//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectmainframe
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectmainframeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPISetHLLAPIDLL(Expression<Func<string>> hLLAPISetHLLAPIDLLDLLFilename, Expression<Func<string>> hLLAPISetHLLAPIDLLWorkflow, Expression<Func<string>> hLLAPISetHLLAPIDLLIAHLLAPIPath = null, Expression<Func<string>> hLLAPISetHLLAPIDLLEntryPointName = null, Expression<Func<bool>> hLLAPISetHLLAPIDLLIsEnhancedInterface = null, Expression<Func<bool>> hLLAPISetHLLAPIDLLIs64BitHLLAPIDLL = null, Expression<Func<bool>> hLLAPISetHLLAPIDLLUseCOMFor64BitHLLAPIDLL = null)
        {
            var apiCallPath = "/HLLAPI/HLLAPISetHLLAPIDLL";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPISetHLLAPIDLL = new JObject();
            var hLLAPISetHLLAPIDLLpropCount = 0;
            hLLAPISetHLLAPIDLLpropCount++;
            hLLAPISetHLLAPIDLL["DLLFilename"] = ExpressionConverter.ConvertO(hLLAPISetHLLAPIDLLDLLFilename);
            if (hLLAPISetHLLAPIDLLIAHLLAPIPath != null)
            {
                hLLAPISetHLLAPIDLL["IAHLLAPIPath"] = ExpressionConverter.ConvertO(hLLAPISetHLLAPIDLLIAHLLAPIPath);
                hLLAPISetHLLAPIDLLpropCount++;
            }

            if (hLLAPISetHLLAPIDLLEntryPointName != null)
            {
                hLLAPISetHLLAPIDLL["EntryPointName"] = ExpressionConverter.ConvertO(hLLAPISetHLLAPIDLLEntryPointName);
                hLLAPISetHLLAPIDLLpropCount++;
            }

            if (hLLAPISetHLLAPIDLLIsEnhancedInterface != null)
            {
                hLLAPISetHLLAPIDLL["IsEnhancedInterface"] = ExpressionConverter.ConvertO(hLLAPISetHLLAPIDLLIsEnhancedInterface);
                hLLAPISetHLLAPIDLLpropCount++;
            }

            if (hLLAPISetHLLAPIDLLIs64BitHLLAPIDLL != null)
            {
                hLLAPISetHLLAPIDLL["Is64BitHLLAPIDLL"] = ExpressionConverter.ConvertO(hLLAPISetHLLAPIDLLIs64BitHLLAPIDLL);
                hLLAPISetHLLAPIDLLpropCount++;
            }

            if (hLLAPISetHLLAPIDLLUseCOMFor64BitHLLAPIDLL != null)
            {
                hLLAPISetHLLAPIDLL["UseCOMFor64BitHLLAPIDLL"] = ExpressionConverter.ConvertO(hLLAPISetHLLAPIDLLUseCOMFor64BitHLLAPIDLL);
                hLLAPISetHLLAPIDLLpropCount++;
            }

            hLLAPISetHLLAPIDLLpropCount++;
            hLLAPISetHLLAPIDLL["Workflow"] = ExpressionConverter.ConvertO(hLLAPISetHLLAPIDLLWorkflow);
            if (hLLAPISetHLLAPIDLLpropCount > 0)
            {
                callPayload.Body = hLLAPISetHLLAPIDLL;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPIDispose(Expression<Func<string>> hLLAPIDisposeWorkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPIDispose";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIDispose = new JObject();
            var hLLAPIDisposepropCount = 0;
            hLLAPIDisposepropCount++;
            hLLAPIDispose["Workflow"] = ExpressionConverter.ConvertO(hLLAPIDisposeWorkflow);
            if (hLLAPIDisposepropCount > 0)
            {
                callPayload.Body = hLLAPIDispose;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPIConnect(Expression<Func<string>> hLLAPIConnectSessionID, Expression<Func<string>> hLLAPIConnectWorkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPIConnect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIConnect = new JObject();
            var hLLAPIConnectpropCount = 0;
            hLLAPIConnectpropCount++;
            hLLAPIConnect["SessionID"] = ExpressionConverter.ConvertO(hLLAPIConnectSessionID);
            hLLAPIConnectpropCount++;
            hLLAPIConnect["Workflow"] = ExpressionConverter.ConvertO(hLLAPIConnectWorkflow);
            if (hLLAPIConnectpropCount > 0)
            {
                callPayload.Body = hLLAPIConnect;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIGetConnectStatusResponse> HLLAPIGetConnectStatus(Expression<Func<string>> hLLAPIGetConnectStatusSessionID, Expression<Func<string>> hLLAPIGetConnectStatusWorkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPIGetConnectStatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIGetConnectStatus = new JObject();
            var hLLAPIGetConnectStatuspropCount = 0;
            hLLAPIGetConnectStatuspropCount++;
            hLLAPIGetConnectStatus["SessionID"] = ExpressionConverter.ConvertO(hLLAPIGetConnectStatusSessionID);
            hLLAPIGetConnectStatuspropCount++;
            hLLAPIGetConnectStatus["Workflow"] = ExpressionConverter.ConvertO(hLLAPIGetConnectStatusWorkflow);
            if (hLLAPIGetConnectStatuspropCount > 0)
            {
                callPayload.Body = hLLAPIGetConnectStatus;
            }

            return new ApiConnectionAction<HLLAPIGetConnectStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPIDisconnect(Expression<Func<string>> hLLAPIDisconnectSessionID, Expression<Func<string>> hLLAPIDisconnectWorkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPIDisconnect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIDisconnect = new JObject();
            var hLLAPIDisconnectpropCount = 0;
            hLLAPIDisconnectpropCount++;
            hLLAPIDisconnect["SessionID"] = ExpressionConverter.ConvertO(hLLAPIDisconnectSessionID);
            hLLAPIDisconnectpropCount++;
            hLLAPIDisconnect["Workflow"] = ExpressionConverter.ConvertO(hLLAPIDisconnectWorkflow);
            if (hLLAPIDisconnectpropCount > 0)
            {
                callPayload.Body = hLLAPIDisconnect;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPISetCursorPos(Expression<Func<string>> hLLAPISetCursorPosSessionID, Expression<Func<int>> hLLAPISetCursorPosCursorRowIndex, Expression<Func<int>> hLLAPISetCursorPosCursorColIndex, Expression<Func<string>> hLLAPISetCursorPosWorkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPISetCursorPos";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPISetCursorPos = new JObject();
            var hLLAPISetCursorPospropCount = 0;
            hLLAPISetCursorPospropCount++;
            hLLAPISetCursorPos["SessionID"] = ExpressionConverter.ConvertO(hLLAPISetCursorPosSessionID);
            hLLAPISetCursorPospropCount++;
            hLLAPISetCursorPos["CursorRowIndex"] = ExpressionConverter.ConvertO(hLLAPISetCursorPosCursorRowIndex);
            hLLAPISetCursorPospropCount++;
            hLLAPISetCursorPos["CursorColIndex"] = ExpressionConverter.ConvertO(hLLAPISetCursorPosCursorColIndex);
            hLLAPISetCursorPospropCount++;
            hLLAPISetCursorPos["Workflow"] = ExpressionConverter.ConvertO(hLLAPISetCursorPosWorkflow);
            if (hLLAPISetCursorPospropCount > 0)
            {
                callPayload.Body = hLLAPISetCursorPos;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIGetCursorPosResponse> HLLAPIGetCursorPos(Expression<Func<string>> hLLAPIGetCursorPosSessionID, Expression<Func<string>> hLLAPIGetCursorPosWorkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPIGetCursorPos";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIGetCursorPos = new JObject();
            var hLLAPIGetCursorPospropCount = 0;
            hLLAPIGetCursorPospropCount++;
            hLLAPIGetCursorPos["SessionID"] = ExpressionConverter.ConvertO(hLLAPIGetCursorPosSessionID);
            hLLAPIGetCursorPospropCount++;
            hLLAPIGetCursorPos["Workflow"] = ExpressionConverter.ConvertO(hLLAPIGetCursorPosWorkflow);
            if (hLLAPIGetCursorPospropCount > 0)
            {
                callPayload.Body = hLLAPIGetCursorPos;
            }

            return new ApiConnectionAction<HLLAPIGetCursorPosResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPISendString(Expression<Func<string>> hLLAPISendStringInputString, Expression<Func<string>> hLLAPISendStringWorkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPISendString";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPISendString = new JObject();
            var hLLAPISendStringpropCount = 0;
            hLLAPISendStringpropCount++;
            hLLAPISendString["InputString"] = ExpressionConverter.ConvertO(hLLAPISendStringInputString);
            hLLAPISendStringpropCount++;
            hLLAPISendString["Workflow"] = ExpressionConverter.ConvertO(hLLAPISendStringWorkflow);
            if (hLLAPISendStringpropCount > 0)
            {
                callPayload.Body = hLLAPISendString;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPISendPassword(Expression<Func<string>> hLLAPISendPasswordInputPassword, Expression<Func<string>> hLLAPISendPasswordWorkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPISendPassword";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPISendPassword = new JObject();
            var hLLAPISendPasswordpropCount = 0;
            hLLAPISendPasswordpropCount++;
            hLLAPISendPassword["InputPassword"] = ExpressionConverter.ConvertO(hLLAPISendPasswordInputPassword);
            hLLAPISendPasswordpropCount++;
            hLLAPISendPassword["Workflow"] = ExpressionConverter.ConvertO(hLLAPISendPasswordWorkflow);
            if (hLLAPISendPasswordpropCount > 0)
            {
                callPayload.Body = hLLAPISendPassword;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPISendStringAtCursorPos(Expression<Func<string>> hLLAPISendStringAtCursorPosSessionID, Expression<Func<int>> hLLAPISendStringAtCursorPosCursorRowIndex, Expression<Func<int>> hLLAPISendStringAtCursorPosCursorColIndex, Expression<Func<string>> hLLAPISendStringAtCursorPosInputString, Expression<Func<string>> hLLAPISendStringAtCursorPosWorkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPISendStringAtCursorPos";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPISendStringAtCursorPos = new JObject();
            var hLLAPISendStringAtCursorPospropCount = 0;
            hLLAPISendStringAtCursorPospropCount++;
            hLLAPISendStringAtCursorPos["SessionID"] = ExpressionConverter.ConvertO(hLLAPISendStringAtCursorPosSessionID);
            hLLAPISendStringAtCursorPospropCount++;
            hLLAPISendStringAtCursorPos["CursorRowIndex"] = ExpressionConverter.ConvertO(hLLAPISendStringAtCursorPosCursorRowIndex);
            hLLAPISendStringAtCursorPospropCount++;
            hLLAPISendStringAtCursorPos["CursorColIndex"] = ExpressionConverter.ConvertO(hLLAPISendStringAtCursorPosCursorColIndex);
            hLLAPISendStringAtCursorPospropCount++;
            hLLAPISendStringAtCursorPos["InputString"] = ExpressionConverter.ConvertO(hLLAPISendStringAtCursorPosInputString);
            hLLAPISendStringAtCursorPospropCount++;
            hLLAPISendStringAtCursorPos["Workflow"] = ExpressionConverter.ConvertO(hLLAPISendStringAtCursorPosWorkflow);
            if (hLLAPISendStringAtCursorPospropCount > 0)
            {
                callPayload.Body = hLLAPISendStringAtCursorPos;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPISendPasswordAtCursorPos(Expression<Func<string>> hLLAPISendPasswordAtCursorPosSessionID, Expression<Func<int>> hLLAPISendPasswordAtCursorPosCursorRowIndex, Expression<Func<int>> hLLAPISendPasswordAtCursorPosCursorColIndex, Expression<Func<string>> hLLAPISendPasswordAtCursorPosInputPassword, Expression<Func<string>> hLLAPISendPasswordAtCursorPosWorkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPISendPasswordAtCursorPos";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPISendPasswordAtCursorPos = new JObject();
            var hLLAPISendPasswordAtCursorPospropCount = 0;
            hLLAPISendPasswordAtCursorPospropCount++;
            hLLAPISendPasswordAtCursorPos["SessionID"] = ExpressionConverter.ConvertO(hLLAPISendPasswordAtCursorPosSessionID);
            hLLAPISendPasswordAtCursorPospropCount++;
            hLLAPISendPasswordAtCursorPos["CursorRowIndex"] = ExpressionConverter.ConvertO(hLLAPISendPasswordAtCursorPosCursorRowIndex);
            hLLAPISendPasswordAtCursorPospropCount++;
            hLLAPISendPasswordAtCursorPos["CursorColIndex"] = ExpressionConverter.ConvertO(hLLAPISendPasswordAtCursorPosCursorColIndex);
            hLLAPISendPasswordAtCursorPospropCount++;
            hLLAPISendPasswordAtCursorPos["InputPassword"] = ExpressionConverter.ConvertO(hLLAPISendPasswordAtCursorPosInputPassword);
            hLLAPISendPasswordAtCursorPospropCount++;
            hLLAPISendPasswordAtCursorPos["Workflow"] = ExpressionConverter.ConvertO(hLLAPISendPasswordAtCursorPosWorkflow);
            if (hLLAPISendPasswordAtCursorPospropCount > 0)
            {
                callPayload.Body = hLLAPISendPasswordAtCursorPos;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIReadScreenAtCursorPosResponse> HLLAPIReadScreenAtCursorPos(Expression<Func<string>> hLLAPIReadScreenAtCursorPosSessionID, Expression<Func<int>> hLLAPIReadScreenAtCursorPosCursorRowIndex, Expression<Func<int>> hLLAPIReadScreenAtCursorPosCursorColIndex, Expression<Func<int>> hLLAPIReadScreenAtCursorPosReadScreenLength, Expression<Func<string>> hLLAPIReadScreenAtCursorPosWorkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPIReadScreenAtCursorPos";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIReadScreenAtCursorPos = new JObject();
            var hLLAPIReadScreenAtCursorPospropCount = 0;
            hLLAPIReadScreenAtCursorPospropCount++;
            hLLAPIReadScreenAtCursorPos["SessionID"] = ExpressionConverter.ConvertO(hLLAPIReadScreenAtCursorPosSessionID);
            hLLAPIReadScreenAtCursorPospropCount++;
            hLLAPIReadScreenAtCursorPos["CursorRowIndex"] = ExpressionConverter.ConvertO(hLLAPIReadScreenAtCursorPosCursorRowIndex);
            hLLAPIReadScreenAtCursorPospropCount++;
            hLLAPIReadScreenAtCursorPos["CursorColIndex"] = ExpressionConverter.ConvertO(hLLAPIReadScreenAtCursorPosCursorColIndex);
            hLLAPIReadScreenAtCursorPospropCount++;
            hLLAPIReadScreenAtCursorPos["ReadScreenLength"] = ExpressionConverter.ConvertO(hLLAPIReadScreenAtCursorPosReadScreenLength);
            hLLAPIReadScreenAtCursorPospropCount++;
            hLLAPIReadScreenAtCursorPos["Workflow"] = ExpressionConverter.ConvertO(hLLAPIReadScreenAtCursorPosWorkflow);
            if (hLLAPIReadScreenAtCursorPospropCount > 0)
            {
                callPayload.Body = hLLAPIReadScreenAtCursorPos;
            }

            return new ApiConnectionAction<HLLAPIReadScreenAtCursorPosResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIQuerySessionStatusResponse> HLLAPIQuerySessionStatus(Expression<Func<string>> hLLAPIQuerySessionStatusWorkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPIQuerySessionStatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIQuerySessionStatus = new JObject();
            var hLLAPIQuerySessionStatuspropCount = 0;
            hLLAPIQuerySessionStatuspropCount++;
            hLLAPIQuerySessionStatus["Workflow"] = ExpressionConverter.ConvertO(hLLAPIQuerySessionStatusWorkflow);
            if (hLLAPIQuerySessionStatuspropCount > 0)
            {
                callPayload.Body = hLLAPIQuerySessionStatus;
            }

            return new ApiConnectionAction<HLLAPIQuerySessionStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIReadScreenRowsResponse> HLLAPIReadScreenRows(Expression<Func<string>> hLLAPIReadScreenRowsSessionID, Expression<Func<int>> hLLAPIReadScreenRowsStartRowIndex, Expression<Func<int>> hLLAPIReadScreenRowsEndRowIndex, Expression<Func<string>> hLLAPIReadScreenRowsWorkflow, Expression<Func<int>> hLLAPIReadScreenRowsNumberOfRowsInSession = null, Expression<Func<int>> hLLAPIReadScreenRowsNumberOfColumnsInSession = null)
        {
            var apiCallPath = "/HLLAPI/HLLAPIReadScreenRows";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIReadScreenRows = new JObject();
            var hLLAPIReadScreenRowspropCount = 0;
            hLLAPIReadScreenRowspropCount++;
            hLLAPIReadScreenRows["SessionID"] = ExpressionConverter.ConvertO(hLLAPIReadScreenRowsSessionID);
            hLLAPIReadScreenRowspropCount++;
            hLLAPIReadScreenRows["StartRowIndex"] = ExpressionConverter.ConvertO(hLLAPIReadScreenRowsStartRowIndex);
            hLLAPIReadScreenRowspropCount++;
            hLLAPIReadScreenRows["EndRowIndex"] = ExpressionConverter.ConvertO(hLLAPIReadScreenRowsEndRowIndex);
            if (hLLAPIReadScreenRowsNumberOfRowsInSession != null)
            {
                hLLAPIReadScreenRows["NumberOfRowsInSession"] = ExpressionConverter.ConvertO(hLLAPIReadScreenRowsNumberOfRowsInSession);
                hLLAPIReadScreenRowspropCount++;
            }

            if (hLLAPIReadScreenRowsNumberOfColumnsInSession != null)
            {
                hLLAPIReadScreenRows["NumberOfColumnsInSession"] = ExpressionConverter.ConvertO(hLLAPIReadScreenRowsNumberOfColumnsInSession);
                hLLAPIReadScreenRowspropCount++;
            }

            hLLAPIReadScreenRowspropCount++;
            hLLAPIReadScreenRows["Workflow"] = ExpressionConverter.ConvertO(hLLAPIReadScreenRowsWorkflow);
            if (hLLAPIReadScreenRowspropCount > 0)
            {
                callPayload.Body = hLLAPIReadScreenRows;
            }

            return new ApiConnectionAction<HLLAPIReadScreenRowsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIIsKeyboardUnlockedResponse> HLLAPIIsKeyboardUnlocked(Expression<Func<string>> hLLAPIIsKeyboardUnlockedWorkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPIIsKeyboardUnlocked";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIIsKeyboardUnlocked = new JObject();
            var hLLAPIIsKeyboardUnlockedpropCount = 0;
            hLLAPIIsKeyboardUnlockedpropCount++;
            hLLAPIIsKeyboardUnlocked["Workflow"] = ExpressionConverter.ConvertO(hLLAPIIsKeyboardUnlockedWorkflow);
            if (hLLAPIIsKeyboardUnlockedpropCount > 0)
            {
                callPayload.Body = hLLAPIIsKeyboardUnlocked;
            }

            return new ApiConnectionAction<HLLAPIIsKeyboardUnlockedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIWaitForKeyboardUnlockedResponse> HLLAPIWaitForKeyboardUnlocked(Expression<Func<double>> hLLAPIWaitForKeyboardUnlockedSecondsToWait, Expression<Func<string>> hLLAPIWaitForKeyboardUnlockedWorkflow, Expression<Func<double>> hLLAPIWaitForKeyboardUnlockedDeltaSecondsToWait = null)
        {
            var apiCallPath = "/HLLAPI/HLLAPIWaitForKeyboardUnlocked";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIWaitForKeyboardUnlocked = new JObject();
            var hLLAPIWaitForKeyboardUnlockedpropCount = 0;
            hLLAPIWaitForKeyboardUnlockedpropCount++;
            hLLAPIWaitForKeyboardUnlocked["SecondsToWait"] = ExpressionConverter.ConvertO(hLLAPIWaitForKeyboardUnlockedSecondsToWait);
            if (hLLAPIWaitForKeyboardUnlockedDeltaSecondsToWait != null)
            {
                hLLAPIWaitForKeyboardUnlocked["DeltaSecondsToWait"] = ExpressionConverter.ConvertO(hLLAPIWaitForKeyboardUnlockedDeltaSecondsToWait);
                hLLAPIWaitForKeyboardUnlockedpropCount++;
            }

            hLLAPIWaitForKeyboardUnlockedpropCount++;
            hLLAPIWaitForKeyboardUnlocked["Workflow"] = ExpressionConverter.ConvertO(hLLAPIWaitForKeyboardUnlockedWorkflow);
            if (hLLAPIWaitForKeyboardUnlockedpropCount > 0)
            {
                callPayload.Body = hLLAPIWaitForKeyboardUnlocked;
            }

            return new ApiConnectionAction<HLLAPIWaitForKeyboardUnlockedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIWaitForSystemReadyResponse> HLLAPIWaitForSystemReady(Expression<Func<double>> hLLAPIWaitForSystemReadySecondsToWait, Expression<Func<string>> hLLAPIWaitForSystemReadyWorkflow, Expression<Func<double>> hLLAPIWaitForSystemReadyDeltaSecondsToWait = null)
        {
            var apiCallPath = "/HLLAPI/HLLAPIWaitForSystemReady";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIWaitForSystemReady = new JObject();
            var hLLAPIWaitForSystemReadypropCount = 0;
            hLLAPIWaitForSystemReadypropCount++;
            hLLAPIWaitForSystemReady["SecondsToWait"] = ExpressionConverter.ConvertO(hLLAPIWaitForSystemReadySecondsToWait);
            if (hLLAPIWaitForSystemReadyDeltaSecondsToWait != null)
            {
                hLLAPIWaitForSystemReady["DeltaSecondsToWait"] = ExpressionConverter.ConvertO(hLLAPIWaitForSystemReadyDeltaSecondsToWait);
                hLLAPIWaitForSystemReadypropCount++;
            }

            hLLAPIWaitForSystemReadypropCount++;
            hLLAPIWaitForSystemReady["Workflow"] = ExpressionConverter.ConvertO(hLLAPIWaitForSystemReadyWorkflow);
            if (hLLAPIWaitForSystemReadypropCount > 0)
            {
                callPayload.Body = hLLAPIWaitForSystemReady;
            }

            return new ApiConnectionAction<HLLAPIWaitForSystemReadyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPIPressReset(Expression<Func<string>> hLLAPIPressResetWorkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPIPressReset";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIPressReset = new JObject();
            var hLLAPIPressResetpropCount = 0;
            hLLAPIPressResetpropCount++;
            hLLAPIPressReset["Workflow"] = ExpressionConverter.ConvertO(hLLAPIPressResetWorkflow);
            if (hLLAPIPressResetpropCount > 0)
            {
                callPayload.Body = hLLAPIPressReset;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPISearchForStringResponse> HLLAPISearchForString(Expression<Func<string>> hLLAPISearchForStringSessionID, Expression<Func<string>> hLLAPISearchForStringSearchString, Expression<Func<string>> hLLAPISearchForStringWorkflow, Expression<Func<bool>> hLLAPISearchForStringSearchEntireScreen = null, Expression<Func<int>> hLLAPISearchForStringSearchStartRowIndex = null, Expression<Func<int>> hLLAPISearchForStringSearchStartColIndex = null)
        {
            var apiCallPath = "/HLLAPI/HLLAPISearchForString";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPISearchForString = new JObject();
            var hLLAPISearchForStringpropCount = 0;
            hLLAPISearchForStringpropCount++;
            hLLAPISearchForString["SessionID"] = ExpressionConverter.ConvertO(hLLAPISearchForStringSessionID);
            hLLAPISearchForStringpropCount++;
            hLLAPISearchForString["SearchString"] = ExpressionConverter.ConvertO(hLLAPISearchForStringSearchString);
            if (hLLAPISearchForStringSearchEntireScreen != null)
            {
                hLLAPISearchForString["SearchEntireScreen"] = ExpressionConverter.ConvertO(hLLAPISearchForStringSearchEntireScreen);
                hLLAPISearchForStringpropCount++;
            }

            if (hLLAPISearchForStringSearchStartRowIndex != null)
            {
                hLLAPISearchForString["SearchStartRowIndex"] = ExpressionConverter.ConvertO(hLLAPISearchForStringSearchStartRowIndex);
                hLLAPISearchForStringpropCount++;
            }

            if (hLLAPISearchForStringSearchStartColIndex != null)
            {
                hLLAPISearchForString["SearchStartColIndex"] = ExpressionConverter.ConvertO(hLLAPISearchForStringSearchStartColIndex);
                hLLAPISearchForStringpropCount++;
            }

            hLLAPISearchForStringpropCount++;
            hLLAPISearchForString["Workflow"] = ExpressionConverter.ConvertO(hLLAPISearchForStringWorkflow);
            if (hLLAPISearchForStringpropCount > 0)
            {
                callPayload.Body = hLLAPISearchForString;
            }

            return new ApiConnectionAction<HLLAPISearchForStringResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIWaitForStringResponse> HLLAPIWaitForString(Expression<Func<string>> hLLAPIWaitForStringSessionID, Expression<Func<string>> hLLAPIWaitForStringSearchString, Expression<Func<double>> hLLAPIWaitForStringSecondsToWait, Expression<Func<string>> hLLAPIWaitForStringWorkflow, Expression<Func<bool>> hLLAPIWaitForStringSearchEntireScreen = null, Expression<Func<int>> hLLAPIWaitForStringSearchStartRowIndex = null, Expression<Func<int>> hLLAPIWaitForStringSearchStartColIndex = null, Expression<Func<double>> hLLAPIWaitForStringDeltaSecondsToWait = null)
        {
            var apiCallPath = "/HLLAPI/HLLAPIWaitForString";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIWaitForString = new JObject();
            var hLLAPIWaitForStringpropCount = 0;
            hLLAPIWaitForStringpropCount++;
            hLLAPIWaitForString["SessionID"] = ExpressionConverter.ConvertO(hLLAPIWaitForStringSessionID);
            hLLAPIWaitForStringpropCount++;
            hLLAPIWaitForString["SearchString"] = ExpressionConverter.ConvertO(hLLAPIWaitForStringSearchString);
            if (hLLAPIWaitForStringSearchEntireScreen != null)
            {
                hLLAPIWaitForString["SearchEntireScreen"] = ExpressionConverter.ConvertO(hLLAPIWaitForStringSearchEntireScreen);
                hLLAPIWaitForStringpropCount++;
            }

            if (hLLAPIWaitForStringSearchStartRowIndex != null)
            {
                hLLAPIWaitForString["SearchStartRowIndex"] = ExpressionConverter.ConvertO(hLLAPIWaitForStringSearchStartRowIndex);
                hLLAPIWaitForStringpropCount++;
            }

            if (hLLAPIWaitForStringSearchStartColIndex != null)
            {
                hLLAPIWaitForString["SearchStartColIndex"] = ExpressionConverter.ConvertO(hLLAPIWaitForStringSearchStartColIndex);
                hLLAPIWaitForStringpropCount++;
            }

            hLLAPIWaitForStringpropCount++;
            hLLAPIWaitForString["SecondsToWait"] = ExpressionConverter.ConvertO(hLLAPIWaitForStringSecondsToWait);
            if (hLLAPIWaitForStringDeltaSecondsToWait != null)
            {
                hLLAPIWaitForString["DeltaSecondsToWait"] = ExpressionConverter.ConvertO(hLLAPIWaitForStringDeltaSecondsToWait);
                hLLAPIWaitForStringpropCount++;
            }

            hLLAPIWaitForStringpropCount++;
            hLLAPIWaitForString["Workflow"] = ExpressionConverter.ConvertO(hLLAPIWaitForStringWorkflow);
            if (hLLAPIWaitForStringpropCount > 0)
            {
                callPayload.Body = hLLAPIWaitForString;
            }

            return new ApiConnectionAction<HLLAPIWaitForStringResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPISetSessionParameter(Expression<Func<string>> hLLAPISetSessionParameterParameter, Expression<Func<string>> hLLAPISetSessionParameterWorkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPISetSessionParameter";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPISetSessionParameter = new JObject();
            var hLLAPISetSessionParameterpropCount = 0;
            hLLAPISetSessionParameterpropCount++;
            hLLAPISetSessionParameter["Parameter"] = ExpressionConverter.ConvertO(hLLAPISetSessionParameterParameter);
            hLLAPISetSessionParameterpropCount++;
            hLLAPISetSessionParameter["Workflow"] = ExpressionConverter.ConvertO(hLLAPISetSessionParameterWorkflow);
            if (hLLAPISetSessionParameterpropCount > 0)
            {
                callPayload.Body = hLLAPISetSessionParameter;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPIResetSystem(Expression<Func<string>> hLLAPIResetSystemWorkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPIResetSystem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIResetSystem = new JObject();
            var hLLAPIResetSystempropCount = 0;
            hLLAPIResetSystempropCount++;
            hLLAPIResetSystem["Workflow"] = ExpressionConverter.ConvertO(hLLAPIResetSystemWorkflow);
            if (hLLAPIResetSystempropCount > 0)
            {
                callPayload.Body = hLLAPIResetSystem;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPICopyOperatorInformationAreaResponse> HLLAPICopyOperatorInformationArea(Expression<Func<string>> hLLAPICopyOperatorInformationAreaWorkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPICopyOperatorInformationArea";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPICopyOperatorInformationArea = new JObject();
            var hLLAPICopyOperatorInformationAreapropCount = 0;
            hLLAPICopyOperatorInformationAreapropCount++;
            hLLAPICopyOperatorInformationArea["Workflow"] = ExpressionConverter.ConvertO(hLLAPICopyOperatorInformationAreaWorkflow);
            if (hLLAPICopyOperatorInformationAreapropCount > 0)
            {
                callPayload.Body = hLLAPICopyOperatorInformationArea;
            }

            return new ApiConnectionAction<HLLAPICopyOperatorInformationAreaResponse>(callPayload);
        }
    }

    public class IaconnectmainframeTriggers([ConnectionName] string connectionId)
    {
    }

    public class HLLAPIGetConnectStatusResponse
    {
        public bool ConnectedToSession { get; set; }
        public bool SystemBusy { get; set; }
        public bool KeyboardLocked { get; set; }
        public bool SessionInUseByAnotherHLLAPIApplication { get; set; }
        public int HLLAPIThreadID { get; set; }
        public int COMThreadID { get; set; }
        public int CallCount { get; set; }
    }

    public class HLLAPIGetCursorPosResponse
    {
        public int CursorRowIndex { get; set; }
        public int CursorColIndex { get; set; }
        public int CursorPos { get; set; }
    }

    public class HLLAPIReadScreenAtCursorPosResponse
    {
        public string ScreenContents { get; set; }
    }

    public class HLLAPIQuerySessionStatusResponse
    {
        public string SessionLongName { get; set; }
        public string SessionType { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfCols { get; set; }
        public int CodePage { get; set; }
    }

    public class HLLAPIReadScreenRowsResponse
    {
        public string ScreenRowsJSON { get; set; }
    }

    public class HLLAPIIsKeyboardUnlockedResponse
    {
        public bool KeyBoardIsUnlocked { get; set; }
    }

    public class HLLAPIWaitForKeyboardUnlockedResponse
    {
        public bool KeyBoardIsUnlocked { get; set; }
    }

    public class HLLAPIWaitForSystemReadyResponse
    {
        public bool SystemReady { get; set; }
    }

    public class HLLAPISearchForStringResponse
    {
        public bool StringFound { get; set; }
        public int StringFoundPosition { get; set; }
        public int StringFoundRowIndex { get; set; }
        public int StringFoundColIndex { get; set; }
    }

    public class HLLAPIWaitForStringResponse
    {
        public bool StringFound { get; set; }
        public int StringFoundPosition { get; set; }
        public int StringFoundRowIndex { get; set; }
        public int StringFoundColIndex { get; set; }
    }

    public class HLLAPICopyOperatorInformationAreaResponse
    {
        public string OIAFormat { get; set; }
        public bool SystemWait { get; set; }
        public bool CAPS { get; set; }
        public bool ShiftKey { get; set; }
        public bool SubsystemReady { get; set; }
        public bool InsertMode { get; set; }
        public bool InvalidInput { get; set; }
        public string InputType { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectmainframe;

    public partial class WorkflowManagedActions
    {
        public IaconnectmainframeActions Iaconnectmainframe(string connectionId) => new IaconnectmainframeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IaconnectmainframeTriggers Iaconnectmainframe(string connectionId) => new IaconnectmainframeTriggers(connectionId);
    }
}