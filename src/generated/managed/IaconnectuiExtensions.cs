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
        public IBodyWorkflowAction<UIADoesTopLevelWindowExistResponse> UIADoesTopLevelWindowExist([WorkflowExpression] Func<string> uIADoesTopLevelWindowExistworkflow, [WorkflowExpression] Func<string> uIADoesTopLevelWindowExistsearchClassName = null, [WorkflowExpression] Func<string> uIADoesTopLevelWindowExistsearchWindowTitle = null, [WorkflowExpression] Func<int> uIADoesTopLevelWindowExistsearchProcessId = null, [WorkflowExpression] Func<int> uIADoesTopLevelWindowExistmatchIndex = null, [WorkflowExpression] Func<string> uIADoesTopLevelWindowExistsearchFilter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/DoesTopLevelWindowExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIADoesTopLevelWindowExist = new JObject();
                var uIADoesTopLevelWindowExistpropCount = 0;
                if (uIADoesTopLevelWindowExistsearchClassName != null)
                {
                    uIADoesTopLevelWindowExist["SearchClassName"] = SourceExpressionConverter.ConvertToken(uIADoesTopLevelWindowExistsearchClassName);
                    uIADoesTopLevelWindowExistpropCount++;
                }

                if (uIADoesTopLevelWindowExistsearchWindowTitle != null)
                {
                    uIADoesTopLevelWindowExist["SearchWindowTitle"] = SourceExpressionConverter.ConvertToken(uIADoesTopLevelWindowExistsearchWindowTitle);
                    uIADoesTopLevelWindowExistpropCount++;
                }

                if (uIADoesTopLevelWindowExistsearchProcessId != null)
                {
                    uIADoesTopLevelWindowExist["SearchProcessId"] = SourceExpressionConverter.ConvertToken(uIADoesTopLevelWindowExistsearchProcessId);
                    uIADoesTopLevelWindowExistpropCount++;
                }

                if (uIADoesTopLevelWindowExistmatchIndex != null)
                {
                    if (uIADoesTopLevelWindowExistmatchIndex != null)
                    {
                        uIADoesTopLevelWindowExist["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIADoesTopLevelWindowExistmatchIndex);
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
                    uIADoesTopLevelWindowExist["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIADoesTopLevelWindowExistsearchFilter);
                    uIADoesTopLevelWindowExistpropCount++;
                }

                uIADoesTopLevelWindowExistpropCount++;
                uIADoesTopLevelWindowExist["Workflow"] = SourceExpressionConverter.ConvertToken(uIADoesTopLevelWindowExistworkflow);
                if (uIADoesTopLevelWindowExistpropCount > 0)
                {
                    callPayload.Body = uIADoesTopLevelWindowExist;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIADoesTopLevelWindowExistResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForTopLevelWindowResponse> UIAGetHandleForTopLevelWindow([WorkflowExpression] Func<string> uIAGetHandleForTopLevelWindowworkflow, [WorkflowExpression] Func<string> uIAGetHandleForTopLevelWindowsearchClassName = null, [WorkflowExpression] Func<string> uIAGetHandleForTopLevelWindowsearchWindowTitle = null, [WorkflowExpression] Func<int> uIAGetHandleForTopLevelWindowsearchProcessId = null, [WorkflowExpression] Func<int> uIAGetHandleForTopLevelWindowmatchIndex = null, [WorkflowExpression] Func<string> uIAGetHandleForTopLevelWindowsearchFilter = null, [WorkflowExpression] Func<string> uIAGetHandleForTopLevelWindowsortByColumn = null, [WorkflowExpression] Func<bool> uIAGetHandleForTopLevelWindowmatchIndexAscending = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/GetHandleForTopLevelWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetHandleForTopLevelWindow = new JObject();
                var uIAGetHandleForTopLevelWindowpropCount = 0;
                if (uIAGetHandleForTopLevelWindowsearchClassName != null)
                {
                    uIAGetHandleForTopLevelWindow["SearchClassName"] = SourceExpressionConverter.ConvertToken(uIAGetHandleForTopLevelWindowsearchClassName);
                    uIAGetHandleForTopLevelWindowpropCount++;
                }

                if (uIAGetHandleForTopLevelWindowsearchWindowTitle != null)
                {
                    uIAGetHandleForTopLevelWindow["SearchWindowTitle"] = SourceExpressionConverter.ConvertToken(uIAGetHandleForTopLevelWindowsearchWindowTitle);
                    uIAGetHandleForTopLevelWindowpropCount++;
                }

                if (uIAGetHandleForTopLevelWindowsearchProcessId != null)
                {
                    uIAGetHandleForTopLevelWindow["SearchProcessId"] = SourceExpressionConverter.ConvertToken(uIAGetHandleForTopLevelWindowsearchProcessId);
                    uIAGetHandleForTopLevelWindowpropCount++;
                }

                if (uIAGetHandleForTopLevelWindowmatchIndex != null)
                {
                    if (uIAGetHandleForTopLevelWindowmatchIndex != null)
                    {
                        uIAGetHandleForTopLevelWindow["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAGetHandleForTopLevelWindowmatchIndex);
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
                    uIAGetHandleForTopLevelWindow["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAGetHandleForTopLevelWindowsearchFilter);
                    uIAGetHandleForTopLevelWindowpropCount++;
                }

                if (uIAGetHandleForTopLevelWindowsortByColumn != null)
                {
                    uIAGetHandleForTopLevelWindow["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAGetHandleForTopLevelWindowsortByColumn);
                    uIAGetHandleForTopLevelWindowpropCount++;
                }

                if (uIAGetHandleForTopLevelWindowmatchIndexAscending != null)
                {
                    if (uIAGetHandleForTopLevelWindowmatchIndexAscending != null)
                    {
                        uIAGetHandleForTopLevelWindow["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAGetHandleForTopLevelWindowmatchIndexAscending);
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
                uIAGetHandleForTopLevelWindow["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetHandleForTopLevelWindowworkflow);
                if (uIAGetHandleForTopLevelWindowpropCount > 0)
                {
                    callPayload.Body = uIAGetHandleForTopLevelWindow;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetHandleForTopLevelWindowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForTopLevelWindowResponse> UIAWaitForTopLevelWindow([WorkflowExpression] Func<int> uIAWaitForTopLevelWindowsecondsToWait, [WorkflowExpression] Func<string> uIAWaitForTopLevelWindowworkflow, [WorkflowExpression] Func<string> uIAWaitForTopLevelWindowsearchClassName = null, [WorkflowExpression] Func<string> uIAWaitForTopLevelWindowsearchWindowTitle = null, [WorkflowExpression] Func<int> uIAWaitForTopLevelWindowsearchProcessId = null, [WorkflowExpression] Func<int> uIAWaitForTopLevelWindowmatchIndex = null, [WorkflowExpression] Func<string> uIAWaitForTopLevelWindowsearchFilter = null, [WorkflowExpression] Func<string> uIAWaitForTopLevelWindowsortByColumn = null, [WorkflowExpression] Func<bool> uIAWaitForTopLevelWindowmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIAWaitForTopLevelWindowraiseExceptionIfWindowNotFound = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/WaitForTopLevelWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAWaitForTopLevelWindow = new JObject();
                var uIAWaitForTopLevelWindowpropCount = 0;
                if (uIAWaitForTopLevelWindowsearchClassName != null)
                {
                    uIAWaitForTopLevelWindow["SearchClassName"] = SourceExpressionConverter.ConvertToken(uIAWaitForTopLevelWindowsearchClassName);
                    uIAWaitForTopLevelWindowpropCount++;
                }

                if (uIAWaitForTopLevelWindowsearchWindowTitle != null)
                {
                    uIAWaitForTopLevelWindow["SearchWindowTitle"] = SourceExpressionConverter.ConvertToken(uIAWaitForTopLevelWindowsearchWindowTitle);
                    uIAWaitForTopLevelWindowpropCount++;
                }

                uIAWaitForTopLevelWindowpropCount++;
                uIAWaitForTopLevelWindow["SecondsToWait"] = SourceExpressionConverter.ConvertToken(uIAWaitForTopLevelWindowsecondsToWait);
                if (uIAWaitForTopLevelWindowsearchProcessId != null)
                {
                    uIAWaitForTopLevelWindow["SearchProcessId"] = SourceExpressionConverter.ConvertToken(uIAWaitForTopLevelWindowsearchProcessId);
                    uIAWaitForTopLevelWindowpropCount++;
                }

                if (uIAWaitForTopLevelWindowmatchIndex != null)
                {
                    if (uIAWaitForTopLevelWindowmatchIndex != null)
                    {
                        uIAWaitForTopLevelWindow["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAWaitForTopLevelWindowmatchIndex);
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
                    uIAWaitForTopLevelWindow["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAWaitForTopLevelWindowsearchFilter);
                    uIAWaitForTopLevelWindowpropCount++;
                }

                if (uIAWaitForTopLevelWindowsortByColumn != null)
                {
                    uIAWaitForTopLevelWindow["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAWaitForTopLevelWindowsortByColumn);
                    uIAWaitForTopLevelWindowpropCount++;
                }

                if (uIAWaitForTopLevelWindowmatchIndexAscending != null)
                {
                    if (uIAWaitForTopLevelWindowmatchIndexAscending != null)
                    {
                        uIAWaitForTopLevelWindow["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAWaitForTopLevelWindowmatchIndexAscending);
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
                        uIAWaitForTopLevelWindow["RaiseExceptionIfWindowNotFound"] = SourceExpressionConverter.ConvertToken(uIAWaitForTopLevelWindowraiseExceptionIfWindowNotFound);
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
                uIAWaitForTopLevelWindow["Workflow"] = SourceExpressionConverter.ConvertToken(uIAWaitForTopLevelWindowworkflow);
                if (uIAWaitForTopLevelWindowpropCount > 0)
                {
                    callPayload.Body = uIAWaitForTopLevelWindow;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAWaitForTopLevelWindowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIADoesProcessHaveWindowResponse> UIADoesProcessHaveWindow([WorkflowExpression] Func<string> uIADoesProcessHaveWindowsearchProcessName, [WorkflowExpression] Func<string> uIADoesProcessHaveWindowworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/DoesProcessHaveWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIADoesProcessHaveWindow = new JObject();
                var uIADoesProcessHaveWindowpropCount = 0;
                uIADoesProcessHaveWindowpropCount++;
                uIADoesProcessHaveWindow["SearchProcessName"] = SourceExpressionConverter.ConvertToken(uIADoesProcessHaveWindowsearchProcessName);
                uIADoesProcessHaveWindowpropCount++;
                uIADoesProcessHaveWindow["Workflow"] = SourceExpressionConverter.ConvertToken(uIADoesProcessHaveWindowworkflow);
                if (uIADoesProcessHaveWindowpropCount > 0)
                {
                    callPayload.Body = uIADoesProcessHaveWindow;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIADoesProcessHaveWindowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForProcessMainWindowResponse> UIAGetHandleForProcessMainWindow([WorkflowExpression] Func<string> uIAGetHandleForProcessMainWindowsearchProcessName, [WorkflowExpression] Func<string> uIAGetHandleForProcessMainWindowworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/GetHandleForProcessMainWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetHandleForProcessMainWindow = new JObject();
                var uIAGetHandleForProcessMainWindowpropCount = 0;
                uIAGetHandleForProcessMainWindowpropCount++;
                uIAGetHandleForProcessMainWindow["SearchProcessName"] = SourceExpressionConverter.ConvertToken(uIAGetHandleForProcessMainWindowsearchProcessName);
                uIAGetHandleForProcessMainWindowpropCount++;
                uIAGetHandleForProcessMainWindow["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetHandleForProcessMainWindowworkflow);
                if (uIAGetHandleForProcessMainWindowpropCount > 0)
                {
                    callPayload.Body = uIAGetHandleForProcessMainWindow;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetHandleForProcessMainWindowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForProcessMainWindowResponse> UIAWaitForProcessMainWindow([WorkflowExpression] Func<string> uIAWaitForProcessMainWindowsearchProcessName, [WorkflowExpression] Func<int> uIAWaitForProcessMainWindowsecondsToWait, [WorkflowExpression] Func<string> uIAWaitForProcessMainWindowworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/WaitForProcessMainWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAWaitForProcessMainWindow = new JObject();
                var uIAWaitForProcessMainWindowpropCount = 0;
                uIAWaitForProcessMainWindowpropCount++;
                uIAWaitForProcessMainWindow["SearchProcessName"] = SourceExpressionConverter.ConvertToken(uIAWaitForProcessMainWindowsearchProcessName);
                uIAWaitForProcessMainWindowpropCount++;
                uIAWaitForProcessMainWindow["SecondsToWait"] = SourceExpressionConverter.ConvertToken(uIAWaitForProcessMainWindowsecondsToWait);
                uIAWaitForProcessMainWindowpropCount++;
                uIAWaitForProcessMainWindow["Workflow"] = SourceExpressionConverter.ConvertToken(uIAWaitForProcessMainWindowworkflow);
                if (uIAWaitForProcessMainWindowpropCount > 0)
                {
                    callPayload.Body = uIAWaitForProcessMainWindow;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAWaitForProcessMainWindowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForProcessIdMainWindowResponse> UIAGetHandleForProcessIdMainWindow([WorkflowExpression] Func<int> uIAGetHandleForProcessIdMainWindowprocessId, [WorkflowExpression] Func<string> uIAGetHandleForProcessIdMainWindowworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/GetHandleForProcessIdMainWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetHandleForProcessIdMainWindow = new JObject();
                var uIAGetHandleForProcessIdMainWindowpropCount = 0;
                uIAGetHandleForProcessIdMainWindowpropCount++;
                uIAGetHandleForProcessIdMainWindow["ProcessId"] = SourceExpressionConverter.ConvertToken(uIAGetHandleForProcessIdMainWindowprocessId);
                uIAGetHandleForProcessIdMainWindowpropCount++;
                uIAGetHandleForProcessIdMainWindow["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetHandleForProcessIdMainWindowworkflow);
                if (uIAGetHandleForProcessIdMainWindowpropCount > 0)
                {
                    callPayload.Body = uIAGetHandleForProcessIdMainWindow;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetHandleForProcessIdMainWindowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForProcessIdMainWindowResponse> UIAWaitForProcessIdMainWindow([WorkflowExpression] Func<int> uIAWaitForProcessIdMainWindowprocessId, [WorkflowExpression] Func<int> uIAWaitForProcessIdMainWindowsecondsToWait, [WorkflowExpression] Func<string> uIAWaitForProcessIdMainWindowworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/WaitForProcessIdMainWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAWaitForProcessIdMainWindow = new JObject();
                var uIAWaitForProcessIdMainWindowpropCount = 0;
                uIAWaitForProcessIdMainWindowpropCount++;
                uIAWaitForProcessIdMainWindow["ProcessId"] = SourceExpressionConverter.ConvertToken(uIAWaitForProcessIdMainWindowprocessId);
                uIAWaitForProcessIdMainWindowpropCount++;
                uIAWaitForProcessIdMainWindow["SecondsToWait"] = SourceExpressionConverter.ConvertToken(uIAWaitForProcessIdMainWindowsecondsToWait);
                uIAWaitForProcessIdMainWindowpropCount++;
                uIAWaitForProcessIdMainWindow["Workflow"] = SourceExpressionConverter.ConvertToken(uIAWaitForProcessIdMainWindowworkflow);
                if (uIAWaitForProcessIdMainWindowpropCount > 0)
                {
                    callPayload.Body = uIAWaitForProcessIdMainWindow;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAWaitForProcessIdMainWindowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForFocussedElementResponse> UIAGetHandleForFocussedElement([WorkflowExpression] Func<string> uIAGetHandleForFocussedElementworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/GetHandleForFocussedElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetHandleForFocussedElement = new JObject();
                var uIAGetHandleForFocussedElementpropCount = 0;
                uIAGetHandleForFocussedElementpropCount++;
                uIAGetHandleForFocussedElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetHandleForFocussedElementworkflow);
                if (uIAGetHandleForFocussedElementpropCount > 0)
                {
                    callPayload.Body = uIAGetHandleForFocussedElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetHandleForFocussedElementResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForMainWindowOfFocussedElementResponse> UIAGetHandleForMainWindowOfFocussedElement([WorkflowExpression] Func<string> uIAGetHandleForMainWindowOfFocussedElementworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/GetHandleForMainWindowOfFocussedElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetHandleForMainWindowOfFocussedElement = new JObject();
                var uIAGetHandleForMainWindowOfFocussedElementpropCount = 0;
                uIAGetHandleForMainWindowOfFocussedElementpropCount++;
                uIAGetHandleForMainWindowOfFocussedElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetHandleForMainWindowOfFocussedElementworkflow);
                if (uIAGetHandleForMainWindowOfFocussedElementpropCount > 0)
                {
                    callPayload.Body = uIAGetHandleForMainWindowOfFocussedElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetHandleForMainWindowOfFocussedElementResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForDesktopResponse> UIAGetHandleForDesktop([WorkflowExpression] Func<string> uIAGetHandleForDesktopworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/GetHandleForDesktop";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetHandleForDesktop = new JObject();
                var uIAGetHandleForDesktoppropCount = 0;
                uIAGetHandleForDesktoppropCount++;
                uIAGetHandleForDesktop["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetHandleForDesktopworkflow);
                if (uIAGetHandleForDesktoppropCount > 0)
                {
                    callPayload.Body = uIAGetHandleForDesktop;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetHandleForDesktopResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIASetForegroundWindow([WorkflowExpression] Func<int> uIASetForegroundWindowwindowHandle, [WorkflowExpression] Func<string> uIASetForegroundWindowworkflow, [WorkflowExpression] Func<bool> uIASetForegroundWindowtoggleWindow = null, [WorkflowExpression] Func<bool> uIASetForegroundWindowtoggleUsesGlobalLeftMouseClickAgent = null, [WorkflowExpression] Func<double> uIASetForegroundWindowtoggleDelay = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/SetForegroundWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIASetForegroundWindow = new JObject();
                var uIASetForegroundWindowpropCount = 0;
                uIASetForegroundWindowpropCount++;
                uIASetForegroundWindow["WindowHandle"] = SourceExpressionConverter.ConvertToken(uIASetForegroundWindowwindowHandle);
                if (uIASetForegroundWindowtoggleWindow != null)
                {
                    if (uIASetForegroundWindowtoggleWindow != null)
                    {
                        uIASetForegroundWindow["ToggleWindow"] = SourceExpressionConverter.ConvertToken(uIASetForegroundWindowtoggleWindow);
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
                        uIASetForegroundWindow["ToggleUsesGlobalLeftMouseClickAgent"] = SourceExpressionConverter.ConvertToken(uIASetForegroundWindowtoggleUsesGlobalLeftMouseClickAgent);
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
                        uIASetForegroundWindow["ToggleDelay"] = SourceExpressionConverter.ConvertToken(uIASetForegroundWindowtoggleDelay);
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
                uIASetForegroundWindow["Workflow"] = SourceExpressionConverter.ConvertToken(uIASetForegroundWindowworkflow);
                if (uIASetForegroundWindowpropCount > 0)
                {
                    callPayload.Body = uIASetForegroundWindow;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAMaximiseWindow([WorkflowExpression] Func<int> uIAMaximiseWindowwindowHandle, [WorkflowExpression] Func<string> uIAMaximiseWindowworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/MaximiseWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAMaximiseWindow = new JObject();
                var uIAMaximiseWindowpropCount = 0;
                uIAMaximiseWindowpropCount++;
                uIAMaximiseWindow["WindowHandle"] = SourceExpressionConverter.ConvertToken(uIAMaximiseWindowwindowHandle);
                uIAMaximiseWindowpropCount++;
                uIAMaximiseWindow["Workflow"] = SourceExpressionConverter.ConvertToken(uIAMaximiseWindowworkflow);
                if (uIAMaximiseWindowpropCount > 0)
                {
                    callPayload.Body = uIAMaximiseWindow;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAMinimiseWindow([WorkflowExpression] Func<int> uIAMinimiseWindowwindowHandle, [WorkflowExpression] Func<string> uIAMinimiseWindowworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/MinimiseWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAMinimiseWindow = new JObject();
                var uIAMinimiseWindowpropCount = 0;
                uIAMinimiseWindowpropCount++;
                uIAMinimiseWindow["WindowHandle"] = SourceExpressionConverter.ConvertToken(uIAMinimiseWindowwindowHandle);
                uIAMinimiseWindowpropCount++;
                uIAMinimiseWindow["Workflow"] = SourceExpressionConverter.ConvertToken(uIAMinimiseWindowworkflow);
                if (uIAMinimiseWindowpropCount > 0)
                {
                    callPayload.Body = uIAMinimiseWindow;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIASetWindowToNormal([WorkflowExpression] Func<int> uIASetWindowToNormalwindowHandle, [WorkflowExpression] Func<string> uIASetWindowToNormalworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/SetWindowToNormal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIASetWindowToNormal = new JObject();
                var uIASetWindowToNormalpropCount = 0;
                uIASetWindowToNormalpropCount++;
                uIASetWindowToNormal["WindowHandle"] = SourceExpressionConverter.ConvertToken(uIASetWindowToNormalwindowHandle);
                uIASetWindowToNormalpropCount++;
                uIASetWindowToNormal["Workflow"] = SourceExpressionConverter.ConvertToken(uIASetWindowToNormalworkflow);
                if (uIASetWindowToNormalpropCount > 0)
                {
                    callPayload.Body = uIASetWindowToNormal;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIADoesElementExistResponse> UIADoesElementExist([WorkflowExpression] Func<int> uIADoesElementExistparentWindowHandle, [WorkflowExpression] Func<string> uIADoesElementExistworkflow, [WorkflowExpression] Func<string> uIADoesElementExistsearchElementName = null, [WorkflowExpression] Func<string> uIADoesElementExistsearchElementClassName = null, [WorkflowExpression] Func<string> uIADoesElementExistsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIADoesElementExistsearchLocalizedControlType = null, [WorkflowExpression] Func<int> uIADoesElementExistsearchProcessId = null, [WorkflowExpression] Func<bool> uIADoesElementExistsearchSubTree = null, [WorkflowExpression] Func<bool> uIADoesElementExistreturnElementHandle = null, [WorkflowExpression] Func<int> uIADoesElementExistmatchIndex = null, [WorkflowExpression] Func<string> uIADoesElementExistsearchFilter = null, [WorkflowExpression] Func<string> uIADoesElementExistsortByColumn = null, [WorkflowExpression] Func<bool> uIADoesElementExistmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIADoesElementExistincludeChildProcesses = null, [WorkflowExpression] Func<int> uIADoesElementExistmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIADoesElementExistmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIADoesElementExistmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIADoesElementExistelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/DoesElementExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIADoesElementExist = new JObject();
                var uIADoesElementExistpropCount = 0;
                uIADoesElementExistpropCount++;
                uIADoesElementExist["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIADoesElementExistparentWindowHandle);
                if (uIADoesElementExistsearchElementName != null)
                {
                    uIADoesElementExist["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIADoesElementExistsearchElementName);
                    uIADoesElementExistpropCount++;
                }

                if (uIADoesElementExistsearchElementClassName != null)
                {
                    uIADoesElementExist["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIADoesElementExistsearchElementClassName);
                    uIADoesElementExistpropCount++;
                }

                if (uIADoesElementExistsearchElementAutomationId != null)
                {
                    uIADoesElementExist["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIADoesElementExistsearchElementAutomationId);
                    uIADoesElementExistpropCount++;
                }

                if (uIADoesElementExistsearchLocalizedControlType != null)
                {
                    uIADoesElementExist["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIADoesElementExistsearchLocalizedControlType);
                    uIADoesElementExistpropCount++;
                }

                if (uIADoesElementExistsearchProcessId != null)
                {
                    uIADoesElementExist["SearchProcessId"] = SourceExpressionConverter.ConvertToken(uIADoesElementExistsearchProcessId);
                    uIADoesElementExistpropCount++;
                }

                if (uIADoesElementExistsearchSubTree != null)
                {
                    if (uIADoesElementExistsearchSubTree != null)
                    {
                        uIADoesElementExist["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIADoesElementExistsearchSubTree);
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
                        uIADoesElementExist["ReturnElementHandle"] = SourceExpressionConverter.ConvertToken(uIADoesElementExistreturnElementHandle);
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
                        uIADoesElementExist["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIADoesElementExistmatchIndex);
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
                    uIADoesElementExist["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIADoesElementExistsearchFilter);
                    uIADoesElementExistpropCount++;
                }

                if (uIADoesElementExistsortByColumn != null)
                {
                    uIADoesElementExist["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIADoesElementExistsortByColumn);
                    uIADoesElementExistpropCount++;
                }

                if (uIADoesElementExistmatchIndexAscending != null)
                {
                    if (uIADoesElementExistmatchIndexAscending != null)
                    {
                        uIADoesElementExist["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIADoesElementExistmatchIndexAscending);
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
                        uIADoesElementExist["IncludeChildProcesses"] = SourceExpressionConverter.ConvertToken(uIADoesElementExistincludeChildProcesses);
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
                        uIADoesElementExist["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIADoesElementExistmaxElementsToSearch);
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
                        uIADoesElementExist["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIADoesElementExistmaxRelativeSearchDepth);
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
                        uIADoesElementExist["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIADoesElementExistmaxChildElementsToSearchPerNode);
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
                    uIADoesElementExist["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIADoesElementExistelementLocalizedControlTypesNotToTraverse);
                    uIADoesElementExistpropCount++;
                }

                uIADoesElementExistpropCount++;
                uIADoesElementExist["Workflow"] = SourceExpressionConverter.ConvertToken(uIADoesElementExistworkflow);
                if (uIADoesElementExistpropCount > 0)
                {
                    callPayload.Body = uIADoesElementExist;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIADoesElementExistResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIADoesDesktopElementExistResponse> UIADoesDesktopElementExist([WorkflowExpression] Func<string> uIADoesDesktopElementExistworkflow, [WorkflowExpression] Func<string> uIADoesDesktopElementExistsearchElementName = null, [WorkflowExpression] Func<string> uIADoesDesktopElementExistsearchElementClassName = null, [WorkflowExpression] Func<string> uIADoesDesktopElementExistsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIADoesDesktopElementExistsearchLocalizedControlType = null, [WorkflowExpression] Func<int> uIADoesDesktopElementExistsearchProcessId = null, [WorkflowExpression] Func<bool> uIADoesDesktopElementExistsearchSubTree = null, [WorkflowExpression] Func<bool> uIADoesDesktopElementExistreturnElementHandle = null, [WorkflowExpression] Func<int> uIADoesDesktopElementExistmatchIndex = null, [WorkflowExpression] Func<string> uIADoesDesktopElementExistsearchFilter = null, [WorkflowExpression] Func<string> uIADoesDesktopElementExistsortByColumn = null, [WorkflowExpression] Func<bool> uIADoesDesktopElementExistmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIADoesDesktopElementExistincludeChildProcesses = null, [WorkflowExpression] Func<int> uIADoesDesktopElementExistmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIADoesDesktopElementExistmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIADoesDesktopElementExistmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIADoesDesktopElementExistelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/DoesDesktopElementExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIADoesDesktopElementExist = new JObject();
                var uIADoesDesktopElementExistpropCount = 0;
                if (uIADoesDesktopElementExistsearchElementName != null)
                {
                    uIADoesDesktopElementExist["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIADoesDesktopElementExistsearchElementName);
                    uIADoesDesktopElementExistpropCount++;
                }

                if (uIADoesDesktopElementExistsearchElementClassName != null)
                {
                    uIADoesDesktopElementExist["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIADoesDesktopElementExistsearchElementClassName);
                    uIADoesDesktopElementExistpropCount++;
                }

                if (uIADoesDesktopElementExistsearchElementAutomationId != null)
                {
                    uIADoesDesktopElementExist["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIADoesDesktopElementExistsearchElementAutomationId);
                    uIADoesDesktopElementExistpropCount++;
                }

                if (uIADoesDesktopElementExistsearchLocalizedControlType != null)
                {
                    uIADoesDesktopElementExist["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIADoesDesktopElementExistsearchLocalizedControlType);
                    uIADoesDesktopElementExistpropCount++;
                }

                if (uIADoesDesktopElementExistsearchProcessId != null)
                {
                    uIADoesDesktopElementExist["SearchProcessId"] = SourceExpressionConverter.ConvertToken(uIADoesDesktopElementExistsearchProcessId);
                    uIADoesDesktopElementExistpropCount++;
                }

                if (uIADoesDesktopElementExistsearchSubTree != null)
                {
                    if (uIADoesDesktopElementExistsearchSubTree != null)
                    {
                        uIADoesDesktopElementExist["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIADoesDesktopElementExistsearchSubTree);
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
                        uIADoesDesktopElementExist["ReturnElementHandle"] = SourceExpressionConverter.ConvertToken(uIADoesDesktopElementExistreturnElementHandle);
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
                        uIADoesDesktopElementExist["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIADoesDesktopElementExistmatchIndex);
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
                    uIADoesDesktopElementExist["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIADoesDesktopElementExistsearchFilter);
                    uIADoesDesktopElementExistpropCount++;
                }

                if (uIADoesDesktopElementExistsortByColumn != null)
                {
                    uIADoesDesktopElementExist["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIADoesDesktopElementExistsortByColumn);
                    uIADoesDesktopElementExistpropCount++;
                }

                if (uIADoesDesktopElementExistmatchIndexAscending != null)
                {
                    if (uIADoesDesktopElementExistmatchIndexAscending != null)
                    {
                        uIADoesDesktopElementExist["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIADoesDesktopElementExistmatchIndexAscending);
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
                        uIADoesDesktopElementExist["IncludeChildProcesses"] = SourceExpressionConverter.ConvertToken(uIADoesDesktopElementExistincludeChildProcesses);
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
                        uIADoesDesktopElementExist["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIADoesDesktopElementExistmaxElementsToSearch);
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
                        uIADoesDesktopElementExist["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIADoesDesktopElementExistmaxRelativeSearchDepth);
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
                        uIADoesDesktopElementExist["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIADoesDesktopElementExistmaxChildElementsToSearchPerNode);
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
                    uIADoesDesktopElementExist["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIADoesDesktopElementExistelementLocalizedControlTypesNotToTraverse);
                    uIADoesDesktopElementExistpropCount++;
                }

                uIADoesDesktopElementExistpropCount++;
                uIADoesDesktopElementExist["Workflow"] = SourceExpressionConverter.ConvertToken(uIADoesDesktopElementExistworkflow);
                if (uIADoesDesktopElementExistpropCount > 0)
                {
                    callPayload.Body = uIADoesDesktopElementExist;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIADoesDesktopElementExistResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForElementResponse> UIAWaitForElement([WorkflowExpression] Func<int> uIAWaitForElementparentWindowHandle, [WorkflowExpression] Func<int> uIAWaitForElementsecondsToWait, [WorkflowExpression] Func<string> uIAWaitForElementworkflow, [WorkflowExpression] Func<string> uIAWaitForElementsearchElementName = null, [WorkflowExpression] Func<string> uIAWaitForElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAWaitForElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAWaitForElementsearchLocalizedControlType = null, [WorkflowExpression] Func<int> uIAWaitForElementsearchProcessId = null, [WorkflowExpression] Func<bool> uIAWaitForElementsearchSubTree = null, [WorkflowExpression] Func<bool> uIAWaitForElementreturnElementHandle = null, [WorkflowExpression] Func<int> uIAWaitForElementmatchIndex = null, [WorkflowExpression] Func<string> uIAWaitForElementsearchFilter = null, [WorkflowExpression] Func<string> uIAWaitForElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAWaitForElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIAWaitForElementincludeChildProcesses = null, [WorkflowExpression] Func<bool> uIAWaitForElementraiseExceptionIfElementNotFound = null, [WorkflowExpression] Func<int> uIAWaitForElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAWaitForElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAWaitForElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAWaitForElementelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/WaitForElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAWaitForElement = new JObject();
                var uIAWaitForElementpropCount = 0;
                uIAWaitForElementpropCount++;
                uIAWaitForElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementparentWindowHandle);
                if (uIAWaitForElementsearchElementName != null)
                {
                    uIAWaitForElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementsearchElementName);
                    uIAWaitForElementpropCount++;
                }

                if (uIAWaitForElementsearchElementClassName != null)
                {
                    uIAWaitForElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementsearchElementClassName);
                    uIAWaitForElementpropCount++;
                }

                if (uIAWaitForElementsearchElementAutomationId != null)
                {
                    uIAWaitForElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementsearchElementAutomationId);
                    uIAWaitForElementpropCount++;
                }

                if (uIAWaitForElementsearchLocalizedControlType != null)
                {
                    uIAWaitForElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementsearchLocalizedControlType);
                    uIAWaitForElementpropCount++;
                }

                if (uIAWaitForElementsearchProcessId != null)
                {
                    uIAWaitForElement["SearchProcessId"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementsearchProcessId);
                    uIAWaitForElementpropCount++;
                }

                if (uIAWaitForElementsearchSubTree != null)
                {
                    if (uIAWaitForElementsearchSubTree != null)
                    {
                        uIAWaitForElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementsearchSubTree);
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
                        uIAWaitForElement["ReturnElementHandle"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementreturnElementHandle);
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
                uIAWaitForElement["SecondsToWait"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementsecondsToWait);
                if (uIAWaitForElementmatchIndex != null)
                {
                    if (uIAWaitForElementmatchIndex != null)
                    {
                        uIAWaitForElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementmatchIndex);
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
                    uIAWaitForElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementsearchFilter);
                    uIAWaitForElementpropCount++;
                }

                if (uIAWaitForElementsortByColumn != null)
                {
                    uIAWaitForElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementsortByColumn);
                    uIAWaitForElementpropCount++;
                }

                if (uIAWaitForElementmatchIndexAscending != null)
                {
                    if (uIAWaitForElementmatchIndexAscending != null)
                    {
                        uIAWaitForElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementmatchIndexAscending);
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
                        uIAWaitForElement["IncludeChildProcesses"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementincludeChildProcesses);
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
                        uIAWaitForElement["RaiseExceptionIfElementNotFound"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementraiseExceptionIfElementNotFound);
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
                        uIAWaitForElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementmaxElementsToSearch);
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
                        uIAWaitForElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementmaxRelativeSearchDepth);
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
                        uIAWaitForElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementmaxChildElementsToSearchPerNode);
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
                    uIAWaitForElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementelementLocalizedControlTypesNotToTraverse);
                    uIAWaitForElementpropCount++;
                }

                uIAWaitForElementpropCount++;
                uIAWaitForElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementworkflow);
                if (uIAWaitForElementpropCount > 0)
                {
                    callPayload.Body = uIAWaitForElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAWaitForElementResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForDesktopElementResponse> UIAWaitForDesktopElement([WorkflowExpression] Func<int> uIAWaitForDesktopElementsecondsToWait, [WorkflowExpression] Func<string> uIAWaitForDesktopElementworkflow, [WorkflowExpression] Func<string> uIAWaitForDesktopElementsearchElementName = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementsearchLocalizedControlType = null, [WorkflowExpression] Func<int> uIAWaitForDesktopElementsearchProcessId = null, [WorkflowExpression] Func<bool> uIAWaitForDesktopElementsearchSubTree = null, [WorkflowExpression] Func<bool> uIAWaitForDesktopElementreturnElementHandle = null, [WorkflowExpression] Func<int> uIAWaitForDesktopElementmatchIndex = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementsearchFilter = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAWaitForDesktopElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIAWaitForDesktopElementincludeChildProcesses = null, [WorkflowExpression] Func<bool> uIAWaitForDesktopElementraiseExceptionIfElementNotFound = null, [WorkflowExpression] Func<int> uIAWaitForDesktopElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAWaitForDesktopElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAWaitForDesktopElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/WaitForDesktopElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAWaitForDesktopElement = new JObject();
                var uIAWaitForDesktopElementpropCount = 0;
                if (uIAWaitForDesktopElementsearchElementName != null)
                {
                    uIAWaitForDesktopElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementsearchElementName);
                    uIAWaitForDesktopElementpropCount++;
                }

                if (uIAWaitForDesktopElementsearchElementClassName != null)
                {
                    uIAWaitForDesktopElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementsearchElementClassName);
                    uIAWaitForDesktopElementpropCount++;
                }

                if (uIAWaitForDesktopElementsearchElementAutomationId != null)
                {
                    uIAWaitForDesktopElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementsearchElementAutomationId);
                    uIAWaitForDesktopElementpropCount++;
                }

                if (uIAWaitForDesktopElementsearchLocalizedControlType != null)
                {
                    uIAWaitForDesktopElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementsearchLocalizedControlType);
                    uIAWaitForDesktopElementpropCount++;
                }

                if (uIAWaitForDesktopElementsearchProcessId != null)
                {
                    if (uIAWaitForDesktopElementsearchProcessId != null)
                    {
                        uIAWaitForDesktopElement["SearchProcessId"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementsearchProcessId);
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
                        uIAWaitForDesktopElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementsearchSubTree);
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
                        uIAWaitForDesktopElement["ReturnElementHandle"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementreturnElementHandle);
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
                uIAWaitForDesktopElement["SecondsToWait"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementsecondsToWait);
                if (uIAWaitForDesktopElementmatchIndex != null)
                {
                    if (uIAWaitForDesktopElementmatchIndex != null)
                    {
                        uIAWaitForDesktopElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementmatchIndex);
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
                    uIAWaitForDesktopElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementsearchFilter);
                    uIAWaitForDesktopElementpropCount++;
                }

                if (uIAWaitForDesktopElementsortByColumn != null)
                {
                    uIAWaitForDesktopElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementsortByColumn);
                    uIAWaitForDesktopElementpropCount++;
                }

                if (uIAWaitForDesktopElementmatchIndexAscending != null)
                {
                    if (uIAWaitForDesktopElementmatchIndexAscending != null)
                    {
                        uIAWaitForDesktopElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementmatchIndexAscending);
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
                        uIAWaitForDesktopElement["IncludeChildProcesses"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementincludeChildProcesses);
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
                        uIAWaitForDesktopElement["RaiseExceptionIfElementNotFound"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementraiseExceptionIfElementNotFound);
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
                        uIAWaitForDesktopElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementmaxElementsToSearch);
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
                        uIAWaitForDesktopElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementmaxRelativeSearchDepth);
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
                        uIAWaitForDesktopElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementmaxChildElementsToSearchPerNode);
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
                    uIAWaitForDesktopElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementelementLocalizedControlTypesNotToTraverse);
                    uIAWaitForDesktopElementpropCount++;
                }

                uIAWaitForDesktopElementpropCount++;
                uIAWaitForDesktopElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementworkflow);
                if (uIAWaitForDesktopElementpropCount > 0)
                {
                    callPayload.Body = uIAWaitForDesktopElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAWaitForDesktopElementResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForElementToNotExistResponse> UIAWaitForElementToNotExist([WorkflowExpression] Func<int> uIAWaitForElementToNotExistparentWindowHandle, [WorkflowExpression] Func<int> uIAWaitForElementToNotExistsecondsToWait, [WorkflowExpression] Func<string> uIAWaitForElementToNotExistworkflow, [WorkflowExpression] Func<string> uIAWaitForElementToNotExistsearchElementName = null, [WorkflowExpression] Func<string> uIAWaitForElementToNotExistsearchElementClassName = null, [WorkflowExpression] Func<string> uIAWaitForElementToNotExistsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAWaitForElementToNotExistsearchLocalizedControlType = null, [WorkflowExpression] Func<int> uIAWaitForElementToNotExistsearchProcessId = null, [WorkflowExpression] Func<bool> uIAWaitForElementToNotExistsearchSubTree = null, [WorkflowExpression] Func<int> uIAWaitForElementToNotExistmatchIndex = null, [WorkflowExpression] Func<string> uIAWaitForElementToNotExistsearchFilter = null, [WorkflowExpression] Func<string> uIAWaitForElementToNotExistsortByColumn = null, [WorkflowExpression] Func<bool> uIAWaitForElementToNotExistmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIAWaitForElementToNotExistincludeChildProcesses = null, [WorkflowExpression] Func<bool> uIAWaitForElementToNotExistraiseExceptionIfElementStillExists = null, [WorkflowExpression] Func<int> uIAWaitForElementToNotExistmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAWaitForElementToNotExistmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAWaitForElementToNotExistmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAWaitForElementToNotExistelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIAWaitForElementToNotExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAWaitForElementToNotExist = new JObject();
                var uIAWaitForElementToNotExistpropCount = 0;
                uIAWaitForElementToNotExistpropCount++;
                uIAWaitForElementToNotExist["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementToNotExistparentWindowHandle);
                if (uIAWaitForElementToNotExistsearchElementName != null)
                {
                    uIAWaitForElementToNotExist["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementToNotExistsearchElementName);
                    uIAWaitForElementToNotExistpropCount++;
                }

                if (uIAWaitForElementToNotExistsearchElementClassName != null)
                {
                    uIAWaitForElementToNotExist["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementToNotExistsearchElementClassName);
                    uIAWaitForElementToNotExistpropCount++;
                }

                if (uIAWaitForElementToNotExistsearchElementAutomationId != null)
                {
                    uIAWaitForElementToNotExist["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementToNotExistsearchElementAutomationId);
                    uIAWaitForElementToNotExistpropCount++;
                }

                if (uIAWaitForElementToNotExistsearchLocalizedControlType != null)
                {
                    uIAWaitForElementToNotExist["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementToNotExistsearchLocalizedControlType);
                    uIAWaitForElementToNotExistpropCount++;
                }

                if (uIAWaitForElementToNotExistsearchProcessId != null)
                {
                    uIAWaitForElementToNotExist["SearchProcessId"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementToNotExistsearchProcessId);
                    uIAWaitForElementToNotExistpropCount++;
                }

                if (uIAWaitForElementToNotExistsearchSubTree != null)
                {
                    if (uIAWaitForElementToNotExistsearchSubTree != null)
                    {
                        uIAWaitForElementToNotExist["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementToNotExistsearchSubTree);
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
                uIAWaitForElementToNotExist["SecondsToWait"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementToNotExistsecondsToWait);
                if (uIAWaitForElementToNotExistmatchIndex != null)
                {
                    if (uIAWaitForElementToNotExistmatchIndex != null)
                    {
                        uIAWaitForElementToNotExist["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementToNotExistmatchIndex);
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
                    uIAWaitForElementToNotExist["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementToNotExistsearchFilter);
                    uIAWaitForElementToNotExistpropCount++;
                }

                if (uIAWaitForElementToNotExistsortByColumn != null)
                {
                    uIAWaitForElementToNotExist["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementToNotExistsortByColumn);
                    uIAWaitForElementToNotExistpropCount++;
                }

                if (uIAWaitForElementToNotExistmatchIndexAscending != null)
                {
                    if (uIAWaitForElementToNotExistmatchIndexAscending != null)
                    {
                        uIAWaitForElementToNotExist["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementToNotExistmatchIndexAscending);
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
                        uIAWaitForElementToNotExist["IncludeChildProcesses"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementToNotExistincludeChildProcesses);
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
                        uIAWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementToNotExistraiseExceptionIfElementStillExists);
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
                        uIAWaitForElementToNotExist["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementToNotExistmaxElementsToSearch);
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
                        uIAWaitForElementToNotExist["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementToNotExistmaxRelativeSearchDepth);
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
                        uIAWaitForElementToNotExist["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementToNotExistmaxChildElementsToSearchPerNode);
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
                    uIAWaitForElementToNotExist["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementToNotExistelementLocalizedControlTypesNotToTraverse);
                    uIAWaitForElementToNotExistpropCount++;
                }

                uIAWaitForElementToNotExistpropCount++;
                uIAWaitForElementToNotExist["Workflow"] = SourceExpressionConverter.ConvertToken(uIAWaitForElementToNotExistworkflow);
                if (uIAWaitForElementToNotExistpropCount > 0)
                {
                    callPayload.Body = uIAWaitForElementToNotExist;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAWaitForElementToNotExistResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForDesktopElementToNotExistResponse> UIAWaitForDesktopElementToNotExist([WorkflowExpression] Func<int> uIAWaitForDesktopElementToNotExistsecondsToWait, [WorkflowExpression] Func<string> uIAWaitForDesktopElementToNotExistworkflow, [WorkflowExpression] Func<string> uIAWaitForDesktopElementToNotExistsearchElementName = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementToNotExistsearchElementClassName = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementToNotExistsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementToNotExistsearchLocalizedControlType = null, [WorkflowExpression] Func<int> uIAWaitForDesktopElementToNotExistsearchProcessId = null, [WorkflowExpression] Func<bool> uIAWaitForDesktopElementToNotExistsearchSubTree = null, [WorkflowExpression] Func<int> uIAWaitForDesktopElementToNotExistmatchIndex = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementToNotExistsearchFilter = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementToNotExistsortByColumn = null, [WorkflowExpression] Func<bool> uIAWaitForDesktopElementToNotExistmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIAWaitForDesktopElementToNotExistincludeChildProcesses = null, [WorkflowExpression] Func<bool> uIAWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists = null, [WorkflowExpression] Func<int> uIAWaitForDesktopElementToNotExistmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAWaitForDesktopElementToNotExistmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAWaitForDesktopElementToNotExistmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAWaitForDesktopElementToNotExistelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIAWaitForDesktopElementToNotExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAWaitForDesktopElementToNotExist = new JObject();
                var uIAWaitForDesktopElementToNotExistpropCount = 0;
                if (uIAWaitForDesktopElementToNotExistsearchElementName != null)
                {
                    uIAWaitForDesktopElementToNotExist["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistsearchElementName);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                if (uIAWaitForDesktopElementToNotExistsearchElementClassName != null)
                {
                    uIAWaitForDesktopElementToNotExist["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistsearchElementClassName);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                if (uIAWaitForDesktopElementToNotExistsearchElementAutomationId != null)
                {
                    uIAWaitForDesktopElementToNotExist["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistsearchElementAutomationId);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                if (uIAWaitForDesktopElementToNotExistsearchLocalizedControlType != null)
                {
                    uIAWaitForDesktopElementToNotExist["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistsearchLocalizedControlType);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                if (uIAWaitForDesktopElementToNotExistsearchProcessId != null)
                {
                    uIAWaitForDesktopElementToNotExist["SearchProcessId"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistsearchProcessId);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                if (uIAWaitForDesktopElementToNotExistsearchSubTree != null)
                {
                    if (uIAWaitForDesktopElementToNotExistsearchSubTree != null)
                    {
                        uIAWaitForDesktopElementToNotExist["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistsearchSubTree);
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
                uIAWaitForDesktopElementToNotExist["SecondsToWait"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistsecondsToWait);
                if (uIAWaitForDesktopElementToNotExistmatchIndex != null)
                {
                    if (uIAWaitForDesktopElementToNotExistmatchIndex != null)
                    {
                        uIAWaitForDesktopElementToNotExist["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistmatchIndex);
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
                    uIAWaitForDesktopElementToNotExist["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistsearchFilter);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                if (uIAWaitForDesktopElementToNotExistsortByColumn != null)
                {
                    uIAWaitForDesktopElementToNotExist["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistsortByColumn);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                if (uIAWaitForDesktopElementToNotExistmatchIndexAscending != null)
                {
                    if (uIAWaitForDesktopElementToNotExistmatchIndexAscending != null)
                    {
                        uIAWaitForDesktopElementToNotExist["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistmatchIndexAscending);
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
                        uIAWaitForDesktopElementToNotExist["IncludeChildProcesses"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistincludeChildProcesses);
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
                        uIAWaitForDesktopElementToNotExist["RaiseExceptionIfElementStillExists"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists);
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
                        uIAWaitForDesktopElementToNotExist["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistmaxElementsToSearch);
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
                        uIAWaitForDesktopElementToNotExist["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistmaxRelativeSearchDepth);
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
                        uIAWaitForDesktopElementToNotExist["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistmaxChildElementsToSearchPerNode);
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
                    uIAWaitForDesktopElementToNotExist["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistelementLocalizedControlTypesNotToTraverse);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                uIAWaitForDesktopElementToNotExistpropCount++;
                uIAWaitForDesktopElementToNotExist["Workflow"] = SourceExpressionConverter.ConvertToken(uIAWaitForDesktopElementToNotExistworkflow);
                if (uIAWaitForDesktopElementToNotExistpropCount > 0)
                {
                    callPayload.Body = uIAWaitForDesktopElementToNotExist;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAWaitForDesktopElementToNotExistResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAPressElement([WorkflowExpression] Func<int> uIAPressElementparentWindowHandle, [WorkflowExpression] Func<string> uIAPressElementworkflow, [WorkflowExpression] Func<string> uIAPressElementsearchElementName = null, [WorkflowExpression] Func<string> uIAPressElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAPressElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAPressElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAPressElementsearchSubTree = null, [WorkflowExpression] Func<bool> uIAPressElementwait = null, [WorkflowExpression] Func<bool> uIAPressElementwin32ClickButton = null, [WorkflowExpression] Func<int> uIAPressElementmatchIndex = null, [WorkflowExpression] Func<string> uIAPressElementsearchFilter = null, [WorkflowExpression] Func<string> uIAPressElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAPressElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAPressElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAPressElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAPressElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAPressElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIAPressElementtryInvokePattern = null, [WorkflowExpression] Func<bool> uIAPressElementtryLegacyPattern = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/PressElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAPressElement = new JObject();
                var uIAPressElementpropCount = 0;
                uIAPressElementpropCount++;
                uIAPressElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAPressElementparentWindowHandle);
                if (uIAPressElementsearchElementName != null)
                {
                    uIAPressElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAPressElementsearchElementName);
                    uIAPressElementpropCount++;
                }

                if (uIAPressElementsearchElementClassName != null)
                {
                    uIAPressElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAPressElementsearchElementClassName);
                    uIAPressElementpropCount++;
                }

                if (uIAPressElementsearchElementAutomationId != null)
                {
                    uIAPressElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAPressElementsearchElementAutomationId);
                    uIAPressElementpropCount++;
                }

                if (uIAPressElementsearchLocalizedControlType != null)
                {
                    uIAPressElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAPressElementsearchLocalizedControlType);
                    uIAPressElementpropCount++;
                }

                if (uIAPressElementsearchSubTree != null)
                {
                    if (uIAPressElementsearchSubTree != null)
                    {
                        uIAPressElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAPressElementsearchSubTree);
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
                        uIAPressElement["Wait"] = SourceExpressionConverter.ConvertToken(uIAPressElementwait);
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
                        uIAPressElement["Win32ClickButton"] = SourceExpressionConverter.ConvertToken(uIAPressElementwin32ClickButton);
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
                        uIAPressElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAPressElementmatchIndex);
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
                    uIAPressElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAPressElementsearchFilter);
                    uIAPressElementpropCount++;
                }

                if (uIAPressElementsortByColumn != null)
                {
                    uIAPressElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAPressElementsortByColumn);
                    uIAPressElementpropCount++;
                }

                if (uIAPressElementmatchIndexAscending != null)
                {
                    if (uIAPressElementmatchIndexAscending != null)
                    {
                        uIAPressElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAPressElementmatchIndexAscending);
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
                        uIAPressElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAPressElementmaxElementsToSearch);
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
                        uIAPressElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAPressElementmaxRelativeSearchDepth);
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
                        uIAPressElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAPressElementmaxChildElementsToSearchPerNode);
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
                    uIAPressElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAPressElementelementLocalizedControlTypesNotToTraverse);
                    uIAPressElementpropCount++;
                }

                if (uIAPressElementtryInvokePattern != null)
                {
                    if (uIAPressElementtryInvokePattern != null)
                    {
                        uIAPressElement["TryInvokePattern"] = SourceExpressionConverter.ConvertToken(uIAPressElementtryInvokePattern);
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
                        uIAPressElement["TryLegacyPattern"] = SourceExpressionConverter.ConvertToken(uIAPressElementtryLegacyPattern);
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
                uIAPressElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIAPressElementworkflow);
                if (uIAPressElementpropCount > 0)
                {
                    callPayload.Body = uIAPressElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalMouseClickOnElement([WorkflowExpression] Func<int> uIAGlobalMouseClickOnElementparentWindowHandle, [WorkflowExpression] Func<string> uIAGlobalMouseClickOnElementworkflow, [WorkflowExpression] Func<string> uIAGlobalMouseClickOnElementsearchElementName = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickOnElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickOnElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGlobalMouseClickOnElementsearchSubTree = null, [WorkflowExpression] Func<bool> uIAGlobalMouseClickOnElementfocusElementFirst = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickOnElementmatchIndex = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickOnElementsearchFilter = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickOnElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAGlobalMouseClickOnElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickOnElementclickOffsetX = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickOnElementclickOffsetY = null, [WorkflowExpression] Func<uIAGlobalMouseClickOnElementoffsetRelativeToInput> uIAGlobalMouseClickOnElementoffsetRelativeTo = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickOnElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickOnElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickOnElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickOnElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIAGlobalMouseClickOnElementvalidateClickablePointWithinElementBoundary = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/GlobalMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGlobalMouseClickOnElement = new JObject();
                var uIAGlobalMouseClickOnElementpropCount = 0;
                uIAGlobalMouseClickOnElementpropCount++;
                uIAGlobalMouseClickOnElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementparentWindowHandle);
                if (uIAGlobalMouseClickOnElementsearchElementName != null)
                {
                    uIAGlobalMouseClickOnElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementsearchElementName);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (uIAGlobalMouseClickOnElementsearchElementClassName != null)
                {
                    uIAGlobalMouseClickOnElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementsearchElementClassName);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (uIAGlobalMouseClickOnElementsearchElementAutomationId != null)
                {
                    uIAGlobalMouseClickOnElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementsearchElementAutomationId);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (uIAGlobalMouseClickOnElementsearchLocalizedControlType != null)
                {
                    uIAGlobalMouseClickOnElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementsearchLocalizedControlType);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (uIAGlobalMouseClickOnElementsearchSubTree != null)
                {
                    if (uIAGlobalMouseClickOnElementsearchSubTree != null)
                    {
                        uIAGlobalMouseClickOnElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementsearchSubTree);
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
                        uIAGlobalMouseClickOnElement["FocusElementFirst"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementfocusElementFirst);
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
                        uIAGlobalMouseClickOnElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementmatchIndex);
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
                    uIAGlobalMouseClickOnElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementsearchFilter);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (uIAGlobalMouseClickOnElementsortByColumn != null)
                {
                    uIAGlobalMouseClickOnElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementsortByColumn);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (uIAGlobalMouseClickOnElementmatchIndexAscending != null)
                {
                    if (uIAGlobalMouseClickOnElementmatchIndexAscending != null)
                    {
                        uIAGlobalMouseClickOnElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementmatchIndexAscending);
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
                        uIAGlobalMouseClickOnElement["ClickOffsetX"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementclickOffsetX);
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
                        uIAGlobalMouseClickOnElement["ClickOffsetY"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementclickOffsetY);
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
                    uIAGlobalMouseClickOnElement["OffsetRelativeTo"] = SourceExpressionConverter.Convert(uIAGlobalMouseClickOnElementoffsetRelativeTo);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (uIAGlobalMouseClickOnElementmaxElementsToSearch != null)
                {
                    if (uIAGlobalMouseClickOnElementmaxElementsToSearch != null)
                    {
                        uIAGlobalMouseClickOnElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementmaxElementsToSearch);
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
                        uIAGlobalMouseClickOnElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementmaxRelativeSearchDepth);
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
                        uIAGlobalMouseClickOnElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementmaxChildElementsToSearchPerNode);
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
                    uIAGlobalMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementelementLocalizedControlTypesNotToTraverse);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (uIAGlobalMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                {
                    if (uIAGlobalMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                    {
                        uIAGlobalMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementvalidateClickablePointWithinElementBoundary);
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
                uIAGlobalMouseClickOnElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickOnElementworkflow);
                if (uIAGlobalMouseClickOnElementpropCount > 0)
                {
                    callPayload.Body = uIAGlobalMouseClickOnElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalRightMouseClickOnElement([WorkflowExpression] Func<int> uIAGlobalRightMouseClickOnElementparentWindowHandle, [WorkflowExpression] Func<string> uIAGlobalRightMouseClickOnElementworkflow, [WorkflowExpression] Func<string> uIAGlobalRightMouseClickOnElementsearchElementName = null, [WorkflowExpression] Func<string> uIAGlobalRightMouseClickOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAGlobalRightMouseClickOnElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGlobalRightMouseClickOnElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGlobalRightMouseClickOnElementsearchSubTree = null, [WorkflowExpression] Func<bool> uIAGlobalRightMouseClickOnElementfocusElementFirst = null, [WorkflowExpression] Func<int> uIAGlobalRightMouseClickOnElementmatchIndex = null, [WorkflowExpression] Func<string> uIAGlobalRightMouseClickOnElementsearchFilter = null, [WorkflowExpression] Func<string> uIAGlobalRightMouseClickOnElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAGlobalRightMouseClickOnElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAGlobalRightMouseClickOnElementclickOffsetX = null, [WorkflowExpression] Func<int> uIAGlobalRightMouseClickOnElementclickOffsetY = null, [WorkflowExpression] Func<uIAGlobalRightMouseClickOnElementoffsetRelativeToInput> uIAGlobalRightMouseClickOnElementoffsetRelativeTo = null, [WorkflowExpression] Func<int> uIAGlobalRightMouseClickOnElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGlobalRightMouseClickOnElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGlobalRightMouseClickOnElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGlobalRightMouseClickOnElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIAGlobalRightMouseClickOnElementvalidateClickablePointWithinElementBoundary = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/GlobalRightMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGlobalRightMouseClickOnElement = new JObject();
                var uIAGlobalRightMouseClickOnElementpropCount = 0;
                uIAGlobalRightMouseClickOnElementpropCount++;
                uIAGlobalRightMouseClickOnElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementparentWindowHandle);
                if (uIAGlobalRightMouseClickOnElementsearchElementName != null)
                {
                    uIAGlobalRightMouseClickOnElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementsearchElementName);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (uIAGlobalRightMouseClickOnElementsearchElementClassName != null)
                {
                    uIAGlobalRightMouseClickOnElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementsearchElementClassName);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (uIAGlobalRightMouseClickOnElementsearchElementAutomationId != null)
                {
                    uIAGlobalRightMouseClickOnElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementsearchElementAutomationId);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (uIAGlobalRightMouseClickOnElementsearchLocalizedControlType != null)
                {
                    uIAGlobalRightMouseClickOnElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementsearchLocalizedControlType);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (uIAGlobalRightMouseClickOnElementsearchSubTree != null)
                {
                    if (uIAGlobalRightMouseClickOnElementsearchSubTree != null)
                    {
                        uIAGlobalRightMouseClickOnElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementsearchSubTree);
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
                        uIAGlobalRightMouseClickOnElement["FocusElementFirst"] = SourceExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementfocusElementFirst);
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
                        uIAGlobalRightMouseClickOnElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementmatchIndex);
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
                    uIAGlobalRightMouseClickOnElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementsearchFilter);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (uIAGlobalRightMouseClickOnElementsortByColumn != null)
                {
                    uIAGlobalRightMouseClickOnElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementsortByColumn);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (uIAGlobalRightMouseClickOnElementmatchIndexAscending != null)
                {
                    if (uIAGlobalRightMouseClickOnElementmatchIndexAscending != null)
                    {
                        uIAGlobalRightMouseClickOnElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementmatchIndexAscending);
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
                        uIAGlobalRightMouseClickOnElement["ClickOffsetX"] = SourceExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementclickOffsetX);
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
                        uIAGlobalRightMouseClickOnElement["ClickOffsetY"] = SourceExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementclickOffsetY);
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
                    uIAGlobalRightMouseClickOnElement["OffsetRelativeTo"] = SourceExpressionConverter.Convert(uIAGlobalRightMouseClickOnElementoffsetRelativeTo);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (uIAGlobalRightMouseClickOnElementmaxElementsToSearch != null)
                {
                    if (uIAGlobalRightMouseClickOnElementmaxElementsToSearch != null)
                    {
                        uIAGlobalRightMouseClickOnElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementmaxElementsToSearch);
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
                        uIAGlobalRightMouseClickOnElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementmaxRelativeSearchDepth);
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
                        uIAGlobalRightMouseClickOnElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementmaxChildElementsToSearchPerNode);
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
                    uIAGlobalRightMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementelementLocalizedControlTypesNotToTraverse);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (uIAGlobalRightMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                {
                    if (uIAGlobalRightMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                    {
                        uIAGlobalRightMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = SourceExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementvalidateClickablePointWithinElementBoundary);
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
                uIAGlobalRightMouseClickOnElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGlobalRightMouseClickOnElementworkflow);
                if (uIAGlobalRightMouseClickOnElementpropCount > 0)
                {
                    callPayload.Body = uIAGlobalRightMouseClickOnElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalMiddleMouseClickOnElement([WorkflowExpression] Func<int> uIAGlobalMiddleMouseClickOnElementparentWindowHandle, [WorkflowExpression] Func<string> uIAGlobalMiddleMouseClickOnElementworkflow, [WorkflowExpression] Func<string> uIAGlobalMiddleMouseClickOnElementsearchElementName = null, [WorkflowExpression] Func<string> uIAGlobalMiddleMouseClickOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAGlobalMiddleMouseClickOnElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGlobalMiddleMouseClickOnElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGlobalMiddleMouseClickOnElementsearchSubTree = null, [WorkflowExpression] Func<bool> uIAGlobalMiddleMouseClickOnElementfocusElementFirst = null, [WorkflowExpression] Func<int> uIAGlobalMiddleMouseClickOnElementmatchIndex = null, [WorkflowExpression] Func<string> uIAGlobalMiddleMouseClickOnElementsearchFilter = null, [WorkflowExpression] Func<string> uIAGlobalMiddleMouseClickOnElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAGlobalMiddleMouseClickOnElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAGlobalMiddleMouseClickOnElementclickOffsetX = null, [WorkflowExpression] Func<int> uIAGlobalMiddleMouseClickOnElementclickOffsetY = null, [WorkflowExpression] Func<uIAGlobalMiddleMouseClickOnElementoffsetRelativeToInput> uIAGlobalMiddleMouseClickOnElementoffsetRelativeTo = null, [WorkflowExpression] Func<int> uIAGlobalMiddleMouseClickOnElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGlobalMiddleMouseClickOnElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGlobalMiddleMouseClickOnElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGlobalMiddleMouseClickOnElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIAGlobalMiddleMouseClickOnElementvalidateClickablePointWithinElementBoundary = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/GlobalMiddleMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGlobalMiddleMouseClickOnElement = new JObject();
                var uIAGlobalMiddleMouseClickOnElementpropCount = 0;
                uIAGlobalMiddleMouseClickOnElementpropCount++;
                uIAGlobalMiddleMouseClickOnElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementparentWindowHandle);
                if (uIAGlobalMiddleMouseClickOnElementsearchElementName != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementsearchElementName);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (uIAGlobalMiddleMouseClickOnElementsearchElementClassName != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementsearchElementClassName);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (uIAGlobalMiddleMouseClickOnElementsearchElementAutomationId != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementsearchElementAutomationId);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (uIAGlobalMiddleMouseClickOnElementsearchLocalizedControlType != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementsearchLocalizedControlType);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (uIAGlobalMiddleMouseClickOnElementsearchSubTree != null)
                {
                    if (uIAGlobalMiddleMouseClickOnElementsearchSubTree != null)
                    {
                        uIAGlobalMiddleMouseClickOnElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementsearchSubTree);
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
                        uIAGlobalMiddleMouseClickOnElement["FocusElementFirst"] = SourceExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementfocusElementFirst);
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
                        uIAGlobalMiddleMouseClickOnElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementmatchIndex);
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
                    uIAGlobalMiddleMouseClickOnElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementsearchFilter);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (uIAGlobalMiddleMouseClickOnElementsortByColumn != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementsortByColumn);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (uIAGlobalMiddleMouseClickOnElementmatchIndexAscending != null)
                {
                    if (uIAGlobalMiddleMouseClickOnElementmatchIndexAscending != null)
                    {
                        uIAGlobalMiddleMouseClickOnElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementmatchIndexAscending);
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
                        uIAGlobalMiddleMouseClickOnElement["ClickOffsetX"] = SourceExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementclickOffsetX);
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
                        uIAGlobalMiddleMouseClickOnElement["ClickOffsetY"] = SourceExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementclickOffsetY);
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
                    uIAGlobalMiddleMouseClickOnElement["OffsetRelativeTo"] = SourceExpressionConverter.Convert(uIAGlobalMiddleMouseClickOnElementoffsetRelativeTo);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (uIAGlobalMiddleMouseClickOnElementmaxElementsToSearch != null)
                {
                    if (uIAGlobalMiddleMouseClickOnElementmaxElementsToSearch != null)
                    {
                        uIAGlobalMiddleMouseClickOnElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementmaxElementsToSearch);
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
                        uIAGlobalMiddleMouseClickOnElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementmaxRelativeSearchDepth);
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
                        uIAGlobalMiddleMouseClickOnElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementmaxChildElementsToSearchPerNode);
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
                    uIAGlobalMiddleMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementelementLocalizedControlTypesNotToTraverse);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (uIAGlobalMiddleMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                {
                    if (uIAGlobalMiddleMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                    {
                        uIAGlobalMiddleMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = SourceExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementvalidateClickablePointWithinElementBoundary);
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
                uIAGlobalMiddleMouseClickOnElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGlobalMiddleMouseClickOnElementworkflow);
                if (uIAGlobalMiddleMouseClickOnElementpropCount > 0)
                {
                    callPayload.Body = uIAGlobalMiddleMouseClickOnElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalDoubleLeftMouseClickOnElement([WorkflowExpression] Func<int> uIAGlobalDoubleLeftMouseClickOnElementparentWindowHandle, [WorkflowExpression] Func<string> uIAGlobalDoubleLeftMouseClickOnElementworkflow, [WorkflowExpression] Func<string> uIAGlobalDoubleLeftMouseClickOnElementsearchElementName = null, [WorkflowExpression] Func<string> uIAGlobalDoubleLeftMouseClickOnElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAGlobalDoubleLeftMouseClickOnElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGlobalDoubleLeftMouseClickOnElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGlobalDoubleLeftMouseClickOnElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds = null, [WorkflowExpression] Func<bool> uIAGlobalDoubleLeftMouseClickOnElementfocusElementFirst = null, [WorkflowExpression] Func<int> uIAGlobalDoubleLeftMouseClickOnElementmatchIndex = null, [WorkflowExpression] Func<string> uIAGlobalDoubleLeftMouseClickOnElementsearchFilter = null, [WorkflowExpression] Func<string> uIAGlobalDoubleLeftMouseClickOnElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAGlobalDoubleLeftMouseClickOnElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAGlobalDoubleLeftMouseClickOnElementclickOffsetX = null, [WorkflowExpression] Func<int> uIAGlobalDoubleLeftMouseClickOnElementclickOffsetY = null, [WorkflowExpression] Func<uIAGlobalDoubleLeftMouseClickOnElementoffsetRelativeToInput> uIAGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo = null, [WorkflowExpression] Func<int> uIAGlobalDoubleLeftMouseClickOnElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGlobalDoubleLeftMouseClickOnElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGlobalDoubleLeftMouseClickOnElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGlobalDoubleLeftMouseClickOnElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIAGlobalDoubleLeftMouseClickOnElementvalidateClickablePointWithinElementBoundary = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/GlobalDoubleLeftMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGlobalDoubleLeftMouseClickOnElement = new JObject();
                var uIAGlobalDoubleLeftMouseClickOnElementpropCount = 0;
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                uIAGlobalDoubleLeftMouseClickOnElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementparentWindowHandle);
                if (uIAGlobalDoubleLeftMouseClickOnElementsearchElementName != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementsearchElementName);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (uIAGlobalDoubleLeftMouseClickOnElementsearchElementClassName != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementsearchElementClassName);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (uIAGlobalDoubleLeftMouseClickOnElementsearchElementAutomationId != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementsearchElementAutomationId);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (uIAGlobalDoubleLeftMouseClickOnElementsearchLocalizedControlType != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementsearchLocalizedControlType);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (uIAGlobalDoubleLeftMouseClickOnElementsearchSubTree != null)
                {
                    if (uIAGlobalDoubleLeftMouseClickOnElementsearchSubTree != null)
                    {
                        uIAGlobalDoubleLeftMouseClickOnElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementsearchSubTree);
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
                        uIAGlobalDoubleLeftMouseClickOnElement["DelayInMilliseconds"] = SourceExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds);
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
                        uIAGlobalDoubleLeftMouseClickOnElement["FocusElementFirst"] = SourceExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementfocusElementFirst);
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
                        uIAGlobalDoubleLeftMouseClickOnElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementmatchIndex);
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
                    uIAGlobalDoubleLeftMouseClickOnElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementsearchFilter);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (uIAGlobalDoubleLeftMouseClickOnElementsortByColumn != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementsortByColumn);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (uIAGlobalDoubleLeftMouseClickOnElementmatchIndexAscending != null)
                {
                    if (uIAGlobalDoubleLeftMouseClickOnElementmatchIndexAscending != null)
                    {
                        uIAGlobalDoubleLeftMouseClickOnElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementmatchIndexAscending);
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
                        uIAGlobalDoubleLeftMouseClickOnElement["ClickOffsetX"] = SourceExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementclickOffsetX);
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
                        uIAGlobalDoubleLeftMouseClickOnElement["ClickOffsetY"] = SourceExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementclickOffsetY);
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
                    uIAGlobalDoubleLeftMouseClickOnElement["OffsetRelativeTo"] = SourceExpressionConverter.Convert(uIAGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (uIAGlobalDoubleLeftMouseClickOnElementmaxElementsToSearch != null)
                {
                    if (uIAGlobalDoubleLeftMouseClickOnElementmaxElementsToSearch != null)
                    {
                        uIAGlobalDoubleLeftMouseClickOnElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementmaxElementsToSearch);
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
                        uIAGlobalDoubleLeftMouseClickOnElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementmaxRelativeSearchDepth);
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
                        uIAGlobalDoubleLeftMouseClickOnElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementmaxChildElementsToSearchPerNode);
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
                    uIAGlobalDoubleLeftMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementelementLocalizedControlTypesNotToTraverse);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (uIAGlobalDoubleLeftMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                {
                    if (uIAGlobalDoubleLeftMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                    {
                        uIAGlobalDoubleLeftMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = SourceExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementvalidateClickablePointWithinElementBoundary);
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
                uIAGlobalDoubleLeftMouseClickOnElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGlobalDoubleLeftMouseClickOnElementworkflow);
                if (uIAGlobalDoubleLeftMouseClickOnElementpropCount > 0)
                {
                    callPayload.Body = uIAGlobalDoubleLeftMouseClickOnElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIASelectElement([WorkflowExpression] Func<int> uIASelectElementparentWindowHandle, [WorkflowExpression] Func<string> uIASelectElementworkflow, [WorkflowExpression] Func<string> uIASelectElementsearchElementName = null, [WorkflowExpression] Func<string> uIASelectElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIASelectElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIASelectElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIASelectElementsearchSubTree = null, [WorkflowExpression] Func<int> uIASelectElementmatchIndex = null, [WorkflowExpression] Func<string> uIASelectElementsearchFilter = null, [WorkflowExpression] Func<string> uIASelectElementsortByColumn = null, [WorkflowExpression] Func<bool> uIASelectElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIASelectElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIASelectElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIASelectElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIASelectElementelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/SelectElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIASelectElement = new JObject();
                var uIASelectElementpropCount = 0;
                uIASelectElementpropCount++;
                uIASelectElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIASelectElementparentWindowHandle);
                if (uIASelectElementsearchElementName != null)
                {
                    uIASelectElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIASelectElementsearchElementName);
                    uIASelectElementpropCount++;
                }

                if (uIASelectElementsearchElementClassName != null)
                {
                    uIASelectElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIASelectElementsearchElementClassName);
                    uIASelectElementpropCount++;
                }

                if (uIASelectElementsearchElementAutomationId != null)
                {
                    uIASelectElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIASelectElementsearchElementAutomationId);
                    uIASelectElementpropCount++;
                }

                if (uIASelectElementsearchLocalizedControlType != null)
                {
                    uIASelectElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIASelectElementsearchLocalizedControlType);
                    uIASelectElementpropCount++;
                }

                if (uIASelectElementsearchSubTree != null)
                {
                    if (uIASelectElementsearchSubTree != null)
                    {
                        uIASelectElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIASelectElementsearchSubTree);
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
                        uIASelectElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIASelectElementmatchIndex);
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
                    uIASelectElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIASelectElementsearchFilter);
                    uIASelectElementpropCount++;
                }

                if (uIASelectElementsortByColumn != null)
                {
                    uIASelectElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIASelectElementsortByColumn);
                    uIASelectElementpropCount++;
                }

                if (uIASelectElementmatchIndexAscending != null)
                {
                    if (uIASelectElementmatchIndexAscending != null)
                    {
                        uIASelectElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIASelectElementmatchIndexAscending);
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
                        uIASelectElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIASelectElementmaxElementsToSearch);
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
                        uIASelectElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIASelectElementmaxRelativeSearchDepth);
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
                        uIASelectElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIASelectElementmaxChildElementsToSearchPerNode);
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
                    uIASelectElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIASelectElementelementLocalizedControlTypesNotToTraverse);
                    uIASelectElementpropCount++;
                }

                uIASelectElementpropCount++;
                uIASelectElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIASelectElementworkflow);
                if (uIASelectElementpropCount > 0)
                {
                    callPayload.Body = uIASelectElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAInputPasswordIntoElement([WorkflowExpression] Func<int> uIAInputPasswordIntoElementparentWindowHandle, [WorkflowExpression] Func<string> uIAInputPasswordIntoElementpasswordToInput, [WorkflowExpression] Func<string> uIAInputPasswordIntoElementworkflow, [WorkflowExpression] Func<string> uIAInputPasswordIntoElementsearchElementName = null, [WorkflowExpression] Func<string> uIAInputPasswordIntoElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAInputPasswordIntoElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAInputPasswordIntoElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAInputPasswordIntoElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAInputPasswordIntoElementmatchIndex = null, [WorkflowExpression] Func<string> uIAInputPasswordIntoElementsearchFilter = null, [WorkflowExpression] Func<string> uIAInputPasswordIntoElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAInputPasswordIntoElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIAInputPasswordIntoElementpasswordContainsStoredPassword = null, [WorkflowExpression] Func<int> uIAInputPasswordIntoElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAInputPasswordIntoElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAInputPasswordIntoElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAInputPasswordIntoElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIAInputPasswordIntoElementtryValuePattern = null, [WorkflowExpression] Func<bool> uIAInputPasswordIntoElementtryLegacyPattern = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/InputPasswordIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAInputPasswordIntoElement = new JObject();
                var uIAInputPasswordIntoElementpropCount = 0;
                uIAInputPasswordIntoElementpropCount++;
                uIAInputPasswordIntoElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAInputPasswordIntoElementparentWindowHandle);
                if (uIAInputPasswordIntoElementsearchElementName != null)
                {
                    uIAInputPasswordIntoElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAInputPasswordIntoElementsearchElementName);
                    uIAInputPasswordIntoElementpropCount++;
                }

                if (uIAInputPasswordIntoElementsearchElementClassName != null)
                {
                    uIAInputPasswordIntoElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAInputPasswordIntoElementsearchElementClassName);
                    uIAInputPasswordIntoElementpropCount++;
                }

                if (uIAInputPasswordIntoElementsearchElementAutomationId != null)
                {
                    uIAInputPasswordIntoElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAInputPasswordIntoElementsearchElementAutomationId);
                    uIAInputPasswordIntoElementpropCount++;
                }

                if (uIAInputPasswordIntoElementsearchLocalizedControlType != null)
                {
                    uIAInputPasswordIntoElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAInputPasswordIntoElementsearchLocalizedControlType);
                    uIAInputPasswordIntoElementpropCount++;
                }

                if (uIAInputPasswordIntoElementsearchSubTree != null)
                {
                    if (uIAInputPasswordIntoElementsearchSubTree != null)
                    {
                        uIAInputPasswordIntoElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAInputPasswordIntoElementsearchSubTree);
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
                uIAInputPasswordIntoElement["PasswordToInput"] = SourceExpressionConverter.ConvertToken(uIAInputPasswordIntoElementpasswordToInput);
                if (uIAInputPasswordIntoElementmatchIndex != null)
                {
                    if (uIAInputPasswordIntoElementmatchIndex != null)
                    {
                        uIAInputPasswordIntoElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAInputPasswordIntoElementmatchIndex);
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
                    uIAInputPasswordIntoElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAInputPasswordIntoElementsearchFilter);
                    uIAInputPasswordIntoElementpropCount++;
                }

                if (uIAInputPasswordIntoElementsortByColumn != null)
                {
                    uIAInputPasswordIntoElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAInputPasswordIntoElementsortByColumn);
                    uIAInputPasswordIntoElementpropCount++;
                }

                if (uIAInputPasswordIntoElementmatchIndexAscending != null)
                {
                    if (uIAInputPasswordIntoElementmatchIndexAscending != null)
                    {
                        uIAInputPasswordIntoElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAInputPasswordIntoElementmatchIndexAscending);
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
                        uIAInputPasswordIntoElement["PasswordContainsStoredPassword"] = SourceExpressionConverter.ConvertToken(uIAInputPasswordIntoElementpasswordContainsStoredPassword);
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
                        uIAInputPasswordIntoElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAInputPasswordIntoElementmaxElementsToSearch);
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
                        uIAInputPasswordIntoElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAInputPasswordIntoElementmaxRelativeSearchDepth);
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
                        uIAInputPasswordIntoElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAInputPasswordIntoElementmaxChildElementsToSearchPerNode);
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
                    uIAInputPasswordIntoElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAInputPasswordIntoElementelementLocalizedControlTypesNotToTraverse);
                    uIAInputPasswordIntoElementpropCount++;
                }

                if (uIAInputPasswordIntoElementtryValuePattern != null)
                {
                    if (uIAInputPasswordIntoElementtryValuePattern != null)
                    {
                        uIAInputPasswordIntoElement["TryValuePattern"] = SourceExpressionConverter.ConvertToken(uIAInputPasswordIntoElementtryValuePattern);
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
                        uIAInputPasswordIntoElement["TryLegacyPattern"] = SourceExpressionConverter.ConvertToken(uIAInputPasswordIntoElementtryLegacyPattern);
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
                uIAInputPasswordIntoElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIAInputPasswordIntoElementworkflow);
                if (uIAInputPasswordIntoElementpropCount > 0)
                {
                    callPayload.Body = uIAInputPasswordIntoElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAInputTextIntoElement([WorkflowExpression] Func<int> uIAInputTextIntoElementparentWindowHandle, [WorkflowExpression] Func<string> uIAInputTextIntoElementworkflow, [WorkflowExpression] Func<string> uIAInputTextIntoElementsearchElementName = null, [WorkflowExpression] Func<string> uIAInputTextIntoElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAInputTextIntoElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAInputTextIntoElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAInputTextIntoElementsearchSubTree = null, [WorkflowExpression] Func<string> uIAInputTextIntoElementtextToInput = null, [WorkflowExpression] Func<int> uIAInputTextIntoElementmatchIndex = null, [WorkflowExpression] Func<string> uIAInputTextIntoElementsearchFilter = null, [WorkflowExpression] Func<string> uIAInputTextIntoElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAInputTextIntoElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIAInputTextIntoElementreplaceExistingValue = null, [WorkflowExpression] Func<int> uIAInputTextIntoElementinsertPosition = null, [WorkflowExpression] Func<int> uIAInputTextIntoElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAInputTextIntoElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAInputTextIntoElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAInputTextIntoElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIAInputTextIntoElementraiseExceptionIfInputValidationFails = null, [WorkflowExpression] Func<bool> uIAInputTextIntoElementtryValuePattern = null, [WorkflowExpression] Func<bool> uIAInputTextIntoElementtryLegacyPattern = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/InputTextIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAInputTextIntoElement = new JObject();
                var uIAInputTextIntoElementpropCount = 0;
                uIAInputTextIntoElementpropCount++;
                uIAInputTextIntoElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoElementparentWindowHandle);
                if (uIAInputTextIntoElementsearchElementName != null)
                {
                    uIAInputTextIntoElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoElementsearchElementName);
                    uIAInputTextIntoElementpropCount++;
                }

                if (uIAInputTextIntoElementsearchElementClassName != null)
                {
                    uIAInputTextIntoElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoElementsearchElementClassName);
                    uIAInputTextIntoElementpropCount++;
                }

                if (uIAInputTextIntoElementsearchElementAutomationId != null)
                {
                    uIAInputTextIntoElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoElementsearchElementAutomationId);
                    uIAInputTextIntoElementpropCount++;
                }

                if (uIAInputTextIntoElementsearchLocalizedControlType != null)
                {
                    uIAInputTextIntoElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoElementsearchLocalizedControlType);
                    uIAInputTextIntoElementpropCount++;
                }

                if (uIAInputTextIntoElementsearchSubTree != null)
                {
                    if (uIAInputTextIntoElementsearchSubTree != null)
                    {
                        uIAInputTextIntoElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoElementsearchSubTree);
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
                    uIAInputTextIntoElement["TextToInput"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoElementtextToInput);
                    uIAInputTextIntoElementpropCount++;
                }

                if (uIAInputTextIntoElementmatchIndex != null)
                {
                    if (uIAInputTextIntoElementmatchIndex != null)
                    {
                        uIAInputTextIntoElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoElementmatchIndex);
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
                    uIAInputTextIntoElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoElementsearchFilter);
                    uIAInputTextIntoElementpropCount++;
                }

                if (uIAInputTextIntoElementsortByColumn != null)
                {
                    uIAInputTextIntoElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoElementsortByColumn);
                    uIAInputTextIntoElementpropCount++;
                }

                if (uIAInputTextIntoElementmatchIndexAscending != null)
                {
                    if (uIAInputTextIntoElementmatchIndexAscending != null)
                    {
                        uIAInputTextIntoElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoElementmatchIndexAscending);
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
                        uIAInputTextIntoElement["ReplaceExistingValue"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoElementreplaceExistingValue);
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
                        uIAInputTextIntoElement["InsertPosition"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoElementinsertPosition);
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
                        uIAInputTextIntoElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoElementmaxElementsToSearch);
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
                        uIAInputTextIntoElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoElementmaxRelativeSearchDepth);
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
                        uIAInputTextIntoElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoElementmaxChildElementsToSearchPerNode);
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
                    uIAInputTextIntoElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoElementelementLocalizedControlTypesNotToTraverse);
                    uIAInputTextIntoElementpropCount++;
                }

                if (uIAInputTextIntoElementraiseExceptionIfInputValidationFails != null)
                {
                    if (uIAInputTextIntoElementraiseExceptionIfInputValidationFails != null)
                    {
                        uIAInputTextIntoElement["RaiseExceptionIfInputValidationFails"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoElementraiseExceptionIfInputValidationFails);
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
                        uIAInputTextIntoElement["TryValuePattern"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoElementtryValuePattern);
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
                        uIAInputTextIntoElement["TryLegacyPattern"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoElementtryLegacyPattern);
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
                uIAInputTextIntoElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoElementworkflow);
                if (uIAInputTextIntoElementpropCount > 0)
                {
                    callPayload.Body = uIAInputTextIntoElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAInputTextIntoMultipleElements([WorkflowExpression] Func<string> uIAInputTextIntoMultipleElementsinputElementsJSON, [WorkflowExpression] Func<string> uIAInputTextIntoMultipleElementsworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIAInputTextIntoMultipleElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAInputTextIntoMultipleElements = new JObject();
                var uIAInputTextIntoMultipleElementspropCount = 0;
                uIAInputTextIntoMultipleElementspropCount++;
                uIAInputTextIntoMultipleElements["InputElementsJSON"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoMultipleElementsinputElementsJSON);
                uIAInputTextIntoMultipleElementspropCount++;
                uIAInputTextIntoMultipleElements["Workflow"] = SourceExpressionConverter.ConvertToken(uIAInputTextIntoMultipleElementsworkflow);
                if (uIAInputTextIntoMultipleElementspropCount > 0)
                {
                    callPayload.Body = uIAInputTextIntoMultipleElements;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAInputReturnIntoElement([WorkflowExpression] Func<int> uIAInputReturnIntoElementparentWindowHandle, [WorkflowExpression] Func<string> uIAInputReturnIntoElementworkflow, [WorkflowExpression] Func<string> uIAInputReturnIntoElementsearchElementName = null, [WorkflowExpression] Func<string> uIAInputReturnIntoElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAInputReturnIntoElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAInputReturnIntoElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAInputReturnIntoElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAInputReturnIntoElementmatchIndex = null, [WorkflowExpression] Func<string> uIAInputReturnIntoElementsearchFilter = null, [WorkflowExpression] Func<string> uIAInputReturnIntoElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAInputReturnIntoElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIAInputReturnIntoElementreplaceExistingValue = null, [WorkflowExpression] Func<int> uIAInputReturnIntoElementinsertPosition = null, [WorkflowExpression] Func<int> uIAInputReturnIntoElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAInputReturnIntoElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAInputReturnIntoElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAInputReturnIntoElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIAInputReturnIntoElementraiseExceptionIfInputValidationFails = null, [WorkflowExpression] Func<bool> uIAInputReturnIntoElementtryValuePattern = null, [WorkflowExpression] Func<bool> uIAInputReturnIntoElementtryLegacyPattern = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/InputReturnIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAInputReturnIntoElement = new JObject();
                var uIAInputReturnIntoElementpropCount = 0;
                uIAInputReturnIntoElementpropCount++;
                uIAInputReturnIntoElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAInputReturnIntoElementparentWindowHandle);
                if (uIAInputReturnIntoElementsearchElementName != null)
                {
                    uIAInputReturnIntoElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAInputReturnIntoElementsearchElementName);
                    uIAInputReturnIntoElementpropCount++;
                }

                if (uIAInputReturnIntoElementsearchElementClassName != null)
                {
                    uIAInputReturnIntoElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAInputReturnIntoElementsearchElementClassName);
                    uIAInputReturnIntoElementpropCount++;
                }

                if (uIAInputReturnIntoElementsearchElementAutomationId != null)
                {
                    uIAInputReturnIntoElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAInputReturnIntoElementsearchElementAutomationId);
                    uIAInputReturnIntoElementpropCount++;
                }

                if (uIAInputReturnIntoElementsearchLocalizedControlType != null)
                {
                    uIAInputReturnIntoElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAInputReturnIntoElementsearchLocalizedControlType);
                    uIAInputReturnIntoElementpropCount++;
                }

                if (uIAInputReturnIntoElementsearchSubTree != null)
                {
                    if (uIAInputReturnIntoElementsearchSubTree != null)
                    {
                        uIAInputReturnIntoElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAInputReturnIntoElementsearchSubTree);
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
                        uIAInputReturnIntoElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAInputReturnIntoElementmatchIndex);
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
                    uIAInputReturnIntoElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAInputReturnIntoElementsearchFilter);
                    uIAInputReturnIntoElementpropCount++;
                }

                if (uIAInputReturnIntoElementsortByColumn != null)
                {
                    uIAInputReturnIntoElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAInputReturnIntoElementsortByColumn);
                    uIAInputReturnIntoElementpropCount++;
                }

                if (uIAInputReturnIntoElementmatchIndexAscending != null)
                {
                    if (uIAInputReturnIntoElementmatchIndexAscending != null)
                    {
                        uIAInputReturnIntoElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAInputReturnIntoElementmatchIndexAscending);
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
                        uIAInputReturnIntoElement["ReplaceExistingValue"] = SourceExpressionConverter.ConvertToken(uIAInputReturnIntoElementreplaceExistingValue);
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
                    uIAInputReturnIntoElement["InsertPosition"] = SourceExpressionConverter.ConvertToken(uIAInputReturnIntoElementinsertPosition);
                    uIAInputReturnIntoElementpropCount++;
                }

                if (uIAInputReturnIntoElementmaxElementsToSearch != null)
                {
                    if (uIAInputReturnIntoElementmaxElementsToSearch != null)
                    {
                        uIAInputReturnIntoElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAInputReturnIntoElementmaxElementsToSearch);
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
                        uIAInputReturnIntoElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAInputReturnIntoElementmaxRelativeSearchDepth);
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
                        uIAInputReturnIntoElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAInputReturnIntoElementmaxChildElementsToSearchPerNode);
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
                    uIAInputReturnIntoElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAInputReturnIntoElementelementLocalizedControlTypesNotToTraverse);
                    uIAInputReturnIntoElementpropCount++;
                }

                if (uIAInputReturnIntoElementraiseExceptionIfInputValidationFails != null)
                {
                    if (uIAInputReturnIntoElementraiseExceptionIfInputValidationFails != null)
                    {
                        uIAInputReturnIntoElement["RaiseExceptionIfInputValidationFails"] = SourceExpressionConverter.ConvertToken(uIAInputReturnIntoElementraiseExceptionIfInputValidationFails);
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
                        uIAInputReturnIntoElement["TryValuePattern"] = SourceExpressionConverter.ConvertToken(uIAInputReturnIntoElementtryValuePattern);
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
                        uIAInputReturnIntoElement["TryLegacyPattern"] = SourceExpressionConverter.ConvertToken(uIAInputReturnIntoElementtryLegacyPattern);
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
                uIAInputReturnIntoElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIAInputReturnIntoElementworkflow);
                if (uIAInputReturnIntoElementpropCount > 0)
                {
                    callPayload.Body = uIAInputReturnIntoElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAFocusElement([WorkflowExpression] Func<int> uIAFocusElementparentWindowHandle, [WorkflowExpression] Func<string> uIAFocusElementworkflow, [WorkflowExpression] Func<string> uIAFocusElementsearchElementName = null, [WorkflowExpression] Func<string> uIAFocusElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAFocusElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAFocusElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAFocusElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAFocusElementmatchIndex = null, [WorkflowExpression] Func<string> uIAFocusElementsearchFilter = null, [WorkflowExpression] Func<string> uIAFocusElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAFocusElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAFocusElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAFocusElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAFocusElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAFocusElementelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/FocusElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAFocusElement = new JObject();
                var uIAFocusElementpropCount = 0;
                uIAFocusElementpropCount++;
                uIAFocusElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAFocusElementparentWindowHandle);
                if (uIAFocusElementsearchElementName != null)
                {
                    uIAFocusElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAFocusElementsearchElementName);
                    uIAFocusElementpropCount++;
                }

                if (uIAFocusElementsearchElementClassName != null)
                {
                    uIAFocusElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAFocusElementsearchElementClassName);
                    uIAFocusElementpropCount++;
                }

                if (uIAFocusElementsearchElementAutomationId != null)
                {
                    uIAFocusElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAFocusElementsearchElementAutomationId);
                    uIAFocusElementpropCount++;
                }

                if (uIAFocusElementsearchLocalizedControlType != null)
                {
                    uIAFocusElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAFocusElementsearchLocalizedControlType);
                    uIAFocusElementpropCount++;
                }

                if (uIAFocusElementsearchSubTree != null)
                {
                    if (uIAFocusElementsearchSubTree != null)
                    {
                        uIAFocusElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAFocusElementsearchSubTree);
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
                        uIAFocusElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAFocusElementmatchIndex);
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
                    uIAFocusElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAFocusElementsearchFilter);
                    uIAFocusElementpropCount++;
                }

                if (uIAFocusElementsortByColumn != null)
                {
                    uIAFocusElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAFocusElementsortByColumn);
                    uIAFocusElementpropCount++;
                }

                if (uIAFocusElementmatchIndexAscending != null)
                {
                    if (uIAFocusElementmatchIndexAscending != null)
                    {
                        uIAFocusElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAFocusElementmatchIndexAscending);
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
                        uIAFocusElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAFocusElementmaxElementsToSearch);
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
                        uIAFocusElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAFocusElementmaxRelativeSearchDepth);
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
                        uIAFocusElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAFocusElementmaxChildElementsToSearchPerNode);
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
                    uIAFocusElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAFocusElementelementLocalizedControlTypesNotToTraverse);
                    uIAFocusElementpropCount++;
                }

                uIAFocusElementpropCount++;
                uIAFocusElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIAFocusElementworkflow);
                if (uIAFocusElementpropCount > 0)
                {
                    callPayload.Body = uIAFocusElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAToggleElement([WorkflowExpression] Func<int> uIAToggleElementparentWindowHandle, [WorkflowExpression] Func<string> uIAToggleElementworkflow, [WorkflowExpression] Func<string> uIAToggleElementsearchElementName = null, [WorkflowExpression] Func<string> uIAToggleElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAToggleElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAToggleElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAToggleElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAToggleElementmatchIndex = null, [WorkflowExpression] Func<string> uIAToggleElementsearchFilter = null, [WorkflowExpression] Func<string> uIAToggleElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAToggleElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAToggleElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAToggleElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAToggleElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAToggleElementelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/ToggleElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAToggleElement = new JObject();
                var uIAToggleElementpropCount = 0;
                uIAToggleElementpropCount++;
                uIAToggleElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAToggleElementparentWindowHandle);
                if (uIAToggleElementsearchElementName != null)
                {
                    uIAToggleElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAToggleElementsearchElementName);
                    uIAToggleElementpropCount++;
                }

                if (uIAToggleElementsearchElementClassName != null)
                {
                    uIAToggleElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAToggleElementsearchElementClassName);
                    uIAToggleElementpropCount++;
                }

                if (uIAToggleElementsearchElementAutomationId != null)
                {
                    uIAToggleElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAToggleElementsearchElementAutomationId);
                    uIAToggleElementpropCount++;
                }

                if (uIAToggleElementsearchLocalizedControlType != null)
                {
                    uIAToggleElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAToggleElementsearchLocalizedControlType);
                    uIAToggleElementpropCount++;
                }

                if (uIAToggleElementsearchSubTree != null)
                {
                    if (uIAToggleElementsearchSubTree != null)
                    {
                        uIAToggleElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAToggleElementsearchSubTree);
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
                        uIAToggleElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAToggleElementmatchIndex);
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
                    uIAToggleElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAToggleElementsearchFilter);
                    uIAToggleElementpropCount++;
                }

                if (uIAToggleElementsortByColumn != null)
                {
                    uIAToggleElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAToggleElementsortByColumn);
                    uIAToggleElementpropCount++;
                }

                if (uIAToggleElementmatchIndexAscending != null)
                {
                    if (uIAToggleElementmatchIndexAscending != null)
                    {
                        uIAToggleElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAToggleElementmatchIndexAscending);
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
                        uIAToggleElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAToggleElementmaxElementsToSearch);
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
                        uIAToggleElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAToggleElementmaxRelativeSearchDepth);
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
                        uIAToggleElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAToggleElementmaxChildElementsToSearchPerNode);
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
                    uIAToggleElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAToggleElementelementLocalizedControlTypesNotToTraverse);
                    uIAToggleElementpropCount++;
                }

                uIAToggleElementpropCount++;
                uIAToggleElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIAToggleElementworkflow);
                if (uIAToggleElementpropCount > 0)
                {
                    callPayload.Body = uIAToggleElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIACheckElement([WorkflowExpression] Func<int> uIACheckElementparentWindowHandle, [WorkflowExpression] Func<string> uIACheckElementworkflow, [WorkflowExpression] Func<string> uIACheckElementsearchElementName = null, [WorkflowExpression] Func<string> uIACheckElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIACheckElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIACheckElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIACheckElementsearchSubTree = null, [WorkflowExpression] Func<bool> uIACheckElementcheckElement = null, [WorkflowExpression] Func<int> uIACheckElementmatchIndex = null, [WorkflowExpression] Func<string> uIACheckElementsearchFilter = null, [WorkflowExpression] Func<string> uIACheckElementsortByColumn = null, [WorkflowExpression] Func<bool> uIACheckElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIACheckElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIACheckElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIACheckElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIACheckElementelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/CheckElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIACheckElement = new JObject();
                var uIACheckElementpropCount = 0;
                uIACheckElementpropCount++;
                uIACheckElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIACheckElementparentWindowHandle);
                if (uIACheckElementsearchElementName != null)
                {
                    uIACheckElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIACheckElementsearchElementName);
                    uIACheckElementpropCount++;
                }

                if (uIACheckElementsearchElementClassName != null)
                {
                    uIACheckElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIACheckElementsearchElementClassName);
                    uIACheckElementpropCount++;
                }

                if (uIACheckElementsearchElementAutomationId != null)
                {
                    uIACheckElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIACheckElementsearchElementAutomationId);
                    uIACheckElementpropCount++;
                }

                if (uIACheckElementsearchLocalizedControlType != null)
                {
                    uIACheckElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIACheckElementsearchLocalizedControlType);
                    uIACheckElementpropCount++;
                }

                if (uIACheckElementsearchSubTree != null)
                {
                    if (uIACheckElementsearchSubTree != null)
                    {
                        uIACheckElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIACheckElementsearchSubTree);
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
                        uIACheckElement["CheckElement"] = SourceExpressionConverter.ConvertToken(uIACheckElementcheckElement);
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
                        uIACheckElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIACheckElementmatchIndex);
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
                    uIACheckElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIACheckElementsearchFilter);
                    uIACheckElementpropCount++;
                }

                if (uIACheckElementsortByColumn != null)
                {
                    uIACheckElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIACheckElementsortByColumn);
                    uIACheckElementpropCount++;
                }

                if (uIACheckElementmatchIndexAscending != null)
                {
                    if (uIACheckElementmatchIndexAscending != null)
                    {
                        uIACheckElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIACheckElementmatchIndexAscending);
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
                        uIACheckElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIACheckElementmaxElementsToSearch);
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
                        uIACheckElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIACheckElementmaxRelativeSearchDepth);
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
                        uIACheckElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIACheckElementmaxChildElementsToSearchPerNode);
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
                    uIACheckElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIACheckElementelementLocalizedControlTypesNotToTraverse);
                    uIACheckElementpropCount++;
                }

                uIACheckElementpropCount++;
                uIACheckElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIACheckElementworkflow);
                if (uIACheckElementpropCount > 0)
                {
                    callPayload.Body = uIACheckElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIACheckMultipleElements([WorkflowExpression] Func<string> uIACheckMultipleElementsinputElementsJSON, [WorkflowExpression] Func<string> uIACheckMultipleElementsworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIACheckMultipleElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIACheckMultipleElements = new JObject();
                var uIACheckMultipleElementspropCount = 0;
                uIACheckMultipleElementspropCount++;
                uIACheckMultipleElements["InputElementsJSON"] = SourceExpressionConverter.ConvertToken(uIACheckMultipleElementsinputElementsJSON);
                uIACheckMultipleElementspropCount++;
                uIACheckMultipleElements["Workflow"] = SourceExpressionConverter.ConvertToken(uIACheckMultipleElementsworkflow);
                if (uIACheckMultipleElementspropCount > 0)
                {
                    callPayload.Body = uIACheckMultipleElements;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAIsElementCheckedResponse> UIAIsElementChecked([WorkflowExpression] Func<int> uIAIsElementCheckedparentWindowHandle, [WorkflowExpression] Func<string> uIAIsElementCheckedworkflow, [WorkflowExpression] Func<string> uIAIsElementCheckedsearchElementName = null, [WorkflowExpression] Func<string> uIAIsElementCheckedsearchElementClassName = null, [WorkflowExpression] Func<string> uIAIsElementCheckedsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAIsElementCheckedsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAIsElementCheckedsearchSubTree = null, [WorkflowExpression] Func<int> uIAIsElementCheckedmatchIndex = null, [WorkflowExpression] Func<string> uIAIsElementCheckedsearchFilter = null, [WorkflowExpression] Func<string> uIAIsElementCheckedsortByColumn = null, [WorkflowExpression] Func<bool> uIAIsElementCheckedmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAIsElementCheckedmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAIsElementCheckedmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAIsElementCheckedmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAIsElementCheckedelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIAIsElementChecked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAIsElementChecked = new JObject();
                var uIAIsElementCheckedpropCount = 0;
                uIAIsElementCheckedpropCount++;
                uIAIsElementChecked["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAIsElementCheckedparentWindowHandle);
                if (uIAIsElementCheckedsearchElementName != null)
                {
                    uIAIsElementChecked["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAIsElementCheckedsearchElementName);
                    uIAIsElementCheckedpropCount++;
                }

                if (uIAIsElementCheckedsearchElementClassName != null)
                {
                    uIAIsElementChecked["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAIsElementCheckedsearchElementClassName);
                    uIAIsElementCheckedpropCount++;
                }

                if (uIAIsElementCheckedsearchElementAutomationId != null)
                {
                    uIAIsElementChecked["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAIsElementCheckedsearchElementAutomationId);
                    uIAIsElementCheckedpropCount++;
                }

                if (uIAIsElementCheckedsearchLocalizedControlType != null)
                {
                    uIAIsElementChecked["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAIsElementCheckedsearchLocalizedControlType);
                    uIAIsElementCheckedpropCount++;
                }

                if (uIAIsElementCheckedsearchSubTree != null)
                {
                    if (uIAIsElementCheckedsearchSubTree != null)
                    {
                        uIAIsElementChecked["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAIsElementCheckedsearchSubTree);
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
                        uIAIsElementChecked["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAIsElementCheckedmatchIndex);
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
                    uIAIsElementChecked["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAIsElementCheckedsearchFilter);
                    uIAIsElementCheckedpropCount++;
                }

                if (uIAIsElementCheckedsortByColumn != null)
                {
                    uIAIsElementChecked["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAIsElementCheckedsortByColumn);
                    uIAIsElementCheckedpropCount++;
                }

                if (uIAIsElementCheckedmatchIndexAscending != null)
                {
                    if (uIAIsElementCheckedmatchIndexAscending != null)
                    {
                        uIAIsElementChecked["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAIsElementCheckedmatchIndexAscending);
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
                        uIAIsElementChecked["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAIsElementCheckedmaxElementsToSearch);
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
                        uIAIsElementChecked["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAIsElementCheckedmaxRelativeSearchDepth);
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
                        uIAIsElementChecked["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAIsElementCheckedmaxChildElementsToSearchPerNode);
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
                    uIAIsElementChecked["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAIsElementCheckedelementLocalizedControlTypesNotToTraverse);
                    uIAIsElementCheckedpropCount++;
                }

                uIAIsElementCheckedpropCount++;
                uIAIsElementChecked["Workflow"] = SourceExpressionConverter.ConvertToken(uIAIsElementCheckedworkflow);
                if (uIAIsElementCheckedpropCount > 0)
                {
                    callPayload.Body = uIAIsElementChecked;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAIsElementCheckedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIACloseElementWindow([WorkflowExpression] Func<int> uIACloseElementWindowparentWindowHandle, [WorkflowExpression] Func<string> uIACloseElementWindowworkflow, [WorkflowExpression] Func<string> uIACloseElementWindowsearchElementName = null, [WorkflowExpression] Func<string> uIACloseElementWindowsearchElementClassName = null, [WorkflowExpression] Func<string> uIACloseElementWindowsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIACloseElementWindowsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIACloseElementWindowsearchSubTree = null, [WorkflowExpression] Func<int> uIACloseElementWindowmatchIndex = null, [WorkflowExpression] Func<string> uIACloseElementWindowsearchFilter = null, [WorkflowExpression] Func<string> uIACloseElementWindowsortByColumn = null, [WorkflowExpression] Func<bool> uIACloseElementWindowmatchIndexAscending = null, [WorkflowExpression] Func<int> uIACloseElementWindowmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIACloseElementWindowmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIACloseElementWindowmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIACloseElementWindowelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/CloseElementWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIACloseElementWindow = new JObject();
                var uIACloseElementWindowpropCount = 0;
                uIACloseElementWindowpropCount++;
                uIACloseElementWindow["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIACloseElementWindowparentWindowHandle);
                if (uIACloseElementWindowsearchElementName != null)
                {
                    uIACloseElementWindow["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIACloseElementWindowsearchElementName);
                    uIACloseElementWindowpropCount++;
                }

                if (uIACloseElementWindowsearchElementClassName != null)
                {
                    uIACloseElementWindow["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIACloseElementWindowsearchElementClassName);
                    uIACloseElementWindowpropCount++;
                }

                if (uIACloseElementWindowsearchElementAutomationId != null)
                {
                    uIACloseElementWindow["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIACloseElementWindowsearchElementAutomationId);
                    uIACloseElementWindowpropCount++;
                }

                if (uIACloseElementWindowsearchLocalizedControlType != null)
                {
                    uIACloseElementWindow["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIACloseElementWindowsearchLocalizedControlType);
                    uIACloseElementWindowpropCount++;
                }

                if (uIACloseElementWindowsearchSubTree != null)
                {
                    if (uIACloseElementWindowsearchSubTree != null)
                    {
                        uIACloseElementWindow["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIACloseElementWindowsearchSubTree);
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
                        uIACloseElementWindow["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIACloseElementWindowmatchIndex);
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
                    uIACloseElementWindow["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIACloseElementWindowsearchFilter);
                    uIACloseElementWindowpropCount++;
                }

                if (uIACloseElementWindowsortByColumn != null)
                {
                    uIACloseElementWindow["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIACloseElementWindowsortByColumn);
                    uIACloseElementWindowpropCount++;
                }

                if (uIACloseElementWindowmatchIndexAscending != null)
                {
                    if (uIACloseElementWindowmatchIndexAscending != null)
                    {
                        uIACloseElementWindow["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIACloseElementWindowmatchIndexAscending);
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
                        uIACloseElementWindow["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIACloseElementWindowmaxElementsToSearch);
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
                        uIACloseElementWindow["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIACloseElementWindowmaxRelativeSearchDepth);
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
                        uIACloseElementWindow["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIACloseElementWindowmaxChildElementsToSearchPerNode);
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
                    uIACloseElementWindow["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIACloseElementWindowelementLocalizedControlTypesNotToTraverse);
                    uIACloseElementWindowpropCount++;
                }

                uIACloseElementWindowpropCount++;
                uIACloseElementWindow["Workflow"] = SourceExpressionConverter.ConvertToken(uIACloseElementWindowworkflow);
                if (uIACloseElementWindowpropCount > 0)
                {
                    callPayload.Body = uIACloseElementWindow;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementTextValueResponse> UIAGetElementTextValue([WorkflowExpression] Func<int> uIAGetElementTextValueparentWindowHandle, [WorkflowExpression] Func<string> uIAGetElementTextValueworkflow, [WorkflowExpression] Func<string> uIAGetElementTextValuesearchElementName = null, [WorkflowExpression] Func<string> uIAGetElementTextValuesearchElementClassName = null, [WorkflowExpression] Func<string> uIAGetElementTextValuesearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGetElementTextValuesearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGetElementTextValuesearchSubTree = null, [WorkflowExpression] Func<int> uIAGetElementTextValuematchIndex = null, [WorkflowExpression] Func<string> uIAGetElementTextValuesearchFilter = null, [WorkflowExpression] Func<string> uIAGetElementTextValuesortByColumn = null, [WorkflowExpression] Func<bool> uIAGetElementTextValuematchIndexAscending = null, [WorkflowExpression] Func<int> uIAGetElementTextValuemaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGetElementTextValuemaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGetElementTextValuemaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGetElementTextValueelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/GetElementTextValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetElementTextValue = new JObject();
                var uIAGetElementTextValuepropCount = 0;
                uIAGetElementTextValuepropCount++;
                uIAGetElementTextValue["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAGetElementTextValueparentWindowHandle);
                if (uIAGetElementTextValuesearchElementName != null)
                {
                    uIAGetElementTextValue["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAGetElementTextValuesearchElementName);
                    uIAGetElementTextValuepropCount++;
                }

                if (uIAGetElementTextValuesearchElementClassName != null)
                {
                    uIAGetElementTextValue["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAGetElementTextValuesearchElementClassName);
                    uIAGetElementTextValuepropCount++;
                }

                if (uIAGetElementTextValuesearchElementAutomationId != null)
                {
                    uIAGetElementTextValue["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAGetElementTextValuesearchElementAutomationId);
                    uIAGetElementTextValuepropCount++;
                }

                if (uIAGetElementTextValuesearchLocalizedControlType != null)
                {
                    uIAGetElementTextValue["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAGetElementTextValuesearchLocalizedControlType);
                    uIAGetElementTextValuepropCount++;
                }

                if (uIAGetElementTextValuesearchSubTree != null)
                {
                    if (uIAGetElementTextValuesearchSubTree != null)
                    {
                        uIAGetElementTextValue["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAGetElementTextValuesearchSubTree);
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
                        uIAGetElementTextValue["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAGetElementTextValuematchIndex);
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
                    uIAGetElementTextValue["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAGetElementTextValuesearchFilter);
                    uIAGetElementTextValuepropCount++;
                }

                if (uIAGetElementTextValuesortByColumn != null)
                {
                    uIAGetElementTextValue["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAGetElementTextValuesortByColumn);
                    uIAGetElementTextValuepropCount++;
                }

                if (uIAGetElementTextValuematchIndexAscending != null)
                {
                    if (uIAGetElementTextValuematchIndexAscending != null)
                    {
                        uIAGetElementTextValue["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAGetElementTextValuematchIndexAscending);
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
                        uIAGetElementTextValue["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAGetElementTextValuemaxElementsToSearch);
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
                        uIAGetElementTextValue["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAGetElementTextValuemaxRelativeSearchDepth);
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
                        uIAGetElementTextValue["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAGetElementTextValuemaxChildElementsToSearchPerNode);
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
                    uIAGetElementTextValue["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAGetElementTextValueelementLocalizedControlTypesNotToTraverse);
                    uIAGetElementTextValuepropCount++;
                }

                uIAGetElementTextValuepropCount++;
                uIAGetElementTextValue["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetElementTextValueworkflow);
                if (uIAGetElementTextValuepropCount > 0)
                {
                    callPayload.Body = uIAGetElementTextValue;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetElementTextValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementValueResponse> UIAGetElementValue([WorkflowExpression] Func<int> uIAGetElementValueparentWindowHandle, [WorkflowExpression] Func<string> uIAGetElementValueworkflow, [WorkflowExpression] Func<string> uIAGetElementValuesearchElementName = null, [WorkflowExpression] Func<string> uIAGetElementValuesearchElementClassName = null, [WorkflowExpression] Func<string> uIAGetElementValuesearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGetElementValuesearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGetElementValuesearchSubTree = null, [WorkflowExpression] Func<int> uIAGetElementValuematchIndex = null, [WorkflowExpression] Func<string> uIAGetElementValuesearchFilter = null, [WorkflowExpression] Func<string> uIAGetElementValuesortByColumn = null, [WorkflowExpression] Func<bool> uIAGetElementValuematchIndexAscending = null, [WorkflowExpression] Func<int> uIAGetElementValuemaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGetElementValuemaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGetElementValuemaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGetElementValueelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/GetElementValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetElementValue = new JObject();
                var uIAGetElementValuepropCount = 0;
                uIAGetElementValuepropCount++;
                uIAGetElementValue["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAGetElementValueparentWindowHandle);
                if (uIAGetElementValuesearchElementName != null)
                {
                    uIAGetElementValue["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAGetElementValuesearchElementName);
                    uIAGetElementValuepropCount++;
                }

                if (uIAGetElementValuesearchElementClassName != null)
                {
                    uIAGetElementValue["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAGetElementValuesearchElementClassName);
                    uIAGetElementValuepropCount++;
                }

                if (uIAGetElementValuesearchElementAutomationId != null)
                {
                    uIAGetElementValue["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAGetElementValuesearchElementAutomationId);
                    uIAGetElementValuepropCount++;
                }

                if (uIAGetElementValuesearchLocalizedControlType != null)
                {
                    uIAGetElementValue["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAGetElementValuesearchLocalizedControlType);
                    uIAGetElementValuepropCount++;
                }

                if (uIAGetElementValuesearchSubTree != null)
                {
                    if (uIAGetElementValuesearchSubTree != null)
                    {
                        uIAGetElementValue["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAGetElementValuesearchSubTree);
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
                        uIAGetElementValue["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAGetElementValuematchIndex);
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
                    uIAGetElementValue["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAGetElementValuesearchFilter);
                    uIAGetElementValuepropCount++;
                }

                if (uIAGetElementValuesortByColumn != null)
                {
                    uIAGetElementValue["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAGetElementValuesortByColumn);
                    uIAGetElementValuepropCount++;
                }

                if (uIAGetElementValuematchIndexAscending != null)
                {
                    if (uIAGetElementValuematchIndexAscending != null)
                    {
                        uIAGetElementValue["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAGetElementValuematchIndexAscending);
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
                        uIAGetElementValue["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAGetElementValuemaxElementsToSearch);
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
                        uIAGetElementValue["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAGetElementValuemaxRelativeSearchDepth);
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
                        uIAGetElementValue["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAGetElementValuemaxChildElementsToSearchPerNode);
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
                    uIAGetElementValue["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAGetElementValueelementLocalizedControlTypesNotToTraverse);
                    uIAGetElementValuepropCount++;
                }

                uIAGetElementValuepropCount++;
                uIAGetElementValue["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetElementValueworkflow);
                if (uIAGetElementValuepropCount > 0)
                {
                    callPayload.Body = uIAGetElementValue;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetElementValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementLabelValueResponse> UIAGetElementLabelValue([WorkflowExpression] Func<int> uIAGetElementLabelValueparentWindowHandle, [WorkflowExpression] Func<string> uIAGetElementLabelValueworkflow, [WorkflowExpression] Func<string> uIAGetElementLabelValuesearchElementName = null, [WorkflowExpression] Func<string> uIAGetElementLabelValuesearchElementClassName = null, [WorkflowExpression] Func<string> uIAGetElementLabelValuesearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGetElementLabelValuesearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGetElementLabelValuesearchSubTree = null, [WorkflowExpression] Func<int> uIAGetElementLabelValuematchIndex = null, [WorkflowExpression] Func<string> uIAGetElementLabelValuesearchFilter = null, [WorkflowExpression] Func<string> uIAGetElementLabelValuesortByColumn = null, [WorkflowExpression] Func<bool> uIAGetElementLabelValuematchIndexAscending = null, [WorkflowExpression] Func<int> uIAGetElementLabelValuemaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGetElementLabelValuemaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGetElementLabelValuemaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGetElementLabelValueelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/GetElementLabelValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetElementLabelValue = new JObject();
                var uIAGetElementLabelValuepropCount = 0;
                uIAGetElementLabelValuepropCount++;
                uIAGetElementLabelValue["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAGetElementLabelValueparentWindowHandle);
                if (uIAGetElementLabelValuesearchElementName != null)
                {
                    uIAGetElementLabelValue["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAGetElementLabelValuesearchElementName);
                    uIAGetElementLabelValuepropCount++;
                }

                if (uIAGetElementLabelValuesearchElementClassName != null)
                {
                    uIAGetElementLabelValue["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAGetElementLabelValuesearchElementClassName);
                    uIAGetElementLabelValuepropCount++;
                }

                if (uIAGetElementLabelValuesearchElementAutomationId != null)
                {
                    uIAGetElementLabelValue["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAGetElementLabelValuesearchElementAutomationId);
                    uIAGetElementLabelValuepropCount++;
                }

                if (uIAGetElementLabelValuesearchLocalizedControlType != null)
                {
                    uIAGetElementLabelValue["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAGetElementLabelValuesearchLocalizedControlType);
                    uIAGetElementLabelValuepropCount++;
                }

                if (uIAGetElementLabelValuesearchSubTree != null)
                {
                    if (uIAGetElementLabelValuesearchSubTree != null)
                    {
                        uIAGetElementLabelValue["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAGetElementLabelValuesearchSubTree);
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
                        uIAGetElementLabelValue["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAGetElementLabelValuematchIndex);
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
                    uIAGetElementLabelValue["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAGetElementLabelValuesearchFilter);
                    uIAGetElementLabelValuepropCount++;
                }

                if (uIAGetElementLabelValuesortByColumn != null)
                {
                    uIAGetElementLabelValue["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAGetElementLabelValuesortByColumn);
                    uIAGetElementLabelValuepropCount++;
                }

                if (uIAGetElementLabelValuematchIndexAscending != null)
                {
                    if (uIAGetElementLabelValuematchIndexAscending != null)
                    {
                        uIAGetElementLabelValue["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAGetElementLabelValuematchIndexAscending);
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
                        uIAGetElementLabelValue["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAGetElementLabelValuemaxElementsToSearch);
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
                        uIAGetElementLabelValue["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAGetElementLabelValuemaxRelativeSearchDepth);
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
                        uIAGetElementLabelValue["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAGetElementLabelValuemaxChildElementsToSearchPerNode);
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
                    uIAGetElementLabelValue["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAGetElementLabelValueelementLocalizedControlTypesNotToTraverse);
                    uIAGetElementLabelValuepropCount++;
                }

                uIAGetElementLabelValuepropCount++;
                uIAGetElementLabelValue["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetElementLabelValueworkflow);
                if (uIAGetElementLabelValuepropCount > 0)
                {
                    callPayload.Body = uIAGetElementLabelValue;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetElementLabelValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementPropertiesResponse> UIAGetElementProperties([WorkflowExpression] Func<int> uIAGetElementPropertiesparentWindowHandle, [WorkflowExpression] Func<string> uIAGetElementPropertiesworkflow, [WorkflowExpression] Func<string> uIAGetElementPropertiessearchElementName = null, [WorkflowExpression] Func<string> uIAGetElementPropertiessearchElementClassName = null, [WorkflowExpression] Func<string> uIAGetElementPropertiessearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGetElementPropertiessearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGetElementPropertiessearchSubTree = null, [WorkflowExpression] Func<bool> uIAGetElementPropertiesreturnElementHandle = null, [WorkflowExpression] Func<bool> uIAGetElementPropertiesreturnElementValue = null, [WorkflowExpression] Func<int> uIAGetElementPropertiesmatchIndex = null, [WorkflowExpression] Func<string> uIAGetElementPropertiessearchFilter = null, [WorkflowExpression] Func<string> uIAGetElementPropertiessortByColumn = null, [WorkflowExpression] Func<bool> uIAGetElementPropertiesmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAGetElementPropertiesmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGetElementPropertiesmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGetElementPropertiesmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGetElementPropertieselementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIAGetElementPropertiesvalidateClickablePointWithinElementBoundary = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/GetElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetElementProperties = new JObject();
                var uIAGetElementPropertiespropCount = 0;
                uIAGetElementPropertiespropCount++;
                uIAGetElementProperties["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAGetElementPropertiesparentWindowHandle);
                if (uIAGetElementPropertiessearchElementName != null)
                {
                    uIAGetElementProperties["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAGetElementPropertiessearchElementName);
                    uIAGetElementPropertiespropCount++;
                }

                if (uIAGetElementPropertiessearchElementClassName != null)
                {
                    uIAGetElementProperties["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAGetElementPropertiessearchElementClassName);
                    uIAGetElementPropertiespropCount++;
                }

                if (uIAGetElementPropertiessearchElementAutomationId != null)
                {
                    uIAGetElementProperties["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAGetElementPropertiessearchElementAutomationId);
                    uIAGetElementPropertiespropCount++;
                }

                if (uIAGetElementPropertiessearchLocalizedControlType != null)
                {
                    uIAGetElementProperties["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAGetElementPropertiessearchLocalizedControlType);
                    uIAGetElementPropertiespropCount++;
                }

                if (uIAGetElementPropertiessearchSubTree != null)
                {
                    if (uIAGetElementPropertiessearchSubTree != null)
                    {
                        uIAGetElementProperties["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAGetElementPropertiessearchSubTree);
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
                        uIAGetElementProperties["ReturnElementHandle"] = SourceExpressionConverter.ConvertToken(uIAGetElementPropertiesreturnElementHandle);
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
                        uIAGetElementProperties["ReturnElementValue"] = SourceExpressionConverter.ConvertToken(uIAGetElementPropertiesreturnElementValue);
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
                        uIAGetElementProperties["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAGetElementPropertiesmatchIndex);
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
                    uIAGetElementProperties["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAGetElementPropertiessearchFilter);
                    uIAGetElementPropertiespropCount++;
                }

                if (uIAGetElementPropertiessortByColumn != null)
                {
                    uIAGetElementProperties["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAGetElementPropertiessortByColumn);
                    uIAGetElementPropertiespropCount++;
                }

                if (uIAGetElementPropertiesmatchIndexAscending != null)
                {
                    if (uIAGetElementPropertiesmatchIndexAscending != null)
                    {
                        uIAGetElementProperties["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAGetElementPropertiesmatchIndexAscending);
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
                        uIAGetElementProperties["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAGetElementPropertiesmaxElementsToSearch);
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
                        uIAGetElementProperties["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAGetElementPropertiesmaxRelativeSearchDepth);
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
                        uIAGetElementProperties["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAGetElementPropertiesmaxChildElementsToSearchPerNode);
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
                    uIAGetElementProperties["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAGetElementPropertieselementLocalizedControlTypesNotToTraverse);
                    uIAGetElementPropertiespropCount++;
                }

                if (uIAGetElementPropertiesvalidateClickablePointWithinElementBoundary != null)
                {
                    if (uIAGetElementPropertiesvalidateClickablePointWithinElementBoundary != null)
                    {
                        uIAGetElementProperties["ValidateClickablePointWithinElementBoundary"] = SourceExpressionConverter.ConvertToken(uIAGetElementPropertiesvalidateClickablePointWithinElementBoundary);
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
                uIAGetElementProperties["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetElementPropertiesworkflow);
                if (uIAGetElementPropertiespropCount > 0)
                {
                    callPayload.Body = uIAGetElementProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetElementPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetMultipleElementPropertiesResponse> UIAGetMultipleElementProperties([WorkflowExpression] Func<int> uIAGetMultipleElementPropertiesparentWindowHandle, [WorkflowExpression] Func<string> uIAGetMultipleElementPropertiesworkflow, [WorkflowExpression] Func<string> uIAGetMultipleElementPropertiessearchElementLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGetMultipleElementPropertiessearchDescendants = null, [WorkflowExpression] Func<bool> uIAGetMultipleElementPropertiesreturnElementHandle = null, [WorkflowExpression] Func<bool> uIAGetMultipleElementPropertiesreturnElementValue = null, [WorkflowExpression] Func<int> uIAGetMultipleElementPropertiesfirstItemToReturn = null, [WorkflowExpression] Func<int> uIAGetMultipleElementPropertiesmaxItemsToReturn = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/GetMultipleElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetMultipleElementProperties = new JObject();
                var uIAGetMultipleElementPropertiespropCount = 0;
                uIAGetMultipleElementPropertiespropCount++;
                uIAGetMultipleElementProperties["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementPropertiesparentWindowHandle);
                if (uIAGetMultipleElementPropertiessearchElementLocalizedControlType != null)
                {
                    uIAGetMultipleElementProperties["SearchElementLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementPropertiessearchElementLocalizedControlType);
                    uIAGetMultipleElementPropertiespropCount++;
                }

                if (uIAGetMultipleElementPropertiessearchDescendants != null)
                {
                    if (uIAGetMultipleElementPropertiessearchDescendants != null)
                    {
                        uIAGetMultipleElementProperties["SearchDescendants"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementPropertiessearchDescendants);
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
                        uIAGetMultipleElementProperties["ReturnElementHandle"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementPropertiesreturnElementHandle);
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
                        uIAGetMultipleElementProperties["ReturnElementValue"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementPropertiesreturnElementValue);
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
                        uIAGetMultipleElementProperties["FirstItemToReturn"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementPropertiesfirstItemToReturn);
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
                        uIAGetMultipleElementProperties["MaxItemsToReturn"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementPropertiesmaxItemsToReturn);
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
                uIAGetMultipleElementProperties["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementPropertiesworkflow);
                if (uIAGetMultipleElementPropertiespropCount > 0)
                {
                    callPayload.Body = uIAGetMultipleElementProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetMultipleElementPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetDesktopElementsResponse> UIAGetDesktopElements([WorkflowExpression] Func<string> uIAGetDesktopElementsworkflow, [WorkflowExpression] Func<string> uIAGetDesktopElementssearchElementLocalizedControlType = null, [WorkflowExpression] Func<int> uIAGetDesktopElementssearchProcessId = null, [WorkflowExpression] Func<bool> uIAGetDesktopElementsreturnElementHandle = null, [WorkflowExpression] Func<int> uIAGetDesktopElementsfirstItemToReturn = null, [WorkflowExpression] Func<int> uIAGetDesktopElementsmaxItemsToReturn = null, [WorkflowExpression] Func<bool> uIAGetDesktopElementsincludeChildProcesses = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/GetDesktopElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetDesktopElements = new JObject();
                var uIAGetDesktopElementspropCount = 0;
                if (uIAGetDesktopElementssearchElementLocalizedControlType != null)
                {
                    uIAGetDesktopElements["SearchElementLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAGetDesktopElementssearchElementLocalizedControlType);
                    uIAGetDesktopElementspropCount++;
                }

                if (uIAGetDesktopElementssearchProcessId != null)
                {
                    if (uIAGetDesktopElementssearchProcessId != null)
                    {
                        uIAGetDesktopElements["SearchProcessID"] = SourceExpressionConverter.ConvertToken(uIAGetDesktopElementssearchProcessId);
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
                        uIAGetDesktopElements["ReturnElementHandle"] = SourceExpressionConverter.ConvertToken(uIAGetDesktopElementsreturnElementHandle);
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
                        uIAGetDesktopElements["FirstItemToReturn"] = SourceExpressionConverter.ConvertToken(uIAGetDesktopElementsfirstItemToReturn);
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
                        uIAGetDesktopElements["MaxItemsToReturn"] = SourceExpressionConverter.ConvertToken(uIAGetDesktopElementsmaxItemsToReturn);
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
                        uIAGetDesktopElements["IncludeChildProcesses"] = SourceExpressionConverter.ConvertToken(uIAGetDesktopElementsincludeChildProcesses);
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
                uIAGetDesktopElements["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetDesktopElementsworkflow);
                if (uIAGetDesktopElementspropCount > 0)
                {
                    callPayload.Body = uIAGetDesktopElements;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetDesktopElementsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAExpandElement([WorkflowExpression] Func<int> uIAExpandElementparentWindowHandle, [WorkflowExpression] Func<string> uIAExpandElementworkflow, [WorkflowExpression] Func<string> uIAExpandElementsearchElementName = null, [WorkflowExpression] Func<string> uIAExpandElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAExpandElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAExpandElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAExpandElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAExpandElementmatchIndex = null, [WorkflowExpression] Func<string> uIAExpandElementsearchFilter = null, [WorkflowExpression] Func<string> uIAExpandElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAExpandElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAExpandElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAExpandElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAExpandElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAExpandElementelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/ExpandElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAExpandElement = new JObject();
                var uIAExpandElementpropCount = 0;
                uIAExpandElementpropCount++;
                uIAExpandElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAExpandElementparentWindowHandle);
                if (uIAExpandElementsearchElementName != null)
                {
                    uIAExpandElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAExpandElementsearchElementName);
                    uIAExpandElementpropCount++;
                }

                if (uIAExpandElementsearchElementClassName != null)
                {
                    uIAExpandElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAExpandElementsearchElementClassName);
                    uIAExpandElementpropCount++;
                }

                if (uIAExpandElementsearchElementAutomationId != null)
                {
                    uIAExpandElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAExpandElementsearchElementAutomationId);
                    uIAExpandElementpropCount++;
                }

                if (uIAExpandElementsearchLocalizedControlType != null)
                {
                    uIAExpandElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAExpandElementsearchLocalizedControlType);
                    uIAExpandElementpropCount++;
                }

                if (uIAExpandElementsearchSubTree != null)
                {
                    if (uIAExpandElementsearchSubTree != null)
                    {
                        uIAExpandElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAExpandElementsearchSubTree);
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
                        uIAExpandElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAExpandElementmatchIndex);
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
                    uIAExpandElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAExpandElementsearchFilter);
                    uIAExpandElementpropCount++;
                }

                if (uIAExpandElementsortByColumn != null)
                {
                    uIAExpandElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAExpandElementsortByColumn);
                    uIAExpandElementpropCount++;
                }

                if (uIAExpandElementmatchIndexAscending != null)
                {
                    if (uIAExpandElementmatchIndexAscending != null)
                    {
                        uIAExpandElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAExpandElementmatchIndexAscending);
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
                        uIAExpandElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAExpandElementmaxElementsToSearch);
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
                        uIAExpandElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAExpandElementmaxRelativeSearchDepth);
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
                        uIAExpandElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAExpandElementmaxChildElementsToSearchPerNode);
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
                    uIAExpandElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAExpandElementelementLocalizedControlTypesNotToTraverse);
                    uIAExpandElementpropCount++;
                }

                uIAExpandElementpropCount++;
                uIAExpandElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIAExpandElementworkflow);
                if (uIAExpandElementpropCount > 0)
                {
                    callPayload.Body = uIAExpandElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIACollapseElement([WorkflowExpression] Func<int> uIACollapseElementparentWindowHandle, [WorkflowExpression] Func<string> uIACollapseElementworkflow, [WorkflowExpression] Func<string> uIACollapseElementsearchElementName = null, [WorkflowExpression] Func<string> uIACollapseElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIACollapseElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIACollapseElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIACollapseElementsearchSubTree = null, [WorkflowExpression] Func<int> uIACollapseElementmatchIndex = null, [WorkflowExpression] Func<string> uIACollapseElementsearchFilter = null, [WorkflowExpression] Func<string> uIACollapseElementsortByColumn = null, [WorkflowExpression] Func<bool> uIACollapseElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIACollapseElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIACollapseElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIACollapseElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIACollapseElementelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/CollapseElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIACollapseElement = new JObject();
                var uIACollapseElementpropCount = 0;
                uIACollapseElementpropCount++;
                uIACollapseElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIACollapseElementparentWindowHandle);
                if (uIACollapseElementsearchElementName != null)
                {
                    uIACollapseElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIACollapseElementsearchElementName);
                    uIACollapseElementpropCount++;
                }

                if (uIACollapseElementsearchElementClassName != null)
                {
                    uIACollapseElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIACollapseElementsearchElementClassName);
                    uIACollapseElementpropCount++;
                }

                if (uIACollapseElementsearchElementAutomationId != null)
                {
                    uIACollapseElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIACollapseElementsearchElementAutomationId);
                    uIACollapseElementpropCount++;
                }

                if (uIACollapseElementsearchLocalizedControlType != null)
                {
                    uIACollapseElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIACollapseElementsearchLocalizedControlType);
                    uIACollapseElementpropCount++;
                }

                if (uIACollapseElementsearchSubTree != null)
                {
                    if (uIACollapseElementsearchSubTree != null)
                    {
                        uIACollapseElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIACollapseElementsearchSubTree);
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
                        uIACollapseElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIACollapseElementmatchIndex);
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
                    uIACollapseElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIACollapseElementsearchFilter);
                    uIACollapseElementpropCount++;
                }

                if (uIACollapseElementsortByColumn != null)
                {
                    uIACollapseElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIACollapseElementsortByColumn);
                    uIACollapseElementpropCount++;
                }

                if (uIACollapseElementmatchIndexAscending != null)
                {
                    if (uIACollapseElementmatchIndexAscending != null)
                    {
                        uIACollapseElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIACollapseElementmatchIndexAscending);
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
                        uIACollapseElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIACollapseElementmaxElementsToSearch);
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
                        uIACollapseElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIACollapseElementmaxRelativeSearchDepth);
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
                        uIACollapseElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIACollapseElementmaxChildElementsToSearchPerNode);
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
                    uIACollapseElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIACollapseElementelementLocalizedControlTypesNotToTraverse);
                    uIACollapseElementpropCount++;
                }

                uIACollapseElementpropCount++;
                uIACollapseElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIACollapseElementworkflow);
                if (uIACollapseElementpropCount > 0)
                {
                    callPayload.Body = uIACollapseElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIATakeScreenShotOfElementLocationResponse> UIATakeScreenShotOfElementLocation([WorkflowExpression] Func<int> uIATakeScreenShotOfElementLocationparentWindowHandle, [WorkflowExpression] Func<string> uIATakeScreenShotOfElementLocationworkflow, [WorkflowExpression] Func<string> uIATakeScreenShotOfElementLocationsearchElementName = null, [WorkflowExpression] Func<string> uIATakeScreenShotOfElementLocationsearchElementClassName = null, [WorkflowExpression] Func<string> uIATakeScreenShotOfElementLocationsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIATakeScreenShotOfElementLocationsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIATakeScreenShotOfElementLocationsearchSubTree = null, [WorkflowExpression] Func<uIATakeScreenShotOfElementLocationimageFormatInput> uIATakeScreenShotOfElementLocationimageFormat = null, [WorkflowExpression] Func<int> uIATakeScreenShotOfElementLocationmatchIndex = null, [WorkflowExpression] Func<string> uIATakeScreenShotOfElementLocationsearchFilter = null, [WorkflowExpression] Func<string> uIATakeScreenShotOfElementLocationsortByColumn = null, [WorkflowExpression] Func<bool> uIATakeScreenShotOfElementLocationmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIATakeScreenShotOfElementLocationhideAgent = null, [WorkflowExpression] Func<int> uIATakeScreenShotOfElementLocationmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIATakeScreenShotOfElementLocationmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIATakeScreenShotOfElementLocationmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIATakeScreenShotOfElementLocationelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/TakeScreenShotOfElementLocation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIATakeScreenShotOfElementLocation = new JObject();
                var uIATakeScreenShotOfElementLocationpropCount = 0;
                uIATakeScreenShotOfElementLocationpropCount++;
                uIATakeScreenShotOfElementLocation["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationparentWindowHandle);
                if (uIATakeScreenShotOfElementLocationsearchElementName != null)
                {
                    uIATakeScreenShotOfElementLocation["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationsearchElementName);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                if (uIATakeScreenShotOfElementLocationsearchElementClassName != null)
                {
                    uIATakeScreenShotOfElementLocation["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationsearchElementClassName);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                if (uIATakeScreenShotOfElementLocationsearchElementAutomationId != null)
                {
                    uIATakeScreenShotOfElementLocation["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationsearchElementAutomationId);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                if (uIATakeScreenShotOfElementLocationsearchLocalizedControlType != null)
                {
                    uIATakeScreenShotOfElementLocation["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationsearchLocalizedControlType);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                if (uIATakeScreenShotOfElementLocationsearchSubTree != null)
                {
                    if (uIATakeScreenShotOfElementLocationsearchSubTree != null)
                    {
                        uIATakeScreenShotOfElementLocation["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationsearchSubTree);
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
                    uIATakeScreenShotOfElementLocation["ImageFormat"] = SourceExpressionConverter.Convert(uIATakeScreenShotOfElementLocationimageFormat);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                if (uIATakeScreenShotOfElementLocationmatchIndex != null)
                {
                    if (uIATakeScreenShotOfElementLocationmatchIndex != null)
                    {
                        uIATakeScreenShotOfElementLocation["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationmatchIndex);
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
                    uIATakeScreenShotOfElementLocation["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationsearchFilter);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                if (uIATakeScreenShotOfElementLocationsortByColumn != null)
                {
                    uIATakeScreenShotOfElementLocation["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationsortByColumn);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                if (uIATakeScreenShotOfElementLocationmatchIndexAscending != null)
                {
                    if (uIATakeScreenShotOfElementLocationmatchIndexAscending != null)
                    {
                        uIATakeScreenShotOfElementLocation["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationmatchIndexAscending);
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
                        uIATakeScreenShotOfElementLocation["HideAgent"] = SourceExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationhideAgent);
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
                        uIATakeScreenShotOfElementLocation["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationmaxElementsToSearch);
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
                        uIATakeScreenShotOfElementLocation["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationmaxRelativeSearchDepth);
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
                        uIATakeScreenShotOfElementLocation["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationmaxChildElementsToSearchPerNode);
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
                    uIATakeScreenShotOfElementLocation["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationelementLocalizedControlTypesNotToTraverse);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                uIATakeScreenShotOfElementLocationpropCount++;
                uIATakeScreenShotOfElementLocation["Workflow"] = SourceExpressionConverter.ConvertToken(uIATakeScreenShotOfElementLocationworkflow);
                if (uIATakeScreenShotOfElementLocationpropCount > 0)
                {
                    callPayload.Body = uIATakeScreenShotOfElementLocation;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIATakeScreenShotOfElementLocationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIADrawRectangleAroundElement([WorkflowExpression] Func<int> uIADrawRectangleAroundElementparentWindowHandle, [WorkflowExpression] Func<string> uIADrawRectangleAroundElementworkflow, [WorkflowExpression] Func<string> uIADrawRectangleAroundElementsearchElementName = null, [WorkflowExpression] Func<string> uIADrawRectangleAroundElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIADrawRectangleAroundElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIADrawRectangleAroundElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIADrawRectangleAroundElementsearchSubTree = null, [WorkflowExpression] Func<string> uIADrawRectangleAroundElementpenColour = null, [WorkflowExpression] Func<int> uIADrawRectangleAroundElementpenThicknessPixels = null, [WorkflowExpression] Func<int> uIADrawRectangleAroundElementmatchIndex = null, [WorkflowExpression] Func<string> uIADrawRectangleAroundElementsearchFilter = null, [WorkflowExpression] Func<string> uIADrawRectangleAroundElementsortByColumn = null, [WorkflowExpression] Func<bool> uIADrawRectangleAroundElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIADrawRectangleAroundElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIADrawRectangleAroundElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIADrawRectangleAroundElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIADrawRectangleAroundElementelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/DrawRectangleAroundElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIADrawRectangleAroundElement = new JObject();
                var uIADrawRectangleAroundElementpropCount = 0;
                uIADrawRectangleAroundElementpropCount++;
                uIADrawRectangleAroundElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIADrawRectangleAroundElementparentWindowHandle);
                if (uIADrawRectangleAroundElementsearchElementName != null)
                {
                    uIADrawRectangleAroundElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIADrawRectangleAroundElementsearchElementName);
                    uIADrawRectangleAroundElementpropCount++;
                }

                if (uIADrawRectangleAroundElementsearchElementClassName != null)
                {
                    uIADrawRectangleAroundElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIADrawRectangleAroundElementsearchElementClassName);
                    uIADrawRectangleAroundElementpropCount++;
                }

                if (uIADrawRectangleAroundElementsearchElementAutomationId != null)
                {
                    uIADrawRectangleAroundElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIADrawRectangleAroundElementsearchElementAutomationId);
                    uIADrawRectangleAroundElementpropCount++;
                }

                if (uIADrawRectangleAroundElementsearchLocalizedControlType != null)
                {
                    uIADrawRectangleAroundElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIADrawRectangleAroundElementsearchLocalizedControlType);
                    uIADrawRectangleAroundElementpropCount++;
                }

                if (uIADrawRectangleAroundElementsearchSubTree != null)
                {
                    if (uIADrawRectangleAroundElementsearchSubTree != null)
                    {
                        uIADrawRectangleAroundElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIADrawRectangleAroundElementsearchSubTree);
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
                        uIADrawRectangleAroundElement["PenColour"] = SourceExpressionConverter.ConvertToken(uIADrawRectangleAroundElementpenColour);
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
                        uIADrawRectangleAroundElement["PenThicknessPixels"] = SourceExpressionConverter.ConvertToken(uIADrawRectangleAroundElementpenThicknessPixels);
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
                        uIADrawRectangleAroundElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIADrawRectangleAroundElementmatchIndex);
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
                    uIADrawRectangleAroundElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIADrawRectangleAroundElementsearchFilter);
                    uIADrawRectangleAroundElementpropCount++;
                }

                if (uIADrawRectangleAroundElementsortByColumn != null)
                {
                    uIADrawRectangleAroundElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIADrawRectangleAroundElementsortByColumn);
                    uIADrawRectangleAroundElementpropCount++;
                }

                if (uIADrawRectangleAroundElementmatchIndexAscending != null)
                {
                    if (uIADrawRectangleAroundElementmatchIndexAscending != null)
                    {
                        uIADrawRectangleAroundElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIADrawRectangleAroundElementmatchIndexAscending);
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
                        uIADrawRectangleAroundElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIADrawRectangleAroundElementmaxElementsToSearch);
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
                        uIADrawRectangleAroundElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIADrawRectangleAroundElementmaxRelativeSearchDepth);
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
                        uIADrawRectangleAroundElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIADrawRectangleAroundElementmaxChildElementsToSearchPerNode);
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
                    uIADrawRectangleAroundElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIADrawRectangleAroundElementelementLocalizedControlTypesNotToTraverse);
                    uIADrawRectangleAroundElementpropCount++;
                }

                uIADrawRectangleAroundElementpropCount++;
                uIADrawRectangleAroundElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIADrawRectangleAroundElementworkflow);
                if (uIADrawRectangleAroundElementpropCount > 0)
                {
                    callPayload.Body = uIADrawRectangleAroundElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetParentElementHandleResponse> UIAGetParentElementHandle([WorkflowExpression] Func<int> uIAGetParentElementHandleelementHandle, [WorkflowExpression] Func<string> uIAGetParentElementHandleworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/GetParentElementHandle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetParentElementHandle = new JObject();
                var uIAGetParentElementHandlepropCount = 0;
                uIAGetParentElementHandlepropCount++;
                uIAGetParentElementHandle["ElementHandle"] = SourceExpressionConverter.ConvertToken(uIAGetParentElementHandleelementHandle);
                uIAGetParentElementHandlepropCount++;
                uIAGetParentElementHandle["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetParentElementHandleworkflow);
                if (uIAGetParentElementHandlepropCount > 0)
                {
                    callPayload.Body = uIAGetParentElementHandle;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetParentElementHandleResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetDataGridElementContentsResponse> UIAGetDataGridElementContents([WorkflowExpression] Func<string> uIAGetDataGridElementContentsworkflow, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsparentWindowHandle = null, [WorkflowExpression] Func<string> uIAGetDataGridElementContentssearchElementName = null, [WorkflowExpression] Func<string> uIAGetDataGridElementContentssearchElementClassName = null, [WorkflowExpression] Func<string> uIAGetDataGridElementContentssearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGetDataGridElementContentssearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGetDataGridElementContentssearchSubTree = null, [WorkflowExpression] Func<bool> uIAGetDataGridElementContentsonScreenColumnsOnly = null, [WorkflowExpression] Func<bool> uIAGetDataGridElementContentsonScreenRowsOnly = null, [WorkflowExpression] Func<bool> uIAGetDataGridElementContentsreturnNullValuesAsBlank = null, [WorkflowExpression] Func<string> uIAGetDataGridElementContentsalternativeHeaderRowName = null, [WorkflowExpression] Func<bool> uIAGetDataGridElementContentsreturnRowUIAName = null, [WorkflowExpression] Func<string> uIAGetDataGridElementContentsnameOfColumnToStoreRowUIAName = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsmatchIndex = null, [WorkflowExpression] Func<string> uIAGetDataGridElementContentssearchFilter = null, [WorkflowExpression] Func<string> uIAGetDataGridElementContentssortByColumn = null, [WorkflowExpression] Func<bool> uIAGetDataGridElementContentsmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsfirstItemToReturn = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsmaxItemsToReturn = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsscanFirstNRowsForEmptyRows = null, [WorkflowExpression] Func<bool> uIAGetDataGridElementContentsreadTableAsThread = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentssecondsToWaitForThread = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNPercent = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNRows = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsscrollDataGridVerticallyElementHandle = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsminimumDataGridRowsForScrolling = null, [WorkflowExpression] Func<bool> uIAGetDataGridElementContentsraiseExceptionIfCannotScroll = null, [WorkflowExpression] Func<string> uIAGetDataGridElementContentsalternativeVerticalScrollbarName = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGetDataGridElementContentsmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGetDataGridElementContentselementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/GetDataGridElementContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetDataGridElementContents = new JObject();
                var uIAGetDataGridElementContentspropCount = 0;
                if (uIAGetDataGridElementContentsparentWindowHandle != null)
                {
                    uIAGetDataGridElementContents["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsparentWindowHandle);
                    uIAGetDataGridElementContentspropCount++;
                }

                if (uIAGetDataGridElementContentssearchElementName != null)
                {
                    uIAGetDataGridElementContents["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentssearchElementName);
                    uIAGetDataGridElementContentspropCount++;
                }

                if (uIAGetDataGridElementContentssearchElementClassName != null)
                {
                    uIAGetDataGridElementContents["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentssearchElementClassName);
                    uIAGetDataGridElementContentspropCount++;
                }

                if (uIAGetDataGridElementContentssearchElementAutomationId != null)
                {
                    uIAGetDataGridElementContents["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentssearchElementAutomationId);
                    uIAGetDataGridElementContentspropCount++;
                }

                if (uIAGetDataGridElementContentssearchLocalizedControlType != null)
                {
                    uIAGetDataGridElementContents["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentssearchLocalizedControlType);
                    uIAGetDataGridElementContentspropCount++;
                }

                if (uIAGetDataGridElementContentssearchSubTree != null)
                {
                    if (uIAGetDataGridElementContentssearchSubTree != null)
                    {
                        uIAGetDataGridElementContents["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentssearchSubTree);
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
                        uIAGetDataGridElementContents["OnScreenColumnsOnly"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsonScreenColumnsOnly);
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
                        uIAGetDataGridElementContents["OnScreenRowsOnly"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsonScreenRowsOnly);
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
                        uIAGetDataGridElementContents["ReturnNullValuesAsBlank"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsreturnNullValuesAsBlank);
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
                    uIAGetDataGridElementContents["AlternativeHeaderRowName"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsalternativeHeaderRowName);
                    uIAGetDataGridElementContentspropCount++;
                }

                if (uIAGetDataGridElementContentsreturnRowUIAName != null)
                {
                    if (uIAGetDataGridElementContentsreturnRowUIAName != null)
                    {
                        uIAGetDataGridElementContents["ReturnRowUIAName"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsreturnRowUIAName);
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
                    uIAGetDataGridElementContents["NameOfColumnToStoreRowUIAName"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsnameOfColumnToStoreRowUIAName);
                    uIAGetDataGridElementContentspropCount++;
                }

                if (uIAGetDataGridElementContentsmatchIndex != null)
                {
                    if (uIAGetDataGridElementContentsmatchIndex != null)
                    {
                        uIAGetDataGridElementContents["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsmatchIndex);
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
                    uIAGetDataGridElementContents["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentssearchFilter);
                    uIAGetDataGridElementContentspropCount++;
                }

                if (uIAGetDataGridElementContentssortByColumn != null)
                {
                    uIAGetDataGridElementContents["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentssortByColumn);
                    uIAGetDataGridElementContentspropCount++;
                }

                if (uIAGetDataGridElementContentsmatchIndexAscending != null)
                {
                    if (uIAGetDataGridElementContentsmatchIndexAscending != null)
                    {
                        uIAGetDataGridElementContents["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsmatchIndexAscending);
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
                        uIAGetDataGridElementContents["FirstItemToReturn"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsfirstItemToReturn);
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
                        uIAGetDataGridElementContents["MaxItemsToReturn"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsmaxItemsToReturn);
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
                        uIAGetDataGridElementContents["ScanFirstNRowsForEmptyRows"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsscanFirstNRowsForEmptyRows);
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
                        uIAGetDataGridElementContents["ReadTableAsThread"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsreadTableAsThread);
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
                    uIAGetDataGridElementContents["RetrieveOutputDataFromThreadId"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsretrieveOutputDataFromThreadId);
                    uIAGetDataGridElementContentspropCount++;
                }

                if (uIAGetDataGridElementContentssecondsToWaitForThread != null)
                {
                    if (uIAGetDataGridElementContentssecondsToWaitForThread != null)
                    {
                        uIAGetDataGridElementContents["SecondsToWaitForThread"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentssecondsToWaitForThread);
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
                        uIAGetDataGridElementContents["ScrollDataGridVerticallyEveryNPercent"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNPercent);
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
                        uIAGetDataGridElementContents["ScrollDataGridVerticallyEveryNRows"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNRows);
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
                        uIAGetDataGridElementContents["ScrollDataGridVerticallyElementHandle"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsscrollDataGridVerticallyElementHandle);
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
                        uIAGetDataGridElementContents["MinimumDataGridRowsForScrolling"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsminimumDataGridRowsForScrolling);
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
                        uIAGetDataGridElementContents["RaiseExceptionIfCannotScroll"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsraiseExceptionIfCannotScroll);
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
                    uIAGetDataGridElementContents["AlternativeVerticalScrollbarName"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsalternativeVerticalScrollbarName);
                    uIAGetDataGridElementContentspropCount++;
                }

                if (uIAGetDataGridElementContentsmaxElementsToSearch != null)
                {
                    if (uIAGetDataGridElementContentsmaxElementsToSearch != null)
                    {
                        uIAGetDataGridElementContents["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsmaxElementsToSearch);
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
                        uIAGetDataGridElementContents["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsmaxRelativeSearchDepth);
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
                        uIAGetDataGridElementContents["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsmaxChildElementsToSearchPerNode);
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
                    uIAGetDataGridElementContents["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentselementLocalizedControlTypesNotToTraverse);
                    uIAGetDataGridElementContentspropCount++;
                }

                uIAGetDataGridElementContentspropCount++;
                uIAGetDataGridElementContents["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementContentsworkflow);
                if (uIAGetDataGridElementContentspropCount > 0)
                {
                    callPayload.Body = uIAGetDataGridElementContents;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetDataGridElementContentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetDataGridElementPropertiesResponse> UIAGetDataGridElementProperties([WorkflowExpression] Func<int> uIAGetDataGridElementPropertiesparentWindowHandle, [WorkflowExpression] Func<string> uIAGetDataGridElementPropertiesworkflow, [WorkflowExpression] Func<string> uIAGetDataGridElementPropertiessearchElementName = null, [WorkflowExpression] Func<string> uIAGetDataGridElementPropertiessearchElementClassName = null, [WorkflowExpression] Func<string> uIAGetDataGridElementPropertiessearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGetDataGridElementPropertiessearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGetDataGridElementPropertiessearchSubTree = null, [WorkflowExpression] Func<string> uIAGetDataGridElementPropertiesalternativeHeaderRowName = null, [WorkflowExpression] Func<int> uIAGetDataGridElementPropertiesmatchIndex = null, [WorkflowExpression] Func<string> uIAGetDataGridElementPropertiessearchFilter = null, [WorkflowExpression] Func<string> uIAGetDataGridElementPropertiessortByColumn = null, [WorkflowExpression] Func<bool> uIAGetDataGridElementPropertiesmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAGetDataGridElementPropertiesmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGetDataGridElementPropertiesmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGetDataGridElementPropertiesmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGetDataGridElementPropertieselementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/GetDataGridElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetDataGridElementProperties = new JObject();
                var uIAGetDataGridElementPropertiespropCount = 0;
                uIAGetDataGridElementPropertiespropCount++;
                uIAGetDataGridElementProperties["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiesparentWindowHandle);
                if (uIAGetDataGridElementPropertiessearchElementName != null)
                {
                    uIAGetDataGridElementProperties["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiessearchElementName);
                    uIAGetDataGridElementPropertiespropCount++;
                }

                if (uIAGetDataGridElementPropertiessearchElementClassName != null)
                {
                    uIAGetDataGridElementProperties["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiessearchElementClassName);
                    uIAGetDataGridElementPropertiespropCount++;
                }

                if (uIAGetDataGridElementPropertiessearchElementAutomationId != null)
                {
                    uIAGetDataGridElementProperties["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiessearchElementAutomationId);
                    uIAGetDataGridElementPropertiespropCount++;
                }

                if (uIAGetDataGridElementPropertiessearchLocalizedControlType != null)
                {
                    uIAGetDataGridElementProperties["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiessearchLocalizedControlType);
                    uIAGetDataGridElementPropertiespropCount++;
                }

                if (uIAGetDataGridElementPropertiessearchSubTree != null)
                {
                    if (uIAGetDataGridElementPropertiessearchSubTree != null)
                    {
                        uIAGetDataGridElementProperties["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiessearchSubTree);
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
                    uIAGetDataGridElementProperties["AlternativeHeaderRowName"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiesalternativeHeaderRowName);
                    uIAGetDataGridElementPropertiespropCount++;
                }

                if (uIAGetDataGridElementPropertiesmatchIndex != null)
                {
                    if (uIAGetDataGridElementPropertiesmatchIndex != null)
                    {
                        uIAGetDataGridElementProperties["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiesmatchIndex);
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
                    uIAGetDataGridElementProperties["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiessearchFilter);
                    uIAGetDataGridElementPropertiespropCount++;
                }

                if (uIAGetDataGridElementPropertiessortByColumn != null)
                {
                    uIAGetDataGridElementProperties["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiessortByColumn);
                    uIAGetDataGridElementPropertiespropCount++;
                }

                if (uIAGetDataGridElementPropertiesmatchIndexAscending != null)
                {
                    if (uIAGetDataGridElementPropertiesmatchIndexAscending != null)
                    {
                        uIAGetDataGridElementProperties["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiesmatchIndexAscending);
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
                        uIAGetDataGridElementProperties["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiesmaxElementsToSearch);
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
                        uIAGetDataGridElementProperties["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiesmaxRelativeSearchDepth);
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
                        uIAGetDataGridElementProperties["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiesmaxChildElementsToSearchPerNode);
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
                    uIAGetDataGridElementProperties["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementPropertieselementLocalizedControlTypesNotToTraverse);
                    uIAGetDataGridElementPropertiespropCount++;
                }

                uIAGetDataGridElementPropertiespropCount++;
                uIAGetDataGridElementProperties["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetDataGridElementPropertiesworkflow);
                if (uIAGetDataGridElementPropertiespropCount > 0)
                {
                    callPayload.Body = uIAGetDataGridElementProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetDataGridElementPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetListElementItemsResponse> UIAGetListElementItems([WorkflowExpression] Func<int> uIAGetListElementItemsparentWindowHandle, [WorkflowExpression] Func<string> uIAGetListElementItemsworkflow, [WorkflowExpression] Func<string> uIAGetListElementItemssearchElementName = null, [WorkflowExpression] Func<string> uIAGetListElementItemssearchElementClassName = null, [WorkflowExpression] Func<string> uIAGetListElementItemssearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGetListElementItemssearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGetListElementItemssearchSubTree = null, [WorkflowExpression] Func<bool> uIAGetListElementItemsexpandFirst = null, [WorkflowExpression] Func<bool> uIAGetListElementItemscollapseAfter = null, [WorkflowExpression] Func<bool> uIAGetListElementItemscheckForSelectedItems = null, [WorkflowExpression] Func<double> uIAGetListElementItemssecondsBetweenExpandCollapse = null, [WorkflowExpression] Func<int> uIAGetListElementItemsmatchIndex = null, [WorkflowExpression] Func<string> uIAGetListElementItemssearchFilter = null, [WorkflowExpression] Func<string> uIAGetListElementItemssortByColumn = null, [WorkflowExpression] Func<bool> uIAGetListElementItemsmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAGetListElementItemsmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGetListElementItemsmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGetListElementItemsmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGetListElementItemselementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/GetListElementItems";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetListElementItems = new JObject();
                var uIAGetListElementItemspropCount = 0;
                uIAGetListElementItemspropCount++;
                uIAGetListElementItems["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAGetListElementItemsparentWindowHandle);
                if (uIAGetListElementItemssearchElementName != null)
                {
                    uIAGetListElementItems["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAGetListElementItemssearchElementName);
                    uIAGetListElementItemspropCount++;
                }

                if (uIAGetListElementItemssearchElementClassName != null)
                {
                    uIAGetListElementItems["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAGetListElementItemssearchElementClassName);
                    uIAGetListElementItemspropCount++;
                }

                if (uIAGetListElementItemssearchElementAutomationId != null)
                {
                    uIAGetListElementItems["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAGetListElementItemssearchElementAutomationId);
                    uIAGetListElementItemspropCount++;
                }

                if (uIAGetListElementItemssearchLocalizedControlType != null)
                {
                    uIAGetListElementItems["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAGetListElementItemssearchLocalizedControlType);
                    uIAGetListElementItemspropCount++;
                }

                if (uIAGetListElementItemssearchSubTree != null)
                {
                    if (uIAGetListElementItemssearchSubTree != null)
                    {
                        uIAGetListElementItems["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAGetListElementItemssearchSubTree);
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
                        uIAGetListElementItems["ExpandFirst"] = SourceExpressionConverter.ConvertToken(uIAGetListElementItemsexpandFirst);
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
                        uIAGetListElementItems["CollapseAfter"] = SourceExpressionConverter.ConvertToken(uIAGetListElementItemscollapseAfter);
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
                        uIAGetListElementItems["CheckForSelectedItems"] = SourceExpressionConverter.ConvertToken(uIAGetListElementItemscheckForSelectedItems);
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
                        uIAGetListElementItems["SecondsBetweenExpandCollapse"] = SourceExpressionConverter.ConvertToken(uIAGetListElementItemssecondsBetweenExpandCollapse);
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
                        uIAGetListElementItems["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAGetListElementItemsmatchIndex);
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
                    uIAGetListElementItems["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAGetListElementItemssearchFilter);
                    uIAGetListElementItemspropCount++;
                }

                if (uIAGetListElementItemssortByColumn != null)
                {
                    uIAGetListElementItems["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAGetListElementItemssortByColumn);
                    uIAGetListElementItemspropCount++;
                }

                if (uIAGetListElementItemsmatchIndexAscending != null)
                {
                    if (uIAGetListElementItemsmatchIndexAscending != null)
                    {
                        uIAGetListElementItems["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAGetListElementItemsmatchIndexAscending);
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
                        uIAGetListElementItems["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAGetListElementItemsmaxElementsToSearch);
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
                        uIAGetListElementItems["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAGetListElementItemsmaxRelativeSearchDepth);
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
                        uIAGetListElementItems["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAGetListElementItemsmaxChildElementsToSearchPerNode);
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
                    uIAGetListElementItems["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAGetListElementItemselementLocalizedControlTypesNotToTraverse);
                    uIAGetListElementItemspropCount++;
                }

                uIAGetListElementItemspropCount++;
                uIAGetListElementItems["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetListElementItemsworkflow);
                if (uIAGetListElementItemspropCount > 0)
                {
                    callPayload.Body = uIAGetListElementItems;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetListElementItemsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAClickListElementItemByName([WorkflowExpression] Func<int> uIAClickListElementItemByNameparentWindowHandle, [WorkflowExpression] Func<string> uIAClickListElementItemByNameworkflow, [WorkflowExpression] Func<string> uIAClickListElementItemByNamesearchElementName = null, [WorkflowExpression] Func<string> uIAClickListElementItemByNamesearchElementClassName = null, [WorkflowExpression] Func<string> uIAClickListElementItemByNamesearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAClickListElementItemByNamesearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAClickListElementItemByNamesearchSubTree = null, [WorkflowExpression] Func<bool> uIAClickListElementItemByNameexpandFirst = null, [WorkflowExpression] Func<bool> uIAClickListElementItemByNamecollapseAfter = null, [WorkflowExpression] Func<string> uIAClickListElementItemByNameitemName = null, [WorkflowExpression] Func<double> uIAClickListElementItemByNamesecondsBetweenExpandCollapse = null, [WorkflowExpression] Func<int> uIAClickListElementItemByNamematchIndex = null, [WorkflowExpression] Func<string> uIAClickListElementItemByNamesearchFilter = null, [WorkflowExpression] Func<string> uIAClickListElementItemByNamesortByColumn = null, [WorkflowExpression] Func<bool> uIAClickListElementItemByNamematchIndexAscending = null, [WorkflowExpression] Func<int> uIAClickListElementItemByNamemaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAClickListElementItemByNamemaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAClickListElementItemByNamemaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAClickListElementItemByNameelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/ClickListElementItemByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAClickListElementItemByName = new JObject();
                var uIAClickListElementItemByNamepropCount = 0;
                uIAClickListElementItemByNamepropCount++;
                uIAClickListElementItemByName["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByNameparentWindowHandle);
                if (uIAClickListElementItemByNamesearchElementName != null)
                {
                    uIAClickListElementItemByName["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByNamesearchElementName);
                    uIAClickListElementItemByNamepropCount++;
                }

                if (uIAClickListElementItemByNamesearchElementClassName != null)
                {
                    uIAClickListElementItemByName["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByNamesearchElementClassName);
                    uIAClickListElementItemByNamepropCount++;
                }

                if (uIAClickListElementItemByNamesearchElementAutomationId != null)
                {
                    uIAClickListElementItemByName["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByNamesearchElementAutomationId);
                    uIAClickListElementItemByNamepropCount++;
                }

                if (uIAClickListElementItemByNamesearchLocalizedControlType != null)
                {
                    uIAClickListElementItemByName["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByNamesearchLocalizedControlType);
                    uIAClickListElementItemByNamepropCount++;
                }

                if (uIAClickListElementItemByNamesearchSubTree != null)
                {
                    if (uIAClickListElementItemByNamesearchSubTree != null)
                    {
                        uIAClickListElementItemByName["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByNamesearchSubTree);
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
                        uIAClickListElementItemByName["ExpandFirst"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByNameexpandFirst);
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
                        uIAClickListElementItemByName["CollapseAfter"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByNamecollapseAfter);
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
                    uIAClickListElementItemByName["ItemName"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByNameitemName);
                    uIAClickListElementItemByNamepropCount++;
                }

                if (uIAClickListElementItemByNamesecondsBetweenExpandCollapse != null)
                {
                    uIAClickListElementItemByName["SecondsBetweenExpandCollapse"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByNamesecondsBetweenExpandCollapse);
                    uIAClickListElementItemByNamepropCount++;
                }

                if (uIAClickListElementItemByNamematchIndex != null)
                {
                    if (uIAClickListElementItemByNamematchIndex != null)
                    {
                        uIAClickListElementItemByName["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByNamematchIndex);
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
                    uIAClickListElementItemByName["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByNamesearchFilter);
                    uIAClickListElementItemByNamepropCount++;
                }

                if (uIAClickListElementItemByNamesortByColumn != null)
                {
                    uIAClickListElementItemByName["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByNamesortByColumn);
                    uIAClickListElementItemByNamepropCount++;
                }

                if (uIAClickListElementItemByNamematchIndexAscending != null)
                {
                    if (uIAClickListElementItemByNamematchIndexAscending != null)
                    {
                        uIAClickListElementItemByName["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByNamematchIndexAscending);
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
                        uIAClickListElementItemByName["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByNamemaxElementsToSearch);
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
                        uIAClickListElementItemByName["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByNamemaxRelativeSearchDepth);
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
                        uIAClickListElementItemByName["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByNamemaxChildElementsToSearchPerNode);
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
                    uIAClickListElementItemByName["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByNameelementLocalizedControlTypesNotToTraverse);
                    uIAClickListElementItemByNamepropCount++;
                }

                uIAClickListElementItemByNamepropCount++;
                uIAClickListElementItemByName["Workflow"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByNameworkflow);
                if (uIAClickListElementItemByNamepropCount > 0)
                {
                    callPayload.Body = uIAClickListElementItemByName;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAClickListElementItemByIndex([WorkflowExpression] Func<int> uIAClickListElementItemByIndexparentWindowHandle, [WorkflowExpression] Func<string> uIAClickListElementItemByIndexworkflow, [WorkflowExpression] Func<string> uIAClickListElementItemByIndexsearchElementName = null, [WorkflowExpression] Func<string> uIAClickListElementItemByIndexsearchElementClassName = null, [WorkflowExpression] Func<string> uIAClickListElementItemByIndexsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAClickListElementItemByIndexsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAClickListElementItemByIndexsearchSubTree = null, [WorkflowExpression] Func<bool> uIAClickListElementItemByIndexexpandFirst = null, [WorkflowExpression] Func<bool> uIAClickListElementItemByIndexcollapseAfter = null, [WorkflowExpression] Func<int> uIAClickListElementItemByIndexitemIndex = null, [WorkflowExpression] Func<double> uIAClickListElementItemByIndexsecondsBetweenExpandCollapse = null, [WorkflowExpression] Func<int> uIAClickListElementItemByIndexmatchIndex = null, [WorkflowExpression] Func<string> uIAClickListElementItemByIndexsearchFilter = null, [WorkflowExpression] Func<string> uIAClickListElementItemByIndexsortByColumn = null, [WorkflowExpression] Func<bool> uIAClickListElementItemByIndexmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAClickListElementItemByIndexmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAClickListElementItemByIndexmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAClickListElementItemByIndexmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAClickListElementItemByIndexelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/ClickListElementItemByIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAClickListElementItemByIndex = new JObject();
                var uIAClickListElementItemByIndexpropCount = 0;
                uIAClickListElementItemByIndexpropCount++;
                uIAClickListElementItemByIndex["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByIndexparentWindowHandle);
                if (uIAClickListElementItemByIndexsearchElementName != null)
                {
                    uIAClickListElementItemByIndex["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByIndexsearchElementName);
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (uIAClickListElementItemByIndexsearchElementClassName != null)
                {
                    uIAClickListElementItemByIndex["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByIndexsearchElementClassName);
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (uIAClickListElementItemByIndexsearchElementAutomationId != null)
                {
                    uIAClickListElementItemByIndex["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByIndexsearchElementAutomationId);
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (uIAClickListElementItemByIndexsearchLocalizedControlType != null)
                {
                    uIAClickListElementItemByIndex["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByIndexsearchLocalizedControlType);
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (uIAClickListElementItemByIndexsearchSubTree != null)
                {
                    if (uIAClickListElementItemByIndexsearchSubTree != null)
                    {
                        uIAClickListElementItemByIndex["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByIndexsearchSubTree);
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
                        uIAClickListElementItemByIndex["ExpandFirst"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByIndexexpandFirst);
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
                        uIAClickListElementItemByIndex["CollapseAfter"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByIndexcollapseAfter);
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
                        uIAClickListElementItemByIndex["ItemIndex"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByIndexitemIndex);
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
                    uIAClickListElementItemByIndex["SecondsBetweenExpandCollapse"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByIndexsecondsBetweenExpandCollapse);
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (uIAClickListElementItemByIndexmatchIndex != null)
                {
                    if (uIAClickListElementItemByIndexmatchIndex != null)
                    {
                        uIAClickListElementItemByIndex["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByIndexmatchIndex);
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
                    uIAClickListElementItemByIndex["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByIndexsearchFilter);
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (uIAClickListElementItemByIndexsortByColumn != null)
                {
                    uIAClickListElementItemByIndex["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByIndexsortByColumn);
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (uIAClickListElementItemByIndexmatchIndexAscending != null)
                {
                    if (uIAClickListElementItemByIndexmatchIndexAscending != null)
                    {
                        uIAClickListElementItemByIndex["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByIndexmatchIndexAscending);
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
                        uIAClickListElementItemByIndex["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByIndexmaxElementsToSearch);
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
                        uIAClickListElementItemByIndex["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByIndexmaxRelativeSearchDepth);
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
                        uIAClickListElementItemByIndex["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByIndexmaxChildElementsToSearchPerNode);
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
                    uIAClickListElementItemByIndex["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByIndexelementLocalizedControlTypesNotToTraverse);
                    uIAClickListElementItemByIndexpropCount++;
                }

                uIAClickListElementItemByIndexpropCount++;
                uIAClickListElementItemByIndex["Workflow"] = SourceExpressionConverter.ConvertToken(uIAClickListElementItemByIndexworkflow);
                if (uIAClickListElementItemByIndexpropCount > 0)
                {
                    callPayload.Body = uIAClickListElementItemByIndex;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIASetElementToNumericValue([WorkflowExpression] Func<int> uIASetElementToNumericValueparentWindowHandle, [WorkflowExpression] Func<int> uIASetElementToNumericValuenewValue, [WorkflowExpression] Func<string> uIASetElementToNumericValueworkflow, [WorkflowExpression] Func<string> uIASetElementToNumericValuesearchElementName = null, [WorkflowExpression] Func<string> uIASetElementToNumericValuesearchElementClassName = null, [WorkflowExpression] Func<string> uIASetElementToNumericValuesearchElementAutomationId = null, [WorkflowExpression] Func<string> uIASetElementToNumericValuesearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIASetElementToNumericValuesearchSubTree = null, [WorkflowExpression] Func<int> uIASetElementToNumericValuematchIndex = null, [WorkflowExpression] Func<string> uIASetElementToNumericValuesearchFilter = null, [WorkflowExpression] Func<string> uIASetElementToNumericValuesortByColumn = null, [WorkflowExpression] Func<bool> uIASetElementToNumericValuematchIndexAscending = null, [WorkflowExpression] Func<int> uIASetElementToNumericValuemaxElementsToSearch = null, [WorkflowExpression] Func<int> uIASetElementToNumericValuemaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIASetElementToNumericValuemaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIASetElementToNumericValueelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIASetElementToNumericValueraiseExceptionIfInputValidationFails = null, [WorkflowExpression] Func<bool> uIASetElementToNumericValuetryValuePattern = null, [WorkflowExpression] Func<bool> uIASetElementToNumericValuetryLegacyPattern = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIASetElementToNumericValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIASetElementToNumericValue = new JObject();
                var uIASetElementToNumericValuepropCount = 0;
                uIASetElementToNumericValuepropCount++;
                uIASetElementToNumericValue["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericValueparentWindowHandle);
                if (uIASetElementToNumericValuesearchElementName != null)
                {
                    uIASetElementToNumericValue["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericValuesearchElementName);
                    uIASetElementToNumericValuepropCount++;
                }

                if (uIASetElementToNumericValuesearchElementClassName != null)
                {
                    uIASetElementToNumericValue["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericValuesearchElementClassName);
                    uIASetElementToNumericValuepropCount++;
                }

                if (uIASetElementToNumericValuesearchElementAutomationId != null)
                {
                    uIASetElementToNumericValue["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericValuesearchElementAutomationId);
                    uIASetElementToNumericValuepropCount++;
                }

                if (uIASetElementToNumericValuesearchLocalizedControlType != null)
                {
                    uIASetElementToNumericValue["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericValuesearchLocalizedControlType);
                    uIASetElementToNumericValuepropCount++;
                }

                if (uIASetElementToNumericValuesearchSubTree != null)
                {
                    if (uIASetElementToNumericValuesearchSubTree != null)
                    {
                        uIASetElementToNumericValue["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericValuesearchSubTree);
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
                        uIASetElementToNumericValue["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericValuematchIndex);
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
                    uIASetElementToNumericValue["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericValuesearchFilter);
                    uIASetElementToNumericValuepropCount++;
                }

                if (uIASetElementToNumericValuesortByColumn != null)
                {
                    uIASetElementToNumericValue["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericValuesortByColumn);
                    uIASetElementToNumericValuepropCount++;
                }

                if (uIASetElementToNumericValuematchIndexAscending != null)
                {
                    if (uIASetElementToNumericValuematchIndexAscending != null)
                    {
                        uIASetElementToNumericValue["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericValuematchIndexAscending);
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
                uIASetElementToNumericValue["NewValue"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericValuenewValue);
                if (uIASetElementToNumericValuemaxElementsToSearch != null)
                {
                    if (uIASetElementToNumericValuemaxElementsToSearch != null)
                    {
                        uIASetElementToNumericValue["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericValuemaxElementsToSearch);
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
                        uIASetElementToNumericValue["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericValuemaxRelativeSearchDepth);
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
                        uIASetElementToNumericValue["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericValuemaxChildElementsToSearchPerNode);
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
                    uIASetElementToNumericValue["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericValueelementLocalizedControlTypesNotToTraverse);
                    uIASetElementToNumericValuepropCount++;
                }

                if (uIASetElementToNumericValueraiseExceptionIfInputValidationFails != null)
                {
                    if (uIASetElementToNumericValueraiseExceptionIfInputValidationFails != null)
                    {
                        uIASetElementToNumericValue["RaiseExceptionIfInputValidationFails"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericValueraiseExceptionIfInputValidationFails);
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
                        uIASetElementToNumericValue["TryValuePattern"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericValuetryValuePattern);
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
                        uIASetElementToNumericValue["TryLegacyPattern"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericValuetryLegacyPattern);
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
                uIASetElementToNumericValue["Workflow"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericValueworkflow);
                if (uIASetElementToNumericValuepropCount > 0)
                {
                    callPayload.Body = uIASetElementToNumericValue;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIASetElementToNumericRangeValue([WorkflowExpression] Func<int> uIASetElementToNumericRangeValueparentWindowHandle, [WorkflowExpression] Func<double> uIASetElementToNumericRangeValuenewValue, [WorkflowExpression] Func<string> uIASetElementToNumericRangeValueworkflow, [WorkflowExpression] Func<string> uIASetElementToNumericRangeValuesearchElementName = null, [WorkflowExpression] Func<string> uIASetElementToNumericRangeValuesearchElementClassName = null, [WorkflowExpression] Func<string> uIASetElementToNumericRangeValuesearchElementAutomationId = null, [WorkflowExpression] Func<string> uIASetElementToNumericRangeValuesearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIASetElementToNumericRangeValuesearchSubTree = null, [WorkflowExpression] Func<int> uIASetElementToNumericRangeValuematchIndex = null, [WorkflowExpression] Func<string> uIASetElementToNumericRangeValuesearchFilter = null, [WorkflowExpression] Func<string> uIASetElementToNumericRangeValuesortByColumn = null, [WorkflowExpression] Func<bool> uIASetElementToNumericRangeValuematchIndexAscending = null, [WorkflowExpression] Func<bool> uIASetElementToNumericRangeValuenewValueIsPercentage = null, [WorkflowExpression] Func<int> uIASetElementToNumericRangeValuemaxElementsToSearch = null, [WorkflowExpression] Func<int> uIASetElementToNumericRangeValuemaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIASetElementToNumericRangeValuemaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIASetElementToNumericRangeValueelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIASetElementToNumericRangeValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIASetElementToNumericRangeValue = new JObject();
                var uIASetElementToNumericRangeValuepropCount = 0;
                uIASetElementToNumericRangeValuepropCount++;
                uIASetElementToNumericRangeValue["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericRangeValueparentWindowHandle);
                if (uIASetElementToNumericRangeValuesearchElementName != null)
                {
                    uIASetElementToNumericRangeValue["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuesearchElementName);
                    uIASetElementToNumericRangeValuepropCount++;
                }

                if (uIASetElementToNumericRangeValuesearchElementClassName != null)
                {
                    uIASetElementToNumericRangeValue["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuesearchElementClassName);
                    uIASetElementToNumericRangeValuepropCount++;
                }

                if (uIASetElementToNumericRangeValuesearchElementAutomationId != null)
                {
                    uIASetElementToNumericRangeValue["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuesearchElementAutomationId);
                    uIASetElementToNumericRangeValuepropCount++;
                }

                if (uIASetElementToNumericRangeValuesearchLocalizedControlType != null)
                {
                    uIASetElementToNumericRangeValue["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuesearchLocalizedControlType);
                    uIASetElementToNumericRangeValuepropCount++;
                }

                if (uIASetElementToNumericRangeValuesearchSubTree != null)
                {
                    if (uIASetElementToNumericRangeValuesearchSubTree != null)
                    {
                        uIASetElementToNumericRangeValue["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuesearchSubTree);
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
                        uIASetElementToNumericRangeValue["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuematchIndex);
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
                    uIASetElementToNumericRangeValue["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuesearchFilter);
                    uIASetElementToNumericRangeValuepropCount++;
                }

                if (uIASetElementToNumericRangeValuesortByColumn != null)
                {
                    uIASetElementToNumericRangeValue["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuesortByColumn);
                    uIASetElementToNumericRangeValuepropCount++;
                }

                if (uIASetElementToNumericRangeValuematchIndexAscending != null)
                {
                    if (uIASetElementToNumericRangeValuematchIndexAscending != null)
                    {
                        uIASetElementToNumericRangeValue["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuematchIndexAscending);
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
                uIASetElementToNumericRangeValue["NewValue"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuenewValue);
                if (uIASetElementToNumericRangeValuenewValueIsPercentage != null)
                {
                    if (uIASetElementToNumericRangeValuenewValueIsPercentage != null)
                    {
                        uIASetElementToNumericRangeValue["NewValueIsPercentage"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuenewValueIsPercentage);
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
                        uIASetElementToNumericRangeValue["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuemaxElementsToSearch);
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
                        uIASetElementToNumericRangeValue["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuemaxRelativeSearchDepth);
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
                        uIASetElementToNumericRangeValue["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericRangeValuemaxChildElementsToSearchPerNode);
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
                    uIASetElementToNumericRangeValue["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericRangeValueelementLocalizedControlTypesNotToTraverse);
                    uIASetElementToNumericRangeValuepropCount++;
                }

                uIASetElementToNumericRangeValuepropCount++;
                uIASetElementToNumericRangeValue["Workflow"] = SourceExpressionConverter.ConvertToken(uIASetElementToNumericRangeValueworkflow);
                if (uIASetElementToNumericRangeValuepropCount > 0)
                {
                    callPayload.Body = uIASetElementToNumericRangeValue;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAResetAllElementHandles([WorkflowExpression] Func<string> uIAResetAllElementHandlesworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIAResetAllElementHandles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAResetAllElementHandles = new JObject();
                var uIAResetAllElementHandlespropCount = 0;
                uIAResetAllElementHandlespropCount++;
                uIAResetAllElementHandles["Workflow"] = SourceExpressionConverter.ConvertToken(uIAResetAllElementHandlesworkflow);
                if (uIAResetAllElementHandlespropCount > 0)
                {
                    callPayload.Body = uIAResetAllElementHandles;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalPasswordInputIntoElement([WorkflowExpression] Func<int> uIAGlobalPasswordInputIntoElementparentWindowHandle, [WorkflowExpression] Func<string> uIAGlobalPasswordInputIntoElementpasswordToInput, [WorkflowExpression] Func<string> uIAGlobalPasswordInputIntoElementworkflow, [WorkflowExpression] Func<string> uIAGlobalPasswordInputIntoElementsearchElementName = null, [WorkflowExpression] Func<string> uIAGlobalPasswordInputIntoElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAGlobalPasswordInputIntoElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGlobalPasswordInputIntoElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGlobalPasswordInputIntoElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAGlobalPasswordInputIntoElementmatchIndex = null, [WorkflowExpression] Func<string> uIAGlobalPasswordInputIntoElementsearchFilter = null, [WorkflowExpression] Func<string> uIAGlobalPasswordInputIntoElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAGlobalPasswordInputIntoElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIAGlobalPasswordInputIntoElementfocusElement = null, [WorkflowExpression] Func<bool> uIAGlobalPasswordInputIntoElementglobalMouseClickOnElement = null, [WorkflowExpression] Func<bool> uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingDoubleClickDelete = null, [WorkflowExpression] Func<bool> uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingCTRLADelete = null, [WorkflowExpression] Func<bool> uIAGlobalPasswordInputIntoElementsendKeyEvents = null, [WorkflowExpression] Func<int> uIAGlobalPasswordInputIntoElementinterval = null, [WorkflowExpression] Func<bool> uIAGlobalPasswordInputIntoElementdontInterpretSymbols = null, [WorkflowExpression] Func<bool> uIAGlobalPasswordInputIntoElementpasswordContainsStoredPassword = null, [WorkflowExpression] Func<int> uIAGlobalPasswordInputIntoElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGlobalPasswordInputIntoElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGlobalPasswordInputIntoElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGlobalPasswordInputIntoElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIAGlobalPasswordInputIntoElementvalidateClickablePointWithinElementBoundary = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIAGlobalPasswordInputIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGlobalPasswordInputIntoElement = new JObject();
                var uIAGlobalPasswordInputIntoElementpropCount = 0;
                uIAGlobalPasswordInputIntoElementpropCount++;
                uIAGlobalPasswordInputIntoElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementparentWindowHandle);
                if (uIAGlobalPasswordInputIntoElementsearchElementName != null)
                {
                    uIAGlobalPasswordInputIntoElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementsearchElementName);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (uIAGlobalPasswordInputIntoElementsearchElementClassName != null)
                {
                    uIAGlobalPasswordInputIntoElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementsearchElementClassName);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (uIAGlobalPasswordInputIntoElementsearchElementAutomationId != null)
                {
                    uIAGlobalPasswordInputIntoElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementsearchElementAutomationId);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (uIAGlobalPasswordInputIntoElementsearchLocalizedControlType != null)
                {
                    uIAGlobalPasswordInputIntoElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementsearchLocalizedControlType);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (uIAGlobalPasswordInputIntoElementsearchSubTree != null)
                {
                    if (uIAGlobalPasswordInputIntoElementsearchSubTree != null)
                    {
                        uIAGlobalPasswordInputIntoElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementsearchSubTree);
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
                        uIAGlobalPasswordInputIntoElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementmatchIndex);
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
                    uIAGlobalPasswordInputIntoElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementsearchFilter);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (uIAGlobalPasswordInputIntoElementsortByColumn != null)
                {
                    uIAGlobalPasswordInputIntoElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementsortByColumn);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (uIAGlobalPasswordInputIntoElementmatchIndexAscending != null)
                {
                    if (uIAGlobalPasswordInputIntoElementmatchIndexAscending != null)
                    {
                        uIAGlobalPasswordInputIntoElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementmatchIndexAscending);
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
                        uIAGlobalPasswordInputIntoElement["FocusElement"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementfocusElement);
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
                        uIAGlobalPasswordInputIntoElement["GlobalMouseClickOnElement"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementglobalMouseClickOnElement);
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
                        uIAGlobalPasswordInputIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingDoubleClickDelete);
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
                        uIAGlobalPasswordInputIntoElement["ReplaceExistingValueUsingCTRLADelete"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingCTRLADelete);
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
                uIAGlobalPasswordInputIntoElement["PasswordToInput"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementpasswordToInput);
                if (uIAGlobalPasswordInputIntoElementsendKeyEvents != null)
                {
                    if (uIAGlobalPasswordInputIntoElementsendKeyEvents != null)
                    {
                        uIAGlobalPasswordInputIntoElement["SendKeyEvents"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementsendKeyEvents);
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
                        uIAGlobalPasswordInputIntoElement["Interval"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementinterval);
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
                        uIAGlobalPasswordInputIntoElement["DontInterpretSymbols"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementdontInterpretSymbols);
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
                        uIAGlobalPasswordInputIntoElement["PasswordContainsStoredPassword"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementpasswordContainsStoredPassword);
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
                        uIAGlobalPasswordInputIntoElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementmaxElementsToSearch);
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
                        uIAGlobalPasswordInputIntoElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementmaxRelativeSearchDepth);
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
                        uIAGlobalPasswordInputIntoElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementmaxChildElementsToSearchPerNode);
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
                    uIAGlobalPasswordInputIntoElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementelementLocalizedControlTypesNotToTraverse);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (uIAGlobalPasswordInputIntoElementvalidateClickablePointWithinElementBoundary != null)
                {
                    if (uIAGlobalPasswordInputIntoElementvalidateClickablePointWithinElementBoundary != null)
                    {
                        uIAGlobalPasswordInputIntoElement["ValidateClickablePointWithinElementBoundary"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementvalidateClickablePointWithinElementBoundary);
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
                uIAGlobalPasswordInputIntoElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGlobalPasswordInputIntoElementworkflow);
                if (uIAGlobalPasswordInputIntoElementpropCount > 0)
                {
                    callPayload.Body = uIAGlobalPasswordInputIntoElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIAGlobalTextInputIntoElement([WorkflowExpression] Func<int> uIAGlobalTextInputIntoElementparentWindowHandle, [WorkflowExpression] Func<string> uIAGlobalTextInputIntoElementworkflow, [WorkflowExpression] Func<string> uIAGlobalTextInputIntoElementsearchElementName = null, [WorkflowExpression] Func<string> uIAGlobalTextInputIntoElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAGlobalTextInputIntoElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGlobalTextInputIntoElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGlobalTextInputIntoElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAGlobalTextInputIntoElementmatchIndex = null, [WorkflowExpression] Func<string> uIAGlobalTextInputIntoElementsearchFilter = null, [WorkflowExpression] Func<string> uIAGlobalTextInputIntoElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAGlobalTextInputIntoElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIAGlobalTextInputIntoElementfocusElement = null, [WorkflowExpression] Func<bool> uIAGlobalTextInputIntoElementglobalMouseClickOnElement = null, [WorkflowExpression] Func<bool> uIAGlobalTextInputIntoElementreplaceExistingValueUsingDoubleClickDelete = null, [WorkflowExpression] Func<bool> uIAGlobalTextInputIntoElementreplaceExistingValueUsingCTRLADelete = null, [WorkflowExpression] Func<string> uIAGlobalTextInputIntoElementtextToInput = null, [WorkflowExpression] Func<bool> uIAGlobalTextInputIntoElementsendKeyEvents = null, [WorkflowExpression] Func<int> uIAGlobalTextInputIntoElementinterval = null, [WorkflowExpression] Func<bool> uIAGlobalTextInputIntoElementdontInterpretSymbols = null, [WorkflowExpression] Func<int> uIAGlobalTextInputIntoElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGlobalTextInputIntoElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGlobalTextInputIntoElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGlobalTextInputIntoElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<bool> uIAGlobalTextInputIntoElementvalidateClickablePointWithinElementBoundary = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIAGlobalTextInputIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGlobalTextInputIntoElement = new JObject();
                var uIAGlobalTextInputIntoElementpropCount = 0;
                uIAGlobalTextInputIntoElementpropCount++;
                uIAGlobalTextInputIntoElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementparentWindowHandle);
                if (uIAGlobalTextInputIntoElementsearchElementName != null)
                {
                    uIAGlobalTextInputIntoElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementsearchElementName);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (uIAGlobalTextInputIntoElementsearchElementClassName != null)
                {
                    uIAGlobalTextInputIntoElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementsearchElementClassName);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (uIAGlobalTextInputIntoElementsearchElementAutomationId != null)
                {
                    uIAGlobalTextInputIntoElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementsearchElementAutomationId);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (uIAGlobalTextInputIntoElementsearchLocalizedControlType != null)
                {
                    uIAGlobalTextInputIntoElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementsearchLocalizedControlType);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (uIAGlobalTextInputIntoElementsearchSubTree != null)
                {
                    if (uIAGlobalTextInputIntoElementsearchSubTree != null)
                    {
                        uIAGlobalTextInputIntoElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementsearchSubTree);
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
                        uIAGlobalTextInputIntoElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementmatchIndex);
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
                    uIAGlobalTextInputIntoElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementsearchFilter);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (uIAGlobalTextInputIntoElementsortByColumn != null)
                {
                    uIAGlobalTextInputIntoElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementsortByColumn);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (uIAGlobalTextInputIntoElementmatchIndexAscending != null)
                {
                    if (uIAGlobalTextInputIntoElementmatchIndexAscending != null)
                    {
                        uIAGlobalTextInputIntoElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementmatchIndexAscending);
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
                        uIAGlobalTextInputIntoElement["FocusElement"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementfocusElement);
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
                        uIAGlobalTextInputIntoElement["GlobalMouseClickOnElement"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementglobalMouseClickOnElement);
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
                        uIAGlobalTextInputIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementreplaceExistingValueUsingDoubleClickDelete);
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
                        uIAGlobalTextInputIntoElement["ReplaceExistingValueUsingCTRLADelete"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementreplaceExistingValueUsingCTRLADelete);
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
                    uIAGlobalTextInputIntoElement["TextToInput"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementtextToInput);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (uIAGlobalTextInputIntoElementsendKeyEvents != null)
                {
                    if (uIAGlobalTextInputIntoElementsendKeyEvents != null)
                    {
                        uIAGlobalTextInputIntoElement["SendKeyEvents"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementsendKeyEvents);
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
                        uIAGlobalTextInputIntoElement["Interval"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementinterval);
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
                        uIAGlobalTextInputIntoElement["DontInterpretSymbols"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementdontInterpretSymbols);
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
                        uIAGlobalTextInputIntoElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementmaxElementsToSearch);
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
                        uIAGlobalTextInputIntoElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementmaxRelativeSearchDepth);
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
                        uIAGlobalTextInputIntoElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementmaxChildElementsToSearchPerNode);
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
                    uIAGlobalTextInputIntoElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementelementLocalizedControlTypesNotToTraverse);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (uIAGlobalTextInputIntoElementvalidateClickablePointWithinElementBoundary != null)
                {
                    if (uIAGlobalTextInputIntoElementvalidateClickablePointWithinElementBoundary != null)
                    {
                        uIAGlobalTextInputIntoElement["ValidateClickablePointWithinElementBoundary"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementvalidateClickablePointWithinElementBoundary);
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
                uIAGlobalTextInputIntoElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGlobalTextInputIntoElementworkflow);
                if (uIAGlobalTextInputIntoElementpropCount > 0)
                {
                    callPayload.Body = uIAGlobalTextInputIntoElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementPropertiesAsListResponse> UIAGetElementPropertiesAsList([WorkflowExpression] Func<int> uIAGetElementPropertiesAsListelementHandle, [WorkflowExpression] Func<string> uIAGetElementPropertiesAsListworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIAGetElementPropertiesAsList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetElementPropertiesAsList = new JObject();
                var uIAGetElementPropertiesAsListpropCount = 0;
                uIAGetElementPropertiesAsListpropCount++;
                uIAGetElementPropertiesAsList["ElementHandle"] = SourceExpressionConverter.ConvertToken(uIAGetElementPropertiesAsListelementHandle);
                uIAGetElementPropertiesAsListpropCount++;
                uIAGetElementPropertiesAsList["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetElementPropertiesAsListworkflow);
                if (uIAGetElementPropertiesAsListpropCount > 0)
                {
                    callPayload.Body = uIAGetElementPropertiesAsList;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetElementPropertiesAsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction UIASetTransactionTimeout([WorkflowExpression] Func<double> uIASetTransactionTimeouttimeoutInSeconds, [WorkflowExpression] Func<string> uIASetTransactionTimeoutworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIASetTransactionTimeout";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIASetTransactionTimeout = new JObject();
                var uIASetTransactionTimeoutpropCount = 0;
                uIASetTransactionTimeoutpropCount++;
                uIASetTransactionTimeout["TimeoutInSeconds"] = SourceExpressionConverter.ConvertToken(uIASetTransactionTimeouttimeoutInSeconds);
                uIASetTransactionTimeoutpropCount++;
                uIASetTransactionTimeout["Workflow"] = SourceExpressionConverter.ConvertToken(uIASetTransactionTimeoutworkflow);
                if (uIASetTransactionTimeoutpropCount > 0)
                {
                    callPayload.Body = uIASetTransactionTimeout;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementAtCoordinatesResponse> UIAGetElementAtCoordinates([WorkflowExpression] Func<string> uIAGetElementAtCoordinatesworkflow, [WorkflowExpression] Func<int> uIAGetElementAtCoordinatesxCoord = null, [WorkflowExpression] Func<int> uIAGetElementAtCoordinatesyCoord = null, [WorkflowExpression] Func<bool> uIAGetElementAtCoordinatesraiseExceptionIfElementNotFound = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                        uIAGetElementAtCoordinates["XCoord"] = SourceExpressionConverter.ConvertToken(uIAGetElementAtCoordinatesxCoord);
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
                        uIAGetElementAtCoordinates["YCoord"] = SourceExpressionConverter.ConvertToken(uIAGetElementAtCoordinatesyCoord);
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
                        uIAGetElementAtCoordinates["RaiseExceptionIfElementNotFound"] = SourceExpressionConverter.ConvertToken(uIAGetElementAtCoordinatesraiseExceptionIfElementNotFound);
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
                uIAGetElementAtCoordinates["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetElementAtCoordinatesworkflow);
                if (uIAGetElementAtCoordinatespropCount > 0)
                {
                    callPayload.Body = uIAGetElementAtCoordinates;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetElementAtCoordinatesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetMultipleParentElementPropertiesResponse> UIAGetMultipleParentElementProperties([WorkflowExpression] Func<int> uIAGetMultipleParentElementPropertieselementHandle, [WorkflowExpression] Func<string> uIAGetMultipleParentElementPropertiesworkflow, [WorkflowExpression] Func<int> uIAGetMultipleParentElementPropertiesmaxParentsToProcess = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIAGetMultipleParentElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetMultipleParentElementProperties = new JObject();
                var uIAGetMultipleParentElementPropertiespropCount = 0;
                uIAGetMultipleParentElementPropertiespropCount++;
                uIAGetMultipleParentElementProperties["ElementHandle"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleParentElementPropertieselementHandle);
                if (uIAGetMultipleParentElementPropertiesmaxParentsToProcess != null)
                {
                    if (uIAGetMultipleParentElementPropertiesmaxParentsToProcess != null)
                    {
                        uIAGetMultipleParentElementProperties["MaxParentsToProcess"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleParentElementPropertiesmaxParentsToProcess);
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
                uIAGetMultipleParentElementProperties["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleParentElementPropertiesworkflow);
                if (uIAGetMultipleParentElementPropertiespropCount > 0)
                {
                    callPayload.Body = uIAGetMultipleParentElementProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetMultipleParentElementPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIASearchForFirstParentElementResponse> UIASearchForFirstParentElement([WorkflowExpression] Func<int> uIASearchForFirstParentElementelementHandle, [WorkflowExpression] Func<string> uIASearchForFirstParentElementworkflow, [WorkflowExpression] Func<string> uIASearchForFirstParentElementsearchParentLocalizedControlType = null, [WorkflowExpression] Func<int> uIASearchForFirstParentElementsearchParentControlType = null, [WorkflowExpression] Func<int> uIASearchForFirstParentElementmaxParentsToProcess = null, [WorkflowExpression] Func<bool> uIASearchForFirstParentElementraiseExceptionIfParentElementNotFound = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIASearchForFirstParentElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIASearchForFirstParentElement = new JObject();
                var uIASearchForFirstParentElementpropCount = 0;
                uIASearchForFirstParentElementpropCount++;
                uIASearchForFirstParentElement["ElementHandle"] = SourceExpressionConverter.ConvertToken(uIASearchForFirstParentElementelementHandle);
                if (uIASearchForFirstParentElementsearchParentLocalizedControlType != null)
                {
                    uIASearchForFirstParentElement["SearchParentLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIASearchForFirstParentElementsearchParentLocalizedControlType);
                    uIASearchForFirstParentElementpropCount++;
                }

                if (uIASearchForFirstParentElementsearchParentControlType != null)
                {
                    uIASearchForFirstParentElement["SearchParentControlType"] = SourceExpressionConverter.ConvertToken(uIASearchForFirstParentElementsearchParentControlType);
                    uIASearchForFirstParentElementpropCount++;
                }

                if (uIASearchForFirstParentElementmaxParentsToProcess != null)
                {
                    if (uIASearchForFirstParentElementmaxParentsToProcess != null)
                    {
                        uIASearchForFirstParentElement["MaxParentsToProcess"] = SourceExpressionConverter.ConvertToken(uIASearchForFirstParentElementmaxParentsToProcess);
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
                        uIASearchForFirstParentElement["RaiseExceptionIfParentElementNotFound"] = SourceExpressionConverter.ConvertToken(uIASearchForFirstParentElementraiseExceptionIfParentElementNotFound);
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
                uIASearchForFirstParentElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIASearchForFirstParentElementworkflow);
                if (uIASearchForFirstParentElementpropCount > 0)
                {
                    callPayload.Body = uIASearchForFirstParentElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIASearchForFirstParentElementResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetMultipleElementsAsTableResponse> UIAGetMultipleElementsAsTable([WorkflowExpression] Func<string> uIAGetMultipleElementsAsTableworkflow, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTableparentWindowHandle = null, [WorkflowExpression] Func<string> uIAGetMultipleElementsAsTablesearchElementName = null, [WorkflowExpression] Func<string> uIAGetMultipleElementsAsTablesearchElementClassName = null, [WorkflowExpression] Func<string> uIAGetMultipleElementsAsTablesearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGetMultipleElementsAsTablesearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGetMultipleElementsAsTablesearchSubTree = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablematchIndex = null, [WorkflowExpression] Func<string> uIAGetMultipleElementsAsTablesearchFilter = null, [WorkflowExpression] Func<string> uIAGetMultipleElementsAsTablesortByColumn = null, [WorkflowExpression] Func<bool> uIAGetMultipleElementsAsTablematchIndexAscending = null, [WorkflowExpression] Func<string> uIAGetMultipleElementsAsTablesearchCellHeaderSubElementLocalizedControlType = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablesearchCellHeaderSubElementControlType = null, [WorkflowExpression] Func<string> uIAGetMultipleElementsAsTablesearchCellSubElementLocalizedControlType = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablesearchCellSubElementControlType = null, [WorkflowExpression] Func<bool> uIAGetMultipleElementsAsTablesearchDescendantsForCellSubElements = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablefirstCellHeaderSubElementToReturn = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablemaxCellHeaderSubElementsToReturn = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablefirstCellSubElementToReturn = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablemaxCellSubElementsToReturn = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablerequestedNumberOfColumns = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablecellSubElementValuePriority = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablecellSubElementTextValuePriority = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablecellSubElementNameValuePriority = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTableminimumCellSubElementWidth = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTableminimumCellSubElementHeight = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxLeft = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxRight = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxTop = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxBottom = null, [WorkflowExpression] Func<bool> uIAGetMultipleElementsAsTablereadTableAsThread = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTableretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablesecondsToWaitForThread = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablemaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablemaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGetMultipleElementsAsTablemaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGetMultipleElementsAsTableelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIAGetMultipleElementsAsTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetMultipleElementsAsTable = new JObject();
                var uIAGetMultipleElementsAsTablepropCount = 0;
                if (uIAGetMultipleElementsAsTableparentWindowHandle != null)
                {
                    uIAGetMultipleElementsAsTable["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTableparentWindowHandle);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (uIAGetMultipleElementsAsTablesearchElementName != null)
                {
                    uIAGetMultipleElementsAsTable["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchElementName);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (uIAGetMultipleElementsAsTablesearchElementClassName != null)
                {
                    uIAGetMultipleElementsAsTable["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchElementClassName);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (uIAGetMultipleElementsAsTablesearchElementAutomationId != null)
                {
                    uIAGetMultipleElementsAsTable["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchElementAutomationId);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (uIAGetMultipleElementsAsTablesearchLocalizedControlType != null)
                {
                    uIAGetMultipleElementsAsTable["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchLocalizedControlType);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (uIAGetMultipleElementsAsTablesearchSubTree != null)
                {
                    if (uIAGetMultipleElementsAsTablesearchSubTree != null)
                    {
                        uIAGetMultipleElementsAsTable["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchSubTree);
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
                        uIAGetMultipleElementsAsTable["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablematchIndex);
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
                    uIAGetMultipleElementsAsTable["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchFilter);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (uIAGetMultipleElementsAsTablesortByColumn != null)
                {
                    uIAGetMultipleElementsAsTable["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesortByColumn);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (uIAGetMultipleElementsAsTablematchIndexAscending != null)
                {
                    if (uIAGetMultipleElementsAsTablematchIndexAscending != null)
                    {
                        uIAGetMultipleElementsAsTable["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablematchIndexAscending);
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
                    uIAGetMultipleElementsAsTable["SearchCellHeaderSubElementLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchCellHeaderSubElementLocalizedControlType);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (uIAGetMultipleElementsAsTablesearchCellHeaderSubElementControlType != null)
                {
                    uIAGetMultipleElementsAsTable["SearchCellHeaderSubElementControlType"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchCellHeaderSubElementControlType);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (uIAGetMultipleElementsAsTablesearchCellSubElementLocalizedControlType != null)
                {
                    uIAGetMultipleElementsAsTable["SearchCellSubElementLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchCellSubElementLocalizedControlType);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (uIAGetMultipleElementsAsTablesearchCellSubElementControlType != null)
                {
                    uIAGetMultipleElementsAsTable["SearchCellSubElementControlType"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchCellSubElementControlType);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (uIAGetMultipleElementsAsTablesearchDescendantsForCellSubElements != null)
                {
                    if (uIAGetMultipleElementsAsTablesearchDescendantsForCellSubElements != null)
                    {
                        uIAGetMultipleElementsAsTable["SearchDescendantsForCellSubElements"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchDescendantsForCellSubElements);
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
                        uIAGetMultipleElementsAsTable["FirstCellHeaderSubElementToReturn"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablefirstCellHeaderSubElementToReturn);
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
                        uIAGetMultipleElementsAsTable["MaxCellHeaderSubElementsToReturn"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablemaxCellHeaderSubElementsToReturn);
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
                        uIAGetMultipleElementsAsTable["FirstCellSubElementToReturn"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablefirstCellSubElementToReturn);
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
                        uIAGetMultipleElementsAsTable["MaxCellSubElementsToReturn"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablemaxCellSubElementsToReturn);
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
                        uIAGetMultipleElementsAsTable["RequestedNumberOfColumns"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablerequestedNumberOfColumns);
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
                        uIAGetMultipleElementsAsTable["CellSubElementValuePriority"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablecellSubElementValuePriority);
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
                        uIAGetMultipleElementsAsTable["CellSubElementTextValuePriority"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablecellSubElementTextValuePriority);
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
                        uIAGetMultipleElementsAsTable["CellSubElementNameValuePriority"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablecellSubElementNameValuePriority);
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
                        uIAGetMultipleElementsAsTable["MinimumCellSubElementWidth"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTableminimumCellSubElementWidth);
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
                        uIAGetMultipleElementsAsTable["MinimumCellSubElementHeight"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTableminimumCellSubElementHeight);
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
                        uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxLeft"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxLeft);
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
                        uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxRight"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxRight);
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
                        uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxTop"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxTop);
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
                        uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxBottom"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxBottom);
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
                        uIAGetMultipleElementsAsTable["ReadTableAsThread"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablereadTableAsThread);
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
                    uIAGetMultipleElementsAsTable["RetrieveOutputDataFromThreadId"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTableretrieveOutputDataFromThreadId);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (uIAGetMultipleElementsAsTablesecondsToWaitForThread != null)
                {
                    if (uIAGetMultipleElementsAsTablesecondsToWaitForThread != null)
                    {
                        uIAGetMultipleElementsAsTable["SecondsToWaitForThread"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablesecondsToWaitForThread);
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
                        uIAGetMultipleElementsAsTable["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablemaxElementsToSearch);
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
                        uIAGetMultipleElementsAsTable["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablemaxRelativeSearchDepth);
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
                        uIAGetMultipleElementsAsTable["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTablemaxChildElementsToSearchPerNode);
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
                    uIAGetMultipleElementsAsTable["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTableelementLocalizedControlTypesNotToTraverse);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
                uIAGetMultipleElementsAsTable["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetMultipleElementsAsTableworkflow);
                if (uIAGetMultipleElementsAsTablepropCount > 0)
                {
                    callPayload.Body = uIAGetMultipleElementsAsTable;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetMultipleElementsAsTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIASetElementScrollPercentageResponse> UIASetElementScrollPercentage([WorkflowExpression] Func<int> uIASetElementScrollPercentageparentWindowHandle, [WorkflowExpression] Func<string> uIASetElementScrollPercentageworkflow, [WorkflowExpression] Func<string> uIASetElementScrollPercentagesearchElementName = null, [WorkflowExpression] Func<string> uIASetElementScrollPercentagesearchElementClassName = null, [WorkflowExpression] Func<string> uIASetElementScrollPercentagesearchElementAutomationId = null, [WorkflowExpression] Func<string> uIASetElementScrollPercentagesearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIASetElementScrollPercentagesearchSubTree = null, [WorkflowExpression] Func<int> uIASetElementScrollPercentagematchIndex = null, [WorkflowExpression] Func<string> uIASetElementScrollPercentagesearchFilter = null, [WorkflowExpression] Func<string> uIASetElementScrollPercentagesortByColumn = null, [WorkflowExpression] Func<bool> uIASetElementScrollPercentagematchIndexAscending = null, [WorkflowExpression] Func<double> uIASetElementScrollPercentagehorizontalScrollPercentage = null, [WorkflowExpression] Func<double> uIASetElementScrollPercentageverticalScrollPercentage = null, [WorkflowExpression] Func<bool> uIASetElementScrollPercentagetryScrollPattern = null, [WorkflowExpression] Func<bool> uIASetElementScrollPercentagetryRangeValuePattern = null, [WorkflowExpression] Func<bool> uIASetElementScrollPercentagetryValuePattern = null, [WorkflowExpression] Func<int> uIASetElementScrollPercentagemaxElementsToSearch = null, [WorkflowExpression] Func<int> uIASetElementScrollPercentagemaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIASetElementScrollPercentagemaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIASetElementScrollPercentageelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIASetElementScrollPercentage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIASetElementScrollPercentage = new JObject();
                var uIASetElementScrollPercentagepropCount = 0;
                uIASetElementScrollPercentagepropCount++;
                uIASetElementScrollPercentage["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIASetElementScrollPercentageparentWindowHandle);
                if (uIASetElementScrollPercentagesearchElementName != null)
                {
                    uIASetElementScrollPercentage["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIASetElementScrollPercentagesearchElementName);
                    uIASetElementScrollPercentagepropCount++;
                }

                if (uIASetElementScrollPercentagesearchElementClassName != null)
                {
                    uIASetElementScrollPercentage["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIASetElementScrollPercentagesearchElementClassName);
                    uIASetElementScrollPercentagepropCount++;
                }

                if (uIASetElementScrollPercentagesearchElementAutomationId != null)
                {
                    uIASetElementScrollPercentage["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIASetElementScrollPercentagesearchElementAutomationId);
                    uIASetElementScrollPercentagepropCount++;
                }

                if (uIASetElementScrollPercentagesearchLocalizedControlType != null)
                {
                    uIASetElementScrollPercentage["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIASetElementScrollPercentagesearchLocalizedControlType);
                    uIASetElementScrollPercentagepropCount++;
                }

                if (uIASetElementScrollPercentagesearchSubTree != null)
                {
                    if (uIASetElementScrollPercentagesearchSubTree != null)
                    {
                        uIASetElementScrollPercentage["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIASetElementScrollPercentagesearchSubTree);
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
                        uIASetElementScrollPercentage["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIASetElementScrollPercentagematchIndex);
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
                    uIASetElementScrollPercentage["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIASetElementScrollPercentagesearchFilter);
                    uIASetElementScrollPercentagepropCount++;
                }

                if (uIASetElementScrollPercentagesortByColumn != null)
                {
                    uIASetElementScrollPercentage["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIASetElementScrollPercentagesortByColumn);
                    uIASetElementScrollPercentagepropCount++;
                }

                if (uIASetElementScrollPercentagematchIndexAscending != null)
                {
                    if (uIASetElementScrollPercentagematchIndexAscending != null)
                    {
                        uIASetElementScrollPercentage["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIASetElementScrollPercentagematchIndexAscending);
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
                        uIASetElementScrollPercentage["HorizontalScrollPercentage"] = SourceExpressionConverter.ConvertToken(uIASetElementScrollPercentagehorizontalScrollPercentage);
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
                        uIASetElementScrollPercentage["VerticalScrollPercentage"] = SourceExpressionConverter.ConvertToken(uIASetElementScrollPercentageverticalScrollPercentage);
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
                        uIASetElementScrollPercentage["TryScrollPattern"] = SourceExpressionConverter.ConvertToken(uIASetElementScrollPercentagetryScrollPattern);
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
                        uIASetElementScrollPercentage["TryRangeValuePattern"] = SourceExpressionConverter.ConvertToken(uIASetElementScrollPercentagetryRangeValuePattern);
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
                        uIASetElementScrollPercentage["TryValuePattern"] = SourceExpressionConverter.ConvertToken(uIASetElementScrollPercentagetryValuePattern);
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
                        uIASetElementScrollPercentage["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIASetElementScrollPercentagemaxElementsToSearch);
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
                        uIASetElementScrollPercentage["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIASetElementScrollPercentagemaxRelativeSearchDepth);
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
                        uIASetElementScrollPercentage["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIASetElementScrollPercentagemaxChildElementsToSearchPerNode);
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
                    uIASetElementScrollPercentage["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIASetElementScrollPercentageelementLocalizedControlTypesNotToTraverse);
                    uIASetElementScrollPercentagepropCount++;
                }

                uIASetElementScrollPercentagepropCount++;
                uIASetElementScrollPercentage["Workflow"] = SourceExpressionConverter.ConvertToken(uIASetElementScrollPercentageworkflow);
                if (uIASetElementScrollPercentagepropCount > 0)
                {
                    callPayload.Body = uIASetElementScrollPercentage;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIASetElementScrollPercentageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementSearchColourRegionResponse> UIAGetElementSearchColourRegion([WorkflowExpression] Func<int> uIAGetElementSearchColourRegionparentWindowHandle, [WorkflowExpression] Func<string> uIAGetElementSearchColourRegionsearchColour, [WorkflowExpression] Func<int> uIAGetElementSearchColourRegionmaxColourDeviation, [WorkflowExpression] Func<string> uIAGetElementSearchColourRegionworkflow, [WorkflowExpression] Func<string> uIAGetElementSearchColourRegionsearchElementName = null, [WorkflowExpression] Func<string> uIAGetElementSearchColourRegionsearchElementClassName = null, [WorkflowExpression] Func<string> uIAGetElementSearchColourRegionsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGetElementSearchColourRegionsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGetElementSearchColourRegionsearchSubTree = null, [WorkflowExpression] Func<int> uIAGetElementSearchColourRegionmatchIndex = null, [WorkflowExpression] Func<string> uIAGetElementSearchColourRegionsearchFilter = null, [WorkflowExpression] Func<string> uIAGetElementSearchColourRegionsortByColumn = null, [WorkflowExpression] Func<bool> uIAGetElementSearchColourRegionmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAGetElementSearchColourRegionleftPixelXOffset = null, [WorkflowExpression] Func<int> uIAGetElementSearchColourRegionrightPixelXOffset = null, [WorkflowExpression] Func<int> uIAGetElementSearchColourRegiontopPixelYOffset = null, [WorkflowExpression] Func<int> uIAGetElementSearchColourRegionbottomPixelYOffset = null, [WorkflowExpression] Func<bool> uIAGetElementSearchColourRegionhideAgent = null, [WorkflowExpression] Func<bool> uIAGetElementSearchColourRegionreturnPhysicalCoordinates = null, [WorkflowExpression] Func<int> uIAGetElementSearchColourRegionmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGetElementSearchColourRegionmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGetElementSearchColourRegionmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGetElementSearchColourRegionelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIAGetElementSearchColourRegion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetElementSearchColourRegion = new JObject();
                var uIAGetElementSearchColourRegionpropCount = 0;
                uIAGetElementSearchColourRegionpropCount++;
                uIAGetElementSearchColourRegion["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionparentWindowHandle);
                if (uIAGetElementSearchColourRegionsearchElementName != null)
                {
                    uIAGetElementSearchColourRegion["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionsearchElementName);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (uIAGetElementSearchColourRegionsearchElementClassName != null)
                {
                    uIAGetElementSearchColourRegion["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionsearchElementClassName);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (uIAGetElementSearchColourRegionsearchElementAutomationId != null)
                {
                    uIAGetElementSearchColourRegion["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionsearchElementAutomationId);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (uIAGetElementSearchColourRegionsearchLocalizedControlType != null)
                {
                    uIAGetElementSearchColourRegion["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionsearchLocalizedControlType);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (uIAGetElementSearchColourRegionsearchSubTree != null)
                {
                    if (uIAGetElementSearchColourRegionsearchSubTree != null)
                    {
                        uIAGetElementSearchColourRegion["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionsearchSubTree);
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
                        uIAGetElementSearchColourRegion["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionmatchIndex);
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
                    uIAGetElementSearchColourRegion["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionsearchFilter);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (uIAGetElementSearchColourRegionsortByColumn != null)
                {
                    uIAGetElementSearchColourRegion["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionsortByColumn);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (uIAGetElementSearchColourRegionmatchIndexAscending != null)
                {
                    if (uIAGetElementSearchColourRegionmatchIndexAscending != null)
                    {
                        uIAGetElementSearchColourRegion["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionmatchIndexAscending);
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
                uIAGetElementSearchColourRegion["SearchColour"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionsearchColour);
                uIAGetElementSearchColourRegionpropCount++;
                uIAGetElementSearchColourRegion["MaxColourDeviation"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionmaxColourDeviation);
                if (uIAGetElementSearchColourRegionleftPixelXOffset != null)
                {
                    uIAGetElementSearchColourRegion["LeftPixelXOffset"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionleftPixelXOffset);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (uIAGetElementSearchColourRegionrightPixelXOffset != null)
                {
                    uIAGetElementSearchColourRegion["RightPixelXOffset"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionrightPixelXOffset);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (uIAGetElementSearchColourRegiontopPixelYOffset != null)
                {
                    uIAGetElementSearchColourRegion["TopPixelYOffset"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegiontopPixelYOffset);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (uIAGetElementSearchColourRegionbottomPixelYOffset != null)
                {
                    uIAGetElementSearchColourRegion["BottomPixelYOffset"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionbottomPixelYOffset);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (uIAGetElementSearchColourRegionhideAgent != null)
                {
                    if (uIAGetElementSearchColourRegionhideAgent != null)
                    {
                        uIAGetElementSearchColourRegion["HideAgent"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionhideAgent);
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
                        uIAGetElementSearchColourRegion["ReturnPhysicalCoordinates"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionreturnPhysicalCoordinates);
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
                        uIAGetElementSearchColourRegion["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionmaxElementsToSearch);
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
                        uIAGetElementSearchColourRegion["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionmaxRelativeSearchDepth);
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
                        uIAGetElementSearchColourRegion["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionmaxChildElementsToSearchPerNode);
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
                    uIAGetElementSearchColourRegion["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionelementLocalizedControlTypesNotToTraverse);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                uIAGetElementSearchColourRegionpropCount++;
                uIAGetElementSearchColourRegion["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetElementSearchColourRegionworkflow);
                if (uIAGetElementSearchColourRegionpropCount > 0)
                {
                    callPayload.Body = uIAGetElementSearchColourRegion;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetElementSearchColourRegionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGlobalMouseClickElementSearchColourRegionResponse> UIAGlobalMouseClickElementSearchColourRegion([WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegionparentWindowHandle, [WorkflowExpression] Func<string> uIAGlobalMouseClickElementSearchColourRegionsearchColour, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegionmaxColourDeviation, [WorkflowExpression] Func<string> uIAGlobalMouseClickElementSearchColourRegionworkflow, [WorkflowExpression] Func<string> uIAGlobalMouseClickElementSearchColourRegionsearchElementName = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickElementSearchColourRegionsearchElementClassName = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickElementSearchColourRegionsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickElementSearchColourRegionsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGlobalMouseClickElementSearchColourRegionsearchSubTree = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegionmatchIndex = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickElementSearchColourRegionsearchFilter = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickElementSearchColourRegionsortByColumn = null, [WorkflowExpression] Func<bool> uIAGlobalMouseClickElementSearchColourRegionmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegionleftPixelXOffset = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegionrightPixelXOffset = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegiontopPixelYOffset = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegionbottomPixelYOffset = null, [WorkflowExpression] Func<uIAGlobalMouseClickElementSearchColourRegionmouseButtonInput> uIAGlobalMouseClickElementSearchColourRegionmouseButton = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegionclickOffsetX = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegionclickOffsetY = null, [WorkflowExpression] Func<uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeToInput> uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeTo = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegiondelayInMilliseconds = null, [WorkflowExpression] Func<bool> uIAGlobalMouseClickElementSearchColourRegionhideAgent = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegionmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegionmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGlobalMouseClickElementSearchColourRegionmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGlobalMouseClickElementSearchColourRegionelementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIAGlobalMouseClickElementSearchColourRegion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGlobalMouseClickElementSearchColourRegion = new JObject();
                var uIAGlobalMouseClickElementSearchColourRegionpropCount = 0;
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                uIAGlobalMouseClickElementSearchColourRegion["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionparentWindowHandle);
                if (uIAGlobalMouseClickElementSearchColourRegionsearchElementName != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionsearchElementName);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (uIAGlobalMouseClickElementSearchColourRegionsearchElementClassName != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionsearchElementClassName);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (uIAGlobalMouseClickElementSearchColourRegionsearchElementAutomationId != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionsearchElementAutomationId);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (uIAGlobalMouseClickElementSearchColourRegionsearchLocalizedControlType != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionsearchLocalizedControlType);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (uIAGlobalMouseClickElementSearchColourRegionsearchSubTree != null)
                {
                    if (uIAGlobalMouseClickElementSearchColourRegionsearchSubTree != null)
                    {
                        uIAGlobalMouseClickElementSearchColourRegion["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionsearchSubTree);
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
                        uIAGlobalMouseClickElementSearchColourRegion["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionmatchIndex);
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
                    uIAGlobalMouseClickElementSearchColourRegion["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionsearchFilter);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (uIAGlobalMouseClickElementSearchColourRegionsortByColumn != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionsortByColumn);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (uIAGlobalMouseClickElementSearchColourRegionmatchIndexAscending != null)
                {
                    if (uIAGlobalMouseClickElementSearchColourRegionmatchIndexAscending != null)
                    {
                        uIAGlobalMouseClickElementSearchColourRegion["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionmatchIndexAscending);
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
                uIAGlobalMouseClickElementSearchColourRegion["SearchColour"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionsearchColour);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                uIAGlobalMouseClickElementSearchColourRegion["MaxColourDeviation"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionmaxColourDeviation);
                if (uIAGlobalMouseClickElementSearchColourRegionleftPixelXOffset != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["LeftPixelXOffset"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionleftPixelXOffset);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (uIAGlobalMouseClickElementSearchColourRegionrightPixelXOffset != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["RightPixelXOffset"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionrightPixelXOffset);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (uIAGlobalMouseClickElementSearchColourRegiontopPixelYOffset != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["TopPixelYOffset"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegiontopPixelYOffset);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (uIAGlobalMouseClickElementSearchColourRegionbottomPixelYOffset != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["BottomPixelYOffset"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionbottomPixelYOffset);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (uIAGlobalMouseClickElementSearchColourRegionmouseButton != null)
                {
                    if (uIAGlobalMouseClickElementSearchColourRegionmouseButton != null)
                    {
                        uIAGlobalMouseClickElementSearchColourRegion["MouseButton"] = SourceExpressionConverter.Convert(uIAGlobalMouseClickElementSearchColourRegionmouseButton);
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
                        uIAGlobalMouseClickElementSearchColourRegion["ClickOffsetX"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionclickOffsetX);
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
                        uIAGlobalMouseClickElementSearchColourRegion["ClickOffsetY"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionclickOffsetY);
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
                        uIAGlobalMouseClickElementSearchColourRegion["OffsetRelativeTo"] = SourceExpressionConverter.Convert(uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeTo);
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
                        uIAGlobalMouseClickElementSearchColourRegion["DelayInMilliseconds"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegiondelayInMilliseconds);
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
                        uIAGlobalMouseClickElementSearchColourRegion["HideAgent"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionhideAgent);
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
                        uIAGlobalMouseClickElementSearchColourRegion["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionmaxElementsToSearch);
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
                        uIAGlobalMouseClickElementSearchColourRegion["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionmaxRelativeSearchDepth);
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
                        uIAGlobalMouseClickElementSearchColourRegion["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionmaxChildElementsToSearchPerNode);
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
                    uIAGlobalMouseClickElementSearchColourRegion["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionelementLocalizedControlTypesNotToTraverse);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                uIAGlobalMouseClickElementSearchColourRegion["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGlobalMouseClickElementSearchColourRegionworkflow);
                if (uIAGlobalMouseClickElementSearchColourRegionpropCount > 0)
                {
                    callPayload.Body = uIAGlobalMouseClickElementSearchColourRegion;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGlobalMouseClickElementSearchColourRegionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetWin32WindowsResponse> UIAGetWin32Windows([WorkflowExpression] Func<string> uIAGetWin32Windowsworkflow, [WorkflowExpression] Func<string> uIAGetWin32WindowssearchClassName = null, [WorkflowExpression] Func<string> uIAGetWin32WindowssearchWindowTitle = null, [WorkflowExpression] Func<bool> uIAGetWin32WindowstopLevelWindowsOnly = null, [WorkflowExpression] Func<bool> uIAGetWin32WindowsvisibleWindowsOnly = null, [WorkflowExpression] Func<bool> uIAGetWin32WindowswindowsWithTitlebarOnly = null, [WorkflowExpression] Func<bool> uIAGetWin32WindowswindowsWithTitleOnly = null, [WorkflowExpression] Func<bool> uIAGetWin32WindowsignoreTransparentWindows = null, [WorkflowExpression] Func<int> uIAGetWin32WindowssearchProcessId = null, [WorkflowExpression] Func<string> uIAGetWin32WindowssearchFilter = null, [WorkflowExpression] Func<string> uIAGetWin32WindowssortByColumn = null, [WorkflowExpression] Func<bool> uIAGetWin32WindowsmatchIndexAscending = null, [WorkflowExpression] Func<bool> uIAGetWin32WindowsreturnElementHandle = null, [WorkflowExpression] Func<int> uIAGetWin32WindowsfirstItemToReturn = null, [WorkflowExpression] Func<int> uIAGetWin32WindowsmaxItemsToReturn = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/GetWin32Windows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetWin32Windows = new JObject();
                var uIAGetWin32WindowspropCount = 0;
                if (uIAGetWin32WindowssearchClassName != null)
                {
                    uIAGetWin32Windows["SearchClassName"] = SourceExpressionConverter.ConvertToken(uIAGetWin32WindowssearchClassName);
                    uIAGetWin32WindowspropCount++;
                }

                if (uIAGetWin32WindowssearchWindowTitle != null)
                {
                    uIAGetWin32Windows["SearchWindowTitle"] = SourceExpressionConverter.ConvertToken(uIAGetWin32WindowssearchWindowTitle);
                    uIAGetWin32WindowspropCount++;
                }

                if (uIAGetWin32WindowstopLevelWindowsOnly != null)
                {
                    if (uIAGetWin32WindowstopLevelWindowsOnly != null)
                    {
                        uIAGetWin32Windows["TopLevelWindowsOnly"] = SourceExpressionConverter.ConvertToken(uIAGetWin32WindowstopLevelWindowsOnly);
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
                        uIAGetWin32Windows["VisibleWindowsOnly"] = SourceExpressionConverter.ConvertToken(uIAGetWin32WindowsvisibleWindowsOnly);
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
                        uIAGetWin32Windows["WindowsWithTitlebarOnly"] = SourceExpressionConverter.ConvertToken(uIAGetWin32WindowswindowsWithTitlebarOnly);
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
                        uIAGetWin32Windows["WindowsWithTitleOnly"] = SourceExpressionConverter.ConvertToken(uIAGetWin32WindowswindowsWithTitleOnly);
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
                        uIAGetWin32Windows["IgnoreTransparentWindows"] = SourceExpressionConverter.ConvertToken(uIAGetWin32WindowsignoreTransparentWindows);
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
                    uIAGetWin32Windows["SearchProcessId"] = SourceExpressionConverter.ConvertToken(uIAGetWin32WindowssearchProcessId);
                    uIAGetWin32WindowspropCount++;
                }

                if (uIAGetWin32WindowssearchFilter != null)
                {
                    uIAGetWin32Windows["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAGetWin32WindowssearchFilter);
                    uIAGetWin32WindowspropCount++;
                }

                if (uIAGetWin32WindowssortByColumn != null)
                {
                    uIAGetWin32Windows["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAGetWin32WindowssortByColumn);
                    uIAGetWin32WindowspropCount++;
                }

                if (uIAGetWin32WindowsmatchIndexAscending != null)
                {
                    if (uIAGetWin32WindowsmatchIndexAscending != null)
                    {
                        uIAGetWin32Windows["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAGetWin32WindowsmatchIndexAscending);
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
                        uIAGetWin32Windows["ReturnElementHandle"] = SourceExpressionConverter.ConvertToken(uIAGetWin32WindowsreturnElementHandle);
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
                        uIAGetWin32Windows["FirstItemToReturn"] = SourceExpressionConverter.ConvertToken(uIAGetWin32WindowsfirstItemToReturn);
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
                        uIAGetWin32Windows["MaxItemsToReturn"] = SourceExpressionConverter.ConvertToken(uIAGetWin32WindowsmaxItemsToReturn);
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
                uIAGetWin32Windows["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetWin32Windowsworkflow);
                if (uIAGetWin32WindowspropCount > 0)
                {
                    callPayload.Body = uIAGetWin32Windows;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetWin32WindowsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<SetUIAElementSearchModeResponse> SetUIAElementSearchMode([WorkflowExpression] Func<setUIAElementSearchModeuIAElementSearchModeInput> setUIAElementSearchModeuIAElementSearchMode, [WorkflowExpression] Func<string> setUIAElementSearchModeworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/SetUIAElementSearchMode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setUIAElementSearchMode = new JObject();
                var setUIAElementSearchModepropCount = 0;
                setUIAElementSearchModepropCount++;
                setUIAElementSearchMode["UIAElementSearchMode"] = SourceExpressionConverter.Convert(setUIAElementSearchModeuIAElementSearchMode);
                setUIAElementSearchModepropCount++;
                setUIAElementSearchMode["Workflow"] = SourceExpressionConverter.ConvertToken(setUIAElementSearchModeworkflow);
                if (setUIAElementSearchModepropCount > 0)
                {
                    callPayload.Body = setUIAElementSearchMode;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SetUIAElementSearchModeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<GetUIAElementSearchModeResponse> GetUIAElementSearchMode([WorkflowExpression] Func<string> getUIAElementSearchModeworkflow)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/GetUIAElementSearchMode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getUIAElementSearchMode = new JObject();
                var getUIAElementSearchModepropCount = 0;
                getUIAElementSearchModepropCount++;
                getUIAElementSearchMode["Workflow"] = SourceExpressionConverter.ConvertToken(getUIAElementSearchModeworkflow);
                if (getUIAElementSearchModepropCount > 0)
                {
                    callPayload.Body = getUIAElementSearchMode;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetUIAElementSearchModeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementPatternsResponse> UIAGetElementPatterns([WorkflowExpression] Func<int> uIAGetElementPatternsparentWindowHandle, [WorkflowExpression] Func<string> uIAGetElementPatternsworkflow, [WorkflowExpression] Func<string> uIAGetElementPatternssearchElementName = null, [WorkflowExpression] Func<string> uIAGetElementPatternssearchElementClassName = null, [WorkflowExpression] Func<string> uIAGetElementPatternssearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAGetElementPatternssearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAGetElementPatternssearchSubTree = null, [WorkflowExpression] Func<int> uIAGetElementPatternsmatchIndex = null, [WorkflowExpression] Func<string> uIAGetElementPatternssearchFilter = null, [WorkflowExpression] Func<string> uIAGetElementPatternssortByColumn = null, [WorkflowExpression] Func<bool> uIAGetElementPatternsmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAGetElementPatternsmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAGetElementPatternsmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAGetElementPatternsmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAGetElementPatternselementLocalizedControlTypesNotToTraverse = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIAGetElementPatterns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetElementPatterns = new JObject();
                var uIAGetElementPatternspropCount = 0;
                uIAGetElementPatternspropCount++;
                uIAGetElementPatterns["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAGetElementPatternsparentWindowHandle);
                if (uIAGetElementPatternssearchElementName != null)
                {
                    uIAGetElementPatterns["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAGetElementPatternssearchElementName);
                    uIAGetElementPatternspropCount++;
                }

                if (uIAGetElementPatternssearchElementClassName != null)
                {
                    uIAGetElementPatterns["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAGetElementPatternssearchElementClassName);
                    uIAGetElementPatternspropCount++;
                }

                if (uIAGetElementPatternssearchElementAutomationId != null)
                {
                    uIAGetElementPatterns["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAGetElementPatternssearchElementAutomationId);
                    uIAGetElementPatternspropCount++;
                }

                if (uIAGetElementPatternssearchLocalizedControlType != null)
                {
                    uIAGetElementPatterns["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAGetElementPatternssearchLocalizedControlType);
                    uIAGetElementPatternspropCount++;
                }

                if (uIAGetElementPatternssearchSubTree != null)
                {
                    if (uIAGetElementPatternssearchSubTree != null)
                    {
                        uIAGetElementPatterns["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAGetElementPatternssearchSubTree);
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
                        uIAGetElementPatterns["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAGetElementPatternsmatchIndex);
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
                    uIAGetElementPatterns["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAGetElementPatternssearchFilter);
                    uIAGetElementPatternspropCount++;
                }

                if (uIAGetElementPatternssortByColumn != null)
                {
                    uIAGetElementPatterns["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAGetElementPatternssortByColumn);
                    uIAGetElementPatternspropCount++;
                }

                if (uIAGetElementPatternsmatchIndexAscending != null)
                {
                    if (uIAGetElementPatternsmatchIndexAscending != null)
                    {
                        uIAGetElementPatterns["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAGetElementPatternsmatchIndexAscending);
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
                        uIAGetElementPatterns["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAGetElementPatternsmaxElementsToSearch);
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
                        uIAGetElementPatterns["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAGetElementPatternsmaxRelativeSearchDepth);
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
                        uIAGetElementPatterns["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAGetElementPatternsmaxChildElementsToSearchPerNode);
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
                    uIAGetElementPatterns["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAGetElementPatternselementLocalizedControlTypesNotToTraverse);
                    uIAGetElementPatternspropCount++;
                }

                uIAGetElementPatternspropCount++;
                uIAGetElementPatterns["Workflow"] = SourceExpressionConverter.ConvertToken(uIAGetElementPatternsworkflow);
                if (uIAGetElementPatternspropCount > 0)
                {
                    callPayload.Body = uIAGetElementPatterns;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAGetElementPatternsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAMoveElementResponse> UIAMoveElement([WorkflowExpression] Func<int> uIAMoveElementparentWindowHandle, [WorkflowExpression] Func<int> uIAMoveElementhorizontalPosition, [WorkflowExpression] Func<int> uIAMoveElementverticalPosition, [WorkflowExpression] Func<string> uIAMoveElementworkflow, [WorkflowExpression] Func<string> uIAMoveElementsearchElementName = null, [WorkflowExpression] Func<string> uIAMoveElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAMoveElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAMoveElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAMoveElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAMoveElementmatchIndex = null, [WorkflowExpression] Func<string> uIAMoveElementsearchFilter = null, [WorkflowExpression] Func<string> uIAMoveElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAMoveElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAMoveElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAMoveElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAMoveElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAMoveElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<uIAMoveElementhorizontalMovementTypeInput> uIAMoveElementhorizontalMovementType = null, [WorkflowExpression] Func<uIAMoveElementverticalMovementTypeInput> uIAMoveElementverticalMovementType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIAMoveElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAMoveElement = new JObject();
                var uIAMoveElementpropCount = 0;
                uIAMoveElementpropCount++;
                uIAMoveElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAMoveElementparentWindowHandle);
                if (uIAMoveElementsearchElementName != null)
                {
                    uIAMoveElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAMoveElementsearchElementName);
                    uIAMoveElementpropCount++;
                }

                if (uIAMoveElementsearchElementClassName != null)
                {
                    uIAMoveElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAMoveElementsearchElementClassName);
                    uIAMoveElementpropCount++;
                }

                if (uIAMoveElementsearchElementAutomationId != null)
                {
                    uIAMoveElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAMoveElementsearchElementAutomationId);
                    uIAMoveElementpropCount++;
                }

                if (uIAMoveElementsearchLocalizedControlType != null)
                {
                    uIAMoveElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAMoveElementsearchLocalizedControlType);
                    uIAMoveElementpropCount++;
                }

                if (uIAMoveElementsearchSubTree != null)
                {
                    if (uIAMoveElementsearchSubTree != null)
                    {
                        uIAMoveElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAMoveElementsearchSubTree);
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
                        uIAMoveElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAMoveElementmatchIndex);
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
                    uIAMoveElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAMoveElementsearchFilter);
                    uIAMoveElementpropCount++;
                }

                if (uIAMoveElementsortByColumn != null)
                {
                    uIAMoveElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAMoveElementsortByColumn);
                    uIAMoveElementpropCount++;
                }

                if (uIAMoveElementmatchIndexAscending != null)
                {
                    if (uIAMoveElementmatchIndexAscending != null)
                    {
                        uIAMoveElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAMoveElementmatchIndexAscending);
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
                        uIAMoveElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAMoveElementmaxElementsToSearch);
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
                        uIAMoveElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAMoveElementmaxRelativeSearchDepth);
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
                        uIAMoveElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAMoveElementmaxChildElementsToSearchPerNode);
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
                    uIAMoveElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAMoveElementelementLocalizedControlTypesNotToTraverse);
                    uIAMoveElementpropCount++;
                }

                if (uIAMoveElementhorizontalMovementType != null)
                {
                    if (uIAMoveElementhorizontalMovementType != null)
                    {
                        uIAMoveElement["HorizontalMovementType"] = SourceExpressionConverter.Convert(uIAMoveElementhorizontalMovementType);
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
                uIAMoveElement["HorizontalPosition"] = SourceExpressionConverter.ConvertToken(uIAMoveElementhorizontalPosition);
                if (uIAMoveElementverticalMovementType != null)
                {
                    if (uIAMoveElementverticalMovementType != null)
                    {
                        uIAMoveElement["VerticalMovementType"] = SourceExpressionConverter.Convert(uIAMoveElementverticalMovementType);
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
                uIAMoveElement["VerticalPosition"] = SourceExpressionConverter.ConvertToken(uIAMoveElementverticalPosition);
                uIAMoveElementpropCount++;
                uIAMoveElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIAMoveElementworkflow);
                if (uIAMoveElementpropCount > 0)
                {
                    callPayload.Body = uIAMoveElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAMoveElementResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAResizeElementResponse> UIAResizeElement([WorkflowExpression] Func<int> uIAResizeElementparentWindowHandle, [WorkflowExpression] Func<int> uIAResizeElementnewWidth, [WorkflowExpression] Func<int> uIAResizeElementnewHeight, [WorkflowExpression] Func<string> uIAResizeElementworkflow, [WorkflowExpression] Func<string> uIAResizeElementsearchElementName = null, [WorkflowExpression] Func<string> uIAResizeElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAResizeElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAResizeElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAResizeElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAResizeElementmatchIndex = null, [WorkflowExpression] Func<string> uIAResizeElementsearchFilter = null, [WorkflowExpression] Func<string> uIAResizeElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAResizeElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAResizeElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAResizeElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAResizeElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAResizeElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<uIAResizeElementresizeWidthTypeInput> uIAResizeElementresizeWidthType = null, [WorkflowExpression] Func<uIAResizeElementresizeHeightTypeInput> uIAResizeElementresizeHeightType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIAResizeElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAResizeElement = new JObject();
                var uIAResizeElementpropCount = 0;
                uIAResizeElementpropCount++;
                uIAResizeElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAResizeElementparentWindowHandle);
                if (uIAResizeElementsearchElementName != null)
                {
                    uIAResizeElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAResizeElementsearchElementName);
                    uIAResizeElementpropCount++;
                }

                if (uIAResizeElementsearchElementClassName != null)
                {
                    uIAResizeElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAResizeElementsearchElementClassName);
                    uIAResizeElementpropCount++;
                }

                if (uIAResizeElementsearchElementAutomationId != null)
                {
                    uIAResizeElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAResizeElementsearchElementAutomationId);
                    uIAResizeElementpropCount++;
                }

                if (uIAResizeElementsearchLocalizedControlType != null)
                {
                    uIAResizeElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAResizeElementsearchLocalizedControlType);
                    uIAResizeElementpropCount++;
                }

                if (uIAResizeElementsearchSubTree != null)
                {
                    if (uIAResizeElementsearchSubTree != null)
                    {
                        uIAResizeElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAResizeElementsearchSubTree);
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
                        uIAResizeElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAResizeElementmatchIndex);
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
                    uIAResizeElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAResizeElementsearchFilter);
                    uIAResizeElementpropCount++;
                }

                if (uIAResizeElementsortByColumn != null)
                {
                    uIAResizeElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAResizeElementsortByColumn);
                    uIAResizeElementpropCount++;
                }

                if (uIAResizeElementmatchIndexAscending != null)
                {
                    if (uIAResizeElementmatchIndexAscending != null)
                    {
                        uIAResizeElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAResizeElementmatchIndexAscending);
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
                        uIAResizeElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAResizeElementmaxElementsToSearch);
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
                        uIAResizeElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAResizeElementmaxRelativeSearchDepth);
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
                        uIAResizeElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAResizeElementmaxChildElementsToSearchPerNode);
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
                    uIAResizeElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAResizeElementelementLocalizedControlTypesNotToTraverse);
                    uIAResizeElementpropCount++;
                }

                if (uIAResizeElementresizeWidthType != null)
                {
                    if (uIAResizeElementresizeWidthType != null)
                    {
                        uIAResizeElement["ResizeWidthType"] = SourceExpressionConverter.Convert(uIAResizeElementresizeWidthType);
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
                uIAResizeElement["NewWidth"] = SourceExpressionConverter.ConvertToken(uIAResizeElementnewWidth);
                if (uIAResizeElementresizeHeightType != null)
                {
                    if (uIAResizeElementresizeHeightType != null)
                    {
                        uIAResizeElement["ResizeHeightType"] = SourceExpressionConverter.Convert(uIAResizeElementresizeHeightType);
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
                uIAResizeElement["NewHeight"] = SourceExpressionConverter.ConvertToken(uIAResizeElementnewHeight);
                uIAResizeElementpropCount++;
                uIAResizeElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIAResizeElementworkflow);
                if (uIAResizeElementpropCount > 0)
                {
                    callPayload.Body = uIAResizeElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAResizeElementResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIALocateVisibleSearchImageWithinElementResponse> UIALocateVisibleSearchImageWithinElement([WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementparentWindowHandle, [WorkflowExpression] Func<string> uIALocateVisibleSearchImageWithinElementworkflow, [WorkflowExpression] Func<string> uIALocateVisibleSearchImageWithinElementsearchElementName = null, [WorkflowExpression] Func<string> uIALocateVisibleSearchImageWithinElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIALocateVisibleSearchImageWithinElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIALocateVisibleSearchImageWithinElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIALocateVisibleSearchImageWithinElementsearchSubTree = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementmatchIndex = null, [WorkflowExpression] Func<string> uIALocateVisibleSearchImageWithinElementsearchFilter = null, [WorkflowExpression] Func<string> uIALocateVisibleSearchImageWithinElementsortByColumn = null, [WorkflowExpression] Func<bool> uIALocateVisibleSearchImageWithinElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIALocateVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<uIALocateVisibleSearchImageWithinElementsearchImageTypeInput> uIALocateVisibleSearchImageWithinElementsearchImageType = null, [WorkflowExpression] Func<string> uIALocateVisibleSearchImageWithinElementsearchImage = null, [WorkflowExpression] Func<uIALocateVisibleSearchImageWithinElementaltSearchImageTypeInput> uIALocateVisibleSearchImageWithinElementaltSearchImageType = null, [WorkflowExpression] Func<string> uIALocateVisibleSearchImageWithinElementaltSearchImage = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementmaxColourDeviation = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementmaxPixelDifferences = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementmaxConsecutivePixelDifferences = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementleftPixelXOffset = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementrightPixelXOffset = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementtopPixelYOffset = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementbottomPixelYOffset = null, [WorkflowExpression] Func<uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnitInput> uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnit = null, [WorkflowExpression] Func<uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnitInput> uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnit = null, [WorkflowExpression] Func<int> uIALocateVisibleSearchImageWithinElementsearchImageIndex = null, [WorkflowExpression] Func<uIALocateVisibleSearchImageWithinElementimageSearchDirectionInput> uIALocateVisibleSearchImageWithinElementimageSearchDirection = null, [WorkflowExpression] Func<bool> uIALocateVisibleSearchImageWithinElementhideAgent = null, [WorkflowExpression] Func<bool> uIALocateVisibleSearchImageWithinElementreturnPhysicalCoordinates = null, [WorkflowExpression] Func<bool> uIALocateVisibleSearchImageWithinElementshowHighlightRectangle = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIALocateVisibleSearchImageWithinElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIALocateVisibleSearchImageWithinElement = new JObject();
                var uIALocateVisibleSearchImageWithinElementpropCount = 0;
                uIALocateVisibleSearchImageWithinElementpropCount++;
                uIALocateVisibleSearchImageWithinElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementparentWindowHandle);
                if (uIALocateVisibleSearchImageWithinElementsearchElementName != null)
                {
                    uIALocateVisibleSearchImageWithinElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementsearchElementName);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (uIALocateVisibleSearchImageWithinElementsearchElementClassName != null)
                {
                    uIALocateVisibleSearchImageWithinElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementsearchElementClassName);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (uIALocateVisibleSearchImageWithinElementsearchElementAutomationId != null)
                {
                    uIALocateVisibleSearchImageWithinElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementsearchElementAutomationId);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (uIALocateVisibleSearchImageWithinElementsearchLocalizedControlType != null)
                {
                    uIALocateVisibleSearchImageWithinElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementsearchLocalizedControlType);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (uIALocateVisibleSearchImageWithinElementsearchSubTree != null)
                {
                    if (uIALocateVisibleSearchImageWithinElementsearchSubTree != null)
                    {
                        uIALocateVisibleSearchImageWithinElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementsearchSubTree);
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
                        uIALocateVisibleSearchImageWithinElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementmatchIndex);
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
                    uIALocateVisibleSearchImageWithinElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementsearchFilter);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (uIALocateVisibleSearchImageWithinElementsortByColumn != null)
                {
                    uIALocateVisibleSearchImageWithinElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementsortByColumn);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (uIALocateVisibleSearchImageWithinElementmatchIndexAscending != null)
                {
                    if (uIALocateVisibleSearchImageWithinElementmatchIndexAscending != null)
                    {
                        uIALocateVisibleSearchImageWithinElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementmatchIndexAscending);
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
                        uIALocateVisibleSearchImageWithinElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementmaxElementsToSearch);
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
                        uIALocateVisibleSearchImageWithinElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementmaxRelativeSearchDepth);
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
                        uIALocateVisibleSearchImageWithinElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode);
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
                    uIALocateVisibleSearchImageWithinElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (uIALocateVisibleSearchImageWithinElementsearchImageType != null)
                {
                    uIALocateVisibleSearchImageWithinElement["SearchImageType"] = SourceExpressionConverter.Convert(uIALocateVisibleSearchImageWithinElementsearchImageType);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (uIALocateVisibleSearchImageWithinElementsearchImage != null)
                {
                    uIALocateVisibleSearchImageWithinElement["SearchImage"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementsearchImage);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (uIALocateVisibleSearchImageWithinElementaltSearchImageType != null)
                {
                    if (uIALocateVisibleSearchImageWithinElementaltSearchImageType != null)
                    {
                        uIALocateVisibleSearchImageWithinElement["AltSearchImageType"] = SourceExpressionConverter.Convert(uIALocateVisibleSearchImageWithinElementaltSearchImageType);
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
                    uIALocateVisibleSearchImageWithinElement["AltSearchImage"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementaltSearchImage);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (uIALocateVisibleSearchImageWithinElementmaxColourDeviation != null)
                {
                    if (uIALocateVisibleSearchImageWithinElementmaxColourDeviation != null)
                    {
                        uIALocateVisibleSearchImageWithinElement["MaxColourDeviation"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementmaxColourDeviation);
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
                        uIALocateVisibleSearchImageWithinElement["MaxPixelDifferences"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementmaxPixelDifferences);
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
                        uIALocateVisibleSearchImageWithinElement["MaxConsecutivePixelDifferences"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementmaxConsecutivePixelDifferences);
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
                    uIALocateVisibleSearchImageWithinElement["LeftPixelXOffset"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementleftPixelXOffset);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (uIALocateVisibleSearchImageWithinElementrightPixelXOffset != null)
                {
                    uIALocateVisibleSearchImageWithinElement["RightPixelXOffset"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementrightPixelXOffset);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (uIALocateVisibleSearchImageWithinElementtopPixelYOffset != null)
                {
                    uIALocateVisibleSearchImageWithinElement["TopPixelYOffset"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementtopPixelYOffset);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (uIALocateVisibleSearchImageWithinElementbottomPixelYOffset != null)
                {
                    uIALocateVisibleSearchImageWithinElement["BottomPixelYOffset"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementbottomPixelYOffset);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnit != null)
                {
                    if (uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnit != null)
                    {
                        uIALocateVisibleSearchImageWithinElement["PixelXOffsetsUnit"] = SourceExpressionConverter.Convert(uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnit);
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
                        uIALocateVisibleSearchImageWithinElement["PixelYOffsetsUnit"] = SourceExpressionConverter.Convert(uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnit);
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
                        uIALocateVisibleSearchImageWithinElement["SearchImageIndex"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementsearchImageIndex);
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
                        uIALocateVisibleSearchImageWithinElement["ImageSearchDirection"] = SourceExpressionConverter.Convert(uIALocateVisibleSearchImageWithinElementimageSearchDirection);
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
                        uIALocateVisibleSearchImageWithinElement["HideAgent"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementhideAgent);
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
                        uIALocateVisibleSearchImageWithinElement["ReturnPhysicalCoordinates"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementreturnPhysicalCoordinates);
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
                        uIALocateVisibleSearchImageWithinElement["ShowHighlightRectangle"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementshowHighlightRectangle);
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
                uIALocateVisibleSearchImageWithinElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIALocateVisibleSearchImageWithinElementworkflow);
                if (uIALocateVisibleSearchImageWithinElementpropCount > 0)
                {
                    callPayload.Body = uIALocateVisibleSearchImageWithinElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIALocateVisibleSearchImageWithinElementResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForVisibleSearchImageWithinElementResponse> UIAWaitForVisibleSearchImageWithinElement([WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageWithinElementworkflow, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementparentWindowHandle = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageWithinElementsearchElementName = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageWithinElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageWithinElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageWithinElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageWithinElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementmatchIndex = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageWithinElementsearchFilter = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageWithinElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageWithinElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<uIAWaitForVisibleSearchImageWithinElementsearchImageTypeInput> uIAWaitForVisibleSearchImageWithinElementsearchImageType = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageWithinElementsearchImage = null, [WorkflowExpression] Func<uIAWaitForVisibleSearchImageWithinElementaltSearchImageTypeInput> uIAWaitForVisibleSearchImageWithinElementaltSearchImageType = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageWithinElementaltSearchImage = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementmaxColourDeviation = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementmaxPixelDifferences = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementmaxConsecutivePixelDifferences = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementleftPixelXOffset = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementrightPixelXOffset = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementtopPixelYOffset = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementbottomPixelYOffset = null, [WorkflowExpression] Func<uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnitInput> uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnit = null, [WorkflowExpression] Func<uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnitInput> uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnit = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementsearchImageIndex = null, [WorkflowExpression] Func<uIAWaitForVisibleSearchImageWithinElementimageSearchDirectionInput> uIAWaitForVisibleSearchImageWithinElementimageSearchDirection = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageWithinElementhideAgent = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageWithinElementreturnPhysicalCoordinates = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageWithinElementshowHighlightRectangle = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementsecondsToWait = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementmillisecondsBetweenSearches = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageWithinElementraiseExceptionIfImageNotFound = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageWithinElementretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageWithinElementwaitForThread = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIAWaitForVisibleSearchImageWithinElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAWaitForVisibleSearchImageWithinElement = new JObject();
                var uIAWaitForVisibleSearchImageWithinElementpropCount = 0;
                if (uIAWaitForVisibleSearchImageWithinElementparentWindowHandle != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementparentWindowHandle);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageWithinElementsearchElementName != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementsearchElementName);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageWithinElementsearchElementClassName != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementsearchElementClassName);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageWithinElementsearchElementAutomationId != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementsearchElementAutomationId);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageWithinElementsearchLocalizedControlType != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementsearchLocalizedControlType);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageWithinElementsearchSubTree != null)
                {
                    if (uIAWaitForVisibleSearchImageWithinElementsearchSubTree != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementsearchSubTree);
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
                        uIAWaitForVisibleSearchImageWithinElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementmatchIndex);
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
                    uIAWaitForVisibleSearchImageWithinElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementsearchFilter);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageWithinElementsortByColumn != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementsortByColumn);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageWithinElementmatchIndexAscending != null)
                {
                    if (uIAWaitForVisibleSearchImageWithinElementmatchIndexAscending != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementmatchIndexAscending);
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
                        uIAWaitForVisibleSearchImageWithinElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementmaxElementsToSearch);
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
                        uIAWaitForVisibleSearchImageWithinElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementmaxRelativeSearchDepth);
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
                        uIAWaitForVisibleSearchImageWithinElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode);
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
                    uIAWaitForVisibleSearchImageWithinElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageWithinElementsearchImageType != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["SearchImageType"] = SourceExpressionConverter.Convert(uIAWaitForVisibleSearchImageWithinElementsearchImageType);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageWithinElementsearchImage != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["SearchImage"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementsearchImage);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageWithinElementaltSearchImageType != null)
                {
                    if (uIAWaitForVisibleSearchImageWithinElementaltSearchImageType != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["AltSearchImageType"] = SourceExpressionConverter.Convert(uIAWaitForVisibleSearchImageWithinElementaltSearchImageType);
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
                    uIAWaitForVisibleSearchImageWithinElement["AltSearchImage"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementaltSearchImage);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageWithinElementmaxColourDeviation != null)
                {
                    if (uIAWaitForVisibleSearchImageWithinElementmaxColourDeviation != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["MaxColourDeviation"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementmaxColourDeviation);
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
                        uIAWaitForVisibleSearchImageWithinElement["MaxPixelDifferences"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementmaxPixelDifferences);
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
                        uIAWaitForVisibleSearchImageWithinElement["MaxConsecutivePixelDifferences"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementmaxConsecutivePixelDifferences);
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
                    uIAWaitForVisibleSearchImageWithinElement["LeftPixelXOffset"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementleftPixelXOffset);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageWithinElementrightPixelXOffset != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["RightPixelXOffset"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementrightPixelXOffset);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageWithinElementtopPixelYOffset != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["TopPixelYOffset"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementtopPixelYOffset);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageWithinElementbottomPixelYOffset != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["BottomPixelYOffset"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementbottomPixelYOffset);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnit != null)
                {
                    if (uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnit != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["PixelXOffsetsUnit"] = SourceExpressionConverter.Convert(uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnit);
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
                        uIAWaitForVisibleSearchImageWithinElement["PixelYOffsetsUnit"] = SourceExpressionConverter.Convert(uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnit);
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
                        uIAWaitForVisibleSearchImageWithinElement["SearchImageIndex"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementsearchImageIndex);
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
                        uIAWaitForVisibleSearchImageWithinElement["ImageSearchDirection"] = SourceExpressionConverter.Convert(uIAWaitForVisibleSearchImageWithinElementimageSearchDirection);
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
                        uIAWaitForVisibleSearchImageWithinElement["HideAgent"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementhideAgent);
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
                        uIAWaitForVisibleSearchImageWithinElement["ReturnPhysicalCoordinates"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementreturnPhysicalCoordinates);
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
                        uIAWaitForVisibleSearchImageWithinElement["ShowHighlightRectangle"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementshowHighlightRectangle);
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
                        uIAWaitForVisibleSearchImageWithinElement["SecondsToWait"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementsecondsToWait);
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
                        uIAWaitForVisibleSearchImageWithinElement["MillisecondsBetweenSearches"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementmillisecondsBetweenSearches);
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
                        uIAWaitForVisibleSearchImageWithinElement["RaiseExceptionIfImageNotFound"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementraiseExceptionIfImageNotFound);
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
                    uIAWaitForVisibleSearchImageWithinElement["RetrieveOutputDataFromThreadId"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementretrieveOutputDataFromThreadId);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageWithinElementwaitForThread != null)
                {
                    if (uIAWaitForVisibleSearchImageWithinElementwaitForThread != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["WaitForThread"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementwaitForThread);
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
                uIAWaitForVisibleSearchImageWithinElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageWithinElementworkflow);
                if (uIAWaitForVisibleSearchImageWithinElementpropCount > 0)
                {
                    callPayload.Body = uIAWaitForVisibleSearchImageWithinElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAWaitForVisibleSearchImageWithinElementResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForVisibleSearchImageToNotExistWithinElementResponse> UIAWaitForVisibleSearchImageToNotExistWithinElement([WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageToNotExistWithinElementworkflow, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementparentWindowHandle = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementName = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementClassName = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementAutomationId = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchSubTree = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndex = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchFilter = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageToNotExistWithinElementsortByColumn = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndexAscending = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxElementsToSearch = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxRelativeSearchDepth = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageToNotExistWithinElementelementLocalizedControlTypesNotToTraverse = null, [WorkflowExpression] Func<uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageTypeInput> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageType = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImage = null, [WorkflowExpression] Func<uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageTypeInput> uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageType = null, [WorkflowExpression] Func<string> uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImage = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxColourDeviation = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxPixelDifferences = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxConsecutivePixelDifferences = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementleftPixelXOffset = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementrightPixelXOffset = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementtopPixelYOffset = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementbottomPixelYOffset = null, [WorkflowExpression] Func<uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnitInput> uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnit = null, [WorkflowExpression] Func<uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnitInput> uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnit = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageIndex = null, [WorkflowExpression] Func<uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirectionInput> uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirection = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageToNotExistWithinElementhideAgent = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageToNotExistWithinElementshowHighlightRectangle = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementsecondsToWait = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementmillisecondsBetweenSearches = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageToNotExistWithinElementraiseExceptionIfImageStillPresent = null, [WorkflowExpression] Func<int> uIAWaitForVisibleSearchImageToNotExistWithinElementretrieveOutputDataFromThreadId = null, [WorkflowExpression] Func<bool> uIAWaitForVisibleSearchImageToNotExistWithinElementwaitForThread = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/UIAControl/UIAWaitForVisibleSearchImageToNotExistWithinElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAWaitForVisibleSearchImageToNotExistWithinElement = new JObject();
                var uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount = 0;
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementparentWindowHandle != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementparentWindowHandle);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementName != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchElementName"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementName);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementClassName != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementClassName);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementAutomationId != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementAutomationId);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchLocalizedControlType != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchLocalizedControlType);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchSubTree != null)
                {
                    if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchSubTree != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchSubTree);
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
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndex);
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
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchFilter);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageToNotExistWithinElementsortByColumn != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementsortByColumn);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndexAscending != null)
                {
                    if (uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndexAscending != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndexAscending);
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
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxElementsToSearch"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxElementsToSearch);
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
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxRelativeSearchDepth"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxRelativeSearchDepth);
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
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxChildElementsToSearchPerNode);
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
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["ElementLocalizedControlTypesNotToTraverse"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementelementLocalizedControlTypesNotToTraverse);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageType != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchImageType"] = SourceExpressionConverter.Convert(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageType);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImage != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchImage"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImage);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageType != null)
                {
                    if (uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageType != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["AltSearchImageType"] = SourceExpressionConverter.Convert(uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageType);
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
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["AltSearchImage"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImage);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageToNotExistWithinElementmaxColourDeviation != null)
                {
                    if (uIAWaitForVisibleSearchImageToNotExistWithinElementmaxColourDeviation != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxColourDeviation"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxColourDeviation);
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
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxPixelDifferences"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxPixelDifferences);
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
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxConsecutivePixelDifferences"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxConsecutivePixelDifferences);
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
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["LeftPixelXOffset"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementleftPixelXOffset);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageToNotExistWithinElementrightPixelXOffset != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["RightPixelXOffset"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementrightPixelXOffset);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageToNotExistWithinElementtopPixelYOffset != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["TopPixelYOffset"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementtopPixelYOffset);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageToNotExistWithinElementbottomPixelYOffset != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["BottomPixelYOffset"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementbottomPixelYOffset);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnit != null)
                {
                    if (uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnit != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["PixelXOffsetsUnit"] = SourceExpressionConverter.Convert(uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnit);
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
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["PixelYOffsetsUnit"] = SourceExpressionConverter.Convert(uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnit);
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
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchImageIndex"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageIndex);
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
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["ImageSearchDirection"] = SourceExpressionConverter.Convert(uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirection);
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
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["HideAgent"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementhideAgent);
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
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["ShowHighlightRectangle"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementshowHighlightRectangle);
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
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["SecondsToWait"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementsecondsToWait);
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
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["MillisecondsBetweenSearches"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementmillisecondsBetweenSearches);
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
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["RaiseExceptionIfImageStillPresent"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementraiseExceptionIfImageStillPresent);
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
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["RetrieveOutputDataFromThreadId"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementretrieveOutputDataFromThreadId);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (uIAWaitForVisibleSearchImageToNotExistWithinElementwaitForThread != null)
                {
                    if (uIAWaitForVisibleSearchImageToNotExistWithinElementwaitForThread != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["WaitForThread"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementwaitForThread);
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
                uIAWaitForVisibleSearchImageToNotExistWithinElement["Workflow"] = SourceExpressionConverter.ConvertToken(uIAWaitForVisibleSearchImageToNotExistWithinElementworkflow);
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount > 0)
                {
                    callPayload.Body = uIAWaitForVisibleSearchImageToNotExistWithinElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UIAWaitForVisibleSearchImageToNotExistWithinElementResponse>(BuildSourceInput);
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