//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectuiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIADoesTopLevelWindowExistResponse, ApiConnectionActionConfiguration> UIADoesTopLevelWindowExist(Expression<Func<UIADoesTopLevelWindowExistInput>> uIADoesTopLevelWindowExist)
        {
            var __workflow_uIADoesTopLevelWindowExist = WorkflowExpression.Compile(uIADoesTopLevelWindowExist, nameof(uIADoesTopLevelWindowExist), required: true);
            return new DeferredBodyAction<UIADoesTopLevelWindowExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/DoesTopLevelWindowExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIADoesTopLevelWindowExist);
                return new ApiConnectionAction<UIADoesTopLevelWindowExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForTopLevelWindowResponse, ApiConnectionActionConfiguration> UIAGetHandleForTopLevelWindow(Expression<Func<UIAGetHandleForTopLevelWindowInput>> uIAGetHandleForTopLevelWindow)
        {
            var __workflow_uIAGetHandleForTopLevelWindow = WorkflowExpression.Compile(uIAGetHandleForTopLevelWindow, nameof(uIAGetHandleForTopLevelWindow), required: true);
            return new DeferredBodyAction<UIAGetHandleForTopLevelWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetHandleForTopLevelWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetHandleForTopLevelWindow);
                return new ApiConnectionAction<UIAGetHandleForTopLevelWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForTopLevelWindowResponse, ApiConnectionActionConfiguration> UIAWaitForTopLevelWindow(Expression<Func<UIAWaitForTopLevelWindowInput>> uIAWaitForTopLevelWindow)
        {
            var __workflow_uIAWaitForTopLevelWindow = WorkflowExpression.Compile(uIAWaitForTopLevelWindow, nameof(uIAWaitForTopLevelWindow), required: true);
            return new DeferredBodyAction<UIAWaitForTopLevelWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/WaitForTopLevelWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAWaitForTopLevelWindow);
                return new ApiConnectionAction<UIAWaitForTopLevelWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIADoesProcessHaveWindowResponse, ApiConnectionActionConfiguration> UIADoesProcessHaveWindow(Expression<Func<UIADoesProcessHaveWindowInput>> uIADoesProcessHaveWindow)
        {
            var __workflow_uIADoesProcessHaveWindow = WorkflowExpression.Compile(uIADoesProcessHaveWindow, nameof(uIADoesProcessHaveWindow), required: true);
            return new DeferredBodyAction<UIADoesProcessHaveWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/DoesProcessHaveWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIADoesProcessHaveWindow);
                return new ApiConnectionAction<UIADoesProcessHaveWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForProcessMainWindowResponse, ApiConnectionActionConfiguration> UIAGetHandleForProcessMainWindow(Expression<Func<UIAGetHandleForProcessMainWindowInput>> uIAGetHandleForProcessMainWindow)
        {
            var __workflow_uIAGetHandleForProcessMainWindow = WorkflowExpression.Compile(uIAGetHandleForProcessMainWindow, nameof(uIAGetHandleForProcessMainWindow), required: true);
            return new DeferredBodyAction<UIAGetHandleForProcessMainWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetHandleForProcessMainWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetHandleForProcessMainWindow);
                return new ApiConnectionAction<UIAGetHandleForProcessMainWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForProcessMainWindowResponse, ApiConnectionActionConfiguration> UIAWaitForProcessMainWindow(Expression<Func<UIAWaitForProcessMainWindowInput>> uIAWaitForProcessMainWindow)
        {
            var __workflow_uIAWaitForProcessMainWindow = WorkflowExpression.Compile(uIAWaitForProcessMainWindow, nameof(uIAWaitForProcessMainWindow), required: true);
            return new DeferredBodyAction<UIAWaitForProcessMainWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/WaitForProcessMainWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAWaitForProcessMainWindow);
                return new ApiConnectionAction<UIAWaitForProcessMainWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForProcessIdMainWindowResponse, ApiConnectionActionConfiguration> UIAGetHandleForProcessIdMainWindow(Expression<Func<UIAGetHandleForProcessIdMainWindowInput>> uIAGetHandleForProcessIdMainWindow)
        {
            var __workflow_uIAGetHandleForProcessIdMainWindow = WorkflowExpression.Compile(uIAGetHandleForProcessIdMainWindow, nameof(uIAGetHandleForProcessIdMainWindow), required: true);
            return new DeferredBodyAction<UIAGetHandleForProcessIdMainWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetHandleForProcessIdMainWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetHandleForProcessIdMainWindow);
                return new ApiConnectionAction<UIAGetHandleForProcessIdMainWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForProcessIdMainWindowResponse, ApiConnectionActionConfiguration> UIAWaitForProcessIdMainWindow(Expression<Func<UIAWaitForProcessIdMainWindowInput>> uIAWaitForProcessIdMainWindow)
        {
            var __workflow_uIAWaitForProcessIdMainWindow = WorkflowExpression.Compile(uIAWaitForProcessIdMainWindow, nameof(uIAWaitForProcessIdMainWindow), required: true);
            return new DeferredBodyAction<UIAWaitForProcessIdMainWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/WaitForProcessIdMainWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAWaitForProcessIdMainWindow);
                return new ApiConnectionAction<UIAWaitForProcessIdMainWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForFocussedElementResponse, ApiConnectionActionConfiguration> UIAGetHandleForFocussedElement(Expression<Func<UIAGetHandleForFocussedElementInput>> uIAGetHandleForFocussedElement)
        {
            var __workflow_uIAGetHandleForFocussedElement = WorkflowExpression.Compile(uIAGetHandleForFocussedElement, nameof(uIAGetHandleForFocussedElement), required: true);
            return new DeferredBodyAction<UIAGetHandleForFocussedElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetHandleForFocussedElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetHandleForFocussedElement);
                return new ApiConnectionAction<UIAGetHandleForFocussedElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForMainWindowOfFocussedElementResponse, ApiConnectionActionConfiguration> UIAGetHandleForMainWindowOfFocussedElement(Expression<Func<UIAGetHandleForMainWindowOfFocussedElementInput>> uIAGetHandleForMainWindowOfFocussedElement)
        {
            var __workflow_uIAGetHandleForMainWindowOfFocussedElement = WorkflowExpression.Compile(uIAGetHandleForMainWindowOfFocussedElement, nameof(uIAGetHandleForMainWindowOfFocussedElement), required: true);
            return new DeferredBodyAction<UIAGetHandleForMainWindowOfFocussedElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetHandleForMainWindowOfFocussedElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetHandleForMainWindowOfFocussedElement);
                return new ApiConnectionAction<UIAGetHandleForMainWindowOfFocussedElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForDesktopResponse, ApiConnectionActionConfiguration> UIAGetHandleForDesktop(Expression<Func<UIAGetHandleForDesktopInput>> uIAGetHandleForDesktop)
        {
            var __workflow_uIAGetHandleForDesktop = WorkflowExpression.Compile(uIAGetHandleForDesktop, nameof(uIAGetHandleForDesktop), required: true);
            return new DeferredBodyAction<UIAGetHandleForDesktopResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetHandleForDesktop";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetHandleForDesktop);
                return new ApiConnectionAction<UIAGetHandleForDesktopResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIASetForegroundWindow(Expression<Func<UIASetForegroundWindowInput>> uIASetForegroundWindow)
        {
            var __workflow_uIASetForegroundWindow = WorkflowExpression.Compile(uIASetForegroundWindow, nameof(uIASetForegroundWindow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/SetForegroundWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIASetForegroundWindow);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAMaximiseWindow(Expression<Func<UIAMaximiseWindowInput>> uIAMaximiseWindow)
        {
            var __workflow_uIAMaximiseWindow = WorkflowExpression.Compile(uIAMaximiseWindow, nameof(uIAMaximiseWindow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/MaximiseWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAMaximiseWindow);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAMinimiseWindow(Expression<Func<UIAMinimiseWindowInput>> uIAMinimiseWindow)
        {
            var __workflow_uIAMinimiseWindow = WorkflowExpression.Compile(uIAMinimiseWindow, nameof(uIAMinimiseWindow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/MinimiseWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAMinimiseWindow);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIASetWindowToNormal(Expression<Func<UIASetWindowToNormalInput>> uIASetWindowToNormal)
        {
            var __workflow_uIASetWindowToNormal = WorkflowExpression.Compile(uIASetWindowToNormal, nameof(uIASetWindowToNormal), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/SetWindowToNormal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIASetWindowToNormal);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIADoesElementExistResponse, ApiConnectionActionConfiguration> UIADoesElementExist(Expression<Func<UIADoesElementExistInput>> uIADoesElementExist)
        {
            var __workflow_uIADoesElementExist = WorkflowExpression.Compile(uIADoesElementExist, nameof(uIADoesElementExist), required: true);
            return new DeferredBodyAction<UIADoesElementExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/DoesElementExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIADoesElementExist);
                return new ApiConnectionAction<UIADoesElementExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIADoesDesktopElementExistResponse, ApiConnectionActionConfiguration> UIADoesDesktopElementExist(Expression<Func<UIADoesDesktopElementExistInput>> uIADoesDesktopElementExist)
        {
            var __workflow_uIADoesDesktopElementExist = WorkflowExpression.Compile(uIADoesDesktopElementExist, nameof(uIADoesDesktopElementExist), required: true);
            return new DeferredBodyAction<UIADoesDesktopElementExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/DoesDesktopElementExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIADoesDesktopElementExist);
                return new ApiConnectionAction<UIADoesDesktopElementExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForElementResponse, ApiConnectionActionConfiguration> UIAWaitForElement(Expression<Func<UIAWaitForElementInput>> uIAWaitForElement)
        {
            var __workflow_uIAWaitForElement = WorkflowExpression.Compile(uIAWaitForElement, nameof(uIAWaitForElement), required: true);
            return new DeferredBodyAction<UIAWaitForElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/WaitForElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAWaitForElement);
                return new ApiConnectionAction<UIAWaitForElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForDesktopElementResponse, ApiConnectionActionConfiguration> UIAWaitForDesktopElement(Expression<Func<UIAWaitForDesktopElementInput>> uIAWaitForDesktopElement)
        {
            var __workflow_uIAWaitForDesktopElement = WorkflowExpression.Compile(uIAWaitForDesktopElement, nameof(uIAWaitForDesktopElement), required: true);
            return new DeferredBodyAction<UIAWaitForDesktopElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/WaitForDesktopElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElement);
                return new ApiConnectionAction<UIAWaitForDesktopElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForElementToNotExistResponse, ApiConnectionActionConfiguration> UIAWaitForElementToNotExist(Expression<Func<UIAWaitForElementToNotExistInput>> uIAWaitForElementToNotExist)
        {
            var __workflow_uIAWaitForElementToNotExist = WorkflowExpression.Compile(uIAWaitForElementToNotExist, nameof(uIAWaitForElementToNotExist), required: true);
            return new DeferredBodyAction<UIAWaitForElementToNotExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAWaitForElementToNotExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementToNotExist);
                return new ApiConnectionAction<UIAWaitForElementToNotExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForDesktopElementToNotExistResponse, ApiConnectionActionConfiguration> UIAWaitForDesktopElementToNotExist(Expression<Func<UIAWaitForDesktopElementToNotExistInput>> uIAWaitForDesktopElementToNotExist)
        {
            var __workflow_uIAWaitForDesktopElementToNotExist = WorkflowExpression.Compile(uIAWaitForDesktopElementToNotExist, nameof(uIAWaitForDesktopElementToNotExist), required: true);
            return new DeferredBodyAction<UIAWaitForDesktopElementToNotExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAWaitForDesktopElementToNotExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementToNotExist);
                return new ApiConnectionAction<UIAWaitForDesktopElementToNotExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAPressElement(Expression<Func<UIAPressElementInput>> uIAPressElement)
        {
            var __workflow_uIAPressElement = WorkflowExpression.Compile(uIAPressElement, nameof(uIAPressElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/PressElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAPressElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAGlobalMouseClickOnElement(Expression<Func<UIAGlobalMouseClickOnElementInput>> uIAGlobalMouseClickOnElement)
        {
            var __workflow_uIAGlobalMouseClickOnElement = WorkflowExpression.Compile(uIAGlobalMouseClickOnElement, nameof(uIAGlobalMouseClickOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GlobalMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAGlobalRightMouseClickOnElement(Expression<Func<UIAGlobalRightMouseClickOnElementInput>> uIAGlobalRightMouseClickOnElement)
        {
            var __workflow_uIAGlobalRightMouseClickOnElement = WorkflowExpression.Compile(uIAGlobalRightMouseClickOnElement, nameof(uIAGlobalRightMouseClickOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GlobalRightMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGlobalRightMouseClickOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAGlobalMiddleMouseClickOnElement(Expression<Func<UIAGlobalMiddleMouseClickOnElementInput>> uIAGlobalMiddleMouseClickOnElement)
        {
            var __workflow_uIAGlobalMiddleMouseClickOnElement = WorkflowExpression.Compile(uIAGlobalMiddleMouseClickOnElement, nameof(uIAGlobalMiddleMouseClickOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GlobalMiddleMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGlobalMiddleMouseClickOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAGlobalDoubleLeftMouseClickOnElement(Expression<Func<UIAGlobalDoubleLeftMouseClickOnElementInput>> uIAGlobalDoubleLeftMouseClickOnElement)
        {
            var __workflow_uIAGlobalDoubleLeftMouseClickOnElement = WorkflowExpression.Compile(uIAGlobalDoubleLeftMouseClickOnElement, nameof(uIAGlobalDoubleLeftMouseClickOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GlobalDoubleLeftMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGlobalDoubleLeftMouseClickOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIASelectElement(Expression<Func<UIASelectElementInput>> uIASelectElement)
        {
            var __workflow_uIASelectElement = WorkflowExpression.Compile(uIASelectElement, nameof(uIASelectElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/SelectElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIASelectElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAInputPasswordIntoElement(Expression<Func<UIAInputPasswordIntoElementInput>> uIAInputPasswordIntoElement)
        {
            var __workflow_uIAInputPasswordIntoElement = WorkflowExpression.Compile(uIAInputPasswordIntoElement, nameof(uIAInputPasswordIntoElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/InputPasswordIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAInputPasswordIntoElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAInputTextIntoElement(Expression<Func<UIAInputTextIntoElementInput>> uIAInputTextIntoElement)
        {
            var __workflow_uIAInputTextIntoElement = WorkflowExpression.Compile(uIAInputTextIntoElement, nameof(uIAInputTextIntoElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/InputTextIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAInputTextIntoMultipleElements(Expression<Func<UIAInputTextIntoMultipleElementsInput>> uIAInputTextIntoMultipleElements)
        {
            var __workflow_uIAInputTextIntoMultipleElements = WorkflowExpression.Compile(uIAInputTextIntoMultipleElements, nameof(uIAInputTextIntoMultipleElements), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAInputTextIntoMultipleElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoMultipleElements);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAInputReturnIntoElement(Expression<Func<UIAInputReturnIntoElementInput>> uIAInputReturnIntoElement)
        {
            var __workflow_uIAInputReturnIntoElement = WorkflowExpression.Compile(uIAInputReturnIntoElement, nameof(uIAInputReturnIntoElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/InputReturnIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAInputReturnIntoElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAFocusElement(Expression<Func<UIAFocusElementInput>> uIAFocusElement)
        {
            var __workflow_uIAFocusElement = WorkflowExpression.Compile(uIAFocusElement, nameof(uIAFocusElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/FocusElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAFocusElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAToggleElement(Expression<Func<UIAToggleElementInput>> uIAToggleElement)
        {
            var __workflow_uIAToggleElement = WorkflowExpression.Compile(uIAToggleElement, nameof(uIAToggleElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/ToggleElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAToggleElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIACheckElement(Expression<Func<UIACheckElementInput>> uIACheckElement)
        {
            var __workflow_uIACheckElement = WorkflowExpression.Compile(uIACheckElement, nameof(uIACheckElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/CheckElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIACheckElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIACheckMultipleElements(Expression<Func<UIACheckMultipleElementsInput>> uIACheckMultipleElements)
        {
            var __workflow_uIACheckMultipleElements = WorkflowExpression.Compile(uIACheckMultipleElements, nameof(uIACheckMultipleElements), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIACheckMultipleElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIACheckMultipleElements);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAIsElementCheckedResponse, ApiConnectionActionConfiguration> UIAIsElementChecked(Expression<Func<UIAIsElementCheckedInput>> uIAIsElementChecked)
        {
            var __workflow_uIAIsElementChecked = WorkflowExpression.Compile(uIAIsElementChecked, nameof(uIAIsElementChecked), required: true);
            return new DeferredBodyAction<UIAIsElementCheckedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAIsElementChecked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAIsElementChecked);
                return new ApiConnectionAction<UIAIsElementCheckedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIACloseElementWindow(Expression<Func<UIACloseElementWindowInput>> uIACloseElementWindow)
        {
            var __workflow_uIACloseElementWindow = WorkflowExpression.Compile(uIACloseElementWindow, nameof(uIACloseElementWindow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/CloseElementWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIACloseElementWindow);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementTextValueResponse, ApiConnectionActionConfiguration> UIAGetElementTextValue(Expression<Func<UIAGetElementTextValueInput>> uIAGetElementTextValue)
        {
            var __workflow_uIAGetElementTextValue = WorkflowExpression.Compile(uIAGetElementTextValue, nameof(uIAGetElementTextValue), required: true);
            return new DeferredBodyAction<UIAGetElementTextValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetElementTextValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetElementTextValue);
                return new ApiConnectionAction<UIAGetElementTextValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementValueResponse, ApiConnectionActionConfiguration> UIAGetElementValue(Expression<Func<UIAGetElementValueInput>> uIAGetElementValue)
        {
            var __workflow_uIAGetElementValue = WorkflowExpression.Compile(uIAGetElementValue, nameof(uIAGetElementValue), required: true);
            return new DeferredBodyAction<UIAGetElementValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetElementValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetElementValue);
                return new ApiConnectionAction<UIAGetElementValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementLabelValueResponse, ApiConnectionActionConfiguration> UIAGetElementLabelValue(Expression<Func<UIAGetElementLabelValueInput>> uIAGetElementLabelValue)
        {
            var __workflow_uIAGetElementLabelValue = WorkflowExpression.Compile(uIAGetElementLabelValue, nameof(uIAGetElementLabelValue), required: true);
            return new DeferredBodyAction<UIAGetElementLabelValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetElementLabelValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetElementLabelValue);
                return new ApiConnectionAction<UIAGetElementLabelValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementPropertiesResponse, ApiConnectionActionConfiguration> UIAGetElementProperties(Expression<Func<UIAGetElementPropertiesInput>> uIAGetElementProperties)
        {
            var __workflow_uIAGetElementProperties = WorkflowExpression.Compile(uIAGetElementProperties, nameof(uIAGetElementProperties), required: true);
            return new DeferredBodyAction<UIAGetElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetElementProperties);
                return new ApiConnectionAction<UIAGetElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetMultipleElementPropertiesResponse, ApiConnectionActionConfiguration> UIAGetMultipleElementProperties(Expression<Func<UIAGetMultipleElementPropertiesInput>> uIAGetMultipleElementProperties)
        {
            var __workflow_uIAGetMultipleElementProperties = WorkflowExpression.Compile(uIAGetMultipleElementProperties, nameof(uIAGetMultipleElementProperties), required: true);
            return new DeferredBodyAction<UIAGetMultipleElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetMultipleElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementProperties);
                return new ApiConnectionAction<UIAGetMultipleElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetDesktopElementsResponse, ApiConnectionActionConfiguration> UIAGetDesktopElements(Expression<Func<UIAGetDesktopElementsInput>> uIAGetDesktopElements)
        {
            var __workflow_uIAGetDesktopElements = WorkflowExpression.Compile(uIAGetDesktopElements, nameof(uIAGetDesktopElements), required: true);
            return new DeferredBodyAction<UIAGetDesktopElementsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetDesktopElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetDesktopElements);
                return new ApiConnectionAction<UIAGetDesktopElementsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAExpandElement(Expression<Func<UIAExpandElementInput>> uIAExpandElement)
        {
            var __workflow_uIAExpandElement = WorkflowExpression.Compile(uIAExpandElement, nameof(uIAExpandElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/ExpandElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAExpandElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIACollapseElement(Expression<Func<UIACollapseElementInput>> uIACollapseElement)
        {
            var __workflow_uIACollapseElement = WorkflowExpression.Compile(uIACollapseElement, nameof(uIACollapseElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/CollapseElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIACollapseElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIATakeScreenShotOfElementLocationResponse, ApiConnectionActionConfiguration> UIATakeScreenShotOfElementLocation(Expression<Func<UIATakeScreenShotOfElementLocationInput>> uIATakeScreenShotOfElementLocation)
        {
            var __workflow_uIATakeScreenShotOfElementLocation = WorkflowExpression.Compile(uIATakeScreenShotOfElementLocation, nameof(uIATakeScreenShotOfElementLocation), required: true);
            return new DeferredBodyAction<UIATakeScreenShotOfElementLocationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/TakeScreenShotOfElementLocation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIATakeScreenShotOfElementLocation);
                return new ApiConnectionAction<UIATakeScreenShotOfElementLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIADrawRectangleAroundElement(Expression<Func<UIADrawRectangleAroundElementInput>> uIADrawRectangleAroundElement)
        {
            var __workflow_uIADrawRectangleAroundElement = WorkflowExpression.Compile(uIADrawRectangleAroundElement, nameof(uIADrawRectangleAroundElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/DrawRectangleAroundElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIADrawRectangleAroundElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetParentElementHandleResponse, ApiConnectionActionConfiguration> UIAGetParentElementHandle(Expression<Func<UIAGetParentElementHandleInput>> uIAGetParentElementHandle)
        {
            var __workflow_uIAGetParentElementHandle = WorkflowExpression.Compile(uIAGetParentElementHandle, nameof(uIAGetParentElementHandle), required: true);
            return new DeferredBodyAction<UIAGetParentElementHandleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetParentElementHandle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetParentElementHandle);
                return new ApiConnectionAction<UIAGetParentElementHandleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetDataGridElementContentsResponse, ApiConnectionActionConfiguration> UIAGetDataGridElementContents(Expression<Func<UIAGetDataGridElementContentsInput>> uIAGetDataGridElementContents)
        {
            var __workflow_uIAGetDataGridElementContents = WorkflowExpression.Compile(uIAGetDataGridElementContents, nameof(uIAGetDataGridElementContents), required: true);
            return new DeferredBodyAction<UIAGetDataGridElementContentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetDataGridElementContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContents);
                return new ApiConnectionAction<UIAGetDataGridElementContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetDataGridElementPropertiesResponse, ApiConnectionActionConfiguration> UIAGetDataGridElementProperties(Expression<Func<UIAGetDataGridElementPropertiesInput>> uIAGetDataGridElementProperties)
        {
            var __workflow_uIAGetDataGridElementProperties = WorkflowExpression.Compile(uIAGetDataGridElementProperties, nameof(uIAGetDataGridElementProperties), required: true);
            return new DeferredBodyAction<UIAGetDataGridElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetDataGridElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementProperties);
                return new ApiConnectionAction<UIAGetDataGridElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetListElementItemsResponse, ApiConnectionActionConfiguration> UIAGetListElementItems(Expression<Func<UIAGetListElementItemsInput>> uIAGetListElementItems)
        {
            var __workflow_uIAGetListElementItems = WorkflowExpression.Compile(uIAGetListElementItems, nameof(uIAGetListElementItems), required: true);
            return new DeferredBodyAction<UIAGetListElementItemsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetListElementItems";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetListElementItems);
                return new ApiConnectionAction<UIAGetListElementItemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAClickListElementItemByName(Expression<Func<UIAClickListElementItemByNameInput>> uIAClickListElementItemByName)
        {
            var __workflow_uIAClickListElementItemByName = WorkflowExpression.Compile(uIAClickListElementItemByName, nameof(uIAClickListElementItemByName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/ClickListElementItemByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByName);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAClickListElementItemByIndex(Expression<Func<UIAClickListElementItemByIndexInput>> uIAClickListElementItemByIndex)
        {
            var __workflow_uIAClickListElementItemByIndex = WorkflowExpression.Compile(uIAClickListElementItemByIndex, nameof(uIAClickListElementItemByIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/ClickListElementItemByIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIASetElementToNumericValue(Expression<Func<UIASetElementToNumericValueInput>> uIASetElementToNumericValue)
        {
            var __workflow_uIASetElementToNumericValue = WorkflowExpression.Compile(uIASetElementToNumericValue, nameof(uIASetElementToNumericValue), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIASetElementToNumericValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericValue);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIASetElementToNumericRangeValue(Expression<Func<UIASetElementToNumericRangeValueInput>> uIASetElementToNumericRangeValue)
        {
            var __workflow_uIASetElementToNumericRangeValue = WorkflowExpression.Compile(uIASetElementToNumericRangeValue, nameof(uIASetElementToNumericRangeValue), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIASetElementToNumericRangeValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericRangeValue);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAResetAllElementHandles(Expression<Func<UIAResetAllElementHandlesInput>> uIAResetAllElementHandles)
        {
            var __workflow_uIAResetAllElementHandles = WorkflowExpression.Compile(uIAResetAllElementHandles, nameof(uIAResetAllElementHandles), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAResetAllElementHandles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAResetAllElementHandles);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAGlobalPasswordInputIntoElement(Expression<Func<UIAGlobalPasswordInputIntoElementInput>> uIAGlobalPasswordInputIntoElement)
        {
            var __workflow_uIAGlobalPasswordInputIntoElement = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElement, nameof(uIAGlobalPasswordInputIntoElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGlobalPasswordInputIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAGlobalTextInputIntoElement(Expression<Func<UIAGlobalTextInputIntoElementInput>> uIAGlobalTextInputIntoElement)
        {
            var __workflow_uIAGlobalTextInputIntoElement = WorkflowExpression.Compile(uIAGlobalTextInputIntoElement, nameof(uIAGlobalTextInputIntoElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGlobalTextInputIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementPropertiesAsListResponse, ApiConnectionActionConfiguration> UIAGetElementPropertiesAsList(Expression<Func<UIAGetElementPropertiesAsListInput>> uIAGetElementPropertiesAsList)
        {
            var __workflow_uIAGetElementPropertiesAsList = WorkflowExpression.Compile(uIAGetElementPropertiesAsList, nameof(uIAGetElementPropertiesAsList), required: true);
            return new DeferredBodyAction<UIAGetElementPropertiesAsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGetElementPropertiesAsList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetElementPropertiesAsList);
                return new ApiConnectionAction<UIAGetElementPropertiesAsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIASetTransactionTimeout(Expression<Func<UIASetTransactionTimeoutInput>> uIASetTransactionTimeout)
        {
            var __workflow_uIASetTransactionTimeout = WorkflowExpression.Compile(uIASetTransactionTimeout, nameof(uIASetTransactionTimeout), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIASetTransactionTimeout";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIASetTransactionTimeout);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementAtCoordinatesResponse, ApiConnectionActionConfiguration> UIAGetElementAtCoordinates(Expression<Func<UIAGetElementAtCoordinatesInput>> uIAGetElementAtCoordinates)
        {
            var __workflow_uIAGetElementAtCoordinates = WorkflowExpression.Compile(uIAGetElementAtCoordinates, nameof(uIAGetElementAtCoordinates), required: true);
            return new DeferredBodyAction<UIAGetElementAtCoordinatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGetElementAtCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetElementAtCoordinates);
                return new ApiConnectionAction<UIAGetElementAtCoordinatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetMultipleParentElementPropertiesResponse, ApiConnectionActionConfiguration> UIAGetMultipleParentElementProperties(Expression<Func<UIAGetMultipleParentElementPropertiesInput>> uIAGetMultipleParentElementProperties)
        {
            var __workflow_uIAGetMultipleParentElementProperties = WorkflowExpression.Compile(uIAGetMultipleParentElementProperties, nameof(uIAGetMultipleParentElementProperties), required: true);
            return new DeferredBodyAction<UIAGetMultipleParentElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGetMultipleParentElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleParentElementProperties);
                return new ApiConnectionAction<UIAGetMultipleParentElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIASearchForFirstParentElementResponse, ApiConnectionActionConfiguration> UIASearchForFirstParentElement(Expression<Func<UIASearchForFirstParentElementInput>> uIASearchForFirstParentElement)
        {
            var __workflow_uIASearchForFirstParentElement = WorkflowExpression.Compile(uIASearchForFirstParentElement, nameof(uIASearchForFirstParentElement), required: true);
            return new DeferredBodyAction<UIASearchForFirstParentElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIASearchForFirstParentElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIASearchForFirstParentElement);
                return new ApiConnectionAction<UIASearchForFirstParentElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetMultipleElementsAsTableResponse, ApiConnectionActionConfiguration> UIAGetMultipleElementsAsTable(Expression<Func<UIAGetMultipleElementsAsTableInput>> uIAGetMultipleElementsAsTable)
        {
            var __workflow_uIAGetMultipleElementsAsTable = WorkflowExpression.Compile(uIAGetMultipleElementsAsTable, nameof(uIAGetMultipleElementsAsTable), required: true);
            return new DeferredBodyAction<UIAGetMultipleElementsAsTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGetMultipleElementsAsTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTable);
                return new ApiConnectionAction<UIAGetMultipleElementsAsTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIASetElementScrollPercentageResponse, ApiConnectionActionConfiguration> UIASetElementScrollPercentage(Expression<Func<UIASetElementScrollPercentageInput>> uIASetElementScrollPercentage)
        {
            var __workflow_uIASetElementScrollPercentage = WorkflowExpression.Compile(uIASetElementScrollPercentage, nameof(uIASetElementScrollPercentage), required: true);
            return new DeferredBodyAction<UIASetElementScrollPercentageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIASetElementScrollPercentage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIASetElementScrollPercentage);
                return new ApiConnectionAction<UIASetElementScrollPercentageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementSearchColourRegionResponse, ApiConnectionActionConfiguration> UIAGetElementSearchColourRegion(Expression<Func<UIAGetElementSearchColourRegionInput>> uIAGetElementSearchColourRegion)
        {
            var __workflow_uIAGetElementSearchColourRegion = WorkflowExpression.Compile(uIAGetElementSearchColourRegion, nameof(uIAGetElementSearchColourRegion), required: true);
            return new DeferredBodyAction<UIAGetElementSearchColourRegionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGetElementSearchColourRegion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegion);
                return new ApiConnectionAction<UIAGetElementSearchColourRegionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGlobalMouseClickElementSearchColourRegionResponse, ApiConnectionActionConfiguration> UIAGlobalMouseClickElementSearchColourRegion(Expression<Func<UIAGlobalMouseClickElementSearchColourRegionInput>> uIAGlobalMouseClickElementSearchColourRegion)
        {
            var __workflow_uIAGlobalMouseClickElementSearchColourRegion = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegion, nameof(uIAGlobalMouseClickElementSearchColourRegion), required: true);
            return new DeferredBodyAction<UIAGlobalMouseClickElementSearchColourRegionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGlobalMouseClickElementSearchColourRegion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegion);
                return new ApiConnectionAction<UIAGlobalMouseClickElementSearchColourRegionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetWin32WindowsResponse, ApiConnectionActionConfiguration> UIAGetWin32Windows(Expression<Func<UIAGetWin32WindowsInput>> uIAGetWin32Windows)
        {
            var __workflow_uIAGetWin32Windows = WorkflowExpression.Compile(uIAGetWin32Windows, nameof(uIAGetWin32Windows), required: true);
            return new DeferredBodyAction<UIAGetWin32WindowsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetWin32Windows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetWin32Windows);
                return new ApiConnectionAction<UIAGetWin32WindowsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<SetUIAElementSearchModeResponse, ApiConnectionActionConfiguration> SetUIAElementSearchMode(Expression<Func<SetUIAElementSearchModeInput>> setUIAElementSearchMode)
        {
            var __workflow_setUIAElementSearchMode = WorkflowExpression.Compile(setUIAElementSearchMode, nameof(setUIAElementSearchMode), required: true);
            return new DeferredBodyAction<SetUIAElementSearchModeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/SetUIAElementSearchMode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_setUIAElementSearchMode);
                return new ApiConnectionAction<SetUIAElementSearchModeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<GetUIAElementSearchModeResponse, ApiConnectionActionConfiguration> GetUIAElementSearchMode(Expression<Func<GetUIAElementSearchModeInput>> getUIAElementSearchMode)
        {
            var __workflow_getUIAElementSearchMode = WorkflowExpression.Compile(getUIAElementSearchMode, nameof(getUIAElementSearchMode), required: true);
            return new DeferredBodyAction<GetUIAElementSearchModeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetUIAElementSearchMode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getUIAElementSearchMode);
                return new ApiConnectionAction<GetUIAElementSearchModeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementPatternsResponse, ApiConnectionActionConfiguration> UIAGetElementPatterns(Expression<Func<UIAGetElementPatternsInput>> uIAGetElementPatterns)
        {
            var __workflow_uIAGetElementPatterns = WorkflowExpression.Compile(uIAGetElementPatterns, nameof(uIAGetElementPatterns), required: true);
            return new DeferredBodyAction<UIAGetElementPatternsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGetElementPatterns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAGetElementPatterns);
                return new ApiConnectionAction<UIAGetElementPatternsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAMoveElementResponse, ApiConnectionActionConfiguration> UIAMoveElement(Expression<Func<UIAMoveElementInput>> uIAMoveElement)
        {
            var __workflow_uIAMoveElement = WorkflowExpression.Compile(uIAMoveElement, nameof(uIAMoveElement), required: true);
            return new DeferredBodyAction<UIAMoveElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAMoveElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAMoveElement);
                return new ApiConnectionAction<UIAMoveElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAResizeElementResponse, ApiConnectionActionConfiguration> UIAResizeElement(Expression<Func<UIAResizeElementInput>> uIAResizeElement)
        {
            var __workflow_uIAResizeElement = WorkflowExpression.Compile(uIAResizeElement, nameof(uIAResizeElement), required: true);
            return new DeferredBodyAction<UIAResizeElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAResizeElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAResizeElement);
                return new ApiConnectionAction<UIAResizeElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIALocateVisibleSearchImageWithinElementResponse, ApiConnectionActionConfiguration> UIALocateVisibleSearchImageWithinElement(Expression<Func<UIALocateVisibleSearchImageWithinElementInput>> uIALocateVisibleSearchImageWithinElement)
        {
            var __workflow_uIALocateVisibleSearchImageWithinElement = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElement, nameof(uIALocateVisibleSearchImageWithinElement), required: true);
            return new DeferredBodyAction<UIALocateVisibleSearchImageWithinElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIALocateVisibleSearchImageWithinElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElement);
                return new ApiConnectionAction<UIALocateVisibleSearchImageWithinElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForVisibleSearchImageWithinElementResponse, ApiConnectionActionConfiguration> UIAWaitForVisibleSearchImageWithinElement(Expression<Func<UIAWaitForVisibleSearchImageWithinElementInput>> uIAWaitForVisibleSearchImageWithinElement)
        {
            var __workflow_uIAWaitForVisibleSearchImageWithinElement = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElement, nameof(uIAWaitForVisibleSearchImageWithinElement), required: true);
            return new DeferredBodyAction<UIAWaitForVisibleSearchImageWithinElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAWaitForVisibleSearchImageWithinElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElement);
                return new ApiConnectionAction<UIAWaitForVisibleSearchImageWithinElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForVisibleSearchImageToNotExistWithinElementResponse, ApiConnectionActionConfiguration> UIAWaitForVisibleSearchImageToNotExistWithinElement(Expression<Func<UIAWaitForVisibleSearchImageToNotExistWithinElementInput>> uIAWaitForVisibleSearchImageToNotExistWithinElement)
        {
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElement = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElement, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElement), required: true);
            return new DeferredBodyAction<UIAWaitForVisibleSearchImageToNotExistWithinElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAWaitForVisibleSearchImageToNotExistWithinElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElement);
                return new ApiConnectionAction<UIAWaitForVisibleSearchImageToNotExistWithinElementResponse>(callPayload);
            });
        }
    }

    public class IaconnectuiTriggers([ConnectionName] string connectionId)
    {
    }

    public class UIADoesTopLevelWindowExistResponse
    {
        public bool WindowExists { get; set; }
    }

    public class UIADoesTopLevelWindowExistInput
    {
        public string SearchClassName { get; set; }
        public string SearchWindowTitle { get; set; }
        public int? SearchProcessId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGetHandleForTopLevelWindowResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAGetHandleForTopLevelWindowInput
    {
        public string SearchClassName { get; set; }
        public string SearchWindowTitle { get; set; }
        public int? SearchProcessId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAWaitForTopLevelWindowResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
        public bool ElementExists { get; set; }
    }

    public class UIAWaitForTopLevelWindowInput
    {
        public string SearchClassName { get; set; }
        public string SearchWindowTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SecondsToWait { get; set; } = 10;
        public int? SearchProcessId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfWindowNotFound { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIADoesProcessHaveWindowResponse
    {
        public bool ProcessHasWindow { get; set; }
    }

    public class UIADoesProcessHaveWindowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchProcessName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGetHandleForProcessMainWindowResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAGetHandleForProcessMainWindowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchProcessName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAWaitForProcessMainWindowResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
        public bool ElementExists { get; set; }
    }

    public class UIAWaitForProcessMainWindowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchProcessName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SecondsToWait { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGetHandleForProcessIdMainWindowResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAGetHandleForProcessIdMainWindowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ProcessId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAWaitForProcessIdMainWindowResponse
    {
        public bool ElementExists { get; set; }
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAWaitForProcessIdMainWindowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ProcessId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SecondsToWait { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGetHandleForFocussedElementResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAGetHandleForFocussedElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGetHandleForMainWindowOfFocussedElementResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAGetHandleForMainWindowOfFocussedElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGetHandleForDesktopResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAGetHandleForDesktopInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIASetForegroundWindowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int WindowHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleWindow { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ToggleUsesGlobalLeftMouseClickAgent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? ToggleDelay { get; set; } = 0.25;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAMaximiseWindowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int WindowHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAMinimiseWindowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int WindowHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIASetWindowToNormalInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int WindowHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIADoesElementExistResponse
    {
        public bool ElementExists { get; set; }
        public int ElementHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIADoesElementExistInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }
        public int? SearchProcessId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnElementHandle { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeChildProcesses { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIADoesDesktopElementExistResponse
    {
        public bool ElementExists { get; set; }
        public int ElementHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIADoesDesktopElementExistInput
    {
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }
        public int? SearchProcessId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnElementHandle { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeChildProcesses { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAWaitForElementResponse
    {
        public bool ElementExists { get; set; }
        public int ElementHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAWaitForElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }
        public int? SearchProcessId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnElementHandle { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SecondsToWait { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeChildProcesses { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfElementNotFound { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAWaitForDesktopElementResponse
    {
        public bool ElementExists { get; set; }
        public int ElementHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAWaitForDesktopElementInput
    {
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchProcessId { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnElementHandle { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SecondsToWait { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeChildProcesses { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfElementNotFound { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAWaitForElementToNotExistResponse
    {
        public bool ElementExistsBeforeWait { get; set; }
        public bool ElementExistsAfterWait { get; set; }
    }

    public class UIAWaitForElementToNotExistInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }
        public int? SearchProcessId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SecondsToWait { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeChildProcesses { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfElementStillExists { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAWaitForDesktopElementToNotExistResponse
    {
        public bool ElementExistsBeforeWait { get; set; }
        public bool ElementExistsAfterWait { get; set; }
    }

    public class UIAWaitForDesktopElementToNotExistInput
    {
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }
        public int? SearchProcessId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SecondsToWait { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeChildProcesses { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfElementStillExists { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAPressElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Wait { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Win32ClickButton { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TryInvokePattern { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TryLegacyPattern { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGlobalMouseClickOnElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FocusElementFirst { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetX { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetY { get; set; } = 0;
        public UIAGlobalMouseClickOnElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ValidateClickablePointWithinElementBoundary { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIAGlobalMouseClickOnElementInputOffsetRelativeToType
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

    public class UIAGlobalRightMouseClickOnElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FocusElementFirst { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetX { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetY { get; set; } = 0;
        public UIAGlobalRightMouseClickOnElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ValidateClickablePointWithinElementBoundary { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIAGlobalRightMouseClickOnElementInputOffsetRelativeToType
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

    public class UIAGlobalMiddleMouseClickOnElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FocusElementFirst { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetX { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetY { get; set; } = 0;
        public UIAGlobalMiddleMouseClickOnElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ValidateClickablePointWithinElementBoundary { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIAGlobalMiddleMouseClickOnElementInputOffsetRelativeToType
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

    public class UIAGlobalDoubleLeftMouseClickOnElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DelayInMilliseconds { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FocusElementFirst { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetX { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetY { get; set; } = 0;
        public UIAGlobalDoubleLeftMouseClickOnElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ValidateClickablePointWithinElementBoundary { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIAGlobalDoubleLeftMouseClickOnElementInputOffsetRelativeToType
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

    public class UIASelectElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAInputPasswordIntoElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PasswordToInput { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PasswordContainsStoredPassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TryValuePattern { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TryLegacyPattern { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAInputTextIntoElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;
        public string TextToInput { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReplaceExistingValue { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? InsertPosition { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfInputValidationFails { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TryValuePattern { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TryLegacyPattern { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAInputTextIntoMultipleElementsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputElementsJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAInputReturnIntoElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReplaceExistingValue { get; set; } = false;
        public int? InsertPosition { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfInputValidationFails { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TryValuePattern { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TryLegacyPattern { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAFocusElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAToggleElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIACheckElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIACheckMultipleElementsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputElementsJSON { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAIsElementCheckedResponse
    {
        public bool ElementIsChecked { get; set; }
    }

    public class UIAIsElementCheckedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIACloseElementWindowInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGetElementTextValueResponse
    {
        public string ElementTextValue { get; set; }
    }

    public class UIAGetElementTextValueInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGetElementValueResponse
    {
        public string ElementValue { get; set; }
    }

    public class UIAGetElementValueInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGetElementLabelValueResponse
    {
        public string ElementLabelValue { get; set; }
    }

    public class UIAGetElementLabelValueInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGetElementPropertiesResponse
    {
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementFrameworkId { get; set; }
        public string ElementControlType { get; set; }
        public string ElementLocalizedControlType { get; set; }
        public bool ElementIsEnabled { get; set; }
        public bool ElementIsOffscreen { get; set; }
        public bool ElementIsKeyboardFocusable { get; set; }
        public bool ElementHasKeyboardFocus { get; set; }
        public bool ElementIsPasswordField { get; set; }
        public string ElementAcceleratorKey { get; set; }
        public string ElementAccessKey { get; set; }
        public int ElementLeftEdge { get; set; }
        public int ElementRightEdge { get; set; }
        public int ElementTopEdge { get; set; }
        public int ElementBottomEdge { get; set; }
        public int ElementClickablePointX { get; set; }
        public int ElementClickablePointY { get; set; }
        public int ElementProcessId { get; set; }
        public int ElementHandle { get; set; }
        public string ElementValue { get; set; }
        public string ElementTextValue { get; set; }
    }

    public class UIAGetElementPropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnElementHandle { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnElementValue { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ValidateClickablePointWithinElementBoundary { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGetMultipleElementPropertiesResponse
    {
        public int NumberOfElementsFound { get; set; }
        public int NumberOfElementsReturned { get; set; }
        public JToken[] ElementProperties { get; set; }
    }

    public class UIAGetMultipleElementPropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchDescendants { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnElementHandle { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnElementValue { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstItemToReturn { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxItemsToReturn { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGetDesktopElementsResponse
    {
        public int NumberOfElementsFound { get; set; }
        public int NumberOfElementsReturned { get; set; }
        public JToken[] ElementProperties { get; set; }
    }

    public class UIAGetDesktopElementsInput
    {
        public string SearchElementLocalizedControlType { get; set; }

        [JsonProperty("SearchProcessID", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchProcessId { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnElementHandle { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstItemToReturn { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxItemsToReturn { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeChildProcesses { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAExpandElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIACollapseElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIATakeScreenShotOfElementLocationResponse
    {
        public string ScreenBitmapBase64 { get; set; }
    }

    public class UIATakeScreenShotOfElementLocationInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;
        public UIATakeScreenShotOfElementLocationInputImageFormatType? ImageFormat { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? HideAgent { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIATakeScreenShotOfElementLocationInputImageFormatType
    {
        PNG,
        JPG,
        BMP,
        GIF
    }

    public class UIADrawRectangleAroundElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PenColour { get; set; } = "#800080";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? PenThicknessPixels { get; set; } = 4;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGetParentElementHandleResponse
    {
        public int ParentElementHandle { get; set; }
    }

    public class UIAGetParentElementHandleInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ElementHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGetDataGridElementContentsResponse
    {
        public string DataGridContentsJSON { get; set; }
        public int NumberOfRowsInTable { get; set; }
        public int NumberOfColumnsInTable { get; set; }
        public int ThreadId { get; set; }
    }

    public class UIAGetDataGridElementContentsInput
    {
        public int? ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnScreenColumnsOnly { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnScreenRowsOnly { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnNullValuesAsBlank { get; set; } = true;
        public string AlternativeHeaderRowName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnRowUIAName { get; set; } = false;
        public string NameOfColumnToStoreRowUIAName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstItemToReturn { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxItemsToReturn { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ScanFirstNRowsForEmptyRows { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReadTableAsThread { get; set; } = false;
        public int? RetrieveOutputDataFromThreadId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWaitForThread { get; set; } = 90;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ScrollDataGridVerticallyEveryNPercent { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ScrollDataGridVerticallyEveryNRows { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ScrollDataGridVerticallyElementHandle { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MinimumDataGridRowsForScrolling { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfCannotScroll { get; set; } = false;
        public string AlternativeVerticalScrollbarName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGetDataGridElementPropertiesResponse
    {
        public int NumberOfColumns { get; set; }
        public int NumberOfVisibleColumns { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfVisibleRows { get; set; }
        public int FirstVisibleRow { get; set; }
        public int LastVisibleRow { get; set; }
        public int NumberOfScrollbars { get; set; }
        public string ScrollbarNames { get; set; }
    }

    public class UIAGetDataGridElementPropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;
        public string AlternativeHeaderRowName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGetListElementItemsResponse
    {
        public int NumberOfListItems { get; set; }
        public string ListItemsJSON { get; set; }
        public int NumberOfSelectedItems { get; set; }
        public int IndexOfFirstSelectedItem { get; set; }
        public string SelectedItemName { get; set; }
    }

    public class UIAGetListElementItemsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExpandFirst { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CollapseAfter { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckForSelectedItems { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SecondsBetweenExpandCollapse { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAClickListElementItemByNameInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExpandFirst { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CollapseAfter { get; set; } = false;
        public string ItemName { get; set; }
        public double? SecondsBetweenExpandCollapse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAClickListElementItemByIndexInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExpandFirst { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CollapseAfter { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ItemIndex { get; set; } = 1;
        public double? SecondsBetweenExpandCollapse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIASetElementToNumericValueInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int NewValue { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfInputValidationFails { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TryValuePattern { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TryLegacyPattern { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIASetElementToNumericRangeValueInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double NewValue { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NewValueIsPercentage { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAResetAllElementHandlesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGlobalPasswordInputIntoElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FocusElement { get; set; } = true;

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
        public int? Interval { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DontInterpretSymbols { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PasswordContainsStoredPassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ValidateClickablePointWithinElementBoundary { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGlobalTextInputIntoElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FocusElement { get; set; } = true;

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
        public int? Interval { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DontInterpretSymbols { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ValidateClickablePointWithinElementBoundary { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGetElementPropertiesAsListResponse
    {
        public int NumberOfElementsFound { get; set; }
        public int NumberOfElementsReturned { get; set; }
        public string UIAElementPropertiesJSON { get; set; }
    }

    public class UIAGetElementPropertiesAsListInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ElementHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIASetTransactionTimeoutInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double TimeoutInSeconds { get; set; } = 5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGetElementAtCoordinatesResponse
    {
        public bool ElementFound { get; set; }
        public int ElementHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAGetElementAtCoordinatesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? XCoord { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? YCoord { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfElementNotFound { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGetMultipleParentElementPropertiesResponse
    {
        public JToken[] UIAParentElements { get; set; }
        public int NumberOfParentElementsReturned { get; set; }
    }

    public class UIAGetMultipleParentElementPropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ElementHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxParentsToProcess { get; set; } = 50;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIASearchForFirstParentElementResponse
    {
        public bool ParentElementFound { get; set; }
        public int ParentElementHandle { get; set; }
        public string ParentElementName { get; set; }
        public string ParentElementClassName { get; set; }
        public string ParentElementAutomationId { get; set; }
        public string ParentElementLocalizedControlType { get; set; }
    }

    public class UIASearchForFirstParentElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ElementHandle { get; set; }
        public string SearchParentLocalizedControlType { get; set; }
        public int? SearchParentControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxParentsToProcess { get; set; } = 50;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfParentElementNotFound { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGetMultipleElementsAsTableResponse
    {
        public int NumberOfCellSubElementsFound { get; set; }
        public int NumberOfCellSubElementsReturned { get; set; }
        public string TableContentsJSON { get; set; }
        public int NumberOfRowsInTable { get; set; }
        public int NumberOfColumnsInTable { get; set; }
        public int ThreadId { get; set; }
    }

    public class UIAGetMultipleElementsAsTableInput
    {
        public int? ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;
        public string SearchCellHeaderSubElementLocalizedControlType { get; set; }
        public int? SearchCellHeaderSubElementControlType { get; set; }
        public string SearchCellSubElementLocalizedControlType { get; set; }
        public int? SearchCellSubElementControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchDescendantsForCellSubElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstCellHeaderSubElementToReturn { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxCellHeaderSubElementsToReturn { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstCellSubElementToReturn { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxCellSubElementsToReturn { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? RequestedNumberOfColumns { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? CellSubElementValuePriority { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? CellSubElementTextValuePriority { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? CellSubElementNameValuePriority { get; set; } = 3;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MinimumCellSubElementWidth { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MinimumCellSubElementHeight { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchCellSubElementBoundingBoxLeft { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchCellSubElementBoundingBoxRight { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchCellSubElementBoundingBoxTop { get; set; } = -99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchCellSubElementBoundingBoxBottom { get; set; } = 99999;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReadTableAsThread { get; set; } = false;
        public int? RetrieveOutputDataFromThreadId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWaitForThread { get; set; } = 90;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIASetElementScrollPercentageResponse
    {
        public bool UIASetElementScrollPercentageResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class UIASetElementScrollPercentageInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? HorizontalScrollPercentage { get; set; } = -1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? VerticalScrollPercentage { get; set; } = -1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TryScrollPattern { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TryRangeValuePattern { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TryValuePattern { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGetElementSearchColourRegionResponse
    {
        public int NumberOfPixelsMatchingColour { get; set; }
        public int ColourMatchBoundingBoxElementLeftPixelXCoord { get; set; }
        public int ColourMatchBoundingBoxElementRightPixelXCoord { get; set; }
        public int ColourMatchBoundingBoxElementTopPixelYCoord { get; set; }
        public int ColourMatchBoundingBoxElementBottomPixelYCoord { get; set; }
        public int ColourMatchBoundingBoxElementCenterPixelXCoord { get; set; }
        public int ColourMatchBoundingBoxElementCenterPixelYCoord { get; set; }
        public int ColourMatchBoundingBoxScreenLeftPixelXCoord { get; set; }
        public int ColourMatchBoundingBoxScreenRightPixelXCoord { get; set; }
        public int ColourMatchBoundingBoxScreenTopPixelYCoord { get; set; }
        public int ColourMatchBoundingBoxScreenBottomPixelYCoord { get; set; }
        public int ColourMatchBoundingBoxScreenCenterPixelXCoord { get; set; }
        public int ColourMatchBoundingBoxScreenCenterPixelYCoord { get; set; }
    }

    public class UIAGetElementSearchColourRegionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchColour { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int MaxColourDeviation { get; set; }
        public int? LeftPixelXOffset { get; set; }
        public int? RightPixelXOffset { get; set; }
        public int? TopPixelYOffset { get; set; }
        public int? BottomPixelYOffset { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? HideAgent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnPhysicalCoordinates { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGlobalMouseClickElementSearchColourRegionResponse
    {
        public bool UIAGlobalMouseClickElementSearchColourRegionResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class UIAGlobalMouseClickElementSearchColourRegionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchColour { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int MaxColourDeviation { get; set; }
        public int? LeftPixelXOffset { get; set; }
        public int? RightPixelXOffset { get; set; }
        public int? TopPixelYOffset { get; set; }
        public int? BottomPixelYOffset { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UIAGlobalMouseClickElementSearchColourRegionInputMouseButtonType? MouseButton { get; set; } = UIAGlobalMouseClickElementSearchColourRegionInputMouseButtonType.Left;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetX { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetY { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UIAGlobalMouseClickElementSearchColourRegionInputOffsetRelativeToType? OffsetRelativeTo { get; set; } = UIAGlobalMouseClickElementSearchColourRegionInputOffsetRelativeToType.Center;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DelayInMilliseconds { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? HideAgent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIAGlobalMouseClickElementSearchColourRegionInputMouseButtonType
    {
        Left,
        Right,
        Middle,
        [EnumMember(Value = "Double left")]
        DoubleLeft
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIAGlobalMouseClickElementSearchColourRegionInputOffsetRelativeToType
    {
        Center,
        Centre,
        Middle,
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

    public class UIAGetWin32WindowsResponse
    {
        public string Win32WindowsJSON { get; set; }
        public int NumberOfWin32Windows { get; set; }
    }

    public class UIAGetWin32WindowsInput
    {
        public string SearchClassName { get; set; }
        public string SearchWindowTitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TopLevelWindowsOnly { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? VisibleWindowsOnly { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? WindowsWithTitlebarOnly { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? WindowsWithTitleOnly { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IgnoreTransparentWindows { get; set; } = true;
        public int? SearchProcessId { get; set; }
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnElementHandle { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstItemToReturn { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxItemsToReturn { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SetUIAElementSearchModeResponse
    {
        public bool SetUIAElementSearchModeResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class SetUIAElementSearchModeInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetUIAElementSearchModeInputUIAElementSearchModeType UIAElementSearchMode { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetUIAElementSearchModeInputUIAElementSearchModeType
    {
        FindAll,
        TreeWalkRaw
    }

    public class GetUIAElementSearchModeResponse
    {
        public string UIAElementSearchMode { get; set; }
    }

    public class GetUIAElementSearchModeInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAGetElementPatternsResponse
    {
        public bool ExpandCollapsePatternAvailable { get; set; }
        public bool InvokePatternAvailable { get; set; }
        public bool RangeValuePatternAvailable { get; set; }
        public bool ScrollPatternAvailable { get; set; }
        public bool SelectionItemPatternAvailable { get; set; }
        public bool TextPatternAvailable { get; set; }
        public bool TogglePatternAvailable { get; set; }
        public bool ValuePatternAvailable { get; set; }
        public bool WindowPatternAvailable { get; set; }
        public bool GridPatternAvailable { get; set; }
        public bool GridItemPatternAvailable { get; set; }
        public bool LegacyIAccessiblePatternAvailable { get; set; }
        public bool SelectionPatternAvailable { get; set; }
        public bool SpreadsheetPatternAvailable { get; set; }
        public bool SpreadsheetItemPatternAvailable { get; set; }
        public bool TablePatternAvailable { get; set; }
        public bool TableItemPatternAvailable { get; set; }
        public bool TextPattern2Available { get; set; }
        public bool TextEditPatternAvailable { get; set; }
        public bool TransformPatternAvailable { get; set; }
    }

    public class UIAGetElementPatternsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UIAMoveElementResponse
    {
        public bool UIAMoveElementResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class UIAMoveElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UIAMoveElementInputHorizontalMovementTypeType? HorizontalMovementType { get; set; } = UIAMoveElementInputHorizontalMovementTypeType.Absolute;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int HorizontalPosition { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UIAMoveElementInputVerticalMovementTypeType? VerticalMovementType { get; set; } = UIAMoveElementInputVerticalMovementTypeType.Absolute;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int VerticalPosition { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIAMoveElementInputHorizontalMovementTypeType
    {
        Absolute,
        Relative
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIAMoveElementInputVerticalMovementTypeType
    {
        Absolute,
        Relative
    }

    public class UIAResizeElementResponse
    {
        public bool UIAResizeElementResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class UIAResizeElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UIAResizeElementInputResizeWidthTypeType? ResizeWidthType { get; set; } = UIAResizeElementInputResizeWidthTypeType.Relative;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int NewWidth { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UIAResizeElementInputResizeHeightTypeType? ResizeHeightType { get; set; } = UIAResizeElementInputResizeHeightTypeType.Relative;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int NewHeight { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIAResizeElementInputResizeWidthTypeType
    {
        Absolute,
        Relative
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIAResizeElementInputResizeHeightTypeType
    {
        Absolute,
        Relative
    }

    public class UIALocateVisibleSearchImageWithinElementResponse
    {
        public bool SearchImageLocated { get; set; }
        public int WhichSearchImageLocated { get; set; }
        public int SearchImageBoundingBoxElementLeftPixelXCoord { get; set; }
        public int SearchImageBoundingBoxElementRightPixelXCoord { get; set; }
        public int SearchImageBoundingBoxElementTopPixelYCoord { get; set; }
        public int SearchImageBoundingBoxElementBottomPixelYCoord { get; set; }
        public int SearchImageBoundingBoxElementCenterPixelXCoord { get; set; }
        public int SearchImageBoundingBoxElementCenterPixelYCoord { get; set; }
        public int SearchImageBoundingBoxScreenLeftPixelXCoord { get; set; }
        public int SearchImageBoundingBoxScreenRightPixelXCoord { get; set; }
        public int SearchImageBoundingBoxScreenTopPixelYCoord { get; set; }
        public int SearchImageBoundingBoxScreenBottomPixelYCoord { get; set; }
        public int SearchImageBoundingBoxScreenCenterPixelXCoord { get; set; }
        public int SearchImageBoundingBoxScreenCenterPixelYCoord { get; set; }
    }

    public class UIALocateVisibleSearchImageWithinElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }
        public UIALocateVisibleSearchImageWithinElementInputSearchImageTypeType? SearchImageType { get; set; }
        public string SearchImage { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UIALocateVisibleSearchImageWithinElementInputAltSearchImageTypeType? AltSearchImageType { get; set; } = UIALocateVisibleSearchImageWithinElementInputAltSearchImageTypeType.None;
        public string AltSearchImage { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxColourDeviation { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxPixelDifferences { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxConsecutivePixelDifferences { get; set; } = 0;
        public int? LeftPixelXOffset { get; set; }
        public int? RightPixelXOffset { get; set; }
        public int? TopPixelYOffset { get; set; }
        public int? BottomPixelYOffset { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UIALocateVisibleSearchImageWithinElementInputPixelXOffsetsUnitType? PixelXOffsetsUnit { get; set; } = UIALocateVisibleSearchImageWithinElementInputPixelXOffsetsUnitType.Pixel;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UIALocateVisibleSearchImageWithinElementInputPixelYOffsetsUnitType? PixelYOffsetsUnit { get; set; } = UIALocateVisibleSearchImageWithinElementInputPixelYOffsetsUnitType.Pixel;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchImageIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UIALocateVisibleSearchImageWithinElementInputImageSearchDirectionType? ImageSearchDirection { get; set; } = UIALocateVisibleSearchImageWithinElementInputImageSearchDirectionType.FromTop;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? HideAgent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnPhysicalCoordinates { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowHighlightRectangle { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIALocateVisibleSearchImageWithinElementInputSearchImageTypeType
    {
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIALocateVisibleSearchImageWithinElementInputAltSearchImageTypeType
    {
        None,
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIALocateVisibleSearchImageWithinElementInputPixelXOffsetsUnitType
    {
        Pixel,
        Percent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIALocateVisibleSearchImageWithinElementInputPixelYOffsetsUnitType
    {
        Pixel,
        Percent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIALocateVisibleSearchImageWithinElementInputImageSearchDirectionType
    {
        FromTop,
        FromBottom,
        FromLeft,
        FromRight
    }

    public class UIAWaitForVisibleSearchImageWithinElementResponse
    {
        public bool SearchImageLocated { get; set; }
        public int WhichSearchImageLocated { get; set; }
        public int SearchImageBoundingBoxElementLeftPixelXCoord { get; set; }
        public int SearchImageBoundingBoxElementRightPixelXCoord { get; set; }
        public int SearchImageBoundingBoxElementTopPixelYCoord { get; set; }
        public int SearchImageBoundingBoxElementBottomPixelYCoord { get; set; }
        public int SearchImageBoundingBoxElementCenterPixelXCoord { get; set; }
        public int SearchImageBoundingBoxElementCenterPixelYCoord { get; set; }
        public int SearchImageBoundingBoxScreenLeftPixelXCoord { get; set; }
        public int SearchImageBoundingBoxScreenRightPixelXCoord { get; set; }
        public int SearchImageBoundingBoxScreenTopPixelYCoord { get; set; }
        public int SearchImageBoundingBoxScreenBottomPixelYCoord { get; set; }
        public int SearchImageBoundingBoxScreenCenterPixelXCoord { get; set; }
        public int SearchImageBoundingBoxScreenCenterPixelYCoord { get; set; }
        public int ThreadId { get; set; }
    }

    public class UIAWaitForVisibleSearchImageWithinElementInput
    {
        public int? ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }
        public UIAWaitForVisibleSearchImageWithinElementInputSearchImageTypeType? SearchImageType { get; set; }
        public string SearchImage { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UIAWaitForVisibleSearchImageWithinElementInputAltSearchImageTypeType? AltSearchImageType { get; set; } = UIAWaitForVisibleSearchImageWithinElementInputAltSearchImageTypeType.None;
        public string AltSearchImage { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxColourDeviation { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxPixelDifferences { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxConsecutivePixelDifferences { get; set; } = 0;
        public int? LeftPixelXOffset { get; set; }
        public int? RightPixelXOffset { get; set; }
        public int? TopPixelYOffset { get; set; }
        public int? BottomPixelYOffset { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UIAWaitForVisibleSearchImageWithinElementInputPixelXOffsetsUnitType? PixelXOffsetsUnit { get; set; } = UIAWaitForVisibleSearchImageWithinElementInputPixelXOffsetsUnitType.Pixel;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UIAWaitForVisibleSearchImageWithinElementInputPixelYOffsetsUnitType? PixelYOffsetsUnit { get; set; } = UIAWaitForVisibleSearchImageWithinElementInputPixelYOffsetsUnitType.Pixel;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchImageIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UIAWaitForVisibleSearchImageWithinElementInputImageSearchDirectionType? ImageSearchDirection { get; set; } = UIAWaitForVisibleSearchImageWithinElementInputImageSearchDirectionType.FromTop;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? HideAgent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnPhysicalCoordinates { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowHighlightRectangle { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWait { get; set; } = 60;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MillisecondsBetweenSearches { get; set; } = 5000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfImageNotFound { get; set; } = true;
        public int? RetrieveOutputDataFromThreadId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? WaitForThread { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIAWaitForVisibleSearchImageWithinElementInputSearchImageTypeType
    {
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIAWaitForVisibleSearchImageWithinElementInputAltSearchImageTypeType
    {
        None,
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIAWaitForVisibleSearchImageWithinElementInputPixelXOffsetsUnitType
    {
        Pixel,
        Percent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIAWaitForVisibleSearchImageWithinElementInputPixelYOffsetsUnitType
    {
        Pixel,
        Percent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIAWaitForVisibleSearchImageWithinElementInputImageSearchDirectionType
    {
        FromTop,
        FromBottom,
        FromLeft,
        FromRight
    }

    public class UIAWaitForVisibleSearchImageToNotExistWithinElementResponse
    {
        public bool SearchImagePresentBeforeWait { get; set; }
        public bool SearchImageStillPresentAfterWait { get; set; }
        public int WhichSearchImageStillPresent { get; set; }
        public int ThreadId { get; set; }
    }

    public class UIAWaitForVisibleSearchImageToNotExistWithinElementInput
    {
        public int? ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxElementsToSearch { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeSearchDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxChildElementsToSearchPerNode { get; set; } = 0;
        public string ElementLocalizedControlTypesNotToTraverse { get; set; }
        public UIAWaitForVisibleSearchImageToNotExistWithinElementInputSearchImageTypeType? SearchImageType { get; set; }
        public string SearchImage { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UIAWaitForVisibleSearchImageToNotExistWithinElementInputAltSearchImageTypeType? AltSearchImageType { get; set; } = UIAWaitForVisibleSearchImageToNotExistWithinElementInputAltSearchImageTypeType.None;
        public string AltSearchImage { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxColourDeviation { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxPixelDifferences { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxConsecutivePixelDifferences { get; set; } = 0;
        public int? LeftPixelXOffset { get; set; }
        public int? RightPixelXOffset { get; set; }
        public int? TopPixelYOffset { get; set; }
        public int? BottomPixelYOffset { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UIAWaitForVisibleSearchImageToNotExistWithinElementInputPixelXOffsetsUnitType? PixelXOffsetsUnit { get; set; } = UIAWaitForVisibleSearchImageToNotExistWithinElementInputPixelXOffsetsUnitType.Pixel;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UIAWaitForVisibleSearchImageToNotExistWithinElementInputPixelYOffsetsUnitType? PixelYOffsetsUnit { get; set; } = UIAWaitForVisibleSearchImageToNotExistWithinElementInputPixelYOffsetsUnitType.Pixel;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchImageIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UIAWaitForVisibleSearchImageToNotExistWithinElementInputImageSearchDirectionType? ImageSearchDirection { get; set; } = UIAWaitForVisibleSearchImageToNotExistWithinElementInputImageSearchDirectionType.FromTop;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? HideAgent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowHighlightRectangle { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWait { get; set; } = 60;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MillisecondsBetweenSearches { get; set; } = 5000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfImageStillPresent { get; set; } = true;
        public int? RetrieveOutputDataFromThreadId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? WaitForThread { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIAWaitForVisibleSearchImageToNotExistWithinElementInputSearchImageTypeType
    {
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIAWaitForVisibleSearchImageToNotExistWithinElementInputAltSearchImageTypeType
    {
        None,
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIAWaitForVisibleSearchImageToNotExistWithinElementInputPixelXOffsetsUnitType
    {
        Pixel,
        Percent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIAWaitForVisibleSearchImageToNotExistWithinElementInputPixelYOffsetsUnitType
    {
        Pixel,
        Percent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UIAWaitForVisibleSearchImageToNotExistWithinElementInputImageSearchDirectionType
    {
        FromTop,
        FromBottom,
        FromLeft,
        FromRight
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui;

    public partial class WorkflowManagedActions
    {
        public IaconnectuiActions Iaconnectui(string connectionId) => new IaconnectuiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IaconnectuiTriggers Iaconnectui(string connectionId) => new IaconnectuiTriggers(connectionId);
    }
}