//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectmainframe
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectmainframeActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPISetHLLAPIDLL))]
        public IWorkflowAction HLLAPISetHLLAPIDLL([WorkflowExpression] Func<string> hLLAPISetHLLAPIDLLdLLFilename, [WorkflowExpression] Func<string> hLLAPISetHLLAPIDLLworkflow, [WorkflowExpression] Func<string> hLLAPISetHLLAPIDLLiAHLLAPIPath = null, [WorkflowExpression] Func<string> hLLAPISetHLLAPIDLLentryPointName = null, [WorkflowExpression] Func<bool> hLLAPISetHLLAPIDLLisEnhancedInterface = null, [WorkflowExpression] Func<bool> hLLAPISetHLLAPIDLLis64BitHLLAPIDLL = null, [WorkflowExpression] Func<bool> hLLAPISetHLLAPIDLLuseCOMFor64BitHLLAPIDLL = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildHLLAPISetHLLAPIDLL(WorkflowExpression<string> hLLAPISetHLLAPIDLLdLLFilename, WorkflowExpression<string> hLLAPISetHLLAPIDLLworkflow, WorkflowExpression<string> hLLAPISetHLLAPIDLLiAHLLAPIPath = null, WorkflowExpression<string> hLLAPISetHLLAPIDLLentryPointName = null, WorkflowExpression<bool> hLLAPISetHLLAPIDLLisEnhancedInterface = null, WorkflowExpression<bool> hLLAPISetHLLAPIDLLis64BitHLLAPIDLL = null, WorkflowExpression<bool> hLLAPISetHLLAPIDLLuseCOMFor64BitHLLAPIDLL = null)
        {
            WorkflowExpression.Validate(hLLAPISetHLLAPIDLLdLLFilename, nameof(hLLAPISetHLLAPIDLLdLLFilename), required: true);
            WorkflowExpression.Validate(hLLAPISetHLLAPIDLLworkflow, nameof(hLLAPISetHLLAPIDLLworkflow), required: true);
            WorkflowExpression.Validate(hLLAPISetHLLAPIDLLiAHLLAPIPath, nameof(hLLAPISetHLLAPIDLLiAHLLAPIPath), required: false);
            WorkflowExpression.Validate(hLLAPISetHLLAPIDLLentryPointName, nameof(hLLAPISetHLLAPIDLLentryPointName), required: false);
            WorkflowExpression.Validate(hLLAPISetHLLAPIDLLisEnhancedInterface, nameof(hLLAPISetHLLAPIDLLisEnhancedInterface), required: false);
            WorkflowExpression.Validate(hLLAPISetHLLAPIDLLis64BitHLLAPIDLL, nameof(hLLAPISetHLLAPIDLLis64BitHLLAPIDLL), required: false);
            WorkflowExpression.Validate(hLLAPISetHLLAPIDLLuseCOMFor64BitHLLAPIDLL, nameof(hLLAPISetHLLAPIDLLuseCOMFor64BitHLLAPIDLL), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISetHLLAPIDLL";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISetHLLAPIDLL = new JObject();
                var hLLAPISetHLLAPIDLLpropCount = 0;
                hLLAPISetHLLAPIDLLpropCount++;
                hLLAPISetHLLAPIDLL["DLLFilename"] = ExpressionConverter.ConvertO(hLLAPISetHLLAPIDLLdLLFilename);
                if (hLLAPISetHLLAPIDLLiAHLLAPIPath != null)
                {
                    hLLAPISetHLLAPIDLL["IAHLLAPIPath"] = ExpressionConverter.ConvertO(hLLAPISetHLLAPIDLLiAHLLAPIPath);
                    hLLAPISetHLLAPIDLLpropCount++;
                }

                if (hLLAPISetHLLAPIDLLentryPointName != null)
                {
                    hLLAPISetHLLAPIDLL["EntryPointName"] = ExpressionConverter.ConvertO(hLLAPISetHLLAPIDLLentryPointName);
                    hLLAPISetHLLAPIDLLpropCount++;
                }

                if (hLLAPISetHLLAPIDLLisEnhancedInterface != null)
                {
                    if (hLLAPISetHLLAPIDLLisEnhancedInterface != null)
                    {
                        hLLAPISetHLLAPIDLL["IsEnhancedInterface"] = ExpressionConverter.ConvertO(hLLAPISetHLLAPIDLLisEnhancedInterface);
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
                        hLLAPISetHLLAPIDLL["Is64BitHLLAPIDLL"] = ExpressionConverter.ConvertO(hLLAPISetHLLAPIDLLis64BitHLLAPIDLL);
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
                        hLLAPISetHLLAPIDLL["UseCOMFor64BitHLLAPIDLL"] = ExpressionConverter.ConvertO(hLLAPISetHLLAPIDLLuseCOMFor64BitHLLAPIDLL);
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
                hLLAPISetHLLAPIDLL["Workflow"] = ExpressionConverter.ConvertO(hLLAPISetHLLAPIDLLworkflow);
                if (hLLAPISetHLLAPIDLLpropCount > 0)
                {
                    callPayload.Body = hLLAPISetHLLAPIDLL;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPIDispose))]
        public IWorkflowAction HLLAPIDispose([WorkflowExpression] Func<string> hLLAPIDisposeworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildHLLAPIDispose(WorkflowExpression<string> hLLAPIDisposeworkflow)
        {
            WorkflowExpression.Validate(hLLAPIDisposeworkflow, nameof(hLLAPIDisposeworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIDispose";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIDispose = new JObject();
                var hLLAPIDisposepropCount = 0;
                hLLAPIDisposepropCount++;
                hLLAPIDispose["Workflow"] = ExpressionConverter.ConvertO(hLLAPIDisposeworkflow);
                if (hLLAPIDisposepropCount > 0)
                {
                    callPayload.Body = hLLAPIDispose;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPIConnect))]
        public IWorkflowAction HLLAPIConnect([WorkflowExpression] Func<string> hLLAPIConnectsessionID, [WorkflowExpression] Func<string> hLLAPIConnectworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildHLLAPIConnect(WorkflowExpression<string> hLLAPIConnectsessionID, WorkflowExpression<string> hLLAPIConnectworkflow)
        {
            WorkflowExpression.Validate(hLLAPIConnectsessionID, nameof(hLLAPIConnectsessionID), required: true);
            WorkflowExpression.Validate(hLLAPIConnectworkflow, nameof(hLLAPIConnectworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIConnect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIConnect = new JObject();
                var hLLAPIConnectpropCount = 0;
                hLLAPIConnectpropCount++;
                hLLAPIConnect["SessionID"] = ExpressionConverter.ConvertO(hLLAPIConnectsessionID);
                hLLAPIConnectpropCount++;
                hLLAPIConnect["Workflow"] = ExpressionConverter.ConvertO(hLLAPIConnectworkflow);
                if (hLLAPIConnectpropCount > 0)
                {
                    callPayload.Body = hLLAPIConnect;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPIGetConnectStatus))]
        public IBodyWorkflowAction<HLLAPIGetConnectStatusResponse> HLLAPIGetConnectStatus([WorkflowExpression] Func<string> hLLAPIGetConnectStatussessionID, [WorkflowExpression] Func<string> hLLAPIGetConnectStatusworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HLLAPIGetConnectStatusResponse> __BuildHLLAPIGetConnectStatus(WorkflowExpression<string> hLLAPIGetConnectStatussessionID, WorkflowExpression<string> hLLAPIGetConnectStatusworkflow)
        {
            WorkflowExpression.Validate(hLLAPIGetConnectStatussessionID, nameof(hLLAPIGetConnectStatussessionID), required: true);
            WorkflowExpression.Validate(hLLAPIGetConnectStatusworkflow, nameof(hLLAPIGetConnectStatusworkflow), required: true);
            return new DeferredBodyAction<HLLAPIGetConnectStatusResponse>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIGetConnectStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIGetConnectStatus = new JObject();
                var hLLAPIGetConnectStatuspropCount = 0;
                hLLAPIGetConnectStatuspropCount++;
                hLLAPIGetConnectStatus["SessionID"] = ExpressionConverter.ConvertO(hLLAPIGetConnectStatussessionID);
                hLLAPIGetConnectStatuspropCount++;
                hLLAPIGetConnectStatus["Workflow"] = ExpressionConverter.ConvertO(hLLAPIGetConnectStatusworkflow);
                if (hLLAPIGetConnectStatuspropCount > 0)
                {
                    callPayload.Body = hLLAPIGetConnectStatus;
                }

                return new ApiConnectionAction<HLLAPIGetConnectStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPIDisconnect))]
        public IWorkflowAction HLLAPIDisconnect([WorkflowExpression] Func<string> hLLAPIDisconnectsessionID, [WorkflowExpression] Func<string> hLLAPIDisconnectworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildHLLAPIDisconnect(WorkflowExpression<string> hLLAPIDisconnectsessionID, WorkflowExpression<string> hLLAPIDisconnectworkflow)
        {
            WorkflowExpression.Validate(hLLAPIDisconnectsessionID, nameof(hLLAPIDisconnectsessionID), required: true);
            WorkflowExpression.Validate(hLLAPIDisconnectworkflow, nameof(hLLAPIDisconnectworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIDisconnect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIDisconnect = new JObject();
                var hLLAPIDisconnectpropCount = 0;
                hLLAPIDisconnectpropCount++;
                hLLAPIDisconnect["SessionID"] = ExpressionConverter.ConvertO(hLLAPIDisconnectsessionID);
                hLLAPIDisconnectpropCount++;
                hLLAPIDisconnect["Workflow"] = ExpressionConverter.ConvertO(hLLAPIDisconnectworkflow);
                if (hLLAPIDisconnectpropCount > 0)
                {
                    callPayload.Body = hLLAPIDisconnect;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPISetCursorPos))]
        public IWorkflowAction HLLAPISetCursorPos([WorkflowExpression] Func<string> hLLAPISetCursorPossessionID, [WorkflowExpression] Func<int> hLLAPISetCursorPoscursorRowIndex, [WorkflowExpression] Func<int> hLLAPISetCursorPoscursorColIndex, [WorkflowExpression] Func<string> hLLAPISetCursorPosworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildHLLAPISetCursorPos(WorkflowExpression<string> hLLAPISetCursorPossessionID, WorkflowExpression<int> hLLAPISetCursorPoscursorRowIndex, WorkflowExpression<int> hLLAPISetCursorPoscursorColIndex, WorkflowExpression<string> hLLAPISetCursorPosworkflow)
        {
            WorkflowExpression.Validate(hLLAPISetCursorPossessionID, nameof(hLLAPISetCursorPossessionID), required: true);
            WorkflowExpression.Validate(hLLAPISetCursorPoscursorRowIndex, nameof(hLLAPISetCursorPoscursorRowIndex), required: true);
            WorkflowExpression.Validate(hLLAPISetCursorPoscursorColIndex, nameof(hLLAPISetCursorPoscursorColIndex), required: true);
            WorkflowExpression.Validate(hLLAPISetCursorPosworkflow, nameof(hLLAPISetCursorPosworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISetCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISetCursorPos = new JObject();
                var hLLAPISetCursorPospropCount = 0;
                hLLAPISetCursorPospropCount++;
                hLLAPISetCursorPos["SessionID"] = ExpressionConverter.ConvertO(hLLAPISetCursorPossessionID);
                hLLAPISetCursorPospropCount++;
                hLLAPISetCursorPos["CursorRowIndex"] = ExpressionConverter.ConvertO(hLLAPISetCursorPoscursorRowIndex);
                hLLAPISetCursorPospropCount++;
                hLLAPISetCursorPos["CursorColIndex"] = ExpressionConverter.ConvertO(hLLAPISetCursorPoscursorColIndex);
                hLLAPISetCursorPospropCount++;
                hLLAPISetCursorPos["Workflow"] = ExpressionConverter.ConvertO(hLLAPISetCursorPosworkflow);
                if (hLLAPISetCursorPospropCount > 0)
                {
                    callPayload.Body = hLLAPISetCursorPos;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPIGetCursorPos))]
        public IBodyWorkflowAction<HLLAPIGetCursorPosResponse> HLLAPIGetCursorPos([WorkflowExpression] Func<string> hLLAPIGetCursorPossessionID, [WorkflowExpression] Func<string> hLLAPIGetCursorPosworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HLLAPIGetCursorPosResponse> __BuildHLLAPIGetCursorPos(WorkflowExpression<string> hLLAPIGetCursorPossessionID, WorkflowExpression<string> hLLAPIGetCursorPosworkflow)
        {
            WorkflowExpression.Validate(hLLAPIGetCursorPossessionID, nameof(hLLAPIGetCursorPossessionID), required: true);
            WorkflowExpression.Validate(hLLAPIGetCursorPosworkflow, nameof(hLLAPIGetCursorPosworkflow), required: true);
            return new DeferredBodyAction<HLLAPIGetCursorPosResponse>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIGetCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIGetCursorPos = new JObject();
                var hLLAPIGetCursorPospropCount = 0;
                hLLAPIGetCursorPospropCount++;
                hLLAPIGetCursorPos["SessionID"] = ExpressionConverter.ConvertO(hLLAPIGetCursorPossessionID);
                hLLAPIGetCursorPospropCount++;
                hLLAPIGetCursorPos["Workflow"] = ExpressionConverter.ConvertO(hLLAPIGetCursorPosworkflow);
                if (hLLAPIGetCursorPospropCount > 0)
                {
                    callPayload.Body = hLLAPIGetCursorPos;
                }

                return new ApiConnectionAction<HLLAPIGetCursorPosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPISendString))]
        public IWorkflowAction HLLAPISendString([WorkflowExpression] Func<string> hLLAPISendStringinputString, [WorkflowExpression] Func<string> hLLAPISendStringworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildHLLAPISendString(WorkflowExpression<string> hLLAPISendStringinputString, WorkflowExpression<string> hLLAPISendStringworkflow)
        {
            WorkflowExpression.Validate(hLLAPISendStringinputString, nameof(hLLAPISendStringinputString), required: true);
            WorkflowExpression.Validate(hLLAPISendStringworkflow, nameof(hLLAPISendStringworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISendString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISendString = new JObject();
                var hLLAPISendStringpropCount = 0;
                hLLAPISendStringpropCount++;
                hLLAPISendString["InputString"] = ExpressionConverter.ConvertO(hLLAPISendStringinputString);
                hLLAPISendStringpropCount++;
                hLLAPISendString["Workflow"] = ExpressionConverter.ConvertO(hLLAPISendStringworkflow);
                if (hLLAPISendStringpropCount > 0)
                {
                    callPayload.Body = hLLAPISendString;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPISendPassword))]
        public IWorkflowAction HLLAPISendPassword([WorkflowExpression] Func<string> hLLAPISendPasswordinputPassword, [WorkflowExpression] Func<string> hLLAPISendPasswordworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildHLLAPISendPassword(WorkflowExpression<string> hLLAPISendPasswordinputPassword, WorkflowExpression<string> hLLAPISendPasswordworkflow)
        {
            WorkflowExpression.Validate(hLLAPISendPasswordinputPassword, nameof(hLLAPISendPasswordinputPassword), required: true);
            WorkflowExpression.Validate(hLLAPISendPasswordworkflow, nameof(hLLAPISendPasswordworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISendPassword";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISendPassword = new JObject();
                var hLLAPISendPasswordpropCount = 0;
                hLLAPISendPasswordpropCount++;
                hLLAPISendPassword["InputPassword"] = ExpressionConverter.ConvertO(hLLAPISendPasswordinputPassword);
                hLLAPISendPasswordpropCount++;
                hLLAPISendPassword["Workflow"] = ExpressionConverter.ConvertO(hLLAPISendPasswordworkflow);
                if (hLLAPISendPasswordpropCount > 0)
                {
                    callPayload.Body = hLLAPISendPassword;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPISendStringAtCursorPos))]
        public IWorkflowAction HLLAPISendStringAtCursorPos([WorkflowExpression] Func<string> hLLAPISendStringAtCursorPossessionID, [WorkflowExpression] Func<int> hLLAPISendStringAtCursorPoscursorRowIndex, [WorkflowExpression] Func<int> hLLAPISendStringAtCursorPoscursorColIndex, [WorkflowExpression] Func<string> hLLAPISendStringAtCursorPosinputString, [WorkflowExpression] Func<string> hLLAPISendStringAtCursorPosworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildHLLAPISendStringAtCursorPos(WorkflowExpression<string> hLLAPISendStringAtCursorPossessionID, WorkflowExpression<int> hLLAPISendStringAtCursorPoscursorRowIndex, WorkflowExpression<int> hLLAPISendStringAtCursorPoscursorColIndex, WorkflowExpression<string> hLLAPISendStringAtCursorPosinputString, WorkflowExpression<string> hLLAPISendStringAtCursorPosworkflow)
        {
            WorkflowExpression.Validate(hLLAPISendStringAtCursorPossessionID, nameof(hLLAPISendStringAtCursorPossessionID), required: true);
            WorkflowExpression.Validate(hLLAPISendStringAtCursorPoscursorRowIndex, nameof(hLLAPISendStringAtCursorPoscursorRowIndex), required: true);
            WorkflowExpression.Validate(hLLAPISendStringAtCursorPoscursorColIndex, nameof(hLLAPISendStringAtCursorPoscursorColIndex), required: true);
            WorkflowExpression.Validate(hLLAPISendStringAtCursorPosinputString, nameof(hLLAPISendStringAtCursorPosinputString), required: true);
            WorkflowExpression.Validate(hLLAPISendStringAtCursorPosworkflow, nameof(hLLAPISendStringAtCursorPosworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISendStringAtCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISendStringAtCursorPos = new JObject();
                var hLLAPISendStringAtCursorPospropCount = 0;
                hLLAPISendStringAtCursorPospropCount++;
                hLLAPISendStringAtCursorPos["SessionID"] = ExpressionConverter.ConvertO(hLLAPISendStringAtCursorPossessionID);
                hLLAPISendStringAtCursorPospropCount++;
                hLLAPISendStringAtCursorPos["CursorRowIndex"] = ExpressionConverter.ConvertO(hLLAPISendStringAtCursorPoscursorRowIndex);
                hLLAPISendStringAtCursorPospropCount++;
                hLLAPISendStringAtCursorPos["CursorColIndex"] = ExpressionConverter.ConvertO(hLLAPISendStringAtCursorPoscursorColIndex);
                hLLAPISendStringAtCursorPospropCount++;
                hLLAPISendStringAtCursorPos["InputString"] = ExpressionConverter.ConvertO(hLLAPISendStringAtCursorPosinputString);
                hLLAPISendStringAtCursorPospropCount++;
                hLLAPISendStringAtCursorPos["Workflow"] = ExpressionConverter.ConvertO(hLLAPISendStringAtCursorPosworkflow);
                if (hLLAPISendStringAtCursorPospropCount > 0)
                {
                    callPayload.Body = hLLAPISendStringAtCursorPos;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPISendPasswordAtCursorPos))]
        public IWorkflowAction HLLAPISendPasswordAtCursorPos([WorkflowExpression] Func<string> hLLAPISendPasswordAtCursorPossessionID, [WorkflowExpression] Func<int> hLLAPISendPasswordAtCursorPoscursorRowIndex, [WorkflowExpression] Func<int> hLLAPISendPasswordAtCursorPoscursorColIndex, [WorkflowExpression] Func<string> hLLAPISendPasswordAtCursorPosinputPassword, [WorkflowExpression] Func<string> hLLAPISendPasswordAtCursorPosworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildHLLAPISendPasswordAtCursorPos(WorkflowExpression<string> hLLAPISendPasswordAtCursorPossessionID, WorkflowExpression<int> hLLAPISendPasswordAtCursorPoscursorRowIndex, WorkflowExpression<int> hLLAPISendPasswordAtCursorPoscursorColIndex, WorkflowExpression<string> hLLAPISendPasswordAtCursorPosinputPassword, WorkflowExpression<string> hLLAPISendPasswordAtCursorPosworkflow)
        {
            WorkflowExpression.Validate(hLLAPISendPasswordAtCursorPossessionID, nameof(hLLAPISendPasswordAtCursorPossessionID), required: true);
            WorkflowExpression.Validate(hLLAPISendPasswordAtCursorPoscursorRowIndex, nameof(hLLAPISendPasswordAtCursorPoscursorRowIndex), required: true);
            WorkflowExpression.Validate(hLLAPISendPasswordAtCursorPoscursorColIndex, nameof(hLLAPISendPasswordAtCursorPoscursorColIndex), required: true);
            WorkflowExpression.Validate(hLLAPISendPasswordAtCursorPosinputPassword, nameof(hLLAPISendPasswordAtCursorPosinputPassword), required: true);
            WorkflowExpression.Validate(hLLAPISendPasswordAtCursorPosworkflow, nameof(hLLAPISendPasswordAtCursorPosworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISendPasswordAtCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISendPasswordAtCursorPos = new JObject();
                var hLLAPISendPasswordAtCursorPospropCount = 0;
                hLLAPISendPasswordAtCursorPospropCount++;
                hLLAPISendPasswordAtCursorPos["SessionID"] = ExpressionConverter.ConvertO(hLLAPISendPasswordAtCursorPossessionID);
                hLLAPISendPasswordAtCursorPospropCount++;
                hLLAPISendPasswordAtCursorPos["CursorRowIndex"] = ExpressionConverter.ConvertO(hLLAPISendPasswordAtCursorPoscursorRowIndex);
                hLLAPISendPasswordAtCursorPospropCount++;
                hLLAPISendPasswordAtCursorPos["CursorColIndex"] = ExpressionConverter.ConvertO(hLLAPISendPasswordAtCursorPoscursorColIndex);
                hLLAPISendPasswordAtCursorPospropCount++;
                hLLAPISendPasswordAtCursorPos["InputPassword"] = ExpressionConverter.ConvertO(hLLAPISendPasswordAtCursorPosinputPassword);
                hLLAPISendPasswordAtCursorPospropCount++;
                hLLAPISendPasswordAtCursorPos["Workflow"] = ExpressionConverter.ConvertO(hLLAPISendPasswordAtCursorPosworkflow);
                if (hLLAPISendPasswordAtCursorPospropCount > 0)
                {
                    callPayload.Body = hLLAPISendPasswordAtCursorPos;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPIReadScreenAtCursorPos))]
        public IBodyWorkflowAction<HLLAPIReadScreenAtCursorPosResponse> HLLAPIReadScreenAtCursorPos([WorkflowExpression] Func<string> hLLAPIReadScreenAtCursorPossessionID, [WorkflowExpression] Func<int> hLLAPIReadScreenAtCursorPoscursorRowIndex, [WorkflowExpression] Func<int> hLLAPIReadScreenAtCursorPoscursorColIndex, [WorkflowExpression] Func<int> hLLAPIReadScreenAtCursorPosreadScreenLength, [WorkflowExpression] Func<string> hLLAPIReadScreenAtCursorPosworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HLLAPIReadScreenAtCursorPosResponse> __BuildHLLAPIReadScreenAtCursorPos(WorkflowExpression<string> hLLAPIReadScreenAtCursorPossessionID, WorkflowExpression<int> hLLAPIReadScreenAtCursorPoscursorRowIndex, WorkflowExpression<int> hLLAPIReadScreenAtCursorPoscursorColIndex, WorkflowExpression<int> hLLAPIReadScreenAtCursorPosreadScreenLength, WorkflowExpression<string> hLLAPIReadScreenAtCursorPosworkflow)
        {
            WorkflowExpression.Validate(hLLAPIReadScreenAtCursorPossessionID, nameof(hLLAPIReadScreenAtCursorPossessionID), required: true);
            WorkflowExpression.Validate(hLLAPIReadScreenAtCursorPoscursorRowIndex, nameof(hLLAPIReadScreenAtCursorPoscursorRowIndex), required: true);
            WorkflowExpression.Validate(hLLAPIReadScreenAtCursorPoscursorColIndex, nameof(hLLAPIReadScreenAtCursorPoscursorColIndex), required: true);
            WorkflowExpression.Validate(hLLAPIReadScreenAtCursorPosreadScreenLength, nameof(hLLAPIReadScreenAtCursorPosreadScreenLength), required: true);
            WorkflowExpression.Validate(hLLAPIReadScreenAtCursorPosworkflow, nameof(hLLAPIReadScreenAtCursorPosworkflow), required: true);
            return new DeferredBodyAction<HLLAPIReadScreenAtCursorPosResponse>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIReadScreenAtCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIReadScreenAtCursorPos = new JObject();
                var hLLAPIReadScreenAtCursorPospropCount = 0;
                hLLAPIReadScreenAtCursorPospropCount++;
                hLLAPIReadScreenAtCursorPos["SessionID"] = ExpressionConverter.ConvertO(hLLAPIReadScreenAtCursorPossessionID);
                hLLAPIReadScreenAtCursorPospropCount++;
                hLLAPIReadScreenAtCursorPos["CursorRowIndex"] = ExpressionConverter.ConvertO(hLLAPIReadScreenAtCursorPoscursorRowIndex);
                hLLAPIReadScreenAtCursorPospropCount++;
                hLLAPIReadScreenAtCursorPos["CursorColIndex"] = ExpressionConverter.ConvertO(hLLAPIReadScreenAtCursorPoscursorColIndex);
                hLLAPIReadScreenAtCursorPospropCount++;
                hLLAPIReadScreenAtCursorPos["ReadScreenLength"] = ExpressionConverter.ConvertO(hLLAPIReadScreenAtCursorPosreadScreenLength);
                hLLAPIReadScreenAtCursorPospropCount++;
                hLLAPIReadScreenAtCursorPos["Workflow"] = ExpressionConverter.ConvertO(hLLAPIReadScreenAtCursorPosworkflow);
                if (hLLAPIReadScreenAtCursorPospropCount > 0)
                {
                    callPayload.Body = hLLAPIReadScreenAtCursorPos;
                }

                return new ApiConnectionAction<HLLAPIReadScreenAtCursorPosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPIQuerySessionStatus))]
        public IBodyWorkflowAction<HLLAPIQuerySessionStatusResponse> HLLAPIQuerySessionStatus([WorkflowExpression] Func<string> hLLAPIQuerySessionStatusworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HLLAPIQuerySessionStatusResponse> __BuildHLLAPIQuerySessionStatus(WorkflowExpression<string> hLLAPIQuerySessionStatusworkflow)
        {
            WorkflowExpression.Validate(hLLAPIQuerySessionStatusworkflow, nameof(hLLAPIQuerySessionStatusworkflow), required: true);
            return new DeferredBodyAction<HLLAPIQuerySessionStatusResponse>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIQuerySessionStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIQuerySessionStatus = new JObject();
                var hLLAPIQuerySessionStatuspropCount = 0;
                hLLAPIQuerySessionStatuspropCount++;
                hLLAPIQuerySessionStatus["Workflow"] = ExpressionConverter.ConvertO(hLLAPIQuerySessionStatusworkflow);
                if (hLLAPIQuerySessionStatuspropCount > 0)
                {
                    callPayload.Body = hLLAPIQuerySessionStatus;
                }

                return new ApiConnectionAction<HLLAPIQuerySessionStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPIReadScreenRows))]
        public IBodyWorkflowAction<HLLAPIReadScreenRowsResponse> HLLAPIReadScreenRows([WorkflowExpression] Func<string> hLLAPIReadScreenRowssessionID, [WorkflowExpression] Func<int> hLLAPIReadScreenRowsstartRowIndex, [WorkflowExpression] Func<int> hLLAPIReadScreenRowsendRowIndex, [WorkflowExpression] Func<string> hLLAPIReadScreenRowsworkflow, [WorkflowExpression] Func<int> hLLAPIReadScreenRowsnumberOfRowsInSession = null, [WorkflowExpression] Func<int> hLLAPIReadScreenRowsnumberOfColumnsInSession = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HLLAPIReadScreenRowsResponse> __BuildHLLAPIReadScreenRows(WorkflowExpression<string> hLLAPIReadScreenRowssessionID, WorkflowExpression<int> hLLAPIReadScreenRowsstartRowIndex, WorkflowExpression<int> hLLAPIReadScreenRowsendRowIndex, WorkflowExpression<string> hLLAPIReadScreenRowsworkflow, WorkflowExpression<int> hLLAPIReadScreenRowsnumberOfRowsInSession = null, WorkflowExpression<int> hLLAPIReadScreenRowsnumberOfColumnsInSession = null)
        {
            WorkflowExpression.Validate(hLLAPIReadScreenRowssessionID, nameof(hLLAPIReadScreenRowssessionID), required: true);
            WorkflowExpression.Validate(hLLAPIReadScreenRowsstartRowIndex, nameof(hLLAPIReadScreenRowsstartRowIndex), required: true);
            WorkflowExpression.Validate(hLLAPIReadScreenRowsendRowIndex, nameof(hLLAPIReadScreenRowsendRowIndex), required: true);
            WorkflowExpression.Validate(hLLAPIReadScreenRowsworkflow, nameof(hLLAPIReadScreenRowsworkflow), required: true);
            WorkflowExpression.Validate(hLLAPIReadScreenRowsnumberOfRowsInSession, nameof(hLLAPIReadScreenRowsnumberOfRowsInSession), required: false);
            WorkflowExpression.Validate(hLLAPIReadScreenRowsnumberOfColumnsInSession, nameof(hLLAPIReadScreenRowsnumberOfColumnsInSession), required: false);
            return new DeferredBodyAction<HLLAPIReadScreenRowsResponse>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIReadScreenRows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIReadScreenRows = new JObject();
                var hLLAPIReadScreenRowspropCount = 0;
                hLLAPIReadScreenRowspropCount++;
                hLLAPIReadScreenRows["SessionID"] = ExpressionConverter.ConvertO(hLLAPIReadScreenRowssessionID);
                hLLAPIReadScreenRowspropCount++;
                hLLAPIReadScreenRows["StartRowIndex"] = ExpressionConverter.ConvertO(hLLAPIReadScreenRowsstartRowIndex);
                hLLAPIReadScreenRowspropCount++;
                hLLAPIReadScreenRows["EndRowIndex"] = ExpressionConverter.ConvertO(hLLAPIReadScreenRowsendRowIndex);
                if (hLLAPIReadScreenRowsnumberOfRowsInSession != null)
                {
                    hLLAPIReadScreenRows["NumberOfRowsInSession"] = ExpressionConverter.ConvertO(hLLAPIReadScreenRowsnumberOfRowsInSession);
                    hLLAPIReadScreenRowspropCount++;
                }

                if (hLLAPIReadScreenRowsnumberOfColumnsInSession != null)
                {
                    hLLAPIReadScreenRows["NumberOfColumnsInSession"] = ExpressionConverter.ConvertO(hLLAPIReadScreenRowsnumberOfColumnsInSession);
                    hLLAPIReadScreenRowspropCount++;
                }

                hLLAPIReadScreenRowspropCount++;
                hLLAPIReadScreenRows["Workflow"] = ExpressionConverter.ConvertO(hLLAPIReadScreenRowsworkflow);
                if (hLLAPIReadScreenRowspropCount > 0)
                {
                    callPayload.Body = hLLAPIReadScreenRows;
                }

                return new ApiConnectionAction<HLLAPIReadScreenRowsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPIIsKeyboardUnlocked))]
        public IBodyWorkflowAction<HLLAPIIsKeyboardUnlockedResponse> HLLAPIIsKeyboardUnlocked([WorkflowExpression] Func<string> hLLAPIIsKeyboardUnlockedworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HLLAPIIsKeyboardUnlockedResponse> __BuildHLLAPIIsKeyboardUnlocked(WorkflowExpression<string> hLLAPIIsKeyboardUnlockedworkflow)
        {
            WorkflowExpression.Validate(hLLAPIIsKeyboardUnlockedworkflow, nameof(hLLAPIIsKeyboardUnlockedworkflow), required: true);
            return new DeferredBodyAction<HLLAPIIsKeyboardUnlockedResponse>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIIsKeyboardUnlocked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIIsKeyboardUnlocked = new JObject();
                var hLLAPIIsKeyboardUnlockedpropCount = 0;
                hLLAPIIsKeyboardUnlockedpropCount++;
                hLLAPIIsKeyboardUnlocked["Workflow"] = ExpressionConverter.ConvertO(hLLAPIIsKeyboardUnlockedworkflow);
                if (hLLAPIIsKeyboardUnlockedpropCount > 0)
                {
                    callPayload.Body = hLLAPIIsKeyboardUnlocked;
                }

                return new ApiConnectionAction<HLLAPIIsKeyboardUnlockedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPIWaitForKeyboardUnlocked))]
        public IBodyWorkflowAction<HLLAPIWaitForKeyboardUnlockedResponse> HLLAPIWaitForKeyboardUnlocked([WorkflowExpression] Func<double> hLLAPIWaitForKeyboardUnlockedsecondsToWait, [WorkflowExpression] Func<string> hLLAPIWaitForKeyboardUnlockedworkflow, [WorkflowExpression] Func<double> hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HLLAPIWaitForKeyboardUnlockedResponse> __BuildHLLAPIWaitForKeyboardUnlocked(WorkflowExpression<double> hLLAPIWaitForKeyboardUnlockedsecondsToWait, WorkflowExpression<string> hLLAPIWaitForKeyboardUnlockedworkflow, WorkflowExpression<double> hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait = null)
        {
            WorkflowExpression.Validate(hLLAPIWaitForKeyboardUnlockedsecondsToWait, nameof(hLLAPIWaitForKeyboardUnlockedsecondsToWait), required: true);
            WorkflowExpression.Validate(hLLAPIWaitForKeyboardUnlockedworkflow, nameof(hLLAPIWaitForKeyboardUnlockedworkflow), required: true);
            WorkflowExpression.Validate(hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait, nameof(hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait), required: false);
            return new DeferredBodyAction<HLLAPIWaitForKeyboardUnlockedResponse>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIWaitForKeyboardUnlocked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIWaitForKeyboardUnlocked = new JObject();
                var hLLAPIWaitForKeyboardUnlockedpropCount = 0;
                hLLAPIWaitForKeyboardUnlockedpropCount++;
                hLLAPIWaitForKeyboardUnlocked["SecondsToWait"] = ExpressionConverter.ConvertO(hLLAPIWaitForKeyboardUnlockedsecondsToWait);
                if (hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait != null)
                {
                    if (hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait != null)
                    {
                        hLLAPIWaitForKeyboardUnlocked["DeltaSecondsToWait"] = ExpressionConverter.ConvertO(hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait);
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
                hLLAPIWaitForKeyboardUnlocked["Workflow"] = ExpressionConverter.ConvertO(hLLAPIWaitForKeyboardUnlockedworkflow);
                if (hLLAPIWaitForKeyboardUnlockedpropCount > 0)
                {
                    callPayload.Body = hLLAPIWaitForKeyboardUnlocked;
                }

                return new ApiConnectionAction<HLLAPIWaitForKeyboardUnlockedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPIWaitForSystemReady))]
        public IBodyWorkflowAction<HLLAPIWaitForSystemReadyResponse> HLLAPIWaitForSystemReady([WorkflowExpression] Func<double> hLLAPIWaitForSystemReadysecondsToWait, [WorkflowExpression] Func<string> hLLAPIWaitForSystemReadyworkflow, [WorkflowExpression] Func<double> hLLAPIWaitForSystemReadydeltaSecondsToWait = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HLLAPIWaitForSystemReadyResponse> __BuildHLLAPIWaitForSystemReady(WorkflowExpression<double> hLLAPIWaitForSystemReadysecondsToWait, WorkflowExpression<string> hLLAPIWaitForSystemReadyworkflow, WorkflowExpression<double> hLLAPIWaitForSystemReadydeltaSecondsToWait = null)
        {
            WorkflowExpression.Validate(hLLAPIWaitForSystemReadysecondsToWait, nameof(hLLAPIWaitForSystemReadysecondsToWait), required: true);
            WorkflowExpression.Validate(hLLAPIWaitForSystemReadyworkflow, nameof(hLLAPIWaitForSystemReadyworkflow), required: true);
            WorkflowExpression.Validate(hLLAPIWaitForSystemReadydeltaSecondsToWait, nameof(hLLAPIWaitForSystemReadydeltaSecondsToWait), required: false);
            return new DeferredBodyAction<HLLAPIWaitForSystemReadyResponse>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIWaitForSystemReady";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIWaitForSystemReady = new JObject();
                var hLLAPIWaitForSystemReadypropCount = 0;
                hLLAPIWaitForSystemReadypropCount++;
                hLLAPIWaitForSystemReady["SecondsToWait"] = ExpressionConverter.ConvertO(hLLAPIWaitForSystemReadysecondsToWait);
                if (hLLAPIWaitForSystemReadydeltaSecondsToWait != null)
                {
                    if (hLLAPIWaitForSystemReadydeltaSecondsToWait != null)
                    {
                        hLLAPIWaitForSystemReady["DeltaSecondsToWait"] = ExpressionConverter.ConvertO(hLLAPIWaitForSystemReadydeltaSecondsToWait);
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
                hLLAPIWaitForSystemReady["Workflow"] = ExpressionConverter.ConvertO(hLLAPIWaitForSystemReadyworkflow);
                if (hLLAPIWaitForSystemReadypropCount > 0)
                {
                    callPayload.Body = hLLAPIWaitForSystemReady;
                }

                return new ApiConnectionAction<HLLAPIWaitForSystemReadyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPIPressReset))]
        public IWorkflowAction HLLAPIPressReset([WorkflowExpression] Func<string> hLLAPIPressResetworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildHLLAPIPressReset(WorkflowExpression<string> hLLAPIPressResetworkflow)
        {
            WorkflowExpression.Validate(hLLAPIPressResetworkflow, nameof(hLLAPIPressResetworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIPressReset";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIPressReset = new JObject();
                var hLLAPIPressResetpropCount = 0;
                hLLAPIPressResetpropCount++;
                hLLAPIPressReset["Workflow"] = ExpressionConverter.ConvertO(hLLAPIPressResetworkflow);
                if (hLLAPIPressResetpropCount > 0)
                {
                    callPayload.Body = hLLAPIPressReset;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPISearchForString))]
        public IBodyWorkflowAction<HLLAPISearchForStringResponse> HLLAPISearchForString([WorkflowExpression] Func<string> hLLAPISearchForStringsessionID, [WorkflowExpression] Func<string> hLLAPISearchForStringsearchString, [WorkflowExpression] Func<string> hLLAPISearchForStringworkflow, [WorkflowExpression] Func<bool> hLLAPISearchForStringsearchEntireScreen = null, [WorkflowExpression] Func<int> hLLAPISearchForStringsearchStartRowIndex = null, [WorkflowExpression] Func<int> hLLAPISearchForStringsearchStartColIndex = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HLLAPISearchForStringResponse> __BuildHLLAPISearchForString(WorkflowExpression<string> hLLAPISearchForStringsessionID, WorkflowExpression<string> hLLAPISearchForStringsearchString, WorkflowExpression<string> hLLAPISearchForStringworkflow, WorkflowExpression<bool> hLLAPISearchForStringsearchEntireScreen = null, WorkflowExpression<int> hLLAPISearchForStringsearchStartRowIndex = null, WorkflowExpression<int> hLLAPISearchForStringsearchStartColIndex = null)
        {
            WorkflowExpression.Validate(hLLAPISearchForStringsessionID, nameof(hLLAPISearchForStringsessionID), required: true);
            WorkflowExpression.Validate(hLLAPISearchForStringsearchString, nameof(hLLAPISearchForStringsearchString), required: true);
            WorkflowExpression.Validate(hLLAPISearchForStringworkflow, nameof(hLLAPISearchForStringworkflow), required: true);
            WorkflowExpression.Validate(hLLAPISearchForStringsearchEntireScreen, nameof(hLLAPISearchForStringsearchEntireScreen), required: false);
            WorkflowExpression.Validate(hLLAPISearchForStringsearchStartRowIndex, nameof(hLLAPISearchForStringsearchStartRowIndex), required: false);
            WorkflowExpression.Validate(hLLAPISearchForStringsearchStartColIndex, nameof(hLLAPISearchForStringsearchStartColIndex), required: false);
            return new DeferredBodyAction<HLLAPISearchForStringResponse>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISearchForString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISearchForString = new JObject();
                var hLLAPISearchForStringpropCount = 0;
                hLLAPISearchForStringpropCount++;
                hLLAPISearchForString["SessionID"] = ExpressionConverter.ConvertO(hLLAPISearchForStringsessionID);
                hLLAPISearchForStringpropCount++;
                hLLAPISearchForString["SearchString"] = ExpressionConverter.ConvertO(hLLAPISearchForStringsearchString);
                if (hLLAPISearchForStringsearchEntireScreen != null)
                {
                    if (hLLAPISearchForStringsearchEntireScreen != null)
                    {
                        hLLAPISearchForString["SearchEntireScreen"] = ExpressionConverter.ConvertO(hLLAPISearchForStringsearchEntireScreen);
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
                    hLLAPISearchForString["SearchStartRowIndex"] = ExpressionConverter.ConvertO(hLLAPISearchForStringsearchStartRowIndex);
                    hLLAPISearchForStringpropCount++;
                }

                if (hLLAPISearchForStringsearchStartColIndex != null)
                {
                    hLLAPISearchForString["SearchStartColIndex"] = ExpressionConverter.ConvertO(hLLAPISearchForStringsearchStartColIndex);
                    hLLAPISearchForStringpropCount++;
                }

                hLLAPISearchForStringpropCount++;
                hLLAPISearchForString["Workflow"] = ExpressionConverter.ConvertO(hLLAPISearchForStringworkflow);
                if (hLLAPISearchForStringpropCount > 0)
                {
                    callPayload.Body = hLLAPISearchForString;
                }

                return new ApiConnectionAction<HLLAPISearchForStringResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPIWaitForString))]
        public IBodyWorkflowAction<HLLAPIWaitForStringResponse> HLLAPIWaitForString([WorkflowExpression] Func<string> hLLAPIWaitForStringsessionID, [WorkflowExpression] Func<string> hLLAPIWaitForStringsearchString, [WorkflowExpression] Func<double> hLLAPIWaitForStringsecondsToWait, [WorkflowExpression] Func<string> hLLAPIWaitForStringworkflow, [WorkflowExpression] Func<bool> hLLAPIWaitForStringsearchEntireScreen = null, [WorkflowExpression] Func<int> hLLAPIWaitForStringsearchStartRowIndex = null, [WorkflowExpression] Func<int> hLLAPIWaitForStringsearchStartColIndex = null, [WorkflowExpression] Func<double> hLLAPIWaitForStringdeltaSecondsToWait = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HLLAPIWaitForStringResponse> __BuildHLLAPIWaitForString(WorkflowExpression<string> hLLAPIWaitForStringsessionID, WorkflowExpression<string> hLLAPIWaitForStringsearchString, WorkflowExpression<double> hLLAPIWaitForStringsecondsToWait, WorkflowExpression<string> hLLAPIWaitForStringworkflow, WorkflowExpression<bool> hLLAPIWaitForStringsearchEntireScreen = null, WorkflowExpression<int> hLLAPIWaitForStringsearchStartRowIndex = null, WorkflowExpression<int> hLLAPIWaitForStringsearchStartColIndex = null, WorkflowExpression<double> hLLAPIWaitForStringdeltaSecondsToWait = null)
        {
            WorkflowExpression.Validate(hLLAPIWaitForStringsessionID, nameof(hLLAPIWaitForStringsessionID), required: true);
            WorkflowExpression.Validate(hLLAPIWaitForStringsearchString, nameof(hLLAPIWaitForStringsearchString), required: true);
            WorkflowExpression.Validate(hLLAPIWaitForStringsecondsToWait, nameof(hLLAPIWaitForStringsecondsToWait), required: true);
            WorkflowExpression.Validate(hLLAPIWaitForStringworkflow, nameof(hLLAPIWaitForStringworkflow), required: true);
            WorkflowExpression.Validate(hLLAPIWaitForStringsearchEntireScreen, nameof(hLLAPIWaitForStringsearchEntireScreen), required: false);
            WorkflowExpression.Validate(hLLAPIWaitForStringsearchStartRowIndex, nameof(hLLAPIWaitForStringsearchStartRowIndex), required: false);
            WorkflowExpression.Validate(hLLAPIWaitForStringsearchStartColIndex, nameof(hLLAPIWaitForStringsearchStartColIndex), required: false);
            WorkflowExpression.Validate(hLLAPIWaitForStringdeltaSecondsToWait, nameof(hLLAPIWaitForStringdeltaSecondsToWait), required: false);
            return new DeferredBodyAction<HLLAPIWaitForStringResponse>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIWaitForString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIWaitForString = new JObject();
                var hLLAPIWaitForStringpropCount = 0;
                hLLAPIWaitForStringpropCount++;
                hLLAPIWaitForString["SessionID"] = ExpressionConverter.ConvertO(hLLAPIWaitForStringsessionID);
                hLLAPIWaitForStringpropCount++;
                hLLAPIWaitForString["SearchString"] = ExpressionConverter.ConvertO(hLLAPIWaitForStringsearchString);
                if (hLLAPIWaitForStringsearchEntireScreen != null)
                {
                    if (hLLAPIWaitForStringsearchEntireScreen != null)
                    {
                        hLLAPIWaitForString["SearchEntireScreen"] = ExpressionConverter.ConvertO(hLLAPIWaitForStringsearchEntireScreen);
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
                    hLLAPIWaitForString["SearchStartRowIndex"] = ExpressionConverter.ConvertO(hLLAPIWaitForStringsearchStartRowIndex);
                    hLLAPIWaitForStringpropCount++;
                }

                if (hLLAPIWaitForStringsearchStartColIndex != null)
                {
                    hLLAPIWaitForString["SearchStartColIndex"] = ExpressionConverter.ConvertO(hLLAPIWaitForStringsearchStartColIndex);
                    hLLAPIWaitForStringpropCount++;
                }

                hLLAPIWaitForStringpropCount++;
                hLLAPIWaitForString["SecondsToWait"] = ExpressionConverter.ConvertO(hLLAPIWaitForStringsecondsToWait);
                if (hLLAPIWaitForStringdeltaSecondsToWait != null)
                {
                    if (hLLAPIWaitForStringdeltaSecondsToWait != null)
                    {
                        hLLAPIWaitForString["DeltaSecondsToWait"] = ExpressionConverter.ConvertO(hLLAPIWaitForStringdeltaSecondsToWait);
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
                hLLAPIWaitForString["Workflow"] = ExpressionConverter.ConvertO(hLLAPIWaitForStringworkflow);
                if (hLLAPIWaitForStringpropCount > 0)
                {
                    callPayload.Body = hLLAPIWaitForString;
                }

                return new ApiConnectionAction<HLLAPIWaitForStringResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPISetSessionParameter))]
        public IWorkflowAction HLLAPISetSessionParameter([WorkflowExpression] Func<string> hLLAPISetSessionParameterparameter, [WorkflowExpression] Func<string> hLLAPISetSessionParameterworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildHLLAPISetSessionParameter(WorkflowExpression<string> hLLAPISetSessionParameterparameter, WorkflowExpression<string> hLLAPISetSessionParameterworkflow)
        {
            WorkflowExpression.Validate(hLLAPISetSessionParameterparameter, nameof(hLLAPISetSessionParameterparameter), required: true);
            WorkflowExpression.Validate(hLLAPISetSessionParameterworkflow, nameof(hLLAPISetSessionParameterworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISetSessionParameter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISetSessionParameter = new JObject();
                var hLLAPISetSessionParameterpropCount = 0;
                hLLAPISetSessionParameterpropCount++;
                hLLAPISetSessionParameter["Parameter"] = ExpressionConverter.ConvertO(hLLAPISetSessionParameterparameter);
                hLLAPISetSessionParameterpropCount++;
                hLLAPISetSessionParameter["Workflow"] = ExpressionConverter.ConvertO(hLLAPISetSessionParameterworkflow);
                if (hLLAPISetSessionParameterpropCount > 0)
                {
                    callPayload.Body = hLLAPISetSessionParameter;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPIResetSystem))]
        public IWorkflowAction HLLAPIResetSystem([WorkflowExpression] Func<string> hLLAPIResetSystemworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildHLLAPIResetSystem(WorkflowExpression<string> hLLAPIResetSystemworkflow)
        {
            WorkflowExpression.Validate(hLLAPIResetSystemworkflow, nameof(hLLAPIResetSystemworkflow), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIResetSystem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIResetSystem = new JObject();
                var hLLAPIResetSystempropCount = 0;
                hLLAPIResetSystempropCount++;
                hLLAPIResetSystem["Workflow"] = ExpressionConverter.ConvertO(hLLAPIResetSystemworkflow);
                if (hLLAPIResetSystempropCount > 0)
                {
                    callPayload.Body = hLLAPIResetSystem;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [WorkflowExpressionFactory(nameof(__BuildHLLAPICopyOperatorInformationArea))]
        public IBodyWorkflowAction<HLLAPICopyOperatorInformationAreaResponse> HLLAPICopyOperatorInformationArea([WorkflowExpression] Func<string> hLLAPICopyOperatorInformationAreaworkflow)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<HLLAPICopyOperatorInformationAreaResponse> __BuildHLLAPICopyOperatorInformationArea(WorkflowExpression<string> hLLAPICopyOperatorInformationAreaworkflow)
        {
            WorkflowExpression.Validate(hLLAPICopyOperatorInformationAreaworkflow, nameof(hLLAPICopyOperatorInformationAreaworkflow), required: true);
            return new DeferredBodyAction<HLLAPICopyOperatorInformationAreaResponse>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPICopyOperatorInformationArea";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPICopyOperatorInformationArea = new JObject();
                var hLLAPICopyOperatorInformationAreapropCount = 0;
                hLLAPICopyOperatorInformationAreapropCount++;
                hLLAPICopyOperatorInformationArea["Workflow"] = ExpressionConverter.ConvertO(hLLAPICopyOperatorInformationAreaworkflow);
                if (hLLAPICopyOperatorInformationAreapropCount > 0)
                {
                    callPayload.Body = hLLAPICopyOperatorInformationArea;
                }

                return new ApiConnectionAction<HLLAPICopyOperatorInformationAreaResponse>(callPayload);
            });
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