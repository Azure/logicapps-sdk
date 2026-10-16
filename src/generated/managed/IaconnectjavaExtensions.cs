//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectjava
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class IaconnectjavaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABConnectToJavaAccessBridgeResponse> JABConnectToJavaAccessBridge(Expression<Func<string>> jABConnectToJavaAccessBridgeworkflow, Expression<Func<string>> jABConnectToJavaAccessBridgewindowsAccessBridgeDLLSearchFolder = null, Expression<Func<string>> jABConnectToJavaAccessBridgeiAJavaAccessBridgePath = null, Expression<Func<bool>> jABConnectToJavaAccessBridgeis64BitJABDLL = null, Expression<Func<bool>> jABConnectToJavaAccessBridgeuseCOMFor64BitJABDLL = null, Expression<Func<bool>> jABConnectToJavaAccessBridgeenableJavaAccessBridge = null, Expression<Func<string>> jABConnectToJavaAccessBridgeaccessibilityFilepath = null, Expression<Func<int>> jABConnectToJavaAccessBridgecommandTimeoutInSeconds = null)
        {
            var __workflow_jABConnectToJavaAccessBridgeworkflow = WorkflowExpression.Compile(jABConnectToJavaAccessBridgeworkflow, nameof(jABConnectToJavaAccessBridgeworkflow), required: true);
            var __workflow_jABConnectToJavaAccessBridgewindowsAccessBridgeDLLSearchFolder = WorkflowExpression.Compile(jABConnectToJavaAccessBridgewindowsAccessBridgeDLLSearchFolder, nameof(jABConnectToJavaAccessBridgewindowsAccessBridgeDLLSearchFolder), required: false);
            var __workflow_jABConnectToJavaAccessBridgeiAJavaAccessBridgePath = WorkflowExpression.Compile(jABConnectToJavaAccessBridgeiAJavaAccessBridgePath, nameof(jABConnectToJavaAccessBridgeiAJavaAccessBridgePath), required: false);
            var __workflow_jABConnectToJavaAccessBridgeis64BitJABDLL = WorkflowExpression.Compile(jABConnectToJavaAccessBridgeis64BitJABDLL, nameof(jABConnectToJavaAccessBridgeis64BitJABDLL), required: false);
            var __workflow_jABConnectToJavaAccessBridgeuseCOMFor64BitJABDLL = WorkflowExpression.Compile(jABConnectToJavaAccessBridgeuseCOMFor64BitJABDLL, nameof(jABConnectToJavaAccessBridgeuseCOMFor64BitJABDLL), required: false);
            var __workflow_jABConnectToJavaAccessBridgeenableJavaAccessBridge = WorkflowExpression.Compile(jABConnectToJavaAccessBridgeenableJavaAccessBridge, nameof(jABConnectToJavaAccessBridgeenableJavaAccessBridge), required: false);
            var __workflow_jABConnectToJavaAccessBridgeaccessibilityFilepath = WorkflowExpression.Compile(jABConnectToJavaAccessBridgeaccessibilityFilepath, nameof(jABConnectToJavaAccessBridgeaccessibilityFilepath), required: false);
            var __workflow_jABConnectToJavaAccessBridgecommandTimeoutInSeconds = WorkflowExpression.Compile(jABConnectToJavaAccessBridgecommandTimeoutInSeconds, nameof(jABConnectToJavaAccessBridgecommandTimeoutInSeconds), required: false);
            return new DeferredBodyAction<JABConnectToJavaAccessBridgeResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABConnectToJavaAccessBridge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABConnectToJavaAccessBridge = new JObject();
                var jABConnectToJavaAccessBridgepropCount = 0;
                if (__workflow_jABConnectToJavaAccessBridgewindowsAccessBridgeDLLSearchFolder != null)
                {
                    jABConnectToJavaAccessBridge["WindowsAccessBridgeDLLSearchFolder"] = ExpressionConverter.ConvertO(__workflow_jABConnectToJavaAccessBridgewindowsAccessBridgeDLLSearchFolder);
                    jABConnectToJavaAccessBridgepropCount++;
                }

                if (__workflow_jABConnectToJavaAccessBridgeiAJavaAccessBridgePath != null)
                {
                    jABConnectToJavaAccessBridge["IAJavaAccessBridgePath"] = ExpressionConverter.ConvertO(__workflow_jABConnectToJavaAccessBridgeiAJavaAccessBridgePath);
                    jABConnectToJavaAccessBridgepropCount++;
                }

                if (__workflow_jABConnectToJavaAccessBridgeis64BitJABDLL != null)
                {
                    if (__workflow_jABConnectToJavaAccessBridgeis64BitJABDLL != null)
                    {
                        jABConnectToJavaAccessBridge["Is64BitJABDLL"] = ExpressionConverter.ConvertO(__workflow_jABConnectToJavaAccessBridgeis64BitJABDLL);
                        jABConnectToJavaAccessBridgepropCount++;
                    }

                    jABConnectToJavaAccessBridgepropCount++;
                }
                else
                {
                    jABConnectToJavaAccessBridge["Is64BitJABDLL"] = false;
                    jABConnectToJavaAccessBridgepropCount++;
                }

                if (__workflow_jABConnectToJavaAccessBridgeuseCOMFor64BitJABDLL != null)
                {
                    if (__workflow_jABConnectToJavaAccessBridgeuseCOMFor64BitJABDLL != null)
                    {
                        jABConnectToJavaAccessBridge["UseCOMFor64BitJABDLL"] = ExpressionConverter.ConvertO(__workflow_jABConnectToJavaAccessBridgeuseCOMFor64BitJABDLL);
                        jABConnectToJavaAccessBridgepropCount++;
                    }

                    jABConnectToJavaAccessBridgepropCount++;
                }
                else
                {
                    jABConnectToJavaAccessBridge["UseCOMFor64BitJABDLL"] = true;
                    jABConnectToJavaAccessBridgepropCount++;
                }

                if (__workflow_jABConnectToJavaAccessBridgeenableJavaAccessBridge != null)
                {
                    if (__workflow_jABConnectToJavaAccessBridgeenableJavaAccessBridge != null)
                    {
                        jABConnectToJavaAccessBridge["EnableJavaAccessBridge"] = ExpressionConverter.ConvertO(__workflow_jABConnectToJavaAccessBridgeenableJavaAccessBridge);
                        jABConnectToJavaAccessBridgepropCount++;
                    }

                    jABConnectToJavaAccessBridgepropCount++;
                }
                else
                {
                    jABConnectToJavaAccessBridge["EnableJavaAccessBridge"] = true;
                    jABConnectToJavaAccessBridgepropCount++;
                }

                if (__workflow_jABConnectToJavaAccessBridgeaccessibilityFilepath != null)
                {
                    if (__workflow_jABConnectToJavaAccessBridgeaccessibilityFilepath != null)
                    {
                        jABConnectToJavaAccessBridge["AccessibilityFilepath"] = ExpressionConverter.ConvertO(__workflow_jABConnectToJavaAccessBridgeaccessibilityFilepath);
                        jABConnectToJavaAccessBridgepropCount++;
                    }

                    jABConnectToJavaAccessBridgepropCount++;
                }
                else
                {
                    jABConnectToJavaAccessBridge["AccessibilityFilepath"] = "%USERPROFILE%\\.accessibility.properties";
                    jABConnectToJavaAccessBridgepropCount++;
                }

                if (__workflow_jABConnectToJavaAccessBridgecommandTimeoutInSeconds != null)
                {
                    if (__workflow_jABConnectToJavaAccessBridgecommandTimeoutInSeconds != null)
                    {
                        jABConnectToJavaAccessBridge["CommandTimeoutInSeconds"] = ExpressionConverter.ConvertO(__workflow_jABConnectToJavaAccessBridgecommandTimeoutInSeconds);
                        jABConnectToJavaAccessBridgepropCount++;
                    }

                    jABConnectToJavaAccessBridgepropCount++;
                }
                else
                {
                    jABConnectToJavaAccessBridge["CommandTimeoutInSeconds"] = 20;
                    jABConnectToJavaAccessBridgepropCount++;
                }

                jABConnectToJavaAccessBridgepropCount++;
                jABConnectToJavaAccessBridge["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABConnectToJavaAccessBridgeworkflow);
                if (jABConnectToJavaAccessBridgepropCount > 0)
                {
                    callPayload.Body = jABConnectToJavaAccessBridge;
                }

                return new ApiConnectionAction<JABConnectToJavaAccessBridgeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABDisconnectFromJavaAccessBridge(Expression<Func<string>> jABDisconnectFromJavaAccessBridgeworkflow, Expression<Func<bool>> jABDisconnectFromJavaAccessBridgedisableJavaAccessBridge = null, Expression<Func<string>> jABDisconnectFromJavaAccessBridgeaccessibilityFilepath = null)
        {
            var __workflow_jABDisconnectFromJavaAccessBridgeworkflow = WorkflowExpression.Compile(jABDisconnectFromJavaAccessBridgeworkflow, nameof(jABDisconnectFromJavaAccessBridgeworkflow), required: true);
            var __workflow_jABDisconnectFromJavaAccessBridgedisableJavaAccessBridge = WorkflowExpression.Compile(jABDisconnectFromJavaAccessBridgedisableJavaAccessBridge, nameof(jABDisconnectFromJavaAccessBridgedisableJavaAccessBridge), required: false);
            var __workflow_jABDisconnectFromJavaAccessBridgeaccessibilityFilepath = WorkflowExpression.Compile(jABDisconnectFromJavaAccessBridgeaccessibilityFilepath, nameof(jABDisconnectFromJavaAccessBridgeaccessibilityFilepath), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABDisconnectFromJavaAccessBridge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABDisconnectFromJavaAccessBridge = new JObject();
                var jABDisconnectFromJavaAccessBridgepropCount = 0;
                if (__workflow_jABDisconnectFromJavaAccessBridgedisableJavaAccessBridge != null)
                {
                    if (__workflow_jABDisconnectFromJavaAccessBridgedisableJavaAccessBridge != null)
                    {
                        jABDisconnectFromJavaAccessBridge["DisableJavaAccessBridge"] = ExpressionConverter.ConvertO(__workflow_jABDisconnectFromJavaAccessBridgedisableJavaAccessBridge);
                        jABDisconnectFromJavaAccessBridgepropCount++;
                    }

                    jABDisconnectFromJavaAccessBridgepropCount++;
                }
                else
                {
                    jABDisconnectFromJavaAccessBridge["DisableJavaAccessBridge"] = true;
                    jABDisconnectFromJavaAccessBridgepropCount++;
                }

                if (__workflow_jABDisconnectFromJavaAccessBridgeaccessibilityFilepath != null)
                {
                    if (__workflow_jABDisconnectFromJavaAccessBridgeaccessibilityFilepath != null)
                    {
                        jABDisconnectFromJavaAccessBridge["AccessibilityFilepath"] = ExpressionConverter.ConvertO(__workflow_jABDisconnectFromJavaAccessBridgeaccessibilityFilepath);
                        jABDisconnectFromJavaAccessBridgepropCount++;
                    }

                    jABDisconnectFromJavaAccessBridgepropCount++;
                }
                else
                {
                    jABDisconnectFromJavaAccessBridge["AccessibilityFilepath"] = "%USERPROFILE%\\.accessibility.properties";
                    jABDisconnectFromJavaAccessBridgepropCount++;
                }

                jABDisconnectFromJavaAccessBridgepropCount++;
                jABDisconnectFromJavaAccessBridge["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABDisconnectFromJavaAccessBridgeworkflow);
                if (jABDisconnectFromJavaAccessBridgepropCount > 0)
                {
                    callPayload.Body = jABDisconnectFromJavaAccessBridge;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetConnectionStatusResponse> JABGetConnectionStatus(Expression<Func<string>> jABGetConnectionStatusworkflow)
        {
            var __workflow_jABGetConnectionStatusworkflow = WorkflowExpression.Compile(jABGetConnectionStatusworkflow, nameof(jABGetConnectionStatusworkflow), required: true);
            return new DeferredBodyAction<JABGetConnectionStatusResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetConnectionStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetConnectionStatus = new JObject();
                var jABGetConnectionStatuspropCount = 0;
                jABGetConnectionStatuspropCount++;
                jABGetConnectionStatus["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetConnectionStatusworkflow);
                if (jABGetConnectionStatuspropCount > 0)
                {
                    callPayload.Body = jABGetConnectionStatus;
                }

                return new ApiConnectionAction<JABGetConnectionStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABIsJavaWindowResponse> JABIsJavaWindow(Expression<Func<int>> jABIsJavaWindowparentWindowHandle, Expression<Func<string>> jABIsJavaWindowworkflow, Expression<Func<string>> jABIsJavaWindowsearchElementName = null, Expression<Func<string>> jABIsJavaWindowsearchElementClassName = null, Expression<Func<string>> jABIsJavaWindowsearchElementAutomationId = null, Expression<Func<string>> jABIsJavaWindowsearchLocalizedControlType = null, Expression<Func<bool>> jABIsJavaWindowsearchSubTree = null, Expression<Func<int>> jABIsJavaWindowmatchIndex = null, Expression<Func<string>> jABIsJavaWindowsearchFilter = null, Expression<Func<string>> jABIsJavaWindowsortByColumn = null, Expression<Func<bool>> jABIsJavaWindowmatchIndexAscending = null)
        {
            var __workflow_jABIsJavaWindowparentWindowHandle = WorkflowExpression.Compile(jABIsJavaWindowparentWindowHandle, nameof(jABIsJavaWindowparentWindowHandle), required: true);
            var __workflow_jABIsJavaWindowworkflow = WorkflowExpression.Compile(jABIsJavaWindowworkflow, nameof(jABIsJavaWindowworkflow), required: true);
            var __workflow_jABIsJavaWindowsearchElementName = WorkflowExpression.Compile(jABIsJavaWindowsearchElementName, nameof(jABIsJavaWindowsearchElementName), required: false);
            var __workflow_jABIsJavaWindowsearchElementClassName = WorkflowExpression.Compile(jABIsJavaWindowsearchElementClassName, nameof(jABIsJavaWindowsearchElementClassName), required: false);
            var __workflow_jABIsJavaWindowsearchElementAutomationId = WorkflowExpression.Compile(jABIsJavaWindowsearchElementAutomationId, nameof(jABIsJavaWindowsearchElementAutomationId), required: false);
            var __workflow_jABIsJavaWindowsearchLocalizedControlType = WorkflowExpression.Compile(jABIsJavaWindowsearchLocalizedControlType, nameof(jABIsJavaWindowsearchLocalizedControlType), required: false);
            var __workflow_jABIsJavaWindowsearchSubTree = WorkflowExpression.Compile(jABIsJavaWindowsearchSubTree, nameof(jABIsJavaWindowsearchSubTree), required: false);
            var __workflow_jABIsJavaWindowmatchIndex = WorkflowExpression.Compile(jABIsJavaWindowmatchIndex, nameof(jABIsJavaWindowmatchIndex), required: false);
            var __workflow_jABIsJavaWindowsearchFilter = WorkflowExpression.Compile(jABIsJavaWindowsearchFilter, nameof(jABIsJavaWindowsearchFilter), required: false);
            var __workflow_jABIsJavaWindowsortByColumn = WorkflowExpression.Compile(jABIsJavaWindowsortByColumn, nameof(jABIsJavaWindowsortByColumn), required: false);
            var __workflow_jABIsJavaWindowmatchIndexAscending = WorkflowExpression.Compile(jABIsJavaWindowmatchIndexAscending, nameof(jABIsJavaWindowmatchIndexAscending), required: false);
            return new DeferredBodyAction<JABIsJavaWindowResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABIsJavaWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABIsJavaWindow = new JObject();
                var jABIsJavaWindowpropCount = 0;
                jABIsJavaWindowpropCount++;
                jABIsJavaWindow["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_jABIsJavaWindowparentWindowHandle);
                if (__workflow_jABIsJavaWindowsearchElementName != null)
                {
                    jABIsJavaWindow["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_jABIsJavaWindowsearchElementName);
                    jABIsJavaWindowpropCount++;
                }

                if (__workflow_jABIsJavaWindowsearchElementClassName != null)
                {
                    jABIsJavaWindow["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_jABIsJavaWindowsearchElementClassName);
                    jABIsJavaWindowpropCount++;
                }

                if (__workflow_jABIsJavaWindowsearchElementAutomationId != null)
                {
                    jABIsJavaWindow["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_jABIsJavaWindowsearchElementAutomationId);
                    jABIsJavaWindowpropCount++;
                }

                if (__workflow_jABIsJavaWindowsearchLocalizedControlType != null)
                {
                    jABIsJavaWindow["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_jABIsJavaWindowsearchLocalizedControlType);
                    jABIsJavaWindowpropCount++;
                }

                if (__workflow_jABIsJavaWindowsearchSubTree != null)
                {
                    if (__workflow_jABIsJavaWindowsearchSubTree != null)
                    {
                        jABIsJavaWindow["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABIsJavaWindowsearchSubTree);
                        jABIsJavaWindowpropCount++;
                    }

                    jABIsJavaWindowpropCount++;
                }
                else
                {
                    jABIsJavaWindow["SearchSubTree"] = true;
                    jABIsJavaWindowpropCount++;
                }

                if (__workflow_jABIsJavaWindowmatchIndex != null)
                {
                    if (__workflow_jABIsJavaWindowmatchIndex != null)
                    {
                        jABIsJavaWindow["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABIsJavaWindowmatchIndex);
                        jABIsJavaWindowpropCount++;
                    }

                    jABIsJavaWindowpropCount++;
                }
                else
                {
                    jABIsJavaWindow["MatchIndex"] = 1;
                    jABIsJavaWindowpropCount++;
                }

                if (__workflow_jABIsJavaWindowsearchFilter != null)
                {
                    jABIsJavaWindow["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABIsJavaWindowsearchFilter);
                    jABIsJavaWindowpropCount++;
                }

                if (__workflow_jABIsJavaWindowsortByColumn != null)
                {
                    jABIsJavaWindow["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABIsJavaWindowsortByColumn);
                    jABIsJavaWindowpropCount++;
                }

                if (__workflow_jABIsJavaWindowmatchIndexAscending != null)
                {
                    if (__workflow_jABIsJavaWindowmatchIndexAscending != null)
                    {
                        jABIsJavaWindow["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABIsJavaWindowmatchIndexAscending);
                        jABIsJavaWindowpropCount++;
                    }

                    jABIsJavaWindowpropCount++;
                }
                else
                {
                    jABIsJavaWindow["MatchIndexAscending"] = true;
                    jABIsJavaWindowpropCount++;
                }

                jABIsJavaWindowpropCount++;
                jABIsJavaWindow["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABIsJavaWindowworkflow);
                if (jABIsJavaWindowpropCount > 0)
                {
                    callPayload.Body = jABIsJavaWindow;
                }

                return new ApiConnectionAction<JABIsJavaWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetWindowsAccessBridgeInfoResponse> JABGetWindowsAccessBridgeInfo(Expression<Func<int>> jABGetWindowsAccessBridgeInfovMID, Expression<Func<string>> jABGetWindowsAccessBridgeInfoworkflow)
        {
            var __workflow_jABGetWindowsAccessBridgeInfovMID = WorkflowExpression.Compile(jABGetWindowsAccessBridgeInfovMID, nameof(jABGetWindowsAccessBridgeInfovMID), required: true);
            var __workflow_jABGetWindowsAccessBridgeInfoworkflow = WorkflowExpression.Compile(jABGetWindowsAccessBridgeInfoworkflow, nameof(jABGetWindowsAccessBridgeInfoworkflow), required: true);
            return new DeferredBodyAction<JABGetWindowsAccessBridgeInfoResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetWindowsAccessBridgeInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetWindowsAccessBridgeInfo = new JObject();
                var jABGetWindowsAccessBridgeInfopropCount = 0;
                jABGetWindowsAccessBridgeInfopropCount++;
                jABGetWindowsAccessBridgeInfo["VMID"] = ExpressionConverter.ConvertO(__workflow_jABGetWindowsAccessBridgeInfovMID);
                jABGetWindowsAccessBridgeInfopropCount++;
                jABGetWindowsAccessBridgeInfo["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetWindowsAccessBridgeInfoworkflow);
                if (jABGetWindowsAccessBridgeInfopropCount > 0)
                {
                    callPayload.Body = jABGetWindowsAccessBridgeInfo;
                }

                return new ApiConnectionAction<JABGetWindowsAccessBridgeInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetUIAElementPropertiesResponse> JABGetUIAElementProperties(Expression<Func<int>> jABGetUIAElementPropertiesparentWindowHandle, Expression<Func<string>> jABGetUIAElementPropertiesworkflow, Expression<Func<string>> jABGetUIAElementPropertiessearchElementName = null, Expression<Func<string>> jABGetUIAElementPropertiessearchElementClassName = null, Expression<Func<string>> jABGetUIAElementPropertiessearchElementAutomationId = null, Expression<Func<string>> jABGetUIAElementPropertiessearchLocalizedControlType = null, Expression<Func<bool>> jABGetUIAElementPropertiessearchSubTree = null, Expression<Func<int>> jABGetUIAElementPropertiesmatchIndex = null, Expression<Func<string>> jABGetUIAElementPropertiessearchFilter = null, Expression<Func<string>> jABGetUIAElementPropertiessortByColumn = null, Expression<Func<bool>> jABGetUIAElementPropertiesmatchIndexAscending = null, Expression<Func<int>> jABGetUIAElementPropertiesmaxStringLength = null)
        {
            var __workflow_jABGetUIAElementPropertiesparentWindowHandle = WorkflowExpression.Compile(jABGetUIAElementPropertiesparentWindowHandle, nameof(jABGetUIAElementPropertiesparentWindowHandle), required: true);
            var __workflow_jABGetUIAElementPropertiesworkflow = WorkflowExpression.Compile(jABGetUIAElementPropertiesworkflow, nameof(jABGetUIAElementPropertiesworkflow), required: true);
            var __workflow_jABGetUIAElementPropertiessearchElementName = WorkflowExpression.Compile(jABGetUIAElementPropertiessearchElementName, nameof(jABGetUIAElementPropertiessearchElementName), required: false);
            var __workflow_jABGetUIAElementPropertiessearchElementClassName = WorkflowExpression.Compile(jABGetUIAElementPropertiessearchElementClassName, nameof(jABGetUIAElementPropertiessearchElementClassName), required: false);
            var __workflow_jABGetUIAElementPropertiessearchElementAutomationId = WorkflowExpression.Compile(jABGetUIAElementPropertiessearchElementAutomationId, nameof(jABGetUIAElementPropertiessearchElementAutomationId), required: false);
            var __workflow_jABGetUIAElementPropertiessearchLocalizedControlType = WorkflowExpression.Compile(jABGetUIAElementPropertiessearchLocalizedControlType, nameof(jABGetUIAElementPropertiessearchLocalizedControlType), required: false);
            var __workflow_jABGetUIAElementPropertiessearchSubTree = WorkflowExpression.Compile(jABGetUIAElementPropertiessearchSubTree, nameof(jABGetUIAElementPropertiessearchSubTree), required: false);
            var __workflow_jABGetUIAElementPropertiesmatchIndex = WorkflowExpression.Compile(jABGetUIAElementPropertiesmatchIndex, nameof(jABGetUIAElementPropertiesmatchIndex), required: false);
            var __workflow_jABGetUIAElementPropertiessearchFilter = WorkflowExpression.Compile(jABGetUIAElementPropertiessearchFilter, nameof(jABGetUIAElementPropertiessearchFilter), required: false);
            var __workflow_jABGetUIAElementPropertiessortByColumn = WorkflowExpression.Compile(jABGetUIAElementPropertiessortByColumn, nameof(jABGetUIAElementPropertiessortByColumn), required: false);
            var __workflow_jABGetUIAElementPropertiesmatchIndexAscending = WorkflowExpression.Compile(jABGetUIAElementPropertiesmatchIndexAscending, nameof(jABGetUIAElementPropertiesmatchIndexAscending), required: false);
            var __workflow_jABGetUIAElementPropertiesmaxStringLength = WorkflowExpression.Compile(jABGetUIAElementPropertiesmaxStringLength, nameof(jABGetUIAElementPropertiesmaxStringLength), required: false);
            return new DeferredBodyAction<JABGetUIAElementPropertiesResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetUIAElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetUIAElementProperties = new JObject();
                var jABGetUIAElementPropertiespropCount = 0;
                jABGetUIAElementPropertiespropCount++;
                jABGetUIAElementProperties["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_jABGetUIAElementPropertiesparentWindowHandle);
                if (__workflow_jABGetUIAElementPropertiessearchElementName != null)
                {
                    jABGetUIAElementProperties["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_jABGetUIAElementPropertiessearchElementName);
                    jABGetUIAElementPropertiespropCount++;
                }

                if (__workflow_jABGetUIAElementPropertiessearchElementClassName != null)
                {
                    jABGetUIAElementProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_jABGetUIAElementPropertiessearchElementClassName);
                    jABGetUIAElementPropertiespropCount++;
                }

                if (__workflow_jABGetUIAElementPropertiessearchElementAutomationId != null)
                {
                    jABGetUIAElementProperties["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_jABGetUIAElementPropertiessearchElementAutomationId);
                    jABGetUIAElementPropertiespropCount++;
                }

                if (__workflow_jABGetUIAElementPropertiessearchLocalizedControlType != null)
                {
                    jABGetUIAElementProperties["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_jABGetUIAElementPropertiessearchLocalizedControlType);
                    jABGetUIAElementPropertiespropCount++;
                }

                if (__workflow_jABGetUIAElementPropertiessearchSubTree != null)
                {
                    if (__workflow_jABGetUIAElementPropertiessearchSubTree != null)
                    {
                        jABGetUIAElementProperties["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABGetUIAElementPropertiessearchSubTree);
                        jABGetUIAElementPropertiespropCount++;
                    }

                    jABGetUIAElementPropertiespropCount++;
                }
                else
                {
                    jABGetUIAElementProperties["SearchSubTree"] = true;
                    jABGetUIAElementPropertiespropCount++;
                }

                if (__workflow_jABGetUIAElementPropertiesmatchIndex != null)
                {
                    if (__workflow_jABGetUIAElementPropertiesmatchIndex != null)
                    {
                        jABGetUIAElementProperties["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABGetUIAElementPropertiesmatchIndex);
                        jABGetUIAElementPropertiespropCount++;
                    }

                    jABGetUIAElementPropertiespropCount++;
                }
                else
                {
                    jABGetUIAElementProperties["MatchIndex"] = 1;
                    jABGetUIAElementPropertiespropCount++;
                }

                if (__workflow_jABGetUIAElementPropertiessearchFilter != null)
                {
                    jABGetUIAElementProperties["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABGetUIAElementPropertiessearchFilter);
                    jABGetUIAElementPropertiespropCount++;
                }

                if (__workflow_jABGetUIAElementPropertiessortByColumn != null)
                {
                    jABGetUIAElementProperties["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABGetUIAElementPropertiessortByColumn);
                    jABGetUIAElementPropertiespropCount++;
                }

                if (__workflow_jABGetUIAElementPropertiesmatchIndexAscending != null)
                {
                    if (__workflow_jABGetUIAElementPropertiesmatchIndexAscending != null)
                    {
                        jABGetUIAElementProperties["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABGetUIAElementPropertiesmatchIndexAscending);
                        jABGetUIAElementPropertiespropCount++;
                    }

                    jABGetUIAElementPropertiespropCount++;
                }
                else
                {
                    jABGetUIAElementProperties["MatchIndexAscending"] = true;
                    jABGetUIAElementPropertiespropCount++;
                }

                if (__workflow_jABGetUIAElementPropertiesmaxStringLength != null)
                {
                    if (__workflow_jABGetUIAElementPropertiesmaxStringLength != null)
                    {
                        jABGetUIAElementProperties["MaxStringLength"] = ExpressionConverter.ConvertO(__workflow_jABGetUIAElementPropertiesmaxStringLength);
                        jABGetUIAElementPropertiespropCount++;
                    }

                    jABGetUIAElementPropertiespropCount++;
                }
                else
                {
                    jABGetUIAElementProperties["MaxStringLength"] = 0;
                    jABGetUIAElementPropertiespropCount++;
                }

                jABGetUIAElementPropertiespropCount++;
                jABGetUIAElementProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetUIAElementPropertiesworkflow);
                if (jABGetUIAElementPropertiespropCount > 0)
                {
                    callPayload.Body = jABGetUIAElementProperties;
                }

                return new ApiConnectionAction<JABGetUIAElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetJABElementPropertiesResponse> JABGetJABElementProperties(Expression<Func<int>> jABGetJABElementPropertiessearchParentElementJABHandle, Expression<Func<string>> jABGetJABElementPropertiesworkflow, Expression<Func<string>> jABGetJABElementPropertiessearchElementJABName = null, Expression<Func<string>> jABGetJABElementPropertiessearchElementJABDescription = null, Expression<Func<string>> jABGetJABElementPropertiessearchElementJABRole = null, Expression<Func<bool>> jABGetJABElementPropertiessearchSubTree = null, Expression<Func<int>> jABGetJABElementPropertiesmaxRelativeDepth = null, Expression<Func<int>> jABGetJABElementPropertiesmatchIndex = null, Expression<Func<string>> jABGetJABElementPropertiessearchFilter = null, Expression<Func<string>> jABGetJABElementPropertiessortByColumn = null, Expression<Func<bool>> jABGetJABElementPropertiesmatchIndexAscending = null, Expression<Func<bool>> jABGetJABElementPropertiescaseSensitiveSearch = null, Expression<Func<bool>> jABGetJABElementPropertiesonlySearchVisibleElements = null, Expression<Func<bool>> jABGetJABElementPropertiesonlySearchShowingElements = null, Expression<Func<string>> jABGetJABElementPropertieselementRolesNotToTraverse = null, Expression<Func<int>> jABGetJABElementPropertiesmaximumElementsToSearch = null, Expression<Func<int>> jABGetJABElementPropertiesmaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABGetJABElementPropertiesmaxStringLength = null)
        {
            var __workflow_jABGetJABElementPropertiessearchParentElementJABHandle = WorkflowExpression.Compile(jABGetJABElementPropertiessearchParentElementJABHandle, nameof(jABGetJABElementPropertiessearchParentElementJABHandle), required: true);
            var __workflow_jABGetJABElementPropertiesworkflow = WorkflowExpression.Compile(jABGetJABElementPropertiesworkflow, nameof(jABGetJABElementPropertiesworkflow), required: true);
            var __workflow_jABGetJABElementPropertiessearchElementJABName = WorkflowExpression.Compile(jABGetJABElementPropertiessearchElementJABName, nameof(jABGetJABElementPropertiessearchElementJABName), required: false);
            var __workflow_jABGetJABElementPropertiessearchElementJABDescription = WorkflowExpression.Compile(jABGetJABElementPropertiessearchElementJABDescription, nameof(jABGetJABElementPropertiessearchElementJABDescription), required: false);
            var __workflow_jABGetJABElementPropertiessearchElementJABRole = WorkflowExpression.Compile(jABGetJABElementPropertiessearchElementJABRole, nameof(jABGetJABElementPropertiessearchElementJABRole), required: false);
            var __workflow_jABGetJABElementPropertiessearchSubTree = WorkflowExpression.Compile(jABGetJABElementPropertiessearchSubTree, nameof(jABGetJABElementPropertiessearchSubTree), required: false);
            var __workflow_jABGetJABElementPropertiesmaxRelativeDepth = WorkflowExpression.Compile(jABGetJABElementPropertiesmaxRelativeDepth, nameof(jABGetJABElementPropertiesmaxRelativeDepth), required: false);
            var __workflow_jABGetJABElementPropertiesmatchIndex = WorkflowExpression.Compile(jABGetJABElementPropertiesmatchIndex, nameof(jABGetJABElementPropertiesmatchIndex), required: false);
            var __workflow_jABGetJABElementPropertiessearchFilter = WorkflowExpression.Compile(jABGetJABElementPropertiessearchFilter, nameof(jABGetJABElementPropertiessearchFilter), required: false);
            var __workflow_jABGetJABElementPropertiessortByColumn = WorkflowExpression.Compile(jABGetJABElementPropertiessortByColumn, nameof(jABGetJABElementPropertiessortByColumn), required: false);
            var __workflow_jABGetJABElementPropertiesmatchIndexAscending = WorkflowExpression.Compile(jABGetJABElementPropertiesmatchIndexAscending, nameof(jABGetJABElementPropertiesmatchIndexAscending), required: false);
            var __workflow_jABGetJABElementPropertiescaseSensitiveSearch = WorkflowExpression.Compile(jABGetJABElementPropertiescaseSensitiveSearch, nameof(jABGetJABElementPropertiescaseSensitiveSearch), required: false);
            var __workflow_jABGetJABElementPropertiesonlySearchVisibleElements = WorkflowExpression.Compile(jABGetJABElementPropertiesonlySearchVisibleElements, nameof(jABGetJABElementPropertiesonlySearchVisibleElements), required: false);
            var __workflow_jABGetJABElementPropertiesonlySearchShowingElements = WorkflowExpression.Compile(jABGetJABElementPropertiesonlySearchShowingElements, nameof(jABGetJABElementPropertiesonlySearchShowingElements), required: false);
            var __workflow_jABGetJABElementPropertieselementRolesNotToTraverse = WorkflowExpression.Compile(jABGetJABElementPropertieselementRolesNotToTraverse, nameof(jABGetJABElementPropertieselementRolesNotToTraverse), required: false);
            var __workflow_jABGetJABElementPropertiesmaximumElementsToSearch = WorkflowExpression.Compile(jABGetJABElementPropertiesmaximumElementsToSearch, nameof(jABGetJABElementPropertiesmaximumElementsToSearch), required: false);
            var __workflow_jABGetJABElementPropertiesmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABGetJABElementPropertiesmaximumChildElementsToSearchPerNode, nameof(jABGetJABElementPropertiesmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABGetJABElementPropertiesmaxStringLength = WorkflowExpression.Compile(jABGetJABElementPropertiesmaxStringLength, nameof(jABGetJABElementPropertiesmaxStringLength), required: false);
            return new DeferredBodyAction<JABGetJABElementPropertiesResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetJABElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetJABElementProperties = new JObject();
                var jABGetJABElementPropertiespropCount = 0;
                jABGetJABElementPropertiespropCount++;
                jABGetJABElementProperties["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGetJABElementPropertiessearchParentElementJABHandle);
                if (__workflow_jABGetJABElementPropertiessearchElementJABName != null)
                {
                    jABGetJABElementProperties["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABGetJABElementPropertiessearchElementJABName);
                    jABGetJABElementPropertiespropCount++;
                }

                if (__workflow_jABGetJABElementPropertiessearchElementJABDescription != null)
                {
                    jABGetJABElementProperties["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABGetJABElementPropertiessearchElementJABDescription);
                    jABGetJABElementPropertiespropCount++;
                }

                if (__workflow_jABGetJABElementPropertiessearchElementJABRole != null)
                {
                    jABGetJABElementProperties["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABGetJABElementPropertiessearchElementJABRole);
                    jABGetJABElementPropertiespropCount++;
                }

                if (__workflow_jABGetJABElementPropertiessearchSubTree != null)
                {
                    if (__workflow_jABGetJABElementPropertiessearchSubTree != null)
                    {
                        jABGetJABElementProperties["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABGetJABElementPropertiessearchSubTree);
                        jABGetJABElementPropertiespropCount++;
                    }

                    jABGetJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetJABElementProperties["SearchSubTree"] = true;
                    jABGetJABElementPropertiespropCount++;
                }

                if (__workflow_jABGetJABElementPropertiesmaxRelativeDepth != null)
                {
                    if (__workflow_jABGetJABElementPropertiesmaxRelativeDepth != null)
                    {
                        jABGetJABElementProperties["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABGetJABElementPropertiesmaxRelativeDepth);
                        jABGetJABElementPropertiespropCount++;
                    }

                    jABGetJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetJABElementProperties["MaxRelativeDepth"] = 0;
                    jABGetJABElementPropertiespropCount++;
                }

                if (__workflow_jABGetJABElementPropertiesmatchIndex != null)
                {
                    if (__workflow_jABGetJABElementPropertiesmatchIndex != null)
                    {
                        jABGetJABElementProperties["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABGetJABElementPropertiesmatchIndex);
                        jABGetJABElementPropertiespropCount++;
                    }

                    jABGetJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetJABElementProperties["MatchIndex"] = 1;
                    jABGetJABElementPropertiespropCount++;
                }

                if (__workflow_jABGetJABElementPropertiessearchFilter != null)
                {
                    jABGetJABElementProperties["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABGetJABElementPropertiessearchFilter);
                    jABGetJABElementPropertiespropCount++;
                }

                if (__workflow_jABGetJABElementPropertiessortByColumn != null)
                {
                    jABGetJABElementProperties["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABGetJABElementPropertiessortByColumn);
                    jABGetJABElementPropertiespropCount++;
                }

                if (__workflow_jABGetJABElementPropertiesmatchIndexAscending != null)
                {
                    if (__workflow_jABGetJABElementPropertiesmatchIndexAscending != null)
                    {
                        jABGetJABElementProperties["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABGetJABElementPropertiesmatchIndexAscending);
                        jABGetJABElementPropertiespropCount++;
                    }

                    jABGetJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetJABElementProperties["MatchIndexAscending"] = true;
                    jABGetJABElementPropertiespropCount++;
                }

                if (__workflow_jABGetJABElementPropertiescaseSensitiveSearch != null)
                {
                    if (__workflow_jABGetJABElementPropertiescaseSensitiveSearch != null)
                    {
                        jABGetJABElementProperties["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetJABElementPropertiescaseSensitiveSearch);
                        jABGetJABElementPropertiespropCount++;
                    }

                    jABGetJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetJABElementProperties["CaseSensitiveSearch"] = false;
                    jABGetJABElementPropertiespropCount++;
                }

                if (__workflow_jABGetJABElementPropertiesonlySearchVisibleElements != null)
                {
                    if (__workflow_jABGetJABElementPropertiesonlySearchVisibleElements != null)
                    {
                        jABGetJABElementProperties["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABGetJABElementPropertiesonlySearchVisibleElements);
                        jABGetJABElementPropertiespropCount++;
                    }

                    jABGetJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetJABElementProperties["OnlySearchVisibleElements"] = true;
                    jABGetJABElementPropertiespropCount++;
                }

                if (__workflow_jABGetJABElementPropertiesonlySearchShowingElements != null)
                {
                    if (__workflow_jABGetJABElementPropertiesonlySearchShowingElements != null)
                    {
                        jABGetJABElementProperties["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABGetJABElementPropertiesonlySearchShowingElements);
                        jABGetJABElementPropertiespropCount++;
                    }

                    jABGetJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetJABElementProperties["OnlySearchShowingElements"] = true;
                    jABGetJABElementPropertiespropCount++;
                }

                if (__workflow_jABGetJABElementPropertieselementRolesNotToTraverse != null)
                {
                    jABGetJABElementProperties["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABGetJABElementPropertieselementRolesNotToTraverse);
                    jABGetJABElementPropertiespropCount++;
                }

                if (__workflow_jABGetJABElementPropertiesmaximumElementsToSearch != null)
                {
                    if (__workflow_jABGetJABElementPropertiesmaximumElementsToSearch != null)
                    {
                        jABGetJABElementProperties["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetJABElementPropertiesmaximumElementsToSearch);
                        jABGetJABElementPropertiespropCount++;
                    }

                    jABGetJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetJABElementProperties["MaximumElementsToSearch"] = 2000;
                    jABGetJABElementPropertiespropCount++;
                }

                if (__workflow_jABGetJABElementPropertiesmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABGetJABElementPropertiesmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetJABElementProperties["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABGetJABElementPropertiesmaximumChildElementsToSearchPerNode);
                        jABGetJABElementPropertiespropCount++;
                    }

                    jABGetJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetJABElementProperties["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGetJABElementPropertiespropCount++;
                }

                if (__workflow_jABGetJABElementPropertiesmaxStringLength != null)
                {
                    if (__workflow_jABGetJABElementPropertiesmaxStringLength != null)
                    {
                        jABGetJABElementProperties["MaxStringLength"] = ExpressionConverter.ConvertO(__workflow_jABGetJABElementPropertiesmaxStringLength);
                        jABGetJABElementPropertiespropCount++;
                    }

                    jABGetJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetJABElementProperties["MaxStringLength"] = 0;
                    jABGetJABElementPropertiespropCount++;
                }

                jABGetJABElementPropertiespropCount++;
                jABGetJABElementProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetJABElementPropertiesworkflow);
                if (jABGetJABElementPropertiespropCount > 0)
                {
                    callPayload.Body = jABGetJABElementProperties;
                }

                return new ApiConnectionAction<JABGetJABElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABDrawRectangleAroundJABElement(Expression<Func<int>> jABDrawRectangleAroundJABElementsearchParentElementJABHandle, Expression<Func<string>> jABDrawRectangleAroundJABElementworkflow, Expression<Func<string>> jABDrawRectangleAroundJABElementsearchElementJABName = null, Expression<Func<string>> jABDrawRectangleAroundJABElementsearchElementJABDescription = null, Expression<Func<string>> jABDrawRectangleAroundJABElementsearchElementJABRole = null, Expression<Func<bool>> jABDrawRectangleAroundJABElementsearchSubTree = null, Expression<Func<int>> jABDrawRectangleAroundJABElementmaxRelativeDepth = null, Expression<Func<int>> jABDrawRectangleAroundJABElementmatchIndex = null, Expression<Func<string>> jABDrawRectangleAroundJABElementsearchFilter = null, Expression<Func<string>> jABDrawRectangleAroundJABElementsortByColumn = null, Expression<Func<bool>> jABDrawRectangleAroundJABElementmatchIndexAscending = null, Expression<Func<bool>> jABDrawRectangleAroundJABElementcaseSensitiveSearch = null, Expression<Func<bool>> jABDrawRectangleAroundJABElementonlySearchVisibleElements = null, Expression<Func<bool>> jABDrawRectangleAroundJABElementonlySearchShowingElements = null, Expression<Func<string>> jABDrawRectangleAroundJABElementelementRolesNotToTraverse = null, Expression<Func<int>> jABDrawRectangleAroundJABElementmaximumElementsToSearch = null, Expression<Func<int>> jABDrawRectangleAroundJABElementmaximumChildElementsToSearchPerNode = null, Expression<Func<string>> jABDrawRectangleAroundJABElementpenColour = null, Expression<Func<int>> jABDrawRectangleAroundJABElementpenThicknessPixels = null)
        {
            var __workflow_jABDrawRectangleAroundJABElementsearchParentElementJABHandle = WorkflowExpression.Compile(jABDrawRectangleAroundJABElementsearchParentElementJABHandle, nameof(jABDrawRectangleAroundJABElementsearchParentElementJABHandle), required: true);
            var __workflow_jABDrawRectangleAroundJABElementworkflow = WorkflowExpression.Compile(jABDrawRectangleAroundJABElementworkflow, nameof(jABDrawRectangleAroundJABElementworkflow), required: true);
            var __workflow_jABDrawRectangleAroundJABElementsearchElementJABName = WorkflowExpression.Compile(jABDrawRectangleAroundJABElementsearchElementJABName, nameof(jABDrawRectangleAroundJABElementsearchElementJABName), required: false);
            var __workflow_jABDrawRectangleAroundJABElementsearchElementJABDescription = WorkflowExpression.Compile(jABDrawRectangleAroundJABElementsearchElementJABDescription, nameof(jABDrawRectangleAroundJABElementsearchElementJABDescription), required: false);
            var __workflow_jABDrawRectangleAroundJABElementsearchElementJABRole = WorkflowExpression.Compile(jABDrawRectangleAroundJABElementsearchElementJABRole, nameof(jABDrawRectangleAroundJABElementsearchElementJABRole), required: false);
            var __workflow_jABDrawRectangleAroundJABElementsearchSubTree = WorkflowExpression.Compile(jABDrawRectangleAroundJABElementsearchSubTree, nameof(jABDrawRectangleAroundJABElementsearchSubTree), required: false);
            var __workflow_jABDrawRectangleAroundJABElementmaxRelativeDepth = WorkflowExpression.Compile(jABDrawRectangleAroundJABElementmaxRelativeDepth, nameof(jABDrawRectangleAroundJABElementmaxRelativeDepth), required: false);
            var __workflow_jABDrawRectangleAroundJABElementmatchIndex = WorkflowExpression.Compile(jABDrawRectangleAroundJABElementmatchIndex, nameof(jABDrawRectangleAroundJABElementmatchIndex), required: false);
            var __workflow_jABDrawRectangleAroundJABElementsearchFilter = WorkflowExpression.Compile(jABDrawRectangleAroundJABElementsearchFilter, nameof(jABDrawRectangleAroundJABElementsearchFilter), required: false);
            var __workflow_jABDrawRectangleAroundJABElementsortByColumn = WorkflowExpression.Compile(jABDrawRectangleAroundJABElementsortByColumn, nameof(jABDrawRectangleAroundJABElementsortByColumn), required: false);
            var __workflow_jABDrawRectangleAroundJABElementmatchIndexAscending = WorkflowExpression.Compile(jABDrawRectangleAroundJABElementmatchIndexAscending, nameof(jABDrawRectangleAroundJABElementmatchIndexAscending), required: false);
            var __workflow_jABDrawRectangleAroundJABElementcaseSensitiveSearch = WorkflowExpression.Compile(jABDrawRectangleAroundJABElementcaseSensitiveSearch, nameof(jABDrawRectangleAroundJABElementcaseSensitiveSearch), required: false);
            var __workflow_jABDrawRectangleAroundJABElementonlySearchVisibleElements = WorkflowExpression.Compile(jABDrawRectangleAroundJABElementonlySearchVisibleElements, nameof(jABDrawRectangleAroundJABElementonlySearchVisibleElements), required: false);
            var __workflow_jABDrawRectangleAroundJABElementonlySearchShowingElements = WorkflowExpression.Compile(jABDrawRectangleAroundJABElementonlySearchShowingElements, nameof(jABDrawRectangleAroundJABElementonlySearchShowingElements), required: false);
            var __workflow_jABDrawRectangleAroundJABElementelementRolesNotToTraverse = WorkflowExpression.Compile(jABDrawRectangleAroundJABElementelementRolesNotToTraverse, nameof(jABDrawRectangleAroundJABElementelementRolesNotToTraverse), required: false);
            var __workflow_jABDrawRectangleAroundJABElementmaximumElementsToSearch = WorkflowExpression.Compile(jABDrawRectangleAroundJABElementmaximumElementsToSearch, nameof(jABDrawRectangleAroundJABElementmaximumElementsToSearch), required: false);
            var __workflow_jABDrawRectangleAroundJABElementmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABDrawRectangleAroundJABElementmaximumChildElementsToSearchPerNode, nameof(jABDrawRectangleAroundJABElementmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABDrawRectangleAroundJABElementpenColour = WorkflowExpression.Compile(jABDrawRectangleAroundJABElementpenColour, nameof(jABDrawRectangleAroundJABElementpenColour), required: false);
            var __workflow_jABDrawRectangleAroundJABElementpenThicknessPixels = WorkflowExpression.Compile(jABDrawRectangleAroundJABElementpenThicknessPixels, nameof(jABDrawRectangleAroundJABElementpenThicknessPixels), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABDrawRectangleAroundJABElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABDrawRectangleAroundJABElement = new JObject();
                var jABDrawRectangleAroundJABElementpropCount = 0;
                jABDrawRectangleAroundJABElementpropCount++;
                jABDrawRectangleAroundJABElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABDrawRectangleAroundJABElementsearchParentElementJABHandle);
                if (__workflow_jABDrawRectangleAroundJABElementsearchElementJABName != null)
                {
                    jABDrawRectangleAroundJABElement["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABDrawRectangleAroundJABElementsearchElementJABName);
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (__workflow_jABDrawRectangleAroundJABElementsearchElementJABDescription != null)
                {
                    jABDrawRectangleAroundJABElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABDrawRectangleAroundJABElementsearchElementJABDescription);
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (__workflow_jABDrawRectangleAroundJABElementsearchElementJABRole != null)
                {
                    jABDrawRectangleAroundJABElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABDrawRectangleAroundJABElementsearchElementJABRole);
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (__workflow_jABDrawRectangleAroundJABElementsearchSubTree != null)
                {
                    if (__workflow_jABDrawRectangleAroundJABElementsearchSubTree != null)
                    {
                        jABDrawRectangleAroundJABElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABDrawRectangleAroundJABElementsearchSubTree);
                        jABDrawRectangleAroundJABElementpropCount++;
                    }

                    jABDrawRectangleAroundJABElementpropCount++;
                }
                else
                {
                    jABDrawRectangleAroundJABElement["SearchSubTree"] = true;
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (__workflow_jABDrawRectangleAroundJABElementmaxRelativeDepth != null)
                {
                    if (__workflow_jABDrawRectangleAroundJABElementmaxRelativeDepth != null)
                    {
                        jABDrawRectangleAroundJABElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABDrawRectangleAroundJABElementmaxRelativeDepth);
                        jABDrawRectangleAroundJABElementpropCount++;
                    }

                    jABDrawRectangleAroundJABElementpropCount++;
                }
                else
                {
                    jABDrawRectangleAroundJABElement["MaxRelativeDepth"] = 0;
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (__workflow_jABDrawRectangleAroundJABElementmatchIndex != null)
                {
                    if (__workflow_jABDrawRectangleAroundJABElementmatchIndex != null)
                    {
                        jABDrawRectangleAroundJABElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABDrawRectangleAroundJABElementmatchIndex);
                        jABDrawRectangleAroundJABElementpropCount++;
                    }

                    jABDrawRectangleAroundJABElementpropCount++;
                }
                else
                {
                    jABDrawRectangleAroundJABElement["MatchIndex"] = 1;
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (__workflow_jABDrawRectangleAroundJABElementsearchFilter != null)
                {
                    jABDrawRectangleAroundJABElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABDrawRectangleAroundJABElementsearchFilter);
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (__workflow_jABDrawRectangleAroundJABElementsortByColumn != null)
                {
                    jABDrawRectangleAroundJABElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABDrawRectangleAroundJABElementsortByColumn);
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (__workflow_jABDrawRectangleAroundJABElementmatchIndexAscending != null)
                {
                    if (__workflow_jABDrawRectangleAroundJABElementmatchIndexAscending != null)
                    {
                        jABDrawRectangleAroundJABElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABDrawRectangleAroundJABElementmatchIndexAscending);
                        jABDrawRectangleAroundJABElementpropCount++;
                    }

                    jABDrawRectangleAroundJABElementpropCount++;
                }
                else
                {
                    jABDrawRectangleAroundJABElement["MatchIndexAscending"] = true;
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (__workflow_jABDrawRectangleAroundJABElementcaseSensitiveSearch != null)
                {
                    if (__workflow_jABDrawRectangleAroundJABElementcaseSensitiveSearch != null)
                    {
                        jABDrawRectangleAroundJABElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABDrawRectangleAroundJABElementcaseSensitiveSearch);
                        jABDrawRectangleAroundJABElementpropCount++;
                    }

                    jABDrawRectangleAroundJABElementpropCount++;
                }
                else
                {
                    jABDrawRectangleAroundJABElement["CaseSensitiveSearch"] = false;
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (__workflow_jABDrawRectangleAroundJABElementonlySearchVisibleElements != null)
                {
                    if (__workflow_jABDrawRectangleAroundJABElementonlySearchVisibleElements != null)
                    {
                        jABDrawRectangleAroundJABElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABDrawRectangleAroundJABElementonlySearchVisibleElements);
                        jABDrawRectangleAroundJABElementpropCount++;
                    }

                    jABDrawRectangleAroundJABElementpropCount++;
                }
                else
                {
                    jABDrawRectangleAroundJABElement["OnlySearchVisibleElements"] = true;
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (__workflow_jABDrawRectangleAroundJABElementonlySearchShowingElements != null)
                {
                    if (__workflow_jABDrawRectangleAroundJABElementonlySearchShowingElements != null)
                    {
                        jABDrawRectangleAroundJABElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABDrawRectangleAroundJABElementonlySearchShowingElements);
                        jABDrawRectangleAroundJABElementpropCount++;
                    }

                    jABDrawRectangleAroundJABElementpropCount++;
                }
                else
                {
                    jABDrawRectangleAroundJABElement["OnlySearchShowingElements"] = true;
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (__workflow_jABDrawRectangleAroundJABElementelementRolesNotToTraverse != null)
                {
                    jABDrawRectangleAroundJABElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABDrawRectangleAroundJABElementelementRolesNotToTraverse);
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (__workflow_jABDrawRectangleAroundJABElementmaximumElementsToSearch != null)
                {
                    if (__workflow_jABDrawRectangleAroundJABElementmaximumElementsToSearch != null)
                    {
                        jABDrawRectangleAroundJABElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABDrawRectangleAroundJABElementmaximumElementsToSearch);
                        jABDrawRectangleAroundJABElementpropCount++;
                    }

                    jABDrawRectangleAroundJABElementpropCount++;
                }
                else
                {
                    jABDrawRectangleAroundJABElement["MaximumElementsToSearch"] = 2000;
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (__workflow_jABDrawRectangleAroundJABElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABDrawRectangleAroundJABElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABDrawRectangleAroundJABElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABDrawRectangleAroundJABElementmaximumChildElementsToSearchPerNode);
                        jABDrawRectangleAroundJABElementpropCount++;
                    }

                    jABDrawRectangleAroundJABElementpropCount++;
                }
                else
                {
                    jABDrawRectangleAroundJABElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (__workflow_jABDrawRectangleAroundJABElementpenColour != null)
                {
                    if (__workflow_jABDrawRectangleAroundJABElementpenColour != null)
                    {
                        jABDrawRectangleAroundJABElement["PenColour"] = ExpressionConverter.ConvertO(__workflow_jABDrawRectangleAroundJABElementpenColour);
                        jABDrawRectangleAroundJABElementpropCount++;
                    }

                    jABDrawRectangleAroundJABElementpropCount++;
                }
                else
                {
                    jABDrawRectangleAroundJABElement["PenColour"] = "Orange";
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (__workflow_jABDrawRectangleAroundJABElementpenThicknessPixels != null)
                {
                    if (__workflow_jABDrawRectangleAroundJABElementpenThicknessPixels != null)
                    {
                        jABDrawRectangleAroundJABElement["PenThicknessPixels"] = ExpressionConverter.ConvertO(__workflow_jABDrawRectangleAroundJABElementpenThicknessPixels);
                        jABDrawRectangleAroundJABElementpropCount++;
                    }

                    jABDrawRectangleAroundJABElementpropCount++;
                }
                else
                {
                    jABDrawRectangleAroundJABElement["PenThicknessPixels"] = 4;
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                jABDrawRectangleAroundJABElementpropCount++;
                jABDrawRectangleAroundJABElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABDrawRectangleAroundJABElementworkflow);
                if (jABDrawRectangleAroundJABElementpropCount > 0)
                {
                    callPayload.Body = jABDrawRectangleAroundJABElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABDoesElementExistResponse> JABDoesElementExist(Expression<Func<int>> jABDoesElementExistsearchParentElementJABHandle, Expression<Func<string>> jABDoesElementExistworkflow, Expression<Func<string>> jABDoesElementExistsearchElementJABName = null, Expression<Func<string>> jABDoesElementExistsearchElementJABDescription = null, Expression<Func<string>> jABDoesElementExistsearchElementJABRole = null, Expression<Func<bool>> jABDoesElementExistsearchSubTree = null, Expression<Func<int>> jABDoesElementExistmaxRelativeDepth = null, Expression<Func<int>> jABDoesElementExistmatchIndex = null, Expression<Func<string>> jABDoesElementExistsearchFilter = null, Expression<Func<string>> jABDoesElementExistsortByColumn = null, Expression<Func<bool>> jABDoesElementExistmatchIndexAscending = null, Expression<Func<bool>> jABDoesElementExistcaseSensitiveSearch = null, Expression<Func<bool>> jABDoesElementExistonlySearchVisibleElements = null, Expression<Func<bool>> jABDoesElementExistonlySearchShowingElements = null, Expression<Func<string>> jABDoesElementExistelementRolesNotToTraverse = null, Expression<Func<int>> jABDoesElementExistmaximumElementsToSearch = null, Expression<Func<int>> jABDoesElementExistmaximumChildElementsToSearchPerNode = null)
        {
            var __workflow_jABDoesElementExistsearchParentElementJABHandle = WorkflowExpression.Compile(jABDoesElementExistsearchParentElementJABHandle, nameof(jABDoesElementExistsearchParentElementJABHandle), required: true);
            var __workflow_jABDoesElementExistworkflow = WorkflowExpression.Compile(jABDoesElementExistworkflow, nameof(jABDoesElementExistworkflow), required: true);
            var __workflow_jABDoesElementExistsearchElementJABName = WorkflowExpression.Compile(jABDoesElementExistsearchElementJABName, nameof(jABDoesElementExistsearchElementJABName), required: false);
            var __workflow_jABDoesElementExistsearchElementJABDescription = WorkflowExpression.Compile(jABDoesElementExistsearchElementJABDescription, nameof(jABDoesElementExistsearchElementJABDescription), required: false);
            var __workflow_jABDoesElementExistsearchElementJABRole = WorkflowExpression.Compile(jABDoesElementExistsearchElementJABRole, nameof(jABDoesElementExistsearchElementJABRole), required: false);
            var __workflow_jABDoesElementExistsearchSubTree = WorkflowExpression.Compile(jABDoesElementExistsearchSubTree, nameof(jABDoesElementExistsearchSubTree), required: false);
            var __workflow_jABDoesElementExistmaxRelativeDepth = WorkflowExpression.Compile(jABDoesElementExistmaxRelativeDepth, nameof(jABDoesElementExistmaxRelativeDepth), required: false);
            var __workflow_jABDoesElementExistmatchIndex = WorkflowExpression.Compile(jABDoesElementExistmatchIndex, nameof(jABDoesElementExistmatchIndex), required: false);
            var __workflow_jABDoesElementExistsearchFilter = WorkflowExpression.Compile(jABDoesElementExistsearchFilter, nameof(jABDoesElementExistsearchFilter), required: false);
            var __workflow_jABDoesElementExistsortByColumn = WorkflowExpression.Compile(jABDoesElementExistsortByColumn, nameof(jABDoesElementExistsortByColumn), required: false);
            var __workflow_jABDoesElementExistmatchIndexAscending = WorkflowExpression.Compile(jABDoesElementExistmatchIndexAscending, nameof(jABDoesElementExistmatchIndexAscending), required: false);
            var __workflow_jABDoesElementExistcaseSensitiveSearch = WorkflowExpression.Compile(jABDoesElementExistcaseSensitiveSearch, nameof(jABDoesElementExistcaseSensitiveSearch), required: false);
            var __workflow_jABDoesElementExistonlySearchVisibleElements = WorkflowExpression.Compile(jABDoesElementExistonlySearchVisibleElements, nameof(jABDoesElementExistonlySearchVisibleElements), required: false);
            var __workflow_jABDoesElementExistonlySearchShowingElements = WorkflowExpression.Compile(jABDoesElementExistonlySearchShowingElements, nameof(jABDoesElementExistonlySearchShowingElements), required: false);
            var __workflow_jABDoesElementExistelementRolesNotToTraverse = WorkflowExpression.Compile(jABDoesElementExistelementRolesNotToTraverse, nameof(jABDoesElementExistelementRolesNotToTraverse), required: false);
            var __workflow_jABDoesElementExistmaximumElementsToSearch = WorkflowExpression.Compile(jABDoesElementExistmaximumElementsToSearch, nameof(jABDoesElementExistmaximumElementsToSearch), required: false);
            var __workflow_jABDoesElementExistmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABDoesElementExistmaximumChildElementsToSearchPerNode, nameof(jABDoesElementExistmaximumChildElementsToSearchPerNode), required: false);
            return new DeferredBodyAction<JABDoesElementExistResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABDoesElementExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABDoesElementExist = new JObject();
                var jABDoesElementExistpropCount = 0;
                jABDoesElementExistpropCount++;
                jABDoesElementExist["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABDoesElementExistsearchParentElementJABHandle);
                if (__workflow_jABDoesElementExistsearchElementJABName != null)
                {
                    jABDoesElementExist["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABDoesElementExistsearchElementJABName);
                    jABDoesElementExistpropCount++;
                }

                if (__workflow_jABDoesElementExistsearchElementJABDescription != null)
                {
                    jABDoesElementExist["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABDoesElementExistsearchElementJABDescription);
                    jABDoesElementExistpropCount++;
                }

                if (__workflow_jABDoesElementExistsearchElementJABRole != null)
                {
                    jABDoesElementExist["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABDoesElementExistsearchElementJABRole);
                    jABDoesElementExistpropCount++;
                }

                if (__workflow_jABDoesElementExistsearchSubTree != null)
                {
                    if (__workflow_jABDoesElementExistsearchSubTree != null)
                    {
                        jABDoesElementExist["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABDoesElementExistsearchSubTree);
                        jABDoesElementExistpropCount++;
                    }

                    jABDoesElementExistpropCount++;
                }
                else
                {
                    jABDoesElementExist["SearchSubTree"] = true;
                    jABDoesElementExistpropCount++;
                }

                if (__workflow_jABDoesElementExistmaxRelativeDepth != null)
                {
                    if (__workflow_jABDoesElementExistmaxRelativeDepth != null)
                    {
                        jABDoesElementExist["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABDoesElementExistmaxRelativeDepth);
                        jABDoesElementExistpropCount++;
                    }

                    jABDoesElementExistpropCount++;
                }
                else
                {
                    jABDoesElementExist["MaxRelativeDepth"] = 0;
                    jABDoesElementExistpropCount++;
                }

                if (__workflow_jABDoesElementExistmatchIndex != null)
                {
                    if (__workflow_jABDoesElementExistmatchIndex != null)
                    {
                        jABDoesElementExist["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABDoesElementExistmatchIndex);
                        jABDoesElementExistpropCount++;
                    }

                    jABDoesElementExistpropCount++;
                }
                else
                {
                    jABDoesElementExist["MatchIndex"] = 1;
                    jABDoesElementExistpropCount++;
                }

                if (__workflow_jABDoesElementExistsearchFilter != null)
                {
                    jABDoesElementExist["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABDoesElementExistsearchFilter);
                    jABDoesElementExistpropCount++;
                }

                if (__workflow_jABDoesElementExistsortByColumn != null)
                {
                    jABDoesElementExist["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABDoesElementExistsortByColumn);
                    jABDoesElementExistpropCount++;
                }

                if (__workflow_jABDoesElementExistmatchIndexAscending != null)
                {
                    if (__workflow_jABDoesElementExistmatchIndexAscending != null)
                    {
                        jABDoesElementExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABDoesElementExistmatchIndexAscending);
                        jABDoesElementExistpropCount++;
                    }

                    jABDoesElementExistpropCount++;
                }
                else
                {
                    jABDoesElementExist["MatchIndexAscending"] = true;
                    jABDoesElementExistpropCount++;
                }

                if (__workflow_jABDoesElementExistcaseSensitiveSearch != null)
                {
                    if (__workflow_jABDoesElementExistcaseSensitiveSearch != null)
                    {
                        jABDoesElementExist["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABDoesElementExistcaseSensitiveSearch);
                        jABDoesElementExistpropCount++;
                    }

                    jABDoesElementExistpropCount++;
                }
                else
                {
                    jABDoesElementExist["CaseSensitiveSearch"] = false;
                    jABDoesElementExistpropCount++;
                }

                if (__workflow_jABDoesElementExistonlySearchVisibleElements != null)
                {
                    if (__workflow_jABDoesElementExistonlySearchVisibleElements != null)
                    {
                        jABDoesElementExist["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABDoesElementExistonlySearchVisibleElements);
                        jABDoesElementExistpropCount++;
                    }

                    jABDoesElementExistpropCount++;
                }
                else
                {
                    jABDoesElementExist["OnlySearchVisibleElements"] = true;
                    jABDoesElementExistpropCount++;
                }

                if (__workflow_jABDoesElementExistonlySearchShowingElements != null)
                {
                    if (__workflow_jABDoesElementExistonlySearchShowingElements != null)
                    {
                        jABDoesElementExist["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABDoesElementExistonlySearchShowingElements);
                        jABDoesElementExistpropCount++;
                    }

                    jABDoesElementExistpropCount++;
                }
                else
                {
                    jABDoesElementExist["OnlySearchShowingElements"] = true;
                    jABDoesElementExistpropCount++;
                }

                if (__workflow_jABDoesElementExistelementRolesNotToTraverse != null)
                {
                    jABDoesElementExist["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABDoesElementExistelementRolesNotToTraverse);
                    jABDoesElementExistpropCount++;
                }

                if (__workflow_jABDoesElementExistmaximumElementsToSearch != null)
                {
                    if (__workflow_jABDoesElementExistmaximumElementsToSearch != null)
                    {
                        jABDoesElementExist["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABDoesElementExistmaximumElementsToSearch);
                        jABDoesElementExistpropCount++;
                    }

                    jABDoesElementExistpropCount++;
                }
                else
                {
                    jABDoesElementExist["MaximumElementsToSearch"] = 2000;
                    jABDoesElementExistpropCount++;
                }

                if (__workflow_jABDoesElementExistmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABDoesElementExistmaximumChildElementsToSearchPerNode != null)
                    {
                        jABDoesElementExist["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABDoesElementExistmaximumChildElementsToSearchPerNode);
                        jABDoesElementExistpropCount++;
                    }

                    jABDoesElementExistpropCount++;
                }
                else
                {
                    jABDoesElementExist["MaximumChildElementsToSearchPerNode"] = 200;
                    jABDoesElementExistpropCount++;
                }

                jABDoesElementExistpropCount++;
                jABDoesElementExist["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABDoesElementExistworkflow);
                if (jABDoesElementExistpropCount > 0)
                {
                    callPayload.Body = jABDoesElementExist;
                }

                return new ApiConnectionAction<JABDoesElementExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABWaitForElementResponse> JABWaitForElement(Expression<Func<int>> jABWaitForElementsearchParentElementJABHandle, Expression<Func<double>> jABWaitForElementsecondsToWait, Expression<Func<string>> jABWaitForElementworkflow, Expression<Func<string>> jABWaitForElementsearchElementJABName = null, Expression<Func<string>> jABWaitForElementsearchElementJABDescription = null, Expression<Func<string>> jABWaitForElementsearchElementJABRole = null, Expression<Func<bool>> jABWaitForElementsearchSubTree = null, Expression<Func<int>> jABWaitForElementmaxRelativeDepth = null, Expression<Func<int>> jABWaitForElementmatchIndex = null, Expression<Func<string>> jABWaitForElementsearchFilter = null, Expression<Func<string>> jABWaitForElementsortByColumn = null, Expression<Func<bool>> jABWaitForElementmatchIndexAscending = null, Expression<Func<bool>> jABWaitForElementcaseSensitiveSearch = null, Expression<Func<bool>> jABWaitForElementonlySearchVisibleElements = null, Expression<Func<bool>> jABWaitForElementonlySearchShowingElements = null, Expression<Func<string>> jABWaitForElementelementRolesNotToTraverse = null, Expression<Func<int>> jABWaitForElementmaximumElementsToSearch = null, Expression<Func<int>> jABWaitForElementmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABWaitForElementraiseExceptionIfElementNotFound = null)
        {
            var __workflow_jABWaitForElementsearchParentElementJABHandle = WorkflowExpression.Compile(jABWaitForElementsearchParentElementJABHandle, nameof(jABWaitForElementsearchParentElementJABHandle), required: true);
            var __workflow_jABWaitForElementsecondsToWait = WorkflowExpression.Compile(jABWaitForElementsecondsToWait, nameof(jABWaitForElementsecondsToWait), required: true);
            var __workflow_jABWaitForElementworkflow = WorkflowExpression.Compile(jABWaitForElementworkflow, nameof(jABWaitForElementworkflow), required: true);
            var __workflow_jABWaitForElementsearchElementJABName = WorkflowExpression.Compile(jABWaitForElementsearchElementJABName, nameof(jABWaitForElementsearchElementJABName), required: false);
            var __workflow_jABWaitForElementsearchElementJABDescription = WorkflowExpression.Compile(jABWaitForElementsearchElementJABDescription, nameof(jABWaitForElementsearchElementJABDescription), required: false);
            var __workflow_jABWaitForElementsearchElementJABRole = WorkflowExpression.Compile(jABWaitForElementsearchElementJABRole, nameof(jABWaitForElementsearchElementJABRole), required: false);
            var __workflow_jABWaitForElementsearchSubTree = WorkflowExpression.Compile(jABWaitForElementsearchSubTree, nameof(jABWaitForElementsearchSubTree), required: false);
            var __workflow_jABWaitForElementmaxRelativeDepth = WorkflowExpression.Compile(jABWaitForElementmaxRelativeDepth, nameof(jABWaitForElementmaxRelativeDepth), required: false);
            var __workflow_jABWaitForElementmatchIndex = WorkflowExpression.Compile(jABWaitForElementmatchIndex, nameof(jABWaitForElementmatchIndex), required: false);
            var __workflow_jABWaitForElementsearchFilter = WorkflowExpression.Compile(jABWaitForElementsearchFilter, nameof(jABWaitForElementsearchFilter), required: false);
            var __workflow_jABWaitForElementsortByColumn = WorkflowExpression.Compile(jABWaitForElementsortByColumn, nameof(jABWaitForElementsortByColumn), required: false);
            var __workflow_jABWaitForElementmatchIndexAscending = WorkflowExpression.Compile(jABWaitForElementmatchIndexAscending, nameof(jABWaitForElementmatchIndexAscending), required: false);
            var __workflow_jABWaitForElementcaseSensitiveSearch = WorkflowExpression.Compile(jABWaitForElementcaseSensitiveSearch, nameof(jABWaitForElementcaseSensitiveSearch), required: false);
            var __workflow_jABWaitForElementonlySearchVisibleElements = WorkflowExpression.Compile(jABWaitForElementonlySearchVisibleElements, nameof(jABWaitForElementonlySearchVisibleElements), required: false);
            var __workflow_jABWaitForElementonlySearchShowingElements = WorkflowExpression.Compile(jABWaitForElementonlySearchShowingElements, nameof(jABWaitForElementonlySearchShowingElements), required: false);
            var __workflow_jABWaitForElementelementRolesNotToTraverse = WorkflowExpression.Compile(jABWaitForElementelementRolesNotToTraverse, nameof(jABWaitForElementelementRolesNotToTraverse), required: false);
            var __workflow_jABWaitForElementmaximumElementsToSearch = WorkflowExpression.Compile(jABWaitForElementmaximumElementsToSearch, nameof(jABWaitForElementmaximumElementsToSearch), required: false);
            var __workflow_jABWaitForElementmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABWaitForElementmaximumChildElementsToSearchPerNode, nameof(jABWaitForElementmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABWaitForElementraiseExceptionIfElementNotFound = WorkflowExpression.Compile(jABWaitForElementraiseExceptionIfElementNotFound, nameof(jABWaitForElementraiseExceptionIfElementNotFound), required: false);
            return new DeferredBodyAction<JABWaitForElementResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABWaitForElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABWaitForElement = new JObject();
                var jABWaitForElementpropCount = 0;
                jABWaitForElementpropCount++;
                jABWaitForElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementsearchParentElementJABHandle);
                if (__workflow_jABWaitForElementsearchElementJABName != null)
                {
                    jABWaitForElement["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementsearchElementJABName);
                    jABWaitForElementpropCount++;
                }

                if (__workflow_jABWaitForElementsearchElementJABDescription != null)
                {
                    jABWaitForElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementsearchElementJABDescription);
                    jABWaitForElementpropCount++;
                }

                if (__workflow_jABWaitForElementsearchElementJABRole != null)
                {
                    jABWaitForElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementsearchElementJABRole);
                    jABWaitForElementpropCount++;
                }

                if (__workflow_jABWaitForElementsearchSubTree != null)
                {
                    if (__workflow_jABWaitForElementsearchSubTree != null)
                    {
                        jABWaitForElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementsearchSubTree);
                        jABWaitForElementpropCount++;
                    }

                    jABWaitForElementpropCount++;
                }
                else
                {
                    jABWaitForElement["SearchSubTree"] = true;
                    jABWaitForElementpropCount++;
                }

                if (__workflow_jABWaitForElementmaxRelativeDepth != null)
                {
                    if (__workflow_jABWaitForElementmaxRelativeDepth != null)
                    {
                        jABWaitForElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementmaxRelativeDepth);
                        jABWaitForElementpropCount++;
                    }

                    jABWaitForElementpropCount++;
                }
                else
                {
                    jABWaitForElement["MaxRelativeDepth"] = 0;
                    jABWaitForElementpropCount++;
                }

                if (__workflow_jABWaitForElementmatchIndex != null)
                {
                    if (__workflow_jABWaitForElementmatchIndex != null)
                    {
                        jABWaitForElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementmatchIndex);
                        jABWaitForElementpropCount++;
                    }

                    jABWaitForElementpropCount++;
                }
                else
                {
                    jABWaitForElement["MatchIndex"] = 1;
                    jABWaitForElementpropCount++;
                }

                if (__workflow_jABWaitForElementsearchFilter != null)
                {
                    jABWaitForElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementsearchFilter);
                    jABWaitForElementpropCount++;
                }

                if (__workflow_jABWaitForElementsortByColumn != null)
                {
                    jABWaitForElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementsortByColumn);
                    jABWaitForElementpropCount++;
                }

                if (__workflow_jABWaitForElementmatchIndexAscending != null)
                {
                    if (__workflow_jABWaitForElementmatchIndexAscending != null)
                    {
                        jABWaitForElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementmatchIndexAscending);
                        jABWaitForElementpropCount++;
                    }

                    jABWaitForElementpropCount++;
                }
                else
                {
                    jABWaitForElement["MatchIndexAscending"] = true;
                    jABWaitForElementpropCount++;
                }

                if (__workflow_jABWaitForElementcaseSensitiveSearch != null)
                {
                    if (__workflow_jABWaitForElementcaseSensitiveSearch != null)
                    {
                        jABWaitForElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementcaseSensitiveSearch);
                        jABWaitForElementpropCount++;
                    }

                    jABWaitForElementpropCount++;
                }
                else
                {
                    jABWaitForElement["CaseSensitiveSearch"] = false;
                    jABWaitForElementpropCount++;
                }

                if (__workflow_jABWaitForElementonlySearchVisibleElements != null)
                {
                    if (__workflow_jABWaitForElementonlySearchVisibleElements != null)
                    {
                        jABWaitForElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementonlySearchVisibleElements);
                        jABWaitForElementpropCount++;
                    }

                    jABWaitForElementpropCount++;
                }
                else
                {
                    jABWaitForElement["OnlySearchVisibleElements"] = true;
                    jABWaitForElementpropCount++;
                }

                if (__workflow_jABWaitForElementonlySearchShowingElements != null)
                {
                    if (__workflow_jABWaitForElementonlySearchShowingElements != null)
                    {
                        jABWaitForElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementonlySearchShowingElements);
                        jABWaitForElementpropCount++;
                    }

                    jABWaitForElementpropCount++;
                }
                else
                {
                    jABWaitForElement["OnlySearchShowingElements"] = true;
                    jABWaitForElementpropCount++;
                }

                if (__workflow_jABWaitForElementelementRolesNotToTraverse != null)
                {
                    jABWaitForElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementelementRolesNotToTraverse);
                    jABWaitForElementpropCount++;
                }

                if (__workflow_jABWaitForElementmaximumElementsToSearch != null)
                {
                    if (__workflow_jABWaitForElementmaximumElementsToSearch != null)
                    {
                        jABWaitForElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementmaximumElementsToSearch);
                        jABWaitForElementpropCount++;
                    }

                    jABWaitForElementpropCount++;
                }
                else
                {
                    jABWaitForElement["MaximumElementsToSearch"] = 2000;
                    jABWaitForElementpropCount++;
                }

                if (__workflow_jABWaitForElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABWaitForElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABWaitForElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementmaximumChildElementsToSearchPerNode);
                        jABWaitForElementpropCount++;
                    }

                    jABWaitForElementpropCount++;
                }
                else
                {
                    jABWaitForElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABWaitForElementpropCount++;
                }

                jABWaitForElementpropCount++;
                jABWaitForElement["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementsecondsToWait);
                if (__workflow_jABWaitForElementraiseExceptionIfElementNotFound != null)
                {
                    if (__workflow_jABWaitForElementraiseExceptionIfElementNotFound != null)
                    {
                        jABWaitForElement["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementraiseExceptionIfElementNotFound);
                        jABWaitForElementpropCount++;
                    }

                    jABWaitForElementpropCount++;
                }
                else
                {
                    jABWaitForElement["RaiseExceptionIfElementNotFound"] = false;
                    jABWaitForElementpropCount++;
                }

                jABWaitForElementpropCount++;
                jABWaitForElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementworkflow);
                if (jABWaitForElementpropCount > 0)
                {
                    callPayload.Body = jABWaitForElement;
                }

                return new ApiConnectionAction<JABWaitForElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABWaitForElementToNotExistResponse> JABWaitForElementToNotExist(Expression<Func<int>> jABWaitForElementToNotExistsearchParentElementJABHandle, Expression<Func<double>> jABWaitForElementToNotExistsecondsToWait, Expression<Func<string>> jABWaitForElementToNotExistworkflow, Expression<Func<string>> jABWaitForElementToNotExistsearchElementJABName = null, Expression<Func<string>> jABWaitForElementToNotExistsearchElementJABDescription = null, Expression<Func<string>> jABWaitForElementToNotExistsearchElementJABRole = null, Expression<Func<bool>> jABWaitForElementToNotExistsearchSubTree = null, Expression<Func<int>> jABWaitForElementToNotExistmaxRelativeDepth = null, Expression<Func<int>> jABWaitForElementToNotExistmatchIndex = null, Expression<Func<string>> jABWaitForElementToNotExistsearchFilter = null, Expression<Func<string>> jABWaitForElementToNotExistsortByColumn = null, Expression<Func<bool>> jABWaitForElementToNotExistmatchIndexAscending = null, Expression<Func<bool>> jABWaitForElementToNotExistcaseSensitiveSearch = null, Expression<Func<bool>> jABWaitForElementToNotExistonlySearchVisibleElements = null, Expression<Func<bool>> jABWaitForElementToNotExistonlySearchShowingElements = null, Expression<Func<string>> jABWaitForElementToNotExistelementRolesNotToTraverse = null, Expression<Func<int>> jABWaitForElementToNotExistmaximumElementsToSearch = null, Expression<Func<int>> jABWaitForElementToNotExistmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABWaitForElementToNotExistraiseExceptionIfElementStillExists = null)
        {
            var __workflow_jABWaitForElementToNotExistsearchParentElementJABHandle = WorkflowExpression.Compile(jABWaitForElementToNotExistsearchParentElementJABHandle, nameof(jABWaitForElementToNotExistsearchParentElementJABHandle), required: true);
            var __workflow_jABWaitForElementToNotExistsecondsToWait = WorkflowExpression.Compile(jABWaitForElementToNotExistsecondsToWait, nameof(jABWaitForElementToNotExistsecondsToWait), required: true);
            var __workflow_jABWaitForElementToNotExistworkflow = WorkflowExpression.Compile(jABWaitForElementToNotExistworkflow, nameof(jABWaitForElementToNotExistworkflow), required: true);
            var __workflow_jABWaitForElementToNotExistsearchElementJABName = WorkflowExpression.Compile(jABWaitForElementToNotExistsearchElementJABName, nameof(jABWaitForElementToNotExistsearchElementJABName), required: false);
            var __workflow_jABWaitForElementToNotExistsearchElementJABDescription = WorkflowExpression.Compile(jABWaitForElementToNotExistsearchElementJABDescription, nameof(jABWaitForElementToNotExistsearchElementJABDescription), required: false);
            var __workflow_jABWaitForElementToNotExistsearchElementJABRole = WorkflowExpression.Compile(jABWaitForElementToNotExistsearchElementJABRole, nameof(jABWaitForElementToNotExistsearchElementJABRole), required: false);
            var __workflow_jABWaitForElementToNotExistsearchSubTree = WorkflowExpression.Compile(jABWaitForElementToNotExistsearchSubTree, nameof(jABWaitForElementToNotExistsearchSubTree), required: false);
            var __workflow_jABWaitForElementToNotExistmaxRelativeDepth = WorkflowExpression.Compile(jABWaitForElementToNotExistmaxRelativeDepth, nameof(jABWaitForElementToNotExistmaxRelativeDepth), required: false);
            var __workflow_jABWaitForElementToNotExistmatchIndex = WorkflowExpression.Compile(jABWaitForElementToNotExistmatchIndex, nameof(jABWaitForElementToNotExistmatchIndex), required: false);
            var __workflow_jABWaitForElementToNotExistsearchFilter = WorkflowExpression.Compile(jABWaitForElementToNotExistsearchFilter, nameof(jABWaitForElementToNotExistsearchFilter), required: false);
            var __workflow_jABWaitForElementToNotExistsortByColumn = WorkflowExpression.Compile(jABWaitForElementToNotExistsortByColumn, nameof(jABWaitForElementToNotExistsortByColumn), required: false);
            var __workflow_jABWaitForElementToNotExistmatchIndexAscending = WorkflowExpression.Compile(jABWaitForElementToNotExistmatchIndexAscending, nameof(jABWaitForElementToNotExistmatchIndexAscending), required: false);
            var __workflow_jABWaitForElementToNotExistcaseSensitiveSearch = WorkflowExpression.Compile(jABWaitForElementToNotExistcaseSensitiveSearch, nameof(jABWaitForElementToNotExistcaseSensitiveSearch), required: false);
            var __workflow_jABWaitForElementToNotExistonlySearchVisibleElements = WorkflowExpression.Compile(jABWaitForElementToNotExistonlySearchVisibleElements, nameof(jABWaitForElementToNotExistonlySearchVisibleElements), required: false);
            var __workflow_jABWaitForElementToNotExistonlySearchShowingElements = WorkflowExpression.Compile(jABWaitForElementToNotExistonlySearchShowingElements, nameof(jABWaitForElementToNotExistonlySearchShowingElements), required: false);
            var __workflow_jABWaitForElementToNotExistelementRolesNotToTraverse = WorkflowExpression.Compile(jABWaitForElementToNotExistelementRolesNotToTraverse, nameof(jABWaitForElementToNotExistelementRolesNotToTraverse), required: false);
            var __workflow_jABWaitForElementToNotExistmaximumElementsToSearch = WorkflowExpression.Compile(jABWaitForElementToNotExistmaximumElementsToSearch, nameof(jABWaitForElementToNotExistmaximumElementsToSearch), required: false);
            var __workflow_jABWaitForElementToNotExistmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABWaitForElementToNotExistmaximumChildElementsToSearchPerNode, nameof(jABWaitForElementToNotExistmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABWaitForElementToNotExistraiseExceptionIfElementStillExists = WorkflowExpression.Compile(jABWaitForElementToNotExistraiseExceptionIfElementStillExists, nameof(jABWaitForElementToNotExistraiseExceptionIfElementStillExists), required: false);
            return new DeferredBodyAction<JABWaitForElementToNotExistResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABWaitForElementToNotExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABWaitForElementToNotExist = new JObject();
                var jABWaitForElementToNotExistpropCount = 0;
                jABWaitForElementToNotExistpropCount++;
                jABWaitForElementToNotExist["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementToNotExistsearchParentElementJABHandle);
                if (__workflow_jABWaitForElementToNotExistsearchElementJABName != null)
                {
                    jABWaitForElementToNotExist["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementToNotExistsearchElementJABName);
                    jABWaitForElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForElementToNotExistsearchElementJABDescription != null)
                {
                    jABWaitForElementToNotExist["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementToNotExistsearchElementJABDescription);
                    jABWaitForElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForElementToNotExistsearchElementJABRole != null)
                {
                    jABWaitForElementToNotExist["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementToNotExistsearchElementJABRole);
                    jABWaitForElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForElementToNotExistsearchSubTree != null)
                {
                    if (__workflow_jABWaitForElementToNotExistsearchSubTree != null)
                    {
                        jABWaitForElementToNotExist["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementToNotExistsearchSubTree);
                        jABWaitForElementToNotExistpropCount++;
                    }

                    jABWaitForElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForElementToNotExist["SearchSubTree"] = true;
                    jABWaitForElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForElementToNotExistmaxRelativeDepth != null)
                {
                    if (__workflow_jABWaitForElementToNotExistmaxRelativeDepth != null)
                    {
                        jABWaitForElementToNotExist["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementToNotExistmaxRelativeDepth);
                        jABWaitForElementToNotExistpropCount++;
                    }

                    jABWaitForElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForElementToNotExist["MaxRelativeDepth"] = 0;
                    jABWaitForElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForElementToNotExistmatchIndex != null)
                {
                    if (__workflow_jABWaitForElementToNotExistmatchIndex != null)
                    {
                        jABWaitForElementToNotExist["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementToNotExistmatchIndex);
                        jABWaitForElementToNotExistpropCount++;
                    }

                    jABWaitForElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForElementToNotExist["MatchIndex"] = 1;
                    jABWaitForElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForElementToNotExistsearchFilter != null)
                {
                    jABWaitForElementToNotExist["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementToNotExistsearchFilter);
                    jABWaitForElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForElementToNotExistsortByColumn != null)
                {
                    jABWaitForElementToNotExist["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementToNotExistsortByColumn);
                    jABWaitForElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForElementToNotExistmatchIndexAscending != null)
                {
                    if (__workflow_jABWaitForElementToNotExistmatchIndexAscending != null)
                    {
                        jABWaitForElementToNotExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementToNotExistmatchIndexAscending);
                        jABWaitForElementToNotExistpropCount++;
                    }

                    jABWaitForElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForElementToNotExist["MatchIndexAscending"] = true;
                    jABWaitForElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForElementToNotExistcaseSensitiveSearch != null)
                {
                    if (__workflow_jABWaitForElementToNotExistcaseSensitiveSearch != null)
                    {
                        jABWaitForElementToNotExist["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementToNotExistcaseSensitiveSearch);
                        jABWaitForElementToNotExistpropCount++;
                    }

                    jABWaitForElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForElementToNotExist["CaseSensitiveSearch"] = false;
                    jABWaitForElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForElementToNotExistonlySearchVisibleElements != null)
                {
                    if (__workflow_jABWaitForElementToNotExistonlySearchVisibleElements != null)
                    {
                        jABWaitForElementToNotExist["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementToNotExistonlySearchVisibleElements);
                        jABWaitForElementToNotExistpropCount++;
                    }

                    jABWaitForElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForElementToNotExist["OnlySearchVisibleElements"] = true;
                    jABWaitForElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForElementToNotExistonlySearchShowingElements != null)
                {
                    if (__workflow_jABWaitForElementToNotExistonlySearchShowingElements != null)
                    {
                        jABWaitForElementToNotExist["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementToNotExistonlySearchShowingElements);
                        jABWaitForElementToNotExistpropCount++;
                    }

                    jABWaitForElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForElementToNotExist["OnlySearchShowingElements"] = true;
                    jABWaitForElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForElementToNotExistelementRolesNotToTraverse != null)
                {
                    jABWaitForElementToNotExist["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementToNotExistelementRolesNotToTraverse);
                    jABWaitForElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForElementToNotExistmaximumElementsToSearch != null)
                {
                    if (__workflow_jABWaitForElementToNotExistmaximumElementsToSearch != null)
                    {
                        jABWaitForElementToNotExist["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementToNotExistmaximumElementsToSearch);
                        jABWaitForElementToNotExistpropCount++;
                    }

                    jABWaitForElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForElementToNotExist["MaximumElementsToSearch"] = 2000;
                    jABWaitForElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForElementToNotExistmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABWaitForElementToNotExistmaximumChildElementsToSearchPerNode != null)
                    {
                        jABWaitForElementToNotExist["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementToNotExistmaximumChildElementsToSearchPerNode);
                        jABWaitForElementToNotExistpropCount++;
                    }

                    jABWaitForElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForElementToNotExist["MaximumChildElementsToSearchPerNode"] = 200;
                    jABWaitForElementToNotExistpropCount++;
                }

                jABWaitForElementToNotExistpropCount++;
                jABWaitForElementToNotExist["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementToNotExistsecondsToWait);
                if (__workflow_jABWaitForElementToNotExistraiseExceptionIfElementStillExists != null)
                {
                    if (__workflow_jABWaitForElementToNotExistraiseExceptionIfElementStillExists != null)
                    {
                        jABWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementToNotExistraiseExceptionIfElementStillExists);
                        jABWaitForElementToNotExistpropCount++;
                    }

                    jABWaitForElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = false;
                    jABWaitForElementToNotExistpropCount++;
                }

                jABWaitForElementToNotExistpropCount++;
                jABWaitForElementToNotExist["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABWaitForElementToNotExistworkflow);
                if (jABWaitForElementToNotExistpropCount > 0)
                {
                    callPayload.Body = jABWaitForElementToNotExist;
                }

                return new ApiConnectionAction<JABWaitForElementToNotExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetDesktopElementsResponse> JABGetDesktopElements(Expression<Func<string>> jABGetDesktopElementsworkflow, Expression<Func<string>> jABGetDesktopElementssearchElementLocalizedControlType = null, Expression<Func<int>> jABGetDesktopElementssearchProcessID = null, Expression<Func<int>> jABGetDesktopElementsfirstItemToReturn = null, Expression<Func<int>> jABGetDesktopElementsmaxItemsToReturn = null, Expression<Func<bool>> jABGetDesktopElementssearchChildElements = null, Expression<Func<int>> jABGetDesktopElementsmaxStringLength = null, Expression<Func<bool>> jABGetDesktopElementsincludeChildProcesses = null)
        {
            var __workflow_jABGetDesktopElementsworkflow = WorkflowExpression.Compile(jABGetDesktopElementsworkflow, nameof(jABGetDesktopElementsworkflow), required: true);
            var __workflow_jABGetDesktopElementssearchElementLocalizedControlType = WorkflowExpression.Compile(jABGetDesktopElementssearchElementLocalizedControlType, nameof(jABGetDesktopElementssearchElementLocalizedControlType), required: false);
            var __workflow_jABGetDesktopElementssearchProcessID = WorkflowExpression.Compile(jABGetDesktopElementssearchProcessID, nameof(jABGetDesktopElementssearchProcessID), required: false);
            var __workflow_jABGetDesktopElementsfirstItemToReturn = WorkflowExpression.Compile(jABGetDesktopElementsfirstItemToReturn, nameof(jABGetDesktopElementsfirstItemToReturn), required: false);
            var __workflow_jABGetDesktopElementsmaxItemsToReturn = WorkflowExpression.Compile(jABGetDesktopElementsmaxItemsToReturn, nameof(jABGetDesktopElementsmaxItemsToReturn), required: false);
            var __workflow_jABGetDesktopElementssearchChildElements = WorkflowExpression.Compile(jABGetDesktopElementssearchChildElements, nameof(jABGetDesktopElementssearchChildElements), required: false);
            var __workflow_jABGetDesktopElementsmaxStringLength = WorkflowExpression.Compile(jABGetDesktopElementsmaxStringLength, nameof(jABGetDesktopElementsmaxStringLength), required: false);
            var __workflow_jABGetDesktopElementsincludeChildProcesses = WorkflowExpression.Compile(jABGetDesktopElementsincludeChildProcesses, nameof(jABGetDesktopElementsincludeChildProcesses), required: false);
            return new DeferredBodyAction<JABGetDesktopElementsResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetDesktopElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetDesktopElements = new JObject();
                var jABGetDesktopElementspropCount = 0;
                if (__workflow_jABGetDesktopElementssearchElementLocalizedControlType != null)
                {
                    jABGetDesktopElements["SearchElementLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_jABGetDesktopElementssearchElementLocalizedControlType);
                    jABGetDesktopElementspropCount++;
                }

                if (__workflow_jABGetDesktopElementssearchProcessID != null)
                {
                    if (__workflow_jABGetDesktopElementssearchProcessID != null)
                    {
                        jABGetDesktopElements["SearchProcessID"] = ExpressionConverter.ConvertO(__workflow_jABGetDesktopElementssearchProcessID);
                        jABGetDesktopElementspropCount++;
                    }

                    jABGetDesktopElementspropCount++;
                }
                else
                {
                    jABGetDesktopElements["SearchProcessID"] = 0;
                    jABGetDesktopElementspropCount++;
                }

                if (__workflow_jABGetDesktopElementsfirstItemToReturn != null)
                {
                    if (__workflow_jABGetDesktopElementsfirstItemToReturn != null)
                    {
                        jABGetDesktopElements["FirstItemToReturn"] = ExpressionConverter.ConvertO(__workflow_jABGetDesktopElementsfirstItemToReturn);
                        jABGetDesktopElementspropCount++;
                    }

                    jABGetDesktopElementspropCount++;
                }
                else
                {
                    jABGetDesktopElements["FirstItemToReturn"] = 1;
                    jABGetDesktopElementspropCount++;
                }

                if (__workflow_jABGetDesktopElementsmaxItemsToReturn != null)
                {
                    if (__workflow_jABGetDesktopElementsmaxItemsToReturn != null)
                    {
                        jABGetDesktopElements["MaxItemsToReturn"] = ExpressionConverter.ConvertO(__workflow_jABGetDesktopElementsmaxItemsToReturn);
                        jABGetDesktopElementspropCount++;
                    }

                    jABGetDesktopElementspropCount++;
                }
                else
                {
                    jABGetDesktopElements["MaxItemsToReturn"] = 0;
                    jABGetDesktopElementspropCount++;
                }

                if (__workflow_jABGetDesktopElementssearchChildElements != null)
                {
                    if (__workflow_jABGetDesktopElementssearchChildElements != null)
                    {
                        jABGetDesktopElements["SearchChildElements"] = ExpressionConverter.ConvertO(__workflow_jABGetDesktopElementssearchChildElements);
                        jABGetDesktopElementspropCount++;
                    }

                    jABGetDesktopElementspropCount++;
                }
                else
                {
                    jABGetDesktopElements["SearchChildElements"] = true;
                    jABGetDesktopElementspropCount++;
                }

                if (__workflow_jABGetDesktopElementsmaxStringLength != null)
                {
                    if (__workflow_jABGetDesktopElementsmaxStringLength != null)
                    {
                        jABGetDesktopElements["MaxStringLength"] = ExpressionConverter.ConvertO(__workflow_jABGetDesktopElementsmaxStringLength);
                        jABGetDesktopElementspropCount++;
                    }

                    jABGetDesktopElementspropCount++;
                }
                else
                {
                    jABGetDesktopElements["MaxStringLength"] = 0;
                    jABGetDesktopElementspropCount++;
                }

                if (__workflow_jABGetDesktopElementsincludeChildProcesses != null)
                {
                    if (__workflow_jABGetDesktopElementsincludeChildProcesses != null)
                    {
                        jABGetDesktopElements["IncludeChildProcesses"] = ExpressionConverter.ConvertO(__workflow_jABGetDesktopElementsincludeChildProcesses);
                        jABGetDesktopElementspropCount++;
                    }

                    jABGetDesktopElementspropCount++;
                }
                else
                {
                    jABGetDesktopElements["IncludeChildProcesses"] = true;
                    jABGetDesktopElementspropCount++;
                }

                jABGetDesktopElementspropCount++;
                jABGetDesktopElements["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetDesktopElementsworkflow);
                if (jABGetDesktopElementspropCount > 0)
                {
                    callPayload.Body = jABGetDesktopElements;
                }

                return new ApiConnectionAction<JABGetDesktopElementsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABDoesDesktopElementExistResponse> JABDoesDesktopElementExist(Expression<Func<string>> jABDoesDesktopElementExistworkflow, Expression<Func<string>> jABDoesDesktopElementExistsearchUIAElementName = null, Expression<Func<string>> jABDoesDesktopElementExistsearchUIAElementClassName = null, Expression<Func<string>> jABDoesDesktopElementExistsearchUIAElementLocalizedControlType = null, Expression<Func<int>> jABDoesDesktopElementExistsearchProcessID = null, Expression<Func<bool>> jABDoesDesktopElementExistsearchChildElements = null, Expression<Func<int>> jABDoesDesktopElementExistmatchIndex = null, Expression<Func<string>> jABDoesDesktopElementExistsearchFilter = null, Expression<Func<string>> jABDoesDesktopElementExistsortByColumn = null, Expression<Func<bool>> jABDoesDesktopElementExistmatchIndexAscending = null, Expression<Func<bool>> jABDoesDesktopElementExistincludeChildProcesses = null)
        {
            var __workflow_jABDoesDesktopElementExistworkflow = WorkflowExpression.Compile(jABDoesDesktopElementExistworkflow, nameof(jABDoesDesktopElementExistworkflow), required: true);
            var __workflow_jABDoesDesktopElementExistsearchUIAElementName = WorkflowExpression.Compile(jABDoesDesktopElementExistsearchUIAElementName, nameof(jABDoesDesktopElementExistsearchUIAElementName), required: false);
            var __workflow_jABDoesDesktopElementExistsearchUIAElementClassName = WorkflowExpression.Compile(jABDoesDesktopElementExistsearchUIAElementClassName, nameof(jABDoesDesktopElementExistsearchUIAElementClassName), required: false);
            var __workflow_jABDoesDesktopElementExistsearchUIAElementLocalizedControlType = WorkflowExpression.Compile(jABDoesDesktopElementExistsearchUIAElementLocalizedControlType, nameof(jABDoesDesktopElementExistsearchUIAElementLocalizedControlType), required: false);
            var __workflow_jABDoesDesktopElementExistsearchProcessID = WorkflowExpression.Compile(jABDoesDesktopElementExistsearchProcessID, nameof(jABDoesDesktopElementExistsearchProcessID), required: false);
            var __workflow_jABDoesDesktopElementExistsearchChildElements = WorkflowExpression.Compile(jABDoesDesktopElementExistsearchChildElements, nameof(jABDoesDesktopElementExistsearchChildElements), required: false);
            var __workflow_jABDoesDesktopElementExistmatchIndex = WorkflowExpression.Compile(jABDoesDesktopElementExistmatchIndex, nameof(jABDoesDesktopElementExistmatchIndex), required: false);
            var __workflow_jABDoesDesktopElementExistsearchFilter = WorkflowExpression.Compile(jABDoesDesktopElementExistsearchFilter, nameof(jABDoesDesktopElementExistsearchFilter), required: false);
            var __workflow_jABDoesDesktopElementExistsortByColumn = WorkflowExpression.Compile(jABDoesDesktopElementExistsortByColumn, nameof(jABDoesDesktopElementExistsortByColumn), required: false);
            var __workflow_jABDoesDesktopElementExistmatchIndexAscending = WorkflowExpression.Compile(jABDoesDesktopElementExistmatchIndexAscending, nameof(jABDoesDesktopElementExistmatchIndexAscending), required: false);
            var __workflow_jABDoesDesktopElementExistincludeChildProcesses = WorkflowExpression.Compile(jABDoesDesktopElementExistincludeChildProcesses, nameof(jABDoesDesktopElementExistincludeChildProcesses), required: false);
            return new DeferredBodyAction<JABDoesDesktopElementExistResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABDoesDesktopElementExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABDoesDesktopElementExist = new JObject();
                var jABDoesDesktopElementExistpropCount = 0;
                if (__workflow_jABDoesDesktopElementExistsearchUIAElementName != null)
                {
                    jABDoesDesktopElementExist["SearchUIAElementName"] = ExpressionConverter.ConvertO(__workflow_jABDoesDesktopElementExistsearchUIAElementName);
                    jABDoesDesktopElementExistpropCount++;
                }

                if (__workflow_jABDoesDesktopElementExistsearchUIAElementClassName != null)
                {
                    jABDoesDesktopElementExist["SearchUIAElementClassName"] = ExpressionConverter.ConvertO(__workflow_jABDoesDesktopElementExistsearchUIAElementClassName);
                    jABDoesDesktopElementExistpropCount++;
                }

                if (__workflow_jABDoesDesktopElementExistsearchUIAElementLocalizedControlType != null)
                {
                    jABDoesDesktopElementExist["SearchUIAElementLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_jABDoesDesktopElementExistsearchUIAElementLocalizedControlType);
                    jABDoesDesktopElementExistpropCount++;
                }

                if (__workflow_jABDoesDesktopElementExistsearchProcessID != null)
                {
                    if (__workflow_jABDoesDesktopElementExistsearchProcessID != null)
                    {
                        jABDoesDesktopElementExist["SearchProcessID"] = ExpressionConverter.ConvertO(__workflow_jABDoesDesktopElementExistsearchProcessID);
                        jABDoesDesktopElementExistpropCount++;
                    }

                    jABDoesDesktopElementExistpropCount++;
                }
                else
                {
                    jABDoesDesktopElementExist["SearchProcessID"] = 0;
                    jABDoesDesktopElementExistpropCount++;
                }

                if (__workflow_jABDoesDesktopElementExistsearchChildElements != null)
                {
                    if (__workflow_jABDoesDesktopElementExistsearchChildElements != null)
                    {
                        jABDoesDesktopElementExist["SearchChildElements"] = ExpressionConverter.ConvertO(__workflow_jABDoesDesktopElementExistsearchChildElements);
                        jABDoesDesktopElementExistpropCount++;
                    }

                    jABDoesDesktopElementExistpropCount++;
                }
                else
                {
                    jABDoesDesktopElementExist["SearchChildElements"] = true;
                    jABDoesDesktopElementExistpropCount++;
                }

                if (__workflow_jABDoesDesktopElementExistmatchIndex != null)
                {
                    if (__workflow_jABDoesDesktopElementExistmatchIndex != null)
                    {
                        jABDoesDesktopElementExist["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABDoesDesktopElementExistmatchIndex);
                        jABDoesDesktopElementExistpropCount++;
                    }

                    jABDoesDesktopElementExistpropCount++;
                }
                else
                {
                    jABDoesDesktopElementExist["MatchIndex"] = 1;
                    jABDoesDesktopElementExistpropCount++;
                }

                if (__workflow_jABDoesDesktopElementExistsearchFilter != null)
                {
                    jABDoesDesktopElementExist["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABDoesDesktopElementExistsearchFilter);
                    jABDoesDesktopElementExistpropCount++;
                }

                if (__workflow_jABDoesDesktopElementExistsortByColumn != null)
                {
                    jABDoesDesktopElementExist["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABDoesDesktopElementExistsortByColumn);
                    jABDoesDesktopElementExistpropCount++;
                }

                if (__workflow_jABDoesDesktopElementExistmatchIndexAscending != null)
                {
                    if (__workflow_jABDoesDesktopElementExistmatchIndexAscending != null)
                    {
                        jABDoesDesktopElementExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABDoesDesktopElementExistmatchIndexAscending);
                        jABDoesDesktopElementExistpropCount++;
                    }

                    jABDoesDesktopElementExistpropCount++;
                }
                else
                {
                    jABDoesDesktopElementExist["MatchIndexAscending"] = true;
                    jABDoesDesktopElementExistpropCount++;
                }

                if (__workflow_jABDoesDesktopElementExistincludeChildProcesses != null)
                {
                    if (__workflow_jABDoesDesktopElementExistincludeChildProcesses != null)
                    {
                        jABDoesDesktopElementExist["IncludeChildProcesses"] = ExpressionConverter.ConvertO(__workflow_jABDoesDesktopElementExistincludeChildProcesses);
                        jABDoesDesktopElementExistpropCount++;
                    }

                    jABDoesDesktopElementExistpropCount++;
                }
                else
                {
                    jABDoesDesktopElementExist["IncludeChildProcesses"] = true;
                    jABDoesDesktopElementExistpropCount++;
                }

                jABDoesDesktopElementExistpropCount++;
                jABDoesDesktopElementExist["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABDoesDesktopElementExistworkflow);
                if (jABDoesDesktopElementExistpropCount > 0)
                {
                    callPayload.Body = jABDoesDesktopElementExist;
                }

                return new ApiConnectionAction<JABDoesDesktopElementExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABWaitForDesktopElementResponse> JABWaitForDesktopElement(Expression<Func<double>> jABWaitForDesktopElementsecondsToWait, Expression<Func<string>> jABWaitForDesktopElementworkflow, Expression<Func<string>> jABWaitForDesktopElementsearchUIAElementName = null, Expression<Func<string>> jABWaitForDesktopElementsearchUIAElementClassName = null, Expression<Func<string>> jABWaitForDesktopElementsearchUIAElementLocalizedControlType = null, Expression<Func<int>> jABWaitForDesktopElementsearchProcessID = null, Expression<Func<bool>> jABWaitForDesktopElementsearchChildElements = null, Expression<Func<int>> jABWaitForDesktopElementmatchIndex = null, Expression<Func<string>> jABWaitForDesktopElementsearchFilter = null, Expression<Func<string>> jABWaitForDesktopElementsortByColumn = null, Expression<Func<bool>> jABWaitForDesktopElementmatchIndexAscending = null, Expression<Func<bool>> jABWaitForDesktopElementincludeChildProcesses = null, Expression<Func<bool>> jABWaitForDesktopElementraiseExceptionIfElementNotFound = null)
        {
            var __workflow_jABWaitForDesktopElementsecondsToWait = WorkflowExpression.Compile(jABWaitForDesktopElementsecondsToWait, nameof(jABWaitForDesktopElementsecondsToWait), required: true);
            var __workflow_jABWaitForDesktopElementworkflow = WorkflowExpression.Compile(jABWaitForDesktopElementworkflow, nameof(jABWaitForDesktopElementworkflow), required: true);
            var __workflow_jABWaitForDesktopElementsearchUIAElementName = WorkflowExpression.Compile(jABWaitForDesktopElementsearchUIAElementName, nameof(jABWaitForDesktopElementsearchUIAElementName), required: false);
            var __workflow_jABWaitForDesktopElementsearchUIAElementClassName = WorkflowExpression.Compile(jABWaitForDesktopElementsearchUIAElementClassName, nameof(jABWaitForDesktopElementsearchUIAElementClassName), required: false);
            var __workflow_jABWaitForDesktopElementsearchUIAElementLocalizedControlType = WorkflowExpression.Compile(jABWaitForDesktopElementsearchUIAElementLocalizedControlType, nameof(jABWaitForDesktopElementsearchUIAElementLocalizedControlType), required: false);
            var __workflow_jABWaitForDesktopElementsearchProcessID = WorkflowExpression.Compile(jABWaitForDesktopElementsearchProcessID, nameof(jABWaitForDesktopElementsearchProcessID), required: false);
            var __workflow_jABWaitForDesktopElementsearchChildElements = WorkflowExpression.Compile(jABWaitForDesktopElementsearchChildElements, nameof(jABWaitForDesktopElementsearchChildElements), required: false);
            var __workflow_jABWaitForDesktopElementmatchIndex = WorkflowExpression.Compile(jABWaitForDesktopElementmatchIndex, nameof(jABWaitForDesktopElementmatchIndex), required: false);
            var __workflow_jABWaitForDesktopElementsearchFilter = WorkflowExpression.Compile(jABWaitForDesktopElementsearchFilter, nameof(jABWaitForDesktopElementsearchFilter), required: false);
            var __workflow_jABWaitForDesktopElementsortByColumn = WorkflowExpression.Compile(jABWaitForDesktopElementsortByColumn, nameof(jABWaitForDesktopElementsortByColumn), required: false);
            var __workflow_jABWaitForDesktopElementmatchIndexAscending = WorkflowExpression.Compile(jABWaitForDesktopElementmatchIndexAscending, nameof(jABWaitForDesktopElementmatchIndexAscending), required: false);
            var __workflow_jABWaitForDesktopElementincludeChildProcesses = WorkflowExpression.Compile(jABWaitForDesktopElementincludeChildProcesses, nameof(jABWaitForDesktopElementincludeChildProcesses), required: false);
            var __workflow_jABWaitForDesktopElementraiseExceptionIfElementNotFound = WorkflowExpression.Compile(jABWaitForDesktopElementraiseExceptionIfElementNotFound, nameof(jABWaitForDesktopElementraiseExceptionIfElementNotFound), required: false);
            return new DeferredBodyAction<JABWaitForDesktopElementResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABWaitForDesktopElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABWaitForDesktopElement = new JObject();
                var jABWaitForDesktopElementpropCount = 0;
                if (__workflow_jABWaitForDesktopElementsearchUIAElementName != null)
                {
                    jABWaitForDesktopElement["SearchUIAElementName"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementsearchUIAElementName);
                    jABWaitForDesktopElementpropCount++;
                }

                if (__workflow_jABWaitForDesktopElementsearchUIAElementClassName != null)
                {
                    jABWaitForDesktopElement["SearchUIAElementClassName"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementsearchUIAElementClassName);
                    jABWaitForDesktopElementpropCount++;
                }

                if (__workflow_jABWaitForDesktopElementsearchUIAElementLocalizedControlType != null)
                {
                    jABWaitForDesktopElement["SearchUIAElementLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementsearchUIAElementLocalizedControlType);
                    jABWaitForDesktopElementpropCount++;
                }

                if (__workflow_jABWaitForDesktopElementsearchProcessID != null)
                {
                    if (__workflow_jABWaitForDesktopElementsearchProcessID != null)
                    {
                        jABWaitForDesktopElement["SearchProcessID"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementsearchProcessID);
                        jABWaitForDesktopElementpropCount++;
                    }

                    jABWaitForDesktopElementpropCount++;
                }
                else
                {
                    jABWaitForDesktopElement["SearchProcessID"] = 0;
                    jABWaitForDesktopElementpropCount++;
                }

                if (__workflow_jABWaitForDesktopElementsearchChildElements != null)
                {
                    if (__workflow_jABWaitForDesktopElementsearchChildElements != null)
                    {
                        jABWaitForDesktopElement["SearchChildElements"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementsearchChildElements);
                        jABWaitForDesktopElementpropCount++;
                    }

                    jABWaitForDesktopElementpropCount++;
                }
                else
                {
                    jABWaitForDesktopElement["SearchChildElements"] = true;
                    jABWaitForDesktopElementpropCount++;
                }

                if (__workflow_jABWaitForDesktopElementmatchIndex != null)
                {
                    if (__workflow_jABWaitForDesktopElementmatchIndex != null)
                    {
                        jABWaitForDesktopElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementmatchIndex);
                        jABWaitForDesktopElementpropCount++;
                    }

                    jABWaitForDesktopElementpropCount++;
                }
                else
                {
                    jABWaitForDesktopElement["MatchIndex"] = 1;
                    jABWaitForDesktopElementpropCount++;
                }

                if (__workflow_jABWaitForDesktopElementsearchFilter != null)
                {
                    jABWaitForDesktopElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementsearchFilter);
                    jABWaitForDesktopElementpropCount++;
                }

                if (__workflow_jABWaitForDesktopElementsortByColumn != null)
                {
                    jABWaitForDesktopElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementsortByColumn);
                    jABWaitForDesktopElementpropCount++;
                }

                if (__workflow_jABWaitForDesktopElementmatchIndexAscending != null)
                {
                    if (__workflow_jABWaitForDesktopElementmatchIndexAscending != null)
                    {
                        jABWaitForDesktopElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementmatchIndexAscending);
                        jABWaitForDesktopElementpropCount++;
                    }

                    jABWaitForDesktopElementpropCount++;
                }
                else
                {
                    jABWaitForDesktopElement["MatchIndexAscending"] = true;
                    jABWaitForDesktopElementpropCount++;
                }

                jABWaitForDesktopElementpropCount++;
                jABWaitForDesktopElement["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementsecondsToWait);
                if (__workflow_jABWaitForDesktopElementincludeChildProcesses != null)
                {
                    if (__workflow_jABWaitForDesktopElementincludeChildProcesses != null)
                    {
                        jABWaitForDesktopElement["IncludeChildProcesses"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementincludeChildProcesses);
                        jABWaitForDesktopElementpropCount++;
                    }

                    jABWaitForDesktopElementpropCount++;
                }
                else
                {
                    jABWaitForDesktopElement["IncludeChildProcesses"] = true;
                    jABWaitForDesktopElementpropCount++;
                }

                if (__workflow_jABWaitForDesktopElementraiseExceptionIfElementNotFound != null)
                {
                    if (__workflow_jABWaitForDesktopElementraiseExceptionIfElementNotFound != null)
                    {
                        jABWaitForDesktopElement["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementraiseExceptionIfElementNotFound);
                        jABWaitForDesktopElementpropCount++;
                    }

                    jABWaitForDesktopElementpropCount++;
                }
                else
                {
                    jABWaitForDesktopElement["RaiseExceptionIfElementNotFound"] = false;
                    jABWaitForDesktopElementpropCount++;
                }

                jABWaitForDesktopElementpropCount++;
                jABWaitForDesktopElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementworkflow);
                if (jABWaitForDesktopElementpropCount > 0)
                {
                    callPayload.Body = jABWaitForDesktopElement;
                }

                return new ApiConnectionAction<JABWaitForDesktopElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABWaitForDesktopElementToNotExistResponse> JABWaitForDesktopElementToNotExist(Expression<Func<double>> jABWaitForDesktopElementToNotExistsecondsToWait, Expression<Func<string>> jABWaitForDesktopElementToNotExistworkflow, Expression<Func<string>> jABWaitForDesktopElementToNotExistsearchUIAElementName = null, Expression<Func<string>> jABWaitForDesktopElementToNotExistsearchUIAElementClassName = null, Expression<Func<string>> jABWaitForDesktopElementToNotExistsearchUIAElementLocalizedControlType = null, Expression<Func<int>> jABWaitForDesktopElementToNotExistsearchProcessID = null, Expression<Func<bool>> jABWaitForDesktopElementToNotExistsearchChildElements = null, Expression<Func<int>> jABWaitForDesktopElementToNotExistmatchIndex = null, Expression<Func<string>> jABWaitForDesktopElementToNotExistsearchFilter = null, Expression<Func<string>> jABWaitForDesktopElementToNotExistsortByColumn = null, Expression<Func<bool>> jABWaitForDesktopElementToNotExistmatchIndexAscending = null, Expression<Func<bool>> jABWaitForDesktopElementToNotExistincludeChildProcesses = null, Expression<Func<bool>> jABWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists = null)
        {
            var __workflow_jABWaitForDesktopElementToNotExistsecondsToWait = WorkflowExpression.Compile(jABWaitForDesktopElementToNotExistsecondsToWait, nameof(jABWaitForDesktopElementToNotExistsecondsToWait), required: true);
            var __workflow_jABWaitForDesktopElementToNotExistworkflow = WorkflowExpression.Compile(jABWaitForDesktopElementToNotExistworkflow, nameof(jABWaitForDesktopElementToNotExistworkflow), required: true);
            var __workflow_jABWaitForDesktopElementToNotExistsearchUIAElementName = WorkflowExpression.Compile(jABWaitForDesktopElementToNotExistsearchUIAElementName, nameof(jABWaitForDesktopElementToNotExistsearchUIAElementName), required: false);
            var __workflow_jABWaitForDesktopElementToNotExistsearchUIAElementClassName = WorkflowExpression.Compile(jABWaitForDesktopElementToNotExistsearchUIAElementClassName, nameof(jABWaitForDesktopElementToNotExistsearchUIAElementClassName), required: false);
            var __workflow_jABWaitForDesktopElementToNotExistsearchUIAElementLocalizedControlType = WorkflowExpression.Compile(jABWaitForDesktopElementToNotExistsearchUIAElementLocalizedControlType, nameof(jABWaitForDesktopElementToNotExistsearchUIAElementLocalizedControlType), required: false);
            var __workflow_jABWaitForDesktopElementToNotExistsearchProcessID = WorkflowExpression.Compile(jABWaitForDesktopElementToNotExistsearchProcessID, nameof(jABWaitForDesktopElementToNotExistsearchProcessID), required: false);
            var __workflow_jABWaitForDesktopElementToNotExistsearchChildElements = WorkflowExpression.Compile(jABWaitForDesktopElementToNotExistsearchChildElements, nameof(jABWaitForDesktopElementToNotExistsearchChildElements), required: false);
            var __workflow_jABWaitForDesktopElementToNotExistmatchIndex = WorkflowExpression.Compile(jABWaitForDesktopElementToNotExistmatchIndex, nameof(jABWaitForDesktopElementToNotExistmatchIndex), required: false);
            var __workflow_jABWaitForDesktopElementToNotExistsearchFilter = WorkflowExpression.Compile(jABWaitForDesktopElementToNotExistsearchFilter, nameof(jABWaitForDesktopElementToNotExistsearchFilter), required: false);
            var __workflow_jABWaitForDesktopElementToNotExistsortByColumn = WorkflowExpression.Compile(jABWaitForDesktopElementToNotExistsortByColumn, nameof(jABWaitForDesktopElementToNotExistsortByColumn), required: false);
            var __workflow_jABWaitForDesktopElementToNotExistmatchIndexAscending = WorkflowExpression.Compile(jABWaitForDesktopElementToNotExistmatchIndexAscending, nameof(jABWaitForDesktopElementToNotExistmatchIndexAscending), required: false);
            var __workflow_jABWaitForDesktopElementToNotExistincludeChildProcesses = WorkflowExpression.Compile(jABWaitForDesktopElementToNotExistincludeChildProcesses, nameof(jABWaitForDesktopElementToNotExistincludeChildProcesses), required: false);
            var __workflow_jABWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists = WorkflowExpression.Compile(jABWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists, nameof(jABWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists), required: false);
            return new DeferredBodyAction<JABWaitForDesktopElementToNotExistResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABWaitForDesktopElementToNotExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABWaitForDesktopElementToNotExist = new JObject();
                var jABWaitForDesktopElementToNotExistpropCount = 0;
                if (__workflow_jABWaitForDesktopElementToNotExistsearchUIAElementName != null)
                {
                    jABWaitForDesktopElementToNotExist["SearchUIAElementName"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementToNotExistsearchUIAElementName);
                    jABWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForDesktopElementToNotExistsearchUIAElementClassName != null)
                {
                    jABWaitForDesktopElementToNotExist["SearchUIAElementClassName"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementToNotExistsearchUIAElementClassName);
                    jABWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForDesktopElementToNotExistsearchUIAElementLocalizedControlType != null)
                {
                    jABWaitForDesktopElementToNotExist["SearchUIAElementLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementToNotExistsearchUIAElementLocalizedControlType);
                    jABWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForDesktopElementToNotExistsearchProcessID != null)
                {
                    if (__workflow_jABWaitForDesktopElementToNotExistsearchProcessID != null)
                    {
                        jABWaitForDesktopElementToNotExist["SearchProcessID"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementToNotExistsearchProcessID);
                        jABWaitForDesktopElementToNotExistpropCount++;
                    }

                    jABWaitForDesktopElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForDesktopElementToNotExist["SearchProcessID"] = 0;
                    jABWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForDesktopElementToNotExistsearchChildElements != null)
                {
                    if (__workflow_jABWaitForDesktopElementToNotExistsearchChildElements != null)
                    {
                        jABWaitForDesktopElementToNotExist["SearchChildElements"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementToNotExistsearchChildElements);
                        jABWaitForDesktopElementToNotExistpropCount++;
                    }

                    jABWaitForDesktopElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForDesktopElementToNotExist["SearchChildElements"] = true;
                    jABWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForDesktopElementToNotExistmatchIndex != null)
                {
                    if (__workflow_jABWaitForDesktopElementToNotExistmatchIndex != null)
                    {
                        jABWaitForDesktopElementToNotExist["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementToNotExistmatchIndex);
                        jABWaitForDesktopElementToNotExistpropCount++;
                    }

                    jABWaitForDesktopElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForDesktopElementToNotExist["MatchIndex"] = 1;
                    jABWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForDesktopElementToNotExistsearchFilter != null)
                {
                    jABWaitForDesktopElementToNotExist["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementToNotExistsearchFilter);
                    jABWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForDesktopElementToNotExistsortByColumn != null)
                {
                    jABWaitForDesktopElementToNotExist["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementToNotExistsortByColumn);
                    jABWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForDesktopElementToNotExistmatchIndexAscending != null)
                {
                    if (__workflow_jABWaitForDesktopElementToNotExistmatchIndexAscending != null)
                    {
                        jABWaitForDesktopElementToNotExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementToNotExistmatchIndexAscending);
                        jABWaitForDesktopElementToNotExistpropCount++;
                    }

                    jABWaitForDesktopElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForDesktopElementToNotExist["MatchIndexAscending"] = true;
                    jABWaitForDesktopElementToNotExistpropCount++;
                }

                jABWaitForDesktopElementToNotExistpropCount++;
                jABWaitForDesktopElementToNotExist["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementToNotExistsecondsToWait);
                if (__workflow_jABWaitForDesktopElementToNotExistincludeChildProcesses != null)
                {
                    if (__workflow_jABWaitForDesktopElementToNotExistincludeChildProcesses != null)
                    {
                        jABWaitForDesktopElementToNotExist["IncludeChildProcesses"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementToNotExistincludeChildProcesses);
                        jABWaitForDesktopElementToNotExistpropCount++;
                    }

                    jABWaitForDesktopElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForDesktopElementToNotExist["IncludeChildProcesses"] = true;
                    jABWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_jABWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists != null)
                {
                    if (__workflow_jABWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists != null)
                    {
                        jABWaitForDesktopElementToNotExist["RaiseExceptionIfElementStillExists"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists);
                        jABWaitForDesktopElementToNotExistpropCount++;
                    }

                    jABWaitForDesktopElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForDesktopElementToNotExist["RaiseExceptionIfElementStillExists"] = false;
                    jABWaitForDesktopElementToNotExistpropCount++;
                }

                jABWaitForDesktopElementToNotExistpropCount++;
                jABWaitForDesktopElementToNotExist["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABWaitForDesktopElementToNotExistworkflow);
                if (jABWaitForDesktopElementToNotExistpropCount > 0)
                {
                    callPayload.Body = jABWaitForDesktopElementToNotExist;
                }

                return new ApiConnectionAction<JABWaitForDesktopElementToNotExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABFreeAllJABHandles(Expression<Func<string>> jABFreeAllJABHandlesworkflow)
        {
            var __workflow_jABFreeAllJABHandlesworkflow = WorkflowExpression.Compile(jABFreeAllJABHandlesworkflow, nameof(jABFreeAllJABHandlesworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABFreeAllJABHandles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABFreeAllJABHandles = new JObject();
                var jABFreeAllJABHandlespropCount = 0;
                jABFreeAllJABHandlespropCount++;
                jABFreeAllJABHandles["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABFreeAllJABHandlesworkflow);
                if (jABFreeAllJABHandlespropCount > 0)
                {
                    callPayload.Body = jABFreeAllJABHandles;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetChildJABElementPropertiesResponse> JABGetChildJABElementProperties(Expression<Func<int>> jABGetChildJABElementPropertiessearchElementJABHandle, Expression<Func<int>> jABGetChildJABElementPropertiessearchChildIndex, Expression<Func<string>> jABGetChildJABElementPropertiesworkflow, Expression<Func<int>> jABGetChildJABElementPropertiesmaxStringLength = null)
        {
            var __workflow_jABGetChildJABElementPropertiessearchElementJABHandle = WorkflowExpression.Compile(jABGetChildJABElementPropertiessearchElementJABHandle, nameof(jABGetChildJABElementPropertiessearchElementJABHandle), required: true);
            var __workflow_jABGetChildJABElementPropertiessearchChildIndex = WorkflowExpression.Compile(jABGetChildJABElementPropertiessearchChildIndex, nameof(jABGetChildJABElementPropertiessearchChildIndex), required: true);
            var __workflow_jABGetChildJABElementPropertiesworkflow = WorkflowExpression.Compile(jABGetChildJABElementPropertiesworkflow, nameof(jABGetChildJABElementPropertiesworkflow), required: true);
            var __workflow_jABGetChildJABElementPropertiesmaxStringLength = WorkflowExpression.Compile(jABGetChildJABElementPropertiesmaxStringLength, nameof(jABGetChildJABElementPropertiesmaxStringLength), required: false);
            return new DeferredBodyAction<JABGetChildJABElementPropertiesResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetChildJABElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetChildJABElementProperties = new JObject();
                var jABGetChildJABElementPropertiespropCount = 0;
                jABGetChildJABElementPropertiespropCount++;
                jABGetChildJABElementProperties["SearchElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGetChildJABElementPropertiessearchElementJABHandle);
                jABGetChildJABElementPropertiespropCount++;
                jABGetChildJABElementProperties["SearchChildIndex"] = ExpressionConverter.ConvertO(__workflow_jABGetChildJABElementPropertiessearchChildIndex);
                if (__workflow_jABGetChildJABElementPropertiesmaxStringLength != null)
                {
                    if (__workflow_jABGetChildJABElementPropertiesmaxStringLength != null)
                    {
                        jABGetChildJABElementProperties["MaxStringLength"] = ExpressionConverter.ConvertO(__workflow_jABGetChildJABElementPropertiesmaxStringLength);
                        jABGetChildJABElementPropertiespropCount++;
                    }

                    jABGetChildJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetChildJABElementProperties["MaxStringLength"] = 0;
                    jABGetChildJABElementPropertiespropCount++;
                }

                jABGetChildJABElementPropertiespropCount++;
                jABGetChildJABElementProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetChildJABElementPropertiesworkflow);
                if (jABGetChildJABElementPropertiespropCount > 0)
                {
                    callPayload.Body = jABGetChildJABElementProperties;
                }

                return new ApiConnectionAction<JABGetChildJABElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetAllChildJABElementPropertiesResponse> JABGetAllChildJABElementProperties(Expression<Func<int>> jABGetAllChildJABElementPropertiessearchElementJABHandle, Expression<Func<string>> jABGetAllChildJABElementPropertiesworkflow, Expression<Func<int>> jABGetAllChildJABElementPropertiesfirstItemToReturn = null, Expression<Func<int>> jABGetAllChildJABElementPropertiesmaxItemsToReturn = null, Expression<Func<int>> jABGetAllChildJABElementPropertiesmaxStringLength = null, Expression<Func<bool>> jABGetAllChildJABElementPropertiessearchDescendants = null, Expression<Func<string>> jABGetAllChildJABElementPropertiessearchRole = null, Expression<Func<int>> jABGetAllChildJABElementPropertiesmaxRelativeDepth = null)
        {
            var __workflow_jABGetAllChildJABElementPropertiessearchElementJABHandle = WorkflowExpression.Compile(jABGetAllChildJABElementPropertiessearchElementJABHandle, nameof(jABGetAllChildJABElementPropertiessearchElementJABHandle), required: true);
            var __workflow_jABGetAllChildJABElementPropertiesworkflow = WorkflowExpression.Compile(jABGetAllChildJABElementPropertiesworkflow, nameof(jABGetAllChildJABElementPropertiesworkflow), required: true);
            var __workflow_jABGetAllChildJABElementPropertiesfirstItemToReturn = WorkflowExpression.Compile(jABGetAllChildJABElementPropertiesfirstItemToReturn, nameof(jABGetAllChildJABElementPropertiesfirstItemToReturn), required: false);
            var __workflow_jABGetAllChildJABElementPropertiesmaxItemsToReturn = WorkflowExpression.Compile(jABGetAllChildJABElementPropertiesmaxItemsToReturn, nameof(jABGetAllChildJABElementPropertiesmaxItemsToReturn), required: false);
            var __workflow_jABGetAllChildJABElementPropertiesmaxStringLength = WorkflowExpression.Compile(jABGetAllChildJABElementPropertiesmaxStringLength, nameof(jABGetAllChildJABElementPropertiesmaxStringLength), required: false);
            var __workflow_jABGetAllChildJABElementPropertiessearchDescendants = WorkflowExpression.Compile(jABGetAllChildJABElementPropertiessearchDescendants, nameof(jABGetAllChildJABElementPropertiessearchDescendants), required: false);
            var __workflow_jABGetAllChildJABElementPropertiessearchRole = WorkflowExpression.Compile(jABGetAllChildJABElementPropertiessearchRole, nameof(jABGetAllChildJABElementPropertiessearchRole), required: false);
            var __workflow_jABGetAllChildJABElementPropertiesmaxRelativeDepth = WorkflowExpression.Compile(jABGetAllChildJABElementPropertiesmaxRelativeDepth, nameof(jABGetAllChildJABElementPropertiesmaxRelativeDepth), required: false);
            return new DeferredBodyAction<JABGetAllChildJABElementPropertiesResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetAllChildJABElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetAllChildJABElementProperties = new JObject();
                var jABGetAllChildJABElementPropertiespropCount = 0;
                jABGetAllChildJABElementPropertiespropCount++;
                jABGetAllChildJABElementProperties["SearchElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGetAllChildJABElementPropertiessearchElementJABHandle);
                if (__workflow_jABGetAllChildJABElementPropertiesfirstItemToReturn != null)
                {
                    if (__workflow_jABGetAllChildJABElementPropertiesfirstItemToReturn != null)
                    {
                        jABGetAllChildJABElementProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(__workflow_jABGetAllChildJABElementPropertiesfirstItemToReturn);
                        jABGetAllChildJABElementPropertiespropCount++;
                    }

                    jABGetAllChildJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetAllChildJABElementProperties["FirstItemToReturn"] = 1;
                    jABGetAllChildJABElementPropertiespropCount++;
                }

                if (__workflow_jABGetAllChildJABElementPropertiesmaxItemsToReturn != null)
                {
                    if (__workflow_jABGetAllChildJABElementPropertiesmaxItemsToReturn != null)
                    {
                        jABGetAllChildJABElementProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(__workflow_jABGetAllChildJABElementPropertiesmaxItemsToReturn);
                        jABGetAllChildJABElementPropertiespropCount++;
                    }

                    jABGetAllChildJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetAllChildJABElementProperties["MaxItemsToReturn"] = 0;
                    jABGetAllChildJABElementPropertiespropCount++;
                }

                if (__workflow_jABGetAllChildJABElementPropertiesmaxStringLength != null)
                {
                    if (__workflow_jABGetAllChildJABElementPropertiesmaxStringLength != null)
                    {
                        jABGetAllChildJABElementProperties["MaxStringLength"] = ExpressionConverter.ConvertO(__workflow_jABGetAllChildJABElementPropertiesmaxStringLength);
                        jABGetAllChildJABElementPropertiespropCount++;
                    }

                    jABGetAllChildJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetAllChildJABElementProperties["MaxStringLength"] = 0;
                    jABGetAllChildJABElementPropertiespropCount++;
                }

                if (__workflow_jABGetAllChildJABElementPropertiessearchDescendants != null)
                {
                    if (__workflow_jABGetAllChildJABElementPropertiessearchDescendants != null)
                    {
                        jABGetAllChildJABElementProperties["SearchDescendants"] = ExpressionConverter.ConvertO(__workflow_jABGetAllChildJABElementPropertiessearchDescendants);
                        jABGetAllChildJABElementPropertiespropCount++;
                    }

                    jABGetAllChildJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetAllChildJABElementProperties["SearchDescendants"] = false;
                    jABGetAllChildJABElementPropertiespropCount++;
                }

                if (__workflow_jABGetAllChildJABElementPropertiessearchRole != null)
                {
                    jABGetAllChildJABElementProperties["SearchRole"] = ExpressionConverter.ConvertO(__workflow_jABGetAllChildJABElementPropertiessearchRole);
                    jABGetAllChildJABElementPropertiespropCount++;
                }

                if (__workflow_jABGetAllChildJABElementPropertiesmaxRelativeDepth != null)
                {
                    if (__workflow_jABGetAllChildJABElementPropertiesmaxRelativeDepth != null)
                    {
                        jABGetAllChildJABElementProperties["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABGetAllChildJABElementPropertiesmaxRelativeDepth);
                        jABGetAllChildJABElementPropertiespropCount++;
                    }

                    jABGetAllChildJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetAllChildJABElementProperties["MaxRelativeDepth"] = 0;
                    jABGetAllChildJABElementPropertiespropCount++;
                }

                jABGetAllChildJABElementPropertiespropCount++;
                jABGetAllChildJABElementProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetAllChildJABElementPropertiesworkflow);
                if (jABGetAllChildJABElementPropertiespropCount > 0)
                {
                    callPayload.Body = jABGetAllChildJABElementProperties;
                }

                return new ApiConnectionAction<JABGetAllChildJABElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetParentJABElementPropertiesResponse> JABGetParentJABElementProperties(Expression<Func<int>> jABGetParentJABElementPropertiessearchElementJABHandle, Expression<Func<string>> jABGetParentJABElementPropertiesworkflow, Expression<Func<int>> jABGetParentJABElementPropertiesmaxStringLength = null)
        {
            var __workflow_jABGetParentJABElementPropertiessearchElementJABHandle = WorkflowExpression.Compile(jABGetParentJABElementPropertiessearchElementJABHandle, nameof(jABGetParentJABElementPropertiessearchElementJABHandle), required: true);
            var __workflow_jABGetParentJABElementPropertiesworkflow = WorkflowExpression.Compile(jABGetParentJABElementPropertiesworkflow, nameof(jABGetParentJABElementPropertiesworkflow), required: true);
            var __workflow_jABGetParentJABElementPropertiesmaxStringLength = WorkflowExpression.Compile(jABGetParentJABElementPropertiesmaxStringLength, nameof(jABGetParentJABElementPropertiesmaxStringLength), required: false);
            return new DeferredBodyAction<JABGetParentJABElementPropertiesResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetParentJABElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetParentJABElementProperties = new JObject();
                var jABGetParentJABElementPropertiespropCount = 0;
                jABGetParentJABElementPropertiespropCount++;
                jABGetParentJABElementProperties["SearchElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGetParentJABElementPropertiessearchElementJABHandle);
                if (__workflow_jABGetParentJABElementPropertiesmaxStringLength != null)
                {
                    if (__workflow_jABGetParentJABElementPropertiesmaxStringLength != null)
                    {
                        jABGetParentJABElementProperties["MaxStringLength"] = ExpressionConverter.ConvertO(__workflow_jABGetParentJABElementPropertiesmaxStringLength);
                        jABGetParentJABElementPropertiespropCount++;
                    }

                    jABGetParentJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetParentJABElementProperties["MaxStringLength"] = 0;
                    jABGetParentJABElementPropertiespropCount++;
                }

                jABGetParentJABElementPropertiespropCount++;
                jABGetParentJABElementProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetParentJABElementPropertiesworkflow);
                if (jABGetParentJABElementPropertiespropCount > 0)
                {
                    callPayload.Body = jABGetParentJABElementProperties;
                }

                return new ApiConnectionAction<JABGetParentJABElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABPressElement(Expression<Func<int>> jABPressElementsearchParentElementJABHandle, Expression<Func<string>> jABPressElementworkflow, Expression<Func<string>> jABPressElementsearchElementJABName = null, Expression<Func<string>> jABPressElementsearchElementJABDescription = null, Expression<Func<string>> jABPressElementsearchElementJABRole = null, Expression<Func<bool>> jABPressElementsearchSubTree = null, Expression<Func<int>> jABPressElementmaxRelativeDepth = null, Expression<Func<int>> jABPressElementmatchIndex = null, Expression<Func<string>> jABPressElementsearchFilter = null, Expression<Func<string>> jABPressElementsortByColumn = null, Expression<Func<bool>> jABPressElementmatchIndexAscending = null, Expression<Func<bool>> jABPressElementcaseSensitiveSearch = null, Expression<Func<bool>> jABPressElementonlySearchVisibleElements = null, Expression<Func<bool>> jABPressElementonlySearchShowingElements = null, Expression<Func<string>> jABPressElementelementRolesNotToTraverse = null, Expression<Func<int>> jABPressElementmaximumElementsToSearch = null, Expression<Func<int>> jABPressElementmaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABPressElementnumberOfTimesToPressElement = null, Expression<Func<double>> jABPressElementsecondsToWaitBetweenPresses = null, Expression<Func<bool>> jABPressElementautoDetectActionName = null, Expression<Func<string>> jABPressElementoverrideActionName = null)
        {
            var __workflow_jABPressElementsearchParentElementJABHandle = WorkflowExpression.Compile(jABPressElementsearchParentElementJABHandle, nameof(jABPressElementsearchParentElementJABHandle), required: true);
            var __workflow_jABPressElementworkflow = WorkflowExpression.Compile(jABPressElementworkflow, nameof(jABPressElementworkflow), required: true);
            var __workflow_jABPressElementsearchElementJABName = WorkflowExpression.Compile(jABPressElementsearchElementJABName, nameof(jABPressElementsearchElementJABName), required: false);
            var __workflow_jABPressElementsearchElementJABDescription = WorkflowExpression.Compile(jABPressElementsearchElementJABDescription, nameof(jABPressElementsearchElementJABDescription), required: false);
            var __workflow_jABPressElementsearchElementJABRole = WorkflowExpression.Compile(jABPressElementsearchElementJABRole, nameof(jABPressElementsearchElementJABRole), required: false);
            var __workflow_jABPressElementsearchSubTree = WorkflowExpression.Compile(jABPressElementsearchSubTree, nameof(jABPressElementsearchSubTree), required: false);
            var __workflow_jABPressElementmaxRelativeDepth = WorkflowExpression.Compile(jABPressElementmaxRelativeDepth, nameof(jABPressElementmaxRelativeDepth), required: false);
            var __workflow_jABPressElementmatchIndex = WorkflowExpression.Compile(jABPressElementmatchIndex, nameof(jABPressElementmatchIndex), required: false);
            var __workflow_jABPressElementsearchFilter = WorkflowExpression.Compile(jABPressElementsearchFilter, nameof(jABPressElementsearchFilter), required: false);
            var __workflow_jABPressElementsortByColumn = WorkflowExpression.Compile(jABPressElementsortByColumn, nameof(jABPressElementsortByColumn), required: false);
            var __workflow_jABPressElementmatchIndexAscending = WorkflowExpression.Compile(jABPressElementmatchIndexAscending, nameof(jABPressElementmatchIndexAscending), required: false);
            var __workflow_jABPressElementcaseSensitiveSearch = WorkflowExpression.Compile(jABPressElementcaseSensitiveSearch, nameof(jABPressElementcaseSensitiveSearch), required: false);
            var __workflow_jABPressElementonlySearchVisibleElements = WorkflowExpression.Compile(jABPressElementonlySearchVisibleElements, nameof(jABPressElementonlySearchVisibleElements), required: false);
            var __workflow_jABPressElementonlySearchShowingElements = WorkflowExpression.Compile(jABPressElementonlySearchShowingElements, nameof(jABPressElementonlySearchShowingElements), required: false);
            var __workflow_jABPressElementelementRolesNotToTraverse = WorkflowExpression.Compile(jABPressElementelementRolesNotToTraverse, nameof(jABPressElementelementRolesNotToTraverse), required: false);
            var __workflow_jABPressElementmaximumElementsToSearch = WorkflowExpression.Compile(jABPressElementmaximumElementsToSearch, nameof(jABPressElementmaximumElementsToSearch), required: false);
            var __workflow_jABPressElementmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABPressElementmaximumChildElementsToSearchPerNode, nameof(jABPressElementmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABPressElementnumberOfTimesToPressElement = WorkflowExpression.Compile(jABPressElementnumberOfTimesToPressElement, nameof(jABPressElementnumberOfTimesToPressElement), required: false);
            var __workflow_jABPressElementsecondsToWaitBetweenPresses = WorkflowExpression.Compile(jABPressElementsecondsToWaitBetweenPresses, nameof(jABPressElementsecondsToWaitBetweenPresses), required: false);
            var __workflow_jABPressElementautoDetectActionName = WorkflowExpression.Compile(jABPressElementautoDetectActionName, nameof(jABPressElementautoDetectActionName), required: false);
            var __workflow_jABPressElementoverrideActionName = WorkflowExpression.Compile(jABPressElementoverrideActionName, nameof(jABPressElementoverrideActionName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABPressElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABPressElement = new JObject();
                var jABPressElementpropCount = 0;
                jABPressElementpropCount++;
                jABPressElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABPressElementsearchParentElementJABHandle);
                if (__workflow_jABPressElementsearchElementJABName != null)
                {
                    jABPressElement["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABPressElementsearchElementJABName);
                    jABPressElementpropCount++;
                }

                if (__workflow_jABPressElementsearchElementJABDescription != null)
                {
                    jABPressElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABPressElementsearchElementJABDescription);
                    jABPressElementpropCount++;
                }

                if (__workflow_jABPressElementsearchElementJABRole != null)
                {
                    jABPressElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABPressElementsearchElementJABRole);
                    jABPressElementpropCount++;
                }

                if (__workflow_jABPressElementsearchSubTree != null)
                {
                    if (__workflow_jABPressElementsearchSubTree != null)
                    {
                        jABPressElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABPressElementsearchSubTree);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["SearchSubTree"] = true;
                    jABPressElementpropCount++;
                }

                if (__workflow_jABPressElementmaxRelativeDepth != null)
                {
                    if (__workflow_jABPressElementmaxRelativeDepth != null)
                    {
                        jABPressElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABPressElementmaxRelativeDepth);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["MaxRelativeDepth"] = 0;
                    jABPressElementpropCount++;
                }

                if (__workflow_jABPressElementmatchIndex != null)
                {
                    if (__workflow_jABPressElementmatchIndex != null)
                    {
                        jABPressElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABPressElementmatchIndex);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["MatchIndex"] = 1;
                    jABPressElementpropCount++;
                }

                if (__workflow_jABPressElementsearchFilter != null)
                {
                    jABPressElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABPressElementsearchFilter);
                    jABPressElementpropCount++;
                }

                if (__workflow_jABPressElementsortByColumn != null)
                {
                    jABPressElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABPressElementsortByColumn);
                    jABPressElementpropCount++;
                }

                if (__workflow_jABPressElementmatchIndexAscending != null)
                {
                    if (__workflow_jABPressElementmatchIndexAscending != null)
                    {
                        jABPressElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABPressElementmatchIndexAscending);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["MatchIndexAscending"] = true;
                    jABPressElementpropCount++;
                }

                if (__workflow_jABPressElementcaseSensitiveSearch != null)
                {
                    if (__workflow_jABPressElementcaseSensitiveSearch != null)
                    {
                        jABPressElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABPressElementcaseSensitiveSearch);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["CaseSensitiveSearch"] = false;
                    jABPressElementpropCount++;
                }

                if (__workflow_jABPressElementonlySearchVisibleElements != null)
                {
                    if (__workflow_jABPressElementonlySearchVisibleElements != null)
                    {
                        jABPressElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABPressElementonlySearchVisibleElements);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["OnlySearchVisibleElements"] = true;
                    jABPressElementpropCount++;
                }

                if (__workflow_jABPressElementonlySearchShowingElements != null)
                {
                    if (__workflow_jABPressElementonlySearchShowingElements != null)
                    {
                        jABPressElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABPressElementonlySearchShowingElements);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["OnlySearchShowingElements"] = true;
                    jABPressElementpropCount++;
                }

                if (__workflow_jABPressElementelementRolesNotToTraverse != null)
                {
                    jABPressElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABPressElementelementRolesNotToTraverse);
                    jABPressElementpropCount++;
                }

                if (__workflow_jABPressElementmaximumElementsToSearch != null)
                {
                    if (__workflow_jABPressElementmaximumElementsToSearch != null)
                    {
                        jABPressElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABPressElementmaximumElementsToSearch);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["MaximumElementsToSearch"] = 2000;
                    jABPressElementpropCount++;
                }

                if (__workflow_jABPressElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABPressElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABPressElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABPressElementmaximumChildElementsToSearchPerNode);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABPressElementpropCount++;
                }

                if (__workflow_jABPressElementnumberOfTimesToPressElement != null)
                {
                    if (__workflow_jABPressElementnumberOfTimesToPressElement != null)
                    {
                        jABPressElement["NumberOfTimesToPressElement"] = ExpressionConverter.ConvertO(__workflow_jABPressElementnumberOfTimesToPressElement);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["NumberOfTimesToPressElement"] = 1;
                    jABPressElementpropCount++;
                }

                if (__workflow_jABPressElementsecondsToWaitBetweenPresses != null)
                {
                    if (__workflow_jABPressElementsecondsToWaitBetweenPresses != null)
                    {
                        jABPressElement["SecondsToWaitBetweenPresses"] = ExpressionConverter.ConvertO(__workflow_jABPressElementsecondsToWaitBetweenPresses);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["SecondsToWaitBetweenPresses"] = 0;
                    jABPressElementpropCount++;
                }

                if (__workflow_jABPressElementautoDetectActionName != null)
                {
                    if (__workflow_jABPressElementautoDetectActionName != null)
                    {
                        jABPressElement["AutoDetectActionName"] = ExpressionConverter.ConvertO(__workflow_jABPressElementautoDetectActionName);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["AutoDetectActionName"] = true;
                    jABPressElementpropCount++;
                }

                if (__workflow_jABPressElementoverrideActionName != null)
                {
                    jABPressElement["OverrideActionName"] = ExpressionConverter.ConvertO(__workflow_jABPressElementoverrideActionName);
                    jABPressElementpropCount++;
                }

                jABPressElementpropCount++;
                jABPressElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABPressElementworkflow);
                if (jABPressElementpropCount > 0)
                {
                    callPayload.Body = jABPressElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABPerformActionOnElement(Expression<Func<int>> jABPerformActionOnElementsearchParentElementJABHandle, Expression<Func<string>> jABPerformActionOnElementaction, Expression<Func<string>> jABPerformActionOnElementworkflow, Expression<Func<string>> jABPerformActionOnElementsearchElementJABName = null, Expression<Func<string>> jABPerformActionOnElementsearchElementJABDescription = null, Expression<Func<string>> jABPerformActionOnElementsearchElementJABRole = null, Expression<Func<bool>> jABPerformActionOnElementsearchSubTree = null, Expression<Func<int>> jABPerformActionOnElementmaxRelativeDepth = null, Expression<Func<int>> jABPerformActionOnElementmatchIndex = null, Expression<Func<string>> jABPerformActionOnElementsearchFilter = null, Expression<Func<string>> jABPerformActionOnElementsortByColumn = null, Expression<Func<bool>> jABPerformActionOnElementmatchIndexAscending = null, Expression<Func<bool>> jABPerformActionOnElementcaseSensitiveSearch = null, Expression<Func<bool>> jABPerformActionOnElementonlySearchVisibleElements = null, Expression<Func<bool>> jABPerformActionOnElementonlySearchShowingElements = null, Expression<Func<string>> jABPerformActionOnElementelementRolesNotToTraverse = null, Expression<Func<int>> jABPerformActionOnElementmaximumElementsToSearch = null, Expression<Func<int>> jABPerformActionOnElementmaximumChildElementsToSearchPerNode = null)
        {
            var __workflow_jABPerformActionOnElementsearchParentElementJABHandle = WorkflowExpression.Compile(jABPerformActionOnElementsearchParentElementJABHandle, nameof(jABPerformActionOnElementsearchParentElementJABHandle), required: true);
            var __workflow_jABPerformActionOnElementaction = WorkflowExpression.Compile(jABPerformActionOnElementaction, nameof(jABPerformActionOnElementaction), required: true);
            var __workflow_jABPerformActionOnElementworkflow = WorkflowExpression.Compile(jABPerformActionOnElementworkflow, nameof(jABPerformActionOnElementworkflow), required: true);
            var __workflow_jABPerformActionOnElementsearchElementJABName = WorkflowExpression.Compile(jABPerformActionOnElementsearchElementJABName, nameof(jABPerformActionOnElementsearchElementJABName), required: false);
            var __workflow_jABPerformActionOnElementsearchElementJABDescription = WorkflowExpression.Compile(jABPerformActionOnElementsearchElementJABDescription, nameof(jABPerformActionOnElementsearchElementJABDescription), required: false);
            var __workflow_jABPerformActionOnElementsearchElementJABRole = WorkflowExpression.Compile(jABPerformActionOnElementsearchElementJABRole, nameof(jABPerformActionOnElementsearchElementJABRole), required: false);
            var __workflow_jABPerformActionOnElementsearchSubTree = WorkflowExpression.Compile(jABPerformActionOnElementsearchSubTree, nameof(jABPerformActionOnElementsearchSubTree), required: false);
            var __workflow_jABPerformActionOnElementmaxRelativeDepth = WorkflowExpression.Compile(jABPerformActionOnElementmaxRelativeDepth, nameof(jABPerformActionOnElementmaxRelativeDepth), required: false);
            var __workflow_jABPerformActionOnElementmatchIndex = WorkflowExpression.Compile(jABPerformActionOnElementmatchIndex, nameof(jABPerformActionOnElementmatchIndex), required: false);
            var __workflow_jABPerformActionOnElementsearchFilter = WorkflowExpression.Compile(jABPerformActionOnElementsearchFilter, nameof(jABPerformActionOnElementsearchFilter), required: false);
            var __workflow_jABPerformActionOnElementsortByColumn = WorkflowExpression.Compile(jABPerformActionOnElementsortByColumn, nameof(jABPerformActionOnElementsortByColumn), required: false);
            var __workflow_jABPerformActionOnElementmatchIndexAscending = WorkflowExpression.Compile(jABPerformActionOnElementmatchIndexAscending, nameof(jABPerformActionOnElementmatchIndexAscending), required: false);
            var __workflow_jABPerformActionOnElementcaseSensitiveSearch = WorkflowExpression.Compile(jABPerformActionOnElementcaseSensitiveSearch, nameof(jABPerformActionOnElementcaseSensitiveSearch), required: false);
            var __workflow_jABPerformActionOnElementonlySearchVisibleElements = WorkflowExpression.Compile(jABPerformActionOnElementonlySearchVisibleElements, nameof(jABPerformActionOnElementonlySearchVisibleElements), required: false);
            var __workflow_jABPerformActionOnElementonlySearchShowingElements = WorkflowExpression.Compile(jABPerformActionOnElementonlySearchShowingElements, nameof(jABPerformActionOnElementonlySearchShowingElements), required: false);
            var __workflow_jABPerformActionOnElementelementRolesNotToTraverse = WorkflowExpression.Compile(jABPerformActionOnElementelementRolesNotToTraverse, nameof(jABPerformActionOnElementelementRolesNotToTraverse), required: false);
            var __workflow_jABPerformActionOnElementmaximumElementsToSearch = WorkflowExpression.Compile(jABPerformActionOnElementmaximumElementsToSearch, nameof(jABPerformActionOnElementmaximumElementsToSearch), required: false);
            var __workflow_jABPerformActionOnElementmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABPerformActionOnElementmaximumChildElementsToSearchPerNode, nameof(jABPerformActionOnElementmaximumChildElementsToSearchPerNode), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABPerformActionOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABPerformActionOnElement = new JObject();
                var jABPerformActionOnElementpropCount = 0;
                jABPerformActionOnElementpropCount++;
                jABPerformActionOnElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABPerformActionOnElementsearchParentElementJABHandle);
                if (__workflow_jABPerformActionOnElementsearchElementJABName != null)
                {
                    jABPerformActionOnElement["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABPerformActionOnElementsearchElementJABName);
                    jABPerformActionOnElementpropCount++;
                }

                if (__workflow_jABPerformActionOnElementsearchElementJABDescription != null)
                {
                    jABPerformActionOnElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABPerformActionOnElementsearchElementJABDescription);
                    jABPerformActionOnElementpropCount++;
                }

                if (__workflow_jABPerformActionOnElementsearchElementJABRole != null)
                {
                    jABPerformActionOnElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABPerformActionOnElementsearchElementJABRole);
                    jABPerformActionOnElementpropCount++;
                }

                if (__workflow_jABPerformActionOnElementsearchSubTree != null)
                {
                    if (__workflow_jABPerformActionOnElementsearchSubTree != null)
                    {
                        jABPerformActionOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABPerformActionOnElementsearchSubTree);
                        jABPerformActionOnElementpropCount++;
                    }

                    jABPerformActionOnElementpropCount++;
                }
                else
                {
                    jABPerformActionOnElement["SearchSubTree"] = true;
                    jABPerformActionOnElementpropCount++;
                }

                if (__workflow_jABPerformActionOnElementmaxRelativeDepth != null)
                {
                    if (__workflow_jABPerformActionOnElementmaxRelativeDepth != null)
                    {
                        jABPerformActionOnElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABPerformActionOnElementmaxRelativeDepth);
                        jABPerformActionOnElementpropCount++;
                    }

                    jABPerformActionOnElementpropCount++;
                }
                else
                {
                    jABPerformActionOnElement["MaxRelativeDepth"] = 0;
                    jABPerformActionOnElementpropCount++;
                }

                if (__workflow_jABPerformActionOnElementmatchIndex != null)
                {
                    if (__workflow_jABPerformActionOnElementmatchIndex != null)
                    {
                        jABPerformActionOnElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABPerformActionOnElementmatchIndex);
                        jABPerformActionOnElementpropCount++;
                    }

                    jABPerformActionOnElementpropCount++;
                }
                else
                {
                    jABPerformActionOnElement["MatchIndex"] = 1;
                    jABPerformActionOnElementpropCount++;
                }

                if (__workflow_jABPerformActionOnElementsearchFilter != null)
                {
                    jABPerformActionOnElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABPerformActionOnElementsearchFilter);
                    jABPerformActionOnElementpropCount++;
                }

                if (__workflow_jABPerformActionOnElementsortByColumn != null)
                {
                    jABPerformActionOnElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABPerformActionOnElementsortByColumn);
                    jABPerformActionOnElementpropCount++;
                }

                if (__workflow_jABPerformActionOnElementmatchIndexAscending != null)
                {
                    if (__workflow_jABPerformActionOnElementmatchIndexAscending != null)
                    {
                        jABPerformActionOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABPerformActionOnElementmatchIndexAscending);
                        jABPerformActionOnElementpropCount++;
                    }

                    jABPerformActionOnElementpropCount++;
                }
                else
                {
                    jABPerformActionOnElement["MatchIndexAscending"] = true;
                    jABPerformActionOnElementpropCount++;
                }

                if (__workflow_jABPerformActionOnElementcaseSensitiveSearch != null)
                {
                    if (__workflow_jABPerformActionOnElementcaseSensitiveSearch != null)
                    {
                        jABPerformActionOnElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABPerformActionOnElementcaseSensitiveSearch);
                        jABPerformActionOnElementpropCount++;
                    }

                    jABPerformActionOnElementpropCount++;
                }
                else
                {
                    jABPerformActionOnElement["CaseSensitiveSearch"] = false;
                    jABPerformActionOnElementpropCount++;
                }

                if (__workflow_jABPerformActionOnElementonlySearchVisibleElements != null)
                {
                    if (__workflow_jABPerformActionOnElementonlySearchVisibleElements != null)
                    {
                        jABPerformActionOnElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABPerformActionOnElementonlySearchVisibleElements);
                        jABPerformActionOnElementpropCount++;
                    }

                    jABPerformActionOnElementpropCount++;
                }
                else
                {
                    jABPerformActionOnElement["OnlySearchVisibleElements"] = true;
                    jABPerformActionOnElementpropCount++;
                }

                if (__workflow_jABPerformActionOnElementonlySearchShowingElements != null)
                {
                    if (__workflow_jABPerformActionOnElementonlySearchShowingElements != null)
                    {
                        jABPerformActionOnElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABPerformActionOnElementonlySearchShowingElements);
                        jABPerformActionOnElementpropCount++;
                    }

                    jABPerformActionOnElementpropCount++;
                }
                else
                {
                    jABPerformActionOnElement["OnlySearchShowingElements"] = true;
                    jABPerformActionOnElementpropCount++;
                }

                if (__workflow_jABPerformActionOnElementelementRolesNotToTraverse != null)
                {
                    jABPerformActionOnElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABPerformActionOnElementelementRolesNotToTraverse);
                    jABPerformActionOnElementpropCount++;
                }

                if (__workflow_jABPerformActionOnElementmaximumElementsToSearch != null)
                {
                    if (__workflow_jABPerformActionOnElementmaximumElementsToSearch != null)
                    {
                        jABPerformActionOnElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABPerformActionOnElementmaximumElementsToSearch);
                        jABPerformActionOnElementpropCount++;
                    }

                    jABPerformActionOnElementpropCount++;
                }
                else
                {
                    jABPerformActionOnElement["MaximumElementsToSearch"] = 2000;
                    jABPerformActionOnElementpropCount++;
                }

                if (__workflow_jABPerformActionOnElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABPerformActionOnElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABPerformActionOnElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABPerformActionOnElementmaximumChildElementsToSearchPerNode);
                        jABPerformActionOnElementpropCount++;
                    }

                    jABPerformActionOnElementpropCount++;
                }
                else
                {
                    jABPerformActionOnElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABPerformActionOnElementpropCount++;
                }

                jABPerformActionOnElementpropCount++;
                jABPerformActionOnElement["Action"] = ExpressionConverter.ConvertO(__workflow_jABPerformActionOnElementaction);
                jABPerformActionOnElementpropCount++;
                jABPerformActionOnElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABPerformActionOnElementworkflow);
                if (jABPerformActionOnElementpropCount > 0)
                {
                    callPayload.Body = jABPerformActionOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalLeftMouseClickOnElement(Expression<Func<int>> jABGlobalLeftMouseClickOnElementsearchParentElementJABHandle, Expression<Func<string>> jABGlobalLeftMouseClickOnElementworkflow, Expression<Func<string>> jABGlobalLeftMouseClickOnElementsearchElementJABName = null, Expression<Func<string>> jABGlobalLeftMouseClickOnElementsearchElementJABDescription = null, Expression<Func<string>> jABGlobalLeftMouseClickOnElementsearchElementJABRole = null, Expression<Func<bool>> jABGlobalLeftMouseClickOnElementsearchSubTree = null, Expression<Func<int>> jABGlobalLeftMouseClickOnElementmaxRelativeDepth = null, Expression<Func<int>> jABGlobalLeftMouseClickOnElementmatchIndex = null, Expression<Func<string>> jABGlobalLeftMouseClickOnElementsearchFilter = null, Expression<Func<string>> jABGlobalLeftMouseClickOnElementsortByColumn = null, Expression<Func<bool>> jABGlobalLeftMouseClickOnElementmatchIndexAscending = null, Expression<Func<bool>> jABGlobalLeftMouseClickOnElementcaseSensitiveSearch = null, Expression<Func<bool>> jABGlobalLeftMouseClickOnElementonlySearchVisibleElements = null, Expression<Func<bool>> jABGlobalLeftMouseClickOnElementonlySearchShowingElements = null, Expression<Func<string>> jABGlobalLeftMouseClickOnElementelementRolesNotToTraverse = null, Expression<Func<int>> jABGlobalLeftMouseClickOnElementmaximumElementsToSearch = null, Expression<Func<int>> jABGlobalLeftMouseClickOnElementmaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABGlobalLeftMouseClickOnElementclickOffsetX = null, Expression<Func<int>> jABGlobalLeftMouseClickOnElementclickOffsetY = null, Expression<Func<jABGlobalLeftMouseClickOnElementoffsetRelativeToInput>> jABGlobalLeftMouseClickOnElementoffsetRelativeTo = null, Expression<Func<int>> jABGlobalLeftMouseClickOnElementnumberOfTimesToClickElement = null, Expression<Func<double>> jABGlobalLeftMouseClickOnElementsecondsToWaitBetweenClicks = null)
        {
            var __workflow_jABGlobalLeftMouseClickOnElementsearchParentElementJABHandle = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElementsearchParentElementJABHandle, nameof(jABGlobalLeftMouseClickOnElementsearchParentElementJABHandle), required: true);
            var __workflow_jABGlobalLeftMouseClickOnElementworkflow = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElementworkflow, nameof(jABGlobalLeftMouseClickOnElementworkflow), required: true);
            var __workflow_jABGlobalLeftMouseClickOnElementsearchElementJABName = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElementsearchElementJABName, nameof(jABGlobalLeftMouseClickOnElementsearchElementJABName), required: false);
            var __workflow_jABGlobalLeftMouseClickOnElementsearchElementJABDescription = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElementsearchElementJABDescription, nameof(jABGlobalLeftMouseClickOnElementsearchElementJABDescription), required: false);
            var __workflow_jABGlobalLeftMouseClickOnElementsearchElementJABRole = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElementsearchElementJABRole, nameof(jABGlobalLeftMouseClickOnElementsearchElementJABRole), required: false);
            var __workflow_jABGlobalLeftMouseClickOnElementsearchSubTree = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElementsearchSubTree, nameof(jABGlobalLeftMouseClickOnElementsearchSubTree), required: false);
            var __workflow_jABGlobalLeftMouseClickOnElementmaxRelativeDepth = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElementmaxRelativeDepth, nameof(jABGlobalLeftMouseClickOnElementmaxRelativeDepth), required: false);
            var __workflow_jABGlobalLeftMouseClickOnElementmatchIndex = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElementmatchIndex, nameof(jABGlobalLeftMouseClickOnElementmatchIndex), required: false);
            var __workflow_jABGlobalLeftMouseClickOnElementsearchFilter = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElementsearchFilter, nameof(jABGlobalLeftMouseClickOnElementsearchFilter), required: false);
            var __workflow_jABGlobalLeftMouseClickOnElementsortByColumn = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElementsortByColumn, nameof(jABGlobalLeftMouseClickOnElementsortByColumn), required: false);
            var __workflow_jABGlobalLeftMouseClickOnElementmatchIndexAscending = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElementmatchIndexAscending, nameof(jABGlobalLeftMouseClickOnElementmatchIndexAscending), required: false);
            var __workflow_jABGlobalLeftMouseClickOnElementcaseSensitiveSearch = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElementcaseSensitiveSearch, nameof(jABGlobalLeftMouseClickOnElementcaseSensitiveSearch), required: false);
            var __workflow_jABGlobalLeftMouseClickOnElementonlySearchVisibleElements = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElementonlySearchVisibleElements, nameof(jABGlobalLeftMouseClickOnElementonlySearchVisibleElements), required: false);
            var __workflow_jABGlobalLeftMouseClickOnElementonlySearchShowingElements = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElementonlySearchShowingElements, nameof(jABGlobalLeftMouseClickOnElementonlySearchShowingElements), required: false);
            var __workflow_jABGlobalLeftMouseClickOnElementelementRolesNotToTraverse = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElementelementRolesNotToTraverse, nameof(jABGlobalLeftMouseClickOnElementelementRolesNotToTraverse), required: false);
            var __workflow_jABGlobalLeftMouseClickOnElementmaximumElementsToSearch = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElementmaximumElementsToSearch, nameof(jABGlobalLeftMouseClickOnElementmaximumElementsToSearch), required: false);
            var __workflow_jABGlobalLeftMouseClickOnElementmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElementmaximumChildElementsToSearchPerNode, nameof(jABGlobalLeftMouseClickOnElementmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABGlobalLeftMouseClickOnElementclickOffsetX = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElementclickOffsetX, nameof(jABGlobalLeftMouseClickOnElementclickOffsetX), required: false);
            var __workflow_jABGlobalLeftMouseClickOnElementclickOffsetY = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElementclickOffsetY, nameof(jABGlobalLeftMouseClickOnElementclickOffsetY), required: false);
            var __workflow_jABGlobalLeftMouseClickOnElementoffsetRelativeTo = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElementoffsetRelativeTo, nameof(jABGlobalLeftMouseClickOnElementoffsetRelativeTo), required: false);
            var __workflow_jABGlobalLeftMouseClickOnElementnumberOfTimesToClickElement = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElementnumberOfTimesToClickElement, nameof(jABGlobalLeftMouseClickOnElementnumberOfTimesToClickElement), required: false);
            var __workflow_jABGlobalLeftMouseClickOnElementsecondsToWaitBetweenClicks = WorkflowExpression.Compile(jABGlobalLeftMouseClickOnElementsecondsToWaitBetweenClicks, nameof(jABGlobalLeftMouseClickOnElementsecondsToWaitBetweenClicks), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalLeftMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGlobalLeftMouseClickOnElement = new JObject();
                var jABGlobalLeftMouseClickOnElementpropCount = 0;
                jABGlobalLeftMouseClickOnElementpropCount++;
                jABGlobalLeftMouseClickOnElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElementsearchParentElementJABHandle);
                if (__workflow_jABGlobalLeftMouseClickOnElementsearchElementJABName != null)
                {
                    jABGlobalLeftMouseClickOnElement["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElementsearchElementJABName);
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalLeftMouseClickOnElementsearchElementJABDescription != null)
                {
                    jABGlobalLeftMouseClickOnElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElementsearchElementJABDescription);
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalLeftMouseClickOnElementsearchElementJABRole != null)
                {
                    jABGlobalLeftMouseClickOnElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElementsearchElementJABRole);
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalLeftMouseClickOnElementsearchSubTree != null)
                {
                    if (__workflow_jABGlobalLeftMouseClickOnElementsearchSubTree != null)
                    {
                        jABGlobalLeftMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElementsearchSubTree);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["SearchSubTree"] = true;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalLeftMouseClickOnElementmaxRelativeDepth != null)
                {
                    if (__workflow_jABGlobalLeftMouseClickOnElementmaxRelativeDepth != null)
                    {
                        jABGlobalLeftMouseClickOnElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElementmaxRelativeDepth);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["MaxRelativeDepth"] = 0;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalLeftMouseClickOnElementmatchIndex != null)
                {
                    if (__workflow_jABGlobalLeftMouseClickOnElementmatchIndex != null)
                    {
                        jABGlobalLeftMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElementmatchIndex);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["MatchIndex"] = 1;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalLeftMouseClickOnElementsearchFilter != null)
                {
                    jABGlobalLeftMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElementsearchFilter);
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalLeftMouseClickOnElementsortByColumn != null)
                {
                    jABGlobalLeftMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElementsortByColumn);
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalLeftMouseClickOnElementmatchIndexAscending != null)
                {
                    if (__workflow_jABGlobalLeftMouseClickOnElementmatchIndexAscending != null)
                    {
                        jABGlobalLeftMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElementmatchIndexAscending);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["MatchIndexAscending"] = true;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalLeftMouseClickOnElementcaseSensitiveSearch != null)
                {
                    if (__workflow_jABGlobalLeftMouseClickOnElementcaseSensitiveSearch != null)
                    {
                        jABGlobalLeftMouseClickOnElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElementcaseSensitiveSearch);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["CaseSensitiveSearch"] = false;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalLeftMouseClickOnElementonlySearchVisibleElements != null)
                {
                    if (__workflow_jABGlobalLeftMouseClickOnElementonlySearchVisibleElements != null)
                    {
                        jABGlobalLeftMouseClickOnElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElementonlySearchVisibleElements);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["OnlySearchVisibleElements"] = true;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalLeftMouseClickOnElementonlySearchShowingElements != null)
                {
                    if (__workflow_jABGlobalLeftMouseClickOnElementonlySearchShowingElements != null)
                    {
                        jABGlobalLeftMouseClickOnElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElementonlySearchShowingElements);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["OnlySearchShowingElements"] = true;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalLeftMouseClickOnElementelementRolesNotToTraverse != null)
                {
                    jABGlobalLeftMouseClickOnElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElementelementRolesNotToTraverse);
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalLeftMouseClickOnElementmaximumElementsToSearch != null)
                {
                    if (__workflow_jABGlobalLeftMouseClickOnElementmaximumElementsToSearch != null)
                    {
                        jABGlobalLeftMouseClickOnElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElementmaximumElementsToSearch);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["MaximumElementsToSearch"] = 2000;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalLeftMouseClickOnElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABGlobalLeftMouseClickOnElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGlobalLeftMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElementmaximumChildElementsToSearchPerNode);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalLeftMouseClickOnElementclickOffsetX != null)
                {
                    if (__workflow_jABGlobalLeftMouseClickOnElementclickOffsetX != null)
                    {
                        jABGlobalLeftMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElementclickOffsetX);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["ClickOffsetX"] = 0;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalLeftMouseClickOnElementclickOffsetY != null)
                {
                    if (__workflow_jABGlobalLeftMouseClickOnElementclickOffsetY != null)
                    {
                        jABGlobalLeftMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElementclickOffsetY);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["ClickOffsetY"] = 0;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalLeftMouseClickOnElementoffsetRelativeTo != null)
                {
                    jABGlobalLeftMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElementoffsetRelativeTo);
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalLeftMouseClickOnElementnumberOfTimesToClickElement != null)
                {
                    if (__workflow_jABGlobalLeftMouseClickOnElementnumberOfTimesToClickElement != null)
                    {
                        jABGlobalLeftMouseClickOnElement["NumberOfTimesToClickElement"] = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElementnumberOfTimesToClickElement);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["NumberOfTimesToClickElement"] = 1;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalLeftMouseClickOnElementsecondsToWaitBetweenClicks != null)
                {
                    if (__workflow_jABGlobalLeftMouseClickOnElementsecondsToWaitBetweenClicks != null)
                    {
                        jABGlobalLeftMouseClickOnElement["SecondsToWaitBetweenClicks"] = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElementsecondsToWaitBetweenClicks);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["SecondsToWaitBetweenClicks"] = 0;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                jABGlobalLeftMouseClickOnElementpropCount++;
                jABGlobalLeftMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGlobalLeftMouseClickOnElementworkflow);
                if (jABGlobalLeftMouseClickOnElementpropCount > 0)
                {
                    callPayload.Body = jABGlobalLeftMouseClickOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalRightMouseClickOnElement(Expression<Func<int>> jABGlobalRightMouseClickOnElementsearchParentElementJABHandle, Expression<Func<string>> jABGlobalRightMouseClickOnElementworkflow, Expression<Func<string>> jABGlobalRightMouseClickOnElementsearchElementJABName = null, Expression<Func<string>> jABGlobalRightMouseClickOnElementsearchElementJABDescription = null, Expression<Func<string>> jABGlobalRightMouseClickOnElementsearchElementJABRole = null, Expression<Func<bool>> jABGlobalRightMouseClickOnElementsearchSubTree = null, Expression<Func<int>> jABGlobalRightMouseClickOnElementmaxRelativeDepth = null, Expression<Func<int>> jABGlobalRightMouseClickOnElementmatchIndex = null, Expression<Func<string>> jABGlobalRightMouseClickOnElementsearchFilter = null, Expression<Func<string>> jABGlobalRightMouseClickOnElementsortByColumn = null, Expression<Func<bool>> jABGlobalRightMouseClickOnElementmatchIndexAscending = null, Expression<Func<bool>> jABGlobalRightMouseClickOnElementcaseSensitiveSearch = null, Expression<Func<bool>> jABGlobalRightMouseClickOnElementonlySearchVisibleElements = null, Expression<Func<bool>> jABGlobalRightMouseClickOnElementonlySearchShowingElements = null, Expression<Func<string>> jABGlobalRightMouseClickOnElementelementRolesNotToTraverse = null, Expression<Func<int>> jABGlobalRightMouseClickOnElementmaximumElementsToSearch = null, Expression<Func<int>> jABGlobalRightMouseClickOnElementmaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABGlobalRightMouseClickOnElementclickOffsetX = null, Expression<Func<int>> jABGlobalRightMouseClickOnElementclickOffsetY = null, Expression<Func<jABGlobalRightMouseClickOnElementoffsetRelativeToInput>> jABGlobalRightMouseClickOnElementoffsetRelativeTo = null)
        {
            var __workflow_jABGlobalRightMouseClickOnElementsearchParentElementJABHandle = WorkflowExpression.Compile(jABGlobalRightMouseClickOnElementsearchParentElementJABHandle, nameof(jABGlobalRightMouseClickOnElementsearchParentElementJABHandle), required: true);
            var __workflow_jABGlobalRightMouseClickOnElementworkflow = WorkflowExpression.Compile(jABGlobalRightMouseClickOnElementworkflow, nameof(jABGlobalRightMouseClickOnElementworkflow), required: true);
            var __workflow_jABGlobalRightMouseClickOnElementsearchElementJABName = WorkflowExpression.Compile(jABGlobalRightMouseClickOnElementsearchElementJABName, nameof(jABGlobalRightMouseClickOnElementsearchElementJABName), required: false);
            var __workflow_jABGlobalRightMouseClickOnElementsearchElementJABDescription = WorkflowExpression.Compile(jABGlobalRightMouseClickOnElementsearchElementJABDescription, nameof(jABGlobalRightMouseClickOnElementsearchElementJABDescription), required: false);
            var __workflow_jABGlobalRightMouseClickOnElementsearchElementJABRole = WorkflowExpression.Compile(jABGlobalRightMouseClickOnElementsearchElementJABRole, nameof(jABGlobalRightMouseClickOnElementsearchElementJABRole), required: false);
            var __workflow_jABGlobalRightMouseClickOnElementsearchSubTree = WorkflowExpression.Compile(jABGlobalRightMouseClickOnElementsearchSubTree, nameof(jABGlobalRightMouseClickOnElementsearchSubTree), required: false);
            var __workflow_jABGlobalRightMouseClickOnElementmaxRelativeDepth = WorkflowExpression.Compile(jABGlobalRightMouseClickOnElementmaxRelativeDepth, nameof(jABGlobalRightMouseClickOnElementmaxRelativeDepth), required: false);
            var __workflow_jABGlobalRightMouseClickOnElementmatchIndex = WorkflowExpression.Compile(jABGlobalRightMouseClickOnElementmatchIndex, nameof(jABGlobalRightMouseClickOnElementmatchIndex), required: false);
            var __workflow_jABGlobalRightMouseClickOnElementsearchFilter = WorkflowExpression.Compile(jABGlobalRightMouseClickOnElementsearchFilter, nameof(jABGlobalRightMouseClickOnElementsearchFilter), required: false);
            var __workflow_jABGlobalRightMouseClickOnElementsortByColumn = WorkflowExpression.Compile(jABGlobalRightMouseClickOnElementsortByColumn, nameof(jABGlobalRightMouseClickOnElementsortByColumn), required: false);
            var __workflow_jABGlobalRightMouseClickOnElementmatchIndexAscending = WorkflowExpression.Compile(jABGlobalRightMouseClickOnElementmatchIndexAscending, nameof(jABGlobalRightMouseClickOnElementmatchIndexAscending), required: false);
            var __workflow_jABGlobalRightMouseClickOnElementcaseSensitiveSearch = WorkflowExpression.Compile(jABGlobalRightMouseClickOnElementcaseSensitiveSearch, nameof(jABGlobalRightMouseClickOnElementcaseSensitiveSearch), required: false);
            var __workflow_jABGlobalRightMouseClickOnElementonlySearchVisibleElements = WorkflowExpression.Compile(jABGlobalRightMouseClickOnElementonlySearchVisibleElements, nameof(jABGlobalRightMouseClickOnElementonlySearchVisibleElements), required: false);
            var __workflow_jABGlobalRightMouseClickOnElementonlySearchShowingElements = WorkflowExpression.Compile(jABGlobalRightMouseClickOnElementonlySearchShowingElements, nameof(jABGlobalRightMouseClickOnElementonlySearchShowingElements), required: false);
            var __workflow_jABGlobalRightMouseClickOnElementelementRolesNotToTraverse = WorkflowExpression.Compile(jABGlobalRightMouseClickOnElementelementRolesNotToTraverse, nameof(jABGlobalRightMouseClickOnElementelementRolesNotToTraverse), required: false);
            var __workflow_jABGlobalRightMouseClickOnElementmaximumElementsToSearch = WorkflowExpression.Compile(jABGlobalRightMouseClickOnElementmaximumElementsToSearch, nameof(jABGlobalRightMouseClickOnElementmaximumElementsToSearch), required: false);
            var __workflow_jABGlobalRightMouseClickOnElementmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABGlobalRightMouseClickOnElementmaximumChildElementsToSearchPerNode, nameof(jABGlobalRightMouseClickOnElementmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABGlobalRightMouseClickOnElementclickOffsetX = WorkflowExpression.Compile(jABGlobalRightMouseClickOnElementclickOffsetX, nameof(jABGlobalRightMouseClickOnElementclickOffsetX), required: false);
            var __workflow_jABGlobalRightMouseClickOnElementclickOffsetY = WorkflowExpression.Compile(jABGlobalRightMouseClickOnElementclickOffsetY, nameof(jABGlobalRightMouseClickOnElementclickOffsetY), required: false);
            var __workflow_jABGlobalRightMouseClickOnElementoffsetRelativeTo = WorkflowExpression.Compile(jABGlobalRightMouseClickOnElementoffsetRelativeTo, nameof(jABGlobalRightMouseClickOnElementoffsetRelativeTo), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalRightMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGlobalRightMouseClickOnElement = new JObject();
                var jABGlobalRightMouseClickOnElementpropCount = 0;
                jABGlobalRightMouseClickOnElementpropCount++;
                jABGlobalRightMouseClickOnElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGlobalRightMouseClickOnElementsearchParentElementJABHandle);
                if (__workflow_jABGlobalRightMouseClickOnElementsearchElementJABName != null)
                {
                    jABGlobalRightMouseClickOnElement["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABGlobalRightMouseClickOnElementsearchElementJABName);
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalRightMouseClickOnElementsearchElementJABDescription != null)
                {
                    jABGlobalRightMouseClickOnElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABGlobalRightMouseClickOnElementsearchElementJABDescription);
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalRightMouseClickOnElementsearchElementJABRole != null)
                {
                    jABGlobalRightMouseClickOnElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABGlobalRightMouseClickOnElementsearchElementJABRole);
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalRightMouseClickOnElementsearchSubTree != null)
                {
                    if (__workflow_jABGlobalRightMouseClickOnElementsearchSubTree != null)
                    {
                        jABGlobalRightMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABGlobalRightMouseClickOnElementsearchSubTree);
                        jABGlobalRightMouseClickOnElementpropCount++;
                    }

                    jABGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalRightMouseClickOnElement["SearchSubTree"] = true;
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalRightMouseClickOnElementmaxRelativeDepth != null)
                {
                    if (__workflow_jABGlobalRightMouseClickOnElementmaxRelativeDepth != null)
                    {
                        jABGlobalRightMouseClickOnElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABGlobalRightMouseClickOnElementmaxRelativeDepth);
                        jABGlobalRightMouseClickOnElementpropCount++;
                    }

                    jABGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalRightMouseClickOnElement["MaxRelativeDepth"] = 0;
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalRightMouseClickOnElementmatchIndex != null)
                {
                    if (__workflow_jABGlobalRightMouseClickOnElementmatchIndex != null)
                    {
                        jABGlobalRightMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABGlobalRightMouseClickOnElementmatchIndex);
                        jABGlobalRightMouseClickOnElementpropCount++;
                    }

                    jABGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalRightMouseClickOnElement["MatchIndex"] = 1;
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalRightMouseClickOnElementsearchFilter != null)
                {
                    jABGlobalRightMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABGlobalRightMouseClickOnElementsearchFilter);
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalRightMouseClickOnElementsortByColumn != null)
                {
                    jABGlobalRightMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABGlobalRightMouseClickOnElementsortByColumn);
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalRightMouseClickOnElementmatchIndexAscending != null)
                {
                    if (__workflow_jABGlobalRightMouseClickOnElementmatchIndexAscending != null)
                    {
                        jABGlobalRightMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABGlobalRightMouseClickOnElementmatchIndexAscending);
                        jABGlobalRightMouseClickOnElementpropCount++;
                    }

                    jABGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalRightMouseClickOnElement["MatchIndexAscending"] = true;
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalRightMouseClickOnElementcaseSensitiveSearch != null)
                {
                    if (__workflow_jABGlobalRightMouseClickOnElementcaseSensitiveSearch != null)
                    {
                        jABGlobalRightMouseClickOnElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABGlobalRightMouseClickOnElementcaseSensitiveSearch);
                        jABGlobalRightMouseClickOnElementpropCount++;
                    }

                    jABGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalRightMouseClickOnElement["CaseSensitiveSearch"] = false;
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalRightMouseClickOnElementonlySearchVisibleElements != null)
                {
                    if (__workflow_jABGlobalRightMouseClickOnElementonlySearchVisibleElements != null)
                    {
                        jABGlobalRightMouseClickOnElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABGlobalRightMouseClickOnElementonlySearchVisibleElements);
                        jABGlobalRightMouseClickOnElementpropCount++;
                    }

                    jABGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalRightMouseClickOnElement["OnlySearchVisibleElements"] = true;
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalRightMouseClickOnElementonlySearchShowingElements != null)
                {
                    if (__workflow_jABGlobalRightMouseClickOnElementonlySearchShowingElements != null)
                    {
                        jABGlobalRightMouseClickOnElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABGlobalRightMouseClickOnElementonlySearchShowingElements);
                        jABGlobalRightMouseClickOnElementpropCount++;
                    }

                    jABGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalRightMouseClickOnElement["OnlySearchShowingElements"] = true;
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalRightMouseClickOnElementelementRolesNotToTraverse != null)
                {
                    jABGlobalRightMouseClickOnElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABGlobalRightMouseClickOnElementelementRolesNotToTraverse);
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalRightMouseClickOnElementmaximumElementsToSearch != null)
                {
                    if (__workflow_jABGlobalRightMouseClickOnElementmaximumElementsToSearch != null)
                    {
                        jABGlobalRightMouseClickOnElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABGlobalRightMouseClickOnElementmaximumElementsToSearch);
                        jABGlobalRightMouseClickOnElementpropCount++;
                    }

                    jABGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalRightMouseClickOnElement["MaximumElementsToSearch"] = 2000;
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalRightMouseClickOnElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABGlobalRightMouseClickOnElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGlobalRightMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABGlobalRightMouseClickOnElementmaximumChildElementsToSearchPerNode);
                        jABGlobalRightMouseClickOnElementpropCount++;
                    }

                    jABGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalRightMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalRightMouseClickOnElementclickOffsetX != null)
                {
                    if (__workflow_jABGlobalRightMouseClickOnElementclickOffsetX != null)
                    {
                        jABGlobalRightMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(__workflow_jABGlobalRightMouseClickOnElementclickOffsetX);
                        jABGlobalRightMouseClickOnElementpropCount++;
                    }

                    jABGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalRightMouseClickOnElement["ClickOffsetX"] = 0;
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalRightMouseClickOnElementclickOffsetY != null)
                {
                    if (__workflow_jABGlobalRightMouseClickOnElementclickOffsetY != null)
                    {
                        jABGlobalRightMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(__workflow_jABGlobalRightMouseClickOnElementclickOffsetY);
                        jABGlobalRightMouseClickOnElementpropCount++;
                    }

                    jABGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalRightMouseClickOnElement["ClickOffsetY"] = 0;
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalRightMouseClickOnElementoffsetRelativeTo != null)
                {
                    jABGlobalRightMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(__workflow_jABGlobalRightMouseClickOnElementoffsetRelativeTo);
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                jABGlobalRightMouseClickOnElementpropCount++;
                jABGlobalRightMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGlobalRightMouseClickOnElementworkflow);
                if (jABGlobalRightMouseClickOnElementpropCount > 0)
                {
                    callPayload.Body = jABGlobalRightMouseClickOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalMiddleMouseClickOnElement(Expression<Func<int>> jABGlobalMiddleMouseClickOnElementsearchParentElementJABHandle, Expression<Func<string>> jABGlobalMiddleMouseClickOnElementworkflow, Expression<Func<string>> jABGlobalMiddleMouseClickOnElementsearchElementJABName = null, Expression<Func<string>> jABGlobalMiddleMouseClickOnElementsearchElementJABDescription = null, Expression<Func<string>> jABGlobalMiddleMouseClickOnElementsearchElementJABRole = null, Expression<Func<bool>> jABGlobalMiddleMouseClickOnElementsearchSubTree = null, Expression<Func<int>> jABGlobalMiddleMouseClickOnElementmaxRelativeDepth = null, Expression<Func<int>> jABGlobalMiddleMouseClickOnElementmatchIndex = null, Expression<Func<string>> jABGlobalMiddleMouseClickOnElementsearchFilter = null, Expression<Func<string>> jABGlobalMiddleMouseClickOnElementsortByColumn = null, Expression<Func<bool>> jABGlobalMiddleMouseClickOnElementmatchIndexAscending = null, Expression<Func<bool>> jABGlobalMiddleMouseClickOnElementcaseSensitiveSearch = null, Expression<Func<bool>> jABGlobalMiddleMouseClickOnElementonlySearchVisibleElements = null, Expression<Func<bool>> jABGlobalMiddleMouseClickOnElementonlySearchShowingElements = null, Expression<Func<string>> jABGlobalMiddleMouseClickOnElementelementRolesNotToTraverse = null, Expression<Func<int>> jABGlobalMiddleMouseClickOnElementmaximumElementsToSearch = null, Expression<Func<int>> jABGlobalMiddleMouseClickOnElementmaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABGlobalMiddleMouseClickOnElementclickOffsetX = null, Expression<Func<int>> jABGlobalMiddleMouseClickOnElementclickOffsetY = null, Expression<Func<jABGlobalMiddleMouseClickOnElementoffsetRelativeToInput>> jABGlobalMiddleMouseClickOnElementoffsetRelativeTo = null)
        {
            var __workflow_jABGlobalMiddleMouseClickOnElementsearchParentElementJABHandle = WorkflowExpression.Compile(jABGlobalMiddleMouseClickOnElementsearchParentElementJABHandle, nameof(jABGlobalMiddleMouseClickOnElementsearchParentElementJABHandle), required: true);
            var __workflow_jABGlobalMiddleMouseClickOnElementworkflow = WorkflowExpression.Compile(jABGlobalMiddleMouseClickOnElementworkflow, nameof(jABGlobalMiddleMouseClickOnElementworkflow), required: true);
            var __workflow_jABGlobalMiddleMouseClickOnElementsearchElementJABName = WorkflowExpression.Compile(jABGlobalMiddleMouseClickOnElementsearchElementJABName, nameof(jABGlobalMiddleMouseClickOnElementsearchElementJABName), required: false);
            var __workflow_jABGlobalMiddleMouseClickOnElementsearchElementJABDescription = WorkflowExpression.Compile(jABGlobalMiddleMouseClickOnElementsearchElementJABDescription, nameof(jABGlobalMiddleMouseClickOnElementsearchElementJABDescription), required: false);
            var __workflow_jABGlobalMiddleMouseClickOnElementsearchElementJABRole = WorkflowExpression.Compile(jABGlobalMiddleMouseClickOnElementsearchElementJABRole, nameof(jABGlobalMiddleMouseClickOnElementsearchElementJABRole), required: false);
            var __workflow_jABGlobalMiddleMouseClickOnElementsearchSubTree = WorkflowExpression.Compile(jABGlobalMiddleMouseClickOnElementsearchSubTree, nameof(jABGlobalMiddleMouseClickOnElementsearchSubTree), required: false);
            var __workflow_jABGlobalMiddleMouseClickOnElementmaxRelativeDepth = WorkflowExpression.Compile(jABGlobalMiddleMouseClickOnElementmaxRelativeDepth, nameof(jABGlobalMiddleMouseClickOnElementmaxRelativeDepth), required: false);
            var __workflow_jABGlobalMiddleMouseClickOnElementmatchIndex = WorkflowExpression.Compile(jABGlobalMiddleMouseClickOnElementmatchIndex, nameof(jABGlobalMiddleMouseClickOnElementmatchIndex), required: false);
            var __workflow_jABGlobalMiddleMouseClickOnElementsearchFilter = WorkflowExpression.Compile(jABGlobalMiddleMouseClickOnElementsearchFilter, nameof(jABGlobalMiddleMouseClickOnElementsearchFilter), required: false);
            var __workflow_jABGlobalMiddleMouseClickOnElementsortByColumn = WorkflowExpression.Compile(jABGlobalMiddleMouseClickOnElementsortByColumn, nameof(jABGlobalMiddleMouseClickOnElementsortByColumn), required: false);
            var __workflow_jABGlobalMiddleMouseClickOnElementmatchIndexAscending = WorkflowExpression.Compile(jABGlobalMiddleMouseClickOnElementmatchIndexAscending, nameof(jABGlobalMiddleMouseClickOnElementmatchIndexAscending), required: false);
            var __workflow_jABGlobalMiddleMouseClickOnElementcaseSensitiveSearch = WorkflowExpression.Compile(jABGlobalMiddleMouseClickOnElementcaseSensitiveSearch, nameof(jABGlobalMiddleMouseClickOnElementcaseSensitiveSearch), required: false);
            var __workflow_jABGlobalMiddleMouseClickOnElementonlySearchVisibleElements = WorkflowExpression.Compile(jABGlobalMiddleMouseClickOnElementonlySearchVisibleElements, nameof(jABGlobalMiddleMouseClickOnElementonlySearchVisibleElements), required: false);
            var __workflow_jABGlobalMiddleMouseClickOnElementonlySearchShowingElements = WorkflowExpression.Compile(jABGlobalMiddleMouseClickOnElementonlySearchShowingElements, nameof(jABGlobalMiddleMouseClickOnElementonlySearchShowingElements), required: false);
            var __workflow_jABGlobalMiddleMouseClickOnElementelementRolesNotToTraverse = WorkflowExpression.Compile(jABGlobalMiddleMouseClickOnElementelementRolesNotToTraverse, nameof(jABGlobalMiddleMouseClickOnElementelementRolesNotToTraverse), required: false);
            var __workflow_jABGlobalMiddleMouseClickOnElementmaximumElementsToSearch = WorkflowExpression.Compile(jABGlobalMiddleMouseClickOnElementmaximumElementsToSearch, nameof(jABGlobalMiddleMouseClickOnElementmaximumElementsToSearch), required: false);
            var __workflow_jABGlobalMiddleMouseClickOnElementmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABGlobalMiddleMouseClickOnElementmaximumChildElementsToSearchPerNode, nameof(jABGlobalMiddleMouseClickOnElementmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABGlobalMiddleMouseClickOnElementclickOffsetX = WorkflowExpression.Compile(jABGlobalMiddleMouseClickOnElementclickOffsetX, nameof(jABGlobalMiddleMouseClickOnElementclickOffsetX), required: false);
            var __workflow_jABGlobalMiddleMouseClickOnElementclickOffsetY = WorkflowExpression.Compile(jABGlobalMiddleMouseClickOnElementclickOffsetY, nameof(jABGlobalMiddleMouseClickOnElementclickOffsetY), required: false);
            var __workflow_jABGlobalMiddleMouseClickOnElementoffsetRelativeTo = WorkflowExpression.Compile(jABGlobalMiddleMouseClickOnElementoffsetRelativeTo, nameof(jABGlobalMiddleMouseClickOnElementoffsetRelativeTo), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalMiddleMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGlobalMiddleMouseClickOnElement = new JObject();
                var jABGlobalMiddleMouseClickOnElementpropCount = 0;
                jABGlobalMiddleMouseClickOnElementpropCount++;
                jABGlobalMiddleMouseClickOnElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMiddleMouseClickOnElementsearchParentElementJABHandle);
                if (__workflow_jABGlobalMiddleMouseClickOnElementsearchElementJABName != null)
                {
                    jABGlobalMiddleMouseClickOnElement["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMiddleMouseClickOnElementsearchElementJABName);
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalMiddleMouseClickOnElementsearchElementJABDescription != null)
                {
                    jABGlobalMiddleMouseClickOnElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMiddleMouseClickOnElementsearchElementJABDescription);
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalMiddleMouseClickOnElementsearchElementJABRole != null)
                {
                    jABGlobalMiddleMouseClickOnElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMiddleMouseClickOnElementsearchElementJABRole);
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalMiddleMouseClickOnElementsearchSubTree != null)
                {
                    if (__workflow_jABGlobalMiddleMouseClickOnElementsearchSubTree != null)
                    {
                        jABGlobalMiddleMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMiddleMouseClickOnElementsearchSubTree);
                        jABGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalMiddleMouseClickOnElement["SearchSubTree"] = true;
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalMiddleMouseClickOnElementmaxRelativeDepth != null)
                {
                    if (__workflow_jABGlobalMiddleMouseClickOnElementmaxRelativeDepth != null)
                    {
                        jABGlobalMiddleMouseClickOnElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMiddleMouseClickOnElementmaxRelativeDepth);
                        jABGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalMiddleMouseClickOnElement["MaxRelativeDepth"] = 0;
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalMiddleMouseClickOnElementmatchIndex != null)
                {
                    if (__workflow_jABGlobalMiddleMouseClickOnElementmatchIndex != null)
                    {
                        jABGlobalMiddleMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMiddleMouseClickOnElementmatchIndex);
                        jABGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalMiddleMouseClickOnElement["MatchIndex"] = 1;
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalMiddleMouseClickOnElementsearchFilter != null)
                {
                    jABGlobalMiddleMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMiddleMouseClickOnElementsearchFilter);
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalMiddleMouseClickOnElementsortByColumn != null)
                {
                    jABGlobalMiddleMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMiddleMouseClickOnElementsortByColumn);
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalMiddleMouseClickOnElementmatchIndexAscending != null)
                {
                    if (__workflow_jABGlobalMiddleMouseClickOnElementmatchIndexAscending != null)
                    {
                        jABGlobalMiddleMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMiddleMouseClickOnElementmatchIndexAscending);
                        jABGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalMiddleMouseClickOnElement["MatchIndexAscending"] = true;
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalMiddleMouseClickOnElementcaseSensitiveSearch != null)
                {
                    if (__workflow_jABGlobalMiddleMouseClickOnElementcaseSensitiveSearch != null)
                    {
                        jABGlobalMiddleMouseClickOnElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMiddleMouseClickOnElementcaseSensitiveSearch);
                        jABGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalMiddleMouseClickOnElement["CaseSensitiveSearch"] = false;
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalMiddleMouseClickOnElementonlySearchVisibleElements != null)
                {
                    if (__workflow_jABGlobalMiddleMouseClickOnElementonlySearchVisibleElements != null)
                    {
                        jABGlobalMiddleMouseClickOnElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMiddleMouseClickOnElementonlySearchVisibleElements);
                        jABGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalMiddleMouseClickOnElement["OnlySearchVisibleElements"] = true;
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalMiddleMouseClickOnElementonlySearchShowingElements != null)
                {
                    if (__workflow_jABGlobalMiddleMouseClickOnElementonlySearchShowingElements != null)
                    {
                        jABGlobalMiddleMouseClickOnElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMiddleMouseClickOnElementonlySearchShowingElements);
                        jABGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalMiddleMouseClickOnElement["OnlySearchShowingElements"] = true;
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalMiddleMouseClickOnElementelementRolesNotToTraverse != null)
                {
                    jABGlobalMiddleMouseClickOnElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMiddleMouseClickOnElementelementRolesNotToTraverse);
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalMiddleMouseClickOnElementmaximumElementsToSearch != null)
                {
                    if (__workflow_jABGlobalMiddleMouseClickOnElementmaximumElementsToSearch != null)
                    {
                        jABGlobalMiddleMouseClickOnElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMiddleMouseClickOnElementmaximumElementsToSearch);
                        jABGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalMiddleMouseClickOnElement["MaximumElementsToSearch"] = 2000;
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalMiddleMouseClickOnElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABGlobalMiddleMouseClickOnElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGlobalMiddleMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMiddleMouseClickOnElementmaximumChildElementsToSearchPerNode);
                        jABGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalMiddleMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalMiddleMouseClickOnElementclickOffsetX != null)
                {
                    if (__workflow_jABGlobalMiddleMouseClickOnElementclickOffsetX != null)
                    {
                        jABGlobalMiddleMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMiddleMouseClickOnElementclickOffsetX);
                        jABGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalMiddleMouseClickOnElement["ClickOffsetX"] = 0;
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalMiddleMouseClickOnElementclickOffsetY != null)
                {
                    if (__workflow_jABGlobalMiddleMouseClickOnElementclickOffsetY != null)
                    {
                        jABGlobalMiddleMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMiddleMouseClickOnElementclickOffsetY);
                        jABGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalMiddleMouseClickOnElement["ClickOffsetY"] = 0;
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalMiddleMouseClickOnElementoffsetRelativeTo != null)
                {
                    jABGlobalMiddleMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMiddleMouseClickOnElementoffsetRelativeTo);
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                jABGlobalMiddleMouseClickOnElementpropCount++;
                jABGlobalMiddleMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMiddleMouseClickOnElementworkflow);
                if (jABGlobalMiddleMouseClickOnElementpropCount > 0)
                {
                    callPayload.Body = jABGlobalMiddleMouseClickOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalDoubleLeftMouseClickOnElement(Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementsearchParentElementJABHandle, Expression<Func<string>> jABGlobalDoubleLeftMouseClickOnElementworkflow, Expression<Func<string>> jABGlobalDoubleLeftMouseClickOnElementsearchElementJABName = null, Expression<Func<string>> jABGlobalDoubleLeftMouseClickOnElementsearchElementJABDescription = null, Expression<Func<string>> jABGlobalDoubleLeftMouseClickOnElementsearchElementJABRole = null, Expression<Func<bool>> jABGlobalDoubleLeftMouseClickOnElementsearchSubTree = null, Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementmaxRelativeDepth = null, Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementmatchIndex = null, Expression<Func<string>> jABGlobalDoubleLeftMouseClickOnElementsearchFilter = null, Expression<Func<string>> jABGlobalDoubleLeftMouseClickOnElementsortByColumn = null, Expression<Func<bool>> jABGlobalDoubleLeftMouseClickOnElementmatchIndexAscending = null, Expression<Func<bool>> jABGlobalDoubleLeftMouseClickOnElementcaseSensitiveSearch = null, Expression<Func<bool>> jABGlobalDoubleLeftMouseClickOnElementonlySearchVisibleElements = null, Expression<Func<bool>> jABGlobalDoubleLeftMouseClickOnElementonlySearchShowingElements = null, Expression<Func<string>> jABGlobalDoubleLeftMouseClickOnElementelementRolesNotToTraverse = null, Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementmaximumElementsToSearch = null, Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementmaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementclickOffsetX = null, Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementclickOffsetY = null, Expression<Func<jABGlobalDoubleLeftMouseClickOnElementoffsetRelativeToInput>> jABGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo = null, Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds = null)
        {
            var __workflow_jABGlobalDoubleLeftMouseClickOnElementsearchParentElementJABHandle = WorkflowExpression.Compile(jABGlobalDoubleLeftMouseClickOnElementsearchParentElementJABHandle, nameof(jABGlobalDoubleLeftMouseClickOnElementsearchParentElementJABHandle), required: true);
            var __workflow_jABGlobalDoubleLeftMouseClickOnElementworkflow = WorkflowExpression.Compile(jABGlobalDoubleLeftMouseClickOnElementworkflow, nameof(jABGlobalDoubleLeftMouseClickOnElementworkflow), required: true);
            var __workflow_jABGlobalDoubleLeftMouseClickOnElementsearchElementJABName = WorkflowExpression.Compile(jABGlobalDoubleLeftMouseClickOnElementsearchElementJABName, nameof(jABGlobalDoubleLeftMouseClickOnElementsearchElementJABName), required: false);
            var __workflow_jABGlobalDoubleLeftMouseClickOnElementsearchElementJABDescription = WorkflowExpression.Compile(jABGlobalDoubleLeftMouseClickOnElementsearchElementJABDescription, nameof(jABGlobalDoubleLeftMouseClickOnElementsearchElementJABDescription), required: false);
            var __workflow_jABGlobalDoubleLeftMouseClickOnElementsearchElementJABRole = WorkflowExpression.Compile(jABGlobalDoubleLeftMouseClickOnElementsearchElementJABRole, nameof(jABGlobalDoubleLeftMouseClickOnElementsearchElementJABRole), required: false);
            var __workflow_jABGlobalDoubleLeftMouseClickOnElementsearchSubTree = WorkflowExpression.Compile(jABGlobalDoubleLeftMouseClickOnElementsearchSubTree, nameof(jABGlobalDoubleLeftMouseClickOnElementsearchSubTree), required: false);
            var __workflow_jABGlobalDoubleLeftMouseClickOnElementmaxRelativeDepth = WorkflowExpression.Compile(jABGlobalDoubleLeftMouseClickOnElementmaxRelativeDepth, nameof(jABGlobalDoubleLeftMouseClickOnElementmaxRelativeDepth), required: false);
            var __workflow_jABGlobalDoubleLeftMouseClickOnElementmatchIndex = WorkflowExpression.Compile(jABGlobalDoubleLeftMouseClickOnElementmatchIndex, nameof(jABGlobalDoubleLeftMouseClickOnElementmatchIndex), required: false);
            var __workflow_jABGlobalDoubleLeftMouseClickOnElementsearchFilter = WorkflowExpression.Compile(jABGlobalDoubleLeftMouseClickOnElementsearchFilter, nameof(jABGlobalDoubleLeftMouseClickOnElementsearchFilter), required: false);
            var __workflow_jABGlobalDoubleLeftMouseClickOnElementsortByColumn = WorkflowExpression.Compile(jABGlobalDoubleLeftMouseClickOnElementsortByColumn, nameof(jABGlobalDoubleLeftMouseClickOnElementsortByColumn), required: false);
            var __workflow_jABGlobalDoubleLeftMouseClickOnElementmatchIndexAscending = WorkflowExpression.Compile(jABGlobalDoubleLeftMouseClickOnElementmatchIndexAscending, nameof(jABGlobalDoubleLeftMouseClickOnElementmatchIndexAscending), required: false);
            var __workflow_jABGlobalDoubleLeftMouseClickOnElementcaseSensitiveSearch = WorkflowExpression.Compile(jABGlobalDoubleLeftMouseClickOnElementcaseSensitiveSearch, nameof(jABGlobalDoubleLeftMouseClickOnElementcaseSensitiveSearch), required: false);
            var __workflow_jABGlobalDoubleLeftMouseClickOnElementonlySearchVisibleElements = WorkflowExpression.Compile(jABGlobalDoubleLeftMouseClickOnElementonlySearchVisibleElements, nameof(jABGlobalDoubleLeftMouseClickOnElementonlySearchVisibleElements), required: false);
            var __workflow_jABGlobalDoubleLeftMouseClickOnElementonlySearchShowingElements = WorkflowExpression.Compile(jABGlobalDoubleLeftMouseClickOnElementonlySearchShowingElements, nameof(jABGlobalDoubleLeftMouseClickOnElementonlySearchShowingElements), required: false);
            var __workflow_jABGlobalDoubleLeftMouseClickOnElementelementRolesNotToTraverse = WorkflowExpression.Compile(jABGlobalDoubleLeftMouseClickOnElementelementRolesNotToTraverse, nameof(jABGlobalDoubleLeftMouseClickOnElementelementRolesNotToTraverse), required: false);
            var __workflow_jABGlobalDoubleLeftMouseClickOnElementmaximumElementsToSearch = WorkflowExpression.Compile(jABGlobalDoubleLeftMouseClickOnElementmaximumElementsToSearch, nameof(jABGlobalDoubleLeftMouseClickOnElementmaximumElementsToSearch), required: false);
            var __workflow_jABGlobalDoubleLeftMouseClickOnElementmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABGlobalDoubleLeftMouseClickOnElementmaximumChildElementsToSearchPerNode, nameof(jABGlobalDoubleLeftMouseClickOnElementmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABGlobalDoubleLeftMouseClickOnElementclickOffsetX = WorkflowExpression.Compile(jABGlobalDoubleLeftMouseClickOnElementclickOffsetX, nameof(jABGlobalDoubleLeftMouseClickOnElementclickOffsetX), required: false);
            var __workflow_jABGlobalDoubleLeftMouseClickOnElementclickOffsetY = WorkflowExpression.Compile(jABGlobalDoubleLeftMouseClickOnElementclickOffsetY, nameof(jABGlobalDoubleLeftMouseClickOnElementclickOffsetY), required: false);
            var __workflow_jABGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo = WorkflowExpression.Compile(jABGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo, nameof(jABGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo), required: false);
            var __workflow_jABGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds = WorkflowExpression.Compile(jABGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds, nameof(jABGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalDoubleLeftMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGlobalDoubleLeftMouseClickOnElement = new JObject();
                var jABGlobalDoubleLeftMouseClickOnElementpropCount = 0;
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                jABGlobalDoubleLeftMouseClickOnElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGlobalDoubleLeftMouseClickOnElementsearchParentElementJABHandle);
                if (__workflow_jABGlobalDoubleLeftMouseClickOnElementsearchElementJABName != null)
                {
                    jABGlobalDoubleLeftMouseClickOnElement["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABGlobalDoubleLeftMouseClickOnElementsearchElementJABName);
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalDoubleLeftMouseClickOnElementsearchElementJABDescription != null)
                {
                    jABGlobalDoubleLeftMouseClickOnElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABGlobalDoubleLeftMouseClickOnElementsearchElementJABDescription);
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalDoubleLeftMouseClickOnElementsearchElementJABRole != null)
                {
                    jABGlobalDoubleLeftMouseClickOnElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABGlobalDoubleLeftMouseClickOnElementsearchElementJABRole);
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalDoubleLeftMouseClickOnElementsearchSubTree != null)
                {
                    if (__workflow_jABGlobalDoubleLeftMouseClickOnElementsearchSubTree != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABGlobalDoubleLeftMouseClickOnElementsearchSubTree);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["SearchSubTree"] = true;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalDoubleLeftMouseClickOnElementmaxRelativeDepth != null)
                {
                    if (__workflow_jABGlobalDoubleLeftMouseClickOnElementmaxRelativeDepth != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABGlobalDoubleLeftMouseClickOnElementmaxRelativeDepth);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["MaxRelativeDepth"] = 0;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalDoubleLeftMouseClickOnElementmatchIndex != null)
                {
                    if (__workflow_jABGlobalDoubleLeftMouseClickOnElementmatchIndex != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABGlobalDoubleLeftMouseClickOnElementmatchIndex);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["MatchIndex"] = 1;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalDoubleLeftMouseClickOnElementsearchFilter != null)
                {
                    jABGlobalDoubleLeftMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABGlobalDoubleLeftMouseClickOnElementsearchFilter);
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalDoubleLeftMouseClickOnElementsortByColumn != null)
                {
                    jABGlobalDoubleLeftMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABGlobalDoubleLeftMouseClickOnElementsortByColumn);
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalDoubleLeftMouseClickOnElementmatchIndexAscending != null)
                {
                    if (__workflow_jABGlobalDoubleLeftMouseClickOnElementmatchIndexAscending != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABGlobalDoubleLeftMouseClickOnElementmatchIndexAscending);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["MatchIndexAscending"] = true;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalDoubleLeftMouseClickOnElementcaseSensitiveSearch != null)
                {
                    if (__workflow_jABGlobalDoubleLeftMouseClickOnElementcaseSensitiveSearch != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABGlobalDoubleLeftMouseClickOnElementcaseSensitiveSearch);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["CaseSensitiveSearch"] = false;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalDoubleLeftMouseClickOnElementonlySearchVisibleElements != null)
                {
                    if (__workflow_jABGlobalDoubleLeftMouseClickOnElementonlySearchVisibleElements != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABGlobalDoubleLeftMouseClickOnElementonlySearchVisibleElements);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["OnlySearchVisibleElements"] = true;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalDoubleLeftMouseClickOnElementonlySearchShowingElements != null)
                {
                    if (__workflow_jABGlobalDoubleLeftMouseClickOnElementonlySearchShowingElements != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABGlobalDoubleLeftMouseClickOnElementonlySearchShowingElements);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["OnlySearchShowingElements"] = true;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalDoubleLeftMouseClickOnElementelementRolesNotToTraverse != null)
                {
                    jABGlobalDoubleLeftMouseClickOnElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABGlobalDoubleLeftMouseClickOnElementelementRolesNotToTraverse);
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalDoubleLeftMouseClickOnElementmaximumElementsToSearch != null)
                {
                    if (__workflow_jABGlobalDoubleLeftMouseClickOnElementmaximumElementsToSearch != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABGlobalDoubleLeftMouseClickOnElementmaximumElementsToSearch);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["MaximumElementsToSearch"] = 2000;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalDoubleLeftMouseClickOnElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABGlobalDoubleLeftMouseClickOnElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABGlobalDoubleLeftMouseClickOnElementmaximumChildElementsToSearchPerNode);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalDoubleLeftMouseClickOnElementclickOffsetX != null)
                {
                    if (__workflow_jABGlobalDoubleLeftMouseClickOnElementclickOffsetX != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(__workflow_jABGlobalDoubleLeftMouseClickOnElementclickOffsetX);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["ClickOffsetX"] = 0;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalDoubleLeftMouseClickOnElementclickOffsetY != null)
                {
                    if (__workflow_jABGlobalDoubleLeftMouseClickOnElementclickOffsetY != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(__workflow_jABGlobalDoubleLeftMouseClickOnElementclickOffsetY);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["ClickOffsetY"] = 0;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo != null)
                {
                    jABGlobalDoubleLeftMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(__workflow_jABGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo);
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_jABGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds != null)
                {
                    if (__workflow_jABGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["DelayInMilliseconds"] = ExpressionConverter.ConvertO(__workflow_jABGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["DelayInMilliseconds"] = 10;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                jABGlobalDoubleLeftMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGlobalDoubleLeftMouseClickOnElementworkflow);
                if (jABGlobalDoubleLeftMouseClickOnElementpropCount > 0)
                {
                    callPayload.Body = jABGlobalDoubleLeftMouseClickOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetActionsForElementResponse> JABGetActionsForElement(Expression<Func<int>> jABGetActionsForElementsearchParentElementJABHandle, Expression<Func<string>> jABGetActionsForElementworkflow, Expression<Func<string>> jABGetActionsForElementsearchElementJABName = null, Expression<Func<string>> jABGetActionsForElementsearchElementJABDescription = null, Expression<Func<string>> jABGetActionsForElementsearchElementJABRole = null, Expression<Func<bool>> jABGetActionsForElementsearchSubTree = null, Expression<Func<int>> jABGetActionsForElementmaxRelativeDepth = null, Expression<Func<int>> jABGetActionsForElementmatchIndex = null, Expression<Func<string>> jABGetActionsForElementsearchFilter = null, Expression<Func<string>> jABGetActionsForElementsortByColumn = null, Expression<Func<bool>> jABGetActionsForElementmatchIndexAscending = null, Expression<Func<bool>> jABGetActionsForElementcaseSensitiveSearch = null, Expression<Func<bool>> jABGetActionsForElementonlySearchVisibleElements = null, Expression<Func<bool>> jABGetActionsForElementonlySearchShowingElements = null, Expression<Func<string>> jABGetActionsForElementelementRolesNotToTraverse = null, Expression<Func<int>> jABGetActionsForElementmaximumElementsToSearch = null, Expression<Func<int>> jABGetActionsForElementmaximumChildElementsToSearchPerNode = null)
        {
            var __workflow_jABGetActionsForElementsearchParentElementJABHandle = WorkflowExpression.Compile(jABGetActionsForElementsearchParentElementJABHandle, nameof(jABGetActionsForElementsearchParentElementJABHandle), required: true);
            var __workflow_jABGetActionsForElementworkflow = WorkflowExpression.Compile(jABGetActionsForElementworkflow, nameof(jABGetActionsForElementworkflow), required: true);
            var __workflow_jABGetActionsForElementsearchElementJABName = WorkflowExpression.Compile(jABGetActionsForElementsearchElementJABName, nameof(jABGetActionsForElementsearchElementJABName), required: false);
            var __workflow_jABGetActionsForElementsearchElementJABDescription = WorkflowExpression.Compile(jABGetActionsForElementsearchElementJABDescription, nameof(jABGetActionsForElementsearchElementJABDescription), required: false);
            var __workflow_jABGetActionsForElementsearchElementJABRole = WorkflowExpression.Compile(jABGetActionsForElementsearchElementJABRole, nameof(jABGetActionsForElementsearchElementJABRole), required: false);
            var __workflow_jABGetActionsForElementsearchSubTree = WorkflowExpression.Compile(jABGetActionsForElementsearchSubTree, nameof(jABGetActionsForElementsearchSubTree), required: false);
            var __workflow_jABGetActionsForElementmaxRelativeDepth = WorkflowExpression.Compile(jABGetActionsForElementmaxRelativeDepth, nameof(jABGetActionsForElementmaxRelativeDepth), required: false);
            var __workflow_jABGetActionsForElementmatchIndex = WorkflowExpression.Compile(jABGetActionsForElementmatchIndex, nameof(jABGetActionsForElementmatchIndex), required: false);
            var __workflow_jABGetActionsForElementsearchFilter = WorkflowExpression.Compile(jABGetActionsForElementsearchFilter, nameof(jABGetActionsForElementsearchFilter), required: false);
            var __workflow_jABGetActionsForElementsortByColumn = WorkflowExpression.Compile(jABGetActionsForElementsortByColumn, nameof(jABGetActionsForElementsortByColumn), required: false);
            var __workflow_jABGetActionsForElementmatchIndexAscending = WorkflowExpression.Compile(jABGetActionsForElementmatchIndexAscending, nameof(jABGetActionsForElementmatchIndexAscending), required: false);
            var __workflow_jABGetActionsForElementcaseSensitiveSearch = WorkflowExpression.Compile(jABGetActionsForElementcaseSensitiveSearch, nameof(jABGetActionsForElementcaseSensitiveSearch), required: false);
            var __workflow_jABGetActionsForElementonlySearchVisibleElements = WorkflowExpression.Compile(jABGetActionsForElementonlySearchVisibleElements, nameof(jABGetActionsForElementonlySearchVisibleElements), required: false);
            var __workflow_jABGetActionsForElementonlySearchShowingElements = WorkflowExpression.Compile(jABGetActionsForElementonlySearchShowingElements, nameof(jABGetActionsForElementonlySearchShowingElements), required: false);
            var __workflow_jABGetActionsForElementelementRolesNotToTraverse = WorkflowExpression.Compile(jABGetActionsForElementelementRolesNotToTraverse, nameof(jABGetActionsForElementelementRolesNotToTraverse), required: false);
            var __workflow_jABGetActionsForElementmaximumElementsToSearch = WorkflowExpression.Compile(jABGetActionsForElementmaximumElementsToSearch, nameof(jABGetActionsForElementmaximumElementsToSearch), required: false);
            var __workflow_jABGetActionsForElementmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABGetActionsForElementmaximumChildElementsToSearchPerNode, nameof(jABGetActionsForElementmaximumChildElementsToSearchPerNode), required: false);
            return new DeferredBodyAction<JABGetActionsForElementResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetActionsForElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetActionsForElement = new JObject();
                var jABGetActionsForElementpropCount = 0;
                jABGetActionsForElementpropCount++;
                jABGetActionsForElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGetActionsForElementsearchParentElementJABHandle);
                if (__workflow_jABGetActionsForElementsearchElementJABName != null)
                {
                    jABGetActionsForElement["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABGetActionsForElementsearchElementJABName);
                    jABGetActionsForElementpropCount++;
                }

                if (__workflow_jABGetActionsForElementsearchElementJABDescription != null)
                {
                    jABGetActionsForElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABGetActionsForElementsearchElementJABDescription);
                    jABGetActionsForElementpropCount++;
                }

                if (__workflow_jABGetActionsForElementsearchElementJABRole != null)
                {
                    jABGetActionsForElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABGetActionsForElementsearchElementJABRole);
                    jABGetActionsForElementpropCount++;
                }

                if (__workflow_jABGetActionsForElementsearchSubTree != null)
                {
                    if (__workflow_jABGetActionsForElementsearchSubTree != null)
                    {
                        jABGetActionsForElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABGetActionsForElementsearchSubTree);
                        jABGetActionsForElementpropCount++;
                    }

                    jABGetActionsForElementpropCount++;
                }
                else
                {
                    jABGetActionsForElement["SearchSubTree"] = true;
                    jABGetActionsForElementpropCount++;
                }

                if (__workflow_jABGetActionsForElementmaxRelativeDepth != null)
                {
                    if (__workflow_jABGetActionsForElementmaxRelativeDepth != null)
                    {
                        jABGetActionsForElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABGetActionsForElementmaxRelativeDepth);
                        jABGetActionsForElementpropCount++;
                    }

                    jABGetActionsForElementpropCount++;
                }
                else
                {
                    jABGetActionsForElement["MaxRelativeDepth"] = 0;
                    jABGetActionsForElementpropCount++;
                }

                if (__workflow_jABGetActionsForElementmatchIndex != null)
                {
                    if (__workflow_jABGetActionsForElementmatchIndex != null)
                    {
                        jABGetActionsForElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABGetActionsForElementmatchIndex);
                        jABGetActionsForElementpropCount++;
                    }

                    jABGetActionsForElementpropCount++;
                }
                else
                {
                    jABGetActionsForElement["MatchIndex"] = 1;
                    jABGetActionsForElementpropCount++;
                }

                if (__workflow_jABGetActionsForElementsearchFilter != null)
                {
                    jABGetActionsForElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABGetActionsForElementsearchFilter);
                    jABGetActionsForElementpropCount++;
                }

                if (__workflow_jABGetActionsForElementsortByColumn != null)
                {
                    jABGetActionsForElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABGetActionsForElementsortByColumn);
                    jABGetActionsForElementpropCount++;
                }

                if (__workflow_jABGetActionsForElementmatchIndexAscending != null)
                {
                    if (__workflow_jABGetActionsForElementmatchIndexAscending != null)
                    {
                        jABGetActionsForElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABGetActionsForElementmatchIndexAscending);
                        jABGetActionsForElementpropCount++;
                    }

                    jABGetActionsForElementpropCount++;
                }
                else
                {
                    jABGetActionsForElement["MatchIndexAscending"] = true;
                    jABGetActionsForElementpropCount++;
                }

                if (__workflow_jABGetActionsForElementcaseSensitiveSearch != null)
                {
                    if (__workflow_jABGetActionsForElementcaseSensitiveSearch != null)
                    {
                        jABGetActionsForElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetActionsForElementcaseSensitiveSearch);
                        jABGetActionsForElementpropCount++;
                    }

                    jABGetActionsForElementpropCount++;
                }
                else
                {
                    jABGetActionsForElement["CaseSensitiveSearch"] = false;
                    jABGetActionsForElementpropCount++;
                }

                if (__workflow_jABGetActionsForElementonlySearchVisibleElements != null)
                {
                    if (__workflow_jABGetActionsForElementonlySearchVisibleElements != null)
                    {
                        jABGetActionsForElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABGetActionsForElementonlySearchVisibleElements);
                        jABGetActionsForElementpropCount++;
                    }

                    jABGetActionsForElementpropCount++;
                }
                else
                {
                    jABGetActionsForElement["OnlySearchVisibleElements"] = true;
                    jABGetActionsForElementpropCount++;
                }

                if (__workflow_jABGetActionsForElementonlySearchShowingElements != null)
                {
                    if (__workflow_jABGetActionsForElementonlySearchShowingElements != null)
                    {
                        jABGetActionsForElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABGetActionsForElementonlySearchShowingElements);
                        jABGetActionsForElementpropCount++;
                    }

                    jABGetActionsForElementpropCount++;
                }
                else
                {
                    jABGetActionsForElement["OnlySearchShowingElements"] = true;
                    jABGetActionsForElementpropCount++;
                }

                if (__workflow_jABGetActionsForElementelementRolesNotToTraverse != null)
                {
                    jABGetActionsForElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABGetActionsForElementelementRolesNotToTraverse);
                    jABGetActionsForElementpropCount++;
                }

                if (__workflow_jABGetActionsForElementmaximumElementsToSearch != null)
                {
                    if (__workflow_jABGetActionsForElementmaximumElementsToSearch != null)
                    {
                        jABGetActionsForElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetActionsForElementmaximumElementsToSearch);
                        jABGetActionsForElementpropCount++;
                    }

                    jABGetActionsForElementpropCount++;
                }
                else
                {
                    jABGetActionsForElement["MaximumElementsToSearch"] = 2000;
                    jABGetActionsForElementpropCount++;
                }

                if (__workflow_jABGetActionsForElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABGetActionsForElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetActionsForElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABGetActionsForElementmaximumChildElementsToSearchPerNode);
                        jABGetActionsForElementpropCount++;
                    }

                    jABGetActionsForElementpropCount++;
                }
                else
                {
                    jABGetActionsForElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGetActionsForElementpropCount++;
                }

                jABGetActionsForElementpropCount++;
                jABGetActionsForElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetActionsForElementworkflow);
                if (jABGetActionsForElementpropCount > 0)
                {
                    callPayload.Body = jABGetActionsForElement;
                }

                return new ApiConnectionAction<JABGetActionsForElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABFocusElement(Expression<Func<int>> jABFocusElementsearchParentElementJABHandle, Expression<Func<string>> jABFocusElementworkflow, Expression<Func<string>> jABFocusElementsearchElementJABName = null, Expression<Func<string>> jABFocusElementsearchElementJABDescription = null, Expression<Func<string>> jABFocusElementsearchElementJABRole = null, Expression<Func<bool>> jABFocusElementsearchSubTree = null, Expression<Func<int>> jABFocusElementmaxRelativeDepth = null, Expression<Func<int>> jABFocusElementmatchIndex = null, Expression<Func<string>> jABFocusElementsearchFilter = null, Expression<Func<string>> jABFocusElementsortByColumn = null, Expression<Func<bool>> jABFocusElementmatchIndexAscending = null, Expression<Func<bool>> jABFocusElementcaseSensitiveSearch = null, Expression<Func<bool>> jABFocusElementonlySearchVisibleElements = null, Expression<Func<bool>> jABFocusElementonlySearchShowingElements = null, Expression<Func<string>> jABFocusElementelementRolesNotToTraverse = null, Expression<Func<int>> jABFocusElementmaximumElementsToSearch = null, Expression<Func<int>> jABFocusElementmaximumChildElementsToSearchPerNode = null)
        {
            var __workflow_jABFocusElementsearchParentElementJABHandle = WorkflowExpression.Compile(jABFocusElementsearchParentElementJABHandle, nameof(jABFocusElementsearchParentElementJABHandle), required: true);
            var __workflow_jABFocusElementworkflow = WorkflowExpression.Compile(jABFocusElementworkflow, nameof(jABFocusElementworkflow), required: true);
            var __workflow_jABFocusElementsearchElementJABName = WorkflowExpression.Compile(jABFocusElementsearchElementJABName, nameof(jABFocusElementsearchElementJABName), required: false);
            var __workflow_jABFocusElementsearchElementJABDescription = WorkflowExpression.Compile(jABFocusElementsearchElementJABDescription, nameof(jABFocusElementsearchElementJABDescription), required: false);
            var __workflow_jABFocusElementsearchElementJABRole = WorkflowExpression.Compile(jABFocusElementsearchElementJABRole, nameof(jABFocusElementsearchElementJABRole), required: false);
            var __workflow_jABFocusElementsearchSubTree = WorkflowExpression.Compile(jABFocusElementsearchSubTree, nameof(jABFocusElementsearchSubTree), required: false);
            var __workflow_jABFocusElementmaxRelativeDepth = WorkflowExpression.Compile(jABFocusElementmaxRelativeDepth, nameof(jABFocusElementmaxRelativeDepth), required: false);
            var __workflow_jABFocusElementmatchIndex = WorkflowExpression.Compile(jABFocusElementmatchIndex, nameof(jABFocusElementmatchIndex), required: false);
            var __workflow_jABFocusElementsearchFilter = WorkflowExpression.Compile(jABFocusElementsearchFilter, nameof(jABFocusElementsearchFilter), required: false);
            var __workflow_jABFocusElementsortByColumn = WorkflowExpression.Compile(jABFocusElementsortByColumn, nameof(jABFocusElementsortByColumn), required: false);
            var __workflow_jABFocusElementmatchIndexAscending = WorkflowExpression.Compile(jABFocusElementmatchIndexAscending, nameof(jABFocusElementmatchIndexAscending), required: false);
            var __workflow_jABFocusElementcaseSensitiveSearch = WorkflowExpression.Compile(jABFocusElementcaseSensitiveSearch, nameof(jABFocusElementcaseSensitiveSearch), required: false);
            var __workflow_jABFocusElementonlySearchVisibleElements = WorkflowExpression.Compile(jABFocusElementonlySearchVisibleElements, nameof(jABFocusElementonlySearchVisibleElements), required: false);
            var __workflow_jABFocusElementonlySearchShowingElements = WorkflowExpression.Compile(jABFocusElementonlySearchShowingElements, nameof(jABFocusElementonlySearchShowingElements), required: false);
            var __workflow_jABFocusElementelementRolesNotToTraverse = WorkflowExpression.Compile(jABFocusElementelementRolesNotToTraverse, nameof(jABFocusElementelementRolesNotToTraverse), required: false);
            var __workflow_jABFocusElementmaximumElementsToSearch = WorkflowExpression.Compile(jABFocusElementmaximumElementsToSearch, nameof(jABFocusElementmaximumElementsToSearch), required: false);
            var __workflow_jABFocusElementmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABFocusElementmaximumChildElementsToSearchPerNode, nameof(jABFocusElementmaximumChildElementsToSearchPerNode), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABFocusElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABFocusElement = new JObject();
                var jABFocusElementpropCount = 0;
                jABFocusElementpropCount++;
                jABFocusElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABFocusElementsearchParentElementJABHandle);
                if (__workflow_jABFocusElementsearchElementJABName != null)
                {
                    jABFocusElement["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABFocusElementsearchElementJABName);
                    jABFocusElementpropCount++;
                }

                if (__workflow_jABFocusElementsearchElementJABDescription != null)
                {
                    jABFocusElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABFocusElementsearchElementJABDescription);
                    jABFocusElementpropCount++;
                }

                if (__workflow_jABFocusElementsearchElementJABRole != null)
                {
                    jABFocusElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABFocusElementsearchElementJABRole);
                    jABFocusElementpropCount++;
                }

                if (__workflow_jABFocusElementsearchSubTree != null)
                {
                    if (__workflow_jABFocusElementsearchSubTree != null)
                    {
                        jABFocusElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABFocusElementsearchSubTree);
                        jABFocusElementpropCount++;
                    }

                    jABFocusElementpropCount++;
                }
                else
                {
                    jABFocusElement["SearchSubTree"] = true;
                    jABFocusElementpropCount++;
                }

                if (__workflow_jABFocusElementmaxRelativeDepth != null)
                {
                    if (__workflow_jABFocusElementmaxRelativeDepth != null)
                    {
                        jABFocusElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABFocusElementmaxRelativeDepth);
                        jABFocusElementpropCount++;
                    }

                    jABFocusElementpropCount++;
                }
                else
                {
                    jABFocusElement["MaxRelativeDepth"] = 0;
                    jABFocusElementpropCount++;
                }

                if (__workflow_jABFocusElementmatchIndex != null)
                {
                    if (__workflow_jABFocusElementmatchIndex != null)
                    {
                        jABFocusElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABFocusElementmatchIndex);
                        jABFocusElementpropCount++;
                    }

                    jABFocusElementpropCount++;
                }
                else
                {
                    jABFocusElement["MatchIndex"] = 1;
                    jABFocusElementpropCount++;
                }

                if (__workflow_jABFocusElementsearchFilter != null)
                {
                    jABFocusElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABFocusElementsearchFilter);
                    jABFocusElementpropCount++;
                }

                if (__workflow_jABFocusElementsortByColumn != null)
                {
                    jABFocusElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABFocusElementsortByColumn);
                    jABFocusElementpropCount++;
                }

                if (__workflow_jABFocusElementmatchIndexAscending != null)
                {
                    if (__workflow_jABFocusElementmatchIndexAscending != null)
                    {
                        jABFocusElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABFocusElementmatchIndexAscending);
                        jABFocusElementpropCount++;
                    }

                    jABFocusElementpropCount++;
                }
                else
                {
                    jABFocusElement["MatchIndexAscending"] = true;
                    jABFocusElementpropCount++;
                }

                if (__workflow_jABFocusElementcaseSensitiveSearch != null)
                {
                    if (__workflow_jABFocusElementcaseSensitiveSearch != null)
                    {
                        jABFocusElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABFocusElementcaseSensitiveSearch);
                        jABFocusElementpropCount++;
                    }

                    jABFocusElementpropCount++;
                }
                else
                {
                    jABFocusElement["CaseSensitiveSearch"] = false;
                    jABFocusElementpropCount++;
                }

                if (__workflow_jABFocusElementonlySearchVisibleElements != null)
                {
                    if (__workflow_jABFocusElementonlySearchVisibleElements != null)
                    {
                        jABFocusElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABFocusElementonlySearchVisibleElements);
                        jABFocusElementpropCount++;
                    }

                    jABFocusElementpropCount++;
                }
                else
                {
                    jABFocusElement["OnlySearchVisibleElements"] = true;
                    jABFocusElementpropCount++;
                }

                if (__workflow_jABFocusElementonlySearchShowingElements != null)
                {
                    if (__workflow_jABFocusElementonlySearchShowingElements != null)
                    {
                        jABFocusElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABFocusElementonlySearchShowingElements);
                        jABFocusElementpropCount++;
                    }

                    jABFocusElementpropCount++;
                }
                else
                {
                    jABFocusElement["OnlySearchShowingElements"] = true;
                    jABFocusElementpropCount++;
                }

                if (__workflow_jABFocusElementelementRolesNotToTraverse != null)
                {
                    jABFocusElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABFocusElementelementRolesNotToTraverse);
                    jABFocusElementpropCount++;
                }

                if (__workflow_jABFocusElementmaximumElementsToSearch != null)
                {
                    if (__workflow_jABFocusElementmaximumElementsToSearch != null)
                    {
                        jABFocusElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABFocusElementmaximumElementsToSearch);
                        jABFocusElementpropCount++;
                    }

                    jABFocusElementpropCount++;
                }
                else
                {
                    jABFocusElement["MaximumElementsToSearch"] = 2000;
                    jABFocusElementpropCount++;
                }

                if (__workflow_jABFocusElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABFocusElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABFocusElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABFocusElementmaximumChildElementsToSearchPerNode);
                        jABFocusElementpropCount++;
                    }

                    jABFocusElementpropCount++;
                }
                else
                {
                    jABFocusElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABFocusElementpropCount++;
                }

                jABFocusElementpropCount++;
                jABFocusElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABFocusElementworkflow);
                if (jABFocusElementpropCount > 0)
                {
                    callPayload.Body = jABFocusElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABInputPasswordIntoElement(Expression<Func<int>> jABInputPasswordIntoElementsearchParentElementJABHandle, Expression<Func<string>> jABInputPasswordIntoElementpasswordToInput, Expression<Func<string>> jABInputPasswordIntoElementworkflow, Expression<Func<string>> jABInputPasswordIntoElementsearchElementJABName = null, Expression<Func<string>> jABInputPasswordIntoElementsearchElementJABDescription = null, Expression<Func<string>> jABInputPasswordIntoElementsearchElementJABRole = null, Expression<Func<bool>> jABInputPasswordIntoElementsearchSubTree = null, Expression<Func<int>> jABInputPasswordIntoElementmaxRelativeDepth = null, Expression<Func<int>> jABInputPasswordIntoElementmatchIndex = null, Expression<Func<string>> jABInputPasswordIntoElementsearchFilter = null, Expression<Func<string>> jABInputPasswordIntoElementsortByColumn = null, Expression<Func<bool>> jABInputPasswordIntoElementmatchIndexAscending = null, Expression<Func<bool>> jABInputPasswordIntoElementcaseSensitiveSearch = null, Expression<Func<bool>> jABInputPasswordIntoElementonlySearchVisibleElements = null, Expression<Func<bool>> jABInputPasswordIntoElementonlySearchShowingElements = null, Expression<Func<string>> jABInputPasswordIntoElementelementRolesNotToTraverse = null, Expression<Func<int>> jABInputPasswordIntoElementmaximumElementsToSearch = null, Expression<Func<int>> jABInputPasswordIntoElementmaximumChildElementsToSearchPerNode = null)
        {
            var __workflow_jABInputPasswordIntoElementsearchParentElementJABHandle = WorkflowExpression.Compile(jABInputPasswordIntoElementsearchParentElementJABHandle, nameof(jABInputPasswordIntoElementsearchParentElementJABHandle), required: true);
            var __workflow_jABInputPasswordIntoElementpasswordToInput = WorkflowExpression.Compile(jABInputPasswordIntoElementpasswordToInput, nameof(jABInputPasswordIntoElementpasswordToInput), required: true);
            var __workflow_jABInputPasswordIntoElementworkflow = WorkflowExpression.Compile(jABInputPasswordIntoElementworkflow, nameof(jABInputPasswordIntoElementworkflow), required: true);
            var __workflow_jABInputPasswordIntoElementsearchElementJABName = WorkflowExpression.Compile(jABInputPasswordIntoElementsearchElementJABName, nameof(jABInputPasswordIntoElementsearchElementJABName), required: false);
            var __workflow_jABInputPasswordIntoElementsearchElementJABDescription = WorkflowExpression.Compile(jABInputPasswordIntoElementsearchElementJABDescription, nameof(jABInputPasswordIntoElementsearchElementJABDescription), required: false);
            var __workflow_jABInputPasswordIntoElementsearchElementJABRole = WorkflowExpression.Compile(jABInputPasswordIntoElementsearchElementJABRole, nameof(jABInputPasswordIntoElementsearchElementJABRole), required: false);
            var __workflow_jABInputPasswordIntoElementsearchSubTree = WorkflowExpression.Compile(jABInputPasswordIntoElementsearchSubTree, nameof(jABInputPasswordIntoElementsearchSubTree), required: false);
            var __workflow_jABInputPasswordIntoElementmaxRelativeDepth = WorkflowExpression.Compile(jABInputPasswordIntoElementmaxRelativeDepth, nameof(jABInputPasswordIntoElementmaxRelativeDepth), required: false);
            var __workflow_jABInputPasswordIntoElementmatchIndex = WorkflowExpression.Compile(jABInputPasswordIntoElementmatchIndex, nameof(jABInputPasswordIntoElementmatchIndex), required: false);
            var __workflow_jABInputPasswordIntoElementsearchFilter = WorkflowExpression.Compile(jABInputPasswordIntoElementsearchFilter, nameof(jABInputPasswordIntoElementsearchFilter), required: false);
            var __workflow_jABInputPasswordIntoElementsortByColumn = WorkflowExpression.Compile(jABInputPasswordIntoElementsortByColumn, nameof(jABInputPasswordIntoElementsortByColumn), required: false);
            var __workflow_jABInputPasswordIntoElementmatchIndexAscending = WorkflowExpression.Compile(jABInputPasswordIntoElementmatchIndexAscending, nameof(jABInputPasswordIntoElementmatchIndexAscending), required: false);
            var __workflow_jABInputPasswordIntoElementcaseSensitiveSearch = WorkflowExpression.Compile(jABInputPasswordIntoElementcaseSensitiveSearch, nameof(jABInputPasswordIntoElementcaseSensitiveSearch), required: false);
            var __workflow_jABInputPasswordIntoElementonlySearchVisibleElements = WorkflowExpression.Compile(jABInputPasswordIntoElementonlySearchVisibleElements, nameof(jABInputPasswordIntoElementonlySearchVisibleElements), required: false);
            var __workflow_jABInputPasswordIntoElementonlySearchShowingElements = WorkflowExpression.Compile(jABInputPasswordIntoElementonlySearchShowingElements, nameof(jABInputPasswordIntoElementonlySearchShowingElements), required: false);
            var __workflow_jABInputPasswordIntoElementelementRolesNotToTraverse = WorkflowExpression.Compile(jABInputPasswordIntoElementelementRolesNotToTraverse, nameof(jABInputPasswordIntoElementelementRolesNotToTraverse), required: false);
            var __workflow_jABInputPasswordIntoElementmaximumElementsToSearch = WorkflowExpression.Compile(jABInputPasswordIntoElementmaximumElementsToSearch, nameof(jABInputPasswordIntoElementmaximumElementsToSearch), required: false);
            var __workflow_jABInputPasswordIntoElementmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABInputPasswordIntoElementmaximumChildElementsToSearchPerNode, nameof(jABInputPasswordIntoElementmaximumChildElementsToSearchPerNode), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABInputPasswordIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABInputPasswordIntoElement = new JObject();
                var jABInputPasswordIntoElementpropCount = 0;
                jABInputPasswordIntoElementpropCount++;
                jABInputPasswordIntoElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABInputPasswordIntoElementsearchParentElementJABHandle);
                if (__workflow_jABInputPasswordIntoElementsearchElementJABName != null)
                {
                    jABInputPasswordIntoElement["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABInputPasswordIntoElementsearchElementJABName);
                    jABInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABInputPasswordIntoElementsearchElementJABDescription != null)
                {
                    jABInputPasswordIntoElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABInputPasswordIntoElementsearchElementJABDescription);
                    jABInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABInputPasswordIntoElementsearchElementJABRole != null)
                {
                    jABInputPasswordIntoElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABInputPasswordIntoElementsearchElementJABRole);
                    jABInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABInputPasswordIntoElementsearchSubTree != null)
                {
                    if (__workflow_jABInputPasswordIntoElementsearchSubTree != null)
                    {
                        jABInputPasswordIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABInputPasswordIntoElementsearchSubTree);
                        jABInputPasswordIntoElementpropCount++;
                    }

                    jABInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABInputPasswordIntoElement["SearchSubTree"] = true;
                    jABInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABInputPasswordIntoElementmaxRelativeDepth != null)
                {
                    if (__workflow_jABInputPasswordIntoElementmaxRelativeDepth != null)
                    {
                        jABInputPasswordIntoElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABInputPasswordIntoElementmaxRelativeDepth);
                        jABInputPasswordIntoElementpropCount++;
                    }

                    jABInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABInputPasswordIntoElement["MaxRelativeDepth"] = 0;
                    jABInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABInputPasswordIntoElementmatchIndex != null)
                {
                    if (__workflow_jABInputPasswordIntoElementmatchIndex != null)
                    {
                        jABInputPasswordIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABInputPasswordIntoElementmatchIndex);
                        jABInputPasswordIntoElementpropCount++;
                    }

                    jABInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABInputPasswordIntoElement["MatchIndex"] = 1;
                    jABInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABInputPasswordIntoElementsearchFilter != null)
                {
                    jABInputPasswordIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABInputPasswordIntoElementsearchFilter);
                    jABInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABInputPasswordIntoElementsortByColumn != null)
                {
                    jABInputPasswordIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABInputPasswordIntoElementsortByColumn);
                    jABInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABInputPasswordIntoElementmatchIndexAscending != null)
                {
                    if (__workflow_jABInputPasswordIntoElementmatchIndexAscending != null)
                    {
                        jABInputPasswordIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABInputPasswordIntoElementmatchIndexAscending);
                        jABInputPasswordIntoElementpropCount++;
                    }

                    jABInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABInputPasswordIntoElement["MatchIndexAscending"] = true;
                    jABInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABInputPasswordIntoElementcaseSensitiveSearch != null)
                {
                    if (__workflow_jABInputPasswordIntoElementcaseSensitiveSearch != null)
                    {
                        jABInputPasswordIntoElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABInputPasswordIntoElementcaseSensitiveSearch);
                        jABInputPasswordIntoElementpropCount++;
                    }

                    jABInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABInputPasswordIntoElement["CaseSensitiveSearch"] = false;
                    jABInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABInputPasswordIntoElementonlySearchVisibleElements != null)
                {
                    if (__workflow_jABInputPasswordIntoElementonlySearchVisibleElements != null)
                    {
                        jABInputPasswordIntoElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABInputPasswordIntoElementonlySearchVisibleElements);
                        jABInputPasswordIntoElementpropCount++;
                    }

                    jABInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABInputPasswordIntoElement["OnlySearchVisibleElements"] = true;
                    jABInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABInputPasswordIntoElementonlySearchShowingElements != null)
                {
                    if (__workflow_jABInputPasswordIntoElementonlySearchShowingElements != null)
                    {
                        jABInputPasswordIntoElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABInputPasswordIntoElementonlySearchShowingElements);
                        jABInputPasswordIntoElementpropCount++;
                    }

                    jABInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABInputPasswordIntoElement["OnlySearchShowingElements"] = true;
                    jABInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABInputPasswordIntoElementelementRolesNotToTraverse != null)
                {
                    jABInputPasswordIntoElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABInputPasswordIntoElementelementRolesNotToTraverse);
                    jABInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABInputPasswordIntoElementmaximumElementsToSearch != null)
                {
                    if (__workflow_jABInputPasswordIntoElementmaximumElementsToSearch != null)
                    {
                        jABInputPasswordIntoElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABInputPasswordIntoElementmaximumElementsToSearch);
                        jABInputPasswordIntoElementpropCount++;
                    }

                    jABInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABInputPasswordIntoElement["MaximumElementsToSearch"] = 2000;
                    jABInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABInputPasswordIntoElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABInputPasswordIntoElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABInputPasswordIntoElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABInputPasswordIntoElementmaximumChildElementsToSearchPerNode);
                        jABInputPasswordIntoElementpropCount++;
                    }

                    jABInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABInputPasswordIntoElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABInputPasswordIntoElementpropCount++;
                }

                jABInputPasswordIntoElementpropCount++;
                jABInputPasswordIntoElement["PasswordToInput"] = ExpressionConverter.ConvertO(__workflow_jABInputPasswordIntoElementpasswordToInput);
                jABInputPasswordIntoElementpropCount++;
                jABInputPasswordIntoElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABInputPasswordIntoElementworkflow);
                if (jABInputPasswordIntoElementpropCount > 0)
                {
                    callPayload.Body = jABInputPasswordIntoElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABInputTextIntoElement(Expression<Func<int>> jABInputTextIntoElementsearchParentElementJABHandle, Expression<Func<string>> jABInputTextIntoElementworkflow, Expression<Func<string>> jABInputTextIntoElementsearchElementJABName = null, Expression<Func<string>> jABInputTextIntoElementsearchElementJABDescription = null, Expression<Func<string>> jABInputTextIntoElementsearchElementJABRole = null, Expression<Func<bool>> jABInputTextIntoElementsearchSubTree = null, Expression<Func<int>> jABInputTextIntoElementmaxRelativeDepth = null, Expression<Func<int>> jABInputTextIntoElementmatchIndex = null, Expression<Func<string>> jABInputTextIntoElementsearchFilter = null, Expression<Func<string>> jABInputTextIntoElementsortByColumn = null, Expression<Func<bool>> jABInputTextIntoElementmatchIndexAscending = null, Expression<Func<bool>> jABInputTextIntoElementcaseSensitiveSearch = null, Expression<Func<bool>> jABInputTextIntoElementonlySearchVisibleElements = null, Expression<Func<bool>> jABInputTextIntoElementonlySearchShowingElements = null, Expression<Func<string>> jABInputTextIntoElementelementRolesNotToTraverse = null, Expression<Func<int>> jABInputTextIntoElementmaximumElementsToSearch = null, Expression<Func<int>> jABInputTextIntoElementmaximumChildElementsToSearchPerNode = null, Expression<Func<string>> jABInputTextIntoElementtextToInput = null, Expression<Func<bool>> jABInputTextIntoElementreplaceExistingValue = null, Expression<Func<int>> jABInputTextIntoElementinsertPosition = null)
        {
            var __workflow_jABInputTextIntoElementsearchParentElementJABHandle = WorkflowExpression.Compile(jABInputTextIntoElementsearchParentElementJABHandle, nameof(jABInputTextIntoElementsearchParentElementJABHandle), required: true);
            var __workflow_jABInputTextIntoElementworkflow = WorkflowExpression.Compile(jABInputTextIntoElementworkflow, nameof(jABInputTextIntoElementworkflow), required: true);
            var __workflow_jABInputTextIntoElementsearchElementJABName = WorkflowExpression.Compile(jABInputTextIntoElementsearchElementJABName, nameof(jABInputTextIntoElementsearchElementJABName), required: false);
            var __workflow_jABInputTextIntoElementsearchElementJABDescription = WorkflowExpression.Compile(jABInputTextIntoElementsearchElementJABDescription, nameof(jABInputTextIntoElementsearchElementJABDescription), required: false);
            var __workflow_jABInputTextIntoElementsearchElementJABRole = WorkflowExpression.Compile(jABInputTextIntoElementsearchElementJABRole, nameof(jABInputTextIntoElementsearchElementJABRole), required: false);
            var __workflow_jABInputTextIntoElementsearchSubTree = WorkflowExpression.Compile(jABInputTextIntoElementsearchSubTree, nameof(jABInputTextIntoElementsearchSubTree), required: false);
            var __workflow_jABInputTextIntoElementmaxRelativeDepth = WorkflowExpression.Compile(jABInputTextIntoElementmaxRelativeDepth, nameof(jABInputTextIntoElementmaxRelativeDepth), required: false);
            var __workflow_jABInputTextIntoElementmatchIndex = WorkflowExpression.Compile(jABInputTextIntoElementmatchIndex, nameof(jABInputTextIntoElementmatchIndex), required: false);
            var __workflow_jABInputTextIntoElementsearchFilter = WorkflowExpression.Compile(jABInputTextIntoElementsearchFilter, nameof(jABInputTextIntoElementsearchFilter), required: false);
            var __workflow_jABInputTextIntoElementsortByColumn = WorkflowExpression.Compile(jABInputTextIntoElementsortByColumn, nameof(jABInputTextIntoElementsortByColumn), required: false);
            var __workflow_jABInputTextIntoElementmatchIndexAscending = WorkflowExpression.Compile(jABInputTextIntoElementmatchIndexAscending, nameof(jABInputTextIntoElementmatchIndexAscending), required: false);
            var __workflow_jABInputTextIntoElementcaseSensitiveSearch = WorkflowExpression.Compile(jABInputTextIntoElementcaseSensitiveSearch, nameof(jABInputTextIntoElementcaseSensitiveSearch), required: false);
            var __workflow_jABInputTextIntoElementonlySearchVisibleElements = WorkflowExpression.Compile(jABInputTextIntoElementonlySearchVisibleElements, nameof(jABInputTextIntoElementonlySearchVisibleElements), required: false);
            var __workflow_jABInputTextIntoElementonlySearchShowingElements = WorkflowExpression.Compile(jABInputTextIntoElementonlySearchShowingElements, nameof(jABInputTextIntoElementonlySearchShowingElements), required: false);
            var __workflow_jABInputTextIntoElementelementRolesNotToTraverse = WorkflowExpression.Compile(jABInputTextIntoElementelementRolesNotToTraverse, nameof(jABInputTextIntoElementelementRolesNotToTraverse), required: false);
            var __workflow_jABInputTextIntoElementmaximumElementsToSearch = WorkflowExpression.Compile(jABInputTextIntoElementmaximumElementsToSearch, nameof(jABInputTextIntoElementmaximumElementsToSearch), required: false);
            var __workflow_jABInputTextIntoElementmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABInputTextIntoElementmaximumChildElementsToSearchPerNode, nameof(jABInputTextIntoElementmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABInputTextIntoElementtextToInput = WorkflowExpression.Compile(jABInputTextIntoElementtextToInput, nameof(jABInputTextIntoElementtextToInput), required: false);
            var __workflow_jABInputTextIntoElementreplaceExistingValue = WorkflowExpression.Compile(jABInputTextIntoElementreplaceExistingValue, nameof(jABInputTextIntoElementreplaceExistingValue), required: false);
            var __workflow_jABInputTextIntoElementinsertPosition = WorkflowExpression.Compile(jABInputTextIntoElementinsertPosition, nameof(jABInputTextIntoElementinsertPosition), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABInputTextIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABInputTextIntoElement = new JObject();
                var jABInputTextIntoElementpropCount = 0;
                jABInputTextIntoElementpropCount++;
                jABInputTextIntoElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABInputTextIntoElementsearchParentElementJABHandle);
                if (__workflow_jABInputTextIntoElementsearchElementJABName != null)
                {
                    jABInputTextIntoElement["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABInputTextIntoElementsearchElementJABName);
                    jABInputTextIntoElementpropCount++;
                }

                if (__workflow_jABInputTextIntoElementsearchElementJABDescription != null)
                {
                    jABInputTextIntoElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABInputTextIntoElementsearchElementJABDescription);
                    jABInputTextIntoElementpropCount++;
                }

                if (__workflow_jABInputTextIntoElementsearchElementJABRole != null)
                {
                    jABInputTextIntoElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABInputTextIntoElementsearchElementJABRole);
                    jABInputTextIntoElementpropCount++;
                }

                if (__workflow_jABInputTextIntoElementsearchSubTree != null)
                {
                    if (__workflow_jABInputTextIntoElementsearchSubTree != null)
                    {
                        jABInputTextIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABInputTextIntoElementsearchSubTree);
                        jABInputTextIntoElementpropCount++;
                    }

                    jABInputTextIntoElementpropCount++;
                }
                else
                {
                    jABInputTextIntoElement["SearchSubTree"] = true;
                    jABInputTextIntoElementpropCount++;
                }

                if (__workflow_jABInputTextIntoElementmaxRelativeDepth != null)
                {
                    if (__workflow_jABInputTextIntoElementmaxRelativeDepth != null)
                    {
                        jABInputTextIntoElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABInputTextIntoElementmaxRelativeDepth);
                        jABInputTextIntoElementpropCount++;
                    }

                    jABInputTextIntoElementpropCount++;
                }
                else
                {
                    jABInputTextIntoElement["MaxRelativeDepth"] = 0;
                    jABInputTextIntoElementpropCount++;
                }

                if (__workflow_jABInputTextIntoElementmatchIndex != null)
                {
                    if (__workflow_jABInputTextIntoElementmatchIndex != null)
                    {
                        jABInputTextIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABInputTextIntoElementmatchIndex);
                        jABInputTextIntoElementpropCount++;
                    }

                    jABInputTextIntoElementpropCount++;
                }
                else
                {
                    jABInputTextIntoElement["MatchIndex"] = 1;
                    jABInputTextIntoElementpropCount++;
                }

                if (__workflow_jABInputTextIntoElementsearchFilter != null)
                {
                    jABInputTextIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABInputTextIntoElementsearchFilter);
                    jABInputTextIntoElementpropCount++;
                }

                if (__workflow_jABInputTextIntoElementsortByColumn != null)
                {
                    jABInputTextIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABInputTextIntoElementsortByColumn);
                    jABInputTextIntoElementpropCount++;
                }

                if (__workflow_jABInputTextIntoElementmatchIndexAscending != null)
                {
                    if (__workflow_jABInputTextIntoElementmatchIndexAscending != null)
                    {
                        jABInputTextIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABInputTextIntoElementmatchIndexAscending);
                        jABInputTextIntoElementpropCount++;
                    }

                    jABInputTextIntoElementpropCount++;
                }
                else
                {
                    jABInputTextIntoElement["MatchIndexAscending"] = true;
                    jABInputTextIntoElementpropCount++;
                }

                if (__workflow_jABInputTextIntoElementcaseSensitiveSearch != null)
                {
                    if (__workflow_jABInputTextIntoElementcaseSensitiveSearch != null)
                    {
                        jABInputTextIntoElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABInputTextIntoElementcaseSensitiveSearch);
                        jABInputTextIntoElementpropCount++;
                    }

                    jABInputTextIntoElementpropCount++;
                }
                else
                {
                    jABInputTextIntoElement["CaseSensitiveSearch"] = false;
                    jABInputTextIntoElementpropCount++;
                }

                if (__workflow_jABInputTextIntoElementonlySearchVisibleElements != null)
                {
                    if (__workflow_jABInputTextIntoElementonlySearchVisibleElements != null)
                    {
                        jABInputTextIntoElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABInputTextIntoElementonlySearchVisibleElements);
                        jABInputTextIntoElementpropCount++;
                    }

                    jABInputTextIntoElementpropCount++;
                }
                else
                {
                    jABInputTextIntoElement["OnlySearchVisibleElements"] = true;
                    jABInputTextIntoElementpropCount++;
                }

                if (__workflow_jABInputTextIntoElementonlySearchShowingElements != null)
                {
                    if (__workflow_jABInputTextIntoElementonlySearchShowingElements != null)
                    {
                        jABInputTextIntoElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABInputTextIntoElementonlySearchShowingElements);
                        jABInputTextIntoElementpropCount++;
                    }

                    jABInputTextIntoElementpropCount++;
                }
                else
                {
                    jABInputTextIntoElement["OnlySearchShowingElements"] = true;
                    jABInputTextIntoElementpropCount++;
                }

                if (__workflow_jABInputTextIntoElementelementRolesNotToTraverse != null)
                {
                    jABInputTextIntoElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABInputTextIntoElementelementRolesNotToTraverse);
                    jABInputTextIntoElementpropCount++;
                }

                if (__workflow_jABInputTextIntoElementmaximumElementsToSearch != null)
                {
                    if (__workflow_jABInputTextIntoElementmaximumElementsToSearch != null)
                    {
                        jABInputTextIntoElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABInputTextIntoElementmaximumElementsToSearch);
                        jABInputTextIntoElementpropCount++;
                    }

                    jABInputTextIntoElementpropCount++;
                }
                else
                {
                    jABInputTextIntoElement["MaximumElementsToSearch"] = 2000;
                    jABInputTextIntoElementpropCount++;
                }

                if (__workflow_jABInputTextIntoElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABInputTextIntoElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABInputTextIntoElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABInputTextIntoElementmaximumChildElementsToSearchPerNode);
                        jABInputTextIntoElementpropCount++;
                    }

                    jABInputTextIntoElementpropCount++;
                }
                else
                {
                    jABInputTextIntoElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABInputTextIntoElementpropCount++;
                }

                if (__workflow_jABInputTextIntoElementtextToInput != null)
                {
                    jABInputTextIntoElement["TextToInput"] = ExpressionConverter.ConvertO(__workflow_jABInputTextIntoElementtextToInput);
                    jABInputTextIntoElementpropCount++;
                }

                if (__workflow_jABInputTextIntoElementreplaceExistingValue != null)
                {
                    if (__workflow_jABInputTextIntoElementreplaceExistingValue != null)
                    {
                        jABInputTextIntoElement["ReplaceExistingValue"] = ExpressionConverter.ConvertO(__workflow_jABInputTextIntoElementreplaceExistingValue);
                        jABInputTextIntoElementpropCount++;
                    }

                    jABInputTextIntoElementpropCount++;
                }
                else
                {
                    jABInputTextIntoElement["ReplaceExistingValue"] = true;
                    jABInputTextIntoElementpropCount++;
                }

                if (__workflow_jABInputTextIntoElementinsertPosition != null)
                {
                    if (__workflow_jABInputTextIntoElementinsertPosition != null)
                    {
                        jABInputTextIntoElement["InsertPosition"] = ExpressionConverter.ConvertO(__workflow_jABInputTextIntoElementinsertPosition);
                        jABInputTextIntoElementpropCount++;
                    }

                    jABInputTextIntoElementpropCount++;
                }
                else
                {
                    jABInputTextIntoElement["InsertPosition"] = 0;
                    jABInputTextIntoElementpropCount++;
                }

                jABInputTextIntoElementpropCount++;
                jABInputTextIntoElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABInputTextIntoElementworkflow);
                if (jABInputTextIntoElementpropCount > 0)
                {
                    callPayload.Body = jABInputTextIntoElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetElementTextValueResponse> JABGetElementTextValue(Expression<Func<int>> jABGetElementTextValuesearchParentElementJABHandle, Expression<Func<string>> jABGetElementTextValueworkflow, Expression<Func<string>> jABGetElementTextValuesearchElementJABName = null, Expression<Func<string>> jABGetElementTextValuesearchElementJABDescription = null, Expression<Func<string>> jABGetElementTextValuesearchElementJABRole = null, Expression<Func<bool>> jABGetElementTextValuesearchSubTree = null, Expression<Func<int>> jABGetElementTextValuemaxRelativeDepth = null, Expression<Func<int>> jABGetElementTextValuematchIndex = null, Expression<Func<string>> jABGetElementTextValuesearchFilter = null, Expression<Func<string>> jABGetElementTextValuesortByColumn = null, Expression<Func<bool>> jABGetElementTextValuematchIndexAscending = null, Expression<Func<bool>> jABGetElementTextValuecaseSensitiveSearch = null, Expression<Func<bool>> jABGetElementTextValueonlySearchVisibleElements = null, Expression<Func<bool>> jABGetElementTextValueonlySearchShowingElements = null, Expression<Func<string>> jABGetElementTextValueelementRolesNotToTraverse = null, Expression<Func<int>> jABGetElementTextValuemaximumElementsToSearch = null, Expression<Func<int>> jABGetElementTextValuemaximumChildElementsToSearchPerNode = null)
        {
            var __workflow_jABGetElementTextValuesearchParentElementJABHandle = WorkflowExpression.Compile(jABGetElementTextValuesearchParentElementJABHandle, nameof(jABGetElementTextValuesearchParentElementJABHandle), required: true);
            var __workflow_jABGetElementTextValueworkflow = WorkflowExpression.Compile(jABGetElementTextValueworkflow, nameof(jABGetElementTextValueworkflow), required: true);
            var __workflow_jABGetElementTextValuesearchElementJABName = WorkflowExpression.Compile(jABGetElementTextValuesearchElementJABName, nameof(jABGetElementTextValuesearchElementJABName), required: false);
            var __workflow_jABGetElementTextValuesearchElementJABDescription = WorkflowExpression.Compile(jABGetElementTextValuesearchElementJABDescription, nameof(jABGetElementTextValuesearchElementJABDescription), required: false);
            var __workflow_jABGetElementTextValuesearchElementJABRole = WorkflowExpression.Compile(jABGetElementTextValuesearchElementJABRole, nameof(jABGetElementTextValuesearchElementJABRole), required: false);
            var __workflow_jABGetElementTextValuesearchSubTree = WorkflowExpression.Compile(jABGetElementTextValuesearchSubTree, nameof(jABGetElementTextValuesearchSubTree), required: false);
            var __workflow_jABGetElementTextValuemaxRelativeDepth = WorkflowExpression.Compile(jABGetElementTextValuemaxRelativeDepth, nameof(jABGetElementTextValuemaxRelativeDepth), required: false);
            var __workflow_jABGetElementTextValuematchIndex = WorkflowExpression.Compile(jABGetElementTextValuematchIndex, nameof(jABGetElementTextValuematchIndex), required: false);
            var __workflow_jABGetElementTextValuesearchFilter = WorkflowExpression.Compile(jABGetElementTextValuesearchFilter, nameof(jABGetElementTextValuesearchFilter), required: false);
            var __workflow_jABGetElementTextValuesortByColumn = WorkflowExpression.Compile(jABGetElementTextValuesortByColumn, nameof(jABGetElementTextValuesortByColumn), required: false);
            var __workflow_jABGetElementTextValuematchIndexAscending = WorkflowExpression.Compile(jABGetElementTextValuematchIndexAscending, nameof(jABGetElementTextValuematchIndexAscending), required: false);
            var __workflow_jABGetElementTextValuecaseSensitiveSearch = WorkflowExpression.Compile(jABGetElementTextValuecaseSensitiveSearch, nameof(jABGetElementTextValuecaseSensitiveSearch), required: false);
            var __workflow_jABGetElementTextValueonlySearchVisibleElements = WorkflowExpression.Compile(jABGetElementTextValueonlySearchVisibleElements, nameof(jABGetElementTextValueonlySearchVisibleElements), required: false);
            var __workflow_jABGetElementTextValueonlySearchShowingElements = WorkflowExpression.Compile(jABGetElementTextValueonlySearchShowingElements, nameof(jABGetElementTextValueonlySearchShowingElements), required: false);
            var __workflow_jABGetElementTextValueelementRolesNotToTraverse = WorkflowExpression.Compile(jABGetElementTextValueelementRolesNotToTraverse, nameof(jABGetElementTextValueelementRolesNotToTraverse), required: false);
            var __workflow_jABGetElementTextValuemaximumElementsToSearch = WorkflowExpression.Compile(jABGetElementTextValuemaximumElementsToSearch, nameof(jABGetElementTextValuemaximumElementsToSearch), required: false);
            var __workflow_jABGetElementTextValuemaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABGetElementTextValuemaximumChildElementsToSearchPerNode, nameof(jABGetElementTextValuemaximumChildElementsToSearchPerNode), required: false);
            return new DeferredBodyAction<JABGetElementTextValueResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetElementTextValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetElementTextValue = new JObject();
                var jABGetElementTextValuepropCount = 0;
                jABGetElementTextValuepropCount++;
                jABGetElementTextValue["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGetElementTextValuesearchParentElementJABHandle);
                if (__workflow_jABGetElementTextValuesearchElementJABName != null)
                {
                    jABGetElementTextValue["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABGetElementTextValuesearchElementJABName);
                    jABGetElementTextValuepropCount++;
                }

                if (__workflow_jABGetElementTextValuesearchElementJABDescription != null)
                {
                    jABGetElementTextValue["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABGetElementTextValuesearchElementJABDescription);
                    jABGetElementTextValuepropCount++;
                }

                if (__workflow_jABGetElementTextValuesearchElementJABRole != null)
                {
                    jABGetElementTextValue["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABGetElementTextValuesearchElementJABRole);
                    jABGetElementTextValuepropCount++;
                }

                if (__workflow_jABGetElementTextValuesearchSubTree != null)
                {
                    if (__workflow_jABGetElementTextValuesearchSubTree != null)
                    {
                        jABGetElementTextValue["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABGetElementTextValuesearchSubTree);
                        jABGetElementTextValuepropCount++;
                    }

                    jABGetElementTextValuepropCount++;
                }
                else
                {
                    jABGetElementTextValue["SearchSubTree"] = true;
                    jABGetElementTextValuepropCount++;
                }

                if (__workflow_jABGetElementTextValuemaxRelativeDepth != null)
                {
                    if (__workflow_jABGetElementTextValuemaxRelativeDepth != null)
                    {
                        jABGetElementTextValue["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABGetElementTextValuemaxRelativeDepth);
                        jABGetElementTextValuepropCount++;
                    }

                    jABGetElementTextValuepropCount++;
                }
                else
                {
                    jABGetElementTextValue["MaxRelativeDepth"] = 0;
                    jABGetElementTextValuepropCount++;
                }

                if (__workflow_jABGetElementTextValuematchIndex != null)
                {
                    if (__workflow_jABGetElementTextValuematchIndex != null)
                    {
                        jABGetElementTextValue["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABGetElementTextValuematchIndex);
                        jABGetElementTextValuepropCount++;
                    }

                    jABGetElementTextValuepropCount++;
                }
                else
                {
                    jABGetElementTextValue["MatchIndex"] = 1;
                    jABGetElementTextValuepropCount++;
                }

                if (__workflow_jABGetElementTextValuesearchFilter != null)
                {
                    jABGetElementTextValue["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABGetElementTextValuesearchFilter);
                    jABGetElementTextValuepropCount++;
                }

                if (__workflow_jABGetElementTextValuesortByColumn != null)
                {
                    jABGetElementTextValue["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABGetElementTextValuesortByColumn);
                    jABGetElementTextValuepropCount++;
                }

                if (__workflow_jABGetElementTextValuematchIndexAscending != null)
                {
                    if (__workflow_jABGetElementTextValuematchIndexAscending != null)
                    {
                        jABGetElementTextValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABGetElementTextValuematchIndexAscending);
                        jABGetElementTextValuepropCount++;
                    }

                    jABGetElementTextValuepropCount++;
                }
                else
                {
                    jABGetElementTextValue["MatchIndexAscending"] = true;
                    jABGetElementTextValuepropCount++;
                }

                if (__workflow_jABGetElementTextValuecaseSensitiveSearch != null)
                {
                    if (__workflow_jABGetElementTextValuecaseSensitiveSearch != null)
                    {
                        jABGetElementTextValue["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetElementTextValuecaseSensitiveSearch);
                        jABGetElementTextValuepropCount++;
                    }

                    jABGetElementTextValuepropCount++;
                }
                else
                {
                    jABGetElementTextValue["CaseSensitiveSearch"] = false;
                    jABGetElementTextValuepropCount++;
                }

                if (__workflow_jABGetElementTextValueonlySearchVisibleElements != null)
                {
                    if (__workflow_jABGetElementTextValueonlySearchVisibleElements != null)
                    {
                        jABGetElementTextValue["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABGetElementTextValueonlySearchVisibleElements);
                        jABGetElementTextValuepropCount++;
                    }

                    jABGetElementTextValuepropCount++;
                }
                else
                {
                    jABGetElementTextValue["OnlySearchVisibleElements"] = true;
                    jABGetElementTextValuepropCount++;
                }

                if (__workflow_jABGetElementTextValueonlySearchShowingElements != null)
                {
                    if (__workflow_jABGetElementTextValueonlySearchShowingElements != null)
                    {
                        jABGetElementTextValue["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABGetElementTextValueonlySearchShowingElements);
                        jABGetElementTextValuepropCount++;
                    }

                    jABGetElementTextValuepropCount++;
                }
                else
                {
                    jABGetElementTextValue["OnlySearchShowingElements"] = true;
                    jABGetElementTextValuepropCount++;
                }

                if (__workflow_jABGetElementTextValueelementRolesNotToTraverse != null)
                {
                    jABGetElementTextValue["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABGetElementTextValueelementRolesNotToTraverse);
                    jABGetElementTextValuepropCount++;
                }

                if (__workflow_jABGetElementTextValuemaximumElementsToSearch != null)
                {
                    if (__workflow_jABGetElementTextValuemaximumElementsToSearch != null)
                    {
                        jABGetElementTextValue["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetElementTextValuemaximumElementsToSearch);
                        jABGetElementTextValuepropCount++;
                    }

                    jABGetElementTextValuepropCount++;
                }
                else
                {
                    jABGetElementTextValue["MaximumElementsToSearch"] = 2000;
                    jABGetElementTextValuepropCount++;
                }

                if (__workflow_jABGetElementTextValuemaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABGetElementTextValuemaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetElementTextValue["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABGetElementTextValuemaximumChildElementsToSearchPerNode);
                        jABGetElementTextValuepropCount++;
                    }

                    jABGetElementTextValuepropCount++;
                }
                else
                {
                    jABGetElementTextValue["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGetElementTextValuepropCount++;
                }

                jABGetElementTextValuepropCount++;
                jABGetElementTextValue["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetElementTextValueworkflow);
                if (jABGetElementTextValuepropCount > 0)
                {
                    callPayload.Body = jABGetElementTextValue;
                }

                return new ApiConnectionAction<JABGetElementTextValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetElementValueResponse> JABGetElementValue(Expression<Func<int>> jABGetElementValuesearchParentElementJABHandle, Expression<Func<string>> jABGetElementValueworkflow, Expression<Func<string>> jABGetElementValuesearchElementJABName = null, Expression<Func<string>> jABGetElementValuesearchElementJABDescription = null, Expression<Func<string>> jABGetElementValuesearchElementJABRole = null, Expression<Func<bool>> jABGetElementValuesearchSubTree = null, Expression<Func<int>> jABGetElementValuemaxRelativeDepth = null, Expression<Func<int>> jABGetElementValuematchIndex = null, Expression<Func<string>> jABGetElementValuesearchFilter = null, Expression<Func<string>> jABGetElementValuesortByColumn = null, Expression<Func<bool>> jABGetElementValuematchIndexAscending = null, Expression<Func<bool>> jABGetElementValuecaseSensitiveSearch = null, Expression<Func<bool>> jABGetElementValueonlySearchVisibleElements = null, Expression<Func<bool>> jABGetElementValueonlySearchShowingElements = null, Expression<Func<string>> jABGetElementValueelementRolesNotToTraverse = null, Expression<Func<int>> jABGetElementValuemaximumElementsToSearch = null, Expression<Func<int>> jABGetElementValuemaximumChildElementsToSearchPerNode = null)
        {
            var __workflow_jABGetElementValuesearchParentElementJABHandle = WorkflowExpression.Compile(jABGetElementValuesearchParentElementJABHandle, nameof(jABGetElementValuesearchParentElementJABHandle), required: true);
            var __workflow_jABGetElementValueworkflow = WorkflowExpression.Compile(jABGetElementValueworkflow, nameof(jABGetElementValueworkflow), required: true);
            var __workflow_jABGetElementValuesearchElementJABName = WorkflowExpression.Compile(jABGetElementValuesearchElementJABName, nameof(jABGetElementValuesearchElementJABName), required: false);
            var __workflow_jABGetElementValuesearchElementJABDescription = WorkflowExpression.Compile(jABGetElementValuesearchElementJABDescription, nameof(jABGetElementValuesearchElementJABDescription), required: false);
            var __workflow_jABGetElementValuesearchElementJABRole = WorkflowExpression.Compile(jABGetElementValuesearchElementJABRole, nameof(jABGetElementValuesearchElementJABRole), required: false);
            var __workflow_jABGetElementValuesearchSubTree = WorkflowExpression.Compile(jABGetElementValuesearchSubTree, nameof(jABGetElementValuesearchSubTree), required: false);
            var __workflow_jABGetElementValuemaxRelativeDepth = WorkflowExpression.Compile(jABGetElementValuemaxRelativeDepth, nameof(jABGetElementValuemaxRelativeDepth), required: false);
            var __workflow_jABGetElementValuematchIndex = WorkflowExpression.Compile(jABGetElementValuematchIndex, nameof(jABGetElementValuematchIndex), required: false);
            var __workflow_jABGetElementValuesearchFilter = WorkflowExpression.Compile(jABGetElementValuesearchFilter, nameof(jABGetElementValuesearchFilter), required: false);
            var __workflow_jABGetElementValuesortByColumn = WorkflowExpression.Compile(jABGetElementValuesortByColumn, nameof(jABGetElementValuesortByColumn), required: false);
            var __workflow_jABGetElementValuematchIndexAscending = WorkflowExpression.Compile(jABGetElementValuematchIndexAscending, nameof(jABGetElementValuematchIndexAscending), required: false);
            var __workflow_jABGetElementValuecaseSensitiveSearch = WorkflowExpression.Compile(jABGetElementValuecaseSensitiveSearch, nameof(jABGetElementValuecaseSensitiveSearch), required: false);
            var __workflow_jABGetElementValueonlySearchVisibleElements = WorkflowExpression.Compile(jABGetElementValueonlySearchVisibleElements, nameof(jABGetElementValueonlySearchVisibleElements), required: false);
            var __workflow_jABGetElementValueonlySearchShowingElements = WorkflowExpression.Compile(jABGetElementValueonlySearchShowingElements, nameof(jABGetElementValueonlySearchShowingElements), required: false);
            var __workflow_jABGetElementValueelementRolesNotToTraverse = WorkflowExpression.Compile(jABGetElementValueelementRolesNotToTraverse, nameof(jABGetElementValueelementRolesNotToTraverse), required: false);
            var __workflow_jABGetElementValuemaximumElementsToSearch = WorkflowExpression.Compile(jABGetElementValuemaximumElementsToSearch, nameof(jABGetElementValuemaximumElementsToSearch), required: false);
            var __workflow_jABGetElementValuemaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABGetElementValuemaximumChildElementsToSearchPerNode, nameof(jABGetElementValuemaximumChildElementsToSearchPerNode), required: false);
            return new DeferredBodyAction<JABGetElementValueResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetElementValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetElementValue = new JObject();
                var jABGetElementValuepropCount = 0;
                jABGetElementValuepropCount++;
                jABGetElementValue["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGetElementValuesearchParentElementJABHandle);
                if (__workflow_jABGetElementValuesearchElementJABName != null)
                {
                    jABGetElementValue["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABGetElementValuesearchElementJABName);
                    jABGetElementValuepropCount++;
                }

                if (__workflow_jABGetElementValuesearchElementJABDescription != null)
                {
                    jABGetElementValue["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABGetElementValuesearchElementJABDescription);
                    jABGetElementValuepropCount++;
                }

                if (__workflow_jABGetElementValuesearchElementJABRole != null)
                {
                    jABGetElementValue["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABGetElementValuesearchElementJABRole);
                    jABGetElementValuepropCount++;
                }

                if (__workflow_jABGetElementValuesearchSubTree != null)
                {
                    if (__workflow_jABGetElementValuesearchSubTree != null)
                    {
                        jABGetElementValue["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABGetElementValuesearchSubTree);
                        jABGetElementValuepropCount++;
                    }

                    jABGetElementValuepropCount++;
                }
                else
                {
                    jABGetElementValue["SearchSubTree"] = true;
                    jABGetElementValuepropCount++;
                }

                if (__workflow_jABGetElementValuemaxRelativeDepth != null)
                {
                    if (__workflow_jABGetElementValuemaxRelativeDepth != null)
                    {
                        jABGetElementValue["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABGetElementValuemaxRelativeDepth);
                        jABGetElementValuepropCount++;
                    }

                    jABGetElementValuepropCount++;
                }
                else
                {
                    jABGetElementValue["MaxRelativeDepth"] = 0;
                    jABGetElementValuepropCount++;
                }

                if (__workflow_jABGetElementValuematchIndex != null)
                {
                    if (__workflow_jABGetElementValuematchIndex != null)
                    {
                        jABGetElementValue["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABGetElementValuematchIndex);
                        jABGetElementValuepropCount++;
                    }

                    jABGetElementValuepropCount++;
                }
                else
                {
                    jABGetElementValue["MatchIndex"] = 1;
                    jABGetElementValuepropCount++;
                }

                if (__workflow_jABGetElementValuesearchFilter != null)
                {
                    jABGetElementValue["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABGetElementValuesearchFilter);
                    jABGetElementValuepropCount++;
                }

                if (__workflow_jABGetElementValuesortByColumn != null)
                {
                    jABGetElementValue["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABGetElementValuesortByColumn);
                    jABGetElementValuepropCount++;
                }

                if (__workflow_jABGetElementValuematchIndexAscending != null)
                {
                    if (__workflow_jABGetElementValuematchIndexAscending != null)
                    {
                        jABGetElementValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABGetElementValuematchIndexAscending);
                        jABGetElementValuepropCount++;
                    }

                    jABGetElementValuepropCount++;
                }
                else
                {
                    jABGetElementValue["MatchIndexAscending"] = true;
                    jABGetElementValuepropCount++;
                }

                if (__workflow_jABGetElementValuecaseSensitiveSearch != null)
                {
                    if (__workflow_jABGetElementValuecaseSensitiveSearch != null)
                    {
                        jABGetElementValue["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetElementValuecaseSensitiveSearch);
                        jABGetElementValuepropCount++;
                    }

                    jABGetElementValuepropCount++;
                }
                else
                {
                    jABGetElementValue["CaseSensitiveSearch"] = false;
                    jABGetElementValuepropCount++;
                }

                if (__workflow_jABGetElementValueonlySearchVisibleElements != null)
                {
                    if (__workflow_jABGetElementValueonlySearchVisibleElements != null)
                    {
                        jABGetElementValue["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABGetElementValueonlySearchVisibleElements);
                        jABGetElementValuepropCount++;
                    }

                    jABGetElementValuepropCount++;
                }
                else
                {
                    jABGetElementValue["OnlySearchVisibleElements"] = true;
                    jABGetElementValuepropCount++;
                }

                if (__workflow_jABGetElementValueonlySearchShowingElements != null)
                {
                    if (__workflow_jABGetElementValueonlySearchShowingElements != null)
                    {
                        jABGetElementValue["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABGetElementValueonlySearchShowingElements);
                        jABGetElementValuepropCount++;
                    }

                    jABGetElementValuepropCount++;
                }
                else
                {
                    jABGetElementValue["OnlySearchShowingElements"] = true;
                    jABGetElementValuepropCount++;
                }

                if (__workflow_jABGetElementValueelementRolesNotToTraverse != null)
                {
                    jABGetElementValue["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABGetElementValueelementRolesNotToTraverse);
                    jABGetElementValuepropCount++;
                }

                if (__workflow_jABGetElementValuemaximumElementsToSearch != null)
                {
                    if (__workflow_jABGetElementValuemaximumElementsToSearch != null)
                    {
                        jABGetElementValue["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetElementValuemaximumElementsToSearch);
                        jABGetElementValuepropCount++;
                    }

                    jABGetElementValuepropCount++;
                }
                else
                {
                    jABGetElementValue["MaximumElementsToSearch"] = 2000;
                    jABGetElementValuepropCount++;
                }

                if (__workflow_jABGetElementValuemaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABGetElementValuemaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetElementValue["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABGetElementValuemaximumChildElementsToSearchPerNode);
                        jABGetElementValuepropCount++;
                    }

                    jABGetElementValuepropCount++;
                }
                else
                {
                    jABGetElementValue["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGetElementValuepropCount++;
                }

                jABGetElementValuepropCount++;
                jABGetElementValue["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetElementValueworkflow);
                if (jABGetElementValuepropCount > 0)
                {
                    callPayload.Body = jABGetElementValue;
                }

                return new ApiConnectionAction<JABGetElementValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABCheckElement(Expression<Func<int>> jABCheckElementsearchParentElementJABHandle, Expression<Func<string>> jABCheckElementworkflow, Expression<Func<string>> jABCheckElementsearchElementJABName = null, Expression<Func<string>> jABCheckElementsearchElementJABDescription = null, Expression<Func<string>> jABCheckElementsearchElementJABRole = null, Expression<Func<bool>> jABCheckElementsearchSubTree = null, Expression<Func<int>> jABCheckElementmaxRelativeDepth = null, Expression<Func<int>> jABCheckElementmatchIndex = null, Expression<Func<string>> jABCheckElementsearchFilter = null, Expression<Func<string>> jABCheckElementsortByColumn = null, Expression<Func<bool>> jABCheckElementmatchIndexAscending = null, Expression<Func<bool>> jABCheckElementcaseSensitiveSearch = null, Expression<Func<bool>> jABCheckElementonlySearchVisibleElements = null, Expression<Func<bool>> jABCheckElementonlySearchShowingElements = null, Expression<Func<string>> jABCheckElementelementRolesNotToTraverse = null, Expression<Func<int>> jABCheckElementmaximumElementsToSearch = null, Expression<Func<int>> jABCheckElementmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABCheckElementcheckElement = null, Expression<Func<bool>> jABCheckElementautoDetectActionName = null, Expression<Func<string>> jABCheckElementoverrideActionName = null)
        {
            var __workflow_jABCheckElementsearchParentElementJABHandle = WorkflowExpression.Compile(jABCheckElementsearchParentElementJABHandle, nameof(jABCheckElementsearchParentElementJABHandle), required: true);
            var __workflow_jABCheckElementworkflow = WorkflowExpression.Compile(jABCheckElementworkflow, nameof(jABCheckElementworkflow), required: true);
            var __workflow_jABCheckElementsearchElementJABName = WorkflowExpression.Compile(jABCheckElementsearchElementJABName, nameof(jABCheckElementsearchElementJABName), required: false);
            var __workflow_jABCheckElementsearchElementJABDescription = WorkflowExpression.Compile(jABCheckElementsearchElementJABDescription, nameof(jABCheckElementsearchElementJABDescription), required: false);
            var __workflow_jABCheckElementsearchElementJABRole = WorkflowExpression.Compile(jABCheckElementsearchElementJABRole, nameof(jABCheckElementsearchElementJABRole), required: false);
            var __workflow_jABCheckElementsearchSubTree = WorkflowExpression.Compile(jABCheckElementsearchSubTree, nameof(jABCheckElementsearchSubTree), required: false);
            var __workflow_jABCheckElementmaxRelativeDepth = WorkflowExpression.Compile(jABCheckElementmaxRelativeDepth, nameof(jABCheckElementmaxRelativeDepth), required: false);
            var __workflow_jABCheckElementmatchIndex = WorkflowExpression.Compile(jABCheckElementmatchIndex, nameof(jABCheckElementmatchIndex), required: false);
            var __workflow_jABCheckElementsearchFilter = WorkflowExpression.Compile(jABCheckElementsearchFilter, nameof(jABCheckElementsearchFilter), required: false);
            var __workflow_jABCheckElementsortByColumn = WorkflowExpression.Compile(jABCheckElementsortByColumn, nameof(jABCheckElementsortByColumn), required: false);
            var __workflow_jABCheckElementmatchIndexAscending = WorkflowExpression.Compile(jABCheckElementmatchIndexAscending, nameof(jABCheckElementmatchIndexAscending), required: false);
            var __workflow_jABCheckElementcaseSensitiveSearch = WorkflowExpression.Compile(jABCheckElementcaseSensitiveSearch, nameof(jABCheckElementcaseSensitiveSearch), required: false);
            var __workflow_jABCheckElementonlySearchVisibleElements = WorkflowExpression.Compile(jABCheckElementonlySearchVisibleElements, nameof(jABCheckElementonlySearchVisibleElements), required: false);
            var __workflow_jABCheckElementonlySearchShowingElements = WorkflowExpression.Compile(jABCheckElementonlySearchShowingElements, nameof(jABCheckElementonlySearchShowingElements), required: false);
            var __workflow_jABCheckElementelementRolesNotToTraverse = WorkflowExpression.Compile(jABCheckElementelementRolesNotToTraverse, nameof(jABCheckElementelementRolesNotToTraverse), required: false);
            var __workflow_jABCheckElementmaximumElementsToSearch = WorkflowExpression.Compile(jABCheckElementmaximumElementsToSearch, nameof(jABCheckElementmaximumElementsToSearch), required: false);
            var __workflow_jABCheckElementmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABCheckElementmaximumChildElementsToSearchPerNode, nameof(jABCheckElementmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABCheckElementcheckElement = WorkflowExpression.Compile(jABCheckElementcheckElement, nameof(jABCheckElementcheckElement), required: false);
            var __workflow_jABCheckElementautoDetectActionName = WorkflowExpression.Compile(jABCheckElementautoDetectActionName, nameof(jABCheckElementautoDetectActionName), required: false);
            var __workflow_jABCheckElementoverrideActionName = WorkflowExpression.Compile(jABCheckElementoverrideActionName, nameof(jABCheckElementoverrideActionName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABCheckElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABCheckElement = new JObject();
                var jABCheckElementpropCount = 0;
                jABCheckElementpropCount++;
                jABCheckElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABCheckElementsearchParentElementJABHandle);
                if (__workflow_jABCheckElementsearchElementJABName != null)
                {
                    jABCheckElement["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABCheckElementsearchElementJABName);
                    jABCheckElementpropCount++;
                }

                if (__workflow_jABCheckElementsearchElementJABDescription != null)
                {
                    jABCheckElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABCheckElementsearchElementJABDescription);
                    jABCheckElementpropCount++;
                }

                if (__workflow_jABCheckElementsearchElementJABRole != null)
                {
                    jABCheckElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABCheckElementsearchElementJABRole);
                    jABCheckElementpropCount++;
                }

                if (__workflow_jABCheckElementsearchSubTree != null)
                {
                    if (__workflow_jABCheckElementsearchSubTree != null)
                    {
                        jABCheckElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABCheckElementsearchSubTree);
                        jABCheckElementpropCount++;
                    }

                    jABCheckElementpropCount++;
                }
                else
                {
                    jABCheckElement["SearchSubTree"] = true;
                    jABCheckElementpropCount++;
                }

                if (__workflow_jABCheckElementmaxRelativeDepth != null)
                {
                    if (__workflow_jABCheckElementmaxRelativeDepth != null)
                    {
                        jABCheckElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABCheckElementmaxRelativeDepth);
                        jABCheckElementpropCount++;
                    }

                    jABCheckElementpropCount++;
                }
                else
                {
                    jABCheckElement["MaxRelativeDepth"] = 0;
                    jABCheckElementpropCount++;
                }

                if (__workflow_jABCheckElementmatchIndex != null)
                {
                    if (__workflow_jABCheckElementmatchIndex != null)
                    {
                        jABCheckElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABCheckElementmatchIndex);
                        jABCheckElementpropCount++;
                    }

                    jABCheckElementpropCount++;
                }
                else
                {
                    jABCheckElement["MatchIndex"] = 1;
                    jABCheckElementpropCount++;
                }

                if (__workflow_jABCheckElementsearchFilter != null)
                {
                    jABCheckElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABCheckElementsearchFilter);
                    jABCheckElementpropCount++;
                }

                if (__workflow_jABCheckElementsortByColumn != null)
                {
                    jABCheckElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABCheckElementsortByColumn);
                    jABCheckElementpropCount++;
                }

                if (__workflow_jABCheckElementmatchIndexAscending != null)
                {
                    if (__workflow_jABCheckElementmatchIndexAscending != null)
                    {
                        jABCheckElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABCheckElementmatchIndexAscending);
                        jABCheckElementpropCount++;
                    }

                    jABCheckElementpropCount++;
                }
                else
                {
                    jABCheckElement["MatchIndexAscending"] = true;
                    jABCheckElementpropCount++;
                }

                if (__workflow_jABCheckElementcaseSensitiveSearch != null)
                {
                    if (__workflow_jABCheckElementcaseSensitiveSearch != null)
                    {
                        jABCheckElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABCheckElementcaseSensitiveSearch);
                        jABCheckElementpropCount++;
                    }

                    jABCheckElementpropCount++;
                }
                else
                {
                    jABCheckElement["CaseSensitiveSearch"] = false;
                    jABCheckElementpropCount++;
                }

                if (__workflow_jABCheckElementonlySearchVisibleElements != null)
                {
                    if (__workflow_jABCheckElementonlySearchVisibleElements != null)
                    {
                        jABCheckElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABCheckElementonlySearchVisibleElements);
                        jABCheckElementpropCount++;
                    }

                    jABCheckElementpropCount++;
                }
                else
                {
                    jABCheckElement["OnlySearchVisibleElements"] = true;
                    jABCheckElementpropCount++;
                }

                if (__workflow_jABCheckElementonlySearchShowingElements != null)
                {
                    if (__workflow_jABCheckElementonlySearchShowingElements != null)
                    {
                        jABCheckElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABCheckElementonlySearchShowingElements);
                        jABCheckElementpropCount++;
                    }

                    jABCheckElementpropCount++;
                }
                else
                {
                    jABCheckElement["OnlySearchShowingElements"] = true;
                    jABCheckElementpropCount++;
                }

                if (__workflow_jABCheckElementelementRolesNotToTraverse != null)
                {
                    jABCheckElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABCheckElementelementRolesNotToTraverse);
                    jABCheckElementpropCount++;
                }

                if (__workflow_jABCheckElementmaximumElementsToSearch != null)
                {
                    if (__workflow_jABCheckElementmaximumElementsToSearch != null)
                    {
                        jABCheckElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABCheckElementmaximumElementsToSearch);
                        jABCheckElementpropCount++;
                    }

                    jABCheckElementpropCount++;
                }
                else
                {
                    jABCheckElement["MaximumElementsToSearch"] = 2000;
                    jABCheckElementpropCount++;
                }

                if (__workflow_jABCheckElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABCheckElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABCheckElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABCheckElementmaximumChildElementsToSearchPerNode);
                        jABCheckElementpropCount++;
                    }

                    jABCheckElementpropCount++;
                }
                else
                {
                    jABCheckElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABCheckElementpropCount++;
                }

                if (__workflow_jABCheckElementcheckElement != null)
                {
                    if (__workflow_jABCheckElementcheckElement != null)
                    {
                        jABCheckElement["CheckElement"] = ExpressionConverter.ConvertO(__workflow_jABCheckElementcheckElement);
                        jABCheckElementpropCount++;
                    }

                    jABCheckElementpropCount++;
                }
                else
                {
                    jABCheckElement["CheckElement"] = true;
                    jABCheckElementpropCount++;
                }

                if (__workflow_jABCheckElementautoDetectActionName != null)
                {
                    if (__workflow_jABCheckElementautoDetectActionName != null)
                    {
                        jABCheckElement["AutoDetectActionName"] = ExpressionConverter.ConvertO(__workflow_jABCheckElementautoDetectActionName);
                        jABCheckElementpropCount++;
                    }

                    jABCheckElementpropCount++;
                }
                else
                {
                    jABCheckElement["AutoDetectActionName"] = true;
                    jABCheckElementpropCount++;
                }

                if (__workflow_jABCheckElementoverrideActionName != null)
                {
                    jABCheckElement["OverrideActionName"] = ExpressionConverter.ConvertO(__workflow_jABCheckElementoverrideActionName);
                    jABCheckElementpropCount++;
                }

                jABCheckElementpropCount++;
                jABCheckElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABCheckElementworkflow);
                if (jABCheckElementpropCount > 0)
                {
                    callPayload.Body = jABCheckElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetElementPropertiesAsListResponse> JABGetElementPropertiesAsList(Expression<Func<int>> jABGetElementPropertiesAsListsearchParentElementJABHandle, Expression<Func<string>> jABGetElementPropertiesAsListworkflow, Expression<Func<string>> jABGetElementPropertiesAsListsearchElementJABName = null, Expression<Func<string>> jABGetElementPropertiesAsListsearchElementJABDescription = null, Expression<Func<string>> jABGetElementPropertiesAsListsearchElementJABRole = null, Expression<Func<bool>> jABGetElementPropertiesAsListsearchSubTree = null, Expression<Func<int>> jABGetElementPropertiesAsListmaxRelativeDepth = null, Expression<Func<int>> jABGetElementPropertiesAsListmatchIndex = null, Expression<Func<string>> jABGetElementPropertiesAsListsearchFilter = null, Expression<Func<string>> jABGetElementPropertiesAsListsortByColumn = null, Expression<Func<bool>> jABGetElementPropertiesAsListmatchIndexAscending = null, Expression<Func<bool>> jABGetElementPropertiesAsListcaseSensitiveSearch = null, Expression<Func<bool>> jABGetElementPropertiesAsListonlySearchVisibleElements = null, Expression<Func<bool>> jABGetElementPropertiesAsListonlySearchShowingElements = null, Expression<Func<string>> jABGetElementPropertiesAsListelementRolesNotToTraverse = null, Expression<Func<int>> jABGetElementPropertiesAsListmaximumElementsToSearch = null, Expression<Func<int>> jABGetElementPropertiesAsListmaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABGetElementPropertiesAsListmaxStringLength = null)
        {
            var __workflow_jABGetElementPropertiesAsListsearchParentElementJABHandle = WorkflowExpression.Compile(jABGetElementPropertiesAsListsearchParentElementJABHandle, nameof(jABGetElementPropertiesAsListsearchParentElementJABHandle), required: true);
            var __workflow_jABGetElementPropertiesAsListworkflow = WorkflowExpression.Compile(jABGetElementPropertiesAsListworkflow, nameof(jABGetElementPropertiesAsListworkflow), required: true);
            var __workflow_jABGetElementPropertiesAsListsearchElementJABName = WorkflowExpression.Compile(jABGetElementPropertiesAsListsearchElementJABName, nameof(jABGetElementPropertiesAsListsearchElementJABName), required: false);
            var __workflow_jABGetElementPropertiesAsListsearchElementJABDescription = WorkflowExpression.Compile(jABGetElementPropertiesAsListsearchElementJABDescription, nameof(jABGetElementPropertiesAsListsearchElementJABDescription), required: false);
            var __workflow_jABGetElementPropertiesAsListsearchElementJABRole = WorkflowExpression.Compile(jABGetElementPropertiesAsListsearchElementJABRole, nameof(jABGetElementPropertiesAsListsearchElementJABRole), required: false);
            var __workflow_jABGetElementPropertiesAsListsearchSubTree = WorkflowExpression.Compile(jABGetElementPropertiesAsListsearchSubTree, nameof(jABGetElementPropertiesAsListsearchSubTree), required: false);
            var __workflow_jABGetElementPropertiesAsListmaxRelativeDepth = WorkflowExpression.Compile(jABGetElementPropertiesAsListmaxRelativeDepth, nameof(jABGetElementPropertiesAsListmaxRelativeDepth), required: false);
            var __workflow_jABGetElementPropertiesAsListmatchIndex = WorkflowExpression.Compile(jABGetElementPropertiesAsListmatchIndex, nameof(jABGetElementPropertiesAsListmatchIndex), required: false);
            var __workflow_jABGetElementPropertiesAsListsearchFilter = WorkflowExpression.Compile(jABGetElementPropertiesAsListsearchFilter, nameof(jABGetElementPropertiesAsListsearchFilter), required: false);
            var __workflow_jABGetElementPropertiesAsListsortByColumn = WorkflowExpression.Compile(jABGetElementPropertiesAsListsortByColumn, nameof(jABGetElementPropertiesAsListsortByColumn), required: false);
            var __workflow_jABGetElementPropertiesAsListmatchIndexAscending = WorkflowExpression.Compile(jABGetElementPropertiesAsListmatchIndexAscending, nameof(jABGetElementPropertiesAsListmatchIndexAscending), required: false);
            var __workflow_jABGetElementPropertiesAsListcaseSensitiveSearch = WorkflowExpression.Compile(jABGetElementPropertiesAsListcaseSensitiveSearch, nameof(jABGetElementPropertiesAsListcaseSensitiveSearch), required: false);
            var __workflow_jABGetElementPropertiesAsListonlySearchVisibleElements = WorkflowExpression.Compile(jABGetElementPropertiesAsListonlySearchVisibleElements, nameof(jABGetElementPropertiesAsListonlySearchVisibleElements), required: false);
            var __workflow_jABGetElementPropertiesAsListonlySearchShowingElements = WorkflowExpression.Compile(jABGetElementPropertiesAsListonlySearchShowingElements, nameof(jABGetElementPropertiesAsListonlySearchShowingElements), required: false);
            var __workflow_jABGetElementPropertiesAsListelementRolesNotToTraverse = WorkflowExpression.Compile(jABGetElementPropertiesAsListelementRolesNotToTraverse, nameof(jABGetElementPropertiesAsListelementRolesNotToTraverse), required: false);
            var __workflow_jABGetElementPropertiesAsListmaximumElementsToSearch = WorkflowExpression.Compile(jABGetElementPropertiesAsListmaximumElementsToSearch, nameof(jABGetElementPropertiesAsListmaximumElementsToSearch), required: false);
            var __workflow_jABGetElementPropertiesAsListmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABGetElementPropertiesAsListmaximumChildElementsToSearchPerNode, nameof(jABGetElementPropertiesAsListmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABGetElementPropertiesAsListmaxStringLength = WorkflowExpression.Compile(jABGetElementPropertiesAsListmaxStringLength, nameof(jABGetElementPropertiesAsListmaxStringLength), required: false);
            return new DeferredBodyAction<JABGetElementPropertiesAsListResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetElementPropertiesAsList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetElementPropertiesAsList = new JObject();
                var jABGetElementPropertiesAsListpropCount = 0;
                jABGetElementPropertiesAsListpropCount++;
                jABGetElementPropertiesAsList["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGetElementPropertiesAsListsearchParentElementJABHandle);
                if (__workflow_jABGetElementPropertiesAsListsearchElementJABName != null)
                {
                    jABGetElementPropertiesAsList["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABGetElementPropertiesAsListsearchElementJABName);
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (__workflow_jABGetElementPropertiesAsListsearchElementJABDescription != null)
                {
                    jABGetElementPropertiesAsList["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABGetElementPropertiesAsListsearchElementJABDescription);
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (__workflow_jABGetElementPropertiesAsListsearchElementJABRole != null)
                {
                    jABGetElementPropertiesAsList["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABGetElementPropertiesAsListsearchElementJABRole);
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (__workflow_jABGetElementPropertiesAsListsearchSubTree != null)
                {
                    if (__workflow_jABGetElementPropertiesAsListsearchSubTree != null)
                    {
                        jABGetElementPropertiesAsList["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABGetElementPropertiesAsListsearchSubTree);
                        jABGetElementPropertiesAsListpropCount++;
                    }

                    jABGetElementPropertiesAsListpropCount++;
                }
                else
                {
                    jABGetElementPropertiesAsList["SearchSubTree"] = true;
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (__workflow_jABGetElementPropertiesAsListmaxRelativeDepth != null)
                {
                    if (__workflow_jABGetElementPropertiesAsListmaxRelativeDepth != null)
                    {
                        jABGetElementPropertiesAsList["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABGetElementPropertiesAsListmaxRelativeDepth);
                        jABGetElementPropertiesAsListpropCount++;
                    }

                    jABGetElementPropertiesAsListpropCount++;
                }
                else
                {
                    jABGetElementPropertiesAsList["MaxRelativeDepth"] = 0;
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (__workflow_jABGetElementPropertiesAsListmatchIndex != null)
                {
                    if (__workflow_jABGetElementPropertiesAsListmatchIndex != null)
                    {
                        jABGetElementPropertiesAsList["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABGetElementPropertiesAsListmatchIndex);
                        jABGetElementPropertiesAsListpropCount++;
                    }

                    jABGetElementPropertiesAsListpropCount++;
                }
                else
                {
                    jABGetElementPropertiesAsList["MatchIndex"] = 1;
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (__workflow_jABGetElementPropertiesAsListsearchFilter != null)
                {
                    jABGetElementPropertiesAsList["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABGetElementPropertiesAsListsearchFilter);
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (__workflow_jABGetElementPropertiesAsListsortByColumn != null)
                {
                    jABGetElementPropertiesAsList["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABGetElementPropertiesAsListsortByColumn);
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (__workflow_jABGetElementPropertiesAsListmatchIndexAscending != null)
                {
                    if (__workflow_jABGetElementPropertiesAsListmatchIndexAscending != null)
                    {
                        jABGetElementPropertiesAsList["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABGetElementPropertiesAsListmatchIndexAscending);
                        jABGetElementPropertiesAsListpropCount++;
                    }

                    jABGetElementPropertiesAsListpropCount++;
                }
                else
                {
                    jABGetElementPropertiesAsList["MatchIndexAscending"] = true;
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (__workflow_jABGetElementPropertiesAsListcaseSensitiveSearch != null)
                {
                    if (__workflow_jABGetElementPropertiesAsListcaseSensitiveSearch != null)
                    {
                        jABGetElementPropertiesAsList["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetElementPropertiesAsListcaseSensitiveSearch);
                        jABGetElementPropertiesAsListpropCount++;
                    }

                    jABGetElementPropertiesAsListpropCount++;
                }
                else
                {
                    jABGetElementPropertiesAsList["CaseSensitiveSearch"] = false;
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (__workflow_jABGetElementPropertiesAsListonlySearchVisibleElements != null)
                {
                    if (__workflow_jABGetElementPropertiesAsListonlySearchVisibleElements != null)
                    {
                        jABGetElementPropertiesAsList["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABGetElementPropertiesAsListonlySearchVisibleElements);
                        jABGetElementPropertiesAsListpropCount++;
                    }

                    jABGetElementPropertiesAsListpropCount++;
                }
                else
                {
                    jABGetElementPropertiesAsList["OnlySearchVisibleElements"] = true;
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (__workflow_jABGetElementPropertiesAsListonlySearchShowingElements != null)
                {
                    if (__workflow_jABGetElementPropertiesAsListonlySearchShowingElements != null)
                    {
                        jABGetElementPropertiesAsList["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABGetElementPropertiesAsListonlySearchShowingElements);
                        jABGetElementPropertiesAsListpropCount++;
                    }

                    jABGetElementPropertiesAsListpropCount++;
                }
                else
                {
                    jABGetElementPropertiesAsList["OnlySearchShowingElements"] = true;
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (__workflow_jABGetElementPropertiesAsListelementRolesNotToTraverse != null)
                {
                    jABGetElementPropertiesAsList["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABGetElementPropertiesAsListelementRolesNotToTraverse);
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (__workflow_jABGetElementPropertiesAsListmaximumElementsToSearch != null)
                {
                    if (__workflow_jABGetElementPropertiesAsListmaximumElementsToSearch != null)
                    {
                        jABGetElementPropertiesAsList["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetElementPropertiesAsListmaximumElementsToSearch);
                        jABGetElementPropertiesAsListpropCount++;
                    }

                    jABGetElementPropertiesAsListpropCount++;
                }
                else
                {
                    jABGetElementPropertiesAsList["MaximumElementsToSearch"] = 2000;
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (__workflow_jABGetElementPropertiesAsListmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABGetElementPropertiesAsListmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetElementPropertiesAsList["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABGetElementPropertiesAsListmaximumChildElementsToSearchPerNode);
                        jABGetElementPropertiesAsListpropCount++;
                    }

                    jABGetElementPropertiesAsListpropCount++;
                }
                else
                {
                    jABGetElementPropertiesAsList["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (__workflow_jABGetElementPropertiesAsListmaxStringLength != null)
                {
                    if (__workflow_jABGetElementPropertiesAsListmaxStringLength != null)
                    {
                        jABGetElementPropertiesAsList["MaxStringLength"] = ExpressionConverter.ConvertO(__workflow_jABGetElementPropertiesAsListmaxStringLength);
                        jABGetElementPropertiesAsListpropCount++;
                    }

                    jABGetElementPropertiesAsListpropCount++;
                }
                else
                {
                    jABGetElementPropertiesAsList["MaxStringLength"] = 0;
                    jABGetElementPropertiesAsListpropCount++;
                }

                jABGetElementPropertiesAsListpropCount++;
                jABGetElementPropertiesAsList["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetElementPropertiesAsListworkflow);
                if (jABGetElementPropertiesAsListpropCount > 0)
                {
                    callPayload.Body = jABGetElementPropertiesAsList;
                }

                return new ApiConnectionAction<JABGetElementPropertiesAsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalInputPasswordIntoElement(Expression<Func<int>> jABGlobalInputPasswordIntoElementsearchParentElementJABHandle, Expression<Func<string>> jABGlobalInputPasswordIntoElementpasswordToInput, Expression<Func<string>> jABGlobalInputPasswordIntoElementworkflow, Expression<Func<string>> jABGlobalInputPasswordIntoElementsearchElementJABName = null, Expression<Func<string>> jABGlobalInputPasswordIntoElementsearchElementJABDescription = null, Expression<Func<string>> jABGlobalInputPasswordIntoElementsearchElementJABRole = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementsearchSubTree = null, Expression<Func<int>> jABGlobalInputPasswordIntoElementmaxRelativeDepth = null, Expression<Func<int>> jABGlobalInputPasswordIntoElementmatchIndex = null, Expression<Func<string>> jABGlobalInputPasswordIntoElementsearchFilter = null, Expression<Func<string>> jABGlobalInputPasswordIntoElementsortByColumn = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementmatchIndexAscending = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementcaseSensitiveSearch = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementonlySearchVisibleElements = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementonlySearchShowingElements = null, Expression<Func<string>> jABGlobalInputPasswordIntoElementelementRolesNotToTraverse = null, Expression<Func<int>> jABGlobalInputPasswordIntoElementmaximumElementsToSearch = null, Expression<Func<int>> jABGlobalInputPasswordIntoElementmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementfocusElement = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementglobalMouseClickOnElement = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementreplaceExistingValueUsingDoubleClickDelete = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementreplaceExistingValueUsingCTRLADelete = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementsendKeyEvents = null, Expression<Func<int>> jABGlobalInputPasswordIntoElementkeyIntervalInMilliseconds = null, Expression<Func<int>> jABGlobalInputPasswordIntoElementdoubleClickIntervalInMilliseconds = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementdontInterpretSymbols = null)
        {
            var __workflow_jABGlobalInputPasswordIntoElementsearchParentElementJABHandle = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementsearchParentElementJABHandle, nameof(jABGlobalInputPasswordIntoElementsearchParentElementJABHandle), required: true);
            var __workflow_jABGlobalInputPasswordIntoElementpasswordToInput = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementpasswordToInput, nameof(jABGlobalInputPasswordIntoElementpasswordToInput), required: true);
            var __workflow_jABGlobalInputPasswordIntoElementworkflow = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementworkflow, nameof(jABGlobalInputPasswordIntoElementworkflow), required: true);
            var __workflow_jABGlobalInputPasswordIntoElementsearchElementJABName = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementsearchElementJABName, nameof(jABGlobalInputPasswordIntoElementsearchElementJABName), required: false);
            var __workflow_jABGlobalInputPasswordIntoElementsearchElementJABDescription = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementsearchElementJABDescription, nameof(jABGlobalInputPasswordIntoElementsearchElementJABDescription), required: false);
            var __workflow_jABGlobalInputPasswordIntoElementsearchElementJABRole = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementsearchElementJABRole, nameof(jABGlobalInputPasswordIntoElementsearchElementJABRole), required: false);
            var __workflow_jABGlobalInputPasswordIntoElementsearchSubTree = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementsearchSubTree, nameof(jABGlobalInputPasswordIntoElementsearchSubTree), required: false);
            var __workflow_jABGlobalInputPasswordIntoElementmaxRelativeDepth = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementmaxRelativeDepth, nameof(jABGlobalInputPasswordIntoElementmaxRelativeDepth), required: false);
            var __workflow_jABGlobalInputPasswordIntoElementmatchIndex = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementmatchIndex, nameof(jABGlobalInputPasswordIntoElementmatchIndex), required: false);
            var __workflow_jABGlobalInputPasswordIntoElementsearchFilter = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementsearchFilter, nameof(jABGlobalInputPasswordIntoElementsearchFilter), required: false);
            var __workflow_jABGlobalInputPasswordIntoElementsortByColumn = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementsortByColumn, nameof(jABGlobalInputPasswordIntoElementsortByColumn), required: false);
            var __workflow_jABGlobalInputPasswordIntoElementmatchIndexAscending = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementmatchIndexAscending, nameof(jABGlobalInputPasswordIntoElementmatchIndexAscending), required: false);
            var __workflow_jABGlobalInputPasswordIntoElementcaseSensitiveSearch = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementcaseSensitiveSearch, nameof(jABGlobalInputPasswordIntoElementcaseSensitiveSearch), required: false);
            var __workflow_jABGlobalInputPasswordIntoElementonlySearchVisibleElements = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementonlySearchVisibleElements, nameof(jABGlobalInputPasswordIntoElementonlySearchVisibleElements), required: false);
            var __workflow_jABGlobalInputPasswordIntoElementonlySearchShowingElements = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementonlySearchShowingElements, nameof(jABGlobalInputPasswordIntoElementonlySearchShowingElements), required: false);
            var __workflow_jABGlobalInputPasswordIntoElementelementRolesNotToTraverse = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementelementRolesNotToTraverse, nameof(jABGlobalInputPasswordIntoElementelementRolesNotToTraverse), required: false);
            var __workflow_jABGlobalInputPasswordIntoElementmaximumElementsToSearch = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementmaximumElementsToSearch, nameof(jABGlobalInputPasswordIntoElementmaximumElementsToSearch), required: false);
            var __workflow_jABGlobalInputPasswordIntoElementmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementmaximumChildElementsToSearchPerNode, nameof(jABGlobalInputPasswordIntoElementmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABGlobalInputPasswordIntoElementfocusElement = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementfocusElement, nameof(jABGlobalInputPasswordIntoElementfocusElement), required: false);
            var __workflow_jABGlobalInputPasswordIntoElementglobalMouseClickOnElement = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementglobalMouseClickOnElement, nameof(jABGlobalInputPasswordIntoElementglobalMouseClickOnElement), required: false);
            var __workflow_jABGlobalInputPasswordIntoElementreplaceExistingValueUsingDoubleClickDelete = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementreplaceExistingValueUsingDoubleClickDelete, nameof(jABGlobalInputPasswordIntoElementreplaceExistingValueUsingDoubleClickDelete), required: false);
            var __workflow_jABGlobalInputPasswordIntoElementreplaceExistingValueUsingCTRLADelete = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementreplaceExistingValueUsingCTRLADelete, nameof(jABGlobalInputPasswordIntoElementreplaceExistingValueUsingCTRLADelete), required: false);
            var __workflow_jABGlobalInputPasswordIntoElementsendKeyEvents = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementsendKeyEvents, nameof(jABGlobalInputPasswordIntoElementsendKeyEvents), required: false);
            var __workflow_jABGlobalInputPasswordIntoElementkeyIntervalInMilliseconds = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementkeyIntervalInMilliseconds, nameof(jABGlobalInputPasswordIntoElementkeyIntervalInMilliseconds), required: false);
            var __workflow_jABGlobalInputPasswordIntoElementdoubleClickIntervalInMilliseconds = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementdoubleClickIntervalInMilliseconds, nameof(jABGlobalInputPasswordIntoElementdoubleClickIntervalInMilliseconds), required: false);
            var __workflow_jABGlobalInputPasswordIntoElementdontInterpretSymbols = WorkflowExpression.Compile(jABGlobalInputPasswordIntoElementdontInterpretSymbols, nameof(jABGlobalInputPasswordIntoElementdontInterpretSymbols), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalInputPasswordIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGlobalInputPasswordIntoElement = new JObject();
                var jABGlobalInputPasswordIntoElementpropCount = 0;
                jABGlobalInputPasswordIntoElementpropCount++;
                jABGlobalInputPasswordIntoElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementsearchParentElementJABHandle);
                if (__workflow_jABGlobalInputPasswordIntoElementsearchElementJABName != null)
                {
                    jABGlobalInputPasswordIntoElement["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementsearchElementJABName);
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputPasswordIntoElementsearchElementJABDescription != null)
                {
                    jABGlobalInputPasswordIntoElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementsearchElementJABDescription);
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputPasswordIntoElementsearchElementJABRole != null)
                {
                    jABGlobalInputPasswordIntoElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementsearchElementJABRole);
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputPasswordIntoElementsearchSubTree != null)
                {
                    if (__workflow_jABGlobalInputPasswordIntoElementsearchSubTree != null)
                    {
                        jABGlobalInputPasswordIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementsearchSubTree);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["SearchSubTree"] = true;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputPasswordIntoElementmaxRelativeDepth != null)
                {
                    if (__workflow_jABGlobalInputPasswordIntoElementmaxRelativeDepth != null)
                    {
                        jABGlobalInputPasswordIntoElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementmaxRelativeDepth);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["MaxRelativeDepth"] = 0;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputPasswordIntoElementmatchIndex != null)
                {
                    if (__workflow_jABGlobalInputPasswordIntoElementmatchIndex != null)
                    {
                        jABGlobalInputPasswordIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementmatchIndex);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["MatchIndex"] = 1;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputPasswordIntoElementsearchFilter != null)
                {
                    jABGlobalInputPasswordIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementsearchFilter);
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputPasswordIntoElementsortByColumn != null)
                {
                    jABGlobalInputPasswordIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementsortByColumn);
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputPasswordIntoElementmatchIndexAscending != null)
                {
                    if (__workflow_jABGlobalInputPasswordIntoElementmatchIndexAscending != null)
                    {
                        jABGlobalInputPasswordIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementmatchIndexAscending);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["MatchIndexAscending"] = true;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputPasswordIntoElementcaseSensitiveSearch != null)
                {
                    if (__workflow_jABGlobalInputPasswordIntoElementcaseSensitiveSearch != null)
                    {
                        jABGlobalInputPasswordIntoElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementcaseSensitiveSearch);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["CaseSensitiveSearch"] = false;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputPasswordIntoElementonlySearchVisibleElements != null)
                {
                    if (__workflow_jABGlobalInputPasswordIntoElementonlySearchVisibleElements != null)
                    {
                        jABGlobalInputPasswordIntoElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementonlySearchVisibleElements);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["OnlySearchVisibleElements"] = true;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputPasswordIntoElementonlySearchShowingElements != null)
                {
                    if (__workflow_jABGlobalInputPasswordIntoElementonlySearchShowingElements != null)
                    {
                        jABGlobalInputPasswordIntoElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementonlySearchShowingElements);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["OnlySearchShowingElements"] = true;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputPasswordIntoElementelementRolesNotToTraverse != null)
                {
                    jABGlobalInputPasswordIntoElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementelementRolesNotToTraverse);
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputPasswordIntoElementmaximumElementsToSearch != null)
                {
                    if (__workflow_jABGlobalInputPasswordIntoElementmaximumElementsToSearch != null)
                    {
                        jABGlobalInputPasswordIntoElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementmaximumElementsToSearch);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["MaximumElementsToSearch"] = 2000;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputPasswordIntoElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABGlobalInputPasswordIntoElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGlobalInputPasswordIntoElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementmaximumChildElementsToSearchPerNode);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputPasswordIntoElementfocusElement != null)
                {
                    if (__workflow_jABGlobalInputPasswordIntoElementfocusElement != null)
                    {
                        jABGlobalInputPasswordIntoElement["FocusElement"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementfocusElement);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["FocusElement"] = true;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputPasswordIntoElementglobalMouseClickOnElement != null)
                {
                    if (__workflow_jABGlobalInputPasswordIntoElementglobalMouseClickOnElement != null)
                    {
                        jABGlobalInputPasswordIntoElement["GlobalMouseClickOnElement"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementglobalMouseClickOnElement);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["GlobalMouseClickOnElement"] = true;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputPasswordIntoElementreplaceExistingValueUsingDoubleClickDelete != null)
                {
                    if (__workflow_jABGlobalInputPasswordIntoElementreplaceExistingValueUsingDoubleClickDelete != null)
                    {
                        jABGlobalInputPasswordIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementreplaceExistingValueUsingDoubleClickDelete);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = false;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputPasswordIntoElementreplaceExistingValueUsingCTRLADelete != null)
                {
                    if (__workflow_jABGlobalInputPasswordIntoElementreplaceExistingValueUsingCTRLADelete != null)
                    {
                        jABGlobalInputPasswordIntoElement["ReplaceExistingValueUsingCTRLADelete"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementreplaceExistingValueUsingCTRLADelete);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["ReplaceExistingValueUsingCTRLADelete"] = false;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                jABGlobalInputPasswordIntoElementpropCount++;
                jABGlobalInputPasswordIntoElement["PasswordToInput"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementpasswordToInput);
                if (__workflow_jABGlobalInputPasswordIntoElementsendKeyEvents != null)
                {
                    if (__workflow_jABGlobalInputPasswordIntoElementsendKeyEvents != null)
                    {
                        jABGlobalInputPasswordIntoElement["SendKeyEvents"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementsendKeyEvents);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["SendKeyEvents"] = false;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputPasswordIntoElementkeyIntervalInMilliseconds != null)
                {
                    if (__workflow_jABGlobalInputPasswordIntoElementkeyIntervalInMilliseconds != null)
                    {
                        jABGlobalInputPasswordIntoElement["KeyIntervalInMilliseconds"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementkeyIntervalInMilliseconds);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["KeyIntervalInMilliseconds"] = 10;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputPasswordIntoElementdoubleClickIntervalInMilliseconds != null)
                {
                    if (__workflow_jABGlobalInputPasswordIntoElementdoubleClickIntervalInMilliseconds != null)
                    {
                        jABGlobalInputPasswordIntoElement["DoubleClickIntervalInMilliseconds"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementdoubleClickIntervalInMilliseconds);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["DoubleClickIntervalInMilliseconds"] = 10;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputPasswordIntoElementdontInterpretSymbols != null)
                {
                    if (__workflow_jABGlobalInputPasswordIntoElementdontInterpretSymbols != null)
                    {
                        jABGlobalInputPasswordIntoElement["DontInterpretSymbols"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementdontInterpretSymbols);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["DontInterpretSymbols"] = false;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                jABGlobalInputPasswordIntoElementpropCount++;
                jABGlobalInputPasswordIntoElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputPasswordIntoElementworkflow);
                if (jABGlobalInputPasswordIntoElementpropCount > 0)
                {
                    callPayload.Body = jABGlobalInputPasswordIntoElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalInputTextIntoElement(Expression<Func<int>> jABGlobalInputTextIntoElementsearchParentElementJABHandle, Expression<Func<string>> jABGlobalInputTextIntoElementworkflow, Expression<Func<string>> jABGlobalInputTextIntoElementsearchElementJABName = null, Expression<Func<string>> jABGlobalInputTextIntoElementsearchElementJABDescription = null, Expression<Func<string>> jABGlobalInputTextIntoElementsearchElementJABRole = null, Expression<Func<bool>> jABGlobalInputTextIntoElementsearchSubTree = null, Expression<Func<int>> jABGlobalInputTextIntoElementmaxRelativeDepth = null, Expression<Func<int>> jABGlobalInputTextIntoElementmatchIndex = null, Expression<Func<string>> jABGlobalInputTextIntoElementsearchFilter = null, Expression<Func<string>> jABGlobalInputTextIntoElementsortByColumn = null, Expression<Func<bool>> jABGlobalInputTextIntoElementmatchIndexAscending = null, Expression<Func<bool>> jABGlobalInputTextIntoElementcaseSensitiveSearch = null, Expression<Func<bool>> jABGlobalInputTextIntoElementonlySearchVisibleElements = null, Expression<Func<bool>> jABGlobalInputTextIntoElementonlySearchShowingElements = null, Expression<Func<string>> jABGlobalInputTextIntoElementelementRolesNotToTraverse = null, Expression<Func<int>> jABGlobalInputTextIntoElementmaximumElementsToSearch = null, Expression<Func<int>> jABGlobalInputTextIntoElementmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGlobalInputTextIntoElementfocusElement = null, Expression<Func<bool>> jABGlobalInputTextIntoElementglobalMouseClickOnElement = null, Expression<Func<bool>> jABGlobalInputTextIntoElementreplaceExistingValueUsingDoubleClickDelete = null, Expression<Func<bool>> jABGlobalInputTextIntoElementreplaceExistingValueUsingCTRLADelete = null, Expression<Func<string>> jABGlobalInputTextIntoElementtextToInput = null, Expression<Func<bool>> jABGlobalInputTextIntoElementsendKeyEvents = null, Expression<Func<int>> jABGlobalInputTextIntoElementkeyIntervalInMilliseconds = null, Expression<Func<int>> jABGlobalInputTextIntoElementdoubleClickIntervalInMilliseconds = null, Expression<Func<bool>> jABGlobalInputTextIntoElementdontInterpretSymbols = null)
        {
            var __workflow_jABGlobalInputTextIntoElementsearchParentElementJABHandle = WorkflowExpression.Compile(jABGlobalInputTextIntoElementsearchParentElementJABHandle, nameof(jABGlobalInputTextIntoElementsearchParentElementJABHandle), required: true);
            var __workflow_jABGlobalInputTextIntoElementworkflow = WorkflowExpression.Compile(jABGlobalInputTextIntoElementworkflow, nameof(jABGlobalInputTextIntoElementworkflow), required: true);
            var __workflow_jABGlobalInputTextIntoElementsearchElementJABName = WorkflowExpression.Compile(jABGlobalInputTextIntoElementsearchElementJABName, nameof(jABGlobalInputTextIntoElementsearchElementJABName), required: false);
            var __workflow_jABGlobalInputTextIntoElementsearchElementJABDescription = WorkflowExpression.Compile(jABGlobalInputTextIntoElementsearchElementJABDescription, nameof(jABGlobalInputTextIntoElementsearchElementJABDescription), required: false);
            var __workflow_jABGlobalInputTextIntoElementsearchElementJABRole = WorkflowExpression.Compile(jABGlobalInputTextIntoElementsearchElementJABRole, nameof(jABGlobalInputTextIntoElementsearchElementJABRole), required: false);
            var __workflow_jABGlobalInputTextIntoElementsearchSubTree = WorkflowExpression.Compile(jABGlobalInputTextIntoElementsearchSubTree, nameof(jABGlobalInputTextIntoElementsearchSubTree), required: false);
            var __workflow_jABGlobalInputTextIntoElementmaxRelativeDepth = WorkflowExpression.Compile(jABGlobalInputTextIntoElementmaxRelativeDepth, nameof(jABGlobalInputTextIntoElementmaxRelativeDepth), required: false);
            var __workflow_jABGlobalInputTextIntoElementmatchIndex = WorkflowExpression.Compile(jABGlobalInputTextIntoElementmatchIndex, nameof(jABGlobalInputTextIntoElementmatchIndex), required: false);
            var __workflow_jABGlobalInputTextIntoElementsearchFilter = WorkflowExpression.Compile(jABGlobalInputTextIntoElementsearchFilter, nameof(jABGlobalInputTextIntoElementsearchFilter), required: false);
            var __workflow_jABGlobalInputTextIntoElementsortByColumn = WorkflowExpression.Compile(jABGlobalInputTextIntoElementsortByColumn, nameof(jABGlobalInputTextIntoElementsortByColumn), required: false);
            var __workflow_jABGlobalInputTextIntoElementmatchIndexAscending = WorkflowExpression.Compile(jABGlobalInputTextIntoElementmatchIndexAscending, nameof(jABGlobalInputTextIntoElementmatchIndexAscending), required: false);
            var __workflow_jABGlobalInputTextIntoElementcaseSensitiveSearch = WorkflowExpression.Compile(jABGlobalInputTextIntoElementcaseSensitiveSearch, nameof(jABGlobalInputTextIntoElementcaseSensitiveSearch), required: false);
            var __workflow_jABGlobalInputTextIntoElementonlySearchVisibleElements = WorkflowExpression.Compile(jABGlobalInputTextIntoElementonlySearchVisibleElements, nameof(jABGlobalInputTextIntoElementonlySearchVisibleElements), required: false);
            var __workflow_jABGlobalInputTextIntoElementonlySearchShowingElements = WorkflowExpression.Compile(jABGlobalInputTextIntoElementonlySearchShowingElements, nameof(jABGlobalInputTextIntoElementonlySearchShowingElements), required: false);
            var __workflow_jABGlobalInputTextIntoElementelementRolesNotToTraverse = WorkflowExpression.Compile(jABGlobalInputTextIntoElementelementRolesNotToTraverse, nameof(jABGlobalInputTextIntoElementelementRolesNotToTraverse), required: false);
            var __workflow_jABGlobalInputTextIntoElementmaximumElementsToSearch = WorkflowExpression.Compile(jABGlobalInputTextIntoElementmaximumElementsToSearch, nameof(jABGlobalInputTextIntoElementmaximumElementsToSearch), required: false);
            var __workflow_jABGlobalInputTextIntoElementmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABGlobalInputTextIntoElementmaximumChildElementsToSearchPerNode, nameof(jABGlobalInputTextIntoElementmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABGlobalInputTextIntoElementfocusElement = WorkflowExpression.Compile(jABGlobalInputTextIntoElementfocusElement, nameof(jABGlobalInputTextIntoElementfocusElement), required: false);
            var __workflow_jABGlobalInputTextIntoElementglobalMouseClickOnElement = WorkflowExpression.Compile(jABGlobalInputTextIntoElementglobalMouseClickOnElement, nameof(jABGlobalInputTextIntoElementglobalMouseClickOnElement), required: false);
            var __workflow_jABGlobalInputTextIntoElementreplaceExistingValueUsingDoubleClickDelete = WorkflowExpression.Compile(jABGlobalInputTextIntoElementreplaceExistingValueUsingDoubleClickDelete, nameof(jABGlobalInputTextIntoElementreplaceExistingValueUsingDoubleClickDelete), required: false);
            var __workflow_jABGlobalInputTextIntoElementreplaceExistingValueUsingCTRLADelete = WorkflowExpression.Compile(jABGlobalInputTextIntoElementreplaceExistingValueUsingCTRLADelete, nameof(jABGlobalInputTextIntoElementreplaceExistingValueUsingCTRLADelete), required: false);
            var __workflow_jABGlobalInputTextIntoElementtextToInput = WorkflowExpression.Compile(jABGlobalInputTextIntoElementtextToInput, nameof(jABGlobalInputTextIntoElementtextToInput), required: false);
            var __workflow_jABGlobalInputTextIntoElementsendKeyEvents = WorkflowExpression.Compile(jABGlobalInputTextIntoElementsendKeyEvents, nameof(jABGlobalInputTextIntoElementsendKeyEvents), required: false);
            var __workflow_jABGlobalInputTextIntoElementkeyIntervalInMilliseconds = WorkflowExpression.Compile(jABGlobalInputTextIntoElementkeyIntervalInMilliseconds, nameof(jABGlobalInputTextIntoElementkeyIntervalInMilliseconds), required: false);
            var __workflow_jABGlobalInputTextIntoElementdoubleClickIntervalInMilliseconds = WorkflowExpression.Compile(jABGlobalInputTextIntoElementdoubleClickIntervalInMilliseconds, nameof(jABGlobalInputTextIntoElementdoubleClickIntervalInMilliseconds), required: false);
            var __workflow_jABGlobalInputTextIntoElementdontInterpretSymbols = WorkflowExpression.Compile(jABGlobalInputTextIntoElementdontInterpretSymbols, nameof(jABGlobalInputTextIntoElementdontInterpretSymbols), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalInputTextIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGlobalInputTextIntoElement = new JObject();
                var jABGlobalInputTextIntoElementpropCount = 0;
                jABGlobalInputTextIntoElementpropCount++;
                jABGlobalInputTextIntoElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementsearchParentElementJABHandle);
                if (__workflow_jABGlobalInputTextIntoElementsearchElementJABName != null)
                {
                    jABGlobalInputTextIntoElement["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementsearchElementJABName);
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementsearchElementJABDescription != null)
                {
                    jABGlobalInputTextIntoElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementsearchElementJABDescription);
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementsearchElementJABRole != null)
                {
                    jABGlobalInputTextIntoElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementsearchElementJABRole);
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementsearchSubTree != null)
                {
                    if (__workflow_jABGlobalInputTextIntoElementsearchSubTree != null)
                    {
                        jABGlobalInputTextIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementsearchSubTree);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["SearchSubTree"] = true;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementmaxRelativeDepth != null)
                {
                    if (__workflow_jABGlobalInputTextIntoElementmaxRelativeDepth != null)
                    {
                        jABGlobalInputTextIntoElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementmaxRelativeDepth);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["MaxRelativeDepth"] = 0;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementmatchIndex != null)
                {
                    if (__workflow_jABGlobalInputTextIntoElementmatchIndex != null)
                    {
                        jABGlobalInputTextIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementmatchIndex);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["MatchIndex"] = 1;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementsearchFilter != null)
                {
                    jABGlobalInputTextIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementsearchFilter);
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementsortByColumn != null)
                {
                    jABGlobalInputTextIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementsortByColumn);
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementmatchIndexAscending != null)
                {
                    if (__workflow_jABGlobalInputTextIntoElementmatchIndexAscending != null)
                    {
                        jABGlobalInputTextIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementmatchIndexAscending);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["MatchIndexAscending"] = true;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementcaseSensitiveSearch != null)
                {
                    if (__workflow_jABGlobalInputTextIntoElementcaseSensitiveSearch != null)
                    {
                        jABGlobalInputTextIntoElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementcaseSensitiveSearch);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["CaseSensitiveSearch"] = false;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementonlySearchVisibleElements != null)
                {
                    if (__workflow_jABGlobalInputTextIntoElementonlySearchVisibleElements != null)
                    {
                        jABGlobalInputTextIntoElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementonlySearchVisibleElements);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["OnlySearchVisibleElements"] = true;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementonlySearchShowingElements != null)
                {
                    if (__workflow_jABGlobalInputTextIntoElementonlySearchShowingElements != null)
                    {
                        jABGlobalInputTextIntoElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementonlySearchShowingElements);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["OnlySearchShowingElements"] = true;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementelementRolesNotToTraverse != null)
                {
                    jABGlobalInputTextIntoElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementelementRolesNotToTraverse);
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementmaximumElementsToSearch != null)
                {
                    if (__workflow_jABGlobalInputTextIntoElementmaximumElementsToSearch != null)
                    {
                        jABGlobalInputTextIntoElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementmaximumElementsToSearch);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["MaximumElementsToSearch"] = 2000;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABGlobalInputTextIntoElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGlobalInputTextIntoElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementmaximumChildElementsToSearchPerNode);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementfocusElement != null)
                {
                    if (__workflow_jABGlobalInputTextIntoElementfocusElement != null)
                    {
                        jABGlobalInputTextIntoElement["FocusElement"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementfocusElement);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["FocusElement"] = true;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementglobalMouseClickOnElement != null)
                {
                    if (__workflow_jABGlobalInputTextIntoElementglobalMouseClickOnElement != null)
                    {
                        jABGlobalInputTextIntoElement["GlobalMouseClickOnElement"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementglobalMouseClickOnElement);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["GlobalMouseClickOnElement"] = true;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementreplaceExistingValueUsingDoubleClickDelete != null)
                {
                    if (__workflow_jABGlobalInputTextIntoElementreplaceExistingValueUsingDoubleClickDelete != null)
                    {
                        jABGlobalInputTextIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementreplaceExistingValueUsingDoubleClickDelete);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = false;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementreplaceExistingValueUsingCTRLADelete != null)
                {
                    if (__workflow_jABGlobalInputTextIntoElementreplaceExistingValueUsingCTRLADelete != null)
                    {
                        jABGlobalInputTextIntoElement["ReplaceExistingValueUsingCTRLADelete"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementreplaceExistingValueUsingCTRLADelete);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["ReplaceExistingValueUsingCTRLADelete"] = false;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementtextToInput != null)
                {
                    jABGlobalInputTextIntoElement["TextToInput"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementtextToInput);
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementsendKeyEvents != null)
                {
                    if (__workflow_jABGlobalInputTextIntoElementsendKeyEvents != null)
                    {
                        jABGlobalInputTextIntoElement["SendKeyEvents"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementsendKeyEvents);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["SendKeyEvents"] = false;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementkeyIntervalInMilliseconds != null)
                {
                    if (__workflow_jABGlobalInputTextIntoElementkeyIntervalInMilliseconds != null)
                    {
                        jABGlobalInputTextIntoElement["KeyIntervalInMilliseconds"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementkeyIntervalInMilliseconds);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["KeyIntervalInMilliseconds"] = 10;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementdoubleClickIntervalInMilliseconds != null)
                {
                    if (__workflow_jABGlobalInputTextIntoElementdoubleClickIntervalInMilliseconds != null)
                    {
                        jABGlobalInputTextIntoElement["DoubleClickIntervalInMilliseconds"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementdoubleClickIntervalInMilliseconds);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["DoubleClickIntervalInMilliseconds"] = 10;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (__workflow_jABGlobalInputTextIntoElementdontInterpretSymbols != null)
                {
                    if (__workflow_jABGlobalInputTextIntoElementdontInterpretSymbols != null)
                    {
                        jABGlobalInputTextIntoElement["DontInterpretSymbols"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementdontInterpretSymbols);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["DontInterpretSymbols"] = false;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                jABGlobalInputTextIntoElementpropCount++;
                jABGlobalInputTextIntoElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGlobalInputTextIntoElementworkflow);
                if (jABGlobalInputTextIntoElementpropCount > 0)
                {
                    callPayload.Body = jABGlobalInputTextIntoElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetSelectionElementItemsResponse> JABGetSelectionElementItems(Expression<Func<int>> jABGetSelectionElementItemssearchParentElementJABHandle, Expression<Func<string>> jABGetSelectionElementItemsworkflow, Expression<Func<string>> jABGetSelectionElementItemssearchElementJABName = null, Expression<Func<string>> jABGetSelectionElementItemssearchElementJABDescription = null, Expression<Func<string>> jABGetSelectionElementItemssearchElementJABRole = null, Expression<Func<bool>> jABGetSelectionElementItemssearchSubTree = null, Expression<Func<int>> jABGetSelectionElementItemsmaxRelativeDepth = null, Expression<Func<int>> jABGetSelectionElementItemsmatchIndex = null, Expression<Func<string>> jABGetSelectionElementItemssearchFilter = null, Expression<Func<string>> jABGetSelectionElementItemssortByColumn = null, Expression<Func<bool>> jABGetSelectionElementItemsmatchIndexAscending = null, Expression<Func<bool>> jABGetSelectionElementItemscaseSensitiveSearch = null, Expression<Func<bool>> jABGetSelectionElementItemsonlySearchVisibleElements = null, Expression<Func<bool>> jABGetSelectionElementItemsonlySearchShowingElements = null, Expression<Func<string>> jABGetSelectionElementItemselementRolesNotToTraverse = null, Expression<Func<int>> jABGetSelectionElementItemsmaximumElementsToSearch = null, Expression<Func<int>> jABGetSelectionElementItemsmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGetSelectionElementItemsgetListOfOptionsBySelecting = null, Expression<Func<bool>> jABGetSelectionElementItemsgetListOfOptionsByReadingLabels = null, Expression<Func<bool>> jABGetSelectionElementItemsexpandFirst = null, Expression<Func<bool>> jABGetSelectionElementItemscollapseAfter = null, Expression<Func<double>> jABGetSelectionElementItemssecondsBetweenExpandCollapse = null, Expression<Func<int>> jABGetSelectionElementItemsmaxListItemsToReturn = null)
        {
            var __workflow_jABGetSelectionElementItemssearchParentElementJABHandle = WorkflowExpression.Compile(jABGetSelectionElementItemssearchParentElementJABHandle, nameof(jABGetSelectionElementItemssearchParentElementJABHandle), required: true);
            var __workflow_jABGetSelectionElementItemsworkflow = WorkflowExpression.Compile(jABGetSelectionElementItemsworkflow, nameof(jABGetSelectionElementItemsworkflow), required: true);
            var __workflow_jABGetSelectionElementItemssearchElementJABName = WorkflowExpression.Compile(jABGetSelectionElementItemssearchElementJABName, nameof(jABGetSelectionElementItemssearchElementJABName), required: false);
            var __workflow_jABGetSelectionElementItemssearchElementJABDescription = WorkflowExpression.Compile(jABGetSelectionElementItemssearchElementJABDescription, nameof(jABGetSelectionElementItemssearchElementJABDescription), required: false);
            var __workflow_jABGetSelectionElementItemssearchElementJABRole = WorkflowExpression.Compile(jABGetSelectionElementItemssearchElementJABRole, nameof(jABGetSelectionElementItemssearchElementJABRole), required: false);
            var __workflow_jABGetSelectionElementItemssearchSubTree = WorkflowExpression.Compile(jABGetSelectionElementItemssearchSubTree, nameof(jABGetSelectionElementItemssearchSubTree), required: false);
            var __workflow_jABGetSelectionElementItemsmaxRelativeDepth = WorkflowExpression.Compile(jABGetSelectionElementItemsmaxRelativeDepth, nameof(jABGetSelectionElementItemsmaxRelativeDepth), required: false);
            var __workflow_jABGetSelectionElementItemsmatchIndex = WorkflowExpression.Compile(jABGetSelectionElementItemsmatchIndex, nameof(jABGetSelectionElementItemsmatchIndex), required: false);
            var __workflow_jABGetSelectionElementItemssearchFilter = WorkflowExpression.Compile(jABGetSelectionElementItemssearchFilter, nameof(jABGetSelectionElementItemssearchFilter), required: false);
            var __workflow_jABGetSelectionElementItemssortByColumn = WorkflowExpression.Compile(jABGetSelectionElementItemssortByColumn, nameof(jABGetSelectionElementItemssortByColumn), required: false);
            var __workflow_jABGetSelectionElementItemsmatchIndexAscending = WorkflowExpression.Compile(jABGetSelectionElementItemsmatchIndexAscending, nameof(jABGetSelectionElementItemsmatchIndexAscending), required: false);
            var __workflow_jABGetSelectionElementItemscaseSensitiveSearch = WorkflowExpression.Compile(jABGetSelectionElementItemscaseSensitiveSearch, nameof(jABGetSelectionElementItemscaseSensitiveSearch), required: false);
            var __workflow_jABGetSelectionElementItemsonlySearchVisibleElements = WorkflowExpression.Compile(jABGetSelectionElementItemsonlySearchVisibleElements, nameof(jABGetSelectionElementItemsonlySearchVisibleElements), required: false);
            var __workflow_jABGetSelectionElementItemsonlySearchShowingElements = WorkflowExpression.Compile(jABGetSelectionElementItemsonlySearchShowingElements, nameof(jABGetSelectionElementItemsonlySearchShowingElements), required: false);
            var __workflow_jABGetSelectionElementItemselementRolesNotToTraverse = WorkflowExpression.Compile(jABGetSelectionElementItemselementRolesNotToTraverse, nameof(jABGetSelectionElementItemselementRolesNotToTraverse), required: false);
            var __workflow_jABGetSelectionElementItemsmaximumElementsToSearch = WorkflowExpression.Compile(jABGetSelectionElementItemsmaximumElementsToSearch, nameof(jABGetSelectionElementItemsmaximumElementsToSearch), required: false);
            var __workflow_jABGetSelectionElementItemsmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABGetSelectionElementItemsmaximumChildElementsToSearchPerNode, nameof(jABGetSelectionElementItemsmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABGetSelectionElementItemsgetListOfOptionsBySelecting = WorkflowExpression.Compile(jABGetSelectionElementItemsgetListOfOptionsBySelecting, nameof(jABGetSelectionElementItemsgetListOfOptionsBySelecting), required: false);
            var __workflow_jABGetSelectionElementItemsgetListOfOptionsByReadingLabels = WorkflowExpression.Compile(jABGetSelectionElementItemsgetListOfOptionsByReadingLabels, nameof(jABGetSelectionElementItemsgetListOfOptionsByReadingLabels), required: false);
            var __workflow_jABGetSelectionElementItemsexpandFirst = WorkflowExpression.Compile(jABGetSelectionElementItemsexpandFirst, nameof(jABGetSelectionElementItemsexpandFirst), required: false);
            var __workflow_jABGetSelectionElementItemscollapseAfter = WorkflowExpression.Compile(jABGetSelectionElementItemscollapseAfter, nameof(jABGetSelectionElementItemscollapseAfter), required: false);
            var __workflow_jABGetSelectionElementItemssecondsBetweenExpandCollapse = WorkflowExpression.Compile(jABGetSelectionElementItemssecondsBetweenExpandCollapse, nameof(jABGetSelectionElementItemssecondsBetweenExpandCollapse), required: false);
            var __workflow_jABGetSelectionElementItemsmaxListItemsToReturn = WorkflowExpression.Compile(jABGetSelectionElementItemsmaxListItemsToReturn, nameof(jABGetSelectionElementItemsmaxListItemsToReturn), required: false);
            return new DeferredBodyAction<JABGetSelectionElementItemsResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetSelectionElementItems";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetSelectionElementItems = new JObject();
                var jABGetSelectionElementItemspropCount = 0;
                jABGetSelectionElementItemspropCount++;
                jABGetSelectionElementItems["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemssearchParentElementJABHandle);
                if (__workflow_jABGetSelectionElementItemssearchElementJABName != null)
                {
                    jABGetSelectionElementItems["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemssearchElementJABName);
                    jABGetSelectionElementItemspropCount++;
                }

                if (__workflow_jABGetSelectionElementItemssearchElementJABDescription != null)
                {
                    jABGetSelectionElementItems["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemssearchElementJABDescription);
                    jABGetSelectionElementItemspropCount++;
                }

                if (__workflow_jABGetSelectionElementItemssearchElementJABRole != null)
                {
                    jABGetSelectionElementItems["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemssearchElementJABRole);
                    jABGetSelectionElementItemspropCount++;
                }

                if (__workflow_jABGetSelectionElementItemssearchSubTree != null)
                {
                    if (__workflow_jABGetSelectionElementItemssearchSubTree != null)
                    {
                        jABGetSelectionElementItems["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemssearchSubTree);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["SearchSubTree"] = true;
                    jABGetSelectionElementItemspropCount++;
                }

                if (__workflow_jABGetSelectionElementItemsmaxRelativeDepth != null)
                {
                    if (__workflow_jABGetSelectionElementItemsmaxRelativeDepth != null)
                    {
                        jABGetSelectionElementItems["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemsmaxRelativeDepth);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["MaxRelativeDepth"] = 0;
                    jABGetSelectionElementItemspropCount++;
                }

                if (__workflow_jABGetSelectionElementItemsmatchIndex != null)
                {
                    if (__workflow_jABGetSelectionElementItemsmatchIndex != null)
                    {
                        jABGetSelectionElementItems["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemsmatchIndex);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["MatchIndex"] = 1;
                    jABGetSelectionElementItemspropCount++;
                }

                if (__workflow_jABGetSelectionElementItemssearchFilter != null)
                {
                    jABGetSelectionElementItems["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemssearchFilter);
                    jABGetSelectionElementItemspropCount++;
                }

                if (__workflow_jABGetSelectionElementItemssortByColumn != null)
                {
                    jABGetSelectionElementItems["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemssortByColumn);
                    jABGetSelectionElementItemspropCount++;
                }

                if (__workflow_jABGetSelectionElementItemsmatchIndexAscending != null)
                {
                    if (__workflow_jABGetSelectionElementItemsmatchIndexAscending != null)
                    {
                        jABGetSelectionElementItems["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemsmatchIndexAscending);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["MatchIndexAscending"] = true;
                    jABGetSelectionElementItemspropCount++;
                }

                if (__workflow_jABGetSelectionElementItemscaseSensitiveSearch != null)
                {
                    if (__workflow_jABGetSelectionElementItemscaseSensitiveSearch != null)
                    {
                        jABGetSelectionElementItems["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemscaseSensitiveSearch);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["CaseSensitiveSearch"] = false;
                    jABGetSelectionElementItemspropCount++;
                }

                if (__workflow_jABGetSelectionElementItemsonlySearchVisibleElements != null)
                {
                    if (__workflow_jABGetSelectionElementItemsonlySearchVisibleElements != null)
                    {
                        jABGetSelectionElementItems["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemsonlySearchVisibleElements);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["OnlySearchVisibleElements"] = true;
                    jABGetSelectionElementItemspropCount++;
                }

                if (__workflow_jABGetSelectionElementItemsonlySearchShowingElements != null)
                {
                    if (__workflow_jABGetSelectionElementItemsonlySearchShowingElements != null)
                    {
                        jABGetSelectionElementItems["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemsonlySearchShowingElements);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["OnlySearchShowingElements"] = true;
                    jABGetSelectionElementItemspropCount++;
                }

                if (__workflow_jABGetSelectionElementItemselementRolesNotToTraverse != null)
                {
                    jABGetSelectionElementItems["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemselementRolesNotToTraverse);
                    jABGetSelectionElementItemspropCount++;
                }

                if (__workflow_jABGetSelectionElementItemsmaximumElementsToSearch != null)
                {
                    if (__workflow_jABGetSelectionElementItemsmaximumElementsToSearch != null)
                    {
                        jABGetSelectionElementItems["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemsmaximumElementsToSearch);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["MaximumElementsToSearch"] = 2000;
                    jABGetSelectionElementItemspropCount++;
                }

                if (__workflow_jABGetSelectionElementItemsmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABGetSelectionElementItemsmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetSelectionElementItems["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemsmaximumChildElementsToSearchPerNode);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGetSelectionElementItemspropCount++;
                }

                if (__workflow_jABGetSelectionElementItemsgetListOfOptionsBySelecting != null)
                {
                    if (__workflow_jABGetSelectionElementItemsgetListOfOptionsBySelecting != null)
                    {
                        jABGetSelectionElementItems["GetListOfOptionsBySelecting"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemsgetListOfOptionsBySelecting);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["GetListOfOptionsBySelecting"] = false;
                    jABGetSelectionElementItemspropCount++;
                }

                if (__workflow_jABGetSelectionElementItemsgetListOfOptionsByReadingLabels != null)
                {
                    if (__workflow_jABGetSelectionElementItemsgetListOfOptionsByReadingLabels != null)
                    {
                        jABGetSelectionElementItems["GetListOfOptionsByReadingLabels"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemsgetListOfOptionsByReadingLabels);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["GetListOfOptionsByReadingLabels"] = false;
                    jABGetSelectionElementItemspropCount++;
                }

                if (__workflow_jABGetSelectionElementItemsexpandFirst != null)
                {
                    if (__workflow_jABGetSelectionElementItemsexpandFirst != null)
                    {
                        jABGetSelectionElementItems["ExpandFirst"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemsexpandFirst);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["ExpandFirst"] = false;
                    jABGetSelectionElementItemspropCount++;
                }

                if (__workflow_jABGetSelectionElementItemscollapseAfter != null)
                {
                    if (__workflow_jABGetSelectionElementItemscollapseAfter != null)
                    {
                        jABGetSelectionElementItems["CollapseAfter"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemscollapseAfter);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["CollapseAfter"] = false;
                    jABGetSelectionElementItemspropCount++;
                }

                if (__workflow_jABGetSelectionElementItemssecondsBetweenExpandCollapse != null)
                {
                    if (__workflow_jABGetSelectionElementItemssecondsBetweenExpandCollapse != null)
                    {
                        jABGetSelectionElementItems["SecondsBetweenExpandCollapse"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemssecondsBetweenExpandCollapse);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["SecondsBetweenExpandCollapse"] = 0.05;
                    jABGetSelectionElementItemspropCount++;
                }

                if (__workflow_jABGetSelectionElementItemsmaxListItemsToReturn != null)
                {
                    if (__workflow_jABGetSelectionElementItemsmaxListItemsToReturn != null)
                    {
                        jABGetSelectionElementItems["MaxListItemsToReturn"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemsmaxListItemsToReturn);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["MaxListItemsToReturn"] = 100;
                    jABGetSelectionElementItemspropCount++;
                }

                jABGetSelectionElementItemspropCount++;
                jABGetSelectionElementItems["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionElementItemsworkflow);
                if (jABGetSelectionElementItemspropCount > 0)
                {
                    callPayload.Body = jABGetSelectionElementItems;
                }

                return new ApiConnectionAction<JABGetSelectionElementItemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABSetSelectionByIndex(Expression<Func<int>> jABSetSelectionByIndexsearchParentElementJABHandle, Expression<Func<int>> jABSetSelectionByIndexitemIndex, Expression<Func<string>> jABSetSelectionByIndexworkflow, Expression<Func<string>> jABSetSelectionByIndexsearchElementJABName = null, Expression<Func<string>> jABSetSelectionByIndexsearchElementJABDescription = null, Expression<Func<string>> jABSetSelectionByIndexsearchElementJABRole = null, Expression<Func<bool>> jABSetSelectionByIndexsearchSubTree = null, Expression<Func<int>> jABSetSelectionByIndexmaxRelativeDepth = null, Expression<Func<int>> jABSetSelectionByIndexmatchIndex = null, Expression<Func<string>> jABSetSelectionByIndexsearchFilter = null, Expression<Func<string>> jABSetSelectionByIndexsortByColumn = null, Expression<Func<bool>> jABSetSelectionByIndexmatchIndexAscending = null, Expression<Func<bool>> jABSetSelectionByIndexcaseSensitiveSearch = null, Expression<Func<bool>> jABSetSelectionByIndexonlySearchVisibleElements = null, Expression<Func<bool>> jABSetSelectionByIndexonlySearchShowingElements = null, Expression<Func<string>> jABSetSelectionByIndexelementRolesNotToTraverse = null, Expression<Func<int>> jABSetSelectionByIndexmaximumElementsToSearch = null, Expression<Func<int>> jABSetSelectionByIndexmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABSetSelectionByIndexselectItem = null, Expression<Func<bool>> jABSetSelectionByIndexclearSelectionFirst = null, Expression<Func<bool>> jABSetSelectionByIndexrecoverOnFailure = null)
        {
            var __workflow_jABSetSelectionByIndexsearchParentElementJABHandle = WorkflowExpression.Compile(jABSetSelectionByIndexsearchParentElementJABHandle, nameof(jABSetSelectionByIndexsearchParentElementJABHandle), required: true);
            var __workflow_jABSetSelectionByIndexitemIndex = WorkflowExpression.Compile(jABSetSelectionByIndexitemIndex, nameof(jABSetSelectionByIndexitemIndex), required: true);
            var __workflow_jABSetSelectionByIndexworkflow = WorkflowExpression.Compile(jABSetSelectionByIndexworkflow, nameof(jABSetSelectionByIndexworkflow), required: true);
            var __workflow_jABSetSelectionByIndexsearchElementJABName = WorkflowExpression.Compile(jABSetSelectionByIndexsearchElementJABName, nameof(jABSetSelectionByIndexsearchElementJABName), required: false);
            var __workflow_jABSetSelectionByIndexsearchElementJABDescription = WorkflowExpression.Compile(jABSetSelectionByIndexsearchElementJABDescription, nameof(jABSetSelectionByIndexsearchElementJABDescription), required: false);
            var __workflow_jABSetSelectionByIndexsearchElementJABRole = WorkflowExpression.Compile(jABSetSelectionByIndexsearchElementJABRole, nameof(jABSetSelectionByIndexsearchElementJABRole), required: false);
            var __workflow_jABSetSelectionByIndexsearchSubTree = WorkflowExpression.Compile(jABSetSelectionByIndexsearchSubTree, nameof(jABSetSelectionByIndexsearchSubTree), required: false);
            var __workflow_jABSetSelectionByIndexmaxRelativeDepth = WorkflowExpression.Compile(jABSetSelectionByIndexmaxRelativeDepth, nameof(jABSetSelectionByIndexmaxRelativeDepth), required: false);
            var __workflow_jABSetSelectionByIndexmatchIndex = WorkflowExpression.Compile(jABSetSelectionByIndexmatchIndex, nameof(jABSetSelectionByIndexmatchIndex), required: false);
            var __workflow_jABSetSelectionByIndexsearchFilter = WorkflowExpression.Compile(jABSetSelectionByIndexsearchFilter, nameof(jABSetSelectionByIndexsearchFilter), required: false);
            var __workflow_jABSetSelectionByIndexsortByColumn = WorkflowExpression.Compile(jABSetSelectionByIndexsortByColumn, nameof(jABSetSelectionByIndexsortByColumn), required: false);
            var __workflow_jABSetSelectionByIndexmatchIndexAscending = WorkflowExpression.Compile(jABSetSelectionByIndexmatchIndexAscending, nameof(jABSetSelectionByIndexmatchIndexAscending), required: false);
            var __workflow_jABSetSelectionByIndexcaseSensitiveSearch = WorkflowExpression.Compile(jABSetSelectionByIndexcaseSensitiveSearch, nameof(jABSetSelectionByIndexcaseSensitiveSearch), required: false);
            var __workflow_jABSetSelectionByIndexonlySearchVisibleElements = WorkflowExpression.Compile(jABSetSelectionByIndexonlySearchVisibleElements, nameof(jABSetSelectionByIndexonlySearchVisibleElements), required: false);
            var __workflow_jABSetSelectionByIndexonlySearchShowingElements = WorkflowExpression.Compile(jABSetSelectionByIndexonlySearchShowingElements, nameof(jABSetSelectionByIndexonlySearchShowingElements), required: false);
            var __workflow_jABSetSelectionByIndexelementRolesNotToTraverse = WorkflowExpression.Compile(jABSetSelectionByIndexelementRolesNotToTraverse, nameof(jABSetSelectionByIndexelementRolesNotToTraverse), required: false);
            var __workflow_jABSetSelectionByIndexmaximumElementsToSearch = WorkflowExpression.Compile(jABSetSelectionByIndexmaximumElementsToSearch, nameof(jABSetSelectionByIndexmaximumElementsToSearch), required: false);
            var __workflow_jABSetSelectionByIndexmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABSetSelectionByIndexmaximumChildElementsToSearchPerNode, nameof(jABSetSelectionByIndexmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABSetSelectionByIndexselectItem = WorkflowExpression.Compile(jABSetSelectionByIndexselectItem, nameof(jABSetSelectionByIndexselectItem), required: false);
            var __workflow_jABSetSelectionByIndexclearSelectionFirst = WorkflowExpression.Compile(jABSetSelectionByIndexclearSelectionFirst, nameof(jABSetSelectionByIndexclearSelectionFirst), required: false);
            var __workflow_jABSetSelectionByIndexrecoverOnFailure = WorkflowExpression.Compile(jABSetSelectionByIndexrecoverOnFailure, nameof(jABSetSelectionByIndexrecoverOnFailure), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABSetSelectionByIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABSetSelectionByIndex = new JObject();
                var jABSetSelectionByIndexpropCount = 0;
                jABSetSelectionByIndexpropCount++;
                jABSetSelectionByIndex["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByIndexsearchParentElementJABHandle);
                if (__workflow_jABSetSelectionByIndexsearchElementJABName != null)
                {
                    jABSetSelectionByIndex["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByIndexsearchElementJABName);
                    jABSetSelectionByIndexpropCount++;
                }

                if (__workflow_jABSetSelectionByIndexsearchElementJABDescription != null)
                {
                    jABSetSelectionByIndex["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByIndexsearchElementJABDescription);
                    jABSetSelectionByIndexpropCount++;
                }

                if (__workflow_jABSetSelectionByIndexsearchElementJABRole != null)
                {
                    jABSetSelectionByIndex["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByIndexsearchElementJABRole);
                    jABSetSelectionByIndexpropCount++;
                }

                if (__workflow_jABSetSelectionByIndexsearchSubTree != null)
                {
                    if (__workflow_jABSetSelectionByIndexsearchSubTree != null)
                    {
                        jABSetSelectionByIndex["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByIndexsearchSubTree);
                        jABSetSelectionByIndexpropCount++;
                    }

                    jABSetSelectionByIndexpropCount++;
                }
                else
                {
                    jABSetSelectionByIndex["SearchSubTree"] = true;
                    jABSetSelectionByIndexpropCount++;
                }

                if (__workflow_jABSetSelectionByIndexmaxRelativeDepth != null)
                {
                    if (__workflow_jABSetSelectionByIndexmaxRelativeDepth != null)
                    {
                        jABSetSelectionByIndex["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByIndexmaxRelativeDepth);
                        jABSetSelectionByIndexpropCount++;
                    }

                    jABSetSelectionByIndexpropCount++;
                }
                else
                {
                    jABSetSelectionByIndex["MaxRelativeDepth"] = 0;
                    jABSetSelectionByIndexpropCount++;
                }

                if (__workflow_jABSetSelectionByIndexmatchIndex != null)
                {
                    if (__workflow_jABSetSelectionByIndexmatchIndex != null)
                    {
                        jABSetSelectionByIndex["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByIndexmatchIndex);
                        jABSetSelectionByIndexpropCount++;
                    }

                    jABSetSelectionByIndexpropCount++;
                }
                else
                {
                    jABSetSelectionByIndex["MatchIndex"] = 1;
                    jABSetSelectionByIndexpropCount++;
                }

                if (__workflow_jABSetSelectionByIndexsearchFilter != null)
                {
                    jABSetSelectionByIndex["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByIndexsearchFilter);
                    jABSetSelectionByIndexpropCount++;
                }

                if (__workflow_jABSetSelectionByIndexsortByColumn != null)
                {
                    jABSetSelectionByIndex["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByIndexsortByColumn);
                    jABSetSelectionByIndexpropCount++;
                }

                if (__workflow_jABSetSelectionByIndexmatchIndexAscending != null)
                {
                    if (__workflow_jABSetSelectionByIndexmatchIndexAscending != null)
                    {
                        jABSetSelectionByIndex["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByIndexmatchIndexAscending);
                        jABSetSelectionByIndexpropCount++;
                    }

                    jABSetSelectionByIndexpropCount++;
                }
                else
                {
                    jABSetSelectionByIndex["MatchIndexAscending"] = true;
                    jABSetSelectionByIndexpropCount++;
                }

                if (__workflow_jABSetSelectionByIndexcaseSensitiveSearch != null)
                {
                    if (__workflow_jABSetSelectionByIndexcaseSensitiveSearch != null)
                    {
                        jABSetSelectionByIndex["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByIndexcaseSensitiveSearch);
                        jABSetSelectionByIndexpropCount++;
                    }

                    jABSetSelectionByIndexpropCount++;
                }
                else
                {
                    jABSetSelectionByIndex["CaseSensitiveSearch"] = false;
                    jABSetSelectionByIndexpropCount++;
                }

                if (__workflow_jABSetSelectionByIndexonlySearchVisibleElements != null)
                {
                    if (__workflow_jABSetSelectionByIndexonlySearchVisibleElements != null)
                    {
                        jABSetSelectionByIndex["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByIndexonlySearchVisibleElements);
                        jABSetSelectionByIndexpropCount++;
                    }

                    jABSetSelectionByIndexpropCount++;
                }
                else
                {
                    jABSetSelectionByIndex["OnlySearchVisibleElements"] = true;
                    jABSetSelectionByIndexpropCount++;
                }

                if (__workflow_jABSetSelectionByIndexonlySearchShowingElements != null)
                {
                    if (__workflow_jABSetSelectionByIndexonlySearchShowingElements != null)
                    {
                        jABSetSelectionByIndex["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByIndexonlySearchShowingElements);
                        jABSetSelectionByIndexpropCount++;
                    }

                    jABSetSelectionByIndexpropCount++;
                }
                else
                {
                    jABSetSelectionByIndex["OnlySearchShowingElements"] = true;
                    jABSetSelectionByIndexpropCount++;
                }

                if (__workflow_jABSetSelectionByIndexelementRolesNotToTraverse != null)
                {
                    jABSetSelectionByIndex["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByIndexelementRolesNotToTraverse);
                    jABSetSelectionByIndexpropCount++;
                }

                if (__workflow_jABSetSelectionByIndexmaximumElementsToSearch != null)
                {
                    if (__workflow_jABSetSelectionByIndexmaximumElementsToSearch != null)
                    {
                        jABSetSelectionByIndex["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByIndexmaximumElementsToSearch);
                        jABSetSelectionByIndexpropCount++;
                    }

                    jABSetSelectionByIndexpropCount++;
                }
                else
                {
                    jABSetSelectionByIndex["MaximumElementsToSearch"] = 2000;
                    jABSetSelectionByIndexpropCount++;
                }

                if (__workflow_jABSetSelectionByIndexmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABSetSelectionByIndexmaximumChildElementsToSearchPerNode != null)
                    {
                        jABSetSelectionByIndex["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByIndexmaximumChildElementsToSearchPerNode);
                        jABSetSelectionByIndexpropCount++;
                    }

                    jABSetSelectionByIndexpropCount++;
                }
                else
                {
                    jABSetSelectionByIndex["MaximumChildElementsToSearchPerNode"] = 200;
                    jABSetSelectionByIndexpropCount++;
                }

                jABSetSelectionByIndexpropCount++;
                jABSetSelectionByIndex["ItemIndex"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByIndexitemIndex);
                if (__workflow_jABSetSelectionByIndexselectItem != null)
                {
                    if (__workflow_jABSetSelectionByIndexselectItem != null)
                    {
                        jABSetSelectionByIndex["SelectItem"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByIndexselectItem);
                        jABSetSelectionByIndexpropCount++;
                    }

                    jABSetSelectionByIndexpropCount++;
                }
                else
                {
                    jABSetSelectionByIndex["SelectItem"] = true;
                    jABSetSelectionByIndexpropCount++;
                }

                if (__workflow_jABSetSelectionByIndexclearSelectionFirst != null)
                {
                    if (__workflow_jABSetSelectionByIndexclearSelectionFirst != null)
                    {
                        jABSetSelectionByIndex["ClearSelectionFirst"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByIndexclearSelectionFirst);
                        jABSetSelectionByIndexpropCount++;
                    }

                    jABSetSelectionByIndexpropCount++;
                }
                else
                {
                    jABSetSelectionByIndex["ClearSelectionFirst"] = true;
                    jABSetSelectionByIndexpropCount++;
                }

                if (__workflow_jABSetSelectionByIndexrecoverOnFailure != null)
                {
                    if (__workflow_jABSetSelectionByIndexrecoverOnFailure != null)
                    {
                        jABSetSelectionByIndex["RecoverOnFailure"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByIndexrecoverOnFailure);
                        jABSetSelectionByIndexpropCount++;
                    }

                    jABSetSelectionByIndexpropCount++;
                }
                else
                {
                    jABSetSelectionByIndex["RecoverOnFailure"] = true;
                    jABSetSelectionByIndexpropCount++;
                }

                jABSetSelectionByIndexpropCount++;
                jABSetSelectionByIndex["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByIndexworkflow);
                if (jABSetSelectionByIndexpropCount > 0)
                {
                    callPayload.Body = jABSetSelectionByIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABSetSelectionByName(Expression<Func<int>> jABSetSelectionByNamesearchParentElementJABHandle, Expression<Func<string>> jABSetSelectionByNameitemName, Expression<Func<string>> jABSetSelectionByNameworkflow, Expression<Func<string>> jABSetSelectionByNamesearchElementJABName = null, Expression<Func<string>> jABSetSelectionByNamesearchElementJABDescription = null, Expression<Func<string>> jABSetSelectionByNamesearchElementJABRole = null, Expression<Func<bool>> jABSetSelectionByNamesearchSubTree = null, Expression<Func<int>> jABSetSelectionByNamemaxRelativeDepth = null, Expression<Func<int>> jABSetSelectionByNamematchIndex = null, Expression<Func<string>> jABSetSelectionByNamesearchFilter = null, Expression<Func<string>> jABSetSelectionByNamesortByColumn = null, Expression<Func<bool>> jABSetSelectionByNamematchIndexAscending = null, Expression<Func<bool>> jABSetSelectionByNamecaseSensitiveSearch = null, Expression<Func<bool>> jABSetSelectionByNameonlySearchVisibleElements = null, Expression<Func<bool>> jABSetSelectionByNameonlySearchShowingElements = null, Expression<Func<string>> jABSetSelectionByNameelementRolesNotToTraverse = null, Expression<Func<int>> jABSetSelectionByNamemaximumElementsToSearch = null, Expression<Func<int>> jABSetSelectionByNamemaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABSetSelectionByNameselectItem = null, Expression<Func<bool>> jABSetSelectionByNameitemNameCaseSensitive = null, Expression<Func<bool>> jABSetSelectionByNameclearSelectionFirst = null, Expression<Func<bool>> jABSetSelectionByNamegetListOfOptionsBySelecting = null, Expression<Func<bool>> jABSetSelectionByNamegetListOfOptionsByReadingLabels = null, Expression<Func<bool>> jABSetSelectionByNameexpandFirst = null, Expression<Func<bool>> jABSetSelectionByNamecollapseAfter = null, Expression<Func<double>> jABSetSelectionByNamesecondsBetweenExpandCollapse = null, Expression<Func<bool>> jABSetSelectionByNameforceEvenIfInCorrectState = null, Expression<Func<bool>> jABSetSelectionByNamerecoverOnFailure = null)
        {
            var __workflow_jABSetSelectionByNamesearchParentElementJABHandle = WorkflowExpression.Compile(jABSetSelectionByNamesearchParentElementJABHandle, nameof(jABSetSelectionByNamesearchParentElementJABHandle), required: true);
            var __workflow_jABSetSelectionByNameitemName = WorkflowExpression.Compile(jABSetSelectionByNameitemName, nameof(jABSetSelectionByNameitemName), required: true);
            var __workflow_jABSetSelectionByNameworkflow = WorkflowExpression.Compile(jABSetSelectionByNameworkflow, nameof(jABSetSelectionByNameworkflow), required: true);
            var __workflow_jABSetSelectionByNamesearchElementJABName = WorkflowExpression.Compile(jABSetSelectionByNamesearchElementJABName, nameof(jABSetSelectionByNamesearchElementJABName), required: false);
            var __workflow_jABSetSelectionByNamesearchElementJABDescription = WorkflowExpression.Compile(jABSetSelectionByNamesearchElementJABDescription, nameof(jABSetSelectionByNamesearchElementJABDescription), required: false);
            var __workflow_jABSetSelectionByNamesearchElementJABRole = WorkflowExpression.Compile(jABSetSelectionByNamesearchElementJABRole, nameof(jABSetSelectionByNamesearchElementJABRole), required: false);
            var __workflow_jABSetSelectionByNamesearchSubTree = WorkflowExpression.Compile(jABSetSelectionByNamesearchSubTree, nameof(jABSetSelectionByNamesearchSubTree), required: false);
            var __workflow_jABSetSelectionByNamemaxRelativeDepth = WorkflowExpression.Compile(jABSetSelectionByNamemaxRelativeDepth, nameof(jABSetSelectionByNamemaxRelativeDepth), required: false);
            var __workflow_jABSetSelectionByNamematchIndex = WorkflowExpression.Compile(jABSetSelectionByNamematchIndex, nameof(jABSetSelectionByNamematchIndex), required: false);
            var __workflow_jABSetSelectionByNamesearchFilter = WorkflowExpression.Compile(jABSetSelectionByNamesearchFilter, nameof(jABSetSelectionByNamesearchFilter), required: false);
            var __workflow_jABSetSelectionByNamesortByColumn = WorkflowExpression.Compile(jABSetSelectionByNamesortByColumn, nameof(jABSetSelectionByNamesortByColumn), required: false);
            var __workflow_jABSetSelectionByNamematchIndexAscending = WorkflowExpression.Compile(jABSetSelectionByNamematchIndexAscending, nameof(jABSetSelectionByNamematchIndexAscending), required: false);
            var __workflow_jABSetSelectionByNamecaseSensitiveSearch = WorkflowExpression.Compile(jABSetSelectionByNamecaseSensitiveSearch, nameof(jABSetSelectionByNamecaseSensitiveSearch), required: false);
            var __workflow_jABSetSelectionByNameonlySearchVisibleElements = WorkflowExpression.Compile(jABSetSelectionByNameonlySearchVisibleElements, nameof(jABSetSelectionByNameonlySearchVisibleElements), required: false);
            var __workflow_jABSetSelectionByNameonlySearchShowingElements = WorkflowExpression.Compile(jABSetSelectionByNameonlySearchShowingElements, nameof(jABSetSelectionByNameonlySearchShowingElements), required: false);
            var __workflow_jABSetSelectionByNameelementRolesNotToTraverse = WorkflowExpression.Compile(jABSetSelectionByNameelementRolesNotToTraverse, nameof(jABSetSelectionByNameelementRolesNotToTraverse), required: false);
            var __workflow_jABSetSelectionByNamemaximumElementsToSearch = WorkflowExpression.Compile(jABSetSelectionByNamemaximumElementsToSearch, nameof(jABSetSelectionByNamemaximumElementsToSearch), required: false);
            var __workflow_jABSetSelectionByNamemaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABSetSelectionByNamemaximumChildElementsToSearchPerNode, nameof(jABSetSelectionByNamemaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABSetSelectionByNameselectItem = WorkflowExpression.Compile(jABSetSelectionByNameselectItem, nameof(jABSetSelectionByNameselectItem), required: false);
            var __workflow_jABSetSelectionByNameitemNameCaseSensitive = WorkflowExpression.Compile(jABSetSelectionByNameitemNameCaseSensitive, nameof(jABSetSelectionByNameitemNameCaseSensitive), required: false);
            var __workflow_jABSetSelectionByNameclearSelectionFirst = WorkflowExpression.Compile(jABSetSelectionByNameclearSelectionFirst, nameof(jABSetSelectionByNameclearSelectionFirst), required: false);
            var __workflow_jABSetSelectionByNamegetListOfOptionsBySelecting = WorkflowExpression.Compile(jABSetSelectionByNamegetListOfOptionsBySelecting, nameof(jABSetSelectionByNamegetListOfOptionsBySelecting), required: false);
            var __workflow_jABSetSelectionByNamegetListOfOptionsByReadingLabels = WorkflowExpression.Compile(jABSetSelectionByNamegetListOfOptionsByReadingLabels, nameof(jABSetSelectionByNamegetListOfOptionsByReadingLabels), required: false);
            var __workflow_jABSetSelectionByNameexpandFirst = WorkflowExpression.Compile(jABSetSelectionByNameexpandFirst, nameof(jABSetSelectionByNameexpandFirst), required: false);
            var __workflow_jABSetSelectionByNamecollapseAfter = WorkflowExpression.Compile(jABSetSelectionByNamecollapseAfter, nameof(jABSetSelectionByNamecollapseAfter), required: false);
            var __workflow_jABSetSelectionByNamesecondsBetweenExpandCollapse = WorkflowExpression.Compile(jABSetSelectionByNamesecondsBetweenExpandCollapse, nameof(jABSetSelectionByNamesecondsBetweenExpandCollapse), required: false);
            var __workflow_jABSetSelectionByNameforceEvenIfInCorrectState = WorkflowExpression.Compile(jABSetSelectionByNameforceEvenIfInCorrectState, nameof(jABSetSelectionByNameforceEvenIfInCorrectState), required: false);
            var __workflow_jABSetSelectionByNamerecoverOnFailure = WorkflowExpression.Compile(jABSetSelectionByNamerecoverOnFailure, nameof(jABSetSelectionByNamerecoverOnFailure), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABSetSelectionByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABSetSelectionByName = new JObject();
                var jABSetSelectionByNamepropCount = 0;
                jABSetSelectionByNamepropCount++;
                jABSetSelectionByName["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNamesearchParentElementJABHandle);
                if (__workflow_jABSetSelectionByNamesearchElementJABName != null)
                {
                    jABSetSelectionByName["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNamesearchElementJABName);
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNamesearchElementJABDescription != null)
                {
                    jABSetSelectionByName["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNamesearchElementJABDescription);
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNamesearchElementJABRole != null)
                {
                    jABSetSelectionByName["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNamesearchElementJABRole);
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNamesearchSubTree != null)
                {
                    if (__workflow_jABSetSelectionByNamesearchSubTree != null)
                    {
                        jABSetSelectionByName["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNamesearchSubTree);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["SearchSubTree"] = true;
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNamemaxRelativeDepth != null)
                {
                    if (__workflow_jABSetSelectionByNamemaxRelativeDepth != null)
                    {
                        jABSetSelectionByName["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNamemaxRelativeDepth);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["MaxRelativeDepth"] = 0;
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNamematchIndex != null)
                {
                    if (__workflow_jABSetSelectionByNamematchIndex != null)
                    {
                        jABSetSelectionByName["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNamematchIndex);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["MatchIndex"] = 1;
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNamesearchFilter != null)
                {
                    jABSetSelectionByName["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNamesearchFilter);
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNamesortByColumn != null)
                {
                    jABSetSelectionByName["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNamesortByColumn);
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNamematchIndexAscending != null)
                {
                    if (__workflow_jABSetSelectionByNamematchIndexAscending != null)
                    {
                        jABSetSelectionByName["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNamematchIndexAscending);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["MatchIndexAscending"] = true;
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNamecaseSensitiveSearch != null)
                {
                    if (__workflow_jABSetSelectionByNamecaseSensitiveSearch != null)
                    {
                        jABSetSelectionByName["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNamecaseSensitiveSearch);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["CaseSensitiveSearch"] = false;
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNameonlySearchVisibleElements != null)
                {
                    if (__workflow_jABSetSelectionByNameonlySearchVisibleElements != null)
                    {
                        jABSetSelectionByName["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNameonlySearchVisibleElements);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["OnlySearchVisibleElements"] = true;
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNameonlySearchShowingElements != null)
                {
                    if (__workflow_jABSetSelectionByNameonlySearchShowingElements != null)
                    {
                        jABSetSelectionByName["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNameonlySearchShowingElements);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["OnlySearchShowingElements"] = true;
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNameelementRolesNotToTraverse != null)
                {
                    jABSetSelectionByName["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNameelementRolesNotToTraverse);
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNamemaximumElementsToSearch != null)
                {
                    if (__workflow_jABSetSelectionByNamemaximumElementsToSearch != null)
                    {
                        jABSetSelectionByName["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNamemaximumElementsToSearch);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["MaximumElementsToSearch"] = 2000;
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNamemaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABSetSelectionByNamemaximumChildElementsToSearchPerNode != null)
                    {
                        jABSetSelectionByName["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNamemaximumChildElementsToSearchPerNode);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["MaximumChildElementsToSearchPerNode"] = 200;
                    jABSetSelectionByNamepropCount++;
                }

                jABSetSelectionByNamepropCount++;
                jABSetSelectionByName["ItemName"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNameitemName);
                if (__workflow_jABSetSelectionByNameselectItem != null)
                {
                    if (__workflow_jABSetSelectionByNameselectItem != null)
                    {
                        jABSetSelectionByName["SelectItem"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNameselectItem);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["SelectItem"] = true;
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNameitemNameCaseSensitive != null)
                {
                    if (__workflow_jABSetSelectionByNameitemNameCaseSensitive != null)
                    {
                        jABSetSelectionByName["ItemNameCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNameitemNameCaseSensitive);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["ItemNameCaseSensitive"] = false;
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNameclearSelectionFirst != null)
                {
                    if (__workflow_jABSetSelectionByNameclearSelectionFirst != null)
                    {
                        jABSetSelectionByName["ClearSelectionFirst"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNameclearSelectionFirst);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["ClearSelectionFirst"] = true;
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNamegetListOfOptionsBySelecting != null)
                {
                    if (__workflow_jABSetSelectionByNamegetListOfOptionsBySelecting != null)
                    {
                        jABSetSelectionByName["GetListOfOptionsBySelecting"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNamegetListOfOptionsBySelecting);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["GetListOfOptionsBySelecting"] = false;
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNamegetListOfOptionsByReadingLabels != null)
                {
                    if (__workflow_jABSetSelectionByNamegetListOfOptionsByReadingLabels != null)
                    {
                        jABSetSelectionByName["GetListOfOptionsByReadingLabels"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNamegetListOfOptionsByReadingLabels);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["GetListOfOptionsByReadingLabels"] = true;
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNameexpandFirst != null)
                {
                    if (__workflow_jABSetSelectionByNameexpandFirst != null)
                    {
                        jABSetSelectionByName["ExpandFirst"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNameexpandFirst);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["ExpandFirst"] = true;
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNamecollapseAfter != null)
                {
                    if (__workflow_jABSetSelectionByNamecollapseAfter != null)
                    {
                        jABSetSelectionByName["CollapseAfter"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNamecollapseAfter);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["CollapseAfter"] = true;
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNamesecondsBetweenExpandCollapse != null)
                {
                    if (__workflow_jABSetSelectionByNamesecondsBetweenExpandCollapse != null)
                    {
                        jABSetSelectionByName["SecondsBetweenExpandCollapse"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNamesecondsBetweenExpandCollapse);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["SecondsBetweenExpandCollapse"] = 0.05;
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNameforceEvenIfInCorrectState != null)
                {
                    if (__workflow_jABSetSelectionByNameforceEvenIfInCorrectState != null)
                    {
                        jABSetSelectionByName["ForceEvenIfInCorrectState"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNameforceEvenIfInCorrectState);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["ForceEvenIfInCorrectState"] = false;
                    jABSetSelectionByNamepropCount++;
                }

                if (__workflow_jABSetSelectionByNamerecoverOnFailure != null)
                {
                    if (__workflow_jABSetSelectionByNamerecoverOnFailure != null)
                    {
                        jABSetSelectionByName["RecoverOnFailure"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNamerecoverOnFailure);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["RecoverOnFailure"] = true;
                    jABSetSelectionByNamepropCount++;
                }

                jABSetSelectionByNamepropCount++;
                jABSetSelectionByName["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABSetSelectionByNameworkflow);
                if (jABSetSelectionByNamepropCount > 0)
                {
                    callPayload.Body = jABSetSelectionByName;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABExpandSelection(Expression<Func<int>> jABExpandSelectionsearchParentElementJABHandle, Expression<Func<string>> jABExpandSelectionworkflow, Expression<Func<string>> jABExpandSelectionsearchElementJABName = null, Expression<Func<string>> jABExpandSelectionsearchElementJABDescription = null, Expression<Func<string>> jABExpandSelectionsearchElementJABRole = null, Expression<Func<bool>> jABExpandSelectionsearchSubTree = null, Expression<Func<int>> jABExpandSelectionmaxRelativeDepth = null, Expression<Func<int>> jABExpandSelectionmatchIndex = null, Expression<Func<string>> jABExpandSelectionsearchFilter = null, Expression<Func<string>> jABExpandSelectionsortByColumn = null, Expression<Func<bool>> jABExpandSelectionmatchIndexAscending = null, Expression<Func<bool>> jABExpandSelectioncaseSensitiveSearch = null, Expression<Func<bool>> jABExpandSelectiononlySearchVisibleElements = null, Expression<Func<bool>> jABExpandSelectiononlySearchShowingElements = null, Expression<Func<string>> jABExpandSelectionelementRolesNotToTraverse = null, Expression<Func<int>> jABExpandSelectionmaximumElementsToSearch = null, Expression<Func<int>> jABExpandSelectionmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABExpandSelectionexpand = null, Expression<Func<bool>> jABExpandSelectionverifyElementState = null, Expression<Func<double>> jABExpandSelectionsecondsToWaitForStateChange = null)
        {
            var __workflow_jABExpandSelectionsearchParentElementJABHandle = WorkflowExpression.Compile(jABExpandSelectionsearchParentElementJABHandle, nameof(jABExpandSelectionsearchParentElementJABHandle), required: true);
            var __workflow_jABExpandSelectionworkflow = WorkflowExpression.Compile(jABExpandSelectionworkflow, nameof(jABExpandSelectionworkflow), required: true);
            var __workflow_jABExpandSelectionsearchElementJABName = WorkflowExpression.Compile(jABExpandSelectionsearchElementJABName, nameof(jABExpandSelectionsearchElementJABName), required: false);
            var __workflow_jABExpandSelectionsearchElementJABDescription = WorkflowExpression.Compile(jABExpandSelectionsearchElementJABDescription, nameof(jABExpandSelectionsearchElementJABDescription), required: false);
            var __workflow_jABExpandSelectionsearchElementJABRole = WorkflowExpression.Compile(jABExpandSelectionsearchElementJABRole, nameof(jABExpandSelectionsearchElementJABRole), required: false);
            var __workflow_jABExpandSelectionsearchSubTree = WorkflowExpression.Compile(jABExpandSelectionsearchSubTree, nameof(jABExpandSelectionsearchSubTree), required: false);
            var __workflow_jABExpandSelectionmaxRelativeDepth = WorkflowExpression.Compile(jABExpandSelectionmaxRelativeDepth, nameof(jABExpandSelectionmaxRelativeDepth), required: false);
            var __workflow_jABExpandSelectionmatchIndex = WorkflowExpression.Compile(jABExpandSelectionmatchIndex, nameof(jABExpandSelectionmatchIndex), required: false);
            var __workflow_jABExpandSelectionsearchFilter = WorkflowExpression.Compile(jABExpandSelectionsearchFilter, nameof(jABExpandSelectionsearchFilter), required: false);
            var __workflow_jABExpandSelectionsortByColumn = WorkflowExpression.Compile(jABExpandSelectionsortByColumn, nameof(jABExpandSelectionsortByColumn), required: false);
            var __workflow_jABExpandSelectionmatchIndexAscending = WorkflowExpression.Compile(jABExpandSelectionmatchIndexAscending, nameof(jABExpandSelectionmatchIndexAscending), required: false);
            var __workflow_jABExpandSelectioncaseSensitiveSearch = WorkflowExpression.Compile(jABExpandSelectioncaseSensitiveSearch, nameof(jABExpandSelectioncaseSensitiveSearch), required: false);
            var __workflow_jABExpandSelectiononlySearchVisibleElements = WorkflowExpression.Compile(jABExpandSelectiononlySearchVisibleElements, nameof(jABExpandSelectiononlySearchVisibleElements), required: false);
            var __workflow_jABExpandSelectiononlySearchShowingElements = WorkflowExpression.Compile(jABExpandSelectiononlySearchShowingElements, nameof(jABExpandSelectiononlySearchShowingElements), required: false);
            var __workflow_jABExpandSelectionelementRolesNotToTraverse = WorkflowExpression.Compile(jABExpandSelectionelementRolesNotToTraverse, nameof(jABExpandSelectionelementRolesNotToTraverse), required: false);
            var __workflow_jABExpandSelectionmaximumElementsToSearch = WorkflowExpression.Compile(jABExpandSelectionmaximumElementsToSearch, nameof(jABExpandSelectionmaximumElementsToSearch), required: false);
            var __workflow_jABExpandSelectionmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABExpandSelectionmaximumChildElementsToSearchPerNode, nameof(jABExpandSelectionmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABExpandSelectionexpand = WorkflowExpression.Compile(jABExpandSelectionexpand, nameof(jABExpandSelectionexpand), required: false);
            var __workflow_jABExpandSelectionverifyElementState = WorkflowExpression.Compile(jABExpandSelectionverifyElementState, nameof(jABExpandSelectionverifyElementState), required: false);
            var __workflow_jABExpandSelectionsecondsToWaitForStateChange = WorkflowExpression.Compile(jABExpandSelectionsecondsToWaitForStateChange, nameof(jABExpandSelectionsecondsToWaitForStateChange), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABExpandSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABExpandSelection = new JObject();
                var jABExpandSelectionpropCount = 0;
                jABExpandSelectionpropCount++;
                jABExpandSelection["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABExpandSelectionsearchParentElementJABHandle);
                if (__workflow_jABExpandSelectionsearchElementJABName != null)
                {
                    jABExpandSelection["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABExpandSelectionsearchElementJABName);
                    jABExpandSelectionpropCount++;
                }

                if (__workflow_jABExpandSelectionsearchElementJABDescription != null)
                {
                    jABExpandSelection["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABExpandSelectionsearchElementJABDescription);
                    jABExpandSelectionpropCount++;
                }

                if (__workflow_jABExpandSelectionsearchElementJABRole != null)
                {
                    jABExpandSelection["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABExpandSelectionsearchElementJABRole);
                    jABExpandSelectionpropCount++;
                }

                if (__workflow_jABExpandSelectionsearchSubTree != null)
                {
                    if (__workflow_jABExpandSelectionsearchSubTree != null)
                    {
                        jABExpandSelection["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABExpandSelectionsearchSubTree);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["SearchSubTree"] = true;
                    jABExpandSelectionpropCount++;
                }

                if (__workflow_jABExpandSelectionmaxRelativeDepth != null)
                {
                    if (__workflow_jABExpandSelectionmaxRelativeDepth != null)
                    {
                        jABExpandSelection["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABExpandSelectionmaxRelativeDepth);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["MaxRelativeDepth"] = 0;
                    jABExpandSelectionpropCount++;
                }

                if (__workflow_jABExpandSelectionmatchIndex != null)
                {
                    if (__workflow_jABExpandSelectionmatchIndex != null)
                    {
                        jABExpandSelection["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABExpandSelectionmatchIndex);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["MatchIndex"] = 1;
                    jABExpandSelectionpropCount++;
                }

                if (__workflow_jABExpandSelectionsearchFilter != null)
                {
                    jABExpandSelection["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABExpandSelectionsearchFilter);
                    jABExpandSelectionpropCount++;
                }

                if (__workflow_jABExpandSelectionsortByColumn != null)
                {
                    jABExpandSelection["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABExpandSelectionsortByColumn);
                    jABExpandSelectionpropCount++;
                }

                if (__workflow_jABExpandSelectionmatchIndexAscending != null)
                {
                    if (__workflow_jABExpandSelectionmatchIndexAscending != null)
                    {
                        jABExpandSelection["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABExpandSelectionmatchIndexAscending);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["MatchIndexAscending"] = true;
                    jABExpandSelectionpropCount++;
                }

                if (__workflow_jABExpandSelectioncaseSensitiveSearch != null)
                {
                    if (__workflow_jABExpandSelectioncaseSensitiveSearch != null)
                    {
                        jABExpandSelection["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABExpandSelectioncaseSensitiveSearch);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["CaseSensitiveSearch"] = false;
                    jABExpandSelectionpropCount++;
                }

                if (__workflow_jABExpandSelectiononlySearchVisibleElements != null)
                {
                    if (__workflow_jABExpandSelectiononlySearchVisibleElements != null)
                    {
                        jABExpandSelection["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABExpandSelectiononlySearchVisibleElements);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["OnlySearchVisibleElements"] = true;
                    jABExpandSelectionpropCount++;
                }

                if (__workflow_jABExpandSelectiononlySearchShowingElements != null)
                {
                    if (__workflow_jABExpandSelectiononlySearchShowingElements != null)
                    {
                        jABExpandSelection["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABExpandSelectiononlySearchShowingElements);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["OnlySearchShowingElements"] = true;
                    jABExpandSelectionpropCount++;
                }

                if (__workflow_jABExpandSelectionelementRolesNotToTraverse != null)
                {
                    jABExpandSelection["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABExpandSelectionelementRolesNotToTraverse);
                    jABExpandSelectionpropCount++;
                }

                if (__workflow_jABExpandSelectionmaximumElementsToSearch != null)
                {
                    if (__workflow_jABExpandSelectionmaximumElementsToSearch != null)
                    {
                        jABExpandSelection["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABExpandSelectionmaximumElementsToSearch);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["MaximumElementsToSearch"] = 2000;
                    jABExpandSelectionpropCount++;
                }

                if (__workflow_jABExpandSelectionmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABExpandSelectionmaximumChildElementsToSearchPerNode != null)
                    {
                        jABExpandSelection["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABExpandSelectionmaximumChildElementsToSearchPerNode);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["MaximumChildElementsToSearchPerNode"] = 200;
                    jABExpandSelectionpropCount++;
                }

                if (__workflow_jABExpandSelectionexpand != null)
                {
                    if (__workflow_jABExpandSelectionexpand != null)
                    {
                        jABExpandSelection["Expand"] = ExpressionConverter.ConvertO(__workflow_jABExpandSelectionexpand);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["Expand"] = true;
                    jABExpandSelectionpropCount++;
                }

                if (__workflow_jABExpandSelectionverifyElementState != null)
                {
                    if (__workflow_jABExpandSelectionverifyElementState != null)
                    {
                        jABExpandSelection["VerifyElementState"] = ExpressionConverter.ConvertO(__workflow_jABExpandSelectionverifyElementState);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["VerifyElementState"] = false;
                    jABExpandSelectionpropCount++;
                }

                if (__workflow_jABExpandSelectionsecondsToWaitForStateChange != null)
                {
                    if (__workflow_jABExpandSelectionsecondsToWaitForStateChange != null)
                    {
                        jABExpandSelection["SecondsToWaitForStateChange"] = ExpressionConverter.ConvertO(__workflow_jABExpandSelectionsecondsToWaitForStateChange);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["SecondsToWaitForStateChange"] = 0.05;
                    jABExpandSelectionpropCount++;
                }

                jABExpandSelectionpropCount++;
                jABExpandSelection["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABExpandSelectionworkflow);
                if (jABExpandSelectionpropCount > 0)
                {
                    callPayload.Body = jABExpandSelection;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetSelectionStateByIndexResponse> JABGetSelectionStateByIndex(Expression<Func<int>> jABGetSelectionStateByIndexsearchParentElementJABHandle, Expression<Func<int>> jABGetSelectionStateByIndexitemIndex, Expression<Func<string>> jABGetSelectionStateByIndexworkflow, Expression<Func<string>> jABGetSelectionStateByIndexsearchElementJABName = null, Expression<Func<string>> jABGetSelectionStateByIndexsearchElementJABDescription = null, Expression<Func<string>> jABGetSelectionStateByIndexsearchElementJABRole = null, Expression<Func<bool>> jABGetSelectionStateByIndexsearchSubTree = null, Expression<Func<int>> jABGetSelectionStateByIndexmaxRelativeDepth = null, Expression<Func<int>> jABGetSelectionStateByIndexmatchIndex = null, Expression<Func<string>> jABGetSelectionStateByIndexsearchFilter = null, Expression<Func<string>> jABGetSelectionStateByIndexsortByColumn = null, Expression<Func<bool>> jABGetSelectionStateByIndexmatchIndexAscending = null, Expression<Func<bool>> jABGetSelectionStateByIndexcaseSensitiveSearch = null, Expression<Func<bool>> jABGetSelectionStateByIndexonlySearchVisibleElements = null, Expression<Func<bool>> jABGetSelectionStateByIndexonlySearchShowingElements = null, Expression<Func<string>> jABGetSelectionStateByIndexelementRolesNotToTraverse = null, Expression<Func<int>> jABGetSelectionStateByIndexmaximumElementsToSearch = null, Expression<Func<int>> jABGetSelectionStateByIndexmaximumChildElementsToSearchPerNode = null)
        {
            var __workflow_jABGetSelectionStateByIndexsearchParentElementJABHandle = WorkflowExpression.Compile(jABGetSelectionStateByIndexsearchParentElementJABHandle, nameof(jABGetSelectionStateByIndexsearchParentElementJABHandle), required: true);
            var __workflow_jABGetSelectionStateByIndexitemIndex = WorkflowExpression.Compile(jABGetSelectionStateByIndexitemIndex, nameof(jABGetSelectionStateByIndexitemIndex), required: true);
            var __workflow_jABGetSelectionStateByIndexworkflow = WorkflowExpression.Compile(jABGetSelectionStateByIndexworkflow, nameof(jABGetSelectionStateByIndexworkflow), required: true);
            var __workflow_jABGetSelectionStateByIndexsearchElementJABName = WorkflowExpression.Compile(jABGetSelectionStateByIndexsearchElementJABName, nameof(jABGetSelectionStateByIndexsearchElementJABName), required: false);
            var __workflow_jABGetSelectionStateByIndexsearchElementJABDescription = WorkflowExpression.Compile(jABGetSelectionStateByIndexsearchElementJABDescription, nameof(jABGetSelectionStateByIndexsearchElementJABDescription), required: false);
            var __workflow_jABGetSelectionStateByIndexsearchElementJABRole = WorkflowExpression.Compile(jABGetSelectionStateByIndexsearchElementJABRole, nameof(jABGetSelectionStateByIndexsearchElementJABRole), required: false);
            var __workflow_jABGetSelectionStateByIndexsearchSubTree = WorkflowExpression.Compile(jABGetSelectionStateByIndexsearchSubTree, nameof(jABGetSelectionStateByIndexsearchSubTree), required: false);
            var __workflow_jABGetSelectionStateByIndexmaxRelativeDepth = WorkflowExpression.Compile(jABGetSelectionStateByIndexmaxRelativeDepth, nameof(jABGetSelectionStateByIndexmaxRelativeDepth), required: false);
            var __workflow_jABGetSelectionStateByIndexmatchIndex = WorkflowExpression.Compile(jABGetSelectionStateByIndexmatchIndex, nameof(jABGetSelectionStateByIndexmatchIndex), required: false);
            var __workflow_jABGetSelectionStateByIndexsearchFilter = WorkflowExpression.Compile(jABGetSelectionStateByIndexsearchFilter, nameof(jABGetSelectionStateByIndexsearchFilter), required: false);
            var __workflow_jABGetSelectionStateByIndexsortByColumn = WorkflowExpression.Compile(jABGetSelectionStateByIndexsortByColumn, nameof(jABGetSelectionStateByIndexsortByColumn), required: false);
            var __workflow_jABGetSelectionStateByIndexmatchIndexAscending = WorkflowExpression.Compile(jABGetSelectionStateByIndexmatchIndexAscending, nameof(jABGetSelectionStateByIndexmatchIndexAscending), required: false);
            var __workflow_jABGetSelectionStateByIndexcaseSensitiveSearch = WorkflowExpression.Compile(jABGetSelectionStateByIndexcaseSensitiveSearch, nameof(jABGetSelectionStateByIndexcaseSensitiveSearch), required: false);
            var __workflow_jABGetSelectionStateByIndexonlySearchVisibleElements = WorkflowExpression.Compile(jABGetSelectionStateByIndexonlySearchVisibleElements, nameof(jABGetSelectionStateByIndexonlySearchVisibleElements), required: false);
            var __workflow_jABGetSelectionStateByIndexonlySearchShowingElements = WorkflowExpression.Compile(jABGetSelectionStateByIndexonlySearchShowingElements, nameof(jABGetSelectionStateByIndexonlySearchShowingElements), required: false);
            var __workflow_jABGetSelectionStateByIndexelementRolesNotToTraverse = WorkflowExpression.Compile(jABGetSelectionStateByIndexelementRolesNotToTraverse, nameof(jABGetSelectionStateByIndexelementRolesNotToTraverse), required: false);
            var __workflow_jABGetSelectionStateByIndexmaximumElementsToSearch = WorkflowExpression.Compile(jABGetSelectionStateByIndexmaximumElementsToSearch, nameof(jABGetSelectionStateByIndexmaximumElementsToSearch), required: false);
            var __workflow_jABGetSelectionStateByIndexmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABGetSelectionStateByIndexmaximumChildElementsToSearchPerNode, nameof(jABGetSelectionStateByIndexmaximumChildElementsToSearchPerNode), required: false);
            return new DeferredBodyAction<JABGetSelectionStateByIndexResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetSelectionStateByIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetSelectionStateByIndex = new JObject();
                var jABGetSelectionStateByIndexpropCount = 0;
                jABGetSelectionStateByIndexpropCount++;
                jABGetSelectionStateByIndex["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByIndexsearchParentElementJABHandle);
                if (__workflow_jABGetSelectionStateByIndexsearchElementJABName != null)
                {
                    jABGetSelectionStateByIndex["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByIndexsearchElementJABName);
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (__workflow_jABGetSelectionStateByIndexsearchElementJABDescription != null)
                {
                    jABGetSelectionStateByIndex["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByIndexsearchElementJABDescription);
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (__workflow_jABGetSelectionStateByIndexsearchElementJABRole != null)
                {
                    jABGetSelectionStateByIndex["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByIndexsearchElementJABRole);
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (__workflow_jABGetSelectionStateByIndexsearchSubTree != null)
                {
                    if (__workflow_jABGetSelectionStateByIndexsearchSubTree != null)
                    {
                        jABGetSelectionStateByIndex["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByIndexsearchSubTree);
                        jABGetSelectionStateByIndexpropCount++;
                    }

                    jABGetSelectionStateByIndexpropCount++;
                }
                else
                {
                    jABGetSelectionStateByIndex["SearchSubTree"] = true;
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (__workflow_jABGetSelectionStateByIndexmaxRelativeDepth != null)
                {
                    if (__workflow_jABGetSelectionStateByIndexmaxRelativeDepth != null)
                    {
                        jABGetSelectionStateByIndex["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByIndexmaxRelativeDepth);
                        jABGetSelectionStateByIndexpropCount++;
                    }

                    jABGetSelectionStateByIndexpropCount++;
                }
                else
                {
                    jABGetSelectionStateByIndex["MaxRelativeDepth"] = 0;
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (__workflow_jABGetSelectionStateByIndexmatchIndex != null)
                {
                    if (__workflow_jABGetSelectionStateByIndexmatchIndex != null)
                    {
                        jABGetSelectionStateByIndex["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByIndexmatchIndex);
                        jABGetSelectionStateByIndexpropCount++;
                    }

                    jABGetSelectionStateByIndexpropCount++;
                }
                else
                {
                    jABGetSelectionStateByIndex["MatchIndex"] = 1;
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (__workflow_jABGetSelectionStateByIndexsearchFilter != null)
                {
                    jABGetSelectionStateByIndex["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByIndexsearchFilter);
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (__workflow_jABGetSelectionStateByIndexsortByColumn != null)
                {
                    jABGetSelectionStateByIndex["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByIndexsortByColumn);
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (__workflow_jABGetSelectionStateByIndexmatchIndexAscending != null)
                {
                    if (__workflow_jABGetSelectionStateByIndexmatchIndexAscending != null)
                    {
                        jABGetSelectionStateByIndex["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByIndexmatchIndexAscending);
                        jABGetSelectionStateByIndexpropCount++;
                    }

                    jABGetSelectionStateByIndexpropCount++;
                }
                else
                {
                    jABGetSelectionStateByIndex["MatchIndexAscending"] = true;
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (__workflow_jABGetSelectionStateByIndexcaseSensitiveSearch != null)
                {
                    if (__workflow_jABGetSelectionStateByIndexcaseSensitiveSearch != null)
                    {
                        jABGetSelectionStateByIndex["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByIndexcaseSensitiveSearch);
                        jABGetSelectionStateByIndexpropCount++;
                    }

                    jABGetSelectionStateByIndexpropCount++;
                }
                else
                {
                    jABGetSelectionStateByIndex["CaseSensitiveSearch"] = false;
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (__workflow_jABGetSelectionStateByIndexonlySearchVisibleElements != null)
                {
                    if (__workflow_jABGetSelectionStateByIndexonlySearchVisibleElements != null)
                    {
                        jABGetSelectionStateByIndex["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByIndexonlySearchVisibleElements);
                        jABGetSelectionStateByIndexpropCount++;
                    }

                    jABGetSelectionStateByIndexpropCount++;
                }
                else
                {
                    jABGetSelectionStateByIndex["OnlySearchVisibleElements"] = true;
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (__workflow_jABGetSelectionStateByIndexonlySearchShowingElements != null)
                {
                    if (__workflow_jABGetSelectionStateByIndexonlySearchShowingElements != null)
                    {
                        jABGetSelectionStateByIndex["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByIndexonlySearchShowingElements);
                        jABGetSelectionStateByIndexpropCount++;
                    }

                    jABGetSelectionStateByIndexpropCount++;
                }
                else
                {
                    jABGetSelectionStateByIndex["OnlySearchShowingElements"] = true;
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (__workflow_jABGetSelectionStateByIndexelementRolesNotToTraverse != null)
                {
                    jABGetSelectionStateByIndex["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByIndexelementRolesNotToTraverse);
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (__workflow_jABGetSelectionStateByIndexmaximumElementsToSearch != null)
                {
                    if (__workflow_jABGetSelectionStateByIndexmaximumElementsToSearch != null)
                    {
                        jABGetSelectionStateByIndex["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByIndexmaximumElementsToSearch);
                        jABGetSelectionStateByIndexpropCount++;
                    }

                    jABGetSelectionStateByIndexpropCount++;
                }
                else
                {
                    jABGetSelectionStateByIndex["MaximumElementsToSearch"] = 2000;
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (__workflow_jABGetSelectionStateByIndexmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABGetSelectionStateByIndexmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetSelectionStateByIndex["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByIndexmaximumChildElementsToSearchPerNode);
                        jABGetSelectionStateByIndexpropCount++;
                    }

                    jABGetSelectionStateByIndexpropCount++;
                }
                else
                {
                    jABGetSelectionStateByIndex["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGetSelectionStateByIndexpropCount++;
                }

                jABGetSelectionStateByIndexpropCount++;
                jABGetSelectionStateByIndex["ItemIndex"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByIndexitemIndex);
                jABGetSelectionStateByIndexpropCount++;
                jABGetSelectionStateByIndex["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByIndexworkflow);
                if (jABGetSelectionStateByIndexpropCount > 0)
                {
                    callPayload.Body = jABGetSelectionStateByIndex;
                }

                return new ApiConnectionAction<JABGetSelectionStateByIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetSelectionStateByNameResponse> JABGetSelectionStateByName(Expression<Func<int>> jABGetSelectionStateByNamesearchParentElementJABHandle, Expression<Func<string>> jABGetSelectionStateByNameitemName, Expression<Func<string>> jABGetSelectionStateByNameworkflow, Expression<Func<string>> jABGetSelectionStateByNamesearchElementJABName = null, Expression<Func<string>> jABGetSelectionStateByNamesearchElementJABDescription = null, Expression<Func<string>> jABGetSelectionStateByNamesearchElementJABRole = null, Expression<Func<bool>> jABGetSelectionStateByNamesearchSubTree = null, Expression<Func<int>> jABGetSelectionStateByNamemaxRelativeDepth = null, Expression<Func<int>> jABGetSelectionStateByNamematchIndex = null, Expression<Func<string>> jABGetSelectionStateByNamesearchFilter = null, Expression<Func<string>> jABGetSelectionStateByNamesortByColumn = null, Expression<Func<bool>> jABGetSelectionStateByNamematchIndexAscending = null, Expression<Func<bool>> jABGetSelectionStateByNamecaseSensitiveSearch = null, Expression<Func<bool>> jABGetSelectionStateByNameonlySearchVisibleElements = null, Expression<Func<bool>> jABGetSelectionStateByNameonlySearchShowingElements = null, Expression<Func<string>> jABGetSelectionStateByNameelementRolesNotToTraverse = null, Expression<Func<int>> jABGetSelectionStateByNamemaximumElementsToSearch = null, Expression<Func<int>> jABGetSelectionStateByNamemaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGetSelectionStateByNameitemNameCaseSensitive = null)
        {
            var __workflow_jABGetSelectionStateByNamesearchParentElementJABHandle = WorkflowExpression.Compile(jABGetSelectionStateByNamesearchParentElementJABHandle, nameof(jABGetSelectionStateByNamesearchParentElementJABHandle), required: true);
            var __workflow_jABGetSelectionStateByNameitemName = WorkflowExpression.Compile(jABGetSelectionStateByNameitemName, nameof(jABGetSelectionStateByNameitemName), required: true);
            var __workflow_jABGetSelectionStateByNameworkflow = WorkflowExpression.Compile(jABGetSelectionStateByNameworkflow, nameof(jABGetSelectionStateByNameworkflow), required: true);
            var __workflow_jABGetSelectionStateByNamesearchElementJABName = WorkflowExpression.Compile(jABGetSelectionStateByNamesearchElementJABName, nameof(jABGetSelectionStateByNamesearchElementJABName), required: false);
            var __workflow_jABGetSelectionStateByNamesearchElementJABDescription = WorkflowExpression.Compile(jABGetSelectionStateByNamesearchElementJABDescription, nameof(jABGetSelectionStateByNamesearchElementJABDescription), required: false);
            var __workflow_jABGetSelectionStateByNamesearchElementJABRole = WorkflowExpression.Compile(jABGetSelectionStateByNamesearchElementJABRole, nameof(jABGetSelectionStateByNamesearchElementJABRole), required: false);
            var __workflow_jABGetSelectionStateByNamesearchSubTree = WorkflowExpression.Compile(jABGetSelectionStateByNamesearchSubTree, nameof(jABGetSelectionStateByNamesearchSubTree), required: false);
            var __workflow_jABGetSelectionStateByNamemaxRelativeDepth = WorkflowExpression.Compile(jABGetSelectionStateByNamemaxRelativeDepth, nameof(jABGetSelectionStateByNamemaxRelativeDepth), required: false);
            var __workflow_jABGetSelectionStateByNamematchIndex = WorkflowExpression.Compile(jABGetSelectionStateByNamematchIndex, nameof(jABGetSelectionStateByNamematchIndex), required: false);
            var __workflow_jABGetSelectionStateByNamesearchFilter = WorkflowExpression.Compile(jABGetSelectionStateByNamesearchFilter, nameof(jABGetSelectionStateByNamesearchFilter), required: false);
            var __workflow_jABGetSelectionStateByNamesortByColumn = WorkflowExpression.Compile(jABGetSelectionStateByNamesortByColumn, nameof(jABGetSelectionStateByNamesortByColumn), required: false);
            var __workflow_jABGetSelectionStateByNamematchIndexAscending = WorkflowExpression.Compile(jABGetSelectionStateByNamematchIndexAscending, nameof(jABGetSelectionStateByNamematchIndexAscending), required: false);
            var __workflow_jABGetSelectionStateByNamecaseSensitiveSearch = WorkflowExpression.Compile(jABGetSelectionStateByNamecaseSensitiveSearch, nameof(jABGetSelectionStateByNamecaseSensitiveSearch), required: false);
            var __workflow_jABGetSelectionStateByNameonlySearchVisibleElements = WorkflowExpression.Compile(jABGetSelectionStateByNameonlySearchVisibleElements, nameof(jABGetSelectionStateByNameonlySearchVisibleElements), required: false);
            var __workflow_jABGetSelectionStateByNameonlySearchShowingElements = WorkflowExpression.Compile(jABGetSelectionStateByNameonlySearchShowingElements, nameof(jABGetSelectionStateByNameonlySearchShowingElements), required: false);
            var __workflow_jABGetSelectionStateByNameelementRolesNotToTraverse = WorkflowExpression.Compile(jABGetSelectionStateByNameelementRolesNotToTraverse, nameof(jABGetSelectionStateByNameelementRolesNotToTraverse), required: false);
            var __workflow_jABGetSelectionStateByNamemaximumElementsToSearch = WorkflowExpression.Compile(jABGetSelectionStateByNamemaximumElementsToSearch, nameof(jABGetSelectionStateByNamemaximumElementsToSearch), required: false);
            var __workflow_jABGetSelectionStateByNamemaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABGetSelectionStateByNamemaximumChildElementsToSearchPerNode, nameof(jABGetSelectionStateByNamemaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABGetSelectionStateByNameitemNameCaseSensitive = WorkflowExpression.Compile(jABGetSelectionStateByNameitemNameCaseSensitive, nameof(jABGetSelectionStateByNameitemNameCaseSensitive), required: false);
            return new DeferredBodyAction<JABGetSelectionStateByNameResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetSelectionStateByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetSelectionStateByName = new JObject();
                var jABGetSelectionStateByNamepropCount = 0;
                jABGetSelectionStateByNamepropCount++;
                jABGetSelectionStateByName["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByNamesearchParentElementJABHandle);
                if (__workflow_jABGetSelectionStateByNamesearchElementJABName != null)
                {
                    jABGetSelectionStateByName["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByNamesearchElementJABName);
                    jABGetSelectionStateByNamepropCount++;
                }

                if (__workflow_jABGetSelectionStateByNamesearchElementJABDescription != null)
                {
                    jABGetSelectionStateByName["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByNamesearchElementJABDescription);
                    jABGetSelectionStateByNamepropCount++;
                }

                if (__workflow_jABGetSelectionStateByNamesearchElementJABRole != null)
                {
                    jABGetSelectionStateByName["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByNamesearchElementJABRole);
                    jABGetSelectionStateByNamepropCount++;
                }

                if (__workflow_jABGetSelectionStateByNamesearchSubTree != null)
                {
                    if (__workflow_jABGetSelectionStateByNamesearchSubTree != null)
                    {
                        jABGetSelectionStateByName["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByNamesearchSubTree);
                        jABGetSelectionStateByNamepropCount++;
                    }

                    jABGetSelectionStateByNamepropCount++;
                }
                else
                {
                    jABGetSelectionStateByName["SearchSubTree"] = true;
                    jABGetSelectionStateByNamepropCount++;
                }

                if (__workflow_jABGetSelectionStateByNamemaxRelativeDepth != null)
                {
                    if (__workflow_jABGetSelectionStateByNamemaxRelativeDepth != null)
                    {
                        jABGetSelectionStateByName["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByNamemaxRelativeDepth);
                        jABGetSelectionStateByNamepropCount++;
                    }

                    jABGetSelectionStateByNamepropCount++;
                }
                else
                {
                    jABGetSelectionStateByName["MaxRelativeDepth"] = 0;
                    jABGetSelectionStateByNamepropCount++;
                }

                if (__workflow_jABGetSelectionStateByNamematchIndex != null)
                {
                    if (__workflow_jABGetSelectionStateByNamematchIndex != null)
                    {
                        jABGetSelectionStateByName["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByNamematchIndex);
                        jABGetSelectionStateByNamepropCount++;
                    }

                    jABGetSelectionStateByNamepropCount++;
                }
                else
                {
                    jABGetSelectionStateByName["MatchIndex"] = 1;
                    jABGetSelectionStateByNamepropCount++;
                }

                if (__workflow_jABGetSelectionStateByNamesearchFilter != null)
                {
                    jABGetSelectionStateByName["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByNamesearchFilter);
                    jABGetSelectionStateByNamepropCount++;
                }

                if (__workflow_jABGetSelectionStateByNamesortByColumn != null)
                {
                    jABGetSelectionStateByName["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByNamesortByColumn);
                    jABGetSelectionStateByNamepropCount++;
                }

                if (__workflow_jABGetSelectionStateByNamematchIndexAscending != null)
                {
                    if (__workflow_jABGetSelectionStateByNamematchIndexAscending != null)
                    {
                        jABGetSelectionStateByName["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByNamematchIndexAscending);
                        jABGetSelectionStateByNamepropCount++;
                    }

                    jABGetSelectionStateByNamepropCount++;
                }
                else
                {
                    jABGetSelectionStateByName["MatchIndexAscending"] = true;
                    jABGetSelectionStateByNamepropCount++;
                }

                if (__workflow_jABGetSelectionStateByNamecaseSensitiveSearch != null)
                {
                    if (__workflow_jABGetSelectionStateByNamecaseSensitiveSearch != null)
                    {
                        jABGetSelectionStateByName["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByNamecaseSensitiveSearch);
                        jABGetSelectionStateByNamepropCount++;
                    }

                    jABGetSelectionStateByNamepropCount++;
                }
                else
                {
                    jABGetSelectionStateByName["CaseSensitiveSearch"] = false;
                    jABGetSelectionStateByNamepropCount++;
                }

                if (__workflow_jABGetSelectionStateByNameonlySearchVisibleElements != null)
                {
                    if (__workflow_jABGetSelectionStateByNameonlySearchVisibleElements != null)
                    {
                        jABGetSelectionStateByName["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByNameonlySearchVisibleElements);
                        jABGetSelectionStateByNamepropCount++;
                    }

                    jABGetSelectionStateByNamepropCount++;
                }
                else
                {
                    jABGetSelectionStateByName["OnlySearchVisibleElements"] = true;
                    jABGetSelectionStateByNamepropCount++;
                }

                if (__workflow_jABGetSelectionStateByNameonlySearchShowingElements != null)
                {
                    if (__workflow_jABGetSelectionStateByNameonlySearchShowingElements != null)
                    {
                        jABGetSelectionStateByName["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByNameonlySearchShowingElements);
                        jABGetSelectionStateByNamepropCount++;
                    }

                    jABGetSelectionStateByNamepropCount++;
                }
                else
                {
                    jABGetSelectionStateByName["OnlySearchShowingElements"] = true;
                    jABGetSelectionStateByNamepropCount++;
                }

                if (__workflow_jABGetSelectionStateByNameelementRolesNotToTraverse != null)
                {
                    jABGetSelectionStateByName["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByNameelementRolesNotToTraverse);
                    jABGetSelectionStateByNamepropCount++;
                }

                if (__workflow_jABGetSelectionStateByNamemaximumElementsToSearch != null)
                {
                    if (__workflow_jABGetSelectionStateByNamemaximumElementsToSearch != null)
                    {
                        jABGetSelectionStateByName["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByNamemaximumElementsToSearch);
                        jABGetSelectionStateByNamepropCount++;
                    }

                    jABGetSelectionStateByNamepropCount++;
                }
                else
                {
                    jABGetSelectionStateByName["MaximumElementsToSearch"] = 2000;
                    jABGetSelectionStateByNamepropCount++;
                }

                if (__workflow_jABGetSelectionStateByNamemaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABGetSelectionStateByNamemaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetSelectionStateByName["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByNamemaximumChildElementsToSearchPerNode);
                        jABGetSelectionStateByNamepropCount++;
                    }

                    jABGetSelectionStateByNamepropCount++;
                }
                else
                {
                    jABGetSelectionStateByName["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGetSelectionStateByNamepropCount++;
                }

                jABGetSelectionStateByNamepropCount++;
                jABGetSelectionStateByName["ItemName"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByNameitemName);
                if (__workflow_jABGetSelectionStateByNameitemNameCaseSensitive != null)
                {
                    if (__workflow_jABGetSelectionStateByNameitemNameCaseSensitive != null)
                    {
                        jABGetSelectionStateByName["ItemNameCaseSensitive"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByNameitemNameCaseSensitive);
                        jABGetSelectionStateByNamepropCount++;
                    }

                    jABGetSelectionStateByNamepropCount++;
                }
                else
                {
                    jABGetSelectionStateByName["ItemNameCaseSensitive"] = false;
                    jABGetSelectionStateByNamepropCount++;
                }

                jABGetSelectionStateByNamepropCount++;
                jABGetSelectionStateByName["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetSelectionStateByNameworkflow);
                if (jABGetSelectionStateByNamepropCount > 0)
                {
                    callPayload.Body = jABGetSelectionStateByName;
                }

                return new ApiConnectionAction<JABGetSelectionStateByNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetTablePropertiesResponse> JABGetTableProperties(Expression<Func<int>> jABGetTablePropertiessearchParentElementJABHandle, Expression<Func<string>> jABGetTablePropertiesworkflow, Expression<Func<string>> jABGetTablePropertiessearchElementJABName = null, Expression<Func<string>> jABGetTablePropertiessearchElementJABDescription = null, Expression<Func<string>> jABGetTablePropertiessearchElementJABRole = null, Expression<Func<bool>> jABGetTablePropertiessearchSubTree = null, Expression<Func<int>> jABGetTablePropertiesmaxRelativeDepth = null, Expression<Func<int>> jABGetTablePropertiesmatchIndex = null, Expression<Func<string>> jABGetTablePropertiessearchFilter = null, Expression<Func<string>> jABGetTablePropertiessortByColumn = null, Expression<Func<bool>> jABGetTablePropertiesmatchIndexAscending = null, Expression<Func<bool>> jABGetTablePropertiescaseSensitiveSearch = null, Expression<Func<bool>> jABGetTablePropertiesonlySearchVisibleElements = null, Expression<Func<bool>> jABGetTablePropertiesonlySearchShowingElements = null, Expression<Func<string>> jABGetTablePropertieselementRolesNotToTraverse = null, Expression<Func<int>> jABGetTablePropertiesmaximumElementsToSearch = null, Expression<Func<int>> jABGetTablePropertiesmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGetTablePropertiesenumerateViewport = null, Expression<Func<bool>> jABGetTablePropertiesprocessViewportParents = null, Expression<Func<int>> jABGetTablePropertiesmaxViewportParentsToProcess = null, Expression<Func<string>> jABGetTablePropertiesviewportParentElementRolesToConsider = null, Expression<Func<int>> jABGetTablePropertiesviewportLeftMargin = null, Expression<Func<int>> jABGetTablePropertiesviewportTopMargin = null, Expression<Func<int>> jABGetTablePropertiesviewportRightMargin = null, Expression<Func<int>> jABGetTablePropertiesviewportBottomMargin = null)
        {
            var __workflow_jABGetTablePropertiessearchParentElementJABHandle = WorkflowExpression.Compile(jABGetTablePropertiessearchParentElementJABHandle, nameof(jABGetTablePropertiessearchParentElementJABHandle), required: true);
            var __workflow_jABGetTablePropertiesworkflow = WorkflowExpression.Compile(jABGetTablePropertiesworkflow, nameof(jABGetTablePropertiesworkflow), required: true);
            var __workflow_jABGetTablePropertiessearchElementJABName = WorkflowExpression.Compile(jABGetTablePropertiessearchElementJABName, nameof(jABGetTablePropertiessearchElementJABName), required: false);
            var __workflow_jABGetTablePropertiessearchElementJABDescription = WorkflowExpression.Compile(jABGetTablePropertiessearchElementJABDescription, nameof(jABGetTablePropertiessearchElementJABDescription), required: false);
            var __workflow_jABGetTablePropertiessearchElementJABRole = WorkflowExpression.Compile(jABGetTablePropertiessearchElementJABRole, nameof(jABGetTablePropertiessearchElementJABRole), required: false);
            var __workflow_jABGetTablePropertiessearchSubTree = WorkflowExpression.Compile(jABGetTablePropertiessearchSubTree, nameof(jABGetTablePropertiessearchSubTree), required: false);
            var __workflow_jABGetTablePropertiesmaxRelativeDepth = WorkflowExpression.Compile(jABGetTablePropertiesmaxRelativeDepth, nameof(jABGetTablePropertiesmaxRelativeDepth), required: false);
            var __workflow_jABGetTablePropertiesmatchIndex = WorkflowExpression.Compile(jABGetTablePropertiesmatchIndex, nameof(jABGetTablePropertiesmatchIndex), required: false);
            var __workflow_jABGetTablePropertiessearchFilter = WorkflowExpression.Compile(jABGetTablePropertiessearchFilter, nameof(jABGetTablePropertiessearchFilter), required: false);
            var __workflow_jABGetTablePropertiessortByColumn = WorkflowExpression.Compile(jABGetTablePropertiessortByColumn, nameof(jABGetTablePropertiessortByColumn), required: false);
            var __workflow_jABGetTablePropertiesmatchIndexAscending = WorkflowExpression.Compile(jABGetTablePropertiesmatchIndexAscending, nameof(jABGetTablePropertiesmatchIndexAscending), required: false);
            var __workflow_jABGetTablePropertiescaseSensitiveSearch = WorkflowExpression.Compile(jABGetTablePropertiescaseSensitiveSearch, nameof(jABGetTablePropertiescaseSensitiveSearch), required: false);
            var __workflow_jABGetTablePropertiesonlySearchVisibleElements = WorkflowExpression.Compile(jABGetTablePropertiesonlySearchVisibleElements, nameof(jABGetTablePropertiesonlySearchVisibleElements), required: false);
            var __workflow_jABGetTablePropertiesonlySearchShowingElements = WorkflowExpression.Compile(jABGetTablePropertiesonlySearchShowingElements, nameof(jABGetTablePropertiesonlySearchShowingElements), required: false);
            var __workflow_jABGetTablePropertieselementRolesNotToTraverse = WorkflowExpression.Compile(jABGetTablePropertieselementRolesNotToTraverse, nameof(jABGetTablePropertieselementRolesNotToTraverse), required: false);
            var __workflow_jABGetTablePropertiesmaximumElementsToSearch = WorkflowExpression.Compile(jABGetTablePropertiesmaximumElementsToSearch, nameof(jABGetTablePropertiesmaximumElementsToSearch), required: false);
            var __workflow_jABGetTablePropertiesmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABGetTablePropertiesmaximumChildElementsToSearchPerNode, nameof(jABGetTablePropertiesmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABGetTablePropertiesenumerateViewport = WorkflowExpression.Compile(jABGetTablePropertiesenumerateViewport, nameof(jABGetTablePropertiesenumerateViewport), required: false);
            var __workflow_jABGetTablePropertiesprocessViewportParents = WorkflowExpression.Compile(jABGetTablePropertiesprocessViewportParents, nameof(jABGetTablePropertiesprocessViewportParents), required: false);
            var __workflow_jABGetTablePropertiesmaxViewportParentsToProcess = WorkflowExpression.Compile(jABGetTablePropertiesmaxViewportParentsToProcess, nameof(jABGetTablePropertiesmaxViewportParentsToProcess), required: false);
            var __workflow_jABGetTablePropertiesviewportParentElementRolesToConsider = WorkflowExpression.Compile(jABGetTablePropertiesviewportParentElementRolesToConsider, nameof(jABGetTablePropertiesviewportParentElementRolesToConsider), required: false);
            var __workflow_jABGetTablePropertiesviewportLeftMargin = WorkflowExpression.Compile(jABGetTablePropertiesviewportLeftMargin, nameof(jABGetTablePropertiesviewportLeftMargin), required: false);
            var __workflow_jABGetTablePropertiesviewportTopMargin = WorkflowExpression.Compile(jABGetTablePropertiesviewportTopMargin, nameof(jABGetTablePropertiesviewportTopMargin), required: false);
            var __workflow_jABGetTablePropertiesviewportRightMargin = WorkflowExpression.Compile(jABGetTablePropertiesviewportRightMargin, nameof(jABGetTablePropertiesviewportRightMargin), required: false);
            var __workflow_jABGetTablePropertiesviewportBottomMargin = WorkflowExpression.Compile(jABGetTablePropertiesviewportBottomMargin, nameof(jABGetTablePropertiesviewportBottomMargin), required: false);
            return new DeferredBodyAction<JABGetTablePropertiesResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetTableProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetTableProperties = new JObject();
                var jABGetTablePropertiespropCount = 0;
                jABGetTablePropertiespropCount++;
                jABGetTableProperties["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiessearchParentElementJABHandle);
                if (__workflow_jABGetTablePropertiessearchElementJABName != null)
                {
                    jABGetTableProperties["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiessearchElementJABName);
                    jABGetTablePropertiespropCount++;
                }

                if (__workflow_jABGetTablePropertiessearchElementJABDescription != null)
                {
                    jABGetTableProperties["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiessearchElementJABDescription);
                    jABGetTablePropertiespropCount++;
                }

                if (__workflow_jABGetTablePropertiessearchElementJABRole != null)
                {
                    jABGetTableProperties["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiessearchElementJABRole);
                    jABGetTablePropertiespropCount++;
                }

                if (__workflow_jABGetTablePropertiessearchSubTree != null)
                {
                    if (__workflow_jABGetTablePropertiessearchSubTree != null)
                    {
                        jABGetTableProperties["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiessearchSubTree);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["SearchSubTree"] = true;
                    jABGetTablePropertiespropCount++;
                }

                if (__workflow_jABGetTablePropertiesmaxRelativeDepth != null)
                {
                    if (__workflow_jABGetTablePropertiesmaxRelativeDepth != null)
                    {
                        jABGetTableProperties["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiesmaxRelativeDepth);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["MaxRelativeDepth"] = 0;
                    jABGetTablePropertiespropCount++;
                }

                if (__workflow_jABGetTablePropertiesmatchIndex != null)
                {
                    if (__workflow_jABGetTablePropertiesmatchIndex != null)
                    {
                        jABGetTableProperties["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiesmatchIndex);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["MatchIndex"] = 1;
                    jABGetTablePropertiespropCount++;
                }

                if (__workflow_jABGetTablePropertiessearchFilter != null)
                {
                    jABGetTableProperties["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiessearchFilter);
                    jABGetTablePropertiespropCount++;
                }

                if (__workflow_jABGetTablePropertiessortByColumn != null)
                {
                    jABGetTableProperties["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiessortByColumn);
                    jABGetTablePropertiespropCount++;
                }

                if (__workflow_jABGetTablePropertiesmatchIndexAscending != null)
                {
                    if (__workflow_jABGetTablePropertiesmatchIndexAscending != null)
                    {
                        jABGetTableProperties["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiesmatchIndexAscending);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["MatchIndexAscending"] = true;
                    jABGetTablePropertiespropCount++;
                }

                if (__workflow_jABGetTablePropertiescaseSensitiveSearch != null)
                {
                    if (__workflow_jABGetTablePropertiescaseSensitiveSearch != null)
                    {
                        jABGetTableProperties["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiescaseSensitiveSearch);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["CaseSensitiveSearch"] = false;
                    jABGetTablePropertiespropCount++;
                }

                if (__workflow_jABGetTablePropertiesonlySearchVisibleElements != null)
                {
                    if (__workflow_jABGetTablePropertiesonlySearchVisibleElements != null)
                    {
                        jABGetTableProperties["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiesonlySearchVisibleElements);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["OnlySearchVisibleElements"] = true;
                    jABGetTablePropertiespropCount++;
                }

                if (__workflow_jABGetTablePropertiesonlySearchShowingElements != null)
                {
                    if (__workflow_jABGetTablePropertiesonlySearchShowingElements != null)
                    {
                        jABGetTableProperties["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiesonlySearchShowingElements);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["OnlySearchShowingElements"] = true;
                    jABGetTablePropertiespropCount++;
                }

                if (__workflow_jABGetTablePropertieselementRolesNotToTraverse != null)
                {
                    jABGetTableProperties["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertieselementRolesNotToTraverse);
                    jABGetTablePropertiespropCount++;
                }

                if (__workflow_jABGetTablePropertiesmaximumElementsToSearch != null)
                {
                    if (__workflow_jABGetTablePropertiesmaximumElementsToSearch != null)
                    {
                        jABGetTableProperties["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiesmaximumElementsToSearch);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["MaximumElementsToSearch"] = 2000;
                    jABGetTablePropertiespropCount++;
                }

                if (__workflow_jABGetTablePropertiesmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABGetTablePropertiesmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetTableProperties["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiesmaximumChildElementsToSearchPerNode);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGetTablePropertiespropCount++;
                }

                if (__workflow_jABGetTablePropertiesenumerateViewport != null)
                {
                    if (__workflow_jABGetTablePropertiesenumerateViewport != null)
                    {
                        jABGetTableProperties["EnumerateViewport"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiesenumerateViewport);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["EnumerateViewport"] = true;
                    jABGetTablePropertiespropCount++;
                }

                if (__workflow_jABGetTablePropertiesprocessViewportParents != null)
                {
                    if (__workflow_jABGetTablePropertiesprocessViewportParents != null)
                    {
                        jABGetTableProperties["ProcessViewportParents"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiesprocessViewportParents);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["ProcessViewportParents"] = true;
                    jABGetTablePropertiespropCount++;
                }

                if (__workflow_jABGetTablePropertiesmaxViewportParentsToProcess != null)
                {
                    if (__workflow_jABGetTablePropertiesmaxViewportParentsToProcess != null)
                    {
                        jABGetTableProperties["MaxViewportParentsToProcess"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiesmaxViewportParentsToProcess);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["MaxViewportParentsToProcess"] = 50;
                    jABGetTablePropertiespropCount++;
                }

                if (__workflow_jABGetTablePropertiesviewportParentElementRolesToConsider != null)
                {
                    if (__workflow_jABGetTablePropertiesviewportParentElementRolesToConsider != null)
                    {
                        jABGetTableProperties["ViewportParentElementRolesToConsider"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiesviewportParentElementRolesToConsider);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["ViewportParentElementRolesToConsider"] = "Panel,Viewport,Layered pane,Root pane";
                    jABGetTablePropertiespropCount++;
                }

                if (__workflow_jABGetTablePropertiesviewportLeftMargin != null)
                {
                    if (__workflow_jABGetTablePropertiesviewportLeftMargin != null)
                    {
                        jABGetTableProperties["ViewportLeftMargin"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiesviewportLeftMargin);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["ViewportLeftMargin"] = 2;
                    jABGetTablePropertiespropCount++;
                }

                if (__workflow_jABGetTablePropertiesviewportTopMargin != null)
                {
                    if (__workflow_jABGetTablePropertiesviewportTopMargin != null)
                    {
                        jABGetTableProperties["ViewportTopMargin"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiesviewportTopMargin);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["ViewportTopMargin"] = 2;
                    jABGetTablePropertiespropCount++;
                }

                if (__workflow_jABGetTablePropertiesviewportRightMargin != null)
                {
                    if (__workflow_jABGetTablePropertiesviewportRightMargin != null)
                    {
                        jABGetTableProperties["ViewportRightMargin"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiesviewportRightMargin);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["ViewportRightMargin"] = 2;
                    jABGetTablePropertiespropCount++;
                }

                if (__workflow_jABGetTablePropertiesviewportBottomMargin != null)
                {
                    if (__workflow_jABGetTablePropertiesviewportBottomMargin != null)
                    {
                        jABGetTableProperties["ViewportBottomMargin"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiesviewportBottomMargin);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["ViewportBottomMargin"] = 2;
                    jABGetTablePropertiespropCount++;
                }

                jABGetTablePropertiespropCount++;
                jABGetTableProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetTablePropertiesworkflow);
                if (jABGetTablePropertiespropCount > 0)
                {
                    callPayload.Body = jABGetTableProperties;
                }

                return new ApiConnectionAction<JABGetTablePropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetTableCellPropertiesResponse> JABGetTableCellProperties(Expression<Func<int>> jABGetTableCellPropertiessearchParentElementJABHandle, Expression<Func<int>> jABGetTableCellPropertiesrowIndex, Expression<Func<int>> jABGetTableCellPropertiescolumnIndex, Expression<Func<string>> jABGetTableCellPropertiesworkflow, Expression<Func<string>> jABGetTableCellPropertiessearchElementJABName = null, Expression<Func<string>> jABGetTableCellPropertiessearchElementJABDescription = null, Expression<Func<string>> jABGetTableCellPropertiessearchElementJABRole = null, Expression<Func<bool>> jABGetTableCellPropertiessearchSubTree = null, Expression<Func<int>> jABGetTableCellPropertiesmaxRelativeDepth = null, Expression<Func<int>> jABGetTableCellPropertiesmatchIndex = null, Expression<Func<string>> jABGetTableCellPropertiessearchFilter = null, Expression<Func<string>> jABGetTableCellPropertiessortByColumn = null, Expression<Func<bool>> jABGetTableCellPropertiesmatchIndexAscending = null, Expression<Func<bool>> jABGetTableCellPropertiescaseSensitiveSearch = null, Expression<Func<bool>> jABGetTableCellPropertiesonlySearchVisibleElements = null, Expression<Func<bool>> jABGetTableCellPropertiesonlySearchShowingElements = null, Expression<Func<string>> jABGetTableCellPropertieselementRolesNotToTraverse = null, Expression<Func<int>> jABGetTableCellPropertiesmaximumElementsToSearch = null, Expression<Func<int>> jABGetTableCellPropertiesmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGetTableCellPropertiesreturnJABHandle = null, Expression<Func<bool>> jABGetTableCellPropertiesenumerateViewport = null, Expression<Func<bool>> jABGetTableCellPropertiesprocessViewportParents = null, Expression<Func<int>> jABGetTableCellPropertiesmaxViewportParentsToProcess = null, Expression<Func<string>> jABGetTableCellPropertiesviewportParentElementRolesToConsider = null, Expression<Func<int>> jABGetTableCellPropertiesviewportLeftMargin = null, Expression<Func<int>> jABGetTableCellPropertiesviewportTopMargin = null, Expression<Func<int>> jABGetTableCellPropertiesviewportRightMargin = null, Expression<Func<int>> jABGetTableCellPropertiesviewportBottomMargin = null)
        {
            var __workflow_jABGetTableCellPropertiessearchParentElementJABHandle = WorkflowExpression.Compile(jABGetTableCellPropertiessearchParentElementJABHandle, nameof(jABGetTableCellPropertiessearchParentElementJABHandle), required: true);
            var __workflow_jABGetTableCellPropertiesrowIndex = WorkflowExpression.Compile(jABGetTableCellPropertiesrowIndex, nameof(jABGetTableCellPropertiesrowIndex), required: true);
            var __workflow_jABGetTableCellPropertiescolumnIndex = WorkflowExpression.Compile(jABGetTableCellPropertiescolumnIndex, nameof(jABGetTableCellPropertiescolumnIndex), required: true);
            var __workflow_jABGetTableCellPropertiesworkflow = WorkflowExpression.Compile(jABGetTableCellPropertiesworkflow, nameof(jABGetTableCellPropertiesworkflow), required: true);
            var __workflow_jABGetTableCellPropertiessearchElementJABName = WorkflowExpression.Compile(jABGetTableCellPropertiessearchElementJABName, nameof(jABGetTableCellPropertiessearchElementJABName), required: false);
            var __workflow_jABGetTableCellPropertiessearchElementJABDescription = WorkflowExpression.Compile(jABGetTableCellPropertiessearchElementJABDescription, nameof(jABGetTableCellPropertiessearchElementJABDescription), required: false);
            var __workflow_jABGetTableCellPropertiessearchElementJABRole = WorkflowExpression.Compile(jABGetTableCellPropertiessearchElementJABRole, nameof(jABGetTableCellPropertiessearchElementJABRole), required: false);
            var __workflow_jABGetTableCellPropertiessearchSubTree = WorkflowExpression.Compile(jABGetTableCellPropertiessearchSubTree, nameof(jABGetTableCellPropertiessearchSubTree), required: false);
            var __workflow_jABGetTableCellPropertiesmaxRelativeDepth = WorkflowExpression.Compile(jABGetTableCellPropertiesmaxRelativeDepth, nameof(jABGetTableCellPropertiesmaxRelativeDepth), required: false);
            var __workflow_jABGetTableCellPropertiesmatchIndex = WorkflowExpression.Compile(jABGetTableCellPropertiesmatchIndex, nameof(jABGetTableCellPropertiesmatchIndex), required: false);
            var __workflow_jABGetTableCellPropertiessearchFilter = WorkflowExpression.Compile(jABGetTableCellPropertiessearchFilter, nameof(jABGetTableCellPropertiessearchFilter), required: false);
            var __workflow_jABGetTableCellPropertiessortByColumn = WorkflowExpression.Compile(jABGetTableCellPropertiessortByColumn, nameof(jABGetTableCellPropertiessortByColumn), required: false);
            var __workflow_jABGetTableCellPropertiesmatchIndexAscending = WorkflowExpression.Compile(jABGetTableCellPropertiesmatchIndexAscending, nameof(jABGetTableCellPropertiesmatchIndexAscending), required: false);
            var __workflow_jABGetTableCellPropertiescaseSensitiveSearch = WorkflowExpression.Compile(jABGetTableCellPropertiescaseSensitiveSearch, nameof(jABGetTableCellPropertiescaseSensitiveSearch), required: false);
            var __workflow_jABGetTableCellPropertiesonlySearchVisibleElements = WorkflowExpression.Compile(jABGetTableCellPropertiesonlySearchVisibleElements, nameof(jABGetTableCellPropertiesonlySearchVisibleElements), required: false);
            var __workflow_jABGetTableCellPropertiesonlySearchShowingElements = WorkflowExpression.Compile(jABGetTableCellPropertiesonlySearchShowingElements, nameof(jABGetTableCellPropertiesonlySearchShowingElements), required: false);
            var __workflow_jABGetTableCellPropertieselementRolesNotToTraverse = WorkflowExpression.Compile(jABGetTableCellPropertieselementRolesNotToTraverse, nameof(jABGetTableCellPropertieselementRolesNotToTraverse), required: false);
            var __workflow_jABGetTableCellPropertiesmaximumElementsToSearch = WorkflowExpression.Compile(jABGetTableCellPropertiesmaximumElementsToSearch, nameof(jABGetTableCellPropertiesmaximumElementsToSearch), required: false);
            var __workflow_jABGetTableCellPropertiesmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABGetTableCellPropertiesmaximumChildElementsToSearchPerNode, nameof(jABGetTableCellPropertiesmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABGetTableCellPropertiesreturnJABHandle = WorkflowExpression.Compile(jABGetTableCellPropertiesreturnJABHandle, nameof(jABGetTableCellPropertiesreturnJABHandle), required: false);
            var __workflow_jABGetTableCellPropertiesenumerateViewport = WorkflowExpression.Compile(jABGetTableCellPropertiesenumerateViewport, nameof(jABGetTableCellPropertiesenumerateViewport), required: false);
            var __workflow_jABGetTableCellPropertiesprocessViewportParents = WorkflowExpression.Compile(jABGetTableCellPropertiesprocessViewportParents, nameof(jABGetTableCellPropertiesprocessViewportParents), required: false);
            var __workflow_jABGetTableCellPropertiesmaxViewportParentsToProcess = WorkflowExpression.Compile(jABGetTableCellPropertiesmaxViewportParentsToProcess, nameof(jABGetTableCellPropertiesmaxViewportParentsToProcess), required: false);
            var __workflow_jABGetTableCellPropertiesviewportParentElementRolesToConsider = WorkflowExpression.Compile(jABGetTableCellPropertiesviewportParentElementRolesToConsider, nameof(jABGetTableCellPropertiesviewportParentElementRolesToConsider), required: false);
            var __workflow_jABGetTableCellPropertiesviewportLeftMargin = WorkflowExpression.Compile(jABGetTableCellPropertiesviewportLeftMargin, nameof(jABGetTableCellPropertiesviewportLeftMargin), required: false);
            var __workflow_jABGetTableCellPropertiesviewportTopMargin = WorkflowExpression.Compile(jABGetTableCellPropertiesviewportTopMargin, nameof(jABGetTableCellPropertiesviewportTopMargin), required: false);
            var __workflow_jABGetTableCellPropertiesviewportRightMargin = WorkflowExpression.Compile(jABGetTableCellPropertiesviewportRightMargin, nameof(jABGetTableCellPropertiesviewportRightMargin), required: false);
            var __workflow_jABGetTableCellPropertiesviewportBottomMargin = WorkflowExpression.Compile(jABGetTableCellPropertiesviewportBottomMargin, nameof(jABGetTableCellPropertiesviewportBottomMargin), required: false);
            return new DeferredBodyAction<JABGetTableCellPropertiesResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetTableCellProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetTableCellProperties = new JObject();
                var jABGetTableCellPropertiespropCount = 0;
                jABGetTableCellPropertiespropCount++;
                jABGetTableCellProperties["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiessearchParentElementJABHandle);
                if (__workflow_jABGetTableCellPropertiessearchElementJABName != null)
                {
                    jABGetTableCellProperties["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiessearchElementJABName);
                    jABGetTableCellPropertiespropCount++;
                }

                if (__workflow_jABGetTableCellPropertiessearchElementJABDescription != null)
                {
                    jABGetTableCellProperties["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiessearchElementJABDescription);
                    jABGetTableCellPropertiespropCount++;
                }

                if (__workflow_jABGetTableCellPropertiessearchElementJABRole != null)
                {
                    jABGetTableCellProperties["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiessearchElementJABRole);
                    jABGetTableCellPropertiespropCount++;
                }

                if (__workflow_jABGetTableCellPropertiessearchSubTree != null)
                {
                    if (__workflow_jABGetTableCellPropertiessearchSubTree != null)
                    {
                        jABGetTableCellProperties["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiessearchSubTree);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["SearchSubTree"] = true;
                    jABGetTableCellPropertiespropCount++;
                }

                if (__workflow_jABGetTableCellPropertiesmaxRelativeDepth != null)
                {
                    if (__workflow_jABGetTableCellPropertiesmaxRelativeDepth != null)
                    {
                        jABGetTableCellProperties["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiesmaxRelativeDepth);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["MaxRelativeDepth"] = 0;
                    jABGetTableCellPropertiespropCount++;
                }

                if (__workflow_jABGetTableCellPropertiesmatchIndex != null)
                {
                    if (__workflow_jABGetTableCellPropertiesmatchIndex != null)
                    {
                        jABGetTableCellProperties["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiesmatchIndex);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["MatchIndex"] = 1;
                    jABGetTableCellPropertiespropCount++;
                }

                if (__workflow_jABGetTableCellPropertiessearchFilter != null)
                {
                    jABGetTableCellProperties["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiessearchFilter);
                    jABGetTableCellPropertiespropCount++;
                }

                if (__workflow_jABGetTableCellPropertiessortByColumn != null)
                {
                    jABGetTableCellProperties["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiessortByColumn);
                    jABGetTableCellPropertiespropCount++;
                }

                if (__workflow_jABGetTableCellPropertiesmatchIndexAscending != null)
                {
                    if (__workflow_jABGetTableCellPropertiesmatchIndexAscending != null)
                    {
                        jABGetTableCellProperties["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiesmatchIndexAscending);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["MatchIndexAscending"] = true;
                    jABGetTableCellPropertiespropCount++;
                }

                if (__workflow_jABGetTableCellPropertiescaseSensitiveSearch != null)
                {
                    if (__workflow_jABGetTableCellPropertiescaseSensitiveSearch != null)
                    {
                        jABGetTableCellProperties["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiescaseSensitiveSearch);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["CaseSensitiveSearch"] = false;
                    jABGetTableCellPropertiespropCount++;
                }

                if (__workflow_jABGetTableCellPropertiesonlySearchVisibleElements != null)
                {
                    if (__workflow_jABGetTableCellPropertiesonlySearchVisibleElements != null)
                    {
                        jABGetTableCellProperties["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiesonlySearchVisibleElements);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["OnlySearchVisibleElements"] = true;
                    jABGetTableCellPropertiespropCount++;
                }

                if (__workflow_jABGetTableCellPropertiesonlySearchShowingElements != null)
                {
                    if (__workflow_jABGetTableCellPropertiesonlySearchShowingElements != null)
                    {
                        jABGetTableCellProperties["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiesonlySearchShowingElements);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["OnlySearchShowingElements"] = true;
                    jABGetTableCellPropertiespropCount++;
                }

                if (__workflow_jABGetTableCellPropertieselementRolesNotToTraverse != null)
                {
                    jABGetTableCellProperties["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertieselementRolesNotToTraverse);
                    jABGetTableCellPropertiespropCount++;
                }

                if (__workflow_jABGetTableCellPropertiesmaximumElementsToSearch != null)
                {
                    if (__workflow_jABGetTableCellPropertiesmaximumElementsToSearch != null)
                    {
                        jABGetTableCellProperties["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiesmaximumElementsToSearch);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["MaximumElementsToSearch"] = 2000;
                    jABGetTableCellPropertiespropCount++;
                }

                if (__workflow_jABGetTableCellPropertiesmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABGetTableCellPropertiesmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetTableCellProperties["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiesmaximumChildElementsToSearchPerNode);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGetTableCellPropertiespropCount++;
                }

                jABGetTableCellPropertiespropCount++;
                jABGetTableCellProperties["RowIndex"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiesrowIndex);
                jABGetTableCellPropertiespropCount++;
                jABGetTableCellProperties["ColumnIndex"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiescolumnIndex);
                if (__workflow_jABGetTableCellPropertiesreturnJABHandle != null)
                {
                    if (__workflow_jABGetTableCellPropertiesreturnJABHandle != null)
                    {
                        jABGetTableCellProperties["ReturnJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiesreturnJABHandle);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["ReturnJABHandle"] = false;
                    jABGetTableCellPropertiespropCount++;
                }

                if (__workflow_jABGetTableCellPropertiesenumerateViewport != null)
                {
                    if (__workflow_jABGetTableCellPropertiesenumerateViewport != null)
                    {
                        jABGetTableCellProperties["EnumerateViewport"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiesenumerateViewport);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["EnumerateViewport"] = true;
                    jABGetTableCellPropertiespropCount++;
                }

                if (__workflow_jABGetTableCellPropertiesprocessViewportParents != null)
                {
                    if (__workflow_jABGetTableCellPropertiesprocessViewportParents != null)
                    {
                        jABGetTableCellProperties["ProcessViewportParents"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiesprocessViewportParents);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["ProcessViewportParents"] = true;
                    jABGetTableCellPropertiespropCount++;
                }

                if (__workflow_jABGetTableCellPropertiesmaxViewportParentsToProcess != null)
                {
                    if (__workflow_jABGetTableCellPropertiesmaxViewportParentsToProcess != null)
                    {
                        jABGetTableCellProperties["MaxViewportParentsToProcess"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiesmaxViewportParentsToProcess);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["MaxViewportParentsToProcess"] = 50;
                    jABGetTableCellPropertiespropCount++;
                }

                if (__workflow_jABGetTableCellPropertiesviewportParentElementRolesToConsider != null)
                {
                    if (__workflow_jABGetTableCellPropertiesviewportParentElementRolesToConsider != null)
                    {
                        jABGetTableCellProperties["ViewportParentElementRolesToConsider"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiesviewportParentElementRolesToConsider);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["ViewportParentElementRolesToConsider"] = "Panel,Viewport,Layered pane,Root pane";
                    jABGetTableCellPropertiespropCount++;
                }

                if (__workflow_jABGetTableCellPropertiesviewportLeftMargin != null)
                {
                    if (__workflow_jABGetTableCellPropertiesviewportLeftMargin != null)
                    {
                        jABGetTableCellProperties["ViewportLeftMargin"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiesviewportLeftMargin);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["ViewportLeftMargin"] = 2;
                    jABGetTableCellPropertiespropCount++;
                }

                if (__workflow_jABGetTableCellPropertiesviewportTopMargin != null)
                {
                    if (__workflow_jABGetTableCellPropertiesviewportTopMargin != null)
                    {
                        jABGetTableCellProperties["ViewportTopMargin"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiesviewportTopMargin);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["ViewportTopMargin"] = 2;
                    jABGetTableCellPropertiespropCount++;
                }

                if (__workflow_jABGetTableCellPropertiesviewportRightMargin != null)
                {
                    if (__workflow_jABGetTableCellPropertiesviewportRightMargin != null)
                    {
                        jABGetTableCellProperties["ViewportRightMargin"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiesviewportRightMargin);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["ViewportRightMargin"] = 2;
                    jABGetTableCellPropertiespropCount++;
                }

                if (__workflow_jABGetTableCellPropertiesviewportBottomMargin != null)
                {
                    if (__workflow_jABGetTableCellPropertiesviewportBottomMargin != null)
                    {
                        jABGetTableCellProperties["ViewportBottomMargin"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiesviewportBottomMargin);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["ViewportBottomMargin"] = 2;
                    jABGetTableCellPropertiespropCount++;
                }

                jABGetTableCellPropertiespropCount++;
                jABGetTableCellProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellPropertiesworkflow);
                if (jABGetTableCellPropertiespropCount > 0)
                {
                    callPayload.Body = jABGetTableCellProperties;
                }

                return new ApiConnectionAction<JABGetTableCellPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetTableContentsResponse> JABGetTableContents(Expression<Func<int>> jABGetTableContentssearchParentElementJABHandle, Expression<Func<string>> jABGetTableContentsworkflow, Expression<Func<string>> jABGetTableContentssearchElementJABName = null, Expression<Func<string>> jABGetTableContentssearchElementJABDescription = null, Expression<Func<string>> jABGetTableContentssearchElementJABRole = null, Expression<Func<bool>> jABGetTableContentssearchSubTree = null, Expression<Func<int>> jABGetTableContentsmaxRelativeDepth = null, Expression<Func<int>> jABGetTableContentsmatchIndex = null, Expression<Func<string>> jABGetTableContentssearchFilter = null, Expression<Func<string>> jABGetTableContentssortByColumn = null, Expression<Func<bool>> jABGetTableContentsmatchIndexAscending = null, Expression<Func<bool>> jABGetTableContentscaseSensitiveSearch = null, Expression<Func<bool>> jABGetTableContentsonlySearchVisibleElements = null, Expression<Func<bool>> jABGetTableContentsonlySearchShowingElements = null, Expression<Func<string>> jABGetTableContentselementRolesNotToTraverse = null, Expression<Func<int>> jABGetTableContentsmaximumElementsToSearch = null, Expression<Func<int>> jABGetTableContentsmaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABGetTableContentsfirstRowToReturn = null, Expression<Func<int>> jABGetTableContentsmaxRowsToReturn = null, Expression<Func<int>> jABGetTableContentsfirstColumnToReturn = null, Expression<Func<int>> jABGetTableContentsmaxColumnsToReturn = null, Expression<Func<bool>> jABGetTableContentsuseColumnHeadersFromTable = null, Expression<Func<bool>> jABGetTableContentsreturnRowIndexInOutputCollection = null, Expression<Func<string>> jABGetTableContentsnameOfColumnToStoreRowIndex = null)
        {
            var __workflow_jABGetTableContentssearchParentElementJABHandle = WorkflowExpression.Compile(jABGetTableContentssearchParentElementJABHandle, nameof(jABGetTableContentssearchParentElementJABHandle), required: true);
            var __workflow_jABGetTableContentsworkflow = WorkflowExpression.Compile(jABGetTableContentsworkflow, nameof(jABGetTableContentsworkflow), required: true);
            var __workflow_jABGetTableContentssearchElementJABName = WorkflowExpression.Compile(jABGetTableContentssearchElementJABName, nameof(jABGetTableContentssearchElementJABName), required: false);
            var __workflow_jABGetTableContentssearchElementJABDescription = WorkflowExpression.Compile(jABGetTableContentssearchElementJABDescription, nameof(jABGetTableContentssearchElementJABDescription), required: false);
            var __workflow_jABGetTableContentssearchElementJABRole = WorkflowExpression.Compile(jABGetTableContentssearchElementJABRole, nameof(jABGetTableContentssearchElementJABRole), required: false);
            var __workflow_jABGetTableContentssearchSubTree = WorkflowExpression.Compile(jABGetTableContentssearchSubTree, nameof(jABGetTableContentssearchSubTree), required: false);
            var __workflow_jABGetTableContentsmaxRelativeDepth = WorkflowExpression.Compile(jABGetTableContentsmaxRelativeDepth, nameof(jABGetTableContentsmaxRelativeDepth), required: false);
            var __workflow_jABGetTableContentsmatchIndex = WorkflowExpression.Compile(jABGetTableContentsmatchIndex, nameof(jABGetTableContentsmatchIndex), required: false);
            var __workflow_jABGetTableContentssearchFilter = WorkflowExpression.Compile(jABGetTableContentssearchFilter, nameof(jABGetTableContentssearchFilter), required: false);
            var __workflow_jABGetTableContentssortByColumn = WorkflowExpression.Compile(jABGetTableContentssortByColumn, nameof(jABGetTableContentssortByColumn), required: false);
            var __workflow_jABGetTableContentsmatchIndexAscending = WorkflowExpression.Compile(jABGetTableContentsmatchIndexAscending, nameof(jABGetTableContentsmatchIndexAscending), required: false);
            var __workflow_jABGetTableContentscaseSensitiveSearch = WorkflowExpression.Compile(jABGetTableContentscaseSensitiveSearch, nameof(jABGetTableContentscaseSensitiveSearch), required: false);
            var __workflow_jABGetTableContentsonlySearchVisibleElements = WorkflowExpression.Compile(jABGetTableContentsonlySearchVisibleElements, nameof(jABGetTableContentsonlySearchVisibleElements), required: false);
            var __workflow_jABGetTableContentsonlySearchShowingElements = WorkflowExpression.Compile(jABGetTableContentsonlySearchShowingElements, nameof(jABGetTableContentsonlySearchShowingElements), required: false);
            var __workflow_jABGetTableContentselementRolesNotToTraverse = WorkflowExpression.Compile(jABGetTableContentselementRolesNotToTraverse, nameof(jABGetTableContentselementRolesNotToTraverse), required: false);
            var __workflow_jABGetTableContentsmaximumElementsToSearch = WorkflowExpression.Compile(jABGetTableContentsmaximumElementsToSearch, nameof(jABGetTableContentsmaximumElementsToSearch), required: false);
            var __workflow_jABGetTableContentsmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABGetTableContentsmaximumChildElementsToSearchPerNode, nameof(jABGetTableContentsmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABGetTableContentsfirstRowToReturn = WorkflowExpression.Compile(jABGetTableContentsfirstRowToReturn, nameof(jABGetTableContentsfirstRowToReturn), required: false);
            var __workflow_jABGetTableContentsmaxRowsToReturn = WorkflowExpression.Compile(jABGetTableContentsmaxRowsToReturn, nameof(jABGetTableContentsmaxRowsToReturn), required: false);
            var __workflow_jABGetTableContentsfirstColumnToReturn = WorkflowExpression.Compile(jABGetTableContentsfirstColumnToReturn, nameof(jABGetTableContentsfirstColumnToReturn), required: false);
            var __workflow_jABGetTableContentsmaxColumnsToReturn = WorkflowExpression.Compile(jABGetTableContentsmaxColumnsToReturn, nameof(jABGetTableContentsmaxColumnsToReturn), required: false);
            var __workflow_jABGetTableContentsuseColumnHeadersFromTable = WorkflowExpression.Compile(jABGetTableContentsuseColumnHeadersFromTable, nameof(jABGetTableContentsuseColumnHeadersFromTable), required: false);
            var __workflow_jABGetTableContentsreturnRowIndexInOutputCollection = WorkflowExpression.Compile(jABGetTableContentsreturnRowIndexInOutputCollection, nameof(jABGetTableContentsreturnRowIndexInOutputCollection), required: false);
            var __workflow_jABGetTableContentsnameOfColumnToStoreRowIndex = WorkflowExpression.Compile(jABGetTableContentsnameOfColumnToStoreRowIndex, nameof(jABGetTableContentsnameOfColumnToStoreRowIndex), required: false);
            return new DeferredBodyAction<JABGetTableContentsResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetTableContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetTableContents = new JObject();
                var jABGetTableContentspropCount = 0;
                jABGetTableContentspropCount++;
                jABGetTableContents["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentssearchParentElementJABHandle);
                if (__workflow_jABGetTableContentssearchElementJABName != null)
                {
                    jABGetTableContents["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentssearchElementJABName);
                    jABGetTableContentspropCount++;
                }

                if (__workflow_jABGetTableContentssearchElementJABDescription != null)
                {
                    jABGetTableContents["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentssearchElementJABDescription);
                    jABGetTableContentspropCount++;
                }

                if (__workflow_jABGetTableContentssearchElementJABRole != null)
                {
                    jABGetTableContents["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentssearchElementJABRole);
                    jABGetTableContentspropCount++;
                }

                if (__workflow_jABGetTableContentssearchSubTree != null)
                {
                    if (__workflow_jABGetTableContentssearchSubTree != null)
                    {
                        jABGetTableContents["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentssearchSubTree);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["SearchSubTree"] = true;
                    jABGetTableContentspropCount++;
                }

                if (__workflow_jABGetTableContentsmaxRelativeDepth != null)
                {
                    if (__workflow_jABGetTableContentsmaxRelativeDepth != null)
                    {
                        jABGetTableContents["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentsmaxRelativeDepth);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["MaxRelativeDepth"] = 0;
                    jABGetTableContentspropCount++;
                }

                if (__workflow_jABGetTableContentsmatchIndex != null)
                {
                    if (__workflow_jABGetTableContentsmatchIndex != null)
                    {
                        jABGetTableContents["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentsmatchIndex);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["MatchIndex"] = 1;
                    jABGetTableContentspropCount++;
                }

                if (__workflow_jABGetTableContentssearchFilter != null)
                {
                    jABGetTableContents["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentssearchFilter);
                    jABGetTableContentspropCount++;
                }

                if (__workflow_jABGetTableContentssortByColumn != null)
                {
                    jABGetTableContents["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentssortByColumn);
                    jABGetTableContentspropCount++;
                }

                if (__workflow_jABGetTableContentsmatchIndexAscending != null)
                {
                    if (__workflow_jABGetTableContentsmatchIndexAscending != null)
                    {
                        jABGetTableContents["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentsmatchIndexAscending);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["MatchIndexAscending"] = true;
                    jABGetTableContentspropCount++;
                }

                if (__workflow_jABGetTableContentscaseSensitiveSearch != null)
                {
                    if (__workflow_jABGetTableContentscaseSensitiveSearch != null)
                    {
                        jABGetTableContents["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentscaseSensitiveSearch);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["CaseSensitiveSearch"] = false;
                    jABGetTableContentspropCount++;
                }

                if (__workflow_jABGetTableContentsonlySearchVisibleElements != null)
                {
                    if (__workflow_jABGetTableContentsonlySearchVisibleElements != null)
                    {
                        jABGetTableContents["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentsonlySearchVisibleElements);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["OnlySearchVisibleElements"] = true;
                    jABGetTableContentspropCount++;
                }

                if (__workflow_jABGetTableContentsonlySearchShowingElements != null)
                {
                    if (__workflow_jABGetTableContentsonlySearchShowingElements != null)
                    {
                        jABGetTableContents["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentsonlySearchShowingElements);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["OnlySearchShowingElements"] = true;
                    jABGetTableContentspropCount++;
                }

                if (__workflow_jABGetTableContentselementRolesNotToTraverse != null)
                {
                    jABGetTableContents["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentselementRolesNotToTraverse);
                    jABGetTableContentspropCount++;
                }

                if (__workflow_jABGetTableContentsmaximumElementsToSearch != null)
                {
                    if (__workflow_jABGetTableContentsmaximumElementsToSearch != null)
                    {
                        jABGetTableContents["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentsmaximumElementsToSearch);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["MaximumElementsToSearch"] = 2000;
                    jABGetTableContentspropCount++;
                }

                if (__workflow_jABGetTableContentsmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABGetTableContentsmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetTableContents["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentsmaximumChildElementsToSearchPerNode);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGetTableContentspropCount++;
                }

                if (__workflow_jABGetTableContentsfirstRowToReturn != null)
                {
                    if (__workflow_jABGetTableContentsfirstRowToReturn != null)
                    {
                        jABGetTableContents["FirstRowToReturn"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentsfirstRowToReturn);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["FirstRowToReturn"] = 1;
                    jABGetTableContentspropCount++;
                }

                if (__workflow_jABGetTableContentsmaxRowsToReturn != null)
                {
                    if (__workflow_jABGetTableContentsmaxRowsToReturn != null)
                    {
                        jABGetTableContents["MaxRowsToReturn"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentsmaxRowsToReturn);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["MaxRowsToReturn"] = 0;
                    jABGetTableContentspropCount++;
                }

                if (__workflow_jABGetTableContentsfirstColumnToReturn != null)
                {
                    if (__workflow_jABGetTableContentsfirstColumnToReturn != null)
                    {
                        jABGetTableContents["FirstColumnToReturn"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentsfirstColumnToReturn);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["FirstColumnToReturn"] = 1;
                    jABGetTableContentspropCount++;
                }

                if (__workflow_jABGetTableContentsmaxColumnsToReturn != null)
                {
                    if (__workflow_jABGetTableContentsmaxColumnsToReturn != null)
                    {
                        jABGetTableContents["MaxColumnsToReturn"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentsmaxColumnsToReturn);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["MaxColumnsToReturn"] = 0;
                    jABGetTableContentspropCount++;
                }

                if (__workflow_jABGetTableContentsuseColumnHeadersFromTable != null)
                {
                    if (__workflow_jABGetTableContentsuseColumnHeadersFromTable != null)
                    {
                        jABGetTableContents["UseColumnHeadersFromTable"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentsuseColumnHeadersFromTable);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["UseColumnHeadersFromTable"] = false;
                    jABGetTableContentspropCount++;
                }

                if (__workflow_jABGetTableContentsreturnRowIndexInOutputCollection != null)
                {
                    if (__workflow_jABGetTableContentsreturnRowIndexInOutputCollection != null)
                    {
                        jABGetTableContents["ReturnRowIndexInOutputCollection"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentsreturnRowIndexInOutputCollection);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["ReturnRowIndexInOutputCollection"] = true;
                    jABGetTableContentspropCount++;
                }

                if (__workflow_jABGetTableContentsnameOfColumnToStoreRowIndex != null)
                {
                    jABGetTableContents["NameOfColumnToStoreRowIndex"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentsnameOfColumnToStoreRowIndex);
                    jABGetTableContentspropCount++;
                }

                jABGetTableContentspropCount++;
                jABGetTableContents["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetTableContentsworkflow);
                if (jABGetTableContentspropCount > 0)
                {
                    callPayload.Body = jABGetTableContents;
                }

                return new ApiConnectionAction<JABGetTableContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABIsTableCellVisibleOnscreenResponse> JABIsTableCellVisibleOnscreen(Expression<Func<int>> jABIsTableCellVisibleOnscreensearchParentElementJABHandle, Expression<Func<int>> jABIsTableCellVisibleOnscreencellRowIndex, Expression<Func<int>> jABIsTableCellVisibleOnscreencellColumnIndex, Expression<Func<string>> jABIsTableCellVisibleOnscreenworkflow, Expression<Func<string>> jABIsTableCellVisibleOnscreensearchElementJABName = null, Expression<Func<string>> jABIsTableCellVisibleOnscreensearchElementJABDescription = null, Expression<Func<string>> jABIsTableCellVisibleOnscreensearchElementJABRole = null, Expression<Func<bool>> jABIsTableCellVisibleOnscreensearchSubTree = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenmaxRelativeDepth = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenmatchIndex = null, Expression<Func<string>> jABIsTableCellVisibleOnscreensearchFilter = null, Expression<Func<string>> jABIsTableCellVisibleOnscreensortByColumn = null, Expression<Func<bool>> jABIsTableCellVisibleOnscreenmatchIndexAscending = null, Expression<Func<bool>> jABIsTableCellVisibleOnscreencaseSensitiveSearch = null, Expression<Func<bool>> jABIsTableCellVisibleOnscreenonlySearchVisibleElements = null, Expression<Func<bool>> jABIsTableCellVisibleOnscreenonlySearchShowingElements = null, Expression<Func<string>> jABIsTableCellVisibleOnscreenelementRolesNotToTraverse = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenmaximumElementsToSearch = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABIsTableCellVisibleOnscreenprocessViewportParents = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenmaxViewportParentsToProcess = null, Expression<Func<string>> jABIsTableCellVisibleOnscreenviewportParentElementRolesToConsider = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenviewportLeftMargin = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenviewportTopMargin = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenviewportRightMargin = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenviewportBottomMargin = null)
        {
            var __workflow_jABIsTableCellVisibleOnscreensearchParentElementJABHandle = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreensearchParentElementJABHandle, nameof(jABIsTableCellVisibleOnscreensearchParentElementJABHandle), required: true);
            var __workflow_jABIsTableCellVisibleOnscreencellRowIndex = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreencellRowIndex, nameof(jABIsTableCellVisibleOnscreencellRowIndex), required: true);
            var __workflow_jABIsTableCellVisibleOnscreencellColumnIndex = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreencellColumnIndex, nameof(jABIsTableCellVisibleOnscreencellColumnIndex), required: true);
            var __workflow_jABIsTableCellVisibleOnscreenworkflow = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreenworkflow, nameof(jABIsTableCellVisibleOnscreenworkflow), required: true);
            var __workflow_jABIsTableCellVisibleOnscreensearchElementJABName = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreensearchElementJABName, nameof(jABIsTableCellVisibleOnscreensearchElementJABName), required: false);
            var __workflow_jABIsTableCellVisibleOnscreensearchElementJABDescription = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreensearchElementJABDescription, nameof(jABIsTableCellVisibleOnscreensearchElementJABDescription), required: false);
            var __workflow_jABIsTableCellVisibleOnscreensearchElementJABRole = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreensearchElementJABRole, nameof(jABIsTableCellVisibleOnscreensearchElementJABRole), required: false);
            var __workflow_jABIsTableCellVisibleOnscreensearchSubTree = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreensearchSubTree, nameof(jABIsTableCellVisibleOnscreensearchSubTree), required: false);
            var __workflow_jABIsTableCellVisibleOnscreenmaxRelativeDepth = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreenmaxRelativeDepth, nameof(jABIsTableCellVisibleOnscreenmaxRelativeDepth), required: false);
            var __workflow_jABIsTableCellVisibleOnscreenmatchIndex = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreenmatchIndex, nameof(jABIsTableCellVisibleOnscreenmatchIndex), required: false);
            var __workflow_jABIsTableCellVisibleOnscreensearchFilter = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreensearchFilter, nameof(jABIsTableCellVisibleOnscreensearchFilter), required: false);
            var __workflow_jABIsTableCellVisibleOnscreensortByColumn = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreensortByColumn, nameof(jABIsTableCellVisibleOnscreensortByColumn), required: false);
            var __workflow_jABIsTableCellVisibleOnscreenmatchIndexAscending = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreenmatchIndexAscending, nameof(jABIsTableCellVisibleOnscreenmatchIndexAscending), required: false);
            var __workflow_jABIsTableCellVisibleOnscreencaseSensitiveSearch = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreencaseSensitiveSearch, nameof(jABIsTableCellVisibleOnscreencaseSensitiveSearch), required: false);
            var __workflow_jABIsTableCellVisibleOnscreenonlySearchVisibleElements = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreenonlySearchVisibleElements, nameof(jABIsTableCellVisibleOnscreenonlySearchVisibleElements), required: false);
            var __workflow_jABIsTableCellVisibleOnscreenonlySearchShowingElements = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreenonlySearchShowingElements, nameof(jABIsTableCellVisibleOnscreenonlySearchShowingElements), required: false);
            var __workflow_jABIsTableCellVisibleOnscreenelementRolesNotToTraverse = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreenelementRolesNotToTraverse, nameof(jABIsTableCellVisibleOnscreenelementRolesNotToTraverse), required: false);
            var __workflow_jABIsTableCellVisibleOnscreenmaximumElementsToSearch = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreenmaximumElementsToSearch, nameof(jABIsTableCellVisibleOnscreenmaximumElementsToSearch), required: false);
            var __workflow_jABIsTableCellVisibleOnscreenmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreenmaximumChildElementsToSearchPerNode, nameof(jABIsTableCellVisibleOnscreenmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABIsTableCellVisibleOnscreenprocessViewportParents = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreenprocessViewportParents, nameof(jABIsTableCellVisibleOnscreenprocessViewportParents), required: false);
            var __workflow_jABIsTableCellVisibleOnscreenmaxViewportParentsToProcess = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreenmaxViewportParentsToProcess, nameof(jABIsTableCellVisibleOnscreenmaxViewportParentsToProcess), required: false);
            var __workflow_jABIsTableCellVisibleOnscreenviewportParentElementRolesToConsider = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreenviewportParentElementRolesToConsider, nameof(jABIsTableCellVisibleOnscreenviewportParentElementRolesToConsider), required: false);
            var __workflow_jABIsTableCellVisibleOnscreenviewportLeftMargin = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreenviewportLeftMargin, nameof(jABIsTableCellVisibleOnscreenviewportLeftMargin), required: false);
            var __workflow_jABIsTableCellVisibleOnscreenviewportTopMargin = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreenviewportTopMargin, nameof(jABIsTableCellVisibleOnscreenviewportTopMargin), required: false);
            var __workflow_jABIsTableCellVisibleOnscreenviewportRightMargin = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreenviewportRightMargin, nameof(jABIsTableCellVisibleOnscreenviewportRightMargin), required: false);
            var __workflow_jABIsTableCellVisibleOnscreenviewportBottomMargin = WorkflowExpression.Compile(jABIsTableCellVisibleOnscreenviewportBottomMargin, nameof(jABIsTableCellVisibleOnscreenviewportBottomMargin), required: false);
            return new DeferredBodyAction<JABIsTableCellVisibleOnscreenResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABIsTableCellVisibleOnscreen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABIsTableCellVisibleOnscreen = new JObject();
                var jABIsTableCellVisibleOnscreenpropCount = 0;
                jABIsTableCellVisibleOnscreenpropCount++;
                jABIsTableCellVisibleOnscreen["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreensearchParentElementJABHandle);
                if (__workflow_jABIsTableCellVisibleOnscreensearchElementJABName != null)
                {
                    jABIsTableCellVisibleOnscreen["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreensearchElementJABName);
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (__workflow_jABIsTableCellVisibleOnscreensearchElementJABDescription != null)
                {
                    jABIsTableCellVisibleOnscreen["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreensearchElementJABDescription);
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (__workflow_jABIsTableCellVisibleOnscreensearchElementJABRole != null)
                {
                    jABIsTableCellVisibleOnscreen["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreensearchElementJABRole);
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (__workflow_jABIsTableCellVisibleOnscreensearchSubTree != null)
                {
                    if (__workflow_jABIsTableCellVisibleOnscreensearchSubTree != null)
                    {
                        jABIsTableCellVisibleOnscreen["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreensearchSubTree);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["SearchSubTree"] = true;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (__workflow_jABIsTableCellVisibleOnscreenmaxRelativeDepth != null)
                {
                    if (__workflow_jABIsTableCellVisibleOnscreenmaxRelativeDepth != null)
                    {
                        jABIsTableCellVisibleOnscreen["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreenmaxRelativeDepth);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["MaxRelativeDepth"] = 0;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (__workflow_jABIsTableCellVisibleOnscreenmatchIndex != null)
                {
                    if (__workflow_jABIsTableCellVisibleOnscreenmatchIndex != null)
                    {
                        jABIsTableCellVisibleOnscreen["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreenmatchIndex);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["MatchIndex"] = 1;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (__workflow_jABIsTableCellVisibleOnscreensearchFilter != null)
                {
                    jABIsTableCellVisibleOnscreen["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreensearchFilter);
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (__workflow_jABIsTableCellVisibleOnscreensortByColumn != null)
                {
                    jABIsTableCellVisibleOnscreen["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreensortByColumn);
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (__workflow_jABIsTableCellVisibleOnscreenmatchIndexAscending != null)
                {
                    if (__workflow_jABIsTableCellVisibleOnscreenmatchIndexAscending != null)
                    {
                        jABIsTableCellVisibleOnscreen["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreenmatchIndexAscending);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["MatchIndexAscending"] = true;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (__workflow_jABIsTableCellVisibleOnscreencaseSensitiveSearch != null)
                {
                    if (__workflow_jABIsTableCellVisibleOnscreencaseSensitiveSearch != null)
                    {
                        jABIsTableCellVisibleOnscreen["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreencaseSensitiveSearch);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["CaseSensitiveSearch"] = false;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (__workflow_jABIsTableCellVisibleOnscreenonlySearchVisibleElements != null)
                {
                    if (__workflow_jABIsTableCellVisibleOnscreenonlySearchVisibleElements != null)
                    {
                        jABIsTableCellVisibleOnscreen["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreenonlySearchVisibleElements);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["OnlySearchVisibleElements"] = true;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (__workflow_jABIsTableCellVisibleOnscreenonlySearchShowingElements != null)
                {
                    if (__workflow_jABIsTableCellVisibleOnscreenonlySearchShowingElements != null)
                    {
                        jABIsTableCellVisibleOnscreen["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreenonlySearchShowingElements);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["OnlySearchShowingElements"] = true;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (__workflow_jABIsTableCellVisibleOnscreenelementRolesNotToTraverse != null)
                {
                    jABIsTableCellVisibleOnscreen["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreenelementRolesNotToTraverse);
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (__workflow_jABIsTableCellVisibleOnscreenmaximumElementsToSearch != null)
                {
                    if (__workflow_jABIsTableCellVisibleOnscreenmaximumElementsToSearch != null)
                    {
                        jABIsTableCellVisibleOnscreen["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreenmaximumElementsToSearch);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["MaximumElementsToSearch"] = 2000;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (__workflow_jABIsTableCellVisibleOnscreenmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABIsTableCellVisibleOnscreenmaximumChildElementsToSearchPerNode != null)
                    {
                        jABIsTableCellVisibleOnscreen["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreenmaximumChildElementsToSearchPerNode);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["MaximumChildElementsToSearchPerNode"] = 200;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (__workflow_jABIsTableCellVisibleOnscreenprocessViewportParents != null)
                {
                    if (__workflow_jABIsTableCellVisibleOnscreenprocessViewportParents != null)
                    {
                        jABIsTableCellVisibleOnscreen["ProcessViewportParents"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreenprocessViewportParents);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["ProcessViewportParents"] = true;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (__workflow_jABIsTableCellVisibleOnscreenmaxViewportParentsToProcess != null)
                {
                    if (__workflow_jABIsTableCellVisibleOnscreenmaxViewportParentsToProcess != null)
                    {
                        jABIsTableCellVisibleOnscreen["MaxViewportParentsToProcess"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreenmaxViewportParentsToProcess);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["MaxViewportParentsToProcess"] = 50;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (__workflow_jABIsTableCellVisibleOnscreenviewportParentElementRolesToConsider != null)
                {
                    if (__workflow_jABIsTableCellVisibleOnscreenviewportParentElementRolesToConsider != null)
                    {
                        jABIsTableCellVisibleOnscreen["ViewportParentElementRolesToConsider"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreenviewportParentElementRolesToConsider);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["ViewportParentElementRolesToConsider"] = "Panel,Viewport,Layered pane,Root pane";
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (__workflow_jABIsTableCellVisibleOnscreenviewportLeftMargin != null)
                {
                    if (__workflow_jABIsTableCellVisibleOnscreenviewportLeftMargin != null)
                    {
                        jABIsTableCellVisibleOnscreen["ViewportLeftMargin"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreenviewportLeftMargin);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["ViewportLeftMargin"] = 2;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (__workflow_jABIsTableCellVisibleOnscreenviewportTopMargin != null)
                {
                    if (__workflow_jABIsTableCellVisibleOnscreenviewportTopMargin != null)
                    {
                        jABIsTableCellVisibleOnscreen["ViewportTopMargin"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreenviewportTopMargin);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["ViewportTopMargin"] = 2;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (__workflow_jABIsTableCellVisibleOnscreenviewportRightMargin != null)
                {
                    if (__workflow_jABIsTableCellVisibleOnscreenviewportRightMargin != null)
                    {
                        jABIsTableCellVisibleOnscreen["ViewportRightMargin"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreenviewportRightMargin);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["ViewportRightMargin"] = 2;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (__workflow_jABIsTableCellVisibleOnscreenviewportBottomMargin != null)
                {
                    if (__workflow_jABIsTableCellVisibleOnscreenviewportBottomMargin != null)
                    {
                        jABIsTableCellVisibleOnscreen["ViewportBottomMargin"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreenviewportBottomMargin);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["ViewportBottomMargin"] = 2;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                jABIsTableCellVisibleOnscreenpropCount++;
                jABIsTableCellVisibleOnscreen["CellRowIndex"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreencellRowIndex);
                jABIsTableCellVisibleOnscreenpropCount++;
                jABIsTableCellVisibleOnscreen["CellColumnIndex"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreencellColumnIndex);
                jABIsTableCellVisibleOnscreenpropCount++;
                jABIsTableCellVisibleOnscreen["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABIsTableCellVisibleOnscreenworkflow);
                if (jABIsTableCellVisibleOnscreenpropCount > 0)
                {
                    callPayload.Body = jABIsTableCellVisibleOnscreen;
                }

                return new ApiConnectionAction<JABIsTableCellVisibleOnscreenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABIsJABHandleSameObjectResponse> JABIsJABHandleSameObject(Expression<Func<int>> jABIsJABHandleSameObjectelement1JABHandle, Expression<Func<int>> jABIsJABHandleSameObjectelement2JABHandle, Expression<Func<string>> jABIsJABHandleSameObjectworkflow)
        {
            var __workflow_jABIsJABHandleSameObjectelement1JABHandle = WorkflowExpression.Compile(jABIsJABHandleSameObjectelement1JABHandle, nameof(jABIsJABHandleSameObjectelement1JABHandle), required: true);
            var __workflow_jABIsJABHandleSameObjectelement2JABHandle = WorkflowExpression.Compile(jABIsJABHandleSameObjectelement2JABHandle, nameof(jABIsJABHandleSameObjectelement2JABHandle), required: true);
            var __workflow_jABIsJABHandleSameObjectworkflow = WorkflowExpression.Compile(jABIsJABHandleSameObjectworkflow, nameof(jABIsJABHandleSameObjectworkflow), required: true);
            return new DeferredBodyAction<JABIsJABHandleSameObjectResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABIsJABHandleSameObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABIsJABHandleSameObject = new JObject();
                var jABIsJABHandleSameObjectpropCount = 0;
                jABIsJABHandleSameObjectpropCount++;
                jABIsJABHandleSameObject["Element1JABHandle"] = ExpressionConverter.ConvertO(__workflow_jABIsJABHandleSameObjectelement1JABHandle);
                jABIsJABHandleSameObjectpropCount++;
                jABIsJABHandleSameObject["Element2JABHandle"] = ExpressionConverter.ConvertO(__workflow_jABIsJABHandleSameObjectelement2JABHandle);
                jABIsJABHandleSameObjectpropCount++;
                jABIsJABHandleSameObject["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABIsJABHandleSameObjectworkflow);
                if (jABIsJABHandleSameObjectpropCount > 0)
                {
                    callPayload.Body = jABIsJABHandleSameObject;
                }

                return new ApiConnectionAction<JABIsJABHandleSameObjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetVisibleBoundingRectangleOfElementOnscreenResponse> JABGetVisibleBoundingRectangleOfElementOnscreen(Expression<Func<int>> jABGetVisibleBoundingRectangleOfElementOnscreenelementJABHandle, Expression<Func<string>> jABGetVisibleBoundingRectangleOfElementOnscreenworkflow, Expression<Func<int>> jABGetVisibleBoundingRectangleOfElementOnscreenmaxParentsToProcess = null, Expression<Func<string>> jABGetVisibleBoundingRectangleOfElementOnscreenparentElementRolesToConsider = null, Expression<Func<bool>> jABGetVisibleBoundingRectangleOfElementOnscreendrawRectangle = null)
        {
            var __workflow_jABGetVisibleBoundingRectangleOfElementOnscreenelementJABHandle = WorkflowExpression.Compile(jABGetVisibleBoundingRectangleOfElementOnscreenelementJABHandle, nameof(jABGetVisibleBoundingRectangleOfElementOnscreenelementJABHandle), required: true);
            var __workflow_jABGetVisibleBoundingRectangleOfElementOnscreenworkflow = WorkflowExpression.Compile(jABGetVisibleBoundingRectangleOfElementOnscreenworkflow, nameof(jABGetVisibleBoundingRectangleOfElementOnscreenworkflow), required: true);
            var __workflow_jABGetVisibleBoundingRectangleOfElementOnscreenmaxParentsToProcess = WorkflowExpression.Compile(jABGetVisibleBoundingRectangleOfElementOnscreenmaxParentsToProcess, nameof(jABGetVisibleBoundingRectangleOfElementOnscreenmaxParentsToProcess), required: false);
            var __workflow_jABGetVisibleBoundingRectangleOfElementOnscreenparentElementRolesToConsider = WorkflowExpression.Compile(jABGetVisibleBoundingRectangleOfElementOnscreenparentElementRolesToConsider, nameof(jABGetVisibleBoundingRectangleOfElementOnscreenparentElementRolesToConsider), required: false);
            var __workflow_jABGetVisibleBoundingRectangleOfElementOnscreendrawRectangle = WorkflowExpression.Compile(jABGetVisibleBoundingRectangleOfElementOnscreendrawRectangle, nameof(jABGetVisibleBoundingRectangleOfElementOnscreendrawRectangle), required: false);
            return new DeferredBodyAction<JABGetVisibleBoundingRectangleOfElementOnscreenResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetVisibleBoundingRectangleOfElementOnscreen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetVisibleBoundingRectangleOfElementOnscreen = new JObject();
                var jABGetVisibleBoundingRectangleOfElementOnscreenpropCount = 0;
                jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
                jABGetVisibleBoundingRectangleOfElementOnscreen["ElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGetVisibleBoundingRectangleOfElementOnscreenelementJABHandle);
                if (__workflow_jABGetVisibleBoundingRectangleOfElementOnscreenmaxParentsToProcess != null)
                {
                    if (__workflow_jABGetVisibleBoundingRectangleOfElementOnscreenmaxParentsToProcess != null)
                    {
                        jABGetVisibleBoundingRectangleOfElementOnscreen["MaxParentsToProcess"] = ExpressionConverter.ConvertO(__workflow_jABGetVisibleBoundingRectangleOfElementOnscreenmaxParentsToProcess);
                        jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
                    }

                    jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
                }
                else
                {
                    jABGetVisibleBoundingRectangleOfElementOnscreen["MaxParentsToProcess"] = 0;
                    jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
                }

                if (__workflow_jABGetVisibleBoundingRectangleOfElementOnscreenparentElementRolesToConsider != null)
                {
                    if (__workflow_jABGetVisibleBoundingRectangleOfElementOnscreenparentElementRolesToConsider != null)
                    {
                        jABGetVisibleBoundingRectangleOfElementOnscreen["ParentElementRolesToConsider"] = ExpressionConverter.ConvertO(__workflow_jABGetVisibleBoundingRectangleOfElementOnscreenparentElementRolesToConsider);
                        jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
                    }

                    jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
                }
                else
                {
                    jABGetVisibleBoundingRectangleOfElementOnscreen["ParentElementRolesToConsider"] = "Panel,Viewport,Layered pane,Root pane";
                    jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
                }

                if (__workflow_jABGetVisibleBoundingRectangleOfElementOnscreendrawRectangle != null)
                {
                    if (__workflow_jABGetVisibleBoundingRectangleOfElementOnscreendrawRectangle != null)
                    {
                        jABGetVisibleBoundingRectangleOfElementOnscreen["DrawRectangle"] = ExpressionConverter.ConvertO(__workflow_jABGetVisibleBoundingRectangleOfElementOnscreendrawRectangle);
                        jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
                    }

                    jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
                }
                else
                {
                    jABGetVisibleBoundingRectangleOfElementOnscreen["DrawRectangle"] = false;
                    jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
                }

                jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
                jABGetVisibleBoundingRectangleOfElementOnscreen["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetVisibleBoundingRectangleOfElementOnscreenworkflow);
                if (jABGetVisibleBoundingRectangleOfElementOnscreenpropCount > 0)
                {
                    callPayload.Body = jABGetVisibleBoundingRectangleOfElementOnscreen;
                }

                return new ApiConnectionAction<JABGetVisibleBoundingRectangleOfElementOnscreenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABCreateHandleForJABElementAtScreenCoordinateResponse> JABCreateHandleForJABElementAtScreenCoordinate(Expression<Func<int>> jABCreateHandleForJABElementAtScreenCoordinateparentElementJABHandle, Expression<Func<int>> jABCreateHandleForJABElementAtScreenCoordinatescreenX, Expression<Func<int>> jABCreateHandleForJABElementAtScreenCoordinatescreenY, Expression<Func<string>> jABCreateHandleForJABElementAtScreenCoordinateworkflow)
        {
            var __workflow_jABCreateHandleForJABElementAtScreenCoordinateparentElementJABHandle = WorkflowExpression.Compile(jABCreateHandleForJABElementAtScreenCoordinateparentElementJABHandle, nameof(jABCreateHandleForJABElementAtScreenCoordinateparentElementJABHandle), required: true);
            var __workflow_jABCreateHandleForJABElementAtScreenCoordinatescreenX = WorkflowExpression.Compile(jABCreateHandleForJABElementAtScreenCoordinatescreenX, nameof(jABCreateHandleForJABElementAtScreenCoordinatescreenX), required: true);
            var __workflow_jABCreateHandleForJABElementAtScreenCoordinatescreenY = WorkflowExpression.Compile(jABCreateHandleForJABElementAtScreenCoordinatescreenY, nameof(jABCreateHandleForJABElementAtScreenCoordinatescreenY), required: true);
            var __workflow_jABCreateHandleForJABElementAtScreenCoordinateworkflow = WorkflowExpression.Compile(jABCreateHandleForJABElementAtScreenCoordinateworkflow, nameof(jABCreateHandleForJABElementAtScreenCoordinateworkflow), required: true);
            return new DeferredBodyAction<JABCreateHandleForJABElementAtScreenCoordinateResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABCreateHandleForJABElementAtScreenCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABCreateHandleForJABElementAtScreenCoordinate = new JObject();
                var jABCreateHandleForJABElementAtScreenCoordinatepropCount = 0;
                jABCreateHandleForJABElementAtScreenCoordinatepropCount++;
                jABCreateHandleForJABElementAtScreenCoordinate["ParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABCreateHandleForJABElementAtScreenCoordinateparentElementJABHandle);
                jABCreateHandleForJABElementAtScreenCoordinatepropCount++;
                jABCreateHandleForJABElementAtScreenCoordinate["ScreenX"] = ExpressionConverter.ConvertO(__workflow_jABCreateHandleForJABElementAtScreenCoordinatescreenX);
                jABCreateHandleForJABElementAtScreenCoordinatepropCount++;
                jABCreateHandleForJABElementAtScreenCoordinate["ScreenY"] = ExpressionConverter.ConvertO(__workflow_jABCreateHandleForJABElementAtScreenCoordinatescreenY);
                jABCreateHandleForJABElementAtScreenCoordinatepropCount++;
                jABCreateHandleForJABElementAtScreenCoordinate["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABCreateHandleForJABElementAtScreenCoordinateworkflow);
                if (jABCreateHandleForJABElementAtScreenCoordinatepropCount > 0)
                {
                    callPayload.Body = jABCreateHandleForJABElementAtScreenCoordinate;
                }

                return new ApiConnectionAction<JABCreateHandleForJABElementAtScreenCoordinateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetTableCellAtScreenCoordinateResponse> JABGetTableCellAtScreenCoordinate(Expression<Func<int>> jABGetTableCellAtScreenCoordinatetableElementJABHandle, Expression<Func<int>> jABGetTableCellAtScreenCoordinatescreenX, Expression<Func<int>> jABGetTableCellAtScreenCoordinatescreenY, Expression<Func<string>> jABGetTableCellAtScreenCoordinateworkflow, Expression<Func<bool>> jABGetTableCellAtScreenCoordinatereturnJABHandle = null)
        {
            var __workflow_jABGetTableCellAtScreenCoordinatetableElementJABHandle = WorkflowExpression.Compile(jABGetTableCellAtScreenCoordinatetableElementJABHandle, nameof(jABGetTableCellAtScreenCoordinatetableElementJABHandle), required: true);
            var __workflow_jABGetTableCellAtScreenCoordinatescreenX = WorkflowExpression.Compile(jABGetTableCellAtScreenCoordinatescreenX, nameof(jABGetTableCellAtScreenCoordinatescreenX), required: true);
            var __workflow_jABGetTableCellAtScreenCoordinatescreenY = WorkflowExpression.Compile(jABGetTableCellAtScreenCoordinatescreenY, nameof(jABGetTableCellAtScreenCoordinatescreenY), required: true);
            var __workflow_jABGetTableCellAtScreenCoordinateworkflow = WorkflowExpression.Compile(jABGetTableCellAtScreenCoordinateworkflow, nameof(jABGetTableCellAtScreenCoordinateworkflow), required: true);
            var __workflow_jABGetTableCellAtScreenCoordinatereturnJABHandle = WorkflowExpression.Compile(jABGetTableCellAtScreenCoordinatereturnJABHandle, nameof(jABGetTableCellAtScreenCoordinatereturnJABHandle), required: false);
            return new DeferredBodyAction<JABGetTableCellAtScreenCoordinateResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetTableCellAtScreenCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetTableCellAtScreenCoordinate = new JObject();
                var jABGetTableCellAtScreenCoordinatepropCount = 0;
                jABGetTableCellAtScreenCoordinatepropCount++;
                jABGetTableCellAtScreenCoordinate["TableElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellAtScreenCoordinatetableElementJABHandle);
                jABGetTableCellAtScreenCoordinatepropCount++;
                jABGetTableCellAtScreenCoordinate["ScreenX"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellAtScreenCoordinatescreenX);
                jABGetTableCellAtScreenCoordinatepropCount++;
                jABGetTableCellAtScreenCoordinate["ScreenY"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellAtScreenCoordinatescreenY);
                if (__workflow_jABGetTableCellAtScreenCoordinatereturnJABHandle != null)
                {
                    if (__workflow_jABGetTableCellAtScreenCoordinatereturnJABHandle != null)
                    {
                        jABGetTableCellAtScreenCoordinate["ReturnJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellAtScreenCoordinatereturnJABHandle);
                        jABGetTableCellAtScreenCoordinatepropCount++;
                    }

                    jABGetTableCellAtScreenCoordinatepropCount++;
                }
                else
                {
                    jABGetTableCellAtScreenCoordinate["ReturnJABHandle"] = false;
                    jABGetTableCellAtScreenCoordinatepropCount++;
                }

                jABGetTableCellAtScreenCoordinatepropCount++;
                jABGetTableCellAtScreenCoordinate["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetTableCellAtScreenCoordinateworkflow);
                if (jABGetTableCellAtScreenCoordinatepropCount > 0)
                {
                    callPayload.Body = jABGetTableCellAtScreenCoordinate;
                }

                return new ApiConnectionAction<JABGetTableCellAtScreenCoordinateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetMultipleParentJABElementPropertiesResponse> JABGetMultipleParentJABElementProperties(Expression<Func<int>> jABGetMultipleParentJABElementPropertiessearchElementJABHandle, Expression<Func<string>> jABGetMultipleParentJABElementPropertiesworkflow, Expression<Func<int>> jABGetMultipleParentJABElementPropertiesmaxStringLength = null, Expression<Func<int>> jABGetMultipleParentJABElementPropertiesmaxParentsToProcess = null)
        {
            var __workflow_jABGetMultipleParentJABElementPropertiessearchElementJABHandle = WorkflowExpression.Compile(jABGetMultipleParentJABElementPropertiessearchElementJABHandle, nameof(jABGetMultipleParentJABElementPropertiessearchElementJABHandle), required: true);
            var __workflow_jABGetMultipleParentJABElementPropertiesworkflow = WorkflowExpression.Compile(jABGetMultipleParentJABElementPropertiesworkflow, nameof(jABGetMultipleParentJABElementPropertiesworkflow), required: true);
            var __workflow_jABGetMultipleParentJABElementPropertiesmaxStringLength = WorkflowExpression.Compile(jABGetMultipleParentJABElementPropertiesmaxStringLength, nameof(jABGetMultipleParentJABElementPropertiesmaxStringLength), required: false);
            var __workflow_jABGetMultipleParentJABElementPropertiesmaxParentsToProcess = WorkflowExpression.Compile(jABGetMultipleParentJABElementPropertiesmaxParentsToProcess, nameof(jABGetMultipleParentJABElementPropertiesmaxParentsToProcess), required: false);
            return new DeferredBodyAction<JABGetMultipleParentJABElementPropertiesResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetMultipleParentJABElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetMultipleParentJABElementProperties = new JObject();
                var jABGetMultipleParentJABElementPropertiespropCount = 0;
                jABGetMultipleParentJABElementPropertiespropCount++;
                jABGetMultipleParentJABElementProperties["SearchElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGetMultipleParentJABElementPropertiessearchElementJABHandle);
                if (__workflow_jABGetMultipleParentJABElementPropertiesmaxStringLength != null)
                {
                    if (__workflow_jABGetMultipleParentJABElementPropertiesmaxStringLength != null)
                    {
                        jABGetMultipleParentJABElementProperties["MaxStringLength"] = ExpressionConverter.ConvertO(__workflow_jABGetMultipleParentJABElementPropertiesmaxStringLength);
                        jABGetMultipleParentJABElementPropertiespropCount++;
                    }

                    jABGetMultipleParentJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetMultipleParentJABElementProperties["MaxStringLength"] = 0;
                    jABGetMultipleParentJABElementPropertiespropCount++;
                }

                if (__workflow_jABGetMultipleParentJABElementPropertiesmaxParentsToProcess != null)
                {
                    if (__workflow_jABGetMultipleParentJABElementPropertiesmaxParentsToProcess != null)
                    {
                        jABGetMultipleParentJABElementProperties["MaxParentsToProcess"] = ExpressionConverter.ConvertO(__workflow_jABGetMultipleParentJABElementPropertiesmaxParentsToProcess);
                        jABGetMultipleParentJABElementPropertiespropCount++;
                    }

                    jABGetMultipleParentJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetMultipleParentJABElementProperties["MaxParentsToProcess"] = 0;
                    jABGetMultipleParentJABElementPropertiespropCount++;
                }

                jABGetMultipleParentJABElementPropertiespropCount++;
                jABGetMultipleParentJABElementProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetMultipleParentJABElementPropertiesworkflow);
                if (jABGetMultipleParentJABElementPropertiespropCount > 0)
                {
                    callPayload.Body = jABGetMultipleParentJABElementProperties;
                }

                return new ApiConnectionAction<JABGetMultipleParentJABElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalMouseClickOnTableCell(Expression<Func<int>> jABGlobalMouseClickOnTableCellsearchParentElementJABHandle, Expression<Func<int>> jABGlobalMouseClickOnTableCellrowIndex, Expression<Func<int>> jABGlobalMouseClickOnTableCellcolumnIndex, Expression<Func<int>> jABGlobalMouseClickOnTableCellmouseButton, Expression<Func<string>> jABGlobalMouseClickOnTableCellworkflow, Expression<Func<string>> jABGlobalMouseClickOnTableCellsearchElementJABName = null, Expression<Func<string>> jABGlobalMouseClickOnTableCellsearchElementJABDescription = null, Expression<Func<string>> jABGlobalMouseClickOnTableCellsearchElementJABRole = null, Expression<Func<bool>> jABGlobalMouseClickOnTableCellsearchSubTree = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellmaxRelativeDepth = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellmatchIndex = null, Expression<Func<string>> jABGlobalMouseClickOnTableCellsearchFilter = null, Expression<Func<string>> jABGlobalMouseClickOnTableCellsortByColumn = null, Expression<Func<bool>> jABGlobalMouseClickOnTableCellmatchIndexAscending = null, Expression<Func<bool>> jABGlobalMouseClickOnTableCellcaseSensitiveSearch = null, Expression<Func<bool>> jABGlobalMouseClickOnTableCellonlySearchVisibleElements = null, Expression<Func<bool>> jABGlobalMouseClickOnTableCellonlySearchShowingElements = null, Expression<Func<string>> jABGlobalMouseClickOnTableCellelementRolesNotToTraverse = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellmaximumElementsToSearch = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGlobalMouseClickOnTableCellenumerateViewport = null, Expression<Func<bool>> jABGlobalMouseClickOnTableCellprocessViewportParents = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellmaxViewportParentsToProcess = null, Expression<Func<string>> jABGlobalMouseClickOnTableCellviewportParentElementRolesToConsider = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellviewportLeftMargin = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellviewportTopMargin = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellviewportRightMargin = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellviewportBottomMargin = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellclickOffsetX = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellclickOffsetY = null, Expression<Func<jABGlobalMouseClickOnTableCelloffsetRelativeToInput>> jABGlobalMouseClickOnTableCelloffsetRelativeTo = null, Expression<Func<int>> jABGlobalMouseClickOnTableCelldelayInMilliseconds = null)
        {
            var __workflow_jABGlobalMouseClickOnTableCellsearchParentElementJABHandle = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellsearchParentElementJABHandle, nameof(jABGlobalMouseClickOnTableCellsearchParentElementJABHandle), required: true);
            var __workflow_jABGlobalMouseClickOnTableCellrowIndex = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellrowIndex, nameof(jABGlobalMouseClickOnTableCellrowIndex), required: true);
            var __workflow_jABGlobalMouseClickOnTableCellcolumnIndex = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellcolumnIndex, nameof(jABGlobalMouseClickOnTableCellcolumnIndex), required: true);
            var __workflow_jABGlobalMouseClickOnTableCellmouseButton = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellmouseButton, nameof(jABGlobalMouseClickOnTableCellmouseButton), required: true);
            var __workflow_jABGlobalMouseClickOnTableCellworkflow = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellworkflow, nameof(jABGlobalMouseClickOnTableCellworkflow), required: true);
            var __workflow_jABGlobalMouseClickOnTableCellsearchElementJABName = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellsearchElementJABName, nameof(jABGlobalMouseClickOnTableCellsearchElementJABName), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellsearchElementJABDescription = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellsearchElementJABDescription, nameof(jABGlobalMouseClickOnTableCellsearchElementJABDescription), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellsearchElementJABRole = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellsearchElementJABRole, nameof(jABGlobalMouseClickOnTableCellsearchElementJABRole), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellsearchSubTree = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellsearchSubTree, nameof(jABGlobalMouseClickOnTableCellsearchSubTree), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellmaxRelativeDepth = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellmaxRelativeDepth, nameof(jABGlobalMouseClickOnTableCellmaxRelativeDepth), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellmatchIndex = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellmatchIndex, nameof(jABGlobalMouseClickOnTableCellmatchIndex), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellsearchFilter = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellsearchFilter, nameof(jABGlobalMouseClickOnTableCellsearchFilter), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellsortByColumn = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellsortByColumn, nameof(jABGlobalMouseClickOnTableCellsortByColumn), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellmatchIndexAscending = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellmatchIndexAscending, nameof(jABGlobalMouseClickOnTableCellmatchIndexAscending), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellcaseSensitiveSearch = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellcaseSensitiveSearch, nameof(jABGlobalMouseClickOnTableCellcaseSensitiveSearch), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellonlySearchVisibleElements = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellonlySearchVisibleElements, nameof(jABGlobalMouseClickOnTableCellonlySearchVisibleElements), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellonlySearchShowingElements = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellonlySearchShowingElements, nameof(jABGlobalMouseClickOnTableCellonlySearchShowingElements), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellelementRolesNotToTraverse = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellelementRolesNotToTraverse, nameof(jABGlobalMouseClickOnTableCellelementRolesNotToTraverse), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellmaximumElementsToSearch = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellmaximumElementsToSearch, nameof(jABGlobalMouseClickOnTableCellmaximumElementsToSearch), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellmaximumChildElementsToSearchPerNode, nameof(jABGlobalMouseClickOnTableCellmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellenumerateViewport = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellenumerateViewport, nameof(jABGlobalMouseClickOnTableCellenumerateViewport), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellprocessViewportParents = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellprocessViewportParents, nameof(jABGlobalMouseClickOnTableCellprocessViewportParents), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellmaxViewportParentsToProcess = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellmaxViewportParentsToProcess, nameof(jABGlobalMouseClickOnTableCellmaxViewportParentsToProcess), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellviewportParentElementRolesToConsider = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellviewportParentElementRolesToConsider, nameof(jABGlobalMouseClickOnTableCellviewportParentElementRolesToConsider), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellviewportLeftMargin = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellviewportLeftMargin, nameof(jABGlobalMouseClickOnTableCellviewportLeftMargin), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellviewportTopMargin = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellviewportTopMargin, nameof(jABGlobalMouseClickOnTableCellviewportTopMargin), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellviewportRightMargin = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellviewportRightMargin, nameof(jABGlobalMouseClickOnTableCellviewportRightMargin), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellviewportBottomMargin = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellviewportBottomMargin, nameof(jABGlobalMouseClickOnTableCellviewportBottomMargin), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellclickOffsetX = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellclickOffsetX, nameof(jABGlobalMouseClickOnTableCellclickOffsetX), required: false);
            var __workflow_jABGlobalMouseClickOnTableCellclickOffsetY = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCellclickOffsetY, nameof(jABGlobalMouseClickOnTableCellclickOffsetY), required: false);
            var __workflow_jABGlobalMouseClickOnTableCelloffsetRelativeTo = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCelloffsetRelativeTo, nameof(jABGlobalMouseClickOnTableCelloffsetRelativeTo), required: false);
            var __workflow_jABGlobalMouseClickOnTableCelldelayInMilliseconds = WorkflowExpression.Compile(jABGlobalMouseClickOnTableCelldelayInMilliseconds, nameof(jABGlobalMouseClickOnTableCelldelayInMilliseconds), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalMouseClickOnTableCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGlobalMouseClickOnTableCell = new JObject();
                var jABGlobalMouseClickOnTableCellpropCount = 0;
                jABGlobalMouseClickOnTableCellpropCount++;
                jABGlobalMouseClickOnTableCell["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellsearchParentElementJABHandle);
                if (__workflow_jABGlobalMouseClickOnTableCellsearchElementJABName != null)
                {
                    jABGlobalMouseClickOnTableCell["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellsearchElementJABName);
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCellsearchElementJABDescription != null)
                {
                    jABGlobalMouseClickOnTableCell["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellsearchElementJABDescription);
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCellsearchElementJABRole != null)
                {
                    jABGlobalMouseClickOnTableCell["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellsearchElementJABRole);
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCellsearchSubTree != null)
                {
                    if (__workflow_jABGlobalMouseClickOnTableCellsearchSubTree != null)
                    {
                        jABGlobalMouseClickOnTableCell["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellsearchSubTree);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["SearchSubTree"] = true;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCellmaxRelativeDepth != null)
                {
                    if (__workflow_jABGlobalMouseClickOnTableCellmaxRelativeDepth != null)
                    {
                        jABGlobalMouseClickOnTableCell["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellmaxRelativeDepth);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["MaxRelativeDepth"] = 0;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCellmatchIndex != null)
                {
                    if (__workflow_jABGlobalMouseClickOnTableCellmatchIndex != null)
                    {
                        jABGlobalMouseClickOnTableCell["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellmatchIndex);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["MatchIndex"] = 1;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCellsearchFilter != null)
                {
                    jABGlobalMouseClickOnTableCell["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellsearchFilter);
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCellsortByColumn != null)
                {
                    jABGlobalMouseClickOnTableCell["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellsortByColumn);
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCellmatchIndexAscending != null)
                {
                    if (__workflow_jABGlobalMouseClickOnTableCellmatchIndexAscending != null)
                    {
                        jABGlobalMouseClickOnTableCell["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellmatchIndexAscending);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["MatchIndexAscending"] = true;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCellcaseSensitiveSearch != null)
                {
                    if (__workflow_jABGlobalMouseClickOnTableCellcaseSensitiveSearch != null)
                    {
                        jABGlobalMouseClickOnTableCell["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellcaseSensitiveSearch);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["CaseSensitiveSearch"] = false;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCellonlySearchVisibleElements != null)
                {
                    if (__workflow_jABGlobalMouseClickOnTableCellonlySearchVisibleElements != null)
                    {
                        jABGlobalMouseClickOnTableCell["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellonlySearchVisibleElements);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["OnlySearchVisibleElements"] = true;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCellonlySearchShowingElements != null)
                {
                    if (__workflow_jABGlobalMouseClickOnTableCellonlySearchShowingElements != null)
                    {
                        jABGlobalMouseClickOnTableCell["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellonlySearchShowingElements);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["OnlySearchShowingElements"] = true;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCellelementRolesNotToTraverse != null)
                {
                    jABGlobalMouseClickOnTableCell["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellelementRolesNotToTraverse);
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCellmaximumElementsToSearch != null)
                {
                    if (__workflow_jABGlobalMouseClickOnTableCellmaximumElementsToSearch != null)
                    {
                        jABGlobalMouseClickOnTableCell["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellmaximumElementsToSearch);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["MaximumElementsToSearch"] = 2000;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCellmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABGlobalMouseClickOnTableCellmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGlobalMouseClickOnTableCell["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellmaximumChildElementsToSearchPerNode);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                jABGlobalMouseClickOnTableCellpropCount++;
                jABGlobalMouseClickOnTableCell["RowIndex"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellrowIndex);
                jABGlobalMouseClickOnTableCellpropCount++;
                jABGlobalMouseClickOnTableCell["ColumnIndex"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellcolumnIndex);
                if (__workflow_jABGlobalMouseClickOnTableCellenumerateViewport != null)
                {
                    if (__workflow_jABGlobalMouseClickOnTableCellenumerateViewport != null)
                    {
                        jABGlobalMouseClickOnTableCell["EnumerateViewport"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellenumerateViewport);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["EnumerateViewport"] = true;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCellprocessViewportParents != null)
                {
                    if (__workflow_jABGlobalMouseClickOnTableCellprocessViewportParents != null)
                    {
                        jABGlobalMouseClickOnTableCell["ProcessViewportParents"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellprocessViewportParents);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["ProcessViewportParents"] = true;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCellmaxViewportParentsToProcess != null)
                {
                    if (__workflow_jABGlobalMouseClickOnTableCellmaxViewportParentsToProcess != null)
                    {
                        jABGlobalMouseClickOnTableCell["MaxViewportParentsToProcess"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellmaxViewportParentsToProcess);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["MaxViewportParentsToProcess"] = 50;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCellviewportParentElementRolesToConsider != null)
                {
                    if (__workflow_jABGlobalMouseClickOnTableCellviewportParentElementRolesToConsider != null)
                    {
                        jABGlobalMouseClickOnTableCell["ViewportParentElementRolesToConsider"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellviewportParentElementRolesToConsider);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["ViewportParentElementRolesToConsider"] = "Panel,Viewport,Layered pane,Root pane";
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCellviewportLeftMargin != null)
                {
                    if (__workflow_jABGlobalMouseClickOnTableCellviewportLeftMargin != null)
                    {
                        jABGlobalMouseClickOnTableCell["ViewportLeftMargin"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellviewportLeftMargin);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["ViewportLeftMargin"] = 2;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCellviewportTopMargin != null)
                {
                    if (__workflow_jABGlobalMouseClickOnTableCellviewportTopMargin != null)
                    {
                        jABGlobalMouseClickOnTableCell["ViewportTopMargin"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellviewportTopMargin);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["ViewportTopMargin"] = 2;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCellviewportRightMargin != null)
                {
                    if (__workflow_jABGlobalMouseClickOnTableCellviewportRightMargin != null)
                    {
                        jABGlobalMouseClickOnTableCell["ViewportRightMargin"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellviewportRightMargin);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["ViewportRightMargin"] = 2;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCellviewportBottomMargin != null)
                {
                    if (__workflow_jABGlobalMouseClickOnTableCellviewportBottomMargin != null)
                    {
                        jABGlobalMouseClickOnTableCell["ViewportBottomMargin"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellviewportBottomMargin);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["ViewportBottomMargin"] = 2;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                jABGlobalMouseClickOnTableCellpropCount++;
                jABGlobalMouseClickOnTableCell["MouseButton"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellmouseButton);
                if (__workflow_jABGlobalMouseClickOnTableCellclickOffsetX != null)
                {
                    if (__workflow_jABGlobalMouseClickOnTableCellclickOffsetX != null)
                    {
                        jABGlobalMouseClickOnTableCell["ClickOffsetX"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellclickOffsetX);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["ClickOffsetX"] = 0;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCellclickOffsetY != null)
                {
                    if (__workflow_jABGlobalMouseClickOnTableCellclickOffsetY != null)
                    {
                        jABGlobalMouseClickOnTableCell["ClickOffsetY"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellclickOffsetY);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["ClickOffsetY"] = 0;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCelloffsetRelativeTo != null)
                {
                    jABGlobalMouseClickOnTableCell["OffsetRelativeTo"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCelloffsetRelativeTo);
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (__workflow_jABGlobalMouseClickOnTableCelldelayInMilliseconds != null)
                {
                    if (__workflow_jABGlobalMouseClickOnTableCelldelayInMilliseconds != null)
                    {
                        jABGlobalMouseClickOnTableCell["DelayInMilliseconds"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCelldelayInMilliseconds);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["DelayInMilliseconds"] = 10;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                jABGlobalMouseClickOnTableCellpropCount++;
                jABGlobalMouseClickOnTableCell["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGlobalMouseClickOnTableCellworkflow);
                if (jABGlobalMouseClickOnTableCellpropCount > 0)
                {
                    callPayload.Body = jABGlobalMouseClickOnTableCell;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetRoleCSVFromElementSearchResponse> JABGetRoleCSVFromElementSearch(Expression<Func<int>> jABGetRoleCSVFromElementSearchsearchParentElementJABHandle, Expression<Func<string>> jABGetRoleCSVFromElementSearchworkflow, Expression<Func<string>> jABGetRoleCSVFromElementSearchsearchElementJABName = null, Expression<Func<string>> jABGetRoleCSVFromElementSearchsearchElementJABDescription = null, Expression<Func<string>> jABGetRoleCSVFromElementSearchsearchElementJABRole = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchsearchSubTree = null, Expression<Func<int>> jABGetRoleCSVFromElementSearchmaxRelativeDepth = null, Expression<Func<int>> jABGetRoleCSVFromElementSearchmatchIndex = null, Expression<Func<string>> jABGetRoleCSVFromElementSearchsearchFilter = null, Expression<Func<string>> jABGetRoleCSVFromElementSearchsortByColumn = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchmatchIndexAscending = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchcaseSensitiveSearch = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchonlySearchVisibleElements = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchonlySearchShowingElements = null, Expression<Func<string>> jABGetRoleCSVFromElementSearchelementRolesNotToTraverse = null, Expression<Func<int>> jABGetRoleCSVFromElementSearchmaximumElementsToSearch = null, Expression<Func<int>> jABGetRoleCSVFromElementSearchmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchindentRoleInCSV = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchincludeDescriptionInCSV = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchincludeDimensionsInCSV = null)
        {
            var __workflow_jABGetRoleCSVFromElementSearchsearchParentElementJABHandle = WorkflowExpression.Compile(jABGetRoleCSVFromElementSearchsearchParentElementJABHandle, nameof(jABGetRoleCSVFromElementSearchsearchParentElementJABHandle), required: true);
            var __workflow_jABGetRoleCSVFromElementSearchworkflow = WorkflowExpression.Compile(jABGetRoleCSVFromElementSearchworkflow, nameof(jABGetRoleCSVFromElementSearchworkflow), required: true);
            var __workflow_jABGetRoleCSVFromElementSearchsearchElementJABName = WorkflowExpression.Compile(jABGetRoleCSVFromElementSearchsearchElementJABName, nameof(jABGetRoleCSVFromElementSearchsearchElementJABName), required: false);
            var __workflow_jABGetRoleCSVFromElementSearchsearchElementJABDescription = WorkflowExpression.Compile(jABGetRoleCSVFromElementSearchsearchElementJABDescription, nameof(jABGetRoleCSVFromElementSearchsearchElementJABDescription), required: false);
            var __workflow_jABGetRoleCSVFromElementSearchsearchElementJABRole = WorkflowExpression.Compile(jABGetRoleCSVFromElementSearchsearchElementJABRole, nameof(jABGetRoleCSVFromElementSearchsearchElementJABRole), required: false);
            var __workflow_jABGetRoleCSVFromElementSearchsearchSubTree = WorkflowExpression.Compile(jABGetRoleCSVFromElementSearchsearchSubTree, nameof(jABGetRoleCSVFromElementSearchsearchSubTree), required: false);
            var __workflow_jABGetRoleCSVFromElementSearchmaxRelativeDepth = WorkflowExpression.Compile(jABGetRoleCSVFromElementSearchmaxRelativeDepth, nameof(jABGetRoleCSVFromElementSearchmaxRelativeDepth), required: false);
            var __workflow_jABGetRoleCSVFromElementSearchmatchIndex = WorkflowExpression.Compile(jABGetRoleCSVFromElementSearchmatchIndex, nameof(jABGetRoleCSVFromElementSearchmatchIndex), required: false);
            var __workflow_jABGetRoleCSVFromElementSearchsearchFilter = WorkflowExpression.Compile(jABGetRoleCSVFromElementSearchsearchFilter, nameof(jABGetRoleCSVFromElementSearchsearchFilter), required: false);
            var __workflow_jABGetRoleCSVFromElementSearchsortByColumn = WorkflowExpression.Compile(jABGetRoleCSVFromElementSearchsortByColumn, nameof(jABGetRoleCSVFromElementSearchsortByColumn), required: false);
            var __workflow_jABGetRoleCSVFromElementSearchmatchIndexAscending = WorkflowExpression.Compile(jABGetRoleCSVFromElementSearchmatchIndexAscending, nameof(jABGetRoleCSVFromElementSearchmatchIndexAscending), required: false);
            var __workflow_jABGetRoleCSVFromElementSearchcaseSensitiveSearch = WorkflowExpression.Compile(jABGetRoleCSVFromElementSearchcaseSensitiveSearch, nameof(jABGetRoleCSVFromElementSearchcaseSensitiveSearch), required: false);
            var __workflow_jABGetRoleCSVFromElementSearchonlySearchVisibleElements = WorkflowExpression.Compile(jABGetRoleCSVFromElementSearchonlySearchVisibleElements, nameof(jABGetRoleCSVFromElementSearchonlySearchVisibleElements), required: false);
            var __workflow_jABGetRoleCSVFromElementSearchonlySearchShowingElements = WorkflowExpression.Compile(jABGetRoleCSVFromElementSearchonlySearchShowingElements, nameof(jABGetRoleCSVFromElementSearchonlySearchShowingElements), required: false);
            var __workflow_jABGetRoleCSVFromElementSearchelementRolesNotToTraverse = WorkflowExpression.Compile(jABGetRoleCSVFromElementSearchelementRolesNotToTraverse, nameof(jABGetRoleCSVFromElementSearchelementRolesNotToTraverse), required: false);
            var __workflow_jABGetRoleCSVFromElementSearchmaximumElementsToSearch = WorkflowExpression.Compile(jABGetRoleCSVFromElementSearchmaximumElementsToSearch, nameof(jABGetRoleCSVFromElementSearchmaximumElementsToSearch), required: false);
            var __workflow_jABGetRoleCSVFromElementSearchmaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABGetRoleCSVFromElementSearchmaximumChildElementsToSearchPerNode, nameof(jABGetRoleCSVFromElementSearchmaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABGetRoleCSVFromElementSearchindentRoleInCSV = WorkflowExpression.Compile(jABGetRoleCSVFromElementSearchindentRoleInCSV, nameof(jABGetRoleCSVFromElementSearchindentRoleInCSV), required: false);
            var __workflow_jABGetRoleCSVFromElementSearchincludeDescriptionInCSV = WorkflowExpression.Compile(jABGetRoleCSVFromElementSearchincludeDescriptionInCSV, nameof(jABGetRoleCSVFromElementSearchincludeDescriptionInCSV), required: false);
            var __workflow_jABGetRoleCSVFromElementSearchincludeDimensionsInCSV = WorkflowExpression.Compile(jABGetRoleCSVFromElementSearchincludeDimensionsInCSV, nameof(jABGetRoleCSVFromElementSearchincludeDimensionsInCSV), required: false);
            return new DeferredBodyAction<JABGetRoleCSVFromElementSearchResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetRoleCSVFromElementSearch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetRoleCSVFromElementSearch = new JObject();
                var jABGetRoleCSVFromElementSearchpropCount = 0;
                jABGetRoleCSVFromElementSearchpropCount++;
                jABGetRoleCSVFromElementSearch["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementSearchsearchParentElementJABHandle);
                if (__workflow_jABGetRoleCSVFromElementSearchsearchElementJABName != null)
                {
                    jABGetRoleCSVFromElementSearch["SearchElementJABName"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementSearchsearchElementJABName);
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementSearchsearchElementJABDescription != null)
                {
                    jABGetRoleCSVFromElementSearch["SearchElementJABDescription"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementSearchsearchElementJABDescription);
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementSearchsearchElementJABRole != null)
                {
                    jABGetRoleCSVFromElementSearch["SearchElementJABRole"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementSearchsearchElementJABRole);
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementSearchsearchSubTree != null)
                {
                    if (__workflow_jABGetRoleCSVFromElementSearchsearchSubTree != null)
                    {
                        jABGetRoleCSVFromElementSearch["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementSearchsearchSubTree);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["SearchSubTree"] = true;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementSearchmaxRelativeDepth != null)
                {
                    if (__workflow_jABGetRoleCSVFromElementSearchmaxRelativeDepth != null)
                    {
                        jABGetRoleCSVFromElementSearch["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementSearchmaxRelativeDepth);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["MaxRelativeDepth"] = 0;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementSearchmatchIndex != null)
                {
                    if (__workflow_jABGetRoleCSVFromElementSearchmatchIndex != null)
                    {
                        jABGetRoleCSVFromElementSearch["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementSearchmatchIndex);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["MatchIndex"] = 1;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementSearchsearchFilter != null)
                {
                    jABGetRoleCSVFromElementSearch["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementSearchsearchFilter);
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementSearchsortByColumn != null)
                {
                    jABGetRoleCSVFromElementSearch["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementSearchsortByColumn);
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementSearchmatchIndexAscending != null)
                {
                    if (__workflow_jABGetRoleCSVFromElementSearchmatchIndexAscending != null)
                    {
                        jABGetRoleCSVFromElementSearch["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementSearchmatchIndexAscending);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["MatchIndexAscending"] = true;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementSearchcaseSensitiveSearch != null)
                {
                    if (__workflow_jABGetRoleCSVFromElementSearchcaseSensitiveSearch != null)
                    {
                        jABGetRoleCSVFromElementSearch["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementSearchcaseSensitiveSearch);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["CaseSensitiveSearch"] = false;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementSearchonlySearchVisibleElements != null)
                {
                    if (__workflow_jABGetRoleCSVFromElementSearchonlySearchVisibleElements != null)
                    {
                        jABGetRoleCSVFromElementSearch["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementSearchonlySearchVisibleElements);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["OnlySearchVisibleElements"] = true;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementSearchonlySearchShowingElements != null)
                {
                    if (__workflow_jABGetRoleCSVFromElementSearchonlySearchShowingElements != null)
                    {
                        jABGetRoleCSVFromElementSearch["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementSearchonlySearchShowingElements);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["OnlySearchShowingElements"] = true;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementSearchelementRolesNotToTraverse != null)
                {
                    jABGetRoleCSVFromElementSearch["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementSearchelementRolesNotToTraverse);
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementSearchmaximumElementsToSearch != null)
                {
                    if (__workflow_jABGetRoleCSVFromElementSearchmaximumElementsToSearch != null)
                    {
                        jABGetRoleCSVFromElementSearch["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementSearchmaximumElementsToSearch);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["MaximumElementsToSearch"] = 2000;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementSearchmaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABGetRoleCSVFromElementSearchmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetRoleCSVFromElementSearch["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementSearchmaximumChildElementsToSearchPerNode);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementSearchindentRoleInCSV != null)
                {
                    if (__workflow_jABGetRoleCSVFromElementSearchindentRoleInCSV != null)
                    {
                        jABGetRoleCSVFromElementSearch["IndentRoleInCSV"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementSearchindentRoleInCSV);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["IndentRoleInCSV"] = true;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementSearchincludeDescriptionInCSV != null)
                {
                    if (__workflow_jABGetRoleCSVFromElementSearchincludeDescriptionInCSV != null)
                    {
                        jABGetRoleCSVFromElementSearch["IncludeDescriptionInCSV"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementSearchincludeDescriptionInCSV);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["IncludeDescriptionInCSV"] = true;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementSearchincludeDimensionsInCSV != null)
                {
                    if (__workflow_jABGetRoleCSVFromElementSearchincludeDimensionsInCSV != null)
                    {
                        jABGetRoleCSVFromElementSearch["IncludeDimensionsInCSV"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementSearchincludeDimensionsInCSV);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["IncludeDimensionsInCSV"] = true;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                jABGetRoleCSVFromElementSearchpropCount++;
                jABGetRoleCSVFromElementSearch["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementSearchworkflow);
                if (jABGetRoleCSVFromElementSearchpropCount > 0)
                {
                    callPayload.Body = jABGetRoleCSVFromElementSearch;
                }

                return new ApiConnectionAction<JABGetRoleCSVFromElementSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetRoleCSVFromElementHandleResponse> JABGetRoleCSVFromElementHandle(Expression<Func<int>> jABGetRoleCSVFromElementHandlesearchParentElementJABHandle, Expression<Func<string>> jABGetRoleCSVFromElementHandleworkflow, Expression<Func<bool>> jABGetRoleCSVFromElementHandlesearchSubTree = null, Expression<Func<int>> jABGetRoleCSVFromElementHandlemaxRelativeDepth = null, Expression<Func<bool>> jABGetRoleCSVFromElementHandleonlySearchVisibleElements = null, Expression<Func<bool>> jABGetRoleCSVFromElementHandleonlySearchShowingElements = null, Expression<Func<string>> jABGetRoleCSVFromElementHandleelementRolesNotToTraverse = null, Expression<Func<int>> jABGetRoleCSVFromElementHandlemaximumElementsToSearch = null, Expression<Func<int>> jABGetRoleCSVFromElementHandlemaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGetRoleCSVFromElementHandleindentRoleInCSV = null, Expression<Func<bool>> jABGetRoleCSVFromElementHandleincludeDescriptionInCSV = null, Expression<Func<bool>> jABGetRoleCSVFromElementHandleincludeDimensionsInCSV = null)
        {
            var __workflow_jABGetRoleCSVFromElementHandlesearchParentElementJABHandle = WorkflowExpression.Compile(jABGetRoleCSVFromElementHandlesearchParentElementJABHandle, nameof(jABGetRoleCSVFromElementHandlesearchParentElementJABHandle), required: true);
            var __workflow_jABGetRoleCSVFromElementHandleworkflow = WorkflowExpression.Compile(jABGetRoleCSVFromElementHandleworkflow, nameof(jABGetRoleCSVFromElementHandleworkflow), required: true);
            var __workflow_jABGetRoleCSVFromElementHandlesearchSubTree = WorkflowExpression.Compile(jABGetRoleCSVFromElementHandlesearchSubTree, nameof(jABGetRoleCSVFromElementHandlesearchSubTree), required: false);
            var __workflow_jABGetRoleCSVFromElementHandlemaxRelativeDepth = WorkflowExpression.Compile(jABGetRoleCSVFromElementHandlemaxRelativeDepth, nameof(jABGetRoleCSVFromElementHandlemaxRelativeDepth), required: false);
            var __workflow_jABGetRoleCSVFromElementHandleonlySearchVisibleElements = WorkflowExpression.Compile(jABGetRoleCSVFromElementHandleonlySearchVisibleElements, nameof(jABGetRoleCSVFromElementHandleonlySearchVisibleElements), required: false);
            var __workflow_jABGetRoleCSVFromElementHandleonlySearchShowingElements = WorkflowExpression.Compile(jABGetRoleCSVFromElementHandleonlySearchShowingElements, nameof(jABGetRoleCSVFromElementHandleonlySearchShowingElements), required: false);
            var __workflow_jABGetRoleCSVFromElementHandleelementRolesNotToTraverse = WorkflowExpression.Compile(jABGetRoleCSVFromElementHandleelementRolesNotToTraverse, nameof(jABGetRoleCSVFromElementHandleelementRolesNotToTraverse), required: false);
            var __workflow_jABGetRoleCSVFromElementHandlemaximumElementsToSearch = WorkflowExpression.Compile(jABGetRoleCSVFromElementHandlemaximumElementsToSearch, nameof(jABGetRoleCSVFromElementHandlemaximumElementsToSearch), required: false);
            var __workflow_jABGetRoleCSVFromElementHandlemaximumChildElementsToSearchPerNode = WorkflowExpression.Compile(jABGetRoleCSVFromElementHandlemaximumChildElementsToSearchPerNode, nameof(jABGetRoleCSVFromElementHandlemaximumChildElementsToSearchPerNode), required: false);
            var __workflow_jABGetRoleCSVFromElementHandleindentRoleInCSV = WorkflowExpression.Compile(jABGetRoleCSVFromElementHandleindentRoleInCSV, nameof(jABGetRoleCSVFromElementHandleindentRoleInCSV), required: false);
            var __workflow_jABGetRoleCSVFromElementHandleincludeDescriptionInCSV = WorkflowExpression.Compile(jABGetRoleCSVFromElementHandleincludeDescriptionInCSV, nameof(jABGetRoleCSVFromElementHandleincludeDescriptionInCSV), required: false);
            var __workflow_jABGetRoleCSVFromElementHandleincludeDimensionsInCSV = WorkflowExpression.Compile(jABGetRoleCSVFromElementHandleincludeDimensionsInCSV, nameof(jABGetRoleCSVFromElementHandleincludeDimensionsInCSV), required: false);
            return new DeferredBodyAction<JABGetRoleCSVFromElementHandleResponse>(() =>
            {
                var apiCallPath = "/JavaAccessBridge/JABGetRoleCSVFromElementHandle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetRoleCSVFromElementHandle = new JObject();
                var jABGetRoleCSVFromElementHandlepropCount = 0;
                jABGetRoleCSVFromElementHandlepropCount++;
                jABGetRoleCSVFromElementHandle["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementHandlesearchParentElementJABHandle);
                if (__workflow_jABGetRoleCSVFromElementHandlesearchSubTree != null)
                {
                    if (__workflow_jABGetRoleCSVFromElementHandlesearchSubTree != null)
                    {
                        jABGetRoleCSVFromElementHandle["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementHandlesearchSubTree);
                        jABGetRoleCSVFromElementHandlepropCount++;
                    }

                    jABGetRoleCSVFromElementHandlepropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementHandle["SearchSubTree"] = true;
                    jABGetRoleCSVFromElementHandlepropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementHandlemaxRelativeDepth != null)
                {
                    if (__workflow_jABGetRoleCSVFromElementHandlemaxRelativeDepth != null)
                    {
                        jABGetRoleCSVFromElementHandle["MaxRelativeDepth"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementHandlemaxRelativeDepth);
                        jABGetRoleCSVFromElementHandlepropCount++;
                    }

                    jABGetRoleCSVFromElementHandlepropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementHandle["MaxRelativeDepth"] = 0;
                    jABGetRoleCSVFromElementHandlepropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementHandleonlySearchVisibleElements != null)
                {
                    if (__workflow_jABGetRoleCSVFromElementHandleonlySearchVisibleElements != null)
                    {
                        jABGetRoleCSVFromElementHandle["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementHandleonlySearchVisibleElements);
                        jABGetRoleCSVFromElementHandlepropCount++;
                    }

                    jABGetRoleCSVFromElementHandlepropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementHandle["OnlySearchVisibleElements"] = true;
                    jABGetRoleCSVFromElementHandlepropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementHandleonlySearchShowingElements != null)
                {
                    if (__workflow_jABGetRoleCSVFromElementHandleonlySearchShowingElements != null)
                    {
                        jABGetRoleCSVFromElementHandle["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementHandleonlySearchShowingElements);
                        jABGetRoleCSVFromElementHandlepropCount++;
                    }

                    jABGetRoleCSVFromElementHandlepropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementHandle["OnlySearchShowingElements"] = true;
                    jABGetRoleCSVFromElementHandlepropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementHandleelementRolesNotToTraverse != null)
                {
                    jABGetRoleCSVFromElementHandle["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementHandleelementRolesNotToTraverse);
                    jABGetRoleCSVFromElementHandlepropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementHandlemaximumElementsToSearch != null)
                {
                    if (__workflow_jABGetRoleCSVFromElementHandlemaximumElementsToSearch != null)
                    {
                        jABGetRoleCSVFromElementHandle["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementHandlemaximumElementsToSearch);
                        jABGetRoleCSVFromElementHandlepropCount++;
                    }

                    jABGetRoleCSVFromElementHandlepropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementHandle["MaximumElementsToSearch"] = 2000;
                    jABGetRoleCSVFromElementHandlepropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementHandlemaximumChildElementsToSearchPerNode != null)
                {
                    if (__workflow_jABGetRoleCSVFromElementHandlemaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetRoleCSVFromElementHandle["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementHandlemaximumChildElementsToSearchPerNode);
                        jABGetRoleCSVFromElementHandlepropCount++;
                    }

                    jABGetRoleCSVFromElementHandlepropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementHandle["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGetRoleCSVFromElementHandlepropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementHandleindentRoleInCSV != null)
                {
                    if (__workflow_jABGetRoleCSVFromElementHandleindentRoleInCSV != null)
                    {
                        jABGetRoleCSVFromElementHandle["IndentRoleInCSV"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementHandleindentRoleInCSV);
                        jABGetRoleCSVFromElementHandlepropCount++;
                    }

                    jABGetRoleCSVFromElementHandlepropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementHandle["IndentRoleInCSV"] = true;
                    jABGetRoleCSVFromElementHandlepropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementHandleincludeDescriptionInCSV != null)
                {
                    if (__workflow_jABGetRoleCSVFromElementHandleincludeDescriptionInCSV != null)
                    {
                        jABGetRoleCSVFromElementHandle["IncludeDescriptionInCSV"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementHandleincludeDescriptionInCSV);
                        jABGetRoleCSVFromElementHandlepropCount++;
                    }

                    jABGetRoleCSVFromElementHandlepropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementHandle["IncludeDescriptionInCSV"] = true;
                    jABGetRoleCSVFromElementHandlepropCount++;
                }

                if (__workflow_jABGetRoleCSVFromElementHandleincludeDimensionsInCSV != null)
                {
                    if (__workflow_jABGetRoleCSVFromElementHandleincludeDimensionsInCSV != null)
                    {
                        jABGetRoleCSVFromElementHandle["IncludeDimensionsInCSV"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementHandleincludeDimensionsInCSV);
                        jABGetRoleCSVFromElementHandlepropCount++;
                    }

                    jABGetRoleCSVFromElementHandlepropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementHandle["IncludeDimensionsInCSV"] = true;
                    jABGetRoleCSVFromElementHandlepropCount++;
                }

                jABGetRoleCSVFromElementHandlepropCount++;
                jABGetRoleCSVFromElementHandle["Workflow"] = ExpressionConverter.ConvertO(__workflow_jABGetRoleCSVFromElementHandleworkflow);
                if (jABGetRoleCSVFromElementHandlepropCount > 0)
                {
                    callPayload.Body = jABGetRoleCSVFromElementHandle;
                }

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

    public class JABIsJavaWindowResponse
    {
        public bool IsJavaWindow { get; set; }
    }

    public class JABGetWindowsAccessBridgeInfoResponse
    {
        public string JavaClassVersion { get; set; }
        public string JavaDLLVersion { get; set; }
        public string WinDLLVersion { get; set; }
        public string VMVersion { get; set; }
    }

    public class JABGetUIAElementPropertiesResponse
    {
        public int ElementJABHandle { get; set; }
        public int ElementVMID { get; set; }
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

    public class JABGetJABElementPropertiesResponse
    {
        public int ElementJABHandle { get; set; }
        public int ElementVMID { get; set; }
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

    public class JABDoesElementExistResponse
    {
        public bool ElementExists { get; set; }
        public int ElementJABHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementDescription { get; set; }
        public string ElementRole { get; set; }
    }

    public class JABWaitForElementResponse
    {
        public bool ElementExists { get; set; }
        public int ElementJABHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementDescription { get; set; }
        public string ElementRole { get; set; }
    }

    public class JABWaitForElementToNotExistResponse
    {
        public bool ElementExistsBeforeWait { get; set; }
        public bool ElementExistsAfterWait { get; set; }
    }

    public class JABGetDesktopElementsResponse
    {
        public int NumberOfElementsFound { get; set; }
        public int NumberOfElementsReturned { get; set; }
        public string JavaDesktopElementsJSON { get; set; }
    }

    public class JABDoesDesktopElementExistResponse
    {
        public bool ElementExists { get; set; }
        public int ElementJABHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementDescription { get; set; }
        public string ElementRole { get; set; }
    }

    public class JABWaitForDesktopElementResponse
    {
        public bool ElementExists { get; set; }
        public int ElementJABHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementDescription { get; set; }
        public string ElementRole { get; set; }
    }

    public class JABWaitForDesktopElementToNotExistResponse
    {
        public bool ElementExistsBeforeWait { get; set; }
        public bool ElementExistsAfterWait { get; set; }
    }

    public class JABGetChildJABElementPropertiesResponse
    {
        public int ElementJABHandle { get; set; }
        public int ElementVMID { get; set; }
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

    public class JABGetAllChildJABElementPropertiesResponse
    {
        public int NumberOfChildElementsReturned { get; set; }
        public bool MoreElementsAvailableAtCurrentDepth { get; set; }
        public bool MoreElementsAvailableAtLowerDepths { get; set; }
        public bool MoreElementsDeeperThanMaxDepth { get; set; }
        public string JavaChildElementsJSON { get; set; }
    }

    public class JABGetParentJABElementPropertiesResponse
    {
        public int ElementJABHandle { get; set; }
        public int ElementVMID { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum jABGlobalLeftMouseClickOnElementoffsetRelativeToInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum jABGlobalRightMouseClickOnElementoffsetRelativeToInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum jABGlobalMiddleMouseClickOnElementoffsetRelativeToInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum jABGlobalDoubleLeftMouseClickOnElementoffsetRelativeToInput
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

    public class JABGetElementTextValueResponse
    {
        public string ElementTextValue { get; set; }
    }

    public class JABGetElementValueResponse
    {
        public string ElementCurrentValue { get; set; }
        public string ElementMaximumValue { get; set; }
        public string ElementMinimumValue { get; set; }
    }

    public class JABGetElementPropertiesAsListResponse
    {
        public int NumberOfElementsFound { get; set; }
        public int NumberOfElementsReturned { get; set; }
        public string JABElementPropertiesJSON { get; set; }
    }

    public class JABGetSelectionElementItemsResponse
    {
        public int NumberOfSelectedItems { get; set; }
        public string AccessibleSelection1Name { get; set; }
        public int AccessibleSelection1IndexInParent { get; set; }
        public string JABSelectionSelectedItemsJSON { get; set; }
        public string JABSelectionListItemsJSON { get; set; }
    }

    public class JABGetSelectionStateByIndexResponse
    {
        public bool IndexIsSelected { get; set; }
    }

    public class JABGetSelectionStateByNameResponse
    {
        public bool NameIsSelected { get; set; }
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

    public class JABIsTableCellVisibleOnscreenResponse
    {
        public bool CellOnScreen { get; set; }
        public bool ResultIsCertain { get; set; }
        public string OffscreenDirection { get; set; }
    }

    public class JABIsJABHandleSameObjectResponse
    {
        public bool SameObject { get; set; }
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

    public class JABCreateHandleForJABElementAtScreenCoordinateResponse
    {
        public int LocatedElementJABHandle { get; set; }
    }

    public class JABGetTableCellAtScreenCoordinateResponse
    {
        public int CellIndexInParent { get; set; }
        public int CellRowIndex { get; set; }
        public int CellColumnIndex { get; set; }
        public int CellJABHandle { get; set; }
    }

    public class JABGetMultipleParentJABElementPropertiesResponse
    {
        public string JavaParentElementsJSON { get; set; }
        public int NumberOfParentElementsReturned { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum jABGlobalMouseClickOnTableCelloffsetRelativeToInput
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

    public class JABGetRoleCSVFromElementHandleResponse
    {
        public bool ElementFound { get; set; }
        public int ElementsSearched { get; set; }
        public string RoleCSV { get; set; }
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
