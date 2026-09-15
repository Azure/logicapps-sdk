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
                uIADoesTopLevelWindowExist["SearchClassName"] = CSharpExpressionConverter.ConvertToken(uIADoesTopLevelWindowExistsearchClassName);
                uIADoesTopLevelWindowExistpropCount++;
            }

            if (uIADoesTopLevelWindowExistsearchWindowTitle != null)
            {
                uIADoesTopLevelWindowExist["SearchWindowTitle"] = CSharpExpressionConverter.ConvertToken(uIADoesTopLevelWindowExistsearchWindowTitle);
                uIADoesTopLevelWindowExistpropCount++;
            }

            if (uIADoesTopLevelWindowExistsearchProcessId != null)
            {
                uIADoesTopLevelWindowExist["SearchProcessId"] = CSharpExpressionConverter.ConvertToken(uIADoesTopLevelWindowExistsearchProcessId);
                uIADoesTopLevelWindowExistpropCount++;
            }

            if (uIADoesTopLevelWindowExistmatchIndex != null)
            {
                if (uIADoesTopLevelWindowExistmatchIndex != null)
                {
                    uIADoesTopLevelWindowExist["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIADoesTopLevelWindowExistmatchIndex);
                    uIADoesTopLevelWindowExistpropCount++;
                }

                uIADoesTopLevelWindowExistpropCount++;
            }
            else
            {
                uIADoesTopLevelWindowExist["MatchIndex"] = 1;
                uIADoesTopLevelWindowExistpropCount++;
            }

            if (uIADoesTopLevelWindowExistsearchFilter != null)
            {
                uIADoesTopLevelWindowExist["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIADoesTopLevelWindowExistsearchFilter);
                uIADoesTopLevelWindowExistpropCount++;
            }

            uIADoesTopLevelWindowExistpropCount++;
            uIADoesTopLevelWindowExist["Workflow"] = CSharpExpressionConverter.ConvertToken(uIADoesTopLevelWindowExistworkflow);
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
                uIAGetHandleForTopLevelWindow["SearchClassName"] = CSharpExpressionConverter.ConvertToken(uIAGetHandleForTopLevelWindowsearchClassName);
                uIAGetHandleForTopLevelWindowpropCount++;
            }

            if (uIAGetHandleForTopLevelWindowsearchWindowTitle != null)
            {
                uIAGetHandleForTopLevelWindow["SearchWindowTitle"] = CSharpExpressionConverter.ConvertToken(uIAGetHandleForTopLevelWindowsearchWindowTitle);
                uIAGetHandleForTopLevelWindowpropCount++;
            }

            if (uIAGetHandleForTopLevelWindowsearchProcessId != null)
            {
                uIAGetHandleForTopLevelWindow["SearchProcessId"] = CSharpExpressionConverter.ConvertToken(uIAGetHandleForTopLevelWindowsearchProcessId);
                uIAGetHandleForTopLevelWindowpropCount++;
            }

            if (uIAGetHandleForTopLevelWindowmatchIndex != null)
            {
                if (uIAGetHandleForTopLevelWindowmatchIndex != null)
                {
                    uIAGetHandleForTopLevelWindow["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAGetHandleForTopLevelWindowmatchIndex);
                    uIAGetHandleForTopLevelWindowpropCount++;
                }

                uIAGetHandleForTopLevelWindowpropCount++;
            }
            else
            {
                uIAGetHandleForTopLevelWindow["MatchIndex"] = 1;
                uIAGetHandleForTopLevelWindowpropCount++;
            }

            if (uIAGetHandleForTopLevelWindowsearchFilter != null)
            {
                uIAGetHandleForTopLevelWindow["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAGetHandleForTopLevelWindowsearchFilter);
                uIAGetHandleForTopLevelWindowpropCount++;
            }

            if (uIAGetHandleForTopLevelWindowsortByColumn != null)
            {
                uIAGetHandleForTopLevelWindow["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAGetHandleForTopLevelWindowsortByColumn);
                uIAGetHandleForTopLevelWindowpropCount++;
            }

            if (uIAGetHandleForTopLevelWindowmatchIndexAscending != null)
            {
                if (uIAGetHandleForTopLevelWindowmatchIndexAscending != null)
                {
                    uIAGetHandleForTopLevelWindow["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAGetHandleForTopLevelWindowmatchIndexAscending);
                    uIAGetHandleForTopLevelWindowpropCount++;
                }

                uIAGetHandleForTopLevelWindowpropCount++;
            }
            else
            {
                uIAGetHandleForTopLevelWindow["MatchIndexAscending"] = true;
                uIAGetHandleForTopLevelWindowpropCount++;
            }

            uIAGetHandleForTopLevelWindowpropCount++;
            uIAGetHandleForTopLevelWindow["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetHandleForTopLevelWindowworkflow);
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
                uIAWaitForTopLevelWindow["SearchClassName"] = CSharpExpressionConverter.ConvertToken(uIAWaitForTopLevelWindowsearchClassName);
                uIAWaitForTopLevelWindowpropCount++;
            }

            if (uIAWaitForTopLevelWindowsearchWindowTitle != null)
            {
                uIAWaitForTopLevelWindow["SearchWindowTitle"] = CSharpExpressionConverter.ConvertToken(uIAWaitForTopLevelWindowsearchWindowTitle);
                uIAWaitForTopLevelWindowpropCount++;
            }

            uIAWaitForTopLevelWindowpropCount++;
            uIAWaitForTopLevelWindow["SecondsToWait"] = CSharpExpressionConverter.ConvertToken(uIAWaitForTopLevelWindowsecondsToWait);
            if (uIAWaitForTopLevelWindowsearchProcessId != null)
            {
                uIAWaitForTopLevelWindow["SearchProcessId"] = CSharpExpressionConverter.ConvertToken(uIAWaitForTopLevelWindowsearchProcessId);
                uIAWaitForTopLevelWindowpropCount++;
            }

            if (uIAWaitForTopLevelWindowmatchIndex != null)
            {
                if (uIAWaitForTopLevelWindowmatchIndex != null)
                {
                    uIAWaitForTopLevelWindow["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAWaitForTopLevelWindowmatchIndex);
                    uIAWaitForTopLevelWindowpropCount++;
                }

                uIAWaitForTopLevelWindowpropCount++;
            }
            else
            {
                uIAWaitForTopLevelWindow["MatchIndex"] = 1;
                uIAWaitForTopLevelWindowpropCount++;
            }

            if (uIAWaitForTopLevelWindowsearchFilter != null)
            {
                uIAWaitForTopLevelWindow["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAWaitForTopLevelWindowsearchFilter);
                uIAWaitForTopLevelWindowpropCount++;
            }

            if (uIAWaitForTopLevelWindowsortByColumn != null)
            {
                uIAWaitForTopLevelWindow["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAWaitForTopLevelWindowsortByColumn);
                uIAWaitForTopLevelWindowpropCount++;
            }

            if (uIAWaitForTopLevelWindowmatchIndexAscending != null)
            {
                if (uIAWaitForTopLevelWindowmatchIndexAscending != null)
                {
                    uIAWaitForTopLevelWindow["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAWaitForTopLevelWindowmatchIndexAscending);
                    uIAWaitForTopLevelWindowpropCount++;
                }

                uIAWaitForTopLevelWindowpropCount++;
            }
            else
            {
                uIAWaitForTopLevelWindow["MatchIndexAscending"] = true;
                uIAWaitForTopLevelWindowpropCount++;
            }

            if (uIAWaitForTopLevelWindowraiseExceptionIfWindowNotFound != null)
            {
                if (uIAWaitForTopLevelWindowraiseExceptionIfWindowNotFound != null)
                {
                    uIAWaitForTopLevelWindow["RaiseExceptionIfWindowNotFound"] = CSharpExpressionConverter.ConvertToken(uIAWaitForTopLevelWindowraiseExceptionIfWindowNotFound);
                    uIAWaitForTopLevelWindowpropCount++;
                }

                uIAWaitForTopLevelWindowpropCount++;
            }
            else
            {
                uIAWaitForTopLevelWindow["RaiseExceptionIfWindowNotFound"] = false;
                uIAWaitForTopLevelWindowpropCount++;
            }

            uIAWaitForTopLevelWindowpropCount++;
            uIAWaitForTopLevelWindow["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAWaitForTopLevelWindowworkflow);
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
            uIADoesProcessHaveWindow["SearchProcessName"] = CSharpExpressionConverter.ConvertToken(uIADoesProcessHaveWindowsearchProcessName);
            uIADoesProcessHaveWindowpropCount++;
            uIADoesProcessHaveWindow["Workflow"] = CSharpExpressionConverter.ConvertToken(uIADoesProcessHaveWindowworkflow);
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
            uIAGetHandleForProcessMainWindow["SearchProcessName"] = CSharpExpressionConverter.ConvertToken(uIAGetHandleForProcessMainWindowsearchProcessName);
            uIAGetHandleForProcessMainWindowpropCount++;
            uIAGetHandleForProcessMainWindow["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetHandleForProcessMainWindowworkflow);
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
            uIAWaitForProcessMainWindow["SearchProcessName"] = CSharpExpressionConverter.ConvertToken(uIAWaitForProcessMainWindowsearchProcessName);
            uIAWaitForProcessMainWindowpropCount++;
            uIAWaitForProcessMainWindow["SecondsToWait"] = CSharpExpressionConverter.ConvertToken(uIAWaitForProcessMainWindowsecondsToWait);
            uIAWaitForProcessMainWindowpropCount++;
            uIAWaitForProcessMainWindow["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAWaitForProcessMainWindowworkflow);
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
            uIAGetHandleForProcessIdMainWindow["ProcessId"] = CSharpExpressionConverter.ConvertToken(uIAGetHandleForProcessIdMainWindowprocessId);
            uIAGetHandleForProcessIdMainWindowpropCount++;
            uIAGetHandleForProcessIdMainWindow["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetHandleForProcessIdMainWindowworkflow);
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
            uIAWaitForProcessIdMainWindow["ProcessId"] = CSharpExpressionConverter.ConvertToken(uIAWaitForProcessIdMainWindowprocessId);
            uIAWaitForProcessIdMainWindowpropCount++;
            uIAWaitForProcessIdMainWindow["SecondsToWait"] = CSharpExpressionConverter.ConvertToken(uIAWaitForProcessIdMainWindowsecondsToWait);
            uIAWaitForProcessIdMainWindowpropCount++;
            uIAWaitForProcessIdMainWindow["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAWaitForProcessIdMainWindowworkflow);
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
            uIAGetHandleForFocussedElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetHandleForFocussedElementworkflow);
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
            uIAGetHandleForMainWindowOfFocussedElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetHandleForMainWindowOfFocussedElementworkflow);
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
            uIAGetHandleForDesktop["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetHandleForDesktopworkflow);
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
            uIASetForegroundWindow["WindowHandle"] = CSharpExpressionConverter.ConvertToken(uIASetForegroundWindowwindowHandle);
            if (uIASetForegroundWindowtoggleWindow != null)
            {
                if (uIASetForegroundWindowtoggleWindow != null)
                {
                    uIASetForegroundWindow["ToggleWindow"] = CSharpExpressionConverter.ConvertToken(uIASetForegroundWindowtoggleWindow);
                    uIASetForegroundWindowpropCount++;
                }

                uIASetForegroundWindowpropCount++;
            }
            else
            {
                uIASetForegroundWindow["ToggleWindow"] = true;
                uIASetForegroundWindowpropCount++;
            }

            if (uIASetForegroundWindowtoggleUsesGlobalLeftMouseClickAgent != null)
            {
                if (uIASetForegroundWindowtoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    uIASetForegroundWindow["ToggleUsesGlobalLeftMouseClickAgent"] = CSharpExpressionConverter.ConvertToken(uIASetForegroundWindowtoggleUsesGlobalLeftMouseClickAgent);
                    uIASetForegroundWindowpropCount++;
                }

                uIASetForegroundWindowpropCount++;
            }
            else
            {
                uIASetForegroundWindow["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                uIASetForegroundWindowpropCount++;
            }

            if (uIASetForegroundWindowtoggleDelay != null)
            {
                if (uIASetForegroundWindowtoggleDelay != null)
                {
                    uIASetForegroundWindow["ToggleDelay"] = CSharpExpressionConverter.ConvertToken(uIASetForegroundWindowtoggleDelay);
                    uIASetForegroundWindowpropCount++;
                }

                uIASetForegroundWindowpropCount++;
            }
            else
            {
                uIASetForegroundWindow["ToggleDelay"] = 0.25;
                uIASetForegroundWindowpropCount++;
            }

            uIASetForegroundWindowpropCount++;
            uIASetForegroundWindow["Workflow"] = CSharpExpressionConverter.ConvertToken(uIASetForegroundWindowworkflow);
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
            uIAMaximiseWindow["WindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAMaximiseWindowwindowHandle);
            uIAMaximiseWindowpropCount++;
            uIAMaximiseWindow["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAMaximiseWindowworkflow);
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
            uIAMinimiseWindow["WindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAMinimiseWindowwindowHandle);
            uIAMinimiseWindowpropCount++;
            uIAMinimiseWindow["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAMinimiseWindowworkflow);
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
            uIASetWindowToNormal["WindowHandle"] = CSharpExpressionConverter.ConvertToken(uIASetWindowToNormalwindowHandle);
            uIASetWindowToNormalpropCount++;
            uIASetWindowToNormal["Workflow"] = CSharpExpressionConverter.ConvertToken(uIASetWindowToNormalworkflow);
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
            uIADoesElementExist["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIADoesElementExistparentWindowHandle);
            if (uIADoesElementExistsearchElementName != null)
            {
                uIADoesElementExist["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIADoesElementExistsearchElementName);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistsearchElementClassName != null)
            {
                uIADoesElementExist["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIADoesElementExistsearchElementClassName);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistsearchElementAutomationId != null)
            {
                uIADoesElementExist["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIADoesElementExistsearchElementAutomationId);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistsearchLocalizedControlType != null)
            {
                uIADoesElementExist["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIADoesElementExistsearchLocalizedControlType);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistsearchProcessId != null)
            {
                uIADoesElementExist["SearchProcessId"] = CSharpExpressionConverter.ConvertToken(uIADoesElementExistsearchProcessId);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistsearchSubTree != null)
            {
                if (uIADoesElementExistsearchSubTree != null)
                {
                    uIADoesElementExist["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIADoesElementExistsearchSubTree);
                    uIADoesElementExistpropCount++;
                }

                uIADoesElementExistpropCount++;
            }
            else
            {
                uIADoesElementExist["SearchSubTree"] = true;
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistreturnElementHandle != null)
            {
                if (uIADoesElementExistreturnElementHandle != null)
                {
                    uIADoesElementExist["ReturnElementHandle"] = CSharpExpressionConverter.ConvertToken(uIADoesElementExistreturnElementHandle);
                    uIADoesElementExistpropCount++;
                }

                uIADoesElementExistpropCount++;
            }
            else
            {
                uIADoesElementExist["ReturnElementHandle"] = true;
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistmatchIndex != null)
            {
                if (uIADoesElementExistmatchIndex != null)
                {
                    uIADoesElementExist["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIADoesElementExistmatchIndex);
                    uIADoesElementExistpropCount++;
                }

                uIADoesElementExistpropCount++;
            }
            else
            {
                uIADoesElementExist["MatchIndex"] = 1;
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistsearchFilter != null)
            {
                uIADoesElementExist["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIADoesElementExistsearchFilter);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistsortByColumn != null)
            {
                uIADoesElementExist["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIADoesElementExistsortByColumn);
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistmatchIndexAscending != null)
            {
                if (uIADoesElementExistmatchIndexAscending != null)
                {
                    uIADoesElementExist["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIADoesElementExistmatchIndexAscending);
                    uIADoesElementExistpropCount++;
                }

                uIADoesElementExistpropCount++;
            }
            else
            {
                uIADoesElementExist["MatchIndexAscending"] = true;
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistincludeChildProcesses != null)
            {
                if (uIADoesElementExistincludeChildProcesses != null)
                {
                    uIADoesElementExist["IncludeChildProcesses"] = CSharpExpressionConverter.ConvertToken(uIADoesElementExistincludeChildProcesses);
                    uIADoesElementExistpropCount++;
                }

                uIADoesElementExistpropCount++;
            }
            else
            {
                uIADoesElementExist["IncludeChildProcesses"] = false;
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistmaxElementsToSearch != null)
            {
                if (uIADoesElementExistmaxElementsToSearch != null)
                {
                    uIADoesElementExist["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIADoesElementExistmaxElementsToSearch);
                    uIADoesElementExistpropCount++;
                }

                uIADoesElementExistpropCount++;
            }
            else
            {
                uIADoesElementExist["MaxElementsToSearch"] = 0;
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistmaxRelativeSearchDepth != null)
            {
                if (uIADoesElementExistmaxRelativeSearchDepth != null)
                {
                    uIADoesElementExist["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIADoesElementExistmaxRelativeSearchDepth);
                    uIADoesElementExistpropCount++;
                }

                uIADoesElementExistpropCount++;
            }
            else
            {
                uIADoesElementExist["MaxRelativeSearchDepth"] = 0;
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistmaxChildElementsToSearchPerNode != null)
            {
                if (uIADoesElementExistmaxChildElementsToSearchPerNode != null)
                {
                    uIADoesElementExist["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIADoesElementExistmaxChildElementsToSearchPerNode);
                    uIADoesElementExistpropCount++;
                }

                uIADoesElementExistpropCount++;
            }
            else
            {
                uIADoesElementExist["MaxChildElementsToSearchPerNode"] = 0;
                uIADoesElementExistpropCount++;
            }

            if (uIADoesElementExistelementLocalizedControlTypesNotToTraverse != null)
            {
                uIADoesElementExist["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIADoesElementExistelementLocalizedControlTypesNotToTraverse);
                uIADoesElementExistpropCount++;
            }

            uIADoesElementExistpropCount++;
            uIADoesElementExist["Workflow"] = CSharpExpressionConverter.ConvertToken(uIADoesElementExistworkflow);
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
                uIADoesDesktopElementExist["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIADoesDesktopElementExistsearchElementName);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistsearchElementClassName != null)
            {
                uIADoesDesktopElementExist["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIADoesDesktopElementExistsearchElementClassName);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistsearchElementAutomationId != null)
            {
                uIADoesDesktopElementExist["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIADoesDesktopElementExistsearchElementAutomationId);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistsearchLocalizedControlType != null)
            {
                uIADoesDesktopElementExist["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIADoesDesktopElementExistsearchLocalizedControlType);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistsearchProcessId != null)
            {
                uIADoesDesktopElementExist["SearchProcessId"] = CSharpExpressionConverter.ConvertToken(uIADoesDesktopElementExistsearchProcessId);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistsearchSubTree != null)
            {
                if (uIADoesDesktopElementExistsearchSubTree != null)
                {
                    uIADoesDesktopElementExist["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIADoesDesktopElementExistsearchSubTree);
                    uIADoesDesktopElementExistpropCount++;
                }

                uIADoesDesktopElementExistpropCount++;
            }
            else
            {
                uIADoesDesktopElementExist["SearchSubTree"] = true;
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistreturnElementHandle != null)
            {
                if (uIADoesDesktopElementExistreturnElementHandle != null)
                {
                    uIADoesDesktopElementExist["ReturnElementHandle"] = CSharpExpressionConverter.ConvertToken(uIADoesDesktopElementExistreturnElementHandle);
                    uIADoesDesktopElementExistpropCount++;
                }

                uIADoesDesktopElementExistpropCount++;
            }
            else
            {
                uIADoesDesktopElementExist["ReturnElementHandle"] = true;
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistmatchIndex != null)
            {
                if (uIADoesDesktopElementExistmatchIndex != null)
                {
                    uIADoesDesktopElementExist["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIADoesDesktopElementExistmatchIndex);
                    uIADoesDesktopElementExistpropCount++;
                }

                uIADoesDesktopElementExistpropCount++;
            }
            else
            {
                uIADoesDesktopElementExist["MatchIndex"] = 1;
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistsearchFilter != null)
            {
                uIADoesDesktopElementExist["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIADoesDesktopElementExistsearchFilter);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistsortByColumn != null)
            {
                uIADoesDesktopElementExist["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIADoesDesktopElementExistsortByColumn);
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistmatchIndexAscending != null)
            {
                if (uIADoesDesktopElementExistmatchIndexAscending != null)
                {
                    uIADoesDesktopElementExist["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIADoesDesktopElementExistmatchIndexAscending);
                    uIADoesDesktopElementExistpropCount++;
                }

                uIADoesDesktopElementExistpropCount++;
            }
            else
            {
                uIADoesDesktopElementExist["MatchIndexAscending"] = true;
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistincludeChildProcesses != null)
            {
                if (uIADoesDesktopElementExistincludeChildProcesses != null)
                {
                    uIADoesDesktopElementExist["IncludeChildProcesses"] = CSharpExpressionConverter.ConvertToken(uIADoesDesktopElementExistincludeChildProcesses);
                    uIADoesDesktopElementExistpropCount++;
                }

                uIADoesDesktopElementExistpropCount++;
            }
            else
            {
                uIADoesDesktopElementExist["IncludeChildProcesses"] = false;
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistmaxElementsToSearch != null)
            {
                if (uIADoesDesktopElementExistmaxElementsToSearch != null)
                {
                    uIADoesDesktopElementExist["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIADoesDesktopElementExistmaxElementsToSearch);
                    uIADoesDesktopElementExistpropCount++;
                }

                uIADoesDesktopElementExistpropCount++;
            }
            else
            {
                uIADoesDesktopElementExist["MaxElementsToSearch"] = 0;
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistmaxRelativeSearchDepth != null)
            {
                if (uIADoesDesktopElementExistmaxRelativeSearchDepth != null)
                {
                    uIADoesDesktopElementExist["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIADoesDesktopElementExistmaxRelativeSearchDepth);
                    uIADoesDesktopElementExistpropCount++;
                }

                uIADoesDesktopElementExistpropCount++;
            }
            else
            {
                uIADoesDesktopElementExist["MaxRelativeSearchDepth"] = 0;
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistmaxChildElementsToSearchPerNode != null)
            {
                if (uIADoesDesktopElementExistmaxChildElementsToSearchPerNode != null)
                {
                    uIADoesDesktopElementExist["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIADoesDesktopElementExistmaxChildElementsToSearchPerNode);
                    uIADoesDesktopElementExistpropCount++;
                }

                uIADoesDesktopElementExistpropCount++;
            }
            else
            {
                uIADoesDesktopElementExist["MaxChildElementsToSearchPerNode"] = 0;
                uIADoesDesktopElementExistpropCount++;
            }

            if (uIADoesDesktopElementExistelementLocalizedControlTypesNotToTraverse != null)
            {
                uIADoesDesktopElementExist["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIADoesDesktopElementExistelementLocalizedControlTypesNotToTraverse);
                uIADoesDesktopElementExistpropCount++;
            }

            uIADoesDesktopElementExistpropCount++;
            uIADoesDesktopElementExist["Workflow"] = CSharpExpressionConverter.ConvertToken(uIADoesDesktopElementExistworkflow);
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
            uIAWaitForElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementparentWindowHandle);
            if (uIAWaitForElementsearchElementName != null)
            {
                uIAWaitForElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementsearchElementName);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementsearchElementClassName != null)
            {
                uIAWaitForElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementsearchElementClassName);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementsearchElementAutomationId != null)
            {
                uIAWaitForElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementsearchElementAutomationId);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementsearchLocalizedControlType != null)
            {
                uIAWaitForElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementsearchLocalizedControlType);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementsearchProcessId != null)
            {
                uIAWaitForElement["SearchProcessId"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementsearchProcessId);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementsearchSubTree != null)
            {
                if (uIAWaitForElementsearchSubTree != null)
                {
                    uIAWaitForElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementsearchSubTree);
                    uIAWaitForElementpropCount++;
                }

                uIAWaitForElementpropCount++;
            }
            else
            {
                uIAWaitForElement["SearchSubTree"] = true;
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementreturnElementHandle != null)
            {
                if (uIAWaitForElementreturnElementHandle != null)
                {
                    uIAWaitForElement["ReturnElementHandle"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementreturnElementHandle);
                    uIAWaitForElementpropCount++;
                }

                uIAWaitForElementpropCount++;
            }
            else
            {
                uIAWaitForElement["ReturnElementHandle"] = true;
                uIAWaitForElementpropCount++;
            }

            uIAWaitForElementpropCount++;
            uIAWaitForElement["SecondsToWait"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementsecondsToWait);
            if (uIAWaitForElementmatchIndex != null)
            {
                if (uIAWaitForElementmatchIndex != null)
                {
                    uIAWaitForElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementmatchIndex);
                    uIAWaitForElementpropCount++;
                }

                uIAWaitForElementpropCount++;
            }
            else
            {
                uIAWaitForElement["MatchIndex"] = 1;
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementsearchFilter != null)
            {
                uIAWaitForElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementsearchFilter);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementsortByColumn != null)
            {
                uIAWaitForElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementsortByColumn);
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementmatchIndexAscending != null)
            {
                if (uIAWaitForElementmatchIndexAscending != null)
                {
                    uIAWaitForElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementmatchIndexAscending);
                    uIAWaitForElementpropCount++;
                }

                uIAWaitForElementpropCount++;
            }
            else
            {
                uIAWaitForElement["MatchIndexAscending"] = true;
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementincludeChildProcesses != null)
            {
                if (uIAWaitForElementincludeChildProcesses != null)
                {
                    uIAWaitForElement["IncludeChildProcesses"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementincludeChildProcesses);
                    uIAWaitForElementpropCount++;
                }

                uIAWaitForElementpropCount++;
            }
            else
            {
                uIAWaitForElement["IncludeChildProcesses"] = false;
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementraiseExceptionIfElementNotFound != null)
            {
                if (uIAWaitForElementraiseExceptionIfElementNotFound != null)
                {
                    uIAWaitForElement["RaiseExceptionIfElementNotFound"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementraiseExceptionIfElementNotFound);
                    uIAWaitForElementpropCount++;
                }

                uIAWaitForElementpropCount++;
            }
            else
            {
                uIAWaitForElement["RaiseExceptionIfElementNotFound"] = false;
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementmaxElementsToSearch != null)
            {
                if (uIAWaitForElementmaxElementsToSearch != null)
                {
                    uIAWaitForElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementmaxElementsToSearch);
                    uIAWaitForElementpropCount++;
                }

                uIAWaitForElementpropCount++;
            }
            else
            {
                uIAWaitForElement["MaxElementsToSearch"] = 0;
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementmaxRelativeSearchDepth != null)
            {
                if (uIAWaitForElementmaxRelativeSearchDepth != null)
                {
                    uIAWaitForElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementmaxRelativeSearchDepth);
                    uIAWaitForElementpropCount++;
                }

                uIAWaitForElementpropCount++;
            }
            else
            {
                uIAWaitForElement["MaxRelativeSearchDepth"] = 0;
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIAWaitForElementmaxChildElementsToSearchPerNode != null)
                {
                    uIAWaitForElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementmaxChildElementsToSearchPerNode);
                    uIAWaitForElementpropCount++;
                }

                uIAWaitForElementpropCount++;
            }
            else
            {
                uIAWaitForElement["MaxChildElementsToSearchPerNode"] = 0;
                uIAWaitForElementpropCount++;
            }

            if (uIAWaitForElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAWaitForElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementelementLocalizedControlTypesNotToTraverse);
                uIAWaitForElementpropCount++;
            }

            uIAWaitForElementpropCount++;
            uIAWaitForElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementworkflow);
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
                uIAWaitForDesktopElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementsearchElementName);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementsearchElementClassName != null)
            {
                uIAWaitForDesktopElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementsearchElementClassName);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementsearchElementAutomationId != null)
            {
                uIAWaitForDesktopElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementsearchElementAutomationId);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementsearchLocalizedControlType != null)
            {
                uIAWaitForDesktopElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementsearchLocalizedControlType);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementsearchProcessId != null)
            {
                if (uIAWaitForDesktopElementsearchProcessId != null)
                {
                    uIAWaitForDesktopElement["SearchProcessId"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementsearchProcessId);
                    uIAWaitForDesktopElementpropCount++;
                }

                uIAWaitForDesktopElementpropCount++;
            }
            else
            {
                uIAWaitForDesktopElement["SearchProcessId"] = 0;
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementsearchSubTree != null)
            {
                if (uIAWaitForDesktopElementsearchSubTree != null)
                {
                    uIAWaitForDesktopElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementsearchSubTree);
                    uIAWaitForDesktopElementpropCount++;
                }

                uIAWaitForDesktopElementpropCount++;
            }
            else
            {
                uIAWaitForDesktopElement["SearchSubTree"] = true;
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementreturnElementHandle != null)
            {
                if (uIAWaitForDesktopElementreturnElementHandle != null)
                {
                    uIAWaitForDesktopElement["ReturnElementHandle"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementreturnElementHandle);
                    uIAWaitForDesktopElementpropCount++;
                }

                uIAWaitForDesktopElementpropCount++;
            }
            else
            {
                uIAWaitForDesktopElement["ReturnElementHandle"] = true;
                uIAWaitForDesktopElementpropCount++;
            }

            uIAWaitForDesktopElementpropCount++;
            uIAWaitForDesktopElement["SecondsToWait"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementsecondsToWait);
            if (uIAWaitForDesktopElementmatchIndex != null)
            {
                if (uIAWaitForDesktopElementmatchIndex != null)
                {
                    uIAWaitForDesktopElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementmatchIndex);
                    uIAWaitForDesktopElementpropCount++;
                }

                uIAWaitForDesktopElementpropCount++;
            }
            else
            {
                uIAWaitForDesktopElement["MatchIndex"] = 1;
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementsearchFilter != null)
            {
                uIAWaitForDesktopElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementsearchFilter);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementsortByColumn != null)
            {
                uIAWaitForDesktopElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementsortByColumn);
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementmatchIndexAscending != null)
            {
                if (uIAWaitForDesktopElementmatchIndexAscending != null)
                {
                    uIAWaitForDesktopElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementmatchIndexAscending);
                    uIAWaitForDesktopElementpropCount++;
                }

                uIAWaitForDesktopElementpropCount++;
            }
            else
            {
                uIAWaitForDesktopElement["MatchIndexAscending"] = true;
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementincludeChildProcesses != null)
            {
                if (uIAWaitForDesktopElementincludeChildProcesses != null)
                {
                    uIAWaitForDesktopElement["IncludeChildProcesses"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementincludeChildProcesses);
                    uIAWaitForDesktopElementpropCount++;
                }

                uIAWaitForDesktopElementpropCount++;
            }
            else
            {
                uIAWaitForDesktopElement["IncludeChildProcesses"] = false;
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementraiseExceptionIfElementNotFound != null)
            {
                if (uIAWaitForDesktopElementraiseExceptionIfElementNotFound != null)
                {
                    uIAWaitForDesktopElement["RaiseExceptionIfElementNotFound"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementraiseExceptionIfElementNotFound);
                    uIAWaitForDesktopElementpropCount++;
                }

                uIAWaitForDesktopElementpropCount++;
            }
            else
            {
                uIAWaitForDesktopElement["RaiseExceptionIfElementNotFound"] = false;
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementmaxElementsToSearch != null)
            {
                if (uIAWaitForDesktopElementmaxElementsToSearch != null)
                {
                    uIAWaitForDesktopElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementmaxElementsToSearch);
                    uIAWaitForDesktopElementpropCount++;
                }

                uIAWaitForDesktopElementpropCount++;
            }
            else
            {
                uIAWaitForDesktopElement["MaxElementsToSearch"] = 0;
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementmaxRelativeSearchDepth != null)
            {
                if (uIAWaitForDesktopElementmaxRelativeSearchDepth != null)
                {
                    uIAWaitForDesktopElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementmaxRelativeSearchDepth);
                    uIAWaitForDesktopElementpropCount++;
                }

                uIAWaitForDesktopElementpropCount++;
            }
            else
            {
                uIAWaitForDesktopElement["MaxRelativeSearchDepth"] = 0;
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIAWaitForDesktopElementmaxChildElementsToSearchPerNode != null)
                {
                    uIAWaitForDesktopElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementmaxChildElementsToSearchPerNode);
                    uIAWaitForDesktopElementpropCount++;
                }

                uIAWaitForDesktopElementpropCount++;
            }
            else
            {
                uIAWaitForDesktopElement["MaxChildElementsToSearchPerNode"] = 0;
                uIAWaitForDesktopElementpropCount++;
            }

            if (uIAWaitForDesktopElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAWaitForDesktopElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementelementLocalizedControlTypesNotToTraverse);
                uIAWaitForDesktopElementpropCount++;
            }

            uIAWaitForDesktopElementpropCount++;
            uIAWaitForDesktopElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementworkflow);
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
            uIAWaitForElementToNotExist["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementToNotExistparentWindowHandle);
            if (uIAWaitForElementToNotExistsearchElementName != null)
            {
                uIAWaitForElementToNotExist["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementToNotExistsearchElementName);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistsearchElementClassName != null)
            {
                uIAWaitForElementToNotExist["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementToNotExistsearchElementClassName);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistsearchElementAutomationId != null)
            {
                uIAWaitForElementToNotExist["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementToNotExistsearchElementAutomationId);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistsearchLocalizedControlType != null)
            {
                uIAWaitForElementToNotExist["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementToNotExistsearchLocalizedControlType);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistsearchProcessId != null)
            {
                uIAWaitForElementToNotExist["SearchProcessId"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementToNotExistsearchProcessId);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistsearchSubTree != null)
            {
                if (uIAWaitForElementToNotExistsearchSubTree != null)
                {
                    uIAWaitForElementToNotExist["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementToNotExistsearchSubTree);
                    uIAWaitForElementToNotExistpropCount++;
                }

                uIAWaitForElementToNotExistpropCount++;
            }
            else
            {
                uIAWaitForElementToNotExist["SearchSubTree"] = true;
                uIAWaitForElementToNotExistpropCount++;
            }

            uIAWaitForElementToNotExistpropCount++;
            uIAWaitForElementToNotExist["SecondsToWait"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementToNotExistsecondsToWait);
            if (uIAWaitForElementToNotExistmatchIndex != null)
            {
                if (uIAWaitForElementToNotExistmatchIndex != null)
                {
                    uIAWaitForElementToNotExist["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementToNotExistmatchIndex);
                    uIAWaitForElementToNotExistpropCount++;
                }

                uIAWaitForElementToNotExistpropCount++;
            }
            else
            {
                uIAWaitForElementToNotExist["MatchIndex"] = 1;
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistsearchFilter != null)
            {
                uIAWaitForElementToNotExist["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementToNotExistsearchFilter);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistsortByColumn != null)
            {
                uIAWaitForElementToNotExist["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementToNotExistsortByColumn);
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistmatchIndexAscending != null)
            {
                if (uIAWaitForElementToNotExistmatchIndexAscending != null)
                {
                    uIAWaitForElementToNotExist["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementToNotExistmatchIndexAscending);
                    uIAWaitForElementToNotExistpropCount++;
                }

                uIAWaitForElementToNotExistpropCount++;
            }
            else
            {
                uIAWaitForElementToNotExist["MatchIndexAscending"] = true;
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistincludeChildProcesses != null)
            {
                if (uIAWaitForElementToNotExistincludeChildProcesses != null)
                {
                    uIAWaitForElementToNotExist["IncludeChildProcesses"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementToNotExistincludeChildProcesses);
                    uIAWaitForElementToNotExistpropCount++;
                }

                uIAWaitForElementToNotExistpropCount++;
            }
            else
            {
                uIAWaitForElementToNotExist["IncludeChildProcesses"] = false;
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistraiseExceptionIfElementStillExists != null)
            {
                if (uIAWaitForElementToNotExistraiseExceptionIfElementStillExists != null)
                {
                    uIAWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementToNotExistraiseExceptionIfElementStillExists);
                    uIAWaitForElementToNotExistpropCount++;
                }

                uIAWaitForElementToNotExistpropCount++;
            }
            else
            {
                uIAWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = false;
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistmaxElementsToSearch != null)
            {
                if (uIAWaitForElementToNotExistmaxElementsToSearch != null)
                {
                    uIAWaitForElementToNotExist["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementToNotExistmaxElementsToSearch);
                    uIAWaitForElementToNotExistpropCount++;
                }

                uIAWaitForElementToNotExistpropCount++;
            }
            else
            {
                uIAWaitForElementToNotExist["MaxElementsToSearch"] = 0;
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistmaxRelativeSearchDepth != null)
            {
                if (uIAWaitForElementToNotExistmaxRelativeSearchDepth != null)
                {
                    uIAWaitForElementToNotExist["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementToNotExistmaxRelativeSearchDepth);
                    uIAWaitForElementToNotExistpropCount++;
                }

                uIAWaitForElementToNotExistpropCount++;
            }
            else
            {
                uIAWaitForElementToNotExist["MaxRelativeSearchDepth"] = 0;
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistmaxChildElementsToSearchPerNode != null)
            {
                if (uIAWaitForElementToNotExistmaxChildElementsToSearchPerNode != null)
                {
                    uIAWaitForElementToNotExist["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementToNotExistmaxChildElementsToSearchPerNode);
                    uIAWaitForElementToNotExistpropCount++;
                }

                uIAWaitForElementToNotExistpropCount++;
            }
            else
            {
                uIAWaitForElementToNotExist["MaxChildElementsToSearchPerNode"] = 0;
                uIAWaitForElementToNotExistpropCount++;
            }

            if (uIAWaitForElementToNotExistelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAWaitForElementToNotExist["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementToNotExistelementLocalizedControlTypesNotToTraverse);
                uIAWaitForElementToNotExistpropCount++;
            }

            uIAWaitForElementToNotExistpropCount++;
            uIAWaitForElementToNotExist["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAWaitForElementToNotExistworkflow);
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
                uIAWaitForDesktopElementToNotExist["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistsearchElementName);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistsearchElementClassName != null)
            {
                uIAWaitForDesktopElementToNotExist["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistsearchElementClassName);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistsearchElementAutomationId != null)
            {
                uIAWaitForDesktopElementToNotExist["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistsearchElementAutomationId);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistsearchLocalizedControlType != null)
            {
                uIAWaitForDesktopElementToNotExist["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistsearchLocalizedControlType);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistsearchProcessId != null)
            {
                uIAWaitForDesktopElementToNotExist["SearchProcessId"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistsearchProcessId);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistsearchSubTree != null)
            {
                if (uIAWaitForDesktopElementToNotExistsearchSubTree != null)
                {
                    uIAWaitForDesktopElementToNotExist["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistsearchSubTree);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                uIAWaitForDesktopElementToNotExistpropCount++;
            }
            else
            {
                uIAWaitForDesktopElementToNotExist["SearchSubTree"] = true;
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            uIAWaitForDesktopElementToNotExistpropCount++;
            uIAWaitForDesktopElementToNotExist["SecondsToWait"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistsecondsToWait);
            if (uIAWaitForDesktopElementToNotExistmatchIndex != null)
            {
                if (uIAWaitForDesktopElementToNotExistmatchIndex != null)
                {
                    uIAWaitForDesktopElementToNotExist["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistmatchIndex);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                uIAWaitForDesktopElementToNotExistpropCount++;
            }
            else
            {
                uIAWaitForDesktopElementToNotExist["MatchIndex"] = 1;
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistsearchFilter != null)
            {
                uIAWaitForDesktopElementToNotExist["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistsearchFilter);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistsortByColumn != null)
            {
                uIAWaitForDesktopElementToNotExist["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistsortByColumn);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistmatchIndexAscending != null)
            {
                if (uIAWaitForDesktopElementToNotExistmatchIndexAscending != null)
                {
                    uIAWaitForDesktopElementToNotExist["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistmatchIndexAscending);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                uIAWaitForDesktopElementToNotExistpropCount++;
            }
            else
            {
                uIAWaitForDesktopElementToNotExist["MatchIndexAscending"] = true;
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistincludeChildProcesses != null)
            {
                if (uIAWaitForDesktopElementToNotExistincludeChildProcesses != null)
                {
                    uIAWaitForDesktopElementToNotExist["IncludeChildProcesses"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistincludeChildProcesses);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                uIAWaitForDesktopElementToNotExistpropCount++;
            }
            else
            {
                uIAWaitForDesktopElementToNotExist["IncludeChildProcesses"] = false;
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists != null)
            {
                if (uIAWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists != null)
                {
                    uIAWaitForDesktopElementToNotExist["RaiseExceptionIfElementStillExists"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                uIAWaitForDesktopElementToNotExistpropCount++;
            }
            else
            {
                uIAWaitForDesktopElementToNotExist["RaiseExceptionIfElementStillExists"] = false;
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistmaxElementsToSearch != null)
            {
                if (uIAWaitForDesktopElementToNotExistmaxElementsToSearch != null)
                {
                    uIAWaitForDesktopElementToNotExist["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistmaxElementsToSearch);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                uIAWaitForDesktopElementToNotExistpropCount++;
            }
            else
            {
                uIAWaitForDesktopElementToNotExist["MaxElementsToSearch"] = 0;
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistmaxRelativeSearchDepth != null)
            {
                if (uIAWaitForDesktopElementToNotExistmaxRelativeSearchDepth != null)
                {
                    uIAWaitForDesktopElementToNotExist["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistmaxRelativeSearchDepth);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                uIAWaitForDesktopElementToNotExistpropCount++;
            }
            else
            {
                uIAWaitForDesktopElementToNotExist["MaxRelativeSearchDepth"] = 0;
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistmaxChildElementsToSearchPerNode != null)
            {
                if (uIAWaitForDesktopElementToNotExistmaxChildElementsToSearchPerNode != null)
                {
                    uIAWaitForDesktopElementToNotExist["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistmaxChildElementsToSearchPerNode);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                uIAWaitForDesktopElementToNotExistpropCount++;
            }
            else
            {
                uIAWaitForDesktopElementToNotExist["MaxChildElementsToSearchPerNode"] = 0;
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            if (uIAWaitForDesktopElementToNotExistelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAWaitForDesktopElementToNotExist["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistelementLocalizedControlTypesNotToTraverse);
                uIAWaitForDesktopElementToNotExistpropCount++;
            }

            uIAWaitForDesktopElementToNotExistpropCount++;
            uIAWaitForDesktopElementToNotExist["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistworkflow);
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
            uIAPressElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAPressElementparentWindowHandle);
            if (uIAPressElementsearchElementName != null)
            {
                uIAPressElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAPressElementsearchElementName);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementsearchElementClassName != null)
            {
                uIAPressElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAPressElementsearchElementClassName);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementsearchElementAutomationId != null)
            {
                uIAPressElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAPressElementsearchElementAutomationId);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementsearchLocalizedControlType != null)
            {
                uIAPressElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAPressElementsearchLocalizedControlType);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementsearchSubTree != null)
            {
                if (uIAPressElementsearchSubTree != null)
                {
                    uIAPressElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAPressElementsearchSubTree);
                    uIAPressElementpropCount++;
                }

                uIAPressElementpropCount++;
            }
            else
            {
                uIAPressElement["SearchSubTree"] = true;
                uIAPressElementpropCount++;
            }

            if (uIAPressElementwait != null)
            {
                if (uIAPressElementwait != null)
                {
                    uIAPressElement["Wait"] = CSharpExpressionConverter.ConvertToken(uIAPressElementwait);
                    uIAPressElementpropCount++;
                }

                uIAPressElementpropCount++;
            }
            else
            {
                uIAPressElement["Wait"] = false;
                uIAPressElementpropCount++;
            }

            if (uIAPressElementwin32ClickButton != null)
            {
                if (uIAPressElementwin32ClickButton != null)
                {
                    uIAPressElement["Win32ClickButton"] = CSharpExpressionConverter.ConvertToken(uIAPressElementwin32ClickButton);
                    uIAPressElementpropCount++;
                }

                uIAPressElementpropCount++;
            }
            else
            {
                uIAPressElement["Win32ClickButton"] = false;
                uIAPressElementpropCount++;
            }

            if (uIAPressElementmatchIndex != null)
            {
                if (uIAPressElementmatchIndex != null)
                {
                    uIAPressElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAPressElementmatchIndex);
                    uIAPressElementpropCount++;
                }

                uIAPressElementpropCount++;
            }
            else
            {
                uIAPressElement["MatchIndex"] = 1;
                uIAPressElementpropCount++;
            }

            if (uIAPressElementsearchFilter != null)
            {
                uIAPressElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAPressElementsearchFilter);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementsortByColumn != null)
            {
                uIAPressElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAPressElementsortByColumn);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementmatchIndexAscending != null)
            {
                if (uIAPressElementmatchIndexAscending != null)
                {
                    uIAPressElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAPressElementmatchIndexAscending);
                    uIAPressElementpropCount++;
                }

                uIAPressElementpropCount++;
            }
            else
            {
                uIAPressElement["MatchIndexAscending"] = true;
                uIAPressElementpropCount++;
            }

            if (uIAPressElementmaxElementsToSearch != null)
            {
                if (uIAPressElementmaxElementsToSearch != null)
                {
                    uIAPressElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAPressElementmaxElementsToSearch);
                    uIAPressElementpropCount++;
                }

                uIAPressElementpropCount++;
            }
            else
            {
                uIAPressElement["MaxElementsToSearch"] = 0;
                uIAPressElementpropCount++;
            }

            if (uIAPressElementmaxRelativeSearchDepth != null)
            {
                if (uIAPressElementmaxRelativeSearchDepth != null)
                {
                    uIAPressElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAPressElementmaxRelativeSearchDepth);
                    uIAPressElementpropCount++;
                }

                uIAPressElementpropCount++;
            }
            else
            {
                uIAPressElement["MaxRelativeSearchDepth"] = 0;
                uIAPressElementpropCount++;
            }

            if (uIAPressElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIAPressElementmaxChildElementsToSearchPerNode != null)
                {
                    uIAPressElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAPressElementmaxChildElementsToSearchPerNode);
                    uIAPressElementpropCount++;
                }

                uIAPressElementpropCount++;
            }
            else
            {
                uIAPressElement["MaxChildElementsToSearchPerNode"] = 0;
                uIAPressElementpropCount++;
            }

            if (uIAPressElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAPressElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAPressElementelementLocalizedControlTypesNotToTraverse);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementtryInvokePattern != null)
            {
                if (uIAPressElementtryInvokePattern != null)
                {
                    uIAPressElement["TryInvokePattern"] = CSharpExpressionConverter.ConvertToken(uIAPressElementtryInvokePattern);
                    uIAPressElementpropCount++;
                }

                uIAPressElementpropCount++;
            }
            else
            {
                uIAPressElement["TryInvokePattern"] = true;
                uIAPressElementpropCount++;
            }

            if (uIAPressElementtryLegacyPattern != null)
            {
                if (uIAPressElementtryLegacyPattern != null)
                {
                    uIAPressElement["TryLegacyPattern"] = CSharpExpressionConverter.ConvertToken(uIAPressElementtryLegacyPattern);
                    uIAPressElementpropCount++;
                }

                uIAPressElementpropCount++;
            }
            else
            {
                uIAPressElement["TryLegacyPattern"] = false;
                uIAPressElementpropCount++;
            }

            uIAPressElementpropCount++;
            uIAPressElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAPressElementworkflow);
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
            uIAGlobalMouseClickOnElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementparentWindowHandle);
            if (uIAGlobalMouseClickOnElementsearchElementName != null)
            {
                uIAGlobalMouseClickOnElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementsearchElementName);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementsearchElementClassName != null)
            {
                uIAGlobalMouseClickOnElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementsearchElementClassName);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementsearchElementAutomationId != null)
            {
                uIAGlobalMouseClickOnElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementsearchElementAutomationId);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementsearchLocalizedControlType != null)
            {
                uIAGlobalMouseClickOnElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementsearchLocalizedControlType);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementsearchSubTree != null)
            {
                if (uIAGlobalMouseClickOnElementsearchSubTree != null)
                {
                    uIAGlobalMouseClickOnElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementsearchSubTree);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                uIAGlobalMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalMouseClickOnElement["SearchSubTree"] = true;
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementfocusElementFirst != null)
            {
                if (uIAGlobalMouseClickOnElementfocusElementFirst != null)
                {
                    uIAGlobalMouseClickOnElement["FocusElementFirst"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementfocusElementFirst);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                uIAGlobalMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalMouseClickOnElement["FocusElementFirst"] = true;
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementmatchIndex != null)
            {
                if (uIAGlobalMouseClickOnElementmatchIndex != null)
                {
                    uIAGlobalMouseClickOnElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementmatchIndex);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                uIAGlobalMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalMouseClickOnElement["MatchIndex"] = 1;
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementsearchFilter != null)
            {
                uIAGlobalMouseClickOnElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementsearchFilter);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementsortByColumn != null)
            {
                uIAGlobalMouseClickOnElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementsortByColumn);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementmatchIndexAscending != null)
            {
                if (uIAGlobalMouseClickOnElementmatchIndexAscending != null)
                {
                    uIAGlobalMouseClickOnElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementmatchIndexAscending);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                uIAGlobalMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalMouseClickOnElement["MatchIndexAscending"] = true;
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementclickOffsetX != null)
            {
                if (uIAGlobalMouseClickOnElementclickOffsetX != null)
                {
                    uIAGlobalMouseClickOnElement["ClickOffsetX"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementclickOffsetX);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                uIAGlobalMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalMouseClickOnElement["ClickOffsetX"] = 0;
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementclickOffsetY != null)
            {
                if (uIAGlobalMouseClickOnElementclickOffsetY != null)
                {
                    uIAGlobalMouseClickOnElement["ClickOffsetY"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementclickOffsetY);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                uIAGlobalMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalMouseClickOnElement["ClickOffsetY"] = 0;
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementoffsetRelativeTo != null)
            {
                uIAGlobalMouseClickOnElement["OffsetRelativeTo"] = CSharpExpressionConverter.Convert(uIAGlobalMouseClickOnElementoffsetRelativeTo);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementmaxElementsToSearch != null)
            {
                if (uIAGlobalMouseClickOnElementmaxElementsToSearch != null)
                {
                    uIAGlobalMouseClickOnElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementmaxElementsToSearch);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                uIAGlobalMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalMouseClickOnElement["MaxElementsToSearch"] = 0;
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementmaxRelativeSearchDepth != null)
            {
                if (uIAGlobalMouseClickOnElementmaxRelativeSearchDepth != null)
                {
                    uIAGlobalMouseClickOnElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementmaxRelativeSearchDepth);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                uIAGlobalMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalMouseClickOnElement["MaxRelativeSearchDepth"] = 0;
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIAGlobalMouseClickOnElementmaxChildElementsToSearchPerNode != null)
                {
                    uIAGlobalMouseClickOnElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementmaxChildElementsToSearchPerNode);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                uIAGlobalMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalMouseClickOnElement["MaxChildElementsToSearchPerNode"] = 0;
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGlobalMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementelementLocalizedControlTypesNotToTraverse);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
            {
                if (uIAGlobalMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                {
                    uIAGlobalMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementvalidateClickablePointWithinElementBoundary);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                uIAGlobalMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = false;
                uIAGlobalMouseClickOnElementpropCount++;
            }

            uIAGlobalMouseClickOnElementpropCount++;
            uIAGlobalMouseClickOnElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementworkflow);
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
            uIAGlobalRightMouseClickOnElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementparentWindowHandle);
            if (uIAGlobalRightMouseClickOnElementsearchElementName != null)
            {
                uIAGlobalRightMouseClickOnElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementsearchElementName);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementsearchElementClassName != null)
            {
                uIAGlobalRightMouseClickOnElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementsearchElementClassName);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementsearchElementAutomationId != null)
            {
                uIAGlobalRightMouseClickOnElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementsearchElementAutomationId);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementsearchLocalizedControlType != null)
            {
                uIAGlobalRightMouseClickOnElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementsearchLocalizedControlType);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementsearchSubTree != null)
            {
                if (uIAGlobalRightMouseClickOnElementsearchSubTree != null)
                {
                    uIAGlobalRightMouseClickOnElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementsearchSubTree);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                uIAGlobalRightMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalRightMouseClickOnElement["SearchSubTree"] = true;
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementfocusElementFirst != null)
            {
                if (uIAGlobalRightMouseClickOnElementfocusElementFirst != null)
                {
                    uIAGlobalRightMouseClickOnElement["FocusElementFirst"] = CSharpExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementfocusElementFirst);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                uIAGlobalRightMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalRightMouseClickOnElement["FocusElementFirst"] = true;
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementmatchIndex != null)
            {
                if (uIAGlobalRightMouseClickOnElementmatchIndex != null)
                {
                    uIAGlobalRightMouseClickOnElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementmatchIndex);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                uIAGlobalRightMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalRightMouseClickOnElement["MatchIndex"] = 1;
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementsearchFilter != null)
            {
                uIAGlobalRightMouseClickOnElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementsearchFilter);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementsortByColumn != null)
            {
                uIAGlobalRightMouseClickOnElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementsortByColumn);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementmatchIndexAscending != null)
            {
                if (uIAGlobalRightMouseClickOnElementmatchIndexAscending != null)
                {
                    uIAGlobalRightMouseClickOnElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementmatchIndexAscending);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                uIAGlobalRightMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalRightMouseClickOnElement["MatchIndexAscending"] = true;
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementclickOffsetX != null)
            {
                if (uIAGlobalRightMouseClickOnElementclickOffsetX != null)
                {
                    uIAGlobalRightMouseClickOnElement["ClickOffsetX"] = CSharpExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementclickOffsetX);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                uIAGlobalRightMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalRightMouseClickOnElement["ClickOffsetX"] = 0;
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementclickOffsetY != null)
            {
                if (uIAGlobalRightMouseClickOnElementclickOffsetY != null)
                {
                    uIAGlobalRightMouseClickOnElement["ClickOffsetY"] = CSharpExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementclickOffsetY);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                uIAGlobalRightMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalRightMouseClickOnElement["ClickOffsetY"] = 0;
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementoffsetRelativeTo != null)
            {
                uIAGlobalRightMouseClickOnElement["OffsetRelativeTo"] = CSharpExpressionConverter.Convert(uIAGlobalRightMouseClickOnElementoffsetRelativeTo);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementmaxElementsToSearch != null)
            {
                if (uIAGlobalRightMouseClickOnElementmaxElementsToSearch != null)
                {
                    uIAGlobalRightMouseClickOnElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementmaxElementsToSearch);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                uIAGlobalRightMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalRightMouseClickOnElement["MaxElementsToSearch"] = 0;
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementmaxRelativeSearchDepth != null)
            {
                if (uIAGlobalRightMouseClickOnElementmaxRelativeSearchDepth != null)
                {
                    uIAGlobalRightMouseClickOnElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementmaxRelativeSearchDepth);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                uIAGlobalRightMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalRightMouseClickOnElement["MaxRelativeSearchDepth"] = 0;
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIAGlobalRightMouseClickOnElementmaxChildElementsToSearchPerNode != null)
                {
                    uIAGlobalRightMouseClickOnElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementmaxChildElementsToSearchPerNode);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                uIAGlobalRightMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalRightMouseClickOnElement["MaxChildElementsToSearchPerNode"] = 0;
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGlobalRightMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementelementLocalizedControlTypesNotToTraverse);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
            {
                if (uIAGlobalRightMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                {
                    uIAGlobalRightMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = CSharpExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementvalidateClickablePointWithinElementBoundary);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                uIAGlobalRightMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalRightMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = false;
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            uIAGlobalRightMouseClickOnElementpropCount++;
            uIAGlobalRightMouseClickOnElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementworkflow);
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
            uIAGlobalMiddleMouseClickOnElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementparentWindowHandle);
            if (uIAGlobalMiddleMouseClickOnElementsearchElementName != null)
            {
                uIAGlobalMiddleMouseClickOnElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementsearchElementName);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementsearchElementClassName != null)
            {
                uIAGlobalMiddleMouseClickOnElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementsearchElementClassName);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementsearchElementAutomationId != null)
            {
                uIAGlobalMiddleMouseClickOnElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementsearchElementAutomationId);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementsearchLocalizedControlType != null)
            {
                uIAGlobalMiddleMouseClickOnElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementsearchLocalizedControlType);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementsearchSubTree != null)
            {
                if (uIAGlobalMiddleMouseClickOnElementsearchSubTree != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementsearchSubTree);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalMiddleMouseClickOnElement["SearchSubTree"] = true;
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementfocusElementFirst != null)
            {
                if (uIAGlobalMiddleMouseClickOnElementfocusElementFirst != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["FocusElementFirst"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementfocusElementFirst);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalMiddleMouseClickOnElement["FocusElementFirst"] = true;
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementmatchIndex != null)
            {
                if (uIAGlobalMiddleMouseClickOnElementmatchIndex != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementmatchIndex);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalMiddleMouseClickOnElement["MatchIndex"] = 1;
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementsearchFilter != null)
            {
                uIAGlobalMiddleMouseClickOnElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementsearchFilter);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementsortByColumn != null)
            {
                uIAGlobalMiddleMouseClickOnElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementsortByColumn);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementmatchIndexAscending != null)
            {
                if (uIAGlobalMiddleMouseClickOnElementmatchIndexAscending != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementmatchIndexAscending);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalMiddleMouseClickOnElement["MatchIndexAscending"] = true;
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementclickOffsetX != null)
            {
                if (uIAGlobalMiddleMouseClickOnElementclickOffsetX != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["ClickOffsetX"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementclickOffsetX);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalMiddleMouseClickOnElement["ClickOffsetX"] = 0;
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementclickOffsetY != null)
            {
                if (uIAGlobalMiddleMouseClickOnElementclickOffsetY != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["ClickOffsetY"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementclickOffsetY);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalMiddleMouseClickOnElement["ClickOffsetY"] = 0;
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementoffsetRelativeTo != null)
            {
                uIAGlobalMiddleMouseClickOnElement["OffsetRelativeTo"] = CSharpExpressionConverter.Convert(uIAGlobalMiddleMouseClickOnElementoffsetRelativeTo);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementmaxElementsToSearch != null)
            {
                if (uIAGlobalMiddleMouseClickOnElementmaxElementsToSearch != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementmaxElementsToSearch);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalMiddleMouseClickOnElement["MaxElementsToSearch"] = 0;
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementmaxRelativeSearchDepth != null)
            {
                if (uIAGlobalMiddleMouseClickOnElementmaxRelativeSearchDepth != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementmaxRelativeSearchDepth);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalMiddleMouseClickOnElement["MaxRelativeSearchDepth"] = 0;
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIAGlobalMiddleMouseClickOnElementmaxChildElementsToSearchPerNode != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementmaxChildElementsToSearchPerNode);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalMiddleMouseClickOnElement["MaxChildElementsToSearchPerNode"] = 0;
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGlobalMiddleMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementelementLocalizedControlTypesNotToTraverse);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
            {
                if (uIAGlobalMiddleMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementvalidateClickablePointWithinElementBoundary);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalMiddleMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = false;
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            uIAGlobalMiddleMouseClickOnElementpropCount++;
            uIAGlobalMiddleMouseClickOnElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementworkflow);
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
            uIAGlobalDoubleLeftMouseClickOnElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementparentWindowHandle);
            if (uIAGlobalDoubleLeftMouseClickOnElementsearchElementName != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementsearchElementName);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementsearchElementClassName != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementsearchElementClassName);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementsearchElementAutomationId != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementsearchElementAutomationId);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementsearchLocalizedControlType != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementsearchLocalizedControlType);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementsearchSubTree != null)
            {
                if (uIAGlobalDoubleLeftMouseClickOnElementsearchSubTree != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementsearchSubTree);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalDoubleLeftMouseClickOnElement["SearchSubTree"] = true;
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds != null)
            {
                if (uIAGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["DelayInMilliseconds"] = CSharpExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalDoubleLeftMouseClickOnElement["DelayInMilliseconds"] = 10;
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementfocusElementFirst != null)
            {
                if (uIAGlobalDoubleLeftMouseClickOnElementfocusElementFirst != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["FocusElementFirst"] = CSharpExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementfocusElementFirst);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalDoubleLeftMouseClickOnElement["FocusElementFirst"] = true;
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementmatchIndex != null)
            {
                if (uIAGlobalDoubleLeftMouseClickOnElementmatchIndex != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementmatchIndex);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalDoubleLeftMouseClickOnElement["MatchIndex"] = 1;
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementsearchFilter != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementsearchFilter);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementsortByColumn != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementsortByColumn);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementmatchIndexAscending != null)
            {
                if (uIAGlobalDoubleLeftMouseClickOnElementmatchIndexAscending != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementmatchIndexAscending);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalDoubleLeftMouseClickOnElement["MatchIndexAscending"] = true;
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementclickOffsetX != null)
            {
                if (uIAGlobalDoubleLeftMouseClickOnElementclickOffsetX != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["ClickOffsetX"] = CSharpExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementclickOffsetX);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalDoubleLeftMouseClickOnElement["ClickOffsetX"] = 0;
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementclickOffsetY != null)
            {
                if (uIAGlobalDoubleLeftMouseClickOnElementclickOffsetY != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["ClickOffsetY"] = CSharpExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementclickOffsetY);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalDoubleLeftMouseClickOnElement["ClickOffsetY"] = 0;
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["OffsetRelativeTo"] = CSharpExpressionConverter.Convert(uIAGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementmaxElementsToSearch != null)
            {
                if (uIAGlobalDoubleLeftMouseClickOnElementmaxElementsToSearch != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementmaxElementsToSearch);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalDoubleLeftMouseClickOnElement["MaxElementsToSearch"] = 0;
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementmaxRelativeSearchDepth != null)
            {
                if (uIAGlobalDoubleLeftMouseClickOnElementmaxRelativeSearchDepth != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementmaxRelativeSearchDepth);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalDoubleLeftMouseClickOnElement["MaxRelativeSearchDepth"] = 0;
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIAGlobalDoubleLeftMouseClickOnElementmaxChildElementsToSearchPerNode != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementmaxChildElementsToSearchPerNode);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalDoubleLeftMouseClickOnElement["MaxChildElementsToSearchPerNode"] = 0;
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGlobalDoubleLeftMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementelementLocalizedControlTypesNotToTraverse);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
            {
                if (uIAGlobalDoubleLeftMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = CSharpExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementvalidateClickablePointWithinElementBoundary);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }
            else
            {
                uIAGlobalDoubleLeftMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = false;
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            uIAGlobalDoubleLeftMouseClickOnElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementworkflow);
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
            uIASelectElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIASelectElementparentWindowHandle);
            if (uIASelectElementsearchElementName != null)
            {
                uIASelectElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIASelectElementsearchElementName);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementsearchElementClassName != null)
            {
                uIASelectElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIASelectElementsearchElementClassName);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementsearchElementAutomationId != null)
            {
                uIASelectElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIASelectElementsearchElementAutomationId);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementsearchLocalizedControlType != null)
            {
                uIASelectElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIASelectElementsearchLocalizedControlType);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementsearchSubTree != null)
            {
                if (uIASelectElementsearchSubTree != null)
                {
                    uIASelectElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIASelectElementsearchSubTree);
                    uIASelectElementpropCount++;
                }

                uIASelectElementpropCount++;
            }
            else
            {
                uIASelectElement["SearchSubTree"] = true;
                uIASelectElementpropCount++;
            }

            if (uIASelectElementmatchIndex != null)
            {
                if (uIASelectElementmatchIndex != null)
                {
                    uIASelectElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIASelectElementmatchIndex);
                    uIASelectElementpropCount++;
                }

                uIASelectElementpropCount++;
            }
            else
            {
                uIASelectElement["MatchIndex"] = 1;
                uIASelectElementpropCount++;
            }

            if (uIASelectElementsearchFilter != null)
            {
                uIASelectElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIASelectElementsearchFilter);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementsortByColumn != null)
            {
                uIASelectElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIASelectElementsortByColumn);
                uIASelectElementpropCount++;
            }

            if (uIASelectElementmatchIndexAscending != null)
            {
                if (uIASelectElementmatchIndexAscending != null)
                {
                    uIASelectElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIASelectElementmatchIndexAscending);
                    uIASelectElementpropCount++;
                }

                uIASelectElementpropCount++;
            }
            else
            {
                uIASelectElement["MatchIndexAscending"] = true;
                uIASelectElementpropCount++;
            }

            if (uIASelectElementmaxElementsToSearch != null)
            {
                if (uIASelectElementmaxElementsToSearch != null)
                {
                    uIASelectElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIASelectElementmaxElementsToSearch);
                    uIASelectElementpropCount++;
                }

                uIASelectElementpropCount++;
            }
            else
            {
                uIASelectElement["MaxElementsToSearch"] = 0;
                uIASelectElementpropCount++;
            }

            if (uIASelectElementmaxRelativeSearchDepth != null)
            {
                if (uIASelectElementmaxRelativeSearchDepth != null)
                {
                    uIASelectElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIASelectElementmaxRelativeSearchDepth);
                    uIASelectElementpropCount++;
                }

                uIASelectElementpropCount++;
            }
            else
            {
                uIASelectElement["MaxRelativeSearchDepth"] = 0;
                uIASelectElementpropCount++;
            }

            if (uIASelectElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIASelectElementmaxChildElementsToSearchPerNode != null)
                {
                    uIASelectElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIASelectElementmaxChildElementsToSearchPerNode);
                    uIASelectElementpropCount++;
                }

                uIASelectElementpropCount++;
            }
            else
            {
                uIASelectElement["MaxChildElementsToSearchPerNode"] = 0;
                uIASelectElementpropCount++;
            }

            if (uIASelectElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIASelectElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIASelectElementelementLocalizedControlTypesNotToTraverse);
                uIASelectElementpropCount++;
            }

            uIASelectElementpropCount++;
            uIASelectElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIASelectElementworkflow);
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
            uIAInputPasswordIntoElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAInputPasswordIntoElementparentWindowHandle);
            if (uIAInputPasswordIntoElementsearchElementName != null)
            {
                uIAInputPasswordIntoElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAInputPasswordIntoElementsearchElementName);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementsearchElementClassName != null)
            {
                uIAInputPasswordIntoElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAInputPasswordIntoElementsearchElementClassName);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementsearchElementAutomationId != null)
            {
                uIAInputPasswordIntoElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAInputPasswordIntoElementsearchElementAutomationId);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementsearchLocalizedControlType != null)
            {
                uIAInputPasswordIntoElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAInputPasswordIntoElementsearchLocalizedControlType);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementsearchSubTree != null)
            {
                if (uIAInputPasswordIntoElementsearchSubTree != null)
                {
                    uIAInputPasswordIntoElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAInputPasswordIntoElementsearchSubTree);
                    uIAInputPasswordIntoElementpropCount++;
                }

                uIAInputPasswordIntoElementpropCount++;
            }
            else
            {
                uIAInputPasswordIntoElement["SearchSubTree"] = true;
                uIAInputPasswordIntoElementpropCount++;
            }

            uIAInputPasswordIntoElementpropCount++;
            uIAInputPasswordIntoElement["PasswordToInput"] = CSharpExpressionConverter.ConvertToken(uIAInputPasswordIntoElementpasswordToInput);
            if (uIAInputPasswordIntoElementmatchIndex != null)
            {
                if (uIAInputPasswordIntoElementmatchIndex != null)
                {
                    uIAInputPasswordIntoElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAInputPasswordIntoElementmatchIndex);
                    uIAInputPasswordIntoElementpropCount++;
                }

                uIAInputPasswordIntoElementpropCount++;
            }
            else
            {
                uIAInputPasswordIntoElement["MatchIndex"] = 1;
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementsearchFilter != null)
            {
                uIAInputPasswordIntoElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAInputPasswordIntoElementsearchFilter);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementsortByColumn != null)
            {
                uIAInputPasswordIntoElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAInputPasswordIntoElementsortByColumn);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementmatchIndexAscending != null)
            {
                if (uIAInputPasswordIntoElementmatchIndexAscending != null)
                {
                    uIAInputPasswordIntoElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAInputPasswordIntoElementmatchIndexAscending);
                    uIAInputPasswordIntoElementpropCount++;
                }

                uIAInputPasswordIntoElementpropCount++;
            }
            else
            {
                uIAInputPasswordIntoElement["MatchIndexAscending"] = true;
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementpasswordContainsStoredPassword != null)
            {
                if (uIAInputPasswordIntoElementpasswordContainsStoredPassword != null)
                {
                    uIAInputPasswordIntoElement["PasswordContainsStoredPassword"] = CSharpExpressionConverter.ConvertToken(uIAInputPasswordIntoElementpasswordContainsStoredPassword);
                    uIAInputPasswordIntoElementpropCount++;
                }

                uIAInputPasswordIntoElementpropCount++;
            }
            else
            {
                uIAInputPasswordIntoElement["PasswordContainsStoredPassword"] = false;
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementmaxElementsToSearch != null)
            {
                if (uIAInputPasswordIntoElementmaxElementsToSearch != null)
                {
                    uIAInputPasswordIntoElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAInputPasswordIntoElementmaxElementsToSearch);
                    uIAInputPasswordIntoElementpropCount++;
                }

                uIAInputPasswordIntoElementpropCount++;
            }
            else
            {
                uIAInputPasswordIntoElement["MaxElementsToSearch"] = 0;
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementmaxRelativeSearchDepth != null)
            {
                if (uIAInputPasswordIntoElementmaxRelativeSearchDepth != null)
                {
                    uIAInputPasswordIntoElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAInputPasswordIntoElementmaxRelativeSearchDepth);
                    uIAInputPasswordIntoElementpropCount++;
                }

                uIAInputPasswordIntoElementpropCount++;
            }
            else
            {
                uIAInputPasswordIntoElement["MaxRelativeSearchDepth"] = 0;
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIAInputPasswordIntoElementmaxChildElementsToSearchPerNode != null)
                {
                    uIAInputPasswordIntoElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAInputPasswordIntoElementmaxChildElementsToSearchPerNode);
                    uIAInputPasswordIntoElementpropCount++;
                }

                uIAInputPasswordIntoElementpropCount++;
            }
            else
            {
                uIAInputPasswordIntoElement["MaxChildElementsToSearchPerNode"] = 0;
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAInputPasswordIntoElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAInputPasswordIntoElementelementLocalizedControlTypesNotToTraverse);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementtryValuePattern != null)
            {
                if (uIAInputPasswordIntoElementtryValuePattern != null)
                {
                    uIAInputPasswordIntoElement["TryValuePattern"] = CSharpExpressionConverter.ConvertToken(uIAInputPasswordIntoElementtryValuePattern);
                    uIAInputPasswordIntoElementpropCount++;
                }

                uIAInputPasswordIntoElementpropCount++;
            }
            else
            {
                uIAInputPasswordIntoElement["TryValuePattern"] = true;
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementtryLegacyPattern != null)
            {
                if (uIAInputPasswordIntoElementtryLegacyPattern != null)
                {
                    uIAInputPasswordIntoElement["TryLegacyPattern"] = CSharpExpressionConverter.ConvertToken(uIAInputPasswordIntoElementtryLegacyPattern);
                    uIAInputPasswordIntoElementpropCount++;
                }

                uIAInputPasswordIntoElementpropCount++;
            }
            else
            {
                uIAInputPasswordIntoElement["TryLegacyPattern"] = false;
                uIAInputPasswordIntoElementpropCount++;
            }

            uIAInputPasswordIntoElementpropCount++;
            uIAInputPasswordIntoElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAInputPasswordIntoElementworkflow);
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
            uIAInputTextIntoElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoElementparentWindowHandle);
            if (uIAInputTextIntoElementsearchElementName != null)
            {
                uIAInputTextIntoElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoElementsearchElementName);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementsearchElementClassName != null)
            {
                uIAInputTextIntoElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoElementsearchElementClassName);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementsearchElementAutomationId != null)
            {
                uIAInputTextIntoElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoElementsearchElementAutomationId);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementsearchLocalizedControlType != null)
            {
                uIAInputTextIntoElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoElementsearchLocalizedControlType);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementsearchSubTree != null)
            {
                if (uIAInputTextIntoElementsearchSubTree != null)
                {
                    uIAInputTextIntoElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoElementsearchSubTree);
                    uIAInputTextIntoElementpropCount++;
                }

                uIAInputTextIntoElementpropCount++;
            }
            else
            {
                uIAInputTextIntoElement["SearchSubTree"] = true;
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementtextToInput != null)
            {
                uIAInputTextIntoElement["TextToInput"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoElementtextToInput);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementmatchIndex != null)
            {
                if (uIAInputTextIntoElementmatchIndex != null)
                {
                    uIAInputTextIntoElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoElementmatchIndex);
                    uIAInputTextIntoElementpropCount++;
                }

                uIAInputTextIntoElementpropCount++;
            }
            else
            {
                uIAInputTextIntoElement["MatchIndex"] = 1;
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementsearchFilter != null)
            {
                uIAInputTextIntoElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoElementsearchFilter);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementsortByColumn != null)
            {
                uIAInputTextIntoElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoElementsortByColumn);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementmatchIndexAscending != null)
            {
                if (uIAInputTextIntoElementmatchIndexAscending != null)
                {
                    uIAInputTextIntoElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoElementmatchIndexAscending);
                    uIAInputTextIntoElementpropCount++;
                }

                uIAInputTextIntoElementpropCount++;
            }
            else
            {
                uIAInputTextIntoElement["MatchIndexAscending"] = true;
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementreplaceExistingValue != null)
            {
                if (uIAInputTextIntoElementreplaceExistingValue != null)
                {
                    uIAInputTextIntoElement["ReplaceExistingValue"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoElementreplaceExistingValue);
                    uIAInputTextIntoElementpropCount++;
                }

                uIAInputTextIntoElementpropCount++;
            }
            else
            {
                uIAInputTextIntoElement["ReplaceExistingValue"] = true;
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementinsertPosition != null)
            {
                if (uIAInputTextIntoElementinsertPosition != null)
                {
                    uIAInputTextIntoElement["InsertPosition"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoElementinsertPosition);
                    uIAInputTextIntoElementpropCount++;
                }

                uIAInputTextIntoElementpropCount++;
            }
            else
            {
                uIAInputTextIntoElement["InsertPosition"] = 0;
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementmaxElementsToSearch != null)
            {
                if (uIAInputTextIntoElementmaxElementsToSearch != null)
                {
                    uIAInputTextIntoElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoElementmaxElementsToSearch);
                    uIAInputTextIntoElementpropCount++;
                }

                uIAInputTextIntoElementpropCount++;
            }
            else
            {
                uIAInputTextIntoElement["MaxElementsToSearch"] = 0;
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementmaxRelativeSearchDepth != null)
            {
                if (uIAInputTextIntoElementmaxRelativeSearchDepth != null)
                {
                    uIAInputTextIntoElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoElementmaxRelativeSearchDepth);
                    uIAInputTextIntoElementpropCount++;
                }

                uIAInputTextIntoElementpropCount++;
            }
            else
            {
                uIAInputTextIntoElement["MaxRelativeSearchDepth"] = 0;
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIAInputTextIntoElementmaxChildElementsToSearchPerNode != null)
                {
                    uIAInputTextIntoElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoElementmaxChildElementsToSearchPerNode);
                    uIAInputTextIntoElementpropCount++;
                }

                uIAInputTextIntoElementpropCount++;
            }
            else
            {
                uIAInputTextIntoElement["MaxChildElementsToSearchPerNode"] = 0;
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAInputTextIntoElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoElementelementLocalizedControlTypesNotToTraverse);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementraiseExceptionIfInputValidationFails != null)
            {
                if (uIAInputTextIntoElementraiseExceptionIfInputValidationFails != null)
                {
                    uIAInputTextIntoElement["RaiseExceptionIfInputValidationFails"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoElementraiseExceptionIfInputValidationFails);
                    uIAInputTextIntoElementpropCount++;
                }

                uIAInputTextIntoElementpropCount++;
            }
            else
            {
                uIAInputTextIntoElement["RaiseExceptionIfInputValidationFails"] = false;
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementtryValuePattern != null)
            {
                if (uIAInputTextIntoElementtryValuePattern != null)
                {
                    uIAInputTextIntoElement["TryValuePattern"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoElementtryValuePattern);
                    uIAInputTextIntoElementpropCount++;
                }

                uIAInputTextIntoElementpropCount++;
            }
            else
            {
                uIAInputTextIntoElement["TryValuePattern"] = true;
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementtryLegacyPattern != null)
            {
                if (uIAInputTextIntoElementtryLegacyPattern != null)
                {
                    uIAInputTextIntoElement["TryLegacyPattern"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoElementtryLegacyPattern);
                    uIAInputTextIntoElementpropCount++;
                }

                uIAInputTextIntoElementpropCount++;
            }
            else
            {
                uIAInputTextIntoElement["TryLegacyPattern"] = false;
                uIAInputTextIntoElementpropCount++;
            }

            uIAInputTextIntoElementpropCount++;
            uIAInputTextIntoElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoElementworkflow);
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
            uIAInputTextIntoMultipleElements["InputElementsJSON"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoMultipleElementsinputElementsJSON);
            uIAInputTextIntoMultipleElementspropCount++;
            uIAInputTextIntoMultipleElements["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAInputTextIntoMultipleElementsworkflow);
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
            uIAInputReturnIntoElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAInputReturnIntoElementparentWindowHandle);
            if (uIAInputReturnIntoElementsearchElementName != null)
            {
                uIAInputReturnIntoElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAInputReturnIntoElementsearchElementName);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementsearchElementClassName != null)
            {
                uIAInputReturnIntoElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAInputReturnIntoElementsearchElementClassName);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementsearchElementAutomationId != null)
            {
                uIAInputReturnIntoElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAInputReturnIntoElementsearchElementAutomationId);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementsearchLocalizedControlType != null)
            {
                uIAInputReturnIntoElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAInputReturnIntoElementsearchLocalizedControlType);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementsearchSubTree != null)
            {
                if (uIAInputReturnIntoElementsearchSubTree != null)
                {
                    uIAInputReturnIntoElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAInputReturnIntoElementsearchSubTree);
                    uIAInputReturnIntoElementpropCount++;
                }

                uIAInputReturnIntoElementpropCount++;
            }
            else
            {
                uIAInputReturnIntoElement["SearchSubTree"] = true;
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementmatchIndex != null)
            {
                if (uIAInputReturnIntoElementmatchIndex != null)
                {
                    uIAInputReturnIntoElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAInputReturnIntoElementmatchIndex);
                    uIAInputReturnIntoElementpropCount++;
                }

                uIAInputReturnIntoElementpropCount++;
            }
            else
            {
                uIAInputReturnIntoElement["MatchIndex"] = 1;
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementsearchFilter != null)
            {
                uIAInputReturnIntoElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAInputReturnIntoElementsearchFilter);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementsortByColumn != null)
            {
                uIAInputReturnIntoElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAInputReturnIntoElementsortByColumn);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementmatchIndexAscending != null)
            {
                if (uIAInputReturnIntoElementmatchIndexAscending != null)
                {
                    uIAInputReturnIntoElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAInputReturnIntoElementmatchIndexAscending);
                    uIAInputReturnIntoElementpropCount++;
                }

                uIAInputReturnIntoElementpropCount++;
            }
            else
            {
                uIAInputReturnIntoElement["MatchIndexAscending"] = true;
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementreplaceExistingValue != null)
            {
                if (uIAInputReturnIntoElementreplaceExistingValue != null)
                {
                    uIAInputReturnIntoElement["ReplaceExistingValue"] = CSharpExpressionConverter.ConvertToken(uIAInputReturnIntoElementreplaceExistingValue);
                    uIAInputReturnIntoElementpropCount++;
                }

                uIAInputReturnIntoElementpropCount++;
            }
            else
            {
                uIAInputReturnIntoElement["ReplaceExistingValue"] = false;
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementinsertPosition != null)
            {
                uIAInputReturnIntoElement["InsertPosition"] = CSharpExpressionConverter.ConvertToken(uIAInputReturnIntoElementinsertPosition);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementmaxElementsToSearch != null)
            {
                if (uIAInputReturnIntoElementmaxElementsToSearch != null)
                {
                    uIAInputReturnIntoElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAInputReturnIntoElementmaxElementsToSearch);
                    uIAInputReturnIntoElementpropCount++;
                }

                uIAInputReturnIntoElementpropCount++;
            }
            else
            {
                uIAInputReturnIntoElement["MaxElementsToSearch"] = 0;
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementmaxRelativeSearchDepth != null)
            {
                if (uIAInputReturnIntoElementmaxRelativeSearchDepth != null)
                {
                    uIAInputReturnIntoElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAInputReturnIntoElementmaxRelativeSearchDepth);
                    uIAInputReturnIntoElementpropCount++;
                }

                uIAInputReturnIntoElementpropCount++;
            }
            else
            {
                uIAInputReturnIntoElement["MaxRelativeSearchDepth"] = 0;
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIAInputReturnIntoElementmaxChildElementsToSearchPerNode != null)
                {
                    uIAInputReturnIntoElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAInputReturnIntoElementmaxChildElementsToSearchPerNode);
                    uIAInputReturnIntoElementpropCount++;
                }

                uIAInputReturnIntoElementpropCount++;
            }
            else
            {
                uIAInputReturnIntoElement["MaxChildElementsToSearchPerNode"] = 0;
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAInputReturnIntoElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAInputReturnIntoElementelementLocalizedControlTypesNotToTraverse);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementraiseExceptionIfInputValidationFails != null)
            {
                if (uIAInputReturnIntoElementraiseExceptionIfInputValidationFails != null)
                {
                    uIAInputReturnIntoElement["RaiseExceptionIfInputValidationFails"] = CSharpExpressionConverter.ConvertToken(uIAInputReturnIntoElementraiseExceptionIfInputValidationFails);
                    uIAInputReturnIntoElementpropCount++;
                }

                uIAInputReturnIntoElementpropCount++;
            }
            else
            {
                uIAInputReturnIntoElement["RaiseExceptionIfInputValidationFails"] = false;
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementtryValuePattern != null)
            {
                if (uIAInputReturnIntoElementtryValuePattern != null)
                {
                    uIAInputReturnIntoElement["TryValuePattern"] = CSharpExpressionConverter.ConvertToken(uIAInputReturnIntoElementtryValuePattern);
                    uIAInputReturnIntoElementpropCount++;
                }

                uIAInputReturnIntoElementpropCount++;
            }
            else
            {
                uIAInputReturnIntoElement["TryValuePattern"] = true;
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementtryLegacyPattern != null)
            {
                if (uIAInputReturnIntoElementtryLegacyPattern != null)
                {
                    uIAInputReturnIntoElement["TryLegacyPattern"] = CSharpExpressionConverter.ConvertToken(uIAInputReturnIntoElementtryLegacyPattern);
                    uIAInputReturnIntoElementpropCount++;
                }

                uIAInputReturnIntoElementpropCount++;
            }
            else
            {
                uIAInputReturnIntoElement["TryLegacyPattern"] = false;
                uIAInputReturnIntoElementpropCount++;
            }

            uIAInputReturnIntoElementpropCount++;
            uIAInputReturnIntoElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAInputReturnIntoElementworkflow);
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
            uIAFocusElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAFocusElementparentWindowHandle);
            if (uIAFocusElementsearchElementName != null)
            {
                uIAFocusElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAFocusElementsearchElementName);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementsearchElementClassName != null)
            {
                uIAFocusElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAFocusElementsearchElementClassName);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementsearchElementAutomationId != null)
            {
                uIAFocusElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAFocusElementsearchElementAutomationId);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementsearchLocalizedControlType != null)
            {
                uIAFocusElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAFocusElementsearchLocalizedControlType);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementsearchSubTree != null)
            {
                if (uIAFocusElementsearchSubTree != null)
                {
                    uIAFocusElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAFocusElementsearchSubTree);
                    uIAFocusElementpropCount++;
                }

                uIAFocusElementpropCount++;
            }
            else
            {
                uIAFocusElement["SearchSubTree"] = true;
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementmatchIndex != null)
            {
                if (uIAFocusElementmatchIndex != null)
                {
                    uIAFocusElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAFocusElementmatchIndex);
                    uIAFocusElementpropCount++;
                }

                uIAFocusElementpropCount++;
            }
            else
            {
                uIAFocusElement["MatchIndex"] = 1;
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementsearchFilter != null)
            {
                uIAFocusElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAFocusElementsearchFilter);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementsortByColumn != null)
            {
                uIAFocusElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAFocusElementsortByColumn);
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementmatchIndexAscending != null)
            {
                if (uIAFocusElementmatchIndexAscending != null)
                {
                    uIAFocusElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAFocusElementmatchIndexAscending);
                    uIAFocusElementpropCount++;
                }

                uIAFocusElementpropCount++;
            }
            else
            {
                uIAFocusElement["MatchIndexAscending"] = true;
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementmaxElementsToSearch != null)
            {
                if (uIAFocusElementmaxElementsToSearch != null)
                {
                    uIAFocusElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAFocusElementmaxElementsToSearch);
                    uIAFocusElementpropCount++;
                }

                uIAFocusElementpropCount++;
            }
            else
            {
                uIAFocusElement["MaxElementsToSearch"] = 0;
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementmaxRelativeSearchDepth != null)
            {
                if (uIAFocusElementmaxRelativeSearchDepth != null)
                {
                    uIAFocusElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAFocusElementmaxRelativeSearchDepth);
                    uIAFocusElementpropCount++;
                }

                uIAFocusElementpropCount++;
            }
            else
            {
                uIAFocusElement["MaxRelativeSearchDepth"] = 0;
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIAFocusElementmaxChildElementsToSearchPerNode != null)
                {
                    uIAFocusElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAFocusElementmaxChildElementsToSearchPerNode);
                    uIAFocusElementpropCount++;
                }

                uIAFocusElementpropCount++;
            }
            else
            {
                uIAFocusElement["MaxChildElementsToSearchPerNode"] = 0;
                uIAFocusElementpropCount++;
            }

            if (uIAFocusElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAFocusElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAFocusElementelementLocalizedControlTypesNotToTraverse);
                uIAFocusElementpropCount++;
            }

            uIAFocusElementpropCount++;
            uIAFocusElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAFocusElementworkflow);
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
            uIAToggleElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAToggleElementparentWindowHandle);
            if (uIAToggleElementsearchElementName != null)
            {
                uIAToggleElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAToggleElementsearchElementName);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementsearchElementClassName != null)
            {
                uIAToggleElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAToggleElementsearchElementClassName);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementsearchElementAutomationId != null)
            {
                uIAToggleElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAToggleElementsearchElementAutomationId);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementsearchLocalizedControlType != null)
            {
                uIAToggleElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAToggleElementsearchLocalizedControlType);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementsearchSubTree != null)
            {
                if (uIAToggleElementsearchSubTree != null)
                {
                    uIAToggleElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAToggleElementsearchSubTree);
                    uIAToggleElementpropCount++;
                }

                uIAToggleElementpropCount++;
            }
            else
            {
                uIAToggleElement["SearchSubTree"] = true;
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementmatchIndex != null)
            {
                if (uIAToggleElementmatchIndex != null)
                {
                    uIAToggleElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAToggleElementmatchIndex);
                    uIAToggleElementpropCount++;
                }

                uIAToggleElementpropCount++;
            }
            else
            {
                uIAToggleElement["MatchIndex"] = 1;
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementsearchFilter != null)
            {
                uIAToggleElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAToggleElementsearchFilter);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementsortByColumn != null)
            {
                uIAToggleElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAToggleElementsortByColumn);
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementmatchIndexAscending != null)
            {
                if (uIAToggleElementmatchIndexAscending != null)
                {
                    uIAToggleElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAToggleElementmatchIndexAscending);
                    uIAToggleElementpropCount++;
                }

                uIAToggleElementpropCount++;
            }
            else
            {
                uIAToggleElement["MatchIndexAscending"] = true;
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementmaxElementsToSearch != null)
            {
                if (uIAToggleElementmaxElementsToSearch != null)
                {
                    uIAToggleElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAToggleElementmaxElementsToSearch);
                    uIAToggleElementpropCount++;
                }

                uIAToggleElementpropCount++;
            }
            else
            {
                uIAToggleElement["MaxElementsToSearch"] = 0;
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementmaxRelativeSearchDepth != null)
            {
                if (uIAToggleElementmaxRelativeSearchDepth != null)
                {
                    uIAToggleElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAToggleElementmaxRelativeSearchDepth);
                    uIAToggleElementpropCount++;
                }

                uIAToggleElementpropCount++;
            }
            else
            {
                uIAToggleElement["MaxRelativeSearchDepth"] = 0;
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIAToggleElementmaxChildElementsToSearchPerNode != null)
                {
                    uIAToggleElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAToggleElementmaxChildElementsToSearchPerNode);
                    uIAToggleElementpropCount++;
                }

                uIAToggleElementpropCount++;
            }
            else
            {
                uIAToggleElement["MaxChildElementsToSearchPerNode"] = 0;
                uIAToggleElementpropCount++;
            }

            if (uIAToggleElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAToggleElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAToggleElementelementLocalizedControlTypesNotToTraverse);
                uIAToggleElementpropCount++;
            }

            uIAToggleElementpropCount++;
            uIAToggleElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAToggleElementworkflow);
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
            uIACheckElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIACheckElementparentWindowHandle);
            if (uIACheckElementsearchElementName != null)
            {
                uIACheckElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIACheckElementsearchElementName);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementsearchElementClassName != null)
            {
                uIACheckElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIACheckElementsearchElementClassName);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementsearchElementAutomationId != null)
            {
                uIACheckElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIACheckElementsearchElementAutomationId);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementsearchLocalizedControlType != null)
            {
                uIACheckElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIACheckElementsearchLocalizedControlType);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementsearchSubTree != null)
            {
                if (uIACheckElementsearchSubTree != null)
                {
                    uIACheckElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIACheckElementsearchSubTree);
                    uIACheckElementpropCount++;
                }

                uIACheckElementpropCount++;
            }
            else
            {
                uIACheckElement["SearchSubTree"] = true;
                uIACheckElementpropCount++;
            }

            if (uIACheckElementcheckElement != null)
            {
                if (uIACheckElementcheckElement != null)
                {
                    uIACheckElement["CheckElement"] = CSharpExpressionConverter.ConvertToken(uIACheckElementcheckElement);
                    uIACheckElementpropCount++;
                }

                uIACheckElementpropCount++;
            }
            else
            {
                uIACheckElement["CheckElement"] = true;
                uIACheckElementpropCount++;
            }

            if (uIACheckElementmatchIndex != null)
            {
                if (uIACheckElementmatchIndex != null)
                {
                    uIACheckElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIACheckElementmatchIndex);
                    uIACheckElementpropCount++;
                }

                uIACheckElementpropCount++;
            }
            else
            {
                uIACheckElement["MatchIndex"] = 1;
                uIACheckElementpropCount++;
            }

            if (uIACheckElementsearchFilter != null)
            {
                uIACheckElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIACheckElementsearchFilter);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementsortByColumn != null)
            {
                uIACheckElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIACheckElementsortByColumn);
                uIACheckElementpropCount++;
            }

            if (uIACheckElementmatchIndexAscending != null)
            {
                if (uIACheckElementmatchIndexAscending != null)
                {
                    uIACheckElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIACheckElementmatchIndexAscending);
                    uIACheckElementpropCount++;
                }

                uIACheckElementpropCount++;
            }
            else
            {
                uIACheckElement["MatchIndexAscending"] = true;
                uIACheckElementpropCount++;
            }

            if (uIACheckElementmaxElementsToSearch != null)
            {
                if (uIACheckElementmaxElementsToSearch != null)
                {
                    uIACheckElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIACheckElementmaxElementsToSearch);
                    uIACheckElementpropCount++;
                }

                uIACheckElementpropCount++;
            }
            else
            {
                uIACheckElement["MaxElementsToSearch"] = 0;
                uIACheckElementpropCount++;
            }

            if (uIACheckElementmaxRelativeSearchDepth != null)
            {
                if (uIACheckElementmaxRelativeSearchDepth != null)
                {
                    uIACheckElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIACheckElementmaxRelativeSearchDepth);
                    uIACheckElementpropCount++;
                }

                uIACheckElementpropCount++;
            }
            else
            {
                uIACheckElement["MaxRelativeSearchDepth"] = 0;
                uIACheckElementpropCount++;
            }

            if (uIACheckElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIACheckElementmaxChildElementsToSearchPerNode != null)
                {
                    uIACheckElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIACheckElementmaxChildElementsToSearchPerNode);
                    uIACheckElementpropCount++;
                }

                uIACheckElementpropCount++;
            }
            else
            {
                uIACheckElement["MaxChildElementsToSearchPerNode"] = 0;
                uIACheckElementpropCount++;
            }

            if (uIACheckElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIACheckElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIACheckElementelementLocalizedControlTypesNotToTraverse);
                uIACheckElementpropCount++;
            }

            uIACheckElementpropCount++;
            uIACheckElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIACheckElementworkflow);
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
            uIACheckMultipleElements["InputElementsJSON"] = CSharpExpressionConverter.ConvertToken(uIACheckMultipleElementsinputElementsJSON);
            uIACheckMultipleElementspropCount++;
            uIACheckMultipleElements["Workflow"] = CSharpExpressionConverter.ConvertToken(uIACheckMultipleElementsworkflow);
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
            uIAIsElementChecked["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAIsElementCheckedparentWindowHandle);
            if (uIAIsElementCheckedsearchElementName != null)
            {
                uIAIsElementChecked["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAIsElementCheckedsearchElementName);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedsearchElementClassName != null)
            {
                uIAIsElementChecked["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAIsElementCheckedsearchElementClassName);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedsearchElementAutomationId != null)
            {
                uIAIsElementChecked["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAIsElementCheckedsearchElementAutomationId);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedsearchLocalizedControlType != null)
            {
                uIAIsElementChecked["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAIsElementCheckedsearchLocalizedControlType);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedsearchSubTree != null)
            {
                if (uIAIsElementCheckedsearchSubTree != null)
                {
                    uIAIsElementChecked["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAIsElementCheckedsearchSubTree);
                    uIAIsElementCheckedpropCount++;
                }

                uIAIsElementCheckedpropCount++;
            }
            else
            {
                uIAIsElementChecked["SearchSubTree"] = true;
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedmatchIndex != null)
            {
                if (uIAIsElementCheckedmatchIndex != null)
                {
                    uIAIsElementChecked["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAIsElementCheckedmatchIndex);
                    uIAIsElementCheckedpropCount++;
                }

                uIAIsElementCheckedpropCount++;
            }
            else
            {
                uIAIsElementChecked["MatchIndex"] = 1;
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedsearchFilter != null)
            {
                uIAIsElementChecked["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAIsElementCheckedsearchFilter);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedsortByColumn != null)
            {
                uIAIsElementChecked["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAIsElementCheckedsortByColumn);
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedmatchIndexAscending != null)
            {
                if (uIAIsElementCheckedmatchIndexAscending != null)
                {
                    uIAIsElementChecked["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAIsElementCheckedmatchIndexAscending);
                    uIAIsElementCheckedpropCount++;
                }

                uIAIsElementCheckedpropCount++;
            }
            else
            {
                uIAIsElementChecked["MatchIndexAscending"] = true;
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedmaxElementsToSearch != null)
            {
                if (uIAIsElementCheckedmaxElementsToSearch != null)
                {
                    uIAIsElementChecked["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAIsElementCheckedmaxElementsToSearch);
                    uIAIsElementCheckedpropCount++;
                }

                uIAIsElementCheckedpropCount++;
            }
            else
            {
                uIAIsElementChecked["MaxElementsToSearch"] = 0;
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedmaxRelativeSearchDepth != null)
            {
                if (uIAIsElementCheckedmaxRelativeSearchDepth != null)
                {
                    uIAIsElementChecked["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAIsElementCheckedmaxRelativeSearchDepth);
                    uIAIsElementCheckedpropCount++;
                }

                uIAIsElementCheckedpropCount++;
            }
            else
            {
                uIAIsElementChecked["MaxRelativeSearchDepth"] = 0;
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedmaxChildElementsToSearchPerNode != null)
            {
                if (uIAIsElementCheckedmaxChildElementsToSearchPerNode != null)
                {
                    uIAIsElementChecked["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAIsElementCheckedmaxChildElementsToSearchPerNode);
                    uIAIsElementCheckedpropCount++;
                }

                uIAIsElementCheckedpropCount++;
            }
            else
            {
                uIAIsElementChecked["MaxChildElementsToSearchPerNode"] = 0;
                uIAIsElementCheckedpropCount++;
            }

            if (uIAIsElementCheckedelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAIsElementChecked["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAIsElementCheckedelementLocalizedControlTypesNotToTraverse);
                uIAIsElementCheckedpropCount++;
            }

            uIAIsElementCheckedpropCount++;
            uIAIsElementChecked["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAIsElementCheckedworkflow);
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
            uIACloseElementWindow["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIACloseElementWindowparentWindowHandle);
            if (uIACloseElementWindowsearchElementName != null)
            {
                uIACloseElementWindow["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIACloseElementWindowsearchElementName);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowsearchElementClassName != null)
            {
                uIACloseElementWindow["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIACloseElementWindowsearchElementClassName);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowsearchElementAutomationId != null)
            {
                uIACloseElementWindow["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIACloseElementWindowsearchElementAutomationId);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowsearchLocalizedControlType != null)
            {
                uIACloseElementWindow["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIACloseElementWindowsearchLocalizedControlType);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowsearchSubTree != null)
            {
                if (uIACloseElementWindowsearchSubTree != null)
                {
                    uIACloseElementWindow["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIACloseElementWindowsearchSubTree);
                    uIACloseElementWindowpropCount++;
                }

                uIACloseElementWindowpropCount++;
            }
            else
            {
                uIACloseElementWindow["SearchSubTree"] = true;
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowmatchIndex != null)
            {
                if (uIACloseElementWindowmatchIndex != null)
                {
                    uIACloseElementWindow["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIACloseElementWindowmatchIndex);
                    uIACloseElementWindowpropCount++;
                }

                uIACloseElementWindowpropCount++;
            }
            else
            {
                uIACloseElementWindow["MatchIndex"] = 1;
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowsearchFilter != null)
            {
                uIACloseElementWindow["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIACloseElementWindowsearchFilter);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowsortByColumn != null)
            {
                uIACloseElementWindow["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIACloseElementWindowsortByColumn);
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowmatchIndexAscending != null)
            {
                if (uIACloseElementWindowmatchIndexAscending != null)
                {
                    uIACloseElementWindow["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIACloseElementWindowmatchIndexAscending);
                    uIACloseElementWindowpropCount++;
                }

                uIACloseElementWindowpropCount++;
            }
            else
            {
                uIACloseElementWindow["MatchIndexAscending"] = true;
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowmaxElementsToSearch != null)
            {
                if (uIACloseElementWindowmaxElementsToSearch != null)
                {
                    uIACloseElementWindow["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIACloseElementWindowmaxElementsToSearch);
                    uIACloseElementWindowpropCount++;
                }

                uIACloseElementWindowpropCount++;
            }
            else
            {
                uIACloseElementWindow["MaxElementsToSearch"] = 0;
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowmaxRelativeSearchDepth != null)
            {
                if (uIACloseElementWindowmaxRelativeSearchDepth != null)
                {
                    uIACloseElementWindow["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIACloseElementWindowmaxRelativeSearchDepth);
                    uIACloseElementWindowpropCount++;
                }

                uIACloseElementWindowpropCount++;
            }
            else
            {
                uIACloseElementWindow["MaxRelativeSearchDepth"] = 0;
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowmaxChildElementsToSearchPerNode != null)
            {
                if (uIACloseElementWindowmaxChildElementsToSearchPerNode != null)
                {
                    uIACloseElementWindow["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIACloseElementWindowmaxChildElementsToSearchPerNode);
                    uIACloseElementWindowpropCount++;
                }

                uIACloseElementWindowpropCount++;
            }
            else
            {
                uIACloseElementWindow["MaxChildElementsToSearchPerNode"] = 0;
                uIACloseElementWindowpropCount++;
            }

            if (uIACloseElementWindowelementLocalizedControlTypesNotToTraverse != null)
            {
                uIACloseElementWindow["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIACloseElementWindowelementLocalizedControlTypesNotToTraverse);
                uIACloseElementWindowpropCount++;
            }

            uIACloseElementWindowpropCount++;
            uIACloseElementWindow["Workflow"] = CSharpExpressionConverter.ConvertToken(uIACloseElementWindowworkflow);
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
            uIAGetElementTextValue["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAGetElementTextValueparentWindowHandle);
            if (uIAGetElementTextValuesearchElementName != null)
            {
                uIAGetElementTextValue["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAGetElementTextValuesearchElementName);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValuesearchElementClassName != null)
            {
                uIAGetElementTextValue["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAGetElementTextValuesearchElementClassName);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValuesearchElementAutomationId != null)
            {
                uIAGetElementTextValue["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAGetElementTextValuesearchElementAutomationId);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValuesearchLocalizedControlType != null)
            {
                uIAGetElementTextValue["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAGetElementTextValuesearchLocalizedControlType);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValuesearchSubTree != null)
            {
                if (uIAGetElementTextValuesearchSubTree != null)
                {
                    uIAGetElementTextValue["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAGetElementTextValuesearchSubTree);
                    uIAGetElementTextValuepropCount++;
                }

                uIAGetElementTextValuepropCount++;
            }
            else
            {
                uIAGetElementTextValue["SearchSubTree"] = true;
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValuematchIndex != null)
            {
                if (uIAGetElementTextValuematchIndex != null)
                {
                    uIAGetElementTextValue["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAGetElementTextValuematchIndex);
                    uIAGetElementTextValuepropCount++;
                }

                uIAGetElementTextValuepropCount++;
            }
            else
            {
                uIAGetElementTextValue["MatchIndex"] = 1;
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValuesearchFilter != null)
            {
                uIAGetElementTextValue["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAGetElementTextValuesearchFilter);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValuesortByColumn != null)
            {
                uIAGetElementTextValue["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAGetElementTextValuesortByColumn);
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValuematchIndexAscending != null)
            {
                if (uIAGetElementTextValuematchIndexAscending != null)
                {
                    uIAGetElementTextValue["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAGetElementTextValuematchIndexAscending);
                    uIAGetElementTextValuepropCount++;
                }

                uIAGetElementTextValuepropCount++;
            }
            else
            {
                uIAGetElementTextValue["MatchIndexAscending"] = true;
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValuemaxElementsToSearch != null)
            {
                if (uIAGetElementTextValuemaxElementsToSearch != null)
                {
                    uIAGetElementTextValue["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAGetElementTextValuemaxElementsToSearch);
                    uIAGetElementTextValuepropCount++;
                }

                uIAGetElementTextValuepropCount++;
            }
            else
            {
                uIAGetElementTextValue["MaxElementsToSearch"] = 0;
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValuemaxRelativeSearchDepth != null)
            {
                if (uIAGetElementTextValuemaxRelativeSearchDepth != null)
                {
                    uIAGetElementTextValue["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAGetElementTextValuemaxRelativeSearchDepth);
                    uIAGetElementTextValuepropCount++;
                }

                uIAGetElementTextValuepropCount++;
            }
            else
            {
                uIAGetElementTextValue["MaxRelativeSearchDepth"] = 0;
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValuemaxChildElementsToSearchPerNode != null)
            {
                if (uIAGetElementTextValuemaxChildElementsToSearchPerNode != null)
                {
                    uIAGetElementTextValue["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAGetElementTextValuemaxChildElementsToSearchPerNode);
                    uIAGetElementTextValuepropCount++;
                }

                uIAGetElementTextValuepropCount++;
            }
            else
            {
                uIAGetElementTextValue["MaxChildElementsToSearchPerNode"] = 0;
                uIAGetElementTextValuepropCount++;
            }

            if (uIAGetElementTextValueelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetElementTextValue["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAGetElementTextValueelementLocalizedControlTypesNotToTraverse);
                uIAGetElementTextValuepropCount++;
            }

            uIAGetElementTextValuepropCount++;
            uIAGetElementTextValue["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetElementTextValueworkflow);
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
            uIAGetElementValue["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAGetElementValueparentWindowHandle);
            if (uIAGetElementValuesearchElementName != null)
            {
                uIAGetElementValue["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAGetElementValuesearchElementName);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValuesearchElementClassName != null)
            {
                uIAGetElementValue["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAGetElementValuesearchElementClassName);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValuesearchElementAutomationId != null)
            {
                uIAGetElementValue["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAGetElementValuesearchElementAutomationId);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValuesearchLocalizedControlType != null)
            {
                uIAGetElementValue["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAGetElementValuesearchLocalizedControlType);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValuesearchSubTree != null)
            {
                if (uIAGetElementValuesearchSubTree != null)
                {
                    uIAGetElementValue["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAGetElementValuesearchSubTree);
                    uIAGetElementValuepropCount++;
                }

                uIAGetElementValuepropCount++;
            }
            else
            {
                uIAGetElementValue["SearchSubTree"] = true;
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValuematchIndex != null)
            {
                if (uIAGetElementValuematchIndex != null)
                {
                    uIAGetElementValue["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAGetElementValuematchIndex);
                    uIAGetElementValuepropCount++;
                }

                uIAGetElementValuepropCount++;
            }
            else
            {
                uIAGetElementValue["MatchIndex"] = 1;
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValuesearchFilter != null)
            {
                uIAGetElementValue["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAGetElementValuesearchFilter);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValuesortByColumn != null)
            {
                uIAGetElementValue["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAGetElementValuesortByColumn);
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValuematchIndexAscending != null)
            {
                if (uIAGetElementValuematchIndexAscending != null)
                {
                    uIAGetElementValue["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAGetElementValuematchIndexAscending);
                    uIAGetElementValuepropCount++;
                }

                uIAGetElementValuepropCount++;
            }
            else
            {
                uIAGetElementValue["MatchIndexAscending"] = true;
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValuemaxElementsToSearch != null)
            {
                if (uIAGetElementValuemaxElementsToSearch != null)
                {
                    uIAGetElementValue["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAGetElementValuemaxElementsToSearch);
                    uIAGetElementValuepropCount++;
                }

                uIAGetElementValuepropCount++;
            }
            else
            {
                uIAGetElementValue["MaxElementsToSearch"] = 0;
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValuemaxRelativeSearchDepth != null)
            {
                if (uIAGetElementValuemaxRelativeSearchDepth != null)
                {
                    uIAGetElementValue["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAGetElementValuemaxRelativeSearchDepth);
                    uIAGetElementValuepropCount++;
                }

                uIAGetElementValuepropCount++;
            }
            else
            {
                uIAGetElementValue["MaxRelativeSearchDepth"] = 0;
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValuemaxChildElementsToSearchPerNode != null)
            {
                if (uIAGetElementValuemaxChildElementsToSearchPerNode != null)
                {
                    uIAGetElementValue["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAGetElementValuemaxChildElementsToSearchPerNode);
                    uIAGetElementValuepropCount++;
                }

                uIAGetElementValuepropCount++;
            }
            else
            {
                uIAGetElementValue["MaxChildElementsToSearchPerNode"] = 0;
                uIAGetElementValuepropCount++;
            }

            if (uIAGetElementValueelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetElementValue["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAGetElementValueelementLocalizedControlTypesNotToTraverse);
                uIAGetElementValuepropCount++;
            }

            uIAGetElementValuepropCount++;
            uIAGetElementValue["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetElementValueworkflow);
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
            uIAGetElementLabelValue["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAGetElementLabelValueparentWindowHandle);
            if (uIAGetElementLabelValuesearchElementName != null)
            {
                uIAGetElementLabelValue["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAGetElementLabelValuesearchElementName);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValuesearchElementClassName != null)
            {
                uIAGetElementLabelValue["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAGetElementLabelValuesearchElementClassName);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValuesearchElementAutomationId != null)
            {
                uIAGetElementLabelValue["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAGetElementLabelValuesearchElementAutomationId);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValuesearchLocalizedControlType != null)
            {
                uIAGetElementLabelValue["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAGetElementLabelValuesearchLocalizedControlType);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValuesearchSubTree != null)
            {
                if (uIAGetElementLabelValuesearchSubTree != null)
                {
                    uIAGetElementLabelValue["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAGetElementLabelValuesearchSubTree);
                    uIAGetElementLabelValuepropCount++;
                }

                uIAGetElementLabelValuepropCount++;
            }
            else
            {
                uIAGetElementLabelValue["SearchSubTree"] = true;
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValuematchIndex != null)
            {
                if (uIAGetElementLabelValuematchIndex != null)
                {
                    uIAGetElementLabelValue["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAGetElementLabelValuematchIndex);
                    uIAGetElementLabelValuepropCount++;
                }

                uIAGetElementLabelValuepropCount++;
            }
            else
            {
                uIAGetElementLabelValue["MatchIndex"] = 1;
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValuesearchFilter != null)
            {
                uIAGetElementLabelValue["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAGetElementLabelValuesearchFilter);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValuesortByColumn != null)
            {
                uIAGetElementLabelValue["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAGetElementLabelValuesortByColumn);
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValuematchIndexAscending != null)
            {
                if (uIAGetElementLabelValuematchIndexAscending != null)
                {
                    uIAGetElementLabelValue["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAGetElementLabelValuematchIndexAscending);
                    uIAGetElementLabelValuepropCount++;
                }

                uIAGetElementLabelValuepropCount++;
            }
            else
            {
                uIAGetElementLabelValue["MatchIndexAscending"] = true;
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValuemaxElementsToSearch != null)
            {
                if (uIAGetElementLabelValuemaxElementsToSearch != null)
                {
                    uIAGetElementLabelValue["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAGetElementLabelValuemaxElementsToSearch);
                    uIAGetElementLabelValuepropCount++;
                }

                uIAGetElementLabelValuepropCount++;
            }
            else
            {
                uIAGetElementLabelValue["MaxElementsToSearch"] = 0;
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValuemaxRelativeSearchDepth != null)
            {
                if (uIAGetElementLabelValuemaxRelativeSearchDepth != null)
                {
                    uIAGetElementLabelValue["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAGetElementLabelValuemaxRelativeSearchDepth);
                    uIAGetElementLabelValuepropCount++;
                }

                uIAGetElementLabelValuepropCount++;
            }
            else
            {
                uIAGetElementLabelValue["MaxRelativeSearchDepth"] = 0;
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValuemaxChildElementsToSearchPerNode != null)
            {
                if (uIAGetElementLabelValuemaxChildElementsToSearchPerNode != null)
                {
                    uIAGetElementLabelValue["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAGetElementLabelValuemaxChildElementsToSearchPerNode);
                    uIAGetElementLabelValuepropCount++;
                }

                uIAGetElementLabelValuepropCount++;
            }
            else
            {
                uIAGetElementLabelValue["MaxChildElementsToSearchPerNode"] = 0;
                uIAGetElementLabelValuepropCount++;
            }

            if (uIAGetElementLabelValueelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetElementLabelValue["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAGetElementLabelValueelementLocalizedControlTypesNotToTraverse);
                uIAGetElementLabelValuepropCount++;
            }

            uIAGetElementLabelValuepropCount++;
            uIAGetElementLabelValue["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetElementLabelValueworkflow);
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
            uIAGetElementProperties["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPropertiesparentWindowHandle);
            if (uIAGetElementPropertiessearchElementName != null)
            {
                uIAGetElementProperties["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPropertiessearchElementName);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiessearchElementClassName != null)
            {
                uIAGetElementProperties["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPropertiessearchElementClassName);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiessearchElementAutomationId != null)
            {
                uIAGetElementProperties["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPropertiessearchElementAutomationId);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiessearchLocalizedControlType != null)
            {
                uIAGetElementProperties["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPropertiessearchLocalizedControlType);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiessearchSubTree != null)
            {
                if (uIAGetElementPropertiessearchSubTree != null)
                {
                    uIAGetElementProperties["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPropertiessearchSubTree);
                    uIAGetElementPropertiespropCount++;
                }

                uIAGetElementPropertiespropCount++;
            }
            else
            {
                uIAGetElementProperties["SearchSubTree"] = true;
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesreturnElementHandle != null)
            {
                if (uIAGetElementPropertiesreturnElementHandle != null)
                {
                    uIAGetElementProperties["ReturnElementHandle"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPropertiesreturnElementHandle);
                    uIAGetElementPropertiespropCount++;
                }

                uIAGetElementPropertiespropCount++;
            }
            else
            {
                uIAGetElementProperties["ReturnElementHandle"] = true;
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesreturnElementValue != null)
            {
                if (uIAGetElementPropertiesreturnElementValue != null)
                {
                    uIAGetElementProperties["ReturnElementValue"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPropertiesreturnElementValue);
                    uIAGetElementPropertiespropCount++;
                }

                uIAGetElementPropertiespropCount++;
            }
            else
            {
                uIAGetElementProperties["ReturnElementValue"] = false;
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesmatchIndex != null)
            {
                if (uIAGetElementPropertiesmatchIndex != null)
                {
                    uIAGetElementProperties["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPropertiesmatchIndex);
                    uIAGetElementPropertiespropCount++;
                }

                uIAGetElementPropertiespropCount++;
            }
            else
            {
                uIAGetElementProperties["MatchIndex"] = 1;
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiessearchFilter != null)
            {
                uIAGetElementProperties["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPropertiessearchFilter);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiessortByColumn != null)
            {
                uIAGetElementProperties["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPropertiessortByColumn);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesmatchIndexAscending != null)
            {
                if (uIAGetElementPropertiesmatchIndexAscending != null)
                {
                    uIAGetElementProperties["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPropertiesmatchIndexAscending);
                    uIAGetElementPropertiespropCount++;
                }

                uIAGetElementPropertiespropCount++;
            }
            else
            {
                uIAGetElementProperties["MatchIndexAscending"] = true;
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesmaxElementsToSearch != null)
            {
                if (uIAGetElementPropertiesmaxElementsToSearch != null)
                {
                    uIAGetElementProperties["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPropertiesmaxElementsToSearch);
                    uIAGetElementPropertiespropCount++;
                }

                uIAGetElementPropertiespropCount++;
            }
            else
            {
                uIAGetElementProperties["MaxElementsToSearch"] = 0;
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesmaxRelativeSearchDepth != null)
            {
                if (uIAGetElementPropertiesmaxRelativeSearchDepth != null)
                {
                    uIAGetElementProperties["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPropertiesmaxRelativeSearchDepth);
                    uIAGetElementPropertiespropCount++;
                }

                uIAGetElementPropertiespropCount++;
            }
            else
            {
                uIAGetElementProperties["MaxRelativeSearchDepth"] = 0;
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesmaxChildElementsToSearchPerNode != null)
            {
                if (uIAGetElementPropertiesmaxChildElementsToSearchPerNode != null)
                {
                    uIAGetElementProperties["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPropertiesmaxChildElementsToSearchPerNode);
                    uIAGetElementPropertiespropCount++;
                }

                uIAGetElementPropertiespropCount++;
            }
            else
            {
                uIAGetElementProperties["MaxChildElementsToSearchPerNode"] = 0;
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertieselementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetElementProperties["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPropertieselementLocalizedControlTypesNotToTraverse);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesvalidateClickablePointWithinElementBoundary != null)
            {
                if (uIAGetElementPropertiesvalidateClickablePointWithinElementBoundary != null)
                {
                    uIAGetElementProperties["ValidateClickablePointWithinElementBoundary"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPropertiesvalidateClickablePointWithinElementBoundary);
                    uIAGetElementPropertiespropCount++;
                }

                uIAGetElementPropertiespropCount++;
            }
            else
            {
                uIAGetElementProperties["ValidateClickablePointWithinElementBoundary"] = false;
                uIAGetElementPropertiespropCount++;
            }

            uIAGetElementPropertiespropCount++;
            uIAGetElementProperties["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPropertiesworkflow);
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
            uIAGetMultipleElementProperties["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementPropertiesparentWindowHandle);
            if (uIAGetMultipleElementPropertiessearchElementLocalizedControlType != null)
            {
                uIAGetMultipleElementProperties["SearchElementLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementPropertiessearchElementLocalizedControlType);
                uIAGetMultipleElementPropertiespropCount++;
            }

            if (uIAGetMultipleElementPropertiessearchDescendants != null)
            {
                if (uIAGetMultipleElementPropertiessearchDescendants != null)
                {
                    uIAGetMultipleElementProperties["SearchDescendants"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementPropertiessearchDescendants);
                    uIAGetMultipleElementPropertiespropCount++;
                }

                uIAGetMultipleElementPropertiespropCount++;
            }
            else
            {
                uIAGetMultipleElementProperties["SearchDescendants"] = false;
                uIAGetMultipleElementPropertiespropCount++;
            }

            if (uIAGetMultipleElementPropertiesreturnElementHandle != null)
            {
                if (uIAGetMultipleElementPropertiesreturnElementHandle != null)
                {
                    uIAGetMultipleElementProperties["ReturnElementHandle"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementPropertiesreturnElementHandle);
                    uIAGetMultipleElementPropertiespropCount++;
                }

                uIAGetMultipleElementPropertiespropCount++;
            }
            else
            {
                uIAGetMultipleElementProperties["ReturnElementHandle"] = true;
                uIAGetMultipleElementPropertiespropCount++;
            }

            if (uIAGetMultipleElementPropertiesreturnElementValue != null)
            {
                if (uIAGetMultipleElementPropertiesreturnElementValue != null)
                {
                    uIAGetMultipleElementProperties["ReturnElementValue"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementPropertiesreturnElementValue);
                    uIAGetMultipleElementPropertiespropCount++;
                }

                uIAGetMultipleElementPropertiespropCount++;
            }
            else
            {
                uIAGetMultipleElementProperties["ReturnElementValue"] = false;
                uIAGetMultipleElementPropertiespropCount++;
            }

            if (uIAGetMultipleElementPropertiesfirstItemToReturn != null)
            {
                if (uIAGetMultipleElementPropertiesfirstItemToReturn != null)
                {
                    uIAGetMultipleElementProperties["FirstItemToReturn"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementPropertiesfirstItemToReturn);
                    uIAGetMultipleElementPropertiespropCount++;
                }

                uIAGetMultipleElementPropertiespropCount++;
            }
            else
            {
                uIAGetMultipleElementProperties["FirstItemToReturn"] = 1;
                uIAGetMultipleElementPropertiespropCount++;
            }

            if (uIAGetMultipleElementPropertiesmaxItemsToReturn != null)
            {
                if (uIAGetMultipleElementPropertiesmaxItemsToReturn != null)
                {
                    uIAGetMultipleElementProperties["MaxItemsToReturn"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementPropertiesmaxItemsToReturn);
                    uIAGetMultipleElementPropertiespropCount++;
                }

                uIAGetMultipleElementPropertiespropCount++;
            }
            else
            {
                uIAGetMultipleElementProperties["MaxItemsToReturn"] = 0;
                uIAGetMultipleElementPropertiespropCount++;
            }

            uIAGetMultipleElementPropertiespropCount++;
            uIAGetMultipleElementProperties["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementPropertiesworkflow);
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
                uIAGetDesktopElements["SearchElementLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAGetDesktopElementssearchElementLocalizedControlType);
                uIAGetDesktopElementspropCount++;
            }

            if (uIAGetDesktopElementssearchProcessID != null)
            {
                if (uIAGetDesktopElementssearchProcessID != null)
                {
                    uIAGetDesktopElements["SearchProcessID"] = CSharpExpressionConverter.ConvertToken(uIAGetDesktopElementssearchProcessID);
                    uIAGetDesktopElementspropCount++;
                }

                uIAGetDesktopElementspropCount++;
            }
            else
            {
                uIAGetDesktopElements["SearchProcessID"] = 0;
                uIAGetDesktopElementspropCount++;
            }

            if (uIAGetDesktopElementsreturnElementHandle != null)
            {
                if (uIAGetDesktopElementsreturnElementHandle != null)
                {
                    uIAGetDesktopElements["ReturnElementHandle"] = CSharpExpressionConverter.ConvertToken(uIAGetDesktopElementsreturnElementHandle);
                    uIAGetDesktopElementspropCount++;
                }

                uIAGetDesktopElementspropCount++;
            }
            else
            {
                uIAGetDesktopElements["ReturnElementHandle"] = true;
                uIAGetDesktopElementspropCount++;
            }

            if (uIAGetDesktopElementsfirstItemToReturn != null)
            {
                if (uIAGetDesktopElementsfirstItemToReturn != null)
                {
                    uIAGetDesktopElements["FirstItemToReturn"] = CSharpExpressionConverter.ConvertToken(uIAGetDesktopElementsfirstItemToReturn);
                    uIAGetDesktopElementspropCount++;
                }

                uIAGetDesktopElementspropCount++;
            }
            else
            {
                uIAGetDesktopElements["FirstItemToReturn"] = 1;
                uIAGetDesktopElementspropCount++;
            }

            if (uIAGetDesktopElementsmaxItemsToReturn != null)
            {
                if (uIAGetDesktopElementsmaxItemsToReturn != null)
                {
                    uIAGetDesktopElements["MaxItemsToReturn"] = CSharpExpressionConverter.ConvertToken(uIAGetDesktopElementsmaxItemsToReturn);
                    uIAGetDesktopElementspropCount++;
                }

                uIAGetDesktopElementspropCount++;
            }
            else
            {
                uIAGetDesktopElements["MaxItemsToReturn"] = 0;
                uIAGetDesktopElementspropCount++;
            }

            if (uIAGetDesktopElementsincludeChildProcesses != null)
            {
                if (uIAGetDesktopElementsincludeChildProcesses != null)
                {
                    uIAGetDesktopElements["IncludeChildProcesses"] = CSharpExpressionConverter.ConvertToken(uIAGetDesktopElementsincludeChildProcesses);
                    uIAGetDesktopElementspropCount++;
                }

                uIAGetDesktopElementspropCount++;
            }
            else
            {
                uIAGetDesktopElements["IncludeChildProcesses"] = false;
                uIAGetDesktopElementspropCount++;
            }

            uIAGetDesktopElementspropCount++;
            uIAGetDesktopElements["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetDesktopElementsworkflow);
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
            uIAExpandElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAExpandElementparentWindowHandle);
            if (uIAExpandElementsearchElementName != null)
            {
                uIAExpandElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAExpandElementsearchElementName);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementsearchElementClassName != null)
            {
                uIAExpandElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAExpandElementsearchElementClassName);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementsearchElementAutomationId != null)
            {
                uIAExpandElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAExpandElementsearchElementAutomationId);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementsearchLocalizedControlType != null)
            {
                uIAExpandElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAExpandElementsearchLocalizedControlType);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementsearchSubTree != null)
            {
                if (uIAExpandElementsearchSubTree != null)
                {
                    uIAExpandElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAExpandElementsearchSubTree);
                    uIAExpandElementpropCount++;
                }

                uIAExpandElementpropCount++;
            }
            else
            {
                uIAExpandElement["SearchSubTree"] = true;
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementmatchIndex != null)
            {
                if (uIAExpandElementmatchIndex != null)
                {
                    uIAExpandElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAExpandElementmatchIndex);
                    uIAExpandElementpropCount++;
                }

                uIAExpandElementpropCount++;
            }
            else
            {
                uIAExpandElement["MatchIndex"] = 1;
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementsearchFilter != null)
            {
                uIAExpandElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAExpandElementsearchFilter);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementsortByColumn != null)
            {
                uIAExpandElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAExpandElementsortByColumn);
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementmatchIndexAscending != null)
            {
                if (uIAExpandElementmatchIndexAscending != null)
                {
                    uIAExpandElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAExpandElementmatchIndexAscending);
                    uIAExpandElementpropCount++;
                }

                uIAExpandElementpropCount++;
            }
            else
            {
                uIAExpandElement["MatchIndexAscending"] = true;
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementmaxElementsToSearch != null)
            {
                if (uIAExpandElementmaxElementsToSearch != null)
                {
                    uIAExpandElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAExpandElementmaxElementsToSearch);
                    uIAExpandElementpropCount++;
                }

                uIAExpandElementpropCount++;
            }
            else
            {
                uIAExpandElement["MaxElementsToSearch"] = 0;
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementmaxRelativeSearchDepth != null)
            {
                if (uIAExpandElementmaxRelativeSearchDepth != null)
                {
                    uIAExpandElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAExpandElementmaxRelativeSearchDepth);
                    uIAExpandElementpropCount++;
                }

                uIAExpandElementpropCount++;
            }
            else
            {
                uIAExpandElement["MaxRelativeSearchDepth"] = 0;
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIAExpandElementmaxChildElementsToSearchPerNode != null)
                {
                    uIAExpandElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAExpandElementmaxChildElementsToSearchPerNode);
                    uIAExpandElementpropCount++;
                }

                uIAExpandElementpropCount++;
            }
            else
            {
                uIAExpandElement["MaxChildElementsToSearchPerNode"] = 0;
                uIAExpandElementpropCount++;
            }

            if (uIAExpandElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAExpandElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAExpandElementelementLocalizedControlTypesNotToTraverse);
                uIAExpandElementpropCount++;
            }

            uIAExpandElementpropCount++;
            uIAExpandElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAExpandElementworkflow);
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
            uIACollapseElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIACollapseElementparentWindowHandle);
            if (uIACollapseElementsearchElementName != null)
            {
                uIACollapseElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIACollapseElementsearchElementName);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementsearchElementClassName != null)
            {
                uIACollapseElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIACollapseElementsearchElementClassName);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementsearchElementAutomationId != null)
            {
                uIACollapseElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIACollapseElementsearchElementAutomationId);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementsearchLocalizedControlType != null)
            {
                uIACollapseElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIACollapseElementsearchLocalizedControlType);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementsearchSubTree != null)
            {
                if (uIACollapseElementsearchSubTree != null)
                {
                    uIACollapseElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIACollapseElementsearchSubTree);
                    uIACollapseElementpropCount++;
                }

                uIACollapseElementpropCount++;
            }
            else
            {
                uIACollapseElement["SearchSubTree"] = true;
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementmatchIndex != null)
            {
                if (uIACollapseElementmatchIndex != null)
                {
                    uIACollapseElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIACollapseElementmatchIndex);
                    uIACollapseElementpropCount++;
                }

                uIACollapseElementpropCount++;
            }
            else
            {
                uIACollapseElement["MatchIndex"] = 1;
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementsearchFilter != null)
            {
                uIACollapseElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIACollapseElementsearchFilter);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementsortByColumn != null)
            {
                uIACollapseElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIACollapseElementsortByColumn);
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementmatchIndexAscending != null)
            {
                if (uIACollapseElementmatchIndexAscending != null)
                {
                    uIACollapseElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIACollapseElementmatchIndexAscending);
                    uIACollapseElementpropCount++;
                }

                uIACollapseElementpropCount++;
            }
            else
            {
                uIACollapseElement["MatchIndexAscending"] = true;
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementmaxElementsToSearch != null)
            {
                if (uIACollapseElementmaxElementsToSearch != null)
                {
                    uIACollapseElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIACollapseElementmaxElementsToSearch);
                    uIACollapseElementpropCount++;
                }

                uIACollapseElementpropCount++;
            }
            else
            {
                uIACollapseElement["MaxElementsToSearch"] = 0;
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementmaxRelativeSearchDepth != null)
            {
                if (uIACollapseElementmaxRelativeSearchDepth != null)
                {
                    uIACollapseElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIACollapseElementmaxRelativeSearchDepth);
                    uIACollapseElementpropCount++;
                }

                uIACollapseElementpropCount++;
            }
            else
            {
                uIACollapseElement["MaxRelativeSearchDepth"] = 0;
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIACollapseElementmaxChildElementsToSearchPerNode != null)
                {
                    uIACollapseElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIACollapseElementmaxChildElementsToSearchPerNode);
                    uIACollapseElementpropCount++;
                }

                uIACollapseElementpropCount++;
            }
            else
            {
                uIACollapseElement["MaxChildElementsToSearchPerNode"] = 0;
                uIACollapseElementpropCount++;
            }

            if (uIACollapseElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIACollapseElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIACollapseElementelementLocalizedControlTypesNotToTraverse);
                uIACollapseElementpropCount++;
            }

            uIACollapseElementpropCount++;
            uIACollapseElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIACollapseElementworkflow);
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
            uIATakeScreenShotOfElementLocation["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationparentWindowHandle);
            if (uIATakeScreenShotOfElementLocationsearchElementName != null)
            {
                uIATakeScreenShotOfElementLocation["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationsearchElementName);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationsearchElementClassName != null)
            {
                uIATakeScreenShotOfElementLocation["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationsearchElementClassName);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationsearchElementAutomationId != null)
            {
                uIATakeScreenShotOfElementLocation["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationsearchElementAutomationId);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationsearchLocalizedControlType != null)
            {
                uIATakeScreenShotOfElementLocation["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationsearchLocalizedControlType);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationsearchSubTree != null)
            {
                if (uIATakeScreenShotOfElementLocationsearchSubTree != null)
                {
                    uIATakeScreenShotOfElementLocation["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationsearchSubTree);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                uIATakeScreenShotOfElementLocationpropCount++;
            }
            else
            {
                uIATakeScreenShotOfElementLocation["SearchSubTree"] = true;
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationimageFormat != null)
            {
                uIATakeScreenShotOfElementLocation["ImageFormat"] = CSharpExpressionConverter.Convert(uIATakeScreenShotOfElementLocationimageFormat);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationmatchIndex != null)
            {
                if (uIATakeScreenShotOfElementLocationmatchIndex != null)
                {
                    uIATakeScreenShotOfElementLocation["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationmatchIndex);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                uIATakeScreenShotOfElementLocationpropCount++;
            }
            else
            {
                uIATakeScreenShotOfElementLocation["MatchIndex"] = 1;
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationsearchFilter != null)
            {
                uIATakeScreenShotOfElementLocation["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationsearchFilter);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationsortByColumn != null)
            {
                uIATakeScreenShotOfElementLocation["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationsortByColumn);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationmatchIndexAscending != null)
            {
                if (uIATakeScreenShotOfElementLocationmatchIndexAscending != null)
                {
                    uIATakeScreenShotOfElementLocation["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationmatchIndexAscending);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                uIATakeScreenShotOfElementLocationpropCount++;
            }
            else
            {
                uIATakeScreenShotOfElementLocation["MatchIndexAscending"] = true;
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationhideAgent != null)
            {
                if (uIATakeScreenShotOfElementLocationhideAgent != null)
                {
                    uIATakeScreenShotOfElementLocation["HideAgent"] = CSharpExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationhideAgent);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                uIATakeScreenShotOfElementLocationpropCount++;
            }
            else
            {
                uIATakeScreenShotOfElementLocation["HideAgent"] = false;
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationmaxElementsToSearch != null)
            {
                if (uIATakeScreenShotOfElementLocationmaxElementsToSearch != null)
                {
                    uIATakeScreenShotOfElementLocation["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationmaxElementsToSearch);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                uIATakeScreenShotOfElementLocationpropCount++;
            }
            else
            {
                uIATakeScreenShotOfElementLocation["MaxElementsToSearch"] = 0;
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationmaxRelativeSearchDepth != null)
            {
                if (uIATakeScreenShotOfElementLocationmaxRelativeSearchDepth != null)
                {
                    uIATakeScreenShotOfElementLocation["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationmaxRelativeSearchDepth);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                uIATakeScreenShotOfElementLocationpropCount++;
            }
            else
            {
                uIATakeScreenShotOfElementLocation["MaxRelativeSearchDepth"] = 0;
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationmaxChildElementsToSearchPerNode != null)
            {
                if (uIATakeScreenShotOfElementLocationmaxChildElementsToSearchPerNode != null)
                {
                    uIATakeScreenShotOfElementLocation["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationmaxChildElementsToSearchPerNode);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                uIATakeScreenShotOfElementLocationpropCount++;
            }
            else
            {
                uIATakeScreenShotOfElementLocation["MaxChildElementsToSearchPerNode"] = 0;
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationelementLocalizedControlTypesNotToTraverse != null)
            {
                uIATakeScreenShotOfElementLocation["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationelementLocalizedControlTypesNotToTraverse);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            uIATakeScreenShotOfElementLocationpropCount++;
            uIATakeScreenShotOfElementLocation["Workflow"] = CSharpExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationworkflow);
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
            uIADrawRectangleAroundElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIADrawRectangleAroundElementparentWindowHandle);
            if (uIADrawRectangleAroundElementsearchElementName != null)
            {
                uIADrawRectangleAroundElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIADrawRectangleAroundElementsearchElementName);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementsearchElementClassName != null)
            {
                uIADrawRectangleAroundElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIADrawRectangleAroundElementsearchElementClassName);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementsearchElementAutomationId != null)
            {
                uIADrawRectangleAroundElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIADrawRectangleAroundElementsearchElementAutomationId);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementsearchLocalizedControlType != null)
            {
                uIADrawRectangleAroundElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIADrawRectangleAroundElementsearchLocalizedControlType);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementsearchSubTree != null)
            {
                if (uIADrawRectangleAroundElementsearchSubTree != null)
                {
                    uIADrawRectangleAroundElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIADrawRectangleAroundElementsearchSubTree);
                    uIADrawRectangleAroundElementpropCount++;
                }

                uIADrawRectangleAroundElementpropCount++;
            }
            else
            {
                uIADrawRectangleAroundElement["SearchSubTree"] = true;
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementpenColour != null)
            {
                if (uIADrawRectangleAroundElementpenColour != null)
                {
                    uIADrawRectangleAroundElement["PenColour"] = CSharpExpressionConverter.ConvertToken(uIADrawRectangleAroundElementpenColour);
                    uIADrawRectangleAroundElementpropCount++;
                }

                uIADrawRectangleAroundElementpropCount++;
            }
            else
            {
                uIADrawRectangleAroundElement["PenColour"] = "#800080";
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementpenThicknessPixels != null)
            {
                if (uIADrawRectangleAroundElementpenThicknessPixels != null)
                {
                    uIADrawRectangleAroundElement["PenThicknessPixels"] = CSharpExpressionConverter.ConvertToken(uIADrawRectangleAroundElementpenThicknessPixels);
                    uIADrawRectangleAroundElementpropCount++;
                }

                uIADrawRectangleAroundElementpropCount++;
            }
            else
            {
                uIADrawRectangleAroundElement["PenThicknessPixels"] = 4;
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementmatchIndex != null)
            {
                if (uIADrawRectangleAroundElementmatchIndex != null)
                {
                    uIADrawRectangleAroundElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIADrawRectangleAroundElementmatchIndex);
                    uIADrawRectangleAroundElementpropCount++;
                }

                uIADrawRectangleAroundElementpropCount++;
            }
            else
            {
                uIADrawRectangleAroundElement["MatchIndex"] = 1;
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementsearchFilter != null)
            {
                uIADrawRectangleAroundElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIADrawRectangleAroundElementsearchFilter);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementsortByColumn != null)
            {
                uIADrawRectangleAroundElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIADrawRectangleAroundElementsortByColumn);
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementmatchIndexAscending != null)
            {
                if (uIADrawRectangleAroundElementmatchIndexAscending != null)
                {
                    uIADrawRectangleAroundElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIADrawRectangleAroundElementmatchIndexAscending);
                    uIADrawRectangleAroundElementpropCount++;
                }

                uIADrawRectangleAroundElementpropCount++;
            }
            else
            {
                uIADrawRectangleAroundElement["MatchIndexAscending"] = true;
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementmaxElementsToSearch != null)
            {
                if (uIADrawRectangleAroundElementmaxElementsToSearch != null)
                {
                    uIADrawRectangleAroundElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIADrawRectangleAroundElementmaxElementsToSearch);
                    uIADrawRectangleAroundElementpropCount++;
                }

                uIADrawRectangleAroundElementpropCount++;
            }
            else
            {
                uIADrawRectangleAroundElement["MaxElementsToSearch"] = 0;
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementmaxRelativeSearchDepth != null)
            {
                if (uIADrawRectangleAroundElementmaxRelativeSearchDepth != null)
                {
                    uIADrawRectangleAroundElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIADrawRectangleAroundElementmaxRelativeSearchDepth);
                    uIADrawRectangleAroundElementpropCount++;
                }

                uIADrawRectangleAroundElementpropCount++;
            }
            else
            {
                uIADrawRectangleAroundElement["MaxRelativeSearchDepth"] = 0;
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIADrawRectangleAroundElementmaxChildElementsToSearchPerNode != null)
                {
                    uIADrawRectangleAroundElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIADrawRectangleAroundElementmaxChildElementsToSearchPerNode);
                    uIADrawRectangleAroundElementpropCount++;
                }

                uIADrawRectangleAroundElementpropCount++;
            }
            else
            {
                uIADrawRectangleAroundElement["MaxChildElementsToSearchPerNode"] = 0;
                uIADrawRectangleAroundElementpropCount++;
            }

            if (uIADrawRectangleAroundElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIADrawRectangleAroundElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIADrawRectangleAroundElementelementLocalizedControlTypesNotToTraverse);
                uIADrawRectangleAroundElementpropCount++;
            }

            uIADrawRectangleAroundElementpropCount++;
            uIADrawRectangleAroundElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIADrawRectangleAroundElementworkflow);
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
            uIAGetParentElementHandle["ElementHandle"] = CSharpExpressionConverter.ConvertToken(uIAGetParentElementHandleelementHandle);
            uIAGetParentElementHandlepropCount++;
            uIAGetParentElementHandle["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetParentElementHandleworkflow);
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
                uIAGetDataGridElementContents["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsparentWindowHandle);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentssearchElementName != null)
            {
                uIAGetDataGridElementContents["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentssearchElementName);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentssearchElementClassName != null)
            {
                uIAGetDataGridElementContents["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentssearchElementClassName);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentssearchElementAutomationId != null)
            {
                uIAGetDataGridElementContents["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentssearchElementAutomationId);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentssearchLocalizedControlType != null)
            {
                uIAGetDataGridElementContents["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentssearchLocalizedControlType);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentssearchSubTree != null)
            {
                if (uIAGetDataGridElementContentssearchSubTree != null)
                {
                    uIAGetDataGridElementContents["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentssearchSubTree);
                    uIAGetDataGridElementContentspropCount++;
                }

                uIAGetDataGridElementContentspropCount++;
            }
            else
            {
                uIAGetDataGridElementContents["SearchSubTree"] = true;
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsonScreenColumnsOnly != null)
            {
                if (uIAGetDataGridElementContentsonScreenColumnsOnly != null)
                {
                    uIAGetDataGridElementContents["OnScreenColumnsOnly"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsonScreenColumnsOnly);
                    uIAGetDataGridElementContentspropCount++;
                }

                uIAGetDataGridElementContentspropCount++;
            }
            else
            {
                uIAGetDataGridElementContents["OnScreenColumnsOnly"] = true;
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsonScreenRowsOnly != null)
            {
                if (uIAGetDataGridElementContentsonScreenRowsOnly != null)
                {
                    uIAGetDataGridElementContents["OnScreenRowsOnly"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsonScreenRowsOnly);
                    uIAGetDataGridElementContentspropCount++;
                }

                uIAGetDataGridElementContentspropCount++;
            }
            else
            {
                uIAGetDataGridElementContents["OnScreenRowsOnly"] = true;
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsreturnNullValuesAsBlank != null)
            {
                if (uIAGetDataGridElementContentsreturnNullValuesAsBlank != null)
                {
                    uIAGetDataGridElementContents["ReturnNullValuesAsBlank"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsreturnNullValuesAsBlank);
                    uIAGetDataGridElementContentspropCount++;
                }

                uIAGetDataGridElementContentspropCount++;
            }
            else
            {
                uIAGetDataGridElementContents["ReturnNullValuesAsBlank"] = true;
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsalternativeHeaderRowName != null)
            {
                uIAGetDataGridElementContents["AlternativeHeaderRowName"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsalternativeHeaderRowName);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsreturnRowUIAName != null)
            {
                if (uIAGetDataGridElementContentsreturnRowUIAName != null)
                {
                    uIAGetDataGridElementContents["ReturnRowUIAName"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsreturnRowUIAName);
                    uIAGetDataGridElementContentspropCount++;
                }

                uIAGetDataGridElementContentspropCount++;
            }
            else
            {
                uIAGetDataGridElementContents["ReturnRowUIAName"] = false;
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsnameOfColumnToStoreRowUIAName != null)
            {
                uIAGetDataGridElementContents["NameOfColumnToStoreRowUIAName"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsnameOfColumnToStoreRowUIAName);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsmatchIndex != null)
            {
                if (uIAGetDataGridElementContentsmatchIndex != null)
                {
                    uIAGetDataGridElementContents["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsmatchIndex);
                    uIAGetDataGridElementContentspropCount++;
                }

                uIAGetDataGridElementContentspropCount++;
            }
            else
            {
                uIAGetDataGridElementContents["MatchIndex"] = 1;
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentssearchFilter != null)
            {
                uIAGetDataGridElementContents["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentssearchFilter);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentssortByColumn != null)
            {
                uIAGetDataGridElementContents["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentssortByColumn);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsmatchIndexAscending != null)
            {
                if (uIAGetDataGridElementContentsmatchIndexAscending != null)
                {
                    uIAGetDataGridElementContents["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsmatchIndexAscending);
                    uIAGetDataGridElementContentspropCount++;
                }

                uIAGetDataGridElementContentspropCount++;
            }
            else
            {
                uIAGetDataGridElementContents["MatchIndexAscending"] = true;
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsfirstItemToReturn != null)
            {
                if (uIAGetDataGridElementContentsfirstItemToReturn != null)
                {
                    uIAGetDataGridElementContents["FirstItemToReturn"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsfirstItemToReturn);
                    uIAGetDataGridElementContentspropCount++;
                }

                uIAGetDataGridElementContentspropCount++;
            }
            else
            {
                uIAGetDataGridElementContents["FirstItemToReturn"] = 1;
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsmaxItemsToReturn != null)
            {
                if (uIAGetDataGridElementContentsmaxItemsToReturn != null)
                {
                    uIAGetDataGridElementContents["MaxItemsToReturn"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsmaxItemsToReturn);
                    uIAGetDataGridElementContentspropCount++;
                }

                uIAGetDataGridElementContentspropCount++;
            }
            else
            {
                uIAGetDataGridElementContents["MaxItemsToReturn"] = 0;
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsscanFirstNRowsForEmptyRows != null)
            {
                if (uIAGetDataGridElementContentsscanFirstNRowsForEmptyRows != null)
                {
                    uIAGetDataGridElementContents["ScanFirstNRowsForEmptyRows"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsscanFirstNRowsForEmptyRows);
                    uIAGetDataGridElementContentspropCount++;
                }

                uIAGetDataGridElementContentspropCount++;
            }
            else
            {
                uIAGetDataGridElementContents["ScanFirstNRowsForEmptyRows"] = 0;
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsreadTableAsThread != null)
            {
                if (uIAGetDataGridElementContentsreadTableAsThread != null)
                {
                    uIAGetDataGridElementContents["ReadTableAsThread"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsreadTableAsThread);
                    uIAGetDataGridElementContentspropCount++;
                }

                uIAGetDataGridElementContentspropCount++;
            }
            else
            {
                uIAGetDataGridElementContents["ReadTableAsThread"] = false;
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsretrieveOutputDataFromThreadId != null)
            {
                uIAGetDataGridElementContents["RetrieveOutputDataFromThreadId"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsretrieveOutputDataFromThreadId);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentssecondsToWaitForThread != null)
            {
                if (uIAGetDataGridElementContentssecondsToWaitForThread != null)
                {
                    uIAGetDataGridElementContents["SecondsToWaitForThread"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentssecondsToWaitForThread);
                    uIAGetDataGridElementContentspropCount++;
                }

                uIAGetDataGridElementContentspropCount++;
            }
            else
            {
                uIAGetDataGridElementContents["SecondsToWaitForThread"] = 90;
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNPercent != null)
            {
                if (uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNPercent != null)
                {
                    uIAGetDataGridElementContents["ScrollDataGridVerticallyEveryNPercent"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNPercent);
                    uIAGetDataGridElementContentspropCount++;
                }

                uIAGetDataGridElementContentspropCount++;
            }
            else
            {
                uIAGetDataGridElementContents["ScrollDataGridVerticallyEveryNPercent"] = 0;
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNRows != null)
            {
                if (uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNRows != null)
                {
                    uIAGetDataGridElementContents["ScrollDataGridVerticallyEveryNRows"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNRows);
                    uIAGetDataGridElementContentspropCount++;
                }

                uIAGetDataGridElementContentspropCount++;
            }
            else
            {
                uIAGetDataGridElementContents["ScrollDataGridVerticallyEveryNRows"] = 0;
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsscrollDataGridVerticallyElementHandle != null)
            {
                if (uIAGetDataGridElementContentsscrollDataGridVerticallyElementHandle != null)
                {
                    uIAGetDataGridElementContents["ScrollDataGridVerticallyElementHandle"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsscrollDataGridVerticallyElementHandle);
                    uIAGetDataGridElementContentspropCount++;
                }

                uIAGetDataGridElementContentspropCount++;
            }
            else
            {
                uIAGetDataGridElementContents["ScrollDataGridVerticallyElementHandle"] = 0;
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsminimumDataGridRowsForScrolling != null)
            {
                if (uIAGetDataGridElementContentsminimumDataGridRowsForScrolling != null)
                {
                    uIAGetDataGridElementContents["MinimumDataGridRowsForScrolling"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsminimumDataGridRowsForScrolling);
                    uIAGetDataGridElementContentspropCount++;
                }

                uIAGetDataGridElementContentspropCount++;
            }
            else
            {
                uIAGetDataGridElementContents["MinimumDataGridRowsForScrolling"] = 200;
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsraiseExceptionIfCannotScroll != null)
            {
                if (uIAGetDataGridElementContentsraiseExceptionIfCannotScroll != null)
                {
                    uIAGetDataGridElementContents["RaiseExceptionIfCannotScroll"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsraiseExceptionIfCannotScroll);
                    uIAGetDataGridElementContentspropCount++;
                }

                uIAGetDataGridElementContentspropCount++;
            }
            else
            {
                uIAGetDataGridElementContents["RaiseExceptionIfCannotScroll"] = false;
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsalternativeVerticalScrollbarName != null)
            {
                uIAGetDataGridElementContents["AlternativeVerticalScrollbarName"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsalternativeVerticalScrollbarName);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsmaxElementsToSearch != null)
            {
                if (uIAGetDataGridElementContentsmaxElementsToSearch != null)
                {
                    uIAGetDataGridElementContents["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsmaxElementsToSearch);
                    uIAGetDataGridElementContentspropCount++;
                }

                uIAGetDataGridElementContentspropCount++;
            }
            else
            {
                uIAGetDataGridElementContents["MaxElementsToSearch"] = 0;
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsmaxRelativeSearchDepth != null)
            {
                if (uIAGetDataGridElementContentsmaxRelativeSearchDepth != null)
                {
                    uIAGetDataGridElementContents["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsmaxRelativeSearchDepth);
                    uIAGetDataGridElementContentspropCount++;
                }

                uIAGetDataGridElementContentspropCount++;
            }
            else
            {
                uIAGetDataGridElementContents["MaxRelativeSearchDepth"] = 0;
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsmaxChildElementsToSearchPerNode != null)
            {
                if (uIAGetDataGridElementContentsmaxChildElementsToSearchPerNode != null)
                {
                    uIAGetDataGridElementContents["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsmaxChildElementsToSearchPerNode);
                    uIAGetDataGridElementContentspropCount++;
                }

                uIAGetDataGridElementContentspropCount++;
            }
            else
            {
                uIAGetDataGridElementContents["MaxChildElementsToSearchPerNode"] = 0;
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentselementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetDataGridElementContents["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentselementLocalizedControlTypesNotToTraverse);
                uIAGetDataGridElementContentspropCount++;
            }

            uIAGetDataGridElementContentspropCount++;
            uIAGetDataGridElementContents["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementContentsworkflow);
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
            uIAGetDataGridElementProperties["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiesparentWindowHandle);
            if (uIAGetDataGridElementPropertiessearchElementName != null)
            {
                uIAGetDataGridElementProperties["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiessearchElementName);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiessearchElementClassName != null)
            {
                uIAGetDataGridElementProperties["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiessearchElementClassName);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiessearchElementAutomationId != null)
            {
                uIAGetDataGridElementProperties["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiessearchElementAutomationId);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiessearchLocalizedControlType != null)
            {
                uIAGetDataGridElementProperties["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiessearchLocalizedControlType);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiessearchSubTree != null)
            {
                if (uIAGetDataGridElementPropertiessearchSubTree != null)
                {
                    uIAGetDataGridElementProperties["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiessearchSubTree);
                    uIAGetDataGridElementPropertiespropCount++;
                }

                uIAGetDataGridElementPropertiespropCount++;
            }
            else
            {
                uIAGetDataGridElementProperties["SearchSubTree"] = true;
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesalternativeHeaderRowName != null)
            {
                uIAGetDataGridElementProperties["AlternativeHeaderRowName"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiesalternativeHeaderRowName);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesmatchIndex != null)
            {
                if (uIAGetDataGridElementPropertiesmatchIndex != null)
                {
                    uIAGetDataGridElementProperties["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiesmatchIndex);
                    uIAGetDataGridElementPropertiespropCount++;
                }

                uIAGetDataGridElementPropertiespropCount++;
            }
            else
            {
                uIAGetDataGridElementProperties["MatchIndex"] = 1;
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiessearchFilter != null)
            {
                uIAGetDataGridElementProperties["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiessearchFilter);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiessortByColumn != null)
            {
                uIAGetDataGridElementProperties["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiessortByColumn);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesmatchIndexAscending != null)
            {
                if (uIAGetDataGridElementPropertiesmatchIndexAscending != null)
                {
                    uIAGetDataGridElementProperties["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiesmatchIndexAscending);
                    uIAGetDataGridElementPropertiespropCount++;
                }

                uIAGetDataGridElementPropertiespropCount++;
            }
            else
            {
                uIAGetDataGridElementProperties["MatchIndexAscending"] = true;
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesmaxElementsToSearch != null)
            {
                if (uIAGetDataGridElementPropertiesmaxElementsToSearch != null)
                {
                    uIAGetDataGridElementProperties["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiesmaxElementsToSearch);
                    uIAGetDataGridElementPropertiespropCount++;
                }

                uIAGetDataGridElementPropertiespropCount++;
            }
            else
            {
                uIAGetDataGridElementProperties["MaxElementsToSearch"] = 0;
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesmaxRelativeSearchDepth != null)
            {
                if (uIAGetDataGridElementPropertiesmaxRelativeSearchDepth != null)
                {
                    uIAGetDataGridElementProperties["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiesmaxRelativeSearchDepth);
                    uIAGetDataGridElementPropertiespropCount++;
                }

                uIAGetDataGridElementPropertiespropCount++;
            }
            else
            {
                uIAGetDataGridElementProperties["MaxRelativeSearchDepth"] = 0;
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesmaxChildElementsToSearchPerNode != null)
            {
                if (uIAGetDataGridElementPropertiesmaxChildElementsToSearchPerNode != null)
                {
                    uIAGetDataGridElementProperties["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiesmaxChildElementsToSearchPerNode);
                    uIAGetDataGridElementPropertiespropCount++;
                }

                uIAGetDataGridElementPropertiespropCount++;
            }
            else
            {
                uIAGetDataGridElementProperties["MaxChildElementsToSearchPerNode"] = 0;
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertieselementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetDataGridElementProperties["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementPropertieselementLocalizedControlTypesNotToTraverse);
                uIAGetDataGridElementPropertiespropCount++;
            }

            uIAGetDataGridElementPropertiespropCount++;
            uIAGetDataGridElementProperties["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiesworkflow);
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
            uIAGetListElementItems["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAGetListElementItemsparentWindowHandle);
            if (uIAGetListElementItemssearchElementName != null)
            {
                uIAGetListElementItems["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAGetListElementItemssearchElementName);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemssearchElementClassName != null)
            {
                uIAGetListElementItems["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAGetListElementItemssearchElementClassName);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemssearchElementAutomationId != null)
            {
                uIAGetListElementItems["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAGetListElementItemssearchElementAutomationId);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemssearchLocalizedControlType != null)
            {
                uIAGetListElementItems["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAGetListElementItemssearchLocalizedControlType);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemssearchSubTree != null)
            {
                if (uIAGetListElementItemssearchSubTree != null)
                {
                    uIAGetListElementItems["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAGetListElementItemssearchSubTree);
                    uIAGetListElementItemspropCount++;
                }

                uIAGetListElementItemspropCount++;
            }
            else
            {
                uIAGetListElementItems["SearchSubTree"] = true;
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsexpandFirst != null)
            {
                if (uIAGetListElementItemsexpandFirst != null)
                {
                    uIAGetListElementItems["ExpandFirst"] = CSharpExpressionConverter.ConvertToken(uIAGetListElementItemsexpandFirst);
                    uIAGetListElementItemspropCount++;
                }

                uIAGetListElementItemspropCount++;
            }
            else
            {
                uIAGetListElementItems["ExpandFirst"] = false;
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemscollapseAfter != null)
            {
                if (uIAGetListElementItemscollapseAfter != null)
                {
                    uIAGetListElementItems["CollapseAfter"] = CSharpExpressionConverter.ConvertToken(uIAGetListElementItemscollapseAfter);
                    uIAGetListElementItemspropCount++;
                }

                uIAGetListElementItemspropCount++;
            }
            else
            {
                uIAGetListElementItems["CollapseAfter"] = false;
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemscheckForSelectedItems != null)
            {
                if (uIAGetListElementItemscheckForSelectedItems != null)
                {
                    uIAGetListElementItems["CheckForSelectedItems"] = CSharpExpressionConverter.ConvertToken(uIAGetListElementItemscheckForSelectedItems);
                    uIAGetListElementItemspropCount++;
                }

                uIAGetListElementItemspropCount++;
            }
            else
            {
                uIAGetListElementItems["CheckForSelectedItems"] = true;
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemssecondsBetweenExpandCollapse != null)
            {
                if (uIAGetListElementItemssecondsBetweenExpandCollapse != null)
                {
                    uIAGetListElementItems["SecondsBetweenExpandCollapse"] = CSharpExpressionConverter.ConvertToken(uIAGetListElementItemssecondsBetweenExpandCollapse);
                    uIAGetListElementItemspropCount++;
                }

                uIAGetListElementItemspropCount++;
            }
            else
            {
                uIAGetListElementItems["SecondsBetweenExpandCollapse"] = 0;
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsmatchIndex != null)
            {
                if (uIAGetListElementItemsmatchIndex != null)
                {
                    uIAGetListElementItems["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAGetListElementItemsmatchIndex);
                    uIAGetListElementItemspropCount++;
                }

                uIAGetListElementItemspropCount++;
            }
            else
            {
                uIAGetListElementItems["MatchIndex"] = 1;
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemssearchFilter != null)
            {
                uIAGetListElementItems["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAGetListElementItemssearchFilter);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemssortByColumn != null)
            {
                uIAGetListElementItems["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAGetListElementItemssortByColumn);
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsmatchIndexAscending != null)
            {
                if (uIAGetListElementItemsmatchIndexAscending != null)
                {
                    uIAGetListElementItems["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAGetListElementItemsmatchIndexAscending);
                    uIAGetListElementItemspropCount++;
                }

                uIAGetListElementItemspropCount++;
            }
            else
            {
                uIAGetListElementItems["MatchIndexAscending"] = true;
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsmaxElementsToSearch != null)
            {
                if (uIAGetListElementItemsmaxElementsToSearch != null)
                {
                    uIAGetListElementItems["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAGetListElementItemsmaxElementsToSearch);
                    uIAGetListElementItemspropCount++;
                }

                uIAGetListElementItemspropCount++;
            }
            else
            {
                uIAGetListElementItems["MaxElementsToSearch"] = 0;
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsmaxRelativeSearchDepth != null)
            {
                if (uIAGetListElementItemsmaxRelativeSearchDepth != null)
                {
                    uIAGetListElementItems["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAGetListElementItemsmaxRelativeSearchDepth);
                    uIAGetListElementItemspropCount++;
                }

                uIAGetListElementItemspropCount++;
            }
            else
            {
                uIAGetListElementItems["MaxRelativeSearchDepth"] = 0;
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemsmaxChildElementsToSearchPerNode != null)
            {
                if (uIAGetListElementItemsmaxChildElementsToSearchPerNode != null)
                {
                    uIAGetListElementItems["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAGetListElementItemsmaxChildElementsToSearchPerNode);
                    uIAGetListElementItemspropCount++;
                }

                uIAGetListElementItemspropCount++;
            }
            else
            {
                uIAGetListElementItems["MaxChildElementsToSearchPerNode"] = 0;
                uIAGetListElementItemspropCount++;
            }

            if (uIAGetListElementItemselementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetListElementItems["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAGetListElementItemselementLocalizedControlTypesNotToTraverse);
                uIAGetListElementItemspropCount++;
            }

            uIAGetListElementItemspropCount++;
            uIAGetListElementItems["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetListElementItemsworkflow);
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
            uIAClickListElementItemByName["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByNameparentWindowHandle);
            if (uIAClickListElementItemByNamesearchElementName != null)
            {
                uIAClickListElementItemByName["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByNamesearchElementName);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamesearchElementClassName != null)
            {
                uIAClickListElementItemByName["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByNamesearchElementClassName);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamesearchElementAutomationId != null)
            {
                uIAClickListElementItemByName["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByNamesearchElementAutomationId);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamesearchLocalizedControlType != null)
            {
                uIAClickListElementItemByName["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByNamesearchLocalizedControlType);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamesearchSubTree != null)
            {
                if (uIAClickListElementItemByNamesearchSubTree != null)
                {
                    uIAClickListElementItemByName["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByNamesearchSubTree);
                    uIAClickListElementItemByNamepropCount++;
                }

                uIAClickListElementItemByNamepropCount++;
            }
            else
            {
                uIAClickListElementItemByName["SearchSubTree"] = true;
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNameexpandFirst != null)
            {
                if (uIAClickListElementItemByNameexpandFirst != null)
                {
                    uIAClickListElementItemByName["ExpandFirst"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByNameexpandFirst);
                    uIAClickListElementItemByNamepropCount++;
                }

                uIAClickListElementItemByNamepropCount++;
            }
            else
            {
                uIAClickListElementItemByName["ExpandFirst"] = false;
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamecollapseAfter != null)
            {
                if (uIAClickListElementItemByNamecollapseAfter != null)
                {
                    uIAClickListElementItemByName["CollapseAfter"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByNamecollapseAfter);
                    uIAClickListElementItemByNamepropCount++;
                }

                uIAClickListElementItemByNamepropCount++;
            }
            else
            {
                uIAClickListElementItemByName["CollapseAfter"] = false;
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNameitemName != null)
            {
                uIAClickListElementItemByName["ItemName"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByNameitemName);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamesecondsBetweenExpandCollapse != null)
            {
                uIAClickListElementItemByName["SecondsBetweenExpandCollapse"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByNamesecondsBetweenExpandCollapse);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamematchIndex != null)
            {
                if (uIAClickListElementItemByNamematchIndex != null)
                {
                    uIAClickListElementItemByName["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByNamematchIndex);
                    uIAClickListElementItemByNamepropCount++;
                }

                uIAClickListElementItemByNamepropCount++;
            }
            else
            {
                uIAClickListElementItemByName["MatchIndex"] = 1;
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamesearchFilter != null)
            {
                uIAClickListElementItemByName["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByNamesearchFilter);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamesortByColumn != null)
            {
                uIAClickListElementItemByName["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByNamesortByColumn);
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamematchIndexAscending != null)
            {
                if (uIAClickListElementItemByNamematchIndexAscending != null)
                {
                    uIAClickListElementItemByName["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByNamematchIndexAscending);
                    uIAClickListElementItemByNamepropCount++;
                }

                uIAClickListElementItemByNamepropCount++;
            }
            else
            {
                uIAClickListElementItemByName["MatchIndexAscending"] = true;
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamemaxElementsToSearch != null)
            {
                if (uIAClickListElementItemByNamemaxElementsToSearch != null)
                {
                    uIAClickListElementItemByName["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByNamemaxElementsToSearch);
                    uIAClickListElementItemByNamepropCount++;
                }

                uIAClickListElementItemByNamepropCount++;
            }
            else
            {
                uIAClickListElementItemByName["MaxElementsToSearch"] = 0;
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamemaxRelativeSearchDepth != null)
            {
                if (uIAClickListElementItemByNamemaxRelativeSearchDepth != null)
                {
                    uIAClickListElementItemByName["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByNamemaxRelativeSearchDepth);
                    uIAClickListElementItemByNamepropCount++;
                }

                uIAClickListElementItemByNamepropCount++;
            }
            else
            {
                uIAClickListElementItemByName["MaxRelativeSearchDepth"] = 0;
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNamemaxChildElementsToSearchPerNode != null)
            {
                if (uIAClickListElementItemByNamemaxChildElementsToSearchPerNode != null)
                {
                    uIAClickListElementItemByName["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByNamemaxChildElementsToSearchPerNode);
                    uIAClickListElementItemByNamepropCount++;
                }

                uIAClickListElementItemByNamepropCount++;
            }
            else
            {
                uIAClickListElementItemByName["MaxChildElementsToSearchPerNode"] = 0;
                uIAClickListElementItemByNamepropCount++;
            }

            if (uIAClickListElementItemByNameelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAClickListElementItemByName["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByNameelementLocalizedControlTypesNotToTraverse);
                uIAClickListElementItemByNamepropCount++;
            }

            uIAClickListElementItemByNamepropCount++;
            uIAClickListElementItemByName["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByNameworkflow);
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
            uIAClickListElementItemByIndex["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByIndexparentWindowHandle);
            if (uIAClickListElementItemByIndexsearchElementName != null)
            {
                uIAClickListElementItemByIndex["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByIndexsearchElementName);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexsearchElementClassName != null)
            {
                uIAClickListElementItemByIndex["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByIndexsearchElementClassName);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexsearchElementAutomationId != null)
            {
                uIAClickListElementItemByIndex["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByIndexsearchElementAutomationId);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexsearchLocalizedControlType != null)
            {
                uIAClickListElementItemByIndex["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByIndexsearchLocalizedControlType);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexsearchSubTree != null)
            {
                if (uIAClickListElementItemByIndexsearchSubTree != null)
                {
                    uIAClickListElementItemByIndex["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByIndexsearchSubTree);
                    uIAClickListElementItemByIndexpropCount++;
                }

                uIAClickListElementItemByIndexpropCount++;
            }
            else
            {
                uIAClickListElementItemByIndex["SearchSubTree"] = true;
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexexpandFirst != null)
            {
                if (uIAClickListElementItemByIndexexpandFirst != null)
                {
                    uIAClickListElementItemByIndex["ExpandFirst"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByIndexexpandFirst);
                    uIAClickListElementItemByIndexpropCount++;
                }

                uIAClickListElementItemByIndexpropCount++;
            }
            else
            {
                uIAClickListElementItemByIndex["ExpandFirst"] = false;
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexcollapseAfter != null)
            {
                if (uIAClickListElementItemByIndexcollapseAfter != null)
                {
                    uIAClickListElementItemByIndex["CollapseAfter"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByIndexcollapseAfter);
                    uIAClickListElementItemByIndexpropCount++;
                }

                uIAClickListElementItemByIndexpropCount++;
            }
            else
            {
                uIAClickListElementItemByIndex["CollapseAfter"] = false;
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexitemIndex != null)
            {
                if (uIAClickListElementItemByIndexitemIndex != null)
                {
                    uIAClickListElementItemByIndex["ItemIndex"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByIndexitemIndex);
                    uIAClickListElementItemByIndexpropCount++;
                }

                uIAClickListElementItemByIndexpropCount++;
            }
            else
            {
                uIAClickListElementItemByIndex["ItemIndex"] = 1;
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexsecondsBetweenExpandCollapse != null)
            {
                uIAClickListElementItemByIndex["SecondsBetweenExpandCollapse"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByIndexsecondsBetweenExpandCollapse);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexmatchIndex != null)
            {
                if (uIAClickListElementItemByIndexmatchIndex != null)
                {
                    uIAClickListElementItemByIndex["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByIndexmatchIndex);
                    uIAClickListElementItemByIndexpropCount++;
                }

                uIAClickListElementItemByIndexpropCount++;
            }
            else
            {
                uIAClickListElementItemByIndex["MatchIndex"] = 1;
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexsearchFilter != null)
            {
                uIAClickListElementItemByIndex["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByIndexsearchFilter);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexsortByColumn != null)
            {
                uIAClickListElementItemByIndex["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByIndexsortByColumn);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexmatchIndexAscending != null)
            {
                if (uIAClickListElementItemByIndexmatchIndexAscending != null)
                {
                    uIAClickListElementItemByIndex["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByIndexmatchIndexAscending);
                    uIAClickListElementItemByIndexpropCount++;
                }

                uIAClickListElementItemByIndexpropCount++;
            }
            else
            {
                uIAClickListElementItemByIndex["MatchIndexAscending"] = true;
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexmaxElementsToSearch != null)
            {
                if (uIAClickListElementItemByIndexmaxElementsToSearch != null)
                {
                    uIAClickListElementItemByIndex["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByIndexmaxElementsToSearch);
                    uIAClickListElementItemByIndexpropCount++;
                }

                uIAClickListElementItemByIndexpropCount++;
            }
            else
            {
                uIAClickListElementItemByIndex["MaxElementsToSearch"] = 0;
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexmaxRelativeSearchDepth != null)
            {
                if (uIAClickListElementItemByIndexmaxRelativeSearchDepth != null)
                {
                    uIAClickListElementItemByIndex["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByIndexmaxRelativeSearchDepth);
                    uIAClickListElementItemByIndexpropCount++;
                }

                uIAClickListElementItemByIndexpropCount++;
            }
            else
            {
                uIAClickListElementItemByIndex["MaxRelativeSearchDepth"] = 0;
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexmaxChildElementsToSearchPerNode != null)
            {
                if (uIAClickListElementItemByIndexmaxChildElementsToSearchPerNode != null)
                {
                    uIAClickListElementItemByIndex["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByIndexmaxChildElementsToSearchPerNode);
                    uIAClickListElementItemByIndexpropCount++;
                }

                uIAClickListElementItemByIndexpropCount++;
            }
            else
            {
                uIAClickListElementItemByIndex["MaxChildElementsToSearchPerNode"] = 0;
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAClickListElementItemByIndex["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByIndexelementLocalizedControlTypesNotToTraverse);
                uIAClickListElementItemByIndexpropCount++;
            }

            uIAClickListElementItemByIndexpropCount++;
            uIAClickListElementItemByIndex["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAClickListElementItemByIndexworkflow);
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
            uIASetElementToNumericValue["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericValueparentWindowHandle);
            if (uIASetElementToNumericValuesearchElementName != null)
            {
                uIASetElementToNumericValue["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericValuesearchElementName);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuesearchElementClassName != null)
            {
                uIASetElementToNumericValue["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericValuesearchElementClassName);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuesearchElementAutomationId != null)
            {
                uIASetElementToNumericValue["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericValuesearchElementAutomationId);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuesearchLocalizedControlType != null)
            {
                uIASetElementToNumericValue["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericValuesearchLocalizedControlType);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuesearchSubTree != null)
            {
                if (uIASetElementToNumericValuesearchSubTree != null)
                {
                    uIASetElementToNumericValue["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericValuesearchSubTree);
                    uIASetElementToNumericValuepropCount++;
                }

                uIASetElementToNumericValuepropCount++;
            }
            else
            {
                uIASetElementToNumericValue["SearchSubTree"] = true;
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuematchIndex != null)
            {
                if (uIASetElementToNumericValuematchIndex != null)
                {
                    uIASetElementToNumericValue["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericValuematchIndex);
                    uIASetElementToNumericValuepropCount++;
                }

                uIASetElementToNumericValuepropCount++;
            }
            else
            {
                uIASetElementToNumericValue["MatchIndex"] = 1;
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuesearchFilter != null)
            {
                uIASetElementToNumericValue["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericValuesearchFilter);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuesortByColumn != null)
            {
                uIASetElementToNumericValue["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericValuesortByColumn);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuematchIndexAscending != null)
            {
                if (uIASetElementToNumericValuematchIndexAscending != null)
                {
                    uIASetElementToNumericValue["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericValuematchIndexAscending);
                    uIASetElementToNumericValuepropCount++;
                }

                uIASetElementToNumericValuepropCount++;
            }
            else
            {
                uIASetElementToNumericValue["MatchIndexAscending"] = true;
                uIASetElementToNumericValuepropCount++;
            }

            uIASetElementToNumericValuepropCount++;
            uIASetElementToNumericValue["NewValue"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericValuenewValue);
            if (uIASetElementToNumericValuemaxElementsToSearch != null)
            {
                if (uIASetElementToNumericValuemaxElementsToSearch != null)
                {
                    uIASetElementToNumericValue["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericValuemaxElementsToSearch);
                    uIASetElementToNumericValuepropCount++;
                }

                uIASetElementToNumericValuepropCount++;
            }
            else
            {
                uIASetElementToNumericValue["MaxElementsToSearch"] = 0;
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuemaxRelativeSearchDepth != null)
            {
                if (uIASetElementToNumericValuemaxRelativeSearchDepth != null)
                {
                    uIASetElementToNumericValue["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericValuemaxRelativeSearchDepth);
                    uIASetElementToNumericValuepropCount++;
                }

                uIASetElementToNumericValuepropCount++;
            }
            else
            {
                uIASetElementToNumericValue["MaxRelativeSearchDepth"] = 0;
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuemaxChildElementsToSearchPerNode != null)
            {
                if (uIASetElementToNumericValuemaxChildElementsToSearchPerNode != null)
                {
                    uIASetElementToNumericValue["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericValuemaxChildElementsToSearchPerNode);
                    uIASetElementToNumericValuepropCount++;
                }

                uIASetElementToNumericValuepropCount++;
            }
            else
            {
                uIASetElementToNumericValue["MaxChildElementsToSearchPerNode"] = 0;
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValueelementLocalizedControlTypesNotToTraverse != null)
            {
                uIASetElementToNumericValue["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericValueelementLocalizedControlTypesNotToTraverse);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValueraiseExceptionIfInputValidationFails != null)
            {
                if (uIASetElementToNumericValueraiseExceptionIfInputValidationFails != null)
                {
                    uIASetElementToNumericValue["RaiseExceptionIfInputValidationFails"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericValueraiseExceptionIfInputValidationFails);
                    uIASetElementToNumericValuepropCount++;
                }

                uIASetElementToNumericValuepropCount++;
            }
            else
            {
                uIASetElementToNumericValue["RaiseExceptionIfInputValidationFails"] = false;
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuetryValuePattern != null)
            {
                if (uIASetElementToNumericValuetryValuePattern != null)
                {
                    uIASetElementToNumericValue["TryValuePattern"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericValuetryValuePattern);
                    uIASetElementToNumericValuepropCount++;
                }

                uIASetElementToNumericValuepropCount++;
            }
            else
            {
                uIASetElementToNumericValue["TryValuePattern"] = true;
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValuetryLegacyPattern != null)
            {
                if (uIASetElementToNumericValuetryLegacyPattern != null)
                {
                    uIASetElementToNumericValue["TryLegacyPattern"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericValuetryLegacyPattern);
                    uIASetElementToNumericValuepropCount++;
                }

                uIASetElementToNumericValuepropCount++;
            }
            else
            {
                uIASetElementToNumericValue["TryLegacyPattern"] = false;
                uIASetElementToNumericValuepropCount++;
            }

            uIASetElementToNumericValuepropCount++;
            uIASetElementToNumericValue["Workflow"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericValueworkflow);
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
            uIASetElementToNumericRangeValue["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericRangeValueparentWindowHandle);
            if (uIASetElementToNumericRangeValuesearchElementName != null)
            {
                uIASetElementToNumericRangeValue["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuesearchElementName);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValuesearchElementClassName != null)
            {
                uIASetElementToNumericRangeValue["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuesearchElementClassName);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValuesearchElementAutomationId != null)
            {
                uIASetElementToNumericRangeValue["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuesearchElementAutomationId);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValuesearchLocalizedControlType != null)
            {
                uIASetElementToNumericRangeValue["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuesearchLocalizedControlType);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValuesearchSubTree != null)
            {
                if (uIASetElementToNumericRangeValuesearchSubTree != null)
                {
                    uIASetElementToNumericRangeValue["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuesearchSubTree);
                    uIASetElementToNumericRangeValuepropCount++;
                }

                uIASetElementToNumericRangeValuepropCount++;
            }
            else
            {
                uIASetElementToNumericRangeValue["SearchSubTree"] = true;
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValuematchIndex != null)
            {
                if (uIASetElementToNumericRangeValuematchIndex != null)
                {
                    uIASetElementToNumericRangeValue["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuematchIndex);
                    uIASetElementToNumericRangeValuepropCount++;
                }

                uIASetElementToNumericRangeValuepropCount++;
            }
            else
            {
                uIASetElementToNumericRangeValue["MatchIndex"] = 1;
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValuesearchFilter != null)
            {
                uIASetElementToNumericRangeValue["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuesearchFilter);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValuesortByColumn != null)
            {
                uIASetElementToNumericRangeValue["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuesortByColumn);
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValuematchIndexAscending != null)
            {
                if (uIASetElementToNumericRangeValuematchIndexAscending != null)
                {
                    uIASetElementToNumericRangeValue["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuematchIndexAscending);
                    uIASetElementToNumericRangeValuepropCount++;
                }

                uIASetElementToNumericRangeValuepropCount++;
            }
            else
            {
                uIASetElementToNumericRangeValue["MatchIndexAscending"] = true;
                uIASetElementToNumericRangeValuepropCount++;
            }

            uIASetElementToNumericRangeValuepropCount++;
            uIASetElementToNumericRangeValue["NewValue"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuenewValue);
            if (uIASetElementToNumericRangeValuenewValueIsPercentage != null)
            {
                if (uIASetElementToNumericRangeValuenewValueIsPercentage != null)
                {
                    uIASetElementToNumericRangeValue["NewValueIsPercentage"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuenewValueIsPercentage);
                    uIASetElementToNumericRangeValuepropCount++;
                }

                uIASetElementToNumericRangeValuepropCount++;
            }
            else
            {
                uIASetElementToNumericRangeValue["NewValueIsPercentage"] = false;
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValuemaxElementsToSearch != null)
            {
                if (uIASetElementToNumericRangeValuemaxElementsToSearch != null)
                {
                    uIASetElementToNumericRangeValue["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuemaxElementsToSearch);
                    uIASetElementToNumericRangeValuepropCount++;
                }

                uIASetElementToNumericRangeValuepropCount++;
            }
            else
            {
                uIASetElementToNumericRangeValue["MaxElementsToSearch"] = 0;
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValuemaxRelativeSearchDepth != null)
            {
                if (uIASetElementToNumericRangeValuemaxRelativeSearchDepth != null)
                {
                    uIASetElementToNumericRangeValue["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuemaxRelativeSearchDepth);
                    uIASetElementToNumericRangeValuepropCount++;
                }

                uIASetElementToNumericRangeValuepropCount++;
            }
            else
            {
                uIASetElementToNumericRangeValue["MaxRelativeSearchDepth"] = 0;
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValuemaxChildElementsToSearchPerNode != null)
            {
                if (uIASetElementToNumericRangeValuemaxChildElementsToSearchPerNode != null)
                {
                    uIASetElementToNumericRangeValue["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuemaxChildElementsToSearchPerNode);
                    uIASetElementToNumericRangeValuepropCount++;
                }

                uIASetElementToNumericRangeValuepropCount++;
            }
            else
            {
                uIASetElementToNumericRangeValue["MaxChildElementsToSearchPerNode"] = 0;
                uIASetElementToNumericRangeValuepropCount++;
            }

            if (uIASetElementToNumericRangeValueelementLocalizedControlTypesNotToTraverse != null)
            {
                uIASetElementToNumericRangeValue["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericRangeValueelementLocalizedControlTypesNotToTraverse);
                uIASetElementToNumericRangeValuepropCount++;
            }

            uIASetElementToNumericRangeValuepropCount++;
            uIASetElementToNumericRangeValue["Workflow"] = CSharpExpressionConverter.ConvertToken(uIASetElementToNumericRangeValueworkflow);
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
            uIAResetAllElementHandles["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAResetAllElementHandlesworkflow);
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
            uIAGlobalPasswordInputIntoElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementparentWindowHandle);
            if (uIAGlobalPasswordInputIntoElementsearchElementName != null)
            {
                uIAGlobalPasswordInputIntoElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementsearchElementName);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementsearchElementClassName != null)
            {
                uIAGlobalPasswordInputIntoElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementsearchElementClassName);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementsearchElementAutomationId != null)
            {
                uIAGlobalPasswordInputIntoElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementsearchElementAutomationId);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementsearchLocalizedControlType != null)
            {
                uIAGlobalPasswordInputIntoElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementsearchLocalizedControlType);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementsearchSubTree != null)
            {
                if (uIAGlobalPasswordInputIntoElementsearchSubTree != null)
                {
                    uIAGlobalPasswordInputIntoElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementsearchSubTree);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                uIAGlobalPasswordInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalPasswordInputIntoElement["SearchSubTree"] = true;
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementmatchIndex != null)
            {
                if (uIAGlobalPasswordInputIntoElementmatchIndex != null)
                {
                    uIAGlobalPasswordInputIntoElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementmatchIndex);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                uIAGlobalPasswordInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalPasswordInputIntoElement["MatchIndex"] = 1;
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementsearchFilter != null)
            {
                uIAGlobalPasswordInputIntoElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementsearchFilter);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementsortByColumn != null)
            {
                uIAGlobalPasswordInputIntoElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementsortByColumn);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementmatchIndexAscending != null)
            {
                if (uIAGlobalPasswordInputIntoElementmatchIndexAscending != null)
                {
                    uIAGlobalPasswordInputIntoElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementmatchIndexAscending);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                uIAGlobalPasswordInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalPasswordInputIntoElement["MatchIndexAscending"] = true;
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementfocusElement != null)
            {
                if (uIAGlobalPasswordInputIntoElementfocusElement != null)
                {
                    uIAGlobalPasswordInputIntoElement["FocusElement"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementfocusElement);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                uIAGlobalPasswordInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalPasswordInputIntoElement["FocusElement"] = true;
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementglobalMouseClickOnElement != null)
            {
                if (uIAGlobalPasswordInputIntoElementglobalMouseClickOnElement != null)
                {
                    uIAGlobalPasswordInputIntoElement["GlobalMouseClickOnElement"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementglobalMouseClickOnElement);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                uIAGlobalPasswordInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalPasswordInputIntoElement["GlobalMouseClickOnElement"] = true;
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingDoubleClickDelete != null)
            {
                if (uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingDoubleClickDelete != null)
                {
                    uIAGlobalPasswordInputIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingDoubleClickDelete);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                uIAGlobalPasswordInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalPasswordInputIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = false;
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingCTRLADelete != null)
            {
                if (uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingCTRLADelete != null)
                {
                    uIAGlobalPasswordInputIntoElement["ReplaceExistingValueUsingCTRLADelete"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingCTRLADelete);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                uIAGlobalPasswordInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalPasswordInputIntoElement["ReplaceExistingValueUsingCTRLADelete"] = false;
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            uIAGlobalPasswordInputIntoElementpropCount++;
            uIAGlobalPasswordInputIntoElement["PasswordToInput"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementpasswordToInput);
            if (uIAGlobalPasswordInputIntoElementsendKeyEvents != null)
            {
                if (uIAGlobalPasswordInputIntoElementsendKeyEvents != null)
                {
                    uIAGlobalPasswordInputIntoElement["SendKeyEvents"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementsendKeyEvents);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                uIAGlobalPasswordInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalPasswordInputIntoElement["SendKeyEvents"] = false;
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementinterval != null)
            {
                if (uIAGlobalPasswordInputIntoElementinterval != null)
                {
                    uIAGlobalPasswordInputIntoElement["Interval"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementinterval);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                uIAGlobalPasswordInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalPasswordInputIntoElement["Interval"] = 10;
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementdontInterpretSymbols != null)
            {
                if (uIAGlobalPasswordInputIntoElementdontInterpretSymbols != null)
                {
                    uIAGlobalPasswordInputIntoElement["DontInterpretSymbols"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementdontInterpretSymbols);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                uIAGlobalPasswordInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalPasswordInputIntoElement["DontInterpretSymbols"] = false;
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementpasswordContainsStoredPassword != null)
            {
                if (uIAGlobalPasswordInputIntoElementpasswordContainsStoredPassword != null)
                {
                    uIAGlobalPasswordInputIntoElement["PasswordContainsStoredPassword"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementpasswordContainsStoredPassword);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                uIAGlobalPasswordInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalPasswordInputIntoElement["PasswordContainsStoredPassword"] = false;
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementmaxElementsToSearch != null)
            {
                if (uIAGlobalPasswordInputIntoElementmaxElementsToSearch != null)
                {
                    uIAGlobalPasswordInputIntoElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementmaxElementsToSearch);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                uIAGlobalPasswordInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalPasswordInputIntoElement["MaxElementsToSearch"] = 0;
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementmaxRelativeSearchDepth != null)
            {
                if (uIAGlobalPasswordInputIntoElementmaxRelativeSearchDepth != null)
                {
                    uIAGlobalPasswordInputIntoElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementmaxRelativeSearchDepth);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                uIAGlobalPasswordInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalPasswordInputIntoElement["MaxRelativeSearchDepth"] = 0;
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIAGlobalPasswordInputIntoElementmaxChildElementsToSearchPerNode != null)
                {
                    uIAGlobalPasswordInputIntoElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementmaxChildElementsToSearchPerNode);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                uIAGlobalPasswordInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalPasswordInputIntoElement["MaxChildElementsToSearchPerNode"] = 0;
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGlobalPasswordInputIntoElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementelementLocalizedControlTypesNotToTraverse);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementvalidateClickablePointWithinElementBoundary != null)
            {
                if (uIAGlobalPasswordInputIntoElementvalidateClickablePointWithinElementBoundary != null)
                {
                    uIAGlobalPasswordInputIntoElement["ValidateClickablePointWithinElementBoundary"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementvalidateClickablePointWithinElementBoundary);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                uIAGlobalPasswordInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalPasswordInputIntoElement["ValidateClickablePointWithinElementBoundary"] = false;
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            uIAGlobalPasswordInputIntoElementpropCount++;
            uIAGlobalPasswordInputIntoElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementworkflow);
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
            uIAGlobalTextInputIntoElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementparentWindowHandle);
            if (uIAGlobalTextInputIntoElementsearchElementName != null)
            {
                uIAGlobalTextInputIntoElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementsearchElementName);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementsearchElementClassName != null)
            {
                uIAGlobalTextInputIntoElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementsearchElementClassName);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementsearchElementAutomationId != null)
            {
                uIAGlobalTextInputIntoElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementsearchElementAutomationId);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementsearchLocalizedControlType != null)
            {
                uIAGlobalTextInputIntoElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementsearchLocalizedControlType);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementsearchSubTree != null)
            {
                if (uIAGlobalTextInputIntoElementsearchSubTree != null)
                {
                    uIAGlobalTextInputIntoElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementsearchSubTree);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                uIAGlobalTextInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalTextInputIntoElement["SearchSubTree"] = true;
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementmatchIndex != null)
            {
                if (uIAGlobalTextInputIntoElementmatchIndex != null)
                {
                    uIAGlobalTextInputIntoElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementmatchIndex);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                uIAGlobalTextInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalTextInputIntoElement["MatchIndex"] = 1;
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementsearchFilter != null)
            {
                uIAGlobalTextInputIntoElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementsearchFilter);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementsortByColumn != null)
            {
                uIAGlobalTextInputIntoElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementsortByColumn);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementmatchIndexAscending != null)
            {
                if (uIAGlobalTextInputIntoElementmatchIndexAscending != null)
                {
                    uIAGlobalTextInputIntoElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementmatchIndexAscending);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                uIAGlobalTextInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalTextInputIntoElement["MatchIndexAscending"] = true;
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementfocusElement != null)
            {
                if (uIAGlobalTextInputIntoElementfocusElement != null)
                {
                    uIAGlobalTextInputIntoElement["FocusElement"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementfocusElement);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                uIAGlobalTextInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalTextInputIntoElement["FocusElement"] = true;
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementglobalMouseClickOnElement != null)
            {
                if (uIAGlobalTextInputIntoElementglobalMouseClickOnElement != null)
                {
                    uIAGlobalTextInputIntoElement["GlobalMouseClickOnElement"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementglobalMouseClickOnElement);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                uIAGlobalTextInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalTextInputIntoElement["GlobalMouseClickOnElement"] = true;
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementreplaceExistingValueUsingDoubleClickDelete != null)
            {
                if (uIAGlobalTextInputIntoElementreplaceExistingValueUsingDoubleClickDelete != null)
                {
                    uIAGlobalTextInputIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementreplaceExistingValueUsingDoubleClickDelete);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                uIAGlobalTextInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalTextInputIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = false;
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementreplaceExistingValueUsingCTRLADelete != null)
            {
                if (uIAGlobalTextInputIntoElementreplaceExistingValueUsingCTRLADelete != null)
                {
                    uIAGlobalTextInputIntoElement["ReplaceExistingValueUsingCTRLADelete"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementreplaceExistingValueUsingCTRLADelete);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                uIAGlobalTextInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalTextInputIntoElement["ReplaceExistingValueUsingCTRLADelete"] = false;
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementtextToInput != null)
            {
                uIAGlobalTextInputIntoElement["TextToInput"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementtextToInput);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementsendKeyEvents != null)
            {
                if (uIAGlobalTextInputIntoElementsendKeyEvents != null)
                {
                    uIAGlobalTextInputIntoElement["SendKeyEvents"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementsendKeyEvents);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                uIAGlobalTextInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalTextInputIntoElement["SendKeyEvents"] = false;
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementinterval != null)
            {
                if (uIAGlobalTextInputIntoElementinterval != null)
                {
                    uIAGlobalTextInputIntoElement["Interval"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementinterval);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                uIAGlobalTextInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalTextInputIntoElement["Interval"] = 10;
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementdontInterpretSymbols != null)
            {
                if (uIAGlobalTextInputIntoElementdontInterpretSymbols != null)
                {
                    uIAGlobalTextInputIntoElement["DontInterpretSymbols"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementdontInterpretSymbols);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                uIAGlobalTextInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalTextInputIntoElement["DontInterpretSymbols"] = false;
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementmaxElementsToSearch != null)
            {
                if (uIAGlobalTextInputIntoElementmaxElementsToSearch != null)
                {
                    uIAGlobalTextInputIntoElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementmaxElementsToSearch);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                uIAGlobalTextInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalTextInputIntoElement["MaxElementsToSearch"] = 0;
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementmaxRelativeSearchDepth != null)
            {
                if (uIAGlobalTextInputIntoElementmaxRelativeSearchDepth != null)
                {
                    uIAGlobalTextInputIntoElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementmaxRelativeSearchDepth);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                uIAGlobalTextInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalTextInputIntoElement["MaxRelativeSearchDepth"] = 0;
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIAGlobalTextInputIntoElementmaxChildElementsToSearchPerNode != null)
                {
                    uIAGlobalTextInputIntoElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementmaxChildElementsToSearchPerNode);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                uIAGlobalTextInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalTextInputIntoElement["MaxChildElementsToSearchPerNode"] = 0;
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGlobalTextInputIntoElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementelementLocalizedControlTypesNotToTraverse);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementvalidateClickablePointWithinElementBoundary != null)
            {
                if (uIAGlobalTextInputIntoElementvalidateClickablePointWithinElementBoundary != null)
                {
                    uIAGlobalTextInputIntoElement["ValidateClickablePointWithinElementBoundary"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementvalidateClickablePointWithinElementBoundary);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                uIAGlobalTextInputIntoElementpropCount++;
            }
            else
            {
                uIAGlobalTextInputIntoElement["ValidateClickablePointWithinElementBoundary"] = false;
                uIAGlobalTextInputIntoElementpropCount++;
            }

            uIAGlobalTextInputIntoElementpropCount++;
            uIAGlobalTextInputIntoElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementworkflow);
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
            uIAGetElementPropertiesAsList["ElementHandle"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPropertiesAsListelementHandle);
            uIAGetElementPropertiesAsListpropCount++;
            uIAGetElementPropertiesAsList["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPropertiesAsListworkflow);
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
            uIASetTransactionTimeout["TimeoutInSeconds"] = CSharpExpressionConverter.ConvertToken(uIASetTransactionTimeouttimeoutInSeconds);
            uIASetTransactionTimeoutpropCount++;
            uIASetTransactionTimeout["Workflow"] = CSharpExpressionConverter.ConvertToken(uIASetTransactionTimeoutworkflow);
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
                if (uIAGetElementAtCoordinatesxCoord != null)
                {
                    uIAGetElementAtCoordinates["XCoord"] = CSharpExpressionConverter.ConvertToken(uIAGetElementAtCoordinatesxCoord);
                    uIAGetElementAtCoordinatespropCount++;
                }

                uIAGetElementAtCoordinatespropCount++;
            }
            else
            {
                uIAGetElementAtCoordinates["XCoord"] = 0;
                uIAGetElementAtCoordinatespropCount++;
            }

            if (uIAGetElementAtCoordinatesyCoord != null)
            {
                if (uIAGetElementAtCoordinatesyCoord != null)
                {
                    uIAGetElementAtCoordinates["YCoord"] = CSharpExpressionConverter.ConvertToken(uIAGetElementAtCoordinatesyCoord);
                    uIAGetElementAtCoordinatespropCount++;
                }

                uIAGetElementAtCoordinatespropCount++;
            }
            else
            {
                uIAGetElementAtCoordinates["YCoord"] = 0;
                uIAGetElementAtCoordinatespropCount++;
            }

            if (uIAGetElementAtCoordinatesraiseExceptionIfElementNotFound != null)
            {
                if (uIAGetElementAtCoordinatesraiseExceptionIfElementNotFound != null)
                {
                    uIAGetElementAtCoordinates["RaiseExceptionIfElementNotFound"] = CSharpExpressionConverter.ConvertToken(uIAGetElementAtCoordinatesraiseExceptionIfElementNotFound);
                    uIAGetElementAtCoordinatespropCount++;
                }

                uIAGetElementAtCoordinatespropCount++;
            }
            else
            {
                uIAGetElementAtCoordinates["RaiseExceptionIfElementNotFound"] = false;
                uIAGetElementAtCoordinatespropCount++;
            }

            uIAGetElementAtCoordinatespropCount++;
            uIAGetElementAtCoordinates["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetElementAtCoordinatesworkflow);
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
            uIAGetMultipleParentElementProperties["ElementHandle"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleParentElementPropertieselementHandle);
            if (uIAGetMultipleParentElementPropertiesmaxParentsToProcess != null)
            {
                if (uIAGetMultipleParentElementPropertiesmaxParentsToProcess != null)
                {
                    uIAGetMultipleParentElementProperties["MaxParentsToProcess"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleParentElementPropertiesmaxParentsToProcess);
                    uIAGetMultipleParentElementPropertiespropCount++;
                }

                uIAGetMultipleParentElementPropertiespropCount++;
            }
            else
            {
                uIAGetMultipleParentElementProperties["MaxParentsToProcess"] = 50;
                uIAGetMultipleParentElementPropertiespropCount++;
            }

            uIAGetMultipleParentElementPropertiespropCount++;
            uIAGetMultipleParentElementProperties["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleParentElementPropertiesworkflow);
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
            uIASearchForFirstParentElement["ElementHandle"] = CSharpExpressionConverter.ConvertToken(uIASearchForFirstParentElementelementHandle);
            if (uIASearchForFirstParentElementsearchParentLocalizedControlType != null)
            {
                uIASearchForFirstParentElement["SearchParentLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIASearchForFirstParentElementsearchParentLocalizedControlType);
                uIASearchForFirstParentElementpropCount++;
            }

            if (uIASearchForFirstParentElementsearchParentControlType != null)
            {
                uIASearchForFirstParentElement["SearchParentControlType"] = CSharpExpressionConverter.ConvertToken(uIASearchForFirstParentElementsearchParentControlType);
                uIASearchForFirstParentElementpropCount++;
            }

            if (uIASearchForFirstParentElementmaxParentsToProcess != null)
            {
                if (uIASearchForFirstParentElementmaxParentsToProcess != null)
                {
                    uIASearchForFirstParentElement["MaxParentsToProcess"] = CSharpExpressionConverter.ConvertToken(uIASearchForFirstParentElementmaxParentsToProcess);
                    uIASearchForFirstParentElementpropCount++;
                }

                uIASearchForFirstParentElementpropCount++;
            }
            else
            {
                uIASearchForFirstParentElement["MaxParentsToProcess"] = 50;
                uIASearchForFirstParentElementpropCount++;
            }

            if (uIASearchForFirstParentElementraiseExceptionIfParentElementNotFound != null)
            {
                if (uIASearchForFirstParentElementraiseExceptionIfParentElementNotFound != null)
                {
                    uIASearchForFirstParentElement["RaiseExceptionIfParentElementNotFound"] = CSharpExpressionConverter.ConvertToken(uIASearchForFirstParentElementraiseExceptionIfParentElementNotFound);
                    uIASearchForFirstParentElementpropCount++;
                }

                uIASearchForFirstParentElementpropCount++;
            }
            else
            {
                uIASearchForFirstParentElement["RaiseExceptionIfParentElementNotFound"] = false;
                uIASearchForFirstParentElementpropCount++;
            }

            uIASearchForFirstParentElementpropCount++;
            uIASearchForFirstParentElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIASearchForFirstParentElementworkflow);
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
                uIAGetMultipleElementsAsTable["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTableparentWindowHandle);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchElementName != null)
            {
                uIAGetMultipleElementsAsTable["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchElementName);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchElementClassName != null)
            {
                uIAGetMultipleElementsAsTable["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchElementClassName);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchElementAutomationId != null)
            {
                uIAGetMultipleElementsAsTable["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchElementAutomationId);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchLocalizedControlType != null)
            {
                uIAGetMultipleElementsAsTable["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchLocalizedControlType);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchSubTree != null)
            {
                if (uIAGetMultipleElementsAsTablesearchSubTree != null)
                {
                    uIAGetMultipleElementsAsTable["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchSubTree);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["SearchSubTree"] = true;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablematchIndex != null)
            {
                if (uIAGetMultipleElementsAsTablematchIndex != null)
                {
                    uIAGetMultipleElementsAsTable["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablematchIndex);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["MatchIndex"] = 1;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchFilter != null)
            {
                uIAGetMultipleElementsAsTable["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchFilter);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesortByColumn != null)
            {
                uIAGetMultipleElementsAsTable["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesortByColumn);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablematchIndexAscending != null)
            {
                if (uIAGetMultipleElementsAsTablematchIndexAscending != null)
                {
                    uIAGetMultipleElementsAsTable["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablematchIndexAscending);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["MatchIndexAscending"] = true;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchCellHeaderSubElementLocalizedControlType != null)
            {
                uIAGetMultipleElementsAsTable["SearchCellHeaderSubElementLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchCellHeaderSubElementLocalizedControlType);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchCellHeaderSubElementControlType != null)
            {
                uIAGetMultipleElementsAsTable["SearchCellHeaderSubElementControlType"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchCellHeaderSubElementControlType);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchCellSubElementLocalizedControlType != null)
            {
                uIAGetMultipleElementsAsTable["SearchCellSubElementLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchCellSubElementLocalizedControlType);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchCellSubElementControlType != null)
            {
                uIAGetMultipleElementsAsTable["SearchCellSubElementControlType"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchCellSubElementControlType);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchDescendantsForCellSubElements != null)
            {
                if (uIAGetMultipleElementsAsTablesearchDescendantsForCellSubElements != null)
                {
                    uIAGetMultipleElementsAsTable["SearchDescendantsForCellSubElements"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchDescendantsForCellSubElements);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["SearchDescendantsForCellSubElements"] = true;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablefirstCellHeaderSubElementToReturn != null)
            {
                if (uIAGetMultipleElementsAsTablefirstCellHeaderSubElementToReturn != null)
                {
                    uIAGetMultipleElementsAsTable["FirstCellHeaderSubElementToReturn"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablefirstCellHeaderSubElementToReturn);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["FirstCellHeaderSubElementToReturn"] = 1;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablemaxCellHeaderSubElementsToReturn != null)
            {
                if (uIAGetMultipleElementsAsTablemaxCellHeaderSubElementsToReturn != null)
                {
                    uIAGetMultipleElementsAsTable["MaxCellHeaderSubElementsToReturn"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablemaxCellHeaderSubElementsToReturn);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["MaxCellHeaderSubElementsToReturn"] = 0;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablefirstCellSubElementToReturn != null)
            {
                if (uIAGetMultipleElementsAsTablefirstCellSubElementToReturn != null)
                {
                    uIAGetMultipleElementsAsTable["FirstCellSubElementToReturn"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablefirstCellSubElementToReturn);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["FirstCellSubElementToReturn"] = 1;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablemaxCellSubElementsToReturn != null)
            {
                if (uIAGetMultipleElementsAsTablemaxCellSubElementsToReturn != null)
                {
                    uIAGetMultipleElementsAsTable["MaxCellSubElementsToReturn"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablemaxCellSubElementsToReturn);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["MaxCellSubElementsToReturn"] = 0;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablerequestedNumberOfColumns != null)
            {
                if (uIAGetMultipleElementsAsTablerequestedNumberOfColumns != null)
                {
                    uIAGetMultipleElementsAsTable["RequestedNumberOfColumns"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablerequestedNumberOfColumns);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["RequestedNumberOfColumns"] = 1;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablecellSubElementValuePriority != null)
            {
                if (uIAGetMultipleElementsAsTablecellSubElementValuePriority != null)
                {
                    uIAGetMultipleElementsAsTable["CellSubElementValuePriority"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablecellSubElementValuePriority);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["CellSubElementValuePriority"] = 1;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablecellSubElementTextValuePriority != null)
            {
                if (uIAGetMultipleElementsAsTablecellSubElementTextValuePriority != null)
                {
                    uIAGetMultipleElementsAsTable["CellSubElementTextValuePriority"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablecellSubElementTextValuePriority);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["CellSubElementTextValuePriority"] = 2;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablecellSubElementNameValuePriority != null)
            {
                if (uIAGetMultipleElementsAsTablecellSubElementNameValuePriority != null)
                {
                    uIAGetMultipleElementsAsTable["CellSubElementNameValuePriority"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablecellSubElementNameValuePriority);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["CellSubElementNameValuePriority"] = 3;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableminimumCellSubElementWidth != null)
            {
                if (uIAGetMultipleElementsAsTableminimumCellSubElementWidth != null)
                {
                    uIAGetMultipleElementsAsTable["MinimumCellSubElementWidth"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTableminimumCellSubElementWidth);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["MinimumCellSubElementWidth"] = 1;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableminimumCellSubElementHeight != null)
            {
                if (uIAGetMultipleElementsAsTableminimumCellSubElementHeight != null)
                {
                    uIAGetMultipleElementsAsTable["MinimumCellSubElementHeight"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTableminimumCellSubElementHeight);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["MinimumCellSubElementHeight"] = 1;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxLeft != null)
            {
                if (uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxLeft != null)
                {
                    uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxLeft"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxLeft);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxLeft"] = -99999;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxRight != null)
            {
                if (uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxRight != null)
                {
                    uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxRight"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxRight);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxRight"] = 99999;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxTop != null)
            {
                if (uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxTop != null)
                {
                    uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxTop"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxTop);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxTop"] = -99999;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxBottom != null)
            {
                if (uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxBottom != null)
                {
                    uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxBottom"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxBottom);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxBottom"] = 99999;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablereadTableAsThread != null)
            {
                if (uIAGetMultipleElementsAsTablereadTableAsThread != null)
                {
                    uIAGetMultipleElementsAsTable["ReadTableAsThread"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablereadTableAsThread);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["ReadTableAsThread"] = false;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableretrieveOutputDataFromThreadId != null)
            {
                uIAGetMultipleElementsAsTable["RetrieveOutputDataFromThreadId"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTableretrieveOutputDataFromThreadId);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesecondsToWaitForThread != null)
            {
                if (uIAGetMultipleElementsAsTablesecondsToWaitForThread != null)
                {
                    uIAGetMultipleElementsAsTable["SecondsToWaitForThread"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesecondsToWaitForThread);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["SecondsToWaitForThread"] = 90;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablemaxElementsToSearch != null)
            {
                if (uIAGetMultipleElementsAsTablemaxElementsToSearch != null)
                {
                    uIAGetMultipleElementsAsTable["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablemaxElementsToSearch);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["MaxElementsToSearch"] = 0;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablemaxRelativeSearchDepth != null)
            {
                if (uIAGetMultipleElementsAsTablemaxRelativeSearchDepth != null)
                {
                    uIAGetMultipleElementsAsTable["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablemaxRelativeSearchDepth);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["MaxRelativeSearchDepth"] = 0;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablemaxChildElementsToSearchPerNode != null)
            {
                if (uIAGetMultipleElementsAsTablemaxChildElementsToSearchPerNode != null)
                {
                    uIAGetMultipleElementsAsTable["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablemaxChildElementsToSearchPerNode);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
            }
            else
            {
                uIAGetMultipleElementsAsTable["MaxChildElementsToSearchPerNode"] = 0;
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTableelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetMultipleElementsAsTable["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTableelementLocalizedControlTypesNotToTraverse);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            uIAGetMultipleElementsAsTablepropCount++;
            uIAGetMultipleElementsAsTable["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTableworkflow);
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
            uIASetElementScrollPercentage["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIASetElementScrollPercentageparentWindowHandle);
            if (uIASetElementScrollPercentagesearchElementName != null)
            {
                uIASetElementScrollPercentage["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIASetElementScrollPercentagesearchElementName);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagesearchElementClassName != null)
            {
                uIASetElementScrollPercentage["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIASetElementScrollPercentagesearchElementClassName);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagesearchElementAutomationId != null)
            {
                uIASetElementScrollPercentage["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIASetElementScrollPercentagesearchElementAutomationId);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagesearchLocalizedControlType != null)
            {
                uIASetElementScrollPercentage["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIASetElementScrollPercentagesearchLocalizedControlType);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagesearchSubTree != null)
            {
                if (uIASetElementScrollPercentagesearchSubTree != null)
                {
                    uIASetElementScrollPercentage["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIASetElementScrollPercentagesearchSubTree);
                    uIASetElementScrollPercentagepropCount++;
                }

                uIASetElementScrollPercentagepropCount++;
            }
            else
            {
                uIASetElementScrollPercentage["SearchSubTree"] = true;
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagematchIndex != null)
            {
                if (uIASetElementScrollPercentagematchIndex != null)
                {
                    uIASetElementScrollPercentage["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIASetElementScrollPercentagematchIndex);
                    uIASetElementScrollPercentagepropCount++;
                }

                uIASetElementScrollPercentagepropCount++;
            }
            else
            {
                uIASetElementScrollPercentage["MatchIndex"] = 1;
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagesearchFilter != null)
            {
                uIASetElementScrollPercentage["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIASetElementScrollPercentagesearchFilter);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagesortByColumn != null)
            {
                uIASetElementScrollPercentage["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIASetElementScrollPercentagesortByColumn);
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagematchIndexAscending != null)
            {
                if (uIASetElementScrollPercentagematchIndexAscending != null)
                {
                    uIASetElementScrollPercentage["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIASetElementScrollPercentagematchIndexAscending);
                    uIASetElementScrollPercentagepropCount++;
                }

                uIASetElementScrollPercentagepropCount++;
            }
            else
            {
                uIASetElementScrollPercentage["MatchIndexAscending"] = true;
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagehorizontalScrollPercentage != null)
            {
                if (uIASetElementScrollPercentagehorizontalScrollPercentage != null)
                {
                    uIASetElementScrollPercentage["HorizontalScrollPercentage"] = CSharpExpressionConverter.ConvertToken(uIASetElementScrollPercentagehorizontalScrollPercentage);
                    uIASetElementScrollPercentagepropCount++;
                }

                uIASetElementScrollPercentagepropCount++;
            }
            else
            {
                uIASetElementScrollPercentage["HorizontalScrollPercentage"] = -1;
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentageverticalScrollPercentage != null)
            {
                if (uIASetElementScrollPercentageverticalScrollPercentage != null)
                {
                    uIASetElementScrollPercentage["VerticalScrollPercentage"] = CSharpExpressionConverter.ConvertToken(uIASetElementScrollPercentageverticalScrollPercentage);
                    uIASetElementScrollPercentagepropCount++;
                }

                uIASetElementScrollPercentagepropCount++;
            }
            else
            {
                uIASetElementScrollPercentage["VerticalScrollPercentage"] = -1;
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagetryScrollPattern != null)
            {
                if (uIASetElementScrollPercentagetryScrollPattern != null)
                {
                    uIASetElementScrollPercentage["TryScrollPattern"] = CSharpExpressionConverter.ConvertToken(uIASetElementScrollPercentagetryScrollPattern);
                    uIASetElementScrollPercentagepropCount++;
                }

                uIASetElementScrollPercentagepropCount++;
            }
            else
            {
                uIASetElementScrollPercentage["TryScrollPattern"] = true;
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagetryRangeValuePattern != null)
            {
                if (uIASetElementScrollPercentagetryRangeValuePattern != null)
                {
                    uIASetElementScrollPercentage["TryRangeValuePattern"] = CSharpExpressionConverter.ConvertToken(uIASetElementScrollPercentagetryRangeValuePattern);
                    uIASetElementScrollPercentagepropCount++;
                }

                uIASetElementScrollPercentagepropCount++;
            }
            else
            {
                uIASetElementScrollPercentage["TryRangeValuePattern"] = true;
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagetryValuePattern != null)
            {
                if (uIASetElementScrollPercentagetryValuePattern != null)
                {
                    uIASetElementScrollPercentage["TryValuePattern"] = CSharpExpressionConverter.ConvertToken(uIASetElementScrollPercentagetryValuePattern);
                    uIASetElementScrollPercentagepropCount++;
                }

                uIASetElementScrollPercentagepropCount++;
            }
            else
            {
                uIASetElementScrollPercentage["TryValuePattern"] = true;
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagemaxElementsToSearch != null)
            {
                if (uIASetElementScrollPercentagemaxElementsToSearch != null)
                {
                    uIASetElementScrollPercentage["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIASetElementScrollPercentagemaxElementsToSearch);
                    uIASetElementScrollPercentagepropCount++;
                }

                uIASetElementScrollPercentagepropCount++;
            }
            else
            {
                uIASetElementScrollPercentage["MaxElementsToSearch"] = 0;
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagemaxRelativeSearchDepth != null)
            {
                if (uIASetElementScrollPercentagemaxRelativeSearchDepth != null)
                {
                    uIASetElementScrollPercentage["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIASetElementScrollPercentagemaxRelativeSearchDepth);
                    uIASetElementScrollPercentagepropCount++;
                }

                uIASetElementScrollPercentagepropCount++;
            }
            else
            {
                uIASetElementScrollPercentage["MaxRelativeSearchDepth"] = 0;
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentagemaxChildElementsToSearchPerNode != null)
            {
                if (uIASetElementScrollPercentagemaxChildElementsToSearchPerNode != null)
                {
                    uIASetElementScrollPercentage["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIASetElementScrollPercentagemaxChildElementsToSearchPerNode);
                    uIASetElementScrollPercentagepropCount++;
                }

                uIASetElementScrollPercentagepropCount++;
            }
            else
            {
                uIASetElementScrollPercentage["MaxChildElementsToSearchPerNode"] = 0;
                uIASetElementScrollPercentagepropCount++;
            }

            if (uIASetElementScrollPercentageelementLocalizedControlTypesNotToTraverse != null)
            {
                uIASetElementScrollPercentage["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIASetElementScrollPercentageelementLocalizedControlTypesNotToTraverse);
                uIASetElementScrollPercentagepropCount++;
            }

            uIASetElementScrollPercentagepropCount++;
            uIASetElementScrollPercentage["Workflow"] = CSharpExpressionConverter.ConvertToken(uIASetElementScrollPercentageworkflow);
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
            uIAGetElementSearchColourRegion["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionparentWindowHandle);
            if (uIAGetElementSearchColourRegionsearchElementName != null)
            {
                uIAGetElementSearchColourRegion["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionsearchElementName);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionsearchElementClassName != null)
            {
                uIAGetElementSearchColourRegion["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionsearchElementClassName);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionsearchElementAutomationId != null)
            {
                uIAGetElementSearchColourRegion["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionsearchElementAutomationId);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionsearchLocalizedControlType != null)
            {
                uIAGetElementSearchColourRegion["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionsearchLocalizedControlType);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionsearchSubTree != null)
            {
                if (uIAGetElementSearchColourRegionsearchSubTree != null)
                {
                    uIAGetElementSearchColourRegion["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionsearchSubTree);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                uIAGetElementSearchColourRegionpropCount++;
            }
            else
            {
                uIAGetElementSearchColourRegion["SearchSubTree"] = true;
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionmatchIndex != null)
            {
                if (uIAGetElementSearchColourRegionmatchIndex != null)
                {
                    uIAGetElementSearchColourRegion["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionmatchIndex);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                uIAGetElementSearchColourRegionpropCount++;
            }
            else
            {
                uIAGetElementSearchColourRegion["MatchIndex"] = 1;
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionsearchFilter != null)
            {
                uIAGetElementSearchColourRegion["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionsearchFilter);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionsortByColumn != null)
            {
                uIAGetElementSearchColourRegion["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionsortByColumn);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionmatchIndexAscending != null)
            {
                if (uIAGetElementSearchColourRegionmatchIndexAscending != null)
                {
                    uIAGetElementSearchColourRegion["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionmatchIndexAscending);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                uIAGetElementSearchColourRegionpropCount++;
            }
            else
            {
                uIAGetElementSearchColourRegion["MatchIndexAscending"] = true;
                uIAGetElementSearchColourRegionpropCount++;
            }

            uIAGetElementSearchColourRegionpropCount++;
            uIAGetElementSearchColourRegion["SearchColour"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionsearchColour);
            uIAGetElementSearchColourRegionpropCount++;
            uIAGetElementSearchColourRegion["MaxColourDeviation"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionmaxColourDeviation);
            if (uIAGetElementSearchColourRegionleftPixelXOffset != null)
            {
                uIAGetElementSearchColourRegion["LeftPixelXOffset"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionleftPixelXOffset);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionrightPixelXOffset != null)
            {
                uIAGetElementSearchColourRegion["RightPixelXOffset"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionrightPixelXOffset);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegiontopPixelYOffset != null)
            {
                uIAGetElementSearchColourRegion["TopPixelYOffset"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegiontopPixelYOffset);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionbottomPixelYOffset != null)
            {
                uIAGetElementSearchColourRegion["BottomPixelYOffset"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionbottomPixelYOffset);
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionhideAgent != null)
            {
                if (uIAGetElementSearchColourRegionhideAgent != null)
                {
                    uIAGetElementSearchColourRegion["HideAgent"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionhideAgent);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                uIAGetElementSearchColourRegionpropCount++;
            }
            else
            {
                uIAGetElementSearchColourRegion["HideAgent"] = true;
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionreturnPhysicalCoordinates != null)
            {
                if (uIAGetElementSearchColourRegionreturnPhysicalCoordinates != null)
                {
                    uIAGetElementSearchColourRegion["ReturnPhysicalCoordinates"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionreturnPhysicalCoordinates);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                uIAGetElementSearchColourRegionpropCount++;
            }
            else
            {
                uIAGetElementSearchColourRegion["ReturnPhysicalCoordinates"] = false;
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionmaxElementsToSearch != null)
            {
                if (uIAGetElementSearchColourRegionmaxElementsToSearch != null)
                {
                    uIAGetElementSearchColourRegion["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionmaxElementsToSearch);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                uIAGetElementSearchColourRegionpropCount++;
            }
            else
            {
                uIAGetElementSearchColourRegion["MaxElementsToSearch"] = 0;
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionmaxRelativeSearchDepth != null)
            {
                if (uIAGetElementSearchColourRegionmaxRelativeSearchDepth != null)
                {
                    uIAGetElementSearchColourRegion["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionmaxRelativeSearchDepth);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                uIAGetElementSearchColourRegionpropCount++;
            }
            else
            {
                uIAGetElementSearchColourRegion["MaxRelativeSearchDepth"] = 0;
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionmaxChildElementsToSearchPerNode != null)
            {
                if (uIAGetElementSearchColourRegionmaxChildElementsToSearchPerNode != null)
                {
                    uIAGetElementSearchColourRegion["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionmaxChildElementsToSearchPerNode);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                uIAGetElementSearchColourRegionpropCount++;
            }
            else
            {
                uIAGetElementSearchColourRegion["MaxChildElementsToSearchPerNode"] = 0;
                uIAGetElementSearchColourRegionpropCount++;
            }

            if (uIAGetElementSearchColourRegionelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetElementSearchColourRegion["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionelementLocalizedControlTypesNotToTraverse);
                uIAGetElementSearchColourRegionpropCount++;
            }

            uIAGetElementSearchColourRegionpropCount++;
            uIAGetElementSearchColourRegion["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionworkflow);
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
            uIAGlobalMouseClickElementSearchColourRegion["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionparentWindowHandle);
            if (uIAGlobalMouseClickElementSearchColourRegionsearchElementName != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionsearchElementName);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionsearchElementClassName != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionsearchElementClassName);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionsearchElementAutomationId != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionsearchElementAutomationId);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionsearchLocalizedControlType != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionsearchLocalizedControlType);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionsearchSubTree != null)
            {
                if (uIAGlobalMouseClickElementSearchColourRegionsearchSubTree != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionsearchSubTree);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }
            else
            {
                uIAGlobalMouseClickElementSearchColourRegion["SearchSubTree"] = true;
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionmatchIndex != null)
            {
                if (uIAGlobalMouseClickElementSearchColourRegionmatchIndex != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionmatchIndex);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }
            else
            {
                uIAGlobalMouseClickElementSearchColourRegion["MatchIndex"] = 1;
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionsearchFilter != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionsearchFilter);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionsortByColumn != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionsortByColumn);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionmatchIndexAscending != null)
            {
                if (uIAGlobalMouseClickElementSearchColourRegionmatchIndexAscending != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionmatchIndexAscending);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }
            else
            {
                uIAGlobalMouseClickElementSearchColourRegion["MatchIndexAscending"] = true;
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            uIAGlobalMouseClickElementSearchColourRegion["SearchColour"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionsearchColour);
            uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            uIAGlobalMouseClickElementSearchColourRegion["MaxColourDeviation"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionmaxColourDeviation);
            if (uIAGlobalMouseClickElementSearchColourRegionleftPixelXOffset != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["LeftPixelXOffset"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionleftPixelXOffset);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionrightPixelXOffset != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["RightPixelXOffset"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionrightPixelXOffset);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegiontopPixelYOffset != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["TopPixelYOffset"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegiontopPixelYOffset);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionbottomPixelYOffset != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["BottomPixelYOffset"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionbottomPixelYOffset);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionmouseButton != null)
            {
                if (uIAGlobalMouseClickElementSearchColourRegionmouseButton != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["MouseButton"] = CSharpExpressionConverter.Convert(uIAGlobalMouseClickElementSearchColourRegionmouseButton);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }
            else
            {
                uIAGlobalMouseClickElementSearchColourRegion["MouseButton"] = "Left";
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionclickOffsetX != null)
            {
                if (uIAGlobalMouseClickElementSearchColourRegionclickOffsetX != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["ClickOffsetX"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionclickOffsetX);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }
            else
            {
                uIAGlobalMouseClickElementSearchColourRegion["ClickOffsetX"] = 0;
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionclickOffsetY != null)
            {
                if (uIAGlobalMouseClickElementSearchColourRegionclickOffsetY != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["ClickOffsetY"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionclickOffsetY);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }
            else
            {
                uIAGlobalMouseClickElementSearchColourRegion["ClickOffsetY"] = 0;
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeTo != null)
            {
                if (uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeTo != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["OffsetRelativeTo"] = CSharpExpressionConverter.Convert(uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeTo);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }
            else
            {
                uIAGlobalMouseClickElementSearchColourRegion["OffsetRelativeTo"] = "Center";
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegiondelayInMilliseconds != null)
            {
                if (uIAGlobalMouseClickElementSearchColourRegiondelayInMilliseconds != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["DelayInMilliseconds"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegiondelayInMilliseconds);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }
            else
            {
                uIAGlobalMouseClickElementSearchColourRegion["DelayInMilliseconds"] = 10;
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionhideAgent != null)
            {
                if (uIAGlobalMouseClickElementSearchColourRegionhideAgent != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["HideAgent"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionhideAgent);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }
            else
            {
                uIAGlobalMouseClickElementSearchColourRegion["HideAgent"] = true;
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionmaxElementsToSearch != null)
            {
                if (uIAGlobalMouseClickElementSearchColourRegionmaxElementsToSearch != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionmaxElementsToSearch);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }
            else
            {
                uIAGlobalMouseClickElementSearchColourRegion["MaxElementsToSearch"] = 0;
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionmaxRelativeSearchDepth != null)
            {
                if (uIAGlobalMouseClickElementSearchColourRegionmaxRelativeSearchDepth != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionmaxRelativeSearchDepth);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }
            else
            {
                uIAGlobalMouseClickElementSearchColourRegion["MaxRelativeSearchDepth"] = 0;
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionmaxChildElementsToSearchPerNode != null)
            {
                if (uIAGlobalMouseClickElementSearchColourRegionmaxChildElementsToSearchPerNode != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionmaxChildElementsToSearchPerNode);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }
            else
            {
                uIAGlobalMouseClickElementSearchColourRegion["MaxChildElementsToSearchPerNode"] = 0;
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            if (uIAGlobalMouseClickElementSearchColourRegionelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGlobalMouseClickElementSearchColourRegion["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionelementLocalizedControlTypesNotToTraverse);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            }

            uIAGlobalMouseClickElementSearchColourRegionpropCount++;
            uIAGlobalMouseClickElementSearchColourRegion["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionworkflow);
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
                uIAGetWin32Windows["SearchClassName"] = CSharpExpressionConverter.ConvertToken(uIAGetWin32WindowssearchClassName);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowssearchWindowTitle != null)
            {
                uIAGetWin32Windows["SearchWindowTitle"] = CSharpExpressionConverter.ConvertToken(uIAGetWin32WindowssearchWindowTitle);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowstopLevelWindowsOnly != null)
            {
                if (uIAGetWin32WindowstopLevelWindowsOnly != null)
                {
                    uIAGetWin32Windows["TopLevelWindowsOnly"] = CSharpExpressionConverter.ConvertToken(uIAGetWin32WindowstopLevelWindowsOnly);
                    uIAGetWin32WindowspropCount++;
                }

                uIAGetWin32WindowspropCount++;
            }
            else
            {
                uIAGetWin32Windows["TopLevelWindowsOnly"] = false;
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsvisibleWindowsOnly != null)
            {
                if (uIAGetWin32WindowsvisibleWindowsOnly != null)
                {
                    uIAGetWin32Windows["VisibleWindowsOnly"] = CSharpExpressionConverter.ConvertToken(uIAGetWin32WindowsvisibleWindowsOnly);
                    uIAGetWin32WindowspropCount++;
                }

                uIAGetWin32WindowspropCount++;
            }
            else
            {
                uIAGetWin32Windows["VisibleWindowsOnly"] = true;
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowswindowsWithTitlebarOnly != null)
            {
                if (uIAGetWin32WindowswindowsWithTitlebarOnly != null)
                {
                    uIAGetWin32Windows["WindowsWithTitlebarOnly"] = CSharpExpressionConverter.ConvertToken(uIAGetWin32WindowswindowsWithTitlebarOnly);
                    uIAGetWin32WindowspropCount++;
                }

                uIAGetWin32WindowspropCount++;
            }
            else
            {
                uIAGetWin32Windows["WindowsWithTitlebarOnly"] = true;
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowswindowsWithTitleOnly != null)
            {
                if (uIAGetWin32WindowswindowsWithTitleOnly != null)
                {
                    uIAGetWin32Windows["WindowsWithTitleOnly"] = CSharpExpressionConverter.ConvertToken(uIAGetWin32WindowswindowsWithTitleOnly);
                    uIAGetWin32WindowspropCount++;
                }

                uIAGetWin32WindowspropCount++;
            }
            else
            {
                uIAGetWin32Windows["WindowsWithTitleOnly"] = true;
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsignoreTransparentWindows != null)
            {
                if (uIAGetWin32WindowsignoreTransparentWindows != null)
                {
                    uIAGetWin32Windows["IgnoreTransparentWindows"] = CSharpExpressionConverter.ConvertToken(uIAGetWin32WindowsignoreTransparentWindows);
                    uIAGetWin32WindowspropCount++;
                }

                uIAGetWin32WindowspropCount++;
            }
            else
            {
                uIAGetWin32Windows["IgnoreTransparentWindows"] = true;
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowssearchProcessId != null)
            {
                uIAGetWin32Windows["SearchProcessId"] = CSharpExpressionConverter.ConvertToken(uIAGetWin32WindowssearchProcessId);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowssearchFilter != null)
            {
                uIAGetWin32Windows["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAGetWin32WindowssearchFilter);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowssortByColumn != null)
            {
                uIAGetWin32Windows["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAGetWin32WindowssortByColumn);
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsmatchIndexAscending != null)
            {
                if (uIAGetWin32WindowsmatchIndexAscending != null)
                {
                    uIAGetWin32Windows["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAGetWin32WindowsmatchIndexAscending);
                    uIAGetWin32WindowspropCount++;
                }

                uIAGetWin32WindowspropCount++;
            }
            else
            {
                uIAGetWin32Windows["MatchIndexAscending"] = true;
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsreturnElementHandle != null)
            {
                if (uIAGetWin32WindowsreturnElementHandle != null)
                {
                    uIAGetWin32Windows["ReturnElementHandle"] = CSharpExpressionConverter.ConvertToken(uIAGetWin32WindowsreturnElementHandle);
                    uIAGetWin32WindowspropCount++;
                }

                uIAGetWin32WindowspropCount++;
            }
            else
            {
                uIAGetWin32Windows["ReturnElementHandle"] = true;
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsfirstItemToReturn != null)
            {
                if (uIAGetWin32WindowsfirstItemToReturn != null)
                {
                    uIAGetWin32Windows["FirstItemToReturn"] = CSharpExpressionConverter.ConvertToken(uIAGetWin32WindowsfirstItemToReturn);
                    uIAGetWin32WindowspropCount++;
                }

                uIAGetWin32WindowspropCount++;
            }
            else
            {
                uIAGetWin32Windows["FirstItemToReturn"] = 1;
                uIAGetWin32WindowspropCount++;
            }

            if (uIAGetWin32WindowsmaxItemsToReturn != null)
            {
                if (uIAGetWin32WindowsmaxItemsToReturn != null)
                {
                    uIAGetWin32Windows["MaxItemsToReturn"] = CSharpExpressionConverter.ConvertToken(uIAGetWin32WindowsmaxItemsToReturn);
                    uIAGetWin32WindowspropCount++;
                }

                uIAGetWin32WindowspropCount++;
            }
            else
            {
                uIAGetWin32Windows["MaxItemsToReturn"] = 0;
                uIAGetWin32WindowspropCount++;
            }

            uIAGetWin32WindowspropCount++;
            uIAGetWin32Windows["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetWin32Windowsworkflow);
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
            setUIAElementSearchMode["UIAElementSearchMode"] = CSharpExpressionConverter.Convert(setUIAElementSearchModeuIAElementSearchMode);
            setUIAElementSearchModepropCount++;
            setUIAElementSearchMode["Workflow"] = CSharpExpressionConverter.ConvertToken(setUIAElementSearchModeworkflow);
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
            getUIAElementSearchMode["Workflow"] = CSharpExpressionConverter.ConvertToken(getUIAElementSearchModeworkflow);
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
            uIAGetElementPatterns["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPatternsparentWindowHandle);
            if (uIAGetElementPatternssearchElementName != null)
            {
                uIAGetElementPatterns["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPatternssearchElementName);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternssearchElementClassName != null)
            {
                uIAGetElementPatterns["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPatternssearchElementClassName);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternssearchElementAutomationId != null)
            {
                uIAGetElementPatterns["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPatternssearchElementAutomationId);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternssearchLocalizedControlType != null)
            {
                uIAGetElementPatterns["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPatternssearchLocalizedControlType);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternssearchSubTree != null)
            {
                if (uIAGetElementPatternssearchSubTree != null)
                {
                    uIAGetElementPatterns["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPatternssearchSubTree);
                    uIAGetElementPatternspropCount++;
                }

                uIAGetElementPatternspropCount++;
            }
            else
            {
                uIAGetElementPatterns["SearchSubTree"] = true;
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternsmatchIndex != null)
            {
                if (uIAGetElementPatternsmatchIndex != null)
                {
                    uIAGetElementPatterns["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPatternsmatchIndex);
                    uIAGetElementPatternspropCount++;
                }

                uIAGetElementPatternspropCount++;
            }
            else
            {
                uIAGetElementPatterns["MatchIndex"] = 1;
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternssearchFilter != null)
            {
                uIAGetElementPatterns["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPatternssearchFilter);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternssortByColumn != null)
            {
                uIAGetElementPatterns["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPatternssortByColumn);
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternsmatchIndexAscending != null)
            {
                if (uIAGetElementPatternsmatchIndexAscending != null)
                {
                    uIAGetElementPatterns["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPatternsmatchIndexAscending);
                    uIAGetElementPatternspropCount++;
                }

                uIAGetElementPatternspropCount++;
            }
            else
            {
                uIAGetElementPatterns["MatchIndexAscending"] = true;
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternsmaxElementsToSearch != null)
            {
                if (uIAGetElementPatternsmaxElementsToSearch != null)
                {
                    uIAGetElementPatterns["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPatternsmaxElementsToSearch);
                    uIAGetElementPatternspropCount++;
                }

                uIAGetElementPatternspropCount++;
            }
            else
            {
                uIAGetElementPatterns["MaxElementsToSearch"] = 0;
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternsmaxRelativeSearchDepth != null)
            {
                if (uIAGetElementPatternsmaxRelativeSearchDepth != null)
                {
                    uIAGetElementPatterns["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPatternsmaxRelativeSearchDepth);
                    uIAGetElementPatternspropCount++;
                }

                uIAGetElementPatternspropCount++;
            }
            else
            {
                uIAGetElementPatterns["MaxRelativeSearchDepth"] = 0;
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternsmaxChildElementsToSearchPerNode != null)
            {
                if (uIAGetElementPatternsmaxChildElementsToSearchPerNode != null)
                {
                    uIAGetElementPatterns["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPatternsmaxChildElementsToSearchPerNode);
                    uIAGetElementPatternspropCount++;
                }

                uIAGetElementPatternspropCount++;
            }
            else
            {
                uIAGetElementPatterns["MaxChildElementsToSearchPerNode"] = 0;
                uIAGetElementPatternspropCount++;
            }

            if (uIAGetElementPatternselementLocalizedControlTypesNotToTraverse != null)
            {
                uIAGetElementPatterns["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPatternselementLocalizedControlTypesNotToTraverse);
                uIAGetElementPatternspropCount++;
            }

            uIAGetElementPatternspropCount++;
            uIAGetElementPatterns["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAGetElementPatternsworkflow);
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
            uIAMoveElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAMoveElementparentWindowHandle);
            if (uIAMoveElementsearchElementName != null)
            {
                uIAMoveElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAMoveElementsearchElementName);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementsearchElementClassName != null)
            {
                uIAMoveElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAMoveElementsearchElementClassName);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementsearchElementAutomationId != null)
            {
                uIAMoveElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAMoveElementsearchElementAutomationId);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementsearchLocalizedControlType != null)
            {
                uIAMoveElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAMoveElementsearchLocalizedControlType);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementsearchSubTree != null)
            {
                if (uIAMoveElementsearchSubTree != null)
                {
                    uIAMoveElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAMoveElementsearchSubTree);
                    uIAMoveElementpropCount++;
                }

                uIAMoveElementpropCount++;
            }
            else
            {
                uIAMoveElement["SearchSubTree"] = true;
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementmatchIndex != null)
            {
                if (uIAMoveElementmatchIndex != null)
                {
                    uIAMoveElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAMoveElementmatchIndex);
                    uIAMoveElementpropCount++;
                }

                uIAMoveElementpropCount++;
            }
            else
            {
                uIAMoveElement["MatchIndex"] = 1;
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementsearchFilter != null)
            {
                uIAMoveElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAMoveElementsearchFilter);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementsortByColumn != null)
            {
                uIAMoveElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAMoveElementsortByColumn);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementmatchIndexAscending != null)
            {
                if (uIAMoveElementmatchIndexAscending != null)
                {
                    uIAMoveElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAMoveElementmatchIndexAscending);
                    uIAMoveElementpropCount++;
                }

                uIAMoveElementpropCount++;
            }
            else
            {
                uIAMoveElement["MatchIndexAscending"] = true;
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementmaxElementsToSearch != null)
            {
                if (uIAMoveElementmaxElementsToSearch != null)
                {
                    uIAMoveElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAMoveElementmaxElementsToSearch);
                    uIAMoveElementpropCount++;
                }

                uIAMoveElementpropCount++;
            }
            else
            {
                uIAMoveElement["MaxElementsToSearch"] = 0;
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementmaxRelativeSearchDepth != null)
            {
                if (uIAMoveElementmaxRelativeSearchDepth != null)
                {
                    uIAMoveElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAMoveElementmaxRelativeSearchDepth);
                    uIAMoveElementpropCount++;
                }

                uIAMoveElementpropCount++;
            }
            else
            {
                uIAMoveElement["MaxRelativeSearchDepth"] = 0;
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIAMoveElementmaxChildElementsToSearchPerNode != null)
                {
                    uIAMoveElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAMoveElementmaxChildElementsToSearchPerNode);
                    uIAMoveElementpropCount++;
                }

                uIAMoveElementpropCount++;
            }
            else
            {
                uIAMoveElement["MaxChildElementsToSearchPerNode"] = 0;
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAMoveElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAMoveElementelementLocalizedControlTypesNotToTraverse);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementhorizontalMovementType != null)
            {
                if (uIAMoveElementhorizontalMovementType != null)
                {
                    uIAMoveElement["HorizontalMovementType"] = CSharpExpressionConverter.Convert(uIAMoveElementhorizontalMovementType);
                    uIAMoveElementpropCount++;
                }

                uIAMoveElementpropCount++;
            }
            else
            {
                uIAMoveElement["HorizontalMovementType"] = "Absolute";
                uIAMoveElementpropCount++;
            }

            uIAMoveElementpropCount++;
            uIAMoveElement["HorizontalPosition"] = CSharpExpressionConverter.ConvertToken(uIAMoveElementhorizontalPosition);
            if (uIAMoveElementverticalMovementType != null)
            {
                if (uIAMoveElementverticalMovementType != null)
                {
                    uIAMoveElement["VerticalMovementType"] = CSharpExpressionConverter.Convert(uIAMoveElementverticalMovementType);
                    uIAMoveElementpropCount++;
                }

                uIAMoveElementpropCount++;
            }
            else
            {
                uIAMoveElement["VerticalMovementType"] = "Absolute";
                uIAMoveElementpropCount++;
            }

            uIAMoveElementpropCount++;
            uIAMoveElement["VerticalPosition"] = CSharpExpressionConverter.ConvertToken(uIAMoveElementverticalPosition);
            uIAMoveElementpropCount++;
            uIAMoveElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAMoveElementworkflow);
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
            uIAResizeElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAResizeElementparentWindowHandle);
            if (uIAResizeElementsearchElementName != null)
            {
                uIAResizeElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAResizeElementsearchElementName);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementsearchElementClassName != null)
            {
                uIAResizeElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAResizeElementsearchElementClassName);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementsearchElementAutomationId != null)
            {
                uIAResizeElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAResizeElementsearchElementAutomationId);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementsearchLocalizedControlType != null)
            {
                uIAResizeElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAResizeElementsearchLocalizedControlType);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementsearchSubTree != null)
            {
                if (uIAResizeElementsearchSubTree != null)
                {
                    uIAResizeElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAResizeElementsearchSubTree);
                    uIAResizeElementpropCount++;
                }

                uIAResizeElementpropCount++;
            }
            else
            {
                uIAResizeElement["SearchSubTree"] = true;
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementmatchIndex != null)
            {
                if (uIAResizeElementmatchIndex != null)
                {
                    uIAResizeElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAResizeElementmatchIndex);
                    uIAResizeElementpropCount++;
                }

                uIAResizeElementpropCount++;
            }
            else
            {
                uIAResizeElement["MatchIndex"] = 1;
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementsearchFilter != null)
            {
                uIAResizeElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAResizeElementsearchFilter);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementsortByColumn != null)
            {
                uIAResizeElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAResizeElementsortByColumn);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementmatchIndexAscending != null)
            {
                if (uIAResizeElementmatchIndexAscending != null)
                {
                    uIAResizeElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAResizeElementmatchIndexAscending);
                    uIAResizeElementpropCount++;
                }

                uIAResizeElementpropCount++;
            }
            else
            {
                uIAResizeElement["MatchIndexAscending"] = true;
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementmaxElementsToSearch != null)
            {
                if (uIAResizeElementmaxElementsToSearch != null)
                {
                    uIAResizeElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAResizeElementmaxElementsToSearch);
                    uIAResizeElementpropCount++;
                }

                uIAResizeElementpropCount++;
            }
            else
            {
                uIAResizeElement["MaxElementsToSearch"] = 0;
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementmaxRelativeSearchDepth != null)
            {
                if (uIAResizeElementmaxRelativeSearchDepth != null)
                {
                    uIAResizeElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAResizeElementmaxRelativeSearchDepth);
                    uIAResizeElementpropCount++;
                }

                uIAResizeElementpropCount++;
            }
            else
            {
                uIAResizeElement["MaxRelativeSearchDepth"] = 0;
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIAResizeElementmaxChildElementsToSearchPerNode != null)
                {
                    uIAResizeElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAResizeElementmaxChildElementsToSearchPerNode);
                    uIAResizeElementpropCount++;
                }

                uIAResizeElementpropCount++;
            }
            else
            {
                uIAResizeElement["MaxChildElementsToSearchPerNode"] = 0;
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAResizeElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAResizeElementelementLocalizedControlTypesNotToTraverse);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementresizeWidthType != null)
            {
                if (uIAResizeElementresizeWidthType != null)
                {
                    uIAResizeElement["ResizeWidthType"] = CSharpExpressionConverter.Convert(uIAResizeElementresizeWidthType);
                    uIAResizeElementpropCount++;
                }

                uIAResizeElementpropCount++;
            }
            else
            {
                uIAResizeElement["ResizeWidthType"] = "Relative";
                uIAResizeElementpropCount++;
            }

            uIAResizeElementpropCount++;
            uIAResizeElement["NewWidth"] = CSharpExpressionConverter.ConvertToken(uIAResizeElementnewWidth);
            if (uIAResizeElementresizeHeightType != null)
            {
                if (uIAResizeElementresizeHeightType != null)
                {
                    uIAResizeElement["ResizeHeightType"] = CSharpExpressionConverter.Convert(uIAResizeElementresizeHeightType);
                    uIAResizeElementpropCount++;
                }

                uIAResizeElementpropCount++;
            }
            else
            {
                uIAResizeElement["ResizeHeightType"] = "Relative";
                uIAResizeElementpropCount++;
            }

            uIAResizeElementpropCount++;
            uIAResizeElement["NewHeight"] = CSharpExpressionConverter.ConvertToken(uIAResizeElementnewHeight);
            uIAResizeElementpropCount++;
            uIAResizeElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAResizeElementworkflow);
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
            uIALocateVisibleSearchImageWithinElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementparentWindowHandle);
            if (uIALocateVisibleSearchImageWithinElementsearchElementName != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementsearchElementName);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementsearchElementClassName != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementsearchElementClassName);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementsearchElementAutomationId != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementsearchElementAutomationId);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementsearchLocalizedControlType != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementsearchLocalizedControlType);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementsearchSubTree != null)
            {
                if (uIALocateVisibleSearchImageWithinElementsearchSubTree != null)
                {
                    uIALocateVisibleSearchImageWithinElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementsearchSubTree);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                uIALocateVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIALocateVisibleSearchImageWithinElement["SearchSubTree"] = true;
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementmatchIndex != null)
            {
                if (uIALocateVisibleSearchImageWithinElementmatchIndex != null)
                {
                    uIALocateVisibleSearchImageWithinElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementmatchIndex);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                uIALocateVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIALocateVisibleSearchImageWithinElement["MatchIndex"] = 1;
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementsearchFilter != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementsearchFilter);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementsortByColumn != null)
            {
                uIALocateVisibleSearchImageWithinElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementsortByColumn);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementmatchIndexAscending != null)
            {
                if (uIALocateVisibleSearchImageWithinElementmatchIndexAscending != null)
                {
                    uIALocateVisibleSearchImageWithinElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementmatchIndexAscending);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                uIALocateVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIALocateVisibleSearchImageWithinElement["MatchIndexAscending"] = true;
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementmaxElementsToSearch != null)
            {
                if (uIALocateVisibleSearchImageWithinElementmaxElementsToSearch != null)
                {
                    uIALocateVisibleSearchImageWithinElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementmaxElementsToSearch);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                uIALocateVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIALocateVisibleSearchImageWithinElement["MaxElementsToSearch"] = 0;
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementmaxRelativeSearchDepth != null)
            {
                if (uIALocateVisibleSearchImageWithinElementmaxRelativeSearchDepth != null)
                {
                    uIALocateVisibleSearchImageWithinElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementmaxRelativeSearchDepth);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                uIALocateVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIALocateVisibleSearchImageWithinElement["MaxRelativeSearchDepth"] = 0;
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIALocateVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode != null)
                {
                    uIALocateVisibleSearchImageWithinElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                uIALocateVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIALocateVisibleSearchImageWithinElement["MaxChildElementsToSearchPerNode"] = 0;
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIALocateVisibleSearchImageWithinElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementsearchImageType != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchImageType"] = CSharpExpressionConverter.Convert(uIALocateVisibleSearchImageWithinElementsearchImageType);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementsearchImage != null)
            {
                uIALocateVisibleSearchImageWithinElement["SearchImage"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementsearchImage);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementaltSearchImageType != null)
            {
                if (uIALocateVisibleSearchImageWithinElementaltSearchImageType != null)
                {
                    uIALocateVisibleSearchImageWithinElement["AltSearchImageType"] = CSharpExpressionConverter.Convert(uIALocateVisibleSearchImageWithinElementaltSearchImageType);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                uIALocateVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIALocateVisibleSearchImageWithinElement["AltSearchImageType"] = "None";
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementaltSearchImage != null)
            {
                uIALocateVisibleSearchImageWithinElement["AltSearchImage"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementaltSearchImage);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementmaxColourDeviation != null)
            {
                if (uIALocateVisibleSearchImageWithinElementmaxColourDeviation != null)
                {
                    uIALocateVisibleSearchImageWithinElement["MaxColourDeviation"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementmaxColourDeviation);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                uIALocateVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIALocateVisibleSearchImageWithinElement["MaxColourDeviation"] = 0;
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementmaxPixelDifferences != null)
            {
                if (uIALocateVisibleSearchImageWithinElementmaxPixelDifferences != null)
                {
                    uIALocateVisibleSearchImageWithinElement["MaxPixelDifferences"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementmaxPixelDifferences);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                uIALocateVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIALocateVisibleSearchImageWithinElement["MaxPixelDifferences"] = 0;
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementmaxConsecutivePixelDifferences != null)
            {
                if (uIALocateVisibleSearchImageWithinElementmaxConsecutivePixelDifferences != null)
                {
                    uIALocateVisibleSearchImageWithinElement["MaxConsecutivePixelDifferences"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementmaxConsecutivePixelDifferences);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                uIALocateVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIALocateVisibleSearchImageWithinElement["MaxConsecutivePixelDifferences"] = 0;
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementleftPixelXOffset != null)
            {
                uIALocateVisibleSearchImageWithinElement["LeftPixelXOffset"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementleftPixelXOffset);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementrightPixelXOffset != null)
            {
                uIALocateVisibleSearchImageWithinElement["RightPixelXOffset"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementrightPixelXOffset);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementtopPixelYOffset != null)
            {
                uIALocateVisibleSearchImageWithinElement["TopPixelYOffset"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementtopPixelYOffset);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementbottomPixelYOffset != null)
            {
                uIALocateVisibleSearchImageWithinElement["BottomPixelYOffset"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementbottomPixelYOffset);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnit != null)
            {
                if (uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnit != null)
                {
                    uIALocateVisibleSearchImageWithinElement["PixelXOffsetsUnit"] = CSharpExpressionConverter.Convert(uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnit);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                uIALocateVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIALocateVisibleSearchImageWithinElement["PixelXOffsetsUnit"] = "Pixel";
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnit != null)
            {
                if (uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnit != null)
                {
                    uIALocateVisibleSearchImageWithinElement["PixelYOffsetsUnit"] = CSharpExpressionConverter.Convert(uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnit);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                uIALocateVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIALocateVisibleSearchImageWithinElement["PixelYOffsetsUnit"] = "Pixel";
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementsearchImageIndex != null)
            {
                if (uIALocateVisibleSearchImageWithinElementsearchImageIndex != null)
                {
                    uIALocateVisibleSearchImageWithinElement["SearchImageIndex"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementsearchImageIndex);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                uIALocateVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIALocateVisibleSearchImageWithinElement["SearchImageIndex"] = 1;
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementimageSearchDirection != null)
            {
                if (uIALocateVisibleSearchImageWithinElementimageSearchDirection != null)
                {
                    uIALocateVisibleSearchImageWithinElement["ImageSearchDirection"] = CSharpExpressionConverter.Convert(uIALocateVisibleSearchImageWithinElementimageSearchDirection);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                uIALocateVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIALocateVisibleSearchImageWithinElement["ImageSearchDirection"] = "FromTop";
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementhideAgent != null)
            {
                if (uIALocateVisibleSearchImageWithinElementhideAgent != null)
                {
                    uIALocateVisibleSearchImageWithinElement["HideAgent"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementhideAgent);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                uIALocateVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIALocateVisibleSearchImageWithinElement["HideAgent"] = true;
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementreturnPhysicalCoordinates != null)
            {
                if (uIALocateVisibleSearchImageWithinElementreturnPhysicalCoordinates != null)
                {
                    uIALocateVisibleSearchImageWithinElement["ReturnPhysicalCoordinates"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementreturnPhysicalCoordinates);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                uIALocateVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIALocateVisibleSearchImageWithinElement["ReturnPhysicalCoordinates"] = false;
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementshowHighlightRectangle != null)
            {
                if (uIALocateVisibleSearchImageWithinElementshowHighlightRectangle != null)
                {
                    uIALocateVisibleSearchImageWithinElement["ShowHighlightRectangle"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementshowHighlightRectangle);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                uIALocateVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIALocateVisibleSearchImageWithinElement["ShowHighlightRectangle"] = false;
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            uIALocateVisibleSearchImageWithinElementpropCount++;
            uIALocateVisibleSearchImageWithinElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementworkflow);
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
                uIAWaitForVisibleSearchImageWithinElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementparentWindowHandle);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementsearchElementName != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementsearchElementName);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementsearchElementClassName != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementsearchElementClassName);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementsearchElementAutomationId != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementsearchElementAutomationId);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementsearchLocalizedControlType != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementsearchLocalizedControlType);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementsearchSubTree != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementsearchSubTree != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementsearchSubTree);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchSubTree"] = true;
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementmatchIndex != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementmatchIndex != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementmatchIndex);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageWithinElement["MatchIndex"] = 1;
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementsearchFilter != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementsearchFilter);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementsortByColumn != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementsortByColumn);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementmatchIndexAscending != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementmatchIndexAscending != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementmatchIndexAscending);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageWithinElement["MatchIndexAscending"] = true;
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementmaxElementsToSearch != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementmaxElementsToSearch != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementmaxElementsToSearch);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageWithinElement["MaxElementsToSearch"] = 0;
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementmaxRelativeSearchDepth != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementmaxRelativeSearchDepth != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementmaxRelativeSearchDepth);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageWithinElement["MaxRelativeSearchDepth"] = 0;
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageWithinElement["MaxChildElementsToSearchPerNode"] = 0;
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementsearchImageType != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchImageType"] = CSharpExpressionConverter.Convert(uIAWaitForVisibleSearchImageWithinElementsearchImageType);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementsearchImage != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchImage"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementsearchImage);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementaltSearchImageType != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementaltSearchImageType != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["AltSearchImageType"] = CSharpExpressionConverter.Convert(uIAWaitForVisibleSearchImageWithinElementaltSearchImageType);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageWithinElement["AltSearchImageType"] = "None";
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementaltSearchImage != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["AltSearchImage"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementaltSearchImage);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementmaxColourDeviation != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementmaxColourDeviation != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["MaxColourDeviation"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementmaxColourDeviation);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageWithinElement["MaxColourDeviation"] = 0;
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementmaxPixelDifferences != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementmaxPixelDifferences != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["MaxPixelDifferences"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementmaxPixelDifferences);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageWithinElement["MaxPixelDifferences"] = 0;
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementmaxConsecutivePixelDifferences != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementmaxConsecutivePixelDifferences != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["MaxConsecutivePixelDifferences"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementmaxConsecutivePixelDifferences);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageWithinElement["MaxConsecutivePixelDifferences"] = 0;
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementleftPixelXOffset != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["LeftPixelXOffset"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementleftPixelXOffset);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementrightPixelXOffset != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["RightPixelXOffset"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementrightPixelXOffset);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementtopPixelYOffset != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["TopPixelYOffset"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementtopPixelYOffset);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementbottomPixelYOffset != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["BottomPixelYOffset"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementbottomPixelYOffset);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnit != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnit != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["PixelXOffsetsUnit"] = CSharpExpressionConverter.Convert(uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnit);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageWithinElement["PixelXOffsetsUnit"] = "Pixel";
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnit != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnit != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["PixelYOffsetsUnit"] = CSharpExpressionConverter.Convert(uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnit);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageWithinElement["PixelYOffsetsUnit"] = "Pixel";
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementsearchImageIndex != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementsearchImageIndex != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["SearchImageIndex"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementsearchImageIndex);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageWithinElement["SearchImageIndex"] = 1;
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementimageSearchDirection != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementimageSearchDirection != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["ImageSearchDirection"] = CSharpExpressionConverter.Convert(uIAWaitForVisibleSearchImageWithinElementimageSearchDirection);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageWithinElement["ImageSearchDirection"] = "FromTop";
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementhideAgent != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementhideAgent != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["HideAgent"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementhideAgent);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageWithinElement["HideAgent"] = true;
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementreturnPhysicalCoordinates != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementreturnPhysicalCoordinates != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["ReturnPhysicalCoordinates"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementreturnPhysicalCoordinates);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageWithinElement["ReturnPhysicalCoordinates"] = false;
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementshowHighlightRectangle != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementshowHighlightRectangle != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["ShowHighlightRectangle"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementshowHighlightRectangle);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageWithinElement["ShowHighlightRectangle"] = false;
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementsecondsToWait != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementsecondsToWait != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["SecondsToWait"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementsecondsToWait);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageWithinElement["SecondsToWait"] = 60;
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementmillisecondsBetweenSearches != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementmillisecondsBetweenSearches != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["MillisecondsBetweenSearches"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementmillisecondsBetweenSearches);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageWithinElement["MillisecondsBetweenSearches"] = 5000;
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementraiseExceptionIfImageNotFound != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementraiseExceptionIfImageNotFound != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["RaiseExceptionIfImageNotFound"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementraiseExceptionIfImageNotFound);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageWithinElement["RaiseExceptionIfImageNotFound"] = true;
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementretrieveOutputDataFromThreadId != null)
            {
                uIAWaitForVisibleSearchImageWithinElement["RetrieveOutputDataFromThreadId"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementretrieveOutputDataFromThreadId);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementwaitForThread != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementwaitForThread != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["WaitForThread"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementwaitForThread);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageWithinElement["WaitForThread"] = true;
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            uIAWaitForVisibleSearchImageWithinElementpropCount++;
            uIAWaitForVisibleSearchImageWithinElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementworkflow);
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
                uIAWaitForVisibleSearchImageToNotExistWithinElement["ParentWindowHandle"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementparentWindowHandle);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementName != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchElementName"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementName);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementClassName != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchElementClassName"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementClassName);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementAutomationId != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchElementAutomationId"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementAutomationId);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchLocalizedControlType != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchLocalizedControlType"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchLocalizedControlType);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchSubTree != null)
            {
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchSubTree != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchSubTree"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchSubTree);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchSubTree"] = true;
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndex != null)
            {
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndex != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MatchIndex"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndex);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MatchIndex"] = 1;
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchFilter != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchFilter"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchFilter);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementsortByColumn != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SortByColumn"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementsortByColumn);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndexAscending != null)
            {
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndexAscending != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MatchIndexAscending"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndexAscending);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MatchIndexAscending"] = true;
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementmaxElementsToSearch != null)
            {
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementmaxElementsToSearch != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxElementsToSearch"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxElementsToSearch);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxElementsToSearch"] = 0;
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementmaxRelativeSearchDepth != null)
            {
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementmaxRelativeSearchDepth != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxRelativeSearchDepth"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxRelativeSearchDepth);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxRelativeSearchDepth"] = 0;
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementmaxChildElementsToSearchPerNode != null)
            {
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementmaxChildElementsToSearchPerNode != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxChildElementsToSearchPerNode"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxChildElementsToSearchPerNode);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxChildElementsToSearchPerNode"] = 0;
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementelementLocalizedControlTypesNotToTraverse != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["ElementLocalizedControlTypesNotToTraverse"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementelementLocalizedControlTypesNotToTraverse);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageType != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchImageType"] = CSharpExpressionConverter.Convert(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageType);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImage != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchImage"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImage);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageType != null)
            {
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageType != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["AltSearchImageType"] = CSharpExpressionConverter.Convert(uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageType);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["AltSearchImageType"] = "None";
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImage != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["AltSearchImage"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImage);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementmaxColourDeviation != null)
            {
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementmaxColourDeviation != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxColourDeviation"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxColourDeviation);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxColourDeviation"] = 0;
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementmaxPixelDifferences != null)
            {
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementmaxPixelDifferences != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxPixelDifferences"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxPixelDifferences);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxPixelDifferences"] = 0;
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementmaxConsecutivePixelDifferences != null)
            {
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementmaxConsecutivePixelDifferences != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxConsecutivePixelDifferences"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxConsecutivePixelDifferences);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxConsecutivePixelDifferences"] = 0;
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementleftPixelXOffset != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["LeftPixelXOffset"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementleftPixelXOffset);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementrightPixelXOffset != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["RightPixelXOffset"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementrightPixelXOffset);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementtopPixelYOffset != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["TopPixelYOffset"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementtopPixelYOffset);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementbottomPixelYOffset != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["BottomPixelYOffset"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementbottomPixelYOffset);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnit != null)
            {
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnit != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["PixelXOffsetsUnit"] = CSharpExpressionConverter.Convert(uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnit);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["PixelXOffsetsUnit"] = "Pixel";
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnit != null)
            {
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnit != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["PixelYOffsetsUnit"] = CSharpExpressionConverter.Convert(uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnit);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["PixelYOffsetsUnit"] = "Pixel";
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageIndex != null)
            {
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageIndex != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchImageIndex"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageIndex);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchImageIndex"] = 1;
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirection != null)
            {
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirection != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["ImageSearchDirection"] = CSharpExpressionConverter.Convert(uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirection);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["ImageSearchDirection"] = "FromTop";
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementhideAgent != null)
            {
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementhideAgent != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["HideAgent"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementhideAgent);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["HideAgent"] = true;
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementshowHighlightRectangle != null)
            {
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementshowHighlightRectangle != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["ShowHighlightRectangle"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementshowHighlightRectangle);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["ShowHighlightRectangle"] = false;
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementsecondsToWait != null)
            {
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementsecondsToWait != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SecondsToWait"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementsecondsToWait);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["SecondsToWait"] = 60;
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementmillisecondsBetweenSearches != null)
            {
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementmillisecondsBetweenSearches != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MillisecondsBetweenSearches"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementmillisecondsBetweenSearches);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["MillisecondsBetweenSearches"] = 5000;
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementraiseExceptionIfImageStillPresent != null)
            {
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementraiseExceptionIfImageStillPresent != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["RaiseExceptionIfImageStillPresent"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementraiseExceptionIfImageStillPresent);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["RaiseExceptionIfImageStillPresent"] = true;
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementretrieveOutputDataFromThreadId != null)
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["RetrieveOutputDataFromThreadId"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementretrieveOutputDataFromThreadId);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementwaitForThread != null)
            {
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementwaitForThread != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["WaitForThread"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementwaitForThread);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }
            else
            {
                uIAWaitForVisibleSearchImageToNotExistWithinElement["WaitForThread"] = true;
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            uIAWaitForVisibleSearchImageToNotExistWithinElement["Workflow"] = CSharpExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementworkflow);
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