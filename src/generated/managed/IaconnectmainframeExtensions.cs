//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectmainframe
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectmainframeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPISetHLLAPIdLL(Expression<Func<string>> hLLAPISetHLLAPIdLLdLLFilename, Expression<Func<string>> hLLAPISetHLLAPIdLLworkflow, Expression<Func<string>> hLLAPISetHLLAPIdLLiAHLLAPIPath = null, Expression<Func<string>> hLLAPISetHLLAPIdLLentryPointName = null, Expression<Func<bool>> hLLAPISetHLLAPIdLLisEnhancedInterface = null, Expression<Func<bool>> hLLAPISetHLLAPIdLLis64BitHLLAPIdLL = null, Expression<Func<bool>> hLLAPISetHLLAPIdLLuseCOMFor64BitHLLAPIdLL = null)
        {
            var __workflow_hLLAPISetHLLAPIdLLdLLFilename = WorkflowExpression.Compile(hLLAPISetHLLAPIdLLdLLFilename, nameof(hLLAPISetHLLAPIdLLdLLFilename), required: true);
            var __workflow_hLLAPISetHLLAPIdLLworkflow = WorkflowExpression.Compile(hLLAPISetHLLAPIdLLworkflow, nameof(hLLAPISetHLLAPIdLLworkflow), required: true);
            var __workflow_hLLAPISetHLLAPIdLLiAHLLAPIPath = WorkflowExpression.Compile(hLLAPISetHLLAPIdLLiAHLLAPIPath, nameof(hLLAPISetHLLAPIdLLiAHLLAPIPath), required: false);
            var __workflow_hLLAPISetHLLAPIdLLentryPointName = WorkflowExpression.Compile(hLLAPISetHLLAPIdLLentryPointName, nameof(hLLAPISetHLLAPIdLLentryPointName), required: false);
            var __workflow_hLLAPISetHLLAPIdLLisEnhancedInterface = WorkflowExpression.Compile(hLLAPISetHLLAPIdLLisEnhancedInterface, nameof(hLLAPISetHLLAPIdLLisEnhancedInterface), required: false);
            var __workflow_hLLAPISetHLLAPIdLLis64BitHLLAPIdLL = WorkflowExpression.Compile(hLLAPISetHLLAPIdLLis64BitHLLAPIdLL, nameof(hLLAPISetHLLAPIdLLis64BitHLLAPIdLL), required: false);
            var __workflow_hLLAPISetHLLAPIdLLuseCOMFor64BitHLLAPIdLL = WorkflowExpression.Compile(hLLAPISetHLLAPIdLLuseCOMFor64BitHLLAPIdLL, nameof(hLLAPISetHLLAPIdLLuseCOMFor64BitHLLAPIdLL), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISetHLLAPIDLL";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISetHLLAPIdLL = new JObject();
                var hLLAPISetHLLAPIdLLpropCount = 0;
                hLLAPISetHLLAPIdLLpropCount++;
                hLLAPISetHLLAPIdLL["DLLFilename"] = ExpressionConverter.ConvertO(__workflow_hLLAPISetHLLAPIdLLdLLFilename);
                if (__workflow_hLLAPISetHLLAPIdLLiAHLLAPIPath != null)
                {
                    hLLAPISetHLLAPIdLL["IAHLLAPIPath"] = ExpressionConverter.ConvertO(__workflow_hLLAPISetHLLAPIdLLiAHLLAPIPath);
                    hLLAPISetHLLAPIdLLpropCount++;
                }

                if (__workflow_hLLAPISetHLLAPIdLLentryPointName != null)
                {
                    hLLAPISetHLLAPIdLL["EntryPointName"] = ExpressionConverter.ConvertO(__workflow_hLLAPISetHLLAPIdLLentryPointName);
                    hLLAPISetHLLAPIdLLpropCount++;
                }

                if (__workflow_hLLAPISetHLLAPIdLLisEnhancedInterface != null)
                {
                    if (__workflow_hLLAPISetHLLAPIdLLisEnhancedInterface != null)
                    {
                        hLLAPISetHLLAPIdLL["IsEnhancedInterface"] = ExpressionConverter.ConvertO(__workflow_hLLAPISetHLLAPIdLLisEnhancedInterface);
                        hLLAPISetHLLAPIdLLpropCount++;
                    }

                    hLLAPISetHLLAPIdLLpropCount++;
                }
                else
                {
                    hLLAPISetHLLAPIdLL["IsEnhancedInterface"] = false;
                    hLLAPISetHLLAPIdLLpropCount++;
                }

                if (__workflow_hLLAPISetHLLAPIdLLis64BitHLLAPIdLL != null)
                {
                    if (__workflow_hLLAPISetHLLAPIdLLis64BitHLLAPIdLL != null)
                    {
                        hLLAPISetHLLAPIdLL["Is64BitHLLAPIDLL"] = ExpressionConverter.ConvertO(__workflow_hLLAPISetHLLAPIdLLis64BitHLLAPIdLL);
                        hLLAPISetHLLAPIdLLpropCount++;
                    }

                    hLLAPISetHLLAPIdLLpropCount++;
                }
                else
                {
                    hLLAPISetHLLAPIdLL["Is64BitHLLAPIDLL"] = false;
                    hLLAPISetHLLAPIdLLpropCount++;
                }

                if (__workflow_hLLAPISetHLLAPIdLLuseCOMFor64BitHLLAPIdLL != null)
                {
                    if (__workflow_hLLAPISetHLLAPIdLLuseCOMFor64BitHLLAPIdLL != null)
                    {
                        hLLAPISetHLLAPIdLL["UseCOMFor64BitHLLAPIDLL"] = ExpressionConverter.ConvertO(__workflow_hLLAPISetHLLAPIdLLuseCOMFor64BitHLLAPIdLL);
                        hLLAPISetHLLAPIdLLpropCount++;
                    }

                    hLLAPISetHLLAPIdLLpropCount++;
                }
                else
                {
                    hLLAPISetHLLAPIdLL["UseCOMFor64BitHLLAPIDLL"] = false;
                    hLLAPISetHLLAPIdLLpropCount++;
                }

                hLLAPISetHLLAPIdLLpropCount++;
                hLLAPISetHLLAPIdLL["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPISetHLLAPIdLLworkflow);
                if (hLLAPISetHLLAPIdLLpropCount > 0)
                {
                    callPayload.Body = hLLAPISetHLLAPIdLL;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPIDispose(Expression<Func<string>> hLLAPIDisposeworkflow)
        {
            var __workflow_hLLAPIDisposeworkflow = WorkflowExpression.Compile(hLLAPIDisposeworkflow, nameof(hLLAPIDisposeworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIDispose";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIDispose = new JObject();
                var hLLAPIDisposepropCount = 0;
                hLLAPIDisposepropCount++;
                hLLAPIDispose["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPIDisposeworkflow);
                if (hLLAPIDisposepropCount > 0)
                {
                    callPayload.Body = hLLAPIDispose;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPIConnect(Expression<Func<string>> hLLAPIConnectsessionId, Expression<Func<string>> hLLAPIConnectworkflow)
        {
            var __workflow_hLLAPIConnectsessionId = WorkflowExpression.Compile(hLLAPIConnectsessionId, nameof(hLLAPIConnectsessionId), required: true);
            var __workflow_hLLAPIConnectworkflow = WorkflowExpression.Compile(hLLAPIConnectworkflow, nameof(hLLAPIConnectworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIConnect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIConnect = new JObject();
                var hLLAPIConnectpropCount = 0;
                hLLAPIConnectpropCount++;
                hLLAPIConnect["SessionID"] = ExpressionConverter.ConvertO(__workflow_hLLAPIConnectsessionId);
                hLLAPIConnectpropCount++;
                hLLAPIConnect["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPIConnectworkflow);
                if (hLLAPIConnectpropCount > 0)
                {
                    callPayload.Body = hLLAPIConnect;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIGetConnectStatusResponse, ApiConnectionActionConfiguration> HLLAPIGetConnectStatus(Expression<Func<string>> hLLAPIGetConnectStatussessionId, Expression<Func<string>> hLLAPIGetConnectStatusworkflow)
        {
            var __workflow_hLLAPIGetConnectStatussessionId = WorkflowExpression.Compile(hLLAPIGetConnectStatussessionId, nameof(hLLAPIGetConnectStatussessionId), required: true);
            var __workflow_hLLAPIGetConnectStatusworkflow = WorkflowExpression.Compile(hLLAPIGetConnectStatusworkflow, nameof(hLLAPIGetConnectStatusworkflow), required: true);
            return new DeferredBodyAction<HLLAPIGetConnectStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIGetConnectStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIGetConnectStatus = new JObject();
                var hLLAPIGetConnectStatuspropCount = 0;
                hLLAPIGetConnectStatuspropCount++;
                hLLAPIGetConnectStatus["SessionID"] = ExpressionConverter.ConvertO(__workflow_hLLAPIGetConnectStatussessionId);
                hLLAPIGetConnectStatuspropCount++;
                hLLAPIGetConnectStatus["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPIGetConnectStatusworkflow);
                if (hLLAPIGetConnectStatuspropCount > 0)
                {
                    callPayload.Body = hLLAPIGetConnectStatus;
                }

                return new ApiConnectionAction<HLLAPIGetConnectStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPIDisconnect(Expression<Func<string>> hLLAPIDisconnectsessionId, Expression<Func<string>> hLLAPIDisconnectworkflow)
        {
            var __workflow_hLLAPIDisconnectsessionId = WorkflowExpression.Compile(hLLAPIDisconnectsessionId, nameof(hLLAPIDisconnectsessionId), required: true);
            var __workflow_hLLAPIDisconnectworkflow = WorkflowExpression.Compile(hLLAPIDisconnectworkflow, nameof(hLLAPIDisconnectworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIDisconnect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIDisconnect = new JObject();
                var hLLAPIDisconnectpropCount = 0;
                hLLAPIDisconnectpropCount++;
                hLLAPIDisconnect["SessionID"] = ExpressionConverter.ConvertO(__workflow_hLLAPIDisconnectsessionId);
                hLLAPIDisconnectpropCount++;
                hLLAPIDisconnect["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPIDisconnectworkflow);
                if (hLLAPIDisconnectpropCount > 0)
                {
                    callPayload.Body = hLLAPIDisconnect;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPISetCursorPos(Expression<Func<string>> hLLAPISetCursorPossessionId, Expression<Func<int>> hLLAPISetCursorPoscursorRowIndex, Expression<Func<int>> hLLAPISetCursorPoscursorColIndex, Expression<Func<string>> hLLAPISetCursorPosworkflow)
        {
            var __workflow_hLLAPISetCursorPossessionId = WorkflowExpression.Compile(hLLAPISetCursorPossessionId, nameof(hLLAPISetCursorPossessionId), required: true);
            var __workflow_hLLAPISetCursorPoscursorRowIndex = WorkflowExpression.Compile(hLLAPISetCursorPoscursorRowIndex, nameof(hLLAPISetCursorPoscursorRowIndex), required: true);
            var __workflow_hLLAPISetCursorPoscursorColIndex = WorkflowExpression.Compile(hLLAPISetCursorPoscursorColIndex, nameof(hLLAPISetCursorPoscursorColIndex), required: true);
            var __workflow_hLLAPISetCursorPosworkflow = WorkflowExpression.Compile(hLLAPISetCursorPosworkflow, nameof(hLLAPISetCursorPosworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISetCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISetCursorPos = new JObject();
                var hLLAPISetCursorPospropCount = 0;
                hLLAPISetCursorPospropCount++;
                hLLAPISetCursorPos["SessionID"] = ExpressionConverter.ConvertO(__workflow_hLLAPISetCursorPossessionId);
                hLLAPISetCursorPospropCount++;
                hLLAPISetCursorPos["CursorRowIndex"] = ExpressionConverter.ConvertO(__workflow_hLLAPISetCursorPoscursorRowIndex);
                hLLAPISetCursorPospropCount++;
                hLLAPISetCursorPos["CursorColIndex"] = ExpressionConverter.ConvertO(__workflow_hLLAPISetCursorPoscursorColIndex);
                hLLAPISetCursorPospropCount++;
                hLLAPISetCursorPos["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPISetCursorPosworkflow);
                if (hLLAPISetCursorPospropCount > 0)
                {
                    callPayload.Body = hLLAPISetCursorPos;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIGetCursorPosResponse, ApiConnectionActionConfiguration> HLLAPIGetCursorPos(Expression<Func<string>> hLLAPIGetCursorPossessionId, Expression<Func<string>> hLLAPIGetCursorPosworkflow)
        {
            var __workflow_hLLAPIGetCursorPossessionId = WorkflowExpression.Compile(hLLAPIGetCursorPossessionId, nameof(hLLAPIGetCursorPossessionId), required: true);
            var __workflow_hLLAPIGetCursorPosworkflow = WorkflowExpression.Compile(hLLAPIGetCursorPosworkflow, nameof(hLLAPIGetCursorPosworkflow), required: true);
            return new DeferredBodyAction<HLLAPIGetCursorPosResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIGetCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIGetCursorPos = new JObject();
                var hLLAPIGetCursorPospropCount = 0;
                hLLAPIGetCursorPospropCount++;
                hLLAPIGetCursorPos["SessionID"] = ExpressionConverter.ConvertO(__workflow_hLLAPIGetCursorPossessionId);
                hLLAPIGetCursorPospropCount++;
                hLLAPIGetCursorPos["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPIGetCursorPosworkflow);
                if (hLLAPIGetCursorPospropCount > 0)
                {
                    callPayload.Body = hLLAPIGetCursorPos;
                }

                return new ApiConnectionAction<HLLAPIGetCursorPosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPISendString(Expression<Func<string>> hLLAPISendStringinputString, Expression<Func<string>> hLLAPISendStringworkflow)
        {
            var __workflow_hLLAPISendStringinputString = WorkflowExpression.Compile(hLLAPISendStringinputString, nameof(hLLAPISendStringinputString), required: true);
            var __workflow_hLLAPISendStringworkflow = WorkflowExpression.Compile(hLLAPISendStringworkflow, nameof(hLLAPISendStringworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISendString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISendString = new JObject();
                var hLLAPISendStringpropCount = 0;
                hLLAPISendStringpropCount++;
                hLLAPISendString["InputString"] = ExpressionConverter.ConvertO(__workflow_hLLAPISendStringinputString);
                hLLAPISendStringpropCount++;
                hLLAPISendString["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPISendStringworkflow);
                if (hLLAPISendStringpropCount > 0)
                {
                    callPayload.Body = hLLAPISendString;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPISendPassword(Expression<Func<string>> hLLAPISendPasswordinputPassword, Expression<Func<string>> hLLAPISendPasswordworkflow)
        {
            var __workflow_hLLAPISendPasswordinputPassword = WorkflowExpression.Compile(hLLAPISendPasswordinputPassword, nameof(hLLAPISendPasswordinputPassword), required: true);
            var __workflow_hLLAPISendPasswordworkflow = WorkflowExpression.Compile(hLLAPISendPasswordworkflow, nameof(hLLAPISendPasswordworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISendPassword";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISendPassword = new JObject();
                var hLLAPISendPasswordpropCount = 0;
                hLLAPISendPasswordpropCount++;
                hLLAPISendPassword["InputPassword"] = ExpressionConverter.ConvertO(__workflow_hLLAPISendPasswordinputPassword);
                hLLAPISendPasswordpropCount++;
                hLLAPISendPassword["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPISendPasswordworkflow);
                if (hLLAPISendPasswordpropCount > 0)
                {
                    callPayload.Body = hLLAPISendPassword;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPISendStringAtCursorPos(Expression<Func<string>> hLLAPISendStringAtCursorPossessionId, Expression<Func<int>> hLLAPISendStringAtCursorPoscursorRowIndex, Expression<Func<int>> hLLAPISendStringAtCursorPoscursorColIndex, Expression<Func<string>> hLLAPISendStringAtCursorPosinputString, Expression<Func<string>> hLLAPISendStringAtCursorPosworkflow)
        {
            var __workflow_hLLAPISendStringAtCursorPossessionId = WorkflowExpression.Compile(hLLAPISendStringAtCursorPossessionId, nameof(hLLAPISendStringAtCursorPossessionId), required: true);
            var __workflow_hLLAPISendStringAtCursorPoscursorRowIndex = WorkflowExpression.Compile(hLLAPISendStringAtCursorPoscursorRowIndex, nameof(hLLAPISendStringAtCursorPoscursorRowIndex), required: true);
            var __workflow_hLLAPISendStringAtCursorPoscursorColIndex = WorkflowExpression.Compile(hLLAPISendStringAtCursorPoscursorColIndex, nameof(hLLAPISendStringAtCursorPoscursorColIndex), required: true);
            var __workflow_hLLAPISendStringAtCursorPosinputString = WorkflowExpression.Compile(hLLAPISendStringAtCursorPosinputString, nameof(hLLAPISendStringAtCursorPosinputString), required: true);
            var __workflow_hLLAPISendStringAtCursorPosworkflow = WorkflowExpression.Compile(hLLAPISendStringAtCursorPosworkflow, nameof(hLLAPISendStringAtCursorPosworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISendStringAtCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISendStringAtCursorPos = new JObject();
                var hLLAPISendStringAtCursorPospropCount = 0;
                hLLAPISendStringAtCursorPospropCount++;
                hLLAPISendStringAtCursorPos["SessionID"] = ExpressionConverter.ConvertO(__workflow_hLLAPISendStringAtCursorPossessionId);
                hLLAPISendStringAtCursorPospropCount++;
                hLLAPISendStringAtCursorPos["CursorRowIndex"] = ExpressionConverter.ConvertO(__workflow_hLLAPISendStringAtCursorPoscursorRowIndex);
                hLLAPISendStringAtCursorPospropCount++;
                hLLAPISendStringAtCursorPos["CursorColIndex"] = ExpressionConverter.ConvertO(__workflow_hLLAPISendStringAtCursorPoscursorColIndex);
                hLLAPISendStringAtCursorPospropCount++;
                hLLAPISendStringAtCursorPos["InputString"] = ExpressionConverter.ConvertO(__workflow_hLLAPISendStringAtCursorPosinputString);
                hLLAPISendStringAtCursorPospropCount++;
                hLLAPISendStringAtCursorPos["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPISendStringAtCursorPosworkflow);
                if (hLLAPISendStringAtCursorPospropCount > 0)
                {
                    callPayload.Body = hLLAPISendStringAtCursorPos;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPISendPasswordAtCursorPos(Expression<Func<string>> hLLAPISendPasswordAtCursorPossessionId, Expression<Func<int>> hLLAPISendPasswordAtCursorPoscursorRowIndex, Expression<Func<int>> hLLAPISendPasswordAtCursorPoscursorColIndex, Expression<Func<string>> hLLAPISendPasswordAtCursorPosinputPassword, Expression<Func<string>> hLLAPISendPasswordAtCursorPosworkflow)
        {
            var __workflow_hLLAPISendPasswordAtCursorPossessionId = WorkflowExpression.Compile(hLLAPISendPasswordAtCursorPossessionId, nameof(hLLAPISendPasswordAtCursorPossessionId), required: true);
            var __workflow_hLLAPISendPasswordAtCursorPoscursorRowIndex = WorkflowExpression.Compile(hLLAPISendPasswordAtCursorPoscursorRowIndex, nameof(hLLAPISendPasswordAtCursorPoscursorRowIndex), required: true);
            var __workflow_hLLAPISendPasswordAtCursorPoscursorColIndex = WorkflowExpression.Compile(hLLAPISendPasswordAtCursorPoscursorColIndex, nameof(hLLAPISendPasswordAtCursorPoscursorColIndex), required: true);
            var __workflow_hLLAPISendPasswordAtCursorPosinputPassword = WorkflowExpression.Compile(hLLAPISendPasswordAtCursorPosinputPassword, nameof(hLLAPISendPasswordAtCursorPosinputPassword), required: true);
            var __workflow_hLLAPISendPasswordAtCursorPosworkflow = WorkflowExpression.Compile(hLLAPISendPasswordAtCursorPosworkflow, nameof(hLLAPISendPasswordAtCursorPosworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISendPasswordAtCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISendPasswordAtCursorPos = new JObject();
                var hLLAPISendPasswordAtCursorPospropCount = 0;
                hLLAPISendPasswordAtCursorPospropCount++;
                hLLAPISendPasswordAtCursorPos["SessionID"] = ExpressionConverter.ConvertO(__workflow_hLLAPISendPasswordAtCursorPossessionId);
                hLLAPISendPasswordAtCursorPospropCount++;
                hLLAPISendPasswordAtCursorPos["CursorRowIndex"] = ExpressionConverter.ConvertO(__workflow_hLLAPISendPasswordAtCursorPoscursorRowIndex);
                hLLAPISendPasswordAtCursorPospropCount++;
                hLLAPISendPasswordAtCursorPos["CursorColIndex"] = ExpressionConverter.ConvertO(__workflow_hLLAPISendPasswordAtCursorPoscursorColIndex);
                hLLAPISendPasswordAtCursorPospropCount++;
                hLLAPISendPasswordAtCursorPos["InputPassword"] = ExpressionConverter.ConvertO(__workflow_hLLAPISendPasswordAtCursorPosinputPassword);
                hLLAPISendPasswordAtCursorPospropCount++;
                hLLAPISendPasswordAtCursorPos["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPISendPasswordAtCursorPosworkflow);
                if (hLLAPISendPasswordAtCursorPospropCount > 0)
                {
                    callPayload.Body = hLLAPISendPasswordAtCursorPos;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIReadScreenAtCursorPosResponse, ApiConnectionActionConfiguration> HLLAPIReadScreenAtCursorPos(Expression<Func<string>> hLLAPIReadScreenAtCursorPossessionId, Expression<Func<int>> hLLAPIReadScreenAtCursorPoscursorRowIndex, Expression<Func<int>> hLLAPIReadScreenAtCursorPoscursorColIndex, Expression<Func<int>> hLLAPIReadScreenAtCursorPosreadScreenLength, Expression<Func<string>> hLLAPIReadScreenAtCursorPosworkflow)
        {
            var __workflow_hLLAPIReadScreenAtCursorPossessionId = WorkflowExpression.Compile(hLLAPIReadScreenAtCursorPossessionId, nameof(hLLAPIReadScreenAtCursorPossessionId), required: true);
            var __workflow_hLLAPIReadScreenAtCursorPoscursorRowIndex = WorkflowExpression.Compile(hLLAPIReadScreenAtCursorPoscursorRowIndex, nameof(hLLAPIReadScreenAtCursorPoscursorRowIndex), required: true);
            var __workflow_hLLAPIReadScreenAtCursorPoscursorColIndex = WorkflowExpression.Compile(hLLAPIReadScreenAtCursorPoscursorColIndex, nameof(hLLAPIReadScreenAtCursorPoscursorColIndex), required: true);
            var __workflow_hLLAPIReadScreenAtCursorPosreadScreenLength = WorkflowExpression.Compile(hLLAPIReadScreenAtCursorPosreadScreenLength, nameof(hLLAPIReadScreenAtCursorPosreadScreenLength), required: true);
            var __workflow_hLLAPIReadScreenAtCursorPosworkflow = WorkflowExpression.Compile(hLLAPIReadScreenAtCursorPosworkflow, nameof(hLLAPIReadScreenAtCursorPosworkflow), required: true);
            return new DeferredBodyAction<HLLAPIReadScreenAtCursorPosResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIReadScreenAtCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIReadScreenAtCursorPos = new JObject();
                var hLLAPIReadScreenAtCursorPospropCount = 0;
                hLLAPIReadScreenAtCursorPospropCount++;
                hLLAPIReadScreenAtCursorPos["SessionID"] = ExpressionConverter.ConvertO(__workflow_hLLAPIReadScreenAtCursorPossessionId);
                hLLAPIReadScreenAtCursorPospropCount++;
                hLLAPIReadScreenAtCursorPos["CursorRowIndex"] = ExpressionConverter.ConvertO(__workflow_hLLAPIReadScreenAtCursorPoscursorRowIndex);
                hLLAPIReadScreenAtCursorPospropCount++;
                hLLAPIReadScreenAtCursorPos["CursorColIndex"] = ExpressionConverter.ConvertO(__workflow_hLLAPIReadScreenAtCursorPoscursorColIndex);
                hLLAPIReadScreenAtCursorPospropCount++;
                hLLAPIReadScreenAtCursorPos["ReadScreenLength"] = ExpressionConverter.ConvertO(__workflow_hLLAPIReadScreenAtCursorPosreadScreenLength);
                hLLAPIReadScreenAtCursorPospropCount++;
                hLLAPIReadScreenAtCursorPos["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPIReadScreenAtCursorPosworkflow);
                if (hLLAPIReadScreenAtCursorPospropCount > 0)
                {
                    callPayload.Body = hLLAPIReadScreenAtCursorPos;
                }

                return new ApiConnectionAction<HLLAPIReadScreenAtCursorPosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIQuerySessionStatusResponse, ApiConnectionActionConfiguration> HLLAPIQuerySessionStatus(Expression<Func<string>> hLLAPIQuerySessionStatusworkflow)
        {
            var __workflow_hLLAPIQuerySessionStatusworkflow = WorkflowExpression.Compile(hLLAPIQuerySessionStatusworkflow, nameof(hLLAPIQuerySessionStatusworkflow), required: true);
            return new DeferredBodyAction<HLLAPIQuerySessionStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIQuerySessionStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIQuerySessionStatus = new JObject();
                var hLLAPIQuerySessionStatuspropCount = 0;
                hLLAPIQuerySessionStatuspropCount++;
                hLLAPIQuerySessionStatus["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPIQuerySessionStatusworkflow);
                if (hLLAPIQuerySessionStatuspropCount > 0)
                {
                    callPayload.Body = hLLAPIQuerySessionStatus;
                }

                return new ApiConnectionAction<HLLAPIQuerySessionStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIReadScreenRowsResponse, ApiConnectionActionConfiguration> HLLAPIReadScreenRows(Expression<Func<string>> hLLAPIReadScreenRowssessionId, Expression<Func<int>> hLLAPIReadScreenRowsstartRowIndex, Expression<Func<int>> hLLAPIReadScreenRowsendRowIndex, Expression<Func<string>> hLLAPIReadScreenRowsworkflow, Expression<Func<int>> hLLAPIReadScreenRowsnumberOfRowsInSession = null, Expression<Func<int>> hLLAPIReadScreenRowsnumberOfColumnsInSession = null)
        {
            var __workflow_hLLAPIReadScreenRowssessionId = WorkflowExpression.Compile(hLLAPIReadScreenRowssessionId, nameof(hLLAPIReadScreenRowssessionId), required: true);
            var __workflow_hLLAPIReadScreenRowsstartRowIndex = WorkflowExpression.Compile(hLLAPIReadScreenRowsstartRowIndex, nameof(hLLAPIReadScreenRowsstartRowIndex), required: true);
            var __workflow_hLLAPIReadScreenRowsendRowIndex = WorkflowExpression.Compile(hLLAPIReadScreenRowsendRowIndex, nameof(hLLAPIReadScreenRowsendRowIndex), required: true);
            var __workflow_hLLAPIReadScreenRowsworkflow = WorkflowExpression.Compile(hLLAPIReadScreenRowsworkflow, nameof(hLLAPIReadScreenRowsworkflow), required: true);
            var __workflow_hLLAPIReadScreenRowsnumberOfRowsInSession = WorkflowExpression.Compile(hLLAPIReadScreenRowsnumberOfRowsInSession, nameof(hLLAPIReadScreenRowsnumberOfRowsInSession), required: false);
            var __workflow_hLLAPIReadScreenRowsnumberOfColumnsInSession = WorkflowExpression.Compile(hLLAPIReadScreenRowsnumberOfColumnsInSession, nameof(hLLAPIReadScreenRowsnumberOfColumnsInSession), required: false);
            return new DeferredBodyAction<HLLAPIReadScreenRowsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIReadScreenRows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIReadScreenRows = new JObject();
                var hLLAPIReadScreenRowspropCount = 0;
                hLLAPIReadScreenRowspropCount++;
                hLLAPIReadScreenRows["SessionID"] = ExpressionConverter.ConvertO(__workflow_hLLAPIReadScreenRowssessionId);
                hLLAPIReadScreenRowspropCount++;
                hLLAPIReadScreenRows["StartRowIndex"] = ExpressionConverter.ConvertO(__workflow_hLLAPIReadScreenRowsstartRowIndex);
                hLLAPIReadScreenRowspropCount++;
                hLLAPIReadScreenRows["EndRowIndex"] = ExpressionConverter.ConvertO(__workflow_hLLAPIReadScreenRowsendRowIndex);
                if (__workflow_hLLAPIReadScreenRowsnumberOfRowsInSession != null)
                {
                    hLLAPIReadScreenRows["NumberOfRowsInSession"] = ExpressionConverter.ConvertO(__workflow_hLLAPIReadScreenRowsnumberOfRowsInSession);
                    hLLAPIReadScreenRowspropCount++;
                }

                if (__workflow_hLLAPIReadScreenRowsnumberOfColumnsInSession != null)
                {
                    hLLAPIReadScreenRows["NumberOfColumnsInSession"] = ExpressionConverter.ConvertO(__workflow_hLLAPIReadScreenRowsnumberOfColumnsInSession);
                    hLLAPIReadScreenRowspropCount++;
                }

                hLLAPIReadScreenRowspropCount++;
                hLLAPIReadScreenRows["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPIReadScreenRowsworkflow);
                if (hLLAPIReadScreenRowspropCount > 0)
                {
                    callPayload.Body = hLLAPIReadScreenRows;
                }

                return new ApiConnectionAction<HLLAPIReadScreenRowsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIIsKeyboardUnlockedResponse, ApiConnectionActionConfiguration> HLLAPIIsKeyboardUnlocked(Expression<Func<string>> hLLAPIIsKeyboardUnlockedworkflow)
        {
            var __workflow_hLLAPIIsKeyboardUnlockedworkflow = WorkflowExpression.Compile(hLLAPIIsKeyboardUnlockedworkflow, nameof(hLLAPIIsKeyboardUnlockedworkflow), required: true);
            return new DeferredBodyAction<HLLAPIIsKeyboardUnlockedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIIsKeyboardUnlocked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIIsKeyboardUnlocked = new JObject();
                var hLLAPIIsKeyboardUnlockedpropCount = 0;
                hLLAPIIsKeyboardUnlockedpropCount++;
                hLLAPIIsKeyboardUnlocked["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPIIsKeyboardUnlockedworkflow);
                if (hLLAPIIsKeyboardUnlockedpropCount > 0)
                {
                    callPayload.Body = hLLAPIIsKeyboardUnlocked;
                }

                return new ApiConnectionAction<HLLAPIIsKeyboardUnlockedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIWaitForKeyboardUnlockedResponse, ApiConnectionActionConfiguration> HLLAPIWaitForKeyboardUnlocked(Expression<Func<double>> hLLAPIWaitForKeyboardUnlockedsecondsToWait, Expression<Func<string>> hLLAPIWaitForKeyboardUnlockedworkflow, Expression<Func<double>> hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait = null)
        {
            var __workflow_hLLAPIWaitForKeyboardUnlockedsecondsToWait = WorkflowExpression.Compile(hLLAPIWaitForKeyboardUnlockedsecondsToWait, nameof(hLLAPIWaitForKeyboardUnlockedsecondsToWait), required: true);
            var __workflow_hLLAPIWaitForKeyboardUnlockedworkflow = WorkflowExpression.Compile(hLLAPIWaitForKeyboardUnlockedworkflow, nameof(hLLAPIWaitForKeyboardUnlockedworkflow), required: true);
            var __workflow_hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait = WorkflowExpression.Compile(hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait, nameof(hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait), required: false);
            return new DeferredBodyAction<HLLAPIWaitForKeyboardUnlockedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIWaitForKeyboardUnlocked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIWaitForKeyboardUnlocked = new JObject();
                var hLLAPIWaitForKeyboardUnlockedpropCount = 0;
                hLLAPIWaitForKeyboardUnlockedpropCount++;
                hLLAPIWaitForKeyboardUnlocked["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_hLLAPIWaitForKeyboardUnlockedsecondsToWait);
                if (__workflow_hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait != null)
                {
                    if (__workflow_hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait != null)
                    {
                        hLLAPIWaitForKeyboardUnlocked["DeltaSecondsToWait"] = ExpressionConverter.ConvertO(__workflow_hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait);
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
                hLLAPIWaitForKeyboardUnlocked["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPIWaitForKeyboardUnlockedworkflow);
                if (hLLAPIWaitForKeyboardUnlockedpropCount > 0)
                {
                    callPayload.Body = hLLAPIWaitForKeyboardUnlocked;
                }

                return new ApiConnectionAction<HLLAPIWaitForKeyboardUnlockedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIWaitForSystemReadyResponse, ApiConnectionActionConfiguration> HLLAPIWaitForSystemReady(Expression<Func<double>> hLLAPIWaitForSystemReadysecondsToWait, Expression<Func<string>> hLLAPIWaitForSystemReadyworkflow, Expression<Func<double>> hLLAPIWaitForSystemReadydeltaSecondsToWait = null)
        {
            var __workflow_hLLAPIWaitForSystemReadysecondsToWait = WorkflowExpression.Compile(hLLAPIWaitForSystemReadysecondsToWait, nameof(hLLAPIWaitForSystemReadysecondsToWait), required: true);
            var __workflow_hLLAPIWaitForSystemReadyworkflow = WorkflowExpression.Compile(hLLAPIWaitForSystemReadyworkflow, nameof(hLLAPIWaitForSystemReadyworkflow), required: true);
            var __workflow_hLLAPIWaitForSystemReadydeltaSecondsToWait = WorkflowExpression.Compile(hLLAPIWaitForSystemReadydeltaSecondsToWait, nameof(hLLAPIWaitForSystemReadydeltaSecondsToWait), required: false);
            return new DeferredBodyAction<HLLAPIWaitForSystemReadyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIWaitForSystemReady";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIWaitForSystemReady = new JObject();
                var hLLAPIWaitForSystemReadypropCount = 0;
                hLLAPIWaitForSystemReadypropCount++;
                hLLAPIWaitForSystemReady["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_hLLAPIWaitForSystemReadysecondsToWait);
                if (__workflow_hLLAPIWaitForSystemReadydeltaSecondsToWait != null)
                {
                    if (__workflow_hLLAPIWaitForSystemReadydeltaSecondsToWait != null)
                    {
                        hLLAPIWaitForSystemReady["DeltaSecondsToWait"] = ExpressionConverter.ConvertO(__workflow_hLLAPIWaitForSystemReadydeltaSecondsToWait);
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
                hLLAPIWaitForSystemReady["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPIWaitForSystemReadyworkflow);
                if (hLLAPIWaitForSystemReadypropCount > 0)
                {
                    callPayload.Body = hLLAPIWaitForSystemReady;
                }

                return new ApiConnectionAction<HLLAPIWaitForSystemReadyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPIPressReset(Expression<Func<string>> hLLAPIPressResetworkflow)
        {
            var __workflow_hLLAPIPressResetworkflow = WorkflowExpression.Compile(hLLAPIPressResetworkflow, nameof(hLLAPIPressResetworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIPressReset";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIPressReset = new JObject();
                var hLLAPIPressResetpropCount = 0;
                hLLAPIPressResetpropCount++;
                hLLAPIPressReset["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPIPressResetworkflow);
                if (hLLAPIPressResetpropCount > 0)
                {
                    callPayload.Body = hLLAPIPressReset;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPISearchForStringResponse, ApiConnectionActionConfiguration> HLLAPISearchForString(Expression<Func<string>> hLLAPISearchForStringsessionId, Expression<Func<string>> hLLAPISearchForStringsearchString, Expression<Func<string>> hLLAPISearchForStringworkflow, Expression<Func<bool>> hLLAPISearchForStringsearchEntireScreen = null, Expression<Func<int>> hLLAPISearchForStringsearchStartRowIndex = null, Expression<Func<int>> hLLAPISearchForStringsearchStartColIndex = null)
        {
            var __workflow_hLLAPISearchForStringsessionId = WorkflowExpression.Compile(hLLAPISearchForStringsessionId, nameof(hLLAPISearchForStringsessionId), required: true);
            var __workflow_hLLAPISearchForStringsearchString = WorkflowExpression.Compile(hLLAPISearchForStringsearchString, nameof(hLLAPISearchForStringsearchString), required: true);
            var __workflow_hLLAPISearchForStringworkflow = WorkflowExpression.Compile(hLLAPISearchForStringworkflow, nameof(hLLAPISearchForStringworkflow), required: true);
            var __workflow_hLLAPISearchForStringsearchEntireScreen = WorkflowExpression.Compile(hLLAPISearchForStringsearchEntireScreen, nameof(hLLAPISearchForStringsearchEntireScreen), required: false);
            var __workflow_hLLAPISearchForStringsearchStartRowIndex = WorkflowExpression.Compile(hLLAPISearchForStringsearchStartRowIndex, nameof(hLLAPISearchForStringsearchStartRowIndex), required: false);
            var __workflow_hLLAPISearchForStringsearchStartColIndex = WorkflowExpression.Compile(hLLAPISearchForStringsearchStartColIndex, nameof(hLLAPISearchForStringsearchStartColIndex), required: false);
            return new DeferredBodyAction<HLLAPISearchForStringResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISearchForString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISearchForString = new JObject();
                var hLLAPISearchForStringpropCount = 0;
                hLLAPISearchForStringpropCount++;
                hLLAPISearchForString["SessionID"] = ExpressionConverter.ConvertO(__workflow_hLLAPISearchForStringsessionId);
                hLLAPISearchForStringpropCount++;
                hLLAPISearchForString["SearchString"] = ExpressionConverter.ConvertO(__workflow_hLLAPISearchForStringsearchString);
                if (__workflow_hLLAPISearchForStringsearchEntireScreen != null)
                {
                    if (__workflow_hLLAPISearchForStringsearchEntireScreen != null)
                    {
                        hLLAPISearchForString["SearchEntireScreen"] = ExpressionConverter.ConvertO(__workflow_hLLAPISearchForStringsearchEntireScreen);
                        hLLAPISearchForStringpropCount++;
                    }

                    hLLAPISearchForStringpropCount++;
                }
                else
                {
                    hLLAPISearchForString["SearchEntireScreen"] = true;
                    hLLAPISearchForStringpropCount++;
                }

                if (__workflow_hLLAPISearchForStringsearchStartRowIndex != null)
                {
                    hLLAPISearchForString["SearchStartRowIndex"] = ExpressionConverter.ConvertO(__workflow_hLLAPISearchForStringsearchStartRowIndex);
                    hLLAPISearchForStringpropCount++;
                }

                if (__workflow_hLLAPISearchForStringsearchStartColIndex != null)
                {
                    hLLAPISearchForString["SearchStartColIndex"] = ExpressionConverter.ConvertO(__workflow_hLLAPISearchForStringsearchStartColIndex);
                    hLLAPISearchForStringpropCount++;
                }

                hLLAPISearchForStringpropCount++;
                hLLAPISearchForString["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPISearchForStringworkflow);
                if (hLLAPISearchForStringpropCount > 0)
                {
                    callPayload.Body = hLLAPISearchForString;
                }

                return new ApiConnectionAction<HLLAPISearchForStringResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIWaitForStringResponse, ApiConnectionActionConfiguration> HLLAPIWaitForString(Expression<Func<string>> hLLAPIWaitForStringsessionId, Expression<Func<string>> hLLAPIWaitForStringsearchString, Expression<Func<double>> hLLAPIWaitForStringsecondsToWait, Expression<Func<string>> hLLAPIWaitForStringworkflow, Expression<Func<bool>> hLLAPIWaitForStringsearchEntireScreen = null, Expression<Func<int>> hLLAPIWaitForStringsearchStartRowIndex = null, Expression<Func<int>> hLLAPIWaitForStringsearchStartColIndex = null, Expression<Func<double>> hLLAPIWaitForStringdeltaSecondsToWait = null)
        {
            var __workflow_hLLAPIWaitForStringsessionId = WorkflowExpression.Compile(hLLAPIWaitForStringsessionId, nameof(hLLAPIWaitForStringsessionId), required: true);
            var __workflow_hLLAPIWaitForStringsearchString = WorkflowExpression.Compile(hLLAPIWaitForStringsearchString, nameof(hLLAPIWaitForStringsearchString), required: true);
            var __workflow_hLLAPIWaitForStringsecondsToWait = WorkflowExpression.Compile(hLLAPIWaitForStringsecondsToWait, nameof(hLLAPIWaitForStringsecondsToWait), required: true);
            var __workflow_hLLAPIWaitForStringworkflow = WorkflowExpression.Compile(hLLAPIWaitForStringworkflow, nameof(hLLAPIWaitForStringworkflow), required: true);
            var __workflow_hLLAPIWaitForStringsearchEntireScreen = WorkflowExpression.Compile(hLLAPIWaitForStringsearchEntireScreen, nameof(hLLAPIWaitForStringsearchEntireScreen), required: false);
            var __workflow_hLLAPIWaitForStringsearchStartRowIndex = WorkflowExpression.Compile(hLLAPIWaitForStringsearchStartRowIndex, nameof(hLLAPIWaitForStringsearchStartRowIndex), required: false);
            var __workflow_hLLAPIWaitForStringsearchStartColIndex = WorkflowExpression.Compile(hLLAPIWaitForStringsearchStartColIndex, nameof(hLLAPIWaitForStringsearchStartColIndex), required: false);
            var __workflow_hLLAPIWaitForStringdeltaSecondsToWait = WorkflowExpression.Compile(hLLAPIWaitForStringdeltaSecondsToWait, nameof(hLLAPIWaitForStringdeltaSecondsToWait), required: false);
            return new DeferredBodyAction<HLLAPIWaitForStringResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIWaitForString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIWaitForString = new JObject();
                var hLLAPIWaitForStringpropCount = 0;
                hLLAPIWaitForStringpropCount++;
                hLLAPIWaitForString["SessionID"] = ExpressionConverter.ConvertO(__workflow_hLLAPIWaitForStringsessionId);
                hLLAPIWaitForStringpropCount++;
                hLLAPIWaitForString["SearchString"] = ExpressionConverter.ConvertO(__workflow_hLLAPIWaitForStringsearchString);
                if (__workflow_hLLAPIWaitForStringsearchEntireScreen != null)
                {
                    if (__workflow_hLLAPIWaitForStringsearchEntireScreen != null)
                    {
                        hLLAPIWaitForString["SearchEntireScreen"] = ExpressionConverter.ConvertO(__workflow_hLLAPIWaitForStringsearchEntireScreen);
                        hLLAPIWaitForStringpropCount++;
                    }

                    hLLAPIWaitForStringpropCount++;
                }
                else
                {
                    hLLAPIWaitForString["SearchEntireScreen"] = true;
                    hLLAPIWaitForStringpropCount++;
                }

                if (__workflow_hLLAPIWaitForStringsearchStartRowIndex != null)
                {
                    hLLAPIWaitForString["SearchStartRowIndex"] = ExpressionConverter.ConvertO(__workflow_hLLAPIWaitForStringsearchStartRowIndex);
                    hLLAPIWaitForStringpropCount++;
                }

                if (__workflow_hLLAPIWaitForStringsearchStartColIndex != null)
                {
                    hLLAPIWaitForString["SearchStartColIndex"] = ExpressionConverter.ConvertO(__workflow_hLLAPIWaitForStringsearchStartColIndex);
                    hLLAPIWaitForStringpropCount++;
                }

                hLLAPIWaitForStringpropCount++;
                hLLAPIWaitForString["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_hLLAPIWaitForStringsecondsToWait);
                if (__workflow_hLLAPIWaitForStringdeltaSecondsToWait != null)
                {
                    if (__workflow_hLLAPIWaitForStringdeltaSecondsToWait != null)
                    {
                        hLLAPIWaitForString["DeltaSecondsToWait"] = ExpressionConverter.ConvertO(__workflow_hLLAPIWaitForStringdeltaSecondsToWait);
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
                hLLAPIWaitForString["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPIWaitForStringworkflow);
                if (hLLAPIWaitForStringpropCount > 0)
                {
                    callPayload.Body = hLLAPIWaitForString;
                }

                return new ApiConnectionAction<HLLAPIWaitForStringResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPISetSessionParameter(Expression<Func<string>> hLLAPISetSessionParameterparameter, Expression<Func<string>> hLLAPISetSessionParameterworkflow)
        {
            var __workflow_hLLAPISetSessionParameterparameter = WorkflowExpression.Compile(hLLAPISetSessionParameterparameter, nameof(hLLAPISetSessionParameterparameter), required: true);
            var __workflow_hLLAPISetSessionParameterworkflow = WorkflowExpression.Compile(hLLAPISetSessionParameterworkflow, nameof(hLLAPISetSessionParameterworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISetSessionParameter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISetSessionParameter = new JObject();
                var hLLAPISetSessionParameterpropCount = 0;
                hLLAPISetSessionParameterpropCount++;
                hLLAPISetSessionParameter["Parameter"] = ExpressionConverter.ConvertO(__workflow_hLLAPISetSessionParameterparameter);
                hLLAPISetSessionParameterpropCount++;
                hLLAPISetSessionParameter["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPISetSessionParameterworkflow);
                if (hLLAPISetSessionParameterpropCount > 0)
                {
                    callPayload.Body = hLLAPISetSessionParameter;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPIResetSystem(Expression<Func<string>> hLLAPIResetSystemworkflow)
        {
            var __workflow_hLLAPIResetSystemworkflow = WorkflowExpression.Compile(hLLAPIResetSystemworkflow, nameof(hLLAPIResetSystemworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIResetSystem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIResetSystem = new JObject();
                var hLLAPIResetSystempropCount = 0;
                hLLAPIResetSystempropCount++;
                hLLAPIResetSystem["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPIResetSystemworkflow);
                if (hLLAPIResetSystempropCount > 0)
                {
                    callPayload.Body = hLLAPIResetSystem;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPICopyOperatorInformationAreaResponse, ApiConnectionActionConfiguration> HLLAPICopyOperatorInformationArea(Expression<Func<string>> hLLAPICopyOperatorInformationAreaworkflow)
        {
            var __workflow_hLLAPICopyOperatorInformationAreaworkflow = WorkflowExpression.Compile(hLLAPICopyOperatorInformationAreaworkflow, nameof(hLLAPICopyOperatorInformationAreaworkflow), required: true);
            return new DeferredBodyAction<HLLAPICopyOperatorInformationAreaResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPICopyOperatorInformationArea";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPICopyOperatorInformationArea = new JObject();
                var hLLAPICopyOperatorInformationAreapropCount = 0;
                hLLAPICopyOperatorInformationAreapropCount++;
                hLLAPICopyOperatorInformationArea["Workflow"] = ExpressionConverter.ConvertO(__workflow_hLLAPICopyOperatorInformationAreaworkflow);
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

        [JsonProperty("HLLAPIThreadID")]
        public int HLLAPIThreadId { get; set; }

        [JsonProperty("COMThreadID")]
        public int COMThreadId { get; set; }
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