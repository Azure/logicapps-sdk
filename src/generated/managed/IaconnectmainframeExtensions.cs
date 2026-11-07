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
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPISetHLLAPIdLL(Expression<Func<HLLAPISetHLLAPIdLLInput>> hLLAPISetHLLAPIdLL)
        {
            var __workflow_hLLAPISetHLLAPIdLL = WorkflowExpression.Compile(hLLAPISetHLLAPIdLL, nameof(hLLAPISetHLLAPIdLL), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISetHLLAPIDLL";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPISetHLLAPIdLL);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPIDispose(Expression<Func<HLLAPIDisposeInput>> hLLAPIDispose)
        {
            var __workflow_hLLAPIDispose = WorkflowExpression.Compile(hLLAPIDispose, nameof(hLLAPIDispose), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIDispose";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPIDispose);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPIConnect(Expression<Func<HLLAPIConnectInput>> hLLAPIConnect)
        {
            var __workflow_hLLAPIConnect = WorkflowExpression.Compile(hLLAPIConnect, nameof(hLLAPIConnect), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIConnect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPIConnect);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIGetConnectStatusResponse, ApiConnectionActionConfiguration> HLLAPIGetConnectStatus(Expression<Func<HLLAPIGetConnectStatusInput>> hLLAPIGetConnectStatus)
        {
            var __workflow_hLLAPIGetConnectStatus = WorkflowExpression.Compile(hLLAPIGetConnectStatus, nameof(hLLAPIGetConnectStatus), required: true);
            return new DeferredBodyAction<HLLAPIGetConnectStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIGetConnectStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPIGetConnectStatus);
                return new ApiConnectionAction<HLLAPIGetConnectStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPIDisconnect(Expression<Func<HLLAPIDisconnectInput>> hLLAPIDisconnect)
        {
            var __workflow_hLLAPIDisconnect = WorkflowExpression.Compile(hLLAPIDisconnect, nameof(hLLAPIDisconnect), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIDisconnect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPIDisconnect);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPISetCursorPos(Expression<Func<HLLAPISetCursorPosInput>> hLLAPISetCursorPos)
        {
            var __workflow_hLLAPISetCursorPos = WorkflowExpression.Compile(hLLAPISetCursorPos, nameof(hLLAPISetCursorPos), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISetCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPISetCursorPos);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIGetCursorPosResponse, ApiConnectionActionConfiguration> HLLAPIGetCursorPos(Expression<Func<HLLAPIGetCursorPosInput>> hLLAPIGetCursorPos)
        {
            var __workflow_hLLAPIGetCursorPos = WorkflowExpression.Compile(hLLAPIGetCursorPos, nameof(hLLAPIGetCursorPos), required: true);
            return new DeferredBodyAction<HLLAPIGetCursorPosResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIGetCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPIGetCursorPos);
                return new ApiConnectionAction<HLLAPIGetCursorPosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPISendString(Expression<Func<HLLAPISendStringInput>> hLLAPISendString)
        {
            var __workflow_hLLAPISendString = WorkflowExpression.Compile(hLLAPISendString, nameof(hLLAPISendString), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISendString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPISendString);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPISendPassword(Expression<Func<HLLAPISendPasswordInput>> hLLAPISendPassword)
        {
            var __workflow_hLLAPISendPassword = WorkflowExpression.Compile(hLLAPISendPassword, nameof(hLLAPISendPassword), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISendPassword";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPISendPassword);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPISendStringAtCursorPos(Expression<Func<HLLAPISendStringAtCursorPosInput>> hLLAPISendStringAtCursorPos)
        {
            var __workflow_hLLAPISendStringAtCursorPos = WorkflowExpression.Compile(hLLAPISendStringAtCursorPos, nameof(hLLAPISendStringAtCursorPos), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISendStringAtCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPISendStringAtCursorPos);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPISendPasswordAtCursorPos(Expression<Func<HLLAPISendPasswordAtCursorPosInput>> hLLAPISendPasswordAtCursorPos)
        {
            var __workflow_hLLAPISendPasswordAtCursorPos = WorkflowExpression.Compile(hLLAPISendPasswordAtCursorPos, nameof(hLLAPISendPasswordAtCursorPos), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISendPasswordAtCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPISendPasswordAtCursorPos);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIReadScreenAtCursorPosResponse, ApiConnectionActionConfiguration> HLLAPIReadScreenAtCursorPos(Expression<Func<HLLAPIReadScreenAtCursorPosInput>> hLLAPIReadScreenAtCursorPos)
        {
            var __workflow_hLLAPIReadScreenAtCursorPos = WorkflowExpression.Compile(hLLAPIReadScreenAtCursorPos, nameof(hLLAPIReadScreenAtCursorPos), required: true);
            return new DeferredBodyAction<HLLAPIReadScreenAtCursorPosResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIReadScreenAtCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPIReadScreenAtCursorPos);
                return new ApiConnectionAction<HLLAPIReadScreenAtCursorPosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIQuerySessionStatusResponse, ApiConnectionActionConfiguration> HLLAPIQuerySessionStatus(Expression<Func<HLLAPIQuerySessionStatusInput>> hLLAPIQuerySessionStatus)
        {
            var __workflow_hLLAPIQuerySessionStatus = WorkflowExpression.Compile(hLLAPIQuerySessionStatus, nameof(hLLAPIQuerySessionStatus), required: true);
            return new DeferredBodyAction<HLLAPIQuerySessionStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIQuerySessionStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPIQuerySessionStatus);
                return new ApiConnectionAction<HLLAPIQuerySessionStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIReadScreenRowsResponse, ApiConnectionActionConfiguration> HLLAPIReadScreenRows(Expression<Func<HLLAPIReadScreenRowsInput>> hLLAPIReadScreenRows)
        {
            var __workflow_hLLAPIReadScreenRows = WorkflowExpression.Compile(hLLAPIReadScreenRows, nameof(hLLAPIReadScreenRows), required: true);
            return new DeferredBodyAction<HLLAPIReadScreenRowsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIReadScreenRows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPIReadScreenRows);
                return new ApiConnectionAction<HLLAPIReadScreenRowsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIIsKeyboardUnlockedResponse, ApiConnectionActionConfiguration> HLLAPIIsKeyboardUnlocked(Expression<Func<HLLAPIIsKeyboardUnlockedInput>> hLLAPIIsKeyboardUnlocked)
        {
            var __workflow_hLLAPIIsKeyboardUnlocked = WorkflowExpression.Compile(hLLAPIIsKeyboardUnlocked, nameof(hLLAPIIsKeyboardUnlocked), required: true);
            return new DeferredBodyAction<HLLAPIIsKeyboardUnlockedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIIsKeyboardUnlocked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPIIsKeyboardUnlocked);
                return new ApiConnectionAction<HLLAPIIsKeyboardUnlockedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIWaitForKeyboardUnlockedResponse, ApiConnectionActionConfiguration> HLLAPIWaitForKeyboardUnlocked(Expression<Func<HLLAPIWaitForKeyboardUnlockedInput>> hLLAPIWaitForKeyboardUnlocked)
        {
            var __workflow_hLLAPIWaitForKeyboardUnlocked = WorkflowExpression.Compile(hLLAPIWaitForKeyboardUnlocked, nameof(hLLAPIWaitForKeyboardUnlocked), required: true);
            return new DeferredBodyAction<HLLAPIWaitForKeyboardUnlockedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIWaitForKeyboardUnlocked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPIWaitForKeyboardUnlocked);
                return new ApiConnectionAction<HLLAPIWaitForKeyboardUnlockedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIWaitForSystemReadyResponse, ApiConnectionActionConfiguration> HLLAPIWaitForSystemReady(Expression<Func<HLLAPIWaitForSystemReadyInput>> hLLAPIWaitForSystemReady)
        {
            var __workflow_hLLAPIWaitForSystemReady = WorkflowExpression.Compile(hLLAPIWaitForSystemReady, nameof(hLLAPIWaitForSystemReady), required: true);
            return new DeferredBodyAction<HLLAPIWaitForSystemReadyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIWaitForSystemReady";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPIWaitForSystemReady);
                return new ApiConnectionAction<HLLAPIWaitForSystemReadyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPIPressReset(Expression<Func<HLLAPIPressResetInput>> hLLAPIPressReset)
        {
            var __workflow_hLLAPIPressReset = WorkflowExpression.Compile(hLLAPIPressReset, nameof(hLLAPIPressReset), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIPressReset";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPIPressReset);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPISearchForStringResponse, ApiConnectionActionConfiguration> HLLAPISearchForString(Expression<Func<HLLAPISearchForStringInput>> hLLAPISearchForString)
        {
            var __workflow_hLLAPISearchForString = WorkflowExpression.Compile(hLLAPISearchForString, nameof(hLLAPISearchForString), required: true);
            return new DeferredBodyAction<HLLAPISearchForStringResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISearchForString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPISearchForString);
                return new ApiConnectionAction<HLLAPISearchForStringResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIWaitForStringResponse, ApiConnectionActionConfiguration> HLLAPIWaitForString(Expression<Func<HLLAPIWaitForStringInput>> hLLAPIWaitForString)
        {
            var __workflow_hLLAPIWaitForString = WorkflowExpression.Compile(hLLAPIWaitForString, nameof(hLLAPIWaitForString), required: true);
            return new DeferredBodyAction<HLLAPIWaitForStringResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIWaitForString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPIWaitForString);
                return new ApiConnectionAction<HLLAPIWaitForStringResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPISetSessionParameter(Expression<Func<HLLAPISetSessionParameterInput>> hLLAPISetSessionParameter)
        {
            var __workflow_hLLAPISetSessionParameter = WorkflowExpression.Compile(hLLAPISetSessionParameter, nameof(hLLAPISetSessionParameter), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISetSessionParameter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPISetSessionParameter);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HLLAPIResetSystem(Expression<Func<HLLAPIResetSystemInput>> hLLAPIResetSystem)
        {
            var __workflow_hLLAPIResetSystem = WorkflowExpression.Compile(hLLAPIResetSystem, nameof(hLLAPIResetSystem), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIResetSystem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPIResetSystem);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPICopyOperatorInformationAreaResponse, ApiConnectionActionConfiguration> HLLAPICopyOperatorInformationArea(Expression<Func<HLLAPICopyOperatorInformationAreaInput>> hLLAPICopyOperatorInformationArea)
        {
            var __workflow_hLLAPICopyOperatorInformationArea = WorkflowExpression.Compile(hLLAPICopyOperatorInformationArea, nameof(hLLAPICopyOperatorInformationArea), required: true);
            return new DeferredBodyAction<HLLAPICopyOperatorInformationAreaResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPICopyOperatorInformationArea";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hLLAPICopyOperatorInformationArea);
                return new ApiConnectionAction<HLLAPICopyOperatorInformationAreaResponse>(callPayload);
            });
        }
    }

    public class IaconnectmainframeTriggers([ConnectionName] string connectionId)
    {
    }

    public class HLLAPISetHLLAPIdLLInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DLLFilename { get; set; }
        public string IAHLLAPIPath { get; set; }
        public string EntryPointName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsEnhancedInterface { get; set; } = false;

        [JsonProperty("Is64BitHLLAPIDLL", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Is64BitHLLAPIdLL { get; set; } = false;

        [JsonProperty("UseCOMFor64BitHLLAPIDLL", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseCOMFor64BitHLLAPIdLL { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HLLAPIDisposeInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HLLAPIConnectInput
    {
        [JsonProperty("SessionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SessionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
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

    public class HLLAPIGetConnectStatusInput
    {
        [JsonProperty("SessionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SessionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HLLAPIDisconnectInput
    {
        [JsonProperty("SessionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SessionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HLLAPISetCursorPosInput
    {
        [JsonProperty("SessionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SessionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int CursorRowIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int CursorColIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HLLAPIGetCursorPosResponse
    {
        public int CursorRowIndex { get; set; }
        public int CursorColIndex { get; set; }
        public int CursorPos { get; set; }
    }

    public class HLLAPIGetCursorPosInput
    {
        [JsonProperty("SessionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SessionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HLLAPISendStringInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputString { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HLLAPISendPasswordInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputPassword { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HLLAPISendStringAtCursorPosInput
    {
        [JsonProperty("SessionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SessionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int CursorRowIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int CursorColIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputString { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HLLAPISendPasswordAtCursorPosInput
    {
        [JsonProperty("SessionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SessionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int CursorRowIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int CursorColIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputPassword { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HLLAPIReadScreenAtCursorPosResponse
    {
        public string ScreenContents { get; set; }
    }

    public class HLLAPIReadScreenAtCursorPosInput
    {
        [JsonProperty("SessionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SessionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int CursorRowIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int CursorColIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ReadScreenLength { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HLLAPIQuerySessionStatusResponse
    {
        public string SessionLongName { get; set; }
        public string SessionType { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfCols { get; set; }
        public int CodePage { get; set; }
    }

    public class HLLAPIQuerySessionStatusInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HLLAPIReadScreenRowsResponse
    {
        public string ScreenRowsJSON { get; set; }
    }

    public class HLLAPIReadScreenRowsInput
    {
        [JsonProperty("SessionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SessionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int StartRowIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int EndRowIndex { get; set; }
        public int? NumberOfRowsInSession { get; set; }
        public int? NumberOfColumnsInSession { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HLLAPIIsKeyboardUnlockedResponse
    {
        public bool KeyBoardIsUnlocked { get; set; }
    }

    public class HLLAPIIsKeyboardUnlockedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HLLAPIWaitForKeyboardUnlockedResponse
    {
        public bool KeyBoardIsUnlocked { get; set; }
    }

    public class HLLAPIWaitForKeyboardUnlockedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double SecondsToWait { get; set; } = 5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? DeltaSecondsToWait { get; set; } = 0.05;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HLLAPIWaitForSystemReadyResponse
    {
        public bool SystemReady { get; set; }
    }

    public class HLLAPIWaitForSystemReadyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double SecondsToWait { get; set; } = 5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? DeltaSecondsToWait { get; set; } = 0.05;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HLLAPIPressResetInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HLLAPISearchForStringResponse
    {
        public bool StringFound { get; set; }
        public int StringFoundPosition { get; set; }
        public int StringFoundRowIndex { get; set; }
        public int StringFoundColIndex { get; set; }
    }

    public class HLLAPISearchForStringInput
    {
        [JsonProperty("SessionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SessionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchString { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchEntireScreen { get; set; } = true;
        public int? SearchStartRowIndex { get; set; }
        public int? SearchStartColIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HLLAPIWaitForStringResponse
    {
        public bool StringFound { get; set; }
        public int StringFoundPosition { get; set; }
        public int StringFoundRowIndex { get; set; }
        public int StringFoundColIndex { get; set; }
    }

    public class HLLAPIWaitForStringInput
    {
        [JsonProperty("SessionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SessionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchString { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SearchEntireScreen { get; set; } = true;
        public int? SearchStartRowIndex { get; set; }
        public int? SearchStartColIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double SecondsToWait { get; set; } = 5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? DeltaSecondsToWait { get; set; } = 0.05;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HLLAPISetSessionParameterInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Parameter { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HLLAPIResetSystemInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
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

    public class HLLAPICopyOperatorInformationAreaInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
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