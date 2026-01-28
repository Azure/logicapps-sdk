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
        public IBodyWorkflowAction<UIADoesTopLevelWindowExistResponse> UIADoesTopLevelWindowExist(Expression<Func<string>> uIADoesTopLevelWindowExistworkflow, Expression<Func<string>> uIADoesTopLevelWindowExistsearchClassName = null, Expression<Func<string>> uIADoesTopLevelWindowExistsearchWindowTitle = null, Expression<Func<int>> uIADoesTopLevelWindowExistsearchProcessId = null, Expression<Func<int>> uIADoesTopLevelWindowExistmatchIndex = null, Expression<Func<string>> uIADoesTopLevelWindowExistsearchFilter = null)
        {
            var apiCallPath = "/UIAControl/DoesTopLevelWindowExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIADoesTopLevelWindowExist = new JObject();
            var uIADoesTopLevelWindowExistpropCount = 0;
            if (uIADoesTopLevelWindowExistsearchClassName != null)
            {
                uIADoesTopLevelWindowExist["SearchClassName"] = ExpressionConverter.ConvertO(uIADoesTopLevelWindowExistsearchClassName);
                uIADoesTopLevelWindowExistpropCount++;
            }

            if (uIADoesTopLevelWindowExistsearchWindowTitle != null)
            {
                uIADoesTopLevelWindowExist["SearchWindowTitle"] = ExpressionConverter.ConvertO(uIADoesTopLevelWindowExistsearchWindowTitle);
                uIADoesTopLevelWindowExistpropCount++;
            }

            if (uIADoesTopLevelWindowExistsearchProcessId != null)
            {
                uIADoesTopLevelWindowExist["SearchProcessId"] = ExpressionConverter.ConvertO(uIADoesTopLevelWindowExistsearchProcessId);
                uIADoesTopLevelWindowExistpropCount++;
            }

            if (uIADoesTopLevelWindowExistmatchIndex != null)
            {
                uIADoesTopLevelWindowExist["MatchIndex"] = ExpressionConverter.ConvertO(uIADoesTopLevelWindowExistmatchIndex);
                uIADoesTopLevelWindowExistpropCount++;
            }

            if (uIADoesTopLevelWindowExistsearchFilter != null)
            {
                uIADoesTopLevelWindowExist["SearchFilter"] = ExpressionConverter.ConvertO(uIADoesTopLevelWindowExistsearchFilter);
                uIADoesTopLevelWindowExistpropCount++;
            }

            uIADoesTopLevelWindowExistpropCount++;
            uIADoesTopLevelWindowExist["Workflow"] = ExpressionConverter.ConvertO(uIADoesTopLevelWindowExistworkflow);
            if (uIADoesTopLevelWindowExistpropCount > 0)
            {
                callPayload.Body = uIADoesTopLevelWindowExist;
            }

            return new ApiConnectionAction<UIADoesTopLevelWindowExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForTopLevelWindowResponse> UIAGetHandleForTopLevelWindow(Expression<Func<string>> uIAGetHandleForTopLevelWindowworkflow, Expression<Func<string>> uIAGetHandleForTopLevelWindowsearchClassName = null, Expression<Func<string>> uIAGetHandleForTopLevelWindowsearchWindowTitle = null, Expression<Func<int>> uIAGetHandleForTopLevelWindowsearchProcessId = null, Expression<Func<int>> uIAGetHandleForTopLevelWindowmatchIndex = null, Expression<Func<string>> uIAGetHandleForTopLevelWindowsearchFilter = null, Expression<Func<string>> uIAGetHandleForTopLevelWindowsortByColumn = null, Expression<Func<bool>> uIAGetHandleForTopLevelWindowmatchIndexAscending = null)
        {
            var apiCallPath = "/UIAControl/GetHandleForTopLevelWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetHandleForTopLevelWindow = new JObject();
            var uIAGetHandleForTopLevelWindowpropCount = 0;
            if (uIAGetHandleForTopLevelWindowsearchClassName != null)
            {
                uIAGetHandleForTopLevelWindow["SearchClassName"] = ExpressionConverter.ConvertO(uIAGetHandleForTopLevelWindowsearchClassName);
                uIAGetHandleForTopLevelWindowpropCount++;
            }

            if (uIAGetHandleForTopLevelWindowsearchWindowTitle != null)
            {
                uIAGetHandleForTopLevelWindow["SearchWindowTitle"] = ExpressionConverter.ConvertO(uIAGetHandleForTopLevelWindowsearchWindowTitle);
                uIAGetHandleForTopLevelWindowpropCount++;
            }

            if (uIAGetHandleForTopLevelWindowsearchProcessId != null)
            {
                uIAGetHandleForTopLevelWindow["SearchProcessId"] = ExpressionConverter.ConvertO(uIAGetHandleForTopLevelWindowsearchProcessId);
                uIAGetHandleForTopLevelWindowpropCount++;
            }

            if (uIAGetHandleForTopLevelWindowmatchIndex != null)
            {
                uIAGetHandleForTopLevelWindow["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetHandleForTopLevelWindowmatchIndex);
                uIAGetHandleForTopLevelWindowpropCount++;
            }

            if (uIAGetHandleForTopLevelWindowsearchFilter != null)
            {
                uIAGetHandleForTopLevelWindow["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetHandleForTopLevelWindowsearchFilter);
                uIAGetHandleForTopLevelWindowpropCount++;
            }

            if (uIAGetHandleForTopLevelWindowsortByColumn != null)
            {
                uIAGetHandleForTopLevelWindow["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetHandleForTopLevelWindowsortByColumn);
                uIAGetHandleForTopLevelWindowpropCount++;
            }

            if (uIAGetHandleForTopLevelWindowmatchIndexAscending != null)
            {
                uIAGetHandleForTopLevelWindow["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetHandleForTopLevelWindowmatchIndexAscending);
                uIAGetHandleForTopLevelWindowpropCount++;
            }

            uIAGetHandleForTopLevelWindowpropCount++;
            uIAGetHandleForTopLevelWindow["Workflow"] = ExpressionConverter.ConvertO(uIAGetHandleForTopLevelWindowworkflow);
            if (uIAGetHandleForTopLevelWindowpropCount > 0)
            {
                callPayload.Body = uIAGetHandleForTopLevelWindow;
            }

            return new ApiConnectionAction<UIAGetHandleForTopLevelWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForTopLevelWindowResponse> UIAWaitForTopLevelWindow(Expression<Func<int>> uIAWaitForTopLevelWindowsecondsToWait, Expression<Func<string>> uIAWaitForTopLevelWindowworkflow, Expression<Func<string>> uIAWaitForTopLevelWindowsearchClassName = null, Expression<Func<string>> uIAWaitForTopLevelWindowsearchWindowTitle = null, Expression<Func<int>> uIAWaitForTopLevelWindowsearchProcessId = null, Expression<Func<int>> uIAWaitForTopLevelWindowmatchIndex = null, Expression<Func<string>> uIAWaitForTopLevelWindowsearchFilter = null, Expression<Func<string>> uIAWaitForTopLevelWindowsortByColumn = null, Expression<Func<bool>> uIAWaitForTopLevelWindowmatchIndexAscending = null, Expression<Func<bool>> uIAWaitForTopLevelWindowraiseExceptionIfWindowNotFound = null)
        {
            var apiCallPath = "/UIAControl/WaitForTopLevelWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAWaitForTopLevelWindow = new JObject();
            var uIAWaitForTopLevelWindowpropCount = 0;
            if (uIAWaitForTopLevelWindowsearchClassName != null)
            {
                uIAWaitForTopLevelWindow["SearchClassName"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowsearchClassName);
                uIAWaitForTopLevelWindowpropCount++;
            }

            if (uIAWaitForTopLevelWindowsearchWindowTitle != null)
            {
                uIAWaitForTopLevelWindow["SearchWindowTitle"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowsearchWindowTitle);
                uIAWaitForTopLevelWindowpropCount++;
            }

            uIAWaitForTopLevelWindowpropCount++;
            uIAWaitForTopLevelWindow["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowsecondsToWait);
            if (uIAWaitForTopLevelWindowsearchProcessId != null)
            {
                uIAWaitForTopLevelWindow["SearchProcessId"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowsearchProcessId);
                uIAWaitForTopLevelWindowpropCount++;
            }

            if (uIAWaitForTopLevelWindowmatchIndex != null)
            {
                uIAWaitForTopLevelWindow["MatchIndex"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowmatchIndex);
                uIAWaitForTopLevelWindowpropCount++;
            }

            if (uIAWaitForTopLevelWindowsearchFilter != null)
            {
                uIAWaitForTopLevelWindow["SearchFilter"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowsearchFilter);
                uIAWaitForTopLevelWindowpropCount++;
            }

            if (uIAWaitForTopLevelWindowsortByColumn != null)
            {
                uIAWaitForTopLevelWindow["SortByColumn"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowsortByColumn);
                uIAWaitForTopLevelWindowpropCount++;
            }

            if (uIAWaitForTopLevelWindowmatchIndexAscending != null)
            {
                uIAWaitForTopLevelWindow["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowmatchIndexAscending);
                uIAWaitForTopLevelWindowpropCount++;
            }

            if (uIAWaitForTopLevelWindowraiseExceptionIfWindowNotFound != null)
            {
                uIAWaitForTopLevelWindow["RaiseExceptionIfWindowNotFound"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowraiseExceptionIfWindowNotFound);
                uIAWaitForTopLevelWindowpropCount++;
            }

            uIAWaitForTopLevelWindowpropCount++;
            uIAWaitForTopLevelWindow["Workflow"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowworkflow);
            if (uIAWaitForTopLevelWindowpropCount > 0)
            {
                callPayload.Body = uIAWaitForTopLevelWindow;
            }

            return new ApiConnectionAction<UIAWaitForTopLevelWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIADoesProcessHaveWindowResponse> UIADoesProcessHaveWindow(Expression<Func<string>> uIADoesProcessHaveWindowsearchProcessName, Expression<Func<string>> uIADoesProcessHaveWindowworkflow)
        {
            var apiCallPath = "/UIAControl/DoesProcessHaveWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIADoesProcessHaveWindow = new JObject();
            var uIADoesProcessHaveWindowpropCount = 0;
            uIADoesProcessHaveWindowpropCount++;
            uIADoesProcessHaveWindow["SearchProcessName"] = ExpressionConverter.ConvertO(uIADoesProcessHaveWindowsearchProcessName);
            uIADoesProcessHaveWindowpropCount++;
            uIADoesProcessHaveWindow["Workflow"] = ExpressionConverter.ConvertO(uIADoesProcessHaveWindowworkflow);
            if (uIADoesProcessHaveWindowpropCount > 0)
            {
                callPayload.Body = uIADoesProcessHaveWindow;
            }

            return new ApiConnectionAction<UIADoesProcessHaveWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForProcessMainWindowResponse> UIAGetHandleForProcessMainWindow(Expression<Func<string>> uIAGetHandleForProcessMainWindowsearchProcessName, Expression<Func<string>> uIAGetHandleForProcessMainWindowworkflow)
        {
            var apiCallPath = "/UIAControl/GetHandleForProcessMainWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetHandleForProcessMainWindow = new JObject();
            var uIAGetHandleForProcessMainWindowpropCount = 0;
            uIAGetHandleForProcessMainWindowpropCount++;
            uIAGetHandleForProcessMainWindow["SearchProcessName"] = ExpressionConverter.ConvertO(uIAGetHandleForProcessMainWindowsearchProcessName);
            uIAGetHandleForProcessMainWindowpropCount++;
            uIAGetHandleForProcessMainWindow["Workflow"] = ExpressionConverter.ConvertO(uIAGetHandleForProcessMainWindowworkflow);
            if (uIAGetHandleForProcessMainWindowpropCount > 0)
            {
                callPayload.Body = uIAGetHandleForProcessMainWindow;
            }

            return new ApiConnectionAction<UIAGetHandleForProcessMainWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForProcessMainWindowResponse> UIAWaitForProcessMainWindow(Expression<Func<string>> uIAWaitForProcessMainWindowsearchProcessName, Expression<Func<int>> uIAWaitForProcessMainWindowsecondsToWait, Expression<Func<string>> uIAWaitForProcessMainWindowworkflow)
        {
            var apiCallPath = "/UIAControl/WaitForProcessMainWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAWaitForProcessMainWindow = new JObject();
            var uIAWaitForProcessMainWindowpropCount = 0;
            uIAWaitForProcessMainWindowpropCount++;
            uIAWaitForProcessMainWindow["SearchProcessName"] = ExpressionConverter.ConvertO(uIAWaitForProcessMainWindowsearchProcessName);
            uIAWaitForProcessMainWindowpropCount++;
            uIAWaitForProcessMainWindow["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForProcessMainWindowsecondsToWait);
            uIAWaitForProcessMainWindowpropCount++;
            uIAWaitForProcessMainWindow["Workflow"] = ExpressionConverter.ConvertO(uIAWaitForProcessMainWindowworkflow);
            if (uIAWaitForProcessMainWindowpropCount > 0)
            {
                callPayload.Body = uIAWaitForProcessMainWindow;
            }

            return new ApiConnectionAction<UIAWaitForProcessMainWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForProcessIdMainWindowResponse> UIAGetHandleForProcessIdMainWindow(Expression<Func<int>> uIAGetHandleForProcessIdMainWindowprocessId, Expression<Func<string>> uIAGetHandleForProcessIdMainWindowworkflow)
        {
            var apiCallPath = "/UIAControl/GetHandleForProcessIdMainWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetHandleForProcessIdMainWindow = new JObject();
            var uIAGetHandleForProcessIdMainWindowpropCount = 0;
            uIAGetHandleForProcessIdMainWindowpropCount++;
            uIAGetHandleForProcessIdMainWindow["ProcessId"] = ExpressionConverter.ConvertO(uIAGetHandleForProcessIdMainWindowprocessId);
            uIAGetHandleForProcessIdMainWindowpropCount++;
            uIAGetHandleForProcessIdMainWindow["Workflow"] = ExpressionConverter.ConvertO(uIAGetHandleForProcessIdMainWindowworkflow);
            if (uIAGetHandleForProcessIdMainWindowpropCount > 0)
            {
                callPayload.Body = uIAGetHandleForProcessIdMainWindow;
            }

            return new ApiConnectionAction<UIAGetHandleForProcessIdMainWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForProcessIdMainWindowResponse> UIAWaitForProcessIdMainWindow(Expression<Func<int>> uIAWaitForProcessIdMainWindowprocessId, Expression<Func<int>> uIAWaitForProcessIdMainWindowsecondsToWait, Expression<Func<string>> uIAWaitForProcessIdMainWindowworkflow)
        {
            var apiCallPath = "/UIAControl/WaitForProcessIdMainWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAWaitForProcessIdMainWindow = new JObject();
            var uIAWaitForProcessIdMainWindowpropCount = 0;
            uIAWaitForProcessIdMainWindowpropCount++;
            uIAWaitForProcessIdMainWindow["ProcessId"] = ExpressionConverter.ConvertO(uIAWaitForProcessIdMainWindowprocessId);
            uIAWaitForProcessIdMainWindowpropCount++;
            uIAWaitForProcessIdMainWindow["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForProcessIdMainWindowsecondsToWait);
            uIAWaitForProcessIdMainWindowpropCount++;
            uIAWaitForProcessIdMainWindow["Workflow"] = ExpressionConverter.ConvertO(uIAWaitForProcessIdMainWindowworkflow);
            if (uIAWaitForProcessIdMainWindowpropCount > 0)
            {
                callPayload.Body = uIAWaitForProcessIdMainWindow;
            }

            return new ApiConnectionAction<UIAWaitForProcessIdMainWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForFocussedElementResponse> UIAGetHandleForFocussedElement(Expression<Func<string>> uIAGetHandleForFocussedElementworkflow)
        {
            var apiCallPath = "/UIAControl/GetHandleForFocussedElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetHandleForFocussedElement = new JObject();
            var uIAGetHandleForFocussedElementpropCount = 0;
            uIAGetHandleForFocussedElementpropCount++;
            uIAGetHandleForFocussedElement["Workflow"] = ExpressionConverter.ConvertO(uIAGetHandleForFocussedElementworkflow);
            if (uIAGetHandleForFocussedElementpropCount > 0)
            {
                callPayload.Body = uIAGetHandleForFocussedElement;
            }

            return new ApiConnectionAction<UIAGetHandleForFocussedElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForMainWindowOfFocussedElementResponse> UIAGetHandleForMainWindowOfFocussedElement(Expression<Func<string>> uIAGetHandleForMainWindowOfFocussedElementworkflow)
        {
            var apiCallPath = "/UIAControl/GetHandleForMainWindowOfFocussedElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetHandleForMainWindowOfFocussedElement = new JObject();
            var uIAGetHandleForMainWindowOfFocussedElementpropCount = 0;
            uIAGetHandleForMainWindowOfFocussedElementpropCount++;
            uIAGetHandleForMainWindowOfFocussedElement["Workflow"] = ExpressionConverter.ConvertO(uIAGetHandleForMainWindowOfFocussedElementworkflow);
            if (uIAGetHandleForMainWindowOfFocussedElementpropCount > 0)
            {
                callPayload.Body = uIAGetHandleForMainWindowOfFocussedElement;
            }

            return new ApiConnectionAction<UIAGetHandleForMainWindowOfFocussedElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForDesktopResponse> UIAGetHandleForDesktop(Expression<Func<string>> uIAGetHandleForDesktopworkflow)
        {
            var apiCallPath = "/UIAControl/GetHandleForDesktop";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetHandleForDesktop = new JObject();
            var uIAGetHandleForDesktoppropCount = 0;
            uIAGetHandleForDesktoppropCount++;
            uIAGetHandleForDesktop["Workflow"] = ExpressionConverter.ConvertO(uIAGetHandleForDesktopworkflow);
            if (uIAGetHandleForDesktoppropCount > 0)
            {
                callPayload.Body = uIAGetHandleForDesktop;
            }

            return new ApiConnectionAction<UIAGetHandleForDesktopResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIASetForegroundWindow(Expression<Func<int>> uIASetForegroundWindowwindowHandle, Expression<Func<string>> uIASetForegroundWindowworkflow, Expression<Func<bool>> uIASetForegroundWindowtoggleWindow = null, Expression<Func<bool>> uIASetForegroundWindowtoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> uIASetForegroundWindowtoggleDelay = null)
        {
            var apiCallPath = "/UIAControl/SetForegroundWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIASetForegroundWindow = new JObject();
            var uIASetForegroundWindowpropCount = 0;
            uIASetForegroundWindowpropCount++;
            uIASetForegroundWindow["WindowHandle"] = ExpressionConverter.ConvertO(uIASetForegroundWindowwindowHandle);
            if (uIASetForegroundWindowtoggleWindow != null)
            {
                uIASetForegroundWindow["ToggleWindow"] = ExpressionConverter.ConvertO(uIASetForegroundWindowtoggleWindow);
                uIASetForegroundWindowpropCount++;
            }

            if (uIASetForegroundWindowtoggleUsesGlobalLeftMouseClickAgent != null)
            {
                uIASetForegroundWindow["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(uIASetForegroundWindowtoggleUsesGlobalLeftMouseClickAgent);
                uIASetForegroundWindowpropCount++;
            }

            if (uIASetForegroundWindowtoggleDelay != null)
            {
                uIASetForegroundWindow["ToggleDelay"] = ExpressionConverter.ConvertO(uIASetForegroundWindowtoggleDelay);
                uIASetForegroundWindowpropCount++;
            }

            uIASetForegroundWindowpropCount++;
            uIASetForegroundWindow["Workflow"] = ExpressionConverter.ConvertO(uIASetForegroundWindowworkflow);
            if (uIASetForegroundWindowpropCount > 0)
            {
                callPayload.Body = uIASetForegroundWindow;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAMaximiseWindow(Expression<Func<int>> uIAMaximiseWindowwindowHandle, Expression<Func<string>> uIAMaximiseWindowworkflow)
        {
            var apiCallPath = "/UIAControl/MaximiseWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAMaximiseWindow = new JObject();
            var uIAMaximiseWindowpropCount = 0;
            uIAMaximiseWindowpropCount++;
            uIAMaximiseWindow["WindowHandle"] = ExpressionConverter.ConvertO(uIAMaximiseWindowwindowHandle);
            uIAMaximiseWindowpropCount++;
            uIAMaximiseWindow["Workflow"] = ExpressionConverter.ConvertO(uIAMaximiseWindowworkflow);
            if (uIAMaximiseWindowpropCount > 0)
            {
                callPayload.Body = uIAMaximiseWindow;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAMinimiseWindow(Expression<Func<int>> uIAMinimiseWindowwindowHandle, Expression<Func<string>> uIAMinimiseWindowworkflow)
        {
            var apiCallPath = "/UIAControl/MinimiseWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAMinimiseWindow = new JObject();
            var uIAMinimiseWindowpropCount = 0;
            uIAMinimiseWindowpropCount++;
            uIAMinimiseWindow["WindowHandle"] = ExpressionConverter.ConvertO(uIAMinimiseWindowwindowHandle);
            uIAMinimiseWindowpropCount++;
            uIAMinimiseWindow["Workflow"] = ExpressionConverter.ConvertO(uIAMinimiseWindowworkflow);
            if (uIAMinimiseWindowpropCount > 0)
            {
                callPayload.Body = uIAMinimiseWindow;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIASetWindowToNormal(Expression<Func<int>> uIASetWindowToNormalwindowHandle, Expression<Func<string>> uIASetWindowToNormalworkflow)
        {
            var apiCallPath = "/UIAControl/SetWindowToNormal";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIASetWindowToNormal = new JObject();
            var uIASetWindowToNormalpropCount = 0;
            uIASetWindowToNormalpropCount++;
            uIASetWindowToNormal["WindowHandle"] = ExpressionConverter.ConvertO(uIASetWindowToNormalwindowHandle);
            uIASetWindowToNormalpropCount++;
            uIASetWindowToNormal["Workflow"] = ExpressionConverter.ConvertO(uIASetWindowToNormalworkflow);
            if (uIASetWindowToNormalpropCount > 0)
            {
                callPayload.Body = uIASetWindowToNormal;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIADoesElementExistResponse> UIADoesElementExist(Expression<Func<int>> uIADoesElementExistparentWindowHandle, Expression<Func<string>> uIADoesElementExistworkflow, Expression<Func<string>> uIADoesElementExistsearchElementName = null, Expression<Func<string>> uIADoesElementExistsearchElementClassName = null, Expression<Func<string>> uIADoesElementExistsearchElementAutomationId = null, Expression<Func<string>> uIADoesElementExistsearchLocalizedControlType = null, Expression<Func<int>> uIADoesElementExistsearchProcessId = null, Expression<Func<bool>> uIADoesElementExistsearchSubTree = null, Expression<Func<bool>> uIADoesElementExistreturnElementHandle = null, Expression<Func<int>> uIADoesElementExistmatchIndex = null, Expression<Func<string>> uIADoesElementExistsearchFilter = null, Expression<Func<string>> uIADoesElementExistsortByColumn = null, Expression<Func<bool>> uIADoesElementExistmatchIndexAscending = null, Expression<Func<bool>> uIADoesElementExistincludeChildProcesses = null, Expression<Func<int>> uIADoesElementExistmaxElementsToSearch = null, Expression<Func<int>> uIADoesElementExistmaxRelativeSearchDepth = null, Expression<Func<int>> uIADoesElementExistmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIADoesElementExistelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/DoesElementExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIADoesElementExist = new JObject();
            var uIADoesElementExistpropCount = 0;
            uIADoesElementExistpropCount++;
            uIADoesElementExist["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIADoesElementExistparentWindowHandle);
            if (uIADoesElementExistsearchElementName != null)
            {
                uIADoesElementExist["SearchElementName"] = ExpressionConverter.ConvertO(uIADoesElementExistsearchElementName);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistsearchElementClassName != null)
            {
                uIADoesElementExist["SearchElementClassName"] = ExpressionConverter.ConvertO(uIADoesElementExistsearchElementClassName);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistsearchElementAutomationId != null)
            {
                uIADoesElementExist["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIADoesElementExistsearchElementAutomationId);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistsearchLocalizedControlType != null)
            {
                uIADoesElementExist["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIADoesElementExistsearchLocalizedControlType);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistsearchProcessId != null)
            {
                uIADoesElementExist["SearchProcessId"] = ExpressionConverter.ConvertO(uIADoesElementExistsearchProcessId);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistsearchSubTree != null)
            {
                uIADoesElementExist["SearchSubTree"] = ExpressionConverter.ConvertO(uIADoesElementExistsearchSubTree);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistreturnElementHandle != null)
            {
                uIADoesElementExist["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIADoesElementExistreturnElementHandle);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistmatchIndex != null)
            {
                uIADoesElementExist["MatchIndex"] = ExpressionConverter.ConvertO(uIADoesElementExistmatchIndex);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistsearchFilter != null)
            {
                uIADoesElementExist["SearchFilter"] = ExpressionConverter.ConvertO(uIADoesElementExistsearchFilter);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistsortByColumn != null)
            {
                uIADoesElementExist["SortByColumn"] = ExpressionConverter.ConvertO(uIADoesElementExistsortByColumn);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistmatchIndexAscending != null)
            {
                uIADoesElementExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIADoesElementExistmatchIndexAscending);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistincludeChildProcesses != null)
            {
                uIADoesElementExist["IncludeChildProcesses"] = ExpressionConverter.ConvertO(uIADoesElementExistincludeChildProcesses);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistmaxElementsToSearch != null)
            {
                uIADoesElementExist["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIADoesElementExistmaxElementsToSearch);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistmaxRelativeSearchDepth != null)
            {
                uIADoesElementExist["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIADoesElementExistmaxRelativeSearchDepth);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistmaxChildElementsToSearchPerNode != null)
            {
                uIADoesElementExist["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIADoesElementExistmaxChildElementsToSearchPerNode);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistelementLocalizedControlTypesNotToTraverse != null)
            {
                uIADoesElementExist["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIADoesElementExistelementLocalizedControlTypesNotToTraverse);
                uIADoesElementExistpropCount++;
            }

            uIADoesElementExistpropCount++;
            uIADoesElementExist["Workflow"] = ExpressionConverter.ConvertO(uIADoesElementExistworkflow);
            if (uIADoesElementExistpropCount > 0)
            {
                callPayload.Body = uIADoesElementExist;
            }

            return new ApiConnectionAction<UIADoesElementExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIADoesDesktopElementExistResponse> UIADoesDesktopElementExist(Expression<Func<string>> uIADoesDesktopElementExistworkflow, Expression<Func<string>> uIADoesDesktopElementExistsearchElementName = null, Expression<Func<string>> uIADoesDesktopElementExistsearchElementClassName = null, Expression<Func<string>> uIADoesDesktopElementExistsearchElementAutomationId = null, Expression<Func<string>> uIADoesDesktopElementExistsearchLocalizedControlType = null, Expression<Func<int>> uIADoesDesktopElementExistsearchProcessId = null, Expression<Func<bool>> uIADoesDesktopElementExistsearchSubTree = null, Expression<Func<bool>> uIADoesDesktopElementExistreturnElementHandle = null, Expression<Func<int>> uIADoesDesktopElementExistmatchIndex = null, Expression<Func<string>> uIADoesDesktopElementExistsearchFilter = null, Expression<Func<string>> uIADoesDesktopElementExistsortByColumn = null, Expression<Func<bool>> uIADoesDesktopElementExistmatchIndexAscending = null, Expression<Func<bool>> uIADoesDesktopElementExistincludeChildProcesses = null, Expression<Func<int>> uIADoesDesktopElementExistmaxElementsToSearch = null, Expression<Func<int>> uIADoesDesktopElementExistmaxRelativeSearchDepth = null, Expression<Func<int>> uIADoesDesktopElementExistmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIADoesDesktopElementExistelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/DoesDesktopElementExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIADoesDesktopElementExist = new JObject();
            var uIADoesDesktopElementExistpropCount = 0;
            if (uIADoesDesktopElementExistsearchElementName != null)
            {
                uIADoesDesktopElementExist["SearchElementName"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistsearchElementName);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistsearchElementClassName != null)
            {
                uIADoesDesktopElementExist["SearchElementClassName"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistsearchElementClassName);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistsearchElementAutomationId != null)
            {
                uIADoesDesktopElementExist["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistsearchElementAutomationId);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistsearchLocalizedControlType != null)
            {
                uIADoesDesktopElementExist["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistsearchLocalizedControlType);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistsearchProcessId != null)
            {
                uIADoesDesktopElementExist["SearchProcessId"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistsearchProcessId);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistsearchSubTree != null)
            {
                uIADoesDesktopElementExist["SearchSubTree"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistsearchSubTree);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistreturnElementHandle != null)
            {
                uIADoesDesktopElementExist["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistreturnElementHandle);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistmatchIndex != null)
            {
                uIADoesDesktopElementExist["MatchIndex"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistmatchIndex);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistsearchFilter != null)
            {
                uIADoesDesktopElementExist["SearchFilter"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistsearchFilter);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistsortByColumn != null)
            {
                uIADoesDesktopElementExist["SortByColumn"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistsortByColumn);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistmatchIndexAscending != null)
            {
                uIADoesDesktopElementExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistmatchIndexAscending);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistincludeChildProcesses != null)
            {
                uIADoesDesktopElementExist["IncludeChildProcesses"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistincludeChildProcesses);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistmaxElementsToSearch != null)
            {
                uIADoesDesktopElementExist["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistmaxElementsToSearch);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistmaxRelativeSearchDepth != null)
            {
                uIADoesDesktopElementExist["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistmaxRelativeSearchDepth);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistmaxChildElementsToSearchPerNode != null)
            {
                uIADoesDesktopElementExist["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistmaxChildElementsToSearchPerNode);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistelementLocalizedControlTypesNotToTraverse != null)
            {
                uIADoesDesktopElementExist["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistelementLocalizedControlTypesNotToTraverse);
                uIADoesDesktopElementExistpropCount++;
            }

            uIADoesDesktopElementExistpropCount++;
            uIADoesDesktopElementExist["Workflow"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistworkflow);
            if (uIADoesDesktopElementExistpropCount > 0)
            {
                callPayload.Body = uIADoesDesktopElementExist;
            }

            return new ApiConnectionAction<UIADoesDesktopElementExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForElementResponse> UIAWaitForElement(Expression<Func<int>> uIAWaitForElementparentWindowHandle, Expression<Func<int>> uIAWaitForElementsecondsToWait, Expression<Func<string>> uIAWaitForElementworkflow, Expression<Func<string>> uIAWaitForElementsearchElementName = null, Expression<Func<string>> uIAWaitForElementsearchElementClassName = null, Expression<Func<string>> uIAWaitForElementsearchElementAutomationId = null, Expression<Func<string>> uIAWaitForElementsearchLocalizedControlType = null, Expression<Func<int>> uIAWaitForElementsearchProcessId = null, Expression<Func<bool>> uIAWaitForElementsearchSubTree = null, Expression<Func<bool>> uIAWaitForElementreturnElementHandle = null, Expression<Func<int>> uIAWaitForElementmatchIndex = null, Expression<Func<string>> uIAWaitForElementsearchFilter = null, Expression<Func<string>> uIAWaitForElementsortByColumn = null, Expression<Func<bool>> uIAWaitForElementmatchIndexAscending = null, Expression<Func<bool>> uIAWaitForElementincludeChildProcesses = null, Expression<Func<bool>> uIAWaitForElementraiseExceptionIfElementNotFound = null, Expression<Func<int>> uIAWaitForElementmaxElementsToSearch = null, Expression<Func<int>> uIAWaitForElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAWaitForElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAWaitForElementelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/WaitForElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAWaitForElement = new JObject();
            var uIAWaitForElementpropCount = 0;
            uIAWaitForElementpropCount++;
            uIAWaitForElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAWaitForElementparentWindowHandle);
            if (uIAWaitForElementsearchElementName != null)
            {
                uIAWaitForElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAWaitForElementsearchElementName);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementsearchElementClassName != null)
            {
                uIAWaitForElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAWaitForElementsearchElementClassName);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementsearchElementAutomationId != null)
            {
                uIAWaitForElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAWaitForElementsearchElementAutomationId);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementsearchLocalizedControlType != null)
            {
                uIAWaitForElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAWaitForElementsearchLocalizedControlType);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementsearchProcessId != null)
            {
                uIAWaitForElement["SearchProcessId"] = ExpressionConverter.ConvertO(uIAWaitForElementsearchProcessId);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementsearchSubTree != null)
            {
                uIAWaitForElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAWaitForElementsearchSubTree);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementreturnElementHandle != null)
            {
                uIAWaitForElement["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIAWaitForElementreturnElementHandle);
                uIAWaitForElementpropCount++;
            }

            uIAWaitForElementpropCount++;
            uIAWaitForElement["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForElementsecondsToWait);
            if (uIAWaitForElementmatchIndex != null)
            {
                uIAWaitForElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAWaitForElementmatchIndex);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementsearchFilter != null)
            {
                uIAWaitForElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAWaitForElementsearchFilter);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementsortByColumn != null)
            {
                uIAWaitForElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAWaitForElementsortByColumn);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementmatchIndexAscending != null)
            {
                uIAWaitForElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAWaitForElementmatchIndexAscending);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementincludeChildProcesses != null)
            {
                uIAWaitForElement["IncludeChildProcesses"] = ExpressionConverter.ConvertO(uIAWaitForElementincludeChildProcesses);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementraiseExceptionIfElementNotFound != null)
            {
                uIAWaitForElement["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(uIAWaitForElementraiseExceptionIfElementNotFound);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementmaxElementsToSearch != null)
            {
                uIAWaitForElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAWaitForElementmaxElementsToSearch);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementmaxRelativeSearchDepth != null)
            {
                uIAWaitForElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAWaitForElementmaxRelativeSearchDepth);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementmaxChildElementsToSearchPerNode != null)
            {
                uIAWaitForElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAWaitForElementmaxChildElementsToSearchPerNode);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAWaitForElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAWaitForElementelementLocalizedControlTypesNotToTraverse);
                uIAWaitForElementpropCount++;
            }

            uIAWaitForElementpropCount++;
            uIAWaitForElement["Workflow"] = ExpressionConverter.ConvertO(uIAWaitForElementworkflow);
            if (uIAWaitForElementpropCount > 0)
            {
                callPayload.Body = uIAWaitForElement;
            }

            return new ApiConnectionAction<UIAWaitForElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForDesktopElementResponse> UIAWaitForDesktopElement(Expression<Func<int>> uIAWaitForDesktopElementsecondsToWait, Expression<Func<string>> uIAWaitForDesktopElementworkflow, Expression<Func<string>> uIAWaitForDesktopElementsearchElementName = null, Expression<Func<string>> uIAWaitForDesktopElementsearchElementClassName = null, Expression<Func<string>> uIAWaitForDesktopElementsearchElementAutomationId = null, Expression<Func<string>> uIAWaitForDesktopElementsearchLocalizedControlType = null, Expression<Func<int>> uIAWaitForDesktopElementsearchProcessId = null, Expression<Func<bool>> uIAWaitForDesktopElementsearchSubTree = null, Expression<Func<bool>> uIAWaitForDesktopElementreturnElementHandle = null, Expression<Func<int>> uIAWaitForDesktopElementmatchIndex = null, Expression<Func<string>> uIAWaitForDesktopElementsearchFilter = null, Expression<Func<string>> uIAWaitForDesktopElementsortByColumn = null, Expression<Func<bool>> uIAWaitForDesktopElementmatchIndexAscending = null, Expression<Func<bool>> uIAWaitForDesktopElementincludeChildProcesses = null, Expression<Func<bool>> uIAWaitForDesktopElementraiseExceptionIfElementNotFound = null, Expression<Func<int>> uIAWaitForDesktopElementmaxElementsToSearch = null, Expression<Func<int>> uIAWaitForDesktopElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAWaitForDesktopElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAWaitForDesktopElementelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/WaitForDesktopElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAWaitForDesktopElement = new JObject();
            var uIAWaitForDesktopElementpropCount = 0;
            if (uIAWaitForDesktopElementsearchElementName != null)
            {
                uIAWaitForDesktopElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementsearchElementName);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementsearchElementClassName != null)
            {
                uIAWaitForDesktopElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementsearchElementClassName);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementsearchElementAutomationId != null)
            {
                uIAWaitForDesktopElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementsearchElementAutomationId);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementsearchLocalizedControlType != null)
            {
                uIAWaitForDesktopElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementsearchLocalizedControlType);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementsearchProcessId != null)
            {
                uIAWaitForDesktopElement["SearchProcessId"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementsearchProcessId);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementsearchSubTree != null)
            {
                uIAWaitForDesktopElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementsearchSubTree);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementreturnElementHandle != null)
            {
                uIAWaitForDesktopElement["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementreturnElementHandle);
                uIAWaitForDesktopElementpropCount++;
            }

            uIAWaitForDesktopElementpropCount++;
            uIAWaitForDesktopElement["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementsecondsToWait);
            if (uIAWaitForDesktopElementmatchIndex != null)
            {
                uIAWaitForDesktopElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementmatchIndex);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementsearchFilter != null)
            {
                uIAWaitForDesktopElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementsearchFilter);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementsortByColumn != null)
            {
                uIAWaitForDesktopElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementsortByColumn);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementmatchIndexAscending != null)
            {
                uIAWaitForDesktopElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementmatchIndexAscending);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementincludeChildProcesses != null)
            {
                uIAWaitForDesktopElement["IncludeChildProcesses"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementincludeChildProcesses);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementraiseExceptionIfElementNotFound != null)
            {
                uIAWaitForDesktopElement["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementraiseExceptionIfElementNotFound);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementmaxElementsToSearch != null)
            {
                uIAWaitForDesktopElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementmaxElementsToSearch);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementmaxRelativeSearchDepth != null)
            {
                uIAWaitForDesktopElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementmaxRelativeSearchDepth);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementmaxChildElementsToSearchPerNode != null)
            {
                uIAWaitForDesktopElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementmaxChildElementsToSearchPerNode);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAWaitForDesktopElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementelementLocalizedControlTypesNotToTraverse);
                uIAWaitForDesktopElementpropCount++;
            }

            uIAWaitForDesktopElementpropCount++;
            uIAWaitForDesktopElement["Workflow"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementworkflow);
            if (uIAWaitForDesktopElementpropCount > 0)
            {
                callPayload.Body = uIAWaitForDesktopElement;
            }

            return new ApiConnectionAction<UIAWaitForDesktopElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForElementToNotExistResponse> UIAWaitForElementToNotExist(Expression<Func<int>> uIAWaitForElementToNotExistparentWindowHandle, Expression<Func<int>> uIAWaitForElementToNotExistsecondsToWait, Expression<Func<string>> uIAWaitForElementToNotExistworkflow, Expression<Func<string>> uIAWaitForElementToNotExistsearchElementName = null, Expression<Func<string>> uIAWaitForElementToNotExistsearchElementClassName = null, Expression<Func<string>> uIAWaitForElementToNotExistsearchElementAutomationId = null, Expression<Func<string>> uIAWaitForElementToNotExistsearchLocalizedControlType = null, Expression<Func<int>> uIAWaitForElementToNotExistsearchProcessId = null, Expression<Func<bool>> uIAWaitForElementToNotExistsearchSubTree = null, Expression<Func<int>> uIAWaitForElementToNotExistmatchIndex = null, Expression<Func<string>> uIAWaitForElementToNotExistsearchFilter = null, Expression<Func<string>> uIAWaitForElementToNotExistsortByColumn = null, Expression<Func<bool>> uIAWaitForElementToNotExistmatchIndexAscending = null, Expression<Func<bool>> uIAWaitForElementToNotExistincludeChildProcesses = null, Expression<Func<bool>> uIAWaitForElementToNotExistraiseExceptionIfElementStillExists = null, Expression<Func<int>> uIAWaitForElementToNotExistmaxElementsToSearch = null, Expression<Func<int>> uIAWaitForElementToNotExistmaxRelativeSearchDepth = null, Expression<Func<int>> uIAWaitForElementToNotExistmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAWaitForElementToNotExistelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/UIAWaitForElementToNotExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAWaitForElementToNotExist = new JObject();
            var uIAWaitForElementToNotExistpropCount = 0;
            uIAWaitForElementToNotExistpropCount++;
            uIAWaitForElementToNotExist["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistparentWindowHandle);
            if (uIAWaitForElementToNotExistsearchElementName != null)
            {
                uIAWaitForElementToNotExist["SearchElementName"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistsearchElementName);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistsearchElementClassName != null)
            {
                uIAWaitForElementToNotExist["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistsearchElementClassName);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistsearchElementAutomationId != null)
            {
                uIAWaitForElementToNotExist["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistsearchElementAutomationId);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistsearchLocalizedControlType != null)
            {
                uIAWaitForElementToNotExist["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistsearchLocalizedControlType);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistsearchProcessId != null)
            {
                uIAWaitForElementToNotExist["SearchProcessId"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistsearchProcessId);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistsearchSubTree != null)
            {
                uIAWaitForElementToNotExist["SearchSubTree"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistsearchSubTree);
                uIAWaitForElementToNotExistpropCount++;
            }

            uIAWaitForElementToNotExistpropCount++;
            uIAWaitForElementToNotExist["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistsecondsToWait);
            if (uIAWaitForElementToNotExistmatchIndex != null)
            {
                uIAWaitForElementToNotExist["MatchIndex"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistmatchIndex);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistsearchFilter != null)
            {
                uIAWaitForElementToNotExist["SearchFilter"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistsearchFilter);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistsortByColumn != null)
            {
                uIAWaitForElementToNotExist["SortByColumn"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistsortByColumn);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistmatchIndexAscending != null)
            {
                uIAWaitForElementToNotExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistmatchIndexAscending);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistincludeChildProcesses != null)
            {
                uIAWaitForElementToNotExist["IncludeChildProcesses"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistincludeChildProcesses);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistraiseExceptionIfElementStillExists != null)
            {
                uIAWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistraiseExceptionIfElementStillExists);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistmaxElementsToSearch != null)
            {
                uIAWaitForElementToNotExist["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistmaxElementsToSearch);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistmaxRelativeSearchDepth != null)
            {
                uIAWaitForElementToNotExist["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistmaxRelativeSearchDepth);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistmaxChildElementsToSearchPerNode != null)
            {
                uIAWaitForElementToNotExist["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistmaxChildElementsToSearchPerNode);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAWaitForElementToNotExist["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistelementLocalizedControlTypesNotToTraverse);
                uIAWaitForElementToNotExistpropCount++;
            }

            uIAWaitForElementToNotExistpropCount++;
            uIAWaitForElementToNotExist["Workflow"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistworkflow);
            if (uIAWaitForElementToNotExistpropCount > 0)
            {
                callPayload.Body = uIAWaitForElementToNotExist;
            }

            return new ApiConnectionAction<UIAWaitForElementToNotExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForDesktopElementToNotExistResponse> UIAWaitForDesktopElementToNotExist(Expression<Func<int>> uIAWaitForDesktopElementToNotExistsecondsToWait, Expression<Func<string>> uIAWaitForDesktopElementToNotExistworkflow, Expression<Func<string>> uIAWaitForDesktopElementToNotExistsearchElementName = null, Expression<Func<string>> uIAWaitForDesktopElementToNotExistsearchElementClassName = null, Expression<Func<string>> uIAWaitForDesktopElementToNotExistsearchElementAutomationId = null, Expression<Func<string>> uIAWaitForDesktopElementToNotExistsearchLocalizedControlType = null, Expression<Func<int>> uIAWaitForDesktopElementToNotExistsearchProcessId = null, Expression<Func<bool>> uIAWaitForDesktopElementToNotExistsearchSubTree = null, Expression<Func<int>> uIAWaitForDesktopElementToNotExistmatchIndex = null, Expression<Func<string>> uIAWaitForDesktopElementToNotExistsearchFilter = null, Expression<Func<string>> uIAWaitForDesktopElementToNotExistsortByColumn = null, Expression<Func<bool>> uIAWaitForDesktopElementToNotExistmatchIndexAscending = null, Expression<Func<bool>> uIAWaitForDesktopElementToNotExistincludeChildProcesses = null, Expression<Func<bool>> uIAWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists = null, Expression<Func<int>> uIAWaitForDesktopElementToNotExistmaxElementsToSearch = null, Expression<Func<int>> uIAWaitForDesktopElementToNotExistmaxRelativeSearchDepth = null, Expression<Func<int>> uIAWaitForDesktopElementToNotExistmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAWaitForDesktopElementToNotExistelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/UIAWaitForDesktopElementToNotExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAWaitForDesktopElementToNotExist = new JObject();
            var uIAWaitForDesktopElementToNotExistpropCount = 0;
            if (uIAWaitForDesktopElementToNotExistsearchElementName != null)
            {
                uIAWaitForDesktopElementToNotExist["SearchElementName"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistsearchElementName);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistsearchElementClassName != null)
            {
                uIAWaitForDesktopElementToNotExist["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistsearchElementClassName);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistsearchElementAutomationId != null)
            {
                uIAWaitForDesktopElementToNotExist["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistsearchElementAutomationId);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistsearchLocalizedControlType != null)
            {
                uIAWaitForDesktopElementToNotExist["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistsearchLocalizedControlType);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistsearchProcessId != null)
            {
                uIAWaitForDesktopElementToNotExist["SearchProcessId"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistsearchProcessId);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistsearchSubTree != null)
            {
                uIAWaitForDesktopElementToNotExist["SearchSubTree"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistsearchSubTree);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            uIAWaitForDesktopElementToNotExistpropCount++;
            uIAWaitForDesktopElementToNotExist["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistsecondsToWait);
            if (uIAWaitForDesktopElementToNotExistmatchIndex != null)
            {
                uIAWaitForDesktopElementToNotExist["MatchIndex"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistmatchIndex);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistsearchFilter != null)
            {
                uIAWaitForDesktopElementToNotExist["SearchFilter"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistsearchFilter);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistsortByColumn != null)
            {
                uIAWaitForDesktopElementToNotExist["SortByColumn"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistsortByColumn);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistmatchIndexAscending != null)
            {
                uIAWaitForDesktopElementToNotExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistmatchIndexAscending);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistincludeChildProcesses != null)
            {
                uIAWaitForDesktopElementToNotExist["IncludeChildProcesses"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistincludeChildProcesses);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists != null)
            {
                uIAWaitForDesktopElementToNotExist["RaiseExceptionIfElementStillExists"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistmaxElementsToSearch != null)
            {
                uIAWaitForDesktopElementToNotExist["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistmaxElementsToSearch);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistmaxRelativeSearchDepth != null)
            {
                uIAWaitForDesktopElementToNotExist["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistmaxRelativeSearchDepth);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistmaxChildElementsToSearchPerNode != null)
            {
                uIAWaitForDesktopElementToNotExist["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistmaxChildElementsToSearchPerNode);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAWaitForDesktopElementToNotExist["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistelementLocalizedControlTypesNotToTraverse);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            uIAWaitForDesktopElementToNotExistpropCount++;
            uIAWaitForDesktopElementToNotExist["Workflow"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistworkflow);
            if (uIAWaitForDesktopElementToNotExistpropCount > 0)
            {
                callPayload.Body = uIAWaitForDesktopElementToNotExist;
            }

            return new ApiConnectionAction<UIAWaitForDesktopElementToNotExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAPressElement(Expression<Func<int>> uIAPressElementparentWindowHandle, Expression<Func<string>> uIAPressElementworkflow, Expression<Func<string>> uIAPressElementsearchElementName = null, Expression<Func<string>> uIAPressElementsearchElementClassName = null, Expression<Func<string>> uIAPressElementsearchElementAutomationId = null, Expression<Func<string>> uIAPressElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAPressElementsearchSubTree = null, Expression<Func<bool>> uIAPressElementwait = null, Expression<Func<bool>> uIAPressElementwin32ClickButton = null, Expression<Func<int>> uIAPressElementmatchIndex = null, Expression<Func<string>> uIAPressElementsearchFilter = null, Expression<Func<string>> uIAPressElementsortByColumn = null, Expression<Func<bool>> uIAPressElementmatchIndexAscending = null, Expression<Func<int>> uIAPressElementmaxElementsToSearch = null, Expression<Func<int>> uIAPressElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAPressElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAPressElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAPressElementtryInvokePattern = null, Expression<Func<bool>> uIAPressElementtryLegacyPattern = null)
        {
            var apiCallPath = "/UIAControl/PressElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAPressElement = new JObject();
            var uIAPressElementpropCount = 0;
            uIAPressElementpropCount++;
            uIAPressElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAPressElementparentWindowHandle);
            if (uIAPressElementsearchElementName != null)
            {
                uIAPressElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAPressElementsearchElementName);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementsearchElementClassName != null)
            {
                uIAPressElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAPressElementsearchElementClassName);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementsearchElementAutomationId != null)
            {
                uIAPressElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAPressElementsearchElementAutomationId);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementsearchLocalizedControlType != null)
            {
                uIAPressElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAPressElementsearchLocalizedControlType);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementsearchSubTree != null)
            {
                uIAPressElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAPressElementsearchSubTree);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementwait != null)
            {
                uIAPressElement["Wait"] = ExpressionConverter.ConvertO(uIAPressElementwait);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementwin32ClickButton != null)
            {
                uIAPressElement["Win32ClickButton"] = ExpressionConverter.ConvertO(uIAPressElementwin32ClickButton);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementmatchIndex != null)
            {
                uIAPressElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAPressElementmatchIndex);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementsearchFilter != null)
            {
                uIAPressElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAPressElementsearchFilter);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementsortByColumn != null)
            {
                uIAPressElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAPressElementsortByColumn);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementmatchIndexAscending != null)
            {
                uIAPressElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAPressElementmatchIndexAscending);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementmaxElementsToSearch != null)
            {
                uIAPressElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAPressElementmaxElementsToSearch);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementmaxRelativeSearchDepth != null)
            {
                uIAPressElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAPressElementmaxRelativeSearchDepth);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementmaxChildElementsToSearchPerNode != null)
            {
                uIAPressElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAPressElementmaxChildElementsToSearchPerNode);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAPressElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAPressElementelementLocalizedControlTypesNotToTraverse);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementtryInvokePattern != null)
            {
                uIAPressElement["TryInvokePattern"] = ExpressionConverter.ConvertO(uIAPressElementtryInvokePattern);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementtryLegacyPattern != null)
            {
                uIAPressElement["TryLegacyPattern"] = ExpressionConverter.ConvertO(uIAPressElementtryLegacyPattern);
                uIAPressElementpropCount++;
            }

            uIAPressElementpropCount++;
            uIAPressElement["Workflow"] = ExpressionConverter.ConvertO(uIAPressElementworkflow);
            if (uIAPressElementpropCount > 0)
            {
                callPayload.Body = uIAPressElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalMouseClickOnElement(Expression<Func<int>> uIAGlobalMouseClickOnElementparentWindowHandle, Expression<Func<string>> uIAGlobalMouseClickOnElementworkflow, Expression<Func<string>> uIAGlobalMouseClickOnElementsearchElementName = null, Expression<Func<string>> uIAGlobalMouseClickOnElementsearchElementClassName = null, Expression<Func<string>> uIAGlobalMouseClickOnElementsearchElementAutomationId = null, Expression<Func<string>> uIAGlobalMouseClickOnElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAGlobalMouseClickOnElementsearchSubTree = null, Expression<Func<bool>> uIAGlobalMouseClickOnElementfocusElementFirst = null, Expression<Func<int>> uIAGlobalMouseClickOnElementmatchIndex = null, Expression<Func<string>> uIAGlobalMouseClickOnElementsearchFilter = null, Expression<Func<string>> uIAGlobalMouseClickOnElementsortByColumn = null, Expression<Func<bool>> uIAGlobalMouseClickOnElementmatchIndexAscending = null, Expression<Func<int>> uIAGlobalMouseClickOnElementclickOffsetX = null, Expression<Func<int>> uIAGlobalMouseClickOnElementclickOffsetY = null, Expression<Func<uIAGlobalMouseClickOnElementoffsetRelativeToInput>> uIAGlobalMouseClickOnElementoffsetRelativeTo = null, Expression<Func<int>> uIAGlobalMouseClickOnElementmaxElementsToSearch = null, Expression<Func<int>> uIAGlobalMouseClickOnElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGlobalMouseClickOnElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGlobalMouseClickOnElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAGlobalMouseClickOnElementvalidateClickablePointWithinElementBoundary = null)
        {
            var apiCallPath = "/UIAControl/GlobalMouseClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGlobalMouseClickOnElement = new JObject();
            var uIAGlobalMouseClickOnElementpropCount = 0;
            uIAGlobalMouseClickOnElementpropCount++;
            uIAGlobalMouseClickOnElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementparentWindowHandle);
            if (uIAGlobalMouseClickOnElementsearchElementName != null)
            {
                uIAGlobalMouseClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementsearchElementName);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementsearchElementClassName != null)
            {
                uIAGlobalMouseClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementsearchElementClassName);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementsearchElementAutomationId != null)
            {
                uIAGlobalMouseClickOnElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementsearchElementAutomationId);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementsearchLocalizedControlType != null)
            {
                uIAGlobalMouseClickOnElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementsearchLocalizedControlType);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementsearchSubTree != null)
            {
                uIAGlobalMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementsearchSubTree);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementfocusElementFirst != null)
            {
                uIAGlobalMouseClickOnElement["FocusElementFirst"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementfocusElementFirst);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementmatchIndex != null)
            {
                uIAGlobalMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementmatchIndex);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementsearchFilter != null)
            {
                uIAGlobalMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementsearchFilter);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementsortByColumn != null)
            {
                uIAGlobalMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementsortByColumn);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementmatchIndexAscending != null)
            {
                uIAGlobalMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementmatchIndexAscending);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementclickOffsetX != null)
            {
                uIAGlobalMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementclickOffsetX);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementclickOffsetY != null)
            {
                uIAGlobalMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementclickOffsetY);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementoffsetRelativeTo != null)
            {
                uIAGlobalMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementoffsetRelativeTo);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementmaxElementsToSearch != null)
            {
                uIAGlobalMouseClickOnElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementmaxElementsToSearch);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementmaxRelativeSearchDepth != null)
            {
                uIAGlobalMouseClickOnElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementmaxRelativeSearchDepth);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementmaxChildElementsToSearchPerNode != null)
            {
                uIAGlobalMouseClickOnElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementmaxChildElementsToSearchPerNode);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGlobalMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementelementLocalizedControlTypesNotToTraverse);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
            {
                uIAGlobalMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementvalidateClickablePointWithinElementBoundary);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            uIAGlobalMouseClickOnElementpropCount++;
            uIAGlobalMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementworkflow);
            if (uIAGlobalMouseClickOnElementpropCount > 0)
            {
                callPayload.Body = uIAGlobalMouseClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalRightMouseClickOnElement(Expression<Func<int>> uIAGlobalRightMouseClickOnElementparentWindowHandle, Expression<Func<string>> uIAGlobalRightMouseClickOnElementworkflow, Expression<Func<string>> uIAGlobalRightMouseClickOnElementsearchElementName = null, Expression<Func<string>> uIAGlobalRightMouseClickOnElementsearchElementClassName = null, Expression<Func<string>> uIAGlobalRightMouseClickOnElementsearchElementAutomationId = null, Expression<Func<string>> uIAGlobalRightMouseClickOnElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAGlobalRightMouseClickOnElementsearchSubTree = null, Expression<Func<bool>> uIAGlobalRightMouseClickOnElementfocusElementFirst = null, Expression<Func<int>> uIAGlobalRightMouseClickOnElementmatchIndex = null, Expression<Func<string>> uIAGlobalRightMouseClickOnElementsearchFilter = null, Expression<Func<string>> uIAGlobalRightMouseClickOnElementsortByColumn = null, Expression<Func<bool>> uIAGlobalRightMouseClickOnElementmatchIndexAscending = null, Expression<Func<int>> uIAGlobalRightMouseClickOnElementclickOffsetX = null, Expression<Func<int>> uIAGlobalRightMouseClickOnElementclickOffsetY = null, Expression<Func<uIAGlobalRightMouseClickOnElementoffsetRelativeToInput>> uIAGlobalRightMouseClickOnElementoffsetRelativeTo = null, Expression<Func<int>> uIAGlobalRightMouseClickOnElementmaxElementsToSearch = null, Expression<Func<int>> uIAGlobalRightMouseClickOnElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGlobalRightMouseClickOnElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGlobalRightMouseClickOnElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAGlobalRightMouseClickOnElementvalidateClickablePointWithinElementBoundary = null)
        {
            var apiCallPath = "/UIAControl/GlobalRightMouseClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGlobalRightMouseClickOnElement = new JObject();
            var uIAGlobalRightMouseClickOnElementpropCount = 0;
            uIAGlobalRightMouseClickOnElementpropCount++;
            uIAGlobalRightMouseClickOnElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementparentWindowHandle);
            if (uIAGlobalRightMouseClickOnElementsearchElementName != null)
            {
                uIAGlobalRightMouseClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementsearchElementName);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementsearchElementClassName != null)
            {
                uIAGlobalRightMouseClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementsearchElementClassName);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementsearchElementAutomationId != null)
            {
                uIAGlobalRightMouseClickOnElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementsearchElementAutomationId);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementsearchLocalizedControlType != null)
            {
                uIAGlobalRightMouseClickOnElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementsearchLocalizedControlType);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementsearchSubTree != null)
            {
                uIAGlobalRightMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementsearchSubTree);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementfocusElementFirst != null)
            {
                uIAGlobalRightMouseClickOnElement["FocusElementFirst"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementfocusElementFirst);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementmatchIndex != null)
            {
                uIAGlobalRightMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementmatchIndex);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementsearchFilter != null)
            {
                uIAGlobalRightMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementsearchFilter);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementsortByColumn != null)
            {
                uIAGlobalRightMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementsortByColumn);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementmatchIndexAscending != null)
            {
                uIAGlobalRightMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementmatchIndexAscending);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementclickOffsetX != null)
            {
                uIAGlobalRightMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementclickOffsetX);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementclickOffsetY != null)
            {
                uIAGlobalRightMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementclickOffsetY);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementoffsetRelativeTo != null)
            {
                uIAGlobalRightMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementoffsetRelativeTo);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementmaxElementsToSearch != null)
            {
                uIAGlobalRightMouseClickOnElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementmaxElementsToSearch);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementmaxRelativeSearchDepth != null)
            {
                uIAGlobalRightMouseClickOnElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementmaxRelativeSearchDepth);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementmaxChildElementsToSearchPerNode != null)
            {
                uIAGlobalRightMouseClickOnElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementmaxChildElementsToSearchPerNode);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGlobalRightMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementelementLocalizedControlTypesNotToTraverse);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
            {
                uIAGlobalRightMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementvalidateClickablePointWithinElementBoundary);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            uIAGlobalRightMouseClickOnElementpropCount++;
            uIAGlobalRightMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementworkflow);
            if (uIAGlobalRightMouseClickOnElementpropCount > 0)
            {
                callPayload.Body = uIAGlobalRightMouseClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalMiddleMouseClickOnElement(Expression<Func<int>> uIAGlobalMiddleMouseClickOnElementparentWindowHandle, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementworkflow, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementsearchElementName = null, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementsearchElementClassName = null, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementsearchElementAutomationId = null, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAGlobalMiddleMouseClickOnElementsearchSubTree = null, Expression<Func<bool>> uIAGlobalMiddleMouseClickOnElementfocusElementFirst = null, Expression<Func<int>> uIAGlobalMiddleMouseClickOnElementmatchIndex = null, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementsearchFilter = null, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementsortByColumn = null, Expression<Func<bool>> uIAGlobalMiddleMouseClickOnElementmatchIndexAscending = null, Expression<Func<int>> uIAGlobalMiddleMouseClickOnElementclickOffsetX = null, Expression<Func<int>> uIAGlobalMiddleMouseClickOnElementclickOffsetY = null, Expression<Func<uIAGlobalMiddleMouseClickOnElementoffsetRelativeToInput>> uIAGlobalMiddleMouseClickOnElementoffsetRelativeTo = null, Expression<Func<int>> uIAGlobalMiddleMouseClickOnElementmaxElementsToSearch = null, Expression<Func<int>> uIAGlobalMiddleMouseClickOnElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGlobalMiddleMouseClickOnElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAGlobalMiddleMouseClickOnElementvalidateClickablePointWithinElementBoundary = null)
        {
            var apiCallPath = "/UIAControl/GlobalMiddleMouseClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGlobalMiddleMouseClickOnElement = new JObject();
            var uIAGlobalMiddleMouseClickOnElementpropCount = 0;
            uIAGlobalMiddleMouseClickOnElementpropCount++;
            uIAGlobalMiddleMouseClickOnElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementparentWindowHandle);
            if (uIAGlobalMiddleMouseClickOnElementsearchElementName != null)
            {
                uIAGlobalMiddleMouseClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementsearchElementName);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementsearchElementClassName != null)
            {
                uIAGlobalMiddleMouseClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementsearchElementClassName);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementsearchElementAutomationId != null)
            {
                uIAGlobalMiddleMouseClickOnElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementsearchElementAutomationId);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementsearchLocalizedControlType != null)
            {
                uIAGlobalMiddleMouseClickOnElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementsearchLocalizedControlType);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementsearchSubTree != null)
            {
                uIAGlobalMiddleMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementsearchSubTree);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementfocusElementFirst != null)
            {
                uIAGlobalMiddleMouseClickOnElement["FocusElementFirst"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementfocusElementFirst);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementmatchIndex != null)
            {
                uIAGlobalMiddleMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementmatchIndex);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementsearchFilter != null)
            {
                uIAGlobalMiddleMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementsearchFilter);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementsortByColumn != null)
            {
                uIAGlobalMiddleMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementsortByColumn);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementmatchIndexAscending != null)
            {
                uIAGlobalMiddleMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementmatchIndexAscending);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementclickOffsetX != null)
            {
                uIAGlobalMiddleMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementclickOffsetX);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementclickOffsetY != null)
            {
                uIAGlobalMiddleMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementclickOffsetY);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementoffsetRelativeTo != null)
            {
                uIAGlobalMiddleMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementoffsetRelativeTo);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementmaxElementsToSearch != null)
            {
                uIAGlobalMiddleMouseClickOnElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementmaxElementsToSearch);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementmaxRelativeSearchDepth != null)
            {
                uIAGlobalMiddleMouseClickOnElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementmaxRelativeSearchDepth);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementmaxChildElementsToSearchPerNode != null)
            {
                uIAGlobalMiddleMouseClickOnElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementmaxChildElementsToSearchPerNode);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGlobalMiddleMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementelementLocalizedControlTypesNotToTraverse);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
            {
                uIAGlobalMiddleMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementvalidateClickablePointWithinElementBoundary);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            uIAGlobalMiddleMouseClickOnElementpropCount++;
            uIAGlobalMiddleMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementworkflow);
            if (uIAGlobalMiddleMouseClickOnElementpropCount > 0)
            {
                callPayload.Body = uIAGlobalMiddleMouseClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalDoubleLeftMouseClickOnElement(Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementparentWindowHandle, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementworkflow, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementsearchElementName = null, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementsearchElementClassName = null, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementsearchElementAutomationId = null, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAGlobalDoubleLeftMouseClickOnElementsearchSubTree = null, Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds = null, Expression<Func<bool>> uIAGlobalDoubleLeftMouseClickOnElementfocusElementFirst = null, Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementmatchIndex = null, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementsearchFilter = null, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementsortByColumn = null, Expression<Func<bool>> uIAGlobalDoubleLeftMouseClickOnElementmatchIndexAscending = null, Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementclickOffsetX = null, Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementclickOffsetY = null, Expression<Func<uIAGlobalDoubleLeftMouseClickOnElementoffsetRelativeToInput>> uIAGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo = null, Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementmaxElementsToSearch = null, Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAGlobalDoubleLeftMouseClickOnElementvalidateClickablePointWithinElementBoundary = null)
        {
            var apiCallPath = "/UIAControl/GlobalDoubleLeftMouseClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGlobalDoubleLeftMouseClickOnElement = new JObject();
            var uIAGlobalDoubleLeftMouseClickOnElementpropCount = 0;
            uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            uIAGlobalDoubleLeftMouseClickOnElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementparentWindowHandle);
            if (uIAGlobalDoubleLeftMouseClickOnElementsearchElementName != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementsearchElementName);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementsearchElementClassName != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementsearchElementClassName);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementsearchElementAutomationId != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementsearchElementAutomationId);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementsearchLocalizedControlType != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementsearchLocalizedControlType);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementsearchSubTree != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementsearchSubTree);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["DelayInMilliseconds"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementfocusElementFirst != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["FocusElementFirst"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementfocusElementFirst);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementmatchIndex != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementmatchIndex);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementsearchFilter != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementsearchFilter);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementsortByColumn != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementsortByColumn);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementmatchIndexAscending != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementmatchIndexAscending);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementclickOffsetX != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementclickOffsetX);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementclickOffsetY != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementclickOffsetY);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementmaxElementsToSearch != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementmaxElementsToSearch);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementmaxRelativeSearchDepth != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementmaxRelativeSearchDepth);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementmaxChildElementsToSearchPerNode != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementmaxChildElementsToSearchPerNode);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementelementLocalizedControlTypesNotToTraverse);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementvalidateClickablePointWithinElementBoundary);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            uIAGlobalDoubleLeftMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementworkflow);
            if (uIAGlobalDoubleLeftMouseClickOnElementpropCount > 0)
            {
                callPayload.Body = uIAGlobalDoubleLeftMouseClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIASelectElement(Expression<Func<int>> uIASelectElementparentWindowHandle, Expression<Func<string>> uIASelectElementworkflow, Expression<Func<string>> uIASelectElementsearchElementName = null, Expression<Func<string>> uIASelectElementsearchElementClassName = null, Expression<Func<string>> uIASelectElementsearchElementAutomationId = null, Expression<Func<string>> uIASelectElementsearchLocalizedControlType = null, Expression<Func<bool>> uIASelectElementsearchSubTree = null, Expression<Func<int>> uIASelectElementmatchIndex = null, Expression<Func<string>> uIASelectElementsearchFilter = null, Expression<Func<string>> uIASelectElementsortByColumn = null, Expression<Func<bool>> uIASelectElementmatchIndexAscending = null, Expression<Func<int>> uIASelectElementmaxElementsToSearch = null, Expression<Func<int>> uIASelectElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIASelectElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIASelectElementelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/SelectElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIASelectElement = new JObject();
            var uIASelectElementpropCount = 0;
            uIASelectElementpropCount++;
            uIASelectElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIASelectElementparentWindowHandle);
            if (uIASelectElementsearchElementName != null)
            {
                uIASelectElement["SearchElementName"] = ExpressionConverter.ConvertO(uIASelectElementsearchElementName);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementsearchElementClassName != null)
            {
                uIASelectElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIASelectElementsearchElementClassName);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementsearchElementAutomationId != null)
            {
                uIASelectElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIASelectElementsearchElementAutomationId);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementsearchLocalizedControlType != null)
            {
                uIASelectElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIASelectElementsearchLocalizedControlType);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementsearchSubTree != null)
            {
                uIASelectElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIASelectElementsearchSubTree);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementmatchIndex != null)
            {
                uIASelectElement["MatchIndex"] = ExpressionConverter.ConvertO(uIASelectElementmatchIndex);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementsearchFilter != null)
            {
                uIASelectElement["SearchFilter"] = ExpressionConverter.ConvertO(uIASelectElementsearchFilter);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementsortByColumn != null)
            {
                uIASelectElement["SortByColumn"] = ExpressionConverter.ConvertO(uIASelectElementsortByColumn);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementmatchIndexAscending != null)
            {
                uIASelectElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIASelectElementmatchIndexAscending);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementmaxElementsToSearch != null)
            {
                uIASelectElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIASelectElementmaxElementsToSearch);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementmaxRelativeSearchDepth != null)
            {
                uIASelectElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIASelectElementmaxRelativeSearchDepth);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementmaxChildElementsToSearchPerNode != null)
            {
                uIASelectElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIASelectElementmaxChildElementsToSearchPerNode);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIASelectElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIASelectElementelementLocalizedControlTypesNotToTraverse);
                uIASelectElementpropCount++;
            }

            uIASelectElementpropCount++;
            uIASelectElement["Workflow"] = ExpressionConverter.ConvertO(uIASelectElementworkflow);
            if (uIASelectElementpropCount > 0)
            {
                callPayload.Body = uIASelectElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAInputPasswordIntoElement(Expression<Func<int>> uIAInputPasswordIntoElementparentWindowHandle, Expression<Func<string>> uIAInputPasswordIntoElementpasswordToInput, Expression<Func<string>> uIAInputPasswordIntoElementworkflow, Expression<Func<string>> uIAInputPasswordIntoElementsearchElementName = null, Expression<Func<string>> uIAInputPasswordIntoElementsearchElementClassName = null, Expression<Func<string>> uIAInputPasswordIntoElementsearchElementAutomationId = null, Expression<Func<string>> uIAInputPasswordIntoElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAInputPasswordIntoElementsearchSubTree = null, Expression<Func<int>> uIAInputPasswordIntoElementmatchIndex = null, Expression<Func<string>> uIAInputPasswordIntoElementsearchFilter = null, Expression<Func<string>> uIAInputPasswordIntoElementsortByColumn = null, Expression<Func<bool>> uIAInputPasswordIntoElementmatchIndexAscending = null, Expression<Func<bool>> uIAInputPasswordIntoElementpasswordContainsStoredPassword = null, Expression<Func<int>> uIAInputPasswordIntoElementmaxElementsToSearch = null, Expression<Func<int>> uIAInputPasswordIntoElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAInputPasswordIntoElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAInputPasswordIntoElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAInputPasswordIntoElementtryValuePattern = null, Expression<Func<bool>> uIAInputPasswordIntoElementtryLegacyPattern = null)
        {
            var apiCallPath = "/UIAControl/InputPasswordIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAInputPasswordIntoElement = new JObject();
            var uIAInputPasswordIntoElementpropCount = 0;
            uIAInputPasswordIntoElementpropCount++;
            uIAInputPasswordIntoElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementparentWindowHandle);
            if (uIAInputPasswordIntoElementsearchElementName != null)
            {
                uIAInputPasswordIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementsearchElementName);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementsearchElementClassName != null)
            {
                uIAInputPasswordIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementsearchElementClassName);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementsearchElementAutomationId != null)
            {
                uIAInputPasswordIntoElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementsearchElementAutomationId);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementsearchLocalizedControlType != null)
            {
                uIAInputPasswordIntoElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementsearchLocalizedControlType);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementsearchSubTree != null)
            {
                uIAInputPasswordIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementsearchSubTree);
                uIAInputPasswordIntoElementpropCount++;
            }

            uIAInputPasswordIntoElementpropCount++;
            uIAInputPasswordIntoElement["PasswordToInput"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementpasswordToInput);
            if (uIAInputPasswordIntoElementmatchIndex != null)
            {
                uIAInputPasswordIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementmatchIndex);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementsearchFilter != null)
            {
                uIAInputPasswordIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementsearchFilter);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementsortByColumn != null)
            {
                uIAInputPasswordIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementsortByColumn);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementmatchIndexAscending != null)
            {
                uIAInputPasswordIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementmatchIndexAscending);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementpasswordContainsStoredPassword != null)
            {
                uIAInputPasswordIntoElement["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementpasswordContainsStoredPassword);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementmaxElementsToSearch != null)
            {
                uIAInputPasswordIntoElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementmaxElementsToSearch);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementmaxRelativeSearchDepth != null)
            {
                uIAInputPasswordIntoElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementmaxRelativeSearchDepth);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementmaxChildElementsToSearchPerNode != null)
            {
                uIAInputPasswordIntoElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementmaxChildElementsToSearchPerNode);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAInputPasswordIntoElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementelementLocalizedControlTypesNotToTraverse);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementtryValuePattern != null)
            {
                uIAInputPasswordIntoElement["TryValuePattern"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementtryValuePattern);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementtryLegacyPattern != null)
            {
                uIAInputPasswordIntoElement["TryLegacyPattern"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementtryLegacyPattern);
                uIAInputPasswordIntoElementpropCount++;
            }

            uIAInputPasswordIntoElementpropCount++;
            uIAInputPasswordIntoElement["Workflow"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementworkflow);
            if (uIAInputPasswordIntoElementpropCount > 0)
            {
                callPayload.Body = uIAInputPasswordIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAInputTextIntoElement(Expression<Func<int>> uIAInputTextIntoElementparentWindowHandle, Expression<Func<string>> uIAInputTextIntoElementworkflow, Expression<Func<string>> uIAInputTextIntoElementsearchElementName = null, Expression<Func<string>> uIAInputTextIntoElementsearchElementClassName = null, Expression<Func<string>> uIAInputTextIntoElementsearchElementAutomationId = null, Expression<Func<string>> uIAInputTextIntoElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAInputTextIntoElementsearchSubTree = null, Expression<Func<string>> uIAInputTextIntoElementtextToInput = null, Expression<Func<int>> uIAInputTextIntoElementmatchIndex = null, Expression<Func<string>> uIAInputTextIntoElementsearchFilter = null, Expression<Func<string>> uIAInputTextIntoElementsortByColumn = null, Expression<Func<bool>> uIAInputTextIntoElementmatchIndexAscending = null, Expression<Func<bool>> uIAInputTextIntoElementreplaceExistingValue = null, Expression<Func<int>> uIAInputTextIntoElementinsertPosition = null, Expression<Func<int>> uIAInputTextIntoElementmaxElementsToSearch = null, Expression<Func<int>> uIAInputTextIntoElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAInputTextIntoElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAInputTextIntoElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAInputTextIntoElementraiseExceptionIfInputValidationFails = null, Expression<Func<bool>> uIAInputTextIntoElementtryValuePattern = null, Expression<Func<bool>> uIAInputTextIntoElementtryLegacyPattern = null)
        {
            var apiCallPath = "/UIAControl/InputTextIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAInputTextIntoElement = new JObject();
            var uIAInputTextIntoElementpropCount = 0;
            uIAInputTextIntoElementpropCount++;
            uIAInputTextIntoElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementparentWindowHandle);
            if (uIAInputTextIntoElementsearchElementName != null)
            {
                uIAInputTextIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementsearchElementName);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementsearchElementClassName != null)
            {
                uIAInputTextIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementsearchElementClassName);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementsearchElementAutomationId != null)
            {
                uIAInputTextIntoElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementsearchElementAutomationId);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementsearchLocalizedControlType != null)
            {
                uIAInputTextIntoElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementsearchLocalizedControlType);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementsearchSubTree != null)
            {
                uIAInputTextIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementsearchSubTree);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementtextToInput != null)
            {
                uIAInputTextIntoElement["TextToInput"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementtextToInput);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementmatchIndex != null)
            {
                uIAInputTextIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementmatchIndex);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementsearchFilter != null)
            {
                uIAInputTextIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementsearchFilter);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementsortByColumn != null)
            {
                uIAInputTextIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementsortByColumn);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementmatchIndexAscending != null)
            {
                uIAInputTextIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementmatchIndexAscending);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementreplaceExistingValue != null)
            {
                uIAInputTextIntoElement["ReplaceExistingValue"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementreplaceExistingValue);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementinsertPosition != null)
            {
                uIAInputTextIntoElement["InsertPosition"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementinsertPosition);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementmaxElementsToSearch != null)
            {
                uIAInputTextIntoElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementmaxElementsToSearch);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementmaxRelativeSearchDepth != null)
            {
                uIAInputTextIntoElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementmaxRelativeSearchDepth);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementmaxChildElementsToSearchPerNode != null)
            {
                uIAInputTextIntoElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementmaxChildElementsToSearchPerNode);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAInputTextIntoElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementelementLocalizedControlTypesNotToTraverse);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementraiseExceptionIfInputValidationFails != null)
            {
                uIAInputTextIntoElement["RaiseExceptionIfInputValidationFails"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementraiseExceptionIfInputValidationFails);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementtryValuePattern != null)
            {
                uIAInputTextIntoElement["TryValuePattern"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementtryValuePattern);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementtryLegacyPattern != null)
            {
                uIAInputTextIntoElement["TryLegacyPattern"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementtryLegacyPattern);
                uIAInputTextIntoElementpropCount++;
            }

            uIAInputTextIntoElementpropCount++;
            uIAInputTextIntoElement["Workflow"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementworkflow);
            if (uIAInputTextIntoElementpropCount > 0)
            {
                callPayload.Body = uIAInputTextIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAInputTextIntoMultipleElements(Expression<Func<string>> uIAInputTextIntoMultipleElementsinputElementsJSON, Expression<Func<string>> uIAInputTextIntoMultipleElementsworkflow)
        {
            var apiCallPath = "/UIAControl/UIAInputTextIntoMultipleElements";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAInputTextIntoMultipleElements = new JObject();
            var uIAInputTextIntoMultipleElementspropCount = 0;
            uIAInputTextIntoMultipleElementspropCount++;
            uIAInputTextIntoMultipleElements["InputElementsJSON"] = ExpressionConverter.ConvertO(uIAInputTextIntoMultipleElementsinputElementsJSON);
            uIAInputTextIntoMultipleElementspropCount++;
            uIAInputTextIntoMultipleElements["Workflow"] = ExpressionConverter.ConvertO(uIAInputTextIntoMultipleElementsworkflow);
            if (uIAInputTextIntoMultipleElementspropCount > 0)
            {
                callPayload.Body = uIAInputTextIntoMultipleElements;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAInputReturnIntoElement(Expression<Func<int>> uIAInputReturnIntoElementparentWindowHandle, Expression<Func<string>> uIAInputReturnIntoElementworkflow, Expression<Func<string>> uIAInputReturnIntoElementsearchElementName = null, Expression<Func<string>> uIAInputReturnIntoElementsearchElementClassName = null, Expression<Func<string>> uIAInputReturnIntoElementsearchElementAutomationId = null, Expression<Func<string>> uIAInputReturnIntoElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAInputReturnIntoElementsearchSubTree = null, Expression<Func<int>> uIAInputReturnIntoElementmatchIndex = null, Expression<Func<string>> uIAInputReturnIntoElementsearchFilter = null, Expression<Func<string>> uIAInputReturnIntoElementsortByColumn = null, Expression<Func<bool>> uIAInputReturnIntoElementmatchIndexAscending = null, Expression<Func<bool>> uIAInputReturnIntoElementreplaceExistingValue = null, Expression<Func<int>> uIAInputReturnIntoElementinsertPosition = null, Expression<Func<int>> uIAInputReturnIntoElementmaxElementsToSearch = null, Expression<Func<int>> uIAInputReturnIntoElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAInputReturnIntoElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAInputReturnIntoElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAInputReturnIntoElementraiseExceptionIfInputValidationFails = null, Expression<Func<bool>> uIAInputReturnIntoElementtryValuePattern = null, Expression<Func<bool>> uIAInputReturnIntoElementtryLegacyPattern = null)
        {
            var apiCallPath = "/UIAControl/InputReturnIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAInputReturnIntoElement = new JObject();
            var uIAInputReturnIntoElementpropCount = 0;
            uIAInputReturnIntoElementpropCount++;
            uIAInputReturnIntoElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementparentWindowHandle);
            if (uIAInputReturnIntoElementsearchElementName != null)
            {
                uIAInputReturnIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementsearchElementName);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementsearchElementClassName != null)
            {
                uIAInputReturnIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementsearchElementClassName);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementsearchElementAutomationId != null)
            {
                uIAInputReturnIntoElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementsearchElementAutomationId);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementsearchLocalizedControlType != null)
            {
                uIAInputReturnIntoElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementsearchLocalizedControlType);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementsearchSubTree != null)
            {
                uIAInputReturnIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementsearchSubTree);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementmatchIndex != null)
            {
                uIAInputReturnIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementmatchIndex);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementsearchFilter != null)
            {
                uIAInputReturnIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementsearchFilter);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementsortByColumn != null)
            {
                uIAInputReturnIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementsortByColumn);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementmatchIndexAscending != null)
            {
                uIAInputReturnIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementmatchIndexAscending);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementreplaceExistingValue != null)
            {
                uIAInputReturnIntoElement["ReplaceExistingValue"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementreplaceExistingValue);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementinsertPosition != null)
            {
                uIAInputReturnIntoElement["InsertPosition"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementinsertPosition);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementmaxElementsToSearch != null)
            {
                uIAInputReturnIntoElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementmaxElementsToSearch);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementmaxRelativeSearchDepth != null)
            {
                uIAInputReturnIntoElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementmaxRelativeSearchDepth);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementmaxChildElementsToSearchPerNode != null)
            {
                uIAInputReturnIntoElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementmaxChildElementsToSearchPerNode);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAInputReturnIntoElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementelementLocalizedControlTypesNotToTraverse);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementraiseExceptionIfInputValidationFails != null)
            {
                uIAInputReturnIntoElement["RaiseExceptionIfInputValidationFails"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementraiseExceptionIfInputValidationFails);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementtryValuePattern != null)
            {
                uIAInputReturnIntoElement["TryValuePattern"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementtryValuePattern);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementtryLegacyPattern != null)
            {
                uIAInputReturnIntoElement["TryLegacyPattern"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementtryLegacyPattern);
                uIAInputReturnIntoElementpropCount++;
            }

            uIAInputReturnIntoElementpropCount++;
            uIAInputReturnIntoElement["Workflow"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementworkflow);
            if (uIAInputReturnIntoElementpropCount > 0)
            {
                callPayload.Body = uIAInputReturnIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAFocusElement(Expression<Func<int>> uIAFocusElementparentWindowHandle, Expression<Func<string>> uIAFocusElementworkflow, Expression<Func<string>> uIAFocusElementsearchElementName = null, Expression<Func<string>> uIAFocusElementsearchElementClassName = null, Expression<Func<string>> uIAFocusElementsearchElementAutomationId = null, Expression<Func<string>> uIAFocusElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAFocusElementsearchSubTree = null, Expression<Func<int>> uIAFocusElementmatchIndex = null, Expression<Func<string>> uIAFocusElementsearchFilter = null, Expression<Func<string>> uIAFocusElementsortByColumn = null, Expression<Func<bool>> uIAFocusElementmatchIndexAscending = null, Expression<Func<int>> uIAFocusElementmaxElementsToSearch = null, Expression<Func<int>> uIAFocusElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAFocusElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAFocusElementelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/FocusElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAFocusElement = new JObject();
            var uIAFocusElementpropCount = 0;
            uIAFocusElementpropCount++;
            uIAFocusElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAFocusElementparentWindowHandle);
            if (uIAFocusElementsearchElementName != null)
            {
                uIAFocusElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAFocusElementsearchElementName);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementsearchElementClassName != null)
            {
                uIAFocusElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAFocusElementsearchElementClassName);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementsearchElementAutomationId != null)
            {
                uIAFocusElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAFocusElementsearchElementAutomationId);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementsearchLocalizedControlType != null)
            {
                uIAFocusElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAFocusElementsearchLocalizedControlType);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementsearchSubTree != null)
            {
                uIAFocusElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAFocusElementsearchSubTree);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementmatchIndex != null)
            {
                uIAFocusElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAFocusElementmatchIndex);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementsearchFilter != null)
            {
                uIAFocusElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAFocusElementsearchFilter);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementsortByColumn != null)
            {
                uIAFocusElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAFocusElementsortByColumn);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementmatchIndexAscending != null)
            {
                uIAFocusElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAFocusElementmatchIndexAscending);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementmaxElementsToSearch != null)
            {
                uIAFocusElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAFocusElementmaxElementsToSearch);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementmaxRelativeSearchDepth != null)
            {
                uIAFocusElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAFocusElementmaxRelativeSearchDepth);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementmaxChildElementsToSearchPerNode != null)
            {
                uIAFocusElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAFocusElementmaxChildElementsToSearchPerNode);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAFocusElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAFocusElementelementLocalizedControlTypesNotToTraverse);
                uIAFocusElementpropCount++;
            }

            uIAFocusElementpropCount++;
            uIAFocusElement["Workflow"] = ExpressionConverter.ConvertO(uIAFocusElementworkflow);
            if (uIAFocusElementpropCount > 0)
            {
                callPayload.Body = uIAFocusElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAToggleElement(Expression<Func<int>> uIAToggleElementparentWindowHandle, Expression<Func<string>> uIAToggleElementworkflow, Expression<Func<string>> uIAToggleElementsearchElementName = null, Expression<Func<string>> uIAToggleElementsearchElementClassName = null, Expression<Func<string>> uIAToggleElementsearchElementAutomationId = null, Expression<Func<string>> uIAToggleElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAToggleElementsearchSubTree = null, Expression<Func<int>> uIAToggleElementmatchIndex = null, Expression<Func<string>> uIAToggleElementsearchFilter = null, Expression<Func<string>> uIAToggleElementsortByColumn = null, Expression<Func<bool>> uIAToggleElementmatchIndexAscending = null, Expression<Func<int>> uIAToggleElementmaxElementsToSearch = null, Expression<Func<int>> uIAToggleElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAToggleElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAToggleElementelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/ToggleElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAToggleElement = new JObject();
            var uIAToggleElementpropCount = 0;
            uIAToggleElementpropCount++;
            uIAToggleElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAToggleElementparentWindowHandle);
            if (uIAToggleElementsearchElementName != null)
            {
                uIAToggleElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAToggleElementsearchElementName);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementsearchElementClassName != null)
            {
                uIAToggleElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAToggleElementsearchElementClassName);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementsearchElementAutomationId != null)
            {
                uIAToggleElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAToggleElementsearchElementAutomationId);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementsearchLocalizedControlType != null)
            {
                uIAToggleElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAToggleElementsearchLocalizedControlType);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementsearchSubTree != null)
            {
                uIAToggleElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAToggleElementsearchSubTree);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementmatchIndex != null)
            {
                uIAToggleElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAToggleElementmatchIndex);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementsearchFilter != null)
            {
                uIAToggleElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAToggleElementsearchFilter);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementsortByColumn != null)
            {
                uIAToggleElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAToggleElementsortByColumn);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementmatchIndexAscending != null)
            {
                uIAToggleElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAToggleElementmatchIndexAscending);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementmaxElementsToSearch != null)
            {
                uIAToggleElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAToggleElementmaxElementsToSearch);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementmaxRelativeSearchDepth != null)
            {
                uIAToggleElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAToggleElementmaxRelativeSearchDepth);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementmaxChildElementsToSearchPerNode != null)
            {
                uIAToggleElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAToggleElementmaxChildElementsToSearchPerNode);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAToggleElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAToggleElementelementLocalizedControlTypesNotToTraverse);
                uIAToggleElementpropCount++;
            }

            uIAToggleElementpropCount++;
            uIAToggleElement["Workflow"] = ExpressionConverter.ConvertO(uIAToggleElementworkflow);
            if (uIAToggleElementpropCount > 0)
            {
                callPayload.Body = uIAToggleElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIACheckElement(Expression<Func<int>> uIACheckElementparentWindowHandle, Expression<Func<string>> uIACheckElementworkflow, Expression<Func<string>> uIACheckElementsearchElementName = null, Expression<Func<string>> uIACheckElementsearchElementClassName = null, Expression<Func<string>> uIACheckElementsearchElementAutomationId = null, Expression<Func<string>> uIACheckElementsearchLocalizedControlType = null, Expression<Func<bool>> uIACheckElementsearchSubTree = null, Expression<Func<bool>> uIACheckElementcheckElement = null, Expression<Func<int>> uIACheckElementmatchIndex = null, Expression<Func<string>> uIACheckElementsearchFilter = null, Expression<Func<string>> uIACheckElementsortByColumn = null, Expression<Func<bool>> uIACheckElementmatchIndexAscending = null, Expression<Func<int>> uIACheckElementmaxElementsToSearch = null, Expression<Func<int>> uIACheckElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIACheckElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIACheckElementelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/CheckElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIACheckElement = new JObject();
            var uIACheckElementpropCount = 0;
            uIACheckElementpropCount++;
            uIACheckElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIACheckElementparentWindowHandle);
            if (uIACheckElementsearchElementName != null)
            {
                uIACheckElement["SearchElementName"] = ExpressionConverter.ConvertO(uIACheckElementsearchElementName);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementsearchElementClassName != null)
            {
                uIACheckElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIACheckElementsearchElementClassName);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementsearchElementAutomationId != null)
            {
                uIACheckElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIACheckElementsearchElementAutomationId);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementsearchLocalizedControlType != null)
            {
                uIACheckElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIACheckElementsearchLocalizedControlType);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementsearchSubTree != null)
            {
                uIACheckElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIACheckElementsearchSubTree);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementcheckElement != null)
            {
                uIACheckElement["CheckElement"] = ExpressionConverter.ConvertO(uIACheckElementcheckElement);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementmatchIndex != null)
            {
                uIACheckElement["MatchIndex"] = ExpressionConverter.ConvertO(uIACheckElementmatchIndex);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementsearchFilter != null)
            {
                uIACheckElement["SearchFilter"] = ExpressionConverter.ConvertO(uIACheckElementsearchFilter);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementsortByColumn != null)
            {
                uIACheckElement["SortByColumn"] = ExpressionConverter.ConvertO(uIACheckElementsortByColumn);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementmatchIndexAscending != null)
            {
                uIACheckElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIACheckElementmatchIndexAscending);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementmaxElementsToSearch != null)
            {
                uIACheckElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIACheckElementmaxElementsToSearch);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementmaxRelativeSearchDepth != null)
            {
                uIACheckElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIACheckElementmaxRelativeSearchDepth);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementmaxChildElementsToSearchPerNode != null)
            {
                uIACheckElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIACheckElementmaxChildElementsToSearchPerNode);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIACheckElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIACheckElementelementLocalizedControlTypesNotToTraverse);
                uIACheckElementpropCount++;
            }

            uIACheckElementpropCount++;
            uIACheckElement["Workflow"] = ExpressionConverter.ConvertO(uIACheckElementworkflow);
            if (uIACheckElementpropCount > 0)
            {
                callPayload.Body = uIACheckElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIACheckMultipleElements(Expression<Func<string>> uIACheckMultipleElementsinputElementsJSON, Expression<Func<string>> uIACheckMultipleElementsworkflow)
        {
            var apiCallPath = "/UIAControl/UIACheckMultipleElements";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIACheckMultipleElements = new JObject();
            var uIACheckMultipleElementspropCount = 0;
            uIACheckMultipleElementspropCount++;
            uIACheckMultipleElements["InputElementsJSON"] = ExpressionConverter.ConvertO(uIACheckMultipleElementsinputElementsJSON);
            uIACheckMultipleElementspropCount++;
            uIACheckMultipleElements["Workflow"] = ExpressionConverter.ConvertO(uIACheckMultipleElementsworkflow);
            if (uIACheckMultipleElementspropCount > 0)
            {
                callPayload.Body = uIACheckMultipleElements;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAIsElementCheckedResponse> UIAIsElementChecked(Expression<Func<int>> uIAIsElementCheckedparentWindowHandle, Expression<Func<string>> uIAIsElementCheckedworkflow, Expression<Func<string>> uIAIsElementCheckedsearchElementName = null, Expression<Func<string>> uIAIsElementCheckedsearchElementClassName = null, Expression<Func<string>> uIAIsElementCheckedsearchElementAutomationId = null, Expression<Func<string>> uIAIsElementCheckedsearchLocalizedControlType = null, Expression<Func<bool>> uIAIsElementCheckedsearchSubTree = null, Expression<Func<int>> uIAIsElementCheckedmatchIndex = null, Expression<Func<string>> uIAIsElementCheckedsearchFilter = null, Expression<Func<string>> uIAIsElementCheckedsortByColumn = null, Expression<Func<bool>> uIAIsElementCheckedmatchIndexAscending = null, Expression<Func<int>> uIAIsElementCheckedmaxElementsToSearch = null, Expression<Func<int>> uIAIsElementCheckedmaxRelativeSearchDepth = null, Expression<Func<int>> uIAIsElementCheckedmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAIsElementCheckedelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/UIAIsElementChecked";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAIsElementChecked = new JObject();
            var uIAIsElementCheckedpropCount = 0;
            uIAIsElementCheckedpropCount++;
            uIAIsElementChecked["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAIsElementCheckedparentWindowHandle);
            if (uIAIsElementCheckedsearchElementName != null)
            {
                uIAIsElementChecked["SearchElementName"] = ExpressionConverter.ConvertO(uIAIsElementCheckedsearchElementName);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedsearchElementClassName != null)
            {
                uIAIsElementChecked["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAIsElementCheckedsearchElementClassName);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedsearchElementAutomationId != null)
            {
                uIAIsElementChecked["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAIsElementCheckedsearchElementAutomationId);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedsearchLocalizedControlType != null)
            {
                uIAIsElementChecked["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAIsElementCheckedsearchLocalizedControlType);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedsearchSubTree != null)
            {
                uIAIsElementChecked["SearchSubTree"] = ExpressionConverter.ConvertO(uIAIsElementCheckedsearchSubTree);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedmatchIndex != null)
            {
                uIAIsElementChecked["MatchIndex"] = ExpressionConverter.ConvertO(uIAIsElementCheckedmatchIndex);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedsearchFilter != null)
            {
                uIAIsElementChecked["SearchFilter"] = ExpressionConverter.ConvertO(uIAIsElementCheckedsearchFilter);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedsortByColumn != null)
            {
                uIAIsElementChecked["SortByColumn"] = ExpressionConverter.ConvertO(uIAIsElementCheckedsortByColumn);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedmatchIndexAscending != null)
            {
                uIAIsElementChecked["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAIsElementCheckedmatchIndexAscending);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedmaxElementsToSearch != null)
            {
                uIAIsElementChecked["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAIsElementCheckedmaxElementsToSearch);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedmaxRelativeSearchDepth != null)
            {
                uIAIsElementChecked["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAIsElementCheckedmaxRelativeSearchDepth);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedmaxChildElementsToSearchPerNode != null)
            {
                uIAIsElementChecked["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAIsElementCheckedmaxChildElementsToSearchPerNode);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAIsElementChecked["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAIsElementCheckedelementLocalizedControlTypesNotToTraverse);
                uIAIsElementCheckedpropCount++;
            }

            uIAIsElementCheckedpropCount++;
            uIAIsElementChecked["Workflow"] = ExpressionConverter.ConvertO(uIAIsElementCheckedworkflow);
            if (uIAIsElementCheckedpropCount > 0)
            {
                callPayload.Body = uIAIsElementChecked;
            }

            return new ApiConnectionAction<UIAIsElementCheckedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIACloseElementWindow(Expression<Func<int>> uIACloseElementWindowparentWindowHandle, Expression<Func<string>> uIACloseElementWindowworkflow, Expression<Func<string>> uIACloseElementWindowsearchElementName = null, Expression<Func<string>> uIACloseElementWindowsearchElementClassName = null, Expression<Func<string>> uIACloseElementWindowsearchElementAutomationId = null, Expression<Func<string>> uIACloseElementWindowsearchLocalizedControlType = null, Expression<Func<bool>> uIACloseElementWindowsearchSubTree = null, Expression<Func<int>> uIACloseElementWindowmatchIndex = null, Expression<Func<string>> uIACloseElementWindowsearchFilter = null, Expression<Func<string>> uIACloseElementWindowsortByColumn = null, Expression<Func<bool>> uIACloseElementWindowmatchIndexAscending = null, Expression<Func<int>> uIACloseElementWindowmaxElementsToSearch = null, Expression<Func<int>> uIACloseElementWindowmaxRelativeSearchDepth = null, Expression<Func<int>> uIACloseElementWindowmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIACloseElementWindowelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/CloseElementWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIACloseElementWindow = new JObject();
            var uIACloseElementWindowpropCount = 0;
            uIACloseElementWindowpropCount++;
            uIACloseElementWindow["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIACloseElementWindowparentWindowHandle);
            if (uIACloseElementWindowsearchElementName != null)
            {
                uIACloseElementWindow["SearchElementName"] = ExpressionConverter.ConvertO(uIACloseElementWindowsearchElementName);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowsearchElementClassName != null)
            {
                uIACloseElementWindow["SearchElementClassName"] = ExpressionConverter.ConvertO(uIACloseElementWindowsearchElementClassName);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowsearchElementAutomationId != null)
            {
                uIACloseElementWindow["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIACloseElementWindowsearchElementAutomationId);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowsearchLocalizedControlType != null)
            {
                uIACloseElementWindow["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIACloseElementWindowsearchLocalizedControlType);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowsearchSubTree != null)
            {
                uIACloseElementWindow["SearchSubTree"] = ExpressionConverter.ConvertO(uIACloseElementWindowsearchSubTree);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowmatchIndex != null)
            {
                uIACloseElementWindow["MatchIndex"] = ExpressionConverter.ConvertO(uIACloseElementWindowmatchIndex);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowsearchFilter != null)
            {
                uIACloseElementWindow["SearchFilter"] = ExpressionConverter.ConvertO(uIACloseElementWindowsearchFilter);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowsortByColumn != null)
            {
                uIACloseElementWindow["SortByColumn"] = ExpressionConverter.ConvertO(uIACloseElementWindowsortByColumn);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowmatchIndexAscending != null)
            {
                uIACloseElementWindow["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIACloseElementWindowmatchIndexAscending);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowmaxElementsToSearch != null)
            {
                uIACloseElementWindow["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIACloseElementWindowmaxElementsToSearch);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowmaxRelativeSearchDepth != null)
            {
                uIACloseElementWindow["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIACloseElementWindowmaxRelativeSearchDepth);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowmaxChildElementsToSearchPerNode != null)
            {
                uIACloseElementWindow["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIACloseElementWindowmaxChildElementsToSearchPerNode);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowelementLocalizedControlTypesNotToTraverse != null)
            {
                uIACloseElementWindow["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIACloseElementWindowelementLocalizedControlTypesNotToTraverse);
                uIACloseElementWindowpropCount++;
            }

            uIACloseElementWindowpropCount++;
            uIACloseElementWindow["Workflow"] = ExpressionConverter.ConvertO(uIACloseElementWindowworkflow);
            if (uIACloseElementWindowpropCount > 0)
            {
                callPayload.Body = uIACloseElementWindow;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementTextValueResponse> UIAGetElementTextValue(Expression<Func<int>> uIAGetElementTextValueparentWindowHandle, Expression<Func<string>> uIAGetElementTextValueworkflow, Expression<Func<string>> uIAGetElementTextValuesearchElementName = null, Expression<Func<string>> uIAGetElementTextValuesearchElementClassName = null, Expression<Func<string>> uIAGetElementTextValuesearchElementAutomationId = null, Expression<Func<string>> uIAGetElementTextValuesearchLocalizedControlType = null, Expression<Func<bool>> uIAGetElementTextValuesearchSubTree = null, Expression<Func<int>> uIAGetElementTextValuematchIndex = null, Expression<Func<string>> uIAGetElementTextValuesearchFilter = null, Expression<Func<string>> uIAGetElementTextValuesortByColumn = null, Expression<Func<bool>> uIAGetElementTextValuematchIndexAscending = null, Expression<Func<int>> uIAGetElementTextValuemaxElementsToSearch = null, Expression<Func<int>> uIAGetElementTextValuemaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetElementTextValuemaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetElementTextValueelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/GetElementTextValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetElementTextValue = new JObject();
            var uIAGetElementTextValuepropCount = 0;
            uIAGetElementTextValuepropCount++;
            uIAGetElementTextValue["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGetElementTextValueparentWindowHandle);
            if (uIAGetElementTextValuesearchElementName != null)
            {
                uIAGetElementTextValue["SearchElementName"] = ExpressionConverter.ConvertO(uIAGetElementTextValuesearchElementName);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValuesearchElementClassName != null)
            {
                uIAGetElementTextValue["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGetElementTextValuesearchElementClassName);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValuesearchElementAutomationId != null)
            {
                uIAGetElementTextValue["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGetElementTextValuesearchElementAutomationId);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValuesearchLocalizedControlType != null)
            {
                uIAGetElementTextValue["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetElementTextValuesearchLocalizedControlType);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValuesearchSubTree != null)
            {
                uIAGetElementTextValue["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetElementTextValuesearchSubTree);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValuematchIndex != null)
            {
                uIAGetElementTextValue["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetElementTextValuematchIndex);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValuesearchFilter != null)
            {
                uIAGetElementTextValue["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetElementTextValuesearchFilter);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValuesortByColumn != null)
            {
                uIAGetElementTextValue["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetElementTextValuesortByColumn);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValuematchIndexAscending != null)
            {
                uIAGetElementTextValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetElementTextValuematchIndexAscending);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValuemaxElementsToSearch != null)
            {
                uIAGetElementTextValue["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetElementTextValuemaxElementsToSearch);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValuemaxRelativeSearchDepth != null)
            {
                uIAGetElementTextValue["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetElementTextValuemaxRelativeSearchDepth);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValuemaxChildElementsToSearchPerNode != null)
            {
                uIAGetElementTextValue["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetElementTextValuemaxChildElementsToSearchPerNode);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValueelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetElementTextValue["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGetElementTextValueelementLocalizedControlTypesNotToTraverse);
                uIAGetElementTextValuepropCount++;
            }

            uIAGetElementTextValuepropCount++;
            uIAGetElementTextValue["Workflow"] = ExpressionConverter.ConvertO(uIAGetElementTextValueworkflow);
            if (uIAGetElementTextValuepropCount > 0)
            {
                callPayload.Body = uIAGetElementTextValue;
            }

            return new ApiConnectionAction<UIAGetElementTextValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementValueResponse> UIAGetElementValue(Expression<Func<int>> uIAGetElementValueparentWindowHandle, Expression<Func<string>> uIAGetElementValueworkflow, Expression<Func<string>> uIAGetElementValuesearchElementName = null, Expression<Func<string>> uIAGetElementValuesearchElementClassName = null, Expression<Func<string>> uIAGetElementValuesearchElementAutomationId = null, Expression<Func<string>> uIAGetElementValuesearchLocalizedControlType = null, Expression<Func<bool>> uIAGetElementValuesearchSubTree = null, Expression<Func<int>> uIAGetElementValuematchIndex = null, Expression<Func<string>> uIAGetElementValuesearchFilter = null, Expression<Func<string>> uIAGetElementValuesortByColumn = null, Expression<Func<bool>> uIAGetElementValuematchIndexAscending = null, Expression<Func<int>> uIAGetElementValuemaxElementsToSearch = null, Expression<Func<int>> uIAGetElementValuemaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetElementValuemaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetElementValueelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/GetElementValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetElementValue = new JObject();
            var uIAGetElementValuepropCount = 0;
            uIAGetElementValuepropCount++;
            uIAGetElementValue["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGetElementValueparentWindowHandle);
            if (uIAGetElementValuesearchElementName != null)
            {
                uIAGetElementValue["SearchElementName"] = ExpressionConverter.ConvertO(uIAGetElementValuesearchElementName);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValuesearchElementClassName != null)
            {
                uIAGetElementValue["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGetElementValuesearchElementClassName);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValuesearchElementAutomationId != null)
            {
                uIAGetElementValue["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGetElementValuesearchElementAutomationId);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValuesearchLocalizedControlType != null)
            {
                uIAGetElementValue["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetElementValuesearchLocalizedControlType);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValuesearchSubTree != null)
            {
                uIAGetElementValue["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetElementValuesearchSubTree);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValuematchIndex != null)
            {
                uIAGetElementValue["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetElementValuematchIndex);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValuesearchFilter != null)
            {
                uIAGetElementValue["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetElementValuesearchFilter);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValuesortByColumn != null)
            {
                uIAGetElementValue["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetElementValuesortByColumn);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValuematchIndexAscending != null)
            {
                uIAGetElementValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetElementValuematchIndexAscending);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValuemaxElementsToSearch != null)
            {
                uIAGetElementValue["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetElementValuemaxElementsToSearch);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValuemaxRelativeSearchDepth != null)
            {
                uIAGetElementValue["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetElementValuemaxRelativeSearchDepth);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValuemaxChildElementsToSearchPerNode != null)
            {
                uIAGetElementValue["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetElementValuemaxChildElementsToSearchPerNode);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValueelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetElementValue["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGetElementValueelementLocalizedControlTypesNotToTraverse);
                uIAGetElementValuepropCount++;
            }

            uIAGetElementValuepropCount++;
            uIAGetElementValue["Workflow"] = ExpressionConverter.ConvertO(uIAGetElementValueworkflow);
            if (uIAGetElementValuepropCount > 0)
            {
                callPayload.Body = uIAGetElementValue;
            }

            return new ApiConnectionAction<UIAGetElementValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementLabelValueResponse> UIAGetElementLabelValue(Expression<Func<int>> uIAGetElementLabelValueparentWindowHandle, Expression<Func<string>> uIAGetElementLabelValueworkflow, Expression<Func<string>> uIAGetElementLabelValuesearchElementName = null, Expression<Func<string>> uIAGetElementLabelValuesearchElementClassName = null, Expression<Func<string>> uIAGetElementLabelValuesearchElementAutomationId = null, Expression<Func<string>> uIAGetElementLabelValuesearchLocalizedControlType = null, Expression<Func<bool>> uIAGetElementLabelValuesearchSubTree = null, Expression<Func<int>> uIAGetElementLabelValuematchIndex = null, Expression<Func<string>> uIAGetElementLabelValuesearchFilter = null, Expression<Func<string>> uIAGetElementLabelValuesortByColumn = null, Expression<Func<bool>> uIAGetElementLabelValuematchIndexAscending = null, Expression<Func<int>> uIAGetElementLabelValuemaxElementsToSearch = null, Expression<Func<int>> uIAGetElementLabelValuemaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetElementLabelValuemaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetElementLabelValueelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/GetElementLabelValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetElementLabelValue = new JObject();
            var uIAGetElementLabelValuepropCount = 0;
            uIAGetElementLabelValuepropCount++;
            uIAGetElementLabelValue["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGetElementLabelValueparentWindowHandle);
            if (uIAGetElementLabelValuesearchElementName != null)
            {
                uIAGetElementLabelValue["SearchElementName"] = ExpressionConverter.ConvertO(uIAGetElementLabelValuesearchElementName);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValuesearchElementClassName != null)
            {
                uIAGetElementLabelValue["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGetElementLabelValuesearchElementClassName);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValuesearchElementAutomationId != null)
            {
                uIAGetElementLabelValue["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGetElementLabelValuesearchElementAutomationId);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValuesearchLocalizedControlType != null)
            {
                uIAGetElementLabelValue["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetElementLabelValuesearchLocalizedControlType);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValuesearchSubTree != null)
            {
                uIAGetElementLabelValue["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetElementLabelValuesearchSubTree);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValuematchIndex != null)
            {
                uIAGetElementLabelValue["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetElementLabelValuematchIndex);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValuesearchFilter != null)
            {
                uIAGetElementLabelValue["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetElementLabelValuesearchFilter);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValuesortByColumn != null)
            {
                uIAGetElementLabelValue["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetElementLabelValuesortByColumn);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValuematchIndexAscending != null)
            {
                uIAGetElementLabelValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetElementLabelValuematchIndexAscending);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValuemaxElementsToSearch != null)
            {
                uIAGetElementLabelValue["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetElementLabelValuemaxElementsToSearch);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValuemaxRelativeSearchDepth != null)
            {
                uIAGetElementLabelValue["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetElementLabelValuemaxRelativeSearchDepth);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValuemaxChildElementsToSearchPerNode != null)
            {
                uIAGetElementLabelValue["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetElementLabelValuemaxChildElementsToSearchPerNode);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValueelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetElementLabelValue["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGetElementLabelValueelementLocalizedControlTypesNotToTraverse);
                uIAGetElementLabelValuepropCount++;
            }

            uIAGetElementLabelValuepropCount++;
            uIAGetElementLabelValue["Workflow"] = ExpressionConverter.ConvertO(uIAGetElementLabelValueworkflow);
            if (uIAGetElementLabelValuepropCount > 0)
            {
                callPayload.Body = uIAGetElementLabelValue;
            }

            return new ApiConnectionAction<UIAGetElementLabelValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementPropertiesResponse> UIAGetElementProperties(Expression<Func<int>> uIAGetElementPropertiesparentWindowHandle, Expression<Func<string>> uIAGetElementPropertiesworkflow, Expression<Func<string>> uIAGetElementPropertiessearchElementName = null, Expression<Func<string>> uIAGetElementPropertiessearchElementClassName = null, Expression<Func<string>> uIAGetElementPropertiessearchElementAutomationId = null, Expression<Func<string>> uIAGetElementPropertiessearchLocalizedControlType = null, Expression<Func<bool>> uIAGetElementPropertiessearchSubTree = null, Expression<Func<bool>> uIAGetElementPropertiesreturnElementHandle = null, Expression<Func<bool>> uIAGetElementPropertiesreturnElementValue = null, Expression<Func<int>> uIAGetElementPropertiesmatchIndex = null, Expression<Func<string>> uIAGetElementPropertiessearchFilter = null, Expression<Func<string>> uIAGetElementPropertiessortByColumn = null, Expression<Func<bool>> uIAGetElementPropertiesmatchIndexAscending = null, Expression<Func<int>> uIAGetElementPropertiesmaxElementsToSearch = null, Expression<Func<int>> uIAGetElementPropertiesmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetElementPropertiesmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetElementPropertieselementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAGetElementPropertiesvalidateClickablePointWithinElementBoundary = null)
        {
            var apiCallPath = "/UIAControl/GetElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetElementProperties = new JObject();
            var uIAGetElementPropertiespropCount = 0;
            uIAGetElementPropertiespropCount++;
            uIAGetElementProperties["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesparentWindowHandle);
            if (uIAGetElementPropertiessearchElementName != null)
            {
                uIAGetElementProperties["SearchElementName"] = ExpressionConverter.ConvertO(uIAGetElementPropertiessearchElementName);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiessearchElementClassName != null)
            {
                uIAGetElementProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGetElementPropertiessearchElementClassName);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiessearchElementAutomationId != null)
            {
                uIAGetElementProperties["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGetElementPropertiessearchElementAutomationId);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiessearchLocalizedControlType != null)
            {
                uIAGetElementProperties["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetElementPropertiessearchLocalizedControlType);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiessearchSubTree != null)
            {
                uIAGetElementProperties["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetElementPropertiessearchSubTree);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesreturnElementHandle != null)
            {
                uIAGetElementProperties["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesreturnElementHandle);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesreturnElementValue != null)
            {
                uIAGetElementProperties["ReturnElementValue"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesreturnElementValue);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesmatchIndex != null)
            {
                uIAGetElementProperties["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesmatchIndex);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiessearchFilter != null)
            {
                uIAGetElementProperties["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetElementPropertiessearchFilter);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiessortByColumn != null)
            {
                uIAGetElementProperties["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetElementPropertiessortByColumn);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesmatchIndexAscending != null)
            {
                uIAGetElementProperties["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesmatchIndexAscending);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesmaxElementsToSearch != null)
            {
                uIAGetElementProperties["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesmaxElementsToSearch);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesmaxRelativeSearchDepth != null)
            {
                uIAGetElementProperties["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesmaxRelativeSearchDepth);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesmaxChildElementsToSearchPerNode != null)
            {
                uIAGetElementProperties["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesmaxChildElementsToSearchPerNode);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertieselementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetElementProperties["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGetElementPropertieselementLocalizedControlTypesNotToTraverse);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesvalidateClickablePointWithinElementBoundary != null)
            {
                uIAGetElementProperties["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesvalidateClickablePointWithinElementBoundary);
                uIAGetElementPropertiespropCount++;
            }

            uIAGetElementPropertiespropCount++;
            uIAGetElementProperties["Workflow"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesworkflow);
            if (uIAGetElementPropertiespropCount > 0)
            {
                callPayload.Body = uIAGetElementProperties;
            }

            return new ApiConnectionAction<UIAGetElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetMultipleElementPropertiesResponse> UIAGetMultipleElementProperties(Expression<Func<int>> uIAGetMultipleElementPropertiesparentWindowHandle, Expression<Func<string>> uIAGetMultipleElementPropertiesworkflow, Expression<Func<string>> uIAGetMultipleElementPropertiessearchElementLocalizedControlType = null, Expression<Func<bool>> uIAGetMultipleElementPropertiessearchDescendants = null, Expression<Func<bool>> uIAGetMultipleElementPropertiesreturnElementHandle = null, Expression<Func<bool>> uIAGetMultipleElementPropertiesreturnElementValue = null, Expression<Func<int>> uIAGetMultipleElementPropertiesfirstItemToReturn = null, Expression<Func<int>> uIAGetMultipleElementPropertiesmaxItemsToReturn = null)
        {
            var apiCallPath = "/UIAControl/GetMultipleElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetMultipleElementProperties = new JObject();
            var uIAGetMultipleElementPropertiespropCount = 0;
            uIAGetMultipleElementPropertiespropCount++;
            uIAGetMultipleElementProperties["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGetMultipleElementPropertiesparentWindowHandle);
            if (uIAGetMultipleElementPropertiessearchElementLocalizedControlType != null)
            {
                uIAGetMultipleElementProperties["SearchElementLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetMultipleElementPropertiessearchElementLocalizedControlType);
                uIAGetMultipleElementPropertiespropCount++;
            }

            if (uIAGetMultipleElementPropertiessearchDescendants != null)
            {
                uIAGetMultipleElementProperties["SearchDescendants"] = ExpressionConverter.ConvertO(uIAGetMultipleElementPropertiessearchDescendants);
                uIAGetMultipleElementPropertiespropCount++;
            }

            if (uIAGetMultipleElementPropertiesreturnElementHandle != null)
            {
                uIAGetMultipleElementProperties["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIAGetMultipleElementPropertiesreturnElementHandle);
                uIAGetMultipleElementPropertiespropCount++;
            }

            if (uIAGetMultipleElementPropertiesreturnElementValue != null)
            {
                uIAGetMultipleElementProperties["ReturnElementValue"] = ExpressionConverter.ConvertO(uIAGetMultipleElementPropertiesreturnElementValue);
                uIAGetMultipleElementPropertiespropCount++;
            }

            if (uIAGetMultipleElementPropertiesfirstItemToReturn != null)
            {
                uIAGetMultipleElementProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(uIAGetMultipleElementPropertiesfirstItemToReturn);
                uIAGetMultipleElementPropertiespropCount++;
            }

            if (uIAGetMultipleElementPropertiesmaxItemsToReturn != null)
            {
                uIAGetMultipleElementProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(uIAGetMultipleElementPropertiesmaxItemsToReturn);
                uIAGetMultipleElementPropertiespropCount++;
            }

            uIAGetMultipleElementPropertiespropCount++;
            uIAGetMultipleElementProperties["Workflow"] = ExpressionConverter.ConvertO(uIAGetMultipleElementPropertiesworkflow);
            if (uIAGetMultipleElementPropertiespropCount > 0)
            {
                callPayload.Body = uIAGetMultipleElementProperties;
            }

            return new ApiConnectionAction<UIAGetMultipleElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetDesktopElementsResponse> UIAGetDesktopElements(Expression<Func<string>> uIAGetDesktopElementsworkflow, Expression<Func<string>> uIAGetDesktopElementssearchElementLocalizedControlType = null, Expression<Func<int>> uIAGetDesktopElementssearchProcessID = null, Expression<Func<bool>> uIAGetDesktopElementsreturnElementHandle = null, Expression<Func<int>> uIAGetDesktopElementsfirstItemToReturn = null, Expression<Func<int>> uIAGetDesktopElementsmaxItemsToReturn = null, Expression<Func<bool>> uIAGetDesktopElementsincludeChildProcesses = null)
        {
            var apiCallPath = "/UIAControl/GetDesktopElements";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetDesktopElements = new JObject();
            var uIAGetDesktopElementspropCount = 0;
            if (uIAGetDesktopElementssearchElementLocalizedControlType != null)
            {
                uIAGetDesktopElements["SearchElementLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetDesktopElementssearchElementLocalizedControlType);
                uIAGetDesktopElementspropCount++;
            }

            if (uIAGetDesktopElementssearchProcessID != null)
            {
                uIAGetDesktopElements["SearchProcessID"] = ExpressionConverter.ConvertO(uIAGetDesktopElementssearchProcessID);
                uIAGetDesktopElementspropCount++;
            }

            if (uIAGetDesktopElementsreturnElementHandle != null)
            {
                uIAGetDesktopElements["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIAGetDesktopElementsreturnElementHandle);
                uIAGetDesktopElementspropCount++;
            }

            if (uIAGetDesktopElementsfirstItemToReturn != null)
            {
                uIAGetDesktopElements["FirstItemToReturn"] = ExpressionConverter.ConvertO(uIAGetDesktopElementsfirstItemToReturn);
                uIAGetDesktopElementspropCount++;
            }

            if (uIAGetDesktopElementsmaxItemsToReturn != null)
            {
                uIAGetDesktopElements["MaxItemsToReturn"] = ExpressionConverter.ConvertO(uIAGetDesktopElementsmaxItemsToReturn);
                uIAGetDesktopElementspropCount++;
            }

            if (uIAGetDesktopElementsincludeChildProcesses != null)
            {
                uIAGetDesktopElements["IncludeChildProcesses"] = ExpressionConverter.ConvertO(uIAGetDesktopElementsincludeChildProcesses);
                uIAGetDesktopElementspropCount++;
            }

            uIAGetDesktopElementspropCount++;
            uIAGetDesktopElements["Workflow"] = ExpressionConverter.ConvertO(uIAGetDesktopElementsworkflow);
            if (uIAGetDesktopElementspropCount > 0)
            {
                callPayload.Body = uIAGetDesktopElements;
            }

            return new ApiConnectionAction<UIAGetDesktopElementsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAExpandElement(Expression<Func<int>> uIAExpandElementparentWindowHandle, Expression<Func<string>> uIAExpandElementworkflow, Expression<Func<string>> uIAExpandElementsearchElementName = null, Expression<Func<string>> uIAExpandElementsearchElementClassName = null, Expression<Func<string>> uIAExpandElementsearchElementAutomationId = null, Expression<Func<string>> uIAExpandElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAExpandElementsearchSubTree = null, Expression<Func<int>> uIAExpandElementmatchIndex = null, Expression<Func<string>> uIAExpandElementsearchFilter = null, Expression<Func<string>> uIAExpandElementsortByColumn = null, Expression<Func<bool>> uIAExpandElementmatchIndexAscending = null, Expression<Func<int>> uIAExpandElementmaxElementsToSearch = null, Expression<Func<int>> uIAExpandElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAExpandElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAExpandElementelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/ExpandElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAExpandElement = new JObject();
            var uIAExpandElementpropCount = 0;
            uIAExpandElementpropCount++;
            uIAExpandElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAExpandElementparentWindowHandle);
            if (uIAExpandElementsearchElementName != null)
            {
                uIAExpandElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAExpandElementsearchElementName);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementsearchElementClassName != null)
            {
                uIAExpandElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAExpandElementsearchElementClassName);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementsearchElementAutomationId != null)
            {
                uIAExpandElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAExpandElementsearchElementAutomationId);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementsearchLocalizedControlType != null)
            {
                uIAExpandElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAExpandElementsearchLocalizedControlType);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementsearchSubTree != null)
            {
                uIAExpandElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAExpandElementsearchSubTree);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementmatchIndex != null)
            {
                uIAExpandElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAExpandElementmatchIndex);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementsearchFilter != null)
            {
                uIAExpandElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAExpandElementsearchFilter);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementsortByColumn != null)
            {
                uIAExpandElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAExpandElementsortByColumn);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementmatchIndexAscending != null)
            {
                uIAExpandElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAExpandElementmatchIndexAscending);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementmaxElementsToSearch != null)
            {
                uIAExpandElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAExpandElementmaxElementsToSearch);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementmaxRelativeSearchDepth != null)
            {
                uIAExpandElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAExpandElementmaxRelativeSearchDepth);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementmaxChildElementsToSearchPerNode != null)
            {
                uIAExpandElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAExpandElementmaxChildElementsToSearchPerNode);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAExpandElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAExpandElementelementLocalizedControlTypesNotToTraverse);
                uIAExpandElementpropCount++;
            }

            uIAExpandElementpropCount++;
            uIAExpandElement["Workflow"] = ExpressionConverter.ConvertO(uIAExpandElementworkflow);
            if (uIAExpandElementpropCount > 0)
            {
                callPayload.Body = uIAExpandElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIACollapseElement(Expression<Func<int>> uIACollapseElementparentWindowHandle, Expression<Func<string>> uIACollapseElementworkflow, Expression<Func<string>> uIACollapseElementsearchElementName = null, Expression<Func<string>> uIACollapseElementsearchElementClassName = null, Expression<Func<string>> uIACollapseElementsearchElementAutomationId = null, Expression<Func<string>> uIACollapseElementsearchLocalizedControlType = null, Expression<Func<bool>> uIACollapseElementsearchSubTree = null, Expression<Func<int>> uIACollapseElementmatchIndex = null, Expression<Func<string>> uIACollapseElementsearchFilter = null, Expression<Func<string>> uIACollapseElementsortByColumn = null, Expression<Func<bool>> uIACollapseElementmatchIndexAscending = null, Expression<Func<int>> uIACollapseElementmaxElementsToSearch = null, Expression<Func<int>> uIACollapseElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIACollapseElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIACollapseElementelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/CollapseElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIACollapseElement = new JObject();
            var uIACollapseElementpropCount = 0;
            uIACollapseElementpropCount++;
            uIACollapseElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIACollapseElementparentWindowHandle);
            if (uIACollapseElementsearchElementName != null)
            {
                uIACollapseElement["SearchElementName"] = ExpressionConverter.ConvertO(uIACollapseElementsearchElementName);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementsearchElementClassName != null)
            {
                uIACollapseElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIACollapseElementsearchElementClassName);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementsearchElementAutomationId != null)
            {
                uIACollapseElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIACollapseElementsearchElementAutomationId);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementsearchLocalizedControlType != null)
            {
                uIACollapseElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIACollapseElementsearchLocalizedControlType);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementsearchSubTree != null)
            {
                uIACollapseElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIACollapseElementsearchSubTree);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementmatchIndex != null)
            {
                uIACollapseElement["MatchIndex"] = ExpressionConverter.ConvertO(uIACollapseElementmatchIndex);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementsearchFilter != null)
            {
                uIACollapseElement["SearchFilter"] = ExpressionConverter.ConvertO(uIACollapseElementsearchFilter);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementsortByColumn != null)
            {
                uIACollapseElement["SortByColumn"] = ExpressionConverter.ConvertO(uIACollapseElementsortByColumn);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementmatchIndexAscending != null)
            {
                uIACollapseElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIACollapseElementmatchIndexAscending);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementmaxElementsToSearch != null)
            {
                uIACollapseElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIACollapseElementmaxElementsToSearch);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementmaxRelativeSearchDepth != null)
            {
                uIACollapseElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIACollapseElementmaxRelativeSearchDepth);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementmaxChildElementsToSearchPerNode != null)
            {
                uIACollapseElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIACollapseElementmaxChildElementsToSearchPerNode);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIACollapseElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIACollapseElementelementLocalizedControlTypesNotToTraverse);
                uIACollapseElementpropCount++;
            }

            uIACollapseElementpropCount++;
            uIACollapseElement["Workflow"] = ExpressionConverter.ConvertO(uIACollapseElementworkflow);
            if (uIACollapseElementpropCount > 0)
            {
                callPayload.Body = uIACollapseElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIATakeScreenShotOfElementLocationResponse> UIATakeScreenShotOfElementLocation(Expression<Func<int>> uIATakeScreenShotOfElementLocationparentWindowHandle, Expression<Func<string>> uIATakeScreenShotOfElementLocationworkflow, Expression<Func<string>> uIATakeScreenShotOfElementLocationsearchElementName = null, Expression<Func<string>> uIATakeScreenShotOfElementLocationsearchElementClassName = null, Expression<Func<string>> uIATakeScreenShotOfElementLocationsearchElementAutomationId = null, Expression<Func<string>> uIATakeScreenShotOfElementLocationsearchLocalizedControlType = null, Expression<Func<bool>> uIATakeScreenShotOfElementLocationsearchSubTree = null, Expression<Func<uIATakeScreenShotOfElementLocationimageFormatInput>> uIATakeScreenShotOfElementLocationimageFormat = null, Expression<Func<int>> uIATakeScreenShotOfElementLocationmatchIndex = null, Expression<Func<string>> uIATakeScreenShotOfElementLocationsearchFilter = null, Expression<Func<string>> uIATakeScreenShotOfElementLocationsortByColumn = null, Expression<Func<bool>> uIATakeScreenShotOfElementLocationmatchIndexAscending = null, Expression<Func<bool>> uIATakeScreenShotOfElementLocationhideAgent = null, Expression<Func<int>> uIATakeScreenShotOfElementLocationmaxElementsToSearch = null, Expression<Func<int>> uIATakeScreenShotOfElementLocationmaxRelativeSearchDepth = null, Expression<Func<int>> uIATakeScreenShotOfElementLocationmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIATakeScreenShotOfElementLocationelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/TakeScreenShotOfElementLocation";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIATakeScreenShotOfElementLocation = new JObject();
            var uIATakeScreenShotOfElementLocationpropCount = 0;
            uIATakeScreenShotOfElementLocationpropCount++;
            uIATakeScreenShotOfElementLocation["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationparentWindowHandle);
            if (uIATakeScreenShotOfElementLocationsearchElementName != null)
            {
                uIATakeScreenShotOfElementLocation["SearchElementName"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationsearchElementName);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationsearchElementClassName != null)
            {
                uIATakeScreenShotOfElementLocation["SearchElementClassName"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationsearchElementClassName);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationsearchElementAutomationId != null)
            {
                uIATakeScreenShotOfElementLocation["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationsearchElementAutomationId);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationsearchLocalizedControlType != null)
            {
                uIATakeScreenShotOfElementLocation["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationsearchLocalizedControlType);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationsearchSubTree != null)
            {
                uIATakeScreenShotOfElementLocation["SearchSubTree"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationsearchSubTree);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationimageFormat != null)
            {
                uIATakeScreenShotOfElementLocation["ImageFormat"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationimageFormat);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationmatchIndex != null)
            {
                uIATakeScreenShotOfElementLocation["MatchIndex"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationmatchIndex);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationsearchFilter != null)
            {
                uIATakeScreenShotOfElementLocation["SearchFilter"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationsearchFilter);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationsortByColumn != null)
            {
                uIATakeScreenShotOfElementLocation["SortByColumn"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationsortByColumn);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationmatchIndexAscending != null)
            {
                uIATakeScreenShotOfElementLocation["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationmatchIndexAscending);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationhideAgent != null)
            {
                uIATakeScreenShotOfElementLocation["HideAgent"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationhideAgent);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationmaxElementsToSearch != null)
            {
                uIATakeScreenShotOfElementLocation["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationmaxElementsToSearch);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationmaxRelativeSearchDepth != null)
            {
                uIATakeScreenShotOfElementLocation["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationmaxRelativeSearchDepth);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationmaxChildElementsToSearchPerNode != null)
            {
                uIATakeScreenShotOfElementLocation["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationmaxChildElementsToSearchPerNode);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationelementLocalizedControlTypesNotToTraverse != null)
            {
                uIATakeScreenShotOfElementLocation["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationelementLocalizedControlTypesNotToTraverse);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            uIATakeScreenShotOfElementLocationpropCount++;
            uIATakeScreenShotOfElementLocation["Workflow"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationworkflow);
            if (uIATakeScreenShotOfElementLocationpropCount > 0)
            {
                callPayload.Body = uIATakeScreenShotOfElementLocation;
            }

            return new ApiConnectionAction<UIATakeScreenShotOfElementLocationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIADrawRectangleAroundElement(Expression<Func<int>> uIADrawRectangleAroundElementparentWindowHandle, Expression<Func<string>> uIADrawRectangleAroundElementworkflow, Expression<Func<string>> uIADrawRectangleAroundElementsearchElementName = null, Expression<Func<string>> uIADrawRectangleAroundElementsearchElementClassName = null, Expression<Func<string>> uIADrawRectangleAroundElementsearchElementAutomationId = null, Expression<Func<string>> uIADrawRectangleAroundElementsearchLocalizedControlType = null, Expression<Func<bool>> uIADrawRectangleAroundElementsearchSubTree = null, Expression<Func<string>> uIADrawRectangleAroundElementpenColour = null, Expression<Func<int>> uIADrawRectangleAroundElementpenThicknessPixels = null, Expression<Func<int>> uIADrawRectangleAroundElementmatchIndex = null, Expression<Func<string>> uIADrawRectangleAroundElementsearchFilter = null, Expression<Func<string>> uIADrawRectangleAroundElementsortByColumn = null, Expression<Func<bool>> uIADrawRectangleAroundElementmatchIndexAscending = null, Expression<Func<int>> uIADrawRectangleAroundElementmaxElementsToSearch = null, Expression<Func<int>> uIADrawRectangleAroundElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIADrawRectangleAroundElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIADrawRectangleAroundElementelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/DrawRectangleAroundElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIADrawRectangleAroundElement = new JObject();
            var uIADrawRectangleAroundElementpropCount = 0;
            uIADrawRectangleAroundElementpropCount++;
            uIADrawRectangleAroundElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementparentWindowHandle);
            if (uIADrawRectangleAroundElementsearchElementName != null)
            {
                uIADrawRectangleAroundElement["SearchElementName"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementsearchElementName);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementsearchElementClassName != null)
            {
                uIADrawRectangleAroundElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementsearchElementClassName);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementsearchElementAutomationId != null)
            {
                uIADrawRectangleAroundElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementsearchElementAutomationId);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementsearchLocalizedControlType != null)
            {
                uIADrawRectangleAroundElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementsearchLocalizedControlType);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementsearchSubTree != null)
            {
                uIADrawRectangleAroundElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementsearchSubTree);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementpenColour != null)
            {
                uIADrawRectangleAroundElement["PenColour"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementpenColour);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementpenThicknessPixels != null)
            {
                uIADrawRectangleAroundElement["PenThicknessPixels"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementpenThicknessPixels);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementmatchIndex != null)
            {
                uIADrawRectangleAroundElement["MatchIndex"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementmatchIndex);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementsearchFilter != null)
            {
                uIADrawRectangleAroundElement["SearchFilter"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementsearchFilter);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementsortByColumn != null)
            {
                uIADrawRectangleAroundElement["SortByColumn"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementsortByColumn);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementmatchIndexAscending != null)
            {
                uIADrawRectangleAroundElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementmatchIndexAscending);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementmaxElementsToSearch != null)
            {
                uIADrawRectangleAroundElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementmaxElementsToSearch);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementmaxRelativeSearchDepth != null)
            {
                uIADrawRectangleAroundElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementmaxRelativeSearchDepth);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementmaxChildElementsToSearchPerNode != null)
            {
                uIADrawRectangleAroundElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementmaxChildElementsToSearchPerNode);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIADrawRectangleAroundElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementelementLocalizedControlTypesNotToTraverse);
                uIADrawRectangleAroundElementpropCount++;
            }

            uIADrawRectangleAroundElementpropCount++;
            uIADrawRectangleAroundElement["Workflow"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementworkflow);
            if (uIADrawRectangleAroundElementpropCount > 0)
            {
                callPayload.Body = uIADrawRectangleAroundElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetParentElementHandleResponse> UIAGetParentElementHandle(Expression<Func<int>> uIAGetParentElementHandleelementHandle, Expression<Func<string>> uIAGetParentElementHandleworkflow)
        {
            var apiCallPath = "/UIAControl/GetParentElementHandle";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetParentElementHandle = new JObject();
            var uIAGetParentElementHandlepropCount = 0;
            uIAGetParentElementHandlepropCount++;
            uIAGetParentElementHandle["ElementHandle"] = ExpressionConverter.ConvertO(uIAGetParentElementHandleelementHandle);
            uIAGetParentElementHandlepropCount++;
            uIAGetParentElementHandle["Workflow"] = ExpressionConverter.ConvertO(uIAGetParentElementHandleworkflow);
            if (uIAGetParentElementHandlepropCount > 0)
            {
                callPayload.Body = uIAGetParentElementHandle;
            }

            return new ApiConnectionAction<UIAGetParentElementHandleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetDataGridElementContentsResponse> UIAGetDataGridElementContents(Expression<Func<string>> uIAGetDataGridElementContentsworkflow, Expression<Func<int>> uIAGetDataGridElementContentsparentWindowHandle = null, Expression<Func<string>> uIAGetDataGridElementContentssearchElementName = null, Expression<Func<string>> uIAGetDataGridElementContentssearchElementClassName = null, Expression<Func<string>> uIAGetDataGridElementContentssearchElementAutomationId = null, Expression<Func<string>> uIAGetDataGridElementContentssearchLocalizedControlType = null, Expression<Func<bool>> uIAGetDataGridElementContentssearchSubTree = null, Expression<Func<bool>> uIAGetDataGridElementContentsonScreenColumnsOnly = null, Expression<Func<bool>> uIAGetDataGridElementContentsonScreenRowsOnly = null, Expression<Func<bool>> uIAGetDataGridElementContentsreturnNullValuesAsBlank = null, Expression<Func<string>> uIAGetDataGridElementContentsalternativeHeaderRowName = null, Expression<Func<bool>> uIAGetDataGridElementContentsreturnRowUIAName = null, Expression<Func<string>> uIAGetDataGridElementContentsnameOfColumnToStoreRowUIAName = null, Expression<Func<int>> uIAGetDataGridElementContentsmatchIndex = null, Expression<Func<string>> uIAGetDataGridElementContentssearchFilter = null, Expression<Func<string>> uIAGetDataGridElementContentssortByColumn = null, Expression<Func<bool>> uIAGetDataGridElementContentsmatchIndexAscending = null, Expression<Func<int>> uIAGetDataGridElementContentsfirstItemToReturn = null, Expression<Func<int>> uIAGetDataGridElementContentsmaxItemsToReturn = null, Expression<Func<int>> uIAGetDataGridElementContentsscanFirstNRowsForEmptyRows = null, Expression<Func<bool>> uIAGetDataGridElementContentsreadTableAsThread = null, Expression<Func<int>> uIAGetDataGridElementContentsretrieveOutputDataFromThreadId = null, Expression<Func<int>> uIAGetDataGridElementContentssecondsToWaitForThread = null, Expression<Func<int>> uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNPercent = null, Expression<Func<int>> uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNRows = null, Expression<Func<int>> uIAGetDataGridElementContentsscrollDataGridVerticallyElementHandle = null, Expression<Func<int>> uIAGetDataGridElementContentsminimumDataGridRowsForScrolling = null, Expression<Func<bool>> uIAGetDataGridElementContentsraiseExceptionIfCannotScroll = null, Expression<Func<string>> uIAGetDataGridElementContentsalternativeVerticalScrollbarName = null, Expression<Func<int>> uIAGetDataGridElementContentsmaxElementsToSearch = null, Expression<Func<int>> uIAGetDataGridElementContentsmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetDataGridElementContentsmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetDataGridElementContentselementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/GetDataGridElementContents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetDataGridElementContents = new JObject();
            var uIAGetDataGridElementContentspropCount = 0;
            if (uIAGetDataGridElementContentsparentWindowHandle != null)
            {
                uIAGetDataGridElementContents["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsparentWindowHandle);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentssearchElementName != null)
            {
                uIAGetDataGridElementContents["SearchElementName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentssearchElementName);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentssearchElementClassName != null)
            {
                uIAGetDataGridElementContents["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentssearchElementClassName);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentssearchElementAutomationId != null)
            {
                uIAGetDataGridElementContents["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentssearchElementAutomationId);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentssearchLocalizedControlType != null)
            {
                uIAGetDataGridElementContents["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentssearchLocalizedControlType);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentssearchSubTree != null)
            {
                uIAGetDataGridElementContents["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentssearchSubTree);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsonScreenColumnsOnly != null)
            {
                uIAGetDataGridElementContents["OnScreenColumnsOnly"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsonScreenColumnsOnly);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsonScreenRowsOnly != null)
            {
                uIAGetDataGridElementContents["OnScreenRowsOnly"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsonScreenRowsOnly);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsreturnNullValuesAsBlank != null)
            {
                uIAGetDataGridElementContents["ReturnNullValuesAsBlank"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsreturnNullValuesAsBlank);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsalternativeHeaderRowName != null)
            {
                uIAGetDataGridElementContents["AlternativeHeaderRowName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsalternativeHeaderRowName);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsreturnRowUIAName != null)
            {
                uIAGetDataGridElementContents["ReturnRowUIAName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsreturnRowUIAName);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsnameOfColumnToStoreRowUIAName != null)
            {
                uIAGetDataGridElementContents["NameOfColumnToStoreRowUIAName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsnameOfColumnToStoreRowUIAName);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsmatchIndex != null)
            {
                uIAGetDataGridElementContents["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsmatchIndex);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentssearchFilter != null)
            {
                uIAGetDataGridElementContents["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentssearchFilter);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentssortByColumn != null)
            {
                uIAGetDataGridElementContents["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentssortByColumn);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsmatchIndexAscending != null)
            {
                uIAGetDataGridElementContents["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsmatchIndexAscending);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsfirstItemToReturn != null)
            {
                uIAGetDataGridElementContents["FirstItemToReturn"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsfirstItemToReturn);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsmaxItemsToReturn != null)
            {
                uIAGetDataGridElementContents["MaxItemsToReturn"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsmaxItemsToReturn);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsscanFirstNRowsForEmptyRows != null)
            {
                uIAGetDataGridElementContents["ScanFirstNRowsForEmptyRows"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsscanFirstNRowsForEmptyRows);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsreadTableAsThread != null)
            {
                uIAGetDataGridElementContents["ReadTableAsThread"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsreadTableAsThread);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsretrieveOutputDataFromThreadId != null)
            {
                uIAGetDataGridElementContents["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsretrieveOutputDataFromThreadId);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentssecondsToWaitForThread != null)
            {
                uIAGetDataGridElementContents["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentssecondsToWaitForThread);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNPercent != null)
            {
                uIAGetDataGridElementContents["ScrollDataGridVerticallyEveryNPercent"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNPercent);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNRows != null)
            {
                uIAGetDataGridElementContents["ScrollDataGridVerticallyEveryNRows"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNRows);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsscrollDataGridVerticallyElementHandle != null)
            {
                uIAGetDataGridElementContents["ScrollDataGridVerticallyElementHandle"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsscrollDataGridVerticallyElementHandle);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsminimumDataGridRowsForScrolling != null)
            {
                uIAGetDataGridElementContents["MinimumDataGridRowsForScrolling"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsminimumDataGridRowsForScrolling);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsraiseExceptionIfCannotScroll != null)
            {
                uIAGetDataGridElementContents["RaiseExceptionIfCannotScroll"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsraiseExceptionIfCannotScroll);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsalternativeVerticalScrollbarName != null)
            {
                uIAGetDataGridElementContents["AlternativeVerticalScrollbarName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsalternativeVerticalScrollbarName);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsmaxElementsToSearch != null)
            {
                uIAGetDataGridElementContents["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsmaxElementsToSearch);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsmaxRelativeSearchDepth != null)
            {
                uIAGetDataGridElementContents["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsmaxRelativeSearchDepth);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsmaxChildElementsToSearchPerNode != null)
            {
                uIAGetDataGridElementContents["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsmaxChildElementsToSearchPerNode);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentselementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetDataGridElementContents["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentselementLocalizedControlTypesNotToTraverse);
                uIAGetDataGridElementContentspropCount++;
            }

            uIAGetDataGridElementContentspropCount++;
            uIAGetDataGridElementContents["Workflow"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsworkflow);
            if (uIAGetDataGridElementContentspropCount > 0)
            {
                callPayload.Body = uIAGetDataGridElementContents;
            }

            return new ApiConnectionAction<UIAGetDataGridElementContentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetDataGridElementPropertiesResponse> UIAGetDataGridElementProperties(Expression<Func<int>> uIAGetDataGridElementPropertiesparentWindowHandle, Expression<Func<string>> uIAGetDataGridElementPropertiesworkflow, Expression<Func<string>> uIAGetDataGridElementPropertiessearchElementName = null, Expression<Func<string>> uIAGetDataGridElementPropertiessearchElementClassName = null, Expression<Func<string>> uIAGetDataGridElementPropertiessearchElementAutomationId = null, Expression<Func<string>> uIAGetDataGridElementPropertiessearchLocalizedControlType = null, Expression<Func<bool>> uIAGetDataGridElementPropertiessearchSubTree = null, Expression<Func<string>> uIAGetDataGridElementPropertiesalternativeHeaderRowName = null, Expression<Func<int>> uIAGetDataGridElementPropertiesmatchIndex = null, Expression<Func<string>> uIAGetDataGridElementPropertiessearchFilter = null, Expression<Func<string>> uIAGetDataGridElementPropertiessortByColumn = null, Expression<Func<bool>> uIAGetDataGridElementPropertiesmatchIndexAscending = null, Expression<Func<int>> uIAGetDataGridElementPropertiesmaxElementsToSearch = null, Expression<Func<int>> uIAGetDataGridElementPropertiesmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetDataGridElementPropertiesmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetDataGridElementPropertieselementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/GetDataGridElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetDataGridElementProperties = new JObject();
            var uIAGetDataGridElementPropertiespropCount = 0;
            uIAGetDataGridElementPropertiespropCount++;
            uIAGetDataGridElementProperties["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesparentWindowHandle);
            if (uIAGetDataGridElementPropertiessearchElementName != null)
            {
                uIAGetDataGridElementProperties["SearchElementName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiessearchElementName);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiessearchElementClassName != null)
            {
                uIAGetDataGridElementProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiessearchElementClassName);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiessearchElementAutomationId != null)
            {
                uIAGetDataGridElementProperties["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiessearchElementAutomationId);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiessearchLocalizedControlType != null)
            {
                uIAGetDataGridElementProperties["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiessearchLocalizedControlType);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiessearchSubTree != null)
            {
                uIAGetDataGridElementProperties["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiessearchSubTree);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesalternativeHeaderRowName != null)
            {
                uIAGetDataGridElementProperties["AlternativeHeaderRowName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesalternativeHeaderRowName);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesmatchIndex != null)
            {
                uIAGetDataGridElementProperties["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesmatchIndex);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiessearchFilter != null)
            {
                uIAGetDataGridElementProperties["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiessearchFilter);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiessortByColumn != null)
            {
                uIAGetDataGridElementProperties["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiessortByColumn);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesmatchIndexAscending != null)
            {
                uIAGetDataGridElementProperties["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesmatchIndexAscending);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesmaxElementsToSearch != null)
            {
                uIAGetDataGridElementProperties["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesmaxElementsToSearch);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesmaxRelativeSearchDepth != null)
            {
                uIAGetDataGridElementProperties["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesmaxRelativeSearchDepth);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesmaxChildElementsToSearchPerNode != null)
            {
                uIAGetDataGridElementProperties["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesmaxChildElementsToSearchPerNode);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertieselementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetDataGridElementProperties["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertieselementLocalizedControlTypesNotToTraverse);
                uIAGetDataGridElementPropertiespropCount++;
            }

            uIAGetDataGridElementPropertiespropCount++;
            uIAGetDataGridElementProperties["Workflow"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesworkflow);
            if (uIAGetDataGridElementPropertiespropCount > 0)
            {
                callPayload.Body = uIAGetDataGridElementProperties;
            }

            return new ApiConnectionAction<UIAGetDataGridElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetListElementItemsResponse> UIAGetListElementItems(Expression<Func<int>> uIAGetListElementItemsparentWindowHandle, Expression<Func<string>> uIAGetListElementItemsworkflow, Expression<Func<string>> uIAGetListElementItemssearchElementName = null, Expression<Func<string>> uIAGetListElementItemssearchElementClassName = null, Expression<Func<string>> uIAGetListElementItemssearchElementAutomationId = null, Expression<Func<string>> uIAGetListElementItemssearchLocalizedControlType = null, Expression<Func<bool>> uIAGetListElementItemssearchSubTree = null, Expression<Func<bool>> uIAGetListElementItemsexpandFirst = null, Expression<Func<bool>> uIAGetListElementItemscollapseAfter = null, Expression<Func<bool>> uIAGetListElementItemscheckForSelectedItems = null, Expression<Func<double>> uIAGetListElementItemssecondsBetweenExpandCollapse = null, Expression<Func<int>> uIAGetListElementItemsmatchIndex = null, Expression<Func<string>> uIAGetListElementItemssearchFilter = null, Expression<Func<string>> uIAGetListElementItemssortByColumn = null, Expression<Func<bool>> uIAGetListElementItemsmatchIndexAscending = null, Expression<Func<int>> uIAGetListElementItemsmaxElementsToSearch = null, Expression<Func<int>> uIAGetListElementItemsmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetListElementItemsmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetListElementItemselementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/GetListElementItems";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetListElementItems = new JObject();
            var uIAGetListElementItemspropCount = 0;
            uIAGetListElementItemspropCount++;
            uIAGetListElementItems["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGetListElementItemsparentWindowHandle);
            if (uIAGetListElementItemssearchElementName != null)
            {
                uIAGetListElementItems["SearchElementName"] = ExpressionConverter.ConvertO(uIAGetListElementItemssearchElementName);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemssearchElementClassName != null)
            {
                uIAGetListElementItems["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGetListElementItemssearchElementClassName);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemssearchElementAutomationId != null)
            {
                uIAGetListElementItems["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGetListElementItemssearchElementAutomationId);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemssearchLocalizedControlType != null)
            {
                uIAGetListElementItems["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetListElementItemssearchLocalizedControlType);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemssearchSubTree != null)
            {
                uIAGetListElementItems["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetListElementItemssearchSubTree);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsexpandFirst != null)
            {
                uIAGetListElementItems["ExpandFirst"] = ExpressionConverter.ConvertO(uIAGetListElementItemsexpandFirst);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemscollapseAfter != null)
            {
                uIAGetListElementItems["CollapseAfter"] = ExpressionConverter.ConvertO(uIAGetListElementItemscollapseAfter);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemscheckForSelectedItems != null)
            {
                uIAGetListElementItems["CheckForSelectedItems"] = ExpressionConverter.ConvertO(uIAGetListElementItemscheckForSelectedItems);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemssecondsBetweenExpandCollapse != null)
            {
                uIAGetListElementItems["SecondsBetweenExpandCollapse"] = ExpressionConverter.ConvertO(uIAGetListElementItemssecondsBetweenExpandCollapse);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsmatchIndex != null)
            {
                uIAGetListElementItems["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetListElementItemsmatchIndex);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemssearchFilter != null)
            {
                uIAGetListElementItems["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetListElementItemssearchFilter);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemssortByColumn != null)
            {
                uIAGetListElementItems["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetListElementItemssortByColumn);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsmatchIndexAscending != null)
            {
                uIAGetListElementItems["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetListElementItemsmatchIndexAscending);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsmaxElementsToSearch != null)
            {
                uIAGetListElementItems["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetListElementItemsmaxElementsToSearch);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsmaxRelativeSearchDepth != null)
            {
                uIAGetListElementItems["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetListElementItemsmaxRelativeSearchDepth);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsmaxChildElementsToSearchPerNode != null)
            {
                uIAGetListElementItems["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetListElementItemsmaxChildElementsToSearchPerNode);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemselementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetListElementItems["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGetListElementItemselementLocalizedControlTypesNotToTraverse);
                uIAGetListElementItemspropCount++;
            }

            uIAGetListElementItemspropCount++;
            uIAGetListElementItems["Workflow"] = ExpressionConverter.ConvertO(uIAGetListElementItemsworkflow);
            if (uIAGetListElementItemspropCount > 0)
            {
                callPayload.Body = uIAGetListElementItems;
            }

            return new ApiConnectionAction<UIAGetListElementItemsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAClickListElementItemByName(Expression<Func<int>> uIAClickListElementItemByNameparentWindowHandle, Expression<Func<string>> uIAClickListElementItemByNameworkflow, Expression<Func<string>> uIAClickListElementItemByNamesearchElementName = null, Expression<Func<string>> uIAClickListElementItemByNamesearchElementClassName = null, Expression<Func<string>> uIAClickListElementItemByNamesearchElementAutomationId = null, Expression<Func<string>> uIAClickListElementItemByNamesearchLocalizedControlType = null, Expression<Func<bool>> uIAClickListElementItemByNamesearchSubTree = null, Expression<Func<bool>> uIAClickListElementItemByNameexpandFirst = null, Expression<Func<bool>> uIAClickListElementItemByNamecollapseAfter = null, Expression<Func<string>> uIAClickListElementItemByNameitemName = null, Expression<Func<double>> uIAClickListElementItemByNamesecondsBetweenExpandCollapse = null, Expression<Func<int>> uIAClickListElementItemByNamematchIndex = null, Expression<Func<string>> uIAClickListElementItemByNamesearchFilter = null, Expression<Func<string>> uIAClickListElementItemByNamesortByColumn = null, Expression<Func<bool>> uIAClickListElementItemByNamematchIndexAscending = null, Expression<Func<int>> uIAClickListElementItemByNamemaxElementsToSearch = null, Expression<Func<int>> uIAClickListElementItemByNamemaxRelativeSearchDepth = null, Expression<Func<int>> uIAClickListElementItemByNamemaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAClickListElementItemByNameelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/ClickListElementItemByName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAClickListElementItemByName = new JObject();
            var uIAClickListElementItemByNamepropCount = 0;
            uIAClickListElementItemByNamepropCount++;
            uIAClickListElementItemByName["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameparentWindowHandle);
            if (uIAClickListElementItemByNamesearchElementName != null)
            {
                uIAClickListElementItemByName["SearchElementName"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNamesearchElementName);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamesearchElementClassName != null)
            {
                uIAClickListElementItemByName["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNamesearchElementClassName);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamesearchElementAutomationId != null)
            {
                uIAClickListElementItemByName["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNamesearchElementAutomationId);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamesearchLocalizedControlType != null)
            {
                uIAClickListElementItemByName["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNamesearchLocalizedControlType);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamesearchSubTree != null)
            {
                uIAClickListElementItemByName["SearchSubTree"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNamesearchSubTree);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNameexpandFirst != null)
            {
                uIAClickListElementItemByName["ExpandFirst"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameexpandFirst);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamecollapseAfter != null)
            {
                uIAClickListElementItemByName["CollapseAfter"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNamecollapseAfter);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNameitemName != null)
            {
                uIAClickListElementItemByName["ItemName"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameitemName);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamesecondsBetweenExpandCollapse != null)
            {
                uIAClickListElementItemByName["SecondsBetweenExpandCollapse"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNamesecondsBetweenExpandCollapse);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamematchIndex != null)
            {
                uIAClickListElementItemByName["MatchIndex"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNamematchIndex);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamesearchFilter != null)
            {
                uIAClickListElementItemByName["SearchFilter"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNamesearchFilter);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamesortByColumn != null)
            {
                uIAClickListElementItemByName["SortByColumn"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNamesortByColumn);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamematchIndexAscending != null)
            {
                uIAClickListElementItemByName["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNamematchIndexAscending);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamemaxElementsToSearch != null)
            {
                uIAClickListElementItemByName["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNamemaxElementsToSearch);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamemaxRelativeSearchDepth != null)
            {
                uIAClickListElementItemByName["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNamemaxRelativeSearchDepth);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamemaxChildElementsToSearchPerNode != null)
            {
                uIAClickListElementItemByName["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNamemaxChildElementsToSearchPerNode);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNameelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAClickListElementItemByName["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameelementLocalizedControlTypesNotToTraverse);
                uIAClickListElementItemByNamepropCount++;
            }

            uIAClickListElementItemByNamepropCount++;
            uIAClickListElementItemByName["Workflow"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameworkflow);
            if (uIAClickListElementItemByNamepropCount > 0)
            {
                callPayload.Body = uIAClickListElementItemByName;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAClickListElementItemByIndex(Expression<Func<int>> uIAClickListElementItemByIndexparentWindowHandle, Expression<Func<string>> uIAClickListElementItemByIndexworkflow, Expression<Func<string>> uIAClickListElementItemByIndexsearchElementName = null, Expression<Func<string>> uIAClickListElementItemByIndexsearchElementClassName = null, Expression<Func<string>> uIAClickListElementItemByIndexsearchElementAutomationId = null, Expression<Func<string>> uIAClickListElementItemByIndexsearchLocalizedControlType = null, Expression<Func<bool>> uIAClickListElementItemByIndexsearchSubTree = null, Expression<Func<bool>> uIAClickListElementItemByIndexexpandFirst = null, Expression<Func<bool>> uIAClickListElementItemByIndexcollapseAfter = null, Expression<Func<int>> uIAClickListElementItemByIndexitemIndex = null, Expression<Func<double>> uIAClickListElementItemByIndexsecondsBetweenExpandCollapse = null, Expression<Func<int>> uIAClickListElementItemByIndexmatchIndex = null, Expression<Func<string>> uIAClickListElementItemByIndexsearchFilter = null, Expression<Func<string>> uIAClickListElementItemByIndexsortByColumn = null, Expression<Func<bool>> uIAClickListElementItemByIndexmatchIndexAscending = null, Expression<Func<int>> uIAClickListElementItemByIndexmaxElementsToSearch = null, Expression<Func<int>> uIAClickListElementItemByIndexmaxRelativeSearchDepth = null, Expression<Func<int>> uIAClickListElementItemByIndexmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAClickListElementItemByIndexelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/ClickListElementItemByIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAClickListElementItemByIndex = new JObject();
            var uIAClickListElementItemByIndexpropCount = 0;
            uIAClickListElementItemByIndexpropCount++;
            uIAClickListElementItemByIndex["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexparentWindowHandle);
            if (uIAClickListElementItemByIndexsearchElementName != null)
            {
                uIAClickListElementItemByIndex["SearchElementName"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexsearchElementName);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexsearchElementClassName != null)
            {
                uIAClickListElementItemByIndex["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexsearchElementClassName);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexsearchElementAutomationId != null)
            {
                uIAClickListElementItemByIndex["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexsearchElementAutomationId);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexsearchLocalizedControlType != null)
            {
                uIAClickListElementItemByIndex["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexsearchLocalizedControlType);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexsearchSubTree != null)
            {
                uIAClickListElementItemByIndex["SearchSubTree"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexsearchSubTree);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexexpandFirst != null)
            {
                uIAClickListElementItemByIndex["ExpandFirst"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexexpandFirst);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexcollapseAfter != null)
            {
                uIAClickListElementItemByIndex["CollapseAfter"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexcollapseAfter);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexitemIndex != null)
            {
                uIAClickListElementItemByIndex["ItemIndex"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexitemIndex);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexsecondsBetweenExpandCollapse != null)
            {
                uIAClickListElementItemByIndex["SecondsBetweenExpandCollapse"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexsecondsBetweenExpandCollapse);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexmatchIndex != null)
            {
                uIAClickListElementItemByIndex["MatchIndex"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexmatchIndex);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexsearchFilter != null)
            {
                uIAClickListElementItemByIndex["SearchFilter"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexsearchFilter);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexsortByColumn != null)
            {
                uIAClickListElementItemByIndex["SortByColumn"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexsortByColumn);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexmatchIndexAscending != null)
            {
                uIAClickListElementItemByIndex["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexmatchIndexAscending);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexmaxElementsToSearch != null)
            {
                uIAClickListElementItemByIndex["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexmaxElementsToSearch);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexmaxRelativeSearchDepth != null)
            {
                uIAClickListElementItemByIndex["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexmaxRelativeSearchDepth);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexmaxChildElementsToSearchPerNode != null)
            {
                uIAClickListElementItemByIndex["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexmaxChildElementsToSearchPerNode);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAClickListElementItemByIndex["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexelementLocalizedControlTypesNotToTraverse);
                uIAClickListElementItemByIndexpropCount++;
            }

            uIAClickListElementItemByIndexpropCount++;
            uIAClickListElementItemByIndex["Workflow"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexworkflow);
            if (uIAClickListElementItemByIndexpropCount > 0)
            {
                callPayload.Body = uIAClickListElementItemByIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIASetElementToNumericValue(Expression<Func<int>> uIASetElementToNumericValueparentWindowHandle, Expression<Func<int>> uIASetElementToNumericValuenewValue, Expression<Func<string>> uIASetElementToNumericValueworkflow, Expression<Func<string>> uIASetElementToNumericValuesearchElementName = null, Expression<Func<string>> uIASetElementToNumericValuesearchElementClassName = null, Expression<Func<string>> uIASetElementToNumericValuesearchElementAutomationId = null, Expression<Func<string>> uIASetElementToNumericValuesearchLocalizedControlType = null, Expression<Func<bool>> uIASetElementToNumericValuesearchSubTree = null, Expression<Func<int>> uIASetElementToNumericValuematchIndex = null, Expression<Func<string>> uIASetElementToNumericValuesearchFilter = null, Expression<Func<string>> uIASetElementToNumericValuesortByColumn = null, Expression<Func<bool>> uIASetElementToNumericValuematchIndexAscending = null, Expression<Func<int>> uIASetElementToNumericValuemaxElementsToSearch = null, Expression<Func<int>> uIASetElementToNumericValuemaxRelativeSearchDepth = null, Expression<Func<int>> uIASetElementToNumericValuemaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIASetElementToNumericValueelementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIASetElementToNumericValueraiseExceptionIfInputValidationFails = null, Expression<Func<bool>> uIASetElementToNumericValuetryValuePattern = null, Expression<Func<bool>> uIASetElementToNumericValuetryLegacyPattern = null)
        {
            var apiCallPath = "/UIAControl/UIASetElementToNumericValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIASetElementToNumericValue = new JObject();
            var uIASetElementToNumericValuepropCount = 0;
            uIASetElementToNumericValuepropCount++;
            uIASetElementToNumericValue["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueparentWindowHandle);
            if (uIASetElementToNumericValuesearchElementName != null)
            {
                uIASetElementToNumericValue["SearchElementName"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuesearchElementName);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuesearchElementClassName != null)
            {
                uIASetElementToNumericValue["SearchElementClassName"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuesearchElementClassName);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuesearchElementAutomationId != null)
            {
                uIASetElementToNumericValue["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuesearchElementAutomationId);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuesearchLocalizedControlType != null)
            {
                uIASetElementToNumericValue["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuesearchLocalizedControlType);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuesearchSubTree != null)
            {
                uIASetElementToNumericValue["SearchSubTree"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuesearchSubTree);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuematchIndex != null)
            {
                uIASetElementToNumericValue["MatchIndex"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuematchIndex);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuesearchFilter != null)
            {
                uIASetElementToNumericValue["SearchFilter"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuesearchFilter);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuesortByColumn != null)
            {
                uIASetElementToNumericValue["SortByColumn"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuesortByColumn);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuematchIndexAscending != null)
            {
                uIASetElementToNumericValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuematchIndexAscending);
                uIASetElementToNumericValuepropCount++;
            }

            uIASetElementToNumericValuepropCount++;
            uIASetElementToNumericValue["NewValue"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuenewValue);
            if (uIASetElementToNumericValuemaxElementsToSearch != null)
            {
                uIASetElementToNumericValue["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuemaxElementsToSearch);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuemaxRelativeSearchDepth != null)
            {
                uIASetElementToNumericValue["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuemaxRelativeSearchDepth);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuemaxChildElementsToSearchPerNode != null)
            {
                uIASetElementToNumericValue["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuemaxChildElementsToSearchPerNode);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValueelementLocalizedControlTypesNotToTraverse != null)
            {
                uIASetElementToNumericValue["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueelementLocalizedControlTypesNotToTraverse);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValueraiseExceptionIfInputValidationFails != null)
            {
                uIASetElementToNumericValue["RaiseExceptionIfInputValidationFails"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueraiseExceptionIfInputValidationFails);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuetryValuePattern != null)
            {
                uIASetElementToNumericValue["TryValuePattern"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuetryValuePattern);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuetryLegacyPattern != null)
            {
                uIASetElementToNumericValue["TryLegacyPattern"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuetryLegacyPattern);
                uIASetElementToNumericValuepropCount++;
            }

            uIASetElementToNumericValuepropCount++;
            uIASetElementToNumericValue["Workflow"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueworkflow);
            if (uIASetElementToNumericValuepropCount > 0)
            {
                callPayload.Body = uIASetElementToNumericValue;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIASetElementToNumericRangeValue(Expression<Func<int>> uIASetElementToNumericRangeValueparentWindowHandle, Expression<Func<double>> uIASetElementToNumericRangeValuenewValue, Expression<Func<string>> uIASetElementToNumericRangeValueworkflow, Expression<Func<string>> uIASetElementToNumericRangeValuesearchElementName = null, Expression<Func<string>> uIASetElementToNumericRangeValuesearchElementClassName = null, Expression<Func<string>> uIASetElementToNumericRangeValuesearchElementAutomationId = null, Expression<Func<string>> uIASetElementToNumericRangeValuesearchLocalizedControlType = null, Expression<Func<bool>> uIASetElementToNumericRangeValuesearchSubTree = null, Expression<Func<int>> uIASetElementToNumericRangeValuematchIndex = null, Expression<Func<string>> uIASetElementToNumericRangeValuesearchFilter = null, Expression<Func<string>> uIASetElementToNumericRangeValuesortByColumn = null, Expression<Func<bool>> uIASetElementToNumericRangeValuematchIndexAscending = null, Expression<Func<bool>> uIASetElementToNumericRangeValuenewValueIsPercentage = null, Expression<Func<int>> uIASetElementToNumericRangeValuemaxElementsToSearch = null, Expression<Func<int>> uIASetElementToNumericRangeValuemaxRelativeSearchDepth = null, Expression<Func<int>> uIASetElementToNumericRangeValuemaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIASetElementToNumericRangeValueelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/UIASetElementToNumericRangeValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIASetElementToNumericRangeValue = new JObject();
            var uIASetElementToNumericRangeValuepropCount = 0;
            uIASetElementToNumericRangeValuepropCount++;
            uIASetElementToNumericRangeValue["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValueparentWindowHandle);
            if (uIASetElementToNumericRangeValuesearchElementName != null)
            {
                uIASetElementToNumericRangeValue["SearchElementName"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValuesearchElementName);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValuesearchElementClassName != null)
            {
                uIASetElementToNumericRangeValue["SearchElementClassName"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValuesearchElementClassName);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValuesearchElementAutomationId != null)
            {
                uIASetElementToNumericRangeValue["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValuesearchElementAutomationId);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValuesearchLocalizedControlType != null)
            {
                uIASetElementToNumericRangeValue["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValuesearchLocalizedControlType);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValuesearchSubTree != null)
            {
                uIASetElementToNumericRangeValue["SearchSubTree"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValuesearchSubTree);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValuematchIndex != null)
            {
                uIASetElementToNumericRangeValue["MatchIndex"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValuematchIndex);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValuesearchFilter != null)
            {
                uIASetElementToNumericRangeValue["SearchFilter"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValuesearchFilter);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValuesortByColumn != null)
            {
                uIASetElementToNumericRangeValue["SortByColumn"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValuesortByColumn);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValuematchIndexAscending != null)
            {
                uIASetElementToNumericRangeValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValuematchIndexAscending);
                uIASetElementToNumericRangeValuepropCount++;
            }

            uIASetElementToNumericRangeValuepropCount++;
            uIASetElementToNumericRangeValue["NewValue"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValuenewValue);
            if (uIASetElementToNumericRangeValuenewValueIsPercentage != null)
            {
                uIASetElementToNumericRangeValue["NewValueIsPercentage"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValuenewValueIsPercentage);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValuemaxElementsToSearch != null)
            {
                uIASetElementToNumericRangeValue["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValuemaxElementsToSearch);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValuemaxRelativeSearchDepth != null)
            {
                uIASetElementToNumericRangeValue["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValuemaxRelativeSearchDepth);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValuemaxChildElementsToSearchPerNode != null)
            {
                uIASetElementToNumericRangeValue["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValuemaxChildElementsToSearchPerNode);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValueelementLocalizedControlTypesNotToTraverse != null)
            {
                uIASetElementToNumericRangeValue["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValueelementLocalizedControlTypesNotToTraverse);
                uIASetElementToNumericRangeValuepropCount++;
            }

            uIASetElementToNumericRangeValuepropCount++;
            uIASetElementToNumericRangeValue["Workflow"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValueworkflow);
            if (uIASetElementToNumericRangeValuepropCount > 0)
            {
                callPayload.Body = uIASetElementToNumericRangeValue;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAResetAllElementHandles(Expression<Func<string>> uIAResetAllElementHandlesworkflow)
        {
            var apiCallPath = "/UIAControl/UIAResetAllElementHandles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAResetAllElementHandles = new JObject();
            var uIAResetAllElementHandlespropCount = 0;
            uIAResetAllElementHandlespropCount++;
            uIAResetAllElementHandles["Workflow"] = ExpressionConverter.ConvertO(uIAResetAllElementHandlesworkflow);
            if (uIAResetAllElementHandlespropCount > 0)
            {
                callPayload.Body = uIAResetAllElementHandles;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalPasswordInputIntoElement(Expression<Func<int>> uIAGlobalPasswordInputIntoElementparentWindowHandle, Expression<Func<string>> uIAGlobalPasswordInputIntoElementpasswordToInput, Expression<Func<string>> uIAGlobalPasswordInputIntoElementworkflow, Expression<Func<string>> uIAGlobalPasswordInputIntoElementsearchElementName = null, Expression<Func<string>> uIAGlobalPasswordInputIntoElementsearchElementClassName = null, Expression<Func<string>> uIAGlobalPasswordInputIntoElementsearchElementAutomationId = null, Expression<Func<string>> uIAGlobalPasswordInputIntoElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementsearchSubTree = null, Expression<Func<int>> uIAGlobalPasswordInputIntoElementmatchIndex = null, Expression<Func<string>> uIAGlobalPasswordInputIntoElementsearchFilter = null, Expression<Func<string>> uIAGlobalPasswordInputIntoElementsortByColumn = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementmatchIndexAscending = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementfocusElement = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementglobalMouseClickOnElement = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingDoubleClickDelete = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingCTRLADelete = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementsendKeyEvents = null, Expression<Func<int>> uIAGlobalPasswordInputIntoElementinterval = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementdontInterpretSymbols = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementpasswordContainsStoredPassword = null, Expression<Func<int>> uIAGlobalPasswordInputIntoElementmaxElementsToSearch = null, Expression<Func<int>> uIAGlobalPasswordInputIntoElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGlobalPasswordInputIntoElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGlobalPasswordInputIntoElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementvalidateClickablePointWithinElementBoundary = null)
        {
            var apiCallPath = "/UIAControl/UIAGlobalPasswordInputIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGlobalPasswordInputIntoElement = new JObject();
            var uIAGlobalPasswordInputIntoElementpropCount = 0;
            uIAGlobalPasswordInputIntoElementpropCount++;
            uIAGlobalPasswordInputIntoElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementparentWindowHandle);
            if (uIAGlobalPasswordInputIntoElementsearchElementName != null)
            {
                uIAGlobalPasswordInputIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementsearchElementName);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementsearchElementClassName != null)
            {
                uIAGlobalPasswordInputIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementsearchElementClassName);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementsearchElementAutomationId != null)
            {
                uIAGlobalPasswordInputIntoElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementsearchElementAutomationId);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementsearchLocalizedControlType != null)
            {
                uIAGlobalPasswordInputIntoElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementsearchLocalizedControlType);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementsearchSubTree != null)
            {
                uIAGlobalPasswordInputIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementsearchSubTree);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementmatchIndex != null)
            {
                uIAGlobalPasswordInputIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementmatchIndex);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementsearchFilter != null)
            {
                uIAGlobalPasswordInputIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementsearchFilter);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementsortByColumn != null)
            {
                uIAGlobalPasswordInputIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementsortByColumn);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementmatchIndexAscending != null)
            {
                uIAGlobalPasswordInputIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementmatchIndexAscending);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementfocusElement != null)
            {
                uIAGlobalPasswordInputIntoElement["FocusElement"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementfocusElement);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementglobalMouseClickOnElement != null)
            {
                uIAGlobalPasswordInputIntoElement["GlobalMouseClickOnElement"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementglobalMouseClickOnElement);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingDoubleClickDelete != null)
            {
                uIAGlobalPasswordInputIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingDoubleClickDelete);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingCTRLADelete != null)
            {
                uIAGlobalPasswordInputIntoElement["ReplaceExistingValueUsingCTRLADelete"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingCTRLADelete);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            uIAGlobalPasswordInputIntoElementpropCount++;
            uIAGlobalPasswordInputIntoElement["PasswordToInput"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementpasswordToInput);
            if (uIAGlobalPasswordInputIntoElementsendKeyEvents != null)
            {
                uIAGlobalPasswordInputIntoElement["SendKeyEvents"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementsendKeyEvents);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementinterval != null)
            {
                uIAGlobalPasswordInputIntoElement["Interval"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementinterval);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementdontInterpretSymbols != null)
            {
                uIAGlobalPasswordInputIntoElement["DontInterpretSymbols"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementdontInterpretSymbols);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementpasswordContainsStoredPassword != null)
            {
                uIAGlobalPasswordInputIntoElement["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementpasswordContainsStoredPassword);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementmaxElementsToSearch != null)
            {
                uIAGlobalPasswordInputIntoElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementmaxElementsToSearch);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementmaxRelativeSearchDepth != null)
            {
                uIAGlobalPasswordInputIntoElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementmaxRelativeSearchDepth);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementmaxChildElementsToSearchPerNode != null)
            {
                uIAGlobalPasswordInputIntoElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementmaxChildElementsToSearchPerNode);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGlobalPasswordInputIntoElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementelementLocalizedControlTypesNotToTraverse);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementvalidateClickablePointWithinElementBoundary != null)
            {
                uIAGlobalPasswordInputIntoElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementvalidateClickablePointWithinElementBoundary);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            uIAGlobalPasswordInputIntoElementpropCount++;
            uIAGlobalPasswordInputIntoElement["Workflow"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementworkflow);
            if (uIAGlobalPasswordInputIntoElementpropCount > 0)
            {
                callPayload.Body = uIAGlobalPasswordInputIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalTextInputIntoElement(Expression<Func<int>> uIAGlobalTextInputIntoElementparentWindowHandle, Expression<Func<string>> uIAGlobalTextInputIntoElementworkflow, Expression<Func<string>> uIAGlobalTextInputIntoElementsearchElementName = null, Expression<Func<string>> uIAGlobalTextInputIntoElementsearchElementClassName = null, Expression<Func<string>> uIAGlobalTextInputIntoElementsearchElementAutomationId = null, Expression<Func<string>> uIAGlobalTextInputIntoElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementsearchSubTree = null, Expression<Func<int>> uIAGlobalTextInputIntoElementmatchIndex = null, Expression<Func<string>> uIAGlobalTextInputIntoElementsearchFilter = null, Expression<Func<string>> uIAGlobalTextInputIntoElementsortByColumn = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementmatchIndexAscending = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementfocusElement = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementglobalMouseClickOnElement = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementreplaceExistingValueUsingDoubleClickDelete = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementreplaceExistingValueUsingCTRLADelete = null, Expression<Func<string>> uIAGlobalTextInputIntoElementtextToInput = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementsendKeyEvents = null, Expression<Func<int>> uIAGlobalTextInputIntoElementinterval = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementdontInterpretSymbols = null, Expression<Func<int>> uIAGlobalTextInputIntoElementmaxElementsToSearch = null, Expression<Func<int>> uIAGlobalTextInputIntoElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGlobalTextInputIntoElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGlobalTextInputIntoElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementvalidateClickablePointWithinElementBoundary = null)
        {
            var apiCallPath = "/UIAControl/UIAGlobalTextInputIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGlobalTextInputIntoElement = new JObject();
            var uIAGlobalTextInputIntoElementpropCount = 0;
            uIAGlobalTextInputIntoElementpropCount++;
            uIAGlobalTextInputIntoElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementparentWindowHandle);
            if (uIAGlobalTextInputIntoElementsearchElementName != null)
            {
                uIAGlobalTextInputIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementsearchElementName);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementsearchElementClassName != null)
            {
                uIAGlobalTextInputIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementsearchElementClassName);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementsearchElementAutomationId != null)
            {
                uIAGlobalTextInputIntoElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementsearchElementAutomationId);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementsearchLocalizedControlType != null)
            {
                uIAGlobalTextInputIntoElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementsearchLocalizedControlType);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementsearchSubTree != null)
            {
                uIAGlobalTextInputIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementsearchSubTree);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementmatchIndex != null)
            {
                uIAGlobalTextInputIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementmatchIndex);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementsearchFilter != null)
            {
                uIAGlobalTextInputIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementsearchFilter);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementsortByColumn != null)
            {
                uIAGlobalTextInputIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementsortByColumn);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementmatchIndexAscending != null)
            {
                uIAGlobalTextInputIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementmatchIndexAscending);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementfocusElement != null)
            {
                uIAGlobalTextInputIntoElement["FocusElement"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementfocusElement);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementglobalMouseClickOnElement != null)
            {
                uIAGlobalTextInputIntoElement["GlobalMouseClickOnElement"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementglobalMouseClickOnElement);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementreplaceExistingValueUsingDoubleClickDelete != null)
            {
                uIAGlobalTextInputIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementreplaceExistingValueUsingDoubleClickDelete);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementreplaceExistingValueUsingCTRLADelete != null)
            {
                uIAGlobalTextInputIntoElement["ReplaceExistingValueUsingCTRLADelete"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementreplaceExistingValueUsingCTRLADelete);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementtextToInput != null)
            {
                uIAGlobalTextInputIntoElement["TextToInput"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementtextToInput);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementsendKeyEvents != null)
            {
                uIAGlobalTextInputIntoElement["SendKeyEvents"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementsendKeyEvents);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementinterval != null)
            {
                uIAGlobalTextInputIntoElement["Interval"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementinterval);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementdontInterpretSymbols != null)
            {
                uIAGlobalTextInputIntoElement["DontInterpretSymbols"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementdontInterpretSymbols);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementmaxElementsToSearch != null)
            {
                uIAGlobalTextInputIntoElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementmaxElementsToSearch);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementmaxRelativeSearchDepth != null)
            {
                uIAGlobalTextInputIntoElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementmaxRelativeSearchDepth);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementmaxChildElementsToSearchPerNode != null)
            {
                uIAGlobalTextInputIntoElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementmaxChildElementsToSearchPerNode);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGlobalTextInputIntoElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementelementLocalizedControlTypesNotToTraverse);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementvalidateClickablePointWithinElementBoundary != null)
            {
                uIAGlobalTextInputIntoElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementvalidateClickablePointWithinElementBoundary);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            uIAGlobalTextInputIntoElementpropCount++;
            uIAGlobalTextInputIntoElement["Workflow"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementworkflow);
            if (uIAGlobalTextInputIntoElementpropCount > 0)
            {
                callPayload.Body = uIAGlobalTextInputIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementPropertiesAsListResponse> UIAGetElementPropertiesAsList(Expression<Func<int>> uIAGetElementPropertiesAsListelementHandle, Expression<Func<string>> uIAGetElementPropertiesAsListworkflow)
        {
            var apiCallPath = "/UIAControl/UIAGetElementPropertiesAsList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetElementPropertiesAsList = new JObject();
            var uIAGetElementPropertiesAsListpropCount = 0;
            uIAGetElementPropertiesAsListpropCount++;
            uIAGetElementPropertiesAsList["ElementHandle"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesAsListelementHandle);
            uIAGetElementPropertiesAsListpropCount++;
            uIAGetElementPropertiesAsList["Workflow"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesAsListworkflow);
            if (uIAGetElementPropertiesAsListpropCount > 0)
            {
                callPayload.Body = uIAGetElementPropertiesAsList;
            }

            return new ApiConnectionAction<UIAGetElementPropertiesAsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIASetTransactionTimeout(Expression<Func<double>> uIASetTransactionTimeouttimeoutInSeconds, Expression<Func<string>> uIASetTransactionTimeoutworkflow)
        {
            var apiCallPath = "/UIAControl/UIASetTransactionTimeout";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIASetTransactionTimeout = new JObject();
            var uIASetTransactionTimeoutpropCount = 0;
            uIASetTransactionTimeoutpropCount++;
            uIASetTransactionTimeout["TimeoutInSeconds"] = ExpressionConverter.ConvertO(uIASetTransactionTimeouttimeoutInSeconds);
            uIASetTransactionTimeoutpropCount++;
            uIASetTransactionTimeout["Workflow"] = ExpressionConverter.ConvertO(uIASetTransactionTimeoutworkflow);
            if (uIASetTransactionTimeoutpropCount > 0)
            {
                callPayload.Body = uIASetTransactionTimeout;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementAtCoordinatesResponse> UIAGetElementAtCoordinates(Expression<Func<string>> uIAGetElementAtCoordinatesworkflow, Expression<Func<int>> uIAGetElementAtCoordinatesxCoord = null, Expression<Func<int>> uIAGetElementAtCoordinatesyCoord = null, Expression<Func<bool>> uIAGetElementAtCoordinatesraiseExceptionIfElementNotFound = null)
        {
            var apiCallPath = "/UIAControl/UIAGetElementAtCoordinates";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetElementAtCoordinates = new JObject();
            var uIAGetElementAtCoordinatespropCount = 0;
            if (uIAGetElementAtCoordinatesxCoord != null)
            {
                uIAGetElementAtCoordinates["XCoord"] = ExpressionConverter.ConvertO(uIAGetElementAtCoordinatesxCoord);
                uIAGetElementAtCoordinatespropCount++;
            }

            if (uIAGetElementAtCoordinatesyCoord != null)
            {
                uIAGetElementAtCoordinates["YCoord"] = ExpressionConverter.ConvertO(uIAGetElementAtCoordinatesyCoord);
                uIAGetElementAtCoordinatespropCount++;
            }

            if (uIAGetElementAtCoordinatesraiseExceptionIfElementNotFound != null)
            {
                uIAGetElementAtCoordinates["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(uIAGetElementAtCoordinatesraiseExceptionIfElementNotFound);
                uIAGetElementAtCoordinatespropCount++;
            }

            uIAGetElementAtCoordinatespropCount++;
            uIAGetElementAtCoordinates["Workflow"] = ExpressionConverter.ConvertO(uIAGetElementAtCoordinatesworkflow);
            if (uIAGetElementAtCoordinatespropCount > 0)
            {
                callPayload.Body = uIAGetElementAtCoordinates;
            }

            return new ApiConnectionAction<UIAGetElementAtCoordinatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetMultipleParentElementPropertiesResponse> UIAGetMultipleParentElementProperties(Expression<Func<int>> uIAGetMultipleParentElementPropertieselementHandle, Expression<Func<string>> uIAGetMultipleParentElementPropertiesworkflow, Expression<Func<int>> uIAGetMultipleParentElementPropertiesmaxParentsToProcess = null)
        {
            var apiCallPath = "/UIAControl/UIAGetMultipleParentElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetMultipleParentElementProperties = new JObject();
            var uIAGetMultipleParentElementPropertiespropCount = 0;
            uIAGetMultipleParentElementPropertiespropCount++;
            uIAGetMultipleParentElementProperties["ElementHandle"] = ExpressionConverter.ConvertO(uIAGetMultipleParentElementPropertieselementHandle);
            if (uIAGetMultipleParentElementPropertiesmaxParentsToProcess != null)
            {
                uIAGetMultipleParentElementProperties["MaxParentsToProcess"] = ExpressionConverter.ConvertO(uIAGetMultipleParentElementPropertiesmaxParentsToProcess);
                uIAGetMultipleParentElementPropertiespropCount++;
            }

            uIAGetMultipleParentElementPropertiespropCount++;
            uIAGetMultipleParentElementProperties["Workflow"] = ExpressionConverter.ConvertO(uIAGetMultipleParentElementPropertiesworkflow);
            if (uIAGetMultipleParentElementPropertiespropCount > 0)
            {
                callPayload.Body = uIAGetMultipleParentElementProperties;
            }

            return new ApiConnectionAction<UIAGetMultipleParentElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIASearchForFirstParentElementResponse> UIASearchForFirstParentElement(Expression<Func<int>> uIASearchForFirstParentElementelementHandle, Expression<Func<string>> uIASearchForFirstParentElementworkflow, Expression<Func<string>> uIASearchForFirstParentElementsearchParentLocalizedControlType = null, Expression<Func<int>> uIASearchForFirstParentElementsearchParentControlType = null, Expression<Func<int>> uIASearchForFirstParentElementmaxParentsToProcess = null, Expression<Func<bool>> uIASearchForFirstParentElementraiseExceptionIfParentElementNotFound = null)
        {
            var apiCallPath = "/UIAControl/UIASearchForFirstParentElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIASearchForFirstParentElement = new JObject();
            var uIASearchForFirstParentElementpropCount = 0;
            uIASearchForFirstParentElementpropCount++;
            uIASearchForFirstParentElement["ElementHandle"] = ExpressionConverter.ConvertO(uIASearchForFirstParentElementelementHandle);
            if (uIASearchForFirstParentElementsearchParentLocalizedControlType != null)
            {
                uIASearchForFirstParentElement["SearchParentLocalizedControlType"] = ExpressionConverter.ConvertO(uIASearchForFirstParentElementsearchParentLocalizedControlType);
                uIASearchForFirstParentElementpropCount++;
            }

            if (uIASearchForFirstParentElementsearchParentControlType != null)
            {
                uIASearchForFirstParentElement["SearchParentControlType"] = ExpressionConverter.ConvertO(uIASearchForFirstParentElementsearchParentControlType);
                uIASearchForFirstParentElementpropCount++;
            }

            if (uIASearchForFirstParentElementmaxParentsToProcess != null)
            {
                uIASearchForFirstParentElement["MaxParentsToProcess"] = ExpressionConverter.ConvertO(uIASearchForFirstParentElementmaxParentsToProcess);
                uIASearchForFirstParentElementpropCount++;
            }

            if (uIASearchForFirstParentElementraiseExceptionIfParentElementNotFound != null)
            {
                uIASearchForFirstParentElement["RaiseExceptionIfParentElementNotFound"] = ExpressionConverter.ConvertO(uIASearchForFirstParentElementraiseExceptionIfParentElementNotFound);
                uIASearchForFirstParentElementpropCount++;
            }

            uIASearchForFirstParentElementpropCount++;
            uIASearchForFirstParentElement["Workflow"] = ExpressionConverter.ConvertO(uIASearchForFirstParentElementworkflow);
            if (uIASearchForFirstParentElementpropCount > 0)
            {
                callPayload.Body = uIASearchForFirstParentElement;
            }

            return new ApiConnectionAction<UIASearchForFirstParentElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetMultipleElementsAsTableResponse> UIAGetMultipleElementsAsTable(Expression<Func<string>> uIAGetMultipleElementsAsTableworkflow, Expression<Func<int>> uIAGetMultipleElementsAsTableparentWindowHandle = null, Expression<Func<string>> uIAGetMultipleElementsAsTablesearchElementName = null, Expression<Func<string>> uIAGetMultipleElementsAsTablesearchElementClassName = null, Expression<Func<string>> uIAGetMultipleElementsAsTablesearchElementAutomationId = null, Expression<Func<string>> uIAGetMultipleElementsAsTablesearchLocalizedControlType = null, Expression<Func<bool>> uIAGetMultipleElementsAsTablesearchSubTree = null, Expression<Func<int>> uIAGetMultipleElementsAsTablematchIndex = null, Expression<Func<string>> uIAGetMultipleElementsAsTablesearchFilter = null, Expression<Func<string>> uIAGetMultipleElementsAsTablesortByColumn = null, Expression<Func<bool>> uIAGetMultipleElementsAsTablematchIndexAscending = null, Expression<Func<string>> uIAGetMultipleElementsAsTablesearchCellHeaderSubElementLocalizedControlType = null, Expression<Func<int>> uIAGetMultipleElementsAsTablesearchCellHeaderSubElementControlType = null, Expression<Func<string>> uIAGetMultipleElementsAsTablesearchCellSubElementLocalizedControlType = null, Expression<Func<int>> uIAGetMultipleElementsAsTablesearchCellSubElementControlType = null, Expression<Func<bool>> uIAGetMultipleElementsAsTablesearchDescendantsForCellSubElements = null, Expression<Func<int>> uIAGetMultipleElementsAsTablefirstCellHeaderSubElementToReturn = null, Expression<Func<int>> uIAGetMultipleElementsAsTablemaxCellHeaderSubElementsToReturn = null, Expression<Func<int>> uIAGetMultipleElementsAsTablefirstCellSubElementToReturn = null, Expression<Func<int>> uIAGetMultipleElementsAsTablemaxCellSubElementsToReturn = null, Expression<Func<int>> uIAGetMultipleElementsAsTablerequestedNumberOfColumns = null, Expression<Func<int>> uIAGetMultipleElementsAsTablecellSubElementValuePriority = null, Expression<Func<int>> uIAGetMultipleElementsAsTablecellSubElementTextValuePriority = null, Expression<Func<int>> uIAGetMultipleElementsAsTablecellSubElementNameValuePriority = null, Expression<Func<int>> uIAGetMultipleElementsAsTableminimumCellSubElementWidth = null, Expression<Func<int>> uIAGetMultipleElementsAsTableminimumCellSubElementHeight = null, Expression<Func<int>> uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxLeft = null, Expression<Func<int>> uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxRight = null, Expression<Func<int>> uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxTop = null, Expression<Func<int>> uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxBottom = null, Expression<Func<bool>> uIAGetMultipleElementsAsTablereadTableAsThread = null, Expression<Func<int>> uIAGetMultipleElementsAsTableretrieveOutputDataFromThreadId = null, Expression<Func<int>> uIAGetMultipleElementsAsTablesecondsToWaitForThread = null, Expression<Func<int>> uIAGetMultipleElementsAsTablemaxElementsToSearch = null, Expression<Func<int>> uIAGetMultipleElementsAsTablemaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetMultipleElementsAsTablemaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetMultipleElementsAsTableelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/UIAGetMultipleElementsAsTable";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetMultipleElementsAsTable = new JObject();
            var uIAGetMultipleElementsAsTablepropCount = 0;
            if (uIAGetMultipleElementsAsTableparentWindowHandle != null)
            {
                uIAGetMultipleElementsAsTable["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableparentWindowHandle);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchElementName != null)
            {
                uIAGetMultipleElementsAsTable["SearchElementName"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesearchElementName);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchElementClassName != null)
            {
                uIAGetMultipleElementsAsTable["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesearchElementClassName);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchElementAutomationId != null)
            {
                uIAGetMultipleElementsAsTable["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesearchElementAutomationId);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchLocalizedControlType != null)
            {
                uIAGetMultipleElementsAsTable["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesearchLocalizedControlType);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchSubTree != null)
            {
                uIAGetMultipleElementsAsTable["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesearchSubTree);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablematchIndex != null)
            {
                uIAGetMultipleElementsAsTable["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablematchIndex);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchFilter != null)
            {
                uIAGetMultipleElementsAsTable["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesearchFilter);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesortByColumn != null)
            {
                uIAGetMultipleElementsAsTable["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesortByColumn);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablematchIndexAscending != null)
            {
                uIAGetMultipleElementsAsTable["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablematchIndexAscending);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchCellHeaderSubElementLocalizedControlType != null)
            {
                uIAGetMultipleElementsAsTable["SearchCellHeaderSubElementLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesearchCellHeaderSubElementLocalizedControlType);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchCellHeaderSubElementControlType != null)
            {
                uIAGetMultipleElementsAsTable["SearchCellHeaderSubElementControlType"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesearchCellHeaderSubElementControlType);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchCellSubElementLocalizedControlType != null)
            {
                uIAGetMultipleElementsAsTable["SearchCellSubElementLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesearchCellSubElementLocalizedControlType);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchCellSubElementControlType != null)
            {
                uIAGetMultipleElementsAsTable["SearchCellSubElementControlType"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesearchCellSubElementControlType);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchDescendantsForCellSubElements != null)
            {
                uIAGetMultipleElementsAsTable["SearchDescendantsForCellSubElements"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesearchDescendantsForCellSubElements);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablefirstCellHeaderSubElementToReturn != null)
            {
                uIAGetMultipleElementsAsTable["FirstCellHeaderSubElementToReturn"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablefirstCellHeaderSubElementToReturn);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablemaxCellHeaderSubElementsToReturn != null)
            {
                uIAGetMultipleElementsAsTable["MaxCellHeaderSubElementsToReturn"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablemaxCellHeaderSubElementsToReturn);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablefirstCellSubElementToReturn != null)
            {
                uIAGetMultipleElementsAsTable["FirstCellSubElementToReturn"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablefirstCellSubElementToReturn);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablemaxCellSubElementsToReturn != null)
            {
                uIAGetMultipleElementsAsTable["MaxCellSubElementsToReturn"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablemaxCellSubElementsToReturn);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablerequestedNumberOfColumns != null)
            {
                uIAGetMultipleElementsAsTable["RequestedNumberOfColumns"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablerequestedNumberOfColumns);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablecellSubElementValuePriority != null)
            {
                uIAGetMultipleElementsAsTable["CellSubElementValuePriority"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablecellSubElementValuePriority);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablecellSubElementTextValuePriority != null)
            {
                uIAGetMultipleElementsAsTable["CellSubElementTextValuePriority"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablecellSubElementTextValuePriority);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablecellSubElementNameValuePriority != null)
            {
                uIAGetMultipleElementsAsTable["CellSubElementNameValuePriority"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablecellSubElementNameValuePriority);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableminimumCellSubElementWidth != null)
            {
                uIAGetMultipleElementsAsTable["MinimumCellSubElementWidth"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableminimumCellSubElementWidth);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableminimumCellSubElementHeight != null)
            {
                uIAGetMultipleElementsAsTable["MinimumCellSubElementHeight"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableminimumCellSubElementHeight);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxLeft != null)
            {
                uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxLeft);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxRight != null)
            {
                uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxRight"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxRight);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxTop != null)
            {
                uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxTop"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxTop);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxBottom != null)
            {
                uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxBottom);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablereadTableAsThread != null)
            {
                uIAGetMultipleElementsAsTable["ReadTableAsThread"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablereadTableAsThread);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableretrieveOutputDataFromThreadId != null)
            {
                uIAGetMultipleElementsAsTable["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableretrieveOutputDataFromThreadId);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesecondsToWaitForThread != null)
            {
                uIAGetMultipleElementsAsTable["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesecondsToWaitForThread);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablemaxElementsToSearch != null)
            {
                uIAGetMultipleElementsAsTable["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablemaxElementsToSearch);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablemaxRelativeSearchDepth != null)
            {
                uIAGetMultipleElementsAsTable["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablemaxRelativeSearchDepth);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablemaxChildElementsToSearchPerNode != null)
            {
                uIAGetMultipleElementsAsTable["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablemaxChildElementsToSearchPerNode);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetMultipleElementsAsTable["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableelementLocalizedControlTypesNotToTraverse);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            uIAGetMultipleElementsAsTablepropCount++;
            uIAGetMultipleElementsAsTable["Workflow"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableworkflow);
            if (uIAGetMultipleElementsAsTablepropCount > 0)
            {
                callPayload.Body = uIAGetMultipleElementsAsTable;
            }

            return new ApiConnectionAction<UIAGetMultipleElementsAsTableResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIASetElementScrollPercentageResponse> UIASetElementScrollPercentage(Expression<Func<int>> uIASetElementScrollPercentageparentWindowHandle, Expression<Func<string>> uIASetElementScrollPercentageworkflow, Expression<Func<string>> uIASetElementScrollPercentagesearchElementName = null, Expression<Func<string>> uIASetElementScrollPercentagesearchElementClassName = null, Expression<Func<string>> uIASetElementScrollPercentagesearchElementAutomationId = null, Expression<Func<string>> uIASetElementScrollPercentagesearchLocalizedControlType = null, Expression<Func<bool>> uIASetElementScrollPercentagesearchSubTree = null, Expression<Func<int>> uIASetElementScrollPercentagematchIndex = null, Expression<Func<string>> uIASetElementScrollPercentagesearchFilter = null, Expression<Func<string>> uIASetElementScrollPercentagesortByColumn = null, Expression<Func<bool>> uIASetElementScrollPercentagematchIndexAscending = null, Expression<Func<double>> uIASetElementScrollPercentagehorizontalScrollPercentage = null, Expression<Func<double>> uIASetElementScrollPercentageverticalScrollPercentage = null, Expression<Func<bool>> uIASetElementScrollPercentagetryScrollPattern = null, Expression<Func<bool>> uIASetElementScrollPercentagetryRangeValuePattern = null, Expression<Func<bool>> uIASetElementScrollPercentagetryValuePattern = null, Expression<Func<int>> uIASetElementScrollPercentagemaxElementsToSearch = null, Expression<Func<int>> uIASetElementScrollPercentagemaxRelativeSearchDepth = null, Expression<Func<int>> uIASetElementScrollPercentagemaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIASetElementScrollPercentageelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/UIASetElementScrollPercentage";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIASetElementScrollPercentage = new JObject();
            var uIASetElementScrollPercentagepropCount = 0;
            uIASetElementScrollPercentagepropCount++;
            uIASetElementScrollPercentage["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageparentWindowHandle);
            if (uIASetElementScrollPercentagesearchElementName != null)
            {
                uIASetElementScrollPercentage["SearchElementName"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagesearchElementName);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagesearchElementClassName != null)
            {
                uIASetElementScrollPercentage["SearchElementClassName"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagesearchElementClassName);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagesearchElementAutomationId != null)
            {
                uIASetElementScrollPercentage["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagesearchElementAutomationId);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagesearchLocalizedControlType != null)
            {
                uIASetElementScrollPercentage["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagesearchLocalizedControlType);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagesearchSubTree != null)
            {
                uIASetElementScrollPercentage["SearchSubTree"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagesearchSubTree);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagematchIndex != null)
            {
                uIASetElementScrollPercentage["MatchIndex"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagematchIndex);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagesearchFilter != null)
            {
                uIASetElementScrollPercentage["SearchFilter"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagesearchFilter);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagesortByColumn != null)
            {
                uIASetElementScrollPercentage["SortByColumn"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagesortByColumn);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagematchIndexAscending != null)
            {
                uIASetElementScrollPercentage["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagematchIndexAscending);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagehorizontalScrollPercentage != null)
            {
                uIASetElementScrollPercentage["HorizontalScrollPercentage"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagehorizontalScrollPercentage);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentageverticalScrollPercentage != null)
            {
                uIASetElementScrollPercentage["VerticalScrollPercentage"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageverticalScrollPercentage);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagetryScrollPattern != null)
            {
                uIASetElementScrollPercentage["TryScrollPattern"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagetryScrollPattern);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagetryRangeValuePattern != null)
            {
                uIASetElementScrollPercentage["TryRangeValuePattern"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagetryRangeValuePattern);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagetryValuePattern != null)
            {
                uIASetElementScrollPercentage["TryValuePattern"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagetryValuePattern);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagemaxElementsToSearch != null)
            {
                uIASetElementScrollPercentage["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagemaxElementsToSearch);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagemaxRelativeSearchDepth != null)
            {
                uIASetElementScrollPercentage["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagemaxRelativeSearchDepth);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagemaxChildElementsToSearchPerNode != null)
            {
                uIASetElementScrollPercentage["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagemaxChildElementsToSearchPerNode);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentageelementLocalizedControlTypesNotToTraverse != null)
            {
                uIASetElementScrollPercentage["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageelementLocalizedControlTypesNotToTraverse);
                uIASetElementScrollPercentagepropCount++;
            }

            uIASetElementScrollPercentagepropCount++;
            uIASetElementScrollPercentage["Workflow"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageworkflow);
            if (uIASetElementScrollPercentagepropCount > 0)
            {
                callPayload.Body = uIASetElementScrollPercentage;
            }

            return new ApiConnectionAction<UIASetElementScrollPercentageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementSearchColourRegionResponse> UIAGetElementSearchColourRegion(Expression<Func<int>> uIAGetElementSearchColourRegionparentWindowHandle, Expression<Func<string>> uIAGetElementSearchColourRegionsearchColour, Expression<Func<int>> uIAGetElementSearchColourRegionmaxColourDeviation, Expression<Func<string>> uIAGetElementSearchColourRegionworkflow, Expression<Func<string>> uIAGetElementSearchColourRegionsearchElementName = null, Expression<Func<string>> uIAGetElementSearchColourRegionsearchElementClassName = null, Expression<Func<string>> uIAGetElementSearchColourRegionsearchElementAutomationId = null, Expression<Func<string>> uIAGetElementSearchColourRegionsearchLocalizedControlType = null, Expression<Func<bool>> uIAGetElementSearchColourRegionsearchSubTree = null, Expression<Func<int>> uIAGetElementSearchColourRegionmatchIndex = null, Expression<Func<string>> uIAGetElementSearchColourRegionsearchFilter = null, Expression<Func<string>> uIAGetElementSearchColourRegionsortByColumn = null, Expression<Func<bool>> uIAGetElementSearchColourRegionmatchIndexAscending = null, Expression<Func<int>> uIAGetElementSearchColourRegionleftPixelXOffset = null, Expression<Func<int>> uIAGetElementSearchColourRegionrightPixelXOffset = null, Expression<Func<int>> uIAGetElementSearchColourRegiontopPixelYOffset = null, Expression<Func<int>> uIAGetElementSearchColourRegionbottomPixelYOffset = null, Expression<Func<bool>> uIAGetElementSearchColourRegionhideAgent = null, Expression<Func<bool>> uIAGetElementSearchColourRegionreturnPhysicalCoordinates = null, Expression<Func<int>> uIAGetElementSearchColourRegionmaxElementsToSearch = null, Expression<Func<int>> uIAGetElementSearchColourRegionmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetElementSearchColourRegionmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetElementSearchColourRegionelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/UIAGetElementSearchColourRegion";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetElementSearchColourRegion = new JObject();
            var uIAGetElementSearchColourRegionpropCount = 0;
            uIAGetElementSearchColourRegionpropCount++;
            uIAGetElementSearchColourRegion["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionparentWindowHandle);
            if (uIAGetElementSearchColourRegionsearchElementName != null)
            {
                uIAGetElementSearchColourRegion["SearchElementName"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionsearchElementName);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionsearchElementClassName != null)
            {
                uIAGetElementSearchColourRegion["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionsearchElementClassName);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionsearchElementAutomationId != null)
            {
                uIAGetElementSearchColourRegion["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionsearchElementAutomationId);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionsearchLocalizedControlType != null)
            {
                uIAGetElementSearchColourRegion["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionsearchLocalizedControlType);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionsearchSubTree != null)
            {
                uIAGetElementSearchColourRegion["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionsearchSubTree);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionmatchIndex != null)
            {
                uIAGetElementSearchColourRegion["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionmatchIndex);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionsearchFilter != null)
            {
                uIAGetElementSearchColourRegion["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionsearchFilter);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionsortByColumn != null)
            {
                uIAGetElementSearchColourRegion["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionsortByColumn);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionmatchIndexAscending != null)
            {
                uIAGetElementSearchColourRegion["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionmatchIndexAscending);
                uIAGetElementSearchColourRegionpropCount++;
            }

            uIAGetElementSearchColourRegionpropCount++;
            uIAGetElementSearchColourRegion["SearchColour"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionsearchColour);
            uIAGetElementSearchColourRegionpropCount++;
            uIAGetElementSearchColourRegion["MaxColourDeviation"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionmaxColourDeviation);
            if (uIAGetElementSearchColourRegionleftPixelXOffset != null)
            {
                uIAGetElementSearchColourRegion["LeftPixelXOffset"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionleftPixelXOffset);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionrightPixelXOffset != null)
            {
                uIAGetElementSearchColourRegion["RightPixelXOffset"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionrightPixelXOffset);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegiontopPixelYOffset != null)
            {
                uIAGetElementSearchColourRegion["TopPixelYOffset"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegiontopPixelYOffset);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionbottomPixelYOffset != null)
            {
                uIAGetElementSearchColourRegion["BottomPixelYOffset"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionbottomPixelYOffset);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionhideAgent != null)
            {
                uIAGetElementSearchColourRegion["HideAgent"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionhideAgent);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionreturnPhysicalCoordinates != null)
            {
                uIAGetElementSearchColourRegion["ReturnPhysicalCoordinates"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionreturnPhysicalCoordinates);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionmaxElementsToSearch != null)
            {
                uIAGetElementSearchColourRegion["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionmaxElementsToSearch);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionmaxRelativeSearchDepth != null)
            {
                uIAGetElementSearchColourRegion["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionmaxRelativeSearchDepth);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionmaxChildElementsToSearchPerNode != null)
            {
                uIAGetElementSearchColourRegion["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionmaxChildElementsToSearchPerNode);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetElementSearchColourRegion["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionelementLocalizedControlTypesNotToTraverse);
                uIAGetElementSearchColourRegionpropCount++;
            }

            uIAGetElementSearchColourRegionpropCount++;
            uIAGetElementSearchColourRegion["Workflow"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionworkflow);
            if (uIAGetElementSearchColourRegionpropCount > 0)
            {
                callPayload.Body = uIAGetElementSearchColourRegion;
            }

            return new ApiConnectionAction<UIAGetElementSearchColourRegionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGlobalMouseClickElementSearchColourRegionResponse> UIAGlobalMouseClickElementSearchColourRegion(Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionparentWindowHandle, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionsearchColour, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionmaxColourDeviation, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionworkflow, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionsearchElementName = null, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionsearchElementClassName = null, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionsearchElementAutomationId = null, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionsearchLocalizedControlType = null, Expression<Func<bool>> uIAGlobalMouseClickElementSearchColourRegionsearchSubTree = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionmatchIndex = null, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionsearchFilter = null, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionsortByColumn = null, Expression<Func<bool>> uIAGlobalMouseClickElementSearchColourRegionmatchIndexAscending = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionleftPixelXOffset = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionrightPixelXOffset = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegiontopPixelYOffset = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionbottomPixelYOffset = null, Expression<Func<uIAGlobalMouseClickElementSearchColourRegionmouseButtonInput>> uIAGlobalMouseClickElementSearchColourRegionmouseButton = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionclickOffsetX = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionclickOffsetY = null, Expression<Func<uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeToInput>> uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeTo = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegiondelayInMilliseconds = null, Expression<Func<bool>> uIAGlobalMouseClickElementSearchColourRegionhideAgent = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionmaxElementsToSearch = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionelementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/UIAGlobalMouseClickElementSearchColourRegion";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGlobalMouseClickElementSearchColourRegion = new JObject();
            var uIAGlobalMouseClickElementSearchColourRegionpropCount = 0;
            uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            uIAGlobalMouseClickElementSearchColourRegion["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionparentWindowHandle);
            if (uIAGlobalMouseClickElementSearchColourRegionsearchElementName != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["SearchElementName"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionsearchElementName);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionsearchElementClassName != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionsearchElementClassName);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionsearchElementAutomationId != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionsearchElementAutomationId);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionsearchLocalizedControlType != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionsearchLocalizedControlType);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionsearchSubTree != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionsearchSubTree);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionmatchIndex != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["MatchIndex"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionmatchIndex);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionsearchFilter != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["SearchFilter"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionsearchFilter);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionsortByColumn != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["SortByColumn"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionsortByColumn);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionmatchIndexAscending != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionmatchIndexAscending);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            uIAGlobalMouseClickElementSearchColourRegion["SearchColour"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionsearchColour);
            uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            uIAGlobalMouseClickElementSearchColourRegion["MaxColourDeviation"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionmaxColourDeviation);
            if (uIAGlobalMouseClickElementSearchColourRegionleftPixelXOffset != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["LeftPixelXOffset"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionleftPixelXOffset);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionrightPixelXOffset != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["RightPixelXOffset"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionrightPixelXOffset);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegiontopPixelYOffset != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["TopPixelYOffset"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegiontopPixelYOffset);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionbottomPixelYOffset != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["BottomPixelYOffset"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionbottomPixelYOffset);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionmouseButton != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["MouseButton"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionmouseButton);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionclickOffsetX != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["ClickOffsetX"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionclickOffsetX);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionclickOffsetY != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["ClickOffsetY"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionclickOffsetY);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeTo != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["OffsetRelativeTo"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeTo);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegiondelayInMilliseconds != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["DelayInMilliseconds"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegiondelayInMilliseconds);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionhideAgent != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["HideAgent"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionhideAgent);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionmaxElementsToSearch != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionmaxElementsToSearch);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionmaxRelativeSearchDepth != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionmaxRelativeSearchDepth);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionmaxChildElementsToSearchPerNode != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionmaxChildElementsToSearchPerNode);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionelementLocalizedControlTypesNotToTraverse);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            uIAGlobalMouseClickElementSearchColourRegion["Workflow"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionworkflow);
            if (uIAGlobalMouseClickElementSearchColourRegionpropCount > 0)
            {
                callPayload.Body = uIAGlobalMouseClickElementSearchColourRegion;
            }

            return new ApiConnectionAction<UIAGlobalMouseClickElementSearchColourRegionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetWin32WindowsResponse> UIAGetWin32Windows(Expression<Func<string>> uIAGetWin32Windowsworkflow, Expression<Func<string>> uIAGetWin32WindowssearchClassName = null, Expression<Func<string>> uIAGetWin32WindowssearchWindowTitle = null, Expression<Func<bool>> uIAGetWin32WindowstopLevelWindowsOnly = null, Expression<Func<bool>> uIAGetWin32WindowsvisibleWindowsOnly = null, Expression<Func<bool>> uIAGetWin32WindowswindowsWithTitlebarOnly = null, Expression<Func<bool>> uIAGetWin32WindowswindowsWithTitleOnly = null, Expression<Func<bool>> uIAGetWin32WindowsignoreTransparentWindows = null, Expression<Func<int>> uIAGetWin32WindowssearchProcessId = null, Expression<Func<string>> uIAGetWin32WindowssearchFilter = null, Expression<Func<string>> uIAGetWin32WindowssortByColumn = null, Expression<Func<bool>> uIAGetWin32WindowsmatchIndexAscending = null, Expression<Func<bool>> uIAGetWin32WindowsreturnElementHandle = null, Expression<Func<int>> uIAGetWin32WindowsfirstItemToReturn = null, Expression<Func<int>> uIAGetWin32WindowsmaxItemsToReturn = null)
        {
            var apiCallPath = "/UIAControl/GetWin32Windows";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetWin32Windows = new JObject();
            var uIAGetWin32WindowspropCount = 0;
            if (uIAGetWin32WindowssearchClassName != null)
            {
                uIAGetWin32Windows["SearchClassName"] = ExpressionConverter.ConvertO(uIAGetWin32WindowssearchClassName);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowssearchWindowTitle != null)
            {
                uIAGetWin32Windows["SearchWindowTitle"] = ExpressionConverter.ConvertO(uIAGetWin32WindowssearchWindowTitle);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowstopLevelWindowsOnly != null)
            {
                uIAGetWin32Windows["TopLevelWindowsOnly"] = ExpressionConverter.ConvertO(uIAGetWin32WindowstopLevelWindowsOnly);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsvisibleWindowsOnly != null)
            {
                uIAGetWin32Windows["VisibleWindowsOnly"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsvisibleWindowsOnly);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowswindowsWithTitlebarOnly != null)
            {
                uIAGetWin32Windows["WindowsWithTitlebarOnly"] = ExpressionConverter.ConvertO(uIAGetWin32WindowswindowsWithTitlebarOnly);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowswindowsWithTitleOnly != null)
            {
                uIAGetWin32Windows["WindowsWithTitleOnly"] = ExpressionConverter.ConvertO(uIAGetWin32WindowswindowsWithTitleOnly);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsignoreTransparentWindows != null)
            {
                uIAGetWin32Windows["IgnoreTransparentWindows"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsignoreTransparentWindows);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowssearchProcessId != null)
            {
                uIAGetWin32Windows["SearchProcessId"] = ExpressionConverter.ConvertO(uIAGetWin32WindowssearchProcessId);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowssearchFilter != null)
            {
                uIAGetWin32Windows["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetWin32WindowssearchFilter);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowssortByColumn != null)
            {
                uIAGetWin32Windows["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetWin32WindowssortByColumn);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsmatchIndexAscending != null)
            {
                uIAGetWin32Windows["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsmatchIndexAscending);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsreturnElementHandle != null)
            {
                uIAGetWin32Windows["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsreturnElementHandle);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsfirstItemToReturn != null)
            {
                uIAGetWin32Windows["FirstItemToReturn"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsfirstItemToReturn);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsmaxItemsToReturn != null)
            {
                uIAGetWin32Windows["MaxItemsToReturn"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsmaxItemsToReturn);
                uIAGetWin32WindowspropCount++;
            }

            uIAGetWin32WindowspropCount++;
            uIAGetWin32Windows["Workflow"] = ExpressionConverter.ConvertO(uIAGetWin32Windowsworkflow);
            if (uIAGetWin32WindowspropCount > 0)
            {
                callPayload.Body = uIAGetWin32Windows;
            }

            return new ApiConnectionAction<UIAGetWin32WindowsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<SetUIAElementSearchModeResponse> SetUIAElementSearchMode(Expression<Func<setUIAElementSearchModeuIAElementSearchModeInput>> setUIAElementSearchModeuIAElementSearchMode, Expression<Func<string>> setUIAElementSearchModeworkflow)
        {
            var apiCallPath = "/UIAControl/SetUIAElementSearchMode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var setUIAElementSearchMode = new JObject();
            var setUIAElementSearchModepropCount = 0;
            setUIAElementSearchModepropCount++;
            setUIAElementSearchMode["UIAElementSearchMode"] = ExpressionConverter.ConvertO(setUIAElementSearchModeuIAElementSearchMode);
            setUIAElementSearchModepropCount++;
            setUIAElementSearchMode["Workflow"] = ExpressionConverter.ConvertO(setUIAElementSearchModeworkflow);
            if (setUIAElementSearchModepropCount > 0)
            {
                callPayload.Body = setUIAElementSearchMode;
            }

            return new ApiConnectionAction<SetUIAElementSearchModeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<GetUIAElementSearchModeResponse> GetUIAElementSearchMode(Expression<Func<string>> getUIAElementSearchModeworkflow)
        {
            var apiCallPath = "/UIAControl/GetUIAElementSearchMode";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var getUIAElementSearchMode = new JObject();
            var getUIAElementSearchModepropCount = 0;
            getUIAElementSearchModepropCount++;
            getUIAElementSearchMode["Workflow"] = ExpressionConverter.ConvertO(getUIAElementSearchModeworkflow);
            if (getUIAElementSearchModepropCount > 0)
            {
                callPayload.Body = getUIAElementSearchMode;
            }

            return new ApiConnectionAction<GetUIAElementSearchModeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementPatternsResponse> UIAGetElementPatterns(Expression<Func<int>> uIAGetElementPatternsparentWindowHandle, Expression<Func<string>> uIAGetElementPatternsworkflow, Expression<Func<string>> uIAGetElementPatternssearchElementName = null, Expression<Func<string>> uIAGetElementPatternssearchElementClassName = null, Expression<Func<string>> uIAGetElementPatternssearchElementAutomationId = null, Expression<Func<string>> uIAGetElementPatternssearchLocalizedControlType = null, Expression<Func<bool>> uIAGetElementPatternssearchSubTree = null, Expression<Func<int>> uIAGetElementPatternsmatchIndex = null, Expression<Func<string>> uIAGetElementPatternssearchFilter = null, Expression<Func<string>> uIAGetElementPatternssortByColumn = null, Expression<Func<bool>> uIAGetElementPatternsmatchIndexAscending = null, Expression<Func<int>> uIAGetElementPatternsmaxElementsToSearch = null, Expression<Func<int>> uIAGetElementPatternsmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetElementPatternsmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetElementPatternselementLocalizedControlTypesNotToTraverse = null)
        {
            var apiCallPath = "/UIAControl/UIAGetElementPatterns";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAGetElementPatterns = new JObject();
            var uIAGetElementPatternspropCount = 0;
            uIAGetElementPatternspropCount++;
            uIAGetElementPatterns["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAGetElementPatternsparentWindowHandle);
            if (uIAGetElementPatternssearchElementName != null)
            {
                uIAGetElementPatterns["SearchElementName"] = ExpressionConverter.ConvertO(uIAGetElementPatternssearchElementName);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternssearchElementClassName != null)
            {
                uIAGetElementPatterns["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAGetElementPatternssearchElementClassName);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternssearchElementAutomationId != null)
            {
                uIAGetElementPatterns["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAGetElementPatternssearchElementAutomationId);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternssearchLocalizedControlType != null)
            {
                uIAGetElementPatterns["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAGetElementPatternssearchLocalizedControlType);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternssearchSubTree != null)
            {
                uIAGetElementPatterns["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetElementPatternssearchSubTree);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternsmatchIndex != null)
            {
                uIAGetElementPatterns["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetElementPatternsmatchIndex);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternssearchFilter != null)
            {
                uIAGetElementPatterns["SearchFilter"] = ExpressionConverter.ConvertO(uIAGetElementPatternssearchFilter);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternssortByColumn != null)
            {
                uIAGetElementPatterns["SortByColumn"] = ExpressionConverter.ConvertO(uIAGetElementPatternssortByColumn);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternsmatchIndexAscending != null)
            {
                uIAGetElementPatterns["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetElementPatternsmatchIndexAscending);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternsmaxElementsToSearch != null)
            {
                uIAGetElementPatterns["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetElementPatternsmaxElementsToSearch);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternsmaxRelativeSearchDepth != null)
            {
                uIAGetElementPatterns["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetElementPatternsmaxRelativeSearchDepth);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternsmaxChildElementsToSearchPerNode != null)
            {
                uIAGetElementPatterns["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetElementPatternsmaxChildElementsToSearchPerNode);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternselementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetElementPatterns["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGetElementPatternselementLocalizedControlTypesNotToTraverse);
                uIAGetElementPatternspropCount++;
            }

            uIAGetElementPatternspropCount++;
            uIAGetElementPatterns["Workflow"] = ExpressionConverter.ConvertO(uIAGetElementPatternsworkflow);
            if (uIAGetElementPatternspropCount > 0)
            {
                callPayload.Body = uIAGetElementPatterns;
            }

            return new ApiConnectionAction<UIAGetElementPatternsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAMoveElementResponse> UIAMoveElement(Expression<Func<int>> uIAMoveElementparentWindowHandle, Expression<Func<int>> uIAMoveElementhorizontalPosition, Expression<Func<int>> uIAMoveElementverticalPosition, Expression<Func<string>> uIAMoveElementworkflow, Expression<Func<string>> uIAMoveElementsearchElementName = null, Expression<Func<string>> uIAMoveElementsearchElementClassName = null, Expression<Func<string>> uIAMoveElementsearchElementAutomationId = null, Expression<Func<string>> uIAMoveElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAMoveElementsearchSubTree = null, Expression<Func<int>> uIAMoveElementmatchIndex = null, Expression<Func<string>> uIAMoveElementsearchFilter = null, Expression<Func<string>> uIAMoveElementsortByColumn = null, Expression<Func<bool>> uIAMoveElementmatchIndexAscending = null, Expression<Func<int>> uIAMoveElementmaxElementsToSearch = null, Expression<Func<int>> uIAMoveElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAMoveElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAMoveElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<uIAMoveElementhorizontalMovementTypeInput>> uIAMoveElementhorizontalMovementType = null, Expression<Func<uIAMoveElementverticalMovementTypeInput>> uIAMoveElementverticalMovementType = null)
        {
            var apiCallPath = "/UIAControl/UIAMoveElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAMoveElement = new JObject();
            var uIAMoveElementpropCount = 0;
            uIAMoveElementpropCount++;
            uIAMoveElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAMoveElementparentWindowHandle);
            if (uIAMoveElementsearchElementName != null)
            {
                uIAMoveElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAMoveElementsearchElementName);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementsearchElementClassName != null)
            {
                uIAMoveElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAMoveElementsearchElementClassName);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementsearchElementAutomationId != null)
            {
                uIAMoveElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAMoveElementsearchElementAutomationId);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementsearchLocalizedControlType != null)
            {
                uIAMoveElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAMoveElementsearchLocalizedControlType);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementsearchSubTree != null)
            {
                uIAMoveElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAMoveElementsearchSubTree);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementmatchIndex != null)
            {
                uIAMoveElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAMoveElementmatchIndex);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementsearchFilter != null)
            {
                uIAMoveElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAMoveElementsearchFilter);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementsortByColumn != null)
            {
                uIAMoveElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAMoveElementsortByColumn);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementmatchIndexAscending != null)
            {
                uIAMoveElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAMoveElementmatchIndexAscending);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementmaxElementsToSearch != null)
            {
                uIAMoveElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAMoveElementmaxElementsToSearch);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementmaxRelativeSearchDepth != null)
            {
                uIAMoveElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAMoveElementmaxRelativeSearchDepth);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementmaxChildElementsToSearchPerNode != null)
            {
                uIAMoveElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAMoveElementmaxChildElementsToSearchPerNode);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAMoveElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAMoveElementelementLocalizedControlTypesNotToTraverse);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementhorizontalMovementType != null)
            {
                uIAMoveElement["HorizontalMovementType"] = ExpressionConverter.ConvertO(uIAMoveElementhorizontalMovementType);
                uIAMoveElementpropCount++;
            }

            uIAMoveElementpropCount++;
            uIAMoveElement["HorizontalPosition"] = ExpressionConverter.ConvertO(uIAMoveElementhorizontalPosition);
            if (uIAMoveElementverticalMovementType != null)
            {
                uIAMoveElement["VerticalMovementType"] = ExpressionConverter.ConvertO(uIAMoveElementverticalMovementType);
                uIAMoveElementpropCount++;
            }

            uIAMoveElementpropCount++;
            uIAMoveElement["VerticalPosition"] = ExpressionConverter.ConvertO(uIAMoveElementverticalPosition);
            uIAMoveElementpropCount++;
            uIAMoveElement["Workflow"] = ExpressionConverter.ConvertO(uIAMoveElementworkflow);
            if (uIAMoveElementpropCount > 0)
            {
                callPayload.Body = uIAMoveElement;
            }

            return new ApiConnectionAction<UIAMoveElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAResizeElementResponse> UIAResizeElement(Expression<Func<int>> uIAResizeElementparentWindowHandle, Expression<Func<int>> uIAResizeElementnewWidth, Expression<Func<int>> uIAResizeElementnewHeight, Expression<Func<string>> uIAResizeElementworkflow, Expression<Func<string>> uIAResizeElementsearchElementName = null, Expression<Func<string>> uIAResizeElementsearchElementClassName = null, Expression<Func<string>> uIAResizeElementsearchElementAutomationId = null, Expression<Func<string>> uIAResizeElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAResizeElementsearchSubTree = null, Expression<Func<int>> uIAResizeElementmatchIndex = null, Expression<Func<string>> uIAResizeElementsearchFilter = null, Expression<Func<string>> uIAResizeElementsortByColumn = null, Expression<Func<bool>> uIAResizeElementmatchIndexAscending = null, Expression<Func<int>> uIAResizeElementmaxElementsToSearch = null, Expression<Func<int>> uIAResizeElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAResizeElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAResizeElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<uIAResizeElementresizeWidthTypeInput>> uIAResizeElementresizeWidthType = null, Expression<Func<uIAResizeElementresizeHeightTypeInput>> uIAResizeElementresizeHeightType = null)
        {
            var apiCallPath = "/UIAControl/UIAResizeElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAResizeElement = new JObject();
            var uIAResizeElementpropCount = 0;
            uIAResizeElementpropCount++;
            uIAResizeElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAResizeElementparentWindowHandle);
            if (uIAResizeElementsearchElementName != null)
            {
                uIAResizeElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAResizeElementsearchElementName);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementsearchElementClassName != null)
            {
                uIAResizeElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAResizeElementsearchElementClassName);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementsearchElementAutomationId != null)
            {
                uIAResizeElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAResizeElementsearchElementAutomationId);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementsearchLocalizedControlType != null)
            {
                uIAResizeElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAResizeElementsearchLocalizedControlType);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementsearchSubTree != null)
            {
                uIAResizeElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAResizeElementsearchSubTree);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementmatchIndex != null)
            {
                uIAResizeElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAResizeElementmatchIndex);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementsearchFilter != null)
            {
                uIAResizeElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAResizeElementsearchFilter);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementsortByColumn != null)
            {
                uIAResizeElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAResizeElementsortByColumn);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementmatchIndexAscending != null)
            {
                uIAResizeElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAResizeElementmatchIndexAscending);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementmaxElementsToSearch != null)
            {
                uIAResizeElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAResizeElementmaxElementsToSearch);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementmaxRelativeSearchDepth != null)
            {
                uIAResizeElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAResizeElementmaxRelativeSearchDepth);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementmaxChildElementsToSearchPerNode != null)
            {
                uIAResizeElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAResizeElementmaxChildElementsToSearchPerNode);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAResizeElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAResizeElementelementLocalizedControlTypesNotToTraverse);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementresizeWidthType != null)
            {
                uIAResizeElement["ResizeWidthType"] = ExpressionConverter.ConvertO(uIAResizeElementresizeWidthType);
                uIAResizeElementpropCount++;
            }

            uIAResizeElementpropCount++;
            uIAResizeElement["NewWidth"] = ExpressionConverter.ConvertO(uIAResizeElementnewWidth);
            if (uIAResizeElementresizeHeightType != null)
            {
                uIAResizeElement["ResizeHeightType"] = ExpressionConverter.ConvertO(uIAResizeElementresizeHeightType);
                uIAResizeElementpropCount++;
            }

            uIAResizeElementpropCount++;
            uIAResizeElement["NewHeight"] = ExpressionConverter.ConvertO(uIAResizeElementnewHeight);
            uIAResizeElementpropCount++;
            uIAResizeElement["Workflow"] = ExpressionConverter.ConvertO(uIAResizeElementworkflow);
            if (uIAResizeElementpropCount > 0)
            {
                callPayload.Body = uIAResizeElement;
            }

            return new ApiConnectionAction<UIAResizeElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIALocateVisibleSearchImageWithinElementResponse> UIALocateVisibleSearchImageWithinElement(Expression<Func<int>> uIALocateVisibleSearchImageWithinElementparentWindowHandle, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementworkflow, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementsearchElementName = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementsearchElementClassName = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementsearchElementAutomationId = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementsearchLocalizedControlType = null, Expression<Func<bool>> uIALocateVisibleSearchImageWithinElementsearchSubTree = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementmatchIndex = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementsearchFilter = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementsortByColumn = null, Expression<Func<bool>> uIALocateVisibleSearchImageWithinElementmatchIndexAscending = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementmaxElementsToSearch = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<uIALocateVisibleSearchImageWithinElementsearchImageTypeInput>> uIALocateVisibleSearchImageWithinElementsearchImageType = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementsearchImage = null, Expression<Func<uIALocateVisibleSearchImageWithinElementaltSearchImageTypeInput>> uIALocateVisibleSearchImageWithinElementaltSearchImageType = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementaltSearchImage = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementmaxColourDeviation = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementmaxPixelDifferences = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementmaxConsecutivePixelDifferences = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementleftPixelXOffset = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementrightPixelXOffset = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementtopPixelYOffset = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementbottomPixelYOffset = null, Expression<Func<uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnitInput>> uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnit = null, Expression<Func<uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnitInput>> uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnit = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementsearchImageIndex = null, Expression<Func<uIALocateVisibleSearchImageWithinElementimageSearchDirectionInput>> uIALocateVisibleSearchImageWithinElementimageSearchDirection = null, Expression<Func<bool>> uIALocateVisibleSearchImageWithinElementhideAgent = null, Expression<Func<bool>> uIALocateVisibleSearchImageWithinElementreturnPhysicalCoordinates = null, Expression<Func<bool>> uIALocateVisibleSearchImageWithinElementshowHighlightRectangle = null)
        {
            var apiCallPath = "/UIAControl/UIALocateVisibleSearchImageWithinElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIALocateVisibleSearchImageWithinElement = new JObject();
            var uIALocateVisibleSearchImageWithinElementpropCount = 0;
            uIALocateVisibleSearchImageWithinElementpropCount++;
            uIALocateVisibleSearchImageWithinElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementparentWindowHandle);
            if (uIALocateVisibleSearchImageWithinElementsearchElementName != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchElementName"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementsearchElementName);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementsearchElementClassName != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementsearchElementClassName);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementsearchElementAutomationId != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementsearchElementAutomationId);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementsearchLocalizedControlType != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementsearchLocalizedControlType);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementsearchSubTree != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementsearchSubTree);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementmatchIndex != null)
            {
                uIALocateVisibleSearchImageWithinElement["MatchIndex"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementmatchIndex);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementsearchFilter != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchFilter"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementsearchFilter);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementsortByColumn != null)
            {
                uIALocateVisibleSearchImageWithinElement["SortByColumn"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementsortByColumn);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementmatchIndexAscending != null)
            {
                uIALocateVisibleSearchImageWithinElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementmatchIndexAscending);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementmaxElementsToSearch != null)
            {
                uIALocateVisibleSearchImageWithinElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementmaxElementsToSearch);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementmaxRelativeSearchDepth != null)
            {
                uIALocateVisibleSearchImageWithinElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementmaxRelativeSearchDepth);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode != null)
            {
                uIALocateVisibleSearchImageWithinElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIALocateVisibleSearchImageWithinElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementsearchImageType != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchImageType"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementsearchImageType);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementsearchImage != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchImage"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementsearchImage);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementaltSearchImageType != null)
            {
                uIALocateVisibleSearchImageWithinElement["AltSearchImageType"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementaltSearchImageType);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementaltSearchImage != null)
            {
                uIALocateVisibleSearchImageWithinElement["AltSearchImage"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementaltSearchImage);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementmaxColourDeviation != null)
            {
                uIALocateVisibleSearchImageWithinElement["MaxColourDeviation"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementmaxColourDeviation);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementmaxPixelDifferences != null)
            {
                uIALocateVisibleSearchImageWithinElement["MaxPixelDifferences"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementmaxPixelDifferences);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementmaxConsecutivePixelDifferences != null)
            {
                uIALocateVisibleSearchImageWithinElement["MaxConsecutivePixelDifferences"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementmaxConsecutivePixelDifferences);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementleftPixelXOffset != null)
            {
                uIALocateVisibleSearchImageWithinElement["LeftPixelXOffset"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementleftPixelXOffset);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementrightPixelXOffset != null)
            {
                uIALocateVisibleSearchImageWithinElement["RightPixelXOffset"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementrightPixelXOffset);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementtopPixelYOffset != null)
            {
                uIALocateVisibleSearchImageWithinElement["TopPixelYOffset"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementtopPixelYOffset);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementbottomPixelYOffset != null)
            {
                uIALocateVisibleSearchImageWithinElement["BottomPixelYOffset"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementbottomPixelYOffset);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnit != null)
            {
                uIALocateVisibleSearchImageWithinElement["PixelXOffsetsUnit"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnit);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnit != null)
            {
                uIALocateVisibleSearchImageWithinElement["PixelYOffsetsUnit"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnit);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementsearchImageIndex != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchImageIndex"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementsearchImageIndex);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementimageSearchDirection != null)
            {
                uIALocateVisibleSearchImageWithinElement["ImageSearchDirection"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementimageSearchDirection);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementhideAgent != null)
            {
                uIALocateVisibleSearchImageWithinElement["HideAgent"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementhideAgent);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementreturnPhysicalCoordinates != null)
            {
                uIALocateVisibleSearchImageWithinElement["ReturnPhysicalCoordinates"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementreturnPhysicalCoordinates);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementshowHighlightRectangle != null)
            {
                uIALocateVisibleSearchImageWithinElement["ShowHighlightRectangle"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementshowHighlightRectangle);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            uIALocateVisibleSearchImageWithinElementpropCount++;
            uIALocateVisibleSearchImageWithinElement["Workflow"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementworkflow);
            if (uIALocateVisibleSearchImageWithinElementpropCount > 0)
            {
                callPayload.Body = uIALocateVisibleSearchImageWithinElement;
            }

            return new ApiConnectionAction<UIALocateVisibleSearchImageWithinElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForVisibleSearchImageWithinElementResponse> UIAWaitForVisibleSearchImageWithinElement(Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementworkflow, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementparentWindowHandle = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementsearchElementName = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementsearchElementClassName = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementsearchElementAutomationId = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageWithinElementsearchSubTree = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementmatchIndex = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementsearchFilter = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementsortByColumn = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageWithinElementmatchIndexAscending = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementmaxElementsToSearch = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<uIAWaitForVisibleSearchImageWithinElementsearchImageTypeInput>> uIAWaitForVisibleSearchImageWithinElementsearchImageType = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementsearchImage = null, Expression<Func<uIAWaitForVisibleSearchImageWithinElementaltSearchImageTypeInput>> uIAWaitForVisibleSearchImageWithinElementaltSearchImageType = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementaltSearchImage = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementmaxColourDeviation = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementmaxPixelDifferences = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementmaxConsecutivePixelDifferences = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementleftPixelXOffset = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementrightPixelXOffset = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementtopPixelYOffset = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementbottomPixelYOffset = null, Expression<Func<uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnitInput>> uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnit = null, Expression<Func<uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnitInput>> uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnit = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementsearchImageIndex = null, Expression<Func<uIAWaitForVisibleSearchImageWithinElementimageSearchDirectionInput>> uIAWaitForVisibleSearchImageWithinElementimageSearchDirection = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageWithinElementhideAgent = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageWithinElementreturnPhysicalCoordinates = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageWithinElementshowHighlightRectangle = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementsecondsToWait = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementmillisecondsBetweenSearches = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageWithinElementraiseExceptionIfImageNotFound = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementretrieveOutputDataFromThreadId = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageWithinElementwaitForThread = null)
        {
            var apiCallPath = "/UIAControl/UIAWaitForVisibleSearchImageWithinElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAWaitForVisibleSearchImageWithinElement = new JObject();
            var uIAWaitForVisibleSearchImageWithinElementpropCount = 0;
            if (uIAWaitForVisibleSearchImageWithinElementparentWindowHandle != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementparentWindowHandle);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementsearchElementName != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementsearchElementName);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementsearchElementClassName != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementsearchElementClassName);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementsearchElementAutomationId != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementsearchElementAutomationId);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementsearchLocalizedControlType != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementsearchLocalizedControlType);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementsearchSubTree != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementsearchSubTree);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementmatchIndex != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementmatchIndex);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementsearchFilter != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementsearchFilter);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementsortByColumn != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementsortByColumn);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementmatchIndexAscending != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementmatchIndexAscending);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementmaxElementsToSearch != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementmaxElementsToSearch);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementmaxRelativeSearchDepth != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementmaxRelativeSearchDepth);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementsearchImageType != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchImageType"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementsearchImageType);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementsearchImage != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchImage"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementsearchImage);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementaltSearchImageType != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["AltSearchImageType"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementaltSearchImageType);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementaltSearchImage != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["AltSearchImage"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementaltSearchImage);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementmaxColourDeviation != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["MaxColourDeviation"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementmaxColourDeviation);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementmaxPixelDifferences != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["MaxPixelDifferences"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementmaxPixelDifferences);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementmaxConsecutivePixelDifferences != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["MaxConsecutivePixelDifferences"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementmaxConsecutivePixelDifferences);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementleftPixelXOffset != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["LeftPixelXOffset"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementleftPixelXOffset);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementrightPixelXOffset != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["RightPixelXOffset"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementrightPixelXOffset);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementtopPixelYOffset != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["TopPixelYOffset"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementtopPixelYOffset);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementbottomPixelYOffset != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["BottomPixelYOffset"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementbottomPixelYOffset);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnit != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["PixelXOffsetsUnit"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnit);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnit != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["PixelYOffsetsUnit"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnit);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementsearchImageIndex != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchImageIndex"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementsearchImageIndex);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementimageSearchDirection != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["ImageSearchDirection"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementimageSearchDirection);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementhideAgent != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["HideAgent"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementhideAgent);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementreturnPhysicalCoordinates != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["ReturnPhysicalCoordinates"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementreturnPhysicalCoordinates);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementshowHighlightRectangle != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["ShowHighlightRectangle"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementshowHighlightRectangle);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementsecondsToWait != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementsecondsToWait);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementmillisecondsBetweenSearches != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["MillisecondsBetweenSearches"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementmillisecondsBetweenSearches);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementraiseExceptionIfImageNotFound != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["RaiseExceptionIfImageNotFound"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementraiseExceptionIfImageNotFound);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementretrieveOutputDataFromThreadId != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementretrieveOutputDataFromThreadId);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementwaitForThread != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["WaitForThread"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementwaitForThread);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            uIAWaitForVisibleSearchImageWithinElementpropCount++;
            uIAWaitForVisibleSearchImageWithinElement["Workflow"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementworkflow);
            if (uIAWaitForVisibleSearchImageWithinElementpropCount > 0)
            {
                callPayload.Body = uIAWaitForVisibleSearchImageWithinElement;
            }

            return new ApiConnectionAction<UIAWaitForVisibleSearchImageWithinElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForVisibleSearchImageToNotExistWithinElementResponse> UIAWaitForVisibleSearchImageToNotExistWithinElement(Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementworkflow, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementparentWindowHandle = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementName = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementClassName = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementAutomationId = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchSubTree = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndex = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchFilter = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementsortByColumn = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndexAscending = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxElementsToSearch = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageTypeInput>> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageType = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImage = null, Expression<Func<uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageTypeInput>> uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageType = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImage = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxColourDeviation = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxPixelDifferences = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxConsecutivePixelDifferences = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementleftPixelXOffset = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementrightPixelXOffset = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementtopPixelYOffset = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementbottomPixelYOffset = null, Expression<Func<uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnitInput>> uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnit = null, Expression<Func<uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnitInput>> uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnit = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageIndex = null, Expression<Func<uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirectionInput>> uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirection = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageToNotExistWithinElementhideAgent = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageToNotExistWithinElementshowHighlightRectangle = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementsecondsToWait = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementmillisecondsBetweenSearches = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageToNotExistWithinElementraiseExceptionIfImageStillPresent = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementretrieveOutputDataFromThreadId = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageToNotExistWithinElementwaitForThread = null)
        {
            var apiCallPath = "/UIAControl/UIAWaitForVisibleSearchImageToNotExistWithinElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var uIAWaitForVisibleSearchImageToNotExistWithinElement = new JObject();
            var uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount = 0;
            if (uIAWaitForVisibleSearchImageToNotExistWithinElementparentWindowHandle != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementparentWindowHandle);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementName != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchElementName"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementName);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementClassName != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchElementClassName"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementClassName);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementAutomationId != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementAutomationId);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchLocalizedControlType != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchLocalizedControlType);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchSubTree != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchSubTree);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndex != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndex);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchFilter != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchFilter"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchFilter);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementsortByColumn != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SortByColumn"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementsortByColumn);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndexAscending != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndexAscending);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementmaxElementsToSearch != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxElementsToSearch);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementmaxRelativeSearchDepth != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxRelativeSearchDepth);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementmaxChildElementsToSearchPerNode != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxChildElementsToSearchPerNode);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementelementLocalizedControlTypesNotToTraverse);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageType != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchImageType"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageType);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImage != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchImage"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImage);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageType != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["AltSearchImageType"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageType);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImage != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["AltSearchImage"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImage);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementmaxColourDeviation != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxColourDeviation"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxColourDeviation);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementmaxPixelDifferences != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxPixelDifferences"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxPixelDifferences);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementmaxConsecutivePixelDifferences != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxConsecutivePixelDifferences"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxConsecutivePixelDifferences);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementleftPixelXOffset != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["LeftPixelXOffset"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementleftPixelXOffset);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementrightPixelXOffset != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["RightPixelXOffset"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementrightPixelXOffset);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementtopPixelYOffset != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["TopPixelYOffset"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementtopPixelYOffset);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementbottomPixelYOffset != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["BottomPixelYOffset"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementbottomPixelYOffset);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnit != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["PixelXOffsetsUnit"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnit);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnit != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["PixelYOffsetsUnit"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnit);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageIndex != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchImageIndex"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageIndex);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirection != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["ImageSearchDirection"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirection);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementhideAgent != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["HideAgent"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementhideAgent);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementshowHighlightRectangle != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["ShowHighlightRectangle"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementshowHighlightRectangle);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementsecondsToWait != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementsecondsToWait);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementmillisecondsBetweenSearches != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MillisecondsBetweenSearches"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementmillisecondsBetweenSearches);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementraiseExceptionIfImageStillPresent != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["RaiseExceptionIfImageStillPresent"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementraiseExceptionIfImageStillPresent);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementretrieveOutputDataFromThreadId != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementretrieveOutputDataFromThreadId);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementwaitForThread != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["WaitForThread"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementwaitForThread);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            uIAWaitForVisibleSearchImageToNotExistWithinElement["Workflow"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementworkflow);
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

    public enum uIAGlobalMouseClickOnElementoffsetRelativeToInput
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

    public enum uIAGlobalRightMouseClickOnElementoffsetRelativeToInput
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

    public enum uIAGlobalMiddleMouseClickOnElementoffsetRelativeToInput
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

    public enum uIAGlobalDoubleLeftMouseClickOnElementoffsetRelativeToInput
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

    public enum uIATakeScreenShotOfElementLocationimageFormatInput
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

    public enum uIAGlobalMouseClickElementSearchColourRegionmouseButtonInput
    {
        Left,
        Right,
        Middle,
        [EnumMember(Value = "Double left")]
        DoubleLeft
    }

    public enum uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeToInput
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

    public enum setUIAElementSearchModeuIAElementSearchModeInput
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

    public enum uIAMoveElementhorizontalMovementTypeInput
    {
        Absolute,
        Relative
    }

    public enum uIAMoveElementverticalMovementTypeInput
    {
        Absolute,
        Relative
    }

    public class UIAResizeElementResponse
    {
        public bool UIAResizeElementResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public enum uIAResizeElementresizeWidthTypeInput
    {
        Absolute,
        Relative
    }

    public enum uIAResizeElementresizeHeightTypeInput
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

    public enum uIALocateVisibleSearchImageWithinElementsearchImageTypeInput
    {
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    public enum uIALocateVisibleSearchImageWithinElementaltSearchImageTypeInput
    {
        None,
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    public enum uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnitInput
    {
        Pixel,
        Percent
    }

    public enum uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnitInput
    {
        Pixel,
        Percent
    }

    public enum uIALocateVisibleSearchImageWithinElementimageSearchDirectionInput
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

    public enum uIAWaitForVisibleSearchImageWithinElementsearchImageTypeInput
    {
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    public enum uIAWaitForVisibleSearchImageWithinElementaltSearchImageTypeInput
    {
        None,
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    public enum uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnitInput
    {
        Pixel,
        Percent
    }

    public enum uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnitInput
    {
        Pixel,
        Percent
    }

    public enum uIAWaitForVisibleSearchImageWithinElementimageSearchDirectionInput
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

    public enum uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageTypeInput
    {
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    public enum uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageTypeInput
    {
        None,
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    public enum uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnitInput
    {
        Pixel,
        Percent
    }

    public enum uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnitInput
    {
        Pixel,
        Percent
    }

    public enum uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirectionInput
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