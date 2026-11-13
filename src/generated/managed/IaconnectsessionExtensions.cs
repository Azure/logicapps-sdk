//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectsessionActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetMachineNameResponse, ApiConnectionActionConfiguration> GetMachineName(Expression<Func<GetMachineNameInput>> getMachineName)
        {
            var __workflow_getMachineName = WorkflowExpression.Compile(getMachineName, nameof(getMachineName), required: true);
            return new DeferredBodyAction<GetMachineNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetMachineName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getMachineName);
                return new ApiConnectionAction<GetMachineNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetMachineDomainResponse, ApiConnectionActionConfiguration> GetMachineDomain(Expression<Func<GetMachineDomainInput>> getMachineDomain)
        {
            var __workflow_getMachineDomain = WorkflowExpression.Compile(getMachineDomain, nameof(getMachineDomain), required: true);
            return new DeferredBodyAction<GetMachineDomainResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetMachineDomain";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getMachineDomain);
                return new ApiConnectionAction<GetMachineDomainResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteSessionClientHostnameResponse, ApiConnectionActionConfiguration> GetRemoteSessionClientHostname(Expression<Func<GetRemoteSessionClientHostnameInput>> getRemoteSessionClientHostname)
        {
            var __workflow_getRemoteSessionClientHostname = WorkflowExpression.Compile(getRemoteSessionClientHostname, nameof(getRemoteSessionClientHostname), required: true);
            return new DeferredBodyAction<GetRemoteSessionClientHostnameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetRemoteSessionClientHostname";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getRemoteSessionClientHostname);
                return new ApiConnectionAction<GetRemoteSessionClientHostnameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ExpandEnvironmentVariableResponse, ApiConnectionActionConfiguration> ExpandEnvironmentVariable(Expression<Func<ExpandEnvironmentVariableInput>> expandEnvironmentVariable)
        {
            var __workflow_expandEnvironmentVariable = WorkflowExpression.Compile(expandEnvironmentVariable, nameof(expandEnvironmentVariable), required: true);
            return new DeferredBodyAction<ExpandEnvironmentVariableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/ExpandEnvironmentVariable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_expandEnvironmentVariable);
                return new ApiConnectionAction<ExpandEnvironmentVariableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillProcessResponse, ApiConnectionActionConfiguration> KillProcess(Expression<Func<KillProcessInput>> killProcess)
        {
            var __workflow_killProcess = WorkflowExpression.Compile(killProcess, nameof(killProcess), required: true);
            return new DeferredBodyAction<KillProcessResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/KillProcess";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_killProcess);
                return new ApiConnectionAction<KillProcessResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillProcessIdResponse, ApiConnectionActionConfiguration> KillProcessId(Expression<Func<KillProcessIdInput>> killProcessId)
        {
            var __workflow_killProcessId = WorkflowExpression.Compile(killProcessId, nameof(killProcessId), required: true);
            return new DeferredBodyAction<KillProcessIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/KillProcessID";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_killProcessId);
                return new ApiConnectionAction<KillProcessIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessCountByNameResponse, ApiConnectionActionConfiguration> GetProcessCountByName(Expression<Func<GetProcessCountByNameInput>> getProcessCountByName)
        {
            var __workflow_getProcessCountByName = WorkflowExpression.Compile(getProcessCountByName, nameof(getProcessCountByName), required: true);
            return new DeferredBodyAction<GetProcessCountByNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetProcessCountByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getProcessCountByName);
                return new ApiConnectionAction<GetProcessCountByNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentProcessCountResponse, ApiConnectionActionConfiguration> GetAgentProcessCount(Expression<Func<GetAgentProcessCountInput>> getAgentProcessCount)
        {
            var __workflow_getAgentProcessCount = WorkflowExpression.Compile(getAgentProcessCount, nameof(getAgentProcessCount), required: true);
            return new DeferredBodyAction<GetAgentProcessCountResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetAgentProcessCount";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getAgentProcessCount);
                return new ApiConnectionAction<GetAgentProcessCountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillAllOtherAgentsResponse, ApiConnectionActionConfiguration> KillAllOtherAgents(Expression<Func<KillAllOtherAgentsInput>> killAllOtherAgents)
        {
            var __workflow_killAllOtherAgents = WorkflowExpression.Compile(killAllOtherAgents, nameof(killAllOtherAgents), required: true);
            return new DeferredBodyAction<KillAllOtherAgentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/KillAllOtherAgents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_killAllOtherAgents);
                return new ApiConnectionAction<KillAllOtherAgentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessByPidResponse, ApiConnectionActionConfiguration> GetProcessByPid(Expression<Func<GetProcessByPidInput>> getProcessByPid)
        {
            var __workflow_getProcessByPid = WorkflowExpression.Compile(getProcessByPid, nameof(getProcessByPid), required: true);
            return new DeferredBodyAction<GetProcessByPidResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetProcessByPID";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getProcessByPid);
                return new ApiConnectionAction<GetProcessByPidResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessesResponse, ApiConnectionActionConfiguration> GetProcesses(Expression<Func<GetProcessesInput>> getProcesses)
        {
            var __workflow_getProcesses = WorkflowExpression.Compile(getProcesses, nameof(getProcesses), required: true);
            return new DeferredBodyAction<GetProcessesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetProcesses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getProcesses);
                return new ApiConnectionAction<GetProcessesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunProcessResponse, ApiConnectionActionConfiguration> RunProcess(Expression<Func<RunProcessInput>> runProcess)
        {
            var __workflow_runProcess = WorkflowExpression.Compile(runProcess, nameof(runProcess), required: true);
            return new DeferredBodyAction<RunProcessResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/RunProcess";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_runProcess);
                return new ApiConnectionAction<RunProcessResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunPowerShellProcessResponse, ApiConnectionActionConfiguration> RunPowerShellProcess(Expression<Func<RunPowerShellProcessInput>> runPowerShellProcess)
        {
            var __workflow_runPowerShellProcess = WorkflowExpression.Compile(runPowerShellProcess, nameof(runPowerShellProcess), required: true);
            return new DeferredBodyAction<RunPowerShellProcessResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/RunPowerShellProcess";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_runPowerShellProcess);
                return new ApiConnectionAction<RunPowerShellProcessResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetScreenResolutionResponse, ApiConnectionActionConfiguration> GetScreenResolution(Expression<Func<GetScreenResolutionInput>> getScreenResolution)
        {
            var __workflow_getScreenResolution = WorkflowExpression.Compile(getScreenResolution, nameof(getScreenResolution), required: true);
            return new DeferredBodyAction<GetScreenResolutionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetScreenResolution";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getScreenResolution);
                return new ApiConnectionAction<GetScreenResolutionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetDefaultPrinter(Expression<Func<SetDefaultPrinterInput>> setDefaultPrinter)
        {
            var __workflow_setDefaultPrinter = WorkflowExpression.Compile(setDefaultPrinter, nameof(setDefaultPrinter), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/SetDefaultPrinter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_setDefaultPrinter);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetDefaultPrinterResponse, ApiConnectionActionConfiguration> GetDefaultPrinter(Expression<Func<GetDefaultPrinterInput>> getDefaultPrinter)
        {
            var __workflow_getDefaultPrinter = WorkflowExpression.Compile(getDefaultPrinter, nameof(getDefaultPrinter), required: true);
            return new DeferredBodyAction<GetDefaultPrinterResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetDefaultPrinter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getDefaultPrinter);
                return new ApiConnectionAction<GetDefaultPrinterResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetListOfPrintersResponse, ApiConnectionActionConfiguration> GetListOfPrinters(Expression<Func<GetListOfPrintersInput>> getListOfPrinters)
        {
            var __workflow_getListOfPrinters = WorkflowExpression.Compile(getListOfPrinters, nameof(getListOfPrinters), required: true);
            return new DeferredBodyAction<GetListOfPrintersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetListOfPrinters";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getListOfPrinters);
                return new ApiConnectionAction<GetListOfPrintersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetMouseMultiplier(Expression<Func<SetMouseMultiplierInput>> setMouseMultiplier)
        {
            var __workflow_setMouseMultiplier = WorkflowExpression.Compile(setMouseMultiplier, nameof(setMouseMultiplier), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/SetMouseMultiplier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_setMouseMultiplier);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetMouseMultiplierResponse, ApiConnectionActionConfiguration> GetMouseMultiplier(Expression<Func<GetMouseMultiplierInput>> getMouseMultiplier)
        {
            var __workflow_getMouseMultiplier = WorkflowExpression.Compile(getMouseMultiplier, nameof(getMouseMultiplier), required: true);
            return new DeferredBodyAction<GetMouseMultiplierResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetMouseMultiplier";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getMouseMultiplier);
                return new ApiConnectionAction<GetMouseMultiplierResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MoveMouseToCoordinate(Expression<Func<MoveMouseToCoordinateInput>> moveMouseToCoordinate)
        {
            var __workflow_moveMouseToCoordinate = WorkflowExpression.Compile(moveMouseToCoordinate, nameof(moveMouseToCoordinate), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/MoveMouseToCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_moveMouseToCoordinate);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MoveMouseRelative(Expression<Func<MoveMouseRelativeInput>> moveMouseRelative)
        {
            var __workflow_moveMouseRelative = WorkflowExpression.Compile(moveMouseRelative, nameof(moveMouseRelative), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/MoveMouseRelative";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_moveMouseRelative);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LeftMouseButtonDown(Expression<Func<LeftMouseButtonDownInput>> leftMouseButtonDown)
        {
            var __workflow_leftMouseButtonDown = WorkflowExpression.Compile(leftMouseButtonDown, nameof(leftMouseButtonDown), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/LeftMouseButtonDown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_leftMouseButtonDown);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LeftMouseButtonUp(Expression<Func<LeftMouseButtonUpInput>> leftMouseButtonUp)
        {
            var __workflow_leftMouseButtonUp = WorkflowExpression.Compile(leftMouseButtonUp, nameof(leftMouseButtonUp), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/LeftMouseButtonUp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_leftMouseButtonUp);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LeftClickMouse(Expression<Func<LeftClickMouseInput>> leftClickMouse)
        {
            var __workflow_leftClickMouse = WorkflowExpression.Compile(leftClickMouse, nameof(leftClickMouse), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/LeftClickMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_leftClickMouse);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LeftClickMouseAtCoordinate(Expression<Func<LeftClickMouseAtCoordinateInput>> leftClickMouseAtCoordinate)
        {
            var __workflow_leftClickMouseAtCoordinate = WorkflowExpression.Compile(leftClickMouseAtCoordinate, nameof(leftClickMouseAtCoordinate), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/LeftClickMouseAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_leftClickMouseAtCoordinate);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LeftHoldMouse(Expression<Func<LeftHoldMouseInput>> leftHoldMouse)
        {
            var __workflow_leftHoldMouse = WorkflowExpression.Compile(leftHoldMouse, nameof(leftHoldMouse), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/LeftHoldMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_leftHoldMouse);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LeftHoldMouseAtCoordinate(Expression<Func<LeftHoldMouseAtCoordinateInput>> leftHoldMouseAtCoordinate)
        {
            var __workflow_leftHoldMouseAtCoordinate = WorkflowExpression.Compile(leftHoldMouseAtCoordinate, nameof(leftHoldMouseAtCoordinate), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/LeftHoldMouseAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_leftHoldMouseAtCoordinate);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RightMouseButtonDown(Expression<Func<RightMouseButtonDownInput>> rightMouseButtonDown)
        {
            var __workflow_rightMouseButtonDown = WorkflowExpression.Compile(rightMouseButtonDown, nameof(rightMouseButtonDown), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/RightMouseButtonDown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_rightMouseButtonDown);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RightMouseButtonUp(Expression<Func<RightMouseButtonUpInput>> rightMouseButtonUp)
        {
            var __workflow_rightMouseButtonUp = WorkflowExpression.Compile(rightMouseButtonUp, nameof(rightMouseButtonUp), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/RightMouseButtonUp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_rightMouseButtonUp);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RightClickMouse(Expression<Func<RightClickMouseInput>> rightClickMouse)
        {
            var __workflow_rightClickMouse = WorkflowExpression.Compile(rightClickMouse, nameof(rightClickMouse), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/RightClickMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_rightClickMouse);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RightClickMouseAtCoordinate(Expression<Func<RightClickMouseAtCoordinateInput>> rightClickMouseAtCoordinate)
        {
            var __workflow_rightClickMouseAtCoordinate = WorkflowExpression.Compile(rightClickMouseAtCoordinate, nameof(rightClickMouseAtCoordinate), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/RightClickMouseAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_rightClickMouseAtCoordinate);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RightHoldMouse(Expression<Func<RightHoldMouseInput>> rightHoldMouse)
        {
            var __workflow_rightHoldMouse = WorkflowExpression.Compile(rightHoldMouse, nameof(rightHoldMouse), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/RightHoldMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_rightHoldMouse);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RightHoldMouseAtCoordinate(Expression<Func<RightHoldMouseAtCoordinateInput>> rightHoldMouseAtCoordinate)
        {
            var __workflow_rightHoldMouseAtCoordinate = WorkflowExpression.Compile(rightHoldMouseAtCoordinate, nameof(rightHoldMouseAtCoordinate), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/RightHoldMouseAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_rightHoldMouseAtCoordinate);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MiddleMouseButtonDown(Expression<Func<MiddleMouseButtonDownInput>> middleMouseButtonDown)
        {
            var __workflow_middleMouseButtonDown = WorkflowExpression.Compile(middleMouseButtonDown, nameof(middleMouseButtonDown), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/MiddleMouseButtonDown";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_middleMouseButtonDown);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MiddleMouseButtonUp(Expression<Func<MiddleMouseButtonUpInput>> middleMouseButtonUp)
        {
            var __workflow_middleMouseButtonUp = WorkflowExpression.Compile(middleMouseButtonUp, nameof(middleMouseButtonUp), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/MiddleMouseButtonUp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_middleMouseButtonUp);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MiddleClickMouse(Expression<Func<MiddleClickMouseInput>> middleClickMouse)
        {
            var __workflow_middleClickMouse = WorkflowExpression.Compile(middleClickMouse, nameof(middleClickMouse), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/MiddleClickMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_middleClickMouse);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MiddleClickMouseAtCoordinate(Expression<Func<MiddleClickMouseAtCoordinateInput>> middleClickMouseAtCoordinate)
        {
            var __workflow_middleClickMouseAtCoordinate = WorkflowExpression.Compile(middleClickMouseAtCoordinate, nameof(middleClickMouseAtCoordinate), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/MiddleClickMouseAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_middleClickMouseAtCoordinate);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MiddleHoldMouse(Expression<Func<MiddleHoldMouseInput>> middleHoldMouse)
        {
            var __workflow_middleHoldMouse = WorkflowExpression.Compile(middleHoldMouse, nameof(middleHoldMouse), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/MiddleHoldMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_middleHoldMouse);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MiddleHoldMouseAtCoordinate(Expression<Func<MiddleHoldMouseAtCoordinateInput>> middleHoldMouseAtCoordinate)
        {
            var __workflow_middleHoldMouseAtCoordinate = WorkflowExpression.Compile(middleHoldMouseAtCoordinate, nameof(middleHoldMouseAtCoordinate), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/MiddleHoldMouseAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_middleHoldMouseAtCoordinate);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DoubleLeftClickMouse(Expression<Func<DoubleLeftClickMouseInput>> doubleLeftClickMouse)
        {
            var __workflow_doubleLeftClickMouse = WorkflowExpression.Compile(doubleLeftClickMouse, nameof(doubleLeftClickMouse), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/DoubleLeftClickMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_doubleLeftClickMouse);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DoubleLeftClickMouseAtCoordinate(Expression<Func<DoubleLeftClickMouseAtCoordinateInput>> doubleLeftClickMouseAtCoordinate)
        {
            var __workflow_doubleLeftClickMouseAtCoordinate = WorkflowExpression.Compile(doubleLeftClickMouseAtCoordinate, nameof(doubleLeftClickMouseAtCoordinate), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/DoubleLeftClickMouseAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_doubleLeftClickMouseAtCoordinate);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LeftMouseDragBetweenCoordinates(Expression<Func<LeftMouseDragBetweenCoordinatesInput>> leftMouseDragBetweenCoordinates)
        {
            var __workflow_leftMouseDragBetweenCoordinates = WorkflowExpression.Compile(leftMouseDragBetweenCoordinates, nameof(leftMouseDragBetweenCoordinates), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/LeftMouseDragBetweenCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_leftMouseDragBetweenCoordinates);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RightMouseDragBetweenCoordinates(Expression<Func<RightMouseDragBetweenCoordinatesInput>> rightMouseDragBetweenCoordinates)
        {
            var __workflow_rightMouseDragBetweenCoordinates = WorkflowExpression.Compile(rightMouseDragBetweenCoordinates, nameof(rightMouseDragBetweenCoordinates), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/RightMouseDragBetweenCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_rightMouseDragBetweenCoordinates);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MiddleMouseDragBetweenCoordinates(Expression<Func<MiddleMouseDragBetweenCoordinatesInput>> middleMouseDragBetweenCoordinates)
        {
            var __workflow_middleMouseDragBetweenCoordinates = WorkflowExpression.Compile(middleMouseDragBetweenCoordinates, nameof(middleMouseDragBetweenCoordinates), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/MiddleMouseDragBetweenCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_middleMouseDragBetweenCoordinates);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MoveMouseBetweenCoordinates(Expression<Func<MoveMouseBetweenCoordinatesInput>> moveMouseBetweenCoordinates)
        {
            var __workflow_moveMouseBetweenCoordinates = WorkflowExpression.Compile(moveMouseBetweenCoordinates, nameof(moveMouseBetweenCoordinates), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/MoveMouseBetweenCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_moveMouseBetweenCoordinates);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TurnMouseWheel(Expression<Func<TurnMouseWheelInput>> turnMouseWheel)
        {
            var __workflow_turnMouseWheel = WorkflowExpression.Compile(turnMouseWheel, nameof(turnMouseWheel), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/TurnMouseWheel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_turnMouseWheel);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetCursorPos(Expression<Func<SetCursorPosInput>> setCursorPos)
        {
            var __workflow_setCursorPos = WorkflowExpression.Compile(setCursorPos, nameof(setCursorPos), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/SetCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_setCursorPos);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetCursorPosResponse, ApiConnectionActionConfiguration> GetCursorPos(Expression<Func<GetCursorPosInput>> getCursorPos)
        {
            var __workflow_getCursorPos = WorkflowExpression.Compile(getCursorPos, nameof(getCursorPos), required: true);
            return new DeferredBodyAction<GetCursorPosResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getCursorPos);
                return new ApiConnectionAction<GetCursorPosResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CalibrateMouseEventResponse, ApiConnectionActionConfiguration> CalibrateMouseEvent(Expression<Func<CalibrateMouseEventInput>> calibrateMouseEvent)
        {
            var __workflow_calibrateMouseEvent = WorkflowExpression.Compile(calibrateMouseEvent, nameof(calibrateMouseEvent), required: true);
            return new DeferredBodyAction<CalibrateMouseEventResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/CalibrateMouseEvent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_calibrateMouseEvent);
                return new ApiConnectionAction<CalibrateMouseEventResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetMouseMoveMethodResponse, ApiConnectionActionConfiguration> GetMouseMoveMethod(Expression<Func<GetMouseMoveMethodInput>> getMouseMoveMethod)
        {
            var __workflow_getMouseMoveMethod = WorkflowExpression.Compile(getMouseMoveMethod, nameof(getMouseMoveMethod), required: true);
            return new DeferredBodyAction<GetMouseMoveMethodResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetMouseMoveMethod";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getMouseMoveMethod);
                return new ApiConnectionAction<GetMouseMoveMethodResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetMouseMoveMethod(Expression<Func<SetMouseMoveMethodInput>> setMouseMoveMethod)
        {
            var __workflow_setMouseMoveMethod = WorkflowExpression.Compile(setMouseMoveMethod, nameof(setMouseMoveMethod), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/SetMouseMoveMethod";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_setMouseMoveMethod);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> WiggleMouse(Expression<Func<WiggleMouseInput>> wiggleMouse)
        {
            var __workflow_wiggleMouse = WorkflowExpression.Compile(wiggleMouse, nameof(wiggleMouse), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/WiggleMouse";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_wiggleMouse);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendKeyEvents(Expression<Func<SendKeyEventsInput>> sendKeyEvents)
        {
            var __workflow_sendKeyEvents = WorkflowExpression.Compile(sendKeyEvents, nameof(sendKeyEvents), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/SendKeyEvents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sendKeyEvents);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendPasswordKeyEvents(Expression<Func<SendPasswordKeyEventsInput>> sendPasswordKeyEvents)
        {
            var __workflow_sendPasswordKeyEvents = WorkflowExpression.Compile(sendPasswordKeyEvents, nameof(sendPasswordKeyEvents), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/SendPasswordKeyEvents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sendPasswordKeyEvents);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendKeys(Expression<Func<SendKeysInput>> sendKeys)
        {
            var __workflow_sendKeys = WorkflowExpression.Compile(sendKeys, nameof(sendKeys), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/SendKeys";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sendKeys);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendPasswordKeys(Expression<Func<SendPasswordKeysInput>> sendPasswordKeys)
        {
            var __workflow_sendPasswordKeys = WorkflowExpression.Compile(sendPasswordKeys, nameof(sendPasswordKeys), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/SendPasswordKeys";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sendPasswordKeys);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ClearClipboard(Expression<Func<ClearClipboardInput>> clearClipboard)
        {
            var __workflow_clearClipboard = WorkflowExpression.Compile(clearClipboard, nameof(clearClipboard), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/ClearClipboard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_clearClipboard);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetClipboardData(Expression<Func<SetClipboardDataInput>> setClipboardData)
        {
            var __workflow_setClipboardData = WorkflowExpression.Compile(setClipboardData, nameof(setClipboardData), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/SetClipboardData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_setClipboardData);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetClipboardDataResponse, ApiConnectionActionConfiguration> GetClipboardData(Expression<Func<GetClipboardDataInput>> getClipboardData)
        {
            var __workflow_getClipboardData = WorkflowExpression.Compile(getClipboardData, nameof(getClipboardData), required: true);
            return new DeferredBodyAction<GetClipboardDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetClipboardData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getClipboardData);
                return new ApiConnectionAction<GetClipboardDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TakeScreenshotResponse, ApiConnectionActionConfiguration> TakeScreenshot(Expression<Func<TakeScreenshotInput>> takeScreenshot)
        {
            var __workflow_takeScreenshot = WorkflowExpression.Compile(takeScreenshot, nameof(takeScreenshot), required: true);
            return new DeferredBodyAction<TakeScreenshotResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/TakeScreenshot";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_takeScreenshot);
                return new ApiConnectionAction<TakeScreenshotResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetEnvironmentInfoResponse, ApiConnectionActionConfiguration> GetEnvironmentInfo(Expression<Func<GetEnvironmentInfoInput>> getEnvironmentInfo)
        {
            var __workflow_getEnvironmentInfo = WorkflowExpression.Compile(getEnvironmentInfo, nameof(getEnvironmentInfo), required: true);
            return new DeferredBodyAction<GetEnvironmentInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetEnvironmentInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getEnvironmentInfo);
                return new ApiConnectionAction<GetEnvironmentInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<IsScreenReaderEnabledResponse, ApiConnectionActionConfiguration> IsScreenReaderEnabled(Expression<Func<IsScreenReaderEnabledInput>> isScreenReaderEnabled)
        {
            var __workflow_isScreenReaderEnabled = WorkflowExpression.Compile(isScreenReaderEnabled, nameof(isScreenReaderEnabled), required: true);
            return new DeferredBodyAction<IsScreenReaderEnabledResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/IsScreenReaderEnabled";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_isScreenReaderEnabled);
                return new ApiConnectionAction<IsScreenReaderEnabledResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetScreenReader(Expression<Func<SetScreenReaderInput>> setScreenReader)
        {
            var __workflow_setScreenReader = WorkflowExpression.Compile(setScreenReader, nameof(setScreenReader), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/SetScreenReader";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_setScreenReader);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetParentProcessIdResponse, ApiConnectionActionConfiguration> GetParentProcessId(Expression<Func<GetParentProcessIdInput>> getParentProcessId)
        {
            var __workflow_getParentProcessId = WorkflowExpression.Compile(getParentProcessId, nameof(getParentProcessId), required: true);
            return new DeferredBodyAction<GetParentProcessIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetParentProcessId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getParentProcessId);
                return new ApiConnectionAction<GetParentProcessIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetProcessIdCommandLineResponse, ApiConnectionActionConfiguration> GetProcessIdCommandLine(Expression<Func<GetProcessIdCommandLineInput>> getProcessIdCommandLine)
        {
            var __workflow_getProcessIdCommandLine = WorkflowExpression.Compile(getProcessIdCommandLine, nameof(getProcessIdCommandLine), required: true);
            return new DeferredBodyAction<GetProcessIdCommandLineResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetProcessIdCommandLine";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getProcessIdCommandLine);
                return new ApiConnectionAction<GetProcessIdCommandLineResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLastInputInfoResponse, ApiConnectionActionConfiguration> GetLastInputInfo(Expression<Func<GetLastInputInfoInput>> getLastInputInfo)
        {
            var __workflow_getLastInputInfo = WorkflowExpression.Compile(getLastInputInfo, nameof(getLastInputInfo), required: true);
            return new DeferredBodyAction<GetLastInputInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetLastInputInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getLastInputInfo);
                return new ApiConnectionAction<GetLastInputInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KeepSessionAliveResponse, ApiConnectionActionConfiguration> KeepSessionAlive(Expression<Func<KeepSessionAliveInput>> keepSessionAlive)
        {
            var __workflow_keepSessionAlive = WorkflowExpression.Compile(keepSessionAlive, nameof(keepSessionAlive), required: true);
            return new DeferredBodyAction<KeepSessionAliveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/KeepSessionAlive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_keepSessionAlive);
                return new ApiConnectionAction<KeepSessionAliveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<StopKeepSessionAliveResponse, ApiConnectionActionConfiguration> StopKeepSessionAlive(Expression<Func<StopKeepSessionAliveInput>> stopKeepSessionAlive)
        {
            var __workflow_stopKeepSessionAlive = WorkflowExpression.Compile(stopKeepSessionAlive, nameof(stopKeepSessionAlive), required: true);
            return new DeferredBodyAction<StopKeepSessionAliveResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/StopKeepSessionAlive";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_stopKeepSessionAlive);
                return new ApiConnectionAction<StopKeepSessionAliveResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CopyFileToClipboardResponse, ApiConnectionActionConfiguration> CopyFileToClipboard(Expression<Func<CopyFileToClipboardInput>> copyFileToClipboard)
        {
            var __workflow_copyFileToClipboard = WorkflowExpression.Compile(copyFileToClipboard, nameof(copyFileToClipboard), required: true);
            return new DeferredBodyAction<CopyFileToClipboardResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/CopyFileToClipboard";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_copyFileToClipboard);
                return new ApiConnectionAction<CopyFileToClipboardResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteSessionInfoResponse, ApiConnectionActionConfiguration> GetRemoteSessionInfo(Expression<Func<GetRemoteSessionInfoInput>> getRemoteSessionInfo)
        {
            var __workflow_getRemoteSessionInfo = WorkflowExpression.Compile(getRemoteSessionInfo, nameof(getRemoteSessionInfo), required: true);
            return new DeferredBodyAction<GetRemoteSessionInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetRemoteSessionInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getRemoteSessionInfo);
                return new ApiConnectionAction<GetRemoteSessionInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GeneratePasswordResponse, ApiConnectionActionConfiguration> GeneratePassword(Expression<Func<GeneratePasswordInput>> generatePassword)
        {
            var __workflow_generatePassword = WorkflowExpression.Compile(generatePassword, nameof(generatePassword), required: true);
            return new DeferredBodyAction<GeneratePasswordResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GeneratePassword";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_generatePassword);
                return new ApiConnectionAction<GeneratePasswordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetStoredPasswordResponse, ApiConnectionActionConfiguration> GetStoredPassword(Expression<Func<GetStoredPasswordInput>> getStoredPassword)
        {
            var __workflow_getStoredPassword = WorkflowExpression.Compile(getStoredPassword, nameof(getStoredPassword), required: true);
            return new DeferredBodyAction<GetStoredPasswordResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetStoredPassword";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getStoredPassword);
                return new ApiConnectionAction<GetStoredPasswordResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ExpandPasswordStringResponse, ApiConnectionActionConfiguration> ExpandPasswordString(Expression<Func<ExpandPasswordStringInput>> expandPasswordString)
        {
            var __workflow_expandPasswordString = WorkflowExpression.Compile(expandPasswordString, nameof(expandPasswordString), required: true);
            return new DeferredBodyAction<ExpandPasswordStringResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/ExpandPasswordString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_expandPasswordString);
                return new ApiConnectionAction<ExpandPasswordStringResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<StorePasswordInAgentMemoryResponse, ApiConnectionActionConfiguration> StorePasswordInAgentMemory(Expression<Func<StorePasswordInAgentMemoryInput>> storePasswordInAgentMemory)
        {
            var __workflow_storePasswordInAgentMemory = WorkflowExpression.Compile(storePasswordInAgentMemory, nameof(storePasswordInAgentMemory), required: true);
            return new DeferredBodyAction<StorePasswordInAgentMemoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/StorePasswordInAgentMemory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_storePasswordInAgentMemory);
                return new ApiConnectionAction<StorePasswordInAgentMemoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DeletePasswordInAgentMemoryResponse, ApiConnectionActionConfiguration> DeletePasswordInAgentMemory(Expression<Func<DeletePasswordInAgentMemoryInput>> deletePasswordInAgentMemory)
        {
            var __workflow_deletePasswordInAgentMemory = WorkflowExpression.Compile(deletePasswordInAgentMemory, nameof(deletePasswordInAgentMemory), required: true);
            return new DeferredBodyAction<DeletePasswordInAgentMemoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/DeletePasswordInAgentMemory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_deletePasswordInAgentMemory);
                return new ApiConnectionAction<DeletePasswordInAgentMemoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CredentialWriteResponse, ApiConnectionActionConfiguration> CredentialWrite(Expression<Func<CredentialWriteInput>> credentialWrite)
        {
            var __workflow_credentialWrite = WorkflowExpression.Compile(credentialWrite, nameof(credentialWrite), required: true);
            return new DeferredBodyAction<CredentialWriteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/CredentialWrite";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_credentialWrite);
                return new ApiConnectionAction<CredentialWriteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CredentialReadResponse, ApiConnectionActionConfiguration> CredentialRead(Expression<Func<CredentialReadInput>> credentialRead)
        {
            var __workflow_credentialRead = WorkflowExpression.Compile(credentialRead, nameof(credentialRead), required: true);
            return new DeferredBodyAction<CredentialReadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/CredentialRead";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_credentialRead);
                return new ApiConnectionAction<CredentialReadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CredentialDeleteResponse, ApiConnectionActionConfiguration> CredentialDelete(Expression<Func<CredentialDeleteInput>> credentialDelete)
        {
            var __workflow_credentialDelete = WorkflowExpression.Compile(credentialDelete, nameof(credentialDelete), required: true);
            return new DeferredBodyAction<CredentialDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/CredentialDelete";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_credentialDelete);
                return new ApiConnectionAction<CredentialDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GenerateRdpFileResponse, ApiConnectionActionConfiguration> GenerateRdpFile(Expression<Func<GenerateRdpFileInput>> generateRdpFile)
        {
            var __workflow_generateRdpFile = WorkflowExpression.Compile(generateRdpFile, nameof(generateRdpFile), required: true);
            return new DeferredBodyAction<GenerateRdpFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GenerateRDPFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_generateRdpFile);
                return new ApiConnectionAction<GenerateRdpFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<LaunchRemoteDesktopSessionResponse, ApiConnectionActionConfiguration> LaunchRemoteDesktopSession(Expression<Func<LaunchRemoteDesktopSessionInput>> launchRemoteDesktopSession)
        {
            var __workflow_launchRemoteDesktopSession = WorkflowExpression.Compile(launchRemoteDesktopSession, nameof(launchRemoteDesktopSession), required: true);
            return new DeferredBodyAction<LaunchRemoteDesktopSessionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/LaunchRemoteDesktopSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_launchRemoteDesktopSession);
                return new ApiConnectionAction<LaunchRemoteDesktopSessionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<IsTcpPortRespondingResponse, ApiConnectionActionConfiguration> IsTcpPortResponding(Expression<Func<IsTcpPortRespondingInput>> isTcpPortResponding)
        {
            var __workflow_isTcpPortResponding = WorkflowExpression.Compile(isTcpPortResponding, nameof(isTcpPortResponding), required: true);
            return new DeferredBodyAction<IsTcpPortRespondingResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/IsTCPPortResponding";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_isTcpPortResponding);
                return new ApiConnectionAction<IsTcpPortRespondingResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<UnlockSessionResponse, ApiConnectionActionConfiguration> UnlockSession(Expression<Func<UnlockSessionInput>> unlockSession)
        {
            var __workflow_unlockSession = WorkflowExpression.Compile(unlockSession, nameof(unlockSession), required: true);
            return new DeferredBodyAction<UnlockSessionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/UnlockSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_unlockSession);
                return new ApiConnectionAction<UnlockSessionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<LockSessionResponse, ApiConnectionActionConfiguration> LockSession(Expression<Func<LockSessionInput>> lockSession)
        {
            var __workflow_lockSession = WorkflowExpression.Compile(lockSession, nameof(lockSession), required: true);
            return new DeferredBodyAction<LockSessionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/LockSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_lockSession);
                return new ApiConnectionAction<LockSessionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<IsSessionLockedResponse, ApiConnectionActionConfiguration> IsSessionLocked(Expression<Func<IsSessionLockedInput>> isSessionLocked)
        {
            var __workflow_isSessionLocked = WorkflowExpression.Compile(isSessionLocked, nameof(isSessionLocked), required: true);
            return new DeferredBodyAction<IsSessionLockedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/IsSessionLocked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_isSessionLocked);
                return new ApiConnectionAction<IsSessionLockedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetGenericCredentialFromOrchestratorResponse, ApiConnectionActionConfiguration> GetGenericCredentialFromOrchestrator(Expression<Func<GetGenericCredentialFromOrchestratorInput>> getGenericCredentialFromOrchestrator)
        {
            var __workflow_getGenericCredentialFromOrchestrator = WorkflowExpression.Compile(getGenericCredentialFromOrchestrator, nameof(getGenericCredentialFromOrchestrator), required: true);
            return new DeferredBodyAction<GetGenericCredentialFromOrchestratorResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetGenericCredentialFromOrchestrator";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getGenericCredentialFromOrchestrator);
                return new ApiConnectionAction<GetGenericCredentialFromOrchestratorResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DrawRectangleOnScreenResponse, ApiConnectionActionConfiguration> DrawRectangleOnScreen(Expression<Func<DrawRectangleOnScreenInput>> drawRectangleOnScreen)
        {
            var __workflow_drawRectangleOnScreen = WorkflowExpression.Compile(drawRectangleOnScreen, nameof(drawRectangleOnScreen), required: true);
            return new DeferredBodyAction<DrawRectangleOnScreenResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/DrawRectangleOnScreen";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_drawRectangleOnScreen);
                return new ApiConnectionAction<DrawRectangleOnScreenResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFailedActionErrorMessageFromPowerAutomateResultJsonResponse, ApiConnectionActionConfiguration> GetFailedActionErrorMessageFromPowerAutomateResultJson(Expression<Func<GetFailedActionErrorMessageFromPowerAutomateResultJsonInput>> getFailedActionErrorMessageFromPowerAutomateResultJson)
        {
            var __workflow_getFailedActionErrorMessageFromPowerAutomateResultJson = WorkflowExpression.Compile(getFailedActionErrorMessageFromPowerAutomateResultJson, nameof(getFailedActionErrorMessageFromPowerAutomateResultJson), required: true);
            return new DeferredBodyAction<GetFailedActionErrorMessageFromPowerAutomateResultJsonResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetFailedActionErrorMessageFromPowerAutomateResultJSON";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getFailedActionErrorMessageFromPowerAutomateResultJson);
                return new ApiConnectionAction<GetFailedActionErrorMessageFromPowerAutomateResultJsonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetPixelColourAtCoordinateResponse, ApiConnectionActionConfiguration> GetPixelColourAtCoordinate(Expression<Func<GetPixelColourAtCoordinateInput>> getPixelColourAtCoordinate)
        {
            var __workflow_getPixelColourAtCoordinate = WorkflowExpression.Compile(getPixelColourAtCoordinate, nameof(getPixelColourAtCoordinate), required: true);
            return new DeferredBodyAction<GetPixelColourAtCoordinateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/GetPixelColourAtCoordinate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getPixelColourAtCoordinate);
                return new ApiConnectionAction<GetPixelColourAtCoordinateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ConvertRectangleCoordinatesResponse, ApiConnectionActionConfiguration> ConvertRectangleCoordinates(Expression<Func<ConvertRectangleCoordinatesInput>> convertRectangleCoordinates)
        {
            var __workflow_convertRectangleCoordinates = WorkflowExpression.Compile(convertRectangleCoordinates, nameof(convertRectangleCoordinates), required: true);
            return new DeferredBodyAction<ConvertRectangleCoordinatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/ConvertRectangleCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_convertRectangleCoordinates);
                return new ApiConnectionAction<ConvertRectangleCoordinatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SendMessageToWebApiResponse, ApiConnectionActionConfiguration> SendMessageToWebApi(Expression<Func<SendMessageToWebApiInput>> sendMessageToWebApi)
        {
            var __workflow_sendMessageToWebApi = WorkflowExpression.Compile(sendMessageToWebApi, nameof(sendMessageToWebApi), required: true);
            return new DeferredBodyAction<SendMessageToWebApiResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/SendMessageToWebAPI";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_sendMessageToWebApi);
                return new ApiConnectionAction<SendMessageToWebApiResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewTaskResponse, ApiConnectionActionConfiguration> TasksAddNewTask(Expression<Func<TasksAddNewTaskInput>> tasksAddNewTask)
        {
            var __workflow_tasksAddNewTask = WorkflowExpression.Compile(tasksAddNewTask, nameof(tasksAddNewTask), required: true);
            return new DeferredBodyAction<TasksAddNewTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/TasksAddNewTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_tasksAddNewTask);
                return new ApiConnectionAction<TasksAddNewTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewDeferralResponse, ApiConnectionActionConfiguration> TasksAddNewDeferral(Expression<Func<TasksAddNewDeferralInput>> tasksAddNewDeferral)
        {
            var __workflow_tasksAddNewDeferral = WorkflowExpression.Compile(tasksAddNewDeferral, nameof(tasksAddNewDeferral), required: true);
            return new DeferredBodyAction<TasksAddNewDeferralResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/TasksAddNewDeferral";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferral);
                return new ApiConnectionAction<TasksAddNewDeferralResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksDeferExistingTaskResponse, ApiConnectionActionConfiguration> TasksDeferExistingTask(Expression<Func<TasksDeferExistingTaskInput>> tasksDeferExistingTask)
        {
            var __workflow_tasksDeferExistingTask = WorkflowExpression.Compile(tasksDeferExistingTask, nameof(tasksDeferExistingTask), required: true);
            return new DeferredBodyAction<TasksDeferExistingTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/TasksDeferExistingTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_tasksDeferExistingTask);
                return new ApiConnectionAction<TasksDeferExistingTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksDeferExistingTaskOperationResponse, ApiConnectionActionConfiguration> TasksDeferExistingTaskOperation(Expression<Func<TasksDeferExistingTaskOperationInput>> tasksDeferExistingTaskOperation)
        {
            var __workflow_tasksDeferExistingTaskOperation = WorkflowExpression.Compile(tasksDeferExistingTaskOperation, nameof(tasksDeferExistingTaskOperation), required: true);
            return new DeferredBodyAction<TasksDeferExistingTaskOperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/TasksDeferExistingTaskOperation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_tasksDeferExistingTaskOperation);
                return new ApiConnectionAction<TasksDeferExistingTaskOperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksDeleteTaskResponse, ApiConnectionActionConfiguration> TasksDeleteTask(Expression<Func<TasksDeleteTaskInput>> tasksDeleteTask)
        {
            var __workflow_tasksDeleteTask = WorkflowExpression.Compile(tasksDeleteTask, nameof(tasksDeleteTask), required: true);
            return new DeferredBodyAction<TasksDeleteTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/TasksDeleteTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_tasksDeleteTask);
                return new ApiConnectionAction<TasksDeleteTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksDeleteTaskOperationResponse, ApiConnectionActionConfiguration> TasksDeleteTaskOperation(Expression<Func<TasksDeleteTaskOperationInput>> tasksDeleteTaskOperation)
        {
            var __workflow_tasksDeleteTaskOperation = WorkflowExpression.Compile(tasksDeleteTaskOperation, nameof(tasksDeleteTaskOperation), required: true);
            return new DeferredBodyAction<TasksDeleteTaskOperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/TasksDeleteTaskOperation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_tasksDeleteTaskOperation);
                return new ApiConnectionAction<TasksDeleteTaskOperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksGetAllTasksResponse, ApiConnectionActionConfiguration> TasksGetAllTasks(Expression<Func<TasksGetAllTasksInput>> tasksGetAllTasks)
        {
            var __workflow_tasksGetAllTasks = WorkflowExpression.Compile(tasksGetAllTasks, nameof(tasksGetAllTasks), required: true);
            return new DeferredBodyAction<TasksGetAllTasksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/TasksGetAllTasks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_tasksGetAllTasks);
                return new ApiConnectionAction<TasksGetAllTasksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksGetTaskResponse, ApiConnectionActionConfiguration> TasksGetTask(Expression<Func<TasksGetTaskInput>> tasksGetTask)
        {
            var __workflow_tasksGetTask = WorkflowExpression.Compile(tasksGetTask, nameof(tasksGetTask), required: true);
            return new DeferredBodyAction<TasksGetTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/TasksGetTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_tasksGetTask);
                return new ApiConnectionAction<TasksGetTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksGetNextTaskResponse, ApiConnectionActionConfiguration> TasksGetNextTask(Expression<Func<TasksGetNextTaskInput>> tasksGetNextTask)
        {
            var __workflow_tasksGetNextTask = WorkflowExpression.Compile(tasksGetNextTask, nameof(tasksGetNextTask), required: true);
            return new DeferredBodyAction<TasksGetNextTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/TasksGetNextTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_tasksGetNextTask);
                return new ApiConnectionAction<TasksGetNextTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksChangeTaskStatusResponse, ApiConnectionActionConfiguration> TasksChangeTaskStatus(Expression<Func<TasksChangeTaskStatusInput>> tasksChangeTaskStatus)
        {
            var __workflow_tasksChangeTaskStatus = WorkflowExpression.Compile(tasksChangeTaskStatus, nameof(tasksChangeTaskStatus), required: true);
            return new DeferredBodyAction<TasksChangeTaskStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/TasksChangeTaskStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_tasksChangeTaskStatus);
                return new ApiConnectionAction<TasksChangeTaskStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNoteResponse, ApiConnectionActionConfiguration> TasksAddNote(Expression<Func<TasksAddNoteInput>> tasksAddNote)
        {
            var __workflow_tasksAddNote = WorkflowExpression.Compile(tasksAddNote, nameof(tasksAddNote), required: true);
            return new DeferredBodyAction<TasksAddNoteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/TasksAddNote";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_tasksAddNote);
                return new ApiConnectionAction<TasksAddNoteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAssignTaskResponse, ApiConnectionActionConfiguration> TasksAssignTask(Expression<Func<TasksAssignTaskInput>> tasksAssignTask)
        {
            var __workflow_tasksAssignTask = WorkflowExpression.Compile(tasksAssignTask, nameof(tasksAssignTask), required: true);
            return new DeferredBodyAction<TasksAssignTaskResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/TasksAssignTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_tasksAssignTask);
                return new ApiConnectionAction<TasksAssignTaskResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksSetOutputDataResponse, ApiConnectionActionConfiguration> TasksSetOutputData(Expression<Func<TasksSetOutputDataInput>> tasksSetOutputData)
        {
            var __workflow_tasksSetOutputData = WorkflowExpression.Compile(tasksSetOutputData, nameof(tasksSetOutputData), required: true);
            return new DeferredBodyAction<TasksSetOutputDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/TasksSetOutputData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_tasksSetOutputData);
                return new ApiConnectionAction<TasksSetOutputDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewTaskOperationResponse, ApiConnectionActionConfiguration> TasksAddNewTaskOperation(Expression<Func<TasksAddNewTaskOperationInput>> tasksAddNewTaskOperation)
        {
            var __workflow_tasksAddNewTaskOperation = WorkflowExpression.Compile(tasksAddNewTaskOperation, nameof(tasksAddNewTaskOperation), required: true);
            return new DeferredBodyAction<TasksAddNewTaskOperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/TasksAddNewTaskOperation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_tasksAddNewTaskOperation);
                return new ApiConnectionAction<TasksAddNewTaskOperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksAddNewDeferralOperationResponse, ApiConnectionActionConfiguration> TasksAddNewDeferralOperation(Expression<Func<TasksAddNewDeferralOperationInput>> tasksAddNewDeferralOperation)
        {
            var __workflow_tasksAddNewDeferralOperation = WorkflowExpression.Compile(tasksAddNewDeferralOperation, nameof(tasksAddNewDeferralOperation), required: true);
            return new DeferredBodyAction<TasksAddNewDeferralOperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/TasksAddNewDeferralOperation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_tasksAddNewDeferralOperation);
                return new ApiConnectionAction<TasksAddNewDeferralOperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<TasksGetTaskOperationResponse, ApiConnectionActionConfiguration> TasksGetTaskOperation(Expression<Func<TasksGetTaskOperationInput>> tasksGetTaskOperation)
        {
            var __workflow_tasksGetTaskOperation = WorkflowExpression.Compile(tasksGetTaskOperation, nameof(tasksGetTaskOperation), required: true);
            return new DeferredBodyAction<TasksGetTaskOperationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Environment/TasksGetTaskOperation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_tasksGetTaskOperation);
                return new ApiConnectionAction<TasksGetTaskOperationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetRemoteLoggingLevel(Expression<Func<SetRemoteLoggingLevelInput>> setRemoteLoggingLevel)
        {
            var __workflow_setRemoteLoggingLevel = WorkflowExpression.Compile(setRemoteLoggingLevel, nameof(setRemoteLoggingLevel), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/SetRemoteLoggingLevel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_setRemoteLoggingLevel);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteLoggingLevelResponse, ApiConnectionActionConfiguration> GetRemoteLoggingLevel(Expression<Func<GetRemoteLoggingLevelInput>> getRemoteLoggingLevel)
        {
            var __workflow_getRemoteLoggingLevel = WorkflowExpression.Compile(getRemoteLoggingLevel, nameof(getRemoteLoggingLevel), required: true);
            return new DeferredBodyAction<GetRemoteLoggingLevelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/GetRemoteLoggingLevel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getRemoteLoggingLevel);
                return new ApiConnectionAction<GetRemoteLoggingLevelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetLicenseCode(Expression<Func<SetLicenseCodeInput>> setLicenseCode)
        {
            var __workflow_setLicenseCode = WorkflowExpression.Compile(setLicenseCode, nameof(setLicenseCode), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/SetLicenseCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_setLicenseCode);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SetLicenseStringResponse, ApiConnectionActionConfiguration> SetLicenseString(Expression<Func<SetLicenseStringInput>> setLicenseString)
        {
            var __workflow_setLicenseString = WorkflowExpression.Compile(setLicenseString, nameof(setLicenseString), required: true);
            return new DeferredBodyAction<SetLicenseStringResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/SetLicenseString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_setLicenseString);
                return new ApiConnectionAction<SetLicenseStringResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLicenseStateResponse, ApiConnectionActionConfiguration> GetLicenseState(Expression<Func<GetLicenseStateInput>> getLicenseState)
        {
            var __workflow_getLicenseState = WorkflowExpression.Compile(getLicenseState, nameof(getLicenseState), required: true);
            return new DeferredBodyAction<GetLicenseStateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/GetLicenseState";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getLicenseState);
                return new ApiConnectionAction<GetLicenseStateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetRsaguiTopmost(Expression<Func<SetRsaguiTopmostInput>> setRsaguiTopmost)
        {
            var __workflow_setRsaguiTopmost = WorkflowExpression.Compile(setRsaguiTopmost, nameof(setRsaguiTopmost), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/SetRSAGUITopmost";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_setRsaguiTopmost);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetRsaguiOpacity(Expression<Func<SetRsaguiOpacityInput>> setRsaguiOpacity)
        {
            var __workflow_setRsaguiOpacity = WorkflowExpression.Compile(setRsaguiOpacity, nameof(setRsaguiOpacity), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/SetRSAGUIOpacity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_setRsaguiOpacity);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetRsaguiPosition(Expression<Func<SetRsaguiPositionInput>> setRsaguiPosition)
        {
            var __workflow_setRsaguiPosition = WorkflowExpression.Compile(setRsaguiPosition, nameof(setRsaguiPosition), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/SetRSAGUIPosition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_setRsaguiPosition);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BringRsaguiToFront(Expression<Func<BringRsaguiToFrontInput>> bringRsaguiToFront)
        {
            var __workflow_bringRsaguiToFront = WorkflowExpression.Compile(bringRsaguiToFront, nameof(bringRsaguiToFront), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/BringRSAGUIToFront";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_bringRsaguiToFront);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DisconnectSession(Expression<Func<DisconnectSessionInput>> disconnectSession)
        {
            var __workflow_disconnectSession = WorkflowExpression.Compile(disconnectSession, nameof(disconnectSession), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/DisconnectSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_disconnectSession);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> LogoffSession(Expression<Func<LogoffSessionInput>> logoffSession)
        {
            var __workflow_logoffSession = WorkflowExpression.Compile(logoffSession, nameof(logoffSession), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/LogoffSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_logoffSession);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CloseRsaServer(Expression<Func<CloseRsaServerInput>> closeRsaServer)
        {
            var __workflow_closeRsaServer = WorkflowExpression.Compile(closeRsaServer, nameof(closeRsaServer), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/CloseRSAServer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_closeRsaServer);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetRpaCommandTimeout(Expression<Func<SetRpaCommandTimeoutInput>> setRpaCommandTimeout)
        {
            var __workflow_setRpaCommandTimeout = WorkflowExpression.Compile(setRpaCommandTimeout, nameof(setRpaCommandTimeout), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/SetRPACommandTimeout";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_setRpaCommandTimeout);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RunAlternativeIAConnect(Expression<Func<RunAlternativeIAConnectInput>> runAlternativeIAConnect)
        {
            var __workflow_runAlternativeIAConnect = WorkflowExpression.Compile(runAlternativeIAConnect, nameof(runAlternativeIAConnect), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/RunAlternativeIAConnect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_runAlternativeIAConnect);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunAlternativeIAConnectSentFromDirectorResponse, ApiConnectionActionConfiguration> RunAlternativeIAConnectSentFromDirector(Expression<Func<RunAlternativeIAConnectSentFromDirectorInput>> runAlternativeIAConnectSentFromDirector)
        {
            var __workflow_runAlternativeIAConnectSentFromDirector = WorkflowExpression.Compile(runAlternativeIAConnectSentFromDirector, nameof(runAlternativeIAConnectSentFromDirector), required: true);
            return new DeferredBodyAction<RunAlternativeIAConnectSentFromDirectorResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/RunAlternativeIAConnectSentFromDirector";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_runAlternativeIAConnectSentFromDirector);
                return new ApiConnectionAction<RunAlternativeIAConnectSentFromDirectorResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetIAConnectAgentInfoResponse, ApiConnectionActionConfiguration> GetIAConnectAgentInfo(Expression<Func<GetIAConnectAgentInfoInput>> getIAConnectAgentInfo)
        {
            var __workflow_getIAConnectAgentInfo = WorkflowExpression.Compile(getIAConnectAgentInfo, nameof(getIAConnectAgentInfo), required: true);
            return new DeferredBodyAction<GetIAConnectAgentInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/GetIAConnectAgentInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getIAConnectAgentInfo);
                return new ApiConnectionAction<GetIAConnectAgentInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetIAConnectAgentLogResponse, ApiConnectionActionConfiguration> GetIAConnectAgentLog(Expression<Func<GetIAConnectAgentLogInput>> getIAConnectAgentLog)
        {
            var __workflow_getIAConnectAgentLog = WorkflowExpression.Compile(getIAConnectAgentLog, nameof(getIAConnectAgentLog), required: true);
            return new DeferredBodyAction<GetIAConnectAgentLogResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/GetIAConnectAgentLog";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getIAConnectAgentLog);
                return new ApiConnectionAction<GetIAConnectAgentLogResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ResetCommandStats(Expression<Func<ResetCommandStatsInput>> resetCommandStats)
        {
            var __workflow_resetCommandStats = WorkflowExpression.Compile(resetCommandStats, nameof(resetCommandStats), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/ResetCommandStats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_resetCommandStats);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAllCommandStatsResponse, ApiConnectionActionConfiguration> GetAllCommandStats(Expression<Func<GetAllCommandStatsInput>> getAllCommandStats)
        {
            var __workflow_getAllCommandStats = WorkflowExpression.Compile(getAllCommandStats, nameof(getAllCommandStats), required: true);
            return new DeferredBodyAction<GetAllCommandStatsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/GetAllCommandStats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getAllCommandStats);
                return new ApiConnectionAction<GetAllCommandStatsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<EnableNextHopResponse, ApiConnectionActionConfiguration> EnableNextHop(Expression<Func<EnableNextHopInput>> enableNextHop)
        {
            var __workflow_enableNextHop = WorkflowExpression.Compile(enableNextHop, nameof(enableNextHop), required: true);
            return new DeferredBodyAction<EnableNextHopResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/EnableNextHop";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_enableNextHop);
                return new ApiConnectionAction<EnableNextHopResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DisableNextHop(Expression<Func<DisableNextHopInput>> disableNextHop)
        {
            var __workflow_disableNextHop = WorkflowExpression.Compile(disableNextHop, nameof(disableNextHop), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/DisableNextHop";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_disableNextHop);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetNextHopStatusResponse, ApiConnectionActionConfiguration> GetNextHopStatus(Expression<Func<GetNextHopStatusInput>> getNextHopStatus)
        {
            var __workflow_getNextHopStatus = WorkflowExpression.Compile(getNextHopStatus, nameof(getNextHopStatus), required: true);
            return new DeferredBodyAction<GetNextHopStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/GetNextHopStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getNextHopStatus);
                return new ApiConnectionAction<GetNextHopStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WaitForNextHopSessionToConnectResponse, ApiConnectionActionConfiguration> WaitForNextHopSessionToConnect(Expression<Func<WaitForNextHopSessionToConnectInput>> waitForNextHopSessionToConnect)
        {
            var __workflow_waitForNextHopSessionToConnect = WorkflowExpression.Compile(waitForNextHopSessionToConnect, nameof(waitForNextHopSessionToConnect), required: true);
            return new DeferredBodyAction<WaitForNextHopSessionToConnectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/WaitForNextHopSessionToConnect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_waitForNextHopSessionToConnect);
                return new ApiConnectionAction<WaitForNextHopSessionToConnectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ConfigureNextHopDirector(Expression<Func<ConfigureNextHopDirectorInput>> configureNextHopDirector)
        {
            var __workflow_configureNextHopDirector = WorkflowExpression.Compile(configureNextHopDirector, nameof(configureNextHopDirector), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/ConfigureNextHopDirector";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_configureNextHopDirector);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ResetNextHopDirectorSettings(Expression<Func<ResetNextHopDirectorSettingsInput>> resetNextHopDirectorSettings)
        {
            var __workflow_resetNextHopDirectorSettings = WorkflowExpression.Compile(resetNextHopDirectorSettings, nameof(resetNextHopDirectorSettings), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/ResetNextHopDirectorSettings";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_resetNextHopDirectorSettings);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> WorkflowCompleted(Expression<Func<WorkflowCompletedInput>> workflowCompleted)
        {
            var __workflow_workflowCompleted = WorkflowExpression.Compile(workflowCompleted, nameof(workflowCompleted), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/WorkflowCompleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_workflowCompleted);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RaiseExceptionResponse, ApiConnectionActionConfiguration> RaiseException(Expression<Func<RaiseExceptionInput>> raiseException)
        {
            var __workflow_raiseException = WorkflowExpression.Compile(raiseException, nameof(raiseException), required: true);
            return new DeferredBodyAction<RaiseExceptionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/RaiseException";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_raiseException);
                return new ApiConnectionAction<RaiseExceptionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<UpdateOrchestratorFlowStatsResultResponse, ApiConnectionActionConfiguration> UpdateOrchestratorFlowStatsResult(Expression<Func<UpdateOrchestratorFlowStatsResultInput>> updateOrchestratorFlowStatsResult)
        {
            var __workflow_updateOrchestratorFlowStatsResult = WorkflowExpression.Compile(updateOrchestratorFlowStatsResult, nameof(updateOrchestratorFlowStatsResult), required: true);
            return new DeferredBodyAction<UpdateOrchestratorFlowStatsResultResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/UpdateOrchestratorFlowStatsResult";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_updateOrchestratorFlowStatsResult);
                return new ApiConnectionAction<UpdateOrchestratorFlowStatsResultResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLastFailedActionFromOrchestratorFlowStatsResponse, ApiConnectionActionConfiguration> GetLastFailedActionFromOrchestratorFlowStats(Expression<Func<GetLastFailedActionFromOrchestratorFlowStatsInput>> getLastFailedActionFromOrchestratorFlowStats)
        {
            var __workflow_getLastFailedActionFromOrchestratorFlowStats = WorkflowExpression.Compile(getLastFailedActionFromOrchestratorFlowStats, nameof(getLastFailedActionFromOrchestratorFlowStats), required: true);
            return new DeferredBodyAction<GetLastFailedActionFromOrchestratorFlowStatsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/GetLastFailedActionFromOrchestratorFlowStats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getLastFailedActionFromOrchestratorFlowStats);
                return new ApiConnectionAction<GetLastFailedActionFromOrchestratorFlowStatsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorFlowStatsResponse, ApiConnectionActionConfiguration> GetOrchestratorFlowStats(Expression<Func<GetOrchestratorFlowStatsInput>> getOrchestratorFlowStats)
        {
            var __workflow_getOrchestratorFlowStats = WorkflowExpression.Compile(getOrchestratorFlowStats, nameof(getOrchestratorFlowStats), required: true);
            return new DeferredBodyAction<GetOrchestratorFlowStatsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/GetOrchestratorFlowStats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getOrchestratorFlowStats);
                return new ApiConnectionAction<GetOrchestratorFlowStatsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorWorkerAvailabilityStatsResponse, ApiConnectionActionConfiguration> GetOrchestratorWorkerAvailabilityStats(Expression<Func<GetOrchestratorWorkerAvailabilityStatsInput>> getOrchestratorWorkerAvailabilityStats)
        {
            var __workflow_getOrchestratorWorkerAvailabilityStats = WorkflowExpression.Compile(getOrchestratorWorkerAvailabilityStats, nameof(getOrchestratorWorkerAvailabilityStats), required: true);
            return new DeferredBodyAction<GetOrchestratorWorkerAvailabilityStatsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/GetOrchestratorWorkerAvailabilityStats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getOrchestratorWorkerAvailabilityStats);
                return new ApiConnectionAction<GetOrchestratorWorkerAvailabilityStatsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorWorkerFlowUsageHeatmapResponse, ApiConnectionActionConfiguration> GetOrchestratorWorkerFlowUsageHeatmap(Expression<Func<GetOrchestratorWorkerFlowUsageHeatmapInput>> getOrchestratorWorkerFlowUsageHeatmap)
        {
            var __workflow_getOrchestratorWorkerFlowUsageHeatmap = WorkflowExpression.Compile(getOrchestratorWorkerFlowUsageHeatmap, nameof(getOrchestratorWorkerFlowUsageHeatmap), required: true);
            return new DeferredBodyAction<GetOrchestratorWorkerFlowUsageHeatmapResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/GetOrchestratorWorkerFlowUsageHeatmap";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getOrchestratorWorkerFlowUsageHeatmap);
                return new ApiConnectionAction<GetOrchestratorWorkerFlowUsageHeatmapResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorLoginHistoryResponse, ApiConnectionActionConfiguration> GetOrchestratorLoginHistory(Expression<Func<GetOrchestratorLoginHistoryInput>> getOrchestratorLoginHistory)
        {
            var __workflow_getOrchestratorLoginHistory = WorkflowExpression.Compile(getOrchestratorLoginHistory, nameof(getOrchestratorLoginHistory), required: true);
            return new DeferredBodyAction<GetOrchestratorLoginHistoryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/GetOrchestratorLoginHistory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getOrchestratorLoginHistory);
                return new ApiConnectionAction<GetOrchestratorLoginHistoryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetLocalLoggingLevel(Expression<Func<SetLocalLoggingLevelInput>> setLocalLoggingLevel)
        {
            var __workflow_setLocalLoggingLevel = WorkflowExpression.Compile(setLocalLoggingLevel, nameof(setLocalLoggingLevel), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/SetLocalLoggingLevel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_setLocalLoggingLevel);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RunCommandResponse, ApiConnectionActionConfiguration> RunCommand(Expression<Func<RunCommandInput>> runCommand)
        {
            var __workflow_runCommand = WorkflowExpression.Compile(runCommand, nameof(runCommand), required: true);
            return new DeferredBodyAction<RunCommandResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/RunCommand";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_runCommand);
                return new ApiConnectionAction<RunCommandResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetLocalLoggingLevelResponse, ApiConnectionActionConfiguration> GetLocalLoggingLevel(Expression<Func<GetLocalLoggingLevelInput>> getLocalLoggingLevel)
        {
            var __workflow_getLocalLoggingLevel = WorkflowExpression.Compile(getLocalLoggingLevel, nameof(getLocalLoggingLevel), required: true);
            return new DeferredBodyAction<GetLocalLoggingLevelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/GetLocalLoggingLevel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getLocalLoggingLevel);
                return new ApiConnectionAction<GetLocalLoggingLevelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetRemoteClientTypeResponse, ApiConnectionActionConfiguration> GetRemoteClientType(Expression<Func<GetRemoteClientTypeInput>> getRemoteClientType)
        {
            var __workflow_getRemoteClientType = WorkflowExpression.Compile(getRemoteClientType, nameof(getRemoteClientType), required: true);
            return new DeferredBodyAction<GetRemoteClientTypeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/GetRemoteClientType";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getRemoteClientType);
                return new ApiConnectionAction<GetRemoteClientTypeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetIAConnectDirectorInfoResponse, ApiConnectionActionConfiguration> GetIAConnectDirectorInfo(Expression<Func<GetIAConnectDirectorInfoInput>> getIAConnectDirectorInfo)
        {
            var __workflow_getIAConnectDirectorInfo = WorkflowExpression.Compile(getIAConnectDirectorInfo, nameof(getIAConnectDirectorInfo), required: true);
            return new DeferredBodyAction<GetIAConnectDirectorInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/GetIAConnectDirectorInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getIAConnectDirectorInfo);
                return new ApiConnectionAction<GetIAConnectDirectorInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAvailableIAConnectSessionsResponse, ApiConnectionActionConfiguration> GetAvailableIAConnectSessions(Expression<Func<GetAvailableIAConnectSessionsInput>> getAvailableIAConnectSessions)
        {
            var __workflow_getAvailableIAConnectSessions = WorkflowExpression.Compile(getAvailableIAConnectSessions, nameof(getAvailableIAConnectSessions), required: true);
            return new DeferredBodyAction<GetAvailableIAConnectSessionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/GetAvailableIAConnectSessions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getAvailableIAConnectSessions);
                return new ApiConnectionAction<GetAvailableIAConnectSessionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AttachToIAConnectSessionByName(Expression<Func<AttachToIAConnectSessionByNameInput>> attachToIAConnectSessionByName)
        {
            var __workflow_attachToIAConnectSessionByName = WorkflowExpression.Compile(attachToIAConnectSessionByName, nameof(attachToIAConnectSessionByName), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/AttachToIAConnectSessionByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_attachToIAConnectSessionByName);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AttachToTier1IAConnectSessionResponse, ApiConnectionActionConfiguration> AttachToTier1IAConnectSession(Expression<Func<AttachToTier1IAConnectSessionInput>> attachToTier1IAConnectSession)
        {
            var __workflow_attachToTier1IAConnectSession = WorkflowExpression.Compile(attachToTier1IAConnectSession, nameof(attachToTier1IAConnectSession), required: true);
            return new DeferredBodyAction<AttachToTier1IAConnectSessionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/AttachToTier1IAConnectSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_attachToTier1IAConnectSession);
                return new ApiConnectionAction<AttachToTier1IAConnectSessionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AttachToIAConnectSessionByIndexResponse, ApiConnectionActionConfiguration> AttachToIAConnectSessionByIndex(Expression<Func<AttachToIAConnectSessionByIndexInput>> attachToIAConnectSessionByIndex)
        {
            var __workflow_attachToIAConnectSessionByIndex = WorkflowExpression.Compile(attachToIAConnectSessionByIndex, nameof(attachToIAConnectSessionByIndex), required: true);
            return new DeferredBodyAction<AttachToIAConnectSessionByIndexResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/AttachToIAConnectSessionByIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_attachToIAConnectSessionByIndex);
                return new ApiConnectionAction<AttachToIAConnectSessionByIndexResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AttachToMostRecentIAConnectSessionResponse, ApiConnectionActionConfiguration> AttachToMostRecentIAConnectSession(Expression<Func<AttachToMostRecentIAConnectSessionInput>> attachToMostRecentIAConnectSession)
        {
            var __workflow_attachToMostRecentIAConnectSession = WorkflowExpression.Compile(attachToMostRecentIAConnectSession, nameof(attachToMostRecentIAConnectSession), required: true);
            return new DeferredBodyAction<AttachToMostRecentIAConnectSessionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/AttachToMostRecentIAConnectSession";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_attachToMostRecentIAConnectSession);
                return new ApiConnectionAction<AttachToMostRecentIAConnectSessionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetDirectorUpTimeResponse, ApiConnectionActionConfiguration> GetDirectorUpTime(Expression<Func<GetDirectorUpTimeInput>> getDirectorUpTime)
        {
            var __workflow_getDirectorUpTime = WorkflowExpression.Compile(getDirectorUpTime, nameof(getDirectorUpTime), required: true);
            return new DeferredBodyAction<GetDirectorUpTimeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/GetDirectorUpTime";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getDirectorUpTime);
                return new ApiConnectionAction<GetDirectorUpTimeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DoesIAConnectSessionExistByNameResponse, ApiConnectionActionConfiguration> DoesIAConnectSessionExistByName(Expression<Func<DoesIAConnectSessionExistByNameInput>> doesIAConnectSessionExistByName)
        {
            var __workflow_doesIAConnectSessionExistByName = WorkflowExpression.Compile(doesIAConnectSessionExistByName, nameof(doesIAConnectSessionExistByName), required: true);
            return new DeferredBodyAction<DoesIAConnectSessionExistByNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/DoesIAConnectSessionExistByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_doesIAConnectSessionExistByName);
                return new ApiConnectionAction<DoesIAConnectSessionExistByNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WaitForIAConnectSessionToCloseByNameResponse, ApiConnectionActionConfiguration> WaitForIAConnectSessionToCloseByName(Expression<Func<WaitForIAConnectSessionToCloseByNameInput>> waitForIAConnectSessionToCloseByName)
        {
            var __workflow_waitForIAConnectSessionToCloseByName = WorkflowExpression.Compile(waitForIAConnectSessionToCloseByName, nameof(waitForIAConnectSessionToCloseByName), required: true);
            return new DeferredBodyAction<WaitForIAConnectSessionToCloseByNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/WaitForIAConnectSessionToCloseByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_waitForIAConnectSessionToCloseByName);
                return new ApiConnectionAction<WaitForIAConnectSessionToCloseByNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillIAConnectSessionByNameResponse, ApiConnectionActionConfiguration> KillIAConnectSessionByName(Expression<Func<KillIAConnectSessionByNameInput>> killIAConnectSessionByName)
        {
            var __workflow_killIAConnectSessionByName = WorkflowExpression.Compile(killIAConnectSessionByName, nameof(killIAConnectSessionByName), required: true);
            return new DeferredBodyAction<KillIAConnectSessionByNameResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/KillIAConnectSessionByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_killIAConnectSessionByName);
                return new ApiConnectionAction<KillIAConnectSessionByNameResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SetAgentGlobalCoordinateConfigurationResponse, ApiConnectionActionConfiguration> SetAgentGlobalCoordinateConfiguration(Expression<Func<SetAgentGlobalCoordinateConfigurationInput>> setAgentGlobalCoordinateConfiguration)
        {
            var __workflow_setAgentGlobalCoordinateConfiguration = WorkflowExpression.Compile(setAgentGlobalCoordinateConfiguration, nameof(setAgentGlobalCoordinateConfiguration), required: true);
            return new DeferredBodyAction<SetAgentGlobalCoordinateConfigurationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/SetAgentGlobalCoordinateConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_setAgentGlobalCoordinateConfiguration);
                return new ApiConnectionAction<SetAgentGlobalCoordinateConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentGlobalCoordinateConfigurationResponse, ApiConnectionActionConfiguration> GetAgentGlobalCoordinateConfiguration(Expression<Func<GetAgentGlobalCoordinateConfigurationInput>> getAgentGlobalCoordinateConfiguration)
        {
            var __workflow_getAgentGlobalCoordinateConfiguration = WorkflowExpression.Compile(getAgentGlobalCoordinateConfiguration, nameof(getAgentGlobalCoordinateConfiguration), required: true);
            return new DeferredBodyAction<GetAgentGlobalCoordinateConfigurationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/GetAgentGlobalCoordinateConfiguration";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getAgentGlobalCoordinateConfiguration);
                return new ApiConnectionAction<GetAgentGlobalCoordinateConfigurationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentThreadStatusResponse, ApiConnectionActionConfiguration> GetAgentThreadStatus(Expression<Func<GetAgentThreadStatusInput>> getAgentThreadStatus)
        {
            var __workflow_getAgentThreadStatus = WorkflowExpression.Compile(getAgentThreadStatus, nameof(getAgentThreadStatus), required: true);
            return new DeferredBodyAction<GetAgentThreadStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/GetAgentThreadStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getAgentThreadStatus);
                return new ApiConnectionAction<GetAgentThreadStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WaitForAgentThreadToCompleteSuccessfullyResponse, ApiConnectionActionConfiguration> WaitForAgentThreadToCompleteSuccessfully(Expression<Func<WaitForAgentThreadToCompleteSuccessfullyInput>> waitForAgentThreadToCompleteSuccessfully)
        {
            var __workflow_waitForAgentThreadToCompleteSuccessfully = WorkflowExpression.Compile(waitForAgentThreadToCompleteSuccessfully, nameof(waitForAgentThreadToCompleteSuccessfully), required: true);
            return new DeferredBodyAction<WaitForAgentThreadToCompleteSuccessfullyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/WaitForAgentThreadToCompleteSuccessfully";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_waitForAgentThreadToCompleteSuccessfully);
                return new ApiConnectionAction<WaitForAgentThreadToCompleteSuccessfullyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetAgentThreadsResponse, ApiConnectionActionConfiguration> GetAgentThreads(Expression<Func<GetAgentThreadsInput>> getAgentThreads)
        {
            var __workflow_getAgentThreads = WorkflowExpression.Compile(getAgentThreads, nameof(getAgentThreads), required: true);
            return new DeferredBodyAction<GetAgentThreadsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/GetAgentThreads";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getAgentThreads);
                return new ApiConnectionAction<GetAgentThreadsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<KillAgentThreadResponse, ApiConnectionActionConfiguration> KillAgentThread(Expression<Func<KillAgentThreadInput>> killAgentThread)
        {
            var __workflow_killAgentThread = WorkflowExpression.Compile(killAgentThread, nameof(killAgentThread), required: true);
            return new DeferredBodyAction<KillAgentThreadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/KillAgentThread";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_killAgentThread);
                return new ApiConnectionAction<KillAgentThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DeleteAgentThreadResponse, ApiConnectionActionConfiguration> DeleteAgentThread(Expression<Func<DeleteAgentThreadInput>> deleteAgentThread)
        {
            var __workflow_deleteAgentThread = WorkflowExpression.Compile(deleteAgentThread, nameof(deleteAgentThread), required: true);
            return new DeferredBodyAction<DeleteAgentThreadResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/DeleteAgentThread";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_deleteAgentThread);
                return new ApiConnectionAction<DeleteAgentThreadResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AllocateWorkerFromOrchestratorResponse, ApiConnectionActionConfiguration> AllocateWorkerFromOrchestrator(Expression<Func<AllocateWorkerFromOrchestratorInput>> allocateWorkerFromOrchestrator)
        {
            var __workflow_allocateWorkerFromOrchestrator = WorkflowExpression.Compile(allocateWorkerFromOrchestrator, nameof(allocateWorkerFromOrchestrator), required: true);
            return new DeferredBodyAction<AllocateWorkerFromOrchestratorResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/AllocateWorkerFromOrchestrator";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_allocateWorkerFromOrchestrator);
                return new ApiConnectionAction<AllocateWorkerFromOrchestratorResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<SetOrchestratorWorkerMaintenanceModeResponse, ApiConnectionActionConfiguration> SetOrchestratorWorkerMaintenanceMode(Expression<Func<SetOrchestratorWorkerMaintenanceModeInput>> setOrchestratorWorkerMaintenanceMode)
        {
            var __workflow_setOrchestratorWorkerMaintenanceMode = WorkflowExpression.Compile(setOrchestratorWorkerMaintenanceMode, nameof(setOrchestratorWorkerMaintenanceMode), required: true);
            return new DeferredBodyAction<SetOrchestratorWorkerMaintenanceModeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/SetOrchestratorWorkerMaintenanceMode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_setOrchestratorWorkerMaintenanceMode);
                return new ApiConnectionAction<SetOrchestratorWorkerMaintenanceModeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<CreateOrchestratorOneTimeSecretResponse, ApiConnectionActionConfiguration> CreateOrchestratorOneTimeSecret(Expression<Func<CreateOrchestratorOneTimeSecretInput>> createOrchestratorOneTimeSecret)
        {
            var __workflow_createOrchestratorOneTimeSecret = WorkflowExpression.Compile(createOrchestratorOneTimeSecret, nameof(createOrchestratorOneTimeSecret), required: true);
            return new DeferredBodyAction<CreateOrchestratorOneTimeSecretResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/CreateOrchestratorOneTimeSecret";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_createOrchestratorOneTimeSecret);
                return new ApiConnectionAction<CreateOrchestratorOneTimeSecretResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetListOfOrchestratorWorkersResponse, ApiConnectionActionConfiguration> GetListOfOrchestratorWorkers(Expression<Func<GetListOfOrchestratorWorkersInput>> getListOfOrchestratorWorkers)
        {
            var __workflow_getListOfOrchestratorWorkers = WorkflowExpression.Compile(getListOfOrchestratorWorkers, nameof(getListOfOrchestratorWorkers), required: true);
            return new DeferredBodyAction<GetListOfOrchestratorWorkersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/GetListOfOrchestratorWorkers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getListOfOrchestratorWorkers);
                return new ApiConnectionAction<GetListOfOrchestratorWorkersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetOrchestratorWorkerResponse, ApiConnectionActionConfiguration> GetOrchestratorWorker(Expression<Func<GetOrchestratorWorkerInput>> getOrchestratorWorker)
        {
            var __workflow_getOrchestratorWorker = WorkflowExpression.Compile(getOrchestratorWorker, nameof(getOrchestratorWorker), required: true);
            return new DeferredBodyAction<GetOrchestratorWorkerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/DriverControl/GetOrchestratorWorker";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getOrchestratorWorker);
                return new ApiConnectionAction<GetOrchestratorWorkerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<OrchestratorGetStatusResponse, ApiConnectionActionConfiguration> OrchestratorGetStatus()
        {
            return new DeferredBodyAction<OrchestratorGetStatusResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/OrchestratorController/OrchestratorGetStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OrchestratorGetStatusResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<OrchestratorGetWorkerAvailabilityStatusOverviewResponse, ApiConnectionActionConfiguration> OrchestratorGetWorkerAvailabilityStatusOverview()
        {
            return new DeferredBodyAction<OrchestratorGetWorkerAvailabilityStatusOverviewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/OrchestratorController/OrchestratorGetWorkerAvailabilityStatusOverview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OrchestratorGetWorkerAvailabilityStatusOverviewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<FileExistsResponse, ApiConnectionActionConfiguration> FileExists(Expression<Func<FileExistsInput>> fileExists)
        {
            var __workflow_fileExists = WorkflowExpression.Compile(fileExists, nameof(fileExists), required: true);
            return new DeferredBodyAction<FileExistsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/FileExists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_fileExists);
                return new ApiConnectionAction<FileExistsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DirectoryExistsResponse, ApiConnectionActionConfiguration> DirectoryExists(Expression<Func<DirectoryExistsInput>> directoryExists)
        {
            var __workflow_directoryExists = WorkflowExpression.Compile(directoryExists, nameof(directoryExists), required: true);
            return new DeferredBodyAction<DirectoryExistsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/DirectoryExists";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_directoryExists);
                return new ApiConnectionAction<DirectoryExistsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteFile(Expression<Func<DeleteFileInput>> deleteFile)
        {
            var __workflow_deleteFile = WorkflowExpression.Compile(deleteFile, nameof(deleteFile), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/DeleteFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_deleteFile);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDirectory(Expression<Func<DeleteDirectoryInput>> deleteDirectory)
        {
            var __workflow_deleteDirectory = WorkflowExpression.Compile(deleteDirectory, nameof(deleteDirectory), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/DeleteDirectory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_deleteDirectory);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> PurgeDirectory(Expression<Func<PurgeDirectoryInput>> purgeDirectory)
        {
            var __workflow_purgeDirectory = WorkflowExpression.Compile(purgeDirectory, nameof(purgeDirectory), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/PurgeDirectory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_purgeDirectory);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CopyFile(Expression<Func<CopyFileInput>> copyFile)
        {
            var __workflow_copyFile = WorkflowExpression.Compile(copyFile, nameof(copyFile), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/CopyFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_copyFile);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MoveFile(Expression<Func<MoveFileInput>> moveFile)
        {
            var __workflow_moveFile = WorkflowExpression.Compile(moveFile, nameof(moveFile), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/MoveFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_moveFile);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateDirectory(Expression<Func<CreateDirectoryInput>> createDirectory)
        {
            var __workflow_createDirectory = WorkflowExpression.Compile(createDirectory, nameof(createDirectory), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/CreateDirectory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_createDirectory);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFileSizeResponse, ApiConnectionActionConfiguration> GetFileSize(Expression<Func<GetFileSizeInput>> getFileSize)
        {
            var __workflow_getFileSize = WorkflowExpression.Compile(getFileSize, nameof(getFileSize), required: true);
            return new DeferredBodyAction<GetFileSizeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/GetFileSize";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getFileSize);
                return new ApiConnectionAction<GetFileSizeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> WriteTextFile(Expression<Func<WriteTextFileInput>> writeTextFile)
        {
            var __workflow_writeTextFile = WorkflowExpression.Compile(writeTextFile, nameof(writeTextFile), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/WriteTextFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_writeTextFile);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<ReadAllTextFromFileResponse, ApiConnectionActionConfiguration> ReadAllTextFromFile(Expression<Func<ReadAllTextFromFileInput>> readAllTextFromFile)
        {
            var __workflow_readAllTextFromFile = WorkflowExpression.Compile(readAllTextFromFile, nameof(readAllTextFromFile), required: true);
            return new DeferredBodyAction<ReadAllTextFromFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/ReadAllTextFromFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_readAllTextFromFile);
                return new ApiConnectionAction<ReadAllTextFromFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFilesResponse, ApiConnectionActionConfiguration> GetFiles(Expression<Func<GetFilesInput>> getFiles)
        {
            var __workflow_getFiles = WorkflowExpression.Compile(getFiles, nameof(getFiles), required: true);
            return new DeferredBodyAction<GetFilesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/GetFiles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getFiles);
                return new ApiConnectionAction<GetFilesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFoldersResponse, ApiConnectionActionConfiguration> GetFolders(Expression<Func<GetFoldersInput>> getFolders)
        {
            var __workflow_getFolders = WorkflowExpression.Compile(getFolders, nameof(getFolders), required: true);
            return new DeferredBodyAction<GetFoldersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/GetFolders";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getFolders);
                return new ApiConnectionAction<GetFoldersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DeleteFilesResponse, ApiConnectionActionConfiguration> DeleteFiles(Expression<Func<DeleteFilesInput>> deleteFiles)
        {
            var __workflow_deleteFiles = WorkflowExpression.Compile(deleteFiles, nameof(deleteFiles), required: true);
            return new DeferredBodyAction<DeleteFilesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/DeleteFiles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_deleteFiles);
                return new ApiConnectionAction<DeleteFilesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetDiskFreeSpaceResponse, ApiConnectionActionConfiguration> GetDiskFreeSpace(Expression<Func<GetDiskFreeSpaceInput>> getDiskFreeSpace)
        {
            var __workflow_getDiskFreeSpace = WorkflowExpression.Compile(getDiskFreeSpace, nameof(getDiskFreeSpace), required: true);
            return new DeferredBodyAction<GetDiskFreeSpaceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/GetDiskFreeSpace";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getDiskFreeSpace);
                return new ApiConnectionAction<GetDiskFreeSpaceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetListOfDrivesResponse, ApiConnectionActionConfiguration> GetListOfDrives(Expression<Func<GetListOfDrivesInput>> getListOfDrives)
        {
            var __workflow_getListOfDrives = WorkflowExpression.Compile(getListOfDrives, nameof(getListOfDrives), required: true);
            return new DeferredBodyAction<GetListOfDrivesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/GetListOfDrives";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getListOfDrives);
                return new ApiConnectionAction<GetListOfDrivesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DirectoryIsAccessibleResponse, ApiConnectionActionConfiguration> DirectoryIsAccessible(Expression<Func<DirectoryIsAccessibleInput>> directoryIsAccessible)
        {
            var __workflow_directoryIsAccessible = WorkflowExpression.Compile(directoryIsAccessible, nameof(directoryIsAccessible), required: true);
            return new DeferredBodyAction<DirectoryIsAccessibleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/DirectoryIsAccessible";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_directoryIsAccessible);
                return new ApiConnectionAction<DirectoryIsAccessibleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetCsvTextAsCollectionResponse, ApiConnectionActionConfiguration> GetCsvTextAsCollection(Expression<Func<GetCsvTextAsCollectionInput>> getCsvTextAsCollection)
        {
            var __workflow_getCsvTextAsCollection = WorkflowExpression.Compile(getCsvTextAsCollection, nameof(getCsvTextAsCollection), required: true);
            return new DeferredBodyAction<GetCsvTextAsCollectionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/GetCSVTextAsCollection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getCsvTextAsCollection);
                return new ApiConnectionAction<GetCsvTextAsCollectionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<WriteCollectionToCsvFileResponse, ApiConnectionActionConfiguration> WriteCollectionToCsvFile(Expression<Func<WriteCollectionToCsvFileInput>> writeCollectionToCsvFile)
        {
            var __workflow_writeCollectionToCsvFile = WorkflowExpression.Compile(writeCollectionToCsvFile, nameof(writeCollectionToCsvFile), required: true);
            return new DeferredBodyAction<WriteCollectionToCsvFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/WriteCollectionToCSVFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_writeCollectionToCsvFile);
                return new ApiConnectionAction<WriteCollectionToCsvFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetOwnerOnFolder(Expression<Func<SetOwnerOnFolderInput>> setOwnerOnFolder)
        {
            var __workflow_setOwnerOnFolder = WorkflowExpression.Compile(setOwnerOnFolder, nameof(setOwnerOnFolder), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/SetOwnerOnFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_setOwnerOnFolder);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SetOwnerOnFile(Expression<Func<SetOwnerOnFileInput>> setOwnerOnFile)
        {
            var __workflow_setOwnerOnFile = WorkflowExpression.Compile(setOwnerOnFile, nameof(setOwnerOnFile), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/SetOwnerOnFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_setOwnerOnFile);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddPermissionToFolder(Expression<Func<AddPermissionToFolderInput>> addPermissionToFolder)
        {
            var __workflow_addPermissionToFolder = WorkflowExpression.Compile(addPermissionToFolder, nameof(addPermissionToFolder), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/AddPermissionToFolder";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_addPermissionToFolder);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddPermissionToFile(Expression<Func<AddPermissionToFileInput>> addPermissionToFile)
        {
            var __workflow_addPermissionToFile = WorkflowExpression.Compile(addPermissionToFile, nameof(addPermissionToFile), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/AddPermissionToFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_addPermissionToFile);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BreakFolderSecurityInheritance(Expression<Func<BreakFolderSecurityInheritanceInput>> breakFolderSecurityInheritance)
        {
            var __workflow_breakFolderSecurityInheritance = WorkflowExpression.Compile(breakFolderSecurityInheritance, nameof(breakFolderSecurityInheritance), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/BreakFolderSecurityInheritance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_breakFolderSecurityInheritance);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EnableFolderSecurityInheritance(Expression<Func<EnableFolderSecurityInheritanceInput>> enableFolderSecurityInheritance)
        {
            var __workflow_enableFolderSecurityInheritance = WorkflowExpression.Compile(enableFolderSecurityInheritance, nameof(enableFolderSecurityInheritance), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/EnableFolderSecurityInheritance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_enableFolderSecurityInheritance);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFolderSecurityPermissionsResponse, ApiConnectionActionConfiguration> GetFolderSecurityPermissions(Expression<Func<GetFolderSecurityPermissionsInput>> getFolderSecurityPermissions)
        {
            var __workflow_getFolderSecurityPermissions = WorkflowExpression.Compile(getFolderSecurityPermissions, nameof(getFolderSecurityPermissions), required: true);
            return new DeferredBodyAction<GetFolderSecurityPermissionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/GetFolderSecurityPermissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getFolderSecurityPermissions);
                return new ApiConnectionAction<GetFolderSecurityPermissionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFileSecurityPermissionsResponse, ApiConnectionActionConfiguration> GetFileSecurityPermissions(Expression<Func<GetFileSecurityPermissionsInput>> getFileSecurityPermissions)
        {
            var __workflow_getFileSecurityPermissions = WorkflowExpression.Compile(getFileSecurityPermissions, nameof(getFileSecurityPermissions), required: true);
            return new DeferredBodyAction<GetFileSecurityPermissionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/GetFileSecurityPermissions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getFileSecurityPermissions);
                return new ApiConnectionAction<GetFileSecurityPermissionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RemoveIdentityFromFolderSecurityResponse, ApiConnectionActionConfiguration> RemoveIdentityFromFolderSecurity(Expression<Func<RemoveIdentityFromFolderSecurityInput>> removeIdentityFromFolderSecurity)
        {
            var __workflow_removeIdentityFromFolderSecurity = WorkflowExpression.Compile(removeIdentityFromFolderSecurity, nameof(removeIdentityFromFolderSecurity), required: true);
            return new DeferredBodyAction<RemoveIdentityFromFolderSecurityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/RemoveIdentityFromFolderSecurity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_removeIdentityFromFolderSecurity);
                return new ApiConnectionAction<RemoveIdentityFromFolderSecurityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<RemoveIdentityFromFileSecurityResponse, ApiConnectionActionConfiguration> RemoveIdentityFromFileSecurity(Expression<Func<RemoveIdentityFromFileSecurityInput>> removeIdentityFromFileSecurity)
        {
            var __workflow_removeIdentityFromFileSecurity = WorkflowExpression.Compile(removeIdentityFromFileSecurity, nameof(removeIdentityFromFileSecurity), required: true);
            return new DeferredBodyAction<RemoveIdentityFromFileSecurityResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/RemoveIdentityFromFileSecurity";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_removeIdentityFromFileSecurity);
                return new ApiConnectionAction<RemoveIdentityFromFileSecurityResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CopyFileFromClientToServer(Expression<Func<CopyFileFromClientToServerInput>> copyFileFromClientToServer)
        {
            var __workflow_copyFileFromClientToServer = WorkflowExpression.Compile(copyFileFromClientToServer, nameof(copyFileFromClientToServer), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/CopyFileFromClientToServer";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_copyFileFromClientToServer);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReplaceVariableDataInIniFile(Expression<Func<ReplaceVariableDataInIniFileInput>> replaceVariableDataInIniFile)
        {
            var __workflow_replaceVariableDataInIniFile = WorkflowExpression.Compile(replaceVariableDataInIniFile, nameof(replaceVariableDataInIniFile), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/ReplaceVariableDataInINIFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_replaceVariableDataInIniFile);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<DownloadHttpFileResponse, ApiConnectionActionConfiguration> DownloadHttpFile(Expression<Func<DownloadHttpFileInput>> downloadHttpFile)
        {
            var __workflow_downloadHttpFile = WorkflowExpression.Compile(downloadHttpFile, nameof(downloadHttpFile), required: true);
            return new DeferredBodyAction<DownloadHttpFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/DownloadHTTPFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_downloadHttpFile);
                return new ApiConnectionAction<DownloadHttpFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<UnZipFileResponse, ApiConnectionActionConfiguration> UnZipFile(Expression<Func<UnZipFileInput>> unZipFile)
        {
            var __workflow_unZipFile = WorkflowExpression.Compile(unZipFile, nameof(unZipFile), required: true);
            return new DeferredBodyAction<UnZipFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/UnZIPFile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_unZipFile);
                return new ApiConnectionAction<UnZipFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddFileToZip(Expression<Func<AddFileToZipInput>> addFileToZip)
        {
            var __workflow_addFileToZip = WorkflowExpression.Compile(addFileToZip, nameof(addFileToZip), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/AddFileToZIP";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_addFileToZip);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<AddFolderToZipResponse, ApiConnectionActionConfiguration> AddFolderToZip(Expression<Func<AddFolderToZipInput>> addFolderToZip)
        {
            var __workflow_addFolderToZip = WorkflowExpression.Compile(addFolderToZip, nameof(addFolderToZip), required: true);
            return new DeferredBodyAction<AddFolderToZipResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/AddFolderToZIP";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_addFolderToZip);
                return new ApiConnectionAction<AddFolderToZipResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectsession")]
        public IBodyWorkflowAction<GetFileContentsAsBase64Response, ApiConnectionActionConfiguration> GetFileContentsAsBase64(Expression<Func<GetFileContentsAsBase64Input>> getFileContentsAsBase64)
        {
            var __workflow_getFileContentsAsBase64 = WorkflowExpression.Compile(getFileContentsAsBase64, nameof(getFileContentsAsBase64), required: true);
            return new DeferredBodyAction<GetFileContentsAsBase64Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FileManagement/GetFileContentsAsBase64";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_getFileContentsAsBase64);
                return new ApiConnectionAction<GetFileContentsAsBase64Response>(callPayload);
            });
        }
    }

    public class IaconnectsessionTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetMachineNameResponse
    {
        public string MachineName { get; set; }
    }

    public class GetMachineNameInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetMachineDomainResponse
    {
        public string DomainName { get; set; }

        [JsonProperty("DNSDomainName")]
        public string DnsDomainName { get; set; }
    }

    public class GetMachineDomainInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetRemoteSessionClientHostnameResponse
    {
        public string ClientHostname { get; set; }
    }

    public class GetRemoteSessionClientHostnameInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExpandEnvironmentVariableResponse
    {
        public string OutputString { get; set; }
    }

    public class ExpandEnvironmentVariableInput
    {
        public ExpandEnvironmentVariableInput(string inputString)
        {
            this.InputString = inputString;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputString { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class KillProcessResponse
    {
        public int NumberOfProcessesKilled { get; set; }
    }

    public class KillProcessInput
    {
        public KillProcessInput(string processName)
        {
            this.ProcessName = processName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProcessName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class KillProcessIdResponse
    {
        public int NumberOfProcessesKilled { get; set; }
    }

    public class KillProcessIdInput
    {
        public KillProcessIdInput(int processId)
        {
            this.ProcessId = processId;
        }

        [JsonProperty("ProcessID", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ProcessId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetProcessCountByNameResponse
    {
        public int NumberOfProcesses { get; set; }
    }

    public class GetProcessCountByNameInput
    {
        public GetProcessCountByNameInput(string processName)
        {
            this.ProcessName = processName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProcessName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetAgentProcessCountResponse
    {
        public int NumberOfProcesses { get; set; }
    }

    public class GetAgentProcessCountInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class KillAllOtherAgentsResponse
    {
        public int NumberOfAgentsKilled { get; set; }
        public int NumberOfAgentsFailedToKill { get; set; }
    }

    public class KillAllOtherAgentsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetProcessByPidResponse
    {
        public bool ProcessRunning { get; set; }
    }

    public class GetProcessByPidInput
    {
        public GetProcessByPidInput(int processId)
        {
            this.ProcessId = processId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ProcessId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetProcessesResponse
    {
        public int NumberOfProcesses { get; set; }

        [JsonProperty("ProcessesJSON")]
        public string ProcessesJson { get; set; }
    }

    public class GetProcessesInput
    {
        public string ProcessName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? GetProcessCommandLine { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RunProcessResponse
    {
        public bool ProcessStarted { get; set; }
        public int ExitCode { get; set; }
        public bool ProcessTimedOut { get; set; }
        public int ProcessId { get; set; }
        public string StandardOutput { get; set; }
        public string StandardError { get; set; }
    }

    public class RunProcessInput
    {
        public RunProcessInput(string processName)
        {
            this.ProcessName = processName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ProcessName { get; set; }
        public string Arguments { get; set; }
        public string WorkingDirectory { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseShellExecute { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CreateNoWindow { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public RunProcessInputWindowStyleType? WindowStyle { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.RunProcessInputWindowStyleType.Normal;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? WaitForProcess { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RedirectStandardOutput { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RedirectStandardError { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RedirectStandardErrorToOutput { get; set; } = false;
        public RunProcessInputStandardOutputEncodingType? StandardOutputEncoding { get; set; }
        public RunProcessInputStandardErrorEncodingType? StandardErrorEncoding { get; set; }
        public string RunAsDomain { get; set; }

        [JsonProperty("RunAsUsername")]
        public string RunAsUserName { get; set; }
        public string RunAsPassword { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RunAsLoadUserProfile { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RunAsElevate { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? TimeoutInSeconds { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RunProcessInputWindowStyleType
    {
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "maximised")]
        Maximised,
        [EnumMember(Value = "minimised")]
        Minimised,
        [EnumMember(Value = "hidden")]
        Hidden
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RunProcessInputStandardOutputEncodingType
    {
        [EnumMember(Value = "UTF8")]
        Utf8,
        [EnumMember(Value = "UTF7")]
        Utf7,
        [EnumMember(Value = "UTF16")]
        Utf16,
        [EnumMember(Value = "ASCII")]
        Ascii,
        [EnumMember(Value = "UTF16BE")]
        Utf16BE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RunProcessInputStandardErrorEncodingType
    {
        [EnumMember(Value = "UTF8")]
        Utf8,
        [EnumMember(Value = "UTF7")]
        Utf7,
        [EnumMember(Value = "UTF16")]
        Utf16,
        [EnumMember(Value = "ASCII")]
        Ascii,
        [EnumMember(Value = "UTF16BE")]
        Utf16BE
    }

    public class RunPowerShellProcessResponse
    {
        public bool ProcessStarted { get; set; }
        public int ExitCode { get; set; }
        public bool ProcessTimedOut { get; set; }
        public int ProcessId { get; set; }
        public string StandardOutput { get; set; }
        public string StandardError { get; set; }
    }

    public class RunPowerShellProcessInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PowerShellExecutable { get; set; } = "PowerShell.exe";
        public string PowerShellScriptFilePath { get; set; }
        public string PowerShellScriptContents { get; set; }
        public string WorkingDirectory { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CreateNoWindow { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public RunPowerShellProcessInputWindowStyleType? WindowStyle { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.RunPowerShellProcessInputWindowStyleType.Normal;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? WaitForProcess { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RedirectStandardOutput { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RedirectStandardError { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RedirectStandardErrorToOutput { get; set; } = false;
        public RunPowerShellProcessInputStandardOutputEncodingType? StandardOutputEncoding { get; set; }
        public RunPowerShellProcessInputStandardErrorEncodingType? StandardErrorEncoding { get; set; }
        public string RunAsDomain { get; set; }

        [JsonProperty("RunAsUsername")]
        public string RunAsUserName { get; set; }
        public string RunAsPassword { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RunAsLoadUserProfile { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RunAsElevate { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? TimeoutInSeconds { get; set; } = 10;
        public string PowerShellScriptTempFolder { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RunPowerShellProcessInputWindowStyleType
    {
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "maximised")]
        Maximised,
        [EnumMember(Value = "minimised")]
        Minimised,
        [EnumMember(Value = "hidden")]
        Hidden
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RunPowerShellProcessInputStandardOutputEncodingType
    {
        [EnumMember(Value = "UTF8")]
        Utf8,
        [EnumMember(Value = "UTF7")]
        Utf7,
        [EnumMember(Value = "UTF16")]
        Utf16,
        [EnumMember(Value = "ASCII")]
        Ascii,
        [EnumMember(Value = "UTF16BE")]
        Utf16BE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RunPowerShellProcessInputStandardErrorEncodingType
    {
        [EnumMember(Value = "UTF8")]
        Utf8,
        [EnumMember(Value = "UTF7")]
        Utf7,
        [EnumMember(Value = "UTF16")]
        Utf16,
        [EnumMember(Value = "ASCII")]
        Ascii,
        [EnumMember(Value = "UTF16BE")]
        Utf16BE
    }

    public class GetScreenResolutionResponse
    {
        public int HorizontalResolution { get; set; }
        public int VerticalResolution { get; set; }
        public int NumberOfScreens { get; set; }
        public int SecondDisplayHorizontalResolution { get; set; }
        public int SecondDisplayVerticalResolution { get; set; }
        public int ThirdDisplayHorizontalResolution { get; set; }
        public int ThirdDisplayVerticalResolution { get; set; }
        public int FourthDisplayHorizontalResolution { get; set; }
        public int FourthDisplayVerticalResolution { get; set; }
        public int VirtualScreenLeftEdgePixels { get; set; }
        public int VirtualScreenTopEdgePixels { get; set; }
        public int VirtualScreenWidthPixels { get; set; }
        public int VirtualScreenHeightPixels { get; set; }
        public double PrimaryDisplayScaling { get; set; }
        public double SecondDisplayScaling { get; set; }
        public double ThirdDisplayScaling { get; set; }
        public double FourthDisplayScaling { get; set; }
        public int PhysicalScreenLeftEdgePixels { get; set; }
        public int PhysicalScreenTopEdgePixels { get; set; }
        public int PhysicalScreenWidthPixels { get; set; }
        public int PhysicalScreenHeightPixels { get; set; }
        public int PrimaryDisplayLeftEdgePixels { get; set; }
        public int PrimaryDisplayTopEdgePixels { get; set; }
        public int SecondDisplayLeftEdgePixels { get; set; }
        public int SecondDisplayTopEdgePixels { get; set; }
        public int ThirdDisplayLeftEdgePixels { get; set; }
        public int ThirdDisplayTopEdgePixels { get; set; }
        public int FourthDisplayLeftEdgePixels { get; set; }
        public int FourthDisplayTopEdgePixels { get; set; }
    }

    public class GetScreenResolutionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SetDefaultPrinterInput
    {
        public SetDefaultPrinterInput(string defaultPrinterName)
        {
            this.DefaultPrinterName = defaultPrinterName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DefaultPrinterName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetDefaultPrinterResponse
    {
        public string DefaultPrinterName { get; set; }
    }

    public class GetDefaultPrinterInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetListOfPrintersResponse
    {
        [JsonProperty("PrintersJSON")]
        public string PrintersJson { get; set; }
        public int NumberOfPrinters { get; set; }
    }

    public class GetListOfPrintersInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ListLocalPrinters { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ListNetworkPrinters { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnDetailedInformation { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SetMouseMultiplierInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? MouseXMultiplier { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? MouseYMultiplier { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ApplyToMouseEvent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ApplyToSetCursorPos { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ApplyToCurrentMouseMoveMethod { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetMouseMultiplierResponse
    {
        public double MouseXMultiplier { get; set; }
        public double MouseYMultiplier { get; set; }
        public string MouseMoveMethod { get; set; }
    }

    public class GetMouseMultiplierInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MoveMouseToCoordinateInput
    {
        public MoveMouseToCoordinateInput(int xCoord, int yCoord)
        {
            this.XCoord = xCoord;
            this.YCoord = yCoord;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int XCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int YCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MoveMouseRelativeInput
    {
        public MoveMouseRelativeInput(int xCoord, int yCoord)
        {
            this.XCoord = xCoord;
            this.YCoord = yCoord;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int XCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int YCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class LeftMouseButtonDownInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class LeftMouseButtonUpInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class LeftClickMouseInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class LeftClickMouseAtCoordinateInput
    {
        public LeftClickMouseAtCoordinateInput(int xCoord, int yCoord)
        {
            this.XCoord = xCoord;
            this.YCoord = yCoord;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int XCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int YCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class LeftHoldMouseInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double SecondsToHold { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class LeftHoldMouseAtCoordinateInput
    {
        public LeftHoldMouseAtCoordinateInput(int xCoord, int yCoord)
        {
            this.XCoord = xCoord;
            this.YCoord = yCoord;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int XCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int YCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double SecondsToHold { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RightMouseButtonDownInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RightMouseButtonUpInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RightClickMouseInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RightClickMouseAtCoordinateInput
    {
        public RightClickMouseAtCoordinateInput(int xCoord, int yCoord)
        {
            this.XCoord = xCoord;
            this.YCoord = yCoord;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int XCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int YCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RightHoldMouseInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double SecondsToHold { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RightHoldMouseAtCoordinateInput
    {
        public RightHoldMouseAtCoordinateInput(int xCoord, int yCoord)
        {
            this.XCoord = xCoord;
            this.YCoord = yCoord;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int XCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int YCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double SecondsToHold { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MiddleMouseButtonDownInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MiddleMouseButtonUpInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MiddleClickMouseInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MiddleClickMouseAtCoordinateInput
    {
        public MiddleClickMouseAtCoordinateInput(int xCoord, int yCoord)
        {
            this.XCoord = xCoord;
            this.YCoord = yCoord;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int XCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int YCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MiddleHoldMouseInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double SecondsToHold { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MiddleHoldMouseAtCoordinateInput
    {
        public MiddleHoldMouseAtCoordinateInput(int xCoord, int yCoord)
        {
            this.XCoord = xCoord;
            this.YCoord = yCoord;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int XCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int YCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double SecondsToHold { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class DoubleLeftClickMouseInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DelayInMilliseconds { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class DoubleLeftClickMouseAtCoordinateInput
    {
        public DoubleLeftClickMouseAtCoordinateInput(int xCoord, int yCoord)
        {
            this.XCoord = xCoord;
            this.YCoord = yCoord;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int XCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int YCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DelayInMilliseconds { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class LeftMouseDragBetweenCoordinatesInput
    {
        public LeftMouseDragBetweenCoordinatesInput(int startXCoord, int startYCoord, int endXCoord, int endYCoord)
        {
            this.StartXCoord = startXCoord;
            this.StartYCoord = startYCoord;
            this.EndXCoord = endXCoord;
            this.EndYCoord = endYCoord;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int StartXCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int StartYCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int EndXCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int EndYCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? NumberOfSteps { get; set; } = 20;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? TotalTimeInSeconds { get; set; } = 0.5;
        public int? MaximumMovementPixelJitter { get; set; }
        public int? MaximumEndPixelJitter { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumMovementPixelJitterDelta { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RightMouseDragBetweenCoordinatesInput
    {
        public RightMouseDragBetweenCoordinatesInput(int startXCoord, int startYCoord, int endXCoord, int endYCoord)
        {
            this.StartXCoord = startXCoord;
            this.StartYCoord = startYCoord;
            this.EndXCoord = endXCoord;
            this.EndYCoord = endYCoord;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int StartXCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int StartYCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int EndXCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int EndYCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? NumberOfSteps { get; set; } = 20;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? TotalTimeInSeconds { get; set; } = 0.5;
        public int? MaximumMovementPixelJitter { get; set; }
        public int? MaximumEndPixelJitter { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumMovementPixelJitterDelta { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MiddleMouseDragBetweenCoordinatesInput
    {
        public MiddleMouseDragBetweenCoordinatesInput(int startXCoord, int startYCoord, int endXCoord, int endYCoord)
        {
            this.StartXCoord = startXCoord;
            this.StartYCoord = startYCoord;
            this.EndXCoord = endXCoord;
            this.EndYCoord = endYCoord;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int StartXCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int StartYCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int EndXCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int EndYCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? NumberOfSteps { get; set; } = 20;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? TotalTimeInSeconds { get; set; } = 0.5;
        public int? MaximumMovementPixelJitter { get; set; }
        public int? MaximumEndPixelJitter { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumMovementPixelJitterDelta { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MoveMouseBetweenCoordinatesInput
    {
        public MoveMouseBetweenCoordinatesInput(int startXCoord, int startYCoord, int endXCoord, int endYCoord)
        {
            this.StartXCoord = startXCoord;
            this.StartYCoord = startYCoord;
            this.EndXCoord = endXCoord;
            this.EndYCoord = endYCoord;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int StartXCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int StartYCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int EndXCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int EndYCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? NumberOfSteps { get; set; } = 20;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? TotalTimeInSeconds { get; set; } = 0.5;
        public int? MaximumMovementPixelJitter { get; set; }
        public int? MaximumEndPixelJitter { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumMovementPixelJitterDelta { get; set; } = 2;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class TurnMouseWheelInput
    {
        public TurnMouseWheelInput(int wheelTurns)
        {
            this.WheelTurns = wheelTurns;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int WheelTurns { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SetCursorPosInput
    {
        public SetCursorPosInput(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int X { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Y { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetCursorPosResponse
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class GetCursorPosInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class CalibrateMouseEventResponse
    {
        public double MouseXMultiplier { get; set; }
        public double MouseYMultiplier { get; set; }
    }

    public class CalibrateMouseEventInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? CalibrationSizeInPixels { get; set; } = 200;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetMouseMoveMethodResponse
    {
        public string MouseMoveMethod { get; set; }
    }

    public class GetMouseMoveMethodInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SetMouseMoveMethodInput
    {
        public SetMouseMoveMethodInput(SetMouseMoveMethodInputMouseMoveMethodType mouseMoveMethod)
        {
            this.MouseMoveMethod = mouseMoveMethod;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetMouseMoveMethodInputMouseMoveMethodType MouseMoveMethod { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetMouseMoveMethodInputMouseMoveMethodType
    {
        [EnumMember(Value = "mouse_event")]
        MouseEvent,
        [EnumMember(Value = "setcursorpos")]
        Setcursorpos
    }

    public class WiggleMouseInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? XWiggle { get; set; } = 2;
        public int? YWiggle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? WiggleDelayInSeconds { get; set; } = 0.1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SendKeyEventsInput
    {
        public SendKeyEventsInput(string text)
        {
            this.Text = text;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Interval { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsPassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DontInterpretSymbols { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SendPasswordKeyEventsInput
    {
        public SendPasswordKeyEventsInput(string password)
        {
            this.Password = password;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Interval { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DontInterpretSymbols { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PasswordContainsStoredPassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SendKeysInput
    {
        public SendKeysInput(string text)
        {
            this.Text = text;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Text { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Interval { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IsPassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DontInterpretSymbols { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SendPasswordKeysInput
    {
        public SendPasswordKeysInput(string password)
        {
            this.Password = password;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Interval { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DontInterpretSymbols { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PasswordContainsStoredPassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ClearClipboardInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SetClipboardDataInput
    {
        public string NewClipboardData { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetClipboardDataResponse
    {
        public string ClipboardData { get; set; }
    }

    public class GetClipboardDataInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class TakeScreenshotResponse
    {
        public string ScreenBitmapBase64 { get; set; }
        public bool ScreenshotSuccessful { get; set; }
        public string ScreenshotErrorMessage { get; set; }
    }

    public class TakeScreenshotInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Fullscreen { get; set; } = true;
        public int? LeftXPixels { get; set; }
        public int? TopYPixels { get; set; }
        public int? WidthPixels { get; set; }
        public int? HeightPixels { get; set; }
        public TakeScreenshotInputImageFormatType? ImageFormat { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseDisplayDevice { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionOnError { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? HideAgent { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UsePhysicalCoordinates { get; set; } = false;
        public int? DisplayDeviceId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TakeScreenshotInputImageFormatType
    {
        [EnumMember(Value = "PNG")]
        Png,
        [EnumMember(Value = "JPG")]
        Jpg,
        [EnumMember(Value = "BMP")]
        Bmp,
        [EnumMember(Value = "GIF")]
        Gif
    }

    public class GetEnvironmentInfoResponse
    {
        public int OSVersionMajor { get; set; }
        public int OSVersionMinor { get; set; }
        public int OSVersionBuild { get; set; }

        [JsonProperty("OSIs64Bit")]
        public bool Osis64Bit { get; set; }
        public int ProcessorCount { get; set; }

        [JsonProperty("TotalPhysicalRAMInMB")]
        public int TotalPhysicalRamInMB { get; set; }

        [JsonProperty("TotalVirtualRAMInMB")]
        public int TotalVirtualRamInMB { get; set; }

        [JsonProperty("AvailablePhysicalRAMInMB")]
        public int AvailablePhysicalRamInMB { get; set; }

        [JsonProperty("AvailableVirtualRAMInMB")]
        public int AvailableVirtualRamInMB { get; set; }
        public string OSFullName { get; set; }
        public string InstalledUICultureName { get; set; }
        public string CurrentUICultureName { get; set; }
        public string CurrentCultureName { get; set; }
    }

    public class GetEnvironmentInfoInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class IsScreenReaderEnabledResponse
    {
        public bool ScreenReaderEnabled { get; set; }
    }

    public class IsScreenReaderEnabledInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SetScreenReaderInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EnableScreenReader { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetParentProcessIdResponse
    {
        public int ParentProcessId { get; set; }
        public bool ParentProcessStillRunning { get; set; }
        public string ParentProcessName { get; set; }
    }

    public class GetParentProcessIdInput
    {
        public GetParentProcessIdInput(int processId)
        {
            this.ProcessId = processId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ProcessId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetProcessIdCommandLineResponse
    {
        public string ProcessCommandLine { get; set; }
        public string ProcessArguments { get; set; }
        public string ProcessCurrentWorkingDirectory { get; set; }
        public string ProcessImagePathName { get; set; }
    }

    public class GetProcessIdCommandLineInput
    {
        public GetProcessIdCommandLineInput(int processId)
        {
            this.ProcessId = processId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ProcessId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetLastInputInfoResponse
    {
        public int LastInputTotalSeconds { get; set; }
        public int LastInputTotalMinutes { get; set; }
        public int LastInputTotalHours { get; set; }
    }

    public class GetLastInputInfoInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class KeepSessionAliveResponse
    {
        public bool KeepSessionAliveResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class KeepSessionAliveInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? XWiggle { get; set; } = 2;
        public int? YWiggle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? WiggleDelayInSeconds { get; set; } = 0.1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? IdleThresholdInSeconds { get; set; } = 120;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? IdleCheckPeriodInSeconds { get; set; } = 30;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? TotalKeepaliveRuntimeInSeconds { get; set; } = -1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class StopKeepSessionAliveResponse
    {
        public bool StopKeepSessionAliveResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class StopKeepSessionAliveInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class CopyFileToClipboardResponse
    {
        public bool CopyFileToClipboardResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class CopyFileToClipboardInput
    {
        public CopyFileToClipboardInput(string filepath)
        {
            this.Filepath = filepath;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Filepath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Cut { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetRemoteSessionInfoResponse
    {
        public int SessionId { get; set; }
        public int SessionType { get; set; }
        public string SessionTypeName { get; set; }
    }

    public class GetRemoteSessionInfoInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GeneratePasswordResponse
    {
        public string PlainTextPassword { get; set; }
    }

    public class GeneratePasswordInput
    {
        public GeneratePasswordInput(string passwordFormat)
        {
            this.PasswordFormat = passwordFormat;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PasswordFormat { get; set; }
        public int? MinimumLength { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnAsPlainText { get; set; } = false;
        public string StorePasswordAsIdentifier { get; set; }
        public string SupportedSymbols { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AttemptUniquePasswords { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public GeneratePasswordInputGenerateAtType? GenerateAt { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.GeneratePasswordInputGenerateAtType.Agent;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MinimumLowercase { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MinimumUppercase { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MinimumNumbers { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MinimumSymbols { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GeneratePasswordInputGenerateAtType
    {
        Agent,
        Orchestrator
    }

    public class GetStoredPasswordResponse
    {
        public string PlainTextPassword { get; set; }
    }

    public class GetStoredPasswordInput
    {
        public string PasswordIdentifier { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ExpandPasswordStringResponse
    {
        public string OutputString { get; set; }
    }

    public class ExpandPasswordStringInput
    {
        public string InputString { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class StorePasswordInAgentMemoryResponse
    {
        public bool StorePasswordInAgentMemoryResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class StorePasswordInAgentMemoryInput
    {
        public StorePasswordInAgentMemoryInput(string identifier, string password)
        {
            this.Identifier = identifier;
            this.Password = password;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identifier { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class DeletePasswordInAgentMemoryResponse
    {
        public bool DeletePasswordInAgentMemoryResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class DeletePasswordInAgentMemoryInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeleteAllPasswords { get; set; } = false;
        public string Identifier { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class CredentialWriteResponse
    {
        public bool CredentialWriteResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class CredentialWriteInput
    {
        public CredentialWriteInput(string credentialAddress, string userName, string password, CredentialWriteInputCredentialTypeType credentialType)
        {
            this.CredentialAddress = credentialAddress;
            this.UserName = userName;
            this.Password = password;
            this.CredentialType = credentialType;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CredentialAddress { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public CredentialWriteInputCredentialTypeType CredentialType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public CredentialWriteInputCredentialPersistenceType? CredentialPersistence { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.CredentialWriteInputCredentialPersistenceType.LocalMachine;
        public string SymmetricKey { get; set; }
        public string StorePasswordAsIdentifier { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CredentialWriteInputCredentialTypeType
    {
        Windows,
        Generic
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CredentialWriteInputCredentialPersistenceType
    {
        Session,
        LocalMachine,
        Enterprise
    }

    public class CredentialReadResponse
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class CredentialReadInput
    {
        public CredentialReadInput(string credentialAddress, CredentialReadInputCredentialTypeType credentialType)
        {
            this.CredentialAddress = credentialAddress;
            this.CredentialType = credentialType;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CredentialAddress { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public CredentialReadInputCredentialTypeType CredentialType { get; set; }
        public string SymmetricKey { get; set; }
        public string StorePasswordAsIdentifier { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DontReturnPassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CredentialReadInputCredentialTypeType
    {
        Windows,
        Generic
    }

    public class CredentialDeleteResponse
    {
        public bool CredentialDeleteResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class CredentialDeleteInput
    {
        public CredentialDeleteInput(string credentialAddress, CredentialDeleteInputCredentialTypeType credentialType)
        {
            this.CredentialAddress = credentialAddress;
            this.CredentialType = credentialType;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CredentialAddress { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public CredentialDeleteInputCredentialTypeType CredentialType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CredentialDeleteInputCredentialTypeType
    {
        Windows,
        Generic
    }

    public class GenerateRdpFileResponse
    {
        [JsonProperty("RDPFilePath")]
        public string RdpFilePath { get; set; }
    }

    public class GenerateRdpFileInput
    {
        public GenerateRdpFileInput(string remoteAddress, string outputFolderPath, string rdpFileName)
        {
            this.RemoteAddress = remoteAddress;
            this.OutputFolderPath = outputFolderPath;
            this.RdpFileName = rdpFileName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string RemoteAddress { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string OutputFolderPath { get; set; }

        [JsonProperty("RDPFileName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RdpFileName { get; set; }

        [JsonProperty("OverwriteRDPFileIfAlreadyExists", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OverwriteRdpFileIfAlreadyExists { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TrustRemoteComputer { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? StoreCredentials { get; set; } = true;
        public string UserName { get; set; }
        public string Password { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateRdpFileInputCredentialTypeType? CredentialType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.GenerateRdpFileInputCredentialTypeType.Windows;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateRdpFileInputCredentialPersistenceType? CredentialPersistence { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.GenerateRdpFileInputCredentialPersistenceType.Session;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RedirectPrinters { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RedirectAllDrives { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RedirectClipboard { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Fullscreen { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DesktopWidth { get; set; } = 1280;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? DesktopHeight { get; set; } = 1024;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseMultiMonitor { get; set; } = false;

        [JsonProperty("SessionBPP", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SessionBpp { get; set; } = 32;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SmartSizing { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerateRdpFileInputCredentialTypeType
    {
        Windows,
        Generic
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerateRdpFileInputCredentialPersistenceType
    {
        Session,
        LocalMachine,
        Enterprise
    }

    public class LaunchRemoteDesktopSessionResponse
    {
        public bool LaunchRemoteDesktopSessionResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class LaunchRemoteDesktopSessionInput
    {
        public LaunchRemoteDesktopSessionInput(string rdpFilePath)
        {
            this.RdpFilePath = rdpFilePath;
        }

        [JsonProperty("RDPFilePath", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RdpFilePath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TrustRemoteComputer { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class IsTcpPortRespondingResponse
    {
        [JsonProperty("TCPPortConnected")]
        public bool TcpPortConnected { get; set; }
        public string ConnectionErrorMessage { get; set; }
    }

    public class IsTcpPortRespondingInput
    {
        public IsTcpPortRespondingInput(string remoteHost, int tcpPort)
        {
            this.RemoteHost = remoteHost;
            this.TcpPort = tcpPort;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string RemoteHost { get; set; }

        [JsonProperty("TCPPort", DefaultValueHandling = DefaultValueHandling.Include)]
        public int TcpPort { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? TimeoutInSeconds { get; set; } = 10;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class UnlockSessionResponse
    {
        public bool SessionUnlockPerformed { get; set; }
    }

    public class UnlockSessionInput
    {
        public UnlockSessionInput(string unlockPassword)
        {
            this.UnlockPassword = unlockPassword;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UnlockPassword { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PasswordContainsStoredPassword { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool DetectIfLocked { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool DetectCredentialProvider { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWaitForUnlock { get; set; } = 5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class LockSessionResponse
    {
        public bool LockSessionResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class LockSessionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? LockAfterMinutesOfActionInactivity { get; set; } = 5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWaitAfterLock { get; set; } = 3;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class IsSessionLockedResponse
    {
        public bool SessionIsLocked { get; set; }
    }

    public class IsSessionLockedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetGenericCredentialFromOrchestratorResponse
    {
        [JsonProperty("Username")]
        public string UserName { get; set; }
        public string PlainTextPassword { get; set; }
        public string Hostname { get; set; }
        public string Url { get; set; }
        public string GenericProperty1 { get; set; }
        public string GenericProperty2 { get; set; }
        public string GenericProperty3 { get; set; }
    }

    public class GetGenericCredentialFromOrchestratorInput
    {
        public string FriendlyName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RetrievePlainTextPassword { get; set; } = false;
    }

    public class DrawRectangleOnScreenResponse
    {
        public bool DrawRectangleOnScreenResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class DrawRectangleOnScreenInput
    {
        public DrawRectangleOnScreenInput(int rectangleLeftPixelXCoord, int rectangleRightPixelXCoord, int rectangleTopPixelYCoord, int rectangleBottomPixelYCoord)
        {
            this.RectangleLeftPixelXCoord = rectangleLeftPixelXCoord;
            this.RectangleRightPixelXCoord = rectangleRightPixelXCoord;
            this.RectangleTopPixelYCoord = rectangleTopPixelYCoord;
            this.RectangleBottomPixelYCoord = rectangleBottomPixelYCoord;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RectangleLeftPixelXCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RectangleRightPixelXCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RectangleTopPixelYCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RectangleBottomPixelYCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string PenColour { get; set; } = "#800080";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? PenThicknessPixels { get; set; } = 4;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToDisplay { get; set; } = 5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CoordinatesArePhysical { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetFailedActionErrorMessageFromPowerAutomateResultJsonResponse
    {
        public string ActionErrorMessage { get; set; }
        public string ActionName { get; set; }
        public string ActionCode { get; set; }
    }

    public class GetFailedActionErrorMessageFromPowerAutomateResultJsonInput
    {
        public GetFailedActionErrorMessageFromPowerAutomateResultJsonInput(string[] powerAutomateResultJson)
        {
            this.PowerAutomateResultJson = powerAutomateResultJson;
        }

        [JsonProperty("PowerAutomateResultJSON", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] PowerAutomateResultJson { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchStatus { get; set; } = "Failed";
    }

    public class GetPixelColourAtCoordinateResponse
    {
        public int RedValue { get; set; }
        public int GreenValue { get; set; }
        public int BlueValue { get; set; }
        public int AlphaValue { get; set; }

        [JsonProperty("RRGGBBHexValue")]
        public string RrggbbHexValue { get; set; }

        [JsonProperty("AARRGGBBHexValue")]
        public string AarrggbbHexValue { get; set; }
    }

    public class GetPixelColourAtCoordinateInput
    {
        public GetPixelColourAtCoordinateInput(int leftXPixels, int topYPixels)
        {
            this.LeftXPixels = leftXPixels;
            this.TopYPixels = topYPixels;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int LeftXPixels { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int TopYPixels { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? HideAgent { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UsePhysicalCoordinates { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ConvertRectangleCoordinatesResponse
    {
        public int ConvertedRectangleLeftPixelXCoord { get; set; }
        public int ConvertedRectangleTopPixelYCoord { get; set; }
        public int ConvertedRectangleRightPixelXCoord { get; set; }
        public int ConvertedRectangleBottomPixelYCoord { get; set; }
        public int ConvertedRectangleWidth { get; set; }
        public int ConvertedRectangleHeight { get; set; }
    }

    public class ConvertRectangleCoordinatesInput
    {
        public ConvertRectangleCoordinatesInput(int rectangleLeftPixelXCoord, int rectangleTopPixelYCoord, int rectangleRightPixelXCoord, int rectangleBottomPixelYCoord, ConvertRectangleCoordinatesInputConversionTypeType conversionType)
        {
            this.RectangleLeftPixelXCoord = rectangleLeftPixelXCoord;
            this.RectangleTopPixelYCoord = rectangleTopPixelYCoord;
            this.RectangleRightPixelXCoord = rectangleRightPixelXCoord;
            this.RectangleBottomPixelYCoord = rectangleBottomPixelYCoord;
            this.ConversionType = conversionType;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RectangleLeftPixelXCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RectangleTopPixelYCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RectangleRightPixelXCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int RectangleBottomPixelYCoord { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public ConvertRectangleCoordinatesInputConversionTypeType ConversionType { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ConvertRectangleCoordinatesInputConversionTypeType
    {
        [EnumMember(Value = "P2V")]
        PhysicalToVirtual,
        [EnumMember(Value = "V2P")]
        VirtualToPhysical
    }

    public class SendMessageToWebApiResponse
    {
        public int ResponseStatusCode { get; set; }
        public string ResponseMessage { get; set; }
        public string ResponseContentType { get; set; }

        [JsonProperty("ResponseHeadersJSON")]
        public string ResponseHeadersJson { get; set; }
        public int ThreadId { get; set; }
    }

    public class SendMessageToWebApiInput
    {
        [JsonProperty("URL")]
        public string Url { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SendMessageToWebApiInputMethodType? Method { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.SendMessageToWebApiInputMethodType.Get;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? TimeoutInSeconds { get; set; } = 20;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ContentType { get; set; } = "application/json; charset=utf-8";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Accept { get; set; } = "application/json";
        public string MessageBody { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SendMessageToWebApiInputTransmitEncodingType? TransmitEncoding { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.SendMessageToWebApiInputTransmitEncodingType.Utf8;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SendMessageToWebApiInputResponseEncodingType? ResponseEncoding { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.SendMessageToWebApiInputResponseEncodingType.Utf8;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? BufferSize { get; set; } = 16384;

        [JsonProperty("HTTPRequestHeadersList")]
        public SendMessageToWebApiInputHttpRequestHeadersListTypeItem[] HttpRequestHeadersList { get; set; }

        [JsonProperty("NegotiateTLS10", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NegotiateTls10 { get; set; } = false;

        [JsonProperty("NegotiateTLS11", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NegotiateTls11 { get; set; } = false;

        [JsonProperty("NegotiateTLS12", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NegotiateTls12 { get; set; } = true;

        [JsonProperty("NegotiateTLS13", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NegotiateTls13 { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? KeepAlive { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Expect100Continue { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnResponseHeaders { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RunAsThread { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? WaitForThread { get; set; } = true;
        public int? RetrieveOutputDataFromThreadId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendMessageToWebApiInputMethodType
    {
        [EnumMember(Value = "GET")]
        Get,
        [EnumMember(Value = "PUT")]
        Put,
        [EnumMember(Value = "POST")]
        Post,
        [EnumMember(Value = "PATCH")]
        Patch,
        [EnumMember(Value = "DELETE")]
        Delete,
        [EnumMember(Value = "HEAD")]
        Head,
        [EnumMember(Value = "OPTIONS")]
        Options,
        [EnumMember(Value = "TRACE")]
        Trace
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendMessageToWebApiInputTransmitEncodingType
    {
        [EnumMember(Value = "UTF-8")]
        Utf8,
        [EnumMember(Value = "UTF-7")]
        Utf7,
        [EnumMember(Value = "UTF-16")]
        Utf16,
        [EnumMember(Value = "ASCII")]
        Ascii,
        [EnumMember(Value = "UTF-16BE")]
        Utf16BE
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SendMessageToWebApiInputResponseEncodingType
    {
        [EnumMember(Value = "UTF-8")]
        Utf8,
        [EnumMember(Value = "UTF-7")]
        Utf7,
        [EnumMember(Value = "UTF-16")]
        Utf16,
        [EnumMember(Value = "ASCII")]
        Ascii,
        [EnumMember(Value = "UTF-16BE")]
        Utf16BE
    }

    public class SendMessageToWebApiInputHttpRequestHeadersListTypeItem
    {
        public string Property { get; set; }
        public string Value { get; set; }
    }

    public class TasksAddNewTaskResponse
    {
        public int TaskId { get; set; }
    }

    public class TasksAddNewTaskInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public TasksAddNewTaskInputSetAutomationNameType? SetAutomationName { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.TasksAddNewTaskInputSetAutomationNameType.AutoUseNameOfTheFlow;
        public string AutomationName { get; set; }
        public string TaskInputData { get; set; }
        public string ProcessStage { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Priority { get; set; } = 3;

        [JsonProperty("SLA")]
        public int? Sla { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TaskOnHold { get; set; } = false;
        public string Organisation { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TasksAddNewTaskInputSetAutomationNameType
    {
        [EnumMember(Value = "Auto")]
        AutoUseNameOfTheFlow,
        [EnumMember(Value = "Manual")]
        ManualSetYourOwnAutomationTaskName
    }

    public class TasksAddNewDeferralResponse
    {
        public int TaskId { get; set; }
    }

    public class TasksAddNewDeferralInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public TasksAddNewDeferralInputSetAutomationNameType? SetAutomationName { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.TasksAddNewDeferralInputSetAutomationNameType.AutoUseNameOfTheFlow;
        public string AutomationName { get; set; }
        public int? DeferralTimeInMinutes { get; set; }
        public string TaskInputData { get; set; }
        public string DeferralStoredData { get; set; }
        public string ProcessStage { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Priority { get; set; } = 3;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TaskOnHold { get; set; } = false;
        public string Organisation { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TasksAddNewDeferralInputSetAutomationNameType
    {
        [EnumMember(Value = "Auto")]
        AutoUseNameOfTheFlow,
        [EnumMember(Value = "Manual")]
        ManualSetYourOwnAutomationTaskName
    }

    public class TasksDeferExistingTaskResponse
    {
        public bool TasksDeferExistingTaskResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class TasksDeferExistingTaskInput
    {
        public TasksDeferExistingTaskInput(int taskId)
        {
            this.TaskId = taskId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int TaskId { get; set; }
        public int? DeferralTimeInMinutes { get; set; }
        public string DeferralStoredData { get; set; }
        public string ProcessStage { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Priority { get; set; } = 3;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TaskOnHold { get; set; } = false;
    }

    public class TasksDeferExistingTaskOperationResponse
    {
        public bool TasksDeferExistingTaskOperationResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class TasksDeferExistingTaskOperationInput
    {
        public TasksDeferExistingTaskOperationInput(string operationId)
        {
            this.OperationId = operationId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string OperationId { get; set; }
        public int? DeferralTimeInMinutes { get; set; }
        public string DeferralStoredData { get; set; }
        public string ProcessStage { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Priority { get; set; } = 3;
    }

    public class TasksDeleteTaskResponse
    {
        public bool TasksDeleteTaskResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class TasksDeleteTaskInput
    {
        public TasksDeleteTaskInput(int taskId)
        {
            this.TaskId = taskId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int TaskId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UpdateSourceSystem { get; set; } = true;
    }

    public class TasksDeleteTaskOperationResponse
    {
        public bool TasksDeleteTaskOperationResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class TasksDeleteTaskOperationInput
    {
        public TasksDeleteTaskOperationInput(string operationId)
        {
            this.OperationId = operationId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string OperationId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UpdateSourceSystem { get; set; } = true;
    }

    public class TasksGetAllTasksResponse
    {
        public JToken[] AutomationTasks { get; set; }
        public int NumberOfAutomationTasks { get; set; }
    }

    public class TasksGetAllTasksInput
    {
        public string AutomationName { get; set; }
        public TasksGetAllTasksInputAutomationTaskStatusType? AutomationTaskStatus { get; set; }
        public string FilterByPropertyQuery { get; set; }
        public int? MinutesUntilDeferralDate { get; set; }
        public int? MinimumPriorityLevel { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SortByDeferralDate { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RetrieveOnHoldTasks { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Skip { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxResults { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExcludeTaskData { get; set; } = false;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TasksGetAllTasksInputAutomationTaskStatusType
    {
        Deferred,
        New,
        Retrieved,
        Failed,
        Completed
    }

    public class TasksGetTaskResponse
    {
        public string AutomationName { get; set; }
        public string OperationId { get; set; }
        public string DeferralDateTime { get; set; }
        public string DeferralStoredData { get; set; }
        public int DeferralCount { get; set; }
        public string TaskInputData { get; set; }
        public string TaskOutputData { get; set; }
        public int Priority { get; set; }
        public string AutomationTaskStatus { get; set; }
        public string ProcessStage { get; set; }
        public string ReceivedDateTime { get; set; }
        public int MinutesUntilDeferralDate { get; set; }
        public bool OnHold { get; set; }
        public string SourceTypeName { get; set; }
        public string SourceFriendlyName { get; set; }
        public string SourceTicketId { get; set; }
        public string SourceTicketSubId { get; set; }
        public string Organisation { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
    }

    public class TasksGetTaskInput
    {
        public TasksGetTaskInput(int taskId)
        {
            this.TaskId = taskId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int TaskId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public TasksGetTaskInputStatusChangeType? StatusChange { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.TasksGetTaskInputStatusChangeType.Retrieved;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TasksGetTaskInputStatusChangeType
    {
        Retrieved,
        [EnumMember(Value = "Do nothing")]
        DoNothing
    }

    public class TasksGetNextTaskResponse
    {
        public bool TaskRetrieved { get; set; }
        public int TaskId { get; set; }
        public string OperationId { get; set; }
        public string AutomationNameOutput { get; set; }
        public string DeferralDateTime { get; set; }
        public string DeferralStoredData { get; set; }
        public int DeferralCount { get; set; }
        public string TaskInputData { get; set; }
        public string TaskOutputData { get; set; }
        public int Priority { get; set; }
        public string AutomationTaskStatus { get; set; }
        public string ProcessStage { get; set; }
        public string ReceivedDateTime { get; set; }
        public int MinutesUntilDeferralDateOutput { get; set; }
        public string SourceTypeName { get; set; }
        public string SourceFriendlyName { get; set; }
        public string SourceTicketId { get; set; }
        public string SourceTicketSubId { get; set; }
        public string Organisation { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
    }

    public class TasksGetNextTaskInput
    {
        public string AutomationName { get; set; }
        public string[] AutomationNames { get; set; }
        public int? MinimumPriorityLevel { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public TasksGetNextTaskInputStatusChangeType? StatusChange { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.TasksGetNextTaskInputStatusChangeType.Retrieved;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MinutesUntilDeferralDate { get; set; } = 0;

        [JsonProperty("IgnoreSLA", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IgnoreSla { get; set; } = false;
        public int[] ExcludeTaskIds { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TasksGetNextTaskInputStatusChangeType
    {
        Retrieved,
        [EnumMember(Value = "Do nothing")]
        DoNothing
    }

    public class TasksChangeTaskStatusResponse
    {
        public bool TasksChangeTaskStatusResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class TasksChangeTaskStatusInput
    {
        public TasksChangeTaskStatusInput(int taskId)
        {
            this.TaskId = taskId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int TaskId { get; set; }
        public TasksChangeTaskStatusInputAutomationTaskStatusType? AutomationTaskStatus { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TaskOnHold { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EraseTaskInputData { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? EraseDeferralStoredData { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UpdateSourceSystem { get; set; } = true;
        public string TaskClosureReason { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TasksChangeTaskStatusInputAutomationTaskStatusType
    {
        Completed,
        Failed,
        New,
        Retrieved
    }

    public class TasksAddNoteResponse
    {
        public bool TasksAddNoteResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class TasksAddNoteInput
    {
        public TasksAddNoteInput(int taskId, string noteText)
        {
            this.TaskId = taskId;
            this.NoteText = noteText;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int TaskId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string NoteText { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public TasksAddNoteInputNoteTypeType? NoteType { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.TasksAddNoteInputNoteTypeType.WorkNote;
        public string NoteTypeOther { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TasksAddNoteInputNoteTypeType
    {
        WorkNote,
        [EnumMember(Value = "CloseNote")]
        ClosureNote,
        Comment,
        [EnumMember(Value = "Other")]
        OtherEnterValueIntoNoteTypeOther
    }

    public class TasksAssignTaskResponse
    {
        public bool TasksAssignTaskResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class TasksAssignTaskInput
    {
        public TasksAssignTaskInput(int taskId)
        {
            this.TaskId = taskId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int TaskId { get; set; }
        public string AssignToUserId { get; set; }
        public string AssignToUserName { get; set; }
        public string AssignToGroupId { get; set; }
        public string AssignToGroupName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveUserAssignmentIfBlank { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RemoveGroupAssignmentIfBlank { get; set; } = true;
    }

    public class TasksSetOutputDataResponse
    {
        public bool TasksSetOutputDataResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class TasksSetOutputDataInput
    {
        public TasksSetOutputDataInput(int taskId)
        {
            this.TaskId = taskId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int TaskId { get; set; }
        public string TaskOutputData { get; set; }
    }

    public class TasksAddNewTaskOperationResponse
    {
        public string OperationId { get; set; }
    }

    public class TasksAddNewTaskOperationInput
    {
        public string AutomationName { get; set; }
        public string TaskInputData { get; set; }
        public string ProcessStage { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Priority { get; set; } = 3;

        [JsonProperty("SLA")]
        public int? Sla { get; set; }
        public string Organisation { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
    }

    public class TasksAddNewDeferralOperationResponse
    {
        public string OperationId { get; set; }
    }

    public class TasksAddNewDeferralOperationInput
    {
        public string AutomationName { get; set; }
        public int? DeferralTimeInMinutes { get; set; }
        public string TaskInputData { get; set; }
        public string DeferralStoredData { get; set; }
        public string ProcessStage { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? Priority { get; set; } = 3;
        public string Organisation { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
    }

    public class TasksGetTaskOperationResponse
    {
        public string AutomationName { get; set; }
        public string DeferralDateTime { get; set; }
        public string DeferralStoredData { get; set; }
        public int DeferralCount { get; set; }
        public string TaskInputData { get; set; }
        public string TaskOutputData { get; set; }
        public int Priority { get; set; }
        public string AutomationTaskStatus { get; set; }
        public string ProcessStage { get; set; }
        public string ReceivedDateTime { get; set; }
        public int MinutesUntilDeferralDate { get; set; }
        public bool OnHold { get; set; }
        public string Organisation { get; set; }
        public string Department { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
    }

    public class TasksGetTaskOperationInput
    {
        public TasksGetTaskOperationInput(string operationId)
        {
            this.OperationId = operationId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string OperationId { get; set; }
    }

    public class SetRemoteLoggingLevelInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int LoggingLevel { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetRemoteLoggingLevelResponse
    {
        public int LoggingLevel { get; set; }

        [JsonProperty("IAConnectAgentLogFilename")]
        public string IAConnectAgentLogFileName { get; set; }
    }

    public class GetRemoteLoggingLevelInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SetLicenseCodeInput
    {
        public SetLicenseCodeInput(string customerNetbiosDomainName, string customerDisplayName, string vendorName, string licenseExpiryDate, string activationCode)
        {
            this.CustomerNetbiosDomainName = customerNetbiosDomainName;
            this.CustomerDisplayName = customerDisplayName;
            this.VendorName = vendorName;
            this.LicenseExpiryDate = licenseExpiryDate;
            this.ActivationCode = activationCode;
        }

        [JsonProperty("CustomerNETBIOSDomainName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CustomerNetbiosDomainName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CustomerDisplayName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string VendorName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LicenseExpiryDate { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ActivationCode { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? StoreInRegistry { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SetLicenseStringResponse
    {
        public int DaysUntilLicenseExpires { get; set; }
    }

    public class SetLicenseStringInput
    {
        public SetLicenseStringInput(string licenseString)
        {
            this.LicenseString = licenseString;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string LicenseString { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? StoreInRegistry { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetLicenseStateResponse
    {
        public bool IsLicensed { get; set; }
        public string LicenseType { get; set; }

        [JsonProperty("CustomerNETBIOSDomainName")]
        public string CustomerNetbiosDomainName { get; set; }

        [JsonProperty("DirectorHostnameCSV")]
        public string DirectorHostnameCsv { get; set; }
        public string CustomerDisplayName { get; set; }
        public string VendorName { get; set; }
        public string LicenseExpiryDate { get; set; }
        public int DaysUntilLicenseExpires { get; set; }
        public string LicenseFeatures { get; set; }

        [JsonProperty("IsJMLLicense")]
        public bool IsJmlLicense { get; set; }
    }

    public class GetLicenseStateInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SetRsaguiTopmostInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TopMost { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SetRsaguiOpacityInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double Opacity { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SetRsaguiPositionInput
    {
        public SetRsaguiPositionInput(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int X { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Y { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class BringRsaguiToFrontInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Focus { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? GlobalLeftMouseClick { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class DisconnectSessionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWait { get; set; } = 3;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DoNotDisconnectIfLocalAgent { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class LogoffSessionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWait { get; set; } = 3;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class CloseRsaServerInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWait { get; set; } = 3;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SetRpaCommandTimeoutInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int CommandTimeoutInSeconds { get; set; } = 30;

        [JsonProperty("TerminateTimedoutRPACommandThreads", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TerminateTimedoutRpaCommandThreads { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RunAlternativeIAConnectInput
    {
        public RunAlternativeIAConnectInput(string fileName)
        {
            this.FileName = fileName;
        }

        [JsonProperty("Filename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }
        public string Arguments { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? LoadIntoMemory { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RunAlternativeIAConnectSentFromDirectorResponse
    {
        public bool AlternativeFileCopied { get; set; }
    }

    public class RunAlternativeIAConnectSentFromDirectorInput
    {
        public RunAlternativeIAConnectSentFromDirectorInput(string localFileName)
        {
            this.LocalFileName = localFileName;
        }

        [JsonProperty("LocalFilename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LocalFileName { get; set; }

        [JsonProperty("RemoteFilename")]
        public string RemoteFileName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Compress { get; set; } = true;
        public string Arguments { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PermitDowngrade { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SkipVersionCheck { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? LoadIntoMemory { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SaveToDiskEvenIfRunningFromMemory { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetIAConnectAgentInfoResponse
    {
        public string IAConnectAgentVersion { get; set; }

        [JsonProperty("DotNetCLRVersion")]
        public string DotNetClrVersion { get; set; }

        [JsonProperty("IAConnectAgentRunAsUsername")]
        public string IAConnectAgentRunAsUserName { get; set; }
        public string IAConnectAgentRunAsUserdomain { get; set; }
        public string IAConnectAgentPath { get; set; }
        public bool IAConnectAgentIs64bitProcess { get; set; }
        public string IAConnectAgentReleaseVersion { get; set; }

        [JsonProperty("IAConnectAgentRPACommandTimeout")]
        public int IAConnectAgentRpaCommandTimeout { get; set; }

        [JsonProperty("IAConnectAgentLogFilename")]
        public string IAConnectAgentLogFileName { get; set; }
    }

    public class GetIAConnectAgentInfoInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetIAConnectAgentLogResponse
    {
        public string IAConnectAgentLogContentsBase64 { get; set; }

        [JsonProperty("IAConnectAgentLogFilenameOnly")]
        public string IAConnectAgentLogFileNameOnly { get; set; }
    }

    public class GetIAConnectAgentLogInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Compress { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnLastCommandOnly { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SaveLogToFile { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PlaceLogContentInDataItem { get; set; } = false;
        public string LocalSaveFolder { get; set; }

        [JsonProperty("UseAgentLogFilename", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? UseAgentLogFileName { get; set; } = true;

        [JsonProperty("LocalSaveFilename")]
        public string LocalSaveFileName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxBytesToRead { get; set; } = 4000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ResetCommandStatsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetAllCommandStatsResponse
    {
        [JsonProperty("CommandStatsJSON")]
        public string CommandStatsJson { get; set; }
    }

    public class GetAllCommandStatsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class EnableNextHopResponse
    {
        public string ActiveNextHopDirectorAddress { get; set; }

        [JsonProperty("ActiveNextHopDirectorTCPPort")]
        public int ActiveNextHopDirectorTcpPort { get; set; }

        [JsonProperty("ActiveNextHopDirectorUsesHTTPS")]
        public bool ActiveNextHopDirectorUsesHttps { get; set; }

        [JsonProperty("ActiveNextHopDirectorURL")]
        public string ActiveNextHopDirectorUrl { get; set; }
    }

    public class EnableNextHopInput
    {
        public string NextHopDirectorAddress { get; set; }

        [JsonProperty("NextHopDirectorTCPPort", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? NextHopDirectorTcpPort { get; set; } = 8002;

        [JsonProperty("NextHopDirectorUsesHTTPS", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NextHopDirectorUsesHttps { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NextHopDirectorAddressIsLocalhostname { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NextHopDirectorAddressIsHostname { get; set; } = false;

        [JsonProperty("NextHopDirectorAddressIsFQDN", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NextHopDirectorAddressIsFqdn { get; set; } = false;

        [JsonProperty("IncrementNextHopDirectorTCPPortBySessionId", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncrementNextHopDirectorTcpPortBySessionId { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DisableBeforeEnable { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckNextHopDirectorIsRunning { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckNextHopAgentIsRunning { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NextHopDirectorAddressIsNamedPipe { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class DisableNextHopInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetNextHopStatusResponse
    {
        public bool NextHopEnabled { get; set; }
        public string ActiveNextHopDirectorAddress { get; set; }

        [JsonProperty("ActiveNextHopDirectorTCPPort")]
        public int ActiveNextHopDirectorTcpPort { get; set; }

        [JsonProperty("ActiveNextHopDirectorUsesHTTPS")]
        public bool ActiveNextHopDirectorUsesHttps { get; set; }
        public bool ActiveNextHopDirectorIsRunning { get; set; }

        [JsonProperty("ActiveNextHopDirectorURL")]
        public string ActiveNextHopDirectorUrl { get; set; }
        public bool ActiveNextHopAgentIsRunning { get; set; }
    }

    public class GetNextHopStatusInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckNextHopDirectorIsRunning { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CheckNextHopAgentIsRunning { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class WaitForNextHopSessionToConnectResponse
    {
        public bool NextHopSessionConnected { get; set; }
    }

    public class WaitForNextHopSessionToConnectInput
    {
        public string NextHopDirectorAddress { get; set; }

        [JsonProperty("NextHopDirectorTCPPort", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? NextHopDirectorTcpPort { get; set; } = 8002;

        [JsonProperty("NextHopDirectorUsesHTTPS", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NextHopDirectorUsesHttps { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NextHopDirectorAddressIsLocalhostname { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NextHopDirectorAddressIsHostname { get; set; } = false;

        [JsonProperty("NextHopDirectorAddressIsFQDN", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NextHopDirectorAddressIsFqdn { get; set; } = false;

        [JsonProperty("IncrementNextHopDirectorTCPPortBySessionId", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncrementNextHopDirectorTcpPortBySessionId { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? SecondsToWait { get; set; } = 35;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NextHopDirectorAddressIsNamedPipe { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DisableExistingNextHop { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ConfigureNextHopDirectorInput
    {
        [JsonProperty("SOAPEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SoapEnabled { get; set; } = false;

        [JsonProperty("RESTEnabled", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RestEnabled { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? WebServerEnabled { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DirectorIsLocalhostOnly { get; set; } = true;

        [JsonProperty("SOAPTCPPort", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SoapTcpPort { get; set; } = 8002;

        [JsonProperty("RESTTCPPort", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? RestTcpPort { get; set; } = 8002;

        [JsonProperty("SOAPUsesHTTPS", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SoapUsesHttps { get; set; } = false;

        [JsonProperty("RESTUsesHTTPS", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RestUsesHttps { get; set; } = false;

        [JsonProperty("IncrementDirectorTCPPortBySessionId", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncrementDirectorTcpPortBySessionId { get; set; } = true;

        [JsonProperty("SOAPUsesUserAuthentication", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SoapUsesUserAuthentication { get; set; } = false;

        [JsonProperty("RESTUsesUserAuthentication", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RestUsesUserAuthentication { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CommandNamedPipeEnabled { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ResetNextHopDirectorSettingsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class WorkflowCompletedInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RaiseExceptionResponse
    {
        public bool RaiseExceptionResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class RaiseExceptionInput
    {
        public string InputException { get; set; }
        public string ExceptionMessage { get; set; }
    }

    public class UpdateOrchestratorFlowStatsResultResponse
    {
        public bool UpdateOrchestratorFlowStatsResultResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class UpdateOrchestratorFlowStatsResultInput
    {
        public bool? FlowLastActionSuccess { get; set; }
        public string FlowLastActionErrorMessage { get; set; }
        public int? FlowLastActionCode { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetLastFailedActionFromOrchestratorFlowStatsResponse
    {
        public bool WorkerAllocatedToFlowRun { get; set; }
        public bool LastActionFailed { get; set; }
        public string LastFailedActionRequestPath { get; set; }
        public string LastFailedActionErrorMessage { get; set; }
    }

    public class GetLastFailedActionFromOrchestratorFlowStatsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetOrchestratorFlowStatsResponse
    {
        [JsonProperty("OrchestratorFlowStatsJSON")]
        public string OrchestratorFlowStatsJson { get; set; }
        public int NumberOfOrchestratorFlowStats { get; set; }
    }

    public class GetOrchestratorFlowStatsInput
    {
        public int? WithinLastNumberOfDays { get; set; }
        public string SearchFlowName { get; set; }
        public bool? SearchFlowLastActionResult { get; set; }
        public string SearchFlowStartTimeStartWindow { get; set; }
        public string SearchFlowStartTimeEndWindow { get; set; }
    }

    public class GetOrchestratorWorkerAvailabilityStatsResponse
    {
        [JsonProperty("WorkerAvailabilityStatsJSON")]
        public string WorkerAvailabilityStatsJson { get; set; }
        public int NumberOfWorkerAvailabilityStats { get; set; }
    }

    public class GetOrchestratorWorkerAvailabilityStatsInput
    {
        public int? WithinLastNumberOfDays { get; set; }
        public string SearchFlowName { get; set; }
        public string SearchFlowStartTimeStartWindow { get; set; }
    }

    public class GetOrchestratorWorkerFlowUsageHeatmapResponse
    {
        [JsonProperty("WorkerFlowUsageHeatmapJSON")]
        public string WorkerFlowUsageHeatmapJson { get; set; }
        public int NumberOfWorkerFlowUsageHeatmapItems { get; set; }
    }

    public class GetOrchestratorWorkerFlowUsageHeatmapInput
    {
        public GetOrchestratorWorkerFlowUsageHeatmapInput(string searchStartDateStartWindow, string searchStartDateEndWindow)
        {
            this.SearchStartDateStartWindow = searchStartDateStartWindow;
            this.SearchStartDateEndWindow = searchStartDateEndWindow;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchStartDateStartWindow { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SearchStartDateEndWindow { get; set; }

        [JsonProperty("TimeZoneMinutesOffsetFromUTC", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? TimeZoneMinutesOffsetFromUtc { get; set; } = 0;
        public string WorkerNames { get; set; }
    }

    public class GetOrchestratorLoginHistoryResponse
    {
        [JsonProperty("OrchestratorLoginHistoryJSON")]
        public string OrchestratorLoginHistoryJson { get; set; }
        public int NumberOfOrchestratorLogins { get; set; }
    }

    public class GetOrchestratorLoginHistoryInput
    {
        public int? WithinLastNumberOfDays { get; set; }
        public string SearchByEmail { get; set; }
        public string SearchLoginHistoryTimeStartWindow { get; set; }
        public string SearchLoginHistoryTimeEndWindow { get; set; }
    }

    public class SetLocalLoggingLevelInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int LoggingLevel { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RunCommandResponse
    {
        [JsonProperty("OutputJSON")]
        public string OutputJson { get; set; }
    }

    public class RunCommandInput
    {
        public RunCommandInput(string commandName)
        {
            this.CommandName = commandName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CommandName { get; set; }

        [JsonProperty("InputJSON")]
        public string InputJson { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetLocalLoggingLevelResponse
    {
        public int LoggingLevel { get; set; }

        [JsonProperty("IAConnectDirectorLogFilename")]
        public string IAConnectDirectorLogFileName { get; set; }
    }

    public class GetLocalLoggingLevelInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetRemoteClientTypeResponse
    {
        public string RemoteClientType { get; set; }
        public bool VirtualChannelConnected { get; set; }
        public string DirectorVersion { get; set; }
        public string DirectorReleaseVersion { get; set; }
        public string AgentVersion { get; set; }
        public string AgentReleaseVersion { get; set; }
        public bool AgentIsLicensed { get; set; }
        public string AgentLicenseFeatures { get; set; }
        public string DirectorHostname { get; set; }

        [JsonProperty("DirectorNetBIOSDomainName")]
        public string DirectorNetBiosDomainName { get; set; }

        [JsonProperty("DirectorDNSDomainName")]
        public string DirectorDnsDomainName { get; set; }
        public bool AttachedToNextHopDirector { get; set; }
        public string NextHopDirectorSessionType { get; set; }
    }

    public class GetRemoteClientTypeInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetIAConnectDirectorInfoResponse
    {
        public string IAConnectDirectorVersion { get; set; }

        [JsonProperty("DotNetCLRVersion")]
        public string DotNetClrVersion { get; set; }

        [JsonProperty("IAConnectDirectorRunAsUsername")]
        public string IAConnectDirectorRunAsUserName { get; set; }
        public string IAConnectDirectorRunAsUserdomain { get; set; }
        public string IAConnectDirectorPath { get; set; }
        public bool IAConnectDirectorIs64bitProcess { get; set; }
        public string IAConnectDirectorReleaseVersion { get; set; }

        [JsonProperty("IAConnectDirectorLogFilename")]
        public string IAConnectDirectorLogFileName { get; set; }
    }

    public class GetIAConnectDirectorInfoInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetAvailableIAConnectSessionsResponse
    {
        [JsonProperty("IAConnectSessionsJSON")]
        public string IAConnectSessionsJson { get; set; }
        public int NumberOfIAConnectSessions { get; set; }
        public int NumberOfLocalIAConnectSessions { get; set; }

        [JsonProperty("NumberOfCitrixICAIAConnectSessions")]
        public int NumberOfCitrixIcaiaConnectSessions { get; set; }

        [JsonProperty("NumberOfMicrosoftRDPIAConnectSessions")]
        public int NumberOfMicrosoftRdpiaConnectSessions { get; set; }
    }

    public class GetAvailableIAConnectSessionsInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AttachToIAConnectSessionByNameInput
    {
        public AttachToIAConnectSessionByNameInput(string iaConnectSessionName)
        {
            this.IAConnectSessionName = iaConnectSessionName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string IAConnectSessionName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? VirtualChannelMustBeConnected { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AttachToTier1IAConnectSessionResponse
    {
        public string AttachedTier1IAConnectSessionName { get; set; }
    }

    public class AttachToTier1IAConnectSessionInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? VirtualChannelMustBeConnected { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AttachToIAConnectSessionByIndexResponse
    {
        public string AttachedIAConnectSessionName { get; set; }
        public bool AttachedToSession { get; set; }
    }

    public class AttachToIAConnectSessionByIndexInput
    {
        public AttachToIAConnectSessionByIndexInputSearchIAConnectSessionTypeType? SearchIAConnectSessionType { get; set; }
        public int? SearchIAConnectSessionIndex { get; set; }
        public int? TimeToWaitInSeconds { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfTimedout { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? VirtualChannelMustBeConnected { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyCountSessionsNotSeenBefore { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AttachToIAConnectSessionByIndexInputSearchIAConnectSessionTypeType
    {
        [EnumMember(Value = "Local Agent")]
        LocalAgent,
        [EnumMember(Value = "Microsoft RDP")]
        MicrosoftRdp,
        [EnumMember(Value = "Citrix ICA")]
        CitrixIca,
        Remote
    }

    public class AttachToMostRecentIAConnectSessionResponse
    {
        public string AttachedIAConnectSessionName { get; set; }
        public bool AttachedToSession { get; set; }
    }

    public class AttachToMostRecentIAConnectSessionInput
    {
        public AttachToMostRecentIAConnectSessionInputSearchIAConnectSessionTypeType? SearchIAConnectSessionType { get; set; }
        public int? TimeToWaitInSeconds { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfTimedout { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? VirtualChannelMustBeConnected { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyCountSessionsNotSeenBefore { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AttachToMostRecentIAConnectSessionInputSearchIAConnectSessionTypeType
    {
        [EnumMember(Value = "Local Agent")]
        LocalAgent,
        [EnumMember(Value = "Microsoft RDP")]
        MicrosoftRdp,
        [EnumMember(Value = "Citrix ICA")]
        CitrixIca,
        Remote
    }

    public class GetDirectorUpTimeResponse
    {
        public int UpTimeInSeconds { get; set; }
    }

    public class GetDirectorUpTimeInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class DoesIAConnectSessionExistByNameResponse
    {
        public bool IAConnectSessionExists { get; set; }
    }

    public class DoesIAConnectSessionExistByNameInput
    {
        public DoesIAConnectSessionExistByNameInput(string iaConnectSessionName)
        {
            this.IAConnectSessionName = iaConnectSessionName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string IAConnectSessionName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class WaitForIAConnectSessionToCloseByNameResponse
    {
        public bool IAConnectSessionClosed { get; set; }
        public string AttachedTier1IAConnectSessionName { get; set; }
    }

    public class WaitForIAConnectSessionToCloseByNameInput
    {
        public WaitForIAConnectSessionToCloseByNameInput(string iaConnectSessionName)
        {
            this.IAConnectSessionName = iaConnectSessionName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string IAConnectSessionName { get; set; }
        public int? TimeToWaitInSeconds { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfTimedout { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AttachToTier1IAConnectSessionOnSuccess { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class KillIAConnectSessionByNameResponse
    {
        public bool IAConnectSessionKilled { get; set; }
        public string AttachedTier1IAConnectSessionName { get; set; }
    }

    public class KillIAConnectSessionByNameInput
    {
        public KillIAConnectSessionByNameInput(string iaConnectSessionName)
        {
            this.IAConnectSessionName = iaConnectSessionName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string IAConnectSessionName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AttachToTier1IAConnectSessionOnSuccess { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SetAgentGlobalCoordinateConfigurationResponse
    {
        public bool SetAgentGlobalCoordinateConfigurationResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class SetAgentGlobalCoordinateConfigurationInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetAgentGlobalCoordinateConfigurationInputMultiMonitorFunctionalityType? MultiMonitorFunctionality { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.SetAgentGlobalCoordinateConfigurationInputMultiMonitorFunctionalityType.NotSet;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetAgentGlobalCoordinateConfigurationInputAutoSetMouseInspectionMultiplierType? AutoSetMouseInspectionMultiplier { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.SetAgentGlobalCoordinateConfigurationInputAutoSetMouseInspectionMultiplierType.NotSet;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetAgentGlobalCoordinateConfigurationInputAutoSetGlobalMouseMultiplierType? AutoSetGlobalMouseMultiplier { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.SetAgentGlobalCoordinateConfigurationInputAutoSetGlobalMouseMultiplierType.NotSet;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? MouseInspectionXMultiplier { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? MouseInspectionYMultiplier { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? GlobalMouseXMultiplier { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public double? GlobalMouseYMultiplier { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? GlobalMouseMultiplierApplyToMouseEvent { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? GlobalMouseMultiplierApplyToSetCursorPos { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? GlobalMouseMultiplierApplyToCurrentMouseMoveMethod { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public SetAgentGlobalCoordinateConfigurationInputJavaCoordinateSystemType? JavaCoordinateSystem { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.SetAgentGlobalCoordinateConfigurationInputJavaCoordinateSystemType.NotSet;

        [JsonProperty("SAPGUICoordinateSystem", DefaultValueHandling = DefaultValueHandling.Include)]
        public SetAgentGlobalCoordinateConfigurationInputSapguiCoordinateSystemType? SapguiCoordinateSystem { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.SetAgentGlobalCoordinateConfigurationInputSapguiCoordinateSystemType.NotSet;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetAgentGlobalCoordinateConfigurationInputMultiMonitorFunctionalityType
    {
        NotSet,
        [EnumMember(Value = "PrimaryMonitor")]
        PrimaryDisplayOnly,
        [EnumMember(Value = "MultiMonitor")]
        AllDisplays
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetAgentGlobalCoordinateConfigurationInputAutoSetMouseInspectionMultiplierType
    {
        [EnumMember(Value = "Auto")]
        Automatic,
        Manual,
        NotSet
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetAgentGlobalCoordinateConfigurationInputAutoSetGlobalMouseMultiplierType
    {
        [EnumMember(Value = "Auto")]
        Automatic,
        Manual,
        NotSet
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetAgentGlobalCoordinateConfigurationInputJavaCoordinateSystemType
    {
        NotSet,
        Virtual,
        Physical
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SetAgentGlobalCoordinateConfigurationInputSapguiCoordinateSystemType
    {
        NotSet,
        Virtual,
        Physical
    }

    public class GetAgentGlobalCoordinateConfigurationResponse
    {
        public string MultiMonitorFunctionality { get; set; }
        public bool AutoSetMouseInspectionMultiplier { get; set; }
        public bool AutoSetGlobalMouseMultiplier { get; set; }
        public double MouseInspectionXMultiplier { get; set; }
        public double MouseInspectionYMultiplier { get; set; }
        public double GlobalMouseXMultiplier { get; set; }
        public double GlobalMouseYMultiplier { get; set; }
        public string GlobalMouseMoveMethod { get; set; }
        public string JavaCoordinateSystem { get; set; }

        [JsonProperty("SAPGUICoordinateSystem")]
        public string SapguiCoordinateSystem { get; set; }
    }

    public class GetAgentGlobalCoordinateConfigurationInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetAgentThreadStatusResponse
    {
        public bool ThreadStarted { get; set; }
        public bool ThreadRunning { get; set; }
        public bool ThreadCompleted { get; set; }
        public bool ThreadSuccess { get; set; }
        public int ThreadRuntimeInSeconds { get; set; }
        public string IAConnectActionName { get; set; }
        public string ThreadStatusMessage { get; set; }
        public string ThreadErrorMessage { get; set; }

        [JsonProperty("ThreadOutputJSON")]
        public string ThreadOutputJson { get; set; }
    }

    public class GetAgentThreadStatusInput
    {
        public GetAgentThreadStatusInput(int threadId)
        {
            this.ThreadId = threadId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ThreadId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RetrieveThreadOutputData { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ClearOutputDataFromMemoryOnceRead { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class WaitForAgentThreadToCompleteSuccessfullyResponse
    {
        public bool ThreadStarted { get; set; }
        public bool ThreadRunning { get; set; }
        public bool ThreadCompleted { get; set; }
        public bool ThreadSuccess { get; set; }
        public int ThreadRuntimeInSeconds { get; set; }
        public string IAConnectActionName { get; set; }
        public string ThreadStatusMessage { get; set; }
        public string ThreadErrorMessage { get; set; }

        [JsonProperty("ThreadOutputJSON")]
        public string ThreadOutputJson { get; set; }
    }

    public class WaitForAgentThreadToCompleteSuccessfullyInput
    {
        public WaitForAgentThreadToCompleteSuccessfullyInput(int threadId, int secondsToWaitForThread)
        {
            this.ThreadId = threadId;
            this.SecondsToWaitForThread = secondsToWaitForThread;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ThreadId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int SecondsToWaitForThread { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RetrieveThreadOutputData { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ClearOutputDataFromMemoryOnceRead { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfThreadNotCompleted { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfThreadError { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? SecondsToWaitPerCall { get; set; } = 5;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetAgentThreadsResponse
    {
        public int NumberOfAgentThreads { get; set; }
        public GetAgentThreadsResponseAgentThreadsTypeItem[] AgentThreads { get; set; }
    }

    public class GetAgentThreadsResponseAgentThreadsTypeItem
    {
        public int ThreadId { get; set; }
        public string IAConnectActionName { get; set; }

        [JsonProperty("ThreadStartDateTimeUTC")]
        public string ThreadStartDateTimeUtc { get; set; }

        [JsonProperty("ThreadCompletedDateTimeUTC")]
        public string ThreadCompletedDateTimeUtc { get; set; }
        public int ThreadRuntimeInSeconds { get; set; }
        public bool ThreadStarted { get; set; }
        public bool ThreadRunning { get; set; }
        public bool ThreadCompleted { get; set; }
        public bool ThreadSuccess { get; set; }
        public string ThreadStatusMessage { get; set; }
        public string ThreadErrorMessage { get; set; }
    }

    public class GetAgentThreadsInput
    {
        public GetAgentThreadsInputSortOrderType? SortOrder { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetAgentThreadsInputSortOrderType
    {
        None,
        ThreadStartTime,
        [EnumMember(Value = "ThreadStartTime_Desc")]
        ThreadStartTimeDescending,
        ThreadEndTime,
        [EnumMember(Value = "ThreadEndTime_Desc")]
        ThreadEndTimeDescending,
        ThreadId,
        [EnumMember(Value = "ThreadId_Desc")]
        ThreadIdDescending,
        ThreadActionName,
        [EnumMember(Value = "ThreadActionName_Desc")]
        ThreadActionNameDescending,
        ThreadRuntime,
        [EnumMember(Value = "ThreadRuntime_Desc")]
        ThreadRuntimeDescending
    }

    public class KillAgentThreadResponse
    {
        public bool KillAgentThreadResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class KillAgentThreadInput
    {
        public KillAgentThreadInput(int threadId)
        {
            this.ThreadId = threadId;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int ThreadId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class DeleteAgentThreadResponse
    {
        public int NumberOfAgentThreadsDeleted { get; set; }
    }

    public class DeleteAgentThreadInput
    {
        public int? ThreadId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeleteAllAgentThreads { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfAgentThreadFailsToDelete { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AllocateWorkerFromOrchestratorResponse
    {
        public string WorkerNameAllocated { get; set; }
    }

    public class AllocateWorkerFromOrchestratorInput
    {
        public string WorkerTag { get; set; }
        public string WorkerName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? RaiseExceptionIfWorkerNotImmediatelyAvailable { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SetOrchestratorWorkerMaintenanceModeResponse
    {
        public bool SetOrchestratorWorkerMaintenanceModeResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class SetOrchestratorWorkerMaintenanceModeInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? WorkerId { get; set; } = 0;
        public string WorkerName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? MaintenanceMode { get; set; } = true;
    }

    public class CreateOrchestratorOneTimeSecretResponse
    {
        [JsonProperty("RetrievalURL")]
        public string RetrievalUrl { get; set; }
        public string RetrievalId { get; set; }
    }

    public class CreateOrchestratorOneTimeSecretInput
    {
        public CreateOrchestratorOneTimeSecretInput(string friendlyName)
        {
            this.FriendlyName = friendlyName;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FriendlyName { get; set; }
        public string SecretValue { get; set; }
        public string RetrievalPhrase1 { get; set; }
        public string RetrievalPhrase2 { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaximumRetrievalsBeforeDeletion { get; set; } = 1;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SecretHasAStartDate { get; set; } = false;
        public string SecretStartDateTime { get; set; }
        public int? HoursUntilSecretStartTime { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SecretHasAnExpiryDate { get; set; } = false;
        public string SecretExpiryDateTime { get; set; }
        public int? HoursUntilSecretExpiry { get; set; }
    }

    public class GetListOfOrchestratorWorkersResponse
    {
        public GetListOfOrchestratorWorkersResponseOrchestratorWorkersTypeItem[] OrchestratorWorkers { get; set; }
        public int NumberOfOrchestratorWorkers { get; set; }
    }

    public class GetListOfOrchestratorWorkersResponseOrchestratorWorkersTypeItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CurrentFlowDisplayName { get; set; }
        public bool LiveStatus { get; set; }
        public int LiveStatusLastContactTicks { get; set; }
        public int SecondsSinceLastContact { get; set; }
        public bool MaintenanceMode { get; set; }
        public int Priority { get; set; }
        public bool AgentIsLicensed { get; set; }
        public bool IsAvailableForWork { get; set; }
    }

    public class GetListOfOrchestratorWorkersInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OnlyReturnLiveWorkers { get; set; } = false;
    }

    public class GetOrchestratorWorkerResponse
    {
        public int WorkerId { get; set; }
        public string WorkerName { get; set; }
        public string WorkerDescription { get; set; }
        public string CurrentFlowDisplayName { get; set; }
        public bool LiveStatus { get; set; }
        public int LiveStatusLastContactTicks { get; set; }
        public int SecondsSinceLastContact { get; set; }
        public bool MaintenanceMode { get; set; }
        public int Priority { get; set; }
        public int TimeoutInSeconds { get; set; }
        public bool AgentIsLicensed { get; set; }
        public string AgentLicenseFeatures { get; set; }
        public bool IsAvailableForWork { get; set; }
        public int WorkerConnectionTypeId { get; set; }
        public string WorkerConnectionTypeName { get; set; }
        public string DirectorRestApiUrl { get; set; }
        public string AzureServiceBusNamespace { get; set; }

        [JsonProperty("AzureWCFRelayName")]
        public string AzureWcfRelayName { get; set; }
        public string IAConnectAgentConnectionTypeName { get; set; }
        public bool AttachedToNextHopDirector { get; set; }
        public string NextHopDirectorSessionType { get; set; }
        public string DirectorVersion { get; set; }
        public string AgentVersion { get; set; }
        public double DirectorReleaseVersion { get; set; }
        public double AgentReleaseVersion { get; set; }
        public string DirectorHostname { get; set; }

        [JsonProperty("DirectorNetBIOSDomainName")]
        public string DirectorNetBiosDomainName { get; set; }

        [JsonProperty("DirectorDNSDomainName")]
        public string DirectorDnsDomainName { get; set; }
        public int SupportedFlowEnvironmentIdsCount { get; set; }
        public int SupportedFlowNamesCount { get; set; }
        public int UnsupportedFlowNamesCount { get; set; }
        public int WorkerTagsCount { get; set; }
        public int WorkerMandatoryTagsCount { get; set; }
    }

    public class GetOrchestratorWorkerInput
    {
        public int? SearchWorkerId { get; set; }
        public string SearchWorkerName { get; set; }
    }

    public class OrchestratorGetStatusResponse
    {
        public string OrchestratorVersion { get; set; }
        public int NumberOfStartupErrors { get; set; }
        public int UptimeInSeconds { get; set; }
    }

    public class OrchestratorGetWorkerAvailabilityStatusOverviewResponse
    {
        public int TotalWorkersCount { get; set; }
        public int AvailableWorkersCount { get; set; }
        public int UnavailableWorkersCount { get; set; }
        public int WorkersRunningFlowsCount { get; set; }
        public int WorkersInMaintenanceModeCount { get; set; }
        public int LiveWorkersCount { get; set; }
        public int LicensedWorkersCount { get; set; }
    }

    public class FileExistsResponse
    {
        public bool FileExists { get; set; }
    }

    public class FileExistsInput
    {
        public FileExistsInput(string fileName)
        {
            this.FileName = fileName;
        }

        [JsonProperty("Filename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class DirectoryExistsResponse
    {
        public bool DirectoryExists { get; set; }
    }

    public class DirectoryExistsInput
    {
        public DirectoryExistsInput(string directoryPath)
        {
            this.DirectoryPath = directoryPath;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DirectoryPath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class DeleteFileInput
    {
        public DeleteFileInput(string fileName)
        {
            this.FileName = fileName;
        }

        [JsonProperty("Filename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class DeleteDirectoryInput
    {
        public DeleteDirectoryInput(string directoryPath)
        {
            this.DirectoryPath = directoryPath;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DirectoryPath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Recursive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class PurgeDirectoryInput
    {
        public PurgeDirectoryInput(string directoryPath)
        {
            this.DirectoryPath = directoryPath;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DirectoryPath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Recursive { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? DeleteTopLevel { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class CopyFileInput
    {
        public CopyFileInput(string sourceFilePath, string destFilePath)
        {
            this.SourceFilePath = sourceFilePath;
            this.DestFilePath = destFilePath;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFilePath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestFilePath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class MoveFileInput
    {
        public MoveFileInput(string sourceFilePath, string destFilePath)
        {
            this.SourceFilePath = sourceFilePath;
            this.DestFilePath = destFilePath;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFilePath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DestFilePath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class CreateDirectoryInput
    {
        public CreateDirectoryInput(string directoryPath)
        {
            this.DirectoryPath = directoryPath;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DirectoryPath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ErrorIfAlreadyExists { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetFileSizeResponse
    {
        public int FileSize { get; set; }
    }

    public class GetFileSizeInput
    {
        public GetFileSizeInput(string fileName)
        {
            this.FileName = fileName;
        }

        [JsonProperty("Filename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class WriteTextFileInput
    {
        public WriteTextFileInput(string fileName)
        {
            this.FileName = fileName;
        }

        [JsonProperty("Filename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }
        public string TextToWrite { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AppendExistingFile { get; set; } = false;
        public WriteTextFileInputEncodingType? Encoding { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CreateFolderIfRequired { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WriteTextFileInputEncodingType
    {
        Unicode,
        [EnumMember(Value = "UTF8")]
        Utf8,
        [EnumMember(Value = "UTF7")]
        Utf7,
        [EnumMember(Value = "ASCII")]
        Ascii
    }

    public class ReadAllTextFromFileResponse
    {
        public string FileTextContents { get; set; }
    }

    public class ReadAllTextFromFileInput
    {
        public ReadAllTextFromFileInput(string fileName)
        {
            this.FileName = fileName;
        }

        [JsonProperty("Filename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FileName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetFilesResponse
    {
        [JsonProperty("FilesJSON")]
        public string FilesJson { get; set; }
        public int NumberOfFilesReadSuccessfully { get; set; }
        public int NumberOfFilesFailedToRead { get; set; }
    }

    public class GetFilesInput
    {
        public GetFilesInput(string directoryPath, string patternsCsv)
        {
            this.DirectoryPath = directoryPath;
            this.PatternsCsv = patternsCsv;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DirectoryPath { get; set; }

        [JsonProperty("PatternsCSV", DefaultValueHandling = DefaultValueHandling.Include)]
        public string PatternsCsv { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetFoldersResponse
    {
        [JsonProperty("FoldersJSON")]
        public string FoldersJson { get; set; }
        public int NumberOfFoldersReadSuccessfully { get; set; }
        public int NumberOfFoldersFailedToRead { get; set; }
    }

    public class GetFoldersInput
    {
        public GetFoldersInput(string directoryPath)
        {
            this.DirectoryPath = directoryPath;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DirectoryPath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class DeleteFilesResponse
    {
        public int NumberOfFilesDeleted { get; set; }
        public int NumberOfFilesFailedToDelete { get; set; }
    }

    public class DeleteFilesInput
    {
        public DeleteFilesInput(string directoryPath)
        {
            this.DirectoryPath = directoryPath;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DirectoryPath { get; set; }
        public string Pattern { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetDiskFreeSpaceResponse
    {
        public int FreeSpaceBytes { get; set; }
        public int FreeSpaceKB { get; set; }
        public int FreeSpaceMB { get; set; }
        public int FreeSpaceGB { get; set; }
    }

    public class GetDiskFreeSpaceInput
    {
        public GetDiskFreeSpaceInput(string driveLetter)
        {
            this.DriveLetter = driveLetter;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DriveLetter { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetListOfDrivesResponse
    {
        [JsonProperty("DrivesJSON")]
        public string DrivesJson { get; set; }
    }

    public class GetListOfDrivesInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class DirectoryIsAccessibleResponse
    {
        public bool DirectoryAccessible { get; set; }
        public bool DirectoryAccessUnauthorised { get; set; }
    }

    public class DirectoryIsAccessibleInput
    {
        public DirectoryIsAccessibleInput(string directoryPath)
        {
            this.DirectoryPath = directoryPath;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string DirectoryPath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetCsvTextAsCollectionResponse
    {
        [JsonProperty("CSVDataJSON")]
        public string CsvDataJson { get; set; }
    }

    public class GetCsvTextAsCollectionInput
    {
        public GetCsvTextAsCollectionInput(string csvFilePath)
        {
            this.CsvFilePath = csvFilePath;
        }

        [JsonProperty("CSVFilePath", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CsvFilePath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? FirstLineIsHeader { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? TrimHeaders { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AllowBlankRows { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExtendColumnsIfRequired { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class WriteCollectionToCsvFileResponse
    {
        [JsonProperty("WriteCollectionToCSVFileResult")]
        public bool WriteCollectionToCsvFileResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class WriteCollectionToCsvFileInput
    {
        public WriteCollectionToCsvFileInput(string csvFilePath)
        {
            this.CsvFilePath = csvFilePath;
        }

        public JToken[] InputTable { get; set; }

        [JsonProperty("InputTableJSON")]
        public string InputTableJson { get; set; }

        [JsonProperty("CSVFilePath", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CsvFilePath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public WriteCollectionToCsvFileInputOutputEncodingType? OutputEncoding { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.WriteCollectionToCsvFileInputOutputEncodingType.Utf8;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WriteCollectionToCsvFileInputOutputEncodingType
    {
        [EnumMember(Value = "UTF8")]
        Utf8,
        [EnumMember(Value = "UTF7")]
        Utf7,
        Unicode,
        [EnumMember(Value = "ASCII")]
        Ascii
    }

    public class SetOwnerOnFolderInput
    {
        public SetOwnerOnFolderInput(string folderPath, string userIdentity)
        {
            this.FolderPath = folderPath;
            this.UserIdentity = userIdentity;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderPath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserIdentity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class SetOwnerOnFileInput
    {
        public SetOwnerOnFileInput(string filePath, string userIdentity)
        {
            this.FilePath = filePath;
            this.UserIdentity = userIdentity;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FilePath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserIdentity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AddPermissionToFolderInput
    {
        public AddPermissionToFolderInput(string folderPath, string identity)
        {
            this.FolderPath = folderPath;
            this.Identity = identity;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderPath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public AddPermissionToFolderInputPermissionType Permission { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.AddPermissionToFolderInputPermissionType.Read;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ApplyToFolder { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ApplyToSubFolders { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ApplyToFiles { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Deny { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddPermissionToFolderInputPermissionType
    {
        Read,
        ReadAndExecute,
        Modify,
        FullControl
    }

    public class AddPermissionToFileInput
    {
        public AddPermissionToFileInput(string filePath, string identity)
        {
            this.FilePath = filePath;
            this.Identity = identity;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FilePath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identity { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public AddPermissionToFileInputPermissionType Permission { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.AddPermissionToFileInputPermissionType.Read;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Deny { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AddPermissionToFileInputPermissionType
    {
        Read,
        ReadAndExecute,
        Modify,
        FullControl
    }

    public class BreakFolderSecurityInheritanceInput
    {
        public BreakFolderSecurityInheritanceInput(string folderPath)
        {
            this.FolderPath = folderPath;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderPath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ConvertInheritedToExplicit { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class EnableFolderSecurityInheritanceInput
    {
        public EnableFolderSecurityInheritanceInput(string folderPath)
        {
            this.FolderPath = folderPath;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderPath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetFolderSecurityPermissionsResponse
    {
        [JsonProperty("SecurityPermissionsJSON")]
        public string SecurityPermissionsJson { get; set; }
    }

    public class GetFolderSecurityPermissionsInput
    {
        public GetFolderSecurityPermissionsInput(string folderPath)
        {
            this.FolderPath = folderPath;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderPath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetFileSecurityPermissionsResponse
    {
        [JsonProperty("SecurityPermissionsJSON")]
        public string SecurityPermissionsJson { get; set; }
    }

    public class GetFileSecurityPermissionsInput
    {
        public GetFileSecurityPermissionsInput(string filePath)
        {
            this.FilePath = filePath;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FilePath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RemoveIdentityFromFolderSecurityResponse
    {
        public bool PermissionWasRemoved { get; set; }
    }

    public class RemoveIdentityFromFolderSecurityInput
    {
        public RemoveIdentityFromFolderSecurityInput(string folderPath, string identityToRemove)
        {
            this.FolderPath = folderPath;
            this.IdentityToRemove = identityToRemove;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FolderPath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string IdentityToRemove { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class RemoveIdentityFromFileSecurityResponse
    {
        public bool PermissionWasRemoved { get; set; }
    }

    public class RemoveIdentityFromFileSecurityInput
    {
        public RemoveIdentityFromFileSecurityInput(string filePath, string identityToRemove)
        {
            this.FilePath = filePath;
            this.IdentityToRemove = identityToRemove;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FilePath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string IdentityToRemove { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class CopyFileFromClientToServerInput
    {
        public CopyFileFromClientToServerInput(string clientFilePath, string serverFilePath)
        {
            this.ClientFilePath = clientFilePath;
            this.ServerFilePath = serverFilePath;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ClientFilePath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string ServerFilePath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Compress { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class ReplaceVariableDataInIniFileInput
    {
        public ReplaceVariableDataInIniFileInput(string inputFileName)
        {
            this.InputFileName = inputFileName;
        }

        [JsonProperty("InputFilename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InputFileName { get; set; }

        [JsonProperty("OutputFilename")]
        public string OutputFileName { get; set; }
        public string SearchSection { get; set; }
        public string SearchVariable { get; set; }
        public string ReplaceData { get; set; }

        [JsonProperty("InputFilenameEncoding")]
        public string InputFileNameEncoding { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? CreateNewFileIfNotExists { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? WriteSpaceBeforeEquals { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? WriteSpaceAfterEquals { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class DownloadHttpFileResponse
    {
        public string DownloadFileContents { get; set; }
    }

    public class DownloadHttpFileInput
    {
        public DownloadHttpFileInput(string downloadUrl)
        {
            this.DownloadUrl = downloadUrl;
        }

        [JsonProperty("DownloadURL", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DownloadUrl { get; set; }

        [JsonProperty("SaveFilename")]
        public string SaveFileName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? OverwriteExistingFile { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? PassthroughAuthentication { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserAgent { get; set; } = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.193 Safari/537.36";

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Accept { get; set; } = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";

        [JsonProperty("SupportTLS10", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SupportTls10 { get; set; } = true;

        [JsonProperty("SupportTLS11", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SupportTls11 { get; set; } = true;

        [JsonProperty("SupportTLS12", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? SupportTls12 { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDecompressDeflate { get; set; } = true;

        [JsonProperty("AutoDecompressGZIP", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AutoDecompressGzip { get; set; } = true;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ReturnContentsAsString { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public DownloadHttpFileInputReturnContentEncodingType? ReturnContentEncoding { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession.DownloadHttpFileInputReturnContentEncodingType.Utf8;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DownloadHttpFileInputReturnContentEncodingType
    {
        [EnumMember(Value = "ASCII")]
        Ascii,
        [EnumMember(Value = "UTF7")]
        Utf7,
        [EnumMember(Value = "UTF8")]
        Utf8,
        [EnumMember(Value = "UTF16")]
        Utf16,
        [EnumMember(Value = "UTF16BE")]
        Utf16BE
    }

    public class UnZipFileResponse
    {
        public int FilesExtractedSuccessfully { get; set; }
        public int FilesFailedToExtract { get; set; }
        public int FilesExcluded { get; set; }
    }

    public class UnZipFileInput
    {
        public UnZipFileInput(string zipFileName)
        {
            this.ZipFileName = zipFileName;
        }

        [JsonProperty("ZIPFilename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ZipFileName { get; set; }
        public string ExtractFolder { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExtractAllFilesToSingleFolder { get; set; } = false;
        public string IncludeFilesRegEx { get; set; }
        public string ExcludeFilesRegEx { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AddFileToZipInput
    {
        public AddFileToZipInput(string sourceFileNameToAddToZip, string outputZipFileName)
        {
            this.SourceFileNameToAddToZip = sourceFileNameToAddToZip;
            this.OutputZipFileName = outputZipFileName;
        }

        [JsonProperty("SourceFilenameToAddToZIP", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFileNameToAddToZip { get; set; }

        [JsonProperty("OutputZIPFilename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OutputZipFileName { get; set; }

        [JsonProperty("AddFilenameToFolderInZIP")]
        public string AddFileNameToFolderInZip { get; set; }

        [JsonProperty("SourceFilenameToAddToZIPComment")]
        public string SourceFileNameToAddToZipComment { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Compress { get; set; } = true;

        [JsonProperty("AddToExistingZIPFile", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AddToExistingZipFile { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class AddFolderToZipResponse
    {
        public int FilesAddedSuccessfully { get; set; }
        public int FilesExcluded { get; set; }
    }

    public class AddFolderToZipInput
    {
        public AddFolderToZipInput(string sourceFolderToAddToZip, string outputZipFileName)
        {
            this.SourceFolderToAddToZip = sourceFolderToAddToZip;
            this.OutputZipFileName = outputZipFileName;
        }

        [JsonProperty("SourceFolderToAddToZIP", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SourceFolderToAddToZip { get; set; }

        [JsonProperty("OutputZIPFilename", DefaultValueHandling = DefaultValueHandling.Include)]
        public string OutputZipFileName { get; set; }

        [JsonProperty("AddFilesToFolderInZIP")]
        public string AddFilesToFolderInZip { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Compress { get; set; } = true;

        [JsonProperty("AddToExistingZIPFile", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? AddToExistingZipFile { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeSubfolders { get; set; } = true;
        public string IncludeFilesRegEx { get; set; }
        public string ExcludeFilesRegEx { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }

    public class GetFileContentsAsBase64Response
    {
        public string FileContentsAsBase64 { get; set; }
    }

    public class GetFileContentsAsBase64Input
    {
        public GetFileContentsAsBase64Input(string filePath)
        {
            this.FilePath = filePath;
        }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FilePath { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Compress { get; set; } = false;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int? MaxFileSize { get; set; } = 1024000;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Workflow { get; set; } = "@{workflow()}";
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectsession;

    public partial class WorkflowManagedActions
    {
        public IaconnectsessionActions Iaconnectsession(string connectionId) => new IaconnectsessionActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IaconnectsessionTriggers Iaconnectsession(string connectionId) => new IaconnectsessionTriggers(connectionId);
    }
}