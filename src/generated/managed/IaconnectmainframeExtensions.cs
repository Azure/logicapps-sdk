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
        public IWorkflowAction<ApiConnectionActionConfiguration> HllapiSetHllapidll(Expression<Func<HllapiSetHllapidllInput>> hllapiSetHllapidll)
        {
            var __workflow_hllapiSetHllapidll = WorkflowExpression.Compile(hllapiSetHllapidll, nameof(hllapiSetHllapidll), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISetHLLAPIDLL";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiSetHllapidll);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HllapiDispose(Expression<Func<HllapiDisposeInput>> hllapiDispose)
        {
            var __workflow_hllapiDispose = WorkflowExpression.Compile(hllapiDispose, nameof(hllapiDispose), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIDispose";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiDispose);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HllapiConnect(Expression<Func<HllapiConnectInput>> hllapiConnect)
        {
            var __workflow_hllapiConnect = WorkflowExpression.Compile(hllapiConnect, nameof(hllapiConnect), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIConnect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiConnect);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HllapiGetConnectStatusResponse, ApiConnectionActionConfiguration> HllapiGetConnectStatus(Expression<Func<HllapiGetConnectStatusInput>> hllapiGetConnectStatus)
        {
            var __workflow_hllapiGetConnectStatus = WorkflowExpression.Compile(hllapiGetConnectStatus, nameof(hllapiGetConnectStatus), required: true);
            return new DeferredBodyAction<HllapiGetConnectStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIGetConnectStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiGetConnectStatus);
                return new ApiConnectionAction<HllapiGetConnectStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HllapiDisconnect(Expression<Func<HllapiDisconnectInput>> hllapiDisconnect)
        {
            var __workflow_hllapiDisconnect = WorkflowExpression.Compile(hllapiDisconnect, nameof(hllapiDisconnect), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIDisconnect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiDisconnect);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HllapiSetCursorPos(Expression<Func<HllapiSetCursorPosInput>> hllapiSetCursorPos)
        {
            var __workflow_hllapiSetCursorPos = WorkflowExpression.Compile(hllapiSetCursorPos, nameof(hllapiSetCursorPos), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISetCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiSetCursorPos);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HllapiGetCursorPosResponse, ApiConnectionActionConfiguration> HllapiGetCursorPos(Expression<Func<HllapiGetCursorPosInput>> hllapiGetCursorPos)
        {
            var __workflow_hllapiGetCursorPos = WorkflowExpression.Compile(hllapiGetCursorPos, nameof(hllapiGetCursorPos), required: true);
            return new DeferredBodyAction<HllapiGetCursorPosResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIGetCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiGetCursorPos);
                return new ApiConnectionAction<HllapiGetCursorPosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HllapiSendString(Expression<Func<HllapiSendStringInput>> hllapiSendString)
        {
            var __workflow_hllapiSendString = WorkflowExpression.Compile(hllapiSendString, nameof(hllapiSendString), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISendString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiSendString);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HllapiSendPassword(Expression<Func<HllapiSendPasswordInput>> hllapiSendPassword)
        {
            var __workflow_hllapiSendPassword = WorkflowExpression.Compile(hllapiSendPassword, nameof(hllapiSendPassword), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISendPassword";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiSendPassword);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HllapiSendStringAtCursorPos(Expression<Func<HllapiSendStringAtCursorPosInput>> hllapiSendStringAtCursorPos)
        {
            var __workflow_hllapiSendStringAtCursorPos = WorkflowExpression.Compile(hllapiSendStringAtCursorPos, nameof(hllapiSendStringAtCursorPos), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISendStringAtCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiSendStringAtCursorPos);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HllapiSendPasswordAtCursorPos(Expression<Func<HllapiSendPasswordAtCursorPosInput>> hllapiSendPasswordAtCursorPos)
        {
            var __workflow_hllapiSendPasswordAtCursorPos = WorkflowExpression.Compile(hllapiSendPasswordAtCursorPos, nameof(hllapiSendPasswordAtCursorPos), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISendPasswordAtCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiSendPasswordAtCursorPos);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HllapiReadScreenAtCursorPosResponse, ApiConnectionActionConfiguration> HllapiReadScreenAtCursorPos(Expression<Func<HllapiReadScreenAtCursorPosInput>> hllapiReadScreenAtCursorPos)
        {
            var __workflow_hllapiReadScreenAtCursorPos = WorkflowExpression.Compile(hllapiReadScreenAtCursorPos, nameof(hllapiReadScreenAtCursorPos), required: true);
            return new DeferredBodyAction<HllapiReadScreenAtCursorPosResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIReadScreenAtCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiReadScreenAtCursorPos);
                return new ApiConnectionAction<HllapiReadScreenAtCursorPosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HllapiQuerySessionStatusResponse, ApiConnectionActionConfiguration> HllapiQuerySessionStatus(Expression<Func<HllapiQuerySessionStatusInput>> hllapiQuerySessionStatus)
        {
            var __workflow_hllapiQuerySessionStatus = WorkflowExpression.Compile(hllapiQuerySessionStatus, nameof(hllapiQuerySessionStatus), required: true);
            return new DeferredBodyAction<HllapiQuerySessionStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIQuerySessionStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiQuerySessionStatus);
                return new ApiConnectionAction<HllapiQuerySessionStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HllapiReadScreenRowsResponse, ApiConnectionActionConfiguration> HllapiReadScreenRows(Expression<Func<HllapiReadScreenRowsInput>> hllapiReadScreenRows)
        {
            var __workflow_hllapiReadScreenRows = WorkflowExpression.Compile(hllapiReadScreenRows, nameof(hllapiReadScreenRows), required: true);
            return new DeferredBodyAction<HllapiReadScreenRowsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIReadScreenRows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiReadScreenRows);
                return new ApiConnectionAction<HllapiReadScreenRowsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HllapiisKeyboardUnlockedResponse, ApiConnectionActionConfiguration> HllapiisKeyboardUnlocked(Expression<Func<HllapiisKeyboardUnlockedInput>> hllapiisKeyboardUnlocked)
        {
            var __workflow_hllapiisKeyboardUnlocked = WorkflowExpression.Compile(hllapiisKeyboardUnlocked, nameof(hllapiisKeyboardUnlocked), required: true);
            return new DeferredBodyAction<HllapiisKeyboardUnlockedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIIsKeyboardUnlocked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiisKeyboardUnlocked);
                return new ApiConnectionAction<HllapiisKeyboardUnlockedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HllapiWaitForKeyboardUnlockedResponse, ApiConnectionActionConfiguration> HllapiWaitForKeyboardUnlocked(Expression<Func<HllapiWaitForKeyboardUnlockedInput>> hllapiWaitForKeyboardUnlocked)
        {
            var __workflow_hllapiWaitForKeyboardUnlocked = WorkflowExpression.Compile(hllapiWaitForKeyboardUnlocked, nameof(hllapiWaitForKeyboardUnlocked), required: true);
            return new DeferredBodyAction<HllapiWaitForKeyboardUnlockedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIWaitForKeyboardUnlocked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiWaitForKeyboardUnlocked);
                return new ApiConnectionAction<HllapiWaitForKeyboardUnlockedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HllapiWaitForSystemReadyResponse, ApiConnectionActionConfiguration> HllapiWaitForSystemReady(Expression<Func<HllapiWaitForSystemReadyInput>> hllapiWaitForSystemReady)
        {
            var __workflow_hllapiWaitForSystemReady = WorkflowExpression.Compile(hllapiWaitForSystemReady, nameof(hllapiWaitForSystemReady), required: true);
            return new DeferredBodyAction<HllapiWaitForSystemReadyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIWaitForSystemReady";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiWaitForSystemReady);
                return new ApiConnectionAction<HllapiWaitForSystemReadyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HllapiPressReset(Expression<Func<HllapiPressResetInput>> hllapiPressReset)
        {
            var __workflow_hllapiPressReset = WorkflowExpression.Compile(hllapiPressReset, nameof(hllapiPressReset), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIPressReset";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiPressReset);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HllapiSearchForStringResponse, ApiConnectionActionConfiguration> HllapiSearchForString(Expression<Func<HllapiSearchForStringInput>> hllapiSearchForString)
        {
            var __workflow_hllapiSearchForString = WorkflowExpression.Compile(hllapiSearchForString, nameof(hllapiSearchForString), required: true);
            return new DeferredBodyAction<HllapiSearchForStringResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISearchForString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiSearchForString);
                return new ApiConnectionAction<HllapiSearchForStringResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HllapiWaitForStringResponse, ApiConnectionActionConfiguration> HllapiWaitForString(Expression<Func<HllapiWaitForStringInput>> hllapiWaitForString)
        {
            var __workflow_hllapiWaitForString = WorkflowExpression.Compile(hllapiWaitForString, nameof(hllapiWaitForString), required: true);
            return new DeferredBodyAction<HllapiWaitForStringResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIWaitForString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiWaitForString);
                return new ApiConnectionAction<HllapiWaitForStringResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HllapiSetSessionParameter(Expression<Func<HllapiSetSessionParameterInput>> hllapiSetSessionParameter)
        {
            var __workflow_hllapiSetSessionParameter = WorkflowExpression.Compile(hllapiSetSessionParameter, nameof(hllapiSetSessionParameter), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPISetSessionParameter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiSetSessionParameter);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction<ApiConnectionActionConfiguration> HllapiResetSystem(Expression<Func<HllapiResetSystemInput>> hllapiResetSystem)
        {
            var __workflow_hllapiResetSystem = WorkflowExpression.Compile(hllapiResetSystem, nameof(hllapiResetSystem), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPIResetSystem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiResetSystem);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HllapiCopyOperatorInformationAreaResponse, ApiConnectionActionConfiguration> HllapiCopyOperatorInformationArea(Expression<Func<HllapiCopyOperatorInformationAreaInput>> hllapiCopyOperatorInformationArea)
        {
            var __workflow_hllapiCopyOperatorInformationArea = WorkflowExpression.Compile(hllapiCopyOperatorInformationArea, nameof(hllapiCopyOperatorInformationArea), required: true);
            return new DeferredBodyAction<HllapiCopyOperatorInformationAreaResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/HLLAPI/HLLAPICopyOperatorInformationArea";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_hllapiCopyOperatorInformationArea);
                return new ApiConnectionAction<HllapiCopyOperatorInformationAreaResponse>(callPayload);
            });
        }
    }

    public class IaconnectmainframeTriggers([ConnectionName] string connectionId)
    {
    }

    public class HllapiSetHllapidllInput
    {
        public HllapiSetHllapidllInput(string dllFileName)
        {
            this.DllFileName = dllFileName;
        }

        [JsonProperty("DLLFilename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DllFileName { get; set; }

        [JsonProperty("IAHLLAPIPath")]
        public string IahllapiPath { get; set; }
        public string EntryPointName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsEnhancedInterface { get; set; } = false;

        [JsonProperty("Is64BitHLLAPIDLL", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Is64BitHllapidll { get; set; } = false;

        [JsonProperty("UseCOMFor64BitHLLAPIDLL", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseComFor64BitHllapidll { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HllapiDisposeInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HllapiConnectInput
    {
        public HllapiConnectInput(string sessionId)
        {
            this.SessionId = sessionId;
        }

        [JsonProperty("SessionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SessionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HllapiGetConnectStatusResponse
    {
        public bool ConnectedToSession { get; set; }
        public bool SystemBusy { get; set; }
        public bool KeyboardLocked { get; set; }

        [JsonProperty("SessionInUseByAnotherHLLAPIApplication")]
        public bool SessionInUseByAnotherHllapiApplication { get; set; }

        [JsonProperty("HLLAPIThreadID")]
        public int HllapiThreadId { get; set; }

        [JsonProperty("COMThreadID")]
        public int ComThreadId { get; set; }
        public int CallCount { get; set; }
    }

    public class HllapiGetConnectStatusInput
    {
        public HllapiGetConnectStatusInput(string sessionId)
        {
            this.SessionId = sessionId;
        }

        [JsonProperty("SessionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SessionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HllapiDisconnectInput
    {
        public HllapiDisconnectInput(string sessionId)
        {
            this.SessionId = sessionId;
        }

        [JsonProperty("SessionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SessionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HllapiSetCursorPosInput
    {
        public HllapiSetCursorPosInput(string sessionId, int cursorRowIndex, int cursorColIndex)
        {
            this.SessionId = sessionId;
            this.CursorRowIndex = cursorRowIndex;
            this.CursorColIndex = cursorColIndex;
        }

        [JsonProperty("SessionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SessionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int CursorRowIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int CursorColIndex { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HllapiGetCursorPosResponse
    {
        public int CursorRowIndex { get; set; }
        public int CursorColIndex { get; set; }
        public int CursorPos { get; set; }
    }

    public class HllapiGetCursorPosInput
    {
        public HllapiGetCursorPosInput(string sessionId)
        {
            this.SessionId = sessionId;
        }

        [JsonProperty("SessionID", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SessionId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HllapiSendStringInput
    {
        public HllapiSendStringInput(string inputString)
        {
            this.InputString = inputString;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputString { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HllapiSendPasswordInput
    {
        public HllapiSendPasswordInput(string inputPassword)
        {
            this.InputPassword = inputPassword;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputPassword { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HllapiSendStringAtCursorPosInput
    {
        public HllapiSendStringAtCursorPosInput(string sessionId, int cursorRowIndex, int cursorColIndex, string inputString)
        {
            this.SessionId = sessionId;
            this.CursorRowIndex = cursorRowIndex;
            this.CursorColIndex = cursorColIndex;
            this.InputString = inputString;
        }

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

    public class HllapiSendPasswordAtCursorPosInput
    {
        public HllapiSendPasswordAtCursorPosInput(string sessionId, int cursorRowIndex, int cursorColIndex, string inputPassword)
        {
            this.SessionId = sessionId;
            this.CursorRowIndex = cursorRowIndex;
            this.CursorColIndex = cursorColIndex;
            this.InputPassword = inputPassword;
        }

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

    public class HllapiReadScreenAtCursorPosResponse
    {
        public string ScreenContents { get; set; }
    }

    public class HllapiReadScreenAtCursorPosInput
    {
        public HllapiReadScreenAtCursorPosInput(string sessionId, int cursorRowIndex, int cursorColIndex, int readScreenLength)
        {
            this.SessionId = sessionId;
            this.CursorRowIndex = cursorRowIndex;
            this.CursorColIndex = cursorColIndex;
            this.ReadScreenLength = readScreenLength;
        }

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

    public class HllapiQuerySessionStatusResponse
    {
        public string SessionLongName { get; set; }
        public string SessionType { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfCols { get; set; }
        public int CodePage { get; set; }
    }

    public class HllapiQuerySessionStatusInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HllapiReadScreenRowsResponse
    {
        [JsonProperty("ScreenRowsJSON")]
        public string ScreenRowsJson { get; set; }
    }

    public class HllapiReadScreenRowsInput
    {
        public HllapiReadScreenRowsInput(string sessionId, int startRowIndex, int endRowIndex)
        {
            this.SessionId = sessionId;
            this.StartRowIndex = startRowIndex;
            this.EndRowIndex = endRowIndex;
        }

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

    public class HllapiisKeyboardUnlockedResponse
    {
        public bool KeyBoardIsUnlocked { get; set; }
    }

    public class HllapiisKeyboardUnlockedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HllapiWaitForKeyboardUnlockedResponse
    {
        public bool KeyBoardIsUnlocked { get; set; }
    }

    public class HllapiWaitForKeyboardUnlockedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double SecondsToWait { get; set; } = 5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? DeltaSecondsToWait { get; set; } = 0.05;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HllapiWaitForSystemReadyResponse
    {
        public bool SystemReady { get; set; }
    }

    public class HllapiWaitForSystemReadyInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double SecondsToWait { get; set; } = 5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? DeltaSecondsToWait { get; set; } = 0.05;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HllapiPressResetInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HllapiSearchForStringResponse
    {
        public bool StringFound { get; set; }
        public int StringFoundPosition { get; set; }
        public int StringFoundRowIndex { get; set; }
        public int StringFoundColIndex { get; set; }
    }

    public class HllapiSearchForStringInput
    {
        public HllapiSearchForStringInput(string sessionId, string searchString)
        {
            this.SessionId = sessionId;
            this.SearchString = searchString;
        }

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

    public class HllapiWaitForStringResponse
    {
        public bool StringFound { get; set; }
        public int StringFoundPosition { get; set; }
        public int StringFoundRowIndex { get; set; }
        public int StringFoundColIndex { get; set; }
    }

    public class HllapiWaitForStringInput
    {
        public HllapiWaitForStringInput(string sessionId, string searchString)
        {
            this.SessionId = sessionId;
            this.SearchString = searchString;
        }

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

    public class HllapiSetSessionParameterInput
    {
        public HllapiSetSessionParameterInput(string parameter)
        {
            this.Parameter = parameter;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Parameter { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HllapiResetSystemInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class HllapiCopyOperatorInformationAreaResponse
    {
        [JsonProperty("OIAFormat")]
        public string OiaFormat { get; set; }
        public bool SystemWait { get; set; }

        [JsonProperty("CAPS")]
        public bool Caps { get; set; }
        public bool ShiftKey { get; set; }
        public bool SubsystemReady { get; set; }
        public bool InsertMode { get; set; }
        public bool InvalidInput { get; set; }
        public string InputType { get; set; }
    }

    public class HllapiCopyOperatorInformationAreaInput
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