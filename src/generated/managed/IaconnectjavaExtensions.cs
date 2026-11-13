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
        public IBodyWorkflowAction<JabConnectToJavaAccessBridgeResponse, ApiConnectionActionConfiguration> JabConnectToJavaAccessBridge(Expression<Func<JabConnectToJavaAccessBridgeInput>> jabConnectToJavaAccessBridge)
        {
            var __workflow_jabConnectToJavaAccessBridge = WorkflowExpression.Compile(jabConnectToJavaAccessBridge, nameof(jabConnectToJavaAccessBridge), required: true);
            return new DeferredBodyAction<JabConnectToJavaAccessBridgeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABConnectToJavaAccessBridge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabConnectToJavaAccessBridge);
                return new ApiConnectionAction<JabConnectToJavaAccessBridgeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JabDisconnectFromJavaAccessBridge(Expression<Func<JabDisconnectFromJavaAccessBridgeInput>> jabDisconnectFromJavaAccessBridge)
        {
            var __workflow_jabDisconnectFromJavaAccessBridge = WorkflowExpression.Compile(jabDisconnectFromJavaAccessBridge, nameof(jabDisconnectFromJavaAccessBridge), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABDisconnectFromJavaAccessBridge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabDisconnectFromJavaAccessBridge);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetConnectionStatusResponse, ApiConnectionActionConfiguration> JabGetConnectionStatus(Expression<Func<JabGetConnectionStatusInput>> jabGetConnectionStatus)
        {
            var __workflow_jabGetConnectionStatus = WorkflowExpression.Compile(jabGetConnectionStatus, nameof(jabGetConnectionStatus), required: true);
            return new DeferredBodyAction<JabGetConnectionStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetConnectionStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetConnectionStatus);
                return new ApiConnectionAction<JabGetConnectionStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabisJavaWindowResponse, ApiConnectionActionConfiguration> JabisJavaWindow(Expression<Func<JabisJavaWindowInput>> jabisJavaWindow)
        {
            var __workflow_jabisJavaWindow = WorkflowExpression.Compile(jabisJavaWindow, nameof(jabisJavaWindow), required: true);
            return new DeferredBodyAction<JabisJavaWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABIsJavaWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabisJavaWindow);
                return new ApiConnectionAction<JabisJavaWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetWindowsAccessBridgeInfoResponse, ApiConnectionActionConfiguration> JabGetWindowsAccessBridgeInfo(Expression<Func<JabGetWindowsAccessBridgeInfoInput>> jabGetWindowsAccessBridgeInfo)
        {
            var __workflow_jabGetWindowsAccessBridgeInfo = WorkflowExpression.Compile(jabGetWindowsAccessBridgeInfo, nameof(jabGetWindowsAccessBridgeInfo), required: true);
            return new DeferredBodyAction<JabGetWindowsAccessBridgeInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetWindowsAccessBridgeInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetWindowsAccessBridgeInfo);
                return new ApiConnectionAction<JabGetWindowsAccessBridgeInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetUiaElementPropertiesResponse, ApiConnectionActionConfiguration> JabGetUiaElementProperties(Expression<Func<JabGetUiaElementPropertiesInput>> jabGetUiaElementProperties)
        {
            var __workflow_jabGetUiaElementProperties = WorkflowExpression.Compile(jabGetUiaElementProperties, nameof(jabGetUiaElementProperties), required: true);
            return new DeferredBodyAction<JabGetUiaElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetUIAElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetUiaElementProperties);
                return new ApiConnectionAction<JabGetUiaElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetJabElementPropertiesResponse, ApiConnectionActionConfiguration> JabGetJabElementProperties(Expression<Func<JabGetJabElementPropertiesInput>> jabGetJabElementProperties)
        {
            var __workflow_jabGetJabElementProperties = WorkflowExpression.Compile(jabGetJabElementProperties, nameof(jabGetJabElementProperties), required: true);
            return new DeferredBodyAction<JabGetJabElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetJABElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetJabElementProperties);
                return new ApiConnectionAction<JabGetJabElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JabDrawRectangleAroundJabElement(Expression<Func<JabDrawRectangleAroundJabElementInput>> jabDrawRectangleAroundJabElement)
        {
            var __workflow_jabDrawRectangleAroundJabElement = WorkflowExpression.Compile(jabDrawRectangleAroundJabElement, nameof(jabDrawRectangleAroundJabElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABDrawRectangleAroundJABElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabDrawRectangleAroundJabElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabDoesElementExistResponse, ApiConnectionActionConfiguration> JabDoesElementExist(Expression<Func<JabDoesElementExistInput>> jabDoesElementExist)
        {
            var __workflow_jabDoesElementExist = WorkflowExpression.Compile(jabDoesElementExist, nameof(jabDoesElementExist), required: true);
            return new DeferredBodyAction<JabDoesElementExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABDoesElementExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabDoesElementExist);
                return new ApiConnectionAction<JabDoesElementExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabWaitForElementResponse, ApiConnectionActionConfiguration> JabWaitForElement(Expression<Func<JabWaitForElementInput>> jabWaitForElement)
        {
            var __workflow_jabWaitForElement = WorkflowExpression.Compile(jabWaitForElement, nameof(jabWaitForElement), required: true);
            return new DeferredBodyAction<JabWaitForElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABWaitForElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabWaitForElement);
                return new ApiConnectionAction<JabWaitForElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabWaitForElementToNotExistResponse, ApiConnectionActionConfiguration> JabWaitForElementToNotExist(Expression<Func<JabWaitForElementToNotExistInput>> jabWaitForElementToNotExist)
        {
            var __workflow_jabWaitForElementToNotExist = WorkflowExpression.Compile(jabWaitForElementToNotExist, nameof(jabWaitForElementToNotExist), required: true);
            return new DeferredBodyAction<JabWaitForElementToNotExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABWaitForElementToNotExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabWaitForElementToNotExist);
                return new ApiConnectionAction<JabWaitForElementToNotExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetDesktopElementsResponse, ApiConnectionActionConfiguration> JabGetDesktopElements(Expression<Func<JabGetDesktopElementsInput>> jabGetDesktopElements)
        {
            var __workflow_jabGetDesktopElements = WorkflowExpression.Compile(jabGetDesktopElements, nameof(jabGetDesktopElements), required: true);
            return new DeferredBodyAction<JabGetDesktopElementsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetDesktopElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetDesktopElements);
                return new ApiConnectionAction<JabGetDesktopElementsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabDoesDesktopElementExistResponse, ApiConnectionActionConfiguration> JabDoesDesktopElementExist(Expression<Func<JabDoesDesktopElementExistInput>> jabDoesDesktopElementExist)
        {
            var __workflow_jabDoesDesktopElementExist = WorkflowExpression.Compile(jabDoesDesktopElementExist, nameof(jabDoesDesktopElementExist), required: true);
            return new DeferredBodyAction<JabDoesDesktopElementExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABDoesDesktopElementExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabDoesDesktopElementExist);
                return new ApiConnectionAction<JabDoesDesktopElementExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabWaitForDesktopElementResponse, ApiConnectionActionConfiguration> JabWaitForDesktopElement(Expression<Func<JabWaitForDesktopElementInput>> jabWaitForDesktopElement)
        {
            var __workflow_jabWaitForDesktopElement = WorkflowExpression.Compile(jabWaitForDesktopElement, nameof(jabWaitForDesktopElement), required: true);
            return new DeferredBodyAction<JabWaitForDesktopElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABWaitForDesktopElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabWaitForDesktopElement);
                return new ApiConnectionAction<JabWaitForDesktopElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabWaitForDesktopElementToNotExistResponse, ApiConnectionActionConfiguration> JabWaitForDesktopElementToNotExist(Expression<Func<JabWaitForDesktopElementToNotExistInput>> jabWaitForDesktopElementToNotExist)
        {
            var __workflow_jabWaitForDesktopElementToNotExist = WorkflowExpression.Compile(jabWaitForDesktopElementToNotExist, nameof(jabWaitForDesktopElementToNotExist), required: true);
            return new DeferredBodyAction<JabWaitForDesktopElementToNotExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABWaitForDesktopElementToNotExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabWaitForDesktopElementToNotExist);
                return new ApiConnectionAction<JabWaitForDesktopElementToNotExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JabFreeAllJabHandles(Expression<Func<JabFreeAllJabHandlesInput>> jabFreeAllJabHandles)
        {
            var __workflow_jabFreeAllJabHandles = WorkflowExpression.Compile(jabFreeAllJabHandles, nameof(jabFreeAllJabHandles), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABFreeAllJABHandles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabFreeAllJabHandles);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetChildJabElementPropertiesResponse, ApiConnectionActionConfiguration> JabGetChildJabElementProperties(Expression<Func<JabGetChildJabElementPropertiesInput>> jabGetChildJabElementProperties)
        {
            var __workflow_jabGetChildJabElementProperties = WorkflowExpression.Compile(jabGetChildJabElementProperties, nameof(jabGetChildJabElementProperties), required: true);
            return new DeferredBodyAction<JabGetChildJabElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetChildJABElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetChildJabElementProperties);
                return new ApiConnectionAction<JabGetChildJabElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetAllChildJabElementPropertiesResponse, ApiConnectionActionConfiguration> JabGetAllChildJabElementProperties(Expression<Func<JabGetAllChildJabElementPropertiesInput>> jabGetAllChildJabElementProperties)
        {
            var __workflow_jabGetAllChildJabElementProperties = WorkflowExpression.Compile(jabGetAllChildJabElementProperties, nameof(jabGetAllChildJabElementProperties), required: true);
            return new DeferredBodyAction<JabGetAllChildJabElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetAllChildJABElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetAllChildJabElementProperties);
                return new ApiConnectionAction<JabGetAllChildJabElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetParentJabElementPropertiesResponse, ApiConnectionActionConfiguration> JabGetParentJabElementProperties(Expression<Func<JabGetParentJabElementPropertiesInput>> jabGetParentJabElementProperties)
        {
            var __workflow_jabGetParentJabElementProperties = WorkflowExpression.Compile(jabGetParentJabElementProperties, nameof(jabGetParentJabElementProperties), required: true);
            return new DeferredBodyAction<JabGetParentJabElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetParentJABElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetParentJabElementProperties);
                return new ApiConnectionAction<JabGetParentJabElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JabPressElement(Expression<Func<JabPressElementInput>> jabPressElement)
        {
            var __workflow_jabPressElement = WorkflowExpression.Compile(jabPressElement, nameof(jabPressElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABPressElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabPressElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JabPerformActionOnElement(Expression<Func<JabPerformActionOnElementInput>> jabPerformActionOnElement)
        {
            var __workflow_jabPerformActionOnElement = WorkflowExpression.Compile(jabPerformActionOnElement, nameof(jabPerformActionOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABPerformActionOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabPerformActionOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JabGlobalLeftMouseClickOnElement(Expression<Func<JabGlobalLeftMouseClickOnElementInput>> jabGlobalLeftMouseClickOnElement)
        {
            var __workflow_jabGlobalLeftMouseClickOnElement = WorkflowExpression.Compile(jabGlobalLeftMouseClickOnElement, nameof(jabGlobalLeftMouseClickOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalLeftMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGlobalLeftMouseClickOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JabGlobalRightMouseClickOnElement(Expression<Func<JabGlobalRightMouseClickOnElementInput>> jabGlobalRightMouseClickOnElement)
        {
            var __workflow_jabGlobalRightMouseClickOnElement = WorkflowExpression.Compile(jabGlobalRightMouseClickOnElement, nameof(jabGlobalRightMouseClickOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalRightMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGlobalRightMouseClickOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JabGlobalMiddleMouseClickOnElement(Expression<Func<JabGlobalMiddleMouseClickOnElementInput>> jabGlobalMiddleMouseClickOnElement)
        {
            var __workflow_jabGlobalMiddleMouseClickOnElement = WorkflowExpression.Compile(jabGlobalMiddleMouseClickOnElement, nameof(jabGlobalMiddleMouseClickOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalMiddleMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGlobalMiddleMouseClickOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JabGlobalDoubleLeftMouseClickOnElement(Expression<Func<JabGlobalDoubleLeftMouseClickOnElementInput>> jabGlobalDoubleLeftMouseClickOnElement)
        {
            var __workflow_jabGlobalDoubleLeftMouseClickOnElement = WorkflowExpression.Compile(jabGlobalDoubleLeftMouseClickOnElement, nameof(jabGlobalDoubleLeftMouseClickOnElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalDoubleLeftMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGlobalDoubleLeftMouseClickOnElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetActionsForElementResponse, ApiConnectionActionConfiguration> JabGetActionsForElement(Expression<Func<JabGetActionsForElementInput>> jabGetActionsForElement)
        {
            var __workflow_jabGetActionsForElement = WorkflowExpression.Compile(jabGetActionsForElement, nameof(jabGetActionsForElement), required: true);
            return new DeferredBodyAction<JabGetActionsForElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetActionsForElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetActionsForElement);
                return new ApiConnectionAction<JabGetActionsForElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JabFocusElement(Expression<Func<JabFocusElementInput>> jabFocusElement)
        {
            var __workflow_jabFocusElement = WorkflowExpression.Compile(jabFocusElement, nameof(jabFocusElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABFocusElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabFocusElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JabInputPasswordIntoElement(Expression<Func<JabInputPasswordIntoElementInput>> jabInputPasswordIntoElement)
        {
            var __workflow_jabInputPasswordIntoElement = WorkflowExpression.Compile(jabInputPasswordIntoElement, nameof(jabInputPasswordIntoElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABInputPasswordIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabInputPasswordIntoElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JabInputTextIntoElement(Expression<Func<JabInputTextIntoElementInput>> jabInputTextIntoElement)
        {
            var __workflow_jabInputTextIntoElement = WorkflowExpression.Compile(jabInputTextIntoElement, nameof(jabInputTextIntoElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABInputTextIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabInputTextIntoElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetElementTextValueResponse, ApiConnectionActionConfiguration> JabGetElementTextValue(Expression<Func<JabGetElementTextValueInput>> jabGetElementTextValue)
        {
            var __workflow_jabGetElementTextValue = WorkflowExpression.Compile(jabGetElementTextValue, nameof(jabGetElementTextValue), required: true);
            return new DeferredBodyAction<JabGetElementTextValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetElementTextValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetElementTextValue);
                return new ApiConnectionAction<JabGetElementTextValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetElementValueResponse, ApiConnectionActionConfiguration> JabGetElementValue(Expression<Func<JabGetElementValueInput>> jabGetElementValue)
        {
            var __workflow_jabGetElementValue = WorkflowExpression.Compile(jabGetElementValue, nameof(jabGetElementValue), required: true);
            return new DeferredBodyAction<JabGetElementValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetElementValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetElementValue);
                return new ApiConnectionAction<JabGetElementValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JabCheckElement(Expression<Func<JabCheckElementInput>> jabCheckElement)
        {
            var __workflow_jabCheckElement = WorkflowExpression.Compile(jabCheckElement, nameof(jabCheckElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABCheckElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabCheckElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetElementPropertiesAsListResponse, ApiConnectionActionConfiguration> JabGetElementPropertiesAsList(Expression<Func<JabGetElementPropertiesAsListInput>> jabGetElementPropertiesAsList)
        {
            var __workflow_jabGetElementPropertiesAsList = WorkflowExpression.Compile(jabGetElementPropertiesAsList, nameof(jabGetElementPropertiesAsList), required: true);
            return new DeferredBodyAction<JabGetElementPropertiesAsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetElementPropertiesAsList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetElementPropertiesAsList);
                return new ApiConnectionAction<JabGetElementPropertiesAsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JabGlobalInputPasswordIntoElement(Expression<Func<JabGlobalInputPasswordIntoElementInput>> jabGlobalInputPasswordIntoElement)
        {
            var __workflow_jabGlobalInputPasswordIntoElement = WorkflowExpression.Compile(jabGlobalInputPasswordIntoElement, nameof(jabGlobalInputPasswordIntoElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalInputPasswordIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGlobalInputPasswordIntoElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JabGlobalInputTextIntoElement(Expression<Func<JabGlobalInputTextIntoElementInput>> jabGlobalInputTextIntoElement)
        {
            var __workflow_jabGlobalInputTextIntoElement = WorkflowExpression.Compile(jabGlobalInputTextIntoElement, nameof(jabGlobalInputTextIntoElement), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalInputTextIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGlobalInputTextIntoElement);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetSelectionElementItemsResponse, ApiConnectionActionConfiguration> JabGetSelectionElementItems(Expression<Func<JabGetSelectionElementItemsInput>> jabGetSelectionElementItems)
        {
            var __workflow_jabGetSelectionElementItems = WorkflowExpression.Compile(jabGetSelectionElementItems, nameof(jabGetSelectionElementItems), required: true);
            return new DeferredBodyAction<JabGetSelectionElementItemsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetSelectionElementItems";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetSelectionElementItems);
                return new ApiConnectionAction<JabGetSelectionElementItemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JabSetSelectionByIndex(Expression<Func<JabSetSelectionByIndexInput>> jabSetSelectionByIndex)
        {
            var __workflow_jabSetSelectionByIndex = WorkflowExpression.Compile(jabSetSelectionByIndex, nameof(jabSetSelectionByIndex), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABSetSelectionByIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabSetSelectionByIndex);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JabSetSelectionByName(Expression<Func<JabSetSelectionByNameInput>> jabSetSelectionByName)
        {
            var __workflow_jabSetSelectionByName = WorkflowExpression.Compile(jabSetSelectionByName, nameof(jabSetSelectionByName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABSetSelectionByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabSetSelectionByName);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JabExpandSelection(Expression<Func<JabExpandSelectionInput>> jabExpandSelection)
        {
            var __workflow_jabExpandSelection = WorkflowExpression.Compile(jabExpandSelection, nameof(jabExpandSelection), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABExpandSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabExpandSelection);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetSelectionStateByIndexResponse, ApiConnectionActionConfiguration> JabGetSelectionStateByIndex(Expression<Func<JabGetSelectionStateByIndexInput>> jabGetSelectionStateByIndex)
        {
            var __workflow_jabGetSelectionStateByIndex = WorkflowExpression.Compile(jabGetSelectionStateByIndex, nameof(jabGetSelectionStateByIndex), required: true);
            return new DeferredBodyAction<JabGetSelectionStateByIndexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetSelectionStateByIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetSelectionStateByIndex);
                return new ApiConnectionAction<JabGetSelectionStateByIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetSelectionStateByNameResponse, ApiConnectionActionConfiguration> JabGetSelectionStateByName(Expression<Func<JabGetSelectionStateByNameInput>> jabGetSelectionStateByName)
        {
            var __workflow_jabGetSelectionStateByName = WorkflowExpression.Compile(jabGetSelectionStateByName, nameof(jabGetSelectionStateByName), required: true);
            return new DeferredBodyAction<JabGetSelectionStateByNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetSelectionStateByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetSelectionStateByName);
                return new ApiConnectionAction<JabGetSelectionStateByNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetTablePropertiesResponse, ApiConnectionActionConfiguration> JabGetTableProperties(Expression<Func<JabGetTablePropertiesInput>> jabGetTableProperties)
        {
            var __workflow_jabGetTableProperties = WorkflowExpression.Compile(jabGetTableProperties, nameof(jabGetTableProperties), required: true);
            return new DeferredBodyAction<JabGetTablePropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetTableProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetTableProperties);
                return new ApiConnectionAction<JabGetTablePropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetTableCellPropertiesResponse, ApiConnectionActionConfiguration> JabGetTableCellProperties(Expression<Func<JabGetTableCellPropertiesInput>> jabGetTableCellProperties)
        {
            var __workflow_jabGetTableCellProperties = WorkflowExpression.Compile(jabGetTableCellProperties, nameof(jabGetTableCellProperties), required: true);
            return new DeferredBodyAction<JabGetTableCellPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetTableCellProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetTableCellProperties);
                return new ApiConnectionAction<JabGetTableCellPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetTableContentsResponse, ApiConnectionActionConfiguration> JabGetTableContents(Expression<Func<JabGetTableContentsInput>> jabGetTableContents)
        {
            var __workflow_jabGetTableContents = WorkflowExpression.Compile(jabGetTableContents, nameof(jabGetTableContents), required: true);
            return new DeferredBodyAction<JabGetTableContentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetTableContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetTableContents);
                return new ApiConnectionAction<JabGetTableContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabisTableCellVisibleOnscreenResponse, ApiConnectionActionConfiguration> JabisTableCellVisibleOnscreen(Expression<Func<JabisTableCellVisibleOnscreenInput>> jabisTableCellVisibleOnscreen)
        {
            var __workflow_jabisTableCellVisibleOnscreen = WorkflowExpression.Compile(jabisTableCellVisibleOnscreen, nameof(jabisTableCellVisibleOnscreen), required: true);
            return new DeferredBodyAction<JabisTableCellVisibleOnscreenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABIsTableCellVisibleOnscreen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabisTableCellVisibleOnscreen);
                return new ApiConnectionAction<JabisTableCellVisibleOnscreenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabIsJabHandleSameObjectResponse, ApiConnectionActionConfiguration> JabIsJabHandleSameObject(Expression<Func<JabIsJabHandleSameObjectInput>> jabIsJabHandleSameObject)
        {
            var __workflow_jabIsJabHandleSameObject = WorkflowExpression.Compile(jabIsJabHandleSameObject, nameof(jabIsJabHandleSameObject), required: true);
            return new DeferredBodyAction<JabIsJabHandleSameObjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABIsJABHandleSameObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabIsJabHandleSameObject);
                return new ApiConnectionAction<JabIsJabHandleSameObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetVisibleBoundingRectangleOfElementOnscreenResponse, ApiConnectionActionConfiguration> JabGetVisibleBoundingRectangleOfElementOnscreen(Expression<Func<JabGetVisibleBoundingRectangleOfElementOnscreenInput>> jabGetVisibleBoundingRectangleOfElementOnscreen)
        {
            var __workflow_jabGetVisibleBoundingRectangleOfElementOnscreen = WorkflowExpression.Compile(jabGetVisibleBoundingRectangleOfElementOnscreen, nameof(jabGetVisibleBoundingRectangleOfElementOnscreen), required: true);
            return new DeferredBodyAction<JabGetVisibleBoundingRectangleOfElementOnscreenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetVisibleBoundingRectangleOfElementOnscreen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetVisibleBoundingRectangleOfElementOnscreen);
                return new ApiConnectionAction<JabGetVisibleBoundingRectangleOfElementOnscreenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabCreateHandleForJabElementAtScreenCoordinateResponse, ApiConnectionActionConfiguration> JabCreateHandleForJabElementAtScreenCoordinate(Expression<Func<JabCreateHandleForJabElementAtScreenCoordinateInput>> jabCreateHandleForJabElementAtScreenCoordinate)
        {
            var __workflow_jabCreateHandleForJabElementAtScreenCoordinate = WorkflowExpression.Compile(jabCreateHandleForJabElementAtScreenCoordinate, nameof(jabCreateHandleForJabElementAtScreenCoordinate), required: true);
            return new DeferredBodyAction<JabCreateHandleForJabElementAtScreenCoordinateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABCreateHandleForJABElementAtScreenCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabCreateHandleForJabElementAtScreenCoordinate);
                return new ApiConnectionAction<JabCreateHandleForJabElementAtScreenCoordinateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetTableCellAtScreenCoordinateResponse, ApiConnectionActionConfiguration> JabGetTableCellAtScreenCoordinate(Expression<Func<JabGetTableCellAtScreenCoordinateInput>> jabGetTableCellAtScreenCoordinate)
        {
            var __workflow_jabGetTableCellAtScreenCoordinate = WorkflowExpression.Compile(jabGetTableCellAtScreenCoordinate, nameof(jabGetTableCellAtScreenCoordinate), required: true);
            return new DeferredBodyAction<JabGetTableCellAtScreenCoordinateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetTableCellAtScreenCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetTableCellAtScreenCoordinate);
                return new ApiConnectionAction<JabGetTableCellAtScreenCoordinateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetMultipleParentJabElementPropertiesResponse, ApiConnectionActionConfiguration> JabGetMultipleParentJabElementProperties(Expression<Func<JabGetMultipleParentJabElementPropertiesInput>> jabGetMultipleParentJabElementProperties)
        {
            var __workflow_jabGetMultipleParentJabElementProperties = WorkflowExpression.Compile(jabGetMultipleParentJabElementProperties, nameof(jabGetMultipleParentJabElementProperties), required: true);
            return new DeferredBodyAction<JabGetMultipleParentJabElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetMultipleParentJABElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetMultipleParentJabElementProperties);
                return new ApiConnectionAction<JabGetMultipleParentJabElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JabGlobalMouseClickOnTableCell(Expression<Func<JabGlobalMouseClickOnTableCellInput>> jabGlobalMouseClickOnTableCell)
        {
            var __workflow_jabGlobalMouseClickOnTableCell = WorkflowExpression.Compile(jabGlobalMouseClickOnTableCell, nameof(jabGlobalMouseClickOnTableCell), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalMouseClickOnTableCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGlobalMouseClickOnTableCell);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetRoleCsvFromElementSearchResponse, ApiConnectionActionConfiguration> JabGetRoleCsvFromElementSearch(Expression<Func<JabGetRoleCsvFromElementSearchInput>> jabGetRoleCsvFromElementSearch)
        {
            var __workflow_jabGetRoleCsvFromElementSearch = WorkflowExpression.Compile(jabGetRoleCsvFromElementSearch, nameof(jabGetRoleCsvFromElementSearch), required: true);
            return new DeferredBodyAction<JabGetRoleCsvFromElementSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetRoleCSVFromElementSearch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetRoleCsvFromElementSearch);
                return new ApiConnectionAction<JabGetRoleCsvFromElementSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JabGetRoleCsvFromElementHandleResponse, ApiConnectionActionConfiguration> JabGetRoleCsvFromElementHandle(Expression<Func<JabGetRoleCsvFromElementHandleInput>> jabGetRoleCsvFromElementHandle)
        {
            var __workflow_jabGetRoleCsvFromElementHandle = WorkflowExpression.Compile(jabGetRoleCsvFromElementHandle, nameof(jabGetRoleCsvFromElementHandle), required: true);
            return new DeferredBodyAction<JabGetRoleCsvFromElementHandleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetRoleCSVFromElementHandle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_jabGetRoleCsvFromElementHandle);
                return new ApiConnectionAction<JabGetRoleCsvFromElementHandleResponse>(callPayload);
            });
        }
    }

    public class IaconnectjavaTriggers([ConnectionName] string connectionId)
    {
    }

    public class JabConnectToJavaAccessBridgeResponse
    {
        [JsonProperty("LoadedWindowsAccessBridgeDLL")]
        public string LoadedWindowsAccessBridgeDll { get; set; }
    }

    public class JabConnectToJavaAccessBridgeInput
    {
        [JsonProperty("WindowsAccessBridgeDLLSearchFolder")]
        public string WindowsAccessBridgeDllSearchFolder { get; set; }
        public string IAJavaAccessBridgePath { get; set; }

        [JsonProperty("Is64BitJABDLL", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Is64BitJabdll { get; set; } = false;

        [JsonProperty("UseCOMFor64BitJABDLL", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseComFor64BitJabdll { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EnableJavaAccessBridge { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string AccessibilityFilepath { get; set; } = "%USERPROFILE%\\.accessibility.properties";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? CommandTimeoutInSeconds { get; set; } = 20;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JabDisconnectFromJavaAccessBridgeInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DisableJavaAccessBridge { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string AccessibilityFilepath { get; set; } = "%USERPROFILE%\\.accessibility.properties";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JabGetConnectionStatusResponse
    {
        public bool Connected { get; set; }
        public string ConnectionType { get; set; }

        [JsonProperty("IsWAB64bit")]
        public bool IsWab64bit { get; set; }
        public string ConnectionError { get; set; }

        [JsonProperty("LoadedIAJABDLL")]
        public string LoadedIajabdll { get; set; }

        [JsonProperty("LoadedWABDLL")]
        public string LoadedWabdll { get; set; }

        [JsonProperty("WABVersion")]
        public string WabVersion { get; set; }
    }

    public class JabGetConnectionStatusInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JabisJavaWindowResponse
    {
        public bool IsJavaWindow { get; set; }
    }

    public class JabisJavaWindowInput
    {
        public JabisJavaWindowInput(int parentWindowHandle)
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
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JabGetWindowsAccessBridgeInfoResponse
    {
        public string JavaClassVersion { get; set; }

        [JsonProperty("JavaDLLVersion")]
        public string JavaDllVersion { get; set; }

        [JsonProperty("WinDLLVersion")]
        public string WinDllVersion { get; set; }
        public string VMVersion { get; set; }
    }

    public class JabGetWindowsAccessBridgeInfoInput
    {
        public JabGetWindowsAccessBridgeInfoInput(int vmid)
        {
            this.Vmid = vmid;
        }

        [JsonProperty("VMID", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Vmid { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JabGetUiaElementPropertiesResponse
    {
        [JsonProperty("ElementJABHandle")]
        public int ElementJabHandle { get; set; }

        [JsonProperty("ElementVMID")]
        public int ElementVmid { get; set; }
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

    public class JabGetUiaElementPropertiesInput
    {
        public JabGetUiaElementPropertiesInput(int parentWindowHandle)
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
        public int? MaxStringLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JabGetJabElementPropertiesResponse
    {
        [JsonProperty("ElementJABHandle")]
        public int ElementJabHandle { get; set; }

        [JsonProperty("ElementVMID")]
        public int ElementVmid { get; set; }
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

    public class JabGetJabElementPropertiesInput
    {
        public JabGetJabElementPropertiesInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabDrawRectangleAroundJabElementInput
    {
        public JabDrawRectangleAroundJabElementInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabDoesElementExistResponse
    {
        public bool ElementExists { get; set; }

        [JsonProperty("ElementJABHandle")]
        public int ElementJabHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementDescription { get; set; }
        public string ElementRole { get; set; }
    }

    public class JabDoesElementExistInput
    {
        public JabDoesElementExistInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabWaitForElementResponse
    {
        public bool ElementExists { get; set; }

        [JsonProperty("ElementJABHandle")]
        public int ElementJabHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementDescription { get; set; }
        public string ElementRole { get; set; }
    }

    public class JabWaitForElementInput
    {
        public JabWaitForElementInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabWaitForElementToNotExistResponse
    {
        public bool ElementExistsBeforeWait { get; set; }
        public bool ElementExistsAfterWait { get; set; }
    }

    public class JabWaitForElementToNotExistInput
    {
        public JabWaitForElementToNotExistInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabGetDesktopElementsResponse
    {
        public int NumberOfElementsFound { get; set; }
        public int NumberOfElementsReturned { get; set; }

        [JsonProperty("JavaDesktopElementsJSON")]
        public string JavaDesktopElementsJson { get; set; }
    }

    public class JabGetDesktopElementsInput
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

    public class JabDoesDesktopElementExistResponse
    {
        public bool ElementExists { get; set; }

        [JsonProperty("ElementJABHandle")]
        public int ElementJabHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementDescription { get; set; }
        public string ElementRole { get; set; }
    }

    public class JabDoesDesktopElementExistInput
    {
        [JsonProperty("SearchUIAElementName")]
        public string SearchUiaElementName { get; set; }

        [JsonProperty("SearchUIAElementClassName")]
        public string SearchUiaElementClassName { get; set; }

        [JsonProperty("SearchUIAElementLocalizedControlType")]
        public string SearchUiaElementLocalizedControlType { get; set; }

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

    public class JabWaitForDesktopElementResponse
    {
        public bool ElementExists { get; set; }

        [JsonProperty("ElementJABHandle")]
        public int ElementJabHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementDescription { get; set; }
        public string ElementRole { get; set; }
    }

    public class JabWaitForDesktopElementInput
    {
        [JsonProperty("SearchUIAElementName")]
        public string SearchUiaElementName { get; set; }

        [JsonProperty("SearchUIAElementClassName")]
        public string SearchUiaElementClassName { get; set; }

        [JsonProperty("SearchUIAElementLocalizedControlType")]
        public string SearchUiaElementLocalizedControlType { get; set; }

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

    public class JabWaitForDesktopElementToNotExistResponse
    {
        public bool ElementExistsBeforeWait { get; set; }
        public bool ElementExistsAfterWait { get; set; }
    }

    public class JabWaitForDesktopElementToNotExistInput
    {
        [JsonProperty("SearchUIAElementName")]
        public string SearchUiaElementName { get; set; }

        [JsonProperty("SearchUIAElementClassName")]
        public string SearchUiaElementClassName { get; set; }

        [JsonProperty("SearchUIAElementLocalizedControlType")]
        public string SearchUiaElementLocalizedControlType { get; set; }

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

    public class JabFreeAllJabHandlesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JabGetChildJabElementPropertiesResponse
    {
        [JsonProperty("ElementJABHandle")]
        public int ElementJabHandle { get; set; }

        [JsonProperty("ElementVMID")]
        public int ElementVmid { get; set; }
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

    public class JabGetChildJabElementPropertiesInput
    {
        public JabGetChildJabElementPropertiesInput(int searchElementJabHandle)
        {
            this.SearchElementJabHandle = searchElementJabHandle;
        }

        [JsonProperty("SearchElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchElementJabHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchChildIndex { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxStringLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JabGetAllChildJabElementPropertiesResponse
    {
        public int NumberOfChildElementsReturned { get; set; }
        public bool MoreElementsAvailableAtCurrentDepth { get; set; }
        public bool MoreElementsAvailableAtLowerDepths { get; set; }
        public bool MoreElementsDeeperThanMaxDepth { get; set; }

        [JsonProperty("JavaChildElementsJSON")]
        public string JavaChildElementsJson { get; set; }
    }

    public class JabGetAllChildJabElementPropertiesInput
    {
        public JabGetAllChildJabElementPropertiesInput(int searchElementJabHandle)
        {
            this.SearchElementJabHandle = searchElementJabHandle;
        }

        [JsonProperty("SearchElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchElementJabHandle { get; set; }

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

    public class JabGetParentJabElementPropertiesResponse
    {
        [JsonProperty("ElementJABHandle")]
        public int ElementJabHandle { get; set; }

        [JsonProperty("ElementVMID")]
        public int ElementVmid { get; set; }
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

    public class JabGetParentJabElementPropertiesInput
    {
        public JabGetParentJabElementPropertiesInput(int searchElementJabHandle)
        {
            this.SearchElementJabHandle = searchElementJabHandle;
        }

        [JsonProperty("SearchElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchElementJabHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxStringLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JabPressElementInput
    {
        public JabPressElementInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabPerformActionOnElementInput
    {
        public JabPerformActionOnElementInput(int searchParentElementJabHandle, string action)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
            this.Action = action;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabGlobalLeftMouseClickOnElementInput
    {
        public JabGlobalLeftMouseClickOnElementInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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
        public JabGlobalLeftMouseClickOnElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? NumberOfTimesToClickElement { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SecondsToWaitBetweenClicks { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JabGlobalLeftMouseClickOnElementInputOffsetRelativeToType
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

    public class JabGlobalRightMouseClickOnElementInput
    {
        public JabGlobalRightMouseClickOnElementInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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
        public JabGlobalRightMouseClickOnElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JabGlobalRightMouseClickOnElementInputOffsetRelativeToType
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

    public class JabGlobalMiddleMouseClickOnElementInput
    {
        public JabGlobalMiddleMouseClickOnElementInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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
        public JabGlobalMiddleMouseClickOnElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JabGlobalMiddleMouseClickOnElementInputOffsetRelativeToType
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

    public class JabGlobalDoubleLeftMouseClickOnElementInput
    {
        public JabGlobalDoubleLeftMouseClickOnElementInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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
        public JabGlobalDoubleLeftMouseClickOnElementInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DelayInMilliseconds { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JabGlobalDoubleLeftMouseClickOnElementInputOffsetRelativeToType
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

    public class JabGetActionsForElementResponse
    {
        public string AccessibleActions { get; set; }
    }

    public class JabGetActionsForElementInput
    {
        public JabGetActionsForElementInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabFocusElementInput
    {
        public JabFocusElementInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabInputPasswordIntoElementInput
    {
        public JabInputPasswordIntoElementInput(int searchParentElementJabHandle, string passwordToInput)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
            this.PasswordToInput = passwordToInput;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabInputTextIntoElementInput
    {
        public JabInputTextIntoElementInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabGetElementTextValueResponse
    {
        public string ElementTextValue { get; set; }
    }

    public class JabGetElementTextValueInput
    {
        public JabGetElementTextValueInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabGetElementValueResponse
    {
        public string ElementCurrentValue { get; set; }
        public string ElementMaximumValue { get; set; }
        public string ElementMinimumValue { get; set; }
    }

    public class JabGetElementValueInput
    {
        public JabGetElementValueInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabCheckElementInput
    {
        public JabCheckElementInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabGetElementPropertiesAsListResponse
    {
        public int NumberOfElementsFound { get; set; }
        public int NumberOfElementsReturned { get; set; }

        [JsonProperty("JABElementPropertiesJSON")]
        public string JabElementPropertiesJson { get; set; }
    }

    public class JabGetElementPropertiesAsListInput
    {
        public JabGetElementPropertiesAsListInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabGlobalInputPasswordIntoElementInput
    {
        public JabGlobalInputPasswordIntoElementInput(int searchParentElementJabHandle, string passwordToInput)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
            this.PasswordToInput = passwordToInput;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabGlobalInputTextIntoElementInput
    {
        public JabGlobalInputTextIntoElementInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabGetSelectionElementItemsResponse
    {
        public int NumberOfSelectedItems { get; set; }
        public string AccessibleSelection1Name { get; set; }
        public int AccessibleSelection1IndexInParent { get; set; }

        [JsonProperty("JABSelectionSelectedItemsJSON")]
        public string JabSelectionSelectedItemsJson { get; set; }

        [JsonProperty("JABSelectionListItemsJSON")]
        public string JabSelectionListItemsJson { get; set; }
    }

    public class JabGetSelectionElementItemsInput
    {
        public JabGetSelectionElementItemsInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabSetSelectionByIndexInput
    {
        public JabSetSelectionByIndexInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabSetSelectionByNameInput
    {
        public JabSetSelectionByNameInput(int searchParentElementJabHandle, string itemName)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
            this.ItemName = itemName;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabExpandSelectionInput
    {
        public JabExpandSelectionInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabGetSelectionStateByIndexResponse
    {
        public bool IndexIsSelected { get; set; }
    }

    public class JabGetSelectionStateByIndexInput
    {
        public JabGetSelectionStateByIndexInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabGetSelectionStateByNameResponse
    {
        public bool NameIsSelected { get; set; }
    }

    public class JabGetSelectionStateByNameInput
    {
        public JabGetSelectionStateByNameInput(int searchParentElementJabHandle, string itemName)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
            this.ItemName = itemName;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabGetTablePropertiesResponse
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

    public class JabGetTablePropertiesInput
    {
        public JabGetTablePropertiesInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabGetTableCellPropertiesResponse
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

        [JsonProperty("CellJABHandle")]
        public int CellJabHandle { get; set; }
    }

    public class JabGetTableCellPropertiesInput
    {
        public JabGetTableCellPropertiesInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

        [JsonProperty("ReturnJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnJabHandle { get; set; } = false;

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

    public class JabGetTableContentsResponse
    {
        public int NumberOfRowsInTable { get; set; }
        public int NumberOfColumnsInTable { get; set; }
        public int NumberOfSelectedRows { get; set; }
        public int NumberOfSelectedColumns { get; set; }
        public int NumberOfRowsReturned { get; set; }
        public int NumberOfColumnsReturned { get; set; }

        [JsonProperty("TableContentsJSON")]
        public string TableContentsJson { get; set; }
    }

    public class JabGetTableContentsInput
    {
        public JabGetTableContentsInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabisTableCellVisibleOnscreenResponse
    {
        public bool CellOnScreen { get; set; }
        public bool ResultIsCertain { get; set; }
        public string OffscreenDirection { get; set; }
    }

    public class JabisTableCellVisibleOnscreenInput
    {
        public JabisTableCellVisibleOnscreenInput(int searchParentElementJabHandle, int cellRowIndex, int cellColumnIndex)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
            this.CellRowIndex = cellRowIndex;
            this.CellColumnIndex = cellColumnIndex;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

    public class JabIsJabHandleSameObjectResponse
    {
        public bool SameObject { get; set; }
    }

    public class JabIsJabHandleSameObjectInput
    {
        public JabIsJabHandleSameObjectInput(int element1JabHandle, int element2JabHandle)
        {
            this.Element1JabHandle = element1JabHandle;
            this.Element2JabHandle = element2JabHandle;
        }

        [JsonProperty("Element1JABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Element1JabHandle { get; set; }

        [JsonProperty("Element2JABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Element2JabHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JabGetVisibleBoundingRectangleOfElementOnscreenResponse
    {
        public int ElementVisibleRectangleLeft { get; set; }
        public int ElementVisibleRectangleTop { get; set; }
        public int ElementVisibleRectangleRight { get; set; }
        public int ElementVisibleRectangleBottom { get; set; }
        public int ElementVisibleRectangleWidth { get; set; }
        public int ElementVisibleRectangleHeight { get; set; }
    }

    public class JabGetVisibleBoundingRectangleOfElementOnscreenInput
    {
        public JabGetVisibleBoundingRectangleOfElementOnscreenInput(int elementJabHandle)
        {
            this.ElementJabHandle = elementJabHandle;
        }

        [JsonProperty("ElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ElementJabHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxParentsToProcess { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ParentElementRolesToConsider { get; set; } = "Panel,Viewport,Layered pane,Root pane";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DrawRectangle { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JabCreateHandleForJabElementAtScreenCoordinateResponse
    {
        [JsonProperty("LocatedElementJABHandle")]
        public int LocatedElementJabHandle { get; set; }
    }

    public class JabCreateHandleForJabElementAtScreenCoordinateInput
    {
        public JabCreateHandleForJabElementAtScreenCoordinateInput(int parentElementJabHandle, int screenX, int screenY)
        {
            this.ParentElementJabHandle = parentElementJabHandle;
            this.ScreenX = screenX;
            this.ScreenY = screenY;
        }

        [JsonProperty("ParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ParentElementJabHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ScreenX { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ScreenY { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JabGetTableCellAtScreenCoordinateResponse
    {
        public int CellIndexInParent { get; set; }
        public int CellRowIndex { get; set; }
        public int CellColumnIndex { get; set; }

        [JsonProperty("CellJABHandle")]
        public int CellJabHandle { get; set; }
    }

    public class JabGetTableCellAtScreenCoordinateInput
    {
        public JabGetTableCellAtScreenCoordinateInput(int tableElementJabHandle, int screenX, int screenY)
        {
            this.TableElementJabHandle = tableElementJabHandle;
            this.ScreenX = screenX;
            this.ScreenY = screenY;
        }

        [JsonProperty("TableElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int TableElementJabHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ScreenX { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ScreenY { get; set; }

        [JsonProperty("ReturnJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnJabHandle { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JabGetMultipleParentJabElementPropertiesResponse
    {
        [JsonProperty("JavaParentElementsJSON")]
        public string JavaParentElementsJson { get; set; }
        public int NumberOfParentElementsReturned { get; set; }
    }

    public class JabGetMultipleParentJabElementPropertiesInput
    {
        public JabGetMultipleParentJabElementPropertiesInput(int searchElementJabHandle)
        {
            this.SearchElementJabHandle = searchElementJabHandle;
        }

        [JsonProperty("SearchElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchElementJabHandle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxStringLength { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxParentsToProcess { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JabGlobalMouseClickOnTableCellInput
    {
        public JabGlobalMouseClickOnTableCellInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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
        public JabGlobalMouseClickOnTableCellInputOffsetRelativeToType? OffsetRelativeTo { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DelayInMilliseconds { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum JabGlobalMouseClickOnTableCellInputOffsetRelativeToType
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

    public class JabGetRoleCsvFromElementSearchResponse
    {
        public bool ElementFound { get; set; }
        public int ElementsSearched { get; set; }

        [JsonProperty("RoleCSV")]
        public string RoleCsv { get; set; }
    }

    public class JabGetRoleCsvFromElementSearchInput
    {
        public JabGetRoleCsvFromElementSearchInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

        [JsonProperty("SearchElementJABName")]
        public string SearchElementJabName { get; set; }

        [JsonProperty("SearchElementJABDescription")]
        public string SearchElementJabDescription { get; set; }

        [JsonProperty("SearchElementJABRole")]
        public string SearchElementJabRole { get; set; }

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

        [JsonProperty("IndentRoleInCSV", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IndentRoleInCsv { get; set; } = true;

        [JsonProperty("IncludeDescriptionInCSV", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeDescriptionInCsv { get; set; } = true;

        [JsonProperty("IncludeDimensionsInCSV", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeDimensionsInCsv { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class JabGetRoleCsvFromElementHandleResponse
    {
        public bool ElementFound { get; set; }
        public int ElementsSearched { get; set; }

        [JsonProperty("RoleCSV")]
        public string RoleCsv { get; set; }
    }

    public class JabGetRoleCsvFromElementHandleInput
    {
        public JabGetRoleCsvFromElementHandleInput(int searchParentElementJabHandle)
        {
            this.SearchParentElementJabHandle = searchParentElementJabHandle;
        }

        [JsonProperty("SearchParentElementJABHandle", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SearchParentElementJabHandle { get; set; }

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

        [JsonProperty("IndentRoleInCSV", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IndentRoleInCsv { get; set; } = true;

        [JsonProperty("IncludeDescriptionInCSV", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeDescriptionInCsv { get; set; } = true;

        [JsonProperty("IncludeDimensionsInCSV", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeDimensionsInCsv { get; set; } = true;

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