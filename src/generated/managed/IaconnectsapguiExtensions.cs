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
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPEnableScripting(Expression<Func<SAPEnableScriptingInput>> sAPEnableScripting)
        {
            var __workflow_sAPEnableScripting = WorkflowExpression.Compile(sAPEnableScripting, nameof(sAPEnableScripting), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPEnableScripting";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPEnableScripting);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPLaunchSAPGUIResponse, ApiConnectionActionConfiguration> SAPLaunchSAPGUI(Expression<Func<SAPLaunchSAPGUIInput>> sAPLaunchSAPGUI)
        {
            var __workflow_sAPLaunchSAPGUI = WorkflowExpression.Compile(sAPLaunchSAPGUI, nameof(sAPLaunchSAPGUI), required: true);
            return new DeferredBodyAction<SAPLaunchSAPGUIResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPLaunchSAPGUI";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPLaunchSAPGUI);
                return new ApiConnectionAction<SAPLaunchSAPGUIResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPAttachToSAPGUIResponse, ApiConnectionActionConfiguration> SAPAttachToSAPGUI(Expression<Func<SAPAttachToSAPGUIInput>> sAPAttachToSAPGUI)
        {
            var __workflow_sAPAttachToSAPGUI = WorkflowExpression.Compile(sAPAttachToSAPGUI, nameof(sAPAttachToSAPGUI), required: true);
            return new DeferredBodyAction<SAPAttachToSAPGUIResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPAttachToSAPGUI";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPAttachToSAPGUI);
                return new ApiConnectionAction<SAPAttachToSAPGUIResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPDetachFromSAPGUI(Expression<Func<SAPDetachFromSAPGUIInput>> sAPDetachFromSAPGUI)
        {
            var __workflow_sAPDetachFromSAPGUI = WorkflowExpression.Compile(sAPDetachFromSAPGUI, nameof(sAPDetachFromSAPGUI), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDetachFromSAPGUI";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPDetachFromSAPGUI);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGUIStatusResponse, ApiConnectionActionConfiguration> SAPGetSAPGUIStatus(Expression<Func<SAPGetSAPGUIStatusInput>> sAPGetSAPGUIStatus)
        {
            var __workflow_sAPGetSAPGUIStatus = WorkflowExpression.Compile(sAPGetSAPGUIStatus, nameof(sAPGetSAPGUIStatus), required: true);
            return new DeferredBodyAction<SAPGetSAPGUIStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGUIStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGUIStatus);
                return new ApiConnectionAction<SAPGetSAPGUIStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPSessionsResponse, ApiConnectionActionConfiguration> SAPGetSAPSessions(Expression<Func<SAPGetSAPSessionsInput>> sAPGetSAPSessions)
        {
            var __workflow_sAPGetSAPSessions = WorkflowExpression.Compile(sAPGetSAPSessions, nameof(sAPGetSAPSessions), required: true);
            return new DeferredBodyAction<SAPGetSAPSessionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPSessions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetSAPSessions);
                return new ApiConnectionAction<SAPGetSAPSessionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPAttachToSessionResponse, ApiConnectionActionConfiguration> SAPAttachToSession(Expression<Func<SAPAttachToSessionInput>> sAPAttachToSession)
        {
            var __workflow_sAPAttachToSession = WorkflowExpression.Compile(sAPAttachToSession, nameof(sAPAttachToSession), required: true);
            return new DeferredBodyAction<SAPAttachToSessionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPAttachToSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPAttachToSession);
                return new ApiConnectionAction<SAPAttachToSessionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPCloseSession(Expression<Func<SAPCloseSessionInput>> sAPCloseSession)
        {
            var __workflow_sAPCloseSession = WorkflowExpression.Compile(sAPCloseSession, nameof(sAPCloseSession), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPCloseSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPCloseSession);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetAttachedSessionPropertiesResponse, ApiConnectionActionConfiguration> SAPGetAttachedSessionProperties(Expression<Func<SAPGetAttachedSessionPropertiesInput>> sAPGetAttachedSessionProperties)
        {
            var __workflow_sAPGetAttachedSessionProperties = WorkflowExpression.Compile(sAPGetAttachedSessionProperties, nameof(sAPGetAttachedSessionProperties), required: true);
            return new DeferredBodyAction<SAPGetAttachedSessionPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetAttachedSessionProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetAttachedSessionProperties);
                return new ApiConnectionAction<SAPGetAttachedSessionPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPWaitForAttachedSessionNotBusyResponse, ApiConnectionActionConfiguration> SAPWaitForAttachedSessionNotBusy(Expression<Func<SAPWaitForAttachedSessionNotBusyInput>> sAPWaitForAttachedSessionNotBusy)
        {
            var __workflow_sAPWaitForAttachedSessionNotBusy = WorkflowExpression.Compile(sAPWaitForAttachedSessionNotBusy, nameof(sAPWaitForAttachedSessionNotBusy), required: true);
            return new DeferredBodyAction<SAPWaitForAttachedSessionNotBusyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWaitForAttachedSessionNotBusy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPWaitForAttachedSessionNotBusy);
                return new ApiConnectionAction<SAPWaitForAttachedSessionNotBusyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPInputTextIntoSAPElement(Expression<Func<SAPInputTextIntoSAPElementInput>> sAPInputTextIntoSAPElement)
        {
            var __workflow_sAPInputTextIntoSAPElement = WorkflowExpression.Compile(sAPInputTextIntoSAPElement, nameof(sAPInputTextIntoSAPElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPInputTextIntoSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPInputTextIntoSAPElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPInputPasswordIntoSAPElement(Expression<Func<SAPInputPasswordIntoSAPElementInput>> sAPInputPasswordIntoSAPElement)
        {
            var __workflow_sAPInputPasswordIntoSAPElement = WorkflowExpression.Compile(sAPInputPasswordIntoSAPElement, nameof(sAPInputPasswordIntoSAPElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPInputPasswordIntoSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPInputPasswordIntoSAPElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetElementPropertiesResponse, ApiConnectionActionConfiguration> SAPGetElementProperties(Expression<Func<SAPGetElementPropertiesInput>> sAPGetElementProperties)
        {
            var __workflow_sAPGetElementProperties = WorkflowExpression.Compile(sAPGetElementProperties, nameof(sAPGetElementProperties), required: true);
            return new DeferredBodyAction<SAPGetElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetElementProperties);
                return new ApiConnectionAction<SAPGetElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPWaitForElementIdResponse, ApiConnectionActionConfiguration> SAPWaitForElementId(Expression<Func<SAPWaitForElementIdInput>> sAPWaitForElementId)
        {
            var __workflow_sAPWaitForElementId = WorkflowExpression.Compile(sAPWaitForElementId, nameof(sAPWaitForElementId), required: true);
            return new DeferredBodyAction<SAPWaitForElementIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWaitForElementId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPWaitForElementId);
                return new ApiConnectionAction<SAPWaitForElementIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPWaitForWindowResponse, ApiConnectionActionConfiguration> SAPWaitForWindow(Expression<Func<SAPWaitForWindowInput>> sAPWaitForWindow)
        {
            var __workflow_sAPWaitForWindow = WorkflowExpression.Compile(sAPWaitForWindow, nameof(sAPWaitForWindow), required: true);
            return new DeferredBodyAction<SAPWaitForWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWaitForWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPWaitForWindow);
                return new ApiConnectionAction<SAPWaitForWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetElementTextValueResponse, ApiConnectionActionConfiguration> SAPGetElementTextValue(Expression<Func<SAPGetElementTextValueInput>> sAPGetElementTextValue)
        {
            var __workflow_sAPGetElementTextValue = WorkflowExpression.Compile(sAPGetElementTextValue, nameof(sAPGetElementTextValue), required: true);
            return new DeferredBodyAction<SAPGetElementTextValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetElementTextValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetElementTextValue);
                return new ApiConnectionAction<SAPGetElementTextValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPPressSAPElement(Expression<Func<SAPPressSAPElementInput>> sAPPressSAPElement)
        {
            var __workflow_sAPPressSAPElement = WorkflowExpression.Compile(sAPPressSAPElement, nameof(sAPPressSAPElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPPressSAPElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSelectSAPElement(Expression<Func<SAPSelectSAPElementInput>> sAPSelectSAPElement)
        {
            var __workflow_sAPSelectSAPElement = WorkflowExpression.Compile(sAPSelectSAPElement, nameof(sAPSelectSAPElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPFocusSAPElement(Expression<Func<SAPFocusSAPElementInput>> sAPFocusSAPElement)
        {
            var __workflow_sAPFocusSAPElement = WorkflowExpression.Compile(sAPFocusSAPElement, nameof(sAPFocusSAPElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPFocusSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPFocusSAPElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPCheckSAPElement(Expression<Func<SAPCheckSAPElementInput>> sAPCheckSAPElement)
        {
            var __workflow_sAPCheckSAPElement = WorkflowExpression.Compile(sAPCheckSAPElement, nameof(sAPCheckSAPElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPCheckSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPCheckSAPElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPVisualiseSAPElement(Expression<Func<SAPVisualiseSAPElementInput>> sAPVisualiseSAPElement)
        {
            var __workflow_sAPVisualiseSAPElement = WorkflowExpression.Compile(sAPVisualiseSAPElement, nameof(sAPVisualiseSAPElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPVisualiseSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPVisualiseSAPElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPDrawRectangleAroundSAPElement(Expression<Func<SAPDrawRectangleAroundSAPElementInput>> sAPDrawRectangleAroundSAPElement)
        {
            var __workflow_sAPDrawRectangleAroundSAPElement = WorkflowExpression.Compile(sAPDrawRectangleAroundSAPElement, nameof(sAPDrawRectangleAroundSAPElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDrawRectangleAroundSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPDrawRectangleAroundSAPElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSendCommand(Expression<Func<SAPSendCommandInput>> sAPSendCommand)
        {
            var __workflow_sAPSendCommand = WorkflowExpression.Compile(sAPSendCommand, nameof(sAPSendCommand), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSendCommand";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSendCommand);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPEnterTCode(Expression<Func<SAPEnterTCodeInput>> sAPEnterTCode)
        {
            var __workflow_sAPEnterTCode = WorkflowExpression.Compile(sAPEnterTCode, nameof(sAPEnterTCode), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPEnterTCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPEnterTCode);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSendVKey(Expression<Func<SAPSendVKeyInput>> sAPSendVKey)
        {
            var __workflow_sAPSendVKey = WorkflowExpression.Compile(sAPSendVKey, nameof(sAPSendVKey), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSendVKey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSendVKey);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSendEnterVKey(Expression<Func<SAPSendEnterVKeyInput>> sAPSendEnterVKey)
        {
            var __workflow_sAPSendEnterVKey = WorkflowExpression.Compile(sAPSendEnterVKey, nameof(sAPSendEnterVKey), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSendEnterVKey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSendEnterVKey);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPWindowRestore(Expression<Func<SAPWindowRestoreInput>> sAPWindowRestore)
        {
            var __workflow_sAPWindowRestore = WorkflowExpression.Compile(sAPWindowRestore, nameof(sAPWindowRestore), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWindowRestore";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPWindowRestore);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPWindowMaximise(Expression<Func<SAPWindowMaximiseInput>> sAPWindowMaximise)
        {
            var __workflow_sAPWindowMaximise = WorkflowExpression.Compile(sAPWindowMaximise, nameof(sAPWindowMaximise), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWindowMaximise";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPWindowMaximise);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPWindowMinimise(Expression<Func<SAPWindowMinimiseInput>> sAPWindowMinimise)
        {
            var __workflow_sAPWindowMinimise = WorkflowExpression.Compile(sAPWindowMinimise, nameof(sAPWindowMinimise), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWindowMinimise";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPWindowMinimise);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPWindowClose(Expression<Func<SAPWindowCloseInput>> sAPWindowClose)
        {
            var __workflow_sAPWindowClose = WorkflowExpression.Compile(sAPWindowClose, nameof(sAPWindowClose), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWindowClose";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPWindowClose);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPBringWindowToFront(Expression<Func<SAPBringWindowToFrontInput>> sAPBringWindowToFront)
        {
            var __workflow_sAPBringWindowToFront = WorkflowExpression.Compile(sAPBringWindowToFront, nameof(sAPBringWindowToFront), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPBringWindowToFront";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPBringWindowToFront);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGlobalLeftMouseClickOnSAPElement(Expression<Func<SAPGlobalLeftMouseClickOnSAPElementInput>> sAPGlobalLeftMouseClickOnSAPElement)
        {
            var __workflow_sAPGlobalLeftMouseClickOnSAPElement = WorkflowExpression.Compile(sAPGlobalLeftMouseClickOnSAPElement, nameof(sAPGlobalLeftMouseClickOnSAPElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalLeftMouseClickOnSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftMouseClickOnSAPElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGlobalRightMouseClickOnSAPElement(Expression<Func<SAPGlobalRightMouseClickOnSAPElementInput>> sAPGlobalRightMouseClickOnSAPElement)
        {
            var __workflow_sAPGlobalRightMouseClickOnSAPElement = WorkflowExpression.Compile(sAPGlobalRightMouseClickOnSAPElement, nameof(sAPGlobalRightMouseClickOnSAPElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalRightMouseClickOnSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightMouseClickOnSAPElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGlobalMiddleMouseClickOnSAPElement(Expression<Func<SAPGlobalMiddleMouseClickOnSAPElementInput>> sAPGlobalMiddleMouseClickOnSAPElement)
        {
            var __workflow_sAPGlobalMiddleMouseClickOnSAPElement = WorkflowExpression.Compile(sAPGlobalMiddleMouseClickOnSAPElement, nameof(sAPGlobalMiddleMouseClickOnSAPElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalMiddleMouseClickOnSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGlobalMiddleMouseClickOnSAPElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGlobalDoubleLeftMouseClickOnSAPElement(Expression<Func<SAPGlobalDoubleLeftMouseClickOnSAPElementInput>> sAPGlobalDoubleLeftMouseClickOnSAPElement)
        {
            var __workflow_sAPGlobalDoubleLeftMouseClickOnSAPElement = WorkflowExpression.Compile(sAPGlobalDoubleLeftMouseClickOnSAPElement, nameof(sAPGlobalDoubleLeftMouseClickOnSAPElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalDoubleLeftMouseClickOnSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftMouseClickOnSAPElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGlobalInputTextIntoSAPElement(Expression<Func<SAPGlobalInputTextIntoSAPElementInput>> sAPGlobalInputTextIntoSAPElement)
        {
            var __workflow_sAPGlobalInputTextIntoSAPElement = WorkflowExpression.Compile(sAPGlobalInputTextIntoSAPElement, nameof(sAPGlobalInputTextIntoSAPElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalInputTextIntoSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputTextIntoSAPElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGlobalInputPasswordIntoSAPElement(Expression<Func<SAPGlobalInputPasswordIntoSAPElementInput>> sAPGlobalInputPasswordIntoSAPElement)
        {
            var __workflow_sAPGlobalInputPasswordIntoSAPElement = WorkflowExpression.Compile(sAPGlobalInputPasswordIntoSAPElement, nameof(sAPGlobalInputPasswordIntoSAPElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalInputPasswordIntoSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGlobalInputPasswordIntoSAPElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSetListSelectionByName(Expression<Func<SAPSetListSelectionByNameInput>> sAPSetListSelectionByName)
        {
            var __workflow_sAPSetListSelectionByName = WorkflowExpression.Compile(sAPSetListSelectionByName, nameof(sAPSetListSelectionByName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetListSelectionByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSetListSelectionByName);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSetListSelectionByKey(Expression<Func<SAPSetListSelectionByKeyInput>> sAPSetListSelectionByKey)
        {
            var __workflow_sAPSetListSelectionByKey = WorkflowExpression.Compile(sAPSetListSelectionByKey, nameof(sAPSetListSelectionByKey), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetListSelectionByKey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSetListSelectionByKey);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetListSelectionElementItemsResponse, ApiConnectionActionConfiguration> SAPGetListSelectionElementItems(Expression<Func<SAPGetListSelectionElementItemsInput>> sAPGetListSelectionElementItems)
        {
            var __workflow_sAPGetListSelectionElementItems = WorkflowExpression.Compile(sAPGetListSelectionElementItems, nameof(sAPGetListSelectionElementItems), required: true);
            return new DeferredBodyAction<SAPGetListSelectionElementItemsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetListSelectionElementItems";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetListSelectionElementItems);
                return new ApiConnectionAction<SAPGetListSelectionElementItemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetAllChildSAPElementPropertiesResponse, ApiConnectionActionConfiguration> SAPGetAllChildSAPElementProperties(Expression<Func<SAPGetAllChildSAPElementPropertiesInput>> sAPGetAllChildSAPElementProperties)
        {
            var __workflow_sAPGetAllChildSAPElementProperties = WorkflowExpression.Compile(sAPGetAllChildSAPElementProperties, nameof(sAPGetAllChildSAPElementProperties), required: true);
            return new DeferredBodyAction<SAPGetAllChildSAPElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetAllChildSAPElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetAllChildSAPElementProperties);
                return new ApiConnectionAction<SAPGetAllChildSAPElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPSessionTopLevelSAPElementPropertiesResponse, ApiConnectionActionConfiguration> SAPGetSAPSessionTopLevelSAPElementProperties(Expression<Func<SAPGetSAPSessionTopLevelSAPElementPropertiesInput>> sAPGetSAPSessionTopLevelSAPElementProperties)
        {
            var __workflow_sAPGetSAPSessionTopLevelSAPElementProperties = WorkflowExpression.Compile(sAPGetSAPSessionTopLevelSAPElementProperties, nameof(sAPGetSAPSessionTopLevelSAPElementProperties), required: true);
            return new DeferredBodyAction<SAPGetSAPSessionTopLevelSAPElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPSessionTopLevelSAPElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetSAPSessionTopLevelSAPElementProperties);
                return new ApiConnectionAction<SAPGetSAPSessionTopLevelSAPElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPElementParentIdResponse, ApiConnectionActionConfiguration> SAPGetSAPElementParentId(Expression<Func<SAPGetSAPElementParentIdInput>> sAPGetSAPElementParentId)
        {
            var __workflow_sAPGetSAPElementParentId = WorkflowExpression.Compile(sAPGetSAPElementParentId, nameof(sAPGetSAPElementParentId), required: true);
            return new DeferredBodyAction<SAPGetSAPElementParentIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPElementParentId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetSAPElementParentId);
                return new ApiConnectionAction<SAPGetSAPElementParentIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetElementPropertiesAsListResponse, ApiConnectionActionConfiguration> SAPGetElementPropertiesAsList(Expression<Func<SAPGetElementPropertiesAsListInput>> sAPGetElementPropertiesAsList)
        {
            var __workflow_sAPGetElementPropertiesAsList = WorkflowExpression.Compile(sAPGetElementPropertiesAsList, nameof(sAPGetElementPropertiesAsList), required: true);
            return new DeferredBodyAction<SAPGetElementPropertiesAsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetElementPropertiesAsList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetElementPropertiesAsList);
                return new ApiConnectionAction<SAPGetElementPropertiesAsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPElementAtScreenCoordinateResponse, ApiConnectionActionConfiguration> SAPGetSAPElementAtScreenCoordinate(Expression<Func<SAPGetSAPElementAtScreenCoordinateInput>> sAPGetSAPElementAtScreenCoordinate)
        {
            var __workflow_sAPGetSAPElementAtScreenCoordinate = WorkflowExpression.Compile(sAPGetSAPElementAtScreenCoordinate, nameof(sAPGetSAPElementAtScreenCoordinate), required: true);
            return new DeferredBodyAction<SAPGetSAPElementAtScreenCoordinateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPElementAtScreenCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetSAPElementAtScreenCoordinate);
                return new ApiConnectionAction<SAPGetSAPElementAtScreenCoordinateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPOpenConnectionResponse, ApiConnectionActionConfiguration> SAPOpenConnection(Expression<Func<SAPOpenConnectionInput>> sAPOpenConnection)
        {
            var __workflow_sAPOpenConnection = WorkflowExpression.Compile(sAPOpenConnection, nameof(sAPOpenConnection), required: true);
            return new DeferredBodyAction<SAPOpenConnectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPOpenConnection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPOpenConnection);
                return new ApiConnectionAction<SAPOpenConnectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPTablePropertiesResponse, ApiConnectionActionConfiguration> SAPGetSAPTableProperties(Expression<Func<SAPGetSAPTablePropertiesInput>> sAPGetSAPTableProperties)
        {
            var __workflow_sAPGetSAPTableProperties = WorkflowExpression.Compile(sAPGetSAPTableProperties, nameof(sAPGetSAPTableProperties), required: true);
            return new DeferredBodyAction<SAPGetSAPTablePropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPTableProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetSAPTableProperties);
                return new ApiConnectionAction<SAPGetSAPTablePropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPTableVisibleCellTextContentsAtIndexResponse, ApiConnectionActionConfiguration> SAPGetSAPTableVisibleCellTextContentsAtIndex(Expression<Func<SAPGetSAPTableVisibleCellTextContentsAtIndexInput>> sAPGetSAPTableVisibleCellTextContentsAtIndex)
        {
            var __workflow_sAPGetSAPTableVisibleCellTextContentsAtIndex = WorkflowExpression.Compile(sAPGetSAPTableVisibleCellTextContentsAtIndex, nameof(sAPGetSAPTableVisibleCellTextContentsAtIndex), required: true);
            return new DeferredBodyAction<SAPGetSAPTableVisibleCellTextContentsAtIndexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPTableVisibleCellTextContentsAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetSAPTableVisibleCellTextContentsAtIndex);
                return new ApiConnectionAction<SAPGetSAPTableVisibleCellTextContentsAtIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPTableVisibleCellPropertiesAtIndexResponse, ApiConnectionActionConfiguration> SAPGetSAPTableVisibleCellPropertiesAtIndex(Expression<Func<SAPGetSAPTableVisibleCellPropertiesAtIndexInput>> sAPGetSAPTableVisibleCellPropertiesAtIndex)
        {
            var __workflow_sAPGetSAPTableVisibleCellPropertiesAtIndex = WorkflowExpression.Compile(sAPGetSAPTableVisibleCellPropertiesAtIndex, nameof(sAPGetSAPTableVisibleCellPropertiesAtIndex), required: true);
            return new DeferredBodyAction<SAPGetSAPTableVisibleCellPropertiesAtIndexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPTableVisibleCellPropertiesAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetSAPTableVisibleCellPropertiesAtIndex);
                return new ApiConnectionAction<SAPGetSAPTableVisibleCellPropertiesAtIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSetSAPTableVisibleCellTextContentsAtIndex(Expression<Func<SAPSetSAPTableVisibleCellTextContentsAtIndexInput>> sAPSetSAPTableVisibleCellTextContentsAtIndex)
        {
            var __workflow_sAPSetSAPTableVisibleCellTextContentsAtIndex = WorkflowExpression.Compile(sAPSetSAPTableVisibleCellTextContentsAtIndex, nameof(sAPSetSAPTableVisibleCellTextContentsAtIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPTableVisibleCellTextContentsAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSetSAPTableVisibleCellTextContentsAtIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPCheckSAPTableVisibleCellCheckboxAtIndex(Expression<Func<SAPCheckSAPTableVisibleCellCheckboxAtIndexInput>> sAPCheckSAPTableVisibleCellCheckboxAtIndex)
        {
            var __workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndex = WorkflowExpression.Compile(sAPCheckSAPTableVisibleCellCheckboxAtIndex, nameof(sAPCheckSAPTableVisibleCellCheckboxAtIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPCheckSAPTableVisibleCellCheckboxAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPCheckSAPTableVisibleCellCheckboxAtIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPPressSAPTableVisibleCellAtIndex(Expression<Func<SAPPressSAPTableVisibleCellAtIndexInput>> sAPPressSAPTableVisibleCellAtIndex)
        {
            var __workflow_sAPPressSAPTableVisibleCellAtIndex = WorkflowExpression.Compile(sAPPressSAPTableVisibleCellAtIndex, nameof(sAPPressSAPTableVisibleCellAtIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressSAPTableVisibleCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPPressSAPTableVisibleCellAtIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPScrollSAPTable(Expression<Func<SAPScrollSAPTableInput>> sAPScrollSAPTable)
        {
            var __workflow_sAPScrollSAPTable = WorkflowExpression.Compile(sAPScrollSAPTable, nameof(sAPScrollSAPTable), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPScrollSAPTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPScrollSAPTable);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTableVisibleTextContentsResponse, ApiConnectionActionConfiguration> SAPGetTableVisibleTextContents(Expression<Func<SAPGetTableVisibleTextContentsInput>> sAPGetTableVisibleTextContents)
        {
            var __workflow_sAPGetTableVisibleTextContents = WorkflowExpression.Compile(sAPGetTableVisibleTextContents, nameof(sAPGetTableVisibleTextContents), required: true);
            return new DeferredBodyAction<SAPGetTableVisibleTextContentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetTableVisibleTextContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetTableVisibleTextContents);
                return new ApiConnectionAction<SAPGetTableVisibleTextContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSelectSAPTableRow(Expression<Func<SAPSelectSAPTableRowInput>> sAPSelectSAPTableRow)
        {
            var __workflow_sAPSelectSAPTableRow = WorkflowExpression.Compile(sAPSelectSAPTableRow, nameof(sAPSelectSAPTableRow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPTableRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPTableRow);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSelectSAPTableColumn(Expression<Func<SAPSelectSAPTableColumnInput>> sAPSelectSAPTableColumn)
        {
            var __workflow_sAPSelectSAPTableColumn = WorkflowExpression.Compile(sAPSelectSAPTableColumn, nameof(sAPSelectSAPTableColumn), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPTableColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPTableColumn);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTreeNodesResponse, ApiConnectionActionConfiguration> SAPGetTreeNodes(Expression<Func<SAPGetTreeNodesInput>> sAPGetTreeNodes)
        {
            var __workflow_sAPGetTreeNodes = WorkflowExpression.Compile(sAPGetTreeNodes, nameof(sAPGetTreeNodes), required: true);
            return new DeferredBodyAction<SAPGetTreeNodesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetTreeNodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetTreeNodes);
                return new ApiConnectionAction<SAPGetTreeNodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPDoubleClickTreeItem(Expression<Func<SAPDoubleClickTreeItemInput>> sAPDoubleClickTreeItem)
        {
            var __workflow_sAPDoubleClickTreeItem = WorkflowExpression.Compile(sAPDoubleClickTreeItem, nameof(sAPDoubleClickTreeItem), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDoubleClickTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPDoubleClickTreeItem);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSelectTreeItem(Expression<Func<SAPSelectTreeItemInput>> sAPSelectTreeItem)
        {
            var __workflow_sAPSelectTreeItem = WorkflowExpression.Compile(sAPSelectTreeItem, nameof(sAPSelectTreeItem), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSelectTreeItem);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPExpandTreeNode(Expression<Func<SAPExpandTreeNodeInput>> sAPExpandTreeNode)
        {
            var __workflow_sAPExpandTreeNode = WorkflowExpression.Compile(sAPExpandTreeNode, nameof(sAPExpandTreeNode), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPExpandTreeNode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPExpandTreeNode);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPDeselectAllTreeNodes(Expression<Func<SAPDeselectAllTreeNodesInput>> sAPDeselectAllTreeNodes)
        {
            var __workflow_sAPDeselectAllTreeNodes = WorkflowExpression.Compile(sAPDeselectAllTreeNodes, nameof(sAPDeselectAllTreeNodes), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDeselectAllTreeNodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPDeselectAllTreeNodes);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPPressKeyOnTree(Expression<Func<SAPPressKeyOnTreeInput>> sAPPressKeyOnTree)
        {
            var __workflow_sAPPressKeyOnTree = WorkflowExpression.Compile(sAPPressKeyOnTree, nameof(sAPPressKeyOnTree), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressKeyOnTree";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPPressKeyOnTree);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPOpenContextMenuOnTreeItem(Expression<Func<SAPOpenContextMenuOnTreeItemInput>> sAPOpenContextMenuOnTreeItem)
        {
            var __workflow_sAPOpenContextMenuOnTreeItem = WorkflowExpression.Compile(sAPOpenContextMenuOnTreeItem, nameof(sAPOpenContextMenuOnTreeItem), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPOpenContextMenuOnTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPOpenContextMenuOnTreeItem);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTreeTextContentsResponse, ApiConnectionActionConfiguration> SAPGetTreeTextContents(Expression<Func<SAPGetTreeTextContentsInput>> sAPGetTreeTextContents)
        {
            var __workflow_sAPGetTreeTextContents = WorkflowExpression.Compile(sAPGetTreeTextContents, nameof(sAPGetTreeTextContents), required: true);
            return new DeferredBodyAction<SAPGetTreeTextContentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetTreeTextContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetTreeTextContents);
                return new ApiConnectionAction<SAPGetTreeTextContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSetTreeColumnWidth(Expression<Func<SAPSetTreeColumnWidthInput>> sAPSetTreeColumnWidth)
        {
            var __workflow_sAPSetTreeColumnWidth = WorkflowExpression.Compile(sAPSetTreeColumnWidth, nameof(sAPSetTreeColumnWidth), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetTreeColumnWidth";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSetTreeColumnWidth);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPPressButtonOnTreeItem(Expression<Func<SAPPressButtonOnTreeItemInput>> sAPPressButtonOnTreeItem)
        {
            var __workflow_sAPPressButtonOnTreeItem = WorkflowExpression.Compile(sAPPressButtonOnTreeItem, nameof(sAPPressButtonOnTreeItem), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressButtonOnTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPPressButtonOnTreeItem);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPClickLinkOnTreeItem(Expression<Func<SAPClickLinkOnTreeItemInput>> sAPClickLinkOnTreeItem)
        {
            var __workflow_sAPClickLinkOnTreeItem = WorkflowExpression.Compile(sAPClickLinkOnTreeItem, nameof(sAPClickLinkOnTreeItem), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPClickLinkOnTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPClickLinkOnTreeItem);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPCheckTreeItem(Expression<Func<SAPCheckTreeItemInput>> sAPCheckTreeItem)
        {
            var __workflow_sAPCheckTreeItem = WorkflowExpression.Compile(sAPCheckTreeItem, nameof(sAPCheckTreeItem), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPCheckTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPCheckTreeItem);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTreeColumnHeadersResponse, ApiConnectionActionConfiguration> SAPGetTreeColumnHeaders(Expression<Func<SAPGetTreeColumnHeadersInput>> sAPGetTreeColumnHeaders)
        {
            var __workflow_sAPGetTreeColumnHeaders = WorkflowExpression.Compile(sAPGetTreeColumnHeaders, nameof(sAPGetTreeColumnHeaders), required: true);
            return new DeferredBodyAction<SAPGetTreeColumnHeadersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetTreeColumnHeaders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetTreeColumnHeaders);
                return new ApiConnectionAction<SAPGetTreeColumnHeadersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetTreeItemPropertiesResponse, ApiConnectionActionConfiguration> SAPGetTreeItemProperties(Expression<Func<SAPGetTreeItemPropertiesInput>> sAPGetTreeItemProperties)
        {
            var __workflow_sAPGetTreeItemProperties = WorkflowExpression.Compile(sAPGetTreeItemProperties, nameof(sAPGetTreeItemProperties), required: true);
            return new DeferredBodyAction<SAPGetTreeItemPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetTreeItemProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetTreeItemProperties);
                return new ApiConnectionAction<SAPGetTreeItemPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetShellToolbarElementsResponse, ApiConnectionActionConfiguration> SAPGetShellToolbarElements(Expression<Func<SAPGetShellToolbarElementsInput>> sAPGetShellToolbarElements)
        {
            var __workflow_sAPGetShellToolbarElements = WorkflowExpression.Compile(sAPGetShellToolbarElements, nameof(sAPGetShellToolbarElements), required: true);
            return new DeferredBodyAction<SAPGetShellToolbarElementsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetShellToolbarElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetShellToolbarElements);
                return new ApiConnectionAction<SAPGetShellToolbarElementsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPPressShellToolbarElement(Expression<Func<SAPPressShellToolbarElementInput>> sAPPressShellToolbarElement)
        {
            var __workflow_sAPPressShellToolbarElement = WorkflowExpression.Compile(sAPPressShellToolbarElement, nameof(sAPPressShellToolbarElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressShellToolbarElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPPressShellToolbarElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPPressShellToolbarElementContextButton(Expression<Func<SAPPressShellToolbarElementContextButtonInput>> sAPPressShellToolbarElementContextButton)
        {
            var __workflow_sAPPressShellToolbarElementContextButton = WorkflowExpression.Compile(sAPPressShellToolbarElementContextButton, nameof(sAPPressShellToolbarElementContextButton), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressShellToolbarElementContextButton";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPPressShellToolbarElementContextButton);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSelectShellToolbarMenuItem(Expression<Func<SAPSelectShellToolbarMenuItemInput>> sAPSelectShellToolbarMenuItem)
        {
            var __workflow_sAPSelectShellToolbarMenuItem = WorkflowExpression.Compile(sAPSelectShellToolbarMenuItem, nameof(sAPSelectShellToolbarMenuItem), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectShellToolbarMenuItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSelectShellToolbarMenuItem);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGridViewPropertiesResponse, ApiConnectionActionConfiguration> SAPGetSAPGridViewProperties(Expression<Func<SAPGetSAPGridViewPropertiesInput>> sAPGetSAPGridViewProperties)
        {
            var __workflow_sAPGetSAPGridViewProperties = WorkflowExpression.Compile(sAPGetSAPGridViewProperties, nameof(sAPGetSAPGridViewProperties), required: true);
            return new DeferredBodyAction<SAPGetSAPGridViewPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGridViewProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGridViewProperties);
                return new ApiConnectionAction<SAPGetSAPGridViewPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGridViewCellContentsAtIndexResponse, ApiConnectionActionConfiguration> SAPGetSAPGridViewCellContentsAtIndex(Expression<Func<SAPGetSAPGridViewCellContentsAtIndexInput>> sAPGetSAPGridViewCellContentsAtIndex)
        {
            var __workflow_sAPGetSAPGridViewCellContentsAtIndex = WorkflowExpression.Compile(sAPGetSAPGridViewCellContentsAtIndex, nameof(sAPGetSAPGridViewCellContentsAtIndex), required: true);
            return new DeferredBodyAction<SAPGetSAPGridViewCellContentsAtIndexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGridViewCellContentsAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGridViewCellContentsAtIndex);
                return new ApiConnectionAction<SAPGetSAPGridViewCellContentsAtIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGridViewCellPropertiesAtIndexResponse, ApiConnectionActionConfiguration> SAPGetSAPGridViewCellPropertiesAtIndex(Expression<Func<SAPGetSAPGridViewCellPropertiesAtIndexInput>> sAPGetSAPGridViewCellPropertiesAtIndex)
        {
            var __workflow_sAPGetSAPGridViewCellPropertiesAtIndex = WorkflowExpression.Compile(sAPGetSAPGridViewCellPropertiesAtIndex, nameof(sAPGetSAPGridViewCellPropertiesAtIndex), required: true);
            return new DeferredBodyAction<SAPGetSAPGridViewCellPropertiesAtIndexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGridViewCellPropertiesAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGridViewCellPropertiesAtIndex);
                return new ApiConnectionAction<SAPGetSAPGridViewCellPropertiesAtIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPDrawRectangleAroundSAPGridViewCellAtIndex(Expression<Func<SAPDrawRectangleAroundSAPGridViewCellAtIndexInput>> sAPDrawRectangleAroundSAPGridViewCellAtIndex)
        {
            var __workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndex = WorkflowExpression.Compile(sAPDrawRectangleAroundSAPGridViewCellAtIndex, nameof(sAPDrawRectangleAroundSAPGridViewCellAtIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDrawRectangleAroundSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPDrawRectangleAroundSAPGridViewCellAtIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGlobalLeftClickSAPGridViewCellAtIndex(Expression<Func<SAPGlobalLeftClickSAPGridViewCellAtIndexInput>> sAPGlobalLeftClickSAPGridViewCellAtIndex)
        {
            var __workflow_sAPGlobalLeftClickSAPGridViewCellAtIndex = WorkflowExpression.Compile(sAPGlobalLeftClickSAPGridViewCellAtIndex, nameof(sAPGlobalLeftClickSAPGridViewCellAtIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalLeftClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGlobalLeftClickSAPGridViewCellAtIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGlobalRightClickSAPGridViewCellAtIndex(Expression<Func<SAPGlobalRightClickSAPGridViewCellAtIndexInput>> sAPGlobalRightClickSAPGridViewCellAtIndex)
        {
            var __workflow_sAPGlobalRightClickSAPGridViewCellAtIndex = WorkflowExpression.Compile(sAPGlobalRightClickSAPGridViewCellAtIndex, nameof(sAPGlobalRightClickSAPGridViewCellAtIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalRightClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGlobalRightClickSAPGridViewCellAtIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGlobalDoubleLeftClickSAPGridViewCellAtIndex(Expression<Func<SAPGlobalDoubleLeftClickSAPGridViewCellAtIndexInput>> sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex)
        {
            var __workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex = WorkflowExpression.Compile(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex, nameof(sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalDoubleLeftClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGlobalDoubleLeftClickSAPGridViewCellAtIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetSAPGridViewColumnHeadersResponse, ApiConnectionActionConfiguration> SAPGetSAPGridViewColumnHeaders(Expression<Func<SAPGetSAPGridViewColumnHeadersInput>> sAPGetSAPGridViewColumnHeaders)
        {
            var __workflow_sAPGetSAPGridViewColumnHeaders = WorkflowExpression.Compile(sAPGetSAPGridViewColumnHeaders, nameof(sAPGetSAPGridViewColumnHeaders), required: true);
            return new DeferredBodyAction<SAPGetSAPGridViewColumnHeadersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGridViewColumnHeaders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetSAPGridViewColumnHeaders);
                return new ApiConnectionAction<SAPGetSAPGridViewColumnHeadersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPClickSAPGridViewCellAtIndex(Expression<Func<SAPClickSAPGridViewCellAtIndexInput>> sAPClickSAPGridViewCellAtIndex)
        {
            var __workflow_sAPClickSAPGridViewCellAtIndex = WorkflowExpression.Compile(sAPClickSAPGridViewCellAtIndex, nameof(sAPClickSAPGridViewCellAtIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPClickSAPGridViewCellAtIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPDoubleClickSAPGridViewCellAtIndex(Expression<Func<SAPDoubleClickSAPGridViewCellAtIndexInput>> sAPDoubleClickSAPGridViewCellAtIndex)
        {
            var __workflow_sAPDoubleClickSAPGridViewCellAtIndex = WorkflowExpression.Compile(sAPDoubleClickSAPGridViewCellAtIndex, nameof(sAPDoubleClickSAPGridViewCellAtIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDoubleClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPDoubleClickSAPGridViewCellAtIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPPressSAPGridViewCellButtonAtIndex(Expression<Func<SAPPressSAPGridViewCellButtonAtIndexInput>> sAPPressSAPGridViewCellButtonAtIndex)
        {
            var __workflow_sAPPressSAPGridViewCellButtonAtIndex = WorkflowExpression.Compile(sAPPressSAPGridViewCellButtonAtIndex, nameof(sAPPressSAPGridViewCellButtonAtIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressSAPGridViewCellButtonAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPPressSAPGridViewCellButtonAtIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPCheckSAPGridViewCellCheckboxAtIndex(Expression<Func<SAPCheckSAPGridViewCellCheckboxAtIndexInput>> sAPCheckSAPGridViewCellCheckboxAtIndex)
        {
            var __workflow_sAPCheckSAPGridViewCellCheckboxAtIndex = WorkflowExpression.Compile(sAPCheckSAPGridViewCellCheckboxAtIndex, nameof(sAPCheckSAPGridViewCellCheckboxAtIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPCheckSAPGridViewCellCheckboxAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPCheckSAPGridViewCellCheckboxAtIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPModifySAPGridViewCellAtIndexResponse, ApiConnectionActionConfiguration> SAPModifySAPGridViewCellAtIndex(Expression<Func<SAPModifySAPGridViewCellAtIndexInput>> sAPModifySAPGridViewCellAtIndex)
        {
            var __workflow_sAPModifySAPGridViewCellAtIndex = WorkflowExpression.Compile(sAPModifySAPGridViewCellAtIndex, nameof(sAPModifySAPGridViewCellAtIndex), required: true);
            return new DeferredBodyAction<SAPModifySAPGridViewCellAtIndexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPModifySAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPModifySAPGridViewCellAtIndex);
                return new ApiConnectionAction<SAPModifySAPGridViewCellAtIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSetSAPGridViewCurrentRow(Expression<Func<SAPSetSAPGridViewCurrentRowInput>> sAPSetSAPGridViewCurrentRow)
        {
            var __workflow_sAPSetSAPGridViewCurrentRow = WorkflowExpression.Compile(sAPSetSAPGridViewCurrentRow, nameof(sAPSetSAPGridViewCurrentRow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewCurrentRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewCurrentRow);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPPressSAPGridViewColumnHeader(Expression<Func<SAPPressSAPGridViewColumnHeaderInput>> sAPPressSAPGridViewColumnHeader)
        {
            var __workflow_sAPPressSAPGridViewColumnHeader = WorkflowExpression.Compile(sAPPressSAPGridViewColumnHeader, nameof(sAPPressSAPGridViewColumnHeader), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressSAPGridViewColumnHeader";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPPressSAPGridViewColumnHeader);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPSetSAPGridViewFirstVisibleRowResponse, ApiConnectionActionConfiguration> SAPSetSAPGridViewFirstVisibleRow(Expression<Func<SAPSetSAPGridViewFirstVisibleRowInput>> sAPSetSAPGridViewFirstVisibleRow)
        {
            var __workflow_sAPSetSAPGridViewFirstVisibleRow = WorkflowExpression.Compile(sAPSetSAPGridViewFirstVisibleRow, nameof(sAPSetSAPGridViewFirstVisibleRow), required: true);
            return new DeferredBodyAction<SAPSetSAPGridViewFirstVisibleRowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewFirstVisibleRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewFirstVisibleRow);
                return new ApiConnectionAction<SAPSetSAPGridViewFirstVisibleRowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSelectSAPGridViewRow(Expression<Func<SAPSelectSAPGridViewRowInput>> sAPSelectSAPGridViewRow)
        {
            var __workflow_sAPSelectSAPGridViewRow = WorkflowExpression.Compile(sAPSelectSAPGridViewRow, nameof(sAPSelectSAPGridViewRow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPGridViewRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPGridViewRow);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSelectSAPGridViewMultipleRows(Expression<Func<SAPSelectSAPGridViewMultipleRowsInput>> sAPSelectSAPGridViewMultipleRows)
        {
            var __workflow_sAPSelectSAPGridViewMultipleRows = WorkflowExpression.Compile(sAPSelectSAPGridViewMultipleRows, nameof(sAPSelectSAPGridViewMultipleRows), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPGridViewMultipleRows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPGridViewMultipleRows);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSetSAPGridViewCurrentColumn(Expression<Func<SAPSetSAPGridViewCurrentColumnInput>> sAPSetSAPGridViewCurrentColumn)
        {
            var __workflow_sAPSetSAPGridViewCurrentColumn = WorkflowExpression.Compile(sAPSetSAPGridViewCurrentColumn, nameof(sAPSetSAPGridViewCurrentColumn), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewCurrentColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewCurrentColumn);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSetSAPGridViewCurrentCell(Expression<Func<SAPSetSAPGridViewCurrentCellInput>> sAPSetSAPGridViewCurrentCell)
        {
            var __workflow_sAPSetSAPGridViewCurrentCell = WorkflowExpression.Compile(sAPSetSAPGridViewCurrentCell, nameof(sAPSetSAPGridViewCurrentCell), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewCurrentCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewCurrentCell);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSelectSAPGridViewColumn(Expression<Func<SAPSelectSAPGridViewColumnInput>> sAPSelectSAPGridViewColumn)
        {
            var __workflow_sAPSelectSAPGridViewColumn = WorkflowExpression.Compile(sAPSelectSAPGridViewColumn, nameof(sAPSelectSAPGridViewColumn), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPGridViewColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSelectSAPGridViewColumn);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGridViewSelectAll(Expression<Func<SAPGridViewSelectAllInput>> sAPGridViewSelectAll)
        {
            var __workflow_sAPGridViewSelectAll = WorkflowExpression.Compile(sAPGridViewSelectAll, nameof(sAPGridViewSelectAll), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGridViewSelectAll";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGridViewSelectAll);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGridViewDeselectAll(Expression<Func<SAPGridViewDeselectAllInput>> sAPGridViewDeselectAll)
        {
            var __workflow_sAPGridViewDeselectAll = WorkflowExpression.Compile(sAPGridViewDeselectAll, nameof(sAPGridViewDeselectAll), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGridViewDeselectAll";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGridViewDeselectAll);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPSetSAPGridViewFirstVisibleColumnResponse, ApiConnectionActionConfiguration> SAPSetSAPGridViewFirstVisibleColumn(Expression<Func<SAPSetSAPGridViewFirstVisibleColumnInput>> sAPSetSAPGridViewFirstVisibleColumn)
        {
            var __workflow_sAPSetSAPGridViewFirstVisibleColumn = WorkflowExpression.Compile(sAPSetSAPGridViewFirstVisibleColumn, nameof(sAPSetSAPGridViewFirstVisibleColumn), required: true);
            return new DeferredBodyAction<SAPSetSAPGridViewFirstVisibleColumnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewFirstVisibleColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSetSAPGridViewFirstVisibleColumn);
                return new ApiConnectionAction<SAPSetSAPGridViewFirstVisibleColumnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPGridViewOpenContextMenu(Expression<Func<SAPGridViewOpenContextMenuInput>> sAPGridViewOpenContextMenu)
        {
            var __workflow_sAPGridViewOpenContextMenu = WorkflowExpression.Compile(sAPGridViewOpenContextMenu, nameof(sAPGridViewOpenContextMenu), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGridViewOpenContextMenu";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGridViewOpenContextMenu);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SAPGetGridViewTextContentsResponse, ApiConnectionActionConfiguration> SAPGetGridViewTextContents(Expression<Func<SAPGetGridViewTextContentsInput>> sAPGetGridViewTextContents)
        {
            var __workflow_sAPGetGridViewTextContents = WorkflowExpression.Compile(sAPGetGridViewTextContents, nameof(sAPGetGridViewTextContents), required: true);
            return new DeferredBodyAction<SAPGetGridViewTextContentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetGridViewTextContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPGetGridViewTextContents);
                return new ApiConnectionAction<SAPGetGridViewTextContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSelectCalendarMonth(Expression<Func<SAPSelectCalendarMonthInput>> sAPSelectCalendarMonth)
        {
            var __workflow_sAPSelectCalendarMonth = WorkflowExpression.Compile(sAPSelectCalendarMonth, nameof(sAPSelectCalendarMonth), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectCalendarMonth";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSelectCalendarMonth);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSelectCalendarWeek(Expression<Func<SAPSelectCalendarWeekInput>> sAPSelectCalendarWeek)
        {
            var __workflow_sAPSelectCalendarWeek = WorkflowExpression.Compile(sAPSelectCalendarWeek, nameof(sAPSelectCalendarWeek), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectCalendarWeek";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSelectCalendarWeek);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPSelectCalendarRange(Expression<Func<SAPSelectCalendarRangeInput>> sAPSelectCalendarRange)
        {
            var __workflow_sAPSelectCalendarRange = WorkflowExpression.Compile(sAPSelectCalendarRange, nameof(sAPSelectCalendarRange), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectCalendarRange";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPSelectCalendarRange);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SAPFocusCalendarDate(Expression<Func<SAPFocusCalendarDateInput>> sAPFocusCalendarDate)
        {
            var __workflow_sAPFocusCalendarDate = WorkflowExpression.Compile(sAPFocusCalendarDate, nameof(sAPFocusCalendarDate), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPFocusCalendarDate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sAPFocusCalendarDate);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class IaconnectsapguiTriggers([ConnectionName] string connectionId)
    {
    }

    public class SAPEnableScriptingInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NotifyWhenScriptAttachesToGUI { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NotifyWhenScriptOpensConnection { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowNativeWindowsDialogs { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPLaunchSAPGUIResponse
    {
        public int SAPGUIMajorVersion { get; set; }
        public int SAPGUIRevision { get; set; }
        public int SAPGUIPatchLevel { get; set; }
        public int SAPGUIMinorVersion { get; set; }
        public bool SAPGUINewVisualDesign { get; set; }
    }

    public class SAPLaunchSAPGUIInput
    {
        public string SAPLogonEXE { get; set; }
        public string SAPLogonArguments { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EnableSAPScripting { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NotifyWhenScriptAttachesToGUI { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NotifyWhenScriptOpensConnection { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowNativeWindowsDialogs { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AttachAfterLaunch { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SecondsToWait { get; set; } = 15;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SAPProgId { get; set; } = "SAPGUI";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DisableSystemMessages { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
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

    public class SAPAttachToSAPGUIInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SAPProgId { get; set; } = "SAPGUI";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DisableSystemMessages { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPDetachFromSAPGUIInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
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

    public class SAPGetSAPGUIStatusInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPGetSAPSessionsResponse
    {
        public int NumberOfSAPConnections { get; set; }
        public string SAPConnectionsJSON { get; set; }
        public int NumberOfSAPSessions { get; set; }
        public string SAPSessionsJSON { get; set; }
    }

    public class SAPGetSAPSessionsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPAttachToSessionResponse
    {
        public string AttachedConnectionName { get; set; }
        public string AttachedSessionName { get; set; }
    }

    public class SAPAttachToSessionInput
    {
        public string SearchConnectionName { get; set; }
        public string SearchSessionName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPCloseSessionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CloseAttachedSession { get; set; } = true;
        public string SearchConnectionName { get; set; }
        public string SearchSessionName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
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

    public class SAPGetAttachedSessionPropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPWaitForAttachedSessionNotBusyResponse
    {
        public bool BusyAfterWait { get; set; }
    }

    public class SAPWaitForAttachedSessionNotBusyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double SecondsToWait { get; set; } = 15;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfBusyAfterWait { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPInputTextIntoSAPElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }
        public string TextToInput { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReplaceExistingValue { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? InsertPosition { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPInputPasswordIntoSAPElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PasswordToInput { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
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

    public class SAPGetElementPropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPWaitForElementIdResponse
    {
        public bool SAPElementExists { get; set; }
        public string SAPElementType { get; set; }
        public int SAPElementTypeCode { get; set; }
        public string SAPElementName { get; set; }
        public string SAPElementSubType { get; set; }
    }

    public class SAPWaitForElementIdInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SecondsToWait { get; set; } = 15;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfElementNotFound { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
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

    public class SAPWaitForWindowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPWindowTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SecondsToWait { get; set; } = 15;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfElementNotFound { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPGetElementTextValueResponse
    {
        public string SAPElementTextValue { get; set; }
        public string SAPElementMessageType { get; set; }
    }

    public class SAPGetElementTextValueInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPPressSAPElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSelectSAPElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPFocusSAPElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPCheckSAPElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPVisualiseSAPElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? VisualiseOn { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPDrawRectangleAroundSAPElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PenColour { get; set; } = "#009FDE";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? PenThicknessPixels { get; set; } = 4;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSendCommandInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SAPCommand { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPEnterTCodeInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SAPTCode { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSendVKeyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SAPVKey { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DetectParentWindowElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSendEnterVKeyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DetectParentWindowElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPWindowRestoreInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DetectParentWindowElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPWindowMaximiseInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DetectParentWindowElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPWindowMinimiseInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DetectParentWindowElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPWindowCloseInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DetectParentWindowElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPBringWindowToFrontInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleWindow { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleUsesGlobalLeftMouseClickAgent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? ToggleDelay { get; set; } = 0.5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DetectParentWindowElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPGlobalLeftMouseClickOnSAPElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SetElementWindowTopMost { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BringElementWindowToFront { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleWindow { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleUsesGlobalLeftMouseClickAgent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? ToggleDelay { get; set; } = 0.5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetX { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetY { get; set; } = 0;
        public SAPGlobalLeftMouseClickOnSAPElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SAPGlobalLeftMouseClickOnSAPElementInputOffsetRelativeToType
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

    public class SAPGlobalRightMouseClickOnSAPElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SetElementWindowTopMost { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BringElementWindowToFront { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleWindow { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleUsesGlobalLeftMouseClickAgent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? ToggleDelay { get; set; } = 0.5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetX { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetY { get; set; } = 0;
        public SAPGlobalRightMouseClickOnSAPElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SAPGlobalRightMouseClickOnSAPElementInputOffsetRelativeToType
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

    public class SAPGlobalMiddleMouseClickOnSAPElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SetElementWindowTopMost { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BringElementWindowToFront { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleWindow { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleUsesGlobalLeftMouseClickAgent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? ToggleDelay { get; set; } = 0.5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetX { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetY { get; set; } = 0;
        public SAPGlobalMiddleMouseClickOnSAPElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SAPGlobalMiddleMouseClickOnSAPElementInputOffsetRelativeToType
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

    public class SAPGlobalDoubleLeftMouseClickOnSAPElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SetElementWindowTopMost { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BringElementWindowToFront { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleWindow { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleUsesGlobalLeftMouseClickAgent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? ToggleDelay { get; set; } = 0.5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetX { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetY { get; set; } = 0;
        public SAPGlobalDoubleLeftMouseClickOnSAPElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DoubleClickDelayInMilliseconds { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SAPGlobalDoubleLeftMouseClickOnSAPElementInputOffsetRelativeToType
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

    public class SAPGlobalInputTextIntoSAPElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SetElementWindowTopMost { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BringElementWindowToFront { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleWindow { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleUsesGlobalLeftMouseClickAgent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? ToggleDelay { get; set; } = 0.5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? GlobalMouseClickOnElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReplaceExistingValueUsingDoubleClickDelete { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReplaceExistingValueUsingCTRLADelete { get; set; } = false;
        public string TextToInput { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SendKeyEvents { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? KeyIntervalInMilliseconds { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DoubleClickIntervalInMilliseconds { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DontInterpretSymbols { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPGlobalInputPasswordIntoSAPElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SetElementWindowTopMost { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BringElementWindowToFront { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleWindow { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleUsesGlobalLeftMouseClickAgent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? ToggleDelay { get; set; } = 0.5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? GlobalMouseClickOnElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReplaceExistingValueUsingDoubleClickDelete { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReplaceExistingValueUsingCTRLADelete { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PasswordToInput { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SendKeyEvents { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? KeyIntervalInMilliseconds { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DoubleClickIntervalInMilliseconds { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DontInterpretSymbols { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSetListSelectionByNameInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListItemName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSetListSelectionByKeyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListItemKey { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPGetListSelectionElementItemsResponse
    {
        public int NumberOfItemsInList { get; set; }
        public string SAPSelectionListItemsJSON { get; set; }
        public string CurrentlySelectedValue { get; set; }
        public string CurrentlySelectedKey { get; set; }
        public bool ValueRequired { get; set; }
    }

    public class SAPGetListSelectionElementItemsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPGetAllChildSAPElementPropertiesResponse
    {
        public int NumberOfChildElementsReturned { get; set; }
        public bool MoreElementsAvailableAtCurrentDepth { get; set; }
        public string SAPChildElementsJSON { get; set; }
    }

    public class SAPGetAllChildSAPElementPropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstItemToReturn { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxItemsToReturn { get; set; } = 0;
        public string SearchSAPElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxTextLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPGetSAPSessionTopLevelSAPElementPropertiesResponse
    {
        public int NumberOfChildElementsReturned { get; set; }
        public bool MoreElementsAvailableAtCurrentDepth { get; set; }
        public string SAPChildElementsJSON { get; set; }
    }

    public class SAPGetSAPSessionTopLevelSAPElementPropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstItemToReturn { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxItemsToReturn { get; set; } = 0;
        public string SearchSAPElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxTextLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPGetSAPElementParentIdResponse
    {
        public string SAPParentElementId { get; set; }
        public string SAPParentElementType { get; set; }
        public int SAPParentElementTypeCode { get; set; }
    }

    public class SAPGetSAPElementParentIdInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPGetElementPropertiesAsListResponse
    {
        public int NumberOfElementsReturned { get; set; }
        public string SAPElementsJSON { get; set; }
    }

    public class SAPGetElementPropertiesAsListInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxTextLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPGetSAPElementAtScreenCoordinateResponse
    {
        public string SAPElementId { get; set; }
    }

    public class SAPGetSAPElementAtScreenCoordinateInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ScreenX { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ScreenY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPOpenConnectionResponse
    {
        public string OpenedConnectionName { get; set; }
        public bool ScriptingDisabledByServer { get; set; }
        public int NumberOfSAPSessions { get; set; }
        public string ConnectedSessionName { get; set; }
    }

    public class SAPOpenConnectionInput
    {
        public string SAPConnectionDescription { get; set; }
        public string SAPConnectionAddress { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ConnectSynchronous { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ConnectToSession { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
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

    public class SAPGetSAPTablePropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
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

    public class SAPGetSAPTableVisibleCellTextContentsAtIndexInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VisibleRowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VisibleColumnIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CheckedElementValue { get; set; } = "True";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
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

    public class SAPGetSAPTableVisibleCellPropertiesAtIndexInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VisibleRowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VisibleColumnIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSetSAPTableVisibleCellTextContentsAtIndexInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VisibleRowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VisibleColumnIndex { get; set; } = 1;
        public string TextToInput { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReplaceExistingValue { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? InsertPosition { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPCheckSAPTableVisibleCellCheckboxAtIndexInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VisibleRowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VisibleColumnIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckCellElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPPressSAPTableVisibleCellAtIndexInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VisibleRowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VisibleColumnIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPScrollSAPTableInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MoveHorizontalScrollbar { get; set; } = false;
        public int? HorizontalScrollbarPosition { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MoveVerticalScrollbar { get; set; } = false;
        public int? VerticalScrollbarPosition { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPGetTableVisibleTextContentsResponse
    {
        public string SAPTableTextContentsJSON { get; set; }
        public int NumberOfRowsReturned { get; set; }
        public int NumberOfColumnsReturned { get; set; }
    }

    public class SAPGetTableVisibleTextContentsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstVisibleRowToReturn { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRowsToReturn { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstVisibleColumnToReturn { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxColumnsToReturn { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseColumnHeadersFromTable { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnRowIndexInOutputCollection { get; set; } = false;
        public string NameOfColumnToStoreRowIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CheckedElementValue { get; set; } = "True";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSelectSAPTableRowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VisibleRowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Select { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSelectSAPTableColumnInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VisibleColumnIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Select { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
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

    public class SAPGetTreeNodesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }
        public string ParentNodeKey { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ProcessSubNodes { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPDoubleClickTreeItemInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }
        public string SearchNodeKey { get; set; }
        public string SearchNodePath { get; set; }
        public string SearchNodeText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchNodeTextIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchNodeTextIsCaseSensitive { get; set; } = false;
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSelectTreeItemInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }
        public string SearchNodeKey { get; set; }
        public string SearchNodePath { get; set; }
        public string SearchNodeText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchNodeTextIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchNodeTextIsCaseSensitive { get; set; } = false;
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Select { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeselectAllFirst { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPExpandTreeNodeInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }
        public string SearchNodeKey { get; set; }
        public string SearchNodePath { get; set; }
        public string SearchNodeText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchNodeTextIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchNodeTextIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Expand { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPDeselectAllTreeNodesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPPressKeyOnTreeInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPOpenContextMenuOnTreeItemInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }
        public string SearchNodeKey { get; set; }
        public string SearchNodePath { get; set; }
        public string SearchNodeText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchNodeTextIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchNodeTextIsCaseSensitive { get; set; } = false;
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPGetTreeTextContentsResponse
    {
        public string SAPTreeTextContentsJSON { get; set; }
        public int NumberOfRowsReturned { get; set; }
        public int NumberOfColumnsReturned { get; set; }
    }

    public class SAPGetTreeTextContentsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstRowToReturn { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRowsToReturn { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstColumnToReturn { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxColumnsToReturn { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseColumnHeadersFromTree { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnRowIndexInOutputCollection { get; set; } = false;
        public string NameOfColumnToStoreRowIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSetTreeColumnWidthInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ColumnWidthInPixels { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPPressButtonOnTreeItemInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }
        public string SearchNodeKey { get; set; }
        public string SearchNodePath { get; set; }
        public string SearchNodeText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchNodeTextIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchNodeTextIsCaseSensitive { get; set; } = false;
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Force { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPClickLinkOnTreeItemInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }
        public string SearchNodeKey { get; set; }
        public string SearchNodePath { get; set; }
        public string SearchNodeText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchNodeTextIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchNodeTextIsCaseSensitive { get; set; } = false;
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Force { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPCheckTreeItemInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }
        public string SearchNodeKey { get; set; }
        public string SearchNodePath { get; set; }
        public string SearchNodeText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchNodeTextIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchNodeTextIsCaseSensitive { get; set; } = false;
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckItem { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Force { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPGetTreeColumnHeadersResponse
    {
        public string SAPTreeColumnHeadersJSON { get; set; }
        public int NumberOfColumnHeaders { get; set; }
    }

    public class SAPGetTreeColumnHeadersInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
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

    public class SAPGetTreeItemPropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }
        public string SearchNodeKey { get; set; }
        public string SearchNodePath { get; set; }
        public string SearchNodeText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchNodeTextIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchNodeTextIsCaseSensitive { get; set; } = false;
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPGetShellToolbarElementsResponse
    {
        public int NumberOfToolbarButtons { get; set; }
        public string SAPShellToolbarElementsJSON { get; set; }
    }

    public class SAPGetShellToolbarElementsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPPressShellToolbarElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }
        public string SearchToolbarElementId { get; set; }
        public string SearchToolbarElementText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchToolbarElementIndex { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchToolbarTextIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchToolbarTextIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPPressShellToolbarElementContextButtonInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }
        public string SearchToolbarElementId { get; set; }
        public string SearchToolbarElementText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchToolbarElementIndex { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchToolbarTextIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchToolbarTextIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSelectShellToolbarMenuItemInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }
        public string SearchToolbarElementId { get; set; }
        public string SearchToolbarElementText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchToolbarElementIndex { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchToolbarTextIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchToolbarTextIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
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

    public class SAPGetSAPGridViewPropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPGetSAPGridViewCellContentsAtIndexResponse
    {
        public string CellTextContents { get; set; }
        public bool CellIsChangeable { get; set; }
        public string CellType { get; set; }
        public bool CellIsChecked { get; set; }
    }

    public class SAPGetSAPGridViewCellContentsAtIndexInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
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

    public class SAPGetSAPGridViewCellPropertiesAtIndexInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPDrawRectangleAroundSAPGridViewCellAtIndexInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PenColour { get; set; } = "#009FDE";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? PenThicknessPixels { get; set; } = 4;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPGlobalLeftClickSAPGridViewCellAtIndexInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SetElementWindowTopMost { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BringElementWindowToFront { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleWindow { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleUsesGlobalLeftMouseClickAgent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? ToggleDelay { get; set; } = 0.5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetX { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetY { get; set; } = 0;
        public SAPGlobalLeftClickSAPGridViewCellAtIndexInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SAPGlobalLeftClickSAPGridViewCellAtIndexInputOffsetRelativeToType
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

    public class SAPGlobalRightClickSAPGridViewCellAtIndexInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SetElementWindowTopMost { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BringElementWindowToFront { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleWindow { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleUsesGlobalLeftMouseClickAgent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? ToggleDelay { get; set; } = 0.5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetX { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetY { get; set; } = 0;
        public SAPGlobalRightClickSAPGridViewCellAtIndexInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SAPGlobalRightClickSAPGridViewCellAtIndexInputOffsetRelativeToType
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

    public class SAPGlobalDoubleLeftClickSAPGridViewCellAtIndexInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SetElementWindowTopMost { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? BringElementWindowToFront { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleWindow { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleUsesGlobalLeftMouseClickAgent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? ToggleDelay { get; set; } = 0.5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetX { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetY { get; set; } = 0;
        public SAPGlobalDoubleLeftClickSAPGridViewCellAtIndexInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DoubleClickDelayInMilliseconds { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SAPGlobalDoubleLeftClickSAPGridViewCellAtIndexInputOffsetRelativeToType
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

    public class SAPGetSAPGridViewColumnHeadersInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPClickSAPGridViewCellAtIndexInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPDoubleClickSAPGridViewCellAtIndexInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPPressSAPGridViewCellButtonAtIndexInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPCheckSAPGridViewCellCheckboxAtIndexInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckCellElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPModifySAPGridViewCellAtIndexResponse
    {
        public string ModifiedValue { get; set; }
    }

    public class SAPModifySAPGridViewCellAtIndexInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;
        public string NewValue { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSetSAPGridViewCurrentRowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPPressSAPGridViewColumnHeaderInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSetSAPGridViewFirstVisibleRowResponse
    {
        public int ActualFirstVisibleRowIndex { get; set; }
    }

    public class SAPSetSAPGridViewFirstVisibleRowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int FirstVisibleRowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSelectSAPGridViewRowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SetAsCurrentRow { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSelectSAPGridViewMultipleRowsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string RowsToSelect { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSetSAPGridViewCurrentColumnInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSetSAPGridViewCurrentCellInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSelectSAPGridViewColumnInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SelectColumn { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SetAsCurrentColumn { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ClearSelectionFirst { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPGridViewSelectAllInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPGridViewDeselectAllInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSetSAPGridViewFirstVisibleColumnResponse
    {
        public string ActualFirstVisibleColumnName { get; set; }
    }

    public class SAPSetSAPGridViewFirstVisibleColumnInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPGridViewOpenContextMenuInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPGetGridViewTextContentsResponse
    {
        public string SAPGridViewTextContentsJSON { get; set; }
        public int NumberOfRowsReturned { get; set; }
        public int NumberOfColumnsReturned { get; set; }
    }

    public class SAPGetGridViewTextContentsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstRowToReturn { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRowsToReturn { get; set; } = 0;
        public string FirstSearchColumnName { get; set; }
        public string FirstSearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FirstSearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FirstSearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxColumnsToReturn { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseColumnHeadersFromTable { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnRowIndexInOutputCollection { get; set; } = false;
        public string NameOfColumnToStoreRowIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CheckedElementValue { get; set; } = "True";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSelectCalendarMonthInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Month { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Year { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSelectCalendarWeekInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Week { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Year { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPSelectCalendarRangeInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FromDateYYYYMMDD { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ToDateYYYYMMDD { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SAPFocusCalendarDateInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSAPElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DateYYYYMMDD { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
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