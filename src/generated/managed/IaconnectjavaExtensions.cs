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
        public IBodyWorkflowAction<JABConnectToJavaAccessBridgeResponse> JABConnectToJavaAccessBridge(Expression<Func<string>> jABConnectToJavaAccessBridgeWorkflow, Expression<Func<string>> jABConnectToJavaAccessBridgeWindowsAccessBridgeDLLSearchFolder = null, Expression<Func<string>> jABConnectToJavaAccessBridgeIAJavaAccessBridgePath = null, Expression<Func<bool>> jABConnectToJavaAccessBridgeIs64BitJABDLL = null, Expression<Func<bool>> jABConnectToJavaAccessBridgeUseCOMFor64BitJABDLL = null, Expression<Func<bool>> jABConnectToJavaAccessBridgeEnableJavaAccessBridge = null, Expression<Func<string>> jABConnectToJavaAccessBridgeAccessibilityFilepath = null, Expression<Func<int>> jABConnectToJavaAccessBridgeCommandTimeoutInSeconds = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABConnectToJavaAccessBridge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABConnectToJavaAccessBridge = new JObject();
            var jABConnectToJavaAccessBridgepropCount = 0;
            if (jABConnectToJavaAccessBridgeWindowsAccessBridgeDLLSearchFolder != null)
            {
                jABConnectToJavaAccessBridge["WindowsAccessBridgeDLLSearchFolder"] = ExpressionConverter.ConvertO(jABConnectToJavaAccessBridgeWindowsAccessBridgeDLLSearchFolder);
                jABConnectToJavaAccessBridgepropCount++;
            }

            if (jABConnectToJavaAccessBridgeIAJavaAccessBridgePath != null)
            {
                jABConnectToJavaAccessBridge["IAJavaAccessBridgePath"] = ExpressionConverter.ConvertO(jABConnectToJavaAccessBridgeIAJavaAccessBridgePath);
                jABConnectToJavaAccessBridgepropCount++;
            }

            if (jABConnectToJavaAccessBridgeIs64BitJABDLL != null)
            {
                jABConnectToJavaAccessBridge["Is64BitJABDLL"] = ExpressionConverter.ConvertO(jABConnectToJavaAccessBridgeIs64BitJABDLL);
                jABConnectToJavaAccessBridgepropCount++;
            }

            if (jABConnectToJavaAccessBridgeUseCOMFor64BitJABDLL != null)
            {
                jABConnectToJavaAccessBridge["UseCOMFor64BitJABDLL"] = ExpressionConverter.ConvertO(jABConnectToJavaAccessBridgeUseCOMFor64BitJABDLL);
                jABConnectToJavaAccessBridgepropCount++;
            }

            if (jABConnectToJavaAccessBridgeEnableJavaAccessBridge != null)
            {
                jABConnectToJavaAccessBridge["EnableJavaAccessBridge"] = ExpressionConverter.ConvertO(jABConnectToJavaAccessBridgeEnableJavaAccessBridge);
                jABConnectToJavaAccessBridgepropCount++;
            }

            if (jABConnectToJavaAccessBridgeAccessibilityFilepath != null)
            {
                jABConnectToJavaAccessBridge["AccessibilityFilepath"] = ExpressionConverter.ConvertO(jABConnectToJavaAccessBridgeAccessibilityFilepath);
                jABConnectToJavaAccessBridgepropCount++;
            }

            if (jABConnectToJavaAccessBridgeCommandTimeoutInSeconds != null)
            {
                jABConnectToJavaAccessBridge["CommandTimeoutInSeconds"] = ExpressionConverter.ConvertO(jABConnectToJavaAccessBridgeCommandTimeoutInSeconds);
                jABConnectToJavaAccessBridgepropCount++;
            }

            jABConnectToJavaAccessBridgepropCount++;
            jABConnectToJavaAccessBridge["Workflow"] = ExpressionConverter.ConvertO(jABConnectToJavaAccessBridgeWorkflow);
            if (jABConnectToJavaAccessBridgepropCount > 0)
            {
                callPayload.Body = jABConnectToJavaAccessBridge;
            }

            return new ApiConnectionAction<JABConnectToJavaAccessBridgeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABDisconnectFromJavaAccessBridge(Expression<Func<string>> jABDisconnectFromJavaAccessBridgeWorkflow, Expression<Func<bool>> jABDisconnectFromJavaAccessBridgeDisableJavaAccessBridge = null, Expression<Func<string>> jABDisconnectFromJavaAccessBridgeAccessibilityFilepath = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABDisconnectFromJavaAccessBridge";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABDisconnectFromJavaAccessBridge = new JObject();
            var jABDisconnectFromJavaAccessBridgepropCount = 0;
            if (jABDisconnectFromJavaAccessBridgeDisableJavaAccessBridge != null)
            {
                jABDisconnectFromJavaAccessBridge["DisableJavaAccessBridge"] = ExpressionConverter.ConvertO(jABDisconnectFromJavaAccessBridgeDisableJavaAccessBridge);
                jABDisconnectFromJavaAccessBridgepropCount++;
            }

            if (jABDisconnectFromJavaAccessBridgeAccessibilityFilepath != null)
            {
                jABDisconnectFromJavaAccessBridge["AccessibilityFilepath"] = ExpressionConverter.ConvertO(jABDisconnectFromJavaAccessBridgeAccessibilityFilepath);
                jABDisconnectFromJavaAccessBridgepropCount++;
            }

            jABDisconnectFromJavaAccessBridgepropCount++;
            jABDisconnectFromJavaAccessBridge["Workflow"] = ExpressionConverter.ConvertO(jABDisconnectFromJavaAccessBridgeWorkflow);
            if (jABDisconnectFromJavaAccessBridgepropCount > 0)
            {
                callPayload.Body = jABDisconnectFromJavaAccessBridge;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetConnectionStatusResponse> JABGetConnectionStatus(Expression<Func<string>> jABGetConnectionStatusWorkflow)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetConnectionStatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetConnectionStatus = new JObject();
            var jABGetConnectionStatuspropCount = 0;
            jABGetConnectionStatuspropCount++;
            jABGetConnectionStatus["Workflow"] = ExpressionConverter.ConvertO(jABGetConnectionStatusWorkflow);
            if (jABGetConnectionStatuspropCount > 0)
            {
                callPayload.Body = jABGetConnectionStatus;
            }

            return new ApiConnectionAction<JABGetConnectionStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABIsJavaWindowResponse> JABIsJavaWindow(Expression<Func<int>> jABIsJavaWindowParentWindowHandle, Expression<Func<string>> jABIsJavaWindowWorkflow, Expression<Func<string>> jABIsJavaWindowSearchElementName = null, Expression<Func<string>> jABIsJavaWindowSearchElementClassName = null, Expression<Func<string>> jABIsJavaWindowSearchElementAutomationId = null, Expression<Func<string>> jABIsJavaWindowSearchLocalizedControlType = null, Expression<Func<bool>> jABIsJavaWindowSearchSubTree = null, Expression<Func<int>> jABIsJavaWindowMatchIndex = null, Expression<Func<string>> jABIsJavaWindowSearchFilter = null, Expression<Func<string>> jABIsJavaWindowSortByColumn = null, Expression<Func<bool>> jABIsJavaWindowMatchIndexAscending = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABIsJavaWindow";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABIsJavaWindow = new JObject();
            var jABIsJavaWindowpropCount = 0;
            jABIsJavaWindowpropCount++;
            jABIsJavaWindow["ParentWindowHandle"] = ExpressionConverter.ConvertO(jABIsJavaWindowParentWindowHandle);
            if (jABIsJavaWindowSearchElementName != null)
            {
                jABIsJavaWindow["SearchElementName"] = ExpressionConverter.ConvertO(jABIsJavaWindowSearchElementName);
                jABIsJavaWindowpropCount++;
            }

            if (jABIsJavaWindowSearchElementClassName != null)
            {
                jABIsJavaWindow["SearchElementClassName"] = ExpressionConverter.ConvertO(jABIsJavaWindowSearchElementClassName);
                jABIsJavaWindowpropCount++;
            }

            if (jABIsJavaWindowSearchElementAutomationId != null)
            {
                jABIsJavaWindow["SearchElementAutomationId"] = ExpressionConverter.ConvertO(jABIsJavaWindowSearchElementAutomationId);
                jABIsJavaWindowpropCount++;
            }

            if (jABIsJavaWindowSearchLocalizedControlType != null)
            {
                jABIsJavaWindow["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(jABIsJavaWindowSearchLocalizedControlType);
                jABIsJavaWindowpropCount++;
            }

            if (jABIsJavaWindowSearchSubTree != null)
            {
                jABIsJavaWindow["SearchSubTree"] = ExpressionConverter.ConvertO(jABIsJavaWindowSearchSubTree);
                jABIsJavaWindowpropCount++;
            }

            if (jABIsJavaWindowMatchIndex != null)
            {
                jABIsJavaWindow["MatchIndex"] = ExpressionConverter.ConvertO(jABIsJavaWindowMatchIndex);
                jABIsJavaWindowpropCount++;
            }

            if (jABIsJavaWindowSearchFilter != null)
            {
                jABIsJavaWindow["SearchFilter"] = ExpressionConverter.ConvertO(jABIsJavaWindowSearchFilter);
                jABIsJavaWindowpropCount++;
            }

            if (jABIsJavaWindowSortByColumn != null)
            {
                jABIsJavaWindow["SortByColumn"] = ExpressionConverter.ConvertO(jABIsJavaWindowSortByColumn);
                jABIsJavaWindowpropCount++;
            }

            if (jABIsJavaWindowMatchIndexAscending != null)
            {
                jABIsJavaWindow["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABIsJavaWindowMatchIndexAscending);
                jABIsJavaWindowpropCount++;
            }

            jABIsJavaWindowpropCount++;
            jABIsJavaWindow["Workflow"] = ExpressionConverter.ConvertO(jABIsJavaWindowWorkflow);
            if (jABIsJavaWindowpropCount > 0)
            {
                callPayload.Body = jABIsJavaWindow;
            }

            return new ApiConnectionAction<JABIsJavaWindowResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetWindowsAccessBridgeInfoResponse> JABGetWindowsAccessBridgeInfo(Expression<Func<int>> jABGetWindowsAccessBridgeInfoVMID, Expression<Func<string>> jABGetWindowsAccessBridgeInfoWorkflow)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetWindowsAccessBridgeInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetWindowsAccessBridgeInfo = new JObject();
            var jABGetWindowsAccessBridgeInfopropCount = 0;
            jABGetWindowsAccessBridgeInfopropCount++;
            jABGetWindowsAccessBridgeInfo["VMID"] = ExpressionConverter.ConvertO(jABGetWindowsAccessBridgeInfoVMID);
            jABGetWindowsAccessBridgeInfopropCount++;
            jABGetWindowsAccessBridgeInfo["Workflow"] = ExpressionConverter.ConvertO(jABGetWindowsAccessBridgeInfoWorkflow);
            if (jABGetWindowsAccessBridgeInfopropCount > 0)
            {
                callPayload.Body = jABGetWindowsAccessBridgeInfo;
            }

            return new ApiConnectionAction<JABGetWindowsAccessBridgeInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetUIAElementPropertiesResponse> JABGetUIAElementProperties(Expression<Func<int>> jABGetUIAElementPropertiesParentWindowHandle, Expression<Func<string>> jABGetUIAElementPropertiesWorkflow, Expression<Func<string>> jABGetUIAElementPropertiesSearchElementName = null, Expression<Func<string>> jABGetUIAElementPropertiesSearchElementClassName = null, Expression<Func<string>> jABGetUIAElementPropertiesSearchElementAutomationId = null, Expression<Func<string>> jABGetUIAElementPropertiesSearchLocalizedControlType = null, Expression<Func<bool>> jABGetUIAElementPropertiesSearchSubTree = null, Expression<Func<int>> jABGetUIAElementPropertiesMatchIndex = null, Expression<Func<string>> jABGetUIAElementPropertiesSearchFilter = null, Expression<Func<string>> jABGetUIAElementPropertiesSortByColumn = null, Expression<Func<bool>> jABGetUIAElementPropertiesMatchIndexAscending = null, Expression<Func<int>> jABGetUIAElementPropertiesMaxStringLength = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetUIAElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetUIAElementProperties = new JObject();
            var jABGetUIAElementPropertiespropCount = 0;
            jABGetUIAElementPropertiespropCount++;
            jABGetUIAElementProperties["ParentWindowHandle"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiesParentWindowHandle);
            if (jABGetUIAElementPropertiesSearchElementName != null)
            {
                jABGetUIAElementProperties["SearchElementName"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiesSearchElementName);
                jABGetUIAElementPropertiespropCount++;
            }

            if (jABGetUIAElementPropertiesSearchElementClassName != null)
            {
                jABGetUIAElementProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiesSearchElementClassName);
                jABGetUIAElementPropertiespropCount++;
            }

            if (jABGetUIAElementPropertiesSearchElementAutomationId != null)
            {
                jABGetUIAElementProperties["SearchElementAutomationId"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiesSearchElementAutomationId);
                jABGetUIAElementPropertiespropCount++;
            }

            if (jABGetUIAElementPropertiesSearchLocalizedControlType != null)
            {
                jABGetUIAElementProperties["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiesSearchLocalizedControlType);
                jABGetUIAElementPropertiespropCount++;
            }

            if (jABGetUIAElementPropertiesSearchSubTree != null)
            {
                jABGetUIAElementProperties["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiesSearchSubTree);
                jABGetUIAElementPropertiespropCount++;
            }

            if (jABGetUIAElementPropertiesMatchIndex != null)
            {
                jABGetUIAElementProperties["MatchIndex"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiesMatchIndex);
                jABGetUIAElementPropertiespropCount++;
            }

            if (jABGetUIAElementPropertiesSearchFilter != null)
            {
                jABGetUIAElementProperties["SearchFilter"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiesSearchFilter);
                jABGetUIAElementPropertiespropCount++;
            }

            if (jABGetUIAElementPropertiesSortByColumn != null)
            {
                jABGetUIAElementProperties["SortByColumn"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiesSortByColumn);
                jABGetUIAElementPropertiespropCount++;
            }

            if (jABGetUIAElementPropertiesMatchIndexAscending != null)
            {
                jABGetUIAElementProperties["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiesMatchIndexAscending);
                jABGetUIAElementPropertiespropCount++;
            }

            if (jABGetUIAElementPropertiesMaxStringLength != null)
            {
                jABGetUIAElementProperties["MaxStringLength"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiesMaxStringLength);
                jABGetUIAElementPropertiespropCount++;
            }

            jABGetUIAElementPropertiespropCount++;
            jABGetUIAElementProperties["Workflow"] = ExpressionConverter.ConvertO(jABGetUIAElementPropertiesWorkflow);
            if (jABGetUIAElementPropertiespropCount > 0)
            {
                callPayload.Body = jABGetUIAElementProperties;
            }

            return new ApiConnectionAction<JABGetUIAElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetJABElementPropertiesResponse> JABGetJABElementProperties(Expression<Func<int>> jABGetJABElementPropertiesSearchParentElementJABHandle, Expression<Func<string>> jABGetJABElementPropertiesWorkflow, Expression<Func<string>> jABGetJABElementPropertiesSearchElementJABName = null, Expression<Func<string>> jABGetJABElementPropertiesSearchElementJABDescription = null, Expression<Func<string>> jABGetJABElementPropertiesSearchElementJABRole = null, Expression<Func<bool>> jABGetJABElementPropertiesSearchSubTree = null, Expression<Func<int>> jABGetJABElementPropertiesMaxRelativeDepth = null, Expression<Func<int>> jABGetJABElementPropertiesMatchIndex = null, Expression<Func<string>> jABGetJABElementPropertiesSearchFilter = null, Expression<Func<string>> jABGetJABElementPropertiesSortByColumn = null, Expression<Func<bool>> jABGetJABElementPropertiesMatchIndexAscending = null, Expression<Func<bool>> jABGetJABElementPropertiesCaseSensitiveSearch = null, Expression<Func<bool>> jABGetJABElementPropertiesOnlySearchVisibleElements = null, Expression<Func<bool>> jABGetJABElementPropertiesOnlySearchShowingElements = null, Expression<Func<string>> jABGetJABElementPropertiesElementRolesNotToTraverse = null, Expression<Func<int>> jABGetJABElementPropertiesMaximumElementsToSearch = null, Expression<Func<int>> jABGetJABElementPropertiesMaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABGetJABElementPropertiesMaxStringLength = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetJABElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetJABElementProperties = new JObject();
            var jABGetJABElementPropertiespropCount = 0;
            jABGetJABElementPropertiespropCount++;
            jABGetJABElementProperties["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesSearchParentElementJABHandle);
            if (jABGetJABElementPropertiesSearchElementJABName != null)
            {
                jABGetJABElementProperties["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesSearchElementJABName);
                jABGetJABElementPropertiespropCount++;
            }

            if (jABGetJABElementPropertiesSearchElementJABDescription != null)
            {
                jABGetJABElementProperties["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesSearchElementJABDescription);
                jABGetJABElementPropertiespropCount++;
            }

            if (jABGetJABElementPropertiesSearchElementJABRole != null)
            {
                jABGetJABElementProperties["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesSearchElementJABRole);
                jABGetJABElementPropertiespropCount++;
            }

            if (jABGetJABElementPropertiesSearchSubTree != null)
            {
                jABGetJABElementProperties["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesSearchSubTree);
                jABGetJABElementPropertiespropCount++;
            }

            if (jABGetJABElementPropertiesMaxRelativeDepth != null)
            {
                jABGetJABElementProperties["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesMaxRelativeDepth);
                jABGetJABElementPropertiespropCount++;
            }

            if (jABGetJABElementPropertiesMatchIndex != null)
            {
                jABGetJABElementProperties["MatchIndex"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesMatchIndex);
                jABGetJABElementPropertiespropCount++;
            }

            if (jABGetJABElementPropertiesSearchFilter != null)
            {
                jABGetJABElementProperties["SearchFilter"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesSearchFilter);
                jABGetJABElementPropertiespropCount++;
            }

            if (jABGetJABElementPropertiesSortByColumn != null)
            {
                jABGetJABElementProperties["SortByColumn"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesSortByColumn);
                jABGetJABElementPropertiespropCount++;
            }

            if (jABGetJABElementPropertiesMatchIndexAscending != null)
            {
                jABGetJABElementProperties["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesMatchIndexAscending);
                jABGetJABElementPropertiespropCount++;
            }

            if (jABGetJABElementPropertiesCaseSensitiveSearch != null)
            {
                jABGetJABElementProperties["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesCaseSensitiveSearch);
                jABGetJABElementPropertiespropCount++;
            }

            if (jABGetJABElementPropertiesOnlySearchVisibleElements != null)
            {
                jABGetJABElementProperties["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesOnlySearchVisibleElements);
                jABGetJABElementPropertiespropCount++;
            }

            if (jABGetJABElementPropertiesOnlySearchShowingElements != null)
            {
                jABGetJABElementProperties["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesOnlySearchShowingElements);
                jABGetJABElementPropertiespropCount++;
            }

            if (jABGetJABElementPropertiesElementRolesNotToTraverse != null)
            {
                jABGetJABElementProperties["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesElementRolesNotToTraverse);
                jABGetJABElementPropertiespropCount++;
            }

            if (jABGetJABElementPropertiesMaximumElementsToSearch != null)
            {
                jABGetJABElementProperties["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesMaximumElementsToSearch);
                jABGetJABElementPropertiespropCount++;
            }

            if (jABGetJABElementPropertiesMaximumChildElementsToSearchPerNode != null)
            {
                jABGetJABElementProperties["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesMaximumChildElementsToSearchPerNode);
                jABGetJABElementPropertiespropCount++;
            }

            if (jABGetJABElementPropertiesMaxStringLength != null)
            {
                jABGetJABElementProperties["MaxStringLength"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesMaxStringLength);
                jABGetJABElementPropertiespropCount++;
            }

            jABGetJABElementPropertiespropCount++;
            jABGetJABElementProperties["Workflow"] = ExpressionConverter.ConvertO(jABGetJABElementPropertiesWorkflow);
            if (jABGetJABElementPropertiespropCount > 0)
            {
                callPayload.Body = jABGetJABElementProperties;
            }

            return new ApiConnectionAction<JABGetJABElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABDrawRectangleAroundJABElement(Expression<Func<int>> jABDrawRectangleAroundJABElementSearchParentElementJABHandle, Expression<Func<string>> jABDrawRectangleAroundJABElementWorkflow, Expression<Func<string>> jABDrawRectangleAroundJABElementSearchElementJABName = null, Expression<Func<string>> jABDrawRectangleAroundJABElementSearchElementJABDescription = null, Expression<Func<string>> jABDrawRectangleAroundJABElementSearchElementJABRole = null, Expression<Func<bool>> jABDrawRectangleAroundJABElementSearchSubTree = null, Expression<Func<int>> jABDrawRectangleAroundJABElementMaxRelativeDepth = null, Expression<Func<int>> jABDrawRectangleAroundJABElementMatchIndex = null, Expression<Func<string>> jABDrawRectangleAroundJABElementSearchFilter = null, Expression<Func<string>> jABDrawRectangleAroundJABElementSortByColumn = null, Expression<Func<bool>> jABDrawRectangleAroundJABElementMatchIndexAscending = null, Expression<Func<bool>> jABDrawRectangleAroundJABElementCaseSensitiveSearch = null, Expression<Func<bool>> jABDrawRectangleAroundJABElementOnlySearchVisibleElements = null, Expression<Func<bool>> jABDrawRectangleAroundJABElementOnlySearchShowingElements = null, Expression<Func<string>> jABDrawRectangleAroundJABElementElementRolesNotToTraverse = null, Expression<Func<int>> jABDrawRectangleAroundJABElementMaximumElementsToSearch = null, Expression<Func<int>> jABDrawRectangleAroundJABElementMaximumChildElementsToSearchPerNode = null, Expression<Func<string>> jABDrawRectangleAroundJABElementPenColour = null, Expression<Func<int>> jABDrawRectangleAroundJABElementPenThicknessPixels = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABDrawRectangleAroundJABElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABDrawRectangleAroundJABElement = new JObject();
            var jABDrawRectangleAroundJABElementpropCount = 0;
            jABDrawRectangleAroundJABElementpropCount++;
            jABDrawRectangleAroundJABElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementSearchParentElementJABHandle);
            if (jABDrawRectangleAroundJABElementSearchElementJABName != null)
            {
                jABDrawRectangleAroundJABElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementSearchElementJABName);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            if (jABDrawRectangleAroundJABElementSearchElementJABDescription != null)
            {
                jABDrawRectangleAroundJABElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementSearchElementJABDescription);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            if (jABDrawRectangleAroundJABElementSearchElementJABRole != null)
            {
                jABDrawRectangleAroundJABElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementSearchElementJABRole);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            if (jABDrawRectangleAroundJABElementSearchSubTree != null)
            {
                jABDrawRectangleAroundJABElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementSearchSubTree);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            if (jABDrawRectangleAroundJABElementMaxRelativeDepth != null)
            {
                jABDrawRectangleAroundJABElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementMaxRelativeDepth);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            if (jABDrawRectangleAroundJABElementMatchIndex != null)
            {
                jABDrawRectangleAroundJABElement["MatchIndex"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementMatchIndex);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            if (jABDrawRectangleAroundJABElementSearchFilter != null)
            {
                jABDrawRectangleAroundJABElement["SearchFilter"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementSearchFilter);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            if (jABDrawRectangleAroundJABElementSortByColumn != null)
            {
                jABDrawRectangleAroundJABElement["SortByColumn"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementSortByColumn);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            if (jABDrawRectangleAroundJABElementMatchIndexAscending != null)
            {
                jABDrawRectangleAroundJABElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementMatchIndexAscending);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            if (jABDrawRectangleAroundJABElementCaseSensitiveSearch != null)
            {
                jABDrawRectangleAroundJABElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementCaseSensitiveSearch);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            if (jABDrawRectangleAroundJABElementOnlySearchVisibleElements != null)
            {
                jABDrawRectangleAroundJABElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementOnlySearchVisibleElements);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            if (jABDrawRectangleAroundJABElementOnlySearchShowingElements != null)
            {
                jABDrawRectangleAroundJABElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementOnlySearchShowingElements);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            if (jABDrawRectangleAroundJABElementElementRolesNotToTraverse != null)
            {
                jABDrawRectangleAroundJABElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementElementRolesNotToTraverse);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            if (jABDrawRectangleAroundJABElementMaximumElementsToSearch != null)
            {
                jABDrawRectangleAroundJABElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementMaximumElementsToSearch);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            if (jABDrawRectangleAroundJABElementMaximumChildElementsToSearchPerNode != null)
            {
                jABDrawRectangleAroundJABElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementMaximumChildElementsToSearchPerNode);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            if (jABDrawRectangleAroundJABElementPenColour != null)
            {
                jABDrawRectangleAroundJABElement["PenColour"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementPenColour);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            if (jABDrawRectangleAroundJABElementPenThicknessPixels != null)
            {
                jABDrawRectangleAroundJABElement["PenThicknessPixels"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementPenThicknessPixels);
                jABDrawRectangleAroundJABElementpropCount++;
            }

            jABDrawRectangleAroundJABElementpropCount++;
            jABDrawRectangleAroundJABElement["Workflow"] = ExpressionConverter.ConvertO(jABDrawRectangleAroundJABElementWorkflow);
            if (jABDrawRectangleAroundJABElementpropCount > 0)
            {
                callPayload.Body = jABDrawRectangleAroundJABElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABDoesElementExistResponse> JABDoesElementExist(Expression<Func<int>> jABDoesElementExistSearchParentElementJABHandle, Expression<Func<string>> jABDoesElementExistWorkflow, Expression<Func<string>> jABDoesElementExistSearchElementJABName = null, Expression<Func<string>> jABDoesElementExistSearchElementJABDescription = null, Expression<Func<string>> jABDoesElementExistSearchElementJABRole = null, Expression<Func<bool>> jABDoesElementExistSearchSubTree = null, Expression<Func<int>> jABDoesElementExistMaxRelativeDepth = null, Expression<Func<int>> jABDoesElementExistMatchIndex = null, Expression<Func<string>> jABDoesElementExistSearchFilter = null, Expression<Func<string>> jABDoesElementExistSortByColumn = null, Expression<Func<bool>> jABDoesElementExistMatchIndexAscending = null, Expression<Func<bool>> jABDoesElementExistCaseSensitiveSearch = null, Expression<Func<bool>> jABDoesElementExistOnlySearchVisibleElements = null, Expression<Func<bool>> jABDoesElementExistOnlySearchShowingElements = null, Expression<Func<string>> jABDoesElementExistElementRolesNotToTraverse = null, Expression<Func<int>> jABDoesElementExistMaximumElementsToSearch = null, Expression<Func<int>> jABDoesElementExistMaximumChildElementsToSearchPerNode = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABDoesElementExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABDoesElementExist = new JObject();
            var jABDoesElementExistpropCount = 0;
            jABDoesElementExistpropCount++;
            jABDoesElementExist["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABDoesElementExistSearchParentElementJABHandle);
            if (jABDoesElementExistSearchElementJABName != null)
            {
                jABDoesElementExist["SearchElementJABName"] = ExpressionConverter.ConvertO(jABDoesElementExistSearchElementJABName);
                jABDoesElementExistpropCount++;
            }

            if (jABDoesElementExistSearchElementJABDescription != null)
            {
                jABDoesElementExist["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABDoesElementExistSearchElementJABDescription);
                jABDoesElementExistpropCount++;
            }

            if (jABDoesElementExistSearchElementJABRole != null)
            {
                jABDoesElementExist["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABDoesElementExistSearchElementJABRole);
                jABDoesElementExistpropCount++;
            }

            if (jABDoesElementExistSearchSubTree != null)
            {
                jABDoesElementExist["SearchSubTree"] = ExpressionConverter.ConvertO(jABDoesElementExistSearchSubTree);
                jABDoesElementExistpropCount++;
            }

            if (jABDoesElementExistMaxRelativeDepth != null)
            {
                jABDoesElementExist["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABDoesElementExistMaxRelativeDepth);
                jABDoesElementExistpropCount++;
            }

            if (jABDoesElementExistMatchIndex != null)
            {
                jABDoesElementExist["MatchIndex"] = ExpressionConverter.ConvertO(jABDoesElementExistMatchIndex);
                jABDoesElementExistpropCount++;
            }

            if (jABDoesElementExistSearchFilter != null)
            {
                jABDoesElementExist["SearchFilter"] = ExpressionConverter.ConvertO(jABDoesElementExistSearchFilter);
                jABDoesElementExistpropCount++;
            }

            if (jABDoesElementExistSortByColumn != null)
            {
                jABDoesElementExist["SortByColumn"] = ExpressionConverter.ConvertO(jABDoesElementExistSortByColumn);
                jABDoesElementExistpropCount++;
            }

            if (jABDoesElementExistMatchIndexAscending != null)
            {
                jABDoesElementExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABDoesElementExistMatchIndexAscending);
                jABDoesElementExistpropCount++;
            }

            if (jABDoesElementExistCaseSensitiveSearch != null)
            {
                jABDoesElementExist["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABDoesElementExistCaseSensitiveSearch);
                jABDoesElementExistpropCount++;
            }

            if (jABDoesElementExistOnlySearchVisibleElements != null)
            {
                jABDoesElementExist["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABDoesElementExistOnlySearchVisibleElements);
                jABDoesElementExistpropCount++;
            }

            if (jABDoesElementExistOnlySearchShowingElements != null)
            {
                jABDoesElementExist["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABDoesElementExistOnlySearchShowingElements);
                jABDoesElementExistpropCount++;
            }

            if (jABDoesElementExistElementRolesNotToTraverse != null)
            {
                jABDoesElementExist["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABDoesElementExistElementRolesNotToTraverse);
                jABDoesElementExistpropCount++;
            }

            if (jABDoesElementExistMaximumElementsToSearch != null)
            {
                jABDoesElementExist["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABDoesElementExistMaximumElementsToSearch);
                jABDoesElementExistpropCount++;
            }

            if (jABDoesElementExistMaximumChildElementsToSearchPerNode != null)
            {
                jABDoesElementExist["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABDoesElementExistMaximumChildElementsToSearchPerNode);
                jABDoesElementExistpropCount++;
            }

            jABDoesElementExistpropCount++;
            jABDoesElementExist["Workflow"] = ExpressionConverter.ConvertO(jABDoesElementExistWorkflow);
            if (jABDoesElementExistpropCount > 0)
            {
                callPayload.Body = jABDoesElementExist;
            }

            return new ApiConnectionAction<JABDoesElementExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABWaitForElementResponse> JABWaitForElement(Expression<Func<int>> jABWaitForElementSearchParentElementJABHandle, Expression<Func<double>> jABWaitForElementSecondsToWait, Expression<Func<string>> jABWaitForElementWorkflow, Expression<Func<string>> jABWaitForElementSearchElementJABName = null, Expression<Func<string>> jABWaitForElementSearchElementJABDescription = null, Expression<Func<string>> jABWaitForElementSearchElementJABRole = null, Expression<Func<bool>> jABWaitForElementSearchSubTree = null, Expression<Func<int>> jABWaitForElementMaxRelativeDepth = null, Expression<Func<int>> jABWaitForElementMatchIndex = null, Expression<Func<string>> jABWaitForElementSearchFilter = null, Expression<Func<string>> jABWaitForElementSortByColumn = null, Expression<Func<bool>> jABWaitForElementMatchIndexAscending = null, Expression<Func<bool>> jABWaitForElementCaseSensitiveSearch = null, Expression<Func<bool>> jABWaitForElementOnlySearchVisibleElements = null, Expression<Func<bool>> jABWaitForElementOnlySearchShowingElements = null, Expression<Func<string>> jABWaitForElementElementRolesNotToTraverse = null, Expression<Func<int>> jABWaitForElementMaximumElementsToSearch = null, Expression<Func<int>> jABWaitForElementMaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABWaitForElementRaiseExceptionIfElementNotFound = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABWaitForElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABWaitForElement = new JObject();
            var jABWaitForElementpropCount = 0;
            jABWaitForElementpropCount++;
            jABWaitForElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABWaitForElementSearchParentElementJABHandle);
            if (jABWaitForElementSearchElementJABName != null)
            {
                jABWaitForElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABWaitForElementSearchElementJABName);
                jABWaitForElementpropCount++;
            }

            if (jABWaitForElementSearchElementJABDescription != null)
            {
                jABWaitForElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABWaitForElementSearchElementJABDescription);
                jABWaitForElementpropCount++;
            }

            if (jABWaitForElementSearchElementJABRole != null)
            {
                jABWaitForElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABWaitForElementSearchElementJABRole);
                jABWaitForElementpropCount++;
            }

            if (jABWaitForElementSearchSubTree != null)
            {
                jABWaitForElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABWaitForElementSearchSubTree);
                jABWaitForElementpropCount++;
            }

            if (jABWaitForElementMaxRelativeDepth != null)
            {
                jABWaitForElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABWaitForElementMaxRelativeDepth);
                jABWaitForElementpropCount++;
            }

            if (jABWaitForElementMatchIndex != null)
            {
                jABWaitForElement["MatchIndex"] = ExpressionConverter.ConvertO(jABWaitForElementMatchIndex);
                jABWaitForElementpropCount++;
            }

            if (jABWaitForElementSearchFilter != null)
            {
                jABWaitForElement["SearchFilter"] = ExpressionConverter.ConvertO(jABWaitForElementSearchFilter);
                jABWaitForElementpropCount++;
            }

            if (jABWaitForElementSortByColumn != null)
            {
                jABWaitForElement["SortByColumn"] = ExpressionConverter.ConvertO(jABWaitForElementSortByColumn);
                jABWaitForElementpropCount++;
            }

            if (jABWaitForElementMatchIndexAscending != null)
            {
                jABWaitForElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABWaitForElementMatchIndexAscending);
                jABWaitForElementpropCount++;
            }

            if (jABWaitForElementCaseSensitiveSearch != null)
            {
                jABWaitForElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABWaitForElementCaseSensitiveSearch);
                jABWaitForElementpropCount++;
            }

            if (jABWaitForElementOnlySearchVisibleElements != null)
            {
                jABWaitForElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABWaitForElementOnlySearchVisibleElements);
                jABWaitForElementpropCount++;
            }

            if (jABWaitForElementOnlySearchShowingElements != null)
            {
                jABWaitForElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABWaitForElementOnlySearchShowingElements);
                jABWaitForElementpropCount++;
            }

            if (jABWaitForElementElementRolesNotToTraverse != null)
            {
                jABWaitForElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABWaitForElementElementRolesNotToTraverse);
                jABWaitForElementpropCount++;
            }

            if (jABWaitForElementMaximumElementsToSearch != null)
            {
                jABWaitForElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABWaitForElementMaximumElementsToSearch);
                jABWaitForElementpropCount++;
            }

            if (jABWaitForElementMaximumChildElementsToSearchPerNode != null)
            {
                jABWaitForElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABWaitForElementMaximumChildElementsToSearchPerNode);
                jABWaitForElementpropCount++;
            }

            jABWaitForElementpropCount++;
            jABWaitForElement["SecondsToWait"] = ExpressionConverter.ConvertO(jABWaitForElementSecondsToWait);
            if (jABWaitForElementRaiseExceptionIfElementNotFound != null)
            {
                jABWaitForElement["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(jABWaitForElementRaiseExceptionIfElementNotFound);
                jABWaitForElementpropCount++;
            }

            jABWaitForElementpropCount++;
            jABWaitForElement["Workflow"] = ExpressionConverter.ConvertO(jABWaitForElementWorkflow);
            if (jABWaitForElementpropCount > 0)
            {
                callPayload.Body = jABWaitForElement;
            }

            return new ApiConnectionAction<JABWaitForElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABWaitForElementToNotExistResponse> JABWaitForElementToNotExist(Expression<Func<int>> jABWaitForElementToNotExistSearchParentElementJABHandle, Expression<Func<double>> jABWaitForElementToNotExistSecondsToWait, Expression<Func<string>> jABWaitForElementToNotExistWorkflow, Expression<Func<string>> jABWaitForElementToNotExistSearchElementJABName = null, Expression<Func<string>> jABWaitForElementToNotExistSearchElementJABDescription = null, Expression<Func<string>> jABWaitForElementToNotExistSearchElementJABRole = null, Expression<Func<bool>> jABWaitForElementToNotExistSearchSubTree = null, Expression<Func<int>> jABWaitForElementToNotExistMaxRelativeDepth = null, Expression<Func<int>> jABWaitForElementToNotExistMatchIndex = null, Expression<Func<string>> jABWaitForElementToNotExistSearchFilter = null, Expression<Func<string>> jABWaitForElementToNotExistSortByColumn = null, Expression<Func<bool>> jABWaitForElementToNotExistMatchIndexAscending = null, Expression<Func<bool>> jABWaitForElementToNotExistCaseSensitiveSearch = null, Expression<Func<bool>> jABWaitForElementToNotExistOnlySearchVisibleElements = null, Expression<Func<bool>> jABWaitForElementToNotExistOnlySearchShowingElements = null, Expression<Func<string>> jABWaitForElementToNotExistElementRolesNotToTraverse = null, Expression<Func<int>> jABWaitForElementToNotExistMaximumElementsToSearch = null, Expression<Func<int>> jABWaitForElementToNotExistMaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABWaitForElementToNotExistRaiseExceptionIfElementStillExists = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABWaitForElementToNotExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABWaitForElementToNotExist = new JObject();
            var jABWaitForElementToNotExistpropCount = 0;
            jABWaitForElementToNotExistpropCount++;
            jABWaitForElementToNotExist["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistSearchParentElementJABHandle);
            if (jABWaitForElementToNotExistSearchElementJABName != null)
            {
                jABWaitForElementToNotExist["SearchElementJABName"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistSearchElementJABName);
                jABWaitForElementToNotExistpropCount++;
            }

            if (jABWaitForElementToNotExistSearchElementJABDescription != null)
            {
                jABWaitForElementToNotExist["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistSearchElementJABDescription);
                jABWaitForElementToNotExistpropCount++;
            }

            if (jABWaitForElementToNotExistSearchElementJABRole != null)
            {
                jABWaitForElementToNotExist["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistSearchElementJABRole);
                jABWaitForElementToNotExistpropCount++;
            }

            if (jABWaitForElementToNotExistSearchSubTree != null)
            {
                jABWaitForElementToNotExist["SearchSubTree"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistSearchSubTree);
                jABWaitForElementToNotExistpropCount++;
            }

            if (jABWaitForElementToNotExistMaxRelativeDepth != null)
            {
                jABWaitForElementToNotExist["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistMaxRelativeDepth);
                jABWaitForElementToNotExistpropCount++;
            }

            if (jABWaitForElementToNotExistMatchIndex != null)
            {
                jABWaitForElementToNotExist["MatchIndex"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistMatchIndex);
                jABWaitForElementToNotExistpropCount++;
            }

            if (jABWaitForElementToNotExistSearchFilter != null)
            {
                jABWaitForElementToNotExist["SearchFilter"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistSearchFilter);
                jABWaitForElementToNotExistpropCount++;
            }

            if (jABWaitForElementToNotExistSortByColumn != null)
            {
                jABWaitForElementToNotExist["SortByColumn"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistSortByColumn);
                jABWaitForElementToNotExistpropCount++;
            }

            if (jABWaitForElementToNotExistMatchIndexAscending != null)
            {
                jABWaitForElementToNotExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistMatchIndexAscending);
                jABWaitForElementToNotExistpropCount++;
            }

            if (jABWaitForElementToNotExistCaseSensitiveSearch != null)
            {
                jABWaitForElementToNotExist["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistCaseSensitiveSearch);
                jABWaitForElementToNotExistpropCount++;
            }

            if (jABWaitForElementToNotExistOnlySearchVisibleElements != null)
            {
                jABWaitForElementToNotExist["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistOnlySearchVisibleElements);
                jABWaitForElementToNotExistpropCount++;
            }

            if (jABWaitForElementToNotExistOnlySearchShowingElements != null)
            {
                jABWaitForElementToNotExist["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistOnlySearchShowingElements);
                jABWaitForElementToNotExistpropCount++;
            }

            if (jABWaitForElementToNotExistElementRolesNotToTraverse != null)
            {
                jABWaitForElementToNotExist["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistElementRolesNotToTraverse);
                jABWaitForElementToNotExistpropCount++;
            }

            if (jABWaitForElementToNotExistMaximumElementsToSearch != null)
            {
                jABWaitForElementToNotExist["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistMaximumElementsToSearch);
                jABWaitForElementToNotExistpropCount++;
            }

            if (jABWaitForElementToNotExistMaximumChildElementsToSearchPerNode != null)
            {
                jABWaitForElementToNotExist["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistMaximumChildElementsToSearchPerNode);
                jABWaitForElementToNotExistpropCount++;
            }

            jABWaitForElementToNotExistpropCount++;
            jABWaitForElementToNotExist["SecondsToWait"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistSecondsToWait);
            if (jABWaitForElementToNotExistRaiseExceptionIfElementStillExists != null)
            {
                jABWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistRaiseExceptionIfElementStillExists);
                jABWaitForElementToNotExistpropCount++;
            }

            jABWaitForElementToNotExistpropCount++;
            jABWaitForElementToNotExist["Workflow"] = ExpressionConverter.ConvertO(jABWaitForElementToNotExistWorkflow);
            if (jABWaitForElementToNotExistpropCount > 0)
            {
                callPayload.Body = jABWaitForElementToNotExist;
            }

            return new ApiConnectionAction<JABWaitForElementToNotExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetDesktopElementsResponse> JABGetDesktopElements(Expression<Func<string>> jABGetDesktopElementsWorkflow, Expression<Func<string>> jABGetDesktopElementsSearchElementLocalizedControlType = null, Expression<Func<int>> jABGetDesktopElementsSearchProcessID = null, Expression<Func<int>> jABGetDesktopElementsFirstItemToReturn = null, Expression<Func<int>> jABGetDesktopElementsMaxItemsToReturn = null, Expression<Func<bool>> jABGetDesktopElementsSearchChildElements = null, Expression<Func<int>> jABGetDesktopElementsMaxStringLength = null, Expression<Func<bool>> jABGetDesktopElementsIncludeChildProcesses = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetDesktopElements";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetDesktopElements = new JObject();
            var jABGetDesktopElementspropCount = 0;
            if (jABGetDesktopElementsSearchElementLocalizedControlType != null)
            {
                jABGetDesktopElements["SearchElementLocalizedControlType"] = ExpressionConverter.ConvertO(jABGetDesktopElementsSearchElementLocalizedControlType);
                jABGetDesktopElementspropCount++;
            }

            if (jABGetDesktopElementsSearchProcessID != null)
            {
                jABGetDesktopElements["SearchProcessID"] = ExpressionConverter.ConvertO(jABGetDesktopElementsSearchProcessID);
                jABGetDesktopElementspropCount++;
            }

            if (jABGetDesktopElementsFirstItemToReturn != null)
            {
                jABGetDesktopElements["FirstItemToReturn"] = ExpressionConverter.ConvertO(jABGetDesktopElementsFirstItemToReturn);
                jABGetDesktopElementspropCount++;
            }

            if (jABGetDesktopElementsMaxItemsToReturn != null)
            {
                jABGetDesktopElements["MaxItemsToReturn"] = ExpressionConverter.ConvertO(jABGetDesktopElementsMaxItemsToReturn);
                jABGetDesktopElementspropCount++;
            }

            if (jABGetDesktopElementsSearchChildElements != null)
            {
                jABGetDesktopElements["SearchChildElements"] = ExpressionConverter.ConvertO(jABGetDesktopElementsSearchChildElements);
                jABGetDesktopElementspropCount++;
            }

            if (jABGetDesktopElementsMaxStringLength != null)
            {
                jABGetDesktopElements["MaxStringLength"] = ExpressionConverter.ConvertO(jABGetDesktopElementsMaxStringLength);
                jABGetDesktopElementspropCount++;
            }

            if (jABGetDesktopElementsIncludeChildProcesses != null)
            {
                jABGetDesktopElements["IncludeChildProcesses"] = ExpressionConverter.ConvertO(jABGetDesktopElementsIncludeChildProcesses);
                jABGetDesktopElementspropCount++;
            }

            jABGetDesktopElementspropCount++;
            jABGetDesktopElements["Workflow"] = ExpressionConverter.ConvertO(jABGetDesktopElementsWorkflow);
            if (jABGetDesktopElementspropCount > 0)
            {
                callPayload.Body = jABGetDesktopElements;
            }

            return new ApiConnectionAction<JABGetDesktopElementsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABDoesDesktopElementExistResponse> JABDoesDesktopElementExist(Expression<Func<string>> jABDoesDesktopElementExistWorkflow, Expression<Func<string>> jABDoesDesktopElementExistSearchUIAElementName = null, Expression<Func<string>> jABDoesDesktopElementExistSearchUIAElementClassName = null, Expression<Func<string>> jABDoesDesktopElementExistSearchUIAElementLocalizedControlType = null, Expression<Func<int>> jABDoesDesktopElementExistSearchProcessID = null, Expression<Func<bool>> jABDoesDesktopElementExistSearchChildElements = null, Expression<Func<int>> jABDoesDesktopElementExistMatchIndex = null, Expression<Func<string>> jABDoesDesktopElementExistSearchFilter = null, Expression<Func<string>> jABDoesDesktopElementExistSortByColumn = null, Expression<Func<bool>> jABDoesDesktopElementExistMatchIndexAscending = null, Expression<Func<bool>> jABDoesDesktopElementExistIncludeChildProcesses = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABDoesDesktopElementExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABDoesDesktopElementExist = new JObject();
            var jABDoesDesktopElementExistpropCount = 0;
            if (jABDoesDesktopElementExistSearchUIAElementName != null)
            {
                jABDoesDesktopElementExist["SearchUIAElementName"] = ExpressionConverter.ConvertO(jABDoesDesktopElementExistSearchUIAElementName);
                jABDoesDesktopElementExistpropCount++;
            }

            if (jABDoesDesktopElementExistSearchUIAElementClassName != null)
            {
                jABDoesDesktopElementExist["SearchUIAElementClassName"] = ExpressionConverter.ConvertO(jABDoesDesktopElementExistSearchUIAElementClassName);
                jABDoesDesktopElementExistpropCount++;
            }

            if (jABDoesDesktopElementExistSearchUIAElementLocalizedControlType != null)
            {
                jABDoesDesktopElementExist["SearchUIAElementLocalizedControlType"] = ExpressionConverter.ConvertO(jABDoesDesktopElementExistSearchUIAElementLocalizedControlType);
                jABDoesDesktopElementExistpropCount++;
            }

            if (jABDoesDesktopElementExistSearchProcessID != null)
            {
                jABDoesDesktopElementExist["SearchProcessID"] = ExpressionConverter.ConvertO(jABDoesDesktopElementExistSearchProcessID);
                jABDoesDesktopElementExistpropCount++;
            }

            if (jABDoesDesktopElementExistSearchChildElements != null)
            {
                jABDoesDesktopElementExist["SearchChildElements"] = ExpressionConverter.ConvertO(jABDoesDesktopElementExistSearchChildElements);
                jABDoesDesktopElementExistpropCount++;
            }

            if (jABDoesDesktopElementExistMatchIndex != null)
            {
                jABDoesDesktopElementExist["MatchIndex"] = ExpressionConverter.ConvertO(jABDoesDesktopElementExistMatchIndex);
                jABDoesDesktopElementExistpropCount++;
            }

            if (jABDoesDesktopElementExistSearchFilter != null)
            {
                jABDoesDesktopElementExist["SearchFilter"] = ExpressionConverter.ConvertO(jABDoesDesktopElementExistSearchFilter);
                jABDoesDesktopElementExistpropCount++;
            }

            if (jABDoesDesktopElementExistSortByColumn != null)
            {
                jABDoesDesktopElementExist["SortByColumn"] = ExpressionConverter.ConvertO(jABDoesDesktopElementExistSortByColumn);
                jABDoesDesktopElementExistpropCount++;
            }

            if (jABDoesDesktopElementExistMatchIndexAscending != null)
            {
                jABDoesDesktopElementExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABDoesDesktopElementExistMatchIndexAscending);
                jABDoesDesktopElementExistpropCount++;
            }

            if (jABDoesDesktopElementExistIncludeChildProcesses != null)
            {
                jABDoesDesktopElementExist["IncludeChildProcesses"] = ExpressionConverter.ConvertO(jABDoesDesktopElementExistIncludeChildProcesses);
                jABDoesDesktopElementExistpropCount++;
            }

            jABDoesDesktopElementExistpropCount++;
            jABDoesDesktopElementExist["Workflow"] = ExpressionConverter.ConvertO(jABDoesDesktopElementExistWorkflow);
            if (jABDoesDesktopElementExistpropCount > 0)
            {
                callPayload.Body = jABDoesDesktopElementExist;
            }

            return new ApiConnectionAction<JABDoesDesktopElementExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABWaitForDesktopElementResponse> JABWaitForDesktopElement(Expression<Func<double>> jABWaitForDesktopElementSecondsToWait, Expression<Func<string>> jABWaitForDesktopElementWorkflow, Expression<Func<string>> jABWaitForDesktopElementSearchUIAElementName = null, Expression<Func<string>> jABWaitForDesktopElementSearchUIAElementClassName = null, Expression<Func<string>> jABWaitForDesktopElementSearchUIAElementLocalizedControlType = null, Expression<Func<int>> jABWaitForDesktopElementSearchProcessID = null, Expression<Func<bool>> jABWaitForDesktopElementSearchChildElements = null, Expression<Func<int>> jABWaitForDesktopElementMatchIndex = null, Expression<Func<string>> jABWaitForDesktopElementSearchFilter = null, Expression<Func<string>> jABWaitForDesktopElementSortByColumn = null, Expression<Func<bool>> jABWaitForDesktopElementMatchIndexAscending = null, Expression<Func<bool>> jABWaitForDesktopElementIncludeChildProcesses = null, Expression<Func<bool>> jABWaitForDesktopElementRaiseExceptionIfElementNotFound = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABWaitForDesktopElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABWaitForDesktopElement = new JObject();
            var jABWaitForDesktopElementpropCount = 0;
            if (jABWaitForDesktopElementSearchUIAElementName != null)
            {
                jABWaitForDesktopElement["SearchUIAElementName"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementSearchUIAElementName);
                jABWaitForDesktopElementpropCount++;
            }

            if (jABWaitForDesktopElementSearchUIAElementClassName != null)
            {
                jABWaitForDesktopElement["SearchUIAElementClassName"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementSearchUIAElementClassName);
                jABWaitForDesktopElementpropCount++;
            }

            if (jABWaitForDesktopElementSearchUIAElementLocalizedControlType != null)
            {
                jABWaitForDesktopElement["SearchUIAElementLocalizedControlType"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementSearchUIAElementLocalizedControlType);
                jABWaitForDesktopElementpropCount++;
            }

            if (jABWaitForDesktopElementSearchProcessID != null)
            {
                jABWaitForDesktopElement["SearchProcessID"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementSearchProcessID);
                jABWaitForDesktopElementpropCount++;
            }

            if (jABWaitForDesktopElementSearchChildElements != null)
            {
                jABWaitForDesktopElement["SearchChildElements"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementSearchChildElements);
                jABWaitForDesktopElementpropCount++;
            }

            if (jABWaitForDesktopElementMatchIndex != null)
            {
                jABWaitForDesktopElement["MatchIndex"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementMatchIndex);
                jABWaitForDesktopElementpropCount++;
            }

            if (jABWaitForDesktopElementSearchFilter != null)
            {
                jABWaitForDesktopElement["SearchFilter"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementSearchFilter);
                jABWaitForDesktopElementpropCount++;
            }

            if (jABWaitForDesktopElementSortByColumn != null)
            {
                jABWaitForDesktopElement["SortByColumn"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementSortByColumn);
                jABWaitForDesktopElementpropCount++;
            }

            if (jABWaitForDesktopElementMatchIndexAscending != null)
            {
                jABWaitForDesktopElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementMatchIndexAscending);
                jABWaitForDesktopElementpropCount++;
            }

            jABWaitForDesktopElementpropCount++;
            jABWaitForDesktopElement["SecondsToWait"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementSecondsToWait);
            if (jABWaitForDesktopElementIncludeChildProcesses != null)
            {
                jABWaitForDesktopElement["IncludeChildProcesses"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementIncludeChildProcesses);
                jABWaitForDesktopElementpropCount++;
            }

            if (jABWaitForDesktopElementRaiseExceptionIfElementNotFound != null)
            {
                jABWaitForDesktopElement["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementRaiseExceptionIfElementNotFound);
                jABWaitForDesktopElementpropCount++;
            }

            jABWaitForDesktopElementpropCount++;
            jABWaitForDesktopElement["Workflow"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementWorkflow);
            if (jABWaitForDesktopElementpropCount > 0)
            {
                callPayload.Body = jABWaitForDesktopElement;
            }

            return new ApiConnectionAction<JABWaitForDesktopElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABWaitForDesktopElementToNotExistResponse> JABWaitForDesktopElementToNotExist(Expression<Func<double>> jABWaitForDesktopElementToNotExistSecondsToWait, Expression<Func<string>> jABWaitForDesktopElementToNotExistWorkflow, Expression<Func<string>> jABWaitForDesktopElementToNotExistSearchUIAElementName = null, Expression<Func<string>> jABWaitForDesktopElementToNotExistSearchUIAElementClassName = null, Expression<Func<string>> jABWaitForDesktopElementToNotExistSearchUIAElementLocalizedControlType = null, Expression<Func<int>> jABWaitForDesktopElementToNotExistSearchProcessID = null, Expression<Func<bool>> jABWaitForDesktopElementToNotExistSearchChildElements = null, Expression<Func<int>> jABWaitForDesktopElementToNotExistMatchIndex = null, Expression<Func<string>> jABWaitForDesktopElementToNotExistSearchFilter = null, Expression<Func<string>> jABWaitForDesktopElementToNotExistSortByColumn = null, Expression<Func<bool>> jABWaitForDesktopElementToNotExistMatchIndexAscending = null, Expression<Func<bool>> jABWaitForDesktopElementToNotExistIncludeChildProcesses = null, Expression<Func<bool>> jABWaitForDesktopElementToNotExistRaiseExceptionIfElementStillExists = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABWaitForDesktopElementToNotExist";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABWaitForDesktopElementToNotExist = new JObject();
            var jABWaitForDesktopElementToNotExistpropCount = 0;
            if (jABWaitForDesktopElementToNotExistSearchUIAElementName != null)
            {
                jABWaitForDesktopElementToNotExist["SearchUIAElementName"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistSearchUIAElementName);
                jABWaitForDesktopElementToNotExistpropCount++;
            }

            if (jABWaitForDesktopElementToNotExistSearchUIAElementClassName != null)
            {
                jABWaitForDesktopElementToNotExist["SearchUIAElementClassName"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistSearchUIAElementClassName);
                jABWaitForDesktopElementToNotExistpropCount++;
            }

            if (jABWaitForDesktopElementToNotExistSearchUIAElementLocalizedControlType != null)
            {
                jABWaitForDesktopElementToNotExist["SearchUIAElementLocalizedControlType"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistSearchUIAElementLocalizedControlType);
                jABWaitForDesktopElementToNotExistpropCount++;
            }

            if (jABWaitForDesktopElementToNotExistSearchProcessID != null)
            {
                jABWaitForDesktopElementToNotExist["SearchProcessID"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistSearchProcessID);
                jABWaitForDesktopElementToNotExistpropCount++;
            }

            if (jABWaitForDesktopElementToNotExistSearchChildElements != null)
            {
                jABWaitForDesktopElementToNotExist["SearchChildElements"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistSearchChildElements);
                jABWaitForDesktopElementToNotExistpropCount++;
            }

            if (jABWaitForDesktopElementToNotExistMatchIndex != null)
            {
                jABWaitForDesktopElementToNotExist["MatchIndex"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistMatchIndex);
                jABWaitForDesktopElementToNotExistpropCount++;
            }

            if (jABWaitForDesktopElementToNotExistSearchFilter != null)
            {
                jABWaitForDesktopElementToNotExist["SearchFilter"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistSearchFilter);
                jABWaitForDesktopElementToNotExistpropCount++;
            }

            if (jABWaitForDesktopElementToNotExistSortByColumn != null)
            {
                jABWaitForDesktopElementToNotExist["SortByColumn"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistSortByColumn);
                jABWaitForDesktopElementToNotExistpropCount++;
            }

            if (jABWaitForDesktopElementToNotExistMatchIndexAscending != null)
            {
                jABWaitForDesktopElementToNotExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistMatchIndexAscending);
                jABWaitForDesktopElementToNotExistpropCount++;
            }

            jABWaitForDesktopElementToNotExistpropCount++;
            jABWaitForDesktopElementToNotExist["SecondsToWait"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistSecondsToWait);
            if (jABWaitForDesktopElementToNotExistIncludeChildProcesses != null)
            {
                jABWaitForDesktopElementToNotExist["IncludeChildProcesses"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistIncludeChildProcesses);
                jABWaitForDesktopElementToNotExistpropCount++;
            }

            if (jABWaitForDesktopElementToNotExistRaiseExceptionIfElementStillExists != null)
            {
                jABWaitForDesktopElementToNotExist["RaiseExceptionIfElementStillExists"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistRaiseExceptionIfElementStillExists);
                jABWaitForDesktopElementToNotExistpropCount++;
            }

            jABWaitForDesktopElementToNotExistpropCount++;
            jABWaitForDesktopElementToNotExist["Workflow"] = ExpressionConverter.ConvertO(jABWaitForDesktopElementToNotExistWorkflow);
            if (jABWaitForDesktopElementToNotExistpropCount > 0)
            {
                callPayload.Body = jABWaitForDesktopElementToNotExist;
            }

            return new ApiConnectionAction<JABWaitForDesktopElementToNotExistResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABFreeAllJABHandles(Expression<Func<string>> jABFreeAllJABHandlesWorkflow)
        {
            var apiCallPath = "/JavaAccessBridge/JABFreeAllJABHandles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABFreeAllJABHandles = new JObject();
            var jABFreeAllJABHandlespropCount = 0;
            jABFreeAllJABHandlespropCount++;
            jABFreeAllJABHandles["Workflow"] = ExpressionConverter.ConvertO(jABFreeAllJABHandlesWorkflow);
            if (jABFreeAllJABHandlespropCount > 0)
            {
                callPayload.Body = jABFreeAllJABHandles;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetChildJABElementPropertiesResponse> JABGetChildJABElementProperties(Expression<Func<int>> jABGetChildJABElementPropertiesSearchElementJABHandle, Expression<Func<int>> jABGetChildJABElementPropertiesSearchChildIndex, Expression<Func<string>> jABGetChildJABElementPropertiesWorkflow, Expression<Func<int>> jABGetChildJABElementPropertiesMaxStringLength = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetChildJABElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetChildJABElementProperties = new JObject();
            var jABGetChildJABElementPropertiespropCount = 0;
            jABGetChildJABElementPropertiespropCount++;
            jABGetChildJABElementProperties["SearchElementJABHandle"] = ExpressionConverter.ConvertO(jABGetChildJABElementPropertiesSearchElementJABHandle);
            jABGetChildJABElementPropertiespropCount++;
            jABGetChildJABElementProperties["SearchChildIndex"] = ExpressionConverter.ConvertO(jABGetChildJABElementPropertiesSearchChildIndex);
            if (jABGetChildJABElementPropertiesMaxStringLength != null)
            {
                jABGetChildJABElementProperties["MaxStringLength"] = ExpressionConverter.ConvertO(jABGetChildJABElementPropertiesMaxStringLength);
                jABGetChildJABElementPropertiespropCount++;
            }

            jABGetChildJABElementPropertiespropCount++;
            jABGetChildJABElementProperties["Workflow"] = ExpressionConverter.ConvertO(jABGetChildJABElementPropertiesWorkflow);
            if (jABGetChildJABElementPropertiespropCount > 0)
            {
                callPayload.Body = jABGetChildJABElementProperties;
            }

            return new ApiConnectionAction<JABGetChildJABElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetAllChildJABElementPropertiesResponse> JABGetAllChildJABElementProperties(Expression<Func<int>> jABGetAllChildJABElementPropertiesSearchElementJABHandle, Expression<Func<string>> jABGetAllChildJABElementPropertiesWorkflow, Expression<Func<int>> jABGetAllChildJABElementPropertiesFirstItemToReturn = null, Expression<Func<int>> jABGetAllChildJABElementPropertiesMaxItemsToReturn = null, Expression<Func<int>> jABGetAllChildJABElementPropertiesMaxStringLength = null, Expression<Func<bool>> jABGetAllChildJABElementPropertiesSearchDescendants = null, Expression<Func<string>> jABGetAllChildJABElementPropertiesSearchRole = null, Expression<Func<int>> jABGetAllChildJABElementPropertiesMaxRelativeDepth = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetAllChildJABElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetAllChildJABElementProperties = new JObject();
            var jABGetAllChildJABElementPropertiespropCount = 0;
            jABGetAllChildJABElementPropertiespropCount++;
            jABGetAllChildJABElementProperties["SearchElementJABHandle"] = ExpressionConverter.ConvertO(jABGetAllChildJABElementPropertiesSearchElementJABHandle);
            if (jABGetAllChildJABElementPropertiesFirstItemToReturn != null)
            {
                jABGetAllChildJABElementProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(jABGetAllChildJABElementPropertiesFirstItemToReturn);
                jABGetAllChildJABElementPropertiespropCount++;
            }

            if (jABGetAllChildJABElementPropertiesMaxItemsToReturn != null)
            {
                jABGetAllChildJABElementProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(jABGetAllChildJABElementPropertiesMaxItemsToReturn);
                jABGetAllChildJABElementPropertiespropCount++;
            }

            if (jABGetAllChildJABElementPropertiesMaxStringLength != null)
            {
                jABGetAllChildJABElementProperties["MaxStringLength"] = ExpressionConverter.ConvertO(jABGetAllChildJABElementPropertiesMaxStringLength);
                jABGetAllChildJABElementPropertiespropCount++;
            }

            if (jABGetAllChildJABElementPropertiesSearchDescendants != null)
            {
                jABGetAllChildJABElementProperties["SearchDescendants"] = ExpressionConverter.ConvertO(jABGetAllChildJABElementPropertiesSearchDescendants);
                jABGetAllChildJABElementPropertiespropCount++;
            }

            if (jABGetAllChildJABElementPropertiesSearchRole != null)
            {
                jABGetAllChildJABElementProperties["SearchRole"] = ExpressionConverter.ConvertO(jABGetAllChildJABElementPropertiesSearchRole);
                jABGetAllChildJABElementPropertiespropCount++;
            }

            if (jABGetAllChildJABElementPropertiesMaxRelativeDepth != null)
            {
                jABGetAllChildJABElementProperties["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetAllChildJABElementPropertiesMaxRelativeDepth);
                jABGetAllChildJABElementPropertiespropCount++;
            }

            jABGetAllChildJABElementPropertiespropCount++;
            jABGetAllChildJABElementProperties["Workflow"] = ExpressionConverter.ConvertO(jABGetAllChildJABElementPropertiesWorkflow);
            if (jABGetAllChildJABElementPropertiespropCount > 0)
            {
                callPayload.Body = jABGetAllChildJABElementProperties;
            }

            return new ApiConnectionAction<JABGetAllChildJABElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetParentJABElementPropertiesResponse> JABGetParentJABElementProperties(Expression<Func<int>> jABGetParentJABElementPropertiesSearchElementJABHandle, Expression<Func<string>> jABGetParentJABElementPropertiesWorkflow, Expression<Func<int>> jABGetParentJABElementPropertiesMaxStringLength = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetParentJABElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetParentJABElementProperties = new JObject();
            var jABGetParentJABElementPropertiespropCount = 0;
            jABGetParentJABElementPropertiespropCount++;
            jABGetParentJABElementProperties["SearchElementJABHandle"] = ExpressionConverter.ConvertO(jABGetParentJABElementPropertiesSearchElementJABHandle);
            if (jABGetParentJABElementPropertiesMaxStringLength != null)
            {
                jABGetParentJABElementProperties["MaxStringLength"] = ExpressionConverter.ConvertO(jABGetParentJABElementPropertiesMaxStringLength);
                jABGetParentJABElementPropertiespropCount++;
            }

            jABGetParentJABElementPropertiespropCount++;
            jABGetParentJABElementProperties["Workflow"] = ExpressionConverter.ConvertO(jABGetParentJABElementPropertiesWorkflow);
            if (jABGetParentJABElementPropertiespropCount > 0)
            {
                callPayload.Body = jABGetParentJABElementProperties;
            }

            return new ApiConnectionAction<JABGetParentJABElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABPressElement(Expression<Func<int>> jABPressElementSearchParentElementJABHandle, Expression<Func<string>> jABPressElementWorkflow, Expression<Func<string>> jABPressElementSearchElementJABName = null, Expression<Func<string>> jABPressElementSearchElementJABDescription = null, Expression<Func<string>> jABPressElementSearchElementJABRole = null, Expression<Func<bool>> jABPressElementSearchSubTree = null, Expression<Func<int>> jABPressElementMaxRelativeDepth = null, Expression<Func<int>> jABPressElementMatchIndex = null, Expression<Func<string>> jABPressElementSearchFilter = null, Expression<Func<string>> jABPressElementSortByColumn = null, Expression<Func<bool>> jABPressElementMatchIndexAscending = null, Expression<Func<bool>> jABPressElementCaseSensitiveSearch = null, Expression<Func<bool>> jABPressElementOnlySearchVisibleElements = null, Expression<Func<bool>> jABPressElementOnlySearchShowingElements = null, Expression<Func<string>> jABPressElementElementRolesNotToTraverse = null, Expression<Func<int>> jABPressElementMaximumElementsToSearch = null, Expression<Func<int>> jABPressElementMaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABPressElementNumberOfTimesToPressElement = null, Expression<Func<double>> jABPressElementSecondsToWaitBetweenPresses = null, Expression<Func<bool>> jABPressElementAutoDetectActionName = null, Expression<Func<string>> jABPressElementOverrideActionName = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABPressElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABPressElement = new JObject();
            var jABPressElementpropCount = 0;
            jABPressElementpropCount++;
            jABPressElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABPressElementSearchParentElementJABHandle);
            if (jABPressElementSearchElementJABName != null)
            {
                jABPressElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABPressElementSearchElementJABName);
                jABPressElementpropCount++;
            }

            if (jABPressElementSearchElementJABDescription != null)
            {
                jABPressElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABPressElementSearchElementJABDescription);
                jABPressElementpropCount++;
            }

            if (jABPressElementSearchElementJABRole != null)
            {
                jABPressElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABPressElementSearchElementJABRole);
                jABPressElementpropCount++;
            }

            if (jABPressElementSearchSubTree != null)
            {
                jABPressElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABPressElementSearchSubTree);
                jABPressElementpropCount++;
            }

            if (jABPressElementMaxRelativeDepth != null)
            {
                jABPressElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABPressElementMaxRelativeDepth);
                jABPressElementpropCount++;
            }

            if (jABPressElementMatchIndex != null)
            {
                jABPressElement["MatchIndex"] = ExpressionConverter.ConvertO(jABPressElementMatchIndex);
                jABPressElementpropCount++;
            }

            if (jABPressElementSearchFilter != null)
            {
                jABPressElement["SearchFilter"] = ExpressionConverter.ConvertO(jABPressElementSearchFilter);
                jABPressElementpropCount++;
            }

            if (jABPressElementSortByColumn != null)
            {
                jABPressElement["SortByColumn"] = ExpressionConverter.ConvertO(jABPressElementSortByColumn);
                jABPressElementpropCount++;
            }

            if (jABPressElementMatchIndexAscending != null)
            {
                jABPressElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABPressElementMatchIndexAscending);
                jABPressElementpropCount++;
            }

            if (jABPressElementCaseSensitiveSearch != null)
            {
                jABPressElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABPressElementCaseSensitiveSearch);
                jABPressElementpropCount++;
            }

            if (jABPressElementOnlySearchVisibleElements != null)
            {
                jABPressElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABPressElementOnlySearchVisibleElements);
                jABPressElementpropCount++;
            }

            if (jABPressElementOnlySearchShowingElements != null)
            {
                jABPressElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABPressElementOnlySearchShowingElements);
                jABPressElementpropCount++;
            }

            if (jABPressElementElementRolesNotToTraverse != null)
            {
                jABPressElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABPressElementElementRolesNotToTraverse);
                jABPressElementpropCount++;
            }

            if (jABPressElementMaximumElementsToSearch != null)
            {
                jABPressElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABPressElementMaximumElementsToSearch);
                jABPressElementpropCount++;
            }

            if (jABPressElementMaximumChildElementsToSearchPerNode != null)
            {
                jABPressElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABPressElementMaximumChildElementsToSearchPerNode);
                jABPressElementpropCount++;
            }

            if (jABPressElementNumberOfTimesToPressElement != null)
            {
                jABPressElement["NumberOfTimesToPressElement"] = ExpressionConverter.ConvertO(jABPressElementNumberOfTimesToPressElement);
                jABPressElementpropCount++;
            }

            if (jABPressElementSecondsToWaitBetweenPresses != null)
            {
                jABPressElement["SecondsToWaitBetweenPresses"] = ExpressionConverter.ConvertO(jABPressElementSecondsToWaitBetweenPresses);
                jABPressElementpropCount++;
            }

            if (jABPressElementAutoDetectActionName != null)
            {
                jABPressElement["AutoDetectActionName"] = ExpressionConverter.ConvertO(jABPressElementAutoDetectActionName);
                jABPressElementpropCount++;
            }

            if (jABPressElementOverrideActionName != null)
            {
                jABPressElement["OverrideActionName"] = ExpressionConverter.ConvertO(jABPressElementOverrideActionName);
                jABPressElementpropCount++;
            }

            jABPressElementpropCount++;
            jABPressElement["Workflow"] = ExpressionConverter.ConvertO(jABPressElementWorkflow);
            if (jABPressElementpropCount > 0)
            {
                callPayload.Body = jABPressElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABPerformActionOnElement(Expression<Func<int>> jABPerformActionOnElementSearchParentElementJABHandle, Expression<Func<string>> jABPerformActionOnElementAction, Expression<Func<string>> jABPerformActionOnElementWorkflow, Expression<Func<string>> jABPerformActionOnElementSearchElementJABName = null, Expression<Func<string>> jABPerformActionOnElementSearchElementJABDescription = null, Expression<Func<string>> jABPerformActionOnElementSearchElementJABRole = null, Expression<Func<bool>> jABPerformActionOnElementSearchSubTree = null, Expression<Func<int>> jABPerformActionOnElementMaxRelativeDepth = null, Expression<Func<int>> jABPerformActionOnElementMatchIndex = null, Expression<Func<string>> jABPerformActionOnElementSearchFilter = null, Expression<Func<string>> jABPerformActionOnElementSortByColumn = null, Expression<Func<bool>> jABPerformActionOnElementMatchIndexAscending = null, Expression<Func<bool>> jABPerformActionOnElementCaseSensitiveSearch = null, Expression<Func<bool>> jABPerformActionOnElementOnlySearchVisibleElements = null, Expression<Func<bool>> jABPerformActionOnElementOnlySearchShowingElements = null, Expression<Func<string>> jABPerformActionOnElementElementRolesNotToTraverse = null, Expression<Func<int>> jABPerformActionOnElementMaximumElementsToSearch = null, Expression<Func<int>> jABPerformActionOnElementMaximumChildElementsToSearchPerNode = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABPerformActionOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABPerformActionOnElement = new JObject();
            var jABPerformActionOnElementpropCount = 0;
            jABPerformActionOnElementpropCount++;
            jABPerformActionOnElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABPerformActionOnElementSearchParentElementJABHandle);
            if (jABPerformActionOnElementSearchElementJABName != null)
            {
                jABPerformActionOnElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABPerformActionOnElementSearchElementJABName);
                jABPerformActionOnElementpropCount++;
            }

            if (jABPerformActionOnElementSearchElementJABDescription != null)
            {
                jABPerformActionOnElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABPerformActionOnElementSearchElementJABDescription);
                jABPerformActionOnElementpropCount++;
            }

            if (jABPerformActionOnElementSearchElementJABRole != null)
            {
                jABPerformActionOnElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABPerformActionOnElementSearchElementJABRole);
                jABPerformActionOnElementpropCount++;
            }

            if (jABPerformActionOnElementSearchSubTree != null)
            {
                jABPerformActionOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABPerformActionOnElementSearchSubTree);
                jABPerformActionOnElementpropCount++;
            }

            if (jABPerformActionOnElementMaxRelativeDepth != null)
            {
                jABPerformActionOnElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABPerformActionOnElementMaxRelativeDepth);
                jABPerformActionOnElementpropCount++;
            }

            if (jABPerformActionOnElementMatchIndex != null)
            {
                jABPerformActionOnElement["MatchIndex"] = ExpressionConverter.ConvertO(jABPerformActionOnElementMatchIndex);
                jABPerformActionOnElementpropCount++;
            }

            if (jABPerformActionOnElementSearchFilter != null)
            {
                jABPerformActionOnElement["SearchFilter"] = ExpressionConverter.ConvertO(jABPerformActionOnElementSearchFilter);
                jABPerformActionOnElementpropCount++;
            }

            if (jABPerformActionOnElementSortByColumn != null)
            {
                jABPerformActionOnElement["SortByColumn"] = ExpressionConverter.ConvertO(jABPerformActionOnElementSortByColumn);
                jABPerformActionOnElementpropCount++;
            }

            if (jABPerformActionOnElementMatchIndexAscending != null)
            {
                jABPerformActionOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABPerformActionOnElementMatchIndexAscending);
                jABPerformActionOnElementpropCount++;
            }

            if (jABPerformActionOnElementCaseSensitiveSearch != null)
            {
                jABPerformActionOnElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABPerformActionOnElementCaseSensitiveSearch);
                jABPerformActionOnElementpropCount++;
            }

            if (jABPerformActionOnElementOnlySearchVisibleElements != null)
            {
                jABPerformActionOnElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABPerformActionOnElementOnlySearchVisibleElements);
                jABPerformActionOnElementpropCount++;
            }

            if (jABPerformActionOnElementOnlySearchShowingElements != null)
            {
                jABPerformActionOnElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABPerformActionOnElementOnlySearchShowingElements);
                jABPerformActionOnElementpropCount++;
            }

            if (jABPerformActionOnElementElementRolesNotToTraverse != null)
            {
                jABPerformActionOnElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABPerformActionOnElementElementRolesNotToTraverse);
                jABPerformActionOnElementpropCount++;
            }

            if (jABPerformActionOnElementMaximumElementsToSearch != null)
            {
                jABPerformActionOnElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABPerformActionOnElementMaximumElementsToSearch);
                jABPerformActionOnElementpropCount++;
            }

            if (jABPerformActionOnElementMaximumChildElementsToSearchPerNode != null)
            {
                jABPerformActionOnElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABPerformActionOnElementMaximumChildElementsToSearchPerNode);
                jABPerformActionOnElementpropCount++;
            }

            jABPerformActionOnElementpropCount++;
            jABPerformActionOnElement["Action"] = ExpressionConverter.ConvertO(jABPerformActionOnElementAction);
            jABPerformActionOnElementpropCount++;
            jABPerformActionOnElement["Workflow"] = ExpressionConverter.ConvertO(jABPerformActionOnElementWorkflow);
            if (jABPerformActionOnElementpropCount > 0)
            {
                callPayload.Body = jABPerformActionOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalLeftMouseClickOnElement(Expression<Func<int>> jABGlobalLeftMouseClickOnElementSearchParentElementJABHandle, Expression<Func<string>> jABGlobalLeftMouseClickOnElementWorkflow, Expression<Func<string>> jABGlobalLeftMouseClickOnElementSearchElementJABName = null, Expression<Func<string>> jABGlobalLeftMouseClickOnElementSearchElementJABDescription = null, Expression<Func<string>> jABGlobalLeftMouseClickOnElementSearchElementJABRole = null, Expression<Func<bool>> jABGlobalLeftMouseClickOnElementSearchSubTree = null, Expression<Func<int>> jABGlobalLeftMouseClickOnElementMaxRelativeDepth = null, Expression<Func<int>> jABGlobalLeftMouseClickOnElementMatchIndex = null, Expression<Func<string>> jABGlobalLeftMouseClickOnElementSearchFilter = null, Expression<Func<string>> jABGlobalLeftMouseClickOnElementSortByColumn = null, Expression<Func<bool>> jABGlobalLeftMouseClickOnElementMatchIndexAscending = null, Expression<Func<bool>> jABGlobalLeftMouseClickOnElementCaseSensitiveSearch = null, Expression<Func<bool>> jABGlobalLeftMouseClickOnElementOnlySearchVisibleElements = null, Expression<Func<bool>> jABGlobalLeftMouseClickOnElementOnlySearchShowingElements = null, Expression<Func<string>> jABGlobalLeftMouseClickOnElementElementRolesNotToTraverse = null, Expression<Func<int>> jABGlobalLeftMouseClickOnElementMaximumElementsToSearch = null, Expression<Func<int>> jABGlobalLeftMouseClickOnElementMaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABGlobalLeftMouseClickOnElementClickOffsetX = null, Expression<Func<int>> jABGlobalLeftMouseClickOnElementClickOffsetY = null, Expression<Func<jABGlobalLeftMouseClickOnElementOffsetRelativeToInput>> jABGlobalLeftMouseClickOnElementOffsetRelativeTo = null, Expression<Func<int>> jABGlobalLeftMouseClickOnElementNumberOfTimesToClickElement = null, Expression<Func<double>> jABGlobalLeftMouseClickOnElementSecondsToWaitBetweenClicks = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGlobalLeftMouseClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGlobalLeftMouseClickOnElement = new JObject();
            var jABGlobalLeftMouseClickOnElementpropCount = 0;
            jABGlobalLeftMouseClickOnElementpropCount++;
            jABGlobalLeftMouseClickOnElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementSearchParentElementJABHandle);
            if (jABGlobalLeftMouseClickOnElementSearchElementJABName != null)
            {
                jABGlobalLeftMouseClickOnElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementSearchElementJABName);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementSearchElementJABDescription != null)
            {
                jABGlobalLeftMouseClickOnElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementSearchElementJABDescription);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementSearchElementJABRole != null)
            {
                jABGlobalLeftMouseClickOnElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementSearchElementJABRole);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementSearchSubTree != null)
            {
                jABGlobalLeftMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementSearchSubTree);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementMaxRelativeDepth != null)
            {
                jABGlobalLeftMouseClickOnElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementMaxRelativeDepth);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementMatchIndex != null)
            {
                jABGlobalLeftMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementMatchIndex);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementSearchFilter != null)
            {
                jABGlobalLeftMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementSearchFilter);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementSortByColumn != null)
            {
                jABGlobalLeftMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementSortByColumn);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementMatchIndexAscending != null)
            {
                jABGlobalLeftMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementMatchIndexAscending);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementCaseSensitiveSearch != null)
            {
                jABGlobalLeftMouseClickOnElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementCaseSensitiveSearch);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementOnlySearchVisibleElements != null)
            {
                jABGlobalLeftMouseClickOnElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementOnlySearchVisibleElements);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementOnlySearchShowingElements != null)
            {
                jABGlobalLeftMouseClickOnElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementOnlySearchShowingElements);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementElementRolesNotToTraverse != null)
            {
                jABGlobalLeftMouseClickOnElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementElementRolesNotToTraverse);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementMaximumElementsToSearch != null)
            {
                jABGlobalLeftMouseClickOnElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementMaximumElementsToSearch);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementMaximumChildElementsToSearchPerNode != null)
            {
                jABGlobalLeftMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementMaximumChildElementsToSearchPerNode);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementClickOffsetX != null)
            {
                jABGlobalLeftMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementClickOffsetX);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementClickOffsetY != null)
            {
                jABGlobalLeftMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementClickOffsetY);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementOffsetRelativeTo != null)
            {
                jABGlobalLeftMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementOffsetRelativeTo);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementNumberOfTimesToClickElement != null)
            {
                jABGlobalLeftMouseClickOnElement["NumberOfTimesToClickElement"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementNumberOfTimesToClickElement);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalLeftMouseClickOnElementSecondsToWaitBetweenClicks != null)
            {
                jABGlobalLeftMouseClickOnElement["SecondsToWaitBetweenClicks"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementSecondsToWaitBetweenClicks);
                jABGlobalLeftMouseClickOnElementpropCount++;
            }

            jABGlobalLeftMouseClickOnElementpropCount++;
            jABGlobalLeftMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(jABGlobalLeftMouseClickOnElementWorkflow);
            if (jABGlobalLeftMouseClickOnElementpropCount > 0)
            {
                callPayload.Body = jABGlobalLeftMouseClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalRightMouseClickOnElement(Expression<Func<int>> jABGlobalRightMouseClickOnElementSearchParentElementJABHandle, Expression<Func<string>> jABGlobalRightMouseClickOnElementWorkflow, Expression<Func<string>> jABGlobalRightMouseClickOnElementSearchElementJABName = null, Expression<Func<string>> jABGlobalRightMouseClickOnElementSearchElementJABDescription = null, Expression<Func<string>> jABGlobalRightMouseClickOnElementSearchElementJABRole = null, Expression<Func<bool>> jABGlobalRightMouseClickOnElementSearchSubTree = null, Expression<Func<int>> jABGlobalRightMouseClickOnElementMaxRelativeDepth = null, Expression<Func<int>> jABGlobalRightMouseClickOnElementMatchIndex = null, Expression<Func<string>> jABGlobalRightMouseClickOnElementSearchFilter = null, Expression<Func<string>> jABGlobalRightMouseClickOnElementSortByColumn = null, Expression<Func<bool>> jABGlobalRightMouseClickOnElementMatchIndexAscending = null, Expression<Func<bool>> jABGlobalRightMouseClickOnElementCaseSensitiveSearch = null, Expression<Func<bool>> jABGlobalRightMouseClickOnElementOnlySearchVisibleElements = null, Expression<Func<bool>> jABGlobalRightMouseClickOnElementOnlySearchShowingElements = null, Expression<Func<string>> jABGlobalRightMouseClickOnElementElementRolesNotToTraverse = null, Expression<Func<int>> jABGlobalRightMouseClickOnElementMaximumElementsToSearch = null, Expression<Func<int>> jABGlobalRightMouseClickOnElementMaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABGlobalRightMouseClickOnElementClickOffsetX = null, Expression<Func<int>> jABGlobalRightMouseClickOnElementClickOffsetY = null, Expression<Func<jABGlobalRightMouseClickOnElementOffsetRelativeToInput>> jABGlobalRightMouseClickOnElementOffsetRelativeTo = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGlobalRightMouseClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGlobalRightMouseClickOnElement = new JObject();
            var jABGlobalRightMouseClickOnElementpropCount = 0;
            jABGlobalRightMouseClickOnElementpropCount++;
            jABGlobalRightMouseClickOnElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementSearchParentElementJABHandle);
            if (jABGlobalRightMouseClickOnElementSearchElementJABName != null)
            {
                jABGlobalRightMouseClickOnElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementSearchElementJABName);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementSearchElementJABDescription != null)
            {
                jABGlobalRightMouseClickOnElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementSearchElementJABDescription);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementSearchElementJABRole != null)
            {
                jABGlobalRightMouseClickOnElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementSearchElementJABRole);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementSearchSubTree != null)
            {
                jABGlobalRightMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementSearchSubTree);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementMaxRelativeDepth != null)
            {
                jABGlobalRightMouseClickOnElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementMaxRelativeDepth);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementMatchIndex != null)
            {
                jABGlobalRightMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementMatchIndex);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementSearchFilter != null)
            {
                jABGlobalRightMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementSearchFilter);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementSortByColumn != null)
            {
                jABGlobalRightMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementSortByColumn);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementMatchIndexAscending != null)
            {
                jABGlobalRightMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementMatchIndexAscending);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementCaseSensitiveSearch != null)
            {
                jABGlobalRightMouseClickOnElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementCaseSensitiveSearch);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementOnlySearchVisibleElements != null)
            {
                jABGlobalRightMouseClickOnElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementOnlySearchVisibleElements);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementOnlySearchShowingElements != null)
            {
                jABGlobalRightMouseClickOnElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementOnlySearchShowingElements);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementElementRolesNotToTraverse != null)
            {
                jABGlobalRightMouseClickOnElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementElementRolesNotToTraverse);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementMaximumElementsToSearch != null)
            {
                jABGlobalRightMouseClickOnElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementMaximumElementsToSearch);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementMaximumChildElementsToSearchPerNode != null)
            {
                jABGlobalRightMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementMaximumChildElementsToSearchPerNode);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementClickOffsetX != null)
            {
                jABGlobalRightMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementClickOffsetX);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementClickOffsetY != null)
            {
                jABGlobalRightMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementClickOffsetY);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            if (jABGlobalRightMouseClickOnElementOffsetRelativeTo != null)
            {
                jABGlobalRightMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementOffsetRelativeTo);
                jABGlobalRightMouseClickOnElementpropCount++;
            }

            jABGlobalRightMouseClickOnElementpropCount++;
            jABGlobalRightMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(jABGlobalRightMouseClickOnElementWorkflow);
            if (jABGlobalRightMouseClickOnElementpropCount > 0)
            {
                callPayload.Body = jABGlobalRightMouseClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalMiddleMouseClickOnElement(Expression<Func<int>> jABGlobalMiddleMouseClickOnElementSearchParentElementJABHandle, Expression<Func<string>> jABGlobalMiddleMouseClickOnElementWorkflow, Expression<Func<string>> jABGlobalMiddleMouseClickOnElementSearchElementJABName = null, Expression<Func<string>> jABGlobalMiddleMouseClickOnElementSearchElementJABDescription = null, Expression<Func<string>> jABGlobalMiddleMouseClickOnElementSearchElementJABRole = null, Expression<Func<bool>> jABGlobalMiddleMouseClickOnElementSearchSubTree = null, Expression<Func<int>> jABGlobalMiddleMouseClickOnElementMaxRelativeDepth = null, Expression<Func<int>> jABGlobalMiddleMouseClickOnElementMatchIndex = null, Expression<Func<string>> jABGlobalMiddleMouseClickOnElementSearchFilter = null, Expression<Func<string>> jABGlobalMiddleMouseClickOnElementSortByColumn = null, Expression<Func<bool>> jABGlobalMiddleMouseClickOnElementMatchIndexAscending = null, Expression<Func<bool>> jABGlobalMiddleMouseClickOnElementCaseSensitiveSearch = null, Expression<Func<bool>> jABGlobalMiddleMouseClickOnElementOnlySearchVisibleElements = null, Expression<Func<bool>> jABGlobalMiddleMouseClickOnElementOnlySearchShowingElements = null, Expression<Func<string>> jABGlobalMiddleMouseClickOnElementElementRolesNotToTraverse = null, Expression<Func<int>> jABGlobalMiddleMouseClickOnElementMaximumElementsToSearch = null, Expression<Func<int>> jABGlobalMiddleMouseClickOnElementMaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABGlobalMiddleMouseClickOnElementClickOffsetX = null, Expression<Func<int>> jABGlobalMiddleMouseClickOnElementClickOffsetY = null, Expression<Func<jABGlobalMiddleMouseClickOnElementOffsetRelativeToInput>> jABGlobalMiddleMouseClickOnElementOffsetRelativeTo = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGlobalMiddleMouseClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGlobalMiddleMouseClickOnElement = new JObject();
            var jABGlobalMiddleMouseClickOnElementpropCount = 0;
            jABGlobalMiddleMouseClickOnElementpropCount++;
            jABGlobalMiddleMouseClickOnElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementSearchParentElementJABHandle);
            if (jABGlobalMiddleMouseClickOnElementSearchElementJABName != null)
            {
                jABGlobalMiddleMouseClickOnElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementSearchElementJABName);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementSearchElementJABDescription != null)
            {
                jABGlobalMiddleMouseClickOnElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementSearchElementJABDescription);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementSearchElementJABRole != null)
            {
                jABGlobalMiddleMouseClickOnElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementSearchElementJABRole);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementSearchSubTree != null)
            {
                jABGlobalMiddleMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementSearchSubTree);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementMaxRelativeDepth != null)
            {
                jABGlobalMiddleMouseClickOnElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementMaxRelativeDepth);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementMatchIndex != null)
            {
                jABGlobalMiddleMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementMatchIndex);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementSearchFilter != null)
            {
                jABGlobalMiddleMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementSearchFilter);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementSortByColumn != null)
            {
                jABGlobalMiddleMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementSortByColumn);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementMatchIndexAscending != null)
            {
                jABGlobalMiddleMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementMatchIndexAscending);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementCaseSensitiveSearch != null)
            {
                jABGlobalMiddleMouseClickOnElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementCaseSensitiveSearch);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementOnlySearchVisibleElements != null)
            {
                jABGlobalMiddleMouseClickOnElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementOnlySearchVisibleElements);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementOnlySearchShowingElements != null)
            {
                jABGlobalMiddleMouseClickOnElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementOnlySearchShowingElements);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementElementRolesNotToTraverse != null)
            {
                jABGlobalMiddleMouseClickOnElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementElementRolesNotToTraverse);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementMaximumElementsToSearch != null)
            {
                jABGlobalMiddleMouseClickOnElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementMaximumElementsToSearch);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementMaximumChildElementsToSearchPerNode != null)
            {
                jABGlobalMiddleMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementMaximumChildElementsToSearchPerNode);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementClickOffsetX != null)
            {
                jABGlobalMiddleMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementClickOffsetX);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementClickOffsetY != null)
            {
                jABGlobalMiddleMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementClickOffsetY);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            if (jABGlobalMiddleMouseClickOnElementOffsetRelativeTo != null)
            {
                jABGlobalMiddleMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementOffsetRelativeTo);
                jABGlobalMiddleMouseClickOnElementpropCount++;
            }

            jABGlobalMiddleMouseClickOnElementpropCount++;
            jABGlobalMiddleMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(jABGlobalMiddleMouseClickOnElementWorkflow);
            if (jABGlobalMiddleMouseClickOnElementpropCount > 0)
            {
                callPayload.Body = jABGlobalMiddleMouseClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalDoubleLeftMouseClickOnElement(Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementSearchParentElementJABHandle, Expression<Func<string>> jABGlobalDoubleLeftMouseClickOnElementWorkflow, Expression<Func<string>> jABGlobalDoubleLeftMouseClickOnElementSearchElementJABName = null, Expression<Func<string>> jABGlobalDoubleLeftMouseClickOnElementSearchElementJABDescription = null, Expression<Func<string>> jABGlobalDoubleLeftMouseClickOnElementSearchElementJABRole = null, Expression<Func<bool>> jABGlobalDoubleLeftMouseClickOnElementSearchSubTree = null, Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementMaxRelativeDepth = null, Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementMatchIndex = null, Expression<Func<string>> jABGlobalDoubleLeftMouseClickOnElementSearchFilter = null, Expression<Func<string>> jABGlobalDoubleLeftMouseClickOnElementSortByColumn = null, Expression<Func<bool>> jABGlobalDoubleLeftMouseClickOnElementMatchIndexAscending = null, Expression<Func<bool>> jABGlobalDoubleLeftMouseClickOnElementCaseSensitiveSearch = null, Expression<Func<bool>> jABGlobalDoubleLeftMouseClickOnElementOnlySearchVisibleElements = null, Expression<Func<bool>> jABGlobalDoubleLeftMouseClickOnElementOnlySearchShowingElements = null, Expression<Func<string>> jABGlobalDoubleLeftMouseClickOnElementElementRolesNotToTraverse = null, Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementMaximumElementsToSearch = null, Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementMaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementClickOffsetX = null, Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementClickOffsetY = null, Expression<Func<jABGlobalDoubleLeftMouseClickOnElementOffsetRelativeToInput>> jABGlobalDoubleLeftMouseClickOnElementOffsetRelativeTo = null, Expression<Func<int>> jABGlobalDoubleLeftMouseClickOnElementDelayInMilliseconds = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGlobalDoubleLeftMouseClickOnElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGlobalDoubleLeftMouseClickOnElement = new JObject();
            var jABGlobalDoubleLeftMouseClickOnElementpropCount = 0;
            jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            jABGlobalDoubleLeftMouseClickOnElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementSearchParentElementJABHandle);
            if (jABGlobalDoubleLeftMouseClickOnElementSearchElementJABName != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementSearchElementJABName);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementSearchElementJABDescription != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementSearchElementJABDescription);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementSearchElementJABRole != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementSearchElementJABRole);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementSearchSubTree != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementSearchSubTree);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementMaxRelativeDepth != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementMaxRelativeDepth);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementMatchIndex != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementMatchIndex);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementSearchFilter != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementSearchFilter);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementSortByColumn != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementSortByColumn);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementMatchIndexAscending != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementMatchIndexAscending);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementCaseSensitiveSearch != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementCaseSensitiveSearch);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementOnlySearchVisibleElements != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementOnlySearchVisibleElements);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementOnlySearchShowingElements != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementOnlySearchShowingElements);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementElementRolesNotToTraverse != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementElementRolesNotToTraverse);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementMaximumElementsToSearch != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementMaximumElementsToSearch);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementMaximumChildElementsToSearchPerNode != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementMaximumChildElementsToSearchPerNode);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementClickOffsetX != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementClickOffsetX);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementClickOffsetY != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementClickOffsetY);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementOffsetRelativeTo != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementOffsetRelativeTo);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            if (jABGlobalDoubleLeftMouseClickOnElementDelayInMilliseconds != null)
            {
                jABGlobalDoubleLeftMouseClickOnElement["DelayInMilliseconds"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementDelayInMilliseconds);
                jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            }

            jABGlobalDoubleLeftMouseClickOnElementpropCount++;
            jABGlobalDoubleLeftMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(jABGlobalDoubleLeftMouseClickOnElementWorkflow);
            if (jABGlobalDoubleLeftMouseClickOnElementpropCount > 0)
            {
                callPayload.Body = jABGlobalDoubleLeftMouseClickOnElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetActionsForElementResponse> JABGetActionsForElement(Expression<Func<int>> jABGetActionsForElementSearchParentElementJABHandle, Expression<Func<string>> jABGetActionsForElementWorkflow, Expression<Func<string>> jABGetActionsForElementSearchElementJABName = null, Expression<Func<string>> jABGetActionsForElementSearchElementJABDescription = null, Expression<Func<string>> jABGetActionsForElementSearchElementJABRole = null, Expression<Func<bool>> jABGetActionsForElementSearchSubTree = null, Expression<Func<int>> jABGetActionsForElementMaxRelativeDepth = null, Expression<Func<int>> jABGetActionsForElementMatchIndex = null, Expression<Func<string>> jABGetActionsForElementSearchFilter = null, Expression<Func<string>> jABGetActionsForElementSortByColumn = null, Expression<Func<bool>> jABGetActionsForElementMatchIndexAscending = null, Expression<Func<bool>> jABGetActionsForElementCaseSensitiveSearch = null, Expression<Func<bool>> jABGetActionsForElementOnlySearchVisibleElements = null, Expression<Func<bool>> jABGetActionsForElementOnlySearchShowingElements = null, Expression<Func<string>> jABGetActionsForElementElementRolesNotToTraverse = null, Expression<Func<int>> jABGetActionsForElementMaximumElementsToSearch = null, Expression<Func<int>> jABGetActionsForElementMaximumChildElementsToSearchPerNode = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetActionsForElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetActionsForElement = new JObject();
            var jABGetActionsForElementpropCount = 0;
            jABGetActionsForElementpropCount++;
            jABGetActionsForElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetActionsForElementSearchParentElementJABHandle);
            if (jABGetActionsForElementSearchElementJABName != null)
            {
                jABGetActionsForElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetActionsForElementSearchElementJABName);
                jABGetActionsForElementpropCount++;
            }

            if (jABGetActionsForElementSearchElementJABDescription != null)
            {
                jABGetActionsForElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetActionsForElementSearchElementJABDescription);
                jABGetActionsForElementpropCount++;
            }

            if (jABGetActionsForElementSearchElementJABRole != null)
            {
                jABGetActionsForElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetActionsForElementSearchElementJABRole);
                jABGetActionsForElementpropCount++;
            }

            if (jABGetActionsForElementSearchSubTree != null)
            {
                jABGetActionsForElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetActionsForElementSearchSubTree);
                jABGetActionsForElementpropCount++;
            }

            if (jABGetActionsForElementMaxRelativeDepth != null)
            {
                jABGetActionsForElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetActionsForElementMaxRelativeDepth);
                jABGetActionsForElementpropCount++;
            }

            if (jABGetActionsForElementMatchIndex != null)
            {
                jABGetActionsForElement["MatchIndex"] = ExpressionConverter.ConvertO(jABGetActionsForElementMatchIndex);
                jABGetActionsForElementpropCount++;
            }

            if (jABGetActionsForElementSearchFilter != null)
            {
                jABGetActionsForElement["SearchFilter"] = ExpressionConverter.ConvertO(jABGetActionsForElementSearchFilter);
                jABGetActionsForElementpropCount++;
            }

            if (jABGetActionsForElementSortByColumn != null)
            {
                jABGetActionsForElement["SortByColumn"] = ExpressionConverter.ConvertO(jABGetActionsForElementSortByColumn);
                jABGetActionsForElementpropCount++;
            }

            if (jABGetActionsForElementMatchIndexAscending != null)
            {
                jABGetActionsForElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetActionsForElementMatchIndexAscending);
                jABGetActionsForElementpropCount++;
            }

            if (jABGetActionsForElementCaseSensitiveSearch != null)
            {
                jABGetActionsForElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetActionsForElementCaseSensitiveSearch);
                jABGetActionsForElementpropCount++;
            }

            if (jABGetActionsForElementOnlySearchVisibleElements != null)
            {
                jABGetActionsForElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetActionsForElementOnlySearchVisibleElements);
                jABGetActionsForElementpropCount++;
            }

            if (jABGetActionsForElementOnlySearchShowingElements != null)
            {
                jABGetActionsForElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetActionsForElementOnlySearchShowingElements);
                jABGetActionsForElementpropCount++;
            }

            if (jABGetActionsForElementElementRolesNotToTraverse != null)
            {
                jABGetActionsForElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetActionsForElementElementRolesNotToTraverse);
                jABGetActionsForElementpropCount++;
            }

            if (jABGetActionsForElementMaximumElementsToSearch != null)
            {
                jABGetActionsForElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetActionsForElementMaximumElementsToSearch);
                jABGetActionsForElementpropCount++;
            }

            if (jABGetActionsForElementMaximumChildElementsToSearchPerNode != null)
            {
                jABGetActionsForElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetActionsForElementMaximumChildElementsToSearchPerNode);
                jABGetActionsForElementpropCount++;
            }

            jABGetActionsForElementpropCount++;
            jABGetActionsForElement["Workflow"] = ExpressionConverter.ConvertO(jABGetActionsForElementWorkflow);
            if (jABGetActionsForElementpropCount > 0)
            {
                callPayload.Body = jABGetActionsForElement;
            }

            return new ApiConnectionAction<JABGetActionsForElementResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABFocusElement(Expression<Func<int>> jABFocusElementSearchParentElementJABHandle, Expression<Func<string>> jABFocusElementWorkflow, Expression<Func<string>> jABFocusElementSearchElementJABName = null, Expression<Func<string>> jABFocusElementSearchElementJABDescription = null, Expression<Func<string>> jABFocusElementSearchElementJABRole = null, Expression<Func<bool>> jABFocusElementSearchSubTree = null, Expression<Func<int>> jABFocusElementMaxRelativeDepth = null, Expression<Func<int>> jABFocusElementMatchIndex = null, Expression<Func<string>> jABFocusElementSearchFilter = null, Expression<Func<string>> jABFocusElementSortByColumn = null, Expression<Func<bool>> jABFocusElementMatchIndexAscending = null, Expression<Func<bool>> jABFocusElementCaseSensitiveSearch = null, Expression<Func<bool>> jABFocusElementOnlySearchVisibleElements = null, Expression<Func<bool>> jABFocusElementOnlySearchShowingElements = null, Expression<Func<string>> jABFocusElementElementRolesNotToTraverse = null, Expression<Func<int>> jABFocusElementMaximumElementsToSearch = null, Expression<Func<int>> jABFocusElementMaximumChildElementsToSearchPerNode = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABFocusElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABFocusElement = new JObject();
            var jABFocusElementpropCount = 0;
            jABFocusElementpropCount++;
            jABFocusElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABFocusElementSearchParentElementJABHandle);
            if (jABFocusElementSearchElementJABName != null)
            {
                jABFocusElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABFocusElementSearchElementJABName);
                jABFocusElementpropCount++;
            }

            if (jABFocusElementSearchElementJABDescription != null)
            {
                jABFocusElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABFocusElementSearchElementJABDescription);
                jABFocusElementpropCount++;
            }

            if (jABFocusElementSearchElementJABRole != null)
            {
                jABFocusElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABFocusElementSearchElementJABRole);
                jABFocusElementpropCount++;
            }

            if (jABFocusElementSearchSubTree != null)
            {
                jABFocusElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABFocusElementSearchSubTree);
                jABFocusElementpropCount++;
            }

            if (jABFocusElementMaxRelativeDepth != null)
            {
                jABFocusElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABFocusElementMaxRelativeDepth);
                jABFocusElementpropCount++;
            }

            if (jABFocusElementMatchIndex != null)
            {
                jABFocusElement["MatchIndex"] = ExpressionConverter.ConvertO(jABFocusElementMatchIndex);
                jABFocusElementpropCount++;
            }

            if (jABFocusElementSearchFilter != null)
            {
                jABFocusElement["SearchFilter"] = ExpressionConverter.ConvertO(jABFocusElementSearchFilter);
                jABFocusElementpropCount++;
            }

            if (jABFocusElementSortByColumn != null)
            {
                jABFocusElement["SortByColumn"] = ExpressionConverter.ConvertO(jABFocusElementSortByColumn);
                jABFocusElementpropCount++;
            }

            if (jABFocusElementMatchIndexAscending != null)
            {
                jABFocusElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABFocusElementMatchIndexAscending);
                jABFocusElementpropCount++;
            }

            if (jABFocusElementCaseSensitiveSearch != null)
            {
                jABFocusElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABFocusElementCaseSensitiveSearch);
                jABFocusElementpropCount++;
            }

            if (jABFocusElementOnlySearchVisibleElements != null)
            {
                jABFocusElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABFocusElementOnlySearchVisibleElements);
                jABFocusElementpropCount++;
            }

            if (jABFocusElementOnlySearchShowingElements != null)
            {
                jABFocusElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABFocusElementOnlySearchShowingElements);
                jABFocusElementpropCount++;
            }

            if (jABFocusElementElementRolesNotToTraverse != null)
            {
                jABFocusElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABFocusElementElementRolesNotToTraverse);
                jABFocusElementpropCount++;
            }

            if (jABFocusElementMaximumElementsToSearch != null)
            {
                jABFocusElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABFocusElementMaximumElementsToSearch);
                jABFocusElementpropCount++;
            }

            if (jABFocusElementMaximumChildElementsToSearchPerNode != null)
            {
                jABFocusElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABFocusElementMaximumChildElementsToSearchPerNode);
                jABFocusElementpropCount++;
            }

            jABFocusElementpropCount++;
            jABFocusElement["Workflow"] = ExpressionConverter.ConvertO(jABFocusElementWorkflow);
            if (jABFocusElementpropCount > 0)
            {
                callPayload.Body = jABFocusElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABInputPasswordIntoElement(Expression<Func<int>> jABInputPasswordIntoElementSearchParentElementJABHandle, Expression<Func<string>> jABInputPasswordIntoElementPasswordToInput, Expression<Func<string>> jABInputPasswordIntoElementWorkflow, Expression<Func<string>> jABInputPasswordIntoElementSearchElementJABName = null, Expression<Func<string>> jABInputPasswordIntoElementSearchElementJABDescription = null, Expression<Func<string>> jABInputPasswordIntoElementSearchElementJABRole = null, Expression<Func<bool>> jABInputPasswordIntoElementSearchSubTree = null, Expression<Func<int>> jABInputPasswordIntoElementMaxRelativeDepth = null, Expression<Func<int>> jABInputPasswordIntoElementMatchIndex = null, Expression<Func<string>> jABInputPasswordIntoElementSearchFilter = null, Expression<Func<string>> jABInputPasswordIntoElementSortByColumn = null, Expression<Func<bool>> jABInputPasswordIntoElementMatchIndexAscending = null, Expression<Func<bool>> jABInputPasswordIntoElementCaseSensitiveSearch = null, Expression<Func<bool>> jABInputPasswordIntoElementOnlySearchVisibleElements = null, Expression<Func<bool>> jABInputPasswordIntoElementOnlySearchShowingElements = null, Expression<Func<string>> jABInputPasswordIntoElementElementRolesNotToTraverse = null, Expression<Func<int>> jABInputPasswordIntoElementMaximumElementsToSearch = null, Expression<Func<int>> jABInputPasswordIntoElementMaximumChildElementsToSearchPerNode = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABInputPasswordIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABInputPasswordIntoElement = new JObject();
            var jABInputPasswordIntoElementpropCount = 0;
            jABInputPasswordIntoElementpropCount++;
            jABInputPasswordIntoElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementSearchParentElementJABHandle);
            if (jABInputPasswordIntoElementSearchElementJABName != null)
            {
                jABInputPasswordIntoElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementSearchElementJABName);
                jABInputPasswordIntoElementpropCount++;
            }

            if (jABInputPasswordIntoElementSearchElementJABDescription != null)
            {
                jABInputPasswordIntoElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementSearchElementJABDescription);
                jABInputPasswordIntoElementpropCount++;
            }

            if (jABInputPasswordIntoElementSearchElementJABRole != null)
            {
                jABInputPasswordIntoElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementSearchElementJABRole);
                jABInputPasswordIntoElementpropCount++;
            }

            if (jABInputPasswordIntoElementSearchSubTree != null)
            {
                jABInputPasswordIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementSearchSubTree);
                jABInputPasswordIntoElementpropCount++;
            }

            if (jABInputPasswordIntoElementMaxRelativeDepth != null)
            {
                jABInputPasswordIntoElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementMaxRelativeDepth);
                jABInputPasswordIntoElementpropCount++;
            }

            if (jABInputPasswordIntoElementMatchIndex != null)
            {
                jABInputPasswordIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementMatchIndex);
                jABInputPasswordIntoElementpropCount++;
            }

            if (jABInputPasswordIntoElementSearchFilter != null)
            {
                jABInputPasswordIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementSearchFilter);
                jABInputPasswordIntoElementpropCount++;
            }

            if (jABInputPasswordIntoElementSortByColumn != null)
            {
                jABInputPasswordIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementSortByColumn);
                jABInputPasswordIntoElementpropCount++;
            }

            if (jABInputPasswordIntoElementMatchIndexAscending != null)
            {
                jABInputPasswordIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementMatchIndexAscending);
                jABInputPasswordIntoElementpropCount++;
            }

            if (jABInputPasswordIntoElementCaseSensitiveSearch != null)
            {
                jABInputPasswordIntoElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementCaseSensitiveSearch);
                jABInputPasswordIntoElementpropCount++;
            }

            if (jABInputPasswordIntoElementOnlySearchVisibleElements != null)
            {
                jABInputPasswordIntoElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementOnlySearchVisibleElements);
                jABInputPasswordIntoElementpropCount++;
            }

            if (jABInputPasswordIntoElementOnlySearchShowingElements != null)
            {
                jABInputPasswordIntoElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementOnlySearchShowingElements);
                jABInputPasswordIntoElementpropCount++;
            }

            if (jABInputPasswordIntoElementElementRolesNotToTraverse != null)
            {
                jABInputPasswordIntoElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementElementRolesNotToTraverse);
                jABInputPasswordIntoElementpropCount++;
            }

            if (jABInputPasswordIntoElementMaximumElementsToSearch != null)
            {
                jABInputPasswordIntoElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementMaximumElementsToSearch);
                jABInputPasswordIntoElementpropCount++;
            }

            if (jABInputPasswordIntoElementMaximumChildElementsToSearchPerNode != null)
            {
                jABInputPasswordIntoElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementMaximumChildElementsToSearchPerNode);
                jABInputPasswordIntoElementpropCount++;
            }

            jABInputPasswordIntoElementpropCount++;
            jABInputPasswordIntoElement["PasswordToInput"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementPasswordToInput);
            jABInputPasswordIntoElementpropCount++;
            jABInputPasswordIntoElement["Workflow"] = ExpressionConverter.ConvertO(jABInputPasswordIntoElementWorkflow);
            if (jABInputPasswordIntoElementpropCount > 0)
            {
                callPayload.Body = jABInputPasswordIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABInputTextIntoElement(Expression<Func<int>> jABInputTextIntoElementSearchParentElementJABHandle, Expression<Func<string>> jABInputTextIntoElementWorkflow, Expression<Func<string>> jABInputTextIntoElementSearchElementJABName = null, Expression<Func<string>> jABInputTextIntoElementSearchElementJABDescription = null, Expression<Func<string>> jABInputTextIntoElementSearchElementJABRole = null, Expression<Func<bool>> jABInputTextIntoElementSearchSubTree = null, Expression<Func<int>> jABInputTextIntoElementMaxRelativeDepth = null, Expression<Func<int>> jABInputTextIntoElementMatchIndex = null, Expression<Func<string>> jABInputTextIntoElementSearchFilter = null, Expression<Func<string>> jABInputTextIntoElementSortByColumn = null, Expression<Func<bool>> jABInputTextIntoElementMatchIndexAscending = null, Expression<Func<bool>> jABInputTextIntoElementCaseSensitiveSearch = null, Expression<Func<bool>> jABInputTextIntoElementOnlySearchVisibleElements = null, Expression<Func<bool>> jABInputTextIntoElementOnlySearchShowingElements = null, Expression<Func<string>> jABInputTextIntoElementElementRolesNotToTraverse = null, Expression<Func<int>> jABInputTextIntoElementMaximumElementsToSearch = null, Expression<Func<int>> jABInputTextIntoElementMaximumChildElementsToSearchPerNode = null, Expression<Func<string>> jABInputTextIntoElementTextToInput = null, Expression<Func<bool>> jABInputTextIntoElementReplaceExistingValue = null, Expression<Func<int>> jABInputTextIntoElementInsertPosition = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABInputTextIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABInputTextIntoElement = new JObject();
            var jABInputTextIntoElementpropCount = 0;
            jABInputTextIntoElementpropCount++;
            jABInputTextIntoElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABInputTextIntoElementSearchParentElementJABHandle);
            if (jABInputTextIntoElementSearchElementJABName != null)
            {
                jABInputTextIntoElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABInputTextIntoElementSearchElementJABName);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementSearchElementJABDescription != null)
            {
                jABInputTextIntoElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABInputTextIntoElementSearchElementJABDescription);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementSearchElementJABRole != null)
            {
                jABInputTextIntoElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABInputTextIntoElementSearchElementJABRole);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementSearchSubTree != null)
            {
                jABInputTextIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABInputTextIntoElementSearchSubTree);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementMaxRelativeDepth != null)
            {
                jABInputTextIntoElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABInputTextIntoElementMaxRelativeDepth);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementMatchIndex != null)
            {
                jABInputTextIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(jABInputTextIntoElementMatchIndex);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementSearchFilter != null)
            {
                jABInputTextIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(jABInputTextIntoElementSearchFilter);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementSortByColumn != null)
            {
                jABInputTextIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(jABInputTextIntoElementSortByColumn);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementMatchIndexAscending != null)
            {
                jABInputTextIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABInputTextIntoElementMatchIndexAscending);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementCaseSensitiveSearch != null)
            {
                jABInputTextIntoElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABInputTextIntoElementCaseSensitiveSearch);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementOnlySearchVisibleElements != null)
            {
                jABInputTextIntoElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABInputTextIntoElementOnlySearchVisibleElements);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementOnlySearchShowingElements != null)
            {
                jABInputTextIntoElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABInputTextIntoElementOnlySearchShowingElements);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementElementRolesNotToTraverse != null)
            {
                jABInputTextIntoElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABInputTextIntoElementElementRolesNotToTraverse);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementMaximumElementsToSearch != null)
            {
                jABInputTextIntoElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABInputTextIntoElementMaximumElementsToSearch);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementMaximumChildElementsToSearchPerNode != null)
            {
                jABInputTextIntoElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABInputTextIntoElementMaximumChildElementsToSearchPerNode);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementTextToInput != null)
            {
                jABInputTextIntoElement["TextToInput"] = ExpressionConverter.ConvertO(jABInputTextIntoElementTextToInput);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementReplaceExistingValue != null)
            {
                jABInputTextIntoElement["ReplaceExistingValue"] = ExpressionConverter.ConvertO(jABInputTextIntoElementReplaceExistingValue);
                jABInputTextIntoElementpropCount++;
            }

            if (jABInputTextIntoElementInsertPosition != null)
            {
                jABInputTextIntoElement["InsertPosition"] = ExpressionConverter.ConvertO(jABInputTextIntoElementInsertPosition);
                jABInputTextIntoElementpropCount++;
            }

            jABInputTextIntoElementpropCount++;
            jABInputTextIntoElement["Workflow"] = ExpressionConverter.ConvertO(jABInputTextIntoElementWorkflow);
            if (jABInputTextIntoElementpropCount > 0)
            {
                callPayload.Body = jABInputTextIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetElementTextValueResponse> JABGetElementTextValue(Expression<Func<int>> jABGetElementTextValueSearchParentElementJABHandle, Expression<Func<string>> jABGetElementTextValueWorkflow, Expression<Func<string>> jABGetElementTextValueSearchElementJABName = null, Expression<Func<string>> jABGetElementTextValueSearchElementJABDescription = null, Expression<Func<string>> jABGetElementTextValueSearchElementJABRole = null, Expression<Func<bool>> jABGetElementTextValueSearchSubTree = null, Expression<Func<int>> jABGetElementTextValueMaxRelativeDepth = null, Expression<Func<int>> jABGetElementTextValueMatchIndex = null, Expression<Func<string>> jABGetElementTextValueSearchFilter = null, Expression<Func<string>> jABGetElementTextValueSortByColumn = null, Expression<Func<bool>> jABGetElementTextValueMatchIndexAscending = null, Expression<Func<bool>> jABGetElementTextValueCaseSensitiveSearch = null, Expression<Func<bool>> jABGetElementTextValueOnlySearchVisibleElements = null, Expression<Func<bool>> jABGetElementTextValueOnlySearchShowingElements = null, Expression<Func<string>> jABGetElementTextValueElementRolesNotToTraverse = null, Expression<Func<int>> jABGetElementTextValueMaximumElementsToSearch = null, Expression<Func<int>> jABGetElementTextValueMaximumChildElementsToSearchPerNode = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetElementTextValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetElementTextValue = new JObject();
            var jABGetElementTextValuepropCount = 0;
            jABGetElementTextValuepropCount++;
            jABGetElementTextValue["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetElementTextValueSearchParentElementJABHandle);
            if (jABGetElementTextValueSearchElementJABName != null)
            {
                jABGetElementTextValue["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetElementTextValueSearchElementJABName);
                jABGetElementTextValuepropCount++;
            }

            if (jABGetElementTextValueSearchElementJABDescription != null)
            {
                jABGetElementTextValue["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetElementTextValueSearchElementJABDescription);
                jABGetElementTextValuepropCount++;
            }

            if (jABGetElementTextValueSearchElementJABRole != null)
            {
                jABGetElementTextValue["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetElementTextValueSearchElementJABRole);
                jABGetElementTextValuepropCount++;
            }

            if (jABGetElementTextValueSearchSubTree != null)
            {
                jABGetElementTextValue["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetElementTextValueSearchSubTree);
                jABGetElementTextValuepropCount++;
            }

            if (jABGetElementTextValueMaxRelativeDepth != null)
            {
                jABGetElementTextValue["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetElementTextValueMaxRelativeDepth);
                jABGetElementTextValuepropCount++;
            }

            if (jABGetElementTextValueMatchIndex != null)
            {
                jABGetElementTextValue["MatchIndex"] = ExpressionConverter.ConvertO(jABGetElementTextValueMatchIndex);
                jABGetElementTextValuepropCount++;
            }

            if (jABGetElementTextValueSearchFilter != null)
            {
                jABGetElementTextValue["SearchFilter"] = ExpressionConverter.ConvertO(jABGetElementTextValueSearchFilter);
                jABGetElementTextValuepropCount++;
            }

            if (jABGetElementTextValueSortByColumn != null)
            {
                jABGetElementTextValue["SortByColumn"] = ExpressionConverter.ConvertO(jABGetElementTextValueSortByColumn);
                jABGetElementTextValuepropCount++;
            }

            if (jABGetElementTextValueMatchIndexAscending != null)
            {
                jABGetElementTextValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetElementTextValueMatchIndexAscending);
                jABGetElementTextValuepropCount++;
            }

            if (jABGetElementTextValueCaseSensitiveSearch != null)
            {
                jABGetElementTextValue["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetElementTextValueCaseSensitiveSearch);
                jABGetElementTextValuepropCount++;
            }

            if (jABGetElementTextValueOnlySearchVisibleElements != null)
            {
                jABGetElementTextValue["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetElementTextValueOnlySearchVisibleElements);
                jABGetElementTextValuepropCount++;
            }

            if (jABGetElementTextValueOnlySearchShowingElements != null)
            {
                jABGetElementTextValue["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetElementTextValueOnlySearchShowingElements);
                jABGetElementTextValuepropCount++;
            }

            if (jABGetElementTextValueElementRolesNotToTraverse != null)
            {
                jABGetElementTextValue["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetElementTextValueElementRolesNotToTraverse);
                jABGetElementTextValuepropCount++;
            }

            if (jABGetElementTextValueMaximumElementsToSearch != null)
            {
                jABGetElementTextValue["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetElementTextValueMaximumElementsToSearch);
                jABGetElementTextValuepropCount++;
            }

            if (jABGetElementTextValueMaximumChildElementsToSearchPerNode != null)
            {
                jABGetElementTextValue["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetElementTextValueMaximumChildElementsToSearchPerNode);
                jABGetElementTextValuepropCount++;
            }

            jABGetElementTextValuepropCount++;
            jABGetElementTextValue["Workflow"] = ExpressionConverter.ConvertO(jABGetElementTextValueWorkflow);
            if (jABGetElementTextValuepropCount > 0)
            {
                callPayload.Body = jABGetElementTextValue;
            }

            return new ApiConnectionAction<JABGetElementTextValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetElementValueResponse> JABGetElementValue(Expression<Func<int>> jABGetElementValueSearchParentElementJABHandle, Expression<Func<string>> jABGetElementValueWorkflow, Expression<Func<string>> jABGetElementValueSearchElementJABName = null, Expression<Func<string>> jABGetElementValueSearchElementJABDescription = null, Expression<Func<string>> jABGetElementValueSearchElementJABRole = null, Expression<Func<bool>> jABGetElementValueSearchSubTree = null, Expression<Func<int>> jABGetElementValueMaxRelativeDepth = null, Expression<Func<int>> jABGetElementValueMatchIndex = null, Expression<Func<string>> jABGetElementValueSearchFilter = null, Expression<Func<string>> jABGetElementValueSortByColumn = null, Expression<Func<bool>> jABGetElementValueMatchIndexAscending = null, Expression<Func<bool>> jABGetElementValueCaseSensitiveSearch = null, Expression<Func<bool>> jABGetElementValueOnlySearchVisibleElements = null, Expression<Func<bool>> jABGetElementValueOnlySearchShowingElements = null, Expression<Func<string>> jABGetElementValueElementRolesNotToTraverse = null, Expression<Func<int>> jABGetElementValueMaximumElementsToSearch = null, Expression<Func<int>> jABGetElementValueMaximumChildElementsToSearchPerNode = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetElementValue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetElementValue = new JObject();
            var jABGetElementValuepropCount = 0;
            jABGetElementValuepropCount++;
            jABGetElementValue["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetElementValueSearchParentElementJABHandle);
            if (jABGetElementValueSearchElementJABName != null)
            {
                jABGetElementValue["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetElementValueSearchElementJABName);
                jABGetElementValuepropCount++;
            }

            if (jABGetElementValueSearchElementJABDescription != null)
            {
                jABGetElementValue["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetElementValueSearchElementJABDescription);
                jABGetElementValuepropCount++;
            }

            if (jABGetElementValueSearchElementJABRole != null)
            {
                jABGetElementValue["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetElementValueSearchElementJABRole);
                jABGetElementValuepropCount++;
            }

            if (jABGetElementValueSearchSubTree != null)
            {
                jABGetElementValue["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetElementValueSearchSubTree);
                jABGetElementValuepropCount++;
            }

            if (jABGetElementValueMaxRelativeDepth != null)
            {
                jABGetElementValue["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetElementValueMaxRelativeDepth);
                jABGetElementValuepropCount++;
            }

            if (jABGetElementValueMatchIndex != null)
            {
                jABGetElementValue["MatchIndex"] = ExpressionConverter.ConvertO(jABGetElementValueMatchIndex);
                jABGetElementValuepropCount++;
            }

            if (jABGetElementValueSearchFilter != null)
            {
                jABGetElementValue["SearchFilter"] = ExpressionConverter.ConvertO(jABGetElementValueSearchFilter);
                jABGetElementValuepropCount++;
            }

            if (jABGetElementValueSortByColumn != null)
            {
                jABGetElementValue["SortByColumn"] = ExpressionConverter.ConvertO(jABGetElementValueSortByColumn);
                jABGetElementValuepropCount++;
            }

            if (jABGetElementValueMatchIndexAscending != null)
            {
                jABGetElementValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetElementValueMatchIndexAscending);
                jABGetElementValuepropCount++;
            }

            if (jABGetElementValueCaseSensitiveSearch != null)
            {
                jABGetElementValue["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetElementValueCaseSensitiveSearch);
                jABGetElementValuepropCount++;
            }

            if (jABGetElementValueOnlySearchVisibleElements != null)
            {
                jABGetElementValue["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetElementValueOnlySearchVisibleElements);
                jABGetElementValuepropCount++;
            }

            if (jABGetElementValueOnlySearchShowingElements != null)
            {
                jABGetElementValue["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetElementValueOnlySearchShowingElements);
                jABGetElementValuepropCount++;
            }

            if (jABGetElementValueElementRolesNotToTraverse != null)
            {
                jABGetElementValue["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetElementValueElementRolesNotToTraverse);
                jABGetElementValuepropCount++;
            }

            if (jABGetElementValueMaximumElementsToSearch != null)
            {
                jABGetElementValue["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetElementValueMaximumElementsToSearch);
                jABGetElementValuepropCount++;
            }

            if (jABGetElementValueMaximumChildElementsToSearchPerNode != null)
            {
                jABGetElementValue["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetElementValueMaximumChildElementsToSearchPerNode);
                jABGetElementValuepropCount++;
            }

            jABGetElementValuepropCount++;
            jABGetElementValue["Workflow"] = ExpressionConverter.ConvertO(jABGetElementValueWorkflow);
            if (jABGetElementValuepropCount > 0)
            {
                callPayload.Body = jABGetElementValue;
            }

            return new ApiConnectionAction<JABGetElementValueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABCheckElement(Expression<Func<int>> jABCheckElementSearchParentElementJABHandle, Expression<Func<string>> jABCheckElementWorkflow, Expression<Func<string>> jABCheckElementSearchElementJABName = null, Expression<Func<string>> jABCheckElementSearchElementJABDescription = null, Expression<Func<string>> jABCheckElementSearchElementJABRole = null, Expression<Func<bool>> jABCheckElementSearchSubTree = null, Expression<Func<int>> jABCheckElementMaxRelativeDepth = null, Expression<Func<int>> jABCheckElementMatchIndex = null, Expression<Func<string>> jABCheckElementSearchFilter = null, Expression<Func<string>> jABCheckElementSortByColumn = null, Expression<Func<bool>> jABCheckElementMatchIndexAscending = null, Expression<Func<bool>> jABCheckElementCaseSensitiveSearch = null, Expression<Func<bool>> jABCheckElementOnlySearchVisibleElements = null, Expression<Func<bool>> jABCheckElementOnlySearchShowingElements = null, Expression<Func<string>> jABCheckElementElementRolesNotToTraverse = null, Expression<Func<int>> jABCheckElementMaximumElementsToSearch = null, Expression<Func<int>> jABCheckElementMaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABCheckElementCheckElement = null, Expression<Func<bool>> jABCheckElementAutoDetectActionName = null, Expression<Func<string>> jABCheckElementOverrideActionName = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABCheckElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABCheckElement = new JObject();
            var jABCheckElementpropCount = 0;
            jABCheckElementpropCount++;
            jABCheckElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABCheckElementSearchParentElementJABHandle);
            if (jABCheckElementSearchElementJABName != null)
            {
                jABCheckElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABCheckElementSearchElementJABName);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementSearchElementJABDescription != null)
            {
                jABCheckElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABCheckElementSearchElementJABDescription);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementSearchElementJABRole != null)
            {
                jABCheckElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABCheckElementSearchElementJABRole);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementSearchSubTree != null)
            {
                jABCheckElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABCheckElementSearchSubTree);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementMaxRelativeDepth != null)
            {
                jABCheckElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABCheckElementMaxRelativeDepth);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementMatchIndex != null)
            {
                jABCheckElement["MatchIndex"] = ExpressionConverter.ConvertO(jABCheckElementMatchIndex);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementSearchFilter != null)
            {
                jABCheckElement["SearchFilter"] = ExpressionConverter.ConvertO(jABCheckElementSearchFilter);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementSortByColumn != null)
            {
                jABCheckElement["SortByColumn"] = ExpressionConverter.ConvertO(jABCheckElementSortByColumn);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementMatchIndexAscending != null)
            {
                jABCheckElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABCheckElementMatchIndexAscending);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementCaseSensitiveSearch != null)
            {
                jABCheckElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABCheckElementCaseSensitiveSearch);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementOnlySearchVisibleElements != null)
            {
                jABCheckElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABCheckElementOnlySearchVisibleElements);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementOnlySearchShowingElements != null)
            {
                jABCheckElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABCheckElementOnlySearchShowingElements);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementElementRolesNotToTraverse != null)
            {
                jABCheckElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABCheckElementElementRolesNotToTraverse);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementMaximumElementsToSearch != null)
            {
                jABCheckElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABCheckElementMaximumElementsToSearch);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementMaximumChildElementsToSearchPerNode != null)
            {
                jABCheckElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABCheckElementMaximumChildElementsToSearchPerNode);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementCheckElement != null)
            {
                jABCheckElement["CheckElement"] = ExpressionConverter.ConvertO(jABCheckElementCheckElement);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementAutoDetectActionName != null)
            {
                jABCheckElement["AutoDetectActionName"] = ExpressionConverter.ConvertO(jABCheckElementAutoDetectActionName);
                jABCheckElementpropCount++;
            }

            if (jABCheckElementOverrideActionName != null)
            {
                jABCheckElement["OverrideActionName"] = ExpressionConverter.ConvertO(jABCheckElementOverrideActionName);
                jABCheckElementpropCount++;
            }

            jABCheckElementpropCount++;
            jABCheckElement["Workflow"] = ExpressionConverter.ConvertO(jABCheckElementWorkflow);
            if (jABCheckElementpropCount > 0)
            {
                callPayload.Body = jABCheckElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetElementPropertiesAsListResponse> JABGetElementPropertiesAsList(Expression<Func<int>> jABGetElementPropertiesAsListSearchParentElementJABHandle, Expression<Func<string>> jABGetElementPropertiesAsListWorkflow, Expression<Func<string>> jABGetElementPropertiesAsListSearchElementJABName = null, Expression<Func<string>> jABGetElementPropertiesAsListSearchElementJABDescription = null, Expression<Func<string>> jABGetElementPropertiesAsListSearchElementJABRole = null, Expression<Func<bool>> jABGetElementPropertiesAsListSearchSubTree = null, Expression<Func<int>> jABGetElementPropertiesAsListMaxRelativeDepth = null, Expression<Func<int>> jABGetElementPropertiesAsListMatchIndex = null, Expression<Func<string>> jABGetElementPropertiesAsListSearchFilter = null, Expression<Func<string>> jABGetElementPropertiesAsListSortByColumn = null, Expression<Func<bool>> jABGetElementPropertiesAsListMatchIndexAscending = null, Expression<Func<bool>> jABGetElementPropertiesAsListCaseSensitiveSearch = null, Expression<Func<bool>> jABGetElementPropertiesAsListOnlySearchVisibleElements = null, Expression<Func<bool>> jABGetElementPropertiesAsListOnlySearchShowingElements = null, Expression<Func<string>> jABGetElementPropertiesAsListElementRolesNotToTraverse = null, Expression<Func<int>> jABGetElementPropertiesAsListMaximumElementsToSearch = null, Expression<Func<int>> jABGetElementPropertiesAsListMaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABGetElementPropertiesAsListMaxStringLength = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetElementPropertiesAsList";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetElementPropertiesAsList = new JObject();
            var jABGetElementPropertiesAsListpropCount = 0;
            jABGetElementPropertiesAsListpropCount++;
            jABGetElementPropertiesAsList["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListSearchParentElementJABHandle);
            if (jABGetElementPropertiesAsListSearchElementJABName != null)
            {
                jABGetElementPropertiesAsList["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListSearchElementJABName);
                jABGetElementPropertiesAsListpropCount++;
            }

            if (jABGetElementPropertiesAsListSearchElementJABDescription != null)
            {
                jABGetElementPropertiesAsList["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListSearchElementJABDescription);
                jABGetElementPropertiesAsListpropCount++;
            }

            if (jABGetElementPropertiesAsListSearchElementJABRole != null)
            {
                jABGetElementPropertiesAsList["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListSearchElementJABRole);
                jABGetElementPropertiesAsListpropCount++;
            }

            if (jABGetElementPropertiesAsListSearchSubTree != null)
            {
                jABGetElementPropertiesAsList["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListSearchSubTree);
                jABGetElementPropertiesAsListpropCount++;
            }

            if (jABGetElementPropertiesAsListMaxRelativeDepth != null)
            {
                jABGetElementPropertiesAsList["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListMaxRelativeDepth);
                jABGetElementPropertiesAsListpropCount++;
            }

            if (jABGetElementPropertiesAsListMatchIndex != null)
            {
                jABGetElementPropertiesAsList["MatchIndex"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListMatchIndex);
                jABGetElementPropertiesAsListpropCount++;
            }

            if (jABGetElementPropertiesAsListSearchFilter != null)
            {
                jABGetElementPropertiesAsList["SearchFilter"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListSearchFilter);
                jABGetElementPropertiesAsListpropCount++;
            }

            if (jABGetElementPropertiesAsListSortByColumn != null)
            {
                jABGetElementPropertiesAsList["SortByColumn"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListSortByColumn);
                jABGetElementPropertiesAsListpropCount++;
            }

            if (jABGetElementPropertiesAsListMatchIndexAscending != null)
            {
                jABGetElementPropertiesAsList["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListMatchIndexAscending);
                jABGetElementPropertiesAsListpropCount++;
            }

            if (jABGetElementPropertiesAsListCaseSensitiveSearch != null)
            {
                jABGetElementPropertiesAsList["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListCaseSensitiveSearch);
                jABGetElementPropertiesAsListpropCount++;
            }

            if (jABGetElementPropertiesAsListOnlySearchVisibleElements != null)
            {
                jABGetElementPropertiesAsList["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListOnlySearchVisibleElements);
                jABGetElementPropertiesAsListpropCount++;
            }

            if (jABGetElementPropertiesAsListOnlySearchShowingElements != null)
            {
                jABGetElementPropertiesAsList["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListOnlySearchShowingElements);
                jABGetElementPropertiesAsListpropCount++;
            }

            if (jABGetElementPropertiesAsListElementRolesNotToTraverse != null)
            {
                jABGetElementPropertiesAsList["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListElementRolesNotToTraverse);
                jABGetElementPropertiesAsListpropCount++;
            }

            if (jABGetElementPropertiesAsListMaximumElementsToSearch != null)
            {
                jABGetElementPropertiesAsList["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListMaximumElementsToSearch);
                jABGetElementPropertiesAsListpropCount++;
            }

            if (jABGetElementPropertiesAsListMaximumChildElementsToSearchPerNode != null)
            {
                jABGetElementPropertiesAsList["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListMaximumChildElementsToSearchPerNode);
                jABGetElementPropertiesAsListpropCount++;
            }

            if (jABGetElementPropertiesAsListMaxStringLength != null)
            {
                jABGetElementPropertiesAsList["MaxStringLength"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListMaxStringLength);
                jABGetElementPropertiesAsListpropCount++;
            }

            jABGetElementPropertiesAsListpropCount++;
            jABGetElementPropertiesAsList["Workflow"] = ExpressionConverter.ConvertO(jABGetElementPropertiesAsListWorkflow);
            if (jABGetElementPropertiesAsListpropCount > 0)
            {
                callPayload.Body = jABGetElementPropertiesAsList;
            }

            return new ApiConnectionAction<JABGetElementPropertiesAsListResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalInputPasswordIntoElement(Expression<Func<int>> jABGlobalInputPasswordIntoElementSearchParentElementJABHandle, Expression<Func<string>> jABGlobalInputPasswordIntoElementPasswordToInput, Expression<Func<string>> jABGlobalInputPasswordIntoElementWorkflow, Expression<Func<string>> jABGlobalInputPasswordIntoElementSearchElementJABName = null, Expression<Func<string>> jABGlobalInputPasswordIntoElementSearchElementJABDescription = null, Expression<Func<string>> jABGlobalInputPasswordIntoElementSearchElementJABRole = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementSearchSubTree = null, Expression<Func<int>> jABGlobalInputPasswordIntoElementMaxRelativeDepth = null, Expression<Func<int>> jABGlobalInputPasswordIntoElementMatchIndex = null, Expression<Func<string>> jABGlobalInputPasswordIntoElementSearchFilter = null, Expression<Func<string>> jABGlobalInputPasswordIntoElementSortByColumn = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementMatchIndexAscending = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementCaseSensitiveSearch = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementOnlySearchVisibleElements = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementOnlySearchShowingElements = null, Expression<Func<string>> jABGlobalInputPasswordIntoElementElementRolesNotToTraverse = null, Expression<Func<int>> jABGlobalInputPasswordIntoElementMaximumElementsToSearch = null, Expression<Func<int>> jABGlobalInputPasswordIntoElementMaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementFocusElement = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementGlobalMouseClickOnElement = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementReplaceExistingValueUsingDoubleClickDelete = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementReplaceExistingValueUsingCTRLADelete = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementSendKeyEvents = null, Expression<Func<int>> jABGlobalInputPasswordIntoElementKeyIntervalInMilliseconds = null, Expression<Func<int>> jABGlobalInputPasswordIntoElementDoubleClickIntervalInMilliseconds = null, Expression<Func<bool>> jABGlobalInputPasswordIntoElementDontInterpretSymbols = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGlobalInputPasswordIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGlobalInputPasswordIntoElement = new JObject();
            var jABGlobalInputPasswordIntoElementpropCount = 0;
            jABGlobalInputPasswordIntoElementpropCount++;
            jABGlobalInputPasswordIntoElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementSearchParentElementJABHandle);
            if (jABGlobalInputPasswordIntoElementSearchElementJABName != null)
            {
                jABGlobalInputPasswordIntoElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementSearchElementJABName);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementSearchElementJABDescription != null)
            {
                jABGlobalInputPasswordIntoElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementSearchElementJABDescription);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementSearchElementJABRole != null)
            {
                jABGlobalInputPasswordIntoElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementSearchElementJABRole);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementSearchSubTree != null)
            {
                jABGlobalInputPasswordIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementSearchSubTree);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementMaxRelativeDepth != null)
            {
                jABGlobalInputPasswordIntoElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementMaxRelativeDepth);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementMatchIndex != null)
            {
                jABGlobalInputPasswordIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementMatchIndex);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementSearchFilter != null)
            {
                jABGlobalInputPasswordIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementSearchFilter);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementSortByColumn != null)
            {
                jABGlobalInputPasswordIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementSortByColumn);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementMatchIndexAscending != null)
            {
                jABGlobalInputPasswordIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementMatchIndexAscending);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementCaseSensitiveSearch != null)
            {
                jABGlobalInputPasswordIntoElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementCaseSensitiveSearch);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementOnlySearchVisibleElements != null)
            {
                jABGlobalInputPasswordIntoElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementOnlySearchVisibleElements);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementOnlySearchShowingElements != null)
            {
                jABGlobalInputPasswordIntoElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementOnlySearchShowingElements);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementElementRolesNotToTraverse != null)
            {
                jABGlobalInputPasswordIntoElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementElementRolesNotToTraverse);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementMaximumElementsToSearch != null)
            {
                jABGlobalInputPasswordIntoElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementMaximumElementsToSearch);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementMaximumChildElementsToSearchPerNode != null)
            {
                jABGlobalInputPasswordIntoElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementMaximumChildElementsToSearchPerNode);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementFocusElement != null)
            {
                jABGlobalInputPasswordIntoElement["FocusElement"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementFocusElement);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementGlobalMouseClickOnElement != null)
            {
                jABGlobalInputPasswordIntoElement["GlobalMouseClickOnElement"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementGlobalMouseClickOnElement);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementReplaceExistingValueUsingDoubleClickDelete != null)
            {
                jABGlobalInputPasswordIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementReplaceExistingValueUsingDoubleClickDelete);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementReplaceExistingValueUsingCTRLADelete != null)
            {
                jABGlobalInputPasswordIntoElement["ReplaceExistingValueUsingCTRLADelete"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementReplaceExistingValueUsingCTRLADelete);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            jABGlobalInputPasswordIntoElementpropCount++;
            jABGlobalInputPasswordIntoElement["PasswordToInput"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementPasswordToInput);
            if (jABGlobalInputPasswordIntoElementSendKeyEvents != null)
            {
                jABGlobalInputPasswordIntoElement["SendKeyEvents"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementSendKeyEvents);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementKeyIntervalInMilliseconds != null)
            {
                jABGlobalInputPasswordIntoElement["KeyIntervalInMilliseconds"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementKeyIntervalInMilliseconds);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementDoubleClickIntervalInMilliseconds != null)
            {
                jABGlobalInputPasswordIntoElement["DoubleClickIntervalInMilliseconds"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementDoubleClickIntervalInMilliseconds);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            if (jABGlobalInputPasswordIntoElementDontInterpretSymbols != null)
            {
                jABGlobalInputPasswordIntoElement["DontInterpretSymbols"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementDontInterpretSymbols);
                jABGlobalInputPasswordIntoElementpropCount++;
            }

            jABGlobalInputPasswordIntoElementpropCount++;
            jABGlobalInputPasswordIntoElement["Workflow"] = ExpressionConverter.ConvertO(jABGlobalInputPasswordIntoElementWorkflow);
            if (jABGlobalInputPasswordIntoElementpropCount > 0)
            {
                callPayload.Body = jABGlobalInputPasswordIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalInputTextIntoElement(Expression<Func<int>> jABGlobalInputTextIntoElementSearchParentElementJABHandle, Expression<Func<string>> jABGlobalInputTextIntoElementWorkflow, Expression<Func<string>> jABGlobalInputTextIntoElementSearchElementJABName = null, Expression<Func<string>> jABGlobalInputTextIntoElementSearchElementJABDescription = null, Expression<Func<string>> jABGlobalInputTextIntoElementSearchElementJABRole = null, Expression<Func<bool>> jABGlobalInputTextIntoElementSearchSubTree = null, Expression<Func<int>> jABGlobalInputTextIntoElementMaxRelativeDepth = null, Expression<Func<int>> jABGlobalInputTextIntoElementMatchIndex = null, Expression<Func<string>> jABGlobalInputTextIntoElementSearchFilter = null, Expression<Func<string>> jABGlobalInputTextIntoElementSortByColumn = null, Expression<Func<bool>> jABGlobalInputTextIntoElementMatchIndexAscending = null, Expression<Func<bool>> jABGlobalInputTextIntoElementCaseSensitiveSearch = null, Expression<Func<bool>> jABGlobalInputTextIntoElementOnlySearchVisibleElements = null, Expression<Func<bool>> jABGlobalInputTextIntoElementOnlySearchShowingElements = null, Expression<Func<string>> jABGlobalInputTextIntoElementElementRolesNotToTraverse = null, Expression<Func<int>> jABGlobalInputTextIntoElementMaximumElementsToSearch = null, Expression<Func<int>> jABGlobalInputTextIntoElementMaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGlobalInputTextIntoElementFocusElement = null, Expression<Func<bool>> jABGlobalInputTextIntoElementGlobalMouseClickOnElement = null, Expression<Func<bool>> jABGlobalInputTextIntoElementReplaceExistingValueUsingDoubleClickDelete = null, Expression<Func<bool>> jABGlobalInputTextIntoElementReplaceExistingValueUsingCTRLADelete = null, Expression<Func<string>> jABGlobalInputTextIntoElementTextToInput = null, Expression<Func<bool>> jABGlobalInputTextIntoElementSendKeyEvents = null, Expression<Func<int>> jABGlobalInputTextIntoElementKeyIntervalInMilliseconds = null, Expression<Func<int>> jABGlobalInputTextIntoElementDoubleClickIntervalInMilliseconds = null, Expression<Func<bool>> jABGlobalInputTextIntoElementDontInterpretSymbols = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGlobalInputTextIntoElement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGlobalInputTextIntoElement = new JObject();
            var jABGlobalInputTextIntoElementpropCount = 0;
            jABGlobalInputTextIntoElementpropCount++;
            jABGlobalInputTextIntoElement["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementSearchParentElementJABHandle);
            if (jABGlobalInputTextIntoElementSearchElementJABName != null)
            {
                jABGlobalInputTextIntoElement["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementSearchElementJABName);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementSearchElementJABDescription != null)
            {
                jABGlobalInputTextIntoElement["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementSearchElementJABDescription);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementSearchElementJABRole != null)
            {
                jABGlobalInputTextIntoElement["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementSearchElementJABRole);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementSearchSubTree != null)
            {
                jABGlobalInputTextIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementSearchSubTree);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementMaxRelativeDepth != null)
            {
                jABGlobalInputTextIntoElement["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementMaxRelativeDepth);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementMatchIndex != null)
            {
                jABGlobalInputTextIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementMatchIndex);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementSearchFilter != null)
            {
                jABGlobalInputTextIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementSearchFilter);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementSortByColumn != null)
            {
                jABGlobalInputTextIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementSortByColumn);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementMatchIndexAscending != null)
            {
                jABGlobalInputTextIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementMatchIndexAscending);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementCaseSensitiveSearch != null)
            {
                jABGlobalInputTextIntoElement["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementCaseSensitiveSearch);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementOnlySearchVisibleElements != null)
            {
                jABGlobalInputTextIntoElement["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementOnlySearchVisibleElements);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementOnlySearchShowingElements != null)
            {
                jABGlobalInputTextIntoElement["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementOnlySearchShowingElements);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementElementRolesNotToTraverse != null)
            {
                jABGlobalInputTextIntoElement["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementElementRolesNotToTraverse);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementMaximumElementsToSearch != null)
            {
                jABGlobalInputTextIntoElement["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementMaximumElementsToSearch);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementMaximumChildElementsToSearchPerNode != null)
            {
                jABGlobalInputTextIntoElement["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementMaximumChildElementsToSearchPerNode);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementFocusElement != null)
            {
                jABGlobalInputTextIntoElement["FocusElement"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementFocusElement);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementGlobalMouseClickOnElement != null)
            {
                jABGlobalInputTextIntoElement["GlobalMouseClickOnElement"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementGlobalMouseClickOnElement);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementReplaceExistingValueUsingDoubleClickDelete != null)
            {
                jABGlobalInputTextIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementReplaceExistingValueUsingDoubleClickDelete);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementReplaceExistingValueUsingCTRLADelete != null)
            {
                jABGlobalInputTextIntoElement["ReplaceExistingValueUsingCTRLADelete"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementReplaceExistingValueUsingCTRLADelete);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementTextToInput != null)
            {
                jABGlobalInputTextIntoElement["TextToInput"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementTextToInput);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementSendKeyEvents != null)
            {
                jABGlobalInputTextIntoElement["SendKeyEvents"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementSendKeyEvents);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementKeyIntervalInMilliseconds != null)
            {
                jABGlobalInputTextIntoElement["KeyIntervalInMilliseconds"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementKeyIntervalInMilliseconds);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementDoubleClickIntervalInMilliseconds != null)
            {
                jABGlobalInputTextIntoElement["DoubleClickIntervalInMilliseconds"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementDoubleClickIntervalInMilliseconds);
                jABGlobalInputTextIntoElementpropCount++;
            }

            if (jABGlobalInputTextIntoElementDontInterpretSymbols != null)
            {
                jABGlobalInputTextIntoElement["DontInterpretSymbols"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementDontInterpretSymbols);
                jABGlobalInputTextIntoElementpropCount++;
            }

            jABGlobalInputTextIntoElementpropCount++;
            jABGlobalInputTextIntoElement["Workflow"] = ExpressionConverter.ConvertO(jABGlobalInputTextIntoElementWorkflow);
            if (jABGlobalInputTextIntoElementpropCount > 0)
            {
                callPayload.Body = jABGlobalInputTextIntoElement;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetSelectionElementItemsResponse> JABGetSelectionElementItems(Expression<Func<int>> jABGetSelectionElementItemsSearchParentElementJABHandle, Expression<Func<string>> jABGetSelectionElementItemsWorkflow, Expression<Func<string>> jABGetSelectionElementItemsSearchElementJABName = null, Expression<Func<string>> jABGetSelectionElementItemsSearchElementJABDescription = null, Expression<Func<string>> jABGetSelectionElementItemsSearchElementJABRole = null, Expression<Func<bool>> jABGetSelectionElementItemsSearchSubTree = null, Expression<Func<int>> jABGetSelectionElementItemsMaxRelativeDepth = null, Expression<Func<int>> jABGetSelectionElementItemsMatchIndex = null, Expression<Func<string>> jABGetSelectionElementItemsSearchFilter = null, Expression<Func<string>> jABGetSelectionElementItemsSortByColumn = null, Expression<Func<bool>> jABGetSelectionElementItemsMatchIndexAscending = null, Expression<Func<bool>> jABGetSelectionElementItemsCaseSensitiveSearch = null, Expression<Func<bool>> jABGetSelectionElementItemsOnlySearchVisibleElements = null, Expression<Func<bool>> jABGetSelectionElementItemsOnlySearchShowingElements = null, Expression<Func<string>> jABGetSelectionElementItemsElementRolesNotToTraverse = null, Expression<Func<int>> jABGetSelectionElementItemsMaximumElementsToSearch = null, Expression<Func<int>> jABGetSelectionElementItemsMaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGetSelectionElementItemsGetListOfOptionsBySelecting = null, Expression<Func<bool>> jABGetSelectionElementItemsGetListOfOptionsByReadingLabels = null, Expression<Func<bool>> jABGetSelectionElementItemsExpandFirst = null, Expression<Func<bool>> jABGetSelectionElementItemsCollapseAfter = null, Expression<Func<double>> jABGetSelectionElementItemsSecondsBetweenExpandCollapse = null, Expression<Func<int>> jABGetSelectionElementItemsMaxListItemsToReturn = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetSelectionElementItems";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetSelectionElementItems = new JObject();
            var jABGetSelectionElementItemspropCount = 0;
            jABGetSelectionElementItemspropCount++;
            jABGetSelectionElementItems["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsSearchParentElementJABHandle);
            if (jABGetSelectionElementItemsSearchElementJABName != null)
            {
                jABGetSelectionElementItems["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsSearchElementJABName);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemsSearchElementJABDescription != null)
            {
                jABGetSelectionElementItems["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsSearchElementJABDescription);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemsSearchElementJABRole != null)
            {
                jABGetSelectionElementItems["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsSearchElementJABRole);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemsSearchSubTree != null)
            {
                jABGetSelectionElementItems["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsSearchSubTree);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemsMaxRelativeDepth != null)
            {
                jABGetSelectionElementItems["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsMaxRelativeDepth);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemsMatchIndex != null)
            {
                jABGetSelectionElementItems["MatchIndex"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsMatchIndex);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemsSearchFilter != null)
            {
                jABGetSelectionElementItems["SearchFilter"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsSearchFilter);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemsSortByColumn != null)
            {
                jABGetSelectionElementItems["SortByColumn"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsSortByColumn);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemsMatchIndexAscending != null)
            {
                jABGetSelectionElementItems["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsMatchIndexAscending);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemsCaseSensitiveSearch != null)
            {
                jABGetSelectionElementItems["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsCaseSensitiveSearch);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemsOnlySearchVisibleElements != null)
            {
                jABGetSelectionElementItems["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsOnlySearchVisibleElements);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemsOnlySearchShowingElements != null)
            {
                jABGetSelectionElementItems["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsOnlySearchShowingElements);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemsElementRolesNotToTraverse != null)
            {
                jABGetSelectionElementItems["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsElementRolesNotToTraverse);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemsMaximumElementsToSearch != null)
            {
                jABGetSelectionElementItems["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsMaximumElementsToSearch);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemsMaximumChildElementsToSearchPerNode != null)
            {
                jABGetSelectionElementItems["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsMaximumChildElementsToSearchPerNode);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemsGetListOfOptionsBySelecting != null)
            {
                jABGetSelectionElementItems["GetListOfOptionsBySelecting"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsGetListOfOptionsBySelecting);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemsGetListOfOptionsByReadingLabels != null)
            {
                jABGetSelectionElementItems["GetListOfOptionsByReadingLabels"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsGetListOfOptionsByReadingLabels);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemsExpandFirst != null)
            {
                jABGetSelectionElementItems["ExpandFirst"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsExpandFirst);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemsCollapseAfter != null)
            {
                jABGetSelectionElementItems["CollapseAfter"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsCollapseAfter);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemsSecondsBetweenExpandCollapse != null)
            {
                jABGetSelectionElementItems["SecondsBetweenExpandCollapse"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsSecondsBetweenExpandCollapse);
                jABGetSelectionElementItemspropCount++;
            }

            if (jABGetSelectionElementItemsMaxListItemsToReturn != null)
            {
                jABGetSelectionElementItems["MaxListItemsToReturn"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsMaxListItemsToReturn);
                jABGetSelectionElementItemspropCount++;
            }

            jABGetSelectionElementItemspropCount++;
            jABGetSelectionElementItems["Workflow"] = ExpressionConverter.ConvertO(jABGetSelectionElementItemsWorkflow);
            if (jABGetSelectionElementItemspropCount > 0)
            {
                callPayload.Body = jABGetSelectionElementItems;
            }

            return new ApiConnectionAction<JABGetSelectionElementItemsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABSetSelectionByIndex(Expression<Func<int>> jABSetSelectionByIndexSearchParentElementJABHandle, Expression<Func<int>> jABSetSelectionByIndexItemIndex, Expression<Func<string>> jABSetSelectionByIndexWorkflow, Expression<Func<string>> jABSetSelectionByIndexSearchElementJABName = null, Expression<Func<string>> jABSetSelectionByIndexSearchElementJABDescription = null, Expression<Func<string>> jABSetSelectionByIndexSearchElementJABRole = null, Expression<Func<bool>> jABSetSelectionByIndexSearchSubTree = null, Expression<Func<int>> jABSetSelectionByIndexMaxRelativeDepth = null, Expression<Func<int>> jABSetSelectionByIndexMatchIndex = null, Expression<Func<string>> jABSetSelectionByIndexSearchFilter = null, Expression<Func<string>> jABSetSelectionByIndexSortByColumn = null, Expression<Func<bool>> jABSetSelectionByIndexMatchIndexAscending = null, Expression<Func<bool>> jABSetSelectionByIndexCaseSensitiveSearch = null, Expression<Func<bool>> jABSetSelectionByIndexOnlySearchVisibleElements = null, Expression<Func<bool>> jABSetSelectionByIndexOnlySearchShowingElements = null, Expression<Func<string>> jABSetSelectionByIndexElementRolesNotToTraverse = null, Expression<Func<int>> jABSetSelectionByIndexMaximumElementsToSearch = null, Expression<Func<int>> jABSetSelectionByIndexMaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABSetSelectionByIndexSelectItem = null, Expression<Func<bool>> jABSetSelectionByIndexClearSelectionFirst = null, Expression<Func<bool>> jABSetSelectionByIndexRecoverOnFailure = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABSetSelectionByIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABSetSelectionByIndex = new JObject();
            var jABSetSelectionByIndexpropCount = 0;
            jABSetSelectionByIndexpropCount++;
            jABSetSelectionByIndex["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexSearchParentElementJABHandle);
            if (jABSetSelectionByIndexSearchElementJABName != null)
            {
                jABSetSelectionByIndex["SearchElementJABName"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexSearchElementJABName);
                jABSetSelectionByIndexpropCount++;
            }

            if (jABSetSelectionByIndexSearchElementJABDescription != null)
            {
                jABSetSelectionByIndex["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexSearchElementJABDescription);
                jABSetSelectionByIndexpropCount++;
            }

            if (jABSetSelectionByIndexSearchElementJABRole != null)
            {
                jABSetSelectionByIndex["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexSearchElementJABRole);
                jABSetSelectionByIndexpropCount++;
            }

            if (jABSetSelectionByIndexSearchSubTree != null)
            {
                jABSetSelectionByIndex["SearchSubTree"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexSearchSubTree);
                jABSetSelectionByIndexpropCount++;
            }

            if (jABSetSelectionByIndexMaxRelativeDepth != null)
            {
                jABSetSelectionByIndex["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexMaxRelativeDepth);
                jABSetSelectionByIndexpropCount++;
            }

            if (jABSetSelectionByIndexMatchIndex != null)
            {
                jABSetSelectionByIndex["MatchIndex"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexMatchIndex);
                jABSetSelectionByIndexpropCount++;
            }

            if (jABSetSelectionByIndexSearchFilter != null)
            {
                jABSetSelectionByIndex["SearchFilter"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexSearchFilter);
                jABSetSelectionByIndexpropCount++;
            }

            if (jABSetSelectionByIndexSortByColumn != null)
            {
                jABSetSelectionByIndex["SortByColumn"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexSortByColumn);
                jABSetSelectionByIndexpropCount++;
            }

            if (jABSetSelectionByIndexMatchIndexAscending != null)
            {
                jABSetSelectionByIndex["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexMatchIndexAscending);
                jABSetSelectionByIndexpropCount++;
            }

            if (jABSetSelectionByIndexCaseSensitiveSearch != null)
            {
                jABSetSelectionByIndex["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexCaseSensitiveSearch);
                jABSetSelectionByIndexpropCount++;
            }

            if (jABSetSelectionByIndexOnlySearchVisibleElements != null)
            {
                jABSetSelectionByIndex["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexOnlySearchVisibleElements);
                jABSetSelectionByIndexpropCount++;
            }

            if (jABSetSelectionByIndexOnlySearchShowingElements != null)
            {
                jABSetSelectionByIndex["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexOnlySearchShowingElements);
                jABSetSelectionByIndexpropCount++;
            }

            if (jABSetSelectionByIndexElementRolesNotToTraverse != null)
            {
                jABSetSelectionByIndex["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexElementRolesNotToTraverse);
                jABSetSelectionByIndexpropCount++;
            }

            if (jABSetSelectionByIndexMaximumElementsToSearch != null)
            {
                jABSetSelectionByIndex["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexMaximumElementsToSearch);
                jABSetSelectionByIndexpropCount++;
            }

            if (jABSetSelectionByIndexMaximumChildElementsToSearchPerNode != null)
            {
                jABSetSelectionByIndex["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexMaximumChildElementsToSearchPerNode);
                jABSetSelectionByIndexpropCount++;
            }

            jABSetSelectionByIndexpropCount++;
            jABSetSelectionByIndex["ItemIndex"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexItemIndex);
            if (jABSetSelectionByIndexSelectItem != null)
            {
                jABSetSelectionByIndex["SelectItem"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexSelectItem);
                jABSetSelectionByIndexpropCount++;
            }

            if (jABSetSelectionByIndexClearSelectionFirst != null)
            {
                jABSetSelectionByIndex["ClearSelectionFirst"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexClearSelectionFirst);
                jABSetSelectionByIndexpropCount++;
            }

            if (jABSetSelectionByIndexRecoverOnFailure != null)
            {
                jABSetSelectionByIndex["RecoverOnFailure"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexRecoverOnFailure);
                jABSetSelectionByIndexpropCount++;
            }

            jABSetSelectionByIndexpropCount++;
            jABSetSelectionByIndex["Workflow"] = ExpressionConverter.ConvertO(jABSetSelectionByIndexWorkflow);
            if (jABSetSelectionByIndexpropCount > 0)
            {
                callPayload.Body = jABSetSelectionByIndex;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABSetSelectionByName(Expression<Func<int>> jABSetSelectionByNameSearchParentElementJABHandle, Expression<Func<string>> jABSetSelectionByNameItemName, Expression<Func<string>> jABSetSelectionByNameWorkflow, Expression<Func<string>> jABSetSelectionByNameSearchElementJABName = null, Expression<Func<string>> jABSetSelectionByNameSearchElementJABDescription = null, Expression<Func<string>> jABSetSelectionByNameSearchElementJABRole = null, Expression<Func<bool>> jABSetSelectionByNameSearchSubTree = null, Expression<Func<int>> jABSetSelectionByNameMaxRelativeDepth = null, Expression<Func<int>> jABSetSelectionByNameMatchIndex = null, Expression<Func<string>> jABSetSelectionByNameSearchFilter = null, Expression<Func<string>> jABSetSelectionByNameSortByColumn = null, Expression<Func<bool>> jABSetSelectionByNameMatchIndexAscending = null, Expression<Func<bool>> jABSetSelectionByNameCaseSensitiveSearch = null, Expression<Func<bool>> jABSetSelectionByNameOnlySearchVisibleElements = null, Expression<Func<bool>> jABSetSelectionByNameOnlySearchShowingElements = null, Expression<Func<string>> jABSetSelectionByNameElementRolesNotToTraverse = null, Expression<Func<int>> jABSetSelectionByNameMaximumElementsToSearch = null, Expression<Func<int>> jABSetSelectionByNameMaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABSetSelectionByNameSelectItem = null, Expression<Func<bool>> jABSetSelectionByNameItemNameCaseSensitive = null, Expression<Func<bool>> jABSetSelectionByNameClearSelectionFirst = null, Expression<Func<bool>> jABSetSelectionByNameGetListOfOptionsBySelecting = null, Expression<Func<bool>> jABSetSelectionByNameGetListOfOptionsByReadingLabels = null, Expression<Func<bool>> jABSetSelectionByNameExpandFirst = null, Expression<Func<bool>> jABSetSelectionByNameCollapseAfter = null, Expression<Func<double>> jABSetSelectionByNameSecondsBetweenExpandCollapse = null, Expression<Func<bool>> jABSetSelectionByNameForceEvenIfInCorrectState = null, Expression<Func<bool>> jABSetSelectionByNameRecoverOnFailure = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABSetSelectionByName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABSetSelectionByName = new JObject();
            var jABSetSelectionByNamepropCount = 0;
            jABSetSelectionByNamepropCount++;
            jABSetSelectionByName["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABSetSelectionByNameSearchParentElementJABHandle);
            if (jABSetSelectionByNameSearchElementJABName != null)
            {
                jABSetSelectionByName["SearchElementJABName"] = ExpressionConverter.ConvertO(jABSetSelectionByNameSearchElementJABName);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameSearchElementJABDescription != null)
            {
                jABSetSelectionByName["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABSetSelectionByNameSearchElementJABDescription);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameSearchElementJABRole != null)
            {
                jABSetSelectionByName["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABSetSelectionByNameSearchElementJABRole);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameSearchSubTree != null)
            {
                jABSetSelectionByName["SearchSubTree"] = ExpressionConverter.ConvertO(jABSetSelectionByNameSearchSubTree);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameMaxRelativeDepth != null)
            {
                jABSetSelectionByName["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABSetSelectionByNameMaxRelativeDepth);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameMatchIndex != null)
            {
                jABSetSelectionByName["MatchIndex"] = ExpressionConverter.ConvertO(jABSetSelectionByNameMatchIndex);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameSearchFilter != null)
            {
                jABSetSelectionByName["SearchFilter"] = ExpressionConverter.ConvertO(jABSetSelectionByNameSearchFilter);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameSortByColumn != null)
            {
                jABSetSelectionByName["SortByColumn"] = ExpressionConverter.ConvertO(jABSetSelectionByNameSortByColumn);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameMatchIndexAscending != null)
            {
                jABSetSelectionByName["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABSetSelectionByNameMatchIndexAscending);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameCaseSensitiveSearch != null)
            {
                jABSetSelectionByName["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABSetSelectionByNameCaseSensitiveSearch);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameOnlySearchVisibleElements != null)
            {
                jABSetSelectionByName["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABSetSelectionByNameOnlySearchVisibleElements);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameOnlySearchShowingElements != null)
            {
                jABSetSelectionByName["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABSetSelectionByNameOnlySearchShowingElements);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameElementRolesNotToTraverse != null)
            {
                jABSetSelectionByName["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABSetSelectionByNameElementRolesNotToTraverse);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameMaximumElementsToSearch != null)
            {
                jABSetSelectionByName["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABSetSelectionByNameMaximumElementsToSearch);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameMaximumChildElementsToSearchPerNode != null)
            {
                jABSetSelectionByName["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABSetSelectionByNameMaximumChildElementsToSearchPerNode);
                jABSetSelectionByNamepropCount++;
            }

            jABSetSelectionByNamepropCount++;
            jABSetSelectionByName["ItemName"] = ExpressionConverter.ConvertO(jABSetSelectionByNameItemName);
            if (jABSetSelectionByNameSelectItem != null)
            {
                jABSetSelectionByName["SelectItem"] = ExpressionConverter.ConvertO(jABSetSelectionByNameSelectItem);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameItemNameCaseSensitive != null)
            {
                jABSetSelectionByName["ItemNameCaseSensitive"] = ExpressionConverter.ConvertO(jABSetSelectionByNameItemNameCaseSensitive);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameClearSelectionFirst != null)
            {
                jABSetSelectionByName["ClearSelectionFirst"] = ExpressionConverter.ConvertO(jABSetSelectionByNameClearSelectionFirst);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameGetListOfOptionsBySelecting != null)
            {
                jABSetSelectionByName["GetListOfOptionsBySelecting"] = ExpressionConverter.ConvertO(jABSetSelectionByNameGetListOfOptionsBySelecting);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameGetListOfOptionsByReadingLabels != null)
            {
                jABSetSelectionByName["GetListOfOptionsByReadingLabels"] = ExpressionConverter.ConvertO(jABSetSelectionByNameGetListOfOptionsByReadingLabels);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameExpandFirst != null)
            {
                jABSetSelectionByName["ExpandFirst"] = ExpressionConverter.ConvertO(jABSetSelectionByNameExpandFirst);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameCollapseAfter != null)
            {
                jABSetSelectionByName["CollapseAfter"] = ExpressionConverter.ConvertO(jABSetSelectionByNameCollapseAfter);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameSecondsBetweenExpandCollapse != null)
            {
                jABSetSelectionByName["SecondsBetweenExpandCollapse"] = ExpressionConverter.ConvertO(jABSetSelectionByNameSecondsBetweenExpandCollapse);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameForceEvenIfInCorrectState != null)
            {
                jABSetSelectionByName["ForceEvenIfInCorrectState"] = ExpressionConverter.ConvertO(jABSetSelectionByNameForceEvenIfInCorrectState);
                jABSetSelectionByNamepropCount++;
            }

            if (jABSetSelectionByNameRecoverOnFailure != null)
            {
                jABSetSelectionByName["RecoverOnFailure"] = ExpressionConverter.ConvertO(jABSetSelectionByNameRecoverOnFailure);
                jABSetSelectionByNamepropCount++;
            }

            jABSetSelectionByNamepropCount++;
            jABSetSelectionByName["Workflow"] = ExpressionConverter.ConvertO(jABSetSelectionByNameWorkflow);
            if (jABSetSelectionByNamepropCount > 0)
            {
                callPayload.Body = jABSetSelectionByName;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABExpandSelection(Expression<Func<int>> jABExpandSelectionSearchParentElementJABHandle, Expression<Func<string>> jABExpandSelectionWorkflow, Expression<Func<string>> jABExpandSelectionSearchElementJABName = null, Expression<Func<string>> jABExpandSelectionSearchElementJABDescription = null, Expression<Func<string>> jABExpandSelectionSearchElementJABRole = null, Expression<Func<bool>> jABExpandSelectionSearchSubTree = null, Expression<Func<int>> jABExpandSelectionMaxRelativeDepth = null, Expression<Func<int>> jABExpandSelectionMatchIndex = null, Expression<Func<string>> jABExpandSelectionSearchFilter = null, Expression<Func<string>> jABExpandSelectionSortByColumn = null, Expression<Func<bool>> jABExpandSelectionMatchIndexAscending = null, Expression<Func<bool>> jABExpandSelectionCaseSensitiveSearch = null, Expression<Func<bool>> jABExpandSelectionOnlySearchVisibleElements = null, Expression<Func<bool>> jABExpandSelectionOnlySearchShowingElements = null, Expression<Func<string>> jABExpandSelectionElementRolesNotToTraverse = null, Expression<Func<int>> jABExpandSelectionMaximumElementsToSearch = null, Expression<Func<int>> jABExpandSelectionMaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABExpandSelectionExpand = null, Expression<Func<bool>> jABExpandSelectionVerifyElementState = null, Expression<Func<double>> jABExpandSelectionSecondsToWaitForStateChange = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABExpandSelection";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABExpandSelection = new JObject();
            var jABExpandSelectionpropCount = 0;
            jABExpandSelectionpropCount++;
            jABExpandSelection["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABExpandSelectionSearchParentElementJABHandle);
            if (jABExpandSelectionSearchElementJABName != null)
            {
                jABExpandSelection["SearchElementJABName"] = ExpressionConverter.ConvertO(jABExpandSelectionSearchElementJABName);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionSearchElementJABDescription != null)
            {
                jABExpandSelection["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABExpandSelectionSearchElementJABDescription);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionSearchElementJABRole != null)
            {
                jABExpandSelection["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABExpandSelectionSearchElementJABRole);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionSearchSubTree != null)
            {
                jABExpandSelection["SearchSubTree"] = ExpressionConverter.ConvertO(jABExpandSelectionSearchSubTree);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionMaxRelativeDepth != null)
            {
                jABExpandSelection["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABExpandSelectionMaxRelativeDepth);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionMatchIndex != null)
            {
                jABExpandSelection["MatchIndex"] = ExpressionConverter.ConvertO(jABExpandSelectionMatchIndex);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionSearchFilter != null)
            {
                jABExpandSelection["SearchFilter"] = ExpressionConverter.ConvertO(jABExpandSelectionSearchFilter);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionSortByColumn != null)
            {
                jABExpandSelection["SortByColumn"] = ExpressionConverter.ConvertO(jABExpandSelectionSortByColumn);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionMatchIndexAscending != null)
            {
                jABExpandSelection["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABExpandSelectionMatchIndexAscending);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionCaseSensitiveSearch != null)
            {
                jABExpandSelection["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABExpandSelectionCaseSensitiveSearch);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionOnlySearchVisibleElements != null)
            {
                jABExpandSelection["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABExpandSelectionOnlySearchVisibleElements);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionOnlySearchShowingElements != null)
            {
                jABExpandSelection["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABExpandSelectionOnlySearchShowingElements);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionElementRolesNotToTraverse != null)
            {
                jABExpandSelection["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABExpandSelectionElementRolesNotToTraverse);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionMaximumElementsToSearch != null)
            {
                jABExpandSelection["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABExpandSelectionMaximumElementsToSearch);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionMaximumChildElementsToSearchPerNode != null)
            {
                jABExpandSelection["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABExpandSelectionMaximumChildElementsToSearchPerNode);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionExpand != null)
            {
                jABExpandSelection["Expand"] = ExpressionConverter.ConvertO(jABExpandSelectionExpand);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionVerifyElementState != null)
            {
                jABExpandSelection["VerifyElementState"] = ExpressionConverter.ConvertO(jABExpandSelectionVerifyElementState);
                jABExpandSelectionpropCount++;
            }

            if (jABExpandSelectionSecondsToWaitForStateChange != null)
            {
                jABExpandSelection["SecondsToWaitForStateChange"] = ExpressionConverter.ConvertO(jABExpandSelectionSecondsToWaitForStateChange);
                jABExpandSelectionpropCount++;
            }

            jABExpandSelectionpropCount++;
            jABExpandSelection["Workflow"] = ExpressionConverter.ConvertO(jABExpandSelectionWorkflow);
            if (jABExpandSelectionpropCount > 0)
            {
                callPayload.Body = jABExpandSelection;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetSelectionStateByIndexResponse> JABGetSelectionStateByIndex(Expression<Func<int>> jABGetSelectionStateByIndexSearchParentElementJABHandle, Expression<Func<int>> jABGetSelectionStateByIndexItemIndex, Expression<Func<string>> jABGetSelectionStateByIndexWorkflow, Expression<Func<string>> jABGetSelectionStateByIndexSearchElementJABName = null, Expression<Func<string>> jABGetSelectionStateByIndexSearchElementJABDescription = null, Expression<Func<string>> jABGetSelectionStateByIndexSearchElementJABRole = null, Expression<Func<bool>> jABGetSelectionStateByIndexSearchSubTree = null, Expression<Func<int>> jABGetSelectionStateByIndexMaxRelativeDepth = null, Expression<Func<int>> jABGetSelectionStateByIndexMatchIndex = null, Expression<Func<string>> jABGetSelectionStateByIndexSearchFilter = null, Expression<Func<string>> jABGetSelectionStateByIndexSortByColumn = null, Expression<Func<bool>> jABGetSelectionStateByIndexMatchIndexAscending = null, Expression<Func<bool>> jABGetSelectionStateByIndexCaseSensitiveSearch = null, Expression<Func<bool>> jABGetSelectionStateByIndexOnlySearchVisibleElements = null, Expression<Func<bool>> jABGetSelectionStateByIndexOnlySearchShowingElements = null, Expression<Func<string>> jABGetSelectionStateByIndexElementRolesNotToTraverse = null, Expression<Func<int>> jABGetSelectionStateByIndexMaximumElementsToSearch = null, Expression<Func<int>> jABGetSelectionStateByIndexMaximumChildElementsToSearchPerNode = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetSelectionStateByIndex";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetSelectionStateByIndex = new JObject();
            var jABGetSelectionStateByIndexpropCount = 0;
            jABGetSelectionStateByIndexpropCount++;
            jABGetSelectionStateByIndex["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexSearchParentElementJABHandle);
            if (jABGetSelectionStateByIndexSearchElementJABName != null)
            {
                jABGetSelectionStateByIndex["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexSearchElementJABName);
                jABGetSelectionStateByIndexpropCount++;
            }

            if (jABGetSelectionStateByIndexSearchElementJABDescription != null)
            {
                jABGetSelectionStateByIndex["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexSearchElementJABDescription);
                jABGetSelectionStateByIndexpropCount++;
            }

            if (jABGetSelectionStateByIndexSearchElementJABRole != null)
            {
                jABGetSelectionStateByIndex["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexSearchElementJABRole);
                jABGetSelectionStateByIndexpropCount++;
            }

            if (jABGetSelectionStateByIndexSearchSubTree != null)
            {
                jABGetSelectionStateByIndex["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexSearchSubTree);
                jABGetSelectionStateByIndexpropCount++;
            }

            if (jABGetSelectionStateByIndexMaxRelativeDepth != null)
            {
                jABGetSelectionStateByIndex["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexMaxRelativeDepth);
                jABGetSelectionStateByIndexpropCount++;
            }

            if (jABGetSelectionStateByIndexMatchIndex != null)
            {
                jABGetSelectionStateByIndex["MatchIndex"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexMatchIndex);
                jABGetSelectionStateByIndexpropCount++;
            }

            if (jABGetSelectionStateByIndexSearchFilter != null)
            {
                jABGetSelectionStateByIndex["SearchFilter"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexSearchFilter);
                jABGetSelectionStateByIndexpropCount++;
            }

            if (jABGetSelectionStateByIndexSortByColumn != null)
            {
                jABGetSelectionStateByIndex["SortByColumn"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexSortByColumn);
                jABGetSelectionStateByIndexpropCount++;
            }

            if (jABGetSelectionStateByIndexMatchIndexAscending != null)
            {
                jABGetSelectionStateByIndex["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexMatchIndexAscending);
                jABGetSelectionStateByIndexpropCount++;
            }

            if (jABGetSelectionStateByIndexCaseSensitiveSearch != null)
            {
                jABGetSelectionStateByIndex["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexCaseSensitiveSearch);
                jABGetSelectionStateByIndexpropCount++;
            }

            if (jABGetSelectionStateByIndexOnlySearchVisibleElements != null)
            {
                jABGetSelectionStateByIndex["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexOnlySearchVisibleElements);
                jABGetSelectionStateByIndexpropCount++;
            }

            if (jABGetSelectionStateByIndexOnlySearchShowingElements != null)
            {
                jABGetSelectionStateByIndex["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexOnlySearchShowingElements);
                jABGetSelectionStateByIndexpropCount++;
            }

            if (jABGetSelectionStateByIndexElementRolesNotToTraverse != null)
            {
                jABGetSelectionStateByIndex["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexElementRolesNotToTraverse);
                jABGetSelectionStateByIndexpropCount++;
            }

            if (jABGetSelectionStateByIndexMaximumElementsToSearch != null)
            {
                jABGetSelectionStateByIndex["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexMaximumElementsToSearch);
                jABGetSelectionStateByIndexpropCount++;
            }

            if (jABGetSelectionStateByIndexMaximumChildElementsToSearchPerNode != null)
            {
                jABGetSelectionStateByIndex["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexMaximumChildElementsToSearchPerNode);
                jABGetSelectionStateByIndexpropCount++;
            }

            jABGetSelectionStateByIndexpropCount++;
            jABGetSelectionStateByIndex["ItemIndex"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexItemIndex);
            jABGetSelectionStateByIndexpropCount++;
            jABGetSelectionStateByIndex["Workflow"] = ExpressionConverter.ConvertO(jABGetSelectionStateByIndexWorkflow);
            if (jABGetSelectionStateByIndexpropCount > 0)
            {
                callPayload.Body = jABGetSelectionStateByIndex;
            }

            return new ApiConnectionAction<JABGetSelectionStateByIndexResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetSelectionStateByNameResponse> JABGetSelectionStateByName(Expression<Func<int>> jABGetSelectionStateByNameSearchParentElementJABHandle, Expression<Func<string>> jABGetSelectionStateByNameItemName, Expression<Func<string>> jABGetSelectionStateByNameWorkflow, Expression<Func<string>> jABGetSelectionStateByNameSearchElementJABName = null, Expression<Func<string>> jABGetSelectionStateByNameSearchElementJABDescription = null, Expression<Func<string>> jABGetSelectionStateByNameSearchElementJABRole = null, Expression<Func<bool>> jABGetSelectionStateByNameSearchSubTree = null, Expression<Func<int>> jABGetSelectionStateByNameMaxRelativeDepth = null, Expression<Func<int>> jABGetSelectionStateByNameMatchIndex = null, Expression<Func<string>> jABGetSelectionStateByNameSearchFilter = null, Expression<Func<string>> jABGetSelectionStateByNameSortByColumn = null, Expression<Func<bool>> jABGetSelectionStateByNameMatchIndexAscending = null, Expression<Func<bool>> jABGetSelectionStateByNameCaseSensitiveSearch = null, Expression<Func<bool>> jABGetSelectionStateByNameOnlySearchVisibleElements = null, Expression<Func<bool>> jABGetSelectionStateByNameOnlySearchShowingElements = null, Expression<Func<string>> jABGetSelectionStateByNameElementRolesNotToTraverse = null, Expression<Func<int>> jABGetSelectionStateByNameMaximumElementsToSearch = null, Expression<Func<int>> jABGetSelectionStateByNameMaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGetSelectionStateByNameItemNameCaseSensitive = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetSelectionStateByName";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetSelectionStateByName = new JObject();
            var jABGetSelectionStateByNamepropCount = 0;
            jABGetSelectionStateByNamepropCount++;
            jABGetSelectionStateByName["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameSearchParentElementJABHandle);
            if (jABGetSelectionStateByNameSearchElementJABName != null)
            {
                jABGetSelectionStateByName["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameSearchElementJABName);
                jABGetSelectionStateByNamepropCount++;
            }

            if (jABGetSelectionStateByNameSearchElementJABDescription != null)
            {
                jABGetSelectionStateByName["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameSearchElementJABDescription);
                jABGetSelectionStateByNamepropCount++;
            }

            if (jABGetSelectionStateByNameSearchElementJABRole != null)
            {
                jABGetSelectionStateByName["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameSearchElementJABRole);
                jABGetSelectionStateByNamepropCount++;
            }

            if (jABGetSelectionStateByNameSearchSubTree != null)
            {
                jABGetSelectionStateByName["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameSearchSubTree);
                jABGetSelectionStateByNamepropCount++;
            }

            if (jABGetSelectionStateByNameMaxRelativeDepth != null)
            {
                jABGetSelectionStateByName["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameMaxRelativeDepth);
                jABGetSelectionStateByNamepropCount++;
            }

            if (jABGetSelectionStateByNameMatchIndex != null)
            {
                jABGetSelectionStateByName["MatchIndex"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameMatchIndex);
                jABGetSelectionStateByNamepropCount++;
            }

            if (jABGetSelectionStateByNameSearchFilter != null)
            {
                jABGetSelectionStateByName["SearchFilter"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameSearchFilter);
                jABGetSelectionStateByNamepropCount++;
            }

            if (jABGetSelectionStateByNameSortByColumn != null)
            {
                jABGetSelectionStateByName["SortByColumn"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameSortByColumn);
                jABGetSelectionStateByNamepropCount++;
            }

            if (jABGetSelectionStateByNameMatchIndexAscending != null)
            {
                jABGetSelectionStateByName["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameMatchIndexAscending);
                jABGetSelectionStateByNamepropCount++;
            }

            if (jABGetSelectionStateByNameCaseSensitiveSearch != null)
            {
                jABGetSelectionStateByName["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameCaseSensitiveSearch);
                jABGetSelectionStateByNamepropCount++;
            }

            if (jABGetSelectionStateByNameOnlySearchVisibleElements != null)
            {
                jABGetSelectionStateByName["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameOnlySearchVisibleElements);
                jABGetSelectionStateByNamepropCount++;
            }

            if (jABGetSelectionStateByNameOnlySearchShowingElements != null)
            {
                jABGetSelectionStateByName["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameOnlySearchShowingElements);
                jABGetSelectionStateByNamepropCount++;
            }

            if (jABGetSelectionStateByNameElementRolesNotToTraverse != null)
            {
                jABGetSelectionStateByName["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameElementRolesNotToTraverse);
                jABGetSelectionStateByNamepropCount++;
            }

            if (jABGetSelectionStateByNameMaximumElementsToSearch != null)
            {
                jABGetSelectionStateByName["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameMaximumElementsToSearch);
                jABGetSelectionStateByNamepropCount++;
            }

            if (jABGetSelectionStateByNameMaximumChildElementsToSearchPerNode != null)
            {
                jABGetSelectionStateByName["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameMaximumChildElementsToSearchPerNode);
                jABGetSelectionStateByNamepropCount++;
            }

            jABGetSelectionStateByNamepropCount++;
            jABGetSelectionStateByName["ItemName"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameItemName);
            if (jABGetSelectionStateByNameItemNameCaseSensitive != null)
            {
                jABGetSelectionStateByName["ItemNameCaseSensitive"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameItemNameCaseSensitive);
                jABGetSelectionStateByNamepropCount++;
            }

            jABGetSelectionStateByNamepropCount++;
            jABGetSelectionStateByName["Workflow"] = ExpressionConverter.ConvertO(jABGetSelectionStateByNameWorkflow);
            if (jABGetSelectionStateByNamepropCount > 0)
            {
                callPayload.Body = jABGetSelectionStateByName;
            }

            return new ApiConnectionAction<JABGetSelectionStateByNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetTablePropertiesResponse> JABGetTableProperties(Expression<Func<int>> jABGetTablePropertiesSearchParentElementJABHandle, Expression<Func<string>> jABGetTablePropertiesWorkflow, Expression<Func<string>> jABGetTablePropertiesSearchElementJABName = null, Expression<Func<string>> jABGetTablePropertiesSearchElementJABDescription = null, Expression<Func<string>> jABGetTablePropertiesSearchElementJABRole = null, Expression<Func<bool>> jABGetTablePropertiesSearchSubTree = null, Expression<Func<int>> jABGetTablePropertiesMaxRelativeDepth = null, Expression<Func<int>> jABGetTablePropertiesMatchIndex = null, Expression<Func<string>> jABGetTablePropertiesSearchFilter = null, Expression<Func<string>> jABGetTablePropertiesSortByColumn = null, Expression<Func<bool>> jABGetTablePropertiesMatchIndexAscending = null, Expression<Func<bool>> jABGetTablePropertiesCaseSensitiveSearch = null, Expression<Func<bool>> jABGetTablePropertiesOnlySearchVisibleElements = null, Expression<Func<bool>> jABGetTablePropertiesOnlySearchShowingElements = null, Expression<Func<string>> jABGetTablePropertiesElementRolesNotToTraverse = null, Expression<Func<int>> jABGetTablePropertiesMaximumElementsToSearch = null, Expression<Func<int>> jABGetTablePropertiesMaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGetTablePropertiesEnumerateViewport = null, Expression<Func<bool>> jABGetTablePropertiesProcessViewportParents = null, Expression<Func<int>> jABGetTablePropertiesMaxViewportParentsToProcess = null, Expression<Func<string>> jABGetTablePropertiesViewportParentElementRolesToConsider = null, Expression<Func<int>> jABGetTablePropertiesViewportLeftMargin = null, Expression<Func<int>> jABGetTablePropertiesViewportTopMargin = null, Expression<Func<int>> jABGetTablePropertiesViewportRightMargin = null, Expression<Func<int>> jABGetTablePropertiesViewportBottomMargin = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetTableProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetTableProperties = new JObject();
            var jABGetTablePropertiespropCount = 0;
            jABGetTablePropertiespropCount++;
            jABGetTableProperties["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetTablePropertiesSearchParentElementJABHandle);
            if (jABGetTablePropertiesSearchElementJABName != null)
            {
                jABGetTableProperties["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetTablePropertiesSearchElementJABName);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesSearchElementJABDescription != null)
            {
                jABGetTableProperties["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetTablePropertiesSearchElementJABDescription);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesSearchElementJABRole != null)
            {
                jABGetTableProperties["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetTablePropertiesSearchElementJABRole);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesSearchSubTree != null)
            {
                jABGetTableProperties["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetTablePropertiesSearchSubTree);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesMaxRelativeDepth != null)
            {
                jABGetTableProperties["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetTablePropertiesMaxRelativeDepth);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesMatchIndex != null)
            {
                jABGetTableProperties["MatchIndex"] = ExpressionConverter.ConvertO(jABGetTablePropertiesMatchIndex);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesSearchFilter != null)
            {
                jABGetTableProperties["SearchFilter"] = ExpressionConverter.ConvertO(jABGetTablePropertiesSearchFilter);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesSortByColumn != null)
            {
                jABGetTableProperties["SortByColumn"] = ExpressionConverter.ConvertO(jABGetTablePropertiesSortByColumn);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesMatchIndexAscending != null)
            {
                jABGetTableProperties["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetTablePropertiesMatchIndexAscending);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesCaseSensitiveSearch != null)
            {
                jABGetTableProperties["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetTablePropertiesCaseSensitiveSearch);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesOnlySearchVisibleElements != null)
            {
                jABGetTableProperties["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetTablePropertiesOnlySearchVisibleElements);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesOnlySearchShowingElements != null)
            {
                jABGetTableProperties["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetTablePropertiesOnlySearchShowingElements);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesElementRolesNotToTraverse != null)
            {
                jABGetTableProperties["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetTablePropertiesElementRolesNotToTraverse);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesMaximumElementsToSearch != null)
            {
                jABGetTableProperties["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetTablePropertiesMaximumElementsToSearch);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesMaximumChildElementsToSearchPerNode != null)
            {
                jABGetTableProperties["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetTablePropertiesMaximumChildElementsToSearchPerNode);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesEnumerateViewport != null)
            {
                jABGetTableProperties["EnumerateViewport"] = ExpressionConverter.ConvertO(jABGetTablePropertiesEnumerateViewport);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesProcessViewportParents != null)
            {
                jABGetTableProperties["ProcessViewportParents"] = ExpressionConverter.ConvertO(jABGetTablePropertiesProcessViewportParents);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesMaxViewportParentsToProcess != null)
            {
                jABGetTableProperties["MaxViewportParentsToProcess"] = ExpressionConverter.ConvertO(jABGetTablePropertiesMaxViewportParentsToProcess);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesViewportParentElementRolesToConsider != null)
            {
                jABGetTableProperties["ViewportParentElementRolesToConsider"] = ExpressionConverter.ConvertO(jABGetTablePropertiesViewportParentElementRolesToConsider);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesViewportLeftMargin != null)
            {
                jABGetTableProperties["ViewportLeftMargin"] = ExpressionConverter.ConvertO(jABGetTablePropertiesViewportLeftMargin);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesViewportTopMargin != null)
            {
                jABGetTableProperties["ViewportTopMargin"] = ExpressionConverter.ConvertO(jABGetTablePropertiesViewportTopMargin);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesViewportRightMargin != null)
            {
                jABGetTableProperties["ViewportRightMargin"] = ExpressionConverter.ConvertO(jABGetTablePropertiesViewportRightMargin);
                jABGetTablePropertiespropCount++;
            }

            if (jABGetTablePropertiesViewportBottomMargin != null)
            {
                jABGetTableProperties["ViewportBottomMargin"] = ExpressionConverter.ConvertO(jABGetTablePropertiesViewportBottomMargin);
                jABGetTablePropertiespropCount++;
            }

            jABGetTablePropertiespropCount++;
            jABGetTableProperties["Workflow"] = ExpressionConverter.ConvertO(jABGetTablePropertiesWorkflow);
            if (jABGetTablePropertiespropCount > 0)
            {
                callPayload.Body = jABGetTableProperties;
            }

            return new ApiConnectionAction<JABGetTablePropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetTableCellPropertiesResponse> JABGetTableCellProperties(Expression<Func<int>> jABGetTableCellPropertiesSearchParentElementJABHandle, Expression<Func<int>> jABGetTableCellPropertiesRowIndex, Expression<Func<int>> jABGetTableCellPropertiesColumnIndex, Expression<Func<string>> jABGetTableCellPropertiesWorkflow, Expression<Func<string>> jABGetTableCellPropertiesSearchElementJABName = null, Expression<Func<string>> jABGetTableCellPropertiesSearchElementJABDescription = null, Expression<Func<string>> jABGetTableCellPropertiesSearchElementJABRole = null, Expression<Func<bool>> jABGetTableCellPropertiesSearchSubTree = null, Expression<Func<int>> jABGetTableCellPropertiesMaxRelativeDepth = null, Expression<Func<int>> jABGetTableCellPropertiesMatchIndex = null, Expression<Func<string>> jABGetTableCellPropertiesSearchFilter = null, Expression<Func<string>> jABGetTableCellPropertiesSortByColumn = null, Expression<Func<bool>> jABGetTableCellPropertiesMatchIndexAscending = null, Expression<Func<bool>> jABGetTableCellPropertiesCaseSensitiveSearch = null, Expression<Func<bool>> jABGetTableCellPropertiesOnlySearchVisibleElements = null, Expression<Func<bool>> jABGetTableCellPropertiesOnlySearchShowingElements = null, Expression<Func<string>> jABGetTableCellPropertiesElementRolesNotToTraverse = null, Expression<Func<int>> jABGetTableCellPropertiesMaximumElementsToSearch = null, Expression<Func<int>> jABGetTableCellPropertiesMaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGetTableCellPropertiesReturnJABHandle = null, Expression<Func<bool>> jABGetTableCellPropertiesEnumerateViewport = null, Expression<Func<bool>> jABGetTableCellPropertiesProcessViewportParents = null, Expression<Func<int>> jABGetTableCellPropertiesMaxViewportParentsToProcess = null, Expression<Func<string>> jABGetTableCellPropertiesViewportParentElementRolesToConsider = null, Expression<Func<int>> jABGetTableCellPropertiesViewportLeftMargin = null, Expression<Func<int>> jABGetTableCellPropertiesViewportTopMargin = null, Expression<Func<int>> jABGetTableCellPropertiesViewportRightMargin = null, Expression<Func<int>> jABGetTableCellPropertiesViewportBottomMargin = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetTableCellProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetTableCellProperties = new JObject();
            var jABGetTableCellPropertiespropCount = 0;
            jABGetTableCellPropertiespropCount++;
            jABGetTableCellProperties["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesSearchParentElementJABHandle);
            if (jABGetTableCellPropertiesSearchElementJABName != null)
            {
                jABGetTableCellProperties["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesSearchElementJABName);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesSearchElementJABDescription != null)
            {
                jABGetTableCellProperties["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesSearchElementJABDescription);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesSearchElementJABRole != null)
            {
                jABGetTableCellProperties["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesSearchElementJABRole);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesSearchSubTree != null)
            {
                jABGetTableCellProperties["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesSearchSubTree);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesMaxRelativeDepth != null)
            {
                jABGetTableCellProperties["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesMaxRelativeDepth);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesMatchIndex != null)
            {
                jABGetTableCellProperties["MatchIndex"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesMatchIndex);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesSearchFilter != null)
            {
                jABGetTableCellProperties["SearchFilter"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesSearchFilter);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesSortByColumn != null)
            {
                jABGetTableCellProperties["SortByColumn"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesSortByColumn);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesMatchIndexAscending != null)
            {
                jABGetTableCellProperties["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesMatchIndexAscending);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesCaseSensitiveSearch != null)
            {
                jABGetTableCellProperties["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesCaseSensitiveSearch);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesOnlySearchVisibleElements != null)
            {
                jABGetTableCellProperties["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesOnlySearchVisibleElements);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesOnlySearchShowingElements != null)
            {
                jABGetTableCellProperties["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesOnlySearchShowingElements);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesElementRolesNotToTraverse != null)
            {
                jABGetTableCellProperties["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesElementRolesNotToTraverse);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesMaximumElementsToSearch != null)
            {
                jABGetTableCellProperties["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesMaximumElementsToSearch);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesMaximumChildElementsToSearchPerNode != null)
            {
                jABGetTableCellProperties["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesMaximumChildElementsToSearchPerNode);
                jABGetTableCellPropertiespropCount++;
            }

            jABGetTableCellPropertiespropCount++;
            jABGetTableCellProperties["RowIndex"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesRowIndex);
            jABGetTableCellPropertiespropCount++;
            jABGetTableCellProperties["ColumnIndex"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesColumnIndex);
            if (jABGetTableCellPropertiesReturnJABHandle != null)
            {
                jABGetTableCellProperties["ReturnJABHandle"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesReturnJABHandle);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesEnumerateViewport != null)
            {
                jABGetTableCellProperties["EnumerateViewport"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesEnumerateViewport);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesProcessViewportParents != null)
            {
                jABGetTableCellProperties["ProcessViewportParents"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesProcessViewportParents);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesMaxViewportParentsToProcess != null)
            {
                jABGetTableCellProperties["MaxViewportParentsToProcess"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesMaxViewportParentsToProcess);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesViewportParentElementRolesToConsider != null)
            {
                jABGetTableCellProperties["ViewportParentElementRolesToConsider"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesViewportParentElementRolesToConsider);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesViewportLeftMargin != null)
            {
                jABGetTableCellProperties["ViewportLeftMargin"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesViewportLeftMargin);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesViewportTopMargin != null)
            {
                jABGetTableCellProperties["ViewportTopMargin"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesViewportTopMargin);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesViewportRightMargin != null)
            {
                jABGetTableCellProperties["ViewportRightMargin"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesViewportRightMargin);
                jABGetTableCellPropertiespropCount++;
            }

            if (jABGetTableCellPropertiesViewportBottomMargin != null)
            {
                jABGetTableCellProperties["ViewportBottomMargin"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesViewportBottomMargin);
                jABGetTableCellPropertiespropCount++;
            }

            jABGetTableCellPropertiespropCount++;
            jABGetTableCellProperties["Workflow"] = ExpressionConverter.ConvertO(jABGetTableCellPropertiesWorkflow);
            if (jABGetTableCellPropertiespropCount > 0)
            {
                callPayload.Body = jABGetTableCellProperties;
            }

            return new ApiConnectionAction<JABGetTableCellPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetTableContentsResponse> JABGetTableContents(Expression<Func<int>> jABGetTableContentsSearchParentElementJABHandle, Expression<Func<string>> jABGetTableContentsWorkflow, Expression<Func<string>> jABGetTableContentsSearchElementJABName = null, Expression<Func<string>> jABGetTableContentsSearchElementJABDescription = null, Expression<Func<string>> jABGetTableContentsSearchElementJABRole = null, Expression<Func<bool>> jABGetTableContentsSearchSubTree = null, Expression<Func<int>> jABGetTableContentsMaxRelativeDepth = null, Expression<Func<int>> jABGetTableContentsMatchIndex = null, Expression<Func<string>> jABGetTableContentsSearchFilter = null, Expression<Func<string>> jABGetTableContentsSortByColumn = null, Expression<Func<bool>> jABGetTableContentsMatchIndexAscending = null, Expression<Func<bool>> jABGetTableContentsCaseSensitiveSearch = null, Expression<Func<bool>> jABGetTableContentsOnlySearchVisibleElements = null, Expression<Func<bool>> jABGetTableContentsOnlySearchShowingElements = null, Expression<Func<string>> jABGetTableContentsElementRolesNotToTraverse = null, Expression<Func<int>> jABGetTableContentsMaximumElementsToSearch = null, Expression<Func<int>> jABGetTableContentsMaximumChildElementsToSearchPerNode = null, Expression<Func<int>> jABGetTableContentsFirstRowToReturn = null, Expression<Func<int>> jABGetTableContentsMaxRowsToReturn = null, Expression<Func<int>> jABGetTableContentsFirstColumnToReturn = null, Expression<Func<int>> jABGetTableContentsMaxColumnsToReturn = null, Expression<Func<bool>> jABGetTableContentsUseColumnHeadersFromTable = null, Expression<Func<bool>> jABGetTableContentsReturnRowIndexInOutputCollection = null, Expression<Func<string>> jABGetTableContentsNameOfColumnToStoreRowIndex = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetTableContents";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetTableContents = new JObject();
            var jABGetTableContentspropCount = 0;
            jABGetTableContentspropCount++;
            jABGetTableContents["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetTableContentsSearchParentElementJABHandle);
            if (jABGetTableContentsSearchElementJABName != null)
            {
                jABGetTableContents["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetTableContentsSearchElementJABName);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsSearchElementJABDescription != null)
            {
                jABGetTableContents["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetTableContentsSearchElementJABDescription);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsSearchElementJABRole != null)
            {
                jABGetTableContents["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetTableContentsSearchElementJABRole);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsSearchSubTree != null)
            {
                jABGetTableContents["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetTableContentsSearchSubTree);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsMaxRelativeDepth != null)
            {
                jABGetTableContents["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetTableContentsMaxRelativeDepth);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsMatchIndex != null)
            {
                jABGetTableContents["MatchIndex"] = ExpressionConverter.ConvertO(jABGetTableContentsMatchIndex);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsSearchFilter != null)
            {
                jABGetTableContents["SearchFilter"] = ExpressionConverter.ConvertO(jABGetTableContentsSearchFilter);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsSortByColumn != null)
            {
                jABGetTableContents["SortByColumn"] = ExpressionConverter.ConvertO(jABGetTableContentsSortByColumn);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsMatchIndexAscending != null)
            {
                jABGetTableContents["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetTableContentsMatchIndexAscending);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsCaseSensitiveSearch != null)
            {
                jABGetTableContents["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetTableContentsCaseSensitiveSearch);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsOnlySearchVisibleElements != null)
            {
                jABGetTableContents["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetTableContentsOnlySearchVisibleElements);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsOnlySearchShowingElements != null)
            {
                jABGetTableContents["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetTableContentsOnlySearchShowingElements);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsElementRolesNotToTraverse != null)
            {
                jABGetTableContents["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetTableContentsElementRolesNotToTraverse);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsMaximumElementsToSearch != null)
            {
                jABGetTableContents["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetTableContentsMaximumElementsToSearch);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsMaximumChildElementsToSearchPerNode != null)
            {
                jABGetTableContents["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetTableContentsMaximumChildElementsToSearchPerNode);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsFirstRowToReturn != null)
            {
                jABGetTableContents["FirstRowToReturn"] = ExpressionConverter.ConvertO(jABGetTableContentsFirstRowToReturn);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsMaxRowsToReturn != null)
            {
                jABGetTableContents["MaxRowsToReturn"] = ExpressionConverter.ConvertO(jABGetTableContentsMaxRowsToReturn);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsFirstColumnToReturn != null)
            {
                jABGetTableContents["FirstColumnToReturn"] = ExpressionConverter.ConvertO(jABGetTableContentsFirstColumnToReturn);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsMaxColumnsToReturn != null)
            {
                jABGetTableContents["MaxColumnsToReturn"] = ExpressionConverter.ConvertO(jABGetTableContentsMaxColumnsToReturn);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsUseColumnHeadersFromTable != null)
            {
                jABGetTableContents["UseColumnHeadersFromTable"] = ExpressionConverter.ConvertO(jABGetTableContentsUseColumnHeadersFromTable);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsReturnRowIndexInOutputCollection != null)
            {
                jABGetTableContents["ReturnRowIndexInOutputCollection"] = ExpressionConverter.ConvertO(jABGetTableContentsReturnRowIndexInOutputCollection);
                jABGetTableContentspropCount++;
            }

            if (jABGetTableContentsNameOfColumnToStoreRowIndex != null)
            {
                jABGetTableContents["NameOfColumnToStoreRowIndex"] = ExpressionConverter.ConvertO(jABGetTableContentsNameOfColumnToStoreRowIndex);
                jABGetTableContentspropCount++;
            }

            jABGetTableContentspropCount++;
            jABGetTableContents["Workflow"] = ExpressionConverter.ConvertO(jABGetTableContentsWorkflow);
            if (jABGetTableContentspropCount > 0)
            {
                callPayload.Body = jABGetTableContents;
            }

            return new ApiConnectionAction<JABGetTableContentsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABIsTableCellVisibleOnscreenResponse> JABIsTableCellVisibleOnscreen(Expression<Func<int>> jABIsTableCellVisibleOnscreenSearchParentElementJABHandle, Expression<Func<int>> jABIsTableCellVisibleOnscreenCellRowIndex, Expression<Func<int>> jABIsTableCellVisibleOnscreenCellColumnIndex, Expression<Func<string>> jABIsTableCellVisibleOnscreenWorkflow, Expression<Func<string>> jABIsTableCellVisibleOnscreenSearchElementJABName = null, Expression<Func<string>> jABIsTableCellVisibleOnscreenSearchElementJABDescription = null, Expression<Func<string>> jABIsTableCellVisibleOnscreenSearchElementJABRole = null, Expression<Func<bool>> jABIsTableCellVisibleOnscreenSearchSubTree = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenMaxRelativeDepth = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenMatchIndex = null, Expression<Func<string>> jABIsTableCellVisibleOnscreenSearchFilter = null, Expression<Func<string>> jABIsTableCellVisibleOnscreenSortByColumn = null, Expression<Func<bool>> jABIsTableCellVisibleOnscreenMatchIndexAscending = null, Expression<Func<bool>> jABIsTableCellVisibleOnscreenCaseSensitiveSearch = null, Expression<Func<bool>> jABIsTableCellVisibleOnscreenOnlySearchVisibleElements = null, Expression<Func<bool>> jABIsTableCellVisibleOnscreenOnlySearchShowingElements = null, Expression<Func<string>> jABIsTableCellVisibleOnscreenElementRolesNotToTraverse = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenMaximumElementsToSearch = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenMaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABIsTableCellVisibleOnscreenProcessViewportParents = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenMaxViewportParentsToProcess = null, Expression<Func<string>> jABIsTableCellVisibleOnscreenViewportParentElementRolesToConsider = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenViewportLeftMargin = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenViewportTopMargin = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenViewportRightMargin = null, Expression<Func<int>> jABIsTableCellVisibleOnscreenViewportBottomMargin = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABIsTableCellVisibleOnscreen";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABIsTableCellVisibleOnscreen = new JObject();
            var jABIsTableCellVisibleOnscreenpropCount = 0;
            jABIsTableCellVisibleOnscreenpropCount++;
            jABIsTableCellVisibleOnscreen["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenSearchParentElementJABHandle);
            if (jABIsTableCellVisibleOnscreenSearchElementJABName != null)
            {
                jABIsTableCellVisibleOnscreen["SearchElementJABName"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenSearchElementJABName);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenSearchElementJABDescription != null)
            {
                jABIsTableCellVisibleOnscreen["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenSearchElementJABDescription);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenSearchElementJABRole != null)
            {
                jABIsTableCellVisibleOnscreen["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenSearchElementJABRole);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenSearchSubTree != null)
            {
                jABIsTableCellVisibleOnscreen["SearchSubTree"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenSearchSubTree);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenMaxRelativeDepth != null)
            {
                jABIsTableCellVisibleOnscreen["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenMaxRelativeDepth);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenMatchIndex != null)
            {
                jABIsTableCellVisibleOnscreen["MatchIndex"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenMatchIndex);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenSearchFilter != null)
            {
                jABIsTableCellVisibleOnscreen["SearchFilter"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenSearchFilter);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenSortByColumn != null)
            {
                jABIsTableCellVisibleOnscreen["SortByColumn"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenSortByColumn);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenMatchIndexAscending != null)
            {
                jABIsTableCellVisibleOnscreen["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenMatchIndexAscending);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenCaseSensitiveSearch != null)
            {
                jABIsTableCellVisibleOnscreen["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenCaseSensitiveSearch);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenOnlySearchVisibleElements != null)
            {
                jABIsTableCellVisibleOnscreen["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenOnlySearchVisibleElements);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenOnlySearchShowingElements != null)
            {
                jABIsTableCellVisibleOnscreen["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenOnlySearchShowingElements);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenElementRolesNotToTraverse != null)
            {
                jABIsTableCellVisibleOnscreen["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenElementRolesNotToTraverse);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenMaximumElementsToSearch != null)
            {
                jABIsTableCellVisibleOnscreen["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenMaximumElementsToSearch);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenMaximumChildElementsToSearchPerNode != null)
            {
                jABIsTableCellVisibleOnscreen["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenMaximumChildElementsToSearchPerNode);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenProcessViewportParents != null)
            {
                jABIsTableCellVisibleOnscreen["ProcessViewportParents"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenProcessViewportParents);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenMaxViewportParentsToProcess != null)
            {
                jABIsTableCellVisibleOnscreen["MaxViewportParentsToProcess"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenMaxViewportParentsToProcess);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenViewportParentElementRolesToConsider != null)
            {
                jABIsTableCellVisibleOnscreen["ViewportParentElementRolesToConsider"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenViewportParentElementRolesToConsider);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenViewportLeftMargin != null)
            {
                jABIsTableCellVisibleOnscreen["ViewportLeftMargin"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenViewportLeftMargin);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenViewportTopMargin != null)
            {
                jABIsTableCellVisibleOnscreen["ViewportTopMargin"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenViewportTopMargin);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenViewportRightMargin != null)
            {
                jABIsTableCellVisibleOnscreen["ViewportRightMargin"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenViewportRightMargin);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            if (jABIsTableCellVisibleOnscreenViewportBottomMargin != null)
            {
                jABIsTableCellVisibleOnscreen["ViewportBottomMargin"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenViewportBottomMargin);
                jABIsTableCellVisibleOnscreenpropCount++;
            }

            jABIsTableCellVisibleOnscreenpropCount++;
            jABIsTableCellVisibleOnscreen["CellRowIndex"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenCellRowIndex);
            jABIsTableCellVisibleOnscreenpropCount++;
            jABIsTableCellVisibleOnscreen["CellColumnIndex"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenCellColumnIndex);
            jABIsTableCellVisibleOnscreenpropCount++;
            jABIsTableCellVisibleOnscreen["Workflow"] = ExpressionConverter.ConvertO(jABIsTableCellVisibleOnscreenWorkflow);
            if (jABIsTableCellVisibleOnscreenpropCount > 0)
            {
                callPayload.Body = jABIsTableCellVisibleOnscreen;
            }

            return new ApiConnectionAction<JABIsTableCellVisibleOnscreenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABIsJABHandleSameObjectResponse> JABIsJABHandleSameObject(Expression<Func<int>> jABIsJABHandleSameObjectElement1JABHandle, Expression<Func<int>> jABIsJABHandleSameObjectElement2JABHandle, Expression<Func<string>> jABIsJABHandleSameObjectWorkflow)
        {
            var apiCallPath = "/JavaAccessBridge/JABIsJABHandleSameObject";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABIsJABHandleSameObject = new JObject();
            var jABIsJABHandleSameObjectpropCount = 0;
            jABIsJABHandleSameObjectpropCount++;
            jABIsJABHandleSameObject["Element1JABHandle"] = ExpressionConverter.ConvertO(jABIsJABHandleSameObjectElement1JABHandle);
            jABIsJABHandleSameObjectpropCount++;
            jABIsJABHandleSameObject["Element2JABHandle"] = ExpressionConverter.ConvertO(jABIsJABHandleSameObjectElement2JABHandle);
            jABIsJABHandleSameObjectpropCount++;
            jABIsJABHandleSameObject["Workflow"] = ExpressionConverter.ConvertO(jABIsJABHandleSameObjectWorkflow);
            if (jABIsJABHandleSameObjectpropCount > 0)
            {
                callPayload.Body = jABIsJABHandleSameObject;
            }

            return new ApiConnectionAction<JABIsJABHandleSameObjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetVisibleBoundingRectangleOfElementOnscreenResponse> JABGetVisibleBoundingRectangleOfElementOnscreen(Expression<Func<int>> jABGetVisibleBoundingRectangleOfElementOnscreenElementJABHandle, Expression<Func<string>> jABGetVisibleBoundingRectangleOfElementOnscreenWorkflow, Expression<Func<int>> jABGetVisibleBoundingRectangleOfElementOnscreenMaxParentsToProcess = null, Expression<Func<string>> jABGetVisibleBoundingRectangleOfElementOnscreenParentElementRolesToConsider = null, Expression<Func<bool>> jABGetVisibleBoundingRectangleOfElementOnscreenDrawRectangle = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetVisibleBoundingRectangleOfElementOnscreen";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetVisibleBoundingRectangleOfElementOnscreen = new JObject();
            var jABGetVisibleBoundingRectangleOfElementOnscreenpropCount = 0;
            jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
            jABGetVisibleBoundingRectangleOfElementOnscreen["ElementJABHandle"] = ExpressionConverter.ConvertO(jABGetVisibleBoundingRectangleOfElementOnscreenElementJABHandle);
            if (jABGetVisibleBoundingRectangleOfElementOnscreenMaxParentsToProcess != null)
            {
                jABGetVisibleBoundingRectangleOfElementOnscreen["MaxParentsToProcess"] = ExpressionConverter.ConvertO(jABGetVisibleBoundingRectangleOfElementOnscreenMaxParentsToProcess);
                jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
            }

            if (jABGetVisibleBoundingRectangleOfElementOnscreenParentElementRolesToConsider != null)
            {
                jABGetVisibleBoundingRectangleOfElementOnscreen["ParentElementRolesToConsider"] = ExpressionConverter.ConvertO(jABGetVisibleBoundingRectangleOfElementOnscreenParentElementRolesToConsider);
                jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
            }

            if (jABGetVisibleBoundingRectangleOfElementOnscreenDrawRectangle != null)
            {
                jABGetVisibleBoundingRectangleOfElementOnscreen["DrawRectangle"] = ExpressionConverter.ConvertO(jABGetVisibleBoundingRectangleOfElementOnscreenDrawRectangle);
                jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
            }

            jABGetVisibleBoundingRectangleOfElementOnscreenpropCount++;
            jABGetVisibleBoundingRectangleOfElementOnscreen["Workflow"] = ExpressionConverter.ConvertO(jABGetVisibleBoundingRectangleOfElementOnscreenWorkflow);
            if (jABGetVisibleBoundingRectangleOfElementOnscreenpropCount > 0)
            {
                callPayload.Body = jABGetVisibleBoundingRectangleOfElementOnscreen;
            }

            return new ApiConnectionAction<JABGetVisibleBoundingRectangleOfElementOnscreenResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABCreateHandleForJABElementAtScreenCoordinateResponse> JABCreateHandleForJABElementAtScreenCoordinate(Expression<Func<int>> jABCreateHandleForJABElementAtScreenCoordinateParentElementJABHandle, Expression<Func<int>> jABCreateHandleForJABElementAtScreenCoordinateScreenX, Expression<Func<int>> jABCreateHandleForJABElementAtScreenCoordinateScreenY, Expression<Func<string>> jABCreateHandleForJABElementAtScreenCoordinateWorkflow)
        {
            var apiCallPath = "/JavaAccessBridge/JABCreateHandleForJABElementAtScreenCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABCreateHandleForJABElementAtScreenCoordinate = new JObject();
            var jABCreateHandleForJABElementAtScreenCoordinatepropCount = 0;
            jABCreateHandleForJABElementAtScreenCoordinatepropCount++;
            jABCreateHandleForJABElementAtScreenCoordinate["ParentElementJABHandle"] = ExpressionConverter.ConvertO(jABCreateHandleForJABElementAtScreenCoordinateParentElementJABHandle);
            jABCreateHandleForJABElementAtScreenCoordinatepropCount++;
            jABCreateHandleForJABElementAtScreenCoordinate["ScreenX"] = ExpressionConverter.ConvertO(jABCreateHandleForJABElementAtScreenCoordinateScreenX);
            jABCreateHandleForJABElementAtScreenCoordinatepropCount++;
            jABCreateHandleForJABElementAtScreenCoordinate["ScreenY"] = ExpressionConverter.ConvertO(jABCreateHandleForJABElementAtScreenCoordinateScreenY);
            jABCreateHandleForJABElementAtScreenCoordinatepropCount++;
            jABCreateHandleForJABElementAtScreenCoordinate["Workflow"] = ExpressionConverter.ConvertO(jABCreateHandleForJABElementAtScreenCoordinateWorkflow);
            if (jABCreateHandleForJABElementAtScreenCoordinatepropCount > 0)
            {
                callPayload.Body = jABCreateHandleForJABElementAtScreenCoordinate;
            }

            return new ApiConnectionAction<JABCreateHandleForJABElementAtScreenCoordinateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetTableCellAtScreenCoordinateResponse> JABGetTableCellAtScreenCoordinate(Expression<Func<int>> jABGetTableCellAtScreenCoordinateTableElementJABHandle, Expression<Func<int>> jABGetTableCellAtScreenCoordinateScreenX, Expression<Func<int>> jABGetTableCellAtScreenCoordinateScreenY, Expression<Func<string>> jABGetTableCellAtScreenCoordinateWorkflow, Expression<Func<bool>> jABGetTableCellAtScreenCoordinateReturnJABHandle = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetTableCellAtScreenCoordinate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetTableCellAtScreenCoordinate = new JObject();
            var jABGetTableCellAtScreenCoordinatepropCount = 0;
            jABGetTableCellAtScreenCoordinatepropCount++;
            jABGetTableCellAtScreenCoordinate["TableElementJABHandle"] = ExpressionConverter.ConvertO(jABGetTableCellAtScreenCoordinateTableElementJABHandle);
            jABGetTableCellAtScreenCoordinatepropCount++;
            jABGetTableCellAtScreenCoordinate["ScreenX"] = ExpressionConverter.ConvertO(jABGetTableCellAtScreenCoordinateScreenX);
            jABGetTableCellAtScreenCoordinatepropCount++;
            jABGetTableCellAtScreenCoordinate["ScreenY"] = ExpressionConverter.ConvertO(jABGetTableCellAtScreenCoordinateScreenY);
            if (jABGetTableCellAtScreenCoordinateReturnJABHandle != null)
            {
                jABGetTableCellAtScreenCoordinate["ReturnJABHandle"] = ExpressionConverter.ConvertO(jABGetTableCellAtScreenCoordinateReturnJABHandle);
                jABGetTableCellAtScreenCoordinatepropCount++;
            }

            jABGetTableCellAtScreenCoordinatepropCount++;
            jABGetTableCellAtScreenCoordinate["Workflow"] = ExpressionConverter.ConvertO(jABGetTableCellAtScreenCoordinateWorkflow);
            if (jABGetTableCellAtScreenCoordinatepropCount > 0)
            {
                callPayload.Body = jABGetTableCellAtScreenCoordinate;
            }

            return new ApiConnectionAction<JABGetTableCellAtScreenCoordinateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetMultipleParentJABElementPropertiesResponse> JABGetMultipleParentJABElementProperties(Expression<Func<int>> jABGetMultipleParentJABElementPropertiesSearchElementJABHandle, Expression<Func<string>> jABGetMultipleParentJABElementPropertiesWorkflow, Expression<Func<int>> jABGetMultipleParentJABElementPropertiesMaxStringLength = null, Expression<Func<int>> jABGetMultipleParentJABElementPropertiesMaxParentsToProcess = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetMultipleParentJABElementProperties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetMultipleParentJABElementProperties = new JObject();
            var jABGetMultipleParentJABElementPropertiespropCount = 0;
            jABGetMultipleParentJABElementPropertiespropCount++;
            jABGetMultipleParentJABElementProperties["SearchElementJABHandle"] = ExpressionConverter.ConvertO(jABGetMultipleParentJABElementPropertiesSearchElementJABHandle);
            if (jABGetMultipleParentJABElementPropertiesMaxStringLength != null)
            {
                jABGetMultipleParentJABElementProperties["MaxStringLength"] = ExpressionConverter.ConvertO(jABGetMultipleParentJABElementPropertiesMaxStringLength);
                jABGetMultipleParentJABElementPropertiespropCount++;
            }

            if (jABGetMultipleParentJABElementPropertiesMaxParentsToProcess != null)
            {
                jABGetMultipleParentJABElementProperties["MaxParentsToProcess"] = ExpressionConverter.ConvertO(jABGetMultipleParentJABElementPropertiesMaxParentsToProcess);
                jABGetMultipleParentJABElementPropertiespropCount++;
            }

            jABGetMultipleParentJABElementPropertiespropCount++;
            jABGetMultipleParentJABElementProperties["Workflow"] = ExpressionConverter.ConvertO(jABGetMultipleParentJABElementPropertiesWorkflow);
            if (jABGetMultipleParentJABElementPropertiespropCount > 0)
            {
                callPayload.Body = jABGetMultipleParentJABElementProperties;
            }

            return new ApiConnectionAction<JABGetMultipleParentJABElementPropertiesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IWorkflowAction JABGlobalMouseClickOnTableCell(Expression<Func<int>> jABGlobalMouseClickOnTableCellSearchParentElementJABHandle, Expression<Func<int>> jABGlobalMouseClickOnTableCellRowIndex, Expression<Func<int>> jABGlobalMouseClickOnTableCellColumnIndex, Expression<Func<int>> jABGlobalMouseClickOnTableCellMouseButton, Expression<Func<string>> jABGlobalMouseClickOnTableCellWorkflow, Expression<Func<string>> jABGlobalMouseClickOnTableCellSearchElementJABName = null, Expression<Func<string>> jABGlobalMouseClickOnTableCellSearchElementJABDescription = null, Expression<Func<string>> jABGlobalMouseClickOnTableCellSearchElementJABRole = null, Expression<Func<bool>> jABGlobalMouseClickOnTableCellSearchSubTree = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellMaxRelativeDepth = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellMatchIndex = null, Expression<Func<string>> jABGlobalMouseClickOnTableCellSearchFilter = null, Expression<Func<string>> jABGlobalMouseClickOnTableCellSortByColumn = null, Expression<Func<bool>> jABGlobalMouseClickOnTableCellMatchIndexAscending = null, Expression<Func<bool>> jABGlobalMouseClickOnTableCellCaseSensitiveSearch = null, Expression<Func<bool>> jABGlobalMouseClickOnTableCellOnlySearchVisibleElements = null, Expression<Func<bool>> jABGlobalMouseClickOnTableCellOnlySearchShowingElements = null, Expression<Func<string>> jABGlobalMouseClickOnTableCellElementRolesNotToTraverse = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellMaximumElementsToSearch = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellMaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGlobalMouseClickOnTableCellEnumerateViewport = null, Expression<Func<bool>> jABGlobalMouseClickOnTableCellProcessViewportParents = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellMaxViewportParentsToProcess = null, Expression<Func<string>> jABGlobalMouseClickOnTableCellViewportParentElementRolesToConsider = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellViewportLeftMargin = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellViewportTopMargin = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellViewportRightMargin = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellViewportBottomMargin = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellClickOffsetX = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellClickOffsetY = null, Expression<Func<jABGlobalMouseClickOnTableCellOffsetRelativeToInput>> jABGlobalMouseClickOnTableCellOffsetRelativeTo = null, Expression<Func<int>> jABGlobalMouseClickOnTableCellDelayInMilliseconds = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGlobalMouseClickOnTableCell";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGlobalMouseClickOnTableCell = new JObject();
            var jABGlobalMouseClickOnTableCellpropCount = 0;
            jABGlobalMouseClickOnTableCellpropCount++;
            jABGlobalMouseClickOnTableCell["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellSearchParentElementJABHandle);
            if (jABGlobalMouseClickOnTableCellSearchElementJABName != null)
            {
                jABGlobalMouseClickOnTableCell["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellSearchElementJABName);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellSearchElementJABDescription != null)
            {
                jABGlobalMouseClickOnTableCell["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellSearchElementJABDescription);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellSearchElementJABRole != null)
            {
                jABGlobalMouseClickOnTableCell["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellSearchElementJABRole);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellSearchSubTree != null)
            {
                jABGlobalMouseClickOnTableCell["SearchSubTree"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellSearchSubTree);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellMaxRelativeDepth != null)
            {
                jABGlobalMouseClickOnTableCell["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellMaxRelativeDepth);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellMatchIndex != null)
            {
                jABGlobalMouseClickOnTableCell["MatchIndex"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellMatchIndex);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellSearchFilter != null)
            {
                jABGlobalMouseClickOnTableCell["SearchFilter"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellSearchFilter);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellSortByColumn != null)
            {
                jABGlobalMouseClickOnTableCell["SortByColumn"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellSortByColumn);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellMatchIndexAscending != null)
            {
                jABGlobalMouseClickOnTableCell["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellMatchIndexAscending);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellCaseSensitiveSearch != null)
            {
                jABGlobalMouseClickOnTableCell["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellCaseSensitiveSearch);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellOnlySearchVisibleElements != null)
            {
                jABGlobalMouseClickOnTableCell["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellOnlySearchVisibleElements);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellOnlySearchShowingElements != null)
            {
                jABGlobalMouseClickOnTableCell["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellOnlySearchShowingElements);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellElementRolesNotToTraverse != null)
            {
                jABGlobalMouseClickOnTableCell["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellElementRolesNotToTraverse);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellMaximumElementsToSearch != null)
            {
                jABGlobalMouseClickOnTableCell["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellMaximumElementsToSearch);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellMaximumChildElementsToSearchPerNode != null)
            {
                jABGlobalMouseClickOnTableCell["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellMaximumChildElementsToSearchPerNode);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            jABGlobalMouseClickOnTableCellpropCount++;
            jABGlobalMouseClickOnTableCell["RowIndex"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellRowIndex);
            jABGlobalMouseClickOnTableCellpropCount++;
            jABGlobalMouseClickOnTableCell["ColumnIndex"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellColumnIndex);
            if (jABGlobalMouseClickOnTableCellEnumerateViewport != null)
            {
                jABGlobalMouseClickOnTableCell["EnumerateViewport"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellEnumerateViewport);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellProcessViewportParents != null)
            {
                jABGlobalMouseClickOnTableCell["ProcessViewportParents"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellProcessViewportParents);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellMaxViewportParentsToProcess != null)
            {
                jABGlobalMouseClickOnTableCell["MaxViewportParentsToProcess"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellMaxViewportParentsToProcess);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellViewportParentElementRolesToConsider != null)
            {
                jABGlobalMouseClickOnTableCell["ViewportParentElementRolesToConsider"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellViewportParentElementRolesToConsider);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellViewportLeftMargin != null)
            {
                jABGlobalMouseClickOnTableCell["ViewportLeftMargin"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellViewportLeftMargin);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellViewportTopMargin != null)
            {
                jABGlobalMouseClickOnTableCell["ViewportTopMargin"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellViewportTopMargin);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellViewportRightMargin != null)
            {
                jABGlobalMouseClickOnTableCell["ViewportRightMargin"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellViewportRightMargin);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellViewportBottomMargin != null)
            {
                jABGlobalMouseClickOnTableCell["ViewportBottomMargin"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellViewportBottomMargin);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            jABGlobalMouseClickOnTableCellpropCount++;
            jABGlobalMouseClickOnTableCell["MouseButton"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellMouseButton);
            if (jABGlobalMouseClickOnTableCellClickOffsetX != null)
            {
                jABGlobalMouseClickOnTableCell["ClickOffsetX"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellClickOffsetX);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellClickOffsetY != null)
            {
                jABGlobalMouseClickOnTableCell["ClickOffsetY"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellClickOffsetY);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellOffsetRelativeTo != null)
            {
                jABGlobalMouseClickOnTableCell["OffsetRelativeTo"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellOffsetRelativeTo);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            if (jABGlobalMouseClickOnTableCellDelayInMilliseconds != null)
            {
                jABGlobalMouseClickOnTableCell["DelayInMilliseconds"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellDelayInMilliseconds);
                jABGlobalMouseClickOnTableCellpropCount++;
            }

            jABGlobalMouseClickOnTableCellpropCount++;
            jABGlobalMouseClickOnTableCell["Workflow"] = ExpressionConverter.ConvertO(jABGlobalMouseClickOnTableCellWorkflow);
            if (jABGlobalMouseClickOnTableCellpropCount > 0)
            {
                callPayload.Body = jABGlobalMouseClickOnTableCell;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetRoleCSVFromElementSearchResponse> JABGetRoleCSVFromElementSearch(Expression<Func<int>> jABGetRoleCSVFromElementSearchSearchParentElementJABHandle, Expression<Func<string>> jABGetRoleCSVFromElementSearchWorkflow, Expression<Func<string>> jABGetRoleCSVFromElementSearchSearchElementJABName = null, Expression<Func<string>> jABGetRoleCSVFromElementSearchSearchElementJABDescription = null, Expression<Func<string>> jABGetRoleCSVFromElementSearchSearchElementJABRole = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchSearchSubTree = null, Expression<Func<int>> jABGetRoleCSVFromElementSearchMaxRelativeDepth = null, Expression<Func<int>> jABGetRoleCSVFromElementSearchMatchIndex = null, Expression<Func<string>> jABGetRoleCSVFromElementSearchSearchFilter = null, Expression<Func<string>> jABGetRoleCSVFromElementSearchSortByColumn = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchMatchIndexAscending = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchCaseSensitiveSearch = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchOnlySearchVisibleElements = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchOnlySearchShowingElements = null, Expression<Func<string>> jABGetRoleCSVFromElementSearchElementRolesNotToTraverse = null, Expression<Func<int>> jABGetRoleCSVFromElementSearchMaximumElementsToSearch = null, Expression<Func<int>> jABGetRoleCSVFromElementSearchMaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchIndentRoleInCSV = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchIncludeDescriptionInCSV = null, Expression<Func<bool>> jABGetRoleCSVFromElementSearchIncludeDimensionsInCSV = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetRoleCSVFromElementSearch";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetRoleCSVFromElementSearch = new JObject();
            var jABGetRoleCSVFromElementSearchpropCount = 0;
            jABGetRoleCSVFromElementSearchpropCount++;
            jABGetRoleCSVFromElementSearch["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchSearchParentElementJABHandle);
            if (jABGetRoleCSVFromElementSearchSearchElementJABName != null)
            {
                jABGetRoleCSVFromElementSearch["SearchElementJABName"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchSearchElementJABName);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchSearchElementJABDescription != null)
            {
                jABGetRoleCSVFromElementSearch["SearchElementJABDescription"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchSearchElementJABDescription);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchSearchElementJABRole != null)
            {
                jABGetRoleCSVFromElementSearch["SearchElementJABRole"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchSearchElementJABRole);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchSearchSubTree != null)
            {
                jABGetRoleCSVFromElementSearch["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchSearchSubTree);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchMaxRelativeDepth != null)
            {
                jABGetRoleCSVFromElementSearch["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchMaxRelativeDepth);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchMatchIndex != null)
            {
                jABGetRoleCSVFromElementSearch["MatchIndex"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchMatchIndex);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchSearchFilter != null)
            {
                jABGetRoleCSVFromElementSearch["SearchFilter"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchSearchFilter);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchSortByColumn != null)
            {
                jABGetRoleCSVFromElementSearch["SortByColumn"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchSortByColumn);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchMatchIndexAscending != null)
            {
                jABGetRoleCSVFromElementSearch["MatchIndexAscending"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchMatchIndexAscending);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchCaseSensitiveSearch != null)
            {
                jABGetRoleCSVFromElementSearch["CaseSensitiveSearch"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchCaseSensitiveSearch);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchOnlySearchVisibleElements != null)
            {
                jABGetRoleCSVFromElementSearch["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchOnlySearchVisibleElements);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchOnlySearchShowingElements != null)
            {
                jABGetRoleCSVFromElementSearch["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchOnlySearchShowingElements);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchElementRolesNotToTraverse != null)
            {
                jABGetRoleCSVFromElementSearch["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchElementRolesNotToTraverse);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchMaximumElementsToSearch != null)
            {
                jABGetRoleCSVFromElementSearch["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchMaximumElementsToSearch);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchMaximumChildElementsToSearchPerNode != null)
            {
                jABGetRoleCSVFromElementSearch["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchMaximumChildElementsToSearchPerNode);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchIndentRoleInCSV != null)
            {
                jABGetRoleCSVFromElementSearch["IndentRoleInCSV"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchIndentRoleInCSV);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchIncludeDescriptionInCSV != null)
            {
                jABGetRoleCSVFromElementSearch["IncludeDescriptionInCSV"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchIncludeDescriptionInCSV);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            if (jABGetRoleCSVFromElementSearchIncludeDimensionsInCSV != null)
            {
                jABGetRoleCSVFromElementSearch["IncludeDimensionsInCSV"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchIncludeDimensionsInCSV);
                jABGetRoleCSVFromElementSearchpropCount++;
            }

            jABGetRoleCSVFromElementSearchpropCount++;
            jABGetRoleCSVFromElementSearch["Workflow"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementSearchWorkflow);
            if (jABGetRoleCSVFromElementSearchpropCount > 0)
            {
                callPayload.Body = jABGetRoleCSVFromElementSearch;
            }

            return new ApiConnectionAction<JABGetRoleCSVFromElementSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectjava")]
        public IBodyWorkflowAction<JABGetRoleCSVFromElementHandleResponse> JABGetRoleCSVFromElementHandle(Expression<Func<int>> jABGetRoleCSVFromElementHandleSearchParentElementJABHandle, Expression<Func<string>> jABGetRoleCSVFromElementHandleWorkflow, Expression<Func<bool>> jABGetRoleCSVFromElementHandleSearchSubTree = null, Expression<Func<int>> jABGetRoleCSVFromElementHandleMaxRelativeDepth = null, Expression<Func<bool>> jABGetRoleCSVFromElementHandleOnlySearchVisibleElements = null, Expression<Func<bool>> jABGetRoleCSVFromElementHandleOnlySearchShowingElements = null, Expression<Func<string>> jABGetRoleCSVFromElementHandleElementRolesNotToTraverse = null, Expression<Func<int>> jABGetRoleCSVFromElementHandleMaximumElementsToSearch = null, Expression<Func<int>> jABGetRoleCSVFromElementHandleMaximumChildElementsToSearchPerNode = null, Expression<Func<bool>> jABGetRoleCSVFromElementHandleIndentRoleInCSV = null, Expression<Func<bool>> jABGetRoleCSVFromElementHandleIncludeDescriptionInCSV = null, Expression<Func<bool>> jABGetRoleCSVFromElementHandleIncludeDimensionsInCSV = null)
        {
            var apiCallPath = "/JavaAccessBridge/JABGetRoleCSVFromElementHandle";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var jABGetRoleCSVFromElementHandle = new JObject();
            var jABGetRoleCSVFromElementHandlepropCount = 0;
            jABGetRoleCSVFromElementHandlepropCount++;
            jABGetRoleCSVFromElementHandle["SearchParentElementJABHandle"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandleSearchParentElementJABHandle);
            if (jABGetRoleCSVFromElementHandleSearchSubTree != null)
            {
                jABGetRoleCSVFromElementHandle["SearchSubTree"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandleSearchSubTree);
                jABGetRoleCSVFromElementHandlepropCount++;
            }

            if (jABGetRoleCSVFromElementHandleMaxRelativeDepth != null)
            {
                jABGetRoleCSVFromElementHandle["MaxRelativeDepth"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandleMaxRelativeDepth);
                jABGetRoleCSVFromElementHandlepropCount++;
            }

            if (jABGetRoleCSVFromElementHandleOnlySearchVisibleElements != null)
            {
                jABGetRoleCSVFromElementHandle["OnlySearchVisibleElements"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandleOnlySearchVisibleElements);
                jABGetRoleCSVFromElementHandlepropCount++;
            }

            if (jABGetRoleCSVFromElementHandleOnlySearchShowingElements != null)
            {
                jABGetRoleCSVFromElementHandle["OnlySearchShowingElements"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandleOnlySearchShowingElements);
                jABGetRoleCSVFromElementHandlepropCount++;
            }

            if (jABGetRoleCSVFromElementHandleElementRolesNotToTraverse != null)
            {
                jABGetRoleCSVFromElementHandle["ElementRolesNotToTraverse"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandleElementRolesNotToTraverse);
                jABGetRoleCSVFromElementHandlepropCount++;
            }

            if (jABGetRoleCSVFromElementHandleMaximumElementsToSearch != null)
            {
                jABGetRoleCSVFromElementHandle["MaximumElementsToSearch"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandleMaximumElementsToSearch);
                jABGetRoleCSVFromElementHandlepropCount++;
            }

            if (jABGetRoleCSVFromElementHandleMaximumChildElementsToSearchPerNode != null)
            {
                jABGetRoleCSVFromElementHandle["MaximumChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandleMaximumChildElementsToSearchPerNode);
                jABGetRoleCSVFromElementHandlepropCount++;
            }

            if (jABGetRoleCSVFromElementHandleIndentRoleInCSV != null)
            {
                jABGetRoleCSVFromElementHandle["IndentRoleInCSV"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandleIndentRoleInCSV);
                jABGetRoleCSVFromElementHandlepropCount++;
            }

            if (jABGetRoleCSVFromElementHandleIncludeDescriptionInCSV != null)
            {
                jABGetRoleCSVFromElementHandle["IncludeDescriptionInCSV"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandleIncludeDescriptionInCSV);
                jABGetRoleCSVFromElementHandlepropCount++;
            }

            if (jABGetRoleCSVFromElementHandleIncludeDimensionsInCSV != null)
            {
                jABGetRoleCSVFromElementHandle["IncludeDimensionsInCSV"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandleIncludeDimensionsInCSV);
                jABGetRoleCSVFromElementHandlepropCount++;
            }

            jABGetRoleCSVFromElementHandlepropCount++;
            jABGetRoleCSVFromElementHandle["Workflow"] = ExpressionConverter.ConvertO(jABGetRoleCSVFromElementHandleWorkflow);
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

    public enum jABGlobalLeftMouseClickOnElementOffsetRelativeToInput
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

    public enum jABGlobalRightMouseClickOnElementOffsetRelativeToInput
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

    public enum jABGlobalMiddleMouseClickOnElementOffsetRelativeToInput
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

    public enum jABGlobalDoubleLeftMouseClickOnElementOffsetRelativeToInput
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

    public enum jABGlobalMouseClickOnTableCellOffsetRelativeToInput
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