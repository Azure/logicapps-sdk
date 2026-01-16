//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectuiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIADoesTopLevelWindowExistResponse> UIADoesTopLevelWindowExist(Expression<Func<string>> uIADoesTopLevelWindowExistWorkflow, Expression<Func<string>> uIADoesTopLevelWindowExistSearchClassName = null, Expression<Func<string>> uIADoesTopLevelWindowExistSearchWindowTitle = null, Expression<Func<int>> uIADoesTopLevelWindowExistSearchProcessId = null, Expression<Func<int>> uIADoesTopLevelWindowExistMatchIndex = null, Expression<Func<string>> uIADoesTopLevelWindowExistSearchFilter = null)
        {
            var apiCallPath = "/UIAControl/DoesTopLevelWindowExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIADoesTopLevelWindowExist = new JObject();
            var uIADoesTopLevelWindowExistpropCount = 0;
            if (uIADoesTopLevelWindowExistSearchClassName != null)
            {
                uIADoesTopLevelWindowExist["SearchClassName"] = ExpressionConverter.ConvertO(uIADoesTopLevelWindowExistSearchClassName);
                uIADoesTopLevelWindowExistpropCount++;
            }

            if (uIADoesTopLevelWindowExistSearchWindowTitle != null)
            {
                uIADoesTopLevelWindowExist["SearchWindowTitle"] = ExpressionConverter.ConvertO(uIADoesTopLevelWindowExistSearchWindowTitle);
                uIADoesTopLevelWindowExistpropCount++;
            }

            if (uIADoesTopLevelWindowExistSearchProcessId != null)
            {
                uIADoesTopLevelWindowExist["SearchProcessId"] = ExpressionConverter.ConvertO(uIADoesTopLevelWindowExistSearchProcessId);
                uIADoesTopLevelWindowExistpropCount++;
            }

            if (uIADoesTopLevelWindowExistMatchIndex != null)
            {
                uIADoesTopLevelWindowExist["MatchIndex"] = ExpressionConverter.ConvertO(uIADoesTopLevelWindowExistMatchIndex);
                uIADoesTopLevelWindowExistpropCount++;
            }

            if (uIADoesTopLevelWindowExistSearchFilter != null)
            {
                uIADoesTopLevelWindowExist["SearchFilter"] = ExpressionConverter.ConvertO(uIADoesTopLevelWindowExistSearchFilter);
                uIADoesTopLevelWindowExistpropCount++;
            }

            uIADoesTopLevelWindowExistpropCount++;
            uIADoesTopLevelWindowExist["Workflow"] = ExpressionConverter.ConvertO(uIADoesTopLevelWindowExistWorkflow);
            if (uIADoesTopLevelWindowExistpropCount > 0)
            {
                callPayload.Body = uIADoesTopLevelWindowExist;
            }

            return new ApiConnectionAction<UIADoesTopLevelWindowExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForTopLevelWindowResponse> UIAGetHandleForTopLevelWindow(Expression<Func<string>> uIAGetHandleForTopLevelWindowWorkflow, Expression<Func<string>> uIAGetHandleForTopLevelWindowSearchClassName = null, Expression<Func<string>> uIAGetHandleForTopLevelWindowSearchWindowTitle = null, Expression<Func<int>> uIAGetHandleForTopLevelWindowSearchProcessId = null, Expression<Func<int>> uIAGetHandleForTopLevelWindowMatchIndex = null, Expression<Func<string>> uIAGetHandleForTopLevelWindowSearchFilter = null, Expression<Func<string>> uIAGetHandleForTopLevelWindowSortByColumn = null, Expression<Func<bool>> uIAGetHandleForTopLevelWindowMatchIndexAscending = null)
        {
            var apiCallPath = "/UIAControl/GetHandleForTopLevelWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetHandleForTopLevelWindow = new JObject();
            var uIAGetHandleForTopLevelWindowpropCount = 0;
            if (uIAGetHandleForTopLevelWindowSearchClassName != null)
            {
                uIAGetHandleForTopLevelWindow["SearchClassName"] = ExpressionConverter.ConvertO(uIAGetHandleForTopLevelWindowSearchClassName);
                uIAGetHandleForTopLevelWindowpropCount++;
            }

            if (uIAGetHandleForTopLevelWindowSearchWindowTitle != null)
            {
                uIAGetHandleForTopLevelWindow["SearchWindowTitle"] = ExpressionConverter.ConvertO(uIAGetHandleForTopLevelWindowSearchWindowTitle);
                uIAGetHandleForTopLevelWindowpropCount++;
            }

            if (uIAGetHandleForTopLevelWindowSearchProcessId != null)
            {
                uIAGetHandleForTopLevelWindow["SearchProcessId"] = ExpressionConverter.ConvertO(uIAGetHandleForTopLevelWindowSearchProcessId);
                uIAGetHandleForTopLevelWindowpropCount++;
            }

            if (uIAGetHandleForTopLevelWindowMatchIndex != null)
            {
                uIAGetHandleForTopLevelWindow["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetHandleForTopLevelWindowMatchIndex);
                uIAGetHandleForTopLevelWindowpropCount++;
            }

            if (uIAGetHandleForTopLevelWindowSearchFilter != null)
            {
                uIAGetHandleForTopLevelWindow["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetHandleForTopLevelWindowSearchFilter);
                uIAGetHandleForTopLevelWindowpropCount++;
            }

            if (uIAGetHandleForTopLevelWindowSortByColumn != null)
            {
                uIAGetHandleForTopLevelWindow["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetHandleForTopLevelWindowSortByColumn);
                uIAGetHandleForTopLevelWindowpropCount++;
            }

            if (uIAGetHandleForTopLevelWindowMatchIndexAscending != null)
            {
                uIAGetHandleForTopLevelWindow["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetHandleForTopLevelWindowMatchIndexAscending);
                uIAGetHandleForTopLevelWindowpropCount++;
            }

            uIAGetHandleForTopLevelWindowpropCount++;
            uIAGetHandleForTopLevelWindow["Workflow"] = ExpressionConverter.ConvertO(uIAGetHandleForTopLevelWindowWorkflow);
            if (uIAGetHandleForTopLevelWindowpropCount > 0)
            {
                callPayload.Body = uIAGetHandleForTopLevelWindow;
            }

            return new ApiConnectionAction<UIAGetHandleForTopLevelWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForTopLevelWindowResponse> UIAWaitForTopLevelWindow(Expression<Func<int>> uIAWaitForTopLevelWindowSecondsToWait, Expression<Func<string>> uIAWaitForTopLevelWindowWorkflow, Expression<Func<string>> uIAWaitForTopLevelWindowSearchClassName = null, Expression<Func<string>> uIAWaitForTopLevelWindowSearchWindowTitle = null, Expression<Func<int>> uIAWaitForTopLevelWindowSearchProcessId = null, Expression<Func<int>> uIAWaitForTopLevelWindowMatchIndex = null, Expression<Func<string>> uIAWaitForTopLevelWindowSearchFilter = null, Expression<Func<string>> uIAWaitForTopLevelWindowSortByColumn = null, Expression<Func<bool>> uIAWaitForTopLevelWindowMatchIndexAscending = null, Expression<Func<bool>> uIAWaitForTopLevelWindowRaiseExceptionIfWindowNotFound = null)
        {
            var apiCallPath = "/UIAControl/WaitForTopLevelWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAWaitForTopLevelWindow = new JObject();
            var uIAWaitForTopLevelWindowpropCount = 0;
            if (uIAWaitForTopLevelWindowSearchClassName != null)
            {
                uIAWaitForTopLevelWindow["SearchClassName"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowSearchClassName);
                uIAWaitForTopLevelWindowpropCount++;
            }

            if (uIAWaitForTopLevelWindowSearchWindowTitle != null)
            {
                uIAWaitForTopLevelWindow["SearchWindowTitle"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowSearchWindowTitle);
                uIAWaitForTopLevelWindowpropCount++;
            }

            uIAWaitForTopLevelWindowpropCount++;
            uIAWaitForTopLevelWindow["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowSecondsToWait);
            if (uIAWaitForTopLevelWindowSearchProcessId != null)
            {
                uIAWaitForTopLevelWindow["SearchProcessId"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowSearchProcessId);
                uIAWaitForTopLevelWindowpropCount++;
            }

            if (uIAWaitForTopLevelWindowMatchIndex != null)
            {
                uIAWaitForTopLevelWindow["MatchIndex"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowMatchIndex);
                uIAWaitForTopLevelWindowpropCount++;
            }

            if (uIAWaitForTopLevelWindowSearchFilter != null)
            {
                uIAWaitForTopLevelWindow["SearchFilter"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowSearchFilter);
                uIAWaitForTopLevelWindowpropCount++;
            }

            if (uIAWaitForTopLevelWindowSortByColumn != null)
            {
                uIAWaitForTopLevelWindow["SortByColumn"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowSortByColumn);
                uIAWaitForTopLevelWindowpropCount++;
            }

            if (uIAWaitForTopLevelWindowMatchIndexAscending != null)
            {
                uIAWaitForTopLevelWindow["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowMatchIndexAscending);
                uIAWaitForTopLevelWindowpropCount++;
            }

            if (uIAWaitForTopLevelWindowRaiseExceptionIfWindowNotFound != null)
            {
                uIAWaitForTopLevelWindow["RaiseExceptionIfWindowNotFound"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowRaiseExceptionIfWindowNotFound);
                uIAWaitForTopLevelWindowpropCount++;
            }

            uIAWaitForTopLevelWindowpropCount++;
            uIAWaitForTopLevelWindow["Workflow"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowWorkflow);
            if (uIAWaitForTopLevelWindowpropCount > 0)
            {
                callPayload.Body = uIAWaitForTopLevelWindow;
            }

            return new ApiConnectionAction<UIAWaitForTopLevelWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIADoesProcessHaveWindowResponse> UIADoesProcessHaveWindow(Expression<Func<string>> uIADoesProcessHaveWindowSearchProcessName, Expression<Func<string>> uIADoesProcessHaveWindowWorkflow)
        {
            var apiCallPath = "/UIAControl/DoesProcessHaveWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIADoesProcessHaveWindow = new JObject();
            var uIADoesProcessHaveWindowpropCount = 0;
            uIADoesProcessHaveWindowpropCount++;
            uIADoesProcessHaveWindow["SearchProcessName"] = ExpressionConverter.ConvertO(uIADoesProcessHaveWindowSearchProcessName);
            uIADoesProcessHaveWindowpropCount++;
            uIADoesProcessHaveWindow["Workflow"] = ExpressionConverter.ConvertO(uIADoesProcessHaveWindowWorkflow);
            if (uIADoesProcessHaveWindowpropCount > 0)
            {
                callPayload.Body = uIADoesProcessHaveWindow;
            }

            return new ApiConnectionAction<UIADoesProcessHaveWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForProcessMainWindowResponse> UIAGetHandleForProcessMainWindow(Expression<Func<string>> uIAGetHandleForProcessMainWindowSearchProcessName, Expression<Func<string>> uIAGetHandleForProcessMainWindowWorkflow)
        {
            var apiCallPath = "/UIAControl/GetHandleForProcessMainWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetHandleForProcessMainWindow = new JObject();
            var uIAGetHandleForProcessMainWindowpropCount = 0;
            uIAGetHandleForProcessMainWindowpropCount++;
            uIAGetHandleForProcessMainWindow["SearchProcessName"] = ExpressionConverter.ConvertO(uIAGetHandleForProcessMainWindowSearchProcessName);
            uIAGetHandleForProcessMainWindowpropCount++;
            uIAGetHandleForProcessMainWindow["Workflow"] = ExpressionConverter.ConvertO(uIAGetHandleForProcessMainWindowWorkflow);
            if (uIAGetHandleForProcessMainWindowpropCount > 0)
            {
                callPayload.Body = uIAGetHandleForProcessMainWindow;
            }

            return new ApiConnectionAction<UIAGetHandleForProcessMainWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForProcessMainWindowResponse> UIAWaitForProcessMainWindow(Expression<Func<string>> uIAWaitForProcessMainWindowSearchProcessName, Expression<Func<int>> uIAWaitForProcessMainWindowSecondsToWait, Expression<Func<string>> uIAWaitForProcessMainWindowWorkflow)
        {
            var apiCallPath = "/UIAControl/WaitForProcessMainWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAWaitForProcessMainWindow = new JObject();
            var uIAWaitForProcessMainWindowpropCount = 0;
            uIAWaitForProcessMainWindowpropCount++;
            uIAWaitForProcessMainWindow["SearchProcessName"] = ExpressionConverter.ConvertO(uIAWaitForProcessMainWindowSearchProcessName);
            uIAWaitForProcessMainWindowpropCount++;
            uIAWaitForProcessMainWindow["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForProcessMainWindowSecondsToWait);
            uIAWaitForProcessMainWindowpropCount++;
            uIAWaitForProcessMainWindow["Workflow"] = ExpressionConverter.ConvertO(uIAWaitForProcessMainWindowWorkflow);
            if (uIAWaitForProcessMainWindowpropCount > 0)
            {
                callPayload.Body = uIAWaitForProcessMainWindow;
            }

            return new ApiConnectionAction<UIAWaitForProcessMainWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForProcessIdMainWindowResponse> UIAGetHandleForProcessIdMainWindow(Expression<Func<int>> uIAGetHandleForProcessIdMainWindowProcessId, Expression<Func<string>> uIAGetHandleForProcessIdMainWindowWorkflow)
        {
            var apiCallPath = "/UIAControl/GetHandleForProcessIdMainWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetHandleForProcessIdMainWindow = new JObject();
            var uIAGetHandleForProcessIdMainWindowpropCount = 0;
            uIAGetHandleForProcessIdMainWindowpropCount++;
            uIAGetHandleForProcessIdMainWindow["ProcessId"] = ExpressionConverter.ConvertO(uIAGetHandleForProcessIdMainWindowProcessId);
            uIAGetHandleForProcessIdMainWindowpropCount++;
            uIAGetHandleForProcessIdMainWindow["Workflow"] = ExpressionConverter.ConvertO(uIAGetHandleForProcessIdMainWindowWorkflow);
            if (uIAGetHandleForProcessIdMainWindowpropCount > 0)
            {
                callPayload.Body = uIAGetHandleForProcessIdMainWindow;
            }

            return new ApiConnectionAction<UIAGetHandleForProcessIdMainWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForProcessIdMainWindowResponse> UIAWaitForProcessIdMainWindow(Expression<Func<int>> uIAWaitForProcessIdMainWindowProcessId, Expression<Func<int>> uIAWaitForProcessIdMainWindowSecondsToWait, Expression<Func<string>> uIAWaitForProcessIdMainWindowWorkflow)
        {
            var apiCallPath = "/UIAControl/WaitForProcessIdMainWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAWaitForProcessIdMainWindow = new JObject();
            var uIAWaitForProcessIdMainWindowpropCount = 0;
            uIAWaitForProcessIdMainWindowpropCount++;
            uIAWaitForProcessIdMainWindow["ProcessId"] = ExpressionConverter.ConvertO(uIAWaitForProcessIdMainWindowProcessId);
            uIAWaitForProcessIdMainWindowpropCount++;
            uIAWaitForProcessIdMainWindow["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForProcessIdMainWindowSecondsToWait);
            uIAWaitForProcessIdMainWindowpropCount++;
            uIAWaitForProcessIdMainWindow["Workflow"] = ExpressionConverter.ConvertO(uIAWaitForProcessIdMainWindowWorkflow);
            if (uIAWaitForProcessIdMainWindowpropCount > 0)
            {
                callPayload.Body = uIAWaitForProcessIdMainWindow;
            }

            return new ApiConnectionAction<UIAWaitForProcessIdMainWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForFocussedElementResponse> UIAGetHandleForFocussedElement(Expression<Func<string>> uIAGetHandleForFocussedElementWorkflow)
        {
            var apiCallPath = "/UIAControl/GetHandleForFocussedElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetHandleForFocussedElement = new JObject();
            var uIAGetHandleForFocussedElementpropCount = 0;
            uIAGetHandleForFocussedElementpropCount++;
            uIAGetHandleForFocussedElement["Workflow"] = ExpressionConverter.ConvertO(uIAGetHandleForFocussedElementWorkflow);
            if (uIAGetHandleForFocussedElementpropCount > 0)
            {
                callPayload.Body = uIAGetHandleForFocussedElement;
            }

            return new ApiConnectionAction<UIAGetHandleForFocussedElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForMainWindowOfFocussedElementResponse> UIAGetHandleForMainWindowOfFocussedElement(Expression<Func<string>> uIAGetHandleForMainWindowOfFocussedElementWorkflow)
        {
            var apiCallPath = "/UIAControl/GetHandleForMainWindowOfFocussedElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetHandleForMainWindowOfFocussedElement = new JObject();
            var uIAGetHandleForMainWindowOfFocussedElementpropCount = 0;
            uIAGetHandleForMainWindowOfFocussedElementpropCount++;
            uIAGetHandleForMainWindowOfFocussedElement["Workflow"] = ExpressionConverter.ConvertO(uIAGetHandleForMainWindowOfFocussedElementWorkflow);
            if (uIAGetHandleForMainWindowOfFocussedElementpropCount > 0)
            {
                callPayload.Body = uIAGetHandleForMainWindowOfFocussedElement;
            }

            return new ApiConnectionAction<UIAGetHandleForMainWindowOfFocussedElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForDesktopResponse> UIAGetHandleForDesktop(Expression<Func<string>> uIAGetHandleForDesktopWorkflow)
        {
            var apiCallPath = "/UIAControl/GetHandleForDesktop";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetHandleForDesktop = new JObject();
            var uIAGetHandleForDesktoppropCount = 0;
            uIAGetHandleForDesktoppropCount++;
            uIAGetHandleForDesktop["Workflow"] = ExpressionConverter.ConvertO(uIAGetHandleForDesktopWorkflow);
            if (uIAGetHandleForDesktoppropCount > 0)
            {
                callPayload.Body = uIAGetHandleForDesktop;
            }

            return new ApiConnectionAction<UIAGetHandleForDesktopResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIASetForegroundWindow(Expression<Func<int>> uIASetForegroundWindowWindowHandle, Expression<Func<string>> uIASetForegroundWindowWorkflow, Expression<Func<bool>> uIASetForegroundWindowToggleWindow = null, Expression<Func<bool>> uIASetForegroundWindowToggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> uIASetForegroundWindowToggleDelay = null)
        {
            var apiCallPath = "/UIAControl/SetForegroundWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIASetForegroundWindow = new JObject();
            var uIASetForegroundWindowpropCount = 0;
            uIASetForegroundWindowpropCount++;
            uIASetForegroundWindow["WindowHandle"] = ExpressionConverter.ConvertO(uIASetForegroundWindowWindowHandle);
            if (uIASetForegroundWindowToggleWindow != null)
            {
                uIASetForegroundWindow["ToggleWindow"] = ExpressionConverter.ConvertO(uIASetForegroundWindowToggleWindow);
                uIASetForegroundWindowpropCount++;
            }

            if (uIASetForegroundWindowToggleUsesGlobalLeftMouseClickAgent != null)
            {
                uIASetForegroundWindow["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(uIASetForegroundWindowToggleUsesGlobalLeftMouseClickAgent);
                uIASetForegroundWindowpropCount++;
            }

            if (uIASetForegroundWindowToggleDelay != null)
            {
                uIASetForegroundWindow["ToggleDelay"] = ExpressionConverter.ConvertO(uIASetForegroundWindowToggleDelay);
                uIASetForegroundWindowpropCount++;
            }

            uIASetForegroundWindowpropCount++;
            uIASetForegroundWindow["Workflow"] = ExpressionConverter.ConvertO(uIASetForegroundWindowWorkflow);
            if (uIASetForegroundWindowpropCount > 0)
            {
                callPayload.Body = uIASetForegroundWindow;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAMaximiseWindow(Expression<Func<int>> uIAMaximiseWindowWindowHandle, Expression<Func<string>> uIAMaximiseWindowWorkflow)
        {
            var apiCallPath = "/UIAControl/MaximiseWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAMaximiseWindow = new JObject();
            var uIAMaximiseWindowpropCount = 0;
            uIAMaximiseWindowpropCount++;
            uIAMaximiseWindow["WindowHandle"] = ExpressionConverter.ConvertO(uIAMaximiseWindowWindowHandle);
            uIAMaximiseWindowpropCount++;
            uIAMaximiseWindow["Workflow"] = ExpressionConverter.ConvertO(uIAMaximiseWindowWorkflow);
            if (uIAMaximiseWindowpropCount > 0)
            {
                callPayload.Body = uIAMaximiseWindow;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAMinimiseWindow(Expression<Func<int>> uIAMinimiseWindowWindowHandle, Expression<Func<string>> uIAMinimiseWindowWorkflow)
        {
            var apiCallPath = "/UIAControl/MinimiseWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAMinimiseWindow = new JObject();
            var uIAMinimiseWindowpropCount = 0;
            uIAMinimiseWindowpropCount++;
            uIAMinimiseWindow["WindowHandle"] = ExpressionConverter.ConvertO(uIAMinimiseWindowWindowHandle);
            uIAMinimiseWindowpropCount++;
            uIAMinimiseWindow["Workflow"] = ExpressionConverter.ConvertO(uIAMinimiseWindowWorkflow);
            if (uIAMinimiseWindowpropCount > 0)
            {
                callPayload.Body = uIAMinimiseWindow;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIASetWindowToNormal(Expression<Func<int>> uIASetWindowToNormalWindowHandle, Expression<Func<string>> uIASetWindowToNormalWorkflow)
        {
            var apiCallPath = "/UIAControl/SetWindowToNormal";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIASetWindowToNormal = new JObject();
            var uIASetWindowToNormalpropCount = 0;
            uIASetWindowToNormalpropCount++;
            uIASetWindowToNormal["WindowHandle"] = ExpressionConverter.ConvertO(uIASetWindowToNormalWindowHandle);
            uIASetWindowToNormalpropCount++;
            uIASetWindowToNormal["Workflow"] = ExpressionConverter.ConvertO(uIASetWindowToNormalWorkflow);
            if (uIASetWindowToNormalpropCount > 0)
            {
                callPayload.Body = uIASetWindowToNormal;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIADoesElementExistResponse> UIADoesElementExist(Expression<Func<int>> uIADoesElementExistParentWindowHandle, Expression<Func<string>> uIADoesElementExistWorkflow, Expression<Func<string>> uIADoesElementExistSearchElementName = null, Expression<Func<string>> uIADoesElementExistSearchElementClassName = null, Expression<Func<string>> uIADoesElementExistSearchElementAutomationId = null, Expression<Func<string>> uIADoesElementExistSearchLocalizedControlType = null, Expression<Func<int>> uIADoesElementExistSearchProcessId = null, Expression<Func<bool>> uIADoesElementExistSearchSubTree = null, Expression<Func<bool>> uIADoesElementExistReturnElementHandle = null, Expression<Func<int>> uIADoesElementExistMatchIndex = null, Expression<Func<string>> uIADoesElementExistSearchFilter = null, Expression<Func<string>> uIADoesElementExistSortByColumn = null, Expression<Func<bool>> uIADoesElementExistMatchIndexAscending = null, Expression<Func<bool>> uIADoesElementExistIncludeChildProcesses = null, Expression<Func<int>> uIADoesElementExistMaxElementsToSearch = null, Expression<Func<int>> uIADoesElementExistMaxRelativeSearchDepth = null, Expression<Func<int>> uIADoesElementExistMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIADoesElementExistElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/DoesElementExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIADoesElementExist = new JObject();
            var uIADoesElementExistpropCount = 0;
            uIADoesElementExistpropCount++;
            uIADoesElementExist["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIADoesElementExistParentWindowHandle);
            if (uIADoesElementExistSearchElementName != null)
            {
                uIADoesElementExist["SearchElementName"] = ExpressionConverter.ConvertO(uIADoesElementExistSearchElementName);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistSearchElementClassName != null)
            {
                uIADoesElementExist["SearchElementClassName"] = ExpressionConverter.ConvertO(uIADoesElementExistSearchElementClassName);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistSearchElementAutomationId != null)
            {
                uIADoesElementExist["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIADoesElementExistSearchElementAutomationId);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistSearchLocalizedControlType != null)
            {
                uIADoesElementExist["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIADoesElementExistSearchLocalizedControlType);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistSearchProcessId != null)
            {
                uIADoesElementExist["SearchProcessId"] = ExpressionConverter.ConvertO(uIADoesElementExistSearchProcessId);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistSearchSubTree != null)
            {
                uIADoesElementExist["SearchSubTree"] = ExpressionConverter.ConvertO(uIADoesElementExistSearchSubTree);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistReturnElementHandle != null)
            {
                uIADoesElementExist["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIADoesElementExistReturnElementHandle);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistMatchIndex != null)
            {
                uIADoesElementExist["MatchIndex"] = ExpressionConverter.ConvertO(uIADoesElementExistMatchIndex);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistSearchFilter != null)
            {
                uIADoesElementExist["SearchFilter"] = ExpressionConverter.ConvertO(uIADoesElementExistSearchFilter);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistSortByColumn != null)
            {
                uIADoesElementExist["SortByColumn"] = ExpressionConverter.ConvertO(uIADoesElementExistSortByColumn);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistMatchIndexAscending != null)
            {
                uIADoesElementExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIADoesElementExistMatchIndexAscending);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistIncludeChildProcesses != null)
            {
                uIADoesElementExist["IncludeChildProcesses"] = ExpressionConverter.ConvertO(uIADoesElementExistIncludeChildProcesses);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistMaxElementsToSearch != null)
            {
                uIADoesElementExist["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIADoesElementExistMaxElementsToSearch);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistMaxRelativeSearchDepth != null)
            {
                uIADoesElementExist["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIADoesElementExistMaxRelativeSearchDepth);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistMaxChildElementsToSearchPerNode != null)
            {
                uIADoesElementExist["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIADoesElementExistMaxChildElementsToSearchPerNode);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistElementLocalizedControlTypesNotToTraverse != null)
            {
                uIADoesElementExist["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIADoesElementExistElementLocalizedControlTypesNotToTraverse);
                uIADoesElementExistpropCount++;
            }

            uIADoesElementExistpropCount++;
            uIADoesElementExist["Workflow"] = ExpressionConverter.ConvertO(uIADoesElementExistWorkflow);
            if (uIADoesElementExistpropCount > 0)
            {
                callPayload.Body = uIADoesElementExist;
            }

            return new ApiConnectionAction<UIADoesElementExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIADoesDesktopElementExistResponse> UIADoesDesktopElementExist(Expression<Func<string>> uIADoesDesktopElementExistWorkflow, Expression<Func<string>> uIADoesDesktopElementExistSearchElementName = null, Expression<Func<string>> uIADoesDesktopElementExistSearchElementClassName = null, Expression<Func<string>> uIADoesDesktopElementExistSearchElementAutomationId = null, Expression<Func<string>> uIADoesDesktopElementExistSearchLocalizedControlType = null, Expression<Func<int>> uIADoesDesktopElementExistSearchProcessId = null, Expression<Func<bool>> uIADoesDesktopElementExistSearchSubTree = null, Expression<Func<bool>> uIADoesDesktopElementExistReturnElementHandle = null, Expression<Func<int>> uIADoesDesktopElementExistMatchIndex = null, Expression<Func<string>> uIADoesDesktopElementExistSearchFilter = null, Expression<Func<string>> uIADoesDesktopElementExistSortByColumn = null, Expression<Func<bool>> uIADoesDesktopElementExistMatchIndexAscending = null, Expression<Func<bool>> uIADoesDesktopElementExistIncludeChildProcesses = null, Expression<Func<int>> uIADoesDesktopElementExistMaxElementsToSearch = null, Expression<Func<int>> uIADoesDesktopElementExistMaxRelativeSearchDepth = null, Expression<Func<int>> uIADoesDesktopElementExistMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIADoesDesktopElementExistElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/DoesDesktopElementExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIADoesDesktopElementExist = new JObject();
            var uIADoesDesktopElementExistpropCount = 0;
            if (uIADoesDesktopElementExistSearchElementName != null)
            {
                uIADoesDesktopElementExist["SearchElementName"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistSearchElementName);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistSearchElementClassName != null)
            {
                uIADoesDesktopElementExist["SearchElementClassName"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistSearchElementClassName);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistSearchElementAutomationId != null)
            {
                uIADoesDesktopElementExist["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistSearchElementAutomationId);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistSearchLocalizedControlType != null)
            {
                uIADoesDesktopElementExist["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistSearchLocalizedControlType);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistSearchProcessId != null)
            {
                uIADoesDesktopElementExist["SearchProcessId"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistSearchProcessId);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistSearchSubTree != null)
            {
                uIADoesDesktopElementExist["SearchSubTree"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistSearchSubTree);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistReturnElementHandle != null)
            {
                uIADoesDesktopElementExist["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistReturnElementHandle);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistMatchIndex != null)
            {
                uIADoesDesktopElementExist["MatchIndex"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistMatchIndex);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistSearchFilter != null)
            {
                uIADoesDesktopElementExist["SearchFilter"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistSearchFilter);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistSortByColumn != null)
            {
                uIADoesDesktopElementExist["SortByColumn"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistSortByColumn);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistMatchIndexAscending != null)
            {
                uIADoesDesktopElementExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistMatchIndexAscending);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistIncludeChildProcesses != null)
            {
                uIADoesDesktopElementExist["IncludeChildProcesses"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistIncludeChildProcesses);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistMaxElementsToSearch != null)
            {
                uIADoesDesktopElementExist["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistMaxElementsToSearch);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistMaxRelativeSearchDepth != null)
            {
                uIADoesDesktopElementExist["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistMaxRelativeSearchDepth);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistMaxChildElementsToSearchPerNode != null)
            {
                uIADoesDesktopElementExist["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistMaxChildElementsToSearchPerNode);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistElementLocalizedControlTypesNotToTraverse != null)
            {
                uIADoesDesktopElementExist["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistElementLocalizedControlTypesNotToTraverse);
                uIADoesDesktopElementExistpropCount++;
            }

            uIADoesDesktopElementExistpropCount++;
            uIADoesDesktopElementExist["Workflow"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistWorkflow);
            if (uIADoesDesktopElementExistpropCount > 0)
            {
                callPayload.Body = uIADoesDesktopElementExist;
            }

            return new ApiConnectionAction<UIADoesDesktopElementExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForElementResponse> UIAWaitForElement(Expression<Func<int>> uIAWaitForElementParentWindowHandle, Expression<Func<int>> uIAWaitForElementSecondsToWait, Expression<Func<string>> uIAWaitForElementWorkflow, Expression<Func<string>> uIAWaitForElementSearchElementName = null, Expression<Func<string>> uIAWaitForElementSearchElementClassName = null, Expression<Func<string>> uIAWaitForElementSearchElementAutomationId = null, Expression<Func<string>> uIAWaitForElementSearchLocalizedControlType = null, Expression<Func<int>> uIAWaitForElementSearchProcessId = null, Expression<Func<bool>> uIAWaitForElementSearchSubTree = null, Expression<Func<bool>> uIAWaitForElementReturnElementHandle = null, Expression<Func<int>> uIAWaitForElementMatchIndex = null, Expression<Func<string>> uIAWaitForElementSearchFilter = null, Expression<Func<string>> uIAWaitForElementSortByColumn = null, Expression<Func<bool>> uIAWaitForElementMatchIndexAscending = null, Expression<Func<bool>> uIAWaitForElementIncludeChildProcesses = null, Expression<Func<bool>> uIAWaitForElementRaiseExceptionIfElementNotFound = null, Expression<Func<int>> uIAWaitForElementMaxElementsToSearch = null, Expression<Func<int>> uIAWaitForElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIAWaitForElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAWaitForElementElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/WaitForElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAWaitForElement = new JObject();
            var uIAWaitForElementpropCount = 0;
            uIAWaitForElementpropCount++;
            uIAWaitForElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAWaitForElementParentWindowHandle);
            if (uIAWaitForElementSearchElementName != null)
            {
                uIAWaitForElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAWaitForElementSearchElementName);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementSearchElementClassName != null)
            {
                uIAWaitForElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAWaitForElementSearchElementClassName);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementSearchElementAutomationId != null)
            {
                uIAWaitForElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAWaitForElementSearchElementAutomationId);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementSearchLocalizedControlType != null)
            {
                uIAWaitForElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAWaitForElementSearchLocalizedControlType);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementSearchProcessId != null)
            {
                uIAWaitForElement["SearchProcessId"] = ExpressionConverter.ConvertO(uIAWaitForElementSearchProcessId);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementSearchSubTree != null)
            {
                uIAWaitForElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAWaitForElementSearchSubTree);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementReturnElementHandle != null)
            {
                uIAWaitForElement["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIAWaitForElementReturnElementHandle);
                uIAWaitForElementpropCount++;
            }

            uIAWaitForElementpropCount++;
            uIAWaitForElement["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForElementSecondsToWait);
            if (uIAWaitForElementMatchIndex != null)
            {
                uIAWaitForElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAWaitForElementMatchIndex);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementSearchFilter != null)
            {
                uIAWaitForElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAWaitForElementSearchFilter);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementSortByColumn != null)
            {
                uIAWaitForElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAWaitForElementSortByColumn);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementMatchIndexAscending != null)
            {
                uIAWaitForElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAWaitForElementMatchIndexAscending);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementIncludeChildProcesses != null)
            {
                uIAWaitForElement["IncludeChildProcesses"] = ExpressionConverter.ConvertO(uIAWaitForElementIncludeChildProcesses);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementRaiseExceptionIfElementNotFound != null)
            {
                uIAWaitForElement["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(uIAWaitForElementRaiseExceptionIfElementNotFound);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementMaxElementsToSearch != null)
            {
                uIAWaitForElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAWaitForElementMaxElementsToSearch);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementMaxRelativeSearchDepth != null)
            {
                uIAWaitForElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAWaitForElementMaxRelativeSearchDepth);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementMaxChildElementsToSearchPerNode != null)
            {
                uIAWaitForElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAWaitForElementMaxChildElementsToSearchPerNode);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAWaitForElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAWaitForElementElementLocalizedControlTypesNotToTraverse);
                uIAWaitForElementpropCount++;
            }

            uIAWaitForElementpropCount++;
            uIAWaitForElement["Workflow"] = ExpressionConverter.ConvertO(uIAWaitForElementWorkflow);
            if (uIAWaitForElementpropCount > 0)
            {
                callPayload.Body = uIAWaitForElement;
            }

            return new ApiConnectionAction<UIAWaitForElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForDesktopElementResponse> UIAWaitForDesktopElement(Expression<Func<int>> uIAWaitForDesktopElementSecondsToWait, Expression<Func<string>> uIAWaitForDesktopElementWorkflow, Expression<Func<string>> uIAWaitForDesktopElementSearchElementName = null, Expression<Func<string>> uIAWaitForDesktopElementSearchElementClassName = null, Expression<Func<string>> uIAWaitForDesktopElementSearchElementAutomationId = null, Expression<Func<string>> uIAWaitForDesktopElementSearchLocalizedControlType = null, Expression<Func<int>> uIAWaitForDesktopElementSearchProcessId = null, Expression<Func<bool>> uIAWaitForDesktopElementSearchSubTree = null, Expression<Func<bool>> uIAWaitForDesktopElementReturnElementHandle = null, Expression<Func<int>> uIAWaitForDesktopElementMatchIndex = null, Expression<Func<string>> uIAWaitForDesktopElementSearchFilter = null, Expression<Func<string>> uIAWaitForDesktopElementSortByColumn = null, Expression<Func<bool>> uIAWaitForDesktopElementMatchIndexAscending = null, Expression<Func<bool>> uIAWaitForDesktopElementIncludeChildProcesses = null, Expression<Func<bool>> uIAWaitForDesktopElementRaiseExceptionIfElementNotFound = null, Expression<Func<int>> uIAWaitForDesktopElementMaxElementsToSearch = null, Expression<Func<int>> uIAWaitForDesktopElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIAWaitForDesktopElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAWaitForDesktopElementElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/WaitForDesktopElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAWaitForDesktopElement = new JObject();
            var uIAWaitForDesktopElementpropCount = 0;
            if (uIAWaitForDesktopElementSearchElementName != null)
            {
                uIAWaitForDesktopElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementSearchElementName);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementSearchElementClassName != null)
            {
                uIAWaitForDesktopElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementSearchElementClassName);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementSearchElementAutomationId != null)
            {
                uIAWaitForDesktopElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementSearchElementAutomationId);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementSearchLocalizedControlType != null)
            {
                uIAWaitForDesktopElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementSearchLocalizedControlType);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementSearchProcessId != null)
            {
                uIAWaitForDesktopElement["SearchProcessId"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementSearchProcessId);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementSearchSubTree != null)
            {
                uIAWaitForDesktopElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementSearchSubTree);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementReturnElementHandle != null)
            {
                uIAWaitForDesktopElement["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementReturnElementHandle);
                uIAWaitForDesktopElementpropCount++;
            }

            uIAWaitForDesktopElementpropCount++;
            uIAWaitForDesktopElement["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementSecondsToWait);
            if (uIAWaitForDesktopElementMatchIndex != null)
            {
                uIAWaitForDesktopElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementMatchIndex);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementSearchFilter != null)
            {
                uIAWaitForDesktopElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementSearchFilter);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementSortByColumn != null)
            {
                uIAWaitForDesktopElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementSortByColumn);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementMatchIndexAscending != null)
            {
                uIAWaitForDesktopElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementMatchIndexAscending);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementIncludeChildProcesses != null)
            {
                uIAWaitForDesktopElement["IncludeChildProcesses"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementIncludeChildProcesses);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementRaiseExceptionIfElementNotFound != null)
            {
                uIAWaitForDesktopElement["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementRaiseExceptionIfElementNotFound);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementMaxElementsToSearch != null)
            {
                uIAWaitForDesktopElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementMaxElementsToSearch);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementMaxRelativeSearchDepth != null)
            {
                uIAWaitForDesktopElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementMaxRelativeSearchDepth);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementMaxChildElementsToSearchPerNode != null)
            {
                uIAWaitForDesktopElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementMaxChildElementsToSearchPerNode);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAWaitForDesktopElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementElementLocalizedControlTypesNotToTraverse);
                uIAWaitForDesktopElementpropCount++;
            }

            uIAWaitForDesktopElementpropCount++;
            uIAWaitForDesktopElement["Workflow"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementWorkflow);
            if (uIAWaitForDesktopElementpropCount > 0)
            {
                callPayload.Body = uIAWaitForDesktopElement;
            }

            return new ApiConnectionAction<UIAWaitForDesktopElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForElementToNotExistResponse> UIAWaitForElementToNotExist(Expression<Func<int>> uIAWaitForElementToNotExistParentWindowHandle, Expression<Func<int>> uIAWaitForElementToNotExistSecondsToWait, Expression<Func<string>> uIAWaitForElementToNotExistWorkflow, Expression<Func<string>> uIAWaitForElementToNotExistSearchElementName = null, Expression<Func<string>> uIAWaitForElementToNotExistSearchElementClassName = null, Expression<Func<string>> uIAWaitForElementToNotExistSearchElementAutomationId = null, Expression<Func<string>> uIAWaitForElementToNotExistSearchLocalizedControlType = null, Expression<Func<int>> uIAWaitForElementToNotExistSearchProcessId = null, Expression<Func<bool>> uIAWaitForElementToNotExistSearchSubTree = null, Expression<Func<int>> uIAWaitForElementToNotExistMatchIndex = null, Expression<Func<string>> uIAWaitForElementToNotExistSearchFilter = null, Expression<Func<string>> uIAWaitForElementToNotExistSortByColumn = null, Expression<Func<bool>> uIAWaitForElementToNotExistMatchIndexAscending = null, Expression<Func<bool>> uIAWaitForElementToNotExistIncludeChildProcesses = null, Expression<Func<bool>> uIAWaitForElementToNotExistRaiseExceptionIfElementStillExists = null, Expression<Func<int>> uIAWaitForElementToNotExistMaxElementsToSearch = null, Expression<Func<int>> uIAWaitForElementToNotExistMaxRelativeSearchDepth = null, Expression<Func<int>> uIAWaitForElementToNotExistMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAWaitForElementToNotExistElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/UIAWaitForElementToNotExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAWaitForElementToNotExist = new JObject();
            var uIAWaitForElementToNotExistpropCount = 0;
            uIAWaitForElementToNotExistpropCount++;
            uIAWaitForElementToNotExist["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistParentWindowHandle);
            if (uIAWaitForElementToNotExistSearchElementName != null)
            {
                uIAWaitForElementToNotExist["SearchElementName"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistSearchElementName);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistSearchElementClassName != null)
            {
                uIAWaitForElementToNotExist["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistSearchElementClassName);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistSearchElementAutomationId != null)
            {
                uIAWaitForElementToNotExist["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistSearchElementAutomationId);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistSearchLocalizedControlType != null)
            {
                uIAWaitForElementToNotExist["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistSearchLocalizedControlType);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistSearchProcessId != null)
            {
                uIAWaitForElementToNotExist["SearchProcessId"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistSearchProcessId);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistSearchSubTree != null)
            {
                uIAWaitForElementToNotExist["SearchSubTree"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistSearchSubTree);
                uIAWaitForElementToNotExistpropCount++;
            }

            uIAWaitForElementToNotExistpropCount++;
            uIAWaitForElementToNotExist["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistSecondsToWait);
            if (uIAWaitForElementToNotExistMatchIndex != null)
            {
                uIAWaitForElementToNotExist["MatchIndex"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistMatchIndex);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistSearchFilter != null)
            {
                uIAWaitForElementToNotExist["SearchFilter"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistSearchFilter);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistSortByColumn != null)
            {
                uIAWaitForElementToNotExist["SortByColumn"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistSortByColumn);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistMatchIndexAscending != null)
            {
                uIAWaitForElementToNotExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistMatchIndexAscending);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistIncludeChildProcesses != null)
            {
                uIAWaitForElementToNotExist["IncludeChildProcesses"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistIncludeChildProcesses);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistRaiseExceptionIfElementStillExists != null)
            {
                uIAWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistRaiseExceptionIfElementStillExists);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistMaxElementsToSearch != null)
            {
                uIAWaitForElementToNotExist["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistMaxElementsToSearch);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistMaxRelativeSearchDepth != null)
            {
                uIAWaitForElementToNotExist["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistMaxRelativeSearchDepth);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistMaxChildElementsToSearchPerNode != null)
            {
                uIAWaitForElementToNotExist["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistMaxChildElementsToSearchPerNode);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAWaitForElementToNotExist["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistElementLocalizedControlTypesNotToTraverse);
                uIAWaitForElementToNotExistpropCount++;
            }

            uIAWaitForElementToNotExistpropCount++;
            uIAWaitForElementToNotExist["Workflow"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistWorkflow);
            if (uIAWaitForElementToNotExistpropCount > 0)
            {
                callPayload.Body = uIAWaitForElementToNotExist;
            }

            return new ApiConnectionAction<UIAWaitForElementToNotExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForDesktopElementToNotExistResponse> UIAWaitForDesktopElementToNotExist(Expression<Func<int>> uIAWaitForDesktopElementToNotExistSecondsToWait, Expression<Func<string>> uIAWaitForDesktopElementToNotExistWorkflow, Expression<Func<string>> uIAWaitForDesktopElementToNotExistSearchElementName = null, Expression<Func<string>> uIAWaitForDesktopElementToNotExistSearchElementClassName = null, Expression<Func<string>> uIAWaitForDesktopElementToNotExistSearchElementAutomationId = null, Expression<Func<string>> uIAWaitForDesktopElementToNotExistSearchLocalizedControlType = null, Expression<Func<int>> uIAWaitForDesktopElementToNotExistSearchProcessId = null, Expression<Func<bool>> uIAWaitForDesktopElementToNotExistSearchSubTree = null, Expression<Func<int>> uIAWaitForDesktopElementToNotExistMatchIndex = null, Expression<Func<string>> uIAWaitForDesktopElementToNotExistSearchFilter = null, Expression<Func<string>> uIAWaitForDesktopElementToNotExistSortByColumn = null, Expression<Func<bool>> uIAWaitForDesktopElementToNotExistMatchIndexAscending = null, Expression<Func<bool>> uIAWaitForDesktopElementToNotExistIncludeChildProcesses = null, Expression<Func<bool>> uIAWaitForDesktopElementToNotExistRaiseExceptionIfElementStillExists = null, Expression<Func<int>> uIAWaitForDesktopElementToNotExistMaxElementsToSearch = null, Expression<Func<int>> uIAWaitForDesktopElementToNotExistMaxRelativeSearchDepth = null, Expression<Func<int>> uIAWaitForDesktopElementToNotExistMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAWaitForDesktopElementToNotExistElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/UIAWaitForDesktopElementToNotExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAWaitForDesktopElementToNotExist = new JObject();
            var uIAWaitForDesktopElementToNotExistpropCount = 0;
            if (uIAWaitForDesktopElementToNotExistSearchElementName != null)
            {
                uIAWaitForDesktopElementToNotExist["SearchElementName"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistSearchElementName);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistSearchElementClassName != null)
            {
                uIAWaitForDesktopElementToNotExist["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistSearchElementClassName);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistSearchElementAutomationId != null)
            {
                uIAWaitForDesktopElementToNotExist["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistSearchElementAutomationId);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistSearchLocalizedControlType != null)
            {
                uIAWaitForDesktopElementToNotExist["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistSearchLocalizedControlType);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistSearchProcessId != null)
            {
                uIAWaitForDesktopElementToNotExist["SearchProcessId"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistSearchProcessId);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistSearchSubTree != null)
            {
                uIAWaitForDesktopElementToNotExist["SearchSubTree"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistSearchSubTree);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            uIAWaitForDesktopElementToNotExistpropCount++;
            uIAWaitForDesktopElementToNotExist["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistSecondsToWait);
            if (uIAWaitForDesktopElementToNotExistMatchIndex != null)
            {
                uIAWaitForDesktopElementToNotExist["MatchIndex"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistMatchIndex);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistSearchFilter != null)
            {
                uIAWaitForDesktopElementToNotExist["SearchFilter"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistSearchFilter);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistSortByColumn != null)
            {
                uIAWaitForDesktopElementToNotExist["SortByColumn"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistSortByColumn);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistMatchIndexAscending != null)
            {
                uIAWaitForDesktopElementToNotExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistMatchIndexAscending);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistIncludeChildProcesses != null)
            {
                uIAWaitForDesktopElementToNotExist["IncludeChildProcesses"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistIncludeChildProcesses);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistRaiseExceptionIfElementStillExists != null)
            {
                uIAWaitForDesktopElementToNotExist["RaiseExceptionIfElementStillExists"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistRaiseExceptionIfElementStillExists);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistMaxElementsToSearch != null)
            {
                uIAWaitForDesktopElementToNotExist["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistMaxElementsToSearch);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistMaxRelativeSearchDepth != null)
            {
                uIAWaitForDesktopElementToNotExist["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistMaxRelativeSearchDepth);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistMaxChildElementsToSearchPerNode != null)
            {
                uIAWaitForDesktopElementToNotExist["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistMaxChildElementsToSearchPerNode);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAWaitForDesktopElementToNotExist["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistElementLocalizedControlTypesNotToTraverse);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            uIAWaitForDesktopElementToNotExistpropCount++;
            uIAWaitForDesktopElementToNotExist["Workflow"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistWorkflow);
            if (uIAWaitForDesktopElementToNotExistpropCount > 0)
            {
                callPayload.Body = uIAWaitForDesktopElementToNotExist;
            }

            return new ApiConnectionAction<UIAWaitForDesktopElementToNotExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAPressElement(Expression<Func<int>> uIAPressElementParentWindowHandle, Expression<Func<string>> uIAPressElementWorkflow, Expression<Func<string>> uIAPressElementSearchElementName = null, Expression<Func<string>> uIAPressElementSearchElementClassName = null, Expression<Func<string>> uIAPressElementSearchElementAutomationId = null, Expression<Func<string>> uIAPressElementSearchLocalizedControlType = null, Expression<Func<bool>> uIAPressElementSearchSubTree = null, Expression<Func<bool>> uIAPressElementWait = null, Expression<Func<bool>> uIAPressElementWin32ClickButton = null, Expression<Func<int>> uIAPressElementMatchIndex = null, Expression<Func<string>> uIAPressElementSearchFilter = null, Expression<Func<string>> uIAPressElementSortByColumn = null, Expression<Func<bool>> uIAPressElementMatchIndexAscending = null, Expression<Func<int>> uIAPressElementMaxElementsToSearch = null, Expression<Func<int>> uIAPressElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIAPressElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAPressElementElementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAPressElementTryInvokePattern = null, Expression<Func<bool>> uIAPressElementTryLegacyPattern = null)
        {
            var apiCallPath = "/UIAControl/PressElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAPressElement = new JObject();
            var uIAPressElementpropCount = 0;
            uIAPressElementpropCount++;
            uIAPressElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAPressElementParentWindowHandle);
            if (uIAPressElementSearchElementName != null)
            {
                uIAPressElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAPressElementSearchElementName);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementSearchElementClassName != null)
            {
                uIAPressElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAPressElementSearchElementClassName);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementSearchElementAutomationId != null)
            {
                uIAPressElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAPressElementSearchElementAutomationId);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementSearchLocalizedControlType != null)
            {
                uIAPressElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAPressElementSearchLocalizedControlType);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementSearchSubTree != null)
            {
                uIAPressElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAPressElementSearchSubTree);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementWait != null)
            {
                uIAPressElement["Wait"] = ExpressionConverter.ConvertO(uIAPressElementWait);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementWin32ClickButton != null)
            {
                uIAPressElement["Win32ClickButton"] = ExpressionConverter.ConvertO(uIAPressElementWin32ClickButton);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementMatchIndex != null)
            {
                uIAPressElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAPressElementMatchIndex);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementSearchFilter != null)
            {
                uIAPressElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAPressElementSearchFilter);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementSortByColumn != null)
            {
                uIAPressElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAPressElementSortByColumn);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementMatchIndexAscending != null)
            {
                uIAPressElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAPressElementMatchIndexAscending);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementMaxElementsToSearch != null)
            {
                uIAPressElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAPressElementMaxElementsToSearch);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementMaxRelativeSearchDepth != null)
            {
                uIAPressElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAPressElementMaxRelativeSearchDepth);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementMaxChildElementsToSearchPerNode != null)
            {
                uIAPressElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAPressElementMaxChildElementsToSearchPerNode);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAPressElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAPressElementElementLocalizedControlTypesNotToTraverse);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementTryInvokePattern != null)
            {
                uIAPressElement["TryInvokePattern"] = ExpressionConverter.ConvertO(uIAPressElementTryInvokePattern);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementTryLegacyPattern != null)
            {
                uIAPressElement["TryLegacyPattern"] = ExpressionConverter.ConvertO(uIAPressElementTryLegacyPattern);
                uIAPressElementpropCount++;
            }

            uIAPressElementpropCount++;
            uIAPressElement["Workflow"] = ExpressionConverter.ConvertO(uIAPressElementWorkflow);
            if (uIAPressElementpropCount > 0)
            {
                callPayload.Body = uIAPressElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalMouseClickOnElement(Expression<Func<int>> uIAGlobalMouseClickOnElementParentWindowHandle, Expression<Func<string>> uIAGlobalMouseClickOnElementWorkflow, Expression<Func<string>> uIAGlobalMouseClickOnElementSearchElementName = null, Expression<Func<string>> uIAGlobalMouseClickOnElementSearchElementClassName = null, Expression<Func<string>> uIAGlobalMouseClickOnElementSearchElementAutomationId = null, Expression<Func<string>> uIAGlobalMouseClickOnElementSearchLocalizedControlType = null, Expression<Func<bool>> uIAGlobalMouseClickOnElementSearchSubTree = null, Expression<Func<bool>> uIAGlobalMouseClickOnElementFocusElementFirst = null, Expression<Func<int>> uIAGlobalMouseClickOnElementMatchIndex = null, Expression<Func<string>> uIAGlobalMouseClickOnElementSearchFilter = null, Expression<Func<string>> uIAGlobalMouseClickOnElementSortByColumn = null, Expression<Func<bool>> uIAGlobalMouseClickOnElementMatchIndexAscending = null, Expression<Func<int>> uIAGlobalMouseClickOnElementClickOffsetX = null, Expression<Func<int>> uIAGlobalMouseClickOnElementClickOffsetY = null, Expression<Func<uIAGlobalMouseClickOnElementOffsetRelativeToInput>> uIAGlobalMouseClickOnElementOffsetRelativeTo = null, Expression<Func<int>> uIAGlobalMouseClickOnElementMaxElementsToSearch = null, Expression<Func<int>> uIAGlobalMouseClickOnElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIAGlobalMouseClickOnElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGlobalMouseClickOnElementElementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAGlobalMouseClickOnElementValidateClickablePointWithinElementBoundary = null)
        {
            var apiCallPath = "/UIAControl/GlobalMouseClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGlobalMouseClickOnElement = new JObject();
            var uIAGlobalMouseClickOnElementpropCount = 0;
            uIAGlobalMouseClickOnElementpropCount++;
            uIAGlobalMouseClickOnElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementParentWindowHandle);
            if (uIAGlobalMouseClickOnElementSearchElementName != null)
            {
                uIAGlobalMouseClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementSearchElementName);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementSearchElementClassName != null)
            {
                uIAGlobalMouseClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementSearchElementClassName);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementSearchElementAutomationId != null)
            {
                uIAGlobalMouseClickOnElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementSearchElementAutomationId);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementSearchLocalizedControlType != null)
            {
                uIAGlobalMouseClickOnElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementSearchLocalizedControlType);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementSearchSubTree != null)
            {
                uIAGlobalMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementSearchSubTree);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementFocusElementFirst != null)
            {
                uIAGlobalMouseClickOnElement["FocusElementFirst"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementFocusElementFirst);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementMatchIndex != null)
            {
                uIAGlobalMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementMatchIndex);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementSearchFilter != null)
            {
                uIAGlobalMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementSearchFilter);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementSortByColumn != null)
            {
                uIAGlobalMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementSortByColumn);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementMatchIndexAscending != null)
            {
                uIAGlobalMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementMatchIndexAscending);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementClickOffsetX != null)
            {
                uIAGlobalMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementClickOffsetX);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementClickOffsetY != null)
            {
                uIAGlobalMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementClickOffsetY);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementOffsetRelativeTo != null)
            {
                uIAGlobalMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementOffsetRelativeTo);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementMaxElementsToSearch != null)
            {
                uIAGlobalMouseClickOnElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementMaxElementsToSearch);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementMaxRelativeSearchDepth != null)
            {
                uIAGlobalMouseClickOnElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementMaxRelativeSearchDepth);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementMaxChildElementsToSearchPerNode != null)
            {
                uIAGlobalMouseClickOnElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementMaxChildElementsToSearchPerNode);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGlobalMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementElementLocalizedControlTypesNotToTraverse);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementValidateClickablePointWithinElementBoundary != null)
            {
                uIAGlobalMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementValidateClickablePointWithinElementBoundary);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            uIAGlobalMouseClickOnElementpropCount++;
            uIAGlobalMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementWorkflow);
            if (uIAGlobalMouseClickOnElementpropCount > 0)
            {
                callPayload.Body = uIAGlobalMouseClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalRightMouseClickOnElement(Expression<Func<int>> uIAGlobalRightMouseClickOnElementParentWindowHandle, Expression<Func<string>> uIAGlobalRightMouseClickOnElementWorkflow, Expression<Func<string>> uIAGlobalRightMouseClickOnElementSearchElementName = null, Expression<Func<string>> uIAGlobalRightMouseClickOnElementSearchElementClassName = null, Expression<Func<string>> uIAGlobalRightMouseClickOnElementSearchElementAutomationId = null, Expression<Func<string>> uIAGlobalRightMouseClickOnElementSearchLocalizedControlType = null, Expression<Func<bool>> uIAGlobalRightMouseClickOnElementSearchSubTree = null, Expression<Func<bool>> uIAGlobalRightMouseClickOnElementFocusElementFirst = null, Expression<Func<int>> uIAGlobalRightMouseClickOnElementMatchIndex = null, Expression<Func<string>> uIAGlobalRightMouseClickOnElementSearchFilter = null, Expression<Func<string>> uIAGlobalRightMouseClickOnElementSortByColumn = null, Expression<Func<bool>> uIAGlobalRightMouseClickOnElementMatchIndexAscending = null, Expression<Func<int>> uIAGlobalRightMouseClickOnElementClickOffsetX = null, Expression<Func<int>> uIAGlobalRightMouseClickOnElementClickOffsetY = null, Expression<Func<uIAGlobalRightMouseClickOnElementOffsetRelativeToInput>> uIAGlobalRightMouseClickOnElementOffsetRelativeTo = null, Expression<Func<int>> uIAGlobalRightMouseClickOnElementMaxElementsToSearch = null, Expression<Func<int>> uIAGlobalRightMouseClickOnElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIAGlobalRightMouseClickOnElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGlobalRightMouseClickOnElementElementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAGlobalRightMouseClickOnElementValidateClickablePointWithinElementBoundary = null)
        {
            var apiCallPath = "/UIAControl/GlobalRightMouseClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGlobalRightMouseClickOnElement = new JObject();
            var uIAGlobalRightMouseClickOnElementpropCount = 0;
            uIAGlobalRightMouseClickOnElementpropCount++;
            uIAGlobalRightMouseClickOnElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementParentWindowHandle);
            if (uIAGlobalRightMouseClickOnElementSearchElementName != null)
            {
                uIAGlobalRightMouseClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementSearchElementName);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementSearchElementClassName != null)
            {
                uIAGlobalRightMouseClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementSearchElementClassName);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementSearchElementAutomationId != null)
            {
                uIAGlobalRightMouseClickOnElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementSearchElementAutomationId);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementSearchLocalizedControlType != null)
            {
                uIAGlobalRightMouseClickOnElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementSearchLocalizedControlType);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementSearchSubTree != null)
            {
                uIAGlobalRightMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementSearchSubTree);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementFocusElementFirst != null)
            {
                uIAGlobalRightMouseClickOnElement["FocusElementFirst"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementFocusElementFirst);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementMatchIndex != null)
            {
                uIAGlobalRightMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementMatchIndex);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementSearchFilter != null)
            {
                uIAGlobalRightMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementSearchFilter);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementSortByColumn != null)
            {
                uIAGlobalRightMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementSortByColumn);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementMatchIndexAscending != null)
            {
                uIAGlobalRightMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementMatchIndexAscending);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementClickOffsetX != null)
            {
                uIAGlobalRightMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementClickOffsetX);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementClickOffsetY != null)
            {
                uIAGlobalRightMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementClickOffsetY);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementOffsetRelativeTo != null)
            {
                uIAGlobalRightMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementOffsetRelativeTo);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementMaxElementsToSearch != null)
            {
                uIAGlobalRightMouseClickOnElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementMaxElementsToSearch);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementMaxRelativeSearchDepth != null)
            {
                uIAGlobalRightMouseClickOnElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementMaxRelativeSearchDepth);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementMaxChildElementsToSearchPerNode != null)
            {
                uIAGlobalRightMouseClickOnElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementMaxChildElementsToSearchPerNode);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGlobalRightMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementElementLocalizedControlTypesNotToTraverse);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementValidateClickablePointWithinElementBoundary != null)
            {
                uIAGlobalRightMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementValidateClickablePointWithinElementBoundary);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            uIAGlobalRightMouseClickOnElementpropCount++;
            uIAGlobalRightMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementWorkflow);
            if (uIAGlobalRightMouseClickOnElementpropCount > 0)
            {
                callPayload.Body = uIAGlobalRightMouseClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalMiddleMouseClickOnElement(Expression<Func<int>> uIAGlobalMiddleMouseClickOnElementParentWindowHandle, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementWorkflow, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementSearchElementName = null, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementSearchElementClassName = null, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementSearchElementAutomationId = null, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementSearchLocalizedControlType = null, Expression<Func<bool>> uIAGlobalMiddleMouseClickOnElementSearchSubTree = null, Expression<Func<bool>> uIAGlobalMiddleMouseClickOnElementFocusElementFirst = null, Expression<Func<int>> uIAGlobalMiddleMouseClickOnElementMatchIndex = null, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementSearchFilter = null, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementSortByColumn = null, Expression<Func<bool>> uIAGlobalMiddleMouseClickOnElementMatchIndexAscending = null, Expression<Func<int>> uIAGlobalMiddleMouseClickOnElementClickOffsetX = null, Expression<Func<int>> uIAGlobalMiddleMouseClickOnElementClickOffsetY = null, Expression<Func<uIAGlobalMiddleMouseClickOnElementOffsetRelativeToInput>> uIAGlobalMiddleMouseClickOnElementOffsetRelativeTo = null, Expression<Func<int>> uIAGlobalMiddleMouseClickOnElementMaxElementsToSearch = null, Expression<Func<int>> uIAGlobalMiddleMouseClickOnElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIAGlobalMiddleMouseClickOnElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementElementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAGlobalMiddleMouseClickOnElementValidateClickablePointWithinElementBoundary = null)
        {
            var apiCallPath = "/UIAControl/GlobalMiddleMouseClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGlobalMiddleMouseClickOnElement = new JObject();
            var uIAGlobalMiddleMouseClickOnElementpropCount = 0;
            uIAGlobalMiddleMouseClickOnElementpropCount++;
            uIAGlobalMiddleMouseClickOnElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementParentWindowHandle);
            if (uIAGlobalMiddleMouseClickOnElementSearchElementName != null)
            {
                uIAGlobalMiddleMouseClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementSearchElementName);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementSearchElementClassName != null)
            {
                uIAGlobalMiddleMouseClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementSearchElementClassName);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementSearchElementAutomationId != null)
            {
                uIAGlobalMiddleMouseClickOnElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementSearchElementAutomationId);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementSearchLocalizedControlType != null)
            {
                uIAGlobalMiddleMouseClickOnElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementSearchLocalizedControlType);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementSearchSubTree != null)
            {
                uIAGlobalMiddleMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementSearchSubTree);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementFocusElementFirst != null)
            {
                uIAGlobalMiddleMouseClickOnElement["FocusElementFirst"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementFocusElementFirst);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementMatchIndex != null)
            {
                uIAGlobalMiddleMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementMatchIndex);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementSearchFilter != null)
            {
                uIAGlobalMiddleMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementSearchFilter);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementSortByColumn != null)
            {
                uIAGlobalMiddleMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementSortByColumn);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementMatchIndexAscending != null)
            {
                uIAGlobalMiddleMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementMatchIndexAscending);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementClickOffsetX != null)
            {
                uIAGlobalMiddleMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementClickOffsetX);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementClickOffsetY != null)
            {
                uIAGlobalMiddleMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementClickOffsetY);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementOffsetRelativeTo != null)
            {
                uIAGlobalMiddleMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementOffsetRelativeTo);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementMaxElementsToSearch != null)
            {
                uIAGlobalMiddleMouseClickOnElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementMaxElementsToSearch);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementMaxRelativeSearchDepth != null)
            {
                uIAGlobalMiddleMouseClickOnElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementMaxRelativeSearchDepth);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementMaxChildElementsToSearchPerNode != null)
            {
                uIAGlobalMiddleMouseClickOnElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementMaxChildElementsToSearchPerNode);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGlobalMiddleMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementElementLocalizedControlTypesNotToTraverse);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementValidateClickablePointWithinElementBoundary != null)
            {
                uIAGlobalMiddleMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementValidateClickablePointWithinElementBoundary);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            uIAGlobalMiddleMouseClickOnElementpropCount++;
            uIAGlobalMiddleMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementWorkflow);
            if (uIAGlobalMiddleMouseClickOnElementpropCount > 0)
            {
                callPayload.Body = uIAGlobalMiddleMouseClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalDoubleLeftMouseClickOnElement(Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementParentWindowHandle, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementWorkflow, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementSearchElementName = null, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementSearchElementClassName = null, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementSearchElementAutomationId = null, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementSearchLocalizedControlType = null, Expression<Func<bool>> uIAGlobalDoubleLeftMouseClickOnElementSearchSubTree = null, Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementDelayInMilliseconds = null, Expression<Func<bool>> uIAGlobalDoubleLeftMouseClickOnElementFocusElementFirst = null, Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementMatchIndex = null, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementSearchFilter = null, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementSortByColumn = null, Expression<Func<bool>> uIAGlobalDoubleLeftMouseClickOnElementMatchIndexAscending = null, Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementClickOffsetX = null, Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementClickOffsetY = null, Expression<Func<uIAGlobalDoubleLeftMouseClickOnElementOffsetRelativeToInput>> uIAGlobalDoubleLeftMouseClickOnElementOffsetRelativeTo = null, Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementMaxElementsToSearch = null, Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementElementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAGlobalDoubleLeftMouseClickOnElementValidateClickablePointWithinElementBoundary = null)
        {
            var apiCallPath = "/UIAControl/GlobalDoubleLeftMouseClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGlobalDoubleLeftMouseClickOnElement = new JObject();
            var uIAGlobalDoubleLeftMouseClickOnElementpropCount = 0;
            uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            uIAGlobalDoubleLeftMouseClickOnElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementParentWindowHandle);
            if (uIAGlobalDoubleLeftMouseClickOnElementSearchElementName != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementSearchElementName);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementSearchElementClassName != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementSearchElementClassName);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementSearchElementAutomationId != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementSearchElementAutomationId);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementSearchLocalizedControlType != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementSearchLocalizedControlType);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementSearchSubTree != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementSearchSubTree);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementDelayInMilliseconds != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["DelayInMilliseconds"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementDelayInMilliseconds);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementFocusElementFirst != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["FocusElementFirst"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementFocusElementFirst);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementMatchIndex != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementMatchIndex);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementSearchFilter != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementSearchFilter);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementSortByColumn != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementSortByColumn);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementMatchIndexAscending != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementMatchIndexAscending);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementClickOffsetX != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementClickOffsetX);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementClickOffsetY != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementClickOffsetY);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementOffsetRelativeTo != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementOffsetRelativeTo);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementMaxElementsToSearch != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementMaxElementsToSearch);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementMaxRelativeSearchDepth != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementMaxRelativeSearchDepth);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementMaxChildElementsToSearchPerNode != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementMaxChildElementsToSearchPerNode);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementElementLocalizedControlTypesNotToTraverse);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementValidateClickablePointWithinElementBoundary != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementValidateClickablePointWithinElementBoundary);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            uIAGlobalDoubleLeftMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementWorkflow);
            if (uIAGlobalDoubleLeftMouseClickOnElementpropCount > 0)
            {
                callPayload.Body = uIAGlobalDoubleLeftMouseClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIASelectElement(Expression<Func<int>> uIASelectElementParentWindowHandle, Expression<Func<string>> uIASelectElementWorkflow, Expression<Func<string>> uIASelectElementSearchElementName = null, Expression<Func<string>> uIASelectElementSearchElementClassName = null, Expression<Func<string>> uIASelectElementSearchElementAutomationId = null, Expression<Func<string>> uIASelectElementSearchLocalizedControlType = null, Expression<Func<bool>> uIASelectElementSearchSubTree = null, Expression<Func<int>> uIASelectElementMatchIndex = null, Expression<Func<string>> uIASelectElementSearchFilter = null, Expression<Func<string>> uIASelectElementSortByColumn = null, Expression<Func<bool>> uIASelectElementMatchIndexAscending = null, Expression<Func<int>> uIASelectElementMaxElementsToSearch = null, Expression<Func<int>> uIASelectElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIASelectElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIASelectElementElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/SelectElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIASelectElement = new JObject();
            var uIASelectElementpropCount = 0;
            uIASelectElementpropCount++;
            uIASelectElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIASelectElementParentWindowHandle);
            if (uIASelectElementSearchElementName != null)
            {
                uIASelectElement["SearchElementName"] = ExpressionConverter.ConvertO(uIASelectElementSearchElementName);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementSearchElementClassName != null)
            {
                uIASelectElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIASelectElementSearchElementClassName);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementSearchElementAutomationId != null)
            {
                uIASelectElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIASelectElementSearchElementAutomationId);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementSearchLocalizedControlType != null)
            {
                uIASelectElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIASelectElementSearchLocalizedControlType);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementSearchSubTree != null)
            {
                uIASelectElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIASelectElementSearchSubTree);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementMatchIndex != null)
            {
                uIASelectElement["MatchIndex"] = ExpressionConverter.ConvertO(uIASelectElementMatchIndex);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementSearchFilter != null)
            {
                uIASelectElement["SearchFilter"] = ExpressionConverter.ConvertO(uIASelectElementSearchFilter);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementSortByColumn != null)
            {
                uIASelectElement["SortByColumn"] = ExpressionConverter.ConvertO(uIASelectElementSortByColumn);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementMatchIndexAscending != null)
            {
                uIASelectElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIASelectElementMatchIndexAscending);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementMaxElementsToSearch != null)
            {
                uIASelectElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIASelectElementMaxElementsToSearch);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementMaxRelativeSearchDepth != null)
            {
                uIASelectElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIASelectElementMaxRelativeSearchDepth);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementMaxChildElementsToSearchPerNode != null)
            {
                uIASelectElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIASelectElementMaxChildElementsToSearchPerNode);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIASelectElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIASelectElementElementLocalizedControlTypesNotToTraverse);
                uIASelectElementpropCount++;
            }

            uIASelectElementpropCount++;
            uIASelectElement["Workflow"] = ExpressionConverter.ConvertO(uIASelectElementWorkflow);
            if (uIASelectElementpropCount > 0)
            {
                callPayload.Body = uIASelectElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAInputPasswordIntoElement(Expression<Func<int>> uIAInputPasswordIntoElementParentWindowHandle, Expression<Func<string>> uIAInputPasswordIntoElementPasswordToInput, Expression<Func<string>> uIAInputPasswordIntoElementWorkflow, Expression<Func<string>> uIAInputPasswordIntoElementSearchElementName = null, Expression<Func<string>> uIAInputPasswordIntoElementSearchElementClassName = null, Expression<Func<string>> uIAInputPasswordIntoElementSearchElementAutomationId = null, Expression<Func<string>> uIAInputPasswordIntoElementSearchLocalizedControlType = null, Expression<Func<bool>> uIAInputPasswordIntoElementSearchSubTree = null, Expression<Func<int>> uIAInputPasswordIntoElementMatchIndex = null, Expression<Func<string>> uIAInputPasswordIntoElementSearchFilter = null, Expression<Func<string>> uIAInputPasswordIntoElementSortByColumn = null, Expression<Func<bool>> uIAInputPasswordIntoElementMatchIndexAscending = null, Expression<Func<bool>> uIAInputPasswordIntoElementPasswordContainsStoredPassword = null, Expression<Func<int>> uIAInputPasswordIntoElementMaxElementsToSearch = null, Expression<Func<int>> uIAInputPasswordIntoElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIAInputPasswordIntoElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAInputPasswordIntoElementElementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAInputPasswordIntoElementTryValuePattern = null, Expression<Func<bool>> uIAInputPasswordIntoElementTryLegacyPattern = null)
        {
            var apiCallPath = "/UIAControl/InputPasswordIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAInputPasswordIntoElement = new JObject();
            var uIAInputPasswordIntoElementpropCount = 0;
            uIAInputPasswordIntoElementpropCount++;
            uIAInputPasswordIntoElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementParentWindowHandle);
            if (uIAInputPasswordIntoElementSearchElementName != null)
            {
                uIAInputPasswordIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementSearchElementName);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementSearchElementClassName != null)
            {
                uIAInputPasswordIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementSearchElementClassName);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementSearchElementAutomationId != null)
            {
                uIAInputPasswordIntoElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementSearchElementAutomationId);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementSearchLocalizedControlType != null)
            {
                uIAInputPasswordIntoElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementSearchLocalizedControlType);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementSearchSubTree != null)
            {
                uIAInputPasswordIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementSearchSubTree);
                uIAInputPasswordIntoElementpropCount++;
            }

            uIAInputPasswordIntoElementpropCount++;
            uIAInputPasswordIntoElement["PasswordToInput"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementPasswordToInput);
            if (uIAInputPasswordIntoElementMatchIndex != null)
            {
                uIAInputPasswordIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementMatchIndex);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementSearchFilter != null)
            {
                uIAInputPasswordIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementSearchFilter);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementSortByColumn != null)
            {
                uIAInputPasswordIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementSortByColumn);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementMatchIndexAscending != null)
            {
                uIAInputPasswordIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementMatchIndexAscending);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementPasswordContainsStoredPassword != null)
            {
                uIAInputPasswordIntoElement["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementPasswordContainsStoredPassword);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementMaxElementsToSearch != null)
            {
                uIAInputPasswordIntoElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementMaxElementsToSearch);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementMaxRelativeSearchDepth != null)
            {
                uIAInputPasswordIntoElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementMaxRelativeSearchDepth);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementMaxChildElementsToSearchPerNode != null)
            {
                uIAInputPasswordIntoElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementMaxChildElementsToSearchPerNode);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAInputPasswordIntoElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementElementLocalizedControlTypesNotToTraverse);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementTryValuePattern != null)
            {
                uIAInputPasswordIntoElement["TryValuePattern"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementTryValuePattern);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementTryLegacyPattern != null)
            {
                uIAInputPasswordIntoElement["TryLegacyPattern"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementTryLegacyPattern);
                uIAInputPasswordIntoElementpropCount++;
            }

            uIAInputPasswordIntoElementpropCount++;
            uIAInputPasswordIntoElement["Workflow"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementWorkflow);
            if (uIAInputPasswordIntoElementpropCount > 0)
            {
                callPayload.Body = uIAInputPasswordIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAInputTextIntoElement(Expression<Func<int>> uIAInputTextIntoElementParentWindowHandle, Expression<Func<string>> uIAInputTextIntoElementWorkflow, Expression<Func<string>> uIAInputTextIntoElementSearchElementName = null, Expression<Func<string>> uIAInputTextIntoElementSearchElementClassName = null, Expression<Func<string>> uIAInputTextIntoElementSearchElementAutomationId = null, Expression<Func<string>> uIAInputTextIntoElementSearchLocalizedControlType = null, Expression<Func<bool>> uIAInputTextIntoElementSearchSubTree = null, Expression<Func<string>> uIAInputTextIntoElementTextToInput = null, Expression<Func<int>> uIAInputTextIntoElementMatchIndex = null, Expression<Func<string>> uIAInputTextIntoElementSearchFilter = null, Expression<Func<string>> uIAInputTextIntoElementSortByColumn = null, Expression<Func<bool>> uIAInputTextIntoElementMatchIndexAscending = null, Expression<Func<bool>> uIAInputTextIntoElementReplaceExistingValue = null, Expression<Func<int>> uIAInputTextIntoElementInsertPosition = null, Expression<Func<int>> uIAInputTextIntoElementMaxElementsToSearch = null, Expression<Func<int>> uIAInputTextIntoElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIAInputTextIntoElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAInputTextIntoElementElementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAInputTextIntoElementRaiseExceptionIfInputValidationFails = null, Expression<Func<bool>> uIAInputTextIntoElementTryValuePattern = null, Expression<Func<bool>> uIAInputTextIntoElementTryLegacyPattern = null)
        {
            var apiCallPath = "/UIAControl/InputTextIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAInputTextIntoElement = new JObject();
            var uIAInputTextIntoElementpropCount = 0;
            uIAInputTextIntoElementpropCount++;
            uIAInputTextIntoElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementParentWindowHandle);
            if (uIAInputTextIntoElementSearchElementName != null)
            {
                uIAInputTextIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementSearchElementName);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementSearchElementClassName != null)
            {
                uIAInputTextIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementSearchElementClassName);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementSearchElementAutomationId != null)
            {
                uIAInputTextIntoElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementSearchElementAutomationId);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementSearchLocalizedControlType != null)
            {
                uIAInputTextIntoElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementSearchLocalizedControlType);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementSearchSubTree != null)
            {
                uIAInputTextIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementSearchSubTree);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementTextToInput != null)
            {
                uIAInputTextIntoElement["TextToInput"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementTextToInput);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementMatchIndex != null)
            {
                uIAInputTextIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementMatchIndex);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementSearchFilter != null)
            {
                uIAInputTextIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementSearchFilter);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementSortByColumn != null)
            {
                uIAInputTextIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementSortByColumn);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementMatchIndexAscending != null)
            {
                uIAInputTextIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementMatchIndexAscending);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementReplaceExistingValue != null)
            {
                uIAInputTextIntoElement["ReplaceExistingValue"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementReplaceExistingValue);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementInsertPosition != null)
            {
                uIAInputTextIntoElement["InsertPosition"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementInsertPosition);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementMaxElementsToSearch != null)
            {
                uIAInputTextIntoElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementMaxElementsToSearch);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementMaxRelativeSearchDepth != null)
            {
                uIAInputTextIntoElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementMaxRelativeSearchDepth);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementMaxChildElementsToSearchPerNode != null)
            {
                uIAInputTextIntoElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementMaxChildElementsToSearchPerNode);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAInputTextIntoElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementElementLocalizedControlTypesNotToTraverse);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementRaiseExceptionIfInputValidationFails != null)
            {
                uIAInputTextIntoElement["RaiseExceptionIfInputValidationFails"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementRaiseExceptionIfInputValidationFails);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementTryValuePattern != null)
            {
                uIAInputTextIntoElement["TryValuePattern"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementTryValuePattern);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementTryLegacyPattern != null)
            {
                uIAInputTextIntoElement["TryLegacyPattern"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementTryLegacyPattern);
                uIAInputTextIntoElementpropCount++;
            }

            uIAInputTextIntoElementpropCount++;
            uIAInputTextIntoElement["Workflow"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementWorkflow);
            if (uIAInputTextIntoElementpropCount > 0)
            {
                callPayload.Body = uIAInputTextIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAInputTextIntoMultipleElements(Expression<Func<string>> uIAInputTextIntoMultipleElementsInputElementsJSON, Expression<Func<string>> uIAInputTextIntoMultipleElementsWorkflow)
        {
            var apiCallPath = "/UIAControl/UIAInputTextIntoMultipleElements";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAInputTextIntoMultipleElements = new JObject();
            var uIAInputTextIntoMultipleElementspropCount = 0;
            uIAInputTextIntoMultipleElementspropCount++;
            uIAInputTextIntoMultipleElements["InputElementsJSON"] = ExpressionConverter.ConvertO(uIAInputTextIntoMultipleElementsInputElementsJSON);
            uIAInputTextIntoMultipleElementspropCount++;
            uIAInputTextIntoMultipleElements["Workflow"] = ExpressionConverter.ConvertO(uIAInputTextIntoMultipleElementsWorkflow);
            if (uIAInputTextIntoMultipleElementspropCount > 0)
            {
                callPayload.Body = uIAInputTextIntoMultipleElements;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAInputReturnIntoElement(Expression<Func<int>> uIAInputReturnIntoElementParentWindowHandle, Expression<Func<string>> uIAInputReturnIntoElementWorkflow, Expression<Func<string>> uIAInputReturnIntoElementSearchElementName = null, Expression<Func<string>> uIAInputReturnIntoElementSearchElementClassName = null, Expression<Func<string>> uIAInputReturnIntoElementSearchElementAutomationId = null, Expression<Func<string>> uIAInputReturnIntoElementSearchLocalizedControlType = null, Expression<Func<bool>> uIAInputReturnIntoElementSearchSubTree = null, Expression<Func<int>> uIAInputReturnIntoElementMatchIndex = null, Expression<Func<string>> uIAInputReturnIntoElementSearchFilter = null, Expression<Func<string>> uIAInputReturnIntoElementSortByColumn = null, Expression<Func<bool>> uIAInputReturnIntoElementMatchIndexAscending = null, Expression<Func<bool>> uIAInputReturnIntoElementReplaceExistingValue = null, Expression<Func<int>> uIAInputReturnIntoElementInsertPosition = null, Expression<Func<int>> uIAInputReturnIntoElementMaxElementsToSearch = null, Expression<Func<int>> uIAInputReturnIntoElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIAInputReturnIntoElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAInputReturnIntoElementElementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAInputReturnIntoElementRaiseExceptionIfInputValidationFails = null, Expression<Func<bool>> uIAInputReturnIntoElementTryValuePattern = null, Expression<Func<bool>> uIAInputReturnIntoElementTryLegacyPattern = null)
        {
            var apiCallPath = "/UIAControl/InputReturnIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAInputReturnIntoElement = new JObject();
            var uIAInputReturnIntoElementpropCount = 0;
            uIAInputReturnIntoElementpropCount++;
            uIAInputReturnIntoElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementParentWindowHandle);
            if (uIAInputReturnIntoElementSearchElementName != null)
            {
                uIAInputReturnIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementSearchElementName);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementSearchElementClassName != null)
            {
                uIAInputReturnIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementSearchElementClassName);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementSearchElementAutomationId != null)
            {
                uIAInputReturnIntoElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementSearchElementAutomationId);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementSearchLocalizedControlType != null)
            {
                uIAInputReturnIntoElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementSearchLocalizedControlType);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementSearchSubTree != null)
            {
                uIAInputReturnIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementSearchSubTree);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementMatchIndex != null)
            {
                uIAInputReturnIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementMatchIndex);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementSearchFilter != null)
            {
                uIAInputReturnIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementSearchFilter);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementSortByColumn != null)
            {
                uIAInputReturnIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementSortByColumn);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementMatchIndexAscending != null)
            {
                uIAInputReturnIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementMatchIndexAscending);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementReplaceExistingValue != null)
            {
                uIAInputReturnIntoElement["ReplaceExistingValue"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementReplaceExistingValue);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementInsertPosition != null)
            {
                uIAInputReturnIntoElement["InsertPosition"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementInsertPosition);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementMaxElementsToSearch != null)
            {
                uIAInputReturnIntoElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementMaxElementsToSearch);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementMaxRelativeSearchDepth != null)
            {
                uIAInputReturnIntoElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementMaxRelativeSearchDepth);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementMaxChildElementsToSearchPerNode != null)
            {
                uIAInputReturnIntoElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementMaxChildElementsToSearchPerNode);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAInputReturnIntoElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementElementLocalizedControlTypesNotToTraverse);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementRaiseExceptionIfInputValidationFails != null)
            {
                uIAInputReturnIntoElement["RaiseExceptionIfInputValidationFails"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementRaiseExceptionIfInputValidationFails);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementTryValuePattern != null)
            {
                uIAInputReturnIntoElement["TryValuePattern"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementTryValuePattern);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementTryLegacyPattern != null)
            {
                uIAInputReturnIntoElement["TryLegacyPattern"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementTryLegacyPattern);
                uIAInputReturnIntoElementpropCount++;
            }

            uIAInputReturnIntoElementpropCount++;
            uIAInputReturnIntoElement["Workflow"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementWorkflow);
            if (uIAInputReturnIntoElementpropCount > 0)
            {
                callPayload.Body = uIAInputReturnIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAFocusElement(Expression<Func<int>> uIAFocusElementParentWindowHandle, Expression<Func<string>> uIAFocusElementWorkflow, Expression<Func<string>> uIAFocusElementSearchElementName = null, Expression<Func<string>> uIAFocusElementSearchElementClassName = null, Expression<Func<string>> uIAFocusElementSearchElementAutomationId = null, Expression<Func<string>> uIAFocusElementSearchLocalizedControlType = null, Expression<Func<bool>> uIAFocusElementSearchSubTree = null, Expression<Func<int>> uIAFocusElementMatchIndex = null, Expression<Func<string>> uIAFocusElementSearchFilter = null, Expression<Func<string>> uIAFocusElementSortByColumn = null, Expression<Func<bool>> uIAFocusElementMatchIndexAscending = null, Expression<Func<int>> uIAFocusElementMaxElementsToSearch = null, Expression<Func<int>> uIAFocusElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIAFocusElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAFocusElementElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/FocusElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAFocusElement = new JObject();
            var uIAFocusElementpropCount = 0;
            uIAFocusElementpropCount++;
            uIAFocusElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAFocusElementParentWindowHandle);
            if (uIAFocusElementSearchElementName != null)
            {
                uIAFocusElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAFocusElementSearchElementName);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementSearchElementClassName != null)
            {
                uIAFocusElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAFocusElementSearchElementClassName);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementSearchElementAutomationId != null)
            {
                uIAFocusElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAFocusElementSearchElementAutomationId);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementSearchLocalizedControlType != null)
            {
                uIAFocusElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAFocusElementSearchLocalizedControlType);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementSearchSubTree != null)
            {
                uIAFocusElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAFocusElementSearchSubTree);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementMatchIndex != null)
            {
                uIAFocusElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAFocusElementMatchIndex);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementSearchFilter != null)
            {
                uIAFocusElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAFocusElementSearchFilter);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementSortByColumn != null)
            {
                uIAFocusElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAFocusElementSortByColumn);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementMatchIndexAscending != null)
            {
                uIAFocusElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAFocusElementMatchIndexAscending);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementMaxElementsToSearch != null)
            {
                uIAFocusElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAFocusElementMaxElementsToSearch);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementMaxRelativeSearchDepth != null)
            {
                uIAFocusElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAFocusElementMaxRelativeSearchDepth);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementMaxChildElementsToSearchPerNode != null)
            {
                uIAFocusElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAFocusElementMaxChildElementsToSearchPerNode);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAFocusElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAFocusElementElementLocalizedControlTypesNotToTraverse);
                uIAFocusElementpropCount++;
            }

            uIAFocusElementpropCount++;
            uIAFocusElement["Workflow"] = ExpressionConverter.ConvertO(uIAFocusElementWorkflow);
            if (uIAFocusElementpropCount > 0)
            {
                callPayload.Body = uIAFocusElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAToggleElement(Expression<Func<int>> uIAToggleElementParentWindowHandle, Expression<Func<string>> uIAToggleElementWorkflow, Expression<Func<string>> uIAToggleElementSearchElementName = null, Expression<Func<string>> uIAToggleElementSearchElementClassName = null, Expression<Func<string>> uIAToggleElementSearchElementAutomationId = null, Expression<Func<string>> uIAToggleElementSearchLocalizedControlType = null, Expression<Func<bool>> uIAToggleElementSearchSubTree = null, Expression<Func<int>> uIAToggleElementMatchIndex = null, Expression<Func<string>> uIAToggleElementSearchFilter = null, Expression<Func<string>> uIAToggleElementSortByColumn = null, Expression<Func<bool>> uIAToggleElementMatchIndexAscending = null, Expression<Func<int>> uIAToggleElementMaxElementsToSearch = null, Expression<Func<int>> uIAToggleElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIAToggleElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAToggleElementElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/ToggleElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAToggleElement = new JObject();
            var uIAToggleElementpropCount = 0;
            uIAToggleElementpropCount++;
            uIAToggleElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAToggleElementParentWindowHandle);
            if (uIAToggleElementSearchElementName != null)
            {
                uIAToggleElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAToggleElementSearchElementName);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementSearchElementClassName != null)
            {
                uIAToggleElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAToggleElementSearchElementClassName);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementSearchElementAutomationId != null)
            {
                uIAToggleElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAToggleElementSearchElementAutomationId);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementSearchLocalizedControlType != null)
            {
                uIAToggleElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAToggleElementSearchLocalizedControlType);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementSearchSubTree != null)
            {
                uIAToggleElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAToggleElementSearchSubTree);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementMatchIndex != null)
            {
                uIAToggleElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAToggleElementMatchIndex);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementSearchFilter != null)
            {
                uIAToggleElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAToggleElementSearchFilter);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementSortByColumn != null)
            {
                uIAToggleElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAToggleElementSortByColumn);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementMatchIndexAscending != null)
            {
                uIAToggleElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAToggleElementMatchIndexAscending);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementMaxElementsToSearch != null)
            {
                uIAToggleElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAToggleElementMaxElementsToSearch);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementMaxRelativeSearchDepth != null)
            {
                uIAToggleElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAToggleElementMaxRelativeSearchDepth);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementMaxChildElementsToSearchPerNode != null)
            {
                uIAToggleElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAToggleElementMaxChildElementsToSearchPerNode);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAToggleElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAToggleElementElementLocalizedControlTypesNotToTraverse);
                uIAToggleElementpropCount++;
            }

            uIAToggleElementpropCount++;
            uIAToggleElement["Workflow"] = ExpressionConverter.ConvertO(uIAToggleElementWorkflow);
            if (uIAToggleElementpropCount > 0)
            {
                callPayload.Body = uIAToggleElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIACheckElement(Expression<Func<int>> uIACheckElementParentWindowHandle, Expression<Func<string>> uIACheckElementWorkflow, Expression<Func<string>> uIACheckElementSearchElementName = null, Expression<Func<string>> uIACheckElementSearchElementClassName = null, Expression<Func<string>> uIACheckElementSearchElementAutomationId = null, Expression<Func<string>> uIACheckElementSearchLocalizedControlType = null, Expression<Func<bool>> uIACheckElementSearchSubTree = null, Expression<Func<bool>> uIACheckElementCheckElement = null, Expression<Func<int>> uIACheckElementMatchIndex = null, Expression<Func<string>> uIACheckElementSearchFilter = null, Expression<Func<string>> uIACheckElementSortByColumn = null, Expression<Func<bool>> uIACheckElementMatchIndexAscending = null, Expression<Func<int>> uIACheckElementMaxElementsToSearch = null, Expression<Func<int>> uIACheckElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIACheckElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIACheckElementElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/CheckElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIACheckElement = new JObject();
            var uIACheckElementpropCount = 0;
            uIACheckElementpropCount++;
            uIACheckElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIACheckElementParentWindowHandle);
            if (uIACheckElementSearchElementName != null)
            {
                uIACheckElement["SearchElementName"] = ExpressionConverter.ConvertO(uIACheckElementSearchElementName);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementSearchElementClassName != null)
            {
                uIACheckElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIACheckElementSearchElementClassName);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementSearchElementAutomationId != null)
            {
                uIACheckElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIACheckElementSearchElementAutomationId);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementSearchLocalizedControlType != null)
            {
                uIACheckElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIACheckElementSearchLocalizedControlType);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementSearchSubTree != null)
            {
                uIACheckElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIACheckElementSearchSubTree);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementCheckElement != null)
            {
                uIACheckElement["CheckElement"] = ExpressionConverter.ConvertO(uIACheckElementCheckElement);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementMatchIndex != null)
            {
                uIACheckElement["MatchIndex"] = ExpressionConverter.ConvertO(uIACheckElementMatchIndex);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementSearchFilter != null)
            {
                uIACheckElement["SearchFilter"] = ExpressionConverter.ConvertO(uIACheckElementSearchFilter);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementSortByColumn != null)
            {
                uIACheckElement["SortByColumn"] = ExpressionConverter.ConvertO(uIACheckElementSortByColumn);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementMatchIndexAscending != null)
            {
                uIACheckElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIACheckElementMatchIndexAscending);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementMaxElementsToSearch != null)
            {
                uIACheckElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIACheckElementMaxElementsToSearch);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementMaxRelativeSearchDepth != null)
            {
                uIACheckElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIACheckElementMaxRelativeSearchDepth);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementMaxChildElementsToSearchPerNode != null)
            {
                uIACheckElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIACheckElementMaxChildElementsToSearchPerNode);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIACheckElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIACheckElementElementLocalizedControlTypesNotToTraverse);
                uIACheckElementpropCount++;
            }

            uIACheckElementpropCount++;
            uIACheckElement["Workflow"] = ExpressionConverter.ConvertO(uIACheckElementWorkflow);
            if (uIACheckElementpropCount > 0)
            {
                callPayload.Body = uIACheckElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIACheckMultipleElements(Expression<Func<string>> uIACheckMultipleElementsInputElementsJSON, Expression<Func<string>> uIACheckMultipleElementsWorkflow)
        {
            var apiCallPath = "/UIAControl/UIACheckMultipleElements";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIACheckMultipleElements = new JObject();
            var uIACheckMultipleElementspropCount = 0;
            uIACheckMultipleElementspropCount++;
            uIACheckMultipleElements["InputElementsJSON"] = ExpressionConverter.ConvertO(uIACheckMultipleElementsInputElementsJSON);
            uIACheckMultipleElementspropCount++;
            uIACheckMultipleElements["Workflow"] = ExpressionConverter.ConvertO(uIACheckMultipleElementsWorkflow);
            if (uIACheckMultipleElementspropCount > 0)
            {
                callPayload.Body = uIACheckMultipleElements;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAIsElementCheckedResponse> UIAIsElementChecked(Expression<Func<int>> uIAIsElementCheckedParentWindowHandle, Expression<Func<string>> uIAIsElementCheckedWorkflow, Expression<Func<string>> uIAIsElementCheckedSearchElementName = null, Expression<Func<string>> uIAIsElementCheckedSearchElementClassName = null, Expression<Func<string>> uIAIsElementCheckedSearchElementAutomationId = null, Expression<Func<string>> uIAIsElementCheckedSearchLocalizedControlType = null, Expression<Func<bool>> uIAIsElementCheckedSearchSubTree = null, Expression<Func<int>> uIAIsElementCheckedMatchIndex = null, Expression<Func<string>> uIAIsElementCheckedSearchFilter = null, Expression<Func<string>> uIAIsElementCheckedSortByColumn = null, Expression<Func<bool>> uIAIsElementCheckedMatchIndexAscending = null, Expression<Func<int>> uIAIsElementCheckedMaxElementsToSearch = null, Expression<Func<int>> uIAIsElementCheckedMaxRelativeSearchDepth = null, Expression<Func<int>> uIAIsElementCheckedMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAIsElementCheckedElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/UIAIsElementChecked";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAIsElementChecked = new JObject();
            var uIAIsElementCheckedpropCount = 0;
            uIAIsElementCheckedpropCount++;
            uIAIsElementChecked["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAIsElementCheckedParentWindowHandle);
            if (uIAIsElementCheckedSearchElementName != null)
            {
                uIAIsElementChecked["SearchElementName"] = ExpressionConverter.ConvertO(uIAIsElementCheckedSearchElementName);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedSearchElementClassName != null)
            {
                uIAIsElementChecked["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAIsElementCheckedSearchElementClassName);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedSearchElementAutomationId != null)
            {
                uIAIsElementChecked["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAIsElementCheckedSearchElementAutomationId);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedSearchLocalizedControlType != null)
            {
                uIAIsElementChecked["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAIsElementCheckedSearchLocalizedControlType);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedSearchSubTree != null)
            {
                uIAIsElementChecked["SearchSubTree"] = ExpressionConverter.ConvertO(uIAIsElementCheckedSearchSubTree);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedMatchIndex != null)
            {
                uIAIsElementChecked["MatchIndex"] = ExpressionConverter.ConvertO(uIAIsElementCheckedMatchIndex);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedSearchFilter != null)
            {
                uIAIsElementChecked["SearchFilter"] = ExpressionConverter.ConvertO(uIAIsElementCheckedSearchFilter);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedSortByColumn != null)
            {
                uIAIsElementChecked["SortByColumn"] = ExpressionConverter.ConvertO(uIAIsElementCheckedSortByColumn);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedMatchIndexAscending != null)
            {
                uIAIsElementChecked["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAIsElementCheckedMatchIndexAscending);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedMaxElementsToSearch != null)
            {
                uIAIsElementChecked["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAIsElementCheckedMaxElementsToSearch);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedMaxRelativeSearchDepth != null)
            {
                uIAIsElementChecked["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAIsElementCheckedMaxRelativeSearchDepth);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedMaxChildElementsToSearchPerNode != null)
            {
                uIAIsElementChecked["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAIsElementCheckedMaxChildElementsToSearchPerNode);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAIsElementChecked["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAIsElementCheckedElementLocalizedControlTypesNotToTraverse);
                uIAIsElementCheckedpropCount++;
            }

            uIAIsElementCheckedpropCount++;
            uIAIsElementChecked["Workflow"] = ExpressionConverter.ConvertO(uIAIsElementCheckedWorkflow);
            if (uIAIsElementCheckedpropCount > 0)
            {
                callPayload.Body = uIAIsElementChecked;
            }

            return new ApiConnectionAction<UIAIsElementCheckedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIACloseElementWindow(Expression<Func<int>> uIACloseElementWindowParentWindowHandle, Expression<Func<string>> uIACloseElementWindowWorkflow, Expression<Func<string>> uIACloseElementWindowSearchElementName = null, Expression<Func<string>> uIACloseElementWindowSearchElementClassName = null, Expression<Func<string>> uIACloseElementWindowSearchElementAutomationId = null, Expression<Func<string>> uIACloseElementWindowSearchLocalizedControlType = null, Expression<Func<bool>> uIACloseElementWindowSearchSubTree = null, Expression<Func<int>> uIACloseElementWindowMatchIndex = null, Expression<Func<string>> uIACloseElementWindowSearchFilter = null, Expression<Func<string>> uIACloseElementWindowSortByColumn = null, Expression<Func<bool>> uIACloseElementWindowMatchIndexAscending = null, Expression<Func<int>> uIACloseElementWindowMaxElementsToSearch = null, Expression<Func<int>> uIACloseElementWindowMaxRelativeSearchDepth = null, Expression<Func<int>> uIACloseElementWindowMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIACloseElementWindowElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/CloseElementWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIACloseElementWindow = new JObject();
            var uIACloseElementWindowpropCount = 0;
            uIACloseElementWindowpropCount++;
            uIACloseElementWindow["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIACloseElementWindowParentWindowHandle);
            if (uIACloseElementWindowSearchElementName != null)
            {
                uIACloseElementWindow["SearchElementName"] = ExpressionConverter.ConvertO(uIACloseElementWindowSearchElementName);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowSearchElementClassName != null)
            {
                uIACloseElementWindow["SearchElementClassName"] = ExpressionConverter.ConvertO(uIACloseElementWindowSearchElementClassName);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowSearchElementAutomationId != null)
            {
                uIACloseElementWindow["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIACloseElementWindowSearchElementAutomationId);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowSearchLocalizedControlType != null)
            {
                uIACloseElementWindow["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIACloseElementWindowSearchLocalizedControlType);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowSearchSubTree != null)
            {
                uIACloseElementWindow["SearchSubTree"] = ExpressionConverter.ConvertO(uIACloseElementWindowSearchSubTree);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowMatchIndex != null)
            {
                uIACloseElementWindow["MatchIndex"] = ExpressionConverter.ConvertO(uIACloseElementWindowMatchIndex);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowSearchFilter != null)
            {
                uIACloseElementWindow["SearchFilter"] = ExpressionConverter.ConvertO(uIACloseElementWindowSearchFilter);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowSortByColumn != null)
            {
                uIACloseElementWindow["SortByColumn"] = ExpressionConverter.ConvertO(uIACloseElementWindowSortByColumn);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowMatchIndexAscending != null)
            {
                uIACloseElementWindow["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIACloseElementWindowMatchIndexAscending);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowMaxElementsToSearch != null)
            {
                uIACloseElementWindow["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIACloseElementWindowMaxElementsToSearch);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowMaxRelativeSearchDepth != null)
            {
                uIACloseElementWindow["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIACloseElementWindowMaxRelativeSearchDepth);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowMaxChildElementsToSearchPerNode != null)
            {
                uIACloseElementWindow["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIACloseElementWindowMaxChildElementsToSearchPerNode);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowElementLocalizedControlTypesNotToTraverse != null)
            {
                uIACloseElementWindow["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIACloseElementWindowElementLocalizedControlTypesNotToTraverse);
                uIACloseElementWindowpropCount++;
            }

            uIACloseElementWindowpropCount++;
            uIACloseElementWindow["Workflow"] = ExpressionConverter.ConvertO(uIACloseElementWindowWorkflow);
            if (uIACloseElementWindowpropCount > 0)
            {
                callPayload.Body = uIACloseElementWindow;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementTextValueResponse> UIAGetElementTextValue(Expression<Func<int>> uIAGetElementTextValueParentWindowHandle, Expression<Func<string>> uIAGetElementTextValueWorkflow, Expression<Func<string>> uIAGetElementTextValueSearchElementName = null, Expression<Func<string>> uIAGetElementTextValueSearchElementClassName = null, Expression<Func<string>> uIAGetElementTextValueSearchElementAutomationId = null, Expression<Func<string>> uIAGetElementTextValueSearchLocalizedControlType = null, Expression<Func<bool>> uIAGetElementTextValueSearchSubTree = null, Expression<Func<int>> uIAGetElementTextValueMatchIndex = null, Expression<Func<string>> uIAGetElementTextValueSearchFilter = null, Expression<Func<string>> uIAGetElementTextValueSortByColumn = null, Expression<Func<bool>> uIAGetElementTextValueMatchIndexAscending = null, Expression<Func<int>> uIAGetElementTextValueMaxElementsToSearch = null, Expression<Func<int>> uIAGetElementTextValueMaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetElementTextValueMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetElementTextValueElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/GetElementTextValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetElementTextValue = new JObject();
            var uIAGetElementTextValuepropCount = 0;
            uIAGetElementTextValuepropCount++;
            uIAGetElementTextValue["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGetElementTextValueParentWindowHandle);
            if (uIAGetElementTextValueSearchElementName != null)
            {
                uIAGetElementTextValue["SearchElementName"] = ExpressionConverter.ConvertO(uIAGetElementTextValueSearchElementName);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValueSearchElementClassName != null)
            {
                uIAGetElementTextValue["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGetElementTextValueSearchElementClassName);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValueSearchElementAutomationId != null)
            {
                uIAGetElementTextValue["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGetElementTextValueSearchElementAutomationId);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValueSearchLocalizedControlType != null)
            {
                uIAGetElementTextValue["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetElementTextValueSearchLocalizedControlType);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValueSearchSubTree != null)
            {
                uIAGetElementTextValue["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetElementTextValueSearchSubTree);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValueMatchIndex != null)
            {
                uIAGetElementTextValue["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetElementTextValueMatchIndex);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValueSearchFilter != null)
            {
                uIAGetElementTextValue["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetElementTextValueSearchFilter);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValueSortByColumn != null)
            {
                uIAGetElementTextValue["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetElementTextValueSortByColumn);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValueMatchIndexAscending != null)
            {
                uIAGetElementTextValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetElementTextValueMatchIndexAscending);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValueMaxElementsToSearch != null)
            {
                uIAGetElementTextValue["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetElementTextValueMaxElementsToSearch);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValueMaxRelativeSearchDepth != null)
            {
                uIAGetElementTextValue["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetElementTextValueMaxRelativeSearchDepth);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValueMaxChildElementsToSearchPerNode != null)
            {
                uIAGetElementTextValue["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetElementTextValueMaxChildElementsToSearchPerNode);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValueElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetElementTextValue["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGetElementTextValueElementLocalizedControlTypesNotToTraverse);
                uIAGetElementTextValuepropCount++;
            }

            uIAGetElementTextValuepropCount++;
            uIAGetElementTextValue["Workflow"] = ExpressionConverter.ConvertO(uIAGetElementTextValueWorkflow);
            if (uIAGetElementTextValuepropCount > 0)
            {
                callPayload.Body = uIAGetElementTextValue;
            }

            return new ApiConnectionAction<UIAGetElementTextValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementValueResponse> UIAGetElementValue(Expression<Func<int>> uIAGetElementValueParentWindowHandle, Expression<Func<string>> uIAGetElementValueWorkflow, Expression<Func<string>> uIAGetElementValueSearchElementName = null, Expression<Func<string>> uIAGetElementValueSearchElementClassName = null, Expression<Func<string>> uIAGetElementValueSearchElementAutomationId = null, Expression<Func<string>> uIAGetElementValueSearchLocalizedControlType = null, Expression<Func<bool>> uIAGetElementValueSearchSubTree = null, Expression<Func<int>> uIAGetElementValueMatchIndex = null, Expression<Func<string>> uIAGetElementValueSearchFilter = null, Expression<Func<string>> uIAGetElementValueSortByColumn = null, Expression<Func<bool>> uIAGetElementValueMatchIndexAscending = null, Expression<Func<int>> uIAGetElementValueMaxElementsToSearch = null, Expression<Func<int>> uIAGetElementValueMaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetElementValueMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetElementValueElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/GetElementValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetElementValue = new JObject();
            var uIAGetElementValuepropCount = 0;
            uIAGetElementValuepropCount++;
            uIAGetElementValue["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGetElementValueParentWindowHandle);
            if (uIAGetElementValueSearchElementName != null)
            {
                uIAGetElementValue["SearchElementName"] = ExpressionConverter.ConvertO(uIAGetElementValueSearchElementName);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValueSearchElementClassName != null)
            {
                uIAGetElementValue["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGetElementValueSearchElementClassName);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValueSearchElementAutomationId != null)
            {
                uIAGetElementValue["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGetElementValueSearchElementAutomationId);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValueSearchLocalizedControlType != null)
            {
                uIAGetElementValue["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetElementValueSearchLocalizedControlType);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValueSearchSubTree != null)
            {
                uIAGetElementValue["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetElementValueSearchSubTree);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValueMatchIndex != null)
            {
                uIAGetElementValue["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetElementValueMatchIndex);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValueSearchFilter != null)
            {
                uIAGetElementValue["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetElementValueSearchFilter);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValueSortByColumn != null)
            {
                uIAGetElementValue["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetElementValueSortByColumn);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValueMatchIndexAscending != null)
            {
                uIAGetElementValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetElementValueMatchIndexAscending);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValueMaxElementsToSearch != null)
            {
                uIAGetElementValue["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetElementValueMaxElementsToSearch);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValueMaxRelativeSearchDepth != null)
            {
                uIAGetElementValue["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetElementValueMaxRelativeSearchDepth);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValueMaxChildElementsToSearchPerNode != null)
            {
                uIAGetElementValue["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetElementValueMaxChildElementsToSearchPerNode);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValueElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetElementValue["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGetElementValueElementLocalizedControlTypesNotToTraverse);
                uIAGetElementValuepropCount++;
            }

            uIAGetElementValuepropCount++;
            uIAGetElementValue["Workflow"] = ExpressionConverter.ConvertO(uIAGetElementValueWorkflow);
            if (uIAGetElementValuepropCount > 0)
            {
                callPayload.Body = uIAGetElementValue;
            }

            return new ApiConnectionAction<UIAGetElementValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementLabelValueResponse> UIAGetElementLabelValue(Expression<Func<int>> uIAGetElementLabelValueParentWindowHandle, Expression<Func<string>> uIAGetElementLabelValueWorkflow, Expression<Func<string>> uIAGetElementLabelValueSearchElementName = null, Expression<Func<string>> uIAGetElementLabelValueSearchElementClassName = null, Expression<Func<string>> uIAGetElementLabelValueSearchElementAutomationId = null, Expression<Func<string>> uIAGetElementLabelValueSearchLocalizedControlType = null, Expression<Func<bool>> uIAGetElementLabelValueSearchSubTree = null, Expression<Func<int>> uIAGetElementLabelValueMatchIndex = null, Expression<Func<string>> uIAGetElementLabelValueSearchFilter = null, Expression<Func<string>> uIAGetElementLabelValueSortByColumn = null, Expression<Func<bool>> uIAGetElementLabelValueMatchIndexAscending = null, Expression<Func<int>> uIAGetElementLabelValueMaxElementsToSearch = null, Expression<Func<int>> uIAGetElementLabelValueMaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetElementLabelValueMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetElementLabelValueElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/GetElementLabelValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetElementLabelValue = new JObject();
            var uIAGetElementLabelValuepropCount = 0;
            uIAGetElementLabelValuepropCount++;
            uIAGetElementLabelValue["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGetElementLabelValueParentWindowHandle);
            if (uIAGetElementLabelValueSearchElementName != null)
            {
                uIAGetElementLabelValue["SearchElementName"] = ExpressionConverter.ConvertO(uIAGetElementLabelValueSearchElementName);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValueSearchElementClassName != null)
            {
                uIAGetElementLabelValue["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGetElementLabelValueSearchElementClassName);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValueSearchElementAutomationId != null)
            {
                uIAGetElementLabelValue["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGetElementLabelValueSearchElementAutomationId);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValueSearchLocalizedControlType != null)
            {
                uIAGetElementLabelValue["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetElementLabelValueSearchLocalizedControlType);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValueSearchSubTree != null)
            {
                uIAGetElementLabelValue["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetElementLabelValueSearchSubTree);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValueMatchIndex != null)
            {
                uIAGetElementLabelValue["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetElementLabelValueMatchIndex);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValueSearchFilter != null)
            {
                uIAGetElementLabelValue["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetElementLabelValueSearchFilter);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValueSortByColumn != null)
            {
                uIAGetElementLabelValue["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetElementLabelValueSortByColumn);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValueMatchIndexAscending != null)
            {
                uIAGetElementLabelValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetElementLabelValueMatchIndexAscending);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValueMaxElementsToSearch != null)
            {
                uIAGetElementLabelValue["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetElementLabelValueMaxElementsToSearch);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValueMaxRelativeSearchDepth != null)
            {
                uIAGetElementLabelValue["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetElementLabelValueMaxRelativeSearchDepth);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValueMaxChildElementsToSearchPerNode != null)
            {
                uIAGetElementLabelValue["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetElementLabelValueMaxChildElementsToSearchPerNode);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValueElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetElementLabelValue["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGetElementLabelValueElementLocalizedControlTypesNotToTraverse);
                uIAGetElementLabelValuepropCount++;
            }

            uIAGetElementLabelValuepropCount++;
            uIAGetElementLabelValue["Workflow"] = ExpressionConverter.ConvertO(uIAGetElementLabelValueWorkflow);
            if (uIAGetElementLabelValuepropCount > 0)
            {
                callPayload.Body = uIAGetElementLabelValue;
            }

            return new ApiConnectionAction<UIAGetElementLabelValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementPropertiesResponse> UIAGetElementProperties(Expression<Func<int>> uIAGetElementPropertiesParentWindowHandle, Expression<Func<string>> uIAGetElementPropertiesWorkflow, Expression<Func<string>> uIAGetElementPropertiesSearchElementName = null, Expression<Func<string>> uIAGetElementPropertiesSearchElementClassName = null, Expression<Func<string>> uIAGetElementPropertiesSearchElementAutomationId = null, Expression<Func<string>> uIAGetElementPropertiesSearchLocalizedControlType = null, Expression<Func<bool>> uIAGetElementPropertiesSearchSubTree = null, Expression<Func<bool>> uIAGetElementPropertiesReturnElementHandle = null, Expression<Func<bool>> uIAGetElementPropertiesReturnElementValue = null, Expression<Func<int>> uIAGetElementPropertiesMatchIndex = null, Expression<Func<string>> uIAGetElementPropertiesSearchFilter = null, Expression<Func<string>> uIAGetElementPropertiesSortByColumn = null, Expression<Func<bool>> uIAGetElementPropertiesMatchIndexAscending = null, Expression<Func<int>> uIAGetElementPropertiesMaxElementsToSearch = null, Expression<Func<int>> uIAGetElementPropertiesMaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetElementPropertiesMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetElementPropertiesElementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAGetElementPropertiesValidateClickablePointWithinElementBoundary = null)
        {
            var apiCallPath = "/UIAControl/GetElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetElementProperties = new JObject();
            var uIAGetElementPropertiespropCount = 0;
            uIAGetElementPropertiespropCount++;
            uIAGetElementProperties["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesParentWindowHandle);
            if (uIAGetElementPropertiesSearchElementName != null)
            {
                uIAGetElementProperties["SearchElementName"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesSearchElementName);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesSearchElementClassName != null)
            {
                uIAGetElementProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesSearchElementClassName);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesSearchElementAutomationId != null)
            {
                uIAGetElementProperties["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesSearchElementAutomationId);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesSearchLocalizedControlType != null)
            {
                uIAGetElementProperties["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesSearchLocalizedControlType);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesSearchSubTree != null)
            {
                uIAGetElementProperties["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesSearchSubTree);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesReturnElementHandle != null)
            {
                uIAGetElementProperties["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesReturnElementHandle);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesReturnElementValue != null)
            {
                uIAGetElementProperties["ReturnElementValue"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesReturnElementValue);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesMatchIndex != null)
            {
                uIAGetElementProperties["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesMatchIndex);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesSearchFilter != null)
            {
                uIAGetElementProperties["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesSearchFilter);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesSortByColumn != null)
            {
                uIAGetElementProperties["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesSortByColumn);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesMatchIndexAscending != null)
            {
                uIAGetElementProperties["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesMatchIndexAscending);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesMaxElementsToSearch != null)
            {
                uIAGetElementProperties["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesMaxElementsToSearch);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesMaxRelativeSearchDepth != null)
            {
                uIAGetElementProperties["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesMaxRelativeSearchDepth);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesMaxChildElementsToSearchPerNode != null)
            {
                uIAGetElementProperties["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesMaxChildElementsToSearchPerNode);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetElementProperties["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesElementLocalizedControlTypesNotToTraverse);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesValidateClickablePointWithinElementBoundary != null)
            {
                uIAGetElementProperties["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesValidateClickablePointWithinElementBoundary);
                uIAGetElementPropertiespropCount++;
            }

            uIAGetElementPropertiespropCount++;
            uIAGetElementProperties["Workflow"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesWorkflow);
            if (uIAGetElementPropertiespropCount > 0)
            {
                callPayload.Body = uIAGetElementProperties;
            }

            return new ApiConnectionAction<UIAGetElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetMultipleElementPropertiesResponse> UIAGetMultipleElementProperties(Expression<Func<int>> uIAGetMultipleElementPropertiesParentWindowHandle, Expression<Func<string>> uIAGetMultipleElementPropertiesWorkflow, Expression<Func<string>> uIAGetMultipleElementPropertiesSearchElementLocalizedControlType = null, Expression<Func<bool>> uIAGetMultipleElementPropertiesSearchDescendants = null, Expression<Func<bool>> uIAGetMultipleElementPropertiesReturnElementHandle = null, Expression<Func<bool>> uIAGetMultipleElementPropertiesReturnElementValue = null, Expression<Func<int>> uIAGetMultipleElementPropertiesFirstItemToReturn = null, Expression<Func<int>> uIAGetMultipleElementPropertiesMaxItemsToReturn = null)
        {
            var apiCallPath = "/UIAControl/GetMultipleElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetMultipleElementProperties = new JObject();
            var uIAGetMultipleElementPropertiespropCount = 0;
            uIAGetMultipleElementPropertiespropCount++;
            uIAGetMultipleElementProperties["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGetMultipleElementPropertiesParentWindowHandle);
            if (uIAGetMultipleElementPropertiesSearchElementLocalizedControlType != null)
            {
                uIAGetMultipleElementProperties["SearchElementLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetMultipleElementPropertiesSearchElementLocalizedControlType);
                uIAGetMultipleElementPropertiespropCount++;
            }

            if (uIAGetMultipleElementPropertiesSearchDescendants != null)
            {
                uIAGetMultipleElementProperties["SearchDescendants"] = ExpressionConverter.ConvertO(uIAGetMultipleElementPropertiesSearchDescendants);
                uIAGetMultipleElementPropertiespropCount++;
            }

            if (uIAGetMultipleElementPropertiesReturnElementHandle != null)
            {
                uIAGetMultipleElementProperties["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIAGetMultipleElementPropertiesReturnElementHandle);
                uIAGetMultipleElementPropertiespropCount++;
            }

            if (uIAGetMultipleElementPropertiesReturnElementValue != null)
            {
                uIAGetMultipleElementProperties["ReturnElementValue"] = ExpressionConverter.ConvertO(uIAGetMultipleElementPropertiesReturnElementValue);
                uIAGetMultipleElementPropertiespropCount++;
            }

            if (uIAGetMultipleElementPropertiesFirstItemToReturn != null)
            {
                uIAGetMultipleElementProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(uIAGetMultipleElementPropertiesFirstItemToReturn);
                uIAGetMultipleElementPropertiespropCount++;
            }

            if (uIAGetMultipleElementPropertiesMaxItemsToReturn != null)
            {
                uIAGetMultipleElementProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(uIAGetMultipleElementPropertiesMaxItemsToReturn);
                uIAGetMultipleElementPropertiespropCount++;
            }

            uIAGetMultipleElementPropertiespropCount++;
            uIAGetMultipleElementProperties["Workflow"] = ExpressionConverter.ConvertO(uIAGetMultipleElementPropertiesWorkflow);
            if (uIAGetMultipleElementPropertiespropCount > 0)
            {
                callPayload.Body = uIAGetMultipleElementProperties;
            }

            return new ApiConnectionAction<UIAGetMultipleElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetDesktopElementsResponse> UIAGetDesktopElements(Expression<Func<string>> uIAGetDesktopElementsWorkflow, Expression<Func<string>> uIAGetDesktopElementsSearchElementLocalizedControlType = null, Expression<Func<int>> uIAGetDesktopElementsSearchProcessID = null, Expression<Func<bool>> uIAGetDesktopElementsReturnElementHandle = null, Expression<Func<int>> uIAGetDesktopElementsFirstItemToReturn = null, Expression<Func<int>> uIAGetDesktopElementsMaxItemsToReturn = null, Expression<Func<bool>> uIAGetDesktopElementsIncludeChildProcesses = null)
        {
            var apiCallPath = "/UIAControl/GetDesktopElements";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetDesktopElements = new JObject();
            var uIAGetDesktopElementspropCount = 0;
            if (uIAGetDesktopElementsSearchElementLocalizedControlType != null)
            {
                uIAGetDesktopElements["SearchElementLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetDesktopElementsSearchElementLocalizedControlType);
                uIAGetDesktopElementspropCount++;
            }

            if (uIAGetDesktopElementsSearchProcessID != null)
            {
                uIAGetDesktopElements["SearchProcessID"] = ExpressionConverter.ConvertO(uIAGetDesktopElementsSearchProcessID);
                uIAGetDesktopElementspropCount++;
            }

            if (uIAGetDesktopElementsReturnElementHandle != null)
            {
                uIAGetDesktopElements["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIAGetDesktopElementsReturnElementHandle);
                uIAGetDesktopElementspropCount++;
            }

            if (uIAGetDesktopElementsFirstItemToReturn != null)
            {
                uIAGetDesktopElements["FirstItemToReturn"] = ExpressionConverter.ConvertO(uIAGetDesktopElementsFirstItemToReturn);
                uIAGetDesktopElementspropCount++;
            }

            if (uIAGetDesktopElementsMaxItemsToReturn != null)
            {
                uIAGetDesktopElements["MaxItemsToReturn"] = ExpressionConverter.ConvertO(uIAGetDesktopElementsMaxItemsToReturn);
                uIAGetDesktopElementspropCount++;
            }

            if (uIAGetDesktopElementsIncludeChildProcesses != null)
            {
                uIAGetDesktopElements["IncludeChildProcesses"] = ExpressionConverter.ConvertO(uIAGetDesktopElementsIncludeChildProcesses);
                uIAGetDesktopElementspropCount++;
            }

            uIAGetDesktopElementspropCount++;
            uIAGetDesktopElements["Workflow"] = ExpressionConverter.ConvertO(uIAGetDesktopElementsWorkflow);
            if (uIAGetDesktopElementspropCount > 0)
            {
                callPayload.Body = uIAGetDesktopElements;
            }

            return new ApiConnectionAction<UIAGetDesktopElementsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAExpandElement(Expression<Func<int>> uIAExpandElementParentWindowHandle, Expression<Func<string>> uIAExpandElementWorkflow, Expression<Func<string>> uIAExpandElementSearchElementName = null, Expression<Func<string>> uIAExpandElementSearchElementClassName = null, Expression<Func<string>> uIAExpandElementSearchElementAutomationId = null, Expression<Func<string>> uIAExpandElementSearchLocalizedControlType = null, Expression<Func<bool>> uIAExpandElementSearchSubTree = null, Expression<Func<int>> uIAExpandElementMatchIndex = null, Expression<Func<string>> uIAExpandElementSearchFilter = null, Expression<Func<string>> uIAExpandElementSortByColumn = null, Expression<Func<bool>> uIAExpandElementMatchIndexAscending = null, Expression<Func<int>> uIAExpandElementMaxElementsToSearch = null, Expression<Func<int>> uIAExpandElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIAExpandElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAExpandElementElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/ExpandElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAExpandElement = new JObject();
            var uIAExpandElementpropCount = 0;
            uIAExpandElementpropCount++;
            uIAExpandElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAExpandElementParentWindowHandle);
            if (uIAExpandElementSearchElementName != null)
            {
                uIAExpandElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAExpandElementSearchElementName);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementSearchElementClassName != null)
            {
                uIAExpandElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAExpandElementSearchElementClassName);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementSearchElementAutomationId != null)
            {
                uIAExpandElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAExpandElementSearchElementAutomationId);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementSearchLocalizedControlType != null)
            {
                uIAExpandElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAExpandElementSearchLocalizedControlType);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementSearchSubTree != null)
            {
                uIAExpandElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAExpandElementSearchSubTree);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementMatchIndex != null)
            {
                uIAExpandElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAExpandElementMatchIndex);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementSearchFilter != null)
            {
                uIAExpandElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAExpandElementSearchFilter);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementSortByColumn != null)
            {
                uIAExpandElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAExpandElementSortByColumn);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementMatchIndexAscending != null)
            {
                uIAExpandElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAExpandElementMatchIndexAscending);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementMaxElementsToSearch != null)
            {
                uIAExpandElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAExpandElementMaxElementsToSearch);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementMaxRelativeSearchDepth != null)
            {
                uIAExpandElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAExpandElementMaxRelativeSearchDepth);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementMaxChildElementsToSearchPerNode != null)
            {
                uIAExpandElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAExpandElementMaxChildElementsToSearchPerNode);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAExpandElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAExpandElementElementLocalizedControlTypesNotToTraverse);
                uIAExpandElementpropCount++;
            }

            uIAExpandElementpropCount++;
            uIAExpandElement["Workflow"] = ExpressionConverter.ConvertO(uIAExpandElementWorkflow);
            if (uIAExpandElementpropCount > 0)
            {
                callPayload.Body = uIAExpandElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIACollapseElement(Expression<Func<int>> uIACollapseElementParentWindowHandle, Expression<Func<string>> uIACollapseElementWorkflow, Expression<Func<string>> uIACollapseElementSearchElementName = null, Expression<Func<string>> uIACollapseElementSearchElementClassName = null, Expression<Func<string>> uIACollapseElementSearchElementAutomationId = null, Expression<Func<string>> uIACollapseElementSearchLocalizedControlType = null, Expression<Func<bool>> uIACollapseElementSearchSubTree = null, Expression<Func<int>> uIACollapseElementMatchIndex = null, Expression<Func<string>> uIACollapseElementSearchFilter = null, Expression<Func<string>> uIACollapseElementSortByColumn = null, Expression<Func<bool>> uIACollapseElementMatchIndexAscending = null, Expression<Func<int>> uIACollapseElementMaxElementsToSearch = null, Expression<Func<int>> uIACollapseElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIACollapseElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIACollapseElementElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/CollapseElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIACollapseElement = new JObject();
            var uIACollapseElementpropCount = 0;
            uIACollapseElementpropCount++;
            uIACollapseElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIACollapseElementParentWindowHandle);
            if (uIACollapseElementSearchElementName != null)
            {
                uIACollapseElement["SearchElementName"] = ExpressionConverter.ConvertO(uIACollapseElementSearchElementName);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementSearchElementClassName != null)
            {
                uIACollapseElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIACollapseElementSearchElementClassName);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementSearchElementAutomationId != null)
            {
                uIACollapseElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIACollapseElementSearchElementAutomationId);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementSearchLocalizedControlType != null)
            {
                uIACollapseElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIACollapseElementSearchLocalizedControlType);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementSearchSubTree != null)
            {
                uIACollapseElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIACollapseElementSearchSubTree);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementMatchIndex != null)
            {
                uIACollapseElement["MatchIndex"] = ExpressionConverter.ConvertO(uIACollapseElementMatchIndex);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementSearchFilter != null)
            {
                uIACollapseElement["SearchFilter"] = ExpressionConverter.ConvertO(uIACollapseElementSearchFilter);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementSortByColumn != null)
            {
                uIACollapseElement["SortByColumn"] = ExpressionConverter.ConvertO(uIACollapseElementSortByColumn);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementMatchIndexAscending != null)
            {
                uIACollapseElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIACollapseElementMatchIndexAscending);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementMaxElementsToSearch != null)
            {
                uIACollapseElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIACollapseElementMaxElementsToSearch);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementMaxRelativeSearchDepth != null)
            {
                uIACollapseElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIACollapseElementMaxRelativeSearchDepth);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementMaxChildElementsToSearchPerNode != null)
            {
                uIACollapseElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIACollapseElementMaxChildElementsToSearchPerNode);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIACollapseElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIACollapseElementElementLocalizedControlTypesNotToTraverse);
                uIACollapseElementpropCount++;
            }

            uIACollapseElementpropCount++;
            uIACollapseElement["Workflow"] = ExpressionConverter.ConvertO(uIACollapseElementWorkflow);
            if (uIACollapseElementpropCount > 0)
            {
                callPayload.Body = uIACollapseElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIATakeScreenShotOfElementLocationResponse> UIATakeScreenShotOfElementLocation(Expression<Func<int>> uIATakeScreenShotOfElementLocationParentWindowHandle, Expression<Func<string>> uIATakeScreenShotOfElementLocationWorkflow, Expression<Func<string>> uIATakeScreenShotOfElementLocationSearchElementName = null, Expression<Func<string>> uIATakeScreenShotOfElementLocationSearchElementClassName = null, Expression<Func<string>> uIATakeScreenShotOfElementLocationSearchElementAutomationId = null, Expression<Func<string>> uIATakeScreenShotOfElementLocationSearchLocalizedControlType = null, Expression<Func<bool>> uIATakeScreenShotOfElementLocationSearchSubTree = null, Expression<Func<uIATakeScreenShotOfElementLocationImageFormatInput>> uIATakeScreenShotOfElementLocationImageFormat = null, Expression<Func<int>> uIATakeScreenShotOfElementLocationMatchIndex = null, Expression<Func<string>> uIATakeScreenShotOfElementLocationSearchFilter = null, Expression<Func<string>> uIATakeScreenShotOfElementLocationSortByColumn = null, Expression<Func<bool>> uIATakeScreenShotOfElementLocationMatchIndexAscending = null, Expression<Func<bool>> uIATakeScreenShotOfElementLocationHideAgent = null, Expression<Func<int>> uIATakeScreenShotOfElementLocationMaxElementsToSearch = null, Expression<Func<int>> uIATakeScreenShotOfElementLocationMaxRelativeSearchDepth = null, Expression<Func<int>> uIATakeScreenShotOfElementLocationMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIATakeScreenShotOfElementLocationElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/TakeScreenShotOfElementLocation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIATakeScreenShotOfElementLocation = new JObject();
            var uIATakeScreenShotOfElementLocationpropCount = 0;
            uIATakeScreenShotOfElementLocationpropCount++;
            uIATakeScreenShotOfElementLocation["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationParentWindowHandle);
            if (uIATakeScreenShotOfElementLocationSearchElementName != null)
            {
                uIATakeScreenShotOfElementLocation["SearchElementName"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationSearchElementName);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationSearchElementClassName != null)
            {
                uIATakeScreenShotOfElementLocation["SearchElementClassName"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationSearchElementClassName);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationSearchElementAutomationId != null)
            {
                uIATakeScreenShotOfElementLocation["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationSearchElementAutomationId);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationSearchLocalizedControlType != null)
            {
                uIATakeScreenShotOfElementLocation["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationSearchLocalizedControlType);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationSearchSubTree != null)
            {
                uIATakeScreenShotOfElementLocation["SearchSubTree"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationSearchSubTree);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationImageFormat != null)
            {
                uIATakeScreenShotOfElementLocation["ImageFormat"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationImageFormat);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationMatchIndex != null)
            {
                uIATakeScreenShotOfElementLocation["MatchIndex"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationMatchIndex);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationSearchFilter != null)
            {
                uIATakeScreenShotOfElementLocation["SearchFilter"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationSearchFilter);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationSortByColumn != null)
            {
                uIATakeScreenShotOfElementLocation["SortByColumn"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationSortByColumn);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationMatchIndexAscending != null)
            {
                uIATakeScreenShotOfElementLocation["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationMatchIndexAscending);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationHideAgent != null)
            {
                uIATakeScreenShotOfElementLocation["HideAgent"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationHideAgent);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationMaxElementsToSearch != null)
            {
                uIATakeScreenShotOfElementLocation["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationMaxElementsToSearch);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationMaxRelativeSearchDepth != null)
            {
                uIATakeScreenShotOfElementLocation["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationMaxRelativeSearchDepth);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationMaxChildElementsToSearchPerNode != null)
            {
                uIATakeScreenShotOfElementLocation["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationMaxChildElementsToSearchPerNode);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationElementLocalizedControlTypesNotToTraverse != null)
            {
                uIATakeScreenShotOfElementLocation["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationElementLocalizedControlTypesNotToTraverse);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            uIATakeScreenShotOfElementLocationpropCount++;
            uIATakeScreenShotOfElementLocation["Workflow"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationWorkflow);
            if (uIATakeScreenShotOfElementLocationpropCount > 0)
            {
                callPayload.Body = uIATakeScreenShotOfElementLocation;
            }

            return new ApiConnectionAction<UIATakeScreenShotOfElementLocationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIADrawRectangleAroundElement(Expression<Func<int>> uIADrawRectangleAroundElementParentWindowHandle, Expression<Func<string>> uIADrawRectangleAroundElementWorkflow, Expression<Func<string>> uIADrawRectangleAroundElementSearchElementName = null, Expression<Func<string>> uIADrawRectangleAroundElementSearchElementClassName = null, Expression<Func<string>> uIADrawRectangleAroundElementSearchElementAutomationId = null, Expression<Func<string>> uIADrawRectangleAroundElementSearchLocalizedControlType = null, Expression<Func<bool>> uIADrawRectangleAroundElementSearchSubTree = null, Expression<Func<string>> uIADrawRectangleAroundElementPenColour = null, Expression<Func<int>> uIADrawRectangleAroundElementPenThicknessPixels = null, Expression<Func<int>> uIADrawRectangleAroundElementMatchIndex = null, Expression<Func<string>> uIADrawRectangleAroundElementSearchFilter = null, Expression<Func<string>> uIADrawRectangleAroundElementSortByColumn = null, Expression<Func<bool>> uIADrawRectangleAroundElementMatchIndexAscending = null, Expression<Func<int>> uIADrawRectangleAroundElementMaxElementsToSearch = null, Expression<Func<int>> uIADrawRectangleAroundElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIADrawRectangleAroundElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIADrawRectangleAroundElementElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/DrawRectangleAroundElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIADrawRectangleAroundElement = new JObject();
            var uIADrawRectangleAroundElementpropCount = 0;
            uIADrawRectangleAroundElementpropCount++;
            uIADrawRectangleAroundElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementParentWindowHandle);
            if (uIADrawRectangleAroundElementSearchElementName != null)
            {
                uIADrawRectangleAroundElement["SearchElementName"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementSearchElementName);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementSearchElementClassName != null)
            {
                uIADrawRectangleAroundElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementSearchElementClassName);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementSearchElementAutomationId != null)
            {
                uIADrawRectangleAroundElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementSearchElementAutomationId);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementSearchLocalizedControlType != null)
            {
                uIADrawRectangleAroundElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementSearchLocalizedControlType);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementSearchSubTree != null)
            {
                uIADrawRectangleAroundElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementSearchSubTree);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementPenColour != null)
            {
                uIADrawRectangleAroundElement["PenColour"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementPenColour);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementPenThicknessPixels != null)
            {
                uIADrawRectangleAroundElement["PenThicknessPixels"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementPenThicknessPixels);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementMatchIndex != null)
            {
                uIADrawRectangleAroundElement["MatchIndex"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementMatchIndex);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementSearchFilter != null)
            {
                uIADrawRectangleAroundElement["SearchFilter"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementSearchFilter);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementSortByColumn != null)
            {
                uIADrawRectangleAroundElement["SortByColumn"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementSortByColumn);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementMatchIndexAscending != null)
            {
                uIADrawRectangleAroundElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementMatchIndexAscending);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementMaxElementsToSearch != null)
            {
                uIADrawRectangleAroundElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementMaxElementsToSearch);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementMaxRelativeSearchDepth != null)
            {
                uIADrawRectangleAroundElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementMaxRelativeSearchDepth);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementMaxChildElementsToSearchPerNode != null)
            {
                uIADrawRectangleAroundElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementMaxChildElementsToSearchPerNode);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIADrawRectangleAroundElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementElementLocalizedControlTypesNotToTraverse);
                uIADrawRectangleAroundElementpropCount++;
            }

            uIADrawRectangleAroundElementpropCount++;
            uIADrawRectangleAroundElement["Workflow"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementWorkflow);
            if (uIADrawRectangleAroundElementpropCount > 0)
            {
                callPayload.Body = uIADrawRectangleAroundElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetParentElementHandleResponse> UIAGetParentElementHandle(Expression<Func<int>> uIAGetParentElementHandleElementHandle, Expression<Func<string>> uIAGetParentElementHandleWorkflow)
        {
            var apiCallPath = "/UIAControl/GetParentElementHandle";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetParentElementHandle = new JObject();
            var uIAGetParentElementHandlepropCount = 0;
            uIAGetParentElementHandlepropCount++;
            uIAGetParentElementHandle["ElementHandle"] = ExpressionConverter.ConvertO(uIAGetParentElementHandleElementHandle);
            uIAGetParentElementHandlepropCount++;
            uIAGetParentElementHandle["Workflow"] = ExpressionConverter.ConvertO(uIAGetParentElementHandleWorkflow);
            if (uIAGetParentElementHandlepropCount > 0)
            {
                callPayload.Body = uIAGetParentElementHandle;
            }

            return new ApiConnectionAction<UIAGetParentElementHandleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetDataGridElementContentsResponse> UIAGetDataGridElementContents(Expression<Func<string>> uIAGetDataGridElementContentsWorkflow, Expression<Func<int>> uIAGetDataGridElementContentsParentWindowHandle = null, Expression<Func<string>> uIAGetDataGridElementContentsSearchElementName = null, Expression<Func<string>> uIAGetDataGridElementContentsSearchElementClassName = null, Expression<Func<string>> uIAGetDataGridElementContentsSearchElementAutomationId = null, Expression<Func<string>> uIAGetDataGridElementContentsSearchLocalizedControlType = null, Expression<Func<bool>> uIAGetDataGridElementContentsSearchSubTree = null, Expression<Func<bool>> uIAGetDataGridElementContentsOnScreenColumnsOnly = null, Expression<Func<bool>> uIAGetDataGridElementContentsOnScreenRowsOnly = null, Expression<Func<bool>> uIAGetDataGridElementContentsReturnNullValuesAsBlank = null, Expression<Func<string>> uIAGetDataGridElementContentsAlternativeHeaderRowName = null, Expression<Func<bool>> uIAGetDataGridElementContentsReturnRowUIAName = null, Expression<Func<string>> uIAGetDataGridElementContentsNameOfColumnToStoreRowUIAName = null, Expression<Func<int>> uIAGetDataGridElementContentsMatchIndex = null, Expression<Func<string>> uIAGetDataGridElementContentsSearchFilter = null, Expression<Func<string>> uIAGetDataGridElementContentsSortByColumn = null, Expression<Func<bool>> uIAGetDataGridElementContentsMatchIndexAscending = null, Expression<Func<int>> uIAGetDataGridElementContentsFirstItemToReturn = null, Expression<Func<int>> uIAGetDataGridElementContentsMaxItemsToReturn = null, Expression<Func<int>> uIAGetDataGridElementContentsScanFirstNRowsForEmptyRows = null, Expression<Func<bool>> uIAGetDataGridElementContentsReadTableAsThread = null, Expression<Func<int>> uIAGetDataGridElementContentsRetrieveOutputDataFromThreadId = null, Expression<Func<int>> uIAGetDataGridElementContentsSecondsToWaitForThread = null, Expression<Func<int>> uIAGetDataGridElementContentsScrollDataGridVerticallyEveryNPercent = null, Expression<Func<int>> uIAGetDataGridElementContentsScrollDataGridVerticallyEveryNRows = null, Expression<Func<int>> uIAGetDataGridElementContentsScrollDataGridVerticallyElementHandle = null, Expression<Func<int>> uIAGetDataGridElementContentsMinimumDataGridRowsForScrolling = null, Expression<Func<bool>> uIAGetDataGridElementContentsRaiseExceptionIfCannotScroll = null, Expression<Func<string>> uIAGetDataGridElementContentsAlternativeVerticalScrollbarName = null, Expression<Func<int>> uIAGetDataGridElementContentsMaxElementsToSearch = null, Expression<Func<int>> uIAGetDataGridElementContentsMaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetDataGridElementContentsMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetDataGridElementContentsElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/GetDataGridElementContents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetDataGridElementContents = new JObject();
            var uIAGetDataGridElementContentspropCount = 0;
            if (uIAGetDataGridElementContentsParentWindowHandle != null)
            {
                uIAGetDataGridElementContents["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsParentWindowHandle);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsSearchElementName != null)
            {
                uIAGetDataGridElementContents["SearchElementName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsSearchElementName);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsSearchElementClassName != null)
            {
                uIAGetDataGridElementContents["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsSearchElementClassName);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsSearchElementAutomationId != null)
            {
                uIAGetDataGridElementContents["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsSearchElementAutomationId);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsSearchLocalizedControlType != null)
            {
                uIAGetDataGridElementContents["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsSearchLocalizedControlType);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsSearchSubTree != null)
            {
                uIAGetDataGridElementContents["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsSearchSubTree);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsOnScreenColumnsOnly != null)
            {
                uIAGetDataGridElementContents["OnScreenColumnsOnly"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsOnScreenColumnsOnly);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsOnScreenRowsOnly != null)
            {
                uIAGetDataGridElementContents["OnScreenRowsOnly"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsOnScreenRowsOnly);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsReturnNullValuesAsBlank != null)
            {
                uIAGetDataGridElementContents["ReturnNullValuesAsBlank"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsReturnNullValuesAsBlank);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsAlternativeHeaderRowName != null)
            {
                uIAGetDataGridElementContents["AlternativeHeaderRowName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsAlternativeHeaderRowName);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsReturnRowUIAName != null)
            {
                uIAGetDataGridElementContents["ReturnRowUIAName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsReturnRowUIAName);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsNameOfColumnToStoreRowUIAName != null)
            {
                uIAGetDataGridElementContents["NameOfColumnToStoreRowUIAName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsNameOfColumnToStoreRowUIAName);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsMatchIndex != null)
            {
                uIAGetDataGridElementContents["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsMatchIndex);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsSearchFilter != null)
            {
                uIAGetDataGridElementContents["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsSearchFilter);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsSortByColumn != null)
            {
                uIAGetDataGridElementContents["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsSortByColumn);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsMatchIndexAscending != null)
            {
                uIAGetDataGridElementContents["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsMatchIndexAscending);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsFirstItemToReturn != null)
            {
                uIAGetDataGridElementContents["FirstItemToReturn"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsFirstItemToReturn);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsMaxItemsToReturn != null)
            {
                uIAGetDataGridElementContents["MaxItemsToReturn"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsMaxItemsToReturn);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsScanFirstNRowsForEmptyRows != null)
            {
                uIAGetDataGridElementContents["ScanFirstNRowsForEmptyRows"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsScanFirstNRowsForEmptyRows);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsReadTableAsThread != null)
            {
                uIAGetDataGridElementContents["ReadTableAsThread"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsReadTableAsThread);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsRetrieveOutputDataFromThreadId != null)
            {
                uIAGetDataGridElementContents["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsRetrieveOutputDataFromThreadId);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsSecondsToWaitForThread != null)
            {
                uIAGetDataGridElementContents["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsSecondsToWaitForThread);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsScrollDataGridVerticallyEveryNPercent != null)
            {
                uIAGetDataGridElementContents["ScrollDataGridVerticallyEveryNPercent"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsScrollDataGridVerticallyEveryNPercent);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsScrollDataGridVerticallyEveryNRows != null)
            {
                uIAGetDataGridElementContents["ScrollDataGridVerticallyEveryNRows"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsScrollDataGridVerticallyEveryNRows);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsScrollDataGridVerticallyElementHandle != null)
            {
                uIAGetDataGridElementContents["ScrollDataGridVerticallyElementHandle"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsScrollDataGridVerticallyElementHandle);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsMinimumDataGridRowsForScrolling != null)
            {
                uIAGetDataGridElementContents["MinimumDataGridRowsForScrolling"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsMinimumDataGridRowsForScrolling);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsRaiseExceptionIfCannotScroll != null)
            {
                uIAGetDataGridElementContents["RaiseExceptionIfCannotScroll"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsRaiseExceptionIfCannotScroll);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsAlternativeVerticalScrollbarName != null)
            {
                uIAGetDataGridElementContents["AlternativeVerticalScrollbarName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsAlternativeVerticalScrollbarName);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsMaxElementsToSearch != null)
            {
                uIAGetDataGridElementContents["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsMaxElementsToSearch);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsMaxRelativeSearchDepth != null)
            {
                uIAGetDataGridElementContents["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsMaxRelativeSearchDepth);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsMaxChildElementsToSearchPerNode != null)
            {
                uIAGetDataGridElementContents["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsMaxChildElementsToSearchPerNode);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetDataGridElementContents["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsElementLocalizedControlTypesNotToTraverse);
                uIAGetDataGridElementContentspropCount++;
            }

            uIAGetDataGridElementContentspropCount++;
            uIAGetDataGridElementContents["Workflow"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsWorkflow);
            if (uIAGetDataGridElementContentspropCount > 0)
            {
                callPayload.Body = uIAGetDataGridElementContents;
            }

            return new ApiConnectionAction<UIAGetDataGridElementContentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetDataGridElementPropertiesResponse> UIAGetDataGridElementProperties(Expression<Func<int>> uIAGetDataGridElementPropertiesParentWindowHandle, Expression<Func<string>> uIAGetDataGridElementPropertiesWorkflow, Expression<Func<string>> uIAGetDataGridElementPropertiesSearchElementName = null, Expression<Func<string>> uIAGetDataGridElementPropertiesSearchElementClassName = null, Expression<Func<string>> uIAGetDataGridElementPropertiesSearchElementAutomationId = null, Expression<Func<string>> uIAGetDataGridElementPropertiesSearchLocalizedControlType = null, Expression<Func<bool>> uIAGetDataGridElementPropertiesSearchSubTree = null, Expression<Func<string>> uIAGetDataGridElementPropertiesAlternativeHeaderRowName = null, Expression<Func<int>> uIAGetDataGridElementPropertiesMatchIndex = null, Expression<Func<string>> uIAGetDataGridElementPropertiesSearchFilter = null, Expression<Func<string>> uIAGetDataGridElementPropertiesSortByColumn = null, Expression<Func<bool>> uIAGetDataGridElementPropertiesMatchIndexAscending = null, Expression<Func<int>> uIAGetDataGridElementPropertiesMaxElementsToSearch = null, Expression<Func<int>> uIAGetDataGridElementPropertiesMaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetDataGridElementPropertiesMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetDataGridElementPropertiesElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/GetDataGridElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetDataGridElementProperties = new JObject();
            var uIAGetDataGridElementPropertiespropCount = 0;
            uIAGetDataGridElementPropertiespropCount++;
            uIAGetDataGridElementProperties["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesParentWindowHandle);
            if (uIAGetDataGridElementPropertiesSearchElementName != null)
            {
                uIAGetDataGridElementProperties["SearchElementName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesSearchElementName);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesSearchElementClassName != null)
            {
                uIAGetDataGridElementProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesSearchElementClassName);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesSearchElementAutomationId != null)
            {
                uIAGetDataGridElementProperties["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesSearchElementAutomationId);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesSearchLocalizedControlType != null)
            {
                uIAGetDataGridElementProperties["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesSearchLocalizedControlType);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesSearchSubTree != null)
            {
                uIAGetDataGridElementProperties["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesSearchSubTree);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesAlternativeHeaderRowName != null)
            {
                uIAGetDataGridElementProperties["AlternativeHeaderRowName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesAlternativeHeaderRowName);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesMatchIndex != null)
            {
                uIAGetDataGridElementProperties["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesMatchIndex);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesSearchFilter != null)
            {
                uIAGetDataGridElementProperties["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesSearchFilter);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesSortByColumn != null)
            {
                uIAGetDataGridElementProperties["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesSortByColumn);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesMatchIndexAscending != null)
            {
                uIAGetDataGridElementProperties["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesMatchIndexAscending);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesMaxElementsToSearch != null)
            {
                uIAGetDataGridElementProperties["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesMaxElementsToSearch);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesMaxRelativeSearchDepth != null)
            {
                uIAGetDataGridElementProperties["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesMaxRelativeSearchDepth);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesMaxChildElementsToSearchPerNode != null)
            {
                uIAGetDataGridElementProperties["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesMaxChildElementsToSearchPerNode);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetDataGridElementProperties["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesElementLocalizedControlTypesNotToTraverse);
                uIAGetDataGridElementPropertiespropCount++;
            }

            uIAGetDataGridElementPropertiespropCount++;
            uIAGetDataGridElementProperties["Workflow"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesWorkflow);
            if (uIAGetDataGridElementPropertiespropCount > 0)
            {
                callPayload.Body = uIAGetDataGridElementProperties;
            }

            return new ApiConnectionAction<UIAGetDataGridElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetListElementItemsResponse> UIAGetListElementItems(Expression<Func<int>> uIAGetListElementItemsParentWindowHandle, Expression<Func<string>> uIAGetListElementItemsWorkflow, Expression<Func<string>> uIAGetListElementItemsSearchElementName = null, Expression<Func<string>> uIAGetListElementItemsSearchElementClassName = null, Expression<Func<string>> uIAGetListElementItemsSearchElementAutomationId = null, Expression<Func<string>> uIAGetListElementItemsSearchLocalizedControlType = null, Expression<Func<bool>> uIAGetListElementItemsSearchSubTree = null, Expression<Func<bool>> uIAGetListElementItemsExpandFirst = null, Expression<Func<bool>> uIAGetListElementItemsCollapseAfter = null, Expression<Func<bool>> uIAGetListElementItemsCheckForSelectedItems = null, Expression<Func<double>> uIAGetListElementItemsSecondsBetweenExpandCollapse = null, Expression<Func<int>> uIAGetListElementItemsMatchIndex = null, Expression<Func<string>> uIAGetListElementItemsSearchFilter = null, Expression<Func<string>> uIAGetListElementItemsSortByColumn = null, Expression<Func<bool>> uIAGetListElementItemsMatchIndexAscending = null, Expression<Func<int>> uIAGetListElementItemsMaxElementsToSearch = null, Expression<Func<int>> uIAGetListElementItemsMaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetListElementItemsMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetListElementItemsElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/GetListElementItems";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetListElementItems = new JObject();
            var uIAGetListElementItemspropCount = 0;
            uIAGetListElementItemspropCount++;
            uIAGetListElementItems["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGetListElementItemsParentWindowHandle);
            if (uIAGetListElementItemsSearchElementName != null)
            {
                uIAGetListElementItems["SearchElementName"] = ExpressionConverter.ConvertO(uIAGetListElementItemsSearchElementName);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsSearchElementClassName != null)
            {
                uIAGetListElementItems["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGetListElementItemsSearchElementClassName);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsSearchElementAutomationId != null)
            {
                uIAGetListElementItems["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGetListElementItemsSearchElementAutomationId);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsSearchLocalizedControlType != null)
            {
                uIAGetListElementItems["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetListElementItemsSearchLocalizedControlType);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsSearchSubTree != null)
            {
                uIAGetListElementItems["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetListElementItemsSearchSubTree);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsExpandFirst != null)
            {
                uIAGetListElementItems["ExpandFirst"] = ExpressionConverter.ConvertO(uIAGetListElementItemsExpandFirst);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsCollapseAfter != null)
            {
                uIAGetListElementItems["CollapseAfter"] = ExpressionConverter.ConvertO(uIAGetListElementItemsCollapseAfter);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsCheckForSelectedItems != null)
            {
                uIAGetListElementItems["CheckForSelectedItems"] = ExpressionConverter.ConvertO(uIAGetListElementItemsCheckForSelectedItems);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsSecondsBetweenExpandCollapse != null)
            {
                uIAGetListElementItems["SecondsBetweenExpandCollapse"] = ExpressionConverter.ConvertO(uIAGetListElementItemsSecondsBetweenExpandCollapse);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsMatchIndex != null)
            {
                uIAGetListElementItems["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetListElementItemsMatchIndex);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsSearchFilter != null)
            {
                uIAGetListElementItems["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetListElementItemsSearchFilter);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsSortByColumn != null)
            {
                uIAGetListElementItems["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetListElementItemsSortByColumn);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsMatchIndexAscending != null)
            {
                uIAGetListElementItems["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetListElementItemsMatchIndexAscending);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsMaxElementsToSearch != null)
            {
                uIAGetListElementItems["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetListElementItemsMaxElementsToSearch);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsMaxRelativeSearchDepth != null)
            {
                uIAGetListElementItems["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetListElementItemsMaxRelativeSearchDepth);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsMaxChildElementsToSearchPerNode != null)
            {
                uIAGetListElementItems["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetListElementItemsMaxChildElementsToSearchPerNode);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetListElementItems["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGetListElementItemsElementLocalizedControlTypesNotToTraverse);
                uIAGetListElementItemspropCount++;
            }

            uIAGetListElementItemspropCount++;
            uIAGetListElementItems["Workflow"] = ExpressionConverter.ConvertO(uIAGetListElementItemsWorkflow);
            if (uIAGetListElementItemspropCount > 0)
            {
                callPayload.Body = uIAGetListElementItems;
            }

            return new ApiConnectionAction<UIAGetListElementItemsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAClickListElementItemByName(Expression<Func<int>> uIAClickListElementItemByNameParentWindowHandle, Expression<Func<string>> uIAClickListElementItemByNameWorkflow, Expression<Func<string>> uIAClickListElementItemByNameSearchElementName = null, Expression<Func<string>> uIAClickListElementItemByNameSearchElementClassName = null, Expression<Func<string>> uIAClickListElementItemByNameSearchElementAutomationId = null, Expression<Func<string>> uIAClickListElementItemByNameSearchLocalizedControlType = null, Expression<Func<bool>> uIAClickListElementItemByNameSearchSubTree = null, Expression<Func<bool>> uIAClickListElementItemByNameExpandFirst = null, Expression<Func<bool>> uIAClickListElementItemByNameCollapseAfter = null, Expression<Func<string>> uIAClickListElementItemByNameItemName = null, Expression<Func<double>> uIAClickListElementItemByNameSecondsBetweenExpandCollapse = null, Expression<Func<int>> uIAClickListElementItemByNameMatchIndex = null, Expression<Func<string>> uIAClickListElementItemByNameSearchFilter = null, Expression<Func<string>> uIAClickListElementItemByNameSortByColumn = null, Expression<Func<bool>> uIAClickListElementItemByNameMatchIndexAscending = null, Expression<Func<int>> uIAClickListElementItemByNameMaxElementsToSearch = null, Expression<Func<int>> uIAClickListElementItemByNameMaxRelativeSearchDepth = null, Expression<Func<int>> uIAClickListElementItemByNameMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAClickListElementItemByNameElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/ClickListElementItemByName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAClickListElementItemByName = new JObject();
            var uIAClickListElementItemByNamepropCount = 0;
            uIAClickListElementItemByNamepropCount++;
            uIAClickListElementItemByName["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameParentWindowHandle);
            if (uIAClickListElementItemByNameSearchElementName != null)
            {
                uIAClickListElementItemByName["SearchElementName"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameSearchElementName);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNameSearchElementClassName != null)
            {
                uIAClickListElementItemByName["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameSearchElementClassName);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNameSearchElementAutomationId != null)
            {
                uIAClickListElementItemByName["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameSearchElementAutomationId);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNameSearchLocalizedControlType != null)
            {
                uIAClickListElementItemByName["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameSearchLocalizedControlType);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNameSearchSubTree != null)
            {
                uIAClickListElementItemByName["SearchSubTree"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameSearchSubTree);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNameExpandFirst != null)
            {
                uIAClickListElementItemByName["ExpandFirst"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameExpandFirst);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNameCollapseAfter != null)
            {
                uIAClickListElementItemByName["CollapseAfter"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameCollapseAfter);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNameItemName != null)
            {
                uIAClickListElementItemByName["ItemName"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameItemName);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNameSecondsBetweenExpandCollapse != null)
            {
                uIAClickListElementItemByName["SecondsBetweenExpandCollapse"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameSecondsBetweenExpandCollapse);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNameMatchIndex != null)
            {
                uIAClickListElementItemByName["MatchIndex"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameMatchIndex);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNameSearchFilter != null)
            {
                uIAClickListElementItemByName["SearchFilter"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameSearchFilter);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNameSortByColumn != null)
            {
                uIAClickListElementItemByName["SortByColumn"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameSortByColumn);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNameMatchIndexAscending != null)
            {
                uIAClickListElementItemByName["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameMatchIndexAscending);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNameMaxElementsToSearch != null)
            {
                uIAClickListElementItemByName["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameMaxElementsToSearch);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNameMaxRelativeSearchDepth != null)
            {
                uIAClickListElementItemByName["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameMaxRelativeSearchDepth);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNameMaxChildElementsToSearchPerNode != null)
            {
                uIAClickListElementItemByName["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameMaxChildElementsToSearchPerNode);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNameElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAClickListElementItemByName["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameElementLocalizedControlTypesNotToTraverse);
                uIAClickListElementItemByNamepropCount++;
            }

            uIAClickListElementItemByNamepropCount++;
            uIAClickListElementItemByName["Workflow"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameWorkflow);
            if (uIAClickListElementItemByNamepropCount > 0)
            {
                callPayload.Body = uIAClickListElementItemByName;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAClickListElementItemByIndex(Expression<Func<int>> uIAClickListElementItemByIndexParentWindowHandle, Expression<Func<string>> uIAClickListElementItemByIndexWorkflow, Expression<Func<string>> uIAClickListElementItemByIndexSearchElementName = null, Expression<Func<string>> uIAClickListElementItemByIndexSearchElementClassName = null, Expression<Func<string>> uIAClickListElementItemByIndexSearchElementAutomationId = null, Expression<Func<string>> uIAClickListElementItemByIndexSearchLocalizedControlType = null, Expression<Func<bool>> uIAClickListElementItemByIndexSearchSubTree = null, Expression<Func<bool>> uIAClickListElementItemByIndexExpandFirst = null, Expression<Func<bool>> uIAClickListElementItemByIndexCollapseAfter = null, Expression<Func<int>> uIAClickListElementItemByIndexItemIndex = null, Expression<Func<double>> uIAClickListElementItemByIndexSecondsBetweenExpandCollapse = null, Expression<Func<int>> uIAClickListElementItemByIndexMatchIndex = null, Expression<Func<string>> uIAClickListElementItemByIndexSearchFilter = null, Expression<Func<string>> uIAClickListElementItemByIndexSortByColumn = null, Expression<Func<bool>> uIAClickListElementItemByIndexMatchIndexAscending = null, Expression<Func<int>> uIAClickListElementItemByIndexMaxElementsToSearch = null, Expression<Func<int>> uIAClickListElementItemByIndexMaxRelativeSearchDepth = null, Expression<Func<int>> uIAClickListElementItemByIndexMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAClickListElementItemByIndexElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/ClickListElementItemByIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAClickListElementItemByIndex = new JObject();
            var uIAClickListElementItemByIndexpropCount = 0;
            uIAClickListElementItemByIndexpropCount++;
            uIAClickListElementItemByIndex["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexParentWindowHandle);
            if (uIAClickListElementItemByIndexSearchElementName != null)
            {
                uIAClickListElementItemByIndex["SearchElementName"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexSearchElementName);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexSearchElementClassName != null)
            {
                uIAClickListElementItemByIndex["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexSearchElementClassName);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexSearchElementAutomationId != null)
            {
                uIAClickListElementItemByIndex["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexSearchElementAutomationId);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexSearchLocalizedControlType != null)
            {
                uIAClickListElementItemByIndex["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexSearchLocalizedControlType);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexSearchSubTree != null)
            {
                uIAClickListElementItemByIndex["SearchSubTree"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexSearchSubTree);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexExpandFirst != null)
            {
                uIAClickListElementItemByIndex["ExpandFirst"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexExpandFirst);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexCollapseAfter != null)
            {
                uIAClickListElementItemByIndex["CollapseAfter"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexCollapseAfter);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexItemIndex != null)
            {
                uIAClickListElementItemByIndex["ItemIndex"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexItemIndex);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexSecondsBetweenExpandCollapse != null)
            {
                uIAClickListElementItemByIndex["SecondsBetweenExpandCollapse"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexSecondsBetweenExpandCollapse);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexMatchIndex != null)
            {
                uIAClickListElementItemByIndex["MatchIndex"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexMatchIndex);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexSearchFilter != null)
            {
                uIAClickListElementItemByIndex["SearchFilter"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexSearchFilter);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexSortByColumn != null)
            {
                uIAClickListElementItemByIndex["SortByColumn"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexSortByColumn);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexMatchIndexAscending != null)
            {
                uIAClickListElementItemByIndex["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexMatchIndexAscending);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexMaxElementsToSearch != null)
            {
                uIAClickListElementItemByIndex["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexMaxElementsToSearch);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexMaxRelativeSearchDepth != null)
            {
                uIAClickListElementItemByIndex["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexMaxRelativeSearchDepth);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexMaxChildElementsToSearchPerNode != null)
            {
                uIAClickListElementItemByIndex["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexMaxChildElementsToSearchPerNode);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAClickListElementItemByIndex["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexElementLocalizedControlTypesNotToTraverse);
                uIAClickListElementItemByIndexpropCount++;
            }

            uIAClickListElementItemByIndexpropCount++;
            uIAClickListElementItemByIndex["Workflow"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexWorkflow);
            if (uIAClickListElementItemByIndexpropCount > 0)
            {
                callPayload.Body = uIAClickListElementItemByIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIASetElementToNumericValue(Expression<Func<int>> uIASetElementToNumericValueParentWindowHandle, Expression<Func<int>> uIASetElementToNumericValueNewValue, Expression<Func<string>> uIASetElementToNumericValueWorkflow, Expression<Func<string>> uIASetElementToNumericValueSearchElementName = null, Expression<Func<string>> uIASetElementToNumericValueSearchElementClassName = null, Expression<Func<string>> uIASetElementToNumericValueSearchElementAutomationId = null, Expression<Func<string>> uIASetElementToNumericValueSearchLocalizedControlType = null, Expression<Func<bool>> uIASetElementToNumericValueSearchSubTree = null, Expression<Func<int>> uIASetElementToNumericValueMatchIndex = null, Expression<Func<string>> uIASetElementToNumericValueSearchFilter = null, Expression<Func<string>> uIASetElementToNumericValueSortByColumn = null, Expression<Func<bool>> uIASetElementToNumericValueMatchIndexAscending = null, Expression<Func<int>> uIASetElementToNumericValueMaxElementsToSearch = null, Expression<Func<int>> uIASetElementToNumericValueMaxRelativeSearchDepth = null, Expression<Func<int>> uIASetElementToNumericValueMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIASetElementToNumericValueElementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIASetElementToNumericValueRaiseExceptionIfInputValidationFails = null, Expression<Func<bool>> uIASetElementToNumericValueTryValuePattern = null, Expression<Func<bool>> uIASetElementToNumericValueTryLegacyPattern = null)
        {
            var apiCallPath = "/UIAControl/UIASetElementToNumericValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIASetElementToNumericValue = new JObject();
            var uIASetElementToNumericValuepropCount = 0;
            uIASetElementToNumericValuepropCount++;
            uIASetElementToNumericValue["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueParentWindowHandle);
            if (uIASetElementToNumericValueSearchElementName != null)
            {
                uIASetElementToNumericValue["SearchElementName"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueSearchElementName);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValueSearchElementClassName != null)
            {
                uIASetElementToNumericValue["SearchElementClassName"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueSearchElementClassName);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValueSearchElementAutomationId != null)
            {
                uIASetElementToNumericValue["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueSearchElementAutomationId);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValueSearchLocalizedControlType != null)
            {
                uIASetElementToNumericValue["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueSearchLocalizedControlType);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValueSearchSubTree != null)
            {
                uIASetElementToNumericValue["SearchSubTree"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueSearchSubTree);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValueMatchIndex != null)
            {
                uIASetElementToNumericValue["MatchIndex"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueMatchIndex);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValueSearchFilter != null)
            {
                uIASetElementToNumericValue["SearchFilter"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueSearchFilter);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValueSortByColumn != null)
            {
                uIASetElementToNumericValue["SortByColumn"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueSortByColumn);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValueMatchIndexAscending != null)
            {
                uIASetElementToNumericValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueMatchIndexAscending);
                uIASetElementToNumericValuepropCount++;
            }

            uIASetElementToNumericValuepropCount++;
            uIASetElementToNumericValue["NewValue"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueNewValue);
            if (uIASetElementToNumericValueMaxElementsToSearch != null)
            {
                uIASetElementToNumericValue["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueMaxElementsToSearch);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValueMaxRelativeSearchDepth != null)
            {
                uIASetElementToNumericValue["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueMaxRelativeSearchDepth);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValueMaxChildElementsToSearchPerNode != null)
            {
                uIASetElementToNumericValue["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueMaxChildElementsToSearchPerNode);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValueElementLocalizedControlTypesNotToTraverse != null)
            {
                uIASetElementToNumericValue["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueElementLocalizedControlTypesNotToTraverse);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValueRaiseExceptionIfInputValidationFails != null)
            {
                uIASetElementToNumericValue["RaiseExceptionIfInputValidationFails"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueRaiseExceptionIfInputValidationFails);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValueTryValuePattern != null)
            {
                uIASetElementToNumericValue["TryValuePattern"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueTryValuePattern);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValueTryLegacyPattern != null)
            {
                uIASetElementToNumericValue["TryLegacyPattern"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueTryLegacyPattern);
                uIASetElementToNumericValuepropCount++;
            }

            uIASetElementToNumericValuepropCount++;
            uIASetElementToNumericValue["Workflow"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueWorkflow);
            if (uIASetElementToNumericValuepropCount > 0)
            {
                callPayload.Body = uIASetElementToNumericValue;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIASetElementToNumericRangeValue(Expression<Func<int>> uIASetElementToNumericRangeValueParentWindowHandle, Expression<Func<double>> uIASetElementToNumericRangeValueNewValue, Expression<Func<string>> uIASetElementToNumericRangeValueWorkflow, Expression<Func<string>> uIASetElementToNumericRangeValueSearchElementName = null, Expression<Func<string>> uIASetElementToNumericRangeValueSearchElementClassName = null, Expression<Func<string>> uIASetElementToNumericRangeValueSearchElementAutomationId = null, Expression<Func<string>> uIASetElementToNumericRangeValueSearchLocalizedControlType = null, Expression<Func<bool>> uIASetElementToNumericRangeValueSearchSubTree = null, Expression<Func<int>> uIASetElementToNumericRangeValueMatchIndex = null, Expression<Func<string>> uIASetElementToNumericRangeValueSearchFilter = null, Expression<Func<string>> uIASetElementToNumericRangeValueSortByColumn = null, Expression<Func<bool>> uIASetElementToNumericRangeValueMatchIndexAscending = null, Expression<Func<bool>> uIASetElementToNumericRangeValueNewValueIsPercentage = null, Expression<Func<int>> uIASetElementToNumericRangeValueMaxElementsToSearch = null, Expression<Func<int>> uIASetElementToNumericRangeValueMaxRelativeSearchDepth = null, Expression<Func<int>> uIASetElementToNumericRangeValueMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIASetElementToNumericRangeValueElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/UIASetElementToNumericRangeValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIASetElementToNumericRangeValue = new JObject();
            var uIASetElementToNumericRangeValuepropCount = 0;
            uIASetElementToNumericRangeValuepropCount++;
            uIASetElementToNumericRangeValue["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValueParentWindowHandle);
            if (uIASetElementToNumericRangeValueSearchElementName != null)
            {
                uIASetElementToNumericRangeValue["SearchElementName"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValueSearchElementName);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValueSearchElementClassName != null)
            {
                uIASetElementToNumericRangeValue["SearchElementClassName"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValueSearchElementClassName);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValueSearchElementAutomationId != null)
            {
                uIASetElementToNumericRangeValue["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValueSearchElementAutomationId);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValueSearchLocalizedControlType != null)
            {
                uIASetElementToNumericRangeValue["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValueSearchLocalizedControlType);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValueSearchSubTree != null)
            {
                uIASetElementToNumericRangeValue["SearchSubTree"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValueSearchSubTree);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValueMatchIndex != null)
            {
                uIASetElementToNumericRangeValue["MatchIndex"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValueMatchIndex);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValueSearchFilter != null)
            {
                uIASetElementToNumericRangeValue["SearchFilter"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValueSearchFilter);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValueSortByColumn != null)
            {
                uIASetElementToNumericRangeValue["SortByColumn"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValueSortByColumn);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValueMatchIndexAscending != null)
            {
                uIASetElementToNumericRangeValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValueMatchIndexAscending);
                uIASetElementToNumericRangeValuepropCount++;
            }

            uIASetElementToNumericRangeValuepropCount++;
            uIASetElementToNumericRangeValue["NewValue"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValueNewValue);
            if (uIASetElementToNumericRangeValueNewValueIsPercentage != null)
            {
                uIASetElementToNumericRangeValue["NewValueIsPercentage"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValueNewValueIsPercentage);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValueMaxElementsToSearch != null)
            {
                uIASetElementToNumericRangeValue["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValueMaxElementsToSearch);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValueMaxRelativeSearchDepth != null)
            {
                uIASetElementToNumericRangeValue["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValueMaxRelativeSearchDepth);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValueMaxChildElementsToSearchPerNode != null)
            {
                uIASetElementToNumericRangeValue["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValueMaxChildElementsToSearchPerNode);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValueElementLocalizedControlTypesNotToTraverse != null)
            {
                uIASetElementToNumericRangeValue["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValueElementLocalizedControlTypesNotToTraverse);
                uIASetElementToNumericRangeValuepropCount++;
            }

            uIASetElementToNumericRangeValuepropCount++;
            uIASetElementToNumericRangeValue["Workflow"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValueWorkflow);
            if (uIASetElementToNumericRangeValuepropCount > 0)
            {
                callPayload.Body = uIASetElementToNumericRangeValue;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAResetAllElementHandles(Expression<Func<string>> uIAResetAllElementHandlesWorkflow)
        {
            var apiCallPath = "/UIAControl/UIAResetAllElementHandles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAResetAllElementHandles = new JObject();
            var uIAResetAllElementHandlespropCount = 0;
            uIAResetAllElementHandlespropCount++;
            uIAResetAllElementHandles["Workflow"] = ExpressionConverter.ConvertO(uIAResetAllElementHandlesWorkflow);
            if (uIAResetAllElementHandlespropCount > 0)
            {
                callPayload.Body = uIAResetAllElementHandles;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalPasswordInputIntoElement(Expression<Func<int>> uIAGlobalPasswordInputIntoElementParentWindowHandle, Expression<Func<string>> uIAGlobalPasswordInputIntoElementPasswordToInput, Expression<Func<string>> uIAGlobalPasswordInputIntoElementWorkflow, Expression<Func<string>> uIAGlobalPasswordInputIntoElementSearchElementName = null, Expression<Func<string>> uIAGlobalPasswordInputIntoElementSearchElementClassName = null, Expression<Func<string>> uIAGlobalPasswordInputIntoElementSearchElementAutomationId = null, Expression<Func<string>> uIAGlobalPasswordInputIntoElementSearchLocalizedControlType = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementSearchSubTree = null, Expression<Func<int>> uIAGlobalPasswordInputIntoElementMatchIndex = null, Expression<Func<string>> uIAGlobalPasswordInputIntoElementSearchFilter = null, Expression<Func<string>> uIAGlobalPasswordInputIntoElementSortByColumn = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementMatchIndexAscending = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementFocusElement = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementGlobalMouseClickOnElement = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementReplaceExistingValueUsingDoubleClickDelete = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementReplaceExistingValueUsingCTRLADelete = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementSendKeyEvents = null, Expression<Func<int>> uIAGlobalPasswordInputIntoElementInterval = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementDontInterpretSymbols = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementPasswordContainsStoredPassword = null, Expression<Func<int>> uIAGlobalPasswordInputIntoElementMaxElementsToSearch = null, Expression<Func<int>> uIAGlobalPasswordInputIntoElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIAGlobalPasswordInputIntoElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGlobalPasswordInputIntoElementElementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementValidateClickablePointWithinElementBoundary = null)
        {
            var apiCallPath = "/UIAControl/UIAGlobalPasswordInputIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGlobalPasswordInputIntoElement = new JObject();
            var uIAGlobalPasswordInputIntoElementpropCount = 0;
            uIAGlobalPasswordInputIntoElementpropCount++;
            uIAGlobalPasswordInputIntoElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementParentWindowHandle);
            if (uIAGlobalPasswordInputIntoElementSearchElementName != null)
            {
                uIAGlobalPasswordInputIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementSearchElementName);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementSearchElementClassName != null)
            {
                uIAGlobalPasswordInputIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementSearchElementClassName);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementSearchElementAutomationId != null)
            {
                uIAGlobalPasswordInputIntoElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementSearchElementAutomationId);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementSearchLocalizedControlType != null)
            {
                uIAGlobalPasswordInputIntoElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementSearchLocalizedControlType);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementSearchSubTree != null)
            {
                uIAGlobalPasswordInputIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementSearchSubTree);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementMatchIndex != null)
            {
                uIAGlobalPasswordInputIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementMatchIndex);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementSearchFilter != null)
            {
                uIAGlobalPasswordInputIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementSearchFilter);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementSortByColumn != null)
            {
                uIAGlobalPasswordInputIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementSortByColumn);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementMatchIndexAscending != null)
            {
                uIAGlobalPasswordInputIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementMatchIndexAscending);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementFocusElement != null)
            {
                uIAGlobalPasswordInputIntoElement["FocusElement"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementFocusElement);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementGlobalMouseClickOnElement != null)
            {
                uIAGlobalPasswordInputIntoElement["GlobalMouseClickOnElement"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementGlobalMouseClickOnElement);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementReplaceExistingValueUsingDoubleClickDelete != null)
            {
                uIAGlobalPasswordInputIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementReplaceExistingValueUsingDoubleClickDelete);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementReplaceExistingValueUsingCTRLADelete != null)
            {
                uIAGlobalPasswordInputIntoElement["ReplaceExistingValueUsingCTRLADelete"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementReplaceExistingValueUsingCTRLADelete);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            uIAGlobalPasswordInputIntoElementpropCount++;
            uIAGlobalPasswordInputIntoElement["PasswordToInput"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementPasswordToInput);
            if (uIAGlobalPasswordInputIntoElementSendKeyEvents != null)
            {
                uIAGlobalPasswordInputIntoElement["SendKeyEvents"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementSendKeyEvents);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementInterval != null)
            {
                uIAGlobalPasswordInputIntoElement["Interval"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementInterval);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementDontInterpretSymbols != null)
            {
                uIAGlobalPasswordInputIntoElement["DontInterpretSymbols"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementDontInterpretSymbols);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementPasswordContainsStoredPassword != null)
            {
                uIAGlobalPasswordInputIntoElement["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementPasswordContainsStoredPassword);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementMaxElementsToSearch != null)
            {
                uIAGlobalPasswordInputIntoElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementMaxElementsToSearch);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementMaxRelativeSearchDepth != null)
            {
                uIAGlobalPasswordInputIntoElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementMaxRelativeSearchDepth);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementMaxChildElementsToSearchPerNode != null)
            {
                uIAGlobalPasswordInputIntoElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementMaxChildElementsToSearchPerNode);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGlobalPasswordInputIntoElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementElementLocalizedControlTypesNotToTraverse);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementValidateClickablePointWithinElementBoundary != null)
            {
                uIAGlobalPasswordInputIntoElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementValidateClickablePointWithinElementBoundary);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            uIAGlobalPasswordInputIntoElementpropCount++;
            uIAGlobalPasswordInputIntoElement["Workflow"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementWorkflow);
            if (uIAGlobalPasswordInputIntoElementpropCount > 0)
            {
                callPayload.Body = uIAGlobalPasswordInputIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalTextInputIntoElement(Expression<Func<int>> uIAGlobalTextInputIntoElementParentWindowHandle, Expression<Func<string>> uIAGlobalTextInputIntoElementWorkflow, Expression<Func<string>> uIAGlobalTextInputIntoElementSearchElementName = null, Expression<Func<string>> uIAGlobalTextInputIntoElementSearchElementClassName = null, Expression<Func<string>> uIAGlobalTextInputIntoElementSearchElementAutomationId = null, Expression<Func<string>> uIAGlobalTextInputIntoElementSearchLocalizedControlType = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementSearchSubTree = null, Expression<Func<int>> uIAGlobalTextInputIntoElementMatchIndex = null, Expression<Func<string>> uIAGlobalTextInputIntoElementSearchFilter = null, Expression<Func<string>> uIAGlobalTextInputIntoElementSortByColumn = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementMatchIndexAscending = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementFocusElement = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementGlobalMouseClickOnElement = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementReplaceExistingValueUsingDoubleClickDelete = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementReplaceExistingValueUsingCTRLADelete = null, Expression<Func<string>> uIAGlobalTextInputIntoElementTextToInput = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementSendKeyEvents = null, Expression<Func<int>> uIAGlobalTextInputIntoElementInterval = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementDontInterpretSymbols = null, Expression<Func<int>> uIAGlobalTextInputIntoElementMaxElementsToSearch = null, Expression<Func<int>> uIAGlobalTextInputIntoElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIAGlobalTextInputIntoElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGlobalTextInputIntoElementElementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementValidateClickablePointWithinElementBoundary = null)
        {
            var apiCallPath = "/UIAControl/UIAGlobalTextInputIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGlobalTextInputIntoElement = new JObject();
            var uIAGlobalTextInputIntoElementpropCount = 0;
            uIAGlobalTextInputIntoElementpropCount++;
            uIAGlobalTextInputIntoElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementParentWindowHandle);
            if (uIAGlobalTextInputIntoElementSearchElementName != null)
            {
                uIAGlobalTextInputIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementSearchElementName);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementSearchElementClassName != null)
            {
                uIAGlobalTextInputIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementSearchElementClassName);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementSearchElementAutomationId != null)
            {
                uIAGlobalTextInputIntoElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementSearchElementAutomationId);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementSearchLocalizedControlType != null)
            {
                uIAGlobalTextInputIntoElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementSearchLocalizedControlType);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementSearchSubTree != null)
            {
                uIAGlobalTextInputIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementSearchSubTree);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementMatchIndex != null)
            {
                uIAGlobalTextInputIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementMatchIndex);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementSearchFilter != null)
            {
                uIAGlobalTextInputIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementSearchFilter);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementSortByColumn != null)
            {
                uIAGlobalTextInputIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementSortByColumn);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementMatchIndexAscending != null)
            {
                uIAGlobalTextInputIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementMatchIndexAscending);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementFocusElement != null)
            {
                uIAGlobalTextInputIntoElement["FocusElement"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementFocusElement);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementGlobalMouseClickOnElement != null)
            {
                uIAGlobalTextInputIntoElement["GlobalMouseClickOnElement"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementGlobalMouseClickOnElement);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementReplaceExistingValueUsingDoubleClickDelete != null)
            {
                uIAGlobalTextInputIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementReplaceExistingValueUsingDoubleClickDelete);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementReplaceExistingValueUsingCTRLADelete != null)
            {
                uIAGlobalTextInputIntoElement["ReplaceExistingValueUsingCTRLADelete"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementReplaceExistingValueUsingCTRLADelete);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementTextToInput != null)
            {
                uIAGlobalTextInputIntoElement["TextToInput"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementTextToInput);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementSendKeyEvents != null)
            {
                uIAGlobalTextInputIntoElement["SendKeyEvents"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementSendKeyEvents);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementInterval != null)
            {
                uIAGlobalTextInputIntoElement["Interval"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementInterval);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementDontInterpretSymbols != null)
            {
                uIAGlobalTextInputIntoElement["DontInterpretSymbols"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementDontInterpretSymbols);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementMaxElementsToSearch != null)
            {
                uIAGlobalTextInputIntoElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementMaxElementsToSearch);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementMaxRelativeSearchDepth != null)
            {
                uIAGlobalTextInputIntoElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementMaxRelativeSearchDepth);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementMaxChildElementsToSearchPerNode != null)
            {
                uIAGlobalTextInputIntoElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementMaxChildElementsToSearchPerNode);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGlobalTextInputIntoElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementElementLocalizedControlTypesNotToTraverse);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementValidateClickablePointWithinElementBoundary != null)
            {
                uIAGlobalTextInputIntoElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementValidateClickablePointWithinElementBoundary);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            uIAGlobalTextInputIntoElementpropCount++;
            uIAGlobalTextInputIntoElement["Workflow"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementWorkflow);
            if (uIAGlobalTextInputIntoElementpropCount > 0)
            {
                callPayload.Body = uIAGlobalTextInputIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementPropertiesAsListResponse> UIAGetElementPropertiesAsList(Expression<Func<int>> uIAGetElementPropertiesAsListElementHandle, Expression<Func<string>> uIAGetElementPropertiesAsListWorkflow)
        {
            var apiCallPath = "/UIAControl/UIAGetElementPropertiesAsList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetElementPropertiesAsList = new JObject();
            var uIAGetElementPropertiesAsListpropCount = 0;
            uIAGetElementPropertiesAsListpropCount++;
            uIAGetElementPropertiesAsList["ElementHandle"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesAsListElementHandle);
            uIAGetElementPropertiesAsListpropCount++;
            uIAGetElementPropertiesAsList["Workflow"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesAsListWorkflow);
            if (uIAGetElementPropertiesAsListpropCount > 0)
            {
                callPayload.Body = uIAGetElementPropertiesAsList;
            }

            return new ApiConnectionAction<UIAGetElementPropertiesAsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIASetTransactionTimeout(Expression<Func<double>> uIASetTransactionTimeoutTimeoutInSeconds, Expression<Func<string>> uIASetTransactionTimeoutWorkflow)
        {
            var apiCallPath = "/UIAControl/UIASetTransactionTimeout";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIASetTransactionTimeout = new JObject();
            var uIASetTransactionTimeoutpropCount = 0;
            uIASetTransactionTimeoutpropCount++;
            uIASetTransactionTimeout["TimeoutInSeconds"] = ExpressionConverter.ConvertO(uIASetTransactionTimeoutTimeoutInSeconds);
            uIASetTransactionTimeoutpropCount++;
            uIASetTransactionTimeout["Workflow"] = ExpressionConverter.ConvertO(uIASetTransactionTimeoutWorkflow);
            if (uIASetTransactionTimeoutpropCount > 0)
            {
                callPayload.Body = uIASetTransactionTimeout;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementAtCoordinatesResponse> UIAGetElementAtCoordinates(Expression<Func<string>> uIAGetElementAtCoordinatesWorkflow, Expression<Func<int>> uIAGetElementAtCoordinatesXCoord = null, Expression<Func<int>> uIAGetElementAtCoordinatesYCoord = null, Expression<Func<bool>> uIAGetElementAtCoordinatesRaiseExceptionIfElementNotFound = null)
        {
            var apiCallPath = "/UIAControl/UIAGetElementAtCoordinates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetElementAtCoordinates = new JObject();
            var uIAGetElementAtCoordinatespropCount = 0;
            if (uIAGetElementAtCoordinatesXCoord != null)
            {
                uIAGetElementAtCoordinates["XCoord"] = ExpressionConverter.ConvertO(uIAGetElementAtCoordinatesXCoord);
                uIAGetElementAtCoordinatespropCount++;
            }

            if (uIAGetElementAtCoordinatesYCoord != null)
            {
                uIAGetElementAtCoordinates["YCoord"] = ExpressionConverter.ConvertO(uIAGetElementAtCoordinatesYCoord);
                uIAGetElementAtCoordinatespropCount++;
            }

            if (uIAGetElementAtCoordinatesRaiseExceptionIfElementNotFound != null)
            {
                uIAGetElementAtCoordinates["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(uIAGetElementAtCoordinatesRaiseExceptionIfElementNotFound);
                uIAGetElementAtCoordinatespropCount++;
            }

            uIAGetElementAtCoordinatespropCount++;
            uIAGetElementAtCoordinates["Workflow"] = ExpressionConverter.ConvertO(uIAGetElementAtCoordinatesWorkflow);
            if (uIAGetElementAtCoordinatespropCount > 0)
            {
                callPayload.Body = uIAGetElementAtCoordinates;
            }

            return new ApiConnectionAction<UIAGetElementAtCoordinatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetMultipleParentElementPropertiesResponse> UIAGetMultipleParentElementProperties(Expression<Func<int>> uIAGetMultipleParentElementPropertiesElementHandle, Expression<Func<string>> uIAGetMultipleParentElementPropertiesWorkflow, Expression<Func<int>> uIAGetMultipleParentElementPropertiesMaxParentsToProcess = null)
        {
            var apiCallPath = "/UIAControl/UIAGetMultipleParentElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetMultipleParentElementProperties = new JObject();
            var uIAGetMultipleParentElementPropertiespropCount = 0;
            uIAGetMultipleParentElementPropertiespropCount++;
            uIAGetMultipleParentElementProperties["ElementHandle"] = ExpressionConverter.ConvertO(uIAGetMultipleParentElementPropertiesElementHandle);
            if (uIAGetMultipleParentElementPropertiesMaxParentsToProcess != null)
            {
                uIAGetMultipleParentElementProperties["MaxParentsToProcess"] = ExpressionConverter.ConvertO(uIAGetMultipleParentElementPropertiesMaxParentsToProcess);
                uIAGetMultipleParentElementPropertiespropCount++;
            }

            uIAGetMultipleParentElementPropertiespropCount++;
            uIAGetMultipleParentElementProperties["Workflow"] = ExpressionConverter.ConvertO(uIAGetMultipleParentElementPropertiesWorkflow);
            if (uIAGetMultipleParentElementPropertiespropCount > 0)
            {
                callPayload.Body = uIAGetMultipleParentElementProperties;
            }

            return new ApiConnectionAction<UIAGetMultipleParentElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIASearchForFirstParentElementResponse> UIASearchForFirstParentElement(Expression<Func<int>> uIASearchForFirstParentElementElementHandle, Expression<Func<string>> uIASearchForFirstParentElementWorkflow, Expression<Func<string>> uIASearchForFirstParentElementSearchParentLocalizedControlType = null, Expression<Func<int>> uIASearchForFirstParentElementSearchParentControlType = null, Expression<Func<int>> uIASearchForFirstParentElementMaxParentsToProcess = null, Expression<Func<bool>> uIASearchForFirstParentElementRaiseExceptionIfParentElementNotFound = null)
        {
            var apiCallPath = "/UIAControl/UIASearchForFirstParentElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIASearchForFirstParentElement = new JObject();
            var uIASearchForFirstParentElementpropCount = 0;
            uIASearchForFirstParentElementpropCount++;
            uIASearchForFirstParentElement["ElementHandle"] = ExpressionConverter.ConvertO(uIASearchForFirstParentElementElementHandle);
            if (uIASearchForFirstParentElementSearchParentLocalizedControlType != null)
            {
                uIASearchForFirstParentElement["SearchParentLocalizedControlType"] = ExpressionConverter.ConvertO(uIASearchForFirstParentElementSearchParentLocalizedControlType);
                uIASearchForFirstParentElementpropCount++;
            }

            if (uIASearchForFirstParentElementSearchParentControlType != null)
            {
                uIASearchForFirstParentElement["SearchParentControlType"] = ExpressionConverter.ConvertO(uIASearchForFirstParentElementSearchParentControlType);
                uIASearchForFirstParentElementpropCount++;
            }

            if (uIASearchForFirstParentElementMaxParentsToProcess != null)
            {
                uIASearchForFirstParentElement["MaxParentsToProcess"] = ExpressionConverter.ConvertO(uIASearchForFirstParentElementMaxParentsToProcess);
                uIASearchForFirstParentElementpropCount++;
            }

            if (uIASearchForFirstParentElementRaiseExceptionIfParentElementNotFound != null)
            {
                uIASearchForFirstParentElement["RaiseExceptionIfParentElementNotFound"] = ExpressionConverter.ConvertO(uIASearchForFirstParentElementRaiseExceptionIfParentElementNotFound);
                uIASearchForFirstParentElementpropCount++;
            }

            uIASearchForFirstParentElementpropCount++;
            uIASearchForFirstParentElement["Workflow"] = ExpressionConverter.ConvertO(uIASearchForFirstParentElementWorkflow);
            if (uIASearchForFirstParentElementpropCount > 0)
            {
                callPayload.Body = uIASearchForFirstParentElement;
            }

            return new ApiConnectionAction<UIASearchForFirstParentElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetMultipleElementsAsTableResponse> UIAGetMultipleElementsAsTable(Expression<Func<string>> uIAGetMultipleElementsAsTableWorkflow, Expression<Func<int>> uIAGetMultipleElementsAsTableParentWindowHandle = null, Expression<Func<string>> uIAGetMultipleElementsAsTableSearchElementName = null, Expression<Func<string>> uIAGetMultipleElementsAsTableSearchElementClassName = null, Expression<Func<string>> uIAGetMultipleElementsAsTableSearchElementAutomationId = null, Expression<Func<string>> uIAGetMultipleElementsAsTableSearchLocalizedControlType = null, Expression<Func<bool>> uIAGetMultipleElementsAsTableSearchSubTree = null, Expression<Func<int>> uIAGetMultipleElementsAsTableMatchIndex = null, Expression<Func<string>> uIAGetMultipleElementsAsTableSearchFilter = null, Expression<Func<string>> uIAGetMultipleElementsAsTableSortByColumn = null, Expression<Func<bool>> uIAGetMultipleElementsAsTableMatchIndexAscending = null, Expression<Func<string>> uIAGetMultipleElementsAsTableSearchCellHeaderSubElementLocalizedControlType = null, Expression<Func<int>> uIAGetMultipleElementsAsTableSearchCellHeaderSubElementControlType = null, Expression<Func<string>> uIAGetMultipleElementsAsTableSearchCellSubElementLocalizedControlType = null, Expression<Func<int>> uIAGetMultipleElementsAsTableSearchCellSubElementControlType = null, Expression<Func<bool>> uIAGetMultipleElementsAsTableSearchDescendantsForCellSubElements = null, Expression<Func<int>> uIAGetMultipleElementsAsTableFirstCellHeaderSubElementToReturn = null, Expression<Func<int>> uIAGetMultipleElementsAsTableMaxCellHeaderSubElementsToReturn = null, Expression<Func<int>> uIAGetMultipleElementsAsTableFirstCellSubElementToReturn = null, Expression<Func<int>> uIAGetMultipleElementsAsTableMaxCellSubElementsToReturn = null, Expression<Func<int>> uIAGetMultipleElementsAsTableRequestedNumberOfColumns = null, Expression<Func<int>> uIAGetMultipleElementsAsTableCellSubElementValuePriority = null, Expression<Func<int>> uIAGetMultipleElementsAsTableCellSubElementTextValuePriority = null, Expression<Func<int>> uIAGetMultipleElementsAsTableCellSubElementNameValuePriority = null, Expression<Func<int>> uIAGetMultipleElementsAsTableMinimumCellSubElementWidth = null, Expression<Func<int>> uIAGetMultipleElementsAsTableMinimumCellSubElementHeight = null, Expression<Func<int>> uIAGetMultipleElementsAsTableSearchCellSubElementBoundingBoxLeft = null, Expression<Func<int>> uIAGetMultipleElementsAsTableSearchCellSubElementBoundingBoxRight = null, Expression<Func<int>> uIAGetMultipleElementsAsTableSearchCellSubElementBoundingBoxTop = null, Expression<Func<int>> uIAGetMultipleElementsAsTableSearchCellSubElementBoundingBoxBottom = null, Expression<Func<bool>> uIAGetMultipleElementsAsTableReadTableAsThread = null, Expression<Func<int>> uIAGetMultipleElementsAsTableRetrieveOutputDataFromThreadId = null, Expression<Func<int>> uIAGetMultipleElementsAsTableSecondsToWaitForThread = null, Expression<Func<int>> uIAGetMultipleElementsAsTableMaxElementsToSearch = null, Expression<Func<int>> uIAGetMultipleElementsAsTableMaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetMultipleElementsAsTableMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetMultipleElementsAsTableElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/UIAGetMultipleElementsAsTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetMultipleElementsAsTable = new JObject();
            var uIAGetMultipleElementsAsTablepropCount = 0;
            if (uIAGetMultipleElementsAsTableParentWindowHandle != null)
            {
                uIAGetMultipleElementsAsTable["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableParentWindowHandle);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableSearchElementName != null)
            {
                uIAGetMultipleElementsAsTable["SearchElementName"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableSearchElementName);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableSearchElementClassName != null)
            {
                uIAGetMultipleElementsAsTable["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableSearchElementClassName);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableSearchElementAutomationId != null)
            {
                uIAGetMultipleElementsAsTable["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableSearchElementAutomationId);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableSearchLocalizedControlType != null)
            {
                uIAGetMultipleElementsAsTable["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableSearchLocalizedControlType);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableSearchSubTree != null)
            {
                uIAGetMultipleElementsAsTable["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableSearchSubTree);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableMatchIndex != null)
            {
                uIAGetMultipleElementsAsTable["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableMatchIndex);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableSearchFilter != null)
            {
                uIAGetMultipleElementsAsTable["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableSearchFilter);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableSortByColumn != null)
            {
                uIAGetMultipleElementsAsTable["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableSortByColumn);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableMatchIndexAscending != null)
            {
                uIAGetMultipleElementsAsTable["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableMatchIndexAscending);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableSearchCellHeaderSubElementLocalizedControlType != null)
            {
                uIAGetMultipleElementsAsTable["SearchCellHeaderSubElementLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableSearchCellHeaderSubElementLocalizedControlType);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableSearchCellHeaderSubElementControlType != null)
            {
                uIAGetMultipleElementsAsTable["SearchCellHeaderSubElementControlType"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableSearchCellHeaderSubElementControlType);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableSearchCellSubElementLocalizedControlType != null)
            {
                uIAGetMultipleElementsAsTable["SearchCellSubElementLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableSearchCellSubElementLocalizedControlType);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableSearchCellSubElementControlType != null)
            {
                uIAGetMultipleElementsAsTable["SearchCellSubElementControlType"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableSearchCellSubElementControlType);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableSearchDescendantsForCellSubElements != null)
            {
                uIAGetMultipleElementsAsTable["SearchDescendantsForCellSubElements"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableSearchDescendantsForCellSubElements);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableFirstCellHeaderSubElementToReturn != null)
            {
                uIAGetMultipleElementsAsTable["FirstCellHeaderSubElementToReturn"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableFirstCellHeaderSubElementToReturn);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableMaxCellHeaderSubElementsToReturn != null)
            {
                uIAGetMultipleElementsAsTable["MaxCellHeaderSubElementsToReturn"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableMaxCellHeaderSubElementsToReturn);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableFirstCellSubElementToReturn != null)
            {
                uIAGetMultipleElementsAsTable["FirstCellSubElementToReturn"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableFirstCellSubElementToReturn);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableMaxCellSubElementsToReturn != null)
            {
                uIAGetMultipleElementsAsTable["MaxCellSubElementsToReturn"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableMaxCellSubElementsToReturn);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableRequestedNumberOfColumns != null)
            {
                uIAGetMultipleElementsAsTable["RequestedNumberOfColumns"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableRequestedNumberOfColumns);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableCellSubElementValuePriority != null)
            {
                uIAGetMultipleElementsAsTable["CellSubElementValuePriority"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableCellSubElementValuePriority);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableCellSubElementTextValuePriority != null)
            {
                uIAGetMultipleElementsAsTable["CellSubElementTextValuePriority"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableCellSubElementTextValuePriority);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableCellSubElementNameValuePriority != null)
            {
                uIAGetMultipleElementsAsTable["CellSubElementNameValuePriority"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableCellSubElementNameValuePriority);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableMinimumCellSubElementWidth != null)
            {
                uIAGetMultipleElementsAsTable["MinimumCellSubElementWidth"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableMinimumCellSubElementWidth);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableMinimumCellSubElementHeight != null)
            {
                uIAGetMultipleElementsAsTable["MinimumCellSubElementHeight"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableMinimumCellSubElementHeight);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableSearchCellSubElementBoundingBoxLeft != null)
            {
                uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableSearchCellSubElementBoundingBoxLeft);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableSearchCellSubElementBoundingBoxRight != null)
            {
                uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxRight"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableSearchCellSubElementBoundingBoxRight);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableSearchCellSubElementBoundingBoxTop != null)
            {
                uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxTop"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableSearchCellSubElementBoundingBoxTop);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableSearchCellSubElementBoundingBoxBottom != null)
            {
                uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableSearchCellSubElementBoundingBoxBottom);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableReadTableAsThread != null)
            {
                uIAGetMultipleElementsAsTable["ReadTableAsThread"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableReadTableAsThread);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableRetrieveOutputDataFromThreadId != null)
            {
                uIAGetMultipleElementsAsTable["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableRetrieveOutputDataFromThreadId);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableSecondsToWaitForThread != null)
            {
                uIAGetMultipleElementsAsTable["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableSecondsToWaitForThread);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableMaxElementsToSearch != null)
            {
                uIAGetMultipleElementsAsTable["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableMaxElementsToSearch);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableMaxRelativeSearchDepth != null)
            {
                uIAGetMultipleElementsAsTable["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableMaxRelativeSearchDepth);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableMaxChildElementsToSearchPerNode != null)
            {
                uIAGetMultipleElementsAsTable["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableMaxChildElementsToSearchPerNode);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetMultipleElementsAsTable["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableElementLocalizedControlTypesNotToTraverse);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            uIAGetMultipleElementsAsTablepropCount++;
            uIAGetMultipleElementsAsTable["Workflow"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableWorkflow);
            if (uIAGetMultipleElementsAsTablepropCount > 0)
            {
                callPayload.Body = uIAGetMultipleElementsAsTable;
            }

            return new ApiConnectionAction<UIAGetMultipleElementsAsTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIASetElementScrollPercentageResponse> UIASetElementScrollPercentage(Expression<Func<int>> uIASetElementScrollPercentageParentWindowHandle, Expression<Func<string>> uIASetElementScrollPercentageWorkflow, Expression<Func<string>> uIASetElementScrollPercentageSearchElementName = null, Expression<Func<string>> uIASetElementScrollPercentageSearchElementClassName = null, Expression<Func<string>> uIASetElementScrollPercentageSearchElementAutomationId = null, Expression<Func<string>> uIASetElementScrollPercentageSearchLocalizedControlType = null, Expression<Func<bool>> uIASetElementScrollPercentageSearchSubTree = null, Expression<Func<int>> uIASetElementScrollPercentageMatchIndex = null, Expression<Func<string>> uIASetElementScrollPercentageSearchFilter = null, Expression<Func<string>> uIASetElementScrollPercentageSortByColumn = null, Expression<Func<bool>> uIASetElementScrollPercentageMatchIndexAscending = null, Expression<Func<double>> uIASetElementScrollPercentageHorizontalScrollPercentage = null, Expression<Func<double>> uIASetElementScrollPercentageVerticalScrollPercentage = null, Expression<Func<bool>> uIASetElementScrollPercentageTryScrollPattern = null, Expression<Func<bool>> uIASetElementScrollPercentageTryRangeValuePattern = null, Expression<Func<bool>> uIASetElementScrollPercentageTryValuePattern = null, Expression<Func<int>> uIASetElementScrollPercentageMaxElementsToSearch = null, Expression<Func<int>> uIASetElementScrollPercentageMaxRelativeSearchDepth = null, Expression<Func<int>> uIASetElementScrollPercentageMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIASetElementScrollPercentageElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/UIASetElementScrollPercentage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIASetElementScrollPercentage = new JObject();
            var uIASetElementScrollPercentagepropCount = 0;
            uIASetElementScrollPercentagepropCount++;
            uIASetElementScrollPercentage["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageParentWindowHandle);
            if (uIASetElementScrollPercentageSearchElementName != null)
            {
                uIASetElementScrollPercentage["SearchElementName"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageSearchElementName);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentageSearchElementClassName != null)
            {
                uIASetElementScrollPercentage["SearchElementClassName"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageSearchElementClassName);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentageSearchElementAutomationId != null)
            {
                uIASetElementScrollPercentage["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageSearchElementAutomationId);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentageSearchLocalizedControlType != null)
            {
                uIASetElementScrollPercentage["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageSearchLocalizedControlType);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentageSearchSubTree != null)
            {
                uIASetElementScrollPercentage["SearchSubTree"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageSearchSubTree);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentageMatchIndex != null)
            {
                uIASetElementScrollPercentage["MatchIndex"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageMatchIndex);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentageSearchFilter != null)
            {
                uIASetElementScrollPercentage["SearchFilter"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageSearchFilter);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentageSortByColumn != null)
            {
                uIASetElementScrollPercentage["SortByColumn"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageSortByColumn);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentageMatchIndexAscending != null)
            {
                uIASetElementScrollPercentage["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageMatchIndexAscending);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentageHorizontalScrollPercentage != null)
            {
                uIASetElementScrollPercentage["HorizontalScrollPercentage"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageHorizontalScrollPercentage);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentageVerticalScrollPercentage != null)
            {
                uIASetElementScrollPercentage["VerticalScrollPercentage"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageVerticalScrollPercentage);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentageTryScrollPattern != null)
            {
                uIASetElementScrollPercentage["TryScrollPattern"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageTryScrollPattern);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentageTryRangeValuePattern != null)
            {
                uIASetElementScrollPercentage["TryRangeValuePattern"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageTryRangeValuePattern);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentageTryValuePattern != null)
            {
                uIASetElementScrollPercentage["TryValuePattern"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageTryValuePattern);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentageMaxElementsToSearch != null)
            {
                uIASetElementScrollPercentage["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageMaxElementsToSearch);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentageMaxRelativeSearchDepth != null)
            {
                uIASetElementScrollPercentage["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageMaxRelativeSearchDepth);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentageMaxChildElementsToSearchPerNode != null)
            {
                uIASetElementScrollPercentage["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageMaxChildElementsToSearchPerNode);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentageElementLocalizedControlTypesNotToTraverse != null)
            {
                uIASetElementScrollPercentage["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageElementLocalizedControlTypesNotToTraverse);
                uIASetElementScrollPercentagepropCount++;
            }

            uIASetElementScrollPercentagepropCount++;
            uIASetElementScrollPercentage["Workflow"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageWorkflow);
            if (uIASetElementScrollPercentagepropCount > 0)
            {
                callPayload.Body = uIASetElementScrollPercentage;
            }

            return new ApiConnectionAction<UIASetElementScrollPercentageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementSearchColourRegionResponse> UIAGetElementSearchColourRegion(Expression<Func<int>> uIAGetElementSearchColourRegionParentWindowHandle, Expression<Func<string>> uIAGetElementSearchColourRegionSearchColour, Expression<Func<int>> uIAGetElementSearchColourRegionMaxColourDeviation, Expression<Func<string>> uIAGetElementSearchColourRegionWorkflow, Expression<Func<string>> uIAGetElementSearchColourRegionSearchElementName = null, Expression<Func<string>> uIAGetElementSearchColourRegionSearchElementClassName = null, Expression<Func<string>> uIAGetElementSearchColourRegionSearchElementAutomationId = null, Expression<Func<string>> uIAGetElementSearchColourRegionSearchLocalizedControlType = null, Expression<Func<bool>> uIAGetElementSearchColourRegionSearchSubTree = null, Expression<Func<int>> uIAGetElementSearchColourRegionMatchIndex = null, Expression<Func<string>> uIAGetElementSearchColourRegionSearchFilter = null, Expression<Func<string>> uIAGetElementSearchColourRegionSortByColumn = null, Expression<Func<bool>> uIAGetElementSearchColourRegionMatchIndexAscending = null, Expression<Func<int>> uIAGetElementSearchColourRegionLeftPixelXOffset = null, Expression<Func<int>> uIAGetElementSearchColourRegionRightPixelXOffset = null, Expression<Func<int>> uIAGetElementSearchColourRegionTopPixelYOffset = null, Expression<Func<int>> uIAGetElementSearchColourRegionBottomPixelYOffset = null, Expression<Func<bool>> uIAGetElementSearchColourRegionHideAgent = null, Expression<Func<bool>> uIAGetElementSearchColourRegionReturnPhysicalCoordinates = null, Expression<Func<int>> uIAGetElementSearchColourRegionMaxElementsToSearch = null, Expression<Func<int>> uIAGetElementSearchColourRegionMaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetElementSearchColourRegionMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetElementSearchColourRegionElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/UIAGetElementSearchColourRegion";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetElementSearchColourRegion = new JObject();
            var uIAGetElementSearchColourRegionpropCount = 0;
            uIAGetElementSearchColourRegionpropCount++;
            uIAGetElementSearchColourRegion["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionParentWindowHandle);
            if (uIAGetElementSearchColourRegionSearchElementName != null)
            {
                uIAGetElementSearchColourRegion["SearchElementName"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionSearchElementName);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionSearchElementClassName != null)
            {
                uIAGetElementSearchColourRegion["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionSearchElementClassName);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionSearchElementAutomationId != null)
            {
                uIAGetElementSearchColourRegion["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionSearchElementAutomationId);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionSearchLocalizedControlType != null)
            {
                uIAGetElementSearchColourRegion["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionSearchLocalizedControlType);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionSearchSubTree != null)
            {
                uIAGetElementSearchColourRegion["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionSearchSubTree);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionMatchIndex != null)
            {
                uIAGetElementSearchColourRegion["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionMatchIndex);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionSearchFilter != null)
            {
                uIAGetElementSearchColourRegion["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionSearchFilter);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionSortByColumn != null)
            {
                uIAGetElementSearchColourRegion["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionSortByColumn);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionMatchIndexAscending != null)
            {
                uIAGetElementSearchColourRegion["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionMatchIndexAscending);
                uIAGetElementSearchColourRegionpropCount++;
            }

            uIAGetElementSearchColourRegionpropCount++;
            uIAGetElementSearchColourRegion["SearchColour"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionSearchColour);
            uIAGetElementSearchColourRegionpropCount++;
            uIAGetElementSearchColourRegion["MaxColourDeviation"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionMaxColourDeviation);
            if (uIAGetElementSearchColourRegionLeftPixelXOffset != null)
            {
                uIAGetElementSearchColourRegion["LeftPixelXOffset"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionLeftPixelXOffset);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionRightPixelXOffset != null)
            {
                uIAGetElementSearchColourRegion["RightPixelXOffset"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionRightPixelXOffset);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionTopPixelYOffset != null)
            {
                uIAGetElementSearchColourRegion["TopPixelYOffset"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionTopPixelYOffset);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionBottomPixelYOffset != null)
            {
                uIAGetElementSearchColourRegion["BottomPixelYOffset"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionBottomPixelYOffset);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionHideAgent != null)
            {
                uIAGetElementSearchColourRegion["HideAgent"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionHideAgent);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionReturnPhysicalCoordinates != null)
            {
                uIAGetElementSearchColourRegion["ReturnPhysicalCoordinates"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionReturnPhysicalCoordinates);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionMaxElementsToSearch != null)
            {
                uIAGetElementSearchColourRegion["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionMaxElementsToSearch);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionMaxRelativeSearchDepth != null)
            {
                uIAGetElementSearchColourRegion["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionMaxRelativeSearchDepth);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionMaxChildElementsToSearchPerNode != null)
            {
                uIAGetElementSearchColourRegion["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionMaxChildElementsToSearchPerNode);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetElementSearchColourRegion["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionElementLocalizedControlTypesNotToTraverse);
                uIAGetElementSearchColourRegionpropCount++;
            }

            uIAGetElementSearchColourRegionpropCount++;
            uIAGetElementSearchColourRegion["Workflow"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionWorkflow);
            if (uIAGetElementSearchColourRegionpropCount > 0)
            {
                callPayload.Body = uIAGetElementSearchColourRegion;
            }

            return new ApiConnectionAction<UIAGetElementSearchColourRegionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGlobalMouseClickElementSearchColourRegionResponse> UIAGlobalMouseClickElementSearchColourRegion(Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionParentWindowHandle, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionSearchColour, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionMaxColourDeviation, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionWorkflow, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionSearchElementName = null, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionSearchElementClassName = null, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionSearchElementAutomationId = null, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionSearchLocalizedControlType = null, Expression<Func<bool>> uIAGlobalMouseClickElementSearchColourRegionSearchSubTree = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionMatchIndex = null, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionSearchFilter = null, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionSortByColumn = null, Expression<Func<bool>> uIAGlobalMouseClickElementSearchColourRegionMatchIndexAscending = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionLeftPixelXOffset = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionRightPixelXOffset = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionTopPixelYOffset = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionBottomPixelYOffset = null, Expression<Func<uIAGlobalMouseClickElementSearchColourRegionMouseButtonInput>> uIAGlobalMouseClickElementSearchColourRegionMouseButton = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionClickOffsetX = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionClickOffsetY = null, Expression<Func<uIAGlobalMouseClickElementSearchColourRegionOffsetRelativeToInput>> uIAGlobalMouseClickElementSearchColourRegionOffsetRelativeTo = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionDelayInMilliseconds = null, Expression<Func<bool>> uIAGlobalMouseClickElementSearchColourRegionHideAgent = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionMaxElementsToSearch = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionMaxRelativeSearchDepth = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/UIAGlobalMouseClickElementSearchColourRegion";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGlobalMouseClickElementSearchColourRegion = new JObject();
            var uIAGlobalMouseClickElementSearchColourRegionpropCount = 0;
            uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            uIAGlobalMouseClickElementSearchColourRegion["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionParentWindowHandle);
            if (uIAGlobalMouseClickElementSearchColourRegionSearchElementName != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["SearchElementName"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionSearchElementName);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionSearchElementClassName != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionSearchElementClassName);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionSearchElementAutomationId != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionSearchElementAutomationId);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionSearchLocalizedControlType != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionSearchLocalizedControlType);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionSearchSubTree != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionSearchSubTree);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionMatchIndex != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["MatchIndex"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionMatchIndex);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionSearchFilter != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["SearchFilter"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionSearchFilter);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionSortByColumn != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["SortByColumn"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionSortByColumn);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionMatchIndexAscending != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionMatchIndexAscending);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            uIAGlobalMouseClickElementSearchColourRegion["SearchColour"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionSearchColour);
            uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            uIAGlobalMouseClickElementSearchColourRegion["MaxColourDeviation"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionMaxColourDeviation);
            if (uIAGlobalMouseClickElementSearchColourRegionLeftPixelXOffset != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["LeftPixelXOffset"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionLeftPixelXOffset);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionRightPixelXOffset != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["RightPixelXOffset"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionRightPixelXOffset);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionTopPixelYOffset != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["TopPixelYOffset"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionTopPixelYOffset);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionBottomPixelYOffset != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["BottomPixelYOffset"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionBottomPixelYOffset);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionMouseButton != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["MouseButton"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionMouseButton);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionClickOffsetX != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["ClickOffsetX"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionClickOffsetX);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionClickOffsetY != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["ClickOffsetY"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionClickOffsetY);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionOffsetRelativeTo != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["OffsetRelativeTo"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionOffsetRelativeTo);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionDelayInMilliseconds != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["DelayInMilliseconds"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionDelayInMilliseconds);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionHideAgent != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["HideAgent"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionHideAgent);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionMaxElementsToSearch != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionMaxElementsToSearch);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionMaxRelativeSearchDepth != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionMaxRelativeSearchDepth);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionMaxChildElementsToSearchPerNode != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionMaxChildElementsToSearchPerNode);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionElementLocalizedControlTypesNotToTraverse);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            uIAGlobalMouseClickElementSearchColourRegion["Workflow"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionWorkflow);
            if (uIAGlobalMouseClickElementSearchColourRegionpropCount > 0)
            {
                callPayload.Body = uIAGlobalMouseClickElementSearchColourRegion;
            }

            return new ApiConnectionAction<UIAGlobalMouseClickElementSearchColourRegionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetWin32WindowsResponse> UIAGetWin32Windows(Expression<Func<string>> uIAGetWin32WindowsWorkflow, Expression<Func<string>> uIAGetWin32WindowsSearchClassName = null, Expression<Func<string>> uIAGetWin32WindowsSearchWindowTitle = null, Expression<Func<bool>> uIAGetWin32WindowsTopLevelWindowsOnly = null, Expression<Func<bool>> uIAGetWin32WindowsVisibleWindowsOnly = null, Expression<Func<bool>> uIAGetWin32WindowsWindowsWithTitlebarOnly = null, Expression<Func<bool>> uIAGetWin32WindowsWindowsWithTitleOnly = null, Expression<Func<bool>> uIAGetWin32WindowsIgnoreTransparentWindows = null, Expression<Func<int>> uIAGetWin32WindowsSearchProcessId = null, Expression<Func<string>> uIAGetWin32WindowsSearchFilter = null, Expression<Func<string>> uIAGetWin32WindowsSortByColumn = null, Expression<Func<bool>> uIAGetWin32WindowsMatchIndexAscending = null, Expression<Func<bool>> uIAGetWin32WindowsReturnElementHandle = null, Expression<Func<int>> uIAGetWin32WindowsFirstItemToReturn = null, Expression<Func<int>> uIAGetWin32WindowsMaxItemsToReturn = null)
        {
            var apiCallPath = "/UIAControl/GetWin32Windows";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetWin32Windows = new JObject();
            var uIAGetWin32WindowspropCount = 0;
            if (uIAGetWin32WindowsSearchClassName != null)
            {
                uIAGetWin32Windows["SearchClassName"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsSearchClassName);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsSearchWindowTitle != null)
            {
                uIAGetWin32Windows["SearchWindowTitle"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsSearchWindowTitle);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsTopLevelWindowsOnly != null)
            {
                uIAGetWin32Windows["TopLevelWindowsOnly"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsTopLevelWindowsOnly);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsVisibleWindowsOnly != null)
            {
                uIAGetWin32Windows["VisibleWindowsOnly"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsVisibleWindowsOnly);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsWindowsWithTitlebarOnly != null)
            {
                uIAGetWin32Windows["WindowsWithTitlebarOnly"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsWindowsWithTitlebarOnly);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsWindowsWithTitleOnly != null)
            {
                uIAGetWin32Windows["WindowsWithTitleOnly"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsWindowsWithTitleOnly);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsIgnoreTransparentWindows != null)
            {
                uIAGetWin32Windows["IgnoreTransparentWindows"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsIgnoreTransparentWindows);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsSearchProcessId != null)
            {
                uIAGetWin32Windows["SearchProcessId"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsSearchProcessId);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsSearchFilter != null)
            {
                uIAGetWin32Windows["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsSearchFilter);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsSortByColumn != null)
            {
                uIAGetWin32Windows["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsSortByColumn);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsMatchIndexAscending != null)
            {
                uIAGetWin32Windows["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsMatchIndexAscending);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsReturnElementHandle != null)
            {
                uIAGetWin32Windows["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsReturnElementHandle);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsFirstItemToReturn != null)
            {
                uIAGetWin32Windows["FirstItemToReturn"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsFirstItemToReturn);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsMaxItemsToReturn != null)
            {
                uIAGetWin32Windows["MaxItemsToReturn"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsMaxItemsToReturn);
                uIAGetWin32WindowspropCount++;
            }

            uIAGetWin32WindowspropCount++;
            uIAGetWin32Windows["Workflow"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsWorkflow);
            if (uIAGetWin32WindowspropCount > 0)
            {
                callPayload.Body = uIAGetWin32Windows;
            }

            return new ApiConnectionAction<UIAGetWin32WindowsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<SetUIAElementSearchModeResponse> SetUIAElementSearchMode(Expression<Func<setUIAElementSearchModeUIAElementSearchModeInput>> setUIAElementSearchModeUIAElementSearchMode, Expression<Func<string>> setUIAElementSearchModeWorkflow)
        {
            var apiCallPath = "/UIAControl/SetUIAElementSearchMode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setUIAElementSearchMode = new JObject();
            var setUIAElementSearchModepropCount = 0;
            setUIAElementSearchModepropCount++;
            setUIAElementSearchMode["UIAElementSearchMode"] = ExpressionConverter.ConvertO(setUIAElementSearchModeUIAElementSearchMode);
            setUIAElementSearchModepropCount++;
            setUIAElementSearchMode["Workflow"] = ExpressionConverter.ConvertO(setUIAElementSearchModeWorkflow);
            if (setUIAElementSearchModepropCount > 0)
            {
                callPayload.Body = setUIAElementSearchMode;
            }

            return new ApiConnectionAction<SetUIAElementSearchModeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<GetUIAElementSearchModeResponse> GetUIAElementSearchMode(Expression<Func<string>> getUIAElementSearchModeWorkflow)
        {
            var apiCallPath = "/UIAControl/GetUIAElementSearchMode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getUIAElementSearchMode = new JObject();
            var getUIAElementSearchModepropCount = 0;
            getUIAElementSearchModepropCount++;
            getUIAElementSearchMode["Workflow"] = ExpressionConverter.ConvertO(getUIAElementSearchModeWorkflow);
            if (getUIAElementSearchModepropCount > 0)
            {
                callPayload.Body = getUIAElementSearchMode;
            }

            return new ApiConnectionAction<GetUIAElementSearchModeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementPatternsResponse> UIAGetElementPatterns(Expression<Func<int>> uIAGetElementPatternsParentWindowHandle, Expression<Func<string>> uIAGetElementPatternsWorkflow, Expression<Func<string>> uIAGetElementPatternsSearchElementName = null, Expression<Func<string>> uIAGetElementPatternsSearchElementClassName = null, Expression<Func<string>> uIAGetElementPatternsSearchElementAutomationId = null, Expression<Func<string>> uIAGetElementPatternsSearchLocalizedControlType = null, Expression<Func<bool>> uIAGetElementPatternsSearchSubTree = null, Expression<Func<int>> uIAGetElementPatternsMatchIndex = null, Expression<Func<string>> uIAGetElementPatternsSearchFilter = null, Expression<Func<string>> uIAGetElementPatternsSortByColumn = null, Expression<Func<bool>> uIAGetElementPatternsMatchIndexAscending = null, Expression<Func<int>> uIAGetElementPatternsMaxElementsToSearch = null, Expression<Func<int>> uIAGetElementPatternsMaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetElementPatternsMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetElementPatternsElementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/UIAGetElementPatterns";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetElementPatterns = new JObject();
            var uIAGetElementPatternspropCount = 0;
            uIAGetElementPatternspropCount++;
            uIAGetElementPatterns["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGetElementPatternsParentWindowHandle);
            if (uIAGetElementPatternsSearchElementName != null)
            {
                uIAGetElementPatterns["SearchElementName"] = ExpressionConverter.ConvertO(uIAGetElementPatternsSearchElementName);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternsSearchElementClassName != null)
            {
                uIAGetElementPatterns["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGetElementPatternsSearchElementClassName);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternsSearchElementAutomationId != null)
            {
                uIAGetElementPatterns["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGetElementPatternsSearchElementAutomationId);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternsSearchLocalizedControlType != null)
            {
                uIAGetElementPatterns["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetElementPatternsSearchLocalizedControlType);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternsSearchSubTree != null)
            {
                uIAGetElementPatterns["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetElementPatternsSearchSubTree);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternsMatchIndex != null)
            {
                uIAGetElementPatterns["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetElementPatternsMatchIndex);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternsSearchFilter != null)
            {
                uIAGetElementPatterns["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetElementPatternsSearchFilter);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternsSortByColumn != null)
            {
                uIAGetElementPatterns["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetElementPatternsSortByColumn);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternsMatchIndexAscending != null)
            {
                uIAGetElementPatterns["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetElementPatternsMatchIndexAscending);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternsMaxElementsToSearch != null)
            {
                uIAGetElementPatterns["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetElementPatternsMaxElementsToSearch);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternsMaxRelativeSearchDepth != null)
            {
                uIAGetElementPatterns["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetElementPatternsMaxRelativeSearchDepth);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternsMaxChildElementsToSearchPerNode != null)
            {
                uIAGetElementPatterns["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetElementPatternsMaxChildElementsToSearchPerNode);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternsElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetElementPatterns["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGetElementPatternsElementLocalizedControlTypesNotToTraverse);
                uIAGetElementPatternspropCount++;
            }

            uIAGetElementPatternspropCount++;
            uIAGetElementPatterns["Workflow"] = ExpressionConverter.ConvertO(uIAGetElementPatternsWorkflow);
            if (uIAGetElementPatternspropCount > 0)
            {
                callPayload.Body = uIAGetElementPatterns;
            }

            return new ApiConnectionAction<UIAGetElementPatternsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAMoveElementResponse> UIAMoveElement(Expression<Func<int>> uIAMoveElementParentWindowHandle, Expression<Func<int>> uIAMoveElementHorizontalPosition, Expression<Func<int>> uIAMoveElementVerticalPosition, Expression<Func<string>> uIAMoveElementWorkflow, Expression<Func<string>> uIAMoveElementSearchElementName = null, Expression<Func<string>> uIAMoveElementSearchElementClassName = null, Expression<Func<string>> uIAMoveElementSearchElementAutomationId = null, Expression<Func<string>> uIAMoveElementSearchLocalizedControlType = null, Expression<Func<bool>> uIAMoveElementSearchSubTree = null, Expression<Func<int>> uIAMoveElementMatchIndex = null, Expression<Func<string>> uIAMoveElementSearchFilter = null, Expression<Func<string>> uIAMoveElementSortByColumn = null, Expression<Func<bool>> uIAMoveElementMatchIndexAscending = null, Expression<Func<int>> uIAMoveElementMaxElementsToSearch = null, Expression<Func<int>> uIAMoveElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIAMoveElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAMoveElementElementLocalizedControlTypesNotToTraverse = null, Expression<Func<uIAMoveElementHorizontalMovementTypeInput>> uIAMoveElementHorizontalMovementType = null, Expression<Func<uIAMoveElementVerticalMovementTypeInput>> uIAMoveElementVerticalMovementType = null)
        {
            var apiCallPath = "/UIAControl/UIAMoveElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAMoveElement = new JObject();
            var uIAMoveElementpropCount = 0;
            uIAMoveElementpropCount++;
            uIAMoveElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAMoveElementParentWindowHandle);
            if (uIAMoveElementSearchElementName != null)
            {
                uIAMoveElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAMoveElementSearchElementName);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementSearchElementClassName != null)
            {
                uIAMoveElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAMoveElementSearchElementClassName);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementSearchElementAutomationId != null)
            {
                uIAMoveElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAMoveElementSearchElementAutomationId);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementSearchLocalizedControlType != null)
            {
                uIAMoveElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAMoveElementSearchLocalizedControlType);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementSearchSubTree != null)
            {
                uIAMoveElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAMoveElementSearchSubTree);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementMatchIndex != null)
            {
                uIAMoveElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAMoveElementMatchIndex);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementSearchFilter != null)
            {
                uIAMoveElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAMoveElementSearchFilter);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementSortByColumn != null)
            {
                uIAMoveElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAMoveElementSortByColumn);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementMatchIndexAscending != null)
            {
                uIAMoveElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAMoveElementMatchIndexAscending);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementMaxElementsToSearch != null)
            {
                uIAMoveElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAMoveElementMaxElementsToSearch);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementMaxRelativeSearchDepth != null)
            {
                uIAMoveElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAMoveElementMaxRelativeSearchDepth);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementMaxChildElementsToSearchPerNode != null)
            {
                uIAMoveElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAMoveElementMaxChildElementsToSearchPerNode);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAMoveElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAMoveElementElementLocalizedControlTypesNotToTraverse);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementHorizontalMovementType != null)
            {
                uIAMoveElement["HorizontalMovementType"] = ExpressionConverter.ConvertO(uIAMoveElementHorizontalMovementType);
                uIAMoveElementpropCount++;
            }

            uIAMoveElementpropCount++;
            uIAMoveElement["HorizontalPosition"] = ExpressionConverter.ConvertO(uIAMoveElementHorizontalPosition);
            if (uIAMoveElementVerticalMovementType != null)
            {
                uIAMoveElement["VerticalMovementType"] = ExpressionConverter.ConvertO(uIAMoveElementVerticalMovementType);
                uIAMoveElementpropCount++;
            }

            uIAMoveElementpropCount++;
            uIAMoveElement["VerticalPosition"] = ExpressionConverter.ConvertO(uIAMoveElementVerticalPosition);
            uIAMoveElementpropCount++;
            uIAMoveElement["Workflow"] = ExpressionConverter.ConvertO(uIAMoveElementWorkflow);
            if (uIAMoveElementpropCount > 0)
            {
                callPayload.Body = uIAMoveElement;
            }

            return new ApiConnectionAction<UIAMoveElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAResizeElementResponse> UIAResizeElement(Expression<Func<int>> uIAResizeElementParentWindowHandle, Expression<Func<int>> uIAResizeElementNewWidth, Expression<Func<int>> uIAResizeElementNewHeight, Expression<Func<string>> uIAResizeElementWorkflow, Expression<Func<string>> uIAResizeElementSearchElementName = null, Expression<Func<string>> uIAResizeElementSearchElementClassName = null, Expression<Func<string>> uIAResizeElementSearchElementAutomationId = null, Expression<Func<string>> uIAResizeElementSearchLocalizedControlType = null, Expression<Func<bool>> uIAResizeElementSearchSubTree = null, Expression<Func<int>> uIAResizeElementMatchIndex = null, Expression<Func<string>> uIAResizeElementSearchFilter = null, Expression<Func<string>> uIAResizeElementSortByColumn = null, Expression<Func<bool>> uIAResizeElementMatchIndexAscending = null, Expression<Func<int>> uIAResizeElementMaxElementsToSearch = null, Expression<Func<int>> uIAResizeElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIAResizeElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAResizeElementElementLocalizedControlTypesNotToTraverse = null, Expression<Func<uIAResizeElementResizeWidthTypeInput>> uIAResizeElementResizeWidthType = null, Expression<Func<uIAResizeElementResizeHeightTypeInput>> uIAResizeElementResizeHeightType = null)
        {
            var apiCallPath = "/UIAControl/UIAResizeElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAResizeElement = new JObject();
            var uIAResizeElementpropCount = 0;
            uIAResizeElementpropCount++;
            uIAResizeElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAResizeElementParentWindowHandle);
            if (uIAResizeElementSearchElementName != null)
            {
                uIAResizeElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAResizeElementSearchElementName);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementSearchElementClassName != null)
            {
                uIAResizeElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAResizeElementSearchElementClassName);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementSearchElementAutomationId != null)
            {
                uIAResizeElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAResizeElementSearchElementAutomationId);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementSearchLocalizedControlType != null)
            {
                uIAResizeElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAResizeElementSearchLocalizedControlType);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementSearchSubTree != null)
            {
                uIAResizeElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAResizeElementSearchSubTree);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementMatchIndex != null)
            {
                uIAResizeElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAResizeElementMatchIndex);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementSearchFilter != null)
            {
                uIAResizeElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAResizeElementSearchFilter);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementSortByColumn != null)
            {
                uIAResizeElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAResizeElementSortByColumn);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementMatchIndexAscending != null)
            {
                uIAResizeElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAResizeElementMatchIndexAscending);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementMaxElementsToSearch != null)
            {
                uIAResizeElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAResizeElementMaxElementsToSearch);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementMaxRelativeSearchDepth != null)
            {
                uIAResizeElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAResizeElementMaxRelativeSearchDepth);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementMaxChildElementsToSearchPerNode != null)
            {
                uIAResizeElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAResizeElementMaxChildElementsToSearchPerNode);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAResizeElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAResizeElementElementLocalizedControlTypesNotToTraverse);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementResizeWidthType != null)
            {
                uIAResizeElement["ResizeWidthType"] = ExpressionConverter.ConvertO(uIAResizeElementResizeWidthType);
                uIAResizeElementpropCount++;
            }

            uIAResizeElementpropCount++;
            uIAResizeElement["NewWidth"] = ExpressionConverter.ConvertO(uIAResizeElementNewWidth);
            if (uIAResizeElementResizeHeightType != null)
            {
                uIAResizeElement["ResizeHeightType"] = ExpressionConverter.ConvertO(uIAResizeElementResizeHeightType);
                uIAResizeElementpropCount++;
            }

            uIAResizeElementpropCount++;
            uIAResizeElement["NewHeight"] = ExpressionConverter.ConvertO(uIAResizeElementNewHeight);
            uIAResizeElementpropCount++;
            uIAResizeElement["Workflow"] = ExpressionConverter.ConvertO(uIAResizeElementWorkflow);
            if (uIAResizeElementpropCount > 0)
            {
                callPayload.Body = uIAResizeElement;
            }

            return new ApiConnectionAction<UIAResizeElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIALocateVisibleSearchImageWithinElementResponse> UIALocateVisibleSearchImageWithinElement(Expression<Func<int>> uIALocateVisibleSearchImageWithinElementParentWindowHandle, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementWorkflow, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementSearchElementName = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementSearchElementClassName = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementSearchElementAutomationId = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementSearchLocalizedControlType = null, Expression<Func<bool>> uIALocateVisibleSearchImageWithinElementSearchSubTree = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementMatchIndex = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementSearchFilter = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementSortByColumn = null, Expression<Func<bool>> uIALocateVisibleSearchImageWithinElementMatchIndexAscending = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementMaxElementsToSearch = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementElementLocalizedControlTypesNotToTraverse = null, Expression<Func<uIALocateVisibleSearchImageWithinElementSearchImageTypeInput>> uIALocateVisibleSearchImageWithinElementSearchImageType = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementSearchImage = null, Expression<Func<uIALocateVisibleSearchImageWithinElementAltSearchImageTypeInput>> uIALocateVisibleSearchImageWithinElementAltSearchImageType = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementAltSearchImage = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementMaxColourDeviation = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementMaxPixelDifferences = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementMaxConsecutivePixelDifferences = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementLeftPixelXOffset = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementRightPixelXOffset = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementTopPixelYOffset = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementBottomPixelYOffset = null, Expression<Func<uIALocateVisibleSearchImageWithinElementPixelXOffsetsUnitInput>> uIALocateVisibleSearchImageWithinElementPixelXOffsetsUnit = null, Expression<Func<uIALocateVisibleSearchImageWithinElementPixelYOffsetsUnitInput>> uIALocateVisibleSearchImageWithinElementPixelYOffsetsUnit = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementSearchImageIndex = null, Expression<Func<uIALocateVisibleSearchImageWithinElementImageSearchDirectionInput>> uIALocateVisibleSearchImageWithinElementImageSearchDirection = null, Expression<Func<bool>> uIALocateVisibleSearchImageWithinElementHideAgent = null, Expression<Func<bool>> uIALocateVisibleSearchImageWithinElementReturnPhysicalCoordinates = null, Expression<Func<bool>> uIALocateVisibleSearchImageWithinElementShowHighlightRectangle = null)
        {
            var apiCallPath = "/UIAControl/UIALocateVisibleSearchImageWithinElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIALocateVisibleSearchImageWithinElement = new JObject();
            var uIALocateVisibleSearchImageWithinElementpropCount = 0;
            uIALocateVisibleSearchImageWithinElementpropCount++;
            uIALocateVisibleSearchImageWithinElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementParentWindowHandle);
            if (uIALocateVisibleSearchImageWithinElementSearchElementName != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchElementName"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementSearchElementName);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementSearchElementClassName != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementSearchElementClassName);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementSearchElementAutomationId != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementSearchElementAutomationId);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementSearchLocalizedControlType != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementSearchLocalizedControlType);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementSearchSubTree != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementSearchSubTree);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementMatchIndex != null)
            {
                uIALocateVisibleSearchImageWithinElement["MatchIndex"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementMatchIndex);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementSearchFilter != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchFilter"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementSearchFilter);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementSortByColumn != null)
            {
                uIALocateVisibleSearchImageWithinElement["SortByColumn"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementSortByColumn);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementMatchIndexAscending != null)
            {
                uIALocateVisibleSearchImageWithinElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementMatchIndexAscending);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementMaxElementsToSearch != null)
            {
                uIALocateVisibleSearchImageWithinElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementMaxElementsToSearch);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementMaxRelativeSearchDepth != null)
            {
                uIALocateVisibleSearchImageWithinElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementMaxRelativeSearchDepth);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementMaxChildElementsToSearchPerNode != null)
            {
                uIALocateVisibleSearchImageWithinElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementMaxChildElementsToSearchPerNode);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIALocateVisibleSearchImageWithinElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementElementLocalizedControlTypesNotToTraverse);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementSearchImageType != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchImageType"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementSearchImageType);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementSearchImage != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchImage"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementSearchImage);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementAltSearchImageType != null)
            {
                uIALocateVisibleSearchImageWithinElement["AltSearchImageType"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementAltSearchImageType);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementAltSearchImage != null)
            {
                uIALocateVisibleSearchImageWithinElement["AltSearchImage"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementAltSearchImage);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementMaxColourDeviation != null)
            {
                uIALocateVisibleSearchImageWithinElement["MaxColourDeviation"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementMaxColourDeviation);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementMaxPixelDifferences != null)
            {
                uIALocateVisibleSearchImageWithinElement["MaxPixelDifferences"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementMaxPixelDifferences);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementMaxConsecutivePixelDifferences != null)
            {
                uIALocateVisibleSearchImageWithinElement["MaxConsecutivePixelDifferences"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementMaxConsecutivePixelDifferences);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementLeftPixelXOffset != null)
            {
                uIALocateVisibleSearchImageWithinElement["LeftPixelXOffset"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementLeftPixelXOffset);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementRightPixelXOffset != null)
            {
                uIALocateVisibleSearchImageWithinElement["RightPixelXOffset"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementRightPixelXOffset);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementTopPixelYOffset != null)
            {
                uIALocateVisibleSearchImageWithinElement["TopPixelYOffset"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementTopPixelYOffset);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementBottomPixelYOffset != null)
            {
                uIALocateVisibleSearchImageWithinElement["BottomPixelYOffset"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementBottomPixelYOffset);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementPixelXOffsetsUnit != null)
            {
                uIALocateVisibleSearchImageWithinElement["PixelXOffsetsUnit"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementPixelXOffsetsUnit);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementPixelYOffsetsUnit != null)
            {
                uIALocateVisibleSearchImageWithinElement["PixelYOffsetsUnit"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementPixelYOffsetsUnit);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementSearchImageIndex != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchImageIndex"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementSearchImageIndex);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementImageSearchDirection != null)
            {
                uIALocateVisibleSearchImageWithinElement["ImageSearchDirection"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementImageSearchDirection);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementHideAgent != null)
            {
                uIALocateVisibleSearchImageWithinElement["HideAgent"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementHideAgent);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementReturnPhysicalCoordinates != null)
            {
                uIALocateVisibleSearchImageWithinElement["ReturnPhysicalCoordinates"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementReturnPhysicalCoordinates);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementShowHighlightRectangle != null)
            {
                uIALocateVisibleSearchImageWithinElement["ShowHighlightRectangle"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementShowHighlightRectangle);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            uIALocateVisibleSearchImageWithinElementpropCount++;
            uIALocateVisibleSearchImageWithinElement["Workflow"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementWorkflow);
            if (uIALocateVisibleSearchImageWithinElementpropCount > 0)
            {
                callPayload.Body = uIALocateVisibleSearchImageWithinElement;
            }

            return new ApiConnectionAction<UIALocateVisibleSearchImageWithinElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForVisibleSearchImageWithinElementResponse> UIAWaitForVisibleSearchImageWithinElement(Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementWorkflow, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementParentWindowHandle = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementSearchElementName = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementSearchElementClassName = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementSearchElementAutomationId = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementSearchLocalizedControlType = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageWithinElementSearchSubTree = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementMatchIndex = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementSearchFilter = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementSortByColumn = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageWithinElementMatchIndexAscending = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementMaxElementsToSearch = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementElementLocalizedControlTypesNotToTraverse = null, Expression<Func<uIAWaitForVisibleSearchImageWithinElementSearchImageTypeInput>> uIAWaitForVisibleSearchImageWithinElementSearchImageType = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementSearchImage = null, Expression<Func<uIAWaitForVisibleSearchImageWithinElementAltSearchImageTypeInput>> uIAWaitForVisibleSearchImageWithinElementAltSearchImageType = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementAltSearchImage = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementMaxColourDeviation = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementMaxPixelDifferences = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementMaxConsecutivePixelDifferences = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementLeftPixelXOffset = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementRightPixelXOffset = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementTopPixelYOffset = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementBottomPixelYOffset = null, Expression<Func<uIAWaitForVisibleSearchImageWithinElementPixelXOffsetsUnitInput>> uIAWaitForVisibleSearchImageWithinElementPixelXOffsetsUnit = null, Expression<Func<uIAWaitForVisibleSearchImageWithinElementPixelYOffsetsUnitInput>> uIAWaitForVisibleSearchImageWithinElementPixelYOffsetsUnit = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementSearchImageIndex = null, Expression<Func<uIAWaitForVisibleSearchImageWithinElementImageSearchDirectionInput>> uIAWaitForVisibleSearchImageWithinElementImageSearchDirection = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageWithinElementHideAgent = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageWithinElementReturnPhysicalCoordinates = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageWithinElementShowHighlightRectangle = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementSecondsToWait = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementMillisecondsBetweenSearches = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageWithinElementRaiseExceptionIfImageNotFound = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementRetrieveOutputDataFromThreadId = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageWithinElementWaitForThread = null)
        {
            var apiCallPath = "/UIAControl/UIAWaitForVisibleSearchImageWithinElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAWaitForVisibleSearchImageWithinElement = new JObject();
            var uIAWaitForVisibleSearchImageWithinElementpropCount = 0;
            if (uIAWaitForVisibleSearchImageWithinElementParentWindowHandle != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementParentWindowHandle);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementSearchElementName != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementSearchElementName);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementSearchElementClassName != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementSearchElementClassName);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementSearchElementAutomationId != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementSearchElementAutomationId);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementSearchLocalizedControlType != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementSearchLocalizedControlType);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementSearchSubTree != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementSearchSubTree);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementMatchIndex != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementMatchIndex);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementSearchFilter != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementSearchFilter);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementSortByColumn != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementSortByColumn);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementMatchIndexAscending != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementMatchIndexAscending);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementMaxElementsToSearch != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementMaxElementsToSearch);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementMaxRelativeSearchDepth != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementMaxRelativeSearchDepth);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementMaxChildElementsToSearchPerNode != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementMaxChildElementsToSearchPerNode);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementElementLocalizedControlTypesNotToTraverse);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementSearchImageType != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchImageType"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementSearchImageType);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementSearchImage != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchImage"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementSearchImage);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementAltSearchImageType != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["AltSearchImageType"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementAltSearchImageType);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementAltSearchImage != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["AltSearchImage"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementAltSearchImage);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementMaxColourDeviation != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["MaxColourDeviation"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementMaxColourDeviation);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementMaxPixelDifferences != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["MaxPixelDifferences"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementMaxPixelDifferences);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementMaxConsecutivePixelDifferences != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["MaxConsecutivePixelDifferences"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementMaxConsecutivePixelDifferences);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementLeftPixelXOffset != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["LeftPixelXOffset"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementLeftPixelXOffset);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementRightPixelXOffset != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["RightPixelXOffset"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementRightPixelXOffset);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementTopPixelYOffset != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["TopPixelYOffset"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementTopPixelYOffset);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementBottomPixelYOffset != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["BottomPixelYOffset"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementBottomPixelYOffset);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementPixelXOffsetsUnit != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["PixelXOffsetsUnit"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementPixelXOffsetsUnit);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementPixelYOffsetsUnit != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["PixelYOffsetsUnit"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementPixelYOffsetsUnit);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementSearchImageIndex != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchImageIndex"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementSearchImageIndex);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementImageSearchDirection != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["ImageSearchDirection"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementImageSearchDirection);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementHideAgent != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["HideAgent"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementHideAgent);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementReturnPhysicalCoordinates != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["ReturnPhysicalCoordinates"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementReturnPhysicalCoordinates);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementShowHighlightRectangle != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["ShowHighlightRectangle"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementShowHighlightRectangle);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementSecondsToWait != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementSecondsToWait);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementMillisecondsBetweenSearches != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["MillisecondsBetweenSearches"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementMillisecondsBetweenSearches);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementRaiseExceptionIfImageNotFound != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["RaiseExceptionIfImageNotFound"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementRaiseExceptionIfImageNotFound);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementRetrieveOutputDataFromThreadId != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementRetrieveOutputDataFromThreadId);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementWaitForThread != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["WaitForThread"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementWaitForThread);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            uIAWaitForVisibleSearchImageWithinElementpropCount++;
            uIAWaitForVisibleSearchImageWithinElement["Workflow"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementWorkflow);
            if (uIAWaitForVisibleSearchImageWithinElementpropCount > 0)
            {
                callPayload.Body = uIAWaitForVisibleSearchImageWithinElement;
            }

            return new ApiConnectionAction<UIAWaitForVisibleSearchImageWithinElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForVisibleSearchImageToNotExistWithinElementResponse> UIAWaitForVisibleSearchImageToNotExistWithinElement(Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementWorkflow, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementParentWindowHandle = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementSearchElementName = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementSearchElementClassName = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementSearchElementAutomationId = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementSearchLocalizedControlType = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageToNotExistWithinElementSearchSubTree = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementMatchIndex = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementSearchFilter = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementSortByColumn = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageToNotExistWithinElementMatchIndexAscending = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementMaxElementsToSearch = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementMaxRelativeSearchDepth = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementMaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementElementLocalizedControlTypesNotToTraverse = null, Expression<Func<uIAWaitForVisibleSearchImageToNotExistWithinElementSearchImageTypeInput>> uIAWaitForVisibleSearchImageToNotExistWithinElementSearchImageType = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementSearchImage = null, Expression<Func<uIAWaitForVisibleSearchImageToNotExistWithinElementAltSearchImageTypeInput>> uIAWaitForVisibleSearchImageToNotExistWithinElementAltSearchImageType = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementAltSearchImage = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementMaxColourDeviation = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementMaxPixelDifferences = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementMaxConsecutivePixelDifferences = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementLeftPixelXOffset = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementRightPixelXOffset = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementTopPixelYOffset = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementBottomPixelYOffset = null, Expression<Func<uIAWaitForVisibleSearchImageToNotExistWithinElementPixelXOffsetsUnitInput>> uIAWaitForVisibleSearchImageToNotExistWithinElementPixelXOffsetsUnit = null, Expression<Func<uIAWaitForVisibleSearchImageToNotExistWithinElementPixelYOffsetsUnitInput>> uIAWaitForVisibleSearchImageToNotExistWithinElementPixelYOffsetsUnit = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementSearchImageIndex = null, Expression<Func<uIAWaitForVisibleSearchImageToNotExistWithinElementImageSearchDirectionInput>> uIAWaitForVisibleSearchImageToNotExistWithinElementImageSearchDirection = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageToNotExistWithinElementHideAgent = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageToNotExistWithinElementShowHighlightRectangle = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementSecondsToWait = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementMillisecondsBetweenSearches = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageToNotExistWithinElementRaiseExceptionIfImageStillPresent = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementRetrieveOutputDataFromThreadId = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageToNotExistWithinElementWaitForThread = null)
        {
            var apiCallPath = "/UIAControl/UIAWaitForVisibleSearchImageToNotExistWithinElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAWaitForVisibleSearchImageToNotExistWithinElement = new JObject();
            var uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount = 0;
            if (uIAWaitForVisibleSearchImageToNotExistWithinElementParentWindowHandle != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementParentWindowHandle);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementSearchElementName != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementSearchElementName);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementSearchElementClassName != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementSearchElementClassName);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementSearchElementAutomationId != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementSearchElementAutomationId);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementSearchLocalizedControlType != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementSearchLocalizedControlType);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementSearchSubTree != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementSearchSubTree);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementMatchIndex != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementMatchIndex);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementSearchFilter != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementSearchFilter);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementSortByColumn != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementSortByColumn);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementMatchIndexAscending != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementMatchIndexAscending);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementMaxElementsToSearch != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementMaxElementsToSearch);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementMaxRelativeSearchDepth != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementMaxRelativeSearchDepth);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementMaxChildElementsToSearchPerNode != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementMaxChildElementsToSearchPerNode);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementElementLocalizedControlTypesNotToTraverse != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementElementLocalizedControlTypesNotToTraverse);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementSearchImageType != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchImageType"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementSearchImageType);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementSearchImage != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchImage"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementSearchImage);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementAltSearchImageType != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["AltSearchImageType"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementAltSearchImageType);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementAltSearchImage != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["AltSearchImage"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementAltSearchImage);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementMaxColourDeviation != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxColourDeviation"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementMaxColourDeviation);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementMaxPixelDifferences != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxPixelDifferences"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementMaxPixelDifferences);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementMaxConsecutivePixelDifferences != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxConsecutivePixelDifferences"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementMaxConsecutivePixelDifferences);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementLeftPixelXOffset != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["LeftPixelXOffset"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementLeftPixelXOffset);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementRightPixelXOffset != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["RightPixelXOffset"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementRightPixelXOffset);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementTopPixelYOffset != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["TopPixelYOffset"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementTopPixelYOffset);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementBottomPixelYOffset != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["BottomPixelYOffset"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementBottomPixelYOffset);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementPixelXOffsetsUnit != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["PixelXOffsetsUnit"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementPixelXOffsetsUnit);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementPixelYOffsetsUnit != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["PixelYOffsetsUnit"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementPixelYOffsetsUnit);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementSearchImageIndex != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchImageIndex"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementSearchImageIndex);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementImageSearchDirection != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["ImageSearchDirection"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementImageSearchDirection);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementHideAgent != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["HideAgent"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementHideAgent);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementShowHighlightRectangle != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["ShowHighlightRectangle"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementShowHighlightRectangle);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementSecondsToWait != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementSecondsToWait);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementMillisecondsBetweenSearches != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MillisecondsBetweenSearches"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementMillisecondsBetweenSearches);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementRaiseExceptionIfImageStillPresent != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["RaiseExceptionIfImageStillPresent"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementRaiseExceptionIfImageStillPresent);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementRetrieveOutputDataFromThreadId != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementRetrieveOutputDataFromThreadId);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementWaitForThread != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["WaitForThread"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementWaitForThread);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            uIAWaitForVisibleSearchImageToNotExistWithinElement["Workflow"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementWorkflow);
            if (uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount > 0)
            {
                callPayload.Body = uIAWaitForVisibleSearchImageToNotExistWithinElement;
            }

            return new ApiConnectionAction<UIAWaitForVisibleSearchImageToNotExistWithinElementResponse>(callPayload);
        }
    }

    public class IaconnectuiTriggers([ConnectionName] string connectionId)
    {
    }

    public class UIADoesTopLevelWindowExistResponse
    {
        public bool WindowExists { get; set; }
    }

    public class UIAGetHandleForTopLevelWindowResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
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

    public class UIADoesProcessHaveWindowResponse
    {
        public bool ProcessHasWindow { get; set; }
    }

    public class UIAGetHandleForProcessMainWindowResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
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

    public class UIAGetHandleForProcessIdMainWindowResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
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

    public class UIAGetHandleForFocussedElementResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAGetHandleForMainWindowOfFocussedElementResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAGetHandleForDesktopResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
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

    public class UIADoesDesktopElementExistResponse
    {
        public bool ElementExists { get; set; }
        public int ElementHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
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

    public class UIAWaitForDesktopElementResponse
    {
        public bool ElementExists { get; set; }
        public int ElementHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAWaitForElementToNotExistResponse
    {
        public bool ElementExistsBeforeWait { get; set; }
        public bool ElementExistsAfterWait { get; set; }
    }

    public class UIAWaitForDesktopElementToNotExistResponse
    {
        public bool ElementExistsBeforeWait { get; set; }
        public bool ElementExistsAfterWait { get; set; }
    }

    public enum uIAGlobalMouseClickOnElementOffsetRelativeToInput
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

    public enum uIAGlobalRightMouseClickOnElementOffsetRelativeToInput
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

    public enum uIAGlobalMiddleMouseClickOnElementOffsetRelativeToInput
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

    public enum uIAGlobalDoubleLeftMouseClickOnElementOffsetRelativeToInput
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

    public class UIAIsElementCheckedResponse
    {
        public bool ElementIsChecked { get; set; }
    }

    public class UIAGetElementTextValueResponse
    {
        public string ElementTextValue { get; set; }
    }

    public class UIAGetElementValueResponse
    {
        public string ElementValue { get; set; }
    }

    public class UIAGetElementLabelValueResponse
    {
        public string ElementLabelValue { get; set; }
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

    public class UIAGetMultipleElementPropertiesResponse
    {
        public int NumberOfElementsFound { get; set; }
        public int NumberOfElementsReturned { get; set; }
        public JToken[] ElementProperties { get; set; }
    }

    public class UIAGetDesktopElementsResponse
    {
        public int NumberOfElementsFound { get; set; }
        public int NumberOfElementsReturned { get; set; }
        public JToken[] ElementProperties { get; set; }
    }

    public class UIATakeScreenShotOfElementLocationResponse
    {
        public string ScreenBitmapBase64 { get; set; }
    }

    public enum uIATakeScreenShotOfElementLocationImageFormatInput
    {
        PNG,
        JPG,
        BMP,
        GIF
    }

    public class UIAGetParentElementHandleResponse
    {
        public int ParentElementHandle { get; set; }
    }

    public class UIAGetDataGridElementContentsResponse
    {
        public string DataGridContentsJSON { get; set; }
        public int NumberOfRowsInTable { get; set; }
        public int NumberOfColumnsInTable { get; set; }
        public int ThreadId { get; set; }
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

    public class UIAGetListElementItemsResponse
    {
        public int NumberOfListItems { get; set; }
        public string ListItemsJSON { get; set; }
        public int NumberOfSelectedItems { get; set; }
        public int IndexOfFirstSelectedItem { get; set; }
        public string SelectedItemName { get; set; }
    }

    public class UIAGetElementPropertiesAsListResponse
    {
        public int NumberOfElementsFound { get; set; }
        public int NumberOfElementsReturned { get; set; }
        public string UIAElementPropertiesJSON { get; set; }
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

    public class UIAGetMultipleParentElementPropertiesResponse
    {
        public JToken[] UIAParentElements { get; set; }
        public int NumberOfParentElementsReturned { get; set; }
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

    public class UIAGetMultipleElementsAsTableResponse
    {
        public int NumberOfCellSubElementsFound { get; set; }
        public int NumberOfCellSubElementsReturned { get; set; }
        public string TableContentsJSON { get; set; }
        public int NumberOfRowsInTable { get; set; }
        public int NumberOfColumnsInTable { get; set; }
        public int ThreadId { get; set; }
    }

    public class UIASetElementScrollPercentageResponse
    {
        public bool UIASetElementScrollPercentageResult { get; set; }
        public string ErrorMessage { get; set; }
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

    public class UIAGlobalMouseClickElementSearchColourRegionResponse
    {
        public bool UIAGlobalMouseClickElementSearchColourRegionResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public enum uIAGlobalMouseClickElementSearchColourRegionMouseButtonInput
    {
        Left,
        Right,
        Middle,
        [EnumMember(Value = "Double left")]
        DoubleLeft
    }

    public enum uIAGlobalMouseClickElementSearchColourRegionOffsetRelativeToInput
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

    public class SetUIAElementSearchModeResponse
    {
        public bool SetUIAElementSearchModeResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public enum setUIAElementSearchModeUIAElementSearchModeInput
    {
        FindAll,
        TreeWalkRaw
    }

    public class GetUIAElementSearchModeResponse
    {
        public string UIAElementSearchMode { get; set; }
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

    public class UIAMoveElementResponse
    {
        public bool UIAMoveElementResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public enum uIAMoveElementHorizontalMovementTypeInput
    {
        Absolute,
        Relative
    }

    public enum uIAMoveElementVerticalMovementTypeInput
    {
        Absolute,
        Relative
    }

    public class UIAResizeElementResponse
    {
        public bool UIAResizeElementResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public enum uIAResizeElementResizeWidthTypeInput
    {
        Absolute,
        Relative
    }

    public enum uIAResizeElementResizeHeightTypeInput
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

    public enum uIALocateVisibleSearchImageWithinElementSearchImageTypeInput
    {
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    public enum uIALocateVisibleSearchImageWithinElementAltSearchImageTypeInput
    {
        None,
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    public enum uIALocateVisibleSearchImageWithinElementPixelXOffsetsUnitInput
    {
        Pixel,
        Percent
    }

    public enum uIALocateVisibleSearchImageWithinElementPixelYOffsetsUnitInput
    {
        Pixel,
        Percent
    }

    public enum uIALocateVisibleSearchImageWithinElementImageSearchDirectionInput
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

    public enum uIAWaitForVisibleSearchImageWithinElementSearchImageTypeInput
    {
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    public enum uIAWaitForVisibleSearchImageWithinElementAltSearchImageTypeInput
    {
        None,
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    public enum uIAWaitForVisibleSearchImageWithinElementPixelXOffsetsUnitInput
    {
        Pixel,
        Percent
    }

    public enum uIAWaitForVisibleSearchImageWithinElementPixelYOffsetsUnitInput
    {
        Pixel,
        Percent
    }

    public enum uIAWaitForVisibleSearchImageWithinElementImageSearchDirectionInput
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

    public enum uIAWaitForVisibleSearchImageToNotExistWithinElementSearchImageTypeInput
    {
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    public enum uIAWaitForVisibleSearchImageToNotExistWithinElementAltSearchImageTypeInput
    {
        None,
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    public enum uIAWaitForVisibleSearchImageToNotExistWithinElementPixelXOffsetsUnitInput
    {
        Pixel,
        Percent
    }

    public enum uIAWaitForVisibleSearchImageToNotExistWithinElementPixelYOffsetsUnitInput
    {
        Pixel,
        Percent
    }

    public enum uIAWaitForVisibleSearchImageToNotExistWithinElementImageSearchDirectionInput
    {
        FromTop,
        FromBottom,
        FromLeft,
        FromRight
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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