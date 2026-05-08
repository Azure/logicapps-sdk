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
        public IBodyWorkflowAction<JABConnectToJavaAccessBridgeResponse> JABConnectToJavaAccessBridge(Expression<Func<string>> jABConnectToJavaAccessBridgeworkflow, Expression<Func<string>> jABConnectToJavaAccessBridgewindowsAccessBridgeDLLSearchFolder = null, Expression<Func<string>> jABConnectToJavaAccessBridgeiAJavaAccessBridgePath = null, Expression<Func<bool>> jABConnectToJavaAccessBridgeis64BitJABDLL = null, Expression<Func<bool>> jABConnectToJavaAccessBridgeuseCOMFor64BitJABDLL = null, Expression<Func<bool>> jABConnectToJavaAccessBridgeenableJavaAccessBridge = null, Expression<Func<string>> jABConnectToJavaAccessBridgeaccessibilityFilepath = null, Expression<Func<int>> jABConnectToJavaAccessBridgecommandTimeoutInSeconds = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABConnectToJavaAccessBridge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABConnectToJavaAccessBridge = new JObject();
            var jABConnectToJavaAccessBridgepropCount = 0;
            if (jABConnectToJavaAccessBridgewindowsAccessBridgeDLLSearchFolder != null)
            {
                jABConnectToJavaAccessBridge["WindowsAccessBridgeDLLSearchFolder"] = ExpressionConverter.ConvertO(jABConnectToJavaAccessBridgewindowsAccessBridgeDLLSearchFolder);
                jABConnectToJavaAccessBridgepropCount++;
            }

            if (jABConnectToJavaAccessBridgeiAJavaAccessBridgePath != null)
            {
                jABConnectToJavaAccessBridge["IAJavaAccessBridgePath"] = ExpressionConverter.ConvertO(jABConnectToJavaAccessBridgeiAJavaAccessBridgePath);
                jABConnectToJavaAccessBridgepropCount++;
            }

            if (jABConnectToJavaAccessBridgeis64BitJABDLL != null)
            {
                if (jABConnectToJavaAccessBridgeis64BitJABDLL != null)
                {
                    jABConnectToJavaAccessBridge["Is64BitJABDLL"] = ExpressionConverter.ConvertO(jABConnectToJavaAccessBridgeis64BitJABDLL);
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
                    jABConnectToJavaAccessBridge["UseCOMFor64BitJABDLL"] = ExpressionConverter.ConvertO(jABConnectToJavaAccessBridgeuseCOMFor64BitJABDLL);
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
                    jABConnectToJavaAccessBridge["EnableJavaAccessBridge"] = ExpressionConverter.ConvertO(jABConnectToJavaAccessBridgeenableJavaAccessBridge);
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
                    jABConnectToJavaAccessBridge["AccessibilityFilepath"] = ExpressionConverter.ConvertO(jABConnectToJavaAccessBridgeaccessibilityFilepath);
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
                    jABConnectToJavaAccessBridge["CommandTimeoutInSeconds"] = ExpressionConverter.ConvertO(jABConnectToJavaAccessBridgecommandTimeoutInSeconds);
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
            jABConnectToJavaAccessBridge["Workflow"] = ExpressionConverter.ConvertO(jABConnectToJavaAccessBridgeworkflow);
            if (jABConnectToJavaAccessBridgepropCount > 0)
            {
                callPayload.Body = jABConnectToJavaAccessBridge;
            }

            return new ApiConnectionAction<JABConnectToJavaAccessBridgeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABDisconnectFromJavaAccessBridge(Expression<Func<string>> jABDisconnectFromJavaAccessBridgeworkflow, Expression<Func<bool>> jABDisconnectFromJavaAccessBridgedisableJavaAccessBridge = null, Expression<Func<string>> jABDisconnectFromJavaAccessBridgeaccessibilityFilepath = null)
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
                    jABDisconnectFromJavaAccessBridge["DisableJavaAccessBridge"] = ExpressionConverter.ConvertO(jABDisconnectFromJavaAccessBridgedisableJavaAccessBridge);
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
                    jABDisconnectFromJavaAccessBridge["AccessibilityFilepath"] = ExpressionConverter.ConvertO(jABDisconnectFromJavaAccessBridgeaccessibilityFilepath);
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
            jABDisconnectFromJavaAccessBridge["Workflow"] = ExpressionConverter.ConvertO(jABDisconnectFromJavaAccessBridgeworkflow);
            if (jABDisconnectFromJavaAccessBridgepropCount > 0)
            {
                callPayload.Body = jABDisconnectFromJavaAccessBridge;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetConnectionStatusResponse> JABGetConnectionStatus(Expression<Func<string>> jABGetConnectionStatusworkflow)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetConnectionStatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetConnectionStatus = new JObject();
            var jABGetConnectionStatuspropCount = 0;
            jABGetConnectionStatuspropCount++;
            jABGetConnectionStatus["Workflow"] = ExpressionConverter.ConvertO(jABGetConnectionStatusworkflow);
            if (jABGetConnectionStatuspropCount > 0)
            {
                callPayload.Body = jABGetConnectionStatus;
            }

            return new ApiConnectionAction<JABGetConnectionStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABIsJavaWindowResponse> JABIsJavaWindow(Expression<Func<int>> jABIsJavaWindowparentWindowHandle, Expression<Func<string>> jABIsJavaWindowworkflow, Expression<Func<string>> jABIsJavaWindowsearchElementName = null, Expression<Func<string>> jABIsJavaWindowsearchElementClassName = null, Expression<Func<string>> jABIsJavaWindowsearchElementAutomationId = null, Expression<Func<string>> jABIsJavaWindowsearchLocalizedControlType = null, Expression<Func<bool>> jABIsJavaWindowsearchSubTree = null, Expression<Func<int>> jABIsJavaWindowmatchIndex = null, Expression<Func<string>> jABIsJavaWindowsearchFilter = null, Expression<Func<string>> jABIsJavaWindowsortByColumn = null, Expression<Func<bool>> jABIsJavaWindowmatchIndexAscending = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABIsJavaWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABIsJavaWindow = new JObject();
            var jABIsJavaWindowpropCount = 0;
            jABIsJavaWindowpropCount++;
            jABIsJavaWindow["ParentWindowHandle"] = ExpressionConverter.ConvertO(jABIsJavaWindowparentWindowHandle);
            if (jABIsJavaWindowsearchElementName != null)
            {
                jABIsJavaWindow["SearchElementName"] = ExpressionConverter.ConvertO(jABIsJavaWindowsearchElementName);
                jABIsJavaWindowpropCount++;
            }

            if (jABIsJavaWindowsearchElementClassName != null)
            {
                jABIsJavaWindow["SearchElementClassName"] = ExpressionConverter.ConvertO(jABIsJavaWindowsearchElementClassName);
                jABIsJavaWindowpropCount++;
            }

            if (jABIsJavaWindowsearchElementAutomationId != null)
            {
                jABIsJavaWindow["SearchElementAutomationId"] = ExpressionConverter.ConvertO(jABIsJavaWindowsearchElementAutomationId);
                jABIsJavaWindowpropCount++;
            }

            if (jABIsJavaWindowsearchLocalizedControlType != null)
            {
                jABIsJavaWindow["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(jABIsJavaWindowsearchLocalizedControlType);
                jABIsJavaWindowpropCount++;
            }

            if (jABIsJavaWindowsearchSubTree != null)
            {
                if (jABIsJavaWindowsearchSubTree != null)
                {
                    jABIsJavaWindow["SearchSubTree"] = ExpressionConverter.ConvertO(jABIsJavaWindowsearchSubTree);
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
                    jABIsJavaWindow["MatchIndex"] = ExpressionConverter.ConvertO(jABIsJavaWindowmatchIndex);
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
                jABIsJavaWindow["SearchFilter"] = ExpressionConverter.ConvertO(jABIsJavaWindowsearchFilter);
                jABIsJavaWindowpropCount++;
            }

            if (jABIsJavaWindowsortByColumn != null)
            {
                jABIsJavaWindow["SortByColumn"] = ExpressionConverter.ConvertO(jABIsJavaWindowsortByColumn);
                jABIsJavaWindowpropCount++;
            }

            if (jABIsJavaWindowmatchIndexAscending != null)
            {
                if (jABIsJavaWindowmatchIndexAscending != null)
                {
                    jABIsJavaWindow["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABIsJavaWindowmatchIndexAscending);
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
            jABIsJavaWindow["Workflow"] = ExpressionConverter.ConvertO(jABIsJavaWindowworkflow);
            if (jABIsJavaWindowpropCount > 0)
            {
                callPayload.Body = jABIsJavaWindow;
            }

            return new ApiConnectionAction<JABIsJavaWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetWindowsAccessBridgeInfoResponse> JABGetWindowsAccessBridgeInfo(Expression<Func<int>> jABGetWindowsAccessBridgeInfovMID, Expression<Func<string>> jABGetWindowsAccessBridgeInfoworkflow)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetWindowsAccessBridgeInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetWindowsAccessBridgeInfo = new JObject();
            var jABGetWindowsAccessBridgeInfopropCount = 0;
            jABGetWindowsAccessBridgeInfopropCount++;
            jABGetWindowsAccessBridgeInfo["VMID"] = ExpressionConverter.ConvertO(jABGetWindowsAccessBridgeInfovMID);
            jABGetWindowsAccessBridgeInfopropCount++;
            jABGetWindowsAccessBridgeInfo["Workflow"] = ExpressionConverter.ConvertO(jABGetWindowsAccessBridgeInfoworkflow);
            if (jABGetWindowsAccessBridgeInfopropCount > 0)
            {
                callPayload.Body = jABGetWindowsAccessBridgeInfo;
            }

            return new ApiConnectionAction<JABGetWindowsAccessBridgeInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetUIAElementPropertiesResponse> JABGetUIAElementProperties(Expression<Func<int>> jABGetUIAElementPropertiesparentWindowHandle, Expression<Func<string>> jABGetUIAElementPropertiesworkflow, Expression<Func<string>> jABGetUIAElementPropertiessearchElementName = null, Expression<Func<string>> jABGetUIAElementPropertiessearchElementClassName = null, Expression<Func<string>> jABGetUIAElementPropertiessearchElementAutomationId = null, Expression<Func<string>> jABGetUIAElementPropertiessearchLocalizedControlType = null, Expression<Func<bool>> jABGetUIAElementPropertiessearchSubTree = null, Expression<Func<int>> jABGetUIAElementPropertiesmatchIndex = null, Expression<Func<string>> jABGetUIAElementPropertiessearchFilter = null, Expression<Func<string>> jABGetUIAElementPropertiessortByColumn = null, Expression<Func<bool>> jABGetUIAElementPropertiesmatchIndexAscending = null, Expression<Func<int>> jABGetUIAElementPropertiesmaxStringLength = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetUIAElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetUIAElementProperties = new JObject();
            var jABGetUIAElementPropertiespropCount = 0;
            jABGetUIAElementPropertiespropCount++;
            jABGetUIAElementProperties["ParentWindowHandle"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiesparentWindowHandle);
            if (jABGetUIAElementPropertiessearchElementName != null)
            {
                jABGetUIAElementProperties["SearchElementName"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiessearchElementName);
                jABGetUIAElementPropertiespropCount++;
            }

            if (jABGetUIAElementPropertiessearchElementClassName != null)
            {
                jABGetUIAElementProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiessearchElementClassName);
                jABGetUIAElementPropertiespropCount++;
            }

            if (jABGetUIAElementPropertiessearchElementAutomationId != null)
            {
                jABGetUIAElementProperties["SearchElementAutomationId"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiessearchElementAutomationId);
                jABGetUIAElementPropertiespropCount++;
            }

            if (jABGetUIAElementPropertiessearchLocalizedControlType != null)
            {
                jABGetUIAElementProperties["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiessearchLocalizedControlType);
                jABGetUIAElementPropertiespropCount++;
            }

            if (jABGetUIAElementPropertiessearchSubTree != null)
            {
                if (jABGetUIAElementPropertiessearchSubTree != null)
                {
                    jABGetUIAElementProperties["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiessearchSubTree);
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
                    jABGetUIAElementProperties["MatchIndex"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiesmatchIndex);
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
                jABGetUIAElementProperties["SearchFilter"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiessearchFilter);
                jABGetUIAElementPropertiespropCount++;
            }

            if (jABGetUIAElementPropertiessortByColumn != null)
            {
                jABGetUIAElementProperties["SortByColumn"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiessortByColumn);
                jABGetUIAElementPropertiespropCount++;
            }

            if (jABGetUIAElementPropertiesmatchIndexAscending != null)
            {
                if (jABGetUIAElementPropertiesmatchIndexAscending != null)
                {
                    jABGetUIAElementProperties["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiesmatchIndexAscending);
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
                    jABGetUIAElementProperties["MaxStringLength"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiesmaxStringLength);
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
            jABGetUIAElementProperties["Workflow"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiesworkflow);
            if (jABGetUIAElementPropertiespropCount > 0)
            {
                callPayload.Body = jABGetUIAElementProperties;
            }

            return new ApiConnectionAction<JABGetUIAElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetJABElementPropertiesResponse> JABGetJABElementProperties(Expression<Func<int>> jABGetJABElementPropertiessearchParentElementJABHandle, Expression<Func<string>> jABGetJABElementPropertiesworkflow, Expression<Func<string>> jABGetJABElementPropertiessearchElementJABName = null, Expression<Func<string>> jABGetJABElementPropertiessearchElementJABDescription = null, Expression<Func<string>> jABGetJABElementPropertiessearchElementJABRole = null, Expression<Func<bool>> jABGetJABElementPropertiessearchSubTree = null, Expression<Func<int>> jABGetJABElementPropertiesmaxRelativeDepth = null, Expression<Func<int>> jABGetJABElementPropertiesmatchIndex = null, Expression<Func<string>> jABGetJABElementPropertiessearchFilter = null, Expression<Func<string>> jABGetJABElementPropertiessortByColumn = null, Expression<Func<bool>> jABGetJABElementPropertiesmatchIndexAscending = null, Expression<Func<bool>> jABGetJABElementPropertiescaseSensitiveSearch = null, Expression<Func<bool>> jABGetJABElementPropertiesonlySearchVisibleElements = null, Expression<Func<bool>> jABGetJABElementPropertiesonlySearchShowingElements = null, Expression<Func<string>> jABGetJABElementPropertieselementRolesNotToTraverse = null, Expression<Func<int>> jABGetJABElementPropertiesmaximumElementsToSearch = null, Expression<Func<int>> jABGetJABElementPropertiesmaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABGetJABElementPropertiesmaxStringLength = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetJABElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetJABElementProperties = new JObject();
            var jABGetJABElementPropertiespropCount = 0;
            jABGetJABElementPropertiespropCount++;
            jABGetJABElementProperties["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiessearchParentElementJABHandle);
            if (jABGetJABElementPropertiessearchElementJABName != null)
            {
                jABGetJABElementProperties["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiessearchElementJABName);
                jABGetJABElementPropertiespropCount++;
            }

            if (jABGetJABElementPropertiessearchElementJABDescription != null)
            {
                jABGetJABElementProperties["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiessearchElementJABDescription);
                jABGetJABElementPropertiespropCount++;
            }

            if (jABGetJABElementPropertiessearchElementJABRole != null)
            {
                jABGetJABElementProperties["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiessearchElementJABRole);
                jABGetJABElementPropertiespropCount++;
            }

            if (jABGetJABElementPropertiessearchSubTree != null)
            {
                if (jABGetJABElementPropertiessearchSubTree != null)
                {
                    jABGetJABElementProperties["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiessearchSubTree);
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
                    jABGetJABElementProperties["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesmaxRelativeDepth);
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
                    jABGetJABElementProperties["MatchIndex"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesmatchIndex);
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
                jABGetJABElementProperties["SearchFilter"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiessearchFilter);
                jABGetJABElementPropertiespropCount++;
            }

            if (jABGetJABElementPropertiessortByColumn != null)
            {
                jABGetJABElementProperties["SortByColumn"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiessortByColumn);
                jABGetJABElementPropertiespropCount++;
            }

            if (jABGetJABElementPropertiesmatchIndexAscending != null)
            {
                if (jABGetJABElementPropertiesmatchIndexAscending != null)
                {
                    jABGetJABElementProperties["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesmatchIndexAscending);
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
                    jABGetJABElementProperties["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiescaseSensitiveSearch);
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
                    jABGetJABElementProperties["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesonlySearchVisibleElements);
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
                    jABGetJABElementProperties["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesonlySearchShowingElements);
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
                jABGetJABElementProperties["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetJABElementPropertieselementRolesNotToTraverse);
                jABGetJABElementPropertiespropCount++;
            }

            if (jABGetJABElementPropertiesmaximumElementsToSearch != null)
            {
                if (jABGetJABElementPropertiesmaximumElementsToSearch != null)
                {
                    jABGetJABElementProperties["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesmaximumElementsToSearch);
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
                    jABGetJABElementProperties["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesmaximumChildElementsToSearchPerNode);
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
                    jABGetJABElementProperties["MaxStringLength"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesmaxStringLength);
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
            jABGetJABElementProperties["Workflow"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesworkflow);
            if (jABGetJABElementPropertiespropCount > 0)
            {
                callPayload.Body = jABGetJABElementProperties;
            }

            return new ApiConnectionAction<JABGetJABElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABDrawRectangleAroundJABElement(Expression<Func<int>> jABDrawRectangleAroundJABElementsearchParentElementJABHandle, Expression<Func<string>> jABDrawRectangleAroundJABElementworkflow, Expression<Func<string>> jABDrawRectangleAroundJABElementsearchElementJABName = null, Expression<Func<string>> jABDrawRectangleAroundJABElementsearchElementJABDescription = null, Expression<Func<string>> jABDrawRectangleAroundJABElementsearchElementJABRole = null, Expression<Func<bool>> jABDrawRectangleAroundJABElementsearchSubTree = null, Expression<Func<int>> jABDrawRectangleAroundJABElementmaxRelativeDepth = null, Expression<Func<int>> jABDrawRectangleAroundJABElementmatchIndex = null, Expression<Func<string>> jABDrawRectangleAroundJABElementsearchFilter = null, Expression<Func<string>> jABDrawRectangleAroundJABElementsortByColumn = null, Expression<Func<bool>> jABDrawRectangleAroundJABElementmatchIndexAscending = null, Expression<Func<bool>> jABDrawRectangleAroundJABElementcaseSensitiveSearch = null, Expression<Func<bool>> jABDrawRectangleAroundJABElementonlySearchVisibleElements = null, Expression<Func<bool>> jABDrawRectangleAroundJABElementonlySearchShowingElements = null, Expression<Func<string>> jABDrawRectangleAroundJABElementelementRolesNotToTraverse = null, Expression<Func<int>> jABDrawRectangleAroundJABElementmaximumElementsToSearch = null, Expression<Func<int>> jABDrawRectangleAroundJABElementmaximumChildElementsToSearchPerNode = null, Expression<Func<string>> jABDrawRectangleAroundJABElementpenColour = null, Expression<Func<int>> jABDrawRectangleAroundJABElementpenThicknessPixels = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABDrawRectangleAroundJABElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABDrawRectangleAroundJABElement = new JObject();
            var jABDrawRectangleAroundJABElementpropCount = 0;
            jABDrawRectangleAroundJABElementpropCount++;
            jABDrawRectangleAroundJABElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementsearchParentElementJABHandle);
            if (jABDrawRectangleAroundJABElementsearchElementJABName != null)
            {
                jABDrawRectangleAroundJABElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementsearchElementJABName);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            if (jABDrawRectangleAroundJABElementsearchElementJABDescription != null)
            {
                jABDrawRectangleAroundJABElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementsearchElementJABDescription);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            if (jABDrawRectangleAroundJABElementsearchElementJABRole != null)
            {
                jABDrawRectangleAroundJABElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementsearchElementJABRole);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            if (jABDrawRectangleAroundJABElementsearchSubTree != null)
            {
                if (jABDrawRectangleAroundJABElementsearchSubTree != null)
                {
                    jABDrawRectangleAroundJABElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementsearchSubTree);
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
                    jABDrawRectangleAroundJABElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementmaxRelativeDepth);
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
                    jABDrawRectangleAroundJABElement["MatchIndex"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementmatchIndex);
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
                jABDrawRectangleAroundJABElement["SearchFilter"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementsearchFilter);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            if (jABDrawRectangleAroundJABElementsortByColumn != null)
            {
                jABDrawRectangleAroundJABElement["SortByColumn"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementsortByColumn);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            if (jABDrawRectangleAroundJABElementmatchIndexAscending != null)
            {
                if (jABDrawRectangleAroundJABElementmatchIndexAscending != null)
                {
                    jABDrawRectangleAroundJABElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementmatchIndexAscending);
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
                    jABDrawRectangleAroundJABElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementcaseSensitiveSearch);
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
                    jABDrawRectangleAroundJABElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementonlySearchVisibleElements);
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
                    jABDrawRectangleAroundJABElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementonlySearchShowingElements);
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
                jABDrawRectangleAroundJABElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementelementRolesNotToTraverse);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            if (jABDrawRectangleAroundJABElementmaximumElementsToSearch != null)
            {
                if (jABDrawRectangleAroundJABElementmaximumElementsToSearch != null)
                {
                    jABDrawRectangleAroundJABElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementmaximumElementsToSearch);
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
                    jABDrawRectangleAroundJABElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementmaximumChildElementsToSearchPerNode);
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
                    jABDrawRectangleAroundJABElement["PenColour"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementpenColour);
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
                    jABDrawRectangleAroundJABElement["PenThicknessPixels"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementpenThicknessPixels);
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
            jABDrawRectangleAroundJABElement["Workflow"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementworkflow);
            if (jABDrawRectangleAroundJABElementpropCount > 0)
            {
                callPayload.Body = jABDrawRectangleAroundJABElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABDoesElementExistResponse> JABDoesElementExist(Expression<Func<int>> jABDoesElementExistsearchParentElementJABHandle, Expression<Func<string>> jABDoesElementExistworkflow, Expression<Func<string>> jABDoesElementExistsearchElementJABName = null, Expression<Func<string>> jABDoesElementExistsearchElementJABDescription = null, Expression<Func<string>> jABDoesElementExistsearchElementJABRole = null, Expression<Func<bool>> jABDoesElementExistsearchSubTree = null, Expression<Func<int>> jABDoesElementExistmaxRelativeDepth = null, Expression<Func<int>> jABDoesElementExistmatchIndex = null, Expression<Func<string>> jABDoesElementExistsearchFilter = null, Expression<Func<string>> jABDoesElementExistsortByColumn = null, Expression<Func<bool>> jABDoesElementExistmatchIndexAscending = null, Expression<Func<bool>> jABDoesElementExistcaseSensitiveSearch = null, Expression<Func<bool>> jABDoesElementExistonlySearchVisibleElements = null, Expression<Func<bool>> jABDoesElementExistonlySearchShowingElements = null, Expression<Func<string>> jABDoesElementExistelementRolesNotToTraverse = null, Expression<Func<int>> jABDoesElementExistmaximumElementsToSearch = null, Expression<Func<int>> jABDoesElementExistmaximumChildElementsToSearchPerNode = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABDoesElementExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABDoesElementExist = new JObject();
            var jABDoesElementExistpropCount = 0;
            jABDoesElementExistpropCount++;
            jABDoesElementExist["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABDoesElementExistsearchParentElementJABHandle);
            if (jABDoesElementExistsearchElementJABName != null)
            {
                jABDoesElementExist["SearchElementJABName"] = ExpressionConverter.ConvertO(jABDoesElementExistsearchElementJABName);
                jABDoesElementExistpropCount++;
            }

            if (jABDoesElementExistsearchElementJABDescription != null)
            {
                jABDoesElementExist["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABDoesElementExistsearchElementJABDescription);
                jABDoesElementExistpropCount++;
            }

            if (jABDoesElementExistsearchElementJABRole != null)
            {
                jABDoesElementExist["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABDoesElementExistsearchElementJABRole);
                jABDoesElementExistpropCount++;
            }

            if (jABDoesElementExistsearchSubTree != null)
            {
                if (jABDoesElementExistsearchSubTree != null)
                {
                    jABDoesElementExist["SearchSubTree"] = ExpressionConverter.ConvertO(jABDoesElementExistsearchSubTree);
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
                    jABDoesElementExist["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABDoesElementExistmaxRelativeDepth);
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
                    jABDoesElementExist["MatchIndex"] = ExpressionConverter.ConvertO(jABDoesElementExistmatchIndex);
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
                jABDoesElementExist["SearchFilter"] = ExpressionConverter.ConvertO(jABDoesElementExistsearchFilter);
                jABDoesElementExistpropCount++;
            }

            if (jABDoesElementExistsortByColumn != null)
            {
                jABDoesElementExist["SortByColumn"] = ExpressionConverter.ConvertO(jABDoesElementExistsortByColumn);
                jABDoesElementExistpropCount++;
            }

            if (jABDoesElementExistmatchIndexAscending != null)
            {
                if (jABDoesElementExistmatchIndexAscending != null)
                {
                    jABDoesElementExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABDoesElementExistmatchIndexAscending);
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
                    jABDoesElementExist["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABDoesElementExistcaseSensitiveSearch);
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
                    jABDoesElementExist["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABDoesElementExistonlySearchVisibleElements);
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
                    jABDoesElementExist["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABDoesElementExistonlySearchShowingElements);
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
                jABDoesElementExist["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABDoesElementExistelementRolesNotToTraverse);
                jABDoesElementExistpropCount++;
            }

            if (jABDoesElementExistmaximumElementsToSearch != null)
            {
                if (jABDoesElementExistmaximumElementsToSearch != null)
                {
                    jABDoesElementExist["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABDoesElementExistmaximumElementsToSearch);
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
                    jABDoesElementExist["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABDoesElementExistmaximumChildElementsToSearchPerNode);
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
            jABDoesElementExist["Workflow"] = ExpressionConverter.ConvertO(jABDoesElementExistworkflow);
            if (jABDoesElementExistpropCount > 0)
            {
                callPayload.Body = jABDoesElementExist;
            }

            return new ApiConnectionAction<JABDoesElementExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABWaitForElementResponse> JABWaitForElement(Expression<Func<int>> jABWaitForElementsearchParentElementJABHandle, Expression<Func<double>> jABWaitForElementsecondsToWait, Expression<Func<string>> jABWaitForElementworkflow, Expression<Func<string>> jABWaitForElementsearchElementJABName = null, Expression<Func<string>> jABWaitForElementsearchElementJABDescription = null, Expression<Func<string>> jABWaitForElementsearchElementJABRole = null, Expression<Func<bool>> jABWaitForElementsearchSubTree = null, Expression<Func<int>> jABWaitForElementmaxRelativeDepth = null, Expression<Func<int>> jABWaitForElementmatchIndex = null, Expression<Func<string>> jABWaitForElementsearchFilter = null, Expression<Func<string>> jABWaitForElementsortByColumn = null, Expression<Func<bool>> jABWaitForElementmatchIndexAscending = null, Expression<Func<bool>> jABWaitForElementcaseSensitiveSearch = null, Expression<Func<bool>> jABWaitForElementonlySearchVisibleElements = null, Expression<Func<bool>> jABWaitForElementonlySearchShowingElements = null, Expression<Func<string>> jABWaitForElementelementRolesNotToTraverse = null, Expression<Func<int>> jABWaitForElementmaximumElementsToSearch = null, Expression<Func<int>> jABWaitForElementmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABWaitForElementraiseExceptionIfElementNotFound = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABWaitForElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABWaitForElement = new JObject();
            var jABWaitForElementpropCount = 0;
            jABWaitForElementpropCount++;
            jABWaitForElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABWaitForElementsearchParentElementJABHandle);
            if (jABWaitForElementsearchElementJABName != null)
            {
                jABWaitForElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABWaitForElementsearchElementJABName);
                jABWaitForElementpropCount++;
            }

            if (jABWaitForElementsearchElementJABDescription != null)
            {
                jABWaitForElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABWaitForElementsearchElementJABDescription);
                jABWaitForElementpropCount++;
            }

            if (jABWaitForElementsearchElementJABRole != null)
            {
                jABWaitForElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABWaitForElementsearchElementJABRole);
                jABWaitForElementpropCount++;
            }

            if (jABWaitForElementsearchSubTree != null)
            {
                if (jABWaitForElementsearchSubTree != null)
                {
                    jABWaitForElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABWaitForElementsearchSubTree);
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
                    jABWaitForElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABWaitForElementmaxRelativeDepth);
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
                    jABWaitForElement["MatchIndex"] = ExpressionConverter.ConvertO(jABWaitForElementmatchIndex);
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
                jABWaitForElement["SearchFilter"] = ExpressionConverter.ConvertO(jABWaitForElementsearchFilter);
                jABWaitForElementpropCount++;
            }

            if (jABWaitForElementsortByColumn != null)
            {
                jABWaitForElement["SortByColumn"] = ExpressionConverter.ConvertO(jABWaitForElementsortByColumn);
                jABWaitForElementpropCount++;
            }

            if (jABWaitForElementmatchIndexAscending != null)
            {
                if (jABWaitForElementmatchIndexAscending != null)
                {
                    jABWaitForElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABWaitForElementmatchIndexAscending);
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
                    jABWaitForElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABWaitForElementcaseSensitiveSearch);
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
                    jABWaitForElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABWaitForElementonlySearchVisibleElements);
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
                    jABWaitForElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABWaitForElementonlySearchShowingElements);
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
                jABWaitForElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABWaitForElementelementRolesNotToTraverse);
                jABWaitForElementpropCount++;
            }

            if (jABWaitForElementmaximumElementsToSearch != null)
            {
                if (jABWaitForElementmaximumElementsToSearch != null)
                {
                    jABWaitForElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABWaitForElementmaximumElementsToSearch);
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
                    jABWaitForElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABWaitForElementmaximumChildElementsToSearchPerNode);
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
            jABWaitForElement["SecondsToWait"] = ExpressionConverter.ConvertO(jABWaitForElementsecondsToWait);
            if (jABWaitForElementraiseExceptionIfElementNotFound != null)
            {
                if (jABWaitForElementraiseExceptionIfElementNotFound != null)
                {
                    jABWaitForElement["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(jABWaitForElementraiseExceptionIfElementNotFound);
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
            jABWaitForElement["Workflow"] = ExpressionConverter.ConvertO(jABWaitForElementworkflow);
            if (jABWaitForElementpropCount > 0)
            {
                callPayload.Body = jABWaitForElement;
            }

            return new ApiConnectionAction<JABWaitForElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABWaitForElementToNotExistResponse> JABWaitForElementToNotExist(Expression<Func<int>> jABWaitForElementToNotExistsearchParentElementJABHandle, Expression<Func<double>> jABWaitForElementToNotExistsecondsToWait, Expression<Func<string>> jABWaitForElementToNotExistworkflow, Expression<Func<string>> jABWaitForElementToNotExistsearchElementJABName = null, Expression<Func<string>> jABWaitForElementToNotExistsearchElementJABDescription = null, Expression<Func<string>> jABWaitForElementToNotExistsearchElementJABRole = null, Expression<Func<bool>> jABWaitForElementToNotExistsearchSubTree = null, Expression<Func<int>> jABWaitForElementToNotExistmaxRelativeDepth = null, Expression<Func<int>> jABWaitForElementToNotExistmatchIndex = null, Expression<Func<string>> jABWaitForElementToNotExistsearchFilter = null, Expression<Func<string>> jABWaitForElementToNotExistsortByColumn = null, Expression<Func<bool>> jABWaitForElementToNotExistmatchIndexAscending = null, Expression<Func<bool>> jABWaitForElementToNotExistcaseSensitiveSearch = null, Expression<Func<bool>> jABWaitForElementToNotExistonlySearchVisibleElements = null, Expression<Func<bool>> jABWaitForElementToNotExistonlySearchShowingElements = null, Expression<Func<string>> jABWaitForElementToNotExistelementRolesNotToTraverse = null, Expression<Func<int>> jABWaitForElementToNotExistmaximumElementsToSearch = null, Expression<Func<int>> jABWaitForElementToNotExistmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABWaitForElementToNotExistraiseExceptionIfElementStillExists = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABWaitForElementToNotExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABWaitForElementToNotExist = new JObject();
            var jABWaitForElementToNotExistpropCount = 0;
            jABWaitForElementToNotExistpropCount++;
            jABWaitForElementToNotExist["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistsearchParentElementJABHandle);
            if (jABWaitForElementToNotExistsearchElementJABName != null)
            {
                jABWaitForElementToNotExist["SearchElementJABName"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistsearchElementJABName);
                jABWaitForElementToNotExistpropCount++;
            }

            if (jABWaitForElementToNotExistsearchElementJABDescription != null)
            {
                jABWaitForElementToNotExist["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistsearchElementJABDescription);
                jABWaitForElementToNotExistpropCount++;
            }

            if (jABWaitForElementToNotExistsearchElementJABRole != null)
            {
                jABWaitForElementToNotExist["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistsearchElementJABRole);
                jABWaitForElementToNotExistpropCount++;
            }

            if (jABWaitForElementToNotExistsearchSubTree != null)
            {
                if (jABWaitForElementToNotExistsearchSubTree != null)
                {
                    jABWaitForElementToNotExist["SearchSubTree"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistsearchSubTree);
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
                    jABWaitForElementToNotExist["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistmaxRelativeDepth);
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
                    jABWaitForElementToNotExist["MatchIndex"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistmatchIndex);
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
                jABWaitForElementToNotExist["SearchFilter"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistsearchFilter);
                jABWaitForElementToNotExistpropCount++;
            }

            if (jABWaitForElementToNotExistsortByColumn != null)
            {
                jABWaitForElementToNotExist["SortByColumn"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistsortByColumn);
                jABWaitForElementToNotExistpropCount++;
            }

            if (jABWaitForElementToNotExistmatchIndexAscending != null)
            {
                if (jABWaitForElementToNotExistmatchIndexAscending != null)
                {
                    jABWaitForElementToNotExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistmatchIndexAscending);
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
                    jABWaitForElementToNotExist["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistcaseSensitiveSearch);
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
                    jABWaitForElementToNotExist["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistonlySearchVisibleElements);
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
                    jABWaitForElementToNotExist["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistonlySearchShowingElements);
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
                jABWaitForElementToNotExist["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistelementRolesNotToTraverse);
                jABWaitForElementToNotExistpropCount++;
            }

            if (jABWaitForElementToNotExistmaximumElementsToSearch != null)
            {
                if (jABWaitForElementToNotExistmaximumElementsToSearch != null)
                {
                    jABWaitForElementToNotExist["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistmaximumElementsToSearch);
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
                    jABWaitForElementToNotExist["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistmaximumChildElementsToSearchPerNode);
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
            jABWaitForElementToNotExist["SecondsToWait"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistsecondsToWait);
            if (jABWaitForElementToNotExistraiseExceptionIfElementStillExists != null)
            {
                if (jABWaitForElementToNotExistraiseExceptionIfElementStillExists != null)
                {
                    jABWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistraiseExceptionIfElementStillExists);
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
            jABWaitForElementToNotExist["Workflow"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistworkflow);
            if (jABWaitForElementToNotExistpropCount > 0)
            {
                callPayload.Body = jABWaitForElementToNotExist;
            }

            return new ApiConnectionAction<JABWaitForElementToNotExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetDesktopElementsResponse> JABGetDesktopElements(Expression<Func<string>> jABGetDesktopElementsworkflow, Expression<Func<string>> jABGetDesktopElementssearchElementLocalizedControlType = null, Expression<Func<int>> jABGetDesktopElementssearchProcessID = null, Expression<Func<int>> jABGetDesktopElementsfirstItemToReturn = null, Expression<Func<int>> jABGetDesktopElementsmaxItemsToReturn = null, Expression<Func<bool>> jABGetDesktopElementssearchChildElements = null, Expression<Func<int>> jABGetDesktopElementsmaxStringLength = null, Expression<Func<bool>> jABGetDesktopElementsincludeChildProcesses = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetDesktopElements";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetDesktopElements = new JObject();
            var jABGetDesktopElementspropCount = 0;
            if (jABGetDesktopElementssearchElementLocalizedControlType != null)
            {
                jABGetDesktopElements["SearchElementLocalizedControlType"] = ExpressionConverter.ConvertO(jABGetDesktopElementssearchElementLocalizedControlType);
                jABGetDesktopElementspropCount++;
            }

            if (jABGetDesktopElementssearchProcessID != null)
            {
                if (jABGetDesktopElementssearchProcessID != null)
                {
                    jABGetDesktopElements["SearchProcessID"] = ExpressionConverter.ConvertO(jABGetDesktopElementssearchProcessID);
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
                    jABGetDesktopElements["FirstItemToReturn"] = ExpressionConverter.ConvertO(jABGetDesktopElementsfirstItemToReturn);
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
                    jABGetDesktopElements["MaxItemsToReturn"] = ExpressionConverter.ConvertO(jABGetDesktopElementsmaxItemsToReturn);
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
                    jABGetDesktopElements["SearchChildElements"] = ExpressionConverter.ConvertO(jABGetDesktopElementssearchChildElements);
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
                    jABGetDesktopElements["MaxStringLength"] = ExpressionConverter.ConvertO(jABGetDesktopElementsmaxStringLength);
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
                    jABGetDesktopElements["IncludeChildProcesses"] = ExpressionConverter.ConvertO(jABGetDesktopElementsincludeChildProcesses);
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
            jABGetDesktopElements["Workflow"] = ExpressionConverter.ConvertO(jABGetDesktopElementsworkflow);
            if (jABGetDesktopElementspropCount > 0)
            {
                callPayload.Body = jABGetDesktopElements;
            }

            return new ApiConnectionAction<JABGetDesktopElementsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABDoesDesktopElementExistResponse> JABDoesDesktopElementExist(Expression<Func<string>> jABDoesDesktopElementExistworkflow, Expression<Func<string>> jABDoesDesktopElementExistsearchUIAElementName = null, Expression<Func<string>> jABDoesDesktopElementExistsearchUIAElementClassName = null, Expression<Func<string>> jABDoesDesktopElementExistsearchUIAElementLocalizedControlType = null, Expression<Func<int>> jABDoesDesktopElementExistsearchProcessID = null, Expression<Func<bool>> jABDoesDesktopElementExistsearchChildElements = null, Expression<Func<int>> jABDoesDesktopElementExistmatchIndex = null, Expression<Func<string>> jABDoesDesktopElementExistsearchFilter = null, Expression<Func<string>> jABDoesDesktopElementExistsortByColumn = null, Expression<Func<bool>> jABDoesDesktopElementExistmatchIndexAscending = null, Expression<Func<bool>> jABDoesDesktopElementExistincludeChildProcesses = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABDoesDesktopElementExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABDoesDesktopElementExist = new JObject();
            var jABDoesDesktopElementExistpropCount = 0;
            if (jABDoesDesktopElementExistsearchUIAElementName != null)
            {
                jABDoesDesktopElementExist["SearchUIAElementName"] = ExpressionConverter.ConvertO(jABDoesDesktopElementExistsearchUIAElementName);
                jABDoesDesktopElementExistpropCount++;
            }

            if (jABDoesDesktopElementExistsearchUIAElementClassName != null)
            {
                jABDoesDesktopElementExist["SearchUIAElementClassName"] = ExpressionConverter.ConvertO(jABDoesDesktopElementExistsearchUIAElementClassName);
                jABDoesDesktopElementExistpropCount++;
            }

            if (jABDoesDesktopElementExistsearchUIAElementLocalizedControlType != null)
            {
                jABDoesDesktopElementExist["SearchUIAElementLocalizedControlType"] = ExpressionConverter.ConvertO(jABDoesDesktopElementExistsearchUIAElementLocalizedControlType);
                jABDoesDesktopElementExistpropCount++;
            }

            if (jABDoesDesktopElementExistsearchProcessID != null)
            {
                if (jABDoesDesktopElementExistsearchProcessID != null)
                {
                    jABDoesDesktopElementExist["SearchProcessID"] = ExpressionConverter.ConvertO(jABDoesDesktopElementExistsearchProcessID);
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
                    jABDoesDesktopElementExist["SearchChildElements"] = ExpressionConverter.ConvertO(jABDoesDesktopElementExistsearchChildElements);
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
                    jABDoesDesktopElementExist["MatchIndex"] = ExpressionConverter.ConvertO(jABDoesDesktopElementExistmatchIndex);
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
                jABDoesDesktopElementExist["SearchFilter"] = ExpressionConverter.ConvertO(jABDoesDesktopElementExistsearchFilter);
                jABDoesDesktopElementExistpropCount++;
            }

            if (jABDoesDesktopElementExistsortByColumn != null)
            {
                jABDoesDesktopElementExist["SortByColumn"] = ExpressionConverter.ConvertO(jABDoesDesktopElementExistsortByColumn);
                jABDoesDesktopElementExistpropCount++;
            }

            if (jABDoesDesktopElementExistmatchIndexAscending != null)
            {
                if (jABDoesDesktopElementExistmatchIndexAscending != null)
                {
                    jABDoesDesktopElementExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABDoesDesktopElementExistmatchIndexAscending);
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
                    jABDoesDesktopElementExist["IncludeChildProcesses"] = ExpressionConverter.ConvertO(jABDoesDesktopElementExistincludeChildProcesses);
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
            jABDoesDesktopElementExist["Workflow"] = ExpressionConverter.ConvertO(jABDoesDesktopElementExistworkflow);
            if (jABDoesDesktopElementExistpropCount > 0)
            {
                callPayload.Body = jABDoesDesktopElementExist;
            }

            return new ApiConnectionAction<JABDoesDesktopElementExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABWaitForDesktopElementResponse> JABWaitForDesktopElement(Expression<Func<double>> jABWaitForDesktopElementsecondsToWait, Expression<Func<string>> jABWaitForDesktopElementworkflow, Expression<Func<string>> jABWaitForDesktopElementsearchUIAElementName = null, Expression<Func<string>> jABWaitForDesktopElementsearchUIAElementClassName = null, Expression<Func<string>> jABWaitForDesktopElementsearchUIAElementLocalizedControlType = null, Expression<Func<int>> jABWaitForDesktopElementsearchProcessID = null, Expression<Func<bool>> jABWaitForDesktopElementsearchChildElements = null, Expression<Func<int>> jABWaitForDesktopElementmatchIndex = null, Expression<Func<string>> jABWaitForDesktopElementsearchFilter = null, Expression<Func<string>> jABWaitForDesktopElementsortByColumn = null, Expression<Func<bool>> jABWaitForDesktopElementmatchIndexAscending = null, Expression<Func<bool>> jABWaitForDesktopElementincludeChildProcesses = null, Expression<Func<bool>> jABWaitForDesktopElementraiseExceptionIfElementNotFound = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABWaitForDesktopElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABWaitForDesktopElement = new JObject();
            var jABWaitForDesktopElementpropCount = 0;
            if (jABWaitForDesktopElementsearchUIAElementName != null)
            {
                jABWaitForDesktopElement["SearchUIAElementName"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementsearchUIAElementName);
                jABWaitForDesktopElementpropCount++;
            }

            if (jABWaitForDesktopElementsearchUIAElementClassName != null)
            {
                jABWaitForDesktopElement["SearchUIAElementClassName"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementsearchUIAElementClassName);
                jABWaitForDesktopElementpropCount++;
            }

            if (jABWaitForDesktopElementsearchUIAElementLocalizedControlType != null)
            {
                jABWaitForDesktopElement["SearchUIAElementLocalizedControlType"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementsearchUIAElementLocalizedControlType);
                jABWaitForDesktopElementpropCount++;
            }

            if (jABWaitForDesktopElementsearchProcessID != null)
            {
                if (jABWaitForDesktopElementsearchProcessID != null)
                {
                    jABWaitForDesktopElement["SearchProcessID"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementsearchProcessID);
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
                    jABWaitForDesktopElement["SearchChildElements"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementsearchChildElements);
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
                    jABWaitForDesktopElement["MatchIndex"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementmatchIndex);
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
                jABWaitForDesktopElement["SearchFilter"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementsearchFilter);
                jABWaitForDesktopElementpropCount++;
            }

            if (jABWaitForDesktopElementsortByColumn != null)
            {
                jABWaitForDesktopElement["SortByColumn"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementsortByColumn);
                jABWaitForDesktopElementpropCount++;
            }

            if (jABWaitForDesktopElementmatchIndexAscending != null)
            {
                if (jABWaitForDesktopElementmatchIndexAscending != null)
                {
                    jABWaitForDesktopElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementmatchIndexAscending);
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
            jABWaitForDesktopElement["SecondsToWait"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementsecondsToWait);
            if (jABWaitForDesktopElementincludeChildProcesses != null)
            {
                if (jABWaitForDesktopElementincludeChildProcesses != null)
                {
                    jABWaitForDesktopElement["IncludeChildProcesses"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementincludeChildProcesses);
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
                    jABWaitForDesktopElement["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementraiseExceptionIfElementNotFound);
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
            jABWaitForDesktopElement["Workflow"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementworkflow);
            if (jABWaitForDesktopElementpropCount > 0)
            {
                callPayload.Body = jABWaitForDesktopElement;
            }

            return new ApiConnectionAction<JABWaitForDesktopElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABWaitForDesktopElementToNotExistResponse> JABWaitForDesktopElementToNotExist(Expression<Func<double>> jABWaitForDesktopElementToNotExistsecondsToWait, Expression<Func<string>> jABWaitForDesktopElementToNotExistworkflow, Expression<Func<string>> jABWaitForDesktopElementToNotExistsearchUIAElementName = null, Expression<Func<string>> jABWaitForDesktopElementToNotExistsearchUIAElementClassName = null, Expression<Func<string>> jABWaitForDesktopElementToNotExistsearchUIAElementLocalizedControlType = null, Expression<Func<int>> jABWaitForDesktopElementToNotExistsearchProcessID = null, Expression<Func<bool>> jABWaitForDesktopElementToNotExistsearchChildElements = null, Expression<Func<int>> jABWaitForDesktopElementToNotExistmatchIndex = null, Expression<Func<string>> jABWaitForDesktopElementToNotExistsearchFilter = null, Expression<Func<string>> jABWaitForDesktopElementToNotExistsortByColumn = null, Expression<Func<bool>> jABWaitForDesktopElementToNotExistmatchIndexAscending = null, Expression<Func<bool>> jABWaitForDesktopElementToNotExistincludeChildProcesses = null, Expression<Func<bool>> jABWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABWaitForDesktopElementToNotExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABWaitForDesktopElementToNotExist = new JObject();
            var jABWaitForDesktopElementToNotExistpropCount = 0;
            if (jABWaitForDesktopElementToNotExistsearchUIAElementName != null)
            {
                jABWaitForDesktopElementToNotExist["SearchUIAElementName"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistsearchUIAElementName);
                jABWaitForDesktopElementToNotExistpropCount++;
            }

            if (jABWaitForDesktopElementToNotExistsearchUIAElementClassName != null)
            {
                jABWaitForDesktopElementToNotExist["SearchUIAElementClassName"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistsearchUIAElementClassName);
                jABWaitForDesktopElementToNotExistpropCount++;
            }

            if (jABWaitForDesktopElementToNotExistsearchUIAElementLocalizedControlType != null)
            {
                jABWaitForDesktopElementToNotExist["SearchUIAElementLocalizedControlType"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistsearchUIAElementLocalizedControlType);
                jABWaitForDesktopElementToNotExistpropCount++;
            }

            if (jABWaitForDesktopElementToNotExistsearchProcessID != null)
            {
                if (jABWaitForDesktopElementToNotExistsearchProcessID != null)
                {
                    jABWaitForDesktopElementToNotExist["SearchProcessID"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistsearchProcessID);
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
                    jABWaitForDesktopElementToNotExist["SearchChildElements"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistsearchChildElements);
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
                    jABWaitForDesktopElementToNotExist["MatchIndex"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistmatchIndex);
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
                jABWaitForDesktopElementToNotExist["SearchFilter"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistsearchFilter);
                jABWaitForDesktopElementToNotExistpropCount++;
            }

            if (jABWaitForDesktopElementToNotExistsortByColumn != null)
            {
                jABWaitForDesktopElementToNotExist["SortByColumn"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistsortByColumn);
                jABWaitForDesktopElementToNotExistpropCount++;
            }

            if (jABWaitForDesktopElementToNotExistmatchIndexAscending != null)
            {
                if (jABWaitForDesktopElementToNotExistmatchIndexAscending != null)
                {
                    jABWaitForDesktopElementToNotExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistmatchIndexAscending);
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
            jABWaitForDesktopElementToNotExist["SecondsToWait"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistsecondsToWait);
            if (jABWaitForDesktopElementToNotExistincludeChildProcesses != null)
            {
                if (jABWaitForDesktopElementToNotExistincludeChildProcesses != null)
                {
                    jABWaitForDesktopElementToNotExist["IncludeChildProcesses"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistincludeChildProcesses);
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
                    jABWaitForDesktopElementToNotExist["RaiseExceptionIfElementStillExists"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists);
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
            jABWaitForDesktopElementToNotExist["Workflow"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistworkflow);
            if (jABWaitForDesktopElementToNotExistpropCount > 0)
            {
                callPayload.Body = jABWaitForDesktopElementToNotExist;
            }

            return new ApiConnectionAction<JABWaitForDesktopElementToNotExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABFreeAllJABHandles(Expression<Func<string>> jABFreeAllJABHandlesworkflow)
        {
            var apiCallPath = "/JavaAccessBridge/JABFreeAllJABHandles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABFreeAllJABHandles = new JObject();
            var jABFreeAllJABHandlespropCount = 0;
            jABFreeAllJABHandlespropCount++;
            jABFreeAllJABHandles["Workflow"] = ExpressionConverter.ConvertO(jABFreeAllJABHandlesworkflow);
            if (jABFreeAllJABHandlespropCount > 0)
            {
                callPayload.Body = jABFreeAllJABHandles;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetChildJABElementPropertiesResponse> JABGetChildJABElementProperties(Expression<Func<int>> jABGetChildJABElementPropertiessearchElementJABHandle, Expression<Func<int>> jABGetChildJABElementPropertiessearchChildIndex, Expression<Func<string>> jABGetChildJABElementPropertiesworkflow, Expression<Func<int>> jABGetChildJABElementPropertiesmaxStringLength = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetChildJABElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetChildJABElementProperties = new JObject();
            var jABGetChildJABElementPropertiespropCount = 0;
            jABGetChildJABElementPropertiespropCount++;
            jABGetChildJABElementProperties["SearchElementJABHandle"] = ExpressionConverter.ConvertO(jABGetChildJABElementPropertiessearchElementJABHandle);
            jABGetChildJABElementPropertiespropCount++;
            jABGetChildJABElementProperties["SearchChildIndex"] = ExpressionConverter.ConvertO(jABGetChildJABElementPropertiessearchChildIndex);
            if (jABGetChildJABElementPropertiesmaxStringLength != null)
            {
                if (jABGetChildJABElementPropertiesmaxStringLength != null)
                {
                    jABGetChildJABElementProperties["MaxStringLength"] = ExpressionConverter.ConvertO(jABGetChildJABElementPropertiesmaxStringLength);
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
            jABGetChildJABElementProperties["Workflow"] = ExpressionConverter.ConvertO(jABGetChildJABElementPropertiesworkflow);
            if (jABGetChildJABElementPropertiespropCount > 0)
            {
                callPayload.Body = jABGetChildJABElementProperties;
            }

            return new ApiConnectionAction<JABGetChildJABElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetAllChildJABElementPropertiesResponse> JABGetAllChildJABElementProperties(Expression<Func<int>> jABGetAllChildJABElementPropertiessearchElementJABHandle, Expression<Func<string>> jABGetAllChildJABElementPropertiesworkflow, Expression<Func<int>> jABGetAllChildJABElementPropertiesfirstItemToReturn = null, Expression<Func<int>> jABGetAllChildJABElementPropertiesmaxItemsToReturn = null, Expression<Func<int>> jABGetAllChildJABElementPropertiesmaxStringLength = null, Expression<Func<bool>> jABGetAllChildJABElementPropertiessearchDescendants = null, Expression<Func<string>> jABGetAllChildJABElementPropertiessearchRole = null, Expression<Func<int>> jABGetAllChildJABElementPropertiesmaxRelativeDepth = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetAllChildJABElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetAllChildJABElementProperties = new JObject();
            var jABGetAllChildJABElementPropertiespropCount = 0;
            jABGetAllChildJABElementPropertiespropCount++;
            jABGetAllChildJABElementProperties["SearchElementJABHandle"] = ExpressionConverter.ConvertO(jABGetAllChildJABElementPropertiessearchElementJABHandle);
            if (jABGetAllChildJABElementPropertiesfirstItemToReturn != null)
            {
                if (jABGetAllChildJABElementPropertiesfirstItemToReturn != null)
                {
                    jABGetAllChildJABElementProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(jABGetAllChildJABElementPropertiesfirstItemToReturn);
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
                    jABGetAllChildJABElementProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(jABGetAllChildJABElementPropertiesmaxItemsToReturn);
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
                    jABGetAllChildJABElementProperties["MaxStringLength"] = ExpressionConverter.ConvertO(jABGetAllChildJABElementPropertiesmaxStringLength);
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
                    jABGetAllChildJABElementProperties["SearchDescendants"] = ExpressionConverter.ConvertO(jABGetAllChildJABElementPropertiessearchDescendants);
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
                jABGetAllChildJABElementProperties["SearchRole"] = ExpressionConverter.ConvertO(jABGetAllChildJABElementPropertiessearchRole);
                jABGetAllChildJABElementPropertiespropCount++;
            }

            if (jABGetAllChildJABElementPropertiesmaxRelativeDepth != null)
            {
                if (jABGetAllChildJABElementPropertiesmaxRelativeDepth != null)
                {
                    jABGetAllChildJABElementProperties["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetAllChildJABElementPropertiesmaxRelativeDepth);
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
            jABGetAllChildJABElementProperties["Workflow"] = ExpressionConverter.ConvertO(jABGetAllChildJABElementPropertiesworkflow);
            if (jABGetAllChildJABElementPropertiespropCount > 0)
            {
                callPayload.Body = jABGetAllChildJABElementProperties;
            }

            return new ApiConnectionAction<JABGetAllChildJABElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetParentJABElementPropertiesResponse> JABGetParentJABElementProperties(Expression<Func<int>> jABGetParentJABElementPropertiessearchElementJABHandle, Expression<Func<string>> jABGetParentJABElementPropertiesworkflow, Expression<Func<int>> jABGetParentJABElementPropertiesmaxStringLength = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetParentJABElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetParentJABElementProperties = new JObject();
            var jABGetParentJABElementPropertiespropCount = 0;
            jABGetParentJABElementPropertiespropCount++;
            jABGetParentJABElementProperties["SearchElementJABHandle"] = ExpressionConverter.ConvertO(jABGetParentJABElementPropertiessearchElementJABHandle);
            if (jABGetParentJABElementPropertiesmaxStringLength != null)
            {
                if (jABGetParentJABElementPropertiesmaxStringLength != null)
                {
                    jABGetParentJABElementProperties["MaxStringLength"] = ExpressionConverter.ConvertO(jABGetParentJABElementPropertiesmaxStringLength);
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
            jABGetParentJABElementProperties["Workflow"] = ExpressionConverter.ConvertO(jABGetParentJABElementPropertiesworkflow);
            if (jABGetParentJABElementPropertiespropCount > 0)
            {
                callPayload.Body = jABGetParentJABElementProperties;
            }

            return new ApiConnectionAction<JABGetParentJABElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABPressElement(Expression<Func<int>> jABPressElementsearchParentElementJABHandle, Expression<Func<string>> jABPressElementworkflow, Expression<Func<string>> jABPressElementsearchElementJABName = null, Expression<Func<string>> jABPressElementsearchElementJABDescription = null, Expression<Func<string>> jABPressElementsearchElementJABRole = null, Expression<Func<bool>> jABPressElementsearchSubTree = null, Expression<Func<int>> jABPressElementmaxRelativeDepth = null, Expression<Func<int>> jABPressElementmatchIndex = null, Expression<Func<string>> jABPressElementsearchFilter = null, Expression<Func<string>> jABPressElementsortByColumn = null, Expression<Func<bool>> jABPressElementmatchIndexAscending = null, Expression<Func<bool>> jABPressElementcaseSensitiveSearch = null, Expression<Func<bool>> jABPressElementonlySearchVisibleElements = null, Expression<Func<bool>> jABPressElementonlySearchShowingElements = null, Expression<Func<string>> jABPressElementelementRolesNotToTraverse = null, Expression<Func<int>> jABPressElementmaximumElementsToSearch = null, Expression<Func<int>> jABPressElementmaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABPressElementnumberOfTimesToPressElement = null, Expression<Func<double>> jABPressElementsecondsToWaitBetweenPresses = null, Expression<Func<bool>> jABPressElementautoDetectActionName = null, Expression<Func<string>> jABPressElementoverrideActionName = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABPressElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABPressElement = new JObject();
            var jABPressElementpropCount = 0;
            jABPressElementpropCount++;
            jABPressElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABPressElementsearchParentElementJABHandle);
            if (jABPressElementsearchElementJABName != null)
            {
                jABPressElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABPressElementsearchElementJABName);
                jABPressElementpropCount++;
            }

            if (jABPressElementsearchElementJABDescription != null)
            {
                jABPressElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABPressElementsearchElementJABDescription);
                jABPressElementpropCount++;
            }

            if (jABPressElementsearchElementJABRole != null)
            {
                jABPressElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABPressElementsearchElementJABRole);
                jABPressElementpropCount++;
            }

            if (jABPressElementsearchSubTree != null)
            {
                if (jABPressElementsearchSubTree != null)
                {
                    jABPressElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABPressElementsearchSubTree);
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
                    jABPressElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABPressElementmaxRelativeDepth);
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
                    jABPressElement["MatchIndex"] = ExpressionConverter.ConvertO(jABPressElementmatchIndex);
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
                jABPressElement["SearchFilter"] = ExpressionConverter.ConvertO(jABPressElementsearchFilter);
                jABPressElementpropCount++;
            }

            if (jABPressElementsortByColumn != null)
            {
                jABPressElement["SortByColumn"] = ExpressionConverter.ConvertO(jABPressElementsortByColumn);
                jABPressElementpropCount++;
            }

            if (jABPressElementmatchIndexAscending != null)
            {
                if (jABPressElementmatchIndexAscending != null)
                {
                    jABPressElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABPressElementmatchIndexAscending);
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
                    jABPressElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABPressElementcaseSensitiveSearch);
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
                    jABPressElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABPressElementonlySearchVisibleElements);
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
                    jABPressElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABPressElementonlySearchShowingElements);
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
                jABPressElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABPressElementelementRolesNotToTraverse);
                jABPressElementpropCount++;
            }

            if (jABPressElementmaximumElementsToSearch != null)
            {
                if (jABPressElementmaximumElementsToSearch != null)
                {
                    jABPressElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABPressElementmaximumElementsToSearch);
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
                    jABPressElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABPressElementmaximumChildElementsToSearchPerNode);
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
                    jABPressElement["NumberOfTimesToPressElement"] = ExpressionConverter.ConvertO(jABPressElementnumberOfTimesToPressElement);
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
                    jABPressElement["SecondsToWaitBetweenPresses"] = ExpressionConverter.ConvertO(jABPressElementsecondsToWaitBetweenPresses);
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
                    jABPressElement["AutoDetectActionName"] = ExpressionConverter.ConvertO(jABPressElementautoDetectActionName);
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
                jABPressElement["OverrideActionName"] = ExpressionConverter.ConvertO(jABPressElementoverrideActionName);
                jABPressElementpropCount++;
            }

            jABPressElementpropCount++;
            jABPressElement["Workflow"] = ExpressionConverter.ConvertO(jABPressElementworkflow);
            if (jABPressElementpropCount > 0)
            {
                callPayload.Body = jABPressElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABPerformActionOnElement(Expression<Func<int>> jABPerformActionOnElementsearchParentElementJABHandle, Expression<Func<string>> jABPerformActionOnElementaction, Expression<Func<string>> jABPerformActionOnElementworkflow, Expression<Func<string>> jABPerformActionOnElementsearchElementJABName = null, Expression<Func<string>> jABPerformActionOnElementsearchElementJABDescription = null, Expression<Func<string>> jABPerformActionOnElementsearchElementJABRole = null, Expression<Func<bool>> jABPerformActionOnElementsearchSubTree = null, Expression<Func<int>> jABPerformActionOnElementmaxRelativeDepth = null, Expression<Func<int>> jABPerformActionOnElementmatchIndex = null, Expression<Func<string>> jABPerformActionOnElementsearchFilter = null, Expression<Func<string>> jABPerformActionOnElementsortByColumn = null, Expression<Func<bool>> jABPerformActionOnElementmatchIndexAscending = null, Expression<Func<bool>> jABPerformActionOnElementcaseSensitiveSearch = null, Expression<Func<bool>> jABPerformActionOnElementonlySearchVisibleElements = null, Expression<Func<bool>> jABPerformActionOnElementonlySearchShowingElements = null, Expression<Func<string>> jABPerformActionOnElementelementRolesNotToTraverse = null, Expression<Func<int>> jABPerformActionOnElementmaximumElementsToSearch = null, Expression<Func<int>> jABPerformActionOnElementmaximumChildElementsToSearchPerNode = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABPerformActionOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABPerformActionOnElement = new JObject();
            var jABPerformActionOnElementpropCount = 0;
            jABPerformActionOnElementpropCount++;
            jABPerformActionOnElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABPerformActionOnElementsearchParentElementJABHandle);
            if (jABPerformActionOnElementsearchElementJABName != null)
            {
                jABPerformActionOnElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABPerformActionOnElementsearchElementJABName);
                jABPerformActionOnElementpropCount++;
            }

            if (jABPerformActionOnElementsearchElementJABDescription != null)
            {
                jABPerformActionOnElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABPerformActionOnElementsearchElementJABDescription);
                jABPerformActionOnElementpropCount++;
            }

            if (jABPerformActionOnElementsearchElementJABRole != null)
            {
                jABPerformActionOnElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABPerformActionOnElementsearchElementJABRole);
                jABPerformActionOnElementpropCount++;
            }

            if (jABPerformActionOnElementsearchSubTree != null)
            {
                if (jABPerformActionOnElementsearchSubTree != null)
                {
                    jABPerformActionOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABPerformActionOnElementsearchSubTree);
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
                    jABPerformActionOnElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABPerformActionOnElementmaxRelativeDepth);
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
                    jABPerformActionOnElement["MatchIndex"] = ExpressionConverter.ConvertO(jABPerformActionOnElementmatchIndex);
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
                jABPerformActionOnElement["SearchFilter"] = ExpressionConverter.ConvertO(jABPerformActionOnElementsearchFilter);
                jABPerformActionOnElementpropCount++;
            }

            if (jABPerformActionOnElementsortByColumn != null)
            {
                jABPerformActionOnElement["SortByColumn"] = ExpressionConverter.ConvertO(jABPerformActionOnElementsortByColumn);
                jABPerformActionOnElementpropCount++;
            }

            if (jABPerformActionOnElementmatchIndexAscending != null)
            {
                if (jABPerformActionOnElementmatchIndexAscending != null)
                {
                    jABPerformActionOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABPerformActionOnElementmatchIndexAscending);
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
                    jABPerformActionOnElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABPerformActionOnElementcaseSensitiveSearch);
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
                    jABPerformActionOnElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABPerformActionOnElementonlySearchVisibleElements);
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
                    jABPerformActionOnElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABPerformActionOnElementonlySearchShowingElements);
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
                jABPerformActionOnElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABPerformActionOnElementelementRolesNotToTraverse);
                jABPerformActionOnElementpropCount++;
            }

            if (jABPerformActionOnElementmaximumElementsToSearch != null)
            {
                if (jABPerformActionOnElementmaximumElementsToSearch != null)
                {
                    jABPerformActionOnElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABPerformActionOnElementmaximumElementsToSearch);
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
                    jABPerformActionOnElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABPerformActionOnElementmaximumChildElementsToSearchPerNode);
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
            jABPerformActionOnElement["Action"] = ExpressionConverter.ConvertO(jABPerformActionOnElementaction);
            jABPerformActionOnElementpropCount++;
            jABPerformActionOnElement["Workflow"] = ExpressionConverter.ConvertO(jABPerformActionOnElementworkflow);
            if (jABPerformActionOnElementpropCount > 0)
            {
                callPayload.Body = jABPerformActionOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalLeftMouseClickOnElement(Expression<Func<int>> jABGlobalLeftMouseClickOnElementsearchParentElementJABHandle, Expression<Func<string>> jABGlobalLeftMouseClickOnElementworkflow, Expression<Func<string>> jABGlobalLeftMouseClickOnElementsearchElementJABName = null, Expression<Func<string>> jABGlobalLeftMouseClickOnElementsearchElementJABDescription = null, Expression<Func<string>> jABGlobalLeftMouseClickOnElementsearchElementJABRole = null, Expression<Func<bool>> jABGlobalLeftMouseClickOnElementsearchSubTree = null, Expression<Func<int>> jABGlobalLeftMouseClickOnElementmaxRelativeDepth = null, Expression<Func<int>> jABGlobalLeftMouseClickOnElementmatchIndex = null, Expression<Func<string>> jABGlobalLeftMouseClickOnElementsearchFilter = null, Expression<Func<string>> jABGlobalLeftMouseClickOnElementsortByColumn = null, Expression<Func<bool>> jABGlobalLeftMouseClickOnElementmatchIndexAscending = null, Expression<Func<bool>> jABGlobalLeftMouseClickOnElementcaseSensitiveSearch = null, Expression<Func<bool>> jABGlobalLeftMouseClickOnElementonlySearchVisibleElements = null, Expression<Func<bool>> jABGlobalLeftMouseClickOnElementonlySearchShowingElements = null, Expression<Func<string>> jABGlobalLeftMouseClickOnElementelementRolesNotToTraverse = null, Expression<Func<int>> jABGlobalLeftMouseClickOnElementmaximumElementsToSearch = null, Expression<Func<int>> jABGlobalLeftMouseClickOnElementmaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABGlobalLeftMouseClickOnElementclickOffsetX = null, Expression<Func<int>> jABGlobalLeftMouseClickOnElementclickOffsetY = null, Expression<Func<jABGlobalLeftMouseClickOnElementoffsetRelativeToInput>> jABGlobalLeftMouseClickOnElementoffsetRelativeTo = null, Expression<Func<int>> jABGlobalLeftMouseClickOnElementnumberOfTimesToClickElement = null, Expression<Func<double>> jABGlobalLeftMouseClickOnElementsecondsToWaitBetweenClicks = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGlobalLeftMouseClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGlobalLeftMouseClickOnElement = new JObject();
            var jABGlobalLeftMouseClickOnElementpropCount = 0;
            jABGlobalLeftMouseClickOnElementpropCount++;
            jABGlobalLeftMouseClickOnElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementsearchParentElementJABHandle);
            if (jABGlobalLeftMouseClickOnElementsearchElementJABName != null)
            {
                jABGlobalLeftMouseClickOnElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementsearchElementJABName);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementsearchElementJABDescription != null)
            {
                jABGlobalLeftMouseClickOnElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementsearchElementJABDescription);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementsearchElementJABRole != null)
            {
                jABGlobalLeftMouseClickOnElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementsearchElementJABRole);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementsearchSubTree != null)
            {
                if (jABGlobalLeftMouseClickOnElementsearchSubTree != null)
                {
                    jABGlobalLeftMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementsearchSubTree);
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
                    jABGlobalLeftMouseClickOnElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementmaxRelativeDepth);
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
                    jABGlobalLeftMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementmatchIndex);
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
                jABGlobalLeftMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementsearchFilter);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementsortByColumn != null)
            {
                jABGlobalLeftMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementsortByColumn);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementmatchIndexAscending != null)
            {
                if (jABGlobalLeftMouseClickOnElementmatchIndexAscending != null)
                {
                    jABGlobalLeftMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementmatchIndexAscending);
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
                    jABGlobalLeftMouseClickOnElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementcaseSensitiveSearch);
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
                    jABGlobalLeftMouseClickOnElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementonlySearchVisibleElements);
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
                    jABGlobalLeftMouseClickOnElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementonlySearchShowingElements);
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
                jABGlobalLeftMouseClickOnElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementelementRolesNotToTraverse);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementmaximumElementsToSearch != null)
            {
                if (jABGlobalLeftMouseClickOnElementmaximumElementsToSearch != null)
                {
                    jABGlobalLeftMouseClickOnElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementmaximumElementsToSearch);
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
                    jABGlobalLeftMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementmaximumChildElementsToSearchPerNode);
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
                    jABGlobalLeftMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementclickOffsetX);
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
                    jABGlobalLeftMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementclickOffsetY);
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
                jABGlobalLeftMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementoffsetRelativeTo);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementnumberOfTimesToClickElement != null)
            {
                if (jABGlobalLeftMouseClickOnElementnumberOfTimesToClickElement != null)
                {
                    jABGlobalLeftMouseClickOnElement["NumberOfTimesToClickElement"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementnumberOfTimesToClickElement);
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
                    jABGlobalLeftMouseClickOnElement["SecondsToWaitBetweenClicks"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementsecondsToWaitBetweenClicks);
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
            jABGlobalLeftMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementworkflow);
            if (jABGlobalLeftMouseClickOnElementpropCount > 0)
            {
                callPayload.Body = jABGlobalLeftMouseClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalRightMouseClickOnElement(Expression<Func<int>> jABGlobalRightMouseClickOnElementsearchParentElementJABHandle, Expression<Func<string>> jABGlobalRightMouseClickOnElementworkflow, Expression<Func<string>> jABGlobalRightMouseClickOnElementsearchElementJABName = null, Expression<Func<string>> jABGlobalRightMouseClickOnElementsearchElementJABDescription = null, Expression<Func<string>> jABGlobalRightMouseClickOnElementsearchElementJABRole = null, Expression<Func<bool>> jABGlobalRightMouseClickOnElementsearchSubTree = null, Expression<Func<int>> jABGlobalRightMouseClickOnElementmaxRelativeDepth = null, Expression<Func<int>> jABGlobalRightMouseClickOnElementmatchIndex = null, Expression<Func<string>> jABGlobalRightMouseClickOnElementsearchFilter = null, Expression<Func<string>> jABGlobalRightMouseClickOnElementsortByColumn = null, Expression<Func<bool>> jABGlobalRightMouseClickOnElementmatchIndexAscending = null, Expression<Func<bool>> jABGlobalRightMouseClickOnElementcaseSensitiveSearch = null, Expression<Func<bool>> jABGlobalRightMouseClickOnElementonlySearchVisibleElements = null, Expression<Func<bool>> jABGlobalRightMouseClickOnElementonlySearchShowingElements = null, Expression<Func<string>> jABGlobalRightMouseClickOnElementelementRolesNotToTraverse = null, Expression<Func<int>> jABGlobalRightMouseClickOnElementmaximumElementsToSearch = null, Expression<Func<int>> jABGlobalRightMouseClickOnElementmaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABGlobalRightMouseClickOnElementclickOffsetX = null, Expression<Func<int>> jABGlobalRightMouseClickOnElementclickOffsetY = null, Expression<Func<jABGlobalRightMouseClickOnElementoffsetRelativeToInput>> jABGlobalRightMouseClickOnElementoffsetRelativeTo = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGlobalRightMouseClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGlobalRightMouseClickOnElement = new JObject();
            var jABGlobalRightMouseClickOnElementpropCount = 0;
            jABGlobalRightMouseClickOnElementpropCount++;
            jABGlobalRightMouseClickOnElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementsearchParentElementJABHandle);
            if (jABGlobalRightMouseClickOnElementsearchElementJABName != null)
            {
                jABGlobalRightMouseClickOnElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementsearchElementJABName);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementsearchElementJABDescription != null)
            {
                jABGlobalRightMouseClickOnElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementsearchElementJABDescription);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementsearchElementJABRole != null)
            {
                jABGlobalRightMouseClickOnElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementsearchElementJABRole);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementsearchSubTree != null)
            {
                if (jABGlobalRightMouseClickOnElementsearchSubTree != null)
                {
                    jABGlobalRightMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementsearchSubTree);
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
                    jABGlobalRightMouseClickOnElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementmaxRelativeDepth);
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
                    jABGlobalRightMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementmatchIndex);
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
                jABGlobalRightMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementsearchFilter);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementsortByColumn != null)
            {
                jABGlobalRightMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementsortByColumn);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementmatchIndexAscending != null)
            {
                if (jABGlobalRightMouseClickOnElementmatchIndexAscending != null)
                {
                    jABGlobalRightMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementmatchIndexAscending);
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
                    jABGlobalRightMouseClickOnElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementcaseSensitiveSearch);
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
                    jABGlobalRightMouseClickOnElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementonlySearchVisibleElements);
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
                    jABGlobalRightMouseClickOnElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementonlySearchShowingElements);
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
                jABGlobalRightMouseClickOnElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementelementRolesNotToTraverse);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementmaximumElementsToSearch != null)
            {
                if (jABGlobalRightMouseClickOnElementmaximumElementsToSearch != null)
                {
                    jABGlobalRightMouseClickOnElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementmaximumElementsToSearch);
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
                    jABGlobalRightMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementmaximumChildElementsToSearchPerNode);
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
                    jABGlobalRightMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementclickOffsetX);
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
                    jABGlobalRightMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementclickOffsetY);
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
                jABGlobalRightMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementoffsetRelativeTo);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            jABGlobalRightMouseClickOnElementpropCount++;
            jABGlobalRightMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementworkflow);
            if (jABGlobalRightMouseClickOnElementpropCount > 0)
            {
                callPayload.Body = jABGlobalRightMouseClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalMiddleMouseClickOnElement(Expression<Func<int>> jABGlobalMiddleMouseClickOnElementsearchParentElementJABHandle, Expression<Func<string>> jABGlobalMiddleMouseClickOnElementworkflow, Expression<Func<string>> jABGlobalMiddleMouseClickOnElementsearchElementJABName = null, Expression<Func<string>> jABGlobalMiddleMouseClickOnElementsearchElementJABDescription = null, Expression<Func<string>> jABGlobalMiddleMouseClickOnElementsearchElementJABRole = null, Expression<Func<bool>> jABGlobalMiddleMouseClickOnElementsearchSubTree = null, Expression<Func<int>> jABGlobalMiddleMouseClickOnElementmaxRelativeDepth = null, Expression<Func<int>> jABGlobalMiddleMouseClickOnElementmatchIndex = null, Expression<Func<string>> jABGlobalMiddleMouseClickOnElementsearchFilter = null, Expression<Func<string>> jABGlobalMiddleMouseClickOnElementsortByColumn = null, Expression<Func<bool>> jABGlobalMiddleMouseClickOnElementmatchIndexAscending = null, Expression<Func<bool>> jABGlobalMiddleMouseClickOnElementcaseSensitiveSearch = null, Expression<Func<bool>> jABGlobalMiddleMouseClickOnElementonlySearchVisibleElements = null, Expression<Func<bool>> jABGlobalMiddleMouseClickOnElementonlySearchShowingElements = null, Expression<Func<string>> jABGlobalMiddleMouseClickOnElementelementRolesNotToTraverse = null, Expression<Func<int>> jABGlobalMiddleMouseClickOnElementmaximumElementsToSearch = null, Expression<Func<int>> jABGlobalMiddleMouseClickOnElementmaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABGlobalMiddleMouseClickOnElementclickOffsetX = null, Expression<Func<int>> jABGlobalMiddleMouseClickOnElementclickOffsetY = null, Expression<Func<jABGlobalMiddleMouseClickOnElementoffsetRelativeToInput>> jABGlobalMiddleMouseClickOnElementoffsetRelativeTo = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGlobalMiddleMouseClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGlobalMiddleMouseClickOnElement = new JObject();
            var jABGlobalMiddleMouseClickOnElementpropCount = 0;
            jABGlobalMiddleMouseClickOnElementpropCount++;
            jABGlobalMiddleMouseClickOnElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementsearchParentElementJABHandle);
            if (jABGlobalMiddleMouseClickOnElementsearchElementJABName != null)
            {
                jABGlobalMiddleMouseClickOnElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementsearchElementJABName);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementsearchElementJABDescription != null)
            {
                jABGlobalMiddleMouseClickOnElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementsearchElementJABDescription);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementsearchElementJABRole != null)
            {
                jABGlobalMiddleMouseClickOnElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementsearchElementJABRole);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementsearchSubTree != null)
            {
                if (jABGlobalMiddleMouseClickOnElementsearchSubTree != null)
                {
                    jABGlobalMiddleMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementsearchSubTree);
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
                    jABGlobalMiddleMouseClickOnElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementmaxRelativeDepth);
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
                    jABGlobalMiddleMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementmatchIndex);
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
                jABGlobalMiddleMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementsearchFilter);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementsortByColumn != null)
            {
                jABGlobalMiddleMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementsortByColumn);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementmatchIndexAscending != null)
            {
                if (jABGlobalMiddleMouseClickOnElementmatchIndexAscending != null)
                {
                    jABGlobalMiddleMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementmatchIndexAscending);
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
                    jABGlobalMiddleMouseClickOnElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementcaseSensitiveSearch);
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
                    jABGlobalMiddleMouseClickOnElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementonlySearchVisibleElements);
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
                    jABGlobalMiddleMouseClickOnElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementonlySearchShowingElements);
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
                jABGlobalMiddleMouseClickOnElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementelementRolesNotToTraverse);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementmaximumElementsToSearch != null)
            {
                if (jABGlobalMiddleMouseClickOnElementmaximumElementsToSearch != null)
                {
                    jABGlobalMiddleMouseClickOnElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementmaximumElementsToSearch);
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
                    jABGlobalMiddleMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementmaximumChildElementsToSearchPerNode);
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
                    jABGlobalMiddleMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementclickOffsetX);
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
                    jABGlobalMiddleMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementclickOffsetY);
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
                jABGlobalMiddleMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementoffsetRelativeTo);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            jABGlobalMiddleMouseClickOnElementpropCount++;
            jABGlobalMiddleMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementworkflow);
            if (jABGlobalMiddleMouseClickOnElementpropCount > 0)
            {
                callPayload.Body = jABGlobalMiddleMouseClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalDoubleLeftMouseClickOnElement(Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementsearchParentElementJABHandle, Expression<Func<string>> jABGlobalDoubleLeftMouseClickOnElementworkflow, Expression<Func<string>> jABGlobalDoubleLeftMouseClickOnElementsearchElementJABName = null, Expression<Func<string>> jABGlobalDoubleLeftMouseClickOnElementsearchElementJABDescription = null, Expression<Func<string>> jABGlobalDoubleLeftMouseClickOnElementsearchElementJABRole = null, Expression<Func<bool>> jABGlobalDoubleLeftMouseClickOnElementsearchSubTree = null, Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementmaxRelativeDepth = null, Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementmatchIndex = null, Expression<Func<string>> jABGlobalDoubleLeftMouseClickOnElementsearchFilter = null, Expression<Func<string>> jABGlobalDoubleLeftMouseClickOnElementsortByColumn = null, Expression<Func<bool>> jABGlobalDoubleLeftMouseClickOnElementmatchIndexAscending = null, Expression<Func<bool>> jABGlobalDoubleLeftMouseClickOnElementcaseSensitiveSearch = null, Expression<Func<bool>> jABGlobalDoubleLeftMouseClickOnElementonlySearchVisibleElements = null, Expression<Func<bool>> jABGlobalDoubleLeftMouseClickOnElementonlySearchShowingElements = null, Expression<Func<string>> jABGlobalDoubleLeftMouseClickOnElementelementRolesNotToTraverse = null, Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementmaximumElementsToSearch = null, Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementmaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementclickOffsetX = null, Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementclickOffsetY = null, Expression<Func<jABGlobalDoubleLeftMouseClickOnElementoffsetRelativeToInput>> jABGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo = null, Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGlobalDoubleLeftMouseClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGlobalDoubleLeftMouseClickOnElement = new JObject();
            var jABGlobalDoubleLeftMouseClickOnElementpropCount = 0;
            jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            jABGlobalDoubleLeftMouseClickOnElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementsearchParentElementJABHandle);
            if (jABGlobalDoubleLeftMouseClickOnElementsearchElementJABName != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementsearchElementJABName);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementsearchElementJABDescription != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementsearchElementJABDescription);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementsearchElementJABRole != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementsearchElementJABRole);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementsearchSubTree != null)
            {
                if (jABGlobalDoubleLeftMouseClickOnElementsearchSubTree != null)
                {
                    jABGlobalDoubleLeftMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementsearchSubTree);
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
                    jABGlobalDoubleLeftMouseClickOnElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementmaxRelativeDepth);
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
                    jABGlobalDoubleLeftMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementmatchIndex);
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
                jABGlobalDoubleLeftMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementsearchFilter);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementsortByColumn != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementsortByColumn);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementmatchIndexAscending != null)
            {
                if (jABGlobalDoubleLeftMouseClickOnElementmatchIndexAscending != null)
                {
                    jABGlobalDoubleLeftMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementmatchIndexAscending);
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
                    jABGlobalDoubleLeftMouseClickOnElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementcaseSensitiveSearch);
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
                    jABGlobalDoubleLeftMouseClickOnElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementonlySearchVisibleElements);
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
                    jABGlobalDoubleLeftMouseClickOnElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementonlySearchShowingElements);
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
                jABGlobalDoubleLeftMouseClickOnElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementelementRolesNotToTraverse);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementmaximumElementsToSearch != null)
            {
                if (jABGlobalDoubleLeftMouseClickOnElementmaximumElementsToSearch != null)
                {
                    jABGlobalDoubleLeftMouseClickOnElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementmaximumElementsToSearch);
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
                    jABGlobalDoubleLeftMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementmaximumChildElementsToSearchPerNode);
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
                    jABGlobalDoubleLeftMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementclickOffsetX);
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
                    jABGlobalDoubleLeftMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementclickOffsetY);
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
                jABGlobalDoubleLeftMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds != null)
            {
                if (jABGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds != null)
                {
                    jABGlobalDoubleLeftMouseClickOnElement["DelayInMilliseconds"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds);
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
            jABGlobalDoubleLeftMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementworkflow);
            if (jABGlobalDoubleLeftMouseClickOnElementpropCount > 0)
            {
                callPayload.Body = jABGlobalDoubleLeftMouseClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetActionsForElementResponse> JABGetActionsForElement(Expression<Func<int>> jABGetActionsForElementsearchParentElementJABHandle, Expression<Func<string>> jABGetActionsForElementworkflow, Expression<Func<string>> jABGetActionsForElementsearchElementJABName = null, Expression<Func<string>> jABGetActionsForElementsearchElementJABDescription = null, Expression<Func<string>> jABGetActionsForElementsearchElementJABRole = null, Expression<Func<bool>> jABGetActionsForElementsearchSubTree = null, Expression<Func<int>> jABGetActionsForElementmaxRelativeDepth = null, Expression<Func<int>> jABGetActionsForElementmatchIndex = null, Expression<Func<string>> jABGetActionsForElementsearchFilter = null, Expression<Func<string>> jABGetActionsForElementsortByColumn = null, Expression<Func<bool>> jABGetActionsForElementmatchIndexAscending = null, Expression<Func<bool>> jABGetActionsForElementcaseSensitiveSearch = null, Expression<Func<bool>> jABGetActionsForElementonlySearchVisibleElements = null, Expression<Func<bool>> jABGetActionsForElementonlySearchShowingElements = null, Expression<Func<string>> jABGetActionsForElementelementRolesNotToTraverse = null, Expression<Func<int>> jABGetActionsForElementmaximumElementsToSearch = null, Expression<Func<int>> jABGetActionsForElementmaximumChildElementsToSearchPerNode = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetActionsForElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetActionsForElement = new JObject();
            var jABGetActionsForElementpropCount = 0;
            jABGetActionsForElementpropCount++;
            jABGetActionsForElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetActionsForElementsearchParentElementJABHandle);
            if (jABGetActionsForElementsearchElementJABName != null)
            {
                jABGetActionsForElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetActionsForElementsearchElementJABName);
                jABGetActionsForElementpropCount++;
            }

            if (jABGetActionsForElementsearchElementJABDescription != null)
            {
                jABGetActionsForElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetActionsForElementsearchElementJABDescription);
                jABGetActionsForElementpropCount++;
            }

            if (jABGetActionsForElementsearchElementJABRole != null)
            {
                jABGetActionsForElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetActionsForElementsearchElementJABRole);
                jABGetActionsForElementpropCount++;
            }

            if (jABGetActionsForElementsearchSubTree != null)
            {
                if (jABGetActionsForElementsearchSubTree != null)
                {
                    jABGetActionsForElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetActionsForElementsearchSubTree);
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
                    jABGetActionsForElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetActionsForElementmaxRelativeDepth);
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
                    jABGetActionsForElement["MatchIndex"] = ExpressionConverter.ConvertO(jABGetActionsForElementmatchIndex);
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
                jABGetActionsForElement["SearchFilter"] = ExpressionConverter.ConvertO(jABGetActionsForElementsearchFilter);
                jABGetActionsForElementpropCount++;
            }

            if (jABGetActionsForElementsortByColumn != null)
            {
                jABGetActionsForElement["SortByColumn"] = ExpressionConverter.ConvertO(jABGetActionsForElementsortByColumn);
                jABGetActionsForElementpropCount++;
            }

            if (jABGetActionsForElementmatchIndexAscending != null)
            {
                if (jABGetActionsForElementmatchIndexAscending != null)
                {
                    jABGetActionsForElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetActionsForElementmatchIndexAscending);
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
                    jABGetActionsForElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetActionsForElementcaseSensitiveSearch);
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
                    jABGetActionsForElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetActionsForElementonlySearchVisibleElements);
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
                    jABGetActionsForElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetActionsForElementonlySearchShowingElements);
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
                jABGetActionsForElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetActionsForElementelementRolesNotToTraverse);
                jABGetActionsForElementpropCount++;
            }

            if (jABGetActionsForElementmaximumElementsToSearch != null)
            {
                if (jABGetActionsForElementmaximumElementsToSearch != null)
                {
                    jABGetActionsForElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetActionsForElementmaximumElementsToSearch);
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
                    jABGetActionsForElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetActionsForElementmaximumChildElementsToSearchPerNode);
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
            jABGetActionsForElement["Workflow"] = ExpressionConverter.ConvertO(jABGetActionsForElementworkflow);
            if (jABGetActionsForElementpropCount > 0)
            {
                callPayload.Body = jABGetActionsForElement;
            }

            return new ApiConnectionAction<JABGetActionsForElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABFocusElement(Expression<Func<int>> jABFocusElementsearchParentElementJABHandle, Expression<Func<string>> jABFocusElementworkflow, Expression<Func<string>> jABFocusElementsearchElementJABName = null, Expression<Func<string>> jABFocusElementsearchElementJABDescription = null, Expression<Func<string>> jABFocusElementsearchElementJABRole = null, Expression<Func<bool>> jABFocusElementsearchSubTree = null, Expression<Func<int>> jABFocusElementmaxRelativeDepth = null, Expression<Func<int>> jABFocusElementmatchIndex = null, Expression<Func<string>> jABFocusElementsearchFilter = null, Expression<Func<string>> jABFocusElementsortByColumn = null, Expression<Func<bool>> jABFocusElementmatchIndexAscending = null, Expression<Func<bool>> jABFocusElementcaseSensitiveSearch = null, Expression<Func<bool>> jABFocusElementonlySearchVisibleElements = null, Expression<Func<bool>> jABFocusElementonlySearchShowingElements = null, Expression<Func<string>> jABFocusElementelementRolesNotToTraverse = null, Expression<Func<int>> jABFocusElementmaximumElementsToSearch = null, Expression<Func<int>> jABFocusElementmaximumChildElementsToSearchPerNode = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABFocusElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABFocusElement = new JObject();
            var jABFocusElementpropCount = 0;
            jABFocusElementpropCount++;
            jABFocusElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABFocusElementsearchParentElementJABHandle);
            if (jABFocusElementsearchElementJABName != null)
            {
                jABFocusElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABFocusElementsearchElementJABName);
                jABFocusElementpropCount++;
            }

            if (jABFocusElementsearchElementJABDescription != null)
            {
                jABFocusElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABFocusElementsearchElementJABDescription);
                jABFocusElementpropCount++;
            }

            if (jABFocusElementsearchElementJABRole != null)
            {
                jABFocusElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABFocusElementsearchElementJABRole);
                jABFocusElementpropCount++;
            }

            if (jABFocusElementsearchSubTree != null)
            {
                if (jABFocusElementsearchSubTree != null)
                {
                    jABFocusElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABFocusElementsearchSubTree);
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
                    jABFocusElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABFocusElementmaxRelativeDepth);
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
                    jABFocusElement["MatchIndex"] = ExpressionConverter.ConvertO(jABFocusElementmatchIndex);
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
                jABFocusElement["SearchFilter"] = ExpressionConverter.ConvertO(jABFocusElementsearchFilter);
                jABFocusElementpropCount++;
            }

            if (jABFocusElementsortByColumn != null)
            {
                jABFocusElement["SortByColumn"] = ExpressionConverter.ConvertO(jABFocusElementsortByColumn);
                jABFocusElementpropCount++;
            }

            if (jABFocusElementmatchIndexAscending != null)
            {
                if (jABFocusElementmatchIndexAscending != null)
                {
                    jABFocusElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABFocusElementmatchIndexAscending);
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
                    jABFocusElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABFocusElementcaseSensitiveSearch);
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
                    jABFocusElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABFocusElementonlySearchVisibleElements);
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
                    jABFocusElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABFocusElementonlySearchShowingElements);
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
                jABFocusElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABFocusElementelementRolesNotToTraverse);
                jABFocusElementpropCount++;
            }

            if (jABFocusElementmaximumElementsToSearch != null)
            {
                if (jABFocusElementmaximumElementsToSearch != null)
                {
                    jABFocusElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABFocusElementmaximumElementsToSearch);
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
                    jABFocusElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABFocusElementmaximumChildElementsToSearchPerNode);
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
            jABFocusElement["Workflow"] = ExpressionConverter.ConvertO(jABFocusElementworkflow);
            if (jABFocusElementpropCount > 0)
            {
                callPayload.Body = jABFocusElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABInputPasswordIntoElement(Expression<Func<int>> jABInputPasswordIntoElementsearchParentElementJABHandle, Expression<Func<string>> jABInputPasswordIntoElementpasswordToInput, Expression<Func<string>> jABInputPasswordIntoElementworkflow, Expression<Func<string>> jABInputPasswordIntoElementsearchElementJABName = null, Expression<Func<string>> jABInputPasswordIntoElementsearchElementJABDescription = null, Expression<Func<string>> jABInputPasswordIntoElementsearchElementJABRole = null, Expression<Func<bool>> jABInputPasswordIntoElementsearchSubTree = null, Expression<Func<int>> jABInputPasswordIntoElementmaxRelativeDepth = null, Expression<Func<int>> jABInputPasswordIntoElementmatchIndex = null, Expression<Func<string>> jABInputPasswordIntoElementsearchFilter = null, Expression<Func<string>> jABInputPasswordIntoElementsortByColumn = null, Expression<Func<bool>> jABInputPasswordIntoElementmatchIndexAscending = null, Expression<Func<bool>> jABInputPasswordIntoElementcaseSensitiveSearch = null, Expression<Func<bool>> jABInputPasswordIntoElementonlySearchVisibleElements = null, Expression<Func<bool>> jABInputPasswordIntoElementonlySearchShowingElements = null, Expression<Func<string>> jABInputPasswordIntoElementelementRolesNotToTraverse = null, Expression<Func<int>> jABInputPasswordIntoElementmaximumElementsToSearch = null, Expression<Func<int>> jABInputPasswordIntoElementmaximumChildElementsToSearchPerNode = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABInputPasswordIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABInputPasswordIntoElement = new JObject();
            var jABInputPasswordIntoElementpropCount = 0;
            jABInputPasswordIntoElementpropCount++;
            jABInputPasswordIntoElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementsearchParentElementJABHandle);
            if (jABInputPasswordIntoElementsearchElementJABName != null)
            {
                jABInputPasswordIntoElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementsearchElementJABName);
                jABInputPasswordIntoElementpropCount++;
            }

            if (jABInputPasswordIntoElementsearchElementJABDescription != null)
            {
                jABInputPasswordIntoElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementsearchElementJABDescription);
                jABInputPasswordIntoElementpropCount++;
            }

            if (jABInputPasswordIntoElementsearchElementJABRole != null)
            {
                jABInputPasswordIntoElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementsearchElementJABRole);
                jABInputPasswordIntoElementpropCount++;
            }

            if (jABInputPasswordIntoElementsearchSubTree != null)
            {
                if (jABInputPasswordIntoElementsearchSubTree != null)
                {
                    jABInputPasswordIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementsearchSubTree);
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
                    jABInputPasswordIntoElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementmaxRelativeDepth);
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
                    jABInputPasswordIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementmatchIndex);
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
                jABInputPasswordIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementsearchFilter);
                jABInputPasswordIntoElementpropCount++;
            }

            if (jABInputPasswordIntoElementsortByColumn != null)
            {
                jABInputPasswordIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementsortByColumn);
                jABInputPasswordIntoElementpropCount++;
            }

            if (jABInputPasswordIntoElementmatchIndexAscending != null)
            {
                if (jABInputPasswordIntoElementmatchIndexAscending != null)
                {
                    jABInputPasswordIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementmatchIndexAscending);
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
                    jABInputPasswordIntoElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementcaseSensitiveSearch);
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
                    jABInputPasswordIntoElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementonlySearchVisibleElements);
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
                    jABInputPasswordIntoElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementonlySearchShowingElements);
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
                jABInputPasswordIntoElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementelementRolesNotToTraverse);
                jABInputPasswordIntoElementpropCount++;
            }

            if (jABInputPasswordIntoElementmaximumElementsToSearch != null)
            {
                if (jABInputPasswordIntoElementmaximumElementsToSearch != null)
                {
                    jABInputPasswordIntoElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementmaximumElementsToSearch);
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
                    jABInputPasswordIntoElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementmaximumChildElementsToSearchPerNode);
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
            jABInputPasswordIntoElement["PasswordToInput"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementpasswordToInput);
            jABInputPasswordIntoElementpropCount++;
            jABInputPasswordIntoElement["Workflow"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementworkflow);
            if (jABInputPasswordIntoElementpropCount > 0)
            {
                callPayload.Body = jABInputPasswordIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABInputTextIntoElement(Expression<Func<int>> jABInputTextIntoElementsearchParentElementJABHandle, Expression<Func<string>> jABInputTextIntoElementworkflow, Expression<Func<string>> jABInputTextIntoElementsearchElementJABName = null, Expression<Func<string>> jABInputTextIntoElementsearchElementJABDescription = null, Expression<Func<string>> jABInputTextIntoElementsearchElementJABRole = null, Expression<Func<bool>> jABInputTextIntoElementsearchSubTree = null, Expression<Func<int>> jABInputTextIntoElementmaxRelativeDepth = null, Expression<Func<int>> jABInputTextIntoElementmatchIndex = null, Expression<Func<string>> jABInputTextIntoElementsearchFilter = null, Expression<Func<string>> jABInputTextIntoElementsortByColumn = null, Expression<Func<bool>> jABInputTextIntoElementmatchIndexAscending = null, Expression<Func<bool>> jABInputTextIntoElementcaseSensitiveSearch = null, Expression<Func<bool>> jABInputTextIntoElementonlySearchVisibleElements = null, Expression<Func<bool>> jABInputTextIntoElementonlySearchShowingElements = null, Expression<Func<string>> jABInputTextIntoElementelementRolesNotToTraverse = null, Expression<Func<int>> jABInputTextIntoElementmaximumElementsToSearch = null, Expression<Func<int>> jABInputTextIntoElementmaximumChildElementsToSearchPerNode = null, Expression<Func<string>> jABInputTextIntoElementtextToInput = null, Expression<Func<bool>> jABInputTextIntoElementreplaceExistingValue = null, Expression<Func<int>> jABInputTextIntoElementinsertPosition = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABInputTextIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABInputTextIntoElement = new JObject();
            var jABInputTextIntoElementpropCount = 0;
            jABInputTextIntoElementpropCount++;
            jABInputTextIntoElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABInputTextIntoElementsearchParentElementJABHandle);
            if (jABInputTextIntoElementsearchElementJABName != null)
            {
                jABInputTextIntoElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABInputTextIntoElementsearchElementJABName);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementsearchElementJABDescription != null)
            {
                jABInputTextIntoElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABInputTextIntoElementsearchElementJABDescription);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementsearchElementJABRole != null)
            {
                jABInputTextIntoElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABInputTextIntoElementsearchElementJABRole);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementsearchSubTree != null)
            {
                if (jABInputTextIntoElementsearchSubTree != null)
                {
                    jABInputTextIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABInputTextIntoElementsearchSubTree);
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
                    jABInputTextIntoElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABInputTextIntoElementmaxRelativeDepth);
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
                    jABInputTextIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(jABInputTextIntoElementmatchIndex);
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
                jABInputTextIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(jABInputTextIntoElementsearchFilter);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementsortByColumn != null)
            {
                jABInputTextIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(jABInputTextIntoElementsortByColumn);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementmatchIndexAscending != null)
            {
                if (jABInputTextIntoElementmatchIndexAscending != null)
                {
                    jABInputTextIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABInputTextIntoElementmatchIndexAscending);
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
                    jABInputTextIntoElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABInputTextIntoElementcaseSensitiveSearch);
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
                    jABInputTextIntoElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABInputTextIntoElementonlySearchVisibleElements);
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
                    jABInputTextIntoElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABInputTextIntoElementonlySearchShowingElements);
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
                jABInputTextIntoElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABInputTextIntoElementelementRolesNotToTraverse);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementmaximumElementsToSearch != null)
            {
                if (jABInputTextIntoElementmaximumElementsToSearch != null)
                {
                    jABInputTextIntoElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABInputTextIntoElementmaximumElementsToSearch);
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
                    jABInputTextIntoElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABInputTextIntoElementmaximumChildElementsToSearchPerNode);
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
                jABInputTextIntoElement["TextToInput"] = ExpressionConverter.ConvertO(jABInputTextIntoElementtextToInput);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementreplaceExistingValue != null)
            {
                if (jABInputTextIntoElementreplaceExistingValue != null)
                {
                    jABInputTextIntoElement["ReplaceExistingValue"] = ExpressionConverter.ConvertO(jABInputTextIntoElementreplaceExistingValue);
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
                    jABInputTextIntoElement["InsertPosition"] = ExpressionConverter.ConvertO(jABInputTextIntoElementinsertPosition);
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
            jABInputTextIntoElement["Workflow"] = ExpressionConverter.ConvertO(jABInputTextIntoElementworkflow);
            if (jABInputTextIntoElementpropCount > 0)
            {
                callPayload.Body = jABInputTextIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetElementTextValueResponse> JABGetElementTextValue(Expression<Func<int>> jABGetElementTextValuesearchParentElementJABHandle, Expression<Func<string>> jABGetElementTextValueworkflow, Expression<Func<string>> jABGetElementTextValuesearchElementJABName = null, Expression<Func<string>> jABGetElementTextValuesearchElementJABDescription = null, Expression<Func<string>> jABGetElementTextValuesearchElementJABRole = null, Expression<Func<bool>> jABGetElementTextValuesearchSubTree = null, Expression<Func<int>> jABGetElementTextValuemaxRelativeDepth = null, Expression<Func<int>> jABGetElementTextValuematchIndex = null, Expression<Func<string>> jABGetElementTextValuesearchFilter = null, Expression<Func<string>> jABGetElementTextValuesortByColumn = null, Expression<Func<bool>> jABGetElementTextValuematchIndexAscending = null, Expression<Func<bool>> jABGetElementTextValuecaseSensitiveSearch = null, Expression<Func<bool>> jABGetElementTextValueonlySearchVisibleElements = null, Expression<Func<bool>> jABGetElementTextValueonlySearchShowingElements = null, Expression<Func<string>> jABGetElementTextValueelementRolesNotToTraverse = null, Expression<Func<int>> jABGetElementTextValuemaximumElementsToSearch = null, Expression<Func<int>> jABGetElementTextValuemaximumChildElementsToSearchPerNode = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetElementTextValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetElementTextValue = new JObject();
            var jABGetElementTextValuepropCount = 0;
            jABGetElementTextValuepropCount++;
            jABGetElementTextValue["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetElementTextValuesearchParentElementJABHandle);
            if (jABGetElementTextValuesearchElementJABName != null)
            {
                jABGetElementTextValue["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetElementTextValuesearchElementJABName);
                jABGetElementTextValuepropCount++;
            }

            if (jABGetElementTextValuesearchElementJABDescription != null)
            {
                jABGetElementTextValue["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetElementTextValuesearchElementJABDescription);
                jABGetElementTextValuepropCount++;
            }

            if (jABGetElementTextValuesearchElementJABRole != null)
            {
                jABGetElementTextValue["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetElementTextValuesearchElementJABRole);
                jABGetElementTextValuepropCount++;
            }

            if (jABGetElementTextValuesearchSubTree != null)
            {
                if (jABGetElementTextValuesearchSubTree != null)
                {
                    jABGetElementTextValue["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetElementTextValuesearchSubTree);
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
                    jABGetElementTextValue["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetElementTextValuemaxRelativeDepth);
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
                    jABGetElementTextValue["MatchIndex"] = ExpressionConverter.ConvertO(jABGetElementTextValuematchIndex);
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
                jABGetElementTextValue["SearchFilter"] = ExpressionConverter.ConvertO(jABGetElementTextValuesearchFilter);
                jABGetElementTextValuepropCount++;
            }

            if (jABGetElementTextValuesortByColumn != null)
            {
                jABGetElementTextValue["SortByColumn"] = ExpressionConverter.ConvertO(jABGetElementTextValuesortByColumn);
                jABGetElementTextValuepropCount++;
            }

            if (jABGetElementTextValuematchIndexAscending != null)
            {
                if (jABGetElementTextValuematchIndexAscending != null)
                {
                    jABGetElementTextValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetElementTextValuematchIndexAscending);
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
                    jABGetElementTextValue["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetElementTextValuecaseSensitiveSearch);
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
                    jABGetElementTextValue["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetElementTextValueonlySearchVisibleElements);
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
                    jABGetElementTextValue["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetElementTextValueonlySearchShowingElements);
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
                jABGetElementTextValue["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetElementTextValueelementRolesNotToTraverse);
                jABGetElementTextValuepropCount++;
            }

            if (jABGetElementTextValuemaximumElementsToSearch != null)
            {
                if (jABGetElementTextValuemaximumElementsToSearch != null)
                {
                    jABGetElementTextValue["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetElementTextValuemaximumElementsToSearch);
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
                    jABGetElementTextValue["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetElementTextValuemaximumChildElementsToSearchPerNode);
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
            jABGetElementTextValue["Workflow"] = ExpressionConverter.ConvertO(jABGetElementTextValueworkflow);
            if (jABGetElementTextValuepropCount > 0)
            {
                callPayload.Body = jABGetElementTextValue;
            }

            return new ApiConnectionAction<JABGetElementTextValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetElementValueResponse> JABGetElementValue(Expression<Func<int>> jABGetElementValuesearchParentElementJABHandle, Expression<Func<string>> jABGetElementValueworkflow, Expression<Func<string>> jABGetElementValuesearchElementJABName = null, Expression<Func<string>> jABGetElementValuesearchElementJABDescription = null, Expression<Func<string>> jABGetElementValuesearchElementJABRole = null, Expression<Func<bool>> jABGetElementValuesearchSubTree = null, Expression<Func<int>> jABGetElementValuemaxRelativeDepth = null, Expression<Func<int>> jABGetElementValuematchIndex = null, Expression<Func<string>> jABGetElementValuesearchFilter = null, Expression<Func<string>> jABGetElementValuesortByColumn = null, Expression<Func<bool>> jABGetElementValuematchIndexAscending = null, Expression<Func<bool>> jABGetElementValuecaseSensitiveSearch = null, Expression<Func<bool>> jABGetElementValueonlySearchVisibleElements = null, Expression<Func<bool>> jABGetElementValueonlySearchShowingElements = null, Expression<Func<string>> jABGetElementValueelementRolesNotToTraverse = null, Expression<Func<int>> jABGetElementValuemaximumElementsToSearch = null, Expression<Func<int>> jABGetElementValuemaximumChildElementsToSearchPerNode = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetElementValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetElementValue = new JObject();
            var jABGetElementValuepropCount = 0;
            jABGetElementValuepropCount++;
            jABGetElementValue["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetElementValuesearchParentElementJABHandle);
            if (jABGetElementValuesearchElementJABName != null)
            {
                jABGetElementValue["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetElementValuesearchElementJABName);
                jABGetElementValuepropCount++;
            }

            if (jABGetElementValuesearchElementJABDescription != null)
            {
                jABGetElementValue["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetElementValuesearchElementJABDescription);
                jABGetElementValuepropCount++;
            }

            if (jABGetElementValuesearchElementJABRole != null)
            {
                jABGetElementValue["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetElementValuesearchElementJABRole);
                jABGetElementValuepropCount++;
            }

            if (jABGetElementValuesearchSubTree != null)
            {
                if (jABGetElementValuesearchSubTree != null)
                {
                    jABGetElementValue["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetElementValuesearchSubTree);
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
                    jABGetElementValue["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetElementValuemaxRelativeDepth);
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
                    jABGetElementValue["MatchIndex"] = ExpressionConverter.ConvertO(jABGetElementValuematchIndex);
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
                jABGetElementValue["SearchFilter"] = ExpressionConverter.ConvertO(jABGetElementValuesearchFilter);
                jABGetElementValuepropCount++;
            }

            if (jABGetElementValuesortByColumn != null)
            {
                jABGetElementValue["SortByColumn"] = ExpressionConverter.ConvertO(jABGetElementValuesortByColumn);
                jABGetElementValuepropCount++;
            }

            if (jABGetElementValuematchIndexAscending != null)
            {
                if (jABGetElementValuematchIndexAscending != null)
                {
                    jABGetElementValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetElementValuematchIndexAscending);
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
                    jABGetElementValue["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetElementValuecaseSensitiveSearch);
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
                    jABGetElementValue["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetElementValueonlySearchVisibleElements);
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
                    jABGetElementValue["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetElementValueonlySearchShowingElements);
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
                jABGetElementValue["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetElementValueelementRolesNotToTraverse);
                jABGetElementValuepropCount++;
            }

            if (jABGetElementValuemaximumElementsToSearch != null)
            {
                if (jABGetElementValuemaximumElementsToSearch != null)
                {
                    jABGetElementValue["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetElementValuemaximumElementsToSearch);
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
                    jABGetElementValue["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetElementValuemaximumChildElementsToSearchPerNode);
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
            jABGetElementValue["Workflow"] = ExpressionConverter.ConvertO(jABGetElementValueworkflow);
            if (jABGetElementValuepropCount > 0)
            {
                callPayload.Body = jABGetElementValue;
            }

            return new ApiConnectionAction<JABGetElementValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABCheckElement(Expression<Func<int>> jABCheckElementsearchParentElementJABHandle, Expression<Func<string>> jABCheckElementworkflow, Expression<Func<string>> jABCheckElementsearchElementJABName = null, Expression<Func<string>> jABCheckElementsearchElementJABDescription = null, Expression<Func<string>> jABCheckElementsearchElementJABRole = null, Expression<Func<bool>> jABCheckElementsearchSubTree = null, Expression<Func<int>> jABCheckElementmaxRelativeDepth = null, Expression<Func<int>> jABCheckElementmatchIndex = null, Expression<Func<string>> jABCheckElementsearchFilter = null, Expression<Func<string>> jABCheckElementsortByColumn = null, Expression<Func<bool>> jABCheckElementmatchIndexAscending = null, Expression<Func<bool>> jABCheckElementcaseSensitiveSearch = null, Expression<Func<bool>> jABCheckElementonlySearchVisibleElements = null, Expression<Func<bool>> jABCheckElementonlySearchShowingElements = null, Expression<Func<string>> jABCheckElementelementRolesNotToTraverse = null, Expression<Func<int>> jABCheckElementmaximumElementsToSearch = null, Expression<Func<int>> jABCheckElementmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABCheckElementcheckElement = null, Expression<Func<bool>> jABCheckElementautoDetectActionName = null, Expression<Func<string>> jABCheckElementoverrideActionName = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABCheckElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABCheckElement = new JObject();
            var jABCheckElementpropCount = 0;
            jABCheckElementpropCount++;
            jABCheckElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABCheckElementsearchParentElementJABHandle);
            if (jABCheckElementsearchElementJABName != null)
            {
                jABCheckElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABCheckElementsearchElementJABName);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementsearchElementJABDescription != null)
            {
                jABCheckElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABCheckElementsearchElementJABDescription);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementsearchElementJABRole != null)
            {
                jABCheckElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABCheckElementsearchElementJABRole);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementsearchSubTree != null)
            {
                if (jABCheckElementsearchSubTree != null)
                {
                    jABCheckElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABCheckElementsearchSubTree);
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
                    jABCheckElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABCheckElementmaxRelativeDepth);
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
                    jABCheckElement["MatchIndex"] = ExpressionConverter.ConvertO(jABCheckElementmatchIndex);
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
                jABCheckElement["SearchFilter"] = ExpressionConverter.ConvertO(jABCheckElementsearchFilter);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementsortByColumn != null)
            {
                jABCheckElement["SortByColumn"] = ExpressionConverter.ConvertO(jABCheckElementsortByColumn);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementmatchIndexAscending != null)
            {
                if (jABCheckElementmatchIndexAscending != null)
                {
                    jABCheckElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABCheckElementmatchIndexAscending);
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
                    jABCheckElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABCheckElementcaseSensitiveSearch);
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
                    jABCheckElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABCheckElementonlySearchVisibleElements);
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
                    jABCheckElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABCheckElementonlySearchShowingElements);
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
                jABCheckElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABCheckElementelementRolesNotToTraverse);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementmaximumElementsToSearch != null)
            {
                if (jABCheckElementmaximumElementsToSearch != null)
                {
                    jABCheckElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABCheckElementmaximumElementsToSearch);
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
                    jABCheckElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABCheckElementmaximumChildElementsToSearchPerNode);
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
                    jABCheckElement["CheckElement"] = ExpressionConverter.ConvertO(jABCheckElementcheckElement);
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
                    jABCheckElement["AutoDetectActionName"] = ExpressionConverter.ConvertO(jABCheckElementautoDetectActionName);
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
                jABCheckElement["OverrideActionName"] = ExpressionConverter.ConvertO(jABCheckElementoverrideActionName);
                jABCheckElementpropCount++;
            }

            jABCheckElementpropCount++;
            jABCheckElement["Workflow"] = ExpressionConverter.ConvertO(jABCheckElementworkflow);
            if (jABCheckElementpropCount > 0)
            {
                callPayload.Body = jABCheckElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetElementPropertiesAsListResponse> JABGetElementPropertiesAsList(Expression<Func<int>> jABGetElementPropertiesAsListsearchParentElementJABHandle, Expression<Func<string>> jABGetElementPropertiesAsListworkflow, Expression<Func<string>> jABGetElementPropertiesAsListsearchElementJABName = null, Expression<Func<string>> jABGetElementPropertiesAsListsearchElementJABDescription = null, Expression<Func<string>> jABGetElementPropertiesAsListsearchElementJABRole = null, Expression<Func<bool>> jABGetElementPropertiesAsListsearchSubTree = null, Expression<Func<int>> jABGetElementPropertiesAsListmaxRelativeDepth = null, Expression<Func<int>> jABGetElementPropertiesAsListmatchIndex = null, Expression<Func<string>> jABGetElementPropertiesAsListsearchFilter = null, Expression<Func<string>> jABGetElementPropertiesAsListsortByColumn = null, Expression<Func<bool>> jABGetElementPropertiesAsListmatchIndexAscending = null, Expression<Func<bool>> jABGetElementPropertiesAsListcaseSensitiveSearch = null, Expression<Func<bool>> jABGetElementPropertiesAsListonlySearchVisibleElements = null, Expression<Func<bool>> jABGetElementPropertiesAsListonlySearchShowingElements = null, Expression<Func<string>> jABGetElementPropertiesAsListelementRolesNotToTraverse = null, Expression<Func<int>> jABGetElementPropertiesAsListmaximumElementsToSearch = null, Expression<Func<int>> jABGetElementPropertiesAsListmaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABGetElementPropertiesAsListmaxStringLength = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetElementPropertiesAsList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetElementPropertiesAsList = new JObject();
            var jABGetElementPropertiesAsListpropCount = 0;
            jABGetElementPropertiesAsListpropCount++;
            jABGetElementPropertiesAsList["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListsearchParentElementJABHandle);
            if (jABGetElementPropertiesAsListsearchElementJABName != null)
            {
                jABGetElementPropertiesAsList["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListsearchElementJABName);
                jABGetElementPropertiesAsListpropCount++;
            }

            if (jABGetElementPropertiesAsListsearchElementJABDescription != null)
            {
                jABGetElementPropertiesAsList["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListsearchElementJABDescription);
                jABGetElementPropertiesAsListpropCount++;
            }

            if (jABGetElementPropertiesAsListsearchElementJABRole != null)
            {
                jABGetElementPropertiesAsList["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListsearchElementJABRole);
                jABGetElementPropertiesAsListpropCount++;
            }

            if (jABGetElementPropertiesAsListsearchSubTree != null)
            {
                if (jABGetElementPropertiesAsListsearchSubTree != null)
                {
                    jABGetElementPropertiesAsList["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListsearchSubTree);
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
                    jABGetElementPropertiesAsList["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListmaxRelativeDepth);
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
                    jABGetElementPropertiesAsList["MatchIndex"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListmatchIndex);
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
                jABGetElementPropertiesAsList["SearchFilter"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListsearchFilter);
                jABGetElementPropertiesAsListpropCount++;
            }

            if (jABGetElementPropertiesAsListsortByColumn != null)
            {
                jABGetElementPropertiesAsList["SortByColumn"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListsortByColumn);
                jABGetElementPropertiesAsListpropCount++;
            }

            if (jABGetElementPropertiesAsListmatchIndexAscending != null)
            {
                if (jABGetElementPropertiesAsListmatchIndexAscending != null)
                {
                    jABGetElementPropertiesAsList["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListmatchIndexAscending);
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
                    jABGetElementPropertiesAsList["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListcaseSensitiveSearch);
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
                    jABGetElementPropertiesAsList["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListonlySearchVisibleElements);
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
                    jABGetElementPropertiesAsList["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListonlySearchShowingElements);
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
                jABGetElementPropertiesAsList["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListelementRolesNotToTraverse);
                jABGetElementPropertiesAsListpropCount++;
            }

            if (jABGetElementPropertiesAsListmaximumElementsToSearch != null)
            {
                if (jABGetElementPropertiesAsListmaximumElementsToSearch != null)
                {
                    jABGetElementPropertiesAsList["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListmaximumElementsToSearch);
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
                    jABGetElementPropertiesAsList["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListmaximumChildElementsToSearchPerNode);
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
                    jABGetElementPropertiesAsList["MaxStringLength"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListmaxStringLength);
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
            jABGetElementPropertiesAsList["Workflow"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListworkflow);
            if (jABGetElementPropertiesAsListpropCount > 0)
            {
                callPayload.Body = jABGetElementPropertiesAsList;
            }

            return new ApiConnectionAction<JABGetElementPropertiesAsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalInputPasswordIntoElement(Expression<Func<int>> jABGlobalInputPasswordIntoElementsearchParentElementJABHandle, Expression<Func<string>> jABGlobalInputPasswordIntoElementpasswordToInput, Expression<Func<string>> jABGlobalInputPasswordIntoElementworkflow, Expression<Func<string>> jABGlobalInputPasswordIntoElementsearchElementJABName = null, Expression<Func<string>> jABGlobalInputPasswordIntoElementsearchElementJABDescription = null, Expression<Func<string>> jABGlobalInputPasswordIntoElementsearchElementJABRole = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementsearchSubTree = null, Expression<Func<int>> jABGlobalInputPasswordIntoElementmaxRelativeDepth = null, Expression<Func<int>> jABGlobalInputPasswordIntoElementmatchIndex = null, Expression<Func<string>> jABGlobalInputPasswordIntoElementsearchFilter = null, Expression<Func<string>> jABGlobalInputPasswordIntoElementsortByColumn = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementmatchIndexAscending = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementcaseSensitiveSearch = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementonlySearchVisibleElements = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementonlySearchShowingElements = null, Expression<Func<string>> jABGlobalInputPasswordIntoElementelementRolesNotToTraverse = null, Expression<Func<int>> jABGlobalInputPasswordIntoElementmaximumElementsToSearch = null, Expression<Func<int>> jABGlobalInputPasswordIntoElementmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementfocusElement = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementglobalMouseClickOnElement = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementreplaceExistingValueUsingDoubleClickDelete = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementreplaceExistingValueUsingCTRLADelete = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementsendKeyEvents = null, Expression<Func<int>> jABGlobalInputPasswordIntoElementkeyIntervalInMilliseconds = null, Expression<Func<int>> jABGlobalInputPasswordIntoElementdoubleClickIntervalInMilliseconds = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementdontInterpretSymbols = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGlobalInputPasswordIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGlobalInputPasswordIntoElement = new JObject();
            var jABGlobalInputPasswordIntoElementpropCount = 0;
            jABGlobalInputPasswordIntoElementpropCount++;
            jABGlobalInputPasswordIntoElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementsearchParentElementJABHandle);
            if (jABGlobalInputPasswordIntoElementsearchElementJABName != null)
            {
                jABGlobalInputPasswordIntoElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementsearchElementJABName);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementsearchElementJABDescription != null)
            {
                jABGlobalInputPasswordIntoElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementsearchElementJABDescription);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementsearchElementJABRole != null)
            {
                jABGlobalInputPasswordIntoElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementsearchElementJABRole);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementsearchSubTree != null)
            {
                if (jABGlobalInputPasswordIntoElementsearchSubTree != null)
                {
                    jABGlobalInputPasswordIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementsearchSubTree);
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
                    jABGlobalInputPasswordIntoElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementmaxRelativeDepth);
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
                    jABGlobalInputPasswordIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementmatchIndex);
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
                jABGlobalInputPasswordIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementsearchFilter);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementsortByColumn != null)
            {
                jABGlobalInputPasswordIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementsortByColumn);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementmatchIndexAscending != null)
            {
                if (jABGlobalInputPasswordIntoElementmatchIndexAscending != null)
                {
                    jABGlobalInputPasswordIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementmatchIndexAscending);
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
                    jABGlobalInputPasswordIntoElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementcaseSensitiveSearch);
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
                    jABGlobalInputPasswordIntoElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementonlySearchVisibleElements);
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
                    jABGlobalInputPasswordIntoElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementonlySearchShowingElements);
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
                jABGlobalInputPasswordIntoElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementelementRolesNotToTraverse);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementmaximumElementsToSearch != null)
            {
                if (jABGlobalInputPasswordIntoElementmaximumElementsToSearch != null)
                {
                    jABGlobalInputPasswordIntoElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementmaximumElementsToSearch);
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
                    jABGlobalInputPasswordIntoElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementmaximumChildElementsToSearchPerNode);
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
                    jABGlobalInputPasswordIntoElement["FocusElement"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementfocusElement);
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
                    jABGlobalInputPasswordIntoElement["GlobalMouseClickOnElement"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementglobalMouseClickOnElement);
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
                    jABGlobalInputPasswordIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementreplaceExistingValueUsingDoubleClickDelete);
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
                    jABGlobalInputPasswordIntoElement["ReplaceExistingValueUsingCTRLADelete"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementreplaceExistingValueUsingCTRLADelete);
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
            jABGlobalInputPasswordIntoElement["PasswordToInput"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementpasswordToInput);
            if (jABGlobalInputPasswordIntoElementsendKeyEvents != null)
            {
                if (jABGlobalInputPasswordIntoElementsendKeyEvents != null)
                {
                    jABGlobalInputPasswordIntoElement["SendKeyEvents"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementsendKeyEvents);
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
                    jABGlobalInputPasswordIntoElement["KeyIntervalInMilliseconds"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementkeyIntervalInMilliseconds);
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
                    jABGlobalInputPasswordIntoElement["DoubleClickIntervalInMilliseconds"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementdoubleClickIntervalInMilliseconds);
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
                    jABGlobalInputPasswordIntoElement["DontInterpretSymbols"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementdontInterpretSymbols);
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
            jABGlobalInputPasswordIntoElement["Workflow"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementworkflow);
            if (jABGlobalInputPasswordIntoElementpropCount > 0)
            {
                callPayload.Body = jABGlobalInputPasswordIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalInputTextIntoElement(Expression<Func<int>> jABGlobalInputTextIntoElementsearchParentElementJABHandle, Expression<Func<string>> jABGlobalInputTextIntoElementworkflow, Expression<Func<string>> jABGlobalInputTextIntoElementsearchElementJABName = null, Expression<Func<string>> jABGlobalInputTextIntoElementsearchElementJABDescription = null, Expression<Func<string>> jABGlobalInputTextIntoElementsearchElementJABRole = null, Expression<Func<bool>> jABGlobalInputTextIntoElementsearchSubTree = null, Expression<Func<int>> jABGlobalInputTextIntoElementmaxRelativeDepth = null, Expression<Func<int>> jABGlobalInputTextIntoElementmatchIndex = null, Expression<Func<string>> jABGlobalInputTextIntoElementsearchFilter = null, Expression<Func<string>> jABGlobalInputTextIntoElementsortByColumn = null, Expression<Func<bool>> jABGlobalInputTextIntoElementmatchIndexAscending = null, Expression<Func<bool>> jABGlobalInputTextIntoElementcaseSensitiveSearch = null, Expression<Func<bool>> jABGlobalInputTextIntoElementonlySearchVisibleElements = null, Expression<Func<bool>> jABGlobalInputTextIntoElementonlySearchShowingElements = null, Expression<Func<string>> jABGlobalInputTextIntoElementelementRolesNotToTraverse = null, Expression<Func<int>> jABGlobalInputTextIntoElementmaximumElementsToSearch = null, Expression<Func<int>> jABGlobalInputTextIntoElementmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGlobalInputTextIntoElementfocusElement = null, Expression<Func<bool>> jABGlobalInputTextIntoElementglobalMouseClickOnElement = null, Expression<Func<bool>> jABGlobalInputTextIntoElementreplaceExistingValueUsingDoubleClickDelete = null, Expression<Func<bool>> jABGlobalInputTextIntoElementreplaceExistingValueUsingCTRLADelete = null, Expression<Func<string>> jABGlobalInputTextIntoElementtextToInput = null, Expression<Func<bool>> jABGlobalInputTextIntoElementsendKeyEvents = null, Expression<Func<int>> jABGlobalInputTextIntoElementkeyIntervalInMilliseconds = null, Expression<Func<int>> jABGlobalInputTextIntoElementdoubleClickIntervalInMilliseconds = null, Expression<Func<bool>> jABGlobalInputTextIntoElementdontInterpretSymbols = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGlobalInputTextIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGlobalInputTextIntoElement = new JObject();
            var jABGlobalInputTextIntoElementpropCount = 0;
            jABGlobalInputTextIntoElementpropCount++;
            jABGlobalInputTextIntoElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementsearchParentElementJABHandle);
            if (jABGlobalInputTextIntoElementsearchElementJABName != null)
            {
                jABGlobalInputTextIntoElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementsearchElementJABName);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementsearchElementJABDescription != null)
            {
                jABGlobalInputTextIntoElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementsearchElementJABDescription);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementsearchElementJABRole != null)
            {
                jABGlobalInputTextIntoElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementsearchElementJABRole);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementsearchSubTree != null)
            {
                if (jABGlobalInputTextIntoElementsearchSubTree != null)
                {
                    jABGlobalInputTextIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementsearchSubTree);
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
                    jABGlobalInputTextIntoElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementmaxRelativeDepth);
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
                    jABGlobalInputTextIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementmatchIndex);
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
                jABGlobalInputTextIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementsearchFilter);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementsortByColumn != null)
            {
                jABGlobalInputTextIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementsortByColumn);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementmatchIndexAscending != null)
            {
                if (jABGlobalInputTextIntoElementmatchIndexAscending != null)
                {
                    jABGlobalInputTextIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementmatchIndexAscending);
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
                    jABGlobalInputTextIntoElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementcaseSensitiveSearch);
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
                    jABGlobalInputTextIntoElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementonlySearchVisibleElements);
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
                    jABGlobalInputTextIntoElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementonlySearchShowingElements);
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
                jABGlobalInputTextIntoElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementelementRolesNotToTraverse);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementmaximumElementsToSearch != null)
            {
                if (jABGlobalInputTextIntoElementmaximumElementsToSearch != null)
                {
                    jABGlobalInputTextIntoElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementmaximumElementsToSearch);
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
                    jABGlobalInputTextIntoElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementmaximumChildElementsToSearchPerNode);
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
                    jABGlobalInputTextIntoElement["FocusElement"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementfocusElement);
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
                    jABGlobalInputTextIntoElement["GlobalMouseClickOnElement"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementglobalMouseClickOnElement);
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
                    jABGlobalInputTextIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementreplaceExistingValueUsingDoubleClickDelete);
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
                    jABGlobalInputTextIntoElement["ReplaceExistingValueUsingCTRLADelete"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementreplaceExistingValueUsingCTRLADelete);
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
                jABGlobalInputTextIntoElement["TextToInput"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementtextToInput);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementsendKeyEvents != null)
            {
                if (jABGlobalInputTextIntoElementsendKeyEvents != null)
                {
                    jABGlobalInputTextIntoElement["SendKeyEvents"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementsendKeyEvents);
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
                    jABGlobalInputTextIntoElement["KeyIntervalInMilliseconds"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementkeyIntervalInMilliseconds);
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
                    jABGlobalInputTextIntoElement["DoubleClickIntervalInMilliseconds"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementdoubleClickIntervalInMilliseconds);
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
                    jABGlobalInputTextIntoElement["DontInterpretSymbols"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementdontInterpretSymbols);
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
            jABGlobalInputTextIntoElement["Workflow"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementworkflow);
            if (jABGlobalInputTextIntoElementpropCount > 0)
            {
                callPayload.Body = jABGlobalInputTextIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetSelectionElementItemsResponse> JABGetSelectionElementItems(Expression<Func<int>> jABGetSelectionElementItemssearchParentElementJABHandle, Expression<Func<string>> jABGetSelectionElementItemsworkflow, Expression<Func<string>> jABGetSelectionElementItemssearchElementJABName = null, Expression<Func<string>> jABGetSelectionElementItemssearchElementJABDescription = null, Expression<Func<string>> jABGetSelectionElementItemssearchElementJABRole = null, Expression<Func<bool>> jABGetSelectionElementItemssearchSubTree = null, Expression<Func<int>> jABGetSelectionElementItemsmaxRelativeDepth = null, Expression<Func<int>> jABGetSelectionElementItemsmatchIndex = null, Expression<Func<string>> jABGetSelectionElementItemssearchFilter = null, Expression<Func<string>> jABGetSelectionElementItemssortByColumn = null, Expression<Func<bool>> jABGetSelectionElementItemsmatchIndexAscending = null, Expression<Func<bool>> jABGetSelectionElementItemscaseSensitiveSearch = null, Expression<Func<bool>> jABGetSelectionElementItemsonlySearchVisibleElements = null, Expression<Func<bool>> jABGetSelectionElementItemsonlySearchShowingElements = null, Expression<Func<string>> jABGetSelectionElementItemselementRolesNotToTraverse = null, Expression<Func<int>> jABGetSelectionElementItemsmaximumElementsToSearch = null, Expression<Func<int>> jABGetSelectionElementItemsmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGetSelectionElementItemsgetListOfOptionsBySelecting = null, Expression<Func<bool>> jABGetSelectionElementItemsgetListOfOptionsByReadingLabels = null, Expression<Func<bool>> jABGetSelectionElementItemsexpandFirst = null, Expression<Func<bool>> jABGetSelectionElementItemscollapseAfter = null, Expression<Func<double>> jABGetSelectionElementItemssecondsBetweenExpandCollapse = null, Expression<Func<int>> jABGetSelectionElementItemsmaxListItemsToReturn = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetSelectionElementItems";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetSelectionElementItems = new JObject();
            var jABGetSelectionElementItemspropCount = 0;
            jABGetSelectionElementItemspropCount++;
            jABGetSelectionElementItems["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemssearchParentElementJABHandle);
            if (jABGetSelectionElementItemssearchElementJABName != null)
            {
                jABGetSelectionElementItems["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemssearchElementJABName);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemssearchElementJABDescription != null)
            {
                jABGetSelectionElementItems["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemssearchElementJABDescription);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemssearchElementJABRole != null)
            {
                jABGetSelectionElementItems["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemssearchElementJABRole);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemssearchSubTree != null)
            {
                if (jABGetSelectionElementItemssearchSubTree != null)
                {
                    jABGetSelectionElementItems["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemssearchSubTree);
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
                    jABGetSelectionElementItems["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsmaxRelativeDepth);
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
                    jABGetSelectionElementItems["MatchIndex"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsmatchIndex);
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
                jABGetSelectionElementItems["SearchFilter"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemssearchFilter);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemssortByColumn != null)
            {
                jABGetSelectionElementItems["SortByColumn"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemssortByColumn);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemsmatchIndexAscending != null)
            {
                if (jABGetSelectionElementItemsmatchIndexAscending != null)
                {
                    jABGetSelectionElementItems["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsmatchIndexAscending);
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
                    jABGetSelectionElementItems["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemscaseSensitiveSearch);
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
                    jABGetSelectionElementItems["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsonlySearchVisibleElements);
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
                    jABGetSelectionElementItems["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsonlySearchShowingElements);
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
                jABGetSelectionElementItems["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemselementRolesNotToTraverse);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemsmaximumElementsToSearch != null)
            {
                if (jABGetSelectionElementItemsmaximumElementsToSearch != null)
                {
                    jABGetSelectionElementItems["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsmaximumElementsToSearch);
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
                    jABGetSelectionElementItems["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsmaximumChildElementsToSearchPerNode);
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
                    jABGetSelectionElementItems["GetListOfOptionsBySelecting"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsgetListOfOptionsBySelecting);
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
                    jABGetSelectionElementItems["GetListOfOptionsByReadingLabels"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsgetListOfOptionsByReadingLabels);
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
                    jABGetSelectionElementItems["ExpandFirst"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsexpandFirst);
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
                    jABGetSelectionElementItems["CollapseAfter"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemscollapseAfter);
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
                    jABGetSelectionElementItems["SecondsBetweenExpandCollapse"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemssecondsBetweenExpandCollapse);
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
                    jABGetSelectionElementItems["MaxListItemsToReturn"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsmaxListItemsToReturn);
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
            jABGetSelectionElementItems["Workflow"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsworkflow);
            if (jABGetSelectionElementItemspropCount > 0)
            {
                callPayload.Body = jABGetSelectionElementItems;
            }

            return new ApiConnectionAction<JABGetSelectionElementItemsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABSetSelectionByIndex(Expression<Func<int>> jABSetSelectionByIndexsearchParentElementJABHandle, Expression<Func<int>> jABSetSelectionByIndexitemIndex, Expression<Func<string>> jABSetSelectionByIndexworkflow, Expression<Func<string>> jABSetSelectionByIndexsearchElementJABName = null, Expression<Func<string>> jABSetSelectionByIndexsearchElementJABDescription = null, Expression<Func<string>> jABSetSelectionByIndexsearchElementJABRole = null, Expression<Func<bool>> jABSetSelectionByIndexsearchSubTree = null, Expression<Func<int>> jABSetSelectionByIndexmaxRelativeDepth = null, Expression<Func<int>> jABSetSelectionByIndexmatchIndex = null, Expression<Func<string>> jABSetSelectionByIndexsearchFilter = null, Expression<Func<string>> jABSetSelectionByIndexsortByColumn = null, Expression<Func<bool>> jABSetSelectionByIndexmatchIndexAscending = null, Expression<Func<bool>> jABSetSelectionByIndexcaseSensitiveSearch = null, Expression<Func<bool>> jABSetSelectionByIndexonlySearchVisibleElements = null, Expression<Func<bool>> jABSetSelectionByIndexonlySearchShowingElements = null, Expression<Func<string>> jABSetSelectionByIndexelementRolesNotToTraverse = null, Expression<Func<int>> jABSetSelectionByIndexmaximumElementsToSearch = null, Expression<Func<int>> jABSetSelectionByIndexmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABSetSelectionByIndexselectItem = null, Expression<Func<bool>> jABSetSelectionByIndexclearSelectionFirst = null, Expression<Func<bool>> jABSetSelectionByIndexrecoverOnFailure = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABSetSelectionByIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABSetSelectionByIndex = new JObject();
            var jABSetSelectionByIndexpropCount = 0;
            jABSetSelectionByIndexpropCount++;
            jABSetSelectionByIndex["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexsearchParentElementJABHandle);
            if (jABSetSelectionByIndexsearchElementJABName != null)
            {
                jABSetSelectionByIndex["SearchElementJABName"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexsearchElementJABName);
                jABSetSelectionByIndexpropCount++;
            }

            if (jABSetSelectionByIndexsearchElementJABDescription != null)
            {
                jABSetSelectionByIndex["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexsearchElementJABDescription);
                jABSetSelectionByIndexpropCount++;
            }

            if (jABSetSelectionByIndexsearchElementJABRole != null)
            {
                jABSetSelectionByIndex["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexsearchElementJABRole);
                jABSetSelectionByIndexpropCount++;
            }

            if (jABSetSelectionByIndexsearchSubTree != null)
            {
                if (jABSetSelectionByIndexsearchSubTree != null)
                {
                    jABSetSelectionByIndex["SearchSubTree"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexsearchSubTree);
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
                    jABSetSelectionByIndex["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexmaxRelativeDepth);
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
                    jABSetSelectionByIndex["MatchIndex"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexmatchIndex);
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
                jABSetSelectionByIndex["SearchFilter"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexsearchFilter);
                jABSetSelectionByIndexpropCount++;
            }

            if (jABSetSelectionByIndexsortByColumn != null)
            {
                jABSetSelectionByIndex["SortByColumn"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexsortByColumn);
                jABSetSelectionByIndexpropCount++;
            }

            if (jABSetSelectionByIndexmatchIndexAscending != null)
            {
                if (jABSetSelectionByIndexmatchIndexAscending != null)
                {
                    jABSetSelectionByIndex["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexmatchIndexAscending);
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
                    jABSetSelectionByIndex["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexcaseSensitiveSearch);
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
                    jABSetSelectionByIndex["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexonlySearchVisibleElements);
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
                    jABSetSelectionByIndex["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexonlySearchShowingElements);
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
                jABSetSelectionByIndex["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexelementRolesNotToTraverse);
                jABSetSelectionByIndexpropCount++;
            }

            if (jABSetSelectionByIndexmaximumElementsToSearch != null)
            {
                if (jABSetSelectionByIndexmaximumElementsToSearch != null)
                {
                    jABSetSelectionByIndex["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexmaximumElementsToSearch);
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
                    jABSetSelectionByIndex["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexmaximumChildElementsToSearchPerNode);
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
            jABSetSelectionByIndex["ItemIndex"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexitemIndex);
            if (jABSetSelectionByIndexselectItem != null)
            {
                if (jABSetSelectionByIndexselectItem != null)
                {
                    jABSetSelectionByIndex["SelectItem"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexselectItem);
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
                    jABSetSelectionByIndex["ClearSelectionFirst"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexclearSelectionFirst);
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
                    jABSetSelectionByIndex["RecoverOnFailure"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexrecoverOnFailure);
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
            jABSetSelectionByIndex["Workflow"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexworkflow);
            if (jABSetSelectionByIndexpropCount > 0)
            {
                callPayload.Body = jABSetSelectionByIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABSetSelectionByName(Expression<Func<int>> jABSetSelectionByNamesearchParentElementJABHandle, Expression<Func<string>> jABSetSelectionByNameitemName, Expression<Func<string>> jABSetSelectionByNameworkflow, Expression<Func<string>> jABSetSelectionByNamesearchElementJABName = null, Expression<Func<string>> jABSetSelectionByNamesearchElementJABDescription = null, Expression<Func<string>> jABSetSelectionByNamesearchElementJABRole = null, Expression<Func<bool>> jABSetSelectionByNamesearchSubTree = null, Expression<Func<int>> jABSetSelectionByNamemaxRelativeDepth = null, Expression<Func<int>> jABSetSelectionByNamematchIndex = null, Expression<Func<string>> jABSetSelectionByNamesearchFilter = null, Expression<Func<string>> jABSetSelectionByNamesortByColumn = null, Expression<Func<bool>> jABSetSelectionByNamematchIndexAscending = null, Expression<Func<bool>> jABSetSelectionByNamecaseSensitiveSearch = null, Expression<Func<bool>> jABSetSelectionByNameonlySearchVisibleElements = null, Expression<Func<bool>> jABSetSelectionByNameonlySearchShowingElements = null, Expression<Func<string>> jABSetSelectionByNameelementRolesNotToTraverse = null, Expression<Func<int>> jABSetSelectionByNamemaximumElementsToSearch = null, Expression<Func<int>> jABSetSelectionByNamemaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABSetSelectionByNameselectItem = null, Expression<Func<bool>> jABSetSelectionByNameitemNameCaseSensitive = null, Expression<Func<bool>> jABSetSelectionByNameclearSelectionFirst = null, Expression<Func<bool>> jABSetSelectionByNamegetListOfOptionsBySelecting = null, Expression<Func<bool>> jABSetSelectionByNamegetListOfOptionsByReadingLabels = null, Expression<Func<bool>> jABSetSelectionByNameexpandFirst = null, Expression<Func<bool>> jABSetSelectionByNamecollapseAfter = null, Expression<Func<double>> jABSetSelectionByNamesecondsBetweenExpandCollapse = null, Expression<Func<bool>> jABSetSelectionByNameforceEvenIfInCorrectState = null, Expression<Func<bool>> jABSetSelectionByNamerecoverOnFailure = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABSetSelectionByName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABSetSelectionByName = new JObject();
            var jABSetSelectionByNamepropCount = 0;
            jABSetSelectionByNamepropCount++;
            jABSetSelectionByName["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABSetSelectionByNamesearchParentElementJABHandle);
            if (jABSetSelectionByNamesearchElementJABName != null)
            {
                jABSetSelectionByName["SearchElementJABName"] = ExpressionConverter.ConvertO(jABSetSelectionByNamesearchElementJABName);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNamesearchElementJABDescription != null)
            {
                jABSetSelectionByName["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABSetSelectionByNamesearchElementJABDescription);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNamesearchElementJABRole != null)
            {
                jABSetSelectionByName["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABSetSelectionByNamesearchElementJABRole);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNamesearchSubTree != null)
            {
                if (jABSetSelectionByNamesearchSubTree != null)
                {
                    jABSetSelectionByName["SearchSubTree"] = ExpressionConverter.ConvertO(jABSetSelectionByNamesearchSubTree);
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
                    jABSetSelectionByName["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABSetSelectionByNamemaxRelativeDepth);
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
                    jABSetSelectionByName["MatchIndex"] = ExpressionConverter.ConvertO(jABSetSelectionByNamematchIndex);
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
                jABSetSelectionByName["SearchFilter"] = ExpressionConverter.ConvertO(jABSetSelectionByNamesearchFilter);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNamesortByColumn != null)
            {
                jABSetSelectionByName["SortByColumn"] = ExpressionConverter.ConvertO(jABSetSelectionByNamesortByColumn);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNamematchIndexAscending != null)
            {
                if (jABSetSelectionByNamematchIndexAscending != null)
                {
                    jABSetSelectionByName["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABSetSelectionByNamematchIndexAscending);
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
                    jABSetSelectionByName["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABSetSelectionByNamecaseSensitiveSearch);
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
                    jABSetSelectionByName["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABSetSelectionByNameonlySearchVisibleElements);
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
                    jABSetSelectionByName["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABSetSelectionByNameonlySearchShowingElements);
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
                jABSetSelectionByName["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABSetSelectionByNameelementRolesNotToTraverse);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNamemaximumElementsToSearch != null)
            {
                if (jABSetSelectionByNamemaximumElementsToSearch != null)
                {
                    jABSetSelectionByName["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABSetSelectionByNamemaximumElementsToSearch);
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
                    jABSetSelectionByName["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABSetSelectionByNamemaximumChildElementsToSearchPerNode);
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
            jABSetSelectionByName["ItemName"] = ExpressionConverter.ConvertO(jABSetSelectionByNameitemName);
            if (jABSetSelectionByNameselectItem != null)
            {
                if (jABSetSelectionByNameselectItem != null)
                {
                    jABSetSelectionByName["SelectItem"] = ExpressionConverter.ConvertO(jABSetSelectionByNameselectItem);
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
                    jABSetSelectionByName["ItemNameCaseSensitive"] = ExpressionConverter.ConvertO(jABSetSelectionByNameitemNameCaseSensitive);
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
                    jABSetSelectionByName["ClearSelectionFirst"] = ExpressionConverter.ConvertO(jABSetSelectionByNameclearSelectionFirst);
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
                    jABSetSelectionByName["GetListOfOptionsBySelecting"] = ExpressionConverter.ConvertO(jABSetSelectionByNamegetListOfOptionsBySelecting);
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
                    jABSetSelectionByName["GetListOfOptionsByReadingLabels"] = ExpressionConverter.ConvertO(jABSetSelectionByNamegetListOfOptionsByReadingLabels);
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
                    jABSetSelectionByName["ExpandFirst"] = ExpressionConverter.ConvertO(jABSetSelectionByNameexpandFirst);
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
                    jABSetSelectionByName["CollapseAfter"] = ExpressionConverter.ConvertO(jABSetSelectionByNamecollapseAfter);
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
                    jABSetSelectionByName["SecondsBetweenExpandCollapse"] = ExpressionConverter.ConvertO(jABSetSelectionByNamesecondsBetweenExpandCollapse);
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
                    jABSetSelectionByName["ForceEvenIfInCorrectState"] = ExpressionConverter.ConvertO(jABSetSelectionByNameforceEvenIfInCorrectState);
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
                    jABSetSelectionByName["RecoverOnFailure"] = ExpressionConverter.ConvertO(jABSetSelectionByNamerecoverOnFailure);
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
            jABSetSelectionByName["Workflow"] = ExpressionConverter.ConvertO(jABSetSelectionByNameworkflow);
            if (jABSetSelectionByNamepropCount > 0)
            {
                callPayload.Body = jABSetSelectionByName;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABExpandSelection(Expression<Func<int>> jABExpandSelectionsearchParentElementJABHandle, Expression<Func<string>> jABExpandSelectionworkflow, Expression<Func<string>> jABExpandSelectionsearchElementJABName = null, Expression<Func<string>> jABExpandSelectionsearchElementJABDescription = null, Expression<Func<string>> jABExpandSelectionsearchElementJABRole = null, Expression<Func<bool>> jABExpandSelectionsearchSubTree = null, Expression<Func<int>> jABExpandSelectionmaxRelativeDepth = null, Expression<Func<int>> jABExpandSelectionmatchIndex = null, Expression<Func<string>> jABExpandSelectionsearchFilter = null, Expression<Func<string>> jABExpandSelectionsortByColumn = null, Expression<Func<bool>> jABExpandSelectionmatchIndexAscending = null, Expression<Func<bool>> jABExpandSelectioncaseSensitiveSearch = null, Expression<Func<bool>> jABExpandSelectiononlySearchVisibleElements = null, Expression<Func<bool>> jABExpandSelectiononlySearchShowingElements = null, Expression<Func<string>> jABExpandSelectionelementRolesNotToTraverse = null, Expression<Func<int>> jABExpandSelectionmaximumElementsToSearch = null, Expression<Func<int>> jABExpandSelectionmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABExpandSelectionexpand = null, Expression<Func<bool>> jABExpandSelectionverifyElementState = null, Expression<Func<double>> jABExpandSelectionsecondsToWaitForStateChange = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABExpandSelection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABExpandSelection = new JObject();
            var jABExpandSelectionpropCount = 0;
            jABExpandSelectionpropCount++;
            jABExpandSelection["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABExpandSelectionsearchParentElementJABHandle);
            if (jABExpandSelectionsearchElementJABName != null)
            {
                jABExpandSelection["SearchElementJABName"] = ExpressionConverter.ConvertO(jABExpandSelectionsearchElementJABName);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionsearchElementJABDescription != null)
            {
                jABExpandSelection["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABExpandSelectionsearchElementJABDescription);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionsearchElementJABRole != null)
            {
                jABExpandSelection["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABExpandSelectionsearchElementJABRole);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionsearchSubTree != null)
            {
                if (jABExpandSelectionsearchSubTree != null)
                {
                    jABExpandSelection["SearchSubTree"] = ExpressionConverter.ConvertO(jABExpandSelectionsearchSubTree);
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
                    jABExpandSelection["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABExpandSelectionmaxRelativeDepth);
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
                    jABExpandSelection["MatchIndex"] = ExpressionConverter.ConvertO(jABExpandSelectionmatchIndex);
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
                jABExpandSelection["SearchFilter"] = ExpressionConverter.ConvertO(jABExpandSelectionsearchFilter);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionsortByColumn != null)
            {
                jABExpandSelection["SortByColumn"] = ExpressionConverter.ConvertO(jABExpandSelectionsortByColumn);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionmatchIndexAscending != null)
            {
                if (jABExpandSelectionmatchIndexAscending != null)
                {
                    jABExpandSelection["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABExpandSelectionmatchIndexAscending);
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
                    jABExpandSelection["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABExpandSelectioncaseSensitiveSearch);
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
                    jABExpandSelection["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABExpandSelectiononlySearchVisibleElements);
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
                    jABExpandSelection["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABExpandSelectiononlySearchShowingElements);
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
                jABExpandSelection["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABExpandSelectionelementRolesNotToTraverse);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionmaximumElementsToSearch != null)
            {
                if (jABExpandSelectionmaximumElementsToSearch != null)
                {
                    jABExpandSelection["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABExpandSelectionmaximumElementsToSearch);
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
                    jABExpandSelection["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABExpandSelectionmaximumChildElementsToSearchPerNode);
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
                    jABExpandSelection["Expand"] = ExpressionConverter.ConvertO(jABExpandSelectionexpand);
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
                    jABExpandSelection["VerifyElementState"] = ExpressionConverter.ConvertO(jABExpandSelectionverifyElementState);
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
                    jABExpandSelection["SecondsToWaitForStateChange"] = ExpressionConverter.ConvertO(jABExpandSelectionsecondsToWaitForStateChange);
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
            jABExpandSelection["Workflow"] = ExpressionConverter.ConvertO(jABExpandSelectionworkflow);
            if (jABExpandSelectionpropCount > 0)
            {
                callPayload.Body = jABExpandSelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetSelectionStateByIndexResponse> JABGetSelectionStateByIndex(Expression<Func<int>> jABGetSelectionStateByIndexsearchParentElementJABHandle, Expression<Func<int>> jABGetSelectionStateByIndexitemIndex, Expression<Func<string>> jABGetSelectionStateByIndexworkflow, Expression<Func<string>> jABGetSelectionStateByIndexsearchElementJABName = null, Expression<Func<string>> jABGetSelectionStateByIndexsearchElementJABDescription = null, Expression<Func<string>> jABGetSelectionStateByIndexsearchElementJABRole = null, Expression<Func<bool>> jABGetSelectionStateByIndexsearchSubTree = null, Expression<Func<int>> jABGetSelectionStateByIndexmaxRelativeDepth = null, Expression<Func<int>> jABGetSelectionStateByIndexmatchIndex = null, Expression<Func<string>> jABGetSelectionStateByIndexsearchFilter = null, Expression<Func<string>> jABGetSelectionStateByIndexsortByColumn = null, Expression<Func<bool>> jABGetSelectionStateByIndexmatchIndexAscending = null, Expression<Func<bool>> jABGetSelectionStateByIndexcaseSensitiveSearch = null, Expression<Func<bool>> jABGetSelectionStateByIndexonlySearchVisibleElements = null, Expression<Func<bool>> jABGetSelectionStateByIndexonlySearchShowingElements = null, Expression<Func<string>> jABGetSelectionStateByIndexelementRolesNotToTraverse = null, Expression<Func<int>> jABGetSelectionStateByIndexmaximumElementsToSearch = null, Expression<Func<int>> jABGetSelectionStateByIndexmaximumChildElementsToSearchPerNode = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetSelectionStateByIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetSelectionStateByIndex = new JObject();
            var jABGetSelectionStateByIndexpropCount = 0;
            jABGetSelectionStateByIndexpropCount++;
            jABGetSelectionStateByIndex["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexsearchParentElementJABHandle);
            if (jABGetSelectionStateByIndexsearchElementJABName != null)
            {
                jABGetSelectionStateByIndex["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexsearchElementJABName);
                jABGetSelectionStateByIndexpropCount++;
            }

            if (jABGetSelectionStateByIndexsearchElementJABDescription != null)
            {
                jABGetSelectionStateByIndex["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexsearchElementJABDescription);
                jABGetSelectionStateByIndexpropCount++;
            }

            if (jABGetSelectionStateByIndexsearchElementJABRole != null)
            {
                jABGetSelectionStateByIndex["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexsearchElementJABRole);
                jABGetSelectionStateByIndexpropCount++;
            }

            if (jABGetSelectionStateByIndexsearchSubTree != null)
            {
                if (jABGetSelectionStateByIndexsearchSubTree != null)
                {
                    jABGetSelectionStateByIndex["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexsearchSubTree);
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
                    jABGetSelectionStateByIndex["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexmaxRelativeDepth);
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
                    jABGetSelectionStateByIndex["MatchIndex"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexmatchIndex);
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
                jABGetSelectionStateByIndex["SearchFilter"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexsearchFilter);
                jABGetSelectionStateByIndexpropCount++;
            }

            if (jABGetSelectionStateByIndexsortByColumn != null)
            {
                jABGetSelectionStateByIndex["SortByColumn"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexsortByColumn);
                jABGetSelectionStateByIndexpropCount++;
            }

            if (jABGetSelectionStateByIndexmatchIndexAscending != null)
            {
                if (jABGetSelectionStateByIndexmatchIndexAscending != null)
                {
                    jABGetSelectionStateByIndex["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexmatchIndexAscending);
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
                    jABGetSelectionStateByIndex["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexcaseSensitiveSearch);
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
                    jABGetSelectionStateByIndex["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexonlySearchVisibleElements);
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
                    jABGetSelectionStateByIndex["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexonlySearchShowingElements);
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
                jABGetSelectionStateByIndex["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexelementRolesNotToTraverse);
                jABGetSelectionStateByIndexpropCount++;
            }

            if (jABGetSelectionStateByIndexmaximumElementsToSearch != null)
            {
                if (jABGetSelectionStateByIndexmaximumElementsToSearch != null)
                {
                    jABGetSelectionStateByIndex["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexmaximumElementsToSearch);
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
                    jABGetSelectionStateByIndex["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexmaximumChildElementsToSearchPerNode);
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
            jABGetSelectionStateByIndex["ItemIndex"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexitemIndex);
            jABGetSelectionStateByIndexpropCount++;
            jABGetSelectionStateByIndex["Workflow"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexworkflow);
            if (jABGetSelectionStateByIndexpropCount > 0)
            {
                callPayload.Body = jABGetSelectionStateByIndex;
            }

            return new ApiConnectionAction<JABGetSelectionStateByIndexResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetSelectionStateByNameResponse> JABGetSelectionStateByName(Expression<Func<int>> jABGetSelectionStateByNamesearchParentElementJABHandle, Expression<Func<string>> jABGetSelectionStateByNameitemName, Expression<Func<string>> jABGetSelectionStateByNameworkflow, Expression<Func<string>> jABGetSelectionStateByNamesearchElementJABName = null, Expression<Func<string>> jABGetSelectionStateByNamesearchElementJABDescription = null, Expression<Func<string>> jABGetSelectionStateByNamesearchElementJABRole = null, Expression<Func<bool>> jABGetSelectionStateByNamesearchSubTree = null, Expression<Func<int>> jABGetSelectionStateByNamemaxRelativeDepth = null, Expression<Func<int>> jABGetSelectionStateByNamematchIndex = null, Expression<Func<string>> jABGetSelectionStateByNamesearchFilter = null, Expression<Func<string>> jABGetSelectionStateByNamesortByColumn = null, Expression<Func<bool>> jABGetSelectionStateByNamematchIndexAscending = null, Expression<Func<bool>> jABGetSelectionStateByNamecaseSensitiveSearch = null, Expression<Func<bool>> jABGetSelectionStateByNameonlySearchVisibleElements = null, Expression<Func<bool>> jABGetSelectionStateByNameonlySearchShowingElements = null, Expression<Func<string>> jABGetSelectionStateByNameelementRolesNotToTraverse = null, Expression<Func<int>> jABGetSelectionStateByNamemaximumElementsToSearch = null, Expression<Func<int>> jABGetSelectionStateByNamemaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGetSelectionStateByNameitemNameCaseSensitive = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetSelectionStateByName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetSelectionStateByName = new JObject();
            var jABGetSelectionStateByNamepropCount = 0;
            jABGetSelectionStateByNamepropCount++;
            jABGetSelectionStateByName["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNamesearchParentElementJABHandle);
            if (jABGetSelectionStateByNamesearchElementJABName != null)
            {
                jABGetSelectionStateByName["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNamesearchElementJABName);
                jABGetSelectionStateByNamepropCount++;
            }

            if (jABGetSelectionStateByNamesearchElementJABDescription != null)
            {
                jABGetSelectionStateByName["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNamesearchElementJABDescription);
                jABGetSelectionStateByNamepropCount++;
            }

            if (jABGetSelectionStateByNamesearchElementJABRole != null)
            {
                jABGetSelectionStateByName["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNamesearchElementJABRole);
                jABGetSelectionStateByNamepropCount++;
            }

            if (jABGetSelectionStateByNamesearchSubTree != null)
            {
                if (jABGetSelectionStateByNamesearchSubTree != null)
                {
                    jABGetSelectionStateByName["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNamesearchSubTree);
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
                    jABGetSelectionStateByName["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNamemaxRelativeDepth);
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
                    jABGetSelectionStateByName["MatchIndex"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNamematchIndex);
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
                jABGetSelectionStateByName["SearchFilter"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNamesearchFilter);
                jABGetSelectionStateByNamepropCount++;
            }

            if (jABGetSelectionStateByNamesortByColumn != null)
            {
                jABGetSelectionStateByName["SortByColumn"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNamesortByColumn);
                jABGetSelectionStateByNamepropCount++;
            }

            if (jABGetSelectionStateByNamematchIndexAscending != null)
            {
                if (jABGetSelectionStateByNamematchIndexAscending != null)
                {
                    jABGetSelectionStateByName["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNamematchIndexAscending);
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
                    jABGetSelectionStateByName["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNamecaseSensitiveSearch);
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
                    jABGetSelectionStateByName["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameonlySearchVisibleElements);
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
                    jABGetSelectionStateByName["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameonlySearchShowingElements);
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
                jABGetSelectionStateByName["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameelementRolesNotToTraverse);
                jABGetSelectionStateByNamepropCount++;
            }

            if (jABGetSelectionStateByNamemaximumElementsToSearch != null)
            {
                if (jABGetSelectionStateByNamemaximumElementsToSearch != null)
                {
                    jABGetSelectionStateByName["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNamemaximumElementsToSearch);
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
                    jABGetSelectionStateByName["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNamemaximumChildElementsToSearchPerNode);
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
            jABGetSelectionStateByName["ItemName"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameitemName);
            if (jABGetSelectionStateByNameitemNameCaseSensitive != null)
            {
                if (jABGetSelectionStateByNameitemNameCaseSensitive != null)
                {
                    jABGetSelectionStateByName["ItemNameCaseSensitive"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameitemNameCaseSensitive);
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
            jABGetSelectionStateByName["Workflow"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameworkflow);
            if (jABGetSelectionStateByNamepropCount > 0)
            {
                callPayload.Body = jABGetSelectionStateByName;
            }

            return new ApiConnectionAction<JABGetSelectionStateByNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetTablePropertiesResponse> JABGetTableProperties(Expression<Func<int>> jABGetTablePropertiessearchParentElementJABHandle, Expression<Func<string>> jABGetTablePropertiesworkflow, Expression<Func<string>> jABGetTablePropertiessearchElementJABName = null, Expression<Func<string>> jABGetTablePropertiessearchElementJABDescription = null, Expression<Func<string>> jABGetTablePropertiessearchElementJABRole = null, Expression<Func<bool>> jABGetTablePropertiessearchSubTree = null, Expression<Func<int>> jABGetTablePropertiesmaxRelativeDepth = null, Expression<Func<int>> jABGetTablePropertiesmatchIndex = null, Expression<Func<string>> jABGetTablePropertiessearchFilter = null, Expression<Func<string>> jABGetTablePropertiessortByColumn = null, Expression<Func<bool>> jABGetTablePropertiesmatchIndexAscending = null, Expression<Func<bool>> jABGetTablePropertiescaseSensitiveSearch = null, Expression<Func<bool>> jABGetTablePropertiesonlySearchVisibleElements = null, Expression<Func<bool>> jABGetTablePropertiesonlySearchShowingElements = null, Expression<Func<string>> jABGetTablePropertieselementRolesNotToTraverse = null, Expression<Func<int>> jABGetTablePropertiesmaximumElementsToSearch = null, Expression<Func<int>> jABGetTablePropertiesmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGetTablePropertiesenumerateViewport = null, Expression<Func<bool>> jABGetTablePropertiesprocessViewportParents = null, Expression<Func<int>> jABGetTablePropertiesmaxViewportParentsToProcess = null, Expression<Func<string>> jABGetTablePropertiesviewportParentElementRolesToConsider = null, Expression<Func<int>> jABGetTablePropertiesviewportLeftMargin = null, Expression<Func<int>> jABGetTablePropertiesviewportTopMargin = null, Expression<Func<int>> jABGetTablePropertiesviewportRightMargin = null, Expression<Func<int>> jABGetTablePropertiesviewportBottomMargin = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetTableProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetTableProperties = new JObject();
            var jABGetTablePropertiespropCount = 0;
            jABGetTablePropertiespropCount++;
            jABGetTableProperties["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetTablePropertiessearchParentElementJABHandle);
            if (jABGetTablePropertiessearchElementJABName != null)
            {
                jABGetTableProperties["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetTablePropertiessearchElementJABName);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiessearchElementJABDescription != null)
            {
                jABGetTableProperties["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetTablePropertiessearchElementJABDescription);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiessearchElementJABRole != null)
            {
                jABGetTableProperties["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetTablePropertiessearchElementJABRole);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiessearchSubTree != null)
            {
                if (jABGetTablePropertiessearchSubTree != null)
                {
                    jABGetTableProperties["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetTablePropertiessearchSubTree);
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
                    jABGetTableProperties["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetTablePropertiesmaxRelativeDepth);
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
                    jABGetTableProperties["MatchIndex"] = ExpressionConverter.ConvertO(jABGetTablePropertiesmatchIndex);
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
                jABGetTableProperties["SearchFilter"] = ExpressionConverter.ConvertO(jABGetTablePropertiessearchFilter);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiessortByColumn != null)
            {
                jABGetTableProperties["SortByColumn"] = ExpressionConverter.ConvertO(jABGetTablePropertiessortByColumn);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesmatchIndexAscending != null)
            {
                if (jABGetTablePropertiesmatchIndexAscending != null)
                {
                    jABGetTableProperties["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetTablePropertiesmatchIndexAscending);
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
                    jABGetTableProperties["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetTablePropertiescaseSensitiveSearch);
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
                    jABGetTableProperties["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetTablePropertiesonlySearchVisibleElements);
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
                    jABGetTableProperties["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetTablePropertiesonlySearchShowingElements);
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
                jABGetTableProperties["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetTablePropertieselementRolesNotToTraverse);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesmaximumElementsToSearch != null)
            {
                if (jABGetTablePropertiesmaximumElementsToSearch != null)
                {
                    jABGetTableProperties["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetTablePropertiesmaximumElementsToSearch);
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
                    jABGetTableProperties["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetTablePropertiesmaximumChildElementsToSearchPerNode);
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
                    jABGetTableProperties["EnumerateViewport"] = ExpressionConverter.ConvertO(jABGetTablePropertiesenumerateViewport);
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
                    jABGetTableProperties["ProcessViewportParents"] = ExpressionConverter.ConvertO(jABGetTablePropertiesprocessViewportParents);
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
                    jABGetTableProperties["MaxViewportParentsToProcess"] = ExpressionConverter.ConvertO(jABGetTablePropertiesmaxViewportParentsToProcess);
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
                    jABGetTableProperties["ViewportParentElementRolesToConsider"] = ExpressionConverter.ConvertO(jABGetTablePropertiesviewportParentElementRolesToConsider);
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
                    jABGetTableProperties["ViewportLeftMargin"] = ExpressionConverter.ConvertO(jABGetTablePropertiesviewportLeftMargin);
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
                    jABGetTableProperties["ViewportTopMargin"] = ExpressionConverter.ConvertO(jABGetTablePropertiesviewportTopMargin);
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
                    jABGetTableProperties["ViewportRightMargin"] = ExpressionConverter.ConvertO(jABGetTablePropertiesviewportRightMargin);
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
                    jABGetTableProperties["ViewportBottomMargin"] = ExpressionConverter.ConvertO(jABGetTablePropertiesviewportBottomMargin);
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
            jABGetTableProperties["Workflow"] = ExpressionConverter.ConvertO(jABGetTablePropertiesworkflow);
            if (jABGetTablePropertiespropCount > 0)
            {
                callPayload.Body = jABGetTableProperties;
            }

            return new ApiConnectionAction<JABGetTablePropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetTableCellPropertiesResponse> JABGetTableCellProperties(Expression<Func<int>> jABGetTableCellPropertiessearchParentElementJABHandle, Expression<Func<int>> jABGetTableCellPropertiesrowIndex, Expression<Func<int>> jABGetTableCellPropertiescolumnIndex, Expression<Func<string>> jABGetTableCellPropertiesworkflow, Expression<Func<string>> jABGetTableCellPropertiessearchElementJABName = null, Expression<Func<string>> jABGetTableCellPropertiessearchElementJABDescription = null, Expression<Func<string>> jABGetTableCellPropertiessearchElementJABRole = null, Expression<Func<bool>> jABGetTableCellPropertiessearchSubTree = null, Expression<Func<int>> jABGetTableCellPropertiesmaxRelativeDepth = null, Expression<Func<int>> jABGetTableCellPropertiesmatchIndex = null, Expression<Func<string>> jABGetTableCellPropertiessearchFilter = null, Expression<Func<string>> jABGetTableCellPropertiessortByColumn = null, Expression<Func<bool>> jABGetTableCellPropertiesmatchIndexAscending = null, Expression<Func<bool>> jABGetTableCellPropertiescaseSensitiveSearch = null, Expression<Func<bool>> jABGetTableCellPropertiesonlySearchVisibleElements = null, Expression<Func<bool>> jABGetTableCellPropertiesonlySearchShowingElements = null, Expression<Func<string>> jABGetTableCellPropertieselementRolesNotToTraverse = null, Expression<Func<int>> jABGetTableCellPropertiesmaximumElementsToSearch = null, Expression<Func<int>> jABGetTableCellPropertiesmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGetTableCellPropertiesreturnJABHandle = null, Expression<Func<bool>> jABGetTableCellPropertiesenumerateViewport = null, Expression<Func<bool>> jABGetTableCellPropertiesprocessViewportParents = null, Expression<Func<int>> jABGetTableCellPropertiesmaxViewportParentsToProcess = null, Expression<Func<string>> jABGetTableCellPropertiesviewportParentElementRolesToConsider = null, Expression<Func<int>> jABGetTableCellPropertiesviewportLeftMargin = null, Expression<Func<int>> jABGetTableCellPropertiesviewportTopMargin = null, Expression<Func<int>> jABGetTableCellPropertiesviewportRightMargin = null, Expression<Func<int>> jABGetTableCellPropertiesviewportBottomMargin = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetTableCellProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetTableCellProperties = new JObject();
            var jABGetTableCellPropertiespropCount = 0;
            jABGetTableCellPropertiespropCount++;
            jABGetTableCellProperties["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiessearchParentElementJABHandle);
            if (jABGetTableCellPropertiessearchElementJABName != null)
            {
                jABGetTableCellProperties["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiessearchElementJABName);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiessearchElementJABDescription != null)
            {
                jABGetTableCellProperties["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiessearchElementJABDescription);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiessearchElementJABRole != null)
            {
                jABGetTableCellProperties["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiessearchElementJABRole);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiessearchSubTree != null)
            {
                if (jABGetTableCellPropertiessearchSubTree != null)
                {
                    jABGetTableCellProperties["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiessearchSubTree);
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
                    jABGetTableCellProperties["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesmaxRelativeDepth);
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
                    jABGetTableCellProperties["MatchIndex"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesmatchIndex);
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
                jABGetTableCellProperties["SearchFilter"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiessearchFilter);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiessortByColumn != null)
            {
                jABGetTableCellProperties["SortByColumn"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiessortByColumn);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesmatchIndexAscending != null)
            {
                if (jABGetTableCellPropertiesmatchIndexAscending != null)
                {
                    jABGetTableCellProperties["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesmatchIndexAscending);
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
                    jABGetTableCellProperties["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiescaseSensitiveSearch);
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
                    jABGetTableCellProperties["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesonlySearchVisibleElements);
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
                    jABGetTableCellProperties["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesonlySearchShowingElements);
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
                jABGetTableCellProperties["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetTableCellPropertieselementRolesNotToTraverse);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesmaximumElementsToSearch != null)
            {
                if (jABGetTableCellPropertiesmaximumElementsToSearch != null)
                {
                    jABGetTableCellProperties["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesmaximumElementsToSearch);
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
                    jABGetTableCellProperties["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesmaximumChildElementsToSearchPerNode);
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
            jABGetTableCellProperties["RowIndex"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesrowIndex);
            jABGetTableCellPropertiespropCount++;
            jABGetTableCellProperties["ColumnIndex"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiescolumnIndex);
            if (jABGetTableCellPropertiesreturnJABHandle != null)
            {
                if (jABGetTableCellPropertiesreturnJABHandle != null)
                {
                    jABGetTableCellProperties["ReturnJABHandle"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesreturnJABHandle);
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
                    jABGetTableCellProperties["EnumerateViewport"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesenumerateViewport);
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
                    jABGetTableCellProperties["ProcessViewportParents"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesprocessViewportParents);
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
                    jABGetTableCellProperties["MaxViewportParentsToProcess"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesmaxViewportParentsToProcess);
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
                    jABGetTableCellProperties["ViewportParentElementRolesToConsider"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesviewportParentElementRolesToConsider);
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
                    jABGetTableCellProperties["ViewportLeftMargin"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesviewportLeftMargin);
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
                    jABGetTableCellProperties["ViewportTopMargin"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesviewportTopMargin);
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
                    jABGetTableCellProperties["ViewportRightMargin"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesviewportRightMargin);
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
                    jABGetTableCellProperties["ViewportBottomMargin"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesviewportBottomMargin);
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
            jABGetTableCellProperties["Workflow"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesworkflow);
            if (jABGetTableCellPropertiespropCount > 0)
            {
                callPayload.Body = jABGetTableCellProperties;
            }

            return new ApiConnectionAction<JABGetTableCellPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetTableContentsResponse> JABGetTableContents(Expression<Func<int>> jABGetTableContentssearchParentElementJABHandle, Expression<Func<string>> jABGetTableContentsworkflow, Expression<Func<string>> jABGetTableContentssearchElementJABName = null, Expression<Func<string>> jABGetTableContentssearchElementJABDescription = null, Expression<Func<string>> jABGetTableContentssearchElementJABRole = null, Expression<Func<bool>> jABGetTableContentssearchSubTree = null, Expression<Func<int>> jABGetTableContentsmaxRelativeDepth = null, Expression<Func<int>> jABGetTableContentsmatchIndex = null, Expression<Func<string>> jABGetTableContentssearchFilter = null, Expression<Func<string>> jABGetTableContentssortByColumn = null, Expression<Func<bool>> jABGetTableContentsmatchIndexAscending = null, Expression<Func<bool>> jABGetTableContentscaseSensitiveSearch = null, Expression<Func<bool>> jABGetTableContentsonlySearchVisibleElements = null, Expression<Func<bool>> jABGetTableContentsonlySearchShowingElements = null, Expression<Func<string>> jABGetTableContentselementRolesNotToTraverse = null, Expression<Func<int>> jABGetTableContentsmaximumElementsToSearch = null, Expression<Func<int>> jABGetTableContentsmaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABGetTableContentsfirstRowToReturn = null, Expression<Func<int>> jABGetTableContentsmaxRowsToReturn = null, Expression<Func<int>> jABGetTableContentsfirstColumnToReturn = null, Expression<Func<int>> jABGetTableContentsmaxColumnsToReturn = null, Expression<Func<bool>> jABGetTableContentsuseColumnHeadersFromTable = null, Expression<Func<bool>> jABGetTableContentsreturnRowIndexInOutputCollection = null, Expression<Func<string>> jABGetTableContentsnameOfColumnToStoreRowIndex = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetTableContents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetTableContents = new JObject();
            var jABGetTableContentspropCount = 0;
            jABGetTableContentspropCount++;
            jABGetTableContents["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetTableContentssearchParentElementJABHandle);
            if (jABGetTableContentssearchElementJABName != null)
            {
                jABGetTableContents["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetTableContentssearchElementJABName);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentssearchElementJABDescription != null)
            {
                jABGetTableContents["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetTableContentssearchElementJABDescription);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentssearchElementJABRole != null)
            {
                jABGetTableContents["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetTableContentssearchElementJABRole);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentssearchSubTree != null)
            {
                if (jABGetTableContentssearchSubTree != null)
                {
                    jABGetTableContents["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetTableContentssearchSubTree);
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
                    jABGetTableContents["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetTableContentsmaxRelativeDepth);
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
                    jABGetTableContents["MatchIndex"] = ExpressionConverter.ConvertO(jABGetTableContentsmatchIndex);
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
                jABGetTableContents["SearchFilter"] = ExpressionConverter.ConvertO(jABGetTableContentssearchFilter);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentssortByColumn != null)
            {
                jABGetTableContents["SortByColumn"] = ExpressionConverter.ConvertO(jABGetTableContentssortByColumn);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsmatchIndexAscending != null)
            {
                if (jABGetTableContentsmatchIndexAscending != null)
                {
                    jABGetTableContents["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetTableContentsmatchIndexAscending);
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
                    jABGetTableContents["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetTableContentscaseSensitiveSearch);
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
                    jABGetTableContents["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetTableContentsonlySearchVisibleElements);
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
                    jABGetTableContents["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetTableContentsonlySearchShowingElements);
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
                jABGetTableContents["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetTableContentselementRolesNotToTraverse);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsmaximumElementsToSearch != null)
            {
                if (jABGetTableContentsmaximumElementsToSearch != null)
                {
                    jABGetTableContents["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetTableContentsmaximumElementsToSearch);
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
                    jABGetTableContents["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetTableContentsmaximumChildElementsToSearchPerNode);
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
                    jABGetTableContents["FirstRowToReturn"] = ExpressionConverter.ConvertO(jABGetTableContentsfirstRowToReturn);
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
                    jABGetTableContents["MaxRowsToReturn"] = ExpressionConverter.ConvertO(jABGetTableContentsmaxRowsToReturn);
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
                    jABGetTableContents["FirstColumnToReturn"] = ExpressionConverter.ConvertO(jABGetTableContentsfirstColumnToReturn);
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
                    jABGetTableContents["MaxColumnsToReturn"] = ExpressionConverter.ConvertO(jABGetTableContentsmaxColumnsToReturn);
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
                    jABGetTableContents["UseColumnHeadersFromTable"] = ExpressionConverter.ConvertO(jABGetTableContentsuseColumnHeadersFromTable);
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
                    jABGetTableContents["ReturnRowIndexInOutputCollection"] = ExpressionConverter.ConvertO(jABGetTableContentsreturnRowIndexInOutputCollection);
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
                jABGetTableContents["NameOfColumnToStoreRowIndex"] = ExpressionConverter.ConvertO(jABGetTableContentsnameOfColumnToStoreRowIndex);
                jABGetTableContentspropCount++;
            }

            jABGetTableContentspropCount++;
            jABGetTableContents["Workflow"] = ExpressionConverter.ConvertO(jABGetTableContentsworkflow);
            if (jABGetTableContentspropCount > 0)
            {
                callPayload.Body = jABGetTableContents;
            }

            return new ApiConnectionAction<JABGetTableContentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABIsTableCellVisibleOnscreenResponse> JABIsTableCellVisibleOnscreen(Expression<Func<int>> jABIsTableCellVisibleOnscreensearchParentElementJABHandle, Expression<Func<int>> jABIsTableCellVisibleOnscreencellRowIndex, Expression<Func<int>> jABIsTableCellVisibleOnscreencellColumnIndex, Expression<Func<string>> jABIsTableCellVisibleOnscreenworkflow, Expression<Func<string>> jABIsTableCellVisibleOnscreensearchElementJABName = null, Expression<Func<string>> jABIsTableCellVisibleOnscreensearchElementJABDescription = null, Expression<Func<string>> jABIsTableCellVisibleOnscreensearchElementJABRole = null, Expression<Func<bool>> jABIsTableCellVisibleOnscreensearchSubTree = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenmaxRelativeDepth = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenmatchIndex = null, Expression<Func<string>> jABIsTableCellVisibleOnscreensearchFilter = null, Expression<Func<string>> jABIsTableCellVisibleOnscreensortByColumn = null, Expression<Func<bool>> jABIsTableCellVisibleOnscreenmatchIndexAscending = null, Expression<Func<bool>> jABIsTableCellVisibleOnscreencaseSensitiveSearch = null, Expression<Func<bool>> jABIsTableCellVisibleOnscreenonlySearchVisibleElements = null, Expression<Func<bool>> jABIsTableCellVisibleOnscreenonlySearchShowingElements = null, Expression<Func<string>> jABIsTableCellVisibleOnscreenelementRolesNotToTraverse = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenmaximumElementsToSearch = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABIsTableCellVisibleOnscreenprocessViewportParents = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenmaxViewportParentsToProcess = null, Expression<Func<string>> jABIsTableCellVisibleOnscreenviewportParentElementRolesToConsider = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenviewportLeftMargin = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenviewportTopMargin = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenviewportRightMargin = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenviewportBottomMargin = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABIsTableCellVisibleOnscreen";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABIsTableCellVisibleOnscreen = new JObject();
            var jABIsTableCellVisibleOnscreenpropCount = 0;
            jABIsTableCellVisibleOnscreenpropCount++;
            jABIsTableCellVisibleOnscreen["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreensearchParentElementJABHandle);
            if (jABIsTableCellVisibleOnscreensearchElementJABName != null)
            {
                jABIsTableCellVisibleOnscreen["SearchElementJABName"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreensearchElementJABName);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreensearchElementJABDescription != null)
            {
                jABIsTableCellVisibleOnscreen["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreensearchElementJABDescription);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreensearchElementJABRole != null)
            {
                jABIsTableCellVisibleOnscreen["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreensearchElementJABRole);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreensearchSubTree != null)
            {
                if (jABIsTableCellVisibleOnscreensearchSubTree != null)
                {
                    jABIsTableCellVisibleOnscreen["SearchSubTree"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreensearchSubTree);
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
                    jABIsTableCellVisibleOnscreen["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenmaxRelativeDepth);
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
                    jABIsTableCellVisibleOnscreen["MatchIndex"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenmatchIndex);
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
                jABIsTableCellVisibleOnscreen["SearchFilter"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreensearchFilter);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreensortByColumn != null)
            {
                jABIsTableCellVisibleOnscreen["SortByColumn"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreensortByColumn);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenmatchIndexAscending != null)
            {
                if (jABIsTableCellVisibleOnscreenmatchIndexAscending != null)
                {
                    jABIsTableCellVisibleOnscreen["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenmatchIndexAscending);
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
                    jABIsTableCellVisibleOnscreen["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreencaseSensitiveSearch);
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
                    jABIsTableCellVisibleOnscreen["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenonlySearchVisibleElements);
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
                    jABIsTableCellVisibleOnscreen["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenonlySearchShowingElements);
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
                jABIsTableCellVisibleOnscreen["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenelementRolesNotToTraverse);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenmaximumElementsToSearch != null)
            {
                if (jABIsTableCellVisibleOnscreenmaximumElementsToSearch != null)
                {
                    jABIsTableCellVisibleOnscreen["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenmaximumElementsToSearch);
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
                    jABIsTableCellVisibleOnscreen["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenmaximumChildElementsToSearchPerNode);
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
                    jABIsTableCellVisibleOnscreen["ProcessViewportParents"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenprocessViewportParents);
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
                    jABIsTableCellVisibleOnscreen["MaxViewportParentsToProcess"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenmaxViewportParentsToProcess);
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
                    jABIsTableCellVisibleOnscreen["ViewportParentElementRolesToConsider"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenviewportParentElementRolesToConsider);
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
                    jABIsTableCellVisibleOnscreen["ViewportLeftMargin"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenviewportLeftMargin);
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
                    jABIsTableCellVisibleOnscreen["ViewportTopMargin"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenviewportTopMargin);
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
                    jABIsTableCellVisibleOnscreen["ViewportRightMargin"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenviewportRightMargin);
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
                    jABIsTableCellVisibleOnscreen["ViewportBottomMargin"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenviewportBottomMargin);
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
            jABIsTableCellVisibleOnscreen["CellRowIndex"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreencellRowIndex);
            jABIsTableCellVisibleOnscreenpropCount++;
            jABIsTableCellVisibleOnscreen["CellColumnIndex"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreencellColumnIndex);
            jABIsTableCellVisibleOnscreenpropCount++;
            jABIsTableCellVisibleOnscreen["Workflow"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenworkflow);
            if (jABIsTableCellVisibleOnscreenpropCount > 0)
            {
                callPayload.Body = jABIsTableCellVisibleOnscreen;
            }

            return new ApiConnectionAction<JABIsTableCellVisibleOnscreenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABIsJABHandleSameObjectResponse> JABIsJABHandleSameObject(Expression<Func<int>> jABIsJABHandleSameObjectelement1JABHandle, Expression<Func<int>> jABIsJABHandleSameObjectelement2JABHandle, Expression<Func<string>> jABIsJABHandleSameObjectworkflow)
        {
            var apiCallPath = "/JavaAccessBridge/JABIsJABHandleSameObject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABIsJABHandleSameObject = new JObject();
            var jABIsJABHandleSameObjectpropCount = 0;
            jABIsJABHandleSameObjectpropCount++;
            jABIsJABHandleSameObject["Element1JABHandle"] = ExpressionConverter.ConvertO(jABIsJABHandleSameObjectelement1JABHandle);
            jABIsJABHandleSameObjectpropCount++;
            jABIsJABHandleSameObject["Element2JABHandle"] = ExpressionConverter.ConvertO(jABIsJABHandleSameObjectelement2JABHandle);
            jABIsJABHandleSameObjectpropCount++;
            jABIsJABHandleSameObject["Workflow"] = ExpressionConverter.ConvertO(jABIsJABHandleSameObjectworkflow);
            if (jABIsJABHandleSameObjectpropCount > 0)
            {
                callPayload.Body = jABIsJABHandleSameObject;
            }

            return new ApiConnectionAction<JABIsJABHandleSameObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetVisibleBoundingRectangleOfElementOnscreenResponse> JABGetVisibleBoundingRectangleOfElementOnscreen(Expression<Func<int>> jABGetVisibleBoundingRectangleOfElementOnscreenelementJABHandle, Expression<Func<string>> jABGetVisibleBoundingRectangleOfElementOnscreenworkflow, Expression<Func<int>> jABGetVisibleBoundingRectangleOfElementOnscreenmaxParentsToProcess = null, Expression<Func<string>> jABGetVisibleBoundingRectangleOfElementOnscreenparentElementRolesToConsider = null, Expression<Func<bool>> jABGetVisibleBoundingRectangleOfElementOnscreendrawRectangle = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetVisibleBoundingRectangleOfElementOnscreen";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetVisibleBoundingRectangleOfElementOnscreen = new JObject();
            var jABGetVisibleBoundingRectangleOfElementOnscreenpropCount = 0;
            jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
            jABGetVisibleBoundingRectangleOfElementOnscreen["ElementJABHandle"] = ExpressionConverter.ConvertO(jABGetVisibleBoundingRectangleOfElementOnscreenelementJABHandle);
            if (jABGetVisibleBoundingRectangleOfElementOnscreenmaxParentsToProcess != null)
            {
                if (jABGetVisibleBoundingRectangleOfElementOnscreenmaxParentsToProcess != null)
                {
                    jABGetVisibleBoundingRectangleOfElementOnscreen["MaxParentsToProcess"] = ExpressionConverter.ConvertO(jABGetVisibleBoundingRectangleOfElementOnscreenmaxParentsToProcess);
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
                    jABGetVisibleBoundingRectangleOfElementOnscreen["ParentElementRolesToConsider"] = ExpressionConverter.ConvertO(jABGetVisibleBoundingRectangleOfElementOnscreenparentElementRolesToConsider);
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
                    jABGetVisibleBoundingRectangleOfElementOnscreen["DrawRectangle"] = ExpressionConverter.ConvertO(jABGetVisibleBoundingRectangleOfElementOnscreendrawRectangle);
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
            jABGetVisibleBoundingRectangleOfElementOnscreen["Workflow"] = ExpressionConverter.ConvertO(jABGetVisibleBoundingRectangleOfElementOnscreenworkflow);
            if (jABGetVisibleBoundingRectangleOfElementOnscreenpropCount > 0)
            {
                callPayload.Body = jABGetVisibleBoundingRectangleOfElementOnscreen;
            }

            return new ApiConnectionAction<JABGetVisibleBoundingRectangleOfElementOnscreenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABCreateHandleForJABElementAtScreenCoordinateResponse> JABCreateHandleForJABElementAtScreenCoordinate(Expression<Func<int>> jABCreateHandleForJABElementAtScreenCoordinateparentElementJABHandle, Expression<Func<int>> jABCreateHandleForJABElementAtScreenCoordinatescreenX, Expression<Func<int>> jABCreateHandleForJABElementAtScreenCoordinatescreenY, Expression<Func<string>> jABCreateHandleForJABElementAtScreenCoordinateworkflow)
        {
            var apiCallPath = "/JavaAccessBridge/JABCreateHandleForJABElementAtScreenCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABCreateHandleForJABElementAtScreenCoordinate = new JObject();
            var jABCreateHandleForJABElementAtScreenCoordinatepropCount = 0;
            jABCreateHandleForJABElementAtScreenCoordinatepropCount++;
            jABCreateHandleForJABElementAtScreenCoordinate["ParentElementJABHandle"] = ExpressionConverter.ConvertO(jABCreateHandleForJABElementAtScreenCoordinateparentElementJABHandle);
            jABCreateHandleForJABElementAtScreenCoordinatepropCount++;
            jABCreateHandleForJABElementAtScreenCoordinate["ScreenX"] = ExpressionConverter.ConvertO(jABCreateHandleForJABElementAtScreenCoordinatescreenX);
            jABCreateHandleForJABElementAtScreenCoordinatepropCount++;
            jABCreateHandleForJABElementAtScreenCoordinate["ScreenY"] = ExpressionConverter.ConvertO(jABCreateHandleForJABElementAtScreenCoordinatescreenY);
            jABCreateHandleForJABElementAtScreenCoordinatepropCount++;
            jABCreateHandleForJABElementAtScreenCoordinate["Workflow"] = ExpressionConverter.ConvertO(jABCreateHandleForJABElementAtScreenCoordinateworkflow);
            if (jABCreateHandleForJABElementAtScreenCoordinatepropCount > 0)
            {
                callPayload.Body = jABCreateHandleForJABElementAtScreenCoordinate;
            }

            return new ApiConnectionAction<JABCreateHandleForJABElementAtScreenCoordinateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetTableCellAtScreenCoordinateResponse> JABGetTableCellAtScreenCoordinate(Expression<Func<int>> jABGetTableCellAtScreenCoordinatetableElementJABHandle, Expression<Func<int>> jABGetTableCellAtScreenCoordinatescreenX, Expression<Func<int>> jABGetTableCellAtScreenCoordinatescreenY, Expression<Func<string>> jABGetTableCellAtScreenCoordinateworkflow, Expression<Func<bool>> jABGetTableCellAtScreenCoordinatereturnJABHandle = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetTableCellAtScreenCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetTableCellAtScreenCoordinate = new JObject();
            var jABGetTableCellAtScreenCoordinatepropCount = 0;
            jABGetTableCellAtScreenCoordinatepropCount++;
            jABGetTableCellAtScreenCoordinate["TableElementJABHandle"] = ExpressionConverter.ConvertO(jABGetTableCellAtScreenCoordinatetableElementJABHandle);
            jABGetTableCellAtScreenCoordinatepropCount++;
            jABGetTableCellAtScreenCoordinate["ScreenX"] = ExpressionConverter.ConvertO(jABGetTableCellAtScreenCoordinatescreenX);
            jABGetTableCellAtScreenCoordinatepropCount++;
            jABGetTableCellAtScreenCoordinate["ScreenY"] = ExpressionConverter.ConvertO(jABGetTableCellAtScreenCoordinatescreenY);
            if (jABGetTableCellAtScreenCoordinatereturnJABHandle != null)
            {
                if (jABGetTableCellAtScreenCoordinatereturnJABHandle != null)
                {
                    jABGetTableCellAtScreenCoordinate["ReturnJABHandle"] = ExpressionConverter.ConvertO(jABGetTableCellAtScreenCoordinatereturnJABHandle);
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
            jABGetTableCellAtScreenCoordinate["Workflow"] = ExpressionConverter.ConvertO(jABGetTableCellAtScreenCoordinateworkflow);
            if (jABGetTableCellAtScreenCoordinatepropCount > 0)
            {
                callPayload.Body = jABGetTableCellAtScreenCoordinate;
            }

            return new ApiConnectionAction<JABGetTableCellAtScreenCoordinateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetMultipleParentJABElementPropertiesResponse> JABGetMultipleParentJABElementProperties(Expression<Func<int>> jABGetMultipleParentJABElementPropertiessearchElementJABHandle, Expression<Func<string>> jABGetMultipleParentJABElementPropertiesworkflow, Expression<Func<int>> jABGetMultipleParentJABElementPropertiesmaxStringLength = null, Expression<Func<int>> jABGetMultipleParentJABElementPropertiesmaxParentsToProcess = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetMultipleParentJABElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetMultipleParentJABElementProperties = new JObject();
            var jABGetMultipleParentJABElementPropertiespropCount = 0;
            jABGetMultipleParentJABElementPropertiespropCount++;
            jABGetMultipleParentJABElementProperties["SearchElementJABHandle"] = ExpressionConverter.ConvertO(jABGetMultipleParentJABElementPropertiessearchElementJABHandle);
            if (jABGetMultipleParentJABElementPropertiesmaxStringLength != null)
            {
                if (jABGetMultipleParentJABElementPropertiesmaxStringLength != null)
                {
                    jABGetMultipleParentJABElementProperties["MaxStringLength"] = ExpressionConverter.ConvertO(jABGetMultipleParentJABElementPropertiesmaxStringLength);
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
                    jABGetMultipleParentJABElementProperties["MaxParentsToProcess"] = ExpressionConverter.ConvertO(jABGetMultipleParentJABElementPropertiesmaxParentsToProcess);
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
            jABGetMultipleParentJABElementProperties["Workflow"] = ExpressionConverter.ConvertO(jABGetMultipleParentJABElementPropertiesworkflow);
            if (jABGetMultipleParentJABElementPropertiespropCount > 0)
            {
                callPayload.Body = jABGetMultipleParentJABElementProperties;
            }

            return new ApiConnectionAction<JABGetMultipleParentJABElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalMouseClickOnTableCell(Expression<Func<int>> jABGlobalMouseClickOnTableCellsearchParentElementJABHandle, Expression<Func<int>> jABGlobalMouseClickOnTableCellrowIndex, Expression<Func<int>> jABGlobalMouseClickOnTableCellcolumnIndex, Expression<Func<int>> jABGlobalMouseClickOnTableCellmouseButton, Expression<Func<string>> jABGlobalMouseClickOnTableCellworkflow, Expression<Func<string>> jABGlobalMouseClickOnTableCellsearchElementJABName = null, Expression<Func<string>> jABGlobalMouseClickOnTableCellsearchElementJABDescription = null, Expression<Func<string>> jABGlobalMouseClickOnTableCellsearchElementJABRole = null, Expression<Func<bool>> jABGlobalMouseClickOnTableCellsearchSubTree = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellmaxRelativeDepth = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellmatchIndex = null, Expression<Func<string>> jABGlobalMouseClickOnTableCellsearchFilter = null, Expression<Func<string>> jABGlobalMouseClickOnTableCellsortByColumn = null, Expression<Func<bool>> jABGlobalMouseClickOnTableCellmatchIndexAscending = null, Expression<Func<bool>> jABGlobalMouseClickOnTableCellcaseSensitiveSearch = null, Expression<Func<bool>> jABGlobalMouseClickOnTableCellonlySearchVisibleElements = null, Expression<Func<bool>> jABGlobalMouseClickOnTableCellonlySearchShowingElements = null, Expression<Func<string>> jABGlobalMouseClickOnTableCellelementRolesNotToTraverse = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellmaximumElementsToSearch = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGlobalMouseClickOnTableCellenumerateViewport = null, Expression<Func<bool>> jABGlobalMouseClickOnTableCellprocessViewportParents = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellmaxViewportParentsToProcess = null, Expression<Func<string>> jABGlobalMouseClickOnTableCellviewportParentElementRolesToConsider = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellviewportLeftMargin = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellviewportTopMargin = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellviewportRightMargin = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellviewportBottomMargin = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellclickOffsetX = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellclickOffsetY = null, Expression<Func<jABGlobalMouseClickOnTableCelloffsetRelativeToInput>> jABGlobalMouseClickOnTableCelloffsetRelativeTo = null, Expression<Func<int>> jABGlobalMouseClickOnTableCelldelayInMilliseconds = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGlobalMouseClickOnTableCell";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGlobalMouseClickOnTableCell = new JObject();
            var jABGlobalMouseClickOnTableCellpropCount = 0;
            jABGlobalMouseClickOnTableCellpropCount++;
            jABGlobalMouseClickOnTableCell["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellsearchParentElementJABHandle);
            if (jABGlobalMouseClickOnTableCellsearchElementJABName != null)
            {
                jABGlobalMouseClickOnTableCell["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellsearchElementJABName);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellsearchElementJABDescription != null)
            {
                jABGlobalMouseClickOnTableCell["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellsearchElementJABDescription);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellsearchElementJABRole != null)
            {
                jABGlobalMouseClickOnTableCell["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellsearchElementJABRole);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellsearchSubTree != null)
            {
                if (jABGlobalMouseClickOnTableCellsearchSubTree != null)
                {
                    jABGlobalMouseClickOnTableCell["SearchSubTree"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellsearchSubTree);
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
                    jABGlobalMouseClickOnTableCell["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellmaxRelativeDepth);
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
                    jABGlobalMouseClickOnTableCell["MatchIndex"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellmatchIndex);
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
                jABGlobalMouseClickOnTableCell["SearchFilter"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellsearchFilter);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellsortByColumn != null)
            {
                jABGlobalMouseClickOnTableCell["SortByColumn"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellsortByColumn);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellmatchIndexAscending != null)
            {
                if (jABGlobalMouseClickOnTableCellmatchIndexAscending != null)
                {
                    jABGlobalMouseClickOnTableCell["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellmatchIndexAscending);
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
                    jABGlobalMouseClickOnTableCell["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellcaseSensitiveSearch);
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
                    jABGlobalMouseClickOnTableCell["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellonlySearchVisibleElements);
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
                    jABGlobalMouseClickOnTableCell["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellonlySearchShowingElements);
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
                jABGlobalMouseClickOnTableCell["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellelementRolesNotToTraverse);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellmaximumElementsToSearch != null)
            {
                if (jABGlobalMouseClickOnTableCellmaximumElementsToSearch != null)
                {
                    jABGlobalMouseClickOnTableCell["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellmaximumElementsToSearch);
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
                    jABGlobalMouseClickOnTableCell["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellmaximumChildElementsToSearchPerNode);
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
            jABGlobalMouseClickOnTableCell["RowIndex"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellrowIndex);
            jABGlobalMouseClickOnTableCellpropCount++;
            jABGlobalMouseClickOnTableCell["ColumnIndex"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellcolumnIndex);
            if (jABGlobalMouseClickOnTableCellenumerateViewport != null)
            {
                if (jABGlobalMouseClickOnTableCellenumerateViewport != null)
                {
                    jABGlobalMouseClickOnTableCell["EnumerateViewport"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellenumerateViewport);
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
                    jABGlobalMouseClickOnTableCell["ProcessViewportParents"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellprocessViewportParents);
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
                    jABGlobalMouseClickOnTableCell["MaxViewportParentsToProcess"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellmaxViewportParentsToProcess);
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
                    jABGlobalMouseClickOnTableCell["ViewportParentElementRolesToConsider"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellviewportParentElementRolesToConsider);
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
                    jABGlobalMouseClickOnTableCell["ViewportLeftMargin"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellviewportLeftMargin);
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
                    jABGlobalMouseClickOnTableCell["ViewportTopMargin"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellviewportTopMargin);
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
                    jABGlobalMouseClickOnTableCell["ViewportRightMargin"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellviewportRightMargin);
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
                    jABGlobalMouseClickOnTableCell["ViewportBottomMargin"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellviewportBottomMargin);
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
            jABGlobalMouseClickOnTableCell["MouseButton"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellmouseButton);
            if (jABGlobalMouseClickOnTableCellclickOffsetX != null)
            {
                if (jABGlobalMouseClickOnTableCellclickOffsetX != null)
                {
                    jABGlobalMouseClickOnTableCell["ClickOffsetX"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellclickOffsetX);
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
                    jABGlobalMouseClickOnTableCell["ClickOffsetY"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellclickOffsetY);
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
                jABGlobalMouseClickOnTableCell["OffsetRelativeTo"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCelloffsetRelativeTo);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCelldelayInMilliseconds != null)
            {
                if (jABGlobalMouseClickOnTableCelldelayInMilliseconds != null)
                {
                    jABGlobalMouseClickOnTableCell["DelayInMilliseconds"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCelldelayInMilliseconds);
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
            jABGlobalMouseClickOnTableCell["Workflow"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellworkflow);
            if (jABGlobalMouseClickOnTableCellpropCount > 0)
            {
                callPayload.Body = jABGlobalMouseClickOnTableCell;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetRoleCSVFromElementSearchResponse> JABGetRoleCSVFromElementSearch(Expression<Func<int>> jABGetRoleCSVFromElementSearchsearchParentElementJABHandle, Expression<Func<string>> jABGetRoleCSVFromElementSearchworkflow, Expression<Func<string>> jABGetRoleCSVFromElementSearchsearchElementJABName = null, Expression<Func<string>> jABGetRoleCSVFromElementSearchsearchElementJABDescription = null, Expression<Func<string>> jABGetRoleCSVFromElementSearchsearchElementJABRole = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchsearchSubTree = null, Expression<Func<int>> jABGetRoleCSVFromElementSearchmaxRelativeDepth = null, Expression<Func<int>> jABGetRoleCSVFromElementSearchmatchIndex = null, Expression<Func<string>> jABGetRoleCSVFromElementSearchsearchFilter = null, Expression<Func<string>> jABGetRoleCSVFromElementSearchsortByColumn = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchmatchIndexAscending = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchcaseSensitiveSearch = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchonlySearchVisibleElements = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchonlySearchShowingElements = null, Expression<Func<string>> jABGetRoleCSVFromElementSearchelementRolesNotToTraverse = null, Expression<Func<int>> jABGetRoleCSVFromElementSearchmaximumElementsToSearch = null, Expression<Func<int>> jABGetRoleCSVFromElementSearchmaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchindentRoleInCSV = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchincludeDescriptionInCSV = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchincludeDimensionsInCSV = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetRoleCSVFromElementSearch";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetRoleCSVFromElementSearch = new JObject();
            var jABGetRoleCSVFromElementSearchpropCount = 0;
            jABGetRoleCSVFromElementSearchpropCount++;
            jABGetRoleCSVFromElementSearch["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchsearchParentElementJABHandle);
            if (jABGetRoleCSVFromElementSearchsearchElementJABName != null)
            {
                jABGetRoleCSVFromElementSearch["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchsearchElementJABName);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchsearchElementJABDescription != null)
            {
                jABGetRoleCSVFromElementSearch["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchsearchElementJABDescription);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchsearchElementJABRole != null)
            {
                jABGetRoleCSVFromElementSearch["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchsearchElementJABRole);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchsearchSubTree != null)
            {
                if (jABGetRoleCSVFromElementSearchsearchSubTree != null)
                {
                    jABGetRoleCSVFromElementSearch["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchsearchSubTree);
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
                    jABGetRoleCSVFromElementSearch["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchmaxRelativeDepth);
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
                    jABGetRoleCSVFromElementSearch["MatchIndex"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchmatchIndex);
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
                jABGetRoleCSVFromElementSearch["SearchFilter"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchsearchFilter);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchsortByColumn != null)
            {
                jABGetRoleCSVFromElementSearch["SortByColumn"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchsortByColumn);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchmatchIndexAscending != null)
            {
                if (jABGetRoleCSVFromElementSearchmatchIndexAscending != null)
                {
                    jABGetRoleCSVFromElementSearch["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchmatchIndexAscending);
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
                    jABGetRoleCSVFromElementSearch["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchcaseSensitiveSearch);
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
                    jABGetRoleCSVFromElementSearch["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchonlySearchVisibleElements);
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
                    jABGetRoleCSVFromElementSearch["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchonlySearchShowingElements);
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
                jABGetRoleCSVFromElementSearch["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchelementRolesNotToTraverse);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchmaximumElementsToSearch != null)
            {
                if (jABGetRoleCSVFromElementSearchmaximumElementsToSearch != null)
                {
                    jABGetRoleCSVFromElementSearch["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchmaximumElementsToSearch);
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
                    jABGetRoleCSVFromElementSearch["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchmaximumChildElementsToSearchPerNode);
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
                    jABGetRoleCSVFromElementSearch["IndentRoleInCSV"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchindentRoleInCSV);
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
                    jABGetRoleCSVFromElementSearch["IncludeDescriptionInCSV"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchincludeDescriptionInCSV);
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
                    jABGetRoleCSVFromElementSearch["IncludeDimensionsInCSV"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchincludeDimensionsInCSV);
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
            jABGetRoleCSVFromElementSearch["Workflow"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchworkflow);
            if (jABGetRoleCSVFromElementSearchpropCount > 0)
            {
                callPayload.Body = jABGetRoleCSVFromElementSearch;
            }

            return new ApiConnectionAction<JABGetRoleCSVFromElementSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetRoleCSVFromElementHandleResponse> JABGetRoleCSVFromElementHandle(Expression<Func<int>> jABGetRoleCSVFromElementHandlesearchParentElementJABHandle, Expression<Func<string>> jABGetRoleCSVFromElementHandleworkflow, Expression<Func<bool>> jABGetRoleCSVFromElementHandlesearchSubTree = null, Expression<Func<int>> jABGetRoleCSVFromElementHandlemaxRelativeDepth = null, Expression<Func<bool>> jABGetRoleCSVFromElementHandleonlySearchVisibleElements = null, Expression<Func<bool>> jABGetRoleCSVFromElementHandleonlySearchShowingElements = null, Expression<Func<string>> jABGetRoleCSVFromElementHandleelementRolesNotToTraverse = null, Expression<Func<int>> jABGetRoleCSVFromElementHandlemaximumElementsToSearch = null, Expression<Func<int>> jABGetRoleCSVFromElementHandlemaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGetRoleCSVFromElementHandleindentRoleInCSV = null, Expression<Func<bool>> jABGetRoleCSVFromElementHandleincludeDescriptionInCSV = null, Expression<Func<bool>> jABGetRoleCSVFromElementHandleincludeDimensionsInCSV = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetRoleCSVFromElementHandle";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetRoleCSVFromElementHandle = new JObject();
            var jABGetRoleCSVFromElementHandlepropCount = 0;
            jABGetRoleCSVFromElementHandlepropCount++;
            jABGetRoleCSVFromElementHandle["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandlesearchParentElementJABHandle);
            if (jABGetRoleCSVFromElementHandlesearchSubTree != null)
            {
                if (jABGetRoleCSVFromElementHandlesearchSubTree != null)
                {
                    jABGetRoleCSVFromElementHandle["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandlesearchSubTree);
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
                    jABGetRoleCSVFromElementHandle["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandlemaxRelativeDepth);
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
                    jABGetRoleCSVFromElementHandle["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandleonlySearchVisibleElements);
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
                    jABGetRoleCSVFromElementHandle["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandleonlySearchShowingElements);
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
                jABGetRoleCSVFromElementHandle["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandleelementRolesNotToTraverse);
                jABGetRoleCSVFromElementHandlepropCount++;
            }

            if (jABGetRoleCSVFromElementHandlemaximumElementsToSearch != null)
            {
                if (jABGetRoleCSVFromElementHandlemaximumElementsToSearch != null)
                {
                    jABGetRoleCSVFromElementHandle["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandlemaximumElementsToSearch);
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
                    jABGetRoleCSVFromElementHandle["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandlemaximumChildElementsToSearchPerNode);
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
                    jABGetRoleCSVFromElementHandle["IndentRoleInCSV"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandleindentRoleInCSV);
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
                    jABGetRoleCSVFromElementHandle["IncludeDescriptionInCSV"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandleincludeDescriptionInCSV);
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
                    jABGetRoleCSVFromElementHandle["IncludeDimensionsInCSV"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandleincludeDimensionsInCSV);
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
            jABGetRoleCSVFromElementHandle["Workflow"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandleworkflow);
            if (jABGetRoleCSVFromElementHandlepropCount > 0)
            {
                callPayload.Body = jABGetRoleCSVFromElementHandle;
            }

            return new ApiConnectionAction<JABGetRoleCSVFromElementHandleResponse>(callPayload);
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