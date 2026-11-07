//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectjava
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectjavaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABConnectToJavaAccessBridgeResponse, ApiConnectionActionConfiguration> JABConnectToJavaAccessBridge(Expression<Func<JABConnectToJavaAccessBridgeInput>> jABConnectToJavaAccessBridge)
        {
            var __workflow_jABConnectToJavaAccessBridge = WorkflowExpression.Compile(jABConnectToJavaAccessBridge, nameof(jABConnectToJavaAccessBridge), required: true);
            return new DeferredBodyAction<JABConnectToJavaAccessBridgeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABConnectToJavaAccessBridge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABConnectToJavaAccessBridge);
                return new ApiConnectionAction<JABConnectToJavaAccessBridgeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JABDisconnectFromJavaAccessBridge(Expression<Func<JABDisconnectFromJavaAccessBridgeInput>> jABDisconnectFromJavaAccessBridge)
        {
            var __workflow_jABDisconnectFromJavaAccessBridge = WorkflowExpression.Compile(jABDisconnectFromJavaAccessBridge, nameof(jABDisconnectFromJavaAccessBridge), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABDisconnectFromJavaAccessBridge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABDisconnectFromJavaAccessBridge);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetConnectionStatusResponse, ApiConnectionActionConfiguration> JABGetConnectionStatus(Expression<Func<JABGetConnectionStatusInput>> jABGetConnectionStatus)
        {
            var __workflow_jABGetConnectionStatus = WorkflowExpression.Compile(jABGetConnectionStatus, nameof(jABGetConnectionStatus), required: true);
            return new DeferredBodyAction<JABGetConnectionStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetConnectionStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetConnectionStatus);
                return new ApiConnectionAction<JABGetConnectionStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABIsJavaWindowResponse, ApiConnectionActionConfiguration> JABIsJavaWindow(Expression<Func<JABIsJavaWindowInput>> jABIsJavaWindow)
        {
            var __workflow_jABIsJavaWindow = WorkflowExpression.Compile(jABIsJavaWindow, nameof(jABIsJavaWindow), required: true);
            return new DeferredBodyAction<JABIsJavaWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABIsJavaWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABIsJavaWindow);
                return new ApiConnectionAction<JABIsJavaWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetWindowsAccessBridgeInfoResponse, ApiConnectionActionConfiguration> JABGetWindowsAccessBridgeInfo(Expression<Func<JABGetWindowsAccessBridgeInfoInput>> jABGetWindowsAccessBridgeInfo)
        {
            var __workflow_jABGetWindowsAccessBridgeInfo = WorkflowExpression.Compile(jABGetWindowsAccessBridgeInfo, nameof(jABGetWindowsAccessBridgeInfo), required: true);
            return new DeferredBodyAction<JABGetWindowsAccessBridgeInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetWindowsAccessBridgeInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetWindowsAccessBridgeInfo);
                return new ApiConnectionAction<JABGetWindowsAccessBridgeInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetUIAElementPropertiesResponse, ApiConnectionActionConfiguration> JABGetUIAElementProperties(Expression<Func<JABGetUIAElementPropertiesInput>> jABGetUIAElementProperties)
        {
            var __workflow_jABGetUIAElementProperties = WorkflowExpression.Compile(jABGetUIAElementProperties, nameof(jABGetUIAElementProperties), required: true);
            return new DeferredBodyAction<JABGetUIAElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetUIAElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetUIAElementProperties);
                return new ApiConnectionAction<JABGetUIAElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetJABElementPropertiesResponse, ApiConnectionActionConfiguration> JABGetJABElementProperties(Expression<Func<JABGetJABElementPropertiesInput>> jABGetJABElementProperties)
        {
            var __workflow_jABGetJABElementProperties = WorkflowExpression.Compile(jABGetJABElementProperties, nameof(jABGetJABElementProperties), required: true);
            return new DeferredBodyAction<JABGetJABElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetJABElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetJABElementProperties);
                return new ApiConnectionAction<JABGetJABElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JABDrawRectangleAroundJABElement(Expression<Func<JABDrawRectangleAroundJABElementInput>> jABDrawRectangleAroundJABElement)
        {
            var __workflow_jABDrawRectangleAroundJABElement = WorkflowExpression.Compile(jABDrawRectangleAroundJABElement, nameof(jABDrawRectangleAroundJABElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABDrawRectangleAroundJABElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABDrawRectangleAroundJABElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABDoesElementExistResponse, ApiConnectionActionConfiguration> JABDoesElementExist(Expression<Func<JABDoesElementExistInput>> jABDoesElementExist)
        {
            var __workflow_jABDoesElementExist = WorkflowExpression.Compile(jABDoesElementExist, nameof(jABDoesElementExist), required: true);
            return new DeferredBodyAction<JABDoesElementExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABDoesElementExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABDoesElementExist);
                return new ApiConnectionAction<JABDoesElementExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABWaitForElementResponse, ApiConnectionActionConfiguration> JABWaitForElement(Expression<Func<JABWaitForElementInput>> jABWaitForElement)
        {
            var __workflow_jABWaitForElement = WorkflowExpression.Compile(jABWaitForElement, nameof(jABWaitForElement), required: true);
            return new DeferredBodyAction<JABWaitForElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABWaitForElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABWaitForElement);
                return new ApiConnectionAction<JABWaitForElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABWaitForElementToNotExistResponse, ApiConnectionActionConfiguration> JABWaitForElementToNotExist(Expression<Func<JABWaitForElementToNotExistInput>> jABWaitForElementToNotExist)
        {
            var __workflow_jABWaitForElementToNotExist = WorkflowExpression.Compile(jABWaitForElementToNotExist, nameof(jABWaitForElementToNotExist), required: true);
            return new DeferredBodyAction<JABWaitForElementToNotExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABWaitForElementToNotExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABWaitForElementToNotExist);
                return new ApiConnectionAction<JABWaitForElementToNotExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetDesktopElementsResponse, ApiConnectionActionConfiguration> JABGetDesktopElements(Expression<Func<JABGetDesktopElementsInput>> jABGetDesktopElements)
        {
            var __workflow_jABGetDesktopElements = WorkflowExpression.Compile(jABGetDesktopElements, nameof(jABGetDesktopElements), required: true);
            return new DeferredBodyAction<JABGetDesktopElementsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetDesktopElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetDesktopElements);
                return new ApiConnectionAction<JABGetDesktopElementsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABDoesDesktopElementExistResponse, ApiConnectionActionConfiguration> JABDoesDesktopElementExist(Expression<Func<JABDoesDesktopElementExistInput>> jABDoesDesktopElementExist)
        {
            var __workflow_jABDoesDesktopElementExist = WorkflowExpression.Compile(jABDoesDesktopElementExist, nameof(jABDoesDesktopElementExist), required: true);
            return new DeferredBodyAction<JABDoesDesktopElementExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABDoesDesktopElementExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABDoesDesktopElementExist);
                return new ApiConnectionAction<JABDoesDesktopElementExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABWaitForDesktopElementResponse, ApiConnectionActionConfiguration> JABWaitForDesktopElement(Expression<Func<JABWaitForDesktopElementInput>> jABWaitForDesktopElement)
        {
            var __workflow_jABWaitForDesktopElement = WorkflowExpression.Compile(jABWaitForDesktopElement, nameof(jABWaitForDesktopElement), required: true);
            return new DeferredBodyAction<JABWaitForDesktopElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABWaitForDesktopElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElement);
                return new ApiConnectionAction<JABWaitForDesktopElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABWaitForDesktopElementToNotExistResponse, ApiConnectionActionConfiguration> JABWaitForDesktopElementToNotExist(Expression<Func<JABWaitForDesktopElementToNotExistInput>> jABWaitForDesktopElementToNotExist)
        {
            var __workflow_jABWaitForDesktopElementToNotExist = WorkflowExpression.Compile(jABWaitForDesktopElementToNotExist, nameof(jABWaitForDesktopElementToNotExist), required: true);
            return new DeferredBodyAction<JABWaitForDesktopElementToNotExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABWaitForDesktopElementToNotExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementToNotExist);
                return new ApiConnectionAction<JABWaitForDesktopElementToNotExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JABFreeAllJABHandles(Expression<Func<JABFreeAllJABHandlesInput>> jABFreeAllJABHandles)
        {
            var __workflow_jABFreeAllJABHandles = WorkflowExpression.Compile(jABFreeAllJABHandles, nameof(jABFreeAllJABHandles), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABFreeAllJABHandles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABFreeAllJABHandles);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetChildJABElementPropertiesResponse, ApiConnectionActionConfiguration> JABGetChildJABElementProperties(Expression<Func<JABGetChildJABElementPropertiesInput>> jABGetChildJABElementProperties)
        {
            var __workflow_jABGetChildJABElementProperties = WorkflowExpression.Compile(jABGetChildJABElementProperties, nameof(jABGetChildJABElementProperties), required: true);
            return new DeferredBodyAction<JABGetChildJABElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetChildJABElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetChildJABElementProperties);
                return new ApiConnectionAction<JABGetChildJABElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetAllChildJABElementPropertiesResponse, ApiConnectionActionConfiguration> JABGetAllChildJABElementProperties(Expression<Func<JABGetAllChildJABElementPropertiesInput>> jABGetAllChildJABElementProperties)
        {
            var __workflow_jABGetAllChildJABElementProperties = WorkflowExpression.Compile(jABGetAllChildJABElementProperties, nameof(jABGetAllChildJABElementProperties), required: true);
            return new DeferredBodyAction<JABGetAllChildJABElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetAllChildJABElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetAllChildJABElementProperties);
                return new ApiConnectionAction<JABGetAllChildJABElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetParentJABElementPropertiesResponse, ApiConnectionActionConfiguration> JABGetParentJABElementProperties(Expression<Func<JABGetParentJABElementPropertiesInput>> jABGetParentJABElementProperties)
        {
            var __workflow_jABGetParentJABElementProperties = WorkflowExpression.Compile(jABGetParentJABElementProperties, nameof(jABGetParentJABElementProperties), required: true);
            return new DeferredBodyAction<JABGetParentJABElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetParentJABElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetParentJABElementProperties);
                return new ApiConnectionAction<JABGetParentJABElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JABPressElement(Expression<Func<JABPressElementInput>> jABPressElement)
        {
            var __workflow_jABPressElement = WorkflowExpression.Compile(jABPressElement, nameof(jABPressElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABPressElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABPressElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JABPerformActionOnElement(Expression<Func<JABPerformActionOnElementInput>> jABPerformActionOnElement)
        {
            var __workflow_jABPerformActionOnElement = WorkflowExpression.Compile(jABPerformActionOnElement, nameof(jABPerformActionOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABPerformActionOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABPerformActionOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JABGlobalLeftMouseClickOnElement(Expression<Func<JABGlobalLeftMouseClickOnElementInput>> jABGlobalLeftMouseClickOnElement)
        {
            var __workflow_jABGlobalLeftMouseClickOnElement = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElement, nameof(jABGlobalLeftMouseClickOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalLeftMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JABGlobalRightMouseClickOnElement(Expression<Func<JABGlobalRightMouseClickOnElementInput>> jABGlobalRightMouseClickOnElement)
        {
            var __workflow_jABGlobalRightMouseClickOnElement = WorkflowExpression.Compile(jABGlobalRightMouseClickOnElement, nameof(jABGlobalRightMouseClickOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalRightMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGlobalRightMouseClickOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JABGlobalMiddleMouseClickOnElement(Expression<Func<JABGlobalMiddleMouseClickOnElementInput>> jABGlobalMiddleMouseClickOnElement)
        {
            var __workflow_jABGlobalMiddleMouseClickOnElement = WorkflowExpression.Compile(jABGlobalMiddleMouseClickOnElement, nameof(jABGlobalMiddleMouseClickOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalMiddleMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGlobalMiddleMouseClickOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JABGlobalDoubleLeftMouseClickOnElement(Expression<Func<JABGlobalDoubleLeftMouseClickOnElementInput>> jABGlobalDoubleLeftMouseClickOnElement)
        {
            var __workflow_jABGlobalDoubleLeftMouseClickOnElement = WorkflowExpression.Compile(jABGlobalDoubleLeftMouseClickOnElement, nameof(jABGlobalDoubleLeftMouseClickOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalDoubleLeftMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGlobalDoubleLeftMouseClickOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetActionsForElementResponse, ApiConnectionActionConfiguration> JABGetActionsForElement(Expression<Func<JABGetActionsForElementInput>> jABGetActionsForElement)
        {
            var __workflow_jABGetActionsForElement = WorkflowExpression.Compile(jABGetActionsForElement, nameof(jABGetActionsForElement), required: true);
            return new DeferredBodyAction<JABGetActionsForElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetActionsForElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetActionsForElement);
                return new ApiConnectionAction<JABGetActionsForElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JABFocusElement(Expression<Func<JABFocusElementInput>> jABFocusElement)
        {
            var __workflow_jABFocusElement = WorkflowExpression.Compile(jABFocusElement, nameof(jABFocusElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABFocusElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABFocusElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JABInputPasswordIntoElement(Expression<Func<JABInputPasswordIntoElementInput>> jABInputPasswordIntoElement)
        {
            var __workflow_jABInputPasswordIntoElement = WorkflowExpression.Compile(jABInputPasswordIntoElement, nameof(jABInputPasswordIntoElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABInputPasswordIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABInputPasswordIntoElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JABInputTextIntoElement(Expression<Func<JABInputTextIntoElementInput>> jABInputTextIntoElement)
        {
            var __workflow_jABInputTextIntoElement = WorkflowExpression.Compile(jABInputTextIntoElement, nameof(jABInputTextIntoElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABInputTextIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABInputTextIntoElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetElementTextValueResponse, ApiConnectionActionConfiguration> JABGetElementTextValue(Expression<Func<JABGetElementTextValueInput>> jABGetElementTextValue)
        {
            var __workflow_jABGetElementTextValue = WorkflowExpression.Compile(jABGetElementTextValue, nameof(jABGetElementTextValue), required: true);
            return new DeferredBodyAction<JABGetElementTextValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetElementTextValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetElementTextValue);
                return new ApiConnectionAction<JABGetElementTextValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetElementValueResponse, ApiConnectionActionConfiguration> JABGetElementValue(Expression<Func<JABGetElementValueInput>> jABGetElementValue)
        {
            var __workflow_jABGetElementValue = WorkflowExpression.Compile(jABGetElementValue, nameof(jABGetElementValue), required: true);
            return new DeferredBodyAction<JABGetElementValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetElementValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetElementValue);
                return new ApiConnectionAction<JABGetElementValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JABCheckElement(Expression<Func<JABCheckElementInput>> jABCheckElement)
        {
            var __workflow_jABCheckElement = WorkflowExpression.Compile(jABCheckElement, nameof(jABCheckElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABCheckElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABCheckElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetElementPropertiesAsListResponse, ApiConnectionActionConfiguration> JABGetElementPropertiesAsList(Expression<Func<JABGetElementPropertiesAsListInput>> jABGetElementPropertiesAsList)
        {
            var __workflow_jABGetElementPropertiesAsList = WorkflowExpression.Compile(jABGetElementPropertiesAsList, nameof(jABGetElementPropertiesAsList), required: true);
            return new DeferredBodyAction<JABGetElementPropertiesAsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetElementPropertiesAsList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetElementPropertiesAsList);
                return new ApiConnectionAction<JABGetElementPropertiesAsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JABGlobalInputPasswordIntoElement(Expression<Func<JABGlobalInputPasswordIntoElementInput>> jABGlobalInputPasswordIntoElement)
        {
            var __workflow_jABGlobalInputPasswordIntoElement = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElement, nameof(jABGlobalInputPasswordIntoElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalInputPasswordIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JABGlobalInputTextIntoElement(Expression<Func<JABGlobalInputTextIntoElementInput>> jABGlobalInputTextIntoElement)
        {
            var __workflow_jABGlobalInputTextIntoElement = WorkflowExpression.Compile(jABGlobalInputTextIntoElement, nameof(jABGlobalInputTextIntoElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalInputTextIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetSelectionElementItemsResponse, ApiConnectionActionConfiguration> JABGetSelectionElementItems(Expression<Func<JABGetSelectionElementItemsInput>> jABGetSelectionElementItems)
        {
            var __workflow_jABGetSelectionElementItems = WorkflowExpression.Compile(jABGetSelectionElementItems, nameof(jABGetSelectionElementItems), required: true);
            return new DeferredBodyAction<JABGetSelectionElementItemsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetSelectionElementItems";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItems);
                return new ApiConnectionAction<JABGetSelectionElementItemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JABSetSelectionByIndex(Expression<Func<JABSetSelectionByIndexInput>> jABSetSelectionByIndex)
        {
            var __workflow_jABSetSelectionByIndex = WorkflowExpression.Compile(jABSetSelectionByIndex, nameof(jABSetSelectionByIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABSetSelectionByIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JABSetSelectionByName(Expression<Func<JABSetSelectionByNameInput>> jABSetSelectionByName)
        {
            var __workflow_jABSetSelectionByName = WorkflowExpression.Compile(jABSetSelectionByName, nameof(jABSetSelectionByName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABSetSelectionByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByName);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JABExpandSelection(Expression<Func<JABExpandSelectionInput>> jABExpandSelection)
        {
            var __workflow_jABExpandSelection = WorkflowExpression.Compile(jABExpandSelection, nameof(jABExpandSelection), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABExpandSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABExpandSelection);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetSelectionStateByIndexResponse, ApiConnectionActionConfiguration> JABGetSelectionStateByIndex(Expression<Func<JABGetSelectionStateByIndexInput>> jABGetSelectionStateByIndex)
        {
            var __workflow_jABGetSelectionStateByIndex = WorkflowExpression.Compile(jABGetSelectionStateByIndex, nameof(jABGetSelectionStateByIndex), required: true);
            return new DeferredBodyAction<JABGetSelectionStateByIndexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetSelectionStateByIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByIndex);
                return new ApiConnectionAction<JABGetSelectionStateByIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetSelectionStateByNameResponse, ApiConnectionActionConfiguration> JABGetSelectionStateByName(Expression<Func<JABGetSelectionStateByNameInput>> jABGetSelectionStateByName)
        {
            var __workflow_jABGetSelectionStateByName = WorkflowExpression.Compile(jABGetSelectionStateByName, nameof(jABGetSelectionStateByName), required: true);
            return new DeferredBodyAction<JABGetSelectionStateByNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetSelectionStateByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByName);
                return new ApiConnectionAction<JABGetSelectionStateByNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetTablePropertiesResponse, ApiConnectionActionConfiguration> JABGetTableProperties(Expression<Func<JABGetTablePropertiesInput>> jABGetTableProperties)
        {
            var __workflow_jABGetTableProperties = WorkflowExpression.Compile(jABGetTableProperties, nameof(jABGetTableProperties), required: true);
            return new DeferredBodyAction<JABGetTablePropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetTableProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetTableProperties);
                return new ApiConnectionAction<JABGetTablePropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetTableCellPropertiesResponse, ApiConnectionActionConfiguration> JABGetTableCellProperties(Expression<Func<JABGetTableCellPropertiesInput>> jABGetTableCellProperties)
        {
            var __workflow_jABGetTableCellProperties = WorkflowExpression.Compile(jABGetTableCellProperties, nameof(jABGetTableCellProperties), required: true);
            return new DeferredBodyAction<JABGetTableCellPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetTableCellProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetTableCellProperties);
                return new ApiConnectionAction<JABGetTableCellPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetTableContentsResponse, ApiConnectionActionConfiguration> JABGetTableContents(Expression<Func<JABGetTableContentsInput>> jABGetTableContents)
        {
            var __workflow_jABGetTableContents = WorkflowExpression.Compile(jABGetTableContents, nameof(jABGetTableContents), required: true);
            return new DeferredBodyAction<JABGetTableContentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetTableContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetTableContents);
                return new ApiConnectionAction<JABGetTableContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABIsTableCellVisibleOnscreenResponse, ApiConnectionActionConfiguration> JABIsTableCellVisibleOnscreen(Expression<Func<JABIsTableCellVisibleOnscreenInput>> jABIsTableCellVisibleOnscreen)
        {
            var __workflow_jABIsTableCellVisibleOnscreen = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreen, nameof(jABIsTableCellVisibleOnscreen), required: true);
            return new DeferredBodyAction<JABIsTableCellVisibleOnscreenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABIsTableCellVisibleOnscreen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreen);
                return new ApiConnectionAction<JABIsTableCellVisibleOnscreenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABIsJABHandleSameObjectResponse, ApiConnectionActionConfiguration> JABIsJABHandleSameObject(Expression<Func<JABIsJABHandleSameObjectInput>> jABIsJABHandleSameObject)
        {
            var __workflow_jABIsJABHandleSameObject = WorkflowExpression.Compile(jABIsJABHandleSameObject, nameof(jABIsJABHandleSameObject), required: true);
            return new DeferredBodyAction<JABIsJABHandleSameObjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABIsJABHandleSameObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABIsJABHandleSameObject);
                return new ApiConnectionAction<JABIsJABHandleSameObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetVisibleBoundingRectangleOfElementOnscreenResponse, ApiConnectionActionConfiguration> JABGetVisibleBoundingRectangleOfElementOnscreen(Expression<Func<JABGetVisibleBoundingRectangleOfElementOnscreenInput>> jABGetVisibleBoundingRectangleOfElementOnscreen)
        {
            var __workflow_jABGetVisibleBoundingRectangleOfElementOnscreen = WorkflowExpression.Compile(jABGetVisibleBoundingRectangleOfElementOnscreen, nameof(jABGetVisibleBoundingRectangleOfElementOnscreen), required: true);
            return new DeferredBodyAction<JABGetVisibleBoundingRectangleOfElementOnscreenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetVisibleBoundingRectangleOfElementOnscreen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetVisibleBoundingRectangleOfElementOnscreen);
                return new ApiConnectionAction<JABGetVisibleBoundingRectangleOfElementOnscreenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABCreateHandleForJABElementAtScreenCoordinateResponse, ApiConnectionActionConfiguration> JABCreateHandleForJABElementAtScreenCoordinate(Expression<Func<JABCreateHandleForJABElementAtScreenCoordinateInput>> jABCreateHandleForJABElementAtScreenCoordinate)
        {
            var __workflow_jABCreateHandleForJABElementAtScreenCoordinate = WorkflowExpression.Compile(jABCreateHandleForJABElementAtScreenCoordinate, nameof(jABCreateHandleForJABElementAtScreenCoordinate), required: true);
            return new DeferredBodyAction<JABCreateHandleForJABElementAtScreenCoordinateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABCreateHandleForJABElementAtScreenCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABCreateHandleForJABElementAtScreenCoordinate);
                return new ApiConnectionAction<JABCreateHandleForJABElementAtScreenCoordinateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetTableCellAtScreenCoordinateResponse, ApiConnectionActionConfiguration> JABGetTableCellAtScreenCoordinate(Expression<Func<JABGetTableCellAtScreenCoordinateInput>> jABGetTableCellAtScreenCoordinate)
        {
            var __workflow_jABGetTableCellAtScreenCoordinate = WorkflowExpression.Compile(jABGetTableCellAtScreenCoordinate, nameof(jABGetTableCellAtScreenCoordinate), required: true);
            return new DeferredBodyAction<JABGetTableCellAtScreenCoordinateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetTableCellAtScreenCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetTableCellAtScreenCoordinate);
                return new ApiConnectionAction<JABGetTableCellAtScreenCoordinateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetMultipleParentJABElementPropertiesResponse, ApiConnectionActionConfiguration> JABGetMultipleParentJABElementProperties(Expression<Func<JABGetMultipleParentJABElementPropertiesInput>> jABGetMultipleParentJABElementProperties)
        {
            var __workflow_jABGetMultipleParentJABElementProperties = WorkflowExpression.Compile(jABGetMultipleParentJABElementProperties, nameof(jABGetMultipleParentJABElementProperties), required: true);
            return new DeferredBodyAction<JABGetMultipleParentJABElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetMultipleParentJABElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetMultipleParentJABElementProperties);
                return new ApiConnectionAction<JABGetMultipleParentJABElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JABGlobalMouseClickOnTableCell(Expression<Func<JABGlobalMouseClickOnTableCellInput>> jABGlobalMouseClickOnTableCell)
        {
            var __workflow_jABGlobalMouseClickOnTableCell = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCell, nameof(jABGlobalMouseClickOnTableCell), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalMouseClickOnTableCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCell);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetRoleCSVFromElementSearchResponse, ApiConnectionActionConfiguration> JABGetRoleCSVFromElementSearch(Expression<Func<JABGetRoleCSVFromElementSearchInput>> jABGetRoleCSVFromElementSearch)
        {
            var __workflow_jABGetRoleCSVFromElementSearch = WorkflowExpression.Compile(jABGetRoleCSVFromElementSearch, nameof(jABGetRoleCSVFromElementSearch), required: true);
            return new DeferredBodyAction<JABGetRoleCSVFromElementSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetRoleCSVFromElementSearch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementSearch);
                return new ApiConnectionAction<JABGetRoleCSVFromElementSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetRoleCSVFromElementHandleResponse, ApiConnectionActionConfiguration> JABGetRoleCSVFromElementHandle(Expression<Func<JABGetRoleCSVFromElementHandleInput>> jABGetRoleCSVFromElementHandle)
        {
            var __workflow_jABGetRoleCSVFromElementHandle = WorkflowExpression.Compile(jABGetRoleCSVFromElementHandle, nameof(jABGetRoleCSVFromElementHandle), required: true);
            return new DeferredBodyAction<JABGetRoleCSVFromElementHandleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetRoleCSVFromElementHandle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementHandle);
                return new ApiConnectionAction<JABGetRoleCSVFromElementHandleResponse>(callPayload);
            });
        }
    }

    public class IaconnectjavaTriggers([ConnectionName] string connectionId)
    {
    }

    public class JABConnectToJavaAccessBridgeResponse
    {
        public string LoadedWindowsAccessBridgeDLL { get; set; }
    }

    public class JABConnectToJavaAccessBridgeInput
    {
        public string WindowsAccessBridgeDLLSearchFolder { get; set; }
        public string IAJavaAccessBridgePath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Is64BitJABDLL { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseCOMFor64BitJABDLL { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EnableJavaAccessBridge { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string AccessibilityFilepath { get; set; } = "%USERPROFILE%\\.accessibility.properties";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? CommandTimeoutInSeconds { get; set; } = 20;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABDisconnectFromJavaAccessBridgeInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DisableJavaAccessBridge { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string AccessibilityFilepath { get; set; } = "%USERPROFILE%\\.accessibility.properties";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGetConnectionStatusResponse
    {
        public bool Connected { get; set; }
        public string ConnectionType { get; set; }
        public bool IsWAB64bit { get; set; }
        public string ConnectionError { get; set; }
        public string LoadedIAJABDLL { get; set; }
        public string LoadedWABDLL { get; set; }
        public string WABVersion { get; set; }
    }

    public class JABGetConnectionStatusInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABIsJavaWindowResponse
    {
        public bool IsJavaWindow { get; set; }
    }

    public class JABIsJavaWindowInput
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
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGetWindowsAccessBridgeInfoResponse
    {
        public string JavaClassVersion { get; set; }
        public string JavaDLLVersion { get; set; }
        public string WinDLLVersion { get; set; }
        public string VMVersion { get; set; }
    }

    public class JABGetWindowsAccessBridgeInfoInput
    {
        [JsonProperty("VMID", DefaultValueHandling = DefaultValueHandling.Include)]
        public int VMId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGetUIAElementPropertiesResponse
    {
        public int ElementJABHandle { get; set; }

        [JsonProperty("ElementVMID")]
        public int ElementVMId { get; set; }
        public string ElementName { get; set; }
        public string ElementDescription { get; set; }
        public string ElementRole { get; set; }
        public string ElementStates { get; set; }

        [JsonProperty("ElementStates_en_US")]
        public string ElementStatesEnUS { get; set; }
        public int ElementLeftEdge { get; set; }
        public int ElementTopEdge { get; set; }
        public int ElementWidth { get; set; }
        public int ElementHeight { get; set; }
        public int ElementRightEdge { get; set; }
        public int ElementBottomEdge { get; set; }
        public bool IsComponentElement { get; set; }
        public bool IsActionElement { get; set; }
        public bool IsSelectionElement { get; set; }
        public bool IsTextElement { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsVisible { get; set; }
        public bool IsShowing { get; set; }
        public bool IsOpaque { get; set; }
        public bool IsFocusable { get; set; }
        public bool IsEditable { get; set; }
        public bool IsSingleLine { get; set; }
        public bool IsResizable { get; set; }
        public bool IsModal { get; set; }
        public bool IsCollapsed { get; set; }
        public bool IsSelectable { get; set; }
        public bool IsSelected { get; set; }
        public bool IsVertical { get; set; }
        public bool IsHorizontal { get; set; }
        public bool IsActive { get; set; }
        public bool IsChecked { get; set; }
        public bool IsFocussed { get; set; }
        public bool IsExpanded { get; set; }

        [JsonProperty("AdditionalStates_en_US")]
        public string AdditionalStatesEnUS { get; set; }
        public int IndexInParent { get; set; }
        public int ChildrenCount { get; set; }
        public int ElementDepth { get; set; }
    }

    public class JABGetUIAElementPropertiesInput
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
        public int? MaxStringLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGetJABElementPropertiesResponse
    {
        public int ElementJABHandle { get; set; }

        [JsonProperty("ElementVMID")]
        public int ElementVMId { get; set; }
        public string ElementName { get; set; }
        public string ElementDescription { get; set; }
        public string ElementRole { get; set; }
        public string ElementStates { get; set; }

        [JsonProperty("ElementStates_en_US")]
        public string ElementStatesEnUS { get; set; }
        public int ElementLeftEdge { get; set; }
        public int ElementTopEdge { get; set; }
        public int ElementWidth { get; set; }
        public int ElementHeight { get; set; }
        public int ElementRightEdge { get; set; }
        public int ElementBottomEdge { get; set; }
        public bool IsComponentElement { get; set; }
        public bool IsActionElement { get; set; }
        public bool IsSelectionElement { get; set; }
        public bool IsTextElement { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsVisible { get; set; }
        public bool IsShowing { get; set; }
        public bool IsOpaque { get; set; }
        public bool IsFocusable { get; set; }
        public bool IsEditable { get; set; }
        public bool IsSingleLine { get; set; }
        public bool IsResizable { get; set; }
        public bool IsModal { get; set; }
        public bool IsCollapsed { get; set; }
        public bool IsSelectable { get; set; }
        public bool IsSelected { get; set; }
        public bool IsVertical { get; set; }
        public bool IsHorizontal { get; set; }
        public bool IsActive { get; set; }
        public bool IsChecked { get; set; }
        public bool IsFocussed { get; set; }
        public bool IsExpanded { get; set; }

        [JsonProperty("AdditionalStates_en_US")]
        public string AdditionalStatesEnUS { get; set; }
        public int IndexInParent { get; set; }
        public int ChildrenCount { get; set; }
        public int ElementDepth { get; set; }
    }

    public class JABGetJABElementPropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxStringLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABDrawRectangleAroundJABElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PenColour { get; set; } = "Orange";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? PenThicknessPixels { get; set; } = 4;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABDoesElementExistResponse
    {
        public bool ElementExists { get; set; }
        public int ElementJABHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementDescription { get; set; }
        public string ElementRole { get; set; }
    }

    public class JABDoesElementExistInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABWaitForElementResponse
    {
        public bool ElementExists { get; set; }
        public int ElementJABHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementDescription { get; set; }
        public string ElementRole { get; set; }
    }

    public class JABWaitForElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double SecondsToWait { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfElementNotFound { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABWaitForElementToNotExistResponse
    {
        public bool ElementExistsBeforeWait { get; set; }
        public bool ElementExistsAfterWait { get; set; }
    }

    public class JABWaitForElementToNotExistInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double SecondsToWait { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfElementStillExists { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGetDesktopElementsResponse
    {
        public int NumberOfElementsFound { get; set; }
        public int NumberOfElementsReturned { get; set; }
        public string JavaDesktopElementsJSON { get; set; }
    }

    public class JABGetDesktopElementsInput
    {
        public string SearchElementLocalizedControlType { get; set; }

        [JsonProperty("SearchProcessID", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchProcessId { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstItemToReturn { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxItemsToReturn { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchChildElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxStringLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeChildProcesses { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABDoesDesktopElementExistResponse
    {
        public bool ElementExists { get; set; }
        public int ElementJABHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementDescription { get; set; }
        public string ElementRole { get; set; }
    }

    public class JABDoesDesktopElementExistInput
    {
        public string SearchUIAElementName { get; set; }
        public string SearchUIAElementClassName { get; set; }
        public string SearchUIAElementLocalizedControlType { get; set; }

        [JsonProperty("SearchProcessID", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchProcessId { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchChildElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeChildProcesses { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABWaitForDesktopElementResponse
    {
        public bool ElementExists { get; set; }
        public int ElementJABHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementDescription { get; set; }
        public string ElementRole { get; set; }
    }

    public class JABWaitForDesktopElementInput
    {
        public string SearchUIAElementName { get; set; }
        public string SearchUIAElementClassName { get; set; }
        public string SearchUIAElementLocalizedControlType { get; set; }

        [JsonProperty("SearchProcessID", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchProcessId { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchChildElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double SecondsToWait { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeChildProcesses { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfElementNotFound { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABWaitForDesktopElementToNotExistResponse
    {
        public bool ElementExistsBeforeWait { get; set; }
        public bool ElementExistsAfterWait { get; set; }
    }

    public class JABWaitForDesktopElementToNotExistInput
    {
        public string SearchUIAElementName { get; set; }
        public string SearchUIAElementClassName { get; set; }
        public string SearchUIAElementLocalizedControlType { get; set; }

        [JsonProperty("SearchProcessID", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SearchProcessId { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchChildElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double SecondsToWait { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeChildProcesses { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfElementStillExists { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABFreeAllJABHandlesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGetChildJABElementPropertiesResponse
    {
        public int ElementJABHandle { get; set; }

        [JsonProperty("ElementVMID")]
        public int ElementVMId { get; set; }
        public string ElementName { get; set; }
        public string ElementDescription { get; set; }
        public string ElementRole { get; set; }
        public string ElementStates { get; set; }

        [JsonProperty("ElementStates_en_US")]
        public string ElementStatesEnUS { get; set; }
        public int ElementLeftEdge { get; set; }
        public int ElementTopEdge { get; set; }
        public int ElementRightEdge { get; set; }
        public int ElementBottomEdge { get; set; }
        public int ElementWidth { get; set; }
        public int ElementHeight { get; set; }
        public bool IsComponentElement { get; set; }
        public bool IsActionElement { get; set; }
        public bool IsSelectionElement { get; set; }
        public bool IsTextElement { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsVisible { get; set; }
        public bool IsShowing { get; set; }
        public bool IsOpaque { get; set; }
        public bool IsFocusable { get; set; }
        public bool IsEditable { get; set; }
        public bool IsSingleLine { get; set; }
        public bool IsResizable { get; set; }
        public bool IsModal { get; set; }
        public bool IsCollapsed { get; set; }
        public bool IsSelectable { get; set; }
        public bool IsSelected { get; set; }
        public bool IsVertical { get; set; }
        public bool IsHorizontal { get; set; }
        public bool IsActive { get; set; }
        public bool IsChecked { get; set; }
        public bool IsFocussed { get; set; }
        public bool IsExpanded { get; set; }

        [JsonProperty("AdditionalStates_en_US")]
        public string AdditionalStatesEnUS { get; set; }
        public int IndexInParent { get; set; }
        public int ChildrenCount { get; set; }
        public int ElementDepth { get; set; }
    }

    public class JABGetChildJABElementPropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchElementJABHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchChildIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxStringLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGetAllChildJABElementPropertiesResponse
    {
        public int NumberOfChildElementsReturned { get; set; }
        public bool MoreElementsAvailableAtCurrentDepth { get; set; }
        public bool MoreElementsAvailableAtLowerDepths { get; set; }
        public bool MoreElementsDeeperThanMaxDepth { get; set; }
        public string JavaChildElementsJSON { get; set; }
    }

    public class JABGetAllChildJABElementPropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchElementJABHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstItemToReturn { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxItemsToReturn { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxStringLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchDescendants { get; set; } = false;
        public string SearchRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGetParentJABElementPropertiesResponse
    {
        public int ElementJABHandle { get; set; }

        [JsonProperty("ElementVMID")]
        public int ElementVMId { get; set; }
        public string ElementName { get; set; }
        public string ElementDescription { get; set; }
        public string ElementRole { get; set; }
        public string ElementStates { get; set; }

        [JsonProperty("ElementStates_en_US")]
        public string ElementStatesEnUS { get; set; }
        public int ElementLeftEdge { get; set; }
        public int ElementTopEdge { get; set; }
        public int ElementRightEdge { get; set; }
        public int ElementBottomEdge { get; set; }
        public int ElementWidth { get; set; }
        public int ElementHeight { get; set; }
        public bool IsComponentElement { get; set; }
        public bool IsActionElement { get; set; }
        public bool IsSelectionElement { get; set; }
        public bool IsTextElement { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsVisible { get; set; }
        public bool IsShowing { get; set; }
        public bool IsOpaque { get; set; }
        public bool IsFocusable { get; set; }
        public bool IsEditable { get; set; }
        public bool IsSingleLine { get; set; }
        public bool IsResizable { get; set; }
        public bool IsModal { get; set; }
        public bool IsCollapsed { get; set; }
        public bool IsSelectable { get; set; }
        public bool IsSelected { get; set; }
        public bool IsVertical { get; set; }
        public bool IsHorizontal { get; set; }
        public bool IsActive { get; set; }
        public bool IsChecked { get; set; }
        public bool IsFocussed { get; set; }
        public bool IsExpanded { get; set; }

        [JsonProperty("AdditionalStates_en_US")]
        public string AdditionalStatesEnUS { get; set; }
        public int IndexInParent { get; set; }
        public int ChildrenCount { get; set; }
        public int ElementDepth { get; set; }
    }

    public class JABGetParentJABElementPropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchElementJABHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxStringLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABPressElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? NumberOfTimesToPressElement { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SecondsToWaitBetweenPresses { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectActionName { get; set; } = true;
        public string OverrideActionName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABPerformActionOnElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Action { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGlobalLeftMouseClickOnElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetX { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetY { get; set; } = 0;
        public JABGlobalLeftMouseClickOnElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? NumberOfTimesToClickElement { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SecondsToWaitBetweenClicks { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JABGlobalLeftMouseClickOnElementInputOffsetRelativeToType
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

    public class JABGlobalRightMouseClickOnElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetX { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetY { get; set; } = 0;
        public JABGlobalRightMouseClickOnElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JABGlobalRightMouseClickOnElementInputOffsetRelativeToType
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

    public class JABGlobalMiddleMouseClickOnElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetX { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetY { get; set; } = 0;
        public JABGlobalMiddleMouseClickOnElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JABGlobalMiddleMouseClickOnElementInputOffsetRelativeToType
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

    public class JABGlobalDoubleLeftMouseClickOnElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetX { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetY { get; set; } = 0;
        public JABGlobalDoubleLeftMouseClickOnElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DelayInMilliseconds { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JABGlobalDoubleLeftMouseClickOnElementInputOffsetRelativeToType
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

    public class JABGetActionsForElementResponse
    {
        public string AccessibleActions { get; set; }
    }

    public class JABGetActionsForElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABFocusElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABInputPasswordIntoElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PasswordToInput { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABInputTextIntoElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;
        public string TextToInput { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReplaceExistingValue { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? InsertPosition { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGetElementTextValueResponse
    {
        public string ElementTextValue { get; set; }
    }

    public class JABGetElementTextValueInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGetElementValueResponse
    {
        public string ElementCurrentValue { get; set; }
        public string ElementMaximumValue { get; set; }
        public string ElementMinimumValue { get; set; }
    }

    public class JABGetElementValueInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABCheckElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckElement { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDetectActionName { get; set; } = true;
        public string OverrideActionName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGetElementPropertiesAsListResponse
    {
        public int NumberOfElementsFound { get; set; }
        public int NumberOfElementsReturned { get; set; }
        public string JABElementPropertiesJSON { get; set; }
    }

    public class JABGetElementPropertiesAsListInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxStringLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGlobalInputPasswordIntoElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

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
        public int? KeyIntervalInMilliseconds { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DoubleClickIntervalInMilliseconds { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DontInterpretSymbols { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGlobalInputTextIntoElementInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

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
        public int? KeyIntervalInMilliseconds { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DoubleClickIntervalInMilliseconds { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DontInterpretSymbols { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGetSelectionElementItemsResponse
    {
        public int NumberOfSelectedItems { get; set; }
        public string AccessibleSelection1Name { get; set; }
        public int AccessibleSelection1IndexInParent { get; set; }
        public string JABSelectionSelectedItemsJSON { get; set; }
        public string JABSelectionListItemsJSON { get; set; }
    }

    public class JABGetSelectionElementItemsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? GetListOfOptionsBySelecting { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? GetListOfOptionsByReadingLabels { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExpandFirst { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CollapseAfter { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SecondsBetweenExpandCollapse { get; set; } = 0.05;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxListItemsToReturn { get; set; } = 100;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABSetSelectionByIndexInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ItemIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SelectItem { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ClearSelectionFirst { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RecoverOnFailure { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABSetSelectionByNameInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ItemName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SelectItem { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ItemNameCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ClearSelectionFirst { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? GetListOfOptionsBySelecting { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? GetListOfOptionsByReadingLabels { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExpandFirst { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CollapseAfter { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SecondsBetweenExpandCollapse { get; set; } = 0.05;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ForceEvenIfInCorrectState { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RecoverOnFailure { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABExpandSelectionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Expand { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? VerifyElementState { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SecondsToWaitForStateChange { get; set; } = 0.05;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGetSelectionStateByIndexResponse
    {
        public bool IndexIsSelected { get; set; }
    }

    public class JABGetSelectionStateByIndexInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ItemIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGetSelectionStateByNameResponse
    {
        public bool NameIsSelected { get; set; }
    }

    public class JABGetSelectionStateByNameInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ItemName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ItemNameCaseSensitive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGetTablePropertiesResponse
    {
        public int NumberOfRows { get; set; }
        public int NumberOfColumns { get; set; }
        public int NumberOfSelectedRows { get; set; }
        public int NumberOfSelectedColumns { get; set; }
        public int NumberOfRowsInRowHeader { get; set; }
        public int NumberOfColumnsInColumnHeader { get; set; }
        public bool ViewportLocated { get; set; }
        public int ViewportLeftEdge { get; set; }
        public int ViewportTopEdge { get; set; }
        public int ViewportWidth { get; set; }
        public int ViewportHeight { get; set; }
        public int ViewportRightEdge { get; set; }
        public int ViewportBottomEdge { get; set; }
        public int TopLeftVisibleCellIndexInParent { get; set; }
        public int TopLeftVisibleCellRowIndex { get; set; }
        public int TopLeftVisibleCellColumnIndex { get; set; }
        public int TopRightVisibleCellIndexInParent { get; set; }
        public int TopRightVisibleCellRowIndex { get; set; }
        public int TopRightVisibleCellColumnIndex { get; set; }
        public int BottomLeftVisibleCellIndexInParent { get; set; }
        public int BottomLeftVisibleCellRowIndex { get; set; }
        public int BottomLeftVisibleCellColumnIndex { get; set; }
        public int BottomRightVisibleCellIndexInParent { get; set; }
        public int BottomRightVisibleCellRowIndex { get; set; }
        public int BottomRightVisibleCellColumnIndex { get; set; }
        public int LeftmostVisibleColumnIndex { get; set; }
        public int RightmostVisibleColumnIndex { get; set; }
        public int TopmostVisibleRowIndex { get; set; }
        public int BottommostVisibleRowIndex { get; set; }
    }

    public class JABGetTablePropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EnumerateViewport { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ProcessViewportParents { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxViewportParentsToProcess { get; set; } = 50;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ViewportParentElementRolesToConsider { get; set; } = "Panel,Viewport,Layered pane,Root pane";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ViewportLeftMargin { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ViewportTopMargin { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ViewportRightMargin { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ViewportBottomMargin { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGetTableCellPropertiesResponse
    {
        public int CellIndex { get; set; }
        public int RowExtent { get; set; }
        public int ColumnExtent { get; set; }
        public bool IsSelected { get; set; }
        public string CellContents { get; set; }
        public int CellLeftEdge { get; set; }
        public int CellTopEdge { get; set; }
        public int CellRightEdge { get; set; }
        public int CellBottomEdge { get; set; }
        public int CellWidth { get; set; }
        public int CellHeight { get; set; }
        public bool CellOnscreen { get; set; }
        public bool CellVisibleResultIsCertain { get; set; }
        public int CellJABHandle { get; set; }
    }

    public class JABGetTableCellPropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ColumnIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnJABHandle { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EnumerateViewport { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ProcessViewportParents { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxViewportParentsToProcess { get; set; } = 50;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ViewportParentElementRolesToConsider { get; set; } = "Panel,Viewport,Layered pane,Root pane";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ViewportLeftMargin { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ViewportTopMargin { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ViewportRightMargin { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ViewportBottomMargin { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGetTableContentsResponse
    {
        public int NumberOfRowsInTable { get; set; }
        public int NumberOfColumnsInTable { get; set; }
        public int NumberOfSelectedRows { get; set; }
        public int NumberOfSelectedColumns { get; set; }
        public int NumberOfRowsReturned { get; set; }
        public int NumberOfColumnsReturned { get; set; }
        public string TableContentsJSON { get; set; }
    }

    public class JABGetTableContentsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstRowToReturn { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRowsToReturn { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? FirstColumnToReturn { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxColumnsToReturn { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseColumnHeadersFromTable { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnRowIndexInOutputCollection { get; set; } = true;
        public string NameOfColumnToStoreRowIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABIsTableCellVisibleOnscreenResponse
    {
        public bool CellOnScreen { get; set; }
        public bool ResultIsCertain { get; set; }
        public string OffscreenDirection { get; set; }
    }

    public class JABIsTableCellVisibleOnscreenInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ProcessViewportParents { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxViewportParentsToProcess { get; set; } = 50;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ViewportParentElementRolesToConsider { get; set; } = "Panel,Viewport,Layered pane,Root pane";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ViewportLeftMargin { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ViewportTopMargin { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ViewportRightMargin { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ViewportBottomMargin { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int CellRowIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int CellColumnIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABIsJABHandleSameObjectResponse
    {
        public bool SameObject { get; set; }
    }

    public class JABIsJABHandleSameObjectInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Element1JABHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Element2JABHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGetVisibleBoundingRectangleOfElementOnscreenResponse
    {
        public int ElementVisibleRectangleLeft { get; set; }
        public int ElementVisibleRectangleTop { get; set; }
        public int ElementVisibleRectangleRight { get; set; }
        public int ElementVisibleRectangleBottom { get; set; }
        public int ElementVisibleRectangleWidth { get; set; }
        public int ElementVisibleRectangleHeight { get; set; }
    }

    public class JABGetVisibleBoundingRectangleOfElementOnscreenInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ElementJABHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxParentsToProcess { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ParentElementRolesToConsider { get; set; } = "Panel,Viewport,Layered pane,Root pane";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DrawRectangle { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABCreateHandleForJABElementAtScreenCoordinateResponse
    {
        public int LocatedElementJABHandle { get; set; }
    }

    public class JABCreateHandleForJABElementAtScreenCoordinateInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentElementJABHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ScreenX { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ScreenY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGetTableCellAtScreenCoordinateResponse
    {
        public int CellIndexInParent { get; set; }
        public int CellRowIndex { get; set; }
        public int CellColumnIndex { get; set; }
        public int CellJABHandle { get; set; }
    }

    public class JABGetTableCellAtScreenCoordinateInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int TableElementJABHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ScreenX { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ScreenY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnJABHandle { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGetMultipleParentJABElementPropertiesResponse
    {
        public string JavaParentElementsJSON { get; set; }
        public int NumberOfParentElementsReturned { get; set; }
    }

    public class JABGetMultipleParentJABElementPropertiesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchElementJABHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxStringLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxParentsToProcess { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGlobalMouseClickOnTableCellInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RowIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ColumnIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EnumerateViewport { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ProcessViewportParents { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxViewportParentsToProcess { get; set; } = 50;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ViewportParentElementRolesToConsider { get; set; } = "Panel,Viewport,Layered pane,Root pane";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ViewportLeftMargin { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ViewportTopMargin { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ViewportRightMargin { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ViewportBottomMargin { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int MouseButton { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetX { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? ClickOffsetY { get; set; } = 0;
        public JABGlobalMouseClickOnTableCellInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DelayInMilliseconds { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JABGlobalMouseClickOnTableCellInputOffsetRelativeToType
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

    public class JABGetRoleCSVFromElementSearchResponse
    {
        public bool ElementFound { get; set; }
        public int ElementsSearched { get; set; }
        public string RoleCSV { get; set; }
    }

    public class JABGetRoleCSVFromElementSearchInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }
        public string SearchElementJABName { get; set; }
        public string SearchElementJABDescription { get; set; }
        public string SearchElementJABRole { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MatchIndex { get; set; } = 1;
        public string SearchFilter { get; set; }
        public string SortByColumn { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MatchIndexAscending { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CaseSensitiveSearch { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IndentRoleInCSV { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeDescriptionInCSV { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeDimensionsInCSV { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JABGetRoleCSVFromElementHandleResponse
    {
        public bool ElementFound { get; set; }
        public int ElementsSearched { get; set; }
        public string RoleCSV { get; set; }
    }

    public class JABGetRoleCSVFromElementHandleInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJABHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchSubTree { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxRelativeDepth { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchVisibleElements { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlySearchShowingElements { get; set; } = true;
        public string ElementRolesNotToTraverse { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumElementsToSearch { get; set; } = 2000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumChildElementsToSearchPerNode { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IndentRoleInCSV { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeDescriptionInCSV { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeDimensionsInCSV { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectjava;

    public partial class WorkflowManagedActions
    {
        public IaconnectjavaActions Iaconnectjava(string connectionId) => new IaconnectjavaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IaconnectjavaTriggers Iaconnectjava(string connectionId) => new IaconnectjavaTriggers(connectionId);
    }
}