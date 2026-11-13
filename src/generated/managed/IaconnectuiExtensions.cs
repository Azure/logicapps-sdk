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
        public IBodyWorkflowAction<UiaDoesTopLevelWindowExistResponse, ApiConnectionActionConfiguration> UiaDoesTopLevelWindowExist(Expression<Func<UiaDoesTopLevelWindowExistInput>> uiaDoesTopLevelWindowExist)
        {
            var __workflow_uiaDoesTopLevelWindowExist = WorkflowExpression.Compile(uiaDoesTopLevelWindowExist, nameof(uiaDoesTopLevelWindowExist), required: true);
            return new DeferredBodyAction<UiaDoesTopLevelWindowExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/DoesTopLevelWindowExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaDoesTopLevelWindowExist);
                return new ApiConnectionAction<UiaDoesTopLevelWindowExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetHandleForTopLevelWindowResponse, ApiConnectionActionConfiguration> UiaGetHandleForTopLevelWindow(Expression<Func<UiaGetHandleForTopLevelWindowInput>> uiaGetHandleForTopLevelWindow)
        {
            var __workflow_uiaGetHandleForTopLevelWindow = WorkflowExpression.Compile(uiaGetHandleForTopLevelWindow, nameof(uiaGetHandleForTopLevelWindow), required: true);
            return new DeferredBodyAction<UiaGetHandleForTopLevelWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetHandleForTopLevelWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetHandleForTopLevelWindow);
                return new ApiConnectionAction<UiaGetHandleForTopLevelWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaWaitForTopLevelWindowResponse, ApiConnectionActionConfiguration> UiaWaitForTopLevelWindow(Expression<Func<UiaWaitForTopLevelWindowInput>> uiaWaitForTopLevelWindow)
        {
            var __workflow_uiaWaitForTopLevelWindow = WorkflowExpression.Compile(uiaWaitForTopLevelWindow, nameof(uiaWaitForTopLevelWindow), required: true);
            return new DeferredBodyAction<UiaWaitForTopLevelWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/WaitForTopLevelWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaWaitForTopLevelWindow);
                return new ApiConnectionAction<UiaWaitForTopLevelWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaDoesProcessHaveWindowResponse, ApiConnectionActionConfiguration> UiaDoesProcessHaveWindow(Expression<Func<UiaDoesProcessHaveWindowInput>> uiaDoesProcessHaveWindow)
        {
            var __workflow_uiaDoesProcessHaveWindow = WorkflowExpression.Compile(uiaDoesProcessHaveWindow, nameof(uiaDoesProcessHaveWindow), required: true);
            return new DeferredBodyAction<UiaDoesProcessHaveWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/DoesProcessHaveWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaDoesProcessHaveWindow);
                return new ApiConnectionAction<UiaDoesProcessHaveWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetHandleForProcessMainWindowResponse, ApiConnectionActionConfiguration> UiaGetHandleForProcessMainWindow(Expression<Func<UiaGetHandleForProcessMainWindowInput>> uiaGetHandleForProcessMainWindow)
        {
            var __workflow_uiaGetHandleForProcessMainWindow = WorkflowExpression.Compile(uiaGetHandleForProcessMainWindow, nameof(uiaGetHandleForProcessMainWindow), required: true);
            return new DeferredBodyAction<UiaGetHandleForProcessMainWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetHandleForProcessMainWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetHandleForProcessMainWindow);
                return new ApiConnectionAction<UiaGetHandleForProcessMainWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaWaitForProcessMainWindowResponse, ApiConnectionActionConfiguration> UiaWaitForProcessMainWindow(Expression<Func<UiaWaitForProcessMainWindowInput>> uiaWaitForProcessMainWindow)
        {
            var __workflow_uiaWaitForProcessMainWindow = WorkflowExpression.Compile(uiaWaitForProcessMainWindow, nameof(uiaWaitForProcessMainWindow), required: true);
            return new DeferredBodyAction<UiaWaitForProcessMainWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/WaitForProcessMainWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaWaitForProcessMainWindow);
                return new ApiConnectionAction<UiaWaitForProcessMainWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetHandleForProcessIdMainWindowResponse, ApiConnectionActionConfiguration> UiaGetHandleForProcessIdMainWindow(Expression<Func<UiaGetHandleForProcessIdMainWindowInput>> uiaGetHandleForProcessIdMainWindow)
        {
            var __workflow_uiaGetHandleForProcessIdMainWindow = WorkflowExpression.Compile(uiaGetHandleForProcessIdMainWindow, nameof(uiaGetHandleForProcessIdMainWindow), required: true);
            return new DeferredBodyAction<UiaGetHandleForProcessIdMainWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetHandleForProcessIdMainWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetHandleForProcessIdMainWindow);
                return new ApiConnectionAction<UiaGetHandleForProcessIdMainWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaWaitForProcessIdMainWindowResponse, ApiConnectionActionConfiguration> UiaWaitForProcessIdMainWindow(Expression<Func<UiaWaitForProcessIdMainWindowInput>> uiaWaitForProcessIdMainWindow)
        {
            var __workflow_uiaWaitForProcessIdMainWindow = WorkflowExpression.Compile(uiaWaitForProcessIdMainWindow, nameof(uiaWaitForProcessIdMainWindow), required: true);
            return new DeferredBodyAction<UiaWaitForProcessIdMainWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/WaitForProcessIdMainWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaWaitForProcessIdMainWindow);
                return new ApiConnectionAction<UiaWaitForProcessIdMainWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetHandleForFocussedElementResponse, ApiConnectionActionConfiguration> UiaGetHandleForFocussedElement(Expression<Func<UiaGetHandleForFocussedElementInput>> uiaGetHandleForFocussedElement)
        {
            var __workflow_uiaGetHandleForFocussedElement = WorkflowExpression.Compile(uiaGetHandleForFocussedElement, nameof(uiaGetHandleForFocussedElement), required: true);
            return new DeferredBodyAction<UiaGetHandleForFocussedElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetHandleForFocussedElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetHandleForFocussedElement);
                return new ApiConnectionAction<UiaGetHandleForFocussedElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetHandleForMainWindowOfFocussedElementResponse, ApiConnectionActionConfiguration> UiaGetHandleForMainWindowOfFocussedElement(Expression<Func<UiaGetHandleForMainWindowOfFocussedElementInput>> uiaGetHandleForMainWindowOfFocussedElement)
        {
            var __workflow_uiaGetHandleForMainWindowOfFocussedElement = WorkflowExpression.Compile(uiaGetHandleForMainWindowOfFocussedElement, nameof(uiaGetHandleForMainWindowOfFocussedElement), required: true);
            return new DeferredBodyAction<UiaGetHandleForMainWindowOfFocussedElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetHandleForMainWindowOfFocussedElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetHandleForMainWindowOfFocussedElement);
                return new ApiConnectionAction<UiaGetHandleForMainWindowOfFocussedElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetHandleForDesktopResponse, ApiConnectionActionConfiguration> UiaGetHandleForDesktop(Expression<Func<UiaGetHandleForDesktopInput>> uiaGetHandleForDesktop)
        {
            var __workflow_uiaGetHandleForDesktop = WorkflowExpression.Compile(uiaGetHandleForDesktop, nameof(uiaGetHandleForDesktop), required: true);
            return new DeferredBodyAction<UiaGetHandleForDesktopResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetHandleForDesktop";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetHandleForDesktop);
                return new ApiConnectionAction<UiaGetHandleForDesktopResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaSetForegroundWindow(Expression<Func<UiaSetForegroundWindowInput>> uiaSetForegroundWindow)
        {
            var __workflow_uiaSetForegroundWindow = WorkflowExpression.Compile(uiaSetForegroundWindow, nameof(uiaSetForegroundWindow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/SetForegroundWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaSetForegroundWindow);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaMaximiseWindow(Expression<Func<UiaMaximiseWindowInput>> uiaMaximiseWindow)
        {
            var __workflow_uiaMaximiseWindow = WorkflowExpression.Compile(uiaMaximiseWindow, nameof(uiaMaximiseWindow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/MaximiseWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaMaximiseWindow);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaMinimiseWindow(Expression<Func<UiaMinimiseWindowInput>> uiaMinimiseWindow)
        {
            var __workflow_uiaMinimiseWindow = WorkflowExpression.Compile(uiaMinimiseWindow, nameof(uiaMinimiseWindow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/MinimiseWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaMinimiseWindow);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaSetWindowToNormal(Expression<Func<UiaSetWindowToNormalInput>> uiaSetWindowToNormal)
        {
            var __workflow_uiaSetWindowToNormal = WorkflowExpression.Compile(uiaSetWindowToNormal, nameof(uiaSetWindowToNormal), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/SetWindowToNormal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaSetWindowToNormal);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaDoesElementExistResponse, ApiConnectionActionConfiguration> UiaDoesElementExist(Expression<Func<UiaDoesElementExistInput>> uiaDoesElementExist)
        {
            var __workflow_uiaDoesElementExist = WorkflowExpression.Compile(uiaDoesElementExist, nameof(uiaDoesElementExist), required: true);
            return new DeferredBodyAction<UiaDoesElementExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/DoesElementExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaDoesElementExist);
                return new ApiConnectionAction<UiaDoesElementExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaDoesDesktopElementExistResponse, ApiConnectionActionConfiguration> UiaDoesDesktopElementExist(Expression<Func<UiaDoesDesktopElementExistInput>> uiaDoesDesktopElementExist)
        {
            var __workflow_uiaDoesDesktopElementExist = WorkflowExpression.Compile(uiaDoesDesktopElementExist, nameof(uiaDoesDesktopElementExist), required: true);
            return new DeferredBodyAction<UiaDoesDesktopElementExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/DoesDesktopElementExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaDoesDesktopElementExist);
                return new ApiConnectionAction<UiaDoesDesktopElementExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaWaitForElementResponse, ApiConnectionActionConfiguration> UiaWaitForElement(Expression<Func<UiaWaitForElementInput>> uiaWaitForElement)
        {
            var __workflow_uiaWaitForElement = WorkflowExpression.Compile(uiaWaitForElement, nameof(uiaWaitForElement), required: true);
            return new DeferredBodyAction<UiaWaitForElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/WaitForElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaWaitForElement);
                return new ApiConnectionAction<UiaWaitForElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaWaitForDesktopElementResponse, ApiConnectionActionConfiguration> UiaWaitForDesktopElement(Expression<Func<UiaWaitForDesktopElementInput>> uiaWaitForDesktopElement)
        {
            var __workflow_uiaWaitForDesktopElement = WorkflowExpression.Compile(uiaWaitForDesktopElement, nameof(uiaWaitForDesktopElement), required: true);
            return new DeferredBodyAction<UiaWaitForDesktopElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/WaitForDesktopElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaWaitForDesktopElement);
                return new ApiConnectionAction<UiaWaitForDesktopElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaWaitForElementToNotExistResponse, ApiConnectionActionConfiguration> UiaWaitForElementToNotExist(Expression<Func<UiaWaitForElementToNotExistInput>> uiaWaitForElementToNotExist)
        {
            var __workflow_uiaWaitForElementToNotExist = WorkflowExpression.Compile(uiaWaitForElementToNotExist, nameof(uiaWaitForElementToNotExist), required: true);
            return new DeferredBodyAction<UiaWaitForElementToNotExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAWaitForElementToNotExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaWaitForElementToNotExist);
                return new ApiConnectionAction<UiaWaitForElementToNotExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaWaitForDesktopElementToNotExistResponse, ApiConnectionActionConfiguration> UiaWaitForDesktopElementToNotExist(Expression<Func<UiaWaitForDesktopElementToNotExistInput>> uiaWaitForDesktopElementToNotExist)
        {
            var __workflow_uiaWaitForDesktopElementToNotExist = WorkflowExpression.Compile(uiaWaitForDesktopElementToNotExist, nameof(uiaWaitForDesktopElementToNotExist), required: true);
            return new DeferredBodyAction<UiaWaitForDesktopElementToNotExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAWaitForDesktopElementToNotExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaWaitForDesktopElementToNotExist);
                return new ApiConnectionAction<UiaWaitForDesktopElementToNotExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaPressElement(Expression<Func<UiaPressElementInput>> uiaPressElement)
        {
            var __workflow_uiaPressElement = WorkflowExpression.Compile(uiaPressElement, nameof(uiaPressElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/PressElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaPressElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaGlobalMouseClickOnElement(Expression<Func<UiaGlobalMouseClickOnElementInput>> uiaGlobalMouseClickOnElement)
        {
            var __workflow_uiaGlobalMouseClickOnElement = WorkflowExpression.Compile(uiaGlobalMouseClickOnElement, nameof(uiaGlobalMouseClickOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GlobalMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGlobalMouseClickOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaGlobalRightMouseClickOnElement(Expression<Func<UiaGlobalRightMouseClickOnElementInput>> uiaGlobalRightMouseClickOnElement)
        {
            var __workflow_uiaGlobalRightMouseClickOnElement = WorkflowExpression.Compile(uiaGlobalRightMouseClickOnElement, nameof(uiaGlobalRightMouseClickOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GlobalRightMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGlobalRightMouseClickOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaGlobalMiddleMouseClickOnElement(Expression<Func<UiaGlobalMiddleMouseClickOnElementInput>> uiaGlobalMiddleMouseClickOnElement)
        {
            var __workflow_uiaGlobalMiddleMouseClickOnElement = WorkflowExpression.Compile(uiaGlobalMiddleMouseClickOnElement, nameof(uiaGlobalMiddleMouseClickOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GlobalMiddleMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGlobalMiddleMouseClickOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaGlobalDoubleLeftMouseClickOnElement(Expression<Func<UiaGlobalDoubleLeftMouseClickOnElementInput>> uiaGlobalDoubleLeftMouseClickOnElement)
        {
            var __workflow_uiaGlobalDoubleLeftMouseClickOnElement = WorkflowExpression.Compile(uiaGlobalDoubleLeftMouseClickOnElement, nameof(uiaGlobalDoubleLeftMouseClickOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GlobalDoubleLeftMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGlobalDoubleLeftMouseClickOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaSelectElement(Expression<Func<UiaSelectElementInput>> uiaSelectElement)
        {
            var __workflow_uiaSelectElement = WorkflowExpression.Compile(uiaSelectElement, nameof(uiaSelectElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/SelectElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaSelectElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaInputPasswordIntoElement(Expression<Func<UiaInputPasswordIntoElementInput>> uiaInputPasswordIntoElement)
        {
            var __workflow_uiaInputPasswordIntoElement = WorkflowExpression.Compile(uiaInputPasswordIntoElement, nameof(uiaInputPasswordIntoElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/InputPasswordIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaInputPasswordIntoElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaInputTextIntoElement(Expression<Func<UiaInputTextIntoElementInput>> uiaInputTextIntoElement)
        {
            var __workflow_uiaInputTextIntoElement = WorkflowExpression.Compile(uiaInputTextIntoElement, nameof(uiaInputTextIntoElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/InputTextIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaInputTextIntoElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaInputTextIntoMultipleElements(Expression<Func<UiaInputTextIntoMultipleElementsInput>> uiaInputTextIntoMultipleElements)
        {
            var __workflow_uiaInputTextIntoMultipleElements = WorkflowExpression.Compile(uiaInputTextIntoMultipleElements, nameof(uiaInputTextIntoMultipleElements), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAInputTextIntoMultipleElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaInputTextIntoMultipleElements);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaInputReturnIntoElement(Expression<Func<UiaInputReturnIntoElementInput>> uiaInputReturnIntoElement)
        {
            var __workflow_uiaInputReturnIntoElement = WorkflowExpression.Compile(uiaInputReturnIntoElement, nameof(uiaInputReturnIntoElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/InputReturnIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaInputReturnIntoElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaFocusElement(Expression<Func<UiaFocusElementInput>> uiaFocusElement)
        {
            var __workflow_uiaFocusElement = WorkflowExpression.Compile(uiaFocusElement, nameof(uiaFocusElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/FocusElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaFocusElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaToggleElement(Expression<Func<UiaToggleElementInput>> uiaToggleElement)
        {
            var __workflow_uiaToggleElement = WorkflowExpression.Compile(uiaToggleElement, nameof(uiaToggleElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/ToggleElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaToggleElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaCheckElement(Expression<Func<UiaCheckElementInput>> uiaCheckElement)
        {
            var __workflow_uiaCheckElement = WorkflowExpression.Compile(uiaCheckElement, nameof(uiaCheckElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/CheckElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaCheckElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaCheckMultipleElements(Expression<Func<UiaCheckMultipleElementsInput>> uiaCheckMultipleElements)
        {
            var __workflow_uiaCheckMultipleElements = WorkflowExpression.Compile(uiaCheckMultipleElements, nameof(uiaCheckMultipleElements), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIACheckMultipleElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaCheckMultipleElements);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaisElementCheckedResponse, ApiConnectionActionConfiguration> UiaisElementChecked(Expression<Func<UiaisElementCheckedInput>> uiaisElementChecked)
        {
            var __workflow_uiaisElementChecked = WorkflowExpression.Compile(uiaisElementChecked, nameof(uiaisElementChecked), required: true);
            return new DeferredBodyAction<UiaisElementCheckedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAIsElementChecked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaisElementChecked);
                return new ApiConnectionAction<UiaisElementCheckedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaCloseElementWindow(Expression<Func<UiaCloseElementWindowInput>> uiaCloseElementWindow)
        {
            var __workflow_uiaCloseElementWindow = WorkflowExpression.Compile(uiaCloseElementWindow, nameof(uiaCloseElementWindow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/CloseElementWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaCloseElementWindow);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetElementTextValueResponse, ApiConnectionActionConfiguration> UiaGetElementTextValue(Expression<Func<UiaGetElementTextValueInput>> uiaGetElementTextValue)
        {
            var __workflow_uiaGetElementTextValue = WorkflowExpression.Compile(uiaGetElementTextValue, nameof(uiaGetElementTextValue), required: true);
            return new DeferredBodyAction<UiaGetElementTextValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetElementTextValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetElementTextValue);
                return new ApiConnectionAction<UiaGetElementTextValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetElementValueResponse, ApiConnectionActionConfiguration> UiaGetElementValue(Expression<Func<UiaGetElementValueInput>> uiaGetElementValue)
        {
            var __workflow_uiaGetElementValue = WorkflowExpression.Compile(uiaGetElementValue, nameof(uiaGetElementValue), required: true);
            return new DeferredBodyAction<UiaGetElementValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetElementValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetElementValue);
                return new ApiConnectionAction<UiaGetElementValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetElementLabelValueResponse, ApiConnectionActionConfiguration> UiaGetElementLabelValue(Expression<Func<UiaGetElementLabelValueInput>> uiaGetElementLabelValue)
        {
            var __workflow_uiaGetElementLabelValue = WorkflowExpression.Compile(uiaGetElementLabelValue, nameof(uiaGetElementLabelValue), required: true);
            return new DeferredBodyAction<UiaGetElementLabelValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetElementLabelValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetElementLabelValue);
                return new ApiConnectionAction<UiaGetElementLabelValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetElementPropertiesResponse, ApiConnectionActionConfiguration> UiaGetElementProperties(Expression<Func<UiaGetElementPropertiesInput>> uiaGetElementProperties)
        {
            var __workflow_uiaGetElementProperties = WorkflowExpression.Compile(uiaGetElementProperties, nameof(uiaGetElementProperties), required: true);
            return new DeferredBodyAction<UiaGetElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetElementProperties);
                return new ApiConnectionAction<UiaGetElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetMultipleElementPropertiesResponse, ApiConnectionActionConfiguration> UiaGetMultipleElementProperties(Expression<Func<UiaGetMultipleElementPropertiesInput>> uiaGetMultipleElementProperties)
        {
            var __workflow_uiaGetMultipleElementProperties = WorkflowExpression.Compile(uiaGetMultipleElementProperties, nameof(uiaGetMultipleElementProperties), required: true);
            return new DeferredBodyAction<UiaGetMultipleElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetMultipleElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetMultipleElementProperties);
                return new ApiConnectionAction<UiaGetMultipleElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetDesktopElementsResponse, ApiConnectionActionConfiguration> UiaGetDesktopElements(Expression<Func<UiaGetDesktopElementsInput>> uiaGetDesktopElements)
        {
            var __workflow_uiaGetDesktopElements = WorkflowExpression.Compile(uiaGetDesktopElements, nameof(uiaGetDesktopElements), required: true);
            return new DeferredBodyAction<UiaGetDesktopElementsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetDesktopElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetDesktopElements);
                return new ApiConnectionAction<UiaGetDesktopElementsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaExpandElement(Expression<Func<UiaExpandElementInput>> uiaExpandElement)
        {
            var __workflow_uiaExpandElement = WorkflowExpression.Compile(uiaExpandElement, nameof(uiaExpandElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/ExpandElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaExpandElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaCollapseElement(Expression<Func<UiaCollapseElementInput>> uiaCollapseElement)
        {
            var __workflow_uiaCollapseElement = WorkflowExpression.Compile(uiaCollapseElement, nameof(uiaCollapseElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/CollapseElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaCollapseElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaTakeScreenShotOfElementLocationResponse, ApiConnectionActionConfiguration> UiaTakeScreenShotOfElementLocation(Expression<Func<UiaTakeScreenShotOfElementLocationInput>> uiaTakeScreenShotOfElementLocation)
        {
            var __workflow_uiaTakeScreenShotOfElementLocation = WorkflowExpression.Compile(uiaTakeScreenShotOfElementLocation, nameof(uiaTakeScreenShotOfElementLocation), required: true);
            return new DeferredBodyAction<UiaTakeScreenShotOfElementLocationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/TakeScreenShotOfElementLocation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaTakeScreenShotOfElementLocation);
                return new ApiConnectionAction<UiaTakeScreenShotOfElementLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaDrawRectangleAroundElement(Expression<Func<UiaDrawRectangleAroundElementInput>> uiaDrawRectangleAroundElement)
        {
            var __workflow_uiaDrawRectangleAroundElement = WorkflowExpression.Compile(uiaDrawRectangleAroundElement, nameof(uiaDrawRectangleAroundElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/DrawRectangleAroundElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaDrawRectangleAroundElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetParentElementHandleResponse, ApiConnectionActionConfiguration> UiaGetParentElementHandle(Expression<Func<UiaGetParentElementHandleInput>> uiaGetParentElementHandle)
        {
            var __workflow_uiaGetParentElementHandle = WorkflowExpression.Compile(uiaGetParentElementHandle, nameof(uiaGetParentElementHandle), required: true);
            return new DeferredBodyAction<UiaGetParentElementHandleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetParentElementHandle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetParentElementHandle);
                return new ApiConnectionAction<UiaGetParentElementHandleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetDataGridElementContentsResponse, ApiConnectionActionConfiguration> UiaGetDataGridElementContents(Expression<Func<UiaGetDataGridElementContentsInput>> uiaGetDataGridElementContents)
        {
            var __workflow_uiaGetDataGridElementContents = WorkflowExpression.Compile(uiaGetDataGridElementContents, nameof(uiaGetDataGridElementContents), required: true);
            return new DeferredBodyAction<UiaGetDataGridElementContentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetDataGridElementContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetDataGridElementContents);
                return new ApiConnectionAction<UiaGetDataGridElementContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetDataGridElementPropertiesResponse, ApiConnectionActionConfiguration> UiaGetDataGridElementProperties(Expression<Func<UiaGetDataGridElementPropertiesInput>> uiaGetDataGridElementProperties)
        {
            var __workflow_uiaGetDataGridElementProperties = WorkflowExpression.Compile(uiaGetDataGridElementProperties, nameof(uiaGetDataGridElementProperties), required: true);
            return new DeferredBodyAction<UiaGetDataGridElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetDataGridElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetDataGridElementProperties);
                return new ApiConnectionAction<UiaGetDataGridElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetListElementItemsResponse, ApiConnectionActionConfiguration> UiaGetListElementItems(Expression<Func<UiaGetListElementItemsInput>> uiaGetListElementItems)
        {
            var __workflow_uiaGetListElementItems = WorkflowExpression.Compile(uiaGetListElementItems, nameof(uiaGetListElementItems), required: true);
            return new DeferredBodyAction<UiaGetListElementItemsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetListElementItems";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetListElementItems);
                return new ApiConnectionAction<UiaGetListElementItemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaClickListElementItemByName(Expression<Func<UiaClickListElementItemByNameInput>> uiaClickListElementItemByName)
        {
            var __workflow_uiaClickListElementItemByName = WorkflowExpression.Compile(uiaClickListElementItemByName, nameof(uiaClickListElementItemByName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/ClickListElementItemByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaClickListElementItemByName);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaClickListElementItemByIndex(Expression<Func<UiaClickListElementItemByIndexInput>> uiaClickListElementItemByIndex)
        {
            var __workflow_uiaClickListElementItemByIndex = WorkflowExpression.Compile(uiaClickListElementItemByIndex, nameof(uiaClickListElementItemByIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/ClickListElementItemByIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaClickListElementItemByIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaSetElementToNumericValue(Expression<Func<UiaSetElementToNumericValueInput>> uiaSetElementToNumericValue)
        {
            var __workflow_uiaSetElementToNumericValue = WorkflowExpression.Compile(uiaSetElementToNumericValue, nameof(uiaSetElementToNumericValue), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIASetElementToNumericValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaSetElementToNumericValue);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaSetElementToNumericRangeValue(Expression<Func<UiaSetElementToNumericRangeValueInput>> uiaSetElementToNumericRangeValue)
        {
            var __workflow_uiaSetElementToNumericRangeValue = WorkflowExpression.Compile(uiaSetElementToNumericRangeValue, nameof(uiaSetElementToNumericRangeValue), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIASetElementToNumericRangeValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaSetElementToNumericRangeValue);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaResetAllElementHandles(Expression<Func<UiaResetAllElementHandlesInput>> uiaResetAllElementHandles)
        {
            var __workflow_uiaResetAllElementHandles = WorkflowExpression.Compile(uiaResetAllElementHandles, nameof(uiaResetAllElementHandles), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAResetAllElementHandles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaResetAllElementHandles);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaGlobalPasswordInputIntoElement(Expression<Func<UiaGlobalPasswordInputIntoElementInput>> uiaGlobalPasswordInputIntoElement)
        {
            var __workflow_uiaGlobalPasswordInputIntoElement = WorkflowExpression.Compile(uiaGlobalPasswordInputIntoElement, nameof(uiaGlobalPasswordInputIntoElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGlobalPasswordInputIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGlobalPasswordInputIntoElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaGlobalTextInputIntoElement(Expression<Func<UiaGlobalTextInputIntoElementInput>> uiaGlobalTextInputIntoElement)
        {
            var __workflow_uiaGlobalTextInputIntoElement = WorkflowExpression.Compile(uiaGlobalTextInputIntoElement, nameof(uiaGlobalTextInputIntoElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGlobalTextInputIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGlobalTextInputIntoElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetElementPropertiesAsListResponse, ApiConnectionActionConfiguration> UiaGetElementPropertiesAsList(Expression<Func<UiaGetElementPropertiesAsListInput>> uiaGetElementPropertiesAsList)
        {
            var __workflow_uiaGetElementPropertiesAsList = WorkflowExpression.Compile(uiaGetElementPropertiesAsList, nameof(uiaGetElementPropertiesAsList), required: true);
            return new DeferredBodyAction<UiaGetElementPropertiesAsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGetElementPropertiesAsList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetElementPropertiesAsList);
                return new ApiConnectionAction<UiaGetElementPropertiesAsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UiaSetTransactionTimeout(Expression<Func<UiaSetTransactionTimeoutInput>> uiaSetTransactionTimeout)
        {
            var __workflow_uiaSetTransactionTimeout = WorkflowExpression.Compile(uiaSetTransactionTimeout, nameof(uiaSetTransactionTimeout), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIASetTransactionTimeout";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaSetTransactionTimeout);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetElementAtCoordinatesResponse, ApiConnectionActionConfiguration> UiaGetElementAtCoordinates(Expression<Func<UiaGetElementAtCoordinatesInput>> uiaGetElementAtCoordinates)
        {
            var __workflow_uiaGetElementAtCoordinates = WorkflowExpression.Compile(uiaGetElementAtCoordinates, nameof(uiaGetElementAtCoordinates), required: true);
            return new DeferredBodyAction<UiaGetElementAtCoordinatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGetElementAtCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetElementAtCoordinates);
                return new ApiConnectionAction<UiaGetElementAtCoordinatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetMultipleParentElementPropertiesResponse, ApiConnectionActionConfiguration> UiaGetMultipleParentElementProperties(Expression<Func<UiaGetMultipleParentElementPropertiesInput>> uiaGetMultipleParentElementProperties)
        {
            var __workflow_uiaGetMultipleParentElementProperties = WorkflowExpression.Compile(uiaGetMultipleParentElementProperties, nameof(uiaGetMultipleParentElementProperties), required: true);
            return new DeferredBodyAction<UiaGetMultipleParentElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGetMultipleParentElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetMultipleParentElementProperties);
                return new ApiConnectionAction<UiaGetMultipleParentElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaSearchForFirstParentElementResponse, ApiConnectionActionConfiguration> UiaSearchForFirstParentElement(Expression<Func<UiaSearchForFirstParentElementInput>> uiaSearchForFirstParentElement)
        {
            var __workflow_uiaSearchForFirstParentElement = WorkflowExpression.Compile(uiaSearchForFirstParentElement, nameof(uiaSearchForFirstParentElement), required: true);
            return new DeferredBodyAction<UiaSearchForFirstParentElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIASearchForFirstParentElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaSearchForFirstParentElement);
                return new ApiConnectionAction<UiaSearchForFirstParentElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetMultipleElementsAsTableResponse, ApiConnectionActionConfiguration> UiaGetMultipleElementsAsTable(Expression<Func<UiaGetMultipleElementsAsTableInput>> uiaGetMultipleElementsAsTable)
        {
            var __workflow_uiaGetMultipleElementsAsTable = WorkflowExpression.Compile(uiaGetMultipleElementsAsTable, nameof(uiaGetMultipleElementsAsTable), required: true);
            return new DeferredBodyAction<UiaGetMultipleElementsAsTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGetMultipleElementsAsTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetMultipleElementsAsTable);
                return new ApiConnectionAction<UiaGetMultipleElementsAsTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaSetElementScrollPercentageResponse, ApiConnectionActionConfiguration> UiaSetElementScrollPercentage(Expression<Func<UiaSetElementScrollPercentageInput>> uiaSetElementScrollPercentage)
        {
            var __workflow_uiaSetElementScrollPercentage = WorkflowExpression.Compile(uiaSetElementScrollPercentage, nameof(uiaSetElementScrollPercentage), required: true);
            return new DeferredBodyAction<UiaSetElementScrollPercentageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIASetElementScrollPercentage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaSetElementScrollPercentage);
                return new ApiConnectionAction<UiaSetElementScrollPercentageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetElementSearchColourRegionResponse, ApiConnectionActionConfiguration> UiaGetElementSearchColourRegion(Expression<Func<UiaGetElementSearchColourRegionInput>> uiaGetElementSearchColourRegion)
        {
            var __workflow_uiaGetElementSearchColourRegion = WorkflowExpression.Compile(uiaGetElementSearchColourRegion, nameof(uiaGetElementSearchColourRegion), required: true);
            return new DeferredBodyAction<UiaGetElementSearchColourRegionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGetElementSearchColourRegion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetElementSearchColourRegion);
                return new ApiConnectionAction<UiaGetElementSearchColourRegionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGlobalMouseClickElementSearchColourRegionResponse, ApiConnectionActionConfiguration> UiaGlobalMouseClickElementSearchColourRegion(Expression<Func<UiaGlobalMouseClickElementSearchColourRegionInput>> uiaGlobalMouseClickElementSearchColourRegion)
        {
            var __workflow_uiaGlobalMouseClickElementSearchColourRegion = WorkflowExpression.Compile(uiaGlobalMouseClickElementSearchColourRegion, nameof(uiaGlobalMouseClickElementSearchColourRegion), required: true);
            return new DeferredBodyAction<UiaGlobalMouseClickElementSearchColourRegionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGlobalMouseClickElementSearchColourRegion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGlobalMouseClickElementSearchColourRegion);
                return new ApiConnectionAction<UiaGlobalMouseClickElementSearchColourRegionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetWin32WindowsResponse, ApiConnectionActionConfiguration> UiaGetWin32Windows(Expression<Func<UiaGetWin32WindowsInput>> uiaGetWin32Windows)
        {
            var __workflow_uiaGetWin32Windows = WorkflowExpression.Compile(uiaGetWin32Windows, nameof(uiaGetWin32Windows), required: true);
            return new DeferredBodyAction<UiaGetWin32WindowsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetWin32Windows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetWin32Windows);
                return new ApiConnectionAction<UiaGetWin32WindowsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<SetUiaElementSearchModeResponse, ApiConnectionActionConfiguration> SetUiaElementSearchMode(Expression<Func<SetUiaElementSearchModeInput>> setUiaElementSearchMode)
        {
            var __workflow_setUiaElementSearchMode = WorkflowExpression.Compile(setUiaElementSearchMode, nameof(setUiaElementSearchMode), required: true);
            return new DeferredBodyAction<SetUiaElementSearchModeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/SetUIAElementSearchMode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_setUiaElementSearchMode);
                return new ApiConnectionAction<SetUiaElementSearchModeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<GetUiaElementSearchModeResponse, ApiConnectionActionConfiguration> GetUiaElementSearchMode(Expression<Func<GetUiaElementSearchModeInput>> getUiaElementSearchMode)
        {
            var __workflow_getUiaElementSearchMode = WorkflowExpression.Compile(getUiaElementSearchMode, nameof(getUiaElementSearchMode), required: true);
            return new DeferredBodyAction<GetUiaElementSearchModeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetUIAElementSearchMode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getUiaElementSearchMode);
                return new ApiConnectionAction<GetUiaElementSearchModeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaGetElementPatternsResponse, ApiConnectionActionConfiguration> UiaGetElementPatterns(Expression<Func<UiaGetElementPatternsInput>> uiaGetElementPatterns)
        {
            var __workflow_uiaGetElementPatterns = WorkflowExpression.Compile(uiaGetElementPatterns, nameof(uiaGetElementPatterns), required: true);
            return new DeferredBodyAction<UiaGetElementPatternsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGetElementPatterns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaGetElementPatterns);
                return new ApiConnectionAction<UiaGetElementPatternsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaMoveElementResponse, ApiConnectionActionConfiguration> UiaMoveElement(Expression<Func<UiaMoveElementInput>> uiaMoveElement)
        {
            var __workflow_uiaMoveElement = WorkflowExpression.Compile(uiaMoveElement, nameof(uiaMoveElement), required: true);
            return new DeferredBodyAction<UiaMoveElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAMoveElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaMoveElement);
                return new ApiConnectionAction<UiaMoveElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaResizeElementResponse, ApiConnectionActionConfiguration> UiaResizeElement(Expression<Func<UiaResizeElementInput>> uiaResizeElement)
        {
            var __workflow_uiaResizeElement = WorkflowExpression.Compile(uiaResizeElement, nameof(uiaResizeElement), required: true);
            return new DeferredBodyAction<UiaResizeElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAResizeElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaResizeElement);
                return new ApiConnectionAction<UiaResizeElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaLocateVisibleSearchImageWithinElementResponse, ApiConnectionActionConfiguration> UiaLocateVisibleSearchImageWithinElement(Expression<Func<UiaLocateVisibleSearchImageWithinElementInput>> uiaLocateVisibleSearchImageWithinElement)
        {
            var __workflow_uiaLocateVisibleSearchImageWithinElement = WorkflowExpression.Compile(uiaLocateVisibleSearchImageWithinElement, nameof(uiaLocateVisibleSearchImageWithinElement), required: true);
            return new DeferredBodyAction<UiaLocateVisibleSearchImageWithinElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIALocateVisibleSearchImageWithinElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaLocateVisibleSearchImageWithinElement);
                return new ApiConnectionAction<UiaLocateVisibleSearchImageWithinElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaWaitForVisibleSearchImageWithinElementResponse, ApiConnectionActionConfiguration> UiaWaitForVisibleSearchImageWithinElement(Expression<Func<UiaWaitForVisibleSearchImageWithinElementInput>> uiaWaitForVisibleSearchImageWithinElement)
        {
            var __workflow_uiaWaitForVisibleSearchImageWithinElement = WorkflowExpression.Compile(uiaWaitForVisibleSearchImageWithinElement, nameof(uiaWaitForVisibleSearchImageWithinElement), required: true);
            return new DeferredBodyAction<UiaWaitForVisibleSearchImageWithinElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAWaitForVisibleSearchImageWithinElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaWaitForVisibleSearchImageWithinElement);
                return new ApiConnectionAction<UiaWaitForVisibleSearchImageWithinElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UiaWaitForVisibleSearchImageToNotExistWithinElementResponse, ApiConnectionActionConfiguration> UiaWaitForVisibleSearchImageToNotExistWithinElement(Expression<Func<UiaWaitForVisibleSearchImageToNotExistWithinElementInput>> uiaWaitForVisibleSearchImageToNotExistWithinElement)
        {
            var __workflow_uiaWaitForVisibleSearchImageToNotExistWithinElement = WorkflowExpression.Compile(uiaWaitForVisibleSearchImageToNotExistWithinElement, nameof(uiaWaitForVisibleSearchImageToNotExistWithinElement), required: true);
            return new DeferredBodyAction<UiaWaitForVisibleSearchImageToNotExistWithinElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAWaitForVisibleSearchImageToNotExistWithinElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_uiaWaitForVisibleSearchImageToNotExistWithinElement);
                return new ApiConnectionAction<UiaWaitForVisibleSearchImageToNotExistWithinElementResponse>(callPayload);
            });
        }
    }

    public class IaconnectuiTriggers([ConnectionName] string connectionId)
    {
    }

    public class UiaDoesTopLevelWindowExistResponse
    {
        public bool WindowExists { get; set; }
    }

    public class UiaDoesTopLevelWindowExistInput
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

    public class UiaGetHandleForTopLevelWindowResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UiaGetHandleForTopLevelWindowInput
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

    public class UiaWaitForTopLevelWindowResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
        public bool ElementExists { get; set; }
    }

    public class UiaWaitForTopLevelWindowInput
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

    public class UiaDoesProcessHaveWindowResponse
    {
        public bool ProcessHasWindow { get; set; }
    }

    public class UiaDoesProcessHaveWindowInput
    {
        public UiaDoesProcessHaveWindowInput(string searchProcessName)
        {
            this.SearchProcessName = searchProcessName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchProcessName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UiaGetHandleForProcessMainWindowResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UiaGetHandleForProcessMainWindowInput
    {
        public UiaGetHandleForProcessMainWindowInput(string searchProcessName)
        {
            this.SearchProcessName = searchProcessName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchProcessName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UiaWaitForProcessMainWindowResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
        public bool ElementExists { get; set; }
    }

    public class UiaWaitForProcessMainWindowInput
    {
        public UiaWaitForProcessMainWindowInput(string searchProcessName)
        {
            this.SearchProcessName = searchProcessName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchProcessName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SecondsToWait { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UiaGetHandleForProcessIdMainWindowResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UiaGetHandleForProcessIdMainWindowInput
    {
        public UiaGetHandleForProcessIdMainWindowInput(int processId)
        {
            this.ProcessId = processId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ProcessId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UiaWaitForProcessIdMainWindowResponse
    {
        public bool ElementExists { get; set; }
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UiaWaitForProcessIdMainWindowInput
    {
        public UiaWaitForProcessIdMainWindowInput(int processId)
        {
            this.ProcessId = processId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ProcessId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SecondsToWait { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UiaGetHandleForFocussedElementResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UiaGetHandleForFocussedElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UiaGetHandleForMainWindowOfFocussedElementResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UiaGetHandleForMainWindowOfFocussedElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UiaGetHandleForDesktopResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UiaGetHandleForDesktopInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UiaSetForegroundWindowInput
    {
        public UiaSetForegroundWindowInput(int windowHandle)
        {
            this.WindowHandle = windowHandle;
        }

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

    public class UiaMaximiseWindowInput
    {
        public UiaMaximiseWindowInput(int windowHandle)
        {
            this.WindowHandle = windowHandle;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int WindowHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UiaMinimiseWindowInput
    {
        public UiaMinimiseWindowInput(int windowHandle)
        {
            this.WindowHandle = windowHandle;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int WindowHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UiaSetWindowToNormalInput
    {
        public UiaSetWindowToNormalInput(int windowHandle)
        {
            this.WindowHandle = windowHandle;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int WindowHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UiaDoesElementExistResponse
    {
        public bool ElementExists { get; set; }
        public int ElementHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UiaDoesElementExistInput
    {
        public UiaDoesElementExistInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaDoesDesktopElementExistResponse
    {
        public bool ElementExists { get; set; }
        public int ElementHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UiaDoesDesktopElementExistInput
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

    public class UiaWaitForElementResponse
    {
        public bool ElementExists { get; set; }
        public int ElementHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UiaWaitForElementInput
    {
        public UiaWaitForElementInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaWaitForDesktopElementResponse
    {
        public bool ElementExists { get; set; }
        public int ElementHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UiaWaitForDesktopElementInput
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

    public class UiaWaitForElementToNotExistResponse
    {
        public bool ElementExistsBeforeWait { get; set; }
        public bool ElementExistsAfterWait { get; set; }
    }

    public class UiaWaitForElementToNotExistInput
    {
        public UiaWaitForElementToNotExistInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaWaitForDesktopElementToNotExistResponse
    {
        public bool ElementExistsBeforeWait { get; set; }
        public bool ElementExistsAfterWait { get; set; }
    }

    public class UiaWaitForDesktopElementToNotExistInput
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

    public class UiaPressElementInput
    {
        public UiaPressElementInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaGlobalMouseClickOnElementInput
    {
        public UiaGlobalMouseClickOnElementInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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
        public UiaGlobalMouseClickOnElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

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
    public enum UiaGlobalMouseClickOnElementInputOffsetRelativeToType
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

    public class UiaGlobalRightMouseClickOnElementInput
    {
        public UiaGlobalRightMouseClickOnElementInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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
        public UiaGlobalRightMouseClickOnElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

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
    public enum UiaGlobalRightMouseClickOnElementInputOffsetRelativeToType
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

    public class UiaGlobalMiddleMouseClickOnElementInput
    {
        public UiaGlobalMiddleMouseClickOnElementInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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
        public UiaGlobalMiddleMouseClickOnElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

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
    public enum UiaGlobalMiddleMouseClickOnElementInputOffsetRelativeToType
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

    public class UiaGlobalDoubleLeftMouseClickOnElementInput
    {
        public UiaGlobalDoubleLeftMouseClickOnElementInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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
        public UiaGlobalDoubleLeftMouseClickOnElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

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
    public enum UiaGlobalDoubleLeftMouseClickOnElementInputOffsetRelativeToType
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

    public class UiaSelectElementInput
    {
        public UiaSelectElementInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaInputPasswordIntoElementInput
    {
        public UiaInputPasswordIntoElementInput(int parentWindowHandle, string passwordToInput)
        {
            this.ParentWindowHandle = parentWindowHandle;
            this.PasswordToInput = passwordToInput;
        }

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

    public class UiaInputTextIntoElementInput
    {
        public UiaInputTextIntoElementInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaInputTextIntoMultipleElementsInput
    {
        public UiaInputTextIntoMultipleElementsInput(string inputElementsJson)
        {
            this.InputElementsJson = inputElementsJson;
        }

        [JsonProperty("InputElementsJSON", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputElementsJson { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UiaInputReturnIntoElementInput
    {
        public UiaInputReturnIntoElementInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaFocusElementInput
    {
        public UiaFocusElementInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaToggleElementInput
    {
        public UiaToggleElementInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaCheckElementInput
    {
        public UiaCheckElementInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaCheckMultipleElementsInput
    {
        public UiaCheckMultipleElementsInput(string inputElementsJson)
        {
            this.InputElementsJson = inputElementsJson;
        }

        [JsonProperty("InputElementsJSON", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputElementsJson { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UiaisElementCheckedResponse
    {
        public bool ElementIsChecked { get; set; }
    }

    public class UiaisElementCheckedInput
    {
        public UiaisElementCheckedInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaCloseElementWindowInput
    {
        public UiaCloseElementWindowInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaGetElementTextValueResponse
    {
        public string ElementTextValue { get; set; }
    }

    public class UiaGetElementTextValueInput
    {
        public UiaGetElementTextValueInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaGetElementValueResponse
    {
        public string ElementValue { get; set; }
    }

    public class UiaGetElementValueInput
    {
        public UiaGetElementValueInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaGetElementLabelValueResponse
    {
        public string ElementLabelValue { get; set; }
    }

    public class UiaGetElementLabelValueInput
    {
        public UiaGetElementLabelValueInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaGetElementPropertiesResponse
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

    public class UiaGetElementPropertiesInput
    {
        public UiaGetElementPropertiesInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaGetMultipleElementPropertiesResponse
    {
        public int NumberOfElementsFound { get; set; }
        public int NumberOfElementsReturned { get; set; }
        public JToken[] ElementProperties { get; set; }
    }

    public class UiaGetMultipleElementPropertiesInput
    {
        public UiaGetMultipleElementPropertiesInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaGetDesktopElementsResponse
    {
        public int NumberOfElementsFound { get; set; }
        public int NumberOfElementsReturned { get; set; }
        public JToken[] ElementProperties { get; set; }
    }

    public class UiaGetDesktopElementsInput
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

    public class UiaExpandElementInput
    {
        public UiaExpandElementInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaCollapseElementInput
    {
        public UiaCollapseElementInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaTakeScreenShotOfElementLocationResponse
    {
        public string ScreenBitmapBase64 { get; set; }
    }

    public class UiaTakeScreenShotOfElementLocationInput
    {
        public UiaTakeScreenShotOfElementLocationInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentWindowHandle { get; set; }
        public string SearchElementName { get; set; }
        public string SearchElementClassName { get; set; }
        public string SearchElementAutomationId { get; set; }
        public string SearchLocalizedControlType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;
        public UiaTakeScreenShotOfElementLocationInputImageFormatType? ImageFormat { get; set; }

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
    public enum UiaTakeScreenShotOfElementLocationInputImageFormatType
    {
        [EnumMember(Value = "PNG")]
        Png,
        [EnumMember(Value = "JPG")]
        Jpg,
        [EnumMember(Value = "BMP")]
        Bmp,
        [EnumMember(Value = "GIF")]
        Gif
    }

    public class UiaDrawRectangleAroundElementInput
    {
        public UiaDrawRectangleAroundElementInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaGetParentElementHandleResponse
    {
        public int ParentElementHandle { get; set; }
    }

    public class UiaGetParentElementHandleInput
    {
        public UiaGetParentElementHandleInput(int elementHandle)
        {
            this.ElementHandle = elementHandle;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ElementHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UiaGetDataGridElementContentsResponse
    {
        [JsonProperty("DataGridContentsJSON")]
        public string DataGridContentsJson { get; set; }
        public int NumberOfRowsInTable { get; set; }
        public int NumberOfColumnsInTable { get; set; }
        public int ThreadId { get; set; }
    }

    public class UiaGetDataGridElementContentsInput
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

        [JsonProperty("ReturnRowUIAName", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnRowUiaName { get; set; } = false;

        [JsonProperty("NameOfColumnToStoreRowUIAName")]
        public string NameOfColumnToStoreRowUiaName { get; set; }

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

    public class UiaGetDataGridElementPropertiesResponse
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

    public class UiaGetDataGridElementPropertiesInput
    {
        public UiaGetDataGridElementPropertiesInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaGetListElementItemsResponse
    {
        public int NumberOfListItems { get; set; }

        [JsonProperty("ListItemsJSON")]
        public string ListItemsJson { get; set; }
        public int NumberOfSelectedItems { get; set; }
        public int IndexOfFirstSelectedItem { get; set; }
        public string SelectedItemName { get; set; }
    }

    public class UiaGetListElementItemsInput
    {
        public UiaGetListElementItemsInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaClickListElementItemByNameInput
    {
        public UiaClickListElementItemByNameInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaClickListElementItemByIndexInput
    {
        public UiaClickListElementItemByIndexInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaSetElementToNumericValueInput
    {
        public UiaSetElementToNumericValueInput(int parentWindowHandle, int newValue)
        {
            this.ParentWindowHandle = parentWindowHandle;
            this.NewValue = newValue;
        }

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

    public class UiaSetElementToNumericRangeValueInput
    {
        public UiaSetElementToNumericRangeValueInput(int parentWindowHandle, double newValue)
        {
            this.ParentWindowHandle = parentWindowHandle;
            this.NewValue = newValue;
        }

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

    public class UiaResetAllElementHandlesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UiaGlobalPasswordInputIntoElementInput
    {
        public UiaGlobalPasswordInputIntoElementInput(int parentWindowHandle, string passwordToInput)
        {
            this.ParentWindowHandle = parentWindowHandle;
            this.PasswordToInput = passwordToInput;
        }

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

        [JsonProperty("ReplaceExistingValueUsingCTRLADelete", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReplaceExistingValueUsingCtrlaDelete { get; set; } = false;

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

    public class UiaGlobalTextInputIntoElementInput
    {
        public UiaGlobalTextInputIntoElementInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

        [JsonProperty("ReplaceExistingValueUsingCTRLADelete", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReplaceExistingValueUsingCtrlaDelete { get; set; } = false;
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

    public class UiaGetElementPropertiesAsListResponse
    {
        public int NumberOfElementsFound { get; set; }
        public int NumberOfElementsReturned { get; set; }

        [JsonProperty("UIAElementPropertiesJSON")]
        public string UiaElementPropertiesJson { get; set; }
    }

    public class UiaGetElementPropertiesAsListInput
    {
        public UiaGetElementPropertiesAsListInput(int elementHandle)
        {
            this.ElementHandle = elementHandle;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ElementHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UiaSetTransactionTimeoutInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double TimeoutInSeconds { get; set; } = 5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UiaGetElementAtCoordinatesResponse
    {
        public bool ElementFound { get; set; }
        public int ElementHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UiaGetElementAtCoordinatesInput
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

    public class UiaGetMultipleParentElementPropertiesResponse
    {
        [JsonProperty("UIAParentElements")]
        public JToken[] UiaParentElements { get; set; }
        public int NumberOfParentElementsReturned { get; set; }
    }

    public class UiaGetMultipleParentElementPropertiesInput
    {
        public UiaGetMultipleParentElementPropertiesInput(int elementHandle)
        {
            this.ElementHandle = elementHandle;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ElementHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxParentsToProcess { get; set; } = 50;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UiaSearchForFirstParentElementResponse
    {
        public bool ParentElementFound { get; set; }
        public int ParentElementHandle { get; set; }
        public string ParentElementName { get; set; }
        public string ParentElementClassName { get; set; }
        public string ParentElementAutomationId { get; set; }
        public string ParentElementLocalizedControlType { get; set; }
    }

    public class UiaSearchForFirstParentElementInput
    {
        public UiaSearchForFirstParentElementInput(int elementHandle)
        {
            this.ElementHandle = elementHandle;
        }

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

    public class UiaGetMultipleElementsAsTableResponse
    {
        public int NumberOfCellSubElementsFound { get; set; }
        public int NumberOfCellSubElementsReturned { get; set; }

        [JsonProperty("TableContentsJSON")]
        public string TableContentsJson { get; set; }
        public int NumberOfRowsInTable { get; set; }
        public int NumberOfColumnsInTable { get; set; }
        public int ThreadId { get; set; }
    }

    public class UiaGetMultipleElementsAsTableInput
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

    public class UiaSetElementScrollPercentageResponse
    {
        [JsonProperty("UIASetElementScrollPercentageResult")]
        public bool UiaSetElementScrollPercentageResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class UiaSetElementScrollPercentageInput
    {
        public UiaSetElementScrollPercentageInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaGetElementSearchColourRegionResponse
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

    public class UiaGetElementSearchColourRegionInput
    {
        public UiaGetElementSearchColourRegionInput(int parentWindowHandle, string searchColour, int maxColourDeviation)
        {
            this.ParentWindowHandle = parentWindowHandle;
            this.SearchColour = searchColour;
            this.MaxColourDeviation = maxColourDeviation;
        }

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

    public class UiaGlobalMouseClickElementSearchColourRegionResponse
    {
        [JsonProperty("UIAGlobalMouseClickElementSearchColourRegionResult")]
        public bool UiaGlobalMouseClickElementSearchColourRegionResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class UiaGlobalMouseClickElementSearchColourRegionInput
    {
        public UiaGlobalMouseClickElementSearchColourRegionInput(int parentWindowHandle, string searchColour, int maxColourDeviation)
        {
            this.ParentWindowHandle = parentWindowHandle;
            this.SearchColour = searchColour;
            this.MaxColourDeviation = maxColourDeviation;
        }

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
        public UiaGlobalMouseClickElementSearchColourRegionInputMouseButtonType? MouseButton { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui.UiaGlobalMouseClickElementSearchColourRegionInputMouseButtonType.Left;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetX { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetY { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UiaGlobalMouseClickElementSearchColourRegionInputOffsetRelativeToType? OffsetRelativeTo { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui.UiaGlobalMouseClickElementSearchColourRegionInputOffsetRelativeToType.Center;

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
    public enum UiaGlobalMouseClickElementSearchColourRegionInputMouseButtonType
    {
        Left,
        Right,
        Middle,
        [EnumMember(Value = "Double left")]
        DoubleLeft
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UiaGlobalMouseClickElementSearchColourRegionInputOffsetRelativeToType
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

    public class UiaGetWin32WindowsResponse
    {
        [JsonProperty("Win32WindowsJSON")]
        public string Win32WindowsJson { get; set; }
        public int NumberOfWin32Windows { get; set; }
    }

    public class UiaGetWin32WindowsInput
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

    public class SetUiaElementSearchModeResponse
    {
        [JsonProperty("SetUIAElementSearchModeResult")]
        public bool SetUiaElementSearchModeResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class SetUiaElementSearchModeInput
    {
        public SetUiaElementSearchModeInput(SetUiaElementSearchModeInputUiaElementSearchModeType uiaElementSearchMode)
        {
            this.UiaElementSearchMode = uiaElementSearchMode;
        }

        [JsonProperty("UIAElementSearchMode", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetUiaElementSearchModeInputUiaElementSearchModeType UiaElementSearchMode { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetUiaElementSearchModeInputUiaElementSearchModeType
    {
        FindAll,
        TreeWalkRaw
    }

    public class GetUiaElementSearchModeResponse
    {
        [JsonProperty("UIAElementSearchMode")]
        public string UiaElementSearchMode { get; set; }
    }

    public class GetUiaElementSearchModeInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UiaGetElementPatternsResponse
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

    public class UiaGetElementPatternsInput
    {
        public UiaGetElementPatternsInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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

    public class UiaMoveElementResponse
    {
        [JsonProperty("UIAMoveElementResult")]
        public bool UiaMoveElementResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class UiaMoveElementInput
    {
        public UiaMoveElementInput(int parentWindowHandle, int horizontalPosition, int verticalPosition)
        {
            this.ParentWindowHandle = parentWindowHandle;
            this.HorizontalPosition = horizontalPosition;
            this.VerticalPosition = verticalPosition;
        }

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
        public UiaMoveElementInputHorizontalMovementTypeType? HorizontalMovementType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui.UiaMoveElementInputHorizontalMovementTypeType.Absolute;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int HorizontalPosition { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UiaMoveElementInputVerticalMovementTypeType? VerticalMovementType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui.UiaMoveElementInputVerticalMovementTypeType.Absolute;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int VerticalPosition { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UiaMoveElementInputHorizontalMovementTypeType
    {
        Absolute,
        Relative
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UiaMoveElementInputVerticalMovementTypeType
    {
        Absolute,
        Relative
    }

    public class UiaResizeElementResponse
    {
        [JsonProperty("UIAResizeElementResult")]
        public bool UiaResizeElementResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class UiaResizeElementInput
    {
        public UiaResizeElementInput(int parentWindowHandle, int newWidth, int newHeight)
        {
            this.ParentWindowHandle = parentWindowHandle;
            this.NewWidth = newWidth;
            this.NewHeight = newHeight;
        }

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
        public UiaResizeElementInputResizeWidthTypeType? ResizeWidthType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui.UiaResizeElementInputResizeWidthTypeType.Relative;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int NewWidth { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UiaResizeElementInputResizeHeightTypeType? ResizeHeightType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui.UiaResizeElementInputResizeHeightTypeType.Relative;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int NewHeight { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UiaResizeElementInputResizeWidthTypeType
    {
        Absolute,
        Relative
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UiaResizeElementInputResizeHeightTypeType
    {
        Absolute,
        Relative
    }

    public class UiaLocateVisibleSearchImageWithinElementResponse
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

    public class UiaLocateVisibleSearchImageWithinElementInput
    {
        public UiaLocateVisibleSearchImageWithinElementInput(int parentWindowHandle)
        {
            this.ParentWindowHandle = parentWindowHandle;
        }

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
        public UiaLocateVisibleSearchImageWithinElementInputSearchImageTypeType? SearchImageType { get; set; }
        public string SearchImage { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UiaLocateVisibleSearchImageWithinElementInputAltSearchImageTypeType? AltSearchImageType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui.UiaLocateVisibleSearchImageWithinElementInputAltSearchImageTypeType.None;
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
        public UiaLocateVisibleSearchImageWithinElementInputPixelXOffsetsUnitType? PixelXOffsetsUnit { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui.UiaLocateVisibleSearchImageWithinElementInputPixelXOffsetsUnitType.Pixel;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UiaLocateVisibleSearchImageWithinElementInputPixelYOffsetsUnitType? PixelYOffsetsUnit { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui.UiaLocateVisibleSearchImageWithinElementInputPixelYOffsetsUnitType.Pixel;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchImageIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UiaLocateVisibleSearchImageWithinElementInputImageSearchDirectionType? ImageSearchDirection { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui.UiaLocateVisibleSearchImageWithinElementInputImageSearchDirectionType.FromTop;

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
    public enum UiaLocateVisibleSearchImageWithinElementInputSearchImageTypeType
    {
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UiaLocateVisibleSearchImageWithinElementInputAltSearchImageTypeType
    {
        None,
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UiaLocateVisibleSearchImageWithinElementInputPixelXOffsetsUnitType
    {
        Pixel,
        Percent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UiaLocateVisibleSearchImageWithinElementInputPixelYOffsetsUnitType
    {
        Pixel,
        Percent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UiaLocateVisibleSearchImageWithinElementInputImageSearchDirectionType
    {
        FromTop,
        FromBottom,
        FromLeft,
        FromRight
    }

    public class UiaWaitForVisibleSearchImageWithinElementResponse
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

    public class UiaWaitForVisibleSearchImageWithinElementInput
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
        public UiaWaitForVisibleSearchImageWithinElementInputSearchImageTypeType? SearchImageType { get; set; }
        public string SearchImage { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UiaWaitForVisibleSearchImageWithinElementInputAltSearchImageTypeType? AltSearchImageType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui.UiaWaitForVisibleSearchImageWithinElementInputAltSearchImageTypeType.None;
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
        public UiaWaitForVisibleSearchImageWithinElementInputPixelXOffsetsUnitType? PixelXOffsetsUnit { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui.UiaWaitForVisibleSearchImageWithinElementInputPixelXOffsetsUnitType.Pixel;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UiaWaitForVisibleSearchImageWithinElementInputPixelYOffsetsUnitType? PixelYOffsetsUnit { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui.UiaWaitForVisibleSearchImageWithinElementInputPixelYOffsetsUnitType.Pixel;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchImageIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UiaWaitForVisibleSearchImageWithinElementInputImageSearchDirectionType? ImageSearchDirection { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui.UiaWaitForVisibleSearchImageWithinElementInputImageSearchDirectionType.FromTop;

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
    public enum UiaWaitForVisibleSearchImageWithinElementInputSearchImageTypeType
    {
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UiaWaitForVisibleSearchImageWithinElementInputAltSearchImageTypeType
    {
        None,
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UiaWaitForVisibleSearchImageWithinElementInputPixelXOffsetsUnitType
    {
        Pixel,
        Percent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UiaWaitForVisibleSearchImageWithinElementInputPixelYOffsetsUnitType
    {
        Pixel,
        Percent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UiaWaitForVisibleSearchImageWithinElementInputImageSearchDirectionType
    {
        FromTop,
        FromBottom,
        FromLeft,
        FromRight
    }

    public class UiaWaitForVisibleSearchImageToNotExistWithinElementResponse
    {
        public bool SearchImagePresentBeforeWait { get; set; }
        public bool SearchImageStillPresentAfterWait { get; set; }
        public int WhichSearchImageStillPresent { get; set; }
        public int ThreadId { get; set; }
    }

    public class UiaWaitForVisibleSearchImageToNotExistWithinElementInput
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
        public UiaWaitForVisibleSearchImageToNotExistWithinElementInputSearchImageTypeType? SearchImageType { get; set; }
        public string SearchImage { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UiaWaitForVisibleSearchImageToNotExistWithinElementInputAltSearchImageTypeType? AltSearchImageType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui.UiaWaitForVisibleSearchImageToNotExistWithinElementInputAltSearchImageTypeType.None;
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
        public UiaWaitForVisibleSearchImageToNotExistWithinElementInputPixelXOffsetsUnitType? PixelXOffsetsUnit { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui.UiaWaitForVisibleSearchImageToNotExistWithinElementInputPixelXOffsetsUnitType.Pixel;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UiaWaitForVisibleSearchImageToNotExistWithinElementInputPixelYOffsetsUnitType? PixelYOffsetsUnit { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui.UiaWaitForVisibleSearchImageToNotExistWithinElementInputPixelYOffsetsUnitType.Pixel;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchImageIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UiaWaitForVisibleSearchImageToNotExistWithinElementInputImageSearchDirectionType? ImageSearchDirection { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui.UiaWaitForVisibleSearchImageToNotExistWithinElementInputImageSearchDirectionType.FromTop;

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
    public enum UiaWaitForVisibleSearchImageToNotExistWithinElementInputSearchImageTypeType
    {
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UiaWaitForVisibleSearchImageToNotExistWithinElementInputAltSearchImageTypeType
    {
        None,
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UiaWaitForVisibleSearchImageToNotExistWithinElementInputPixelXOffsetsUnitType
    {
        Pixel,
        Percent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UiaWaitForVisibleSearchImageToNotExistWithinElementInputPixelYOffsetsUnitType
    {
        Pixel,
        Percent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UiaWaitForVisibleSearchImageToNotExistWithinElementInputImageSearchDirectionType
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