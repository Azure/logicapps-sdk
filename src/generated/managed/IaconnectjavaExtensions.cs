//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectjava
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectjavaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABConnectToJavaAccessBridgeResponse> JABConnectToJavaAccessBridge([WorkflowExpression] Func<string> jABConnectToJavaAccessBridgeworkflow, [WorkflowExpression] Func<string> jABConnectToJavaAccessBridgewindowsAccessBridgeDLLSearchFolder = null, [WorkflowExpression] Func<string> jABConnectToJavaAccessBridgeiAJavaAccessBridgePath = null, [WorkflowExpression] Func<bool> jABConnectToJavaAccessBridgeis64BitJABDLL = null, [WorkflowExpression] Func<bool> jABConnectToJavaAccessBridgeuseCOMFor64BitJABDLL = null, [WorkflowExpression] Func<bool> jABConnectToJavaAccessBridgeenableJavaAccessBridge = null, [WorkflowExpression] Func<string> jABConnectToJavaAccessBridgeaccessibilityFilepath = null, [WorkflowExpression] Func<int> jABConnectToJavaAccessBridgecommandTimeoutInSeconds = null)
        {
            SourceExpression.Validate(jABConnectToJavaAccessBridgeworkflow, nameof(jABConnectToJavaAccessBridgeworkflow), required: true);
            SourceExpression.Validate(jABConnectToJavaAccessBridgewindowsAccessBridgeDLLSearchFolder, nameof(jABConnectToJavaAccessBridgewindowsAccessBridgeDLLSearchFolder), required: false);
            SourceExpression.Validate(jABConnectToJavaAccessBridgeiAJavaAccessBridgePath, nameof(jABConnectToJavaAccessBridgeiAJavaAccessBridgePath), required: false);
            SourceExpression.Validate(jABConnectToJavaAccessBridgeis64BitJABDLL, nameof(jABConnectToJavaAccessBridgeis64BitJABDLL), required: false);
            SourceExpression.Validate(jABConnectToJavaAccessBridgeuseCOMFor64BitJABDLL, nameof(jABConnectToJavaAccessBridgeuseCOMFor64BitJABDLL), required: false);
            SourceExpression.Validate(jABConnectToJavaAccessBridgeenableJavaAccessBridge, nameof(jABConnectToJavaAccessBridgeenableJavaAccessBridge), required: false);
            SourceExpression.Validate(jABConnectToJavaAccessBridgeaccessibilityFilepath, nameof(jABConnectToJavaAccessBridgeaccessibilityFilepath), required: false);
            SourceExpression.Validate(jABConnectToJavaAccessBridgecommandTimeoutInSeconds, nameof(jABConnectToJavaAccessBridgecommandTimeoutInSeconds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABConnectToJavaAccessBridge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABConnectToJavaAccessBridge = new JObject();
                var jABConnectToJavaAccessBridgepropCount = 0;
                if (jABConnectToJavaAccessBridgewindowsAccessBridgeDLLSearchFolder != null)
                {
                    jABConnectToJavaAccessBridge["WindowsAccessBridgeDLLSearchFolder"] = SourceExpressionConverter.ConvertToken(jABConnectToJavaAccessBridgewindowsAccessBridgeDLLSearchFolder);
                    jABConnectToJavaAccessBridgepropCount++;
                }

                if (jABConnectToJavaAccessBridgeiAJavaAccessBridgePath != null)
                {
                    jABConnectToJavaAccessBridge["IAJavaAccessBridgePath"] = SourceExpressionConverter.ConvertToken(jABConnectToJavaAccessBridgeiAJavaAccessBridgePath);
                    jABConnectToJavaAccessBridgepropCount++;
                }

                if (jABConnectToJavaAccessBridgeis64BitJABDLL != null)
                {
                    if (jABConnectToJavaAccessBridgeis64BitJABDLL != null)
                    {
                        jABConnectToJavaAccessBridge["Is64BitJABDLL"] = SourceExpressionConverter.ConvertToken(jABConnectToJavaAccessBridgeis64BitJABDLL);
                        jABConnectToJavaAccessBridgepropCount++;
                    }

                    jABConnectToJavaAccessBridgepropCount++;
                }
                else
                {
                    jABConnectToJavaAccessBridge["Is64BitJABDLL"] = false;
                    jABConnectToJavaAccessBridgepropCount++;
                }

                if (jABConnectToJavaAccessBridgeuseCOMFor64BitJABDLL != null)
                {
                    if (jABConnectToJavaAccessBridgeuseCOMFor64BitJABDLL != null)
                    {
                        jABConnectToJavaAccessBridge["UseCOMFor64BitJABDLL"] = SourceExpressionConverter.ConvertToken(jABConnectToJavaAccessBridgeuseCOMFor64BitJABDLL);
                        jABConnectToJavaAccessBridgepropCount++;
                    }

                    jABConnectToJavaAccessBridgepropCount++;
                }
                else
                {
                    jABConnectToJavaAccessBridge["UseCOMFor64BitJABDLL"] = true;
                    jABConnectToJavaAccessBridgepropCount++;
                }

                if (jABConnectToJavaAccessBridgeenableJavaAccessBridge != null)
                {
                    if (jABConnectToJavaAccessBridgeenableJavaAccessBridge != null)
                    {
                        jABConnectToJavaAccessBridge["EnableJavaAccessBridge"] = SourceExpressionConverter.ConvertToken(jABConnectToJavaAccessBridgeenableJavaAccessBridge);
                        jABConnectToJavaAccessBridgepropCount++;
                    }

                    jABConnectToJavaAccessBridgepropCount++;
                }
                else
                {
                    jABConnectToJavaAccessBridge["EnableJavaAccessBridge"] = true;
                    jABConnectToJavaAccessBridgepropCount++;
                }

                if (jABConnectToJavaAccessBridgeaccessibilityFilepath != null)
                {
                    if (jABConnectToJavaAccessBridgeaccessibilityFilepath != null)
                    {
                        jABConnectToJavaAccessBridge["AccessibilityFilepath"] = SourceExpressionConverter.ConvertToken(jABConnectToJavaAccessBridgeaccessibilityFilepath);
                        jABConnectToJavaAccessBridgepropCount++;
                    }

                    jABConnectToJavaAccessBridgepropCount++;
                }
                else
                {
                    jABConnectToJavaAccessBridge["AccessibilityFilepath"] = "%USERPROFILE%\\.accessibility.properties";
                    jABConnectToJavaAccessBridgepropCount++;
                }

                if (jABConnectToJavaAccessBridgecommandTimeoutInSeconds != null)
                {
                    if (jABConnectToJavaAccessBridgecommandTimeoutInSeconds != null)
                    {
                        jABConnectToJavaAccessBridge["CommandTimeoutInSeconds"] = SourceExpressionConverter.ConvertToken(jABConnectToJavaAccessBridgecommandTimeoutInSeconds);
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
                jABConnectToJavaAccessBridge["Workflow"] = SourceExpressionConverter.ConvertToken(jABConnectToJavaAccessBridgeworkflow);
                if (jABConnectToJavaAccessBridgepropCount > 0)
                {
                    callPayload.Body = jABConnectToJavaAccessBridge;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABConnectToJavaAccessBridgeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABDisconnectFromJavaAccessBridge([WorkflowExpression] Func<string> jABDisconnectFromJavaAccessBridgeworkflow, [WorkflowExpression] Func<bool> jABDisconnectFromJavaAccessBridgedisableJavaAccessBridge = null, [WorkflowExpression] Func<string> jABDisconnectFromJavaAccessBridgeaccessibilityFilepath = null)
        {
            SourceExpression.Validate(jABDisconnectFromJavaAccessBridgeworkflow, nameof(jABDisconnectFromJavaAccessBridgeworkflow), required: true);
            SourceExpression.Validate(jABDisconnectFromJavaAccessBridgedisableJavaAccessBridge, nameof(jABDisconnectFromJavaAccessBridgedisableJavaAccessBridge), required: false);
            SourceExpression.Validate(jABDisconnectFromJavaAccessBridgeaccessibilityFilepath, nameof(jABDisconnectFromJavaAccessBridgeaccessibilityFilepath), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABDisconnectFromJavaAccessBridge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABDisconnectFromJavaAccessBridge = new JObject();
                var jABDisconnectFromJavaAccessBridgepropCount = 0;
                if (jABDisconnectFromJavaAccessBridgedisableJavaAccessBridge != null)
                {
                    if (jABDisconnectFromJavaAccessBridgedisableJavaAccessBridge != null)
                    {
                        jABDisconnectFromJavaAccessBridge["DisableJavaAccessBridge"] = SourceExpressionConverter.ConvertToken(jABDisconnectFromJavaAccessBridgedisableJavaAccessBridge);
                        jABDisconnectFromJavaAccessBridgepropCount++;
                    }

                    jABDisconnectFromJavaAccessBridgepropCount++;
                }
                else
                {
                    jABDisconnectFromJavaAccessBridge["DisableJavaAccessBridge"] = true;
                    jABDisconnectFromJavaAccessBridgepropCount++;
                }

                if (jABDisconnectFromJavaAccessBridgeaccessibilityFilepath != null)
                {
                    if (jABDisconnectFromJavaAccessBridgeaccessibilityFilepath != null)
                    {
                        jABDisconnectFromJavaAccessBridge["AccessibilityFilepath"] = SourceExpressionConverter.ConvertToken(jABDisconnectFromJavaAccessBridgeaccessibilityFilepath);
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
                jABDisconnectFromJavaAccessBridge["Workflow"] = SourceExpressionConverter.ConvertToken(jABDisconnectFromJavaAccessBridgeworkflow);
                if (jABDisconnectFromJavaAccessBridgepropCount > 0)
                {
                    callPayload.Body = jABDisconnectFromJavaAccessBridge;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetConnectionStatusResponse> JABGetConnectionStatus([WorkflowExpression] Func<string> jABGetConnectionStatusworkflow)
        {
            SourceExpression.Validate(jABGetConnectionStatusworkflow, nameof(jABGetConnectionStatusworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetConnectionStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetConnectionStatus = new JObject();
                var jABGetConnectionStatuspropCount = 0;
                jABGetConnectionStatuspropCount++;
                jABGetConnectionStatus["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetConnectionStatusworkflow);
                if (jABGetConnectionStatuspropCount > 0)
                {
                    callPayload.Body = jABGetConnectionStatus;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetConnectionStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABIsJavaWindowResponse> JABIsJavaWindow([WorkflowExpression] Func<int> jABIsJavaWindowparentWindowHandle, [WorkflowExpression] Func<string> jABIsJavaWindowworkflow, [WorkflowExpression] Func<string> jABIsJavaWindowsearchElementName = null, [WorkflowExpression] Func<string> jABIsJavaWindowsearchElementClassName = null, [WorkflowExpression] Func<string> jABIsJavaWindowsearchElementAutomationId = null, [WorkflowExpression] Func<string> jABIsJavaWindowsearchLocalizedControlType = null, [WorkflowExpression] Func<bool> jABIsJavaWindowsearchSubTree = null, [WorkflowExpression] Func<int> jABIsJavaWindowmatchIndex = null, [WorkflowExpression] Func<string> jABIsJavaWindowsearchFilter = null, [WorkflowExpression] Func<string> jABIsJavaWindowsortByColumn = null, [WorkflowExpression] Func<bool> jABIsJavaWindowmatchIndexAscending = null)
        {
            SourceExpression.Validate(jABIsJavaWindowparentWindowHandle, nameof(jABIsJavaWindowparentWindowHandle), required: true);
            SourceExpression.Validate(jABIsJavaWindowworkflow, nameof(jABIsJavaWindowworkflow), required: true);
            SourceExpression.Validate(jABIsJavaWindowsearchElementName, nameof(jABIsJavaWindowsearchElementName), required: false);
            SourceExpression.Validate(jABIsJavaWindowsearchElementClassName, nameof(jABIsJavaWindowsearchElementClassName), required: false);
            SourceExpression.Validate(jABIsJavaWindowsearchElementAutomationId, nameof(jABIsJavaWindowsearchElementAutomationId), required: false);
            SourceExpression.Validate(jABIsJavaWindowsearchLocalizedControlType, nameof(jABIsJavaWindowsearchLocalizedControlType), required: false);
            SourceExpression.Validate(jABIsJavaWindowsearchSubTree, nameof(jABIsJavaWindowsearchSubTree), required: false);
            SourceExpression.Validate(jABIsJavaWindowmatchIndex, nameof(jABIsJavaWindowmatchIndex), required: false);
            SourceExpression.Validate(jABIsJavaWindowsearchFilter, nameof(jABIsJavaWindowsearchFilter), required: false);
            SourceExpression.Validate(jABIsJavaWindowsortByColumn, nameof(jABIsJavaWindowsortByColumn), required: false);
            SourceExpression.Validate(jABIsJavaWindowmatchIndexAscending, nameof(jABIsJavaWindowmatchIndexAscending), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABIsJavaWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABIsJavaWindow = new JObject();
                var jABIsJavaWindowpropCount = 0;
                jABIsJavaWindowpropCount++;
                jABIsJavaWindow["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(jABIsJavaWindowparentWindowHandle);
                if (jABIsJavaWindowsearchElementName != null)
                {
                    jABIsJavaWindow["SearchElementName"] = SourceExpressionConverter.ConvertToken(jABIsJavaWindowsearchElementName);
                    jABIsJavaWindowpropCount++;
                }

                if (jABIsJavaWindowsearchElementClassName != null)
                {
                    jABIsJavaWindow["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(jABIsJavaWindowsearchElementClassName);
                    jABIsJavaWindowpropCount++;
                }

                if (jABIsJavaWindowsearchElementAutomationId != null)
                {
                    jABIsJavaWindow["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(jABIsJavaWindowsearchElementAutomationId);
                    jABIsJavaWindowpropCount++;
                }

                if (jABIsJavaWindowsearchLocalizedControlType != null)
                {
                    jABIsJavaWindow["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(jABIsJavaWindowsearchLocalizedControlType);
                    jABIsJavaWindowpropCount++;
                }

                if (jABIsJavaWindowsearchSubTree != null)
                {
                    if (jABIsJavaWindowsearchSubTree != null)
                    {
                        jABIsJavaWindow["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABIsJavaWindowsearchSubTree);
                        jABIsJavaWindowpropCount++;
                    }

                    jABIsJavaWindowpropCount++;
                }
                else
                {
                    jABIsJavaWindow["SearchSubTree"] = true;
                    jABIsJavaWindowpropCount++;
                }

                if (jABIsJavaWindowmatchIndex != null)
                {
                    if (jABIsJavaWindowmatchIndex != null)
                    {
                        jABIsJavaWindow["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABIsJavaWindowmatchIndex);
                        jABIsJavaWindowpropCount++;
                    }

                    jABIsJavaWindowpropCount++;
                }
                else
                {
                    jABIsJavaWindow["MatchIndex"] = 1;
                    jABIsJavaWindowpropCount++;
                }

                if (jABIsJavaWindowsearchFilter != null)
                {
                    jABIsJavaWindow["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABIsJavaWindowsearchFilter);
                    jABIsJavaWindowpropCount++;
                }

                if (jABIsJavaWindowsortByColumn != null)
                {
                    jABIsJavaWindow["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABIsJavaWindowsortByColumn);
                    jABIsJavaWindowpropCount++;
                }

                if (jABIsJavaWindowmatchIndexAscending != null)
                {
                    if (jABIsJavaWindowmatchIndexAscending != null)
                    {
                        jABIsJavaWindow["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABIsJavaWindowmatchIndexAscending);
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
                jABIsJavaWindow["Workflow"] = SourceExpressionConverter.ConvertToken(jABIsJavaWindowworkflow);
                if (jABIsJavaWindowpropCount > 0)
                {
                    callPayload.Body = jABIsJavaWindow;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABIsJavaWindowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetWindowsAccessBridgeInfoResponse> JABGetWindowsAccessBridgeInfo([WorkflowExpression] Func<int> jABGetWindowsAccessBridgeInfovMId, [WorkflowExpression] Func<string> jABGetWindowsAccessBridgeInfoworkflow)
        {
            SourceExpression.Validate(jABGetWindowsAccessBridgeInfovMId, nameof(jABGetWindowsAccessBridgeInfovMId), required: true);
            SourceExpression.Validate(jABGetWindowsAccessBridgeInfoworkflow, nameof(jABGetWindowsAccessBridgeInfoworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetWindowsAccessBridgeInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetWindowsAccessBridgeInfo = new JObject();
                var jABGetWindowsAccessBridgeInfopropCount = 0;
                jABGetWindowsAccessBridgeInfopropCount++;
                jABGetWindowsAccessBridgeInfo["VMID"] = SourceExpressionConverter.ConvertToken(jABGetWindowsAccessBridgeInfovMId);
                jABGetWindowsAccessBridgeInfopropCount++;
                jABGetWindowsAccessBridgeInfo["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetWindowsAccessBridgeInfoworkflow);
                if (jABGetWindowsAccessBridgeInfopropCount > 0)
                {
                    callPayload.Body = jABGetWindowsAccessBridgeInfo;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetWindowsAccessBridgeInfoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetUIAElementPropertiesResponse> JABGetUIAElementProperties([WorkflowExpression] Func<int> jABGetUIAElementPropertiesparentWindowHandle, [WorkflowExpression] Func<string> jABGetUIAElementPropertiesworkflow, [WorkflowExpression] Func<string> jABGetUIAElementPropertiessearchElementName = null, [WorkflowExpression] Func<string> jABGetUIAElementPropertiessearchElementClassName = null, [WorkflowExpression] Func<string> jABGetUIAElementPropertiessearchElementAutomationId = null, [WorkflowExpression] Func<string> jABGetUIAElementPropertiessearchLocalizedControlType = null, [WorkflowExpression] Func<bool> jABGetUIAElementPropertiessearchSubTree = null, [WorkflowExpression] Func<int> jABGetUIAElementPropertiesmatchIndex = null, [WorkflowExpression] Func<string> jABGetUIAElementPropertiessearchFilter = null, [WorkflowExpression] Func<string> jABGetUIAElementPropertiessortByColumn = null, [WorkflowExpression] Func<bool> jABGetUIAElementPropertiesmatchIndexAscending = null, [WorkflowExpression] Func<int> jABGetUIAElementPropertiesmaxStringLength = null)
        {
            SourceExpression.Validate(jABGetUIAElementPropertiesparentWindowHandle, nameof(jABGetUIAElementPropertiesparentWindowHandle), required: true);
            SourceExpression.Validate(jABGetUIAElementPropertiesworkflow, nameof(jABGetUIAElementPropertiesworkflow), required: true);
            SourceExpression.Validate(jABGetUIAElementPropertiessearchElementName, nameof(jABGetUIAElementPropertiessearchElementName), required: false);
            SourceExpression.Validate(jABGetUIAElementPropertiessearchElementClassName, nameof(jABGetUIAElementPropertiessearchElementClassName), required: false);
            SourceExpression.Validate(jABGetUIAElementPropertiessearchElementAutomationId, nameof(jABGetUIAElementPropertiessearchElementAutomationId), required: false);
            SourceExpression.Validate(jABGetUIAElementPropertiessearchLocalizedControlType, nameof(jABGetUIAElementPropertiessearchLocalizedControlType), required: false);
            SourceExpression.Validate(jABGetUIAElementPropertiessearchSubTree, nameof(jABGetUIAElementPropertiessearchSubTree), required: false);
            SourceExpression.Validate(jABGetUIAElementPropertiesmatchIndex, nameof(jABGetUIAElementPropertiesmatchIndex), required: false);
            SourceExpression.Validate(jABGetUIAElementPropertiessearchFilter, nameof(jABGetUIAElementPropertiessearchFilter), required: false);
            SourceExpression.Validate(jABGetUIAElementPropertiessortByColumn, nameof(jABGetUIAElementPropertiessortByColumn), required: false);
            SourceExpression.Validate(jABGetUIAElementPropertiesmatchIndexAscending, nameof(jABGetUIAElementPropertiesmatchIndexAscending), required: false);
            SourceExpression.Validate(jABGetUIAElementPropertiesmaxStringLength, nameof(jABGetUIAElementPropertiesmaxStringLength), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetUIAElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetUIAElementProperties = new JObject();
                var jABGetUIAElementPropertiespropCount = 0;
                jABGetUIAElementPropertiespropCount++;
                jABGetUIAElementProperties["ParentWindowHandle"] = SourceExpressionConverter.ConvertToken(jABGetUIAElementPropertiesparentWindowHandle);
                if (jABGetUIAElementPropertiessearchElementName != null)
                {
                    jABGetUIAElementProperties["SearchElementName"] = SourceExpressionConverter.ConvertToken(jABGetUIAElementPropertiessearchElementName);
                    jABGetUIAElementPropertiespropCount++;
                }

                if (jABGetUIAElementPropertiessearchElementClassName != null)
                {
                    jABGetUIAElementProperties["SearchElementClassName"] = SourceExpressionConverter.ConvertToken(jABGetUIAElementPropertiessearchElementClassName);
                    jABGetUIAElementPropertiespropCount++;
                }

                if (jABGetUIAElementPropertiessearchElementAutomationId != null)
                {
                    jABGetUIAElementProperties["SearchElementAutomationId"] = SourceExpressionConverter.ConvertToken(jABGetUIAElementPropertiessearchElementAutomationId);
                    jABGetUIAElementPropertiespropCount++;
                }

                if (jABGetUIAElementPropertiessearchLocalizedControlType != null)
                {
                    jABGetUIAElementProperties["SearchLocalizedControlType"] = SourceExpressionConverter.ConvertToken(jABGetUIAElementPropertiessearchLocalizedControlType);
                    jABGetUIAElementPropertiespropCount++;
                }

                if (jABGetUIAElementPropertiessearchSubTree != null)
                {
                    if (jABGetUIAElementPropertiessearchSubTree != null)
                    {
                        jABGetUIAElementProperties["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABGetUIAElementPropertiessearchSubTree);
                        jABGetUIAElementPropertiespropCount++;
                    }

                    jABGetUIAElementPropertiespropCount++;
                }
                else
                {
                    jABGetUIAElementProperties["SearchSubTree"] = true;
                    jABGetUIAElementPropertiespropCount++;
                }

                if (jABGetUIAElementPropertiesmatchIndex != null)
                {
                    if (jABGetUIAElementPropertiesmatchIndex != null)
                    {
                        jABGetUIAElementProperties["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABGetUIAElementPropertiesmatchIndex);
                        jABGetUIAElementPropertiespropCount++;
                    }

                    jABGetUIAElementPropertiespropCount++;
                }
                else
                {
                    jABGetUIAElementProperties["MatchIndex"] = 1;
                    jABGetUIAElementPropertiespropCount++;
                }

                if (jABGetUIAElementPropertiessearchFilter != null)
                {
                    jABGetUIAElementProperties["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABGetUIAElementPropertiessearchFilter);
                    jABGetUIAElementPropertiespropCount++;
                }

                if (jABGetUIAElementPropertiessortByColumn != null)
                {
                    jABGetUIAElementProperties["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABGetUIAElementPropertiessortByColumn);
                    jABGetUIAElementPropertiespropCount++;
                }

                if (jABGetUIAElementPropertiesmatchIndexAscending != null)
                {
                    if (jABGetUIAElementPropertiesmatchIndexAscending != null)
                    {
                        jABGetUIAElementProperties["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABGetUIAElementPropertiesmatchIndexAscending);
                        jABGetUIAElementPropertiespropCount++;
                    }

                    jABGetUIAElementPropertiespropCount++;
                }
                else
                {
                    jABGetUIAElementProperties["MatchIndexAscending"] = true;
                    jABGetUIAElementPropertiespropCount++;
                }

                if (jABGetUIAElementPropertiesmaxStringLength != null)
                {
                    if (jABGetUIAElementPropertiesmaxStringLength != null)
                    {
                        jABGetUIAElementProperties["MaxStringLength"] = SourceExpressionConverter.ConvertToken(jABGetUIAElementPropertiesmaxStringLength);
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
                jABGetUIAElementProperties["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetUIAElementPropertiesworkflow);
                if (jABGetUIAElementPropertiespropCount > 0)
                {
                    callPayload.Body = jABGetUIAElementProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetUIAElementPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetJABElementPropertiesResponse> JABGetJABElementProperties([WorkflowExpression] Func<int> jABGetJABElementPropertiessearchParentElementJABHandle, [WorkflowExpression] Func<string> jABGetJABElementPropertiesworkflow, [WorkflowExpression] Func<string> jABGetJABElementPropertiessearchElementJABName = null, [WorkflowExpression] Func<string> jABGetJABElementPropertiessearchElementJABDescription = null, [WorkflowExpression] Func<string> jABGetJABElementPropertiessearchElementJABRole = null, [WorkflowExpression] Func<bool> jABGetJABElementPropertiessearchSubTree = null, [WorkflowExpression] Func<int> jABGetJABElementPropertiesmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABGetJABElementPropertiesmatchIndex = null, [WorkflowExpression] Func<string> jABGetJABElementPropertiessearchFilter = null, [WorkflowExpression] Func<string> jABGetJABElementPropertiessortByColumn = null, [WorkflowExpression] Func<bool> jABGetJABElementPropertiesmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABGetJABElementPropertiescaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABGetJABElementPropertiesonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABGetJABElementPropertiesonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABGetJABElementPropertieselementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABGetJABElementPropertiesmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABGetJABElementPropertiesmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<int> jABGetJABElementPropertiesmaxStringLength = null)
        {
            SourceExpression.Validate(jABGetJABElementPropertiessearchParentElementJABHandle, nameof(jABGetJABElementPropertiessearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABGetJABElementPropertiesworkflow, nameof(jABGetJABElementPropertiesworkflow), required: true);
            SourceExpression.Validate(jABGetJABElementPropertiessearchElementJABName, nameof(jABGetJABElementPropertiessearchElementJABName), required: false);
            SourceExpression.Validate(jABGetJABElementPropertiessearchElementJABDescription, nameof(jABGetJABElementPropertiessearchElementJABDescription), required: false);
            SourceExpression.Validate(jABGetJABElementPropertiessearchElementJABRole, nameof(jABGetJABElementPropertiessearchElementJABRole), required: false);
            SourceExpression.Validate(jABGetJABElementPropertiessearchSubTree, nameof(jABGetJABElementPropertiessearchSubTree), required: false);
            SourceExpression.Validate(jABGetJABElementPropertiesmaxRelativeDepth, nameof(jABGetJABElementPropertiesmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABGetJABElementPropertiesmatchIndex, nameof(jABGetJABElementPropertiesmatchIndex), required: false);
            SourceExpression.Validate(jABGetJABElementPropertiessearchFilter, nameof(jABGetJABElementPropertiessearchFilter), required: false);
            SourceExpression.Validate(jABGetJABElementPropertiessortByColumn, nameof(jABGetJABElementPropertiessortByColumn), required: false);
            SourceExpression.Validate(jABGetJABElementPropertiesmatchIndexAscending, nameof(jABGetJABElementPropertiesmatchIndexAscending), required: false);
            SourceExpression.Validate(jABGetJABElementPropertiescaseSensitiveSearch, nameof(jABGetJABElementPropertiescaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABGetJABElementPropertiesonlySearchVisibleElements, nameof(jABGetJABElementPropertiesonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABGetJABElementPropertiesonlySearchShowingElements, nameof(jABGetJABElementPropertiesonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABGetJABElementPropertieselementRolesNotToTraverse, nameof(jABGetJABElementPropertieselementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABGetJABElementPropertiesmaximumElementsToSearch, nameof(jABGetJABElementPropertiesmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABGetJABElementPropertiesmaximumChildElementsToSearchPerNode, nameof(jABGetJABElementPropertiesmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABGetJABElementPropertiesmaxStringLength, nameof(jABGetJABElementPropertiesmaxStringLength), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetJABElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetJABElementProperties = new JObject();
                var jABGetJABElementPropertiespropCount = 0;
                jABGetJABElementPropertiespropCount++;
                jABGetJABElementProperties["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGetJABElementPropertiessearchParentElementJABHandle);
                if (jABGetJABElementPropertiessearchElementJABName != null)
                {
                    jABGetJABElementProperties["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABGetJABElementPropertiessearchElementJABName);
                    jABGetJABElementPropertiespropCount++;
                }

                if (jABGetJABElementPropertiessearchElementJABDescription != null)
                {
                    jABGetJABElementProperties["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABGetJABElementPropertiessearchElementJABDescription);
                    jABGetJABElementPropertiespropCount++;
                }

                if (jABGetJABElementPropertiessearchElementJABRole != null)
                {
                    jABGetJABElementProperties["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABGetJABElementPropertiessearchElementJABRole);
                    jABGetJABElementPropertiespropCount++;
                }

                if (jABGetJABElementPropertiessearchSubTree != null)
                {
                    if (jABGetJABElementPropertiessearchSubTree != null)
                    {
                        jABGetJABElementProperties["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABGetJABElementPropertiessearchSubTree);
                        jABGetJABElementPropertiespropCount++;
                    }

                    jABGetJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetJABElementProperties["SearchSubTree"] = true;
                    jABGetJABElementPropertiespropCount++;
                }

                if (jABGetJABElementPropertiesmaxRelativeDepth != null)
                {
                    if (jABGetJABElementPropertiesmaxRelativeDepth != null)
                    {
                        jABGetJABElementProperties["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABGetJABElementPropertiesmaxRelativeDepth);
                        jABGetJABElementPropertiespropCount++;
                    }

                    jABGetJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetJABElementProperties["MaxRelativeDepth"] = 0;
                    jABGetJABElementPropertiespropCount++;
                }

                if (jABGetJABElementPropertiesmatchIndex != null)
                {
                    if (jABGetJABElementPropertiesmatchIndex != null)
                    {
                        jABGetJABElementProperties["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABGetJABElementPropertiesmatchIndex);
                        jABGetJABElementPropertiespropCount++;
                    }

                    jABGetJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetJABElementProperties["MatchIndex"] = 1;
                    jABGetJABElementPropertiespropCount++;
                }

                if (jABGetJABElementPropertiessearchFilter != null)
                {
                    jABGetJABElementProperties["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABGetJABElementPropertiessearchFilter);
                    jABGetJABElementPropertiespropCount++;
                }

                if (jABGetJABElementPropertiessortByColumn != null)
                {
                    jABGetJABElementProperties["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABGetJABElementPropertiessortByColumn);
                    jABGetJABElementPropertiespropCount++;
                }

                if (jABGetJABElementPropertiesmatchIndexAscending != null)
                {
                    if (jABGetJABElementPropertiesmatchIndexAscending != null)
                    {
                        jABGetJABElementProperties["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABGetJABElementPropertiesmatchIndexAscending);
                        jABGetJABElementPropertiespropCount++;
                    }

                    jABGetJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetJABElementProperties["MatchIndexAscending"] = true;
                    jABGetJABElementPropertiespropCount++;
                }

                if (jABGetJABElementPropertiescaseSensitiveSearch != null)
                {
                    if (jABGetJABElementPropertiescaseSensitiveSearch != null)
                    {
                        jABGetJABElementProperties["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABGetJABElementPropertiescaseSensitiveSearch);
                        jABGetJABElementPropertiespropCount++;
                    }

                    jABGetJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetJABElementProperties["CaseSensitiveSearch"] = false;
                    jABGetJABElementPropertiespropCount++;
                }

                if (jABGetJABElementPropertiesonlySearchVisibleElements != null)
                {
                    if (jABGetJABElementPropertiesonlySearchVisibleElements != null)
                    {
                        jABGetJABElementProperties["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABGetJABElementPropertiesonlySearchVisibleElements);
                        jABGetJABElementPropertiespropCount++;
                    }

                    jABGetJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetJABElementProperties["OnlySearchVisibleElements"] = true;
                    jABGetJABElementPropertiespropCount++;
                }

                if (jABGetJABElementPropertiesonlySearchShowingElements != null)
                {
                    if (jABGetJABElementPropertiesonlySearchShowingElements != null)
                    {
                        jABGetJABElementProperties["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABGetJABElementPropertiesonlySearchShowingElements);
                        jABGetJABElementPropertiespropCount++;
                    }

                    jABGetJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetJABElementProperties["OnlySearchShowingElements"] = true;
                    jABGetJABElementPropertiespropCount++;
                }

                if (jABGetJABElementPropertieselementRolesNotToTraverse != null)
                {
                    jABGetJABElementProperties["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABGetJABElementPropertieselementRolesNotToTraverse);
                    jABGetJABElementPropertiespropCount++;
                }

                if (jABGetJABElementPropertiesmaximumElementsToSearch != null)
                {
                    if (jABGetJABElementPropertiesmaximumElementsToSearch != null)
                    {
                        jABGetJABElementProperties["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABGetJABElementPropertiesmaximumElementsToSearch);
                        jABGetJABElementPropertiespropCount++;
                    }

                    jABGetJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetJABElementProperties["MaximumElementsToSearch"] = 2000;
                    jABGetJABElementPropertiespropCount++;
                }

                if (jABGetJABElementPropertiesmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABGetJABElementPropertiesmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetJABElementProperties["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABGetJABElementPropertiesmaximumChildElementsToSearchPerNode);
                        jABGetJABElementPropertiespropCount++;
                    }

                    jABGetJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetJABElementProperties["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGetJABElementPropertiespropCount++;
                }

                if (jABGetJABElementPropertiesmaxStringLength != null)
                {
                    if (jABGetJABElementPropertiesmaxStringLength != null)
                    {
                        jABGetJABElementProperties["MaxStringLength"] = SourceExpressionConverter.ConvertToken(jABGetJABElementPropertiesmaxStringLength);
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
                jABGetJABElementProperties["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetJABElementPropertiesworkflow);
                if (jABGetJABElementPropertiespropCount > 0)
                {
                    callPayload.Body = jABGetJABElementProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetJABElementPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABDrawRectangleAroundJABElement([WorkflowExpression] Func<int> jABDrawRectangleAroundJABElementsearchParentElementJABHandle, [WorkflowExpression] Func<string> jABDrawRectangleAroundJABElementworkflow, [WorkflowExpression] Func<string> jABDrawRectangleAroundJABElementsearchElementJABName = null, [WorkflowExpression] Func<string> jABDrawRectangleAroundJABElementsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABDrawRectangleAroundJABElementsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABDrawRectangleAroundJABElementsearchSubTree = null, [WorkflowExpression] Func<int> jABDrawRectangleAroundJABElementmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABDrawRectangleAroundJABElementmatchIndex = null, [WorkflowExpression] Func<string> jABDrawRectangleAroundJABElementsearchFilter = null, [WorkflowExpression] Func<string> jABDrawRectangleAroundJABElementsortByColumn = null, [WorkflowExpression] Func<bool> jABDrawRectangleAroundJABElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABDrawRectangleAroundJABElementcaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABDrawRectangleAroundJABElementonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABDrawRectangleAroundJABElementonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABDrawRectangleAroundJABElementelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABDrawRectangleAroundJABElementmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABDrawRectangleAroundJABElementmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> jABDrawRectangleAroundJABElementpenColour = null, [WorkflowExpression] Func<int> jABDrawRectangleAroundJABElementpenThicknessPixels = null)
        {
            SourceExpression.Validate(jABDrawRectangleAroundJABElementsearchParentElementJABHandle, nameof(jABDrawRectangleAroundJABElementsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABDrawRectangleAroundJABElementworkflow, nameof(jABDrawRectangleAroundJABElementworkflow), required: true);
            SourceExpression.Validate(jABDrawRectangleAroundJABElementsearchElementJABName, nameof(jABDrawRectangleAroundJABElementsearchElementJABName), required: false);
            SourceExpression.Validate(jABDrawRectangleAroundJABElementsearchElementJABDescription, nameof(jABDrawRectangleAroundJABElementsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABDrawRectangleAroundJABElementsearchElementJABRole, nameof(jABDrawRectangleAroundJABElementsearchElementJABRole), required: false);
            SourceExpression.Validate(jABDrawRectangleAroundJABElementsearchSubTree, nameof(jABDrawRectangleAroundJABElementsearchSubTree), required: false);
            SourceExpression.Validate(jABDrawRectangleAroundJABElementmaxRelativeDepth, nameof(jABDrawRectangleAroundJABElementmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABDrawRectangleAroundJABElementmatchIndex, nameof(jABDrawRectangleAroundJABElementmatchIndex), required: false);
            SourceExpression.Validate(jABDrawRectangleAroundJABElementsearchFilter, nameof(jABDrawRectangleAroundJABElementsearchFilter), required: false);
            SourceExpression.Validate(jABDrawRectangleAroundJABElementsortByColumn, nameof(jABDrawRectangleAroundJABElementsortByColumn), required: false);
            SourceExpression.Validate(jABDrawRectangleAroundJABElementmatchIndexAscending, nameof(jABDrawRectangleAroundJABElementmatchIndexAscending), required: false);
            SourceExpression.Validate(jABDrawRectangleAroundJABElementcaseSensitiveSearch, nameof(jABDrawRectangleAroundJABElementcaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABDrawRectangleAroundJABElementonlySearchVisibleElements, nameof(jABDrawRectangleAroundJABElementonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABDrawRectangleAroundJABElementonlySearchShowingElements, nameof(jABDrawRectangleAroundJABElementonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABDrawRectangleAroundJABElementelementRolesNotToTraverse, nameof(jABDrawRectangleAroundJABElementelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABDrawRectangleAroundJABElementmaximumElementsToSearch, nameof(jABDrawRectangleAroundJABElementmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABDrawRectangleAroundJABElementmaximumChildElementsToSearchPerNode, nameof(jABDrawRectangleAroundJABElementmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABDrawRectangleAroundJABElementpenColour, nameof(jABDrawRectangleAroundJABElementpenColour), required: false);
            SourceExpression.Validate(jABDrawRectangleAroundJABElementpenThicknessPixels, nameof(jABDrawRectangleAroundJABElementpenThicknessPixels), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABDrawRectangleAroundJABElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABDrawRectangleAroundJABElement = new JObject();
                var jABDrawRectangleAroundJABElementpropCount = 0;
                jABDrawRectangleAroundJABElementpropCount++;
                jABDrawRectangleAroundJABElement["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABDrawRectangleAroundJABElementsearchParentElementJABHandle);
                if (jABDrawRectangleAroundJABElementsearchElementJABName != null)
                {
                    jABDrawRectangleAroundJABElement["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABDrawRectangleAroundJABElementsearchElementJABName);
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (jABDrawRectangleAroundJABElementsearchElementJABDescription != null)
                {
                    jABDrawRectangleAroundJABElement["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABDrawRectangleAroundJABElementsearchElementJABDescription);
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (jABDrawRectangleAroundJABElementsearchElementJABRole != null)
                {
                    jABDrawRectangleAroundJABElement["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABDrawRectangleAroundJABElementsearchElementJABRole);
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (jABDrawRectangleAroundJABElementsearchSubTree != null)
                {
                    if (jABDrawRectangleAroundJABElementsearchSubTree != null)
                    {
                        jABDrawRectangleAroundJABElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABDrawRectangleAroundJABElementsearchSubTree);
                        jABDrawRectangleAroundJABElementpropCount++;
                    }

                    jABDrawRectangleAroundJABElementpropCount++;
                }
                else
                {
                    jABDrawRectangleAroundJABElement["SearchSubTree"] = true;
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (jABDrawRectangleAroundJABElementmaxRelativeDepth != null)
                {
                    if (jABDrawRectangleAroundJABElementmaxRelativeDepth != null)
                    {
                        jABDrawRectangleAroundJABElement["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABDrawRectangleAroundJABElementmaxRelativeDepth);
                        jABDrawRectangleAroundJABElementpropCount++;
                    }

                    jABDrawRectangleAroundJABElementpropCount++;
                }
                else
                {
                    jABDrawRectangleAroundJABElement["MaxRelativeDepth"] = 0;
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (jABDrawRectangleAroundJABElementmatchIndex != null)
                {
                    if (jABDrawRectangleAroundJABElementmatchIndex != null)
                    {
                        jABDrawRectangleAroundJABElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABDrawRectangleAroundJABElementmatchIndex);
                        jABDrawRectangleAroundJABElementpropCount++;
                    }

                    jABDrawRectangleAroundJABElementpropCount++;
                }
                else
                {
                    jABDrawRectangleAroundJABElement["MatchIndex"] = 1;
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (jABDrawRectangleAroundJABElementsearchFilter != null)
                {
                    jABDrawRectangleAroundJABElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABDrawRectangleAroundJABElementsearchFilter);
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (jABDrawRectangleAroundJABElementsortByColumn != null)
                {
                    jABDrawRectangleAroundJABElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABDrawRectangleAroundJABElementsortByColumn);
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (jABDrawRectangleAroundJABElementmatchIndexAscending != null)
                {
                    if (jABDrawRectangleAroundJABElementmatchIndexAscending != null)
                    {
                        jABDrawRectangleAroundJABElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABDrawRectangleAroundJABElementmatchIndexAscending);
                        jABDrawRectangleAroundJABElementpropCount++;
                    }

                    jABDrawRectangleAroundJABElementpropCount++;
                }
                else
                {
                    jABDrawRectangleAroundJABElement["MatchIndexAscending"] = true;
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (jABDrawRectangleAroundJABElementcaseSensitiveSearch != null)
                {
                    if (jABDrawRectangleAroundJABElementcaseSensitiveSearch != null)
                    {
                        jABDrawRectangleAroundJABElement["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABDrawRectangleAroundJABElementcaseSensitiveSearch);
                        jABDrawRectangleAroundJABElementpropCount++;
                    }

                    jABDrawRectangleAroundJABElementpropCount++;
                }
                else
                {
                    jABDrawRectangleAroundJABElement["CaseSensitiveSearch"] = false;
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (jABDrawRectangleAroundJABElementonlySearchVisibleElements != null)
                {
                    if (jABDrawRectangleAroundJABElementonlySearchVisibleElements != null)
                    {
                        jABDrawRectangleAroundJABElement["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABDrawRectangleAroundJABElementonlySearchVisibleElements);
                        jABDrawRectangleAroundJABElementpropCount++;
                    }

                    jABDrawRectangleAroundJABElementpropCount++;
                }
                else
                {
                    jABDrawRectangleAroundJABElement["OnlySearchVisibleElements"] = true;
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (jABDrawRectangleAroundJABElementonlySearchShowingElements != null)
                {
                    if (jABDrawRectangleAroundJABElementonlySearchShowingElements != null)
                    {
                        jABDrawRectangleAroundJABElement["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABDrawRectangleAroundJABElementonlySearchShowingElements);
                        jABDrawRectangleAroundJABElementpropCount++;
                    }

                    jABDrawRectangleAroundJABElementpropCount++;
                }
                else
                {
                    jABDrawRectangleAroundJABElement["OnlySearchShowingElements"] = true;
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (jABDrawRectangleAroundJABElementelementRolesNotToTraverse != null)
                {
                    jABDrawRectangleAroundJABElement["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABDrawRectangleAroundJABElementelementRolesNotToTraverse);
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (jABDrawRectangleAroundJABElementmaximumElementsToSearch != null)
                {
                    if (jABDrawRectangleAroundJABElementmaximumElementsToSearch != null)
                    {
                        jABDrawRectangleAroundJABElement["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABDrawRectangleAroundJABElementmaximumElementsToSearch);
                        jABDrawRectangleAroundJABElementpropCount++;
                    }

                    jABDrawRectangleAroundJABElementpropCount++;
                }
                else
                {
                    jABDrawRectangleAroundJABElement["MaximumElementsToSearch"] = 2000;
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (jABDrawRectangleAroundJABElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABDrawRectangleAroundJABElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABDrawRectangleAroundJABElement["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABDrawRectangleAroundJABElementmaximumChildElementsToSearchPerNode);
                        jABDrawRectangleAroundJABElementpropCount++;
                    }

                    jABDrawRectangleAroundJABElementpropCount++;
                }
                else
                {
                    jABDrawRectangleAroundJABElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (jABDrawRectangleAroundJABElementpenColour != null)
                {
                    if (jABDrawRectangleAroundJABElementpenColour != null)
                    {
                        jABDrawRectangleAroundJABElement["PenColour"] = SourceExpressionConverter.ConvertToken(jABDrawRectangleAroundJABElementpenColour);
                        jABDrawRectangleAroundJABElementpropCount++;
                    }

                    jABDrawRectangleAroundJABElementpropCount++;
                }
                else
                {
                    jABDrawRectangleAroundJABElement["PenColour"] = "Orange";
                    jABDrawRectangleAroundJABElementpropCount++;
                }

                if (jABDrawRectangleAroundJABElementpenThicknessPixels != null)
                {
                    if (jABDrawRectangleAroundJABElementpenThicknessPixels != null)
                    {
                        jABDrawRectangleAroundJABElement["PenThicknessPixels"] = SourceExpressionConverter.ConvertToken(jABDrawRectangleAroundJABElementpenThicknessPixels);
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
                jABDrawRectangleAroundJABElement["Workflow"] = SourceExpressionConverter.ConvertToken(jABDrawRectangleAroundJABElementworkflow);
                if (jABDrawRectangleAroundJABElementpropCount > 0)
                {
                    callPayload.Body = jABDrawRectangleAroundJABElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABDoesElementExistResponse> JABDoesElementExist([WorkflowExpression] Func<int> jABDoesElementExistsearchParentElementJABHandle, [WorkflowExpression] Func<string> jABDoesElementExistworkflow, [WorkflowExpression] Func<string> jABDoesElementExistsearchElementJABName = null, [WorkflowExpression] Func<string> jABDoesElementExistsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABDoesElementExistsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABDoesElementExistsearchSubTree = null, [WorkflowExpression] Func<int> jABDoesElementExistmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABDoesElementExistmatchIndex = null, [WorkflowExpression] Func<string> jABDoesElementExistsearchFilter = null, [WorkflowExpression] Func<string> jABDoesElementExistsortByColumn = null, [WorkflowExpression] Func<bool> jABDoesElementExistmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABDoesElementExistcaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABDoesElementExistonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABDoesElementExistonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABDoesElementExistelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABDoesElementExistmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABDoesElementExistmaximumChildElementsToSearchPerNode = null)
        {
            SourceExpression.Validate(jABDoesElementExistsearchParentElementJABHandle, nameof(jABDoesElementExistsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABDoesElementExistworkflow, nameof(jABDoesElementExistworkflow), required: true);
            SourceExpression.Validate(jABDoesElementExistsearchElementJABName, nameof(jABDoesElementExistsearchElementJABName), required: false);
            SourceExpression.Validate(jABDoesElementExistsearchElementJABDescription, nameof(jABDoesElementExistsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABDoesElementExistsearchElementJABRole, nameof(jABDoesElementExistsearchElementJABRole), required: false);
            SourceExpression.Validate(jABDoesElementExistsearchSubTree, nameof(jABDoesElementExistsearchSubTree), required: false);
            SourceExpression.Validate(jABDoesElementExistmaxRelativeDepth, nameof(jABDoesElementExistmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABDoesElementExistmatchIndex, nameof(jABDoesElementExistmatchIndex), required: false);
            SourceExpression.Validate(jABDoesElementExistsearchFilter, nameof(jABDoesElementExistsearchFilter), required: false);
            SourceExpression.Validate(jABDoesElementExistsortByColumn, nameof(jABDoesElementExistsortByColumn), required: false);
            SourceExpression.Validate(jABDoesElementExistmatchIndexAscending, nameof(jABDoesElementExistmatchIndexAscending), required: false);
            SourceExpression.Validate(jABDoesElementExistcaseSensitiveSearch, nameof(jABDoesElementExistcaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABDoesElementExistonlySearchVisibleElements, nameof(jABDoesElementExistonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABDoesElementExistonlySearchShowingElements, nameof(jABDoesElementExistonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABDoesElementExistelementRolesNotToTraverse, nameof(jABDoesElementExistelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABDoesElementExistmaximumElementsToSearch, nameof(jABDoesElementExistmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABDoesElementExistmaximumChildElementsToSearchPerNode, nameof(jABDoesElementExistmaximumChildElementsToSearchPerNode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABDoesElementExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABDoesElementExist = new JObject();
                var jABDoesElementExistpropCount = 0;
                jABDoesElementExistpropCount++;
                jABDoesElementExist["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABDoesElementExistsearchParentElementJABHandle);
                if (jABDoesElementExistsearchElementJABName != null)
                {
                    jABDoesElementExist["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABDoesElementExistsearchElementJABName);
                    jABDoesElementExistpropCount++;
                }

                if (jABDoesElementExistsearchElementJABDescription != null)
                {
                    jABDoesElementExist["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABDoesElementExistsearchElementJABDescription);
                    jABDoesElementExistpropCount++;
                }

                if (jABDoesElementExistsearchElementJABRole != null)
                {
                    jABDoesElementExist["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABDoesElementExistsearchElementJABRole);
                    jABDoesElementExistpropCount++;
                }

                if (jABDoesElementExistsearchSubTree != null)
                {
                    if (jABDoesElementExistsearchSubTree != null)
                    {
                        jABDoesElementExist["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABDoesElementExistsearchSubTree);
                        jABDoesElementExistpropCount++;
                    }

                    jABDoesElementExistpropCount++;
                }
                else
                {
                    jABDoesElementExist["SearchSubTree"] = true;
                    jABDoesElementExistpropCount++;
                }

                if (jABDoesElementExistmaxRelativeDepth != null)
                {
                    if (jABDoesElementExistmaxRelativeDepth != null)
                    {
                        jABDoesElementExist["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABDoesElementExistmaxRelativeDepth);
                        jABDoesElementExistpropCount++;
                    }

                    jABDoesElementExistpropCount++;
                }
                else
                {
                    jABDoesElementExist["MaxRelativeDepth"] = 0;
                    jABDoesElementExistpropCount++;
                }

                if (jABDoesElementExistmatchIndex != null)
                {
                    if (jABDoesElementExistmatchIndex != null)
                    {
                        jABDoesElementExist["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABDoesElementExistmatchIndex);
                        jABDoesElementExistpropCount++;
                    }

                    jABDoesElementExistpropCount++;
                }
                else
                {
                    jABDoesElementExist["MatchIndex"] = 1;
                    jABDoesElementExistpropCount++;
                }

                if (jABDoesElementExistsearchFilter != null)
                {
                    jABDoesElementExist["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABDoesElementExistsearchFilter);
                    jABDoesElementExistpropCount++;
                }

                if (jABDoesElementExistsortByColumn != null)
                {
                    jABDoesElementExist["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABDoesElementExistsortByColumn);
                    jABDoesElementExistpropCount++;
                }

                if (jABDoesElementExistmatchIndexAscending != null)
                {
                    if (jABDoesElementExistmatchIndexAscending != null)
                    {
                        jABDoesElementExist["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABDoesElementExistmatchIndexAscending);
                        jABDoesElementExistpropCount++;
                    }

                    jABDoesElementExistpropCount++;
                }
                else
                {
                    jABDoesElementExist["MatchIndexAscending"] = true;
                    jABDoesElementExistpropCount++;
                }

                if (jABDoesElementExistcaseSensitiveSearch != null)
                {
                    if (jABDoesElementExistcaseSensitiveSearch != null)
                    {
                        jABDoesElementExist["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABDoesElementExistcaseSensitiveSearch);
                        jABDoesElementExistpropCount++;
                    }

                    jABDoesElementExistpropCount++;
                }
                else
                {
                    jABDoesElementExist["CaseSensitiveSearch"] = false;
                    jABDoesElementExistpropCount++;
                }

                if (jABDoesElementExistonlySearchVisibleElements != null)
                {
                    if (jABDoesElementExistonlySearchVisibleElements != null)
                    {
                        jABDoesElementExist["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABDoesElementExistonlySearchVisibleElements);
                        jABDoesElementExistpropCount++;
                    }

                    jABDoesElementExistpropCount++;
                }
                else
                {
                    jABDoesElementExist["OnlySearchVisibleElements"] = true;
                    jABDoesElementExistpropCount++;
                }

                if (jABDoesElementExistonlySearchShowingElements != null)
                {
                    if (jABDoesElementExistonlySearchShowingElements != null)
                    {
                        jABDoesElementExist["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABDoesElementExistonlySearchShowingElements);
                        jABDoesElementExistpropCount++;
                    }

                    jABDoesElementExistpropCount++;
                }
                else
                {
                    jABDoesElementExist["OnlySearchShowingElements"] = true;
                    jABDoesElementExistpropCount++;
                }

                if (jABDoesElementExistelementRolesNotToTraverse != null)
                {
                    jABDoesElementExist["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABDoesElementExistelementRolesNotToTraverse);
                    jABDoesElementExistpropCount++;
                }

                if (jABDoesElementExistmaximumElementsToSearch != null)
                {
                    if (jABDoesElementExistmaximumElementsToSearch != null)
                    {
                        jABDoesElementExist["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABDoesElementExistmaximumElementsToSearch);
                        jABDoesElementExistpropCount++;
                    }

                    jABDoesElementExistpropCount++;
                }
                else
                {
                    jABDoesElementExist["MaximumElementsToSearch"] = 2000;
                    jABDoesElementExistpropCount++;
                }

                if (jABDoesElementExistmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABDoesElementExistmaximumChildElementsToSearchPerNode != null)
                    {
                        jABDoesElementExist["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABDoesElementExistmaximumChildElementsToSearchPerNode);
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
                jABDoesElementExist["Workflow"] = SourceExpressionConverter.ConvertToken(jABDoesElementExistworkflow);
                if (jABDoesElementExistpropCount > 0)
                {
                    callPayload.Body = jABDoesElementExist;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABDoesElementExistResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABWaitForElementResponse> JABWaitForElement([WorkflowExpression] Func<int> jABWaitForElementsearchParentElementJABHandle, [WorkflowExpression] Func<double> jABWaitForElementsecondsToWait, [WorkflowExpression] Func<string> jABWaitForElementworkflow, [WorkflowExpression] Func<string> jABWaitForElementsearchElementJABName = null, [WorkflowExpression] Func<string> jABWaitForElementsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABWaitForElementsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABWaitForElementsearchSubTree = null, [WorkflowExpression] Func<int> jABWaitForElementmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABWaitForElementmatchIndex = null, [WorkflowExpression] Func<string> jABWaitForElementsearchFilter = null, [WorkflowExpression] Func<string> jABWaitForElementsortByColumn = null, [WorkflowExpression] Func<bool> jABWaitForElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABWaitForElementcaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABWaitForElementonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABWaitForElementonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABWaitForElementelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABWaitForElementmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABWaitForElementmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<bool> jABWaitForElementraiseExceptionIfElementNotFound = null)
        {
            SourceExpression.Validate(jABWaitForElementsearchParentElementJABHandle, nameof(jABWaitForElementsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABWaitForElementsecondsToWait, nameof(jABWaitForElementsecondsToWait), required: true);
            SourceExpression.Validate(jABWaitForElementworkflow, nameof(jABWaitForElementworkflow), required: true);
            SourceExpression.Validate(jABWaitForElementsearchElementJABName, nameof(jABWaitForElementsearchElementJABName), required: false);
            SourceExpression.Validate(jABWaitForElementsearchElementJABDescription, nameof(jABWaitForElementsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABWaitForElementsearchElementJABRole, nameof(jABWaitForElementsearchElementJABRole), required: false);
            SourceExpression.Validate(jABWaitForElementsearchSubTree, nameof(jABWaitForElementsearchSubTree), required: false);
            SourceExpression.Validate(jABWaitForElementmaxRelativeDepth, nameof(jABWaitForElementmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABWaitForElementmatchIndex, nameof(jABWaitForElementmatchIndex), required: false);
            SourceExpression.Validate(jABWaitForElementsearchFilter, nameof(jABWaitForElementsearchFilter), required: false);
            SourceExpression.Validate(jABWaitForElementsortByColumn, nameof(jABWaitForElementsortByColumn), required: false);
            SourceExpression.Validate(jABWaitForElementmatchIndexAscending, nameof(jABWaitForElementmatchIndexAscending), required: false);
            SourceExpression.Validate(jABWaitForElementcaseSensitiveSearch, nameof(jABWaitForElementcaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABWaitForElementonlySearchVisibleElements, nameof(jABWaitForElementonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABWaitForElementonlySearchShowingElements, nameof(jABWaitForElementonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABWaitForElementelementRolesNotToTraverse, nameof(jABWaitForElementelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABWaitForElementmaximumElementsToSearch, nameof(jABWaitForElementmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABWaitForElementmaximumChildElementsToSearchPerNode, nameof(jABWaitForElementmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABWaitForElementraiseExceptionIfElementNotFound, nameof(jABWaitForElementraiseExceptionIfElementNotFound), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABWaitForElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABWaitForElement = new JObject();
                var jABWaitForElementpropCount = 0;
                jABWaitForElementpropCount++;
                jABWaitForElement["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABWaitForElementsearchParentElementJABHandle);
                if (jABWaitForElementsearchElementJABName != null)
                {
                    jABWaitForElement["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABWaitForElementsearchElementJABName);
                    jABWaitForElementpropCount++;
                }

                if (jABWaitForElementsearchElementJABDescription != null)
                {
                    jABWaitForElement["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABWaitForElementsearchElementJABDescription);
                    jABWaitForElementpropCount++;
                }

                if (jABWaitForElementsearchElementJABRole != null)
                {
                    jABWaitForElement["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABWaitForElementsearchElementJABRole);
                    jABWaitForElementpropCount++;
                }

                if (jABWaitForElementsearchSubTree != null)
                {
                    if (jABWaitForElementsearchSubTree != null)
                    {
                        jABWaitForElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABWaitForElementsearchSubTree);
                        jABWaitForElementpropCount++;
                    }

                    jABWaitForElementpropCount++;
                }
                else
                {
                    jABWaitForElement["SearchSubTree"] = true;
                    jABWaitForElementpropCount++;
                }

                if (jABWaitForElementmaxRelativeDepth != null)
                {
                    if (jABWaitForElementmaxRelativeDepth != null)
                    {
                        jABWaitForElement["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABWaitForElementmaxRelativeDepth);
                        jABWaitForElementpropCount++;
                    }

                    jABWaitForElementpropCount++;
                }
                else
                {
                    jABWaitForElement["MaxRelativeDepth"] = 0;
                    jABWaitForElementpropCount++;
                }

                if (jABWaitForElementmatchIndex != null)
                {
                    if (jABWaitForElementmatchIndex != null)
                    {
                        jABWaitForElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABWaitForElementmatchIndex);
                        jABWaitForElementpropCount++;
                    }

                    jABWaitForElementpropCount++;
                }
                else
                {
                    jABWaitForElement["MatchIndex"] = 1;
                    jABWaitForElementpropCount++;
                }

                if (jABWaitForElementsearchFilter != null)
                {
                    jABWaitForElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABWaitForElementsearchFilter);
                    jABWaitForElementpropCount++;
                }

                if (jABWaitForElementsortByColumn != null)
                {
                    jABWaitForElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABWaitForElementsortByColumn);
                    jABWaitForElementpropCount++;
                }

                if (jABWaitForElementmatchIndexAscending != null)
                {
                    if (jABWaitForElementmatchIndexAscending != null)
                    {
                        jABWaitForElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABWaitForElementmatchIndexAscending);
                        jABWaitForElementpropCount++;
                    }

                    jABWaitForElementpropCount++;
                }
                else
                {
                    jABWaitForElement["MatchIndexAscending"] = true;
                    jABWaitForElementpropCount++;
                }

                if (jABWaitForElementcaseSensitiveSearch != null)
                {
                    if (jABWaitForElementcaseSensitiveSearch != null)
                    {
                        jABWaitForElement["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABWaitForElementcaseSensitiveSearch);
                        jABWaitForElementpropCount++;
                    }

                    jABWaitForElementpropCount++;
                }
                else
                {
                    jABWaitForElement["CaseSensitiveSearch"] = false;
                    jABWaitForElementpropCount++;
                }

                if (jABWaitForElementonlySearchVisibleElements != null)
                {
                    if (jABWaitForElementonlySearchVisibleElements != null)
                    {
                        jABWaitForElement["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABWaitForElementonlySearchVisibleElements);
                        jABWaitForElementpropCount++;
                    }

                    jABWaitForElementpropCount++;
                }
                else
                {
                    jABWaitForElement["OnlySearchVisibleElements"] = true;
                    jABWaitForElementpropCount++;
                }

                if (jABWaitForElementonlySearchShowingElements != null)
                {
                    if (jABWaitForElementonlySearchShowingElements != null)
                    {
                        jABWaitForElement["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABWaitForElementonlySearchShowingElements);
                        jABWaitForElementpropCount++;
                    }

                    jABWaitForElementpropCount++;
                }
                else
                {
                    jABWaitForElement["OnlySearchShowingElements"] = true;
                    jABWaitForElementpropCount++;
                }

                if (jABWaitForElementelementRolesNotToTraverse != null)
                {
                    jABWaitForElement["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABWaitForElementelementRolesNotToTraverse);
                    jABWaitForElementpropCount++;
                }

                if (jABWaitForElementmaximumElementsToSearch != null)
                {
                    if (jABWaitForElementmaximumElementsToSearch != null)
                    {
                        jABWaitForElement["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABWaitForElementmaximumElementsToSearch);
                        jABWaitForElementpropCount++;
                    }

                    jABWaitForElementpropCount++;
                }
                else
                {
                    jABWaitForElement["MaximumElementsToSearch"] = 2000;
                    jABWaitForElementpropCount++;
                }

                if (jABWaitForElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABWaitForElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABWaitForElement["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABWaitForElementmaximumChildElementsToSearchPerNode);
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
                jABWaitForElement["SecondsToWait"] = SourceExpressionConverter.ConvertToken(jABWaitForElementsecondsToWait);
                if (jABWaitForElementraiseExceptionIfElementNotFound != null)
                {
                    if (jABWaitForElementraiseExceptionIfElementNotFound != null)
                    {
                        jABWaitForElement["RaiseExceptionIfElementNotFound"] = SourceExpressionConverter.ConvertToken(jABWaitForElementraiseExceptionIfElementNotFound);
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
                jABWaitForElement["Workflow"] = SourceExpressionConverter.ConvertToken(jABWaitForElementworkflow);
                if (jABWaitForElementpropCount > 0)
                {
                    callPayload.Body = jABWaitForElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABWaitForElementResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABWaitForElementToNotExistResponse> JABWaitForElementToNotExist([WorkflowExpression] Func<int> jABWaitForElementToNotExistsearchParentElementJABHandle, [WorkflowExpression] Func<double> jABWaitForElementToNotExistsecondsToWait, [WorkflowExpression] Func<string> jABWaitForElementToNotExistworkflow, [WorkflowExpression] Func<string> jABWaitForElementToNotExistsearchElementJABName = null, [WorkflowExpression] Func<string> jABWaitForElementToNotExistsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABWaitForElementToNotExistsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABWaitForElementToNotExistsearchSubTree = null, [WorkflowExpression] Func<int> jABWaitForElementToNotExistmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABWaitForElementToNotExistmatchIndex = null, [WorkflowExpression] Func<string> jABWaitForElementToNotExistsearchFilter = null, [WorkflowExpression] Func<string> jABWaitForElementToNotExistsortByColumn = null, [WorkflowExpression] Func<bool> jABWaitForElementToNotExistmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABWaitForElementToNotExistcaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABWaitForElementToNotExistonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABWaitForElementToNotExistonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABWaitForElementToNotExistelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABWaitForElementToNotExistmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABWaitForElementToNotExistmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<bool> jABWaitForElementToNotExistraiseExceptionIfElementStillExists = null)
        {
            SourceExpression.Validate(jABWaitForElementToNotExistsearchParentElementJABHandle, nameof(jABWaitForElementToNotExistsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABWaitForElementToNotExistsecondsToWait, nameof(jABWaitForElementToNotExistsecondsToWait), required: true);
            SourceExpression.Validate(jABWaitForElementToNotExistworkflow, nameof(jABWaitForElementToNotExistworkflow), required: true);
            SourceExpression.Validate(jABWaitForElementToNotExistsearchElementJABName, nameof(jABWaitForElementToNotExistsearchElementJABName), required: false);
            SourceExpression.Validate(jABWaitForElementToNotExistsearchElementJABDescription, nameof(jABWaitForElementToNotExistsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABWaitForElementToNotExistsearchElementJABRole, nameof(jABWaitForElementToNotExistsearchElementJABRole), required: false);
            SourceExpression.Validate(jABWaitForElementToNotExistsearchSubTree, nameof(jABWaitForElementToNotExistsearchSubTree), required: false);
            SourceExpression.Validate(jABWaitForElementToNotExistmaxRelativeDepth, nameof(jABWaitForElementToNotExistmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABWaitForElementToNotExistmatchIndex, nameof(jABWaitForElementToNotExistmatchIndex), required: false);
            SourceExpression.Validate(jABWaitForElementToNotExistsearchFilter, nameof(jABWaitForElementToNotExistsearchFilter), required: false);
            SourceExpression.Validate(jABWaitForElementToNotExistsortByColumn, nameof(jABWaitForElementToNotExistsortByColumn), required: false);
            SourceExpression.Validate(jABWaitForElementToNotExistmatchIndexAscending, nameof(jABWaitForElementToNotExistmatchIndexAscending), required: false);
            SourceExpression.Validate(jABWaitForElementToNotExistcaseSensitiveSearch, nameof(jABWaitForElementToNotExistcaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABWaitForElementToNotExistonlySearchVisibleElements, nameof(jABWaitForElementToNotExistonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABWaitForElementToNotExistonlySearchShowingElements, nameof(jABWaitForElementToNotExistonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABWaitForElementToNotExistelementRolesNotToTraverse, nameof(jABWaitForElementToNotExistelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABWaitForElementToNotExistmaximumElementsToSearch, nameof(jABWaitForElementToNotExistmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABWaitForElementToNotExistmaximumChildElementsToSearchPerNode, nameof(jABWaitForElementToNotExistmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABWaitForElementToNotExistraiseExceptionIfElementStillExists, nameof(jABWaitForElementToNotExistraiseExceptionIfElementStillExists), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABWaitForElementToNotExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABWaitForElementToNotExist = new JObject();
                var jABWaitForElementToNotExistpropCount = 0;
                jABWaitForElementToNotExistpropCount++;
                jABWaitForElementToNotExist["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABWaitForElementToNotExistsearchParentElementJABHandle);
                if (jABWaitForElementToNotExistsearchElementJABName != null)
                {
                    jABWaitForElementToNotExist["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABWaitForElementToNotExistsearchElementJABName);
                    jABWaitForElementToNotExistpropCount++;
                }

                if (jABWaitForElementToNotExistsearchElementJABDescription != null)
                {
                    jABWaitForElementToNotExist["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABWaitForElementToNotExistsearchElementJABDescription);
                    jABWaitForElementToNotExistpropCount++;
                }

                if (jABWaitForElementToNotExistsearchElementJABRole != null)
                {
                    jABWaitForElementToNotExist["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABWaitForElementToNotExistsearchElementJABRole);
                    jABWaitForElementToNotExistpropCount++;
                }

                if (jABWaitForElementToNotExistsearchSubTree != null)
                {
                    if (jABWaitForElementToNotExistsearchSubTree != null)
                    {
                        jABWaitForElementToNotExist["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABWaitForElementToNotExistsearchSubTree);
                        jABWaitForElementToNotExistpropCount++;
                    }

                    jABWaitForElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForElementToNotExist["SearchSubTree"] = true;
                    jABWaitForElementToNotExistpropCount++;
                }

                if (jABWaitForElementToNotExistmaxRelativeDepth != null)
                {
                    if (jABWaitForElementToNotExistmaxRelativeDepth != null)
                    {
                        jABWaitForElementToNotExist["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABWaitForElementToNotExistmaxRelativeDepth);
                        jABWaitForElementToNotExistpropCount++;
                    }

                    jABWaitForElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForElementToNotExist["MaxRelativeDepth"] = 0;
                    jABWaitForElementToNotExistpropCount++;
                }

                if (jABWaitForElementToNotExistmatchIndex != null)
                {
                    if (jABWaitForElementToNotExistmatchIndex != null)
                    {
                        jABWaitForElementToNotExist["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABWaitForElementToNotExistmatchIndex);
                        jABWaitForElementToNotExistpropCount++;
                    }

                    jABWaitForElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForElementToNotExist["MatchIndex"] = 1;
                    jABWaitForElementToNotExistpropCount++;
                }

                if (jABWaitForElementToNotExistsearchFilter != null)
                {
                    jABWaitForElementToNotExist["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABWaitForElementToNotExistsearchFilter);
                    jABWaitForElementToNotExistpropCount++;
                }

                if (jABWaitForElementToNotExistsortByColumn != null)
                {
                    jABWaitForElementToNotExist["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABWaitForElementToNotExistsortByColumn);
                    jABWaitForElementToNotExistpropCount++;
                }

                if (jABWaitForElementToNotExistmatchIndexAscending != null)
                {
                    if (jABWaitForElementToNotExistmatchIndexAscending != null)
                    {
                        jABWaitForElementToNotExist["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABWaitForElementToNotExistmatchIndexAscending);
                        jABWaitForElementToNotExistpropCount++;
                    }

                    jABWaitForElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForElementToNotExist["MatchIndexAscending"] = true;
                    jABWaitForElementToNotExistpropCount++;
                }

                if (jABWaitForElementToNotExistcaseSensitiveSearch != null)
                {
                    if (jABWaitForElementToNotExistcaseSensitiveSearch != null)
                    {
                        jABWaitForElementToNotExist["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABWaitForElementToNotExistcaseSensitiveSearch);
                        jABWaitForElementToNotExistpropCount++;
                    }

                    jABWaitForElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForElementToNotExist["CaseSensitiveSearch"] = false;
                    jABWaitForElementToNotExistpropCount++;
                }

                if (jABWaitForElementToNotExistonlySearchVisibleElements != null)
                {
                    if (jABWaitForElementToNotExistonlySearchVisibleElements != null)
                    {
                        jABWaitForElementToNotExist["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABWaitForElementToNotExistonlySearchVisibleElements);
                        jABWaitForElementToNotExistpropCount++;
                    }

                    jABWaitForElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForElementToNotExist["OnlySearchVisibleElements"] = true;
                    jABWaitForElementToNotExistpropCount++;
                }

                if (jABWaitForElementToNotExistonlySearchShowingElements != null)
                {
                    if (jABWaitForElementToNotExistonlySearchShowingElements != null)
                    {
                        jABWaitForElementToNotExist["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABWaitForElementToNotExistonlySearchShowingElements);
                        jABWaitForElementToNotExistpropCount++;
                    }

                    jABWaitForElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForElementToNotExist["OnlySearchShowingElements"] = true;
                    jABWaitForElementToNotExistpropCount++;
                }

                if (jABWaitForElementToNotExistelementRolesNotToTraverse != null)
                {
                    jABWaitForElementToNotExist["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABWaitForElementToNotExistelementRolesNotToTraverse);
                    jABWaitForElementToNotExistpropCount++;
                }

                if (jABWaitForElementToNotExistmaximumElementsToSearch != null)
                {
                    if (jABWaitForElementToNotExistmaximumElementsToSearch != null)
                    {
                        jABWaitForElementToNotExist["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABWaitForElementToNotExistmaximumElementsToSearch);
                        jABWaitForElementToNotExistpropCount++;
                    }

                    jABWaitForElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForElementToNotExist["MaximumElementsToSearch"] = 2000;
                    jABWaitForElementToNotExistpropCount++;
                }

                if (jABWaitForElementToNotExistmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABWaitForElementToNotExistmaximumChildElementsToSearchPerNode != null)
                    {
                        jABWaitForElementToNotExist["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABWaitForElementToNotExistmaximumChildElementsToSearchPerNode);
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
                jABWaitForElementToNotExist["SecondsToWait"] = SourceExpressionConverter.ConvertToken(jABWaitForElementToNotExistsecondsToWait);
                if (jABWaitForElementToNotExistraiseExceptionIfElementStillExists != null)
                {
                    if (jABWaitForElementToNotExistraiseExceptionIfElementStillExists != null)
                    {
                        jABWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = SourceExpressionConverter.ConvertToken(jABWaitForElementToNotExistraiseExceptionIfElementStillExists);
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
                jABWaitForElementToNotExist["Workflow"] = SourceExpressionConverter.ConvertToken(jABWaitForElementToNotExistworkflow);
                if (jABWaitForElementToNotExistpropCount > 0)
                {
                    callPayload.Body = jABWaitForElementToNotExist;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABWaitForElementToNotExistResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetDesktopElementsResponse> JABGetDesktopElements([WorkflowExpression] Func<string> jABGetDesktopElementsworkflow, [WorkflowExpression] Func<string> jABGetDesktopElementssearchElementLocalizedControlType = null, [WorkflowExpression] Func<int> jABGetDesktopElementssearchProcessId = null, [WorkflowExpression] Func<int> jABGetDesktopElementsfirstItemToReturn = null, [WorkflowExpression] Func<int> jABGetDesktopElementsmaxItemsToReturn = null, [WorkflowExpression] Func<bool> jABGetDesktopElementssearchChildElements = null, [WorkflowExpression] Func<int> jABGetDesktopElementsmaxStringLength = null, [WorkflowExpression] Func<bool> jABGetDesktopElementsincludeChildProcesses = null)
        {
            SourceExpression.Validate(jABGetDesktopElementsworkflow, nameof(jABGetDesktopElementsworkflow), required: true);
            SourceExpression.Validate(jABGetDesktopElementssearchElementLocalizedControlType, nameof(jABGetDesktopElementssearchElementLocalizedControlType), required: false);
            SourceExpression.Validate(jABGetDesktopElementssearchProcessId, nameof(jABGetDesktopElementssearchProcessId), required: false);
            SourceExpression.Validate(jABGetDesktopElementsfirstItemToReturn, nameof(jABGetDesktopElementsfirstItemToReturn), required: false);
            SourceExpression.Validate(jABGetDesktopElementsmaxItemsToReturn, nameof(jABGetDesktopElementsmaxItemsToReturn), required: false);
            SourceExpression.Validate(jABGetDesktopElementssearchChildElements, nameof(jABGetDesktopElementssearchChildElements), required: false);
            SourceExpression.Validate(jABGetDesktopElementsmaxStringLength, nameof(jABGetDesktopElementsmaxStringLength), required: false);
            SourceExpression.Validate(jABGetDesktopElementsincludeChildProcesses, nameof(jABGetDesktopElementsincludeChildProcesses), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetDesktopElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetDesktopElements = new JObject();
                var jABGetDesktopElementspropCount = 0;
                if (jABGetDesktopElementssearchElementLocalizedControlType != null)
                {
                    jABGetDesktopElements["SearchElementLocalizedControlType"] = SourceExpressionConverter.ConvertToken(jABGetDesktopElementssearchElementLocalizedControlType);
                    jABGetDesktopElementspropCount++;
                }

                if (jABGetDesktopElementssearchProcessId != null)
                {
                    if (jABGetDesktopElementssearchProcessId != null)
                    {
                        jABGetDesktopElements["SearchProcessID"] = SourceExpressionConverter.ConvertToken(jABGetDesktopElementssearchProcessId);
                        jABGetDesktopElementspropCount++;
                    }

                    jABGetDesktopElementspropCount++;
                }
                else
                {
                    jABGetDesktopElements["SearchProcessID"] = 0;
                    jABGetDesktopElementspropCount++;
                }

                if (jABGetDesktopElementsfirstItemToReturn != null)
                {
                    if (jABGetDesktopElementsfirstItemToReturn != null)
                    {
                        jABGetDesktopElements["FirstItemToReturn"] = SourceExpressionConverter.ConvertToken(jABGetDesktopElementsfirstItemToReturn);
                        jABGetDesktopElementspropCount++;
                    }

                    jABGetDesktopElementspropCount++;
                }
                else
                {
                    jABGetDesktopElements["FirstItemToReturn"] = 1;
                    jABGetDesktopElementspropCount++;
                }

                if (jABGetDesktopElementsmaxItemsToReturn != null)
                {
                    if (jABGetDesktopElementsmaxItemsToReturn != null)
                    {
                        jABGetDesktopElements["MaxItemsToReturn"] = SourceExpressionConverter.ConvertToken(jABGetDesktopElementsmaxItemsToReturn);
                        jABGetDesktopElementspropCount++;
                    }

                    jABGetDesktopElementspropCount++;
                }
                else
                {
                    jABGetDesktopElements["MaxItemsToReturn"] = 0;
                    jABGetDesktopElementspropCount++;
                }

                if (jABGetDesktopElementssearchChildElements != null)
                {
                    if (jABGetDesktopElementssearchChildElements != null)
                    {
                        jABGetDesktopElements["SearchChildElements"] = SourceExpressionConverter.ConvertToken(jABGetDesktopElementssearchChildElements);
                        jABGetDesktopElementspropCount++;
                    }

                    jABGetDesktopElementspropCount++;
                }
                else
                {
                    jABGetDesktopElements["SearchChildElements"] = true;
                    jABGetDesktopElementspropCount++;
                }

                if (jABGetDesktopElementsmaxStringLength != null)
                {
                    if (jABGetDesktopElementsmaxStringLength != null)
                    {
                        jABGetDesktopElements["MaxStringLength"] = SourceExpressionConverter.ConvertToken(jABGetDesktopElementsmaxStringLength);
                        jABGetDesktopElementspropCount++;
                    }

                    jABGetDesktopElementspropCount++;
                }
                else
                {
                    jABGetDesktopElements["MaxStringLength"] = 0;
                    jABGetDesktopElementspropCount++;
                }

                if (jABGetDesktopElementsincludeChildProcesses != null)
                {
                    if (jABGetDesktopElementsincludeChildProcesses != null)
                    {
                        jABGetDesktopElements["IncludeChildProcesses"] = SourceExpressionConverter.ConvertToken(jABGetDesktopElementsincludeChildProcesses);
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
                jABGetDesktopElements["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetDesktopElementsworkflow);
                if (jABGetDesktopElementspropCount > 0)
                {
                    callPayload.Body = jABGetDesktopElements;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetDesktopElementsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABDoesDesktopElementExistResponse> JABDoesDesktopElementExist([WorkflowExpression] Func<string> jABDoesDesktopElementExistworkflow, [WorkflowExpression] Func<string> jABDoesDesktopElementExistsearchUIAElementName = null, [WorkflowExpression] Func<string> jABDoesDesktopElementExistsearchUIAElementClassName = null, [WorkflowExpression] Func<string> jABDoesDesktopElementExistsearchUIAElementLocalizedControlType = null, [WorkflowExpression] Func<int> jABDoesDesktopElementExistsearchProcessId = null, [WorkflowExpression] Func<bool> jABDoesDesktopElementExistsearchChildElements = null, [WorkflowExpression] Func<int> jABDoesDesktopElementExistmatchIndex = null, [WorkflowExpression] Func<string> jABDoesDesktopElementExistsearchFilter = null, [WorkflowExpression] Func<string> jABDoesDesktopElementExistsortByColumn = null, [WorkflowExpression] Func<bool> jABDoesDesktopElementExistmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABDoesDesktopElementExistincludeChildProcesses = null)
        {
            SourceExpression.Validate(jABDoesDesktopElementExistworkflow, nameof(jABDoesDesktopElementExistworkflow), required: true);
            SourceExpression.Validate(jABDoesDesktopElementExistsearchUIAElementName, nameof(jABDoesDesktopElementExistsearchUIAElementName), required: false);
            SourceExpression.Validate(jABDoesDesktopElementExistsearchUIAElementClassName, nameof(jABDoesDesktopElementExistsearchUIAElementClassName), required: false);
            SourceExpression.Validate(jABDoesDesktopElementExistsearchUIAElementLocalizedControlType, nameof(jABDoesDesktopElementExistsearchUIAElementLocalizedControlType), required: false);
            SourceExpression.Validate(jABDoesDesktopElementExistsearchProcessId, nameof(jABDoesDesktopElementExistsearchProcessId), required: false);
            SourceExpression.Validate(jABDoesDesktopElementExistsearchChildElements, nameof(jABDoesDesktopElementExistsearchChildElements), required: false);
            SourceExpression.Validate(jABDoesDesktopElementExistmatchIndex, nameof(jABDoesDesktopElementExistmatchIndex), required: false);
            SourceExpression.Validate(jABDoesDesktopElementExistsearchFilter, nameof(jABDoesDesktopElementExistsearchFilter), required: false);
            SourceExpression.Validate(jABDoesDesktopElementExistsortByColumn, nameof(jABDoesDesktopElementExistsortByColumn), required: false);
            SourceExpression.Validate(jABDoesDesktopElementExistmatchIndexAscending, nameof(jABDoesDesktopElementExistmatchIndexAscending), required: false);
            SourceExpression.Validate(jABDoesDesktopElementExistincludeChildProcesses, nameof(jABDoesDesktopElementExistincludeChildProcesses), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABDoesDesktopElementExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABDoesDesktopElementExist = new JObject();
                var jABDoesDesktopElementExistpropCount = 0;
                if (jABDoesDesktopElementExistsearchUIAElementName != null)
                {
                    jABDoesDesktopElementExist["SearchUIAElementName"] = SourceExpressionConverter.ConvertToken(jABDoesDesktopElementExistsearchUIAElementName);
                    jABDoesDesktopElementExistpropCount++;
                }

                if (jABDoesDesktopElementExistsearchUIAElementClassName != null)
                {
                    jABDoesDesktopElementExist["SearchUIAElementClassName"] = SourceExpressionConverter.ConvertToken(jABDoesDesktopElementExistsearchUIAElementClassName);
                    jABDoesDesktopElementExistpropCount++;
                }

                if (jABDoesDesktopElementExistsearchUIAElementLocalizedControlType != null)
                {
                    jABDoesDesktopElementExist["SearchUIAElementLocalizedControlType"] = SourceExpressionConverter.ConvertToken(jABDoesDesktopElementExistsearchUIAElementLocalizedControlType);
                    jABDoesDesktopElementExistpropCount++;
                }

                if (jABDoesDesktopElementExistsearchProcessId != null)
                {
                    if (jABDoesDesktopElementExistsearchProcessId != null)
                    {
                        jABDoesDesktopElementExist["SearchProcessID"] = SourceExpressionConverter.ConvertToken(jABDoesDesktopElementExistsearchProcessId);
                        jABDoesDesktopElementExistpropCount++;
                    }

                    jABDoesDesktopElementExistpropCount++;
                }
                else
                {
                    jABDoesDesktopElementExist["SearchProcessID"] = 0;
                    jABDoesDesktopElementExistpropCount++;
                }

                if (jABDoesDesktopElementExistsearchChildElements != null)
                {
                    if (jABDoesDesktopElementExistsearchChildElements != null)
                    {
                        jABDoesDesktopElementExist["SearchChildElements"] = SourceExpressionConverter.ConvertToken(jABDoesDesktopElementExistsearchChildElements);
                        jABDoesDesktopElementExistpropCount++;
                    }

                    jABDoesDesktopElementExistpropCount++;
                }
                else
                {
                    jABDoesDesktopElementExist["SearchChildElements"] = true;
                    jABDoesDesktopElementExistpropCount++;
                }

                if (jABDoesDesktopElementExistmatchIndex != null)
                {
                    if (jABDoesDesktopElementExistmatchIndex != null)
                    {
                        jABDoesDesktopElementExist["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABDoesDesktopElementExistmatchIndex);
                        jABDoesDesktopElementExistpropCount++;
                    }

                    jABDoesDesktopElementExistpropCount++;
                }
                else
                {
                    jABDoesDesktopElementExist["MatchIndex"] = 1;
                    jABDoesDesktopElementExistpropCount++;
                }

                if (jABDoesDesktopElementExistsearchFilter != null)
                {
                    jABDoesDesktopElementExist["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABDoesDesktopElementExistsearchFilter);
                    jABDoesDesktopElementExistpropCount++;
                }

                if (jABDoesDesktopElementExistsortByColumn != null)
                {
                    jABDoesDesktopElementExist["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABDoesDesktopElementExistsortByColumn);
                    jABDoesDesktopElementExistpropCount++;
                }

                if (jABDoesDesktopElementExistmatchIndexAscending != null)
                {
                    if (jABDoesDesktopElementExistmatchIndexAscending != null)
                    {
                        jABDoesDesktopElementExist["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABDoesDesktopElementExistmatchIndexAscending);
                        jABDoesDesktopElementExistpropCount++;
                    }

                    jABDoesDesktopElementExistpropCount++;
                }
                else
                {
                    jABDoesDesktopElementExist["MatchIndexAscending"] = true;
                    jABDoesDesktopElementExistpropCount++;
                }

                if (jABDoesDesktopElementExistincludeChildProcesses != null)
                {
                    if (jABDoesDesktopElementExistincludeChildProcesses != null)
                    {
                        jABDoesDesktopElementExist["IncludeChildProcesses"] = SourceExpressionConverter.ConvertToken(jABDoesDesktopElementExistincludeChildProcesses);
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
                jABDoesDesktopElementExist["Workflow"] = SourceExpressionConverter.ConvertToken(jABDoesDesktopElementExistworkflow);
                if (jABDoesDesktopElementExistpropCount > 0)
                {
                    callPayload.Body = jABDoesDesktopElementExist;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABDoesDesktopElementExistResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABWaitForDesktopElementResponse> JABWaitForDesktopElement([WorkflowExpression] Func<double> jABWaitForDesktopElementsecondsToWait, [WorkflowExpression] Func<string> jABWaitForDesktopElementworkflow, [WorkflowExpression] Func<string> jABWaitForDesktopElementsearchUIAElementName = null, [WorkflowExpression] Func<string> jABWaitForDesktopElementsearchUIAElementClassName = null, [WorkflowExpression] Func<string> jABWaitForDesktopElementsearchUIAElementLocalizedControlType = null, [WorkflowExpression] Func<int> jABWaitForDesktopElementsearchProcessId = null, [WorkflowExpression] Func<bool> jABWaitForDesktopElementsearchChildElements = null, [WorkflowExpression] Func<int> jABWaitForDesktopElementmatchIndex = null, [WorkflowExpression] Func<string> jABWaitForDesktopElementsearchFilter = null, [WorkflowExpression] Func<string> jABWaitForDesktopElementsortByColumn = null, [WorkflowExpression] Func<bool> jABWaitForDesktopElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABWaitForDesktopElementincludeChildProcesses = null, [WorkflowExpression] Func<bool> jABWaitForDesktopElementraiseExceptionIfElementNotFound = null)
        {
            SourceExpression.Validate(jABWaitForDesktopElementsecondsToWait, nameof(jABWaitForDesktopElementsecondsToWait), required: true);
            SourceExpression.Validate(jABWaitForDesktopElementworkflow, nameof(jABWaitForDesktopElementworkflow), required: true);
            SourceExpression.Validate(jABWaitForDesktopElementsearchUIAElementName, nameof(jABWaitForDesktopElementsearchUIAElementName), required: false);
            SourceExpression.Validate(jABWaitForDesktopElementsearchUIAElementClassName, nameof(jABWaitForDesktopElementsearchUIAElementClassName), required: false);
            SourceExpression.Validate(jABWaitForDesktopElementsearchUIAElementLocalizedControlType, nameof(jABWaitForDesktopElementsearchUIAElementLocalizedControlType), required: false);
            SourceExpression.Validate(jABWaitForDesktopElementsearchProcessId, nameof(jABWaitForDesktopElementsearchProcessId), required: false);
            SourceExpression.Validate(jABWaitForDesktopElementsearchChildElements, nameof(jABWaitForDesktopElementsearchChildElements), required: false);
            SourceExpression.Validate(jABWaitForDesktopElementmatchIndex, nameof(jABWaitForDesktopElementmatchIndex), required: false);
            SourceExpression.Validate(jABWaitForDesktopElementsearchFilter, nameof(jABWaitForDesktopElementsearchFilter), required: false);
            SourceExpression.Validate(jABWaitForDesktopElementsortByColumn, nameof(jABWaitForDesktopElementsortByColumn), required: false);
            SourceExpression.Validate(jABWaitForDesktopElementmatchIndexAscending, nameof(jABWaitForDesktopElementmatchIndexAscending), required: false);
            SourceExpression.Validate(jABWaitForDesktopElementincludeChildProcesses, nameof(jABWaitForDesktopElementincludeChildProcesses), required: false);
            SourceExpression.Validate(jABWaitForDesktopElementraiseExceptionIfElementNotFound, nameof(jABWaitForDesktopElementraiseExceptionIfElementNotFound), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABWaitForDesktopElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABWaitForDesktopElement = new JObject();
                var jABWaitForDesktopElementpropCount = 0;
                if (jABWaitForDesktopElementsearchUIAElementName != null)
                {
                    jABWaitForDesktopElement["SearchUIAElementName"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementsearchUIAElementName);
                    jABWaitForDesktopElementpropCount++;
                }

                if (jABWaitForDesktopElementsearchUIAElementClassName != null)
                {
                    jABWaitForDesktopElement["SearchUIAElementClassName"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementsearchUIAElementClassName);
                    jABWaitForDesktopElementpropCount++;
                }

                if (jABWaitForDesktopElementsearchUIAElementLocalizedControlType != null)
                {
                    jABWaitForDesktopElement["SearchUIAElementLocalizedControlType"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementsearchUIAElementLocalizedControlType);
                    jABWaitForDesktopElementpropCount++;
                }

                if (jABWaitForDesktopElementsearchProcessId != null)
                {
                    if (jABWaitForDesktopElementsearchProcessId != null)
                    {
                        jABWaitForDesktopElement["SearchProcessID"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementsearchProcessId);
                        jABWaitForDesktopElementpropCount++;
                    }

                    jABWaitForDesktopElementpropCount++;
                }
                else
                {
                    jABWaitForDesktopElement["SearchProcessID"] = 0;
                    jABWaitForDesktopElementpropCount++;
                }

                if (jABWaitForDesktopElementsearchChildElements != null)
                {
                    if (jABWaitForDesktopElementsearchChildElements != null)
                    {
                        jABWaitForDesktopElement["SearchChildElements"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementsearchChildElements);
                        jABWaitForDesktopElementpropCount++;
                    }

                    jABWaitForDesktopElementpropCount++;
                }
                else
                {
                    jABWaitForDesktopElement["SearchChildElements"] = true;
                    jABWaitForDesktopElementpropCount++;
                }

                if (jABWaitForDesktopElementmatchIndex != null)
                {
                    if (jABWaitForDesktopElementmatchIndex != null)
                    {
                        jABWaitForDesktopElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementmatchIndex);
                        jABWaitForDesktopElementpropCount++;
                    }

                    jABWaitForDesktopElementpropCount++;
                }
                else
                {
                    jABWaitForDesktopElement["MatchIndex"] = 1;
                    jABWaitForDesktopElementpropCount++;
                }

                if (jABWaitForDesktopElementsearchFilter != null)
                {
                    jABWaitForDesktopElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementsearchFilter);
                    jABWaitForDesktopElementpropCount++;
                }

                if (jABWaitForDesktopElementsortByColumn != null)
                {
                    jABWaitForDesktopElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementsortByColumn);
                    jABWaitForDesktopElementpropCount++;
                }

                if (jABWaitForDesktopElementmatchIndexAscending != null)
                {
                    if (jABWaitForDesktopElementmatchIndexAscending != null)
                    {
                        jABWaitForDesktopElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementmatchIndexAscending);
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
                jABWaitForDesktopElement["SecondsToWait"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementsecondsToWait);
                if (jABWaitForDesktopElementincludeChildProcesses != null)
                {
                    if (jABWaitForDesktopElementincludeChildProcesses != null)
                    {
                        jABWaitForDesktopElement["IncludeChildProcesses"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementincludeChildProcesses);
                        jABWaitForDesktopElementpropCount++;
                    }

                    jABWaitForDesktopElementpropCount++;
                }
                else
                {
                    jABWaitForDesktopElement["IncludeChildProcesses"] = true;
                    jABWaitForDesktopElementpropCount++;
                }

                if (jABWaitForDesktopElementraiseExceptionIfElementNotFound != null)
                {
                    if (jABWaitForDesktopElementraiseExceptionIfElementNotFound != null)
                    {
                        jABWaitForDesktopElement["RaiseExceptionIfElementNotFound"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementraiseExceptionIfElementNotFound);
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
                jABWaitForDesktopElement["Workflow"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementworkflow);
                if (jABWaitForDesktopElementpropCount > 0)
                {
                    callPayload.Body = jABWaitForDesktopElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABWaitForDesktopElementResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABWaitForDesktopElementToNotExistResponse> JABWaitForDesktopElementToNotExist([WorkflowExpression] Func<double> jABWaitForDesktopElementToNotExistsecondsToWait, [WorkflowExpression] Func<string> jABWaitForDesktopElementToNotExistworkflow, [WorkflowExpression] Func<string> jABWaitForDesktopElementToNotExistsearchUIAElementName = null, [WorkflowExpression] Func<string> jABWaitForDesktopElementToNotExistsearchUIAElementClassName = null, [WorkflowExpression] Func<string> jABWaitForDesktopElementToNotExistsearchUIAElementLocalizedControlType = null, [WorkflowExpression] Func<int> jABWaitForDesktopElementToNotExistsearchProcessId = null, [WorkflowExpression] Func<bool> jABWaitForDesktopElementToNotExistsearchChildElements = null, [WorkflowExpression] Func<int> jABWaitForDesktopElementToNotExistmatchIndex = null, [WorkflowExpression] Func<string> jABWaitForDesktopElementToNotExistsearchFilter = null, [WorkflowExpression] Func<string> jABWaitForDesktopElementToNotExistsortByColumn = null, [WorkflowExpression] Func<bool> jABWaitForDesktopElementToNotExistmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABWaitForDesktopElementToNotExistincludeChildProcesses = null, [WorkflowExpression] Func<bool> jABWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists = null)
        {
            SourceExpression.Validate(jABWaitForDesktopElementToNotExistsecondsToWait, nameof(jABWaitForDesktopElementToNotExistsecondsToWait), required: true);
            SourceExpression.Validate(jABWaitForDesktopElementToNotExistworkflow, nameof(jABWaitForDesktopElementToNotExistworkflow), required: true);
            SourceExpression.Validate(jABWaitForDesktopElementToNotExistsearchUIAElementName, nameof(jABWaitForDesktopElementToNotExistsearchUIAElementName), required: false);
            SourceExpression.Validate(jABWaitForDesktopElementToNotExistsearchUIAElementClassName, nameof(jABWaitForDesktopElementToNotExistsearchUIAElementClassName), required: false);
            SourceExpression.Validate(jABWaitForDesktopElementToNotExistsearchUIAElementLocalizedControlType, nameof(jABWaitForDesktopElementToNotExistsearchUIAElementLocalizedControlType), required: false);
            SourceExpression.Validate(jABWaitForDesktopElementToNotExistsearchProcessId, nameof(jABWaitForDesktopElementToNotExistsearchProcessId), required: false);
            SourceExpression.Validate(jABWaitForDesktopElementToNotExistsearchChildElements, nameof(jABWaitForDesktopElementToNotExistsearchChildElements), required: false);
            SourceExpression.Validate(jABWaitForDesktopElementToNotExistmatchIndex, nameof(jABWaitForDesktopElementToNotExistmatchIndex), required: false);
            SourceExpression.Validate(jABWaitForDesktopElementToNotExistsearchFilter, nameof(jABWaitForDesktopElementToNotExistsearchFilter), required: false);
            SourceExpression.Validate(jABWaitForDesktopElementToNotExistsortByColumn, nameof(jABWaitForDesktopElementToNotExistsortByColumn), required: false);
            SourceExpression.Validate(jABWaitForDesktopElementToNotExistmatchIndexAscending, nameof(jABWaitForDesktopElementToNotExistmatchIndexAscending), required: false);
            SourceExpression.Validate(jABWaitForDesktopElementToNotExistincludeChildProcesses, nameof(jABWaitForDesktopElementToNotExistincludeChildProcesses), required: false);
            SourceExpression.Validate(jABWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists, nameof(jABWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABWaitForDesktopElementToNotExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABWaitForDesktopElementToNotExist = new JObject();
                var jABWaitForDesktopElementToNotExistpropCount = 0;
                if (jABWaitForDesktopElementToNotExistsearchUIAElementName != null)
                {
                    jABWaitForDesktopElementToNotExist["SearchUIAElementName"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementToNotExistsearchUIAElementName);
                    jABWaitForDesktopElementToNotExistpropCount++;
                }

                if (jABWaitForDesktopElementToNotExistsearchUIAElementClassName != null)
                {
                    jABWaitForDesktopElementToNotExist["SearchUIAElementClassName"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementToNotExistsearchUIAElementClassName);
                    jABWaitForDesktopElementToNotExistpropCount++;
                }

                if (jABWaitForDesktopElementToNotExistsearchUIAElementLocalizedControlType != null)
                {
                    jABWaitForDesktopElementToNotExist["SearchUIAElementLocalizedControlType"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementToNotExistsearchUIAElementLocalizedControlType);
                    jABWaitForDesktopElementToNotExistpropCount++;
                }

                if (jABWaitForDesktopElementToNotExistsearchProcessId != null)
                {
                    if (jABWaitForDesktopElementToNotExistsearchProcessId != null)
                    {
                        jABWaitForDesktopElementToNotExist["SearchProcessID"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementToNotExistsearchProcessId);
                        jABWaitForDesktopElementToNotExistpropCount++;
                    }

                    jABWaitForDesktopElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForDesktopElementToNotExist["SearchProcessID"] = 0;
                    jABWaitForDesktopElementToNotExistpropCount++;
                }

                if (jABWaitForDesktopElementToNotExistsearchChildElements != null)
                {
                    if (jABWaitForDesktopElementToNotExistsearchChildElements != null)
                    {
                        jABWaitForDesktopElementToNotExist["SearchChildElements"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementToNotExistsearchChildElements);
                        jABWaitForDesktopElementToNotExistpropCount++;
                    }

                    jABWaitForDesktopElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForDesktopElementToNotExist["SearchChildElements"] = true;
                    jABWaitForDesktopElementToNotExistpropCount++;
                }

                if (jABWaitForDesktopElementToNotExistmatchIndex != null)
                {
                    if (jABWaitForDesktopElementToNotExistmatchIndex != null)
                    {
                        jABWaitForDesktopElementToNotExist["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementToNotExistmatchIndex);
                        jABWaitForDesktopElementToNotExistpropCount++;
                    }

                    jABWaitForDesktopElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForDesktopElementToNotExist["MatchIndex"] = 1;
                    jABWaitForDesktopElementToNotExistpropCount++;
                }

                if (jABWaitForDesktopElementToNotExistsearchFilter != null)
                {
                    jABWaitForDesktopElementToNotExist["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementToNotExistsearchFilter);
                    jABWaitForDesktopElementToNotExistpropCount++;
                }

                if (jABWaitForDesktopElementToNotExistsortByColumn != null)
                {
                    jABWaitForDesktopElementToNotExist["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementToNotExistsortByColumn);
                    jABWaitForDesktopElementToNotExistpropCount++;
                }

                if (jABWaitForDesktopElementToNotExistmatchIndexAscending != null)
                {
                    if (jABWaitForDesktopElementToNotExistmatchIndexAscending != null)
                    {
                        jABWaitForDesktopElementToNotExist["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementToNotExistmatchIndexAscending);
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
                jABWaitForDesktopElementToNotExist["SecondsToWait"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementToNotExistsecondsToWait);
                if (jABWaitForDesktopElementToNotExistincludeChildProcesses != null)
                {
                    if (jABWaitForDesktopElementToNotExistincludeChildProcesses != null)
                    {
                        jABWaitForDesktopElementToNotExist["IncludeChildProcesses"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementToNotExistincludeChildProcesses);
                        jABWaitForDesktopElementToNotExistpropCount++;
                    }

                    jABWaitForDesktopElementToNotExistpropCount++;
                }
                else
                {
                    jABWaitForDesktopElementToNotExist["IncludeChildProcesses"] = true;
                    jABWaitForDesktopElementToNotExistpropCount++;
                }

                if (jABWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists != null)
                {
                    if (jABWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists != null)
                    {
                        jABWaitForDesktopElementToNotExist["RaiseExceptionIfElementStillExists"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists);
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
                jABWaitForDesktopElementToNotExist["Workflow"] = SourceExpressionConverter.ConvertToken(jABWaitForDesktopElementToNotExistworkflow);
                if (jABWaitForDesktopElementToNotExistpropCount > 0)
                {
                    callPayload.Body = jABWaitForDesktopElementToNotExist;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABWaitForDesktopElementToNotExistResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABFreeAllJABHandles([WorkflowExpression] Func<string> jABFreeAllJABHandlesworkflow)
        {
            SourceExpression.Validate(jABFreeAllJABHandlesworkflow, nameof(jABFreeAllJABHandlesworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABFreeAllJABHandles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABFreeAllJABHandles = new JObject();
                var jABFreeAllJABHandlespropCount = 0;
                jABFreeAllJABHandlespropCount++;
                jABFreeAllJABHandles["Workflow"] = SourceExpressionConverter.ConvertToken(jABFreeAllJABHandlesworkflow);
                if (jABFreeAllJABHandlespropCount > 0)
                {
                    callPayload.Body = jABFreeAllJABHandles;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetChildJABElementPropertiesResponse> JABGetChildJABElementProperties([WorkflowExpression] Func<int> jABGetChildJABElementPropertiessearchElementJABHandle, [WorkflowExpression] Func<int> jABGetChildJABElementPropertiessearchChildIndex, [WorkflowExpression] Func<string> jABGetChildJABElementPropertiesworkflow, [WorkflowExpression] Func<int> jABGetChildJABElementPropertiesmaxStringLength = null)
        {
            SourceExpression.Validate(jABGetChildJABElementPropertiessearchElementJABHandle, nameof(jABGetChildJABElementPropertiessearchElementJABHandle), required: true);
            SourceExpression.Validate(jABGetChildJABElementPropertiessearchChildIndex, nameof(jABGetChildJABElementPropertiessearchChildIndex), required: true);
            SourceExpression.Validate(jABGetChildJABElementPropertiesworkflow, nameof(jABGetChildJABElementPropertiesworkflow), required: true);
            SourceExpression.Validate(jABGetChildJABElementPropertiesmaxStringLength, nameof(jABGetChildJABElementPropertiesmaxStringLength), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetChildJABElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetChildJABElementProperties = new JObject();
                var jABGetChildJABElementPropertiespropCount = 0;
                jABGetChildJABElementPropertiespropCount++;
                jABGetChildJABElementProperties["SearchElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGetChildJABElementPropertiessearchElementJABHandle);
                jABGetChildJABElementPropertiespropCount++;
                jABGetChildJABElementProperties["SearchChildIndex"] = SourceExpressionConverter.ConvertToken(jABGetChildJABElementPropertiessearchChildIndex);
                if (jABGetChildJABElementPropertiesmaxStringLength != null)
                {
                    if (jABGetChildJABElementPropertiesmaxStringLength != null)
                    {
                        jABGetChildJABElementProperties["MaxStringLength"] = SourceExpressionConverter.ConvertToken(jABGetChildJABElementPropertiesmaxStringLength);
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
                jABGetChildJABElementProperties["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetChildJABElementPropertiesworkflow);
                if (jABGetChildJABElementPropertiespropCount > 0)
                {
                    callPayload.Body = jABGetChildJABElementProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetChildJABElementPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetAllChildJABElementPropertiesResponse> JABGetAllChildJABElementProperties([WorkflowExpression] Func<int> jABGetAllChildJABElementPropertiessearchElementJABHandle, [WorkflowExpression] Func<string> jABGetAllChildJABElementPropertiesworkflow, [WorkflowExpression] Func<int> jABGetAllChildJABElementPropertiesfirstItemToReturn = null, [WorkflowExpression] Func<int> jABGetAllChildJABElementPropertiesmaxItemsToReturn = null, [WorkflowExpression] Func<int> jABGetAllChildJABElementPropertiesmaxStringLength = null, [WorkflowExpression] Func<bool> jABGetAllChildJABElementPropertiessearchDescendants = null, [WorkflowExpression] Func<string> jABGetAllChildJABElementPropertiessearchRole = null, [WorkflowExpression] Func<int> jABGetAllChildJABElementPropertiesmaxRelativeDepth = null)
        {
            SourceExpression.Validate(jABGetAllChildJABElementPropertiessearchElementJABHandle, nameof(jABGetAllChildJABElementPropertiessearchElementJABHandle), required: true);
            SourceExpression.Validate(jABGetAllChildJABElementPropertiesworkflow, nameof(jABGetAllChildJABElementPropertiesworkflow), required: true);
            SourceExpression.Validate(jABGetAllChildJABElementPropertiesfirstItemToReturn, nameof(jABGetAllChildJABElementPropertiesfirstItemToReturn), required: false);
            SourceExpression.Validate(jABGetAllChildJABElementPropertiesmaxItemsToReturn, nameof(jABGetAllChildJABElementPropertiesmaxItemsToReturn), required: false);
            SourceExpression.Validate(jABGetAllChildJABElementPropertiesmaxStringLength, nameof(jABGetAllChildJABElementPropertiesmaxStringLength), required: false);
            SourceExpression.Validate(jABGetAllChildJABElementPropertiessearchDescendants, nameof(jABGetAllChildJABElementPropertiessearchDescendants), required: false);
            SourceExpression.Validate(jABGetAllChildJABElementPropertiessearchRole, nameof(jABGetAllChildJABElementPropertiessearchRole), required: false);
            SourceExpression.Validate(jABGetAllChildJABElementPropertiesmaxRelativeDepth, nameof(jABGetAllChildJABElementPropertiesmaxRelativeDepth), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetAllChildJABElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetAllChildJABElementProperties = new JObject();
                var jABGetAllChildJABElementPropertiespropCount = 0;
                jABGetAllChildJABElementPropertiespropCount++;
                jABGetAllChildJABElementProperties["SearchElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGetAllChildJABElementPropertiessearchElementJABHandle);
                if (jABGetAllChildJABElementPropertiesfirstItemToReturn != null)
                {
                    if (jABGetAllChildJABElementPropertiesfirstItemToReturn != null)
                    {
                        jABGetAllChildJABElementProperties["FirstItemToReturn"] = SourceExpressionConverter.ConvertToken(jABGetAllChildJABElementPropertiesfirstItemToReturn);
                        jABGetAllChildJABElementPropertiespropCount++;
                    }

                    jABGetAllChildJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetAllChildJABElementProperties["FirstItemToReturn"] = 1;
                    jABGetAllChildJABElementPropertiespropCount++;
                }

                if (jABGetAllChildJABElementPropertiesmaxItemsToReturn != null)
                {
                    if (jABGetAllChildJABElementPropertiesmaxItemsToReturn != null)
                    {
                        jABGetAllChildJABElementProperties["MaxItemsToReturn"] = SourceExpressionConverter.ConvertToken(jABGetAllChildJABElementPropertiesmaxItemsToReturn);
                        jABGetAllChildJABElementPropertiespropCount++;
                    }

                    jABGetAllChildJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetAllChildJABElementProperties["MaxItemsToReturn"] = 0;
                    jABGetAllChildJABElementPropertiespropCount++;
                }

                if (jABGetAllChildJABElementPropertiesmaxStringLength != null)
                {
                    if (jABGetAllChildJABElementPropertiesmaxStringLength != null)
                    {
                        jABGetAllChildJABElementProperties["MaxStringLength"] = SourceExpressionConverter.ConvertToken(jABGetAllChildJABElementPropertiesmaxStringLength);
                        jABGetAllChildJABElementPropertiespropCount++;
                    }

                    jABGetAllChildJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetAllChildJABElementProperties["MaxStringLength"] = 0;
                    jABGetAllChildJABElementPropertiespropCount++;
                }

                if (jABGetAllChildJABElementPropertiessearchDescendants != null)
                {
                    if (jABGetAllChildJABElementPropertiessearchDescendants != null)
                    {
                        jABGetAllChildJABElementProperties["SearchDescendants"] = SourceExpressionConverter.ConvertToken(jABGetAllChildJABElementPropertiessearchDescendants);
                        jABGetAllChildJABElementPropertiespropCount++;
                    }

                    jABGetAllChildJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetAllChildJABElementProperties["SearchDescendants"] = false;
                    jABGetAllChildJABElementPropertiespropCount++;
                }

                if (jABGetAllChildJABElementPropertiessearchRole != null)
                {
                    jABGetAllChildJABElementProperties["SearchRole"] = SourceExpressionConverter.ConvertToken(jABGetAllChildJABElementPropertiessearchRole);
                    jABGetAllChildJABElementPropertiespropCount++;
                }

                if (jABGetAllChildJABElementPropertiesmaxRelativeDepth != null)
                {
                    if (jABGetAllChildJABElementPropertiesmaxRelativeDepth != null)
                    {
                        jABGetAllChildJABElementProperties["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABGetAllChildJABElementPropertiesmaxRelativeDepth);
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
                jABGetAllChildJABElementProperties["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetAllChildJABElementPropertiesworkflow);
                if (jABGetAllChildJABElementPropertiespropCount > 0)
                {
                    callPayload.Body = jABGetAllChildJABElementProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetAllChildJABElementPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetParentJABElementPropertiesResponse> JABGetParentJABElementProperties([WorkflowExpression] Func<int> jABGetParentJABElementPropertiessearchElementJABHandle, [WorkflowExpression] Func<string> jABGetParentJABElementPropertiesworkflow, [WorkflowExpression] Func<int> jABGetParentJABElementPropertiesmaxStringLength = null)
        {
            SourceExpression.Validate(jABGetParentJABElementPropertiessearchElementJABHandle, nameof(jABGetParentJABElementPropertiessearchElementJABHandle), required: true);
            SourceExpression.Validate(jABGetParentJABElementPropertiesworkflow, nameof(jABGetParentJABElementPropertiesworkflow), required: true);
            SourceExpression.Validate(jABGetParentJABElementPropertiesmaxStringLength, nameof(jABGetParentJABElementPropertiesmaxStringLength), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetParentJABElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetParentJABElementProperties = new JObject();
                var jABGetParentJABElementPropertiespropCount = 0;
                jABGetParentJABElementPropertiespropCount++;
                jABGetParentJABElementProperties["SearchElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGetParentJABElementPropertiessearchElementJABHandle);
                if (jABGetParentJABElementPropertiesmaxStringLength != null)
                {
                    if (jABGetParentJABElementPropertiesmaxStringLength != null)
                    {
                        jABGetParentJABElementProperties["MaxStringLength"] = SourceExpressionConverter.ConvertToken(jABGetParentJABElementPropertiesmaxStringLength);
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
                jABGetParentJABElementProperties["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetParentJABElementPropertiesworkflow);
                if (jABGetParentJABElementPropertiespropCount > 0)
                {
                    callPayload.Body = jABGetParentJABElementProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetParentJABElementPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABPressElement([WorkflowExpression] Func<int> jABPressElementsearchParentElementJABHandle, [WorkflowExpression] Func<string> jABPressElementworkflow, [WorkflowExpression] Func<string> jABPressElementsearchElementJABName = null, [WorkflowExpression] Func<string> jABPressElementsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABPressElementsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABPressElementsearchSubTree = null, [WorkflowExpression] Func<int> jABPressElementmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABPressElementmatchIndex = null, [WorkflowExpression] Func<string> jABPressElementsearchFilter = null, [WorkflowExpression] Func<string> jABPressElementsortByColumn = null, [WorkflowExpression] Func<bool> jABPressElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABPressElementcaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABPressElementonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABPressElementonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABPressElementelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABPressElementmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABPressElementmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<int> jABPressElementnumberOfTimesToPressElement = null, [WorkflowExpression] Func<double> jABPressElementsecondsToWaitBetweenPresses = null, [WorkflowExpression] Func<bool> jABPressElementautoDetectActionName = null, [WorkflowExpression] Func<string> jABPressElementoverrideActionName = null)
        {
            SourceExpression.Validate(jABPressElementsearchParentElementJABHandle, nameof(jABPressElementsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABPressElementworkflow, nameof(jABPressElementworkflow), required: true);
            SourceExpression.Validate(jABPressElementsearchElementJABName, nameof(jABPressElementsearchElementJABName), required: false);
            SourceExpression.Validate(jABPressElementsearchElementJABDescription, nameof(jABPressElementsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABPressElementsearchElementJABRole, nameof(jABPressElementsearchElementJABRole), required: false);
            SourceExpression.Validate(jABPressElementsearchSubTree, nameof(jABPressElementsearchSubTree), required: false);
            SourceExpression.Validate(jABPressElementmaxRelativeDepth, nameof(jABPressElementmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABPressElementmatchIndex, nameof(jABPressElementmatchIndex), required: false);
            SourceExpression.Validate(jABPressElementsearchFilter, nameof(jABPressElementsearchFilter), required: false);
            SourceExpression.Validate(jABPressElementsortByColumn, nameof(jABPressElementsortByColumn), required: false);
            SourceExpression.Validate(jABPressElementmatchIndexAscending, nameof(jABPressElementmatchIndexAscending), required: false);
            SourceExpression.Validate(jABPressElementcaseSensitiveSearch, nameof(jABPressElementcaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABPressElementonlySearchVisibleElements, nameof(jABPressElementonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABPressElementonlySearchShowingElements, nameof(jABPressElementonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABPressElementelementRolesNotToTraverse, nameof(jABPressElementelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABPressElementmaximumElementsToSearch, nameof(jABPressElementmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABPressElementmaximumChildElementsToSearchPerNode, nameof(jABPressElementmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABPressElementnumberOfTimesToPressElement, nameof(jABPressElementnumberOfTimesToPressElement), required: false);
            SourceExpression.Validate(jABPressElementsecondsToWaitBetweenPresses, nameof(jABPressElementsecondsToWaitBetweenPresses), required: false);
            SourceExpression.Validate(jABPressElementautoDetectActionName, nameof(jABPressElementautoDetectActionName), required: false);
            SourceExpression.Validate(jABPressElementoverrideActionName, nameof(jABPressElementoverrideActionName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABPressElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABPressElement = new JObject();
                var jABPressElementpropCount = 0;
                jABPressElementpropCount++;
                jABPressElement["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABPressElementsearchParentElementJABHandle);
                if (jABPressElementsearchElementJABName != null)
                {
                    jABPressElement["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABPressElementsearchElementJABName);
                    jABPressElementpropCount++;
                }

                if (jABPressElementsearchElementJABDescription != null)
                {
                    jABPressElement["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABPressElementsearchElementJABDescription);
                    jABPressElementpropCount++;
                }

                if (jABPressElementsearchElementJABRole != null)
                {
                    jABPressElement["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABPressElementsearchElementJABRole);
                    jABPressElementpropCount++;
                }

                if (jABPressElementsearchSubTree != null)
                {
                    if (jABPressElementsearchSubTree != null)
                    {
                        jABPressElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABPressElementsearchSubTree);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["SearchSubTree"] = true;
                    jABPressElementpropCount++;
                }

                if (jABPressElementmaxRelativeDepth != null)
                {
                    if (jABPressElementmaxRelativeDepth != null)
                    {
                        jABPressElement["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABPressElementmaxRelativeDepth);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["MaxRelativeDepth"] = 0;
                    jABPressElementpropCount++;
                }

                if (jABPressElementmatchIndex != null)
                {
                    if (jABPressElementmatchIndex != null)
                    {
                        jABPressElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABPressElementmatchIndex);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["MatchIndex"] = 1;
                    jABPressElementpropCount++;
                }

                if (jABPressElementsearchFilter != null)
                {
                    jABPressElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABPressElementsearchFilter);
                    jABPressElementpropCount++;
                }

                if (jABPressElementsortByColumn != null)
                {
                    jABPressElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABPressElementsortByColumn);
                    jABPressElementpropCount++;
                }

                if (jABPressElementmatchIndexAscending != null)
                {
                    if (jABPressElementmatchIndexAscending != null)
                    {
                        jABPressElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABPressElementmatchIndexAscending);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["MatchIndexAscending"] = true;
                    jABPressElementpropCount++;
                }

                if (jABPressElementcaseSensitiveSearch != null)
                {
                    if (jABPressElementcaseSensitiveSearch != null)
                    {
                        jABPressElement["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABPressElementcaseSensitiveSearch);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["CaseSensitiveSearch"] = false;
                    jABPressElementpropCount++;
                }

                if (jABPressElementonlySearchVisibleElements != null)
                {
                    if (jABPressElementonlySearchVisibleElements != null)
                    {
                        jABPressElement["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABPressElementonlySearchVisibleElements);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["OnlySearchVisibleElements"] = true;
                    jABPressElementpropCount++;
                }

                if (jABPressElementonlySearchShowingElements != null)
                {
                    if (jABPressElementonlySearchShowingElements != null)
                    {
                        jABPressElement["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABPressElementonlySearchShowingElements);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["OnlySearchShowingElements"] = true;
                    jABPressElementpropCount++;
                }

                if (jABPressElementelementRolesNotToTraverse != null)
                {
                    jABPressElement["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABPressElementelementRolesNotToTraverse);
                    jABPressElementpropCount++;
                }

                if (jABPressElementmaximumElementsToSearch != null)
                {
                    if (jABPressElementmaximumElementsToSearch != null)
                    {
                        jABPressElement["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABPressElementmaximumElementsToSearch);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["MaximumElementsToSearch"] = 2000;
                    jABPressElementpropCount++;
                }

                if (jABPressElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABPressElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABPressElement["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABPressElementmaximumChildElementsToSearchPerNode);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABPressElementpropCount++;
                }

                if (jABPressElementnumberOfTimesToPressElement != null)
                {
                    if (jABPressElementnumberOfTimesToPressElement != null)
                    {
                        jABPressElement["NumberOfTimesToPressElement"] = SourceExpressionConverter.ConvertToken(jABPressElementnumberOfTimesToPressElement);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["NumberOfTimesToPressElement"] = 1;
                    jABPressElementpropCount++;
                }

                if (jABPressElementsecondsToWaitBetweenPresses != null)
                {
                    if (jABPressElementsecondsToWaitBetweenPresses != null)
                    {
                        jABPressElement["SecondsToWaitBetweenPresses"] = SourceExpressionConverter.ConvertToken(jABPressElementsecondsToWaitBetweenPresses);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["SecondsToWaitBetweenPresses"] = 0;
                    jABPressElementpropCount++;
                }

                if (jABPressElementautoDetectActionName != null)
                {
                    if (jABPressElementautoDetectActionName != null)
                    {
                        jABPressElement["AutoDetectActionName"] = SourceExpressionConverter.ConvertToken(jABPressElementautoDetectActionName);
                        jABPressElementpropCount++;
                    }

                    jABPressElementpropCount++;
                }
                else
                {
                    jABPressElement["AutoDetectActionName"] = true;
                    jABPressElementpropCount++;
                }

                if (jABPressElementoverrideActionName != null)
                {
                    jABPressElement["OverrideActionName"] = SourceExpressionConverter.ConvertToken(jABPressElementoverrideActionName);
                    jABPressElementpropCount++;
                }

                jABPressElementpropCount++;
                jABPressElement["Workflow"] = SourceExpressionConverter.ConvertToken(jABPressElementworkflow);
                if (jABPressElementpropCount > 0)
                {
                    callPayload.Body = jABPressElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABPerformActionOnElement([WorkflowExpression] Func<int> jABPerformActionOnElementsearchParentElementJABHandle, [WorkflowExpression] Func<string> jABPerformActionOnElementaction, [WorkflowExpression] Func<string> jABPerformActionOnElementworkflow, [WorkflowExpression] Func<string> jABPerformActionOnElementsearchElementJABName = null, [WorkflowExpression] Func<string> jABPerformActionOnElementsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABPerformActionOnElementsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABPerformActionOnElementsearchSubTree = null, [WorkflowExpression] Func<int> jABPerformActionOnElementmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABPerformActionOnElementmatchIndex = null, [WorkflowExpression] Func<string> jABPerformActionOnElementsearchFilter = null, [WorkflowExpression] Func<string> jABPerformActionOnElementsortByColumn = null, [WorkflowExpression] Func<bool> jABPerformActionOnElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABPerformActionOnElementcaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABPerformActionOnElementonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABPerformActionOnElementonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABPerformActionOnElementelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABPerformActionOnElementmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABPerformActionOnElementmaximumChildElementsToSearchPerNode = null)
        {
            SourceExpression.Validate(jABPerformActionOnElementsearchParentElementJABHandle, nameof(jABPerformActionOnElementsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABPerformActionOnElementaction, nameof(jABPerformActionOnElementaction), required: true);
            SourceExpression.Validate(jABPerformActionOnElementworkflow, nameof(jABPerformActionOnElementworkflow), required: true);
            SourceExpression.Validate(jABPerformActionOnElementsearchElementJABName, nameof(jABPerformActionOnElementsearchElementJABName), required: false);
            SourceExpression.Validate(jABPerformActionOnElementsearchElementJABDescription, nameof(jABPerformActionOnElementsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABPerformActionOnElementsearchElementJABRole, nameof(jABPerformActionOnElementsearchElementJABRole), required: false);
            SourceExpression.Validate(jABPerformActionOnElementsearchSubTree, nameof(jABPerformActionOnElementsearchSubTree), required: false);
            SourceExpression.Validate(jABPerformActionOnElementmaxRelativeDepth, nameof(jABPerformActionOnElementmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABPerformActionOnElementmatchIndex, nameof(jABPerformActionOnElementmatchIndex), required: false);
            SourceExpression.Validate(jABPerformActionOnElementsearchFilter, nameof(jABPerformActionOnElementsearchFilter), required: false);
            SourceExpression.Validate(jABPerformActionOnElementsortByColumn, nameof(jABPerformActionOnElementsortByColumn), required: false);
            SourceExpression.Validate(jABPerformActionOnElementmatchIndexAscending, nameof(jABPerformActionOnElementmatchIndexAscending), required: false);
            SourceExpression.Validate(jABPerformActionOnElementcaseSensitiveSearch, nameof(jABPerformActionOnElementcaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABPerformActionOnElementonlySearchVisibleElements, nameof(jABPerformActionOnElementonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABPerformActionOnElementonlySearchShowingElements, nameof(jABPerformActionOnElementonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABPerformActionOnElementelementRolesNotToTraverse, nameof(jABPerformActionOnElementelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABPerformActionOnElementmaximumElementsToSearch, nameof(jABPerformActionOnElementmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABPerformActionOnElementmaximumChildElementsToSearchPerNode, nameof(jABPerformActionOnElementmaximumChildElementsToSearchPerNode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABPerformActionOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABPerformActionOnElement = new JObject();
                var jABPerformActionOnElementpropCount = 0;
                jABPerformActionOnElementpropCount++;
                jABPerformActionOnElement["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABPerformActionOnElementsearchParentElementJABHandle);
                if (jABPerformActionOnElementsearchElementJABName != null)
                {
                    jABPerformActionOnElement["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABPerformActionOnElementsearchElementJABName);
                    jABPerformActionOnElementpropCount++;
                }

                if (jABPerformActionOnElementsearchElementJABDescription != null)
                {
                    jABPerformActionOnElement["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABPerformActionOnElementsearchElementJABDescription);
                    jABPerformActionOnElementpropCount++;
                }

                if (jABPerformActionOnElementsearchElementJABRole != null)
                {
                    jABPerformActionOnElement["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABPerformActionOnElementsearchElementJABRole);
                    jABPerformActionOnElementpropCount++;
                }

                if (jABPerformActionOnElementsearchSubTree != null)
                {
                    if (jABPerformActionOnElementsearchSubTree != null)
                    {
                        jABPerformActionOnElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABPerformActionOnElementsearchSubTree);
                        jABPerformActionOnElementpropCount++;
                    }

                    jABPerformActionOnElementpropCount++;
                }
                else
                {
                    jABPerformActionOnElement["SearchSubTree"] = true;
                    jABPerformActionOnElementpropCount++;
                }

                if (jABPerformActionOnElementmaxRelativeDepth != null)
                {
                    if (jABPerformActionOnElementmaxRelativeDepth != null)
                    {
                        jABPerformActionOnElement["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABPerformActionOnElementmaxRelativeDepth);
                        jABPerformActionOnElementpropCount++;
                    }

                    jABPerformActionOnElementpropCount++;
                }
                else
                {
                    jABPerformActionOnElement["MaxRelativeDepth"] = 0;
                    jABPerformActionOnElementpropCount++;
                }

                if (jABPerformActionOnElementmatchIndex != null)
                {
                    if (jABPerformActionOnElementmatchIndex != null)
                    {
                        jABPerformActionOnElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABPerformActionOnElementmatchIndex);
                        jABPerformActionOnElementpropCount++;
                    }

                    jABPerformActionOnElementpropCount++;
                }
                else
                {
                    jABPerformActionOnElement["MatchIndex"] = 1;
                    jABPerformActionOnElementpropCount++;
                }

                if (jABPerformActionOnElementsearchFilter != null)
                {
                    jABPerformActionOnElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABPerformActionOnElementsearchFilter);
                    jABPerformActionOnElementpropCount++;
                }

                if (jABPerformActionOnElementsortByColumn != null)
                {
                    jABPerformActionOnElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABPerformActionOnElementsortByColumn);
                    jABPerformActionOnElementpropCount++;
                }

                if (jABPerformActionOnElementmatchIndexAscending != null)
                {
                    if (jABPerformActionOnElementmatchIndexAscending != null)
                    {
                        jABPerformActionOnElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABPerformActionOnElementmatchIndexAscending);
                        jABPerformActionOnElementpropCount++;
                    }

                    jABPerformActionOnElementpropCount++;
                }
                else
                {
                    jABPerformActionOnElement["MatchIndexAscending"] = true;
                    jABPerformActionOnElementpropCount++;
                }

                if (jABPerformActionOnElementcaseSensitiveSearch != null)
                {
                    if (jABPerformActionOnElementcaseSensitiveSearch != null)
                    {
                        jABPerformActionOnElement["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABPerformActionOnElementcaseSensitiveSearch);
                        jABPerformActionOnElementpropCount++;
                    }

                    jABPerformActionOnElementpropCount++;
                }
                else
                {
                    jABPerformActionOnElement["CaseSensitiveSearch"] = false;
                    jABPerformActionOnElementpropCount++;
                }

                if (jABPerformActionOnElementonlySearchVisibleElements != null)
                {
                    if (jABPerformActionOnElementonlySearchVisibleElements != null)
                    {
                        jABPerformActionOnElement["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABPerformActionOnElementonlySearchVisibleElements);
                        jABPerformActionOnElementpropCount++;
                    }

                    jABPerformActionOnElementpropCount++;
                }
                else
                {
                    jABPerformActionOnElement["OnlySearchVisibleElements"] = true;
                    jABPerformActionOnElementpropCount++;
                }

                if (jABPerformActionOnElementonlySearchShowingElements != null)
                {
                    if (jABPerformActionOnElementonlySearchShowingElements != null)
                    {
                        jABPerformActionOnElement["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABPerformActionOnElementonlySearchShowingElements);
                        jABPerformActionOnElementpropCount++;
                    }

                    jABPerformActionOnElementpropCount++;
                }
                else
                {
                    jABPerformActionOnElement["OnlySearchShowingElements"] = true;
                    jABPerformActionOnElementpropCount++;
                }

                if (jABPerformActionOnElementelementRolesNotToTraverse != null)
                {
                    jABPerformActionOnElement["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABPerformActionOnElementelementRolesNotToTraverse);
                    jABPerformActionOnElementpropCount++;
                }

                if (jABPerformActionOnElementmaximumElementsToSearch != null)
                {
                    if (jABPerformActionOnElementmaximumElementsToSearch != null)
                    {
                        jABPerformActionOnElement["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABPerformActionOnElementmaximumElementsToSearch);
                        jABPerformActionOnElementpropCount++;
                    }

                    jABPerformActionOnElementpropCount++;
                }
                else
                {
                    jABPerformActionOnElement["MaximumElementsToSearch"] = 2000;
                    jABPerformActionOnElementpropCount++;
                }

                if (jABPerformActionOnElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABPerformActionOnElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABPerformActionOnElement["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABPerformActionOnElementmaximumChildElementsToSearchPerNode);
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
                jABPerformActionOnElement["Action"] = SourceExpressionConverter.ConvertToken(jABPerformActionOnElementaction);
                jABPerformActionOnElementpropCount++;
                jABPerformActionOnElement["Workflow"] = SourceExpressionConverter.ConvertToken(jABPerformActionOnElementworkflow);
                if (jABPerformActionOnElementpropCount > 0)
                {
                    callPayload.Body = jABPerformActionOnElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalLeftMouseClickOnElement([WorkflowExpression] Func<int> jABGlobalLeftMouseClickOnElementsearchParentElementJABHandle, [WorkflowExpression] Func<string> jABGlobalLeftMouseClickOnElementworkflow, [WorkflowExpression] Func<string> jABGlobalLeftMouseClickOnElementsearchElementJABName = null, [WorkflowExpression] Func<string> jABGlobalLeftMouseClickOnElementsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABGlobalLeftMouseClickOnElementsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABGlobalLeftMouseClickOnElementsearchSubTree = null, [WorkflowExpression] Func<int> jABGlobalLeftMouseClickOnElementmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABGlobalLeftMouseClickOnElementmatchIndex = null, [WorkflowExpression] Func<string> jABGlobalLeftMouseClickOnElementsearchFilter = null, [WorkflowExpression] Func<string> jABGlobalLeftMouseClickOnElementsortByColumn = null, [WorkflowExpression] Func<bool> jABGlobalLeftMouseClickOnElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABGlobalLeftMouseClickOnElementcaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABGlobalLeftMouseClickOnElementonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABGlobalLeftMouseClickOnElementonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABGlobalLeftMouseClickOnElementelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABGlobalLeftMouseClickOnElementmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABGlobalLeftMouseClickOnElementmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<int> jABGlobalLeftMouseClickOnElementclickOffsetX = null, [WorkflowExpression] Func<int> jABGlobalLeftMouseClickOnElementclickOffsetY = null, [WorkflowExpression] Func<jABGlobalLeftMouseClickOnElementoffsetRelativeToInput> jABGlobalLeftMouseClickOnElementoffsetRelativeTo = null, [WorkflowExpression] Func<int> jABGlobalLeftMouseClickOnElementnumberOfTimesToClickElement = null, [WorkflowExpression] Func<double> jABGlobalLeftMouseClickOnElementsecondsToWaitBetweenClicks = null)
        {
            SourceExpression.Validate(jABGlobalLeftMouseClickOnElementsearchParentElementJABHandle, nameof(jABGlobalLeftMouseClickOnElementsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABGlobalLeftMouseClickOnElementworkflow, nameof(jABGlobalLeftMouseClickOnElementworkflow), required: true);
            SourceExpression.Validate(jABGlobalLeftMouseClickOnElementsearchElementJABName, nameof(jABGlobalLeftMouseClickOnElementsearchElementJABName), required: false);
            SourceExpression.Validate(jABGlobalLeftMouseClickOnElementsearchElementJABDescription, nameof(jABGlobalLeftMouseClickOnElementsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABGlobalLeftMouseClickOnElementsearchElementJABRole, nameof(jABGlobalLeftMouseClickOnElementsearchElementJABRole), required: false);
            SourceExpression.Validate(jABGlobalLeftMouseClickOnElementsearchSubTree, nameof(jABGlobalLeftMouseClickOnElementsearchSubTree), required: false);
            SourceExpression.Validate(jABGlobalLeftMouseClickOnElementmaxRelativeDepth, nameof(jABGlobalLeftMouseClickOnElementmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABGlobalLeftMouseClickOnElementmatchIndex, nameof(jABGlobalLeftMouseClickOnElementmatchIndex), required: false);
            SourceExpression.Validate(jABGlobalLeftMouseClickOnElementsearchFilter, nameof(jABGlobalLeftMouseClickOnElementsearchFilter), required: false);
            SourceExpression.Validate(jABGlobalLeftMouseClickOnElementsortByColumn, nameof(jABGlobalLeftMouseClickOnElementsortByColumn), required: false);
            SourceExpression.Validate(jABGlobalLeftMouseClickOnElementmatchIndexAscending, nameof(jABGlobalLeftMouseClickOnElementmatchIndexAscending), required: false);
            SourceExpression.Validate(jABGlobalLeftMouseClickOnElementcaseSensitiveSearch, nameof(jABGlobalLeftMouseClickOnElementcaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABGlobalLeftMouseClickOnElementonlySearchVisibleElements, nameof(jABGlobalLeftMouseClickOnElementonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABGlobalLeftMouseClickOnElementonlySearchShowingElements, nameof(jABGlobalLeftMouseClickOnElementonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABGlobalLeftMouseClickOnElementelementRolesNotToTraverse, nameof(jABGlobalLeftMouseClickOnElementelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABGlobalLeftMouseClickOnElementmaximumElementsToSearch, nameof(jABGlobalLeftMouseClickOnElementmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABGlobalLeftMouseClickOnElementmaximumChildElementsToSearchPerNode, nameof(jABGlobalLeftMouseClickOnElementmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABGlobalLeftMouseClickOnElementclickOffsetX, nameof(jABGlobalLeftMouseClickOnElementclickOffsetX), required: false);
            SourceExpression.Validate(jABGlobalLeftMouseClickOnElementclickOffsetY, nameof(jABGlobalLeftMouseClickOnElementclickOffsetY), required: false);
            SourceExpression.Validate(jABGlobalLeftMouseClickOnElementoffsetRelativeTo, nameof(jABGlobalLeftMouseClickOnElementoffsetRelativeTo), required: false);
            SourceExpression.Validate(jABGlobalLeftMouseClickOnElementnumberOfTimesToClickElement, nameof(jABGlobalLeftMouseClickOnElementnumberOfTimesToClickElement), required: false);
            SourceExpression.Validate(jABGlobalLeftMouseClickOnElementsecondsToWaitBetweenClicks, nameof(jABGlobalLeftMouseClickOnElementsecondsToWaitBetweenClicks), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalLeftMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGlobalLeftMouseClickOnElement = new JObject();
                var jABGlobalLeftMouseClickOnElementpropCount = 0;
                jABGlobalLeftMouseClickOnElementpropCount++;
                jABGlobalLeftMouseClickOnElement["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGlobalLeftMouseClickOnElementsearchParentElementJABHandle);
                if (jABGlobalLeftMouseClickOnElementsearchElementJABName != null)
                {
                    jABGlobalLeftMouseClickOnElement["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABGlobalLeftMouseClickOnElementsearchElementJABName);
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalLeftMouseClickOnElementsearchElementJABDescription != null)
                {
                    jABGlobalLeftMouseClickOnElement["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABGlobalLeftMouseClickOnElementsearchElementJABDescription);
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalLeftMouseClickOnElementsearchElementJABRole != null)
                {
                    jABGlobalLeftMouseClickOnElement["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABGlobalLeftMouseClickOnElementsearchElementJABRole);
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalLeftMouseClickOnElementsearchSubTree != null)
                {
                    if (jABGlobalLeftMouseClickOnElementsearchSubTree != null)
                    {
                        jABGlobalLeftMouseClickOnElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABGlobalLeftMouseClickOnElementsearchSubTree);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["SearchSubTree"] = true;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalLeftMouseClickOnElementmaxRelativeDepth != null)
                {
                    if (jABGlobalLeftMouseClickOnElementmaxRelativeDepth != null)
                    {
                        jABGlobalLeftMouseClickOnElement["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABGlobalLeftMouseClickOnElementmaxRelativeDepth);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["MaxRelativeDepth"] = 0;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalLeftMouseClickOnElementmatchIndex != null)
                {
                    if (jABGlobalLeftMouseClickOnElementmatchIndex != null)
                    {
                        jABGlobalLeftMouseClickOnElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABGlobalLeftMouseClickOnElementmatchIndex);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["MatchIndex"] = 1;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalLeftMouseClickOnElementsearchFilter != null)
                {
                    jABGlobalLeftMouseClickOnElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABGlobalLeftMouseClickOnElementsearchFilter);
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalLeftMouseClickOnElementsortByColumn != null)
                {
                    jABGlobalLeftMouseClickOnElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABGlobalLeftMouseClickOnElementsortByColumn);
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalLeftMouseClickOnElementmatchIndexAscending != null)
                {
                    if (jABGlobalLeftMouseClickOnElementmatchIndexAscending != null)
                    {
                        jABGlobalLeftMouseClickOnElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABGlobalLeftMouseClickOnElementmatchIndexAscending);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["MatchIndexAscending"] = true;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalLeftMouseClickOnElementcaseSensitiveSearch != null)
                {
                    if (jABGlobalLeftMouseClickOnElementcaseSensitiveSearch != null)
                    {
                        jABGlobalLeftMouseClickOnElement["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABGlobalLeftMouseClickOnElementcaseSensitiveSearch);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["CaseSensitiveSearch"] = false;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalLeftMouseClickOnElementonlySearchVisibleElements != null)
                {
                    if (jABGlobalLeftMouseClickOnElementonlySearchVisibleElements != null)
                    {
                        jABGlobalLeftMouseClickOnElement["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABGlobalLeftMouseClickOnElementonlySearchVisibleElements);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["OnlySearchVisibleElements"] = true;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalLeftMouseClickOnElementonlySearchShowingElements != null)
                {
                    if (jABGlobalLeftMouseClickOnElementonlySearchShowingElements != null)
                    {
                        jABGlobalLeftMouseClickOnElement["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABGlobalLeftMouseClickOnElementonlySearchShowingElements);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["OnlySearchShowingElements"] = true;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalLeftMouseClickOnElementelementRolesNotToTraverse != null)
                {
                    jABGlobalLeftMouseClickOnElement["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABGlobalLeftMouseClickOnElementelementRolesNotToTraverse);
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalLeftMouseClickOnElementmaximumElementsToSearch != null)
                {
                    if (jABGlobalLeftMouseClickOnElementmaximumElementsToSearch != null)
                    {
                        jABGlobalLeftMouseClickOnElement["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABGlobalLeftMouseClickOnElementmaximumElementsToSearch);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["MaximumElementsToSearch"] = 2000;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalLeftMouseClickOnElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABGlobalLeftMouseClickOnElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGlobalLeftMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABGlobalLeftMouseClickOnElementmaximumChildElementsToSearchPerNode);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalLeftMouseClickOnElementclickOffsetX != null)
                {
                    if (jABGlobalLeftMouseClickOnElementclickOffsetX != null)
                    {
                        jABGlobalLeftMouseClickOnElement["ClickOffsetX"] = SourceExpressionConverter.ConvertToken(jABGlobalLeftMouseClickOnElementclickOffsetX);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["ClickOffsetX"] = 0;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalLeftMouseClickOnElementclickOffsetY != null)
                {
                    if (jABGlobalLeftMouseClickOnElementclickOffsetY != null)
                    {
                        jABGlobalLeftMouseClickOnElement["ClickOffsetY"] = SourceExpressionConverter.ConvertToken(jABGlobalLeftMouseClickOnElementclickOffsetY);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["ClickOffsetY"] = 0;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalLeftMouseClickOnElementoffsetRelativeTo != null)
                {
                    jABGlobalLeftMouseClickOnElement["OffsetRelativeTo"] = SourceExpressionConverter.Convert(jABGlobalLeftMouseClickOnElementoffsetRelativeTo);
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalLeftMouseClickOnElementnumberOfTimesToClickElement != null)
                {
                    if (jABGlobalLeftMouseClickOnElementnumberOfTimesToClickElement != null)
                    {
                        jABGlobalLeftMouseClickOnElement["NumberOfTimesToClickElement"] = SourceExpressionConverter.ConvertToken(jABGlobalLeftMouseClickOnElementnumberOfTimesToClickElement);
                        jABGlobalLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalLeftMouseClickOnElement["NumberOfTimesToClickElement"] = 1;
                    jABGlobalLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalLeftMouseClickOnElementsecondsToWaitBetweenClicks != null)
                {
                    if (jABGlobalLeftMouseClickOnElementsecondsToWaitBetweenClicks != null)
                    {
                        jABGlobalLeftMouseClickOnElement["SecondsToWaitBetweenClicks"] = SourceExpressionConverter.ConvertToken(jABGlobalLeftMouseClickOnElementsecondsToWaitBetweenClicks);
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
                jABGlobalLeftMouseClickOnElement["Workflow"] = SourceExpressionConverter.ConvertToken(jABGlobalLeftMouseClickOnElementworkflow);
                if (jABGlobalLeftMouseClickOnElementpropCount > 0)
                {
                    callPayload.Body = jABGlobalLeftMouseClickOnElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalRightMouseClickOnElement([WorkflowExpression] Func<int> jABGlobalRightMouseClickOnElementsearchParentElementJABHandle, [WorkflowExpression] Func<string> jABGlobalRightMouseClickOnElementworkflow, [WorkflowExpression] Func<string> jABGlobalRightMouseClickOnElementsearchElementJABName = null, [WorkflowExpression] Func<string> jABGlobalRightMouseClickOnElementsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABGlobalRightMouseClickOnElementsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABGlobalRightMouseClickOnElementsearchSubTree = null, [WorkflowExpression] Func<int> jABGlobalRightMouseClickOnElementmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABGlobalRightMouseClickOnElementmatchIndex = null, [WorkflowExpression] Func<string> jABGlobalRightMouseClickOnElementsearchFilter = null, [WorkflowExpression] Func<string> jABGlobalRightMouseClickOnElementsortByColumn = null, [WorkflowExpression] Func<bool> jABGlobalRightMouseClickOnElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABGlobalRightMouseClickOnElementcaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABGlobalRightMouseClickOnElementonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABGlobalRightMouseClickOnElementonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABGlobalRightMouseClickOnElementelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABGlobalRightMouseClickOnElementmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABGlobalRightMouseClickOnElementmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<int> jABGlobalRightMouseClickOnElementclickOffsetX = null, [WorkflowExpression] Func<int> jABGlobalRightMouseClickOnElementclickOffsetY = null, [WorkflowExpression] Func<jABGlobalRightMouseClickOnElementoffsetRelativeToInput> jABGlobalRightMouseClickOnElementoffsetRelativeTo = null)
        {
            SourceExpression.Validate(jABGlobalRightMouseClickOnElementsearchParentElementJABHandle, nameof(jABGlobalRightMouseClickOnElementsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABGlobalRightMouseClickOnElementworkflow, nameof(jABGlobalRightMouseClickOnElementworkflow), required: true);
            SourceExpression.Validate(jABGlobalRightMouseClickOnElementsearchElementJABName, nameof(jABGlobalRightMouseClickOnElementsearchElementJABName), required: false);
            SourceExpression.Validate(jABGlobalRightMouseClickOnElementsearchElementJABDescription, nameof(jABGlobalRightMouseClickOnElementsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABGlobalRightMouseClickOnElementsearchElementJABRole, nameof(jABGlobalRightMouseClickOnElementsearchElementJABRole), required: false);
            SourceExpression.Validate(jABGlobalRightMouseClickOnElementsearchSubTree, nameof(jABGlobalRightMouseClickOnElementsearchSubTree), required: false);
            SourceExpression.Validate(jABGlobalRightMouseClickOnElementmaxRelativeDepth, nameof(jABGlobalRightMouseClickOnElementmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABGlobalRightMouseClickOnElementmatchIndex, nameof(jABGlobalRightMouseClickOnElementmatchIndex), required: false);
            SourceExpression.Validate(jABGlobalRightMouseClickOnElementsearchFilter, nameof(jABGlobalRightMouseClickOnElementsearchFilter), required: false);
            SourceExpression.Validate(jABGlobalRightMouseClickOnElementsortByColumn, nameof(jABGlobalRightMouseClickOnElementsortByColumn), required: false);
            SourceExpression.Validate(jABGlobalRightMouseClickOnElementmatchIndexAscending, nameof(jABGlobalRightMouseClickOnElementmatchIndexAscending), required: false);
            SourceExpression.Validate(jABGlobalRightMouseClickOnElementcaseSensitiveSearch, nameof(jABGlobalRightMouseClickOnElementcaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABGlobalRightMouseClickOnElementonlySearchVisibleElements, nameof(jABGlobalRightMouseClickOnElementonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABGlobalRightMouseClickOnElementonlySearchShowingElements, nameof(jABGlobalRightMouseClickOnElementonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABGlobalRightMouseClickOnElementelementRolesNotToTraverse, nameof(jABGlobalRightMouseClickOnElementelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABGlobalRightMouseClickOnElementmaximumElementsToSearch, nameof(jABGlobalRightMouseClickOnElementmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABGlobalRightMouseClickOnElementmaximumChildElementsToSearchPerNode, nameof(jABGlobalRightMouseClickOnElementmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABGlobalRightMouseClickOnElementclickOffsetX, nameof(jABGlobalRightMouseClickOnElementclickOffsetX), required: false);
            SourceExpression.Validate(jABGlobalRightMouseClickOnElementclickOffsetY, nameof(jABGlobalRightMouseClickOnElementclickOffsetY), required: false);
            SourceExpression.Validate(jABGlobalRightMouseClickOnElementoffsetRelativeTo, nameof(jABGlobalRightMouseClickOnElementoffsetRelativeTo), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalRightMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGlobalRightMouseClickOnElement = new JObject();
                var jABGlobalRightMouseClickOnElementpropCount = 0;
                jABGlobalRightMouseClickOnElementpropCount++;
                jABGlobalRightMouseClickOnElement["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGlobalRightMouseClickOnElementsearchParentElementJABHandle);
                if (jABGlobalRightMouseClickOnElementsearchElementJABName != null)
                {
                    jABGlobalRightMouseClickOnElement["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABGlobalRightMouseClickOnElementsearchElementJABName);
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (jABGlobalRightMouseClickOnElementsearchElementJABDescription != null)
                {
                    jABGlobalRightMouseClickOnElement["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABGlobalRightMouseClickOnElementsearchElementJABDescription);
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (jABGlobalRightMouseClickOnElementsearchElementJABRole != null)
                {
                    jABGlobalRightMouseClickOnElement["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABGlobalRightMouseClickOnElementsearchElementJABRole);
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (jABGlobalRightMouseClickOnElementsearchSubTree != null)
                {
                    if (jABGlobalRightMouseClickOnElementsearchSubTree != null)
                    {
                        jABGlobalRightMouseClickOnElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABGlobalRightMouseClickOnElementsearchSubTree);
                        jABGlobalRightMouseClickOnElementpropCount++;
                    }

                    jABGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalRightMouseClickOnElement["SearchSubTree"] = true;
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (jABGlobalRightMouseClickOnElementmaxRelativeDepth != null)
                {
                    if (jABGlobalRightMouseClickOnElementmaxRelativeDepth != null)
                    {
                        jABGlobalRightMouseClickOnElement["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABGlobalRightMouseClickOnElementmaxRelativeDepth);
                        jABGlobalRightMouseClickOnElementpropCount++;
                    }

                    jABGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalRightMouseClickOnElement["MaxRelativeDepth"] = 0;
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (jABGlobalRightMouseClickOnElementmatchIndex != null)
                {
                    if (jABGlobalRightMouseClickOnElementmatchIndex != null)
                    {
                        jABGlobalRightMouseClickOnElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABGlobalRightMouseClickOnElementmatchIndex);
                        jABGlobalRightMouseClickOnElementpropCount++;
                    }

                    jABGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalRightMouseClickOnElement["MatchIndex"] = 1;
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (jABGlobalRightMouseClickOnElementsearchFilter != null)
                {
                    jABGlobalRightMouseClickOnElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABGlobalRightMouseClickOnElementsearchFilter);
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (jABGlobalRightMouseClickOnElementsortByColumn != null)
                {
                    jABGlobalRightMouseClickOnElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABGlobalRightMouseClickOnElementsortByColumn);
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (jABGlobalRightMouseClickOnElementmatchIndexAscending != null)
                {
                    if (jABGlobalRightMouseClickOnElementmatchIndexAscending != null)
                    {
                        jABGlobalRightMouseClickOnElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABGlobalRightMouseClickOnElementmatchIndexAscending);
                        jABGlobalRightMouseClickOnElementpropCount++;
                    }

                    jABGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalRightMouseClickOnElement["MatchIndexAscending"] = true;
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (jABGlobalRightMouseClickOnElementcaseSensitiveSearch != null)
                {
                    if (jABGlobalRightMouseClickOnElementcaseSensitiveSearch != null)
                    {
                        jABGlobalRightMouseClickOnElement["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABGlobalRightMouseClickOnElementcaseSensitiveSearch);
                        jABGlobalRightMouseClickOnElementpropCount++;
                    }

                    jABGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalRightMouseClickOnElement["CaseSensitiveSearch"] = false;
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (jABGlobalRightMouseClickOnElementonlySearchVisibleElements != null)
                {
                    if (jABGlobalRightMouseClickOnElementonlySearchVisibleElements != null)
                    {
                        jABGlobalRightMouseClickOnElement["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABGlobalRightMouseClickOnElementonlySearchVisibleElements);
                        jABGlobalRightMouseClickOnElementpropCount++;
                    }

                    jABGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalRightMouseClickOnElement["OnlySearchVisibleElements"] = true;
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (jABGlobalRightMouseClickOnElementonlySearchShowingElements != null)
                {
                    if (jABGlobalRightMouseClickOnElementonlySearchShowingElements != null)
                    {
                        jABGlobalRightMouseClickOnElement["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABGlobalRightMouseClickOnElementonlySearchShowingElements);
                        jABGlobalRightMouseClickOnElementpropCount++;
                    }

                    jABGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalRightMouseClickOnElement["OnlySearchShowingElements"] = true;
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (jABGlobalRightMouseClickOnElementelementRolesNotToTraverse != null)
                {
                    jABGlobalRightMouseClickOnElement["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABGlobalRightMouseClickOnElementelementRolesNotToTraverse);
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (jABGlobalRightMouseClickOnElementmaximumElementsToSearch != null)
                {
                    if (jABGlobalRightMouseClickOnElementmaximumElementsToSearch != null)
                    {
                        jABGlobalRightMouseClickOnElement["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABGlobalRightMouseClickOnElementmaximumElementsToSearch);
                        jABGlobalRightMouseClickOnElementpropCount++;
                    }

                    jABGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalRightMouseClickOnElement["MaximumElementsToSearch"] = 2000;
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (jABGlobalRightMouseClickOnElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABGlobalRightMouseClickOnElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGlobalRightMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABGlobalRightMouseClickOnElementmaximumChildElementsToSearchPerNode);
                        jABGlobalRightMouseClickOnElementpropCount++;
                    }

                    jABGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalRightMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (jABGlobalRightMouseClickOnElementclickOffsetX != null)
                {
                    if (jABGlobalRightMouseClickOnElementclickOffsetX != null)
                    {
                        jABGlobalRightMouseClickOnElement["ClickOffsetX"] = SourceExpressionConverter.ConvertToken(jABGlobalRightMouseClickOnElementclickOffsetX);
                        jABGlobalRightMouseClickOnElementpropCount++;
                    }

                    jABGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalRightMouseClickOnElement["ClickOffsetX"] = 0;
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (jABGlobalRightMouseClickOnElementclickOffsetY != null)
                {
                    if (jABGlobalRightMouseClickOnElementclickOffsetY != null)
                    {
                        jABGlobalRightMouseClickOnElement["ClickOffsetY"] = SourceExpressionConverter.ConvertToken(jABGlobalRightMouseClickOnElementclickOffsetY);
                        jABGlobalRightMouseClickOnElementpropCount++;
                    }

                    jABGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalRightMouseClickOnElement["ClickOffsetY"] = 0;
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                if (jABGlobalRightMouseClickOnElementoffsetRelativeTo != null)
                {
                    jABGlobalRightMouseClickOnElement["OffsetRelativeTo"] = SourceExpressionConverter.Convert(jABGlobalRightMouseClickOnElementoffsetRelativeTo);
                    jABGlobalRightMouseClickOnElementpropCount++;
                }

                jABGlobalRightMouseClickOnElementpropCount++;
                jABGlobalRightMouseClickOnElement["Workflow"] = SourceExpressionConverter.ConvertToken(jABGlobalRightMouseClickOnElementworkflow);
                if (jABGlobalRightMouseClickOnElementpropCount > 0)
                {
                    callPayload.Body = jABGlobalRightMouseClickOnElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalMiddleMouseClickOnElement([WorkflowExpression] Func<int> jABGlobalMiddleMouseClickOnElementsearchParentElementJABHandle, [WorkflowExpression] Func<string> jABGlobalMiddleMouseClickOnElementworkflow, [WorkflowExpression] Func<string> jABGlobalMiddleMouseClickOnElementsearchElementJABName = null, [WorkflowExpression] Func<string> jABGlobalMiddleMouseClickOnElementsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABGlobalMiddleMouseClickOnElementsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABGlobalMiddleMouseClickOnElementsearchSubTree = null, [WorkflowExpression] Func<int> jABGlobalMiddleMouseClickOnElementmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABGlobalMiddleMouseClickOnElementmatchIndex = null, [WorkflowExpression] Func<string> jABGlobalMiddleMouseClickOnElementsearchFilter = null, [WorkflowExpression] Func<string> jABGlobalMiddleMouseClickOnElementsortByColumn = null, [WorkflowExpression] Func<bool> jABGlobalMiddleMouseClickOnElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABGlobalMiddleMouseClickOnElementcaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABGlobalMiddleMouseClickOnElementonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABGlobalMiddleMouseClickOnElementonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABGlobalMiddleMouseClickOnElementelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABGlobalMiddleMouseClickOnElementmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABGlobalMiddleMouseClickOnElementmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<int> jABGlobalMiddleMouseClickOnElementclickOffsetX = null, [WorkflowExpression] Func<int> jABGlobalMiddleMouseClickOnElementclickOffsetY = null, [WorkflowExpression] Func<jABGlobalMiddleMouseClickOnElementoffsetRelativeToInput> jABGlobalMiddleMouseClickOnElementoffsetRelativeTo = null)
        {
            SourceExpression.Validate(jABGlobalMiddleMouseClickOnElementsearchParentElementJABHandle, nameof(jABGlobalMiddleMouseClickOnElementsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABGlobalMiddleMouseClickOnElementworkflow, nameof(jABGlobalMiddleMouseClickOnElementworkflow), required: true);
            SourceExpression.Validate(jABGlobalMiddleMouseClickOnElementsearchElementJABName, nameof(jABGlobalMiddleMouseClickOnElementsearchElementJABName), required: false);
            SourceExpression.Validate(jABGlobalMiddleMouseClickOnElementsearchElementJABDescription, nameof(jABGlobalMiddleMouseClickOnElementsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABGlobalMiddleMouseClickOnElementsearchElementJABRole, nameof(jABGlobalMiddleMouseClickOnElementsearchElementJABRole), required: false);
            SourceExpression.Validate(jABGlobalMiddleMouseClickOnElementsearchSubTree, nameof(jABGlobalMiddleMouseClickOnElementsearchSubTree), required: false);
            SourceExpression.Validate(jABGlobalMiddleMouseClickOnElementmaxRelativeDepth, nameof(jABGlobalMiddleMouseClickOnElementmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABGlobalMiddleMouseClickOnElementmatchIndex, nameof(jABGlobalMiddleMouseClickOnElementmatchIndex), required: false);
            SourceExpression.Validate(jABGlobalMiddleMouseClickOnElementsearchFilter, nameof(jABGlobalMiddleMouseClickOnElementsearchFilter), required: false);
            SourceExpression.Validate(jABGlobalMiddleMouseClickOnElementsortByColumn, nameof(jABGlobalMiddleMouseClickOnElementsortByColumn), required: false);
            SourceExpression.Validate(jABGlobalMiddleMouseClickOnElementmatchIndexAscending, nameof(jABGlobalMiddleMouseClickOnElementmatchIndexAscending), required: false);
            SourceExpression.Validate(jABGlobalMiddleMouseClickOnElementcaseSensitiveSearch, nameof(jABGlobalMiddleMouseClickOnElementcaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABGlobalMiddleMouseClickOnElementonlySearchVisibleElements, nameof(jABGlobalMiddleMouseClickOnElementonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABGlobalMiddleMouseClickOnElementonlySearchShowingElements, nameof(jABGlobalMiddleMouseClickOnElementonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABGlobalMiddleMouseClickOnElementelementRolesNotToTraverse, nameof(jABGlobalMiddleMouseClickOnElementelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABGlobalMiddleMouseClickOnElementmaximumElementsToSearch, nameof(jABGlobalMiddleMouseClickOnElementmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABGlobalMiddleMouseClickOnElementmaximumChildElementsToSearchPerNode, nameof(jABGlobalMiddleMouseClickOnElementmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABGlobalMiddleMouseClickOnElementclickOffsetX, nameof(jABGlobalMiddleMouseClickOnElementclickOffsetX), required: false);
            SourceExpression.Validate(jABGlobalMiddleMouseClickOnElementclickOffsetY, nameof(jABGlobalMiddleMouseClickOnElementclickOffsetY), required: false);
            SourceExpression.Validate(jABGlobalMiddleMouseClickOnElementoffsetRelativeTo, nameof(jABGlobalMiddleMouseClickOnElementoffsetRelativeTo), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalMiddleMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGlobalMiddleMouseClickOnElement = new JObject();
                var jABGlobalMiddleMouseClickOnElementpropCount = 0;
                jABGlobalMiddleMouseClickOnElementpropCount++;
                jABGlobalMiddleMouseClickOnElement["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGlobalMiddleMouseClickOnElementsearchParentElementJABHandle);
                if (jABGlobalMiddleMouseClickOnElementsearchElementJABName != null)
                {
                    jABGlobalMiddleMouseClickOnElement["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABGlobalMiddleMouseClickOnElementsearchElementJABName);
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (jABGlobalMiddleMouseClickOnElementsearchElementJABDescription != null)
                {
                    jABGlobalMiddleMouseClickOnElement["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABGlobalMiddleMouseClickOnElementsearchElementJABDescription);
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (jABGlobalMiddleMouseClickOnElementsearchElementJABRole != null)
                {
                    jABGlobalMiddleMouseClickOnElement["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABGlobalMiddleMouseClickOnElementsearchElementJABRole);
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (jABGlobalMiddleMouseClickOnElementsearchSubTree != null)
                {
                    if (jABGlobalMiddleMouseClickOnElementsearchSubTree != null)
                    {
                        jABGlobalMiddleMouseClickOnElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABGlobalMiddleMouseClickOnElementsearchSubTree);
                        jABGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalMiddleMouseClickOnElement["SearchSubTree"] = true;
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (jABGlobalMiddleMouseClickOnElementmaxRelativeDepth != null)
                {
                    if (jABGlobalMiddleMouseClickOnElementmaxRelativeDepth != null)
                    {
                        jABGlobalMiddleMouseClickOnElement["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABGlobalMiddleMouseClickOnElementmaxRelativeDepth);
                        jABGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalMiddleMouseClickOnElement["MaxRelativeDepth"] = 0;
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (jABGlobalMiddleMouseClickOnElementmatchIndex != null)
                {
                    if (jABGlobalMiddleMouseClickOnElementmatchIndex != null)
                    {
                        jABGlobalMiddleMouseClickOnElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABGlobalMiddleMouseClickOnElementmatchIndex);
                        jABGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalMiddleMouseClickOnElement["MatchIndex"] = 1;
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (jABGlobalMiddleMouseClickOnElementsearchFilter != null)
                {
                    jABGlobalMiddleMouseClickOnElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABGlobalMiddleMouseClickOnElementsearchFilter);
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (jABGlobalMiddleMouseClickOnElementsortByColumn != null)
                {
                    jABGlobalMiddleMouseClickOnElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABGlobalMiddleMouseClickOnElementsortByColumn);
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (jABGlobalMiddleMouseClickOnElementmatchIndexAscending != null)
                {
                    if (jABGlobalMiddleMouseClickOnElementmatchIndexAscending != null)
                    {
                        jABGlobalMiddleMouseClickOnElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABGlobalMiddleMouseClickOnElementmatchIndexAscending);
                        jABGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalMiddleMouseClickOnElement["MatchIndexAscending"] = true;
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (jABGlobalMiddleMouseClickOnElementcaseSensitiveSearch != null)
                {
                    if (jABGlobalMiddleMouseClickOnElementcaseSensitiveSearch != null)
                    {
                        jABGlobalMiddleMouseClickOnElement["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABGlobalMiddleMouseClickOnElementcaseSensitiveSearch);
                        jABGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalMiddleMouseClickOnElement["CaseSensitiveSearch"] = false;
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (jABGlobalMiddleMouseClickOnElementonlySearchVisibleElements != null)
                {
                    if (jABGlobalMiddleMouseClickOnElementonlySearchVisibleElements != null)
                    {
                        jABGlobalMiddleMouseClickOnElement["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABGlobalMiddleMouseClickOnElementonlySearchVisibleElements);
                        jABGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalMiddleMouseClickOnElement["OnlySearchVisibleElements"] = true;
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (jABGlobalMiddleMouseClickOnElementonlySearchShowingElements != null)
                {
                    if (jABGlobalMiddleMouseClickOnElementonlySearchShowingElements != null)
                    {
                        jABGlobalMiddleMouseClickOnElement["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABGlobalMiddleMouseClickOnElementonlySearchShowingElements);
                        jABGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalMiddleMouseClickOnElement["OnlySearchShowingElements"] = true;
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (jABGlobalMiddleMouseClickOnElementelementRolesNotToTraverse != null)
                {
                    jABGlobalMiddleMouseClickOnElement["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABGlobalMiddleMouseClickOnElementelementRolesNotToTraverse);
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (jABGlobalMiddleMouseClickOnElementmaximumElementsToSearch != null)
                {
                    if (jABGlobalMiddleMouseClickOnElementmaximumElementsToSearch != null)
                    {
                        jABGlobalMiddleMouseClickOnElement["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABGlobalMiddleMouseClickOnElementmaximumElementsToSearch);
                        jABGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalMiddleMouseClickOnElement["MaximumElementsToSearch"] = 2000;
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (jABGlobalMiddleMouseClickOnElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABGlobalMiddleMouseClickOnElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGlobalMiddleMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABGlobalMiddleMouseClickOnElementmaximumChildElementsToSearchPerNode);
                        jABGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalMiddleMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (jABGlobalMiddleMouseClickOnElementclickOffsetX != null)
                {
                    if (jABGlobalMiddleMouseClickOnElementclickOffsetX != null)
                    {
                        jABGlobalMiddleMouseClickOnElement["ClickOffsetX"] = SourceExpressionConverter.ConvertToken(jABGlobalMiddleMouseClickOnElementclickOffsetX);
                        jABGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalMiddleMouseClickOnElement["ClickOffsetX"] = 0;
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (jABGlobalMiddleMouseClickOnElementclickOffsetY != null)
                {
                    if (jABGlobalMiddleMouseClickOnElementclickOffsetY != null)
                    {
                        jABGlobalMiddleMouseClickOnElement["ClickOffsetY"] = SourceExpressionConverter.ConvertToken(jABGlobalMiddleMouseClickOnElementclickOffsetY);
                        jABGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalMiddleMouseClickOnElement["ClickOffsetY"] = 0;
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (jABGlobalMiddleMouseClickOnElementoffsetRelativeTo != null)
                {
                    jABGlobalMiddleMouseClickOnElement["OffsetRelativeTo"] = SourceExpressionConverter.Convert(jABGlobalMiddleMouseClickOnElementoffsetRelativeTo);
                    jABGlobalMiddleMouseClickOnElementpropCount++;
                }

                jABGlobalMiddleMouseClickOnElementpropCount++;
                jABGlobalMiddleMouseClickOnElement["Workflow"] = SourceExpressionConverter.ConvertToken(jABGlobalMiddleMouseClickOnElementworkflow);
                if (jABGlobalMiddleMouseClickOnElementpropCount > 0)
                {
                    callPayload.Body = jABGlobalMiddleMouseClickOnElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalDoubleLeftMouseClickOnElement([WorkflowExpression] Func<int> jABGlobalDoubleLeftMouseClickOnElementsearchParentElementJABHandle, [WorkflowExpression] Func<string> jABGlobalDoubleLeftMouseClickOnElementworkflow, [WorkflowExpression] Func<string> jABGlobalDoubleLeftMouseClickOnElementsearchElementJABName = null, [WorkflowExpression] Func<string> jABGlobalDoubleLeftMouseClickOnElementsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABGlobalDoubleLeftMouseClickOnElementsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABGlobalDoubleLeftMouseClickOnElementsearchSubTree = null, [WorkflowExpression] Func<int> jABGlobalDoubleLeftMouseClickOnElementmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABGlobalDoubleLeftMouseClickOnElementmatchIndex = null, [WorkflowExpression] Func<string> jABGlobalDoubleLeftMouseClickOnElementsearchFilter = null, [WorkflowExpression] Func<string> jABGlobalDoubleLeftMouseClickOnElementsortByColumn = null, [WorkflowExpression] Func<bool> jABGlobalDoubleLeftMouseClickOnElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABGlobalDoubleLeftMouseClickOnElementcaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABGlobalDoubleLeftMouseClickOnElementonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABGlobalDoubleLeftMouseClickOnElementonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABGlobalDoubleLeftMouseClickOnElementelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABGlobalDoubleLeftMouseClickOnElementmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABGlobalDoubleLeftMouseClickOnElementmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<int> jABGlobalDoubleLeftMouseClickOnElementclickOffsetX = null, [WorkflowExpression] Func<int> jABGlobalDoubleLeftMouseClickOnElementclickOffsetY = null, [WorkflowExpression] Func<jABGlobalDoubleLeftMouseClickOnElementoffsetRelativeToInput> jABGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo = null, [WorkflowExpression] Func<int> jABGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds = null)
        {
            SourceExpression.Validate(jABGlobalDoubleLeftMouseClickOnElementsearchParentElementJABHandle, nameof(jABGlobalDoubleLeftMouseClickOnElementsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABGlobalDoubleLeftMouseClickOnElementworkflow, nameof(jABGlobalDoubleLeftMouseClickOnElementworkflow), required: true);
            SourceExpression.Validate(jABGlobalDoubleLeftMouseClickOnElementsearchElementJABName, nameof(jABGlobalDoubleLeftMouseClickOnElementsearchElementJABName), required: false);
            SourceExpression.Validate(jABGlobalDoubleLeftMouseClickOnElementsearchElementJABDescription, nameof(jABGlobalDoubleLeftMouseClickOnElementsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABGlobalDoubleLeftMouseClickOnElementsearchElementJABRole, nameof(jABGlobalDoubleLeftMouseClickOnElementsearchElementJABRole), required: false);
            SourceExpression.Validate(jABGlobalDoubleLeftMouseClickOnElementsearchSubTree, nameof(jABGlobalDoubleLeftMouseClickOnElementsearchSubTree), required: false);
            SourceExpression.Validate(jABGlobalDoubleLeftMouseClickOnElementmaxRelativeDepth, nameof(jABGlobalDoubleLeftMouseClickOnElementmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABGlobalDoubleLeftMouseClickOnElementmatchIndex, nameof(jABGlobalDoubleLeftMouseClickOnElementmatchIndex), required: false);
            SourceExpression.Validate(jABGlobalDoubleLeftMouseClickOnElementsearchFilter, nameof(jABGlobalDoubleLeftMouseClickOnElementsearchFilter), required: false);
            SourceExpression.Validate(jABGlobalDoubleLeftMouseClickOnElementsortByColumn, nameof(jABGlobalDoubleLeftMouseClickOnElementsortByColumn), required: false);
            SourceExpression.Validate(jABGlobalDoubleLeftMouseClickOnElementmatchIndexAscending, nameof(jABGlobalDoubleLeftMouseClickOnElementmatchIndexAscending), required: false);
            SourceExpression.Validate(jABGlobalDoubleLeftMouseClickOnElementcaseSensitiveSearch, nameof(jABGlobalDoubleLeftMouseClickOnElementcaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABGlobalDoubleLeftMouseClickOnElementonlySearchVisibleElements, nameof(jABGlobalDoubleLeftMouseClickOnElementonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABGlobalDoubleLeftMouseClickOnElementonlySearchShowingElements, nameof(jABGlobalDoubleLeftMouseClickOnElementonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABGlobalDoubleLeftMouseClickOnElementelementRolesNotToTraverse, nameof(jABGlobalDoubleLeftMouseClickOnElementelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABGlobalDoubleLeftMouseClickOnElementmaximumElementsToSearch, nameof(jABGlobalDoubleLeftMouseClickOnElementmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABGlobalDoubleLeftMouseClickOnElementmaximumChildElementsToSearchPerNode, nameof(jABGlobalDoubleLeftMouseClickOnElementmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABGlobalDoubleLeftMouseClickOnElementclickOffsetX, nameof(jABGlobalDoubleLeftMouseClickOnElementclickOffsetX), required: false);
            SourceExpression.Validate(jABGlobalDoubleLeftMouseClickOnElementclickOffsetY, nameof(jABGlobalDoubleLeftMouseClickOnElementclickOffsetY), required: false);
            SourceExpression.Validate(jABGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo, nameof(jABGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo), required: false);
            SourceExpression.Validate(jABGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds, nameof(jABGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalDoubleLeftMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGlobalDoubleLeftMouseClickOnElement = new JObject();
                var jABGlobalDoubleLeftMouseClickOnElementpropCount = 0;
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                jABGlobalDoubleLeftMouseClickOnElement["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGlobalDoubleLeftMouseClickOnElementsearchParentElementJABHandle);
                if (jABGlobalDoubleLeftMouseClickOnElementsearchElementJABName != null)
                {
                    jABGlobalDoubleLeftMouseClickOnElement["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABGlobalDoubleLeftMouseClickOnElementsearchElementJABName);
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalDoubleLeftMouseClickOnElementsearchElementJABDescription != null)
                {
                    jABGlobalDoubleLeftMouseClickOnElement["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABGlobalDoubleLeftMouseClickOnElementsearchElementJABDescription);
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalDoubleLeftMouseClickOnElementsearchElementJABRole != null)
                {
                    jABGlobalDoubleLeftMouseClickOnElement["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABGlobalDoubleLeftMouseClickOnElementsearchElementJABRole);
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalDoubleLeftMouseClickOnElementsearchSubTree != null)
                {
                    if (jABGlobalDoubleLeftMouseClickOnElementsearchSubTree != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABGlobalDoubleLeftMouseClickOnElementsearchSubTree);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["SearchSubTree"] = true;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalDoubleLeftMouseClickOnElementmaxRelativeDepth != null)
                {
                    if (jABGlobalDoubleLeftMouseClickOnElementmaxRelativeDepth != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABGlobalDoubleLeftMouseClickOnElementmaxRelativeDepth);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["MaxRelativeDepth"] = 0;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalDoubleLeftMouseClickOnElementmatchIndex != null)
                {
                    if (jABGlobalDoubleLeftMouseClickOnElementmatchIndex != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABGlobalDoubleLeftMouseClickOnElementmatchIndex);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["MatchIndex"] = 1;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalDoubleLeftMouseClickOnElementsearchFilter != null)
                {
                    jABGlobalDoubleLeftMouseClickOnElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABGlobalDoubleLeftMouseClickOnElementsearchFilter);
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalDoubleLeftMouseClickOnElementsortByColumn != null)
                {
                    jABGlobalDoubleLeftMouseClickOnElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABGlobalDoubleLeftMouseClickOnElementsortByColumn);
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalDoubleLeftMouseClickOnElementmatchIndexAscending != null)
                {
                    if (jABGlobalDoubleLeftMouseClickOnElementmatchIndexAscending != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABGlobalDoubleLeftMouseClickOnElementmatchIndexAscending);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["MatchIndexAscending"] = true;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalDoubleLeftMouseClickOnElementcaseSensitiveSearch != null)
                {
                    if (jABGlobalDoubleLeftMouseClickOnElementcaseSensitiveSearch != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABGlobalDoubleLeftMouseClickOnElementcaseSensitiveSearch);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["CaseSensitiveSearch"] = false;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalDoubleLeftMouseClickOnElementonlySearchVisibleElements != null)
                {
                    if (jABGlobalDoubleLeftMouseClickOnElementonlySearchVisibleElements != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABGlobalDoubleLeftMouseClickOnElementonlySearchVisibleElements);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["OnlySearchVisibleElements"] = true;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalDoubleLeftMouseClickOnElementonlySearchShowingElements != null)
                {
                    if (jABGlobalDoubleLeftMouseClickOnElementonlySearchShowingElements != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABGlobalDoubleLeftMouseClickOnElementonlySearchShowingElements);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["OnlySearchShowingElements"] = true;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalDoubleLeftMouseClickOnElementelementRolesNotToTraverse != null)
                {
                    jABGlobalDoubleLeftMouseClickOnElement["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABGlobalDoubleLeftMouseClickOnElementelementRolesNotToTraverse);
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalDoubleLeftMouseClickOnElementmaximumElementsToSearch != null)
                {
                    if (jABGlobalDoubleLeftMouseClickOnElementmaximumElementsToSearch != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABGlobalDoubleLeftMouseClickOnElementmaximumElementsToSearch);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["MaximumElementsToSearch"] = 2000;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalDoubleLeftMouseClickOnElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABGlobalDoubleLeftMouseClickOnElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABGlobalDoubleLeftMouseClickOnElementmaximumChildElementsToSearchPerNode);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalDoubleLeftMouseClickOnElementclickOffsetX != null)
                {
                    if (jABGlobalDoubleLeftMouseClickOnElementclickOffsetX != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["ClickOffsetX"] = SourceExpressionConverter.ConvertToken(jABGlobalDoubleLeftMouseClickOnElementclickOffsetX);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["ClickOffsetX"] = 0;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalDoubleLeftMouseClickOnElementclickOffsetY != null)
                {
                    if (jABGlobalDoubleLeftMouseClickOnElementclickOffsetY != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["ClickOffsetY"] = SourceExpressionConverter.ConvertToken(jABGlobalDoubleLeftMouseClickOnElementclickOffsetY);
                        jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    jABGlobalDoubleLeftMouseClickOnElement["ClickOffsetY"] = 0;
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo != null)
                {
                    jABGlobalDoubleLeftMouseClickOnElement["OffsetRelativeTo"] = SourceExpressionConverter.Convert(jABGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo);
                    jABGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (jABGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds != null)
                {
                    if (jABGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds != null)
                    {
                        jABGlobalDoubleLeftMouseClickOnElement["DelayInMilliseconds"] = SourceExpressionConverter.ConvertToken(jABGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds);
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
                jABGlobalDoubleLeftMouseClickOnElement["Workflow"] = SourceExpressionConverter.ConvertToken(jABGlobalDoubleLeftMouseClickOnElementworkflow);
                if (jABGlobalDoubleLeftMouseClickOnElementpropCount > 0)
                {
                    callPayload.Body = jABGlobalDoubleLeftMouseClickOnElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetActionsForElementResponse> JABGetActionsForElement([WorkflowExpression] Func<int> jABGetActionsForElementsearchParentElementJABHandle, [WorkflowExpression] Func<string> jABGetActionsForElementworkflow, [WorkflowExpression] Func<string> jABGetActionsForElementsearchElementJABName = null, [WorkflowExpression] Func<string> jABGetActionsForElementsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABGetActionsForElementsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABGetActionsForElementsearchSubTree = null, [WorkflowExpression] Func<int> jABGetActionsForElementmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABGetActionsForElementmatchIndex = null, [WorkflowExpression] Func<string> jABGetActionsForElementsearchFilter = null, [WorkflowExpression] Func<string> jABGetActionsForElementsortByColumn = null, [WorkflowExpression] Func<bool> jABGetActionsForElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABGetActionsForElementcaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABGetActionsForElementonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABGetActionsForElementonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABGetActionsForElementelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABGetActionsForElementmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABGetActionsForElementmaximumChildElementsToSearchPerNode = null)
        {
            SourceExpression.Validate(jABGetActionsForElementsearchParentElementJABHandle, nameof(jABGetActionsForElementsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABGetActionsForElementworkflow, nameof(jABGetActionsForElementworkflow), required: true);
            SourceExpression.Validate(jABGetActionsForElementsearchElementJABName, nameof(jABGetActionsForElementsearchElementJABName), required: false);
            SourceExpression.Validate(jABGetActionsForElementsearchElementJABDescription, nameof(jABGetActionsForElementsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABGetActionsForElementsearchElementJABRole, nameof(jABGetActionsForElementsearchElementJABRole), required: false);
            SourceExpression.Validate(jABGetActionsForElementsearchSubTree, nameof(jABGetActionsForElementsearchSubTree), required: false);
            SourceExpression.Validate(jABGetActionsForElementmaxRelativeDepth, nameof(jABGetActionsForElementmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABGetActionsForElementmatchIndex, nameof(jABGetActionsForElementmatchIndex), required: false);
            SourceExpression.Validate(jABGetActionsForElementsearchFilter, nameof(jABGetActionsForElementsearchFilter), required: false);
            SourceExpression.Validate(jABGetActionsForElementsortByColumn, nameof(jABGetActionsForElementsortByColumn), required: false);
            SourceExpression.Validate(jABGetActionsForElementmatchIndexAscending, nameof(jABGetActionsForElementmatchIndexAscending), required: false);
            SourceExpression.Validate(jABGetActionsForElementcaseSensitiveSearch, nameof(jABGetActionsForElementcaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABGetActionsForElementonlySearchVisibleElements, nameof(jABGetActionsForElementonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABGetActionsForElementonlySearchShowingElements, nameof(jABGetActionsForElementonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABGetActionsForElementelementRolesNotToTraverse, nameof(jABGetActionsForElementelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABGetActionsForElementmaximumElementsToSearch, nameof(jABGetActionsForElementmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABGetActionsForElementmaximumChildElementsToSearchPerNode, nameof(jABGetActionsForElementmaximumChildElementsToSearchPerNode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetActionsForElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetActionsForElement = new JObject();
                var jABGetActionsForElementpropCount = 0;
                jABGetActionsForElementpropCount++;
                jABGetActionsForElement["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGetActionsForElementsearchParentElementJABHandle);
                if (jABGetActionsForElementsearchElementJABName != null)
                {
                    jABGetActionsForElement["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABGetActionsForElementsearchElementJABName);
                    jABGetActionsForElementpropCount++;
                }

                if (jABGetActionsForElementsearchElementJABDescription != null)
                {
                    jABGetActionsForElement["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABGetActionsForElementsearchElementJABDescription);
                    jABGetActionsForElementpropCount++;
                }

                if (jABGetActionsForElementsearchElementJABRole != null)
                {
                    jABGetActionsForElement["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABGetActionsForElementsearchElementJABRole);
                    jABGetActionsForElementpropCount++;
                }

                if (jABGetActionsForElementsearchSubTree != null)
                {
                    if (jABGetActionsForElementsearchSubTree != null)
                    {
                        jABGetActionsForElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABGetActionsForElementsearchSubTree);
                        jABGetActionsForElementpropCount++;
                    }

                    jABGetActionsForElementpropCount++;
                }
                else
                {
                    jABGetActionsForElement["SearchSubTree"] = true;
                    jABGetActionsForElementpropCount++;
                }

                if (jABGetActionsForElementmaxRelativeDepth != null)
                {
                    if (jABGetActionsForElementmaxRelativeDepth != null)
                    {
                        jABGetActionsForElement["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABGetActionsForElementmaxRelativeDepth);
                        jABGetActionsForElementpropCount++;
                    }

                    jABGetActionsForElementpropCount++;
                }
                else
                {
                    jABGetActionsForElement["MaxRelativeDepth"] = 0;
                    jABGetActionsForElementpropCount++;
                }

                if (jABGetActionsForElementmatchIndex != null)
                {
                    if (jABGetActionsForElementmatchIndex != null)
                    {
                        jABGetActionsForElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABGetActionsForElementmatchIndex);
                        jABGetActionsForElementpropCount++;
                    }

                    jABGetActionsForElementpropCount++;
                }
                else
                {
                    jABGetActionsForElement["MatchIndex"] = 1;
                    jABGetActionsForElementpropCount++;
                }

                if (jABGetActionsForElementsearchFilter != null)
                {
                    jABGetActionsForElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABGetActionsForElementsearchFilter);
                    jABGetActionsForElementpropCount++;
                }

                if (jABGetActionsForElementsortByColumn != null)
                {
                    jABGetActionsForElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABGetActionsForElementsortByColumn);
                    jABGetActionsForElementpropCount++;
                }

                if (jABGetActionsForElementmatchIndexAscending != null)
                {
                    if (jABGetActionsForElementmatchIndexAscending != null)
                    {
                        jABGetActionsForElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABGetActionsForElementmatchIndexAscending);
                        jABGetActionsForElementpropCount++;
                    }

                    jABGetActionsForElementpropCount++;
                }
                else
                {
                    jABGetActionsForElement["MatchIndexAscending"] = true;
                    jABGetActionsForElementpropCount++;
                }

                if (jABGetActionsForElementcaseSensitiveSearch != null)
                {
                    if (jABGetActionsForElementcaseSensitiveSearch != null)
                    {
                        jABGetActionsForElement["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABGetActionsForElementcaseSensitiveSearch);
                        jABGetActionsForElementpropCount++;
                    }

                    jABGetActionsForElementpropCount++;
                }
                else
                {
                    jABGetActionsForElement["CaseSensitiveSearch"] = false;
                    jABGetActionsForElementpropCount++;
                }

                if (jABGetActionsForElementonlySearchVisibleElements != null)
                {
                    if (jABGetActionsForElementonlySearchVisibleElements != null)
                    {
                        jABGetActionsForElement["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABGetActionsForElementonlySearchVisibleElements);
                        jABGetActionsForElementpropCount++;
                    }

                    jABGetActionsForElementpropCount++;
                }
                else
                {
                    jABGetActionsForElement["OnlySearchVisibleElements"] = true;
                    jABGetActionsForElementpropCount++;
                }

                if (jABGetActionsForElementonlySearchShowingElements != null)
                {
                    if (jABGetActionsForElementonlySearchShowingElements != null)
                    {
                        jABGetActionsForElement["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABGetActionsForElementonlySearchShowingElements);
                        jABGetActionsForElementpropCount++;
                    }

                    jABGetActionsForElementpropCount++;
                }
                else
                {
                    jABGetActionsForElement["OnlySearchShowingElements"] = true;
                    jABGetActionsForElementpropCount++;
                }

                if (jABGetActionsForElementelementRolesNotToTraverse != null)
                {
                    jABGetActionsForElement["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABGetActionsForElementelementRolesNotToTraverse);
                    jABGetActionsForElementpropCount++;
                }

                if (jABGetActionsForElementmaximumElementsToSearch != null)
                {
                    if (jABGetActionsForElementmaximumElementsToSearch != null)
                    {
                        jABGetActionsForElement["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABGetActionsForElementmaximumElementsToSearch);
                        jABGetActionsForElementpropCount++;
                    }

                    jABGetActionsForElementpropCount++;
                }
                else
                {
                    jABGetActionsForElement["MaximumElementsToSearch"] = 2000;
                    jABGetActionsForElementpropCount++;
                }

                if (jABGetActionsForElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABGetActionsForElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetActionsForElement["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABGetActionsForElementmaximumChildElementsToSearchPerNode);
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
                jABGetActionsForElement["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetActionsForElementworkflow);
                if (jABGetActionsForElementpropCount > 0)
                {
                    callPayload.Body = jABGetActionsForElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetActionsForElementResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABFocusElement([WorkflowExpression] Func<int> jABFocusElementsearchParentElementJABHandle, [WorkflowExpression] Func<string> jABFocusElementworkflow, [WorkflowExpression] Func<string> jABFocusElementsearchElementJABName = null, [WorkflowExpression] Func<string> jABFocusElementsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABFocusElementsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABFocusElementsearchSubTree = null, [WorkflowExpression] Func<int> jABFocusElementmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABFocusElementmatchIndex = null, [WorkflowExpression] Func<string> jABFocusElementsearchFilter = null, [WorkflowExpression] Func<string> jABFocusElementsortByColumn = null, [WorkflowExpression] Func<bool> jABFocusElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABFocusElementcaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABFocusElementonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABFocusElementonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABFocusElementelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABFocusElementmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABFocusElementmaximumChildElementsToSearchPerNode = null)
        {
            SourceExpression.Validate(jABFocusElementsearchParentElementJABHandle, nameof(jABFocusElementsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABFocusElementworkflow, nameof(jABFocusElementworkflow), required: true);
            SourceExpression.Validate(jABFocusElementsearchElementJABName, nameof(jABFocusElementsearchElementJABName), required: false);
            SourceExpression.Validate(jABFocusElementsearchElementJABDescription, nameof(jABFocusElementsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABFocusElementsearchElementJABRole, nameof(jABFocusElementsearchElementJABRole), required: false);
            SourceExpression.Validate(jABFocusElementsearchSubTree, nameof(jABFocusElementsearchSubTree), required: false);
            SourceExpression.Validate(jABFocusElementmaxRelativeDepth, nameof(jABFocusElementmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABFocusElementmatchIndex, nameof(jABFocusElementmatchIndex), required: false);
            SourceExpression.Validate(jABFocusElementsearchFilter, nameof(jABFocusElementsearchFilter), required: false);
            SourceExpression.Validate(jABFocusElementsortByColumn, nameof(jABFocusElementsortByColumn), required: false);
            SourceExpression.Validate(jABFocusElementmatchIndexAscending, nameof(jABFocusElementmatchIndexAscending), required: false);
            SourceExpression.Validate(jABFocusElementcaseSensitiveSearch, nameof(jABFocusElementcaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABFocusElementonlySearchVisibleElements, nameof(jABFocusElementonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABFocusElementonlySearchShowingElements, nameof(jABFocusElementonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABFocusElementelementRolesNotToTraverse, nameof(jABFocusElementelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABFocusElementmaximumElementsToSearch, nameof(jABFocusElementmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABFocusElementmaximumChildElementsToSearchPerNode, nameof(jABFocusElementmaximumChildElementsToSearchPerNode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABFocusElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABFocusElement = new JObject();
                var jABFocusElementpropCount = 0;
                jABFocusElementpropCount++;
                jABFocusElement["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABFocusElementsearchParentElementJABHandle);
                if (jABFocusElementsearchElementJABName != null)
                {
                    jABFocusElement["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABFocusElementsearchElementJABName);
                    jABFocusElementpropCount++;
                }

                if (jABFocusElementsearchElementJABDescription != null)
                {
                    jABFocusElement["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABFocusElementsearchElementJABDescription);
                    jABFocusElementpropCount++;
                }

                if (jABFocusElementsearchElementJABRole != null)
                {
                    jABFocusElement["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABFocusElementsearchElementJABRole);
                    jABFocusElementpropCount++;
                }

                if (jABFocusElementsearchSubTree != null)
                {
                    if (jABFocusElementsearchSubTree != null)
                    {
                        jABFocusElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABFocusElementsearchSubTree);
                        jABFocusElementpropCount++;
                    }

                    jABFocusElementpropCount++;
                }
                else
                {
                    jABFocusElement["SearchSubTree"] = true;
                    jABFocusElementpropCount++;
                }

                if (jABFocusElementmaxRelativeDepth != null)
                {
                    if (jABFocusElementmaxRelativeDepth != null)
                    {
                        jABFocusElement["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABFocusElementmaxRelativeDepth);
                        jABFocusElementpropCount++;
                    }

                    jABFocusElementpropCount++;
                }
                else
                {
                    jABFocusElement["MaxRelativeDepth"] = 0;
                    jABFocusElementpropCount++;
                }

                if (jABFocusElementmatchIndex != null)
                {
                    if (jABFocusElementmatchIndex != null)
                    {
                        jABFocusElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABFocusElementmatchIndex);
                        jABFocusElementpropCount++;
                    }

                    jABFocusElementpropCount++;
                }
                else
                {
                    jABFocusElement["MatchIndex"] = 1;
                    jABFocusElementpropCount++;
                }

                if (jABFocusElementsearchFilter != null)
                {
                    jABFocusElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABFocusElementsearchFilter);
                    jABFocusElementpropCount++;
                }

                if (jABFocusElementsortByColumn != null)
                {
                    jABFocusElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABFocusElementsortByColumn);
                    jABFocusElementpropCount++;
                }

                if (jABFocusElementmatchIndexAscending != null)
                {
                    if (jABFocusElementmatchIndexAscending != null)
                    {
                        jABFocusElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABFocusElementmatchIndexAscending);
                        jABFocusElementpropCount++;
                    }

                    jABFocusElementpropCount++;
                }
                else
                {
                    jABFocusElement["MatchIndexAscending"] = true;
                    jABFocusElementpropCount++;
                }

                if (jABFocusElementcaseSensitiveSearch != null)
                {
                    if (jABFocusElementcaseSensitiveSearch != null)
                    {
                        jABFocusElement["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABFocusElementcaseSensitiveSearch);
                        jABFocusElementpropCount++;
                    }

                    jABFocusElementpropCount++;
                }
                else
                {
                    jABFocusElement["CaseSensitiveSearch"] = false;
                    jABFocusElementpropCount++;
                }

                if (jABFocusElementonlySearchVisibleElements != null)
                {
                    if (jABFocusElementonlySearchVisibleElements != null)
                    {
                        jABFocusElement["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABFocusElementonlySearchVisibleElements);
                        jABFocusElementpropCount++;
                    }

                    jABFocusElementpropCount++;
                }
                else
                {
                    jABFocusElement["OnlySearchVisibleElements"] = true;
                    jABFocusElementpropCount++;
                }

                if (jABFocusElementonlySearchShowingElements != null)
                {
                    if (jABFocusElementonlySearchShowingElements != null)
                    {
                        jABFocusElement["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABFocusElementonlySearchShowingElements);
                        jABFocusElementpropCount++;
                    }

                    jABFocusElementpropCount++;
                }
                else
                {
                    jABFocusElement["OnlySearchShowingElements"] = true;
                    jABFocusElementpropCount++;
                }

                if (jABFocusElementelementRolesNotToTraverse != null)
                {
                    jABFocusElement["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABFocusElementelementRolesNotToTraverse);
                    jABFocusElementpropCount++;
                }

                if (jABFocusElementmaximumElementsToSearch != null)
                {
                    if (jABFocusElementmaximumElementsToSearch != null)
                    {
                        jABFocusElement["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABFocusElementmaximumElementsToSearch);
                        jABFocusElementpropCount++;
                    }

                    jABFocusElementpropCount++;
                }
                else
                {
                    jABFocusElement["MaximumElementsToSearch"] = 2000;
                    jABFocusElementpropCount++;
                }

                if (jABFocusElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABFocusElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABFocusElement["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABFocusElementmaximumChildElementsToSearchPerNode);
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
                jABFocusElement["Workflow"] = SourceExpressionConverter.ConvertToken(jABFocusElementworkflow);
                if (jABFocusElementpropCount > 0)
                {
                    callPayload.Body = jABFocusElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABInputPasswordIntoElement([WorkflowExpression] Func<int> jABInputPasswordIntoElementsearchParentElementJABHandle, [WorkflowExpression] Func<string> jABInputPasswordIntoElementpasswordToInput, [WorkflowExpression] Func<string> jABInputPasswordIntoElementworkflow, [WorkflowExpression] Func<string> jABInputPasswordIntoElementsearchElementJABName = null, [WorkflowExpression] Func<string> jABInputPasswordIntoElementsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABInputPasswordIntoElementsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABInputPasswordIntoElementsearchSubTree = null, [WorkflowExpression] Func<int> jABInputPasswordIntoElementmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABInputPasswordIntoElementmatchIndex = null, [WorkflowExpression] Func<string> jABInputPasswordIntoElementsearchFilter = null, [WorkflowExpression] Func<string> jABInputPasswordIntoElementsortByColumn = null, [WorkflowExpression] Func<bool> jABInputPasswordIntoElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABInputPasswordIntoElementcaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABInputPasswordIntoElementonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABInputPasswordIntoElementonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABInputPasswordIntoElementelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABInputPasswordIntoElementmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABInputPasswordIntoElementmaximumChildElementsToSearchPerNode = null)
        {
            SourceExpression.Validate(jABInputPasswordIntoElementsearchParentElementJABHandle, nameof(jABInputPasswordIntoElementsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABInputPasswordIntoElementpasswordToInput, nameof(jABInputPasswordIntoElementpasswordToInput), required: true);
            SourceExpression.Validate(jABInputPasswordIntoElementworkflow, nameof(jABInputPasswordIntoElementworkflow), required: true);
            SourceExpression.Validate(jABInputPasswordIntoElementsearchElementJABName, nameof(jABInputPasswordIntoElementsearchElementJABName), required: false);
            SourceExpression.Validate(jABInputPasswordIntoElementsearchElementJABDescription, nameof(jABInputPasswordIntoElementsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABInputPasswordIntoElementsearchElementJABRole, nameof(jABInputPasswordIntoElementsearchElementJABRole), required: false);
            SourceExpression.Validate(jABInputPasswordIntoElementsearchSubTree, nameof(jABInputPasswordIntoElementsearchSubTree), required: false);
            SourceExpression.Validate(jABInputPasswordIntoElementmaxRelativeDepth, nameof(jABInputPasswordIntoElementmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABInputPasswordIntoElementmatchIndex, nameof(jABInputPasswordIntoElementmatchIndex), required: false);
            SourceExpression.Validate(jABInputPasswordIntoElementsearchFilter, nameof(jABInputPasswordIntoElementsearchFilter), required: false);
            SourceExpression.Validate(jABInputPasswordIntoElementsortByColumn, nameof(jABInputPasswordIntoElementsortByColumn), required: false);
            SourceExpression.Validate(jABInputPasswordIntoElementmatchIndexAscending, nameof(jABInputPasswordIntoElementmatchIndexAscending), required: false);
            SourceExpression.Validate(jABInputPasswordIntoElementcaseSensitiveSearch, nameof(jABInputPasswordIntoElementcaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABInputPasswordIntoElementonlySearchVisibleElements, nameof(jABInputPasswordIntoElementonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABInputPasswordIntoElementonlySearchShowingElements, nameof(jABInputPasswordIntoElementonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABInputPasswordIntoElementelementRolesNotToTraverse, nameof(jABInputPasswordIntoElementelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABInputPasswordIntoElementmaximumElementsToSearch, nameof(jABInputPasswordIntoElementmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABInputPasswordIntoElementmaximumChildElementsToSearchPerNode, nameof(jABInputPasswordIntoElementmaximumChildElementsToSearchPerNode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABInputPasswordIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABInputPasswordIntoElement = new JObject();
                var jABInputPasswordIntoElementpropCount = 0;
                jABInputPasswordIntoElementpropCount++;
                jABInputPasswordIntoElement["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABInputPasswordIntoElementsearchParentElementJABHandle);
                if (jABInputPasswordIntoElementsearchElementJABName != null)
                {
                    jABInputPasswordIntoElement["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABInputPasswordIntoElementsearchElementJABName);
                    jABInputPasswordIntoElementpropCount++;
                }

                if (jABInputPasswordIntoElementsearchElementJABDescription != null)
                {
                    jABInputPasswordIntoElement["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABInputPasswordIntoElementsearchElementJABDescription);
                    jABInputPasswordIntoElementpropCount++;
                }

                if (jABInputPasswordIntoElementsearchElementJABRole != null)
                {
                    jABInputPasswordIntoElement["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABInputPasswordIntoElementsearchElementJABRole);
                    jABInputPasswordIntoElementpropCount++;
                }

                if (jABInputPasswordIntoElementsearchSubTree != null)
                {
                    if (jABInputPasswordIntoElementsearchSubTree != null)
                    {
                        jABInputPasswordIntoElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABInputPasswordIntoElementsearchSubTree);
                        jABInputPasswordIntoElementpropCount++;
                    }

                    jABInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABInputPasswordIntoElement["SearchSubTree"] = true;
                    jABInputPasswordIntoElementpropCount++;
                }

                if (jABInputPasswordIntoElementmaxRelativeDepth != null)
                {
                    if (jABInputPasswordIntoElementmaxRelativeDepth != null)
                    {
                        jABInputPasswordIntoElement["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABInputPasswordIntoElementmaxRelativeDepth);
                        jABInputPasswordIntoElementpropCount++;
                    }

                    jABInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABInputPasswordIntoElement["MaxRelativeDepth"] = 0;
                    jABInputPasswordIntoElementpropCount++;
                }

                if (jABInputPasswordIntoElementmatchIndex != null)
                {
                    if (jABInputPasswordIntoElementmatchIndex != null)
                    {
                        jABInputPasswordIntoElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABInputPasswordIntoElementmatchIndex);
                        jABInputPasswordIntoElementpropCount++;
                    }

                    jABInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABInputPasswordIntoElement["MatchIndex"] = 1;
                    jABInputPasswordIntoElementpropCount++;
                }

                if (jABInputPasswordIntoElementsearchFilter != null)
                {
                    jABInputPasswordIntoElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABInputPasswordIntoElementsearchFilter);
                    jABInputPasswordIntoElementpropCount++;
                }

                if (jABInputPasswordIntoElementsortByColumn != null)
                {
                    jABInputPasswordIntoElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABInputPasswordIntoElementsortByColumn);
                    jABInputPasswordIntoElementpropCount++;
                }

                if (jABInputPasswordIntoElementmatchIndexAscending != null)
                {
                    if (jABInputPasswordIntoElementmatchIndexAscending != null)
                    {
                        jABInputPasswordIntoElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABInputPasswordIntoElementmatchIndexAscending);
                        jABInputPasswordIntoElementpropCount++;
                    }

                    jABInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABInputPasswordIntoElement["MatchIndexAscending"] = true;
                    jABInputPasswordIntoElementpropCount++;
                }

                if (jABInputPasswordIntoElementcaseSensitiveSearch != null)
                {
                    if (jABInputPasswordIntoElementcaseSensitiveSearch != null)
                    {
                        jABInputPasswordIntoElement["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABInputPasswordIntoElementcaseSensitiveSearch);
                        jABInputPasswordIntoElementpropCount++;
                    }

                    jABInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABInputPasswordIntoElement["CaseSensitiveSearch"] = false;
                    jABInputPasswordIntoElementpropCount++;
                }

                if (jABInputPasswordIntoElementonlySearchVisibleElements != null)
                {
                    if (jABInputPasswordIntoElementonlySearchVisibleElements != null)
                    {
                        jABInputPasswordIntoElement["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABInputPasswordIntoElementonlySearchVisibleElements);
                        jABInputPasswordIntoElementpropCount++;
                    }

                    jABInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABInputPasswordIntoElement["OnlySearchVisibleElements"] = true;
                    jABInputPasswordIntoElementpropCount++;
                }

                if (jABInputPasswordIntoElementonlySearchShowingElements != null)
                {
                    if (jABInputPasswordIntoElementonlySearchShowingElements != null)
                    {
                        jABInputPasswordIntoElement["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABInputPasswordIntoElementonlySearchShowingElements);
                        jABInputPasswordIntoElementpropCount++;
                    }

                    jABInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABInputPasswordIntoElement["OnlySearchShowingElements"] = true;
                    jABInputPasswordIntoElementpropCount++;
                }

                if (jABInputPasswordIntoElementelementRolesNotToTraverse != null)
                {
                    jABInputPasswordIntoElement["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABInputPasswordIntoElementelementRolesNotToTraverse);
                    jABInputPasswordIntoElementpropCount++;
                }

                if (jABInputPasswordIntoElementmaximumElementsToSearch != null)
                {
                    if (jABInputPasswordIntoElementmaximumElementsToSearch != null)
                    {
                        jABInputPasswordIntoElement["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABInputPasswordIntoElementmaximumElementsToSearch);
                        jABInputPasswordIntoElementpropCount++;
                    }

                    jABInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABInputPasswordIntoElement["MaximumElementsToSearch"] = 2000;
                    jABInputPasswordIntoElementpropCount++;
                }

                if (jABInputPasswordIntoElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABInputPasswordIntoElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABInputPasswordIntoElement["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABInputPasswordIntoElementmaximumChildElementsToSearchPerNode);
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
                jABInputPasswordIntoElement["PasswordToInput"] = SourceExpressionConverter.ConvertToken(jABInputPasswordIntoElementpasswordToInput);
                jABInputPasswordIntoElementpropCount++;
                jABInputPasswordIntoElement["Workflow"] = SourceExpressionConverter.ConvertToken(jABInputPasswordIntoElementworkflow);
                if (jABInputPasswordIntoElementpropCount > 0)
                {
                    callPayload.Body = jABInputPasswordIntoElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABInputTextIntoElement([WorkflowExpression] Func<int> jABInputTextIntoElementsearchParentElementJABHandle, [WorkflowExpression] Func<string> jABInputTextIntoElementworkflow, [WorkflowExpression] Func<string> jABInputTextIntoElementsearchElementJABName = null, [WorkflowExpression] Func<string> jABInputTextIntoElementsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABInputTextIntoElementsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABInputTextIntoElementsearchSubTree = null, [WorkflowExpression] Func<int> jABInputTextIntoElementmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABInputTextIntoElementmatchIndex = null, [WorkflowExpression] Func<string> jABInputTextIntoElementsearchFilter = null, [WorkflowExpression] Func<string> jABInputTextIntoElementsortByColumn = null, [WorkflowExpression] Func<bool> jABInputTextIntoElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABInputTextIntoElementcaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABInputTextIntoElementonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABInputTextIntoElementonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABInputTextIntoElementelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABInputTextIntoElementmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABInputTextIntoElementmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<string> jABInputTextIntoElementtextToInput = null, [WorkflowExpression] Func<bool> jABInputTextIntoElementreplaceExistingValue = null, [WorkflowExpression] Func<int> jABInputTextIntoElementinsertPosition = null)
        {
            SourceExpression.Validate(jABInputTextIntoElementsearchParentElementJABHandle, nameof(jABInputTextIntoElementsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABInputTextIntoElementworkflow, nameof(jABInputTextIntoElementworkflow), required: true);
            SourceExpression.Validate(jABInputTextIntoElementsearchElementJABName, nameof(jABInputTextIntoElementsearchElementJABName), required: false);
            SourceExpression.Validate(jABInputTextIntoElementsearchElementJABDescription, nameof(jABInputTextIntoElementsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABInputTextIntoElementsearchElementJABRole, nameof(jABInputTextIntoElementsearchElementJABRole), required: false);
            SourceExpression.Validate(jABInputTextIntoElementsearchSubTree, nameof(jABInputTextIntoElementsearchSubTree), required: false);
            SourceExpression.Validate(jABInputTextIntoElementmaxRelativeDepth, nameof(jABInputTextIntoElementmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABInputTextIntoElementmatchIndex, nameof(jABInputTextIntoElementmatchIndex), required: false);
            SourceExpression.Validate(jABInputTextIntoElementsearchFilter, nameof(jABInputTextIntoElementsearchFilter), required: false);
            SourceExpression.Validate(jABInputTextIntoElementsortByColumn, nameof(jABInputTextIntoElementsortByColumn), required: false);
            SourceExpression.Validate(jABInputTextIntoElementmatchIndexAscending, nameof(jABInputTextIntoElementmatchIndexAscending), required: false);
            SourceExpression.Validate(jABInputTextIntoElementcaseSensitiveSearch, nameof(jABInputTextIntoElementcaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABInputTextIntoElementonlySearchVisibleElements, nameof(jABInputTextIntoElementonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABInputTextIntoElementonlySearchShowingElements, nameof(jABInputTextIntoElementonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABInputTextIntoElementelementRolesNotToTraverse, nameof(jABInputTextIntoElementelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABInputTextIntoElementmaximumElementsToSearch, nameof(jABInputTextIntoElementmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABInputTextIntoElementmaximumChildElementsToSearchPerNode, nameof(jABInputTextIntoElementmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABInputTextIntoElementtextToInput, nameof(jABInputTextIntoElementtextToInput), required: false);
            SourceExpression.Validate(jABInputTextIntoElementreplaceExistingValue, nameof(jABInputTextIntoElementreplaceExistingValue), required: false);
            SourceExpression.Validate(jABInputTextIntoElementinsertPosition, nameof(jABInputTextIntoElementinsertPosition), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABInputTextIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABInputTextIntoElement = new JObject();
                var jABInputTextIntoElementpropCount = 0;
                jABInputTextIntoElementpropCount++;
                jABInputTextIntoElement["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABInputTextIntoElementsearchParentElementJABHandle);
                if (jABInputTextIntoElementsearchElementJABName != null)
                {
                    jABInputTextIntoElement["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABInputTextIntoElementsearchElementJABName);
                    jABInputTextIntoElementpropCount++;
                }

                if (jABInputTextIntoElementsearchElementJABDescription != null)
                {
                    jABInputTextIntoElement["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABInputTextIntoElementsearchElementJABDescription);
                    jABInputTextIntoElementpropCount++;
                }

                if (jABInputTextIntoElementsearchElementJABRole != null)
                {
                    jABInputTextIntoElement["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABInputTextIntoElementsearchElementJABRole);
                    jABInputTextIntoElementpropCount++;
                }

                if (jABInputTextIntoElementsearchSubTree != null)
                {
                    if (jABInputTextIntoElementsearchSubTree != null)
                    {
                        jABInputTextIntoElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABInputTextIntoElementsearchSubTree);
                        jABInputTextIntoElementpropCount++;
                    }

                    jABInputTextIntoElementpropCount++;
                }
                else
                {
                    jABInputTextIntoElement["SearchSubTree"] = true;
                    jABInputTextIntoElementpropCount++;
                }

                if (jABInputTextIntoElementmaxRelativeDepth != null)
                {
                    if (jABInputTextIntoElementmaxRelativeDepth != null)
                    {
                        jABInputTextIntoElement["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABInputTextIntoElementmaxRelativeDepth);
                        jABInputTextIntoElementpropCount++;
                    }

                    jABInputTextIntoElementpropCount++;
                }
                else
                {
                    jABInputTextIntoElement["MaxRelativeDepth"] = 0;
                    jABInputTextIntoElementpropCount++;
                }

                if (jABInputTextIntoElementmatchIndex != null)
                {
                    if (jABInputTextIntoElementmatchIndex != null)
                    {
                        jABInputTextIntoElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABInputTextIntoElementmatchIndex);
                        jABInputTextIntoElementpropCount++;
                    }

                    jABInputTextIntoElementpropCount++;
                }
                else
                {
                    jABInputTextIntoElement["MatchIndex"] = 1;
                    jABInputTextIntoElementpropCount++;
                }

                if (jABInputTextIntoElementsearchFilter != null)
                {
                    jABInputTextIntoElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABInputTextIntoElementsearchFilter);
                    jABInputTextIntoElementpropCount++;
                }

                if (jABInputTextIntoElementsortByColumn != null)
                {
                    jABInputTextIntoElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABInputTextIntoElementsortByColumn);
                    jABInputTextIntoElementpropCount++;
                }

                if (jABInputTextIntoElementmatchIndexAscending != null)
                {
                    if (jABInputTextIntoElementmatchIndexAscending != null)
                    {
                        jABInputTextIntoElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABInputTextIntoElementmatchIndexAscending);
                        jABInputTextIntoElementpropCount++;
                    }

                    jABInputTextIntoElementpropCount++;
                }
                else
                {
                    jABInputTextIntoElement["MatchIndexAscending"] = true;
                    jABInputTextIntoElementpropCount++;
                }

                if (jABInputTextIntoElementcaseSensitiveSearch != null)
                {
                    if (jABInputTextIntoElementcaseSensitiveSearch != null)
                    {
                        jABInputTextIntoElement["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABInputTextIntoElementcaseSensitiveSearch);
                        jABInputTextIntoElementpropCount++;
                    }

                    jABInputTextIntoElementpropCount++;
                }
                else
                {
                    jABInputTextIntoElement["CaseSensitiveSearch"] = false;
                    jABInputTextIntoElementpropCount++;
                }

                if (jABInputTextIntoElementonlySearchVisibleElements != null)
                {
                    if (jABInputTextIntoElementonlySearchVisibleElements != null)
                    {
                        jABInputTextIntoElement["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABInputTextIntoElementonlySearchVisibleElements);
                        jABInputTextIntoElementpropCount++;
                    }

                    jABInputTextIntoElementpropCount++;
                }
                else
                {
                    jABInputTextIntoElement["OnlySearchVisibleElements"] = true;
                    jABInputTextIntoElementpropCount++;
                }

                if (jABInputTextIntoElementonlySearchShowingElements != null)
                {
                    if (jABInputTextIntoElementonlySearchShowingElements != null)
                    {
                        jABInputTextIntoElement["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABInputTextIntoElementonlySearchShowingElements);
                        jABInputTextIntoElementpropCount++;
                    }

                    jABInputTextIntoElementpropCount++;
                }
                else
                {
                    jABInputTextIntoElement["OnlySearchShowingElements"] = true;
                    jABInputTextIntoElementpropCount++;
                }

                if (jABInputTextIntoElementelementRolesNotToTraverse != null)
                {
                    jABInputTextIntoElement["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABInputTextIntoElementelementRolesNotToTraverse);
                    jABInputTextIntoElementpropCount++;
                }

                if (jABInputTextIntoElementmaximumElementsToSearch != null)
                {
                    if (jABInputTextIntoElementmaximumElementsToSearch != null)
                    {
                        jABInputTextIntoElement["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABInputTextIntoElementmaximumElementsToSearch);
                        jABInputTextIntoElementpropCount++;
                    }

                    jABInputTextIntoElementpropCount++;
                }
                else
                {
                    jABInputTextIntoElement["MaximumElementsToSearch"] = 2000;
                    jABInputTextIntoElementpropCount++;
                }

                if (jABInputTextIntoElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABInputTextIntoElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABInputTextIntoElement["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABInputTextIntoElementmaximumChildElementsToSearchPerNode);
                        jABInputTextIntoElementpropCount++;
                    }

                    jABInputTextIntoElementpropCount++;
                }
                else
                {
                    jABInputTextIntoElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABInputTextIntoElementpropCount++;
                }

                if (jABInputTextIntoElementtextToInput != null)
                {
                    jABInputTextIntoElement["TextToInput"] = SourceExpressionConverter.ConvertToken(jABInputTextIntoElementtextToInput);
                    jABInputTextIntoElementpropCount++;
                }

                if (jABInputTextIntoElementreplaceExistingValue != null)
                {
                    if (jABInputTextIntoElementreplaceExistingValue != null)
                    {
                        jABInputTextIntoElement["ReplaceExistingValue"] = SourceExpressionConverter.ConvertToken(jABInputTextIntoElementreplaceExistingValue);
                        jABInputTextIntoElementpropCount++;
                    }

                    jABInputTextIntoElementpropCount++;
                }
                else
                {
                    jABInputTextIntoElement["ReplaceExistingValue"] = true;
                    jABInputTextIntoElementpropCount++;
                }

                if (jABInputTextIntoElementinsertPosition != null)
                {
                    if (jABInputTextIntoElementinsertPosition != null)
                    {
                        jABInputTextIntoElement["InsertPosition"] = SourceExpressionConverter.ConvertToken(jABInputTextIntoElementinsertPosition);
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
                jABInputTextIntoElement["Workflow"] = SourceExpressionConverter.ConvertToken(jABInputTextIntoElementworkflow);
                if (jABInputTextIntoElementpropCount > 0)
                {
                    callPayload.Body = jABInputTextIntoElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetElementTextValueResponse> JABGetElementTextValue([WorkflowExpression] Func<int> jABGetElementTextValuesearchParentElementJABHandle, [WorkflowExpression] Func<string> jABGetElementTextValueworkflow, [WorkflowExpression] Func<string> jABGetElementTextValuesearchElementJABName = null, [WorkflowExpression] Func<string> jABGetElementTextValuesearchElementJABDescription = null, [WorkflowExpression] Func<string> jABGetElementTextValuesearchElementJABRole = null, [WorkflowExpression] Func<bool> jABGetElementTextValuesearchSubTree = null, [WorkflowExpression] Func<int> jABGetElementTextValuemaxRelativeDepth = null, [WorkflowExpression] Func<int> jABGetElementTextValuematchIndex = null, [WorkflowExpression] Func<string> jABGetElementTextValuesearchFilter = null, [WorkflowExpression] Func<string> jABGetElementTextValuesortByColumn = null, [WorkflowExpression] Func<bool> jABGetElementTextValuematchIndexAscending = null, [WorkflowExpression] Func<bool> jABGetElementTextValuecaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABGetElementTextValueonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABGetElementTextValueonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABGetElementTextValueelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABGetElementTextValuemaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABGetElementTextValuemaximumChildElementsToSearchPerNode = null)
        {
            SourceExpression.Validate(jABGetElementTextValuesearchParentElementJABHandle, nameof(jABGetElementTextValuesearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABGetElementTextValueworkflow, nameof(jABGetElementTextValueworkflow), required: true);
            SourceExpression.Validate(jABGetElementTextValuesearchElementJABName, nameof(jABGetElementTextValuesearchElementJABName), required: false);
            SourceExpression.Validate(jABGetElementTextValuesearchElementJABDescription, nameof(jABGetElementTextValuesearchElementJABDescription), required: false);
            SourceExpression.Validate(jABGetElementTextValuesearchElementJABRole, nameof(jABGetElementTextValuesearchElementJABRole), required: false);
            SourceExpression.Validate(jABGetElementTextValuesearchSubTree, nameof(jABGetElementTextValuesearchSubTree), required: false);
            SourceExpression.Validate(jABGetElementTextValuemaxRelativeDepth, nameof(jABGetElementTextValuemaxRelativeDepth), required: false);
            SourceExpression.Validate(jABGetElementTextValuematchIndex, nameof(jABGetElementTextValuematchIndex), required: false);
            SourceExpression.Validate(jABGetElementTextValuesearchFilter, nameof(jABGetElementTextValuesearchFilter), required: false);
            SourceExpression.Validate(jABGetElementTextValuesortByColumn, nameof(jABGetElementTextValuesortByColumn), required: false);
            SourceExpression.Validate(jABGetElementTextValuematchIndexAscending, nameof(jABGetElementTextValuematchIndexAscending), required: false);
            SourceExpression.Validate(jABGetElementTextValuecaseSensitiveSearch, nameof(jABGetElementTextValuecaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABGetElementTextValueonlySearchVisibleElements, nameof(jABGetElementTextValueonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABGetElementTextValueonlySearchShowingElements, nameof(jABGetElementTextValueonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABGetElementTextValueelementRolesNotToTraverse, nameof(jABGetElementTextValueelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABGetElementTextValuemaximumElementsToSearch, nameof(jABGetElementTextValuemaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABGetElementTextValuemaximumChildElementsToSearchPerNode, nameof(jABGetElementTextValuemaximumChildElementsToSearchPerNode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetElementTextValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetElementTextValue = new JObject();
                var jABGetElementTextValuepropCount = 0;
                jABGetElementTextValuepropCount++;
                jABGetElementTextValue["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGetElementTextValuesearchParentElementJABHandle);
                if (jABGetElementTextValuesearchElementJABName != null)
                {
                    jABGetElementTextValue["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABGetElementTextValuesearchElementJABName);
                    jABGetElementTextValuepropCount++;
                }

                if (jABGetElementTextValuesearchElementJABDescription != null)
                {
                    jABGetElementTextValue["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABGetElementTextValuesearchElementJABDescription);
                    jABGetElementTextValuepropCount++;
                }

                if (jABGetElementTextValuesearchElementJABRole != null)
                {
                    jABGetElementTextValue["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABGetElementTextValuesearchElementJABRole);
                    jABGetElementTextValuepropCount++;
                }

                if (jABGetElementTextValuesearchSubTree != null)
                {
                    if (jABGetElementTextValuesearchSubTree != null)
                    {
                        jABGetElementTextValue["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABGetElementTextValuesearchSubTree);
                        jABGetElementTextValuepropCount++;
                    }

                    jABGetElementTextValuepropCount++;
                }
                else
                {
                    jABGetElementTextValue["SearchSubTree"] = true;
                    jABGetElementTextValuepropCount++;
                }

                if (jABGetElementTextValuemaxRelativeDepth != null)
                {
                    if (jABGetElementTextValuemaxRelativeDepth != null)
                    {
                        jABGetElementTextValue["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABGetElementTextValuemaxRelativeDepth);
                        jABGetElementTextValuepropCount++;
                    }

                    jABGetElementTextValuepropCount++;
                }
                else
                {
                    jABGetElementTextValue["MaxRelativeDepth"] = 0;
                    jABGetElementTextValuepropCount++;
                }

                if (jABGetElementTextValuematchIndex != null)
                {
                    if (jABGetElementTextValuematchIndex != null)
                    {
                        jABGetElementTextValue["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABGetElementTextValuematchIndex);
                        jABGetElementTextValuepropCount++;
                    }

                    jABGetElementTextValuepropCount++;
                }
                else
                {
                    jABGetElementTextValue["MatchIndex"] = 1;
                    jABGetElementTextValuepropCount++;
                }

                if (jABGetElementTextValuesearchFilter != null)
                {
                    jABGetElementTextValue["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABGetElementTextValuesearchFilter);
                    jABGetElementTextValuepropCount++;
                }

                if (jABGetElementTextValuesortByColumn != null)
                {
                    jABGetElementTextValue["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABGetElementTextValuesortByColumn);
                    jABGetElementTextValuepropCount++;
                }

                if (jABGetElementTextValuematchIndexAscending != null)
                {
                    if (jABGetElementTextValuematchIndexAscending != null)
                    {
                        jABGetElementTextValue["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABGetElementTextValuematchIndexAscending);
                        jABGetElementTextValuepropCount++;
                    }

                    jABGetElementTextValuepropCount++;
                }
                else
                {
                    jABGetElementTextValue["MatchIndexAscending"] = true;
                    jABGetElementTextValuepropCount++;
                }

                if (jABGetElementTextValuecaseSensitiveSearch != null)
                {
                    if (jABGetElementTextValuecaseSensitiveSearch != null)
                    {
                        jABGetElementTextValue["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABGetElementTextValuecaseSensitiveSearch);
                        jABGetElementTextValuepropCount++;
                    }

                    jABGetElementTextValuepropCount++;
                }
                else
                {
                    jABGetElementTextValue["CaseSensitiveSearch"] = false;
                    jABGetElementTextValuepropCount++;
                }

                if (jABGetElementTextValueonlySearchVisibleElements != null)
                {
                    if (jABGetElementTextValueonlySearchVisibleElements != null)
                    {
                        jABGetElementTextValue["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABGetElementTextValueonlySearchVisibleElements);
                        jABGetElementTextValuepropCount++;
                    }

                    jABGetElementTextValuepropCount++;
                }
                else
                {
                    jABGetElementTextValue["OnlySearchVisibleElements"] = true;
                    jABGetElementTextValuepropCount++;
                }

                if (jABGetElementTextValueonlySearchShowingElements != null)
                {
                    if (jABGetElementTextValueonlySearchShowingElements != null)
                    {
                        jABGetElementTextValue["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABGetElementTextValueonlySearchShowingElements);
                        jABGetElementTextValuepropCount++;
                    }

                    jABGetElementTextValuepropCount++;
                }
                else
                {
                    jABGetElementTextValue["OnlySearchShowingElements"] = true;
                    jABGetElementTextValuepropCount++;
                }

                if (jABGetElementTextValueelementRolesNotToTraverse != null)
                {
                    jABGetElementTextValue["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABGetElementTextValueelementRolesNotToTraverse);
                    jABGetElementTextValuepropCount++;
                }

                if (jABGetElementTextValuemaximumElementsToSearch != null)
                {
                    if (jABGetElementTextValuemaximumElementsToSearch != null)
                    {
                        jABGetElementTextValue["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABGetElementTextValuemaximumElementsToSearch);
                        jABGetElementTextValuepropCount++;
                    }

                    jABGetElementTextValuepropCount++;
                }
                else
                {
                    jABGetElementTextValue["MaximumElementsToSearch"] = 2000;
                    jABGetElementTextValuepropCount++;
                }

                if (jABGetElementTextValuemaximumChildElementsToSearchPerNode != null)
                {
                    if (jABGetElementTextValuemaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetElementTextValue["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABGetElementTextValuemaximumChildElementsToSearchPerNode);
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
                jABGetElementTextValue["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetElementTextValueworkflow);
                if (jABGetElementTextValuepropCount > 0)
                {
                    callPayload.Body = jABGetElementTextValue;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetElementTextValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetElementValueResponse> JABGetElementValue([WorkflowExpression] Func<int> jABGetElementValuesearchParentElementJABHandle, [WorkflowExpression] Func<string> jABGetElementValueworkflow, [WorkflowExpression] Func<string> jABGetElementValuesearchElementJABName = null, [WorkflowExpression] Func<string> jABGetElementValuesearchElementJABDescription = null, [WorkflowExpression] Func<string> jABGetElementValuesearchElementJABRole = null, [WorkflowExpression] Func<bool> jABGetElementValuesearchSubTree = null, [WorkflowExpression] Func<int> jABGetElementValuemaxRelativeDepth = null, [WorkflowExpression] Func<int> jABGetElementValuematchIndex = null, [WorkflowExpression] Func<string> jABGetElementValuesearchFilter = null, [WorkflowExpression] Func<string> jABGetElementValuesortByColumn = null, [WorkflowExpression] Func<bool> jABGetElementValuematchIndexAscending = null, [WorkflowExpression] Func<bool> jABGetElementValuecaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABGetElementValueonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABGetElementValueonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABGetElementValueelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABGetElementValuemaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABGetElementValuemaximumChildElementsToSearchPerNode = null)
        {
            SourceExpression.Validate(jABGetElementValuesearchParentElementJABHandle, nameof(jABGetElementValuesearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABGetElementValueworkflow, nameof(jABGetElementValueworkflow), required: true);
            SourceExpression.Validate(jABGetElementValuesearchElementJABName, nameof(jABGetElementValuesearchElementJABName), required: false);
            SourceExpression.Validate(jABGetElementValuesearchElementJABDescription, nameof(jABGetElementValuesearchElementJABDescription), required: false);
            SourceExpression.Validate(jABGetElementValuesearchElementJABRole, nameof(jABGetElementValuesearchElementJABRole), required: false);
            SourceExpression.Validate(jABGetElementValuesearchSubTree, nameof(jABGetElementValuesearchSubTree), required: false);
            SourceExpression.Validate(jABGetElementValuemaxRelativeDepth, nameof(jABGetElementValuemaxRelativeDepth), required: false);
            SourceExpression.Validate(jABGetElementValuematchIndex, nameof(jABGetElementValuematchIndex), required: false);
            SourceExpression.Validate(jABGetElementValuesearchFilter, nameof(jABGetElementValuesearchFilter), required: false);
            SourceExpression.Validate(jABGetElementValuesortByColumn, nameof(jABGetElementValuesortByColumn), required: false);
            SourceExpression.Validate(jABGetElementValuematchIndexAscending, nameof(jABGetElementValuematchIndexAscending), required: false);
            SourceExpression.Validate(jABGetElementValuecaseSensitiveSearch, nameof(jABGetElementValuecaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABGetElementValueonlySearchVisibleElements, nameof(jABGetElementValueonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABGetElementValueonlySearchShowingElements, nameof(jABGetElementValueonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABGetElementValueelementRolesNotToTraverse, nameof(jABGetElementValueelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABGetElementValuemaximumElementsToSearch, nameof(jABGetElementValuemaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABGetElementValuemaximumChildElementsToSearchPerNode, nameof(jABGetElementValuemaximumChildElementsToSearchPerNode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetElementValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetElementValue = new JObject();
                var jABGetElementValuepropCount = 0;
                jABGetElementValuepropCount++;
                jABGetElementValue["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGetElementValuesearchParentElementJABHandle);
                if (jABGetElementValuesearchElementJABName != null)
                {
                    jABGetElementValue["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABGetElementValuesearchElementJABName);
                    jABGetElementValuepropCount++;
                }

                if (jABGetElementValuesearchElementJABDescription != null)
                {
                    jABGetElementValue["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABGetElementValuesearchElementJABDescription);
                    jABGetElementValuepropCount++;
                }

                if (jABGetElementValuesearchElementJABRole != null)
                {
                    jABGetElementValue["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABGetElementValuesearchElementJABRole);
                    jABGetElementValuepropCount++;
                }

                if (jABGetElementValuesearchSubTree != null)
                {
                    if (jABGetElementValuesearchSubTree != null)
                    {
                        jABGetElementValue["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABGetElementValuesearchSubTree);
                        jABGetElementValuepropCount++;
                    }

                    jABGetElementValuepropCount++;
                }
                else
                {
                    jABGetElementValue["SearchSubTree"] = true;
                    jABGetElementValuepropCount++;
                }

                if (jABGetElementValuemaxRelativeDepth != null)
                {
                    if (jABGetElementValuemaxRelativeDepth != null)
                    {
                        jABGetElementValue["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABGetElementValuemaxRelativeDepth);
                        jABGetElementValuepropCount++;
                    }

                    jABGetElementValuepropCount++;
                }
                else
                {
                    jABGetElementValue["MaxRelativeDepth"] = 0;
                    jABGetElementValuepropCount++;
                }

                if (jABGetElementValuematchIndex != null)
                {
                    if (jABGetElementValuematchIndex != null)
                    {
                        jABGetElementValue["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABGetElementValuematchIndex);
                        jABGetElementValuepropCount++;
                    }

                    jABGetElementValuepropCount++;
                }
                else
                {
                    jABGetElementValue["MatchIndex"] = 1;
                    jABGetElementValuepropCount++;
                }

                if (jABGetElementValuesearchFilter != null)
                {
                    jABGetElementValue["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABGetElementValuesearchFilter);
                    jABGetElementValuepropCount++;
                }

                if (jABGetElementValuesortByColumn != null)
                {
                    jABGetElementValue["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABGetElementValuesortByColumn);
                    jABGetElementValuepropCount++;
                }

                if (jABGetElementValuematchIndexAscending != null)
                {
                    if (jABGetElementValuematchIndexAscending != null)
                    {
                        jABGetElementValue["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABGetElementValuematchIndexAscending);
                        jABGetElementValuepropCount++;
                    }

                    jABGetElementValuepropCount++;
                }
                else
                {
                    jABGetElementValue["MatchIndexAscending"] = true;
                    jABGetElementValuepropCount++;
                }

                if (jABGetElementValuecaseSensitiveSearch != null)
                {
                    if (jABGetElementValuecaseSensitiveSearch != null)
                    {
                        jABGetElementValue["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABGetElementValuecaseSensitiveSearch);
                        jABGetElementValuepropCount++;
                    }

                    jABGetElementValuepropCount++;
                }
                else
                {
                    jABGetElementValue["CaseSensitiveSearch"] = false;
                    jABGetElementValuepropCount++;
                }

                if (jABGetElementValueonlySearchVisibleElements != null)
                {
                    if (jABGetElementValueonlySearchVisibleElements != null)
                    {
                        jABGetElementValue["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABGetElementValueonlySearchVisibleElements);
                        jABGetElementValuepropCount++;
                    }

                    jABGetElementValuepropCount++;
                }
                else
                {
                    jABGetElementValue["OnlySearchVisibleElements"] = true;
                    jABGetElementValuepropCount++;
                }

                if (jABGetElementValueonlySearchShowingElements != null)
                {
                    if (jABGetElementValueonlySearchShowingElements != null)
                    {
                        jABGetElementValue["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABGetElementValueonlySearchShowingElements);
                        jABGetElementValuepropCount++;
                    }

                    jABGetElementValuepropCount++;
                }
                else
                {
                    jABGetElementValue["OnlySearchShowingElements"] = true;
                    jABGetElementValuepropCount++;
                }

                if (jABGetElementValueelementRolesNotToTraverse != null)
                {
                    jABGetElementValue["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABGetElementValueelementRolesNotToTraverse);
                    jABGetElementValuepropCount++;
                }

                if (jABGetElementValuemaximumElementsToSearch != null)
                {
                    if (jABGetElementValuemaximumElementsToSearch != null)
                    {
                        jABGetElementValue["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABGetElementValuemaximumElementsToSearch);
                        jABGetElementValuepropCount++;
                    }

                    jABGetElementValuepropCount++;
                }
                else
                {
                    jABGetElementValue["MaximumElementsToSearch"] = 2000;
                    jABGetElementValuepropCount++;
                }

                if (jABGetElementValuemaximumChildElementsToSearchPerNode != null)
                {
                    if (jABGetElementValuemaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetElementValue["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABGetElementValuemaximumChildElementsToSearchPerNode);
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
                jABGetElementValue["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetElementValueworkflow);
                if (jABGetElementValuepropCount > 0)
                {
                    callPayload.Body = jABGetElementValue;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetElementValueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABCheckElement([WorkflowExpression] Func<int> jABCheckElementsearchParentElementJABHandle, [WorkflowExpression] Func<string> jABCheckElementworkflow, [WorkflowExpression] Func<string> jABCheckElementsearchElementJABName = null, [WorkflowExpression] Func<string> jABCheckElementsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABCheckElementsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABCheckElementsearchSubTree = null, [WorkflowExpression] Func<int> jABCheckElementmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABCheckElementmatchIndex = null, [WorkflowExpression] Func<string> jABCheckElementsearchFilter = null, [WorkflowExpression] Func<string> jABCheckElementsortByColumn = null, [WorkflowExpression] Func<bool> jABCheckElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABCheckElementcaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABCheckElementonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABCheckElementonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABCheckElementelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABCheckElementmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABCheckElementmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<bool> jABCheckElementcheckElement = null, [WorkflowExpression] Func<bool> jABCheckElementautoDetectActionName = null, [WorkflowExpression] Func<string> jABCheckElementoverrideActionName = null)
        {
            SourceExpression.Validate(jABCheckElementsearchParentElementJABHandle, nameof(jABCheckElementsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABCheckElementworkflow, nameof(jABCheckElementworkflow), required: true);
            SourceExpression.Validate(jABCheckElementsearchElementJABName, nameof(jABCheckElementsearchElementJABName), required: false);
            SourceExpression.Validate(jABCheckElementsearchElementJABDescription, nameof(jABCheckElementsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABCheckElementsearchElementJABRole, nameof(jABCheckElementsearchElementJABRole), required: false);
            SourceExpression.Validate(jABCheckElementsearchSubTree, nameof(jABCheckElementsearchSubTree), required: false);
            SourceExpression.Validate(jABCheckElementmaxRelativeDepth, nameof(jABCheckElementmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABCheckElementmatchIndex, nameof(jABCheckElementmatchIndex), required: false);
            SourceExpression.Validate(jABCheckElementsearchFilter, nameof(jABCheckElementsearchFilter), required: false);
            SourceExpression.Validate(jABCheckElementsortByColumn, nameof(jABCheckElementsortByColumn), required: false);
            SourceExpression.Validate(jABCheckElementmatchIndexAscending, nameof(jABCheckElementmatchIndexAscending), required: false);
            SourceExpression.Validate(jABCheckElementcaseSensitiveSearch, nameof(jABCheckElementcaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABCheckElementonlySearchVisibleElements, nameof(jABCheckElementonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABCheckElementonlySearchShowingElements, nameof(jABCheckElementonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABCheckElementelementRolesNotToTraverse, nameof(jABCheckElementelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABCheckElementmaximumElementsToSearch, nameof(jABCheckElementmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABCheckElementmaximumChildElementsToSearchPerNode, nameof(jABCheckElementmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABCheckElementcheckElement, nameof(jABCheckElementcheckElement), required: false);
            SourceExpression.Validate(jABCheckElementautoDetectActionName, nameof(jABCheckElementautoDetectActionName), required: false);
            SourceExpression.Validate(jABCheckElementoverrideActionName, nameof(jABCheckElementoverrideActionName), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABCheckElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABCheckElement = new JObject();
                var jABCheckElementpropCount = 0;
                jABCheckElementpropCount++;
                jABCheckElement["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABCheckElementsearchParentElementJABHandle);
                if (jABCheckElementsearchElementJABName != null)
                {
                    jABCheckElement["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABCheckElementsearchElementJABName);
                    jABCheckElementpropCount++;
                }

                if (jABCheckElementsearchElementJABDescription != null)
                {
                    jABCheckElement["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABCheckElementsearchElementJABDescription);
                    jABCheckElementpropCount++;
                }

                if (jABCheckElementsearchElementJABRole != null)
                {
                    jABCheckElement["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABCheckElementsearchElementJABRole);
                    jABCheckElementpropCount++;
                }

                if (jABCheckElementsearchSubTree != null)
                {
                    if (jABCheckElementsearchSubTree != null)
                    {
                        jABCheckElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABCheckElementsearchSubTree);
                        jABCheckElementpropCount++;
                    }

                    jABCheckElementpropCount++;
                }
                else
                {
                    jABCheckElement["SearchSubTree"] = true;
                    jABCheckElementpropCount++;
                }

                if (jABCheckElementmaxRelativeDepth != null)
                {
                    if (jABCheckElementmaxRelativeDepth != null)
                    {
                        jABCheckElement["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABCheckElementmaxRelativeDepth);
                        jABCheckElementpropCount++;
                    }

                    jABCheckElementpropCount++;
                }
                else
                {
                    jABCheckElement["MaxRelativeDepth"] = 0;
                    jABCheckElementpropCount++;
                }

                if (jABCheckElementmatchIndex != null)
                {
                    if (jABCheckElementmatchIndex != null)
                    {
                        jABCheckElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABCheckElementmatchIndex);
                        jABCheckElementpropCount++;
                    }

                    jABCheckElementpropCount++;
                }
                else
                {
                    jABCheckElement["MatchIndex"] = 1;
                    jABCheckElementpropCount++;
                }

                if (jABCheckElementsearchFilter != null)
                {
                    jABCheckElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABCheckElementsearchFilter);
                    jABCheckElementpropCount++;
                }

                if (jABCheckElementsortByColumn != null)
                {
                    jABCheckElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABCheckElementsortByColumn);
                    jABCheckElementpropCount++;
                }

                if (jABCheckElementmatchIndexAscending != null)
                {
                    if (jABCheckElementmatchIndexAscending != null)
                    {
                        jABCheckElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABCheckElementmatchIndexAscending);
                        jABCheckElementpropCount++;
                    }

                    jABCheckElementpropCount++;
                }
                else
                {
                    jABCheckElement["MatchIndexAscending"] = true;
                    jABCheckElementpropCount++;
                }

                if (jABCheckElementcaseSensitiveSearch != null)
                {
                    if (jABCheckElementcaseSensitiveSearch != null)
                    {
                        jABCheckElement["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABCheckElementcaseSensitiveSearch);
                        jABCheckElementpropCount++;
                    }

                    jABCheckElementpropCount++;
                }
                else
                {
                    jABCheckElement["CaseSensitiveSearch"] = false;
                    jABCheckElementpropCount++;
                }

                if (jABCheckElementonlySearchVisibleElements != null)
                {
                    if (jABCheckElementonlySearchVisibleElements != null)
                    {
                        jABCheckElement["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABCheckElementonlySearchVisibleElements);
                        jABCheckElementpropCount++;
                    }

                    jABCheckElementpropCount++;
                }
                else
                {
                    jABCheckElement["OnlySearchVisibleElements"] = true;
                    jABCheckElementpropCount++;
                }

                if (jABCheckElementonlySearchShowingElements != null)
                {
                    if (jABCheckElementonlySearchShowingElements != null)
                    {
                        jABCheckElement["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABCheckElementonlySearchShowingElements);
                        jABCheckElementpropCount++;
                    }

                    jABCheckElementpropCount++;
                }
                else
                {
                    jABCheckElement["OnlySearchShowingElements"] = true;
                    jABCheckElementpropCount++;
                }

                if (jABCheckElementelementRolesNotToTraverse != null)
                {
                    jABCheckElement["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABCheckElementelementRolesNotToTraverse);
                    jABCheckElementpropCount++;
                }

                if (jABCheckElementmaximumElementsToSearch != null)
                {
                    if (jABCheckElementmaximumElementsToSearch != null)
                    {
                        jABCheckElement["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABCheckElementmaximumElementsToSearch);
                        jABCheckElementpropCount++;
                    }

                    jABCheckElementpropCount++;
                }
                else
                {
                    jABCheckElement["MaximumElementsToSearch"] = 2000;
                    jABCheckElementpropCount++;
                }

                if (jABCheckElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABCheckElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABCheckElement["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABCheckElementmaximumChildElementsToSearchPerNode);
                        jABCheckElementpropCount++;
                    }

                    jABCheckElementpropCount++;
                }
                else
                {
                    jABCheckElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABCheckElementpropCount++;
                }

                if (jABCheckElementcheckElement != null)
                {
                    if (jABCheckElementcheckElement != null)
                    {
                        jABCheckElement["CheckElement"] = SourceExpressionConverter.ConvertToken(jABCheckElementcheckElement);
                        jABCheckElementpropCount++;
                    }

                    jABCheckElementpropCount++;
                }
                else
                {
                    jABCheckElement["CheckElement"] = true;
                    jABCheckElementpropCount++;
                }

                if (jABCheckElementautoDetectActionName != null)
                {
                    if (jABCheckElementautoDetectActionName != null)
                    {
                        jABCheckElement["AutoDetectActionName"] = SourceExpressionConverter.ConvertToken(jABCheckElementautoDetectActionName);
                        jABCheckElementpropCount++;
                    }

                    jABCheckElementpropCount++;
                }
                else
                {
                    jABCheckElement["AutoDetectActionName"] = true;
                    jABCheckElementpropCount++;
                }

                if (jABCheckElementoverrideActionName != null)
                {
                    jABCheckElement["OverrideActionName"] = SourceExpressionConverter.ConvertToken(jABCheckElementoverrideActionName);
                    jABCheckElementpropCount++;
                }

                jABCheckElementpropCount++;
                jABCheckElement["Workflow"] = SourceExpressionConverter.ConvertToken(jABCheckElementworkflow);
                if (jABCheckElementpropCount > 0)
                {
                    callPayload.Body = jABCheckElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetElementPropertiesAsListResponse> JABGetElementPropertiesAsList([WorkflowExpression] Func<int> jABGetElementPropertiesAsListsearchParentElementJABHandle, [WorkflowExpression] Func<string> jABGetElementPropertiesAsListworkflow, [WorkflowExpression] Func<string> jABGetElementPropertiesAsListsearchElementJABName = null, [WorkflowExpression] Func<string> jABGetElementPropertiesAsListsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABGetElementPropertiesAsListsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABGetElementPropertiesAsListsearchSubTree = null, [WorkflowExpression] Func<int> jABGetElementPropertiesAsListmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABGetElementPropertiesAsListmatchIndex = null, [WorkflowExpression] Func<string> jABGetElementPropertiesAsListsearchFilter = null, [WorkflowExpression] Func<string> jABGetElementPropertiesAsListsortByColumn = null, [WorkflowExpression] Func<bool> jABGetElementPropertiesAsListmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABGetElementPropertiesAsListcaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABGetElementPropertiesAsListonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABGetElementPropertiesAsListonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABGetElementPropertiesAsListelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABGetElementPropertiesAsListmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABGetElementPropertiesAsListmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<int> jABGetElementPropertiesAsListmaxStringLength = null)
        {
            SourceExpression.Validate(jABGetElementPropertiesAsListsearchParentElementJABHandle, nameof(jABGetElementPropertiesAsListsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABGetElementPropertiesAsListworkflow, nameof(jABGetElementPropertiesAsListworkflow), required: true);
            SourceExpression.Validate(jABGetElementPropertiesAsListsearchElementJABName, nameof(jABGetElementPropertiesAsListsearchElementJABName), required: false);
            SourceExpression.Validate(jABGetElementPropertiesAsListsearchElementJABDescription, nameof(jABGetElementPropertiesAsListsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABGetElementPropertiesAsListsearchElementJABRole, nameof(jABGetElementPropertiesAsListsearchElementJABRole), required: false);
            SourceExpression.Validate(jABGetElementPropertiesAsListsearchSubTree, nameof(jABGetElementPropertiesAsListsearchSubTree), required: false);
            SourceExpression.Validate(jABGetElementPropertiesAsListmaxRelativeDepth, nameof(jABGetElementPropertiesAsListmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABGetElementPropertiesAsListmatchIndex, nameof(jABGetElementPropertiesAsListmatchIndex), required: false);
            SourceExpression.Validate(jABGetElementPropertiesAsListsearchFilter, nameof(jABGetElementPropertiesAsListsearchFilter), required: false);
            SourceExpression.Validate(jABGetElementPropertiesAsListsortByColumn, nameof(jABGetElementPropertiesAsListsortByColumn), required: false);
            SourceExpression.Validate(jABGetElementPropertiesAsListmatchIndexAscending, nameof(jABGetElementPropertiesAsListmatchIndexAscending), required: false);
            SourceExpression.Validate(jABGetElementPropertiesAsListcaseSensitiveSearch, nameof(jABGetElementPropertiesAsListcaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABGetElementPropertiesAsListonlySearchVisibleElements, nameof(jABGetElementPropertiesAsListonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABGetElementPropertiesAsListonlySearchShowingElements, nameof(jABGetElementPropertiesAsListonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABGetElementPropertiesAsListelementRolesNotToTraverse, nameof(jABGetElementPropertiesAsListelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABGetElementPropertiesAsListmaximumElementsToSearch, nameof(jABGetElementPropertiesAsListmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABGetElementPropertiesAsListmaximumChildElementsToSearchPerNode, nameof(jABGetElementPropertiesAsListmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABGetElementPropertiesAsListmaxStringLength, nameof(jABGetElementPropertiesAsListmaxStringLength), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetElementPropertiesAsList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetElementPropertiesAsList = new JObject();
                var jABGetElementPropertiesAsListpropCount = 0;
                jABGetElementPropertiesAsListpropCount++;
                jABGetElementPropertiesAsList["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGetElementPropertiesAsListsearchParentElementJABHandle);
                if (jABGetElementPropertiesAsListsearchElementJABName != null)
                {
                    jABGetElementPropertiesAsList["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABGetElementPropertiesAsListsearchElementJABName);
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (jABGetElementPropertiesAsListsearchElementJABDescription != null)
                {
                    jABGetElementPropertiesAsList["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABGetElementPropertiesAsListsearchElementJABDescription);
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (jABGetElementPropertiesAsListsearchElementJABRole != null)
                {
                    jABGetElementPropertiesAsList["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABGetElementPropertiesAsListsearchElementJABRole);
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (jABGetElementPropertiesAsListsearchSubTree != null)
                {
                    if (jABGetElementPropertiesAsListsearchSubTree != null)
                    {
                        jABGetElementPropertiesAsList["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABGetElementPropertiesAsListsearchSubTree);
                        jABGetElementPropertiesAsListpropCount++;
                    }

                    jABGetElementPropertiesAsListpropCount++;
                }
                else
                {
                    jABGetElementPropertiesAsList["SearchSubTree"] = true;
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (jABGetElementPropertiesAsListmaxRelativeDepth != null)
                {
                    if (jABGetElementPropertiesAsListmaxRelativeDepth != null)
                    {
                        jABGetElementPropertiesAsList["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABGetElementPropertiesAsListmaxRelativeDepth);
                        jABGetElementPropertiesAsListpropCount++;
                    }

                    jABGetElementPropertiesAsListpropCount++;
                }
                else
                {
                    jABGetElementPropertiesAsList["MaxRelativeDepth"] = 0;
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (jABGetElementPropertiesAsListmatchIndex != null)
                {
                    if (jABGetElementPropertiesAsListmatchIndex != null)
                    {
                        jABGetElementPropertiesAsList["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABGetElementPropertiesAsListmatchIndex);
                        jABGetElementPropertiesAsListpropCount++;
                    }

                    jABGetElementPropertiesAsListpropCount++;
                }
                else
                {
                    jABGetElementPropertiesAsList["MatchIndex"] = 1;
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (jABGetElementPropertiesAsListsearchFilter != null)
                {
                    jABGetElementPropertiesAsList["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABGetElementPropertiesAsListsearchFilter);
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (jABGetElementPropertiesAsListsortByColumn != null)
                {
                    jABGetElementPropertiesAsList["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABGetElementPropertiesAsListsortByColumn);
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (jABGetElementPropertiesAsListmatchIndexAscending != null)
                {
                    if (jABGetElementPropertiesAsListmatchIndexAscending != null)
                    {
                        jABGetElementPropertiesAsList["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABGetElementPropertiesAsListmatchIndexAscending);
                        jABGetElementPropertiesAsListpropCount++;
                    }

                    jABGetElementPropertiesAsListpropCount++;
                }
                else
                {
                    jABGetElementPropertiesAsList["MatchIndexAscending"] = true;
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (jABGetElementPropertiesAsListcaseSensitiveSearch != null)
                {
                    if (jABGetElementPropertiesAsListcaseSensitiveSearch != null)
                    {
                        jABGetElementPropertiesAsList["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABGetElementPropertiesAsListcaseSensitiveSearch);
                        jABGetElementPropertiesAsListpropCount++;
                    }

                    jABGetElementPropertiesAsListpropCount++;
                }
                else
                {
                    jABGetElementPropertiesAsList["CaseSensitiveSearch"] = false;
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (jABGetElementPropertiesAsListonlySearchVisibleElements != null)
                {
                    if (jABGetElementPropertiesAsListonlySearchVisibleElements != null)
                    {
                        jABGetElementPropertiesAsList["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABGetElementPropertiesAsListonlySearchVisibleElements);
                        jABGetElementPropertiesAsListpropCount++;
                    }

                    jABGetElementPropertiesAsListpropCount++;
                }
                else
                {
                    jABGetElementPropertiesAsList["OnlySearchVisibleElements"] = true;
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (jABGetElementPropertiesAsListonlySearchShowingElements != null)
                {
                    if (jABGetElementPropertiesAsListonlySearchShowingElements != null)
                    {
                        jABGetElementPropertiesAsList["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABGetElementPropertiesAsListonlySearchShowingElements);
                        jABGetElementPropertiesAsListpropCount++;
                    }

                    jABGetElementPropertiesAsListpropCount++;
                }
                else
                {
                    jABGetElementPropertiesAsList["OnlySearchShowingElements"] = true;
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (jABGetElementPropertiesAsListelementRolesNotToTraverse != null)
                {
                    jABGetElementPropertiesAsList["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABGetElementPropertiesAsListelementRolesNotToTraverse);
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (jABGetElementPropertiesAsListmaximumElementsToSearch != null)
                {
                    if (jABGetElementPropertiesAsListmaximumElementsToSearch != null)
                    {
                        jABGetElementPropertiesAsList["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABGetElementPropertiesAsListmaximumElementsToSearch);
                        jABGetElementPropertiesAsListpropCount++;
                    }

                    jABGetElementPropertiesAsListpropCount++;
                }
                else
                {
                    jABGetElementPropertiesAsList["MaximumElementsToSearch"] = 2000;
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (jABGetElementPropertiesAsListmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABGetElementPropertiesAsListmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetElementPropertiesAsList["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABGetElementPropertiesAsListmaximumChildElementsToSearchPerNode);
                        jABGetElementPropertiesAsListpropCount++;
                    }

                    jABGetElementPropertiesAsListpropCount++;
                }
                else
                {
                    jABGetElementPropertiesAsList["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGetElementPropertiesAsListpropCount++;
                }

                if (jABGetElementPropertiesAsListmaxStringLength != null)
                {
                    if (jABGetElementPropertiesAsListmaxStringLength != null)
                    {
                        jABGetElementPropertiesAsList["MaxStringLength"] = SourceExpressionConverter.ConvertToken(jABGetElementPropertiesAsListmaxStringLength);
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
                jABGetElementPropertiesAsList["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetElementPropertiesAsListworkflow);
                if (jABGetElementPropertiesAsListpropCount > 0)
                {
                    callPayload.Body = jABGetElementPropertiesAsList;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetElementPropertiesAsListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalInputPasswordIntoElement([WorkflowExpression] Func<int> jABGlobalInputPasswordIntoElementsearchParentElementJABHandle, [WorkflowExpression] Func<string> jABGlobalInputPasswordIntoElementpasswordToInput, [WorkflowExpression] Func<string> jABGlobalInputPasswordIntoElementworkflow, [WorkflowExpression] Func<string> jABGlobalInputPasswordIntoElementsearchElementJABName = null, [WorkflowExpression] Func<string> jABGlobalInputPasswordIntoElementsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABGlobalInputPasswordIntoElementsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABGlobalInputPasswordIntoElementsearchSubTree = null, [WorkflowExpression] Func<int> jABGlobalInputPasswordIntoElementmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABGlobalInputPasswordIntoElementmatchIndex = null, [WorkflowExpression] Func<string> jABGlobalInputPasswordIntoElementsearchFilter = null, [WorkflowExpression] Func<string> jABGlobalInputPasswordIntoElementsortByColumn = null, [WorkflowExpression] Func<bool> jABGlobalInputPasswordIntoElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABGlobalInputPasswordIntoElementcaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABGlobalInputPasswordIntoElementonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABGlobalInputPasswordIntoElementonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABGlobalInputPasswordIntoElementelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABGlobalInputPasswordIntoElementmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABGlobalInputPasswordIntoElementmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<bool> jABGlobalInputPasswordIntoElementfocusElement = null, [WorkflowExpression] Func<bool> jABGlobalInputPasswordIntoElementglobalMouseClickOnElement = null, [WorkflowExpression] Func<bool> jABGlobalInputPasswordIntoElementreplaceExistingValueUsingDoubleClickDelete = null, [WorkflowExpression] Func<bool> jABGlobalInputPasswordIntoElementreplaceExistingValueUsingCTRLADelete = null, [WorkflowExpression] Func<bool> jABGlobalInputPasswordIntoElementsendKeyEvents = null, [WorkflowExpression] Func<int> jABGlobalInputPasswordIntoElementkeyIntervalInMilliseconds = null, [WorkflowExpression] Func<int> jABGlobalInputPasswordIntoElementdoubleClickIntervalInMilliseconds = null, [WorkflowExpression] Func<bool> jABGlobalInputPasswordIntoElementdontInterpretSymbols = null)
        {
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementsearchParentElementJABHandle, nameof(jABGlobalInputPasswordIntoElementsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementpasswordToInput, nameof(jABGlobalInputPasswordIntoElementpasswordToInput), required: true);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementworkflow, nameof(jABGlobalInputPasswordIntoElementworkflow), required: true);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementsearchElementJABName, nameof(jABGlobalInputPasswordIntoElementsearchElementJABName), required: false);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementsearchElementJABDescription, nameof(jABGlobalInputPasswordIntoElementsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementsearchElementJABRole, nameof(jABGlobalInputPasswordIntoElementsearchElementJABRole), required: false);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementsearchSubTree, nameof(jABGlobalInputPasswordIntoElementsearchSubTree), required: false);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementmaxRelativeDepth, nameof(jABGlobalInputPasswordIntoElementmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementmatchIndex, nameof(jABGlobalInputPasswordIntoElementmatchIndex), required: false);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementsearchFilter, nameof(jABGlobalInputPasswordIntoElementsearchFilter), required: false);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementsortByColumn, nameof(jABGlobalInputPasswordIntoElementsortByColumn), required: false);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementmatchIndexAscending, nameof(jABGlobalInputPasswordIntoElementmatchIndexAscending), required: false);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementcaseSensitiveSearch, nameof(jABGlobalInputPasswordIntoElementcaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementonlySearchVisibleElements, nameof(jABGlobalInputPasswordIntoElementonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementonlySearchShowingElements, nameof(jABGlobalInputPasswordIntoElementonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementelementRolesNotToTraverse, nameof(jABGlobalInputPasswordIntoElementelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementmaximumElementsToSearch, nameof(jABGlobalInputPasswordIntoElementmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementmaximumChildElementsToSearchPerNode, nameof(jABGlobalInputPasswordIntoElementmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementfocusElement, nameof(jABGlobalInputPasswordIntoElementfocusElement), required: false);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementglobalMouseClickOnElement, nameof(jABGlobalInputPasswordIntoElementglobalMouseClickOnElement), required: false);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementreplaceExistingValueUsingDoubleClickDelete, nameof(jABGlobalInputPasswordIntoElementreplaceExistingValueUsingDoubleClickDelete), required: false);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementreplaceExistingValueUsingCTRLADelete, nameof(jABGlobalInputPasswordIntoElementreplaceExistingValueUsingCTRLADelete), required: false);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementsendKeyEvents, nameof(jABGlobalInputPasswordIntoElementsendKeyEvents), required: false);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementkeyIntervalInMilliseconds, nameof(jABGlobalInputPasswordIntoElementkeyIntervalInMilliseconds), required: false);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementdoubleClickIntervalInMilliseconds, nameof(jABGlobalInputPasswordIntoElementdoubleClickIntervalInMilliseconds), required: false);
            SourceExpression.Validate(jABGlobalInputPasswordIntoElementdontInterpretSymbols, nameof(jABGlobalInputPasswordIntoElementdontInterpretSymbols), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalInputPasswordIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGlobalInputPasswordIntoElement = new JObject();
                var jABGlobalInputPasswordIntoElementpropCount = 0;
                jABGlobalInputPasswordIntoElementpropCount++;
                jABGlobalInputPasswordIntoElement["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementsearchParentElementJABHandle);
                if (jABGlobalInputPasswordIntoElementsearchElementJABName != null)
                {
                    jABGlobalInputPasswordIntoElement["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementsearchElementJABName);
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (jABGlobalInputPasswordIntoElementsearchElementJABDescription != null)
                {
                    jABGlobalInputPasswordIntoElement["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementsearchElementJABDescription);
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (jABGlobalInputPasswordIntoElementsearchElementJABRole != null)
                {
                    jABGlobalInputPasswordIntoElement["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementsearchElementJABRole);
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (jABGlobalInputPasswordIntoElementsearchSubTree != null)
                {
                    if (jABGlobalInputPasswordIntoElementsearchSubTree != null)
                    {
                        jABGlobalInputPasswordIntoElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementsearchSubTree);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["SearchSubTree"] = true;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (jABGlobalInputPasswordIntoElementmaxRelativeDepth != null)
                {
                    if (jABGlobalInputPasswordIntoElementmaxRelativeDepth != null)
                    {
                        jABGlobalInputPasswordIntoElement["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementmaxRelativeDepth);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["MaxRelativeDepth"] = 0;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (jABGlobalInputPasswordIntoElementmatchIndex != null)
                {
                    if (jABGlobalInputPasswordIntoElementmatchIndex != null)
                    {
                        jABGlobalInputPasswordIntoElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementmatchIndex);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["MatchIndex"] = 1;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (jABGlobalInputPasswordIntoElementsearchFilter != null)
                {
                    jABGlobalInputPasswordIntoElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementsearchFilter);
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (jABGlobalInputPasswordIntoElementsortByColumn != null)
                {
                    jABGlobalInputPasswordIntoElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementsortByColumn);
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (jABGlobalInputPasswordIntoElementmatchIndexAscending != null)
                {
                    if (jABGlobalInputPasswordIntoElementmatchIndexAscending != null)
                    {
                        jABGlobalInputPasswordIntoElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementmatchIndexAscending);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["MatchIndexAscending"] = true;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (jABGlobalInputPasswordIntoElementcaseSensitiveSearch != null)
                {
                    if (jABGlobalInputPasswordIntoElementcaseSensitiveSearch != null)
                    {
                        jABGlobalInputPasswordIntoElement["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementcaseSensitiveSearch);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["CaseSensitiveSearch"] = false;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (jABGlobalInputPasswordIntoElementonlySearchVisibleElements != null)
                {
                    if (jABGlobalInputPasswordIntoElementonlySearchVisibleElements != null)
                    {
                        jABGlobalInputPasswordIntoElement["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementonlySearchVisibleElements);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["OnlySearchVisibleElements"] = true;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (jABGlobalInputPasswordIntoElementonlySearchShowingElements != null)
                {
                    if (jABGlobalInputPasswordIntoElementonlySearchShowingElements != null)
                    {
                        jABGlobalInputPasswordIntoElement["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementonlySearchShowingElements);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["OnlySearchShowingElements"] = true;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (jABGlobalInputPasswordIntoElementelementRolesNotToTraverse != null)
                {
                    jABGlobalInputPasswordIntoElement["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementelementRolesNotToTraverse);
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (jABGlobalInputPasswordIntoElementmaximumElementsToSearch != null)
                {
                    if (jABGlobalInputPasswordIntoElementmaximumElementsToSearch != null)
                    {
                        jABGlobalInputPasswordIntoElement["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementmaximumElementsToSearch);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["MaximumElementsToSearch"] = 2000;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (jABGlobalInputPasswordIntoElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABGlobalInputPasswordIntoElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGlobalInputPasswordIntoElement["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementmaximumChildElementsToSearchPerNode);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (jABGlobalInputPasswordIntoElementfocusElement != null)
                {
                    if (jABGlobalInputPasswordIntoElementfocusElement != null)
                    {
                        jABGlobalInputPasswordIntoElement["FocusElement"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementfocusElement);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["FocusElement"] = true;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (jABGlobalInputPasswordIntoElementglobalMouseClickOnElement != null)
                {
                    if (jABGlobalInputPasswordIntoElementglobalMouseClickOnElement != null)
                    {
                        jABGlobalInputPasswordIntoElement["GlobalMouseClickOnElement"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementglobalMouseClickOnElement);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["GlobalMouseClickOnElement"] = true;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (jABGlobalInputPasswordIntoElementreplaceExistingValueUsingDoubleClickDelete != null)
                {
                    if (jABGlobalInputPasswordIntoElementreplaceExistingValueUsingDoubleClickDelete != null)
                    {
                        jABGlobalInputPasswordIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementreplaceExistingValueUsingDoubleClickDelete);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = false;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (jABGlobalInputPasswordIntoElementreplaceExistingValueUsingCTRLADelete != null)
                {
                    if (jABGlobalInputPasswordIntoElementreplaceExistingValueUsingCTRLADelete != null)
                    {
                        jABGlobalInputPasswordIntoElement["ReplaceExistingValueUsingCTRLADelete"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementreplaceExistingValueUsingCTRLADelete);
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
                jABGlobalInputPasswordIntoElement["PasswordToInput"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementpasswordToInput);
                if (jABGlobalInputPasswordIntoElementsendKeyEvents != null)
                {
                    if (jABGlobalInputPasswordIntoElementsendKeyEvents != null)
                    {
                        jABGlobalInputPasswordIntoElement["SendKeyEvents"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementsendKeyEvents);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["SendKeyEvents"] = false;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (jABGlobalInputPasswordIntoElementkeyIntervalInMilliseconds != null)
                {
                    if (jABGlobalInputPasswordIntoElementkeyIntervalInMilliseconds != null)
                    {
                        jABGlobalInputPasswordIntoElement["KeyIntervalInMilliseconds"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementkeyIntervalInMilliseconds);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["KeyIntervalInMilliseconds"] = 10;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (jABGlobalInputPasswordIntoElementdoubleClickIntervalInMilliseconds != null)
                {
                    if (jABGlobalInputPasswordIntoElementdoubleClickIntervalInMilliseconds != null)
                    {
                        jABGlobalInputPasswordIntoElement["DoubleClickIntervalInMilliseconds"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementdoubleClickIntervalInMilliseconds);
                        jABGlobalInputPasswordIntoElementpropCount++;
                    }

                    jABGlobalInputPasswordIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputPasswordIntoElement["DoubleClickIntervalInMilliseconds"] = 10;
                    jABGlobalInputPasswordIntoElementpropCount++;
                }

                if (jABGlobalInputPasswordIntoElementdontInterpretSymbols != null)
                {
                    if (jABGlobalInputPasswordIntoElementdontInterpretSymbols != null)
                    {
                        jABGlobalInputPasswordIntoElement["DontInterpretSymbols"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementdontInterpretSymbols);
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
                jABGlobalInputPasswordIntoElement["Workflow"] = SourceExpressionConverter.ConvertToken(jABGlobalInputPasswordIntoElementworkflow);
                if (jABGlobalInputPasswordIntoElementpropCount > 0)
                {
                    callPayload.Body = jABGlobalInputPasswordIntoElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalInputTextIntoElement([WorkflowExpression] Func<int> jABGlobalInputTextIntoElementsearchParentElementJABHandle, [WorkflowExpression] Func<string> jABGlobalInputTextIntoElementworkflow, [WorkflowExpression] Func<string> jABGlobalInputTextIntoElementsearchElementJABName = null, [WorkflowExpression] Func<string> jABGlobalInputTextIntoElementsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABGlobalInputTextIntoElementsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABGlobalInputTextIntoElementsearchSubTree = null, [WorkflowExpression] Func<int> jABGlobalInputTextIntoElementmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABGlobalInputTextIntoElementmatchIndex = null, [WorkflowExpression] Func<string> jABGlobalInputTextIntoElementsearchFilter = null, [WorkflowExpression] Func<string> jABGlobalInputTextIntoElementsortByColumn = null, [WorkflowExpression] Func<bool> jABGlobalInputTextIntoElementmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABGlobalInputTextIntoElementcaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABGlobalInputTextIntoElementonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABGlobalInputTextIntoElementonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABGlobalInputTextIntoElementelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABGlobalInputTextIntoElementmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABGlobalInputTextIntoElementmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<bool> jABGlobalInputTextIntoElementfocusElement = null, [WorkflowExpression] Func<bool> jABGlobalInputTextIntoElementglobalMouseClickOnElement = null, [WorkflowExpression] Func<bool> jABGlobalInputTextIntoElementreplaceExistingValueUsingDoubleClickDelete = null, [WorkflowExpression] Func<bool> jABGlobalInputTextIntoElementreplaceExistingValueUsingCTRLADelete = null, [WorkflowExpression] Func<string> jABGlobalInputTextIntoElementtextToInput = null, [WorkflowExpression] Func<bool> jABGlobalInputTextIntoElementsendKeyEvents = null, [WorkflowExpression] Func<int> jABGlobalInputTextIntoElementkeyIntervalInMilliseconds = null, [WorkflowExpression] Func<int> jABGlobalInputTextIntoElementdoubleClickIntervalInMilliseconds = null, [WorkflowExpression] Func<bool> jABGlobalInputTextIntoElementdontInterpretSymbols = null)
        {
            SourceExpression.Validate(jABGlobalInputTextIntoElementsearchParentElementJABHandle, nameof(jABGlobalInputTextIntoElementsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABGlobalInputTextIntoElementworkflow, nameof(jABGlobalInputTextIntoElementworkflow), required: true);
            SourceExpression.Validate(jABGlobalInputTextIntoElementsearchElementJABName, nameof(jABGlobalInputTextIntoElementsearchElementJABName), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementsearchElementJABDescription, nameof(jABGlobalInputTextIntoElementsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementsearchElementJABRole, nameof(jABGlobalInputTextIntoElementsearchElementJABRole), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementsearchSubTree, nameof(jABGlobalInputTextIntoElementsearchSubTree), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementmaxRelativeDepth, nameof(jABGlobalInputTextIntoElementmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementmatchIndex, nameof(jABGlobalInputTextIntoElementmatchIndex), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementsearchFilter, nameof(jABGlobalInputTextIntoElementsearchFilter), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementsortByColumn, nameof(jABGlobalInputTextIntoElementsortByColumn), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementmatchIndexAscending, nameof(jABGlobalInputTextIntoElementmatchIndexAscending), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementcaseSensitiveSearch, nameof(jABGlobalInputTextIntoElementcaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementonlySearchVisibleElements, nameof(jABGlobalInputTextIntoElementonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementonlySearchShowingElements, nameof(jABGlobalInputTextIntoElementonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementelementRolesNotToTraverse, nameof(jABGlobalInputTextIntoElementelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementmaximumElementsToSearch, nameof(jABGlobalInputTextIntoElementmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementmaximumChildElementsToSearchPerNode, nameof(jABGlobalInputTextIntoElementmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementfocusElement, nameof(jABGlobalInputTextIntoElementfocusElement), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementglobalMouseClickOnElement, nameof(jABGlobalInputTextIntoElementglobalMouseClickOnElement), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementreplaceExistingValueUsingDoubleClickDelete, nameof(jABGlobalInputTextIntoElementreplaceExistingValueUsingDoubleClickDelete), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementreplaceExistingValueUsingCTRLADelete, nameof(jABGlobalInputTextIntoElementreplaceExistingValueUsingCTRLADelete), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementtextToInput, nameof(jABGlobalInputTextIntoElementtextToInput), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementsendKeyEvents, nameof(jABGlobalInputTextIntoElementsendKeyEvents), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementkeyIntervalInMilliseconds, nameof(jABGlobalInputTextIntoElementkeyIntervalInMilliseconds), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementdoubleClickIntervalInMilliseconds, nameof(jABGlobalInputTextIntoElementdoubleClickIntervalInMilliseconds), required: false);
            SourceExpression.Validate(jABGlobalInputTextIntoElementdontInterpretSymbols, nameof(jABGlobalInputTextIntoElementdontInterpretSymbols), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalInputTextIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGlobalInputTextIntoElement = new JObject();
                var jABGlobalInputTextIntoElementpropCount = 0;
                jABGlobalInputTextIntoElementpropCount++;
                jABGlobalInputTextIntoElement["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementsearchParentElementJABHandle);
                if (jABGlobalInputTextIntoElementsearchElementJABName != null)
                {
                    jABGlobalInputTextIntoElement["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementsearchElementJABName);
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementsearchElementJABDescription != null)
                {
                    jABGlobalInputTextIntoElement["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementsearchElementJABDescription);
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementsearchElementJABRole != null)
                {
                    jABGlobalInputTextIntoElement["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementsearchElementJABRole);
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementsearchSubTree != null)
                {
                    if (jABGlobalInputTextIntoElementsearchSubTree != null)
                    {
                        jABGlobalInputTextIntoElement["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementsearchSubTree);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["SearchSubTree"] = true;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementmaxRelativeDepth != null)
                {
                    if (jABGlobalInputTextIntoElementmaxRelativeDepth != null)
                    {
                        jABGlobalInputTextIntoElement["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementmaxRelativeDepth);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["MaxRelativeDepth"] = 0;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementmatchIndex != null)
                {
                    if (jABGlobalInputTextIntoElementmatchIndex != null)
                    {
                        jABGlobalInputTextIntoElement["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementmatchIndex);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["MatchIndex"] = 1;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementsearchFilter != null)
                {
                    jABGlobalInputTextIntoElement["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementsearchFilter);
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementsortByColumn != null)
                {
                    jABGlobalInputTextIntoElement["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementsortByColumn);
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementmatchIndexAscending != null)
                {
                    if (jABGlobalInputTextIntoElementmatchIndexAscending != null)
                    {
                        jABGlobalInputTextIntoElement["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementmatchIndexAscending);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["MatchIndexAscending"] = true;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementcaseSensitiveSearch != null)
                {
                    if (jABGlobalInputTextIntoElementcaseSensitiveSearch != null)
                    {
                        jABGlobalInputTextIntoElement["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementcaseSensitiveSearch);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["CaseSensitiveSearch"] = false;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementonlySearchVisibleElements != null)
                {
                    if (jABGlobalInputTextIntoElementonlySearchVisibleElements != null)
                    {
                        jABGlobalInputTextIntoElement["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementonlySearchVisibleElements);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["OnlySearchVisibleElements"] = true;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementonlySearchShowingElements != null)
                {
                    if (jABGlobalInputTextIntoElementonlySearchShowingElements != null)
                    {
                        jABGlobalInputTextIntoElement["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementonlySearchShowingElements);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["OnlySearchShowingElements"] = true;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementelementRolesNotToTraverse != null)
                {
                    jABGlobalInputTextIntoElement["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementelementRolesNotToTraverse);
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementmaximumElementsToSearch != null)
                {
                    if (jABGlobalInputTextIntoElementmaximumElementsToSearch != null)
                    {
                        jABGlobalInputTextIntoElement["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementmaximumElementsToSearch);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["MaximumElementsToSearch"] = 2000;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABGlobalInputTextIntoElementmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGlobalInputTextIntoElement["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementmaximumChildElementsToSearchPerNode);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementfocusElement != null)
                {
                    if (jABGlobalInputTextIntoElementfocusElement != null)
                    {
                        jABGlobalInputTextIntoElement["FocusElement"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementfocusElement);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["FocusElement"] = true;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementglobalMouseClickOnElement != null)
                {
                    if (jABGlobalInputTextIntoElementglobalMouseClickOnElement != null)
                    {
                        jABGlobalInputTextIntoElement["GlobalMouseClickOnElement"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementglobalMouseClickOnElement);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["GlobalMouseClickOnElement"] = true;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementreplaceExistingValueUsingDoubleClickDelete != null)
                {
                    if (jABGlobalInputTextIntoElementreplaceExistingValueUsingDoubleClickDelete != null)
                    {
                        jABGlobalInputTextIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementreplaceExistingValueUsingDoubleClickDelete);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = false;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementreplaceExistingValueUsingCTRLADelete != null)
                {
                    if (jABGlobalInputTextIntoElementreplaceExistingValueUsingCTRLADelete != null)
                    {
                        jABGlobalInputTextIntoElement["ReplaceExistingValueUsingCTRLADelete"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementreplaceExistingValueUsingCTRLADelete);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["ReplaceExistingValueUsingCTRLADelete"] = false;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementtextToInput != null)
                {
                    jABGlobalInputTextIntoElement["TextToInput"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementtextToInput);
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementsendKeyEvents != null)
                {
                    if (jABGlobalInputTextIntoElementsendKeyEvents != null)
                    {
                        jABGlobalInputTextIntoElement["SendKeyEvents"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementsendKeyEvents);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["SendKeyEvents"] = false;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementkeyIntervalInMilliseconds != null)
                {
                    if (jABGlobalInputTextIntoElementkeyIntervalInMilliseconds != null)
                    {
                        jABGlobalInputTextIntoElement["KeyIntervalInMilliseconds"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementkeyIntervalInMilliseconds);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["KeyIntervalInMilliseconds"] = 10;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementdoubleClickIntervalInMilliseconds != null)
                {
                    if (jABGlobalInputTextIntoElementdoubleClickIntervalInMilliseconds != null)
                    {
                        jABGlobalInputTextIntoElement["DoubleClickIntervalInMilliseconds"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementdoubleClickIntervalInMilliseconds);
                        jABGlobalInputTextIntoElementpropCount++;
                    }

                    jABGlobalInputTextIntoElementpropCount++;
                }
                else
                {
                    jABGlobalInputTextIntoElement["DoubleClickIntervalInMilliseconds"] = 10;
                    jABGlobalInputTextIntoElementpropCount++;
                }

                if (jABGlobalInputTextIntoElementdontInterpretSymbols != null)
                {
                    if (jABGlobalInputTextIntoElementdontInterpretSymbols != null)
                    {
                        jABGlobalInputTextIntoElement["DontInterpretSymbols"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementdontInterpretSymbols);
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
                jABGlobalInputTextIntoElement["Workflow"] = SourceExpressionConverter.ConvertToken(jABGlobalInputTextIntoElementworkflow);
                if (jABGlobalInputTextIntoElementpropCount > 0)
                {
                    callPayload.Body = jABGlobalInputTextIntoElement;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetSelectionElementItemsResponse> JABGetSelectionElementItems([WorkflowExpression] Func<int> jABGetSelectionElementItemssearchParentElementJABHandle, [WorkflowExpression] Func<string> jABGetSelectionElementItemsworkflow, [WorkflowExpression] Func<string> jABGetSelectionElementItemssearchElementJABName = null, [WorkflowExpression] Func<string> jABGetSelectionElementItemssearchElementJABDescription = null, [WorkflowExpression] Func<string> jABGetSelectionElementItemssearchElementJABRole = null, [WorkflowExpression] Func<bool> jABGetSelectionElementItemssearchSubTree = null, [WorkflowExpression] Func<int> jABGetSelectionElementItemsmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABGetSelectionElementItemsmatchIndex = null, [WorkflowExpression] Func<string> jABGetSelectionElementItemssearchFilter = null, [WorkflowExpression] Func<string> jABGetSelectionElementItemssortByColumn = null, [WorkflowExpression] Func<bool> jABGetSelectionElementItemsmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABGetSelectionElementItemscaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABGetSelectionElementItemsonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABGetSelectionElementItemsonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABGetSelectionElementItemselementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABGetSelectionElementItemsmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABGetSelectionElementItemsmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<bool> jABGetSelectionElementItemsgetListOfOptionsBySelecting = null, [WorkflowExpression] Func<bool> jABGetSelectionElementItemsgetListOfOptionsByReadingLabels = null, [WorkflowExpression] Func<bool> jABGetSelectionElementItemsexpandFirst = null, [WorkflowExpression] Func<bool> jABGetSelectionElementItemscollapseAfter = null, [WorkflowExpression] Func<double> jABGetSelectionElementItemssecondsBetweenExpandCollapse = null, [WorkflowExpression] Func<int> jABGetSelectionElementItemsmaxListItemsToReturn = null)
        {
            SourceExpression.Validate(jABGetSelectionElementItemssearchParentElementJABHandle, nameof(jABGetSelectionElementItemssearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABGetSelectionElementItemsworkflow, nameof(jABGetSelectionElementItemsworkflow), required: true);
            SourceExpression.Validate(jABGetSelectionElementItemssearchElementJABName, nameof(jABGetSelectionElementItemssearchElementJABName), required: false);
            SourceExpression.Validate(jABGetSelectionElementItemssearchElementJABDescription, nameof(jABGetSelectionElementItemssearchElementJABDescription), required: false);
            SourceExpression.Validate(jABGetSelectionElementItemssearchElementJABRole, nameof(jABGetSelectionElementItemssearchElementJABRole), required: false);
            SourceExpression.Validate(jABGetSelectionElementItemssearchSubTree, nameof(jABGetSelectionElementItemssearchSubTree), required: false);
            SourceExpression.Validate(jABGetSelectionElementItemsmaxRelativeDepth, nameof(jABGetSelectionElementItemsmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABGetSelectionElementItemsmatchIndex, nameof(jABGetSelectionElementItemsmatchIndex), required: false);
            SourceExpression.Validate(jABGetSelectionElementItemssearchFilter, nameof(jABGetSelectionElementItemssearchFilter), required: false);
            SourceExpression.Validate(jABGetSelectionElementItemssortByColumn, nameof(jABGetSelectionElementItemssortByColumn), required: false);
            SourceExpression.Validate(jABGetSelectionElementItemsmatchIndexAscending, nameof(jABGetSelectionElementItemsmatchIndexAscending), required: false);
            SourceExpression.Validate(jABGetSelectionElementItemscaseSensitiveSearch, nameof(jABGetSelectionElementItemscaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABGetSelectionElementItemsonlySearchVisibleElements, nameof(jABGetSelectionElementItemsonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABGetSelectionElementItemsonlySearchShowingElements, nameof(jABGetSelectionElementItemsonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABGetSelectionElementItemselementRolesNotToTraverse, nameof(jABGetSelectionElementItemselementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABGetSelectionElementItemsmaximumElementsToSearch, nameof(jABGetSelectionElementItemsmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABGetSelectionElementItemsmaximumChildElementsToSearchPerNode, nameof(jABGetSelectionElementItemsmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABGetSelectionElementItemsgetListOfOptionsBySelecting, nameof(jABGetSelectionElementItemsgetListOfOptionsBySelecting), required: false);
            SourceExpression.Validate(jABGetSelectionElementItemsgetListOfOptionsByReadingLabels, nameof(jABGetSelectionElementItemsgetListOfOptionsByReadingLabels), required: false);
            SourceExpression.Validate(jABGetSelectionElementItemsexpandFirst, nameof(jABGetSelectionElementItemsexpandFirst), required: false);
            SourceExpression.Validate(jABGetSelectionElementItemscollapseAfter, nameof(jABGetSelectionElementItemscollapseAfter), required: false);
            SourceExpression.Validate(jABGetSelectionElementItemssecondsBetweenExpandCollapse, nameof(jABGetSelectionElementItemssecondsBetweenExpandCollapse), required: false);
            SourceExpression.Validate(jABGetSelectionElementItemsmaxListItemsToReturn, nameof(jABGetSelectionElementItemsmaxListItemsToReturn), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetSelectionElementItems";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetSelectionElementItems = new JObject();
                var jABGetSelectionElementItemspropCount = 0;
                jABGetSelectionElementItemspropCount++;
                jABGetSelectionElementItems["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemssearchParentElementJABHandle);
                if (jABGetSelectionElementItemssearchElementJABName != null)
                {
                    jABGetSelectionElementItems["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemssearchElementJABName);
                    jABGetSelectionElementItemspropCount++;
                }

                if (jABGetSelectionElementItemssearchElementJABDescription != null)
                {
                    jABGetSelectionElementItems["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemssearchElementJABDescription);
                    jABGetSelectionElementItemspropCount++;
                }

                if (jABGetSelectionElementItemssearchElementJABRole != null)
                {
                    jABGetSelectionElementItems["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemssearchElementJABRole);
                    jABGetSelectionElementItemspropCount++;
                }

                if (jABGetSelectionElementItemssearchSubTree != null)
                {
                    if (jABGetSelectionElementItemssearchSubTree != null)
                    {
                        jABGetSelectionElementItems["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemssearchSubTree);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["SearchSubTree"] = true;
                    jABGetSelectionElementItemspropCount++;
                }

                if (jABGetSelectionElementItemsmaxRelativeDepth != null)
                {
                    if (jABGetSelectionElementItemsmaxRelativeDepth != null)
                    {
                        jABGetSelectionElementItems["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemsmaxRelativeDepth);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["MaxRelativeDepth"] = 0;
                    jABGetSelectionElementItemspropCount++;
                }

                if (jABGetSelectionElementItemsmatchIndex != null)
                {
                    if (jABGetSelectionElementItemsmatchIndex != null)
                    {
                        jABGetSelectionElementItems["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemsmatchIndex);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["MatchIndex"] = 1;
                    jABGetSelectionElementItemspropCount++;
                }

                if (jABGetSelectionElementItemssearchFilter != null)
                {
                    jABGetSelectionElementItems["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemssearchFilter);
                    jABGetSelectionElementItemspropCount++;
                }

                if (jABGetSelectionElementItemssortByColumn != null)
                {
                    jABGetSelectionElementItems["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemssortByColumn);
                    jABGetSelectionElementItemspropCount++;
                }

                if (jABGetSelectionElementItemsmatchIndexAscending != null)
                {
                    if (jABGetSelectionElementItemsmatchIndexAscending != null)
                    {
                        jABGetSelectionElementItems["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemsmatchIndexAscending);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["MatchIndexAscending"] = true;
                    jABGetSelectionElementItemspropCount++;
                }

                if (jABGetSelectionElementItemscaseSensitiveSearch != null)
                {
                    if (jABGetSelectionElementItemscaseSensitiveSearch != null)
                    {
                        jABGetSelectionElementItems["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemscaseSensitiveSearch);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["CaseSensitiveSearch"] = false;
                    jABGetSelectionElementItemspropCount++;
                }

                if (jABGetSelectionElementItemsonlySearchVisibleElements != null)
                {
                    if (jABGetSelectionElementItemsonlySearchVisibleElements != null)
                    {
                        jABGetSelectionElementItems["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemsonlySearchVisibleElements);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["OnlySearchVisibleElements"] = true;
                    jABGetSelectionElementItemspropCount++;
                }

                if (jABGetSelectionElementItemsonlySearchShowingElements != null)
                {
                    if (jABGetSelectionElementItemsonlySearchShowingElements != null)
                    {
                        jABGetSelectionElementItems["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemsonlySearchShowingElements);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["OnlySearchShowingElements"] = true;
                    jABGetSelectionElementItemspropCount++;
                }

                if (jABGetSelectionElementItemselementRolesNotToTraverse != null)
                {
                    jABGetSelectionElementItems["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemselementRolesNotToTraverse);
                    jABGetSelectionElementItemspropCount++;
                }

                if (jABGetSelectionElementItemsmaximumElementsToSearch != null)
                {
                    if (jABGetSelectionElementItemsmaximumElementsToSearch != null)
                    {
                        jABGetSelectionElementItems["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemsmaximumElementsToSearch);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["MaximumElementsToSearch"] = 2000;
                    jABGetSelectionElementItemspropCount++;
                }

                if (jABGetSelectionElementItemsmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABGetSelectionElementItemsmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetSelectionElementItems["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemsmaximumChildElementsToSearchPerNode);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGetSelectionElementItemspropCount++;
                }

                if (jABGetSelectionElementItemsgetListOfOptionsBySelecting != null)
                {
                    if (jABGetSelectionElementItemsgetListOfOptionsBySelecting != null)
                    {
                        jABGetSelectionElementItems["GetListOfOptionsBySelecting"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemsgetListOfOptionsBySelecting);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["GetListOfOptionsBySelecting"] = false;
                    jABGetSelectionElementItemspropCount++;
                }

                if (jABGetSelectionElementItemsgetListOfOptionsByReadingLabels != null)
                {
                    if (jABGetSelectionElementItemsgetListOfOptionsByReadingLabels != null)
                    {
                        jABGetSelectionElementItems["GetListOfOptionsByReadingLabels"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemsgetListOfOptionsByReadingLabels);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["GetListOfOptionsByReadingLabels"] = false;
                    jABGetSelectionElementItemspropCount++;
                }

                if (jABGetSelectionElementItemsexpandFirst != null)
                {
                    if (jABGetSelectionElementItemsexpandFirst != null)
                    {
                        jABGetSelectionElementItems["ExpandFirst"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemsexpandFirst);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["ExpandFirst"] = false;
                    jABGetSelectionElementItemspropCount++;
                }

                if (jABGetSelectionElementItemscollapseAfter != null)
                {
                    if (jABGetSelectionElementItemscollapseAfter != null)
                    {
                        jABGetSelectionElementItems["CollapseAfter"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemscollapseAfter);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["CollapseAfter"] = false;
                    jABGetSelectionElementItemspropCount++;
                }

                if (jABGetSelectionElementItemssecondsBetweenExpandCollapse != null)
                {
                    if (jABGetSelectionElementItemssecondsBetweenExpandCollapse != null)
                    {
                        jABGetSelectionElementItems["SecondsBetweenExpandCollapse"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemssecondsBetweenExpandCollapse);
                        jABGetSelectionElementItemspropCount++;
                    }

                    jABGetSelectionElementItemspropCount++;
                }
                else
                {
                    jABGetSelectionElementItems["SecondsBetweenExpandCollapse"] = 0.05;
                    jABGetSelectionElementItemspropCount++;
                }

                if (jABGetSelectionElementItemsmaxListItemsToReturn != null)
                {
                    if (jABGetSelectionElementItemsmaxListItemsToReturn != null)
                    {
                        jABGetSelectionElementItems["MaxListItemsToReturn"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemsmaxListItemsToReturn);
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
                jABGetSelectionElementItems["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetSelectionElementItemsworkflow);
                if (jABGetSelectionElementItemspropCount > 0)
                {
                    callPayload.Body = jABGetSelectionElementItems;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetSelectionElementItemsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABSetSelectionByIndex([WorkflowExpression] Func<int> jABSetSelectionByIndexsearchParentElementJABHandle, [WorkflowExpression] Func<int> jABSetSelectionByIndexitemIndex, [WorkflowExpression] Func<string> jABSetSelectionByIndexworkflow, [WorkflowExpression] Func<string> jABSetSelectionByIndexsearchElementJABName = null, [WorkflowExpression] Func<string> jABSetSelectionByIndexsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABSetSelectionByIndexsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABSetSelectionByIndexsearchSubTree = null, [WorkflowExpression] Func<int> jABSetSelectionByIndexmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABSetSelectionByIndexmatchIndex = null, [WorkflowExpression] Func<string> jABSetSelectionByIndexsearchFilter = null, [WorkflowExpression] Func<string> jABSetSelectionByIndexsortByColumn = null, [WorkflowExpression] Func<bool> jABSetSelectionByIndexmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABSetSelectionByIndexcaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABSetSelectionByIndexonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABSetSelectionByIndexonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABSetSelectionByIndexelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABSetSelectionByIndexmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABSetSelectionByIndexmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<bool> jABSetSelectionByIndexselectItem = null, [WorkflowExpression] Func<bool> jABSetSelectionByIndexclearSelectionFirst = null, [WorkflowExpression] Func<bool> jABSetSelectionByIndexrecoverOnFailure = null)
        {
            SourceExpression.Validate(jABSetSelectionByIndexsearchParentElementJABHandle, nameof(jABSetSelectionByIndexsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABSetSelectionByIndexitemIndex, nameof(jABSetSelectionByIndexitemIndex), required: true);
            SourceExpression.Validate(jABSetSelectionByIndexworkflow, nameof(jABSetSelectionByIndexworkflow), required: true);
            SourceExpression.Validate(jABSetSelectionByIndexsearchElementJABName, nameof(jABSetSelectionByIndexsearchElementJABName), required: false);
            SourceExpression.Validate(jABSetSelectionByIndexsearchElementJABDescription, nameof(jABSetSelectionByIndexsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABSetSelectionByIndexsearchElementJABRole, nameof(jABSetSelectionByIndexsearchElementJABRole), required: false);
            SourceExpression.Validate(jABSetSelectionByIndexsearchSubTree, nameof(jABSetSelectionByIndexsearchSubTree), required: false);
            SourceExpression.Validate(jABSetSelectionByIndexmaxRelativeDepth, nameof(jABSetSelectionByIndexmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABSetSelectionByIndexmatchIndex, nameof(jABSetSelectionByIndexmatchIndex), required: false);
            SourceExpression.Validate(jABSetSelectionByIndexsearchFilter, nameof(jABSetSelectionByIndexsearchFilter), required: false);
            SourceExpression.Validate(jABSetSelectionByIndexsortByColumn, nameof(jABSetSelectionByIndexsortByColumn), required: false);
            SourceExpression.Validate(jABSetSelectionByIndexmatchIndexAscending, nameof(jABSetSelectionByIndexmatchIndexAscending), required: false);
            SourceExpression.Validate(jABSetSelectionByIndexcaseSensitiveSearch, nameof(jABSetSelectionByIndexcaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABSetSelectionByIndexonlySearchVisibleElements, nameof(jABSetSelectionByIndexonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABSetSelectionByIndexonlySearchShowingElements, nameof(jABSetSelectionByIndexonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABSetSelectionByIndexelementRolesNotToTraverse, nameof(jABSetSelectionByIndexelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABSetSelectionByIndexmaximumElementsToSearch, nameof(jABSetSelectionByIndexmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABSetSelectionByIndexmaximumChildElementsToSearchPerNode, nameof(jABSetSelectionByIndexmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABSetSelectionByIndexselectItem, nameof(jABSetSelectionByIndexselectItem), required: false);
            SourceExpression.Validate(jABSetSelectionByIndexclearSelectionFirst, nameof(jABSetSelectionByIndexclearSelectionFirst), required: false);
            SourceExpression.Validate(jABSetSelectionByIndexrecoverOnFailure, nameof(jABSetSelectionByIndexrecoverOnFailure), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABSetSelectionByIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABSetSelectionByIndex = new JObject();
                var jABSetSelectionByIndexpropCount = 0;
                jABSetSelectionByIndexpropCount++;
                jABSetSelectionByIndex["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByIndexsearchParentElementJABHandle);
                if (jABSetSelectionByIndexsearchElementJABName != null)
                {
                    jABSetSelectionByIndex["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByIndexsearchElementJABName);
                    jABSetSelectionByIndexpropCount++;
                }

                if (jABSetSelectionByIndexsearchElementJABDescription != null)
                {
                    jABSetSelectionByIndex["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByIndexsearchElementJABDescription);
                    jABSetSelectionByIndexpropCount++;
                }

                if (jABSetSelectionByIndexsearchElementJABRole != null)
                {
                    jABSetSelectionByIndex["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByIndexsearchElementJABRole);
                    jABSetSelectionByIndexpropCount++;
                }

                if (jABSetSelectionByIndexsearchSubTree != null)
                {
                    if (jABSetSelectionByIndexsearchSubTree != null)
                    {
                        jABSetSelectionByIndex["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByIndexsearchSubTree);
                        jABSetSelectionByIndexpropCount++;
                    }

                    jABSetSelectionByIndexpropCount++;
                }
                else
                {
                    jABSetSelectionByIndex["SearchSubTree"] = true;
                    jABSetSelectionByIndexpropCount++;
                }

                if (jABSetSelectionByIndexmaxRelativeDepth != null)
                {
                    if (jABSetSelectionByIndexmaxRelativeDepth != null)
                    {
                        jABSetSelectionByIndex["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByIndexmaxRelativeDepth);
                        jABSetSelectionByIndexpropCount++;
                    }

                    jABSetSelectionByIndexpropCount++;
                }
                else
                {
                    jABSetSelectionByIndex["MaxRelativeDepth"] = 0;
                    jABSetSelectionByIndexpropCount++;
                }

                if (jABSetSelectionByIndexmatchIndex != null)
                {
                    if (jABSetSelectionByIndexmatchIndex != null)
                    {
                        jABSetSelectionByIndex["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByIndexmatchIndex);
                        jABSetSelectionByIndexpropCount++;
                    }

                    jABSetSelectionByIndexpropCount++;
                }
                else
                {
                    jABSetSelectionByIndex["MatchIndex"] = 1;
                    jABSetSelectionByIndexpropCount++;
                }

                if (jABSetSelectionByIndexsearchFilter != null)
                {
                    jABSetSelectionByIndex["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByIndexsearchFilter);
                    jABSetSelectionByIndexpropCount++;
                }

                if (jABSetSelectionByIndexsortByColumn != null)
                {
                    jABSetSelectionByIndex["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByIndexsortByColumn);
                    jABSetSelectionByIndexpropCount++;
                }

                if (jABSetSelectionByIndexmatchIndexAscending != null)
                {
                    if (jABSetSelectionByIndexmatchIndexAscending != null)
                    {
                        jABSetSelectionByIndex["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByIndexmatchIndexAscending);
                        jABSetSelectionByIndexpropCount++;
                    }

                    jABSetSelectionByIndexpropCount++;
                }
                else
                {
                    jABSetSelectionByIndex["MatchIndexAscending"] = true;
                    jABSetSelectionByIndexpropCount++;
                }

                if (jABSetSelectionByIndexcaseSensitiveSearch != null)
                {
                    if (jABSetSelectionByIndexcaseSensitiveSearch != null)
                    {
                        jABSetSelectionByIndex["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByIndexcaseSensitiveSearch);
                        jABSetSelectionByIndexpropCount++;
                    }

                    jABSetSelectionByIndexpropCount++;
                }
                else
                {
                    jABSetSelectionByIndex["CaseSensitiveSearch"] = false;
                    jABSetSelectionByIndexpropCount++;
                }

                if (jABSetSelectionByIndexonlySearchVisibleElements != null)
                {
                    if (jABSetSelectionByIndexonlySearchVisibleElements != null)
                    {
                        jABSetSelectionByIndex["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByIndexonlySearchVisibleElements);
                        jABSetSelectionByIndexpropCount++;
                    }

                    jABSetSelectionByIndexpropCount++;
                }
                else
                {
                    jABSetSelectionByIndex["OnlySearchVisibleElements"] = true;
                    jABSetSelectionByIndexpropCount++;
                }

                if (jABSetSelectionByIndexonlySearchShowingElements != null)
                {
                    if (jABSetSelectionByIndexonlySearchShowingElements != null)
                    {
                        jABSetSelectionByIndex["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByIndexonlySearchShowingElements);
                        jABSetSelectionByIndexpropCount++;
                    }

                    jABSetSelectionByIndexpropCount++;
                }
                else
                {
                    jABSetSelectionByIndex["OnlySearchShowingElements"] = true;
                    jABSetSelectionByIndexpropCount++;
                }

                if (jABSetSelectionByIndexelementRolesNotToTraverse != null)
                {
                    jABSetSelectionByIndex["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByIndexelementRolesNotToTraverse);
                    jABSetSelectionByIndexpropCount++;
                }

                if (jABSetSelectionByIndexmaximumElementsToSearch != null)
                {
                    if (jABSetSelectionByIndexmaximumElementsToSearch != null)
                    {
                        jABSetSelectionByIndex["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByIndexmaximumElementsToSearch);
                        jABSetSelectionByIndexpropCount++;
                    }

                    jABSetSelectionByIndexpropCount++;
                }
                else
                {
                    jABSetSelectionByIndex["MaximumElementsToSearch"] = 2000;
                    jABSetSelectionByIndexpropCount++;
                }

                if (jABSetSelectionByIndexmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABSetSelectionByIndexmaximumChildElementsToSearchPerNode != null)
                    {
                        jABSetSelectionByIndex["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByIndexmaximumChildElementsToSearchPerNode);
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
                jABSetSelectionByIndex["ItemIndex"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByIndexitemIndex);
                if (jABSetSelectionByIndexselectItem != null)
                {
                    if (jABSetSelectionByIndexselectItem != null)
                    {
                        jABSetSelectionByIndex["SelectItem"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByIndexselectItem);
                        jABSetSelectionByIndexpropCount++;
                    }

                    jABSetSelectionByIndexpropCount++;
                }
                else
                {
                    jABSetSelectionByIndex["SelectItem"] = true;
                    jABSetSelectionByIndexpropCount++;
                }

                if (jABSetSelectionByIndexclearSelectionFirst != null)
                {
                    if (jABSetSelectionByIndexclearSelectionFirst != null)
                    {
                        jABSetSelectionByIndex["ClearSelectionFirst"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByIndexclearSelectionFirst);
                        jABSetSelectionByIndexpropCount++;
                    }

                    jABSetSelectionByIndexpropCount++;
                }
                else
                {
                    jABSetSelectionByIndex["ClearSelectionFirst"] = true;
                    jABSetSelectionByIndexpropCount++;
                }

                if (jABSetSelectionByIndexrecoverOnFailure != null)
                {
                    if (jABSetSelectionByIndexrecoverOnFailure != null)
                    {
                        jABSetSelectionByIndex["RecoverOnFailure"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByIndexrecoverOnFailure);
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
                jABSetSelectionByIndex["Workflow"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByIndexworkflow);
                if (jABSetSelectionByIndexpropCount > 0)
                {
                    callPayload.Body = jABSetSelectionByIndex;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABSetSelectionByName([WorkflowExpression] Func<int> jABSetSelectionByNamesearchParentElementJABHandle, [WorkflowExpression] Func<string> jABSetSelectionByNameitemName, [WorkflowExpression] Func<string> jABSetSelectionByNameworkflow, [WorkflowExpression] Func<string> jABSetSelectionByNamesearchElementJABName = null, [WorkflowExpression] Func<string> jABSetSelectionByNamesearchElementJABDescription = null, [WorkflowExpression] Func<string> jABSetSelectionByNamesearchElementJABRole = null, [WorkflowExpression] Func<bool> jABSetSelectionByNamesearchSubTree = null, [WorkflowExpression] Func<int> jABSetSelectionByNamemaxRelativeDepth = null, [WorkflowExpression] Func<int> jABSetSelectionByNamematchIndex = null, [WorkflowExpression] Func<string> jABSetSelectionByNamesearchFilter = null, [WorkflowExpression] Func<string> jABSetSelectionByNamesortByColumn = null, [WorkflowExpression] Func<bool> jABSetSelectionByNamematchIndexAscending = null, [WorkflowExpression] Func<bool> jABSetSelectionByNamecaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABSetSelectionByNameonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABSetSelectionByNameonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABSetSelectionByNameelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABSetSelectionByNamemaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABSetSelectionByNamemaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<bool> jABSetSelectionByNameselectItem = null, [WorkflowExpression] Func<bool> jABSetSelectionByNameitemNameCaseSensitive = null, [WorkflowExpression] Func<bool> jABSetSelectionByNameclearSelectionFirst = null, [WorkflowExpression] Func<bool> jABSetSelectionByNamegetListOfOptionsBySelecting = null, [WorkflowExpression] Func<bool> jABSetSelectionByNamegetListOfOptionsByReadingLabels = null, [WorkflowExpression] Func<bool> jABSetSelectionByNameexpandFirst = null, [WorkflowExpression] Func<bool> jABSetSelectionByNamecollapseAfter = null, [WorkflowExpression] Func<double> jABSetSelectionByNamesecondsBetweenExpandCollapse = null, [WorkflowExpression] Func<bool> jABSetSelectionByNameforceEvenIfInCorrectState = null, [WorkflowExpression] Func<bool> jABSetSelectionByNamerecoverOnFailure = null)
        {
            SourceExpression.Validate(jABSetSelectionByNamesearchParentElementJABHandle, nameof(jABSetSelectionByNamesearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABSetSelectionByNameitemName, nameof(jABSetSelectionByNameitemName), required: true);
            SourceExpression.Validate(jABSetSelectionByNameworkflow, nameof(jABSetSelectionByNameworkflow), required: true);
            SourceExpression.Validate(jABSetSelectionByNamesearchElementJABName, nameof(jABSetSelectionByNamesearchElementJABName), required: false);
            SourceExpression.Validate(jABSetSelectionByNamesearchElementJABDescription, nameof(jABSetSelectionByNamesearchElementJABDescription), required: false);
            SourceExpression.Validate(jABSetSelectionByNamesearchElementJABRole, nameof(jABSetSelectionByNamesearchElementJABRole), required: false);
            SourceExpression.Validate(jABSetSelectionByNamesearchSubTree, nameof(jABSetSelectionByNamesearchSubTree), required: false);
            SourceExpression.Validate(jABSetSelectionByNamemaxRelativeDepth, nameof(jABSetSelectionByNamemaxRelativeDepth), required: false);
            SourceExpression.Validate(jABSetSelectionByNamematchIndex, nameof(jABSetSelectionByNamematchIndex), required: false);
            SourceExpression.Validate(jABSetSelectionByNamesearchFilter, nameof(jABSetSelectionByNamesearchFilter), required: false);
            SourceExpression.Validate(jABSetSelectionByNamesortByColumn, nameof(jABSetSelectionByNamesortByColumn), required: false);
            SourceExpression.Validate(jABSetSelectionByNamematchIndexAscending, nameof(jABSetSelectionByNamematchIndexAscending), required: false);
            SourceExpression.Validate(jABSetSelectionByNamecaseSensitiveSearch, nameof(jABSetSelectionByNamecaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABSetSelectionByNameonlySearchVisibleElements, nameof(jABSetSelectionByNameonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABSetSelectionByNameonlySearchShowingElements, nameof(jABSetSelectionByNameonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABSetSelectionByNameelementRolesNotToTraverse, nameof(jABSetSelectionByNameelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABSetSelectionByNamemaximumElementsToSearch, nameof(jABSetSelectionByNamemaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABSetSelectionByNamemaximumChildElementsToSearchPerNode, nameof(jABSetSelectionByNamemaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABSetSelectionByNameselectItem, nameof(jABSetSelectionByNameselectItem), required: false);
            SourceExpression.Validate(jABSetSelectionByNameitemNameCaseSensitive, nameof(jABSetSelectionByNameitemNameCaseSensitive), required: false);
            SourceExpression.Validate(jABSetSelectionByNameclearSelectionFirst, nameof(jABSetSelectionByNameclearSelectionFirst), required: false);
            SourceExpression.Validate(jABSetSelectionByNamegetListOfOptionsBySelecting, nameof(jABSetSelectionByNamegetListOfOptionsBySelecting), required: false);
            SourceExpression.Validate(jABSetSelectionByNamegetListOfOptionsByReadingLabels, nameof(jABSetSelectionByNamegetListOfOptionsByReadingLabels), required: false);
            SourceExpression.Validate(jABSetSelectionByNameexpandFirst, nameof(jABSetSelectionByNameexpandFirst), required: false);
            SourceExpression.Validate(jABSetSelectionByNamecollapseAfter, nameof(jABSetSelectionByNamecollapseAfter), required: false);
            SourceExpression.Validate(jABSetSelectionByNamesecondsBetweenExpandCollapse, nameof(jABSetSelectionByNamesecondsBetweenExpandCollapse), required: false);
            SourceExpression.Validate(jABSetSelectionByNameforceEvenIfInCorrectState, nameof(jABSetSelectionByNameforceEvenIfInCorrectState), required: false);
            SourceExpression.Validate(jABSetSelectionByNamerecoverOnFailure, nameof(jABSetSelectionByNamerecoverOnFailure), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABSetSelectionByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABSetSelectionByName = new JObject();
                var jABSetSelectionByNamepropCount = 0;
                jABSetSelectionByNamepropCount++;
                jABSetSelectionByName["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNamesearchParentElementJABHandle);
                if (jABSetSelectionByNamesearchElementJABName != null)
                {
                    jABSetSelectionByName["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNamesearchElementJABName);
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNamesearchElementJABDescription != null)
                {
                    jABSetSelectionByName["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNamesearchElementJABDescription);
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNamesearchElementJABRole != null)
                {
                    jABSetSelectionByName["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNamesearchElementJABRole);
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNamesearchSubTree != null)
                {
                    if (jABSetSelectionByNamesearchSubTree != null)
                    {
                        jABSetSelectionByName["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNamesearchSubTree);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["SearchSubTree"] = true;
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNamemaxRelativeDepth != null)
                {
                    if (jABSetSelectionByNamemaxRelativeDepth != null)
                    {
                        jABSetSelectionByName["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNamemaxRelativeDepth);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["MaxRelativeDepth"] = 0;
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNamematchIndex != null)
                {
                    if (jABSetSelectionByNamematchIndex != null)
                    {
                        jABSetSelectionByName["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNamematchIndex);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["MatchIndex"] = 1;
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNamesearchFilter != null)
                {
                    jABSetSelectionByName["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNamesearchFilter);
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNamesortByColumn != null)
                {
                    jABSetSelectionByName["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNamesortByColumn);
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNamematchIndexAscending != null)
                {
                    if (jABSetSelectionByNamematchIndexAscending != null)
                    {
                        jABSetSelectionByName["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNamematchIndexAscending);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["MatchIndexAscending"] = true;
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNamecaseSensitiveSearch != null)
                {
                    if (jABSetSelectionByNamecaseSensitiveSearch != null)
                    {
                        jABSetSelectionByName["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNamecaseSensitiveSearch);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["CaseSensitiveSearch"] = false;
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNameonlySearchVisibleElements != null)
                {
                    if (jABSetSelectionByNameonlySearchVisibleElements != null)
                    {
                        jABSetSelectionByName["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNameonlySearchVisibleElements);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["OnlySearchVisibleElements"] = true;
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNameonlySearchShowingElements != null)
                {
                    if (jABSetSelectionByNameonlySearchShowingElements != null)
                    {
                        jABSetSelectionByName["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNameonlySearchShowingElements);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["OnlySearchShowingElements"] = true;
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNameelementRolesNotToTraverse != null)
                {
                    jABSetSelectionByName["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNameelementRolesNotToTraverse);
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNamemaximumElementsToSearch != null)
                {
                    if (jABSetSelectionByNamemaximumElementsToSearch != null)
                    {
                        jABSetSelectionByName["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNamemaximumElementsToSearch);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["MaximumElementsToSearch"] = 2000;
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNamemaximumChildElementsToSearchPerNode != null)
                {
                    if (jABSetSelectionByNamemaximumChildElementsToSearchPerNode != null)
                    {
                        jABSetSelectionByName["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNamemaximumChildElementsToSearchPerNode);
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
                jABSetSelectionByName["ItemName"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNameitemName);
                if (jABSetSelectionByNameselectItem != null)
                {
                    if (jABSetSelectionByNameselectItem != null)
                    {
                        jABSetSelectionByName["SelectItem"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNameselectItem);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["SelectItem"] = true;
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNameitemNameCaseSensitive != null)
                {
                    if (jABSetSelectionByNameitemNameCaseSensitive != null)
                    {
                        jABSetSelectionByName["ItemNameCaseSensitive"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNameitemNameCaseSensitive);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["ItemNameCaseSensitive"] = false;
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNameclearSelectionFirst != null)
                {
                    if (jABSetSelectionByNameclearSelectionFirst != null)
                    {
                        jABSetSelectionByName["ClearSelectionFirst"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNameclearSelectionFirst);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["ClearSelectionFirst"] = true;
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNamegetListOfOptionsBySelecting != null)
                {
                    if (jABSetSelectionByNamegetListOfOptionsBySelecting != null)
                    {
                        jABSetSelectionByName["GetListOfOptionsBySelecting"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNamegetListOfOptionsBySelecting);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["GetListOfOptionsBySelecting"] = false;
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNamegetListOfOptionsByReadingLabels != null)
                {
                    if (jABSetSelectionByNamegetListOfOptionsByReadingLabels != null)
                    {
                        jABSetSelectionByName["GetListOfOptionsByReadingLabels"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNamegetListOfOptionsByReadingLabels);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["GetListOfOptionsByReadingLabels"] = true;
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNameexpandFirst != null)
                {
                    if (jABSetSelectionByNameexpandFirst != null)
                    {
                        jABSetSelectionByName["ExpandFirst"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNameexpandFirst);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["ExpandFirst"] = true;
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNamecollapseAfter != null)
                {
                    if (jABSetSelectionByNamecollapseAfter != null)
                    {
                        jABSetSelectionByName["CollapseAfter"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNamecollapseAfter);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["CollapseAfter"] = true;
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNamesecondsBetweenExpandCollapse != null)
                {
                    if (jABSetSelectionByNamesecondsBetweenExpandCollapse != null)
                    {
                        jABSetSelectionByName["SecondsBetweenExpandCollapse"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNamesecondsBetweenExpandCollapse);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["SecondsBetweenExpandCollapse"] = 0.05;
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNameforceEvenIfInCorrectState != null)
                {
                    if (jABSetSelectionByNameforceEvenIfInCorrectState != null)
                    {
                        jABSetSelectionByName["ForceEvenIfInCorrectState"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNameforceEvenIfInCorrectState);
                        jABSetSelectionByNamepropCount++;
                    }

                    jABSetSelectionByNamepropCount++;
                }
                else
                {
                    jABSetSelectionByName["ForceEvenIfInCorrectState"] = false;
                    jABSetSelectionByNamepropCount++;
                }

                if (jABSetSelectionByNamerecoverOnFailure != null)
                {
                    if (jABSetSelectionByNamerecoverOnFailure != null)
                    {
                        jABSetSelectionByName["RecoverOnFailure"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNamerecoverOnFailure);
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
                jABSetSelectionByName["Workflow"] = SourceExpressionConverter.ConvertToken(jABSetSelectionByNameworkflow);
                if (jABSetSelectionByNamepropCount > 0)
                {
                    callPayload.Body = jABSetSelectionByName;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABExpandSelection([WorkflowExpression] Func<int> jABExpandSelectionsearchParentElementJABHandle, [WorkflowExpression] Func<string> jABExpandSelectionworkflow, [WorkflowExpression] Func<string> jABExpandSelectionsearchElementJABName = null, [WorkflowExpression] Func<string> jABExpandSelectionsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABExpandSelectionsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABExpandSelectionsearchSubTree = null, [WorkflowExpression] Func<int> jABExpandSelectionmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABExpandSelectionmatchIndex = null, [WorkflowExpression] Func<string> jABExpandSelectionsearchFilter = null, [WorkflowExpression] Func<string> jABExpandSelectionsortByColumn = null, [WorkflowExpression] Func<bool> jABExpandSelectionmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABExpandSelectioncaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABExpandSelectiononlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABExpandSelectiononlySearchShowingElements = null, [WorkflowExpression] Func<string> jABExpandSelectionelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABExpandSelectionmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABExpandSelectionmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<bool> jABExpandSelectionexpand = null, [WorkflowExpression] Func<bool> jABExpandSelectionverifyElementState = null, [WorkflowExpression] Func<double> jABExpandSelectionsecondsToWaitForStateChange = null)
        {
            SourceExpression.Validate(jABExpandSelectionsearchParentElementJABHandle, nameof(jABExpandSelectionsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABExpandSelectionworkflow, nameof(jABExpandSelectionworkflow), required: true);
            SourceExpression.Validate(jABExpandSelectionsearchElementJABName, nameof(jABExpandSelectionsearchElementJABName), required: false);
            SourceExpression.Validate(jABExpandSelectionsearchElementJABDescription, nameof(jABExpandSelectionsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABExpandSelectionsearchElementJABRole, nameof(jABExpandSelectionsearchElementJABRole), required: false);
            SourceExpression.Validate(jABExpandSelectionsearchSubTree, nameof(jABExpandSelectionsearchSubTree), required: false);
            SourceExpression.Validate(jABExpandSelectionmaxRelativeDepth, nameof(jABExpandSelectionmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABExpandSelectionmatchIndex, nameof(jABExpandSelectionmatchIndex), required: false);
            SourceExpression.Validate(jABExpandSelectionsearchFilter, nameof(jABExpandSelectionsearchFilter), required: false);
            SourceExpression.Validate(jABExpandSelectionsortByColumn, nameof(jABExpandSelectionsortByColumn), required: false);
            SourceExpression.Validate(jABExpandSelectionmatchIndexAscending, nameof(jABExpandSelectionmatchIndexAscending), required: false);
            SourceExpression.Validate(jABExpandSelectioncaseSensitiveSearch, nameof(jABExpandSelectioncaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABExpandSelectiononlySearchVisibleElements, nameof(jABExpandSelectiononlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABExpandSelectiononlySearchShowingElements, nameof(jABExpandSelectiononlySearchShowingElements), required: false);
            SourceExpression.Validate(jABExpandSelectionelementRolesNotToTraverse, nameof(jABExpandSelectionelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABExpandSelectionmaximumElementsToSearch, nameof(jABExpandSelectionmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABExpandSelectionmaximumChildElementsToSearchPerNode, nameof(jABExpandSelectionmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABExpandSelectionexpand, nameof(jABExpandSelectionexpand), required: false);
            SourceExpression.Validate(jABExpandSelectionverifyElementState, nameof(jABExpandSelectionverifyElementState), required: false);
            SourceExpression.Validate(jABExpandSelectionsecondsToWaitForStateChange, nameof(jABExpandSelectionsecondsToWaitForStateChange), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABExpandSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABExpandSelection = new JObject();
                var jABExpandSelectionpropCount = 0;
                jABExpandSelectionpropCount++;
                jABExpandSelection["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABExpandSelectionsearchParentElementJABHandle);
                if (jABExpandSelectionsearchElementJABName != null)
                {
                    jABExpandSelection["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABExpandSelectionsearchElementJABName);
                    jABExpandSelectionpropCount++;
                }

                if (jABExpandSelectionsearchElementJABDescription != null)
                {
                    jABExpandSelection["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABExpandSelectionsearchElementJABDescription);
                    jABExpandSelectionpropCount++;
                }

                if (jABExpandSelectionsearchElementJABRole != null)
                {
                    jABExpandSelection["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABExpandSelectionsearchElementJABRole);
                    jABExpandSelectionpropCount++;
                }

                if (jABExpandSelectionsearchSubTree != null)
                {
                    if (jABExpandSelectionsearchSubTree != null)
                    {
                        jABExpandSelection["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABExpandSelectionsearchSubTree);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["SearchSubTree"] = true;
                    jABExpandSelectionpropCount++;
                }

                if (jABExpandSelectionmaxRelativeDepth != null)
                {
                    if (jABExpandSelectionmaxRelativeDepth != null)
                    {
                        jABExpandSelection["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABExpandSelectionmaxRelativeDepth);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["MaxRelativeDepth"] = 0;
                    jABExpandSelectionpropCount++;
                }

                if (jABExpandSelectionmatchIndex != null)
                {
                    if (jABExpandSelectionmatchIndex != null)
                    {
                        jABExpandSelection["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABExpandSelectionmatchIndex);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["MatchIndex"] = 1;
                    jABExpandSelectionpropCount++;
                }

                if (jABExpandSelectionsearchFilter != null)
                {
                    jABExpandSelection["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABExpandSelectionsearchFilter);
                    jABExpandSelectionpropCount++;
                }

                if (jABExpandSelectionsortByColumn != null)
                {
                    jABExpandSelection["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABExpandSelectionsortByColumn);
                    jABExpandSelectionpropCount++;
                }

                if (jABExpandSelectionmatchIndexAscending != null)
                {
                    if (jABExpandSelectionmatchIndexAscending != null)
                    {
                        jABExpandSelection["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABExpandSelectionmatchIndexAscending);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["MatchIndexAscending"] = true;
                    jABExpandSelectionpropCount++;
                }

                if (jABExpandSelectioncaseSensitiveSearch != null)
                {
                    if (jABExpandSelectioncaseSensitiveSearch != null)
                    {
                        jABExpandSelection["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABExpandSelectioncaseSensitiveSearch);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["CaseSensitiveSearch"] = false;
                    jABExpandSelectionpropCount++;
                }

                if (jABExpandSelectiononlySearchVisibleElements != null)
                {
                    if (jABExpandSelectiononlySearchVisibleElements != null)
                    {
                        jABExpandSelection["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABExpandSelectiononlySearchVisibleElements);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["OnlySearchVisibleElements"] = true;
                    jABExpandSelectionpropCount++;
                }

                if (jABExpandSelectiononlySearchShowingElements != null)
                {
                    if (jABExpandSelectiononlySearchShowingElements != null)
                    {
                        jABExpandSelection["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABExpandSelectiononlySearchShowingElements);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["OnlySearchShowingElements"] = true;
                    jABExpandSelectionpropCount++;
                }

                if (jABExpandSelectionelementRolesNotToTraverse != null)
                {
                    jABExpandSelection["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABExpandSelectionelementRolesNotToTraverse);
                    jABExpandSelectionpropCount++;
                }

                if (jABExpandSelectionmaximumElementsToSearch != null)
                {
                    if (jABExpandSelectionmaximumElementsToSearch != null)
                    {
                        jABExpandSelection["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABExpandSelectionmaximumElementsToSearch);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["MaximumElementsToSearch"] = 2000;
                    jABExpandSelectionpropCount++;
                }

                if (jABExpandSelectionmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABExpandSelectionmaximumChildElementsToSearchPerNode != null)
                    {
                        jABExpandSelection["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABExpandSelectionmaximumChildElementsToSearchPerNode);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["MaximumChildElementsToSearchPerNode"] = 200;
                    jABExpandSelectionpropCount++;
                }

                if (jABExpandSelectionexpand != null)
                {
                    if (jABExpandSelectionexpand != null)
                    {
                        jABExpandSelection["Expand"] = SourceExpressionConverter.ConvertToken(jABExpandSelectionexpand);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["Expand"] = true;
                    jABExpandSelectionpropCount++;
                }

                if (jABExpandSelectionverifyElementState != null)
                {
                    if (jABExpandSelectionverifyElementState != null)
                    {
                        jABExpandSelection["VerifyElementState"] = SourceExpressionConverter.ConvertToken(jABExpandSelectionverifyElementState);
                        jABExpandSelectionpropCount++;
                    }

                    jABExpandSelectionpropCount++;
                }
                else
                {
                    jABExpandSelection["VerifyElementState"] = false;
                    jABExpandSelectionpropCount++;
                }

                if (jABExpandSelectionsecondsToWaitForStateChange != null)
                {
                    if (jABExpandSelectionsecondsToWaitForStateChange != null)
                    {
                        jABExpandSelection["SecondsToWaitForStateChange"] = SourceExpressionConverter.ConvertToken(jABExpandSelectionsecondsToWaitForStateChange);
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
                jABExpandSelection["Workflow"] = SourceExpressionConverter.ConvertToken(jABExpandSelectionworkflow);
                if (jABExpandSelectionpropCount > 0)
                {
                    callPayload.Body = jABExpandSelection;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetSelectionStateByIndexResponse> JABGetSelectionStateByIndex([WorkflowExpression] Func<int> jABGetSelectionStateByIndexsearchParentElementJABHandle, [WorkflowExpression] Func<int> jABGetSelectionStateByIndexitemIndex, [WorkflowExpression] Func<string> jABGetSelectionStateByIndexworkflow, [WorkflowExpression] Func<string> jABGetSelectionStateByIndexsearchElementJABName = null, [WorkflowExpression] Func<string> jABGetSelectionStateByIndexsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABGetSelectionStateByIndexsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABGetSelectionStateByIndexsearchSubTree = null, [WorkflowExpression] Func<int> jABGetSelectionStateByIndexmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABGetSelectionStateByIndexmatchIndex = null, [WorkflowExpression] Func<string> jABGetSelectionStateByIndexsearchFilter = null, [WorkflowExpression] Func<string> jABGetSelectionStateByIndexsortByColumn = null, [WorkflowExpression] Func<bool> jABGetSelectionStateByIndexmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABGetSelectionStateByIndexcaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABGetSelectionStateByIndexonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABGetSelectionStateByIndexonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABGetSelectionStateByIndexelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABGetSelectionStateByIndexmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABGetSelectionStateByIndexmaximumChildElementsToSearchPerNode = null)
        {
            SourceExpression.Validate(jABGetSelectionStateByIndexsearchParentElementJABHandle, nameof(jABGetSelectionStateByIndexsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABGetSelectionStateByIndexitemIndex, nameof(jABGetSelectionStateByIndexitemIndex), required: true);
            SourceExpression.Validate(jABGetSelectionStateByIndexworkflow, nameof(jABGetSelectionStateByIndexworkflow), required: true);
            SourceExpression.Validate(jABGetSelectionStateByIndexsearchElementJABName, nameof(jABGetSelectionStateByIndexsearchElementJABName), required: false);
            SourceExpression.Validate(jABGetSelectionStateByIndexsearchElementJABDescription, nameof(jABGetSelectionStateByIndexsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABGetSelectionStateByIndexsearchElementJABRole, nameof(jABGetSelectionStateByIndexsearchElementJABRole), required: false);
            SourceExpression.Validate(jABGetSelectionStateByIndexsearchSubTree, nameof(jABGetSelectionStateByIndexsearchSubTree), required: false);
            SourceExpression.Validate(jABGetSelectionStateByIndexmaxRelativeDepth, nameof(jABGetSelectionStateByIndexmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABGetSelectionStateByIndexmatchIndex, nameof(jABGetSelectionStateByIndexmatchIndex), required: false);
            SourceExpression.Validate(jABGetSelectionStateByIndexsearchFilter, nameof(jABGetSelectionStateByIndexsearchFilter), required: false);
            SourceExpression.Validate(jABGetSelectionStateByIndexsortByColumn, nameof(jABGetSelectionStateByIndexsortByColumn), required: false);
            SourceExpression.Validate(jABGetSelectionStateByIndexmatchIndexAscending, nameof(jABGetSelectionStateByIndexmatchIndexAscending), required: false);
            SourceExpression.Validate(jABGetSelectionStateByIndexcaseSensitiveSearch, nameof(jABGetSelectionStateByIndexcaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABGetSelectionStateByIndexonlySearchVisibleElements, nameof(jABGetSelectionStateByIndexonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABGetSelectionStateByIndexonlySearchShowingElements, nameof(jABGetSelectionStateByIndexonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABGetSelectionStateByIndexelementRolesNotToTraverse, nameof(jABGetSelectionStateByIndexelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABGetSelectionStateByIndexmaximumElementsToSearch, nameof(jABGetSelectionStateByIndexmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABGetSelectionStateByIndexmaximumChildElementsToSearchPerNode, nameof(jABGetSelectionStateByIndexmaximumChildElementsToSearchPerNode), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetSelectionStateByIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetSelectionStateByIndex = new JObject();
                var jABGetSelectionStateByIndexpropCount = 0;
                jABGetSelectionStateByIndexpropCount++;
                jABGetSelectionStateByIndex["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByIndexsearchParentElementJABHandle);
                if (jABGetSelectionStateByIndexsearchElementJABName != null)
                {
                    jABGetSelectionStateByIndex["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByIndexsearchElementJABName);
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (jABGetSelectionStateByIndexsearchElementJABDescription != null)
                {
                    jABGetSelectionStateByIndex["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByIndexsearchElementJABDescription);
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (jABGetSelectionStateByIndexsearchElementJABRole != null)
                {
                    jABGetSelectionStateByIndex["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByIndexsearchElementJABRole);
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (jABGetSelectionStateByIndexsearchSubTree != null)
                {
                    if (jABGetSelectionStateByIndexsearchSubTree != null)
                    {
                        jABGetSelectionStateByIndex["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByIndexsearchSubTree);
                        jABGetSelectionStateByIndexpropCount++;
                    }

                    jABGetSelectionStateByIndexpropCount++;
                }
                else
                {
                    jABGetSelectionStateByIndex["SearchSubTree"] = true;
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (jABGetSelectionStateByIndexmaxRelativeDepth != null)
                {
                    if (jABGetSelectionStateByIndexmaxRelativeDepth != null)
                    {
                        jABGetSelectionStateByIndex["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByIndexmaxRelativeDepth);
                        jABGetSelectionStateByIndexpropCount++;
                    }

                    jABGetSelectionStateByIndexpropCount++;
                }
                else
                {
                    jABGetSelectionStateByIndex["MaxRelativeDepth"] = 0;
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (jABGetSelectionStateByIndexmatchIndex != null)
                {
                    if (jABGetSelectionStateByIndexmatchIndex != null)
                    {
                        jABGetSelectionStateByIndex["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByIndexmatchIndex);
                        jABGetSelectionStateByIndexpropCount++;
                    }

                    jABGetSelectionStateByIndexpropCount++;
                }
                else
                {
                    jABGetSelectionStateByIndex["MatchIndex"] = 1;
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (jABGetSelectionStateByIndexsearchFilter != null)
                {
                    jABGetSelectionStateByIndex["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByIndexsearchFilter);
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (jABGetSelectionStateByIndexsortByColumn != null)
                {
                    jABGetSelectionStateByIndex["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByIndexsortByColumn);
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (jABGetSelectionStateByIndexmatchIndexAscending != null)
                {
                    if (jABGetSelectionStateByIndexmatchIndexAscending != null)
                    {
                        jABGetSelectionStateByIndex["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByIndexmatchIndexAscending);
                        jABGetSelectionStateByIndexpropCount++;
                    }

                    jABGetSelectionStateByIndexpropCount++;
                }
                else
                {
                    jABGetSelectionStateByIndex["MatchIndexAscending"] = true;
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (jABGetSelectionStateByIndexcaseSensitiveSearch != null)
                {
                    if (jABGetSelectionStateByIndexcaseSensitiveSearch != null)
                    {
                        jABGetSelectionStateByIndex["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByIndexcaseSensitiveSearch);
                        jABGetSelectionStateByIndexpropCount++;
                    }

                    jABGetSelectionStateByIndexpropCount++;
                }
                else
                {
                    jABGetSelectionStateByIndex["CaseSensitiveSearch"] = false;
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (jABGetSelectionStateByIndexonlySearchVisibleElements != null)
                {
                    if (jABGetSelectionStateByIndexonlySearchVisibleElements != null)
                    {
                        jABGetSelectionStateByIndex["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByIndexonlySearchVisibleElements);
                        jABGetSelectionStateByIndexpropCount++;
                    }

                    jABGetSelectionStateByIndexpropCount++;
                }
                else
                {
                    jABGetSelectionStateByIndex["OnlySearchVisibleElements"] = true;
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (jABGetSelectionStateByIndexonlySearchShowingElements != null)
                {
                    if (jABGetSelectionStateByIndexonlySearchShowingElements != null)
                    {
                        jABGetSelectionStateByIndex["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByIndexonlySearchShowingElements);
                        jABGetSelectionStateByIndexpropCount++;
                    }

                    jABGetSelectionStateByIndexpropCount++;
                }
                else
                {
                    jABGetSelectionStateByIndex["OnlySearchShowingElements"] = true;
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (jABGetSelectionStateByIndexelementRolesNotToTraverse != null)
                {
                    jABGetSelectionStateByIndex["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByIndexelementRolesNotToTraverse);
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (jABGetSelectionStateByIndexmaximumElementsToSearch != null)
                {
                    if (jABGetSelectionStateByIndexmaximumElementsToSearch != null)
                    {
                        jABGetSelectionStateByIndex["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByIndexmaximumElementsToSearch);
                        jABGetSelectionStateByIndexpropCount++;
                    }

                    jABGetSelectionStateByIndexpropCount++;
                }
                else
                {
                    jABGetSelectionStateByIndex["MaximumElementsToSearch"] = 2000;
                    jABGetSelectionStateByIndexpropCount++;
                }

                if (jABGetSelectionStateByIndexmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABGetSelectionStateByIndexmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetSelectionStateByIndex["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByIndexmaximumChildElementsToSearchPerNode);
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
                jABGetSelectionStateByIndex["ItemIndex"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByIndexitemIndex);
                jABGetSelectionStateByIndexpropCount++;
                jABGetSelectionStateByIndex["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByIndexworkflow);
                if (jABGetSelectionStateByIndexpropCount > 0)
                {
                    callPayload.Body = jABGetSelectionStateByIndex;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetSelectionStateByIndexResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetSelectionStateByNameResponse> JABGetSelectionStateByName([WorkflowExpression] Func<int> jABGetSelectionStateByNamesearchParentElementJABHandle, [WorkflowExpression] Func<string> jABGetSelectionStateByNameitemName, [WorkflowExpression] Func<string> jABGetSelectionStateByNameworkflow, [WorkflowExpression] Func<string> jABGetSelectionStateByNamesearchElementJABName = null, [WorkflowExpression] Func<string> jABGetSelectionStateByNamesearchElementJABDescription = null, [WorkflowExpression] Func<string> jABGetSelectionStateByNamesearchElementJABRole = null, [WorkflowExpression] Func<bool> jABGetSelectionStateByNamesearchSubTree = null, [WorkflowExpression] Func<int> jABGetSelectionStateByNamemaxRelativeDepth = null, [WorkflowExpression] Func<int> jABGetSelectionStateByNamematchIndex = null, [WorkflowExpression] Func<string> jABGetSelectionStateByNamesearchFilter = null, [WorkflowExpression] Func<string> jABGetSelectionStateByNamesortByColumn = null, [WorkflowExpression] Func<bool> jABGetSelectionStateByNamematchIndexAscending = null, [WorkflowExpression] Func<bool> jABGetSelectionStateByNamecaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABGetSelectionStateByNameonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABGetSelectionStateByNameonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABGetSelectionStateByNameelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABGetSelectionStateByNamemaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABGetSelectionStateByNamemaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<bool> jABGetSelectionStateByNameitemNameCaseSensitive = null)
        {
            SourceExpression.Validate(jABGetSelectionStateByNamesearchParentElementJABHandle, nameof(jABGetSelectionStateByNamesearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABGetSelectionStateByNameitemName, nameof(jABGetSelectionStateByNameitemName), required: true);
            SourceExpression.Validate(jABGetSelectionStateByNameworkflow, nameof(jABGetSelectionStateByNameworkflow), required: true);
            SourceExpression.Validate(jABGetSelectionStateByNamesearchElementJABName, nameof(jABGetSelectionStateByNamesearchElementJABName), required: false);
            SourceExpression.Validate(jABGetSelectionStateByNamesearchElementJABDescription, nameof(jABGetSelectionStateByNamesearchElementJABDescription), required: false);
            SourceExpression.Validate(jABGetSelectionStateByNamesearchElementJABRole, nameof(jABGetSelectionStateByNamesearchElementJABRole), required: false);
            SourceExpression.Validate(jABGetSelectionStateByNamesearchSubTree, nameof(jABGetSelectionStateByNamesearchSubTree), required: false);
            SourceExpression.Validate(jABGetSelectionStateByNamemaxRelativeDepth, nameof(jABGetSelectionStateByNamemaxRelativeDepth), required: false);
            SourceExpression.Validate(jABGetSelectionStateByNamematchIndex, nameof(jABGetSelectionStateByNamematchIndex), required: false);
            SourceExpression.Validate(jABGetSelectionStateByNamesearchFilter, nameof(jABGetSelectionStateByNamesearchFilter), required: false);
            SourceExpression.Validate(jABGetSelectionStateByNamesortByColumn, nameof(jABGetSelectionStateByNamesortByColumn), required: false);
            SourceExpression.Validate(jABGetSelectionStateByNamematchIndexAscending, nameof(jABGetSelectionStateByNamematchIndexAscending), required: false);
            SourceExpression.Validate(jABGetSelectionStateByNamecaseSensitiveSearch, nameof(jABGetSelectionStateByNamecaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABGetSelectionStateByNameonlySearchVisibleElements, nameof(jABGetSelectionStateByNameonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABGetSelectionStateByNameonlySearchShowingElements, nameof(jABGetSelectionStateByNameonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABGetSelectionStateByNameelementRolesNotToTraverse, nameof(jABGetSelectionStateByNameelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABGetSelectionStateByNamemaximumElementsToSearch, nameof(jABGetSelectionStateByNamemaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABGetSelectionStateByNamemaximumChildElementsToSearchPerNode, nameof(jABGetSelectionStateByNamemaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABGetSelectionStateByNameitemNameCaseSensitive, nameof(jABGetSelectionStateByNameitemNameCaseSensitive), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetSelectionStateByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetSelectionStateByName = new JObject();
                var jABGetSelectionStateByNamepropCount = 0;
                jABGetSelectionStateByNamepropCount++;
                jABGetSelectionStateByName["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByNamesearchParentElementJABHandle);
                if (jABGetSelectionStateByNamesearchElementJABName != null)
                {
                    jABGetSelectionStateByName["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByNamesearchElementJABName);
                    jABGetSelectionStateByNamepropCount++;
                }

                if (jABGetSelectionStateByNamesearchElementJABDescription != null)
                {
                    jABGetSelectionStateByName["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByNamesearchElementJABDescription);
                    jABGetSelectionStateByNamepropCount++;
                }

                if (jABGetSelectionStateByNamesearchElementJABRole != null)
                {
                    jABGetSelectionStateByName["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByNamesearchElementJABRole);
                    jABGetSelectionStateByNamepropCount++;
                }

                if (jABGetSelectionStateByNamesearchSubTree != null)
                {
                    if (jABGetSelectionStateByNamesearchSubTree != null)
                    {
                        jABGetSelectionStateByName["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByNamesearchSubTree);
                        jABGetSelectionStateByNamepropCount++;
                    }

                    jABGetSelectionStateByNamepropCount++;
                }
                else
                {
                    jABGetSelectionStateByName["SearchSubTree"] = true;
                    jABGetSelectionStateByNamepropCount++;
                }

                if (jABGetSelectionStateByNamemaxRelativeDepth != null)
                {
                    if (jABGetSelectionStateByNamemaxRelativeDepth != null)
                    {
                        jABGetSelectionStateByName["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByNamemaxRelativeDepth);
                        jABGetSelectionStateByNamepropCount++;
                    }

                    jABGetSelectionStateByNamepropCount++;
                }
                else
                {
                    jABGetSelectionStateByName["MaxRelativeDepth"] = 0;
                    jABGetSelectionStateByNamepropCount++;
                }

                if (jABGetSelectionStateByNamematchIndex != null)
                {
                    if (jABGetSelectionStateByNamematchIndex != null)
                    {
                        jABGetSelectionStateByName["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByNamematchIndex);
                        jABGetSelectionStateByNamepropCount++;
                    }

                    jABGetSelectionStateByNamepropCount++;
                }
                else
                {
                    jABGetSelectionStateByName["MatchIndex"] = 1;
                    jABGetSelectionStateByNamepropCount++;
                }

                if (jABGetSelectionStateByNamesearchFilter != null)
                {
                    jABGetSelectionStateByName["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByNamesearchFilter);
                    jABGetSelectionStateByNamepropCount++;
                }

                if (jABGetSelectionStateByNamesortByColumn != null)
                {
                    jABGetSelectionStateByName["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByNamesortByColumn);
                    jABGetSelectionStateByNamepropCount++;
                }

                if (jABGetSelectionStateByNamematchIndexAscending != null)
                {
                    if (jABGetSelectionStateByNamematchIndexAscending != null)
                    {
                        jABGetSelectionStateByName["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByNamematchIndexAscending);
                        jABGetSelectionStateByNamepropCount++;
                    }

                    jABGetSelectionStateByNamepropCount++;
                }
                else
                {
                    jABGetSelectionStateByName["MatchIndexAscending"] = true;
                    jABGetSelectionStateByNamepropCount++;
                }

                if (jABGetSelectionStateByNamecaseSensitiveSearch != null)
                {
                    if (jABGetSelectionStateByNamecaseSensitiveSearch != null)
                    {
                        jABGetSelectionStateByName["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByNamecaseSensitiveSearch);
                        jABGetSelectionStateByNamepropCount++;
                    }

                    jABGetSelectionStateByNamepropCount++;
                }
                else
                {
                    jABGetSelectionStateByName["CaseSensitiveSearch"] = false;
                    jABGetSelectionStateByNamepropCount++;
                }

                if (jABGetSelectionStateByNameonlySearchVisibleElements != null)
                {
                    if (jABGetSelectionStateByNameonlySearchVisibleElements != null)
                    {
                        jABGetSelectionStateByName["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByNameonlySearchVisibleElements);
                        jABGetSelectionStateByNamepropCount++;
                    }

                    jABGetSelectionStateByNamepropCount++;
                }
                else
                {
                    jABGetSelectionStateByName["OnlySearchVisibleElements"] = true;
                    jABGetSelectionStateByNamepropCount++;
                }

                if (jABGetSelectionStateByNameonlySearchShowingElements != null)
                {
                    if (jABGetSelectionStateByNameonlySearchShowingElements != null)
                    {
                        jABGetSelectionStateByName["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByNameonlySearchShowingElements);
                        jABGetSelectionStateByNamepropCount++;
                    }

                    jABGetSelectionStateByNamepropCount++;
                }
                else
                {
                    jABGetSelectionStateByName["OnlySearchShowingElements"] = true;
                    jABGetSelectionStateByNamepropCount++;
                }

                if (jABGetSelectionStateByNameelementRolesNotToTraverse != null)
                {
                    jABGetSelectionStateByName["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByNameelementRolesNotToTraverse);
                    jABGetSelectionStateByNamepropCount++;
                }

                if (jABGetSelectionStateByNamemaximumElementsToSearch != null)
                {
                    if (jABGetSelectionStateByNamemaximumElementsToSearch != null)
                    {
                        jABGetSelectionStateByName["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByNamemaximumElementsToSearch);
                        jABGetSelectionStateByNamepropCount++;
                    }

                    jABGetSelectionStateByNamepropCount++;
                }
                else
                {
                    jABGetSelectionStateByName["MaximumElementsToSearch"] = 2000;
                    jABGetSelectionStateByNamepropCount++;
                }

                if (jABGetSelectionStateByNamemaximumChildElementsToSearchPerNode != null)
                {
                    if (jABGetSelectionStateByNamemaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetSelectionStateByName["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByNamemaximumChildElementsToSearchPerNode);
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
                jABGetSelectionStateByName["ItemName"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByNameitemName);
                if (jABGetSelectionStateByNameitemNameCaseSensitive != null)
                {
                    if (jABGetSelectionStateByNameitemNameCaseSensitive != null)
                    {
                        jABGetSelectionStateByName["ItemNameCaseSensitive"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByNameitemNameCaseSensitive);
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
                jABGetSelectionStateByName["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetSelectionStateByNameworkflow);
                if (jABGetSelectionStateByNamepropCount > 0)
                {
                    callPayload.Body = jABGetSelectionStateByName;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetSelectionStateByNameResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetTablePropertiesResponse> JABGetTableProperties([WorkflowExpression] Func<int> jABGetTablePropertiessearchParentElementJABHandle, [WorkflowExpression] Func<string> jABGetTablePropertiesworkflow, [WorkflowExpression] Func<string> jABGetTablePropertiessearchElementJABName = null, [WorkflowExpression] Func<string> jABGetTablePropertiessearchElementJABDescription = null, [WorkflowExpression] Func<string> jABGetTablePropertiessearchElementJABRole = null, [WorkflowExpression] Func<bool> jABGetTablePropertiessearchSubTree = null, [WorkflowExpression] Func<int> jABGetTablePropertiesmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABGetTablePropertiesmatchIndex = null, [WorkflowExpression] Func<string> jABGetTablePropertiessearchFilter = null, [WorkflowExpression] Func<string> jABGetTablePropertiessortByColumn = null, [WorkflowExpression] Func<bool> jABGetTablePropertiesmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABGetTablePropertiescaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABGetTablePropertiesonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABGetTablePropertiesonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABGetTablePropertieselementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABGetTablePropertiesmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABGetTablePropertiesmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<bool> jABGetTablePropertiesenumerateViewport = null, [WorkflowExpression] Func<bool> jABGetTablePropertiesprocessViewportParents = null, [WorkflowExpression] Func<int> jABGetTablePropertiesmaxViewportParentsToProcess = null, [WorkflowExpression] Func<string> jABGetTablePropertiesviewportParentElementRolesToConsider = null, [WorkflowExpression] Func<int> jABGetTablePropertiesviewportLeftMargin = null, [WorkflowExpression] Func<int> jABGetTablePropertiesviewportTopMargin = null, [WorkflowExpression] Func<int> jABGetTablePropertiesviewportRightMargin = null, [WorkflowExpression] Func<int> jABGetTablePropertiesviewportBottomMargin = null)
        {
            SourceExpression.Validate(jABGetTablePropertiessearchParentElementJABHandle, nameof(jABGetTablePropertiessearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABGetTablePropertiesworkflow, nameof(jABGetTablePropertiesworkflow), required: true);
            SourceExpression.Validate(jABGetTablePropertiessearchElementJABName, nameof(jABGetTablePropertiessearchElementJABName), required: false);
            SourceExpression.Validate(jABGetTablePropertiessearchElementJABDescription, nameof(jABGetTablePropertiessearchElementJABDescription), required: false);
            SourceExpression.Validate(jABGetTablePropertiessearchElementJABRole, nameof(jABGetTablePropertiessearchElementJABRole), required: false);
            SourceExpression.Validate(jABGetTablePropertiessearchSubTree, nameof(jABGetTablePropertiessearchSubTree), required: false);
            SourceExpression.Validate(jABGetTablePropertiesmaxRelativeDepth, nameof(jABGetTablePropertiesmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABGetTablePropertiesmatchIndex, nameof(jABGetTablePropertiesmatchIndex), required: false);
            SourceExpression.Validate(jABGetTablePropertiessearchFilter, nameof(jABGetTablePropertiessearchFilter), required: false);
            SourceExpression.Validate(jABGetTablePropertiessortByColumn, nameof(jABGetTablePropertiessortByColumn), required: false);
            SourceExpression.Validate(jABGetTablePropertiesmatchIndexAscending, nameof(jABGetTablePropertiesmatchIndexAscending), required: false);
            SourceExpression.Validate(jABGetTablePropertiescaseSensitiveSearch, nameof(jABGetTablePropertiescaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABGetTablePropertiesonlySearchVisibleElements, nameof(jABGetTablePropertiesonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABGetTablePropertiesonlySearchShowingElements, nameof(jABGetTablePropertiesonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABGetTablePropertieselementRolesNotToTraverse, nameof(jABGetTablePropertieselementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABGetTablePropertiesmaximumElementsToSearch, nameof(jABGetTablePropertiesmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABGetTablePropertiesmaximumChildElementsToSearchPerNode, nameof(jABGetTablePropertiesmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABGetTablePropertiesenumerateViewport, nameof(jABGetTablePropertiesenumerateViewport), required: false);
            SourceExpression.Validate(jABGetTablePropertiesprocessViewportParents, nameof(jABGetTablePropertiesprocessViewportParents), required: false);
            SourceExpression.Validate(jABGetTablePropertiesmaxViewportParentsToProcess, nameof(jABGetTablePropertiesmaxViewportParentsToProcess), required: false);
            SourceExpression.Validate(jABGetTablePropertiesviewportParentElementRolesToConsider, nameof(jABGetTablePropertiesviewportParentElementRolesToConsider), required: false);
            SourceExpression.Validate(jABGetTablePropertiesviewportLeftMargin, nameof(jABGetTablePropertiesviewportLeftMargin), required: false);
            SourceExpression.Validate(jABGetTablePropertiesviewportTopMargin, nameof(jABGetTablePropertiesviewportTopMargin), required: false);
            SourceExpression.Validate(jABGetTablePropertiesviewportRightMargin, nameof(jABGetTablePropertiesviewportRightMargin), required: false);
            SourceExpression.Validate(jABGetTablePropertiesviewportBottomMargin, nameof(jABGetTablePropertiesviewportBottomMargin), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetTableProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetTableProperties = new JObject();
                var jABGetTablePropertiespropCount = 0;
                jABGetTablePropertiespropCount++;
                jABGetTableProperties["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiessearchParentElementJABHandle);
                if (jABGetTablePropertiessearchElementJABName != null)
                {
                    jABGetTableProperties["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiessearchElementJABName);
                    jABGetTablePropertiespropCount++;
                }

                if (jABGetTablePropertiessearchElementJABDescription != null)
                {
                    jABGetTableProperties["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiessearchElementJABDescription);
                    jABGetTablePropertiespropCount++;
                }

                if (jABGetTablePropertiessearchElementJABRole != null)
                {
                    jABGetTableProperties["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiessearchElementJABRole);
                    jABGetTablePropertiespropCount++;
                }

                if (jABGetTablePropertiessearchSubTree != null)
                {
                    if (jABGetTablePropertiessearchSubTree != null)
                    {
                        jABGetTableProperties["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiessearchSubTree);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["SearchSubTree"] = true;
                    jABGetTablePropertiespropCount++;
                }

                if (jABGetTablePropertiesmaxRelativeDepth != null)
                {
                    if (jABGetTablePropertiesmaxRelativeDepth != null)
                    {
                        jABGetTableProperties["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiesmaxRelativeDepth);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["MaxRelativeDepth"] = 0;
                    jABGetTablePropertiespropCount++;
                }

                if (jABGetTablePropertiesmatchIndex != null)
                {
                    if (jABGetTablePropertiesmatchIndex != null)
                    {
                        jABGetTableProperties["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiesmatchIndex);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["MatchIndex"] = 1;
                    jABGetTablePropertiespropCount++;
                }

                if (jABGetTablePropertiessearchFilter != null)
                {
                    jABGetTableProperties["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiessearchFilter);
                    jABGetTablePropertiespropCount++;
                }

                if (jABGetTablePropertiessortByColumn != null)
                {
                    jABGetTableProperties["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiessortByColumn);
                    jABGetTablePropertiespropCount++;
                }

                if (jABGetTablePropertiesmatchIndexAscending != null)
                {
                    if (jABGetTablePropertiesmatchIndexAscending != null)
                    {
                        jABGetTableProperties["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiesmatchIndexAscending);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["MatchIndexAscending"] = true;
                    jABGetTablePropertiespropCount++;
                }

                if (jABGetTablePropertiescaseSensitiveSearch != null)
                {
                    if (jABGetTablePropertiescaseSensitiveSearch != null)
                    {
                        jABGetTableProperties["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiescaseSensitiveSearch);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["CaseSensitiveSearch"] = false;
                    jABGetTablePropertiespropCount++;
                }

                if (jABGetTablePropertiesonlySearchVisibleElements != null)
                {
                    if (jABGetTablePropertiesonlySearchVisibleElements != null)
                    {
                        jABGetTableProperties["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiesonlySearchVisibleElements);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["OnlySearchVisibleElements"] = true;
                    jABGetTablePropertiespropCount++;
                }

                if (jABGetTablePropertiesonlySearchShowingElements != null)
                {
                    if (jABGetTablePropertiesonlySearchShowingElements != null)
                    {
                        jABGetTableProperties["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiesonlySearchShowingElements);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["OnlySearchShowingElements"] = true;
                    jABGetTablePropertiespropCount++;
                }

                if (jABGetTablePropertieselementRolesNotToTraverse != null)
                {
                    jABGetTableProperties["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertieselementRolesNotToTraverse);
                    jABGetTablePropertiespropCount++;
                }

                if (jABGetTablePropertiesmaximumElementsToSearch != null)
                {
                    if (jABGetTablePropertiesmaximumElementsToSearch != null)
                    {
                        jABGetTableProperties["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiesmaximumElementsToSearch);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["MaximumElementsToSearch"] = 2000;
                    jABGetTablePropertiespropCount++;
                }

                if (jABGetTablePropertiesmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABGetTablePropertiesmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetTableProperties["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiesmaximumChildElementsToSearchPerNode);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGetTablePropertiespropCount++;
                }

                if (jABGetTablePropertiesenumerateViewport != null)
                {
                    if (jABGetTablePropertiesenumerateViewport != null)
                    {
                        jABGetTableProperties["EnumerateViewport"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiesenumerateViewport);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["EnumerateViewport"] = true;
                    jABGetTablePropertiespropCount++;
                }

                if (jABGetTablePropertiesprocessViewportParents != null)
                {
                    if (jABGetTablePropertiesprocessViewportParents != null)
                    {
                        jABGetTableProperties["ProcessViewportParents"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiesprocessViewportParents);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["ProcessViewportParents"] = true;
                    jABGetTablePropertiespropCount++;
                }

                if (jABGetTablePropertiesmaxViewportParentsToProcess != null)
                {
                    if (jABGetTablePropertiesmaxViewportParentsToProcess != null)
                    {
                        jABGetTableProperties["MaxViewportParentsToProcess"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiesmaxViewportParentsToProcess);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["MaxViewportParentsToProcess"] = 50;
                    jABGetTablePropertiespropCount++;
                }

                if (jABGetTablePropertiesviewportParentElementRolesToConsider != null)
                {
                    if (jABGetTablePropertiesviewportParentElementRolesToConsider != null)
                    {
                        jABGetTableProperties["ViewportParentElementRolesToConsider"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiesviewportParentElementRolesToConsider);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["ViewportParentElementRolesToConsider"] = "Panel,Viewport,Layered pane,Root pane";
                    jABGetTablePropertiespropCount++;
                }

                if (jABGetTablePropertiesviewportLeftMargin != null)
                {
                    if (jABGetTablePropertiesviewportLeftMargin != null)
                    {
                        jABGetTableProperties["ViewportLeftMargin"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiesviewportLeftMargin);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["ViewportLeftMargin"] = 2;
                    jABGetTablePropertiespropCount++;
                }

                if (jABGetTablePropertiesviewportTopMargin != null)
                {
                    if (jABGetTablePropertiesviewportTopMargin != null)
                    {
                        jABGetTableProperties["ViewportTopMargin"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiesviewportTopMargin);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["ViewportTopMargin"] = 2;
                    jABGetTablePropertiespropCount++;
                }

                if (jABGetTablePropertiesviewportRightMargin != null)
                {
                    if (jABGetTablePropertiesviewportRightMargin != null)
                    {
                        jABGetTableProperties["ViewportRightMargin"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiesviewportRightMargin);
                        jABGetTablePropertiespropCount++;
                    }

                    jABGetTablePropertiespropCount++;
                }
                else
                {
                    jABGetTableProperties["ViewportRightMargin"] = 2;
                    jABGetTablePropertiespropCount++;
                }

                if (jABGetTablePropertiesviewportBottomMargin != null)
                {
                    if (jABGetTablePropertiesviewportBottomMargin != null)
                    {
                        jABGetTableProperties["ViewportBottomMargin"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiesviewportBottomMargin);
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
                jABGetTableProperties["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetTablePropertiesworkflow);
                if (jABGetTablePropertiespropCount > 0)
                {
                    callPayload.Body = jABGetTableProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetTablePropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetTableCellPropertiesResponse> JABGetTableCellProperties([WorkflowExpression] Func<int> jABGetTableCellPropertiessearchParentElementJABHandle, [WorkflowExpression] Func<int> jABGetTableCellPropertiesrowIndex, [WorkflowExpression] Func<int> jABGetTableCellPropertiescolumnIndex, [WorkflowExpression] Func<string> jABGetTableCellPropertiesworkflow, [WorkflowExpression] Func<string> jABGetTableCellPropertiessearchElementJABName = null, [WorkflowExpression] Func<string> jABGetTableCellPropertiessearchElementJABDescription = null, [WorkflowExpression] Func<string> jABGetTableCellPropertiessearchElementJABRole = null, [WorkflowExpression] Func<bool> jABGetTableCellPropertiessearchSubTree = null, [WorkflowExpression] Func<int> jABGetTableCellPropertiesmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABGetTableCellPropertiesmatchIndex = null, [WorkflowExpression] Func<string> jABGetTableCellPropertiessearchFilter = null, [WorkflowExpression] Func<string> jABGetTableCellPropertiessortByColumn = null, [WorkflowExpression] Func<bool> jABGetTableCellPropertiesmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABGetTableCellPropertiescaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABGetTableCellPropertiesonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABGetTableCellPropertiesonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABGetTableCellPropertieselementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABGetTableCellPropertiesmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABGetTableCellPropertiesmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<bool> jABGetTableCellPropertiesreturnJABHandle = null, [WorkflowExpression] Func<bool> jABGetTableCellPropertiesenumerateViewport = null, [WorkflowExpression] Func<bool> jABGetTableCellPropertiesprocessViewportParents = null, [WorkflowExpression] Func<int> jABGetTableCellPropertiesmaxViewportParentsToProcess = null, [WorkflowExpression] Func<string> jABGetTableCellPropertiesviewportParentElementRolesToConsider = null, [WorkflowExpression] Func<int> jABGetTableCellPropertiesviewportLeftMargin = null, [WorkflowExpression] Func<int> jABGetTableCellPropertiesviewportTopMargin = null, [WorkflowExpression] Func<int> jABGetTableCellPropertiesviewportRightMargin = null, [WorkflowExpression] Func<int> jABGetTableCellPropertiesviewportBottomMargin = null)
        {
            SourceExpression.Validate(jABGetTableCellPropertiessearchParentElementJABHandle, nameof(jABGetTableCellPropertiessearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABGetTableCellPropertiesrowIndex, nameof(jABGetTableCellPropertiesrowIndex), required: true);
            SourceExpression.Validate(jABGetTableCellPropertiescolumnIndex, nameof(jABGetTableCellPropertiescolumnIndex), required: true);
            SourceExpression.Validate(jABGetTableCellPropertiesworkflow, nameof(jABGetTableCellPropertiesworkflow), required: true);
            SourceExpression.Validate(jABGetTableCellPropertiessearchElementJABName, nameof(jABGetTableCellPropertiessearchElementJABName), required: false);
            SourceExpression.Validate(jABGetTableCellPropertiessearchElementJABDescription, nameof(jABGetTableCellPropertiessearchElementJABDescription), required: false);
            SourceExpression.Validate(jABGetTableCellPropertiessearchElementJABRole, nameof(jABGetTableCellPropertiessearchElementJABRole), required: false);
            SourceExpression.Validate(jABGetTableCellPropertiessearchSubTree, nameof(jABGetTableCellPropertiessearchSubTree), required: false);
            SourceExpression.Validate(jABGetTableCellPropertiesmaxRelativeDepth, nameof(jABGetTableCellPropertiesmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABGetTableCellPropertiesmatchIndex, nameof(jABGetTableCellPropertiesmatchIndex), required: false);
            SourceExpression.Validate(jABGetTableCellPropertiessearchFilter, nameof(jABGetTableCellPropertiessearchFilter), required: false);
            SourceExpression.Validate(jABGetTableCellPropertiessortByColumn, nameof(jABGetTableCellPropertiessortByColumn), required: false);
            SourceExpression.Validate(jABGetTableCellPropertiesmatchIndexAscending, nameof(jABGetTableCellPropertiesmatchIndexAscending), required: false);
            SourceExpression.Validate(jABGetTableCellPropertiescaseSensitiveSearch, nameof(jABGetTableCellPropertiescaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABGetTableCellPropertiesonlySearchVisibleElements, nameof(jABGetTableCellPropertiesonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABGetTableCellPropertiesonlySearchShowingElements, nameof(jABGetTableCellPropertiesonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABGetTableCellPropertieselementRolesNotToTraverse, nameof(jABGetTableCellPropertieselementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABGetTableCellPropertiesmaximumElementsToSearch, nameof(jABGetTableCellPropertiesmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABGetTableCellPropertiesmaximumChildElementsToSearchPerNode, nameof(jABGetTableCellPropertiesmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABGetTableCellPropertiesreturnJABHandle, nameof(jABGetTableCellPropertiesreturnJABHandle), required: false);
            SourceExpression.Validate(jABGetTableCellPropertiesenumerateViewport, nameof(jABGetTableCellPropertiesenumerateViewport), required: false);
            SourceExpression.Validate(jABGetTableCellPropertiesprocessViewportParents, nameof(jABGetTableCellPropertiesprocessViewportParents), required: false);
            SourceExpression.Validate(jABGetTableCellPropertiesmaxViewportParentsToProcess, nameof(jABGetTableCellPropertiesmaxViewportParentsToProcess), required: false);
            SourceExpression.Validate(jABGetTableCellPropertiesviewportParentElementRolesToConsider, nameof(jABGetTableCellPropertiesviewportParentElementRolesToConsider), required: false);
            SourceExpression.Validate(jABGetTableCellPropertiesviewportLeftMargin, nameof(jABGetTableCellPropertiesviewportLeftMargin), required: false);
            SourceExpression.Validate(jABGetTableCellPropertiesviewportTopMargin, nameof(jABGetTableCellPropertiesviewportTopMargin), required: false);
            SourceExpression.Validate(jABGetTableCellPropertiesviewportRightMargin, nameof(jABGetTableCellPropertiesviewportRightMargin), required: false);
            SourceExpression.Validate(jABGetTableCellPropertiesviewportBottomMargin, nameof(jABGetTableCellPropertiesviewportBottomMargin), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetTableCellProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetTableCellProperties = new JObject();
                var jABGetTableCellPropertiespropCount = 0;
                jABGetTableCellPropertiespropCount++;
                jABGetTableCellProperties["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiessearchParentElementJABHandle);
                if (jABGetTableCellPropertiessearchElementJABName != null)
                {
                    jABGetTableCellProperties["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiessearchElementJABName);
                    jABGetTableCellPropertiespropCount++;
                }

                if (jABGetTableCellPropertiessearchElementJABDescription != null)
                {
                    jABGetTableCellProperties["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiessearchElementJABDescription);
                    jABGetTableCellPropertiespropCount++;
                }

                if (jABGetTableCellPropertiessearchElementJABRole != null)
                {
                    jABGetTableCellProperties["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiessearchElementJABRole);
                    jABGetTableCellPropertiespropCount++;
                }

                if (jABGetTableCellPropertiessearchSubTree != null)
                {
                    if (jABGetTableCellPropertiessearchSubTree != null)
                    {
                        jABGetTableCellProperties["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiessearchSubTree);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["SearchSubTree"] = true;
                    jABGetTableCellPropertiespropCount++;
                }

                if (jABGetTableCellPropertiesmaxRelativeDepth != null)
                {
                    if (jABGetTableCellPropertiesmaxRelativeDepth != null)
                    {
                        jABGetTableCellProperties["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiesmaxRelativeDepth);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["MaxRelativeDepth"] = 0;
                    jABGetTableCellPropertiespropCount++;
                }

                if (jABGetTableCellPropertiesmatchIndex != null)
                {
                    if (jABGetTableCellPropertiesmatchIndex != null)
                    {
                        jABGetTableCellProperties["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiesmatchIndex);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["MatchIndex"] = 1;
                    jABGetTableCellPropertiespropCount++;
                }

                if (jABGetTableCellPropertiessearchFilter != null)
                {
                    jABGetTableCellProperties["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiessearchFilter);
                    jABGetTableCellPropertiespropCount++;
                }

                if (jABGetTableCellPropertiessortByColumn != null)
                {
                    jABGetTableCellProperties["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiessortByColumn);
                    jABGetTableCellPropertiespropCount++;
                }

                if (jABGetTableCellPropertiesmatchIndexAscending != null)
                {
                    if (jABGetTableCellPropertiesmatchIndexAscending != null)
                    {
                        jABGetTableCellProperties["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiesmatchIndexAscending);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["MatchIndexAscending"] = true;
                    jABGetTableCellPropertiespropCount++;
                }

                if (jABGetTableCellPropertiescaseSensitiveSearch != null)
                {
                    if (jABGetTableCellPropertiescaseSensitiveSearch != null)
                    {
                        jABGetTableCellProperties["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiescaseSensitiveSearch);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["CaseSensitiveSearch"] = false;
                    jABGetTableCellPropertiespropCount++;
                }

                if (jABGetTableCellPropertiesonlySearchVisibleElements != null)
                {
                    if (jABGetTableCellPropertiesonlySearchVisibleElements != null)
                    {
                        jABGetTableCellProperties["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiesonlySearchVisibleElements);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["OnlySearchVisibleElements"] = true;
                    jABGetTableCellPropertiespropCount++;
                }

                if (jABGetTableCellPropertiesonlySearchShowingElements != null)
                {
                    if (jABGetTableCellPropertiesonlySearchShowingElements != null)
                    {
                        jABGetTableCellProperties["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiesonlySearchShowingElements);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["OnlySearchShowingElements"] = true;
                    jABGetTableCellPropertiespropCount++;
                }

                if (jABGetTableCellPropertieselementRolesNotToTraverse != null)
                {
                    jABGetTableCellProperties["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertieselementRolesNotToTraverse);
                    jABGetTableCellPropertiespropCount++;
                }

                if (jABGetTableCellPropertiesmaximumElementsToSearch != null)
                {
                    if (jABGetTableCellPropertiesmaximumElementsToSearch != null)
                    {
                        jABGetTableCellProperties["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiesmaximumElementsToSearch);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["MaximumElementsToSearch"] = 2000;
                    jABGetTableCellPropertiespropCount++;
                }

                if (jABGetTableCellPropertiesmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABGetTableCellPropertiesmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetTableCellProperties["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiesmaximumChildElementsToSearchPerNode);
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
                jABGetTableCellProperties["RowIndex"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiesrowIndex);
                jABGetTableCellPropertiespropCount++;
                jABGetTableCellProperties["ColumnIndex"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiescolumnIndex);
                if (jABGetTableCellPropertiesreturnJABHandle != null)
                {
                    if (jABGetTableCellPropertiesreturnJABHandle != null)
                    {
                        jABGetTableCellProperties["ReturnJABHandle"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiesreturnJABHandle);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["ReturnJABHandle"] = false;
                    jABGetTableCellPropertiespropCount++;
                }

                if (jABGetTableCellPropertiesenumerateViewport != null)
                {
                    if (jABGetTableCellPropertiesenumerateViewport != null)
                    {
                        jABGetTableCellProperties["EnumerateViewport"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiesenumerateViewport);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["EnumerateViewport"] = true;
                    jABGetTableCellPropertiespropCount++;
                }

                if (jABGetTableCellPropertiesprocessViewportParents != null)
                {
                    if (jABGetTableCellPropertiesprocessViewportParents != null)
                    {
                        jABGetTableCellProperties["ProcessViewportParents"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiesprocessViewportParents);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["ProcessViewportParents"] = true;
                    jABGetTableCellPropertiespropCount++;
                }

                if (jABGetTableCellPropertiesmaxViewportParentsToProcess != null)
                {
                    if (jABGetTableCellPropertiesmaxViewportParentsToProcess != null)
                    {
                        jABGetTableCellProperties["MaxViewportParentsToProcess"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiesmaxViewportParentsToProcess);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["MaxViewportParentsToProcess"] = 50;
                    jABGetTableCellPropertiespropCount++;
                }

                if (jABGetTableCellPropertiesviewportParentElementRolesToConsider != null)
                {
                    if (jABGetTableCellPropertiesviewportParentElementRolesToConsider != null)
                    {
                        jABGetTableCellProperties["ViewportParentElementRolesToConsider"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiesviewportParentElementRolesToConsider);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["ViewportParentElementRolesToConsider"] = "Panel,Viewport,Layered pane,Root pane";
                    jABGetTableCellPropertiespropCount++;
                }

                if (jABGetTableCellPropertiesviewportLeftMargin != null)
                {
                    if (jABGetTableCellPropertiesviewportLeftMargin != null)
                    {
                        jABGetTableCellProperties["ViewportLeftMargin"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiesviewportLeftMargin);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["ViewportLeftMargin"] = 2;
                    jABGetTableCellPropertiespropCount++;
                }

                if (jABGetTableCellPropertiesviewportTopMargin != null)
                {
                    if (jABGetTableCellPropertiesviewportTopMargin != null)
                    {
                        jABGetTableCellProperties["ViewportTopMargin"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiesviewportTopMargin);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["ViewportTopMargin"] = 2;
                    jABGetTableCellPropertiespropCount++;
                }

                if (jABGetTableCellPropertiesviewportRightMargin != null)
                {
                    if (jABGetTableCellPropertiesviewportRightMargin != null)
                    {
                        jABGetTableCellProperties["ViewportRightMargin"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiesviewportRightMargin);
                        jABGetTableCellPropertiespropCount++;
                    }

                    jABGetTableCellPropertiespropCount++;
                }
                else
                {
                    jABGetTableCellProperties["ViewportRightMargin"] = 2;
                    jABGetTableCellPropertiespropCount++;
                }

                if (jABGetTableCellPropertiesviewportBottomMargin != null)
                {
                    if (jABGetTableCellPropertiesviewportBottomMargin != null)
                    {
                        jABGetTableCellProperties["ViewportBottomMargin"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiesviewportBottomMargin);
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
                jABGetTableCellProperties["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetTableCellPropertiesworkflow);
                if (jABGetTableCellPropertiespropCount > 0)
                {
                    callPayload.Body = jABGetTableCellProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetTableCellPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetTableContentsResponse> JABGetTableContents([WorkflowExpression] Func<int> jABGetTableContentssearchParentElementJABHandle, [WorkflowExpression] Func<string> jABGetTableContentsworkflow, [WorkflowExpression] Func<string> jABGetTableContentssearchElementJABName = null, [WorkflowExpression] Func<string> jABGetTableContentssearchElementJABDescription = null, [WorkflowExpression] Func<string> jABGetTableContentssearchElementJABRole = null, [WorkflowExpression] Func<bool> jABGetTableContentssearchSubTree = null, [WorkflowExpression] Func<int> jABGetTableContentsmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABGetTableContentsmatchIndex = null, [WorkflowExpression] Func<string> jABGetTableContentssearchFilter = null, [WorkflowExpression] Func<string> jABGetTableContentssortByColumn = null, [WorkflowExpression] Func<bool> jABGetTableContentsmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABGetTableContentscaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABGetTableContentsonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABGetTableContentsonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABGetTableContentselementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABGetTableContentsmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABGetTableContentsmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<int> jABGetTableContentsfirstRowToReturn = null, [WorkflowExpression] Func<int> jABGetTableContentsmaxRowsToReturn = null, [WorkflowExpression] Func<int> jABGetTableContentsfirstColumnToReturn = null, [WorkflowExpression] Func<int> jABGetTableContentsmaxColumnsToReturn = null, [WorkflowExpression] Func<bool> jABGetTableContentsuseColumnHeadersFromTable = null, [WorkflowExpression] Func<bool> jABGetTableContentsreturnRowIndexInOutputCollection = null, [WorkflowExpression] Func<string> jABGetTableContentsnameOfColumnToStoreRowIndex = null)
        {
            SourceExpression.Validate(jABGetTableContentssearchParentElementJABHandle, nameof(jABGetTableContentssearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABGetTableContentsworkflow, nameof(jABGetTableContentsworkflow), required: true);
            SourceExpression.Validate(jABGetTableContentssearchElementJABName, nameof(jABGetTableContentssearchElementJABName), required: false);
            SourceExpression.Validate(jABGetTableContentssearchElementJABDescription, nameof(jABGetTableContentssearchElementJABDescription), required: false);
            SourceExpression.Validate(jABGetTableContentssearchElementJABRole, nameof(jABGetTableContentssearchElementJABRole), required: false);
            SourceExpression.Validate(jABGetTableContentssearchSubTree, nameof(jABGetTableContentssearchSubTree), required: false);
            SourceExpression.Validate(jABGetTableContentsmaxRelativeDepth, nameof(jABGetTableContentsmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABGetTableContentsmatchIndex, nameof(jABGetTableContentsmatchIndex), required: false);
            SourceExpression.Validate(jABGetTableContentssearchFilter, nameof(jABGetTableContentssearchFilter), required: false);
            SourceExpression.Validate(jABGetTableContentssortByColumn, nameof(jABGetTableContentssortByColumn), required: false);
            SourceExpression.Validate(jABGetTableContentsmatchIndexAscending, nameof(jABGetTableContentsmatchIndexAscending), required: false);
            SourceExpression.Validate(jABGetTableContentscaseSensitiveSearch, nameof(jABGetTableContentscaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABGetTableContentsonlySearchVisibleElements, nameof(jABGetTableContentsonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABGetTableContentsonlySearchShowingElements, nameof(jABGetTableContentsonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABGetTableContentselementRolesNotToTraverse, nameof(jABGetTableContentselementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABGetTableContentsmaximumElementsToSearch, nameof(jABGetTableContentsmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABGetTableContentsmaximumChildElementsToSearchPerNode, nameof(jABGetTableContentsmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABGetTableContentsfirstRowToReturn, nameof(jABGetTableContentsfirstRowToReturn), required: false);
            SourceExpression.Validate(jABGetTableContentsmaxRowsToReturn, nameof(jABGetTableContentsmaxRowsToReturn), required: false);
            SourceExpression.Validate(jABGetTableContentsfirstColumnToReturn, nameof(jABGetTableContentsfirstColumnToReturn), required: false);
            SourceExpression.Validate(jABGetTableContentsmaxColumnsToReturn, nameof(jABGetTableContentsmaxColumnsToReturn), required: false);
            SourceExpression.Validate(jABGetTableContentsuseColumnHeadersFromTable, nameof(jABGetTableContentsuseColumnHeadersFromTable), required: false);
            SourceExpression.Validate(jABGetTableContentsreturnRowIndexInOutputCollection, nameof(jABGetTableContentsreturnRowIndexInOutputCollection), required: false);
            SourceExpression.Validate(jABGetTableContentsnameOfColumnToStoreRowIndex, nameof(jABGetTableContentsnameOfColumnToStoreRowIndex), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetTableContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetTableContents = new JObject();
                var jABGetTableContentspropCount = 0;
                jABGetTableContentspropCount++;
                jABGetTableContents["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGetTableContentssearchParentElementJABHandle);
                if (jABGetTableContentssearchElementJABName != null)
                {
                    jABGetTableContents["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABGetTableContentssearchElementJABName);
                    jABGetTableContentspropCount++;
                }

                if (jABGetTableContentssearchElementJABDescription != null)
                {
                    jABGetTableContents["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABGetTableContentssearchElementJABDescription);
                    jABGetTableContentspropCount++;
                }

                if (jABGetTableContentssearchElementJABRole != null)
                {
                    jABGetTableContents["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABGetTableContentssearchElementJABRole);
                    jABGetTableContentspropCount++;
                }

                if (jABGetTableContentssearchSubTree != null)
                {
                    if (jABGetTableContentssearchSubTree != null)
                    {
                        jABGetTableContents["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABGetTableContentssearchSubTree);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["SearchSubTree"] = true;
                    jABGetTableContentspropCount++;
                }

                if (jABGetTableContentsmaxRelativeDepth != null)
                {
                    if (jABGetTableContentsmaxRelativeDepth != null)
                    {
                        jABGetTableContents["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABGetTableContentsmaxRelativeDepth);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["MaxRelativeDepth"] = 0;
                    jABGetTableContentspropCount++;
                }

                if (jABGetTableContentsmatchIndex != null)
                {
                    if (jABGetTableContentsmatchIndex != null)
                    {
                        jABGetTableContents["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABGetTableContentsmatchIndex);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["MatchIndex"] = 1;
                    jABGetTableContentspropCount++;
                }

                if (jABGetTableContentssearchFilter != null)
                {
                    jABGetTableContents["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABGetTableContentssearchFilter);
                    jABGetTableContentspropCount++;
                }

                if (jABGetTableContentssortByColumn != null)
                {
                    jABGetTableContents["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABGetTableContentssortByColumn);
                    jABGetTableContentspropCount++;
                }

                if (jABGetTableContentsmatchIndexAscending != null)
                {
                    if (jABGetTableContentsmatchIndexAscending != null)
                    {
                        jABGetTableContents["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABGetTableContentsmatchIndexAscending);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["MatchIndexAscending"] = true;
                    jABGetTableContentspropCount++;
                }

                if (jABGetTableContentscaseSensitiveSearch != null)
                {
                    if (jABGetTableContentscaseSensitiveSearch != null)
                    {
                        jABGetTableContents["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABGetTableContentscaseSensitiveSearch);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["CaseSensitiveSearch"] = false;
                    jABGetTableContentspropCount++;
                }

                if (jABGetTableContentsonlySearchVisibleElements != null)
                {
                    if (jABGetTableContentsonlySearchVisibleElements != null)
                    {
                        jABGetTableContents["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABGetTableContentsonlySearchVisibleElements);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["OnlySearchVisibleElements"] = true;
                    jABGetTableContentspropCount++;
                }

                if (jABGetTableContentsonlySearchShowingElements != null)
                {
                    if (jABGetTableContentsonlySearchShowingElements != null)
                    {
                        jABGetTableContents["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABGetTableContentsonlySearchShowingElements);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["OnlySearchShowingElements"] = true;
                    jABGetTableContentspropCount++;
                }

                if (jABGetTableContentselementRolesNotToTraverse != null)
                {
                    jABGetTableContents["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABGetTableContentselementRolesNotToTraverse);
                    jABGetTableContentspropCount++;
                }

                if (jABGetTableContentsmaximumElementsToSearch != null)
                {
                    if (jABGetTableContentsmaximumElementsToSearch != null)
                    {
                        jABGetTableContents["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABGetTableContentsmaximumElementsToSearch);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["MaximumElementsToSearch"] = 2000;
                    jABGetTableContentspropCount++;
                }

                if (jABGetTableContentsmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABGetTableContentsmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetTableContents["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABGetTableContentsmaximumChildElementsToSearchPerNode);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGetTableContentspropCount++;
                }

                if (jABGetTableContentsfirstRowToReturn != null)
                {
                    if (jABGetTableContentsfirstRowToReturn != null)
                    {
                        jABGetTableContents["FirstRowToReturn"] = SourceExpressionConverter.ConvertToken(jABGetTableContentsfirstRowToReturn);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["FirstRowToReturn"] = 1;
                    jABGetTableContentspropCount++;
                }

                if (jABGetTableContentsmaxRowsToReturn != null)
                {
                    if (jABGetTableContentsmaxRowsToReturn != null)
                    {
                        jABGetTableContents["MaxRowsToReturn"] = SourceExpressionConverter.ConvertToken(jABGetTableContentsmaxRowsToReturn);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["MaxRowsToReturn"] = 0;
                    jABGetTableContentspropCount++;
                }

                if (jABGetTableContentsfirstColumnToReturn != null)
                {
                    if (jABGetTableContentsfirstColumnToReturn != null)
                    {
                        jABGetTableContents["FirstColumnToReturn"] = SourceExpressionConverter.ConvertToken(jABGetTableContentsfirstColumnToReturn);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["FirstColumnToReturn"] = 1;
                    jABGetTableContentspropCount++;
                }

                if (jABGetTableContentsmaxColumnsToReturn != null)
                {
                    if (jABGetTableContentsmaxColumnsToReturn != null)
                    {
                        jABGetTableContents["MaxColumnsToReturn"] = SourceExpressionConverter.ConvertToken(jABGetTableContentsmaxColumnsToReturn);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["MaxColumnsToReturn"] = 0;
                    jABGetTableContentspropCount++;
                }

                if (jABGetTableContentsuseColumnHeadersFromTable != null)
                {
                    if (jABGetTableContentsuseColumnHeadersFromTable != null)
                    {
                        jABGetTableContents["UseColumnHeadersFromTable"] = SourceExpressionConverter.ConvertToken(jABGetTableContentsuseColumnHeadersFromTable);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["UseColumnHeadersFromTable"] = false;
                    jABGetTableContentspropCount++;
                }

                if (jABGetTableContentsreturnRowIndexInOutputCollection != null)
                {
                    if (jABGetTableContentsreturnRowIndexInOutputCollection != null)
                    {
                        jABGetTableContents["ReturnRowIndexInOutputCollection"] = SourceExpressionConverter.ConvertToken(jABGetTableContentsreturnRowIndexInOutputCollection);
                        jABGetTableContentspropCount++;
                    }

                    jABGetTableContentspropCount++;
                }
                else
                {
                    jABGetTableContents["ReturnRowIndexInOutputCollection"] = true;
                    jABGetTableContentspropCount++;
                }

                if (jABGetTableContentsnameOfColumnToStoreRowIndex != null)
                {
                    jABGetTableContents["NameOfColumnToStoreRowIndex"] = SourceExpressionConverter.ConvertToken(jABGetTableContentsnameOfColumnToStoreRowIndex);
                    jABGetTableContentspropCount++;
                }

                jABGetTableContentspropCount++;
                jABGetTableContents["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetTableContentsworkflow);
                if (jABGetTableContentspropCount > 0)
                {
                    callPayload.Body = jABGetTableContents;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetTableContentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABIsTableCellVisibleOnscreenResponse> JABIsTableCellVisibleOnscreen([WorkflowExpression] Func<int> jABIsTableCellVisibleOnscreensearchParentElementJABHandle, [WorkflowExpression] Func<int> jABIsTableCellVisibleOnscreencellRowIndex, [WorkflowExpression] Func<int> jABIsTableCellVisibleOnscreencellColumnIndex, [WorkflowExpression] Func<string> jABIsTableCellVisibleOnscreenworkflow, [WorkflowExpression] Func<string> jABIsTableCellVisibleOnscreensearchElementJABName = null, [WorkflowExpression] Func<string> jABIsTableCellVisibleOnscreensearchElementJABDescription = null, [WorkflowExpression] Func<string> jABIsTableCellVisibleOnscreensearchElementJABRole = null, [WorkflowExpression] Func<bool> jABIsTableCellVisibleOnscreensearchSubTree = null, [WorkflowExpression] Func<int> jABIsTableCellVisibleOnscreenmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABIsTableCellVisibleOnscreenmatchIndex = null, [WorkflowExpression] Func<string> jABIsTableCellVisibleOnscreensearchFilter = null, [WorkflowExpression] Func<string> jABIsTableCellVisibleOnscreensortByColumn = null, [WorkflowExpression] Func<bool> jABIsTableCellVisibleOnscreenmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABIsTableCellVisibleOnscreencaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABIsTableCellVisibleOnscreenonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABIsTableCellVisibleOnscreenonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABIsTableCellVisibleOnscreenelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABIsTableCellVisibleOnscreenmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABIsTableCellVisibleOnscreenmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<bool> jABIsTableCellVisibleOnscreenprocessViewportParents = null, [WorkflowExpression] Func<int> jABIsTableCellVisibleOnscreenmaxViewportParentsToProcess = null, [WorkflowExpression] Func<string> jABIsTableCellVisibleOnscreenviewportParentElementRolesToConsider = null, [WorkflowExpression] Func<int> jABIsTableCellVisibleOnscreenviewportLeftMargin = null, [WorkflowExpression] Func<int> jABIsTableCellVisibleOnscreenviewportTopMargin = null, [WorkflowExpression] Func<int> jABIsTableCellVisibleOnscreenviewportRightMargin = null, [WorkflowExpression] Func<int> jABIsTableCellVisibleOnscreenviewportBottomMargin = null)
        {
            SourceExpression.Validate(jABIsTableCellVisibleOnscreensearchParentElementJABHandle, nameof(jABIsTableCellVisibleOnscreensearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreencellRowIndex, nameof(jABIsTableCellVisibleOnscreencellRowIndex), required: true);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreencellColumnIndex, nameof(jABIsTableCellVisibleOnscreencellColumnIndex), required: true);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreenworkflow, nameof(jABIsTableCellVisibleOnscreenworkflow), required: true);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreensearchElementJABName, nameof(jABIsTableCellVisibleOnscreensearchElementJABName), required: false);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreensearchElementJABDescription, nameof(jABIsTableCellVisibleOnscreensearchElementJABDescription), required: false);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreensearchElementJABRole, nameof(jABIsTableCellVisibleOnscreensearchElementJABRole), required: false);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreensearchSubTree, nameof(jABIsTableCellVisibleOnscreensearchSubTree), required: false);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreenmaxRelativeDepth, nameof(jABIsTableCellVisibleOnscreenmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreenmatchIndex, nameof(jABIsTableCellVisibleOnscreenmatchIndex), required: false);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreensearchFilter, nameof(jABIsTableCellVisibleOnscreensearchFilter), required: false);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreensortByColumn, nameof(jABIsTableCellVisibleOnscreensortByColumn), required: false);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreenmatchIndexAscending, nameof(jABIsTableCellVisibleOnscreenmatchIndexAscending), required: false);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreencaseSensitiveSearch, nameof(jABIsTableCellVisibleOnscreencaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreenonlySearchVisibleElements, nameof(jABIsTableCellVisibleOnscreenonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreenonlySearchShowingElements, nameof(jABIsTableCellVisibleOnscreenonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreenelementRolesNotToTraverse, nameof(jABIsTableCellVisibleOnscreenelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreenmaximumElementsToSearch, nameof(jABIsTableCellVisibleOnscreenmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreenmaximumChildElementsToSearchPerNode, nameof(jABIsTableCellVisibleOnscreenmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreenprocessViewportParents, nameof(jABIsTableCellVisibleOnscreenprocessViewportParents), required: false);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreenmaxViewportParentsToProcess, nameof(jABIsTableCellVisibleOnscreenmaxViewportParentsToProcess), required: false);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreenviewportParentElementRolesToConsider, nameof(jABIsTableCellVisibleOnscreenviewportParentElementRolesToConsider), required: false);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreenviewportLeftMargin, nameof(jABIsTableCellVisibleOnscreenviewportLeftMargin), required: false);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreenviewportTopMargin, nameof(jABIsTableCellVisibleOnscreenviewportTopMargin), required: false);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreenviewportRightMargin, nameof(jABIsTableCellVisibleOnscreenviewportRightMargin), required: false);
            SourceExpression.Validate(jABIsTableCellVisibleOnscreenviewportBottomMargin, nameof(jABIsTableCellVisibleOnscreenviewportBottomMargin), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABIsTableCellVisibleOnscreen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABIsTableCellVisibleOnscreen = new JObject();
                var jABIsTableCellVisibleOnscreenpropCount = 0;
                jABIsTableCellVisibleOnscreenpropCount++;
                jABIsTableCellVisibleOnscreen["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreensearchParentElementJABHandle);
                if (jABIsTableCellVisibleOnscreensearchElementJABName != null)
                {
                    jABIsTableCellVisibleOnscreen["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreensearchElementJABName);
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (jABIsTableCellVisibleOnscreensearchElementJABDescription != null)
                {
                    jABIsTableCellVisibleOnscreen["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreensearchElementJABDescription);
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (jABIsTableCellVisibleOnscreensearchElementJABRole != null)
                {
                    jABIsTableCellVisibleOnscreen["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreensearchElementJABRole);
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (jABIsTableCellVisibleOnscreensearchSubTree != null)
                {
                    if (jABIsTableCellVisibleOnscreensearchSubTree != null)
                    {
                        jABIsTableCellVisibleOnscreen["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreensearchSubTree);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["SearchSubTree"] = true;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (jABIsTableCellVisibleOnscreenmaxRelativeDepth != null)
                {
                    if (jABIsTableCellVisibleOnscreenmaxRelativeDepth != null)
                    {
                        jABIsTableCellVisibleOnscreen["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreenmaxRelativeDepth);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["MaxRelativeDepth"] = 0;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (jABIsTableCellVisibleOnscreenmatchIndex != null)
                {
                    if (jABIsTableCellVisibleOnscreenmatchIndex != null)
                    {
                        jABIsTableCellVisibleOnscreen["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreenmatchIndex);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["MatchIndex"] = 1;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (jABIsTableCellVisibleOnscreensearchFilter != null)
                {
                    jABIsTableCellVisibleOnscreen["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreensearchFilter);
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (jABIsTableCellVisibleOnscreensortByColumn != null)
                {
                    jABIsTableCellVisibleOnscreen["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreensortByColumn);
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (jABIsTableCellVisibleOnscreenmatchIndexAscending != null)
                {
                    if (jABIsTableCellVisibleOnscreenmatchIndexAscending != null)
                    {
                        jABIsTableCellVisibleOnscreen["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreenmatchIndexAscending);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["MatchIndexAscending"] = true;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (jABIsTableCellVisibleOnscreencaseSensitiveSearch != null)
                {
                    if (jABIsTableCellVisibleOnscreencaseSensitiveSearch != null)
                    {
                        jABIsTableCellVisibleOnscreen["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreencaseSensitiveSearch);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["CaseSensitiveSearch"] = false;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (jABIsTableCellVisibleOnscreenonlySearchVisibleElements != null)
                {
                    if (jABIsTableCellVisibleOnscreenonlySearchVisibleElements != null)
                    {
                        jABIsTableCellVisibleOnscreen["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreenonlySearchVisibleElements);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["OnlySearchVisibleElements"] = true;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (jABIsTableCellVisibleOnscreenonlySearchShowingElements != null)
                {
                    if (jABIsTableCellVisibleOnscreenonlySearchShowingElements != null)
                    {
                        jABIsTableCellVisibleOnscreen["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreenonlySearchShowingElements);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["OnlySearchShowingElements"] = true;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (jABIsTableCellVisibleOnscreenelementRolesNotToTraverse != null)
                {
                    jABIsTableCellVisibleOnscreen["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreenelementRolesNotToTraverse);
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (jABIsTableCellVisibleOnscreenmaximumElementsToSearch != null)
                {
                    if (jABIsTableCellVisibleOnscreenmaximumElementsToSearch != null)
                    {
                        jABIsTableCellVisibleOnscreen["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreenmaximumElementsToSearch);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["MaximumElementsToSearch"] = 2000;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (jABIsTableCellVisibleOnscreenmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABIsTableCellVisibleOnscreenmaximumChildElementsToSearchPerNode != null)
                    {
                        jABIsTableCellVisibleOnscreen["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreenmaximumChildElementsToSearchPerNode);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["MaximumChildElementsToSearchPerNode"] = 200;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (jABIsTableCellVisibleOnscreenprocessViewportParents != null)
                {
                    if (jABIsTableCellVisibleOnscreenprocessViewportParents != null)
                    {
                        jABIsTableCellVisibleOnscreen["ProcessViewportParents"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreenprocessViewportParents);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["ProcessViewportParents"] = true;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (jABIsTableCellVisibleOnscreenmaxViewportParentsToProcess != null)
                {
                    if (jABIsTableCellVisibleOnscreenmaxViewportParentsToProcess != null)
                    {
                        jABIsTableCellVisibleOnscreen["MaxViewportParentsToProcess"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreenmaxViewportParentsToProcess);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["MaxViewportParentsToProcess"] = 50;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (jABIsTableCellVisibleOnscreenviewportParentElementRolesToConsider != null)
                {
                    if (jABIsTableCellVisibleOnscreenviewportParentElementRolesToConsider != null)
                    {
                        jABIsTableCellVisibleOnscreen["ViewportParentElementRolesToConsider"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreenviewportParentElementRolesToConsider);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["ViewportParentElementRolesToConsider"] = "Panel,Viewport,Layered pane,Root pane";
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (jABIsTableCellVisibleOnscreenviewportLeftMargin != null)
                {
                    if (jABIsTableCellVisibleOnscreenviewportLeftMargin != null)
                    {
                        jABIsTableCellVisibleOnscreen["ViewportLeftMargin"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreenviewportLeftMargin);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["ViewportLeftMargin"] = 2;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (jABIsTableCellVisibleOnscreenviewportTopMargin != null)
                {
                    if (jABIsTableCellVisibleOnscreenviewportTopMargin != null)
                    {
                        jABIsTableCellVisibleOnscreen["ViewportTopMargin"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreenviewportTopMargin);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["ViewportTopMargin"] = 2;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (jABIsTableCellVisibleOnscreenviewportRightMargin != null)
                {
                    if (jABIsTableCellVisibleOnscreenviewportRightMargin != null)
                    {
                        jABIsTableCellVisibleOnscreen["ViewportRightMargin"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreenviewportRightMargin);
                        jABIsTableCellVisibleOnscreenpropCount++;
                    }

                    jABIsTableCellVisibleOnscreenpropCount++;
                }
                else
                {
                    jABIsTableCellVisibleOnscreen["ViewportRightMargin"] = 2;
                    jABIsTableCellVisibleOnscreenpropCount++;
                }

                if (jABIsTableCellVisibleOnscreenviewportBottomMargin != null)
                {
                    if (jABIsTableCellVisibleOnscreenviewportBottomMargin != null)
                    {
                        jABIsTableCellVisibleOnscreen["ViewportBottomMargin"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreenviewportBottomMargin);
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
                jABIsTableCellVisibleOnscreen["CellRowIndex"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreencellRowIndex);
                jABIsTableCellVisibleOnscreenpropCount++;
                jABIsTableCellVisibleOnscreen["CellColumnIndex"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreencellColumnIndex);
                jABIsTableCellVisibleOnscreenpropCount++;
                jABIsTableCellVisibleOnscreen["Workflow"] = SourceExpressionConverter.ConvertToken(jABIsTableCellVisibleOnscreenworkflow);
                if (jABIsTableCellVisibleOnscreenpropCount > 0)
                {
                    callPayload.Body = jABIsTableCellVisibleOnscreen;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABIsTableCellVisibleOnscreenResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABIsJABHandleSameObjectResponse> JABIsJABHandleSameObject([WorkflowExpression] Func<int> jABIsJABHandleSameObjectelement1JABHandle, [WorkflowExpression] Func<int> jABIsJABHandleSameObjectelement2JABHandle, [WorkflowExpression] Func<string> jABIsJABHandleSameObjectworkflow)
        {
            SourceExpression.Validate(jABIsJABHandleSameObjectelement1JABHandle, nameof(jABIsJABHandleSameObjectelement1JABHandle), required: true);
            SourceExpression.Validate(jABIsJABHandleSameObjectelement2JABHandle, nameof(jABIsJABHandleSameObjectelement2JABHandle), required: true);
            SourceExpression.Validate(jABIsJABHandleSameObjectworkflow, nameof(jABIsJABHandleSameObjectworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABIsJABHandleSameObject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABIsJABHandleSameObject = new JObject();
                var jABIsJABHandleSameObjectpropCount = 0;
                jABIsJABHandleSameObjectpropCount++;
                jABIsJABHandleSameObject["Element1JABHandle"] = SourceExpressionConverter.ConvertToken(jABIsJABHandleSameObjectelement1JABHandle);
                jABIsJABHandleSameObjectpropCount++;
                jABIsJABHandleSameObject["Element2JABHandle"] = SourceExpressionConverter.ConvertToken(jABIsJABHandleSameObjectelement2JABHandle);
                jABIsJABHandleSameObjectpropCount++;
                jABIsJABHandleSameObject["Workflow"] = SourceExpressionConverter.ConvertToken(jABIsJABHandleSameObjectworkflow);
                if (jABIsJABHandleSameObjectpropCount > 0)
                {
                    callPayload.Body = jABIsJABHandleSameObject;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABIsJABHandleSameObjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetVisibleBoundingRectangleOfElementOnscreenResponse> JABGetVisibleBoundingRectangleOfElementOnscreen([WorkflowExpression] Func<int> jABGetVisibleBoundingRectangleOfElementOnscreenelementJABHandle, [WorkflowExpression] Func<string> jABGetVisibleBoundingRectangleOfElementOnscreenworkflow, [WorkflowExpression] Func<int> jABGetVisibleBoundingRectangleOfElementOnscreenmaxParentsToProcess = null, [WorkflowExpression] Func<string> jABGetVisibleBoundingRectangleOfElementOnscreenparentElementRolesToConsider = null, [WorkflowExpression] Func<bool> jABGetVisibleBoundingRectangleOfElementOnscreendrawRectangle = null)
        {
            SourceExpression.Validate(jABGetVisibleBoundingRectangleOfElementOnscreenelementJABHandle, nameof(jABGetVisibleBoundingRectangleOfElementOnscreenelementJABHandle), required: true);
            SourceExpression.Validate(jABGetVisibleBoundingRectangleOfElementOnscreenworkflow, nameof(jABGetVisibleBoundingRectangleOfElementOnscreenworkflow), required: true);
            SourceExpression.Validate(jABGetVisibleBoundingRectangleOfElementOnscreenmaxParentsToProcess, nameof(jABGetVisibleBoundingRectangleOfElementOnscreenmaxParentsToProcess), required: false);
            SourceExpression.Validate(jABGetVisibleBoundingRectangleOfElementOnscreenparentElementRolesToConsider, nameof(jABGetVisibleBoundingRectangleOfElementOnscreenparentElementRolesToConsider), required: false);
            SourceExpression.Validate(jABGetVisibleBoundingRectangleOfElementOnscreendrawRectangle, nameof(jABGetVisibleBoundingRectangleOfElementOnscreendrawRectangle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetVisibleBoundingRectangleOfElementOnscreen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetVisibleBoundingRectangleOfElementOnscreen = new JObject();
                var jABGetVisibleBoundingRectangleOfElementOnscreenpropCount = 0;
                jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
                jABGetVisibleBoundingRectangleOfElementOnscreen["ElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGetVisibleBoundingRectangleOfElementOnscreenelementJABHandle);
                if (jABGetVisibleBoundingRectangleOfElementOnscreenmaxParentsToProcess != null)
                {
                    if (jABGetVisibleBoundingRectangleOfElementOnscreenmaxParentsToProcess != null)
                    {
                        jABGetVisibleBoundingRectangleOfElementOnscreen["MaxParentsToProcess"] = SourceExpressionConverter.ConvertToken(jABGetVisibleBoundingRectangleOfElementOnscreenmaxParentsToProcess);
                        jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
                    }

                    jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
                }
                else
                {
                    jABGetVisibleBoundingRectangleOfElementOnscreen["MaxParentsToProcess"] = 0;
                    jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
                }

                if (jABGetVisibleBoundingRectangleOfElementOnscreenparentElementRolesToConsider != null)
                {
                    if (jABGetVisibleBoundingRectangleOfElementOnscreenparentElementRolesToConsider != null)
                    {
                        jABGetVisibleBoundingRectangleOfElementOnscreen["ParentElementRolesToConsider"] = SourceExpressionConverter.ConvertToken(jABGetVisibleBoundingRectangleOfElementOnscreenparentElementRolesToConsider);
                        jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
                    }

                    jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
                }
                else
                {
                    jABGetVisibleBoundingRectangleOfElementOnscreen["ParentElementRolesToConsider"] = "Panel,Viewport,Layered pane,Root pane";
                    jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
                }

                if (jABGetVisibleBoundingRectangleOfElementOnscreendrawRectangle != null)
                {
                    if (jABGetVisibleBoundingRectangleOfElementOnscreendrawRectangle != null)
                    {
                        jABGetVisibleBoundingRectangleOfElementOnscreen["DrawRectangle"] = SourceExpressionConverter.ConvertToken(jABGetVisibleBoundingRectangleOfElementOnscreendrawRectangle);
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
                jABGetVisibleBoundingRectangleOfElementOnscreen["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetVisibleBoundingRectangleOfElementOnscreenworkflow);
                if (jABGetVisibleBoundingRectangleOfElementOnscreenpropCount > 0)
                {
                    callPayload.Body = jABGetVisibleBoundingRectangleOfElementOnscreen;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetVisibleBoundingRectangleOfElementOnscreenResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABCreateHandleForJABElementAtScreenCoordinateResponse> JABCreateHandleForJABElementAtScreenCoordinate([WorkflowExpression] Func<int> jABCreateHandleForJABElementAtScreenCoordinateparentElementJABHandle, [WorkflowExpression] Func<int> jABCreateHandleForJABElementAtScreenCoordinatescreenX, [WorkflowExpression] Func<int> jABCreateHandleForJABElementAtScreenCoordinatescreenY, [WorkflowExpression] Func<string> jABCreateHandleForJABElementAtScreenCoordinateworkflow)
        {
            SourceExpression.Validate(jABCreateHandleForJABElementAtScreenCoordinateparentElementJABHandle, nameof(jABCreateHandleForJABElementAtScreenCoordinateparentElementJABHandle), required: true);
            SourceExpression.Validate(jABCreateHandleForJABElementAtScreenCoordinatescreenX, nameof(jABCreateHandleForJABElementAtScreenCoordinatescreenX), required: true);
            SourceExpression.Validate(jABCreateHandleForJABElementAtScreenCoordinatescreenY, nameof(jABCreateHandleForJABElementAtScreenCoordinatescreenY), required: true);
            SourceExpression.Validate(jABCreateHandleForJABElementAtScreenCoordinateworkflow, nameof(jABCreateHandleForJABElementAtScreenCoordinateworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABCreateHandleForJABElementAtScreenCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABCreateHandleForJABElementAtScreenCoordinate = new JObject();
                var jABCreateHandleForJABElementAtScreenCoordinatepropCount = 0;
                jABCreateHandleForJABElementAtScreenCoordinatepropCount++;
                jABCreateHandleForJABElementAtScreenCoordinate["ParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABCreateHandleForJABElementAtScreenCoordinateparentElementJABHandle);
                jABCreateHandleForJABElementAtScreenCoordinatepropCount++;
                jABCreateHandleForJABElementAtScreenCoordinate["ScreenX"] = SourceExpressionConverter.ConvertToken(jABCreateHandleForJABElementAtScreenCoordinatescreenX);
                jABCreateHandleForJABElementAtScreenCoordinatepropCount++;
                jABCreateHandleForJABElementAtScreenCoordinate["ScreenY"] = SourceExpressionConverter.ConvertToken(jABCreateHandleForJABElementAtScreenCoordinatescreenY);
                jABCreateHandleForJABElementAtScreenCoordinatepropCount++;
                jABCreateHandleForJABElementAtScreenCoordinate["Workflow"] = SourceExpressionConverter.ConvertToken(jABCreateHandleForJABElementAtScreenCoordinateworkflow);
                if (jABCreateHandleForJABElementAtScreenCoordinatepropCount > 0)
                {
                    callPayload.Body = jABCreateHandleForJABElementAtScreenCoordinate;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABCreateHandleForJABElementAtScreenCoordinateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetTableCellAtScreenCoordinateResponse> JABGetTableCellAtScreenCoordinate([WorkflowExpression] Func<int> jABGetTableCellAtScreenCoordinatetableElementJABHandle, [WorkflowExpression] Func<int> jABGetTableCellAtScreenCoordinatescreenX, [WorkflowExpression] Func<int> jABGetTableCellAtScreenCoordinatescreenY, [WorkflowExpression] Func<string> jABGetTableCellAtScreenCoordinateworkflow, [WorkflowExpression] Func<bool> jABGetTableCellAtScreenCoordinatereturnJABHandle = null)
        {
            SourceExpression.Validate(jABGetTableCellAtScreenCoordinatetableElementJABHandle, nameof(jABGetTableCellAtScreenCoordinatetableElementJABHandle), required: true);
            SourceExpression.Validate(jABGetTableCellAtScreenCoordinatescreenX, nameof(jABGetTableCellAtScreenCoordinatescreenX), required: true);
            SourceExpression.Validate(jABGetTableCellAtScreenCoordinatescreenY, nameof(jABGetTableCellAtScreenCoordinatescreenY), required: true);
            SourceExpression.Validate(jABGetTableCellAtScreenCoordinateworkflow, nameof(jABGetTableCellAtScreenCoordinateworkflow), required: true);
            SourceExpression.Validate(jABGetTableCellAtScreenCoordinatereturnJABHandle, nameof(jABGetTableCellAtScreenCoordinatereturnJABHandle), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetTableCellAtScreenCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetTableCellAtScreenCoordinate = new JObject();
                var jABGetTableCellAtScreenCoordinatepropCount = 0;
                jABGetTableCellAtScreenCoordinatepropCount++;
                jABGetTableCellAtScreenCoordinate["TableElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGetTableCellAtScreenCoordinatetableElementJABHandle);
                jABGetTableCellAtScreenCoordinatepropCount++;
                jABGetTableCellAtScreenCoordinate["ScreenX"] = SourceExpressionConverter.ConvertToken(jABGetTableCellAtScreenCoordinatescreenX);
                jABGetTableCellAtScreenCoordinatepropCount++;
                jABGetTableCellAtScreenCoordinate["ScreenY"] = SourceExpressionConverter.ConvertToken(jABGetTableCellAtScreenCoordinatescreenY);
                if (jABGetTableCellAtScreenCoordinatereturnJABHandle != null)
                {
                    if (jABGetTableCellAtScreenCoordinatereturnJABHandle != null)
                    {
                        jABGetTableCellAtScreenCoordinate["ReturnJABHandle"] = SourceExpressionConverter.ConvertToken(jABGetTableCellAtScreenCoordinatereturnJABHandle);
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
                jABGetTableCellAtScreenCoordinate["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetTableCellAtScreenCoordinateworkflow);
                if (jABGetTableCellAtScreenCoordinatepropCount > 0)
                {
                    callPayload.Body = jABGetTableCellAtScreenCoordinate;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetTableCellAtScreenCoordinateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetMultipleParentJABElementPropertiesResponse> JABGetMultipleParentJABElementProperties([WorkflowExpression] Func<int> jABGetMultipleParentJABElementPropertiessearchElementJABHandle, [WorkflowExpression] Func<string> jABGetMultipleParentJABElementPropertiesworkflow, [WorkflowExpression] Func<int> jABGetMultipleParentJABElementPropertiesmaxStringLength = null, [WorkflowExpression] Func<int> jABGetMultipleParentJABElementPropertiesmaxParentsToProcess = null)
        {
            SourceExpression.Validate(jABGetMultipleParentJABElementPropertiessearchElementJABHandle, nameof(jABGetMultipleParentJABElementPropertiessearchElementJABHandle), required: true);
            SourceExpression.Validate(jABGetMultipleParentJABElementPropertiesworkflow, nameof(jABGetMultipleParentJABElementPropertiesworkflow), required: true);
            SourceExpression.Validate(jABGetMultipleParentJABElementPropertiesmaxStringLength, nameof(jABGetMultipleParentJABElementPropertiesmaxStringLength), required: false);
            SourceExpression.Validate(jABGetMultipleParentJABElementPropertiesmaxParentsToProcess, nameof(jABGetMultipleParentJABElementPropertiesmaxParentsToProcess), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetMultipleParentJABElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetMultipleParentJABElementProperties = new JObject();
                var jABGetMultipleParentJABElementPropertiespropCount = 0;
                jABGetMultipleParentJABElementPropertiespropCount++;
                jABGetMultipleParentJABElementProperties["SearchElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGetMultipleParentJABElementPropertiessearchElementJABHandle);
                if (jABGetMultipleParentJABElementPropertiesmaxStringLength != null)
                {
                    if (jABGetMultipleParentJABElementPropertiesmaxStringLength != null)
                    {
                        jABGetMultipleParentJABElementProperties["MaxStringLength"] = SourceExpressionConverter.ConvertToken(jABGetMultipleParentJABElementPropertiesmaxStringLength);
                        jABGetMultipleParentJABElementPropertiespropCount++;
                    }

                    jABGetMultipleParentJABElementPropertiespropCount++;
                }
                else
                {
                    jABGetMultipleParentJABElementProperties["MaxStringLength"] = 0;
                    jABGetMultipleParentJABElementPropertiespropCount++;
                }

                if (jABGetMultipleParentJABElementPropertiesmaxParentsToProcess != null)
                {
                    if (jABGetMultipleParentJABElementPropertiesmaxParentsToProcess != null)
                    {
                        jABGetMultipleParentJABElementProperties["MaxParentsToProcess"] = SourceExpressionConverter.ConvertToken(jABGetMultipleParentJABElementPropertiesmaxParentsToProcess);
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
                jABGetMultipleParentJABElementProperties["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetMultipleParentJABElementPropertiesworkflow);
                if (jABGetMultipleParentJABElementPropertiespropCount > 0)
                {
                    callPayload.Body = jABGetMultipleParentJABElementProperties;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetMultipleParentJABElementPropertiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalMouseClickOnTableCell([WorkflowExpression] Func<int> jABGlobalMouseClickOnTableCellsearchParentElementJABHandle, [WorkflowExpression] Func<int> jABGlobalMouseClickOnTableCellrowIndex, [WorkflowExpression] Func<int> jABGlobalMouseClickOnTableCellcolumnIndex, [WorkflowExpression] Func<int> jABGlobalMouseClickOnTableCellmouseButton, [WorkflowExpression] Func<string> jABGlobalMouseClickOnTableCellworkflow, [WorkflowExpression] Func<string> jABGlobalMouseClickOnTableCellsearchElementJABName = null, [WorkflowExpression] Func<string> jABGlobalMouseClickOnTableCellsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABGlobalMouseClickOnTableCellsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABGlobalMouseClickOnTableCellsearchSubTree = null, [WorkflowExpression] Func<int> jABGlobalMouseClickOnTableCellmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABGlobalMouseClickOnTableCellmatchIndex = null, [WorkflowExpression] Func<string> jABGlobalMouseClickOnTableCellsearchFilter = null, [WorkflowExpression] Func<string> jABGlobalMouseClickOnTableCellsortByColumn = null, [WorkflowExpression] Func<bool> jABGlobalMouseClickOnTableCellmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABGlobalMouseClickOnTableCellcaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABGlobalMouseClickOnTableCellonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABGlobalMouseClickOnTableCellonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABGlobalMouseClickOnTableCellelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABGlobalMouseClickOnTableCellmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABGlobalMouseClickOnTableCellmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<bool> jABGlobalMouseClickOnTableCellenumerateViewport = null, [WorkflowExpression] Func<bool> jABGlobalMouseClickOnTableCellprocessViewportParents = null, [WorkflowExpression] Func<int> jABGlobalMouseClickOnTableCellmaxViewportParentsToProcess = null, [WorkflowExpression] Func<string> jABGlobalMouseClickOnTableCellviewportParentElementRolesToConsider = null, [WorkflowExpression] Func<int> jABGlobalMouseClickOnTableCellviewportLeftMargin = null, [WorkflowExpression] Func<int> jABGlobalMouseClickOnTableCellviewportTopMargin = null, [WorkflowExpression] Func<int> jABGlobalMouseClickOnTableCellviewportRightMargin = null, [WorkflowExpression] Func<int> jABGlobalMouseClickOnTableCellviewportBottomMargin = null, [WorkflowExpression] Func<int> jABGlobalMouseClickOnTableCellclickOffsetX = null, [WorkflowExpression] Func<int> jABGlobalMouseClickOnTableCellclickOffsetY = null, [WorkflowExpression] Func<jABGlobalMouseClickOnTableCelloffsetRelativeToInput> jABGlobalMouseClickOnTableCelloffsetRelativeTo = null, [WorkflowExpression] Func<int> jABGlobalMouseClickOnTableCelldelayInMilliseconds = null)
        {
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellsearchParentElementJABHandle, nameof(jABGlobalMouseClickOnTableCellsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellrowIndex, nameof(jABGlobalMouseClickOnTableCellrowIndex), required: true);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellcolumnIndex, nameof(jABGlobalMouseClickOnTableCellcolumnIndex), required: true);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellmouseButton, nameof(jABGlobalMouseClickOnTableCellmouseButton), required: true);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellworkflow, nameof(jABGlobalMouseClickOnTableCellworkflow), required: true);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellsearchElementJABName, nameof(jABGlobalMouseClickOnTableCellsearchElementJABName), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellsearchElementJABDescription, nameof(jABGlobalMouseClickOnTableCellsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellsearchElementJABRole, nameof(jABGlobalMouseClickOnTableCellsearchElementJABRole), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellsearchSubTree, nameof(jABGlobalMouseClickOnTableCellsearchSubTree), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellmaxRelativeDepth, nameof(jABGlobalMouseClickOnTableCellmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellmatchIndex, nameof(jABGlobalMouseClickOnTableCellmatchIndex), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellsearchFilter, nameof(jABGlobalMouseClickOnTableCellsearchFilter), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellsortByColumn, nameof(jABGlobalMouseClickOnTableCellsortByColumn), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellmatchIndexAscending, nameof(jABGlobalMouseClickOnTableCellmatchIndexAscending), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellcaseSensitiveSearch, nameof(jABGlobalMouseClickOnTableCellcaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellonlySearchVisibleElements, nameof(jABGlobalMouseClickOnTableCellonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellonlySearchShowingElements, nameof(jABGlobalMouseClickOnTableCellonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellelementRolesNotToTraverse, nameof(jABGlobalMouseClickOnTableCellelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellmaximumElementsToSearch, nameof(jABGlobalMouseClickOnTableCellmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellmaximumChildElementsToSearchPerNode, nameof(jABGlobalMouseClickOnTableCellmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellenumerateViewport, nameof(jABGlobalMouseClickOnTableCellenumerateViewport), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellprocessViewportParents, nameof(jABGlobalMouseClickOnTableCellprocessViewportParents), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellmaxViewportParentsToProcess, nameof(jABGlobalMouseClickOnTableCellmaxViewportParentsToProcess), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellviewportParentElementRolesToConsider, nameof(jABGlobalMouseClickOnTableCellviewportParentElementRolesToConsider), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellviewportLeftMargin, nameof(jABGlobalMouseClickOnTableCellviewportLeftMargin), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellviewportTopMargin, nameof(jABGlobalMouseClickOnTableCellviewportTopMargin), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellviewportRightMargin, nameof(jABGlobalMouseClickOnTableCellviewportRightMargin), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellviewportBottomMargin, nameof(jABGlobalMouseClickOnTableCellviewportBottomMargin), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellclickOffsetX, nameof(jABGlobalMouseClickOnTableCellclickOffsetX), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCellclickOffsetY, nameof(jABGlobalMouseClickOnTableCellclickOffsetY), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCelloffsetRelativeTo, nameof(jABGlobalMouseClickOnTableCelloffsetRelativeTo), required: false);
            SourceExpression.Validate(jABGlobalMouseClickOnTableCelldelayInMilliseconds, nameof(jABGlobalMouseClickOnTableCelldelayInMilliseconds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGlobalMouseClickOnTableCell";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGlobalMouseClickOnTableCell = new JObject();
                var jABGlobalMouseClickOnTableCellpropCount = 0;
                jABGlobalMouseClickOnTableCellpropCount++;
                jABGlobalMouseClickOnTableCell["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellsearchParentElementJABHandle);
                if (jABGlobalMouseClickOnTableCellsearchElementJABName != null)
                {
                    jABGlobalMouseClickOnTableCell["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellsearchElementJABName);
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCellsearchElementJABDescription != null)
                {
                    jABGlobalMouseClickOnTableCell["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellsearchElementJABDescription);
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCellsearchElementJABRole != null)
                {
                    jABGlobalMouseClickOnTableCell["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellsearchElementJABRole);
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCellsearchSubTree != null)
                {
                    if (jABGlobalMouseClickOnTableCellsearchSubTree != null)
                    {
                        jABGlobalMouseClickOnTableCell["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellsearchSubTree);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["SearchSubTree"] = true;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCellmaxRelativeDepth != null)
                {
                    if (jABGlobalMouseClickOnTableCellmaxRelativeDepth != null)
                    {
                        jABGlobalMouseClickOnTableCell["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellmaxRelativeDepth);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["MaxRelativeDepth"] = 0;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCellmatchIndex != null)
                {
                    if (jABGlobalMouseClickOnTableCellmatchIndex != null)
                    {
                        jABGlobalMouseClickOnTableCell["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellmatchIndex);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["MatchIndex"] = 1;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCellsearchFilter != null)
                {
                    jABGlobalMouseClickOnTableCell["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellsearchFilter);
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCellsortByColumn != null)
                {
                    jABGlobalMouseClickOnTableCell["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellsortByColumn);
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCellmatchIndexAscending != null)
                {
                    if (jABGlobalMouseClickOnTableCellmatchIndexAscending != null)
                    {
                        jABGlobalMouseClickOnTableCell["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellmatchIndexAscending);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["MatchIndexAscending"] = true;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCellcaseSensitiveSearch != null)
                {
                    if (jABGlobalMouseClickOnTableCellcaseSensitiveSearch != null)
                    {
                        jABGlobalMouseClickOnTableCell["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellcaseSensitiveSearch);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["CaseSensitiveSearch"] = false;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCellonlySearchVisibleElements != null)
                {
                    if (jABGlobalMouseClickOnTableCellonlySearchVisibleElements != null)
                    {
                        jABGlobalMouseClickOnTableCell["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellonlySearchVisibleElements);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["OnlySearchVisibleElements"] = true;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCellonlySearchShowingElements != null)
                {
                    if (jABGlobalMouseClickOnTableCellonlySearchShowingElements != null)
                    {
                        jABGlobalMouseClickOnTableCell["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellonlySearchShowingElements);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["OnlySearchShowingElements"] = true;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCellelementRolesNotToTraverse != null)
                {
                    jABGlobalMouseClickOnTableCell["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellelementRolesNotToTraverse);
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCellmaximumElementsToSearch != null)
                {
                    if (jABGlobalMouseClickOnTableCellmaximumElementsToSearch != null)
                    {
                        jABGlobalMouseClickOnTableCell["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellmaximumElementsToSearch);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["MaximumElementsToSearch"] = 2000;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCellmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABGlobalMouseClickOnTableCellmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGlobalMouseClickOnTableCell["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellmaximumChildElementsToSearchPerNode);
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
                jABGlobalMouseClickOnTableCell["RowIndex"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellrowIndex);
                jABGlobalMouseClickOnTableCellpropCount++;
                jABGlobalMouseClickOnTableCell["ColumnIndex"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellcolumnIndex);
                if (jABGlobalMouseClickOnTableCellenumerateViewport != null)
                {
                    if (jABGlobalMouseClickOnTableCellenumerateViewport != null)
                    {
                        jABGlobalMouseClickOnTableCell["EnumerateViewport"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellenumerateViewport);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["EnumerateViewport"] = true;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCellprocessViewportParents != null)
                {
                    if (jABGlobalMouseClickOnTableCellprocessViewportParents != null)
                    {
                        jABGlobalMouseClickOnTableCell["ProcessViewportParents"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellprocessViewportParents);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["ProcessViewportParents"] = true;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCellmaxViewportParentsToProcess != null)
                {
                    if (jABGlobalMouseClickOnTableCellmaxViewportParentsToProcess != null)
                    {
                        jABGlobalMouseClickOnTableCell["MaxViewportParentsToProcess"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellmaxViewportParentsToProcess);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["MaxViewportParentsToProcess"] = 50;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCellviewportParentElementRolesToConsider != null)
                {
                    if (jABGlobalMouseClickOnTableCellviewportParentElementRolesToConsider != null)
                    {
                        jABGlobalMouseClickOnTableCell["ViewportParentElementRolesToConsider"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellviewportParentElementRolesToConsider);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["ViewportParentElementRolesToConsider"] = "Panel,Viewport,Layered pane,Root pane";
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCellviewportLeftMargin != null)
                {
                    if (jABGlobalMouseClickOnTableCellviewportLeftMargin != null)
                    {
                        jABGlobalMouseClickOnTableCell["ViewportLeftMargin"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellviewportLeftMargin);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["ViewportLeftMargin"] = 2;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCellviewportTopMargin != null)
                {
                    if (jABGlobalMouseClickOnTableCellviewportTopMargin != null)
                    {
                        jABGlobalMouseClickOnTableCell["ViewportTopMargin"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellviewportTopMargin);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["ViewportTopMargin"] = 2;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCellviewportRightMargin != null)
                {
                    if (jABGlobalMouseClickOnTableCellviewportRightMargin != null)
                    {
                        jABGlobalMouseClickOnTableCell["ViewportRightMargin"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellviewportRightMargin);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["ViewportRightMargin"] = 2;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCellviewportBottomMargin != null)
                {
                    if (jABGlobalMouseClickOnTableCellviewportBottomMargin != null)
                    {
                        jABGlobalMouseClickOnTableCell["ViewportBottomMargin"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellviewportBottomMargin);
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
                jABGlobalMouseClickOnTableCell["MouseButton"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellmouseButton);
                if (jABGlobalMouseClickOnTableCellclickOffsetX != null)
                {
                    if (jABGlobalMouseClickOnTableCellclickOffsetX != null)
                    {
                        jABGlobalMouseClickOnTableCell["ClickOffsetX"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellclickOffsetX);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["ClickOffsetX"] = 0;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCellclickOffsetY != null)
                {
                    if (jABGlobalMouseClickOnTableCellclickOffsetY != null)
                    {
                        jABGlobalMouseClickOnTableCell["ClickOffsetY"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellclickOffsetY);
                        jABGlobalMouseClickOnTableCellpropCount++;
                    }

                    jABGlobalMouseClickOnTableCellpropCount++;
                }
                else
                {
                    jABGlobalMouseClickOnTableCell["ClickOffsetY"] = 0;
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCelloffsetRelativeTo != null)
                {
                    jABGlobalMouseClickOnTableCell["OffsetRelativeTo"] = SourceExpressionConverter.Convert(jABGlobalMouseClickOnTableCelloffsetRelativeTo);
                    jABGlobalMouseClickOnTableCellpropCount++;
                }

                if (jABGlobalMouseClickOnTableCelldelayInMilliseconds != null)
                {
                    if (jABGlobalMouseClickOnTableCelldelayInMilliseconds != null)
                    {
                        jABGlobalMouseClickOnTableCell["DelayInMilliseconds"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCelldelayInMilliseconds);
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
                jABGlobalMouseClickOnTableCell["Workflow"] = SourceExpressionConverter.ConvertToken(jABGlobalMouseClickOnTableCellworkflow);
                if (jABGlobalMouseClickOnTableCellpropCount > 0)
                {
                    callPayload.Body = jABGlobalMouseClickOnTableCell;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetRoleCSVFromElementSearchResponse> JABGetRoleCSVFromElementSearch([WorkflowExpression] Func<int> jABGetRoleCSVFromElementSearchsearchParentElementJABHandle, [WorkflowExpression] Func<string> jABGetRoleCSVFromElementSearchworkflow, [WorkflowExpression] Func<string> jABGetRoleCSVFromElementSearchsearchElementJABName = null, [WorkflowExpression] Func<string> jABGetRoleCSVFromElementSearchsearchElementJABDescription = null, [WorkflowExpression] Func<string> jABGetRoleCSVFromElementSearchsearchElementJABRole = null, [WorkflowExpression] Func<bool> jABGetRoleCSVFromElementSearchsearchSubTree = null, [WorkflowExpression] Func<int> jABGetRoleCSVFromElementSearchmaxRelativeDepth = null, [WorkflowExpression] Func<int> jABGetRoleCSVFromElementSearchmatchIndex = null, [WorkflowExpression] Func<string> jABGetRoleCSVFromElementSearchsearchFilter = null, [WorkflowExpression] Func<string> jABGetRoleCSVFromElementSearchsortByColumn = null, [WorkflowExpression] Func<bool> jABGetRoleCSVFromElementSearchmatchIndexAscending = null, [WorkflowExpression] Func<bool> jABGetRoleCSVFromElementSearchcaseSensitiveSearch = null, [WorkflowExpression] Func<bool> jABGetRoleCSVFromElementSearchonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABGetRoleCSVFromElementSearchonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABGetRoleCSVFromElementSearchelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABGetRoleCSVFromElementSearchmaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABGetRoleCSVFromElementSearchmaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<bool> jABGetRoleCSVFromElementSearchindentRoleInCSV = null, [WorkflowExpression] Func<bool> jABGetRoleCSVFromElementSearchincludeDescriptionInCSV = null, [WorkflowExpression] Func<bool> jABGetRoleCSVFromElementSearchincludeDimensionsInCSV = null)
        {
            SourceExpression.Validate(jABGetRoleCSVFromElementSearchsearchParentElementJABHandle, nameof(jABGetRoleCSVFromElementSearchsearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABGetRoleCSVFromElementSearchworkflow, nameof(jABGetRoleCSVFromElementSearchworkflow), required: true);
            SourceExpression.Validate(jABGetRoleCSVFromElementSearchsearchElementJABName, nameof(jABGetRoleCSVFromElementSearchsearchElementJABName), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementSearchsearchElementJABDescription, nameof(jABGetRoleCSVFromElementSearchsearchElementJABDescription), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementSearchsearchElementJABRole, nameof(jABGetRoleCSVFromElementSearchsearchElementJABRole), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementSearchsearchSubTree, nameof(jABGetRoleCSVFromElementSearchsearchSubTree), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementSearchmaxRelativeDepth, nameof(jABGetRoleCSVFromElementSearchmaxRelativeDepth), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementSearchmatchIndex, nameof(jABGetRoleCSVFromElementSearchmatchIndex), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementSearchsearchFilter, nameof(jABGetRoleCSVFromElementSearchsearchFilter), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementSearchsortByColumn, nameof(jABGetRoleCSVFromElementSearchsortByColumn), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementSearchmatchIndexAscending, nameof(jABGetRoleCSVFromElementSearchmatchIndexAscending), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementSearchcaseSensitiveSearch, nameof(jABGetRoleCSVFromElementSearchcaseSensitiveSearch), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementSearchonlySearchVisibleElements, nameof(jABGetRoleCSVFromElementSearchonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementSearchonlySearchShowingElements, nameof(jABGetRoleCSVFromElementSearchonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementSearchelementRolesNotToTraverse, nameof(jABGetRoleCSVFromElementSearchelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementSearchmaximumElementsToSearch, nameof(jABGetRoleCSVFromElementSearchmaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementSearchmaximumChildElementsToSearchPerNode, nameof(jABGetRoleCSVFromElementSearchmaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementSearchindentRoleInCSV, nameof(jABGetRoleCSVFromElementSearchindentRoleInCSV), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementSearchincludeDescriptionInCSV, nameof(jABGetRoleCSVFromElementSearchincludeDescriptionInCSV), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementSearchincludeDimensionsInCSV, nameof(jABGetRoleCSVFromElementSearchincludeDimensionsInCSV), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetRoleCSVFromElementSearch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetRoleCSVFromElementSearch = new JObject();
                var jABGetRoleCSVFromElementSearchpropCount = 0;
                jABGetRoleCSVFromElementSearchpropCount++;
                jABGetRoleCSVFromElementSearch["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementSearchsearchParentElementJABHandle);
                if (jABGetRoleCSVFromElementSearchsearchElementJABName != null)
                {
                    jABGetRoleCSVFromElementSearch["SearchElementJABName"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementSearchsearchElementJABName);
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (jABGetRoleCSVFromElementSearchsearchElementJABDescription != null)
                {
                    jABGetRoleCSVFromElementSearch["SearchElementJABDescription"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementSearchsearchElementJABDescription);
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (jABGetRoleCSVFromElementSearchsearchElementJABRole != null)
                {
                    jABGetRoleCSVFromElementSearch["SearchElementJABRole"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementSearchsearchElementJABRole);
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (jABGetRoleCSVFromElementSearchsearchSubTree != null)
                {
                    if (jABGetRoleCSVFromElementSearchsearchSubTree != null)
                    {
                        jABGetRoleCSVFromElementSearch["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementSearchsearchSubTree);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["SearchSubTree"] = true;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (jABGetRoleCSVFromElementSearchmaxRelativeDepth != null)
                {
                    if (jABGetRoleCSVFromElementSearchmaxRelativeDepth != null)
                    {
                        jABGetRoleCSVFromElementSearch["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementSearchmaxRelativeDepth);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["MaxRelativeDepth"] = 0;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (jABGetRoleCSVFromElementSearchmatchIndex != null)
                {
                    if (jABGetRoleCSVFromElementSearchmatchIndex != null)
                    {
                        jABGetRoleCSVFromElementSearch["MatchIndex"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementSearchmatchIndex);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["MatchIndex"] = 1;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (jABGetRoleCSVFromElementSearchsearchFilter != null)
                {
                    jABGetRoleCSVFromElementSearch["SearchFilter"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementSearchsearchFilter);
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (jABGetRoleCSVFromElementSearchsortByColumn != null)
                {
                    jABGetRoleCSVFromElementSearch["SortByColumn"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementSearchsortByColumn);
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (jABGetRoleCSVFromElementSearchmatchIndexAscending != null)
                {
                    if (jABGetRoleCSVFromElementSearchmatchIndexAscending != null)
                    {
                        jABGetRoleCSVFromElementSearch["MatchIndexAscending"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementSearchmatchIndexAscending);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["MatchIndexAscending"] = true;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (jABGetRoleCSVFromElementSearchcaseSensitiveSearch != null)
                {
                    if (jABGetRoleCSVFromElementSearchcaseSensitiveSearch != null)
                    {
                        jABGetRoleCSVFromElementSearch["CaseSensitiveSearch"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementSearchcaseSensitiveSearch);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["CaseSensitiveSearch"] = false;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (jABGetRoleCSVFromElementSearchonlySearchVisibleElements != null)
                {
                    if (jABGetRoleCSVFromElementSearchonlySearchVisibleElements != null)
                    {
                        jABGetRoleCSVFromElementSearch["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementSearchonlySearchVisibleElements);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["OnlySearchVisibleElements"] = true;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (jABGetRoleCSVFromElementSearchonlySearchShowingElements != null)
                {
                    if (jABGetRoleCSVFromElementSearchonlySearchShowingElements != null)
                    {
                        jABGetRoleCSVFromElementSearch["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementSearchonlySearchShowingElements);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["OnlySearchShowingElements"] = true;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (jABGetRoleCSVFromElementSearchelementRolesNotToTraverse != null)
                {
                    jABGetRoleCSVFromElementSearch["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementSearchelementRolesNotToTraverse);
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (jABGetRoleCSVFromElementSearchmaximumElementsToSearch != null)
                {
                    if (jABGetRoleCSVFromElementSearchmaximumElementsToSearch != null)
                    {
                        jABGetRoleCSVFromElementSearch["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementSearchmaximumElementsToSearch);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["MaximumElementsToSearch"] = 2000;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (jABGetRoleCSVFromElementSearchmaximumChildElementsToSearchPerNode != null)
                {
                    if (jABGetRoleCSVFromElementSearchmaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetRoleCSVFromElementSearch["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementSearchmaximumChildElementsToSearchPerNode);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (jABGetRoleCSVFromElementSearchindentRoleInCSV != null)
                {
                    if (jABGetRoleCSVFromElementSearchindentRoleInCSV != null)
                    {
                        jABGetRoleCSVFromElementSearch["IndentRoleInCSV"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementSearchindentRoleInCSV);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["IndentRoleInCSV"] = true;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (jABGetRoleCSVFromElementSearchincludeDescriptionInCSV != null)
                {
                    if (jABGetRoleCSVFromElementSearchincludeDescriptionInCSV != null)
                    {
                        jABGetRoleCSVFromElementSearch["IncludeDescriptionInCSV"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementSearchincludeDescriptionInCSV);
                        jABGetRoleCSVFromElementSearchpropCount++;
                    }

                    jABGetRoleCSVFromElementSearchpropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementSearch["IncludeDescriptionInCSV"] = true;
                    jABGetRoleCSVFromElementSearchpropCount++;
                }

                if (jABGetRoleCSVFromElementSearchincludeDimensionsInCSV != null)
                {
                    if (jABGetRoleCSVFromElementSearchincludeDimensionsInCSV != null)
                    {
                        jABGetRoleCSVFromElementSearch["IncludeDimensionsInCSV"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementSearchincludeDimensionsInCSV);
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
                jABGetRoleCSVFromElementSearch["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementSearchworkflow);
                if (jABGetRoleCSVFromElementSearchpropCount > 0)
                {
                    callPayload.Body = jABGetRoleCSVFromElementSearch;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetRoleCSVFromElementSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetRoleCSVFromElementHandleResponse> JABGetRoleCSVFromElementHandle([WorkflowExpression] Func<int> jABGetRoleCSVFromElementHandlesearchParentElementJABHandle, [WorkflowExpression] Func<string> jABGetRoleCSVFromElementHandleworkflow, [WorkflowExpression] Func<bool> jABGetRoleCSVFromElementHandlesearchSubTree = null, [WorkflowExpression] Func<int> jABGetRoleCSVFromElementHandlemaxRelativeDepth = null, [WorkflowExpression] Func<bool> jABGetRoleCSVFromElementHandleonlySearchVisibleElements = null, [WorkflowExpression] Func<bool> jABGetRoleCSVFromElementHandleonlySearchShowingElements = null, [WorkflowExpression] Func<string> jABGetRoleCSVFromElementHandleelementRolesNotToTraverse = null, [WorkflowExpression] Func<int> jABGetRoleCSVFromElementHandlemaximumElementsToSearch = null, [WorkflowExpression] Func<int> jABGetRoleCSVFromElementHandlemaximumChildElementsToSearchPerNode = null, [WorkflowExpression] Func<bool> jABGetRoleCSVFromElementHandleindentRoleInCSV = null, [WorkflowExpression] Func<bool> jABGetRoleCSVFromElementHandleincludeDescriptionInCSV = null, [WorkflowExpression] Func<bool> jABGetRoleCSVFromElementHandleincludeDimensionsInCSV = null)
        {
            SourceExpression.Validate(jABGetRoleCSVFromElementHandlesearchParentElementJABHandle, nameof(jABGetRoleCSVFromElementHandlesearchParentElementJABHandle), required: true);
            SourceExpression.Validate(jABGetRoleCSVFromElementHandleworkflow, nameof(jABGetRoleCSVFromElementHandleworkflow), required: true);
            SourceExpression.Validate(jABGetRoleCSVFromElementHandlesearchSubTree, nameof(jABGetRoleCSVFromElementHandlesearchSubTree), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementHandlemaxRelativeDepth, nameof(jABGetRoleCSVFromElementHandlemaxRelativeDepth), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementHandleonlySearchVisibleElements, nameof(jABGetRoleCSVFromElementHandleonlySearchVisibleElements), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementHandleonlySearchShowingElements, nameof(jABGetRoleCSVFromElementHandleonlySearchShowingElements), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementHandleelementRolesNotToTraverse, nameof(jABGetRoleCSVFromElementHandleelementRolesNotToTraverse), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementHandlemaximumElementsToSearch, nameof(jABGetRoleCSVFromElementHandlemaximumElementsToSearch), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementHandlemaximumChildElementsToSearchPerNode, nameof(jABGetRoleCSVFromElementHandlemaximumChildElementsToSearchPerNode), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementHandleindentRoleInCSV, nameof(jABGetRoleCSVFromElementHandleindentRoleInCSV), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementHandleincludeDescriptionInCSV, nameof(jABGetRoleCSVFromElementHandleincludeDescriptionInCSV), required: false);
            SourceExpression.Validate(jABGetRoleCSVFromElementHandleincludeDimensionsInCSV, nameof(jABGetRoleCSVFromElementHandleincludeDimensionsInCSV), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/JavaAccessBridge/JABGetRoleCSVFromElementHandle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var jABGetRoleCSVFromElementHandle = new JObject();
                var jABGetRoleCSVFromElementHandlepropCount = 0;
                jABGetRoleCSVFromElementHandlepropCount++;
                jABGetRoleCSVFromElementHandle["SearchParentElementJABHandle"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementHandlesearchParentElementJABHandle);
                if (jABGetRoleCSVFromElementHandlesearchSubTree != null)
                {
                    if (jABGetRoleCSVFromElementHandlesearchSubTree != null)
                    {
                        jABGetRoleCSVFromElementHandle["SearchSubTree"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementHandlesearchSubTree);
                        jABGetRoleCSVFromElementHandlepropCount++;
                    }

                    jABGetRoleCSVFromElementHandlepropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementHandle["SearchSubTree"] = true;
                    jABGetRoleCSVFromElementHandlepropCount++;
                }

                if (jABGetRoleCSVFromElementHandlemaxRelativeDepth != null)
                {
                    if (jABGetRoleCSVFromElementHandlemaxRelativeDepth != null)
                    {
                        jABGetRoleCSVFromElementHandle["MaxRelativeDepth"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementHandlemaxRelativeDepth);
                        jABGetRoleCSVFromElementHandlepropCount++;
                    }

                    jABGetRoleCSVFromElementHandlepropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementHandle["MaxRelativeDepth"] = 0;
                    jABGetRoleCSVFromElementHandlepropCount++;
                }

                if (jABGetRoleCSVFromElementHandleonlySearchVisibleElements != null)
                {
                    if (jABGetRoleCSVFromElementHandleonlySearchVisibleElements != null)
                    {
                        jABGetRoleCSVFromElementHandle["OnlySearchVisibleElements"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementHandleonlySearchVisibleElements);
                        jABGetRoleCSVFromElementHandlepropCount++;
                    }

                    jABGetRoleCSVFromElementHandlepropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementHandle["OnlySearchVisibleElements"] = true;
                    jABGetRoleCSVFromElementHandlepropCount++;
                }

                if (jABGetRoleCSVFromElementHandleonlySearchShowingElements != null)
                {
                    if (jABGetRoleCSVFromElementHandleonlySearchShowingElements != null)
                    {
                        jABGetRoleCSVFromElementHandle["OnlySearchShowingElements"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementHandleonlySearchShowingElements);
                        jABGetRoleCSVFromElementHandlepropCount++;
                    }

                    jABGetRoleCSVFromElementHandlepropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementHandle["OnlySearchShowingElements"] = true;
                    jABGetRoleCSVFromElementHandlepropCount++;
                }

                if (jABGetRoleCSVFromElementHandleelementRolesNotToTraverse != null)
                {
                    jABGetRoleCSVFromElementHandle["ElementRolesNotToTraverse"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementHandleelementRolesNotToTraverse);
                    jABGetRoleCSVFromElementHandlepropCount++;
                }

                if (jABGetRoleCSVFromElementHandlemaximumElementsToSearch != null)
                {
                    if (jABGetRoleCSVFromElementHandlemaximumElementsToSearch != null)
                    {
                        jABGetRoleCSVFromElementHandle["MaximumElementsToSearch"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementHandlemaximumElementsToSearch);
                        jABGetRoleCSVFromElementHandlepropCount++;
                    }

                    jABGetRoleCSVFromElementHandlepropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementHandle["MaximumElementsToSearch"] = 2000;
                    jABGetRoleCSVFromElementHandlepropCount++;
                }

                if (jABGetRoleCSVFromElementHandlemaximumChildElementsToSearchPerNode != null)
                {
                    if (jABGetRoleCSVFromElementHandlemaximumChildElementsToSearchPerNode != null)
                    {
                        jABGetRoleCSVFromElementHandle["MaximumChildElementsToSearchPerNode"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementHandlemaximumChildElementsToSearchPerNode);
                        jABGetRoleCSVFromElementHandlepropCount++;
                    }

                    jABGetRoleCSVFromElementHandlepropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementHandle["MaximumChildElementsToSearchPerNode"] = 200;
                    jABGetRoleCSVFromElementHandlepropCount++;
                }

                if (jABGetRoleCSVFromElementHandleindentRoleInCSV != null)
                {
                    if (jABGetRoleCSVFromElementHandleindentRoleInCSV != null)
                    {
                        jABGetRoleCSVFromElementHandle["IndentRoleInCSV"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementHandleindentRoleInCSV);
                        jABGetRoleCSVFromElementHandlepropCount++;
                    }

                    jABGetRoleCSVFromElementHandlepropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementHandle["IndentRoleInCSV"] = true;
                    jABGetRoleCSVFromElementHandlepropCount++;
                }

                if (jABGetRoleCSVFromElementHandleincludeDescriptionInCSV != null)
                {
                    if (jABGetRoleCSVFromElementHandleincludeDescriptionInCSV != null)
                    {
                        jABGetRoleCSVFromElementHandle["IncludeDescriptionInCSV"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementHandleincludeDescriptionInCSV);
                        jABGetRoleCSVFromElementHandlepropCount++;
                    }

                    jABGetRoleCSVFromElementHandlepropCount++;
                }
                else
                {
                    jABGetRoleCSVFromElementHandle["IncludeDescriptionInCSV"] = true;
                    jABGetRoleCSVFromElementHandlepropCount++;
                }

                if (jABGetRoleCSVFromElementHandleincludeDimensionsInCSV != null)
                {
                    if (jABGetRoleCSVFromElementHandleincludeDimensionsInCSV != null)
                    {
                        jABGetRoleCSVFromElementHandle["IncludeDimensionsInCSV"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementHandleincludeDimensionsInCSV);
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
                jABGetRoleCSVFromElementHandle["Workflow"] = SourceExpressionConverter.ConvertToken(jABGetRoleCSVFromElementHandleworkflow);
                if (jABGetRoleCSVFromElementHandlepropCount > 0)
                {
                    callPayload.Body = jABGetRoleCSVFromElementHandle;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JABGetRoleCSVFromElementHandleResponse>(BuildSourceInput);
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