//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectuiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIADoesTopLevelWindowExistResponse> UIADoesTopLevelWindowExist([WorkflowExpression] Func<string> uIADoesTopLevelWindowExistworkflow, [WorkflowExpression] Func<string> uIADoesTopLevelWindowExistsearchClassName = null, [WorkflowExpression] Func<string> uIADoesTopLevelWindowExistsearchWindowTitle = null, [WorkflowExpression] Func<int> uIADoesTopLevelWindowExistsearchProcessId = null, [WorkflowExpression] Func<int> uIADoesTopLevelWindowExistmatchIndex = null, [WorkflowExpression] Func<string> uIADoesTopLevelWindowExistsearchFilter = null)
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
                if (uIADoesTopLevelWindowExistmatchIndex != null)
                {
                    uIADoesTopLevelWindowExist["MatchIndex"] = ExpressionConverter.ConvertO(uIADoesTopLevelWindowExistmatchIndex);
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
        public IBodyWorkflowAction<UIAGetHandleForTopLevelWindowResponse> UIAGetHandleForTopLevelWindow([WorkflowExpression] Func<string> uIAGetHandleForTopLevelWindowworkflow, [WorkflowExpression] Func<string> uIAGetHandleForTopLevelWindowsearchClassName = null, [WorkflowExpression] Func<string> uIAGetHandleForTopLevelWindowsearchWindowTitle = null, [WorkflowExpression] Func<int> uIAGetHandleForTopLevelWindowsearchProcessId = null, [WorkflowExpression] Func<int> uIAGetHandleForTopLevelWindowmatchIndex = null, [WorkflowExpression] Func<string> uIAGetHandleForTopLevelWindowsearchFilter = null, [WorkflowExpression] Func<string> uIAGetHandleForTopLevelWindowsortByColumn = null, [WorkflowExpression] Func<bool> uIAGetHandleForTopLevelWindowmatchIndexAscending = null)
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
                if (uIAGetHandleForTopLevelWindowmatchIndex != null)
                {
                    uIAGetHandleForTopLevelWindow["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetHandleForTopLevelWindowmatchIndex);
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
                if (uIAGetHandleForTopLevelWindowmatchIndexAscending != null)
                {
                    uIAGetHandleForTopLevelWindow["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetHandleForTopLevelWindowmatchIndexAscending);
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
            uIAGetHandleForTopLevelWindow["Workflow"] = ExpressionConverter.ConvertO(uIAGetHandleForTopLevelWindowworkflow);
            if (uIAGetHandleForTopLevelWindowpropCount > 0)
            {
                callPayload.Body = uIAGetHandleForTopLevelWindow;
            }

            return new ApiConnectionAction<UIAGetHandleForTopLevelWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForTopLevelWindowResponse> UIAWaitForTopLevelWindow([WorkflowExpression] Func<int> uIAWaitForTopLevelWindowsecondsToWait, [WorkflowExpression] Func<string> uIAWaitForTopLevelWindowworkflow, [WorkflowExpression] Func<string> uIAWaitForTopLevelWindowsearchClassName = null, [WorkflowExpression] Func<string> uIAWaitForTopLevelWindowsearchWindowTitle = null, [WorkflowExpression] Func<int> uIAWaitForTopLevelWindowsearchProcessId = null, [WorkflowExpression] Func<int> uIAWaitForTopLevelWindowmatchIndex = null, [WorkflowExpression] Func<string> uIAWaitForTopLevelWindowsearchFilter = null, [WorkflowExpression] Func<string> uIAWaitForTopLevelWindowsortByColumn = null, [WorkflowExpression] Func<bool> uIAWaitForTopLevelWindowmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIAWaitForTopLevelWindowraiseExceptionIfWindowNotFound = null)
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
                if (uIAWaitForTopLevelWindowmatchIndex != null)
                {
                    uIAWaitForTopLevelWindow["MatchIndex"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowmatchIndex);
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
                if (uIAWaitForTopLevelWindowmatchIndexAscending != null)
                {
                    uIAWaitForTopLevelWindow["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowmatchIndexAscending);
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
                    uIAWaitForTopLevelWindow["RaiseExceptionIfWindowNotFound"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowraiseExceptionIfWindowNotFound);
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
            uIAWaitForTopLevelWindow["Workflow"] = ExpressionConverter.ConvertO(uIAWaitForTopLevelWindowworkflow);
            if (uIAWaitForTopLevelWindowpropCount > 0)
            {
                callPayload.Body = uIAWaitForTopLevelWindow;
            }

            return new ApiConnectionAction<UIAWaitForTopLevelWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIADoesProcessHaveWindowResponse> UIADoesProcessHaveWindow([WorkflowExpression] Func<string> uIADoesProcessHaveWindowsearchProcessName, [WorkflowExpression] Func<string> uIADoesProcessHaveWindowworkflow)
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
        public IBodyWorkflowAction<UIAGetHandleForProcessMainWindowResponse> UIAGetHandleForProcessMainWindow([WorkflowExpression] Func<string> uIAGetHandleForProcessMainWindowsearchProcessName, [WorkflowExpression] Func<string> uIAGetHandleForProcessMainWindowworkflow)
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
        public IBodyWorkflowAction<UIAWaitForProcessMainWindowResponse> UIAWaitForProcessMainWindow([WorkflowExpression] Func<string> uIAWaitForProcessMainWindowsearchProcessName, [WorkflowExpression] Func<int> uIAWaitForProcessMainWindowsecondsToWait, [WorkflowExpression] Func<string> uIAWaitForProcessMainWindowworkflow)
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
        public IBodyWorkflowAction<UIAGetHandleForProcessIdMainWindowResponse> UIAGetHandleForProcessIdMainWindow([WorkflowExpression] Func<int> uIAGetHandleForProcessIdMainWindowprocessId, [WorkflowExpression] Func<string> uIAGetHandleForProcessIdMainWindowworkflow)
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
        public IBodyWorkflowAction<UIAWaitForProcessIdMainWindowResponse> UIAWaitForProcessIdMainWindow([WorkflowExpression] Func<int> uIAWaitForProcessIdMainWindowprocessId, [WorkflowExpression] Func<int> uIAWaitForProcessIdMainWindowsecondsToWait, [WorkflowExpression] Func<string> uIAWaitForProcessIdMainWindowworkflow)
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
        public IBodyWorkflowAction<UIAGetHandleForFocussedElementResponse> UIAGetHandleForFocussedElement([WorkflowExpression] Func<string> uIAGetHandleForFocussedElementworkflow)
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
        public IBodyWorkflowAction<UIAGetHandleForMainWindowOfFocussedElementResponse> UIAGetHandleForMainWindowOfFocussedElement([WorkflowExpression] Func<string> uIAGetHandleForMainWindowOfFocussedElementworkflow)
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
        public IBodyWorkflowAction<UIAGetHandleForDesktopResponse> UIAGetHandleForDesktop([WorkflowExpression] Func<string> uIAGetHandleForDesktopworkflow)
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
        public IWorkflowAction UIASetForegroundWindow([WorkflowExpression] Func<int> uIASetForegroundWindowwindowHandle, [WorkflowExpression] Func<string> uIASetForegroundWindowworkflow, [WorkflowExpression] Func<bool> uIASetForegroundWindowtoggleWindow = null, [WorkflowExpression] Func<bool> uIASetForegroundWindowtoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> uIASetForegroundWindowtoggleDelay = null)
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
                if (uIASetForegroundWindowtoggleWindow != null)
                {
                    uIASetForegroundWindow["ToggleWindow"] = ExpressionConverter.ConvertO(uIASetForegroundWindowtoggleWindow);
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
                    uIASetForegroundWindow["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(uIASetForegroundWindowtoggleUsesGlobalLeftMouseClickAgent);
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
                    uIASetForegroundWindow["ToggleDelay"] = ExpressionConverter.ConvertO(uIASetForegroundWindowtoggleDelay);
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
            uIASetForegroundWindow["Workflow"] = ExpressionConverter.ConvertO(uIASetForegroundWindowworkflow);
            if (uIASetForegroundWindowpropCount > 0)
            {
                callPayload.Body = uIASetForegroundWindow;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAMaximiseWindow([WorkflowExpression] Func<int> uIAMaximiseWindowwindowHandle, [WorkflowExpression] Func<string> uIAMaximiseWindowworkflow)
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
        public IWorkflowAction UIAMinimiseWindow([WorkflowExpression] Func<int> uIAMinimiseWindowwindowHandle, [WorkflowExpression] Func<string> uIAMinimiseWindowworkflow)
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
        public IWorkflowAction UIASetWindowToNormal([WorkflowExpression] Func<int> uIASetWindowToNormalwindowHandle, [WorkflowExpression] Func<string> uIASetWindowToNormalworkflow)
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
        public IBodyWorkflowAction<UIADoesElementExistResponse> UIADoesElementExist([WorkflowExpression] Func<int> uIADoesElementExistparentWindowHandle, [WorkflowExpression] Func<string> uIADoesElementExistworkflow, [WorkflowExpression] Func<string> uIADoesElementExistsearchElementName = null, [WorkflowExpression] Func<string> uIADoesElementExistsearchElementClassName = null, [WorkflowExpression] Func<string> uIADoesElementExistsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIADoesElementExistsearchLocalizedControlType = null, [WorkflowExpression] Func<int> uIADoesElementExistsearchProcessId = null, [WorkflowExpression] Func<bool> uIADoesElementExistsearchSubTree = null, [WorkflowExpression] Func<bool> uIADoesElementExistreturnElementHandle = null, [WorkflowExpression] Func<int> uIADoesElementExistmatchIndex = null, [WorkflowExpression] Func<string> uIADoesElementExistsearchFilter = null, [WorkflowExpression] Func<string> uIADoesElementExistsortByColumn = null, [WorkflowExpression] Func<bool> uIADoesElementExistmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIADoesElementExistincludeChildProcesses = null, [WorkflowExpression] Func<int> uIADoesElementExistmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIADoesElementExistmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIADoesElementExistmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIADoesElementExistelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIADoesElementExistsearchSubTree != null)
                {
                    uIADoesElementExist["SearchSubTree"] = ExpressionConverter.ConvertO(uIADoesElementExistsearchSubTree);
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
                    uIADoesElementExist["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIADoesElementExistreturnElementHandle);
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
                    uIADoesElementExist["MatchIndex"] = ExpressionConverter.ConvertO(uIADoesElementExistmatchIndex);
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
                if (uIADoesElementExistmatchIndexAscending != null)
                {
                    uIADoesElementExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIADoesElementExistmatchIndexAscending);
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
                    uIADoesElementExist["IncludeChildProcesses"] = ExpressionConverter.ConvertO(uIADoesElementExistincludeChildProcesses);
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
                    uIADoesElementExist["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIADoesElementExistmaxElementsToSearch);
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
                    uIADoesElementExist["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIADoesElementExistmaxRelativeSearchDepth);
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
                    uIADoesElementExist["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIADoesElementExistmaxChildElementsToSearchPerNode);
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
        public IBodyWorkflowAction<UIADoesDesktopElementExistResponse> UIADoesDesktopElementExist([WorkflowExpression] Func<string> uIADoesDesktopElementExistworkflow, [WorkflowExpression] Func<string> uIADoesDesktopElementExistsearchElementName = null, [WorkflowExpression] Func<string> uIADoesDesktopElementExistsearchElementClassName = null, [WorkflowExpression] Func<string> uIADoesDesktopElementExistsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIADoesDesktopElementExistsearchLocalizedControlType = null, [WorkflowExpression] Func<int> uIADoesDesktopElementExistsearchProcessId = null, [WorkflowExpression] Func<bool> uIADoesDesktopElementExistsearchSubTree = null, [WorkflowExpression] Func<bool> uIADoesDesktopElementExistreturnElementHandle = null, [WorkflowExpression] Func<int> uIADoesDesktopElementExistmatchIndex = null, [WorkflowExpression] Func<string> uIADoesDesktopElementExistsearchFilter = null, [WorkflowExpression] Func<string> uIADoesDesktopElementExistsortByColumn = null, [WorkflowExpression] Func<bool> uIADoesDesktopElementExistmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIADoesDesktopElementExistincludeChildProcesses = null, [WorkflowExpression] Func<int> uIADoesDesktopElementExistmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIADoesDesktopElementExistmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIADoesDesktopElementExistmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIADoesDesktopElementExistelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIADoesDesktopElementExistsearchSubTree != null)
                {
                    uIADoesDesktopElementExist["SearchSubTree"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistsearchSubTree);
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
                    uIADoesDesktopElementExist["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistreturnElementHandle);
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
                    uIADoesDesktopElementExist["MatchIndex"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistmatchIndex);
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
                if (uIADoesDesktopElementExistmatchIndexAscending != null)
                {
                    uIADoesDesktopElementExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistmatchIndexAscending);
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
                    uIADoesDesktopElementExist["IncludeChildProcesses"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistincludeChildProcesses);
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
                    uIADoesDesktopElementExist["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistmaxElementsToSearch);
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
                    uIADoesDesktopElementExist["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistmaxRelativeSearchDepth);
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
                    uIADoesDesktopElementExist["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIADoesDesktopElementExistmaxChildElementsToSearchPerNode);
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
        public IBodyWorkflowAction<UIAWaitForElementResponse> UIAWaitForElement([WorkflowExpression] Func<int> uIAWaitForElementparentWindowHandle, [WorkflowExpression] Func<int> uIAWaitForElementsecondsToWait, [WorkflowExpression] Func<string> uIAWaitForElementworkflow, [WorkflowExpression] Func<string> uIAWaitForElementsearchElementName = null, [WorkflowExpression] Func<string> uIAWaitForElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAWaitForElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAWaitForElementsearchLocalizedControlType = null, [WorkflowExpression] Func<int> uIAWaitForElementsearchProcessId = null, [WorkflowExpression] Func<bool> uIAWaitForElementsearchSubTree = null, [WorkflowExpression] Func<bool> uIAWaitForElementreturnElementHandle = null, [WorkflowExpression] Func<int> uIAWaitForElementmatchIndex = null, [WorkflowExpression] Func<string> uIAWaitForElementsearchFilter = null, [WorkflowExpression] Func<string> uIAWaitForElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAWaitForElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIAWaitForElementincludeChildProcesses = null, [WorkflowExpression] Func<bool> uIAWaitForElementraiseExceptionIfElementNotFound = null, [WorkflowExpression] Func<int> uIAWaitForElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAWaitForElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAWaitForElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAWaitForElementelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIAWaitForElementsearchSubTree != null)
                {
                    uIAWaitForElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAWaitForElementsearchSubTree);
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
                    uIAWaitForElement["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIAWaitForElementreturnElementHandle);
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
            uIAWaitForElement["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForElementsecondsToWait);
            if (uIAWaitForElementmatchIndex != null)
            {
                if (uIAWaitForElementmatchIndex != null)
                {
                    uIAWaitForElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAWaitForElementmatchIndex);
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
                if (uIAWaitForElementmatchIndexAscending != null)
                {
                    uIAWaitForElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAWaitForElementmatchIndexAscending);
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
                    uIAWaitForElement["IncludeChildProcesses"] = ExpressionConverter.ConvertO(uIAWaitForElementincludeChildProcesses);
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
                    uIAWaitForElement["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(uIAWaitForElementraiseExceptionIfElementNotFound);
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
                    uIAWaitForElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAWaitForElementmaxElementsToSearch);
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
                    uIAWaitForElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAWaitForElementmaxRelativeSearchDepth);
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
                    uIAWaitForElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAWaitForElementmaxChildElementsToSearchPerNode);
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
        public IBodyWorkflowAction<UIAWaitForDesktopElementResponse> UIAWaitForDesktopElement([WorkflowExpression] Func<int> uIAWaitForDesktopElementsecondsToWait, [WorkflowExpression] Func<string> uIAWaitForDesktopElementworkflow, [WorkflowExpression] Func<string> uIAWaitForDesktopElementsearchElementName = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementsearchLocalizedControlType = null, [WorkflowExpression] Func<int> uIAWaitForDesktopElementsearchProcessId = null, [WorkflowExpression] Func<bool> uIAWaitForDesktopElementsearchSubTree = null, [WorkflowExpression] Func<bool> uIAWaitForDesktopElementreturnElementHandle = null, [WorkflowExpression] Func<int> uIAWaitForDesktopElementmatchIndex = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementsearchFilter = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAWaitForDesktopElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIAWaitForDesktopElementincludeChildProcesses = null, [WorkflowExpression] Func<bool> uIAWaitForDesktopElementraiseExceptionIfElementNotFound = null, [WorkflowExpression] Func<int> uIAWaitForDesktopElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAWaitForDesktopElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAWaitForDesktopElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIAWaitForDesktopElementsearchProcessId != null)
                {
                    uIAWaitForDesktopElement["SearchProcessId"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementsearchProcessId);
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
                    uIAWaitForDesktopElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementsearchSubTree);
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
                    uIAWaitForDesktopElement["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementreturnElementHandle);
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
            uIAWaitForDesktopElement["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementsecondsToWait);
            if (uIAWaitForDesktopElementmatchIndex != null)
            {
                if (uIAWaitForDesktopElementmatchIndex != null)
                {
                    uIAWaitForDesktopElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementmatchIndex);
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
                if (uIAWaitForDesktopElementmatchIndexAscending != null)
                {
                    uIAWaitForDesktopElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementmatchIndexAscending);
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
                    uIAWaitForDesktopElement["IncludeChildProcesses"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementincludeChildProcesses);
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
                    uIAWaitForDesktopElement["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementraiseExceptionIfElementNotFound);
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
                    uIAWaitForDesktopElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementmaxElementsToSearch);
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
                    uIAWaitForDesktopElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementmaxRelativeSearchDepth);
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
                    uIAWaitForDesktopElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementmaxChildElementsToSearchPerNode);
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
        public IBodyWorkflowAction<UIAWaitForElementToNotExistResponse> UIAWaitForElementToNotExist([WorkflowExpression] Func<int> uIAWaitForElementToNotExistparentWindowHandle, [WorkflowExpression] Func<int> uIAWaitForElementToNotExistsecondsToWait, [WorkflowExpression] Func<string> uIAWaitForElementToNotExistworkflow, [WorkflowExpression] Func<string> uIAWaitForElementToNotExistsearchElementName = null, [WorkflowExpression] Func<string> uIAWaitForElementToNotExistsearchElementClassName = null, [WorkflowExpression] Func<string> uIAWaitForElementToNotExistsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAWaitForElementToNotExistsearchLocalizedControlType = null, [WorkflowExpression] Func<int> uIAWaitForElementToNotExistsearchProcessId = null, [WorkflowExpression] Func<bool> uIAWaitForElementToNotExistsearchSubTree = null, [WorkflowExpression] Func<int> uIAWaitForElementToNotExistmatchIndex = null, [WorkflowExpression] Func<string> uIAWaitForElementToNotExistsearchFilter = null, [WorkflowExpression] Func<string> uIAWaitForElementToNotExistsortByColumn = null, [WorkflowExpression] Func<bool> uIAWaitForElementToNotExistmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIAWaitForElementToNotExistincludeChildProcesses = null, [WorkflowExpression] Func<bool> uIAWaitForElementToNotExistraiseExceptionIfElementStillExists = null, [WorkflowExpression] Func<int> uIAWaitForElementToNotExistmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAWaitForElementToNotExistmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAWaitForElementToNotExistmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAWaitForElementToNotExistelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIAWaitForElementToNotExistsearchSubTree != null)
                {
                    uIAWaitForElementToNotExist["SearchSubTree"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistsearchSubTree);
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
            uIAWaitForElementToNotExist["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistsecondsToWait);
            if (uIAWaitForElementToNotExistmatchIndex != null)
            {
                if (uIAWaitForElementToNotExistmatchIndex != null)
                {
                    uIAWaitForElementToNotExist["MatchIndex"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistmatchIndex);
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
                if (uIAWaitForElementToNotExistmatchIndexAscending != null)
                {
                    uIAWaitForElementToNotExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistmatchIndexAscending);
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
                    uIAWaitForElementToNotExist["IncludeChildProcesses"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistincludeChildProcesses);
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
                    uIAWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistraiseExceptionIfElementStillExists);
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
                    uIAWaitForElementToNotExist["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistmaxElementsToSearch);
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
                    uIAWaitForElementToNotExist["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistmaxRelativeSearchDepth);
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
                    uIAWaitForElementToNotExist["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAWaitForElementToNotExistmaxChildElementsToSearchPerNode);
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
        public IBodyWorkflowAction<UIAWaitForDesktopElementToNotExistResponse> UIAWaitForDesktopElementToNotExist([WorkflowExpression] Func<int> uIAWaitForDesktopElementToNotExistsecondsToWait, [WorkflowExpression] Func<string> uIAWaitForDesktopElementToNotExistworkflow, [WorkflowExpression] Func<string> uIAWaitForDesktopElementToNotExistsearchElementName = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementToNotExistsearchElementClassName = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementToNotExistsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementToNotExistsearchLocalizedControlType = null, [WorkflowExpression] Func<int> uIAWaitForDesktopElementToNotExistsearchProcessId = null, [WorkflowExpression] Func<bool> uIAWaitForDesktopElementToNotExistsearchSubTree = null, [WorkflowExpression] Func<int> uIAWaitForDesktopElementToNotExistmatchIndex = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementToNotExistsearchFilter = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementToNotExistsortByColumn = null, [WorkflowExpression] Func<bool> uIAWaitForDesktopElementToNotExistmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIAWaitForDesktopElementToNotExistincludeChildProcesses = null, [WorkflowExpression] Func<bool> uIAWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists = null, [WorkflowExpression] Func<int> uIAWaitForDesktopElementToNotExistmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAWaitForDesktopElementToNotExistmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAWaitForDesktopElementToNotExistmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementToNotExistelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIAWaitForDesktopElementToNotExistsearchSubTree != null)
                {
                    uIAWaitForDesktopElementToNotExist["SearchSubTree"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistsearchSubTree);
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
            uIAWaitForDesktopElementToNotExist["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistsecondsToWait);
            if (uIAWaitForDesktopElementToNotExistmatchIndex != null)
            {
                if (uIAWaitForDesktopElementToNotExistmatchIndex != null)
                {
                    uIAWaitForDesktopElementToNotExist["MatchIndex"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistmatchIndex);
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
                if (uIAWaitForDesktopElementToNotExistmatchIndexAscending != null)
                {
                    uIAWaitForDesktopElementToNotExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistmatchIndexAscending);
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
                    uIAWaitForDesktopElementToNotExist["IncludeChildProcesses"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistincludeChildProcesses);
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
                    uIAWaitForDesktopElementToNotExist["RaiseExceptionIfElementStillExists"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists);
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
                    uIAWaitForDesktopElementToNotExist["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistmaxElementsToSearch);
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
                    uIAWaitForDesktopElementToNotExist["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistmaxRelativeSearchDepth);
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
                    uIAWaitForDesktopElementToNotExist["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAWaitForDesktopElementToNotExistmaxChildElementsToSearchPerNode);
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
        public IWorkflowAction UIAPressElement([WorkflowExpression] Func<int> uIAPressElementparentWindowHandle, [WorkflowExpression] Func<string> uIAPressElementworkflow, [WorkflowExpression] Func<string> uIAPressElementsearchElementName = null, [WorkflowExpression] Func<string> uIAPressElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAPressElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAPressElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAPressElementsearchSubTree = null, [WorkflowExpression] Func<bool> uIAPressElementwait = null, [WorkflowExpression] Func<bool> uIAPressElementwin32ClickButton = null, [WorkflowExpression] Func<int> uIAPressElementmatchIndex = null, [WorkflowExpression] Func<string> uIAPressElementsearchFilter = null, [WorkflowExpression] Func<string> uIAPressElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAPressElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAPressElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAPressElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAPressElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAPressElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIAPressElementtryInvokePattern = null, [WorkflowExpression] Func<bool> uIAPressElementtryLegacyPattern = null)
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
                if (uIAPressElementsearchSubTree != null)
                {
                    uIAPressElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAPressElementsearchSubTree);
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
                    uIAPressElement["Wait"] = ExpressionConverter.ConvertO(uIAPressElementwait);
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
                    uIAPressElement["Win32ClickButton"] = ExpressionConverter.ConvertO(uIAPressElementwin32ClickButton);
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
                    uIAPressElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAPressElementmatchIndex);
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
                if (uIAPressElementmatchIndexAscending != null)
                {
                    uIAPressElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAPressElementmatchIndexAscending);
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
                    uIAPressElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAPressElementmaxElementsToSearch);
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
                    uIAPressElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAPressElementmaxRelativeSearchDepth);
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
                    uIAPressElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAPressElementmaxChildElementsToSearchPerNode);
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
                uIAPressElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAPressElementelementLocalizedControlTypesNotToTraverse);
                uIAPressElementpropCount++;
            }

            if (uIAPressElementtryInvokePattern != null)
            {
                if (uIAPressElementtryInvokePattern != null)
                {
                    uIAPressElement["TryInvokePattern"] = ExpressionConverter.ConvertO(uIAPressElementtryInvokePattern);
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
                    uIAPressElement["TryLegacyPattern"] = ExpressionConverter.ConvertO(uIAPressElementtryLegacyPattern);
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
            uIAPressElement["Workflow"] = ExpressionConverter.ConvertO(uIAPressElementworkflow);
            if (uIAPressElementpropCount > 0)
            {
                callPayload.Body = uIAPressElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalMouseClickOnElement([WorkflowExpression] Func<int> uIAGlobalMouseClickOnElementparentWindowHandle, [WorkflowExpression] Func<string> uIAGlobalMouseClickOnElementworkflow, [WorkflowExpression] Func<string> uIAGlobalMouseClickOnElementsearchElementName = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickOnElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickOnElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGlobalMouseClickOnElementsearchSubTree = null, [WorkflowExpression] Func<bool> uIAGlobalMouseClickOnElementfocusElementFirst = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickOnElementmatchIndex = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickOnElementsearchFilter = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickOnElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAGlobalMouseClickOnElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickOnElementclickOffsetX = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickOnElementclickOffsetY = null, [WorkflowExpression] Func<uIAGlobalMouseClickOnElementoffsetRelativeToInput> uIAGlobalMouseClickOnElementoffsetRelativeTo = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickOnElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickOnElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickOnElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickOnElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIAGlobalMouseClickOnElementvalidateClickablePointWithinElementBoundary = null)
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
                if (uIAGlobalMouseClickOnElementsearchSubTree != null)
                {
                    uIAGlobalMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementsearchSubTree);
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
                    uIAGlobalMouseClickOnElement["FocusElementFirst"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementfocusElementFirst);
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
                    uIAGlobalMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementmatchIndex);
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
                if (uIAGlobalMouseClickOnElementmatchIndexAscending != null)
                {
                    uIAGlobalMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementmatchIndexAscending);
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
                    uIAGlobalMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementclickOffsetX);
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
                    uIAGlobalMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementclickOffsetY);
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
                uIAGlobalMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementoffsetRelativeTo);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementmaxElementsToSearch != null)
            {
                if (uIAGlobalMouseClickOnElementmaxElementsToSearch != null)
                {
                    uIAGlobalMouseClickOnElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementmaxElementsToSearch);
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
                    uIAGlobalMouseClickOnElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementmaxRelativeSearchDepth);
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
                    uIAGlobalMouseClickOnElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementmaxChildElementsToSearchPerNode);
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
                uIAGlobalMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementelementLocalizedControlTypesNotToTraverse);
                uIAGlobalMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
            {
                if (uIAGlobalMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                {
                    uIAGlobalMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementvalidateClickablePointWithinElementBoundary);
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
            uIAGlobalMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickOnElementworkflow);
            if (uIAGlobalMouseClickOnElementpropCount > 0)
            {
                callPayload.Body = uIAGlobalMouseClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalRightMouseClickOnElement([WorkflowExpression] Func<int> uIAGlobalRightMouseClickOnElementparentWindowHandle, [WorkflowExpression] Func<string> uIAGlobalRightMouseClickOnElementworkflow, [WorkflowExpression] Func<string> uIAGlobalRightMouseClickOnElementsearchElementName = null, [WorkflowExpression] Func<string> uIAGlobalRightMouseClickOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAGlobalRightMouseClickOnElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGlobalRightMouseClickOnElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGlobalRightMouseClickOnElementsearchSubTree = null, [WorkflowExpression] Func<bool> uIAGlobalRightMouseClickOnElementfocusElementFirst = null, [WorkflowExpression] Func<int> uIAGlobalRightMouseClickOnElementmatchIndex = null, [WorkflowExpression] Func<string> uIAGlobalRightMouseClickOnElementsearchFilter = null, [WorkflowExpression] Func<string> uIAGlobalRightMouseClickOnElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAGlobalRightMouseClickOnElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAGlobalRightMouseClickOnElementclickOffsetX = null, [WorkflowExpression] Func<int> uIAGlobalRightMouseClickOnElementclickOffsetY = null, [WorkflowExpression] Func<uIAGlobalRightMouseClickOnElementoffsetRelativeToInput> uIAGlobalRightMouseClickOnElementoffsetRelativeTo = null, [WorkflowExpression] Func<int> uIAGlobalRightMouseClickOnElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGlobalRightMouseClickOnElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGlobalRightMouseClickOnElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGlobalRightMouseClickOnElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIAGlobalRightMouseClickOnElementvalidateClickablePointWithinElementBoundary = null)
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
                if (uIAGlobalRightMouseClickOnElementsearchSubTree != null)
                {
                    uIAGlobalRightMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementsearchSubTree);
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
                    uIAGlobalRightMouseClickOnElement["FocusElementFirst"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementfocusElementFirst);
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
                    uIAGlobalRightMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementmatchIndex);
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
                if (uIAGlobalRightMouseClickOnElementmatchIndexAscending != null)
                {
                    uIAGlobalRightMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementmatchIndexAscending);
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
                    uIAGlobalRightMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementclickOffsetX);
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
                    uIAGlobalRightMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementclickOffsetY);
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
                uIAGlobalRightMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementoffsetRelativeTo);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementmaxElementsToSearch != null)
            {
                if (uIAGlobalRightMouseClickOnElementmaxElementsToSearch != null)
                {
                    uIAGlobalRightMouseClickOnElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementmaxElementsToSearch);
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
                    uIAGlobalRightMouseClickOnElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementmaxRelativeSearchDepth);
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
                    uIAGlobalRightMouseClickOnElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementmaxChildElementsToSearchPerNode);
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
                uIAGlobalRightMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementelementLocalizedControlTypesNotToTraverse);
                uIAGlobalRightMouseClickOnElementpropCount++;
            }

            if (uIAGlobalRightMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
            {
                if (uIAGlobalRightMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                {
                    uIAGlobalRightMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementvalidateClickablePointWithinElementBoundary);
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
            uIAGlobalRightMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(uIAGlobalRightMouseClickOnElementworkflow);
            if (uIAGlobalRightMouseClickOnElementpropCount > 0)
            {
                callPayload.Body = uIAGlobalRightMouseClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalMiddleMouseClickOnElement([WorkflowExpression] Func<int> uIAGlobalMiddleMouseClickOnElementparentWindowHandle, [WorkflowExpression] Func<string> uIAGlobalMiddleMouseClickOnElementworkflow, [WorkflowExpression] Func<string> uIAGlobalMiddleMouseClickOnElementsearchElementName = null, [WorkflowExpression] Func<string> uIAGlobalMiddleMouseClickOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAGlobalMiddleMouseClickOnElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGlobalMiddleMouseClickOnElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGlobalMiddleMouseClickOnElementsearchSubTree = null, [WorkflowExpression] Func<bool> uIAGlobalMiddleMouseClickOnElementfocusElementFirst = null, [WorkflowExpression] Func<int> uIAGlobalMiddleMouseClickOnElementmatchIndex = null, [WorkflowExpression] Func<string> uIAGlobalMiddleMouseClickOnElementsearchFilter = null, [WorkflowExpression] Func<string> uIAGlobalMiddleMouseClickOnElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAGlobalMiddleMouseClickOnElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAGlobalMiddleMouseClickOnElementclickOffsetX = null, [WorkflowExpression] Func<int> uIAGlobalMiddleMouseClickOnElementclickOffsetY = null, [WorkflowExpression] Func<uIAGlobalMiddleMouseClickOnElementoffsetRelativeToInput> uIAGlobalMiddleMouseClickOnElementoffsetRelativeTo = null, [WorkflowExpression] Func<int> uIAGlobalMiddleMouseClickOnElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGlobalMiddleMouseClickOnElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGlobalMiddleMouseClickOnElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGlobalMiddleMouseClickOnElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIAGlobalMiddleMouseClickOnElementvalidateClickablePointWithinElementBoundary = null)
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
                if (uIAGlobalMiddleMouseClickOnElementsearchSubTree != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementsearchSubTree);
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
                    uIAGlobalMiddleMouseClickOnElement["FocusElementFirst"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementfocusElementFirst);
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
                    uIAGlobalMiddleMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementmatchIndex);
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
                if (uIAGlobalMiddleMouseClickOnElementmatchIndexAscending != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementmatchIndexAscending);
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
                    uIAGlobalMiddleMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementclickOffsetX);
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
                    uIAGlobalMiddleMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementclickOffsetY);
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
                uIAGlobalMiddleMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementoffsetRelativeTo);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementmaxElementsToSearch != null)
            {
                if (uIAGlobalMiddleMouseClickOnElementmaxElementsToSearch != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementmaxElementsToSearch);
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
                    uIAGlobalMiddleMouseClickOnElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementmaxRelativeSearchDepth);
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
                    uIAGlobalMiddleMouseClickOnElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementmaxChildElementsToSearchPerNode);
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
                uIAGlobalMiddleMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementelementLocalizedControlTypesNotToTraverse);
                uIAGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (uIAGlobalMiddleMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
            {
                if (uIAGlobalMiddleMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementvalidateClickablePointWithinElementBoundary);
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
            uIAGlobalMiddleMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(uIAGlobalMiddleMouseClickOnElementworkflow);
            if (uIAGlobalMiddleMouseClickOnElementpropCount > 0)
            {
                callPayload.Body = uIAGlobalMiddleMouseClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalDoubleLeftMouseClickOnElement([WorkflowExpression] Func<int> uIAGlobalDoubleLeftMouseClickOnElementparentWindowHandle, [WorkflowExpression] Func<string> uIAGlobalDoubleLeftMouseClickOnElementworkflow, [WorkflowExpression] Func<string> uIAGlobalDoubleLeftMouseClickOnElementsearchElementName = null, [WorkflowExpression] Func<string> uIAGlobalDoubleLeftMouseClickOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAGlobalDoubleLeftMouseClickOnElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGlobalDoubleLeftMouseClickOnElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGlobalDoubleLeftMouseClickOnElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds = null, [WorkflowExpression] Func<bool> uIAGlobalDoubleLeftMouseClickOnElementfocusElementFirst = null, [WorkflowExpression] Func<int> uIAGlobalDoubleLeftMouseClickOnElementmatchIndex = null, [WorkflowExpression] Func<string> uIAGlobalDoubleLeftMouseClickOnElementsearchFilter = null, [WorkflowExpression] Func<string> uIAGlobalDoubleLeftMouseClickOnElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAGlobalDoubleLeftMouseClickOnElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAGlobalDoubleLeftMouseClickOnElementclickOffsetX = null, [WorkflowExpression] Func<int> uIAGlobalDoubleLeftMouseClickOnElementclickOffsetY = null, [WorkflowExpression] Func<uIAGlobalDoubleLeftMouseClickOnElementoffsetRelativeToInput> uIAGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo = null, [WorkflowExpression] Func<int> uIAGlobalDoubleLeftMouseClickOnElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGlobalDoubleLeftMouseClickOnElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGlobalDoubleLeftMouseClickOnElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGlobalDoubleLeftMouseClickOnElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIAGlobalDoubleLeftMouseClickOnElementvalidateClickablePointWithinElementBoundary = null)
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
                if (uIAGlobalDoubleLeftMouseClickOnElementsearchSubTree != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementsearchSubTree);
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
                    uIAGlobalDoubleLeftMouseClickOnElement["DelayInMilliseconds"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds);
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
                    uIAGlobalDoubleLeftMouseClickOnElement["FocusElementFirst"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementfocusElementFirst);
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
                    uIAGlobalDoubleLeftMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementmatchIndex);
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
                if (uIAGlobalDoubleLeftMouseClickOnElementmatchIndexAscending != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementmatchIndexAscending);
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
                    uIAGlobalDoubleLeftMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementclickOffsetX);
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
                    uIAGlobalDoubleLeftMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementclickOffsetY);
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
                uIAGlobalDoubleLeftMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementmaxElementsToSearch != null)
            {
                if (uIAGlobalDoubleLeftMouseClickOnElementmaxElementsToSearch != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementmaxElementsToSearch);
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
                    uIAGlobalDoubleLeftMouseClickOnElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementmaxRelativeSearchDepth);
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
                    uIAGlobalDoubleLeftMouseClickOnElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementmaxChildElementsToSearchPerNode);
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
                uIAGlobalDoubleLeftMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementelementLocalizedControlTypesNotToTraverse);
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (uIAGlobalDoubleLeftMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
            {
                if (uIAGlobalDoubleLeftMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementvalidateClickablePointWithinElementBoundary);
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
            uIAGlobalDoubleLeftMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(uIAGlobalDoubleLeftMouseClickOnElementworkflow);
            if (uIAGlobalDoubleLeftMouseClickOnElementpropCount > 0)
            {
                callPayload.Body = uIAGlobalDoubleLeftMouseClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIASelectElement([WorkflowExpression] Func<int> uIASelectElementparentWindowHandle, [WorkflowExpression] Func<string> uIASelectElementworkflow, [WorkflowExpression] Func<string> uIASelectElementsearchElementName = null, [WorkflowExpression] Func<string> uIASelectElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIASelectElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIASelectElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIASelectElementsearchSubTree = null, [WorkflowExpression] Func<int> uIASelectElementmatchIndex = null, [WorkflowExpression] Func<string> uIASelectElementsearchFilter = null, [WorkflowExpression] Func<string> uIASelectElementsortByColumn = null, [WorkflowExpression] Func<bool> uIASelectElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIASelectElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIASelectElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIASelectElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIASelectElementelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIASelectElementsearchSubTree != null)
                {
                    uIASelectElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIASelectElementsearchSubTree);
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
                    uIASelectElement["MatchIndex"] = ExpressionConverter.ConvertO(uIASelectElementmatchIndex);
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
                if (uIASelectElementmatchIndexAscending != null)
                {
                    uIASelectElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIASelectElementmatchIndexAscending);
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
                    uIASelectElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIASelectElementmaxElementsToSearch);
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
                    uIASelectElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIASelectElementmaxRelativeSearchDepth);
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
                    uIASelectElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIASelectElementmaxChildElementsToSearchPerNode);
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
        public IWorkflowAction UIAInputPasswordIntoElement([WorkflowExpression] Func<int> uIAInputPasswordIntoElementparentWindowHandle, [WorkflowExpression] Func<string> uIAInputPasswordIntoElementpasswordToInput, [WorkflowExpression] Func<string> uIAInputPasswordIntoElementworkflow, [WorkflowExpression] Func<string> uIAInputPasswordIntoElementsearchElementName = null, [WorkflowExpression] Func<string> uIAInputPasswordIntoElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAInputPasswordIntoElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAInputPasswordIntoElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAInputPasswordIntoElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAInputPasswordIntoElementmatchIndex = null, [WorkflowExpression] Func<string> uIAInputPasswordIntoElementsearchFilter = null, [WorkflowExpression] Func<string> uIAInputPasswordIntoElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAInputPasswordIntoElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIAInputPasswordIntoElementpasswordContainsStoredPassword = null, [WorkflowExpression] Func<int> uIAInputPasswordIntoElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAInputPasswordIntoElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAInputPasswordIntoElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAInputPasswordIntoElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIAInputPasswordIntoElementtryValuePattern = null, [WorkflowExpression] Func<bool> uIAInputPasswordIntoElementtryLegacyPattern = null)
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
                if (uIAInputPasswordIntoElementsearchSubTree != null)
                {
                    uIAInputPasswordIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementsearchSubTree);
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
            uIAInputPasswordIntoElement["PasswordToInput"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementpasswordToInput);
            if (uIAInputPasswordIntoElementmatchIndex != null)
            {
                if (uIAInputPasswordIntoElementmatchIndex != null)
                {
                    uIAInputPasswordIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementmatchIndex);
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
                if (uIAInputPasswordIntoElementmatchIndexAscending != null)
                {
                    uIAInputPasswordIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementmatchIndexAscending);
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
                    uIAInputPasswordIntoElement["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementpasswordContainsStoredPassword);
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
                    uIAInputPasswordIntoElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementmaxElementsToSearch);
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
                    uIAInputPasswordIntoElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementmaxRelativeSearchDepth);
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
                    uIAInputPasswordIntoElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementmaxChildElementsToSearchPerNode);
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
                uIAInputPasswordIntoElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementelementLocalizedControlTypesNotToTraverse);
                uIAInputPasswordIntoElementpropCount++;
            }

            if (uIAInputPasswordIntoElementtryValuePattern != null)
            {
                if (uIAInputPasswordIntoElementtryValuePattern != null)
                {
                    uIAInputPasswordIntoElement["TryValuePattern"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementtryValuePattern);
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
                    uIAInputPasswordIntoElement["TryLegacyPattern"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementtryLegacyPattern);
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
            uIAInputPasswordIntoElement["Workflow"] = ExpressionConverter.ConvertO(uIAInputPasswordIntoElementworkflow);
            if (uIAInputPasswordIntoElementpropCount > 0)
            {
                callPayload.Body = uIAInputPasswordIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAInputTextIntoElement([WorkflowExpression] Func<int> uIAInputTextIntoElementparentWindowHandle, [WorkflowExpression] Func<string> uIAInputTextIntoElementworkflow, [WorkflowExpression] Func<string> uIAInputTextIntoElementsearchElementName = null, [WorkflowExpression] Func<string> uIAInputTextIntoElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAInputTextIntoElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAInputTextIntoElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAInputTextIntoElementsearchSubTree = null, [WorkflowExpression] Func<string> uIAInputTextIntoElementtextToInput = null, [WorkflowExpression] Func<int> uIAInputTextIntoElementmatchIndex = null, [WorkflowExpression] Func<string> uIAInputTextIntoElementsearchFilter = null, [WorkflowExpression] Func<string> uIAInputTextIntoElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAInputTextIntoElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIAInputTextIntoElementreplaceExistingValue = null, [WorkflowExpression] Func<int> uIAInputTextIntoElementinsertPosition = null, [WorkflowExpression] Func<int> uIAInputTextIntoElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAInputTextIntoElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAInputTextIntoElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAInputTextIntoElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIAInputTextIntoElementraiseExceptionIfInputValidationFails = null, [WorkflowExpression] Func<bool> uIAInputTextIntoElementtryValuePattern = null, [WorkflowExpression] Func<bool> uIAInputTextIntoElementtryLegacyPattern = null)
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
                if (uIAInputTextIntoElementsearchSubTree != null)
                {
                    uIAInputTextIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementsearchSubTree);
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
                uIAInputTextIntoElement["TextToInput"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementtextToInput);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementmatchIndex != null)
            {
                if (uIAInputTextIntoElementmatchIndex != null)
                {
                    uIAInputTextIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementmatchIndex);
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
                if (uIAInputTextIntoElementmatchIndexAscending != null)
                {
                    uIAInputTextIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementmatchIndexAscending);
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
                    uIAInputTextIntoElement["ReplaceExistingValue"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementreplaceExistingValue);
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
                    uIAInputTextIntoElement["InsertPosition"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementinsertPosition);
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
                    uIAInputTextIntoElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementmaxElementsToSearch);
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
                    uIAInputTextIntoElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementmaxRelativeSearchDepth);
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
                    uIAInputTextIntoElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementmaxChildElementsToSearchPerNode);
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
                uIAInputTextIntoElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementelementLocalizedControlTypesNotToTraverse);
                uIAInputTextIntoElementpropCount++;
            }

            if (uIAInputTextIntoElementraiseExceptionIfInputValidationFails != null)
            {
                if (uIAInputTextIntoElementraiseExceptionIfInputValidationFails != null)
                {
                    uIAInputTextIntoElement["RaiseExceptionIfInputValidationFails"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementraiseExceptionIfInputValidationFails);
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
                    uIAInputTextIntoElement["TryValuePattern"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementtryValuePattern);
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
                    uIAInputTextIntoElement["TryLegacyPattern"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementtryLegacyPattern);
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
            uIAInputTextIntoElement["Workflow"] = ExpressionConverter.ConvertO(uIAInputTextIntoElementworkflow);
            if (uIAInputTextIntoElementpropCount > 0)
            {
                callPayload.Body = uIAInputTextIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAInputTextIntoMultipleElements([WorkflowExpression] Func<string> uIAInputTextIntoMultipleElementsinputElementsJSON, [WorkflowExpression] Func<string> uIAInputTextIntoMultipleElementsworkflow)
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
        public IWorkflowAction UIAInputReturnIntoElement([WorkflowExpression] Func<int> uIAInputReturnIntoElementparentWindowHandle, [WorkflowExpression] Func<string> uIAInputReturnIntoElementworkflow, [WorkflowExpression] Func<string> uIAInputReturnIntoElementsearchElementName = null, [WorkflowExpression] Func<string> uIAInputReturnIntoElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAInputReturnIntoElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAInputReturnIntoElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAInputReturnIntoElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAInputReturnIntoElementmatchIndex = null, [WorkflowExpression] Func<string> uIAInputReturnIntoElementsearchFilter = null, [WorkflowExpression] Func<string> uIAInputReturnIntoElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAInputReturnIntoElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIAInputReturnIntoElementreplaceExistingValue = null, [WorkflowExpression] Func<int> uIAInputReturnIntoElementinsertPosition = null, [WorkflowExpression] Func<int> uIAInputReturnIntoElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAInputReturnIntoElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAInputReturnIntoElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAInputReturnIntoElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIAInputReturnIntoElementraiseExceptionIfInputValidationFails = null, [WorkflowExpression] Func<bool> uIAInputReturnIntoElementtryValuePattern = null, [WorkflowExpression] Func<bool> uIAInputReturnIntoElementtryLegacyPattern = null)
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
                if (uIAInputReturnIntoElementsearchSubTree != null)
                {
                    uIAInputReturnIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementsearchSubTree);
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
                    uIAInputReturnIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementmatchIndex);
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
                if (uIAInputReturnIntoElementmatchIndexAscending != null)
                {
                    uIAInputReturnIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementmatchIndexAscending);
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
                    uIAInputReturnIntoElement["ReplaceExistingValue"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementreplaceExistingValue);
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
                uIAInputReturnIntoElement["InsertPosition"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementinsertPosition);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementmaxElementsToSearch != null)
            {
                if (uIAInputReturnIntoElementmaxElementsToSearch != null)
                {
                    uIAInputReturnIntoElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementmaxElementsToSearch);
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
                    uIAInputReturnIntoElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementmaxRelativeSearchDepth);
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
                    uIAInputReturnIntoElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementmaxChildElementsToSearchPerNode);
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
                uIAInputReturnIntoElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementelementLocalizedControlTypesNotToTraverse);
                uIAInputReturnIntoElementpropCount++;
            }

            if (uIAInputReturnIntoElementraiseExceptionIfInputValidationFails != null)
            {
                if (uIAInputReturnIntoElementraiseExceptionIfInputValidationFails != null)
                {
                    uIAInputReturnIntoElement["RaiseExceptionIfInputValidationFails"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementraiseExceptionIfInputValidationFails);
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
                    uIAInputReturnIntoElement["TryValuePattern"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementtryValuePattern);
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
                    uIAInputReturnIntoElement["TryLegacyPattern"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementtryLegacyPattern);
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
            uIAInputReturnIntoElement["Workflow"] = ExpressionConverter.ConvertO(uIAInputReturnIntoElementworkflow);
            if (uIAInputReturnIntoElementpropCount > 0)
            {
                callPayload.Body = uIAInputReturnIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAFocusElement([WorkflowExpression] Func<int> uIAFocusElementparentWindowHandle, [WorkflowExpression] Func<string> uIAFocusElementworkflow, [WorkflowExpression] Func<string> uIAFocusElementsearchElementName = null, [WorkflowExpression] Func<string> uIAFocusElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAFocusElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAFocusElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAFocusElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAFocusElementmatchIndex = null, [WorkflowExpression] Func<string> uIAFocusElementsearchFilter = null, [WorkflowExpression] Func<string> uIAFocusElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAFocusElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAFocusElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAFocusElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAFocusElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAFocusElementelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIAFocusElementsearchSubTree != null)
                {
                    uIAFocusElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAFocusElementsearchSubTree);
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
                    uIAFocusElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAFocusElementmatchIndex);
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
                if (uIAFocusElementmatchIndexAscending != null)
                {
                    uIAFocusElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAFocusElementmatchIndexAscending);
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
                    uIAFocusElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAFocusElementmaxElementsToSearch);
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
                    uIAFocusElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAFocusElementmaxRelativeSearchDepth);
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
                    uIAFocusElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAFocusElementmaxChildElementsToSearchPerNode);
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
        public IWorkflowAction UIAToggleElement([WorkflowExpression] Func<int> uIAToggleElementparentWindowHandle, [WorkflowExpression] Func<string> uIAToggleElementworkflow, [WorkflowExpression] Func<string> uIAToggleElementsearchElementName = null, [WorkflowExpression] Func<string> uIAToggleElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAToggleElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAToggleElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAToggleElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAToggleElementmatchIndex = null, [WorkflowExpression] Func<string> uIAToggleElementsearchFilter = null, [WorkflowExpression] Func<string> uIAToggleElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAToggleElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAToggleElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAToggleElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAToggleElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAToggleElementelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIAToggleElementsearchSubTree != null)
                {
                    uIAToggleElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAToggleElementsearchSubTree);
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
                    uIAToggleElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAToggleElementmatchIndex);
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
                if (uIAToggleElementmatchIndexAscending != null)
                {
                    uIAToggleElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAToggleElementmatchIndexAscending);
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
                    uIAToggleElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAToggleElementmaxElementsToSearch);
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
                    uIAToggleElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAToggleElementmaxRelativeSearchDepth);
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
                    uIAToggleElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAToggleElementmaxChildElementsToSearchPerNode);
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
        public IWorkflowAction UIACheckElement([WorkflowExpression] Func<int> uIACheckElementparentWindowHandle, [WorkflowExpression] Func<string> uIACheckElementworkflow, [WorkflowExpression] Func<string> uIACheckElementsearchElementName = null, [WorkflowExpression] Func<string> uIACheckElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIACheckElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIACheckElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIACheckElementsearchSubTree = null, [WorkflowExpression] Func<bool> uIACheckElementcheckElement = null, [WorkflowExpression] Func<int> uIACheckElementmatchIndex = null, [WorkflowExpression] Func<string> uIACheckElementsearchFilter = null, [WorkflowExpression] Func<string> uIACheckElementsortByColumn = null, [WorkflowExpression] Func<bool> uIACheckElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIACheckElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIACheckElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIACheckElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIACheckElementelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIACheckElementsearchSubTree != null)
                {
                    uIACheckElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIACheckElementsearchSubTree);
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
                    uIACheckElement["CheckElement"] = ExpressionConverter.ConvertO(uIACheckElementcheckElement);
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
                    uIACheckElement["MatchIndex"] = ExpressionConverter.ConvertO(uIACheckElementmatchIndex);
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
                if (uIACheckElementmatchIndexAscending != null)
                {
                    uIACheckElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIACheckElementmatchIndexAscending);
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
                    uIACheckElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIACheckElementmaxElementsToSearch);
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
                    uIACheckElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIACheckElementmaxRelativeSearchDepth);
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
                    uIACheckElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIACheckElementmaxChildElementsToSearchPerNode);
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
        public IWorkflowAction UIACheckMultipleElements([WorkflowExpression] Func<string> uIACheckMultipleElementsinputElementsJSON, [WorkflowExpression] Func<string> uIACheckMultipleElementsworkflow)
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
        public IBodyWorkflowAction<UIAIsElementCheckedResponse> UIAIsElementChecked([WorkflowExpression] Func<int> uIAIsElementCheckedparentWindowHandle, [WorkflowExpression] Func<string> uIAIsElementCheckedworkflow, [WorkflowExpression] Func<string> uIAIsElementCheckedsearchElementName = null, [WorkflowExpression] Func<string> uIAIsElementCheckedsearchElementClassName = null, [WorkflowExpression] Func<string> uIAIsElementCheckedsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAIsElementCheckedsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAIsElementCheckedsearchSubTree = null, [WorkflowExpression] Func<int> uIAIsElementCheckedmatchIndex = null, [WorkflowExpression] Func<string> uIAIsElementCheckedsearchFilter = null, [WorkflowExpression] Func<string> uIAIsElementCheckedsortByColumn = null, [WorkflowExpression] Func<bool> uIAIsElementCheckedmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAIsElementCheckedmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAIsElementCheckedmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAIsElementCheckedmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAIsElementCheckedelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIAIsElementCheckedsearchSubTree != null)
                {
                    uIAIsElementChecked["SearchSubTree"] = ExpressionConverter.ConvertO(uIAIsElementCheckedsearchSubTree);
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
                    uIAIsElementChecked["MatchIndex"] = ExpressionConverter.ConvertO(uIAIsElementCheckedmatchIndex);
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
                if (uIAIsElementCheckedmatchIndexAscending != null)
                {
                    uIAIsElementChecked["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAIsElementCheckedmatchIndexAscending);
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
                    uIAIsElementChecked["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAIsElementCheckedmaxElementsToSearch);
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
                    uIAIsElementChecked["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAIsElementCheckedmaxRelativeSearchDepth);
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
                    uIAIsElementChecked["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAIsElementCheckedmaxChildElementsToSearchPerNode);
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
        public IWorkflowAction UIACloseElementWindow([WorkflowExpression] Func<int> uIACloseElementWindowparentWindowHandle, [WorkflowExpression] Func<string> uIACloseElementWindowworkflow, [WorkflowExpression] Func<string> uIACloseElementWindowsearchElementName = null, [WorkflowExpression] Func<string> uIACloseElementWindowsearchElementClassName = null, [WorkflowExpression] Func<string> uIACloseElementWindowsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIACloseElementWindowsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIACloseElementWindowsearchSubTree = null, [WorkflowExpression] Func<int> uIACloseElementWindowmatchIndex = null, [WorkflowExpression] Func<string> uIACloseElementWindowsearchFilter = null, [WorkflowExpression] Func<string> uIACloseElementWindowsortByColumn = null, [WorkflowExpression] Func<bool> uIACloseElementWindowmatchIndexAscending = null, [WorkflowExpression] Func<int> uIACloseElementWindowmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIACloseElementWindowmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIACloseElementWindowmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIACloseElementWindowelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIACloseElementWindowsearchSubTree != null)
                {
                    uIACloseElementWindow["SearchSubTree"] = ExpressionConverter.ConvertO(uIACloseElementWindowsearchSubTree);
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
                    uIACloseElementWindow["MatchIndex"] = ExpressionConverter.ConvertO(uIACloseElementWindowmatchIndex);
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
                if (uIACloseElementWindowmatchIndexAscending != null)
                {
                    uIACloseElementWindow["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIACloseElementWindowmatchIndexAscending);
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
                    uIACloseElementWindow["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIACloseElementWindowmaxElementsToSearch);
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
                    uIACloseElementWindow["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIACloseElementWindowmaxRelativeSearchDepth);
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
                    uIACloseElementWindow["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIACloseElementWindowmaxChildElementsToSearchPerNode);
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
        public IBodyWorkflowAction<UIAGetElementTextValueResponse> UIAGetElementTextValue([WorkflowExpression] Func<int> uIAGetElementTextValueparentWindowHandle, [WorkflowExpression] Func<string> uIAGetElementTextValueworkflow, [WorkflowExpression] Func<string> uIAGetElementTextValuesearchElementName = null, [WorkflowExpression] Func<string> uIAGetElementTextValuesearchElementClassName = null, [WorkflowExpression] Func<string> uIAGetElementTextValuesearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGetElementTextValuesearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGetElementTextValuesearchSubTree = null, [WorkflowExpression] Func<int> uIAGetElementTextValuematchIndex = null, [WorkflowExpression] Func<string> uIAGetElementTextValuesearchFilter = null, [WorkflowExpression] Func<string> uIAGetElementTextValuesortByColumn = null, [WorkflowExpression] Func<bool> uIAGetElementTextValuematchIndexAscending = null, [WorkflowExpression] Func<int> uIAGetElementTextValuemaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGetElementTextValuemaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGetElementTextValuemaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGetElementTextValueelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIAGetElementTextValuesearchSubTree != null)
                {
                    uIAGetElementTextValue["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetElementTextValuesearchSubTree);
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
                    uIAGetElementTextValue["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetElementTextValuematchIndex);
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
                if (uIAGetElementTextValuematchIndexAscending != null)
                {
                    uIAGetElementTextValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetElementTextValuematchIndexAscending);
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
                    uIAGetElementTextValue["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetElementTextValuemaxElementsToSearch);
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
                    uIAGetElementTextValue["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetElementTextValuemaxRelativeSearchDepth);
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
                    uIAGetElementTextValue["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetElementTextValuemaxChildElementsToSearchPerNode);
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
        public IBodyWorkflowAction<UIAGetElementValueResponse> UIAGetElementValue([WorkflowExpression] Func<int> uIAGetElementValueparentWindowHandle, [WorkflowExpression] Func<string> uIAGetElementValueworkflow, [WorkflowExpression] Func<string> uIAGetElementValuesearchElementName = null, [WorkflowExpression] Func<string> uIAGetElementValuesearchElementClassName = null, [WorkflowExpression] Func<string> uIAGetElementValuesearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGetElementValuesearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGetElementValuesearchSubTree = null, [WorkflowExpression] Func<int> uIAGetElementValuematchIndex = null, [WorkflowExpression] Func<string> uIAGetElementValuesearchFilter = null, [WorkflowExpression] Func<string> uIAGetElementValuesortByColumn = null, [WorkflowExpression] Func<bool> uIAGetElementValuematchIndexAscending = null, [WorkflowExpression] Func<int> uIAGetElementValuemaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGetElementValuemaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGetElementValuemaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGetElementValueelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIAGetElementValuesearchSubTree != null)
                {
                    uIAGetElementValue["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetElementValuesearchSubTree);
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
                    uIAGetElementValue["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetElementValuematchIndex);
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
                if (uIAGetElementValuematchIndexAscending != null)
                {
                    uIAGetElementValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetElementValuematchIndexAscending);
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
                    uIAGetElementValue["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetElementValuemaxElementsToSearch);
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
                    uIAGetElementValue["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetElementValuemaxRelativeSearchDepth);
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
                    uIAGetElementValue["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetElementValuemaxChildElementsToSearchPerNode);
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
        public IBodyWorkflowAction<UIAGetElementLabelValueResponse> UIAGetElementLabelValue([WorkflowExpression] Func<int> uIAGetElementLabelValueparentWindowHandle, [WorkflowExpression] Func<string> uIAGetElementLabelValueworkflow, [WorkflowExpression] Func<string> uIAGetElementLabelValuesearchElementName = null, [WorkflowExpression] Func<string> uIAGetElementLabelValuesearchElementClassName = null, [WorkflowExpression] Func<string> uIAGetElementLabelValuesearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGetElementLabelValuesearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGetElementLabelValuesearchSubTree = null, [WorkflowExpression] Func<int> uIAGetElementLabelValuematchIndex = null, [WorkflowExpression] Func<string> uIAGetElementLabelValuesearchFilter = null, [WorkflowExpression] Func<string> uIAGetElementLabelValuesortByColumn = null, [WorkflowExpression] Func<bool> uIAGetElementLabelValuematchIndexAscending = null, [WorkflowExpression] Func<int> uIAGetElementLabelValuemaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGetElementLabelValuemaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGetElementLabelValuemaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGetElementLabelValueelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIAGetElementLabelValuesearchSubTree != null)
                {
                    uIAGetElementLabelValue["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetElementLabelValuesearchSubTree);
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
                    uIAGetElementLabelValue["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetElementLabelValuematchIndex);
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
                if (uIAGetElementLabelValuematchIndexAscending != null)
                {
                    uIAGetElementLabelValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetElementLabelValuematchIndexAscending);
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
                    uIAGetElementLabelValue["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetElementLabelValuemaxElementsToSearch);
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
                    uIAGetElementLabelValue["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetElementLabelValuemaxRelativeSearchDepth);
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
                    uIAGetElementLabelValue["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetElementLabelValuemaxChildElementsToSearchPerNode);
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
        public IBodyWorkflowAction<UIAGetElementPropertiesResponse> UIAGetElementProperties([WorkflowExpression] Func<int> uIAGetElementPropertiesparentWindowHandle, [WorkflowExpression] Func<string> uIAGetElementPropertiesworkflow, [WorkflowExpression] Func<string> uIAGetElementPropertiessearchElementName = null, [WorkflowExpression] Func<string> uIAGetElementPropertiessearchElementClassName = null, [WorkflowExpression] Func<string> uIAGetElementPropertiessearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGetElementPropertiessearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGetElementPropertiessearchSubTree = null, [WorkflowExpression] Func<bool> uIAGetElementPropertiesreturnElementHandle = null, [WorkflowExpression] Func<bool> uIAGetElementPropertiesreturnElementValue = null, [WorkflowExpression] Func<int> uIAGetElementPropertiesmatchIndex = null, [WorkflowExpression] Func<string> uIAGetElementPropertiessearchFilter = null, [WorkflowExpression] Func<string> uIAGetElementPropertiessortByColumn = null, [WorkflowExpression] Func<bool> uIAGetElementPropertiesmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAGetElementPropertiesmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGetElementPropertiesmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGetElementPropertiesmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGetElementPropertieselementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIAGetElementPropertiesvalidateClickablePointWithinElementBoundary = null)
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
                if (uIAGetElementPropertiessearchSubTree != null)
                {
                    uIAGetElementProperties["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetElementPropertiessearchSubTree);
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
                    uIAGetElementProperties["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesreturnElementHandle);
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
                    uIAGetElementProperties["ReturnElementValue"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesreturnElementValue);
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
                    uIAGetElementProperties["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesmatchIndex);
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
                if (uIAGetElementPropertiesmatchIndexAscending != null)
                {
                    uIAGetElementProperties["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesmatchIndexAscending);
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
                    uIAGetElementProperties["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesmaxElementsToSearch);
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
                    uIAGetElementProperties["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesmaxRelativeSearchDepth);
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
                    uIAGetElementProperties["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesmaxChildElementsToSearchPerNode);
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
                uIAGetElementProperties["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGetElementPropertieselementLocalizedControlTypesNotToTraverse);
                uIAGetElementPropertiespropCount++;
            }

            if (uIAGetElementPropertiesvalidateClickablePointWithinElementBoundary != null)
            {
                if (uIAGetElementPropertiesvalidateClickablePointWithinElementBoundary != null)
                {
                    uIAGetElementProperties["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesvalidateClickablePointWithinElementBoundary);
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
            uIAGetElementProperties["Workflow"] = ExpressionConverter.ConvertO(uIAGetElementPropertiesworkflow);
            if (uIAGetElementPropertiespropCount > 0)
            {
                callPayload.Body = uIAGetElementProperties;
            }

            return new ApiConnectionAction<UIAGetElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetMultipleElementPropertiesResponse> UIAGetMultipleElementProperties([WorkflowExpression] Func<int> uIAGetMultipleElementPropertiesparentWindowHandle, [WorkflowExpression] Func<string> uIAGetMultipleElementPropertiesworkflow, [WorkflowExpression] Func<string> uIAGetMultipleElementPropertiessearchElementLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGetMultipleElementPropertiessearchDescendants = null, [WorkflowExpression] Func<bool> uIAGetMultipleElementPropertiesreturnElementHandle = null, [WorkflowExpression] Func<bool> uIAGetMultipleElementPropertiesreturnElementValue = null, [WorkflowExpression] Func<int> uIAGetMultipleElementPropertiesfirstItemToReturn = null, [WorkflowExpression] Func<int> uIAGetMultipleElementPropertiesmaxItemsToReturn = null)
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
                if (uIAGetMultipleElementPropertiessearchDescendants != null)
                {
                    uIAGetMultipleElementProperties["SearchDescendants"] = ExpressionConverter.ConvertO(uIAGetMultipleElementPropertiessearchDescendants);
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
                    uIAGetMultipleElementProperties["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIAGetMultipleElementPropertiesreturnElementHandle);
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
                    uIAGetMultipleElementProperties["ReturnElementValue"] = ExpressionConverter.ConvertO(uIAGetMultipleElementPropertiesreturnElementValue);
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
                    uIAGetMultipleElementProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(uIAGetMultipleElementPropertiesfirstItemToReturn);
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
                    uIAGetMultipleElementProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(uIAGetMultipleElementPropertiesmaxItemsToReturn);
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
            uIAGetMultipleElementProperties["Workflow"] = ExpressionConverter.ConvertO(uIAGetMultipleElementPropertiesworkflow);
            if (uIAGetMultipleElementPropertiespropCount > 0)
            {
                callPayload.Body = uIAGetMultipleElementProperties;
            }

            return new ApiConnectionAction<UIAGetMultipleElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetDesktopElementsResponse> UIAGetDesktopElements([WorkflowExpression] Func<string> uIAGetDesktopElementsworkflow, [WorkflowExpression] Func<string> uIAGetDesktopElementssearchElementLocalizedControlType = null, [WorkflowExpression] Func<int> uIAGetDesktopElementssearchProcessID = null, [WorkflowExpression] Func<bool> uIAGetDesktopElementsreturnElementHandle = null, [WorkflowExpression] Func<int> uIAGetDesktopElementsfirstItemToReturn = null, [WorkflowExpression] Func<int> uIAGetDesktopElementsmaxItemsToReturn = null, [WorkflowExpression] Func<bool> uIAGetDesktopElementsincludeChildProcesses = null)
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
                if (uIAGetDesktopElementssearchProcessID != null)
                {
                    uIAGetDesktopElements["SearchProcessID"] = ExpressionConverter.ConvertO(uIAGetDesktopElementssearchProcessID);
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
                    uIAGetDesktopElements["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIAGetDesktopElementsreturnElementHandle);
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
                    uIAGetDesktopElements["FirstItemToReturn"] = ExpressionConverter.ConvertO(uIAGetDesktopElementsfirstItemToReturn);
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
                    uIAGetDesktopElements["MaxItemsToReturn"] = ExpressionConverter.ConvertO(uIAGetDesktopElementsmaxItemsToReturn);
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
                    uIAGetDesktopElements["IncludeChildProcesses"] = ExpressionConverter.ConvertO(uIAGetDesktopElementsincludeChildProcesses);
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
            uIAGetDesktopElements["Workflow"] = ExpressionConverter.ConvertO(uIAGetDesktopElementsworkflow);
            if (uIAGetDesktopElementspropCount > 0)
            {
                callPayload.Body = uIAGetDesktopElements;
            }

            return new ApiConnectionAction<UIAGetDesktopElementsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAExpandElement([WorkflowExpression] Func<int> uIAExpandElementparentWindowHandle, [WorkflowExpression] Func<string> uIAExpandElementworkflow, [WorkflowExpression] Func<string> uIAExpandElementsearchElementName = null, [WorkflowExpression] Func<string> uIAExpandElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAExpandElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAExpandElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAExpandElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAExpandElementmatchIndex = null, [WorkflowExpression] Func<string> uIAExpandElementsearchFilter = null, [WorkflowExpression] Func<string> uIAExpandElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAExpandElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAExpandElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAExpandElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAExpandElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAExpandElementelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIAExpandElementsearchSubTree != null)
                {
                    uIAExpandElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAExpandElementsearchSubTree);
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
                    uIAExpandElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAExpandElementmatchIndex);
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
                if (uIAExpandElementmatchIndexAscending != null)
                {
                    uIAExpandElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAExpandElementmatchIndexAscending);
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
                    uIAExpandElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAExpandElementmaxElementsToSearch);
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
                    uIAExpandElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAExpandElementmaxRelativeSearchDepth);
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
                    uIAExpandElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAExpandElementmaxChildElementsToSearchPerNode);
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
        public IWorkflowAction UIACollapseElement([WorkflowExpression] Func<int> uIACollapseElementparentWindowHandle, [WorkflowExpression] Func<string> uIACollapseElementworkflow, [WorkflowExpression] Func<string> uIACollapseElementsearchElementName = null, [WorkflowExpression] Func<string> uIACollapseElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIACollapseElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIACollapseElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIACollapseElementsearchSubTree = null, [WorkflowExpression] Func<int> uIACollapseElementmatchIndex = null, [WorkflowExpression] Func<string> uIACollapseElementsearchFilter = null, [WorkflowExpression] Func<string> uIACollapseElementsortByColumn = null, [WorkflowExpression] Func<bool> uIACollapseElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIACollapseElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIACollapseElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIACollapseElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIACollapseElementelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIACollapseElementsearchSubTree != null)
                {
                    uIACollapseElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIACollapseElementsearchSubTree);
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
                    uIACollapseElement["MatchIndex"] = ExpressionConverter.ConvertO(uIACollapseElementmatchIndex);
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
                if (uIACollapseElementmatchIndexAscending != null)
                {
                    uIACollapseElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIACollapseElementmatchIndexAscending);
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
                    uIACollapseElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIACollapseElementmaxElementsToSearch);
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
                    uIACollapseElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIACollapseElementmaxRelativeSearchDepth);
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
                    uIACollapseElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIACollapseElementmaxChildElementsToSearchPerNode);
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
        public IBodyWorkflowAction<UIATakeScreenShotOfElementLocationResponse> UIATakeScreenShotOfElementLocation([WorkflowExpression] Func<int> uIATakeScreenShotOfElementLocationparentWindowHandle, [WorkflowExpression] Func<string> uIATakeScreenShotOfElementLocationworkflow, [WorkflowExpression] Func<string> uIATakeScreenShotOfElementLocationsearchElementName = null, [WorkflowExpression] Func<string> uIATakeScreenShotOfElementLocationsearchElementClassName = null, [WorkflowExpression] Func<string> uIATakeScreenShotOfElementLocationsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIATakeScreenShotOfElementLocationsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIATakeScreenShotOfElementLocationsearchSubTree = null, [WorkflowExpression] Func<uIATakeScreenShotOfElementLocationimageFormatInput> uIATakeScreenShotOfElementLocationimageFormat = null, [WorkflowExpression] Func<int> uIATakeScreenShotOfElementLocationmatchIndex = null, [WorkflowExpression] Func<string> uIATakeScreenShotOfElementLocationsearchFilter = null, [WorkflowExpression] Func<string> uIATakeScreenShotOfElementLocationsortByColumn = null, [WorkflowExpression] Func<bool> uIATakeScreenShotOfElementLocationmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIATakeScreenShotOfElementLocationhideAgent = null, [WorkflowExpression] Func<int> uIATakeScreenShotOfElementLocationmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIATakeScreenShotOfElementLocationmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIATakeScreenShotOfElementLocationmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIATakeScreenShotOfElementLocationelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIATakeScreenShotOfElementLocationsearchSubTree != null)
                {
                    uIATakeScreenShotOfElementLocation["SearchSubTree"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationsearchSubTree);
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
                uIATakeScreenShotOfElementLocation["ImageFormat"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationimageFormat);
                uIATakeScreenShotOfElementLocationpropCount++;
            }

            if (uIATakeScreenShotOfElementLocationmatchIndex != null)
            {
                if (uIATakeScreenShotOfElementLocationmatchIndex != null)
                {
                    uIATakeScreenShotOfElementLocation["MatchIndex"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationmatchIndex);
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
                if (uIATakeScreenShotOfElementLocationmatchIndexAscending != null)
                {
                    uIATakeScreenShotOfElementLocation["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationmatchIndexAscending);
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
                    uIATakeScreenShotOfElementLocation["HideAgent"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationhideAgent);
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
                    uIATakeScreenShotOfElementLocation["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationmaxElementsToSearch);
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
                    uIATakeScreenShotOfElementLocation["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationmaxRelativeSearchDepth);
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
                    uIATakeScreenShotOfElementLocation["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIATakeScreenShotOfElementLocationmaxChildElementsToSearchPerNode);
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
        public IWorkflowAction UIADrawRectangleAroundElement([WorkflowExpression] Func<int> uIADrawRectangleAroundElementparentWindowHandle, [WorkflowExpression] Func<string> uIADrawRectangleAroundElementworkflow, [WorkflowExpression] Func<string> uIADrawRectangleAroundElementsearchElementName = null, [WorkflowExpression] Func<string> uIADrawRectangleAroundElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIADrawRectangleAroundElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIADrawRectangleAroundElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIADrawRectangleAroundElementsearchSubTree = null, [WorkflowExpression] Func<string> uIADrawRectangleAroundElementpenColour = null, [WorkflowExpression] Func<int> uIADrawRectangleAroundElementpenThicknessPixels = null, [WorkflowExpression] Func<int> uIADrawRectangleAroundElementmatchIndex = null, [WorkflowExpression] Func<string> uIADrawRectangleAroundElementsearchFilter = null, [WorkflowExpression] Func<string> uIADrawRectangleAroundElementsortByColumn = null, [WorkflowExpression] Func<bool> uIADrawRectangleAroundElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIADrawRectangleAroundElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIADrawRectangleAroundElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIADrawRectangleAroundElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIADrawRectangleAroundElementelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIADrawRectangleAroundElementsearchSubTree != null)
                {
                    uIADrawRectangleAroundElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementsearchSubTree);
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
                    uIADrawRectangleAroundElement["PenColour"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementpenColour);
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
                    uIADrawRectangleAroundElement["PenThicknessPixels"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementpenThicknessPixels);
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
                    uIADrawRectangleAroundElement["MatchIndex"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementmatchIndex);
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
                if (uIADrawRectangleAroundElementmatchIndexAscending != null)
                {
                    uIADrawRectangleAroundElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementmatchIndexAscending);
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
                    uIADrawRectangleAroundElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementmaxElementsToSearch);
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
                    uIADrawRectangleAroundElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementmaxRelativeSearchDepth);
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
                    uIADrawRectangleAroundElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIADrawRectangleAroundElementmaxChildElementsToSearchPerNode);
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
        public IBodyWorkflowAction<UIAGetParentElementHandleResponse> UIAGetParentElementHandle([WorkflowExpression] Func<int> uIAGetParentElementHandleelementHandle, [WorkflowExpression] Func<string> uIAGetParentElementHandleworkflow)
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
        public IBodyWorkflowAction<UIAGetDataGridElementContentsResponse> UIAGetDataGridElementContents([WorkflowExpression] Func<string> uIAGetDataGridElementContentsworkflow, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsparentWindowHandle = null, [WorkflowExpression] Func<string> uIAGetDataGridElementContentssearchElementName = null, [WorkflowExpression] Func<string> uIAGetDataGridElementContentssearchElementClassName = null, [WorkflowExpression] Func<string> uIAGetDataGridElementContentssearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGetDataGridElementContentssearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGetDataGridElementContentssearchSubTree = null, [WorkflowExpression] Func<bool> uIAGetDataGridElementContentsonScreenColumnsOnly = null, [WorkflowExpression] Func<bool> uIAGetDataGridElementContentsonScreenRowsOnly = null, [WorkflowExpression] Func<bool> uIAGetDataGridElementContentsreturnNullValuesAsBlank = null, [WorkflowExpression] Func<string> uIAGetDataGridElementContentsalternativeHeaderRowName = null, [WorkflowExpression] Func<bool> uIAGetDataGridElementContentsreturnRowUIAName = null, [WorkflowExpression] Func<string> uIAGetDataGridElementContentsnameOfColumnToStoreRowUIAName = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsmatchIndex = null, [WorkflowExpression] Func<string> uIAGetDataGridElementContentssearchFilter = null, [WorkflowExpression] Func<string> uIAGetDataGridElementContentssortByColumn = null, [WorkflowExpression] Func<bool> uIAGetDataGridElementContentsmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsfirstItemToReturn = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsmaxItemsToReturn = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsscanFirstNRowsForEmptyRows = null, [WorkflowExpression] Func<bool> uIAGetDataGridElementContentsreadTableAsThread = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentssecondsToWaitForThread = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNPercent = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNRows = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsscrollDataGridVerticallyElementHandle = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsminimumDataGridRowsForScrolling = null, [WorkflowExpression] Func<bool> uIAGetDataGridElementContentsraiseExceptionIfCannotScroll = null, [WorkflowExpression] Func<string> uIAGetDataGridElementContentsalternativeVerticalScrollbarName = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGetDataGridElementContentselementLocalizedControlTypesNotToTraverse = null)
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
                if (uIAGetDataGridElementContentssearchSubTree != null)
                {
                    uIAGetDataGridElementContents["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentssearchSubTree);
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
                    uIAGetDataGridElementContents["OnScreenColumnsOnly"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsonScreenColumnsOnly);
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
                    uIAGetDataGridElementContents["OnScreenRowsOnly"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsonScreenRowsOnly);
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
                    uIAGetDataGridElementContents["ReturnNullValuesAsBlank"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsreturnNullValuesAsBlank);
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
                uIAGetDataGridElementContents["AlternativeHeaderRowName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsalternativeHeaderRowName);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsreturnRowUIAName != null)
            {
                if (uIAGetDataGridElementContentsreturnRowUIAName != null)
                {
                    uIAGetDataGridElementContents["ReturnRowUIAName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsreturnRowUIAName);
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
                uIAGetDataGridElementContents["NameOfColumnToStoreRowUIAName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsnameOfColumnToStoreRowUIAName);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsmatchIndex != null)
            {
                if (uIAGetDataGridElementContentsmatchIndex != null)
                {
                    uIAGetDataGridElementContents["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsmatchIndex);
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
                if (uIAGetDataGridElementContentsmatchIndexAscending != null)
                {
                    uIAGetDataGridElementContents["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsmatchIndexAscending);
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
                    uIAGetDataGridElementContents["FirstItemToReturn"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsfirstItemToReturn);
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
                    uIAGetDataGridElementContents["MaxItemsToReturn"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsmaxItemsToReturn);
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
                    uIAGetDataGridElementContents["ScanFirstNRowsForEmptyRows"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsscanFirstNRowsForEmptyRows);
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
                    uIAGetDataGridElementContents["ReadTableAsThread"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsreadTableAsThread);
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
                uIAGetDataGridElementContents["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsretrieveOutputDataFromThreadId);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentssecondsToWaitForThread != null)
            {
                if (uIAGetDataGridElementContentssecondsToWaitForThread != null)
                {
                    uIAGetDataGridElementContents["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentssecondsToWaitForThread);
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
                    uIAGetDataGridElementContents["ScrollDataGridVerticallyEveryNPercent"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNPercent);
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
                    uIAGetDataGridElementContents["ScrollDataGridVerticallyEveryNRows"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNRows);
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
                    uIAGetDataGridElementContents["ScrollDataGridVerticallyElementHandle"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsscrollDataGridVerticallyElementHandle);
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
                    uIAGetDataGridElementContents["MinimumDataGridRowsForScrolling"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsminimumDataGridRowsForScrolling);
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
                    uIAGetDataGridElementContents["RaiseExceptionIfCannotScroll"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsraiseExceptionIfCannotScroll);
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
                uIAGetDataGridElementContents["AlternativeVerticalScrollbarName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsalternativeVerticalScrollbarName);
                uIAGetDataGridElementContentspropCount++;
            }

            if (uIAGetDataGridElementContentsmaxElementsToSearch != null)
            {
                if (uIAGetDataGridElementContentsmaxElementsToSearch != null)
                {
                    uIAGetDataGridElementContents["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsmaxElementsToSearch);
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
                    uIAGetDataGridElementContents["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsmaxRelativeSearchDepth);
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
                    uIAGetDataGridElementContents["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetDataGridElementContentsmaxChildElementsToSearchPerNode);
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
        public IBodyWorkflowAction<UIAGetDataGridElementPropertiesResponse> UIAGetDataGridElementProperties([WorkflowExpression] Func<int> uIAGetDataGridElementPropertiesparentWindowHandle, [WorkflowExpression] Func<string> uIAGetDataGridElementPropertiesworkflow, [WorkflowExpression] Func<string> uIAGetDataGridElementPropertiessearchElementName = null, [WorkflowExpression] Func<string> uIAGetDataGridElementPropertiessearchElementClassName = null, [WorkflowExpression] Func<string> uIAGetDataGridElementPropertiessearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGetDataGridElementPropertiessearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGetDataGridElementPropertiessearchSubTree = null, [WorkflowExpression] Func<string> uIAGetDataGridElementPropertiesalternativeHeaderRowName = null, [WorkflowExpression] Func<int> uIAGetDataGridElementPropertiesmatchIndex = null, [WorkflowExpression] Func<string> uIAGetDataGridElementPropertiessearchFilter = null, [WorkflowExpression] Func<string> uIAGetDataGridElementPropertiessortByColumn = null, [WorkflowExpression] Func<bool> uIAGetDataGridElementPropertiesmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAGetDataGridElementPropertiesmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGetDataGridElementPropertiesmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGetDataGridElementPropertiesmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGetDataGridElementPropertieselementLocalizedControlTypesNotToTraverse = null)
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
                if (uIAGetDataGridElementPropertiessearchSubTree != null)
                {
                    uIAGetDataGridElementProperties["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiessearchSubTree);
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
                uIAGetDataGridElementProperties["AlternativeHeaderRowName"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesalternativeHeaderRowName);
                uIAGetDataGridElementPropertiespropCount++;
            }

            if (uIAGetDataGridElementPropertiesmatchIndex != null)
            {
                if (uIAGetDataGridElementPropertiesmatchIndex != null)
                {
                    uIAGetDataGridElementProperties["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesmatchIndex);
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
                if (uIAGetDataGridElementPropertiesmatchIndexAscending != null)
                {
                    uIAGetDataGridElementProperties["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesmatchIndexAscending);
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
                    uIAGetDataGridElementProperties["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesmaxElementsToSearch);
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
                    uIAGetDataGridElementProperties["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesmaxRelativeSearchDepth);
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
                    uIAGetDataGridElementProperties["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetDataGridElementPropertiesmaxChildElementsToSearchPerNode);
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
        public IBodyWorkflowAction<UIAGetListElementItemsResponse> UIAGetListElementItems([WorkflowExpression] Func<int> uIAGetListElementItemsparentWindowHandle, [WorkflowExpression] Func<string> uIAGetListElementItemsworkflow, [WorkflowExpression] Func<string> uIAGetListElementItemssearchElementName = null, [WorkflowExpression] Func<string> uIAGetListElementItemssearchElementClassName = null, [WorkflowExpression] Func<string> uIAGetListElementItemssearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGetListElementItemssearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGetListElementItemssearchSubTree = null, [WorkflowExpression] Func<bool> uIAGetListElementItemsexpandFirst = null, [WorkflowExpression] Func<bool> uIAGetListElementItemscollapseAfter = null, [WorkflowExpression] Func<bool> uIAGetListElementItemscheckForSelectedItems = null, [WorkflowExpression] Func<double> uIAGetListElementItemssecondsBetweenExpandCollapse = null, [WorkflowExpression] Func<int> uIAGetListElementItemsmatchIndex = null, [WorkflowExpression] Func<string> uIAGetListElementItemssearchFilter = null, [WorkflowExpression] Func<string> uIAGetListElementItemssortByColumn = null, [WorkflowExpression] Func<bool> uIAGetListElementItemsmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAGetListElementItemsmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGetListElementItemsmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGetListElementItemsmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGetListElementItemselementLocalizedControlTypesNotToTraverse = null)
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
                if (uIAGetListElementItemssearchSubTree != null)
                {
                    uIAGetListElementItems["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetListElementItemssearchSubTree);
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
                    uIAGetListElementItems["ExpandFirst"] = ExpressionConverter.ConvertO(uIAGetListElementItemsexpandFirst);
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
                    uIAGetListElementItems["CollapseAfter"] = ExpressionConverter.ConvertO(uIAGetListElementItemscollapseAfter);
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
                    uIAGetListElementItems["CheckForSelectedItems"] = ExpressionConverter.ConvertO(uIAGetListElementItemscheckForSelectedItems);
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
                    uIAGetListElementItems["SecondsBetweenExpandCollapse"] = ExpressionConverter.ConvertO(uIAGetListElementItemssecondsBetweenExpandCollapse);
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
                    uIAGetListElementItems["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetListElementItemsmatchIndex);
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
                if (uIAGetListElementItemsmatchIndexAscending != null)
                {
                    uIAGetListElementItems["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetListElementItemsmatchIndexAscending);
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
                    uIAGetListElementItems["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetListElementItemsmaxElementsToSearch);
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
                    uIAGetListElementItems["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetListElementItemsmaxRelativeSearchDepth);
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
                    uIAGetListElementItems["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetListElementItemsmaxChildElementsToSearchPerNode);
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
        public IWorkflowAction UIAClickListElementItemByName([WorkflowExpression] Func<int> uIAClickListElementItemByNameparentWindowHandle, [WorkflowExpression] Func<string> uIAClickListElementItemByNameworkflow, [WorkflowExpression] Func<string> uIAClickListElementItemByNamesearchElementName = null, [WorkflowExpression] Func<string> uIAClickListElementItemByNamesearchElementClassName = null, [WorkflowExpression] Func<string> uIAClickListElementItemByNamesearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAClickListElementItemByNamesearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAClickListElementItemByNamesearchSubTree = null, [WorkflowExpression] Func<bool> uIAClickListElementItemByNameexpandFirst = null, [WorkflowExpression] Func<bool> uIAClickListElementItemByNamecollapseAfter = null, [WorkflowExpression] Func<string> uIAClickListElementItemByNameitemName = null, [WorkflowExpression] Func<double> uIAClickListElementItemByNamesecondsBetweenExpandCollapse = null, [WorkflowExpression] Func<int> uIAClickListElementItemByNamematchIndex = null, [WorkflowExpression] Func<string> uIAClickListElementItemByNamesearchFilter = null, [WorkflowExpression] Func<string> uIAClickListElementItemByNamesortByColumn = null, [WorkflowExpression] Func<bool> uIAClickListElementItemByNamematchIndexAscending = null, [WorkflowExpression] Func<int> uIAClickListElementItemByNamemaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAClickListElementItemByNamemaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAClickListElementItemByNamemaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAClickListElementItemByNameelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIAClickListElementItemByNamesearchSubTree != null)
                {
                    uIAClickListElementItemByName["SearchSubTree"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNamesearchSubTree);
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
                    uIAClickListElementItemByName["ExpandFirst"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNameexpandFirst);
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
                    uIAClickListElementItemByName["CollapseAfter"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNamecollapseAfter);
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
                if (uIAClickListElementItemByNamematchIndex != null)
                {
                    uIAClickListElementItemByName["MatchIndex"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNamematchIndex);
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
                if (uIAClickListElementItemByNamematchIndexAscending != null)
                {
                    uIAClickListElementItemByName["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNamematchIndexAscending);
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
                    uIAClickListElementItemByName["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNamemaxElementsToSearch);
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
                    uIAClickListElementItemByName["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNamemaxRelativeSearchDepth);
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
                    uIAClickListElementItemByName["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAClickListElementItemByNamemaxChildElementsToSearchPerNode);
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
        public IWorkflowAction UIAClickListElementItemByIndex([WorkflowExpression] Func<int> uIAClickListElementItemByIndexparentWindowHandle, [WorkflowExpression] Func<string> uIAClickListElementItemByIndexworkflow, [WorkflowExpression] Func<string> uIAClickListElementItemByIndexsearchElementName = null, [WorkflowExpression] Func<string> uIAClickListElementItemByIndexsearchElementClassName = null, [WorkflowExpression] Func<string> uIAClickListElementItemByIndexsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAClickListElementItemByIndexsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAClickListElementItemByIndexsearchSubTree = null, [WorkflowExpression] Func<bool> uIAClickListElementItemByIndexexpandFirst = null, [WorkflowExpression] Func<bool> uIAClickListElementItemByIndexcollapseAfter = null, [WorkflowExpression] Func<int> uIAClickListElementItemByIndexitemIndex = null, [WorkflowExpression] Func<double> uIAClickListElementItemByIndexsecondsBetweenExpandCollapse = null, [WorkflowExpression] Func<int> uIAClickListElementItemByIndexmatchIndex = null, [WorkflowExpression] Func<string> uIAClickListElementItemByIndexsearchFilter = null, [WorkflowExpression] Func<string> uIAClickListElementItemByIndexsortByColumn = null, [WorkflowExpression] Func<bool> uIAClickListElementItemByIndexmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAClickListElementItemByIndexmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAClickListElementItemByIndexmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAClickListElementItemByIndexmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAClickListElementItemByIndexelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIAClickListElementItemByIndexsearchSubTree != null)
                {
                    uIAClickListElementItemByIndex["SearchSubTree"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexsearchSubTree);
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
                    uIAClickListElementItemByIndex["ExpandFirst"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexexpandFirst);
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
                    uIAClickListElementItemByIndex["CollapseAfter"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexcollapseAfter);
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
                    uIAClickListElementItemByIndex["ItemIndex"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexitemIndex);
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
                uIAClickListElementItemByIndex["SecondsBetweenExpandCollapse"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexsecondsBetweenExpandCollapse);
                uIAClickListElementItemByIndexpropCount++;
            }

            if (uIAClickListElementItemByIndexmatchIndex != null)
            {
                if (uIAClickListElementItemByIndexmatchIndex != null)
                {
                    uIAClickListElementItemByIndex["MatchIndex"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexmatchIndex);
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
                if (uIAClickListElementItemByIndexmatchIndexAscending != null)
                {
                    uIAClickListElementItemByIndex["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexmatchIndexAscending);
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
                    uIAClickListElementItemByIndex["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexmaxElementsToSearch);
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
                    uIAClickListElementItemByIndex["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexmaxRelativeSearchDepth);
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
                    uIAClickListElementItemByIndex["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAClickListElementItemByIndexmaxChildElementsToSearchPerNode);
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
        public IWorkflowAction UIASetElementToNumericValue([WorkflowExpression] Func<int> uIASetElementToNumericValueparentWindowHandle, [WorkflowExpression] Func<int> uIASetElementToNumericValuenewValue, [WorkflowExpression] Func<string> uIASetElementToNumericValueworkflow, [WorkflowExpression] Func<string> uIASetElementToNumericValuesearchElementName = null, [WorkflowExpression] Func<string> uIASetElementToNumericValuesearchElementClassName = null, [WorkflowExpression] Func<string> uIASetElementToNumericValuesearchElementAutomationId = null, [WorkflowExpression] Func<string> uIASetElementToNumericValuesearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIASetElementToNumericValuesearchSubTree = null, [WorkflowExpression] Func<int> uIASetElementToNumericValuematchIndex = null, [WorkflowExpression] Func<string> uIASetElementToNumericValuesearchFilter = null, [WorkflowExpression] Func<string> uIASetElementToNumericValuesortByColumn = null, [WorkflowExpression] Func<bool> uIASetElementToNumericValuematchIndexAscending = null, [WorkflowExpression] Func<int> uIASetElementToNumericValuemaxElementsToSearch = null, [WorkflowExpression] Func<int> uIASetElementToNumericValuemaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIASetElementToNumericValuemaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIASetElementToNumericValueelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIASetElementToNumericValueraiseExceptionIfInputValidationFails = null, [WorkflowExpression] Func<bool> uIASetElementToNumericValuetryValuePattern = null, [WorkflowExpression] Func<bool> uIASetElementToNumericValuetryLegacyPattern = null)
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
                if (uIASetElementToNumericValuesearchSubTree != null)
                {
                    uIASetElementToNumericValue["SearchSubTree"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuesearchSubTree);
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
                    uIASetElementToNumericValue["MatchIndex"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuematchIndex);
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
                if (uIASetElementToNumericValuematchIndexAscending != null)
                {
                    uIASetElementToNumericValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuematchIndexAscending);
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
            uIASetElementToNumericValue["NewValue"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuenewValue);
            if (uIASetElementToNumericValuemaxElementsToSearch != null)
            {
                if (uIASetElementToNumericValuemaxElementsToSearch != null)
                {
                    uIASetElementToNumericValue["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuemaxElementsToSearch);
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
                    uIASetElementToNumericValue["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuemaxRelativeSearchDepth);
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
                    uIASetElementToNumericValue["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuemaxChildElementsToSearchPerNode);
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
                uIASetElementToNumericValue["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueelementLocalizedControlTypesNotToTraverse);
                uIASetElementToNumericValuepropCount++;
            }

            if (uIASetElementToNumericValueraiseExceptionIfInputValidationFails != null)
            {
                if (uIASetElementToNumericValueraiseExceptionIfInputValidationFails != null)
                {
                    uIASetElementToNumericValue["RaiseExceptionIfInputValidationFails"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueraiseExceptionIfInputValidationFails);
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
                    uIASetElementToNumericValue["TryValuePattern"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuetryValuePattern);
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
                    uIASetElementToNumericValue["TryLegacyPattern"] = ExpressionConverter.ConvertO(uIASetElementToNumericValuetryLegacyPattern);
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
            uIASetElementToNumericValue["Workflow"] = ExpressionConverter.ConvertO(uIASetElementToNumericValueworkflow);
            if (uIASetElementToNumericValuepropCount > 0)
            {
                callPayload.Body = uIASetElementToNumericValue;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIASetElementToNumericRangeValue([WorkflowExpression] Func<int> uIASetElementToNumericRangeValueparentWindowHandle, [WorkflowExpression] Func<double> uIASetElementToNumericRangeValuenewValue, [WorkflowExpression] Func<string> uIASetElementToNumericRangeValueworkflow, [WorkflowExpression] Func<string> uIASetElementToNumericRangeValuesearchElementName = null, [WorkflowExpression] Func<string> uIASetElementToNumericRangeValuesearchElementClassName = null, [WorkflowExpression] Func<string> uIASetElementToNumericRangeValuesearchElementAutomationId = null, [WorkflowExpression] Func<string> uIASetElementToNumericRangeValuesearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIASetElementToNumericRangeValuesearchSubTree = null, [WorkflowExpression] Func<int> uIASetElementToNumericRangeValuematchIndex = null, [WorkflowExpression] Func<string> uIASetElementToNumericRangeValuesearchFilter = null, [WorkflowExpression] Func<string> uIASetElementToNumericRangeValuesortByColumn = null, [WorkflowExpression] Func<bool> uIASetElementToNumericRangeValuematchIndexAscending = null, [WorkflowExpression] Func<bool> uIASetElementToNumericRangeValuenewValueIsPercentage = null, [WorkflowExpression] Func<int> uIASetElementToNumericRangeValuemaxElementsToSearch = null, [WorkflowExpression] Func<int> uIASetElementToNumericRangeValuemaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIASetElementToNumericRangeValuemaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIASetElementToNumericRangeValueelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIASetElementToNumericRangeValuesearchSubTree != null)
                {
                    uIASetElementToNumericRangeValue["SearchSubTree"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValuesearchSubTree);
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
                    uIASetElementToNumericRangeValue["MatchIndex"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValuematchIndex);
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
                if (uIASetElementToNumericRangeValuematchIndexAscending != null)
                {
                    uIASetElementToNumericRangeValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValuematchIndexAscending);
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
            uIASetElementToNumericRangeValue["NewValue"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValuenewValue);
            if (uIASetElementToNumericRangeValuenewValueIsPercentage != null)
            {
                if (uIASetElementToNumericRangeValuenewValueIsPercentage != null)
                {
                    uIASetElementToNumericRangeValue["NewValueIsPercentage"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValuenewValueIsPercentage);
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
                    uIASetElementToNumericRangeValue["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValuemaxElementsToSearch);
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
                    uIASetElementToNumericRangeValue["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValuemaxRelativeSearchDepth);
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
                    uIASetElementToNumericRangeValue["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIASetElementToNumericRangeValuemaxChildElementsToSearchPerNode);
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
        public IWorkflowAction UIAResetAllElementHandles([WorkflowExpression] Func<string> uIAResetAllElementHandlesworkflow)
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
        public IWorkflowAction UIAGlobalPasswordInputIntoElement([WorkflowExpression] Func<int> uIAGlobalPasswordInputIntoElementparentWindowHandle, [WorkflowExpression] Func<string> uIAGlobalPasswordInputIntoElementpasswordToInput, [WorkflowExpression] Func<string> uIAGlobalPasswordInputIntoElementworkflow, [WorkflowExpression] Func<string> uIAGlobalPasswordInputIntoElementsearchElementName = null, [WorkflowExpression] Func<string> uIAGlobalPasswordInputIntoElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAGlobalPasswordInputIntoElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGlobalPasswordInputIntoElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGlobalPasswordInputIntoElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAGlobalPasswordInputIntoElementmatchIndex = null, [WorkflowExpression] Func<string> uIAGlobalPasswordInputIntoElementsearchFilter = null, [WorkflowExpression] Func<string> uIAGlobalPasswordInputIntoElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAGlobalPasswordInputIntoElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIAGlobalPasswordInputIntoElementfocusElement = null, [WorkflowExpression] Func<bool> uIAGlobalPasswordInputIntoElementglobalMouseClickOnElement = null, [WorkflowExpression] Func<bool> uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingDoubleClickDelete = null, [WorkflowExpression] Func<bool> uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingCTRLADelete = null, [WorkflowExpression] Func<bool> uIAGlobalPasswordInputIntoElementsendKeyEvents = null, [WorkflowExpression] Func<int> uIAGlobalPasswordInputIntoElementinterval = null, [WorkflowExpression] Func<bool> uIAGlobalPasswordInputIntoElementdontInterpretSymbols = null, [WorkflowExpression] Func<bool> uIAGlobalPasswordInputIntoElementpasswordContainsStoredPassword = null, [WorkflowExpression] Func<int> uIAGlobalPasswordInputIntoElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGlobalPasswordInputIntoElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGlobalPasswordInputIntoElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGlobalPasswordInputIntoElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIAGlobalPasswordInputIntoElementvalidateClickablePointWithinElementBoundary = null)
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
                if (uIAGlobalPasswordInputIntoElementsearchSubTree != null)
                {
                    uIAGlobalPasswordInputIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementsearchSubTree);
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
                    uIAGlobalPasswordInputIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementmatchIndex);
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
                if (uIAGlobalPasswordInputIntoElementmatchIndexAscending != null)
                {
                    uIAGlobalPasswordInputIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementmatchIndexAscending);
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
                    uIAGlobalPasswordInputIntoElement["FocusElement"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementfocusElement);
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
                    uIAGlobalPasswordInputIntoElement["GlobalMouseClickOnElement"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementglobalMouseClickOnElement);
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
                    uIAGlobalPasswordInputIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingDoubleClickDelete);
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
                    uIAGlobalPasswordInputIntoElement["ReplaceExistingValueUsingCTRLADelete"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingCTRLADelete);
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
            uIAGlobalPasswordInputIntoElement["PasswordToInput"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementpasswordToInput);
            if (uIAGlobalPasswordInputIntoElementsendKeyEvents != null)
            {
                if (uIAGlobalPasswordInputIntoElementsendKeyEvents != null)
                {
                    uIAGlobalPasswordInputIntoElement["SendKeyEvents"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementsendKeyEvents);
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
                    uIAGlobalPasswordInputIntoElement["Interval"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementinterval);
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
                    uIAGlobalPasswordInputIntoElement["DontInterpretSymbols"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementdontInterpretSymbols);
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
                    uIAGlobalPasswordInputIntoElement["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementpasswordContainsStoredPassword);
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
                    uIAGlobalPasswordInputIntoElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementmaxElementsToSearch);
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
                    uIAGlobalPasswordInputIntoElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementmaxRelativeSearchDepth);
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
                    uIAGlobalPasswordInputIntoElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementmaxChildElementsToSearchPerNode);
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
                uIAGlobalPasswordInputIntoElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementelementLocalizedControlTypesNotToTraverse);
                uIAGlobalPasswordInputIntoElementpropCount++;
            }

            if (uIAGlobalPasswordInputIntoElementvalidateClickablePointWithinElementBoundary != null)
            {
                if (uIAGlobalPasswordInputIntoElementvalidateClickablePointWithinElementBoundary != null)
                {
                    uIAGlobalPasswordInputIntoElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementvalidateClickablePointWithinElementBoundary);
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
            uIAGlobalPasswordInputIntoElement["Workflow"] = ExpressionConverter.ConvertO(uIAGlobalPasswordInputIntoElementworkflow);
            if (uIAGlobalPasswordInputIntoElementpropCount > 0)
            {
                callPayload.Body = uIAGlobalPasswordInputIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalTextInputIntoElement([WorkflowExpression] Func<int> uIAGlobalTextInputIntoElementparentWindowHandle, [WorkflowExpression] Func<string> uIAGlobalTextInputIntoElementworkflow, [WorkflowExpression] Func<string> uIAGlobalTextInputIntoElementsearchElementName = null, [WorkflowExpression] Func<string> uIAGlobalTextInputIntoElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAGlobalTextInputIntoElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGlobalTextInputIntoElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGlobalTextInputIntoElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAGlobalTextInputIntoElementmatchIndex = null, [WorkflowExpression] Func<string> uIAGlobalTextInputIntoElementsearchFilter = null, [WorkflowExpression] Func<string> uIAGlobalTextInputIntoElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAGlobalTextInputIntoElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIAGlobalTextInputIntoElementfocusElement = null, [WorkflowExpression] Func<bool> uIAGlobalTextInputIntoElementglobalMouseClickOnElement = null, [WorkflowExpression] Func<bool> uIAGlobalTextInputIntoElementreplaceExistingValueUsingDoubleClickDelete = null, [WorkflowExpression] Func<bool> uIAGlobalTextInputIntoElementreplaceExistingValueUsingCTRLADelete = null, [WorkflowExpression] Func<string> uIAGlobalTextInputIntoElementtextToInput = null, [WorkflowExpression] Func<bool> uIAGlobalTextInputIntoElementsendKeyEvents = null, [WorkflowExpression] Func<int> uIAGlobalTextInputIntoElementinterval = null, [WorkflowExpression] Func<bool> uIAGlobalTextInputIntoElementdontInterpretSymbols = null, [WorkflowExpression] Func<int> uIAGlobalTextInputIntoElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGlobalTextInputIntoElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGlobalTextInputIntoElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGlobalTextInputIntoElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIAGlobalTextInputIntoElementvalidateClickablePointWithinElementBoundary = null)
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
                if (uIAGlobalTextInputIntoElementsearchSubTree != null)
                {
                    uIAGlobalTextInputIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementsearchSubTree);
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
                    uIAGlobalTextInputIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementmatchIndex);
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
                if (uIAGlobalTextInputIntoElementmatchIndexAscending != null)
                {
                    uIAGlobalTextInputIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementmatchIndexAscending);
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
                    uIAGlobalTextInputIntoElement["FocusElement"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementfocusElement);
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
                    uIAGlobalTextInputIntoElement["GlobalMouseClickOnElement"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementglobalMouseClickOnElement);
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
                    uIAGlobalTextInputIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementreplaceExistingValueUsingDoubleClickDelete);
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
                    uIAGlobalTextInputIntoElement["ReplaceExistingValueUsingCTRLADelete"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementreplaceExistingValueUsingCTRLADelete);
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
                uIAGlobalTextInputIntoElement["TextToInput"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementtextToInput);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementsendKeyEvents != null)
            {
                if (uIAGlobalTextInputIntoElementsendKeyEvents != null)
                {
                    uIAGlobalTextInputIntoElement["SendKeyEvents"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementsendKeyEvents);
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
                    uIAGlobalTextInputIntoElement["Interval"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementinterval);
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
                    uIAGlobalTextInputIntoElement["DontInterpretSymbols"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementdontInterpretSymbols);
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
                    uIAGlobalTextInputIntoElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementmaxElementsToSearch);
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
                    uIAGlobalTextInputIntoElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementmaxRelativeSearchDepth);
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
                    uIAGlobalTextInputIntoElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementmaxChildElementsToSearchPerNode);
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
                uIAGlobalTextInputIntoElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementelementLocalizedControlTypesNotToTraverse);
                uIAGlobalTextInputIntoElementpropCount++;
            }

            if (uIAGlobalTextInputIntoElementvalidateClickablePointWithinElementBoundary != null)
            {
                if (uIAGlobalTextInputIntoElementvalidateClickablePointWithinElementBoundary != null)
                {
                    uIAGlobalTextInputIntoElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementvalidateClickablePointWithinElementBoundary);
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
            uIAGlobalTextInputIntoElement["Workflow"] = ExpressionConverter.ConvertO(uIAGlobalTextInputIntoElementworkflow);
            if (uIAGlobalTextInputIntoElementpropCount > 0)
            {
                callPayload.Body = uIAGlobalTextInputIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementPropertiesAsListResponse> UIAGetElementPropertiesAsList([WorkflowExpression] Func<int> uIAGetElementPropertiesAsListelementHandle, [WorkflowExpression] Func<string> uIAGetElementPropertiesAsListworkflow)
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
        public IWorkflowAction UIASetTransactionTimeout([WorkflowExpression] Func<double> uIASetTransactionTimeouttimeoutInSeconds, [WorkflowExpression] Func<string> uIASetTransactionTimeoutworkflow)
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
        public IBodyWorkflowAction<UIAGetElementAtCoordinatesResponse> UIAGetElementAtCoordinates([WorkflowExpression] Func<string> uIAGetElementAtCoordinatesworkflow, [WorkflowExpression] Func<int> uIAGetElementAtCoordinatesxCoord = null, [WorkflowExpression] Func<int> uIAGetElementAtCoordinatesyCoord = null, [WorkflowExpression] Func<bool> uIAGetElementAtCoordinatesraiseExceptionIfElementNotFound = null)
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
                    uIAGetElementAtCoordinates["XCoord"] = ExpressionConverter.ConvertO(uIAGetElementAtCoordinatesxCoord);
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
                    uIAGetElementAtCoordinates["YCoord"] = ExpressionConverter.ConvertO(uIAGetElementAtCoordinatesyCoord);
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
                    uIAGetElementAtCoordinates["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(uIAGetElementAtCoordinatesraiseExceptionIfElementNotFound);
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
            uIAGetElementAtCoordinates["Workflow"] = ExpressionConverter.ConvertO(uIAGetElementAtCoordinatesworkflow);
            if (uIAGetElementAtCoordinatespropCount > 0)
            {
                callPayload.Body = uIAGetElementAtCoordinates;
            }

            return new ApiConnectionAction<UIAGetElementAtCoordinatesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetMultipleParentElementPropertiesResponse> UIAGetMultipleParentElementProperties([WorkflowExpression] Func<int> uIAGetMultipleParentElementPropertieselementHandle, [WorkflowExpression] Func<string> uIAGetMultipleParentElementPropertiesworkflow, [WorkflowExpression] Func<int> uIAGetMultipleParentElementPropertiesmaxParentsToProcess = null)
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
                if (uIAGetMultipleParentElementPropertiesmaxParentsToProcess != null)
                {
                    uIAGetMultipleParentElementProperties["MaxParentsToProcess"] = ExpressionConverter.ConvertO(uIAGetMultipleParentElementPropertiesmaxParentsToProcess);
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
            uIAGetMultipleParentElementProperties["Workflow"] = ExpressionConverter.ConvertO(uIAGetMultipleParentElementPropertiesworkflow);
            if (uIAGetMultipleParentElementPropertiespropCount > 0)
            {
                callPayload.Body = uIAGetMultipleParentElementProperties;
            }

            return new ApiConnectionAction<UIAGetMultipleParentElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIASearchForFirstParentElementResponse> UIASearchForFirstParentElement([WorkflowExpression] Func<int> uIASearchForFirstParentElementelementHandle, [WorkflowExpression] Func<string> uIASearchForFirstParentElementworkflow, [WorkflowExpression] Func<string> uIASearchForFirstParentElementsearchParentLocalizedControlType = null, [WorkflowExpression] Func<int> uIASearchForFirstParentElementsearchParentControlType = null, [WorkflowExpression] Func<int> uIASearchForFirstParentElementmaxParentsToProcess = null, [WorkflowExpression] Func<bool> uIASearchForFirstParentElementraiseExceptionIfParentElementNotFound = null)
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
                if (uIASearchForFirstParentElementmaxParentsToProcess != null)
                {
                    uIASearchForFirstParentElement["MaxParentsToProcess"] = ExpressionConverter.ConvertO(uIASearchForFirstParentElementmaxParentsToProcess);
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
                    uIASearchForFirstParentElement["RaiseExceptionIfParentElementNotFound"] = ExpressionConverter.ConvertO(uIASearchForFirstParentElementraiseExceptionIfParentElementNotFound);
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
            uIASearchForFirstParentElement["Workflow"] = ExpressionConverter.ConvertO(uIASearchForFirstParentElementworkflow);
            if (uIASearchForFirstParentElementpropCount > 0)
            {
                callPayload.Body = uIASearchForFirstParentElement;
            }

            return new ApiConnectionAction<UIASearchForFirstParentElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetMultipleElementsAsTableResponse> UIAGetMultipleElementsAsTable([WorkflowExpression] Func<string> uIAGetMultipleElementsAsTableworkflow, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTableparentWindowHandle = null, [WorkflowExpression] Func<string> uIAGetMultipleElementsAsTablesearchElementName = null, [WorkflowExpression] Func<string> uIAGetMultipleElementsAsTablesearchElementClassName = null, [WorkflowExpression] Func<string> uIAGetMultipleElementsAsTablesearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGetMultipleElementsAsTablesearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGetMultipleElementsAsTablesearchSubTree = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablematchIndex = null, [WorkflowExpression] Func<string> uIAGetMultipleElementsAsTablesearchFilter = null, [WorkflowExpression] Func<string> uIAGetMultipleElementsAsTablesortByColumn = null, [WorkflowExpression] Func<bool> uIAGetMultipleElementsAsTablematchIndexAscending = null, [WorkflowExpression] Func<string> uIAGetMultipleElementsAsTablesearchCellHeaderSubElementLocalizedControlType = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablesearchCellHeaderSubElementControlType = null, [WorkflowExpression] Func<string> uIAGetMultipleElementsAsTablesearchCellSubElementLocalizedControlType = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablesearchCellSubElementControlType = null, [WorkflowExpression] Func<bool> uIAGetMultipleElementsAsTablesearchDescendantsForCellSubElements = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablefirstCellHeaderSubElementToReturn = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablemaxCellHeaderSubElementsToReturn = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablefirstCellSubElementToReturn = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablemaxCellSubElementsToReturn = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablerequestedNumberOfColumns = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablecellSubElementValuePriority = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablecellSubElementTextValuePriority = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablecellSubElementNameValuePriority = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTableminimumCellSubElementWidth = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTableminimumCellSubElementHeight = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxLeft = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxRight = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxTop = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> uIAGetMultipleElementsAsTablereadTableAsThread = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTableretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablesecondsToWaitForThread = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablemaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablemaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablemaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGetMultipleElementsAsTableelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIAGetMultipleElementsAsTablesearchSubTree != null)
                {
                    uIAGetMultipleElementsAsTable["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesearchSubTree);
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
                    uIAGetMultipleElementsAsTable["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablematchIndex);
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
                if (uIAGetMultipleElementsAsTablematchIndexAscending != null)
                {
                    uIAGetMultipleElementsAsTable["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablematchIndexAscending);
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
                if (uIAGetMultipleElementsAsTablesearchDescendantsForCellSubElements != null)
                {
                    uIAGetMultipleElementsAsTable["SearchDescendantsForCellSubElements"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesearchDescendantsForCellSubElements);
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
                    uIAGetMultipleElementsAsTable["FirstCellHeaderSubElementToReturn"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablefirstCellHeaderSubElementToReturn);
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
                    uIAGetMultipleElementsAsTable["MaxCellHeaderSubElementsToReturn"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablemaxCellHeaderSubElementsToReturn);
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
                    uIAGetMultipleElementsAsTable["FirstCellSubElementToReturn"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablefirstCellSubElementToReturn);
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
                    uIAGetMultipleElementsAsTable["MaxCellSubElementsToReturn"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablemaxCellSubElementsToReturn);
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
                    uIAGetMultipleElementsAsTable["RequestedNumberOfColumns"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablerequestedNumberOfColumns);
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
                    uIAGetMultipleElementsAsTable["CellSubElementValuePriority"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablecellSubElementValuePriority);
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
                    uIAGetMultipleElementsAsTable["CellSubElementTextValuePriority"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablecellSubElementTextValuePriority);
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
                    uIAGetMultipleElementsAsTable["CellSubElementNameValuePriority"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablecellSubElementNameValuePriority);
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
                    uIAGetMultipleElementsAsTable["MinimumCellSubElementWidth"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableminimumCellSubElementWidth);
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
                    uIAGetMultipleElementsAsTable["MinimumCellSubElementHeight"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableminimumCellSubElementHeight);
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
                    uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxLeft);
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
                    uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxRight"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxRight);
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
                    uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxTop"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxTop);
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
                    uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxBottom);
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
                    uIAGetMultipleElementsAsTable["ReadTableAsThread"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablereadTableAsThread);
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
                uIAGetMultipleElementsAsTable["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTableretrieveOutputDataFromThreadId);
                uIAGetMultipleElementsAsTablepropCount++;
            }

            if (uIAGetMultipleElementsAsTablesecondsToWaitForThread != null)
            {
                if (uIAGetMultipleElementsAsTablesecondsToWaitForThread != null)
                {
                    uIAGetMultipleElementsAsTable["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablesecondsToWaitForThread);
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
                    uIAGetMultipleElementsAsTable["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablemaxElementsToSearch);
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
                    uIAGetMultipleElementsAsTable["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablemaxRelativeSearchDepth);
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
                    uIAGetMultipleElementsAsTable["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetMultipleElementsAsTablemaxChildElementsToSearchPerNode);
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
        public IBodyWorkflowAction<UIASetElementScrollPercentageResponse> UIASetElementScrollPercentage([WorkflowExpression] Func<int> uIASetElementScrollPercentageparentWindowHandle, [WorkflowExpression] Func<string> uIASetElementScrollPercentageworkflow, [WorkflowExpression] Func<string> uIASetElementScrollPercentagesearchElementName = null, [WorkflowExpression] Func<string> uIASetElementScrollPercentagesearchElementClassName = null, [WorkflowExpression] Func<string> uIASetElementScrollPercentagesearchElementAutomationId = null, [WorkflowExpression] Func<string> uIASetElementScrollPercentagesearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIASetElementScrollPercentagesearchSubTree = null, [WorkflowExpression] Func<int> uIASetElementScrollPercentagematchIndex = null, [WorkflowExpression] Func<string> uIASetElementScrollPercentagesearchFilter = null, [WorkflowExpression] Func<string> uIASetElementScrollPercentagesortByColumn = null, [WorkflowExpression] Func<bool> uIASetElementScrollPercentagematchIndexAscending = null, [WorkflowExpression] Func<double> uIASetElementScrollPercentagehorizontalScrollPercentage = null, [WorkflowExpression] Func<double> uIASetElementScrollPercentageverticalScrollPercentage = null, [WorkflowExpression] Func<bool> uIASetElementScrollPercentagetryScrollPattern = null, [WorkflowExpression] Func<bool> uIASetElementScrollPercentagetryRangeValuePattern = null, [WorkflowExpression] Func<bool> uIASetElementScrollPercentagetryValuePattern = null, [WorkflowExpression] Func<int> uIASetElementScrollPercentagemaxElementsToSearch = null, [WorkflowExpression] Func<int> uIASetElementScrollPercentagemaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIASetElementScrollPercentagemaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIASetElementScrollPercentageelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIASetElementScrollPercentagesearchSubTree != null)
                {
                    uIASetElementScrollPercentage["SearchSubTree"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagesearchSubTree);
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
                    uIASetElementScrollPercentage["MatchIndex"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagematchIndex);
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
                if (uIASetElementScrollPercentagematchIndexAscending != null)
                {
                    uIASetElementScrollPercentage["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagematchIndexAscending);
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
                    uIASetElementScrollPercentage["HorizontalScrollPercentage"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagehorizontalScrollPercentage);
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
                    uIASetElementScrollPercentage["VerticalScrollPercentage"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentageverticalScrollPercentage);
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
                    uIASetElementScrollPercentage["TryScrollPattern"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagetryScrollPattern);
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
                    uIASetElementScrollPercentage["TryRangeValuePattern"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagetryRangeValuePattern);
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
                    uIASetElementScrollPercentage["TryValuePattern"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagetryValuePattern);
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
                    uIASetElementScrollPercentage["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagemaxElementsToSearch);
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
                    uIASetElementScrollPercentage["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagemaxRelativeSearchDepth);
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
                    uIASetElementScrollPercentage["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIASetElementScrollPercentagemaxChildElementsToSearchPerNode);
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
        public IBodyWorkflowAction<UIAGetElementSearchColourRegionResponse> UIAGetElementSearchColourRegion([WorkflowExpression] Func<int> uIAGetElementSearchColourRegionparentWindowHandle, [WorkflowExpression] Func<string> uIAGetElementSearchColourRegionsearchColour, [WorkflowExpression] Func<int> uIAGetElementSearchColourRegionmaxColourDeviation, [WorkflowExpression] Func<string> uIAGetElementSearchColourRegionworkflow, [WorkflowExpression] Func<string> uIAGetElementSearchColourRegionsearchElementName = null, [WorkflowExpression] Func<string> uIAGetElementSearchColourRegionsearchElementClassName = null, [WorkflowExpression] Func<string> uIAGetElementSearchColourRegionsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGetElementSearchColourRegionsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGetElementSearchColourRegionsearchSubTree = null, [WorkflowExpression] Func<int> uIAGetElementSearchColourRegionmatchIndex = null, [WorkflowExpression] Func<string> uIAGetElementSearchColourRegionsearchFilter = null, [WorkflowExpression] Func<string> uIAGetElementSearchColourRegionsortByColumn = null, [WorkflowExpression] Func<bool> uIAGetElementSearchColourRegionmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAGetElementSearchColourRegionleftPixelXOffset = null, [WorkflowExpression] Func<int> uIAGetElementSearchColourRegionrightPixelXOffset = null, [WorkflowExpression] Func<int> uIAGetElementSearchColourRegiontopPixelYOffset = null, [WorkflowExpression] Func<int> uIAGetElementSearchColourRegionbottomPixelYOffset = null, [WorkflowExpression] Func<bool> uIAGetElementSearchColourRegionhideAgent = null, [WorkflowExpression] Func<bool> uIAGetElementSearchColourRegionreturnPhysicalCoordinates = null, [WorkflowExpression] Func<int> uIAGetElementSearchColourRegionmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGetElementSearchColourRegionmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGetElementSearchColourRegionmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGetElementSearchColourRegionelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIAGetElementSearchColourRegionsearchSubTree != null)
                {
                    uIAGetElementSearchColourRegion["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionsearchSubTree);
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
                    uIAGetElementSearchColourRegion["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionmatchIndex);
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
                if (uIAGetElementSearchColourRegionmatchIndexAscending != null)
                {
                    uIAGetElementSearchColourRegion["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionmatchIndexAscending);
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
                if (uIAGetElementSearchColourRegionhideAgent != null)
                {
                    uIAGetElementSearchColourRegion["HideAgent"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionhideAgent);
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
                    uIAGetElementSearchColourRegion["ReturnPhysicalCoordinates"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionreturnPhysicalCoordinates);
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
                    uIAGetElementSearchColourRegion["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionmaxElementsToSearch);
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
                    uIAGetElementSearchColourRegion["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionmaxRelativeSearchDepth);
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
                    uIAGetElementSearchColourRegion["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetElementSearchColourRegionmaxChildElementsToSearchPerNode);
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
        public IBodyWorkflowAction<UIAGlobalMouseClickElementSearchColourRegionResponse> UIAGlobalMouseClickElementSearchColourRegion([WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegionparentWindowHandle, [WorkflowExpression] Func<string> uIAGlobalMouseClickElementSearchColourRegionsearchColour, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegionmaxColourDeviation, [WorkflowExpression] Func<string> uIAGlobalMouseClickElementSearchColourRegionworkflow, [WorkflowExpression] Func<string> uIAGlobalMouseClickElementSearchColourRegionsearchElementName = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickElementSearchColourRegionsearchElementClassName = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickElementSearchColourRegionsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickElementSearchColourRegionsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGlobalMouseClickElementSearchColourRegionsearchSubTree = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegionmatchIndex = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickElementSearchColourRegionsearchFilter = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickElementSearchColourRegionsortByColumn = null, [WorkflowExpression] Func<bool> uIAGlobalMouseClickElementSearchColourRegionmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegionleftPixelXOffset = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegionrightPixelXOffset = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegiontopPixelYOffset = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegionbottomPixelYOffset = null, [WorkflowExpression] Func<uIAGlobalMouseClickElementSearchColourRegionmouseButtonInput> uIAGlobalMouseClickElementSearchColourRegionmouseButton = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegionclickOffsetX = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegionclickOffsetY = null, [WorkflowExpression] Func<uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeToInput> uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeTo = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegiondelayInMilliseconds = null, [WorkflowExpression] Func<bool> uIAGlobalMouseClickElementSearchColourRegionhideAgent = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegionmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegionmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegionmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickElementSearchColourRegionelementLocalizedControlTypesNotToTraverse = null)
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
                if (uIAGlobalMouseClickElementSearchColourRegionsearchSubTree != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionsearchSubTree);
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
                    uIAGlobalMouseClickElementSearchColourRegion["MatchIndex"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionmatchIndex);
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
                if (uIAGlobalMouseClickElementSearchColourRegionmatchIndexAscending != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionmatchIndexAscending);
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
                if (uIAGlobalMouseClickElementSearchColourRegionmouseButton != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["MouseButton"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionmouseButton);
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
                    uIAGlobalMouseClickElementSearchColourRegion["ClickOffsetX"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionclickOffsetX);
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
                    uIAGlobalMouseClickElementSearchColourRegion["ClickOffsetY"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionclickOffsetY);
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
                    uIAGlobalMouseClickElementSearchColourRegion["OffsetRelativeTo"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeTo);
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
                    uIAGlobalMouseClickElementSearchColourRegion["DelayInMilliseconds"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegiondelayInMilliseconds);
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
                    uIAGlobalMouseClickElementSearchColourRegion["HideAgent"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionhideAgent);
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
                    uIAGlobalMouseClickElementSearchColourRegion["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionmaxElementsToSearch);
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
                    uIAGlobalMouseClickElementSearchColourRegion["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionmaxRelativeSearchDepth);
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
                    uIAGlobalMouseClickElementSearchColourRegion["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGlobalMouseClickElementSearchColourRegionmaxChildElementsToSearchPerNode);
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
        public IBodyWorkflowAction<UIAGetWin32WindowsResponse> UIAGetWin32Windows([WorkflowExpression] Func<string> uIAGetWin32Windowsworkflow, [WorkflowExpression] Func<string> uIAGetWin32WindowssearchClassName = null, [WorkflowExpression] Func<string> uIAGetWin32WindowssearchWindowTitle = null, [WorkflowExpression] Func<bool> uIAGetWin32WindowstopLevelWindowsOnly = null, [WorkflowExpression] Func<bool> uIAGetWin32WindowsvisibleWindowsOnly = null, [WorkflowExpression] Func<bool> uIAGetWin32WindowswindowsWithTitlebarOnly = null, [WorkflowExpression] Func<bool> uIAGetWin32WindowswindowsWithTitleOnly = null, [WorkflowExpression] Func<bool> uIAGetWin32WindowsignoreTransparentWindows = null, [WorkflowExpression] Func<int> uIAGetWin32WindowssearchProcessId = null, [WorkflowExpression] Func<string> uIAGetWin32WindowssearchFilter = null, [WorkflowExpression] Func<string> uIAGetWin32WindowssortByColumn = null, [WorkflowExpression] Func<bool> uIAGetWin32WindowsmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIAGetWin32WindowsreturnElementHandle = null, [WorkflowExpression] Func<int> uIAGetWin32WindowsfirstItemToReturn = null, [WorkflowExpression] Func<int> uIAGetWin32WindowsmaxItemsToReturn = null)
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
                if (uIAGetWin32WindowstopLevelWindowsOnly != null)
                {
                    uIAGetWin32Windows["TopLevelWindowsOnly"] = ExpressionConverter.ConvertO(uIAGetWin32WindowstopLevelWindowsOnly);
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
                    uIAGetWin32Windows["VisibleWindowsOnly"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsvisibleWindowsOnly);
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
                    uIAGetWin32Windows["WindowsWithTitlebarOnly"] = ExpressionConverter.ConvertO(uIAGetWin32WindowswindowsWithTitlebarOnly);
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
                    uIAGetWin32Windows["WindowsWithTitleOnly"] = ExpressionConverter.ConvertO(uIAGetWin32WindowswindowsWithTitleOnly);
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
                    uIAGetWin32Windows["IgnoreTransparentWindows"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsignoreTransparentWindows);
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
                if (uIAGetWin32WindowsmatchIndexAscending != null)
                {
                    uIAGetWin32Windows["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsmatchIndexAscending);
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
                    uIAGetWin32Windows["ReturnElementHandle"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsreturnElementHandle);
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
                    uIAGetWin32Windows["FirstItemToReturn"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsfirstItemToReturn);
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
                    uIAGetWin32Windows["MaxItemsToReturn"] = ExpressionConverter.ConvertO(uIAGetWin32WindowsmaxItemsToReturn);
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
            uIAGetWin32Windows["Workflow"] = ExpressionConverter.ConvertO(uIAGetWin32Windowsworkflow);
            if (uIAGetWin32WindowspropCount > 0)
            {
                callPayload.Body = uIAGetWin32Windows;
            }

            return new ApiConnectionAction<UIAGetWin32WindowsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<SetUIAElementSearchModeResponse> SetUIAElementSearchMode([WorkflowExpression] Func<setUIAElementSearchModeuIAElementSearchModeInput> setUIAElementSearchModeuIAElementSearchMode, [WorkflowExpression] Func<string> setUIAElementSearchModeworkflow)
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
        public IBodyWorkflowAction<GetUIAElementSearchModeResponse> GetUIAElementSearchMode([WorkflowExpression] Func<string> getUIAElementSearchModeworkflow)
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
        public IBodyWorkflowAction<UIAGetElementPatternsResponse> UIAGetElementPatterns([WorkflowExpression] Func<int> uIAGetElementPatternsparentWindowHandle, [WorkflowExpression] Func<string> uIAGetElementPatternsworkflow, [WorkflowExpression] Func<string> uIAGetElementPatternssearchElementName = null, [WorkflowExpression] Func<string> uIAGetElementPatternssearchElementClassName = null, [WorkflowExpression] Func<string> uIAGetElementPatternssearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGetElementPatternssearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGetElementPatternssearchSubTree = null, [WorkflowExpression] Func<int> uIAGetElementPatternsmatchIndex = null, [WorkflowExpression] Func<string> uIAGetElementPatternssearchFilter = null, [WorkflowExpression] Func<string> uIAGetElementPatternssortByColumn = null, [WorkflowExpression] Func<bool> uIAGetElementPatternsmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAGetElementPatternsmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGetElementPatternsmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGetElementPatternsmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGetElementPatternselementLocalizedControlTypesNotToTraverse = null)
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
                if (uIAGetElementPatternssearchSubTree != null)
                {
                    uIAGetElementPatterns["SearchSubTree"] = ExpressionConverter.ConvertO(uIAGetElementPatternssearchSubTree);
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
                    uIAGetElementPatterns["MatchIndex"] = ExpressionConverter.ConvertO(uIAGetElementPatternsmatchIndex);
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
                if (uIAGetElementPatternsmatchIndexAscending != null)
                {
                    uIAGetElementPatterns["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAGetElementPatternsmatchIndexAscending);
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
                    uIAGetElementPatterns["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAGetElementPatternsmaxElementsToSearch);
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
                    uIAGetElementPatterns["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAGetElementPatternsmaxRelativeSearchDepth);
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
                    uIAGetElementPatterns["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAGetElementPatternsmaxChildElementsToSearchPerNode);
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
        public IBodyWorkflowAction<UIAMoveElementResponse> UIAMoveElement([WorkflowExpression] Func<int> uIAMoveElementparentWindowHandle, [WorkflowExpression] Func<int> uIAMoveElementhorizontalPosition, [WorkflowExpression] Func<int> uIAMoveElementverticalPosition, [WorkflowExpression] Func<string> uIAMoveElementworkflow, [WorkflowExpression] Func<string> uIAMoveElementsearchElementName = null, [WorkflowExpression] Func<string> uIAMoveElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAMoveElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAMoveElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAMoveElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAMoveElementmatchIndex = null, [WorkflowExpression] Func<string> uIAMoveElementsearchFilter = null, [WorkflowExpression] Func<string> uIAMoveElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAMoveElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAMoveElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAMoveElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAMoveElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAMoveElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<uIAMoveElementhorizontalMovementTypeInput> uIAMoveElementhorizontalMovementType = null, [WorkflowExpression] Func<uIAMoveElementverticalMovementTypeInput> uIAMoveElementverticalMovementType = null)
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
                if (uIAMoveElementsearchSubTree != null)
                {
                    uIAMoveElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAMoveElementsearchSubTree);
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
                    uIAMoveElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAMoveElementmatchIndex);
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
                if (uIAMoveElementmatchIndexAscending != null)
                {
                    uIAMoveElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAMoveElementmatchIndexAscending);
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
                    uIAMoveElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAMoveElementmaxElementsToSearch);
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
                    uIAMoveElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAMoveElementmaxRelativeSearchDepth);
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
                    uIAMoveElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAMoveElementmaxChildElementsToSearchPerNode);
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
                uIAMoveElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAMoveElementelementLocalizedControlTypesNotToTraverse);
                uIAMoveElementpropCount++;
            }

            if (uIAMoveElementhorizontalMovementType != null)
            {
                if (uIAMoveElementhorizontalMovementType != null)
                {
                    uIAMoveElement["HorizontalMovementType"] = ExpressionConverter.ConvertO(uIAMoveElementhorizontalMovementType);
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
            uIAMoveElement["HorizontalPosition"] = ExpressionConverter.ConvertO(uIAMoveElementhorizontalPosition);
            if (uIAMoveElementverticalMovementType != null)
            {
                if (uIAMoveElementverticalMovementType != null)
                {
                    uIAMoveElement["VerticalMovementType"] = ExpressionConverter.ConvertO(uIAMoveElementverticalMovementType);
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
        public IBodyWorkflowAction<UIAResizeElementResponse> UIAResizeElement([WorkflowExpression] Func<int> uIAResizeElementparentWindowHandle, [WorkflowExpression] Func<int> uIAResizeElementnewWidth, [WorkflowExpression] Func<int> uIAResizeElementnewHeight, [WorkflowExpression] Func<string> uIAResizeElementworkflow, [WorkflowExpression] Func<string> uIAResizeElementsearchElementName = null, [WorkflowExpression] Func<string> uIAResizeElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAResizeElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAResizeElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAResizeElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAResizeElementmatchIndex = null, [WorkflowExpression] Func<string> uIAResizeElementsearchFilter = null, [WorkflowExpression] Func<string> uIAResizeElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAResizeElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAResizeElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAResizeElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAResizeElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAResizeElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<uIAResizeElementresizeWidthTypeInput> uIAResizeElementresizeWidthType = null, [WorkflowExpression] Func<uIAResizeElementresizeHeightTypeInput> uIAResizeElementresizeHeightType = null)
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
                if (uIAResizeElementsearchSubTree != null)
                {
                    uIAResizeElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAResizeElementsearchSubTree);
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
                    uIAResizeElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAResizeElementmatchIndex);
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
                if (uIAResizeElementmatchIndexAscending != null)
                {
                    uIAResizeElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAResizeElementmatchIndexAscending);
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
                    uIAResizeElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAResizeElementmaxElementsToSearch);
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
                    uIAResizeElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAResizeElementmaxRelativeSearchDepth);
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
                    uIAResizeElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAResizeElementmaxChildElementsToSearchPerNode);
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
                uIAResizeElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(uIAResizeElementelementLocalizedControlTypesNotToTraverse);
                uIAResizeElementpropCount++;
            }

            if (uIAResizeElementresizeWidthType != null)
            {
                if (uIAResizeElementresizeWidthType != null)
                {
                    uIAResizeElement["ResizeWidthType"] = ExpressionConverter.ConvertO(uIAResizeElementresizeWidthType);
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
            uIAResizeElement["NewWidth"] = ExpressionConverter.ConvertO(uIAResizeElementnewWidth);
            if (uIAResizeElementresizeHeightType != null)
            {
                if (uIAResizeElementresizeHeightType != null)
                {
                    uIAResizeElement["ResizeHeightType"] = ExpressionConverter.ConvertO(uIAResizeElementresizeHeightType);
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
        public IBodyWorkflowAction<UIALocateVisibleSearchImageWithinElementResponse> UIALocateVisibleSearchImageWithinElement([WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementparentWindowHandle, [WorkflowExpression] Func<string> uIALocateVisibleSearchImageWithinElementworkflow, [WorkflowExpression] Func<string> uIALocateVisibleSearchImageWithinElementsearchElementName = null, [WorkflowExpression] Func<string> uIALocateVisibleSearchImageWithinElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIALocateVisibleSearchImageWithinElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIALocateVisibleSearchImageWithinElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIALocateVisibleSearchImageWithinElementsearchSubTree = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementmatchIndex = null, [WorkflowExpression] Func<string> uIALocateVisibleSearchImageWithinElementsearchFilter = null, [WorkflowExpression] Func<string> uIALocateVisibleSearchImageWithinElementsortByColumn = null, [WorkflowExpression] Func<bool> uIALocateVisibleSearchImageWithinElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIALocateVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<uIALocateVisibleSearchImageWithinElementsearchImageTypeInput> uIALocateVisibleSearchImageWithinElementsearchImageType = null, [WorkflowExpression] Func<string> uIALocateVisibleSearchImageWithinElementsearchImage = null, [WorkflowExpression] Func<uIALocateVisibleSearchImageWithinElementaltSearchImageTypeInput> uIALocateVisibleSearchImageWithinElementaltSearchImageType = null, [WorkflowExpression] Func<string> uIALocateVisibleSearchImageWithinElementaltSearchImage = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementmaxColourDeviation = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementmaxPixelDifferences = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementmaxConsecutivePixelDifferences = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementleftPixelXOffset = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementrightPixelXOffset = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementtopPixelYOffset = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementbottomPixelYOffset = null, [WorkflowExpression] Func<uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnitInput> uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnit = null, [WorkflowExpression] Func<uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnitInput> uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnit = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementsearchImageIndex = null, [WorkflowExpression] Func<uIALocateVisibleSearchImageWithinElementimageSearchDirectionInput> uIALocateVisibleSearchImageWithinElementimageSearchDirection = null, [WorkflowExpression] Func<bool> uIALocateVisibleSearchImageWithinElementhideAgent = null, [WorkflowExpression] Func<bool> uIALocateVisibleSearchImageWithinElementreturnPhysicalCoordinates = null, [WorkflowExpression] Func<bool> uIALocateVisibleSearchImageWithinElementshowHighlightRectangle = null)
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
                if (uIALocateVisibleSearchImageWithinElementsearchSubTree != null)
                {
                    uIALocateVisibleSearchImageWithinElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementsearchSubTree);
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
                    uIALocateVisibleSearchImageWithinElement["MatchIndex"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementmatchIndex);
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
                if (uIALocateVisibleSearchImageWithinElementmatchIndexAscending != null)
                {
                    uIALocateVisibleSearchImageWithinElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementmatchIndexAscending);
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
                    uIALocateVisibleSearchImageWithinElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementmaxElementsToSearch);
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
                    uIALocateVisibleSearchImageWithinElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementmaxRelativeSearchDepth);
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
                    uIALocateVisibleSearchImageWithinElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode);
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
                if (uIALocateVisibleSearchImageWithinElementaltSearchImageType != null)
                {
                    uIALocateVisibleSearchImageWithinElement["AltSearchImageType"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementaltSearchImageType);
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
                uIALocateVisibleSearchImageWithinElement["AltSearchImage"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementaltSearchImage);
                uIALocateVisibleSearchImageWithinElementpropCount++;
            }

            if (uIALocateVisibleSearchImageWithinElementmaxColourDeviation != null)
            {
                if (uIALocateVisibleSearchImageWithinElementmaxColourDeviation != null)
                {
                    uIALocateVisibleSearchImageWithinElement["MaxColourDeviation"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementmaxColourDeviation);
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
                    uIALocateVisibleSearchImageWithinElement["MaxPixelDifferences"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementmaxPixelDifferences);
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
                    uIALocateVisibleSearchImageWithinElement["MaxConsecutivePixelDifferences"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementmaxConsecutivePixelDifferences);
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
                if (uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnit != null)
                {
                    uIALocateVisibleSearchImageWithinElement["PixelXOffsetsUnit"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnit);
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
                    uIALocateVisibleSearchImageWithinElement["PixelYOffsetsUnit"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnit);
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
                    uIALocateVisibleSearchImageWithinElement["SearchImageIndex"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementsearchImageIndex);
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
                    uIALocateVisibleSearchImageWithinElement["ImageSearchDirection"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementimageSearchDirection);
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
                    uIALocateVisibleSearchImageWithinElement["HideAgent"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementhideAgent);
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
                    uIALocateVisibleSearchImageWithinElement["ReturnPhysicalCoordinates"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementreturnPhysicalCoordinates);
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
                    uIALocateVisibleSearchImageWithinElement["ShowHighlightRectangle"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementshowHighlightRectangle);
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
            uIALocateVisibleSearchImageWithinElement["Workflow"] = ExpressionConverter.ConvertO(uIALocateVisibleSearchImageWithinElementworkflow);
            if (uIALocateVisibleSearchImageWithinElementpropCount > 0)
            {
                callPayload.Body = uIALocateVisibleSearchImageWithinElement;
            }

            return new ApiConnectionAction<UIALocateVisibleSearchImageWithinElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForVisibleSearchImageWithinElementResponse> UIAWaitForVisibleSearchImageWithinElement([WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageWithinElementworkflow, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementparentWindowHandle = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageWithinElementsearchElementName = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageWithinElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageWithinElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageWithinElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageWithinElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementmatchIndex = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageWithinElementsearchFilter = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageWithinElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageWithinElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<uIAWaitForVisibleSearchImageWithinElementsearchImageTypeInput> uIAWaitForVisibleSearchImageWithinElementsearchImageType = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageWithinElementsearchImage = null, [WorkflowExpression] Func<uIAWaitForVisibleSearchImageWithinElementaltSearchImageTypeInput> uIAWaitForVisibleSearchImageWithinElementaltSearchImageType = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageWithinElementaltSearchImage = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementmaxColourDeviation = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementmaxPixelDifferences = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementmaxConsecutivePixelDifferences = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementleftPixelXOffset = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementrightPixelXOffset = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementtopPixelYOffset = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementbottomPixelYOffset = null, [WorkflowExpression] Func<uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnitInput> uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnit = null, [WorkflowExpression] Func<uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnitInput> uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnit = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementsearchImageIndex = null, [WorkflowExpression] Func<uIAWaitForVisibleSearchImageWithinElementimageSearchDirectionInput> uIAWaitForVisibleSearchImageWithinElementimageSearchDirection = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageWithinElementhideAgent = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageWithinElementreturnPhysicalCoordinates = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageWithinElementshowHighlightRectangle = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementsecondsToWait = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementmillisecondsBetweenSearches = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageWithinElementraiseExceptionIfImageNotFound = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageWithinElementwaitForThread = null)
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
                if (uIAWaitForVisibleSearchImageWithinElementsearchSubTree != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementsearchSubTree);
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
                    uIAWaitForVisibleSearchImageWithinElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementmatchIndex);
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
                if (uIAWaitForVisibleSearchImageWithinElementmatchIndexAscending != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementmatchIndexAscending);
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
                    uIAWaitForVisibleSearchImageWithinElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementmaxElementsToSearch);
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
                    uIAWaitForVisibleSearchImageWithinElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementmaxRelativeSearchDepth);
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
                    uIAWaitForVisibleSearchImageWithinElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode);
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
                if (uIAWaitForVisibleSearchImageWithinElementaltSearchImageType != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["AltSearchImageType"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementaltSearchImageType);
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
                uIAWaitForVisibleSearchImageWithinElement["AltSearchImage"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementaltSearchImage);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementmaxColourDeviation != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementmaxColourDeviation != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["MaxColourDeviation"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementmaxColourDeviation);
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
                    uIAWaitForVisibleSearchImageWithinElement["MaxPixelDifferences"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementmaxPixelDifferences);
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
                    uIAWaitForVisibleSearchImageWithinElement["MaxConsecutivePixelDifferences"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementmaxConsecutivePixelDifferences);
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
                if (uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnit != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["PixelXOffsetsUnit"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnit);
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
                    uIAWaitForVisibleSearchImageWithinElement["PixelYOffsetsUnit"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnit);
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
                    uIAWaitForVisibleSearchImageWithinElement["SearchImageIndex"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementsearchImageIndex);
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
                    uIAWaitForVisibleSearchImageWithinElement["ImageSearchDirection"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementimageSearchDirection);
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
                    uIAWaitForVisibleSearchImageWithinElement["HideAgent"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementhideAgent);
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
                    uIAWaitForVisibleSearchImageWithinElement["ReturnPhysicalCoordinates"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementreturnPhysicalCoordinates);
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
                    uIAWaitForVisibleSearchImageWithinElement["ShowHighlightRectangle"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementshowHighlightRectangle);
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
                    uIAWaitForVisibleSearchImageWithinElement["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementsecondsToWait);
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
                    uIAWaitForVisibleSearchImageWithinElement["MillisecondsBetweenSearches"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementmillisecondsBetweenSearches);
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
                    uIAWaitForVisibleSearchImageWithinElement["RaiseExceptionIfImageNotFound"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementraiseExceptionIfImageNotFound);
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
                uIAWaitForVisibleSearchImageWithinElement["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementretrieveOutputDataFromThreadId);
                uIAWaitForVisibleSearchImageWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageWithinElementwaitForThread != null)
            {
                if (uIAWaitForVisibleSearchImageWithinElementwaitForThread != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["WaitForThread"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementwaitForThread);
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
            uIAWaitForVisibleSearchImageWithinElement["Workflow"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageWithinElementworkflow);
            if (uIAWaitForVisibleSearchImageWithinElementpropCount > 0)
            {
                callPayload.Body = uIAWaitForVisibleSearchImageWithinElement;
            }

            return new ApiConnectionAction<UIAWaitForVisibleSearchImageWithinElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForVisibleSearchImageToNotExistWithinElementResponse> UIAWaitForVisibleSearchImageToNotExistWithinElement([WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageToNotExistWithinElementworkflow, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementparentWindowHandle = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementName = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndex = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchFilter = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageToNotExistWithinElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageToNotExistWithinElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageTypeInput> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageType = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImage = null, [WorkflowExpression] Func<uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageTypeInput> uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageType = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImage = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxColourDeviation = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxPixelDifferences = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxConsecutivePixelDifferences = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementleftPixelXOffset = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementrightPixelXOffset = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementtopPixelYOffset = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementbottomPixelYOffset = null, [WorkflowExpression] Func<uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnitInput> uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnit = null, [WorkflowExpression] Func<uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnitInput> uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnit = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageIndex = null, [WorkflowExpression] Func<uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirectionInput> uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirection = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageToNotExistWithinElementhideAgent = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageToNotExistWithinElementshowHighlightRectangle = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementsecondsToWait = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementmillisecondsBetweenSearches = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageToNotExistWithinElementraiseExceptionIfImageStillPresent = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageToNotExistWithinElementwaitForThread = null)
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
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchSubTree != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchSubTree"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchSubTree);
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
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MatchIndex"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndex);
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
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndexAscending != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndexAscending);
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
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxElementsToSearch);
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
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxRelativeSearchDepth);
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
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxChildElementsToSearchPerNode);
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
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageType != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["AltSearchImageType"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageType);
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
                uIAWaitForVisibleSearchImageToNotExistWithinElement["AltSearchImage"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImage);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementmaxColourDeviation != null)
            {
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementmaxColourDeviation != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxColourDeviation"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxColourDeviation);
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
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxPixelDifferences"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxPixelDifferences);
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
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxConsecutivePixelDifferences"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxConsecutivePixelDifferences);
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
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnit != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["PixelXOffsetsUnit"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnit);
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
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["PixelYOffsetsUnit"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnit);
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
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchImageIndex"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageIndex);
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
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["ImageSearchDirection"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirection);
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
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["HideAgent"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementhideAgent);
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
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["ShowHighlightRectangle"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementshowHighlightRectangle);
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
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SecondsToWait"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementsecondsToWait);
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
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MillisecondsBetweenSearches"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementmillisecondsBetweenSearches);
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
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["RaiseExceptionIfImageStillPresent"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementraiseExceptionIfImageStillPresent);
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
                uIAWaitForVisibleSearchImageToNotExistWithinElement["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementretrieveOutputDataFromThreadId);
                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
            }

            if (uIAWaitForVisibleSearchImageToNotExistWithinElementwaitForThread != null)
            {
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementwaitForThread != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["WaitForThread"] = ExpressionConverter.ConvertO(uIAWaitForVisibleSearchImageToNotExistWithinElementwaitForThread);
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