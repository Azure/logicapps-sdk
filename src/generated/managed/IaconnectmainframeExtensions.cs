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
        public IWorkflowAction HLLAPISetHLLAPIDLL(Expression<Func<string>> hLLAPISetHLLAPIDLLdLLFilename, Expression<Func<string>> hLLAPISetHLLAPIDLLworkflow, Expression<Func<string>> hLLAPISetHLLAPIDLLiAHLLAPIPath = null, Expression<Func<string>> hLLAPISetHLLAPIDLLentryPointName = null, Expression<Func<bool>> hLLAPISetHLLAPIDLLisEnhancedInterface = null, Expression<Func<bool>> hLLAPISetHLLAPIDLLis64BitHLLAPIDLL = null, Expression<Func<bool>> hLLAPISetHLLAPIDLLuseCOMFor64BitHLLAPIDLL = null)
        {
            var apiCallPath = "/HLLAPI/HLLAPISetHLLAPIDLL";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPISetHLLAPIDLL = new JObject();
            var hLLAPISetHLLAPIDLLpropCount = 0;
            hLLAPISetHLLAPIDLLpropCount++;
            hLLAPISetHLLAPIDLL["DLLFilename"] = CSharpExpressionConverter.ConvertToken(hLLAPISetHLLAPIDLLdLLFilename);
            if (hLLAPISetHLLAPIDLLiAHLLAPIPath != null)
            {
                hLLAPISetHLLAPIDLL["IAHLLAPIPath"] = CSharpExpressionConverter.ConvertToken(hLLAPISetHLLAPIDLLiAHLLAPIPath);
                hLLAPISetHLLAPIDLLpropCount++;
            }

            if (hLLAPISetHLLAPIDLLentryPointName != null)
            {
                hLLAPISetHLLAPIDLL["EntryPointName"] = CSharpExpressionConverter.ConvertToken(hLLAPISetHLLAPIDLLentryPointName);
                hLLAPISetHLLAPIDLLpropCount++;
            }

            if (hLLAPISetHLLAPIDLLisEnhancedInterface != null)
            {
                if (hLLAPISetHLLAPIDLLisEnhancedInterface != null)
                {
                    hLLAPISetHLLAPIDLL["IsEnhancedInterface"] = CSharpExpressionConverter.ConvertToken(hLLAPISetHLLAPIDLLisEnhancedInterface);
                    hLLAPISetHLLAPIDLLpropCount++;
                }

                hLLAPISetHLLAPIDLLpropCount++;
            }
            else
            {
                hLLAPISetHLLAPIDLL["IsEnhancedInterface"] = false;
                hLLAPISetHLLAPIDLLpropCount++;
            }

            if (hLLAPISetHLLAPIDLLis64BitHLLAPIDLL != null)
            {
                if (hLLAPISetHLLAPIDLLis64BitHLLAPIDLL != null)
                {
                    hLLAPISetHLLAPIDLL["Is64BitHLLAPIDLL"] = CSharpExpressionConverter.ConvertToken(hLLAPISetHLLAPIDLLis64BitHLLAPIDLL);
                    hLLAPISetHLLAPIDLLpropCount++;
                }

                hLLAPISetHLLAPIDLLpropCount++;
            }
            else
            {
                hLLAPISetHLLAPIDLL["Is64BitHLLAPIDLL"] = false;
                hLLAPISetHLLAPIDLLpropCount++;
            }

            if (hLLAPISetHLLAPIDLLuseCOMFor64BitHLLAPIDLL != null)
            {
                if (hLLAPISetHLLAPIDLLuseCOMFor64BitHLLAPIDLL != null)
                {
                    hLLAPISetHLLAPIDLL["UseCOMFor64BitHLLAPIDLL"] = CSharpExpressionConverter.ConvertToken(hLLAPISetHLLAPIDLLuseCOMFor64BitHLLAPIDLL);
                    hLLAPISetHLLAPIDLLpropCount++;
                }

                hLLAPISetHLLAPIDLLpropCount++;
            }
            else
            {
                hLLAPISetHLLAPIDLL["UseCOMFor64BitHLLAPIDLL"] = false;
                hLLAPISetHLLAPIDLLpropCount++;
            }

            hLLAPISetHLLAPIDLLpropCount++;
            hLLAPISetHLLAPIDLL["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPISetHLLAPIDLLworkflow);
            if (hLLAPISetHLLAPIDLLpropCount > 0)
            {
                callPayload.Body = hLLAPISetHLLAPIDLL;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPIDispose(Expression<Func<string>> hLLAPIDisposeworkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPIDispose";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIDispose = new JObject();
            var hLLAPIDisposepropCount = 0;
            hLLAPIDisposepropCount++;
            hLLAPIDispose["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPIDisposeworkflow);
            if (hLLAPIDisposepropCount > 0)
            {
                callPayload.Body = hLLAPIDispose;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPIConnect(Expression<Func<string>> hLLAPIConnectsessionID, Expression<Func<string>> hLLAPIConnectworkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPIConnect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIConnect = new JObject();
            var hLLAPIConnectpropCount = 0;
            hLLAPIConnectpropCount++;
            hLLAPIConnect["SessionID"] = CSharpExpressionConverter.ConvertToken(hLLAPIConnectsessionID);
            hLLAPIConnectpropCount++;
            hLLAPIConnect["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPIConnectworkflow);
            if (hLLAPIConnectpropCount > 0)
            {
                callPayload.Body = hLLAPIConnect;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIGetConnectStatusResponse> HLLAPIGetConnectStatus(Expression<Func<string>> hLLAPIGetConnectStatussessionID, Expression<Func<string>> hLLAPIGetConnectStatusworkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPIGetConnectStatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIGetConnectStatus = new JObject();
            var hLLAPIGetConnectStatuspropCount = 0;
            hLLAPIGetConnectStatuspropCount++;
            hLLAPIGetConnectStatus["SessionID"] = CSharpExpressionConverter.ConvertToken(hLLAPIGetConnectStatussessionID);
            hLLAPIGetConnectStatuspropCount++;
            hLLAPIGetConnectStatus["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPIGetConnectStatusworkflow);
            if (hLLAPIGetConnectStatuspropCount > 0)
            {
                callPayload.Body = hLLAPIGetConnectStatus;
            }

            return new ApiConnectionAction<HLLAPIGetConnectStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPIDisconnect(Expression<Func<string>> hLLAPIDisconnectsessionID, Expression<Func<string>> hLLAPIDisconnectworkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPIDisconnect";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIDisconnect = new JObject();
            var hLLAPIDisconnectpropCount = 0;
            hLLAPIDisconnectpropCount++;
            hLLAPIDisconnect["SessionID"] = CSharpExpressionConverter.ConvertToken(hLLAPIDisconnectsessionID);
            hLLAPIDisconnectpropCount++;
            hLLAPIDisconnect["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPIDisconnectworkflow);
            if (hLLAPIDisconnectpropCount > 0)
            {
                callPayload.Body = hLLAPIDisconnect;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPISetCursorPos(Expression<Func<string>> hLLAPISetCursorPossessionID, Expression<Func<int>> hLLAPISetCursorPoscursorRowIndex, Expression<Func<int>> hLLAPISetCursorPoscursorColIndex, Expression<Func<string>> hLLAPISetCursorPosworkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPISetCursorPos";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPISetCursorPos = new JObject();
            var hLLAPISetCursorPospropCount = 0;
            hLLAPISetCursorPospropCount++;
            hLLAPISetCursorPos["SessionID"] = CSharpExpressionConverter.ConvertToken(hLLAPISetCursorPossessionID);
            hLLAPISetCursorPospropCount++;
            hLLAPISetCursorPos["CursorRowIndex"] = CSharpExpressionConverter.ConvertToken(hLLAPISetCursorPoscursorRowIndex);
            hLLAPISetCursorPospropCount++;
            hLLAPISetCursorPos["CursorColIndex"] = CSharpExpressionConverter.ConvertToken(hLLAPISetCursorPoscursorColIndex);
            hLLAPISetCursorPospropCount++;
            hLLAPISetCursorPos["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPISetCursorPosworkflow);
            if (hLLAPISetCursorPospropCount > 0)
            {
                callPayload.Body = hLLAPISetCursorPos;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIGetCursorPosResponse> HLLAPIGetCursorPos(Expression<Func<string>> hLLAPIGetCursorPossessionID, Expression<Func<string>> hLLAPIGetCursorPosworkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPIGetCursorPos";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIGetCursorPos = new JObject();
            var hLLAPIGetCursorPospropCount = 0;
            hLLAPIGetCursorPospropCount++;
            hLLAPIGetCursorPos["SessionID"] = CSharpExpressionConverter.ConvertToken(hLLAPIGetCursorPossessionID);
            hLLAPIGetCursorPospropCount++;
            hLLAPIGetCursorPos["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPIGetCursorPosworkflow);
            if (hLLAPIGetCursorPospropCount > 0)
            {
                callPayload.Body = hLLAPIGetCursorPos;
            }

            return new ApiConnectionAction<HLLAPIGetCursorPosResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPISendString(Expression<Func<string>> hLLAPISendStringinputString, Expression<Func<string>> hLLAPISendStringworkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPISendString";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPISendString = new JObject();
            var hLLAPISendStringpropCount = 0;
            hLLAPISendStringpropCount++;
            hLLAPISendString["InputString"] = CSharpExpressionConverter.ConvertToken(hLLAPISendStringinputString);
            hLLAPISendStringpropCount++;
            hLLAPISendString["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPISendStringworkflow);
            if (hLLAPISendStringpropCount > 0)
            {
                callPayload.Body = hLLAPISendString;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPISendPassword(Expression<Func<string>> hLLAPISendPasswordinputPassword, Expression<Func<string>> hLLAPISendPasswordworkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPISendPassword";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPISendPassword = new JObject();
            var hLLAPISendPasswordpropCount = 0;
            hLLAPISendPasswordpropCount++;
            hLLAPISendPassword["InputPassword"] = CSharpExpressionConverter.ConvertToken(hLLAPISendPasswordinputPassword);
            hLLAPISendPasswordpropCount++;
            hLLAPISendPassword["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPISendPasswordworkflow);
            if (hLLAPISendPasswordpropCount > 0)
            {
                callPayload.Body = hLLAPISendPassword;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPISendStringAtCursorPos(Expression<Func<string>> hLLAPISendStringAtCursorPossessionID, Expression<Func<int>> hLLAPISendStringAtCursorPoscursorRowIndex, Expression<Func<int>> hLLAPISendStringAtCursorPoscursorColIndex, Expression<Func<string>> hLLAPISendStringAtCursorPosinputString, Expression<Func<string>> hLLAPISendStringAtCursorPosworkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPISendStringAtCursorPos";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPISendStringAtCursorPos = new JObject();
            var hLLAPISendStringAtCursorPospropCount = 0;
            hLLAPISendStringAtCursorPospropCount++;
            hLLAPISendStringAtCursorPos["SessionID"] = CSharpExpressionConverter.ConvertToken(hLLAPISendStringAtCursorPossessionID);
            hLLAPISendStringAtCursorPospropCount++;
            hLLAPISendStringAtCursorPos["CursorRowIndex"] = CSharpExpressionConverter.ConvertToken(hLLAPISendStringAtCursorPoscursorRowIndex);
            hLLAPISendStringAtCursorPospropCount++;
            hLLAPISendStringAtCursorPos["CursorColIndex"] = CSharpExpressionConverter.ConvertToken(hLLAPISendStringAtCursorPoscursorColIndex);
            hLLAPISendStringAtCursorPospropCount++;
            hLLAPISendStringAtCursorPos["InputString"] = CSharpExpressionConverter.ConvertToken(hLLAPISendStringAtCursorPosinputString);
            hLLAPISendStringAtCursorPospropCount++;
            hLLAPISendStringAtCursorPos["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPISendStringAtCursorPosworkflow);
            if (hLLAPISendStringAtCursorPospropCount > 0)
            {
                callPayload.Body = hLLAPISendStringAtCursorPos;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPISendPasswordAtCursorPos(Expression<Func<string>> hLLAPISendPasswordAtCursorPossessionID, Expression<Func<int>> hLLAPISendPasswordAtCursorPoscursorRowIndex, Expression<Func<int>> hLLAPISendPasswordAtCursorPoscursorColIndex, Expression<Func<string>> hLLAPISendPasswordAtCursorPosinputPassword, Expression<Func<string>> hLLAPISendPasswordAtCursorPosworkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPISendPasswordAtCursorPos";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPISendPasswordAtCursorPos = new JObject();
            var hLLAPISendPasswordAtCursorPospropCount = 0;
            hLLAPISendPasswordAtCursorPospropCount++;
            hLLAPISendPasswordAtCursorPos["SessionID"] = CSharpExpressionConverter.ConvertToken(hLLAPISendPasswordAtCursorPossessionID);
            hLLAPISendPasswordAtCursorPospropCount++;
            hLLAPISendPasswordAtCursorPos["CursorRowIndex"] = CSharpExpressionConverter.ConvertToken(hLLAPISendPasswordAtCursorPoscursorRowIndex);
            hLLAPISendPasswordAtCursorPospropCount++;
            hLLAPISendPasswordAtCursorPos["CursorColIndex"] = CSharpExpressionConverter.ConvertToken(hLLAPISendPasswordAtCursorPoscursorColIndex);
            hLLAPISendPasswordAtCursorPospropCount++;
            hLLAPISendPasswordAtCursorPos["InputPassword"] = CSharpExpressionConverter.ConvertToken(hLLAPISendPasswordAtCursorPosinputPassword);
            hLLAPISendPasswordAtCursorPospropCount++;
            hLLAPISendPasswordAtCursorPos["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPISendPasswordAtCursorPosworkflow);
            if (hLLAPISendPasswordAtCursorPospropCount > 0)
            {
                callPayload.Body = hLLAPISendPasswordAtCursorPos;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIReadScreenAtCursorPosResponse> HLLAPIReadScreenAtCursorPos(Expression<Func<string>> hLLAPIReadScreenAtCursorPossessionID, Expression<Func<int>> hLLAPIReadScreenAtCursorPoscursorRowIndex, Expression<Func<int>> hLLAPIReadScreenAtCursorPoscursorColIndex, Expression<Func<int>> hLLAPIReadScreenAtCursorPosreadScreenLength, Expression<Func<string>> hLLAPIReadScreenAtCursorPosworkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPIReadScreenAtCursorPos";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIReadScreenAtCursorPos = new JObject();
            var hLLAPIReadScreenAtCursorPospropCount = 0;
            hLLAPIReadScreenAtCursorPospropCount++;
            hLLAPIReadScreenAtCursorPos["SessionID"] = CSharpExpressionConverter.ConvertToken(hLLAPIReadScreenAtCursorPossessionID);
            hLLAPIReadScreenAtCursorPospropCount++;
            hLLAPIReadScreenAtCursorPos["CursorRowIndex"] = CSharpExpressionConverter.ConvertToken(hLLAPIReadScreenAtCursorPoscursorRowIndex);
            hLLAPIReadScreenAtCursorPospropCount++;
            hLLAPIReadScreenAtCursorPos["CursorColIndex"] = CSharpExpressionConverter.ConvertToken(hLLAPIReadScreenAtCursorPoscursorColIndex);
            hLLAPIReadScreenAtCursorPospropCount++;
            hLLAPIReadScreenAtCursorPos["ReadScreenLength"] = CSharpExpressionConverter.ConvertToken(hLLAPIReadScreenAtCursorPosreadScreenLength);
            hLLAPIReadScreenAtCursorPospropCount++;
            hLLAPIReadScreenAtCursorPos["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPIReadScreenAtCursorPosworkflow);
            if (hLLAPIReadScreenAtCursorPospropCount > 0)
            {
                callPayload.Body = hLLAPIReadScreenAtCursorPos;
            }

            return new ApiConnectionAction<HLLAPIReadScreenAtCursorPosResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIQuerySessionStatusResponse> HLLAPIQuerySessionStatus(Expression<Func<string>> hLLAPIQuerySessionStatusworkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPIQuerySessionStatus";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIQuerySessionStatus = new JObject();
            var hLLAPIQuerySessionStatuspropCount = 0;
            hLLAPIQuerySessionStatuspropCount++;
            hLLAPIQuerySessionStatus["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPIQuerySessionStatusworkflow);
            if (hLLAPIQuerySessionStatuspropCount > 0)
            {
                callPayload.Body = hLLAPIQuerySessionStatus;
            }

            return new ApiConnectionAction<HLLAPIQuerySessionStatusResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIReadScreenRowsResponse> HLLAPIReadScreenRows(Expression<Func<string>> hLLAPIReadScreenRowssessionID, Expression<Func<int>> hLLAPIReadScreenRowsstartRowIndex, Expression<Func<int>> hLLAPIReadScreenRowsendRowIndex, Expression<Func<string>> hLLAPIReadScreenRowsworkflow, Expression<Func<int>> hLLAPIReadScreenRowsnumberOfRowsInSession = null, Expression<Func<int>> hLLAPIReadScreenRowsnumberOfColumnsInSession = null)
        {
            var apiCallPath = "/HLLAPI/HLLAPIReadScreenRows";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIReadScreenRows = new JObject();
            var hLLAPIReadScreenRowspropCount = 0;
            hLLAPIReadScreenRowspropCount++;
            hLLAPIReadScreenRows["SessionID"] = CSharpExpressionConverter.ConvertToken(hLLAPIReadScreenRowssessionID);
            hLLAPIReadScreenRowspropCount++;
            hLLAPIReadScreenRows["StartRowIndex"] = CSharpExpressionConverter.ConvertToken(hLLAPIReadScreenRowsstartRowIndex);
            hLLAPIReadScreenRowspropCount++;
            hLLAPIReadScreenRows["EndRowIndex"] = CSharpExpressionConverter.ConvertToken(hLLAPIReadScreenRowsendRowIndex);
            if (hLLAPIReadScreenRowsnumberOfRowsInSession != null)
            {
                hLLAPIReadScreenRows["NumberOfRowsInSession"] = CSharpExpressionConverter.ConvertToken(hLLAPIReadScreenRowsnumberOfRowsInSession);
                hLLAPIReadScreenRowspropCount++;
            }

            if (hLLAPIReadScreenRowsnumberOfColumnsInSession != null)
            {
                hLLAPIReadScreenRows["NumberOfColumnsInSession"] = CSharpExpressionConverter.ConvertToken(hLLAPIReadScreenRowsnumberOfColumnsInSession);
                hLLAPIReadScreenRowspropCount++;
            }

            hLLAPIReadScreenRowspropCount++;
            hLLAPIReadScreenRows["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPIReadScreenRowsworkflow);
            if (hLLAPIReadScreenRowspropCount > 0)
            {
                callPayload.Body = hLLAPIReadScreenRows;
            }

            return new ApiConnectionAction<HLLAPIReadScreenRowsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIIsKeyboardUnlockedResponse> HLLAPIIsKeyboardUnlocked(Expression<Func<string>> hLLAPIIsKeyboardUnlockedworkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPIIsKeyboardUnlocked";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIIsKeyboardUnlocked = new JObject();
            var hLLAPIIsKeyboardUnlockedpropCount = 0;
            hLLAPIIsKeyboardUnlockedpropCount++;
            hLLAPIIsKeyboardUnlocked["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPIIsKeyboardUnlockedworkflow);
            if (hLLAPIIsKeyboardUnlockedpropCount > 0)
            {
                callPayload.Body = hLLAPIIsKeyboardUnlocked;
            }

            return new ApiConnectionAction<HLLAPIIsKeyboardUnlockedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIWaitForKeyboardUnlockedResponse> HLLAPIWaitForKeyboardUnlocked(Expression<Func<double>> hLLAPIWaitForKeyboardUnlockedsecondsToWait, Expression<Func<string>> hLLAPIWaitForKeyboardUnlockedworkflow, Expression<Func<double>> hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait = null)
        {
            var apiCallPath = "/HLLAPI/HLLAPIWaitForKeyboardUnlocked";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIWaitForKeyboardUnlocked = new JObject();
            var hLLAPIWaitForKeyboardUnlockedpropCount = 0;
            hLLAPIWaitForKeyboardUnlockedpropCount++;
            hLLAPIWaitForKeyboardUnlocked["SecondsToWait"] = CSharpExpressionConverter.ConvertToken(hLLAPIWaitForKeyboardUnlockedsecondsToWait);
            if (hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait != null)
            {
                if (hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait != null)
                {
                    hLLAPIWaitForKeyboardUnlocked["DeltaSecondsToWait"] = CSharpExpressionConverter.ConvertToken(hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait);
                    hLLAPIWaitForKeyboardUnlockedpropCount++;
                }

                hLLAPIWaitForKeyboardUnlockedpropCount++;
            }
            else
            {
                hLLAPIWaitForKeyboardUnlocked["DeltaSecondsToWait"] = 0.05;
                hLLAPIWaitForKeyboardUnlockedpropCount++;
            }

            hLLAPIWaitForKeyboardUnlockedpropCount++;
            hLLAPIWaitForKeyboardUnlocked["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPIWaitForKeyboardUnlockedworkflow);
            if (hLLAPIWaitForKeyboardUnlockedpropCount > 0)
            {
                callPayload.Body = hLLAPIWaitForKeyboardUnlocked;
            }

            return new ApiConnectionAction<HLLAPIWaitForKeyboardUnlockedResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIWaitForSystemReadyResponse> HLLAPIWaitForSystemReady(Expression<Func<double>> hLLAPIWaitForSystemReadysecondsToWait, Expression<Func<string>> hLLAPIWaitForSystemReadyworkflow, Expression<Func<double>> hLLAPIWaitForSystemReadydeltaSecondsToWait = null)
        {
            var apiCallPath = "/HLLAPI/HLLAPIWaitForSystemReady";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIWaitForSystemReady = new JObject();
            var hLLAPIWaitForSystemReadypropCount = 0;
            hLLAPIWaitForSystemReadypropCount++;
            hLLAPIWaitForSystemReady["SecondsToWait"] = CSharpExpressionConverter.ConvertToken(hLLAPIWaitForSystemReadysecondsToWait);
            if (hLLAPIWaitForSystemReadydeltaSecondsToWait != null)
            {
                if (hLLAPIWaitForSystemReadydeltaSecondsToWait != null)
                {
                    hLLAPIWaitForSystemReady["DeltaSecondsToWait"] = CSharpExpressionConverter.ConvertToken(hLLAPIWaitForSystemReadydeltaSecondsToWait);
                    hLLAPIWaitForSystemReadypropCount++;
                }

                hLLAPIWaitForSystemReadypropCount++;
            }
            else
            {
                hLLAPIWaitForSystemReady["DeltaSecondsToWait"] = 0.05;
                hLLAPIWaitForSystemReadypropCount++;
            }

            hLLAPIWaitForSystemReadypropCount++;
            hLLAPIWaitForSystemReady["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPIWaitForSystemReadyworkflow);
            if (hLLAPIWaitForSystemReadypropCount > 0)
            {
                callPayload.Body = hLLAPIWaitForSystemReady;
            }

            return new ApiConnectionAction<HLLAPIWaitForSystemReadyResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPIPressReset(Expression<Func<string>> hLLAPIPressResetworkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPIPressReset";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIPressReset = new JObject();
            var hLLAPIPressResetpropCount = 0;
            hLLAPIPressResetpropCount++;
            hLLAPIPressReset["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPIPressResetworkflow);
            if (hLLAPIPressResetpropCount > 0)
            {
                callPayload.Body = hLLAPIPressReset;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPISearchForStringResponse> HLLAPISearchForString(Expression<Func<string>> hLLAPISearchForStringsessionID, Expression<Func<string>> hLLAPISearchForStringsearchString, Expression<Func<string>> hLLAPISearchForStringworkflow, Expression<Func<bool>> hLLAPISearchForStringsearchEntireScreen = null, Expression<Func<int>> hLLAPISearchForStringsearchStartRowIndex = null, Expression<Func<int>> hLLAPISearchForStringsearchStartColIndex = null)
        {
            var apiCallPath = "/HLLAPI/HLLAPISearchForString";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPISearchForString = new JObject();
            var hLLAPISearchForStringpropCount = 0;
            hLLAPISearchForStringpropCount++;
            hLLAPISearchForString["SessionID"] = CSharpExpressionConverter.ConvertToken(hLLAPISearchForStringsessionID);
            hLLAPISearchForStringpropCount++;
            hLLAPISearchForString["SearchString"] = CSharpExpressionConverter.ConvertToken(hLLAPISearchForStringsearchString);
            if (hLLAPISearchForStringsearchEntireScreen != null)
            {
                if (hLLAPISearchForStringsearchEntireScreen != null)
                {
                    hLLAPISearchForString["SearchEntireScreen"] = CSharpExpressionConverter.ConvertToken(hLLAPISearchForStringsearchEntireScreen);
                    hLLAPISearchForStringpropCount++;
                }

                hLLAPISearchForStringpropCount++;
            }
            else
            {
                hLLAPISearchForString["SearchEntireScreen"] = true;
                hLLAPISearchForStringpropCount++;
            }

            if (hLLAPISearchForStringsearchStartRowIndex != null)
            {
                hLLAPISearchForString["SearchStartRowIndex"] = CSharpExpressionConverter.ConvertToken(hLLAPISearchForStringsearchStartRowIndex);
                hLLAPISearchForStringpropCount++;
            }

            if (hLLAPISearchForStringsearchStartColIndex != null)
            {
                hLLAPISearchForString["SearchStartColIndex"] = CSharpExpressionConverter.ConvertToken(hLLAPISearchForStringsearchStartColIndex);
                hLLAPISearchForStringpropCount++;
            }

            hLLAPISearchForStringpropCount++;
            hLLAPISearchForString["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPISearchForStringworkflow);
            if (hLLAPISearchForStringpropCount > 0)
            {
                callPayload.Body = hLLAPISearchForString;
            }

            return new ApiConnectionAction<HLLAPISearchForStringResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIWaitForStringResponse> HLLAPIWaitForString(Expression<Func<string>> hLLAPIWaitForStringsessionID, Expression<Func<string>> hLLAPIWaitForStringsearchString, Expression<Func<double>> hLLAPIWaitForStringsecondsToWait, Expression<Func<string>> hLLAPIWaitForStringworkflow, Expression<Func<bool>> hLLAPIWaitForStringsearchEntireScreen = null, Expression<Func<int>> hLLAPIWaitForStringsearchStartRowIndex = null, Expression<Func<int>> hLLAPIWaitForStringsearchStartColIndex = null, Expression<Func<double>> hLLAPIWaitForStringdeltaSecondsToWait = null)
        {
            var apiCallPath = "/HLLAPI/HLLAPIWaitForString";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIWaitForString = new JObject();
            var hLLAPIWaitForStringpropCount = 0;
            hLLAPIWaitForStringpropCount++;
            hLLAPIWaitForString["SessionID"] = CSharpExpressionConverter.ConvertToken(hLLAPIWaitForStringsessionID);
            hLLAPIWaitForStringpropCount++;
            hLLAPIWaitForString["SearchString"] = CSharpExpressionConverter.ConvertToken(hLLAPIWaitForStringsearchString);
            if (hLLAPIWaitForStringsearchEntireScreen != null)
            {
                if (hLLAPIWaitForStringsearchEntireScreen != null)
                {
                    hLLAPIWaitForString["SearchEntireScreen"] = CSharpExpressionConverter.ConvertToken(hLLAPIWaitForStringsearchEntireScreen);
                    hLLAPIWaitForStringpropCount++;
                }

                hLLAPIWaitForStringpropCount++;
            }
            else
            {
                hLLAPIWaitForString["SearchEntireScreen"] = true;
                hLLAPIWaitForStringpropCount++;
            }

            if (hLLAPIWaitForStringsearchStartRowIndex != null)
            {
                hLLAPIWaitForString["SearchStartRowIndex"] = CSharpExpressionConverter.ConvertToken(hLLAPIWaitForStringsearchStartRowIndex);
                hLLAPIWaitForStringpropCount++;
            }

            if (hLLAPIWaitForStringsearchStartColIndex != null)
            {
                hLLAPIWaitForString["SearchStartColIndex"] = CSharpExpressionConverter.ConvertToken(hLLAPIWaitForStringsearchStartColIndex);
                hLLAPIWaitForStringpropCount++;
            }

            hLLAPIWaitForStringpropCount++;
            hLLAPIWaitForString["SecondsToWait"] = CSharpExpressionConverter.ConvertToken(hLLAPIWaitForStringsecondsToWait);
            if (hLLAPIWaitForStringdeltaSecondsToWait != null)
            {
                if (hLLAPIWaitForStringdeltaSecondsToWait != null)
                {
                    hLLAPIWaitForString["DeltaSecondsToWait"] = CSharpExpressionConverter.ConvertToken(hLLAPIWaitForStringdeltaSecondsToWait);
                    hLLAPIWaitForStringpropCount++;
                }

                hLLAPIWaitForStringpropCount++;
            }
            else
            {
                hLLAPIWaitForString["DeltaSecondsToWait"] = 0.05;
                hLLAPIWaitForStringpropCount++;
            }

            hLLAPIWaitForStringpropCount++;
            hLLAPIWaitForString["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPIWaitForStringworkflow);
            if (hLLAPIWaitForStringpropCount > 0)
            {
                callPayload.Body = hLLAPIWaitForString;
            }

            return new ApiConnectionAction<HLLAPIWaitForStringResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPISetSessionParameter(Expression<Func<string>> hLLAPISetSessionParameterparameter, Expression<Func<string>> hLLAPISetSessionParameterworkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPISetSessionParameter";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPISetSessionParameter = new JObject();
            var hLLAPISetSessionParameterpropCount = 0;
            hLLAPISetSessionParameterpropCount++;
            hLLAPISetSessionParameter["Parameter"] = CSharpExpressionConverter.ConvertToken(hLLAPISetSessionParameterparameter);
            hLLAPISetSessionParameterpropCount++;
            hLLAPISetSessionParameter["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPISetSessionParameterworkflow);
            if (hLLAPISetSessionParameterpropCount > 0)
            {
                callPayload.Body = hLLAPISetSessionParameter;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPIResetSystem(Expression<Func<string>> hLLAPIResetSystemworkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPIResetSystem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPIResetSystem = new JObject();
            var hLLAPIResetSystempropCount = 0;
            hLLAPIResetSystempropCount++;
            hLLAPIResetSystem["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPIResetSystemworkflow);
            if (hLLAPIResetSystempropCount > 0)
            {
                callPayload.Body = hLLAPIResetSystem;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPICopyOperatorInformationAreaResponse> HLLAPICopyOperatorInformationArea(Expression<Func<string>> hLLAPICopyOperatorInformationAreaworkflow)
        {
            var apiCallPath = "/HLLAPI/HLLAPICopyOperatorInformationArea";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hLLAPICopyOperatorInformationArea = new JObject();
            var hLLAPICopyOperatorInformationAreapropCount = 0;
            hLLAPICopyOperatorInformationAreapropCount++;
            hLLAPICopyOperatorInformationArea["Workflow"] = CSharpExpressionConverter.ConvertToken(hLLAPICopyOperatorInformationAreaworkflow);
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