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
        public IWorkflowAction<ApiConnectionActionConfiguration> SapEnableScripting(Expression<Func<SapEnableScriptingInput>> sapEnableScripting)
        {
            var __workflow_sapEnableScripting = WorkflowExpression.Compile(sapEnableScripting, nameof(sapEnableScripting), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPEnableScripting";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapEnableScripting);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapLaunchSapguiResponse, ApiConnectionActionConfiguration> SapLaunchSapgui(Expression<Func<SapLaunchSapguiInput>> sapLaunchSapgui)
        {
            var __workflow_sapLaunchSapgui = WorkflowExpression.Compile(sapLaunchSapgui, nameof(sapLaunchSapgui), required: true);
            return new DeferredBodyAction<SapLaunchSapguiResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPLaunchSAPGUI";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapLaunchSapgui);
                return new ApiConnectionAction<SapLaunchSapguiResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapAttachToSapguiResponse, ApiConnectionActionConfiguration> SapAttachToSapgui(Expression<Func<SapAttachToSapguiInput>> sapAttachToSapgui)
        {
            var __workflow_sapAttachToSapgui = WorkflowExpression.Compile(sapAttachToSapgui, nameof(sapAttachToSapgui), required: true);
            return new DeferredBodyAction<SapAttachToSapguiResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPAttachToSAPGUI";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapAttachToSapgui);
                return new ApiConnectionAction<SapAttachToSapguiResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapDetachFromSapgui(Expression<Func<SapDetachFromSapguiInput>> sapDetachFromSapgui)
        {
            var __workflow_sapDetachFromSapgui = WorkflowExpression.Compile(sapDetachFromSapgui, nameof(sapDetachFromSapgui), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDetachFromSAPGUI";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapDetachFromSapgui);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetSapguiStatusResponse, ApiConnectionActionConfiguration> SapGetSapguiStatus(Expression<Func<SapGetSapguiStatusInput>> sapGetSapguiStatus)
        {
            var __workflow_sapGetSapguiStatus = WorkflowExpression.Compile(sapGetSapguiStatus, nameof(sapGetSapguiStatus), required: true);
            return new DeferredBodyAction<SapGetSapguiStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGUIStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetSapguiStatus);
                return new ApiConnectionAction<SapGetSapguiStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetSapSessionsResponse, ApiConnectionActionConfiguration> SapGetSapSessions(Expression<Func<SapGetSapSessionsInput>> sapGetSapSessions)
        {
            var __workflow_sapGetSapSessions = WorkflowExpression.Compile(sapGetSapSessions, nameof(sapGetSapSessions), required: true);
            return new DeferredBodyAction<SapGetSapSessionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPSessions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetSapSessions);
                return new ApiConnectionAction<SapGetSapSessionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapAttachToSessionResponse, ApiConnectionActionConfiguration> SapAttachToSession(Expression<Func<SapAttachToSessionInput>> sapAttachToSession)
        {
            var __workflow_sapAttachToSession = WorkflowExpression.Compile(sapAttachToSession, nameof(sapAttachToSession), required: true);
            return new DeferredBodyAction<SapAttachToSessionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPAttachToSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapAttachToSession);
                return new ApiConnectionAction<SapAttachToSessionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapCloseSession(Expression<Func<SapCloseSessionInput>> sapCloseSession)
        {
            var __workflow_sapCloseSession = WorkflowExpression.Compile(sapCloseSession, nameof(sapCloseSession), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPCloseSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapCloseSession);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetAttachedSessionPropertiesResponse, ApiConnectionActionConfiguration> SapGetAttachedSessionProperties(Expression<Func<SapGetAttachedSessionPropertiesInput>> sapGetAttachedSessionProperties)
        {
            var __workflow_sapGetAttachedSessionProperties = WorkflowExpression.Compile(sapGetAttachedSessionProperties, nameof(sapGetAttachedSessionProperties), required: true);
            return new DeferredBodyAction<SapGetAttachedSessionPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetAttachedSessionProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetAttachedSessionProperties);
                return new ApiConnectionAction<SapGetAttachedSessionPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapWaitForAttachedSessionNotBusyResponse, ApiConnectionActionConfiguration> SapWaitForAttachedSessionNotBusy(Expression<Func<SapWaitForAttachedSessionNotBusyInput>> sapWaitForAttachedSessionNotBusy)
        {
            var __workflow_sapWaitForAttachedSessionNotBusy = WorkflowExpression.Compile(sapWaitForAttachedSessionNotBusy, nameof(sapWaitForAttachedSessionNotBusy), required: true);
            return new DeferredBodyAction<SapWaitForAttachedSessionNotBusyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWaitForAttachedSessionNotBusy";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapWaitForAttachedSessionNotBusy);
                return new ApiConnectionAction<SapWaitForAttachedSessionNotBusyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapInputTextIntoSapElement(Expression<Func<SapInputTextIntoSapElementInput>> sapInputTextIntoSapElement)
        {
            var __workflow_sapInputTextIntoSapElement = WorkflowExpression.Compile(sapInputTextIntoSapElement, nameof(sapInputTextIntoSapElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPInputTextIntoSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapInputTextIntoSapElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapInputPasswordIntoSapElement(Expression<Func<SapInputPasswordIntoSapElementInput>> sapInputPasswordIntoSapElement)
        {
            var __workflow_sapInputPasswordIntoSapElement = WorkflowExpression.Compile(sapInputPasswordIntoSapElement, nameof(sapInputPasswordIntoSapElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPInputPasswordIntoSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapInputPasswordIntoSapElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetElementPropertiesResponse, ApiConnectionActionConfiguration> SapGetElementProperties(Expression<Func<SapGetElementPropertiesInput>> sapGetElementProperties)
        {
            var __workflow_sapGetElementProperties = WorkflowExpression.Compile(sapGetElementProperties, nameof(sapGetElementProperties), required: true);
            return new DeferredBodyAction<SapGetElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetElementProperties);
                return new ApiConnectionAction<SapGetElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapWaitForElementIdResponse, ApiConnectionActionConfiguration> SapWaitForElementId(Expression<Func<SapWaitForElementIdInput>> sapWaitForElementId)
        {
            var __workflow_sapWaitForElementId = WorkflowExpression.Compile(sapWaitForElementId, nameof(sapWaitForElementId), required: true);
            return new DeferredBodyAction<SapWaitForElementIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWaitForElementId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapWaitForElementId);
                return new ApiConnectionAction<SapWaitForElementIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapWaitForWindowResponse, ApiConnectionActionConfiguration> SapWaitForWindow(Expression<Func<SapWaitForWindowInput>> sapWaitForWindow)
        {
            var __workflow_sapWaitForWindow = WorkflowExpression.Compile(sapWaitForWindow, nameof(sapWaitForWindow), required: true);
            return new DeferredBodyAction<SapWaitForWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWaitForWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapWaitForWindow);
                return new ApiConnectionAction<SapWaitForWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetElementTextValueResponse, ApiConnectionActionConfiguration> SapGetElementTextValue(Expression<Func<SapGetElementTextValueInput>> sapGetElementTextValue)
        {
            var __workflow_sapGetElementTextValue = WorkflowExpression.Compile(sapGetElementTextValue, nameof(sapGetElementTextValue), required: true);
            return new DeferredBodyAction<SapGetElementTextValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetElementTextValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetElementTextValue);
                return new ApiConnectionAction<SapGetElementTextValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapPressSapElement(Expression<Func<SapPressSapElementInput>> sapPressSapElement)
        {
            var __workflow_sapPressSapElement = WorkflowExpression.Compile(sapPressSapElement, nameof(sapPressSapElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapPressSapElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapSelectSapElement(Expression<Func<SapSelectSapElementInput>> sapSelectSapElement)
        {
            var __workflow_sapSelectSapElement = WorkflowExpression.Compile(sapSelectSapElement, nameof(sapSelectSapElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSelectSapElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapFocusSapElement(Expression<Func<SapFocusSapElementInput>> sapFocusSapElement)
        {
            var __workflow_sapFocusSapElement = WorkflowExpression.Compile(sapFocusSapElement, nameof(sapFocusSapElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPFocusSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapFocusSapElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapCheckSapElement(Expression<Func<SapCheckSapElementInput>> sapCheckSapElement)
        {
            var __workflow_sapCheckSapElement = WorkflowExpression.Compile(sapCheckSapElement, nameof(sapCheckSapElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPCheckSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapCheckSapElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapVisualiseSapElement(Expression<Func<SapVisualiseSapElementInput>> sapVisualiseSapElement)
        {
            var __workflow_sapVisualiseSapElement = WorkflowExpression.Compile(sapVisualiseSapElement, nameof(sapVisualiseSapElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPVisualiseSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapVisualiseSapElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapDrawRectangleAroundSapElement(Expression<Func<SapDrawRectangleAroundSapElementInput>> sapDrawRectangleAroundSapElement)
        {
            var __workflow_sapDrawRectangleAroundSapElement = WorkflowExpression.Compile(sapDrawRectangleAroundSapElement, nameof(sapDrawRectangleAroundSapElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDrawRectangleAroundSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapDrawRectangleAroundSapElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapSendCommand(Expression<Func<SapSendCommandInput>> sapSendCommand)
        {
            var __workflow_sapSendCommand = WorkflowExpression.Compile(sapSendCommand, nameof(sapSendCommand), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSendCommand";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSendCommand);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapEnterTCode(Expression<Func<SapEnterTCodeInput>> sapEnterTCode)
        {
            var __workflow_sapEnterTCode = WorkflowExpression.Compile(sapEnterTCode, nameof(sapEnterTCode), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPEnterTCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapEnterTCode);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapSendVKey(Expression<Func<SapSendVKeyInput>> sapSendVKey)
        {
            var __workflow_sapSendVKey = WorkflowExpression.Compile(sapSendVKey, nameof(sapSendVKey), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSendVKey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSendVKey);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapSendEnterVKey(Expression<Func<SapSendEnterVKeyInput>> sapSendEnterVKey)
        {
            var __workflow_sapSendEnterVKey = WorkflowExpression.Compile(sapSendEnterVKey, nameof(sapSendEnterVKey), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSendEnterVKey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSendEnterVKey);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapWindowRestore(Expression<Func<SapWindowRestoreInput>> sapWindowRestore)
        {
            var __workflow_sapWindowRestore = WorkflowExpression.Compile(sapWindowRestore, nameof(sapWindowRestore), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWindowRestore";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapWindowRestore);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapWindowMaximise(Expression<Func<SapWindowMaximiseInput>> sapWindowMaximise)
        {
            var __workflow_sapWindowMaximise = WorkflowExpression.Compile(sapWindowMaximise, nameof(sapWindowMaximise), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWindowMaximise";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapWindowMaximise);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapWindowMinimise(Expression<Func<SapWindowMinimiseInput>> sapWindowMinimise)
        {
            var __workflow_sapWindowMinimise = WorkflowExpression.Compile(sapWindowMinimise, nameof(sapWindowMinimise), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWindowMinimise";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapWindowMinimise);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapWindowClose(Expression<Func<SapWindowCloseInput>> sapWindowClose)
        {
            var __workflow_sapWindowClose = WorkflowExpression.Compile(sapWindowClose, nameof(sapWindowClose), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPWindowClose";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapWindowClose);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapBringWindowToFront(Expression<Func<SapBringWindowToFrontInput>> sapBringWindowToFront)
        {
            var __workflow_sapBringWindowToFront = WorkflowExpression.Compile(sapBringWindowToFront, nameof(sapBringWindowToFront), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPBringWindowToFront";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapBringWindowToFront);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapGlobalLeftMouseClickOnSapElement(Expression<Func<SapGlobalLeftMouseClickOnSapElementInput>> sapGlobalLeftMouseClickOnSapElement)
        {
            var __workflow_sapGlobalLeftMouseClickOnSapElement = WorkflowExpression.Compile(sapGlobalLeftMouseClickOnSapElement, nameof(sapGlobalLeftMouseClickOnSapElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalLeftMouseClickOnSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGlobalLeftMouseClickOnSapElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapGlobalRightMouseClickOnSapElement(Expression<Func<SapGlobalRightMouseClickOnSapElementInput>> sapGlobalRightMouseClickOnSapElement)
        {
            var __workflow_sapGlobalRightMouseClickOnSapElement = WorkflowExpression.Compile(sapGlobalRightMouseClickOnSapElement, nameof(sapGlobalRightMouseClickOnSapElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalRightMouseClickOnSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGlobalRightMouseClickOnSapElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapGlobalMiddleMouseClickOnSapElement(Expression<Func<SapGlobalMiddleMouseClickOnSapElementInput>> sapGlobalMiddleMouseClickOnSapElement)
        {
            var __workflow_sapGlobalMiddleMouseClickOnSapElement = WorkflowExpression.Compile(sapGlobalMiddleMouseClickOnSapElement, nameof(sapGlobalMiddleMouseClickOnSapElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalMiddleMouseClickOnSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGlobalMiddleMouseClickOnSapElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapGlobalDoubleLeftMouseClickOnSapElement(Expression<Func<SapGlobalDoubleLeftMouseClickOnSapElementInput>> sapGlobalDoubleLeftMouseClickOnSapElement)
        {
            var __workflow_sapGlobalDoubleLeftMouseClickOnSapElement = WorkflowExpression.Compile(sapGlobalDoubleLeftMouseClickOnSapElement, nameof(sapGlobalDoubleLeftMouseClickOnSapElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalDoubleLeftMouseClickOnSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGlobalDoubleLeftMouseClickOnSapElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapGlobalInputTextIntoSapElement(Expression<Func<SapGlobalInputTextIntoSapElementInput>> sapGlobalInputTextIntoSapElement)
        {
            var __workflow_sapGlobalInputTextIntoSapElement = WorkflowExpression.Compile(sapGlobalInputTextIntoSapElement, nameof(sapGlobalInputTextIntoSapElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalInputTextIntoSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGlobalInputTextIntoSapElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapGlobalInputPasswordIntoSapElement(Expression<Func<SapGlobalInputPasswordIntoSapElementInput>> sapGlobalInputPasswordIntoSapElement)
        {
            var __workflow_sapGlobalInputPasswordIntoSapElement = WorkflowExpression.Compile(sapGlobalInputPasswordIntoSapElement, nameof(sapGlobalInputPasswordIntoSapElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalInputPasswordIntoSAPElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGlobalInputPasswordIntoSapElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapSetListSelectionByName(Expression<Func<SapSetListSelectionByNameInput>> sapSetListSelectionByName)
        {
            var __workflow_sapSetListSelectionByName = WorkflowExpression.Compile(sapSetListSelectionByName, nameof(sapSetListSelectionByName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetListSelectionByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSetListSelectionByName);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapSetListSelectionByKey(Expression<Func<SapSetListSelectionByKeyInput>> sapSetListSelectionByKey)
        {
            var __workflow_sapSetListSelectionByKey = WorkflowExpression.Compile(sapSetListSelectionByKey, nameof(sapSetListSelectionByKey), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetListSelectionByKey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSetListSelectionByKey);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetListSelectionElementItemsResponse, ApiConnectionActionConfiguration> SapGetListSelectionElementItems(Expression<Func<SapGetListSelectionElementItemsInput>> sapGetListSelectionElementItems)
        {
            var __workflow_sapGetListSelectionElementItems = WorkflowExpression.Compile(sapGetListSelectionElementItems, nameof(sapGetListSelectionElementItems), required: true);
            return new DeferredBodyAction<SapGetListSelectionElementItemsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetListSelectionElementItems";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetListSelectionElementItems);
                return new ApiConnectionAction<SapGetListSelectionElementItemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetAllChildSapElementPropertiesResponse, ApiConnectionActionConfiguration> SapGetAllChildSapElementProperties(Expression<Func<SapGetAllChildSapElementPropertiesInput>> sapGetAllChildSapElementProperties)
        {
            var __workflow_sapGetAllChildSapElementProperties = WorkflowExpression.Compile(sapGetAllChildSapElementProperties, nameof(sapGetAllChildSapElementProperties), required: true);
            return new DeferredBodyAction<SapGetAllChildSapElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetAllChildSAPElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetAllChildSapElementProperties);
                return new ApiConnectionAction<SapGetAllChildSapElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetSapSessionTopLevelSapElementPropertiesResponse, ApiConnectionActionConfiguration> SapGetSapSessionTopLevelSapElementProperties(Expression<Func<SapGetSapSessionTopLevelSapElementPropertiesInput>> sapGetSapSessionTopLevelSapElementProperties)
        {
            var __workflow_sapGetSapSessionTopLevelSapElementProperties = WorkflowExpression.Compile(sapGetSapSessionTopLevelSapElementProperties, nameof(sapGetSapSessionTopLevelSapElementProperties), required: true);
            return new DeferredBodyAction<SapGetSapSessionTopLevelSapElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPSessionTopLevelSAPElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetSapSessionTopLevelSapElementProperties);
                return new ApiConnectionAction<SapGetSapSessionTopLevelSapElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetSapElementParentIdResponse, ApiConnectionActionConfiguration> SapGetSapElementParentId(Expression<Func<SapGetSapElementParentIdInput>> sapGetSapElementParentId)
        {
            var __workflow_sapGetSapElementParentId = WorkflowExpression.Compile(sapGetSapElementParentId, nameof(sapGetSapElementParentId), required: true);
            return new DeferredBodyAction<SapGetSapElementParentIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPElementParentId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetSapElementParentId);
                return new ApiConnectionAction<SapGetSapElementParentIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetElementPropertiesAsListResponse, ApiConnectionActionConfiguration> SapGetElementPropertiesAsList(Expression<Func<SapGetElementPropertiesAsListInput>> sapGetElementPropertiesAsList)
        {
            var __workflow_sapGetElementPropertiesAsList = WorkflowExpression.Compile(sapGetElementPropertiesAsList, nameof(sapGetElementPropertiesAsList), required: true);
            return new DeferredBodyAction<SapGetElementPropertiesAsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetElementPropertiesAsList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetElementPropertiesAsList);
                return new ApiConnectionAction<SapGetElementPropertiesAsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetSapElementAtScreenCoordinateResponse, ApiConnectionActionConfiguration> SapGetSapElementAtScreenCoordinate(Expression<Func<SapGetSapElementAtScreenCoordinateInput>> sapGetSapElementAtScreenCoordinate)
        {
            var __workflow_sapGetSapElementAtScreenCoordinate = WorkflowExpression.Compile(sapGetSapElementAtScreenCoordinate, nameof(sapGetSapElementAtScreenCoordinate), required: true);
            return new DeferredBodyAction<SapGetSapElementAtScreenCoordinateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPElementAtScreenCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetSapElementAtScreenCoordinate);
                return new ApiConnectionAction<SapGetSapElementAtScreenCoordinateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapOpenConnectionResponse, ApiConnectionActionConfiguration> SapOpenConnection(Expression<Func<SapOpenConnectionInput>> sapOpenConnection)
        {
            var __workflow_sapOpenConnection = WorkflowExpression.Compile(sapOpenConnection, nameof(sapOpenConnection), required: true);
            return new DeferredBodyAction<SapOpenConnectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPOpenConnection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapOpenConnection);
                return new ApiConnectionAction<SapOpenConnectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetSapTablePropertiesResponse, ApiConnectionActionConfiguration> SapGetSapTableProperties(Expression<Func<SapGetSapTablePropertiesInput>> sapGetSapTableProperties)
        {
            var __workflow_sapGetSapTableProperties = WorkflowExpression.Compile(sapGetSapTableProperties, nameof(sapGetSapTableProperties), required: true);
            return new DeferredBodyAction<SapGetSapTablePropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPTableProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetSapTableProperties);
                return new ApiConnectionAction<SapGetSapTablePropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetSapTableVisibleCellTextContentsAtIndexResponse, ApiConnectionActionConfiguration> SapGetSapTableVisibleCellTextContentsAtIndex(Expression<Func<SapGetSapTableVisibleCellTextContentsAtIndexInput>> sapGetSapTableVisibleCellTextContentsAtIndex)
        {
            var __workflow_sapGetSapTableVisibleCellTextContentsAtIndex = WorkflowExpression.Compile(sapGetSapTableVisibleCellTextContentsAtIndex, nameof(sapGetSapTableVisibleCellTextContentsAtIndex), required: true);
            return new DeferredBodyAction<SapGetSapTableVisibleCellTextContentsAtIndexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPTableVisibleCellTextContentsAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetSapTableVisibleCellTextContentsAtIndex);
                return new ApiConnectionAction<SapGetSapTableVisibleCellTextContentsAtIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetSapTableVisibleCellPropertiesAtIndexResponse, ApiConnectionActionConfiguration> SapGetSapTableVisibleCellPropertiesAtIndex(Expression<Func<SapGetSapTableVisibleCellPropertiesAtIndexInput>> sapGetSapTableVisibleCellPropertiesAtIndex)
        {
            var __workflow_sapGetSapTableVisibleCellPropertiesAtIndex = WorkflowExpression.Compile(sapGetSapTableVisibleCellPropertiesAtIndex, nameof(sapGetSapTableVisibleCellPropertiesAtIndex), required: true);
            return new DeferredBodyAction<SapGetSapTableVisibleCellPropertiesAtIndexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPTableVisibleCellPropertiesAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetSapTableVisibleCellPropertiesAtIndex);
                return new ApiConnectionAction<SapGetSapTableVisibleCellPropertiesAtIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapSetSapTableVisibleCellTextContentsAtIndex(Expression<Func<SapSetSapTableVisibleCellTextContentsAtIndexInput>> sapSetSapTableVisibleCellTextContentsAtIndex)
        {
            var __workflow_sapSetSapTableVisibleCellTextContentsAtIndex = WorkflowExpression.Compile(sapSetSapTableVisibleCellTextContentsAtIndex, nameof(sapSetSapTableVisibleCellTextContentsAtIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPTableVisibleCellTextContentsAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSetSapTableVisibleCellTextContentsAtIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapCheckSapTableVisibleCellCheckboxAtIndex(Expression<Func<SapCheckSapTableVisibleCellCheckboxAtIndexInput>> sapCheckSapTableVisibleCellCheckboxAtIndex)
        {
            var __workflow_sapCheckSapTableVisibleCellCheckboxAtIndex = WorkflowExpression.Compile(sapCheckSapTableVisibleCellCheckboxAtIndex, nameof(sapCheckSapTableVisibleCellCheckboxAtIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPCheckSAPTableVisibleCellCheckboxAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapCheckSapTableVisibleCellCheckboxAtIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapPressSapTableVisibleCellAtIndex(Expression<Func<SapPressSapTableVisibleCellAtIndexInput>> sapPressSapTableVisibleCellAtIndex)
        {
            var __workflow_sapPressSapTableVisibleCellAtIndex = WorkflowExpression.Compile(sapPressSapTableVisibleCellAtIndex, nameof(sapPressSapTableVisibleCellAtIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressSAPTableVisibleCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapPressSapTableVisibleCellAtIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapScrollSapTable(Expression<Func<SapScrollSapTableInput>> sapScrollSapTable)
        {
            var __workflow_sapScrollSapTable = WorkflowExpression.Compile(sapScrollSapTable, nameof(sapScrollSapTable), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPScrollSAPTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapScrollSapTable);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetTableVisibleTextContentsResponse, ApiConnectionActionConfiguration> SapGetTableVisibleTextContents(Expression<Func<SapGetTableVisibleTextContentsInput>> sapGetTableVisibleTextContents)
        {
            var __workflow_sapGetTableVisibleTextContents = WorkflowExpression.Compile(sapGetTableVisibleTextContents, nameof(sapGetTableVisibleTextContents), required: true);
            return new DeferredBodyAction<SapGetTableVisibleTextContentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetTableVisibleTextContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetTableVisibleTextContents);
                return new ApiConnectionAction<SapGetTableVisibleTextContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapSelectSapTableRow(Expression<Func<SapSelectSapTableRowInput>> sapSelectSapTableRow)
        {
            var __workflow_sapSelectSapTableRow = WorkflowExpression.Compile(sapSelectSapTableRow, nameof(sapSelectSapTableRow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPTableRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSelectSapTableRow);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapSelectSapTableColumn(Expression<Func<SapSelectSapTableColumnInput>> sapSelectSapTableColumn)
        {
            var __workflow_sapSelectSapTableColumn = WorkflowExpression.Compile(sapSelectSapTableColumn, nameof(sapSelectSapTableColumn), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPTableColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSelectSapTableColumn);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetTreeNodesResponse, ApiConnectionActionConfiguration> SapGetTreeNodes(Expression<Func<SapGetTreeNodesInput>> sapGetTreeNodes)
        {
            var __workflow_sapGetTreeNodes = WorkflowExpression.Compile(sapGetTreeNodes, nameof(sapGetTreeNodes), required: true);
            return new DeferredBodyAction<SapGetTreeNodesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetTreeNodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetTreeNodes);
                return new ApiConnectionAction<SapGetTreeNodesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapDoubleClickTreeItem(Expression<Func<SapDoubleClickTreeItemInput>> sapDoubleClickTreeItem)
        {
            var __workflow_sapDoubleClickTreeItem = WorkflowExpression.Compile(sapDoubleClickTreeItem, nameof(sapDoubleClickTreeItem), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDoubleClickTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapDoubleClickTreeItem);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapSelectTreeItem(Expression<Func<SapSelectTreeItemInput>> sapSelectTreeItem)
        {
            var __workflow_sapSelectTreeItem = WorkflowExpression.Compile(sapSelectTreeItem, nameof(sapSelectTreeItem), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSelectTreeItem);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapExpandTreeNode(Expression<Func<SapExpandTreeNodeInput>> sapExpandTreeNode)
        {
            var __workflow_sapExpandTreeNode = WorkflowExpression.Compile(sapExpandTreeNode, nameof(sapExpandTreeNode), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPExpandTreeNode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapExpandTreeNode);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapDeselectAllTreeNodes(Expression<Func<SapDeselectAllTreeNodesInput>> sapDeselectAllTreeNodes)
        {
            var __workflow_sapDeselectAllTreeNodes = WorkflowExpression.Compile(sapDeselectAllTreeNodes, nameof(sapDeselectAllTreeNodes), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDeselectAllTreeNodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapDeselectAllTreeNodes);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapPressKeyOnTree(Expression<Func<SapPressKeyOnTreeInput>> sapPressKeyOnTree)
        {
            var __workflow_sapPressKeyOnTree = WorkflowExpression.Compile(sapPressKeyOnTree, nameof(sapPressKeyOnTree), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressKeyOnTree";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapPressKeyOnTree);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapOpenContextMenuOnTreeItem(Expression<Func<SapOpenContextMenuOnTreeItemInput>> sapOpenContextMenuOnTreeItem)
        {
            var __workflow_sapOpenContextMenuOnTreeItem = WorkflowExpression.Compile(sapOpenContextMenuOnTreeItem, nameof(sapOpenContextMenuOnTreeItem), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPOpenContextMenuOnTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapOpenContextMenuOnTreeItem);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetTreeTextContentsResponse, ApiConnectionActionConfiguration> SapGetTreeTextContents(Expression<Func<SapGetTreeTextContentsInput>> sapGetTreeTextContents)
        {
            var __workflow_sapGetTreeTextContents = WorkflowExpression.Compile(sapGetTreeTextContents, nameof(sapGetTreeTextContents), required: true);
            return new DeferredBodyAction<SapGetTreeTextContentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetTreeTextContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetTreeTextContents);
                return new ApiConnectionAction<SapGetTreeTextContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapSetTreeColumnWidth(Expression<Func<SapSetTreeColumnWidthInput>> sapSetTreeColumnWidth)
        {
            var __workflow_sapSetTreeColumnWidth = WorkflowExpression.Compile(sapSetTreeColumnWidth, nameof(sapSetTreeColumnWidth), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetTreeColumnWidth";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSetTreeColumnWidth);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapPressButtonOnTreeItem(Expression<Func<SapPressButtonOnTreeItemInput>> sapPressButtonOnTreeItem)
        {
            var __workflow_sapPressButtonOnTreeItem = WorkflowExpression.Compile(sapPressButtonOnTreeItem, nameof(sapPressButtonOnTreeItem), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressButtonOnTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapPressButtonOnTreeItem);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapClickLinkOnTreeItem(Expression<Func<SapClickLinkOnTreeItemInput>> sapClickLinkOnTreeItem)
        {
            var __workflow_sapClickLinkOnTreeItem = WorkflowExpression.Compile(sapClickLinkOnTreeItem, nameof(sapClickLinkOnTreeItem), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPClickLinkOnTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapClickLinkOnTreeItem);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapCheckTreeItem(Expression<Func<SapCheckTreeItemInput>> sapCheckTreeItem)
        {
            var __workflow_sapCheckTreeItem = WorkflowExpression.Compile(sapCheckTreeItem, nameof(sapCheckTreeItem), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPCheckTreeItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapCheckTreeItem);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetTreeColumnHeadersResponse, ApiConnectionActionConfiguration> SapGetTreeColumnHeaders(Expression<Func<SapGetTreeColumnHeadersInput>> sapGetTreeColumnHeaders)
        {
            var __workflow_sapGetTreeColumnHeaders = WorkflowExpression.Compile(sapGetTreeColumnHeaders, nameof(sapGetTreeColumnHeaders), required: true);
            return new DeferredBodyAction<SapGetTreeColumnHeadersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetTreeColumnHeaders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetTreeColumnHeaders);
                return new ApiConnectionAction<SapGetTreeColumnHeadersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetTreeItemPropertiesResponse, ApiConnectionActionConfiguration> SapGetTreeItemProperties(Expression<Func<SapGetTreeItemPropertiesInput>> sapGetTreeItemProperties)
        {
            var __workflow_sapGetTreeItemProperties = WorkflowExpression.Compile(sapGetTreeItemProperties, nameof(sapGetTreeItemProperties), required: true);
            return new DeferredBodyAction<SapGetTreeItemPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetTreeItemProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetTreeItemProperties);
                return new ApiConnectionAction<SapGetTreeItemPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetShellToolbarElementsResponse, ApiConnectionActionConfiguration> SapGetShellToolbarElements(Expression<Func<SapGetShellToolbarElementsInput>> sapGetShellToolbarElements)
        {
            var __workflow_sapGetShellToolbarElements = WorkflowExpression.Compile(sapGetShellToolbarElements, nameof(sapGetShellToolbarElements), required: true);
            return new DeferredBodyAction<SapGetShellToolbarElementsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetShellToolbarElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetShellToolbarElements);
                return new ApiConnectionAction<SapGetShellToolbarElementsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapPressShellToolbarElement(Expression<Func<SapPressShellToolbarElementInput>> sapPressShellToolbarElement)
        {
            var __workflow_sapPressShellToolbarElement = WorkflowExpression.Compile(sapPressShellToolbarElement, nameof(sapPressShellToolbarElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressShellToolbarElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapPressShellToolbarElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapPressShellToolbarElementContextButton(Expression<Func<SapPressShellToolbarElementContextButtonInput>> sapPressShellToolbarElementContextButton)
        {
            var __workflow_sapPressShellToolbarElementContextButton = WorkflowExpression.Compile(sapPressShellToolbarElementContextButton, nameof(sapPressShellToolbarElementContextButton), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressShellToolbarElementContextButton";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapPressShellToolbarElementContextButton);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapSelectShellToolbarMenuItem(Expression<Func<SapSelectShellToolbarMenuItemInput>> sapSelectShellToolbarMenuItem)
        {
            var __workflow_sapSelectShellToolbarMenuItem = WorkflowExpression.Compile(sapSelectShellToolbarMenuItem, nameof(sapSelectShellToolbarMenuItem), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectShellToolbarMenuItem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSelectShellToolbarMenuItem);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetSapGridViewPropertiesResponse, ApiConnectionActionConfiguration> SapGetSapGridViewProperties(Expression<Func<SapGetSapGridViewPropertiesInput>> sapGetSapGridViewProperties)
        {
            var __workflow_sapGetSapGridViewProperties = WorkflowExpression.Compile(sapGetSapGridViewProperties, nameof(sapGetSapGridViewProperties), required: true);
            return new DeferredBodyAction<SapGetSapGridViewPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGridViewProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetSapGridViewProperties);
                return new ApiConnectionAction<SapGetSapGridViewPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetSapGridViewCellContentsAtIndexResponse, ApiConnectionActionConfiguration> SapGetSapGridViewCellContentsAtIndex(Expression<Func<SapGetSapGridViewCellContentsAtIndexInput>> sapGetSapGridViewCellContentsAtIndex)
        {
            var __workflow_sapGetSapGridViewCellContentsAtIndex = WorkflowExpression.Compile(sapGetSapGridViewCellContentsAtIndex, nameof(sapGetSapGridViewCellContentsAtIndex), required: true);
            return new DeferredBodyAction<SapGetSapGridViewCellContentsAtIndexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGridViewCellContentsAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetSapGridViewCellContentsAtIndex);
                return new ApiConnectionAction<SapGetSapGridViewCellContentsAtIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetSapGridViewCellPropertiesAtIndexResponse, ApiConnectionActionConfiguration> SapGetSapGridViewCellPropertiesAtIndex(Expression<Func<SapGetSapGridViewCellPropertiesAtIndexInput>> sapGetSapGridViewCellPropertiesAtIndex)
        {
            var __workflow_sapGetSapGridViewCellPropertiesAtIndex = WorkflowExpression.Compile(sapGetSapGridViewCellPropertiesAtIndex, nameof(sapGetSapGridViewCellPropertiesAtIndex), required: true);
            return new DeferredBodyAction<SapGetSapGridViewCellPropertiesAtIndexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGridViewCellPropertiesAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetSapGridViewCellPropertiesAtIndex);
                return new ApiConnectionAction<SapGetSapGridViewCellPropertiesAtIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapDrawRectangleAroundSapGridViewCellAtIndex(Expression<Func<SapDrawRectangleAroundSapGridViewCellAtIndexInput>> sapDrawRectangleAroundSapGridViewCellAtIndex)
        {
            var __workflow_sapDrawRectangleAroundSapGridViewCellAtIndex = WorkflowExpression.Compile(sapDrawRectangleAroundSapGridViewCellAtIndex, nameof(sapDrawRectangleAroundSapGridViewCellAtIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDrawRectangleAroundSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapDrawRectangleAroundSapGridViewCellAtIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapGlobalLeftClickSapGridViewCellAtIndex(Expression<Func<SapGlobalLeftClickSapGridViewCellAtIndexInput>> sapGlobalLeftClickSapGridViewCellAtIndex)
        {
            var __workflow_sapGlobalLeftClickSapGridViewCellAtIndex = WorkflowExpression.Compile(sapGlobalLeftClickSapGridViewCellAtIndex, nameof(sapGlobalLeftClickSapGridViewCellAtIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalLeftClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGlobalLeftClickSapGridViewCellAtIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapGlobalRightClickSapGridViewCellAtIndex(Expression<Func<SapGlobalRightClickSapGridViewCellAtIndexInput>> sapGlobalRightClickSapGridViewCellAtIndex)
        {
            var __workflow_sapGlobalRightClickSapGridViewCellAtIndex = WorkflowExpression.Compile(sapGlobalRightClickSapGridViewCellAtIndex, nameof(sapGlobalRightClickSapGridViewCellAtIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalRightClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGlobalRightClickSapGridViewCellAtIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapGlobalDoubleLeftClickSapGridViewCellAtIndex(Expression<Func<SapGlobalDoubleLeftClickSapGridViewCellAtIndexInput>> sapGlobalDoubleLeftClickSapGridViewCellAtIndex)
        {
            var __workflow_sapGlobalDoubleLeftClickSapGridViewCellAtIndex = WorkflowExpression.Compile(sapGlobalDoubleLeftClickSapGridViewCellAtIndex, nameof(sapGlobalDoubleLeftClickSapGridViewCellAtIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGlobalDoubleLeftClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGlobalDoubleLeftClickSapGridViewCellAtIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetSapGridViewColumnHeadersResponse, ApiConnectionActionConfiguration> SapGetSapGridViewColumnHeaders(Expression<Func<SapGetSapGridViewColumnHeadersInput>> sapGetSapGridViewColumnHeaders)
        {
            var __workflow_sapGetSapGridViewColumnHeaders = WorkflowExpression.Compile(sapGetSapGridViewColumnHeaders, nameof(sapGetSapGridViewColumnHeaders), required: true);
            return new DeferredBodyAction<SapGetSapGridViewColumnHeadersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetSAPGridViewColumnHeaders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetSapGridViewColumnHeaders);
                return new ApiConnectionAction<SapGetSapGridViewColumnHeadersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapClickSapGridViewCellAtIndex(Expression<Func<SapClickSapGridViewCellAtIndexInput>> sapClickSapGridViewCellAtIndex)
        {
            var __workflow_sapClickSapGridViewCellAtIndex = WorkflowExpression.Compile(sapClickSapGridViewCellAtIndex, nameof(sapClickSapGridViewCellAtIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapClickSapGridViewCellAtIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapDoubleClickSapGridViewCellAtIndex(Expression<Func<SapDoubleClickSapGridViewCellAtIndexInput>> sapDoubleClickSapGridViewCellAtIndex)
        {
            var __workflow_sapDoubleClickSapGridViewCellAtIndex = WorkflowExpression.Compile(sapDoubleClickSapGridViewCellAtIndex, nameof(sapDoubleClickSapGridViewCellAtIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPDoubleClickSAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapDoubleClickSapGridViewCellAtIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapPressSapGridViewCellButtonAtIndex(Expression<Func<SapPressSapGridViewCellButtonAtIndexInput>> sapPressSapGridViewCellButtonAtIndex)
        {
            var __workflow_sapPressSapGridViewCellButtonAtIndex = WorkflowExpression.Compile(sapPressSapGridViewCellButtonAtIndex, nameof(sapPressSapGridViewCellButtonAtIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressSAPGridViewCellButtonAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapPressSapGridViewCellButtonAtIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapCheckSapGridViewCellCheckboxAtIndex(Expression<Func<SapCheckSapGridViewCellCheckboxAtIndexInput>> sapCheckSapGridViewCellCheckboxAtIndex)
        {
            var __workflow_sapCheckSapGridViewCellCheckboxAtIndex = WorkflowExpression.Compile(sapCheckSapGridViewCellCheckboxAtIndex, nameof(sapCheckSapGridViewCellCheckboxAtIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPCheckSAPGridViewCellCheckboxAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapCheckSapGridViewCellCheckboxAtIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapModifySapGridViewCellAtIndexResponse, ApiConnectionActionConfiguration> SapModifySapGridViewCellAtIndex(Expression<Func<SapModifySapGridViewCellAtIndexInput>> sapModifySapGridViewCellAtIndex)
        {
            var __workflow_sapModifySapGridViewCellAtIndex = WorkflowExpression.Compile(sapModifySapGridViewCellAtIndex, nameof(sapModifySapGridViewCellAtIndex), required: true);
            return new DeferredBodyAction<SapModifySapGridViewCellAtIndexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPModifySAPGridViewCellAtIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapModifySapGridViewCellAtIndex);
                return new ApiConnectionAction<SapModifySapGridViewCellAtIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapSetSapGridViewCurrentRow(Expression<Func<SapSetSapGridViewCurrentRowInput>> sapSetSapGridViewCurrentRow)
        {
            var __workflow_sapSetSapGridViewCurrentRow = WorkflowExpression.Compile(sapSetSapGridViewCurrentRow, nameof(sapSetSapGridViewCurrentRow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewCurrentRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSetSapGridViewCurrentRow);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapPressSapGridViewColumnHeader(Expression<Func<SapPressSapGridViewColumnHeaderInput>> sapPressSapGridViewColumnHeader)
        {
            var __workflow_sapPressSapGridViewColumnHeader = WorkflowExpression.Compile(sapPressSapGridViewColumnHeader, nameof(sapPressSapGridViewColumnHeader), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPPressSAPGridViewColumnHeader";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapPressSapGridViewColumnHeader);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapSetSapGridViewFirstVisibleRowResponse, ApiConnectionActionConfiguration> SapSetSapGridViewFirstVisibleRow(Expression<Func<SapSetSapGridViewFirstVisibleRowInput>> sapSetSapGridViewFirstVisibleRow)
        {
            var __workflow_sapSetSapGridViewFirstVisibleRow = WorkflowExpression.Compile(sapSetSapGridViewFirstVisibleRow, nameof(sapSetSapGridViewFirstVisibleRow), required: true);
            return new DeferredBodyAction<SapSetSapGridViewFirstVisibleRowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewFirstVisibleRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSetSapGridViewFirstVisibleRow);
                return new ApiConnectionAction<SapSetSapGridViewFirstVisibleRowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapSelectSapGridViewRow(Expression<Func<SapSelectSapGridViewRowInput>> sapSelectSapGridViewRow)
        {
            var __workflow_sapSelectSapGridViewRow = WorkflowExpression.Compile(sapSelectSapGridViewRow, nameof(sapSelectSapGridViewRow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPGridViewRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSelectSapGridViewRow);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapSelectSapGridViewMultipleRows(Expression<Func<SapSelectSapGridViewMultipleRowsInput>> sapSelectSapGridViewMultipleRows)
        {
            var __workflow_sapSelectSapGridViewMultipleRows = WorkflowExpression.Compile(sapSelectSapGridViewMultipleRows, nameof(sapSelectSapGridViewMultipleRows), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPGridViewMultipleRows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSelectSapGridViewMultipleRows);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapSetSapGridViewCurrentColumn(Expression<Func<SapSetSapGridViewCurrentColumnInput>> sapSetSapGridViewCurrentColumn)
        {
            var __workflow_sapSetSapGridViewCurrentColumn = WorkflowExpression.Compile(sapSetSapGridViewCurrentColumn, nameof(sapSetSapGridViewCurrentColumn), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewCurrentColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSetSapGridViewCurrentColumn);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapSetSapGridViewCurrentCell(Expression<Func<SapSetSapGridViewCurrentCellInput>> sapSetSapGridViewCurrentCell)
        {
            var __workflow_sapSetSapGridViewCurrentCell = WorkflowExpression.Compile(sapSetSapGridViewCurrentCell, nameof(sapSetSapGridViewCurrentCell), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewCurrentCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSetSapGridViewCurrentCell);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapSelectSapGridViewColumn(Expression<Func<SapSelectSapGridViewColumnInput>> sapSelectSapGridViewColumn)
        {
            var __workflow_sapSelectSapGridViewColumn = WorkflowExpression.Compile(sapSelectSapGridViewColumn, nameof(sapSelectSapGridViewColumn), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectSAPGridViewColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSelectSapGridViewColumn);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapGridViewSelectAll(Expression<Func<SapGridViewSelectAllInput>> sapGridViewSelectAll)
        {
            var __workflow_sapGridViewSelectAll = WorkflowExpression.Compile(sapGridViewSelectAll, nameof(sapGridViewSelectAll), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGridViewSelectAll";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGridViewSelectAll);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapGridViewDeselectAll(Expression<Func<SapGridViewDeselectAllInput>> sapGridViewDeselectAll)
        {
            var __workflow_sapGridViewDeselectAll = WorkflowExpression.Compile(sapGridViewDeselectAll, nameof(sapGridViewDeselectAll), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGridViewDeselectAll";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGridViewDeselectAll);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapSetSapGridViewFirstVisibleColumnResponse, ApiConnectionActionConfiguration> SapSetSapGridViewFirstVisibleColumn(Expression<Func<SapSetSapGridViewFirstVisibleColumnInput>> sapSetSapGridViewFirstVisibleColumn)
        {
            var __workflow_sapSetSapGridViewFirstVisibleColumn = WorkflowExpression.Compile(sapSetSapGridViewFirstVisibleColumn, nameof(sapSetSapGridViewFirstVisibleColumn), required: true);
            return new DeferredBodyAction<SapSetSapGridViewFirstVisibleColumnResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSetSAPGridViewFirstVisibleColumn";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSetSapGridViewFirstVisibleColumn);
                return new ApiConnectionAction<SapSetSapGridViewFirstVisibleColumnResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapGridViewOpenContextMenu(Expression<Func<SapGridViewOpenContextMenuInput>> sapGridViewOpenContextMenu)
        {
            var __workflow_sapGridViewOpenContextMenu = WorkflowExpression.Compile(sapGridViewOpenContextMenu, nameof(sapGridViewOpenContextMenu), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGridViewOpenContextMenu";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGridViewOpenContextMenu);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IBodyWorkflowAction<SapGetGridViewTextContentsResponse, ApiConnectionActionConfiguration> SapGetGridViewTextContents(Expression<Func<SapGetGridViewTextContentsInput>> sapGetGridViewTextContents)
        {
            var __workflow_sapGetGridViewTextContents = WorkflowExpression.Compile(sapGetGridViewTextContents, nameof(sapGetGridViewTextContents), required: true);
            return new DeferredBodyAction<SapGetGridViewTextContentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPGetGridViewTextContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapGetGridViewTextContents);
                return new ApiConnectionAction<SapGetGridViewTextContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapSelectCalendarMonth(Expression<Func<SapSelectCalendarMonthInput>> sapSelectCalendarMonth)
        {
            var __workflow_sapSelectCalendarMonth = WorkflowExpression.Compile(sapSelectCalendarMonth, nameof(sapSelectCalendarMonth), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectCalendarMonth";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSelectCalendarMonth);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapSelectCalendarWeek(Expression<Func<SapSelectCalendarWeekInput>> sapSelectCalendarWeek)
        {
            var __workflow_sapSelectCalendarWeek = WorkflowExpression.Compile(sapSelectCalendarWeek, nameof(sapSelectCalendarWeek), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectCalendarWeek";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSelectCalendarWeek);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapSelectCalendarRange(Expression<Func<SapSelectCalendarRangeInput>> sapSelectCalendarRange)
        {
            var __workflow_sapSelectCalendarRange = WorkflowExpression.Compile(sapSelectCalendarRange, nameof(sapSelectCalendarRange), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPSelectCalendarRange";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapSelectCalendarRange);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsapgui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SapFocusCalendarDate(Expression<Func<SapFocusCalendarDateInput>> sapFocusCalendarDate)
        {
            var __workflow_sapFocusCalendarDate = WorkflowExpression.Compile(sapFocusCalendarDate, nameof(sapFocusCalendarDate), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SAPGUI/SAPFocusCalendarDate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sapFocusCalendarDate);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class IaconnectsapguiTriggers([ConnectionName] string connectionId)
    {
    }

    public class SapEnableScriptingInput
    {
        [JsonProperty("NotifyWhenScriptAttachesToGUI", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NotifyWhenScriptAttachesToGui { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NotifyWhenScriptOpensConnection { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowNativeWindowsDialogs { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapLaunchSapguiResponse
    {
        [JsonProperty("SAPGUIMajorVersion")]
        public int SapguiMajorVersion { get; set; }

        [JsonProperty("SAPGUIRevision")]
        public int SapguiRevision { get; set; }

        [JsonProperty("SAPGUIPatchLevel")]
        public int SapguiPatchLevel { get; set; }

        [JsonProperty("SAPGUIMinorVersion")]
        public int SapguiMinorVersion { get; set; }

        [JsonProperty("SAPGUINewVisualDesign")]
        public bool SapguiNewVisualDesign { get; set; }
    }

    public class SapLaunchSapguiInput
    {
        [JsonProperty("SAPLogonEXE")]
        public string SapLogonExe { get; set; }

        [JsonProperty("SAPLogonArguments")]
        public string SapLogonArguments { get; set; }

        [JsonProperty("EnableSAPScripting", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EnableSapScripting { get; set; } = true;

        [JsonProperty("NotifyWhenScriptAttachesToGUI", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NotifyWhenScriptAttachesToGui { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NotifyWhenScriptOpensConnection { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowNativeWindowsDialogs { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AttachAfterLaunch { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SecondsToWait { get; set; } = 15;

        [JsonProperty("SAPProgId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SapProgId { get; set; } = "SAPGUI";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DisableSystemMessages { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapAttachToSapguiResponse
    {
        [JsonProperty("NumberOfSAPConnections")]
        public int NumberOfSapConnections { get; set; }

        [JsonProperty("SAPGUIMajorVersion")]
        public int SapguiMajorVersion { get; set; }

        [JsonProperty("SAPGUIRevision")]
        public int SapguiRevision { get; set; }

        [JsonProperty("SAPGUIPatchLevel")]
        public int SapguiPatchLevel { get; set; }

        [JsonProperty("SAPGUIMinorVersion")]
        public int SapguiMinorVersion { get; set; }

        [JsonProperty("SAPGUINewVisualDesign")]
        public bool SapguiNewVisualDesign { get; set; }
    }

    public class SapAttachToSapguiInput
    {
        [JsonProperty("SAPProgId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SapProgId { get; set; } = "SAPGUI";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DisableSystemMessages { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapDetachFromSapguiInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapGetSapguiStatusResponse
    {
        public bool Connected { get; set; }
        public string ConnectionError { get; set; }

        [JsonProperty("NumberOfSAPConnections")]
        public int NumberOfSapConnections { get; set; }

        [JsonProperty("SAPGUIMajorVersion")]
        public int SapguiMajorVersion { get; set; }

        [JsonProperty("SAPGUIRevision")]
        public int SapguiRevision { get; set; }

        [JsonProperty("SAPGUIPatchLevel")]
        public int SapguiPatchLevel { get; set; }

        [JsonProperty("SAPGUIMinorVersion")]
        public int SapguiMinorVersion { get; set; }

        [JsonProperty("SAPGUINewVisualDesign")]
        public bool SapguiNewVisualDesign { get; set; }
        public bool ConnectedToSession { get; set; }
        public string SessionError { get; set; }
        public string SessionName { get; set; }
        public string SessionSystemName { get; set; }
    }

    public class SapGetSapguiStatusInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapGetSapSessionsResponse
    {
        [JsonProperty("NumberOfSAPConnections")]
        public int NumberOfSapConnections { get; set; }

        [JsonProperty("SAPConnectionsJSON")]
        public string SapConnectionsJson { get; set; }

        [JsonProperty("NumberOfSAPSessions")]
        public int NumberOfSapSessions { get; set; }

        [JsonProperty("SAPSessionsJSON")]
        public string SapSessionsJson { get; set; }
    }

    public class SapGetSapSessionsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapAttachToSessionResponse
    {
        public string AttachedConnectionName { get; set; }
        public string AttachedSessionName { get; set; }
    }

    public class SapAttachToSessionInput
    {
        public string SearchConnectionName { get; set; }
        public string SearchSessionName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapCloseSessionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CloseAttachedSession { get; set; } = true;
        public string SearchConnectionName { get; set; }
        public string SearchSessionName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapGetAttachedSessionPropertiesResponse
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

    public class SapGetAttachedSessionPropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapWaitForAttachedSessionNotBusyResponse
    {
        public bool BusyAfterWait { get; set; }
    }

    public class SapWaitForAttachedSessionNotBusyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double SecondsToWait { get; set; } = 15;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfBusyAfterWait { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapInputTextIntoSapElementInput
    {
        public SapInputTextIntoSapElementInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }
        public string TextToInput { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReplaceExistingValue { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? InsertPosition { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapInputPasswordIntoSapElementInput
    {
        public SapInputPasswordIntoSapElementInput(string searchSapElementId, string passwordToInput)
        {
            this.SearchSapElementId = searchSapElementId;
            this.PasswordToInput = passwordToInput;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PasswordToInput { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapGetElementPropertiesResponse
    {
        [JsonProperty("SAPElementType")]
        public string SapElementType { get; set; }

        [JsonProperty("SAPElementTypeCode")]
        public int SapElementTypeCode { get; set; }

        [JsonProperty("SAPElementName")]
        public string SapElementName { get; set; }

        [JsonProperty("SAPElementId")]
        public string SapElementId { get; set; }

        [JsonProperty("SAPElementSubType")]
        public string SapElementSubType { get; set; }

        [JsonProperty("SAPElementTextValue")]
        public string SapElementTextValue { get; set; }

        [JsonProperty("SAPElementIsContainer")]
        public bool SapElementIsContainer { get; set; }

        [JsonProperty("SAPElementNumberOfChildren")]
        public int SapElementNumberOfChildren { get; set; }

        [JsonProperty("SAPElementIsChangeable")]
        public bool SapElementIsChangeable { get; set; }

        [JsonProperty("SAPElementIsModified")]
        public bool SapElementIsModified { get; set; }

        [JsonProperty("SAPElementIsSelected")]
        public bool SapElementIsSelected { get; set; }

        [JsonProperty("SAPElementIsHighlighted")]
        public bool SapElementIsHighlighted { get; set; }

        [JsonProperty("SAPElementIsVisible")]
        public bool SapElementIsVisible { get; set; }

        [JsonProperty("SAPElementLeftEdge")]
        public int SapElementLeftEdge { get; set; }

        [JsonProperty("SAPElementTopEdge")]
        public int SapElementTopEdge { get; set; }

        [JsonProperty("SAPElementWidth")]
        public int SapElementWidth { get; set; }

        [JsonProperty("SAPElementHeight")]
        public int SapElementHeight { get; set; }

        [JsonProperty("SAPElementRightEdge")]
        public int SapElementRightEdge { get; set; }

        [JsonProperty("SAPElementBottomEdge")]
        public int SapElementBottomEdge { get; set; }

        [JsonProperty("SAPElementMessageType")]
        public string SapElementMessageType { get; set; }
    }

    public class SapGetElementPropertiesInput
    {
        public SapGetElementPropertiesInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapWaitForElementIdResponse
    {
        [JsonProperty("SAPElementExists")]
        public bool SapElementExists { get; set; }

        [JsonProperty("SAPElementType")]
        public string SapElementType { get; set; }

        [JsonProperty("SAPElementTypeCode")]
        public int SapElementTypeCode { get; set; }

        [JsonProperty("SAPElementName")]
        public string SapElementName { get; set; }

        [JsonProperty("SAPElementSubType")]
        public string SapElementSubType { get; set; }
    }

    public class SapWaitForElementIdInput
    {
        public SapWaitForElementIdInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SecondsToWait { get; set; } = 15;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfElementNotFound { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapWaitForWindowResponse
    {
        [JsonProperty("SAPWindowExists")]
        public bool SapWindowExists { get; set; }

        [JsonProperty("SAPElementId")]
        public string SapElementId { get; set; }

        [JsonProperty("SAPElementType")]
        public string SapElementType { get; set; }

        [JsonProperty("SAPElementTypeCode")]
        public int SapElementTypeCode { get; set; }

        [JsonProperty("SAPElementName")]
        public string SapElementName { get; set; }

        [JsonProperty("SAPElementSubType")]
        public string SapElementSubType { get; set; }
    }

    public class SapWaitForWindowInput
    {
        public SapWaitForWindowInput(string searchSapWindowTitle)
        {
            this.SearchSapWindowTitle = searchSapWindowTitle;
        }

        [JsonProperty("SearchSAPWindowTitle", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapWindowTitle { get; set; }

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

    public class SapGetElementTextValueResponse
    {
        [JsonProperty("SAPElementTextValue")]
        public string SapElementTextValue { get; set; }

        [JsonProperty("SAPElementMessageType")]
        public string SapElementMessageType { get; set; }
    }

    public class SapGetElementTextValueInput
    {
        public SapGetElementTextValueInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapPressSapElementInput
    {
        public SapPressSapElementInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapSelectSapElementInput
    {
        public SapSelectSapElementInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapFocusSapElementInput
    {
        public SapFocusSapElementInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapCheckSapElementInput
    {
        public SapCheckSapElementInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapVisualiseSapElementInput
    {
        public SapVisualiseSapElementInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? VisualiseOn { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapDrawRectangleAroundSapElementInput
    {
        public SapDrawRectangleAroundSapElementInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PenColour { get; set; } = "#009FDE";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? PenThicknessPixels { get; set; } = 4;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapSendCommandInput
    {
        public SapSendCommandInput(string sapCommand)
        {
            this.SapCommand = sapCommand;
        }

        [JsonProperty("SAPCommand", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SapCommand { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapEnterTCodeInput
    {
        public SapEnterTCodeInput(string saptCode)
        {
            this.SaptCode = saptCode;
        }

        [JsonProperty("SAPTCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SaptCode { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapSendVKeyInput
    {
        public SapSendVKeyInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty("SAPVKey", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SapvKey { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DetectParentWindowElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapSendEnterVKeyInput
    {
        public SapSendEnterVKeyInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DetectParentWindowElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapWindowRestoreInput
    {
        public SapWindowRestoreInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DetectParentWindowElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapWindowMaximiseInput
    {
        public SapWindowMaximiseInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DetectParentWindowElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapWindowMinimiseInput
    {
        public SapWindowMinimiseInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DetectParentWindowElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapWindowCloseInput
    {
        public SapWindowCloseInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DetectParentWindowElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapBringWindowToFrontInput
    {
        public SapBringWindowToFrontInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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

    public class SapGlobalLeftMouseClickOnSapElementInput
    {
        public SapGlobalLeftMouseClickOnSapElementInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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
        public SapGlobalLeftMouseClickOnSapElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SapGlobalLeftMouseClickOnSapElementInputOffsetRelativeToType
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

    public class SapGlobalRightMouseClickOnSapElementInput
    {
        public SapGlobalRightMouseClickOnSapElementInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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
        public SapGlobalRightMouseClickOnSapElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SapGlobalRightMouseClickOnSapElementInputOffsetRelativeToType
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

    public class SapGlobalMiddleMouseClickOnSapElementInput
    {
        public SapGlobalMiddleMouseClickOnSapElementInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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
        public SapGlobalMiddleMouseClickOnSapElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SapGlobalMiddleMouseClickOnSapElementInputOffsetRelativeToType
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

    public class SapGlobalDoubleLeftMouseClickOnSapElementInput
    {
        public SapGlobalDoubleLeftMouseClickOnSapElementInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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
        public SapGlobalDoubleLeftMouseClickOnSapElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DoubleClickDelayInMilliseconds { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SapGlobalDoubleLeftMouseClickOnSapElementInputOffsetRelativeToType
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

    public class SapGlobalInputTextIntoSapElementInput
    {
        public SapGlobalInputTextIntoSapElementInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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

        [JsonProperty("ReplaceExistingValueUsingCTRLADelete", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReplaceExistingValueUsingCtrlaDelete { get; set; } = false;
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

    public class SapGlobalInputPasswordIntoSapElementInput
    {
        public SapGlobalInputPasswordIntoSapElementInput(string searchSapElementId, string passwordToInput)
        {
            this.SearchSapElementId = searchSapElementId;
            this.PasswordToInput = passwordToInput;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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

        [JsonProperty("ReplaceExistingValueUsingCTRLADelete", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReplaceExistingValueUsingCtrlaDelete { get; set; } = false;

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

    public class SapSetListSelectionByNameInput
    {
        public SapSetListSelectionByNameInput(string searchSapElementId, string listItemName)
        {
            this.SearchSapElementId = searchSapElementId;
            this.ListItemName = listItemName;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListItemName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapSetListSelectionByKeyInput
    {
        public SapSetListSelectionByKeyInput(string searchSapElementId, string listItemKey)
        {
            this.SearchSapElementId = searchSapElementId;
            this.ListItemKey = listItemKey;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ListItemKey { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapGetListSelectionElementItemsResponse
    {
        public int NumberOfItemsInList { get; set; }

        [JsonProperty("SAPSelectionListItemsJSON")]
        public string SapSelectionListItemsJson { get; set; }
        public string CurrentlySelectedValue { get; set; }
        public string CurrentlySelectedKey { get; set; }
        public bool ValueRequired { get; set; }
    }

    public class SapGetListSelectionElementItemsInput
    {
        public SapGetListSelectionElementItemsInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapGetAllChildSapElementPropertiesResponse
    {
        public int NumberOfChildElementsReturned { get; set; }
        public bool MoreElementsAvailableAtCurrentDepth { get; set; }

        [JsonProperty("SAPChildElementsJSON")]
        public string SapChildElementsJson { get; set; }
    }

    public class SapGetAllChildSapElementPropertiesInput
    {
        public SapGetAllChildSapElementPropertiesInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstItemToReturn { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxItemsToReturn { get; set; } = 0;

        [JsonProperty("SearchSAPElementType")]
        public string SearchSapElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxTextLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapGetSapSessionTopLevelSapElementPropertiesResponse
    {
        public int NumberOfChildElementsReturned { get; set; }
        public bool MoreElementsAvailableAtCurrentDepth { get; set; }

        [JsonProperty("SAPChildElementsJSON")]
        public string SapChildElementsJson { get; set; }
    }

    public class SapGetSapSessionTopLevelSapElementPropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstItemToReturn { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxItemsToReturn { get; set; } = 0;

        [JsonProperty("SearchSAPElementType")]
        public string SearchSapElementType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxTextLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapGetSapElementParentIdResponse
    {
        [JsonProperty("SAPParentElementId")]
        public string SapParentElementId { get; set; }

        [JsonProperty("SAPParentElementType")]
        public string SapParentElementType { get; set; }

        [JsonProperty("SAPParentElementTypeCode")]
        public int SapParentElementTypeCode { get; set; }
    }

    public class SapGetSapElementParentIdInput
    {
        public SapGetSapElementParentIdInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapGetElementPropertiesAsListResponse
    {
        public int NumberOfElementsReturned { get; set; }

        [JsonProperty("SAPElementsJSON")]
        public string SapElementsJson { get; set; }
    }

    public class SapGetElementPropertiesAsListInput
    {
        public SapGetElementPropertiesAsListInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxTextLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapGetSapElementAtScreenCoordinateResponse
    {
        [JsonProperty("SAPElementId")]
        public string SapElementId { get; set; }
    }

    public class SapGetSapElementAtScreenCoordinateInput
    {
        public SapGetSapElementAtScreenCoordinateInput(int screenX, int screenY)
        {
            this.ScreenX = screenX;
            this.ScreenY = screenY;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ScreenX { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ScreenY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapOpenConnectionResponse
    {
        public string OpenedConnectionName { get; set; }
        public bool ScriptingDisabledByServer { get; set; }

        [JsonProperty("NumberOfSAPSessions")]
        public int NumberOfSapSessions { get; set; }
        public string ConnectedSessionName { get; set; }
    }

    public class SapOpenConnectionInput
    {
        [JsonProperty("SAPConnectionDescription")]
        public string SapConnectionDescription { get; set; }

        [JsonProperty("SAPConnectionAddress")]
        public string SapConnectionAddress { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ConnectSynchronous { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ConnectToSession { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapGetSapTablePropertiesResponse
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

    public class SapGetSapTablePropertiesInput
    {
        public SapGetSapTablePropertiesInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapGetSapTableVisibleCellTextContentsAtIndexResponse
    {
        public string CellTextContents { get; set; }
        public string CellColumnName { get; set; }
        public int HorizontalScrollbarPosition { get; set; }
        public int VerticalScrollbarPosition { get; set; }
        public int EstimatedActualRowIndex { get; set; }
        public int EstimatedActualColumnIndex { get; set; }
    }

    public class SapGetSapTableVisibleCellTextContentsAtIndexInput
    {
        public SapGetSapTableVisibleCellTextContentsAtIndexInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VisibleRowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VisibleColumnIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CheckedElementValue { get; set; } = "True";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapGetSapTableVisibleCellPropertiesAtIndexResponse
    {
        [JsonProperty("SAPElementType")]
        public string SapElementType { get; set; }

        [JsonProperty("SAPElementTypeCode")]
        public int SapElementTypeCode { get; set; }

        [JsonProperty("SAPElementName")]
        public string SapElementName { get; set; }

        [JsonProperty("SAPElementId")]
        public string SapElementId { get; set; }

        [JsonProperty("SAPElementSubType")]
        public string SapElementSubType { get; set; }

        [JsonProperty("SAPElementTextValue")]
        public string SapElementTextValue { get; set; }

        [JsonProperty("SAPElementIsContainer")]
        public bool SapElementIsContainer { get; set; }

        [JsonProperty("SAPElementNumberOfChildren")]
        public int SapElementNumberOfChildren { get; set; }

        [JsonProperty("SAPElementIsChangeable")]
        public bool SapElementIsChangeable { get; set; }

        [JsonProperty("SAPElementIsModified")]
        public bool SapElementIsModified { get; set; }

        [JsonProperty("SAPElementIsSelected")]
        public bool SapElementIsSelected { get; set; }

        [JsonProperty("SAPElementIsHighlighted")]
        public bool SapElementIsHighlighted { get; set; }

        [JsonProperty("SAPElementIsVisible")]
        public bool SapElementIsVisible { get; set; }

        [JsonProperty("SAPElementLeftEdge")]
        public int SapElementLeftEdge { get; set; }

        [JsonProperty("SAPElementTopEdge")]
        public int SapElementTopEdge { get; set; }

        [JsonProperty("SAPElementWidth")]
        public int SapElementWidth { get; set; }

        [JsonProperty("SAPElementHeight")]
        public int SapElementHeight { get; set; }

        [JsonProperty("SAPElementRightEdge")]
        public int SapElementRightEdge { get; set; }

        [JsonProperty("SAPElementBottomEdge")]
        public int SapElementBottomEdge { get; set; }
        public string CellColumnName { get; set; }
        public int HorizontalScrollbarPosition { get; set; }
        public int VerticalScrollbarPosition { get; set; }
        public int EstimatedActualRowIndex { get; set; }
        public int EstimatedActualColumnIndex { get; set; }
    }

    public class SapGetSapTableVisibleCellPropertiesAtIndexInput
    {
        public SapGetSapTableVisibleCellPropertiesAtIndexInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VisibleRowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VisibleColumnIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapSetSapTableVisibleCellTextContentsAtIndexInput
    {
        public SapSetSapTableVisibleCellTextContentsAtIndexInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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

    public class SapCheckSapTableVisibleCellCheckboxAtIndexInput
    {
        public SapCheckSapTableVisibleCellCheckboxAtIndexInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VisibleRowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VisibleColumnIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckCellElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapPressSapTableVisibleCellAtIndexInput
    {
        public SapPressSapTableVisibleCellAtIndexInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VisibleRowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VisibleColumnIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapScrollSapTableInput
    {
        public SapScrollSapTableInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MoveHorizontalScrollbar { get; set; } = false;
        public int? HorizontalScrollbarPosition { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MoveVerticalScrollbar { get; set; } = false;
        public int? VerticalScrollbarPosition { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapGetTableVisibleTextContentsResponse
    {
        [JsonProperty("SAPTableTextContentsJSON")]
        public string SapTableTextContentsJson { get; set; }
        public int NumberOfRowsReturned { get; set; }
        public int NumberOfColumnsReturned { get; set; }
    }

    public class SapGetTableVisibleTextContentsInput
    {
        public SapGetTableVisibleTextContentsInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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

    public class SapSelectSapTableRowInput
    {
        public SapSelectSapTableRowInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VisibleRowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Select { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapSelectSapTableColumnInput
    {
        public SapSelectSapTableColumnInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? VisibleColumnIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Select { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapGetTreeNodesResponse
    {
        public int NumberOfNodesInTree { get; set; }

        [JsonProperty("SAPTreeNodesJSON")]
        public string SapTreeNodesJson { get; set; }
        public int NumberOfSelectedNodes { get; set; }
        public string CurrentlySelectedNode { get; set; }
        public string TreeType { get; set; }
        public string TreeSelectionMode { get; set; }
    }

    public class SapGetTreeNodesInput
    {
        public SapGetTreeNodesInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }
        public string ParentNodeKey { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ProcessSubNodes { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapDoubleClickTreeItemInput
    {
        public SapDoubleClickTreeItemInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }
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

    public class SapSelectTreeItemInput
    {
        public SapSelectTreeItemInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }
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

    public class SapExpandTreeNodeInput
    {
        public SapExpandTreeNodeInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }
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

    public class SapDeselectAllTreeNodesInput
    {
        public SapDeselectAllTreeNodesInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapPressKeyOnTreeInput
    {
        public SapPressKeyOnTreeInput(string searchSapElementId, string key)
        {
            this.SearchSapElementId = searchSapElementId;
            this.Key = key;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Key { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapOpenContextMenuOnTreeItemInput
    {
        public SapOpenContextMenuOnTreeItemInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }
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

    public class SapGetTreeTextContentsResponse
    {
        [JsonProperty("SAPTreeTextContentsJSON")]
        public string SapTreeTextContentsJson { get; set; }
        public int NumberOfRowsReturned { get; set; }
        public int NumberOfColumnsReturned { get; set; }
    }

    public class SapGetTreeTextContentsInput
    {
        public SapGetTreeTextContentsInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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

    public class SapSetTreeColumnWidthInput
    {
        public SapSetTreeColumnWidthInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }
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

    public class SapPressButtonOnTreeItemInput
    {
        public SapPressButtonOnTreeItemInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }
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

    public class SapClickLinkOnTreeItemInput
    {
        public SapClickLinkOnTreeItemInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }
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

    public class SapCheckTreeItemInput
    {
        public SapCheckTreeItemInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }
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

    public class SapGetTreeColumnHeadersResponse
    {
        [JsonProperty("SAPTreeColumnHeadersJSON")]
        public string SapTreeColumnHeadersJson { get; set; }
        public int NumberOfColumnHeaders { get; set; }
    }

    public class SapGetTreeColumnHeadersInput
    {
        public SapGetTreeColumnHeadersInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapGetTreeItemPropertiesResponse
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

    public class SapGetTreeItemPropertiesInput
    {
        public SapGetTreeItemPropertiesInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }
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

    public class SapGetShellToolbarElementsResponse
    {
        public int NumberOfToolbarButtons { get; set; }

        [JsonProperty("SAPShellToolbarElementsJSON")]
        public string SapShellToolbarElementsJson { get; set; }
    }

    public class SapGetShellToolbarElementsInput
    {
        public SapGetShellToolbarElementsInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapPressShellToolbarElementInput
    {
        public SapPressShellToolbarElementInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }
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

    public class SapPressShellToolbarElementContextButtonInput
    {
        public SapPressShellToolbarElementContextButtonInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }
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

    public class SapSelectShellToolbarMenuItemInput
    {
        public SapSelectShellToolbarMenuItemInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }
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

    public class SapGetSapGridViewPropertiesResponse
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

    public class SapGetSapGridViewPropertiesInput
    {
        public SapGetSapGridViewPropertiesInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapGetSapGridViewCellContentsAtIndexResponse
    {
        public string CellTextContents { get; set; }
        public bool CellIsChangeable { get; set; }
        public string CellType { get; set; }
        public bool CellIsChecked { get; set; }
    }

    public class SapGetSapGridViewCellContentsAtIndexInput
    {
        public SapGetSapGridViewCellContentsAtIndexInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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

    public class SapGetSapGridViewCellPropertiesAtIndexResponse
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

    public class SapGetSapGridViewCellPropertiesAtIndexInput
    {
        public SapGetSapGridViewCellPropertiesAtIndexInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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

    public class SapDrawRectangleAroundSapGridViewCellAtIndexInput
    {
        public SapDrawRectangleAroundSapGridViewCellAtIndexInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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

    public class SapGlobalLeftClickSapGridViewCellAtIndexInput
    {
        public SapGlobalLeftClickSapGridViewCellAtIndexInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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
        public SapGlobalLeftClickSapGridViewCellAtIndexInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SapGlobalLeftClickSapGridViewCellAtIndexInputOffsetRelativeToType
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

    public class SapGlobalRightClickSapGridViewCellAtIndexInput
    {
        public SapGlobalRightClickSapGridViewCellAtIndexInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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
        public SapGlobalRightClickSapGridViewCellAtIndexInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SapGlobalRightClickSapGridViewCellAtIndexInputOffsetRelativeToType
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

    public class SapGlobalDoubleLeftClickSapGridViewCellAtIndexInput
    {
        public SapGlobalDoubleLeftClickSapGridViewCellAtIndexInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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
        public SapGlobalDoubleLeftClickSapGridViewCellAtIndexInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DoubleClickDelayInMilliseconds { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SapGlobalDoubleLeftClickSapGridViewCellAtIndexInputOffsetRelativeToType
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

    public class SapGetSapGridViewColumnHeadersResponse
    {
        [JsonProperty("SAPGridViewColumnHeadersJSON")]
        public string SapGridViewColumnHeadersJson { get; set; }
        public int NumberOfColumnHeaders { get; set; }
    }

    public class SapGetSapGridViewColumnHeadersInput
    {
        public SapGetSapGridViewColumnHeadersInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapClickSapGridViewCellAtIndexInput
    {
        public SapClickSapGridViewCellAtIndexInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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

    public class SapDoubleClickSapGridViewCellAtIndexInput
    {
        public SapDoubleClickSapGridViewCellAtIndexInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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

    public class SapPressSapGridViewCellButtonAtIndexInput
    {
        public SapPressSapGridViewCellButtonAtIndexInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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

    public class SapCheckSapGridViewCellCheckboxAtIndexInput
    {
        public SapCheckSapGridViewCellCheckboxAtIndexInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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

    public class SapModifySapGridViewCellAtIndexResponse
    {
        public string ModifiedValue { get; set; }
    }

    public class SapModifySapGridViewCellAtIndexInput
    {
        public SapModifySapGridViewCellAtIndexInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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

    public class SapSetSapGridViewCurrentRowInput
    {
        public SapSetSapGridViewCurrentRowInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapPressSapGridViewColumnHeaderInput
    {
        public SapPressSapGridViewColumnHeaderInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapSetSapGridViewFirstVisibleRowResponse
    {
        public int ActualFirstVisibleRowIndex { get; set; }
    }

    public class SapSetSapGridViewFirstVisibleRowInput
    {
        public SapSetSapGridViewFirstVisibleRowInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int FirstVisibleRowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapSelectSapGridViewRowInput
    {
        public SapSelectSapGridViewRowInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SetAsCurrentRow { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapSelectSapGridViewMultipleRowsInput
    {
        public SapSelectSapGridViewMultipleRowsInput(string searchSapElementId, string rowsToSelect)
        {
            this.SearchSapElementId = searchSapElementId;
            this.RowsToSelect = rowsToSelect;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string RowsToSelect { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapSetSapGridViewCurrentColumnInput
    {
        public SapSetSapGridViewCurrentColumnInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapSetSapGridViewCurrentCellInput
    {
        public SapSetSapGridViewCurrentCellInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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

    public class SapSelectSapGridViewColumnInput
    {
        public SapSelectSapGridViewColumnInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }
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

    public class SapGridViewSelectAllInput
    {
        public SapGridViewSelectAllInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapGridViewDeselectAllInput
    {
        public SapGridViewDeselectAllInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapSetSapGridViewFirstVisibleColumnResponse
    {
        public string ActualFirstVisibleColumnName { get; set; }
    }

    public class SapSetSapGridViewFirstVisibleColumnInput
    {
        public SapSetSapGridViewFirstVisibleColumnInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }
        public string SearchColumnName { get; set; }
        public string SearchColumnTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsRegularExpression { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchColumnTitleIsCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapGridViewOpenContextMenuInput
    {
        public SapGridViewOpenContextMenuInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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

    public class SapGetGridViewTextContentsResponse
    {
        [JsonProperty("SAPGridViewTextContentsJSON")]
        public string SapGridViewTextContentsJson { get; set; }
        public int NumberOfRowsReturned { get; set; }
        public int NumberOfColumnsReturned { get; set; }
    }

    public class SapGetGridViewTextContentsInput
    {
        public SapGetGridViewTextContentsInput(string searchSapElementId)
        {
            this.SearchSapElementId = searchSapElementId;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

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

    public class SapSelectCalendarMonthInput
    {
        public SapSelectCalendarMonthInput(string searchSapElementId, int month, int year)
        {
            this.SearchSapElementId = searchSapElementId;
            this.Month = month;
            this.Year = year;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Month { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Year { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapSelectCalendarWeekInput
    {
        public SapSelectCalendarWeekInput(string searchSapElementId, int week, int year)
        {
            this.SearchSapElementId = searchSapElementId;
            this.Week = week;
            this.Year = year;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Week { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Year { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapSelectCalendarRangeInput
    {
        public SapSelectCalendarRangeInput(string searchSapElementId, string fromDateYyyymmdd, string toDateYyyymmdd)
        {
            this.SearchSapElementId = searchSapElementId;
            this.FromDateYyyymmdd = fromDateYyyymmdd;
            this.ToDateYyyymmdd = toDateYyyymmdd;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty("FromDateYYYYMMDD", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FromDateYyyymmdd { get; set; }

        [JsonProperty("ToDateYYYYMMDD", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ToDateYyyymmdd { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SapFocusCalendarDateInput
    {
        public SapFocusCalendarDateInput(string searchSapElementId, string dateYyyymmdd)
        {
            this.SearchSapElementId = searchSapElementId;
            this.DateYyyymmdd = dateYyyymmdd;
        }

        [JsonProperty("SearchSAPElementId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchSapElementId { get; set; }

        [JsonProperty("DateYYYYMMDD", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DateYyyymmdd { get; set; }

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